# DateSceneCast.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`9C27CEF2BE2466147F072E758C1E490F1354018D97688280EFA299F34BE10642`。来源：[源码](../../DateSceneCast.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.DateSceneCast`、`NationalSpire.DateCastRoster`、`NationalSpire.DateSceneView`。

字段、事件及初始值（源码原样）：

```csharp
private Texture2D? _default;
private readonly List<string> _visible = [];
private readonly Queue<string> _recent = new();
private string _lastSpeaker = "";
private readonly List<DateSceneCast> _cast = [];
private readonly Dictionary<string, TextureRect> _castSprites = [];
private readonly List<string> _visibleCast = [];
private readonly DateCastRoster _castRoster = new();
private bool _castConfigured;
private string _speaker = "";
private bool _castNarration;
private readonly Dictionary<string, DatePortraitPlacement> _portraitPlacements = [];
```

<a id="symbol-3661ac1602ca"></a>

## `NationalSpire.DateSceneCast.Default — public Texture2D Default`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Func<TResult>.Invoke()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneCast.LoadDefault`；`NationalSpire.DateSceneCast._default`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Func<TResult>.Invoke()`；输入表达式：`LoadDefault()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _default ??= LoadDefault()`

**赋值（含属性/字段和局部值）：**

- `_default` ??= `LoadDefault()`

<a id="symbol-38299cc02f1b"></a>

## `NationalSpire.DateCastRoster.Visible — public IReadOnlyList<string> Visible`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.DateCastRoster._visible`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f677f7756d35"></a>

## `NationalSpire.DateCastRoster.Clear() — public void Clear()`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateCastRoster.Replay(System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, string)`](DateSceneCast.cs.md#symbol-b3a34a475c3e)

**调用：** `System.Collections.Generic.List<T>.Clear()`；`System.Collections.Generic.Queue<T>.Clear()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateCastRoster._lastSpeaker`；`NationalSpire.DateCastRoster._recent`；`NationalSpire.DateCastRoster._visible`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`_visible.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _visible.Clear();`
- `System.Collections.Generic.Queue<T>.Clear()`；输入表达式：`_recent.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _recent.Clear();`

**赋值（含属性/字段和局部值）：**

- `_lastSpeaker` = `""`

<a id="symbol-d85e4199ab71"></a>

## `NationalSpire.DateCastRoster.Observe(NationalSpire.DateSceneLine, string) — public void Observe(DateSceneLine line, string fallback)`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateCastRoster.Replay(System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, string)`](DateSceneCast.cs.md#symbol-b3a34a475c3e)；[`NationalSpire.DateMemoryPlayback.BuildPages()`](DateSceneMemoryPlayback.cs.md#symbol-e09e5b7ddabe)；[`NationalSpire.DateSceneView.SelectSpeaker(NationalSpire.DateSceneLine, Godot.Texture2D, bool)`](DateSceneCast.cs.md#symbol-52d06ed87b40)

