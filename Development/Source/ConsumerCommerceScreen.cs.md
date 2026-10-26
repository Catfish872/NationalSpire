# ConsumerCommerceScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`74E799CB5C20C618617F41A72BE76564926F8ECEC8EE23417D3AD59C57E850A9`。来源：[源码](../../ConsumerCommerceScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.ConsumerComposer`、`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp

```

<a id="symbol-4d2c83181e84"></a>

## `NationalSpire.CareerScreen.ConsumerTarget(NationalSpire.Good, bool) — private void ConsumerTarget(Good good, bool activity)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer)`](ConsumerScreen.cs.md#symbol-d0b5fafc7e7c)

**调用：** [`NationalSpire.CareerScreen.ConsumerEditor(bool, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?, string, string, NationalSpire.CareerScreen.ConsumerEdit?)`](ConsumerPickerScreen.cs.md#symbol-0f5d28176960)；`NationalSpire.ConsumerComposer.ConsumerComposer(string, string, string, System.Collections.Generic.List<string>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ConsumerEditor(bool, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?, string, string, NationalSpire.CareerScreen.ConsumerEdit?)`；`NationalSpire.Good.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.ConsumerEditor(bool, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?, string, string, NationalSpire.CareerScreen.ConsumerEdit?)`；输入表达式：`ConsumerEditor(activity, new(good.Id, "", "", []))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => ConsumerEditor(activity, new(good.Id, "", "", []))`
- `NationalSpire.ConsumerComposer.ConsumerComposer(string, string, string, System.Collections.Generic.List<string>)`；输入表达式：`new(good.Id, "", "", [])`；返回值紧邻使用处：`ArgumentSyntax: new(good.Id, "", "", [])`

**赋值（含属性/字段和局部值）：**


<a id="symbol-deb0704ef9e4"></a>

## `NationalSpire.CareerScreen.ConsumerConfirmPurchase(NationalSpire.CareerData, NationalSpire.Good, int) — private void ConsumerConfirmPurchase(CareerData data, Good good, int quantity)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer)`](ConsumerScreen.cs.md#symbol-d0b5fafc7e7c)

**调用：** [`NationalSpire.CareerScreen.ConsumerSubmit(NationalSpire.CareerData, NationalSpire.Good, string, System.Collections.Generic.List<string>, int)`](ConsumerScreen.cs.md#symbol-f212593005f6)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`](ConsumerEngine.cs.md#symbol-723a34b6e2cb)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ConsumerSubmit(NationalSpire.CareerData, NationalSpire.Good, string, System.Collections.Generic.List<string>, int)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`；`NationalSpire.Good.Instant`；`NationalSpire.Good.Name`；`NationalSpire.Good.Promo`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.ConsumerSubmit(NationalSpire.CareerData, NationalSpire.Good, string, System.Collections.Generic.List<string>, int)`；输入表达式：`ConsumerSubmit(data, good, "", [], quantity)`；返回值紧邻使用处：`ExpressionStatementSyntax: ConsumerSubmit(data, good, "", [], quantity);`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("确认购买", $"{good.Name} ×{quantity}\n支付 ${ConsumerEngine.Price(good) * (decimal)quantity:N0}\n"              + (good.Instant ? "付款后立即单人使用，本次购买不进入库存。" : good.Promo ? "购买后立即执行运营。" : "购买后加入库存。"),              () => { ConsumerSubmit(data, good, "", [], quantity); return true; }, "确认购买")`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("确认购买", $"{good.Name} ×{quantity}\n支付 ${ConsumerEngine.Price(good) * (decimal)quantity:N0}\n"              + (good.Instant ? "付款后立即单人使用，本次购买不进入库存。" : good.Promo ? "购买后立即执行运营。" : "购买后加入库存。"),              () => { ConsumerSubmit(data, good, "", [], quantity); return true; }, "确认购买");`
- `NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`；输入表达式：`ConsumerEngine.Price(good)`；返回值紧邻使用处：`BinaryExpressionSyntax: ConsumerEngine.Price(good) * (decimal)quantity`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f3a03a858f88"></a>

## `NationalSpire.CareerScreen.ConsumerAttachmentConfirmation(NationalSpire.ConsumerComposer, NationalSpire.PrivateOffer, System.Action?) — private void ConsumerAttachmentConfirmation(ConsumerComposer target, PrivateOffer attachment, Action? returnTo = null)`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerEditor(bool, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?, string, string, NationalSpire.CareerScreen.ConsumerEdit?)`](ConsumerPickerScreen.cs.md#symbol-0f5d28176960)

**调用：** `Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`；`Godot.CanvasItem.Hide()`；`Godot.CanvasItem.Show()`；`Godot.Color.Color(string)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CareerScreen.PrivateActivityPicker(string, string, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?)`](ChatAttachmentScreen.cs.md#symbol-1f0cb820099b)；[`NationalSpire.CareerScreen.PrivateGiftPicker(NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?)`](ChatAttachmentScreen.cs.md#symbol-bd49b7253d4e)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.ConsumerAttachments.Prepare(NationalSpire.CareerData, string, string, NationalSpire.PrivateOffer, bool)`](ConsumerAttachments.cs.md#symbol-bb17fc71b2da)；[`NationalSpire.ConsumerAttachments.ToBuy(NationalSpire.CareerData, NationalSpire.Good, int)`](ConsumerAttachments.cs.md#symbol-cdcb64898743)；[`NationalSpire.ConsumerCatalog.Get(string)`](ConsumerData.cs.md#symbol-46828b8901c1)；[`NationalSpire.ConsumerEngine.HospitalityFee(NationalSpire.Good)`](ConsumerEngine.cs.md#symbol-a4327d304bf8)；[`NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`](ConsumerEngine.cs.md#symbol-723a34b6e2cb)；[`NationalSpire.Coop.CoopJson.Copy<T>(T)`](Coop/CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.EconomicActions.Save(NationalSpire.CareerData, System.Func<NationalSpire.CareerData, string?>)`](EconomicActions.cs.md#symbol-6ec38e492fe6)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；[`NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-e21b0ff1d18b)；`NationalSpire.LifestyleArt.LifestyleArt()`；[`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-15c716ec61a1)；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；`int.ToString()`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`

**字段、属性、事件及方法组引用：** `Accepted()`；`NationalSpire.CareerScreen.PrivateActivityPicker(string, string, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?)`；`NationalSpire.CareerScreen.PrivateGiftPicker(NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._openingDialogReturn`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.ConsumerAttachments.Prepare(NationalSpire.CareerData, string, string, NationalSpire.PrivateOffer, bool)`；`NationalSpire.ConsumerAttachments.ToBuy(NationalSpire.CareerData, NationalSpire.Good, int)`；`NationalSpire.ConsumerCatalog.Get(string)`；`NationalSpire.ConsumerComposer.Group`；`NationalSpire.ConsumerComposer.People`；`NationalSpire.ConsumerComposer.Person`；`NationalSpire.ConsumerEngine.HospitalityFee(NationalSpire.Good)`；`NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.EconomicActions.Save(NationalSpire.CareerData, System.Func<NationalSpire.CareerData, string?>)`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.Good.Category`；`NationalSpire.Good.Id`；`NationalSpire.Good.Instant`；`NationalSpire.Good.Name`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；`NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?)`；`NationalSpire.LifestyleArt.Category`；`NationalSpire.LifestyleArt.ProductId`；`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateMessageCommand.Part`；`NationalSpire.PrivateMessageCommand.Request`；`NationalSpire.PrivateOffer.GoodId`；`NationalSpire.PrivateOffer.GoodVerb`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.Quantity`；`NationalSpire.PrivateOffer.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(Accepted).CallDeferred()`；返回值紧邻使用处：`ExpressionStatementSyntax: Callable.From(Accepted).CallDeferred();`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(Accepted)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(Accepted).CallDeferred`
- `Godot.CanvasItem.Hide()`；输入表达式：`error.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: error.Hide();`
- `Godot.CanvasItem.Show()`；输入表达式：`error.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: error.Show();`
- `Godot.Color.Color(string)`；输入表达式：`new("efb3aa")`；返回值紧邻使用处：`ArgumentSyntax: new("efb3aa")`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`metrics.AddThemeConstantOverride("separation", 24)`；返回值紧邻使用处：`ExpressionStatementSyntax: metrics.AddThemeConstantOverride("separation", 24);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 18);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`summary.AddThemeConstantOverride("separation", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: summary.AddThemeConstantOverride("separation", 8);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("203b48", "688b8b", 10, 18))`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("203b48", "688b8b", 10, 18));`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(explanation, 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(explanation, 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(error)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(error);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(metrics)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(metrics);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`card.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`column.AddChild(Text(metric.Item1, 14, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddChild(Text(metric.Item1, 14, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`column.AddChild(Text(metric.Item2, 25, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddChild(Text(metric.Item2, 25, CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`metrics.AddChild(column)`；返回值紧邻使用处：`ExpressionStatementSyntax: metrics.AddChild(column);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(new LifestyleArt { ProductId = good.Id, Category = good.Category + " " + good.Name, CustomMinimumSize = new(100, 100) })`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(new LifestyleArt { ProductId = good.Id, Category = good.Category + " " + good.Name, CustomMinimumSize = new(100, 100) });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(summary)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(summary);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`summary.AddChild(Text((attachment.Kind == "activity" ? "同行者 · " : "接收者 · ") + string.Join("、", target.People.Select(id => GroupChats.Name(data, id))), 17, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: summary.AddChild(Text((attachment.Kind == "activity" ? "同行者 · " : "接收者 · ") + string.Join("、", target.People.Select(id => GroupChats.Name(data, id))), 17, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`summary.AddChild(Text(attachment.Title + " · " + GameCalendar.Text(data, PrivateAppointments.Date(data, attachment)), 16, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: summary.AddChild(Text(attachment.Title + " · " + GameCalendar.Text(data, PrivateAppointments.Date(data, attachment)), 16, CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`summary.AddChild(Text(good.Name + " ×" + quantity, 23, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: summary.AddChild(Text(good.Name + " ×" + quantity, 23, _gold));`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer()`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(100, 100)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(100, 100)`
- `NationalSpire.CareerScreen.PrivateActivityPicker(string, string, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?)`；输入表达式：`PrivateActivityPicker(good.Id, attachment.GoodVerb, target, attachment)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateActivityPicker(good.Id, attachment.GoodVerb, target, attachment);`
- `NationalSpire.CareerScreen.PrivateGiftPicker(NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?)`；输入表达式：`PrivateGiftPicker(target, attachment)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateGiftPicker(target, attachment);`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("确认费用与附件", "", () => { var command = new PrivateMessageCommand { Request = attachment, Part = target.Group }; void Accepted() { _multiplayer?.Refresh(); if (target.Group.Length > 0) OpenPrivateMessages(group: target.Group); else OpenPrivateMessages(target.Person); RestoreConsumerDrafts(); RefreshPrivateAttachments(); } if (_multiplayer != null) _multiplayer.Send("consumer-attach", target.Person, JsonSerializer.Serialize(command), accepted: Accepted); else { var prepared = Coop.CoopJson.Copy(attachment); string? result = EconomicActions.Save(data, d => ConsumerAttachments.Prepare(d, target.Person, target.Group, prepared)); if (result != null) { error!.Text = result; error.Show(); return false; } Callable.From(Accepted).CallDeferred(); } return true; }, "确认并添加", contents: box => { var card = new PanelContainer(); card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("203b48", "688b8b", 10, 18)); box.AddChild(card); var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 18); card.AddChild(row); row.AddChild(new LifestyleArt { ProductId = good.Id, Category = good.Category + " " + good.Name, CustomMinimumSize = new(100, 100) }); var summary = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; summary.AddThemeConstantOverride("separation", 8); row.AddChild(summary); summary.AddChild(Text(good.Name + " ×" + quantity, 23, _gold)); summary.AddChild(Text((attachment.Kind == "activity" ? "同行者 · " : "接收者 · ") + string.Join("、", target.People.Select(id => GroupChats.Name(data, id))), 17, _ink)); if (attachment.Kind == "activity") summary.AddChild(Text(attachment.Title + " · " + GameCalendar.Text(data, PrivateAppointments.Date(data, attachment)), 16, CareerVisuals.Teal)); var metrics = new HBoxContainer(); metrics.AddThemeConstantOverride("separation", 24); box.AddChild(metrics); foreach (var metric in new[] { ("使用现有", (quantity - buy).ToString()), ("本次补购", buy.ToString()), ("本次支付", $"${ConsumerEngine.Price(good) * (decimal)buy:N0}") }) { var column = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; metrics.AddChild(column); column.AddChild(Text(metric.Item1, 14, _muted)); column.AddChild(Text(metric.Item2, 25, CareerVisuals.Teal)); } box.AddChild(Text(explanation, 16, _muted)); error = Text("", 16, new("efb3aa")); error.Name = "ConsumerAttachmentError"; error.Hide(); box.AddChild(error); }, returnOutsideChat: true)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("确认费用与附件", "", () => { var command = new PrivateMessageCommand { Request = attachment, Part = target.Group }; void Accepted() { _multiplayer?.Refresh(); if (target.Group.Length > 0) OpenPrivateMessages(group: target.Group); else OpenPrivateMessages(target.Person); RestoreConsumerDrafts(); RefreshPrivateAttachments(); } if (_multiplayer != null) _multiplayer.Send("consumer-attach", target.Person, JsonSerializer.Serialize(command), accepted: Accepted); else { var prepared = Coop.CoopJson.Copy(attachment); string? result = EconomicActions.Save(data, d => ConsumerAttachments.Prepare(d, target.Person, target.Group, prepared)); if (result != null) { error!.Text = result; error.Show(); return false; } Callable.From(Accepted).CallDeferred(); } return true; }, "确认并添加", contents: box => { var card = new PanelContainer(); card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("203b48", "688b8b", 10, 18)); box.AddChild(card); var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 18); card.AddChild(row); row.AddChild(new LifestyleArt { ProductId = good.Id, Category = good.Category + " " + good.Name, CustomMinimumSize = new(100, 100) }); var summary = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; summary.AddThemeConstantOverride("separation", 8); row.AddChild(summary); summary.AddChild(Text(good.Name + " ×" + quantity, 23, _gold)); summary.AddChild(Text((attachment.Kind == "activity" ? "同行者 · " : "接收者 · ") + string.Join("、", target.People.Select(id => GroupChats.Name(data, id))), 17, _ink)); if (attachment.Kind == "activity") summary.AddChild(Text(attachment.Title + " · " + GameCalendar.Text(data, PrivateAppointments.Date(data, attachment)), 16, CareerVisuals.Teal)); var metrics = new HBoxContainer(); metrics.AddThemeConstantOverride("separation", 24); box.AddChild(metrics); foreach (var metric in new[] { ("使用现有", (quantity - buy).ToString()), ("本次补购", buy.ToString()), ("本次支付", $"${ConsumerEngine.Price(good) * (decimal)buy:N0}") }) { var column = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; metrics.AddChild(column); column.AddChild(Text(metric.Item1, 14, _muted)); column.AddChild(Text(metric.Item2, 25, CareerVisuals.Teal)); } box.AddChild(Text(explanation, 16, _muted)); error = Text("", 16, new("efb3aa")); error.Name = "ConsumerAttachmentError"; error.Hide(); box.AddChild(error); }, returnOutsideChat: true);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 16, new("efb3aa"))`；返回值紧邻使用处：`AssignmentExpressionSyntax: error = Text("", 16, new("efb3aa"))`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text((attachment.Kind == "activity" ? "同行者 · " : "接收者 · ") + string.Join("、", target.People.Select(id => GroupChats.Name(data, id))), 17, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text((attachment.Kind == "activity" ? "同行者 · " : "接收者 · ") + string.Join("、", target.People.Select(id => GroupChats.Name(data, id))), 17, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(attachment.Title + " · " + GameCalendar.Text(data, PrivateAppointments.Date(data, attachment)), 16, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Text(attachment.Title + " · " + GameCalendar.Text(data, PrivateAppointments.Date(data, attachment)), 16, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(explanation, 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(explanation, 16, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(good.Name + " ×" + quantity, 23, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(good.Name + " ×" + quantity, 23, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(metric.Item1, 14, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(metric.Item1, 14, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(metric.Item2, 25, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Text(metric.Item2, 25, CareerVisuals.Teal)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("203b48", "688b8b", 10, 18)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("203b48", "688b8b", 10, 18)`
- `NationalSpire.ConsumerAttachments.Prepare(NationalSpire.CareerData, string, string, NationalSpire.PrivateOffer, bool)`；输入表达式：`ConsumerAttachments.Prepare(d, target.Person, target.Group, prepared)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: d => ConsumerAttachments.Prepare(d, target.Person, target.Group, prepared)`
- `NationalSpire.ConsumerAttachments.ToBuy(NationalSpire.CareerData, NationalSpire.Good, int)`；输入表达式：`ConsumerAttachments.ToBuy(data, good, quantity)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ConsumerAttachments.ToBuy(data, good, quantity)`
- `NationalSpire.ConsumerCatalog.Get(string)`；输入表达式：`ConsumerCatalog.Get(attachment.GoodId)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: ConsumerCatalog.Get(attachment.GoodId)!`
- `NationalSpire.ConsumerEngine.HospitalityFee(NationalSpire.Good)`；输入表达式：`ConsumerEngine.HospitalityFee(good)`；返回值紧邻使用处：`InterpolationSyntax: {ConsumerEngine.HospitalityFee(good):N0}`
- `NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`；输入表达式：`ConsumerEngine.Price(good)`；返回值紧邻使用处：`BinaryExpressionSyntax: ConsumerEngine.Price(good) * (decimal)buy`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`Coop.CoopJson.Copy(attachment)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Coop.CoopJson.Copy(attachment)`
- `NationalSpire.EconomicActions.Save(NationalSpire.CareerData, System.Func<NationalSpire.CareerData, string?>)`；输入表达式：`EconomicActions.Save(data, d => ConsumerAttachments.Prepare(d, target.Person, target.Group, prepared))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = EconomicActions.Save(data, d => ConsumerAttachments.Prepare(d, target.Person, target.Group, prepared))`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(data, PrivateAppointments.Date(data, attachment))`；返回值紧邻使用处：`BinaryExpressionSyntax: attachment.Title + " · " + GameCalendar.Text(data, PrivateAppointments.Date(data, attachment))`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(data, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => GroupChats.Name(data, id)`
- `NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?)`；输入表达式：`_multiplayer.Send("consumer-attach", target.Person, JsonSerializer.Serialize(command), accepted: Accepted)`；返回值紧邻使用处：`ExpressionStatementSyntax: _multiplayer.Send("consumer-attach", target.Person, JsonSerializer.Serialize(command), accepted: Accepted);`
- `NationalSpire.LifestyleArt.LifestyleArt()`；输入表达式：`new LifestyleArt { ProductId = good.Id, Category = good.Category + " " + good.Name, CustomMinimumSize = new(100, 100) }`；返回值紧邻使用处：`ArgumentSyntax: new LifestyleArt { ProductId = good.Id, Category = good.Category + " " + good.Name, CustomMinimumSize = new(100, 100) }`
- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Date(data, attachment)`；返回值紧邻使用处：`ArgumentSyntax: PrivateAppointments.Date(data, attachment)`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new PrivateMessageCommand { Request = attachment, Part = target.Group }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PrivateMessageCommand { Request = attachment, Part = target.Group }`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`target.People.Select(id => GroupChats.Name(data, id))`；返回值紧邻使用处：`ArgumentSyntax: target.People.Select(id => GroupChats.Name(data, id))`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(command)`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.Serialize(command)`
- `int.ToString()`；输入表达式：`(quantity - buy).ToString()`；返回值紧邻使用处：`ArgumentSyntax: (quantity - buy).ToString()`
- `int.ToString()`；输入表达式：`buy.ToString()`；返回值紧邻使用处：`ArgumentSyntax: buy.ToString()`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", target.People.Select(id => GroupChats.Name(data, id)))`；返回值紧邻使用处：`BinaryExpressionSyntax: (attachment.Kind == "activity" ? "同行者 · " : "接收者 · ") + string.Join("、", target.People.Select(id => GroupChats.Name(data, id)))`

**赋值（含属性/字段和局部值）：**

- `Category` = `good.Category + " " + good.Name`
- `CustomMinimumSize` = `new(100, 100)`
- `Part` = `target.Group`
- `ProductId` = `good.Id`
- `Request` = `attachment`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `_openingDialogReturn` = `null`
- `_openingDialogReturn` = `returnTo ?? (() => { if (attachment.Kind == "gift") PrivateGiftPicker(target, attachment); else PrivateActivityPicker(good.Id, attachment.GoodVerb, target, attachment); })`
- `error!.Text` = `result`
- `error.Name` = `"ConsumerAttachmentError"`
- `error` = `Text("", 16, new("efb3aa"))`

<a id="symbol-bf6f71fa2076"></a>

## `Accepted() — void Accepted()`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.RefreshPrivateAttachments()`](PrivateMemoryScreen.cs.md#symbol-b9d6c2084031)；[`NationalSpire.CareerScreen.RestoreConsumerDrafts()`](ConsumerCommerceScreen.cs.md#symbol-4c75feed1e1b)；[`NationalSpire.ICareerSession.Refresh()`](CareerSession.cs.md#symbol-bae3aaaf496d)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；`NationalSpire.CareerScreen.RefreshPrivateAttachments()`；`NationalSpire.CareerScreen.RestoreConsumerDrafts()`；`NationalSpire.ConsumerComposer.Group`；`NationalSpire.ConsumerComposer.Person`；`NationalSpire.ICareerSession.Refresh()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；输入表达式：`OpenPrivateMessages(group: target.Group)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenPrivateMessages(group: target.Group);`
- `NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；输入表达式：`OpenPrivateMessages(target.Person)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenPrivateMessages(target.Person);`
- `NationalSpire.CareerScreen.RefreshPrivateAttachments()`；输入表达式：`RefreshPrivateAttachments()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshPrivateAttachments();`
- `NationalSpire.CareerScreen.RestoreConsumerDrafts()`；输入表达式：`RestoreConsumerDrafts()`；返回值紧邻使用处：`ExpressionStatementSyntax: RestoreConsumerDrafts();`
- `NationalSpire.ICareerSession.Refresh()`；输入表达式：`.Refresh()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _multiplayer?.Refresh()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4c75feed1e1b"></a>

## `NationalSpire.CareerScreen.RestoreConsumerDrafts() — private void RestoreConsumerDrafts()`

来源：源码第 68 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Accepted()`](ConsumerCommerceScreen.cs.md#symbol-b8f072aaa76f)；[`Accepted()`](ConsumerCommerceScreen.cs.md#symbol-bf6f71fa2076)；[`NationalSpire.CareerScreen.RefreshPrivateAttachments()`](PrivateMemoryScreen.cs.md#symbol-b9d6c2084031)

**调用：** [`NationalSpire.ConsumerAttachments.Find(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](ConsumerAttachments.cs.md#symbol-eb0f1a1bbf73)；[`NationalSpire.Coop.CoopJson.Copy<T>(T)`](Coop/CoopData.cs.md#symbol-38a51b2b1811)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Remove(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Consumer`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen.PrivateAttachments`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.ConsumerAttachment.Group`；`NationalSpire.ConsumerAttachment.Id`；`NationalSpire.ConsumerAttachment.Offer`；`NationalSpire.ConsumerAttachment.Person`；`NationalSpire.ConsumerAttachment.State`；`NationalSpire.ConsumerAttachments.Find(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.ConsumerState.Attachments`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.PrivateOffer.ConsumerAttachmentId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ConsumerAttachments.Find(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`ConsumerAttachments.Find(d, old)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: ConsumerAttachments.Find(d, old)?.State`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`Coop.CoopJson.Copy(saved.Offer)`；返回值紧邻使用处：`ArgumentSyntax: Coop.CoopJson.Copy(saved.Offer)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateAttachments.Any(a => a.ConsumerAttachmentId == saved.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PrivateAttachments.Any(a => a.ConsumerAttachmentId == saved.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`PrivateAttachments.Where(a => a.ConsumerAttachmentId.Length > 0).ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var old in PrivateAttachments.Where(a => a.ConsumerAttachmentId.Length > 0).ToArray())              if (ConsumerAttachments.Find(d, old)?.State != "draft") PrivateAttachments.Remove(old);`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Consumer.Attachments.Where(x => x.State == "draft" && (x.Group.Length > 0 ? x.Group == _privateGroup : _privateGroup.Length == 0 && x.Person == _privatePerson))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var saved in d.Life.Consumer.Attachments.Where(x => x.State == "draft" && (x.Group.Length > 0 ? x.Group == _privateGroup : _privateGroup.Length == 0 && x.Person == _privatePerson)))              if (!PrivateAttachments.Any(a => a.ConsumerAttachmentId == saved.Id)) PrivateAttachments.Add(Coop.CoopJson.Copy(saved.Offer));`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateAttachments.Where(a => a.ConsumerAttachmentId.Length > 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateAttachments.Where(a => a.ConsumerAttachmentId.Length > 0).ToArray`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`PrivateAttachments.Add(Coop.CoopJson.Copy(saved.Offer))`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateAttachments.Add(Coop.CoopJson.Copy(saved.Offer));`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`PrivateAttachments.Remove(old)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateAttachments.Remove(old);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-635682b51731"></a>

## `NationalSpire.CareerScreen.RemoveConsumerDraft(NationalSpire.PrivateOffer) — private void RemoveConsumerDraft(PrivateOffer a)`

来源：源码第 76 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateAttachmentCard(NationalSpire.PrivateOffer, bool)`](PrivateMemoryScreen.cs.md#symbol-eb2b2a37c5d1)

**调用：** [`Accepted()`](ConsumerCommerceScreen.cs.md#symbol-98ac2ebb0f25)；[`NationalSpire.ConsumerAttachments.Remove(NationalSpire.CareerData, string)`](ConsumerAttachments.cs.md#symbol-54163762ce47)；[`NationalSpire.EconomicActions.Save(NationalSpire.CareerData, System.Func<NationalSpire.CareerData, string?>)`](EconomicActions.cs.md#symbol-6ec38e492fe6)；[`NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-e21b0ff1d18b)；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `Accepted()`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen._privateStatus`；`NationalSpire.ConsumerAttachments.Remove(NationalSpire.CareerData, string)`；`NationalSpire.EconomicActions.Save(NationalSpire.CareerData, System.Func<NationalSpire.CareerData, string?>)`；`NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?)`；`NationalSpire.PrivateMessageCommand.Entry`；`NationalSpire.PrivateOffer.ConsumerAttachmentId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Accepted()`；输入表达式：`Accepted()`；返回值紧邻使用处：`ExpressionStatementSyntax: Accepted();`
- `NationalSpire.ConsumerAttachments.Remove(NationalSpire.CareerData, string)`；输入表达式：`ConsumerAttachments.Remove(d, a.ConsumerAttachmentId)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: d => ConsumerAttachments.Remove(d, a.ConsumerAttachmentId)`
- `NationalSpire.EconomicActions.Save(NationalSpire.CareerData, System.Func<NationalSpire.CareerData, string?>)`；输入表达式：`EconomicActions.Save(ViewData, d => ConsumerAttachments.Remove(d, a.ConsumerAttachmentId))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = EconomicActions.Save(ViewData, d => ConsumerAttachments.Remove(d, a.ConsumerAttachmentId))`
- `NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?)`；输入表达式：`_multiplayer.Send("consumer-remove", _privatePerson, JsonSerializer.Serialize(new PrivateMessageCommand { Entry = a.ConsumerAttachmentId }), accepted: Accepted)`；返回值紧邻使用处：`ExpressionStatementSyntax: _multiplayer.Send("consumer-remove", _privatePerson, JsonSerializer.Serialize(new PrivateMessageCommand { Entry = a.ConsumerAttachmentId }), accepted: Accepted);`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new PrivateMessageCommand { Entry = a.ConsumerAttachmentId }`；返回值紧邻使用处：`ArgumentSyntax: new PrivateMessageCommand { Entry = a.ConsumerAttachmentId }`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(new PrivateMessageCommand { Entry = a.ConsumerAttachmentId })`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.Serialize(new PrivateMessageCommand { Entry = a.ConsumerAttachmentId })`

**赋值（含属性/字段和局部值）：**

- `Entry` = `a.ConsumerAttachmentId`
- `_privateStatus.Text` = `error`

<a id="symbol-98ac2ebb0f25"></a>

## `Accepted() — void Accepted()`

来源：源码第 78 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RemoveConsumerDraft(NationalSpire.PrivateOffer)`](ConsumerCommerceScreen.cs.md#symbol-635682b51731)

**调用：** [`NationalSpire.CareerScreen.RefreshPrivateAttachments()`](PrivateMemoryScreen.cs.md#symbol-b9d6c2084031)；[`NationalSpire.ICareerSession.Refresh()`](CareerSession.cs.md#symbol-bae3aaaf496d)；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen.PrivateAttachments`；`NationalSpire.CareerScreen.RefreshPrivateAttachments()`；`NationalSpire.ICareerSession.Refresh()`；`NationalSpire.PrivateOffer.ConsumerAttachmentId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.RefreshPrivateAttachments()`；输入表达式：`RefreshPrivateAttachments()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshPrivateAttachments();`
- `NationalSpire.ICareerSession.Refresh()`；输入表达式：`.Refresh()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _multiplayer?.Refresh()`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`PrivateAttachments.RemoveAll(x => x.ConsumerAttachmentId == a.ConsumerAttachmentId)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateAttachments.RemoveAll(x => x.ConsumerAttachmentId == a.ConsumerAttachmentId);`

**赋值（含属性/字段和局部值）：**
<a id="symbol-27b7a54df1f4"></a>

## `NationalSpire.CareerScreen.ReserveConsumerDraft(NationalSpire.PrivateOffer) — private void ReserveConsumerDraft(PrivateOffer attachment)`

来源：源码第 87 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`](PrivateMemoryScreen.cs.md#symbol-053a2c0af91b)

**调用：** [`Accepted()`](ConsumerCommerceScreen.cs.md#symbol-b8f072aaa76f)；[`NationalSpire.ConsumerAttachments.Prepare(NationalSpire.CareerData, string, string, NationalSpire.PrivateOffer, bool)`](ConsumerAttachments.cs.md#symbol-bb17fc71b2da)；[`NationalSpire.Coop.CoopJson.Copy<T>(T)`](Coop/CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.EconomicActions.Save(NationalSpire.CareerData, System.Func<NationalSpire.CareerData, string?>)`](EconomicActions.cs.md#symbol-6ec38e492fe6)；[`NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-e21b0ff1d18b)；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `Accepted()`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._groupSelection`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen._privateStatus`；`NationalSpire.ConsumerAttachments.Prepare(NationalSpire.CareerData, string, string, NationalSpire.PrivateOffer, bool)`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.EconomicActions.Save(NationalSpire.CareerData, System.Func<NationalSpire.CareerData, string?>)`；`NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?)`；`NationalSpire.PrivateMessageCommand.Part`；`NationalSpire.PrivateMessageCommand.Request`；`NationalSpire.PrivateOffer.ActorId`；`NationalSpire.PrivateOffer.GroupId`；`NationalSpire.PrivateOffer.Participants`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Accepted()`；输入表达式：`Accepted()`；返回值紧邻使用处：`ExpressionStatementSyntax: Accepted();`
- `NationalSpire.ConsumerAttachments.Prepare(NationalSpire.CareerData, string, string, NationalSpire.PrivateOffer, bool)`；输入表达式：`ConsumerAttachments.Prepare(d, person, group, prepared, buyMissing: false)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: d => ConsumerAttachments.Prepare(d, person, group, prepared, buyMissing: false)`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`Coop.CoopJson.Copy(attachment)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Coop.CoopJson.Copy(attachment)`
- `NationalSpire.EconomicActions.Save(NationalSpire.CareerData, System.Func<NationalSpire.CareerData, string?>)`；输入表达式：`EconomicActions.Save(ViewData, d => ConsumerAttachments.Prepare(d, person, group, prepared, buyMissing: false))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = EconomicActions.Save(ViewData, d => ConsumerAttachments.Prepare(d, person, group, prepared, buyMissing: false))`
- `NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?)`；输入表达式：`_multiplayer.Send("consumer-reserve", person, JsonSerializer.Serialize(new PrivateMessageCommand { Request = prepared, Part = group }), accepted: Accepted)`；返回值紧邻使用处：`ExpressionStatementSyntax: _multiplayer.Send("consumer-reserve", person, JsonSerializer.Serialize(new PrivateMessageCommand { Request = prepared, Part = group }), accepted: Accepted);`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new PrivateMessageCommand { Request = prepared, Part = group }`；返回值紧邻使用处：`ArgumentSyntax: new PrivateMessageCommand { Request = prepared, Part = group }`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`_groupSelection.ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: prepared.Participants = _groupSelection.ToList()`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(new PrivateMessageCommand { Request = prepared, Part = group })`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.Serialize(new PrivateMessageCommand { Request = prepared, Part = group })`

**赋值（含属性/字段和局部值）：**

- `Part` = `group`
- `Request` = `prepared`
- `_privateStatus.Text` = `error`
- `prepared.GroupId` = `group`
- `prepared.Participants` = `_groupSelection.ToList()`

<a id="symbol-b8f072aaa76f"></a>

## `Accepted() — void Accepted()`

来源：源码第 94 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ReserveConsumerDraft(NationalSpire.PrivateOffer)`](ConsumerCommerceScreen.cs.md#symbol-27b7a54df1f4)

**调用：** `Godot.CanvasItem.IsVisibleInTree()`；`Godot.Control.GrabFocus()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；[`NationalSpire.CareerScreen.RefreshPrivateAttachments()`](PrivateMemoryScreen.cs.md#symbol-b9d6c2084031)；[`NationalSpire.CareerScreen.RestoreConsumerDrafts()`](ConsumerCommerceScreen.cs.md#symbol-4c75feed1e1b)；[`NationalSpire.ICareerSession.Refresh()`](CareerSession.cs.md#symbol-bae3aaaf496d)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.RefreshPrivateAttachments()`；`NationalSpire.CareerScreen.RestoreConsumerDrafts()`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._privateInput`；`NationalSpire.ICareerSession.Refresh()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.IsVisibleInTree()`；输入表达式：`_privateInput!.IsVisibleInTree()`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(_privateInput) && _privateInput!.IsVisibleInTree()`
- `Godot.Control.GrabFocus()`；输入表达式：`_privateInput.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateInput.GrabFocus();`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_privateInput)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(_privateInput) && _privateInput!.IsVisibleInTree()`
- `NationalSpire.CareerScreen.RefreshPrivateAttachments()`；输入表达式：`RefreshPrivateAttachments()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshPrivateAttachments();`
- `NationalSpire.CareerScreen.RestoreConsumerDrafts()`；输入表达式：`RestoreConsumerDrafts()`；返回值紧邻使用处：`ExpressionStatementSyntax: RestoreConsumerDrafts();`
- `NationalSpire.ICareerSession.Refresh()`；输入表达式：`.Refresh()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _multiplayer?.Refresh()`

**赋值（含属性/字段和局部值）：**
