# RelationshipPresentation.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`3B70D041926FB967FAD4D7911AB9A0CF57F7A3FF65DB98792C87579124247AD5`。来源：[源码](../../RelationshipPresentation.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.RelationshipAppearance`、`NationalSpire.RelationshipPresentation`。

字段、事件及初始值（源码原样）：

```csharp

```

<a id="symbol-46c9c691f66a"></a>

## `NationalSpire.RelationshipPresentation.Tier(int) — public static int Tier(int favour)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AffectionBadge._Draw()`](AffectionVisuals.cs.md#symbol-dc75b39bdb21)；[`NationalSpire.PrivateRelation.RefreshAppearance()`](PrivateMessageData.cs.md#symbol-fbf6e9bf540b)；[`NationalSpire.RelationshipPresentation.Progress(int)`](RelationshipPresentation.cs.md#symbol-d986c8a42da8)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-490ba5274317"></a>

## `NationalSpire.RelationshipPresentation.Range(int) — public static (int Low, int High) Range(int tier)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.RelationshipPresentation.Progress(int)`](RelationshipPresentation.cs.md#symbol-d986c8a42da8)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d986c8a42da8"></a>

## `NationalSpire.RelationshipPresentation.Progress(int) — public static float Progress(int favour)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AffectionBadge._Draw()`](AffectionVisuals.cs.md#symbol-dc75b39bdb21)

