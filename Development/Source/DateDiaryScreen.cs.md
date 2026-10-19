# DateDiaryScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`389A0EBA7F94945188D3F893F5C2FF3B7253FDD8FCD089A75D31512F47B35CAC`。来源：[源码](../../DateDiaryScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp

```

<a id="symbol-2e181417b5e0"></a>

## `NationalSpire.CareerScreen.DateDiaryDialog(NationalSpire.CareerData, string) — private void DateDiaryDialog(CareerData data, string person)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](PrivateMessageScreen.cs.md#symbol-8e28d3a34860)

**调用：** [`NationalSpire.CareerScreen.DateDiaryEntryDialog(NationalSpire.CareerData, string, string)`](DateDiaryScreen.cs.md#symbol-fb4ba1a3b5fa)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.DateDiaryEntryDialog(NationalSpire.CareerData, string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.DateDiaryEntryDialog(NationalSpire.CareerData, string, string)`；输入表达式：`DateDiaryEntryDialog(data, person, "")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => DateDiaryEntryDialog(data, person, "")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-fb4ba1a3b5fa"></a>

## `NationalSpire.CareerScreen.DateDiaryEntryDialog(NationalSpire.CareerData, string, string) — private void DateDiaryEntryDialog(CareerData data, string person, string offerId)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-c7881d245b3d)；[`NationalSpire.CareerScreen.DateDiaryDialog(NationalSpire.CareerData, string)`](DateDiaryScreen.cs.md#symbol-2e181417b5e0)

**调用：** `Godot.Color.Color(string)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.GodotObject.SetMeta(Godot.StringName, Godot.Variant)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.BroadcastScroll.BroadcastScroll()`；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`](CareerDialog.cs.md#symbol-d832b736b02b)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.DateDiaries.Records(NationalSpire.PrivateConversation)`](DateDiaries.cs.md#symbol-24329f1d823f)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.DateDiaries.Records(NationalSpire.PrivateConversation)`；`NationalSpire.DateDiary.Content`；`NationalSpire.DateDiary.Day`；`NationalSpire.DateDiary.Location`；`NationalSpire.DateDiary.OfferId`；`NationalSpire.DateDiary.Season`；`NationalSpire.DateDiary.Summary`；`NationalSpire.DateDiary.Title`；`NationalSpire.PrivateConversation.DateSceneStates`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("efb4d0")`；返回值紧邻使用处：`ArgumentSyntax: new Color("efb4d0")`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`body.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`list.AddThemeConstantOverride("separation", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddThemeConstantOverride("separation", 18);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("292e40", diary.OfferId == offerId ? "efb4d0" : "ad7b97", 8, 18))`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("292e40", diary.OfferId == offerId ? "efb4d0" : "ad7b97", 8, 18));`
- `Godot.GodotObject.SetMeta(Godot.StringName, Godot.Variant)`；输入表达式：`card.SetMeta("offer_id", diary.OfferId)`；返回值紧邻使用处：`ExpressionStatementSyntax: card.SetMeta("offer_id", diary.OfferId);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text("内容 · " + diary.Content, 17, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text("内容 · " + diary.Content, 17, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text("地点 · " + diary.Location, 17, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text("地点 · " + diary.Location, 17, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text($"第{diary.Season}赛季 · 第{diary.Day}天 · {diary.Title}", 22, new Color("efb4d0")))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text($"第{diary.Season}赛季 · 第{diary.Day}天 · {diary.Title}", 22, new Color("efb4d0")));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text(diary.Summary.Length > 0 ? diary.Summary : conversation.DateSceneStates.GetValueOrDefault(diary.OfferId) == "ended" ? "约会已结束，等待对方整理日记。" : "约会进行中，结束后记录这次相处的感想。", 20, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text(diary.Summary.Length > 0 ? diary.Summary : conversation.DateSceneStates.GetValueOrDefault(diary.OfferId) == "ended" ? "约会已结束，等待对方整理日记。" : "约会进行中，结束后记录这次相处的感想。", 20, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`card.AddChild(body)`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddChild(body);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`list.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scroll.AddChild(list)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.AddChild(list);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { Name = "DateDiaryEntry" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { Name = "DateDiaryEntry" }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(760, 440)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(760, 440)`
- `NationalSpire.BroadcastScroll.BroadcastScroll()`；输入表达式：`new BroadcastScroll { Name = "DateDiaryScroll", CustomMinimumSize = new(760, 440), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastScroll { Name = "DateDiaryScroll", CustomMinimumSize = new(760, 440), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, person)`；返回值紧邻使用处：`BinaryExpressionSyntax: "约会日记 · " + CareerEngine.DisplayName(data, person)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；输入表达式：`ShowCareerDialog("约会日记 · " + CareerEngine.DisplayName(data, person), "", () => true, "关闭", box => { var scroll = new BroadcastScroll { Name = "DateDiaryScroll", CustomMinimumSize = new(760, 440), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll); var list = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; list.AddThemeConstantOverride("separation", 18); scroll.AddChild(list); foreach (var diary in DateDiaries.Records(conversation).OrderByDescending(d => d.OfferId == offerId).ThenByDescending(d => d.Season).ThenByDescending(d => d.Day)) { var card = new PanelContainer { Name = "DateDiaryEntry" }; card.SetMeta("offer_id", diary.OfferId); card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("292e40", diary.OfferId == offerId ? "efb4d0" : "ad7b97", 8, 18)); list.AddChild(card); var body = new VBoxContainer(); body.AddThemeConstantOverride("separation", 12); card.AddChild(body); body.AddChild(Text($"第{diary.Season}赛季 · 第{diary.Day}天 · {diary.Title}", 22, new Color("efb4d0"))); body.AddChild(Text("地点 · " + diary.Location, 17, _muted)); body.AddChild(Text("内容 · " + diary.Content, 17, _ink)); body.AddChild(Text(diary.Summary.Length > 0 ? diary.Summary : conversation.DateSceneStates.GetValueOrDefault(diary.OfferId) == "ended" ? "约会已结束，等待对方整理日记。" : "约会进行中，结束后记录这次相处的感想。", 20, _ink)); } }, showCancel: false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("约会日记 · " + CareerEngine.DisplayName(data, person), "", () => true, "关闭", box => { var scroll = new BroadcastScroll { Name = "DateDiaryScroll", CustomMinimumSize = new(760, 440), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll); var list = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; list.AddThemeConstantOverride("separation", 18); scroll.AddChild(list); foreach (var diary in DateDiaries.Records(conversation).OrderByDescending(d => d.OfferId == offerId).ThenByDescending(d => d.Season).ThenByDescending(d => d.Day)) { var card = new PanelContainer { Name = "DateDiaryEntry" }; card.SetMeta("offer_id", diary.OfferId); card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("292e40", diary.OfferId == offerId ? "efb4d0" : "ad7b97", 8, 18)); list.AddChild(card); var body = new VBoxContainer(); body.AddThemeConstantOverride("separation", 12); card.AddChild(body); body.AddChild(Text($"第{diary.Season}赛季 · 第{diary.Day}天 · {diary.Title}", 22, new Color("efb4d0"))); body.AddChild(Text("地点 · " + diary.Location, 17, _muted)); body.AddChild(Text("内容 · " + diary.Content, 17, _ink)); body.AddChild(Text(diary.Summary.Length > 0 ? diary.Summary : conversation.DateSceneStates.GetValueOrDefault(diary.OfferId) == "ended" ? "约会已结束，等待对方整理日记。" : "约会进行中，结束后记录这次相处的感想。", 20, _ink)); } }, showCancel: false);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("内容 · " + diary.Content, 17, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text("内容 · " + diary.Content, 17, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("地点 · " + diary.Location, 17, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("地点 · " + diary.Location, 17, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"第{diary.Season}赛季 · 第{diary.Day}天 · {diary.Title}", 22, new Color("efb4d0"))`；返回值紧邻使用处：`ArgumentSyntax: Text($"第{diary.Season}赛季 · 第{diary.Day}天 · {diary.Title}", 22, new Color("efb4d0"))`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(diary.Summary.Length > 0 ? diary.Summary : conversation.DateSceneStates.GetValueOrDefault(diary.OfferId) == "ended" ? "约会已结束，等待对方整理日记。" : "约会进行中，结束后记录这次相处的感想。", 20, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(diary.Summary.Length > 0 ? diary.Summary : conversation.DateSceneStates.GetValueOrDefault(diary.OfferId) == "ended" ? "约会已结束，等待对方整理日记。" : "约会进行中，结束后记录这次相处的感想。", 20, _ink)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("292e40", diary.OfferId == offerId ? "efb4d0" : "ad7b97", 8, 18)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("292e40", diary.OfferId == offerId ? "efb4d0" : "ad7b97", 8, 18)`
- `NationalSpire.DateDiaries.Records(NationalSpire.PrivateConversation)`；输入表达式：`DateDiaries.Records(conversation)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateDiaries.Records(conversation).OrderByDescending`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(data, person)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`DateDiaries.Records(conversation).OrderByDescending(d => d.OfferId == offerId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateDiaries.Records(conversation).OrderByDescending(d => d.OfferId == offerId).ThenByDescending`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`conversation.DateSceneStates.GetValueOrDefault(diary.OfferId)`；返回值紧邻使用处：`BinaryExpressionSyntax: conversation.DateSceneStates.GetValueOrDefault(diary.OfferId) == "ended"`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`DateDiaries.Records(conversation).OrderByDescending(d => d.OfferId == offerId).ThenByDescending(d => d.Season)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateDiaries.Records(conversation).OrderByDescending(d => d.OfferId == offerId).ThenByDescending(d => d.Season).ThenByDescending`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`DateDiaries.Records(conversation).OrderByDescending(d => d.OfferId == offerId).ThenByDescending(d => d.Season).ThenByDescending(d => d.Day)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var diary in DateDiaries.Records(conversation).OrderByDescending(d => d.OfferId == offerId).ThenByDescending(d => d.Season).ThenByDescending(d => d.Day)) { var card = new PanelContainer { Name = "DateDiaryEntry" }; card.SetMeta("offer_id", diary.OfferId); card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("292e40", diary.OfferId == offerId ? "efb4d0" : "ad7b97", 8, 18)); list.AddChild(card); var body = new VBoxContainer(); body.AddThemeConstantOverride("separation", 12); card.AddChild(body); body.AddChild(Text($"第{diary.Season}赛季 · 第{diary.Day}天 · {diary.Title}", 22, new Color("efb4d0"))); body.AddChild(Text("地点 · " + diary.Location, 17, _muted)); body.AddChild(Text("内容 · " + diary.Content, 17, _ink)); body.AddChild(Text(diary.Summary.Length > 0 ? diary.Summary : conversation.DateSceneStates.GetValueOrDefault(diary.OfferId) == "ended" ? "约会已结束，等待对方整理日记。" : "约会进行中，结束后记录这次相处的感想。", 20, _ink)); }`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(760, 440)`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `Name` = `"DateDiaryEntry"`
- `Name` = `"DateDiaryScroll"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-6147e79e0285"></a>

## `NationalSpire.CareerScreen.GuardInvitationButton(Godot.Button, NationalSpire.CareerData) — private void GuardInvitationButton(Button button, CareerData data)`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Choice(string, string, System.Action)`](PrivateMessageScreen.cs.md#symbol-792e8a9748c7)；[`NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer)`](ConsumerScreen.cs.md#symbol-d0b5fafc7e7c)

**调用：** [`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.ConsumerInvitationStock.Active(NationalSpire.CareerData)`](ConsumerInvitationStock.cs.md#symbol-71fa8e1feaa2)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.ConsumerInvitationStock.Active(NationalSpire.CareerData)`；`NationalSpire.ConsumerInvitationStock.ActiveMessage`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(ConsumerInvitationStock.ActiveMessage, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(ConsumerInvitationStock.ActiveMessage, true);`
- `NationalSpire.ConsumerInvitationStock.Active(NationalSpire.CareerData)`；输入表达式：`ConsumerInvitationStock.Active(data)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ConsumerInvitationStock.Active(data)`

**赋值（含属性/字段和局部值）：**

- `button.Disabled` = `true`
- `button.GuiInput` += `input => { if (input is InputEventMouseButton { Pressed: true, ButtonIndex: MouseButton.Left }) Notice(ConsumerInvitationStock.ActiveMessage, true); }`
- `button.TooltipText` = `ConsumerInvitationStock.ActiveMessage`

<a id="symbol-cdf7f00bf71b"></a>

## `NationalSpire.CareerScreen.PrivateDateInvitationPicker() — private void PrivateDateInvitationPicker()`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`Done()`](DateDiaryScreen.cs.md#symbol-7c2781213a24)；`Godot.BaseButton.SetPressedNoSignal(bool)`；`Godot.Color.Color(string)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.Control()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.FindChild(string, bool, bool)`；`Godot.Node.GetParent()`；`Godot.Node.MoveChild(Godot.Node, int)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.BroadcastScroll.BroadcastScroll()`；[`NationalSpire.CareerScreen.ClosePrivateMessagesCore(bool)`](PrivateMessageScreen.cs.md#symbol-db8b0a9ff8de)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`](CareerDialog.cs.md#symbol-d832b736b02b)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerScreen.Visit(System.Action)`](CareerNavigation.cs.md#symbol-d49752019228)；[`NationalSpire.ConsumerEngine.CanInvite(NationalSpire.CareerData, string)`](ConsumerEngine.cs.md#symbol-2aa34d35c1b8)；[`NationalSpire.ConsumerInvitationStock.Active(NationalSpire.CareerData)`](ConsumerInvitationStock.cs.md#symbol-71fa8e1feaa2)；[`NationalSpire.ConsumerInvitationStock.Availability(NationalSpire.CareerData, string)`](ConsumerInvitationStock.cs.md#symbol-18ffa12d670c)；[`NationalSpire.ConsumerInvitationStock.Ticket(NationalSpire.Good)`](ConsumerInvitationStock.cs.md#symbol-6ac4bb7a00c7)；[`NationalSpire.ConsumerInvitations.Create(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>, bool)`](ConsumerInvitations.cs.md#symbol-cc2d01b16094)；`NationalSpire.ConsumerOrder.ConsumerOrder(string, System.Collections.Generic.List<string>, int, bool)`；[`NationalSpire.EconomicActions.Save(NationalSpire.CareerData, System.Func<NationalSpire.CareerData, string?>)`](EconomicActions.cs.md#symbol-6ec38e492fe6)；`System.Action.Invoke()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `Done()`；`NationalSpire.CareerScreen.ClosePrivateMessagesCore(bool)`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen.Visit(System.Action)`；`NationalSpire.CareerScreen._cancelDialog`；`NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.CareerScreen._lifeSection`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen._shopOwned`；`NationalSpire.CareerScreen._tab`；`NationalSpire.ConsumerCatalog.All`；`NationalSpire.ConsumerEngine.CanInvite(NationalSpire.CareerData, string)`；`NationalSpire.ConsumerInvitationStock.Active(NationalSpire.CareerData)`；`NationalSpire.ConsumerInvitationStock.ActiveMessage`；`NationalSpire.ConsumerInvitationStock.Availability(NationalSpire.CareerData, string)`；`NationalSpire.ConsumerInvitationStock.Ticket(NationalSpire.Good)`；`NationalSpire.ConsumerInvitations.Create(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>, bool)`；`NationalSpire.EconomicActions.Save(NationalSpire.CareerData, System.Func<NationalSpire.CareerData, string?>)`；`NationalSpire.Good.Id`；`NationalSpire.Good.Name`；`NationalSpire.Good.Verbs`；`NationalSpire.GoodVerb.Id`；`NationalSpire.GoodVerb.Name`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Done()`；输入表达式：`Done()`；返回值紧邻使用处：`ExpressionStatementSyntax: Done();`
- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`b.SetPressedNoSignal(b == button)`；返回值紧邻使用处：`ExpressionStatementSyntax: b.SetPressedNoSignal(b == button);`
- `Godot.Color.Color(string)`；输入表达式：`new Color("ee929d")`；返回值紧邻使用处：`ArgumentSyntax: new Color("ee929d")`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`list.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.Control()`；输入表达式：`new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(error)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(error);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`footer.AddChild(shop)`；返回值紧邻使用处：`ExpressionStatementSyntax: footer.AddChild(shop);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`footer.AddChild(spacer)`；返回值紧邻使用处：`ExpressionStatementSyntax: footer.AddChild(spacer);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`list.AddChild(Text("暂无可邀约库存，可前往消费商城购买。", 18, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddChild(Text("暂无可邀约库存，可前往消费商城购买。", 18, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`list.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddChild(button);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scroll.AddChild(list)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.AddChild(list);`
- `Godot.Node.FindChild(string, bool, bool)`；输入表达式：`.FindChild("CareerDialogConfirm", true, false)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _dialogOverlay?.FindChild("CareerDialogConfirm", true, false)`
- `Godot.Node.GetParent()`；输入表达式：`.GetParent()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: confirm?.GetParent()`
- `Godot.Node.MoveChild(Godot.Node, int)`；输入表达式：`footer.MoveChild(shop, 0)`；返回值紧邻使用处：`ExpressionStatementSyntax: footer.MoveChild(shop, 0);`
- `Godot.Node.MoveChild(Godot.Node, int)`；输入表达式：`footer.MoveChild(spacer, 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: footer.MoveChild(spacer, 1);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(680, 360)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(680, 360)`
- `NationalSpire.BroadcastScroll.BroadcastScroll()`；输入表达式：`new BroadcastScroll { CustomMinimumSize = new(680, 360), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastScroll { CustomMinimumSize = new(680, 360), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `NationalSpire.CareerScreen.ClosePrivateMessagesCore(bool)`；输入表达式：`ClosePrivateMessagesCore(false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClosePrivateMessagesCore(false);`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("consumer-invite", item.Good.Id, JsonSerializer.Serialize(new ConsumerOrder(item.Verb, [person])), accepted: Done)`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand("consumer-invite", item.Good.Id, JsonSerializer.Serialize(new ConsumerOrder(item.Verb, [person])), accepted: Done)) return true;`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("邀请约会需要对方好感达到5。", true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("邀请约会需要对方好感达到5。", true);`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(ConsumerInvitationStock.ActiveMessage, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(ConsumerInvitationStock.ActiveMessage, true);`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("前往商城", () => { _cancelDialog?.Invoke(); ClosePrivateMessagesCore(false); Visit(() => { _tab = "生涯生活"; _lifeSection = "消费商城"; _shopOwned = false; }); }, 130)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton("前往商城", () => { _cancelDialog?.Invoke(); ClosePrivateMessagesCore(false); Visit(() => { _tab = "生涯生活"; _lifeSection = "消费商城"; _shopOwned = false; }); }, 130)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton(item.Title + $" · 可用 {available[(item.Good.Id, item.Verb)]}", () => { }, 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton(item.Title + $" · 可用 {available[(item.Good.Id, item.Verb)]}", () => { }, 0)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；输入表达式：`ShowCareerDialog("邀请约会", "选择库存中的活动，附到消息后填写邀约留言。", () => { if (choice is not { } item) return false; void Done() { _multiplayer?.Refresh(); RefreshPrivateAttachments(); } if (MultiplayerCommand("consumer-invite", item.Good.Id, JsonSerializer.Serialize(new ConsumerOrder(item.Verb, [person])), accepted: Done)) return true; string? failure = EconomicActions.Save(data, d => ConsumerInvitations.Create(d, item.Good.Id, item.Verb, [person])); if (failure != null) { error!.Text = failure; return false; } Done(); return true; }, "邀约", box => { var scroll = new BroadcastScroll { CustomMinimumSize = new(680, 360), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll); var list = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; list.AddThemeConstantOverride("separation", 12); scroll.AddChild(list); var options = ConsumerCatalog.All.SelectMany(g => g.Verbs.Length > 0 ? g.Verbs.Select(v => (Good:g, Verb:v.Id, Title:g.Name + " · " + v.Name)) : ConsumerInvitationStock.Ticket(g) ? new[] { (Good:g, Verb:"", Title:g.Name) } : []); var available = ConsumerInvitationStock.Availability(data); var buttons = new List<Button>(); foreach (var item in options.Where(o => available.GetValueOrDefault((o.Good.Id, o.Verb)) > 0)) { var button = PrivateButton(item.Title + $" · 可用 {available[(item.Good.Id, item.Verb)]}", () => { }, 0); button.Alignment = HorizontalAlignment.Left; button.ToggleMode = true; button.SizeFlagsHorizontal = SizeFlags.ExpandFill; button.Pressed += () => { choice = item; foreach (var b in buttons) b.SetPressedNoSignal(b == button); if (confirm != null) confirm.Disabled = false; }; buttons.Add(button); list.AddChild(button); } if (buttons.Count == 0) list.AddChild(Text("暂无可邀约库存，可前往消费商城购买。", 18, _muted)); error = Text("", 16, new Color("ee929d")); box.AddChild(error); })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("邀请约会", "选择库存中的活动，附到消息后填写邀约留言。", () => { if (choice is not { } item) return false; void Done() { _multiplayer?.Refresh(); RefreshPrivateAttachments(); } if (MultiplayerCommand("consumer-invite", item.Good.Id, JsonSerializer.Serialize(new ConsumerOrder(item.Verb, [person])), accepted: Done)) return true; string? failure = EconomicActions.Save(data, d => ConsumerInvitations.Create(d, item.Good.Id, item.Verb, [person])); if (failure != null) { error!.Text = failure; return false; } Done(); return true; }, "邀约", box => { var scroll = new BroadcastScroll { CustomMinimumSize = new(680, 360), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll); var list = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; list.AddThemeConstantOverride("separation", 12); scroll.AddChild(list); var options = ConsumerCatalog.All.SelectMany(g => g.Verbs.Length > 0 ? g.Verbs.Select(v => (Good:g, Verb:v.Id, Title:g.Name + " · " + v.Name)) : ConsumerInvitationStock.Ticket(g) ? new[] { (Good:g, Verb:"", Title:g.Name) } : []); var available = ConsumerInvitationStock.Availability(data); var buttons = new List<Button>(); foreach (var item in options.Where(o => available.GetValueOrDefault((o.Good.Id, o.Verb)) > 0)) { var button = PrivateButton(item.Title + $" · 可用 {available[(item.Good.Id, item.Verb)]}", () => { }, 0); button.Alignment = HorizontalAlignment.Left; button.ToggleMode = true; button.SizeFlagsHorizontal = SizeFlags.ExpandFill; button.Pressed += () => { choice = item; foreach (var b in buttons) b.SetPressedNoSignal(b == button); if (confirm != null) confirm.Disabled = false; }; buttons.Add(button); list.AddChild(button); } if (buttons.Count == 0) list.AddChild(Text("暂无可邀约库存，可前往消费商城购买。", 18, _muted)); error = Text("", 16, new Color("ee929d")); box.AddChild(error); });`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 16, new Color("ee929d"))`；返回值紧邻使用处：`AssignmentExpressionSyntax: error = Text("", 16, new Color("ee929d"))`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("暂无可邀约库存，可前往消费商城购买。", 18, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("暂无可邀约库存，可前往消费商城购买。", 18, _muted)`
- `NationalSpire.CareerScreen.Visit(System.Action)`；输入表达式：`Visit(() => { _tab = "生涯生活"; _lifeSection = "消费商城"; _shopOwned = false; })`；返回值紧邻使用处：`ExpressionStatementSyntax: Visit(() => { _tab = "生涯生活"; _lifeSection = "消费商城"; _shopOwned = false; });`
- `NationalSpire.ConsumerEngine.CanInvite(NationalSpire.CareerData, string)`；输入表达式：`ConsumerEngine.CanInvite(data, person)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ConsumerEngine.CanInvite(data, person)`
- `NationalSpire.ConsumerInvitationStock.Active(NationalSpire.CareerData)`；输入表达式：`ConsumerInvitationStock.Active(data)`；返回值紧邻使用处：`IfStatementSyntax: if (ConsumerInvitationStock.Active(data)) { Notice(ConsumerInvitationStock.ActiveMessage, true); return; }`
- `NationalSpire.ConsumerInvitationStock.Availability(NationalSpire.CareerData, string)`；输入表达式：`ConsumerInvitationStock.Availability(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ConsumerInvitationStock.Availability(data)`
- `NationalSpire.ConsumerInvitationStock.Ticket(NationalSpire.Good)`；输入表达式：`ConsumerInvitationStock.Ticket(g)`；返回值紧邻使用处：`ConditionalExpressionSyntax: ConsumerInvitationStock.Ticket(g) ? new[] { (Good:g, Verb:"", Title:g.Name) } : []`
- `NationalSpire.ConsumerInvitations.Create(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>, bool)`；输入表达式：`ConsumerInvitations.Create(d, item.Good.Id, item.Verb, [person])`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: d => ConsumerInvitations.Create(d, item.Good.Id, item.Verb, [person])`
- `NationalSpire.ConsumerOrder.ConsumerOrder(string, System.Collections.Generic.List<string>, int, bool)`；输入表达式：`new ConsumerOrder(item.Verb, [person])`；返回值紧邻使用处：`ArgumentSyntax: new ConsumerOrder(item.Verb, [person])`
- `NationalSpire.EconomicActions.Save(NationalSpire.CareerData, System.Func<NationalSpire.CareerData, string?>)`；输入表达式：`EconomicActions.Save(data, d => ConsumerInvitations.Create(d, item.Good.Id, item.Verb, [person]))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = EconomicActions.Save(data, d => ConsumerInvitations.Create(d, item.Good.Id, item.Verb, [person]))`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _cancelDialog?.Invoke()`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`g.Verbs.Select(v => (Good:g, Verb:v.Id, Title:g.Name + " · " + v.Name))`；返回值紧邻使用处：`ConditionalExpressionSyntax: g.Verbs.Length > 0 ? g.Verbs.Select(v => (Good:g, Verb:v.Id, Title:g.Name + " · " + v.Name)) : ConsumerInvitationStock.Ticket(g) ? new[] { (Good:g, Verb:"", Title:g.Name) } : []`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`ConsumerCatalog.All.SelectMany(g => g.Verbs.Length > 0 ? g.Verbs.Select(v => (Good:g, Verb:v.Id, Title:g.Name + " · " + v.Name)) : ConsumerInvitationStock.Ticket(g) ? new[] { (Good:g, Verb:"", Title:g.Name) } : [])`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ConsumerCatalog.All.SelectMany(g => g.Verbs.Length > 0 ? g.Verbs.Select(v => (Good:g, Verb:v.Id, Title:g.Name + " · " + v.Name)) : ConsumerInvitationStock.Ticket(g) ? new[] { (Good:g, Verb:"", Title:g.Name) } : [])`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`options.Where(o => available.GetValueOrDefault((o.Good.Id, o.Verb)) > 0)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var item in options.Where(o => available.GetValueOrDefault((o.Good.Id, o.Verb)) > 0)) { var button = PrivateButton(item.Title + $" · 可用 {available[(item.Good.Id, item.Verb)]}", () => { }, 0); button.Alignment = HorizontalAlignment.Left; button.ToggleMode = true; button.SizeFlagsHorizontal = SizeFlags.ExpandFill; button.Pressed += () => { choice = item; foreach (var b in buttons) b.SetPressedNoSignal(b == button); if (confirm != null) confirm.Disabled = false; }; buttons.Add(button); list.AddChild(button); }`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`available.GetValueOrDefault((o.Good.Id, o.Verb))`；返回值紧邻使用处：`BinaryExpressionSyntax: available.GetValueOrDefault((o.Good.Id, o.Verb)) > 0`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`buttons.Add(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: buttons.Add(button);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<Button>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<Button>()`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(new ConsumerOrder(item.Verb, [person]))`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.Serialize(new ConsumerOrder(item.Verb, [person]))`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(680, 360)`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `_lifeSection` = `"消费商城"`
- `_shopOwned` = `false`
- `_tab` = `"生涯生活"`
- `button.Alignment` = `HorizontalAlignment.Left`
- `button.Pressed` += `() => { choice = item; foreach (var b in buttons) b.SetPressedNoSignal(b == button); if (confirm != null) confirm.Disabled = false; }`
- `button.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `button.ToggleMode` = `true`
- `choice` = `item`
- `confirm.Disabled` = `false`
- `confirm.Disabled` = `true`
- `confirm` = `_dialogOverlay?.FindChild("CareerDialogConfirm", true, false) as Button`
- `error!.Text` = `failure`
- `error` = `Text("", 16, new Color("ee929d"))`
- `shop.Name` = `"DateInviteGoToShop"`

<a id="symbol-7c2781213a24"></a>

## `Done() — void Done()`

来源：源码第 43 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateDateInvitationPicker()`](DateDiaryScreen.cs.md#symbol-cdf7f00bf71b)

**调用：** [`NationalSpire.CareerScreen.RefreshPrivateAttachments()`](PrivateMemoryScreen.cs.md#symbol-b9d6c2084031)；[`NationalSpire.ICareerSession.Refresh()`](CareerSession.cs.md#symbol-bae3aaaf496d)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.RefreshPrivateAttachments()`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.ICareerSession.Refresh()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.RefreshPrivateAttachments()`；输入表达式：`RefreshPrivateAttachments()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshPrivateAttachments();`
- `NationalSpire.ICareerSession.Refresh()`；输入表达式：`.Refresh()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _multiplayer?.Refresh()`

**赋值（含属性/字段和局部值）：**
