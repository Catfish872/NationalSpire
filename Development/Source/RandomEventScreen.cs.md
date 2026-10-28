# RandomEventScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`7B02B3286AF34BE0B4BF8AFF76418EB93BEFDA25E66C2A000D304B70987D4162`。来源：[源码](../../RandomEventScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`、`NationalSpire.EventStoryView`、`NationalSpire.EventStoryButton`。

字段、事件及初始值（源码原样）：

```csharp
private EventStoryView? _eventView;
private string _eventId = "", _eventSignature = "";
public Action? Close, Start, Stop, Skip, Tick, ContinueJourney, Settings;
public Action<int>? Choose;
public Action<RichTextLabel, string>? Paint;
public Action<Variant>? OpenPerson;
private Label _title = null!, _date = null!, _chapter = null!, _artTitle = null!, _phase = null!;
private RichTextLabel _story = null!, _result = null!, _people = null!, _thought = null!, _decision = null!;
private VBoxContainer _effects = null!;
private Button _continue = null!, _stay = null!;
private VBoxContainer _options = null!, _resultBox = null!, _reading = null!;
private HBoxContainer _columns = null!;
private Control _artSpace = null!;
private PanelContainer _paper = null!;
private ScrollContainer _scroll = null!, _thinkingScroll = null!;
private EventStoryButton _start = null!;
private Button _skip = null!, _retry = null!, _stop = null!, _history = null!, _thinking = null!;
private TextureRect _image = null!;
private ShaderMaterial _imageMaterial = null!;
private Texture2D? _ownedImage;
private string _artId = "\0", _storyText = "", _resultText = "", _choiceSignature = "", _lastState = "";
private double _poll;
private bool _showHistory;
private static readonly Color Ink = new("e4e8e8"), Muted = new("a8bdc8"), Gold = new("e7ca91");
private StyleBoxFlat _normal = null!, _hover = null!, _disabled = null!;
private string _caption = "";
private RichTextLabel? _captionLabel;
```

<a id="symbol-e27dca18c72a"></a>

## `NationalSpire.CareerScreen.EventCards(NationalSpire.CareerData, Godot.VBoxContainer, int) — private void EventCards(CareerData d, VBoxContainer parent, int day)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)