**调用：** [`NationalSpire.RelationshipPresentation.Range(int)`](RelationshipPresentation.cs.md#symbol-490ba5274317)；[`NationalSpire.RelationshipPresentation.Tier(int)`](RelationshipPresentation.cs.md#symbol-46c9c691f66a)；`System.Math.Clamp(float, float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.RelationshipPresentation.Range(int)`；`NationalSpire.RelationshipPresentation.Tier(int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RelationshipPresentation.Range(int)`；输入表达式：`Range(Tier(favour))`；返回值紧邻使用处：`AssignmentExpressionSyntax: var (low, high) = Range(Tier(favour))`
- `NationalSpire.RelationshipPresentation.Tier(int)`；输入表达式：`Tier(favour)`；返回值紧邻使用处：`ArgumentSyntax: Tier(favour)`
- `System.Math.Clamp(float, float, float)`；输入表达式：`Math.Clamp((favour - low) / (float)(high - low), 0, 1)`；返回值紧邻使用处：`ReturnStatementSyntax: return Math.Clamp((favour - low) / (float)(high - low), 0, 1);`

**赋值（含属性/字段和局部值）：**

- `var (low, high)` = `Range(Tier(favour))`

<a id="symbol-bac5ded19066"></a>

## `NationalSpire.RelationshipPresentation.OathAppearance(NationalSpire.PrivateRelation?) — public static bool OathAppearance(PrivateRelation? relation)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AffectionBadge._Draw()`](AffectionVisuals.cs.md#symbol-dc75b39bdb21)；[`NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`](AvatarHonors.cs.md#symbol-5207a1627331)；[`NationalSpire.CareerScreen.OpenCharacterCardCore(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?, NationalSpire.CharacterDesignPackage.Imported?)`](CharacterCardScreen.cs.md#symbol-c2fe452ad056)；[`NationalSpire.NpcAvatarFrames.Locked(NationalSpire.PrivateRelation, string)`](NpcAvatarFrames.cs.md#symbol-fd1fec9d14c5)；[`NationalSpire.RelationshipPresentation.Bond(NationalSpire.PrivateRelation)`](RelationshipPresentation.cs.md#symbol-e3889e06e77f)；[`NationalSpire.RelationshipPresentation.Context(NationalSpire.PrivateRelation)`](RelationshipPresentation.cs.md#symbol-c7ee26e64717)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateRelation.OathConfirmed`；`NationalSpire.PrivateRelation.WeddingCompleted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e3889e06e77f"></a>

## `NationalSpire.RelationshipPresentation.Bond(NationalSpire.PrivateRelation) — public static string Bond(PrivateRelation relation)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.RelationshipPresentation.IconBond(NationalSpire.PrivateRelation)`](RelationshipPresentation.cs.md#symbol-d6b37bf58f98)

**调用：** [`NationalSpire.RelationshipPresentation.OathAppearance(NationalSpire.PrivateRelation?)`](RelationshipPresentation.cs.md#symbol-bac5ded19066)

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateRelation.Appearance`；`NationalSpire.RelationshipAppearance.Lover`；`NationalSpire.RelationshipPresentation.OathAppearance(NationalSpire.PrivateRelation?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RelationshipPresentation.OathAppearance(NationalSpire.PrivateRelation?)`；输入表达式：`OathAppearance(relation)`；返回值紧邻使用处：`ConditionalExpressionSyntax: OathAppearance(relation) ? "oath" : relation.Appearance.Lover ? "lover" : "none"`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d6b37bf58f98"></a>

## `NationalSpire.RelationshipPresentation.IconBond(NationalSpire.PrivateRelation) — public static string IconBond(PrivateRelation relation)`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.PrivateIdentity(NationalSpire.CareerData, string, bool)`](PrivateMemoryScreen.cs.md#symbol-65caddca194f)；[`NationalSpire.CareerScreen.ShowPrivateListRows()`](PrivateListRows.cs.md#symbol-a42f68b15faf)

**调用：** [`NationalSpire.RelationshipPresentation.Bond(NationalSpire.PrivateRelation)`](RelationshipPresentation.cs.md#symbol-e3889e06e77f)

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateRelation.Favour`；`NationalSpire.RelationshipPresentation.Bond(NationalSpire.PrivateRelation)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RelationshipPresentation.Bond(NationalSpire.PrivateRelation)`；输入表达式：`Bond(relation)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Bond(relation) is var bond`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3ff059aada88"></a>

## `NationalSpire.RelationshipPresentation.Unlocked(NationalSpire.PrivateRelation) — public static int Unlocked(PrivateRelation relation)`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateRelation.HighestBond`；`NationalSpire.PrivateRelation.OathConfirmed`；`NationalSpire.PrivateRelation.SelectedBond`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Max(int, int)`；输入表达式：`Math.Max(relation.HighestBond, relation.OathConfirmed ? 2 : relation.SelectedBond >= 1 ? 1 : 0)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Math.Max(relation.HighestBond, relation.OathConfirmed ? 2 : relation.SelectedBond >= 1 ? 1 : 0)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-49a406ddaa23"></a>

## `NationalSpire.RelationshipPresentation.CompleteWedding(NationalSpire.CareerData, string) — public static void CompleteWedding(CareerData data, string person)`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.WeddingAppointments.Complete(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-4cb46102c2e0)

**调用：** [`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.PrivateInteractionHistory.PreserveRelation(NationalSpire.PrivateMailbox, NationalSpire.ChatWorld, string, string, System.Collections.Generic.IReadOnlyList<string>)`](PrivateInteractionUndo.cs.md#symbol-9f5887b5e53e)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；[`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-8a6bb6e78fa5)；[`NationalSpire.PrivateRelation.RefreshAppearance()`](PrivateMessageData.cs.md#symbol-fbf6e9bf540b)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Chats`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.PrivateInteractionHistory.PreserveRelation(NationalSpire.PrivateMailbox, NationalSpire.ChatWorld, string, string, System.Collections.Generic.IReadOnlyList<string>)`；`NationalSpire.PrivateMailbox.NpcAvatarFrames`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateRelation.OathConfirmed`；`NationalSpire.PrivateRelation.RefreshAppearance()`；`NationalSpire.PrivateRelation.Revision`；`NationalSpire.PrivateRelation.SelectedBond`；`NationalSpire.PrivateRelation.WeddingCompleted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(data)`；返回值紧邻使用处：`ArgumentSyntax: GroupChats.Human(data)`
- `NationalSpire.PrivateInteractionHistory.PreserveRelation(NationalSpire.PrivateMailbox, NationalSpire.ChatWorld, string, string, System.Collections.Generic.IReadOnlyList<string>)`；输入表达式：`PrivateInteractionHistory.PreserveRelation(PrivateMessages.Mailbox(data), data.Chats, GroupChats.Human(data), person, [nameof(PrivateRelation.WeddingCompleted), nameof(PrivateRelation.OathConfirmed), nameof(PrivateRelation.SelectedBond)])`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateInteractionHistory.PreserveRelation(PrivateMessages.Mailbox(data), data.Chats, GroupChats.Human(data), person, [nameof(PrivateRelation.WeddingCompleted), nameof(PrivateRelation.OathConfirmed), nameof(PrivateRelation.SelectedBond)]);`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).NpcAvatarFrames`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`ArgumentSyntax: PrivateMessages.Mailbox(data)`
- `NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Relation(data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Relation(data, person)`
- `NationalSpire.PrivateRelation.RefreshAppearance()`；输入表达式：`relation.RefreshAppearance()`；返回值紧邻使用处：`ExpressionStatementSyntax: relation.RefreshAppearance();`

**赋值（含属性/字段和局部值）：**

- `PrivateMessages.Mailbox(data).NpcAvatarFrames[person]` = `"oath"`
- `relation.OathConfirmed` = `true`
- `relation.SelectedBond` = `2`
- `relation.WeddingCompleted` = `true`

<a id="symbol-c7ee26e64717"></a>

## `NationalSpire.RelationshipPresentation.Context(NationalSpire.PrivateRelation) — public static string Context(PrivateRelation relation)`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)；[`NationalSpire.PrivateMessagePrompts.Context(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-4b9d12b26f65)

**调用：** [`NationalSpire.RelationshipPresentation.OathAppearance(NationalSpire.PrivateRelation?)`](RelationshipPresentation.cs.md#symbol-bac5ded19066)

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateRelation.SelectedBond`；`NationalSpire.PrivateRelation.WeddingCompleted`；`NationalSpire.RelationshipPresentation.OathAppearance(NationalSpire.PrivateRelation?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RelationshipPresentation.OathAppearance(NationalSpire.PrivateRelation?)`；输入表达式：`OathAppearance(relation)`；返回值紧邻使用处：`ConditionalExpressionSyntax: OathAppearance(relation) ? "已缔结誓约" : relation.SelectedBond >= 1 ? "恋人" : "尚未确定恋人关系"`

**赋值（含属性/字段和局部值）：**
