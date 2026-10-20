# DateSceneWaiting.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`07DECF89C57B10772790910F4433749F3F40A5948D29326B840B77C76D0C957C`。来源：[源码](../../DateSceneWaiting.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.DateSceneView`。

字段、事件及初始值（源码原样）：

```csharp
private bool _waiting, _waitingDoubleBounce;
private Texture2D? _waitingAnchor, _positionAnchor;
private double _waitingClock, _waitingBounceAt, _waitingShiftAt = -2;
private readonly Queue<double> _waitingClicks = new();
private float _waitingShift, _waitingShiftFrom, _waitingShiftTarget, _waitingShiftElapsed = 1;
private readonly List<(PanelContainer Panel, double Born)> _waitingBubbles = [];
private readonly Dictionary<ulong, Rect2> _spriteBounds = [];
private static readonly string[] WaitingPhrases = ["哈哈哈！", "痒死了！", "别戳了~~~", "呜呜呜……", "嘿嘿～", "嗯？", "哎呀！", "抓到你啦！", "唔……", "又来啦？"];
```

<a id="symbol-dc990eee2aab"></a>

## `NationalSpire.DateSceneView.WaitingSprites — public IReadOnlyList<Texture2D> WaitingSprites`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ee4c44a29e32"></a>

## `NationalSpire.DateSceneView.WaitingDefault — public Texture2D? WaitingDefault`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-289036db5043"></a>

## `NationalSpire.DateSceneView.BeginWaiting() — private void BeginWaiting()`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView.ShowWaiting(string, bool)`](DateSceneView.cs.md#symbol-c6c25a66fde3)

