# PrivatePublicContext.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`3A6D7241D9CC82F8231763A53E32F9EC303A2AB1C34D17C3ECBDDF47A626D655`。来源：[源码](../../PrivatePublicContext.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.PrivatePublicContext`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-6854ea57c49e"></a>

## `NationalSpire.PrivatePublicContext.Human(NationalSpire.CareerData) — private static string Human(CareerData d)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivatePublicContext.AppendCareerDetails(System.Text.StringBuilder, NationalSpire.CareerData, NationalSpire.CareerPerson, System.Collections.Generic.List<(int Start, int Length, string Group)>?)`](PrivateCareerContext.cs.md#symbol-12edc643ff32)；[`NationalSpire.PrivatePublicContext.Community(NationalSpire.CareerData, NationalSpire.CareerPerson, string, System.Collections.Generic.ISet<string>?, System.Collections.Generic.List<(string Id, string Text)>?, NationalSpire.CommunityMemorySearch.Request?)`](PrivatePublicContext.cs.md#symbol-58aebbb834b8)；[`NationalSpire.PrivatePublicContext.IsPlayer(NationalSpire.CareerData, string)`](PrivatePublicContext.cs.md#symbol-9d4f1ec3280e)；[`NationalSpire.PrivatePublicContext.Profiles(NationalSpire.CareerData, NationalSpire.CareerPerson, System.Collections.Generic.List<(int Start, int Length, string Group)>?)`](PrivatePublicContext.cs.md#symbol-d9c12bf4e41b)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.LocalHumanId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9d4f1ec3280e"></a>

## `NationalSpire.PrivatePublicContext.IsPlayer(NationalSpire.CareerData, string) — private static bool IsPlayer(CareerData d, string id)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`LastActivity(NationalSpire.CommunityPost)`](PrivatePublicContext.cs.md#symbol-a5f90f6e1a09)；[`NationalSpire.PrivatePublicContext.Name(NationalSpire.CareerData, string)`](PrivatePublicContext.cs.md#symbol-fb5bb85205d3)；[`NationalSpire.PrivatePublicContext.PostTexts(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CareerPerson, string, System.Collections.Generic.IEnumerable<NationalSpire.CommunityMemory>?, NationalSpire.CommunityMemorySearch.Request?)`](PrivatePublicContext.cs.md#symbol-0f3333edf327)；[`PlayerRelated(NationalSpire.CommunityPost)`](PrivatePublicContext.cs.md#symbol-33b430eaf173)

