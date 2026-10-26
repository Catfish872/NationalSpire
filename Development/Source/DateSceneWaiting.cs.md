# DateSceneWaiting.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`FA514CBA55475A296543D012441E28BABED1A0EE656516D3B78BBE9604DB8BFF`。来源：[源码](../../DateSceneWaiting.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.DateSceneView`、`NationalSpire.DateSceneView.WaitingActor`。

字段、事件及初始值（源码原样）：

```csharp
public readonly string Id = id;
public readonly TextureRect Sprite = sprite;
public readonly Texture2D? Anchor = sprite.Texture;
public Vector2 Base;
public IReadOnlyList<Texture2D>? Sprites;
public readonly Queue<double> Clicks = new();
public double ShiftAt = -2;
public float Shift, ShiftFrom, ShiftTarget, ShiftElapsed = 1, Jump, Duration, Height;
public bool Twice;
private bool _waiting;
private Texture2D? _positionAnchor;
private double _waitingClock, _waitingBounceAt;
private readonly List<WaitingActor> _waitingActors = [];
private readonly List<(PanelContainer Panel, double Born, WaitingActor Actor)> _waitingBubbles = [];
private readonly Dictionary<ulong, Rect2> _spriteBounds = [];
private static readonly string[] WaitingPhrases = ["哈哈哈！", "痒死了！", "别戳了~~~", "呜呜呜……", "嘿嘿～", "嗯？", "哎呀！", "抓到你啦！", "唔……", "又来啦？"];
```

<a id="symbol-0692d61c2543"></a>

## `NationalSpire.DateSceneView.WaitingPortraits — public Func<string, IReadOnlyList<Texture2D>>? WaitingPortraits`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-dc990eee2aab"></a>

## `NationalSpire.DateSceneView.WaitingSprites — public IReadOnlyList<Texture2D> WaitingSprites`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ee4c44a29e32"></a>

## `NationalSpire.DateSceneView.WaitingDefault — public Texture2D? WaitingDefault`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-289036db5043"></a>

## `NationalSpire.DateSceneView.BeginWaiting() — private void BeginWaiting()`

