# RandomEventArt.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`C6AE2038F09CA9F186E22E4C6DE8476AC5F3A4D48892DCFDC387C0876DD5FC3C`。来源：[源码](../../RandomEventArt.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.RandomEventArt`、`NationalSpire.EventArtPicture`、`NationalSpire.EventEmblem`。

字段、事件及初始值（源码原样）：

```csharp
public const string UnknownIcon = "res://images/atlases/ui_atlas.sprites/map/icons/map_unknown.tres";
private static readonly Dictionary<string, string[]> Pools = new()
    {
        ["日常"] = ["living_room", "park", "bg_cityRiver_day", "game:wood_carvings"],
        ["饮食"] = ["gourmet_street", "restaurant", "kitchen", "game:tea_master"],
        ["阅读"] = ["art_museum", "living_room", "game:self_help_book", "game:waterlogged_scriptorium"],
        ["户外"] = ["park", "bg_cityRiver_day", "manor_exterior", "game:dense_vegetation"],
        ["夜色"] = ["bg_cityRiver_night", "aurora_street", "bg_cityRiver_evening"],
        ["训练"] = ["training_room", "championship_contest_venue", "game:battleworn_dummy"],
        ["手作"] = ["training_room", "art_museum", "game:wood_carvings", "game:tinker_time"],
        ["交易"] = ["auction", "gourmet_street", "game:relic_trader"],
        ["相聚"] = ["living_room", "restaurant", "park", "game:round_tea_party"],
        ["音乐"] = ["concert_hall", "livehouse", "ktv"],
    };
private static readonly SemaphoreSlim DecodeSlot = new(1);
private CancellationTokenSource? _pending;
private Texture2D? _owned;
private Texture2D? _icon;
```

<a id="symbol-1d9dc9e2c817"></a>

## `NationalSpire.RandomEventArt.Category(string) — public static string Category(string seed)`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.RandomEventArt.Category(NationalSpire.RandomEventRecord)`](RandomEventArt.cs.md#symbol-4d27d6b0c40b)；[`NationalSpire.RandomEventArt.Select(NationalSpire.RandomEventRecord)`](RandomEventArt.cs.md#symbol-e34111fd0431)

