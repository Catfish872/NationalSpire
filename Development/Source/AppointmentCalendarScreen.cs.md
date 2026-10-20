# AppointmentCalendarScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`9712121B6E3CF5783E2B4E5F12AF8B8AEDC984C7490C51C2C13E3BEC34B980EC`。来源：[源码](../../AppointmentCalendarScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-b5cb4cb371f4"></a>

## `NationalSpire.CareerScreen.AppointmentCalendar(NationalSpire.CareerData, int, System.Collections.Generic.IEnumerable<string>, int, System.Action<int>) — private Control AppointmentCalendar(CareerData data, int season, IEnumerable<string> participants, int selected, Action<int> choose)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Calendar()`](ChatAttachmentScreen.cs.md#symbol-e5434801f66f)；[`Calendar()`](PrivateMessageScreen.cs.md#symbol-ad3ab9c35314)

**调用：** [`NationalSpire.CalendarDayButton.SelectDate(bool)`](CalendarDayButton.cs.md#symbol-c7e15f459308)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-8a08be365f83)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；[`NationalSpire.PrivateAppointments.Schedule(NationalSpire.CareerData, string, int)`](PrivateAppointments.cs.md#symbol-8d91a4d33a55)；[`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-12bdfe5d4265)；[`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-ee7b01d76b23)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.ToSignal(Godot.GodotObject, Godot.StringName)`；`Godot.GridContainer.GridContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChildren(bool)`；`Godot.Node.GetParent()`；`Godot.Node.GetTree()`；`Godot.Node.IsInsideTree()`；`Godot.ScrollContainer.EnsureControlVisible(Godot.Control)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.CalendarDayButton.CalendarDayButton()`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.IEnumerable.OfType<TResult>()`；`System.DateOnly.ToString(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CalendarDayButton.Description`；`NationalSpire.CalendarDayButton.Number`；`NationalSpire.CalendarDayButton.Registered`；`NationalSpire.CalendarDayButton.SelectDate(bool)`；`NationalSpire.CalendarDayButton.Selected`；`NationalSpire.CalendarDayButton.Today`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.PrivateAppointments.Schedule(NationalSpire.CareerData, string, int)`；`NationalSpire.PrivateAppointments.ScheduleEntry.Description`；`NationalSpire.PrivateAppointments.ScheduleEntry.Occupied`；`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`details.AddThemeConstantOverride("separation", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: details.AddThemeConstantOverride("separation", 8);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("h_separation", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("h_separation", 8);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("v_separation", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("v_separation", 8);`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(box)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(box) && box.IsInsideTree()`
- `Godot.GodotObject.ToSignal(Godot.GodotObject, Godot.StringName)`；输入表达式：`ToSignal(GetTree(), SceneTree.SignalName.ProcessFrame)`；返回值紧邻使用处：`AwaitExpressionSyntax: await ToSignal(GetTree(), SceneTree.SignalName.ProcessFrame)`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer { Columns = 7 }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GridContainer { Columns = 7 }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(details)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(details);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(grid)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(grid);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`details.AddChild(Text($"{GameCalendar.Text(data, absolute)} · {description}", 14, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: details.AddChild(Text($"{GameCalendar.Text(data, absolute)} · {description}", 14, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`grid.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddChild(button);`
- `Godot.Node.GetChildren(bool)`；输入表达式：`grid.GetChildren()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: grid.GetChildren().OfType<CalendarDayButton>`
- `Godot.Node.GetParent()`；输入表达式：`.GetParent()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: box.GetParent()?.GetParent()`
- `Godot.Node.GetParent()`；输入表达式：`box.GetParent()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: box.GetParent()?.GetParent()`
- `Godot.Node.GetTree()`；输入表达式：`GetTree()`；返回值紧邻使用处：`ArgumentSyntax: GetTree()`
- `Godot.Node.IsInsideTree()`；输入表达式：`box.IsInsideTree()`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(box) && box.IsInsideTree()`
- `Godot.ScrollContainer.EnsureControlVisible(Godot.Control)`；输入表达式：`.EnsureControlVisible(initial)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: (box.GetParent()?.GetParent() as ScrollContainer)?.EnsureControlVisible(initial)`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { Name = "AppointmentCalendar", SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { Name = "AppointmentCalendar", SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(96, 88)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(96, 88)`
- `NationalSpire.CalendarDayButton.CalendarDayButton()`；输入表达式：`new CalendarDayButton              {                  Name = "Day" + date, Number = GameCalendar.Date(data, absolute).ToString("M/d"),                  Description = entries.Any(e => e.Occupied) ? "有安排" : entries.Length > 0 ? "可报名" : "空闲",                  Today = absolute == data.Day, Selected = date == selected, Registered = entries.Any(e => e.Occupied),                  Disabled = absolute < data.Day, TooltipText = description, CustomMinimumSize = new(96, 88)              }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CalendarDayButton              {                  Name = "Day" + date, Number = GameCalendar.Date(data, absolute).ToString("M/d"),                  Description = entries.Any(e => e.Occupied) ? "有安排" : entries.Length > 0 ? "可报名" : "空闲",                  Today = absolute == data.Day, Selected = date == selected, Registered = entries.Any(e => e.Occupied),                  Disabled = absolute < data.Day, TooltipText = description, CustomMinimumSize = new(96, 88)              }`
- `NationalSpire.CalendarDayButton.SelectDate(bool)`；输入表达式：`child.SelectDate(child == button)`；返回值紧邻使用处：`ExpressionStatementSyntax: child.SelectDate(child == button);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"{GameCalendar.Text(data, absolute)} · {description}", 14, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"{GameCalendar.Text(data, absolute)} · {description}", 14, _muted)`
- `NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Date(data, absolute)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GameCalendar.Date(data, absolute).ToString`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(data, absolute)`；返回值紧邻使用处：`InterpolationSyntax: {GameCalendar.Text(data, absolute)}`
- `NationalSpire.PrivateAppointments.Schedule(NationalSpire.CareerData, string, int)`；输入表达式：`PrivateAppointments.Schedule(data, person, absolute)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: person => PrivateAppointments.Schedule(data, person, absolute)`
- `NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Length(data, season)`；返回值紧邻使用处：`BinaryExpressionSyntax: n <= SeasonCalendar.Length(data, season)`
- `NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Start(data, season)`；返回值紧邻使用处：`BinaryExpressionSyntax: SeasonCalendar.Start(data, season) + date`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n", entries.Select(e => e.Description).Distinct())`；返回值紧邻使用处：`EqualsValueClauseSyntax: = string.Join("\n", entries.Select(e => e.Description).Distinct())`
- `System.Action<T>.Invoke(T)`；输入表达式：`choose(date)`；返回值紧邻使用处：`ExpressionStatementSyntax: choose(date);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`entries.Any(e => e.Occupied)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Registered = entries.Any(e => e.Occupied)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`entries.Any(e => e.Occupied)`；返回值紧邻使用处：`ConditionalExpressionSyntax: entries.Any(e => e.Occupied) ? "有安排" : entries.Length > 0 ? "可报名" : "空闲"`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`entries.Select(e => e.Description).Distinct()`；返回值紧邻使用处：`ArgumentSyntax: entries.Select(e => e.Description).Distinct()`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`participants.Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: participants.Distinct().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`people.SelectMany(person => PrivateAppointments.Schedule(data, person, absolute)).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: people.SelectMany(person => PrivateAppointments.Schedule(data, person, absolute)).Distinct().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`entries.Select(e => e.Description)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: entries.Select(e => e.Description).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`people.SelectMany(person => PrivateAppointments.Schedule(data, person, absolute))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: people.SelectMany(person => PrivateAppointments.Schedule(data, person, absolute)).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`participants.Distinct().ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = participants.Distinct().ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`people.SelectMany(person => PrivateAppointments.Schedule(data, person, absolute)).Distinct().ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = people.SelectMany(person => PrivateAppointments.Schedule(data, person, absolute)).Distinct().ToArray()`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`grid.GetChildren().OfType<CalendarDayButton>()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var child in grid.GetChildren().OfType<CalendarDayButton>()) child.SelectDate(child == button);`
- `System.DateOnly.ToString(string?)`；输入表达式：`GameCalendar.Date(data, absolute).ToString("M/d")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Number = GameCalendar.Date(data, absolute).ToString("M/d")`

**赋值（含属性/字段和局部值）：**

- `box.Ready` += `async () =>          {              await ToSignal(GetTree(), SceneTree.SignalName.ProcessFrame);              await ToSignal(GetTree(), SceneTree.SignalName.ProcessFrame);              if (IsInstanceValid(box) && box.IsInsideTree() && initial != null)                  (box.GetParent()?.GetParent() as ScrollContainer)?.EnsureControlVisible(initial);          }`
- `button.Pressed` += `() =>              {                  choose(date);                  foreach (var child in grid.GetChildren().OfType<CalendarDayButton>()) child.SelectDate(child == button);              }`
- `Columns` = `7`
- `CustomMinimumSize` = `new(96, 88)`
- `Description` = `entries.Any(e => e.Occupied) ? "有安排" : entries.Length > 0 ? "可报名" : "空闲"`
- `Disabled` = `absolute < data.Day`
- `initial` = `button`
- `Name` = `"AppointmentCalendar"`
- `Name` = `"Day" + date`
- `Number` = `GameCalendar.Date(data, absolute).ToString("M/d")`
- `Registered` = `entries.Any(e => e.Occupied)`
- `Selected` = `date == selected`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Today` = `absolute == data.Day`
- `TooltipText` = `description`
