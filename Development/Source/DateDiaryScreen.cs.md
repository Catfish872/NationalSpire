# DateDiaryScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`A09CD2254B5E7DA2A3DFD47528510E424E7B53B2DDC1E725E0C6E7E40AFD0A26`。来源：[源码](../../DateDiaryScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-0154b9cfbb28"></a>

## `NationalSpire.CareerScreen.AddCompletedDateCard(NationalSpire.CareerData, string, NationalSpire.PrivateOffer) — private void AddCompletedDateCard(CareerData data, string person, PrivateOffer offer)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-c7881d245b3d)

**调用：** [`FitTitle()`](DateDiaryScreen.cs.md#symbol-7186bfcf8320)；[`NationalSpire.CareerScreen.DateDiaryEntryDialog(NationalSpire.CareerData, string, string)`](DateDiaryScreen.cs.md#symbol-fb4ba1a3b5fa)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-84294149ff91)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；[`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-15c716ec61a1)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.Control()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`

**字段、属性、事件及方法组引用：** `FitTitle()`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._privateBody`；`NationalSpire.CareerScreen.DateDiaryEntryDialog(NationalSpire.CareerData, string, string)`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.State`；`NationalSpire.PrivateOffer.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `FitTitle()`；输入表达式：`FitTitle()`；返回值紧邻使用处：`ExpressionStatementSyntax: FitTitle();`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`summary.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: summary.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`completed.AddThemeStyleboxOverride("panel", CareerVisuals.Box("353042", "cf9db9", 10, 12))`；返回值紧邻使用处：`ExpressionStatementSyntax: completed.AddThemeStyleboxOverride("panel", CareerVisuals.Box("353042", "cf9db9", 10, 12));`
- `Godot.Control.Control()`；输入表达式：`new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`ArgumentSyntax: new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateBody!.AddChild(completed)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateBody!.AddChild(completed);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`completed.AddChild(summary)`；返回值紧邻使用处：`ExpressionStatementSyntax: completed.AddChild(summary);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`summary.AddChild(diary)`；返回值紧邻使用处：`ExpressionStatementSyntax: summary.AddChild(diary);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`summary.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill })`；返回值紧邻使用处：`ExpressionStatementSyntax: summary.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`summary.AddChild(timing)`；返回值紧邻使用处：`ExpressionStatementSyntax: summary.AddChild(timing);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`summary.AddChild(title)`；返回值紧邻使用处：`ExpressionStatementSyntax: summary.AddChild(title);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { Name = "CompletedDateCard" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { Name = "CompletedDateCard" }`
- `NationalSpire.CareerScreen.DateDiaryEntryDialog(NationalSpire.CareerData, string, string)`；输入表达式：`DateDiaryEntryDialog(data, person, offer.Id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => DateDiaryEntryDialog(data, person, offer.Id)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("约会日记", () => DateDiaryEntryDialog(data, person, offer.Id), 120)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton("约会日记", () => DateDiaryEntryDialog(data, person, offer.Id), 120)`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine($"{GameCalendar.Text(data, PrivateAppointments.Date(data, offer))} · {offer.State}", 16, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateLine($"{GameCalendar.Text(data, PrivateAppointments.Date(data, offer))} · {offer.State}", 16, _muted)`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine(offer.Title, 23, _gold)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateLine(offer.Title, 23, _gold)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("353042", "cf9db9", 10, 12)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("353042", "cf9db9", 10, 12)`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(data, PrivateAppointments.Date(data, offer))`；返回值紧邻使用处：`InterpolationSyntax: {GameCalendar.Text(data, PrivateAppointments.Date(data, offer))}`
- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Date(data, offer)`；返回值紧邻使用处：`ArgumentSyntax: PrivateAppointments.Date(data, offer)`

**赋值（含属性/字段和局部值）：**

- `diary.Name` = `"CompletedDateDiary"`
- `Name` = `"CompletedDateCard"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `summary.Resized` += `FitTitle`
- `timing.Name` = `"CompletedDateTime"`
- `timing.SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`
- `timing.SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `title.ClipText` = `true`
- `title.Name` = `"CompletedDateTitle"`
- `title.SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`
- `title.SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `title.TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`

<a id="symbol-7186bfcf8320"></a>

## `FitTitle() — void FitTitle()`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddCompletedDateCard(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](DateDiaryScreen.cs.md#symbol-0154b9cfbb28)

**调用：** `Godot.Control.GetCombinedMinimumSize()`；`Godot.Control.GetThemeFont(Godot.StringName, Godot.StringName)`；`Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；`Godot.Vector2.Vector2(float, float)`；`System.Math.Max(float, float)`；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.GetCombinedMinimumSize()`；输入表达式：`diary.GetCombinedMinimumSize()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: diary.GetCombinedMinimumSize().X`
- `Godot.Control.GetCombinedMinimumSize()`；输入表达式：`timing.GetCombinedMinimumSize()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: timing.GetCombinedMinimumSize().X`
- `Godot.Control.GetThemeFont(Godot.StringName, Godot.StringName)`；输入表达式：`title.GetThemeFont("font")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: title.GetThemeFont("font").GetStringSize`
- `Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；输入表达式：`title.GetThemeFont("font").GetStringSize(title.Text, fontSize: 23)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: title.GetThemeFont("font").GetStringSize(title.Text, fontSize: 23).X`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(Math.Min(title.GetThemeFont("font").GetStringSize(title.Text, fontSize: 23).X,                      Math.Max(0, summary.Size.X - timing.GetCombinedMinimumSize().X - diary.GetCombinedMinimumSize().X - 36)), 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: title.CustomMinimumSize = new(Math.Min(title.GetThemeFont("font").GetStringSize(title.Text, fontSize: 23).X,                      Math.Max(0, summary.Size.X - timing.GetCombinedMinimumSize().X - diary.GetCombinedMinimumSize().X - 36)), 0)`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(0, summary.Size.X - timing.GetCombinedMinimumSize().X - diary.GetCombinedMinimumSize().X - 36)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, summary.Size.X - timing.GetCombinedMinimumSize().X - diary.GetCombinedMinimumSize().X - 36)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(title.GetThemeFont("font").GetStringSize(title.Text, fontSize: 23).X,                      Math.Max(0, summary.Size.X - timing.GetCombinedMinimumSize().X - diary.GetCombinedMinimumSize().X - 36))`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(title.GetThemeFont("font").GetStringSize(title.Text, fontSize: 23).X,                      Math.Max(0, summary.Size.X - timing.GetCombinedMinimumSize().X - diary.GetCombinedMinimumSize().X - 36))`

**赋值（含属性/字段和局部值）：**

- `title.CustomMinimumSize` = `new(Math.Min(title.GetThemeFont("font").GetStringSize(title.Text, fontSize: 23).X,                      Math.Max(0, summary.Size.X - timing.GetCombinedMinimumSize().X - diary.GetCombinedMinimumSize().X - 36)), 0)`

<a id="symbol-2e181417b5e0"></a>

## `NationalSpire.CareerScreen.DateDiaryDialog(NationalSpire.CareerData, string) — private void DateDiaryDialog(CareerData data, string person)`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](PrivateMessageScreen.cs.md#symbol-8e28d3a34860)

**调用：** [`NationalSpire.CareerScreen.DateDiaryEntryDialog(NationalSpire.CareerData, string, string)`](DateDiaryScreen.cs.md#symbol-fb4ba1a3b5fa)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.DateDiaryEntryDialog(NationalSpire.CareerData, string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.DateDiaryEntryDialog(NationalSpire.CareerData, string, string)`；输入表达式：`DateDiaryEntryDialog(data, person, "")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => DateDiaryEntryDialog(data, person, "")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-fb4ba1a3b5fa"></a>

## `NationalSpire.CareerScreen.DateDiaryEntryDialog(NationalSpire.CareerData, string, string) — private void DateDiaryEntryDialog(CareerData data, string person, string offerId)`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddCompletedDateCard(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](DateDiaryScreen.cs.md#symbol-0154b9cfbb28)；[`NationalSpire.CareerScreen.DateDiaryDialog(NationalSpire.CareerData, string)`](DateDiaryScreen.cs.md#symbol-2e181417b5e0)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.DateDiaries.Records(NationalSpire.PrivateConversation)`](DateDiaries.cs.md#symbol-24329f1d823f)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；[`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-ee7b01d76b23)；`Godot.Color.Color(string)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.GodotObject.SetMeta(Godot.StringName, Godot.Variant)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.BroadcastScroll.BroadcastScroll()`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.DateDiaries.Records(NationalSpire.PrivateConversation)`；`NationalSpire.DateDiary.Content`；`NationalSpire.DateDiary.Day`；`NationalSpire.DateDiary.Location`；`NationalSpire.DateDiary.OfferId`；`NationalSpire.DateDiary.Season`；`NationalSpire.DateDiary.Summary`；`NationalSpire.DateDiary.Title`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.PrivateConversation.DateSceneStates`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("efb4d0")`；返回值紧邻使用处：`ArgumentSyntax: new Color("efb4d0")`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`body.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`list.AddThemeConstantOverride("separation", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddThemeConstantOverride("separation", 18);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("292e40", diary.OfferId == offerId ? "efb4d0" : "ad7b97", 8, 18))`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("292e40", diary.OfferId == offerId ? "efb4d0" : "ad7b97", 8, 18));`
- `Godot.GodotObject.SetMeta(Godot.StringName, Godot.Variant)`；输入表达式：`card.SetMeta("offer_id", diary.OfferId)`；返回值紧邻使用处：`ExpressionStatementSyntax: card.SetMeta("offer_id", diary.OfferId);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text("地点 · " + diary.Location, 17, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text("地点 · " + diary.Location, 17, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text("内容 · " + diary.Content, 17, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text("内容 · " + diary.Content, 17, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text($"{GameCalendar.Text(data, SeasonCalendar.Start(data, diary.Season) + diary.Day)} · {diary.Title}", 22, new Color("efb4d0")))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text($"{GameCalendar.Text(data, SeasonCalendar.Start(data, diary.Season) + diary.Day)} · {diary.Title}", 22, new Color("efb4d0")));`
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
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("约会日记 · " + CareerEngine.DisplayName(data, person), "", () => true, "关闭", box =>          {              var scroll = new BroadcastScroll { Name = "DateDiaryScroll", CustomMinimumSize = new(760, 440), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);              var list = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; list.AddThemeConstantOverride("separation", 18); scroll.AddChild(list);              foreach (var diary in DateDiaries.Records(conversation).OrderByDescending(d => d.OfferId == offerId).ThenByDescending(d => d.Season).ThenByDescending(d => d.Day))              {                  var card = new PanelContainer { Name = "DateDiaryEntry" }; card.SetMeta("offer_id", diary.OfferId);                  card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("292e40", diary.OfferId == offerId ? "efb4d0" : "ad7b97", 8, 18)); list.AddChild(card);                  var body = new VBoxContainer(); body.AddThemeConstantOverride("separation", 12); card.AddChild(body);                  body.AddChild(Text($"{GameCalendar.Text(data, SeasonCalendar.Start(data, diary.Season) + diary.Day)} · {diary.Title}", 22, new Color("efb4d0")));                  body.AddChild(Text("地点 · " + diary.Location, 17, _muted)); body.AddChild(Text("内容 · " + diary.Content, 17, _ink));                  body.AddChild(Text(diary.Summary.Length > 0 ? diary.Summary : conversation.DateSceneStates.GetValueOrDefault(diary.OfferId) == "ended" ? "约会已结束，等待对方整理日记。" : "约会进行中，结束后记录这次相处的感想。", 20, _ink));              }          }, showCancel: false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("约会日记 · " + CareerEngine.DisplayName(data, person), "", () => true, "关闭", box =>          {              var scroll = new BroadcastScroll { Name = "DateDiaryScroll", CustomMinimumSize = new(760, 440), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);              var list = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; list.AddThemeConstantOverride("separation", 18); scroll.AddChild(list);              foreach (var diary in DateDiaries.Records(conversation).OrderByDescending(d => d.OfferId == offerId).ThenByDescending(d => d.Season).ThenByDescending(d => d.Day))              {                  var card = new PanelContainer { Name = "DateDiaryEntry" }; card.SetMeta("offer_id", diary.OfferId);                  card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("292e40", diary.OfferId == offerId ? "efb4d0" : "ad7b97", 8, 18)); list.AddChild(card);                  var body = new VBoxContainer(); body.AddThemeConstantOverride("separation", 12); card.AddChild(body);                  body.AddChild(Text($"{GameCalendar.Text(data, SeasonCalendar.Start(data, diary.Season) + diary.Day)} · {diary.Title}", 22, new Color("efb4d0")));                  body.AddChild(Text("地点 · " + diary.Location, 17, _muted)); body.AddChild(Text("内容 · " + diary.Content, 17, _ink));                  body.AddChild(Text(diary.Summary.Length > 0 ? diary.Summary : conversation.DateSceneStates.GetValueOrDefault(diary.OfferId) == "ended" ? "约会已结束，等待对方整理日记。" : "约会进行中，结束后记录这次相处的感想。", 20, _ink));              }          }, showCancel: false);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("地点 · " + diary.Location, 17, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("地点 · " + diary.Location, 17, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("内容 · " + diary.Content, 17, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text("内容 · " + diary.Content, 17, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"{GameCalendar.Text(data, SeasonCalendar.Start(data, diary.Season) + diary.Day)} · {diary.Title}", 22, new Color("efb4d0"))`；返回值紧邻使用处：`ArgumentSyntax: Text($"{GameCalendar.Text(data, SeasonCalendar.Start(data, diary.Season) + diary.Day)} · {diary.Title}", 22, new Color("efb4d0"))`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(diary.Summary.Length > 0 ? diary.Summary : conversation.DateSceneStates.GetValueOrDefault(diary.OfferId) == "ended" ? "约会已结束，等待对方整理日记。" : "约会进行中，结束后记录这次相处的感想。", 20, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(diary.Summary.Length > 0 ? diary.Summary : conversation.DateSceneStates.GetValueOrDefault(diary.OfferId) == "ended" ? "约会已结束，等待对方整理日记。" : "约会进行中，结束后记录这次相处的感想。", 20, _ink)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("292e40", diary.OfferId == offerId ? "efb4d0" : "ad7b97", 8, 18)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("292e40", diary.OfferId == offerId ? "efb4d0" : "ad7b97", 8, 18)`
- `NationalSpire.DateDiaries.Records(NationalSpire.PrivateConversation)`；输入表达式：`DateDiaries.Records(conversation)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateDiaries.Records(conversation).OrderByDescending`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(data, SeasonCalendar.Start(data, diary.Season) + diary.Day)`；返回值紧邻使用处：`InterpolationSyntax: {GameCalendar.Text(data, SeasonCalendar.Start(data, diary.Season) + diary.Day)}`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(data, person)`
- `NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Start(data, diary.Season)`；返回值紧邻使用处：`BinaryExpressionSyntax: SeasonCalendar.Start(data, diary.Season) + diary.Day`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`DateDiaries.Records(conversation).OrderByDescending(d => d.OfferId == offerId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateDiaries.Records(conversation).OrderByDescending(d => d.OfferId == offerId).ThenByDescending`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`conversation.DateSceneStates.GetValueOrDefault(diary.OfferId)`；返回值紧邻使用处：`BinaryExpressionSyntax: conversation.DateSceneStates.GetValueOrDefault(diary.OfferId) == "ended"`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`DateDiaries.Records(conversation).OrderByDescending(d => d.OfferId == offerId).ThenByDescending(d => d.Season).ThenByDescending(d => d.Day)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var diary in DateDiaries.Records(conversation).OrderByDescending(d => d.OfferId == offerId).ThenByDescending(d => d.Season).ThenByDescending(d => d.Day))              {                  var card = new PanelContainer { Name = "DateDiaryEntry" }; card.SetMeta("offer_id", diary.OfferId);                  card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("292e40", diary.OfferId == offerId ? "efb4d0" : "ad7b97", 8, 18)); list.AddChild(card);                  var body = new VBoxContainer(); body.AddThemeConstantOverride("separation", 12); card.AddChild(body);                  body.AddChild(Text($"{GameCalendar.Text(data, SeasonCalendar.Start(data, diary.Season) + diary.Day)} · {diary.Title}", 22, new Color("efb4d0")));                  body.AddChild(Text("地点 · " + diary.Location, 17, _muted)); body.AddChild(Text("内容 · " + diary.Content, 17, _ink));                  body.AddChild(Text(diary.Summary.Length > 0 ? diary.Summary : conversation.DateSceneStates.GetValueOrDefault(diary.OfferId) == "ended" ? "约会已结束，等待对方整理日记。" : "约会进行中，结束后记录这次相处的感想。", 20, _ink));              }`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`DateDiaries.Records(conversation).OrderByDescending(d => d.OfferId == offerId).ThenByDescending(d => d.Season)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateDiaries.Records(conversation).OrderByDescending(d => d.OfferId == offerId).ThenByDescending(d => d.Season).ThenByDescending`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(760, 440)`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `Name` = `"DateDiaryEntry"`
- `Name` = `"DateDiaryScroll"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
