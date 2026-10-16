# PromptTestScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`80F6242613512D749185A2A32F0B2CB5C83FDC716D51909B87FAA3EB6FC7D885`。来源：[源码](../../PromptTestScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
private PromptTestSession? _promptTestSession;
private Action? _closePromptTest;
```

<a id="symbol-4e150abf093b"></a>

## `NationalSpire.CareerScreen.OpenPromptTest(NationalSpire.CareerData, Godot.Control, System.Collections.Generic.Dictionary<string, string>, string) — private void OpenPromptTest(CareerData data, Control editor, Dictionary<string, string> drafts, string section)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenPromptSettings(NationalSpire.CareerData)`](PromptScreen.cs.md#symbol-fda1b116cf88)

**调用：** [`ChooseSources()`](PromptTestScreen.cs.md#symbol-b495d2c3d047)；[`NationalSpire.AiService.Connection(NationalSpire.AiOptions, string)`](AiService.cs.md#symbol-8c02bb75b41a)；[`NationalSpire.AiService.TestPromptAsync(NationalSpire.CareerData, NationalSpire.PromptTestSession, System.Collections.Generic.IReadOnlyDictionary<string, string>, bool)`](PromptTesting.cs.md#symbol-48585ad62c60)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`](CareerDialog.cs.md#symbol-d832b736b02b)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`Prepare()`](PromptTestScreen.cs.md#symbol-bb12916e300a)；[`Preview(string, string)`](PromptTestScreen.cs.md#symbol-ef689470fe03)；[`Refresh()`](PromptTestScreen.cs.md#symbol-e609e93f16bf)；[`ShowMaterial()`](PromptTestScreen.cs.md#symbol-ba102e81e6b8)；`Godot.CanvasItem.Hide()`；`Godot.Color.Color(float, float, float, float)`；`Godot.ColorRect.ColorRect()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.MarginContainer.MarginContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.OptionButton()`；`Godot.OptionButton.Select(int)`；`Godot.TextEdit.TextEdit()`；`Godot.Timer.Timer()`；`Godot.Vector2.Vector2(float, float)`；`System.Array.IndexOf<T>(T[], T)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IDictionary<TKey, TValue>)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Uri.GetLeftPart(System.UriPartial)`；`System.Uri.TryCreate(string?, System.UriKind, out System.Uri?)`

**字段、属性、事件及方法组引用：** `ChooseSources()`；`CloseTest()`；`NationalSpire.AiConnection.Endpoint`；`NationalSpire.AiService.Connection(NationalSpire.AiOptions, string)`；`NationalSpire.AiService.TestPromptAsync(NationalSpire.CareerData, NationalSpire.PromptTestSession, System.Collections.Generic.IReadOnlyDictionary<string, string>, bool)`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerScreen._closePromptTest`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._promptTestSession`；`NationalSpire.CareerScreen._stage`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.PromptTestSession.Message`；`NationalSpire.PromptTestSession.Running`；`NationalSpire.PromptTestSession.Source`；`NationalSpire.PromptTestSource.Scene`；`Prepare()`；`Preview(string, string)`；`Refresh()`；`ShowMaterial()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `ChooseSources()`；输入表达式：`ChooseSources()`；返回值紧邻使用处：`ExpressionStatementSyntax: ChooseSources();`
- `Godot.CanvasItem.Hide()`；输入表达式：`editor.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: editor.Hide();`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(0, 0, 0, .85f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Color = new Color(0, 0, 0, .85f)`
- `Godot.ColorRect.ColorRect()`；输入表达式：`new ColorRect { Name = "PromptTest", Color = new Color(0, 0, 0, .85f), MouseFilter = MouseFilterEnum.Stop, ZIndex = 30 }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ColorRect { Name = "PromptTest", Color = new Color(0, 0, 0, .85f), MouseFilter = MouseFilterEnum.Stop, ZIndex = 30 }`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`actions.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`compare.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: compare.AddThemeConstantOverride("separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`margin.AddThemeConstantOverride("margin_" + edge, 45)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddThemeConstantOverride("margin_" + edge, 45);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`material.AddThemeFontSizeOverride("font_size", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: material.AddThemeFontSizeOverride("font_size", 16);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`message.AddThemeFontSizeOverride("font_size", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: message.AddThemeFontSizeOverride("font_size", 18);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { SizeFlagsVertical = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { SizeFlagsVertical = SizeFlags.ExpandFill }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.MarginContainer.MarginContainer()`；输入表达式：`new MarginContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MarginContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_stage.AddChild(shade)`；返回值紧邻使用处：`ExpressionStatementSyntax: _stage.AddChild(shade);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(Button("返回编辑", CloseTest, 170))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(Button("返回编辑", CloseTest, 170));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(inspect)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(inspect);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(send)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(send);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(actions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(compare)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(compare);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(material)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(material);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(message)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(message);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(status)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(status);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text("使用当前编辑。每次试写调用一次 AI，仅在这里预览，保留前后两次结果供比较。", 17, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text("使用当前编辑。每次试写调用一次 AI，仅在这里预览，保留前后两次结果供比较。", 17, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text("提示词试写", 28, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text("提示词试写", 28, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`margin.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddChild(panel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(sceneChoice)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(sceneChoice);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(sourceChoice)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(sourceChoice);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`shade.AddChild(margin)`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.AddChild(margin);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`shade.AddChild(timer)`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.AddChild(timer);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`sceneChoice.AddItem(sceneNames[i])`；返回值紧邻使用处：`ExpressionStatementSyntax: sceneChoice.AddItem(sceneNames[i]);`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { Name = "PromptTestScene", CustomMinimumSize = new Vector2(250, 48) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { Name = "PromptTestScene", CustomMinimumSize = new Vector2(250, 48) }`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { Name = "PromptTestSource", SizeFlagsHorizontal = SizeFlags.ExpandFill, FitToLongestItem = false, TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { Name = "PromptTestSource", SizeFlagsHorizontal = SizeFlags.ExpandFill, FitToLongestItem = false, TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis }`
- `Godot.OptionButton.Select(int)`；输入表达式：`sceneChoice.Select(Array.IndexOf(scenes, scene))`；返回值紧邻使用处：`ExpressionStatementSyntax: sceneChoice.Select(Array.IndexOf(scenes, scene));`
- `Godot.TextEdit.TextEdit()`；输入表达式：`new TextEdit { Name = "PromptTestMaterial", Editable = false, Visible = false, SizeFlagsVertical = SizeFlags.ExpandFill, WrapMode = TextEdit.LineWrappingMode.Boundary }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TextEdit { Name = "PromptTestMaterial", Editable = false, Visible = false, SizeFlagsVertical = SizeFlags.ExpandFill, WrapMode = TextEdit.LineWrappingMode.Boundary }`
- `Godot.TextEdit.TextEdit()`；输入表达式：`new TextEdit { Name = "PromptTestMessage", PlaceholderText = "填写要让社区回应的测试留言……", CustomMinimumSize = new Vector2(0, 90), WrapMode = TextEdit.LineWrappingMode.Boundary }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TextEdit { Name = "PromptTestMessage", PlaceholderText = "填写要让社区回应的测试留言……", CustomMinimumSize = new Vector2(0, 90), WrapMode = TextEdit.LineWrappingMode.Boundary }`
- `Godot.Timer.Timer()`；输入表达式：`new Godot.Timer { WaitTime = .25, Autostart = true }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Godot.Timer { WaitTime = .25, Autostart = true }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, 90)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(0, 90)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(250, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(250, 48)`
- `NationalSpire.AiService.Connection(NationalSpire.AiOptions, string)`；输入表达式：`AiService.Connection(data.Ai, test.Source.Scene)`；返回值紧邻使用处：`BinaryExpressionSyntax: AiService.Connection(data.Ai, test.Source.Scene) != connection`
- `NationalSpire.AiService.Connection(NationalSpire.AiOptions, string)`；输入表达式：`AiService.Connection(data.Ai, test.Source.Scene)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AiService.Connection(data.Ai, test.Source.Scene)`
- `NationalSpire.AiService.TestPromptAsync(NationalSpire.CareerData, NationalSpire.PromptTestSession, System.Collections.Generic.IReadOnlyDictionary<string, string>, bool)`；输入表达式：`AiService.TestPromptAsync(data, test, new Dictionary<string, string>(drafts), confirmedExternalSend: true)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AiService.TestPromptAsync(data, test, new Dictionary<string, string>(drafts), confirmedExternalSend: true)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("查看本次材料", () => { showingMaterial = !showingMaterial; material.Visible = showingMaterial; compare.Visible = !showingMaterial; if (showingMaterial) ShowMaterial(); }, 210)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("查看本次材料", () => { showingMaterial = !showingMaterial; material.Visible = showingMaterial; compare.Visible = !showingMaterial; if (showingMaterial) ShowMaterial(); }, 210)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("返回编辑", CloseTest, 170)`；返回值紧邻使用处：`ArgumentSyntax: Button("返回编辑", CloseTest, 170)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("开始测试", () =>          {              if (_promptTestSession?.Running == true) return;              try              {                  localError = "";                  var test = Prepare();                  var connection = AiService.Connection(data.Ai, test.Source.Scene);                  string endpoint = connection.Endpoint;                  string service = Uri.TryCreate(endpoint, UriKind.Absolute, out var address) ? address.GetLeftPart(UriPartial.Authority) : "尚未填写有效地址";                  ShowCareerDialog("确认试写", $"向 {service} 发送所选材料、相关人物与历史记录，以及当前编辑的提示词？\n消耗一次 AI 请求。结果仅供预览，材料可在“查看本次材料”中检查。", () =>                  {                      if (AiService.Connection(data.Ai, test.Source.Scene) != connection) { localError = "接收地址已改变，请重新确认。"; return true; }                      _ = AiService.TestPromptAsync(data, test, new Dictionary<string, string>(drafts), confirmedExternalSend: true);                      Refresh();                      return true;                  }, "发送并测试");              }              catch (Exception e) { localError = e.Message; status.Text = e.Message; }          }, 180)`；返回值紧邻使用处：`AssignmentExpressionSyntax: send = Button("开始测试", () =>          {              if (_promptTestSession?.Running == true) return;              try              {                  localError = "";                  var test = Prepare();                  var connection = AiService.Connection(data.Ai, test.Source.Scene);                  string endpoint = connection.Endpoint;                  string service = Uri.TryCreate(endpoint, UriKind.Absolute, out var address) ? address.GetLeftPart(UriPartial.Authority) : "尚未填写有效地址";                  ShowCareerDialog("确认试写", $"向 {service} 发送所选材料、相关人物与历史记录，以及当前编辑的提示词？\n消耗一次 AI 请求。结果仅供预览，材料可在“查看本次材料”中检查。", () =>                  {                      if (AiService.Connection(data.Ai, test.Source.Scene) != connection) { localError = "接收地址已改变，请重新确认。"; return true; }                      _ = AiService.TestPromptAsync(data, test, new Dictionary<string, string>(drafts), confirmedExternalSend: true);                      Refresh();                      return true;                  }, "发送并测试");              }              catch (Exception e) { localError = e.Message; status.Text = e.Message; }          }, 180)`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(panel)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(panel)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；输入表达式：`ShowCareerDialog("确认试写", $"向 {service} 发送所选材料、相关人物与历史记录，以及当前编辑的提示词？\n消耗一次 AI 请求。结果仅供预览，材料可在“查看本次材料”中检查。", () =>                  {                      if (AiService.Connection(data.Ai, test.Source.Scene) != connection) { localError = "接收地址已改变，请重新确认。"; return true; }                      _ = AiService.TestPromptAsync(data, test, new Dictionary<string, string>(drafts), confirmedExternalSend: true);                      Refresh();                      return true;                  }, "发送并测试")`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("确认试写", $"向 {service} 发送所选材料、相关人物与历史记录，以及当前编辑的提示词？\n消耗一次 AI 请求。结果仅供预览，材料可在“查看本次材料”中检查。", () =>                  {                      if (AiService.Connection(data.Ai, test.Source.Scene) != connection) { localError = "接收地址已改变，请重新确认。"; return true; }                      _ = AiService.TestPromptAsync(data, test, new Dictionary<string, string>(drafts), confirmedExternalSend: true);                      Refresh();                      return true;                  }, "发送并测试");`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 16, CareerVisuals.Teal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("", 16, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("使用当前编辑。每次试写调用一次 AI，仅在这里预览，保留前后两次结果供比较。", 17, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("使用当前编辑。每次试写调用一次 AI，仅在这里预览，保留前后两次结果供比较。", 17, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("提示词试写", 28, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("提示词试写", 28, _gold)`
- `Prepare()`；输入表达式：`Prepare()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Prepare()`
- `Preview(string, string)`；输入表达式：`Preview("上一次", "PromptTestPrevious")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Preview("上一次", "PromptTestPrevious")`
- `Preview(string, string)`；输入表达式：`Preview("这一次", "PromptTestCurrent")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Preview("这一次", "PromptTestCurrent")`
- `Refresh()`；输入表达式：`Refresh()`；返回值紧邻使用处：`ExpressionStatementSyntax: Refresh();`
- `ShowMaterial()`；输入表达式：`ShowMaterial()`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowMaterial();`
- `System.Array.IndexOf<T>(T[], T)`；输入表达式：`Array.IndexOf(scenes, scene)`；返回值紧邻使用处：`ArgumentSyntax: Array.IndexOf(scenes, scene)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IDictionary<TKey, TValue>)`；输入表达式：`new Dictionary<string, string>(drafts)`；返回值紧邻使用处：`ArgumentSyntax: new Dictionary<string, string>(drafts)`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`scenes.Contains(section)`；返回值紧邻使用处：`ConditionalExpressionSyntax: scenes.Contains(section) ? section : "news"`
- `System.Uri.GetLeftPart(System.UriPartial)`；输入表达式：`address.GetLeftPart(UriPartial.Authority)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Uri.TryCreate(endpoint, UriKind.Absolute, out var address) ? address.GetLeftPart(UriPartial.Authority) : "尚未填写有效地址"`
- `System.Uri.TryCreate(string?, System.UriKind, out System.Uri?)`；输入表达式：`Uri.TryCreate(endpoint, UriKind.Absolute, out var address)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Uri.TryCreate(endpoint, UriKind.Absolute, out var address) ? address.GetLeftPart(UriPartial.Authority) : "尚未填写有效地址"`

**赋值（含属性/字段和局部值）：**

- `_` = `AiService.TestPromptAsync(data, test, new Dictionary<string, string>(drafts), confirmedExternalSend: true)`
- `_closePromptTest` = `CloseTest`
- `Autostart` = `true`
- `Color` = `new Color(0, 0, 0, .85f)`
- `compare.Visible` = `!showingMaterial`
- `CustomMinimumSize` = `new Vector2(0, 90)`
- `CustomMinimumSize` = `new Vector2(250, 48)`
- `Editable` = `false`
- `FitToLongestItem` = `false`
- `localError` = `""`
- `localError` = `"接收地址已改变，请重新确认。"`
- `localError` = `e.Message`
- `material.Visible` = `showingMaterial`
- `message.Text` = `_promptTestSession?.Message ?? ""`
- `message.TextChanged` += `() => { if (showingMaterial && _promptTestSession?.Running != true) ShowMaterial(); }`
- `MouseFilter` = `MouseFilterEnum.Stop`
- `Name` = `"PromptTest"`
- `Name` = `"PromptTestMaterial"`
- `Name` = `"PromptTestMessage"`
- `Name` = `"PromptTestScene"`
- `Name` = `"PromptTestSource"`
- `PlaceholderText` = `"填写要让社区回应的测试留言……"`
- `scene` = `scenes[(int)index]`
- `sceneChoice.ItemSelected` += `index => { localError = ""; scene = scenes[(int)index]; ChooseSources(); if (showingMaterial) ShowMaterial(); }`
- `send` = `Button("开始测试", () =>          {              if (_promptTestSession?.Running == true) return;              try              {                  localError = "";                  var test = Prepare();                  var connection = AiService.Connection(data.Ai, test.Source.Scene);                  string endpoint = connection.Endpoint;                  string service = Uri.TryCreate(endpoint, UriKind.Absolute, out var address) ? address.GetLeftPart(UriPartial.Authority) : "尚未填写有效地址";                  ShowCareerDialog("确认试写", $"向 {service} 发送所选材料、相关人物与历史记录，以及当前编辑的提示词？\n消耗一次 AI 请求。结果仅供预览，材料可在“查看本次材料”中检查。", () =>                  {                      if (AiService.Connection(data.Ai, test.Source.Scene) != connection) { localError = "接收地址已改变，请重新确认。"; return true; }                      _ = AiService.TestPromptAsync(data, test, new Dictionary<string, string>(drafts), confirmedExternalSend: true);                      Refresh();                      return true;                  }, "发送并测试");              }              catch (Exception e) { localError = e.Message; status.Text = e.Message; }          }, 180)`
- `showingMaterial` = `!showingMaterial`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ExpandFill`
- `sourceChoice.ItemSelected` += `_ => { localError = ""; if (showingMaterial) ShowMaterial(); }`
- `status.Text` = `e.Message`
- `TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`
- `timer.Timeout` += `Refresh`
- `Visible` = `false`
- `WaitTime` = `.25`
- `WrapMode` = `TextEdit.LineWrappingMode.Boundary`
- `ZIndex` = `30`

<a id="symbol-ef689470fe03"></a>

## `Preview(string, string) — TextEdit Preview(string title, string name)`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenPromptTest(NationalSpire.CareerData, Godot.Control, System.Collections.Generic.Dictionary<string, string>, string)`](PromptTestScreen.cs.md#symbol-4e150abf093b)

**调用：** [`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.TextEdit.TextEdit()`；`Godot.VBoxContainer.VBoxContainer()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`text.AddThemeFontSizeOverride("font_size", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: text.AddThemeFontSizeOverride("font_size", 18);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`column.AddChild(Text(title, 18, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddChild(Text(title, 18, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`column.AddChild(text)`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddChild(text);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`compare.AddChild(column)`；返回值紧邻使用处：`ExpressionStatementSyntax: compare.AddChild(column);`
- `Godot.TextEdit.TextEdit()`；输入表达式：`new TextEdit { Name = name, Editable = false, SizeFlagsVertical = SizeFlags.ExpandFill, WrapMode = TextEdit.LineWrappingMode.Boundary }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TextEdit { Name = name, Editable = false, SizeFlagsVertical = SizeFlags.ExpandFill, WrapMode = TextEdit.LineWrappingMode.Boundary }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(title, 18, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(title, 18, _gold)`

**赋值（含属性/字段和局部值）：**

- `Editable` = `false`
- `Name` = `name`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ExpandFill`
- `WrapMode` = `TextEdit.LineWrappingMode.Boundary`

<a id="symbol-b495d2c3d047"></a>

## `ChooseSources() — void ChooseSources()`

来源：源码第 49 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenPromptTest(NationalSpire.CareerData, Godot.Control, System.Collections.Generic.Dictionary<string, string>, string)`](PromptTestScreen.cs.md#symbol-4e150abf093b)

**调用：** [`NationalSpire.AiService.TestSources(NationalSpire.CareerData, string)`](PromptTesting.cs.md#symbol-bac6770dfaa1)；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.Clear()`；`Godot.OptionButton.Select(int)`；`System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.TestSources(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen._promptTestSession`；`NationalSpire.PromptTestSession.Source`；`NationalSpire.PromptTestSource.Label`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`sourceChoice.AddItem("当前还没有可用材料")`；返回值紧邻使用处：`ExpressionStatementSyntax: sourceChoice.AddItem("当前还没有可用材料");`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`sourceChoice.AddItem(source.Label)`；返回值紧邻使用处：`ExpressionStatementSyntax: sourceChoice.AddItem(source.Label);`
- `Godot.OptionButton.Clear()`；输入表达式：`sourceChoice.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: sourceChoice.Clear();`
- `Godot.OptionButton.Select(int)`；输入表达式：`sourceChoice.Select(Math.Max(0, remembered))`；返回值紧邻使用处：`ExpressionStatementSyntax: sourceChoice.Select(Math.Max(0, remembered));`
- `NationalSpire.AiService.TestSources(NationalSpire.CareerData, string)`；输入表达式：`AiService.TestSources(data, scene)`；返回值紧邻使用处：`AssignmentExpressionSyntax: sources = AiService.TestSources(data, scene)`
- `System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；输入表达式：`sources.FindIndex(s => s == _promptTestSession?.Source)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = sources.FindIndex(s => s == _promptTestSession?.Source)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, remembered)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, remembered)`

**赋值（含属性/字段和局部值）：**

- `message.Visible` = `scene == "discussion"`
- `sources` = `AiService.TestSources(data, scene)`

<a id="symbol-bb12916e300a"></a>

## `Prepare() — PromptTestSession Prepare()`

来源：源码第 58 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenPromptTest(NationalSpire.CareerData, Godot.Control, System.Collections.Generic.Dictionary<string, string>, string)`](PromptTestScreen.cs.md#symbol-4e150abf093b)；[`ShowMaterial()`](PromptTestScreen.cs.md#symbol-ba102e81e6b8)

**调用：** [`NationalSpire.AiService.CreateTestSession(NationalSpire.CareerData, NationalSpire.PromptTestSource, string)`](PromptTesting.cs.md#symbol-c81f52ee7090)；`System.ArgumentException.ArgumentException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.CreateTestSession(NationalSpire.CareerData, NationalSpire.PromptTestSource, string)`；`NationalSpire.CareerScreen._promptTestSession`；`NationalSpire.PromptTestSession.Message`；`NationalSpire.PromptTestSession.Running`；`NationalSpire.PromptTestSession.Source`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.CreateTestSession(NationalSpire.CareerData, NationalSpire.PromptTestSource, string)`；输入表达式：`AiService.CreateTestSession(data, source, message.Text)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _promptTestSession = AiService.CreateTestSession(data, source, message.Text)`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("当前场景还没有可用材料，请选择其他场景。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("当前场景还没有可用材料，请选择其他场景。");`

**赋值（含属性/字段和局部值）：**

- `_promptTestSession` = `AiService.CreateTestSession(data, source, message.Text)`

<a id="symbol-ba102e81e6b8"></a>

## `ShowMaterial() — void ShowMaterial()`

来源：源码第 67 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenPromptTest(NationalSpire.CareerData, Godot.Control, System.Collections.Generic.Dictionary<string, string>, string)`](PromptTestScreen.cs.md#symbol-4e150abf093b)

**调用：** [`Prepare()`](PromptTestScreen.cs.md#symbol-bb12916e300a)；`System.Text.Json.JsonDocument.Parse(string, System.Text.Json.JsonDocumentOptions)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；`System.Text.Json.JsonSerializerOptions.JsonSerializerOptions()`

**字段、属性、事件及方法组引用：** `NationalSpire.PromptTestSession.Context`；`Prepare()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Prepare()`；输入表达式：`Prepare()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Prepare()`
- `System.Text.Json.JsonDocument.Parse(string, System.Text.Json.JsonDocumentOptions)`；输入表达式：`System.Text.Json.JsonDocument.Parse(test.Context)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = System.Text.Json.JsonDocument.Parse(test.Context)`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`System.Text.Json.JsonSerializer.Serialize(parsed.RootElement, new System.Text.Json.JsonSerializerOptions                      { WriteIndented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping })`；返回值紧邻使用处：`AssignmentExpressionSyntax: material.Text = System.Text.Json.JsonSerializer.Serialize(parsed.RootElement, new System.Text.Json.JsonSerializerOptions                      { WriteIndented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping })`
- `System.Text.Json.JsonSerializerOptions.JsonSerializerOptions()`；输入表达式：`new System.Text.Json.JsonSerializerOptions                      { WriteIndented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping }`；返回值紧邻使用处：`ArgumentSyntax: new System.Text.Json.JsonSerializerOptions                      { WriteIndented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping }`

**赋值（含属性/字段和局部值）：**

- `Encoder` = `System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping`
- `localError` = `""`
- `localError` = `e.Message`
- `material.Text` = `e.Message`
- `material.Text` = `System.Text.Json.JsonSerializer.Serialize(parsed.RootElement, new System.Text.Json.JsonSerializerOptions                      { WriteIndented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping })`
- `WriteIndented` = `true`

<a id="symbol-4541f5c07cf7"></a>

## `CloseTest() — void CloseTest()`

来源：源码第 103 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.Hide()`；`Godot.CanvasItem.Show()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Node.QueueFree()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._closePromptTest`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`shade.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.Hide();`
- `Godot.CanvasItem.Show()`；输入表达式：`editor.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: editor.Show();`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(editor)`；返回值紧邻使用处：`IfStatementSyntax: if (IsInstanceValid(editor)) editor.Show();`
- `Godot.Node.QueueFree()`；输入表达式：`shade.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.QueueFree();`

**赋值（含属性/字段和局部值）：**

- `_closePromptTest` = `null`

<a id="symbol-e609e93f16bf"></a>

## `Refresh() — void Refresh()`

来源：源码第 113 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenPromptTest(NationalSpire.CareerData, Godot.Control, System.Collections.Generic.Dictionary<string, string>, string)`](PromptTestScreen.cs.md#symbol-4e150abf093b)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.AiWorkState.Error`；`NationalSpire.AiWorkState.State`；`NationalSpire.AiWorkState.WaitReason`；`NationalSpire.CareerScreen._promptTestSession`；`NationalSpire.PromptTestSession.Previous`；`NationalSpire.PromptTestSession.Result`；`NationalSpire.PromptTestSession.Running`；`NationalSpire.PromptTestSession.Work`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `current.Text` = `test?.Result ?? ""`
- `message.Editable` = `!busy`
- `previous.Text` = `test?.Previous ?? ""`
- `sceneChoice.Disabled` = `busy`
- `send.Disabled` = `busy || sources.Count == 0`
- `send.Text` = `test == null || test.Work.State == "idle" ? "开始测试" : "重新测试"`
- `sourceChoice.Disabled` = `busy`
- `status.Text` = `localError`
- `status.Text` = `sources.Count == 0 ? "当前场景还没有可用材料，请选择其他场景。" : "选择材料后开始测试。"`
- `status.Text` = `test.Work.State switch {                  "queued" => test.Work.WaitReason.Length > 0 ? test.Work.WaitReason : "正在等候空闲位置……",                  "sending" => "正在试写，可以返回继续编辑。",                  "completed" => "试写完成。同一材料可重新测试，或返回编辑后再比较。",                  "failed" => test.Work.Error,                  _ => "材料已经选好，点击开始测试。" }`
