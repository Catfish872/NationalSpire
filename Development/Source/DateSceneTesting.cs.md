# DateSceneTesting.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`53390573352E02EAF6F677EE413A7988046F7E6D3C4217794A6AC49C735EA1A5`。来源：[源码](../../DateSceneTesting.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.DateSceneTesting`、`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
public Action? Closed;
private DateSceneView _view = null!;
private DateSceneRequest _request = new();
private readonly Dictionary<string, Dictionary<string, List<Texture2D>>> _textures = [];
private readonly List<Texture2D> _owned = [];
private readonly StringBuilder _history = new();
private PrivateStreamParser _parser = new();
private List<DateSceneLine> _lines = [];
private string _pending = "";
private int _received, _index, _round;
private double _clock;
private bool _complete;
private string _lastInput = "";
private int _roundHistoryStart;
private bool _editing;
private DateSceneTesting? _testDateScene;
```

<a id="symbol-91667df79532"></a>

## `NationalSpire.DateSceneTesting.Initialize(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>) — public void Initialize(CareerData data, IReadOnlyList<string> people)`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.TestDateScenePicker()`](DateSceneTesting.cs.md#symbol-c1c7664de97e)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.DateDefaultPortraits.Texture(NationalSpire.CareerData, string)`](DateDefaultPortraits.cs.md#symbol-5c7df7a4e40d)；[`NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`](DateSceneAssets.cs.md#symbol-57fe620f4cc9)；[`NationalSpire.DateSceneAssetStore.Ready(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign?)`](DateSceneAssets.cs.md#symbol-79425fed4748)；[`NationalSpire.DateSceneAssetStore.SpriteKeys(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string)`](DateSceneAssets.cs.md#symbol-3b48b221efd8)；[`NationalSpire.DateSceneAssetStore.Texture(string, bool)`](DateSceneAssets.cs.md#symbol-616d47ee9d6a)；`NationalSpire.DateSceneParticipant.DateSceneParticipant()`；[`NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`](PortraitDesignStore.cs.md#symbol-8db102d73ed8)；[`NationalSpire.PortraitDesignStore.Read(string, string)`](PortraitDesignStore.cs.md#symbol-2eeba99f517d)；`System.ArgumentException.ArgumentException(string?)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.DateDefaultPortraits.Texture(NationalSpire.CareerData, string)`；`NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`；`NationalSpire.DateSceneAssetStore.Ready(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign?)`；`NationalSpire.DateSceneAssetStore.SpriteKeys(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string)`；`NationalSpire.DateSceneAssetStore.Texture(string, bool)`；`NationalSpire.DateSceneAssets.OutfitId`；`NationalSpire.DateSceneAssets.Sprites`；`NationalSpire.DateSceneAssets.UseDefaultPortrait`；`NationalSpire.DateSceneParticipant.DefaultEmotionId`；`NationalSpire.DateSceneParticipant.Emotions`；`NationalSpire.DateSceneParticipant.Name`；`NationalSpire.DateSceneParticipant.OutfitId`；`NationalSpire.DateSceneParticipant.PersonId`；`NationalSpire.DateSceneRequest.DefaultEmotionId`；`NationalSpire.DateSceneRequest.Emotions`；`NationalSpire.DateSceneRequest.Participants`；`NationalSpire.DateSceneTesting._owned`；`NationalSpire.DateSceneTesting._request`；`NationalSpire.DateSceneTesting._textures`；`NationalSpire.PortraitDesign.DefaultEmotionId`；`NationalSpire.PortraitDesign.Emotions`；`NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`；`NationalSpire.PortraitDesignStore.Read(string, string)`；`NationalSpire.PortraitEmotion.Enabled`；`NationalSpire.PortraitEmotion.Id`；`NationalSpire.PortraitEmotion.Name`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, person)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Name = CareerEngine.DisplayName(data, person)`
- `NationalSpire.DateDefaultPortraits.Texture(NationalSpire.CareerData, string)`；输入表达式：`DateDefaultPortraits.Texture(data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateDefaultPortraits.Texture(data, person)`
- `NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`；输入表达式：`DateSceneAssetStore.Read(data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateSceneAssetStore.Read(data, person)`
- `NationalSpire.DateSceneAssetStore.Ready(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign?)`；输入表达式：`DateSceneAssetStore.Ready(assets, design)`；返回值紧邻使用处：`BinaryExpressionSyntax: DateSceneAssetStore.Ready(assets, design) == null`
- `NationalSpire.DateSceneAssetStore.SpriteKeys(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string)`；输入表达式：`DateSceneAssetStore.SpriteKeys(assets, design, emotion.Id)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string key in DateSceneAssetStore.SpriteKeys(assets, design, emotion.Id)) try { var image = DateSceneAssetStore.Texture(assets.Sprites[key]); loaded.Add(image); _owned.Add(image); } catch { }`
- `NationalSpire.DateSceneAssetStore.Texture(string, bool)`；输入表达式：`DateSceneAssetStore.Texture(assets.Sprites[key])`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateSceneAssetStore.Texture(assets.Sprites[key])`
- `NationalSpire.DateSceneParticipant.DateSceneParticipant()`；输入表达式：`new DateSceneParticipant { PersonId = person, Name = CareerEngine.DisplayName(data, person), Emotions = new() { ["neutral"] = "平淡", ["excited"] = "兴奋" } }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new DateSceneParticipant { PersonId = person, Name = CareerEngine.DisplayName(data, person), Emotions = new() { ["neutral"] = "平淡", ["excited"] = "兴奋" } }`
- `NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`；输入表达式：`PortraitDesignStore.FilePath(data, person)`；返回值紧邻使用处：`ArgumentSyntax: PortraitDesignStore.FilePath(data, person)`
- `NationalSpire.PortraitDesignStore.Read(string, string)`；输入表达式：`PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person)`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("请选择至少一名角色。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("请选择至少一名角色。");`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`member.Emotions.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: member.Emotions.Clear();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`images.ContainsKey(member.DefaultEmotionId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !images.ContainsKey(member.DefaultEmotionId)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, List<Texture2D>>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, List<Texture2D>>()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new() { ["neutral"] = "平淡", ["excited"] = "兴奋" }`；返回值紧邻使用处：`AssignmentExpressionSyntax: Emotions = new() { ["neutral"] = "平淡", ["excited"] = "兴奋" }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new() { ["neutral"] = "平淡", ["excited"] = "兴奋" }`；返回值紧邻使用处：`AssignmentExpressionSyntax: member.Emotions = new() { ["neutral"] = "平淡", ["excited"] = "兴奋" }`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`people.Distinct()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string person in people.Distinct()) { var member = new DateSceneParticipant { PersonId = person, Name = CareerEngine.DisplayName(data, person), Emotions = new() { ["neutral"] = "平淡", ["excited"] = "兴奋" } }; var images = new Dictionary<string, List<Texture2D>>(); try { var design = PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person); var assets = DateSceneAssetStore.Read(data, person); if (!assets.UseDefaultPortrait && design != null && DateSceneAssetStore.Ready(assets, design) == null) { member.DefaultEmotionId = design.DefaultEmotionId; member.OutfitId = assets.OutfitId; member.Emotions.Clear(); foreach (var emotion in design.Emotions.Where(e => e.Enabled)) { var loaded = new List<Texture2D>(); foreach (string key in DateSceneAssetStore.SpriteKeys(assets, design, emotion.Id)) try { var image = DateSceneAssetStore.Texture(assets.Sprites[key]); loaded.Add(image); _owned.Add(image); } catch { } if (loaded.Count > 0) { images[emotion.Id] = loaded; member.Emotions[emotion.Id] = emotion.Name; } } } } catch { } if (!images.ContainsKey(member.DefaultEmotionId)) { member.DefaultEmotionId = "neutral"; member.Emotions = new() { ["neutral"] = "平淡", ["excited"] = "兴奋" }; var texture = DateDefaultPortraits.Texture(data, person); _owned.Add(texture); images["neutral"] = [texture]; images["excited"] = [texture]; } _request.Participants.Add(member); _textures[person] = images; }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`design.Emotions.Where(e => e.Enabled)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var emotion in design.Emotions.Where(e => e.Enabled)) { var loaded = new List<Texture2D>(); foreach (string key in DateSceneAssetStore.SpriteKeys(assets, design, emotion.Id)) try { var image = DateSceneAssetStore.Texture(assets.Sprites[key]); loaded.Add(image); _owned.Add(image); } catch { } if (loaded.Count > 0) { images[emotion.Id] = loaded; member.Emotions[emotion.Id] = emotion.Name; } }`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`_owned.Add(image)`；返回值紧邻使用处：`ExpressionStatementSyntax: _owned.Add(image);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`_owned.Add(texture)`；返回值紧邻使用处：`ExpressionStatementSyntax: _owned.Add(texture);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`_request.Participants.Add(member)`；返回值紧邻使用处：`ExpressionStatementSyntax: _request.Participants.Add(member);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`loaded.Add(image)`；返回值紧邻使用处：`ExpressionStatementSyntax: loaded.Add(image);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<Texture2D>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<Texture2D>()`

**赋值（含属性/字段和局部值）：**

- `Emotions` = `new() { ["neutral"] = "平淡", ["excited"] = "兴奋" }`
- `Name` = `CareerEngine.DisplayName(data, person)`
- `PersonId` = `person`
- `["excited"]` = `"兴奋"`
- `["neutral"]` = `"平淡"`
- `_request.DefaultEmotionId` = `first.DefaultEmotionId`
- `_request.Emotions` = `first.Emotions`
- `_textures[person]` = `images`
- `images["excited"]` = `[texture]`
- `images["neutral"]` = `[texture]`
- `images[emotion.Id]` = `loaded`
- `member.DefaultEmotionId` = `"neutral"`
- `member.DefaultEmotionId` = `design.DefaultEmotionId`
- `member.Emotions[emotion.Id]` = `emotion.Name`
- `member.Emotions` = `new() { ["neutral"] = "平淡", ["excited"] = "兴奋" }`
- `member.OutfitId` = `assets.OutfitId`

<a id="symbol-b985fcb2f0ac"></a>

## `NationalSpire.DateSceneTesting.Texture(string, string) — private Texture2D Texture(string person, string emotion)`

来源：源码第 58 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneTesting.Show()`](DateSceneTesting.cs.md#symbol-ea6d8bf11dd7)；[`NationalSpire.DateSceneTesting._Process(double)`](DateSceneTesting.cs.md#symbol-e5cbbec1bb0d)；[`NationalSpire.DateSceneTesting._Ready()`](DateSceneTesting.cs.md#symbol-2174d0446f18)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Random.Next(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneParticipant.DefaultEmotionId`；`NationalSpire.DateSceneParticipant.PersonId`；`NationalSpire.DateSceneRequest.Participants`；`NationalSpire.DateSceneTesting._request`；`NationalSpire.DateSceneTesting._textures`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`_request.Participants.First(p => p.PersonId == person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _request.Participants.First(p => p.PersonId == person)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`_textures[person].GetValueOrDefault(emotion)`；返回值紧邻使用处：`BinaryExpressionSyntax: _textures[person].GetValueOrDefault(emotion) ?? _textures[person][member.DefaultEmotionId]`
- `System.Random.Next(int)`；输入表达式：`Random.Shared.Next(options.Count)`；返回值紧邻使用处：`ArgumentSyntax: Random.Shared.Next(options.Count)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2174d0446f18"></a>

## `NationalSpire.DateSceneTesting._Ready() — public override void _Ready()`

来源：源码第 63 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`NationalSpire.DateSceneCast.DateSceneCast(string, string, System.Func<Godot.Texture2D>)`；[`NationalSpire.DateSceneTesting.Generate(string)`](DateSceneTesting.cs.md#symbol-970e66145f4d)；[`NationalSpire.DateSceneTesting.Texture(string, string)`](DateSceneTesting.cs.md#symbol-b985fcb2f0ac)；`NationalSpire.DateSceneView.DateSceneView()`；[`NationalSpire.DateSceneView.Relationship(NationalSpire.PrivateRelation, string, bool)`](DateSceneView.cs.md#symbol-949c1add6c05)；[`NationalSpire.DateSceneView.SetCast(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneCast>)`](DateSceneCast.cs.md#symbol-913514fd78e1)；`NationalSpire.PrivateRelation.PrivateRelation()`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneParticipant.DefaultEmotionId`；`NationalSpire.DateSceneParticipant.Name`；`NationalSpire.DateSceneParticipant.PersonId`；`NationalSpire.DateSceneRequest.Participants`；`NationalSpire.DateSceneTesting.Advance()`；`NationalSpire.DateSceneTesting.Close()`；`NationalSpire.DateSceneTesting.EditPreviousInput()`；`NationalSpire.DateSceneTesting.Generate(string)`；`NationalSpire.DateSceneTesting.Send()`；`NationalSpire.DateSceneTesting.Texture(string, string)`；`NationalSpire.DateSceneTesting._history`；`NationalSpire.DateSceneTesting._owned`；`NationalSpire.DateSceneTesting._request`；`NationalSpire.DateSceneTesting._textures`；`NationalSpire.DateSceneTesting._view`；`NationalSpire.DateSceneView.AddAttachment`；`NationalSpire.DateSceneView.Advance`；`NationalSpire.DateSceneView.EditPrevious`；`NationalSpire.DateSceneView.Exit`；`NationalSpire.DateSceneView.HistoryText`；`NationalSpire.DateSceneView.InstantSpeed`；`NationalSpire.DateSceneView.Relationship(NationalSpire.PrivateRelation, string, bool)`；`NationalSpire.DateSceneView.RetryStop`；`NationalSpire.DateSceneView.SetCast(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneCast>)`；`NationalSpire.DateSceneView.Settings`；`NationalSpire.DateSceneView.Status`；`NationalSpire.DateSceneView.Submit`；`NationalSpire.DateSceneView.TextSpeed`；`NationalSpire.DateSceneView.WaitingDefault`；`NationalSpire.DateSceneView.WaitingPortraits`；`NationalSpire.DateSceneView.WaitingSprites`；`NationalSpire.PrivateRelation.Favour`；`NationalSpire.PrivateRelation.Relationship`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`_view.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: _view.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(_view)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(_view);`
- `NationalSpire.DateSceneCast.DateSceneCast(string, string, System.Func<Godot.Texture2D>)`；输入表达式：`new DateSceneCast(p.PersonId, p.Name, () => Texture(p.PersonId, p.DefaultEmotionId))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => new DateSceneCast(p.PersonId, p.Name, () => Texture(p.PersonId, p.DefaultEmotionId))`
- `NationalSpire.DateSceneTesting.Generate(string)`；输入表达式：`Generate("开场")`；返回值紧邻使用处：`ExpressionStatementSyntax: Generate("开场");`
- `NationalSpire.DateSceneTesting.Generate(string)`；输入表达式：`Generate("重新测试")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Generate("重新测试")`
- `NationalSpire.DateSceneTesting.Texture(string, string)`；输入表达式：`Texture(first.PersonId, first.DefaultEmotionId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Texture(first.PersonId, first.DefaultEmotionId)`
- `NationalSpire.DateSceneTesting.Texture(string, string)`；输入表达式：`Texture(p.PersonId, p.DefaultEmotionId)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Texture(p.PersonId, p.DefaultEmotionId)`
- `NationalSpire.DateSceneView.DateSceneView()`；输入表达式：`new() { WaitingDefault = initial, WaitingSprites = _owned, Exit = Close, Submit = Send, Advance = Advance, HistoryText = () => _history.ToString(), RetryStop = () => Generate("重新测试"), EditPrevious = EditPreviousInput, Settings = () => { _view!.TextSpeed = _view.TextSpeed == DateSceneView.InstantSpeed ? 75 : DateSceneView.InstantSpeed; _view.Status.Text = "测试字速已切换；Esc结束测试。"; } }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _view = new() { WaitingDefault = initial, WaitingSprites = _owned, Exit = Close, Submit = Send, Advance = Advance, HistoryText = () => _history.ToString(), RetryStop = () => Generate("重新测试"), EditPrevious = EditPreviousInput, Settings = () => { _view!.TextSpeed = _view.TextSpeed == DateSceneView.InstantSpeed ? 75 : DateSceneView.InstantSpeed; _view.Status.Text = "测试字速已切换；Esc结束测试。"; } }`
- `NationalSpire.DateSceneView.Relationship(NationalSpire.PrivateRelation, string, bool)`；输入表达式：`_view.Relationship(new PrivateRelation { Favour = 30, Relationship = "测试关系" })`；返回值紧邻使用处：`ExpressionStatementSyntax: _view.Relationship(new PrivateRelation { Favour = 30, Relationship = "测试关系" });`
- `NationalSpire.DateSceneView.SetCast(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneCast>)`；输入表达式：`_view.SetCast(_request.Participants.Select(p => new DateSceneCast(p.PersonId, p.Name, () => Texture(p.PersonId, p.DefaultEmotionId))))`；返回值紧邻使用处：`ExpressionStatementSyntax: _view.SetCast(_request.Participants.Select(p => new DateSceneCast(p.PersonId, p.Name, () => Texture(p.PersonId, p.DefaultEmotionId))));`
- `NationalSpire.PrivateRelation.PrivateRelation()`；输入表达式：`new PrivateRelation { Favour = 30, Relationship = "测试关系" }`；返回值紧邻使用处：`ArgumentSyntax: new PrivateRelation { Favour = 30, Relationship = "测试关系" }`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`_textures.GetValueOrDefault(person, _textures[first.PersonId]).Values.SelectMany(x => x).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _textures.GetValueOrDefault(person, _textures[first.PersonId]).Values.SelectMany(x => x).Distinct().ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`_request.Participants.Select(p => new DateSceneCast(p.PersonId, p.Name, () => Texture(p.PersonId, p.DefaultEmotionId)))`；返回值紧邻使用处：`ArgumentSyntax: _request.Participants.Select(p => new DateSceneCast(p.PersonId, p.Name, () => Texture(p.PersonId, p.DefaultEmotionId)))`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`_textures.GetValueOrDefault(person, _textures[first.PersonId]).Values.SelectMany(x => x)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _textures.GetValueOrDefault(person, _textures[first.PersonId]).Values.SelectMany(x => x).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`_textures.GetValueOrDefault(person, _textures[first.PersonId]).Values.SelectMany(x => x).Distinct().ToList()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: person => _textures.GetValueOrDefault(person, _textures[first.PersonId]).Values.SelectMany(x => x).Distinct().ToList()`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`_textures.GetValueOrDefault(person, _textures[first.PersonId])`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _textures.GetValueOrDefault(person, _textures[first.PersonId]).Values`
- `System.Text.StringBuilder.ToString()`；输入表达式：`_history.ToString()`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => _history.ToString()`

**赋值（含属性/字段和局部值）：**

- `Advance` = `Advance`
- `EditPrevious` = `EditPreviousInput`
- `Exit` = `Close`
- `Favour` = `30`
- `HistoryText` = `() => _history.ToString()`
- `MouseFilter` = `MouseFilterEnum.Stop`
- `Name` = `"DeveloperDateTest"`
- `Relationship` = `"测试关系"`
- `RetryStop` = `() => Generate("重新测试")`
- `Settings` = `() => { _view!.TextSpeed = _view.TextSpeed == DateSceneView.InstantSpeed ? 75 : DateSceneView.InstantSpeed; _view.Status.Text = "测试字速已切换；Esc结束测试。"; }`
- `Submit` = `Send`
- `WaitingDefault` = `initial`
- `WaitingSprites` = `_owned`
- `ZIndex` = `60`
- `_view!.TextSpeed` = `_view.TextSpeed == DateSceneView.InstantSpeed ? 75 : DateSceneView.InstantSpeed`
- `_view.AddAttachment` = `() => _view.Status.Text = "测试约会使用本地台词，附件在正式约会中使用。"`
- `_view.Status.Text` = `"测试字速已切换；Esc结束测试。"`
- `_view.Status.Text` = `"测试约会使用本地台词，附件在正式约会中使用。"`
- `_view.WaitingPortraits` = `person => _textures.GetValueOrDefault(person, _textures[first.PersonId]).Values.SelectMany(x => x).Distinct().ToList()`
- `_view` = `new() { WaitingDefault = initial, WaitingSprites = _owned, Exit = Close, Submit = Send, Advance = Advance, HistoryText = () => _history.ToString(), RetryStop = () => Generate("重新测试"), EditPrevious = EditPreviousInput, Settings = () => { _view!.TextSpeed = _view.TextSpeed == DateSceneView.InstantSpeed ? 75 : DateSceneView.InstantSpeed; _view.Status.Text = "测试字速已切换；Esc结束测试。"; } }`

<a id="symbol-f97c641d8299"></a>

## `NationalSpire.DateSceneTesting.Send() — private void Send()`

来源：源码第 78 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.DateSceneTesting.SendInput(string)`](DateSceneTesting.cs.md#symbol-50e8157d7635)；`string.IsNullOrWhiteSpace(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneTesting.SendInput(string)`；`NationalSpire.DateSceneTesting._view`；`NationalSpire.DateSceneView.Editor`；`NationalSpire.DateSceneView.InputMode`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneTesting.SendInput(string)`；输入表达式：`SendInput(_view.Editor.Text)`；返回值紧邻使用处：`ExpressionStatementSyntax: SendInput(_view.Editor.Text);`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(_view.Editor.Text)`；返回值紧邻使用处：`BinaryExpressionSyntax: !_view.InputMode || string.IsNullOrWhiteSpace(_view.Editor.Text)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-50e8157d7635"></a>

## `NationalSpire.DateSceneTesting.SendInput(string) — private void SendInput(string text)`

来源：源码第 83 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneTesting.Send()`](DateSceneTesting.cs.md#symbol-f97c641d8299)；[`NationalSpire.DateSceneTesting.Show()`](DateSceneTesting.cs.md#symbol-ea6d8bf11dd7)

**调用：** [`NationalSpire.DateSceneTesting.Generate(string)`](DateSceneTesting.cs.md#symbol-970e66145f4d)；`System.Text.StringBuilder.AppendLine()`；`System.Text.StringBuilder.AppendLine(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneTesting.Generate(string)`；`NationalSpire.DateSceneTesting._editing`；`NationalSpire.DateSceneTesting._history`；`NationalSpire.DateSceneTesting._lastInput`；`NationalSpire.DateSceneTesting._roundHistoryStart`；`NationalSpire.DateSceneTesting._view`；`NationalSpire.DateSceneView.Editor`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneTesting.Generate(string)`；输入表达式：`Generate(text)`；返回值紧邻使用处：`ExpressionStatementSyntax: Generate(text);`
- `System.Text.StringBuilder.AppendLine()`；输入表达式：`_history.AppendLine("玩家").AppendLine(text).AppendLine()`；返回值紧邻使用处：`ExpressionStatementSyntax: _history.AppendLine("玩家").AppendLine(text).AppendLine();`
- `System.Text.StringBuilder.AppendLine(string?)`；输入表达式：`_history.AppendLine("玩家")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _history.AppendLine("玩家").AppendLine`
- `System.Text.StringBuilder.AppendLine(string?)`；输入表达式：`_history.AppendLine("玩家").AppendLine(text)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _history.AppendLine("玩家").AppendLine(text).AppendLine`

**赋值（含属性/字段和局部值）：**

- `_editing` = `false`
- `_history.Length` = `_roundHistoryStart`
- `_lastInput` = `text`
- `_roundHistoryStart` = `_history.Length`
- `_view.Editor.Text` = `""`

<a id="symbol-4e7bc34c63a1"></a>

## `NationalSpire.DateSceneTesting.EditPreviousInput() — private void EditPreviousInput()`

来源：源码第 89 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.TextEdit.GetCaretLine(int)`；`Godot.TextEdit.GetLine(int)`；`Godot.TextEdit.GetLineCount()`；`Godot.TextEdit.SetCaretColumn(int, bool, int)`；`Godot.TextEdit.SetCaretLine(int, bool, bool, int, int)`；[`NationalSpire.DateSceneView.ShowInput(string, bool, bool)`](DateSceneView.cs.md#symbol-4f0d075ed97b)

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneTesting._complete`；`NationalSpire.DateSceneTesting._editing`；`NationalSpire.DateSceneTesting._lastInput`；`NationalSpire.DateSceneTesting._view`；`NationalSpire.DateSceneView.Editor`；`NationalSpire.DateSceneView.ShowInput(string, bool, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.TextEdit.GetCaretLine(int)`；输入表达式：`_view.Editor.GetCaretLine()`；返回值紧邻使用处：`ArgumentSyntax: _view.Editor.GetCaretLine()`
- `Godot.TextEdit.GetLine(int)`；输入表达式：`_view.Editor.GetLine(_view.Editor.GetCaretLine())`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _view.Editor.GetLine(_view.Editor.GetCaretLine()).Length`
- `Godot.TextEdit.GetLineCount()`；输入表达式：`_view.Editor.GetLineCount()`；返回值紧邻使用处：`BinaryExpressionSyntax: _view.Editor.GetLineCount() - 1`
- `Godot.TextEdit.SetCaretColumn(int, bool, int)`；输入表达式：`_view.Editor.SetCaretColumn(_view.Editor.GetLine(_view.Editor.GetCaretLine()).Length)`；返回值紧邻使用处：`ExpressionStatementSyntax: _view.Editor.SetCaretColumn(_view.Editor.GetLine(_view.Editor.GetCaretLine()).Length);`
- `Godot.TextEdit.SetCaretLine(int, bool, bool, int, int)`；输入表达式：`_view.Editor.SetCaretLine(_view.Editor.GetLineCount() - 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: _view.Editor.SetCaretLine(_view.Editor.GetLineCount() - 1);`
- `NationalSpire.DateSceneView.ShowInput(string, bool, bool)`；输入表达式：`_view.ShowInput("玩家 · 测试约会", showChoices: false)`；返回值紧邻使用处：`ExpressionStatementSyntax: _view.ShowInput("玩家 · 测试约会", showChoices: false);`

**赋值（含属性/字段和局部值）：**

- `_editing` = `true`
- `_view.Editor.Text` = `_lastInput`

<a id="symbol-970e66145f4d"></a>

## `NationalSpire.DateSceneTesting.Generate(string) — private void Generate(string input)`

来源：源码第 96 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneTesting.SendInput(string)`](DateSceneTesting.cs.md#symbol-50e8157d7635)；[`NationalSpire.DateSceneTesting._Ready()`](DateSceneTesting.cs.md#symbol-2174d0446f18)

**调用：** [`NationalSpire.DateSceneView.ShowWaiting(string, bool)`](DateSceneView.cs.md#symbol-c6c25a66fde3)；[`NationalSpire.PrivateStreamParser.PrivateStreamParser(params string[])`](PrivateMessages.cs.md#symbol-af0a0ba2ac6c)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.List<T>.Clear()`；`System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；`System.Text.StringBuilder.StringBuilder(string?)`；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneParticipant.DefaultEmotionId`；`NationalSpire.DateSceneParticipant.Emotions`；`NationalSpire.DateSceneParticipant.PersonId`；`NationalSpire.DateSceneRequest.Participants`；`NationalSpire.DateSceneTesting._clock`；`NationalSpire.DateSceneTesting._complete`；`NationalSpire.DateSceneTesting._index`；`NationalSpire.DateSceneTesting._lines`；`NationalSpire.DateSceneTesting._parser`；`NationalSpire.DateSceneTesting._pending`；`NationalSpire.DateSceneTesting._received`；`NationalSpire.DateSceneTesting._request`；`NationalSpire.DateSceneTesting._round`；`NationalSpire.DateSceneTesting._view`；`NationalSpire.DateSceneView.ShowWaiting(string, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneView.ShowWaiting(string, bool)`；输入表达式：`_view.ShowWaiting("本地测试台词 · 模拟流式接收", false)`；返回值紧邻使用处：`ExpressionStatementSyntax: _view.ShowWaiting("本地测试台词 · 模拟流式接收", false);`
- `NationalSpire.PrivateStreamParser.PrivateStreamParser(params string[])`；输入表达式：`new()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _parser = new()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`p.Emotions.ContainsKey("excited")`；返回值紧邻使用处：`BinaryExpressionSyntax: exchange == 2 && p.Emotions.ContainsKey("excited")`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`_lines.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _lines.Clear();`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`script.AppendLine($"[Scene: dialogue, Speaker: {p.PersonId}, Emotion: {emotion}, Background: current]{phrases[i % phrases.Length][exchange]}")`；返回值紧邻使用处：`ExpressionStatementSyntax: script.AppendLine($"[Scene: dialogue, Speaker: {p.PersonId}, Emotion: {emotion}, Background: current]{phrases[i % phrases.Length][exchange]}");`
- `System.Text.StringBuilder.StringBuilder(string?)`；输入表达式：`new StringBuilder("[Scene: narration, Emotion: neutral, Background: current]（微风拂过树梢，大家在长椅旁坐下。）\n")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StringBuilder("[Scene: narration, Emotion: neutral, Background: current]（微风拂过树梢，大家在长椅旁坐下。）\n")`
- `System.Text.StringBuilder.ToString()`；输入表达式：`script.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _pending = script.ToString()`

**赋值（含属性/字段和局部值）：**

- `_clock` = `0`
- `_complete` = `false`
- `_index` = `_received = 0`
- `_parser` = `new()`
- `_pending` = `script.ToString()`
- `_received` = `0`

<a id="symbol-e5cbbec1bb0d"></a>

## `NationalSpire.DateSceneTesting._Process(double) — public override void _Process(double delta)`

来源：源码第 109 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.DateSceneTesting.Show()`](DateSceneTesting.cs.md#symbol-ea6d8bf11dd7)；[`NationalSpire.DateSceneTesting.Texture(string, string)`](DateSceneTesting.cs.md#symbol-b985fcb2f0ac)；[`NationalSpire.DateSceneView.AppendLine(System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, System.Func<(string Name, Godot.Texture2D Texture)>?)`](DateSceneView.cs.md#symbol-eecb2292c03b)；[`NationalSpire.DateSceneView.Streaming(bool)`](DateSceneView.cs.md#symbol-e7a96de3c199)；[`NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`](DateSceneData.cs.md#symbol-711ab692d366)；[`NationalSpire.DateScenes.TaggedLines(NationalSpire.PrivateStreamParser, NationalSpire.DateSceneRequest)`](DateSceneData.cs.md#symbol-00bcca1f004c)；[`NationalSpire.PrivateStreamParser.Feed(string)`](PrivateMessages.cs.md#symbol-f34e8e2406af)；[`NationalSpire.PrivateStreamParser.Finish()`](PrivateMessages.cs.md#symbol-90306db26d5a)；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Math.Min(int, int)`；`System.Text.StringBuilder.AppendLine()`；`System.Text.StringBuilder.AppendLine(string?)`；`string.Substring(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneLine.Emotion`；`NationalSpire.DateSceneLine.Narration`；`NationalSpire.DateSceneLine.Speaker`；`NationalSpire.DateSceneParticipant.Name`；`NationalSpire.DateSceneParticipant.PersonId`；`NationalSpire.DateSceneRequest.Participants`；`NationalSpire.DateSceneTesting.Show()`；`NationalSpire.DateSceneTesting.Texture(string, string)`；`NationalSpire.DateSceneTesting._clock`；`NationalSpire.DateSceneTesting._complete`；`NationalSpire.DateSceneTesting._editing`；`NationalSpire.DateSceneTesting._history`；`NationalSpire.DateSceneTesting._index`；`NationalSpire.DateSceneTesting._lastInput`；`NationalSpire.DateSceneTesting._lines`；`NationalSpire.DateSceneTesting._parser`；`NationalSpire.DateSceneTesting._pending`；`NationalSpire.DateSceneTesting._received`；`NationalSpire.DateSceneTesting._request`；`NationalSpire.DateSceneTesting._view`；`NationalSpire.DateSceneView.AppendLine(System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, System.Func<(string Name, Godot.Texture2D Texture)>?)`；`NationalSpire.DateSceneView.EditPreviousButton`；`NationalSpire.DateSceneView.Streaming(bool)`；`NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`；`NationalSpire.DateScenes.TaggedLines(NationalSpire.PrivateStreamParser, NationalSpire.DateSceneRequest)`；`NationalSpire.PrivateStreamParser.Feed(string)`；`NationalSpire.PrivateStreamParser.Finish()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneTesting.Show()`；输入表达式：`Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: Show();`
- `NationalSpire.DateSceneTesting.Texture(string, string)`；输入表达式：`Texture(person.PersonId, line.Emotion)`；返回值紧邻使用处：`ArgumentSyntax: Texture(person.PersonId, line.Emotion)`
- `NationalSpire.DateSceneView.AppendLine(System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, System.Func<(string Name, Godot.Texture2D Texture)>?)`；输入表达式：`_view.AppendLine(_lines, Math.Min(_index, _lines.Count - 1), () => { var person = _request.Participants.FirstOrDefault(p => p.PersonId == line.Speaker) ?? _request.Participants[0]; return (person.Name, Texture(person.PersonId, line.Emotion)); })`；返回值紧邻使用处：`ExpressionStatementSyntax: _view.AppendLine(_lines, Math.Min(_index, _lines.Count - 1), () => { var person = _request.Participants.FirstOrDefault(p => p.PersonId == line.Speaker) ?? _request.Participants[0]; return (person.Name, Texture(person.PersonId, line.Emotion)); });`
- `NationalSpire.DateSceneView.Streaming(bool)`；输入表达式：`_view.Streaming(!_complete)`；返回值紧邻使用处：`ExpressionStatementSyntax: _view.Streaming(!_complete);`
- `NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`；输入表达式：`DateScenes.DisplayText(line)`；返回值紧邻使用处：`ArgumentSyntax: DateScenes.DisplayText(line)`
- `NationalSpire.DateScenes.TaggedLines(NationalSpire.PrivateStreamParser, NationalSpire.DateSceneRequest)`；输入表达式：`DateScenes.TaggedLines(_parser, _request)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _lines = DateScenes.TaggedLines(_parser, _request)`
- `NationalSpire.PrivateStreamParser.Feed(string)`；输入表达式：`_parser.Feed(_pending.Substring(_received, count))`；返回值紧邻使用处：`ExpressionStatementSyntax: _parser.Feed(_pending.Substring(_received, count));`
- `NationalSpire.PrivateStreamParser.Finish()`；输入表达式：`_parser.Finish()`；返回值紧邻使用处：`ExpressionStatementSyntax: _parser.Finish();`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`_request.Participants.First(p => p.PersonId == line.Speaker)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _request.Participants.First(p => p.PersonId == line.Speaker).Name`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`_request.Participants.FirstOrDefault(p => p.PersonId == line.Speaker)`；返回值紧邻使用处：`BinaryExpressionSyntax: _request.Participants.FirstOrDefault(p => p.PersonId == line.Speaker) ?? _request.Participants[0]`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(18, _pending.Length - _received)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(18, _pending.Length - _received)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(_index, _lines.Count - 1)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(_index, _lines.Count - 1)`
- `System.Text.StringBuilder.AppendLine()`；输入表达式：`_history.AppendLine(line.Narration ? "旁白" : _request.Participants.First(p => p.PersonId == line.Speaker).Name).AppendLine(DateScenes.DisplayText(line)).AppendLine()`；返回值紧邻使用处：`ExpressionStatementSyntax: _history.AppendLine(line.Narration ? "旁白" : _request.Participants.First(p => p.PersonId == line.Speaker).Name).AppendLine(DateScenes.DisplayText(line)).AppendLine();`
- `System.Text.StringBuilder.AppendLine(string?)`；输入表达式：`_history.AppendLine(line.Narration ? "旁白" : _request.Participants.First(p => p.PersonId == line.Speaker).Name)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _history.AppendLine(line.Narration ? "旁白" : _request.Participants.First(p => p.PersonId == line.Speaker).Name).AppendLine`
- `System.Text.StringBuilder.AppendLine(string?)`；输入表达式：`_history.AppendLine(line.Narration ? "旁白" : _request.Participants.First(p => p.PersonId == line.Speaker).Name).AppendLine(DateScenes.DisplayText(line))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _history.AppendLine(line.Narration ? "旁白" : _request.Participants.First(p => p.PersonId == line.Speaker).Name).AppendLine(DateScenes.DisplayText(line)).AppendLine`
- `string.Substring(int, int)`；输入表达式：`_pending.Substring(_received, count)`；返回值紧邻使用处：`ArgumentSyntax: _pending.Substring(_received, count)`

**赋值（含属性/字段和局部值）：**

- `_clock` += `delta`
- `_clock` = `0`
- `_complete` = `_received == _pending.Length`
- `_lines` = `DateScenes.TaggedLines(_parser, _request)`
- `_received` += `count`
- `_view.EditPreviousButton.Disabled` = `!_complete || _lastInput.Length == 0 || _editing`

<a id="symbol-46fb71782844"></a>

## `NationalSpire.DateSceneTesting.Advance() — private void Advance()`

来源：源码第 134 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.DateSceneTesting.Show()`](DateSceneTesting.cs.md#symbol-ea6d8bf11dd7)

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneTesting.Show()`；`NationalSpire.DateSceneTesting._complete`；`NationalSpire.DateSceneTesting._index`；`NationalSpire.DateSceneTesting._lines`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneTesting.Show()`；输入表达式：`Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: Show();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ea6d8bf11dd7"></a>

## `NationalSpire.DateSceneTesting.Show() — private new void Show()`

来源：源码第 139 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneTesting.Advance()`](DateSceneTesting.cs.md#symbol-46fb71782844)；[`NationalSpire.DateSceneTesting._Process(double)`](DateSceneTesting.cs.md#symbol-e5cbbec1bb0d)

**调用：** [`NationalSpire.DateSceneTesting.SendInput(string)`](DateSceneTesting.cs.md#symbol-50e8157d7635)；[`NationalSpire.DateSceneTesting.Texture(string, string)`](DateSceneTesting.cs.md#symbol-b985fcb2f0ac)；[`NationalSpire.DateSceneView.SetReplyChoices(string, System.Action, string, System.Action)`](DateSceneView.cs.md#symbol-697ad465ef9e)；[`NationalSpire.DateSceneView.ShowInput(string, bool, bool)`](DateSceneView.cs.md#symbol-4f0d075ed97b)；[`NationalSpire.DateSceneView.ShowRoundLine(System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, string, Godot.Texture2D)`](DateSceneCast.cs.md#symbol-35177f2945fc)；[`NationalSpire.DateSceneView.Streaming(bool)`](DateSceneView.cs.md#symbol-e7a96de3c199)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneLine.Emotion`；`NationalSpire.DateSceneLine.Speaker`；`NationalSpire.DateSceneParticipant.Name`；`NationalSpire.DateSceneParticipant.PersonId`；`NationalSpire.DateSceneRequest.Participants`；`NationalSpire.DateSceneTesting.SendInput(string)`；`NationalSpire.DateSceneTesting.Texture(string, string)`；`NationalSpire.DateSceneTesting._complete`；`NationalSpire.DateSceneTesting._index`；`NationalSpire.DateSceneTesting._lines`；`NationalSpire.DateSceneTesting._request`；`NationalSpire.DateSceneTesting._view`；`NationalSpire.DateSceneView.SetReplyChoices(string, System.Action, string, System.Action)`；`NationalSpire.DateSceneView.ShowInput(string, bool, bool)`；`NationalSpire.DateSceneView.ShowRoundLine(System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, string, Godot.Texture2D)`；`NationalSpire.DateSceneView.Streaming(bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneTesting.SendInput(string)`；输入表达式：`SendInput("一起休息一会儿")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => SendInput("一起休息一会儿")`
- `NationalSpire.DateSceneTesting.SendInput(string)`；输入表达式：`SendInput("聊聊接下来的安排")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => SendInput("聊聊接下来的安排")`
- `NationalSpire.DateSceneTesting.Texture(string, string)`；输入表达式：`Texture(person.PersonId, line.Emotion)`；返回值紧邻使用处：`ArgumentSyntax: Texture(person.PersonId, line.Emotion)`
- `NationalSpire.DateSceneView.SetReplyChoices(string, System.Action, string, System.Action)`；输入表达式：`_view.SetReplyChoices("聊聊接下来的安排", () => SendInput("聊聊接下来的安排"), "一起休息一会儿", () => SendInput("一起休息一会儿"))`；返回值紧邻使用处：`ExpressionStatementSyntax: _view.SetReplyChoices("聊聊接下来的安排", () => SendInput("聊聊接下来的安排"), "一起休息一会儿", () => SendInput("一起休息一会儿"));`
- `NationalSpire.DateSceneView.ShowInput(string, bool, bool)`；输入表达式：`_view.ShowInput("玩家 · 测试约会")`；返回值紧邻使用处：`ExpressionStatementSyntax: _view.ShowInput("玩家 · 测试约会");`
- `NationalSpire.DateSceneView.ShowRoundLine(System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, string, Godot.Texture2D)`；输入表达式：`_view.ShowRoundLine(_lines, _index, person.Name, Texture(person.PersonId, line.Emotion))`；返回值紧邻使用处：`ExpressionStatementSyntax: _view.ShowRoundLine(_lines, _index, person.Name, Texture(person.PersonId, line.Emotion));`
- `NationalSpire.DateSceneView.Streaming(bool)`；输入表达式：`_view.Streaming(!_complete)`；返回值紧邻使用处：`ExpressionStatementSyntax: _view.Streaming(!_complete);`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`_request.Participants.FirstOrDefault(p => p.PersonId == line.Speaker)`；返回值紧邻使用处：`BinaryExpressionSyntax: _request.Participants.FirstOrDefault(p => p.PersonId == line.Speaker) ?? _request.Participants[0]`

**赋值（含属性/字段和局部值）：**


<a id="symbol-357d06d908f5"></a>

## `NationalSpire.DateSceneTesting.Close() — public void Close()`

来源：源码第 149 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen._Input(Godot.InputEvent)`](CareerScreen.cs.md#symbol-a9891646fd75)

**调用：** `Godot.CanvasItem.Hide()`；`Godot.Node.QueueFree()`；`System.Action.Invoke()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneTesting.Closed`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: Hide();`
- `Godot.Node.QueueFree()`；输入表达式：`QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueFree();`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Closed?.Invoke()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f9ebd8ab5040"></a>

## `NationalSpire.DateSceneTesting._ExitTree() — public override void _ExitTree()`

来源：源码第 150 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.GodotObject.Dispose()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneTesting._owned`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.Dispose()`；输入表达式：`texture.Dispose()`；返回值紧邻使用处：`ExpressionStatementSyntax: texture.Dispose();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c1c7664de97e"></a>

## `NationalSpire.CareerScreen.TestDateScenePicker() — private void TestDateScenePicker()`

来源：源码第 156 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.GodotObject.Dispose()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；[`NationalSpire.CareerScreen.GroupMemberPicker(NationalSpire.GroupChat?, System.Action<System.Collections.Generic.List<string>>, bool, string, bool, bool)`](GroupChatScreen.cs.md#symbol-26ccde004356)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；`NationalSpire.DateSceneTesting.DateSceneTesting()`；[`NationalSpire.DateSceneTesting.Initialize(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>)`](DateSceneTesting.cs.md#symbol-91667df79532)；`NationalSpire.GroupChat.GroupChat()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.GroupMemberPicker(NationalSpire.GroupChat?, System.Action<System.Collections.Generic.List<string>>, bool, string, bool, bool)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._stage`；`NationalSpire.CareerScreen._testDateScene`；`NationalSpire.DateSceneTesting.Closed`；`NationalSpire.DateSceneTesting.Initialize(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.Dispose()`；输入表达式：`test.Dispose()`；返回值紧邻使用处：`ExpressionStatementSyntax: test.Dispose();`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_stage.AddChild(test)`；返回值紧邻使用处：`ExpressionStatementSyntax: _stage.AddChild(test);`
- `NationalSpire.CareerScreen.GroupMemberPicker(NationalSpire.GroupChat?, System.Action<System.Collections.Generic.List<string>>, bool, string, bool, bool)`；输入表达式：`GroupMemberPicker(new GroupChat(), people => { if (people.Count < 1) { Notice("测试约会请选择至少一名NPC。", true); return; } var test = new DateSceneTesting(); try { test.Initialize(ViewData, people); } catch (Exception e) { test.Dispose(); Notice(e.Message, true); return; } _testDateScene = test; test.Closed = () => _testDateScene = null; _stage.AddChild(test); }, title: "测试约会 · 选择参与角色")`；返回值紧邻使用处：`ExpressionStatementSyntax: GroupMemberPicker(new GroupChat(), people => { if (people.Count < 1) { Notice("测试约会请选择至少一名NPC。", true); return; } var test = new DateSceneTesting(); try { test.Initialize(ViewData, people); } catch (Exception e) { test.Dispose(); Notice(e.Message, true); return; } _testDateScene = test; test.Closed = () => _testDateScene = null; _stage.AddChild(test); }, title: "测试约会 · 选择参与角色");`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("测试约会请选择至少一名NPC。", true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("测试约会请选择至少一名NPC。", true);`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(e.Message, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(e.Message, true);`
- `NationalSpire.DateSceneTesting.DateSceneTesting()`；输入表达式：`new DateSceneTesting()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new DateSceneTesting()`
- `NationalSpire.DateSceneTesting.Initialize(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>)`；输入表达式：`test.Initialize(ViewData, people)`；返回值紧邻使用处：`ExpressionStatementSyntax: test.Initialize(ViewData, people);`
- `NationalSpire.GroupChat.GroupChat()`；输入表达式：`new GroupChat()`；返回值紧邻使用处：`ArgumentSyntax: new GroupChat()`

**赋值（含属性/字段和局部值）：**

- `_testDateScene` = `null`
- `_testDateScene` = `test`
- `test.Closed` = `() => _testDateScene = null`
