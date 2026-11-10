# DateSceneMemoryScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`B29F4913FE448B33A9F496ADA4BA7FB6354333514B8CDC19FF983496C9AC49A5`。来源：[源码](../../DateSceneMemoryScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
protected DateMemoryRecorder? _dateMemory;
private string _dateMemoryKey = "";
private bool _dateRecording;
private readonly Dictionary<ulong, string> _dateMemoryImages = [];
protected DateMemoryPlayback? _dateMemoryPlayback;
```

<a id="symbol-5fae395fe1f4"></a>

## `NationalSpire.CareerScreen.RememberDateImage(Godot.Texture2D) — private string RememberDateImage(Texture2D texture)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RefreshDateMemoryPeople()`](DateSceneMemoryScreen.cs.md#symbol-afd6840c2c58)

**调用：** [`NationalSpire.DateSceneAssetStore.Hash(byte[])`](DateSceneAssets.cs.md#symbol-e8871d339d39)；[`NationalSpire.DateSceneAssetStore.Store(byte[], string)`](DateSceneAssets.cs.md#symbol-a774cf2421cf)；`Godot.GodotObject.GetInstanceId()`；`Godot.Image.SavePngToBuffer()`；`Godot.Texture2D.GetImage()`；`string.IsNullOrEmpty(string?)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._dateMemoryImages`；`NationalSpire.CareerScreen._dateTextures`；`NationalSpire.DateSceneAssetStore.Hash(byte[])`；`NationalSpire.DateSceneAssetStore.Store(byte[], string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.GetInstanceId()`；输入表达式：`texture.GetInstanceId()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = texture.GetInstanceId()`
- `Godot.Image.SavePngToBuffer()`；输入表达式：`pixels.SavePngToBuffer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = pixels.SavePngToBuffer()`
- `Godot.Texture2D.GetImage()`；输入表达式：`texture.GetImage()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = texture.GetImage()`
- `NationalSpire.DateSceneAssetStore.Hash(byte[])`；输入表达式：`DateSceneAssetStore.Hash(bytes)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateSceneAssetStore.Hash(bytes)`
- `NationalSpire.DateSceneAssetStore.Store(byte[], string)`；输入表达式：`DateSceneAssetStore.Store(bytes, hash)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateSceneAssetStore.Store(bytes, hash);`
- `string.IsNullOrEmpty(string?)`；输入表达式：`string.IsNullOrEmpty(existing)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !string.IsNullOrEmpty(existing)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_dateMemoryImages.TryGetValue(id, out string? image)`；返回值紧邻使用处：`IfStatementSyntax: if (_dateMemoryImages.TryGetValue(id, out string? image)) return image;`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`_dateTextures.FirstOrDefault(p => p.Value == texture && p.Key.Length == 64)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _dateTextures.FirstOrDefault(p => p.Value == texture && p.Key.Length == 64).Key`

**赋值（含属性/字段和局部值）：**

- `_dateMemoryImages[id]` = `existing`
- `_dateMemoryImages[id]` = `hash`

<a id="symbol-e0190873cf74"></a>

## `NationalSpire.CareerScreen.BeginDateMemory(NationalSpire.CareerData, NationalSpire.PrivateOffer) — private void BeginDateMemory(CareerData data, PrivateOffer offer)`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)

**调用：** [`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerScreen.RefreshDateMemoryPeople()`](DateSceneMemoryScreen.cs.md#symbol-afd6840c2c58)；[`NationalSpire.CareerScreen.SyncDateMemory()`](DateSceneMemoryScreen.cs.md#symbol-4103852c245a)；[`NationalSpire.DateSceneMemories.FilePath(NationalSpire.CareerData, string)`](DateSceneMemories.cs.md#symbol-c6266089e238)；[`NationalSpire.DateSceneMemories.Read(NationalSpire.CareerData, string)`](DateSceneMemories.cs.md#symbol-99fb40e5b954)；`NationalSpire.DateMemoryRecorder.DateMemoryRecorder(NationalSpire.DateSceneMemory)`；`NationalSpire.DateSceneMemory.DateSceneMemory()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerScreen._dateMemory`；`NationalSpire.CareerScreen._dateMemoryImages`；`NationalSpire.CareerScreen._dateMemoryKey`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateRecording`；`NationalSpire.CareerScreen.RefreshDateMemoryPeople()`；`NationalSpire.CareerScreen.SyncDateMemory()`；`NationalSpire.DateSceneMemories.FilePath(NationalSpire.CareerData, string)`；`NationalSpire.DateSceneMemories.Read(NationalSpire.CareerData, string)`；`NationalSpire.DateSceneMemories.Recording`；`NationalSpire.DateSceneMemory.Day`；`NationalSpire.DateSceneMemory.Host`；`NationalSpire.DateSceneMemory.OfferId`；`NationalSpire.DateSceneMemory.Player`；`NationalSpire.DateSceneMemory.Season`；`NationalSpire.DateSceneMemory.Title`；`NationalSpire.PrivateOffer.Day`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Season`；`NationalSpire.PrivateOffer.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(data)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Player = CareerEngine.Name(data)`
- `NationalSpire.CareerScreen.RefreshDateMemoryPeople()`；输入表达式：`RefreshDateMemoryPeople()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshDateMemoryPeople();`
- `NationalSpire.CareerScreen.SyncDateMemory()`；输入表达式：`SyncDateMemory()`；返回值紧邻使用处：`ExpressionStatementSyntax: SyncDateMemory();`
- `NationalSpire.DateMemoryRecorder.DateMemoryRecorder(NationalSpire.DateSceneMemory)`；输入表达式：`new(saved ?? new() { OfferId = offer.Id, Host = _datePerson, Title = offer.Title, Season = offer.Season, Day = offer.Day, Player = CareerEngine.Name(data) })`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dateMemory = new(saved ?? new() { OfferId = offer.Id, Host = _datePerson, Title = offer.Title, Season = offer.Season, Day = offer.Day, Player = CareerEngine.Name(data) })`
- `NationalSpire.DateSceneMemories.FilePath(NationalSpire.CareerData, string)`；输入表达式：`DateSceneMemories.FilePath(data, offer.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateSceneMemories.FilePath(data, offer.Id)`
- `NationalSpire.DateSceneMemories.Read(NationalSpire.CareerData, string)`；输入表达式：`DateSceneMemories.Read(data, offer.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateSceneMemories.Read(data, offer.Id)`
- `NationalSpire.DateSceneMemory.DateSceneMemory()`；输入表达式：`new() { OfferId = offer.Id, Host = _datePerson, Title = offer.Title, Season = offer.Season, Day = offer.Day, Player = CareerEngine.Name(data) }`；返回值紧邻使用处：`BinaryExpressionSyntax: saved ?? new() { OfferId = offer.Id, Host = _datePerson, Title = offer.Title, Season = offer.Season, Day = offer.Day, Player = CareerEngine.Name(data) }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_dateMemoryImages.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateMemoryImages.Clear();`

**赋值（含属性/字段和局部值）：**

- `_dateMemory` = `new(saved ?? new() { OfferId = offer.Id, Host = _datePerson, Title = offer.Title, Season = offer.Season, Day = offer.Day, Player = CareerEngine.Name(data) })`
- `_dateMemoryKey` = `key`
- `_dateRecording` = `DateSceneMemories.Recording`
- `Day` = `offer.Day`
- `Host` = `_datePerson`
- `OfferId` = `offer.Id`
- `Player` = `CareerEngine.Name(data)`
- `Season` = `offer.Season`
- `Title` = `offer.Title`

<a id="symbol-afd6840c2c58"></a>

## `NationalSpire.CareerScreen.RefreshDateMemoryPeople() — private void RefreshDateMemoryPeople()`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BeginDateMemory(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](DateSceneMemoryScreen.cs.md#symbol-e0190873cf74)；[`NationalSpire.CareerScreen.CaptureDateMemory()`](DateSceneMemoryScreen.cs.md#symbol-7b36ced91124)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerScreen.PartyTexture(string, string)`](DateScenePartyScreen.cs.md#symbol-53bfcf8e2a43)；[`NationalSpire.CareerScreen.RememberDateImage(Godot.Texture2D)`](DateSceneMemoryScreen.cs.md#symbol-5fae395fe1f4)；[`NationalSpire.DateSceneAssetStore.SpriteKeys(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string)`](DateSceneAssets.cs.md#symbol-3b48b221efd8)；`NationalSpire.DateMemoryPerson.DateMemoryPerson()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `(NationalSpire.PortraitDesign Design, NationalSpire.DateSceneAssets Assets).Assets`；`(NationalSpire.PortraitDesign Design, NationalSpire.DateSceneAssets Assets).Design`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen._dateDefaultPeople`；`NationalSpire.CareerScreen._dateMemory`；`NationalSpire.CareerScreen._datePartyArt`；`NationalSpire.CareerScreen.PartyTexture(string, string)`；`NationalSpire.CareerScreen.RememberDateImage(Godot.Texture2D)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.DateMemoryPerson.Default`；`NationalSpire.DateMemoryPerson.Emotions`；`NationalSpire.DateMemoryPerson.Name`；`NationalSpire.DateMemoryRecorder.Dirty`；`NationalSpire.DateMemoryRecorder.Memory`；`NationalSpire.DateSceneAssets.Sprites`；`NationalSpire.DateSceneAssetStore.SpriteKeys(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string)`；`NationalSpire.DateSceneMemory.People`；`NationalSpire.PortraitDesign.DefaultEmotionId`；`NationalSpire.PortraitDesign.Emotions`；`NationalSpire.PortraitEmotion.Enabled`；`NationalSpire.PortraitEmotion.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(ViewData, person)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Name = CareerEngine.DisplayName(ViewData, person)`
- `NationalSpire.CareerScreen.PartyTexture(string, string)`；输入表达式：`PartyTexture(person, art.Design.DefaultEmotionId)`；返回值紧邻使用处：`ArgumentSyntax: PartyTexture(person, art.Design.DefaultEmotionId)`
- `NationalSpire.CareerScreen.RememberDateImage(Godot.Texture2D)`；输入表达式：`RememberDateImage(PartyTexture(person, art.Design.DefaultEmotionId))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RememberDateImage(PartyTexture(person, art.Design.DefaultEmotionId))`
- `NationalSpire.DateMemoryPerson.DateMemoryPerson()`；输入表达式：`new DateMemoryPerson { Name = CareerEngine.DisplayName(ViewData, person), Default = fallback }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new DateMemoryPerson { Name = CareerEngine.DisplayName(ViewData, person), Default = fallback }`
- `NationalSpire.DateSceneAssetStore.SpriteKeys(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string)`；输入表达式：`DateSceneAssetStore.SpriteKeys(art.Assets, art.Design, emotion.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateSceneAssetStore.SpriteKeys(art.Assets, art.Design, emotion.Id).Select`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`_dateMemory.Memory.People.ContainsKey(person)`；返回值紧邻使用处：`IfStatementSyntax: if (_dateMemory.Memory.People.ContainsKey(person)) continue;`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`_dateDefaultPeople.Contains(person)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _dateDefaultPeople.Contains(person) ? fallback                      : DateSceneAssetStore.SpriteKeys(art.Assets, art.Design, emotion.Id).Select(k => art.Assets.Sprites[k]).FirstOrDefault() ?? fallback`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`DateSceneAssetStore.SpriteKeys(art.Assets, art.Design, emotion.Id).Select(k => art.Assets.Sprites[k]).FirstOrDefault()`；返回值紧邻使用处：`BinaryExpressionSyntax: DateSceneAssetStore.SpriteKeys(art.Assets, art.Design, emotion.Id).Select(k => art.Assets.Sprites[k]).FirstOrDefault() ?? fallback`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`DateSceneAssetStore.SpriteKeys(art.Assets, art.Design, emotion.Id).Select(k => art.Assets.Sprites[k])`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateSceneAssetStore.SpriteKeys(art.Assets, art.Design, emotion.Id).Select(k => art.Assets.Sprites[k]).FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`art.Design.Emotions.Where(e => e.Enabled)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var emotion in art.Design.Emotions.Where(e => e.Enabled))                  entry.Emotions[emotion.Id] = _dateDefaultPeople.Contains(person) ? fallback                      : DateSceneAssetStore.SpriteKeys(art.Assets, art.Design, emotion.Id).Select(k => art.Assets.Sprites[k]).FirstOrDefault() ?? fallback;`

**赋值（含属性/字段和局部值）：**

- `_dateMemory.Dirty` = `true`
- `_dateMemory.Memory.People[person]` = `entry`
- `Default` = `fallback`
- `entry.Emotions[emotion.Id]` = `_dateDefaultPeople.Contains(person) ? fallback                      : DateSceneAssetStore.SpriteKeys(art.Assets, art.Design, emotion.Id).Select(k => art.Assets.Sprites[k]).FirstOrDefault() ?? fallback`
- `Name` = `CareerEngine.DisplayName(ViewData, person)`

<a id="symbol-4103852c245a"></a>

## `NationalSpire.CareerScreen.SyncDateMemory() — protected void SyncDateMemory()`

来源：源码第 50 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BeginDateMemory(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](DateSceneMemoryScreen.cs.md#symbol-e0190873cf74)；[`NationalSpire.CareerScreen.ConfirmDateHistoryInput()`](DateHistoryReplayScreen.cs.md#symbol-e9d44f3bf0bb)；[`NationalSpire.CareerScreen.SaveDateMemory(bool)`](DateSceneMemoryScreen.cs.md#symbol-c76191deb959)；[`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)

**调用：** [`NationalSpire.DateMemoryRecorder.Sync(NationalSpire.PrivateConversation)`](DateSceneMemories.cs.md#symbol-949d37f3d89e)；[`NationalSpire.DateSceneMemories.FilePath(NationalSpire.CareerData, string)`](DateSceneMemories.cs.md#symbol-c6266089e238)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._dateMemory`；`NationalSpire.CareerScreen._dateMemoryKey`；`NationalSpire.CareerScreen._dateOffer`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.DateMemoryRecorder.Sync(NationalSpire.PrivateConversation)`；`NationalSpire.DateSceneMemories.FilePath(NationalSpire.CareerData, string)`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateMemoryRecorder.Sync(NationalSpire.PrivateConversation)`；输入表达式：`_dateMemory.Sync(PrivateMessages.Conversation(ViewData, _datePerson))`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateMemory.Sync(PrivateMessages.Conversation(ViewData, _datePerson));`
- `NationalSpire.DateSceneMemories.FilePath(NationalSpire.CareerData, string)`；输入表达式：`DateSceneMemories.FilePath(ViewData, _dateOffer)`；返回值紧邻使用处：`BinaryExpressionSyntax: DateSceneMemories.FilePath(ViewData, _dateOffer) != _dateMemoryKey`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(ViewData, _datePerson)`；返回值紧邻使用处：`ArgumentSyntax: PrivateMessages.Conversation(ViewData, _datePerson)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7b36ced91124"></a>

## `NationalSpire.CareerScreen.CaptureDateMemory() — private void CaptureDateMemory()`

来源：源码第 55 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddDateMemorySetting(Godot.VBoxContainer)`](DateSceneMemoryScreen.cs.md#symbol-e85e0fc39965)；[`NationalSpire.CareerScreen.AdvanceDateScene()`](DateSceneScreen.cs.md#symbol-96e53c8a266f)；[`NationalSpire.CareerScreen.AppendDateLine(NationalSpire.DateSceneLine)`](DateSceneScreen.cs.md#symbol-243385a70bb8)；[`NationalSpire.CareerScreen.SaveDateMemory(bool)`](DateSceneMemoryScreen.cs.md#symbol-c76191deb959)；[`NationalSpire.CareerScreen.ShowDateLine()`](DateSceneScreen.cs.md#symbol-1580b0be190e)

**调用：** [`NationalSpire.CareerScreen.RefreshDateMemoryPeople()`](DateSceneMemoryScreen.cs.md#symbol-afd6840c2c58)；[`NationalSpire.DateMemoryRecorder.Capture(string, int, NationalSpire.DateSceneLine, NationalSpire.DateMemoryFrame)`](DateSceneMemories.cs.md#symbol-9b3816f4efa8)；[`NationalSpire.DateSceneBackgrounds.ResolveImage(string)`](DateSceneBackgrounds.cs.md#symbol-05e1fa49f816)；[`NationalSpire.DateSceneView.CaptureMemoryFrame(System.Func<Godot.Texture2D, string>)`](DateSceneMemoryPlayback.cs.md#symbol-72b7e856545d)；[`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-8a6bb6e78fa5)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._dateAssets`；`NationalSpire.CareerScreen._dateBackground`；`NationalSpire.CareerScreen._dateHistoryTurn`；`NationalSpire.CareerScreen._dateIndex`；`NationalSpire.CareerScreen._dateLines`；`NationalSpire.CareerScreen._dateMemory`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateTurn`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.CareerScreen.RefreshDateMemoryPeople()`；`NationalSpire.CareerScreen.RememberDateImage(Godot.Texture2D)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.DateMemoryFrame.Background`；`NationalSpire.DateMemoryFrame.Badge`；`NationalSpire.DateMemoryFrame.Blur`；`NationalSpire.DateMemoryFrame.Bond`；`NationalSpire.DateMemoryFrame.Fade`；`NationalSpire.DateMemoryFrame.Favour`；`NationalSpire.DateMemoryFrame.FontSize`；`NationalSpire.DateMemoryFrame.Oath`；`NationalSpire.DateMemoryFrame.Outline`；`NationalSpire.DateMemoryFrame.Relationship`；`NationalSpire.DateMemoryFrame.Scale`；`NationalSpire.DateMemoryFrame.Spacing`；`NationalSpire.DateMemoryFrame.Speaker`；`NationalSpire.DateMemoryFrame.X`；`NationalSpire.DateMemoryFrame.Y`；`NationalSpire.DateMemoryRecorder.Capture(string, int, NationalSpire.DateSceneLine, NationalSpire.DateMemoryFrame)`；`NationalSpire.DateMemoryRecorder.Memory`；`NationalSpire.DateSceneAssets.BlurAmount`；`NationalSpire.DateSceneAssets.FontSize`；`NationalSpire.DateSceneAssets.LetterSpacing`；`NationalSpire.DateSceneAssets.PanelFade`；`NationalSpire.DateSceneAssets.ShowAffectionBadge`；`NationalSpire.DateSceneAssets.SpriteScale`；`NationalSpire.DateSceneAssets.SpriteX`；`NationalSpire.DateSceneAssets.SpriteY`；`NationalSpire.DateSceneAssets.TextOutline`；`NationalSpire.DateSceneBackgrounds.ResolveImage(string)`；`NationalSpire.DateSceneMemory.Backgrounds`；`NationalSpire.DateSceneView.CaptureMemoryFrame(System.Func<Godot.Texture2D, string>)`；`NationalSpire.DateSceneView.Status`；`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateRelation.Favour`；`NationalSpire.PrivateRelation.OathConfirmed`；`NationalSpire.PrivateRelation.Relationship`；`NationalSpire.PrivateRelation.SelectedBond`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.RefreshDateMemoryPeople()`；输入表达式：`RefreshDateMemoryPeople()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshDateMemoryPeople();`
- `NationalSpire.DateMemoryRecorder.Capture(string, int, NationalSpire.DateSceneLine, NationalSpire.DateMemoryFrame)`；输入表达式：`_dateMemory.Capture(_dateTurn, _dateIndex, _dateLines[_dateIndex], frame)`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateMemory.Capture(_dateTurn, _dateIndex, _dateLines[_dateIndex], frame);`
- `NationalSpire.DateSceneBackgrounds.ResolveImage(string)`；输入表达式：`DateSceneBackgrounds.ResolveImage(frame.Background)`；返回值紧邻使用处：`AssignmentExpressionSyntax: frame.Background = DateSceneBackgrounds.ResolveImage(frame.Background)`
- `NationalSpire.DateSceneView.CaptureMemoryFrame(System.Func<Godot.Texture2D, string>)`；输入表达式：`_dateView.CaptureMemoryFrame(RememberDateImage)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _dateView.CaptureMemoryFrame(RememberDateImage)`
- `NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Relation(ViewData, frame.Speaker.Length > 0 ? frame.Speaker : _datePerson)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Relation(ViewData, frame.Speaker.Length > 0 ? frame.Speaker : _datePerson)`

**赋值（含属性/字段和局部值）：**

- `_dateMemory.Memory.Backgrounds[_dateBackground]` = `frame.Background`
- `_dateView.Status.Text` = `"回忆画面记录失败：" + e.Message`
- `frame.Background` = `DateSceneBackgrounds.ResolveImage(frame.Background)`
- `frame.Badge` = `assets.ShowAffectionBadge`
- `frame.Blur` = `assets.BlurAmount`
- `frame.Bond` = `relation.SelectedBond`
- `frame.Fade` = `assets.PanelFade`
- `frame.Favour` = `relation.Favour`
- `frame.FontSize` = `assets.FontSize`
- `frame.Oath` = `relation.OathConfirmed`
- `frame.Outline` = `assets.TextOutline`
- `frame.Relationship` = `relation.Relationship`
- `frame.Scale` = `assets.SpriteScale`
- `frame.Spacing` = `assets.LetterSpacing`
- `frame.X` = `assets.SpriteX`
- `frame.Y` = `assets.SpriteY`

<a id="symbol-c76191deb959"></a>

## `NationalSpire.CareerScreen.SaveDateMemory(bool) — private void SaveDateMemory(bool end = false)`

来源：源码第 75 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddDateMemorySetting(Godot.VBoxContainer)`](DateSceneMemoryScreen.cs.md#symbol-e85e0fc39965)；[`NationalSpire.CareerScreen.AdvanceDateScene()`](DateSceneScreen.cs.md#symbol-96e53c8a266f)；[`NationalSpire.CareerScreen.CompleteDateLeave(bool, System.Action?)`](DateSceneScreen.cs.md#symbol-da3333a7be3d)；[`NationalSpire.CareerScreen.ConfirmDateHistoryInput()`](DateHistoryReplayScreen.cs.md#symbol-e9d44f3bf0bb)；[`NationalSpire.CareerScreen.ReleaseDateSceneView()`](DateSceneScreen.cs.md#symbol-ea637ecbc4b0)；[`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)

**调用：** [`NationalSpire.CareerScreen.CaptureDateMemory()`](DateSceneMemoryScreen.cs.md#symbol-7b36ced91124)；[`NationalSpire.CareerScreen.SyncDateMemory()`](DateSceneMemoryScreen.cs.md#symbol-4103852c245a)；[`NationalSpire.DateSceneBackgrounds.ResolveImage(string)`](DateSceneBackgrounds.cs.md#symbol-05e1fa49f816)；[`NationalSpire.DateSceneMemories.FilePath(NationalSpire.CareerData, string)`](DateSceneMemories.cs.md#symbol-c6266089e238)；[`NationalSpire.DateSceneMemories.Read(NationalSpire.CareerData, string)`](DateSceneMemories.cs.md#symbol-99fb40e5b954)；[`NationalSpire.DateSceneMemories.Save(NationalSpire.CareerData, NationalSpire.DateSceneMemory)`](DateSceneMemories.cs.md#symbol-4fa62fbdceed)；`Godot.GD.PushWarning(string)`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._dateBackgrounds`；`NationalSpire.CareerScreen._dateMemory`；`NationalSpire.CareerScreen._dateMemoryKey`；`NationalSpire.CareerScreen._dateOffer`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateRecording`；`NationalSpire.CareerScreen._dateState`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.CareerScreen.CaptureDateMemory()`；`NationalSpire.CareerScreen.SyncDateMemory()`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.DateMemoryRecorder.Dirty`；`NationalSpire.DateMemoryRecorder.Memory`；`NationalSpire.DateMemoryTurn.Lines`；`NationalSpire.DateSceneBackground.Id`；`NationalSpire.DateSceneBackground.Image`；`NationalSpire.DateSceneBackgrounds.ResolveImage(string)`；`NationalSpire.DateSceneLine.Background`；`NationalSpire.DateSceneMemories.FilePath(NationalSpire.CareerData, string)`；`NationalSpire.DateSceneMemories.Read(NationalSpire.CareerData, string)`；`NationalSpire.DateSceneMemories.Save(NationalSpire.CareerData, NationalSpire.DateSceneMemory)`；`NationalSpire.DateSceneMemory.Backgrounds`；`NationalSpire.DateSceneMemory.Ended`；`NationalSpire.DateSceneMemory.Turns`；`NationalSpire.DateSceneView.InputMode`；`NationalSpire.DateSceneView.Status`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GD.PushWarning(string)`；输入表达式：`GD.PushWarning("[NationalSpire] 回忆保存失败：" + e.Message)`；返回值紧邻使用处：`ExpressionStatementSyntax: GD.PushWarning("[NationalSpire] 回忆保存失败：" + e.Message);`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_dateView)`；返回值紧邻使用处：`BinaryExpressionSyntax: _dateView != null && IsInstanceValid(_dateView)`
- `NationalSpire.CareerScreen.CaptureDateMemory()`；输入表达式：`CaptureDateMemory()`；返回值紧邻使用处：`ExpressionStatementSyntax: CaptureDateMemory();`
- `NationalSpire.CareerScreen.SyncDateMemory()`；输入表达式：`SyncDateMemory()`；返回值紧邻使用处：`ExpressionStatementSyntax: SyncDateMemory();`
- `NationalSpire.DateSceneBackgrounds.ResolveImage(string)`；输入表达式：`DateSceneBackgrounds.ResolveImage(background.Image)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dateMemory.Memory.Backgrounds[id] = DateSceneBackgrounds.ResolveImage(background.Image)`
- `NationalSpire.DateSceneMemories.FilePath(NationalSpire.CareerData, string)`；输入表达式：`DateSceneMemories.FilePath(ViewData, _dateOffer)`；返回值紧邻使用处：`BinaryExpressionSyntax: DateSceneMemories.FilePath(ViewData, _dateOffer) != _dateMemoryKey`
- `NationalSpire.DateSceneMemories.Read(NationalSpire.CareerData, string)`；输入表达式：`DateSceneMemories.Read(ViewData, _dateOffer)`；返回值紧邻使用处：`IsPatternExpressionSyntax: DateSceneMemories.Read(ViewData, _dateOffer) is { } saved`
- `NationalSpire.DateSceneMemories.Save(NationalSpire.CareerData, NationalSpire.DateSceneMemory)`；输入表达式：`DateSceneMemories.Save(ViewData, _dateMemory.Memory)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateSceneMemories.Save(ViewData, _dateMemory.Memory);`
- `NationalSpire.DateSceneMemories.Save(NationalSpire.CareerData, NationalSpire.DateSceneMemory)`；输入表达式：`DateSceneMemories.Save(ViewData, saved)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateSceneMemories.Save(ViewData, saved);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`_dateMemory.Memory.Backgrounds.ContainsKey(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_dateMemory.Memory.Backgrounds.ContainsKey(id)`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`_dateMemory.Memory.Turns.SelectMany(t => t.Lines).Select(l => l.Background).Where(s => s.Length > 0).Distinct()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string id in _dateMemory.Memory.Turns.SelectMany(t => t.Lines).Select(l => l.Background).Where(s => s.Length > 0).Distinct())                      if (!_dateMemory.Memory.Backgrounds.ContainsKey(id) && _dateBackgrounds.FirstOrDefault(b => b.Id == id) is { } background)                          _dateMemory.Memory.Backgrounds[id] = DateSceneBackgrounds.ResolveImage(background.Image);`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`_dateBackgrounds.FirstOrDefault(b => b.Id == id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: _dateBackgrounds.FirstOrDefault(b => b.Id == id) is { } background`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`_dateMemory.Memory.Turns.SelectMany(t => t.Lines).Select(l => l.Background)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _dateMemory.Memory.Turns.SelectMany(t => t.Lines).Select(l => l.Background).Where`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`_dateMemory.Memory.Turns.SelectMany(t => t.Lines)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _dateMemory.Memory.Turns.SelectMany(t => t.Lines).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`_dateMemory.Memory.Turns.SelectMany(t => t.Lines).Select(l => l.Background).Where(s => s.Length > 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _dateMemory.Memory.Turns.SelectMany(t => t.Lines).Select(l => l.Background).Where(s => s.Length > 0).Distinct`

**赋值（含属性/字段和局部值）：**

- `_dateMemory.Dirty` = `false`
- `_dateMemory.Dirty` = `true`
- `_dateMemory.Memory.Backgrounds[id]` = `DateSceneBackgrounds.ResolveImage(background.Image)`
- `_dateMemory.Memory.Ended` = `true`
- `_dateView.Status.Text` = `"回忆保存失败：" + e.Message`
- `saved.Ended` = `true`

<a id="symbol-e85e0fc39965"></a>

## `NationalSpire.CareerScreen.AddDateMemorySetting(Godot.VBoxContainer) — private void AddDateMemorySetting(VBoxContainer box)`

来源：源码第 100 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DateSceneSettings()`](DateSceneScreen.cs.md#symbol-0845ec2acab1)

**调用：** [`NationalSpire.CareerScreen.CaptureDateMemory()`](DateSceneMemoryScreen.cs.md#symbol-7b36ced91124)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.SaveDateMemory(bool)`](DateSceneMemoryScreen.cs.md#symbol-c76191deb959)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`Godot.BaseButton.SetPressedNoSignal(bool)`；`Godot.CheckBox.CheckBox()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._dateMemory`；`NationalSpire.CareerScreen._dateRecording`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.CaptureDateMemory()`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.SaveDateMemory(bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.DateMemoryRecorder.Dirty`；`NationalSpire.DateSceneMemories.Recording`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`record.SetPressedNoSignal(_dateRecording)`；返回值紧邻使用处：`ExpressionStatementSyntax: record.SetPressedNoSignal(_dateRecording);`
- `Godot.CheckBox.CheckBox()`；输入表达式：`new CheckBox { Name = "DateRecordMemory", Text = "保留所有约会对话", ButtonPressed = _dateRecording }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CheckBox { Name = "DateRecordMemory", Text = "保留所有约会对话", ButtonPressed = _dateRecording }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(record)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(record);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text("保存在本机，可从约会日记进入回忆。此设置持续应用于之后的约会。", 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text("保存在本机，可从约会日记进入回忆。此设置持续应用于之后的约会。", 16, _muted));`
- `NationalSpire.CareerScreen.CaptureDateMemory()`；输入表达式：`CaptureDateMemory()`；返回值紧邻使用处：`ExpressionStatementSyntax: CaptureDateMemory();`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(e.Message, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(e.Message, true);`
- `NationalSpire.CareerScreen.SaveDateMemory(bool)`；输入表达式：`SaveDateMemory()`；返回值紧邻使用处：`ExpressionStatementSyntax: SaveDateMemory();`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("保存在本机，可从约会日记进入回忆。此设置持续应用于之后的约会。", 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("保存在本机，可从约会日记进入回忆。此设置持续应用于之后的约会。", 16, _muted)`

**赋值（含属性/字段和局部值）：**

- `_dateMemory.Dirty` = `true`
- `_dateRecording` = `value`
- `ButtonPressed` = `_dateRecording`
- `DateSceneMemories.Recording` = `value`
- `Name` = `"DateRecordMemory"`
- `record.Toggled` += `value =>          {              try              {                  if (!value) SaveDateMemory();                  DateSceneMemories.Recording = value; _dateRecording = value;                  if (value) { CaptureDateMemory(); if (_dateMemory != null) _dateMemory.Dirty = true; SaveDateMemory(); }              }              catch (Exception e) { record.SetPressedNoSignal(_dateRecording); Notice(e.Message, true); }          }`
- `Text` = `"保留所有约会对话"`

<a id="symbol-5a8c8e2619a9"></a>

## `NationalSpire.CareerScreen.OpenDateMemory(NationalSpire.CareerData, string, NationalSpire.DateSceneMemory) — protected void OpenDateMemory(CareerData data, string person, DateSceneMemory memory)`

来源：源码第 115 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenDateMemoryChoice(NationalSpire.CareerData, string, NationalSpire.DateSceneMemory)`](CareerScreenExtensions.cs.md#symbol-db34df2d56c6)

**调用：** [`NationalSpire.CareerScreen.AttachMemoryPlayback(NationalSpire.CareerData, string, NationalSpire.DateSceneMemory, NationalSpire.DateMemoryPlayback)`](DateSceneMemoryScreen.cs.md#symbol-a203b37d1b91)；[`NationalSpire.CareerScreen.CreateDateMemoryPlayback(NationalSpire.CareerData, NationalSpire.DateSceneMemory)`](CareerScreenExtensions.cs.md#symbol-bd56cbc47967)；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.Node.IsInsideTree()`；`System.Action.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._cancelDialog`；`NationalSpire.CareerScreen._dateMemoryPlayback`；`NationalSpire.CareerScreen.AttachMemoryPlayback(NationalSpire.CareerData, string, NationalSpire.DateSceneMemory, NationalSpire.DateMemoryPlayback)`；`NationalSpire.CareerScreen.CreateDateMemoryPlayback(NationalSpire.CareerData, NationalSpire.DateSceneMemory)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_dateMemoryPlayback)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(_dateMemoryPlayback) && _dateMemoryPlayback!.IsInsideTree()`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`_dateMemoryPlayback.IsQueuedForDeletion()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_dateMemoryPlayback.IsQueuedForDeletion()`
- `Godot.Node.IsInsideTree()`；输入表达式：`_dateMemoryPlayback!.IsInsideTree()`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(_dateMemoryPlayback) && _dateMemoryPlayback!.IsInsideTree()`
- `NationalSpire.CareerScreen.AttachMemoryPlayback(NationalSpire.CareerData, string, NationalSpire.DateSceneMemory, NationalSpire.DateMemoryPlayback)`；输入表达式：`AttachMemoryPlayback(data, person, memory, CreateDateMemoryPlayback(data, memory))`；返回值紧邻使用处：`ExpressionStatementSyntax: AttachMemoryPlayback(data, person, memory, CreateDateMemoryPlayback(data, memory));`
- `NationalSpire.CareerScreen.CreateDateMemoryPlayback(NationalSpire.CareerData, NationalSpire.DateSceneMemory)`；输入表达式：`CreateDateMemoryPlayback(data, memory)`；返回值紧邻使用处：`ArgumentSyntax: CreateDateMemoryPlayback(data, memory)`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _cancelDialog?.Invoke()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a203b37d1b91"></a>

## `NationalSpire.CareerScreen.AttachMemoryPlayback(NationalSpire.CareerData, string, NationalSpire.DateSceneMemory, NationalSpire.DateMemoryPlayback) — private void AttachMemoryPlayback(CareerData data, string person, DateSceneMemory memory, DateMemoryPlayback replay)`

来源：源码第 122 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.EnterDiaryMemory(NationalSpire.CareerData, string, NationalSpire.DateSceneMemory)`](DateDiaryScreen.cs.md#symbol-15d246c49d27)；[`NationalSpire.CareerScreen.OpenDateMemory(NationalSpire.CareerData, string, NationalSpire.DateSceneMemory)`](DateSceneMemoryScreen.cs.md#symbol-5a8c8e2619a9)

**调用：** [`NationalSpire.CareerScreen.DateDiaryEntryDialog(NationalSpire.CareerData, string, string)`](DateDiaryScreen.cs.md#symbol-fb4ba1a3b5fa)；[`NationalSpire.CareerScreen.DeleteDateHistoryReply(string, string, string, NationalSpire.DateSceneMemory?, System.Action?)`](DateSceneHistoryScreen.cs.md#symbol-aab4554aa037)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`](CareerDialog.cs.md#symbol-df0355cc8433)；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.IsInsideTree()`；`System.Action.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.WorldId`；`NationalSpire.CareerScreen._cancelDialog`；`NationalSpire.CareerScreen._dateMemoryPlayback`；`NationalSpire.CareerScreen._stage`；`NationalSpire.CareerScreen.DateDiaryEntryDialog(NationalSpire.CareerData, string, string)`；`NationalSpire.CareerScreen.DeleteDateHistoryReply(string, string, string, NationalSpire.DateSceneMemory?, System.Action?)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.DateMemoryPlayback.Closed`；`NationalSpire.DateMemoryPlayback.DeleteReply`；`NationalSpire.DateMemoryPlayback.OpeningFailed`；`NationalSpire.DateMemoryPlayback.RefreshHistory()`；`NationalSpire.DateSceneMemory.Host`；`NationalSpire.DateSceneMemory.OfferId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`IsQueuedForDeletion()`；返回值紧邻使用处：`BinaryExpressionSyntax: _dateMemoryPlayback != replay || !IsInsideTree() || IsQueuedForDeletion()`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`IsQueuedForDeletion()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsQueuedForDeletion()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_stage.AddChild(replay)`；返回值紧邻使用处：`ExpressionStatementSyntax: _stage.AddChild(replay);`
- `Godot.Node.IsInsideTree()`；输入表达式：`IsInsideTree()`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInsideTree() && !IsQueuedForDeletion()`
- `Godot.Node.IsInsideTree()`；输入表达式：`IsInsideTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInsideTree()`
- `NationalSpire.CareerScreen.DateDiaryEntryDialog(NationalSpire.CareerData, string, string)`；输入表达式：`DateDiaryEntryDialog(ViewData, person, memory.OfferId)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateDiaryEntryDialog(ViewData, person, memory.OfferId);`
- `NationalSpire.CareerScreen.DeleteDateHistoryReply(string, string, string, NationalSpire.DateSceneMemory?, System.Action?)`；输入表达式：`DeleteDateHistoryReply(memory.Host, memory.OfferId, id, memory, replay.RefreshHistory)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => DeleteDateHistoryReply(memory.Host, memory.OfferId, id, memory, replay.RefreshHistory)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；输入表达式：`ShowCareerDialog("回忆打开失败", error.Message, () =>              {                  _cancelDialog?.Invoke();                  DateDiaryEntryDialog(ViewData, person, memory.OfferId);                  return true;              }, "返回日记", showCancel: false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("回忆打开失败", error.Message, () =>              {                  _cancelDialog?.Invoke();                  DateDiaryEntryDialog(ViewData, person, memory.OfferId);                  return true;              }, "返回日记", showCancel: false);`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _cancelDialog?.Invoke()`

**赋值（含属性/字段和局部值）：**

- `_dateMemoryPlayback` = `null`
- `_dateMemoryPlayback` = `replay`
- `replay.Closed` = `() =>          {              if (_dateMemoryPlayback != replay) return;              _dateMemoryPlayback = null;              if (IsInsideTree() && !IsQueuedForDeletion() && ViewData.WorldId == data.WorldId) DateDiaryEntryDialog(ViewData, person, memory.OfferId);          }`
- `replay.DeleteReply` = `id => DeleteDateHistoryReply(memory.Host, memory.OfferId, id, memory, replay.RefreshHistory)`
- `replay.OpeningFailed` = `error =>          {              if (_dateMemoryPlayback != replay || !IsInsideTree() || IsQueuedForDeletion() || ViewData.WorldId != data.WorldId) return;              _dateMemoryPlayback = null;              ShowCareerDialog("回忆打开失败", error.Message, () =>              {                  _cancelDialog?.Invoke();                  DateDiaryEntryDialog(ViewData, person, memory.OfferId);                  return true;              }, "返回日记", showCancel: false);          }`
- `replay.TreeExited` += `() => { if (_dateMemoryPlayback == replay) _dateMemoryPlayback = null; }`
