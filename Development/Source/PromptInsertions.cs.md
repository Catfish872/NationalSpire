# PromptInsertions.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`CFC7B3945E6EF0D7E15ACA362256F42E891D70F35839CF86F9D7987A8EA82A95`。来源：[源码](../../PromptInsertions.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.PromptInsertion`、`NationalSpire.PromptInsertionSettings`、`NationalSpire.PromptInsertions`。

字段、事件及初始值（源码原样）：

```csharp
public static readonly string[] Positions = ["在所有提示词前插入", "在对话输入前插入", "在对话输入后插入", "在所有提示词后插入"];
public static readonly string[] Scenes = ["private", "group", "community", "date"];
private static PromptInsertionSettings? _settings;
```

<a id="symbol-eebfb46170d2"></a>

## `NationalSpire.PromptInsertion.Text — public string Text`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f45ad1752896"></a>

## `NationalSpire.PromptInsertion.Position — public int Position`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-5b45328f43b6"></a>

## `NationalSpire.PromptInsertionSettings.Slots — public List<PromptInsertion> Slots`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7eb348ff005a"></a>

## `NationalSpire.PromptInsertionSettings.Enabled — public Dictionary<string, bool[]> Enabled`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-245af619eff3"></a>

## `NationalSpire.PromptInsertions.FilePath — public static string FilePath`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.ProjectSettings.GlobalizePath(string)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ProjectSettings.GlobalizePath(string)`；输入表达式：`ProjectSettings.GlobalizePath("user://national_spire_prompt_insertions.json")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => ProjectSettings.GlobalizePath("user://national_spire_prompt_insertions.json")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3d35c3f46165"></a>

## `NationalSpire.PromptInsertions.Settings — public static PromptInsertionSettings Settings`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.GD.PushWarning(string)`；`NationalSpire.PromptInsertionSettings.PromptInsertionSettings()`；[`NationalSpire.PromptInsertions.Normalize(NationalSpire.PromptInsertionSettings)`](PromptInsertions.cs.md#symbol-616d7071f399)；`System.IO.File.Exists(string?)`；`System.IO.File.ReadAllText(string)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.PromptInsertions.FilePath`；`NationalSpire.PromptInsertions.Normalize(NationalSpire.PromptInsertionSettings)`；`NationalSpire.PromptInsertions._settings`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GD.PushWarning(string)`；输入表达式：`GD.PushWarning("[NationalSpire] 提示词插入配置读取失败，使用空白配置。")`；返回值紧邻使用处：`ExpressionStatementSyntax: GD.PushWarning("[NationalSpire] 提示词插入配置读取失败，使用空白配置。");`
- `NationalSpire.PromptInsertionSettings.PromptInsertionSettings()`；输入表达式：`new()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _settings ??= new()`
- `NationalSpire.PromptInsertions.Normalize(NationalSpire.PromptInsertionSettings)`；输入表达式：`Normalize(_settings)`；返回值紧邻使用处：`ExpressionStatementSyntax: Normalize(_settings);`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(FilePath)`；返回值紧邻使用处：`ConditionalExpressionSyntax: File.Exists(FilePath) ? JsonSerializer.Deserialize<PromptInsertionSettings>(File.ReadAllText(FilePath)) : null`
- `System.IO.File.ReadAllText(string)`；输入表达式：`File.ReadAllText(FilePath)`；返回值紧邻使用处：`ArgumentSyntax: File.ReadAllText(FilePath)`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<PromptInsertionSettings>(File.ReadAllText(FilePath))`；返回值紧邻使用处：`ConditionalExpressionSyntax: File.Exists(FilePath) ? JsonSerializer.Deserialize<PromptInsertionSettings>(File.ReadAllText(FilePath)) : null`

**赋值（含属性/字段和局部值）：**

- `_settings` = `File.Exists(FilePath) ? JsonSerializer.Deserialize<PromptInsertionSettings>(File.ReadAllText(FilePath)) : null`
- `_settings` ??= `new()`

<a id="symbol-616d7071f399"></a>

## `NationalSpire.PromptInsertions.Normalize(NationalSpire.PromptInsertionSettings) — public static void Normalize(PromptInsertionSettings settings)`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PromptInsertions.Settings`](PromptInsertions.cs.md#symbol-3d35c3f46165)