来源：源码第 31 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView.SetCast(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneCast>)`](DateSceneCast.cs.md#symbol-913514fd78e1)；[`NationalSpire.DateSceneView.ShowWaiting(string, bool)`](DateSceneView.cs.md#symbol-c6c25a66fde3)

**调用：** [`NationalSpire.DateSceneView.Layout()`](DateSceneView.cs.md#symbol-80b96be1ed4b)；`NationalSpire.DateSceneView.WaitingActor.WaitingActor(string, Godot.TextureRect)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView.Layout()`；`NationalSpire.DateSceneView.WaitingDefault`；`NationalSpire.DateSceneView._castConfigured`；`NationalSpire.DateSceneView._castSprites`；`NationalSpire.DateSceneView._jump`；`NationalSpire.DateSceneView._speaker`；`NationalSpire.DateSceneView._sprite`；`NationalSpire.DateSceneView._targetAlpha`；`NationalSpire.DateSceneView._visibleCast`；`NationalSpire.DateSceneView._waiting`；`NationalSpire.DateSceneView._waitingActors`；`NationalSpire.DateSceneView._waitingBounceAt`；`NationalSpire.DateSceneView._waitingClock`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneView.Layout()`；输入表达式：`Layout()`；返回值紧邻使用处：`ExpressionStatementSyntax: Layout();`
- `NationalSpire.DateSceneView.WaitingActor.WaitingActor(string, Godot.TextureRect)`；输入表达式：`new("", _sprite)`；返回值紧邻使用处：`ArgumentSyntax: new("", _sprite)`
- `NationalSpire.DateSceneView.WaitingActor.WaitingActor(string, Godot.TextureRect)`；输入表达式：`new(id, id == _speaker ? _sprite : _castSprites[id])`；返回值紧邻使用处：`ArgumentSyntax: new(id, id == _speaker ? _sprite : _castSprites[id])`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`_waitingActors.Add(new("", _sprite))`；返回值紧邻使用处：`ExpressionStatementSyntax: _waitingActors.Add(new("", _sprite));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`_waitingActors.Add(new(id, id == _speaker ? _sprite : _castSprites[id]))`；返回值紧邻使用处：`ExpressionStatementSyntax: _waitingActors.Add(new(id, id == _speaker ? _sprite : _castSprites[id]));`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`_visibleCast.Contains(_speaker)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_visibleCast.Contains(_speaker)`

**赋值（含属性/字段和局部值）：**

- `_jump` = `0`
- `_sprite.Texture` ??= `WaitingDefault`
- `_targetAlpha` = `_sprite.Texture == null || _castConfigured && !_visibleCast.Contains(_speaker) ? 0 : 1`
- `_waitingBounceAt` = `5`
- `_waitingClock` = `0`
- `_waiting` = `true`

<a id="symbol-03e797c35180"></a>

## `NationalSpire.DateSceneView.EndWaiting() — private void EndWaiting()`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView.SetCast(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneCast>)`](DateSceneCast.cs.md#symbol-913514fd78e1)；[`NationalSpire.DateSceneView.ShowInput(string, bool, bool)`](DateSceneView.cs.md#symbol-4f0d075ed97b)；[`NationalSpire.DateSceneView.ShowLineCore(NationalSpire.DateSceneLine, string, Godot.Texture2D, bool)`](DateSceneView.cs.md#symbol-d19549d8d807)；[`NationalSpire.DateSceneView.ShowRoundLine(System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, string, Godot.Texture2D)`](DateSceneCast.cs.md#symbol-35177f2945fc)

**调用：** `Godot.CanvasItem.Hide()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Node.QueueFree()`；[`NationalSpire.DateSceneView.Layout()`](DateSceneView.cs.md#symbol-80b96be1ed4b)；`System.Collections.Generic.List<T>.Clear()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView.Layout()`；`NationalSpire.DateSceneView.WaitingActor.Anchor`；`NationalSpire.DateSceneView.WaitingActor.Sprite`；`NationalSpire.DateSceneView._jump`；`NationalSpire.DateSceneView._waiting`；`NationalSpire.DateSceneView._waitingActors`；`NationalSpire.DateSceneView._waitingBubbles`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`bubble.Panel.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: bubble.Panel.Hide();`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(actor.Sprite)`；返回值紧邻使用处：`IfStatementSyntax: if (IsInstanceValid(actor.Sprite)) actor.Sprite.Texture = actor.Anchor;`
- `Godot.Node.QueueFree()`；输入表达式：`bubble.Panel.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: bubble.Panel.QueueFree();`
- `NationalSpire.DateSceneView.Layout()`；输入表达式：`Layout()`；返回值紧邻使用处：`ExpressionStatementSyntax: Layout();`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`_waitingActors.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _waitingActors.Clear();`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`_waitingBubbles.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _waitingBubbles.Clear();`

**赋值（含属性/字段和局部值）：**

- `_jump` = `0`
- `_waiting` = `false`
- `actor.Sprite.Texture` = `actor.Anchor`

<a id="symbol-cacdc3bf25d3"></a>

## `NationalSpire.DateSceneView.LayoutWaiting() — private void LayoutWaiting()`

来源：源码第 48 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView.Layout()`](DateSceneView.cs.md#symbol-80b96be1ed4b)

**调用：** [`NationalSpire.DateSceneView.PositionWaiting(NationalSpire.DateSceneView.WaitingActor)`](DateSceneWaiting.cs.md#symbol-6e879326d9fb)

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView.PositionWaiting(NationalSpire.DateSceneView.WaitingActor)`；`NationalSpire.DateSceneView.WaitingActor.Base`；`NationalSpire.DateSceneView.WaitingActor.Sprite`；`NationalSpire.DateSceneView._waitingActors`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneView.PositionWaiting(NationalSpire.DateSceneView.WaitingActor)`；输入表达式：`PositionWaiting(actor)`；返回值紧邻使用处：`ExpressionStatementSyntax: PositionWaiting(actor);`

**赋值（含属性/字段和局部值）：**

- `actor.Base` = `actor.Sprite.Position`

<a id="symbol-6e879326d9fb"></a>

## `NationalSpire.DateSceneView.PositionWaiting(NationalSpire.DateSceneView.WaitingActor) — private static void PositionWaiting(WaitingActor actor)`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView.LayoutWaiting()`](DateSceneWaiting.cs.md#symbol-cacdc3bf25d3)；[`NationalSpire.DateSceneView.TickWaiting(double)`](DateSceneWaiting.cs.md#symbol-bb1239eb8331)

**调用：** `Godot.Vector2.Vector2(float, float)`；`System.MathF.Abs(float)`；`System.MathF.Sin(float)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView.WaitingActor.Base`；`NationalSpire.DateSceneView.WaitingActor.Duration`；`NationalSpire.DateSceneView.WaitingActor.Height`；`NationalSpire.DateSceneView.WaitingActor.Jump`；`NationalSpire.DateSceneView.WaitingActor.Shift`；`NationalSpire.DateSceneView.WaitingActor.Sprite`；`NationalSpire.DateSceneView.WaitingActor.Twice`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(actor.Shift, -bounce)`；返回值紧邻使用处：`BinaryExpressionSyntax: actor.Base + new Vector2(actor.Shift, -bounce)`
- `System.MathF.Abs(float)`；输入表达式：`MathF.Abs(MathF.Sin(phase * MathF.PI * (actor.Twice ? 2 : 1)))`；返回值紧邻使用处：`BinaryExpressionSyntax: MathF.Abs(MathF.Sin(phase * MathF.PI * (actor.Twice ? 2 : 1))) * actor.Height`
- `System.MathF.Sin(float)`；输入表达式：`MathF.Sin(phase * MathF.PI * (actor.Twice ? 2 : 1))`；返回值紧邻使用处：`ArgumentSyntax: MathF.Sin(phase * MathF.PI * (actor.Twice ? 2 : 1))`

**赋值（含属性/字段和局部值）：**

- `actor.Sprite.Position` = `actor.Base + new Vector2(actor.Shift, -bounce)`

<a id="symbol-9b17a8ece561"></a>

## `NationalSpire.DateSceneView.RememberSprite(Godot.Texture2D) — private void RememberSprite(Texture2D texture)`

来源：源码第 58 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView.AddCastSprite(NationalSpire.DateSceneCast)`](DateSceneCast.cs.md#symbol-2b81e5e41a28)；[`NationalSpire.DateSceneView.PortraitPosition(string, int, Godot.Vector2, Godot.Texture2D?)`](DateSceneCast.cs.md#symbol-660b122db429)；[`NationalSpire.DateSceneView.ShowLineCore(NationalSpire.DateSceneLine, string, Godot.Texture2D, bool)`](DateSceneView.cs.md#symbol-d19549d8d807)；[`NationalSpire.DateSceneView.WaitingSpriteBounds(Godot.TextureRect)`](DateSceneWaiting.cs.md#symbol-6d50be6d43f5)

**调用：** `Godot.GodotObject.GetInstanceId()`；`Godot.Image.GetSize()`；`Godot.Image.GetUsedRect()`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.Rect2I.HasArea()`；`Godot.Rect2I.Rect2I(Godot.Vector2I, Godot.Vector2I)`；`Godot.Texture2D.GetImage()`；`Godot.Texture2D.GetSize()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView._headRatios`；`NationalSpire.DateSceneView._spriteBounds`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.GetInstanceId()`；输入表达式：`texture.GetInstanceId()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = texture.GetInstanceId()`
- `Godot.Image.GetSize()`；输入表达式：`image.GetSize()`；返回值紧邻使用处：`ArgumentSyntax: image.GetSize()`
- `Godot.Image.GetUsedRect()`；输入表达式：`image.GetUsedRect()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = image.GetUsedRect()`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2((Vector2)used.Position / dimensions, (Vector2)used.Size / dimensions)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _spriteBounds[id] = new Rect2((Vector2)used.Position / dimensions, (Vector2)used.Size / dimensions)`
- `Godot.Rect2I.HasArea()`；输入表达式：`used.HasArea()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !used.HasArea()`
- `Godot.Rect2I.Rect2I(Godot.Vector2I, Godot.Vector2I)`；输入表达式：`new Rect2I(Vector2I.Zero, image.GetSize())`；返回值紧邻使用处：`AssignmentExpressionSyntax: used = new Rect2I(Vector2I.Zero, image.GetSize())`
- `Godot.Texture2D.GetImage()`；输入表达式：`texture.GetImage()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = texture.GetImage()`
- `Godot.Texture2D.GetSize()`；输入表达式：`texture.GetSize()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = texture.GetSize()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`_spriteBounds.ContainsKey(id)`；返回值紧邻使用处：`IfStatementSyntax: if (_spriteBounds.ContainsKey(id)) return;`

**赋值（含属性/字段和局部值）：**

- `_headRatios[id]` = `used.Position.Y / dimensions.Y`
- `_spriteBounds[id]` = `new Rect2((Vector2)used.Position / dimensions, (Vector2)used.Size / dimensions)`
- `used` = `new Rect2I(Vector2I.Zero, image.GetSize())`

<a id="symbol-6d50be6d43f5"></a>

## `NationalSpire.DateSceneView.WaitingSpriteBounds(Godot.TextureRect) — private Rect2 WaitingSpriteBounds(TextureRect sprite)`

来源：源码第 66 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView.TickWaiting(double)`](DateSceneWaiting.cs.md#symbol-bb1239eb8331)；[`NationalSpire.DateSceneView.WaitingBubble(NationalSpire.DateSceneView.WaitingActor)`](DateSceneWaiting.cs.md#symbol-865fad94731c)；[`NationalSpire.DateSceneView.WaitingClick(Godot.Vector2)`](DateSceneWaiting.cs.md#symbol-883b2e576cb3)

**调用：** `Godot.GodotObject.GetInstanceId()`；`Godot.Rect2.Rect2()`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.Texture2D.GetSize()`；[`NationalSpire.DateSceneView.RememberSprite(Godot.Texture2D)`](DateSceneWaiting.cs.md#symbol-9b17a8ece561)；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView.RememberSprite(Godot.Texture2D)`；`NationalSpire.DateSceneView._spriteBounds`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.GetInstanceId()`；输入表达式：`sprite.Texture.GetInstanceId()`；返回值紧邻使用处：`ArgumentSyntax: sprite.Texture.GetInstanceId()`
- `Godot.Rect2.Rect2()`；输入表达式：`new()`；返回值紧邻使用处：`ReturnStatementSyntax: return new();`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(sprite.Position + (sprite.Size - drawn) / 2 + used.Position * drawn, used.Size * drawn)`；返回值紧邻使用处：`ReturnStatementSyntax: return new Rect2(sprite.Position + (sprite.Size - drawn) / 2 + used.Position * drawn, used.Size * drawn);`
- `Godot.Texture2D.GetSize()`；输入表达式：`sprite.Texture.GetSize()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = sprite.Texture.GetSize()`
- `NationalSpire.DateSceneView.RememberSprite(Godot.Texture2D)`；输入表达式：`RememberSprite(sprite.Texture)`；返回值紧邻使用处：`ExpressionStatementSyntax: RememberSprite(sprite.Texture);`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(sprite.Size.X / dimensions.X, sprite.Size.Y / dimensions.Y)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(sprite.Size.X / dimensions.X, sprite.Size.Y / dimensions.Y)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9b344f530581"></a>

## `NationalSpire.DateSceneView.WaitingBlocked(Godot.Rect2) — private bool WaitingBlocked(Rect2 bounds)`

来源：源码第 74 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView.TickWaiting(double)`](DateSceneWaiting.cs.md#symbol-bb1239eb8331)；[`NationalSpire.DateSceneView.WaitingBubble(NationalSpire.DateSceneView.WaitingActor)`](DateSceneWaiting.cs.md#symbol-865fad94731c)；[`NationalSpire.DateSceneView.WaitingClick(Godot.Vector2)`](DateSceneWaiting.cs.md#symbol-883b2e576cb3)

**调用：** `Godot.Control.GetRect()`；`Godot.Rect2.Intersects(Godot.Rect2, bool)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView.DialogueHidden`；`NationalSpire.DateSceneView._dialog`；`NationalSpire.DateSceneView._favourHost`；`NationalSpire.DateSceneView._gameChoices`；`NationalSpire.DateSceneView._nameBox`；`NationalSpire.DateSceneView._navigation`；`NationalSpire.DateSceneView._replyChoices`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.GetRect()`；输入表达式：`_dialog.GetRect()`；返回值紧邻使用处：`ArgumentSyntax: _dialog.GetRect()`
- `Godot.Control.GetRect()`；输入表达式：`_favourHost.GetRect()`；返回值紧邻使用处：`ArgumentSyntax: _favourHost.GetRect()`
- `Godot.Control.GetRect()`；输入表达式：`_gameChoices.GetRect()`；返回值紧邻使用处：`ArgumentSyntax: _gameChoices.GetRect()`
- `Godot.Control.GetRect()`；输入表达式：`_nameBox.GetRect()`；返回值紧邻使用处：`ArgumentSyntax: _nameBox.GetRect()`
- `Godot.Control.GetRect()`；输入表达式：`_navigation.GetRect()`；返回值紧邻使用处：`ArgumentSyntax: _navigation.GetRect()`
- `Godot.Control.GetRect()`；输入表达式：`_replyChoices.GetRect()`；返回值紧邻使用处：`ArgumentSyntax: _replyChoices.GetRect()`
- `Godot.Rect2.Intersects(Godot.Rect2, bool)`；输入表达式：`bounds.Intersects(_dialog.GetRect())`；返回值紧邻使用处：`BinaryExpressionSyntax: bounds.Intersects(_dialog.GetRect()) || _nameBox.Visible && bounds.Intersects(_nameBox.GetRect())`
- `Godot.Rect2.Intersects(Godot.Rect2, bool)`；输入表达式：`bounds.Intersects(_favourHost.GetRect())`；返回值紧邻使用处：`BinaryExpressionSyntax: _favourHost.Visible && bounds.Intersects(_favourHost.GetRect())`
- `Godot.Rect2.Intersects(Godot.Rect2, bool)`；输入表达式：`bounds.Intersects(_gameChoices.GetRect())`；返回值紧邻使用处：`BinaryExpressionSyntax: _gameChoices.Visible && bounds.Intersects(_gameChoices.GetRect())`
- `Godot.Rect2.Intersects(Godot.Rect2, bool)`；输入表达式：`bounds.Intersects(_nameBox.GetRect())`；返回值紧邻使用处：`BinaryExpressionSyntax: _nameBox.Visible && bounds.Intersects(_nameBox.GetRect())`
- `Godot.Rect2.Intersects(Godot.Rect2, bool)`；输入表达式：`bounds.Intersects(_navigation.GetRect())`；返回值紧邻使用处：`BinaryExpressionSyntax: bounds.Intersects(_dialog.GetRect()) || _nameBox.Visible && bounds.Intersects(_nameBox.GetRect()) || _favourHost.Visible && bounds.Intersects(_favourHost.GetRect()) || bounds.Intersects(_navigation.GetRect())`
- `Godot.Rect2.Intersects(Godot.Rect2, bool)`；输入表达式：`bounds.Intersects(_replyChoices.GetRect())`；返回值紧邻使用处：`BinaryExpressionSyntax: _replyChoices.Visible && bounds.Intersects(_replyChoices.GetRect())`

**赋值（含属性/字段和局部值）：**


<a id="symbol-883b2e576cb3"></a>

## `NationalSpire.DateSceneView.WaitingClick(Godot.Vector2) — private bool WaitingClick(Vector2 position)`

来源：源码第 80 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView._Input(Godot.InputEvent)`](DateSceneView.cs.md#symbol-557ca90aab66)

**调用：** `Godot.Node.GetIndex(bool)`；`Godot.Rect2.HasPoint(Godot.Vector2)`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；[`NationalSpire.DateSceneView.WaitingBlocked(Godot.Rect2)`](DateSceneWaiting.cs.md#symbol-9b344f530581)；[`NationalSpire.DateSceneView.WaitingBounce(NationalSpire.DateSceneView.WaitingActor, bool, bool)`](DateSceneWaiting.cs.md#symbol-22eaff430386)；[`NationalSpire.DateSceneView.WaitingBubble(NationalSpire.DateSceneView.WaitingActor)`](DateSceneWaiting.cs.md#symbol-865fad94731c)；[`NationalSpire.DateSceneView.WaitingSpriteBounds(Godot.TextureRect)`](DateSceneWaiting.cs.md#symbol-6d50be6d43f5)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.Queue<T>.Clear()`；`System.Collections.Generic.Queue<T>.Dequeue()`；`System.Collections.Generic.Queue<T>.Enqueue(T)`；`System.Collections.Generic.Queue<T>.Peek()`；`System.Func<T, TResult>.Invoke(T)`；`System.Math.Abs(float)`；`System.Random.Next(int)`；`System.Random.Next(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView.HistoryOpen`；`NationalSpire.DateSceneView.WaitingActor.Clicks`；`NationalSpire.DateSceneView.WaitingActor.Id`；`NationalSpire.DateSceneView.WaitingActor.Shift`；`NationalSpire.DateSceneView.WaitingActor.ShiftAt`；`NationalSpire.DateSceneView.WaitingActor.ShiftElapsed`；`NationalSpire.DateSceneView.WaitingActor.ShiftFrom`；`NationalSpire.DateSceneView.WaitingActor.ShiftTarget`；`NationalSpire.DateSceneView.WaitingActor.Sprite`；`NationalSpire.DateSceneView.WaitingActor.Sprites`；`NationalSpire.DateSceneView.WaitingBlocked(Godot.Rect2)`；`NationalSpire.DateSceneView.WaitingBounce(NationalSpire.DateSceneView.WaitingActor, bool, bool)`；`NationalSpire.DateSceneView.WaitingBubble(NationalSpire.DateSceneView.WaitingActor)`；`NationalSpire.DateSceneView.WaitingPortraits`；`NationalSpire.DateSceneView.WaitingSpriteBounds(Godot.TextureRect)`；`NationalSpire.DateSceneView.WaitingSprites`；`NationalSpire.DateSceneView._waiting`；`NationalSpire.DateSceneView._waitingActors`；`NationalSpire.DateSceneView._waitingClock`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.GetIndex(bool)`；输入表达式：`a.Sprite.GetIndex()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: a => a.Sprite.GetIndex()`
- `Godot.Rect2.HasPoint(Godot.Vector2)`；输入表达式：`WaitingSpriteBounds(a.Sprite).HasPoint(position)`；返回值紧邻使用处：`BinaryExpressionSyntax: a.Sprite.Visible && a.Sprite.Texture != null && WaitingSpriteBounds(a.Sprite).HasPoint(position)`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(position, Vector2.One)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(position, Vector2.One)`
- `NationalSpire.DateSceneView.WaitingBlocked(Godot.Rect2)`；输入表达式：`WaitingBlocked(new Rect2(position, Vector2.One))`；返回值紧邻使用处：`BinaryExpressionSyntax: !_waiting || HistoryOpen || WaitingBlocked(new Rect2(position, Vector2.One))`
- `NationalSpire.DateSceneView.WaitingBounce(NationalSpire.DateSceneView.WaitingActor, bool, bool)`；输入表达式：`WaitingBounce(actor, true, false)`；返回值紧邻使用处：`ExpressionStatementSyntax: WaitingBounce(actor, true, false);`
- `NationalSpire.DateSceneView.WaitingBubble(NationalSpire.DateSceneView.WaitingActor)`；输入表达式：`WaitingBubble(actor)`；返回值紧邻使用处：`ExpressionStatementSyntax: WaitingBubble(actor);`
- `NationalSpire.DateSceneView.WaitingSpriteBounds(Godot.TextureRect)`；输入表达式：`WaitingSpriteBounds(a.Sprite)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: WaitingSpriteBounds(a.Sprite).HasPoint`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`_waitingActors.Where(a => a.Sprite.Visible && a.Sprite.Texture != null && WaitingSpriteBounds(a.Sprite).HasPoint(position)) .OrderByDescending(a => a.Sprite.GetIndex()).FirstOrDefault()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _waitingActors.Where(a => a.Sprite.Visible && a.Sprite.Texture != null && WaitingSpriteBounds(a.Sprite).HasPoint(position)) .OrderByDescending(a => a.Sprite.GetIndex()).FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`_waitingActors.Where(a => a.Sprite.Visible && a.Sprite.Texture != null && WaitingSpriteBounds(a.Sprite).HasPoint(position)) .OrderByDescending(a => a.Sprite.GetIndex())`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _waitingActors.Where(a => a.Sprite.Visible && a.Sprite.Texture != null && WaitingSpriteBounds(a.Sprite).HasPoint(position)) .OrderByDescending(a => a.Sprite.GetIndex()).FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`_waitingActors.Where(a => a.Sprite.Visible && a.Sprite.Texture != null && WaitingSpriteBounds(a.Sprite).HasPoint(position))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _waitingActors.Where(a => a.Sprite.Visible && a.Sprite.Texture != null && WaitingSpriteBounds(a.Sprite).HasPoint(position)) .OrderByDescending`
- `System.Collections.Generic.Queue<T>.Clear()`；输入表达式：`actor.Clicks.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: actor.Clicks.Clear();`
- `System.Collections.Generic.Queue<T>.Dequeue()`；输入表达式：`actor.Clicks.Dequeue()`；返回值紧邻使用处：`ExpressionStatementSyntax: actor.Clicks.Dequeue();`
- `System.Collections.Generic.Queue<T>.Enqueue(T)`；输入表达式：`actor.Clicks.Enqueue(_waitingClock)`；返回值紧邻使用处：`ExpressionStatementSyntax: actor.Clicks.Enqueue(_waitingClock);`
- `System.Collections.Generic.Queue<T>.Peek()`；输入表达式：`actor.Clicks.Peek()`；返回值紧邻使用处：`BinaryExpressionSyntax: _waitingClock - actor.Clicks.Peek()`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`.Invoke(actor.Id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: WaitingPortraits?.Invoke(actor.Id)`
- `System.Math.Abs(float)`；输入表达式：`Math.Abs(actor.Shift + direction * distance)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Abs(actor.Shift + direction * distance) > 120`
- `System.Random.Next(int)`；输入表达式：`Random.Shared.Next(2)`；返回值紧邻使用处：`BinaryExpressionSyntax: Random.Shared.Next(2) == 0`
- `System.Random.Next(int)`；输入表达式：`Random.Shared.Next(actor.Sprites.Count)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Random.Shared.Next(actor.Sprites.Count)`
- `System.Random.Next(int, int)`；输入表达式：`Random.Shared.Next(50, 121)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Random.Shared.Next(50, 121)`

**赋值（含属性/字段和局部值）：**

- `actor.ShiftAt` = `_waitingClock`
- `actor.ShiftElapsed` = `0`
- `actor.ShiftFrom` = `actor.Shift`
- `actor.ShiftTarget` = `actor.Shift + direction * distance`
- `actor.Sprite.Texture` = `actor.Sprites[index]`
- `actor.Sprites` ??= `WaitingPortraits?.Invoke(actor.Id) ?? WaitingSprites`
- `direction` = `-direction`
- `index` = `(index + 1) % actor.Sprites.Count`

<a id="symbol-22eaff430386"></a>

## `NationalSpire.DateSceneView.WaitingBounce(NationalSpire.DateSceneView.WaitingActor, bool, bool) — private static void WaitingBounce(WaitingActor actor, bool strong, bool twice)`

来源：源码第 111 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView.TickWaiting(double)`](DateSceneWaiting.cs.md#symbol-bb1239eb8331)；[`NationalSpire.DateSceneView.WaitingClick(Godot.Vector2)`](DateSceneWaiting.cs.md#symbol-883b2e576cb3)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView.WaitingActor.Duration`；`NationalSpire.DateSceneView.WaitingActor.Height`；`NationalSpire.DateSceneView.WaitingActor.Jump`；`NationalSpire.DateSceneView.WaitingActor.Twice`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `actor.Duration` = `twice ? .56f : .36f`
- `actor.Height` = `strong ? 18 : 9`
- `actor.Jump` = `actor.Duration`
- `actor.Twice` = `twice`

<a id="symbol-bb1239eb8331"></a>

## `NationalSpire.DateSceneView.TickWaiting(double) — private void TickWaiting(double delta)`

来源：源码第 115 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView._Process(double)`](DateSceneView.cs.md#symbol-e901780018ca)

**调用：** `Godot.CanvasItem.Hide()`；`Godot.Color.Color(float, float, float, float)`；`Godot.Control.GetRect()`；`Godot.Mathf.Lerp(float, float, float)`；`Godot.Node.QueueFree()`；`Godot.Rect2.GetCenter()`；[`NationalSpire.DateSceneView.PositionWaiting(NationalSpire.DateSceneView.WaitingActor)`](DateSceneWaiting.cs.md#symbol-6e879326d9fb)；[`NationalSpire.DateSceneView.WaitingBlocked(Godot.Rect2)`](DateSceneWaiting.cs.md#symbol-9b344f530581)；[`NationalSpire.DateSceneView.WaitingBounce(NationalSpire.DateSceneView.WaitingActor, bool, bool)`](DateSceneWaiting.cs.md#symbol-22eaff430386)；[`NationalSpire.DateSceneView.WaitingSpriteBounds(Godot.TextureRect)`](DateSceneWaiting.cs.md#symbol-6d50be6d43f5)；`System.Collections.Generic.List<T>.RemoveAt(int)`；`System.Math.Abs(float)`；`System.Math.Clamp(double, double, double)`；`System.Math.Max(float, float)`；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView.PositionWaiting(NationalSpire.DateSceneView.WaitingActor)`；`NationalSpire.DateSceneView.WaitingActor.Jump`；`NationalSpire.DateSceneView.WaitingActor.Shift`；`NationalSpire.DateSceneView.WaitingActor.ShiftElapsed`；`NationalSpire.DateSceneView.WaitingActor.ShiftFrom`；`NationalSpire.DateSceneView.WaitingActor.ShiftTarget`；`NationalSpire.DateSceneView.WaitingActor.Sprite`；`NationalSpire.DateSceneView.WaitingBlocked(Godot.Rect2)`；`NationalSpire.DateSceneView.WaitingBounce(NationalSpire.DateSceneView.WaitingActor, bool, bool)`；`NationalSpire.DateSceneView.WaitingSpriteBounds(Godot.TextureRect)`；`NationalSpire.DateSceneView._dialog`；`NationalSpire.DateSceneView._waiting`；`NationalSpire.DateSceneView._waitingActors`；`NationalSpire.DateSceneView._waitingBounceAt`；`NationalSpire.DateSceneView._waitingBubbles`；`NationalSpire.DateSceneView._waitingClock`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`item.Panel.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: item.Panel.Hide();`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(1, 1, 1, (float)Math.Clamp((2.8 - age) / .4, 0, 1))`；返回值紧邻使用处：`AssignmentExpressionSyntax: item.Panel.Modulate = new Color(1, 1, 1, (float)Math.Clamp((2.8 - age) / .4, 0, 1))`
- `Godot.Control.GetRect()`；输入表达式：`item.Panel.GetRect()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = item.Panel.GetRect()`
- `Godot.Mathf.Lerp(float, float, float)`；输入表达式：`Mathf.Lerp(actor.ShiftFrom, actor.ShiftTarget, eased)`；返回值紧邻使用处：`AssignmentExpressionSyntax: actor.Shift = Mathf.Lerp(actor.ShiftFrom, actor.ShiftTarget, eased)`
- `Godot.Node.QueueFree()`；输入表达式：`item.Panel.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: item.Panel.QueueFree();`
- `Godot.Rect2.GetCenter()`；输入表达式：`bounds.GetCenter()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = bounds.GetCenter()`
- `NationalSpire.DateSceneView.PositionWaiting(NationalSpire.DateSceneView.WaitingActor)`；输入表达式：`PositionWaiting(actor)`；返回值紧邻使用处：`ExpressionStatementSyntax: PositionWaiting(actor);`
- `NationalSpire.DateSceneView.WaitingBlocked(Godot.Rect2)`；输入表达式：`WaitingBlocked(bounds)`；返回值紧邻使用处：`BinaryExpressionSyntax: age >= 2.8 || Math.Abs(center.Y - portrait.Position.Y) > 100 || Math.Min(Math.Abs(center.X - portrait.Position.X), Math.Abs(center.X - portrait.End.X)) > 150 || _dialog.Position.Y - center.Y < 50 || WaitingBlocked(bounds)`
- `NationalSpire.DateSceneView.WaitingBounce(NationalSpire.DateSceneView.WaitingActor, bool, bool)`；输入表达式：`WaitingBounce(actor, false, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: WaitingBounce(actor, false, true);`
- `NationalSpire.DateSceneView.WaitingSpriteBounds(Godot.TextureRect)`；输入表达式：`WaitingSpriteBounds(item.Actor.Sprite)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = WaitingSpriteBounds(item.Actor.Sprite)`
- `System.Collections.Generic.List<T>.RemoveAt(int)`；输入表达式：`_waitingBubbles.RemoveAt(i)`；返回值紧邻使用处：`ExpressionStatementSyntax: _waitingBubbles.RemoveAt(i);`
- `System.Math.Abs(float)`；输入表达式：`Math.Abs(center.X - portrait.End.X)`；返回值紧邻使用处：`ArgumentSyntax: Math.Abs(center.X - portrait.End.X)`
- `System.Math.Abs(float)`；输入表达式：`Math.Abs(center.X - portrait.Position.X)`；返回值紧邻使用处：`ArgumentSyntax: Math.Abs(center.X - portrait.Position.X)`
- `System.Math.Abs(float)`；输入表达式：`Math.Abs(center.Y - portrait.Position.Y)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Abs(center.Y - portrait.Position.Y) > 100`
- `System.Math.Clamp(double, double, double)`；输入表达式：`Math.Clamp((2.8 - age) / .4, 0, 1)`；返回值紧邻使用处：`CastExpressionSyntax: (float)Math.Clamp((2.8 - age) / .4, 0, 1)`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(0, actor.Jump - (float)delta)`；返回值紧邻使用处：`AssignmentExpressionSyntax: actor.Jump = Math.Max(0, actor.Jump - (float)delta)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(1, actor.ShiftElapsed + (float)delta / .28f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: actor.ShiftElapsed = Math.Min(1, actor.ShiftElapsed + (float)delta / .28f)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(Math.Abs(center.X - portrait.Position.X), Math.Abs(center.X - portrait.End.X))`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Min(Math.Abs(center.X - portrait.Position.X), Math.Abs(center.X - portrait.End.X)) > 150`

**赋值（含属性/字段和局部值）：**

- `_waitingBounceAt` = `_waitingClock + 5`
- `_waitingClock` += `delta`
- `actor.Jump` = `Math.Max(0, actor.Jump - (float)delta)`
- `actor.ShiftElapsed` = `Math.Min(1, actor.ShiftElapsed + (float)delta / .28f)`
- `actor.Shift` = `Mathf.Lerp(actor.ShiftFrom, actor.ShiftTarget, eased)`
- `item.Panel.Modulate` = `new Color(1, 1, 1, (float)Math.Clamp((2.8 - age) / .4, 0, 1))`

<a id="symbol-865fad94731c"></a>

## `NationalSpire.DateSceneView.WaitingBubble(NationalSpire.DateSceneView.WaitingActor) — private void WaitingBubble(WaitingActor actor)`

来源：源码第 142 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView.WaitingClick(Godot.Vector2)`](DateSceneWaiting.cs.md#symbol-883b2e576cb3)

**调用：** `Godot.CanvasItem.Hide()`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.GetCombinedMinimumSize()`；`Godot.Control.GetThemeFontSize(Godot.StringName, Godot.StringName)`；`Godot.GodotObject.SetMeta(Godot.StringName, Godot.Variant)`；`Godot.Label.Label()`；`Godot.Mathf.Lerp(float, float, float)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.QueueFree()`；`Godot.PanelContainer.PanelContainer()`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.DateSceneView.WaitingBlocked(Godot.Rect2)`](DateSceneWaiting.cs.md#symbol-9b344f530581)；[`NationalSpire.DateSceneView.WaitingSpriteBounds(Godot.TextureRect)`](DateSceneWaiting.cs.md#symbol-6d50be6d43f5)；`System.Collections.Generic.List<T>.Add(T)`；`System.Math.Max(float, float)`；`System.Math.Max(int, int)`；`System.Math.Min(float, float)`；`System.Random.Next(int)`；`System.Random.NextSingle()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.DateSceneView.DialogueHidden`；`NationalSpire.DateSceneView.Ink`；`NationalSpire.DateSceneView.WaitingActor.Id`；`NationalSpire.DateSceneView.WaitingActor.Sprite`；`NationalSpire.DateSceneView.WaitingBlocked(Godot.Rect2)`；`NationalSpire.DateSceneView.WaitingPhrases`；`NationalSpire.DateSceneView.WaitingSpriteBounds(Godot.TextureRect)`；`NationalSpire.DateSceneView._dialog`；`NationalSpire.DateSceneView._interface`；`NationalSpire.DateSceneView._text`；`NationalSpire.DateSceneView._waitingBubbles`；`NationalSpire.DateSceneView._waitingClock`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`bubble.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: bubble.Hide();`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`text.AddThemeColorOverride("font_color", Ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: text.AddThemeColorOverride("font_color", Ink);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`text.AddThemeFontSizeOverride("font_size", Math.Max(1, _text.GetThemeFontSize("normal_font_size") - 3))`；返回值紧邻使用处：`ExpressionStatementSyntax: text.AddThemeFontSizeOverride("font_size", Math.Max(1, _text.GetThemeFontSize("normal_font_size") - 3));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`bubble.AddThemeStyleboxOverride("panel", CareerVisuals.Box("233b4f66", "b6d0da66", 14, 12))`；返回值紧邻使用处：`ExpressionStatementSyntax: bubble.AddThemeStyleboxOverride("panel", CareerVisuals.Box("233b4f66", "b6d0da66", 14, 12));`
- `Godot.Control.GetCombinedMinimumSize()`；输入表达式：`bubble.GetCombinedMinimumSize()`；返回值紧邻使用处：`AssignmentExpressionSyntax: bubble.Size = bubble.GetCombinedMinimumSize()`
- `Godot.Control.GetThemeFontSize(Godot.StringName, Godot.StringName)`；输入表达式：`_text.GetThemeFontSize("normal_font_size")`；返回值紧邻使用处：`BinaryExpressionSyntax: _text.GetThemeFontSize("normal_font_size") - 3`
- `Godot.GodotObject.SetMeta(Godot.StringName, Godot.Variant)`；输入表达式：`bubble.SetMeta("person", actor.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: bubble.SetMeta("person", actor.Id);`
- `Godot.Label.Label()`；输入表达式：`new Label { Text = WaitingPhrases[Random.Shared.Next(WaitingPhrases.Length)], MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Label { Text = WaitingPhrases[Random.Shared.Next(WaitingPhrases.Length)], MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Mathf.Lerp(float, float, float)`；输入表达式：`Mathf.Lerp(left, right, Random.Shared.NextSingle())`；返回值紧邻使用处：`ArgumentSyntax: Mathf.Lerp(left, right, Random.Shared.NextSingle())`
- `Godot.Mathf.Lerp(float, float, float)`；输入表达式：`Mathf.Lerp(low, high, Random.Shared.NextSingle())`；返回值紧邻使用处：`ArgumentSyntax: Mathf.Lerp(low, high, Random.Shared.NextSingle())`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_interface.AddChild(bubble)`；返回值紧邻使用处：`ExpressionStatementSyntax: _interface.AddChild(bubble);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`bubble.AddChild(text)`；返回值紧邻使用处：`ExpressionStatementSyntax: bubble.AddChild(text);`
- `Godot.Node.QueueFree()`；输入表达式：`bubble.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: bubble.QueueFree();`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { Name = "DateWaitingBubble", MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { Name = "DateWaitingBubble", MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(center - half, bubble.Size)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Rect2(center - half, bubble.Size)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(Mathf.Lerp(left, right, Random.Shared.NextSingle()), Mathf.Lerp(low, high, Random.Shared.NextSingle()))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Vector2(Mathf.Lerp(left, right, Random.Shared.NextSingle()), Mathf.Lerp(low, high, Random.Shared.NextSingle()))`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("233b4f66", "b6d0da66", 14, 12)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("233b4f66", "b6d0da66", 14, 12)`
- `NationalSpire.DateSceneView.WaitingBlocked(Godot.Rect2)`；输入表达式：`WaitingBlocked(rect)`；返回值紧邻使用处：`IfStatementSyntax: if (WaitingBlocked(rect)) continue;`
- `NationalSpire.DateSceneView.WaitingSpriteBounds(Godot.TextureRect)`；输入表达式：`WaitingSpriteBounds(actor.Sprite)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = WaitingSpriteBounds(actor.Sprite)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`_waitingBubbles.Add((bubble, _waitingClock, actor))`；返回值紧邻使用处：`ExpressionStatementSyntax: _waitingBubbles.Add((bubble, _waitingClock, actor));`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(half.X + 4, side - 150)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Max(half.X + 4, side - 150)`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(half.Y + 4, portrait.Position.Y - 80)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Max(half.Y + 4, portrait.Position.Y - 80)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1, _text.GetThemeFontSize("normal_font_size") - 3)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(1, _text.GetThemeFontSize("normal_font_size") - 3)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(Size.X - half.X - 4, side + 150)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(Size.X - half.X - 4, side + 150)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(_dialog.Position.Y - 50, _dialog.Position.Y - half.Y - 4)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(_dialog.Position.Y - 50, _dialog.Position.Y - half.Y - 4)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(portrait.Position.Y + 80, Math.Min(_dialog.Position.Y - 50, _dialog.Position.Y - half.Y - 4))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(portrait.Position.Y + 80, Math.Min(_dialog.Position.Y - 50, _dialog.Position.Y - half.Y - 4))`
- `System.Random.Next(int)`；输入表达式：`Random.Shared.Next(2)`；返回值紧邻使用处：`BinaryExpressionSyntax: Random.Shared.Next(2) == 0`
- `System.Random.Next(int)`；输入表达式：`Random.Shared.Next(WaitingPhrases.Length)`；返回值紧邻使用处：`ArgumentSyntax: Random.Shared.Next(WaitingPhrases.Length)`
- `System.Random.NextSingle()`；输入表达式：`Random.Shared.NextSingle()`；返回值紧邻使用处：`ArgumentSyntax: Random.Shared.NextSingle()`

**赋值（含属性/字段和局部值）：**

- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Name` = `"DateWaitingBubble"`
- `Text` = `WaitingPhrases[Random.Shared.Next(WaitingPhrases.Length)]`
- `bubble.Position` = `rect.Position`
- `bubble.Size` = `bubble.GetCombinedMinimumSize()`
- `placed` = `true`
