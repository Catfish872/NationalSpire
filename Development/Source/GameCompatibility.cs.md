# GameCompatibility.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`BBDB68173A44F05594B1B91678FC1280E38180575211F70F4E0595C3C34086B7`。来源：[源码](../../GameCompatibility.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.GameCompatibility`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly Lazy<SeedApi> Seeds = new(() => new(typeof(StringHelper), typeof(Rng)));
```

<a id="symbol-90b5831e6fff"></a>

## `NationalSpire.GameCompatibility.SingleplayerStart(System.Type) — public static MethodInfo SingleplayerStart(Type acts)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](GameBridge.cs.md#symbol-b93ed89d4fc6)

**调用：** [`NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`](RuntimeApi.cs.md#symbol-8426661c18c8)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Reflection.MethodBase.GetParameters()`；`System.Type.GetMethods()`

**字段、属性、事件及方法组引用：** `NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`；输入表达式：`RuntimeApi.Bind(typeof(NGame), "StartNewSingleplayerRun", false, typeof(CharacterModel), typeof(bool), acts,                  typeof(ModifierModel[]), typeof(string), typeof(GameMode), typeof(int))`；返回值紧邻使用处：`ConditionalExpressionSyntax: player              ? RuntimeApi.Bind(typeof(NGame), "StartNewSingleplayerRun", false, typeof(Player), typeof(bool), acts,                  typeof(ModifierModel[]), typeof(string), typeof(GameMode), typeof(bool), typeof(int))              : RuntimeApi.Bind(typeof(NGame), "StartNewSingleplayerRun", false, typeof(CharacterModel), typeof(bool), acts,                  typeof(ModifierModel[]), typeof(string), typeof(GameMode), typeof(int))`
- `NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`；输入表达式：`RuntimeApi.Bind(typeof(NGame), "StartNewSingleplayerRun", false, typeof(Player), typeof(bool), acts,                  typeof(ModifierModel[]), typeof(string), typeof(GameMode), typeof(bool), typeof(int))`；返回值紧邻使用处：`ConditionalExpressionSyntax: player              ? RuntimeApi.Bind(typeof(NGame), "StartNewSingleplayerRun", false, typeof(Player), typeof(bool), acts,                  typeof(ModifierModel[]), typeof(string), typeof(GameMode), typeof(bool), typeof(int))              : RuntimeApi.Bind(typeof(NGame), "StartNewSingleplayerRun", false, typeof(CharacterModel), typeof(bool), acts,                  typeof(ModifierModel[]), typeof(string), typeof(GameMode), typeof(int))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`typeof(NGame).GetMethods().Any(m => m.Name == "StartNewSingleplayerRun"              && m.GetParameters().FirstOrDefault()?.ParameterType == typeof(Player))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = typeof(NGame).GetMethods().Any(m => m.Name == "StartNewSingleplayerRun"              && m.GetParameters().FirstOrDefault()?.ParameterType == typeof(Player))`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`m.GetParameters().FirstOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: m.GetParameters().FirstOrDefault()?.ParameterType`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`m.GetParameters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: m.GetParameters().FirstOrDefault`
- `System.Type.GetMethods()`；输入表达式：`typeof(NGame).GetMethods()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: typeof(NGame).GetMethods().Any`

**赋值（含属性/字段和局部值）：**


<a id="symbol-48e9860a31ce"></a>

## `NationalSpire.GameCompatibility.StartSingleplayer(System.Reflection.MethodInfo, MegaCrit.Sts2.Core.Nodes.NGame, MegaCrit.Sts2.Core.Models.CharacterModel, System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel>, string, int, string) — public static Task StartSingleplayer(MethodInfo start, NGame game, CharacterModel character, List<ActModel> acts, string seed, int ascension, string mode = MatchModes.Standard)`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](GameBridge.cs.md#symbol-b93ed89d4fc6)

**调用：** [`NationalSpire.MatchModes.Native(string)`](MatchModes.cs.md#symbol-5c0b5a07fb3c)；[`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`](RuntimeApi.cs.md#symbol-65f56c93bd1a)；`MegaCrit.Sts2.Core.Entities.Players.Player.CreateForNewRun(MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Unlocks.UnlockState, ulong)`；`MegaCrit.Sts2.Core.Saves.SaveManager.GenerateUnlockStateFromProgress()`；`System.Array.Empty<T>()`；`System.Reflection.MethodBase.GetParameters()`

**字段、属性、事件及方法组引用：** `NationalSpire.MatchModes.Native(string)`；`NationalSpire.MatchModes.Standard`；`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Entities.Players.Player.CreateForNewRun(MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Unlocks.UnlockState, ulong)`；输入表达式：`Player.CreateForNewRun(character, SaveManager.Instance.GenerateUnlockStateFromProgress(), 1UL)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Player.CreateForNewRun(character, SaveManager.Instance.GenerateUnlockStateFromProgress(), 1UL)`
- `MegaCrit.Sts2.Core.Saves.SaveManager.GenerateUnlockStateFromProgress()`；输入表达式：`SaveManager.Instance.GenerateUnlockStateFromProgress()`；返回值紧邻使用处：`ArgumentSyntax: SaveManager.Instance.GenerateUnlockStateFromProgress()`
- `NationalSpire.MatchModes.Native(string)`；输入表达式：`MatchModes.Native(mode)`；返回值紧邻使用处：`ArgumentSyntax: MatchModes.Native(mode)`
- `NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`；输入表达式：`RuntimeApi.Invoke(start, game, character, true, acts, Array.Empty<ModifierModel>(), seed, MatchModes.Native(mode), ascension)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: RuntimeApi.Invoke(start, game, character, true, acts, Array.Empty<ModifierModel>(), seed, MatchModes.Native(mode), ascension)!`
- `NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`；输入表达式：`RuntimeApi.Invoke(start, game, player, true, acts, Array.Empty<ModifierModel>(), seed, MatchModes.Native(mode), false, ascension)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: RuntimeApi.Invoke(start, game, player, true, acts, Array.Empty<ModifierModel>(), seed, MatchModes.Native(mode), false, ascension)!`
- `System.Array.Empty<T>()`；输入表达式：`Array.Empty<ModifierModel>()`；返回值紧邻使用处：`ArgumentSyntax: Array.Empty<ModifierModel>()`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`start.GetParameters()`；返回值紧邻使用处：`ElementAccessExpressionSyntax: start.GetParameters()[0]`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a00822d68705"></a>

## `NationalSpire.GameCompatibility.AssetLoadingStatus() — public static object AssetLoadingStatus()`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchStartWatch.ShowNotice()`](MatchStartWatch.cs.md#symbol-c904f0fb2bfd)

**调用：** [`Queue(string)`](GameCompatibility.cs.md#symbol-f92c1da69597)；[`Read(string)`](GameCompatibility.cs.md#symbol-1d28e0d0dc9a)；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Node.CanProcess()`；`Godot.Node.IsInsideTree()`；`Godot.Node.IsProcessing()`；`System.Enum.ToString()`；`System.Exception.GetBaseException()`；`System.Reflection.FieldInfo.GetValue(object?)`；`System.Type.GetField(string, System.Reflection.BindingFlags)`

**字段、属性、事件及方法组引用：** `<anonymous type: bool available, bool insideTree, bool processing, bool canProcess, string processMode, object name, object toLoad, object loading, object finalizing, object vfx, object currentVfx, object vfxLoading>.available`；`<anonymous type: bool available, bool insideTree, bool processing, bool canProcess, string processMode, object name, object toLoad, object loading, object finalizing, object vfx, object currentVfx, object vfxLoading>.canProcess`；`<anonymous type: bool available, bool insideTree, bool processing, bool canProcess, string processMode, object name, object toLoad, object loading, object finalizing, object vfx, object currentVfx, object vfxLoading>.currentVfx`；`<anonymous type: bool available, bool insideTree, bool processing, bool canProcess, string processMode, object name, object toLoad, object loading, object finalizing, object vfx, object currentVfx, object vfxLoading>.finalizing`；`<anonymous type: bool available, bool insideTree, bool processing, bool canProcess, string processMode, object name, object toLoad, object loading, object finalizing, object vfx, object currentVfx, object vfxLoading>.insideTree`；`<anonymous type: bool available, bool insideTree, bool processing, bool canProcess, string processMode, object name, object toLoad, object loading, object finalizing, object vfx, object currentVfx, object vfxLoading>.loading`；`<anonymous type: bool available, bool insideTree, bool processing, bool canProcess, string processMode, object name, object toLoad, object loading, object finalizing, object vfx, object currentVfx, object vfxLoading>.name`；`<anonymous type: bool available, bool insideTree, bool processing, bool canProcess, string processMode, object name, object toLoad, object loading, object finalizing, object vfx, object currentVfx, object vfxLoading>.processing`；`<anonymous type: bool available, bool insideTree, bool processing, bool canProcess, string processMode, object name, object toLoad, object loading, object finalizing, object vfx, object currentVfx, object vfxLoading>.processMode`；`<anonymous type: bool available, bool insideTree, bool processing, bool canProcess, string processMode, object name, object toLoad, object loading, object finalizing, object vfx, object currentVfx, object vfxLoading>.toLoad`；`<anonymous type: bool available, bool insideTree, bool processing, bool canProcess, string processMode, object name, object toLoad, object loading, object finalizing, object vfx, object currentVfx, object vfxLoading>.vfx`；`<anonymous type: bool available, bool insideTree, bool processing, bool canProcess, string processMode, object name, object toLoad, object loading, object finalizing, object vfx, object currentVfx, object vfxLoading>.vfxLoading`；`<anonymous type: bool available, string error>.available`；`<anonymous type: bool available, string error>.error`；`<anonymous type: bool available>.available`；`Queue(string)`；`Read(string)`

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


<a id="symbol-1d28e0d0dc9a"></a>

## `Read(string) — object? Read(string name)`

来源：源码第 45 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameCompatibility.AssetLoadingStatus()`](GameCompatibility.cs.md#symbol-a00822d68705)；[`Queue(string)`](GameCompatibility.cs.md#symbol-f92c1da69597)

**调用：** `object.GetType()`；`System.Reflection.FieldInfo.GetValue(object?)`；`System.Type.GetField(string, System.Reflection.BindingFlags)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `object.GetType()`；输入表达式：`.GetType()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: .GetType().GetField`
- `System.Reflection.FieldInfo.GetValue(object?)`；输入表达式：`.GetValue(session)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .GetType().GetField(name, flags)?.GetValue(session)`
- `System.Type.GetField(string, System.Reflection.BindingFlags)`；输入表达式：`.GetType().GetField(name, flags)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .GetType().GetField(name, flags)?.GetValue(session)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f92c1da69597"></a>

## `Queue(string) — object Queue(string field)`

来源：源码第 46 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameCompatibility.AssetLoadingStatus()`](GameCompatibility.cs.md#symbol-a00822d68705)

**调用：** [`Read(string)`](GameCompatibility.cs.md#symbol-1d28e0d0dc9a)；`Godot.ResourceLoader.LoadThreadedGetStatus(string, Godot.Collections.Array)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Enum.ToString()`

**字段、属性、事件及方法组引用：** `<anonymous type: bool available>.available`；`<anonymous type: int? count, <anonymous type: string path, string status>[] paths>.count`；`<anonymous type: int? count, <anonymous type: string path, string status>[] paths>.paths`；`<anonymous type: string path, string status>.path`；`<anonymous type: string path, string status>.status`；`Read(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ResourceLoader.LoadThreadedGetStatus(string, Godot.Collections.Array)`；输入表达式：`Godot.ResourceLoader.LoadThreadedGetStatus(p)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Godot.ResourceLoader.LoadThreadedGetStatus(p).ToString`
- `Read(string)`；输入表达式：`Read(field)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Read(field) is not IEnumerable<string> paths`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`paths.Take(32).Select(p => new { path = p, status = field is "_loading" or "_finalizing"                          ? Godot.ResourceLoader.LoadThreadedGetStatus(p).ToString() : "queued" })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: paths.Take(32).Select(p => new { path = p, status = field is "_loading" or "_finalizing"                          ? Godot.ResourceLoader.LoadThreadedGetStatus(p).ToString() : "queued" }).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`paths.Take(32)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: paths.Take(32).Select`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`paths.Take(32).Select(p => new { path = p, status = field is "_loading" or "_finalizing"                          ? Godot.ResourceLoader.LoadThreadedGetStatus(p).ToString() : "queued" }).ToArray()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: paths = paths.Take(32).Select(p => new { path = p, status = field is "_loading" or "_finalizing"                          ? Godot.ResourceLoader.LoadThreadedGetStatus(p).ToString() : "queued" }).ToArray()`
- `System.Enum.ToString()`；输入表达式：`Godot.ResourceLoader.LoadThreadedGetStatus(p).ToString()`；返回值紧邻使用处：`ConditionalExpressionSyntax: field is "_loading" or "_finalizing"                          ? Godot.ResourceLoader.LoadThreadedGetStatus(p).ToString() : "queued"`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9bd705ffd995"></a>

## `NationalSpire.GameCompatibility.SeedMode — public static string SeedMode`

来源：源码第 61 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.GameCompatibility.Seeds`；`NationalSpire.SeedApi.Description`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-68363869a9cf"></a>

## `NationalSpire.GameCompatibility.ActRng(string) — public static Rng ActRng(string seed)`

来源：源码第 62 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCompatibility.Check(bool)`](Coop/CoopCompatibility.cs.md#symbol-c71e5d5de570)；[`NationalSpire.GameBridge.CreateActSelectionRng(string)`](GameBridge.cs.md#symbol-e22050f58fa0)

**调用：** [`NationalSpire.SeedApi.FromText(string, string)`](RuntimeApi.cs.md#symbol-84805f281f9e)

**字段、属性、事件及方法组引用：** `NationalSpire.GameCompatibility.Seeds`；`NationalSpire.SeedApi.FromText(string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.SeedApi.FromText(string, string)`；输入表达式：`Seeds.Value.FromText(seed, "act_selection")`；返回值紧邻使用处：`CastExpressionSyntax: (Rng)Seeds.Value.FromText(seed, "act_selection")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a2187753991c"></a>

## `NationalSpire.GameCompatibility.MapRng(object, int) — public static Rng MapRng(object runRng, int act)`

来源：源码第 63 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveMaps.Read(MegaCrit.Sts2.Core.Runs.IRunState, NationalSpire.CareerMatch, bool)`](LiveMaps.cs.md#symbol-c878186b1e5a)

**调用：** [`NationalSpire.SeedApi.FromRun(object, string)`](RuntimeApi.cs.md#symbol-e32ac6048df2)

**字段、属性、事件及方法组引用：** `NationalSpire.GameCompatibility.Seeds`；`NationalSpire.SeedApi.FromRun(object, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.SeedApi.FromRun(object, string)`；输入表达式：`Seeds.Value.FromRun(runRng, $"act_{act}_map")`；返回值紧邻使用处：`CastExpressionSyntax: (Rng)Seeds.Value.FromRun(runRng, $"act_{act}_map")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f20a223e98d6"></a>

## `NationalSpire.GameCompatibility.Version() — public static string Version()`

来源：源码第 64 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Entry.Init()`](Entry.cs.md#symbol-f4f7468c39e8)；[`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](GameBridge.cs.md#symbol-b93ed89d4fc6)

**调用：** [`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；`System.IO.File.Exists(string?)`；`System.IO.File.ReadAllText(string)`；`System.IO.Path.Combine(string, string, string)`；`System.IO.Path.Combine(string, string)`；`System.IO.Path.GetDirectoryName(string?)`；`System.Reflection.Assembly.GetName()`；`System.Reflection.MethodBase.Invoke(object?, object?[]?)`；`System.Text.Json.JsonDocument.Parse(string, System.Text.Json.JsonDocumentOptions)`；`System.Text.Json.JsonElement.GetProperty(string)`；`System.Text.Json.JsonElement.GetString()`；`System.Type.GetMethod(string, System.Reflection.BindingFlags, System.Type[])`；`System.Version.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.Error(string, System.Exception)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("compat.version", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("compat.version", e);`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(file)`；返回值紧邻使用处：`IfStatementSyntax: if (File.Exists(file))                  { using var json = JsonDocument.Parse(File.ReadAllText(file)); return json.RootElement.GetProperty("version").GetString() ?? "未知版本"; }`
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
