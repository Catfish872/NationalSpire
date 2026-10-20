# ChatAttachmentScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`0B8DFA162F314ED10F02C1998721EAE0ACB149FCEBDE06432462D28498DE038A`。来源：[源码](../../ChatAttachmentScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

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

**调用：** [`NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`](PrivateMemoryScreen.cs.md#symbol-053a2c0af91b)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`](PrivateMessageScreen.cs.md#symbol-fb5e88f4639a)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`](CareerDialog.cs.md#symbol-d832b736b02b)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.ChatAttachments.Prepare(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](ChatAttachments.cs.md#symbol-114368537271)；[`NationalSpire.ConsumerCatalog.Get(string)`](ConsumerData.cs.md#symbol-46828b8901c1)；[`NationalSpire.ConsumerQuantity.ConsumerQuantity()`](ConsumerGiftControls.cs.md#symbol-0eddfdec0f89)；[`NationalSpire.ConsumerQuantity.Initialize(int)`](ConsumerGiftControls.cs.md#symbol-a0db04226b0a)；[`NationalSpire.ConsumerQuantity.SetValue(int)`](ConsumerGiftControls.cs.md#symbol-e2e90c4c8401)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；[`RelationshipChoice()`](ChatAttachmentScreen.cs.md#symbol-ca9dd9c19af5)；`Godot.CheckButton.CheckButton()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.OptionButton()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.PrivateOffer.PrivateOffer()`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, long>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Math.Min(int, int)`；`System.Math.Min(long, long)`

**字段、属性、事件及方法组引用：** `(NationalSpire.Good Good, long Quantity).Good`；`(NationalSpire.Good Good, long Quantity).Quantity`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Consumer`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.ChatAttachments.Prepare(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；`NationalSpire.ConsumerCatalog.Get(string)`；`NationalSpire.ConsumerQuantity.Initialize(int)`；`NationalSpire.ConsumerQuantity.Maximum`；`NationalSpire.ConsumerQuantity.Minimum`；`NationalSpire.ConsumerQuantity.SetValue(int)`；`NationalSpire.ConsumerQuantity.Valid`；`NationalSpire.ConsumerQuantity.Value`；`NationalSpire.ConsumerState.Goods`；`NationalSpire.Good.Collectible`；`NationalSpire.Good.Id`；`NationalSpire.Good.Name`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；`NationalSpire.OwnedGood.Consumed`；`NationalSpire.OwnedGood.Id`；`NationalSpire.OwnedGood.Quantity`；`NationalSpire.PrivateOffer.ActorId`；`NationalSpire.PrivateOffer.GoodId`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.Participants`；`NationalSpire.PrivateOffer.Quantity`；`NationalSpire.PrivateOffer.RelationshipIntent`；`RelationshipChoice()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CheckButton.CheckButton()`；输入表达式：`new CheckButton { Text = "附加确定恋人关系的请求", CustomMinimumSize = new(520, 44) }`；返回值紧邻使用处：`AssignmentExpressionSyntax: relationship = new CheckButton { Text = "附加确定恋人关系的请求", CustomMinimumSize = new(520, 44) }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(picker)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(picker);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(PrivateText("收藏中的物品可以作为礼物赠送。", 18, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(PrivateText("收藏中的物品可以作为礼物赠送。", 18, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(quantity)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(quantity);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(relationship)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(relationship);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(relationshipHint)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(relationshipHint);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`picker.AddItem(item.Good!.Name + " · 持有 " + item.Quantity)`；返回值紧邻使用处：`ExpressionStatementSyntax: picker.AddItem(item.Good!.Name + " · 持有 " + item.Quantity);`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(520, 48) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(520, 48) }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(520, 44)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(520, 44)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(520, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(520, 48)`
- `NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`；输入表达式：`AttachPrivate(attachment)`；返回值紧邻使用处：`ExpressionStatementSyntax: AttachPrivate(attachment);`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("请输入有效的赠礼数量。", true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("请输入有效的赠礼数量。", true);`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(message, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(message, true);`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText("收藏中的物品可以作为礼物赠送。", 18, _muted)`；返回值紧邻使用处：`ArgumentSyntax: PrivateText("收藏中的物品可以作为礼物赠送。", 18, _muted)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；输入表达式：`ShowCareerDialog("赠送礼物", "接收者：" + GroupChats.Name(d, _privatePerson), () =>          {              if (goods.Length == 0) return true;              if (!quantity!.Valid) { Notice("请输入有效的赠礼数量。", true); return false; }              var item = goods[selected];              var attachment = new PrivateOffer { Kind = "gift", GoodId = item.Good!.Id, Quantity = (int)quantity!.Value, RelationshipIntent = relationship?.Visible == true && relationship.ButtonPressed ? 1 : 0, ActorId = _privatePerson, Participants = [_privatePerson] };              if (ChatAttachments.Prepare(d, _privatePerson, attachment) is { } message) { Notice(message, true); return false; }              AttachPrivate(attachment); return true;          }, "添加到消息", box =>          {              if (goods.Length == 0) { box.AddChild(PrivateText("收藏中的物品可以作为礼物赠送。", 18, _muted)); return; }              var picker = new OptionButton { SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(520, 48) };              foreach (var item in goods) picker.AddItem(item.Good!.Name + " · 持有 " + item.Quantity);              box.AddChild(picker);              quantity = new ConsumerQuantity { Minimum = 1, Maximum = (int)Math.Min(int.MaxValue, goods[0].Quantity) }; quantity.Initialize(1); box.AddChild(quantity);              relationship = new CheckButton { Text = "附加确定恋人关系的请求", CustomMinimumSize = new(520, 44) }; box.AddChild(relationship);              relationshipHint = Text("", 16, CareerVisuals.Teal); box.AddChild(relationshipHint);              void RelationshipChoice()              {                  bool special = RelationshipGifts.Special(goods[selected].Good!.Id);                  var relation = PrivateMessages.Relation(d, _privatePerson);                  relationship.Visible = !special && relation.Favour >= 60 && relation.SelectedBond is not >= 1 && !relation.OathConfirmed;                  relationshipHint.Text = special ? "好感达到85后可以赠送；对方接受后确定誓约关系。" : relationship.Visible ? "对方接受礼物后，确定恋人关系。" : "";                  relationshipHint.Visible = relationshipHint.Text.Length > 0;              }              picker.ItemSelected += index => { selected = (int)index; quantity.Maximum = (int)Math.Min(int.MaxValue, goods[selected].Quantity); quantity.SetValue(Math.Min(quantity.Value, quantity.Maximum)); RelationshipChoice(); };              RelationshipChoice();          })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("赠送礼物", "接收者：" + GroupChats.Name(d, _privatePerson), () =>          {              if (goods.Length == 0) return true;              if (!quantity!.Valid) { Notice("请输入有效的赠礼数量。", true); return false; }              var item = goods[selected];              var attachment = new PrivateOffer { Kind = "gift", GoodId = item.Good!.Id, Quantity = (int)quantity!.Value, RelationshipIntent = relationship?.Visible == true && relationship.ButtonPressed ? 1 : 0, ActorId = _privatePerson, Participants = [_privatePerson] };              if (ChatAttachments.Prepare(d, _privatePerson, attachment) is { } message) { Notice(message, true); return false; }              AttachPrivate(attachment); return true;          }, "添加到消息", box =>          {              if (goods.Length == 0) { box.AddChild(PrivateText("收藏中的物品可以作为礼物赠送。", 18, _muted)); return; }              var picker = new OptionButton { SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(520, 48) };              foreach (var item in goods) picker.AddItem(item.Good!.Name + " · 持有 " + item.Quantity);              box.AddChild(picker);              quantity = new ConsumerQuantity { Minimum = 1, Maximum = (int)Math.Min(int.MaxValue, goods[0].Quantity) }; quantity.Initialize(1); box.AddChild(quantity);              relationship = new CheckButton { Text = "附加确定恋人关系的请求", CustomMinimumSize = new(520, 44) }; box.AddChild(relationship);              relationshipHint = Text("", 16, CareerVisuals.Teal); box.AddChild(relationshipHint);              void RelationshipChoice()              {                  bool special = RelationshipGifts.Special(goods[selected].Good!.Id);                  var relation = PrivateMessages.Relation(d, _privatePerson);                  relationship.Visible = !special && relation.Favour >= 60 && relation.SelectedBond is not >= 1 && !relation.OathConfirmed;                  relationshipHint.Text = special ? "好感达到85后可以赠送；对方接受后确定誓约关系。" : relationship.Visible ? "对方接受礼物后，确定恋人关系。" : "";                  relationshipHint.Visible = relationshipHint.Text.Length > 0;              }              picker.ItemSelected += index => { selected = (int)index; quantity.Maximum = (int)Math.Min(int.MaxValue, goods[selected].Quantity); quantity.SetValue(Math.Min(quantity.Value, quantity.Maximum)); RelationshipChoice(); };              RelationshipChoice();          });`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 16, CareerVisuals.Teal)`；返回值紧邻使用处：`AssignmentExpressionSyntax: relationshipHint = Text("", 16, CareerVisuals.Teal)`
- `NationalSpire.ChatAttachments.Prepare(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；输入表达式：`ChatAttachments.Prepare(d, _privatePerson, attachment)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ChatAttachments.Prepare(d, _privatePerson, attachment) is { } message`
- `NationalSpire.ConsumerCatalog.Get(string)`；输入表达式：`ConsumerCatalog.Get(g.Key)`；返回值紧邻使用处：`ArgumentSyntax: Good: ConsumerCatalog.Get(g.Key)`
- `NationalSpire.ConsumerQuantity.ConsumerQuantity()`；输入表达式：`new ConsumerQuantity { Minimum = 1, Maximum = (int)Math.Min(int.MaxValue, goods[0].Quantity) }`；返回值紧邻使用处：`AssignmentExpressionSyntax: quantity = new ConsumerQuantity { Minimum = 1, Maximum = (int)Math.Min(int.MaxValue, goods[0].Quantity) }`
- `NationalSpire.ConsumerQuantity.Initialize(int)`；输入表达式：`quantity.Initialize(1)`；返回值紧邻使用处：`ExpressionStatementSyntax: quantity.Initialize(1);`
- `NationalSpire.ConsumerQuantity.SetValue(int)`；输入表达式：`quantity.SetValue(Math.Min(quantity.Value, quantity.Maximum))`；返回值紧邻使用处：`ExpressionStatementSyntax: quantity.SetValue(Math.Min(quantity.Value, quantity.Maximum));`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(d, _privatePerson)`；返回值紧邻使用处：`BinaryExpressionSyntax: "接收者：" + GroupChats.Name(d, _privatePerson)`
- `NationalSpire.PrivateOffer.PrivateOffer()`；输入表达式：`new PrivateOffer { Kind = "gift", GoodId = item.Good!.Id, Quantity = (int)quantity!.Value, RelationshipIntent = relationship?.Visible == true && relationship.ButtonPressed ? 1 : 0, ActorId = _privatePerson, Participants = [_privatePerson] }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PrivateOffer { Kind = "gift", GoodId = item.Good!.Id, Quantity = (int)quantity!.Value, RelationshipIntent = relationship?.Visible == true && relationship.ButtonPressed ? 1 : 0, ActorId = _privatePerson, Participants = [_privatePerson] }`
- `RelationshipChoice()`；输入表达式：`RelationshipChoice()`；返回值紧邻使用处：`ExpressionStatementSyntax: RelationshipChoice();`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Life.Consumer.Goods.Where(g => !g.Consumed && g.Quantity > 0).GroupBy(g => g.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Consumer.Goods.Where(g => !g.Consumed && g.Quantity > 0).GroupBy(g => g.Id)              .Select`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`d.Life.Consumer.Goods.Where(g => !g.Consumed && g.Quantity > 0).GroupBy(g => g.Id)              .Select(g => (Good: ConsumerCatalog.Get(g.Key), Quantity: g.Sum(x => x.Quantity)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Consumer.Goods.Where(g => !g.Consumed && g.Quantity > 0).GroupBy(g => g.Id)              .Select(g => (Good: ConsumerCatalog.Get(g.Key), Quantity: g.Sum(x => x.Quantity)))              .Where`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, long>)`；输入表达式：`g.Sum(x => x.Quantity)`；返回值紧邻使用处：`ArgumentSyntax: Quantity: g.Sum(x => x.Quantity)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`d.Life.Consumer.Goods.Where(g => !g.Consumed && g.Quantity > 0).GroupBy(g => g.Id)              .Select(g => (Good: ConsumerCatalog.Get(g.Key), Quantity: g.Sum(x => x.Quantity)))              .Where(x => x.Good?.Collectible == true).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Life.Consumer.Goods.Where(g => !g.Consumed && g.Quantity > 0).GroupBy(g => g.Id)              .Select(g => (Good: ConsumerCatalog.Get(g.Key), Quantity: g.Sum(x => x.Quantity)))              .Where(x => x.Good?.Collectible == true).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Consumer.Goods.Where(g => !g.Consumed && g.Quantity > 0).GroupBy(g => g.Id)              .Select(g => (Good: ConsumerCatalog.Get(g.Key), Quantity: g.Sum(x => x.Quantity)))              .Where(x => x.Good?.Collectible == true)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Consumer.Goods.Where(g => !g.Consumed && g.Quantity > 0).GroupBy(g => g.Id)              .Select(g => (Good: ConsumerCatalog.Get(g.Key), Quantity: g.Sum(x => x.Quantity)))              .Where(x => x.Good?.Collectible == true).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Consumer.Goods.Where(g => !g.Consumed && g.Quantity > 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Consumer.Goods.Where(g => !g.Consumed && g.Quantity > 0).GroupBy`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(quantity.Value, quantity.Maximum)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(quantity.Value, quantity.Maximum)`
- `System.Math.Min(long, long)`；输入表达式：`Math.Min(int.MaxValue, goods[0].Quantity)`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Min(int.MaxValue, goods[0].Quantity)`
- `System.Math.Min(long, long)`；输入表达式：`Math.Min(int.MaxValue, goods[selected].Quantity)`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Min(int.MaxValue, goods[selected].Quantity)`

**赋值（含属性/字段和局部值）：**

- `ActorId` = `_privatePerson`
- `CustomMinimumSize` = `new(520, 44)`
- `CustomMinimumSize` = `new(520, 48)`
- `GoodId` = `item.Good!.Id`
- `Kind` = `"gift"`
- `Maximum` = `(int)Math.Min(int.MaxValue, goods[0].Quantity)`
- `Minimum` = `1`
- `Participants` = `[_privatePerson]`
- `picker.ItemSelected` += `index => { selected = (int)index; quantity.Maximum = (int)Math.Min(int.MaxValue, goods[selected].Quantity); quantity.SetValue(Math.Min(quantity.Value, quantity.Maximum)); RelationshipChoice(); }`
- `quantity.Maximum` = `(int)Math.Min(int.MaxValue, goods[selected].Quantity)`
- `Quantity` = `(int)quantity!.Value`
- `quantity` = `new ConsumerQuantity { Minimum = 1, Maximum = (int)Math.Min(int.MaxValue, goods[0].Quantity) }`
- `relationship` = `new CheckButton { Text = "附加确定恋人关系的请求", CustomMinimumSize = new(520, 44) }`
- `relationshipHint` = `Text("", 16, CareerVisuals.Teal)`
- `RelationshipIntent` = `relationship?.Visible == true && relationship.ButtonPressed ? 1 : 0`
- `selected` = `(int)index`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Text` = `"附加确定恋人关系的请求"`

<a id="symbol-ca9dd9c19af5"></a>

## `RelationshipChoice() — void RelationshipChoice()`

来源：源码第 45 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateGiftPicker()`](ChatAttachmentScreen.cs.md#symbol-53b0d3e663d2)

**调用：** [`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-8a6bb6e78fa5)；[`NationalSpire.RelationshipGifts.Special(string)`](RelationshipGifts.cs.md#symbol-d05881b51110)

**字段、属性、事件及方法组引用：** `(NationalSpire.Good Good, long Quantity).Good`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.Good.Id`；`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateRelation.Favour`；`NationalSpire.PrivateRelation.OathConfirmed`；`NationalSpire.PrivateRelation.SelectedBond`；`NationalSpire.RelationshipGifts.Special(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Relation(d, _privatePerson)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Relation(d, _privatePerson)`
- `NationalSpire.RelationshipGifts.Special(string)`；输入表达式：`RelationshipGifts.Special(goods[selected].Good!.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RelationshipGifts.Special(goods[selected].Good!.Id)`

**赋值（含属性/字段和局部值）：**

- `relationship.Visible` = `!special && relation.Favour >= 60 && relation.SelectedBond is not >= 1 && !relation.OathConfirmed`
- `relationshipHint.Text` = `special ? "好感达到85后可以赠送；对方接受后确定誓约关系。" : relationship.Visible ? "对方接受礼物后，确定恋人关系。" : ""`
- `relationshipHint.Visible` = `relationshipHint.Text.Length > 0`

<a id="symbol-5fd2ae52a36b"></a>

## `NationalSpire.CareerScreen.PrivateActivityPicker() — private void PrivateActivityPicker()`

来源：源码第 58 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerScreen.PrivateActivityPicker(string, string)`](ChatAttachmentScreen.cs.md#symbol-658aa5efcda4)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.PrivateActivityPicker(string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.PrivateActivityPicker(string, string)`；输入表达式：`PrivateActivityPicker("", "")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => PrivateActivityPicker("", "")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-658aa5efcda4"></a>

## `NationalSpire.CareerScreen.PrivateActivityPicker(string, string) — private void PrivateActivityPicker(string goodId, string verbId)`

来源：源码第 59 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateActivityPicker()`](ChatAttachmentScreen.cs.md#symbol-5fd2ae52a36b)

**调用：** [`Calendar()`](ChatAttachmentScreen.cs.md#symbol-e5434801f66f)；[`NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`](PrivateMemoryScreen.cs.md#symbol-053a2c0af91b)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`](CareerDialog.cs.md#symbol-d832b736b02b)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.ChatAttachments.Prepare(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](ChatAttachments.cs.md#symbol-114368537271)；[`NationalSpire.ConsumerCatalog.Get(string)`](ConsumerData.cs.md#symbol-46828b8901c1)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-0f707d2c9895)；[`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-12bdfe5d4265)；[`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-ee7b01d76b23)；[`NationalSpire.WeddingAppointments.Services(NationalSpire.CareerData)`](WeddingAppointments.cs.md#symbol-2dfb2ee379ae)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.OptionButton()`；`Godot.OptionButton.Select(int)`；`Godot.ScrollContainer.ScrollContainer()`；`Godot.SpinBox.SpinBox()`；`Godot.TextEdit.TextEdit()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.PrivateOffer.PrivateOffer()`；`string.Trim()`；`System.Array.FindIndex<T>(T[], System.Predicate<T>)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.List()`；`System.Collections.Generic.List<T>.ToArray()`；`System.Collections.IEnumerable.OfType<TResult>()`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `(NationalSpire.Good Good, NationalSpire.GoodVerb Verb, string ServiceId).Good`；`(NationalSpire.Good Good, NationalSpire.GoodVerb Verb, string ServiceId).ServiceId`；`(NationalSpire.Good Good, NationalSpire.GoodVerb Verb, string ServiceId).Verb`；`(string Id, string Person, long Remaining).Id`；`(string Id, string Person, long Remaining).Person`；`Calendar()`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerLifeState.Consumer`；`NationalSpire.CareerScreen._groupSelection`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.ChatAttachments.Prepare(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；`NationalSpire.ConsumerCatalog.Get(string)`；`NationalSpire.ConsumerState.Goods`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.Good.Id`；`NationalSpire.Good.Name`；`NationalSpire.Good.Verbs`；`NationalSpire.GoodVerb.Id`；`NationalSpire.GoodVerb.Name`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.OwnedGood.Consumed`；`NationalSpire.OwnedGood.Id`；`NationalSpire.OwnedGood.Quantity`；`NationalSpire.PrivateOffer.Day`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.GoodId`；`NationalSpire.PrivateOffer.GoodVerb`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.Participants`；`NationalSpire.PrivateOffer.Season`；`NationalSpire.PrivateOffer.ServiceId`；`NationalSpire.PrivateOffer.Title`；`NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`；`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；`NationalSpire.WeddingAppointments.GoodId`；`NationalSpire.WeddingAppointments.Services(NationalSpire.CareerData)`；`NationalSpire.WeddingAppointments.Verb`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Calendar()`；输入表达式：`Calendar()`；返回值紧邻使用处：`ExpressionStatementSyntax: Calendar();`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 16);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { PlaceholderText = "活动名称", SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`AssignmentExpressionSyntax: title = new LineEdit { PlaceholderText = "活动名称", SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(detail)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(detail);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(picker)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(picker);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(title)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(title);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(season)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(season);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(selected)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(selected);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scroll.AddChild(calendar)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.AddChild(calendar);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`picker.AddItem("自行约定活动")`；返回值紧邻使用处：`ExpressionStatementSyntax: picker.AddItem("自行约定活动");`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`picker.AddItem(item.Verb.Name + " · " + item.Good.Name)`；返回值紧邻使用处：`ExpressionStatementSyntax: picker.AddItem(item.Verb.Name + " · " + item.Good.Name);`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(560, 44) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(560, 44) }`
- `Godot.OptionButton.Select(int)`；输入表达式：`picker.Select(initial + 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: picker.Select(initial + 1);`
- `Godot.ScrollContainer.ScrollContainer()`；输入表达式：`new ScrollContainer { CustomMinimumSize = new(740, 230), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ScrollContainer { CustomMinimumSize = new(740, 230), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `Godot.SpinBox.SpinBox()`；输入表达式：`new SpinBox { MinValue = d.Season, MaxValue = int.MaxValue, Value = d.Season, Prefix = "赛季 ", CustomMinimumSize = new(200, 44), UpdateOnTextChanged = true }`；返回值紧邻使用处：`AssignmentExpressionSyntax: season = new SpinBox { MinValue = d.Season, MaxValue = int.MaxValue, Value = d.Season, Prefix = "赛季 ", CustomMinimumSize = new(200, 44), UpdateOnTextChanged = true }`
- `Godot.TextEdit.TextEdit()`；输入表达式：`new TextEdit { PlaceholderText = "活动内容", CustomMinimumSize = new(740, 80), WrapMode = TextEdit.LineWrappingMode.Boundary }`；返回值紧邻使用处：`AssignmentExpressionSyntax: detail = new TextEdit { PlaceholderText = "活动内容", CustomMinimumSize = new(740, 80), WrapMode = TextEdit.LineWrappingMode.Boundary }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(200, 44)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(200, 44)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(560, 44)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(560, 44)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(740, 230)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(740, 230)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(740, 80)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(740, 80)`
- `NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`；输入表达式：`AttachPrivate(attachment)`；返回值紧邻使用处：`ExpressionStatementSyntax: AttachPrivate(attachment);`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(message, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(message, true);`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；输入表达式：`ShowCareerDialog("约定活动", "接受后记入日程，赴约时选择公开或私密。", () =>          {              var attachment = new PrivateOffer { Kind = "activity", Title = title!.Text.Trim(), Detail = detail!.Text.Trim(), Season = (int)season!.Value, Day = day,                  Participants = new[] { GroupChats.Human(d) }.Concat(people).Distinct().ToList() };              if (chosen >= 0) { attachment.GoodId = activities[chosen].Good.Id; attachment.GoodVerb = activities[chosen].Verb.Id; attachment.ServiceId = activities[chosen].ServiceId; }              if (ChatAttachments.Prepare(d, _privatePerson, attachment) is { } message) { Notice(message, true); return false; }              AttachPrivate(attachment); return true;          }, "添加到消息", box =>          {              var picker = new OptionButton { SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(560, 44) }; picker.AddItem("自行约定活动");              foreach (var item in activities) picker.AddItem(item.Verb.Name + " · " + item.Good.Name);              box.AddChild(picker);              title = new LineEdit { PlaceholderText = "活动名称", SizeFlagsHorizontal = SizeFlags.ExpandFill }; box.AddChild(title);              detail = new TextEdit { PlaceholderText = "活动内容", CustomMinimumSize = new(740, 80), WrapMode = TextEdit.LineWrappingMode.Boundary }; box.AddChild(detail);              var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 16); box.AddChild(row);              season = new SpinBox { MinValue = d.Season, MaxValue = int.MaxValue, Value = d.Season, Prefix = "赛季 ", CustomMinimumSize = new(200, 44), UpdateOnTextChanged = true }; row.AddChild(season);              var selected = Text($"{GameCalendar.Text(d, SeasonCalendar.Start(d) + day)}", 17, CareerVisuals.Teal); row.AddChild(selected);              var scroll = new ScrollContainer { CustomMinimumSize = new(740, 230), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);              var calendar = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; scroll.AddChild(calendar);              void Calendar()              {                  CareerVisuals.ClearContent(calendar);                  calendar.AddChild(AppointmentCalendar(d, (int)season.Value, people, day, value =>                  { day = value; selected.Text = $"{GameCalendar.Text(d, SeasonCalendar.Start(d, (int)season.Value) + day)}"; }));              }              season.ValueChanged += value => { day = Math.Min(day, SeasonCalendar.Length(d, (int)value)); selected.Text = $"{GameCalendar.Text(d, SeasonCalendar.Start(d, (int)value) + day)}"; Calendar(); };              box.AddThemeConstantOverride("separation", 12);              Calendar();              picker.ItemSelected += index => { chosen = (int)index - 1; if (chosen >= 0) { title.Text = activities[chosen].Verb.Name; detail.Text = "使用" + activities[chosen].Good.Name + "开展" + title.Text; } };              int initial = Array.FindIndex(activities, a => a.Good.Id == goodId && a.Verb.Id == verbId);              if (initial >= 0) { chosen = initial; picker.Select(initial + 1); title.Text = activities[initial].Verb.Name; detail.Text = "使用" + activities[initial].Good.Name + "开展" + title.Text; }          })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("约定活动", "接受后记入日程，赴约时选择公开或私密。", () =>          {              var attachment = new PrivateOffer { Kind = "activity", Title = title!.Text.Trim(), Detail = detail!.Text.Trim(), Season = (int)season!.Value, Day = day,                  Participants = new[] { GroupChats.Human(d) }.Concat(people).Distinct().ToList() };              if (chosen >= 0) { attachment.GoodId = activities[chosen].Good.Id; attachment.GoodVerb = activities[chosen].Verb.Id; attachment.ServiceId = activities[chosen].ServiceId; }              if (ChatAttachments.Prepare(d, _privatePerson, attachment) is { } message) { Notice(message, true); return false; }              AttachPrivate(attachment); return true;          }, "添加到消息", box =>          {              var picker = new OptionButton { SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(560, 44) }; picker.AddItem("自行约定活动");              foreach (var item in activities) picker.AddItem(item.Verb.Name + " · " + item.Good.Name);              box.AddChild(picker);              title = new LineEdit { PlaceholderText = "活动名称", SizeFlagsHorizontal = SizeFlags.ExpandFill }; box.AddChild(title);              detail = new TextEdit { PlaceholderText = "活动内容", CustomMinimumSize = new(740, 80), WrapMode = TextEdit.LineWrappingMode.Boundary }; box.AddChild(detail);              var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 16); box.AddChild(row);              season = new SpinBox { MinValue = d.Season, MaxValue = int.MaxValue, Value = d.Season, Prefix = "赛季 ", CustomMinimumSize = new(200, 44), UpdateOnTextChanged = true }; row.AddChild(season);              var selected = Text($"{GameCalendar.Text(d, SeasonCalendar.Start(d) + day)}", 17, CareerVisuals.Teal); row.AddChild(selected);              var scroll = new ScrollContainer { CustomMinimumSize = new(740, 230), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);              var calendar = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; scroll.AddChild(calendar);              void Calendar()              {                  CareerVisuals.ClearContent(calendar);                  calendar.AddChild(AppointmentCalendar(d, (int)season.Value, people, day, value =>                  { day = value; selected.Text = $"{GameCalendar.Text(d, SeasonCalendar.Start(d, (int)season.Value) + day)}"; }));              }              season.ValueChanged += value => { day = Math.Min(day, SeasonCalendar.Length(d, (int)value)); selected.Text = $"{GameCalendar.Text(d, SeasonCalendar.Start(d, (int)value) + day)}"; Calendar(); };              box.AddThemeConstantOverride("separation", 12);              Calendar();              picker.ItemSelected += index => { chosen = (int)index - 1; if (chosen >= 0) { title.Text = activities[chosen].Verb.Name; detail.Text = "使用" + activities[chosen].Good.Name + "开展" + title.Text; } };              int initial = Array.FindIndex(activities, a => a.Good.Id == goodId && a.Verb.Id == verbId);              if (initial >= 0) { chosen = initial; picker.Select(initial + 1); title.Text = activities[initial].Verb.Name; detail.Text = "使用" + activities[initial].Good.Name + "开展" + title.Text; }          });`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"{GameCalendar.Text(d, SeasonCalendar.Start(d) + day)}", 17, CareerVisuals.Teal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text($"{GameCalendar.Text(d, SeasonCalendar.Start(d) + day)}", 17, CareerVisuals.Teal)`
- `NationalSpire.ChatAttachments.Prepare(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；输入表达式：`ChatAttachments.Prepare(d, _privatePerson, attachment)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ChatAttachments.Prepare(d, _privatePerson, attachment) is { } message`
- `NationalSpire.ConsumerCatalog.Get(string)`；输入表达式：`ConsumerCatalog.Get(g.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => ConsumerCatalog.Get(g.Id)`
- `NationalSpire.ConsumerCatalog.Get(string)`；输入表达式：`ConsumerCatalog.Get(WeddingAppointments.GoodId)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: ConsumerCatalog.Get(WeddingAppointments.GoodId)!`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(d, SeasonCalendar.Start(d, (int)value) + day)`；返回值紧邻使用处：`InterpolationSyntax: {GameCalendar.Text(d, SeasonCalendar.Start(d, (int)value) + day)}`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(d, SeasonCalendar.Start(d) + day)`；返回值紧邻使用处：`InterpolationSyntax: {GameCalendar.Text(d, SeasonCalendar.Start(d) + day)}`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(d)`；返回值紧邻使用处：`InitializerExpressionSyntax: { GroupChats.Human(d) }`
- `NationalSpire.PrivateOffer.PrivateOffer()`；输入表达式：`new PrivateOffer { Kind = "activity", Title = title!.Text.Trim(), Detail = detail!.Text.Trim(), Season = (int)season!.Value, Day = day,                  Participants = new[] { GroupChats.Human(d) }.Concat(people).Distinct().ToList() }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PrivateOffer { Kind = "activity", Title = title!.Text.Trim(), Detail = detail!.Text.Trim(), Season = (int)season!.Value, Day = day,                  Participants = new[] { GroupChats.Human(d) }.Concat(people).Distinct().ToList() }`
- `NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Day(d, d.Day)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = SeasonCalendar.Day(d, d.Day)`
- `NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Length(d, (int)value)`；返回值紧邻使用处：`ArgumentSyntax: SeasonCalendar.Length(d, (int)value)`
- `NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Start(d, (int)value)`；返回值紧邻使用处：`BinaryExpressionSyntax: SeasonCalendar.Start(d, (int)value) + day`
- `NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Start(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: SeasonCalendar.Start(d) + day`
- `NationalSpire.WeddingAppointments.Services(NationalSpire.CareerData)`；输入表达式：`WeddingAppointments.Services(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: WeddingAppointments.Services(d).Where`
- `string.Trim()`；输入表达式：`detail!.Text.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Detail = detail!.Text.Trim()`
- `string.Trim()`；输入表达式：`title!.Text.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Title = title!.Text.Trim()`
- `System.Array.FindIndex<T>(T[], System.Predicate<T>)`；输入表达式：`Array.FindIndex(activities, a => a.Good.Id == goodId && a.Verb.Id == verbId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Array.FindIndex(activities, a => a.Good.Id == goodId && a.Verb.Id == verbId)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`d.Life.Consumer.Goods.Where(g => g.Quantity > 0 && !g.Consumed).Select(g => ConsumerCatalog.Get(g.Id))              .OfType<Good>().DistinctBy(g => g.Id).SelectMany(g => g.Verbs.Select(v => (Good: g, Verb: v, ServiceId: "")))              .Concat(WeddingAppointments.Services(d).Where(s => people.Length == 1 && people[0] == s.Person)                  .Select(s => (Good: ConsumerCatalog.Get(WeddingAppointments.GoodId)!, Verb: WeddingAppointments.Verb, ServiceId: s.Id)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Consumer.Goods.Where(g => g.Quantity > 0 && !g.Consumed).Select(g => ConsumerCatalog.Get(g.Id))              .OfType<Good>().DistinctBy(g => g.Id).SelectMany(g => g.Verbs.Select(v => (Good: g, Verb: v, ServiceId: "")))              .Concat(WeddingAppointments.Services(d).Where(s => people.Length == 1 && people[0] == s.Person)                  .Select(s => (Good: ConsumerCatalog.Get(WeddingAppointments.GoodId)!, Verb: WeddingAppointments.Verb, ServiceId: s.Id))).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`new[] { GroupChats.Human(d) }.Concat(people)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { GroupChats.Human(d) }.Concat(people).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`new[] { GroupChats.Human(d) }.Concat(people).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { GroupChats.Human(d) }.Concat(people).Distinct().ToList`
- `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Life.Consumer.Goods.Where(g => g.Quantity > 0 && !g.Consumed).Select(g => ConsumerCatalog.Get(g.Id))              .OfType<Good>().DistinctBy(g => g.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Consumer.Goods.Where(g => g.Quantity > 0 && !g.Consumed).Select(g => ConsumerCatalog.Get(g.Id))              .OfType<Good>().DistinctBy(g => g.Id).SelectMany`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`d.Life.Consumer.Goods.Where(g => g.Quantity > 0 && !g.Consumed).Select(g => ConsumerCatalog.Get(g.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Consumer.Goods.Where(g => g.Quantity > 0 && !g.Consumed).Select(g => ConsumerCatalog.Get(g.Id))              .OfType<Good>`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`g.Verbs.Select(v => (Good: g, Verb: v, ServiceId: ""))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => g.Verbs.Select(v => (Good: g, Verb: v, ServiceId: ""))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`WeddingAppointments.Services(d).Where(s => people.Length == 1 && people[0] == s.Person)                  .Select(s => (Good: ConsumerCatalog.Get(WeddingAppointments.GoodId)!, Verb: WeddingAppointments.Verb, ServiceId: s.Id))`；返回值紧邻使用处：`ArgumentSyntax: WeddingAppointments.Services(d).Where(s => people.Length == 1 && people[0] == s.Person)                  .Select(s => (Good: ConsumerCatalog.Get(WeddingAppointments.GoodId)!, Verb: WeddingAppointments.Verb, ServiceId: s.Id))`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`d.Life.Consumer.Goods.Where(g => g.Quantity > 0 && !g.Consumed).Select(g => ConsumerCatalog.Get(g.Id))              .OfType<Good>().DistinctBy(g => g.Id).SelectMany(g => g.Verbs.Select(v => (Good: g, Verb: v, ServiceId: "")))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Consumer.Goods.Where(g => g.Quantity > 0 && !g.Consumed).Select(g => ConsumerCatalog.Get(g.Id))              .OfType<Good>().DistinctBy(g => g.Id).SelectMany(g => g.Verbs.Select(v => (Good: g, Verb: v, ServiceId: "")))              .Concat`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`d.Life.Consumer.Goods.Where(g => g.Quantity > 0 && !g.Consumed).Select(g => ConsumerCatalog.Get(g.Id))              .OfType<Good>().DistinctBy(g => g.Id).SelectMany(g => g.Verbs.Select(v => (Good: g, Verb: v, ServiceId: "")))              .Concat(WeddingAppointments.Services(d).Where(s => people.Length == 1 && people[0] == s.Person)                  .Select(s => (Good: ConsumerCatalog.Get(WeddingAppointments.GoodId)!, Verb: WeddingAppointments.Verb, ServiceId: s.Id))).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Life.Consumer.Goods.Where(g => g.Quantity > 0 && !g.Consumed).Select(g => ConsumerCatalog.Get(g.Id))              .OfType<Good>().DistinctBy(g => g.Id).SelectMany(g => g.Verbs.Select(v => (Good: g, Verb: v, ServiceId: "")))              .Concat(WeddingAppointments.Services(d).Where(s => people.Length == 1 && people[0] == s.Person)                  .Select(s => (Good: ConsumerCatalog.Get(WeddingAppointments.GoodId)!, Verb: WeddingAppointments.Verb, ServiceId: s.Id))).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`new[] { GroupChats.Human(d) }.Concat(people).Distinct().ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Participants = new[] { GroupChats.Human(d) }.Concat(people).Distinct().ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Consumer.Goods.Where(g => g.Quantity > 0 && !g.Consumed)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Consumer.Goods.Where(g => g.Quantity > 0 && !g.Consumed).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`WeddingAppointments.Services(d).Where(s => people.Length == 1 && people[0] == s.Person)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: WeddingAppointments.Services(d).Where(s => people.Length == 1 && people[0] == s.Person)                  .Select`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<string> { _privatePerson }`；返回值紧邻使用处：`ConditionalExpressionSyntax: _privateGroup.Length > 0 ? _groupSelection : new List<string> { _privatePerson }`
- `System.Collections.Generic.List<T>.ToArray()`；输入表达式：`(_privateGroup.Length > 0 ? _groupSelection : new List<string> { _privatePerson }).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = (_privateGroup.Length > 0 ? _groupSelection : new List<string> { _privatePerson }).ToArray()`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`d.Life.Consumer.Goods.Where(g => g.Quantity > 0 && !g.Consumed).Select(g => ConsumerCatalog.Get(g.Id))              .OfType<Good>()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Consumer.Goods.Where(g => g.Quantity > 0 && !g.Consumed).Select(g => ConsumerCatalog.Get(g.Id))              .OfType<Good>().DistinctBy`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(day, SeasonCalendar.Length(d, (int)value))`；返回值紧邻使用处：`AssignmentExpressionSyntax: day = Math.Min(day, SeasonCalendar.Length(d, (int)value))`

**赋值（含属性/字段和局部值）：**

- `attachment.GoodId` = `activities[chosen].Good.Id`
- `attachment.GoodVerb` = `activities[chosen].Verb.Id`
- `attachment.ServiceId` = `activities[chosen].ServiceId`
- `chosen` = `(int)index - 1`
- `chosen` = `initial`
- `CustomMinimumSize` = `new(200, 44)`
- `CustomMinimumSize` = `new(560, 44)`
- `CustomMinimumSize` = `new(740, 230)`
- `CustomMinimumSize` = `new(740, 80)`
- `Day` = `day`
- `day` = `Math.Min(day, SeasonCalendar.Length(d, (int)value))`
- `detail.Text` = `"使用" + activities[chosen].Good.Name + "开展" + title.Text`
- `detail.Text` = `"使用" + activities[initial].Good.Name + "开展" + title.Text`
- `Detail` = `detail!.Text.Trim()`
- `detail` = `new TextEdit { PlaceholderText = "活动内容", CustomMinimumSize = new(740, 80), WrapMode = TextEdit.LineWrappingMode.Boundary }`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `Kind` = `"activity"`
- `MaxValue` = `int.MaxValue`
- `MinValue` = `d.Season`
- `Participants` = `new[] { GroupChats.Human(d) }.Concat(people).Distinct().ToList()`
- `picker.ItemSelected` += `index => { chosen = (int)index - 1; if (chosen >= 0) { title.Text = activities[chosen].Verb.Name; detail.Text = "使用" + activities[chosen].Good.Name + "开展" + title.Text; } }`
- `PlaceholderText` = `"活动名称"`
- `PlaceholderText` = `"活动内容"`
- `Prefix` = `"赛季 "`
- `season.ValueChanged` += `value => { day = Math.Min(day, SeasonCalendar.Length(d, (int)value)); selected.Text = $"{GameCalendar.Text(d, SeasonCalendar.Start(d, (int)value) + day)}"; Calendar(); }`
- `Season` = `(int)season!.Value`
- `season` = `new SpinBox { MinValue = d.Season, MaxValue = int.MaxValue, Value = d.Season, Prefix = "赛季 ", CustomMinimumSize = new(200, 44), UpdateOnTextChanged = true }`
- `selected.Text` = `$"{GameCalendar.Text(d, SeasonCalendar.Start(d, (int)value) + day)}"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `title.Text` = `activities[chosen].Verb.Name`
- `title.Text` = `activities[initial].Verb.Name`
- `title` = `new LineEdit { PlaceholderText = "活动名称", SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Title` = `title!.Text.Trim()`
- `UpdateOnTextChanged` = `true`
- `Value` = `d.Season`
- `WrapMode` = `TextEdit.LineWrappingMode.Boundary`

<a id="symbol-e5434801f66f"></a>

## `Calendar() — void Calendar()`

来源：源码第 87 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateActivityPicker(string, string)`](ChatAttachmentScreen.cs.md#symbol-658aa5efcda4)

**调用：** [`NationalSpire.CareerScreen.AppointmentCalendar(NationalSpire.CareerData, int, System.Collections.Generic.IEnumerable<string>, int, System.Action<int>)`](AppointmentCalendarScreen.cs.md#symbol-b5cb4cb371f4)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；[`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-ee7b01d76b23)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.AppointmentCalendar(NationalSpire.CareerData, int, System.Collections.Generic.IEnumerable<string>, int, System.Action<int>)`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`calendar.AddChild(AppointmentCalendar(d, (int)season.Value, people, day, value =>                  { day = value; selected.Text = $"{GameCalendar.Text(d, SeasonCalendar.Start(d, (int)season.Value) + day)}"; }))`；返回值紧邻使用处：`ExpressionStatementSyntax: calendar.AddChild(AppointmentCalendar(d, (int)season.Value, people, day, value =>                  { day = value; selected.Text = $"{GameCalendar.Text(d, SeasonCalendar.Start(d, (int)season.Value) + day)}"; }));`
- `NationalSpire.CareerScreen.AppointmentCalendar(NationalSpire.CareerData, int, System.Collections.Generic.IEnumerable<string>, int, System.Action<int>)`；输入表达式：`AppointmentCalendar(d, (int)season.Value, people, day, value =>                  { day = value; selected.Text = $"{GameCalendar.Text(d, SeasonCalendar.Start(d, (int)season.Value) + day)}"; })`；返回值紧邻使用处：`ArgumentSyntax: AppointmentCalendar(d, (int)season.Value, people, day, value =>                  { day = value; selected.Text = $"{GameCalendar.Text(d, SeasonCalendar.Start(d, (int)season.Value) + day)}"; })`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(calendar)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(calendar);`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(d, SeasonCalendar.Start(d, (int)season.Value) + day)`；返回值紧邻使用处：`InterpolationSyntax: {GameCalendar.Text(d, SeasonCalendar.Start(d, (int)season.Value) + day)}`
- `NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Start(d, (int)season.Value)`；返回值紧邻使用处：`BinaryExpressionSyntax: SeasonCalendar.Start(d, (int)season.Value) + day`

**赋值（含属性/字段和局部值）：**

- `day` = `value`
- `selected.Text` = `$"{GameCalendar.Text(d, SeasonCalendar.Start(d, (int)season.Value) + day)}"`
