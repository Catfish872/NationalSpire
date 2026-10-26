# GameCompatibility.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`5F179718B14502D05D547F9136B35C4C51412356BEC7BD23A7D5D18292109BC2`。来源：[源码](../../GameCompatibility.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.GameCompatibility`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly Lazy<SeedApi> Seeds = new(() => new(typeof(StringHelper), typeof(Rng)));
```

<a id="symbol-a00822d68705"></a>

## `NationalSpire.GameCompatibility.AssetLoadingStatus() — public static object AssetLoadingStatus()`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchStartWatch.ShowNotice()`](MatchStartWatch.cs.md#symbol-c904f0fb2bfd)

**调用：** `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Node.CanProcess()`；`Godot.Node.IsInsideTree()`；`Godot.Node.IsProcessing()`；[`Queue(string)`](GameCompatibility.cs.md#symbol-b5d06d6f7a1a)；[`Read(string)`](GameCompatibility.cs.md#symbol-b13ad29a9e25)；`System.Enum.ToString()`；`System.Exception.GetBaseException()`；`System.Reflection.FieldInfo.GetValue(object?)`；`System.Type.GetField(string, System.Reflection.BindingFlags)`

**字段、属性、事件及方法组引用：** `Queue(string)`；`Read(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`Godot.GodotObject.IsInstanceValid(loader)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Godot.GodotObject.IsInstanceValid(loader)`
- `Godot.Node.CanProcess()`；输入表达式：`loader.CanProcess()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: canProcess = loader.CanProcess()`
- `Godot.Node.IsInsideTree()`；输入表达式：`loader.IsInsideTree()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: insideTree = loader.IsInsideTree()`
- `Godot.Node.IsProcessing()`；输入表达式：`loader.IsProcessing()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: processing = loader.IsProcessing()`
- `Queue(string)`；输入表达式：`Queue("_finalizing")`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: finalizing = Queue("_finalizing")`
- `Queue(string)`；输入表达式：`Queue("_loading")`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: loading = Queue("_loading")`
- `Queue(string)`；输入表达式：`Queue("_toLoad")`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: toLoad = Queue("_toLoad")`
- `Queue(string)`；输入表达式：`Queue("_vfxScenes")`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: vfx = Queue("_vfxScenes")`
- `Read(string)`；输入表达式：`Read("_currentVfxPath")`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: currentVfx = Read("_currentVfxPath")`
- `Read(string)`；输入表达式：`Read("_name")`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: name = Read("_name")`
- `Read(string)`；输入表达式：`Read("_vfxLoading")`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: vfxLoading = Read("_vfxLoading")`
- `System.Enum.ToString()`；输入表达式：`loader.ProcessMode.ToString()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: processMode = loader.ProcessMode.ToString()`
- `System.Exception.GetBaseException()`；输入表达式：`error.GetBaseException()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: error.GetBaseException().Message`
- `System.Reflection.FieldInfo.GetValue(object?)`；输入表达式：`.GetValue(loader)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: typeof(NAssetLoader).GetField("_currentSession", flags)?.GetValue(loader)`
- `System.Reflection.FieldInfo.GetValue(object?)`；输入表达式：`.GetValue(null)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: typeof(NAssetLoader).GetField("_instance", flags)?.GetValue(null)`
- `System.Type.GetField(string, System.Reflection.BindingFlags)`；输入表达式：`typeof(NAssetLoader).GetField("_currentSession", flags)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: typeof(NAssetLoader).GetField("_currentSession", flags)?.GetValue(loader)`
- `System.Type.GetField(string, System.Reflection.BindingFlags)`；输入表达式：`typeof(NAssetLoader).GetField("_instance", flags)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: typeof(NAssetLoader).GetField("_instance", flags)?.GetValue(null)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b13ad29a9e25"></a>

## `Read(string) — object? Read(string name)`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameCompatibility.AssetLoadingStatus()`](GameCompatibility.cs.md#symbol-a00822d68705)；[`Queue(string)`](GameCompatibility.cs.md#symbol-b5d06d6f7a1a)

**调用：** `System.Reflection.FieldInfo.GetValue(object?)`；`System.Type.GetField(string, System.Reflection.BindingFlags)`；`object.GetType()`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Reflection.FieldInfo.GetValue(object?)`；输入表达式：`.GetValue(session)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .GetType().GetField(name, flags)?.GetValue(session)`
- `System.Type.GetField(string, System.Reflection.BindingFlags)`；输入表达式：`.GetType().GetField(name, flags)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .GetType().GetField(name, flags)?.GetValue(session)`
- `object.GetType()`；输入表达式：`.GetType()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: .GetType().GetField`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b5d06d6f7a1a"></a>

## `Queue(string) — object Queue(string field)`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameCompatibility.AssetLoadingStatus()`](GameCompatibility.cs.md#symbol-a00822d68705)

**调用：** `Godot.ResourceLoader.LoadThreadedGetStatus(string, Godot.Collections.Array)`；[`Read(string)`](GameCompatibility.cs.md#symbol-b13ad29a9e25)；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Enum.ToString()`

**字段、属性、事件及方法组引用：** `Read(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ResourceLoader.LoadThreadedGetStatus(string, Godot.Collections.Array)`；输入表达式：`Godot.ResourceLoader.LoadThreadedGetStatus(p)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Godot.ResourceLoader.LoadThreadedGetStatus(p).ToString`
- `Read(string)`；输入表达式：`Read(field)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Read(field) is not IEnumerable<string> paths`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`paths.Take(32).Select(p => new { path = p, status = field is "_loading" or "_finalizing" ? Godot.ResourceLoader.LoadThreadedGetStatus(p).ToString() : "queued" })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: paths.Take(32).Select(p => new { path = p, status = field is "_loading" or "_finalizing" ? Godot.ResourceLoader.LoadThreadedGetStatus(p).ToString() : "queued" }).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`paths.Take(32)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: paths.Take(32).Select`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`paths.Take(32).Select(p => new { path = p, status = field is "_loading" or "_finalizing" ? Godot.ResourceLoader.LoadThreadedGetStatus(p).ToString() : "queued" }).ToArray()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: paths = paths.Take(32).Select(p => new { path = p, status = field is "_loading" or "_finalizing" ? Godot.ResourceLoader.LoadThreadedGetStatus(p).ToString() : "queued" }).ToArray()`
- `System.Enum.ToString()`；输入表达式：`Godot.ResourceLoader.LoadThreadedGetStatus(p).ToString()`；返回值紧邻使用处：`ConditionalExpressionSyntax: field is "_loading" or "_finalizing" ? Godot.ResourceLoader.LoadThreadedGetStatus(p).ToString() : "queued"`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9bd705ffd995"></a>

## `NationalSpire.GameCompatibility.SeedMode — public static string SeedMode`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.GameCompatibility.Seeds`；`NationalSpire.SeedApi.Description`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-68363869a9cf"></a>

## `NationalSpire.GameCompatibility.ActRng(string) — public static Rng ActRng(string seed)`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCompatibility.Check(bool)`](Coop/CoopCompatibility.cs.md#symbol-c71e5d5de570)；[`NationalSpire.GameBridge.CreateActSelectionRng(string)`](GameBridge.cs.md#symbol-e22050f58fa0)

**调用：** [`NationalSpire.SeedApi.FromText(string, string)`](RuntimeApi.cs.md#symbol-84805f281f9e)

**字段、属性、事件及方法组引用：** `NationalSpire.GameCompatibility.Seeds`；`NationalSpire.SeedApi.FromText(string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.SeedApi.FromText(string, string)`；输入表达式：`Seeds.Value.FromText(seed, "act_selection")`；返回值紧邻使用处：`CastExpressionSyntax: (Rng)Seeds.Value.FromText(seed, "act_selection")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a2187753991c"></a>

## `NationalSpire.GameCompatibility.MapRng(object, int) — public static Rng MapRng(object runRng, int act)`

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveMaps.Read(MegaCrit.Sts2.Core.Runs.IRunState, NationalSpire.CareerMatch, bool)`](LiveMaps.cs.md#symbol-c878186b1e5a)

**调用：** [`NationalSpire.SeedApi.FromRun(object, string)`](RuntimeApi.cs.md#symbol-e32ac6048df2)

**字段、属性、事件及方法组引用：** `NationalSpire.GameCompatibility.Seeds`；`NationalSpire.SeedApi.FromRun(object, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.SeedApi.FromRun(object, string)`；输入表达式：`Seeds.Value.FromRun(runRng, $"act_{act}_map")`；返回值紧邻使用处：`CastExpressionSyntax: (Rng)Seeds.Value.FromRun(runRng, $"act_{act}_map")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f20a223e98d6"></a>

## `NationalSpire.GameCompatibility.Version() — public static string Version()`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Entry.Init()`](Entry.cs.md#symbol-f4f7468c39e8)；[`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](GameBridge.cs.md#symbol-b93ed89d4fc6)

**调用：** [`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；`System.IO.File.Exists(string?)`；`System.IO.File.ReadAllText(string)`；`System.IO.Path.Combine(string, string, string)`；`System.IO.Path.Combine(string, string)`；`System.IO.Path.GetDirectoryName(string?)`；`System.Reflection.Assembly.GetName()`；`System.Reflection.MethodBase.Invoke(object?, object?[]?)`；`System.Text.Json.JsonDocument.Parse(string, System.Text.Json.JsonDocumentOptions)`；`System.Text.Json.JsonElement.GetProperty(string)`；`System.Text.Json.JsonElement.GetString()`；`System.Type.GetMethod(string, System.Reflection.BindingFlags, System.Type[])`；`System.Version.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.Error(string, System.Exception)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("compat.version", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("compat.version", e);`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(file)`；返回值紧邻使用处：`IfStatementSyntax: if (File.Exists(file))                 { using var json = JsonDocument.Parse(File.ReadAllText(file)); return json.RootElement.GetProperty("version").GetString() ?? "未知版本"; }`
- `System.IO.File.ReadAllText(string)`；输入表达式：`File.ReadAllText(file)`；返回值紧邻使用处：`ArgumentSyntax: File.ReadAllText(file)`
- `System.IO.Path.Combine(string, string, string)`；输入表达式：`Path.Combine(directory, "..", "release_info.json")`；返回值紧邻使用处：`InitializerExpressionSyntax: { Path.Combine(directory, "release_info.json"), Path.Combine(directory, "..", "release_info.json") }`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(directory, "release_info.json")`；返回值紧邻使用处：`InitializerExpressionSyntax: { Path.Combine(directory, "release_info.json"), Path.Combine(directory, "..", "release_info.json") }`
- `System.IO.Path.GetDirectoryName(string?)`；输入表达式：`Path.GetDirectoryName(typeof(NGame).Assembly.Location)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: Path.GetDirectoryName(typeof(NGame).Assembly.Location)!`
- `System.Reflection.Assembly.GetName()`；输入表达式：`typeof(NGame).Assembly.GetName()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: typeof(NGame).Assembly.GetName().Version`
- `System.Reflection.MethodBase.Invoke(object?, object?[]?)`；输入表达式：`.Invoke(null, null)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: reader?.Invoke(null, null)`
- `System.Text.Json.JsonDocument.Parse(string, System.Text.Json.JsonDocumentOptions)`；输入表达式：`JsonDocument.Parse(File.ReadAllText(file))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = JsonDocument.Parse(File.ReadAllText(file))`
- `System.Text.Json.JsonElement.GetProperty(string)`；输入表达式：`json.RootElement.GetProperty("version")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: json.RootElement.GetProperty("version").GetString`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`json.RootElement.GetProperty("version").GetString()`；返回值紧邻使用处：`BinaryExpressionSyntax: json.RootElement.GetProperty("version").GetString() ?? "未知版本"`
- `System.Type.GetMethod(string, System.Reflection.BindingFlags, System.Type[])`；输入表达式：`typeof(NGame).GetMethod("GetGameVersion", BindingFlags.Public | BindingFlags.Static, Type.EmptyTypes)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = typeof(NGame).GetMethod("GetGameVersion", BindingFlags.Public | BindingFlags.Static, Type.EmptyTypes)`
- `System.Version.ToString()`；输入表达式：`.ToString()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: typeof(NGame).Assembly.GetName().Version?.ToString()`

**赋值（含属性/字段和局部值）：**