**调用：** `NationalSpire.PromptInsertion.PromptInsertion()`；`System.Collections.Generic.IEnumerable<TSource>.ElementAtOrDefault<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Linq.Enumerable.Range(int, int)`；`System.Math.Clamp(int, int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.PromptInsertion.Position`；`NationalSpire.PromptInsertion.Text`；`NationalSpire.PromptInsertionSettings.Enabled`；`NationalSpire.PromptInsertionSettings.Slots`；`NationalSpire.PromptInsertions.Scenes`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PromptInsertion.PromptInsertion()`；输入表达式：`new()`；返回值紧邻使用处：`BinaryExpressionSyntax: settings.Slots.ElementAtOrDefault(i) ?? new()`
- `System.Collections.Generic.IEnumerable<TSource>.ElementAtOrDefault<TSource>(int)`；输入表达式：`.ElementAtOrDefault(i)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: settings.Enabled.GetValueOrDefault(scene)?.ElementAtOrDefault(i)`
- `System.Collections.Generic.IEnumerable<TSource>.ElementAtOrDefault<TSource>(int)`；输入表达式：`settings.Slots.ElementAtOrDefault(i)`；返回值紧邻使用处：`BinaryExpressionSyntax: settings.Slots.ElementAtOrDefault(i) ?? new()`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Enumerable.Range(0, 4).Select(i => settings.Enabled.GetValueOrDefault(scene)?.ElementAtOrDefault(i) == true)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0, 4).Select(i => settings.Enabled.GetValueOrDefault(scene)?.ElementAtOrDefault(i) == true).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Enumerable.Range(0, 4).Select(i => settings.Slots.ElementAtOrDefault(i) ?? new())`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0, 4).Select(i => settings.Slots.ElementAtOrDefault(i) ?? new()).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Enumerable.Range(0, 4).Select(i => settings.Enabled.GetValueOrDefault(scene)?.ElementAtOrDefault(i) == true).ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: settings.Enabled[scene] = Enumerable.Range(0, 4).Select(i => settings.Enabled.GetValueOrDefault(scene)?.ElementAtOrDefault(i) == true).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`Enumerable.Range(0, 4).Select(i => settings.Slots.ElementAtOrDefault(i) ?? new()).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: settings.Slots = Enumerable.Range(0, 4).Select(i => settings.Slots.ElementAtOrDefault(i) ?? new()).ToList()`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`settings.Enabled.GetValueOrDefault(scene)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: settings.Enabled.GetValueOrDefault(scene)?.ElementAtOrDefault(i)`
- `System.Linq.Enumerable.Range(int, int)`；输入表达式：`Enumerable.Range(0, 4)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0, 4).Select`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(slot.Position, 0, 3)`；返回值紧邻使用处：`AssignmentExpressionSyntax: slot.Position = Math.Clamp(slot.Position, 0, 3)`

**赋值（含属性/字段和局部值）：**

- `settings.Enabled[scene]` = `Enumerable.Range(0, 4).Select(i => settings.Enabled.GetValueOrDefault(scene)?.ElementAtOrDefault(i) == true).ToArray()`
- `settings.Enabled` ??= `[]`
- `settings.Slots` = `Enumerable.Range(0, 4).Select(i => settings.Slots.ElementAtOrDefault(i) ?? new()).ToList()`
- `settings.Slots` ??= `[]`
- `slot.Position` = `Math.Clamp(slot.Position, 0, 3)`
- `slot.Text` ??= `""`

<a id="symbol-ab02e6f288c3"></a>

## `NationalSpire.PromptInsertions.Save() — public static void Save()`

来源：源码第 41 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Save()`](PromptInsertionScreen.cs.md#symbol-c2cd5419d101)

**调用：** `System.IO.Directory.CreateDirectory(string)`；`System.IO.File.Delete(string)`；`System.IO.File.Exists(string?)`；`System.IO.File.Move(string, string, bool)`；`System.IO.File.WriteAllText(string, string?)`；`System.IO.Path.GetDirectoryName(string?)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.PortraitDesigns.Json`；`NationalSpire.PromptInsertions.FilePath`；`NationalSpire.PromptInsertions.Settings`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.IO.Directory.CreateDirectory(string)`；输入表达式：`Directory.CreateDirectory(Path.GetDirectoryName(path)!)`；返回值紧邻使用处：`ExpressionStatementSyntax: Directory.CreateDirectory(Path.GetDirectoryName(path)!);`
- `System.IO.File.Delete(string)`；输入表达式：`File.Delete(temporary)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Delete(temporary);`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(temporary)`；返回值紧邻使用处：`IfStatementSyntax: if (File.Exists(temporary)) File.Delete(temporary);`
- `System.IO.File.Move(string, string, bool)`；输入表达式：`File.Move(temporary, path, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Move(temporary, path, true);`
- `System.IO.File.WriteAllText(string, string?)`；输入表达式：`File.WriteAllText(temporary, JsonSerializer.Serialize(Settings, PortraitDesigns.Json))`；返回值紧邻使用处：`ExpressionStatementSyntax: File.WriteAllText(temporary, JsonSerializer.Serialize(Settings, PortraitDesigns.Json));`
- `System.IO.Path.GetDirectoryName(string?)`；输入表达式：`Path.GetDirectoryName(path)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: Path.GetDirectoryName(path)!`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(Settings, PortraitDesigns.Json)`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.Serialize(Settings, PortraitDesigns.Json)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-333725b6545b"></a>

## `NationalSpire.PromptInsertions.Capture(string) — public static List<PromptInsertion> Capture(string scene)`

来源：源码第 48 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.CreateReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-592b8f5f225f)；[`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`](GroupChatScreen.cs.md#symbol-9f2d53ad7587)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.RenderPostComposer(NationalSpire.CareerData)`](CommunityScreen.cs.md#symbol-02ed3035beb3)；[`NationalSpire.Coop.CoopCareerSession.Send(string, string, string, int, string, System.Action?)`](Coop/CoopCareerSession.cs.md#symbol-b761b96e0df4)

**调用：** [`NationalSpire.PromptInsertions.Copy(System.Collections.Generic.IEnumerable<NationalSpire.PromptInsertion>?)`](PromptInsertions.cs.md#symbol-511fbf5c4ca1)；`System.Collections.Generic.IEnumerable<TSource>.ElementAtOrDefault<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, int, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.PromptInsertionSettings.Enabled`；`NationalSpire.PromptInsertionSettings.Slots`；`NationalSpire.PromptInsertions.Copy(System.Collections.Generic.IEnumerable<NationalSpire.PromptInsertion>?)`；`NationalSpire.PromptInsertions.Settings`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PromptInsertions.Copy(System.Collections.Generic.IEnumerable<NationalSpire.PromptInsertion>?)`；输入表达式：`Copy(Settings.Slots.Where((s, i) => Settings.Enabled.GetValueOrDefault(scene)?.ElementAtOrDefault(i) == true))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Copy(Settings.Slots.Where((s, i) => Settings.Enabled.GetValueOrDefault(scene)?.ElementAtOrDefault(i) == true))`
- `System.Collections.Generic.IEnumerable<TSource>.ElementAtOrDefault<TSource>(int)`；输入表达式：`.ElementAtOrDefault(i)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Settings.Enabled.GetValueOrDefault(scene)?.ElementAtOrDefault(i)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, int, bool>)`；输入表达式：`Settings.Slots.Where((s, i) => Settings.Enabled.GetValueOrDefault(scene)?.ElementAtOrDefault(i) == true)`；返回值紧邻使用处：`ArgumentSyntax: Settings.Slots.Where((s, i) => Settings.Enabled.GetValueOrDefault(scene)?.ElementAtOrDefault(i) == true)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`Settings.Enabled.GetValueOrDefault(scene)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Settings.Enabled.GetValueOrDefault(scene)?.ElementAtOrDefault(i)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-511fbf5c4ca1"></a>

## `NationalSpire.PromptInsertions.Copy(System.Collections.Generic.IEnumerable<NationalSpire.PromptInsertion>?) — public static List<PromptInsertion> Copy(IEnumerable<PromptInsertion>? entries)`

来源：源码第 50 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityThreads.Publish(NationalSpire.CareerData, string, string, System.Collections.Generic.List<NationalSpire.PromptInsertion>?)`](CommunityThreads.cs.md#symbol-d9b68d9a8f52)；[`NationalSpire.CommunityThreads.Submit(NationalSpire.CareerData, NationalSpire.CommunityPost, string, string, System.Collections.Generic.List<NationalSpire.PromptInsertion>?)`](CommunityThreads.cs.md#symbol-4de765d004ff)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)；[`NationalSpire.GroupChats.Command(NationalSpire.CareerData, string, string, NationalSpire.GroupCommand)`](GroupChats.cs.md#symbol-e0439deb45ac)；[`NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-81ef5fba41b8)；[`NationalSpire.PromptInsertions.Capture(string)`](PromptInsertions.cs.md#symbol-333725b6545b)；[`NationalSpire.RelationshipPresentation.Decide(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](RelationshipPresentation.cs.md#symbol-808145b97462)

**调用：** `NationalSpire.PromptInsertion.PromptInsertion()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`string.IsNullOrWhiteSpace(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.PromptInsertion.Position`；`NationalSpire.PromptInsertion.Text`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PromptInsertion.PromptInsertion()`；输入表达式：`new PromptInsertion { Text = s.Text, Position = s.Position }`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: s => new PromptInsertion { Text = s.Text, Position = s.Position }`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`(entries ?? []).Where(s => s != null && s.Position is >= 0 and <= 3 && !string.IsNullOrWhiteSpace(s.Text)).Take(4) .Select(s => new PromptInsertion { Text = s.Text, Position = s.Position })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: (entries ?? []).Where(s => s != null && s.Position is >= 0 and <= 3 && !string.IsNullOrWhiteSpace(s.Text)).Take(4) .Select(s => new PromptInsertion { Text = s.Text, Position = s.Position }).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`(entries ?? []).Where(s => s != null && s.Position is >= 0 and <= 3 && !string.IsNullOrWhiteSpace(s.Text)).Take(4)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: (entries ?? []).Where(s => s != null && s.Position is >= 0 and <= 3 && !string.IsNullOrWhiteSpace(s.Text)).Take(4) .Select`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`(entries ?? []).Where(s => s != null && s.Position is >= 0 and <= 3 && !string.IsNullOrWhiteSpace(s.Text)).Take(4) .Select(s => new PromptInsertion { Text = s.Text, Position = s.Position }).ToList()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => (entries ?? []).Where(s => s != null && s.Position is >= 0 and <= 3 && !string.IsNullOrWhiteSpace(s.Text)).Take(4) .Select(s => new PromptInsertion { Text = s.Text, Position = s.Position }).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`(entries ?? []).Where(s => s != null && s.Position is >= 0 and <= 3 && !string.IsNullOrWhiteSpace(s.Text))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: (entries ?? []).Where(s => s != null && s.Position is >= 0 and <= 3 && !string.IsNullOrWhiteSpace(s.Text)).Take`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(s.Text)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !string.IsNullOrWhiteSpace(s.Text)`

**赋值（含属性/字段和局部值）：**

- `Position` = `s.Position`
- `Text` = `s.Text`

<a id="symbol-3d0f6f332049"></a>

## `NationalSpire.PromptInsertions.Around(string, System.Collections.Generic.IEnumerable<NationalSpire.PromptInsertion>?, int, int) — public static string Around(string text, IEnumerable<PromptInsertion>? entries, int before, int after)`

来源：源码第 53 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupArbitration.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn)`](GroupArbitration.cs.md#symbol-af12ffcc2740)；[`NationalSpire.GroupChatPrompts.UserText(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn, System.Collections.Generic.List<NationalSpire.PromptInsertion>?)`](GroupChatPrompts.cs.md#symbol-28b2a2534bee)；[`NationalSpire.PrivateMessagePrompts.UserText(NationalSpire.PrivateTurn, NationalSpire.PrivateConversation, bool, System.Collections.Generic.List<NationalSpire.PromptInsertion>?)`](PrivateMessagePrompts.cs.md#symbol-a6aa8a8392b1)；[`NationalSpire.PromptInsertions.Apply(System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, System.Collections.Generic.IEnumerable<NationalSpire.PromptInsertion>?)`](PromptInsertions.cs.md#symbol-35674fc9b589)；[`NationalSpire.PromptInsertions.Discussion(NationalSpire.AiWireProtocol, System.Collections.Generic.ISet<string>, System.Collections.Generic.List<NationalSpire.CommunityPost>, string, string)`](PromptInsertions.cs.md#symbol-d7ee7742c680)；[`NationalSpire.SpireArbitration.Compose(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn)`](SpireArbitration.cs.md#symbol-6116255f39e7)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`

**字段、属性、事件及方法组引用：** `NationalSpire.PromptInsertion.Position`；`NationalSpire.PromptInsertion.Text`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`active.Where(s => s.Position == after).Select(s => s.Text)`；返回值紧邻使用处：`ArgumentSyntax: active.Where(s => s.Position == after).Select(s => s.Text)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`active.Where(s => s.Position == before).Select(s => s.Text)`；返回值紧邻使用处：`ArgumentSyntax: active.Where(s => s.Position == before).Select(s => s.Text)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`(entries ?? []).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = (entries ?? []).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`active.Where(s => s.Position == after)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: active.Where(s => s.Position == after).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`active.Where(s => s.Position == before)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: active.Where(s => s.Position == before).Select`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n", active.Where(s => s.Position == after).Select(s => s.Text))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = string.Join("\n", active.Where(s => s.Position == after).Select(s => s.Text))`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n", active.Where(s => s.Position == before).Select(s => s.Text))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = string.Join("\n", active.Where(s => s.Position == before).Select(s => s.Text))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-35674fc9b589"></a>

## `NationalSpire.PromptInsertions.Apply(System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, System.Collections.Generic.IEnumerable<NationalSpire.PromptInsertion>?) — public static List<Dictionary<string, string>> Apply(List<Dictionary<string, string>> messages, IEnumerable<PromptInsertion>? entries)`

来源：源码第 60 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupArbitration.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn)`](GroupArbitration.cs.md#symbol-af12ffcc2740)；[`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?, bool)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)；[`NationalSpire.PrivateMessagePrompts.Compose(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn?, string?, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?, bool)`](PrivateMessagePrompts.cs.md#symbol-e8c8e5f35407)；[`NationalSpire.PromptInsertions.Discussion(NationalSpire.AiWireProtocol, System.Collections.Generic.ISet<string>, System.Collections.Generic.List<NationalSpire.CommunityPost>, string, string)`](PromptInsertions.cs.md#symbol-d7ee7742c680)；[`NationalSpire.SpireArbitration.Compose(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn)`](SpireArbitration.cs.md#symbol-6116255f39e7)

**调用：** [`NationalSpire.PromptInsertions.Around(string, System.Collections.Generic.IEnumerable<NationalSpire.PromptInsertion>?, int, int)`](PromptInsertions.cs.md#symbol-3d0f6f332049)；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.PromptInsertions.Around(string, System.Collections.Generic.IEnumerable<NationalSpire.PromptInsertion>?, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PromptInsertions.Around(string, System.Collections.Generic.IEnumerable<NationalSpire.PromptInsertion>?, int, int)`；输入表达式：`Around(messages[0]["content"], active, 0, -1)`；返回值紧邻使用处：`AssignmentExpressionSyntax: messages[0]["content"] = Around(messages[0]["content"], active, 0, -1)`
- `NationalSpire.PromptInsertions.Around(string, System.Collections.Generic.IEnumerable<NationalSpire.PromptInsertion>?, int, int)`；输入表达式：`Around(messages[^1]["content"], active, -1, 3)`；返回值紧邻使用处：`AssignmentExpressionSyntax: messages[^1]["content"] = Around(messages[^1]["content"], active, -1, 3)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`(entries ?? []).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = (entries ?? []).ToArray()`

**赋值（含属性/字段和局部值）：**

- `messages[0]["content"]` = `Around(messages[0]["content"], active, 0, -1)`
- `messages[^1]["content"]` = `Around(messages[^1]["content"], active, -1, 3)`

<a id="symbol-d7ee7742c680"></a>

## `NationalSpire.PromptInsertions.Discussion(NationalSpire.AiWireProtocol, System.Collections.Generic.ISet<string>, System.Collections.Generic.List<NationalSpire.CommunityPost>, string, string) — internal static List<Dictionary<string, string>> Discussion(AiWireProtocol wire, ISet<string> requested, List<CommunityPost> posts, string system, string context)`

来源：源码第 68 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`](AiDiscussion.cs.md#symbol-63a666dde156)

**调用：** [`NationalSpire.AiWireProtocol.Encode(string)`](AiWireProtocol.cs.md#symbol-bcdcbacd353a)；[`NationalSpire.PromptInsertions.Apply(System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, System.Collections.Generic.IEnumerable<NationalSpire.PromptInsertion>?)`](PromptInsertions.cs.md#symbol-35674fc9b589)；[`NationalSpire.PromptInsertions.Around(string, System.Collections.Generic.IEnumerable<NationalSpire.PromptInsertion>?, int, int)`](PromptInsertions.cs.md#symbol-3d0f6f332049)；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.ICollection<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Collections.IEnumerable.OfType<TResult>()`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；`System.Text.Json.Nodes.JsonNode.AsArray()`；`System.Text.Json.Nodes.JsonNode.GetValue<T>()`；`System.Text.Json.Nodes.JsonNode.Parse(string, System.Text.Json.Nodes.JsonNodeOptions?, System.Text.Json.JsonDocumentOptions)`；`System.Text.Json.Nodes.JsonNode.ToJsonString(System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiWireProtocol.Encode(string)`；`NationalSpire.CommunityPost.Body`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.PromptInsertions`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityReply.Body`；`NationalSpire.CommunityReply.Id`；`NationalSpire.CommunityReply.PromptInsertions`；`NationalSpire.PortraitDesigns.Json`；`NationalSpire.PromptInsertions.Apply(System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, System.Collections.Generic.IEnumerable<NationalSpire.PromptInsertion>?)`；`NationalSpire.PromptInsertions.Around(string, System.Collections.Generic.IEnumerable<NationalSpire.PromptInsertion>?, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiWireProtocol.Encode(string)`；输入表达式：`wire.Encode(node.ToJsonString(PortraitDesigns.Json))`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["content"] = wire.Encode(node.ToJsonString(PortraitDesigns.Json))`
- `NationalSpire.PromptInsertions.Apply(System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, System.Collections.Generic.IEnumerable<NationalSpire.PromptInsertion>?)`；输入表达式：`Apply([new() { ["role"] = "system", ["content"] = system }, new() { ["role"] = "user", ["content"] = wire.Encode(node.ToJsonString(PortraitDesigns.Json)) }], unique)`；返回值紧邻使用处：`ReturnStatementSyntax: return Apply([new() { ["role"] = "system", ["content"] = system }, new() { ["role"] = "user", ["content"] = wire.Encode(node.ToJsonString(PortraitDesigns.Json)) }], unique);`
- `NationalSpire.PromptInsertions.Around(string, System.Collections.Generic.IEnumerable<NationalSpire.PromptInsertion>?, int, int)`；输入表达式：`Around(post.Body, post.PromptInsertions, 1, 2)`；返回值紧邻使用处：`AssignmentExpressionSyntax: target["Body"] = Around(post.Body, post.PromptInsertions, 1, 2)`
- `NationalSpire.PromptInsertions.Around(string, System.Collections.Generic.IEnumerable<NationalSpire.PromptInsertion>?, int, int)`；输入表达式：`Around(source.Body, source.PromptInsertions, 1, 2)`；返回值紧邻使用处：`AssignmentExpressionSyntax: reply["Body"] = Around(source.Body, source.PromptInsertions, 1, 2)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new() { ["role"] = "system", ["content"] = system }`；返回值紧邻使用处：`ExpressionElementSyntax: new() { ["role"] = "system", ["content"] = system }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new() { ["role"] = "user", ["content"] = wire.Encode(node.ToJsonString(PortraitDesigns.Json)) }`；返回值紧邻使用处：`ExpressionElementSyntax: new() { ["role"] = "user", ["content"] = wire.Encode(node.ToJsonString(PortraitDesigns.Json)) }`
- `System.Collections.Generic.ICollection<T>.Contains(T)`；输入表达式：`requested.Contains(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !requested.Contains(id)`
- `System.Collections.Generic.ICollection<T>.Contains(T)`；输入表达式：`requested.Contains(post.Id)`；返回值紧邻使用处：`IfStatementSyntax: if (requested.Contains(post.Id)) { target["Body"] = Around(post.Body, post.PromptInsertions, 1, 2); snapshots.Add(post.PromptInsertions); }`
- `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`snapshots.DistinctBy(s => JsonSerializer.Serialize(s))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: snapshots.DistinctBy(s => JsonSerializer.Serialize(s)).SelectMany`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`snapshots.DistinctBy(s => JsonSerializer.Serialize(s)).SelectMany(s => s)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = snapshots.DistinctBy(s => JsonSerializer.Serialize(s)).SelectMany(s => s)`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`post.Replies.Single(r => r.Id == id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = post.Replies.Single(r => r.Id == id)`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`posts.Single(p => p.Id == target["Id"]!.GetValue<string>())`；返回值紧邻使用处：`EqualsValueClauseSyntax: = posts.Single(p => p.Id == target["Id"]!.GetValue<string>())`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`snapshots.Add(post.PromptInsertions)`；返回值紧邻使用处：`ExpressionStatementSyntax: snapshots.Add(post.PromptInsertions);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`snapshots.Add(source.PromptInsertions)`；返回值紧邻使用处：`ExpressionStatementSyntax: snapshots.Add(source.PromptInsertions);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<List<PromptInsertion>>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<List<PromptInsertion>>()`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`node["targets"]!.AsArray().OfType<JsonObject>()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var target in node["targets"]!.AsArray().OfType<JsonObject>()) { var post = posts.Single(p => p.Id == target["Id"]!.GetValue<string>()); if (requested.Contains(post.Id)) { target["Body"] = Around(post.Body, post.PromptInsertions, 1, 2); snapshots.Add(post.PromptInsertions); } foreach (var reply in target["conversation"]!.AsArray().OfType<JsonObject>()) { string id = reply["Id"]!.GetValue<string>(); if (!requested.Contains(id)) continue; var source = post.Replies.Single(r => r.Id == id); reply["Body"] = Around(source.Body, source.PromptInsertions, 1, 2); snapshots.Add(source.PromptInsertions); } }`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`target["conversation"]!.AsArray().OfType<JsonObject>()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var reply in target["conversation"]!.AsArray().OfType<JsonObject>()) { string id = reply["Id"]!.GetValue<string>(); if (!requested.Contains(id)) continue; var source = post.Replies.Single(r => r.Id == id); reply["Body"] = Around(source.Body, source.PromptInsertions, 1, 2); snapshots.Add(source.PromptInsertions); }`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(s)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: s => JsonSerializer.Serialize(s)`
- `System.Text.Json.Nodes.JsonNode.AsArray()`；输入表达式：`node["targets"]!.AsArray()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: node["targets"]!.AsArray().OfType<JsonObject>`
- `System.Text.Json.Nodes.JsonNode.AsArray()`；输入表达式：`target["conversation"]!.AsArray()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: target["conversation"]!.AsArray().OfType<JsonObject>`
- `System.Text.Json.Nodes.JsonNode.GetValue<T>()`；输入表达式：`reply["Id"]!.GetValue<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = reply["Id"]!.GetValue<string>()`
- `System.Text.Json.Nodes.JsonNode.GetValue<T>()`；输入表达式：`target["Id"]!.GetValue<string>()`；返回值紧邻使用处：`BinaryExpressionSyntax: p.Id == target["Id"]!.GetValue<string>()`
- `System.Text.Json.Nodes.JsonNode.Parse(string, System.Text.Json.Nodes.JsonNodeOptions?, System.Text.Json.JsonDocumentOptions)`；输入表达式：`JsonNode.Parse(context)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: JsonNode.Parse(context)!`
- `System.Text.Json.Nodes.JsonNode.ToJsonString(System.Text.Json.JsonSerializerOptions?)`；输入表达式：`node.ToJsonString(PortraitDesigns.Json)`；返回值紧邻使用处：`ArgumentSyntax: node.ToJsonString(PortraitDesigns.Json)`

**赋值（含属性/字段和局部值）：**

- `["content"]` = `system`
- `["content"]` = `wire.Encode(node.ToJsonString(PortraitDesigns.Json))`
- `["role"]` = `"system"`
- `["role"]` = `"user"`
- `reply["Body"]` = `Around(source.Body, source.PromptInsertions, 1, 2)`
- `target["Body"]` = `Around(post.Body, post.PromptInsertions, 1, 2)`
