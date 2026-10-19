# RelationshipPresentation.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`04EE62F246BC4649BE215643588BDCF860C728A0DF5344C851098E6DD52BF925`。来源：[源码](../../RelationshipPresentation.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.RelationshipAppearance`、`NationalSpire.RelationshipPresentation`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly string[] Lovers = ["恋人", "情人", "爱人", "情侣", "伴侣", "男朋友", "女朋友", "男友", "女友", "专属"];
private static readonly string[] Spouses = ["妻子", "丈夫", "老公", "老婆", "终身伴侣", "誓约", "夫妻", "配偶"];
private static readonly Regex Negative = new(@"(?:不是|并非|并不|不再|尚未|还未|未曾|没有|拒绝|解除|取消|曾是|曾经是|前任|前|非)(?:成为|是|作为|的|了|一对|彼此的|对方的)?(?:终身)?\s*$", RegexOptions.CultureInvariant);
```

<a id="symbol-46c9c691f66a"></a>

## `NationalSpire.RelationshipPresentation.Tier(int) — public static int Tier(int favour)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AffectionBadge._Draw()`](AffectionVisuals.cs.md#symbol-dc75b39bdb21)；[`NationalSpire.RelationshipPresentation.Evaluate(int, string)`](RelationshipPresentation.cs.md#symbol-d52dcd40f222)；[`NationalSpire.RelationshipPresentation.Progress(int)`](RelationshipPresentation.cs.md#symbol-d986c8a42da8)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-490ba5274317"></a>

## `NationalSpire.RelationshipPresentation.Range(int) — public static (int Low, int High) Range(int tier)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.RelationshipPresentation.Progress(int)`](RelationshipPresentation.cs.md#symbol-d986c8a42da8)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d986c8a42da8"></a>

## `NationalSpire.RelationshipPresentation.Progress(int) — public static float Progress(int favour)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AffectionBadge._Draw()`](AffectionVisuals.cs.md#symbol-dc75b39bdb21)

**调用：** [`NationalSpire.RelationshipPresentation.Range(int)`](RelationshipPresentation.cs.md#symbol-490ba5274317)；[`NationalSpire.RelationshipPresentation.Tier(int)`](RelationshipPresentation.cs.md#symbol-46c9c691f66a)；`System.Math.Clamp(float, float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.RelationshipPresentation.Range(int)`；`NationalSpire.RelationshipPresentation.Tier(int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RelationshipPresentation.Range(int)`；输入表达式：`Range(Tier(favour))`；返回值紧邻使用处：`AssignmentExpressionSyntax: var (low, high) = Range(Tier(favour))`
- `NationalSpire.RelationshipPresentation.Tier(int)`；输入表达式：`Tier(favour)`；返回值紧邻使用处：`ArgumentSyntax: Tier(favour)`
- `System.Math.Clamp(float, float, float)`；输入表达式：`Math.Clamp((favour - low) / (float)(high - low), 0, 1)`；返回值紧邻使用处：`ReturnStatementSyntax: return Math.Clamp((favour - low) / (float)(high - low), 0, 1);`

**赋值（含属性/字段和局部值）：**

- `var (low, high)` = `Range(Tier(favour))`

<a id="symbol-d52dcd40f222"></a>

## `NationalSpire.RelationshipPresentation.Evaluate(int, string) — public static RelationshipAppearance Evaluate(int favour, string relationship)`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateRelation.RefreshAppearance()`](PrivateMessageData.cs.md#symbol-fbf6e9bf540b)

**调用：** `NationalSpire.RelationshipAppearance.RelationshipAppearance(int, bool, bool)`；[`NationalSpire.RelationshipPresentation.HasKeyword(string, System.Collections.Generic.IEnumerable<string>)`](RelationshipPresentation.cs.md#symbol-383115a2b81c)；[`NationalSpire.RelationshipPresentation.Tier(int)`](RelationshipPresentation.cs.md#symbol-46c9c691f66a)

**字段、属性、事件及方法组引用：** `NationalSpire.RelationshipPresentation.HasKeyword(string, System.Collections.Generic.IEnumerable<string>)`；`NationalSpire.RelationshipPresentation.Lovers`；`NationalSpire.RelationshipPresentation.Spouses`；`NationalSpire.RelationshipPresentation.Tier(int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RelationshipAppearance.RelationshipAppearance(int, bool, bool)`；输入表达式：`new(tier, false, false)`；返回值紧邻使用处：`ReturnStatementSyntax: return new(tier, false, false);`
- `NationalSpire.RelationshipAppearance.RelationshipAppearance(int, bool, bool)`；输入表达式：`new(tier, spouse || HasKeyword(relationship, Lovers), favour == 100 && spouse)`；返回值紧邻使用处：`ReturnStatementSyntax: return new(tier, spouse || HasKeyword(relationship, Lovers), favour == 100 && spouse);`
- `NationalSpire.RelationshipPresentation.HasKeyword(string, System.Collections.Generic.IEnumerable<string>)`；输入表达式：`HasKeyword(relationship, Lovers)`；返回值紧邻使用处：`BinaryExpressionSyntax: spouse || HasKeyword(relationship, Lovers)`
- `NationalSpire.RelationshipPresentation.HasKeyword(string, System.Collections.Generic.IEnumerable<string>)`；输入表达式：`HasKeyword(relationship, Spouses)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = HasKeyword(relationship, Spouses)`
- `NationalSpire.RelationshipPresentation.Tier(int)`；输入表达式：`Tier(favour)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Tier(favour)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-383115a2b81c"></a>

## `NationalSpire.RelationshipPresentation.HasKeyword(string, System.Collections.Generic.IEnumerable<string>) — private static bool HasKeyword(string text, IEnumerable<string> words)`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.RelationshipPresentation.Evaluate(int, string)`](RelationshipPresentation.cs.md#symbol-d52dcd40f222)；[`NationalSpire.RelationshipPresentation.IsRomantic(string)`](RelationshipPresentation.cs.md#symbol-e8efb463e09b)

**调用：** `System.Math.Max(int, int)`；`System.Math.Min(int, int)`；`System.Text.RegularExpressions.Regex.IsMatch(string)`；`string.IndexOf(string, System.StringComparison)`；`string.IndexOf(string, int, System.StringComparison)`；`string.Substring(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.RelationshipPresentation.Negative`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, index - 12)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, index - 12)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(12, index)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(12, index)`
- `System.Text.RegularExpressions.Regex.IsMatch(string)`；输入表达式：`Negative.IsMatch(prefix)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Negative.IsMatch(prefix)`
- `string.IndexOf(string, System.StringComparison)`；输入表达式：`text.IndexOf(word, StringComparison.Ordinal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = text.IndexOf(word, StringComparison.Ordinal)`
- `string.IndexOf(string, int, System.StringComparison)`；输入表达式：`text.IndexOf(word, index + word.Length, StringComparison.Ordinal)`；返回值紧邻使用处：`AssignmentExpressionSyntax: index = text.IndexOf(word, index + word.Length, StringComparison.Ordinal)`
- `string.Substring(int, int)`；输入表达式：`text.Substring(Math.Max(0, index - 12), Math.Min(12, index))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = text.Substring(Math.Max(0, index - 12), Math.Min(12, index))`

**赋值（含属性/字段和局部值）：**

- `index` = `text.IndexOf(word, index + word.Length, StringComparison.Ordinal)`

<a id="symbol-e8efb463e09b"></a>

## `NationalSpire.RelationshipPresentation.IsRomantic(string) — public static bool IsRomantic(string relationship)`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.NpcAvatarFrames.Locked(NationalSpire.PrivateRelation, string)`](NpcAvatarFrames.cs.md#symbol-fd1fec9d14c5)

**调用：** [`NationalSpire.RelationshipPresentation.HasKeyword(string, System.Collections.Generic.IEnumerable<string>)`](RelationshipPresentation.cs.md#symbol-383115a2b81c)

**字段、属性、事件及方法组引用：** `NationalSpire.RelationshipPresentation.HasKeyword(string, System.Collections.Generic.IEnumerable<string>)`；`NationalSpire.RelationshipPresentation.Lovers`；`NationalSpire.RelationshipPresentation.Spouses`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RelationshipPresentation.HasKeyword(string, System.Collections.Generic.IEnumerable<string>)`；输入表达式：`HasKeyword(relationship, Lovers)`；返回值紧邻使用处：`BinaryExpressionSyntax: HasKeyword(relationship, Lovers) || HasKeyword(relationship, Spouses)`
- `NationalSpire.RelationshipPresentation.HasKeyword(string, System.Collections.Generic.IEnumerable<string>)`；输入表达式：`HasKeyword(relationship, Spouses)`；返回值紧邻使用处：`BinaryExpressionSyntax: HasKeyword(relationship, Lovers) || HasKeyword(relationship, Spouses)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-bac5ded19066"></a>

## `NationalSpire.RelationshipPresentation.OathAppearance(NationalSpire.PrivateRelation?) — public static bool OathAppearance(PrivateRelation? relation)`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AffectionBadge._Draw()`](AffectionVisuals.cs.md#symbol-dc75b39bdb21)；[`NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`](AvatarHonors.cs.md#symbol-5207a1627331)；[`NationalSpire.CareerScreen.OpenCharacterCardCore(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?, NationalSpire.CharacterDesignPackage.Imported?)`](CharacterCardScreen.cs.md#symbol-c2fe452ad056)；[`NationalSpire.NpcAvatarFrames.Locked(NationalSpire.PrivateRelation, string)`](NpcAvatarFrames.cs.md#symbol-fd1fec9d14c5)；[`NationalSpire.RelationshipPresentation.Bond(NationalSpire.PrivateRelation)`](RelationshipPresentation.cs.md#symbol-e3889e06e77f)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateRelation.OathConfirmed`；`NationalSpire.PrivateRelation.WeddingCompleted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e3889e06e77f"></a>

## `NationalSpire.RelationshipPresentation.Bond(NationalSpire.PrivateRelation) — public static string Bond(PrivateRelation relation)`

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RefreshGroupChat()`](GroupChatScreen.cs.md#symbol-b56fe79b2db7)；[`NationalSpire.RelationshipPresentation.IconBond(NationalSpire.PrivateRelation)`](RelationshipPresentation.cs.md#symbol-d6b37bf58f98)

**调用：** [`NationalSpire.RelationshipPresentation.OathAppearance(NationalSpire.PrivateRelation?)`](RelationshipPresentation.cs.md#symbol-bac5ded19066)

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateRelation.Appearance`；`NationalSpire.RelationshipAppearance.Lover`；`NationalSpire.RelationshipPresentation.OathAppearance(NationalSpire.PrivateRelation?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RelationshipPresentation.OathAppearance(NationalSpire.PrivateRelation?)`；输入表达式：`OathAppearance(relation)`；返回值紧邻使用处：`ConditionalExpressionSyntax: OathAppearance(relation) ? "oath" : relation.Appearance.Lover ? "lover" : "none"`

**赋值（含属性/字段和局部值）：**


<a id="symbol-49a406ddaa23"></a>

## `NationalSpire.RelationshipPresentation.CompleteWedding(NationalSpire.CareerData, string) — public static void CompleteWedding(CareerData data, string person)`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.Leave(NationalSpire.CareerData, NationalSpire.PrivateConversation, string, bool)`](DateSceneData.cs.md#symbol-81bdbfbfe1d8)

**调用：** [`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.PrivateInteractionHistory.PreserveRelation(NationalSpire.PrivateMailbox, NationalSpire.ChatWorld, string, string, System.Collections.Generic.IReadOnlyList<string>)`](PrivateInteractionUndo.cs.md#symbol-9f5887b5e53e)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；[`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-8a6bb6e78fa5)；[`NationalSpire.PrivateRelation.RefreshAppearance()`](PrivateMessageData.cs.md#symbol-fbf6e9bf540b)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Chats`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.PrivateInteractionHistory.PreserveRelation(NationalSpire.PrivateMailbox, NationalSpire.ChatWorld, string, string, System.Collections.Generic.IReadOnlyList<string>)`；`NationalSpire.PrivateMailbox.NpcAvatarFrames`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateRelation.HighestBond`；`NationalSpire.PrivateRelation.OathConfirmed`；`NationalSpire.PrivateRelation.OathDeferred`；`NationalSpire.PrivateRelation.OathPromptHidden`；`NationalSpire.PrivateRelation.OathReleaseReason`；`NationalSpire.PrivateRelation.OathReleaseTurn`；`NationalSpire.PrivateRelation.RefreshAppearance()`；`NationalSpire.PrivateRelation.Revision`；`NationalSpire.PrivateRelation.SelectedBond`；`NationalSpire.PrivateRelation.WeddingCompleted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(data)`；返回值紧邻使用处：`ArgumentSyntax: GroupChats.Human(data)`
- `NationalSpire.PrivateInteractionHistory.PreserveRelation(NationalSpire.PrivateMailbox, NationalSpire.ChatWorld, string, string, System.Collections.Generic.IReadOnlyList<string>)`；输入表达式：`PrivateInteractionHistory.PreserveRelation(mailbox, data.Chats, GroupChats.Human(data), person, [nameof(PrivateRelation.WeddingCompleted), nameof(PrivateRelation.OathConfirmed), nameof(PrivateRelation.HighestBond), nameof(PrivateRelation.SelectedBond), nameof(PrivateRelation.OathDeferred), nameof(PrivateRelation.OathPromptHidden), nameof(PrivateRelation.OathReleaseReason), nameof(PrivateRelation.OathReleaseTurn)])`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateInteractionHistory.PreserveRelation(mailbox, data.Chats, GroupChats.Human(data), person, [nameof(PrivateRelation.WeddingCompleted), nameof(PrivateRelation.OathConfirmed), nameof(PrivateRelation.HighestBond), nameof(PrivateRelation.SelectedBond), nameof(PrivateRelation.OathDeferred), nameof(PrivateRelation.OathPromptHidden), nameof(PrivateRelation.OathReleaseReason), nameof(PrivateRelation.OathReleaseTurn)]);`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Mailbox(data)`
- `NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Relation(data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Relation(data, person)`
- `NationalSpire.PrivateRelation.RefreshAppearance()`；输入表达式：`relation.RefreshAppearance()`；返回值紧邻使用处：`ExpressionStatementSyntax: relation.RefreshAppearance();`

**赋值（含属性/字段和局部值）：**

- `mailbox.NpcAvatarFrames[person]` = `"oath"`
- `relation.HighestBond` = `2`
- `relation.OathConfirmed` = `true`
- `relation.OathDeferred` = `false`
- `relation.OathPromptHidden` = `false`
- `relation.OathReleaseReason` = `relation.OathReleaseTurn = ""`
- `relation.OathReleaseTurn` = `""`
- `relation.SelectedBond` = `2`
- `relation.WeddingCompleted` = `true`

<a id="symbol-d6b37bf58f98"></a>

## `NationalSpire.RelationshipPresentation.IconBond(NationalSpire.PrivateRelation) — public static string IconBond(PrivateRelation relation)`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.PrivateIdentity(NationalSpire.CareerData, string, bool)`](PrivateMemoryScreen.cs.md#symbol-65caddca194f)；[`NationalSpire.CareerScreen.RefreshPrivateList()`](PrivateMessageScreen.cs.md#symbol-fca825e025fa)；[`NationalSpire.CareerScreen.ShowPrivateListRows()`](PrivateListRows.cs.md#symbol-a42f68b15faf)

**调用：** [`NationalSpire.RelationshipPresentation.Bond(NationalSpire.PrivateRelation)`](RelationshipPresentation.cs.md#symbol-e3889e06e77f)

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateRelation.Favour`；`NationalSpire.RelationshipPresentation.Bond(NationalSpire.PrivateRelation)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RelationshipPresentation.Bond(NationalSpire.PrivateRelation)`；输入表达式：`Bond(relation)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Bond(relation) is var bond`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3ff059aada88"></a>

## `NationalSpire.RelationshipPresentation.Unlocked(NationalSpire.PrivateRelation) — public static int Unlocked(PrivateRelation relation)`

来源：源码第 53 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCharacterCardCore(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?, NationalSpire.CharacterDesignPackage.Imported?)`](CharacterCardScreen.cs.md#symbol-c2fe452ad056)；[`NationalSpire.RelationshipPresentation.Edit(NationalSpire.PrivateRelation, int)`](RelationshipPresentation.cs.md#symbol-3907ae6dd3cc)；[`NationalSpire.RelationshipPresentation.EditError(NationalSpire.PrivateRelation, int)`](RelationshipPresentation.cs.md#symbol-6df7387f23e5)

**调用：** `System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateRelation.Appearance`；`NationalSpire.PrivateRelation.HighestBond`；`NationalSpire.PrivateRelation.OathConfirmed`；`NationalSpire.RelationshipAppearance.Lover`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Max(int, int)`；输入表达式：`Math.Max(relation.HighestBond, relation.OathConfirmed ? 2 : relation.Appearance.Lover ? 1 : 0)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Math.Max(relation.HighestBond, relation.OathConfirmed ? 2 : relation.Appearance.Lover ? 1 : 0)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-6df7387f23e5"></a>

## `NationalSpire.RelationshipPresentation.EditError(NationalSpire.PrivateRelation, int) — public static string? EditError(PrivateRelation relation, int value)`

来源：源码第 54 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CharacterCards.Apply(NationalSpire.CareerData, NationalSpire.CharacterCardEdit, NationalSpire.CareerLifeState?, string?)`](CharacterCards.cs.md#symbol-a50771d297a5)；[`NationalSpire.RelationshipPresentation.Edit(NationalSpire.PrivateRelation, int)`](RelationshipPresentation.cs.md#symbol-3907ae6dd3cc)

**调用：** [`NationalSpire.RelationshipPresentation.Unlocked(NationalSpire.PrivateRelation)`](RelationshipPresentation.cs.md#symbol-3ff059aada88)

**字段、属性、事件及方法组引用：** `NationalSpire.RelationshipPresentation.Unlocked(NationalSpire.PrivateRelation)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RelationshipPresentation.Unlocked(NationalSpire.PrivateRelation)`；输入表达式：`Unlocked(relation)`；返回值紧邻使用处：`BinaryExpressionSyntax: value > Unlocked(relation)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3907ae6dd3cc"></a>

## `NationalSpire.RelationshipPresentation.Edit(NationalSpire.PrivateRelation, int) — public static void Edit(PrivateRelation relation, int value)`

来源：源码第 56 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessages.EditRelation(NationalSpire.CareerData, NationalSpire.CareerLifeState, string, string, NationalSpire.CharacterRelationEdit)`](PrivateMessages.cs.md#symbol-721322de5dd7)

**调用：** [`NationalSpire.RelationshipPresentation.EditError(NationalSpire.PrivateRelation, int)`](RelationshipPresentation.cs.md#symbol-6df7387f23e5)；[`NationalSpire.RelationshipPresentation.Unlocked(NationalSpire.PrivateRelation)`](RelationshipPresentation.cs.md#symbol-3ff059aada88)；`System.ArgumentException.ArgumentException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateRelation.HighestBond`；`NationalSpire.PrivateRelation.OathConfirmed`；`NationalSpire.PrivateRelation.OathDeferred`；`NationalSpire.PrivateRelation.OathPromptHidden`；`NationalSpire.PrivateRelation.OathReleaseReason`；`NationalSpire.PrivateRelation.OathReleaseTurn`；`NationalSpire.PrivateRelation.Relationship`；`NationalSpire.PrivateRelation.SelectedBond`；`NationalSpire.RelationshipPresentation.EditError(NationalSpire.PrivateRelation, int)`；`NationalSpire.RelationshipPresentation.Unlocked(NationalSpire.PrivateRelation)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RelationshipPresentation.EditError(NationalSpire.PrivateRelation, int)`；输入表达式：`EditError(relation, value)`；返回值紧邻使用处：`IsPatternExpressionSyntax: EditError(relation, value) is { } error`
- `NationalSpire.RelationshipPresentation.Unlocked(NationalSpire.PrivateRelation)`；输入表达式：`Unlocked(relation)`；返回值紧邻使用处：`AssignmentExpressionSyntax: relation.HighestBond = Unlocked(relation)`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException(error)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException(error);`

**赋值（含属性/字段和局部值）：**

- `relation.HighestBond` = `Unlocked(relation)`
- `relation.OathConfirmed` = `value == 2`
- `relation.OathDeferred` = `true`
- `relation.OathPromptHidden` = `true`
- `relation.OathReleaseReason` = `relation.OathReleaseTurn = ""`
- `relation.OathReleaseTurn` = `""`
- `relation.Relationship` = `value switch { 2 => "婚约", 1 => "恋人", _ => "熟人" }`
- `relation.SelectedBond` = `value`

<a id="symbol-808145b97462"></a>

## `NationalSpire.RelationshipPresentation.Decide(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand) — public static string? Decide(CareerData data, string person, string kind, PrivateMessageCommand command)`

来源：源码第 64 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-81ef5fba41b8)

**调用：** [`NationalSpire.PrivateInteractionHistory.PreserveRelation(NationalSpire.PrivateMailbox, NationalSpire.ChatWorld, string, string, System.Collections.Generic.IReadOnlyList<string>)`](PrivateInteractionUndo.cs.md#symbol-9f5887b5e53e)；[`NationalSpire.PrivateMessages.Enqueue(NationalSpire.CareerData, string, string, NationalSpire.PrivateOffer?, System.Collections.Generic.List<NationalSpire.PrivateOffer>?, bool)`](PrivateMessages.cs.md#symbol-7823819594c6)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；[`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-8a6bb6e78fa5)；[`NationalSpire.PromptInsertions.Copy(System.Collections.Generic.IEnumerable<NationalSpire.PromptInsertion>?)`](PromptInsertions.cs.md#symbol-511fbf5c4ca1)；`string.IsNullOrWhiteSpace(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Chats`；`NationalSpire.CareerData.LocalHumanId`；`NationalSpire.PrivateInteractionHistory.PreserveRelation(NationalSpire.PrivateMailbox, NationalSpire.ChatWorld, string, string, System.Collections.Generic.IReadOnlyList<string>)`；`NationalSpire.PrivateMessageCommand.Part`；`NationalSpire.PrivateMessageCommand.PromptInsertions`；`NationalSpire.PrivateMessageCommand.Text`；`NationalSpire.PrivateMessages.Enqueue(NationalSpire.CareerData, string, string, NationalSpire.PrivateOffer?, System.Collections.Generic.List<NationalSpire.PrivateOffer>?, bool)`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateRelation.Appearance`；`NationalSpire.PrivateRelation.HighestBond`；`NationalSpire.PrivateRelation.OathConfirmed`；`NationalSpire.PrivateRelation.OathDeferred`；`NationalSpire.PrivateRelation.OathPromptHidden`；`NationalSpire.PrivateRelation.OathReleaseReason`；`NationalSpire.PrivateRelation.OathReleaseTurn`；`NationalSpire.PrivateRelation.Revision`；`NationalSpire.PrivateRelation.SelectedBond`；`NationalSpire.PrivateTurn.PromptInsertions`；`NationalSpire.PromptInsertions.Copy(System.Collections.Generic.IEnumerable<NationalSpire.PromptInsertion>?)`；`NationalSpire.RelationshipAppearance.OathEligible`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateInteractionHistory.PreserveRelation(NationalSpire.PrivateMailbox, NationalSpire.ChatWorld, string, string, System.Collections.Generic.IReadOnlyList<string>)`；输入表达式：`PrivateInteractionHistory.PreserveRelation(PrivateMessages.Mailbox(data), data.Chats, data.LocalHumanId.Length > 0 ? data.LocalHumanId : "player", person, [nameof(PrivateRelation.OathConfirmed), nameof(PrivateRelation.HighestBond), nameof(PrivateRelation.SelectedBond), nameof(PrivateRelation.OathDeferred), nameof(PrivateRelation.OathPromptHidden), nameof(PrivateRelation.OathReleaseReason), nameof(PrivateRelation.OathReleaseTurn)])`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateInteractionHistory.PreserveRelation(PrivateMessages.Mailbox(data), data.Chats, data.LocalHumanId.Length > 0 ? data.LocalHumanId : "player", person, [nameof(PrivateRelation.OathConfirmed), nameof(PrivateRelation.HighestBond), nameof(PrivateRelation.SelectedBond), nameof(PrivateRelation.OathDeferred), nameof(PrivateRelation.OathPromptHidden), nameof(PrivateRelation.OathReleaseReason), nameof(PrivateRelation.OathReleaseTurn)]);`
- `NationalSpire.PrivateMessages.Enqueue(NationalSpire.CareerData, string, string, NationalSpire.PrivateOffer?, System.Collections.Generic.List<NationalSpire.PrivateOffer>?, bool)`；输入表达式：`PrivateMessages.Enqueue(data, person, command.Text)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Enqueue(data, person, command.Text).PromptInsertions`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`ArgumentSyntax: PrivateMessages.Mailbox(data)`
- `NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Relation(data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Relation(data, person)`
- `NationalSpire.PromptInsertions.Copy(System.Collections.Generic.IEnumerable<NationalSpire.PromptInsertion>?)`；输入表达式：`PromptInsertions.Copy(command.PromptInsertions)`；返回值紧邻使用处：`AssignmentExpressionSyntax: PrivateMessages.Enqueue(data, person, command.Text).PromptInsertions = PromptInsertions.Copy(command.PromptInsertions)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(command.Text)`；返回值紧邻使用处：`IfStatementSyntax: if (string.IsNullOrWhiteSpace(command.Text)) return "请先填写给对方的回复。";`

**赋值（含属性/字段和局部值）：**

- `PrivateMessages.Enqueue(data, person, command.Text).PromptInsertions` = `PromptInsertions.Copy(command.PromptInsertions)`
- `r.HighestBond` = `2`
- `r.OathConfirmed` = `false`
- `r.OathConfirmed` = `true`
- `r.OathDeferred` = `false`
- `r.OathDeferred` = `true`
- `r.OathPromptHidden` = `false`
- `r.OathPromptHidden` = `true`
- `r.OathReleaseReason` = `r.OathReleaseTurn = ""`
- `r.OathReleaseTurn` = `""`
- `r.SelectedBond` = `null`

<a id="symbol-4b25688fd79c"></a>

## `NationalSpire.RelationshipPresentation.RequestRelease(NationalSpire.PrivateRelation, NationalSpire.PrivateTurn, string) — public static void RequestRelease(PrivateRelation relation, PrivateTurn turn, string reason)`

来源：源码第 92 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessages.Apply(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>, int?)`](PrivateMessages.cs.md#symbol-7bf623828ccc)

**调用：** `string.IsNullOrWhiteSpace(string?)`；`string.Trim()`

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateRelation.OathConfirmed`；`NationalSpire.PrivateRelation.OathReleaseReason`；`NationalSpire.PrivateRelation.OathReleaseTurn`；`NationalSpire.PrivateRelation.Revision`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.PrivateTurn.Reply`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.Status`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(reason)`；返回值紧邻使用处：`BinaryExpressionSyntax: !relation.OathConfirmed || relation.OathReleaseReason.Length > 0 || turn.Status != "complete" || turn.ReplyDeleted || string.IsNullOrWhiteSpace(turn.Reply) || string.IsNullOrWhiteSpace(reason)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(turn.Reply)`；返回值紧邻使用处：`BinaryExpressionSyntax: !relation.OathConfirmed || relation.OathReleaseReason.Length > 0 || turn.Status != "complete" || turn.ReplyDeleted || string.IsNullOrWhiteSpace(turn.Reply)`
- `string.Trim()`；输入表达式：`reason.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: relation.OathReleaseReason = reason.Trim()`

**赋值（含属性/字段和局部值）：**

- `relation.OathReleaseReason` = `reason.Trim()`
- `relation.OathReleaseTurn` = `turn.Id`

<a id="symbol-c7ee26e64717"></a>

## `NationalSpire.RelationshipPresentation.Context(NationalSpire.PrivateRelation) — public static string Context(PrivateRelation relation)`

来源：源码第 97 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessagePrompts.Context(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-4b9d12b26f65)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateRelation.OathConfirmed`；`NationalSpire.PrivateRelation.OathReleaseReason`；`NationalSpire.PrivateRelation.RingReceived`；`NationalSpire.PrivateRelation.WeddingCompleted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**
