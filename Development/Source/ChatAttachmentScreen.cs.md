# ChatAttachmentScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`9A172F49D9C06C0CE77E62A480DDAC17C0070D7B7CEB9B3E5400CBC4D553F204`。来源：[源码](../../ChatAttachmentScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-bb34e71c1240"></a>

## `NationalSpire.CareerScreen.GiftReceipt(NationalSpire.PrivateOffer) — private void GiftReceipt(PrivateOffer offer)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-c7881d245b3d)；[`NationalSpire.CareerScreen.GroupOffer(NationalSpire.GroupChat, NationalSpire.GroupEffect, NationalSpire.PrivateOffer)`](GroupChatScreen.cs.md#symbol-3afa41099b93)

**调用：** [`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-5789f5c9047d)；[`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`](PrivateMessageScreen.cs.md#symbol-fb5e88f4639a)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._privateBody`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`；`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.OathAttachments.Kind`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.State`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("203448", "b89e67", 10, 16))`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("203448", "b89e67", 10, 16));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateBody!.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateBody!.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(PrivateSelectableText(offer.Detail, 17, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(PrivateSelectableText(offer.Detail, 17, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(PrivateText((offer.Kind == OathAttachments.Kind ? "解除誓约 · " : "礼物 · ") + offer.State, 20, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(PrivateText((offer.Kind == OathAttachments.Kind ? "解除誓约 · " : "礼物 · ") + offer.State, 20, _gold));`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { Name = "GiftReceipt" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { Name = "GiftReceipt" }`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(card)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(card)`
- `NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`；输入表达式：`PrivateSelectableText(offer.Detail, 17, _ink)`；返回值紧邻使用处：`ArgumentSyntax: PrivateSelectableText(offer.Detail, 17, _ink)`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText((offer.Kind == OathAttachments.Kind ? "解除誓约 · " : "礼物 · ") + offer.State, 20, _gold)`；返回值紧邻使用处：`ArgumentSyntax: PrivateText((offer.Kind == OathAttachments.Kind ? "解除誓约 · " : "礼物 · ") + offer.State, 20, _gold)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("203448", "b89e67", 10, 16)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("203448", "b89e67", 10, 16)`

**赋值（含属性/字段和局部值）：**

- `Name` = `"GiftReceipt"`

<a id="symbol-cefd5039c4e6"></a>

## `NationalSpire.CareerScreen.PrivateOathAttachment() — private void PrivateOathAttachment()`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`](PrivateMemoryScreen.cs.md#symbol-053a2c0af91b)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.OathAttachments.Prepare(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](OathAttachments.cs.md#symbol-9abb4f75eb8f)；`NationalSpire.PrivateOffer.PrivateOffer()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.OathAttachments.Kind`；`NationalSpire.OathAttachments.Prepare(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.Participants`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`；输入表达式：`AttachPrivate(attachment)`；返回值紧邻使用处：`ExpressionStatementSyntax: AttachPrivate(attachment);`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(error, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(error, true);`
- `NationalSpire.OathAttachments.Prepare(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；输入表达式：`OathAttachments.Prepare(ViewData, _privatePerson, attachment)`；返回值紧邻使用处：`IsPatternExpressionSyntax: OathAttachments.Prepare(ViewData, _privatePerson, attachment) is { } error`
- `NationalSpire.PrivateOffer.PrivateOffer()`；输入表达式：`new PrivateOffer { Kind = OathAttachments.Kind, Participants = [_privatePerson] }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PrivateOffer { Kind = OathAttachments.Kind, Participants = [_privatePerson] }`

**赋值（含属性/字段和局部值）：**

- `Kind` = `OathAttachments.Kind`
- `Participants` = `[_privatePerson]`

<a id="symbol-53b0d3e663d2"></a>

## `NationalSpire.CareerScreen.PrivateGiftPicker() — private void PrivateGiftPicker()`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerScreen.PrivateGiftPicker(NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?)`](ChatAttachmentScreen.cs.md#symbol-bd49b7253d4e)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.PrivateGiftPicker(NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.PrivateGiftPicker(NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?)`；输入表达式：`PrivateGiftPicker(null)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => PrivateGiftPicker(null)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-bd49b7253d4e"></a>

## `NationalSpire.CareerScreen.PrivateGiftPicker(NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?) — private void PrivateGiftPicker(ConsumerComposer? shop, PrivateOffer? previous = null)`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerAttachmentConfirmation(NationalSpire.ConsumerComposer, NationalSpire.PrivateOffer, System.Action?)`](ConsumerCommerceScreen.cs.md#symbol-f3a03a858f88)；[`NationalSpire.CareerScreen.PrivateGiftPicker()`](ChatAttachmentScreen.cs.md#symbol-53b0d3e663d2)

**调用：** [`NationalSpire.CareerScreen.ConsumerEditor(bool, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?, string, string, NationalSpire.CareerScreen.ConsumerEdit?)`](ConsumerPickerScreen.cs.md#symbol-0f5d28176960)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ConsumerEditor(bool, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?, string, string, NationalSpire.CareerScreen.ConsumerEdit?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.ConsumerEditor(bool, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?, string, string, NationalSpire.CareerScreen.ConsumerEdit?)`；输入表达式：`ConsumerEditor(false, shop, previous)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => ConsumerEditor(false, shop, previous)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5fd2ae52a36b"></a>

## `NationalSpire.CareerScreen.PrivateActivityPicker() — private void PrivateActivityPicker()`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerScreen.PrivateActivityPicker(string, string, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?)`](ChatAttachmentScreen.cs.md#symbol-1f0cb820099b)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.PrivateActivityPicker(string, string, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.PrivateActivityPicker(string, string, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?)`；输入表达式：`PrivateActivityPicker("", "")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => PrivateActivityPicker("", "")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1f0cb820099b"></a>

## `NationalSpire.CareerScreen.PrivateActivityPicker(string, string, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?) — private void PrivateActivityPicker(string goodId, string verbId, ConsumerComposer? shop = null, PrivateOffer? previous = null)`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerAttachmentConfirmation(NationalSpire.ConsumerComposer, NationalSpire.PrivateOffer, System.Action?)`](ConsumerCommerceScreen.cs.md#symbol-f3a03a858f88)；[`NationalSpire.CareerScreen.PrivateActivityPicker()`](ChatAttachmentScreen.cs.md#symbol-5fd2ae52a36b)

**调用：** [`NationalSpire.CareerScreen.ConsumerEditor(bool, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?, string, string, NationalSpire.CareerScreen.ConsumerEdit?)`](ConsumerPickerScreen.cs.md#symbol-0f5d28176960)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ConsumerEditor(bool, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?, string, string, NationalSpire.CareerScreen.ConsumerEdit?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.ConsumerEditor(bool, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?, string, string, NationalSpire.CareerScreen.ConsumerEdit?)`；输入表达式：`ConsumerEditor(true, shop, previous, goodId, verbId)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => ConsumerEditor(true, shop, previous, goodId, verbId)`

**赋值（含属性/字段和局部值）：**
