# DateDiaryScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`ADE85D0496E9C584EA8B66895F12662B6E936D7431212F9C92A8C20100AD8B5C`。来源：[源码](../../DateDiaryScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`、`NationalSpire.DateMemoryEraser`。

字段、事件及初始值（源码原样）：

```csharp

```

<a id="symbol-da0fd94c90a9"></a>

## `NationalSpire.CareerScreen.DateDiaryButton(System.Action, int) — private Button DateDiaryButton(Action open, int width)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddCompletedDateCard(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](DateDiaryScreen.cs.md#symbol-0154b9cfbb28)；[`NationalSpire.CareerScreen.PrivateProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](PrivateMessageScreen.cs.md#symbol-8e28d3a34860)

**调用：** `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("hover", CareerVisuals.Box("895b75", "ffc8df", 8, 10))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("hover", CareerVisuals.Box("895b75", "ffc8df", 8, 10));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("normal", CareerVisuals.Box("69465a", "e5a1c1", 8, 10))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("normal", CareerVisuals.Box("69465a", "e5a1c1", 8, 10));`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("约会日记", open, width)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton("约会日记", open, width)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("69465a", "e5a1c1", 8, 10)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("69465a", "e5a1c1", 8, 10)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("895b75", "ffc8df", 8, 10)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("895b75", "ffc8df", 8, 10)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0154b9cfbb28"></a>

## `NationalSpire.CareerScreen.AddCompletedDateCard(NationalSpire.CareerData, string, NationalSpire.PrivateOffer) — private void AddCompletedDateCard(CareerData data, string person, PrivateOffer offer)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-c7881d245b3d)