**调用：** `System.Array.LastIndexOf<T>(T[], T)`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.IndexOf(T)`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；`System.Collections.Generic.Queue<T>.Contains(T)`；`System.Collections.Generic.Queue<T>.Dequeue()`；`System.Collections.Generic.Queue<T>.Enqueue(T)`；`System.Collections.Generic.Queue<T>.ToArray()`；`string.IsNullOrWhiteSpace(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateCastRoster._lastSpeaker`；`NationalSpire.DateCastRoster._recent`；`NationalSpire.DateCastRoster._visible`；`NationalSpire.DateSceneLine.Narration`；`NationalSpire.DateSceneLine.Speaker`；`NationalSpire.DateSceneLine.Text`；`NationalSpire.DateSceneParty.VisibleMaximum`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Array.LastIndexOf<T>(T[], T)`；输入表达式：`Array.LastIndexOf(history, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => Array.LastIndexOf(history, id)`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；输入表达式：`_visible.OrderBy(id => Array.LastIndexOf(history, id)).First()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _visible.OrderBy(id => Array.LastIndexOf(history, id)).First()`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`_visible.OrderBy(id => Array.LastIndexOf(history, id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _visible.OrderBy(id => Array.LastIndexOf(history, id)).First`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`_visible.Add(speaker)`；返回值紧邻使用处：`ExpressionStatementSyntax: _visible.Add(speaker);`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`_visible.Contains(speaker)`；返回值紧邻使用处：`IfStatementSyntax: if (_visible.Contains(speaker)) return;`
- `System.Collections.Generic.List<T>.IndexOf(T)`；输入表达式：`_visible.IndexOf(oldest)`；返回值紧邻使用处：`ArgumentSyntax: _visible.IndexOf(oldest)`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`_visible.RemoveAll(id => !_recent.Contains(id))`；返回值紧邻使用处：`ExpressionStatementSyntax: _visible.RemoveAll(id => !_recent.Contains(id));`
- `System.Collections.Generic.Queue<T>.Contains(T)`；输入表达式：`_recent.Contains(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_recent.Contains(id)`
- `System.Collections.Generic.Queue<T>.Dequeue()`；输入表达式：`_recent.Dequeue()`；返回值紧邻使用处：`ExpressionStatementSyntax: _recent.Dequeue();`
- `System.Collections.Generic.Queue<T>.Enqueue(T)`；输入表达式：`_recent.Enqueue(speaker)`；返回值紧邻使用处：`ExpressionStatementSyntax: _recent.Enqueue(speaker);`
- `System.Collections.Generic.Queue<T>.ToArray()`；输入表达式：`_recent.ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _recent.ToArray()`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(line.Text)`；返回值紧邻使用处：`BinaryExpressionSyntax: line.Narration || string.IsNullOrWhiteSpace(line.Text)`

**赋值（含属性/字段和局部值）：**

- `_lastSpeaker` = `speaker`
- `_visible[_visible.IndexOf(oldest)]` = `speaker`

<a id="symbol-b3a34a475c3e"></a>

## `NationalSpire.DateCastRoster.Replay(System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, string) — public void Replay(IReadOnlyList<DateSceneLine> lines, int index, string fallback)`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView.ShowRoundLine(System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, string, Godot.Texture2D)`](DateSceneCast.cs.md#symbol-35177f2945fc)

**调用：** [`NationalSpire.DateCastRoster.Clear()`](DateSceneCast.cs.md#symbol-f677f7756d35)；[`NationalSpire.DateCastRoster.Observe(NationalSpire.DateSceneLine, string)`](DateSceneCast.cs.md#symbol-d85e4199ab71)

**字段、属性、事件及方法组引用：** `NationalSpire.DateCastRoster.Clear()`；`NationalSpire.DateCastRoster.Observe(NationalSpire.DateSceneLine, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateCastRoster.Clear()`；输入表达式：`Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: Clear();`
- `NationalSpire.DateCastRoster.Observe(NationalSpire.DateSceneLine, string)`；输入表达式：`Observe(lines[i], fallback)`；返回值紧邻使用处：`ExpressionStatementSyntax: Observe(lines[i], fallback);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-80abec64fd7f"></a>

## `NationalSpire.DateSceneView.PortraitPlacements(System.Collections.Generic.IReadOnlyDictionary<string, NationalSpire.DatePortraitPlacement>) — public void PortraitPlacements(IReadOnlyDictionary<string, DatePortraitPlacement> placements)`

来源：源码第 55 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ApplyDatePortraitPlacements()`](DateScenePortraitSettings.cs.md#symbol-9e6a2d77a042)；[`NationalSpire.DateSceneView.ShowMemoryFrame(NationalSpire.DateMemoryFrame, NationalSpire.DateSceneLine, string, bool, System.Collections.Generic.IReadOnlyDictionary<string, NationalSpire.DateMemoryPerson>, System.Func<string, Godot.Texture2D>)`](DateSceneMemoryPlayback.cs.md#symbol-428af8387aa7)

**调用：** [`NationalSpire.DatePortraitPlacement.Normalized()`](DateSceneAssets.cs.md#symbol-67e9c0f8f2dc)；[`NationalSpire.DateSceneView.Layout()`](DateSceneView.cs.md#symbol-80b96be1ed4b)；`System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`

**字段、属性、事件及方法组引用：** `NationalSpire.DatePortraitPlacement.Normalized()`；`NationalSpire.DateSceneView.Layout()`；`NationalSpire.DateSceneView._portraitPlacements`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DatePortraitPlacement.Normalized()`；输入表达式：`placement.Normalized()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _portraitPlacements[id] = placement.Normalized()`
- `NationalSpire.DateSceneView.Layout()`；输入表达式：`Layout()`；返回值紧邻使用处：`ExpressionStatementSyntax: Layout();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_portraitPlacements.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _portraitPlacements.Clear();`

**赋值（含属性/字段和局部值）：**

- `_portraitPlacements[id]` = `placement.Normalized()`

<a id="symbol-09f2107801c6"></a>

## `NationalSpire.DateSceneView.PortraitSize(string) — private Vector2 PortraitSize(string person)`

来源：源码第 61 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView.Layout()`](DateSceneView.cs.md#symbol-80b96be1ed4b)；[`NationalSpire.DateSceneView.LayoutCast()`](DateSceneCast.cs.md#symbol-0a6a432034a8)

**调用：** `Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.DatePortraitPlacement.Scale`；`NationalSpire.DateSceneView._portraitPlacements`；`NationalSpire.DateSceneView._spriteScale`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(Size.Y * .62f * 1.3f, Size.Y * .93f * 1.3f)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(Size.Y * .62f * 1.3f, Size.Y * .93f * 1.3f) * (_portraitPlacements.TryGetValue(person, out var placement) ? (float)placement.Scale : _spriteScale)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_portraitPlacements.TryGetValue(person, out var placement)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _portraitPlacements.TryGetValue(person, out var placement) ? (float)placement.Scale : _spriteScale`

**赋值（含属性/字段和局部值）：**


<a id="symbol-660b122db429"></a>

## `NationalSpire.DateSceneView.PortraitPosition(string, int, Godot.Vector2, Godot.Texture2D?) — private Vector2 PortraitPosition(string person, int slot, Vector2 size, Texture2D? anchor)`

来源：源码第 63 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView.Layout()`](DateSceneView.cs.md#symbol-80b96be1ed4b)；[`NationalSpire.DateSceneView.LayoutCast()`](DateSceneCast.cs.md#symbol-0a6a432034a8)

**调用：** `Godot.GodotObject.GetInstanceId()`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.DateSceneParty.Position(int, int)`](DateSceneParty.cs.md#symbol-050345b203c6)；[`NationalSpire.DateSceneView.RememberSprite(Godot.Texture2D)`](DateSceneWaiting.cs.md#symbol-9b17a8ece561)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.DatePortraitPlacement.Y`；`NationalSpire.DateSceneParty.Position(int, int)`；`NationalSpire.DateSceneView.RememberSprite(Godot.Texture2D)`；`NationalSpire.DateSceneView._headRatios`；`NationalSpire.DateSceneView._portraitPlacements`；`NationalSpire.DateSceneView._spriteX`；`NationalSpire.DateSceneView._spriteY`；`NationalSpire.DateSceneView._visibleCast`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.GetInstanceId()`；输入表达式：`anchor.GetInstanceId()`；返回值紧邻使用处：`ArgumentSyntax: anchor.GetInstanceId()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(Size.X * DateSceneParty.Position(_visibleCast.Count, Math.Max(0, slot)) - size.X * .5f + (individual ? 0 : _spriteX), Size.Y * .4f - top * size.Y - 160 + (individual ? -(float)placement!.Y : _spriteY))`；返回值紧邻使用处：`ReturnStatementSyntax: return new(Size.X * DateSceneParty.Position(_visibleCast.Count, Math.Max(0, slot)) - size.X * .5f + (individual ? 0 : _spriteX), Size.Y * .4f - top * size.Y - 160 + (individual ? -(float)placement!.Y : _spriteY));`
- `NationalSpire.DateSceneParty.Position(int, int)`；输入表达式：`DateSceneParty.Position(_visibleCast.Count, Math.Max(0, slot))`；返回值紧邻使用处：`BinaryExpressionSyntax: Size.X * DateSceneParty.Position(_visibleCast.Count, Math.Max(0, slot))`
- `NationalSpire.DateSceneView.RememberSprite(Godot.Texture2D)`；输入表达式：`RememberSprite(anchor)`；返回值紧邻使用处：`ExpressionStatementSyntax: RememberSprite(anchor);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_portraitPlacements.TryGetValue(person, out var placement)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _portraitPlacements.TryGetValue(person, out var placement)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`_headRatios.GetValueOrDefault(anchor.GetInstanceId())`；返回值紧邻使用处：`ConditionalExpressionSyntax: anchor == null ? 0 : _headRatios.GetValueOrDefault(anchor.GetInstanceId())`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, slot)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, slot)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8cb2173ec0a1"></a>

## `NationalSpire.DateSceneView.SpeakerId — public string SpeakerId`

来源：源码第 71 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView._speaker`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-913514fd78e1"></a>

## `NationalSpire.DateSceneView.SetCast(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneCast>) — public void SetCast(IEnumerable<DateSceneCast> cast)`

来源：源码第 72 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DateSceneSettings()`](DateSceneScreen.cs.md#symbol-0845ec2acab1)；[`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)；[`NationalSpire.CareerScreen.RefreshDateParty()`](DateScenePartyScreen.cs.md#symbol-3918c1aaf95a)；[`NationalSpire.DateSceneTesting._Ready()`](DateSceneTesting.cs.md#symbol-2174d0446f18)；[`NationalSpire.DateSceneView.ShowMemoryFrame(NationalSpire.DateMemoryFrame, NationalSpire.DateSceneLine, string, bool, System.Collections.Generic.IReadOnlyDictionary<string, NationalSpire.DateMemoryPerson>, System.Func<string, Godot.Texture2D>)`](DateSceneMemoryPlayback.cs.md#symbol-428af8387aa7)

**调用：** [`NationalSpire.DateSceneView.BeginWaiting()`](DateSceneWaiting.cs.md#symbol-289036db5043)；[`NationalSpire.DateSceneView.EndWaiting()`](DateSceneWaiting.cs.md#symbol-03e797c35180)；[`NationalSpire.DateSceneView.Layout()`](DateSceneView.cs.md#symbol-80b96be1ed4b)；[`NationalSpire.DateSceneView.RestoreVisibleCast(System.Collections.Generic.IEnumerable<string>)`](DateSceneCast.cs.md#symbol-2d5e455c25d0)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.List<T>.Clear()`；`System.Collections.Generic.List<T>.ToArray()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneCast.Default`；`NationalSpire.DateSceneCast.PersonId`；`NationalSpire.DateSceneView.BeginWaiting()`；`NationalSpire.DateSceneView.EndWaiting()`；`NationalSpire.DateSceneView.Layout()`；`NationalSpire.DateSceneView.RestoreVisibleCast(System.Collections.Generic.IEnumerable<string>)`；`NationalSpire.DateSceneView.WaitingDefault`；`NationalSpire.DateSceneView._alpha`；`NationalSpire.DateSceneView._cast`；`NationalSpire.DateSceneView._castConfigured`；`NationalSpire.DateSceneView._positionAnchor`；`NationalSpire.DateSceneView._speaker`；`NationalSpire.DateSceneView._sprite`；`NationalSpire.DateSceneView._targetAlpha`；`NationalSpire.DateSceneView._visibleCast`；`NationalSpire.DateSceneView._waiting`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneView.BeginWaiting()`；输入表达式：`BeginWaiting()`；返回值紧邻使用处：`ExpressionStatementSyntax: BeginWaiting();`
- `NationalSpire.DateSceneView.EndWaiting()`；输入表达式：`EndWaiting()`；返回值紧邻使用处：`ExpressionStatementSyntax: EndWaiting();`
- `NationalSpire.DateSceneView.Layout()`；输入表达式：`Layout()`；返回值紧邻使用处：`ExpressionStatementSyntax: Layout();`
- `NationalSpire.DateSceneView.RestoreVisibleCast(System.Collections.Generic.IEnumerable<string>)`；输入表达式：`RestoreVisibleCast(visible)`；返回值紧邻使用处：`ExpressionStatementSyntax: RestoreVisibleCast(visible);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`_cast.Any(c => c.PersonId == _speaker)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_cast.Any(c => c.PersonId == _speaker)`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`_cast.First(c => c.PersonId == _speaker)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _cast.First(c => c.PersonId == _speaker).Default`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`cast.ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = cast.ToArray()`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`_cast.AddRange(members)`；返回值紧邻使用处：`ExpressionStatementSyntax: _cast.AddRange(members);`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`_cast.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _cast.Clear();`
- `System.Collections.Generic.List<T>.ToArray()`；输入表达式：`_visibleCast.ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _visibleCast.ToArray()`

**赋值（含属性/字段和局部值）：**

- `WaitingDefault` = `_cast.First(c => c.PersonId == _speaker).Default`
- `WaitingDefault` = `_sprite.Texture = null`
- `_alpha` = `_targetAlpha = 0`
- `_castConfigured` = `true`
- `_positionAnchor` = `WaitingDefault = _cast.First(c => c.PersonId == _speaker).Default`
- `_positionAnchor` = `WaitingDefault = _sprite.Texture = null`
- `_speaker` = `""`
- `_sprite.Texture` = `null`
- `_targetAlpha` = `0`

<a id="symbol-2d5e455c25d0"></a>

## `NationalSpire.DateSceneView.RestoreVisibleCast(System.Collections.Generic.IEnumerable<string>) — private void RestoreVisibleCast(IEnumerable<string> visible)`

来源：源码第 89 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView.SelectSpeaker(NationalSpire.DateSceneLine, Godot.Texture2D, bool)`](DateSceneCast.cs.md#symbol-52d06ed87b40)；[`NationalSpire.DateSceneView.SetCast(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneCast>)`](DateSceneCast.cs.md#symbol-913514fd78e1)；[`NationalSpire.DateSceneView.ShowMemoryFrame(NationalSpire.DateMemoryFrame, NationalSpire.DateSceneLine, string, bool, System.Collections.Generic.IReadOnlyDictionary<string, NationalSpire.DateMemoryPerson>, System.Func<string, Godot.Texture2D>)`](DateSceneMemoryPlayback.cs.md#symbol-428af8387aa7)；[`NationalSpire.DateSceneView.ShowRoundLine(System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, string, Godot.Texture2D)`](DateSceneCast.cs.md#symbol-35177f2945fc)

**调用：** `Godot.CanvasItem.Hide()`；`Godot.Node.QueueFree()`；[`NationalSpire.DateSceneView.AddCastSprite(NationalSpire.DateSceneCast)`](DateSceneCast.cs.md#symbol-2b81e5e41a28)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Except<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.List<T>.Clear()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneCast.PersonId`；`NationalSpire.DateSceneParty.VisibleMaximum`；`NationalSpire.DateSceneView.AddCastSprite(NationalSpire.DateSceneCast)`；`NationalSpire.DateSceneView._cast`；`NationalSpire.DateSceneView._castSprites`；`NationalSpire.DateSceneView._visibleCast`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`node.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: node.Hide();`
- `Godot.Node.QueueFree()`；输入表达式：`node.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: node.QueueFree();`
- `NationalSpire.DateSceneView.AddCastSprite(NationalSpire.DateSceneCast)`；输入表达式：`AddCastSprite(_cast.First(c => c.PersonId == id))`；返回值紧邻使用处：`ExpressionStatementSyntax: AddCastSprite(_cast.First(c => c.PersonId == id));`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`_castSprites.ContainsKey(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_castSprites.ContainsKey(id)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`_castSprites.Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: _castSprites.Remove(id);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`_cast.Any(c => c.PersonId == id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => _cast.Any(c => c.PersonId == id)`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`visible.Where(id => _cast.Any(c => c.PersonId == id)).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: visible.Where(id => _cast.Any(c => c.PersonId == id)).Distinct().Take`
- `System.Collections.Generic.IEnumerable<TSource>.Except<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`_castSprites.Keys.Except(ids)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _castSprites.Keys.Except(ids).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`_cast.First(c => c.PersonId == id)`；返回值紧邻使用处：`ArgumentSyntax: _cast.First(c => c.PersonId == id)`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`visible.Where(id => _cast.Any(c => c.PersonId == id)).Distinct().Take(DateSceneParty.VisibleMaximum)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: visible.Where(id => _cast.Any(c => c.PersonId == id)).Distinct().Take(DateSceneParty.VisibleMaximum).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`_castSprites.Keys.Except(ids).ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string id in _castSprites.Keys.Except(ids).ToArray()) { var node = _castSprites[id]; node.Hide(); node.QueueFree(); _castSprites.Remove(id); }`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`visible.Where(id => _cast.Any(c => c.PersonId == id)).Distinct().Take(DateSceneParty.VisibleMaximum).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = visible.Where(id => _cast.Any(c => c.PersonId == id)).Distinct().Take(DateSceneParty.VisibleMaximum).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`visible.Where(id => _cast.Any(c => c.PersonId == id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: visible.Where(id => _cast.Any(c => c.PersonId == id)).Distinct`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`_visibleCast.AddRange(ids)`；返回值紧邻使用处：`ExpressionStatementSyntax: _visibleCast.AddRange(ids);`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`_visibleCast.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _visibleCast.Clear();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-35177f2945fc"></a>

## `NationalSpire.DateSceneView.ShowRoundLine(System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, string, Godot.Texture2D) — public void ShowRoundLine(IReadOnlyList<DateSceneLine> lines, int index, string speaker, Texture2D sprite)`

来源：源码第 98 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ShowDateLine()`](DateSceneScreen.cs.md#symbol-1580b0be190e)；[`NationalSpire.DateSceneTesting.Show()`](DateSceneTesting.cs.md#symbol-ea6d8bf11dd7)；[`NationalSpire.DateSceneView.AppendLine(System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, System.Func<(string Name, Godot.Texture2D Texture)>?)`](DateSceneView.cs.md#symbol-eecb2292c03b)

**调用：** [`NationalSpire.DateCastRoster.Replay(System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, string)`](DateSceneCast.cs.md#symbol-b3a34a475c3e)；[`NationalSpire.DateSceneView.EndWaiting()`](DateSceneWaiting.cs.md#symbol-03e797c35180)；[`NationalSpire.DateSceneView.RestoreVisibleCast(System.Collections.Generic.IEnumerable<string>)`](DateSceneCast.cs.md#symbol-2d5e455c25d0)；[`NationalSpire.DateSceneView.ShowLineCore(NationalSpire.DateSceneLine, string, Godot.Texture2D, bool)`](DateSceneView.cs.md#symbol-d19549d8d807)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateCastRoster.Replay(System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, string)`；`NationalSpire.DateCastRoster.Visible`；`NationalSpire.DateSceneCast.PersonId`；`NationalSpire.DateSceneView.EndWaiting()`；`NationalSpire.DateSceneView.RestoreVisibleCast(System.Collections.Generic.IEnumerable<string>)`；`NationalSpire.DateSceneView.ShowLineCore(NationalSpire.DateSceneLine, string, Godot.Texture2D, bool)`；`NationalSpire.DateSceneView._cast`；`NationalSpire.DateSceneView._castRoster`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateCastRoster.Replay(System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, string)`；输入表达式：`_castRoster.Replay(lines, index, _cast.FirstOrDefault()?.PersonId ?? "")`；返回值紧邻使用处：`ExpressionStatementSyntax: _castRoster.Replay(lines, index, _cast.FirstOrDefault()?.PersonId ?? "");`
- `NationalSpire.DateSceneView.EndWaiting()`；输入表达式：`EndWaiting()`；返回值紧邻使用处：`ExpressionStatementSyntax: EndWaiting();`
- `NationalSpire.DateSceneView.RestoreVisibleCast(System.Collections.Generic.IEnumerable<string>)`；输入表达式：`RestoreVisibleCast(_castRoster.Visible)`；返回值紧邻使用处：`ExpressionStatementSyntax: RestoreVisibleCast(_castRoster.Visible);`
- `NationalSpire.DateSceneView.ShowLineCore(NationalSpire.DateSceneLine, string, Godot.Texture2D, bool)`；输入表达式：`ShowLineCore(lines[index], speaker, sprite, false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowLineCore(lines[index], speaker, sprite, false);`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`_cast.FirstOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _cast.FirstOrDefault()?.PersonId`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2b81e5e41a28"></a>

## `NationalSpire.DateSceneView.AddCastSprite(NationalSpire.DateSceneCast) — private void AddCastSprite(DateSceneCast member)`

来源：源码第 105 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView.RestoreVisibleCast(System.Collections.Generic.IEnumerable<string>)`](DateSceneCast.cs.md#symbol-2d5e455c25d0)

**调用：** `Godot.Color.Color(float, float, float, float)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetIndex(bool)`；`Godot.Node.MoveChild(Godot.Node, int)`；`Godot.TextureRect.TextureRect()`；[`NationalSpire.DateSceneView.RememberSprite(Godot.Texture2D)`](DateSceneWaiting.cs.md#symbol-9b17a8ece561)

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneCast.Default`；`NationalSpire.DateSceneCast.PersonId`；`NationalSpire.DateSceneView.RememberSprite(Godot.Texture2D)`；`NationalSpire.DateSceneView._castSprites`；`NationalSpire.DateSceneView._sprite`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new(1, 1, 1, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Modulate = new(1, 1, 1, 0)`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(node)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(node);`
- `Godot.Node.GetIndex(bool)`；输入表达式：`_sprite.GetIndex()`；返回值紧邻使用处：`ArgumentSyntax: _sprite.GetIndex()`
- `Godot.Node.MoveChild(Godot.Node, int)`；输入表达式：`MoveChild(node, _sprite.GetIndex())`；返回值紧邻使用处：`ExpressionStatementSyntax: MoveChild(node, _sprite.GetIndex());`
- `Godot.TextureRect.TextureRect()`；输入表达式：`new TextureRect { Name = "DateCast" + member.PersonId, Texture = texture, ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, MouseFilter = MouseFilterEnum.Ignore, Modulate = new(1, 1, 1, 0) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TextureRect { Name = "DateCast" + member.PersonId, Texture = texture, ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, MouseFilter = MouseFilterEnum.Ignore, Modulate = new(1, 1, 1, 0) }`
- `NationalSpire.DateSceneView.RememberSprite(Godot.Texture2D)`；输入表达式：`RememberSprite(texture)`；返回值紧邻使用处：`ExpressionStatementSyntax: RememberSprite(texture);`

**赋值（含属性/字段和局部值）：**

- `ExpandMode` = `TextureRect.ExpandModeEnum.IgnoreSize`
- `Modulate` = `new(1, 1, 1, 0)`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Name` = `"DateCast" + member.PersonId`
- `StretchMode` = `TextureRect.StretchModeEnum.KeepAspectCentered`
- `Texture` = `texture`
- `_castSprites[member.PersonId]` = `node`

<a id="symbol-52d06ed87b40"></a>

## `NationalSpire.DateSceneView.SelectSpeaker(NationalSpire.DateSceneLine, Godot.Texture2D, bool) — private void SelectSpeaker(DateSceneLine line, Texture2D texture, bool advanceCast)`

来源：源码第 114 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView.ShowLineCore(NationalSpire.DateSceneLine, string, Godot.Texture2D, bool)`](DateSceneView.cs.md#symbol-d19549d8d807)；[`NationalSpire.DateSceneView.ShowMemoryFrame(NationalSpire.DateMemoryFrame, NationalSpire.DateSceneLine, string, bool, System.Collections.Generic.IReadOnlyDictionary<string, NationalSpire.DateMemoryPerson>, System.Func<string, Godot.Texture2D>)`](DateSceneMemoryPlayback.cs.md#symbol-428af8387aa7)

**调用：** `Godot.CanvasItem.Hide()`；`Godot.Color.Color(float, float, float, float)`；[`NationalSpire.DateCastRoster.Observe(NationalSpire.DateSceneLine, string)`](DateSceneCast.cs.md#symbol-d85e4199ab71)；[`NationalSpire.DateSceneView.RestoreVisibleCast(System.Collections.Generic.IEnumerable<string>)`](DateSceneCast.cs.md#symbol-2d5e455c25d0)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateCastRoster.Observe(NationalSpire.DateSceneLine, string)`；`NationalSpire.DateCastRoster.Visible`；`NationalSpire.DateSceneCast.Default`；`NationalSpire.DateSceneCast.PersonId`；`NationalSpire.DateSceneLine.Narration`；`NationalSpire.DateSceneLine.Speaker`；`NationalSpire.DateSceneView.RestoreVisibleCast(System.Collections.Generic.IEnumerable<string>)`；`NationalSpire.DateSceneView.WaitingDefault`；`NationalSpire.DateSceneView._alpha`；`NationalSpire.DateSceneView._cast`；`NationalSpire.DateSceneView._castNarration`；`NationalSpire.DateSceneView._castRoster`；`NationalSpire.DateSceneView._castSprites`；`NationalSpire.DateSceneView._positionAnchor`；`NationalSpire.DateSceneView._speaker`；`NationalSpire.DateSceneView._sprite`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`current.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: current.Hide();`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(1, 1, 1, _alpha)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _sprite.Modulate = new Color(1, 1, 1, _alpha)`
- `NationalSpire.DateCastRoster.Observe(NationalSpire.DateSceneLine, string)`；输入表达式：`_castRoster.Observe(line, next)`；返回值紧邻使用处：`ExpressionStatementSyntax: _castRoster.Observe(line, next);`
- `NationalSpire.DateSceneView.RestoreVisibleCast(System.Collections.Generic.IEnumerable<string>)`；输入表达式：`RestoreVisibleCast(_castRoster.Visible)`；返回值紧邻使用处：`ExpressionStatementSyntax: RestoreVisibleCast(_castRoster.Visible);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_castSprites.TryGetValue(_speaker, out var previous)`；返回值紧邻使用处：`IfStatementSyntax: if (_castSprites.TryGetValue(_speaker, out var previous)) { previous.Texture = _sprite.Texture; previous.Modulate = _sprite.Modulate; }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_castSprites.TryGetValue(next, out var current)`；返回值紧邻使用处：`IfStatementSyntax: if (_castSprites.TryGetValue(next, out var current)) { current.Texture = texture; current.Hide(); }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_castSprites.TryGetValue(next, out var incoming)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _castSprites.TryGetValue(next, out var incoming) ? incoming.Modulate.A : 0`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`_cast.Any(c => c.PersonId == line.Speaker)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _cast.Any(c => c.PersonId == line.Speaker) ? line.Speaker : _cast[0].PersonId`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`_cast.First(c => c.PersonId == next)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _cast.First(c => c.PersonId == next).Default`

**赋值（含属性/字段和局部值）：**

- `WaitingDefault` = `_cast.First(c => c.PersonId == next).Default`
- `_alpha` = `_castSprites.TryGetValue(next, out var incoming) ? incoming.Modulate.A : 0`
- `_castNarration` = `line.Narration`
- `_positionAnchor` = `_cast.First(c => c.PersonId == next).Default`
- `_speaker` = `next`
- `_sprite.Modulate` = `new Color(1, 1, 1, _alpha)`
- `current.Texture` = `texture`
- `previous.Modulate` = `_sprite.Modulate`
- `previous.Texture` = `_sprite.Texture`

<a id="symbol-0a6a432034a8"></a>

## `NationalSpire.DateSceneView.LayoutCast() — private void LayoutCast()`

来源：源码第 135 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView.Layout()`](DateSceneView.cs.md#symbol-80b96be1ed4b)

**调用：** [`NationalSpire.DateSceneView.PortraitPosition(string, int, Godot.Vector2, Godot.Texture2D?)`](DateSceneCast.cs.md#symbol-660b122db429)；[`NationalSpire.DateSceneView.PortraitSize(string)`](DateSceneCast.cs.md#symbol-09f2107801c6)；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.IndexOf(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneCast.Default`；`NationalSpire.DateSceneCast.PersonId`；`NationalSpire.DateSceneView.PortraitPosition(string, int, Godot.Vector2, Godot.Texture2D?)`；`NationalSpire.DateSceneView.PortraitSize(string)`；`NationalSpire.DateSceneView._cast`；`NationalSpire.DateSceneView._castSprites`；`NationalSpire.DateSceneView._speaker`；`NationalSpire.DateSceneView._visibleCast`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneView.PortraitPosition(string, int, Godot.Vector2, Godot.Texture2D?)`；输入表达式：`PortraitPosition(id, slot, node.Size, member.Default)`；返回值紧邻使用处：`AssignmentExpressionSyntax: node.Position = PortraitPosition(id, slot, node.Size, member.Default)`
- `NationalSpire.DateSceneView.PortraitSize(string)`；输入表达式：`PortraitSize(id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: node.Size = PortraitSize(id)`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`_cast.First(c => c.PersonId == id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _cast.First(c => c.PersonId == id)`
- `System.Collections.Generic.List<T>.IndexOf(T)`；输入表达式：`_visibleCast.IndexOf(member.PersonId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _visibleCast.IndexOf(member.PersonId)`

**赋值（含属性/字段和局部值）：**

- `node.Position` = `PortraitPosition(id, slot, node.Size, member.Default)`
- `node.Size` = `PortraitSize(id)`
- `node.Visible` = `slot >= 0 && member.PersonId != _speaker`

<a id="symbol-9093d3132f05"></a>

## `NationalSpire.DateSceneView.TickCast(double) — private void TickCast(double delta)`

来源：源码第 146 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView._Process(double)`](DateSceneView.cs.md#symbol-e901780018ca)

**调用：** `Godot.Color.Color(float, float, float, float)`；`Godot.Mathf.MoveToward(float, float, float)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView._castNarration`；`NationalSpire.DateSceneView._castSprites`；`NationalSpire.DateSceneView._speaker`；`NationalSpire.DateSceneView._visibleCast`；`NationalSpire.DateSceneView._waiting`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(1, 1, 1, Mathf.MoveToward(node.Modulate.A, target, (float)delta * 4))`；返回值紧邻使用处：`AssignmentExpressionSyntax: node.Modulate = new Color(1, 1, 1, Mathf.MoveToward(node.Modulate.A, target, (float)delta * 4))`
- `Godot.Mathf.MoveToward(float, float, float)`；输入表达式：`Mathf.MoveToward(node.Modulate.A, target, (float)delta * 4)`；返回值紧邻使用处：`ArgumentSyntax: Mathf.MoveToward(node.Modulate.A, target, (float)delta * 4)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`_visibleCast.Contains(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: _visibleCast.Contains(id) && id != _speaker`

**赋值（含属性/字段和局部值）：**

- `node.Modulate` = `new Color(1, 1, 1, Mathf.MoveToward(node.Modulate.A, target, (float)delta * 4))`
- `node.Visible` = `_visibleCast.Contains(id) && id != _speaker`

<a id="symbol-97b88ee931cf"></a>

## `NationalSpire.DateSceneView.AddSceneAction(string, string, System.Action) — public Button AddSceneAction(string text, string name, Action action)`

来源：源码第 155 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView.MemoryControls(System.Action, System.Action)`](DateSceneMemoryPlayback.cs.md#symbol-714c8ce810da)

**调用：** `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`；[`NationalSpire.DateSceneView.ActionButton(string, System.Action, string, int)`](DateSceneView.cs.md#symbol-1ed75a76342e)

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView.ActionButton(string, System.Action, string, int)`；`NationalSpire.DateSceneView._settings`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride(state, new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride(state, new StyleBoxEmpty());`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_settings.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: _settings.AddChild(button);`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty()`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxEmpty()`
- `NationalSpire.DateSceneView.ActionButton(string, System.Action, string, int)`；输入表达式：`ActionButton(text, action, name, 150)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ActionButton(text, action, name, 150)`

**赋值（含属性/字段和局部值）：**