**调用：** [`NationalSpire.RandomEventSeeds.Category(string)`](RandomEventSeeds.cs.md#symbol-be664de1cd8d)

**字段、属性、事件及方法组引用：** `NationalSpire.RandomEventSeeds.Category(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RandomEventSeeds.Category(string)`；输入表达式：`RandomEventSeeds.Category(seed)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => RandomEventSeeds.Category(seed)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4d27d6b0c40b"></a>

## `NationalSpire.RandomEventArt.Category(NationalSpire.RandomEventRecord) — public static string Category(RandomEventRecord e)`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EventStoryView.Display(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.EventLive?, bool)`](RandomEventScreen.cs.md#symbol-f847e9f29b0e)；[`NationalSpire.RandomEventArt.Select(NationalSpire.RandomEventRecord)`](RandomEventArt.cs.md#symbol-e34111fd0431)

**调用：** [`NationalSpire.RandomEventArt.Category(string)`](RandomEventArt.cs.md#symbol-1d9dc9e2c817)

**字段、属性、事件及方法组引用：** `NationalSpire.RandomEventArt.Category(string)`；`NationalSpire.RandomEventRecord.Category`；`NationalSpire.RandomEventRecord.Seed`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RandomEventArt.Category(string)`；输入表达式：`Category(e.Seed ?? "")`；返回值紧邻使用处：`ConditionalExpressionSyntax: e.Category is { Length: > 0 } category ? category : Category(e.Seed ?? "")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e34111fd0431"></a>

## `NationalSpire.RandomEventArt.Select(NationalSpire.RandomEventRecord) — public static string Select(RandomEventRecord e)`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EventStoryView.Display(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.EventLive?, bool)`](RandomEventScreen.cs.md#symbol-f847e9f29b0e)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.RandomEventArt.Category(NationalSpire.RandomEventRecord)`](RandomEventArt.cs.md#symbol-4d27d6b0c40b)；[`NationalSpire.RandomEventArt.Category(string)`](RandomEventArt.cs.md#symbol-1d9dc9e2c817)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`string.IsNullOrEmpty(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.RandomEventArt.Category(NationalSpire.RandomEventRecord)`；`NationalSpire.RandomEventArt.Category(string)`；`NationalSpire.RandomEventArt.Pools`；`NationalSpire.RandomEventRecord.Id`；`NationalSpire.RandomEventRecord.Seed`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(e.Id + ":art:" + e.Seed)`；返回值紧邻使用处：`CastExpressionSyntax: (uint)CareerEngine.StableHash(e.Id + ":art:" + e.Seed)`
- `NationalSpire.RandomEventArt.Category(NationalSpire.RandomEventRecord)`；输入表达式：`Category(e)`；返回值紧邻使用处：`ArgumentSyntax: Category(e)`
- `NationalSpire.RandomEventArt.Category(string)`；输入表达式：`Category(e.Seed)`；返回值紧邻使用处：`ArgumentSyntax: Category(e.Seed)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Pools.TryGetValue(Category(e), out var pool)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Pools.TryGetValue(Category(e), out var pool)`
- `string.IsNullOrEmpty(string?)`；输入表达式：`string.IsNullOrEmpty(e.Seed)`；返回值紧邻使用处：`IfStatementSyntax: if (string.IsNullOrEmpty(e.Seed)) return "";`

**赋值（含属性/字段和局部值）：**

- `pool` = `Pools[Category(e.Seed)]`

<a id="symbol-ae11038396a9"></a>

## `NationalSpire.RandomEventArt.IsGameArt(string) — internal static bool IsGameArt(string id)`

来源：源码第 31 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EventArtPicture.ShowArt(string)`](RandomEventArt.cs.md#symbol-b98bbf61f246)；[`NationalSpire.RandomEventArt.Load(string)`](RandomEventArt.cs.md#symbol-5147b98e47ca)；[`NationalSpire.RandomEventArt.LoadAsync(string, Godot.SceneTree, System.Threading.CancellationToken)`](RandomEventArt.cs.md#symbol-8d4310f4546c)

**调用：** `string.StartsWith(string, System.StringComparison)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.StartsWith(string, System.StringComparison)`；输入表达式：`id.StartsWith("game:", StringComparison.Ordinal)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => id.StartsWith("game:", StringComparison.Ordinal)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9618c3e7ad21"></a>

## `NationalSpire.RandomEventArt.GamePath(string) — private static string GamePath(string id)`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.RandomEventArt.Load(string)`](RandomEventArt.cs.md#symbol-5147b98e47ca)；[`NationalSpire.RandomEventArt.LoadAsync(string, Godot.SceneTree, System.Threading.CancellationToken)`](RandomEventArt.cs.md#symbol-8d4310f4546c)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2cb75271e6ef"></a>

## `NationalSpire.RandomEventArt.ReadPixels(string, System.Threading.CancellationToken) — private static Image? ReadPixels(string id, CancellationToken token)`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.RandomEventArt.Load(string)`](RandomEventArt.cs.md#symbol-5147b98e47ca)；[`NationalSpire.RandomEventArt.LoadAsync(string, Godot.SceneTree, System.Threading.CancellationToken)`](RandomEventArt.cs.md#symbol-8d4310f4546c)

**调用：** `Godot.Image.GenerateMipmaps(bool)`；[`NationalSpire.DateSceneBackground.ReadPixels()`](DateSceneBackgrounds.cs.md#symbol-53d208267ec2)；[`NationalSpire.DateSceneBackgrounds.Read(out string, string?)`](DateSceneBackgrounds.cs.md#symbol-b6c3bc7d87d9)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Threading.CancellationToken.ThrowIfCancellationRequested()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneBackground.Id`；`NationalSpire.DateSceneBackground.ReadPixels()`；`NationalSpire.DateSceneBackgrounds.Read(out string, string?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Image.GenerateMipmaps(bool)`；输入表达式：`.GenerateMipmaps()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: pixels?.GenerateMipmaps()`
- `NationalSpire.DateSceneBackground.ReadPixels()`；输入表达式：`.ReadPixels()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: entry?.ReadPixels()`
- `NationalSpire.DateSceneBackgrounds.Read(out string, string?)`；输入表达式：`DateSceneBackgrounds.Read(out _)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateSceneBackgrounds.Read(out _).FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`DateSceneBackgrounds.Read(out _).FirstOrDefault(b => b.Id == id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateSceneBackgrounds.Read(out _).FirstOrDefault(b => b.Id == id)`
- `System.Threading.CancellationToken.ThrowIfCancellationRequested()`；输入表达式：`token.ThrowIfCancellationRequested()`；返回值紧邻使用处：`ExpressionStatementSyntax: token.ThrowIfCancellationRequested();`

**赋值（含属性/字段和局部值）：**

- `id` = `"bg_cityRiver_evening"`

<a id="symbol-5147b98e47ca"></a>

## `NationalSpire.RandomEventArt.Load(string) — public static Texture2D? Load(string id)`

来源：源码第 45 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.GD.Load<T>(string)`；`Godot.ImageTexture.CreateFromImage(Godot.Image)`；`Godot.ResourceLoader.Exists(string, string)`；[`NationalSpire.RandomEventArt.GamePath(string)`](RandomEventArt.cs.md#symbol-9618c3e7ad21)；[`NationalSpire.RandomEventArt.IsGameArt(string)`](RandomEventArt.cs.md#symbol-ae11038396a9)；[`NationalSpire.RandomEventArt.ReadPixels(string, System.Threading.CancellationToken)`](RandomEventArt.cs.md#symbol-2cb75271e6ef)

**字段、属性、事件及方法组引用：** `NationalSpire.RandomEventArt.GamePath(string)`；`NationalSpire.RandomEventArt.IsGameArt(string)`；`NationalSpire.RandomEventArt.ReadPixels(string, System.Threading.CancellationToken)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GD.Load<T>(string)`；输入表达式：`GD.Load<Texture2D>(path)`；返回值紧邻使用处：`ConditionalExpressionSyntax: ResourceLoader.Exists(path) ? GD.Load<Texture2D>(path) : null`
- `Godot.ImageTexture.CreateFromImage(Godot.Image)`；输入表达式：`ImageTexture.CreateFromImage(pixels)`；返回值紧邻使用处：`ConditionalExpressionSyntax: pixels == null ? null : ImageTexture.CreateFromImage(pixels)`
- `Godot.ResourceLoader.Exists(string, string)`；输入表达式：`ResourceLoader.Exists(path)`；返回值紧邻使用处：`ConditionalExpressionSyntax: ResourceLoader.Exists(path) ? GD.Load<Texture2D>(path) : null`
- `NationalSpire.RandomEventArt.GamePath(string)`；输入表达式：`GamePath(id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GamePath(id)`
- `NationalSpire.RandomEventArt.IsGameArt(string)`；输入表达式：`IsGameArt(id)`；返回值紧邻使用处：`IfStatementSyntax: if (IsGameArt(id)) { string path = GamePath(id); return ResourceLoader.Exists(path) ? GD.Load<Texture2D>(path) : null; }`
- `NationalSpire.RandomEventArt.ReadPixels(string, System.Threading.CancellationToken)`；输入表达式：`ReadPixels(id, CancellationToken.None)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ReadPixels(id, CancellationToken.None)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8d4310f4546c"></a>

## `NationalSpire.RandomEventArt.LoadAsync(string, Godot.SceneTree, System.Threading.CancellationToken) — internal static async Task<Texture2D?> LoadAsync(string id, SceneTree tree, CancellationToken token)`

来源：源码第 56 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EventArtPicture.ShowArt(string)`](RandomEventArt.cs.md#symbol-b98bbf61f246)

**调用：** `Godot.GodotObject.ToSignal(Godot.GodotObject, Godot.StringName)`；`Godot.ImageTexture.CreateFromImage(Godot.Image)`；`Godot.ResourceLoader.Exists(string, string)`；`Godot.ResourceLoader.LoadThreadedGet(string)`；`Godot.ResourceLoader.LoadThreadedGetStatus(string, Godot.Collections.Array)`；`Godot.ResourceLoader.LoadThreadedRequest(string, string, bool, Godot.ResourceLoader.CacheMode)`；[`NationalSpire.RandomEventArt.GamePath(string)`](RandomEventArt.cs.md#symbol-9618c3e7ad21)；[`NationalSpire.RandomEventArt.IsGameArt(string)`](RandomEventArt.cs.md#symbol-ae11038396a9)；[`NationalSpire.RandomEventArt.ReadPixels(string, System.Threading.CancellationToken)`](RandomEventArt.cs.md#symbol-2cb75271e6ef)；`System.Threading.CancellationToken.ThrowIfCancellationRequested()`；`System.Threading.SemaphoreSlim.Release()`；`System.Threading.SemaphoreSlim.WaitAsync(System.Threading.CancellationToken)`；`System.Threading.Tasks.Task.Run<TResult>(System.Func<TResult>, System.Threading.CancellationToken)`

**字段、属性、事件及方法组引用：** `NationalSpire.RandomEventArt.DecodeSlot`；`NationalSpire.RandomEventArt.GamePath(string)`；`NationalSpire.RandomEventArt.IsGameArt(string)`；`NationalSpire.RandomEventArt.ReadPixels(string, System.Threading.CancellationToken)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.ToSignal(Godot.GodotObject, Godot.StringName)`；输入表达式：`tree.ToSignal(tree, SceneTree.SignalName.ProcessFrame)`；返回值紧邻使用处：`AwaitExpressionSyntax: await tree.ToSignal(tree, SceneTree.SignalName.ProcessFrame)`
- `Godot.ImageTexture.CreateFromImage(Godot.Image)`；输入表达式：`ImageTexture.CreateFromImage(pixels)`；返回值紧邻使用处：`ConditionalExpressionSyntax: pixels == null ? null : ImageTexture.CreateFromImage(pixels)`
- `Godot.ResourceLoader.Exists(string, string)`；输入表达式：`ResourceLoader.Exists(path)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ResourceLoader.Exists(path)`
- `Godot.ResourceLoader.LoadThreadedGet(string)`；输入表达式：`ResourceLoader.LoadThreadedGet(path)`；返回值紧邻使用处：`BinaryExpressionSyntax: ResourceLoader.LoadThreadedGet(path) as Texture2D`
- `Godot.ResourceLoader.LoadThreadedGetStatus(string, Godot.Collections.Array)`；输入表达式：`ResourceLoader.LoadThreadedGetStatus(path)`；返回值紧邻使用处：`BinaryExpressionSyntax: ResourceLoader.LoadThreadedGetStatus(path) == ResourceLoader.ThreadLoadStatus.InProgress`
- `Godot.ResourceLoader.LoadThreadedRequest(string, string, bool, Godot.ResourceLoader.CacheMode)`；输入表达式：`ResourceLoader.LoadThreadedRequest(path, "Texture2D")`；返回值紧邻使用处：`BinaryExpressionSyntax: ResourceLoader.LoadThreadedRequest(path, "Texture2D") != Error.Ok`
- `NationalSpire.RandomEventArt.GamePath(string)`；输入表达式：`GamePath(id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GamePath(id)`
- `NationalSpire.RandomEventArt.IsGameArt(string)`；输入表达式：`IsGameArt(id)`；返回值紧邻使用处：`IfStatementSyntax: if (IsGameArt(id)) { string path = GamePath(id); if (!ResourceLoader.Exists(path) || ResourceLoader.LoadThreadedRequest(path, "Texture2D") != Error.Ok) return null; while (ResourceLoader.LoadThreadedGetStatus(path) == ResourceLoader.ThreadLoadStatus.InProgress) await tree.ToSignal(tree, SceneTree.SignalName.ProcessFrame); return ResourceLoader.LoadThreadedGet(path) as Texture2D; }`
- `NationalSpire.RandomEventArt.ReadPixels(string, System.Threading.CancellationToken)`；输入表达式：`ReadPixels(id, token)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ReadPixels(id, token)`
- `System.Threading.CancellationToken.ThrowIfCancellationRequested()`；输入表达式：`token.ThrowIfCancellationRequested()`；返回值紧邻使用处：`ExpressionStatementSyntax: token.ThrowIfCancellationRequested();`
- `System.Threading.SemaphoreSlim.Release()`；输入表达式：`DecodeSlot.Release()`；返回值紧邻使用处：`ExpressionStatementSyntax: DecodeSlot.Release();`
- `System.Threading.SemaphoreSlim.WaitAsync(System.Threading.CancellationToken)`；输入表达式：`DecodeSlot.WaitAsync(token)`；返回值紧邻使用处：`AwaitExpressionSyntax: await DecodeSlot.WaitAsync(token)`
- `System.Threading.Tasks.Task.Run<TResult>(System.Func<TResult>, System.Threading.CancellationToken)`；输入表达式：`Task.Run(() => ReadPixels(id, token), token)`；返回值紧邻使用处：`AwaitExpressionSyntax: await Task.Run(() => ReadPixels(id, token), token)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b98bbf61f246"></a>

## `NationalSpire.EventArtPicture.ShowArt(string) — internal async void ShowArt(string id)`

来源：源码第 83 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ShowJourneyEncounter()`](EventJourneyScreen.cs.md#symbol-4e94d6a77974)；[`NationalSpire.EventStoryView.Display(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.EventLive?, bool)`](RandomEventScreen.cs.md#symbol-f847e9f29b0e)

**调用：** `Godot.GD.PushWarning(string)`；`Godot.GodotObject.Dispose()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.Node.GetTree()`；[`NationalSpire.EventArtPicture.SetArt(Godot.Texture2D?, bool)`](RandomEventArt.cs.md#symbol-4e16f0013a81)；[`NationalSpire.RandomEventArt.IsGameArt(string)`](RandomEventArt.cs.md#symbol-ae11038396a9)；[`NationalSpire.RandomEventArt.LoadAsync(string, Godot.SceneTree, System.Threading.CancellationToken)`](RandomEventArt.cs.md#symbol-8d4310f4546c)；`System.Threading.CancellationTokenSource.Cancel()`；`System.Threading.CancellationTokenSource.CancellationTokenSource()`；`System.Threading.CancellationTokenSource.Dispose()`

**字段、属性、事件及方法组引用：** `NationalSpire.EventArtPicture.SetArt(Godot.Texture2D?, bool)`；`NationalSpire.EventArtPicture._pending`；`NationalSpire.RandomEventArt.IsGameArt(string)`；`NationalSpire.RandomEventArt.LoadAsync(string, Godot.SceneTree, System.Threading.CancellationToken)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GD.PushWarning(string)`；输入表达式：`GD.PushWarning("[NationalSpire] 际遇背景加载失败：" + e.Message)`；返回值紧邻使用处：`ExpressionStatementSyntax: GD.PushWarning("[NationalSpire] 际遇背景加载失败：" + e.Message);`
- `Godot.GodotObject.Dispose()`；输入表达式：`.Dispose()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: texture?.Dispose()`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(this)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(this)`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`IsQueuedForDeletion()`；返回值紧邻使用处：`BinaryExpressionSyntax: request.IsCancellationRequested || !IsInstanceValid(this) || IsQueuedForDeletion()`
- `Godot.Node.GetTree()`；输入表达式：`GetTree()`；返回值紧邻使用处：`ArgumentSyntax: GetTree()`
- `NationalSpire.EventArtPicture.SetArt(Godot.Texture2D?, bool)`；输入表达式：`SetArt(null, false)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetArt(null, false);`
- `NationalSpire.EventArtPicture.SetArt(Godot.Texture2D?, bool)`；输入表达式：`SetArt(texture, gameArt)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetArt(texture, gameArt);`
- `NationalSpire.RandomEventArt.IsGameArt(string)`；输入表达式：`RandomEventArt.IsGameArt(id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RandomEventArt.IsGameArt(id)`
- `NationalSpire.RandomEventArt.LoadAsync(string, Godot.SceneTree, System.Threading.CancellationToken)`；输入表达式：`RandomEventArt.LoadAsync(id, GetTree(), request.Token)`；返回值紧邻使用处：`AwaitExpressionSyntax: await RandomEventArt.LoadAsync(id, GetTree(), request.Token)`
- `System.Threading.CancellationTokenSource.Cancel()`；输入表达式：`.Cancel()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _pending?.Cancel()`
- `System.Threading.CancellationTokenSource.CancellationTokenSource()`；输入表达式：`new CancellationTokenSource()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _pending = new CancellationTokenSource()`
- `System.Threading.CancellationTokenSource.Dispose()`；输入表达式：`request.Dispose()`；返回值紧邻使用处：`ExpressionStatementSyntax: request.Dispose();`

**赋值（含属性/字段和局部值）：**

- `_pending` = `new CancellationTokenSource()`
- `_pending` = `null`

<a id="symbol-4e16f0013a81"></a>

## `NationalSpire.EventArtPicture.SetArt(Godot.Texture2D?, bool) — private void SetArt(Texture2D? texture, bool gameArt)`

来源：源码第 112 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EventArtPicture.ShowArt(string)`](RandomEventArt.cs.md#symbol-b98bbf61f246)；[`NationalSpire.EventArtPicture._ExitTree()`](RandomEventArt.cs.md#symbol-f995a9275e1d)

**调用：** `Godot.GodotObject.Dispose()`；`Godot.ShaderMaterial.SetShaderParameter(Godot.StringName, Godot.Variant)`

**字段、属性、事件及方法组引用：** `NationalSpire.EventArtPicture._owned`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.Dispose()`；输入表达式：`.Dispose()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: previous?.Dispose()`
- `Godot.ShaderMaterial.SetShaderParameter(Godot.StringName, Godot.Variant)`；输入表达式：`material.SetShaderParameter("original", gameArt ? 1f : 0f)`；返回值紧邻使用处：`ExpressionStatementSyntax: material.SetShaderParameter("original", gameArt ? 1f : 0f);`

**赋值（含属性/字段和局部值）：**

- `Texture` = `texture`
- `_owned` = `gameArt ? null : texture`

<a id="symbol-f995a9275e1d"></a>

## `NationalSpire.EventArtPicture._ExitTree() — public override void _ExitTree()`

来源：源码第 120 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.EventArtPicture.SetArt(Godot.Texture2D?, bool)`](RandomEventArt.cs.md#symbol-4e16f0013a81)；`System.Threading.CancellationTokenSource.Cancel()`

**字段、属性、事件及方法组引用：** `NationalSpire.EventArtPicture.SetArt(Godot.Texture2D?, bool)`；`NationalSpire.EventArtPicture._pending`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.EventArtPicture.SetArt(Godot.Texture2D?, bool)`；输入表达式：`SetArt(null, false)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetArt(null, false);`
- `System.Threading.CancellationTokenSource.Cancel()`；输入表达式：`.Cancel()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _pending?.Cancel()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b4f1de4518b3"></a>

## `NationalSpire.EventEmblem._Ready() — public override void _Ready()`

来源：源码第 131 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.AtlasTexture.AtlasTexture()`；`Godot.GD.Load<T>(string)`；`Godot.ResourceLoader.Exists(string, string)`

**字段、属性、事件及方法组引用：** `NationalSpire.EventEmblem._icon`；`NationalSpire.RandomEventArt.UnknownIcon`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.AtlasTexture.AtlasTexture()`；输入表达式：`new AtlasTexture { Atlas = atlas.Atlas, Region = atlas.Region }`；返回值紧邻使用处：`ConditionalExpressionSyntax: icon is AtlasTexture atlas ? new AtlasTexture { Atlas = atlas.Atlas, Region = atlas.Region } : icon`
- `Godot.GD.Load<T>(string)`；输入表达式：`GD.Load<Texture2D>(RandomEventArt.UnknownIcon)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GD.Load<Texture2D>(RandomEventArt.UnknownIcon)`
- `Godot.ResourceLoader.Exists(string, string)`；输入表达式：`ResourceLoader.Exists(RandomEventArt.UnknownIcon)`；返回值紧邻使用处：`IfStatementSyntax: if (ResourceLoader.Exists(RandomEventArt.UnknownIcon))          {              var icon = GD.Load<Texture2D>(RandomEventArt.UnknownIcon);              _icon = icon is AtlasTexture atlas ? new AtlasTexture { Atlas = atlas.Atlas, Region = atlas.Region } : icon;          }`

**赋值（含属性/字段和局部值）：**

- `_icon` = `icon is AtlasTexture atlas ? new AtlasTexture { Atlas = atlas.Atlas, Region = atlas.Region } : icon`
- `Atlas` = `atlas.Atlas`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Region` = `atlas.Region`
- `Resized` += `QueueRedraw`

<a id="symbol-6e57b64df6f1"></a>

## `NationalSpire.EventEmblem._Draw() — public override void _Draw()`

来源：源码第 141 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；`Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；`Godot.CanvasItem.DrawString(Godot.Font, Godot.Vector2, string, Godot.HorizontalAlignment, float, int, Godot.Color?, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation, float)`；`Godot.CanvasItem.DrawTextureRect(Godot.Texture2D, Godot.Rect2, bool, Godot.Color?, bool)`；`Godot.Color.Color(string)`；`Godot.Control.GetThemeDefaultFont()`；`Godot.Font.GetAscent(int)`；`Godot.Font.GetDescent(int)`；`Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.Vector2.Vector2(float, float)`；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Teal`；`NationalSpire.EventEmblem._icon`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(c, r, -.3f, Mathf.Pi * .82f, 30, gold, 1, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(c, r, -.3f, Mathf.Pi * .82f, 30, gold, 1, true);`
- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(c, r, Mathf.Pi - .3f, Mathf.Pi * 1.82f, 30, gold, 1, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(c, r, Mathf.Pi - .3f, Mathf.Pi * 1.82f, 30, gold, 1, true);`
- `Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；输入表达式：`DrawCircle(c, r, new Color("182d3b"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawCircle(c, r, new Color("182d3b"));`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon([p + new Vector2(-3, 0), p + new Vector2(0, -3), p + new Vector2(3, 0), p + new Vector2(0, 3)], CareerVisuals.Teal)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon([p + new Vector2(-3, 0), p + new Vector2(0, -3), p + new Vector2(3, 0), p + new Vector2(0, 3)], CareerVisuals.Teal);`
- `Godot.CanvasItem.DrawString(Godot.Font, Godot.Vector2, string, Godot.HorizontalAlignment, float, int, Godot.Color?, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation, float)`；输入表达式：`DrawString(font, c + new Vector2(-measure.X / 2, (font.GetAscent(size) - font.GetDescent(size)) / 2), "?", fontSize: size, modulate: gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawString(font, c + new Vector2(-measure.X / 2, (font.GetAscent(size) - font.GetDescent(size)) / 2), "?", fontSize: size, modulate: gold);`
- `Godot.CanvasItem.DrawTextureRect(Godot.Texture2D, Godot.Rect2, bool, Godot.Color?, bool)`；输入表达式：`DrawTextureRect(_icon, new Rect2(c - Vector2.One * r * .76f, Vector2.One * r * 1.52f), false, gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawTextureRect(_icon, new Rect2(c - Vector2.One * r * .76f, Vector2.One * r * 1.52f), false, gold);`
- `Godot.Color.Color(string)`；输入表达式：`new Color("182d3b")`；返回值紧邻使用处：`ArgumentSyntax: new Color("182d3b")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("c7ae7a")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Color("c7ae7a")`
- `Godot.Control.GetThemeDefaultFont()`；输入表达式：`GetThemeDefaultFont()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GetThemeDefaultFont()`
- `Godot.Font.GetAscent(int)`；输入表达式：`font.GetAscent(size)`；返回值紧邻使用处：`BinaryExpressionSyntax: font.GetAscent(size) - font.GetDescent(size)`
- `Godot.Font.GetDescent(int)`；输入表达式：`font.GetDescent(size)`；返回值紧邻使用处：`BinaryExpressionSyntax: font.GetAscent(size) - font.GetDescent(size)`
- `Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；输入表达式：`font.GetStringSize("?", fontSize: size)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = font.GetStringSize("?", fontSize: size)`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(c - Vector2.One * r * .76f, Vector2.One * r * 1.52f)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(c - Vector2.One * r * .76f, Vector2.One * r * 1.52f)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-3, 0)`；返回值紧邻使用处：`BinaryExpressionSyntax: p + new Vector2(-3, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-measure.X / 2, (font.GetAscent(size) - font.GetDescent(size)) / 2)`；返回值紧邻使用处：`BinaryExpressionSyntax: c + new Vector2(-measure.X / 2, (font.GetAscent(size) - font.GetDescent(size)) / 2)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, -3)`；返回值紧邻使用处：`BinaryExpressionSyntax: p + new Vector2(0, -3)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, 3)`；返回值紧邻使用处：`BinaryExpressionSyntax: p + new Vector2(0, 3)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(3, 0)`；返回值紧邻使用处：`BinaryExpressionSyntax: p + new Vector2(3, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(sign * r, 0)`；返回值紧邻使用处：`BinaryExpressionSyntax: c + new Vector2(sign * r, 0)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(Size.X, Size.Y)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Min(Size.X, Size.Y) * .43f`

**赋值（含属性/字段和局部值）：**