**调用：** [`NationalSpire.DateSceneView.Layout()`](DateSceneView.cs.md#symbol-80b96be1ed4b)；[`NationalSpire.DateSceneView.RememberSprite(Godot.Texture2D)`](DateSceneWaiting.cs.md#symbol-9b17a8ece561)；`System.Collections.Generic.Queue<T>.Clear()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView._sprite`；`NationalSpire.DateSceneView._targetAlpha`；`NationalSpire.DateSceneView._waiting`；`NationalSpire.DateSceneView._waitingAnchor`；`NationalSpire.DateSceneView._waitingBounceAt`；`NationalSpire.DateSceneView._waitingClicks`；`NationalSpire.DateSceneView._waitingClock`；`NationalSpire.DateSceneView._waitingShiftAt`；`NationalSpire.DateSceneView.Layout()`；`NationalSpire.DateSceneView.RememberSprite(Godot.Texture2D)`；`NationalSpire.DateSceneView.WaitingDefault`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneView.Layout()`；输入表达式：`Layout()`；返回值紧邻使用处：`ExpressionStatementSyntax: Layout();`
- `NationalSpire.DateSceneView.RememberSprite(Godot.Texture2D)`；输入表达式：`RememberSprite(_waitingAnchor)`；返回值紧邻使用处：`ExpressionStatementSyntax: RememberSprite(_waitingAnchor);`
- `System.Collections.Generic.Queue<T>.Clear()`；输入表达式：`_waitingClicks.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _waitingClicks.Clear();`

**赋值（含属性/字段和局部值）：**

- `_sprite.Texture` = `_waitingAnchor`
- `_targetAlpha` = `_waitingAnchor == null ? 0 : 1`
- `_waiting` = `true`
- `_waitingAnchor` = `_sprite.Texture ?? WaitingDefault`
- `_waitingBounceAt` = `5`
- `_waitingClock` = `0`
- `_waitingShiftAt` = `-2`

<a id="symbol-03e797c35180"></a>

## `NationalSpire.DateSceneView.EndWaiting() — private void EndWaiting()`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView.ShowInput(string, bool)`](DateSceneView.cs.md#symbol-4f0d075ed97b)；[`NationalSpire.DateSceneView.ShowLine(NationalSpire.DateSceneLine, string, Godot.Texture2D)`](DateSceneView.cs.md#symbol-1801b5d93aa1)

**调用：** [`NationalSpire.DateSceneView.Layout()`](DateSceneView.cs.md#symbol-80b96be1ed4b)；`Godot.CanvasItem.Hide()`；`Godot.Node.QueueFree()`；`System.Collections.Generic.List<T>.Clear()`；`System.Collections.Generic.Queue<T>.Clear()`

**字段、属性、事件及方法组引用：** `(Godot.PanelContainer Panel, double Born).Panel`；`NationalSpire.DateSceneView._jump`；`NationalSpire.DateSceneView._sprite`；`NationalSpire.DateSceneView._waiting`；`NationalSpire.DateSceneView._waitingAnchor`；`NationalSpire.DateSceneView._waitingBubbles`；`NationalSpire.DateSceneView._waitingClicks`；`NationalSpire.DateSceneView._waitingDoubleBounce`；`NationalSpire.DateSceneView._waitingShift`；`NationalSpire.DateSceneView._waitingShiftElapsed`；`NationalSpire.DateSceneView._waitingShiftFrom`；`NationalSpire.DateSceneView._waitingShiftTarget`；`NationalSpire.DateSceneView.Layout()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`bubble.Panel.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: bubble.Panel.Hide();`
- `Godot.Node.QueueFree()`；输入表达式：`bubble.Panel.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: bubble.Panel.QueueFree();`
- `NationalSpire.DateSceneView.Layout()`；输入表达式：`Layout()`；返回值紧邻使用处：`ExpressionStatementSyntax: Layout();`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`_waitingBubbles.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _waitingBubbles.Clear();`
- `System.Collections.Generic.Queue<T>.Clear()`；输入表达式：`_waitingClicks.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _waitingClicks.Clear();`

**赋值（含属性/字段和局部值）：**

- `_jump` = `0`
- `_sprite.Texture` = `_waitingAnchor`
- `_waiting` = `false`
- `_waitingAnchor` = `null`
- `_waitingDoubleBounce` = `false`
- `_waitingShift` = `_waitingShiftFrom = _waitingShiftTarget = 0`
- `_waitingShiftElapsed` = `1`
- `_waitingShiftFrom` = `_waitingShiftTarget = 0`
- `_waitingShiftTarget` = `0`

<a id="symbol-9b17a8ece561"></a>

## `NationalSpire.DateSceneView.RememberSprite(Godot.Texture2D) — private void RememberSprite(Texture2D texture)`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView.BeginWaiting()`](DateSceneWaiting.cs.md#symbol-289036db5043)；[`NationalSpire.DateSceneView.Layout()`](DateSceneView.cs.md#symbol-80b96be1ed4b)；[`NationalSpire.DateSceneView.ShowLine(NationalSpire.DateSceneLine, string, Godot.Texture2D)`](DateSceneView.cs.md#symbol-1801b5d93aa1)；[`NationalSpire.DateSceneView.WaitingSpriteBounds()`](DateSceneWaiting.cs.md#symbol-6d50be6d43f5)

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

## `NationalSpire.DateSceneView.WaitingSpriteBounds() — private Rect2 WaitingSpriteBounds()`

来源：源码第 45 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView.TickWaiting(double)`](DateSceneWaiting.cs.md#symbol-bb1239eb8331)；[`NationalSpire.DateSceneView.WaitingBubble()`](DateSceneWaiting.cs.md#symbol-865fad94731c)；[`NationalSpire.DateSceneView.WaitingClick(Godot.Vector2)`](DateSceneWaiting.cs.md#symbol-883b2e576cb3)

**调用：** [`NationalSpire.DateSceneView.RememberSprite(Godot.Texture2D)`](DateSceneWaiting.cs.md#symbol-9b17a8ece561)；`Godot.GodotObject.GetInstanceId()`；`Godot.Rect2.Rect2()`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.Texture2D.GetSize()`；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView._sprite`；`NationalSpire.DateSceneView._spriteBounds`；`NationalSpire.DateSceneView.RememberSprite(Godot.Texture2D)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.GetInstanceId()`；输入表达式：`_sprite.Texture.GetInstanceId()`；返回值紧邻使用处：`ArgumentSyntax: _sprite.Texture.GetInstanceId()`
- `Godot.Rect2.Rect2()`；输入表达式：`new()`；返回值紧邻使用处：`ReturnStatementSyntax: return new();`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(_sprite.Position + (_sprite.Size - drawn) / 2 + used.Position * drawn, used.Size * drawn)`；返回值紧邻使用处：`ReturnStatementSyntax: return new Rect2(_sprite.Position + (_sprite.Size - drawn) / 2 + used.Position * drawn, used.Size * drawn);`
- `Godot.Texture2D.GetSize()`；输入表达式：`_sprite.Texture.GetSize()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _sprite.Texture.GetSize()`
- `NationalSpire.DateSceneView.RememberSprite(Godot.Texture2D)`；输入表达式：`RememberSprite(_sprite.Texture)`；返回值紧邻使用处：`ExpressionStatementSyntax: RememberSprite(_sprite.Texture);`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(_sprite.Size.X / dimensions.X, _sprite.Size.Y / dimensions.Y)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(_sprite.Size.X / dimensions.X, _sprite.Size.Y / dimensions.Y)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-883b2e576cb3"></a>

## `NationalSpire.DateSceneView.WaitingClick(Godot.Vector2) — private bool WaitingClick(Vector2 position)`

来源：源码第 53 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView._Input(Godot.InputEvent)`](DateSceneView.cs.md#symbol-557ca90aab66)

**调用：** [`NationalSpire.DateSceneView.WaitingBounce(bool, bool)`](DateSceneWaiting.cs.md#symbol-22eaff430386)；[`NationalSpire.DateSceneView.WaitingBubble()`](DateSceneWaiting.cs.md#symbol-865fad94731c)；[`NationalSpire.DateSceneView.WaitingSpriteBounds()`](DateSceneWaiting.cs.md#symbol-6d50be6d43f5)；`Godot.Control.GetRect()`；`Godot.Rect2.HasPoint(Godot.Vector2)`；`System.Collections.Generic.Queue<T>.Clear()`；`System.Collections.Generic.Queue<T>.Dequeue()`；`System.Collections.Generic.Queue<T>.Enqueue(T)`；`System.Collections.Generic.Queue<T>.Peek()`；`System.Math.Abs(float)`；`System.Random.Next(int, int)`；`System.Random.Next(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView._dialog`；`NationalSpire.DateSceneView._nameBox`；`NationalSpire.DateSceneView._sprite`；`NationalSpire.DateSceneView._waiting`；`NationalSpire.DateSceneView._waitingClicks`；`NationalSpire.DateSceneView._waitingClock`；`NationalSpire.DateSceneView._waitingShift`；`NationalSpire.DateSceneView._waitingShiftAt`；`NationalSpire.DateSceneView._waitingShiftElapsed`；`NationalSpire.DateSceneView._waitingShiftFrom`；`NationalSpire.DateSceneView._waitingShiftTarget`；`NationalSpire.DateSceneView.DialogueHidden`；`NationalSpire.DateSceneView.HistoryOpen`；`NationalSpire.DateSceneView.WaitingBounce(bool, bool)`；`NationalSpire.DateSceneView.WaitingBubble()`；`NationalSpire.DateSceneView.WaitingSpriteBounds()`；`NationalSpire.DateSceneView.WaitingSprites`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.GetRect()`；输入表达式：`_dialog.GetRect()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _dialog.GetRect().HasPoint`
- `Godot.Control.GetRect()`；输入表达式：`_nameBox.GetRect()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _nameBox.GetRect().HasPoint`
- `Godot.Rect2.HasPoint(Godot.Vector2)`；输入表达式：`_dialog.GetRect().HasPoint(position)`；返回值紧邻使用处：`BinaryExpressionSyntax: _dialog.GetRect().HasPoint(position) || _nameBox.Visible && _nameBox.GetRect().HasPoint(position)`
- `Godot.Rect2.HasPoint(Godot.Vector2)`；输入表达式：`_nameBox.GetRect().HasPoint(position)`；返回值紧邻使用处：`BinaryExpressionSyntax: _nameBox.Visible && _nameBox.GetRect().HasPoint(position)`
- `Godot.Rect2.HasPoint(Godot.Vector2)`；输入表达式：`WaitingSpriteBounds().HasPoint(position)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !WaitingSpriteBounds().HasPoint(position)`
- `NationalSpire.DateSceneView.WaitingBounce(bool, bool)`；输入表达式：`WaitingBounce(true, false)`；返回值紧邻使用处：`ExpressionStatementSyntax: WaitingBounce(true, false);`
- `NationalSpire.DateSceneView.WaitingBubble()`；输入表达式：`WaitingBubble()`；返回值紧邻使用处：`ExpressionStatementSyntax: WaitingBubble();`
- `NationalSpire.DateSceneView.WaitingSpriteBounds()`；输入表达式：`WaitingSpriteBounds()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: WaitingSpriteBounds().HasPoint`
- `System.Collections.Generic.Queue<T>.Clear()`；输入表达式：`_waitingClicks.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _waitingClicks.Clear();`
- `System.Collections.Generic.Queue<T>.Dequeue()`；输入表达式：`_waitingClicks.Dequeue()`；返回值紧邻使用处：`ExpressionStatementSyntax: _waitingClicks.Dequeue();`
- `System.Collections.Generic.Queue<T>.Enqueue(T)`；输入表达式：`_waitingClicks.Enqueue(_waitingClock)`；返回值紧邻使用处：`ExpressionStatementSyntax: _waitingClicks.Enqueue(_waitingClock);`
- `System.Collections.Generic.Queue<T>.Peek()`；输入表达式：`_waitingClicks.Peek()`；返回值紧邻使用处：`BinaryExpressionSyntax: _waitingClock - _waitingClicks.Peek()`
- `System.Math.Abs(float)`；输入表达式：`Math.Abs(_waitingShift + direction * distance)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Abs(_waitingShift + direction * distance) > 120`
- `System.Random.Next(int, int)`；输入表达式：`Random.Shared.Next(50, 121)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Random.Shared.Next(50, 121)`
- `System.Random.Next(int)`；输入表达式：`Random.Shared.Next(2)`；返回值紧邻使用处：`BinaryExpressionSyntax: Random.Shared.Next(2) == 0`
- `System.Random.Next(int)`；输入表达式：`Random.Shared.Next(WaitingSprites.Count)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Random.Shared.Next(WaitingSprites.Count)`

**赋值（含属性/字段和局部值）：**

- `_sprite.Texture` = `WaitingSprites[index]`
- `_waitingShiftAt` = `_waitingClock`
- `_waitingShiftElapsed` = `0`
- `_waitingShiftFrom` = `_waitingShift`
- `_waitingShiftTarget` = `_waitingShift + direction * distance`
- `direction` = `-direction`
- `index` = `(index + 1) % WaitingSprites.Count`

<a id="symbol-22eaff430386"></a>

## `NationalSpire.DateSceneView.WaitingBounce(bool, bool) — private void WaitingBounce(bool strong, bool twice)`

来源：源码第 81 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView.TickWaiting(double)`](DateSceneWaiting.cs.md#symbol-bb1239eb8331)；[`NationalSpire.DateSceneView.WaitingClick(Godot.Vector2)`](DateSceneWaiting.cs.md#symbol-883b2e576cb3)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView._jump`；`NationalSpire.DateSceneView._jumpDuration`；`NationalSpire.DateSceneView._jumpHeight`；`NationalSpire.DateSceneView._waitingDoubleBounce`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `_jump` = `_jumpDuration`
- `_jumpDuration` = `twice ? .56f : .36f`
- `_jumpHeight` = `strong ? 18 : 9`
- `_waitingDoubleBounce` = `twice`

<a id="symbol-bb1239eb8331"></a>

## `NationalSpire.DateSceneView.TickWaiting(double) — private void TickWaiting(double delta)`

来源：源码第 85 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView._Process(double)`](DateSceneView.cs.md#symbol-e901780018ca)

**调用：** [`NationalSpire.DateSceneView.WaitingBounce(bool, bool)`](DateSceneWaiting.cs.md#symbol-22eaff430386)；[`NationalSpire.DateSceneView.WaitingSpriteBounds()`](DateSceneWaiting.cs.md#symbol-6d50be6d43f5)；`Godot.CanvasItem.Hide()`；`Godot.Color.Color(float, float, float, float)`；`Godot.Control.GetRect()`；`Godot.Mathf.Lerp(float, float, float)`；`Godot.Node.QueueFree()`；`Godot.Rect2.GetCenter()`；`Godot.Rect2.Intersects(Godot.Rect2, bool)`；`Godot.Rect2.Rect2()`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.List<T>.RemoveAt(int)`；`System.Math.Abs(float)`；`System.Math.Clamp(double, double, double)`；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** `(Godot.PanelContainer Panel, double Born).Born`；`(Godot.PanelContainer Panel, double Born).Panel`；`NationalSpire.DateSceneView._dialog`；`NationalSpire.DateSceneView._favourHost`；`NationalSpire.DateSceneView._nameBox`；`NationalSpire.DateSceneView._sprite`；`NationalSpire.DateSceneView._spriteX`；`NationalSpire.DateSceneView._waiting`；`NationalSpire.DateSceneView._waitingBounceAt`；`NationalSpire.DateSceneView._waitingBubbles`；`NationalSpire.DateSceneView._waitingClock`；`NationalSpire.DateSceneView._waitingShift`；`NationalSpire.DateSceneView._waitingShiftElapsed`；`NationalSpire.DateSceneView._waitingShiftFrom`；`NationalSpire.DateSceneView._waitingShiftTarget`；`NationalSpire.DateSceneView.WaitingBounce(bool, bool)`；`NationalSpire.DateSceneView.WaitingSpriteBounds()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`item.Panel.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: item.Panel.Hide();`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(1, 1, 1, (float)Math.Clamp((2.8 - age) / .4, 0, 1))`；返回值紧邻使用处：`AssignmentExpressionSyntax: item.Panel.Modulate = new Color(1, 1, 1, (float)Math.Clamp((2.8 - age) / .4, 0, 1))`
- `Godot.Control.GetRect()`；输入表达式：`_dialog.GetRect()`；返回值紧邻使用处：`ArgumentSyntax: _dialog.GetRect()`
- `Godot.Control.GetRect()`；输入表达式：`_favourHost.GetRect()`；返回值紧邻使用处：`ArgumentSyntax: _favourHost.GetRect()`
- `Godot.Control.GetRect()`；输入表达式：`_nameBox.GetRect()`；返回值紧邻使用处：`ArgumentSyntax: _nameBox.GetRect()`
- `Godot.Control.GetRect()`；输入表达式：`item.Panel.GetRect()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = item.Panel.GetRect()`
- `Godot.Mathf.Lerp(float, float, float)`；输入表达式：`Mathf.Lerp(_waitingShiftFrom, _waitingShiftTarget, eased)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _waitingShift = Mathf.Lerp(_waitingShiftFrom, _waitingShiftTarget, eased)`
- `Godot.Node.QueueFree()`；输入表达式：`item.Panel.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: item.Panel.QueueFree();`
- `Godot.Rect2.GetCenter()`；输入表达式：`bounds.GetCenter()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = bounds.GetCenter()`
- `Godot.Rect2.Intersects(Godot.Rect2, bool)`；输入表达式：`bounds.Intersects(_dialog.GetRect())`；返回值紧邻使用处：`BinaryExpressionSyntax: age >= 2.8 || Math.Abs(center.Y - portrait.Position.Y) > 100 || Math.Min(Math.Abs(center.X - portrait.Position.X), Math.Abs(center.X - portrait.End.X)) > 150                  || _dialog.Position.Y - center.Y < 50 || bounds.Intersects(_dialog.GetRect())`
- `Godot.Rect2.Intersects(Godot.Rect2, bool)`；输入表达式：`bounds.Intersects(_favourHost.GetRect())`；返回值紧邻使用处：`BinaryExpressionSyntax: _favourHost.Visible && bounds.Intersects(_favourHost.GetRect())`
- `Godot.Rect2.Intersects(Godot.Rect2, bool)`；输入表达式：`bounds.Intersects(_nameBox.GetRect())`；返回值紧邻使用处：`BinaryExpressionSyntax: _nameBox.Visible && bounds.Intersects(_nameBox.GetRect())`
- `Godot.Rect2.Rect2()`；输入表达式：`new Rect2()`；返回值紧邻使用处：`ConditionalExpressionSyntax: _waitingBubbles.Count > 0 ? WaitingSpriteBounds() : new Rect2()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new((Size.X - _sprite.Size.X) * .5f + _spriteX + _waitingShift, _sprite.Position.Y)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _sprite.Position = new((Size.X - _sprite.Size.X) * .5f + _spriteX + _waitingShift, _sprite.Position.Y)`
- `NationalSpire.DateSceneView.WaitingBounce(bool, bool)`；输入表达式：`WaitingBounce(false, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: WaitingBounce(false, true);`
- `NationalSpire.DateSceneView.WaitingSpriteBounds()`；输入表达式：`WaitingSpriteBounds()`；返回值紧邻使用处：`ConditionalExpressionSyntax: _waitingBubbles.Count > 0 ? WaitingSpriteBounds() : new Rect2()`
- `System.Collections.Generic.List<T>.RemoveAt(int)`；输入表达式：`_waitingBubbles.RemoveAt(i)`；返回值紧邻使用处：`ExpressionStatementSyntax: _waitingBubbles.RemoveAt(i);`
- `System.Math.Abs(float)`；输入表达式：`Math.Abs(center.X - portrait.End.X)`；返回值紧邻使用处：`ArgumentSyntax: Math.Abs(center.X - portrait.End.X)`
- `System.Math.Abs(float)`；输入表达式：`Math.Abs(center.X - portrait.Position.X)`；返回值紧邻使用处：`ArgumentSyntax: Math.Abs(center.X - portrait.Position.X)`
- `System.Math.Abs(float)`；输入表达式：`Math.Abs(center.Y - portrait.Position.Y)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Abs(center.Y - portrait.Position.Y) > 100`
- `System.Math.Clamp(double, double, double)`；输入表达式：`Math.Clamp((2.8 - age) / .4, 0, 1)`；返回值紧邻使用处：`CastExpressionSyntax: (float)Math.Clamp((2.8 - age) / .4, 0, 1)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(1, _waitingShiftElapsed + (float)delta / .28f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _waitingShiftElapsed = Math.Min(1, _waitingShiftElapsed + (float)delta / .28f)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(Math.Abs(center.X - portrait.Position.X), Math.Abs(center.X - portrait.End.X))`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Min(Math.Abs(center.X - portrait.Position.X), Math.Abs(center.X - portrait.End.X)) > 150`

**赋值（含属性/字段和局部值）：**

- `_sprite.Position` = `new((Size.X - _sprite.Size.X) * .5f + _spriteX + _waitingShift, _sprite.Position.Y)`
- `_waitingBounceAt` = `_waitingClock + 5`
- `_waitingClock` += `delta`
- `_waitingShift` = `Mathf.Lerp(_waitingShiftFrom, _waitingShiftTarget, eased)`
- `_waitingShiftElapsed` = `Math.Min(1, _waitingShiftElapsed + (float)delta / .28f)`
- `item.Panel.Modulate` = `new Color(1, 1, 1, (float)Math.Clamp((2.8 - age) / .4, 0, 1))`

<a id="symbol-865fad94731c"></a>

## `NationalSpire.DateSceneView.WaitingBubble() — private void WaitingBubble()`

来源：源码第 106 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView.WaitingClick(Godot.Vector2)`](DateSceneWaiting.cs.md#symbol-883b2e576cb3)

**调用：** [`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.DateSceneView.WaitingSpriteBounds()`](DateSceneWaiting.cs.md#symbol-6d50be6d43f5)；`Godot.CanvasItem.Hide()`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.GetCombinedMinimumSize()`；`Godot.Control.GetRect()`；`Godot.Control.GetThemeFontSize(Godot.StringName, Godot.StringName)`；`Godot.Label.Label()`；`Godot.Mathf.Lerp(float, float, float)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.QueueFree()`；`Godot.PanelContainer.PanelContainer()`；`Godot.Rect2.Intersects(Godot.Rect2, bool)`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Math.Max(float, float)`；`System.Math.Max(int, int)`；`System.Math.Min(float, float)`；`System.Random.Next(int)`；`System.Random.NextSingle()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.DateSceneView._dialog`；`NationalSpire.DateSceneView._favourHost`；`NationalSpire.DateSceneView._interface`；`NationalSpire.DateSceneView._nameBox`；`NationalSpire.DateSceneView._text`；`NationalSpire.DateSceneView._waitingBubbles`；`NationalSpire.DateSceneView._waitingClock`；`NationalSpire.DateSceneView.DialogueHidden`；`NationalSpire.DateSceneView.Ink`；`NationalSpire.DateSceneView.WaitingPhrases`；`NationalSpire.DateSceneView.WaitingSpriteBounds()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`bubble.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: bubble.Hide();`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`text.AddThemeColorOverride("font_color", Ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: text.AddThemeColorOverride("font_color", Ink);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`text.AddThemeFontSizeOverride("font_size", Math.Max(1, _text.GetThemeFontSize("normal_font_size") - 3))`；返回值紧邻使用处：`ExpressionStatementSyntax: text.AddThemeFontSizeOverride("font_size", Math.Max(1, _text.GetThemeFontSize("normal_font_size") - 3));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`bubble.AddThemeStyleboxOverride("panel", CareerVisuals.Box("233b4f66", "b6d0da66", 14, 12))`；返回值紧邻使用处：`ExpressionStatementSyntax: bubble.AddThemeStyleboxOverride("panel", CareerVisuals.Box("233b4f66", "b6d0da66", 14, 12));`
- `Godot.Control.GetCombinedMinimumSize()`；输入表达式：`bubble.GetCombinedMinimumSize()`；返回值紧邻使用处：`AssignmentExpressionSyntax: bubble.Size = bubble.GetCombinedMinimumSize()`
- `Godot.Control.GetRect()`；输入表达式：`_dialog.GetRect()`；返回值紧邻使用处：`ArgumentSyntax: _dialog.GetRect()`
- `Godot.Control.GetRect()`；输入表达式：`_favourHost.GetRect()`；返回值紧邻使用处：`ArgumentSyntax: _favourHost.GetRect()`
- `Godot.Control.GetRect()`；输入表达式：`_nameBox.GetRect()`；返回值紧邻使用处：`ArgumentSyntax: _nameBox.GetRect()`
- `Godot.Control.GetThemeFontSize(Godot.StringName, Godot.StringName)`；输入表达式：`_text.GetThemeFontSize("normal_font_size")`；返回值紧邻使用处：`BinaryExpressionSyntax: _text.GetThemeFontSize("normal_font_size") - 3`
- `Godot.Label.Label()`；输入表达式：`new Label { Text = WaitingPhrases[Random.Shared.Next(WaitingPhrases.Length)], MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Label { Text = WaitingPhrases[Random.Shared.Next(WaitingPhrases.Length)], MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Mathf.Lerp(float, float, float)`；输入表达式：`Mathf.Lerp(left, right, Random.Shared.NextSingle())`；返回值紧邻使用处：`ArgumentSyntax: Mathf.Lerp(left, right, Random.Shared.NextSingle())`
- `Godot.Mathf.Lerp(float, float, float)`；输入表达式：`Mathf.Lerp(low, high, Random.Shared.NextSingle())`；返回值紧邻使用处：`ArgumentSyntax: Mathf.Lerp(low, high, Random.Shared.NextSingle())`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_interface.AddChild(bubble)`；返回值紧邻使用处：`ExpressionStatementSyntax: _interface.AddChild(bubble);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`bubble.AddChild(text)`；返回值紧邻使用处：`ExpressionStatementSyntax: bubble.AddChild(text);`
- `Godot.Node.QueueFree()`；输入表达式：`bubble.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: bubble.QueueFree();`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { Name = "DateWaitingBubble", MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { Name = "DateWaitingBubble", MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Rect2.Intersects(Godot.Rect2, bool)`；输入表达式：`rect.Intersects(_dialog.GetRect())`；返回值紧邻使用处：`BinaryExpressionSyntax: rect.Intersects(_dialog.GetRect()) || _nameBox.Visible && rect.Intersects(_nameBox.GetRect())`
- `Godot.Rect2.Intersects(Godot.Rect2, bool)`；输入表达式：`rect.Intersects(_favourHost.GetRect())`；返回值紧邻使用处：`BinaryExpressionSyntax: _favourHost.Visible && rect.Intersects(_favourHost.GetRect())`
- `Godot.Rect2.Intersects(Godot.Rect2, bool)`；输入表达式：`rect.Intersects(_nameBox.GetRect())`；返回值紧邻使用处：`BinaryExpressionSyntax: _nameBox.Visible && rect.Intersects(_nameBox.GetRect())`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(center - half, bubble.Size)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Rect2(center - half, bubble.Size)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(Mathf.Lerp(left, right, Random.Shared.NextSingle()), Mathf.Lerp(low, high, Random.Shared.NextSingle()))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Vector2(Mathf.Lerp(left, right, Random.Shared.NextSingle()), Mathf.Lerp(low, high, Random.Shared.NextSingle()))`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("233b4f66", "b6d0da66", 14, 12)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("233b4f66", "b6d0da66", 14, 12)`
- `NationalSpire.DateSceneView.WaitingSpriteBounds()`；输入表达式：`WaitingSpriteBounds()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = WaitingSpriteBounds()`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`_waitingBubbles.Add((bubble, _waitingClock))`；返回值紧邻使用处：`ExpressionStatementSyntax: _waitingBubbles.Add((bubble, _waitingClock));`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(half.X + 4, side - 150)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Max(half.X + 4, side - 150)`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(half.Y + 4, portrait.Position.Y - 80)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Max(half.Y + 4, portrait.Position.Y - 80)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1, _text.GetThemeFontSize("normal_font_size") - 3)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(1, _text.GetThemeFontSize("normal_font_size") - 3)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(_dialog.Position.Y - 50, _dialog.Position.Y - half.Y - 4)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(_dialog.Position.Y - 50, _dialog.Position.Y - half.Y - 4)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(portrait.Position.Y + 80, Math.Min(_dialog.Position.Y - 50, _dialog.Position.Y - half.Y - 4))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(portrait.Position.Y + 80, Math.Min(_dialog.Position.Y - 50, _dialog.Position.Y - half.Y - 4))`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(Size.X - half.X - 4, side + 150)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(Size.X - half.X - 4, side + 150)`
- `System.Random.Next(int)`；输入表达式：`Random.Shared.Next(2)`；返回值紧邻使用处：`BinaryExpressionSyntax: Random.Shared.Next(2) == 0`
- `System.Random.Next(int)`；输入表达式：`Random.Shared.Next(WaitingPhrases.Length)`；返回值紧邻使用处：`ArgumentSyntax: Random.Shared.Next(WaitingPhrases.Length)`
- `System.Random.NextSingle()`；输入表达式：`Random.Shared.NextSingle()`；返回值紧邻使用处：`ArgumentSyntax: Random.Shared.NextSingle()`

**赋值（含属性/字段和局部值）：**

- `bubble.Position` = `rect.Position`
- `bubble.Size` = `bubble.GetCombinedMinimumSize()`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Name` = `"DateWaitingBubble"`
- `placed` = `true`
- `Text` = `WaitingPhrases[Random.Shared.Next(WaitingPhrases.Length)]`