**调用：** [`FitTitle()`](DateDiaryScreen.cs.md#symbol-7186bfcf8320)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.Control()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；[`NationalSpire.CareerScreen.DateDiaryButton(System.Action, int)`](DateDiaryScreen.cs.md#symbol-da0fd94c90a9)；[`NationalSpire.CareerScreen.DateDiaryEntryDialog(NationalSpire.CareerData, string, string)`](DateDiaryScreen.cs.md#symbol-fb4ba1a3b5fa)；[`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-84294149ff91)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；[`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-15c716ec61a1)

**字段、属性、事件及方法组引用：** `FitTitle()`；`NationalSpire.CareerScreen.DateDiaryButton(System.Action, int)`；`NationalSpire.CareerScreen.DateDiaryEntryDialog(NationalSpire.CareerData, string, string)`；`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._privateBody`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.State`；`NationalSpire.PrivateOffer.Title`

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
- `NationalSpire.CareerScreen.DateDiaryButton(System.Action, int)`；输入表达式：`DateDiaryButton(() => DateDiaryEntryDialog(data, person, offer.Id), 120)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateDiaryButton(() => DateDiaryEntryDialog(data, person, offer.Id), 120)`
- `NationalSpire.CareerScreen.DateDiaryEntryDialog(NationalSpire.CareerData, string, string)`；输入表达式：`DateDiaryEntryDialog(data, person, offer.Id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => DateDiaryEntryDialog(data, person, offer.Id)`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine($"{GameCalendar.Text(data, PrivateAppointments.Date(data, offer))} · {offer.State}", 16, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateLine($"{GameCalendar.Text(data, PrivateAppointments.Date(data, offer))} · {offer.State}", 16, _muted)`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine(offer.Title, 23, _gold)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateLine(offer.Title, 23, _gold)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("353042", "cf9db9", 10, 12)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("353042", "cf9db9", 10, 12)`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(data, PrivateAppointments.Date(data, offer))`；返回值紧邻使用处：`InterpolationSyntax: {GameCalendar.Text(data, PrivateAppointments.Date(data, offer))}`
- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Date(data, offer)`；返回值紧邻使用处：`ArgumentSyntax: PrivateAppointments.Date(data, offer)`

**赋值（含属性/字段和局部值）：**

- `Name` = `"CompletedDateCard"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `diary.Name` = `"CompletedDateDiary"`
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

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

来源：源码第 31 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](PrivateMessageScreen.cs.md#symbol-8e28d3a34860)

**调用：** [`NationalSpire.CareerScreen.DateDiaryEntryDialog(NationalSpire.CareerData, string, string)`](DateDiaryScreen.cs.md#symbol-fb4ba1a3b5fa)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.DateDiaryEntryDialog(NationalSpire.CareerData, string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.DateDiaryEntryDialog(NationalSpire.CareerData, string, string)`；输入表达式：`DateDiaryEntryDialog(data, person, "")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => DateDiaryEntryDialog(data, person, "")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-fb4ba1a3b5fa"></a>

## `NationalSpire.CareerScreen.DateDiaryEntryDialog(NationalSpire.CareerData, string, string) — private void DateDiaryEntryDialog(CareerData data, string person, string offerId)`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Back()`](DateDiaryScreen.cs.md#symbol-178613c1e28c)；[`NationalSpire.CareerScreen.AddCompletedDateCard(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](DateDiaryScreen.cs.md#symbol-0154b9cfbb28)；[`NationalSpire.CareerScreen.DateDiaryDialog(NationalSpire.CareerData, string)`](DateDiaryScreen.cs.md#symbol-2e181417b5e0)；[`NationalSpire.CareerScreen.OpenDateMemory(NationalSpire.CareerData, string, NationalSpire.DateSceneMemory)`](DateSceneMemoryScreen.cs.md#symbol-5a8c8e2619a9)

**调用：** `Godot.Color.Color(string)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.GodotObject.SetMeta(Godot.StringName, Godot.Variant)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.BroadcastScroll.BroadcastScroll()`；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerScreen.DeleteDateDiaryDialog(NationalSpire.CareerData, string, NationalSpire.DateDiary, NationalSpire.DateSceneMemory?)`](DateDiaryScreen.cs.md#symbol-d6865c262849)；[`NationalSpire.CareerScreen.OpenDateMemory(NationalSpire.CareerData, string, NationalSpire.DateSceneMemory)`](DateSceneMemoryScreen.cs.md#symbol-5a8c8e2619a9)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.DateDiaries.ForPerson(NationalSpire.CareerData, string)`](DateDiaries.cs.md#symbol-61a0ccdee0e3)；[`NationalSpire.DateDiaries.Records(NationalSpire.PrivateConversation)`](DateDiaries.cs.md#symbol-24329f1d823f)；`NationalSpire.DateDiary.DateDiary()`；`NationalSpire.DateMemoryEraser.DateMemoryEraser()`；[`NationalSpire.DateSceneMemories.ForPerson(NationalSpire.CareerData, string, out string)`](DateSceneMemories.cs.md#symbol-8302de288689)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；[`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-ee7b01d76b23)；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen.DeleteDateDiaryDialog(NationalSpire.CareerData, string, NationalSpire.DateDiary, NationalSpire.DateSceneMemory?)`；`NationalSpire.CareerScreen.OpenDateMemory(NationalSpire.CareerData, string, NationalSpire.DateSceneMemory)`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.DateDiaries.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.DateDiaries.Records(NationalSpire.PrivateConversation)`；`NationalSpire.DateDiary.Content`；`NationalSpire.DateDiary.Day`；`NationalSpire.DateDiary.Location`；`NationalSpire.DateDiary.OfferId`；`NationalSpire.DateDiary.Season`；`NationalSpire.DateDiary.Summary`；`NationalSpire.DateDiary.Title`；`NationalSpire.DateSceneMemories.ForPerson(NationalSpire.CareerData, string, out string)`；`NationalSpire.DateSceneMemory.Day`；`NationalSpire.DateSceneMemory.Host`；`NationalSpire.DateSceneMemory.OfferId`；`NationalSpire.DateSceneMemory.Season`；`NationalSpire.DateSceneMemory.Title`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.PrivateConversation.DateSceneStates`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("efb4d0")`；返回值紧邻使用处：`ArgumentSyntax: new Color("efb4d0")`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`actions.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`body.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`list.AddThemeConstantOverride("separation", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddThemeConstantOverride("separation", 18);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("292e40", diary.OfferId == offerId ? "efb4d0" : "ad7b97", 8, 18))`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("292e40", diary.OfferId == offerId ? "efb4d0" : "ad7b97", 8, 18));`
- `Godot.GodotObject.SetMeta(Godot.StringName, Godot.Variant)`；输入表达式：`card.SetMeta("offer_id", diary.OfferId)`；返回值紧邻使用处：`ExpressionStatementSyntax: card.SetMeta("offer_id", diary.OfferId);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { Alignment = BoxContainer.AlignmentMode.End }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { Alignment = BoxContainer.AlignmentMode.End }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(enter)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(enter);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(erase)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(erase);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text("内容 · " + diary.Content, 17, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text("内容 · " + diary.Content, 17, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text("地点 · " + diary.Location, 17, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text("地点 · " + diary.Location, 17, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text($"{GameCalendar.Text(data, SeasonCalendar.Start(data, diary.Season) + diary.Day)} · {diary.Title}", 22, new Color("efb4d0")))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text($"{GameCalendar.Text(data, SeasonCalendar.Start(data, diary.Season) + diary.Day)} · {diary.Title}", 22, new Color("efb4d0")));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text(diary.Summary.Length > 0 ? diary.Summary : ended ? "约会已结束，等待对方整理日记。" : "约会进行中，结束后记录这次相处的感想。", 20, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text(diary.Summary.Length > 0 ? diary.Summary : ended ? "约会已结束，等待对方整理日记。" : "约会进行中，结束后记录这次相处的感想。", 20, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(actions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(memoryWarning, 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(memoryWarning, 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`card.AddChild(body)`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddChild(body);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`erase.AddChild(new DateMemoryEraser { MouseFilter = MouseFilterEnum.Ignore })`；返回值紧邻使用处：`ExpressionStatementSyntax: erase.AddChild(new DateMemoryEraser { MouseFilter = MouseFilterEnum.Ignore });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`list.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scroll.AddChild(list)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.AddChild(list);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { Name = "DateDiaryEntry" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { Name = "DateDiaryEntry" }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(48, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: erase.CustomMinimumSize = new(48, 48)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(760, 440)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(760, 440)`
- `NationalSpire.BroadcastScroll.BroadcastScroll()`；输入表达式：`new BroadcastScroll { Name = "DateDiaryScroll", CustomMinimumSize = new(760, 440), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastScroll { Name = "DateDiaryScroll", CustomMinimumSize = new(760, 440), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, person)`；返回值紧邻使用处：`BinaryExpressionSyntax: "约会日记 · " + CareerEngine.DisplayName(data, person)`
- `NationalSpire.CareerScreen.DeleteDateDiaryDialog(NationalSpire.CareerData, string, NationalSpire.DateDiary, NationalSpire.DateSceneMemory?)`；输入表达式：`DeleteDateDiaryDialog(data, person, diary, memory)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => DeleteDateDiaryDialog(data, person, diary, memory)`
- `NationalSpire.CareerScreen.OpenDateMemory(NationalSpire.CareerData, string, NationalSpire.DateSceneMemory)`；输入表达式：`OpenDateMemory(data, person, memory)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenDateMemory(data, person, memory)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("", () => DeleteDateDiaryDialog(data, person, diary, memory), 48)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton("", () => DeleteDateDiaryDialog(data, person, diary, memory), 48)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("进入回忆", () => OpenDateMemory(data, person, memory), 150)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton("进入回忆", () => OpenDateMemory(data, person, memory), 150)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("约会日记 · " + CareerEngine.DisplayName(data, person), "", () => true, "关闭", box => { if (memoryWarning.Length > 0) box.AddChild(Text(memoryWarning, 16, _muted)); var scroll = new BroadcastScroll { Name = "DateDiaryScroll", CustomMinimumSize = new(760, 440), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll); var list = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; list.AddThemeConstantOverride("separation", 18); scroll.AddChild(list); foreach (var diary in diaries.OrderByDescending(d => d.OfferId == offerId).ThenByDescending(d => d.Season).ThenByDescending(d => d.Day)) { var card = new PanelContainer { Name = "DateDiaryEntry" }; card.SetMeta("offer_id", diary.OfferId); card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("292e40", diary.OfferId == offerId ? "efb4d0" : "ad7b97", 8, 18)); list.AddChild(card); var body = new VBoxContainer(); body.AddThemeConstantOverride("separation", 12); card.AddChild(body); body.AddChild(Text($"{GameCalendar.Text(data, SeasonCalendar.Start(data, diary.Season) + diary.Day)} · {diary.Title}", 22, new Color("efb4d0"))); body.AddChild(Text("地点 · " + diary.Location, 17, _muted)); body.AddChild(Text("内容 · " + diary.Content, 17, _ink)); string host = references.FirstOrDefault(e => e.Diary.OfferId == diary.OfferId).Host ?? person; bool ended = PrivateMessages.Mailbox(data).Conversations.GetValueOrDefault(host)?.DateSceneStates.GetValueOrDefault(diary.OfferId) == "ended" || memories.Any(m => m.OfferId == diary.OfferId); body.AddChild(Text(diary.Summary.Length > 0 ? diary.Summary : ended ? "约会已结束，等待对方整理日记。" : "约会进行中，结束后记录这次相处的感想。", 20, _ink)); var memory = memories.FirstOrDefault(m => m.OfferId == diary.OfferId); var actions = new HBoxContainer { Alignment = BoxContainer.AlignmentMode.End }; actions.AddThemeConstantOverride("separation", 12); body.AddChild(actions); var erase = PrivateButton("", () => DeleteDateDiaryDialog(data, person, diary, memory), 48); erase.Name = "DateEraseMemory"; erase.TooltipText = "管理这段回忆"; erase.CustomMinimumSize = new(48, 48); erase.AddChild(new DateMemoryEraser { MouseFilter = MouseFilterEnum.Ignore }); actions.AddChild(erase); if (memory != null) { var enter = PrivateButton("进入回忆", () => OpenDateMemory(data, person, memory), 150); enter.Name = "DateEnterMemory"; actions.AddChild(enter); } } }, showCancel: false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("约会日记 · " + CareerEngine.DisplayName(data, person), "", () => true, "关闭", box => { if (memoryWarning.Length > 0) box.AddChild(Text(memoryWarning, 16, _muted)); var scroll = new BroadcastScroll { Name = "DateDiaryScroll", CustomMinimumSize = new(760, 440), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll); var list = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; list.AddThemeConstantOverride("separation", 18); scroll.AddChild(list); foreach (var diary in diaries.OrderByDescending(d => d.OfferId == offerId).ThenByDescending(d => d.Season).ThenByDescending(d => d.Day)) { var card = new PanelContainer { Name = "DateDiaryEntry" }; card.SetMeta("offer_id", diary.OfferId); card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("292e40", diary.OfferId == offerId ? "efb4d0" : "ad7b97", 8, 18)); list.AddChild(card); var body = new VBoxContainer(); body.AddThemeConstantOverride("separation", 12); card.AddChild(body); body.AddChild(Text($"{GameCalendar.Text(data, SeasonCalendar.Start(data, diary.Season) + diary.Day)} · {diary.Title}", 22, new Color("efb4d0"))); body.AddChild(Text("地点 · " + diary.Location, 17, _muted)); body.AddChild(Text("内容 · " + diary.Content, 17, _ink)); string host = references.FirstOrDefault(e => e.Diary.OfferId == diary.OfferId).Host ?? person; bool ended = PrivateMessages.Mailbox(data).Conversations.GetValueOrDefault(host)?.DateSceneStates.GetValueOrDefault(diary.OfferId) == "ended" || memories.Any(m => m.OfferId == diary.OfferId); body.AddChild(Text(diary.Summary.Length > 0 ? diary.Summary : ended ? "约会已结束，等待对方整理日记。" : "约会进行中，结束后记录这次相处的感想。", 20, _ink)); var memory = memories.FirstOrDefault(m => m.OfferId == diary.OfferId); var actions = new HBoxContainer { Alignment = BoxContainer.AlignmentMode.End }; actions.AddThemeConstantOverride("separation", 12); body.AddChild(actions); var erase = PrivateButton("", () => DeleteDateDiaryDialog(data, person, diary, memory), 48); erase.Name = "DateEraseMemory"; erase.TooltipText = "管理这段回忆"; erase.CustomMinimumSize = new(48, 48); erase.AddChild(new DateMemoryEraser { MouseFilter = MouseFilterEnum.Ignore }); actions.AddChild(erase); if (memory != null) { var enter = PrivateButton("进入回忆", () => OpenDateMemory(data, person, memory), 150); enter.Name = "DateEnterMemory"; actions.AddChild(enter); } } }, showCancel: false);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("内容 · " + diary.Content, 17, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text("内容 · " + diary.Content, 17, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("地点 · " + diary.Location, 17, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("地点 · " + diary.Location, 17, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"{GameCalendar.Text(data, SeasonCalendar.Start(data, diary.Season) + diary.Day)} · {diary.Title}", 22, new Color("efb4d0"))`；返回值紧邻使用处：`ArgumentSyntax: Text($"{GameCalendar.Text(data, SeasonCalendar.Start(data, diary.Season) + diary.Day)} · {diary.Title}", 22, new Color("efb4d0"))`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(diary.Summary.Length > 0 ? diary.Summary : ended ? "约会已结束，等待对方整理日记。" : "约会进行中，结束后记录这次相处的感想。", 20, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(diary.Summary.Length > 0 ? diary.Summary : ended ? "约会已结束，等待对方整理日记。" : "约会进行中，结束后记录这次相处的感想。", 20, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(memoryWarning, 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(memoryWarning, 16, _muted)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("292e40", diary.OfferId == offerId ? "efb4d0" : "ad7b97", 8, 18)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("292e40", diary.OfferId == offerId ? "efb4d0" : "ad7b97", 8, 18)`
- `NationalSpire.DateDiaries.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`DateDiaries.ForPerson(data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateDiaries.ForPerson(data, person)`
- `NationalSpire.DateDiaries.Records(NationalSpire.PrivateConversation)`；输入表达式：`DateDiaries.Records(source)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateDiaries.Records(source).FirstOrDefault`
- `NationalSpire.DateDiary.DateDiary()`；输入表达式：`new() { OfferId = memory.OfferId, Title = memory.Title, Season = memory.Season, Day = memory.Day }`；返回值紧邻使用处：`ConditionalExpressionSyntax: source == null ? new() { OfferId = memory.OfferId, Title = memory.Title, Season = memory.Season, Day = memory.Day } : DateDiaries.Records(source).FirstOrDefault(d => d.OfferId == memory.OfferId) ?? new() { OfferId = memory.OfferId, Title = memory.Title, Season = memory.Season, Day = memory.Day }`
- `NationalSpire.DateDiary.DateDiary()`；输入表达式：`new() { OfferId = memory.OfferId, Title = memory.Title, Season = memory.Season, Day = memory.Day }`；返回值紧邻使用处：`BinaryExpressionSyntax: DateDiaries.Records(source).FirstOrDefault(d => d.OfferId == memory.OfferId) ?? new() { OfferId = memory.OfferId, Title = memory.Title, Season = memory.Season, Day = memory.Day }`
- `NationalSpire.DateMemoryEraser.DateMemoryEraser()`；输入表达式：`new DateMemoryEraser { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`ArgumentSyntax: new DateMemoryEraser { MouseFilter = MouseFilterEnum.Ignore }`
- `NationalSpire.DateSceneMemories.ForPerson(NationalSpire.CareerData, string, out string)`；输入表达式：`DateSceneMemories.ForPerson(data, person, out string memoryWarning)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateSceneMemories.ForPerson(data, person, out string memoryWarning)`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(data, SeasonCalendar.Start(data, diary.Season) + diary.Day)`；返回值紧邻使用处：`InterpolationSyntax: {GameCalendar.Text(data, SeasonCalendar.Start(data, diary.Season) + diary.Day)}`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(data, person)`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations`
- `NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Start(data, diary.Season)`；返回值紧邻使用处：`BinaryExpressionSyntax: SeasonCalendar.Start(data, diary.Season) + diary.Day`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`diaries.All(d => d.OfferId != m.OfferId)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: m => diaries.All(d => d.OfferId != m.OfferId)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`memories.Any(m => m.OfferId == diary.OfferId)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateMessages.Mailbox(data).Conversations.GetValueOrDefault(host)?.DateSceneStates.GetValueOrDefault(diary.OfferId) == "ended" || memories.Any(m => m.OfferId == diary.OfferId)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`DateDiaries.Records(source).FirstOrDefault(d => d.OfferId == memory.OfferId)`；返回值紧邻使用处：`BinaryExpressionSyntax: DateDiaries.Records(source).FirstOrDefault(d => d.OfferId == memory.OfferId) ?? new() { OfferId = memory.OfferId, Title = memory.Title, Season = memory.Season, Day = memory.Day }`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`memories.FirstOrDefault(m => m.OfferId == diary.OfferId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = memories.FirstOrDefault(m => m.OfferId == diary.OfferId)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`references.FirstOrDefault(e => e.Diary.OfferId == diary.OfferId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: references.FirstOrDefault(e => e.Diary.OfferId == diary.OfferId).Host`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`diaries.OrderByDescending(d => d.OfferId == offerId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: diaries.OrderByDescending(d => d.OfferId == offerId).ThenByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`references.Select(e => e.Diary)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: references.Select(e => e.Diary).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`references.Select(e => e.Diary).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = references.Select(e => e.Diary).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`memories.Where(m => diaries.All(d => d.OfferId != m.OfferId))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var memory in memories.Where(m => diaries.All(d => d.OfferId != m.OfferId))) { var source = PrivateMessages.Mailbox(data).Conversations.GetValueOrDefault(memory.Host); diaries.Add(source == null ? new() { OfferId = memory.OfferId, Title = memory.Title, Season = memory.Season, Day = memory.Day } : DateDiaries.Records(source).FirstOrDefault(d => d.OfferId == memory.OfferId) ?? new() { OfferId = memory.OfferId, Title = memory.Title, Season = memory.Season, Day = memory.Day }); }`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`.DateSceneStates.GetValueOrDefault(diary.OfferId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations.GetValueOrDefault(host)?.DateSceneStates.GetValueOrDefault(diary.OfferId)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.GetValueOrDefault(host)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations.GetValueOrDefault(host)?.DateSceneStates.GetValueOrDefault(diary.OfferId)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.GetValueOrDefault(memory.Host)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Mailbox(data).Conversations.GetValueOrDefault(memory.Host)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`diaries.Add(source == null ? new() { OfferId = memory.OfferId, Title = memory.Title, Season = memory.Season, Day = memory.Day } : DateDiaries.Records(source).FirstOrDefault(d => d.OfferId == memory.OfferId) ?? new() { OfferId = memory.OfferId, Title = memory.Title, Season = memory.Season, Day = memory.Day })`；返回值紧邻使用处：`ExpressionStatementSyntax: diaries.Add(source == null ? new() { OfferId = memory.OfferId, Title = memory.Title, Season = memory.Season, Day = memory.Day } : DateDiaries.Records(source).FirstOrDefault(d => d.OfferId == memory.OfferId) ?? new() { OfferId = memory.OfferId, Title = memory.Title, Season = memory.Season, Day = memory.Day });`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`diaries.OrderByDescending(d => d.OfferId == offerId).ThenByDescending(d => d.Season)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: diaries.OrderByDescending(d => d.OfferId == offerId).ThenByDescending(d => d.Season).ThenByDescending`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`diaries.OrderByDescending(d => d.OfferId == offerId).ThenByDescending(d => d.Season).ThenByDescending(d => d.Day)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var diary in diaries.OrderByDescending(d => d.OfferId == offerId).ThenByDescending(d => d.Season).ThenByDescending(d => d.Day)) { var card = new PanelContainer { Name = "DateDiaryEntry" }; card.SetMeta("offer_id", diary.OfferId); card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("292e40", diary.OfferId == offerId ? "efb4d0" : "ad7b97", 8, 18)); list.AddChild(card); var body = new VBoxContainer(); body.AddThemeConstantOverride("separation", 12); card.AddChild(body); body.AddChild(Text($"{GameCalendar.Text(data, SeasonCalendar.Start(data, diary.Season) + diary.Day)} · {diary.Title}", 22, new Color("efb4d0"))); body.AddChild(Text("地点 · " + diary.Location, 17, _muted)); body.AddChild(Text("内容 · " + diary.Content, 17, _ink)); string host = references.FirstOrDefault(e => e.Diary.OfferId == diary.OfferId).Host ?? person; bool ended = PrivateMessages.Mailbox(data).Conversations.GetValueOrDefault(host)?.DateSceneStates.GetValueOrDefault(diary.OfferId) == "ended" || memories.Any(m => m.OfferId == diary.OfferId); body.AddChild(Text(diary.Summary.Length > 0 ? diary.Summary : ended ? "约会已结束，等待对方整理日记。" : "约会进行中，结束后记录这次相处的感想。", 20, _ink)); var memory = memories.FirstOrDefault(m => m.OfferId == diary.OfferId); var actions = new HBoxContainer { Alignment = BoxContainer.AlignmentMode.End }; actions.AddThemeConstantOverride("separation", 12); body.AddChild(actions); var erase = PrivateButton("", () => DeleteDateDiaryDialog(data, person, diary, memory), 48); erase.Name = "DateEraseMemory"; erase.TooltipText = "管理这段回忆"; erase.CustomMinimumSize = new(48, 48); erase.AddChild(new DateMemoryEraser { MouseFilter = MouseFilterEnum.Ignore }); actions.AddChild(erase); if (memory != null) { var enter = PrivateButton("进入回忆", () => OpenDateMemory(data, person, memory), 150); enter.Name = "DateEnterMemory"; actions.AddChild(enter); } }`

**赋值（含属性/字段和局部值）：**

- `Alignment` = `BoxContainer.AlignmentMode.End`
- `CustomMinimumSize` = `new(760, 440)`
- `Day` = `memory.Day`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Name` = `"DateDiaryEntry"`
- `Name` = `"DateDiaryScroll"`
- `OfferId` = `memory.OfferId`
- `Season` = `memory.Season`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Title` = `memory.Title`
- `enter.Name` = `"DateEnterMemory"`
- `erase.CustomMinimumSize` = `new(48, 48)`
- `erase.Name` = `"DateEraseMemory"`
- `erase.TooltipText` = `"管理这段回忆"`

<a id="symbol-d6865c262849"></a>

## `NationalSpire.CareerScreen.DeleteDateDiaryDialog(NationalSpire.CareerData, string, NationalSpire.DateDiary, NationalSpire.DateSceneMemory?) — private void DeleteDateDiaryDialog(CareerData data, string person, DateDiary diary, DateSceneMemory? memory)`

来源：源码第 73 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DateDiaryEntryDialog(NationalSpire.CareerData, string, string)`](DateDiaryScreen.cs.md#symbol-fb4ba1a3b5fa)

**调用：** [`Back()`](DateDiaryScreen.cs.md#symbol-178613c1e28c)；`Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.FindChild(string, bool, bool)`；`Godot.Node.GetParent()`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.DateDiaries.ForPerson(NationalSpire.CareerData, string)`](DateDiaries.cs.md#symbol-61a0ccdee0e3)；[`NationalSpire.DateSceneMemories.Delete(NationalSpire.CareerData, string)`](DateSceneMemories.cs.md#symbol-a32b756f581f)；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；[`Removed()`](DateDiaryScreen.cs.md#symbol-d4d8f582fe1c)；`System.Action.Invoke()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `Back()`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen._cancelDialog`；`NationalSpire.CareerScreen._dateMemory`；`NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.CareerScreen._muted`；`NationalSpire.DateDiaries.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.DateDiary.OfferId`；`NationalSpire.DateMemoryRecorder.Memory`；`NationalSpire.DateSceneMemories.Delete(NationalSpire.CareerData, string)`；`NationalSpire.DateSceneMemory.Host`；`NationalSpire.DateSceneMemory.OfferId`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMessageCommand.Offer`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`Removed()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Back()`；输入表达式：`Back()`；返回值紧邻使用处：`ExpressionStatementSyntax: Back();`
- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(Back).CallDeferred()`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Callable.From(Back).CallDeferred()`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(Back)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(Back).CallDeferred`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(clear)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(clear);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(remove)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(remove);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.GetParent().AddChild(error)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.GetParent().AddChild(error);`
- `Godot.Node.FindChild(string, bool, bool)`；输入表达式：`_dialogOverlay!.FindChild("CareerDialogConfirm", true, false)`；返回值紧邻使用处：`BinaryExpressionSyntax: _dialogOverlay!.FindChild("CareerDialogConfirm", true, false) as Button`
- `Godot.Node.GetParent()`；输入表达式：`cancel!.GetParent()`；返回值紧邻使用处：`CastExpressionSyntax: (HBoxContainer)cancel!.GetParent()`
- `Godot.Node.GetParent()`；输入表达式：`row.GetParent()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: row.GetParent().AddChild`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(180, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: cancel.CustomMinimumSize = new(180, 48)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(180, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: clear.CustomMinimumSize = new(180, 48)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(180, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: remove.CustomMinimumSize = new(180, 48)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("删除回忆对话", () => { try { DateSceneMemories.Delete(data, diary.OfferId); if (_dateMemory?.Memory.OfferId == diary.OfferId) _dateMemory = null; Back(); } catch (Exception e) { error.Text = "删除失败：" + e.Message; } }, 180)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton("删除回忆对话", () => { try { DateSceneMemories.Delete(data, diary.OfferId); if (_dateMemory?.Memory.OfferId == diary.OfferId) _dateMemory = null; Back(); } catch (Exception e) { error.Text = "删除失败：" + e.Message; } }, 180)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("删除整篇日记", () => { string owner = memory?.Host ?? DateDiaries.ForPerson(data, person).FirstOrDefault(e => e.Diary.OfferId == diary.OfferId).Host ?? person; void Removed() { try { DateSceneMemories.Delete(data, diary.OfferId); if (_dateMemory?.Memory.OfferId == diary.OfferId) _dateMemory = null; Back(); } catch (Exception e) { if (IsInstanceValid(error)) error.Text = "日记已删除，回忆文件清理失败：" + e.Message; } } if (memory != null && !PrivateMessages.Mailbox(data).Conversations.ContainsKey(owner)) { Removed(); return; } PrivateCommand("dm-date-diary-delete", new() { Offer = diary.OfferId }, Removed, owner, message => error.Text = message); }, 180)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton("删除整篇日记", () => { string owner = memory?.Host ?? DateDiaries.ForPerson(data, person).FirstOrDefault(e => e.Diary.OfferId == diary.OfferId).Host ?? person; void Removed() { try { DateSceneMemories.Delete(data, diary.OfferId); if (_dateMemory?.Memory.OfferId == diary.OfferId) _dateMemory = null; Back(); } catch (Exception e) { if (IsInstanceValid(error)) error.Text = "日记已删除，回忆文件清理失败：" + e.Message; } } if (memory != null && !PrivateMessages.Mailbox(data).Conversations.ContainsKey(owner)) { Removed(); return; } PrivateCommand("dm-date-diary-delete", new() { Offer = diary.OfferId }, Removed, owner, message => error.Text = message); }, 180)`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；输入表达式：`PrivateCommand("dm-date-diary-delete", new() { Offer = diary.OfferId }, Removed, owner, message => error.Text = message)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateCommand("dm-date-diary-delete", new() { Offer = diary.OfferId }, Removed, owner, message => error.Text = message);`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("是否删除这段回忆？", "删除回忆对话：清除录制的对话与画面，保留日记摘要。\n删除整篇日记：一并移除该场约会的日记和回忆。\n已产生的角色记忆、关系和游戏结果保持原状。", () => true, "取消", showCancel: false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("是否删除这段回忆？", "删除回忆对话：清除录制的对话与画面，保留日记摘要。\n删除整篇日记：一并移除该场约会的日记和回忆。\n已产生的角色记忆、关系和游戏结果保持原状。", () => true, "取消", showCancel: false);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 16, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("", 16, _muted)`
- `NationalSpire.DateDiaries.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`DateDiaries.ForPerson(data, person)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateDiaries.ForPerson(data, person).FirstOrDefault`
- `NationalSpire.DateSceneMemories.Delete(NationalSpire.CareerData, string)`；输入表达式：`DateSceneMemories.Delete(data, diary.OfferId)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateSceneMemories.Delete(data, diary.OfferId);`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Offer = diary.OfferId }`；返回值紧邻使用处：`ArgumentSyntax: new() { Offer = diary.OfferId }`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations`
- `Removed()`；输入表达式：`Removed()`；返回值紧邻使用处：`ExpressionStatementSyntax: Removed();`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _cancelDialog?.Invoke()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.ContainsKey(owner)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PrivateMessages.Mailbox(data).Conversations.ContainsKey(owner)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`DateDiaries.ForPerson(data, person).FirstOrDefault(e => e.Diary.OfferId == diary.OfferId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateDiaries.ForPerson(data, person).FirstOrDefault(e => e.Diary.OfferId == diary.OfferId).Host`

**赋值（含属性/字段和局部值）：**

- `Offer` = `diary.OfferId`
- `_dateMemory` = `null`
- `cancel.CustomMinimumSize` = `new(180, 48)`
- `cancel.Pressed` += `() => Callable.From(Back).CallDeferred()`
- `clear.CustomMinimumSize` = `new(180, 48)`
- `clear.Disabled` = `memory == null`
- `clear.Name` = `"DateDeleteReplay"`
- `error.Text` = `"删除失败：" + e.Message`
- `error.Text` = `message`
- `remove.CustomMinimumSize` = `new(180, 48)`
- `remove.Name` = `"DateDeleteDiary"`

<a id="symbol-178613c1e28c"></a>

## `Back() — void Back()`

来源：源码第 80 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DeleteDateDiaryDialog(NationalSpire.CareerData, string, NationalSpire.DateDiary, NationalSpire.DateSceneMemory?)`](DateDiaryScreen.cs.md#symbol-d6865c262849)；[`Removed()`](DateDiaryScreen.cs.md#symbol-d4d8f582fe1c)

**调用：** `Godot.Node.IsInsideTree()`；[`NationalSpire.CareerScreen.DateDiaryEntryDialog(NationalSpire.CareerData, string, string)`](DateDiaryScreen.cs.md#symbol-fb4ba1a3b5fa)；[`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`](CareerStore.cs.md#symbol-ead7461ee7cb)；`System.Action.Invoke()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.DateDiaryEntryDialog(NationalSpire.CareerData, string, string)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._cancelDialog`；`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；`NationalSpire.DateDiary.OfferId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.IsInsideTree()`；输入表达式：`IsInsideTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInsideTree()`
- `NationalSpire.CareerScreen.DateDiaryEntryDialog(NationalSpire.CareerData, string, string)`；输入表达式：`DateDiaryEntryDialog(ViewData, person, diary.OfferId)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateDiaryEntryDialog(ViewData, person, diary.OfferId);`
- `NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；输入表达式：`CareerStore.IsCurrent(data)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CareerStore.IsCurrent(data)`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _cancelDialog?.Invoke()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d4d8f582fe1c"></a>

## `Removed() — void Removed()`

来源：源码第 94 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DeleteDateDiaryDialog(NationalSpire.CareerData, string, NationalSpire.DateDiary, NationalSpire.DateSceneMemory?)`](DateDiaryScreen.cs.md#symbol-d6865c262849)

**调用：** [`Back()`](DateDiaryScreen.cs.md#symbol-178613c1e28c)；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；[`NationalSpire.DateSceneMemories.Delete(NationalSpire.CareerData, string)`](DateSceneMemories.cs.md#symbol-a32b756f581f)

**字段、属性、事件及方法组引用：** `Back()`；`NationalSpire.CareerScreen._dateMemory`；`NationalSpire.DateDiary.OfferId`；`NationalSpire.DateMemoryRecorder.Memory`；`NationalSpire.DateSceneMemories.Delete(NationalSpire.CareerData, string)`；`NationalSpire.DateSceneMemory.OfferId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Back()`；输入表达式：`Back()`；返回值紧邻使用处：`ExpressionStatementSyntax: Back();`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(error)`；返回值紧邻使用处：`IfStatementSyntax: if (IsInstanceValid(error)) error.Text = "日记已删除，回忆文件清理失败：" + e.Message;`
- `NationalSpire.DateSceneMemories.Delete(NationalSpire.CareerData, string)`；输入表达式：`DateSceneMemories.Delete(data, diary.OfferId)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateSceneMemories.Delete(data, diary.OfferId);`

**赋值（含属性/字段和局部值）：**

- `_dateMemory` = `null`
- `error.Text` = `"日记已删除，回忆文件清理失败：" + e.Message`

<a id="symbol-69d095616782"></a>

## `NationalSpire.DateMemoryEraser._Ready() — public override void _Ready()`

来源：源码第 109 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8c8030eb0292"></a>

## `NationalSpire.DateMemoryEraser._Draw() — public override void _Draw()`

来源：源码第 110 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawPolyline(Godot.Vector2[], Godot.Color, float, bool)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Ink`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(c + new Vector2(-6, -3), c + new Vector2(4, 7), ink, 1.8f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(c + new Vector2(-6, -3), c + new Vector2(4, 7), ink, 1.8f, true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(c + new Vector2(1, 10), c + new Vector2(13, 10), ink, 1.8f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(c + new Vector2(1, 10), c + new Vector2(13, 10), ink, 1.8f, true);`
- `Godot.CanvasItem.DrawPolyline(Godot.Vector2[], Godot.Color, float, bool)`；输入表达式：`DrawPolyline(p, ink, 1.8f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline(p, ink, 1.8f, true);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-12, 3)`；返回值紧邻使用处：`BinaryExpressionSyntax: c + new Vector2(-12, 3)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-5, 10)`；返回值紧邻使用处：`BinaryExpressionSyntax: c + new Vector2(-5, 10)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-6, -3)`；返回值紧邻使用处：`BinaryExpressionSyntax: c + new Vector2(-6, -3)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(1, 10)`；返回值紧邻使用处：`BinaryExpressionSyntax: c + new Vector2(1, 10)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(12, -1)`；返回值紧邻使用处：`BinaryExpressionSyntax: c + new Vector2(12, -1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(13, 10)`；返回值紧邻使用处：`BinaryExpressionSyntax: c + new Vector2(13, 10)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(2, -11)`；返回值紧邻使用处：`BinaryExpressionSyntax: c + new Vector2(2, -11)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(4, 7)`；返回值紧邻使用处：`BinaryExpressionSyntax: c + new Vector2(4, 7)`

**赋值（含属性/字段和局部值）：**
