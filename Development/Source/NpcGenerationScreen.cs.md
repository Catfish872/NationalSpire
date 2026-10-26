# NpcGenerationScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`471CF889E52CFC285B6DE31B9B6D164FE069A5A59C9973DE848729A772225281`。来源：[源码](../../NpcGenerationScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
private bool _npcSetupOpening;
```

<a id="symbol-4a76a0da98d8"></a>

## `NationalSpire.CareerScreen.SelectNpcGeneration(Godot.Control, NationalSpire.AiOptions, System.Func<NationalSpire.NpcGenerationSetup, System.Threading.Tasks.Task>, System.Action?) — internal static void SelectNpcGeneration(Control parent, AiOptions ai, Func<NpcGenerationSetup, Task> selected, Action? cancelled = null)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopScreen.Connect(bool, string, int, string, string, string, NationalSpire.NpcGenerationSetup?, bool)`](Coop/CoopScreen.cs.md#symbol-af359fd6d523)

**调用：** `Godot.Control.Control()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.QueueFree()`；`Godot.Node.SetProcess(bool)`；`NationalSpire.CareerScreen.CareerScreen()`；[`NationalSpire.CareerScreen.FitStage()`](CareerScreen.cs.md#symbol-67c6fd5d17bc)；[`NationalSpire.CareerScreen.OpenNpcGeneration(NationalSpire.AiOptions, System.Action<NationalSpire.NpcGenerationSetup>, bool, System.Func<NationalSpire.NpcGenerationSetup, System.Threading.Tasks.Task>?, int, bool)`](NpcGenerationScreen.cs.md#symbol-fa734ac20da4)；[`NationalSpire.CareerVisuals.CreateTheme()`](CareerVisuals.cs.md#symbol-a5f88af9f360)；`System.Action.Invoke()`；`System.Func<T, TResult>.Invoke(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.FitStage()`；`NationalSpire.CareerScreen.OpenNpcGeneration(NationalSpire.AiOptions, System.Action<NationalSpire.NpcGenerationSetup>, bool, System.Func<NationalSpire.NpcGenerationSetup, System.Threading.Tasks.Task>?, int, bool)`；`NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.CareerScreen._stage`；`NationalSpire.CareerVisuals.CreateTheme()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.Control()`；输入表达式：`new Control()`；返回值紧邻使用处：`AssignmentExpressionSyntax: screen._stage = new Control()`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`screen.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: screen.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`screen.IsQueuedForDeletion()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !screen.IsQueuedForDeletion()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(screen)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(screen);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`screen.AddChild(screen._stage)`；返回值紧邻使用处：`ExpressionStatementSyntax: screen.AddChild(screen._stage);`
- `Godot.Node.QueueFree()`；输入表达式：`screen.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: screen.QueueFree();`
- `Godot.Node.SetProcess(bool)`；输入表达式：`screen.SetProcess(false)`；返回值紧邻使用处：`ExpressionStatementSyntax: screen.SetProcess(false);`
- `NationalSpire.CareerScreen.CareerScreen()`；输入表达式：`new CareerScreen { Theme = CareerVisuals.CreateTheme() }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CareerScreen { Theme = CareerVisuals.CreateTheme() }`
- `NationalSpire.CareerScreen.FitStage()`；输入表达式：`screen.FitStage()`；返回值紧邻使用处：`ExpressionStatementSyntax: screen.FitStage();`
- `NationalSpire.CareerScreen.OpenNpcGeneration(NationalSpire.AiOptions, System.Action<NationalSpire.NpcGenerationSetup>, bool, System.Func<NationalSpire.NpcGenerationSetup, System.Threading.Tasks.Task>?, int, bool)`；输入表达式：`screen.OpenNpcGeneration(ai, _ => { }, selectedAsync: async plan => { await selected(plan); complete = true; }, team: true)`；返回值紧邻使用处：`ExpressionStatementSyntax: screen.OpenNpcGeneration(ai, _ => { }, selectedAsync: async plan => { await selected(plan); complete = true; }, team: true);`
- `NationalSpire.CareerVisuals.CreateTheme()`；输入表达式：`CareerVisuals.CreateTheme()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Theme = CareerVisuals.CreateTheme()`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: cancelled?.Invoke()`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`selected(plan)`；返回值紧邻使用处：`AwaitExpressionSyntax: await selected(plan)`

**赋值（含属性/字段和局部值）：**

- `Theme` = `CareerVisuals.CreateTheme()`
- `complete` = `true`
- `screen.Resized` += `screen.FitStage`
- `screen._dialogOverlay!.TreeExiting` += `() => { if (!complete) cancelled?.Invoke(); if (!screen.IsQueuedForDeletion()) screen.QueueFree(); }`
- `screen._stage` = `new Control()`

<a id="symbol-fa734ac20da4"></a>

## `NationalSpire.CareerScreen.OpenNpcGeneration(NationalSpire.AiOptions, System.Action<NationalSpire.NpcGenerationSetup>, bool, System.Func<NationalSpire.NpcGenerationSetup, System.Threading.Tasks.Task>?, int, bool) — private void OpenNpcGeneration(AiOptions ai, Action<NpcGenerationSetup> selected, bool required = false, Func<NpcGenerationSetup, Task>? selectedAsync = null, int rivalLevel = 1000, bool team = false)`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BeginNpcSetup(bool)`](NpcGenerationScreen.cs.md#symbol-b4785dd51d2b)；[`NationalSpire.CareerScreen.SelectNpcGeneration(Godot.Control, NationalSpire.AiOptions, System.Func<NationalSpire.NpcGenerationSetup, System.Threading.Tasks.Task>, System.Action?)`](NpcGenerationScreen.cs.md#symbol-4a76a0da98d8)

**调用：** [`Files()`](NpcGenerationScreen.cs.md#symbol-bbc9ef0af3ad)；`Godot.CanvasItem.QueueRedraw()`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.GridContainer.GridContainer()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.HSeparator.HSeparator()`；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.GetItemId(int)`；`Godot.OptionButton.GetItemText(int)`；`Godot.OptionButton.OptionButton()`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；[`Input(Godot.VBoxContainer, string, string, string)`](NpcGenerationScreen.cs.md#symbol-889f6f04d436)；`NationalSpire.AiConnectionProfile.AiConnectionProfile()`；[`NationalSpire.AiRouting.Ensure(NationalSpire.AiOptions)`](AiRouting.cs.md#symbol-7a203ffde56e)；[`NationalSpire.AiService.HasProfileKey(string)`](AiService.cs.md#symbol-79f735f59baf)；[`NationalSpire.AiService.PersistKey(string, string)`](AiService.cs.md#symbol-017daf4a239c)；[`NationalSpire.AiSettingsPanel.RivalLevelPicker(int, bool)`](AiSettingsPanel.cs.md#symbol-6ea5b8b2d06c)；`NationalSpire.BroadcastScroll.BroadcastScroll()`；`NationalSpire.CareerDisclosureButton.CareerDisclosureButton()`；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.PickNestedFile(string, string[], System.Action<string>, System.Action<string[]>?)`](CareerFilePicker.cs.md#symbol-ca0ccac08c64)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.Coop.CoopJson.Copy<T>(T)`](Coop/CoopData.cs.md#symbol-38a51b2b1811)；`NationalSpire.NpcGenerationSetup.NpcGenerationSetup()`；[`NationalSpire.PercentageSlider.Commit()`](PercentageSlider.cs.md#symbol-013abce752a0)；[`NationalSpire.PersonalityPools.Import(string)`](PersonalityPools.cs.md#symbol-a524890425ed)；[`NationalSpire.PersonalityPools.Read(NationalSpire.AiOptions)`](PersonalityPools.cs.md#symbol-80fcf785b385)；[`NationalSpire.PersonalityPools.Validate(NationalSpire.PersonalityPool)`](PersonalityPools.cs.md#symbol-7a6a591a48dd)；[`NationalSpire.PromptLibrary.AvailableTemplates(NationalSpire.AiOptions)`](CustomPromptTemplates.cs.md#symbol-034310e38b45)；[`NationalSpire.PromptLibrary.SelectTemplate(NationalSpire.AiOptions, string)`](PromptTemplates.cs.md#symbol-50231e85e9e7)；[`NationalSpire.PromptTransfer.Apply(NationalSpire.AiOptions, NationalSpire.PromptTransfer.Bundle, string?)`](PromptTransfer.cs.md#symbol-3403e8b82dd8)；[`NationalSpire.PromptTransfer.Read(string)`](PromptTransfer.cs.md#symbol-ec709e31f222)；[`RefreshWorlds()`](NpcGenerationScreen.cs.md#symbol-a2752f80a146)；[`SettingRow(string)`](NpcGenerationScreen.cs.md#symbol-a4f7a7bc2bf3)；[`SubmitAsync()`](NpcGenerationScreen.cs.md#symbol-5ef72d7dd75f)；`System.Action<T>.Invoke(T)`；`System.ArgumentException.ArgumentException(string?)`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource, System.Collections.Generic.IEqualityComparer<TSource>?)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.IO.File.ReadAllText(string)`；`System.IO.IOException.IOException(string?)`；`System.Uri.TryCreate(string?, System.UriKind, out System.Uri?)`；[`Weights()`](NpcGenerationScreen.cs.md#symbol-3c35095e983c)；`string.IsNullOrWhiteSpace(string?)`；`string.Trim()`

**字段、属性、事件及方法组引用：** `Files()`；`Input(Godot.VBoxContainer, string, string, string)`；`NationalSpire.AiConnectionProfile.Endpoint`；`NationalSpire.AiConnectionProfile.Model`；`NationalSpire.AiOptions.ConnectionProfiles`；`NationalSpire.AiOptions.Enabled`；`NationalSpire.AiOptions.Endpoint`；`NationalSpire.AiOptions.Model`；`NationalSpire.AiRouting.Default`；`NationalSpire.AiRouting.Ensure(NationalSpire.AiOptions)`；`NationalSpire.AiService.HasProfileKey(string)`；`NationalSpire.AiService.PersistKey(string, string)`；`NationalSpire.AiSettingsPanel.RivalLevelPicker(int, bool)`；`NationalSpire.CareerDisclosureButton.ArrowOnLeft`；`NationalSpire.CareerEngine.PlayerName`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.PickNestedFile(string, string[], System.Action<string>, System.Action<string[]>?)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._returnDialog`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.NpcGenerationSetup.Ai`；`NationalSpire.NpcGenerationSetup.Files`；`NationalSpire.NpcGenerationSetup.PlayerName`；`NationalSpire.NpcGenerationSetup.Pool`；`NationalSpire.NpcGenerationSetup.RivalLevel`；`NationalSpire.PercentageSlider.Commit()`；`NationalSpire.PersonalityPools.Import(string)`；`NationalSpire.PersonalityPools.Read(NationalSpire.AiOptions)`；`NationalSpire.PersonalityPools.Validate(NationalSpire.PersonalityPool)`；`NationalSpire.PromptLibrary.AvailableTemplates(NationalSpire.AiOptions)`；`NationalSpire.PromptLibrary.SelectTemplate(NationalSpire.AiOptions, string)`；`NationalSpire.PromptTemplate.Id`；`NationalSpire.PromptTransfer.Apply(NationalSpire.AiOptions, NationalSpire.PromptTransfer.Bundle, string?)`；`NationalSpire.PromptTransfer.Bundle.PersonalityPool`；`NationalSpire.PromptTransfer.Read(string)`；`RefreshWorlds()`；`SettingRow(string)`；`SubmitAsync()`；`Weights()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Files()`；输入表达式：`Files()`；返回值紧邻使用处：`ExpressionStatementSyntax: Files();`
- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`toggle.QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: toggle.QueueRedraw();`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`toggle.AddThemeColorOverride("font_color", _muted)`；返回值紧邻使用处：`ExpressionStatementSyntax: toggle.AddThemeColorOverride("font_color", _muted);`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`toggle.AddThemeColorOverride("font_hover_color", _ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: toggle.AddThemeColorOverride("font_hover_color", _ink);`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`toggle.AddThemeColorOverride("font_hover_pressed_color", _ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: toggle.AddThemeColorOverride("font_hover_pressed_color", _ink);`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`toggle.AddThemeColorOverride("font_pressed_color", _ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: toggle.AddThemeColorOverride("font_pressed_color", _ink);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`content.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`credentials.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: credentials.AddThemeConstantOverride("separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`peopleColumn.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: peopleColumn.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`peopleRow.AddThemeConstantOverride("separation", 24)`；返回值紧邻使用处：`ExpressionStatementSyntax: peopleRow.AddThemeConstantOverride("separation", 24);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`playerColumn.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: playerColumn.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`proportions.AddThemeConstantOverride("separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: proportions.AddThemeConstantOverride("separation", 10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`toolbar.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: toolbar.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`weights.AddThemeConstantOverride("h_separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: weights.AddThemeConstantOverride("h_separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`weights.AddThemeConstantOverride("v_separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: weights.AddThemeConstantOverride("v_separation", 16);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`playerName.AddThemeFontSizeOverride("font_size", 17)`；返回值紧邻使用处：`ExpressionStatementSyntax: playerName.AddThemeFontSizeOverride("font_size", 17);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`toggle.AddThemeFontSizeOverride("font_size", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: toggle.AddThemeFontSizeOverride("font_size", 18);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`toggle.AddThemeStyleboxOverride(state, new StyleBoxEmpty { ContentMarginLeft = 26, ContentMarginTop = 4, ContentMarginBottom = 4 })`；返回值紧邻使用处：`ExpressionStatementSyntax: toggle.AddThemeStyleboxOverride(state, new StyleBoxEmpty { ContentMarginLeft = 26, ContentMarginTop = 4, ContentMarginBottom = 4 });`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`AssignmentExpressionSyntax: weights = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.HSeparator.HSeparator()`；输入表达式：`new HSeparator()`；返回值紧邻使用处：`ArgumentSyntax: new HSeparator()`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Name = "WorldPlayerName", Text = setup.PlayerName, PlaceholderText = CareerEngine.PlayerName, CustomMinimumSize = new(0, 48), SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsVertical = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LineEdit { Name = "WorldPlayerName", Text = setup.PlayerName, PlaceholderText = CareerEngine.PlayerName, CustomMinimumSize = new(0, 48), SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsVertical = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`SettingRow("NPC 游戏下降水平").AddChild(level)`；返回值紧邻使用处：`ExpressionStatementSyntax: SettingRow("NPC 游戏下降水平").AddChild(level);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`SettingRow("世界设定").AddChild(worlds)`；返回值紧邻使用处：`ExpressionStatementSyntax: SettingRow("世界设定").AddChild(worlds);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(status)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(status);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(Text("API 配置", 20, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(Text("API 配置", 20, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(Text("接入 AI 后能获得更好的社区和讯息互动体验。", 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(Text("接入 AI 后能获得更好的社区和讯息互动体验。", 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(credentials)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(credentials);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(files)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(files);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(new HSeparator())`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(new HSeparator());`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(peopleRow)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(peopleRow);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(proportions)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(proportions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(toggle)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(toggle);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`credentials.AddChild(addressColumn)`；返回值紧邻使用处：`ExpressionStatementSyntax: credentials.AddChild(addressColumn);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`credentials.AddChild(modelColumn)`；返回值紧邻使用处：`ExpressionStatementSyntax: credentials.AddChild(modelColumn);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`credentials.AddChild(secretColumn)`；返回值紧邻使用处：`ExpressionStatementSyntax: credentials.AddChild(secretColumn);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`peopleColumn.AddChild(Text("NPC 性格与角色配置", 20, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: peopleColumn.AddChild(Text("NPC 性格与角色配置", 20, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`peopleColumn.AddChild(toolbar)`；返回值紧邻使用处：`ExpressionStatementSyntax: peopleColumn.AddChild(toolbar);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`peopleRow.AddChild(peopleColumn)`；返回值紧邻使用处：`ExpressionStatementSyntax: peopleRow.AddChild(peopleColumn);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`peopleRow.AddChild(playerColumn)`；返回值紧邻使用处：`ExpressionStatementSyntax: peopleRow.AddChild(playerColumn);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`playerColumn.AddChild(Text("你的名字：", 20, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: playerColumn.AddChild(Text("你的名字：", 20, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`playerColumn.AddChild(playerName)`；返回值紧邻使用处：`ExpressionStatementSyntax: playerColumn.AddChild(playerName);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`proportions.AddChild(allocationHint)`；返回值紧邻使用处：`ExpressionStatementSyntax: proportions.AddChild(allocationHint);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`proportions.AddChild(weights)`；返回值紧邻使用处：`ExpressionStatementSyntax: proportions.AddChild(weights);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scroll.AddChild(content)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.AddChild(content);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`toolbar.AddChild(Button("导入性格池", () => { if (busy) return; PickNestedFile("导入性格池", [".json"], path => { try { setup.Pool = PersonalityPools.Import(File.ReadAllText(path)); Weights(); status.Text = "性格池已加载。"; } catch (Exception e) { status.Text = e.Message; } }); }, 180))`；返回值紧邻使用处：`ExpressionStatementSyntax: toolbar.AddChild(Button("导入性格池", () => { if (busy) return; PickNestedFile("导入性格池", [".json"], path => { try { setup.Pool = PersonalityPools.Import(File.ReadAllText(path)); Weights(); status.Text = "性格池已加载。"; } catch (Exception e) { status.Text = e.Message; } }); }, 180));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`toolbar.AddChild(Button("批量导入角色", () => { if (busy) return; PickNestedFile("选择角色卡或角色设计包", [".png", ".zip"], _ => { }, paths => { foreach (var path in paths) if (!setup.Files.Contains(path, StringComparer.OrdinalIgnoreCase)) setup.Files.Add(path); Files(); status.Text = "已选 " + setup.Files.Count + " 个角色文件；确认后统一校验并导入。"; }); }, 180))`；返回值紧邻使用处：`ExpressionStatementSyntax: toolbar.AddChild(Button("批量导入角色", () => { if (busy) return; PickNestedFile("选择角色卡或角色设计包", [".png", ".zip"], _ => { }, paths => { foreach (var path in paths) if (!setup.Files.Contains(path, StringComparer.OrdinalIgnoreCase)) setup.Files.Add(path); Files(); status.Text = "已选 " + setup.Files.Count + " 个角色文件；确认后统一校验并导入。"; }); }, 180));`
- `Godot.OptionButton.GetItemId(int)`；输入表达式：`level.GetItemId((int)i)`；返回值紧邻使用处：`AssignmentExpressionSyntax: setup.RivalLevel = level.GetItemId((int)i)`
- `Godot.OptionButton.GetItemText(int)`；输入表达式：`worlds.GetItemText(worlds.Selected)`；返回值紧邻使用处：`BinaryExpressionSyntax: "提示词已载入：" + worlds.GetItemText(worlds.Selected)`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { Name = "WorldPromptTemplate", FitToLongestItem = false, CustomMinimumSize = new(0, 44), SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { Name = "WorldPromptTemplate", FitToLongestItem = false, CustomMinimumSize = new(0, 44), SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty { ContentMarginLeft = 26, ContentMarginTop = 4, ContentMarginBottom = 4 }`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxEmpty { ContentMarginLeft = 26, ContentMarginTop = 4, ContentMarginBottom = 4 }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { CustomMinimumSize = new(300, 0) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { CustomMinimumSize = new(300, 0) }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { Name = "WorldProportions", Visible = false }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { Name = "WorldProportions", Visible = false }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = 1.5f }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = 1.5f }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`AssignmentExpressionSyntax: files = new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 44)`；返回值紧邻使用处：`AssignmentExpressionSyntax: level.CustomMinimumSize = new(0, 44)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 44)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 44)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 48)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 550)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 550)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, proportions.Visible ? 770 : 550)`；返回值紧邻使用处：`AssignmentExpressionSyntax: scroll.CustomMinimumSize = new(0, proportions.Visible ? 770 : 550)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(1040, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: box.CustomMinimumSize = new(1040, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(300, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(300, 0)`
- `Input(Godot.VBoxContainer, string, string, string)`；输入表达式：`Input(addressColumn, "服务地址", connection.Endpoint, "WorldApiEndpoint")`；返回值紧邻使用处：`AssignmentExpressionSyntax: endpoint = Input(addressColumn, "服务地址", connection.Endpoint, "WorldApiEndpoint")`
- `Input(Godot.VBoxContainer, string, string, string)`；输入表达式：`Input(modelColumn, "模型", connection.Model, "WorldApiModel")`；返回值紧邻使用处：`AssignmentExpressionSyntax: model = Input(modelColumn, "模型", connection.Model, "WorldApiModel")`
- `Input(Godot.VBoxContainer, string, string, string)`；输入表达式：`Input(secretColumn, "密钥 · 加密保存在本机", "", "WorldApiKey")`；返回值紧邻使用处：`AssignmentExpressionSyntax: key = Input(secretColumn, "密钥 · 加密保存在本机", "", "WorldApiKey")`
- `NationalSpire.AiConnectionProfile.AiConnectionProfile()`；输入表达式：`new() { Endpoint = setup.Ai.Endpoint, Model = setup.Ai.Model }`；返回值紧邻使用处：`AssignmentExpressionSyntax: setup.Ai.ConnectionProfiles[AiRouting.Default] = new() { Endpoint = setup.Ai.Endpoint, Model = setup.Ai.Model }`
- `NationalSpire.AiRouting.Ensure(NationalSpire.AiOptions)`；输入表达式：`AiRouting.Ensure(setup.Ai)`；返回值紧邻使用处：`ExpressionStatementSyntax: AiRouting.Ensure(setup.Ai);`
- `NationalSpire.AiService.HasProfileKey(string)`；输入表达式：`AiService.HasProfileKey(AiRouting.Default)`；返回值紧邻使用处：`IfStatementSyntax: if (AiService.HasProfileKey(AiRouting.Default)) setup.Ai.Enabled = true;`
- `NationalSpire.AiService.HasProfileKey(string)`；输入表达式：`AiService.HasProfileKey(AiRouting.Default)`；返回值紧邻使用处：`ConditionalExpressionSyntax: AiService.HasProfileKey(AiRouting.Default) ? "已保存 · 留空保留" : "填写 API 密钥"`
- `NationalSpire.AiService.PersistKey(string, string)`；输入表达式：`AiService.PersistKey(key.Text.Trim())`；返回值紧邻使用处：`IsPatternExpressionSyntax: AiService.PersistKey(key.Text.Trim()) is { } error`
- `NationalSpire.AiSettingsPanel.RivalLevelPicker(int, bool)`；输入表达式：`AiSettingsPanel.RivalLevelPicker(setup.RivalLevel, team)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AiSettingsPanel.RivalLevelPicker(setup.RivalLevel, team)`
- `NationalSpire.BroadcastScroll.BroadcastScroll()`；输入表达式：`new BroadcastScroll { Name = "NewWorldScroll", CustomMinimumSize = new(0, 550), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastScroll { Name = "NewWorldScroll", CustomMinimumSize = new(0, 550), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `NationalSpire.CareerDisclosureButton.CareerDisclosureButton()`；输入表达式：`new CareerDisclosureButton { Name = "WorldProportionsToggle", Text = "配置人物比例", ArrowOnLeft = true, Flat = true, ToggleMode = true, SizeFlagsHorizontal = SizeFlags.ShrinkBegin, MouseDefaultCursorShape = CursorShape.PointingHand }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CareerDisclosureButton { Name = "WorldProportionsToggle", Text = "配置人物比例", ArrowOnLeft = true, Flat = true, ToggleMode = true, SizeFlagsHorizontal = SizeFlags.ShrinkBegin, MouseDefaultCursorShape = CursorShape.PointingHand }`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("导入性格池", () => { if (busy) return; PickNestedFile("导入性格池", [".json"], path => { try { setup.Pool = PersonalityPools.Import(File.ReadAllText(path)); Weights(); status.Text = "性格池已加载。"; } catch (Exception e) { status.Text = e.Message; } }); }, 180)`；返回值紧邻使用处：`ArgumentSyntax: Button("导入性格池", () => { if (busy) return; PickNestedFile("导入性格池", [".json"], path => { try { setup.Pool = PersonalityPools.Import(File.ReadAllText(path)); Weights(); status.Text = "性格池已加载。"; } catch (Exception e) { status.Text = e.Message; } }); }, 180)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("批量导入角色", () => { if (busy) return; PickNestedFile("选择角色卡或角色设计包", [".png", ".zip"], _ => { }, paths => { foreach (var path in paths) if (!setup.Files.Contains(path, StringComparer.OrdinalIgnoreCase)) setup.Files.Add(path); Files(); status.Text = "已选 " + setup.Files.Count + " 个角色文件；确认后统一校验并导入。"; }); }, 180)`；返回值紧邻使用处：`ArgumentSyntax: Button("批量导入角色", () => { if (busy) return; PickNestedFile("选择角色卡或角色设计包", [".png", ".zip"], _ => { }, paths => { foreach (var path in paths) if (!setup.Files.Contains(path, StringComparer.OrdinalIgnoreCase)) setup.Files.Add(path); Files(); status.Text = "已选 " + setup.Files.Count + " 个角色文件；确认后统一校验并导入。"; }); }, 180)`
- `NationalSpire.CareerScreen.PickNestedFile(string, string[], System.Action<string>, System.Action<string[]>?)`；输入表达式：`PickNestedFile("导入性格池", [".json"], path => { try { setup.Pool = PersonalityPools.Import(File.ReadAllText(path)); Weights(); status.Text = "性格池已加载。"; } catch (Exception e) { status.Text = e.Message; } })`；返回值紧邻使用处：`ExpressionStatementSyntax: PickNestedFile("导入性格池", [".json"], path => { try { setup.Pool = PersonalityPools.Import(File.ReadAllText(path)); Weights(); status.Text = "性格池已加载。"; } catch (Exception e) { status.Text = e.Message; } });`
- `NationalSpire.CareerScreen.PickNestedFile(string, string[], System.Action<string>, System.Action<string[]>?)`；输入表达式：`PickNestedFile("选择提示词 JSON", [".json"], path => { try { var imported = Coop.CoopJson.Copy(setup.Ai); var bundle = PromptTransfer.Read(File.ReadAllText(path)); PromptTransfer.Apply(imported, bundle); setup.Ai = imported; connection = setup.Ai.ConnectionProfiles[AiRouting.Default]; if (bundle.PersonalityPool != null) { setup.Pool = PersonalityPools.Read(imported); Weights(); } RefreshWorlds(); status.Text = "提示词已载入：" + worlds.GetItemText(worlds.Selected) + (bundle.PersonalityPool != null ? "，性格池与人物比例已同步。" : "。") + "生成新世界时应用。"; } catch (Exception e) { status.Text = "提示词导入失败：" + e.Message; } })`；返回值紧邻使用处：`ExpressionStatementSyntax: PickNestedFile("选择提示词 JSON", [".json"], path => { try { var imported = Coop.CoopJson.Copy(setup.Ai); var bundle = PromptTransfer.Read(File.ReadAllText(path)); PromptTransfer.Apply(imported, bundle); setup.Ai = imported; connection = setup.Ai.ConnectionProfiles[AiRouting.Default]; if (bundle.PersonalityPool != null) { setup.Pool = PersonalityPools.Read(imported); Weights(); } RefreshWorlds(); status.Text = "提示词已载入：" + worlds.GetItemText(worlds.Selected) + (bundle.PersonalityPool != null ? "，性格池与人物比例已同步。" : "。") + "生成新世界时应用。"; } catch (Exception e) { status.Text = "提示词导入失败：" + e.Message; } });`
- `NationalSpire.CareerScreen.PickNestedFile(string, string[], System.Action<string>, System.Action<string[]>?)`；输入表达式：`PickNestedFile("选择角色卡或角色设计包", [".png", ".zip"], _ => { }, paths => { foreach (var path in paths) if (!setup.Files.Contains(path, StringComparer.OrdinalIgnoreCase)) setup.Files.Add(path); Files(); status.Text = "已选 " + setup.Files.Count + " 个角色文件；确认后统一校验并导入。"; })`；返回值紧邻使用处：`ExpressionStatementSyntax: PickNestedFile("选择角色卡或角色设计包", [".png", ".zip"], _ => { }, paths => { foreach (var path in paths) if (!setup.Files.Contains(path, StringComparer.OrdinalIgnoreCase)) setup.Files.Add(path); Files(); status.Text = "已选 " + setup.Files.Count + " 个角色文件；确认后统一校验并导入。"; });`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("配置新世界", "", () => { if (busy) return false; try { foreach (var slider in sliders) slider.Commit(); PersonalityPools.Validate(setup.Pool); string address = endpoint.Text.Trim(), modelId = model.Text.Trim(); if (!Uri.TryCreate(address, UriKind.Absolute, out var uri) || uri.Scheme is not ("https" or "http") || modelId.Length == 0) throw new ArgumentException("请填写有效的服务地址和模型名称。"); connection.Endpoint = setup.Ai.Endpoint = address; connection.Model = setup.Ai.Model = modelId; if (!string.IsNullOrWhiteSpace(key.Text)) { if (AiService.PersistKey(key.Text.Trim()) is { } error) throw new IOException(error); key.Text = ""; key.PlaceholderText = "已保存 · 留空保留"; } if (AiService.HasProfileKey(AiRouting.Default)) setup.Ai.Enabled = true; if (selectedAsync != null) { _ = SubmitAsync(); return false; } selected(setup); return true; } catch (Exception e) { status.Text = "配置未应用：" + e.Message; return false; } }, "生成并开始", box => { box.CustomMinimumSize = new(1040, 0); box.AddThemeConstantOverride("separation", 16); var scroll = new BroadcastScroll { Name = "NewWorldScroll", CustomMinimumSize = new(0, 550), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll); var content = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; content.AddThemeConstantOverride("separation", 12); scroll.AddChild(content); HBoxContainer SettingRow(string title) { var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 16); content.AddChild(row); var label = Text(title, 20, _gold); label.CustomMinimumSize = new(190, 0); row.AddChild(label); return row; } var level = AiSettingsPanel.RivalLevelPicker(setup.RivalLevel, team); level.CustomMinimumSize = new(0, 44); level.ItemSelected += i => setup.RivalLevel = level.GetItemId((int)i); SettingRow("NPC 游戏下降水平").AddChild(level); var templates = PromptLibrary.AvailableTemplates(setup.Ai).ToArray(); var worlds = new OptionButton { Name = "WorldPromptTemplate", FitToLongestItem = false, CustomMinimumSize = new(0, 44), SizeFlagsHorizontal = SizeFlags.ExpandFill }; void RefreshWorlds() { templates = PromptLibrary.AvailableTemplates(setup.Ai).ToArray(); worlds.Clear(); foreach (var template in templates) worlds.AddItem(template.Name); worlds.AddSeparator(); worlds.AddItem("导入提示词…"); worlds.Select(Array.FindIndex(templates, t => t.Id == PromptLibrary.TemplateId(setup.Ai))); } RefreshWorlds(); worlds.ItemSelected += i => { if (busy) { RefreshWorlds(); return; } if (i < templates.Length) { PromptLibrary.SelectTemplate(setup.Ai, templates[(int)i].Id); return; } RefreshWorlds(); PickNestedFile("选择提示词 JSON", [".json"], path => { try { var imported = Coop.CoopJson.Copy(setup.Ai); var bundle = PromptTransfer.Read(File.ReadAllText(path)); PromptTransfer.Apply(imported, bundle); setup.Ai = imported; connection = setup.Ai.ConnectionProfiles[AiRouting.Default]; if (bundle.PersonalityPool != null) { setup.Pool = PersonalityPools.Read(imported); Weights(); } RefreshWorlds(); status.Text = "提示词已载入：" + worlds.GetItemText(worlds.Selected) + (bundle.PersonalityPool != null ? "，性格池与人物比例已同步。" : "。") + "生成新世界时应用。"; } catch (Exception e) { status.Text = "提示词导入失败：" + e.Message; } }); }; SettingRow("世界设定").AddChild(worlds); content.AddChild(new HSeparator()); content.AddChild(Text("API 配置", 20, _gold)); content.AddChild(Text("接入 AI 后能获得更好的社区和讯息互动体验。", 16, _muted)); LineEdit Input(VBoxContainer parent, string title, string value, string name) { parent.AddChild(Text(title, 16, _muted)); var input = new LineEdit { Name = name, Text = value, CustomMinimumSize = new(0, 40), SizeFlagsHorizontal = SizeFlags.ExpandFill }; parent.AddChild(input); return input; } var credentials = new HBoxContainer(); credentials.AddThemeConstantOverride("separation", 16); content.AddChild(credentials); var addressColumn = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = 1.5f }; credentials.AddChild(addressColumn); endpoint = Input(addressColumn, "服务地址", connection.Endpoint, "WorldApiEndpoint"); var secretColumn = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; credentials.AddChild(secretColumn); var modelColumn = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; credentials.AddChild(modelColumn); key = Input(secretColumn, "密钥 · 加密保存在本机", "", "WorldApiKey"); key.Secret = true; key.PlaceholderText = AiService.HasProfileKey(AiRouting.Default) ? "已保存 · 留空保留" : "填写 API 密钥"; model = Input(modelColumn, "模型", connection.Model, "WorldApiModel"); content.AddChild(new HSeparator()); var peopleRow = new HBoxContainer(); peopleRow.AddThemeConstantOverride("separation", 24); content.AddChild(peopleRow); var peopleColumn = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; peopleColumn.AddThemeConstantOverride("separation", 12); peopleRow.AddChild(peopleColumn); peopleColumn.AddChild(Text("NPC 性格与角色配置", 20, _gold)); var toolbar = new HBoxContainer(); toolbar.AddThemeConstantOverride("separation", 12); peopleColumn.AddChild(toolbar); toolbar.AddChild(Button("导入性格池", () => { if (busy) return; PickNestedFile("导入性格池", [".json"], path => { try { setup.Pool = PersonalityPools.Import(File.ReadAllText(path)); Weights(); status.Text = "性格池已加载。"; } catch (Exception e) { status.Text = e.Message; } }); }, 180)); toolbar.AddChild(Button("批量导入角色", () => { if (busy) return; PickNestedFile("选择角色卡或角色设计包", [".png", ".zip"], _ => { }, paths => { foreach (var path in paths) if (!setup.Files.Contains(path, StringComparer.OrdinalIgnoreCase)) setup.Files.Add(path); Files(); status.Text = "已选 " + setup.Files.Count + " 个角色文件；确认后统一校验并导入。"; }); }, 180)); var playerColumn = new VBoxContainer { CustomMinimumSize = new(300, 0) }; playerColumn.AddThemeConstantOverride("separation", 12); peopleRow.AddChild(playerColumn); playerColumn.AddChild(Text("你的名字：", 20, _gold)); var playerName = new LineEdit { Name = "WorldPlayerName", Text = setup.PlayerName, PlaceholderText = CareerEngine.PlayerName, CustomMinimumSize = new(0, 48), SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsVertical = SizeFlags.ExpandFill }; playerName.AddThemeFontSizeOverride("font_size", 17); playerColumn.AddChild(playerName); playerName.TextChanged += value => { if (!busy) setup.PlayerName = value; }; files = new VBoxContainer(); content.AddChild(files); Files(); var proportions = new VBoxContainer { Name = "WorldProportions", Visible = false }; proportions.AddThemeConstantOverride("separation", 10); var toggle = new CareerDisclosureButton { Name = "WorldProportionsToggle", Text = "配置人物比例", ArrowOnLeft = true, Flat = true, ToggleMode = true, SizeFlagsHorizontal = SizeFlags.ShrinkBegin, MouseDefaultCursorShape = CursorShape.PointingHand }; toggle.AddThemeFontSizeOverride("font_size", 18); toggle.AddThemeColorOverride("font_color", _muted); toggle.AddThemeColorOverride("font_hover_color", _ink); toggle.AddThemeColorOverride("font_pressed_color", _ink); toggle.AddThemeColorOverride("font_hover_pressed_color", _ink); foreach (string state in new[] { "normal", "hover", "pressed", "focus" }) toggle.AddThemeStyleboxOverride(state, new StyleBoxEmpty { ContentMarginLeft = 26, ContentMarginTop = 4, ContentMarginBottom = 4 }); toggle.Pressed += () => { if (busy) { toggle.ButtonPressed = proportions.Visible; return; } proportions.Visible = !proportions.Visible; toggle.ButtonPressed = proportions.Visible; toggle.QueueRedraw(); scroll.CustomMinimumSize = new(0, proportions.Visible ? 770 : 550); }; content.AddChild(toggle); content.AddChild(proportions); var allocationHint = Text("各大类、每类内部各合计 100%。点击锁固定比例；其余未锁定项均摊差额，调整上限为剩余额度。", 16, _muted); allocationHint.AutowrapMode = TextServer.AutowrapMode.WordSmart; proportions.AddChild(allocationHint); weights = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }; weights.AddThemeConstantOverride("h_separation", 16); weights.AddThemeConstantOverride("v_separation", 16); proportions.AddChild(weights); Weights(); status = Text("已沿用现有世界设定；导入角色保留自己的设定，随机人物按类别与性格比例生成。", 15, _muted); status.AutowrapMode = TextServer.AutowrapMode.WordSmart; box.AddChild(status); }, showCancel: !required)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("配置新世界", "", () => { if (busy) return false; try { foreach (var slider in sliders) slider.Commit(); PersonalityPools.Validate(setup.Pool); string address = endpoint.Text.Trim(), modelId = model.Text.Trim(); if (!Uri.TryCreate(address, UriKind.Absolute, out var uri) || uri.Scheme is not ("https" or "http") || modelId.Length == 0) throw new ArgumentException("请填写有效的服务地址和模型名称。"); connection.Endpoint = setup.Ai.Endpoint = address; connection.Model = setup.Ai.Model = modelId; if (!string.IsNullOrWhiteSpace(key.Text)) { if (AiService.PersistKey(key.Text.Trim()) is { } error) throw new IOException(error); key.Text = ""; key.PlaceholderText = "已保存 · 留空保留"; } if (AiService.HasProfileKey(AiRouting.Default)) setup.Ai.Enabled = true; if (selectedAsync != null) { _ = SubmitAsync(); return false; } selected(setup); return true; } catch (Exception e) { status.Text = "配置未应用：" + e.Message; return false; } }, "生成并开始", box => { box.CustomMinimumSize = new(1040, 0); box.AddThemeConstantOverride("separation", 16); var scroll = new BroadcastScroll { Name = "NewWorldScroll", CustomMinimumSize = new(0, 550), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll); var content = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; content.AddThemeConstantOverride("separation", 12); scroll.AddChild(content); HBoxContainer SettingRow(string title) { var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 16); content.AddChild(row); var label = Text(title, 20, _gold); label.CustomMinimumSize = new(190, 0); row.AddChild(label); return row; } var level = AiSettingsPanel.RivalLevelPicker(setup.RivalLevel, team); level.CustomMinimumSize = new(0, 44); level.ItemSelected += i => setup.RivalLevel = level.GetItemId((int)i); SettingRow("NPC 游戏下降水平").AddChild(level); var templates = PromptLibrary.AvailableTemplates(setup.Ai).ToArray(); var worlds = new OptionButton { Name = "WorldPromptTemplate", FitToLongestItem = false, CustomMinimumSize = new(0, 44), SizeFlagsHorizontal = SizeFlags.ExpandFill }; void RefreshWorlds() { templates = PromptLibrary.AvailableTemplates(setup.Ai).ToArray(); worlds.Clear(); foreach (var template in templates) worlds.AddItem(template.Name); worlds.AddSeparator(); worlds.AddItem("导入提示词…"); worlds.Select(Array.FindIndex(templates, t => t.Id == PromptLibrary.TemplateId(setup.Ai))); } RefreshWorlds(); worlds.ItemSelected += i => { if (busy) { RefreshWorlds(); return; } if (i < templates.Length) { PromptLibrary.SelectTemplate(setup.Ai, templates[(int)i].Id); return; } RefreshWorlds(); PickNestedFile("选择提示词 JSON", [".json"], path => { try { var imported = Coop.CoopJson.Copy(setup.Ai); var bundle = PromptTransfer.Read(File.ReadAllText(path)); PromptTransfer.Apply(imported, bundle); setup.Ai = imported; connection = setup.Ai.ConnectionProfiles[AiRouting.Default]; if (bundle.PersonalityPool != null) { setup.Pool = PersonalityPools.Read(imported); Weights(); } RefreshWorlds(); status.Text = "提示词已载入：" + worlds.GetItemText(worlds.Selected) + (bundle.PersonalityPool != null ? "，性格池与人物比例已同步。" : "。") + "生成新世界时应用。"; } catch (Exception e) { status.Text = "提示词导入失败：" + e.Message; } }); }; SettingRow("世界设定").AddChild(worlds); content.AddChild(new HSeparator()); content.AddChild(Text("API 配置", 20, _gold)); content.AddChild(Text("接入 AI 后能获得更好的社区和讯息互动体验。", 16, _muted)); LineEdit Input(VBoxContainer parent, string title, string value, string name) { parent.AddChild(Text(title, 16, _muted)); var input = new LineEdit { Name = name, Text = value, CustomMinimumSize = new(0, 40), SizeFlagsHorizontal = SizeFlags.ExpandFill }; parent.AddChild(input); return input; } var credentials = new HBoxContainer(); credentials.AddThemeConstantOverride("separation", 16); content.AddChild(credentials); var addressColumn = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = 1.5f }; credentials.AddChild(addressColumn); endpoint = Input(addressColumn, "服务地址", connection.Endpoint, "WorldApiEndpoint"); var secretColumn = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; credentials.AddChild(secretColumn); var modelColumn = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; credentials.AddChild(modelColumn); key = Input(secretColumn, "密钥 · 加密保存在本机", "", "WorldApiKey"); key.Secret = true; key.PlaceholderText = AiService.HasProfileKey(AiRouting.Default) ? "已保存 · 留空保留" : "填写 API 密钥"; model = Input(modelColumn, "模型", connection.Model, "WorldApiModel"); content.AddChild(new HSeparator()); var peopleRow = new HBoxContainer(); peopleRow.AddThemeConstantOverride("separation", 24); content.AddChild(peopleRow); var peopleColumn = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; peopleColumn.AddThemeConstantOverride("separation", 12); peopleRow.AddChild(peopleColumn); peopleColumn.AddChild(Text("NPC 性格与角色配置", 20, _gold)); var toolbar = new HBoxContainer(); toolbar.AddThemeConstantOverride("separation", 12); peopleColumn.AddChild(toolbar); toolbar.AddChild(Button("导入性格池", () => { if (busy) return; PickNestedFile("导入性格池", [".json"], path => { try { setup.Pool = PersonalityPools.Import(File.ReadAllText(path)); Weights(); status.Text = "性格池已加载。"; } catch (Exception e) { status.Text = e.Message; } }); }, 180)); toolbar.AddChild(Button("批量导入角色", () => { if (busy) return; PickNestedFile("选择角色卡或角色设计包", [".png", ".zip"], _ => { }, paths => { foreach (var path in paths) if (!setup.Files.Contains(path, StringComparer.OrdinalIgnoreCase)) setup.Files.Add(path); Files(); status.Text = "已选 " + setup.Files.Count + " 个角色文件；确认后统一校验并导入。"; }); }, 180)); var playerColumn = new VBoxContainer { CustomMinimumSize = new(300, 0) }; playerColumn.AddThemeConstantOverride("separation", 12); peopleRow.AddChild(playerColumn); playerColumn.AddChild(Text("你的名字：", 20, _gold)); var playerName = new LineEdit { Name = "WorldPlayerName", Text = setup.PlayerName, PlaceholderText = CareerEngine.PlayerName, CustomMinimumSize = new(0, 48), SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsVertical = SizeFlags.ExpandFill }; playerName.AddThemeFontSizeOverride("font_size", 17); playerColumn.AddChild(playerName); playerName.TextChanged += value => { if (!busy) setup.PlayerName = value; }; files = new VBoxContainer(); content.AddChild(files); Files(); var proportions = new VBoxContainer { Name = "WorldProportions", Visible = false }; proportions.AddThemeConstantOverride("separation", 10); var toggle = new CareerDisclosureButton { Name = "WorldProportionsToggle", Text = "配置人物比例", ArrowOnLeft = true, Flat = true, ToggleMode = true, SizeFlagsHorizontal = SizeFlags.ShrinkBegin, MouseDefaultCursorShape = CursorShape.PointingHand }; toggle.AddThemeFontSizeOverride("font_size", 18); toggle.AddThemeColorOverride("font_color", _muted); toggle.AddThemeColorOverride("font_hover_color", _ink); toggle.AddThemeColorOverride("font_pressed_color", _ink); toggle.AddThemeColorOverride("font_hover_pressed_color", _ink); foreach (string state in new[] { "normal", "hover", "pressed", "focus" }) toggle.AddThemeStyleboxOverride(state, new StyleBoxEmpty { ContentMarginLeft = 26, ContentMarginTop = 4, ContentMarginBottom = 4 }); toggle.Pressed += () => { if (busy) { toggle.ButtonPressed = proportions.Visible; return; } proportions.Visible = !proportions.Visible; toggle.ButtonPressed = proportions.Visible; toggle.QueueRedraw(); scroll.CustomMinimumSize = new(0, proportions.Visible ? 770 : 550); }; content.AddChild(toggle); content.AddChild(proportions); var allocationHint = Text("各大类、每类内部各合计 100%。点击锁固定比例；其余未锁定项均摊差额，调整上限为剩余额度。", 16, _muted); allocationHint.AutowrapMode = TextServer.AutowrapMode.WordSmart; proportions.AddChild(allocationHint); weights = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }; weights.AddThemeConstantOverride("h_separation", 16); weights.AddThemeConstantOverride("v_separation", 16); proportions.AddChild(weights); Weights(); status = Text("已沿用现有世界设定；导入角色保留自己的设定，随机人物按类别与性格比例生成。", 15, _muted); status.AutowrapMode = TextServer.AutowrapMode.WordSmart; box.AddChild(status); }, showCancel: !required);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("API 配置", 20, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("API 配置", 20, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("NPC 性格与角色配置", 20, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("NPC 性格与角色配置", 20, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("你的名字：", 20, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("你的名字：", 20, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("各大类、每类内部各合计 100%。点击锁固定比例；其余未锁定项均摊差额，调整上限为剩余额度。", 16, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("各大类、每类内部各合计 100%。点击锁固定比例；其余未锁定项均摊差额，调整上限为剩余额度。", 16, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("已沿用现有世界设定；导入角色保留自己的设定，随机人物按类别与性格比例生成。", 15, _muted)`；返回值紧邻使用处：`AssignmentExpressionSyntax: status = Text("已沿用现有世界设定；导入角色保留自己的设定，随机人物按类别与性格比例生成。", 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("接入 AI 后能获得更好的社区和讯息互动体验。", 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("接入 AI 后能获得更好的社区和讯息互动体验。", 16, _muted)`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`Coop.CoopJson.Copy(ai)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Ai = Coop.CoopJson.Copy(ai)`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`Coop.CoopJson.Copy(setup.Ai)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Coop.CoopJson.Copy(setup.Ai)`
- `NationalSpire.NpcGenerationSetup.NpcGenerationSetup()`；输入表达式：`new NpcGenerationSetup { Pool = PersonalityPools.Read(ai), Ai = Coop.CoopJson.Copy(ai), RivalLevel = rivalLevel }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new NpcGenerationSetup { Pool = PersonalityPools.Read(ai), Ai = Coop.CoopJson.Copy(ai), RivalLevel = rivalLevel }`
- `NationalSpire.PercentageSlider.Commit()`；输入表达式：`slider.Commit()`；返回值紧邻使用处：`ExpressionStatementSyntax: slider.Commit();`
- `NationalSpire.PersonalityPools.Import(string)`；输入表达式：`PersonalityPools.Import(File.ReadAllText(path))`；返回值紧邻使用处：`AssignmentExpressionSyntax: setup.Pool = PersonalityPools.Import(File.ReadAllText(path))`
- `NationalSpire.PersonalityPools.Read(NationalSpire.AiOptions)`；输入表达式：`PersonalityPools.Read(ai)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Pool = PersonalityPools.Read(ai)`
- `NationalSpire.PersonalityPools.Read(NationalSpire.AiOptions)`；输入表达式：`PersonalityPools.Read(imported)`；返回值紧邻使用处：`AssignmentExpressionSyntax: setup.Pool = PersonalityPools.Read(imported)`
- `NationalSpire.PersonalityPools.Validate(NationalSpire.PersonalityPool)`；输入表达式：`PersonalityPools.Validate(setup.Pool)`；返回值紧邻使用处：`ExpressionStatementSyntax: PersonalityPools.Validate(setup.Pool);`
- `NationalSpire.PromptLibrary.AvailableTemplates(NationalSpire.AiOptions)`；输入表达式：`PromptLibrary.AvailableTemplates(setup.Ai)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PromptLibrary.AvailableTemplates(setup.Ai).ToArray`
- `NationalSpire.PromptLibrary.SelectTemplate(NationalSpire.AiOptions, string)`；输入表达式：`PromptLibrary.SelectTemplate(setup.Ai, templates[(int)i].Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: PromptLibrary.SelectTemplate(setup.Ai, templates[(int)i].Id);`
- `NationalSpire.PromptTransfer.Apply(NationalSpire.AiOptions, NationalSpire.PromptTransfer.Bundle, string?)`；输入表达式：`PromptTransfer.Apply(imported, bundle)`；返回值紧邻使用处：`ExpressionStatementSyntax: PromptTransfer.Apply(imported, bundle);`
- `NationalSpire.PromptTransfer.Read(string)`；输入表达式：`PromptTransfer.Read(File.ReadAllText(path))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PromptTransfer.Read(File.ReadAllText(path))`
- `RefreshWorlds()`；输入表达式：`RefreshWorlds()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshWorlds();`
- `SettingRow(string)`；输入表达式：`SettingRow("NPC 游戏下降水平")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: SettingRow("NPC 游戏下降水平").AddChild`
- `SettingRow(string)`；输入表达式：`SettingRow("世界设定")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: SettingRow("世界设定").AddChild`
- `SubmitAsync()`；输入表达式：`SubmitAsync()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = SubmitAsync()`
- `System.Action<T>.Invoke(T)`；输入表达式：`selected(setup)`；返回值紧邻使用处：`ExpressionStatementSyntax: selected(setup);`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("请填写有效的服务地址和模型名称。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("请填写有效的服务地址和模型名称。");`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`setup.Ai.ConnectionProfiles.ContainsKey(AiRouting.Default)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !setup.Ai.ConnectionProfiles.ContainsKey(AiRouting.Default)`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource, System.Collections.Generic.IEqualityComparer<TSource>?)`；输入表达式：`setup.Files.Contains(path, StringComparer.OrdinalIgnoreCase)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !setup.Files.Contains(path, StringComparer.OrdinalIgnoreCase)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`PromptLibrary.AvailableTemplates(setup.Ai).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PromptLibrary.AvailableTemplates(setup.Ai).ToArray()`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`setup.Files.Add(path)`；返回值紧邻使用处：`ExpressionStatementSyntax: setup.Files.Add(path);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<PercentageSlider>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<PercentageSlider>()`
- `System.IO.File.ReadAllText(string)`；输入表达式：`File.ReadAllText(path)`；返回值紧邻使用处：`ArgumentSyntax: File.ReadAllText(path)`
- `System.IO.IOException.IOException(string?)`；输入表达式：`new IOException(error)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new IOException(error);`
- `System.Uri.TryCreate(string?, System.UriKind, out System.Uri?)`；输入表达式：`Uri.TryCreate(address, UriKind.Absolute, out var uri)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Uri.TryCreate(address, UriKind.Absolute, out var uri)`
- `Weights()`；输入表达式：`Weights()`；返回值紧邻使用处：`ExpressionStatementSyntax: Weights();`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(key.Text)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !string.IsNullOrWhiteSpace(key.Text)`
- `string.Trim()`；输入表达式：`endpoint.Text.Trim()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = endpoint.Text.Trim()`
- `string.Trim()`；输入表达式：`key.Text.Trim()`；返回值紧邻使用处：`ArgumentSyntax: key.Text.Trim()`
- `string.Trim()`；输入表达式：`model.Text.Trim()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = model.Text.Trim()`

**赋值（含属性/字段和局部值）：**

- `Ai` = `Coop.CoopJson.Copy(ai)`
- `ArrowOnLeft` = `true`
- `Columns` = `2`
- `ContentMarginBottom` = `4`
- `ContentMarginLeft` = `26`
- `ContentMarginTop` = `4`
- `CustomMinimumSize` = `new(0, 44)`
- `CustomMinimumSize` = `new(0, 48)`
- `CustomMinimumSize` = `new(0, 550)`
- `CustomMinimumSize` = `new(300, 0)`
- `Endpoint` = `setup.Ai.Endpoint`
- `FitToLongestItem` = `false`
- `Flat` = `true`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `Model` = `setup.Ai.Model`
- `MouseDefaultCursorShape` = `CursorShape.PointingHand`
- `Name` = `"NewWorldScroll"`
- `Name` = `"WorldPlayerName"`
- `Name` = `"WorldPromptTemplate"`
- `Name` = `"WorldProportions"`
- `Name` = `"WorldProportionsToggle"`
- `PlaceholderText` = `CareerEngine.PlayerName`
- `Pool` = `PersonalityPools.Read(ai)`
- `RivalLevel` = `rivalLevel`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`
- `SizeFlagsStretchRatio` = `1.5f`
- `SizeFlagsVertical` = `SizeFlags.ExpandFill`
- `Text` = `"配置人物比例"`
- `Text` = `setup.PlayerName`
- `ToggleMode` = `true`
- `Visible` = `false`
- `_` = `SubmitAsync()`
- `_returnDialog` = `() => { }`
- `allocationHint.AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `box.CustomMinimumSize` = `new(1040, 0)`
- `connection.Endpoint` = `setup.Ai.Endpoint = address`
- `connection.Model` = `setup.Ai.Model = modelId`
- `connection` = `setup.Ai.ConnectionProfiles[AiRouting.Default]`
- `endpoint` = `Input(addressColumn, "服务地址", connection.Endpoint, "WorldApiEndpoint")`
- `files` = `new VBoxContainer()`
- `key.PlaceholderText` = `"已保存 · 留空保留"`
- `key.PlaceholderText` = `AiService.HasProfileKey(AiRouting.Default) ? "已保存 · 留空保留" : "填写 API 密钥"`
- `key.Secret` = `true`
- `key.Text` = `""`
- `key` = `Input(secretColumn, "密钥 · 加密保存在本机", "", "WorldApiKey")`
- `level.CustomMinimumSize` = `new(0, 44)`
- `level.ItemSelected` += `i => setup.RivalLevel = level.GetItemId((int)i)`
- `model` = `Input(modelColumn, "模型", connection.Model, "WorldApiModel")`
- `playerName.TextChanged` += `value => { if (!busy) setup.PlayerName = value; }`
- `proportions.Visible` = `!proportions.Visible`
- `scroll.CustomMinimumSize` = `new(0, proportions.Visible ? 770 : 550)`
- `setup.Ai.ConnectionProfiles[AiRouting.Default]` = `new() { Endpoint = setup.Ai.Endpoint, Model = setup.Ai.Model }`
- `setup.Ai.Enabled` = `true`
- `setup.Ai.Endpoint` = `address`
- `setup.Ai.Model` = `modelId`
- `setup.Ai` = `imported`
- `setup.PlayerName` = `value`
- `setup.Pool` = `PersonalityPools.Import(File.ReadAllText(path))`
- `setup.Pool` = `PersonalityPools.Read(imported)`
- `setup.RivalLevel` = `level.GetItemId((int)i)`
- `status.AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `status.Text` = `"已选 " + setup.Files.Count + " 个角色文件；确认后统一校验并导入。"`
- `status.Text` = `"性格池已加载。"`
- `status.Text` = `"提示词导入失败：" + e.Message`
- `status.Text` = `"提示词已载入：" + worlds.GetItemText(worlds.Selected) + (bundle.PersonalityPool != null ? "，性格池与人物比例已同步。" : "。") + "生成新世界时应用。"`
- `status.Text` = `"配置未应用：" + e.Message`
- `status.Text` = `e.Message`
- `status` = `Text("已沿用现有世界设定；导入角色保留自己的设定，随机人物按类别与性格比例生成。", 15, _muted)`
- `toggle.ButtonPressed` = `proportions.Visible`
- `toggle.Pressed` += `() => { if (busy) { toggle.ButtonPressed = proportions.Visible; return; } proportions.Visible = !proportions.Visible; toggle.ButtonPressed = proportions.Visible; toggle.QueueRedraw(); scroll.CustomMinimumSize = new(0, proportions.Visible ? 770 : 550); }`
- `weights` = `new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `worlds.ItemSelected` += `i => { if (busy) { RefreshWorlds(); return; } if (i < templates.Length) { PromptLibrary.SelectTemplate(setup.Ai, templates[(int)i].Id); return; } RefreshWorlds(); PickNestedFile("选择提示词 JSON", [".json"], path => { try { var imported = Coop.CoopJson.Copy(setup.Ai); var bundle = PromptTransfer.Read(File.ReadAllText(path)); PromptTransfer.Apply(imported, bundle); setup.Ai = imported; connection = setup.Ai.ConnectionProfiles[AiRouting.Default]; if (bundle.PersonalityPool != null) { setup.Pool = PersonalityPools.Read(imported); Weights(); } RefreshWorlds(); status.Text = "提示词已载入：" + worlds.GetItemText(worlds.Selected) + (bundle.PersonalityPool != null ? "，性格池与人物比例已同步。" : "。") + "生成新世界时应用。"; } catch (Exception e) { status.Text = "提示词导入失败：" + e.Message; } }); }`

<a id="symbol-5ef72d7dd75f"></a>

## `SubmitAsync() — async Task SubmitAsync()`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenNpcGeneration(NationalSpire.AiOptions, System.Action<NationalSpire.NpcGenerationSetup>, bool, System.Func<NationalSpire.NpcGenerationSetup, System.Threading.Tasks.Task>?, int, bool)`](NpcGenerationScreen.cs.md#symbol-fa734ac20da4)

**调用：** `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.IsQueuedForDeletion()`；[`NationalSpire.Coop.CoopJson.Copy<T>(T)`](Coop/CoopData.cs.md#symbol-38a51b2b1811)；`System.Action.Invoke()`；`System.Func<T, TResult>.Invoke(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._cancelDialog`；`NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(status)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(status) && !status.IsQueuedForDeletion()`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(this)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(this) && !IsQueuedForDeletion()`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`IsQueuedForDeletion()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsQueuedForDeletion()`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`status.IsQueuedForDeletion()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !status.IsQueuedForDeletion()`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`Coop.CoopJson.Copy(setup)`；返回值紧邻使用处：`ArgumentSyntax: Coop.CoopJson.Copy(setup)`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _cancelDialog?.Invoke()`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`selectedAsync!(Coop.CoopJson.Copy(setup))`；返回值紧邻使用处：`AwaitExpressionSyntax: await selectedAsync!(Coop.CoopJson.Copy(setup))`

**赋值（含属性/字段和局部值）：**

- `busy` = `false`
- `busy` = `true`
- `status.Text` = `"正在生成角色并建立房间……"`
- `status.Text` = `"配置未应用：" + e.Message`

<a id="symbol-bbc9ef0af3ad"></a>

## `Files() — void Files()`

来源：源码第 35 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Files()`](NpcGenerationScreen.cs.md#symbol-bbc9ef0af3ad)；[`NationalSpire.CareerScreen.OpenNpcGeneration(NationalSpire.AiOptions, System.Action<NationalSpire.NpcGenerationSetup>, bool, System.Func<NationalSpire.NpcGenerationSetup, System.Threading.Tasks.Task>?, int, bool)`](NpcGenerationScreen.cs.md#symbol-fa734ac20da4)

**调用：** [`Files()`](NpcGenerationScreen.cs.md#symbol-bbc9ef0af3ad)；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；`System.Collections.Generic.List<T>.Remove(T)`；`System.Collections.Generic.List<T>.ToArray()`；`System.IO.Path.GetFileName(string?)`

**字段、属性、事件及方法组引用：** `Files()`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.NpcGenerationSetup.Files`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Files()`；输入表达式：`Files()`；返回值紧邻使用处：`ExpressionStatementSyntax: Files();`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`files.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: files.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(Button("移除", () => { if (busy) return; setup.Files.Remove(path); Files(); }, 90))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(Button("移除", () => { if (busy) return; setup.Files.Remove(path); Files(); }, 90));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(name)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(name);`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("移除", () => { if (busy) return; setup.Files.Remove(path); Files(); }, 90)`；返回值紧邻使用处：`ArgumentSyntax: Button("移除", () => { if (busy) return; setup.Files.Remove(path); Files(); }, 90)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(Path.GetFileName(path), 16, _ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text(Path.GetFileName(path), 16, _ink)`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(files)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(files);`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`setup.Files.Remove(path)`；返回值紧邻使用处：`ExpressionStatementSyntax: setup.Files.Remove(path);`
- `System.Collections.Generic.List<T>.ToArray()`；输入表达式：`setup.Files.ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var path in setup.Files.ToArray()) { var row = new HBoxContainer(); files.AddChild(row); var name = Text(Path.GetFileName(path), 16, _ink); name.SizeFlagsHorizontal = SizeFlags.ExpandFill; name.AutowrapMode = TextServer.AutowrapMode.WordSmart; row.AddChild(name); row.AddChild(Button("移除", () => { if (busy) return; setup.Files.Remove(path); Files(); }, 90)); }`
- `System.IO.Path.GetFileName(string?)`；输入表达式：`Path.GetFileName(path)`；返回值紧邻使用处：`ArgumentSyntax: Path.GetFileName(path)`

**赋值（含属性/字段和局部值）：**

- `files.Visible` = `setup.Files.Count > 0`
- `name.AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `name.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-3c35095e983c"></a>

## `Weights() — void Weights()`

来源：源码第 45 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenNpcGeneration(NationalSpire.AiOptions, System.Action<NationalSpire.NpcGenerationSetup>, bool, System.Func<NationalSpire.NpcGenerationSetup, System.Threading.Tasks.Task>?, int, bool)`](NpcGenerationScreen.cs.md#symbol-fa734ac20da4)

**调用：** [`AddSlider(Godot.HBoxContainer, NationalSpire.PercentageSlider, bool[], int)`](NpcGenerationScreen.cs.md#symbol-31c6a4d85278)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.HSeparator.HSeparator()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.Range.SetValueNoSignal(double)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`NationalSpire.PercentageAllocation.Adjust(System.Collections.Generic.IReadOnlyList<double>, int, double, System.Collections.Generic.IReadOnlyList<bool>?)`](PercentageAllocation.cs.md#symbol-1fb1ed9d9944)；[`NationalSpire.PercentageAllocation.Normalize(System.Collections.Generic.IEnumerable<double>)`](PercentageAllocation.cs.md#symbol-deabc46c0872)；`NationalSpire.PercentageSlider.PercentageSlider()`；[`NationalSpire.PercentageSlider.Refresh()`](PercentageSlider.cs.md#symbol-087a30b22085)；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Clear()`；`System.Collections.Generic.List<T>.IndexOf(T)`；`System.Collections.Generic.List<T>.List()`

**字段、属性、事件及方法组引用：** `AddSlider(Godot.HBoxContainer, NationalSpire.PercentageSlider, bool[], int)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.NpcGenerationSetup.Pool`；`NationalSpire.PercentageAllocation.Adjust(System.Collections.Generic.IReadOnlyList<double>, int, double, System.Collections.Generic.IReadOnlyList<bool>?)`；`NationalSpire.PercentageAllocation.Normalize(System.Collections.Generic.IEnumerable<double>)`；`NationalSpire.PercentageSlider.Refresh()`；`NationalSpire.PersonalityCategory.Gender`；`NationalSpire.PersonalityCategory.Id`；`NationalSpire.PersonalityCategory.Name`；`NationalSpire.PersonalityCategory.Styles`；`NationalSpire.PersonalityCategory.Weight`；`NationalSpire.PersonalityPool.Categories`；`NationalSpire.PersonalityStyle.Id`；`NationalSpire.PersonalityStyle.Name`；`NationalSpire.PersonalityStyle.Weight`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `AddSlider(Godot.HBoxContainer, NationalSpire.PercentageSlider, bool[], int)`；输入表达式：`AddSlider(parentRow, parentSlider, categoryLocks, index)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddSlider(parentRow, parentSlider, categoryLocks, index);`
- `AddSlider(Godot.HBoxContainer, NationalSpire.PercentageSlider, bool[], int)`；输入表达式：`AddSlider(row, slider, childLocks, childIndex)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddSlider(row, slider, childLocks, childIndex);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`column.AddThemeConstantOverride("separation", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddThemeConstantOverride("separation", 8);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`parentRow.AddThemeConstantOverride("separation", 6)`；返回值紧邻使用处：`ExpressionStatementSyntax: parentRow.AddThemeConstantOverride("separation", 6);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 10);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("142734", "365565", 8, 14))`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("142734", "365565", 8, 14));`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.HSeparator.HSeparator()`；输入表达式：`new HSeparator()`；返回值紧邻使用处：`ArgumentSyntax: new HSeparator()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`column.AddChild(Text("类别内性格 · 合计 100%", 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddChild(Text("类别内性格 · 合计 100%", 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`column.AddChild(Text(category.Name + " · " + category.Gender, 19, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddChild(Text(category.Name + " · " + category.Gender, 19, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`column.AddChild(new HSeparator())`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddChild(new HSeparator());`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`column.AddChild(parentRow)`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddChild(parentRow);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`column.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(column)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(column);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(name)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(name);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`weights.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: weights.AddChild(panel);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Range.SetValueNoSignal(double)`；输入表达式：`categorySliders[j].SetValueNoSignal(adjusted[j])`；返回值紧邻使用处：`ExpressionStatementSyntax: categorySliders[j].SetValueNoSignal(adjusted[j]);`
- `Godot.Range.SetValueNoSignal(double)`；输入表达式：`children[k].SetValueNoSignal(adjusted[k])`；返回值紧邻使用处：`ExpressionStatementSyntax: children[k].SetValueNoSignal(adjusted[k]);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(76, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: name.CustomMinimumSize = new(76, 0)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("类别内性格 · 合计 100%", 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("类别内性格 · 合计 100%", 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(category.Name + " · " + category.Gender, 19, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(category.Name + " · " + category.Gender, 19, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(style.Name, 17, _ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text(style.Name, 17, _ink)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("142734", "365565", 8, 14)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("142734", "365565", 8, 14)`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(weights)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(weights);`
- `NationalSpire.PercentageAllocation.Adjust(System.Collections.Generic.IReadOnlyList<double>, int, double, System.Collections.Generic.IReadOnlyList<bool>?)`；输入表达式：`PercentageAllocation.Adjust(categories.Select(c => c.Weight).ToArray(), index, value, categoryLocks)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PercentageAllocation.Adjust(categories.Select(c => c.Weight).ToArray(), index, value, categoryLocks)`
- `NationalSpire.PercentageAllocation.Adjust(System.Collections.Generic.IReadOnlyList<double>, int, double, System.Collections.Generic.IReadOnlyList<bool>?)`；输入表达式：`PercentageAllocation.Adjust(styles.Select(s => s.Weight).ToArray(), childIndex, value, childLocks)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PercentageAllocation.Adjust(styles.Select(s => s.Weight).ToArray(), childIndex, value, childLocks)`
- `NationalSpire.PercentageAllocation.Normalize(System.Collections.Generic.IEnumerable<double>)`；输入表达式：`PercentageAllocation.Normalize(categories.Select(c => c.Weight))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PercentageAllocation.Normalize(categories.Select(c => c.Weight))`
- `NationalSpire.PercentageAllocation.Normalize(System.Collections.Generic.IEnumerable<double>)`；输入表达式：`PercentageAllocation.Normalize(styles.Select(s => s.Weight))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PercentageAllocation.Normalize(styles.Select(s => s.Weight))`
- `NationalSpire.PercentageSlider.PercentageSlider()`；输入表达式：`new PercentageSlider { Name = "CategoryPercent_" + category.Id, Value = category.Weight, Editable = categories.Count > 1 }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PercentageSlider { Name = "CategoryPercent_" + category.Id, Value = category.Weight, Editable = categories.Count > 1 }`
- `NationalSpire.PercentageSlider.PercentageSlider()`；输入表达式：`new PercentageSlider { Name = "StylePercent_" + category.Id + "_" + style.Id, Value = style.Weight, Editable = styles.Count > 1 }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PercentageSlider { Name = "StylePercent_" + category.Id + "_" + style.Id, Value = style.Weight, Editable = styles.Count > 1 }`
- `NationalSpire.PercentageSlider.Refresh()`；输入表达式：`categorySliders[j].Refresh()`；返回值紧邻使用处：`ExpressionStatementSyntax: categorySliders[j].Refresh();`
- `NationalSpire.PercentageSlider.Refresh()`；输入表达式：`children[k].Refresh()`；返回值紧邻使用处：`ExpressionStatementSyntax: children[k].Refresh();`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`categories.Select(c => c.Weight)`；返回值紧邻使用处：`ArgumentSyntax: categories.Select(c => c.Weight)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`categories.Select(c => c.Weight)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: categories.Select(c => c.Weight).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`styles.Select(s => s.Weight)`；返回值紧邻使用处：`ArgumentSyntax: styles.Select(s => s.Weight)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`styles.Select(s => s.Weight)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: styles.Select(s => s.Weight).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`categories.Select(c => c.Weight).ToArray()`；返回值紧邻使用处：`ArgumentSyntax: categories.Select(c => c.Weight).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`styles.Select(s => s.Weight).ToArray()`；返回值紧邻使用处：`ArgumentSyntax: styles.Select(s => s.Weight).ToArray()`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`categorySliders.Add(parentSlider)`；返回值紧邻使用处：`ExpressionStatementSyntax: categorySliders.Add(parentSlider);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`children.Add(slider)`；返回值紧邻使用处：`ExpressionStatementSyntax: children.Add(slider);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`sliders.Add(parentSlider)`；返回值紧邻使用处：`ExpressionStatementSyntax: sliders.Add(parentSlider);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`sliders.Add(slider)`；返回值紧邻使用处：`ExpressionStatementSyntax: sliders.Add(slider);`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`sliders.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: sliders.Clear();`
- `System.Collections.Generic.List<T>.IndexOf(T)`；输入表达式：`categories.IndexOf(category)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = categories.IndexOf(category)`
- `System.Collections.Generic.List<T>.IndexOf(T)`；输入表达式：`styles.IndexOf(style)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = styles.IndexOf(style)`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<PercentageSlider>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<PercentageSlider>()`

**赋值（含属性/字段和局部值）：**

- `Editable` = `categories.Count > 1`
- `Editable` = `styles.Count > 1`
- `Name` = `"CategoryPercent_" + category.Id`
- `Name` = `"StylePercent_" + category.Id + "_" + style.Id`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Value` = `category.Weight`
- `Value` = `style.Weight`
- `categories[i].Weight` = `categoryValues[i]`
- `categories[j].Weight` = `adjusted[j]`
- `name.AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `name.CustomMinimumSize` = `new(76, 0)`
- `name.SizeFlagsHorizontal` = `SizeFlags.Fill`
- `parentSlider.ValueChanged` += `value => { if (updating) return; updating = true; var adjusted = PercentageAllocation.Adjust(categories.Select(c => c.Weight).ToArray(), index, value, categoryLocks); for (int j = 0; j < categories.Count; j++) { categories[j].Weight = adjusted[j]; categorySliders[j].SetValueNoSignal(adjusted[j]); categorySliders[j].Refresh(); } updating = false; }`
- `slider.ValueChanged` += `value => { if (updating) return; updating = true; var adjusted = PercentageAllocation.Adjust(styles.Select(s => s.Weight).ToArray(), childIndex, value, childLocks); for (int k = 0; k < styles.Count; k++) { styles[k].Weight = adjusted[k]; children[k].SetValueNoSignal(adjusted[k]); children[k].Refresh(); } updating = false; }`
- `styles[j].Weight` = `values[j]`
- `styles[k].Weight` = `adjusted[k]`
- `updating` = `false`
- `updating` = `true`

<a id="symbol-31c6a4d85278"></a>

## `AddSlider(Godot.HBoxContainer, NationalSpire.PercentageSlider, bool[], int) — void AddSlider(HBoxContainer row, PercentageSlider slider, bool[] locks, int index)`

来源：源码第 53 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Weights()`](NpcGenerationScreen.cs.md#symbol-3c35095e983c)

**调用：** `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`NationalSpire.PercentageLockButton.PercentageLockButton()`；[`NationalSpire.PercentageSlider.Commit()`](PercentageSlider.cs.md#symbol-013abce752a0)

**字段、属性、事件及方法组引用：** `NationalSpire.PercentageSlider.Commit()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(slider)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(slider);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(toggle)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(toggle);`
- `NationalSpire.PercentageLockButton.PercentageLockButton()`；输入表达式：`new PercentageLockButton { Name = slider.Name + "_Lock" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PercentageLockButton { Name = slider.Name + "_Lock" }`
- `NationalSpire.PercentageSlider.Commit()`；输入表达式：`slider.Commit()`；返回值紧邻使用处：`ExpressionStatementSyntax: slider.Commit();`

**赋值（含属性/字段和局部值）：**

- `Name` = `slider.Name + "_Lock"`
- `locks[index]` = `locked`
- `slider.Editable` = `!locked && locks.Length > 1`
- `toggle.Toggled` += `locked => { slider.Commit(); locks[index] = locked; slider.Editable = !locked && locks.Length > 1; }`

<a id="symbol-a4f7a7bc2bf3"></a>

## `SettingRow(string) — HBoxContainer SettingRow(string title)`

来源：源码第 131 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenNpcGeneration(NationalSpire.AiOptions, System.Action<NationalSpire.NpcGenerationSetup>, bool, System.Func<NationalSpire.NpcGenerationSetup, System.Threading.Tasks.Task>?, int, bool)`](NpcGenerationScreen.cs.md#symbol-fa734ac20da4)

**调用：** `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen._gold`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 16);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(label)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(label);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(190, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: label.CustomMinimumSize = new(190, 0)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(title, 20, _gold)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text(title, 20, _gold)`

**赋值（含属性/字段和局部值）：**

- `label.CustomMinimumSize` = `new(190, 0)`

<a id="symbol-a2752f80a146"></a>

## `RefreshWorlds() — void RefreshWorlds()`

来源：源码第 140 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenNpcGeneration(NationalSpire.AiOptions, System.Action<NationalSpire.NpcGenerationSetup>, bool, System.Func<NationalSpire.NpcGenerationSetup, System.Threading.Tasks.Task>?, int, bool)`](NpcGenerationScreen.cs.md#symbol-fa734ac20da4)

**调用：** `Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.AddSeparator(string)`；`Godot.OptionButton.Clear()`；`Godot.OptionButton.Select(int)`；[`NationalSpire.PromptLibrary.AvailableTemplates(NationalSpire.AiOptions)`](CustomPromptTemplates.cs.md#symbol-034310e38b45)；[`NationalSpire.PromptLibrary.TemplateId(NationalSpire.AiOptions)`](PromptTemplates.cs.md#symbol-51c9e7869e6e)；`System.Array.FindIndex<T>(T[], System.Predicate<T>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.NpcGenerationSetup.Ai`；`NationalSpire.PromptLibrary.AvailableTemplates(NationalSpire.AiOptions)`；`NationalSpire.PromptLibrary.TemplateId(NationalSpire.AiOptions)`；`NationalSpire.PromptTemplate.Id`；`NationalSpire.PromptTemplate.Name`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`worlds.AddItem("导入提示词…")`；返回值紧邻使用处：`ExpressionStatementSyntax: worlds.AddItem("导入提示词…");`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`worlds.AddItem(template.Name)`；返回值紧邻使用处：`ExpressionStatementSyntax: worlds.AddItem(template.Name);`
- `Godot.OptionButton.AddSeparator(string)`；输入表达式：`worlds.AddSeparator()`；返回值紧邻使用处：`ExpressionStatementSyntax: worlds.AddSeparator();`
- `Godot.OptionButton.Clear()`；输入表达式：`worlds.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: worlds.Clear();`
- `Godot.OptionButton.Select(int)`；输入表达式：`worlds.Select(Array.FindIndex(templates, t => t.Id == PromptLibrary.TemplateId(setup.Ai)))`；返回值紧邻使用处：`ExpressionStatementSyntax: worlds.Select(Array.FindIndex(templates, t => t.Id == PromptLibrary.TemplateId(setup.Ai)));`
- `NationalSpire.PromptLibrary.AvailableTemplates(NationalSpire.AiOptions)`；输入表达式：`PromptLibrary.AvailableTemplates(setup.Ai)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PromptLibrary.AvailableTemplates(setup.Ai).ToArray`
- `NationalSpire.PromptLibrary.TemplateId(NationalSpire.AiOptions)`；输入表达式：`PromptLibrary.TemplateId(setup.Ai)`；返回值紧邻使用处：`BinaryExpressionSyntax: t.Id == PromptLibrary.TemplateId(setup.Ai)`
- `System.Array.FindIndex<T>(T[], System.Predicate<T>)`；输入表达式：`Array.FindIndex(templates, t => t.Id == PromptLibrary.TemplateId(setup.Ai))`；返回值紧邻使用处：`ArgumentSyntax: Array.FindIndex(templates, t => t.Id == PromptLibrary.TemplateId(setup.Ai))`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`PromptLibrary.AvailableTemplates(setup.Ai).ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: templates = PromptLibrary.AvailableTemplates(setup.Ai).ToArray()`

**赋值（含属性/字段和局部值）：**

- `templates` = `PromptLibrary.AvailableTemplates(setup.Ai).ToArray()`

<a id="symbol-889f6f04d436"></a>

## `Input(Godot.VBoxContainer, string, string, string) — LineEdit Input(VBoxContainer parent, string title, string value, string name)`

来源：源码第 172 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenNpcGeneration(NationalSpire.AiOptions, System.Action<NationalSpire.NpcGenerationSetup>, bool, System.Func<NationalSpire.NpcGenerationSetup, System.Threading.Tasks.Task>?, int, bool)`](NpcGenerationScreen.cs.md#symbol-fa734ac20da4)

**调用：** `Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen._muted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Name = name, Text = value, CustomMinimumSize = new(0, 40), SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LineEdit { Name = name, Text = value, CustomMinimumSize = new(0, 40), SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(Text(title, 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(Text(title, 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(input)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(input);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 40)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 40)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(title, 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(title, 16, _muted)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(0, 40)`
- `Name` = `name`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Text` = `value`

<a id="symbol-b4785dd51d2b"></a>

## `NationalSpire.CareerScreen.BeginNpcSetup(bool) — private void BeginNpcSetup(bool reset)`

来源：源码第 231 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AiSettings(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-6dafb04d04fd)；[`NationalSpire.CareerScreen.OpenCareerLibrary()`](CareerLibraryScreen.cs.md#symbol-57e1d5f83960)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)

**调用：** `Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`；[`NationalSpire.CareerLibrary.Create(string, NationalSpire.CareerData)`](CareerLibrary.cs.md#symbol-bb2b0ce2be9d)；[`NationalSpire.CareerScreen.OpenNpcGeneration(NationalSpire.AiOptions, System.Action<NationalSpire.NpcGenerationSetup>, bool, System.Func<NationalSpire.NpcGenerationSetup, System.Threading.Tasks.Task>?, int, bool)`](NpcGenerationScreen.cs.md#symbol-fa734ac20da4)；[`NationalSpire.CareerScreen.ResetNavigation()`](CareerNavigation.cs.md#symbol-870e8f5590bb)；[`NationalSpire.CareerStore.ReplaceFreshCareer(NationalSpire.CareerData)`](CareerStore.cs.md#symbol-b15d2f44132b)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.CareerStore.SwitchCareer(string)`](CareerStore.cs.md#symbol-67c415b86d89)；[`NationalSpire.NpcGeneration.Create(NationalSpire.AiOptions, NationalSpire.NpcGenerationSetup)`](NpcGenerationSetup.cs.md#symbol-c3f59c3c9460)；[`NationalSpire.NpcGeneration.ImportBatch.Commit()`](NpcGenerationSetup.cs.md#symbol-9e8174232934)；[`NationalSpire.NpcGeneration.ImportBatch.ImportBatch(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`](NpcGenerationSetup.cs.md#symbol-023f02ec9cbf)；`System.Action.Invoke()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Ai`；`NationalSpire.CareerData.NpcSetupPending`；`NationalSpire.CareerData.RivalLevel`；`NationalSpire.CareerLibrary.Create(string, NationalSpire.CareerData)`；`NationalSpire.CareerScreen.OpenNpcGeneration(NationalSpire.AiOptions, System.Action<NationalSpire.NpcGenerationSetup>, bool, System.Func<NationalSpire.NpcGenerationSetup, System.Threading.Tasks.Task>?, int, bool)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.ResetNavigation()`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._boundData`；`NationalSpire.CareerScreen._cancelDialog`；`NationalSpire.CareerScreen._confirmReset`；`NationalSpire.CareerScreen._npcSetupOpening`；`NationalSpire.CareerStore.DefaultPath`；`NationalSpire.CareerStore.ReplaceFreshCareer(NationalSpire.CareerData)`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.CareerStore.SwitchCareer(string)`；`NationalSpire.NpcGeneration.Create(NationalSpire.AiOptions, NationalSpire.NpcGenerationSetup)`；`NationalSpire.NpcGeneration.ImportBatch.Commit()`；`NationalSpire.NpcGenerationSetup.Files`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(Render).CallDeferred()`；返回值紧邻使用处：`ExpressionStatementSyntax: Callable.From(Render).CallDeferred();`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(Render)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(Render).CallDeferred`
- `NationalSpire.CareerLibrary.Create(string, NationalSpire.CareerData)`；输入表达式：`CareerLibrary.Create(CareerStore.DefaultPath, fresh)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerLibrary.Create(CareerStore.DefaultPath, fresh)`
- `NationalSpire.CareerScreen.OpenNpcGeneration(NationalSpire.AiOptions, System.Action<NationalSpire.NpcGenerationSetup>, bool, System.Func<NationalSpire.NpcGenerationSetup, System.Threading.Tasks.Task>?, int, bool)`；输入表达式：`OpenNpcGeneration(ViewData.Ai, plan => { var fresh = NpcGeneration.Create(ViewData.Ai, plan); using var imported = new NpcGeneration.ImportBatch(fresh, plan.Files); if (reset) _boundData = CareerStore.ReplaceFreshCareer(fresh); else { var path = CareerLibrary.Create(CareerStore.DefaultPath, fresh); imported.Commit(); _boundData = CareerStore.SwitchCareer(path); _boundData.Ai = fresh.Ai; CareerStore.Save(_boundData); } imported.Commit(); _npcSetupOpening = false; _confirmReset = false; ResetNavigation(); Callable.From(Render).CallDeferred(); }, required: ViewData.NpcSetupPending, rivalLevel: ViewData.RivalLevel)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenNpcGeneration(ViewData.Ai, plan => { var fresh = NpcGeneration.Create(ViewData.Ai, plan); using var imported = new NpcGeneration.ImportBatch(fresh, plan.Files); if (reset) _boundData = CareerStore.ReplaceFreshCareer(fresh); else { var path = CareerLibrary.Create(CareerStore.DefaultPath, fresh); imported.Commit(); _boundData = CareerStore.SwitchCareer(path); _boundData.Ai = fresh.Ai; CareerStore.Save(_boundData); } imported.Commit(); _npcSetupOpening = false; _confirmReset = false; ResetNavigation(); Callable.From(Render).CallDeferred(); }, required: ViewData.NpcSetupPending, rivalLevel: ViewData.RivalLevel);`
- `NationalSpire.CareerScreen.ResetNavigation()`；输入表达式：`ResetNavigation()`；返回值紧邻使用处：`ExpressionStatementSyntax: ResetNavigation();`
- `NationalSpire.CareerStore.ReplaceFreshCareer(NationalSpire.CareerData)`；输入表达式：`CareerStore.ReplaceFreshCareer(fresh)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _boundData = CareerStore.ReplaceFreshCareer(fresh)`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(_boundData)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(_boundData);`
- `NationalSpire.CareerStore.SwitchCareer(string)`；输入表达式：`CareerStore.SwitchCareer(path)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _boundData = CareerStore.SwitchCareer(path)`
- `NationalSpire.NpcGeneration.Create(NationalSpire.AiOptions, NationalSpire.NpcGenerationSetup)`；输入表达式：`NpcGeneration.Create(ViewData.Ai, plan)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = NpcGeneration.Create(ViewData.Ai, plan)`
- `NationalSpire.NpcGeneration.ImportBatch.Commit()`；输入表达式：`imported.Commit()`；返回值紧邻使用处：`ExpressionStatementSyntax: imported.Commit();`
- `NationalSpire.NpcGeneration.ImportBatch.ImportBatch(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`；输入表达式：`new NpcGeneration.ImportBatch(fresh, plan.Files)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new NpcGeneration.ImportBatch(fresh, plan.Files)`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _cancelDialog?.Invoke()`

**赋值（含属性/字段和局部值）：**

- `_boundData.Ai` = `fresh.Ai`
- `_boundData` = `CareerStore.ReplaceFreshCareer(fresh)`
- `_boundData` = `CareerStore.SwitchCareer(path)`
- `_confirmReset` = `false`
- `_npcSetupOpening` = `false`
