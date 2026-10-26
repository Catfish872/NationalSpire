# DateSceneMemoryPlayback.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`46D5AD4C7085E3882A7DD23D1586C3C55352E87B83C2FA1D3FC49AAD9676AE7E`。来源：[源码](../../DateSceneMemoryPlayback.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.DateSceneView`、`NationalSpire.DateMemoryPlayback`。

字段、事件及初始值（源码原样）：

```csharp
public Action? Closed;
public Action<string>? DeleteReply;
public Func<bool>? Blocked;
private DateSceneView _view = null!;
private readonly Dictionary<string, Texture2D> _textures = [];
private readonly List<(DateSceneLine Line, string Name, bool Player, DateMemoryFrame Frame, string Turn, int Index)> _pages = [];
private int _index;
private string _warning = "";
```

<a id="symbol-72b7e856545d"></a>

## `NationalSpire.DateSceneView.CaptureMemoryFrame(System.Func<Godot.Texture2D, string>) — public DateMemoryFrame CaptureMemoryFrame(Func<Texture2D, string> image)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.CaptureDateMemory()`](DateSceneMemoryScreen.cs.md#symbol-7b36ced91124)

**调用：** `NationalSpire.DateMemoryFrame.DateMemoryFrame()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IDictionary<TKey, TValue>)`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Func<T, TResult>.Invoke(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateMemoryFrame.Anchors`；`NationalSpire.DateMemoryFrame.Background`；`NationalSpire.DateMemoryFrame.Cast`；`NationalSpire.DateMemoryFrame.Placements`；`NationalSpire.DateMemoryFrame.Portraits`；`NationalSpire.DateMemoryFrame.Speaker`；`NationalSpire.DateSceneCast.Default`；`NationalSpire.DateSceneCast.PersonId`；`NationalSpire.DateSceneView._backgroundId`；`NationalSpire.DateSceneView._cast`；`NationalSpire.DateSceneView._castSprites`；`NationalSpire.DateSceneView._portraitPlacements`；`NationalSpire.DateSceneView._queuedBackgroundId`；`NationalSpire.DateSceneView._speaker`；`NationalSpire.DateSceneView._sprite`；`NationalSpire.DateSceneView._visibleCast`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateMemoryFrame.DateMemoryFrame()`；输入表达式：`new DateMemoryFrame { Background = _queuedBackgroundId.Length > 0 ? _queuedBackgroundId : _backgroundId, Speaker = _speaker, Cast = _visibleCast.ToList(), Placements = new(_portraitPlacements) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new DateMemoryFrame { Background = _queuedBackgroundId.Length > 0 ? _queuedBackgroundId : _backgroundId, Speaker = _speaker, Cast = _visibleCast.ToList(), Placements = new(_portraitPlacements) }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IDictionary<TKey, TValue>)`；输入表达式：`new(_portraitPlacements)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Placements = new(_portraitPlacements)`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`_cast.First(c => c.PersonId == id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _cast.First(c => c.PersonId == id).Default`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`_visibleCast.ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Cast = _visibleCast.ToList()`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`_castSprites.GetValueOrDefault(id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _castSprites.GetValueOrDefault(id)?.Texture`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`image(_cast.First(c => c.PersonId == id).Default)`；返回值紧邻使用处：`AssignmentExpressionSyntax: result.Anchors[id] = image(_cast.First(c => c.PersonId == id).Default)`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`image(texture)`；返回值紧邻使用处：`AssignmentExpressionSyntax: result.Portraits[id] = image(texture)`

**赋值（含属性/字段和局部值）：**

- `Background` = `_queuedBackgroundId.Length > 0 ? _queuedBackgroundId : _backgroundId`
- `Cast` = `_visibleCast.ToList()`
- `Placements` = `new(_portraitPlacements)`
- `Speaker` = `_speaker`
- `result.Anchors[id]` = `image(_cast.First(c => c.PersonId == id).Default)`
- `result.Portraits[id]` = `image(texture)`
- `texture` ??= `_cast.First(c => c.PersonId == id).Default`

<a id="symbol-714c8ce810da"></a>

## `NationalSpire.DateSceneView.MemoryControls(System.Action, System.Action) — public void MemoryControls(Action previous, Action restart)`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateMemoryPlayback._Ready()`](DateSceneMemoryPlayback.cs.md#symbol-d7bfbc4c7f9b)

**调用：** `Godot.CanvasItem.Hide()`；`Godot.Node.GetNode<T>(Godot.NodePath)`；[`NationalSpire.DateSceneView.AddSceneAction(string, string, System.Action)`](DateSceneCast.cs.md#symbol-97b88ee931cf)

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneView.AddSceneAction(string, string, System.Action)`；`NationalSpire.DateSceneView.EditPreviousButton`；`NationalSpire.DateSceneView.ExitButton`；`NationalSpire.DateSceneView._hint`；`NationalSpire.DateSceneView._hintDismissed`；`NationalSpire.DateSceneView._settings`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`EditPreviousButton.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: EditPreviousButton.Hide();`
- `Godot.CanvasItem.Hide()`；输入表达式：`_hint.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _hint.Hide();`
- `Godot.CanvasItem.Hide()`；输入表达式：`_settings.GetNode<Button>("DateSettings").Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _settings.GetNode<Button>("DateSettings").Hide();`
- `Godot.Node.GetNode<T>(Godot.NodePath)`；输入表达式：`_settings.GetNode<Button>("DateEnd")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _settings.GetNode<Button>("DateEnd").Text`
- `Godot.Node.GetNode<T>(Godot.NodePath)`；输入表达式：`_settings.GetNode<Button>("DateSettings")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _settings.GetNode<Button>("DateSettings").Hide`
- `NationalSpire.DateSceneView.AddSceneAction(string, string, System.Action)`；输入表达式：`AddSceneAction("上一句", "DateMemoryPrevious", previous)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddSceneAction("上一句", "DateMemoryPrevious", previous);`
- `NationalSpire.DateSceneView.AddSceneAction(string, string, System.Action)`；输入表达式：`AddSceneAction("从头回看", "DateMemoryRestart", restart)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddSceneAction("从头回看", "DateMemoryRestart", restart);`

**赋值（含属性/字段和局部值）：**

- `ExitButton.Text` = `"返回日记 Esc"`
- `_hintDismissed` = `true`
- `_settings.GetNode<Button>("DateEnd").Text` = `"返回日记"`

<a id="symbol-428af8387aa7"></a>

## `NationalSpire.DateSceneView.ShowMemoryFrame(NationalSpire.DateMemoryFrame, NationalSpire.DateSceneLine, string, bool, System.Collections.Generic.IReadOnlyDictionary<string, NationalSpire.DateMemoryPerson>, System.Func<string, Godot.Texture2D>) — public void ShowMemoryFrame(DateMemoryFrame frame, DateSceneLine line, string name, bool player, IReadOnlyDictionary<string, DateMemoryPerson> people, Func<string, Texture2D> texture)`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateMemoryPlayback.ShowPage()`](DateSceneMemoryPlayback.cs.md#symbol-cf0986d25dad)

**调用：** `NationalSpire.DateSceneCast.DateSceneCast(string, string, System.Func<Godot.Texture2D>)`；`NationalSpire.DateSceneLine.DateSceneLine()`；[`NationalSpire.DateSceneMemories.CopyLine(NationalSpire.DateSceneLine)`](DateSceneMemories.cs.md#symbol-0929ad334607)；[`NationalSpire.DateSceneView.AffectionVisibility(bool)`](DateSceneView.cs.md#symbol-7da14922fda4)；[`NationalSpire.DateSceneView.PortraitPlacements(System.Collections.Generic.IReadOnlyDictionary<string, NationalSpire.DatePortraitPlacement>)`](DateSceneCast.cs.md#symbol-80abec64fd7f)；[`NationalSpire.DateSceneView.Preferences(int, double, double)`](DateSceneView.cs.md#symbol-878552c24bd8)；[`NationalSpire.DateSceneView.Presentation(double, double, double, bool)`](DateSceneView.cs.md#symbol-32ea38e8c82d)；[`NationalSpire.DateSceneView.Relationship(NationalSpire.PrivateRelation, string, bool)`](DateSceneView.cs.md#symbol-949c1add6c05)；[`NationalSpire.DateSceneView.RestoreVisibleCast(System.Collections.Generic.IEnumerable<string>)`](DateSceneCast.cs.md#symbol-2d5e455c25d0)；[`NationalSpire.DateSceneView.SelectSpeaker(NationalSpire.DateSceneLine, Godot.Texture2D, bool)`](DateSceneCast.cs.md#symbol-52d06ed87b40)；[`NationalSpire.DateSceneView.SetCast(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneCast>)`](DateSceneCast.cs.md#symbol-913514fd78e1)；[`NationalSpire.DateSceneView.SetDialogueVisible(bool)`](DateSceneView.cs.md#symbol-11800b4bb8d0)；[`NationalSpire.DateSceneView.ShowLineCore(NationalSpire.DateSceneLine, string, Godot.Texture2D, bool)`](DateSceneView.cs.md#symbol-d19549d8d807)；[`NationalSpire.DateSceneView.Streaming(bool)`](DateSceneView.cs.md#symbol-e7a96de3c199)；`NationalSpire.PrivateRelation.PrivateRelation()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Func<T, TResult>.Invoke(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateMemoryFrame.Anchors`；`NationalSpire.DateMemoryFrame.Badge`；`NationalSpire.DateMemoryFrame.Bond`；`NationalSpire.DateMemoryFrame.Cast`；`NationalSpire.DateMemoryFrame.Fade`；`NationalSpire.DateMemoryFrame.Favour`；`NationalSpire.DateMemoryFrame.FontSize`；`NationalSpire.DateMemoryFrame.Oath`；`NationalSpire.DateMemoryFrame.Outline`；`NationalSpire.DateMemoryFrame.Placements`；`NationalSpire.DateMemoryFrame.Portraits`；`NationalSpire.DateMemoryFrame.Relationship`；`NationalSpire.DateMemoryFrame.Scale`；`NationalSpire.DateMemoryFrame.Spacing`；`NationalSpire.DateMemoryFrame.Speaker`；`NationalSpire.DateMemoryFrame.X`；`NationalSpire.DateMemoryFrame.Y`；`NationalSpire.DateMemoryPerson.Default`；`NationalSpire.DateMemoryPerson.Name`；`NationalSpire.DateSceneLine.Narration`；`NationalSpire.DateSceneLine.Speaker`；`NationalSpire.DateSceneMemories.CopyLine(NationalSpire.DateSceneLine)`；`NationalSpire.DateSceneParty.VisibleMaximum`；`NationalSpire.DateSceneView.AffectionVisibility(bool)`；`NationalSpire.DateSceneView.PortraitPlacements(System.Collections.Generic.IReadOnlyDictionary<string, NationalSpire.DatePortraitPlacement>)`；`NationalSpire.DateSceneView.Preferences(int, double, double)`；`NationalSpire.DateSceneView.Presentation(double, double, double, bool)`；`NationalSpire.DateSceneView.Relationship(NationalSpire.PrivateRelation, string, bool)`；`NationalSpire.DateSceneView.RestoreVisibleCast(System.Collections.Generic.IEnumerable<string>)`；`NationalSpire.DateSceneView.SelectSpeaker(NationalSpire.DateSceneLine, Godot.Texture2D, bool)`；`NationalSpire.DateSceneView.SetCast(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneCast>)`；`NationalSpire.DateSceneView.SetDialogueVisible(bool)`；`NationalSpire.DateSceneView.ShowLineCore(NationalSpire.DateSceneLine, string, Godot.Texture2D, bool)`；`NationalSpire.DateSceneView.Streaming(bool)`；`NationalSpire.DateSceneView._castSprites`；`NationalSpire.DateSceneView._jump`；`NationalSpire.DateSceneView._sprite`；`NationalSpire.PrivateRelation.Favour`；`NationalSpire.PrivateRelation.OathConfirmed`；`NationalSpire.PrivateRelation.Relationship`；`NationalSpire.PrivateRelation.SelectedBond`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneCast.DateSceneCast(string, string, System.Func<Godot.Texture2D>)`；输入表达式：`new DateSceneCast(id, people[id].Name, () => texture(frame.Anchors.GetValueOrDefault(id, people[id].Default)))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => new DateSceneCast(id, people[id].Name, () => texture(frame.Anchors.GetValueOrDefault(id, people[id].Default)))`
- `NationalSpire.DateSceneLine.DateSceneLine()`；输入表达式：`new() { Speaker = speaker }`；返回值紧邻使用处：`ArgumentSyntax: new() { Speaker = speaker }`
- `NationalSpire.DateSceneMemories.CopyLine(NationalSpire.DateSceneLine)`；输入表达式：`DateSceneMemories.CopyLine(line)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateSceneMemories.CopyLine(line)`
- `NationalSpire.DateSceneView.AffectionVisibility(bool)`；输入表达式：`AffectionVisibility(frame.Badge)`；返回值紧邻使用处：`ExpressionStatementSyntax: AffectionVisibility(frame.Badge);`
- `NationalSpire.DateSceneView.PortraitPlacements(System.Collections.Generic.IReadOnlyDictionary<string, NationalSpire.DatePortraitPlacement>)`；输入表达式：`PortraitPlacements(frame.Placements)`；返回值紧邻使用处：`ExpressionStatementSyntax: PortraitPlacements(frame.Placements);`
- `NationalSpire.DateSceneView.Preferences(int, double, double)`；输入表达式：`Preferences(frame.FontSize, frame.Fade, frame.Spacing)`；返回值紧邻使用处：`ExpressionStatementSyntax: Preferences(frame.FontSize, frame.Fade, frame.Spacing);`
- `NationalSpire.DateSceneView.Presentation(double, double, double, bool)`；输入表达式：`Presentation(frame.Scale, frame.X, frame.Y, frame.Outline)`；返回值紧邻使用处：`ExpressionStatementSyntax: Presentation(frame.Scale, frame.X, frame.Y, frame.Outline);`
- `NationalSpire.DateSceneView.Relationship(NationalSpire.PrivateRelation, string, bool)`；输入表达式：`Relationship(new() { Favour = frame.Favour, Relationship = frame.Relationship, SelectedBond = frame.Bond, OathConfirmed = frame.Oath }, speaker, animate: false)`；返回值紧邻使用处：`ExpressionStatementSyntax: Relationship(new() { Favour = frame.Favour, Relationship = frame.Relationship, SelectedBond = frame.Bond, OathConfirmed = frame.Oath }, speaker, animate: false);`
- `NationalSpire.DateSceneView.RestoreVisibleCast(System.Collections.Generic.IEnumerable<string>)`；输入表达式：`RestoreVisibleCast(ids)`；返回值紧邻使用处：`ExpressionStatementSyntax: RestoreVisibleCast(ids);`
- `NationalSpire.DateSceneView.SelectSpeaker(NationalSpire.DateSceneLine, Godot.Texture2D, bool)`；输入表达式：`SelectSpeaker(new() { Speaker = speaker }, portrait, false)`；返回值紧邻使用处：`ExpressionStatementSyntax: SelectSpeaker(new() { Speaker = speaker }, portrait, false);`
- `NationalSpire.DateSceneView.SetCast(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneCast>)`；输入表达式：`SetCast(ids.Select(id => new DateSceneCast(id, people[id].Name, () => texture(frame.Anchors.GetValueOrDefault(id, people[id].Default)))))`；返回值紧邻使用处：`ExpressionStatementSyntax: SetCast(ids.Select(id => new DateSceneCast(id, people[id].Name, () => texture(frame.Anchors.GetValueOrDefault(id, people[id].Default)))));`
- `NationalSpire.DateSceneView.SetDialogueVisible(bool)`；输入表达式：`SetDialogueVisible(true)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetDialogueVisible(true);`
- `NationalSpire.DateSceneView.ShowLineCore(NationalSpire.DateSceneLine, string, Godot.Texture2D, bool)`；输入表达式：`ShowLineCore(shown, name, portrait, false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowLineCore(shown, name, portrait, false);`
- `NationalSpire.DateSceneView.Streaming(bool)`；输入表达式：`Streaming(false)`；返回值紧邻使用处：`ExpressionStatementSyntax: Streaming(false);`
- `NationalSpire.PrivateRelation.PrivateRelation()`；输入表达式：`new() { Favour = frame.Favour, Relationship = frame.Relationship, SelectedBond = frame.Bond, OathConfirmed = frame.Oath }`；返回值紧邻使用处：`ArgumentSyntax: new() { Favour = frame.Favour, Relationship = frame.Relationship, SelectedBond = frame.Bond, OathConfirmed = frame.Oath }`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`ids.FirstOrDefault()`；返回值紧邻使用处：`BinaryExpressionSyntax: ids.FirstOrDefault() ?? ""`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`ids.Select(id => new DateSceneCast(id, people[id].Name, () => texture(frame.Anchors.GetValueOrDefault(id, people[id].Default))))`；返回值紧邻使用处：`ArgumentSyntax: ids.Select(id => new DateSceneCast(id, people[id].Name, () => texture(frame.Anchors.GetValueOrDefault(id, people[id].Default))))`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`frame.Cast.Where(people.ContainsKey).Take(DateSceneParty.VisibleMaximum)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: frame.Cast.Where(people.ContainsKey).Take(DateSceneParty.VisibleMaximum).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`frame.Cast.Where(people.ContainsKey).Take(DateSceneParty.VisibleMaximum).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = frame.Cast.Where(people.ContainsKey).Take(DateSceneParty.VisibleMaximum).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`frame.Cast.Where(people.ContainsKey)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: frame.Cast.Where(people.ContainsKey).Take`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`people.GetValueOrDefault(speaker)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: people.GetValueOrDefault(speaker)?.Default`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`frame.Anchors.GetValueOrDefault(id, people[id].Default)`；返回值紧邻使用处：`ArgumentSyntax: frame.Anchors.GetValueOrDefault(id, people[id].Default)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`frame.Portraits.GetValueOrDefault(id, people[id].Default)`；返回值紧邻使用处：`ArgumentSyntax: frame.Portraits.GetValueOrDefault(id, people[id].Default)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`frame.Portraits.GetValueOrDefault(shown.Speaker, people.GetValueOrDefault(speaker)?.Default ?? "")`；返回值紧邻使用处：`ArgumentSyntax: frame.Portraits.GetValueOrDefault(shown.Speaker, people.GetValueOrDefault(speaker)?.Default ?? "")`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`ids.Contains(frame.Speaker)`；返回值紧邻使用处：`ConditionalExpressionSyntax: ids.Contains(frame.Speaker) ? frame.Speaker : ids.FirstOrDefault() ?? ""`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`ids.Contains(line.Speaker)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ids.Contains(line.Speaker)`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`texture(frame.Anchors.GetValueOrDefault(id, people[id].Default))`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => texture(frame.Anchors.GetValueOrDefault(id, people[id].Default))`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`texture(frame.Portraits.GetValueOrDefault(id, people[id].Default))`；返回值紧邻使用处：`AssignmentExpressionSyntax: _castSprites[id].Texture = texture(frame.Portraits.GetValueOrDefault(id, people[id].Default))`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`texture(frame.Portraits.GetValueOrDefault(shown.Speaker, people.GetValueOrDefault(speaker)?.Default ?? ""))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = texture(frame.Portraits.GetValueOrDefault(shown.Speaker, people.GetValueOrDefault(speaker)?.Default ?? ""))`

**赋值（含属性/字段和局部值）：**

- `Favour` = `frame.Favour`
- `OathConfirmed` = `frame.Oath`
- `Relationship` = `frame.Relationship`
- `SelectedBond` = `frame.Bond`
- `Speaker` = `speaker`
- `_castSprites[id].Texture` = `texture(frame.Portraits.GetValueOrDefault(id, people[id].Default))`
- `_jump` = `0`
- `_sprite.Texture` = `portrait`
- `shown.Speaker` = `player || !ids.Contains(line.Speaker) ? speaker : line.Speaker`

<a id="symbol-27b8914b5773"></a>

## `NationalSpire.DateMemoryPlayback.Memory — public DateSceneMemory Memory`

来源：源码第 62 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `NationalSpire.DateSceneMemory.DateSceneMemory()`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneMemory.DateSceneMemory()`；输入表达式：`new()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d7bfbc4c7f9b"></a>

## `NationalSpire.DateMemoryPlayback._Ready() — public override void _Ready()`

来源：源码第 68 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；[`NationalSpire.DateMemoryPlayback.BuildPages()`](DateSceneMemoryPlayback.cs.md#symbol-e09e5b7ddabe)；[`NationalSpire.DateMemoryPlayback.ShowPage()`](DateSceneMemoryPlayback.cs.md#symbol-cf0986d25dad)；`NationalSpire.DateSceneView.DateSceneView()`；[`NationalSpire.DateSceneView.MemoryControls(System.Action, System.Action)`](DateSceneMemoryPlayback.cs.md#symbol-714c8ce810da)；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateMemoryPlayback.Blocked`；`NationalSpire.DateMemoryPlayback.BuildPages()`；`NationalSpire.DateMemoryPlayback.Close()`；`NationalSpire.DateMemoryPlayback.DeleteReply`；`NationalSpire.DateMemoryPlayback.History()`；`NationalSpire.DateMemoryPlayback.HistoryEntries()`；`NationalSpire.DateMemoryPlayback.Next()`；`NationalSpire.DateMemoryPlayback.ShowPage()`；`NationalSpire.DateMemoryPlayback._index`；`NationalSpire.DateMemoryPlayback._view`；`NationalSpire.DateSceneView.Advance`；`NationalSpire.DateSceneView.Blocked`；`NationalSpire.DateSceneView.DeleteHistoryReply`；`NationalSpire.DateSceneView.Exit`；`NationalSpire.DateSceneView.HistoryEntries`；`NationalSpire.DateSceneView.HistoryText`；`NationalSpire.DateSceneView.MemoryControls(System.Action, System.Action)`；`NationalSpire.DateSceneView.TextSpeed`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`_view.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: _view.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(_view)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(_view);`
- `NationalSpire.DateMemoryPlayback.BuildPages()`；输入表达式：`BuildPages()`；返回值紧邻使用处：`ExpressionStatementSyntax: BuildPages();`
- `NationalSpire.DateMemoryPlayback.ShowPage()`；输入表达式：`ShowPage()`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowPage();`
- `NationalSpire.DateSceneView.DateSceneView()`；输入表达式：`new DateSceneView { TextSpeed = 75, Advance = Next, Exit = Close, HistoryText = History, HistoryEntries = HistoryEntries, DeleteHistoryReply = DeleteReply, Blocked = Blocked }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _view = new DateSceneView { TextSpeed = 75, Advance = Next, Exit = Close, HistoryText = History, HistoryEntries = HistoryEntries, DeleteHistoryReply = DeleteReply, Blocked = Blocked }`
- `NationalSpire.DateSceneView.MemoryControls(System.Action, System.Action)`；输入表达式：`_view.MemoryControls(() => { _index = Math.Max(0, _index - 1); ShowPage(); }, () => { _index = 0; ShowPage(); })`；返回值紧邻使用处：`ExpressionStatementSyntax: _view.MemoryControls(() => { _index = Math.Max(0, _index - 1); ShowPage(); }, () => { _index = 0; ShowPage(); });`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, _index - 1)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _index = Math.Max(0, _index - 1)`

**赋值（含属性/字段和局部值）：**

- `Advance` = `Next`
- `Blocked` = `Blocked`
- `DeleteHistoryReply` = `DeleteReply`
- `Exit` = `Close`
- `HistoryEntries` = `HistoryEntries`
- `HistoryText` = `History`
- `MouseFilter` = `MouseFilterEnum.Stop`
- `Name` = `"DateMemoryPlayback"`
- `TextSpeed` = `75`
- `ZIndex` = `32`
- `_index` = `0`
- `_index` = `Math.Max(0, _index - 1)`
- `_view` = `new DateSceneView { TextSpeed = 75, Advance = Next, Exit = Close, HistoryText = History, HistoryEntries = HistoryEntries, DeleteHistoryReply = DeleteReply, Blocked = Blocked }`

<a id="symbol-e09e5b7ddabe"></a>

## `NationalSpire.DateMemoryPlayback.BuildPages() — private void BuildPages()`

来源：源码第 78 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateMemoryPlayback.RefreshHistory()`](DateSceneMemoryPlayback.cs.md#symbol-9343ac064a30)；[`NationalSpire.DateMemoryPlayback._Ready()`](DateSceneMemoryPlayback.cs.md#symbol-d7bfbc4c7f9b)

**调用：** `NationalSpire.DateCastRoster.DateCastRoster()`；[`NationalSpire.DateCastRoster.Observe(NationalSpire.DateSceneLine, string)`](DateSceneCast.cs.md#symbol-d85e4199ab71)；`NationalSpire.DateMemoryFrame.DateMemoryFrame()`；`NationalSpire.DateSceneLine.DateSceneLine()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Clear()`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；`string.IsNullOrWhiteSpace(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateCastRoster.Observe(NationalSpire.DateSceneLine, string)`；`NationalSpire.DateCastRoster.Visible`；`NationalSpire.DateMemoryFrame.Background`；`NationalSpire.DateMemoryFrame.Cast`；`NationalSpire.DateMemoryFrame.Portraits`；`NationalSpire.DateMemoryFrame.Speaker`；`NationalSpire.DateMemoryPerson.Default`；`NationalSpire.DateMemoryPerson.Emotions`；`NationalSpire.DateMemoryPerson.Name`；`NationalSpire.DateMemoryPlayback.Memory`；`NationalSpire.DateMemoryPlayback._pages`；`NationalSpire.DateMemoryTurn.Choice`；`NationalSpire.DateMemoryTurn.Frames`；`NationalSpire.DateMemoryTurn.Id`；`NationalSpire.DateMemoryTurn.Lines`；`NationalSpire.DateMemoryTurn.User`；`NationalSpire.DateMemoryTurn.UserFrame`；`NationalSpire.DateSceneLine.Background`；`NationalSpire.DateSceneLine.Emotion`；`NationalSpire.DateSceneLine.Narration`；`NationalSpire.DateSceneLine.Speaker`；`NationalSpire.DateSceneLine.Text`；`NationalSpire.DateSceneMemory.Backgrounds`；`NationalSpire.DateSceneMemory.Host`；`NationalSpire.DateSceneMemory.Initial`；`NationalSpire.DateSceneMemory.People`；`NationalSpire.DateSceneMemory.Player`；`NationalSpire.DateSceneMemory.Turns`；`NationalSpire.DateSceneParty.VisibleMaximum`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateCastRoster.DateCastRoster()`；输入表达式：`new DateCastRoster()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new DateCastRoster()`
- `NationalSpire.DateCastRoster.Observe(NationalSpire.DateSceneLine, string)`；输入表达式：`roster.Observe(line, Memory.Host)`；返回值紧邻使用处：`ExpressionStatementSyntax: roster.Observe(line, Memory.Host);`
- `NationalSpire.DateMemoryFrame.DateMemoryFrame()`；输入表达式：`new DateMemoryFrame { Cast = Memory.People.Keys.Take(DateSceneParty.VisibleMaximum).ToList(), Speaker = Memory.Host }`；返回值紧邻使用处：`BinaryExpressionSyntax: Memory.Initial ?? new DateMemoryFrame { Cast = Memory.People.Keys.Take(DateSceneParty.VisibleMaximum).ToList(), Speaker = Memory.Host }`
- `NationalSpire.DateSceneLine.DateSceneLine()`；输入表达式：`new() { Text = turn.User }`；返回值紧邻使用处：`ArgumentSyntax: new() { Text = turn.User }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`Memory.People.ContainsKey(line.Speaker)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Memory.People.ContainsKey(line.Speaker) ? line.Speaker : Memory.Host`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Memory.Backgrounds.TryGetValue(line.Background, out string? background)`；返回值紧邻使用处：`IfStatementSyntax: if (Memory.Backgrounds.TryGetValue(line.Background, out string? background)) frame.Background = background;`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Memory.People.TryGetValue(speaker, out var person)`；返回值紧邻使用处：`BinaryExpressionSyntax: !line.Narration && Memory.People.TryGetValue(speaker, out var person)`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`Memory.People.Keys.Take(DateSceneParty.VisibleMaximum)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Memory.People.Keys.Take(DateSceneParty.VisibleMaximum).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`Memory.People.Keys.Take(DateSceneParty.VisibleMaximum).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Cast = Memory.People.Keys.Take(DateSceneParty.VisibleMaximum).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`roster.Visible.ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: frame.Cast = roster.Visible.ToList()`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`Memory.People.GetValueOrDefault(frame.Speaker)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Memory.People.GetValueOrDefault(frame.Speaker)?.Name`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`Memory.People.GetValueOrDefault(line.Speaker)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Memory.People.GetValueOrDefault(line.Speaker)?.Name`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`turn.Frames.GetValueOrDefault(index)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = turn.Frames.GetValueOrDefault(index)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`person.Emotions.GetValueOrDefault(line.Emotion, person.Default)`；返回值紧邻使用处：`AssignmentExpressionSyntax: frame.Portraits[speaker] = person.Emotions.GetValueOrDefault(line.Emotion, person.Default)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`_pages.Add((line, line.Narration ? "" : Memory.People.GetValueOrDefault(line.Speaker)?.Name ?? Memory.People.GetValueOrDefault(frame.Speaker)?.Name ?? "", false, frame, turn.Id, index))`；返回值紧邻使用处：`ExpressionStatementSyntax: _pages.Add((line, line.Narration ? "" : Memory.People.GetValueOrDefault(line.Speaker)?.Name ?? Memory.People.GetValueOrDefault(frame.Speaker)?.Name ?? "", false, frame, turn.Id, index));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`_pages.Add((new() { Text = turn.User }, Memory.Player + (turn.Choice ? " · 选择回应" : ""), true, turn.UserFrame ?? last, turn.Id, -1))`；返回值紧邻使用处：`ExpressionStatementSyntax: _pages.Add((new() { Text = turn.User }, Memory.Player + (turn.Choice ? " · 选择回应" : ""), true, turn.UserFrame ?? last, turn.Id, -1));`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`_pages.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _pages.Clear();`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<DateMemoryFrame>(JsonSerializer.Serialize(last))`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: JsonSerializer.Deserialize<DateMemoryFrame>(JsonSerializer.Serialize(last))!`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(last)`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.Serialize(last)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(line.Text)`；返回值紧邻使用处：`IfStatementSyntax: if (string.IsNullOrWhiteSpace(line.Text)) continue;`

**赋值（含属性/字段和局部值）：**

- `Cast` = `Memory.People.Keys.Take(DateSceneParty.VisibleMaximum).ToList()`
- `Speaker` = `Memory.Host`
- `Text` = `turn.User`
- `frame.Background` = `background`
- `frame.Cast` = `roster.Visible.ToList()`
- `frame.Portraits[speaker]` = `person.Emotions.GetValueOrDefault(line.Emotion, person.Default)`
- `frame.Speaker` = `speaker`
- `frame` = `JsonSerializer.Deserialize<DateMemoryFrame>(JsonSerializer.Serialize(last))!`
- `last` = `frame`

<a id="symbol-29553f3d3337"></a>

## `NationalSpire.DateMemoryPlayback.Texture(string) — private Texture2D Texture(string hash)`

来源：源码第 109 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Image.CreateEmpty(int, int, bool, Godot.Image.Format)`；`Godot.Image.Fill(Godot.Color)`；`Godot.ImageTexture.CreateFromImage(Godot.Image)`；[`NationalSpire.DateSceneAssetStore.Texture(string, bool)`](DateSceneAssets.cs.md#symbol-616d47ee9d6a)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateMemoryPlayback._textures`；`NationalSpire.DateMemoryPlayback._warning`；`NationalSpire.DateSceneAssetStore.Texture(string, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Image.CreateEmpty(int, int, bool, Godot.Image.Format)`；输入表达式：`Image.CreateEmpty(8, 8, false, Image.Format.Rgba8)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Image.CreateEmpty(8, 8, false, Image.Format.Rgba8)`
- `Godot.Image.Fill(Godot.Color)`；输入表达式：`image.Fill(Colors.Transparent)`；返回值紧邻使用处：`ExpressionStatementSyntax: image.Fill(Colors.Transparent);`
- `Godot.ImageTexture.CreateFromImage(Godot.Image)`；输入表达式：`ImageTexture.CreateFromImage(image)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _textures[hash] = ImageTexture.CreateFromImage(image)`
- `NationalSpire.DateSceneAssetStore.Texture(string, bool)`；输入表达式：`DateSceneAssetStore.Texture(hash)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _textures[hash] = DateSceneAssetStore.Texture(hash)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_textures.TryGetValue(hash, out var texture)`；返回值紧邻使用处：`IfStatementSyntax: if (_textures.TryGetValue(hash, out var texture)) return texture;`

**赋值（含属性/字段和局部值）：**

- `_textures[hash]` = `DateSceneAssetStore.Texture(hash)`
- `_textures[hash]` = `ImageTexture.CreateFromImage(image)`
- `_warning` = `"部分回忆素材读取失败：" + e.Message`

<a id="symbol-cf0986d25dad"></a>

## `NationalSpire.DateMemoryPlayback.ShowPage() — private void ShowPage()`

来源：源码第 117 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateMemoryPlayback.Next()`](DateSceneMemoryPlayback.cs.md#symbol-1dd6f6d35fc8)；[`NationalSpire.DateMemoryPlayback.RefreshHistory()`](DateSceneMemoryPlayback.cs.md#symbol-9343ac064a30)；[`NationalSpire.DateMemoryPlayback._Ready()`](DateSceneMemoryPlayback.cs.md#symbol-d7bfbc4c7f9b)

**调用：** `NationalSpire.DateMemoryFrame.DateMemoryFrame()`；`NationalSpire.DateSceneLine.DateSceneLine()`；[`NationalSpire.DateSceneView.Background(string, bool, double)`](DateSceneView.cs.md#symbol-9c58edcaf529)；[`NationalSpire.DateSceneView.ShowMemoryFrame(NationalSpire.DateMemoryFrame, NationalSpire.DateSceneLine, string, bool, System.Collections.Generic.IReadOnlyDictionary<string, NationalSpire.DateMemoryPerson>, System.Func<string, Godot.Texture2D>)`](DateSceneMemoryPlayback.cs.md#symbol-428af8387aa7)

**字段、属性、事件及方法组引用：** `NationalSpire.DateMemoryFrame.Background`；`NationalSpire.DateMemoryFrame.Blur`；`NationalSpire.DateMemoryPlayback.Memory`；`NationalSpire.DateMemoryPlayback.Texture(string)`；`NationalSpire.DateMemoryPlayback._index`；`NationalSpire.DateMemoryPlayback._pages`；`NationalSpire.DateMemoryPlayback._view`；`NationalSpire.DateMemoryPlayback._warning`；`NationalSpire.DateSceneLine.Narration`；`NationalSpire.DateSceneLine.Text`；`NationalSpire.DateSceneMemory.People`；`NationalSpire.DateSceneView.Background(string, bool, double)`；`NationalSpire.DateSceneView.ShowMemoryFrame(NationalSpire.DateMemoryFrame, NationalSpire.DateSceneLine, string, bool, System.Collections.Generic.IReadOnlyDictionary<string, NationalSpire.DateMemoryPerson>, System.Func<string, Godot.Texture2D>)`；`NationalSpire.DateSceneView.Status`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateMemoryFrame.DateMemoryFrame()`；输入表达式：`new()`；返回值紧邻使用处：`ArgumentSyntax: new()`
- `NationalSpire.DateSceneLine.DateSceneLine()`；输入表达式：`new() { Narration = true, Text = "这份回忆中尚无对话记录。" }`；返回值紧邻使用处：`ArgumentSyntax: new() { Narration = true, Text = "这份回忆中尚无对话记录。" }`
- `NationalSpire.DateSceneView.Background(string, bool, double)`；输入表达式：`_view.Background("", false)`；返回值紧邻使用处：`ExpressionStatementSyntax: _view.Background("", false);`
- `NationalSpire.DateSceneView.Background(string, bool, double)`；输入表达式：`_view.Background(page.Frame.Background, true, page.Frame.Blur)`；返回值紧邻使用处：`ExpressionStatementSyntax: _view.Background(page.Frame.Background, true, page.Frame.Blur);`
- `NationalSpire.DateSceneView.ShowMemoryFrame(NationalSpire.DateMemoryFrame, NationalSpire.DateSceneLine, string, bool, System.Collections.Generic.IReadOnlyDictionary<string, NationalSpire.DateMemoryPerson>, System.Func<string, Godot.Texture2D>)`；输入表达式：`_view.ShowMemoryFrame(new(), new() { Narration = true, Text = "这份回忆中尚无对话记录。" }, "", false, Memory.People, Texture)`；返回值紧邻使用处：`ExpressionStatementSyntax: _view.ShowMemoryFrame(new(), new() { Narration = true, Text = "这份回忆中尚无对话记录。" }, "", false, Memory.People, Texture);`
- `NationalSpire.DateSceneView.ShowMemoryFrame(NationalSpire.DateMemoryFrame, NationalSpire.DateSceneLine, string, bool, System.Collections.Generic.IReadOnlyDictionary<string, NationalSpire.DateMemoryPerson>, System.Func<string, Godot.Texture2D>)`；输入表达式：`_view.ShowMemoryFrame(page.Frame, page.Line, page.Name, page.Player, Memory.People, Texture)`；返回值紧邻使用处：`ExpressionStatementSyntax: _view.ShowMemoryFrame(page.Frame, page.Line, page.Name, page.Player, Memory.People, Texture);`

**赋值（含属性/字段和局部值）：**

- `Narration` = `true`
- `Text` = `"这份回忆中尚无对话记录。"`
- `_view.Status.Text` = `_warning.Length > 0 ? _warning : $"回忆 · {_index + 1}/{_pages.Count}"`
- `_warning` = `"回忆背景读取失败：" + e.Message`

<a id="symbol-1dd6f6d35fc8"></a>

## `NationalSpire.DateMemoryPlayback.Next() — private void Next()`

来源：源码第 130 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.DateMemoryPlayback.ShowPage()`](DateSceneMemoryPlayback.cs.md#symbol-cf0986d25dad)

**字段、属性、事件及方法组引用：** `NationalSpire.DateMemoryPlayback.ShowPage()`；`NationalSpire.DateMemoryPlayback._index`；`NationalSpire.DateMemoryPlayback._pages`；`NationalSpire.DateMemoryPlayback._view`；`NationalSpire.DateSceneView.Status`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateMemoryPlayback.ShowPage()`；输入表达式：`ShowPage()`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowPage();`

**赋值（含属性/字段和局部值）：**

- `_view.Status.Text` = `"回忆已播放完毕 · 可从头回看或返回日记"`

<a id="symbol-b888e2863847"></a>

## `NationalSpire.DateMemoryPlayback.History() — private string History()`

来源：源码第 135 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`](DateSceneData.cs.md#symbol-711ab692d366)；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Text.StringBuilder.AppendLine()`；`System.Text.StringBuilder.AppendLine(string?)`；`System.Text.StringBuilder.StringBuilder()`；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateMemoryPlayback._index`；`NationalSpire.DateMemoryPlayback._pages`；`NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`；输入表达式：`DateScenes.DisplayText(page.Line)`；返回值紧邻使用处：`ArgumentSyntax: DateScenes.DisplayText(page.Line)`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`_pages.Take(_index + 1)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var page in _pages.Take(_index + 1)) text.AppendLine(page.Name.Length > 0 ? page.Name : "旁白").AppendLine(DateScenes.DisplayText(page.Line)).AppendLine();`
- `System.Text.StringBuilder.AppendLine()`；输入表达式：`text.AppendLine(page.Name.Length > 0 ? page.Name : "旁白").AppendLine(DateScenes.DisplayText(page.Line)).AppendLine()`；返回值紧邻使用处：`ExpressionStatementSyntax: text.AppendLine(page.Name.Length > 0 ? page.Name : "旁白").AppendLine(DateScenes.DisplayText(page.Line)).AppendLine();`
- `System.Text.StringBuilder.AppendLine(string?)`；输入表达式：`text.AppendLine(page.Name.Length > 0 ? page.Name : "旁白")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.AppendLine(page.Name.Length > 0 ? page.Name : "旁白").AppendLine`
- `System.Text.StringBuilder.AppendLine(string?)`；输入表达式：`text.AppendLine(page.Name.Length > 0 ? page.Name : "旁白").AppendLine(DateScenes.DisplayText(page.Line))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.AppendLine(page.Name.Length > 0 ? page.Name : "旁白").AppendLine(DateScenes.DisplayText(page.Line)).AppendLine`
- `System.Text.StringBuilder.StringBuilder()`；输入表达式：`new StringBuilder()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StringBuilder()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`text.ToString()`；返回值紧邻使用处：`ReturnStatementSyntax: return text.ToString();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-095d68561b37"></a>

## `NationalSpire.DateMemoryPlayback.HistoryEntries() — private IReadOnlyList<DateHistoryEntry> HistoryEntries()`

来源：源码第 141 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `NationalSpire.DateHistoryEntry.DateHistoryEntry(string, string, bool)`；[`NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`](DateSceneData.cs.md#symbol-711ab692d366)；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateMemoryPlayback._index`；`NationalSpire.DateMemoryPlayback._pages`；`NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateHistoryEntry.DateHistoryEntry(string, string, bool)`；输入表达式：`new DateHistoryEntry(g.Key.Turn, string.Join("\n\n", g.Select(p => (p.Name.Length > 0 ? p.Name : "旁白") + "\n" + DateScenes.DisplayText(p.Line))), !g.Key.Player)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => new DateHistoryEntry(g.Key.Turn, string.Join("\n\n", g.Select(p => (p.Name.Length > 0 ? p.Name : "旁白") + "\n" + DateScenes.DisplayText(p.Line))), !g.Key.Player)`
- `NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`；输入表达式：`DateScenes.DisplayText(p.Line)`；返回值紧邻使用处：`BinaryExpressionSyntax: (p.Name.Length > 0 ? p.Name : "旁白") + "\n" + DateScenes.DisplayText(p.Line)`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`_pages.Take(_index + 1) .GroupBy(p => (p.Turn, p.Player))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _pages.Take(_index + 1) .GroupBy(p => (p.Turn, p.Player)).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`_pages.Take(_index + 1) .GroupBy(p => (p.Turn, p.Player)).Select(g => new DateHistoryEntry(g.Key.Turn, string.Join("\n\n", g.Select(p => (p.Name.Length > 0 ? p.Name : "旁白") + "\n" + DateScenes.DisplayText(p.Line))), !g.Key.Player))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _pages.Take(_index + 1) .GroupBy(p => (p.Turn, p.Player)).Select(g => new DateHistoryEntry(g.Key.Turn, string.Join("\n\n", g.Select(p => (p.Name.Length > 0 ? p.Name : "旁白") + "\n" + DateScenes.DisplayText(p.Line))), !g.Key.Player)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`g.Select(p => (p.Name.Length > 0 ? p.Name : "旁白") + "\n" + DateScenes.DisplayText(p.Line))`；返回值紧邻使用处：`ArgumentSyntax: g.Select(p => (p.Name.Length > 0 ? p.Name : "旁白") + "\n" + DateScenes.DisplayText(p.Line))`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`_pages.Take(_index + 1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _pages.Take(_index + 1) .GroupBy`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`_pages.Take(_index + 1) .GroupBy(p => (p.Turn, p.Player)).Select(g => new DateHistoryEntry(g.Key.Turn, string.Join("\n\n", g.Select(p => (p.Name.Length > 0 ? p.Name : "旁白") + "\n" + DateScenes.DisplayText(p.Line))), !g.Key.Player)).ToList()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => _pages.Take(_index + 1) .GroupBy(p => (p.Turn, p.Player)).Select(g => new DateHistoryEntry(g.Key.Turn, string.Join("\n\n", g.Select(p => (p.Name.Length > 0 ? p.Name : "旁白") + "\n" + DateScenes.DisplayText(p.Line))), !g.Key.Player)).ToList()`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n\n", g.Select(p => (p.Name.Length > 0 ? p.Name : "旁白") + "\n" + DateScenes.DisplayText(p.Line)))`；返回值紧邻使用处：`ArgumentSyntax: string.Join("\n\n", g.Select(p => (p.Name.Length > 0 ? p.Name : "旁白") + "\n" + DateScenes.DisplayText(p.Line)))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9343ac064a30"></a>

## `NationalSpire.DateMemoryPlayback.RefreshHistory() — public void RefreshHistory()`

来源：源码第 144 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.DateMemoryPlayback.BuildPages()`](DateSceneMemoryPlayback.cs.md#symbol-e09e5b7ddabe)；[`NationalSpire.DateMemoryPlayback.ShowPage()`](DateSceneMemoryPlayback.cs.md#symbol-cf0986d25dad)；[`NationalSpire.DateSceneView.RefreshHistory(bool)`](DateSceneView.cs.md#symbol-0762d57cebb4)；`System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；`System.Math.Clamp(int, int, int)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateMemoryPlayback.BuildPages()`；`NationalSpire.DateMemoryPlayback.ShowPage()`；`NationalSpire.DateMemoryPlayback._index`；`NationalSpire.DateMemoryPlayback._pages`；`NationalSpire.DateMemoryPlayback._view`；`NationalSpire.DateSceneView.RefreshHistory(bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateMemoryPlayback.BuildPages()`；输入表达式：`BuildPages()`；返回值紧邻使用处：`ExpressionStatementSyntax: BuildPages();`
- `NationalSpire.DateMemoryPlayback.ShowPage()`；输入表达式：`ShowPage()`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowPage();`
- `NationalSpire.DateSceneView.RefreshHistory(bool)`；输入表达式：`_view.RefreshHistory()`；返回值紧邻使用处：`ExpressionStatementSyntax: _view.RefreshHistory();`
- `System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；输入表达式：`_pages.FindIndex(p => (p.Turn, p.Index) == anchor)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _pages.FindIndex(p => (p.Turn, p.Index) == anchor)`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(_index, 0, Math.Max(0, _pages.Count - 1))`；返回值紧邻使用处：`ConditionalExpressionSyntax: found >= 0 ? found : Math.Clamp(_index, 0, Math.Max(0, _pages.Count - 1))`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, _pages.Count - 1)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, _pages.Count - 1)`

**赋值（含属性/字段和局部值）：**

- `_index` = `found >= 0 ? found : Math.Clamp(_index, 0, Math.Max(0, _pages.Count - 1))`

<a id="symbol-c036240ab245"></a>

## `NationalSpire.DateMemoryPlayback.GoBack() — public void GoBack()`

来源：源码第 151 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen._Input(Godot.InputEvent)`](CareerScreen.cs.md#symbol-a9891646fd75)

**调用：** [`NationalSpire.DateSceneView.GoBack()`](DateSceneView.cs.md#symbol-c97afbe9881b)

**字段、属性、事件及方法组引用：** `NationalSpire.DateMemoryPlayback._view`；`NationalSpire.DateSceneView.GoBack()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneView.GoBack()`；输入表达式：`_view.GoBack()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => _view.GoBack()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c283d55da133"></a>

## `NationalSpire.DateMemoryPlayback.Close() — public void Close()`

来源：源码第 152 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.Hide()`；`Godot.Node.QueueFree()`；`System.Action.Invoke()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateMemoryPlayback.Closed`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: Hide();`
- `Godot.Node.QueueFree()`；输入表达式：`QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueFree();`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Closed?.Invoke()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-726a271afdd2"></a>

## `NationalSpire.DateMemoryPlayback._ExitTree() — public override void _ExitTree()`

来源：源码第 153 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.GodotObject.Dispose()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateMemoryPlayback._textures`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.Dispose()`；输入表达式：`texture.Dispose()`；返回值紧邻使用处：`ExpressionStatementSyntax: texture.Dispose();`

**赋值（含属性/字段和局部值）：**