**调用：** [`NationalSpire.PrivatePublicContext.Human(NationalSpire.CareerData)`](PrivatePublicContext.cs.md#symbol-6854ea57c49e)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.LocalHumanId`；`NationalSpire.PrivatePublicContext.Human(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivatePublicContext.Human(NationalSpire.CareerData)`；输入表达式：`Human(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: id == Human(d)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-fb5bb85205d3"></a>

## `NationalSpire.PrivatePublicContext.Name(NationalSpire.CareerData, string) — private static string Name(CareerData d, string id)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Brief(string)`](PrivateCareerContext.cs.md#symbol-a3119017dbcc)；[`NationalSpire.PrivatePublicContext.AppendCareerDetails(System.Text.StringBuilder, NationalSpire.CareerData, NationalSpire.CareerPerson, System.Collections.Generic.List<(int Start, int Length, string Group)>?)`](PrivateCareerContext.cs.md#symbol-12edc643ff32)；[`NationalSpire.PrivatePublicContext.AppendClubDetails(System.Text.StringBuilder, NationalSpire.CareerData, NationalSpire.CareerClub, string, System.Collections.Generic.List<(int Start, int Length, string Group)>?)`](PrivateCareerContext.cs.md#symbol-7b4c2e1f7909)；[`NationalSpire.PrivatePublicContext.AppendRecentResults(System.Text.StringBuilder, NationalSpire.CareerData, NationalSpire.CareerPerson)`](PrivateCareerContext.cs.md#symbol-8c2348c334d4)；[`NationalSpire.PrivatePublicContext.PostTexts(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CareerPerson, string, System.Collections.Generic.IEnumerable<NationalSpire.CommunityMemory>?, NationalSpire.CommunityMemorySearch.Request?)`](PrivatePublicContext.cs.md#symbol-0f3333edf327)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.PrivatePublicContext.IsPlayer(NationalSpire.CareerData, string)`](PrivatePublicContext.cs.md#symbol-9d4f1ec3280e)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.PrivatePublicContext.IsPlayer(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: IsPlayer(d, id) ? CareerEngine.Name(d) : CareerEngine.DisplayName(d, id)`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(d)`；返回值紧邻使用处：`ConditionalExpressionSyntax: IsPlayer(d, id) ? CareerEngine.Name(d) : CareerEngine.DisplayName(d, id)`
- `NationalSpire.PrivatePublicContext.IsPlayer(NationalSpire.CareerData, string)`；输入表达式：`IsPlayer(d, id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: IsPlayer(d, id) ? CareerEngine.Name(d) : CareerEngine.DisplayName(d, id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e2ed83d703a9"></a>

## `NationalSpire.PrivatePublicContext.ActualAscension(NationalSpire.CareerResult) — private static int ActualAscension(CareerResult r)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivatePublicContext.AppendRecentResults(System.Text.StringBuilder, NationalSpire.CareerData, NationalSpire.CareerPerson)`](PrivateCareerContext.cs.md#symbol-8c2348c334d4)；[`NationalSpire.PrivatePublicContext.Profiles(NationalSpire.CareerData, NationalSpire.CareerPerson, System.Collections.Generic.List<(int Start, int Length, string Group)>?)`](PrivatePublicContext.cs.md#symbol-d9c12bf4e41b)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerResult.Ascension`；`NationalSpire.CareerResult.OfficialAscensionVerified`；`NationalSpire.CareerResult.PlayedAscension`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-90836101e931"></a>

## `NationalSpire.PrivatePublicContext.IdentityText(NationalSpire.CareerPerson) — public static string IdentityText(CareerPerson p)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.Persona(NationalSpire.CareerData, NationalSpire.CareerPerson, string, int?, int?, NationalSpire.PersonalityProfile?, int, System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>?)`](AiDiscussion.cs.md#symbol-92d85bbd4154)；[`NationalSpire.PrivateMessagePrompts.Compose(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn?)`](PrivateMessagePrompts.cs.md#symbol-e8c8e5f35407)；[`NationalSpire.PrivatePublicContext.CharacterProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](PrivatePublicContext.cs.md#symbol-9d0bf89294e6)；[`NationalSpire.SpireArbitration.Compose(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn)`](SpireArbitration.cs.md#symbol-6116255f39e7)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerPerson.Handle`；`NationalSpire.CareerPerson.Name`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9d0bf89294e6"></a>

## `NationalSpire.PrivatePublicContext.CharacterProfile(NationalSpire.CareerData, NationalSpire.CareerPerson) — public static object CharacterProfile(CareerData d, CareerPerson p)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)；[`NationalSpire.PrivateMessagePrompts.Compose(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn?)`](PrivateMessagePrompts.cs.md#symbol-e8c8e5f35407)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CharacterIdentity.Name(NationalSpire.CareerData, string)`](CharacterIdentity.cs.md#symbol-4d068357a08b)；[`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-54b1e9fa0cf0)；[`NationalSpire.IdentityGender.Of(NationalSpire.CareerData, string)`](IdentityGender.cs.md#symbol-961507352d98)；[`NationalSpire.PersonalityLibrary.PromptProfile(NationalSpire.PersonalityProfile)`](PersonalityLibrary.cs.md#symbol-cc24e5415a31)；[`NationalSpire.PrivatePublicContext.IdentityText(NationalSpire.CareerPerson)`](PrivatePublicContext.cs.md#symbol-90836101e931)；[`NationalSpire.SpireArbitration.Memory(NationalSpire.CareerData, NationalSpire.CareerPerson)`](SpireArbitration.cs.md#symbol-7208d87df58d)；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`

**字段、属性、事件及方法组引用：** `<anonymous type: string 官方仲裁记录, string 显示名称, string 游戏名, string 姓名, System.Collections.Generic.List<string> 曾用游戏名, string 性别, string 职业, string 国家或地区, string 所在地区, string 角色卡保存的背景介绍, string 性格概述, string 打法, object 性格, string 擅长角色, string 说话习惯, System.Collections.Generic.List<string> 身份, string 支持俱乐部, System.Collections.Generic.IEnumerable<string> 熟悉的人>.曾用游戏名`；`<anonymous type: string 官方仲裁记录, string 显示名称, string 游戏名, string 姓名, System.Collections.Generic.List<string> 曾用游戏名, string 性别, string 职业, string 国家或地区, string 所在地区, string 角色卡保存的背景介绍, string 性格概述, string 打法, object 性格, string 擅长角色, string 说话习惯, System.Collections.Generic.List<string> 身份, string 支持俱乐部, System.Collections.Generic.IEnumerable<string> 熟悉的人>.打法`；`<anonymous type: string 官方仲裁记录, string 显示名称, string 游戏名, string 姓名, System.Collections.Generic.List<string> 曾用游戏名, string 性别, string 职业, string 国家或地区, string 所在地区, string 角色卡保存的背景介绍, string 性格概述, string 打法, object 性格, string 擅长角色, string 说话习惯, System.Collections.Generic.List<string> 身份, string 支持俱乐部, System.Collections.Generic.IEnumerable<string> 熟悉的人>.官方仲裁记录`；`<anonymous type: string 官方仲裁记录, string 显示名称, string 游戏名, string 姓名, System.Collections.Generic.List<string> 曾用游戏名, string 性别, string 职业, string 国家或地区, string 所在地区, string 角色卡保存的背景介绍, string 性格概述, string 打法, object 性格, string 擅长角色, string 说话习惯, System.Collections.Generic.List<string> 身份, string 支持俱乐部, System.Collections.Generic.IEnumerable<string> 熟悉的人>.国家或地区`；`<anonymous type: string 官方仲裁记录, string 显示名称, string 游戏名, string 姓名, System.Collections.Generic.List<string> 曾用游戏名, string 性别, string 职业, string 国家或地区, string 所在地区, string 角色卡保存的背景介绍, string 性格概述, string 打法, object 性格, string 擅长角色, string 说话习惯, System.Collections.Generic.List<string> 身份, string 支持俱乐部, System.Collections.Generic.IEnumerable<string> 熟悉的人>.角色卡保存的背景介绍`；`<anonymous type: string 官方仲裁记录, string 显示名称, string 游戏名, string 姓名, System.Collections.Generic.List<string> 曾用游戏名, string 性别, string 职业, string 国家或地区, string 所在地区, string 角色卡保存的背景介绍, string 性格概述, string 打法, object 性格, string 擅长角色, string 说话习惯, System.Collections.Generic.List<string> 身份, string 支持俱乐部, System.Collections.Generic.IEnumerable<string> 熟悉的人>.擅长角色`；`<anonymous type: string 官方仲裁记录, string 显示名称, string 游戏名, string 姓名, System.Collections.Generic.List<string> 曾用游戏名, string 性别, string 职业, string 国家或地区, string 所在地区, string 角色卡保存的背景介绍, string 性格概述, string 打法, object 性格, string 擅长角色, string 说话习惯, System.Collections.Generic.List<string> 身份, string 支持俱乐部, System.Collections.Generic.IEnumerable<string> 熟悉的人>.身份`；`<anonymous type: string 官方仲裁记录, string 显示名称, string 游戏名, string 姓名, System.Collections.Generic.List<string> 曾用游戏名, string 性别, string 职业, string 国家或地区, string 所在地区, string 角色卡保存的背景介绍, string 性格概述, string 打法, object 性格, string 擅长角色, string 说话习惯, System.Collections.Generic.List<string> 身份, string 支持俱乐部, System.Collections.Generic.IEnumerable<string> 熟悉的人>.熟悉的人`；`<anonymous type: string 官方仲裁记录, string 显示名称, string 游戏名, string 姓名, System.Collections.Generic.List<string> 曾用游戏名, string 性别, string 职业, string 国家或地区, string 所在地区, string 角色卡保存的背景介绍, string 性格概述, string 打法, object 性格, string 擅长角色, string 说话习惯, System.Collections.Generic.List<string> 身份, string 支持俱乐部, System.Collections.Generic.IEnumerable<string> 熟悉的人>.说话习惯`；`<anonymous type: string 官方仲裁记录, string 显示名称, string 游戏名, string 姓名, System.Collections.Generic.List<string> 曾用游戏名, string 性别, string 职业, string 国家或地区, string 所在地区, string 角色卡保存的背景介绍, string 性格概述, string 打法, object 性格, string 擅长角色, string 说话习惯, System.Collections.Generic.List<string> 身份, string 支持俱乐部, System.Collections.Generic.IEnumerable<string> 熟悉的人>.所在地区`；`<anonymous type: string 官方仲裁记录, string 显示名称, string 游戏名, string 姓名, System.Collections.Generic.List<string> 曾用游戏名, string 性别, string 职业, string 国家或地区, string 所在地区, string 角色卡保存的背景介绍, string 性格概述, string 打法, object 性格, string 擅长角色, string 说话习惯, System.Collections.Generic.List<string> 身份, string 支持俱乐部, System.Collections.Generic.IEnumerable<string> 熟悉的人>.显示名称`；`<anonymous type: string 官方仲裁记录, string 显示名称, string 游戏名, string 姓名, System.Collections.Generic.List<string> 曾用游戏名, string 性别, string 职业, string 国家或地区, string 所在地区, string 角色卡保存的背景介绍, string 性格概述, string 打法, object 性格, string 擅长角色, string 说话习惯, System.Collections.Generic.List<string> 身份, string 支持俱乐部, System.Collections.Generic.IEnumerable<string> 熟悉的人>.姓名`；`<anonymous type: string 官方仲裁记录, string 显示名称, string 游戏名, string 姓名, System.Collections.Generic.List<string> 曾用游戏名, string 性别, string 职业, string 国家或地区, string 所在地区, string 角色卡保存的背景介绍, string 性格概述, string 打法, object 性格, string 擅长角色, string 说话习惯, System.Collections.Generic.List<string> 身份, string 支持俱乐部, System.Collections.Generic.IEnumerable<string> 熟悉的人>.性别`；`<anonymous type: string 官方仲裁记录, string 显示名称, string 游戏名, string 姓名, System.Collections.Generic.List<string> 曾用游戏名, string 性别, string 职业, string 国家或地区, string 所在地区, string 角色卡保存的背景介绍, string 性格概述, string 打法, object 性格, string 擅长角色, string 说话习惯, System.Collections.Generic.List<string> 身份, string 支持俱乐部, System.Collections.Generic.IEnumerable<string> 熟悉的人>.性格`；`<anonymous type: string 官方仲裁记录, string 显示名称, string 游戏名, string 姓名, System.Collections.Generic.List<string> 曾用游戏名, string 性别, string 职业, string 国家或地区, string 所在地区, string 角色卡保存的背景介绍, string 性格概述, string 打法, object 性格, string 擅长角色, string 说话习惯, System.Collections.Generic.List<string> 身份, string 支持俱乐部, System.Collections.Generic.IEnumerable<string> 熟悉的人>.性格概述`；`<anonymous type: string 官方仲裁记录, string 显示名称, string 游戏名, string 姓名, System.Collections.Generic.List<string> 曾用游戏名, string 性别, string 职业, string 国家或地区, string 所在地区, string 角色卡保存的背景介绍, string 性格概述, string 打法, object 性格, string 擅长角色, string 说话习惯, System.Collections.Generic.List<string> 身份, string 支持俱乐部, System.Collections.Generic.IEnumerable<string> 熟悉的人>.游戏名`；`<anonymous type: string 官方仲裁记录, string 显示名称, string 游戏名, string 姓名, System.Collections.Generic.List<string> 曾用游戏名, string 性别, string 职业, string 国家或地区, string 所在地区, string 角色卡保存的背景介绍, string 性格概述, string 打法, object 性格, string 擅长角色, string 说话习惯, System.Collections.Generic.List<string> 身份, string 支持俱乐部, System.Collections.Generic.IEnumerable<string> 熟悉的人>.支持俱乐部`；`<anonymous type: string 官方仲裁记录, string 显示名称, string 游戏名, string 姓名, System.Collections.Generic.List<string> 曾用游戏名, string 性别, string 职业, string 国家或地区, string 所在地区, string 角色卡保存的背景介绍, string 性格概述, string 打法, object 性格, string 擅长角色, string 说话习惯, System.Collections.Generic.List<string> 身份, string 支持俱乐部, System.Collections.Generic.IEnumerable<string> 熟悉的人>.职业`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.Biography`；`NationalSpire.CareerPerson.Character`；`NationalSpire.CareerPerson.Connections`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.Handle`；`NationalSpire.CareerPerson.HandleAliases`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Identities`；`NationalSpire.CareerPerson.Name`；`NationalSpire.CareerPerson.Personality`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CareerPerson.Region`；`NationalSpire.CareerPerson.Role`；`NationalSpire.CareerPerson.Style`；`NationalSpire.CareerPerson.SupportedClubId`；`NationalSpire.CareerPerson.Temperament`；`NationalSpire.CareerPerson.Voice`；`NationalSpire.CharacterIdentity.Name(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；`NationalSpire.IdentityGender.Of(NationalSpire.CareerData, string)`；`NationalSpire.PersonalityLibrary.PromptProfile(NationalSpire.PersonalityProfile)`；`NationalSpire.PrivatePublicContext.IdentityText(NationalSpire.CareerPerson)`；`NationalSpire.SpireArbitration.Memory(NationalSpire.CareerData, NationalSpire.CareerPerson)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: CareerEngine.Person(d, id) is { } known ? IdentityText(known) : CareerEngine.DisplayName(d, id)`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerEngine.Person(d, id) is { } known`
- `NationalSpire.CharacterIdentity.Name(NationalSpire.CareerData, string)`；输入表达式：`CharacterIdentity.Name(d, p.Character)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: 擅长角色 = CharacterIdentity.Name(d, p.Character)`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubName(d, p.SupportedClubId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: p.SupportedClubId.Length > 0 ? EsportsWorld.ClubName(d, p.SupportedClubId) : "未记录"`
- `NationalSpire.IdentityGender.Of(NationalSpire.CareerData, string)`；输入表达式：`IdentityGender.Of(d, p.Id)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: 性别 = IdentityGender.Of(d, p.Id)`
- `NationalSpire.PersonalityLibrary.PromptProfile(NationalSpire.PersonalityProfile)`；输入表达式：`PersonalityLibrary.PromptProfile(p.Personality)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: 性格 = PersonalityLibrary.PromptProfile(p.Personality)`
- `NationalSpire.PrivatePublicContext.IdentityText(NationalSpire.CareerPerson)`；输入表达式：`IdentityText(known)`；返回值紧邻使用处：`ConditionalExpressionSyntax: CareerEngine.Person(d, id) is { } known ? IdentityText(known) : CareerEngine.DisplayName(d, id)`
- `NationalSpire.SpireArbitration.Memory(NationalSpire.CareerData, NationalSpire.CareerPerson)`；输入表达式：`SpireArbitration.Memory(d, p)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: 官方仲裁记录 = SpireArbitration.Memory(d, p)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`p.Connections.Select(id => CareerEngine.Person(d, id) is { } known ? IdentityText(known) : CareerEngine.DisplayName(d, id))`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: 熟悉的人 = p.Connections.Select(id => CareerEngine.Person(d, id) is { } known ? IdentityText(known) : CareerEngine.DisplayName(d, id))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d9c12bf4e41b"></a>

## `NationalSpire.PrivatePublicContext.Profiles(NationalSpire.CareerData, NationalSpire.CareerPerson, System.Collections.Generic.List<(int Start, int Length, string Group)>?) — public static string Profiles(CareerData d, CareerPerson p, List<(int Start, int Length, string Group)>? changing = null)`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessagePrompts.Context(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-4b9d12b26f65)

**调用：** [`Awards(string, string)`](PrivatePublicContext.cs.md#symbol-7a9097f87102)；[`Club(string, string)`](PrivatePublicContext.cs.md#symbol-0073b473a0ab)；[`NationalSpire.CameoContent.StreakText(NationalSpire.CareerPerson)`](CameoContent.cs.md#symbol-4b0402048b3d)；[`NationalSpire.CareerCommerce.ActiveSponsor(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-aeb7e7ee6d76)；[`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CharacterIdentity.ForResult(NationalSpire.CareerResult)`](CharacterIdentity.cs.md#symbol-6c3ca5d0abad)；[`NationalSpire.CharacterIdentity.Name(NationalSpire.CareerData, string)`](CharacterIdentity.cs.md#symbol-4d068357a08b)；[`NationalSpire.ClubCoaching.Factor(NationalSpire.CareerPerson)`](ClubCoaching.cs.md#symbol-c0a761e9458d)；[`NationalSpire.ClubCoaching.IsCoach(NationalSpire.CareerPerson)`](ClubCoaching.cs.md#symbol-8b4ec414486e)；[`NationalSpire.ClubCoaching.PlayerCoach(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-26fb5cc468c4)；[`NationalSpire.ClubCoaching.PlayerFeatures(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-e30d7b812432)；[`NationalSpire.ClubCoaching.PlayerReserve(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-c5c2fb20bef5)；[`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-54b1e9fa0cf0)；[`NationalSpire.EsportsWorld.LicenseName(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-921c23662473)；[`NationalSpire.MatchRules.BaseChance(NationalSpire.CareerPerson, int)`](MatchRules.cs.md#symbol-4f16d2879002)；[`NationalSpire.MatchRules.ClearChance(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?)`](MatchRules.cs.md#symbol-a0517de2db43)；[`NationalSpire.MatchRules.Performance(bool, int, double?)`](MatchRules.cs.md#symbol-b38635e79223)；[`NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-871ad0e2a2c9)；[`NationalSpire.PersonalityLibrary.PromptProfile(NationalSpire.PersonalityProfile)`](PersonalityLibrary.cs.md#symbol-cc24e5415a31)；[`NationalSpire.PersonalityProfile.Dimensions()`](PersonalityLibrary.cs.md#symbol-2a59469d0196)；[`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`](PrivateAppointments.cs.md#symbol-1c549626b284)；[`NationalSpire.PrivatePublicContext.ActualAscension(NationalSpire.CareerResult)`](PrivatePublicContext.cs.md#symbol-e2ed83d703a9)；[`NationalSpire.PrivatePublicContext.AppendCareerDetails(System.Text.StringBuilder, NationalSpire.CareerData, NationalSpire.CareerPerson, System.Collections.Generic.List<(int Start, int Length, string Group)>?)`](PrivateCareerContext.cs.md#symbol-12edc643ff32)；[`NationalSpire.PrivatePublicContext.Human(NationalSpire.CareerData)`](PrivatePublicContext.cs.md#symbol-6854ea57c49e)；[`NationalSpire.PrivatePublicContext.WorldPoints(NationalSpire.CareerData, string)`](PrivateCareerContext.cs.md#symbol-7c9e041c472a)；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`string.Join<T>(string?, System.Collections.Generic.IEnumerable<T>)`；`string.StartsWith(string)`；`string.ToCharArray()`；`string.TrimEnd()`；`System.Collections.Generic.HashSet<T>.HashSet()`；`System.Collections.Generic.IEnumerable<int>.Max()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；`System.Text.Json.JsonSerializerOptions.JsonSerializerOptions()`；`System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；`System.Text.StringBuilder.AppendLine(string?)`；`System.Text.StringBuilder.StringBuilder()`；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `(string Title, bool Team).Team`；`(string Title, bool Team).Title`；`Awards(string, string)`；`Club(string, string)`；`NationalSpire.CameoContent.StreakText(NationalSpire.CareerPerson)`；`NationalSpire.CareerCommerce.ActiveSponsor(NationalSpire.CareerData)`；`NationalSpire.CareerData.AvatarHighestClear`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Draws`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Fans`；`NationalSpire.CareerData.LocalHumanId`；`NationalSpire.CareerData.Losses`；`NationalSpire.CareerData.PlayerCard`；`NationalSpire.CareerData.PlayerGender`；`NationalSpire.CareerData.PlayerIntroduction`；`NationalSpire.CareerData.PlayerIntroductionDay`；`NationalSpire.CareerData.PlayerNameAliases`；`NationalSpire.CareerData.Rating`；`NationalSpire.CareerData.Results`；`NationalSpire.CareerData.SelectedCharacter`；`NationalSpire.CareerData.Wins`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerHonor.Day`；`NationalSpire.CareerHonor.Id`；`NationalSpire.CareerHonor.Season`；`NationalSpire.CareerHonor.Title`；`NationalSpire.CareerPerson.AiIntroduction`；`NationalSpire.CareerPerson.Biography`；`NationalSpire.CareerPerson.Character`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.CustomClearChance`；`NationalSpire.CareerPerson.Form`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Identities`；`NationalSpire.CareerPerson.IntroductionDay`；`NationalSpire.CareerPerson.Losses`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.CareerPerson.Name`；`NationalSpire.CareerPerson.Personality`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CareerPerson.Rating`；`NationalSpire.CareerPerson.RecordedWinStreak`；`NationalSpire.CareerPerson.Region`；`NationalSpire.CareerPerson.Role`；`NationalSpire.CareerPerson.Style`；`NationalSpire.CareerPerson.SupportedClubId`；`NationalSpire.CareerPerson.Titles`；`NationalSpire.CareerPerson.Voice`；`NationalSpire.CareerPerson.Wins`；`NationalSpire.CareerResult.Ascension`；`NationalSpire.CareerResult.Day`；`NationalSpire.CareerResult.Event`；`NationalSpire.CareerResult.Floor`；`NationalSpire.CareerResult.Kind`；`NationalSpire.CareerResult.OfficialAscensionVerified`；`NationalSpire.CareerResult.Opponent`；`NationalSpire.CareerResult.OpponentId`；`NationalSpire.CareerResult.OpponentParticipants`；`NationalSpire.CareerResult.Outcome`；`NationalSpire.CareerResult.RunSeconds`；`NationalSpire.CareerResult.Win`；`NationalSpire.CharacterIdentity.ForResult(NationalSpire.CareerResult)`；`NationalSpire.CharacterIdentity.Name(NationalSpire.CareerData, string)`；`NationalSpire.ClubCoaching.Factor(NationalSpire.CareerPerson)`；`NationalSpire.ClubCoaching.IsCoach(NationalSpire.CareerPerson)`；`NationalSpire.ClubCoaching.PlayerCoach(NationalSpire.CareerData)`；`NationalSpire.ClubCoaching.PlayerFeatures(NationalSpire.CareerData)`；`NationalSpire.ClubCoaching.PlayerReserve(NationalSpire.CareerData)`；`NationalSpire.EsportsCareer.BestClear`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.EsportsCareer.Honors`；`NationalSpire.EsportsCareer.NationalTeam`；`NationalSpire.EsportsCareer.WinStreak`；`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.LicenseName(NationalSpire.CareerData)`；`NationalSpire.MatchRules.BaseChance(NationalSpire.CareerPerson, int)`；`NationalSpire.MatchRules.ClearChance(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?)`；`NationalSpire.MatchRules.Performance(bool, int, double?)`；`NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`；`NationalSpire.PersonalityLibrary.ProfileUsage`；`NationalSpire.PersonalityLibrary.PromptProfile(NationalSpire.PersonalityProfile)`；`NationalSpire.PersonalityProfile.Dimensions()`；`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；`NationalSpire.PrivatePublicContext.ActualAscension(NationalSpire.CareerResult)`；`NationalSpire.PrivatePublicContext.AppendCareerDetails(System.Text.StringBuilder, NationalSpire.CareerData, NationalSpire.CareerPerson, System.Collections.Generic.List<(int Start, int Length, string Group)>?)`；`NationalSpire.PrivatePublicContext.Human(NationalSpire.CareerData)`；`NationalSpire.PrivatePublicContext.WorldPoints(NationalSpire.CareerData, string)`；`NationalSpire.SponsorContract.Brand`；`NationalSpire.SponsorContract.Description`；`NationalSpire.SponsorContract.EndSeason`；`NationalSpire.SponsorContract.SignedDay`；`NationalSpire.SponsorContract.StartSeason`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Awards(string, string)`；输入表达式：`Awards(Human(d), player)`；返回值紧邻使用处：`ExpressionStatementSyntax: Awards(Human(d), player);`
- `Awards(string, string)`；输入表达式：`Awards(p.Id, p.PublicName)`；返回值紧邻使用处：`ExpressionStatementSyntax: Awards(p.Id, p.PublicName);`
- `Club(string, string)`；输入表达式：`Club(d.Esports.ClubId, player)`；返回值紧邻使用处：`ExpressionStatementSyntax: Club(d.Esports.ClubId, player);`
- `Club(string, string)`；输入表达式：`Club(p.ClubId, p.PublicName)`；返回值紧邻使用处：`ExpressionStatementSyntax: Club(p.ClubId, p.PublicName);`
- `NationalSpire.CameoContent.StreakText(NationalSpire.CareerPerson)`；输入表达式：`CameoContent.StreakText(p)`；返回值紧邻使用处：`InterpolationSyntax: {CameoContent.StreakText(p)}`
- `NationalSpire.CareerCommerce.ActiveSponsor(NationalSpire.CareerData)`；输入表达式：`CareerCommerce.ActiveSponsor(d)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerCommerce.ActiveSponsor(d) is { } sponsor`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.Name(d)`
- `NationalSpire.CharacterIdentity.ForResult(NationalSpire.CareerResult)`；输入表达式：`CharacterIdentity.ForResult(r)`；返回值紧邻使用处：`InterpolationSyntax: {CharacterIdentity.ForResult(r)}`
- `NationalSpire.CharacterIdentity.Name(NationalSpire.CareerData, string)`；输入表达式：`CharacterIdentity.Name(d, card.Character)`；返回值紧邻使用处：`InterpolationSyntax: {CharacterIdentity.Name(d, card.Character)}`
- `NationalSpire.CharacterIdentity.Name(NationalSpire.CareerData, string)`；输入表达式：`CharacterIdentity.Name(d, d.SelectedCharacter)`；返回值紧邻使用处：`InterpolationSyntax: {CharacterIdentity.Name(d, d.SelectedCharacter)}`
- `NationalSpire.ClubCoaching.Factor(NationalSpire.CareerPerson)`；输入表达式：`ClubCoaching.Factor(p)`；返回值紧邻使用处：`InterpolationSyntax: {ClubCoaching.Factor(p):0.#}`
- `NationalSpire.ClubCoaching.IsCoach(NationalSpire.CareerPerson)`；输入表达式：`ClubCoaching.IsCoach(p)`；返回值紧邻使用处：`IfStatementSyntax: if (ClubCoaching.IsCoach(p)) b.AppendLine($"{p.PublicName}担任俱乐部教练，不兼任选手；陪练系数×{ClubCoaching.Factor(p):0.#}。");`
- `NationalSpire.ClubCoaching.PlayerCoach(NationalSpire.CareerData)`；输入表达式：`ClubCoaching.PlayerCoach(d)`；返回值紧邻使用处：`ConditionalExpressionSyntax: ClubCoaching.PlayerCoach(d) ? "，兼任教练" : ""`
- `NationalSpire.ClubCoaching.PlayerFeatures(NationalSpire.CareerData)`；输入表达式：`ClubCoaching.PlayerFeatures(d)`；返回值紧邻使用处：`IfStatementSyntax: if (ClubCoaching.PlayerFeatures(d))              b.AppendLine($"{player}在俱乐部的岗位：{(ClubCoaching.PlayerReserve(d) ? "轮换" : "首发")}{(ClubCoaching.PlayerCoach(d) ? "，兼任教练" : "")}。");`
- `NationalSpire.ClubCoaching.PlayerReserve(NationalSpire.CareerData)`；输入表达式：`ClubCoaching.PlayerReserve(d)`；返回值紧邻使用处：`ConditionalExpressionSyntax: ClubCoaching.PlayerReserve(d) ? "轮换" : "首发"`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubName(d, card.SupportedClubId)`；返回值紧邻使用处：`InterpolationSyntax: {EsportsWorld.ClubName(d, card.SupportedClubId)}`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubName(d, d.Esports.ClubId)`；返回值紧邻使用处：`InterpolationSyntax: {EsportsWorld.ClubName(d, d.Esports.ClubId)}`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubName(d, p.ClubId)`；返回值紧邻使用处：`InterpolationSyntax: {EsportsWorld.ClubName(d, p.ClubId)}`
- `NationalSpire.EsportsWorld.LicenseName(NationalSpire.CareerData)`；输入表达式：`EsportsWorld.LicenseName(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: d.PlayerCard?.Role ?? EsportsWorld.LicenseName(d)`
- `NationalSpire.EsportsWorld.LicenseName(NationalSpire.CareerData)`；输入表达式：`EsportsWorld.LicenseName(d)`；返回值紧邻使用处：`InterpolationSyntax: {EsportsWorld.LicenseName(d)}`
- `NationalSpire.MatchRules.BaseChance(NationalSpire.CareerPerson, int)`；输入表达式：`MatchRules.BaseChance(p, p.MaxAscension)`；返回值紧邻使用处：`InterpolationSyntax: {MatchRules.BaseChance(p, p.MaxAscension):P1}`
- `NationalSpire.MatchRules.ClearChance(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?)`；输入表达式：`MatchRules.ClearChance(d, p, p.MaxAscension)`；返回值紧邻使用处：`InterpolationSyntax: {MatchRules.ClearChance(d, p, p.MaxAscension):P1}`
- `NationalSpire.MatchRules.Performance(bool, int, double?)`；输入表达式：`MatchRules.Performance(r.Win, r.Floor, r.RunSeconds)`；返回值紧邻使用处：`InterpolationSyntax: {MatchRules.Performance(r.Win, r.Floor, r.RunSeconds)}`
- `NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.CanOperate(d)`；返回值紧邻使用处：`ConditionalExpressionSyntax: OwnedClubs.CanOperate(d) ? $"{player}是这家自建俱乐部的管理者。" : ""`
- `NationalSpire.PersonalityLibrary.PromptProfile(NationalSpire.PersonalityProfile)`；输入表达式：`PersonalityLibrary.PromptProfile(card.Personality)`；返回值紧邻使用处：`ArgumentSyntax: PersonalityLibrary.PromptProfile(card.Personality)`
- `NationalSpire.PersonalityProfile.Dimensions()`；输入表达式：`card.Personality.Dimensions()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: card.Personality.Dimensions().Any`
- `NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；输入表达式：`PrivateAppointments.DateText(d, d.PlayerIntroductionDay)`；返回值紧邻使用处：`InterpolationSyntax: {PrivateAppointments.DateText(d, d.PlayerIntroductionDay)}`
- `NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；输入表达式：`PrivateAppointments.DateText(d, p.IntroductionDay)`；返回值紧邻使用处：`InterpolationSyntax: {PrivateAppointments.DateText(d, p.IntroductionDay)}`
- `NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；输入表达式：`PrivateAppointments.DateText(d, r.Day)`；返回值紧邻使用处：`InterpolationSyntax: {PrivateAppointments.DateText(d, r.Day)}`
- `NationalSpire.PrivatePublicContext.ActualAscension(NationalSpire.CareerResult)`；输入表达式：`ActualAscension(r)`；返回值紧邻使用处：`BinaryExpressionSyntax: "实际挑战进阶" + ActualAscension(r)`
- `NationalSpire.PrivatePublicContext.ActualAscension(NationalSpire.CareerResult)`；输入表达式：`ActualAscension(r)`；返回值紧邻使用处：`BinaryExpressionSyntax: ActualAscension(r) >= 0`
- `NationalSpire.PrivatePublicContext.AppendCareerDetails(System.Text.StringBuilder, NationalSpire.CareerData, NationalSpire.CareerPerson, System.Collections.Generic.List<(int Start, int Length, string Group)>?)`；输入表达式：`AppendCareerDetails(b, d, p, changing)`；返回值紧邻使用处：`ExpressionStatementSyntax: AppendCareerDetails(b, d, p, changing);`
- `NationalSpire.PrivatePublicContext.Human(NationalSpire.CareerData)`；输入表达式：`Human(d)`；返回值紧邻使用处：`ArgumentSyntax: Human(d)`
- `NationalSpire.PrivatePublicContext.WorldPoints(NationalSpire.CareerData, string)`；输入表达式：`WorldPoints(d, "player")`；返回值紧邻使用处：`InterpolationSyntax: {WorldPoints(d, "player")}`
- `NationalSpire.PrivatePublicContext.WorldPoints(NationalSpire.CareerData, string)`；输入表达式：`WorldPoints(d, Human(d))`；返回值紧邻使用处：`InterpolationSyntax: {WorldPoints(d, Human(d))}`
- `NationalSpire.PrivatePublicContext.WorldPoints(NationalSpire.CareerData, string)`；输入表达式：`WorldPoints(d, p.Id)`；返回值紧邻使用处：`InterpolationSyntax: {WorldPoints(d, p.Id)}`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", card.Identities)`；返回值紧邻使用处：`InterpolationSyntax: {string.Join("、", card.Identities)}`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", d.PlayerNameAliases)`；返回值紧邻使用处：`InterpolationSyntax: {string.Join("、", d.PlayerNameAliases)}`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", group.Select(h => "第" + h.Season + "赛季").Distinct())`；返回值紧邻使用处：`InterpolationSyntax: {string.Join("、", group.Select(h => "第" + h.Season + "赛季").Distinct())}`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("；", results.GroupBy(ActualAscension).OrderByDescending(g => g.Key).Select(g =>                  $"{(g.Key < 0 ? "实际进阶未记录" : "进阶" + g.Key)}，{g.Count()}场，通关{g.Count(r => r.Win)}场，赛事获胜{g.Count(r => r.Outcome == "获胜")}场"))`；返回值紧邻使用处：`BinaryExpressionSyntax: $"{player}已记录的公开比赛，按实际挑战进阶统计：" + string.Join("；", results.GroupBy(ActualAscension).OrderByDescending(g => g.Key).Select(g =>                  $"{(g.Key < 0 ? "实际进阶未记录" : "进阶" + g.Key)}，{g.Count()}场，通关{g.Count(r => r.Win)}场，赛事获胜{g.Count(r => r.Outcome == "获胜")}场"))`
- `string.Join<T>(string?, System.Collections.Generic.IEnumerable<T>)`；输入表达式：`string.Join("、", p.Form.ToCharArray())`；返回值紧邻使用处：`InterpolationSyntax: {string.Join("、", p.Form.ToCharArray())}`
- `string.StartsWith(string)`；输入表达式：`h.Id.StartsWith("ceremony-")`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !h.Id.StartsWith("ceremony-")`
- `string.StartsWith(string)`；输入表达式：`h.Id.StartsWith("top20-")`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !h.Id.StartsWith("top20-")`
- `string.ToCharArray()`；输入表达式：`p.Form.ToCharArray()`；返回值紧邻使用处：`ArgumentSyntax: p.Form.ToCharArray()`
- `string.TrimEnd()`；输入表达式：`b.ToString().TrimEnd()`；返回值紧邻使用处：`ReturnStatementSyntax: return b.ToString().TrimEnd();`
- `System.Collections.Generic.HashSet<T>.HashSet()`；输入表达式：`new HashSet<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HashSet<string>()`
- `System.Collections.Generic.IEnumerable<int>.Max()`；输入表达式：`results.Where(r => r.Win).Select(ActualAscension).Append(d.LocalHumanId.Length == 0 ? d.Esports.BestClear : -1).Max()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = results.Where(r => r.Win).Select(ActualAscension).Append(d.LocalHumanId.Length == 0 ? d.Esports.BestClear : -1).Max()`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`card.Personality.Dimensions().Any(s => s.Length > 0)`；返回值紧邻使用处：`IfStatementSyntax: if (card.Personality.Dimensions().Any(s => s.Length > 0)) b.AppendLine($"{player}自设角色卡中的性格：" + System.Text.Json.JsonSerializer.Serialize(PersonalityLibrary.PromptProfile(card.Personality), new System.Text.Json.JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping }));`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`results.Where(r => r.Win).Select(ActualAscension).Append(d.LocalHumanId.Length == 0 ? d.Esports.BestClear : -1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: results.Where(r => r.Win).Select(ActualAscension).Append(d.LocalHumanId.Length == 0 ? d.Esports.BestClear : -1).Max`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`g.Count()`；返回值紧邻使用处：`InterpolationSyntax: {g.Count()}`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Count(r => r.Outcome == "获胜")`；返回值紧邻使用处：`InterpolationSyntax: {g.Count(r => r.Outcome == "获胜")}`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Count(r => r.Win)`；返回值紧邻使用处：`InterpolationSyntax: {g.Count(r => r.Win)}`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`group.Select(h => "第" + h.Season + "赛季").Distinct()`；返回值紧邻使用处：`ArgumentSyntax: group.Select(h => "第" + h.Season + "赛季").Distinct()`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Esports.Honors.Where(h => h.Day <= d.Day).GroupBy(h => (h.Title, Team: d.LocalHumanId.Length > 0 && !h.Id.StartsWith("ceremony-") && !h.Id.StartsWith("top20-")))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var group in d.Esports.Honors.Where(h => h.Day <= d.Day).GroupBy(h => (h.Title, Team: d.LocalHumanId.Length > 0 && !h.Id.StartsWith("ceremony-") && !h.Id.StartsWith("top20-"))))              b.AppendLine($"{(group.Key.Team ? player + "所在合作队伍" : player)}的荣誉：{group.Key.Title}（{string.Join("、", group.Select(h => "第" + h.Season + "赛季").Distinct())}）。");`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`results.GroupBy(ActualAscension)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: results.GroupBy(ActualAscension).OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`results.GroupBy(ActualAscension).OrderByDescending(g => g.Key)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: results.GroupBy(ActualAscension).OrderByDescending(g => g.Key).Select`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`results.OrderByDescending(r => r.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: results.OrderByDescending(r => r.Day).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`group.Select(h => "第" + h.Season + "赛季")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: group.Select(h => "第" + h.Season + "赛季").Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`results.GroupBy(ActualAscension).OrderByDescending(g => g.Key).Select(g =>                  $"{(g.Key < 0 ? "实际进阶未记录" : "进阶" + g.Key)}，{g.Count()}场，通关{g.Count(r => r.Win)}场，赛事获胜{g.Count(r => r.Outcome == "获胜")}场")`；返回值紧邻使用处：`ArgumentSyntax: results.GroupBy(ActualAscension).OrderByDescending(g => g.Key).Select(g =>                  $"{(g.Key < 0 ? "实际进阶未记录" : "进阶" + g.Key)}，{g.Count()}场，通关{g.Count(r => r.Win)}场，赛事获胜{g.Count(r => r.Outcome == "获胜")}场")`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`results.Where(r => r.Win).Select(ActualAscension)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: results.Where(r => r.Win).Select(ActualAscension).Append`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`results.OrderByDescending(r => r.Day).Take(3)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: results.OrderByDescending(r => r.Day).Take(3).Where`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`d.Results.Where(r => r.Day <= d.Day && r.Kind != "private-friendly").ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Results.Where(r => r.Day <= d.Day && r.Kind != "private-friendly").ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`results.OrderByDescending(r => r.Day).Take(3).Where(r => r.OpponentId != p.Id && !r.OpponentParticipants.Contains(p.Id)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = results.OrderByDescending(r => r.Day).Take(3).Where(r => r.OpponentId != p.Id && !r.OpponentParticipants.Contains(p.Id)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Honors.Where(h => h.Day <= d.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.Honors.Where(h => h.Day <= d.Day).GroupBy`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Results.Where(r => r.Day <= d.Day && r.Kind != "private-friendly")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Results.Where(r => r.Day <= d.Day && r.Kind != "private-friendly").ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`results.OrderByDescending(r => r.Day).Take(3).Where(r => r.OpponentId != p.Id && !r.OpponentParticipants.Contains(p.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: results.OrderByDescending(r => r.Day).Take(3).Where(r => r.OpponentId != p.Id && !r.OpponentParticipants.Contains(p.Id)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`results.Where(r => r.Win)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: results.Where(r => r.Win).Select`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`.Add((chanceStart, b.Length - chanceStart, "learning"))`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: changing?.Add((chanceStart, b.Length - chanceStart, "learning"))`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`.Add((recentStart, b.Length - recentStart, "results"))`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: changing?.Add((recentStart, b.Length - recentStart, "results"))`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`r.OpponentParticipants.Contains(p.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !r.OpponentParticipants.Contains(p.Id)`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`System.Text.Json.JsonSerializer.Serialize(PersonalityLibrary.PromptProfile(card.Personality), new System.Text.Json.JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping })`；返回值紧邻使用处：`BinaryExpressionSyntax: $"{player}自设角色卡中的性格：" + System.Text.Json.JsonSerializer.Serialize(PersonalityLibrary.PromptProfile(card.Personality), new System.Text.Json.JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping })`
- `System.Text.Json.JsonSerializerOptions.JsonSerializerOptions()`；输入表达式：`new System.Text.Json.JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping }`；返回值紧邻使用处：`ArgumentSyntax: new System.Text.Json.JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping }`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"{(group.Key.Team ? player + "所在合作队伍" : player)}的荣誉：{group.Key.Title}（{string.Join("、", group.Select(h => "第" + h.Season + "赛季").Distinct())}）。")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{(group.Key.Team ? player + "所在合作队伍" : player)}的荣誉：{group.Key.Title}（{string.Join("、", group.Select(h => "第" + h.Season + "赛季").Distinct())}）。");`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"{p.PublicName}担任俱乐部教练，不兼任选手；陪练系数×{ClubCoaching.Factor(p):0.#}。")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{p.PublicName}担任俱乐部教练，不兼任选手；陪练系数×{ClubCoaching.Factor(p):0.#}。");`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"{p.PublicName}的当前资料")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{p.PublicName}的当前资料");`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"{p.PublicName}的连胜纪录：{CameoContent.StreakText(p)}")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{p.PublicName}的连胜纪录：{CameoContent.StreakText(p)}");`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"{p.PublicName}角色卡设定的进阶{p.MaxAscension}初始通关率为{custom:P1}；上述当前通关率已计入后续交流学习。")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{p.PublicName}角色卡设定的进阶{p.MaxAscension}初始通关率为{custom:P1}；上述当前通关率已计入后续交流学习。");`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"{p.PublicName}近期比赛结果（从旧到新）：{string.Join("、", p.Form.ToCharArray())}。")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{p.PublicName}近期比赛结果（从旧到新）：{string.Join("、", p.Form.ToCharArray())}。");`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"{p.PublicName}是{p.Role}，归属{EsportsWorld.ClubName(d, p.ClubId)}；{p.PublicName}的战绩为{p.Wins}胜{p.Losses}负，最高通关进阶{p.MaxAscension}，累计冠军{p.Titles}次，世界积分{WorldPoints(d, p.Id)}，评分{p.Rating}。")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{p.PublicName}是{p.Role}，归属{EsportsWorld.ClubName(d, p.ClubId)}；{p.PublicName}的战绩为{p.Wins}胜{p.Losses}负，最高通关进阶{p.MaxAscension}，累计冠军{p.Titles}次，世界积分{WorldPoints(d, p.Id)}，评分{p.Rating}。");`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"{p.PublicName}在进阶{p.MaxAscension}的基础通关率为{MatchRules.BaseChance(p, p.MaxAscension):P1}；计入当前培养、陪练、交流学习与短期状态后为{MatchRules.ClearChance(d, p, p.MaxAscension):P1}。")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{p.PublicName}在进阶{p.MaxAscension}的基础通关率为{MatchRules.BaseChance(p, p.MaxAscension):P1}；计入当前培养、陪练、交流学习与短期状态后为{MatchRules.ClearChance(d, p, p.MaxAscension):P1}。");`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"{player}当前连胜{d.Esports.WinStreak}场，世界积分{WorldPoints(d, "player")}。")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{player}当前连胜{d.Esports.WinStreak}场，世界积分{WorldPoints(d, "player")}。");`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"{player}当前选择的角色：{CharacterIdentity.Name(d, d.SelectedCharacter)}。")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{player}当前选择的角色：{CharacterIdentity.Name(d, d.SelectedCharacter)}。");`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"{player}的本生涯比赛战绩为{d.Wins}胜{d.Losses}负、{d.Draws}平，评分{d.Rating}，关注{d.Fans}。")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{player}的本生涯比赛战绩为{d.Wins}胜{d.Losses}负、{d.Draws}平，评分{d.Rating}，关注{d.Fans}。");`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"{player}的曾用游戏名：{string.Join("、", d.PlayerNameAliases)}。")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{player}的曾用游戏名：{string.Join("、", d.PlayerNameAliases)}。");`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"{player}的打法偏好：{card.Style}。")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{player}的打法偏好：{card.Style}。");`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"{player}的个人世界积分为{WorldPoints(d, Human(d))}。")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{player}的个人世界积分为{WorldPoints(d, Human(d))}。");`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"{player}的个人赞助商：{sponsor.Brand}，合作期为第{sponsor.StartSeason}至{sponsor.EndSeason}赛季。{sponsor.Description}")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{player}的个人赞助商：{sponsor.Brand}，合作期为第{sponsor.StartSeason}至{sponsor.EndSeason}赛季。{sponsor.Description}");`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"{player}的近期公开赛果：")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{player}的近期公开赛果：");`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"{player}的其他身份：{string.Join("、", card.Identities)}。")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{player}的其他身份：{string.Join("、", card.Identities)}。");`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"{player}的人物介绍：{card.Biography}")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{player}的人物介绍：{card.Biography}");`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"{player}的说话习惯：{card.Voice}")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{player}的说话习惯：{card.Voice}");`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"{player}的姓名：{card.Name}。")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{player}的姓名：{card.Name}。");`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"{player}的游戏档案最高通关：进阶{d.AvatarHighestClear}（包含本生涯以外的游戏记录）。")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{player}的游戏档案最高通关：进阶{d.AvatarHighestClear}（包含本生涯以外的游戏记录）。");`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"{player}入选{d.Esports.Country}国家队。")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{player}入选{d.Esports.Country}国家队。");`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"{player}擅长角色：{CharacterIdentity.Name(d, card.Character)}。")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{player}擅长角色：{CharacterIdentity.Name(d, card.Character)}。");`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"{player}是与你聊天的玩家，性别为{d.PlayerGender}，来自{d.Esports.Country}；职业为{d.PlayerCard?.Role ?? EsportsWorld.LicenseName(d)}，参赛资格为{EsportsWorld.LicenseName(d)}。")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{player}是与你聊天的玩家，性别为{d.PlayerGender}，来自{d.Esports.Country}；职业为{d.PlayerCard?.Role ?? EsportsWorld.LicenseName(d)}，参赛资格为{EsportsWorld.LicenseName(d)}。");`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"{player}所在地区：{card.Region}。")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{player}所在地区：{card.Region}。");`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"{player}在俱乐部的岗位：{(ClubCoaching.PlayerReserve(d) ? "轮换" : "首发")}{(ClubCoaching.PlayerCoach(d) ? "，兼任教练" : "")}。")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{player}在俱乐部的岗位：{(ClubCoaching.PlayerReserve(d) ? "轮换" : "首发")}{(ClubCoaching.PlayerCoach(d) ? "，兼任教练" : "")}。");`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"{player}支持的俱乐部：{EsportsWorld.ClubName(d, card.SupportedClubId)}。")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{player}支持的俱乐部：{EsportsWorld.ClubName(d, card.SupportedClubId)}。");`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"{PrivateAppointments.DateText(d, d.PlayerIntroductionDay)}的{player}周刊档案：{d.PlayerIntroduction}")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{PrivateAppointments.DateText(d, d.PlayerIntroductionDay)}的{player}周刊档案：{d.PlayerIntroduction}");`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"{PrivateAppointments.DateText(d, p.IntroductionDay)}的{p.PublicName}周刊档案：{p.AiIntroduction}")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{PrivateAppointments.DateText(d, p.IntroductionDay)}的{p.PublicName}周刊档案：{p.AiIntroduction}");`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"{PrivateAppointments.DateText(d, r.Day)}，{player}在{r.Event}对阵{r.Opponent}，赛果{r.Outcome}；{(r.OfficialAscensionVerified ? "赛事规定进阶" + r.Ascension : "赛事规定进阶未核实")}，{player}{(ActualAscension(r) >= 0 ? "实际挑战进阶" + ActualAscension(r) : "实际挑战进阶未记录")}，使用{CharacterIdentity.ForResult(r)}，{MatchRules.Performance(r.Win, r.Floor, r.RunSeconds)}。")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{PrivateAppointments.DateText(d, r.Day)}，{player}在{r.Event}对阵{r.Opponent}，赛果{r.Outcome}；{(r.OfficialAscensionVerified ? "赛事规定进阶" + r.Ascension : "赛事规定进阶未核实")}，{player}{(ActualAscension(r) >= 0 ? "实际挑战进阶" + ActualAscension(r) : "实际挑战进阶未记录")}，使用{CharacterIdentity.ForResult(r)}，{MatchRules.Performance(r.Win, r.Floor, r.RunSeconds)}。");`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"\n{player}的当前资料")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"\n{player}的当前资料");`
- `System.Text.StringBuilder.AppendLine(string?)`；输入表达式：`b.AppendLine("\n性格使用说明：" + PersonalityLibrary.ProfileUsage)`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine("\n性格使用说明：" + PersonalityLibrary.ProfileUsage);`
- `System.Text.StringBuilder.AppendLine(string?)`；输入表达式：`b.AppendLine($"{player}所属俱乐部：{EsportsWorld.ClubName(d, d.Esports.ClubId)}。" + (OwnedClubs.CanOperate(d) ? $"{player}是这家自建俱乐部的管理者。" : ""))`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{player}所属俱乐部：{EsportsWorld.ClubName(d, d.Esports.ClubId)}。" + (OwnedClubs.CanOperate(d) ? $"{player}是这家自建俱乐部的管理者。" : ""));`
- `System.Text.StringBuilder.AppendLine(string?)`；输入表达式：`b.AppendLine($"{player}已记录的公开比赛，按实际挑战进阶统计：" + string.Join("；", results.GroupBy(ActualAscension).OrderByDescending(g => g.Key).Select(g =>                  $"{(g.Key < 0 ? "实际进阶未记录" : "进阶" + g.Key)}，{g.Count()}场，通关{g.Count(r => r.Win)}场，赛事获胜{g.Count(r => r.Outcome == "获胜")}场")) + "。")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{player}已记录的公开比赛，按实际挑战进阶统计：" + string.Join("；", results.GroupBy(ActualAscension).OrderByDescending(g => g.Key).Select(g =>                  $"{(g.Key < 0 ? "实际进阶未记录" : "进阶" + g.Key)}，{g.Count()}场，通关{g.Count(r => r.Win)}场，赛事获胜{g.Count(r => r.Outcome == "获胜")}场")) + "。");`
- `System.Text.StringBuilder.AppendLine(string?)`；输入表达式：`b.AppendLine($"{player}自设角色卡中的性格：" + System.Text.Json.JsonSerializer.Serialize(PersonalityLibrary.PromptProfile(card.Personality), new System.Text.Json.JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping }))`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{player}自设角色卡中的性格：" + System.Text.Json.JsonSerializer.Serialize(PersonalityLibrary.PromptProfile(card.Personality), new System.Text.Json.JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping }));`
- `System.Text.StringBuilder.AppendLine(string?)`；输入表达式：`b.AppendLine(highest >= 0 ? $"{player}的生涯最高通关：进阶{highest}。" : $"{player}尚无已确认的生涯通关进阶记录。")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine(highest >= 0 ? $"{player}的生涯最高通关：进阶{highest}。" : $"{player}尚无已确认的生涯通关进阶记录。");`
- `System.Text.StringBuilder.StringBuilder()`；输入表达式：`new StringBuilder()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StringBuilder()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`b.ToString()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: b.ToString().TrimEnd`

**赋值（含属性/字段和局部值）：**

- `Encoder` = `System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping`

<a id="symbol-7a9097f87102"></a>

## `Awards(string, string) — void Awards(string id, string name)`

来源：源码第 96 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivatePublicContext.Profiles(NationalSpire.CareerData, NationalSpire.CareerPerson, System.Collections.Generic.List<(int Start, int Length, string Group)>?)`](PrivatePublicContext.cs.md#symbol-d9c12bf4e41b)

**调用：** `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`

**字段、属性、事件及方法组引用：** `(string Event, string Place).Event`；`(string Event, string Place).Place`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CircuitAward.Day`；`NationalSpire.CircuitAward.Event`；`NationalSpire.CircuitAward.PersonId`；`NationalSpire.CircuitAward.Place`；`NationalSpire.CircuitAward.Season`；`NationalSpire.EsportsCareer.CircuitAwards`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", group.Select(a => "第" + a.Season + "赛季").Distinct())`；返回值紧邻使用处：`InterpolationSyntax: {string.Join("、", group.Select(a => "第" + a.Season + "赛季").Distinct())}`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`group.Select(a => "第" + a.Season + "赛季").Distinct()`；返回值紧邻使用处：`ArgumentSyntax: group.Select(a => "第" + a.Season + "赛季").Distinct()`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Esports.CircuitAwards.Where(a => a.PersonId == id && a.Day <= d.Day).GroupBy(a => (a.Event, a.Place))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var group in d.Esports.CircuitAwards.Where(a => a.PersonId == id && a.Day <= d.Day).GroupBy(a => (a.Event, a.Place)))                  b.AppendLine($"{name}的赛事荣誉：{group.Key.Event}{group.Key.Place}（{string.Join("、", group.Select(a => "第" + a.Season + "赛季").Distinct())}）。");`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`group.Select(a => "第" + a.Season + "赛季")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: group.Select(a => "第" + a.Season + "赛季").Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.CircuitAwards.Where(a => a.PersonId == id && a.Day <= d.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.CircuitAwards.Where(a => a.PersonId == id && a.Day <= d.Day).GroupBy`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"{name}的赛事荣誉：{group.Key.Event}{group.Key.Place}（{string.Join("、", group.Select(a => "第" + a.Season + "赛季").Distinct())}）。")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{name}的赛事荣誉：{group.Key.Event}{group.Key.Place}（{string.Join("、", group.Select(a => "第" + a.Season + "赛季").Distinct())}）。");`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0073b473a0ab"></a>

## `Club(string, string) — void Club(string id, string name)`

来源：源码第 101 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivatePublicContext.Profiles(NationalSpire.CareerData, NationalSpire.CareerPerson, System.Collections.Generic.List<(int Start, int Length, string Group)>?)`](PrivatePublicContext.cs.md#symbol-d9c12bf4e41b)

**调用：** [`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-3ba0e806ba5c)；[`NationalSpire.PrivatePublicContext.AppendClubDetails(System.Text.StringBuilder, NationalSpire.CareerData, NationalSpire.CareerClub, string, System.Collections.Generic.List<(int Start, int Length, string Group)>?)`](PrivateCareerContext.cs.md#symbol-7b4c2e1f7909)；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerClub.Country`；`NationalSpire.CareerClub.Motto`；`NationalSpire.CareerClub.Name`；`NationalSpire.CareerClub.Titles`；`NationalSpire.CareerPerson.Id`；`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；`NationalSpire.PrivatePublicContext.AppendClubDetails(System.Text.StringBuilder, NationalSpire.CareerData, NationalSpire.CareerClub, string, System.Collections.Generic.List<(int Start, int Length, string Group)>?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.Club(d, id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: EsportsWorld.Club(d, id) is not { } club`
- `NationalSpire.PrivatePublicContext.AppendClubDetails(System.Text.StringBuilder, NationalSpire.CareerData, NationalSpire.CareerClub, string, System.Collections.Generic.List<(int Start, int Length, string Group)>?)`；输入表达式：`AppendClubDetails(b, d, club, p.Id, changing)`；返回值紧邻使用处：`ExpressionStatementSyntax: AppendClubDetails(b, d, club, p.Id, changing);`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`clubs.Add(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !clubs.Add(id)`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"{name}所属的{club.Name}来自{club.Country}，累计冠军{club.Titles}次。{club.Motto}")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{name}所属的{club.Name}来自{club.Country}，累计冠军{club.Titles}次。{club.Motto}");`

**赋值（含属性/字段和局部值）：**


<a id="symbol-58aebbb834b8"></a>

## `NationalSpire.PrivatePublicContext.Community(NationalSpire.CareerData, NationalSpire.CareerPerson, string, System.Collections.Generic.ISet<string>?, System.Collections.Generic.List<(string Id, string Text)>?, NationalSpire.CommunityMemorySearch.Request?) — public static string Community(CareerData d, CareerPerson person, string query, ISet<string>? attached = null, List<(string Id, string Text)>? completePosts = null, CommunityMemorySearch.Request? request = null)`

来源：源码第 109 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)；[`NationalSpire.PrivateMessagePrompts.Context(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-4b9d12b26f65)

**调用：** [`Add(System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>, int)`](PrivatePublicContext.cs.md#symbol-ade3ea2318ca)；[`NationalSpire.AiGeneratedText.Memory(NationalSpire.CommunityMemory)`](AiGeneratedText.cs.md#symbol-ff263d7615f1)；[`NationalSpire.CommunityMemorySearch.PrivateAcquaintance(NationalSpire.CareerData, NationalSpire.CareerPerson)`](CommunityMemorySearch.cs.md#symbol-ab53931edb52)；[`NationalSpire.CommunityMemorySearch.Retrieve(NationalSpire.CareerData, string, System.Collections.Generic.IEnumerable<string>, int, System.Collections.Generic.ISet<string>, int, System.Collections.Generic.ISet<string>?, bool, NationalSpire.CommunityMemorySearch.Request?)`](CommunityMemorySearch.cs.md#symbol-f933ce4e4ad8)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-87fd384e7842)；[`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`](PrivateAppointments.cs.md#symbol-1c549626b284)；[`NationalSpire.PrivatePublicContext.Human(NationalSpire.CareerData)`](PrivatePublicContext.cs.md#symbol-6854ea57c49e)；[`NationalSpire.PrivatePublicContext.PostText(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CareerPerson, string, System.Collections.Generic.IEnumerable<NationalSpire.CommunityMemory>?, NationalSpire.CommunityMemorySearch.Request?)`](PrivatePublicContext.cs.md#symbol-b9ef12aab6ca)；[`PlayerRelated(NationalSpire.CommunityPost)`](PrivatePublicContext.cs.md#symbol-33b430eaf173)；[`Topic(NationalSpire.CommunityPost)`](PrivatePublicContext.cs.md#symbol-7af32d4a06f5)；`NationalSpire.CommunityMemorySearch.Request.Request()`；`string.Trim()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.HashSet<T>.HashSet()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.List<T>.List()`；`System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；`System.Text.StringBuilder.AppendLine(string?)`；`System.Text.StringBuilder.StringBuilder()`；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `Add(System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>, int)`；`LastActivity(NationalSpire.CommunityPost)`；`NationalSpire.AiGeneratedText.Memory(NationalSpire.CommunityMemory)`；`NationalSpire.CareerData.CommunityMemories`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CommunityMemory.Day`；`NationalSpire.CommunityMemory.Id`；`NationalSpire.CommunityMemory.Kind`；`NationalSpire.CommunityMemory.PostId`；`NationalSpire.CommunityMemorySearch.PrivateAcquaintance(NationalSpire.CareerData, NationalSpire.CareerPerson)`；`NationalSpire.CommunityMemorySearch.Retrieve(NationalSpire.CareerData, string, System.Collections.Generic.IEnumerable<string>, int, System.Collections.Generic.ISet<string>, int, System.Collections.Generic.ISet<string>?, bool, NationalSpire.CommunityMemorySearch.Request?)`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.Day`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.Priority`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.CommunityReply.Day`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`；`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；`NationalSpire.PrivatePublicContext.Human(NationalSpire.CareerData)`；`NationalSpire.PrivatePublicContext.PostText(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CareerPerson, string, System.Collections.Generic.IEnumerable<NationalSpire.CommunityMemory>?, NationalSpire.CommunityMemorySearch.Request?)`；`PlayerRelated(NationalSpire.CommunityPost)`；`Topic(NationalSpire.CommunityPost)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Add(System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>, int)`；输入表达式：`Add(memories.Where(m => available.ContainsKey(m.PostId)).Select(m => available[m.PostId]).DistinctBy(p => p.Id), 2)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(memories.Where(m => available.ContainsKey(m.PostId)).Select(m => available[m.PostId]).DistinctBy(p => p.Id), 2);`
- `Add(System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>, int)`；输入表达式：`Add(ownPosts.OrderByDescending(LastActivity), 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(ownPosts.OrderByDescending(LastActivity), 1);`
- `Add(System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>, int)`；输入表达式：`Add(ownPosts.Where(p => Topic(p) || PlayerRelated(p)).OrderByDescending(Topic).ThenByDescending(PlayerRelated).ThenByDescending(LastActivity), 2)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(ownPosts.Where(p => Topic(p) || PlayerRelated(p)).OrderByDescending(Topic).ThenByDescending(PlayerRelated).ThenByDescending(LastActivity), 2);`
- `Add(System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>, int)`；输入表达式：`Add(posts.Where(p => PlayerRelated(p) && Topic(p)).OrderByDescending(p => p.Priority).ThenByDescending(LastActivity), 2)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(posts.Where(p => PlayerRelated(p) && Topic(p)).OrderByDescending(p => p.Priority).ThenByDescending(LastActivity), 2);`
- `Add(System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>, int)`；输入表达式：`Add(posts.Where(PlayerRelated).OrderByDescending(LastActivity), 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(posts.Where(PlayerRelated).OrderByDescending(LastActivity), 1);`
- `Add(System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>, int)`；输入表达式：`Add(posts.Where(Topic).OrderByDescending(LastActivity), 2)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(posts.Where(Topic).OrderByDescending(LastActivity), 2);`
- `NationalSpire.AiGeneratedText.Memory(NationalSpire.CommunityMemory)`；输入表达式：`AiGeneratedText.Memory(memory)`；返回值紧邻使用处：`InterpolationSyntax: {AiGeneratedText.Memory(memory)}`
- `NationalSpire.CommunityMemorySearch.PrivateAcquaintance(NationalSpire.CareerData, NationalSpire.CareerPerson)`；输入表达式：`CommunityMemorySearch.PrivateAcquaintance(d, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityMemorySearch.PrivateAcquaintance(d, person)`
- `NationalSpire.CommunityMemorySearch.Request.Request()`；输入表达式：`new()`；返回值紧邻使用处：`AssignmentExpressionSyntax: request ??= new()`
- `NationalSpire.CommunityMemorySearch.Retrieve(NationalSpire.CareerData, string, System.Collections.Generic.IEnumerable<string>, int, System.Collections.Generic.ISet<string>, int, System.Collections.Generic.ISet<string>?, bool, NationalSpire.CommunityMemorySearch.Request?)`；输入表达式：`CommunityMemorySearch.Retrieve(d, query, [person.Id, Human(d)], d.Day, new HashSet<string>(), 5,              excludedMemories: memories.Select(m => m.Id).ToHashSet(), requireTopic: true, request: request)`；返回值紧邻使用处：`ArgumentSyntax: CommunityMemorySearch.Retrieve(d, query, [person.Id, Human(d)], d.Day, new HashSet<string>(), 5,              excludedMemories: memories.Select(m => m.Id).ToHashSet(), requireTopic: true, request: request)`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(d).Where`
- `NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`CommunityThreads.NewsPending(d, p)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CommunityThreads.NewsPending(d, p)`
- `NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；输入表达式：`PrivateAppointments.DateText(d, memory.Day)`；返回值紧邻使用处：`InterpolationSyntax: {PrivateAppointments.DateText(d, memory.Day)}`
- `NationalSpire.PrivatePublicContext.Human(NationalSpire.CareerData)`；输入表达式：`Human(d)`；返回值紧邻使用处：`ExpressionElementSyntax: Human(d)`
- `NationalSpire.PrivatePublicContext.PostText(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CareerPerson, string, System.Collections.Generic.IEnumerable<NationalSpire.CommunityMemory>?, NationalSpire.CommunityMemorySearch.Request?)`；输入表达式：`PostText(d, post, person, query, memories, request)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PostText(d, post, person, query, memories, request)`
- `PlayerRelated(NationalSpire.CommunityPost)`；输入表达式：`PlayerRelated(p)`；返回值紧邻使用处：`BinaryExpressionSyntax: PlayerRelated(p) && Topic(p)`
- `PlayerRelated(NationalSpire.CommunityPost)`；输入表达式：`PlayerRelated(p)`；返回值紧邻使用处：`BinaryExpressionSyntax: Topic(p) || PlayerRelated(p)`
- `string.Trim()`；输入表达式：`b.ToString().Trim()`；返回值紧邻使用处：`ReturnStatementSyntax: return b.ToString().Trim();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`available.ContainsKey(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !available.ContainsKey(id)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`available.ContainsKey(m.PostId)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: m => available.ContainsKey(m.PostId)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`missingSources.Contains(m.PostId)`；返回值紧邻使用处：`BinaryExpressionSyntax: m.Day <= d.Day && missingSources.Contains(m.PostId)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`selectedIds.Contains(m.PostId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !selectedIds.Contains(m.PostId)`
- `System.Collections.Generic.HashSet<T>.HashSet()`；输入表达式：`new HashSet<string>()`；返回值紧邻使用处：`ArgumentSyntax: new HashSet<string>()`
- `System.Collections.Generic.HashSet<T>.HashSet()`；输入表达式：`new HashSet<string>()`；返回值紧邻使用处：`BinaryExpressionSyntax: attached ?? new HashSet<string>()`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`p.Replies.Any(r => r.Day <= d.Day && r.AuthorId == person.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.AuthorId == person.Id || p.Replies.Any(r => r.Day <= d.Day && r.AuthorId == person.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`originals.Concat(remaining)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: originals.Concat(remaining).DistinctBy`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`selected.Select(p => p.Id).Concat(attached ?? new HashSet<string>())`；返回值紧邻使用处：`MemberAccessExpressionSyntax: selected.Select(p => p.Id).Concat(attached ?? new HashSet<string>()).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`memories.Where(m => available.ContainsKey(m.PostId)).Select(m => available[m.PostId]).DistinctBy(p => p.Id)`；返回值紧邻使用处：`ArgumentSyntax: memories.Where(m => available.ContainsKey(m.PostId)).Select(m => available[m.PostId]).DistinctBy(p => p.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`originals.Concat(remaining).DistinctBy(m => m.Id)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var memory in originals.Concat(remaining).DistinctBy(m => m.Id))              b.AppendLine($"{PrivateAppointments.DateText(d, memory.Day)}，{(memory.Kind == "fact" ? "已记录事件" : "社区发言，仅代表发言者的观点或猜测")}：{AiGeneratedText.Memory(memory)}");`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`ownPosts.OrderByDescending(LastActivity)`；返回值紧邻使用处：`ArgumentSyntax: ownPosts.OrderByDescending(LastActivity)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`ownPosts.Where(p => Topic(p) || PlayerRelated(p)).OrderByDescending(Topic)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ownPosts.Where(p => Topic(p) || PlayerRelated(p)).OrderByDescending(Topic).ThenByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`posts.Where(p => PlayerRelated(p) && Topic(p)).OrderByDescending(p => p.Priority)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: posts.Where(p => PlayerRelated(p) && Topic(p)).OrderByDescending(p => p.Priority).ThenByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`posts.Where(PlayerRelated).OrderByDescending(LastActivity)`；返回值紧邻使用处：`ArgumentSyntax: posts.Where(PlayerRelated).OrderByDescending(LastActivity)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`posts.Where(Topic).OrderByDescending(LastActivity)`；返回值紧邻使用处：`ArgumentSyntax: posts.Where(Topic).OrderByDescending(LastActivity)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`memories.Select(m => m.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: memories.Select(m => m.Id).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`memories.Where(m => available.ContainsKey(m.PostId)).Select(m => available[m.PostId])`；返回值紧邻使用处：`MemberAccessExpressionSyntax: memories.Where(m => available.ContainsKey(m.PostId)).Select(m => available[m.PostId]).DistinctBy`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`remaining.Select(m => m.PostId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: remaining.Select(m => m.PostId).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`selected.Select(p => p.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: selected.Select(p => p.Id).Concat`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`CommunityThreads.All(d).Where(p => p.Day <= d.Day && !CommunityThreads.NewsPending(d, p)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityThreads.All(d).Where(p => p.Day <= d.Day && !CommunityThreads.NewsPending(d, p)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`memories.Where(m => !selectedIds.Contains(m.PostId)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = memories.Where(m => !selectedIds.Contains(m.PostId)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`posts.Where(p => p.AuthorId == person.Id || p.Replies.Any(r => r.Day <= d.Day && r.AuthorId == person.Id)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = posts.Where(p => p.AuthorId == person.Id || p.Replies.Any(r => r.Day <= d.Day && r.AuthorId == person.Id)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`posts.ToDictionary(p => p.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = posts.ToDictionary(p => p.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`memories.Select(m => m.Id).ToHashSet()`；返回值紧邻使用处：`ArgumentSyntax: excludedMemories: memories.Select(m => m.Id).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`remaining.Select(m => m.PostId).Where(id => !available.ContainsKey(id)).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = remaining.Select(m => m.PostId).Where(id => !available.ContainsKey(id)).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`selected.Select(p => p.Id).Concat(attached ?? new HashSet<string>()).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = selected.Select(p => p.Id).Concat(attached ?? new HashSet<string>()).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(d).Where(p => p.Day <= d.Day && !CommunityThreads.NewsPending(d, p))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(d).Where(p => p.Day <= d.Day && !CommunityThreads.NewsPending(d, p)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.CommunityMemories.Where(m => m.Day <= d.Day && missingSources.Contains(m.PostId) &&              (m.Id == m.PostId + ":fact" || m.Id == m.PostId + ":editorial"))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.CommunityMemories.Where(m => m.Day <= d.Day && missingSources.Contains(m.PostId) &&              (m.Id == m.PostId + ":fact" || m.Id == m.PostId + ":editorial"))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`memories.Where(m => !selectedIds.Contains(m.PostId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: memories.Where(m => !selectedIds.Contains(m.PostId)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`memories.Where(m => available.ContainsKey(m.PostId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: memories.Where(m => available.ContainsKey(m.PostId)).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`ownPosts.Where(p => Topic(p) || PlayerRelated(p))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ownPosts.Where(p => Topic(p) || PlayerRelated(p)).OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`posts.Where(p => p.AuthorId == person.Id || p.Replies.Any(r => r.Day <= d.Day && r.AuthorId == person.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: posts.Where(p => p.AuthorId == person.Id || p.Replies.Any(r => r.Day <= d.Day && r.AuthorId == person.Id)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`posts.Where(p => PlayerRelated(p) && Topic(p))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: posts.Where(p => PlayerRelated(p) && Topic(p)).OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`posts.Where(PlayerRelated)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: posts.Where(PlayerRelated).OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`posts.Where(Topic)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: posts.Where(Topic).OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`remaining.Select(m => m.PostId).Where(id => !available.ContainsKey(id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: remaining.Select(m => m.PostId).Where(id => !available.ContainsKey(id)).ToHashSet`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`.Add((post.Id, fullPost))`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: completePosts?.Add((post.Id, fullPost))`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`memories.AddRange(CommunityMemorySearch.Retrieve(d, query, [person.Id, Human(d)], d.Day, new HashSet<string>(), 5,              excludedMemories: memories.Select(m => m.Id).ToHashSet(), requireTopic: true, request: request))`；返回值紧邻使用处：`ExpressionStatementSyntax: memories.AddRange(CommunityMemorySearch.Retrieve(d, query, [person.Id, Human(d)], d.Day, new HashSet<string>(), 5,              excludedMemories: memories.Select(m => m.Id).ToHashSet(), requireTopic: true, request: request));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<CommunityPost>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<CommunityPost>()`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`ownPosts.Where(p => Topic(p) || PlayerRelated(p)).OrderByDescending(Topic).ThenByDescending(PlayerRelated).ThenByDescending(LastActivity)`；返回值紧邻使用处：`ArgumentSyntax: ownPosts.Where(p => Topic(p) || PlayerRelated(p)).OrderByDescending(Topic).ThenByDescending(PlayerRelated).ThenByDescending(LastActivity)`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`ownPosts.Where(p => Topic(p) || PlayerRelated(p)).OrderByDescending(Topic).ThenByDescending(PlayerRelated)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ownPosts.Where(p => Topic(p) || PlayerRelated(p)).OrderByDescending(Topic).ThenByDescending(PlayerRelated).ThenByDescending`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`posts.Where(p => PlayerRelated(p) && Topic(p)).OrderByDescending(p => p.Priority).ThenByDescending(LastActivity)`；返回值紧邻使用处：`ArgumentSyntax: posts.Where(p => PlayerRelated(p) && Topic(p)).OrderByDescending(p => p.Priority).ThenByDescending(LastActivity)`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"{PrivateAppointments.DateText(d, memory.Day)}，{(memory.Kind == "fact" ? "已记录事件" : "社区发言，仅代表发言者的观点或猜测")}：{AiGeneratedText.Memory(memory)}")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"{PrivateAppointments.DateText(d, memory.Day)}，{(memory.Kind == "fact" ? "已记录事件" : "社区发言，仅代表发言者的观点或猜测")}：{AiGeneratedText.Memory(memory)}");`
- `System.Text.StringBuilder.AppendLine(string?)`；输入表达式：`b.AppendLine(fullPost)`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine(fullPost);`
- `System.Text.StringBuilder.StringBuilder()`；输入表达式：`new StringBuilder()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StringBuilder()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`b.ToString()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: b.ToString().Trim`
- `Topic(NationalSpire.CommunityPost)`；输入表达式：`Topic(p)`；返回值紧邻使用处：`BinaryExpressionSyntax: PlayerRelated(p) && Topic(p)`
- `Topic(NationalSpire.CommunityPost)`；输入表达式：`Topic(p)`；返回值紧邻使用处：`BinaryExpressionSyntax: Topic(p) || PlayerRelated(p)`

**赋值（含属性/字段和局部值）：**

- `request` ??= `new()`

<a id="symbol-33b430eaf173"></a>

## `PlayerRelated(NationalSpire.CommunityPost) — bool PlayerRelated(CommunityPost p)`

来源：源码第 117 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivatePublicContext.Community(NationalSpire.CareerData, NationalSpire.CareerPerson, string, System.Collections.Generic.ISet<string>?, System.Collections.Generic.List<(string Id, string Text)>?, NationalSpire.CommunityMemorySearch.Request?)`](PrivatePublicContext.cs.md#symbol-58aebbb834b8)

**调用：** [`NationalSpire.PrivatePublicContext.IsPlayer(NationalSpire.CareerData, string)`](PrivatePublicContext.cs.md#symbol-9d4f1ec3280e)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.RelatedPeople`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.CommunityReply.Day`；`NationalSpire.PrivatePublicContext.IsPlayer(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivatePublicContext.IsPlayer(NationalSpire.CareerData, string)`；输入表达式：`IsPlayer(d, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => IsPlayer(d, id)`
- `NationalSpire.PrivatePublicContext.IsPlayer(NationalSpire.CareerData, string)`；输入表达式：`IsPlayer(d, p.AuthorId)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsPlayer(d, p.AuthorId) || p.RelatedPeople.Any(id => IsPlayer(d, id))`
- `NationalSpire.PrivatePublicContext.IsPlayer(NationalSpire.CareerData, string)`；输入表达式：`IsPlayer(d, r.AuthorId)`；返回值紧邻使用处：`BinaryExpressionSyntax: r.Day <= d.Day && IsPlayer(d, r.AuthorId)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`p.RelatedPeople.Any(id => IsPlayer(d, id))`；返回值紧邻使用处：`BinaryExpressionSyntax: IsPlayer(d, p.AuthorId) || p.RelatedPeople.Any(id => IsPlayer(d, id))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`p.Replies.Any(r => r.Day <= d.Day && IsPlayer(d, r.AuthorId))`；返回值紧邻使用处：`BinaryExpressionSyntax: IsPlayer(d, p.AuthorId) || p.RelatedPeople.Any(id => IsPlayer(d, id)) || p.Replies.Any(r => r.Day <= d.Day && IsPlayer(d, r.AuthorId))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a5f90f6e1a09"></a>

## `LastActivity(NationalSpire.CommunityPost) — int LastActivity(CommunityPost p)`

来源：源码第 118 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.PrivatePublicContext.IsPlayer(NationalSpire.CareerData, string)`](PrivatePublicContext.cs.md#symbol-9d4f1ec3280e)；`System.Collections.Generic.IEnumerable<int>.Max()`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CommunityPost.Day`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.CommunityReply.Day`；`NationalSpire.PrivatePublicContext.IsPlayer(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivatePublicContext.IsPlayer(NationalSpire.CareerData, string)`；输入表达式：`IsPlayer(d, r.AuthorId)`；返回值紧邻使用处：`BinaryExpressionSyntax: r.AuthorId == person.Id || IsPlayer(d, r.AuthorId)`
- `System.Collections.Generic.IEnumerable<int>.Max()`；输入表达式：`p.Replies.Where(r => r.Day <= d.Day && (r.AuthorId == person.Id || IsPlayer(d, r.AuthorId))).Select(r => r.Day).Append(p.Day).Max()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => p.Replies.Where(r => r.Day <= d.Day && (r.AuthorId == person.Id || IsPlayer(d, r.AuthorId))).Select(r => r.Day).Append(p.Day).Max()`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`p.Replies.Where(r => r.Day <= d.Day && (r.AuthorId == person.Id || IsPlayer(d, r.AuthorId))).Select(r => r.Day).Append(p.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.Replies.Where(r => r.Day <= d.Day && (r.AuthorId == person.Id || IsPlayer(d, r.AuthorId))).Select(r => r.Day).Append(p.Day).Max`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`p.Replies.Where(r => r.Day <= d.Day && (r.AuthorId == person.Id || IsPlayer(d, r.AuthorId))).Select(r => r.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.Replies.Where(r => r.Day <= d.Day && (r.AuthorId == person.Id || IsPlayer(d, r.AuthorId))).Select(r => r.Day).Append`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`p.Replies.Where(r => r.Day <= d.Day && (r.AuthorId == person.Id || IsPlayer(d, r.AuthorId)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.Replies.Where(r => r.Day <= d.Day && (r.AuthorId == person.Id || IsPlayer(d, r.AuthorId))).Select`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7af32d4a06f5"></a>

## `Topic(NationalSpire.CommunityPost) — bool Topic(CommunityPost p)`

来源：源码第 119 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivatePublicContext.Community(NationalSpire.CareerData, NationalSpire.CareerPerson, string, System.Collections.Generic.ISet<string>?, System.Collections.Generic.List<(string Id, string Text)>?, NationalSpire.CommunityMemorySearch.Request?)`](PrivatePublicContext.cs.md#symbol-58aebbb834b8)

**调用：** [`NationalSpire.CommunityMemorySearch.MatchesTopic(string, string, NationalSpire.CommunityMemorySearch.Request?)`](CommunityMemorySearch.cs.md#symbol-9f4e57953da4)

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityMemorySearch.MatchesTopic(string, string, NationalSpire.CommunityMemorySearch.Request?)`；`NationalSpire.CommunityPost.Body`；`NationalSpire.CommunityPost.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityMemorySearch.MatchesTopic(string, string, NationalSpire.CommunityMemorySearch.Request?)`；输入表达式：`CommunityMemorySearch.MatchesTopic(query, p.Title + "\n" + p.Body, request)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => CommunityMemorySearch.MatchesTopic(query, p.Title + "\n" + p.Body, request)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ade3ea2318ca"></a>

## `Add(System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>, int) — void Add(IEnumerable<CommunityPost> sources, int count)`

来源：源码第 121 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivatePublicContext.Community(NationalSpire.CareerData, NationalSpire.CareerPerson, string, System.Collections.Generic.ISet<string>?, System.Collections.Generic.List<(string Id, string Text)>?, NationalSpire.CommunityMemorySearch.Request?)`](PrivatePublicContext.cs.md#symbol-58aebbb834b8)

**调用：** `System.Collections.Generic.ICollection<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityPost.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.ICollection<T>.Contains(T)`；输入表达式：`.Contains(p.Id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: attached?.Contains(p.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`selected.All(s => s.Id != p.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: attached?.Contains(p.Id) != true && selected.All(s => s.Id != p.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`sources.Where(p => attached?.Contains(p.Id) != true && selected.All(s => s.Id != p.Id)).Take(count)`；返回值紧邻使用处：`ArgumentSyntax: sources.Where(p => attached?.Contains(p.Id) != true && selected.All(s => s.Id != p.Id)).Take(count)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`sources.Where(p => attached?.Contains(p.Id) != true && selected.All(s => s.Id != p.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: sources.Where(p => attached?.Contains(p.Id) != true && selected.All(s => s.Id != p.Id)).Take`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`selected.AddRange(sources.Where(p => attached?.Contains(p.Id) != true && selected.All(s => s.Id != p.Id)).Take(count))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => selected.AddRange(sources.Where(p => attached?.Contains(p.Id) != true && selected.All(s => s.Id != p.Id)).Take(count))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b9ef12aab6ca"></a>

## `NationalSpire.PrivatePublicContext.PostText(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CareerPerson, string, System.Collections.Generic.IEnumerable<NationalSpire.CommunityMemory>?, NationalSpire.CommunityMemorySearch.Request?) — public static string PostText(CareerData d, CommunityPost post, CareerPerson person, string query = "", IEnumerable<CommunityMemory>? sourceMemories = null, CommunityMemorySearch.Request? request = null)`

来源：源码第 148 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivatePublicContext.Community(NationalSpire.CareerData, NationalSpire.CareerPerson, string, System.Collections.Generic.ISet<string>?, System.Collections.Generic.List<(string Id, string Text)>?, NationalSpire.CommunityMemorySearch.Request?)`](PrivatePublicContext.cs.md#symbol-58aebbb834b8)

**调用：** [`NationalSpire.PrivatePublicContext.PostTexts(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CareerPerson, string, System.Collections.Generic.IEnumerable<NationalSpire.CommunityMemory>?, NationalSpire.CommunityMemorySearch.Request?)`](PrivatePublicContext.cs.md#symbol-0f3333edf327)

**字段、属性、事件及方法组引用：** `(string Original, string Ai).Ai`；`NationalSpire.PrivatePublicContext.PostTexts(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CareerPerson, string, System.Collections.Generic.IEnumerable<NationalSpire.CommunityMemory>?, NationalSpire.CommunityMemorySearch.Request?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivatePublicContext.PostTexts(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CareerPerson, string, System.Collections.Generic.IEnumerable<NationalSpire.CommunityMemory>?, NationalSpire.CommunityMemorySearch.Request?)`；输入表达式：`PostTexts(d, post, person, query, sourceMemories, request)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PostTexts(d, post, person, query, sourceMemories, request).Ai`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0f3333edf327"></a>

## `NationalSpire.PrivatePublicContext.PostTexts(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CareerPerson, string, System.Collections.Generic.IEnumerable<NationalSpire.CommunityMemory>?, NationalSpire.CommunityMemorySearch.Request?) — public static (string Original, string Ai) PostTexts(CareerData d, CommunityPost post, CareerPerson person, string query = "", IEnumerable<CommunityMemory>? sourceMemories = null, CommunityMemorySearch.Request? request = null)`

来源：源码第 150 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessages.PrepareAttachments(NationalSpire.CareerData, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>)`](PrivateMessages.cs.md#symbol-f2d6d9cf9c86)；[`NationalSpire.PrivatePublicContext.PostText(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CareerPerson, string, System.Collections.Generic.IEnumerable<NationalSpire.CommunityMemory>?, NationalSpire.CommunityMemorySearch.Request?)`](PrivatePublicContext.cs.md#symbol-b9ef12aab6ca)

**调用：** [`Both(string)`](PrivatePublicContext.cs.md#symbol-dd76b14ba329)；[`NationalSpire.AiGeneratedText.Source(NationalSpire.CommunityPost)`](AiGeneratedText.cs.md#symbol-ac6ac5681f0e)；[`NationalSpire.CommunityMemorySearch.MatchesTopic(string, string, NationalSpire.CommunityMemorySearch.Request?)`](CommunityMemorySearch.cs.md#symbol-9f4e57953da4)；[`NationalSpire.CommunityThreads.ContextReplies(NationalSpire.CommunityPost, int, bool, System.Collections.Generic.IEnumerable<string>?)`](CommunityThreads.cs.md#symbol-3e0f576a5190)；[`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`](CommunityThreads.cs.md#symbol-1d3cb55b1636)；[`NationalSpire.GameText.Plain(string)`](GameText.cs.md#symbol-e2c48dec4564)；[`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`](PrivateAppointments.cs.md#symbol-1c549626b284)；[`NationalSpire.PrivatePublicContext.IsPlayer(NationalSpire.CareerData, string)`](PrivatePublicContext.cs.md#symbol-9d4f1ec3280e)；[`NationalSpire.PrivatePublicContext.Name(NationalSpire.CareerData, string)`](PrivatePublicContext.cs.md#symbol-fb5bb85205d3)；`string.Trim()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；`System.Text.StringBuilder.StringBuilder()`；`System.Text.StringBuilder.StringBuilder(string?)`；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `Both(string)`；`NationalSpire.AiGeneratedText.Source(NationalSpire.CommunityPost)`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CommunityMemory.Id`；`NationalSpire.CommunityMemory.PostId`；`NationalSpire.CommunityMemorySearch.MatchesTopic(string, string, NationalSpire.CommunityMemorySearch.Request?)`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.Body`；`NationalSpire.CommunityPost.Day`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityPost.SourceBody`；`NationalSpire.CommunityPost.Title`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.CommunityReply.Body`；`NationalSpire.CommunityReply.Day`；`NationalSpire.CommunityReply.Id`；`NationalSpire.CommunityReply.ParentId`；`NationalSpire.CommunityThreads.ContextReplies(NationalSpire.CommunityPost, int, bool, System.Collections.Generic.IEnumerable<string>?)`；`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.GameText.Plain(string)`；`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；`NationalSpire.PrivatePublicContext.IsPlayer(NationalSpire.CareerData, string)`；`NationalSpire.PrivatePublicContext.Name(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Both(string)`；输入表达式：`Both($"{PrivateAppointments.DateText(d, reply.Day)}，{Name(d, reply.AuthorId)}回复{target}：{reply.Body}")`；返回值紧邻使用处：`ExpressionStatementSyntax: Both($"{PrivateAppointments.DateText(d, reply.Day)}，{Name(d, reply.AuthorId)}回复{target}：{reply.Body}");`
- `Both(string)`；输入表达式：`Both(conversation.Count == replies.Count ? "帖子讨论（完整记录）：" : "帖子讨论（开头、近期发言与相关回复分支）：")`；返回值紧邻使用处：`ExpressionStatementSyntax: Both(conversation.Count == replies.Count ? "帖子讨论（完整记录）：" : "帖子讨论（开头、近期发言与相关回复分支）：");`
- `NationalSpire.AiGeneratedText.Source(NationalSpire.CommunityPost)`；输入表达式：`AiGeneratedText.Source(post)`；返回值紧邻使用处：`ArgumentSyntax: AiGeneratedText.Source(post)`
- `NationalSpire.CommunityMemorySearch.MatchesTopic(string, string, NationalSpire.CommunityMemorySearch.Request?)`；输入表达式：`CommunityMemorySearch.MatchesTopic(query, r.Body, request)`；返回值紧邻使用处：`BinaryExpressionSyntax: r.Day <= d.Day && CommunityMemorySearch.MatchesTopic(query, r.Body, request)`
- `NationalSpire.CommunityThreads.ContextReplies(NationalSpire.CommunityPost, int, bool, System.Collections.Generic.IEnumerable<string>?)`；输入表达式：`CommunityThreads.ContextReplies(post, d.Day, anchors: chosen)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityThreads.ContextReplies(post, d.Day, anchors: chosen)`
- `NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`CommunityThreads.IsHuman(d, post.AuthorId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CommunityThreads.IsHuman(d, post.AuthorId)`
- `NationalSpire.GameText.Plain(string)`；输入表达式：`GameText.Plain(AiGeneratedText.Source(post))`；返回值紧邻使用处：`InterpolationSyntax: {GameText.Plain(AiGeneratedText.Source(post))}`
- `NationalSpire.GameText.Plain(string)`；输入表达式：`GameText.Plain(post.SourceBody)`；返回值紧邻使用处：`InterpolationSyntax: {GameText.Plain(post.SourceBody)}`
- `NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；输入表达式：`PrivateAppointments.DateText(d, post.Day)`；返回值紧邻使用处：`InterpolationSyntax: {PrivateAppointments.DateText(d, post.Day)}`
- `NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；输入表达式：`PrivateAppointments.DateText(d, reply.Day)`；返回值紧邻使用处：`InterpolationSyntax: {PrivateAppointments.DateText(d, reply.Day)}`
- `NationalSpire.PrivatePublicContext.IsPlayer(NationalSpire.CareerData, string)`；输入表达式：`IsPlayer(d, r.AuthorId)`；返回值紧邻使用处：`BinaryExpressionSyntax: r.AuthorId == person.Id || IsPlayer(d, r.AuthorId)`
- `NationalSpire.PrivatePublicContext.Name(NationalSpire.CareerData, string)`；输入表达式：`Name(d, parent.AuthorId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: replies.TryGetValue(reply.ParentId, out var parent) ? Name(d, parent.AuthorId) : "原帖"`
- `NationalSpire.PrivatePublicContext.Name(NationalSpire.CareerData, string)`；输入表达式：`Name(d, post.AuthorId)`；返回值紧邻使用处：`InterpolationSyntax: {Name(d, post.AuthorId)}`
- `NationalSpire.PrivatePublicContext.Name(NationalSpire.CareerData, string)`；输入表达式：`Name(d, reply.AuthorId)`；返回值紧邻使用处：`InterpolationSyntax: {Name(d, reply.AuthorId)}`
- `string.Trim()`；输入表达式：`b.ToString().Trim()`；返回值紧邻使用处：`ArgumentSyntax: b.ToString().Trim()`
- `string.Trim()`；输入表达式：`original.ToString().Trim()`；返回值紧邻使用处：`ArgumentSyntax: original.ToString().Trim()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`replies.TryGetValue(reply.ParentId, out var parent)`；返回值紧邻使用处：`ConditionalExpressionSyntax: replies.TryGetValue(reply.ParentId, out var parent) ? Name(d, parent.AuthorId) : "原帖"`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`chosen.Add(reply.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: chosen.Add(reply.Id);`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`post.Replies.Where(r => r.Day <= d.Day && (r.AuthorId == person.Id || IsPlayer(d, r.AuthorId))).TakeLast(6)                  .Concat(post.Replies.Where(r => r.Day <= d.Day && CommunityMemorySearch.MatchesTopic(query, r.Body, request)).TakeLast(2))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: post.Replies.Where(r => r.Day <= d.Day && (r.AuthorId == person.Id || IsPlayer(d, r.AuthorId))).TakeLast(6)                  .Concat(post.Replies.Where(r => r.Day <= d.Day && CommunityMemorySearch.MatchesTopic(query, r.Body, request)).TakeLast(2)).Select`
- `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`post.Replies.Where(r => r.Day <= d.Day).DistinctBy(r => r.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: post.Replies.Where(r => r.Day <= d.Day).DistinctBy(r => r.Id).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`post.Replies.Where(r => r.Day <= d.Day && (r.AuthorId == person.Id || IsPlayer(d, r.AuthorId))).TakeLast(6)                  .Concat(post.Replies.Where(r => r.Day <= d.Day && CommunityMemorySearch.MatchesTopic(query, r.Body, request)).TakeLast(2)).Select(r => r.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: post.Replies.Where(r => r.Day <= d.Day && (r.AuthorId == person.Id || IsPlayer(d, r.AuthorId))).TakeLast(6)                  .Concat(post.Replies.Where(r => r.Day <= d.Day && CommunityMemorySearch.MatchesTopic(query, r.Body, request)).TakeLast(2)).Select(r => r.Id).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；输入表达式：`post.Replies.Where(r => r.Day <= d.Day && (r.AuthorId == person.Id || IsPlayer(d, r.AuthorId))).TakeLast(6)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: post.Replies.Where(r => r.Day <= d.Day && (r.AuthorId == person.Id || IsPlayer(d, r.AuthorId))).TakeLast(6)                  .Concat`
- `System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；输入表达式：`post.Replies.Where(r => r.Day <= d.Day && CommunityMemorySearch.MatchesTopic(query, r.Body, request)).TakeLast(2)`；返回值紧邻使用处：`ArgumentSyntax: post.Replies.Where(r => r.Day <= d.Day && CommunityMemorySearch.MatchesTopic(query, r.Body, request)).TakeLast(2)`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`post.Replies.Where(r => r.Day <= d.Day).DistinctBy(r => r.Id).ToDictionary(r => r.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = post.Replies.Where(r => r.Day <= d.Day).DistinctBy(r => r.Id).ToDictionary(r => r.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`post.Replies.Where(r => r.Day <= d.Day && (r.AuthorId == person.Id || IsPlayer(d, r.AuthorId))).TakeLast(6)                  .Concat(post.Replies.Where(r => r.Day <= d.Day && CommunityMemorySearch.MatchesTopic(query, r.Body, request)).TakeLast(2)).Select(r => r.Id).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = post.Replies.Where(r => r.Day <= d.Day && (r.AuthorId == person.Id || IsPlayer(d, r.AuthorId))).TakeLast(6)                  .Concat(post.Replies.Where(r => r.Day <= d.Day && CommunityMemorySearch.MatchesTopic(query, r.Body, request)).TakeLast(2)).Select(r => r.Id).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`memories.Where(m => m.PostId == post.Id)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var memory in memories.Where(m => m.PostId == post.Id))                  foreach (var reply in replies.Values.Where(r => memory.Id == post.Id + ":" + r.Id)) chosen.Add(reply.Id);`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`post.Replies.Where(r => r.Day <= d.Day && (r.AuthorId == person.Id || IsPlayer(d, r.AuthorId)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: post.Replies.Where(r => r.Day <= d.Day && (r.AuthorId == person.Id || IsPlayer(d, r.AuthorId))).TakeLast`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`post.Replies.Where(r => r.Day <= d.Day && CommunityMemorySearch.MatchesTopic(query, r.Body, request))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: post.Replies.Where(r => r.Day <= d.Day && CommunityMemorySearch.MatchesTopic(query, r.Body, request)).TakeLast`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`post.Replies.Where(r => r.Day <= d.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: post.Replies.Where(r => r.Day <= d.Day).DistinctBy`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`replies.Values.Where(r => memory.Id == post.Id + ":" + r.Id)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var reply in replies.Values.Where(r => memory.Id == post.Id + ":" + r.Id)) chosen.Add(reply.Id);`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"\n《{post.Title}》｜{PrivateAppointments.DateText(d, post.Day)}｜发帖者：{Name(d, post.AuthorId)}")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"\n《{post.Title}》｜{PrivateAppointments.DateText(d, post.Day)}｜发帖者：{Name(d, post.AuthorId)}");`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"帖子原文（{Name(d, post.AuthorId)}的公开发言）：\n{post.Body}")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"帖子原文（{Name(d, post.AuthorId)}的公开发言）：\n{post.Body}");`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`b.AppendLine($"这篇帖子对应的已记录事件：{GameText.Plain(AiGeneratedText.Source(post))}")`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine($"这篇帖子对应的已记录事件：{GameText.Plain(AiGeneratedText.Source(post))}");`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`original.AppendLine($"这篇帖子对应的已记录事件：{GameText.Plain(post.SourceBody)}")`；返回值紧邻使用处：`ExpressionStatementSyntax: original.AppendLine($"这篇帖子对应的已记录事件：{GameText.Plain(post.SourceBody)}");`
- `System.Text.StringBuilder.StringBuilder()`；输入表达式：`new StringBuilder()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StringBuilder()`
- `System.Text.StringBuilder.StringBuilder(string?)`；输入表达式：`new StringBuilder(b.ToString())`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StringBuilder(b.ToString())`
- `System.Text.StringBuilder.ToString()`；输入表达式：`b.ToString()`；返回值紧邻使用处：`ArgumentSyntax: b.ToString()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`b.ToString()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: b.ToString().Trim`
- `System.Text.StringBuilder.ToString()`；输入表达式：`original.ToString()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: original.ToString().Trim`

**赋值（含属性/字段和局部值）：**


<a id="symbol-dd76b14ba329"></a>

## `Both(string) — void Both(string line)`

来源：源码第 157 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivatePublicContext.PostTexts(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CareerPerson, string, System.Collections.Generic.IEnumerable<NationalSpire.CommunityMemory>?, NationalSpire.CommunityMemorySearch.Request?)`](PrivatePublicContext.cs.md#symbol-0f3333edf327)

**调用：** `System.Text.StringBuilder.AppendLine(string?)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Text.StringBuilder.AppendLine(string?)`；输入表达式：`b.AppendLine(line)`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AppendLine(line);`
- `System.Text.StringBuilder.AppendLine(string?)`；输入表达式：`original.AppendLine(line)`；返回值紧邻使用处：`ExpressionStatementSyntax: original.AppendLine(line);`

**赋值（含属性/字段和局部值）：**