**调用：** [`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.EventCommand(string, int, bool, string?, string?)`](RandomEventScreen.cs.md#symbol-07fb309a31aa)；[`NationalSpire.CareerScreen.OpenRandomEvent(string)`](RandomEventScreen.cs.md#symbol-b6a9dfbe8e4f)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.EventStoryButton.EventStoryButton()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.RandomEvents`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.EventCommand(string, int, bool, string?, string?)`；`NationalSpire.CareerScreen.OpenRandomEvent(string)`；`NationalSpire.EventStoryButton.Caption`；`NationalSpire.EventStoryButton.Detail`；`NationalSpire.EventStoryButton.Mark`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.RandomEventRecord.Day`；`NationalSpire.RandomEventRecord.Id`；`NationalSpire.RandomEventRecord.State`；`NationalSpire.RandomEventRecord.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 12);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(button);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(skip)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(skip);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 92)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 92)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("跳过事件", () => EventCommand("event-skip", id: e.Id), 116)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("跳过事件", () => EventCommand("event-skip", id: e.Id), 116)`
- `NationalSpire.CareerScreen.EventCommand(string, int, bool, string?, string?)`；输入表达式：`EventCommand("event-skip", id: e.Id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => EventCommand("event-skip", id: e.Id)`
- `NationalSpire.CareerScreen.OpenRandomEvent(string)`；输入表达式：`OpenRandomEvent(e.Id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenRandomEvent(e.Id)`
- `NationalSpire.EventStoryButton.EventStoryButton()`；输入表达式：`new EventStoryButton { Name = "QuestionEvent_" + e.Id, Caption = e.State == "complete" ? e.Title : "今日际遇", Detail = e.State == "complete" ? "查看你的选择与这段经历" : day > d.Day ? GameCalendar.Text(d, day) + " · 随机事件" : "生活中的另一种可能", Mark = "?", CustomMinimumSize = new(0, 92), SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new EventStoryButton { Name = "QuestionEvent_" + e.Id, Caption = e.State == "complete" ? e.Title : "今日际遇", Detail = e.State == "complete" ? "查看你的选择与这段经历" : day > d.Day ? GameCalendar.Text(d, day) + " · 随机事件" : "生活中的另一种可能", Mark = "?", CustomMinimumSize = new(0, 92), SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(d, day)`；返回值紧邻使用处：`BinaryExpressionSyntax: GameCalendar.Text(d, day) + " · 随机事件"`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.RandomEvents.Where(e => e.Day == day && e.State != "skipped")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var e in d.Life.RandomEvents.Where(e => e.Day == day && e.State != "skipped"))          {              var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); parent.AddChild(row);              var button = new EventStoryButton { Name = "QuestionEvent_" + e.Id, Caption = e.State == "complete" ? e.Title : "今日际遇", Detail = e.State == "complete" ? "查看你的选择与这段经历" : day > d.Day ? GameCalendar.Text(d, day) + " · 随机事件" : "生活中的另一种可能", Mark = "?", CustomMinimumSize = new(0, 92), SizeFlagsHorizontal = SizeFlags.ExpandFill };              button.Disabled = day != d.Day && e.State != "complete";              button.Pressed += () => OpenRandomEvent(e.Id); row.AddChild(button);              if (e.State != "complete")              {                  var skip = Button("跳过事件", () => EventCommand("event-skip", id: e.Id), 116);                  skip.Name = "SkipCalendarEvent_" + e.Id; skip.SizeFlagsVertical = SizeFlags.ShrinkCenter; row.AddChild(skip);              }          }`

**赋值（含属性/字段和局部值）：**

- `button.Disabled` = `day != d.Day && e.State != "complete"`
- `button.Pressed` += `() => OpenRandomEvent(e.Id)`
- `Caption` = `e.State == "complete" ? e.Title : "今日际遇"`
- `CustomMinimumSize` = `new(0, 92)`
- `Detail` = `e.State == "complete" ? "查看你的选择与这段经历" : day > d.Day ? GameCalendar.Text(d, day) + " · 随机事件" : "生活中的另一种可能"`
- `Mark` = `"?"`
- `Name` = `"QuestionEvent_" + e.Id`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `skip.Name` = `"SkipCalendarEvent_" + e.Id`
- `skip.SizeFlagsVertical` = `SizeFlags.ShrinkCenter`

<a id="symbol-b6a9dfbe8e4f"></a>

## `NationalSpire.CareerScreen.OpenRandomEvent(string) — private void OpenRandomEvent(string id)`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Back()`](CareerNavigation.cs.md#symbol-08af62207fef)；[`NationalSpire.CareerScreen.EventCards(NationalSpire.CareerData, Godot.VBoxContainer, int)`](RandomEventScreen.cs.md#symbol-e27dca18c72a)；[`NationalSpire.CareerScreen.ShowJourneyEncounter()`](EventJourneyScreen.cs.md#symbol-4e94d6a77974)

**调用：** [`NationalSpire.CareerScreen.EventCommand(string, int, bool, string?, string?)`](RandomEventScreen.cs.md#symbol-07fb309a31aa)；[`NationalSpire.CareerScreen.LoadChatPreferences()`](ChatHistoryScreen.cs.md#symbol-d1d5bc5023c7)；[`NationalSpire.CareerScreen.PaintMentionText(Godot.RichTextLabel, NationalSpire.CareerData, string, System.Collections.Generic.IEnumerable<string>?, bool)`](MentionScreen.cs.md#symbol-97692853b81c)；[`NationalSpire.CareerScreen.RefreshRandomEvent()`](RandomEventScreen.cs.md#symbol-54853f1d507f)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.WriteChatPreferences()`](ChatHistoryScreen.cs.md#symbol-15e26075b1d4)；[`NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`](RandomEvents.cs.md#symbol-20d7a260dcab)；`Godot.BaseButton.SetPressedNoSignal(bool)`；`Godot.CanvasItem.Show()`；`Godot.ConfigFile.GetValue(string, string, Godot.Variant)`；`Godot.ConfigFile.SetValue(string, string, Godot.Variant)`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.QueueFree()`；`Godot.Variant.AsBool()`；`NationalSpire.EventStoryView.EventStoryView()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._eventId`；`NationalSpire.CareerScreen._eventSignature`；`NationalSpire.CareerScreen._eventView`；`NationalSpire.CareerScreen._stage`；`NationalSpire.CareerScreen.ChatPreferenceKey`；`NationalSpire.CareerScreen.ChatPreferences`；`NationalSpire.CareerScreen.ContinueEventJourney()`；`NationalSpire.CareerScreen.EventCommand(string, int, bool, string?, string?)`；`NationalSpire.CareerScreen.LoadChatPreferences()`；`NationalSpire.CareerScreen.OpenMention(Godot.Variant)`；`NationalSpire.CareerScreen.PaintMentionText(Godot.RichTextLabel, NationalSpire.CareerData, string, System.Collections.Generic.IEnumerable<string>?, bool)`；`NationalSpire.CareerScreen.RandomEventSettings()`；`NationalSpire.CareerScreen.RefreshRandomEvent()`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen.WriteChatPreferences()`；`NationalSpire.EventStoryView.Choose`；`NationalSpire.EventStoryView.Close`；`NationalSpire.EventStoryView.ConfirmCustom`；`NationalSpire.EventStoryView.ContinueJourney`；`NationalSpire.EventStoryView.Custom`；`NationalSpire.EventStoryView.OpenPerson`；`NationalSpire.EventStoryView.Paint`；`NationalSpire.EventStoryView.Public`；`NationalSpire.EventStoryView.Settings`；`NationalSpire.EventStoryView.Skip`；`NationalSpire.EventStoryView.Start`；`NationalSpire.EventStoryView.Stop`；`NationalSpire.EventStoryView.Tick`；`NationalSpire.RandomEventRecord.People`；`NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`view.Public.SetPressedNoSignal(ChatPreferences.GetValue(ChatPreferenceKey, "event-public", false).AsBool())`；返回值紧邻使用处：`ExpressionStatementSyntax: view.Public.SetPressedNoSignal(ChatPreferences.GetValue(ChatPreferenceKey, "event-public", false).AsBool());`
- `Godot.CanvasItem.Show()`；输入表达式：`_eventView.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: _eventView.Show();`
- `Godot.ConfigFile.GetValue(string, string, Godot.Variant)`；输入表达式：`ChatPreferences.GetValue(ChatPreferenceKey, "event-public", false)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ChatPreferences.GetValue(ChatPreferenceKey, "event-public", false).AsBool`
- `Godot.ConfigFile.SetValue(string, string, Godot.Variant)`；输入表达式：`ChatPreferences.SetValue(ChatPreferenceKey, "event-public", value)`；返回值紧邻使用处：`ExpressionStatementSyntax: ChatPreferences.SetValue(ChatPreferenceKey, "event-public", value);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`view.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: view.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_stage.AddChild(view)`；返回值紧邻使用处：`ExpressionStatementSyntax: _stage.AddChild(view);`
- `Godot.Node.QueueFree()`；输入表达式：`_eventView.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: _eventView.QueueFree();`
- `Godot.Node.QueueFree()`；输入表达式：`view.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: view.QueueFree();`
- `Godot.Variant.AsBool()`；输入表达式：`ChatPreferences.GetValue(ChatPreferenceKey, "event-public", false).AsBool()`；返回值紧邻使用处：`ArgumentSyntax: ChatPreferences.GetValue(ChatPreferenceKey, "event-public", false).AsBool()`
- `NationalSpire.CareerScreen.EventCommand(string, int, bool, string?, string?)`；输入表达式：`EventCommand("event-choose", index, view.Public.ButtonPressed)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: index => EventCommand("event-choose", index, view.Public.ButtonPressed)`
- `NationalSpire.CareerScreen.EventCommand(string, int, bool, string?, string?)`；输入表达式：`EventCommand("event-custom-choose", publicly: view.Public.ButtonPressed)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => EventCommand("event-custom-choose", publicly: view.Public.ButtonPressed)`
- `NationalSpire.CareerScreen.EventCommand(string, int, bool, string?, string?)`；输入表达式：`EventCommand("event-custom", action: action)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: action => EventCommand("event-custom", action: action)`
- `NationalSpire.CareerScreen.EventCommand(string, int, bool, string?, string?)`；输入表达式：`EventCommand("event-skip")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => EventCommand("event-skip")`
- `NationalSpire.CareerScreen.EventCommand(string, int, bool, string?, string?)`；输入表达式：`EventCommand("event-start")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => EventCommand("event-start")`
- `NationalSpire.CareerScreen.EventCommand(string, int, bool, string?, string?)`；输入表达式：`EventCommand("event-stop")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => EventCommand("event-stop")`
- `NationalSpire.CareerScreen.LoadChatPreferences()`；输入表达式：`LoadChatPreferences()`；返回值紧邻使用处：`ExpressionStatementSyntax: LoadChatPreferences();`
- `NationalSpire.CareerScreen.PaintMentionText(Godot.RichTextLabel, NationalSpire.CareerData, string, System.Collections.Generic.IEnumerable<string>?, bool)`；输入表达式：`PaintMentionText(label, ViewData, value, RandomEvents.Find(ViewData, id)?.People, true)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: (label, value) => PaintMentionText(label, ViewData, value, RandomEvents.Find(ViewData, id)?.People, true)`
- `NationalSpire.CareerScreen.RefreshRandomEvent()`；输入表达式：`RefreshRandomEvent()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshRandomEvent();`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.WriteChatPreferences()`；输入表达式：`WriteChatPreferences()`；返回值紧邻使用处：`ExpressionStatementSyntax: WriteChatPreferences();`
- `NationalSpire.EventStoryView.EventStoryView()`；输入表达式：`new EventStoryView()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new EventStoryView()`
- `NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`；输入表达式：`RandomEvents.Find(ViewData, id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: RandomEvents.Find(ViewData, id)?.People`

**赋值（含属性/字段和局部值）：**

- `_eventId` = `id`
- `_eventSignature` = `""`
- `_eventView` = `null`
- `_eventView` = `view`
- `view.Choose` = `index => EventCommand("event-choose", index, view.Public.ButtonPressed)`
- `view.Close` = `() => { view.QueueFree(); _eventView = null; Render(); }`
- `view.ConfirmCustom` = `() => EventCommand("event-custom-choose", publicly: view.Public.ButtonPressed)`
- `view.ContinueJourney` = `ContinueEventJourney`
- `view.Custom` = `action => EventCommand("event-custom", action: action)`
- `view.OpenPerson` = `OpenMention`
- `view.Paint` = `(label, value) => PaintMentionText(label, ViewData, value, RandomEvents.Find(ViewData, id)?.People, true)`
- `view.Public.Toggled` += `value => { ChatPreferences.SetValue(ChatPreferenceKey, "event-public", value); WriteChatPreferences(); }`
- `view.Settings` = `RandomEventSettings`
- `view.Skip` = `() => EventCommand("event-skip")`
- `view.Start` = `() => EventCommand("event-start")`
- `view.Stop` = `() => EventCommand("event-stop")`
- `view.Tick` = `RefreshRandomEvent`

<a id="symbol-6c1195d3802b"></a>

## `NationalSpire.CareerScreen.RandomEventSettings() — private void RandomEventSettings()`

来源：源码第 47 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`Field(string, int, string)`](RandomEventScreen.cs.md#symbol-79b22c396ed3)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.RefreshRandomEvent()`](RandomEventScreen.cs.md#symbol-54853f1d507f)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.RandomEvents.SetFrequency(NationalSpire.CareerData, bool, int, int)`](RandomEvents.cs.md#symbol-8716e3f7b803)；`Godot.CheckButton.CheckButton()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.SpinBox.Apply()`；`Godot.Vector2.Vector2(float, float)`；`int.ToString(System.IFormatProvider?)`

**字段、属性、事件及方法组引用：** `Field(string, int, string)`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.RandomEventMaxDays`；`NationalSpire.CareerLifeState.RandomEventMinDays`；`NationalSpire.CareerLifeState.RandomEventsEnabled`；`NationalSpire.CareerScreen._eventSignature`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.RefreshRandomEvent()`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.RandomEvents.SetFrequency(NationalSpire.CareerData, bool, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Field(string, int, string)`；输入表达式：`Field("最大间隔", current.RandomEventMaxDays, "RandomEventMaximum")`；返回值紧邻使用处：`AssignmentExpressionSyntax: maximum = Field("最大间隔", current.RandomEventMaxDays, "RandomEventMaximum")`
- `Field(string, int, string)`；输入表达式：`Field("最小间隔", current.RandomEventMinDays, "RandomEventMinimum")`；返回值紧邻使用处：`AssignmentExpressionSyntax: minimum = Field("最小间隔", current.RandomEventMinDays, "RandomEventMinimum")`
- `Godot.CheckButton.CheckButton()`；输入表达式：`new CheckButton { Name = "RandomEventsEnabled", Text = "启用随机事件", ButtonPressed = current.RandomEventsEnabled, CustomMinimumSize = new(0, 44) }`；返回值紧邻使用处：`AssignmentExpressionSyntax: enabled = new CheckButton { Name = "RandomEventsEnabled", Text = "启用随机事件", ButtonPressed = current.RandomEventsEnabled, CustomMinimumSize = new(0, 44) }`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 18);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(enabled)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(enabled);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text("保存后重新安排未来尚未展开的事件。当天事件和已经生成的故事继续保留。", 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text("保存后重新安排未来尚未展开的事件。当天事件和已经生成的故事继续保留。", 16, _muted));`
- `Godot.SpinBox.Apply()`；输入表达式：`maximum!.Apply()`；返回值紧邻使用处：`ExpressionStatementSyntax: maximum!.Apply();`
- `Godot.SpinBox.Apply()`；输入表达式：`minimum!.Apply()`；返回值紧邻使用处：`ExpressionStatementSyntax: minimum!.Apply();`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 44)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 44)`
- `int.ToString(System.IFormatProvider?)`；输入表达式：`max.ToString(System.Globalization.CultureInfo.InvariantCulture)`；返回值紧邻使用处：`ArgumentSyntax: max.ToString(System.Globalization.CultureInfo.InvariantCulture)`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("event-settings", on ? "enabled" : "disabled", max.ToString(System.Globalization.CultureInfo.InvariantCulture), min,                  accepted: () => { _eventSignature = ""; RefreshRandomEvent(); })`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !MultiplayerCommand("event-settings", on ? "enabled" : "disabled", max.ToString(System.Globalization.CultureInfo.InvariantCulture), min,                  accepted: () => { _eventSignature = ""; RefreshRandomEvent(); })`
- `NationalSpire.CareerScreen.RefreshRandomEvent()`；输入表达式：`RefreshRandomEvent()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshRandomEvent();`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("随机事件设置", "在设定的天数范围内随机安排下一次际遇。", () =>          {              minimum!.Apply(); maximum!.Apply();              int min = (int)minimum.Value, max = (int)maximum.Value;              bool on = enabled!.ButtonPressed;              if (!MultiplayerCommand("event-settings", on ? "enabled" : "disabled", max.ToString(System.Globalization.CultureInfo.InvariantCulture), min,                  accepted: () => { _eventSignature = ""; RefreshRandomEvent(); }))              {                  RandomEvents.SetFrequency(ViewData, on, min, max); CareerStore.Save(ViewData);                  _eventSignature = ""; RefreshRandomEvent();              }              return true;          }, "保存设置", box =>          {              enabled = new CheckButton { Name = "RandomEventsEnabled", Text = "启用随机事件", ButtonPressed = current.RandomEventsEnabled, CustomMinimumSize = new(0, 44) }; box.AddChild(enabled);              var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 18); box.AddChild(row);              SpinBox Field(string caption, int value, string name)              {                  var panel = new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill };                  panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("142936", "466371", 8, 18)); row.AddChild(panel);                  var fields = new VBoxContainer(); fields.AddThemeConstantOverride("separation", 12); panel.AddChild(fields);                  fields.AddChild(Text(caption, 17, _muted));                  var input = new SpinBox { Name = name, MinValue = 1, MaxValue = int.MaxValue, Step = 1, Value = value,                      Suffix = "天", UpdateOnTextChanged = true, Editable = current.RandomEventsEnabled, CustomMinimumSize = new(220, 48), SizeFlagsHorizontal = SizeFlags.ExpandFill };                  fields.AddChild(input); return input;              }              minimum = Field("最小间隔", current.RandomEventMinDays, "RandomEventMinimum");              maximum = Field("最大间隔", current.RandomEventMaxDays, "RandomEventMaximum");              maximum.MinValue = minimum.Value;              minimum.ValueChanged += value => maximum.MinValue = value;              enabled.Toggled += value => { minimum.Editable = value; maximum.Editable = value; };              box.AddChild(Text("保存后重新安排未来尚未展开的事件。当天事件和已经生成的故事继续保留。", 16, _muted));          })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("随机事件设置", "在设定的天数范围内随机安排下一次际遇。", () =>          {              minimum!.Apply(); maximum!.Apply();              int min = (int)minimum.Value, max = (int)maximum.Value;              bool on = enabled!.ButtonPressed;              if (!MultiplayerCommand("event-settings", on ? "enabled" : "disabled", max.ToString(System.Globalization.CultureInfo.InvariantCulture), min,                  accepted: () => { _eventSignature = ""; RefreshRandomEvent(); }))              {                  RandomEvents.SetFrequency(ViewData, on, min, max); CareerStore.Save(ViewData);                  _eventSignature = ""; RefreshRandomEvent();              }              return true;          }, "保存设置", box =>          {              enabled = new CheckButton { Name = "RandomEventsEnabled", Text = "启用随机事件", ButtonPressed = current.RandomEventsEnabled, CustomMinimumSize = new(0, 44) }; box.AddChild(enabled);              var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 18); box.AddChild(row);              SpinBox Field(string caption, int value, string name)              {                  var panel = new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill };                  panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("142936", "466371", 8, 18)); row.AddChild(panel);                  var fields = new VBoxContainer(); fields.AddThemeConstantOverride("separation", 12); panel.AddChild(fields);                  fields.AddChild(Text(caption, 17, _muted));                  var input = new SpinBox { Name = name, MinValue = 1, MaxValue = int.MaxValue, Step = 1, Value = value,                      Suffix = "天", UpdateOnTextChanged = true, Editable = current.RandomEventsEnabled, CustomMinimumSize = new(220, 48), SizeFlagsHorizontal = SizeFlags.ExpandFill };                  fields.AddChild(input); return input;              }              minimum = Field("最小间隔", current.RandomEventMinDays, "RandomEventMinimum");              maximum = Field("最大间隔", current.RandomEventMaxDays, "RandomEventMaximum");              maximum.MinValue = minimum.Value;              minimum.ValueChanged += value => maximum.MinValue = value;              enabled.Toggled += value => { minimum.Editable = value; maximum.Editable = value; };              box.AddChild(Text("保存后重新安排未来尚未展开的事件。当天事件和已经生成的故事继续保留。", 16, _muted));          });`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("保存后重新安排未来尚未展开的事件。当天事件和已经生成的故事继续保留。", 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("保存后重新安排未来尚未展开的事件。当天事件和已经生成的故事继续保留。", 16, _muted)`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(ViewData)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(ViewData);`
- `NationalSpire.RandomEvents.SetFrequency(NationalSpire.CareerData, bool, int, int)`；输入表达式：`RandomEvents.SetFrequency(ViewData, on, min, max)`；返回值紧邻使用处：`ExpressionStatementSyntax: RandomEvents.SetFrequency(ViewData, on, min, max);`

**赋值（含属性/字段和局部值）：**

- `_eventSignature` = `""`
- `ButtonPressed` = `current.RandomEventsEnabled`
- `CustomMinimumSize` = `new(0, 44)`
- `enabled.Toggled` += `value => { minimum.Editable = value; maximum.Editable = value; }`
- `enabled` = `new CheckButton { Name = "RandomEventsEnabled", Text = "启用随机事件", ButtonPressed = current.RandomEventsEnabled, CustomMinimumSize = new(0, 44) }`
- `maximum.Editable` = `value`
- `maximum.MinValue` = `minimum.Value`
- `maximum.MinValue` = `value`
- `maximum` = `Field("最大间隔", current.RandomEventMaxDays, "RandomEventMaximum")`
- `minimum.Editable` = `value`
- `minimum.ValueChanged` += `value => maximum.MinValue = value`
- `minimum` = `Field("最小间隔", current.RandomEventMinDays, "RandomEventMinimum")`
- `Name` = `"RandomEventsEnabled"`
- `Text` = `"启用随机事件"`

<a id="symbol-79b22c396ed3"></a>

## `Field(string, int, string) — SpinBox Field(string caption, int value, string name)`

来源：源码第 67 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RandomEventSettings()`](RandomEventScreen.cs.md#symbol-6c1195d3802b)

**调用：** [`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.SpinBox.SpinBox()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerLifeState.RandomEventsEnabled`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`fields.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: fields.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("142936", "466371", 8, 18))`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("142936", "466371", 8, 18));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`fields.AddChild(input)`；返回值紧邻使用处：`ExpressionStatementSyntax: fields.AddChild(input);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`fields.AddChild(Text(caption, 17, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: fields.AddChild(Text(caption, 17, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(fields)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(fields);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(panel);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.SpinBox.SpinBox()`；输入表达式：`new SpinBox { Name = name, MinValue = 1, MaxValue = int.MaxValue, Step = 1, Value = value,                      Suffix = "天", UpdateOnTextChanged = true, Editable = current.RandomEventsEnabled, CustomMinimumSize = new(220, 48), SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new SpinBox { Name = name, MinValue = 1, MaxValue = int.MaxValue, Step = 1, Value = value,                      Suffix = "天", UpdateOnTextChanged = true, Editable = current.RandomEventsEnabled, CustomMinimumSize = new(220, 48), SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(220, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(220, 48)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(caption, 17, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(caption, 17, _muted)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("142936", "466371", 8, 18)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("142936", "466371", 8, 18)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(220, 48)`
- `Editable` = `current.RandomEventsEnabled`
- `MaxValue` = `int.MaxValue`
- `MinValue` = `1`
- `Name` = `name`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Step` = `1`
- `Suffix` = `"天"`
- `UpdateOnTextChanged` = `true`
- `Value` = `value`

<a id="symbol-07fb309a31aa"></a>

## `NationalSpire.CareerScreen.EventCommand(string, int, bool, string?, string?) — private void EventCommand(string kind, int option = 0, bool publicly = false, string? id = null, string? action = null)`

来源：源码第 85 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.EventCards(NationalSpire.CareerData, Godot.VBoxContainer, int)`](RandomEventScreen.cs.md#symbol-e27dca18c72a)；[`NationalSpire.CareerScreen.OpenRandomEvent(string)`](RandomEventScreen.cs.md#symbol-b6a9dfbe8e4f)

**调用：** [`NationalSpire.AiService.ProcessEventAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<NationalSpire.EventLive>?)`](AiRandomEvents.cs.md#symbol-5705d03a72b3)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`](CareerStore.cs.md#symbol-ead7461ee7cb)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.RandomEvents.Choose(NationalSpire.CareerData, string, int, bool)`](RandomEvents.cs.md#symbol-c0266703d306)；[`NationalSpire.RandomEvents.ChooseCustom(NationalSpire.CareerData, string, bool)`](RandomEvents.cs.md#symbol-c949f4a092a3)；[`NationalSpire.RandomEvents.Custom(NationalSpire.CareerData, string, string)`](RandomEvents.cs.md#symbol-b7d9c2f158f5)；[`NationalSpire.RandomEvents.Skip(NationalSpire.CareerData, string)`](RandomEvents.cs.md#symbol-9b570a0265e9)；[`NationalSpire.RandomEvents.Start(NationalSpire.CareerData, string)`](RandomEvents.cs.md#symbol-605db3348248)；[`NationalSpire.RandomEvents.Stop(NationalSpire.CareerData, string)`](RandomEvents.cs.md#symbol-3b62c8ad1ca6)；[`Updated()`](RandomEventScreen.cs.md#symbol-e5d5d629b488)；`Godot.CanvasItem.Show()`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.ProcessEventAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<NationalSpire.EventLive>?)`；`NationalSpire.CareerScreen._eventId`；`NationalSpire.CareerScreen._eventView`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.EventStoryView.Status`；`NationalSpire.RandomEvents.Choose(NationalSpire.CareerData, string, int, bool)`；`NationalSpire.RandomEvents.ChooseCustom(NationalSpire.CareerData, string, bool)`；`NationalSpire.RandomEvents.Custom(NationalSpire.CareerData, string, string)`；`NationalSpire.RandomEvents.Skip(NationalSpire.CareerData, string)`；`NationalSpire.RandomEvents.Start(NationalSpire.CareerData, string)`；`NationalSpire.RandomEvents.Stop(NationalSpire.CareerData, string)`；`Updated()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Show()`；输入表达式：`_eventView.Status.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: _eventView.Status.Show();`
- `NationalSpire.AiService.ProcessEventAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<NationalSpire.EventLive>?)`；输入表达式：`AiService.ProcessEventAsync(() => CareerStore.IsCurrent(d) ? d : null, CareerStore.Save, target)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AiService.ProcessEventAsync(() => CareerStore.IsCurrent(d) ? d : null, CareerStore.Save, target)`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand(kind, target, action ?? (publicly ? "public" : "private"), option, accepted: Updated)`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand(kind, target, action ?? (publicly ? "public" : "private"), option, accepted: Updated)) return;`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("随机事件", error, () => true, "关闭", showCancel: false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("随机事件", error, () => true, "关闭", showCancel: false);`
- `NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；输入表达式：`CareerStore.IsCurrent(d)`；返回值紧邻使用处：`ConditionalExpressionSyntax: CareerStore.IsCurrent(d) ? d : null`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(d);`
- `NationalSpire.RandomEvents.Choose(NationalSpire.CareerData, string, int, bool)`；输入表达式：`RandomEvents.Choose(d, target, option, publicly)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "event-choose" => RandomEvents.Choose(d, target, option, publicly)`
- `NationalSpire.RandomEvents.ChooseCustom(NationalSpire.CareerData, string, bool)`；输入表达式：`RandomEvents.ChooseCustom(d, target, publicly)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "event-custom-choose" => RandomEvents.ChooseCustom(d, target, publicly)`
- `NationalSpire.RandomEvents.Custom(NationalSpire.CareerData, string, string)`；输入表达式：`RandomEvents.Custom(d, target, action ?? "")`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "event-custom" => RandomEvents.Custom(d, target, action ?? "")`
- `NationalSpire.RandomEvents.Skip(NationalSpire.CareerData, string)`；输入表达式：`RandomEvents.Skip(d, target)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "event-skip" => RandomEvents.Skip(d, target)`
- `NationalSpire.RandomEvents.Start(NationalSpire.CareerData, string)`；输入表达式：`RandomEvents.Start(d, target)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "event-start" => RandomEvents.Start(d, target)`
- `NationalSpire.RandomEvents.Stop(NationalSpire.CareerData, string)`；输入表达式：`RandomEvents.Stop(d, target)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "event-stop" => RandomEvents.Stop(d, target)`
- `Updated()`；输入表达式：`Updated()`；返回值紧邻使用处：`ExpressionStatementSyntax: Updated();`

**赋值（含属性/字段和局部值）：**

- `_` = `AiService.ProcessEventAsync(() => CareerStore.IsCurrent(d) ? d : null, CareerStore.Save, target)`
- `_eventView.Status.Text` = `error`

<a id="symbol-e5d5d629b488"></a>

## `Updated() — void Updated()`

来源：源码第 88 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.EventCommand(string, int, bool, string?, string?)`](RandomEventScreen.cs.md#symbol-07fb309a31aa)

**调用：** [`NationalSpire.CareerScreen.RefreshRandomEvent()`](RandomEventScreen.cs.md#symbol-54853f1d507f)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._eventView`；`NationalSpire.CareerScreen.RefreshRandomEvent()`；`NationalSpire.CareerScreen.Render()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.RefreshRandomEvent()`；输入表达式：`RefreshRandomEvent()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshRandomEvent();`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-54853f1d507f"></a>

## `NationalSpire.CareerScreen.RefreshRandomEvent() — private void RefreshRandomEvent()`

来源：源码第 100 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenRandomEvent(string)`](RandomEventScreen.cs.md#symbol-b6a9dfbe8e4f)；[`NationalSpire.CareerScreen.RandomEventSettings()`](RandomEventScreen.cs.md#symbol-6c1195d3802b)；[`Updated()`](RandomEventScreen.cs.md#symbol-e5d5d629b488)

**调用：** [`NationalSpire.AiService.EventBusy(NationalSpire.CareerData, string)`](AiRandomEvents.cs.md#symbol-a251022ff4b2)；[`NationalSpire.AiService.EventKey(NationalSpire.CareerData, string)`](AiRandomEvents.cs.md#symbol-fadf0b2a4925)；[`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`](LifeData.cs.md#symbol-de5af63fa4e7)；[`NationalSpire.EventStoryView.Display(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.EventLive?, bool)`](RandomEventScreen.cs.md#symbol-f847e9f29b0e)；[`NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`](RandomEvents.cs.md#symbol-20d7a260dcab)；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.EventBusy(NationalSpire.CareerData, string)`；`NationalSpire.AiService.EventKey(NationalSpire.CareerData, string)`；`NationalSpire.AiService.EventLive`；`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；`NationalSpire.CareerScreen._eventId`；`NationalSpire.CareerScreen._eventSignature`；`NationalSpire.CareerScreen._eventView`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.EventLive.Options`；`NationalSpire.EventLive.Phase`；`NationalSpire.EventLive.Reasoning`；`NationalSpire.EventLive.Story`；`NationalSpire.EventLive.Title`；`NationalSpire.EventStoryView.Close`；`NationalSpire.EventStoryView.CustomInputText`；`NationalSpire.EventStoryView.Display(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.EventLive?, bool)`；`NationalSpire.RandomEventOption.Result`；`NationalSpire.RandomEventRecord.CustomAction`；`NationalSpire.RandomEventRecord.CustomOption`；`NationalSpire.RandomEventRecord.CustomReasoning`；`NationalSpire.RandomEventRecord.CustomState`；`NationalSpire.RandomEventRecord.Error`；`NationalSpire.RandomEventRecord.Id`；`NationalSpire.RandomEventRecord.Options`；`NationalSpire.RandomEventRecord.Selected`；`NationalSpire.RandomEventRecord.State`；`NationalSpire.RandomEventRecord.Title`；`NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_eventView)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(_eventView)`
- `NationalSpire.AiService.EventBusy(NationalSpire.CareerData, string)`；输入表达式：`AiService.EventBusy(d, e.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: AiService.EventBusy(d, e.Id) || live != null`
- `NationalSpire.AiService.EventBusy(NationalSpire.CareerData, string)`；输入表达式：`AiService.EventBusy(d, e.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: e.State + e.CustomState + e.CustomAction + e.CustomOption?.Result + e.CustomReasoning + e.Title + e.Error + e.Options.Count + e.Selected + live?.Title + live?.Story + live?.Options + live?.Reasoning + live?.Phase + AiService.EventBusy(d, e.Id)`
- `NationalSpire.AiService.EventKey(NationalSpire.CareerData, string)`；输入表达式：`AiService.EventKey(d, e.Id)`；返回值紧邻使用处：`ArgumentSyntax: AiService.EventKey(d, e.Id)`
- `NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；输入表达式：`CareerMoney.Balance(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: e.State + e.CustomState + e.CustomAction + e.CustomOption?.Result + e.CustomReasoning + e.Title + e.Error + e.Options.Count + e.Selected + live?.Title + live?.Story + live?.Options + live?.Reasoning + live?.Phase + AiService.EventBusy(d, e.Id) + CareerMoney.Balance(d)`
- `NationalSpire.EventStoryView.Display(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.EventLive?, bool)`；输入表达式：`_eventView.Display(d, e, live, AiService.EventBusy(d, e.Id) || live != null)`；返回值紧邻使用处：`ExpressionStatementSyntax: _eventView.Display(d, e, live, AiService.EventBusy(d, e.Id) || live != null);`
- `NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`；输入表达式：`RandomEvents.Find(d, _eventId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RandomEvents.Find(d, _eventId)`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _eventView.Close?.Invoke()`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`AiService.EventLive.GetValueOrDefault(AiService.EventKey(d, e.Id))`；返回值紧邻使用处：`ConditionalExpressionSyntax: e.State == "generating" || e.CustomState == "generating" ? AiService.EventLive.GetValueOrDefault(AiService.EventKey(d, e.Id)) : null`

**赋值（含属性/字段和局部值）：**

- `_eventSignature` = `signature`

<a id="symbol-3ed25cc69ced"></a>

## `NationalSpire.EventStoryView.Public — public CheckButton Public`

来源：源码第 117 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8412299b7674"></a>

## `NationalSpire.EventStoryView.Status — public Label Status`

来源：源码第 118 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d31ee33f7cb0"></a>

## `NationalSpire.EventStoryView._Ready() — public override void _Ready()`

来源：源码第 137 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.EventStoryView.ActionButton(string, System.Action)`](RandomEventScreen.cs.md#symbol-8068df83bcbc)；[`NationalSpire.EventStoryView.BuildCustomAction(Godot.VBoxContainer)`](RandomEventCustomScreen.cs.md#symbol-9f8527a6f5e4)；[`NationalSpire.EventStoryView.Layout()`](RandomEventScreen.cs.md#symbol-741edf2a9101)；[`NationalSpire.EventStoryView.Rich(int)`](RandomEventScreen.cs.md#symbol-b60c5aa36cb9)；[`NationalSpire.EventStoryView.Words(string, int, Godot.Color)`](RandomEventScreen.cs.md#symbol-56ea79fa7863)；`Godot.CheckButton.CheckButton()`；`Godot.Color.Color(string)`；`Godot.ColorRect.ColorRect()`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.Control()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.HFlowContainer.HFlowContainer()`；`Godot.MarginContainer.MarginContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.ScrollContainer.ScrollContainer()`；`Godot.Shader.Shader()`；`Godot.ShaderMaterial.ShaderMaterial()`；`Godot.TextureRect.TextureRect()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.EventEmblem.EventEmblem()`；`NationalSpire.EventStoryButton.EventStoryButton()`；`System.Action.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.EventStoryButton.Caption`；`NationalSpire.EventStoryButton.Detail`；`NationalSpire.EventStoryButton.Mark`；`NationalSpire.EventStoryView._artSpace`；`NationalSpire.EventStoryView._artTitle`；`NationalSpire.EventStoryView._chapter`；`NationalSpire.EventStoryView._columns`；`NationalSpire.EventStoryView._continue`；`NationalSpire.EventStoryView._date`；`NationalSpire.EventStoryView._decision`；`NationalSpire.EventStoryView._effects`；`NationalSpire.EventStoryView._history`；`NationalSpire.EventStoryView._image`；`NationalSpire.EventStoryView._imageMaterial`；`NationalSpire.EventStoryView._options`；`NationalSpire.EventStoryView._paper`；`NationalSpire.EventStoryView._people`；`NationalSpire.EventStoryView._phase`；`NationalSpire.EventStoryView._reading`；`NationalSpire.EventStoryView._result`；`NationalSpire.EventStoryView._resultBox`；`NationalSpire.EventStoryView._retry`；`NationalSpire.EventStoryView._scroll`；`NationalSpire.EventStoryView._showHistory`；`NationalSpire.EventStoryView._skip`；`NationalSpire.EventStoryView._start`；`NationalSpire.EventStoryView._stay`；`NationalSpire.EventStoryView._stop`；`NationalSpire.EventStoryView._story`；`NationalSpire.EventStoryView._thinking`；`NationalSpire.EventStoryView._thinkingScroll`；`NationalSpire.EventStoryView._thought`；`NationalSpire.EventStoryView._title`；`NationalSpire.EventStoryView.ActionButton(string, System.Action)`；`NationalSpire.EventStoryView.BuildCustomAction(Godot.VBoxContainer)`；`NationalSpire.EventStoryView.Close`；`NationalSpire.EventStoryView.ContinueJourney`；`NationalSpire.EventStoryView.Gold`；`NationalSpire.EventStoryView.Layout()`；`NationalSpire.EventStoryView.Muted`；`NationalSpire.EventStoryView.Public`；`NationalSpire.EventStoryView.Rich(int)`；`NationalSpire.EventStoryView.Settings`；`NationalSpire.EventStoryView.Skip`；`NationalSpire.EventStoryView.Start`；`NationalSpire.EventStoryView.Status`；`NationalSpire.EventStoryView.Stop`；`NationalSpire.EventStoryView.Words(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CheckButton.CheckButton()`；输入表达式：`new CheckButton { Text = "公开这段经历", TooltipText = "所选结局可成为后续社区报道的材料。", CustomMinimumSize = new(0, 42) }`；返回值紧邻使用处：`AssignmentExpressionSyntax: Public = new CheckButton { Text = "公开这段经历", TooltipText = "所选结局可成为后续社区报道的材料。", CustomMinimumSize = new(0, 42) }`
- `Godot.Color.Color(string)`；输入表达式：`new("0c1722")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Color = new("0c1722")`
- `Godot.Color.Color(string)`；输入表达式：`new("dfbdac")`；返回值紧邻使用处：`ArgumentSyntax: new("dfbdac")`
- `Godot.ColorRect.ColorRect()`；输入表达式：`new ColorRect { Color = new("0c1722"), MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ColorRect { Color = new("0c1722"), MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_decision.AddThemeColorOverride("default_color", Gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: _decision.AddThemeColorOverride("default_color", Gold);`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_thought.AddThemeColorOverride("default_color", Muted)`；返回值紧邻使用处：`ExpressionStatementSyntax: _thought.AddThemeColorOverride("default_color", Muted);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_columns.AddThemeConstantOverride("separation", 26)`；返回值紧邻使用处：`ExpressionStatementSyntax: _columns.AddThemeConstantOverride("separation", 26);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_effects.AddThemeConstantOverride("separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: _effects.AddThemeConstantOverride("separation", 10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_options.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: _options.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_reading.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: _reading.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_resultBox.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: _resultBox.AddThemeConstantOverride("separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`artMargin.AddThemeConstantOverride("margin_bottom", 28)`；返回值紧邻使用处：`ExpressionStatementSyntax: artMargin.AddThemeConstantOverride("margin_bottom", 28);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`artMargin.AddThemeConstantOverride("margin_left", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: artMargin.AddThemeConstantOverride("margin_left", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`body.AddThemeConstantOverride("separation", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddThemeConstantOverride("separation", 18);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`caption.AddThemeConstantOverride("separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: caption.AddThemeConstantOverride("separation", 10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`column.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddThemeConstantOverride("separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`footer.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: footer.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`header.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`margin.AddThemeConstantOverride("margin_" + side, side is "left" or "right" ? 32 : 22)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddThemeConstantOverride("margin_" + side, side is "left" or "right" ? 32 : 22);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`readingTools.AddThemeConstantOverride("h_separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: readingTools.AddThemeConstantOverride("h_separation", 10);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`_paper.AddThemeStyleboxOverride("panel", CareerVisuals.Box("101e2be8", "526774", 12, 24))`；返回值紧邻使用处：`ExpressionStatementSyntax: _paper.AddThemeStyleboxOverride("panel", CareerVisuals.Box("101e2be8", "526774", 12, 24));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`decisionPanel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("203a46", "748577", 8, 18))`；返回值紧邻使用处：`ExpressionStatementSyntax: decisionPanel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("203a46", "748577", 8, 18));`
- `Godot.Control.Control()`；输入表达式：`new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`ArgumentSyntax: new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Control.Control()`；输入表达式：`new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = .38f }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _artSpace = new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = .38f }`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`_image.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: _image.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`artMargin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: artMargin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { SizeFlagsVertical = SizeFlags.ExpandFill }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _columns = new HBoxContainer { SizeFlagsVertical = SizeFlags.ExpandFill }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.HFlowContainer.HFlowContainer()`；输入表达式：`new HFlowContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HFlowContainer()`
- `Godot.MarginContainer.MarginContainer()`；输入表达式：`new MarginContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MarginContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_artSpace.AddChild(artMargin)`；返回值紧邻使用处：`ExpressionStatementSyntax: _artSpace.AddChild(artMargin);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_columns.AddChild(_artSpace)`；返回值紧邻使用处：`ExpressionStatementSyntax: _columns.AddChild(_artSpace);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_columns.AddChild(_paper)`；返回值紧邻使用处：`ExpressionStatementSyntax: _columns.AddChild(_paper);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_paper.AddChild(column)`；返回值紧邻使用处：`ExpressionStatementSyntax: _paper.AddChild(column);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_reading.AddChild(_options)`；返回值紧邻使用处：`ExpressionStatementSyntax: _reading.AddChild(_options);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_reading.AddChild(_resultBox)`；返回值紧邻使用处：`ExpressionStatementSyntax: _reading.AddChild(_resultBox);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_reading.AddChild(_start)`；返回值紧邻使用处：`ExpressionStatementSyntax: _reading.AddChild(_start);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_reading.AddChild(_story)`；返回值紧邻使用处：`ExpressionStatementSyntax: _reading.AddChild(_story);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_reading.AddChild(_thinkingScroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: _reading.AddChild(_thinkingScroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_reading.AddChild(readingTools)`；返回值紧邻使用处：`ExpressionStatementSyntax: _reading.AddChild(readingTools);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_resultBox.AddChild(_effects)`；返回值紧邻使用处：`ExpressionStatementSyntax: _resultBox.AddChild(_effects);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_resultBox.AddChild(_result)`；返回值紧邻使用处：`ExpressionStatementSyntax: _resultBox.AddChild(_result);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_resultBox.AddChild(decisionPanel)`；返回值紧邻使用处：`ExpressionStatementSyntax: _resultBox.AddChild(decisionPanel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_resultBox.AddChild(Words("你的选择", 14, Muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: _resultBox.AddChild(Words("你的选择", 14, Muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_scroll.AddChild(_reading)`；返回值紧邻使用处：`ExpressionStatementSyntax: _scroll.AddChild(_reading);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_thinkingScroll.AddChild(_thought)`；返回值紧邻使用处：`ExpressionStatementSyntax: _thinkingScroll.AddChild(_thought);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(_image)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(_image);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(margin)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(margin);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(shade)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(shade);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`artMargin.AddChild(caption)`；返回值紧邻使用处：`ExpressionStatementSyntax: artMargin.AddChild(caption);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(_columns)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(_columns);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(footer)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(footer);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(header)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(header);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`caption.AddChild(_artTitle)`；返回值紧邻使用处：`ExpressionStatementSyntax: caption.AddChild(_artTitle);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`caption.AddChild(_chapter)`；返回值紧邻使用处：`ExpressionStatementSyntax: caption.AddChild(_chapter);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`caption.AddChild(_people)`；返回值紧邻使用处：`ExpressionStatementSyntax: caption.AddChild(_people);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`column.AddChild(_phase)`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddChild(_phase);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`column.AddChild(_scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddChild(_scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`column.AddChild(_title)`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddChild(_title);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`column.AddChild(Status)`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddChild(Status);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`decisionPanel.AddChild(_decision)`；返回值紧邻使用处：`ExpressionStatementSyntax: decisionPanel.AddChild(_decision);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`footer.AddChild(_continue)`；返回值紧邻使用处：`ExpressionStatementSyntax: footer.AddChild(_continue);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`footer.AddChild(_retry)`；返回值紧邻使用处：`ExpressionStatementSyntax: footer.AddChild(_retry);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`footer.AddChild(_skip)`；返回值紧邻使用处：`ExpressionStatementSyntax: footer.AddChild(_skip);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`footer.AddChild(_stay)`；返回值紧邻使用处：`ExpressionStatementSyntax: footer.AddChild(_stay);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`footer.AddChild(_stop)`；返回值紧邻使用处：`ExpressionStatementSyntax: footer.AddChild(_stop);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`footer.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill })`；返回值紧邻使用处：`ExpressionStatementSyntax: footer.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`footer.AddChild(Public)`；返回值紧邻使用处：`ExpressionStatementSyntax: footer.AddChild(Public);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`footer.AddChild(settings)`；返回值紧邻使用处：`ExpressionStatementSyntax: footer.AddChild(settings);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(_date)`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(_date);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(exit)`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(exit);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(new EventEmblem { CustomMinimumSize = new(34, 34) })`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(new EventEmblem { CustomMinimumSize = new(34, 34) });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`margin.AddChild(body)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddChild(body);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`readingTools.AddChild(_history)`；返回值紧邻使用处：`ExpressionStatementSyntax: readingTools.AddChild(_history);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`readingTools.AddChild(_thinking)`；返回值紧邻使用处：`ExpressionStatementSyntax: readingTools.AddChild(_thinking);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = .62f }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _paper = new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = .62f }`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer()`
- `Godot.ScrollContainer.ScrollContainer()`；输入表达式：`new ScrollContainer { CustomMinimumSize = new(0, 150), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled, Visible = false }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _thinkingScroll = new ScrollContainer { CustomMinimumSize = new(0, 150), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled, Visible = false }`
- `Godot.ScrollContainer.ScrollContainer()`；输入表达式：`new ScrollContainer { SizeFlagsVertical = SizeFlags.ExpandFill, HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _scroll = new ScrollContainer { SizeFlagsVertical = SizeFlags.ExpandFill, HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `Godot.Shader.Shader()`；输入表达式：`new Shader { Code = "shader_type canvas_item; uniform float original = 0.0; void fragment(){ vec4 t=texture(TEXTURE, UV); float cover=mix(smoothstep(0.12,0.72,UV.x)*0.82+0.12,smoothstep(0.35,0.74,UV.x)*0.35,original); cover=max(cover,smoothstep(0.55,0.92,UV.y)*0.88); cover=max(cover,(1.0-smoothstep(0.0,0.17,UV.y))*0.8); COLOR=vec4(mix(t.rgb,vec3(0.047,0.09,0.13),cover),t.a); }" }`；返回值紧邻使用处：`AssignmentExpressionSyntax: Shader = new Shader { Code = "shader_type canvas_item; uniform float original = 0.0; void fragment(){ vec4 t=texture(TEXTURE, UV); float cover=mix(smoothstep(0.12,0.72,UV.x)*0.82+0.12,smoothstep(0.35,0.74,UV.x)*0.35,original); cover=max(cover,smoothstep(0.55,0.92,UV.y)*0.88); cover=max(cover,(1.0-smoothstep(0.0,0.17,UV.y))*0.8); COLOR=vec4(mix(t.rgb,vec3(0.047,0.09,0.13),cover),t.a); }" }`
- `Godot.ShaderMaterial.ShaderMaterial()`；输入表达式：`new ShaderMaterial { Shader = new Shader { Code = "shader_type canvas_item; uniform float original = 0.0; void fragment(){ vec4 t=texture(TEXTURE, UV); float cover=mix(smoothstep(0.12,0.72,UV.x)*0.82+0.12,smoothstep(0.35,0.74,UV.x)*0.35,original); cover=max(cover,smoothstep(0.55,0.92,UV.y)*0.88); cover=max(cover,(1.0-smoothstep(0.0,0.17,UV.y))*0.8); COLOR=vec4(mix(t.rgb,vec3(0.047,0.09,0.13),cover),t.a); }" } }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _imageMaterial = new ShaderMaterial { Shader = new Shader { Code = "shader_type canvas_item; uniform float original = 0.0; void fragment(){ vec4 t=texture(TEXTURE, UV); float cover=mix(smoothstep(0.12,0.72,UV.x)*0.82+0.12,smoothstep(0.35,0.74,UV.x)*0.35,original); cover=max(cover,smoothstep(0.55,0.92,UV.y)*0.88); cover=max(cover,(1.0-smoothstep(0.0,0.17,UV.y))*0.8); COLOR=vec4(mix(t.rgb,vec3(0.047,0.09,0.13),cover),t.a); }" } }`
- `Godot.TextureRect.TextureRect()`；输入表达式：`new TextureRect { ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCovered, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _image = new TextureRect { ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCovered, MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { Alignment = BoxContainer.AlignmentMode.End }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { Alignment = BoxContainer.AlignmentMode.End }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _reading = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _effects = new VBoxContainer()`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _options = new VBoxContainer()`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _resultBox = new VBoxContainer()`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 100)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 100)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 150)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 150)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 42)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(34, 34)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(34, 34)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("101e2be8", "526774", 12, 24)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("101e2be8", "526774", 12, 24)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("203a46", "748577", 8, 18)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("203a46", "748577", 8, 18)`
- `NationalSpire.EventEmblem.EventEmblem()`；输入表达式：`new EventEmblem { CustomMinimumSize = new(34, 34) }`；返回值紧邻使用处：`ArgumentSyntax: new EventEmblem { CustomMinimumSize = new(34, 34) }`
- `NationalSpire.EventStoryButton.EventStoryButton()`；输入表达式：`new EventStoryButton { Caption = "展开这段故事", Detail = "人物、赛程与此刻的生活，在这里相遇", Mark = "?", CustomMinimumSize = new(0, 100) }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _start = new EventStoryButton { Caption = "展开这段故事", Detail = "人物、赛程与此刻的生活，在这里相遇", Mark = "?", CustomMinimumSize = new(0, 100) }`
- `NationalSpire.EventStoryView.ActionButton(string, System.Action)`；输入表达式：`ActionButton("返回", () => Close?.Invoke())`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ActionButton("返回", () => Close?.Invoke())`
- `NationalSpire.EventStoryView.ActionButton(string, System.Action)`；输入表达式：`ActionButton("继续前往", () => ContinueJourney?.Invoke())`；返回值紧邻使用处：`AssignmentExpressionSyntax: _continue = ActionButton("继续前往", () => ContinueJourney?.Invoke())`
- `NationalSpire.EventStoryView.ActionButton(string, System.Action)`；输入表达式：`ActionButton("留在当天", () => Close?.Invoke())`；返回值紧邻使用处：`AssignmentExpressionSyntax: _stay = ActionButton("留在当天", () => Close?.Invoke())`
- `NationalSpire.EventStoryView.ActionButton(string, System.Action)`；输入表达式：`ActionButton("设置", () => Settings?.Invoke())`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ActionButton("设置", () => Settings?.Invoke())`
- `NationalSpire.EventStoryView.ActionButton(string, System.Action)`；输入表达式：`ActionButton("思考过程 ▸", () => { _thinkingScroll.Visible = !_thinkingScroll.Visible; _thinking.Text = _thinkingScroll.Visible ? "思考过程 ▾" : "思考过程 ▸"; })`；返回值紧邻使用处：`AssignmentExpressionSyntax: _thinking = ActionButton("思考过程 ▸", () => { _thinkingScroll.Visible = !_thinkingScroll.Visible; _thinking.Text = _thinkingScroll.Visible ? "思考过程 ▾" : "思考过程 ▸"; })`
- `NationalSpire.EventStoryView.ActionButton(string, System.Action)`；输入表达式：`ActionButton("跳过事件", () => Skip?.Invoke())`；返回值紧邻使用处：`AssignmentExpressionSyntax: _skip = ActionButton("跳过事件", () => Skip?.Invoke())`
- `NationalSpire.EventStoryView.ActionButton(string, System.Action)`；输入表达式：`ActionButton("停止生成", () => Stop?.Invoke())`；返回值紧邻使用处：`AssignmentExpressionSyntax: _stop = ActionButton("停止生成", () => Stop?.Invoke())`
- `NationalSpire.EventStoryView.ActionButton(string, System.Action)`；输入表达式：`ActionButton("阅读故事经过 ▸", () => { _showHistory = !_showHistory; _story.Visible = _showHistory; _history.Text = _showHistory ? "收起故事经过 ▾" : "阅读故事经过 ▸"; })`；返回值紧邻使用处：`AssignmentExpressionSyntax: _history = ActionButton("阅读故事经过 ▸", () => { _showHistory = !_showHistory; _story.Visible = _showHistory; _history.Text = _showHistory ? "收起故事经过 ▾" : "阅读故事经过 ▸"; })`
- `NationalSpire.EventStoryView.ActionButton(string, System.Action)`；输入表达式：`ActionButton("重新生成", () => Start?.Invoke())`；返回值紧邻使用处：`AssignmentExpressionSyntax: _retry = ActionButton("重新生成", () => Start?.Invoke())`
- `NationalSpire.EventStoryView.BuildCustomAction(Godot.VBoxContainer)`；输入表达式：`BuildCustomAction(_reading)`；返回值紧邻使用处：`ExpressionStatementSyntax: BuildCustomAction(_reading);`
- `NationalSpire.EventStoryView.Layout()`；输入表达式：`Layout()`；返回值紧邻使用处：`ExpressionStatementSyntax: Layout();`
- `NationalSpire.EventStoryView.Rich(int)`；输入表达式：`Rich(15)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _thought = Rich(15)`
- `NationalSpire.EventStoryView.Rich(int)`；输入表达式：`Rich(17)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _people = Rich(17)`
- `NationalSpire.EventStoryView.Rich(int)`；输入表达式：`Rich(20)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _decision = Rich(20)`
- `NationalSpire.EventStoryView.Rich(int)`；输入表达式：`Rich(20)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _story = Rich(20)`
- `NationalSpire.EventStoryView.Rich(int)`；输入表达式：`Rich(21)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _result = Rich(21)`
- `NationalSpire.EventStoryView.Words(string, int, Godot.Color)`；输入表达式：`Words("", 14, CareerVisuals.Teal)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _phase = Words("", 14, CareerVisuals.Teal)`
- `NationalSpire.EventStoryView.Words(string, int, Godot.Color)`；输入表达式：`Words("", 15, new("dfbdac"))`；返回值紧邻使用处：`AssignmentExpressionSyntax: Status = Words("", 15, new("dfbdac"))`
- `NationalSpire.EventStoryView.Words(string, int, Godot.Color)`；输入表达式：`Words("际遇", 17, Muted)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _date = Words("际遇", 17, Muted)`
- `NationalSpire.EventStoryView.Words(string, int, Godot.Color)`；输入表达式：`Words("你的选择", 14, Muted)`；返回值紧邻使用处：`ArgumentSyntax: Words("你的选择", 14, Muted)`
- `NationalSpire.EventStoryView.Words(string, int, Godot.Color)`；输入表达式：`Words("生活的另一面", 30, Gold)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _artTitle = Words("生活的另一面", 30, Gold)`
- `NationalSpire.EventStoryView.Words(string, int, Godot.Color)`；输入表达式：`Words("未知的际遇", 30, Gold)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _title = Words("未知的际遇", 30, Gold)`
- `NationalSpire.EventStoryView.Words(string, int, Godot.Color)`；输入表达式：`Words("一段尚未展开的故事", 15, CareerVisuals.Teal)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _chapter = Words("一段尚未展开的故事", 15, CareerVisuals.Teal)`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Close?.Invoke()`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: ContinueJourney?.Invoke()`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Settings?.Invoke()`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Skip?.Invoke()`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Start?.Invoke()`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Stop?.Invoke()`

**赋值（含属性/字段和局部值）：**

- `_artSpace` = `new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = .38f }`
- `_artTitle` = `Words("生活的另一面", 30, Gold)`
- `_chapter` = `Words("一段尚未展开的故事", 15, CareerVisuals.Teal)`
- `_columns` = `new HBoxContainer { SizeFlagsVertical = SizeFlags.ExpandFill }`
- `_continue.Name` = `"ContinueEventJourney"`
- `_continue` = `ActionButton("继续前往", () => ContinueJourney?.Invoke())`
- `_date.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `_date` = `Words("际遇", 17, Muted)`
- `_decision` = `Rich(20)`
- `_effects` = `new VBoxContainer()`
- `_history.SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`
- `_history.Text` = `_showHistory ? "收起故事经过 ▾" : "阅读故事经过 ▸"`
- `_history` = `ActionButton("阅读故事经过 ▸", () => { _showHistory = !_showHistory; _story.Visible = _showHistory; _history.Text = _showHistory ? "收起故事经过 ▾" : "阅读故事经过 ▸"; })`
- `_image.Material` = `_imageMaterial`
- `_image` = `new TextureRect { ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCovered, MouseFilter = MouseFilterEnum.Ignore }`
- `_imageMaterial` = `new ShaderMaterial { Shader = new Shader { Code = "shader_type canvas_item; uniform float original = 0.0; void fragment(){ vec4 t=texture(TEXTURE, UV); float cover=mix(smoothstep(0.12,0.72,UV.x)*0.82+0.12,smoothstep(0.35,0.74,UV.x)*0.35,original); cover=max(cover,smoothstep(0.55,0.92,UV.y)*0.88); cover=max(cover,(1.0-smoothstep(0.0,0.17,UV.y))*0.8); COLOR=vec4(mix(t.rgb,vec3(0.047,0.09,0.13),cover),t.a); }" } }`
- `_options` = `new VBoxContainer()`
- `_paper` = `new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = .62f }`
- `_people` = `Rich(17)`
- `_phase` = `Words("", 14, CareerVisuals.Teal)`
- `_reading` = `new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `_result.Name` = `"EventResult"`
- `_result` = `Rich(21)`
- `_resultBox` = `new VBoxContainer()`
- `_retry.Name` = `"RetryRandomEvent"`
- `_retry` = `ActionButton("重新生成", () => Start?.Invoke())`
- `_scroll` = `new ScrollContainer { SizeFlagsVertical = SizeFlags.ExpandFill, HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `_showHistory` = `!_showHistory`
- `_skip.Name` = `"SkipRandomEvent"`
- `_skip` = `ActionButton("跳过事件", () => Skip?.Invoke())`
- `_start.Pressed` += `() => Start?.Invoke()`
- `_start` = `new EventStoryButton { Caption = "展开这段故事", Detail = "人物、赛程与此刻的生活，在这里相遇", Mark = "?", CustomMinimumSize = new(0, 100) }`
- `_stay.Name` = `"StayAfterEvent"`
- `_stay` = `ActionButton("留在当天", () => Close?.Invoke())`
- `_stop.Name` = `"StopRandomEvent"`
- `_stop` = `ActionButton("停止生成", () => Stop?.Invoke())`
- `_story.Name` = `"EventStory"`
- `_story.Visible` = `_showHistory`
- `_story` = `Rich(20)`
- `_thinking.SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`
- `_thinking.Text` = `_thinkingScroll.Visible ? "思考过程 ▾" : "思考过程 ▸"`
- `_thinking` = `ActionButton("思考过程 ▸", () => { _thinkingScroll.Visible = !_thinkingScroll.Visible; _thinking.Text = _thinkingScroll.Visible ? "思考过程 ▾" : "思考过程 ▸"; })`
- `_thinkingScroll.Visible` = `!_thinkingScroll.Visible`
- `_thinkingScroll` = `new ScrollContainer { CustomMinimumSize = new(0, 150), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled, Visible = false }`
- `_thought` = `Rich(15)`
- `_title` = `Words("未知的际遇", 30, Gold)`
- `Alignment` = `BoxContainer.AlignmentMode.End`
- `Caption` = `"展开这段故事"`
- `Code` = `"shader_type canvas_item; uniform float original = 0.0; void fragment(){ vec4 t=texture(TEXTURE, UV); float cover=mix(smoothstep(0.12,0.72,UV.x)*0.82+0.12,smoothstep(0.35,0.74,UV.x)*0.35,original); cover=max(cover,smoothstep(0.55,0.92,UV.y)*0.88); cover=max(cover,(1.0-smoothstep(0.0,0.17,UV.y))*0.8); COLOR=vec4(mix(t.rgb,vec3(0.047,0.09,0.13),cover),t.a); }"`
- `Color` = `new("0c1722")`
- `CustomMinimumSize` = `new(0, 100)`
- `CustomMinimumSize` = `new(0, 150)`
- `CustomMinimumSize` = `new(0, 42)`
- `CustomMinimumSize` = `new(34, 34)`
- `Detail` = `"人物、赛程与此刻的生活，在这里相遇"`
- `exit.Name` = `"CloseRandomEvent"`
- `ExpandMode` = `TextureRect.ExpandModeEnum.IgnoreSize`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `Mark` = `"?"`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `MouseFilter` = `MouseFilterEnum.Stop`
- `Name` = `"RandomEventView"`
- `Public` = `new CheckButton { Text = "公开这段经历", TooltipText = "所选结局可成为后续社区报道的材料。", CustomMinimumSize = new(0, 42) }`
- `Resized` += `Layout`
- `settings.Name` = `"RandomEventSettings"`
- `Shader` = `new Shader { Code = "shader_type canvas_item; uniform float original = 0.0; void fragment(){ vec4 t=texture(TEXTURE, UV); float cover=mix(smoothstep(0.12,0.72,UV.x)*0.82+0.12,smoothstep(0.35,0.74,UV.x)*0.35,original); cover=max(cover,smoothstep(0.55,0.92,UV.y)*0.88); cover=max(cover,(1.0-smoothstep(0.0,0.17,UV.y))*0.8); COLOR=vec4(mix(t.rgb,vec3(0.047,0.09,0.13),cover),t.a); }" }`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsStretchRatio` = `.38f`
- `SizeFlagsStretchRatio` = `.62f`
- `SizeFlagsVertical` = `SizeFlags.ExpandFill`
- `Status` = `Words("", 15, new("dfbdac"))`
- `StretchMode` = `TextureRect.StretchModeEnum.KeepAspectCovered`
- `Text` = `"公开这段经历"`
- `TooltipText` = `"所选结局可成为后续社区报道的材料。"`
- `Visible` = `false`
- `ZIndex` = `35`

<a id="symbol-741edf2a9101"></a>

## `NationalSpire.EventStoryView.Layout() — private void Layout()`

来源：源码第 194 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EventStoryView._Ready()`](RandomEventScreen.cs.md#symbol-d31ee33f7cb0)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.EventStoryView._artSpace`；`NationalSpire.EventStoryView._columns`；`NationalSpire.EventStoryView._paper`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `_artSpace.SizeFlagsStretchRatio` = `Size.X < 1250 ? .28f : .38f`
- `_paper.SizeFlagsStretchRatio` = `1 - _artSpace.SizeFlagsStretchRatio`

<a id="symbol-56ea79fa7863"></a>

## `NationalSpire.EventStoryView.Words(string, int, Godot.Color) — private static Label Words(string text, int size, Color color)`

来源：源码第 200 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EventStoryView._Ready()`](RandomEventScreen.cs.md#symbol-d31ee33f7cb0)；[`NationalSpire.EventStoryView.BuildCustomAction(Godot.VBoxContainer)`](RandomEventCustomScreen.cs.md#symbol-9f8527a6f5e4)；[`NationalSpire.EventStoryView.Display(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.EventLive?, bool)`](RandomEventScreen.cs.md#symbol-f847e9f29b0e)；[`NationalSpire.EventStoryView.ShowResultEffects(NationalSpire.CareerData, NationalSpire.RandomEventOption, Godot.VBoxContainer)`](RandomEventScreen.cs.md#symbol-5fbf79c036d6)

**调用：** `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Label.Label()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`label.AddThemeColorOverride("font_color", color)`；返回值紧邻使用处：`ExpressionStatementSyntax: label.AddThemeColorOverride("font_color", color);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`label.AddThemeFontSizeOverride("font_size", size)`；返回值紧邻使用处：`ExpressionStatementSyntax: label.AddThemeFontSizeOverride("font_size", size);`
- `Godot.Label.Label()`；输入表达式：`new Label { Text = text, AutowrapMode = TextServer.AutowrapMode.WordSmart }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Label { Text = text, AutowrapMode = TextServer.AutowrapMode.WordSmart }`

**赋值（含属性/字段和局部值）：**

- `AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `Text` = `text`

<a id="symbol-b60c5aa36cb9"></a>

## `NationalSpire.EventStoryView.Rich(int) — private RichTextLabel Rich(int size)`

来源：源码第 205 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EventStoryView._Ready()`](RandomEventScreen.cs.md#symbol-d31ee33f7cb0)；[`NationalSpire.EventStoryView.BuildCustomAction(Godot.VBoxContainer)`](RandomEventCustomScreen.cs.md#symbol-9f8527a6f5e4)；[`NationalSpire.EventStoryView.ShowResultEffects(NationalSpire.CareerData, NationalSpire.RandomEventOption, Godot.VBoxContainer)`](RandomEventScreen.cs.md#symbol-5fbf79c036d6)

**调用：** `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.RichTextLabel.RichTextLabel()`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.EventStoryView.Ink`；`NationalSpire.EventStoryView.OpenPerson`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`text.AddThemeColorOverride("default_color", Ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: text.AddThemeColorOverride("default_color", Ink);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`text.AddThemeConstantOverride("line_separation", 7)`；返回值紧邻使用处：`ExpressionStatementSyntax: text.AddThemeConstantOverride("line_separation", 7);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`text.AddThemeFontSizeOverride("normal_font_size", size)`；返回值紧邻使用处：`ExpressionStatementSyntax: text.AddThemeFontSizeOverride("normal_font_size", size);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`text.AddThemeStyleboxOverride("focus", new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: text.AddThemeStyleboxOverride("focus", new StyleBoxEmpty());`
- `Godot.RichTextLabel.RichTextLabel()`；输入表达式：`new RichTextLabel { FitContent = true, ScrollActive = false, SelectionEnabled = true, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new RichTextLabel { FitContent = true, ScrollActive = false, SelectionEnabled = true, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty()`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxEmpty()`
- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke(meta)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: OpenPerson?.Invoke(meta)`

**赋值（含属性/字段和局部值）：**

- `FitContent` = `true`
- `ScrollActive` = `false`
- `SelectionEnabled` = `true`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `text.MetaClicked` += `meta => OpenPerson?.Invoke(meta)`

<a id="symbol-8068df83bcbc"></a>

## `NationalSpire.EventStoryView.ActionButton(string, System.Action) — private static Button ActionButton(string text, Action action)`

来源：源码第 212 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EventStoryView._Ready()`](RandomEventScreen.cs.md#symbol-d31ee33f7cb0)；[`NationalSpire.EventStoryView.BuildCustomAction(Godot.VBoxContainer)`](RandomEventCustomScreen.cs.md#symbol-9f8527a6f5e4)

**调用：** [`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Button.Button()`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.EventStoryView.Ink`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Button.Button()`；输入表达式：`new Button { Text = text, CustomMinimumSize = new(112, 42), MouseDefaultCursorShape = CursorShape.PointingHand }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Button { Text = text, CustomMinimumSize = new(112, 42), MouseDefaultCursorShape = CursorShape.PointingHand }`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`button.AddThemeColorOverride("font_color", Ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeColorOverride("font_color", Ink);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride(state, CareerVisuals.Box(state == "normal" ? "172c3c" : "2c4c5b", state == "normal" ? "476373" : "8abfb8", 7, 12))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride(state, CareerVisuals.Box(state == "normal" ? "172c3c" : "2c4c5b", state == "normal" ? "476373" : "8abfb8", 7, 12));`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(112, 42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(112, 42)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box(state == "normal" ? "172c3c" : "2c4c5b", state == "normal" ? "476373" : "8abfb8", 7, 12)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box(state == "normal" ? "172c3c" : "2c4c5b", state == "normal" ? "476373" : "8abfb8", 7, 12)`

**赋值（含属性/字段和局部值）：**

- `button.Pressed` += `action`
- `CustomMinimumSize` = `new(112, 42)`
- `MouseDefaultCursorShape` = `CursorShape.PointingHand`
- `Text` = `text`

<a id="symbol-f7138d37ec2b"></a>

## `NationalSpire.EventStoryView.SetText(Godot.RichTextLabel, string) — private void SetText(RichTextLabel label, string text)`

来源：源码第 218 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EventStoryView.Display(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.EventLive?, bool)`](RandomEventScreen.cs.md#symbol-f847e9f29b0e)；[`NationalSpire.EventStoryView.DisplayCustom(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.EventLive?, bool)`](RandomEventCustomScreen.cs.md#symbol-e43ecd579917)；[`NationalSpire.EventStoryView.ShowResultEffects(NationalSpire.CareerData, NationalSpire.RandomEventOption, Godot.VBoxContainer)`](RandomEventScreen.cs.md#symbol-5fbf79c036d6)

**调用：** `System.Action<T1, T2>.Invoke(T1, T2)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.EventStoryView.Paint`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Action<T1, T2>.Invoke(T1, T2)`；输入表达式：`Paint(label, text)`；返回值紧邻使用处：`ExpressionStatementSyntax: Paint(label, text);`

**赋值（含属性/字段和局部值）：**

- `label.Text` = `text`

<a id="symbol-f847e9f29b0e"></a>

## `NationalSpire.EventStoryView.Display(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.EventLive?, bool) — public void Display(CareerData d, RandomEventRecord e, EventLive? live, bool busy)`

来源：源码第 219 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RefreshRandomEvent()`](RandomEventScreen.cs.md#symbol-54853f1d507f)

**调用：** [`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`NationalSpire.EventStoryView.DisplayCustom(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.EventLive?, bool)`](RandomEventCustomScreen.cs.md#symbol-e43ecd579917)；[`NationalSpire.EventStoryView.SetText(Godot.RichTextLabel, string)`](RandomEventScreen.cs.md#symbol-f7138d37ec2b)；[`NationalSpire.EventStoryView.ShowResultEffects(NationalSpire.CareerData, NationalSpire.RandomEventOption)`](RandomEventScreen.cs.md#symbol-8328804c1b4d)；[`NationalSpire.EventStoryView.Words(string, int, Godot.Color)`](RandomEventScreen.cs.md#symbol-56ea79fa7863)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；[`NationalSpire.PlayerFacingText.LongError(string)`](PlayerFacingText.cs.md#symbol-f9422d3b8971)；[`NationalSpire.RandomEventArt.Category(NationalSpire.RandomEventRecord)`](RandomEventArt.cs.md#symbol-4d27d6b0c40b)；[`NationalSpire.RandomEventArt.Load(string)`](RandomEventArt.cs.md#symbol-5147b98e47ca)；[`NationalSpire.RandomEventArt.Select(NationalSpire.RandomEventRecord)`](RandomEventArt.cs.md#symbol-e34111fd0431)；[`NationalSpire.RandomEventEffects.Check(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption)`](RandomEvents.cs.md#symbol-09ecc3f9af33)；[`NationalSpire.RandomEventEffects.Preview(NationalSpire.CareerData, NationalSpire.RandomEventOption)`](RandomEvents.cs.md#symbol-de44eea7b389)；`Godot.Color.Color(string)`；`Godot.GodotObject.Dispose()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.ShaderMaterial.SetShaderParameter(Godot.StringName, Godot.Variant)`；`int.ToString()`；`NationalSpire.EventStoryButton.EventStoryButton()`；`string.Join(string?, params string?[])`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`string.StartsWith(string)`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Journey`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.EventJourney.Destination`；`NationalSpire.EventLive.Choices`；`NationalSpire.EventLive.Options`；`NationalSpire.EventLive.Phase`；`NationalSpire.EventLive.Reasoning`；`NationalSpire.EventLive.Story`；`NationalSpire.EventLive.Title`；`NationalSpire.EventStoryButton.Caption`；`NationalSpire.EventStoryButton.Detail`；`NationalSpire.EventStoryButton.Mark`；`NationalSpire.EventStoryButton.Paint`；`NationalSpire.EventStoryView._artId`；`NationalSpire.EventStoryView._artTitle`；`NationalSpire.EventStoryView._chapter`；`NationalSpire.EventStoryView._choiceSignature`；`NationalSpire.EventStoryView._continue`；`NationalSpire.EventStoryView._customExpanded`；`NationalSpire.EventStoryView._date`；`NationalSpire.EventStoryView._decision`；`NationalSpire.EventStoryView._history`；`NationalSpire.EventStoryView._image`；`NationalSpire.EventStoryView._imageMaterial`；`NationalSpire.EventStoryView._lastState`；`NationalSpire.EventStoryView._options`；`NationalSpire.EventStoryView._ownedImage`；`NationalSpire.EventStoryView._people`；`NationalSpire.EventStoryView._phase`；`NationalSpire.EventStoryView._result`；`NationalSpire.EventStoryView._resultBox`；`NationalSpire.EventStoryView._resultText`；`NationalSpire.EventStoryView._retry`；`NationalSpire.EventStoryView._scroll`；`NationalSpire.EventStoryView._showHistory`；`NationalSpire.EventStoryView._skip`；`NationalSpire.EventStoryView._start`；`NationalSpire.EventStoryView._stay`；`NationalSpire.EventStoryView._stop`；`NationalSpire.EventStoryView._story`；`NationalSpire.EventStoryView._storyText`；`NationalSpire.EventStoryView._thinking`；`NationalSpire.EventStoryView._thinkingScroll`；`NationalSpire.EventStoryView._thought`；`NationalSpire.EventStoryView._title`；`NationalSpire.EventStoryView.Choose`；`NationalSpire.EventStoryView.DisplayCustom(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.EventLive?, bool)`；`NationalSpire.EventStoryView.Paint`；`NationalSpire.EventStoryView.Public`；`NationalSpire.EventStoryView.SetText(Godot.RichTextLabel, string)`；`NationalSpire.EventStoryView.ShowResultEffects(NationalSpire.CareerData, NationalSpire.RandomEventOption)`；`NationalSpire.EventStoryView.Status`；`NationalSpire.EventStoryView.Words(string, int, Godot.Color)`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；`NationalSpire.PlayerFacingText.LongError(string)`；`NationalSpire.RandomEventArt.Category(NationalSpire.RandomEventRecord)`；`NationalSpire.RandomEventArt.Load(string)`；`NationalSpire.RandomEventArt.Select(NationalSpire.RandomEventRecord)`；`NationalSpire.RandomEventEffects.Check(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption)`；`NationalSpire.RandomEventEffects.Preview(NationalSpire.CareerData, NationalSpire.RandomEventOption)`；`NationalSpire.RandomEventOption.Result`；`NationalSpire.RandomEventOption.Text`；`NationalSpire.RandomEventRecord.CustomReasoning`；`NationalSpire.RandomEventRecord.CustomState`；`NationalSpire.RandomEventRecord.Day`；`NationalSpire.RandomEventRecord.Error`；`NationalSpire.RandomEventRecord.Options`；`NationalSpire.RandomEventRecord.People`；`NationalSpire.RandomEventRecord.Public`；`NationalSpire.RandomEventRecord.Reasoning`；`NationalSpire.RandomEventRecord.Seed`；`NationalSpire.RandomEventRecord.Selected`；`NationalSpire.RandomEventRecord.State`；`NationalSpire.RandomEventRecord.Story`；`NationalSpire.RandomEventRecord.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new("d0aaa0")`；返回值紧邻使用处：`ArgumentSyntax: new("d0aaa0")`
- `Godot.GodotObject.Dispose()`；输入表达式：`.Dispose()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _ownedImage?.Dispose()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_options.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: _options.AddChild(button);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_options.AddChild(Words(error, 14, new("d0aaa0")))`；返回值紧邻使用处：`ExpressionStatementSyntax: _options.AddChild(Words(error, 14, new("d0aaa0")));`
- `Godot.ShaderMaterial.SetShaderParameter(Godot.StringName, Godot.Variant)`；输入表达式：`_imageMaterial.SetShaderParameter("original", art.StartsWith("game:") ? 1f : 0f)`；返回值紧邻使用处：`ExpressionStatementSyntax: _imageMaterial.SetShaderParameter("original", art.StartsWith("game:") ? 1f : 0f);`
- `int.ToString()`；输入表达式：`(i + 1).ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Mark = (i + 1).ToString()`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(_options)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(_options);`
- `NationalSpire.EventStoryButton.EventStoryButton()`；输入表达式：`new EventStoryButton { Name = "EventOption_" + i, Caption = option.Text, Detail = RandomEventEffects.Preview(d, option), Mark = (i + 1).ToString(), Disabled = generating || busy || customBusy || error != null, TooltipText = error ?? "", Paint = Paint }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new EventStoryButton { Name = "EventOption_" + i, Caption = option.Text, Detail = RandomEventEffects.Preview(d, option), Mark = (i + 1).ToString(), Disabled = generating || busy || customBusy || error != null, TooltipText = error ?? "", Paint = Paint }`
- `NationalSpire.EventStoryView.DisplayCustom(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.EventLive?, bool)`；输入表达式：`DisplayCustom(d, e, customBusy ? live : null, busy)`；返回值紧邻使用处：`ExpressionStatementSyntax: DisplayCustom(d, e, customBusy ? live : null, busy);`
- `NationalSpire.EventStoryView.SetText(Godot.RichTextLabel, string)`；输入表达式：`SetText(_decision, chosen.Text)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetText(_decision, chosen.Text);`
- `NationalSpire.EventStoryView.SetText(Godot.RichTextLabel, string)`；输入表达式：`SetText(_people, string.Join("\n", e.People.Select(id => GroupChats.Name(d, id))))`；返回值紧邻使用处：`ExpressionStatementSyntax: SetText(_people, string.Join("\n", e.People.Select(id => GroupChats.Name(d, id))));`
- `NationalSpire.EventStoryView.SetText(Godot.RichTextLabel, string)`；输入表达式：`SetText(_result, chosen.Result)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetText(_result, chosen.Result);`
- `NationalSpire.EventStoryView.SetText(Godot.RichTextLabel, string)`；输入表达式：`SetText(_story, story)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetText(_story, story);`
- `NationalSpire.EventStoryView.ShowResultEffects(NationalSpire.CareerData, NationalSpire.RandomEventOption)`；输入表达式：`ShowResultEffects(d, chosen)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowResultEffects(d, chosen);`
- `NationalSpire.EventStoryView.Words(string, int, Godot.Color)`；输入表达式：`Words(error, 14, new("d0aaa0"))`；返回值紧邻使用处：`ArgumentSyntax: Words(error, 14, new("d0aaa0"))`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(d, d.Journey.Destination)`；返回值紧邻使用处：`BinaryExpressionSyntax: "继续前往 " + GameCalendar.Text(d, d.Journey.Destination)`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(d, e.Day)`；返回值紧邻使用处：`BinaryExpressionSyntax: "际遇  /  " + GameCalendar.Text(d, e.Day)`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(d, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => GroupChats.Name(d, id)`
- `NationalSpire.PlayerFacingText.LongError(string)`；输入表达式：`PlayerFacingText.LongError(e.Error)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Status.Text = PlayerFacingText.LongError(e.Error)`
- `NationalSpire.RandomEventArt.Category(NationalSpire.RandomEventRecord)`；输入表达式：`RandomEventArt.Category(e)`；返回值紧邻使用处：`BinaryExpressionSyntax: RandomEventArt.Category(e) + " · "`
- `NationalSpire.RandomEventArt.Load(string)`；输入表达式：`RandomEventArt.Load(art)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RandomEventArt.Load(art)`
- `NationalSpire.RandomEventArt.Select(NationalSpire.RandomEventRecord)`；输入表达式：`RandomEventArt.Select(e)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RandomEventArt.Select(e)`
- `NationalSpire.RandomEventEffects.Check(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption)`；输入表达式：`RandomEventEffects.Check(d, e, o)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: o => RandomEventEffects.Check(d, e, o)`
- `NationalSpire.RandomEventEffects.Preview(NationalSpire.CareerData, NationalSpire.RandomEventOption)`；输入表达式：`RandomEventEffects.Preview(d, option)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Detail = RandomEventEffects.Preview(d, option)`
- `string.Join(string?, params string?[])`；输入表达式：`string.Join("|", errors)`；返回值紧邻使用处：`BinaryExpressionSyntax: e.State + ":" + busy + ":" + choices.Count + ":" + string.Join("|", errors)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n", e.People.Select(id => GroupChats.Name(d, id)))`；返回值紧邻使用处：`ArgumentSyntax: string.Join("\n", e.People.Select(id => GroupChats.Name(d, id)))`
- `string.StartsWith(string)`；输入表达式：`art.StartsWith("game:")`；返回值紧邻使用处：`ConditionalExpressionSyntax: art.StartsWith("game:") ? 1f : 0f`
- `string.StartsWith(string)`；输入表达式：`art.StartsWith("game:")`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !art.StartsWith("game:")`
- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke(index)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Choose?.Invoke(index)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`choices.Select(o => RandomEventEffects.Check(d, e, o))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: choices.Select(o => RandomEventEffects.Check(d, e, o)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`e.People.Select(id => GroupChats.Name(d, id))`；返回值紧邻使用处：`ArgumentSyntax: e.People.Select(id => GroupChats.Name(d, id))`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`choices.Select(o => RandomEventEffects.Check(d, e, o)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = choices.Select(o => RandomEventEffects.Check(d, e, o)).ToArray()`

**赋值（含属性/字段和局部值）：**

- `_artId` = `art`
- `_artTitle.Text` = `complete ? "故事告一段落" : generating ? "故事正在发生" : "生活的另一面"`
- `_chapter.Text` = `e.Seed.Length == 0 ? "一段尚未展开的故事" : RandomEventArt.Category(e) + " · " + (complete ? "已经留下的回忆" : "此刻的生活")`
- `_choiceSignature` = `signature`
- `_continue.Text` = `"继续前往 " + GameCalendar.Text(d, d.Journey.Destination)`
- `_continue.Visible` = `(complete || skipped) && d.Journey.Destination > d.Day`
- `_date.Text` = `"际遇  /  " + GameCalendar.Text(d, e.Day)`
- `_history.Visible` = `complete`
- `_image.Texture` = `null`
- `_image.Texture` = `texture`
- `_lastState` = `e.State`
- `_ownedImage` = `null`
- `_ownedImage` = `texture`
- `_phase.Text` = `complete ? (e.Public ? "已完成 · 公开经历" : "已完成 · 私密经历") : skipped ? "已跳过" : generating ? (live?.Phase ?? "正在恢复请求") + (live?.Options > 0 ? " · 已收到" + live.Options + "个选项" : "") : e.State == "ready" ? "选择一个行动，让这段故事落下句点" : ""`
- `_phase.Visible` = `_phase.Text.Length > 0`
- `_resultBox.Visible` = `complete`
- `_resultText` = `result`
- `_retry.Disabled` = `busy`
- `_retry.Text` = `e.State == "failed" || generating ? "重试生成" : "重新生成"`
- `_retry.Visible` &= `!customBusy`
- `_retry.Visible` = `!complete && !skipped && e.State != "waiting" && (!generating || !busy)`
- `_scroll.ScrollVertical` = `0`
- `_showHistory` = `false`
- `_skip.Visible` = `!complete && !skipped`
- `_start.Visible` = `e.State == "waiting"`
- `_stay.Visible` = `complete || skipped`
- `_stop.Visible` = `(generating || customBusy) && busy`
- `_story.Visible` = `!complete || _showHistory`
- `_storyText` = `story`
- `_thinking.Visible` = `thought.Length > 0`
- `_thinkingScroll.Visible` = `false`
- `_thought.Text` = `thought`
- `_title.Text` = `live?.Title is { Length: > 0 } title && title != "未知的际遇" ? title : e.Title`
- `button.Pressed` += `() => Choose?.Invoke(index)`
- `Caption` = `option.Text`
- `Detail` = `RandomEventEffects.Preview(d, option)`
- `Disabled` = `generating || busy || customBusy || error != null`
- `Mark` = `(i + 1).ToString()`
- `Name` = `"EventOption_" + i`
- `Paint` = `Paint`
- `Public.Visible` = `!complete && !skipped`
- `Status.Text` = `PlayerFacingText.LongError(e.Error)`
- `Status.Visible` = `e.Error.Length > 0`
- `story` = `"故事正在酝酿，人物与此刻的经历将在这里相遇。"`
- `story` = `"你把这段时间留给了其他安排。"`
- `story` = `"赛程之外，也有值得停留的片刻。\n\n从这里展开一段故事，或把今天留给其他安排。"`
- `TooltipText` = `error ?? ""`

<a id="symbol-8328804c1b4d"></a>

## `NationalSpire.EventStoryView.ShowResultEffects(NationalSpire.CareerData, NationalSpire.RandomEventOption) — private void ShowResultEffects(CareerData data, RandomEventOption option)`

来源：源码第 281 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EventStoryView.Display(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.EventLive?, bool)`](RandomEventScreen.cs.md#symbol-f847e9f29b0e)

**调用：** [`NationalSpire.EventStoryView.ShowResultEffects(NationalSpire.CareerData, NationalSpire.RandomEventOption, Godot.VBoxContainer)`](RandomEventScreen.cs.md#symbol-5fbf79c036d6)

**字段、属性、事件及方法组引用：** `NationalSpire.EventStoryView._effects`；`NationalSpire.EventStoryView.ShowResultEffects(NationalSpire.CareerData, NationalSpire.RandomEventOption, Godot.VBoxContainer)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.EventStoryView.ShowResultEffects(NationalSpire.CareerData, NationalSpire.RandomEventOption, Godot.VBoxContainer)`；输入表达式：`ShowResultEffects(data, option, _effects)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => ShowResultEffects(data, option, _effects)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5fbf79c036d6"></a>

## `NationalSpire.EventStoryView.ShowResultEffects(NationalSpire.CareerData, NationalSpire.RandomEventOption, Godot.VBoxContainer) — private void ShowResultEffects(CareerData data, RandomEventOption option, VBoxContainer _effects)`

来源：源码第 282 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EventStoryView.DisplayCustom(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.EventLive?, bool)`](RandomEventCustomScreen.cs.md#symbol-e43ecd579917)；[`NationalSpire.EventStoryView.ShowResultEffects(NationalSpire.CareerData, NationalSpire.RandomEventOption)`](RandomEventScreen.cs.md#symbol-8328804c1b4d)

**调用：** [`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`NationalSpire.EventStoryView.Rich(int)`](RandomEventScreen.cs.md#symbol-b60c5aa36cb9)；[`NationalSpire.EventStoryView.SetText(Godot.RichTextLabel, string)`](RandomEventScreen.cs.md#symbol-f7138d37ec2b)；[`NationalSpire.EventStoryView.Words(string, int, Godot.Color)`](RandomEventScreen.cs.md#symbol-56ea79fa7863)；[`NationalSpire.RandomEventEffects.Preview(NationalSpire.CareerData, NationalSpire.RandomEventOption)`](RandomEvents.cs.md#symbol-de44eea7b389)；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.HFlowContainer.HFlowContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.RandomEventOption.RandomEventOption()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.EventStoryView.Muted`；`NationalSpire.EventStoryView.Rich(int)`；`NationalSpire.EventStoryView.SetText(Godot.RichTextLabel, string)`；`NationalSpire.EventStoryView.Words(string, int, Godot.Color)`；`NationalSpire.RandomEventEffects.Preview(NationalSpire.CareerData, NationalSpire.RandomEventOption)`；`NationalSpire.RandomEventOption.Effects`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`label.AddThemeColorOverride("default_color", CareerVisuals.Teal)`；返回值紧邻使用处：`ExpressionStatementSyntax: label.AddThemeColorOverride("default_color", CareerVisuals.Teal);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`tiles.AddThemeConstantOverride("h_separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: tiles.AddThemeConstantOverride("h_separation", 10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`tiles.AddThemeConstantOverride("v_separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: tiles.AddThemeConstantOverride("v_separation", 10);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`card.AddThemeStyleboxOverride("panel", CareerVisuals.Box(detail ? "172d39" : "203a46", "3d5965", 7, 12))`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddThemeStyleboxOverride("panel", CareerVisuals.Box(detail ? "172d39" : "203a46", "3d5965", 7, 12));`
- `Godot.HFlowContainer.HFlowContainer()`；输入表达式：`new HFlowContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HFlowContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_effects.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: _effects.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_effects.AddChild(tiles)`；返回值紧邻使用处：`ExpressionStatementSyntax: _effects.AddChild(tiles);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_effects.AddChild(Words("这次经历带来的变化", 14, Muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: _effects.AddChild(Words("这次经历带来的变化", 14, Muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`card.AddChild(label)`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddChild(label);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`tiles.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: tiles.AddChild(card);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(detail ? 0 : 160, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: label.CustomMinimumSize = new(detail ? 0 : 160, 0)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box(detail ? "172d39" : "203a46", "3d5965", 7, 12)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box(detail ? "172d39" : "203a46", "3d5965", 7, 12)`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(_effects)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(_effects);`
- `NationalSpire.EventStoryView.Rich(int)`；输入表达式：`Rich(16)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Rich(16)`
- `NationalSpire.EventStoryView.SetText(Godot.RichTextLabel, string)`；输入表达式：`SetText(label, RandomEventEffects.Preview(data, new RandomEventOption { Effects = [effect] }))`；返回值紧邻使用处：`ExpressionStatementSyntax: SetText(label, RandomEventEffects.Preview(data, new RandomEventOption { Effects = [effect] }));`
- `NationalSpire.EventStoryView.Words(string, int, Godot.Color)`；输入表达式：`Words("这次经历带来的变化", 14, Muted)`；返回值紧邻使用处：`ArgumentSyntax: Words("这次经历带来的变化", 14, Muted)`
- `NationalSpire.RandomEventEffects.Preview(NationalSpire.CareerData, NationalSpire.RandomEventOption)`；输入表达式：`RandomEventEffects.Preview(data, new RandomEventOption { Effects = [effect] })`；返回值紧邻使用处：`ArgumentSyntax: RandomEventEffects.Preview(data, new RandomEventOption { Effects = [effect] })`
- `NationalSpire.RandomEventOption.RandomEventOption()`；输入表达式：`new RandomEventOption { Effects = [effect] }`；返回值紧邻使用处：`ArgumentSyntax: new RandomEventOption { Effects = [effect] }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`effect.ContainsKey("challenge")`；返回值紧邻使用处：`BinaryExpressionSyntax: effect.ContainsKey("impression") || effect.ContainsKey("challenge")`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`effect.ContainsKey("impression")`；返回值紧邻使用处：`BinaryExpressionSyntax: effect.ContainsKey("impression") || effect.ContainsKey("challenge")`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`effect.ContainsKey("status")`；返回值紧邻使用处：`BinaryExpressionSyntax: effect.ContainsKey("impression") || effect.ContainsKey("challenge") || effect.ContainsKey("status")`

**赋值（含属性/字段和局部值）：**

- `_effects.Visible` = `option.Effects.Count > 0`
- `Effects` = `[effect]`
- `label.CustomMinimumSize` = `new(detail ? 0 : 160, 0)`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-542a61595f6f"></a>

## `NationalSpire.EventStoryView._Process(double) — public override void _Process(double delta)`

来源：源码第 299 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Action.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.EventStoryView._poll`；`NationalSpire.EventStoryView.Tick`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Tick?.Invoke()`

**赋值（含属性/字段和局部值）：**

- `_poll` += `delta`
- `_poll` = `0`

<a id="symbol-a3ba6d73184d"></a>

## `NationalSpire.EventStoryView._ExitTree() — public override void _ExitTree()`

来源：源码第 300 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.GodotObject.Dispose()`

**字段、属性、事件及方法组引用：** `NationalSpire.EventStoryView._image`；`NationalSpire.EventStoryView._imageMaterial`；`NationalSpire.EventStoryView._ownedImage`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.Dispose()`；输入表达式：`_imageMaterial.Dispose()`；返回值紧邻使用处：`ExpressionStatementSyntax: _imageMaterial.Dispose();`
- `Godot.GodotObject.Dispose()`；输入表达式：`_imageMaterial.Shader.Dispose()`；返回值紧邻使用处：`ExpressionStatementSyntax: _imageMaterial.Shader.Dispose();`
- `Godot.GodotObject.Dispose()`；输入表达式：`.Dispose()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _ownedImage?.Dispose()`

**赋值（含属性/字段和局部值）：**

- `_image.Texture` = `null`

<a id="symbol-2fade2e67373"></a>

## `NationalSpire.EventStoryButton.Caption — public string Caption`

来源：源码第 309 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Action<T1, T2>.Invoke(T1, T2)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.EventStoryButton._caption`；`NationalSpire.EventStoryButton._captionLabel`；`NationalSpire.EventStoryButton.Paint`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Action<T1, T2>.Invoke(T1, T2)`；输入表达式：`Paint(_captionLabel, value)`；返回值紧邻使用处：`ExpressionStatementSyntax: Paint(_captionLabel, value);`

**赋值（含属性/字段和局部值）：**

- `_caption` = `value`
- `_captionLabel.Text` = `value`

<a id="symbol-d4559eeac184"></a>

## `NationalSpire.EventStoryButton.Detail — public string Detail`

来源：源码第 310 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-94b41e7adedd"></a>

## `NationalSpire.EventStoryButton.Mark — public string Mark`

来源：源码第 311 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3b729478e92e"></a>

## `NationalSpire.EventStoryButton._Ready() — public override void _Ready()`

来源：源码第 312 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`ResizeContent()`](RandomEventScreen.cs.md#symbol-5760759804d5)；`Godot.Color.Color(string)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.Label.Label()`；`Godot.MarginContainer.MarginContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.RichTextLabel.RichTextLabel()`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.EventEmblem.EventEmblem()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.EventStoryButton._caption`；`NationalSpire.EventStoryButton._captionLabel`；`NationalSpire.EventStoryButton._disabled`；`NationalSpire.EventStoryButton._hover`；`NationalSpire.EventStoryButton._normal`；`NationalSpire.EventStoryButton.Caption`；`NationalSpire.EventStoryButton.Detail`；`NationalSpire.EventStoryButton.Mark`；`ResizeContent()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new("aac1c9")`；返回值紧邻使用处：`ArgumentSyntax: new("aac1c9")`
- `Godot.Color.Color(string)`；输入表达式：`new("ecdbb9")`；返回值紧邻使用处：`ArgumentSyntax: new("ecdbb9")`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_captionLabel.AddThemeColorOverride("default_color", new("ecdbb9"))`；返回值紧邻使用处：`ExpressionStatementSyntax: _captionLabel.AddThemeColorOverride("default_color", new("ecdbb9"));`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`detail.AddThemeColorOverride("font_color", new("aac1c9"))`；返回值紧邻使用处：`ExpressionStatementSyntax: detail.AddThemeColorOverride("font_color", new("aac1c9"));`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation", 8);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`margin.AddThemeConstantOverride("margin_bottom", 17)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddThemeConstantOverride("margin_bottom", 17);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`margin.AddThemeConstantOverride("margin_left", 72)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddThemeConstantOverride("margin_left", 72);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`margin.AddThemeConstantOverride("margin_right", 20)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddThemeConstantOverride("margin_right", 20);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`margin.AddThemeConstantOverride("margin_top", 17)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddThemeConstantOverride("margin_top", 17);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`_captionLabel.AddThemeFontSizeOverride("normal_font_size", 20)`；返回值紧邻使用处：`ExpressionStatementSyntax: _captionLabel.AddThemeFontSizeOverride("normal_font_size", 20);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`detail.AddThemeFontSizeOverride("font_size", 15)`；返回值紧邻使用处：`ExpressionStatementSyntax: detail.AddThemeFontSizeOverride("font_size", 15);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`AddThemeStyleboxOverride(state, new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: AddThemeStyleboxOverride(state, new StyleBoxEmpty());`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Label.Label()`；输入表达式：`new Label { Text = Detail, AutowrapMode = TextServer.AutowrapMode.WordSmart, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Label { Text = Detail, AutowrapMode = TextServer.AutowrapMode.WordSmart, MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.MarginContainer.MarginContainer()`；输入表达式：`new MarginContainer { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MarginContainer { MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(emblem)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(emblem);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(margin)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(margin);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(_captionLabel)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(_captionLabel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(detail)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(detail);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`margin.AddChild(box)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddChild(box);`
- `Godot.RichTextLabel.RichTextLabel()`；输入表达式：`new RichTextLabel { FitContent = true, ScrollActive = false, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _captionLabel = new RichTextLabel { FitContent = true, ScrollActive = false, MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty()`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxEmpty()`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(44, 44)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Size = new(44, 44)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("17232e", "456374", 8, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _disabled = CareerVisuals.Box("17232e", "456374", 8, 0)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("1b3040", "456374", 8, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _normal = CareerVisuals.Box("1b3040", "456374", 8, 0)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("294451", "94c4bd", 8, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _hover = CareerVisuals.Box("294451", "94c4bd", 8, 0)`
- `NationalSpire.EventEmblem.EventEmblem()`；输入表达式：`new EventEmblem { Size = new(44, 44), AnchorTop = .5f, AnchorBottom = .5f, OffsetTop = -22, OffsetBottom = 22, OffsetLeft = 14, OffsetRight = 58 }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new EventEmblem { Size = new(44, 44), AnchorTop = .5f, AnchorBottom = .5f, OffsetTop = -22, OffsetBottom = 22, OffsetLeft = 14, OffsetRight = 58 }`
- `ResizeContent()`；输入表达式：`ResizeContent()`；返回值紧邻使用处：`ExpressionStatementSyntax: ResizeContent();`

**赋值（含属性/字段和局部值）：**

- `_captionLabel` = `new RichTextLabel { FitContent = true, ScrollActive = false, MouseFilter = MouseFilterEnum.Ignore }`
- `_disabled` = `CareerVisuals.Box("17232e", "456374", 8, 0)`
- `_hover` = `CareerVisuals.Box("294451", "94c4bd", 8, 0)`
- `_normal` = `CareerVisuals.Box("1b3040", "456374", 8, 0)`
- `AnchorBottom` = `.5f`
- `AnchorTop` = `.5f`
- `AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `box.MinimumSizeChanged` += `ResizeContent`
- `Caption` = `_caption`
- `FitContent` = `true`
- `FocusEntered` += `QueueRedraw`
- `FocusExited` += `QueueRedraw`
- `MouseDefaultCursorShape` = `CursorShape.PointingHand`
- `MouseEntered` += `QueueRedraw`
- `MouseExited` += `QueueRedraw`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `OffsetBottom` = `22`
- `OffsetLeft` = `14`
- `OffsetRight` = `58`
- `OffsetTop` = `-22`
- `Resized` += `QueueRedraw`
- `ScrollActive` = `false`
- `Size` = `new(44, 44)`
- `Text` = `Detail`

<a id="symbol-5760759804d5"></a>

## `ResizeContent() — void ResizeContent()`

来源：源码第 326 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EventStoryButton._Ready()`](RandomEventScreen.cs.md#symbol-3b729478e92e)

**调用：** `Godot.CanvasItem.QueueRedraw()`；`Godot.Control.GetCombinedMinimumSize()`；`Godot.Vector2.Vector2(float, float)`；`System.Math.Max(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueRedraw();`
- `Godot.Control.GetCombinedMinimumSize()`；输入表达式：`box.GetCombinedMinimumSize()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: box.GetCombinedMinimumSize().Y`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, Math.Max(88, box.GetCombinedMinimumSize().Y + 36))`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, Math.Max(88, box.GetCombinedMinimumSize().Y + 36))`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(88, box.GetCombinedMinimumSize().Y + 36)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(88, box.GetCombinedMinimumSize().Y + 36)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(0, Math.Max(88, box.GetCombinedMinimumSize().Y + 36))`

<a id="symbol-50b8d14ca5d6"></a>

## `NationalSpire.EventStoryButton._Draw() — public override void _Draw()`

来源：源码第 330 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.BaseButton.IsHovered()`；`Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawString(Godot.Font, Godot.Vector2, string, Godot.HorizontalAlignment, float, int, Godot.Color?, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation, float)`；`Godot.CanvasItem.DrawStyleBox(Godot.StyleBox, Godot.Rect2)`；`Godot.Color.Color(string)`；`Godot.Control.GetThemeFont(Godot.StringName, Godot.StringName)`；`Godot.Control.HasFocus()`；`Godot.Font.GetAscent(int)`；`Godot.Font.GetDescent(int)`；`Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.Vector2.Vector2(float, float)`；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.EventStoryButton._disabled`；`NationalSpire.EventStoryButton._hover`；`NationalSpire.EventStoryButton._normal`；`NationalSpire.EventStoryButton.Mark`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.BaseButton.IsHovered()`；输入表达式：`IsHovered()`；返回值紧邻使用处：`BinaryExpressionSyntax: IsHovered() || HasFocus()`
- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(c, 18, 0, Mathf.Tau, 40, edge, 1, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(c, 18, 0, Mathf.Tau, 40, edge, 1, true);`
- `Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；输入表达式：`DrawCircle(c, 18, new Color("10212d"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawCircle(c, 18, new Color("10212d"));`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(new(14, 1), new(Math.Min(66, w - 14), 1), new("c9b27d"), 2, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(new(14, 1), new(Math.Min(66, w - 14), 1), new("c9b27d"), 2, true);`
- `Godot.CanvasItem.DrawString(Godot.Font, Godot.Vector2, string, Godot.HorizontalAlignment, float, int, Godot.Color?, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation, float)`；输入表达式：`DrawString(font, c + new Vector2(-width / 2, (font.GetAscent(size) - font.GetDescent(size)) / 2), Mark, fontSize: size, modulate: new("dfc994"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawString(font, c + new Vector2(-width / 2, (font.GetAscent(size) - font.GetDescent(size)) / 2), Mark, fontSize: size, modulate: new("dfc994"));`
- `Godot.CanvasItem.DrawStyleBox(Godot.StyleBox, Godot.Rect2)`；输入表达式：`DrawStyleBox(Disabled ? _disabled : active ? _hover : _normal, new Rect2(Vector2.Zero, Size))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawStyleBox(Disabled ? _disabled : active ? _hover : _normal, new Rect2(Vector2.Zero, Size));`
- `Godot.Color.Color(string)`；输入表达式：`new Color("10212d")`；返回值紧邻使用处：`ArgumentSyntax: new Color("10212d")`
- `Godot.Color.Color(string)`；输入表达式：`new("c9b27d")`；返回值紧邻使用处：`ArgumentSyntax: new("c9b27d")`
- `Godot.Color.Color(string)`；输入表达式：`new("dfc994")`；返回值紧邻使用处：`ArgumentSyntax: modulate: new("dfc994")`
- `Godot.Color.Color(string)`；输入表达式：`new(active ? "94c4bd" : "456374")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new(active ? "94c4bd" : "456374")`
- `Godot.Control.GetThemeFont(Godot.StringName, Godot.StringName)`；输入表达式：`GetThemeFont("font")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GetThemeFont("font")`
- `Godot.Control.HasFocus()`；输入表达式：`HasFocus()`；返回值紧邻使用处：`BinaryExpressionSyntax: IsHovered() || HasFocus()`
- `Godot.Font.GetAscent(int)`；输入表达式：`font.GetAscent(size)`；返回值紧邻使用处：`BinaryExpressionSyntax: font.GetAscent(size) - font.GetDescent(size)`
- `Godot.Font.GetDescent(int)`；输入表达式：`font.GetDescent(size)`；返回值紧邻使用处：`BinaryExpressionSyntax: font.GetAscent(size) - font.GetDescent(size)`
- `Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；输入表达式：`font.GetStringSize(Mark, fontSize: size)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: font.GetStringSize(Mark, fontSize: size).X`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(Vector2.Zero, Size)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(Vector2.Zero, Size)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-width / 2, (font.GetAscent(size) - font.GetDescent(size)) / 2)`；返回值紧邻使用处：`BinaryExpressionSyntax: c + new Vector2(-width / 2, (font.GetAscent(size) - font.GetDescent(size)) / 2)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(35, h / 2)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Vector2(35, h / 2)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(14, 1)`；返回值紧邻使用处：`ArgumentSyntax: new(14, 1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(Math.Min(66, w - 14), 1)`；返回值紧邻使用处：`ArgumentSyntax: new(Math.Min(66, w - 14), 1)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(66, w - 14)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(66, w - 14)`

**赋值（含属性/字段和局部值）：**
