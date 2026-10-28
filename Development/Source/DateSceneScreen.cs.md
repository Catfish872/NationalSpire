# DateSceneScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`85E93C43DA83F79633D794D5BE680A65C075AB87696AAAAA81E36D521F30BBAB`。来源：[源码](../../DateSceneScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
private DateSceneView? _dateView;
private DateSceneAssets? _dateAssets;
private PortraitDesign? _dateDesign;
private string _datePerson = "", _dateOffer = "", _dateKey = "", _dateTurn = "", _dateReply = "", _dateState = "", _dateAttachments = "", _dateSource = "";
private List<DateSceneLine> _dateLines = [];
private List<DateSceneBackground> _dateBackgrounds = [];
private string _dateBackground = "", _dateInitialBackground = "";
private int _dateIndex;
private string _dateEditingTurn = "";
private readonly Dictionary<string, Texture2D> _dateTextures = [];
private readonly HashSet<string> _dateMissingTextures = [];
private string _dateTextureWarning = "";
private (string Path, DateTime DesignTime, DateTime AssetTime, bool Ready) _dateAvailability;
```

<a id="symbol-d6c92b4f494c"></a>

## `NationalSpire.CareerScreen.PromptDateScene(string) — private void PromptDateScene(string offer)`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddDateSceneAction(NationalSpire.CareerData, NationalSpire.PrivateOffer, Godot.HBoxContainer)`](DateSceneScreen.cs.md#symbol-413adf55a103)

**调用：** [`NationalSpire.CareerScreen.OpenDateAssets(NationalSpire.CareerData, string)`](DateSceneAssetScreen.cs.md#symbol-a45b4a628cd5)；[`NationalSpire.CareerScreen.OpenDateScene(string)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`](CareerStore.cs.md#symbol-ead7461ee7cb)；[`NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`](DateSceneAssets.cs.md#symbol-57fe620f4cc9)；[`NationalSpire.DateSceneAssetStore.Ready(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign?)`](DateSceneAssets.cs.md#symbol-79425fed4748)；[`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`](DateSceneData.cs.md#symbol-0d3e014bcb63)；[`NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`](PortraitDesignStore.cs.md#symbol-8db102d73ed8)；[`NationalSpire.PortraitDesignStore.Read(string, string)`](PortraitDesignStore.cs.md#symbol-2eeba99f517d)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen.OpenDateAssets(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen.OpenDateScene(string)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；`NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`；`NationalSpire.DateSceneAssetStore.Ready(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign?)`；`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；`NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`；`NationalSpire.PortraitDesignStore.Read(string, string)`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(() => { if (!IsInstanceValid(this) || !CareerStore.IsCurrent(data)) return; if (issue == null) OpenDateScene(offer); else OpenDateAssets(data, person); }).CallDeferred()`；返回值紧邻使用处：`ExpressionStatementSyntax: Callable.From(() => { if (!IsInstanceValid(this) || !CareerStore.IsCurrent(data)) return; if (issue == null) OpenDateScene(offer); else OpenDateAssets(data, person); }).CallDeferred();`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(() => { if (!IsInstanceValid(this) || !CareerStore.IsCurrent(data)) return; if (issue == null) OpenDateScene(offer); else OpenDateAssets(data, person); })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(() => { if (!IsInstanceValid(this) || !CareerStore.IsCurrent(data)) return; if (issue == null) OpenDateScene(offer); else OpenDateAssets(data, person); }).CallDeferred`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(this)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(this)`
- `NationalSpire.CareerScreen.OpenDateAssets(NationalSpire.CareerData, string)`；输入表达式：`OpenDateAssets(data, person)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenDateAssets(data, person);`
- `NationalSpire.CareerScreen.OpenDateScene(string)`；输入表达式：`OpenDateScene(offer)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenDateScene(offer);`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog(issue == null ? "进入约会场景" : "准备角色立绘", issue ?? "以视觉小说方式继续这次活动；场景对话保存在约会历史中，附件与关系变化继续生效。", () =>          {              Callable.From(() => { if (!IsInstanceValid(this) || !CareerStore.IsCurrent(data)) return; if (issue == null) OpenDateScene(offer); else OpenDateAssets(data, person); }).CallDeferred(); return true;          }, issue == null ? "进入场景" : "导入立绘", cancelText: "继续私聊")`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog(issue == null ? "进入约会场景" : "准备角色立绘", issue ?? "以视觉小说方式继续这次活动；场景对话保存在约会历史中，附件与关系变化继续生效。", () =>          {              Callable.From(() => { if (!IsInstanceValid(this) || !CareerStore.IsCurrent(data)) return; if (issue == null) OpenDateScene(offer); else OpenDateAssets(data, person); }).CallDeferred(); return true;          }, issue == null ? "进入场景" : "导入立绘", cancelText: "继续私聊");`
- `NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；输入表达式：`CareerStore.IsCurrent(data)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CareerStore.IsCurrent(data)`
- `NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`；输入表达式：`DateSceneAssetStore.Read(data, person)`；返回值紧邻使用处：`ArgumentSyntax: DateSceneAssetStore.Read(data, person)`
- `NationalSpire.DateSceneAssetStore.Ready(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign?)`；输入表达式：`DateSceneAssetStore.Ready(DateSceneAssetStore.Read(data, person), PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person))`；返回值紧邻使用处：`AssignmentExpressionSyntax: issue = DateSceneAssetStore.Ready(DateSceneAssetStore.Read(data, person), PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person))`
- `NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；输入表达式：`DateScenes.Available(data, o, conversation)`；返回值紧邻使用处：`BinaryExpressionSyntax: o.Id == offer && DateScenes.Available(data, o, conversation)`
- `NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`；输入表达式：`PortraitDesignStore.FilePath(data, person)`；返回值紧邻使用处：`ArgumentSyntax: PortraitDesignStore.FilePath(data, person)`
- `NationalSpire.PortraitDesignStore.Read(string, string)`；输入表达式：`PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person)`；返回值紧邻使用处：`ArgumentSyntax: PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person)`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(data, person)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.Offers.Any(o => o.Id == offer && DateScenes.Available(data, o, conversation))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !conversation.Offers.Any(o => o.Id == offer && DateScenes.Available(data, o, conversation))`

**赋值（含属性/字段和局部值）：**

- `issue` = `DateSceneAssetStore.Ready(DateSceneAssetStore.Read(data, person), PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person))`
- `issue` = `e.Message`

<a id="symbol-277baf4e7cb8"></a>

## `NationalSpire.CareerScreen.SceneRequest(bool) — private DateSceneRequest SceneRequest(bool opening = false)`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenDateScene(string)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)；[`NationalSpire.CareerScreen.SendPrivate()`](PrivateMessageScreen.cs.md#symbol-748ab66a7351)

**调用：** [`NationalSpire.CareerScreen.SpriteVariants(string)`](DateSceneScreen.cs.md#symbol-e038e794d751)；[`NationalSpire.DateSceneBackgrounds.AutomaticChoices(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneBackground>)`](DateSceneBackgrounds.cs.md#symbol-7e409d1b4e9f)；`NationalSpire.DateSceneRequest.DateSceneRequest()`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._dateAssets`；`NationalSpire.CareerScreen._dateBackground`；`NationalSpire.CareerScreen._dateBackgrounds`；`NationalSpire.CareerScreen._dateDesign`；`NationalSpire.CareerScreen._dateOffer`；`NationalSpire.CareerScreen.SpriteVariants(string)`；`NationalSpire.DateSceneAssets.OutfitId`；`NationalSpire.DateSceneBackground.Description`；`NationalSpire.DateSceneBackground.Id`；`NationalSpire.DateSceneBackgrounds.AutomaticChoices(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneBackground>)`；`NationalSpire.DateSceneRequest.Backgrounds`；`NationalSpire.DateSceneRequest.CurrentBackground`；`NationalSpire.DateSceneRequest.DefaultEmotionId`；`NationalSpire.DateSceneRequest.Emotions`；`NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.DateSceneRequest.Opening`；`NationalSpire.DateSceneRequest.OutfitId`；`NationalSpire.PortraitDesign.DefaultEmotionId`；`NationalSpire.PortraitDesign.Emotions`；`NationalSpire.PortraitEmotion.Description`；`NationalSpire.PortraitEmotion.Enabled`；`NationalSpire.PortraitEmotion.Id`；`NationalSpire.PortraitEmotion.Name`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.SpriteVariants(string)`；输入表达式：`SpriteVariants(e.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: SpriteVariants(e.Id).Count`
- `NationalSpire.DateSceneBackgrounds.AutomaticChoices(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneBackground>)`；输入表达式：`DateSceneBackgrounds.AutomaticChoices(_dateBackgrounds)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateSceneBackgrounds.AutomaticChoices(_dateBackgrounds).ToDictionary`
- `NationalSpire.DateSceneRequest.DateSceneRequest()`；输入表达式：`new()      {          OfferId = _dateOffer, OutfitId = _dateAssets!.OutfitId, Opening = opening,          DefaultEmotionId = _dateDesign!.DefaultEmotionId,          Emotions = _dateDesign!.Emotions.Where(e => e.Enabled && SpriteVariants(e.Id).Count > 0).ToDictionary(e => e.Id, e => e.Name + "：" + e.Description),          Backgrounds = DateSceneBackgrounds.AutomaticChoices(_dateBackgrounds).ToDictionary(b => b.Id, b => b.Description), CurrentBackground = _dateBackground      }`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new()      {          OfferId = _dateOffer, OutfitId = _dateAssets!.OutfitId, Opening = opening,          DefaultEmotionId = _dateDesign!.DefaultEmotionId,          Emotions = _dateDesign!.Emotions.Where(e => e.Enabled && SpriteVariants(e.Id).Count > 0).ToDictionary(e => e.Id, e => e.Name + "：" + e.Description),          Backgrounds = DateSceneBackgrounds.AutomaticChoices(_dateBackgrounds).ToDictionary(b => b.Id, b => b.Description), CurrentBackground = _dateBackground      }`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`_dateDesign!.Emotions.Where(e => e.Enabled && SpriteVariants(e.Id).Count > 0).ToDictionary(e => e.Id, e => e.Name + "：" + e.Description)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Emotions = _dateDesign!.Emotions.Where(e => e.Enabled && SpriteVariants(e.Id).Count > 0).ToDictionary(e => e.Id, e => e.Name + "：" + e.Description)`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`DateSceneBackgrounds.AutomaticChoices(_dateBackgrounds).ToDictionary(b => b.Id, b => b.Description)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Backgrounds = DateSceneBackgrounds.AutomaticChoices(_dateBackgrounds).ToDictionary(b => b.Id, b => b.Description)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`_dateDesign!.Emotions.Where(e => e.Enabled && SpriteVariants(e.Id).Count > 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _dateDesign!.Emotions.Where(e => e.Enabled && SpriteVariants(e.Id).Count > 0).ToDictionary`

**赋值（含属性/字段和局部值）：**

- `Backgrounds` = `DateSceneBackgrounds.AutomaticChoices(_dateBackgrounds).ToDictionary(b => b.Id, b => b.Description)`
- `CurrentBackground` = `_dateBackground`
- `DefaultEmotionId` = `_dateDesign!.DefaultEmotionId`
- `Emotions` = `_dateDesign!.Emotions.Where(e => e.Enabled && SpriteVariants(e.Id).Count > 0).ToDictionary(e => e.Id, e => e.Name + "：" + e.Description)`
- `OfferId` = `_dateOffer`
- `Opening` = `opening`
- `OutfitId` = `_dateAssets!.OutfitId`

<a id="symbol-bb8a80d5df80"></a>

## `NationalSpire.CareerScreen.OpenDateScene(string) — private void OpenDateScene(string offer)`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPausedDateScenes(NationalSpire.CareerData, NationalSpire.PrivateConversation)`](DateSceneScreen.cs.md#symbol-a5b10d9fb0b8)；[`NationalSpire.CareerScreen.PromptDateScene(string)`](DateSceneScreen.cs.md#symbol-d6c92b4f494c)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerScreen.CloseDateScene()`](DateSceneScreen.cs.md#symbol-375f9bc3e86a)；[`NationalSpire.CareerScreen.DateTexture(string)`](DateSceneScreen.cs.md#symbol-f1499ce9d9b1)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.PrivateActions()`](PrivateMessageScreen.cs.md#symbol-6e8c11ead905)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.SceneRequest(bool)`](DateSceneScreen.cs.md#symbol-277baf4e7cb8)；[`NationalSpire.CareerScreen.SpriteVariants(string)`](DateSceneScreen.cs.md#symbol-e038e794d751)；[`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)；[`NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`](DateSceneAssets.cs.md#symbol-57fe620f4cc9)；[`NationalSpire.DateSceneAssetStore.Ready(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign?)`](DateSceneAssets.cs.md#symbol-79425fed4748)；[`NationalSpire.DateSceneBackgrounds.Read(out string, string?)`](DateSceneBackgrounds.cs.md#symbol-b6c3bc7d87d9)；[`NationalSpire.DateSceneBackgrounds.RegisterLegacy(string)`](DateSceneBackgrounds.cs.md#symbol-7feab11c4c5b)；[`NationalSpire.DateScenes.History(NationalSpire.PrivateConversation, string, string, int, string, string)`](DateSceneData.cs.md#symbol-13e129fe5e9e)；[`NationalSpire.DateScenes.Validate(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest)`](DateSceneData.cs.md#symbol-190a72e967ad)；[`NationalSpire.DateSceneView.AffectionVisibility(bool)`](DateSceneView.cs.md#symbol-7da14922fda4)；[`NationalSpire.DateSceneView.Background(string, bool, double)`](DateSceneView.cs.md#symbol-9c58edcaf529)；[`NationalSpire.DateSceneView.Preferences(int, double, double)`](DateSceneView.cs.md#symbol-878552c24bd8)；[`NationalSpire.DateSceneView.Presentation(double, double, double, bool)`](DateSceneView.cs.md#symbol-32ea38e8c82d)；[`NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`](PortraitDesignStore.cs.md#symbol-8db102d73ed8)；[`NationalSpire.PortraitDesignStore.Key(NationalSpire.CareerData, string)`](PortraitDesignStore.cs.md#symbol-2ed1ee155b2d)；[`NationalSpire.PortraitDesignStore.Read(string, string)`](PortraitDesignStore.cs.md#symbol-2eeba99f517d)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`Godot.CanvasItem.Hide()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`NationalSpire.DateSceneRequest.DateSceneRequest()`；`NationalSpire.DateSceneView.DateSceneView()`；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.InvalidOperationException.InvalidOperationException(string?)`；`System.IO.InvalidDataException.InvalidDataException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerScreen._dateAssets`；`NationalSpire.CareerScreen._dateAttachments`；`NationalSpire.CareerScreen._dateBackground`；`NationalSpire.CareerScreen._dateBackgrounds`；`NationalSpire.CareerScreen._dateDesign`；`NationalSpire.CareerScreen._dateEditingTurn`；`NationalSpire.CareerScreen._dateIndex`；`NationalSpire.CareerScreen._dateInitialBackground`；`NationalSpire.CareerScreen._dateKey`；`NationalSpire.CareerScreen._dateLines`；`NationalSpire.CareerScreen._dateOffer`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateReply`；`NationalSpire.CareerScreen._dateSource`；`NationalSpire.CareerScreen._dateState`；`NationalSpire.CareerScreen._dateTurn`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen._privateInput`；`NationalSpire.CareerScreen._privateOverlay`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen._stage`；`NationalSpire.CareerScreen.AdvanceDateScene()`；`NationalSpire.CareerScreen.CloseDateScene()`；`NationalSpire.CareerScreen.DateSceneExitChoices()`；`NationalSpire.CareerScreen.DateSceneSettings()`；`NationalSpire.CareerScreen.DateTexture(string)`；`NationalSpire.CareerScreen.EditFailedDateScene()`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.PrivateActions()`；`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`；`NationalSpire.CareerScreen.RegenerateDateScene()`；`NationalSpire.CareerScreen.SceneRequest(bool)`；`NationalSpire.CareerScreen.SendDateScene()`；`NationalSpire.CareerScreen.SpriteVariants(string)`；`NationalSpire.CareerScreen.TickDateScene()`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.DateSceneAssets.Background`；`NationalSpire.DateSceneAssets.BlurAmount`；`NationalSpire.DateSceneAssets.FontSize`；`NationalSpire.DateSceneAssets.LetterSpacing`；`NationalSpire.DateSceneAssets.OutfitId`；`NationalSpire.DateSceneAssets.PanelFade`；`NationalSpire.DateSceneAssets.ShowAffectionBadge`；`NationalSpire.DateSceneAssets.SpriteScale`；`NationalSpire.DateSceneAssets.SpriteX`；`NationalSpire.DateSceneAssets.SpriteY`；`NationalSpire.DateSceneAssets.TextOutline`；`NationalSpire.DateSceneAssets.TextSpeed`；`NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`；`NationalSpire.DateSceneAssetStore.Ready(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign?)`；`NationalSpire.DateSceneBackground.Id`；`NationalSpire.DateSceneBackground.Image`；`NationalSpire.DateSceneBackgrounds.Read(out string, string?)`；`NationalSpire.DateSceneBackgrounds.RegisterLegacy(string)`；`NationalSpire.DateSceneRequest.DefaultEmotionId`；`NationalSpire.DateSceneRequest.Emotions`；`NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.DateSceneRequest.Opening`；`NationalSpire.DateSceneRequest.OutfitId`；`NationalSpire.DateScenes.History(NationalSpire.PrivateConversation, string, string, int, string, string)`；`NationalSpire.DateScenes.Validate(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest)`；`NationalSpire.DateSceneView.AddAttachment`；`NationalSpire.DateSceneView.Advance`；`NationalSpire.DateSceneView.AffectionVisibility(bool)`；`NationalSpire.DateSceneView.Background(string, bool, double)`；`NationalSpire.DateSceneView.Blocked`；`NationalSpire.DateSceneView.Editor`；`NationalSpire.DateSceneView.Exit`；`NationalSpire.DateSceneView.HistoryText`；`NationalSpire.DateSceneView.Preferences(int, double, double)`；`NationalSpire.DateSceneView.Presentation(double, double, double, bool)`；`NationalSpire.DateSceneView.Regenerate`；`NationalSpire.DateSceneView.RetryStop`；`NationalSpire.DateSceneView.ReturnToEdit`；`NationalSpire.DateSceneView.Settings`；`NationalSpire.DateSceneView.Status`；`NationalSpire.DateSceneView.Submit`；`NationalSpire.DateSceneView.TextSpeed`；`NationalSpire.DateSceneView.Tick`；`NationalSpire.DateSceneView.WaitingDefault`；`NationalSpire.DateSceneView.WaitingSprites`；`NationalSpire.PortraitDesign.DefaultEmotionId`；`NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`；`NationalSpire.PortraitDesignStore.Key(NationalSpire.CareerData, string)`；`NationalSpire.PortraitDesignStore.Read(string, string)`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMessageCommand.Scene`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.Scene`；`NationalSpire.PrivateTurn.Status`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`.Hide()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _privateOverlay?.Hide()`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`view.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: view.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_privateInput)`；返回值紧邻使用处：`BinaryExpressionSyntax: _privateInput != null && IsInstanceValid(_privateInput)`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_stage.AddChild(view)`；返回值紧邻使用处：`ExpressionStatementSyntax: _stage.AddChild(view);`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(ViewData, _datePerson)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.DisplayName(ViewData, _datePerson)`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(ViewData)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.Name(ViewData)`
- `NationalSpire.CareerScreen.CloseDateScene()`；输入表达式：`CloseDateScene()`；返回值紧邻使用处：`ExpressionStatementSyntax: CloseDateScene();`
- `NationalSpire.CareerScreen.DateTexture(string)`；输入表达式：`DateTexture(defaults[0])`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateTexture(defaults[0])`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("本次修订保留原消息附件；新附件可在下一轮添加。", false)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("本次修订保留原消息附件；新附件可在下一轮添加。", false);`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("打开约会场景失败：" + e.Message, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("打开约会场景失败：" + e.Message, true);`
- `NationalSpire.CareerScreen.PrivateActions()`；输入表达式：`PrivateActions()`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateActions();`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`；输入表达式：`PrivateCommand("dm-date-open", new() { Scene = SceneRequest(true) })`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateCommand("dm-date-open", new() { Scene = SceneRequest(true) });`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`；输入表达式：`PrivateCommand(PrivateMessages.Conversation(ViewData, _datePerson).Turns.Any(t => t.Status is "queued" or "sending") ? "dm-stop" : "dm-retry", new())`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => PrivateCommand(PrivateMessages.Conversation(ViewData, _datePerson).Turns.Any(t => t.Status is "queued" or "sending") ? "dm-stop" : "dm-retry", new())`
- `NationalSpire.CareerScreen.SceneRequest(bool)`；输入表达式：`SceneRequest(true)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Scene = SceneRequest(true)`
- `NationalSpire.CareerScreen.SpriteVariants(string)`；输入表达式：`SpriteVariants(_dateDesign.DefaultEmotionId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = SpriteVariants(_dateDesign.DefaultEmotionId)`
- `NationalSpire.CareerScreen.TickDateScene()`；输入表达式：`TickDateScene()`；返回值紧邻使用处：`ExpressionStatementSyntax: TickDateScene();`
- `NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`；输入表达式：`DateSceneAssetStore.Read(data, person)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dateAssets = DateSceneAssetStore.Read(data, person)`
- `NationalSpire.DateSceneAssetStore.Ready(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign?)`；输入表达式：`DateSceneAssetStore.Ready(_dateAssets, _dateDesign)`；返回值紧邻使用处：`IsPatternExpressionSyntax: DateSceneAssetStore.Ready(_dateAssets, _dateDesign) is { } reason`
- `NationalSpire.DateSceneBackgrounds.Read(out string, string?)`；输入表达式：`DateSceneBackgrounds.Read(out string backgroundWarning)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dateBackgrounds = DateSceneBackgrounds.Read(out string backgroundWarning)`
- `NationalSpire.DateSceneBackgrounds.RegisterLegacy(string)`；输入表达式：`DateSceneBackgrounds.RegisterLegacy(_dateAssets.Background)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dateAssets.Background = DateSceneBackgrounds.RegisterLegacy(_dateAssets.Background)`
- `NationalSpire.DateSceneRequest.DateSceneRequest()`；输入表达式：`new DateSceneRequest { OfferId = offer, OutfitId = _dateAssets.OutfitId, DefaultEmotionId = _dateDesign!.DefaultEmotionId, Emotions = new() { [_dateDesign.DefaultEmotionId] = "默认" } }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new DateSceneRequest { OfferId = offer, OutfitId = _dateAssets.OutfitId, DefaultEmotionId = _dateDesign!.DefaultEmotionId, Emotions = new() { [_dateDesign.DefaultEmotionId] = "默认" } }`
- `NationalSpire.DateScenes.History(NationalSpire.PrivateConversation, string, string, int, string, string)`；输入表达式：`DateScenes.History(PrivateMessages.Conversation(ViewData, _datePerson), _dateOffer, _dateState == "complete" ? _dateTurn : "", _dateIndex, CareerEngine.Name(ViewData), CareerEngine.DisplayName(ViewData, _datePerson))`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => DateScenes.History(PrivateMessages.Conversation(ViewData, _datePerson), _dateOffer, _dateState == "complete" ? _dateTurn : "", _dateIndex, CareerEngine.Name(ViewData), CareerEngine.DisplayName(ViewData, _datePerson))`
- `NationalSpire.DateScenes.Validate(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest)`；输入表达式：`DateScenes.Validate(data, PrivateMessages.Conversation(data, person), check)`；返回值紧邻使用处：`IsPatternExpressionSyntax: DateScenes.Validate(data, PrivateMessages.Conversation(data, person), check) is { } error`
- `NationalSpire.DateSceneView.AffectionVisibility(bool)`；输入表达式：`view.AffectionVisibility(_dateAssets.ShowAffectionBadge)`；返回值紧邻使用处：`ExpressionStatementSyntax: view.AffectionVisibility(_dateAssets.ShowAffectionBadge);`
- `NationalSpire.DateSceneView.Background(string, bool, double)`；输入表达式：`view.Background(_dateBackgrounds.FirstOrDefault(b => b.Id == _dateBackground)?.Image ?? "", true, _dateAssets.BlurAmount)`；返回值紧邻使用处：`ExpressionStatementSyntax: view.Background(_dateBackgrounds.FirstOrDefault(b => b.Id == _dateBackground)?.Image ?? "", true, _dateAssets.BlurAmount);`
- `NationalSpire.DateSceneView.DateSceneView()`；输入表达式：`new DateSceneView { TextSpeed = _dateAssets.TextSpeed, WaitingSprites = [initialTexture],                  WaitingDefault = initialTexture }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new DateSceneView { TextSpeed = _dateAssets.TextSpeed, WaitingSprites = [initialTexture],                  WaitingDefault = initialTexture }`
- `NationalSpire.DateSceneView.Preferences(int, double, double)`；输入表达式：`view.Preferences(_dateAssets.FontSize, _dateAssets.PanelFade, _dateAssets.LetterSpacing)`；返回值紧邻使用处：`ExpressionStatementSyntax: view.Preferences(_dateAssets.FontSize, _dateAssets.PanelFade, _dateAssets.LetterSpacing);`
- `NationalSpire.DateSceneView.Presentation(double, double, double, bool)`；输入表达式：`view.Presentation(_dateAssets.SpriteScale, _dateAssets.SpriteX, _dateAssets.SpriteY, _dateAssets.TextOutline)`；返回值紧邻使用处：`ExpressionStatementSyntax: view.Presentation(_dateAssets.SpriteScale, _dateAssets.SpriteX, _dateAssets.SpriteY, _dateAssets.TextOutline);`
- `NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`；输入表达式：`PortraitDesignStore.FilePath(data, person)`；返回值紧邻使用处：`ArgumentSyntax: PortraitDesignStore.FilePath(data, person)`
- `NationalSpire.PortraitDesignStore.Key(NationalSpire.CareerData, string)`；输入表达式：`PortraitDesignStore.Key(data, person)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dateKey = PortraitDesignStore.Key(data, person)`
- `NationalSpire.PortraitDesignStore.Read(string, string)`；输入表达式：`PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dateDesign = PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person)`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Scene = SceneRequest(true) }`；返回值紧邻使用处：`ArgumentSyntax: new() { Scene = SceneRequest(true) }`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new()`；返回值紧邻使用处：`ArgumentSyntax: new()`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, person)`；返回值紧邻使用处：`ArgumentSyntax: PrivateMessages.Conversation(data, person)`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(data, person)`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(ViewData, _datePerson)`；返回值紧邻使用处：`ArgumentSyntax: PrivateMessages.Conversation(ViewData, _datePerson)`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(ViewData, _datePerson)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Conversation(ViewData, _datePerson).Turns`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new() { [_dateDesign.DefaultEmotionId] = "默认" }`；返回值紧邻使用处：`AssignmentExpressionSyntax: Emotions = new() { [_dateDesign.DefaultEmotionId] = "默认" }`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`_dateAssets.Background.All(char.IsAsciiHexDigit)`；返回值紧邻使用处：`BinaryExpressionSyntax: _dateAssets.Background.Length == 64 && _dateAssets.Background.All(char.IsAsciiHexDigit)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`_dateBackgrounds.Any(b => b.Id == _dateAssets.Background)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _dateBackgrounds.Any(b => b.Id == _dateAssets.Background) ? _dateAssets.Background : ""`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.Any(t => t.Scene?.OfferId == offer && t.Scene.Opening && !t.ReplyDeleted)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !c.Turns.Any(t => t.Scene?.OfferId == offer && t.Scene.Opening && !t.ReplyDeleted)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateMessages.Conversation(ViewData, _datePerson).Turns.Any(t => t.Status is "queued" or "sending")`；返回值紧邻使用处：`ConditionalExpressionSyntax: PrivateMessages.Conversation(ViewData, _datePerson).Turns.Any(t => t.Status is "queued" or "sending") ? "dm-stop" : "dm-retry"`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`_dateBackgrounds.FirstOrDefault(b => b.Id == _dateBackground)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _dateBackgrounds.FirstOrDefault(b => b.Id == _dateBackground)?.Image`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException(error)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException(error);`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException(reason)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException(reason);`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException($"请导入有效的默认立绘 {_dateDesign.DefaultEmotionId}.png 或对应编号变体。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException($"请导入有效的默认立绘 {_dateDesign.DefaultEmotionId}.png 或对应编号变体。");`

**赋值（含属性/字段和局部值）：**

- `_dateAssets.Background` = `""`
- `_dateAssets.Background` = `DateSceneBackgrounds.RegisterLegacy(_dateAssets.Background)`
- `_dateAssets` = `DateSceneAssetStore.Read(data, person)`
- `_dateAttachments` = `_dateSource = ""`
- `_dateBackground` = `_dateInitialBackground = _dateBackgrounds.Any(b => b.Id == _dateAssets.Background) ? _dateAssets.Background : ""`
- `_dateBackgrounds` = `DateSceneBackgrounds.Read(out string backgroundWarning)`
- `_dateDesign` = `PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person)`
- `_dateEditingTurn` = `""`
- `_dateIndex` = `0`
- `_dateInitialBackground` = `_dateBackgrounds.Any(b => b.Id == _dateAssets.Background) ? _dateAssets.Background : ""`
- `_dateKey` = `PortraitDesignStore.Key(data, person)`
- `_dateLines` = `[]`
- `_dateOffer` = `offer`
- `_datePerson` = `person`
- `_dateReply` = `_dateState = _dateAttachments = _dateSource = ""`
- `_dateSource` = `""`
- `_dateState` = `_dateAttachments = _dateSource = ""`
- `_dateTurn` = `_dateReply = _dateState = _dateAttachments = _dateSource = ""`
- `_dateView` = `view`
- `_privateInput.Text` = `view.Editor.Text`
- `[_dateDesign.DefaultEmotionId]` = `"默认"`
- `DefaultEmotionId` = `_dateDesign!.DefaultEmotionId`
- `Emotions` = `new() { [_dateDesign.DefaultEmotionId] = "默认" }`
- `OfferId` = `offer`
- `OutfitId` = `_dateAssets.OutfitId`
- `Scene` = `SceneRequest(true)`
- `TextSpeed` = `_dateAssets.TextSpeed`
- `view.AddAttachment` = `() => { if (_dateEditingTurn.Length == 0) PrivateActions(); else Notice("本次修订保留原消息附件；新附件可在下一轮添加。", false); }`
- `view.Advance` = `AdvanceDateScene`
- `view.Blocked` = `() => _dialogOverlay != null`
- `view.Editor.Text` = `_privateInput!.Text`
- `view.Editor.TextChanged` += `() => { if (_privateInput != null && IsInstanceValid(_privateInput)) _privateInput.Text = view.Editor.Text; }`
- `view.Exit` = `DateSceneExitChoices`
- `view.HistoryText` = `() => DateScenes.History(PrivateMessages.Conversation(ViewData, _datePerson), _dateOffer, _dateState == "complete" ? _dateTurn : "", _dateIndex, CareerEngine.Name(ViewData), CareerEngine.DisplayName(ViewData, _datePerson))`
- `view.Regenerate` = `RegenerateDateScene`
- `view.RetryStop` = `() => PrivateCommand(PrivateMessages.Conversation(ViewData, _datePerson).Turns.Any(t => t.Status is "queued" or "sending") ? "dm-stop" : "dm-retry", new())`
- `view.ReturnToEdit` = `EditFailedDateScene`
- `view.Settings` = `DateSceneSettings`
- `view.Status.Text` = `backgroundWarning`
- `view.Submit` = `SendDateScene`
- `view.Tick` = `TickDateScene`
- `WaitingDefault` = `initialTexture`
- `WaitingSprites` = `[initialTexture]`

<a id="symbol-375f9bc3e86a"></a>

## `NationalSpire.CareerScreen.CloseDateScene() — private void CloseDateScene()`

来源：源码第 85 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen._ExitTree()`](CareerScreen.cs.md#symbol-5aaebf0ee0ab)；[`NationalSpire.CareerScreen.ClosePrivateMessagesCore(bool)`](PrivateMessageScreen.cs.md#symbol-db8b0a9ff8de)；[`NationalSpire.CareerScreen.LeaveDateScene(bool)`](DateSceneScreen.cs.md#symbol-942f3afae68b)；[`NationalSpire.CareerScreen.OpenDateScene(string)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)；[`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)

**调用：** `Godot.CanvasItem.Show()`；`Godot.GodotObject.Dispose()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Node.QueueFree()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；`System.Collections.Generic.HashSet<T>.Clear()`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.List<T>.Clear()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._dateAssets`；`NationalSpire.CareerScreen._dateBackgrounds`；`NationalSpire.CareerScreen._dateDesign`；`NationalSpire.CareerScreen._dateMissingTextures`；`NationalSpire.CareerScreen._dateOffer`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateTextures`；`NationalSpire.CareerScreen._dateTextureWarning`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.CareerScreen._privateDrafts`；`NationalSpire.CareerScreen._privateInput`；`NationalSpire.CareerScreen._privateOverlay`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen._privateSignature`；`NationalSpire.DateSceneView.Editor`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Show()`；输入表达式：`_privateOverlay.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateOverlay.Show();`
- `Godot.GodotObject.Dispose()`；输入表达式：`texture.Dispose()`；返回值紧邻使用处：`ExpressionStatementSyntax: texture.Dispose();`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_dateView)`；返回值紧邻使用处：`BinaryExpressionSyntax: _dateView != null && IsInstanceValid(_dateView)`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_privateInput)`；返回值紧邻使用处：`BinaryExpressionSyntax: _privatePerson == _datePerson && _privateInput != null && IsInstanceValid(_privateInput)`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_privateOverlay)`；返回值紧邻使用处：`BinaryExpressionSyntax: _privateOverlay != null && IsInstanceValid(_privateOverlay)`
- `Godot.Node.QueueFree()`；输入表达式：`_dateView.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.QueueFree();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_dateTextures.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateTextures.Clear();`
- `System.Collections.Generic.HashSet<T>.Clear()`；输入表达式：`_dateMissingTextures.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateMissingTextures.Clear();`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`_dateTextures.Values.Distinct()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var texture in _dateTextures.Values.Distinct()) texture.Dispose();`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`_dateBackgrounds.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateBackgrounds.Clear();`

**赋值（含属性/字段和局部值）：**

- `_dateAssets` = `null`
- `_dateDesign` = `null`
- `_dateOffer` = `""`
- `_datePerson` = `_dateOffer = ""`
- `_dateTextureWarning` = `""`
- `_dateView` = `null`
- `_privateDrafts[_datePerson]` = `_dateView.Editor.Text`
- `_privateInput.Text` = `_dateView.Editor.Text`
- `_privateSignature` = `""`

<a id="symbol-52133982acce"></a>

## `NationalSpire.CareerScreen.DateSceneExitChoices() — private void DateSceneExitChoices()`

来源：源码第 101 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen._Input(Godot.InputEvent)`](CareerScreen.cs.md#symbol-a9891646fd75)

**调用：** [`NationalSpire.CareerScreen.LeaveDateScene(bool)`](DateSceneScreen.cs.md#symbol-942f3afae68b)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.Control()`；`Godot.Control.GetCombinedMinimumSize()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.FindChild(string, bool, bool)`；`Godot.Node.GetParent()`；`Godot.Node.MoveChild(Godot.Node, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._dateView`；`NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.CareerScreen.LeaveDateScene(bool)`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`resume.AddThemeColorOverride(state, Colors.Black)`；返回值紧邻使用处：`ExpressionStatementSyntax: resume.AddThemeColorOverride(state, Colors.Black);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 0)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 0);`
- `Godot.Control.Control()`；输入表达式：`new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Control.GetCombinedMinimumSize()`；输入表达式：`resume.GetCombinedMinimumSize()`；返回值紧邻使用处：`AssignmentExpressionSyntax: pause.CustomMinimumSize = resume.GetCombinedMinimumSize()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(end)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(end);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(gap1)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(gap1);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(gap2)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(gap2);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(pause)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(pause);`
- `Godot.Node.FindChild(string, bool, bool)`；输入表达式：`.FindChild("CareerDialogConfirm", true, false)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _dialogOverlay?.FindChild("CareerDialogConfirm", true, false)`
- `Godot.Node.GetParent()`；输入表达式：`resume.GetParent()`；返回值紧邻使用处：`CastExpressionSyntax: (HBoxContainer)resume.GetParent()`
- `Godot.Node.MoveChild(Godot.Node, int)`；输入表达式：`row.MoveChild(end, 0)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.MoveChild(end, 0);`
- `Godot.Node.MoveChild(Godot.Node, int)`；输入表达式：`row.MoveChild(gap1, 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.MoveChild(gap1, 1);`
- `Godot.Node.MoveChild(Godot.Node, int)`；输入表达式：`row.MoveChild(gap2, 3)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.MoveChild(gap2, 3);`
- `Godot.Node.MoveChild(Godot.Node, int)`；输入表达式：`row.MoveChild(pause, 2)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.MoveChild(pause, 2);`
- `NationalSpire.CareerScreen.LeaveDateScene(bool)`；输入表达式：`LeaveDateScene(false)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => LeaveDateScene(false)`
- `NationalSpire.CareerScreen.LeaveDateScene(bool)`；输入表达式：`LeaveDateScene(true)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => LeaveDateScene(true)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("结束约会", () => LeaveDateScene(true), 150)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton("结束约会", () => LeaveDateScene(true), 150)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("暂时返回私聊", () => LeaveDateScene(false), 150)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton("暂时返回私聊", () => LeaveDateScene(false), 150)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("返回私聊", "结束约会后返回私聊，聊天记录继续保留。暂时返回会保留当前进度。", () => true, "继续约会", showCancel: false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("返回私聊", "结束约会后返回私聊，聊天记录继续保留。暂时返回会保留当前进度。", () => true, "继续约会", showCancel: false);`

**赋值（含属性/字段和局部值）：**

- `button.SizeFlagsVertical` = `SizeFlags.Fill`
- `end.CustomMinimumSize` = `pause.CustomMinimumSize = resume.GetCombinedMinimumSize()`
- `pause.CustomMinimumSize` = `resume.GetCombinedMinimumSize()`
- `row.Alignment` = `BoxContainer.AlignmentMode.Begin`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-942f3afae68b"></a>

## `NationalSpire.CareerScreen.LeaveDateScene(bool) — private void LeaveDateScene(bool end)`

来源：源码第 116 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DateSceneExitChoices()`](DateSceneScreen.cs.md#symbol-52133982acce)

**调用：** [`NationalSpire.CareerScreen.CloseDateScene()`](DateSceneScreen.cs.md#symbol-375f9bc3e86a)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)；[`NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`](DateSceneAssets.cs.md#symbol-2bf1f40a912e)；`NationalSpire.DateSceneBookmark.DateSceneBookmark()`；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；`System.Action.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._cancelDialog`；`NationalSpire.CareerScreen._dateAssets`；`NationalSpire.CareerScreen._dateIndex`；`NationalSpire.CareerScreen._dateOffer`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateReply`；`NationalSpire.CareerScreen._dateState`；`NationalSpire.CareerScreen._dateTurn`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.CareerScreen.CloseDateScene()`；`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`；`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.DateSceneAssets.Bookmarks`；`NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`；`NationalSpire.DateSceneBookmark.Index`；`NationalSpire.DateSceneBookmark.ReplyHash`；`NationalSpire.DateSceneBookmark.Turn`；`NationalSpire.DateSceneView.Status`；`NationalSpire.PrivateMessageCommand.Offer`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.CloseDateScene()`；输入表达式：`CloseDateScene()`；返回值紧邻使用处：`ExpressionStatementSyntax: CloseDateScene();`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`；输入表达式：`PrivateCommand(end ? "dm-date-end" : "dm-date-pause", new() { Offer = _dateOffer }, () =>              { _cancelDialog?.Invoke(); CloseDateScene(); RefreshPrivateChat(); })`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateCommand(end ? "dm-date-end" : "dm-date-pause", new() { Offer = _dateOffer }, () =>              { _cancelDialog?.Invoke(); CloseDateScene(); RefreshPrivateChat(); });`
- `NationalSpire.CareerScreen.RefreshPrivateChat(bool)`；输入表达式：`RefreshPrivateChat()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshPrivateChat();`
- `NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`；输入表达式：`DateSceneAssetStore.Save(ViewData, _datePerson, _dateAssets)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateSceneAssetStore.Save(ViewData, _datePerson, _dateAssets);`
- `NationalSpire.DateSceneBookmark.DateSceneBookmark()`；输入表达式：`new() { Turn = _dateTurn, ReplyHash = _dateReply, Index = _dateIndex }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dateAssets.Bookmarks[_dateOffer] = new() { Turn = _dateTurn, ReplyHash = _dateReply, Index = _dateIndex }`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Offer = _dateOffer }`；返回值紧邻使用处：`ArgumentSyntax: new() { Offer = _dateOffer }`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _cancelDialog?.Invoke()`

**赋值（含属性/字段和局部值）：**

- `_dateAssets.Bookmarks[_dateOffer]` = `new() { Turn = _dateTurn, ReplyHash = _dateReply, Index = _dateIndex }`
- `_dateView.Status.Text` = `"保存约会状态失败：" + e.Message`
- `Index` = `_dateIndex`
- `Offer` = `_dateOffer`
- `ReplyHash` = `_dateReply`
- `Turn` = `_dateTurn`

<a id="symbol-a5b10d9fb0b8"></a>

## `NationalSpire.CareerScreen.AddPausedDateScenes(NationalSpire.CareerData, NationalSpire.PrivateConversation) — private void AddPausedDateScenes(CareerData data, PrivateConversation conversation)`

来源：源码第 128 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)

**调用：** [`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.OpenDateScene(string)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`](DateSceneData.cs.md#symbol-0d3e014bcb63)；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._privateBody`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.OpenDateScene(string)`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；`NationalSpire.PrivateConversation.DateSceneStates`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("353042", "cf9db9", 10, 16))`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("353042", "cf9db9", 10, 16));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateBody!.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateBody!.AddChild(panel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(PrivateButton("继续约会", () => OpenDateScene(offer.Id), 180))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(PrivateButton("继续约会", () => OpenDateScene(offer.Id), 180));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text("继续约会 · " + offer.Title, 20, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text("继续约会 · " + offer.Title, 20, _ink));`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { Name = "DateResumeCard" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { Name = "DateResumeCard" }`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(panel)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(panel)`
- `NationalSpire.CareerScreen.OpenDateScene(string)`；输入表达式：`OpenDateScene(offer.Id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenDateScene(offer.Id)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("继续约会", () => OpenDateScene(offer.Id), 180)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("继续约会", () => OpenDateScene(offer.Id), 180)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("继续约会 · " + offer.Title, 20, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text("继续约会 · " + offer.Title, 20, _ink)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("353042", "cf9db9", 10, 16)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("353042", "cf9db9", 10, 16)`
- `NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；输入表达式：`DateScenes.Available(data, o, conversation)`；返回值紧邻使用处：`BinaryExpressionSyntax: conversation.DateSceneStates.GetValueOrDefault(o.Id) == "paused" && DateScenes.Available(data, o, conversation)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.Offers.Where(o => conversation.DateSceneStates.GetValueOrDefault(o.Id) == "paused" && DateScenes.Available(data, o, conversation))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var offer in conversation.Offers.Where(o => conversation.DateSceneStates.GetValueOrDefault(o.Id) == "paused" && DateScenes.Available(data, o, conversation)))          {              var panel = new PanelContainer { Name = "DateResumeCard" }; panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("353042", "cf9db9", 10, 16));              _privateBody!.AddChild(panel); var box = Inner(panel); box.AddChild(Text("继续约会 · " + offer.Title, 20, _ink));              box.AddChild(PrivateButton("继续约会", () => OpenDateScene(offer.Id), 180));          }`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`conversation.DateSceneStates.GetValueOrDefault(o.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: conversation.DateSceneStates.GetValueOrDefault(o.Id) == "paused"`

**赋值（含属性/字段和局部值）：**

- `Name` = `"DateResumeCard"`

<a id="symbol-5923316321e9"></a>

## `NationalSpire.CareerScreen.TickDateScene() — private void TickDateScene()`

来源：源码第 137 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenDateScene(string)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)；[`NationalSpire.CareerScreen.RegenerateDateScene()`](DateSceneScreen.cs.md#symbol-c589255edb6a)；[`NationalSpire.CareerScreen.SendDateScene()`](DateSceneScreen.cs.md#symbol-b811d23c8af3)

**调用：** [`NationalSpire.AiService.PrivateKey(NationalSpire.CareerData, string)`](AiPrivateMessages.cs.md#symbol-97ba03595bc3)；[`NationalSpire.CareerScreen.CanRegenerateDate(NationalSpire.PrivateTurn?)`](DateSceneScreen.cs.md#symbol-1b2873272c7a)；[`NationalSpire.CareerScreen.CloseDateScene()`](DateSceneScreen.cs.md#symbol-375f9bc3e86a)；[`NationalSpire.CareerScreen.PrivateAttachmentCard(NationalSpire.PrivateOffer, bool)`](PrivateMemoryScreen.cs.md#symbol-eb2b2a37c5d1)；[`NationalSpire.CareerScreen.ShowDateLine()`](DateSceneScreen.cs.md#symbol-1580b0be190e)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`NationalSpire.DateSceneAssetStore.Hash(byte[])`](DateSceneAssets.cs.md#symbol-e8871d339d39)；[`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`](DateSceneData.cs.md#symbol-0d3e014bcb63)；[`NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`](DateSceneData.cs.md#symbol-801111e76ca9)；[`NationalSpire.DateSceneView.AppendLine(NationalSpire.DateSceneLine)`](DateSceneView.cs.md#symbol-eecb2292c03b)；[`NationalSpire.DateSceneView.Relationship(NationalSpire.PrivateRelation)`](DateSceneView.cs.md#symbol-949c1add6c05)；[`NationalSpire.DateSceneView.ShowAttachments()`](DateSceneView.cs.md#symbol-f99d5e4e9b59)；[`NationalSpire.DateSceneView.ShowWaiting(string, bool)`](DateSceneView.cs.md#symbol-c6c25a66fde3)；[`NationalSpire.DateSceneView.Streaming(bool)`](DateSceneView.cs.md#symbol-e7a96de3c199)；[`NationalSpire.PlayerFacingText.LongError(string)`](PlayerFacingText.cs.md#symbol-f9422d3b8971)；[`NationalSpire.PortraitDesignStore.Key(NationalSpire.CareerData, string)`](PortraitDesignStore.cs.md#symbol-2ed1ee155b2d)；[`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-25194feb6779)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；[`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-8a6bb6e78fa5)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Math.Clamp(int, int, int)`；`System.Math.Min(int, int)`；`System.Text.Encoding.GetBytes(string)`

**字段、属性、事件及方法组引用：** `(string Turn, System.Collections.Generic.List<NationalSpire.DateSceneLine> Lines).Lines`；`(string Turn, System.Collections.Generic.List<NationalSpire.DateSceneLine> Lines).Turn`；`NationalSpire.AiService.PrivateKey(NationalSpire.CareerData, string)`；`NationalSpire.AiService.PrivateSceneLive`；`NationalSpire.CareerScreen._dateAssets`；`NationalSpire.CareerScreen._dateAttachments`；`NationalSpire.CareerScreen._dateBackground`；`NationalSpire.CareerScreen._dateBackgrounds`；`NationalSpire.CareerScreen._dateEditingTurn`；`NationalSpire.CareerScreen._dateIndex`；`NationalSpire.CareerScreen._dateInitialBackground`；`NationalSpire.CareerScreen._dateKey`；`NationalSpire.CareerScreen._dateLines`；`NationalSpire.CareerScreen._dateOffer`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateReply`；`NationalSpire.CareerScreen._dateSource`；`NationalSpire.CareerScreen._dateState`；`NationalSpire.CareerScreen._dateTurn`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen._privateStatus`；`NationalSpire.CareerScreen.CanRegenerateDate(NationalSpire.PrivateTurn?)`；`NationalSpire.CareerScreen.CloseDateScene()`；`NationalSpire.CareerScreen.PrivateAttachmentCard(NationalSpire.PrivateOffer, bool)`；`NationalSpire.CareerScreen.PrivateAttachments`；`NationalSpire.CareerScreen.ShowDateLine()`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.DateSceneAssets.Bookmarks`；`NationalSpire.DateSceneAssetStore.Hash(byte[])`；`NationalSpire.DateSceneBackground.Id`；`NationalSpire.DateSceneBookmark.Index`；`NationalSpire.DateSceneBookmark.ReplyHash`；`NationalSpire.DateSceneBookmark.Turn`；`NationalSpire.DateSceneRequest.CurrentBackground`；`NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；`NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`；`NationalSpire.DateSceneView.AppendLine(NationalSpire.DateSceneLine)`；`NationalSpire.DateSceneView.Attachments`；`NationalSpire.DateSceneView.RegenerateButton`；`NationalSpire.DateSceneView.Relationship(NationalSpire.PrivateRelation)`；`NationalSpire.DateSceneView.ShowAttachments()`；`NationalSpire.DateSceneView.ShowWaiting(string, bool)`；`NationalSpire.DateSceneView.Status`；`NationalSpire.DateSceneView.Streaming(bool)`；`NationalSpire.PlayerFacingText.LongError(string)`；`NationalSpire.PortraitDesignStore.Key(NationalSpire.CareerData, string)`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateTurn.Error`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.PrivateTurn.Reply`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.Scene`；`NationalSpire.PrivateTurn.Status`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_dateView.Attachments.AddChild(PrivateAttachmentCard(item, true))`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.Attachments.AddChild(PrivateAttachmentCard(item, true));`
- `NationalSpire.AiService.PrivateKey(NationalSpire.CareerData, string)`；输入表达式：`AiService.PrivateKey(data, _datePerson)`；返回值紧邻使用处：`ArgumentSyntax: AiService.PrivateKey(data, _datePerson)`
- `NationalSpire.CareerScreen.CanRegenerateDate(NationalSpire.PrivateTurn?)`；输入表达式：`CanRegenerateDate(c.Turns.LastOrDefault())`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CanRegenerateDate(c.Turns.LastOrDefault())`
- `NationalSpire.CareerScreen.CloseDateScene()`；输入表达式：`CloseDateScene()`；返回值紧邻使用处：`ExpressionStatementSyntax: CloseDateScene();`
- `NationalSpire.CareerScreen.PrivateAttachmentCard(NationalSpire.PrivateOffer, bool)`；输入表达式：`PrivateAttachmentCard(item, true)`；返回值紧邻使用处：`ArgumentSyntax: PrivateAttachmentCard(item, true)`
- `NationalSpire.CareerScreen.ShowDateLine()`；输入表达式：`ShowDateLine()`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowDateLine();`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(_dateView.Attachments)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(_dateView.Attachments);`
- `NationalSpire.DateSceneAssetStore.Hash(byte[])`；输入表达式：`DateSceneAssetStore.Hash(Encoding.UTF8.GetBytes(turn.Reply))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateSceneAssetStore.Hash(Encoding.UTF8.GetBytes(turn.Reply))`
- `NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；输入表达式：`DateScenes.Available(data, o, c)`；返回值紧邻使用处：`BinaryExpressionSyntax: o.Id == _dateOffer && DateScenes.Available(data, o, c)`
- `NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`；输入表达式：`DateScenes.Lines(turn)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dateLines = DateScenes.Lines(turn)`
- `NationalSpire.DateSceneView.AppendLine(NationalSpire.DateSceneLine)`；输入表达式：`_dateView.AppendLine(_dateLines[_dateIndex])`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.AppendLine(_dateLines[_dateIndex]);`
- `NationalSpire.DateSceneView.AppendLine(NationalSpire.DateSceneLine)`；输入表达式：`_dateView.AppendLine(_dateLines[Math.Min(_dateIndex, _dateLines.Count - 1)])`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.AppendLine(_dateLines[Math.Min(_dateIndex, _dateLines.Count - 1)]);`
- `NationalSpire.DateSceneView.Relationship(NationalSpire.PrivateRelation)`；输入表达式：`_dateView.Relationship(PrivateMessages.Relation(data, _datePerson))`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.Relationship(PrivateMessages.Relation(data, _datePerson));`
- `NationalSpire.DateSceneView.ShowAttachments()`；输入表达式：`_dateView.ShowAttachments()`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.ShowAttachments();`
- `NationalSpire.DateSceneView.ShowWaiting(string, bool)`；输入表达式：`_dateView.ShowWaiting(_privateStatus?.Text.Length > 0 ? _privateStatus.Text : "正在准备开场…", true)`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.ShowWaiting(_privateStatus?.Text.Length > 0 ? _privateStatus.Text : "正在准备开场…", true);`
- `NationalSpire.DateSceneView.ShowWaiting(string, bool)`；输入表达式：`_dateView.ShowWaiting(turn.Status == "failed" ? PlayerFacingText.LongError(turn.Error) : "正在生成完整回复与情绪差分…", turn.Status == "failed")`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.ShowWaiting(turn.Status == "failed" ? PlayerFacingText.LongError(turn.Error) : "正在生成完整回复与情绪差分…", turn.Status == "failed");`
- `NationalSpire.DateSceneView.Streaming(bool)`；输入表达式：`_dateView.Streaming(false)`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.Streaming(false);`
- `NationalSpire.PlayerFacingText.LongError(string)`；输入表达式：`PlayerFacingText.LongError(turn.Error)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dateView.Status.Text = PlayerFacingText.LongError(turn.Error)`
- `NationalSpire.PlayerFacingText.LongError(string)`；输入表达式：`PlayerFacingText.LongError(turn.Error)`；返回值紧邻使用处：`ConditionalExpressionSyntax: turn.Status == "failed" ? PlayerFacingText.LongError(turn.Error) : "正在生成完整回复与情绪差分…"`
- `NationalSpire.PortraitDesignStore.Key(NationalSpire.CareerData, string)`；输入表达式：`PortraitDesignStore.Key(data, _datePerson)`；返回值紧邻使用处：`BinaryExpressionSyntax: PortraitDesignStore.Key(data, _datePerson) != _dateKey`
- `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.CanChat(data, _datePerson)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PrivateMessages.CanChat(data, _datePerson)`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, _datePerson)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(data, _datePerson)`
- `NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Relation(data, _datePerson)`；返回值紧邻使用处：`ArgumentSyntax: PrivateMessages.Relation(data, _datePerson)`
- `string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；输入表达式：`string.Join('|', PrivateAttachments.Select(a => a.Id))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = string.Join('|', PrivateAttachments.Select(a => a.Id))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`_dateBackgrounds.Any(b => b.Id == turn.Scene?.CurrentBackground)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _dateBackgrounds.Any(b => b.Id == turn.Scene?.CurrentBackground) ? turn.Scene!.CurrentBackground : _dateBackground`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Offers.Any(o => o.Id == _dateOffer && DateScenes.Available(data, o, c))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !c.Offers.Any(o => o.Id == _dateOffer && DateScenes.Available(data, o, c))`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`c.Turns.LastOrDefault()`；返回值紧邻使用处：`ArgumentSyntax: c.Turns.LastOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.LastOrDefault(t => t.Scene?.OfferId == _dateOffer && !t.ReplyDeleted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Turns.LastOrDefault(t => t.Scene?.OfferId == _dateOffer && !t.ReplyDeleted)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`PrivateAttachments.Select(a => a.Id)`；返回值紧邻使用处：`ArgumentSyntax: PrivateAttachments.Select(a => a.Id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`_dateAssets.Bookmarks.GetValueOrDefault(_dateOffer)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _dateAssets.Bookmarks.GetValueOrDefault(_dateOffer)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`AiService.PrivateSceneLive.GetValueOrDefault(AiService.PrivateKey(data, _datePerson))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AiService.PrivateSceneLive.GetValueOrDefault(AiService.PrivateKey(data, _datePerson))`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(bookmark.Index, 0, _dateLines.Count)`；返回值紧邻使用处：`ConditionalExpressionSyntax: bookmark?.Turn == turn.Id && bookmark.ReplyHash == hash ? Math.Clamp(bookmark.Index, 0, _dateLines.Count) : 0`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(_dateIndex, _dateLines.Count - 1)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(_dateIndex, _dateLines.Count - 1)`
- `System.Text.Encoding.GetBytes(string)`；输入表达式：`Encoding.UTF8.GetBytes(turn.Reply)`；返回值紧邻使用处：`ArgumentSyntax: Encoding.UTF8.GetBytes(turn.Reply)`

**赋值（含属性/字段和局部值）：**

- `_dateAttachments` = `attachments`
- `_dateEditingTurn` = `""`
- `_dateIndex` = `0`
- `_dateIndex` = `bookmark?.Turn == turn.Id && bookmark.ReplyHash == hash ? Math.Clamp(bookmark.Index, 0, _dateLines.Count) : 0`
- `_dateInitialBackground` = `_dateBackgrounds.Any(b => b.Id == turn.Scene?.CurrentBackground) ? turn.Scene!.CurrentBackground : _dateBackground`
- `_dateInitialBackground` = `turn.Scene!.CurrentBackground`
- `_dateLines` = `DateScenes.Lines(turn)`
- `_dateLines` = `live.Lines`
- `_dateReply` = `hash`
- `_dateSource` = `turn.Reply`
- `_dateState` = `"complete"`
- `_dateState` = `"streaming"`
- `_dateState` = `state`
- `_dateTurn` = `turn.Id`
- `_dateView.RegenerateButton.Disabled` = `!CanRegenerateDate(c.Turns.LastOrDefault())`
- `_dateView.Status.Text` = `PlayerFacingText.LongError(turn.Error)`

<a id="symbol-1580b0be190e"></a>

## `NationalSpire.CareerScreen.ShowDateLine() — private void ShowDateLine()`

来源：源码第 185 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AdvanceDateScene()`](DateSceneScreen.cs.md#symbol-96e53c8a266f)；[`NationalSpire.CareerScreen.DateSceneSettings()`](DateSceneScreen.cs.md#symbol-0845ec2acab1)；[`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerScreen.ApplyDateBackground()`](DateSceneScreen.cs.md#symbol-4c2055af1c70)；[`NationalSpire.CareerScreen.DateTexture(string)`](DateSceneScreen.cs.md#symbol-f1499ce9d9b1)；[`NationalSpire.CareerScreen.SpriteVariants(string)`](DateSceneScreen.cs.md#symbol-e038e794d751)；[`NationalSpire.DateSceneView.ShowInput(string, bool)`](DateSceneView.cs.md#symbol-4f0d075ed97b)；[`NationalSpire.DateSceneView.ShowLine(NationalSpire.DateSceneLine, string, Godot.Texture2D)`](DateSceneView.cs.md#symbol-1801b5d93aa1)；[`NationalSpire.DateSceneView.Streaming(bool)`](DateSceneView.cs.md#symbol-e7a96de3c199)；`System.Random.Next(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerScreen._dateDesign`；`NationalSpire.CareerScreen._dateIndex`；`NationalSpire.CareerScreen._dateLines`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateState`；`NationalSpire.CareerScreen._dateTextureWarning`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.CareerScreen.ApplyDateBackground()`；`NationalSpire.CareerScreen.DateTexture(string)`；`NationalSpire.CareerScreen.SpriteVariants(string)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.DateSceneLine.Emotion`；`NationalSpire.DateSceneView.ShowInput(string, bool)`；`NationalSpire.DateSceneView.ShowLine(NationalSpire.DateSceneLine, string, Godot.Texture2D)`；`NationalSpire.DateSceneView.Status`；`NationalSpire.DateSceneView.Streaming(bool)`；`NationalSpire.PortraitDesign.DefaultEmotionId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(ViewData, _datePerson)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.DisplayName(ViewData, _datePerson)`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(ViewData)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.Name(ViewData)`
- `NationalSpire.CareerScreen.ApplyDateBackground()`；输入表达式：`ApplyDateBackground()`；返回值紧邻使用处：`ExpressionStatementSyntax: ApplyDateBackground();`
- `NationalSpire.CareerScreen.DateTexture(string)`；输入表达式：`DateTexture(variants[Random.Shared.Next(variants.Count)])`；返回值紧邻使用处：`ArgumentSyntax: DateTexture(variants[Random.Shared.Next(variants.Count)])`
- `NationalSpire.CareerScreen.SpriteVariants(string)`；输入表达式：`SpriteVariants(_dateDesign!.DefaultEmotionId)`；返回值紧邻使用处：`AssignmentExpressionSyntax: variants = SpriteVariants(_dateDesign!.DefaultEmotionId)`
- `NationalSpire.CareerScreen.SpriteVariants(string)`；输入表达式：`SpriteVariants(line.Emotion)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = SpriteVariants(line.Emotion)`
- `NationalSpire.DateSceneView.ShowInput(string, bool)`；输入表达式：`_dateView.ShowInput(CareerEngine.Name(ViewData))`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.ShowInput(CareerEngine.Name(ViewData));`
- `NationalSpire.DateSceneView.ShowLine(NationalSpire.DateSceneLine, string, Godot.Texture2D)`；输入表达式：`_dateView.ShowLine(line, CareerEngine.DisplayName(ViewData, _datePerson), DateTexture(variants[Random.Shared.Next(variants.Count)]))`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.ShowLine(line, CareerEngine.DisplayName(ViewData, _datePerson), DateTexture(variants[Random.Shared.Next(variants.Count)]));`
- `NationalSpire.DateSceneView.Streaming(bool)`；输入表达式：`_dateView.Streaming(_dateState == "streaming")`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.Streaming(_dateState == "streaming");`
- `System.Random.Next(int)`；输入表达式：`Random.Shared.Next(variants.Count)`；返回值紧邻使用处：`ArgumentSyntax: Random.Shared.Next(variants.Count)`

**赋值（含属性/字段和局部值）：**

- `_dateView.Status.Text` = `_dateTextureWarning`
- `_dateView.Status.Text` = `"此差分缺少立绘，当前使用平淡立绘。"`
- `variants` = `SpriteVariants(_dateDesign!.DefaultEmotionId)`

<a id="symbol-e038e794d751"></a>

## `NationalSpire.CareerScreen.SpriteVariants(string) — private List<string> SpriteVariants(string emotion)`

来源：源码第 200 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DateTexture(string)`](DateSceneScreen.cs.md#symbol-f1499ce9d9b1)；[`NationalSpire.CareerScreen.OpenDateScene(string)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)；[`NationalSpire.CareerScreen.SceneRequest(bool)`](DateSceneScreen.cs.md#symbol-277baf4e7cb8)；[`NationalSpire.CareerScreen.ShowDateLine()`](DateSceneScreen.cs.md#symbol-1580b0be190e)

**调用：** [`NationalSpire.DateSceneAssetStore.SpriteKeys(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string)`](DateSceneAssets.cs.md#symbol-3b48b221efd8)；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._dateAssets`；`NationalSpire.CareerScreen._dateDesign`；`NationalSpire.DateSceneAssetStore.SpriteKeys(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneAssetStore.SpriteKeys(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string)`；输入表达式：`DateSceneAssetStore.SpriteKeys(_dateAssets, _dateDesign, emotion)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateSceneAssetStore.SpriteKeys(_dateAssets, _dateDesign, emotion).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`DateSceneAssetStore.SpriteKeys(_dateAssets, _dateDesign, emotion).ToList()`；返回值紧邻使用处：`ConditionalExpressionSyntax: _dateAssets == null || _dateDesign == null ? [] : DateSceneAssetStore.SpriteKeys(_dateAssets, _dateDesign, emotion).ToList()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f1499ce9d9b1"></a>

## `NationalSpire.CareerScreen.DateTexture(string) — private Texture2D DateTexture(string key)`

来源：源码第 201 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenDateScene(string)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)；[`NationalSpire.CareerScreen.ShowDateLine()`](DateSceneScreen.cs.md#symbol-1580b0be190e)

**调用：** [`NationalSpire.CareerScreen.SpriteVariants(string)`](DateSceneScreen.cs.md#symbol-e038e794d751)；[`NationalSpire.DateSceneAssetStore.Texture(string, bool)`](DateSceneAssets.cs.md#symbol-616d47ee9d6a)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.IO.InvalidDataException.InvalidDataException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._dateAssets`；`NationalSpire.CareerScreen._dateDesign`；`NationalSpire.CareerScreen._dateMissingTextures`；`NationalSpire.CareerScreen._dateTextures`；`NationalSpire.CareerScreen._dateTextureWarning`；`NationalSpire.CareerScreen.SpriteVariants(string)`；`NationalSpire.DateSceneAssets.Sprites`；`NationalSpire.DateSceneAssetStore.Texture(string, bool)`；`NationalSpire.PortraitDesign.DefaultEmotionId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.SpriteVariants(string)`；输入表达式：`SpriteVariants(_dateDesign!.DefaultEmotionId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: SpriteVariants(_dateDesign!.DefaultEmotionId).Select`
- `NationalSpire.DateSceneAssetStore.Texture(string, bool)`；输入表达式：`DateSceneAssetStore.Texture(candidate)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dateTextures[candidate] = DateSceneAssetStore.Texture(candidate)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_dateTextures.TryGetValue(candidate, out var texture)`；返回值紧邻使用处：`IfStatementSyntax: if (_dateTextures.TryGetValue(candidate, out var texture)) return texture;`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`_dateMissingTextures.Add(candidate)`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateMissingTextures.Add(candidate);`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`_dateMissingTextures.Contains(candidate)`；返回值紧邻使用处：`IfStatementSyntax: if (_dateMissingTextures.Contains(candidate)) continue;`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`new[] { hash }.Concat(SpriteVariants(_dateDesign!.DefaultEmotionId).Select(k => _dateAssets.Sprites[k]))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { hash }.Concat(SpriteVariants(_dateDesign!.DefaultEmotionId).Select(k => _dateAssets.Sprites[k])).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`new[] { hash }.Concat(SpriteVariants(_dateDesign!.DefaultEmotionId).Select(k => _dateAssets.Sprites[k])).Distinct()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string candidate in new[] { hash }.Concat(SpriteVariants(_dateDesign!.DefaultEmotionId).Select(k => _dateAssets.Sprites[k])).Distinct())          {              if (_dateMissingTextures.Contains(candidate)) continue;              if (_dateTextures.TryGetValue(candidate, out var texture)) return texture;              try { return _dateTextures[candidate] = DateSceneAssetStore.Texture(candidate); }              catch (Exception e) { _dateMissingTextures.Add(candidate); _dateTextureWarning = "部分立绘读取失败，当前使用可用立绘。" + e.Message; }          }`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`SpriteVariants(_dateDesign!.DefaultEmotionId).Select(k => _dateAssets.Sprites[k])`；返回值紧邻使用处：`ArgumentSyntax: SpriteVariants(_dateDesign!.DefaultEmotionId).Select(k => _dateAssets.Sprites[k])`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("当前套装没有可读取的默认立绘，请重新导入。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("当前套装没有可读取的默认立绘，请重新导入。");`

**赋值（含属性/字段和局部值）：**

- `_dateTextures[candidate]` = `DateSceneAssetStore.Texture(candidate)`
- `_dateTextureWarning` = `"部分立绘读取失败，当前使用可用立绘。" + e.Message`

<a id="symbol-694ba8dec04c"></a>

## `NationalSpire.CareerScreen.HasDateArt(NationalSpire.CareerData, string) — private bool HasDateArt(CareerData data, string person)`

来源：源码第 215 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddDateSceneAction(NationalSpire.CareerData, NationalSpire.PrivateOffer, Godot.HBoxContainer)`](DateSceneScreen.cs.md#symbol-413adf55a103)

**调用：** [`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.DateSceneAssetStore.BlobPath(string)`](DateSceneAssets.cs.md#symbol-1b33c2ffb1f6)；[`NationalSpire.DateSceneAssetStore.PathFor(NationalSpire.CareerData, string)`](DateSceneAssets.cs.md#symbol-81bb8bd9a964)；[`NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`](DateSceneAssets.cs.md#symbol-57fe620f4cc9)；[`NationalSpire.DateSceneAssetStore.SpriteKeys(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string)`](DateSceneAssets.cs.md#symbol-3b48b221efd8)；[`NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`](PortraitDesignStore.cs.md#symbol-8db102d73ed8)；[`NationalSpire.PortraitDesignStore.Read(string, string)`](PortraitDesignStore.cs.md#symbol-2eeba99f517d)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.IO.File.Exists(string?)`；`System.IO.File.GetLastWriteTimeUtc(string)`

**字段、属性、事件及方法组引用：** `(string Path, System.DateTime DesignTime, System.DateTime AssetTime, bool Ready).AssetTime`；`(string Path, System.DateTime DesignTime, System.DateTime AssetTime, bool Ready).DesignTime`；`(string Path, System.DateTime DesignTime, System.DateTime AssetTime, bool Ready).Path`；`(string Path, System.DateTime DesignTime, System.DateTime AssetTime, bool Ready).Ready`；`NationalSpire.CareerScreen._dateAvailability`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.DateSceneAssets.OutfitId`；`NationalSpire.DateSceneAssets.Sprites`；`NationalSpire.DateSceneAssetStore.BlobPath(string)`；`NationalSpire.DateSceneAssetStore.PathFor(NationalSpire.CareerData, string)`；`NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`；`NationalSpire.DateSceneAssetStore.SpriteKeys(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string)`；`NationalSpire.PortraitDesign.DefaultEmotionId`；`NationalSpire.PortraitDesign.SelectedOutfit`；`NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`；`NationalSpire.PortraitDesignStore.Read(string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("角色立绘资料读取失败：" + e.Message, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("角色立绘资料读取失败：" + e.Message, true);`
- `NationalSpire.DateSceneAssetStore.BlobPath(string)`；输入表达式：`DateSceneAssetStore.BlobPath(assets.Sprites[key])`；返回值紧邻使用处：`ArgumentSyntax: DateSceneAssetStore.BlobPath(assets.Sprites[key])`
- `NationalSpire.DateSceneAssetStore.PathFor(NationalSpire.CareerData, string)`；输入表达式：`DateSceneAssetStore.PathFor(data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateSceneAssetStore.PathFor(data, person)`
- `NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`；输入表达式：`DateSceneAssetStore.Read(data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateSceneAssetStore.Read(data, person)`
- `NationalSpire.DateSceneAssetStore.SpriteKeys(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string)`；输入表达式：`DateSceneAssetStore.SpriteKeys(assets, design, design.DefaultEmotionId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateSceneAssetStore.SpriteKeys(assets, design, design.DefaultEmotionId).Any`
- `NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`；输入表达式：`PortraitDesignStore.FilePath(data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PortraitDesignStore.FilePath(data, person)`
- `NationalSpire.PortraitDesignStore.Read(string, string)`；输入表达式：`PortraitDesignStore.Read(path, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PortraitDesignStore.Read(path, person)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`DateSceneAssetStore.SpriteKeys(assets, design, design.DefaultEmotionId).Any(key => File.Exists(DateSceneAssetStore.BlobPath(assets.Sprites[key])))`；返回值紧邻使用处：`AssignmentExpressionSyntax: ready = DateSceneAssetStore.SpriteKeys(assets, design, design.DefaultEmotionId).Any(key => File.Exists(DateSceneAssetStore.BlobPath(assets.Sprites[key])))`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(DateSceneAssetStore.BlobPath(assets.Sprites[key]))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: key => File.Exists(DateSceneAssetStore.BlobPath(assets.Sprites[key]))`
- `System.IO.File.GetLastWriteTimeUtc(string)`；输入表达式：`File.GetLastWriteTimeUtc(assetsPath)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = File.GetLastWriteTimeUtc(assetsPath)`
- `System.IO.File.GetLastWriteTimeUtc(string)`；输入表达式：`File.GetLastWriteTimeUtc(path)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = File.GetLastWriteTimeUtc(path)`

**赋值（含属性/字段和局部值）：**

- `_dateAvailability` = `(path, designTime, assetTime, ready)`
- `assets.OutfitId` = `design.SelectedOutfit`
- `ready` = `DateSceneAssetStore.SpriteKeys(assets, design, design.DefaultEmotionId).Any(key => File.Exists(DateSceneAssetStore.BlobPath(assets.Sprites[key])))`

<a id="symbol-413adf55a103"></a>

## `NationalSpire.CareerScreen.AddDateSceneAction(NationalSpire.CareerData, NationalSpire.PrivateOffer, Godot.HBoxContainer) — private void AddDateSceneAction(CareerData data, PrivateOffer offer, HBoxContainer row)`

来源：源码第 233 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-c7881d245b3d)

**调用：** [`NationalSpire.CareerScreen.HasDateArt(NationalSpire.CareerData, string)`](DateSceneScreen.cs.md#symbol-694ba8dec04c)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.PromptDateScene(string)`](DateSceneScreen.cs.md#symbol-d6c92b4f494c)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`](DateSceneData.cs.md#symbol-0d3e014bcb63)；[`NationalSpire.DateScenes.OneToOne(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`](DateSceneData.cs.md#symbol-dccb0fff0030)；[`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-15c716ec61a1)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`；`Godot.CanvasItem.Hide()`；`Godot.Color.Color(string)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.DateChoiceButton.DateChoiceButton()`；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerScreen._cancelDialog`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen.HasDateArt(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`；`NationalSpire.CareerScreen.PromptDateScene(string)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.DateChoiceButton.Caption`；`NationalSpire.DateChoiceButton.Public`；`NationalSpire.DateChoiceButton.Subtitle`；`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；`NationalSpire.DateScenes.OneToOne(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateConversation.DateSceneStates`；`NationalSpire.PrivateMessageCommand.Offer`；`NationalSpire.PrivateMessageCommand.Part`；`NationalSpire.PrivateMessageCommand.SceneAttendance`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.State`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(() => PromptDateScene(offer.Id)).CallDeferred()`；返回值紧邻使用处：`ExpressionStatementSyntax: Callable.From(() => PromptDateScene(offer.Id)).CallDeferred();`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(() => PromptDateScene(offer.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(() => PromptDateScene(offer.Id)).CallDeferred`
- `Godot.CanvasItem.Hide()`；输入表达式：`error.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: error.Hide();`
- `Godot.Color.Color(string)`；输入表达式：`new Color("ee929d")`；返回值紧邻使用处：`ArgumentSyntax: new Color("ee929d")`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`choices.AddThemeConstantOverride("separation", 20)`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.AddThemeConstantOverride("separation", 20);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(choices)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(choices);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(error)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(error);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`choices.AddChild(choice)`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.AddChild(choice);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(button);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(150, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(150, 48)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(290, 150)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(290, 150)`
- `NationalSpire.CareerScreen.HasDateArt(NationalSpire.CareerData, string)`；输入表达式：`HasDateArt(data, _privatePerson)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !HasDateArt(data, _privatePerson)`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`；输入表达式：`PrivateCommand("dm-attend", new() { Offer = offer.Id, Part = visible ? "public" : "", SceneAttendance = true },                          () => { _cancelDialog?.Invoke(); Callable.From(() => PromptDateScene(offer.Id)).CallDeferred(); })`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => PrivateCommand("dm-attend", new() { Offer = offer.Id, Part = visible ? "public" : "", SceneAttendance = true },                          () => { _cancelDialog?.Invoke(); Callable.From(() => PromptDateScene(offer.Id)).CallDeferred(); })`
- `NationalSpire.CareerScreen.PromptDateScene(string)`；输入表达式：`PromptDateScene(offer.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: PromptDateScene(offer.Id);`
- `NationalSpire.CareerScreen.PromptDateScene(string)`；输入表达式：`PromptDateScene(offer.Id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => PromptDateScene(offer.Id)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("专属约会", "选择这次赴约的公开方式。", () => true, "取消", box =>              {                  var choices = new HBoxContainer(); choices.AddThemeConstantOverride("separation", 20); box.AddChild(choices);                  foreach (bool visible in new[] { false, true })                  {                      var choice = new DateChoiceButton { Name = visible ? "DatePublicChoice" : "DatePrivateChoice", Caption = visible ? "公开赴约" : "私密赴约",                          Subtitle = visible ? "让这次相聚成为公开经历" : "将这次相聚留在彼此之间", Public = visible,                          CustomMinimumSize = new(290, 150), SizeFlagsHorizontal = SizeFlags.ExpandFill };                      choice.Pressed += () => PrivateCommand("dm-attend", new() { Offer = offer.Id, Part = visible ? "public" : "", SceneAttendance = true },                          () => { _cancelDialog?.Invoke(); Callable.From(() => PromptDateScene(offer.Id)).CallDeferred(); });                      choices.AddChild(choice);                  }                  var error = Text("", 16, new Color("ee929d")); error.Name = "DateAttendanceError"; error.Hide(); box.AddChild(error);              }, showCancel: false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("专属约会", "选择这次赴约的公开方式。", () => true, "取消", box =>              {                  var choices = new HBoxContainer(); choices.AddThemeConstantOverride("separation", 20); box.AddChild(choices);                  foreach (bool visible in new[] { false, true })                  {                      var choice = new DateChoiceButton { Name = visible ? "DatePublicChoice" : "DatePrivateChoice", Caption = visible ? "公开赴约" : "私密赴约",                          Subtitle = visible ? "让这次相聚成为公开经历" : "将这次相聚留在彼此之间", Public = visible,                          CustomMinimumSize = new(290, 150), SizeFlagsHorizontal = SizeFlags.ExpandFill };                      choice.Pressed += () => PrivateCommand("dm-attend", new() { Offer = offer.Id, Part = visible ? "public" : "", SceneAttendance = true },                          () => { _cancelDialog?.Invoke(); Callable.From(() => PromptDateScene(offer.Id)).CallDeferred(); });                      choices.AddChild(choice);                  }                  var error = Text("", 16, new Color("ee929d")); error.Name = "DateAttendanceError"; error.Hide(); box.AddChild(error);              }, showCancel: false);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 16, new Color("ee929d"))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("", 16, new Color("ee929d"))`
- `NationalSpire.DateChoiceButton.DateChoiceButton()`；输入表达式：`new DateChoiceButton { Name = "ExclusiveDate", Caption = conversation.DateSceneStates.GetValueOrDefault(offer.Id) == "paused" ? "继续约会" : "专属约会", CustomMinimumSize = new(150, 48), SizeFlagsVertical = SizeFlags.ShrinkCenter }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new DateChoiceButton { Name = "ExclusiveDate", Caption = conversation.DateSceneStates.GetValueOrDefault(offer.Id) == "paused" ? "继续约会" : "专属约会", CustomMinimumSize = new(150, 48), SizeFlagsVertical = SizeFlags.ShrinkCenter }`
- `NationalSpire.DateChoiceButton.DateChoiceButton()`；输入表达式：`new DateChoiceButton { Name = visible ? "DatePublicChoice" : "DatePrivateChoice", Caption = visible ? "公开赴约" : "私密赴约",                          Subtitle = visible ? "让这次相聚成为公开经历" : "将这次相聚留在彼此之间", Public = visible,                          CustomMinimumSize = new(290, 150), SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new DateChoiceButton { Name = visible ? "DatePublicChoice" : "DatePrivateChoice", Caption = visible ? "公开赴约" : "私密赴约",                          Subtitle = visible ? "让这次相聚成为公开经历" : "将这次相聚留在彼此之间", Public = visible,                          CustomMinimumSize = new(290, 150), SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；输入表达式：`DateScenes.Available(data, offer, conversation)`；返回值紧邻使用处：`BinaryExpressionSyntax: attend || DateScenes.Available(data, offer, conversation)`
- `NationalSpire.DateScenes.OneToOne(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；输入表达式：`DateScenes.OneToOne(data, offer, conversation)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !DateScenes.OneToOne(data, offer, conversation)`
- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Date(data, offer)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateAppointments.Date(data, offer) == data.Day`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Offer = offer.Id, Part = visible ? "public" : "", SceneAttendance = true }`；返回值紧邻使用处：`ArgumentSyntax: new() { Offer = offer.Id, Part = visible ? "public" : "", SceneAttendance = true }`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, _privatePerson)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(data, _privatePerson)`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _cancelDialog?.Invoke()`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`conversation.DateSceneStates.GetValueOrDefault(offer.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: conversation.DateSceneStates.GetValueOrDefault(offer.Id) == "paused"`

**赋值（含属性/字段和局部值）：**

- `button.Pressed` += `() =>          {              if (!attend) { PromptDateScene(offer.Id); return; }              ShowCareerDialog("专属约会", "选择这次赴约的公开方式。", () => true, "取消", box =>              {                  var choices = new HBoxContainer(); choices.AddThemeConstantOverride("separation", 20); box.AddChild(choices);                  foreach (bool visible in new[] { false, true })                  {                      var choice = new DateChoiceButton { Name = visible ? "DatePublicChoice" : "DatePrivateChoice", Caption = visible ? "公开赴约" : "私密赴约",                          Subtitle = visible ? "让这次相聚成为公开经历" : "将这次相聚留在彼此之间", Public = visible,                          CustomMinimumSize = new(290, 150), SizeFlagsHorizontal = SizeFlags.ExpandFill };                      choice.Pressed += () => PrivateCommand("dm-attend", new() { Offer = offer.Id, Part = visible ? "public" : "", SceneAttendance = true },                          () => { _cancelDialog?.Invoke(); Callable.From(() => PromptDateScene(offer.Id)).CallDeferred(); });                      choices.AddChild(choice);                  }                  var error = Text("", 16, new Color("ee929d")); error.Name = "DateAttendanceError"; error.Hide(); box.AddChild(error);              }, showCancel: false);          }`
- `Caption` = `conversation.DateSceneStates.GetValueOrDefault(offer.Id) == "paused" ? "继续约会" : "专属约会"`
- `Caption` = `visible ? "公开赴约" : "私密赴约"`
- `choice.Pressed` += `() => PrivateCommand("dm-attend", new() { Offer = offer.Id, Part = visible ? "public" : "", SceneAttendance = true },                          () => { _cancelDialog?.Invoke(); Callable.From(() => PromptDateScene(offer.Id)).CallDeferred(); })`
- `CustomMinimumSize` = `new(150, 48)`
- `CustomMinimumSize` = `new(290, 150)`
- `error.Name` = `"DateAttendanceError"`
- `Name` = `"ExclusiveDate"`
- `Name` = `visible ? "DatePublicChoice" : "DatePrivateChoice"`
- `Offer` = `offer.Id`
- `Part` = `visible ? "public" : ""`
- `Public` = `visible`
- `SceneAttendance` = `true`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `Subtitle` = `visible ? "让这次相聚成为公开经历" : "将这次相聚留在彼此之间"`

<a id="symbol-4d37da1a3f4b"></a>

## `NationalSpire.CareerScreen.SelectDateBackground(string) — private void SelectDateBackground(string id)`

来源：源码第 259 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ApplyDateBackground()`](DateSceneScreen.cs.md#symbol-4c2055af1c70)

**调用：** [`NationalSpire.DateSceneView.Background(string, bool, double)`](DateSceneView.cs.md#symbol-9c58edcaf529)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._dateAssets`；`NationalSpire.CareerScreen._dateBackground`；`NationalSpire.CareerScreen._dateBackgrounds`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.DateSceneAssets.Background`；`NationalSpire.DateSceneAssets.BlurAmount`；`NationalSpire.DateSceneBackground.Id`；`NationalSpire.DateSceneBackground.Image`；`NationalSpire.DateSceneView.Background(string, bool, double)`；`NationalSpire.DateSceneView.Status`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneView.Background(string, bool, double)`；输入表达式：`_dateView.Background(background?.Image ?? "", true, _dateAssets.BlurAmount)`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.Background(background?.Image ?? "", true, _dateAssets.BlurAmount);`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`_dateBackgrounds.FirstOrDefault(b => b.Id == id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _dateBackgrounds.FirstOrDefault(b => b.Id == id)`

**赋值（含属性/字段和局部值）：**

- `_dateAssets.Background` = `background?.Id ?? ""`
- `_dateBackground` = `_dateAssets.Background = background?.Id ?? ""`
- `_dateView.Status.Text` = `"背景加载失败，保留当前背景：" + e.Message`

<a id="symbol-4c2055af1c70"></a>

## `NationalSpire.CareerScreen.ApplyDateBackground() — private void ApplyDateBackground()`

来源：源码第 266 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Apply()`](DateSceneScreen.cs.md#symbol-c87d3c4db5f5)；[`NationalSpire.CareerScreen.ShowDateLine()`](DateSceneScreen.cs.md#symbol-1580b0be190e)

**调用：** [`NationalSpire.CareerScreen.SelectDateBackground(string)`](DateSceneScreen.cs.md#symbol-4d37da1a3f4b)；[`NationalSpire.DateSceneBackgrounds.AutomaticChoices(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneBackground>)`](DateSceneBackgrounds.cs.md#symbol-7e409d1b4e9f)；[`NationalSpire.DateSceneBackgrounds.Closest(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneBackground>, string, string)`](DateSceneBackgrounds.cs.md#symbol-fe6e9e9ebd7b)；[`NationalSpire.DateScenes.BackgroundAt(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneLine>, int, string)`](DateSceneData.cs.md#symbol-e19b4e66ad48)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`string.Concat(System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._dateAssets`；`NationalSpire.CareerScreen._dateBackground`；`NationalSpire.CareerScreen._dateBackgrounds`；`NationalSpire.CareerScreen._dateIndex`；`NationalSpire.CareerScreen._dateInitialBackground`；`NationalSpire.CareerScreen._dateLines`；`NationalSpire.CareerScreen._dateOffer`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen.SelectDateBackground(string)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.DateSceneAssets.AutoBackground`；`NationalSpire.DateSceneAssets.Background`；`NationalSpire.DateSceneBackground.Id`；`NationalSpire.DateSceneBackgrounds.AutomaticChoices(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneBackground>)`；`NationalSpire.DateSceneBackgrounds.Closest(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneBackground>, string, string)`；`NationalSpire.DateSceneLine.Narration`；`NationalSpire.DateSceneLine.Text`；`NationalSpire.DateScenes.BackgroundAt(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneLine>, int, string)`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.SelectDateBackground(string)`；输入表达式：`SelectDateBackground(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: SelectDateBackground(id);`
- `NationalSpire.DateSceneBackgrounds.AutomaticChoices(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneBackground>)`；输入表达式：`DateSceneBackgrounds.AutomaticChoices(_dateBackgrounds)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateSceneBackgrounds.AutomaticChoices(_dateBackgrounds).Any`
- `NationalSpire.DateSceneBackgrounds.Closest(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneBackground>, string, string)`；输入表达式：`DateSceneBackgrounds.Closest(_dateBackgrounds, offer?.Title + " " + offer?.Detail + " " + string.Concat(_dateLines.Take(_dateIndex + 1).Where(l => l.Narration).Select(l => l.Text)), _dateBackground)`；返回值紧邻使用处：`AssignmentExpressionSyntax: id = DateSceneBackgrounds.Closest(_dateBackgrounds, offer?.Title + " " + offer?.Detail + " " + string.Concat(_dateLines.Take(_dateIndex + 1).Where(l => l.Narration).Select(l => l.Text)), _dateBackground)`
- `NationalSpire.DateScenes.BackgroundAt(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneLine>, int, string)`；输入表达式：`DateScenes.BackgroundAt(_dateLines, _dateIndex, _dateInitialBackground)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _dateAssets.AutoBackground ? DateScenes.BackgroundAt(_dateLines, _dateIndex, _dateInitialBackground) : _dateAssets.Background`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(ViewData, _datePerson)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Conversation(ViewData, _datePerson).Offers`
- `string.Concat(System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Concat(_dateLines.Take(_dateIndex + 1).Where(l => l.Narration).Select(l => l.Text))`；返回值紧邻使用处：`BinaryExpressionSyntax: offer?.Title + " " + offer?.Detail + " " + string.Concat(_dateLines.Take(_dateIndex + 1).Where(l => l.Narration).Select(l => l.Text))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`DateSceneBackgrounds.AutomaticChoices(_dateBackgrounds).Any(b => b.Id == id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !DateSceneBackgrounds.AutomaticChoices(_dateBackgrounds).Any(b => b.Id == id)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateMessages.Conversation(ViewData, _datePerson).Offers.FirstOrDefault(o => o.Id == _dateOffer)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(ViewData, _datePerson).Offers.FirstOrDefault(o => o.Id == _dateOffer)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`_dateLines.Take(_dateIndex + 1).Where(l => l.Narration).Select(l => l.Text)`；返回值紧邻使用处：`ArgumentSyntax: _dateLines.Take(_dateIndex + 1).Where(l => l.Narration).Select(l => l.Text)`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`_dateLines.Take(_dateIndex + 1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _dateLines.Take(_dateIndex + 1).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`_dateLines.Take(_dateIndex + 1).Where(l => l.Narration)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _dateLines.Take(_dateIndex + 1).Where(l => l.Narration).Select`

**赋值（含属性/字段和局部值）：**

- `id` = `DateSceneBackgrounds.Closest(_dateBackgrounds, offer?.Title + " " + offer?.Detail + " " + string.Concat(_dateLines.Take(_dateIndex + 1).Where(l => l.Narration).Select(l => l.Text)), _dateBackground)`

<a id="symbol-96e53c8a266f"></a>

## `NationalSpire.CareerScreen.AdvanceDateScene() — private void AdvanceDateScene()`

来源：源码第 277 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerScreen.ShowDateLine()`](DateSceneScreen.cs.md#symbol-1580b0be190e)；[`NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`](DateSceneAssets.cs.md#symbol-2bf1f40a912e)；`NationalSpire.DateSceneBookmark.DateSceneBookmark()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._dateAssets`；`NationalSpire.CareerScreen._dateIndex`；`NationalSpire.CareerScreen._dateLines`；`NationalSpire.CareerScreen._dateOffer`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateReply`；`NationalSpire.CareerScreen._dateState`；`NationalSpire.CareerScreen._dateTurn`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.CareerScreen.ShowDateLine()`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.DateSceneAssets.Bookmarks`；`NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`；`NationalSpire.DateSceneBookmark.Index`；`NationalSpire.DateSceneBookmark.ReplyHash`；`NationalSpire.DateSceneBookmark.Turn`；`NationalSpire.DateSceneView.Status`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.ShowDateLine()`；输入表达式：`ShowDateLine()`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowDateLine();`
- `NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`；输入表达式：`DateSceneAssetStore.Save(ViewData, _datePerson, _dateAssets)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateSceneAssetStore.Save(ViewData, _datePerson, _dateAssets);`
- `NationalSpire.DateSceneBookmark.DateSceneBookmark()`；输入表达式：`new() { Turn = _dateTurn, ReplyHash = _dateReply, Index = _dateIndex }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dateAssets!.Bookmarks[_dateOffer] = new() { Turn = _dateTurn, ReplyHash = _dateReply, Index = _dateIndex }`

**赋值（含属性/字段和局部值）：**

- `_dateAssets!.Bookmarks[_dateOffer]` = `new() { Turn = _dateTurn, ReplyHash = _dateReply, Index = _dateIndex }`
- `_dateView.Status.Text` = `"播放进度保存失败：" + e.Message`
- `_dateView.Status.Text` = `"正在续写当前回复…"`
- `Index` = `_dateIndex`
- `ReplyHash` = `_dateReply`
- `Turn` = `_dateTurn`

<a id="symbol-b811d23c8af3"></a>

## `NationalSpire.CareerScreen.SendDateScene() — private void SendDateScene()`

来源：源码第 290 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.SendPrivate()`](PrivateMessageScreen.cs.md#symbol-748ab66a7351)；[`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._dateEditingTurn`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateState`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.CareerScreen._privateDrafts`；`NationalSpire.CareerScreen._privateInput`；`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`；`NationalSpire.CareerScreen.SendPrivate()`；`NationalSpire.CareerScreen.TickDateScene()`；`NationalSpire.DateSceneView.DialogueHidden`；`NationalSpire.DateSceneView.Editor`；`NationalSpire.DateSceneView.HistoryOpen`；`NationalSpire.DateSceneView.InputMode`；`NationalSpire.PrivateMessageCommand.Entry`；`NationalSpire.PrivateMessageCommand.Text`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`；输入表达式：`PrivateCommand("dm-date-revise", new() { Entry = _dateEditingTurn, Text = _dateView.Editor.Text }, () =>              {                  _dateEditingTurn = ""; _dateState = "";                  if (_dateView != null) _dateView.Editor.Text = "";                  _privateDrafts.Remove(_datePerson); TickDateScene();              })`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateCommand("dm-date-revise", new() { Entry = _dateEditingTurn, Text = _dateView.Editor.Text }, () =>              {                  _dateEditingTurn = ""; _dateState = "";                  if (_dateView != null) _dateView.Editor.Text = "";                  _privateDrafts.Remove(_datePerson); TickDateScene();              });`
- `NationalSpire.CareerScreen.SendPrivate()`；输入表达式：`SendPrivate()`；返回值紧邻使用处：`ExpressionStatementSyntax: SendPrivate();`
- `NationalSpire.CareerScreen.TickDateScene()`；输入表达式：`TickDateScene()`；返回值紧邻使用处：`ExpressionStatementSyntax: TickDateScene();`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Entry = _dateEditingTurn, Text = _dateView.Editor.Text }`；返回值紧邻使用处：`ArgumentSyntax: new() { Entry = _dateEditingTurn, Text = _dateView.Editor.Text }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`_privateDrafts.Remove(_datePerson)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateDrafts.Remove(_datePerson);`

**赋值（含属性/字段和局部值）：**

- `_dateEditingTurn` = `""`
- `_dateState` = `""`
- `_dateView.Editor.Text` = `""`
- `_privateInput!.Text` = `_dateView.Editor.Text`
- `Entry` = `_dateEditingTurn`
- `Text` = `_dateView.Editor.Text`

<a id="symbol-1b2873272c7a"></a>

## `NationalSpire.CareerScreen.CanRegenerateDate(NationalSpire.PrivateTurn?) — private bool CanRegenerateDate(PrivateTurn? turn)`

来源：源码第 305 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RegenerateDateScene()`](DateSceneScreen.cs.md#symbol-c589255edb6a)；[`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._dateOffer`；`NationalSpire.DateSceneRequest.Ending`；`NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.DateSceneRequest.Opening`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.RequestKind`；`NationalSpire.PrivateTurn.Scene`；`NationalSpire.PrivateTurn.Status`；`NationalSpire.PrivateTurn.UserDeleted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c589255edb6a"></a>

## `NationalSpire.CareerScreen.RegenerateDateScene() — private void RegenerateDateScene()`

来源：源码第 307 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerScreen.CanRegenerateDate(NationalSpire.PrivateTurn?)`](DateSceneScreen.cs.md#symbol-1b2873272c7a)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._dateAssets`；`NationalSpire.CareerScreen._dateEditingTurn`；`NationalSpire.CareerScreen._dateOffer`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateState`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.CareerScreen.CanRegenerateDate(NationalSpire.PrivateTurn?)`；`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.TickDateScene()`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.DateSceneAssets.Bookmarks`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMessageCommand.Entry`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateTurn.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.CanRegenerateDate(NationalSpire.PrivateTurn?)`；输入表达式：`CanRegenerateDate(turn)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CanRegenerateDate(turn)`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`；输入表达式：`PrivateCommand("dm-regenerate", new() { Entry = entry }, () =>              {                  _dateAssets?.Bookmarks.Remove(offer); _dateState = ""; _dateEditingTurn = ""; TickDateScene();              })`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateCommand("dm-regenerate", new() { Entry = entry }, () =>              {                  _dateAssets?.Bookmarks.Remove(offer); _dateState = ""; _dateEditingTurn = ""; TickDateScene();              });`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("重新生成本轮回复", "将沿用你上一次发送的内容与附件，撤回原回复带来的关系及事件变化，再生成一份新回复。", () =>          {              if (_dateView == null || _datePerson != person || _dateOffer != offer) return true;              PrivateCommand("dm-regenerate", new() { Entry = entry }, () =>              {                  _dateAssets?.Bookmarks.Remove(offer); _dateState = ""; _dateEditingTurn = ""; TickDateScene();              });              return true;          }, "重新生成")`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("重新生成本轮回复", "将沿用你上一次发送的内容与附件，撤回原回复带来的关系及事件变化，再生成一份新回复。", () =>          {              if (_dateView == null || _datePerson != person || _dateOffer != offer) return true;              PrivateCommand("dm-regenerate", new() { Entry = entry }, () =>              {                  _dateAssets?.Bookmarks.Remove(offer); _dateState = ""; _dateEditingTurn = ""; TickDateScene();              });              return true;          }, "重新生成");`
- `NationalSpire.CareerScreen.TickDateScene()`；输入表达式：`TickDateScene()`；返回值紧邻使用处：`ExpressionStatementSyntax: TickDateScene();`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Entry = entry }`；返回值紧邻使用处：`ArgumentSyntax: new() { Entry = entry }`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(ViewData, _datePerson)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Conversation(ViewData, _datePerson).Turns`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`.Bookmarks.Remove(offer)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _dateAssets?.Bookmarks.Remove(offer)`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`PrivateMessages.Conversation(ViewData, _datePerson).Turns.LastOrDefault()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(ViewData, _datePerson).Turns.LastOrDefault()`

**赋值（含属性/字段和局部值）：**

- `_dateEditingTurn` = `""`
- `_dateState` = `""`
- `Entry` = `entry`

<a id="symbol-11eaa513a64e"></a>

## `NationalSpire.CareerScreen.EditFailedDateScene() — private void EditFailedDateScene()`

来源：源码第 323 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerScreen.PrivateAttachmentCard(NationalSpire.PrivateOffer, bool)`](PrivateMemoryScreen.cs.md#symbol-eb2b2a37c5d1)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`NationalSpire.DateSceneView.ShowAttachments()`](DateSceneView.cs.md#symbol-f99d5e4e9b59)；[`NationalSpire.DateSceneView.ShowInput(string, bool)`](DateSceneView.cs.md#symbol-4f0d075ed97b)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.TextEdit.GetCaretLine(int)`；`Godot.TextEdit.GetLine(int)`；`Godot.TextEdit.GetLineCount()`；`Godot.TextEdit.SetCaretColumn(int, bool, int)`；`Godot.TextEdit.SetCaretLine(int, bool, bool, int, int)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerScreen._dateEditingTurn`；`NationalSpire.CareerScreen._dateOffer`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.CareerScreen._privateDrafts`；`NationalSpire.CareerScreen.PrivateAttachmentCard(NationalSpire.PrivateOffer, bool)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.DateSceneRequest.Ending`；`NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.DateSceneRequest.Opening`；`NationalSpire.DateSceneView.Attachments`；`NationalSpire.DateSceneView.Editor`；`NationalSpire.DateSceneView.ShowAttachments()`；`NationalSpire.DateSceneView.ShowInput(string, bool)`；`NationalSpire.DateSceneView.Status`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateTurn.Attachments`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.PrivateTurn.Scene`；`NationalSpire.PrivateTurn.Status`；`NationalSpire.PrivateTurn.User`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_dateView.Attachments.AddChild(PrivateAttachmentCard(item, false))`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.Attachments.AddChild(PrivateAttachmentCard(item, false));`
- `Godot.TextEdit.GetCaretLine(int)`；输入表达式：`_dateView.Editor.GetCaretLine()`；返回值紧邻使用处：`ArgumentSyntax: _dateView.Editor.GetCaretLine()`
- `Godot.TextEdit.GetLine(int)`；输入表达式：`_dateView.Editor.GetLine(_dateView.Editor.GetCaretLine())`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _dateView.Editor.GetLine(_dateView.Editor.GetCaretLine()).Length`
- `Godot.TextEdit.GetLineCount()`；输入表达式：`_dateView.Editor.GetLineCount()`；返回值紧邻使用处：`BinaryExpressionSyntax: _dateView.Editor.GetLineCount() - 1`
- `Godot.TextEdit.SetCaretColumn(int, bool, int)`；输入表达式：`_dateView.Editor.SetCaretColumn(_dateView.Editor.GetLine(_dateView.Editor.GetCaretLine()).Length)`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.Editor.SetCaretColumn(_dateView.Editor.GetLine(_dateView.Editor.GetCaretLine()).Length);`
- `Godot.TextEdit.SetCaretLine(int, bool, bool, int, int)`；输入表达式：`_dateView.Editor.SetCaretLine(_dateView.Editor.GetLineCount() - 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.Editor.SetCaretLine(_dateView.Editor.GetLineCount() - 1);`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(ViewData)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.Name(ViewData)`
- `NationalSpire.CareerScreen.PrivateAttachmentCard(NationalSpire.PrivateOffer, bool)`；输入表达式：`PrivateAttachmentCard(item, false)`；返回值紧邻使用处：`ArgumentSyntax: PrivateAttachmentCard(item, false)`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(_dateView.Attachments)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(_dateView.Attachments);`
- `NationalSpire.DateSceneView.ShowAttachments()`；输入表达式：`_dateView.ShowAttachments()`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.ShowAttachments();`
- `NationalSpire.DateSceneView.ShowInput(string, bool)`；输入表达式：`_dateView.ShowInput(CareerEngine.Name(ViewData), keepWaiting: true)`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.ShowInput(CareerEngine.Name(ViewData), keepWaiting: true);`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(ViewData, _datePerson)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Conversation(ViewData, _datePerson).Turns`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`PrivateMessages.Conversation(ViewData, _datePerson).Turns.LastOrDefault()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(ViewData, _datePerson).Turns.LastOrDefault()`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`_privateDrafts.GetValueOrDefault(_datePerson)`；返回值紧邻使用处：`IsPatternExpressionSyntax: _privateDrafts.GetValueOrDefault(_datePerson) is { Length: > 0 } draft`

**赋值（含属性/字段和局部值）：**

- `_dateEditingTurn` = `turn.Id`
- `_dateView.Editor.Text` = `_privateDrafts.GetValueOrDefault(_datePerson) is { Length: > 0 } draft ? draft : turn.Scene.Opening ? "" : turn.User`
- `_dateView.Status.Text` = `"修改后发送将重试这一条消息，原附件继续保留。"`

<a id="symbol-0845ec2acab1"></a>

## `NationalSpire.CareerScreen.DateSceneSettings() — private void DateSceneSettings()`

来源：源码第 335 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`Apply()`](DateSceneScreen.cs.md#symbol-c87d3c4db5f5)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.PickNestedFile(string, string[], System.Action<string>)`](CareerFilePicker.cs.md#symbol-ca0ccac08c64)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.CareerScreen.ShowDateLine()`](DateSceneScreen.cs.md#symbol-1580b0be190e)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`](DateSceneAssets.cs.md#symbol-2bf1f40a912e)；[`NationalSpire.DateSceneBackgrounds.Closest(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneBackground>, string, string)`](DateSceneBackgrounds.cs.md#symbol-fe6e9e9ebd7b)；[`NationalSpire.DateSceneBackgrounds.Import(string)`](DateSceneBackgrounds.cs.md#symbol-2c3c4974b94b)；[`NationalSpire.DateSceneBackgrounds.Read(out string, string?)`](DateSceneBackgrounds.cs.md#symbol-b6c3bc7d87d9)；[`NationalSpire.DateSceneBackgrounds.Remove(string)`](DateSceneBackgrounds.cs.md#symbol-b7d6d0097052)；[`Offset(string, double, System.Action<double>)`](DateSceneScreen.cs.md#symbol-7b83a59636e5)；[`PopulateBackgrounds()`](DateSceneScreen.cs.md#symbol-ee2dde19af2b)；[`Save()`](DateSceneScreen.cs.md#symbol-099c31bd66b5)；`Godot.BaseButton.SetPressedNoSignal(bool)`；`Godot.CheckBox.CheckBox()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.HSlider.HSlider()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.OptionButton()`；`Godot.OptionButton.Select(int)`；`Godot.Range.SetValueNoSignal(double)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.BroadcastScroll.BroadcastScroll()`；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Math.Clamp(float, float, float)`；`System.Math.Clamp(int, int, int)`

**字段、属性、事件及方法组引用：** `Apply()`；`NationalSpire.CareerScreen._cancelDialog`；`NationalSpire.CareerScreen._dateAssets`；`NationalSpire.CareerScreen._dateBackground`；`NationalSpire.CareerScreen._dateBackgrounds`；`NationalSpire.CareerScreen._dateIndex`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._stage`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.PickNestedFile(string, string[], System.Action<string>)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.ShowDateLine()`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.DateSceneAssets.AutoBackground`；`NationalSpire.DateSceneAssets.Background`；`NationalSpire.DateSceneAssets.BlurAmount`；`NationalSpire.DateSceneAssets.FontSize`；`NationalSpire.DateSceneAssets.LetterSpacing`；`NationalSpire.DateSceneAssets.PanelFade`；`NationalSpire.DateSceneAssets.ShowAffectionBadge`；`NationalSpire.DateSceneAssets.SpriteScale`；`NationalSpire.DateSceneAssets.SpriteX`；`NationalSpire.DateSceneAssets.SpriteY`；`NationalSpire.DateSceneAssets.TextOutline`；`NationalSpire.DateSceneAssets.TextSpeed`；`NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`；`NationalSpire.DateSceneBackground.Id`；`NationalSpire.DateSceneBackgrounds.Closest(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneBackground>, string, string)`；`NationalSpire.DateSceneBackgrounds.Import(string)`；`NationalSpire.DateSceneBackgrounds.Read(out string, string?)`；`NationalSpire.DateSceneBackgrounds.Remove(string)`；`NationalSpire.DateSceneView.InstantSpeed`；`Offset(string, double, System.Action<double>)`；`PopulateBackgrounds()`；`Save()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Apply()`；输入表达式：`Apply()`；返回值紧邻使用处：`ExpressionStatementSyntax: Apply();`
- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`auto.SetPressedNoSignal(false)`；返回值紧邻使用处：`ExpressionStatementSyntax: auto.SetPressedNoSignal(false);`
- `Godot.CheckBox.CheckBox()`；输入表达式：`new CheckBox { Name = "DateAutoBackground", Text = "根据场景和时间自动切换背景", ButtonPressed = assets.AutoBackground }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CheckBox { Name = "DateAutoBackground", Text = "根据场景和时间自动切换背景", ButtonPressed = assets.AutoBackground }`
- `Godot.CheckBox.CheckBox()`；输入表达式：`new CheckBox { Name = "DateShowAffection", Text = "显示好感徽章", ButtonPressed = assets.ShowAffectionBadge, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(292, 0) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CheckBox { Name = "DateShowAffection", Text = "显示好感徽章", ButtonPressed = assets.ShowAffectionBadge, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(292, 0) }`
- `Godot.CheckBox.CheckBox()`；输入表达式：`new CheckBox { Name = "DateTextOutline", Text = "正文黑色描边", ButtonPressed = assets.TextOutline, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(292, 0) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CheckBox { Name = "DateTextOutline", Text = "正文黑色描边", ButtonPressed = assets.TextOutline, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(292, 0) }`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`backgroundActions.AddThemeConstantOverride("separation", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: backgroundActions.AddThemeConstantOverride("separation", 18);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation", 14);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`position.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: position.AddThemeConstantOverride("separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`switches.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: switches.AddThemeConstantOverride("separation", 16);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.HSlider.HSlider()`；输入表达式：`new HSlider { Name = "DateBlurAmount", MinValue = 0, MaxValue = 20, Step = 0, Value = assets.BlurAmount, CustomMinimumSize = new(600, 35) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HSlider { Name = "DateBlurAmount", MinValue = 0, MaxValue = 20, Step = 0, Value = assets.BlurAmount, CustomMinimumSize = new(600, 35) }`
- `Godot.HSlider.HSlider()`；输入表达式：`new HSlider { Name = "DateLetterSpacing", MinValue = 0, MaxValue = 3, Step = .05, Value = assets.LetterSpacing, CustomMinimumSize = new(600, 35) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HSlider { Name = "DateLetterSpacing", MinValue = 0, MaxValue = 3, Step = .05, Value = assets.LetterSpacing, CustomMinimumSize = new(600, 35) }`
- `Godot.HSlider.HSlider()`；输入表达式：`new HSlider { Name = "DatePanelFade", MinValue = 0, MaxValue = 1, Step = 0, Value = assets.PanelFade, CustomMinimumSize = new(600, 35) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HSlider { Name = "DatePanelFade", MinValue = 0, MaxValue = 1, Step = 0, Value = assets.PanelFade, CustomMinimumSize = new(600, 35) }`
- `Godot.HSlider.HSlider()`；输入表达式：`new HSlider { Name = "DateSpriteScale", MinValue = .25, MaxValue = 2.5, Step = .01, Value = assets.SpriteScale, CustomMinimumSize = new(600, 35) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HSlider { Name = "DateSpriteScale", MinValue = .25, MaxValue = 2.5, Step = .01, Value = assets.SpriteScale, CustomMinimumSize = new(600, 35) }`
- `Godot.HSlider.HSlider()`；输入表达式：`new HSlider { Name = "DateTextSpeed", MinValue = 5, MaxValue = DateSceneView.InstantSpeed, Step = 0, Value = assets.TextSpeed, CustomMinimumSize = new(600, 35) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HSlider { Name = "DateTextSpeed", MinValue = 5, MaxValue = DateSceneView.InstantSpeed, Step = 0, Value = assets.TextSpeed, CustomMinimumSize = new(600, 35) }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`backgroundActions.AddChild(Button("导入背景图片 / ZIP背景包", () => PickNestedFile("导入背景", [".png", ".jpg", ".jpeg", ".webp", ".zip"], path =>              { try { assets.Background = DateSceneBackgrounds.Import(path); _dateBackgrounds = DateSceneBackgrounds.Read(out _); assets.AutoBackground = false; auto.SetPressedNoSignal(false); Save(); PopulateBackgrounds(); } catch (Exception e) { Notice("背景导入失败：" + e.Message, true); } }), 350))`；返回值紧邻使用处：`ExpressionStatementSyntax: backgroundActions.AddChild(Button("导入背景图片 / ZIP背景包", () => PickNestedFile("导入背景", [".png", ".jpg", ".jpeg", ".webp", ".zip"], path =>              { try { assets.Background = DateSceneBackgrounds.Import(path); _dateBackgrounds = DateSceneBackgrounds.Read(out _); assets.AutoBackground = false; auto.SetPressedNoSignal(false); Save(); PopulateBackgrounds(); } catch (Exception e) { Notice("背景导入失败：" + e.Message, true); } }), 350));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`backgroundActions.AddChild(removeBackground)`；返回值紧邻使用处：`ExpressionStatementSyntax: backgroundActions.AddChild(removeBackground);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(auto)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(auto);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(backgroundActions)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(backgroundActions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(blurAmount)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(blurAmount);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(blurLabel)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(blurLabel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Button("从本轮第一句重看", () => { _dateIndex = 0; ShowDateLine(); _cancelDialog?.Invoke(); }, 240))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Button("从本轮第一句重看", () => { _dateIndex = 0; ShowDateLine(); _cancelDialog?.Invoke(); }, 240));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Button("恢复立绘默认大小与位置", () => { assets.SpriteScale = 1; assets.SpriteX = assets.SpriteY = 0; scale.SetValueNoSignal(1); x.SetValueNoSignal(0); y.SetValueNoSignal(0); scaleLabel.Text = "立绘缩放 · 100%"; Save(); }, 300))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Button("恢复立绘默认大小与位置", () => { assets.SpriteScale = 1; assets.SpriteX = assets.SpriteY = 0; scale.SetValueNoSignal(1); x.SetValueNoSignal(0); y.SetValueNoSignal(0); scaleLabel.Text = "立绘缩放 · 100%"; Save(); }, 300));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(choices)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(choices);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(fade)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(fade);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(fadeLabel)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(fadeLabel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(fonts)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(fonts);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(position)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(position);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(scale)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(scale);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(scaleLabel)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(scaleLabel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(spacing)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(spacing);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(spacingLabel)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(spacingLabel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(speed)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(speed);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(speedLabel)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(speedLabel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(switches)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(switches);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text("字体大小", 18, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text("字体大小", 18, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`outer.AddChild(scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: outer.AddChild(scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scroll.AddChild(box)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.AddChild(box);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`switches.AddChild(affection)`；返回值紧邻使用处：`ExpressionStatementSyntax: switches.AddChild(affection);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`switches.AddChild(outline)`；返回值紧邻使用处：`ExpressionStatementSyntax: switches.AddChild(outline);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`fonts.AddItem(label)`；返回值紧邻使用处：`ExpressionStatementSyntax: fonts.AddItem(label);`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { Name = "DateBackgroundChoice", CustomMinimumSize = new(0, 40), FitToLongestItem = false }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { Name = "DateBackgroundChoice", CustomMinimumSize = new(0, 40), FitToLongestItem = false }`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { Name = "DateFontSize", CustomMinimumSize = new(0, 42) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { Name = "DateFontSize", CustomMinimumSize = new(0, 42) }`
- `Godot.OptionButton.Select(int)`；输入表达式：`fonts.Select(Math.Clamp(assets.FontSize, 0, 2))`；返回值紧邻使用处：`ExpressionStatementSyntax: fonts.Select(Math.Clamp(assets.FontSize, 0, 2));`
- `Godot.Range.SetValueNoSignal(double)`；输入表达式：`scale.SetValueNoSignal(1)`；返回值紧邻使用处：`ExpressionStatementSyntax: scale.SetValueNoSignal(1);`
- `Godot.Range.SetValueNoSignal(double)`；输入表达式：`x.SetValueNoSignal(0)`；返回值紧邻使用处：`ExpressionStatementSyntax: x.SetValueNoSignal(0);`
- `Godot.Range.SetValueNoSignal(double)`；输入表达式：`y.SetValueNoSignal(0)`；返回值紧邻使用处：`ExpressionStatementSyntax: y.SetValueNoSignal(0);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 40)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 40)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 42)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(292, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(292, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(600, 35)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(600, 35)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(660, Math.Clamp(_stage.Size.Y - 300, 330, 540))`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(660, Math.Clamp(_stage.Size.Y - 300, 330, 540))`
- `NationalSpire.BroadcastScroll.BroadcastScroll()`；输入表达式：`new BroadcastScroll { Name = "DateSettingsScroll", CustomMinimumSize = new(660, Math.Clamp(_stage.Size.Y - 300, 330, 540)), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastScroll { Name = "DateSettingsScroll", CustomMinimumSize = new(660, Math.Clamp(_stage.Size.Y - 300, 330, 540)), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("从本轮第一句重看", () => { _dateIndex = 0; ShowDateLine(); _cancelDialog?.Invoke(); }, 240)`；返回值紧邻使用处：`ArgumentSyntax: Button("从本轮第一句重看", () => { _dateIndex = 0; ShowDateLine(); _cancelDialog?.Invoke(); }, 240)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("导入背景图片 / ZIP背景包", () => PickNestedFile("导入背景", [".png", ".jpg", ".jpeg", ".webp", ".zip"], path =>              { try { assets.Background = DateSceneBackgrounds.Import(path); _dateBackgrounds = DateSceneBackgrounds.Read(out _); assets.AutoBackground = false; auto.SetPressedNoSignal(false); Save(); PopulateBackgrounds(); } catch (Exception e) { Notice("背景导入失败：" + e.Message, true); } }), 350)`；返回值紧邻使用处：`ArgumentSyntax: Button("导入背景图片 / ZIP背景包", () => PickNestedFile("导入背景", [".png", ".jpg", ".jpeg", ".webp", ".zip"], path =>              { try { assets.Background = DateSceneBackgrounds.Import(path); _dateBackgrounds = DateSceneBackgrounds.Read(out _); assets.AutoBackground = false; auto.SetPressedNoSignal(false); Save(); PopulateBackgrounds(); } catch (Exception e) { Notice("背景导入失败：" + e.Message, true); } }), 350)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("恢复立绘默认大小与位置", () => { assets.SpriteScale = 1; assets.SpriteX = assets.SpriteY = 0; scale.SetValueNoSignal(1); x.SetValueNoSignal(0); y.SetValueNoSignal(0); scaleLabel.Text = "立绘缩放 · 100%"; Save(); }, 300)`；返回值紧邻使用处：`ArgumentSyntax: Button("恢复立绘默认大小与位置", () => { assets.SpriteScale = 1; assets.SpriteX = assets.SpriteY = 0; scale.SetValueNoSignal(1); x.SetValueNoSignal(0); y.SetValueNoSignal(0); scaleLabel.Text = "立绘缩放 · 100%"; Save(); }, 300)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("删除当前背景", () =>              {                  if (_dateBackground.Length == 0) return;                  try { DateSceneBackgrounds.Remove(_dateBackground); _dateBackgrounds = DateSceneBackgrounds.Read(out _); assets.Background = DateSceneBackgrounds.Closest(_dateBackgrounds, "", ""); Save(); PopulateBackgrounds(); }                  catch (Exception e) { Notice("背景删除失败：" + e.Message, true); }              }, 180)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("删除当前背景", () =>              {                  if (_dateBackground.Length == 0) return;                  try { DateSceneBackgrounds.Remove(_dateBackground); _dateBackgrounds = DateSceneBackgrounds.Read(out _); assets.Background = DateSceneBackgrounds.Closest(_dateBackgrounds, "", ""); Save(); PopulateBackgrounds(); }                  catch (Exception e) { Notice("背景删除失败：" + e.Message, true); }              }, 180)`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("背景导入失败：" + e.Message, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("背景导入失败：" + e.Message, true);`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("背景删除失败：" + e.Message, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("背景删除失败：" + e.Message, true);`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(e.Message, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(e.Message, true);`
- `NationalSpire.CareerScreen.PickNestedFile(string, string[], System.Action<string>)`；输入表达式：`PickNestedFile("导入背景", [".png", ".jpg", ".jpeg", ".webp", ".zip"], path =>              { try { assets.Background = DateSceneBackgrounds.Import(path); _dateBackgrounds = DateSceneBackgrounds.Read(out _); assets.AutoBackground = false; auto.SetPressedNoSignal(false); Save(); PopulateBackgrounds(); } catch (Exception e) { Notice("背景导入失败：" + e.Message, true); } })`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => PickNestedFile("导入背景", [".png", ".jpg", ".jpeg", ".webp", ".zip"], path =>              { try { assets.Background = DateSceneBackgrounds.Import(path); _dateBackgrounds = DateSceneBackgrounds.Read(out _); assets.AutoBackground = false; auto.SetPressedNoSignal(false); Save(); PopulateBackgrounds(); } catch (Exception e) { Notice("背景导入失败：" + e.Message, true); } })`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("场景设置", "背景与显示偏好保存在本机。", () => true, "关闭", outer =>          {              var scroll = new BroadcastScroll { Name = "DateSettingsScroll", CustomMinimumSize = new(660, Math.Clamp(_stage.Size.Y - 300, 330, 540)), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; outer.AddChild(scroll);              var box = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; box.AddThemeConstantOverride("separation", 14); scroll.AddChild(box);              var auto = new CheckBox { Name = "DateAutoBackground", Text = "根据场景和时间自动切换背景", ButtonPressed = assets.AutoBackground }; box.AddChild(auto);              var choices = new OptionButton { Name = "DateBackgroundChoice", CustomMinimumSize = new(0, 40), FitToLongestItem = false }; box.AddChild(choices);              void PopulateBackgrounds()              {                  choices.Clear(); foreach (var item in _dateBackgrounds) choices.AddItem(item.Id + " · " + item.Description);                  if (_dateBackgrounds.Count == 0) { choices.AddItem("请导入背景图片或ZIP背景包"); choices.SetItemDisabled(0, true); }                  choices.Select(Math.Max(0, _dateBackgrounds.FindIndex(b => b.Id == _dateBackground)));              }              choices.ItemSelected += index => { assets.Background = _dateBackgrounds[(int)index].Id; assets.AutoBackground = false; auto.SetPressedNoSignal(false); Save(); };              PopulateBackgrounds();              auto.Toggled += value => { assets.AutoBackground = value; Save(); PopulateBackgrounds(); };              var backgroundActions = new HBoxContainer(); backgroundActions.AddThemeConstantOverride("separation", 18); box.AddChild(backgroundActions);              backgroundActions.AddChild(Button("导入背景图片 / ZIP背景包", () => PickNestedFile("导入背景", [".png", ".jpg", ".jpeg", ".webp", ".zip"], path =>              { try { assets.Background = DateSceneBackgrounds.Import(path); _dateBackgrounds = DateSceneBackgrounds.Read(out _); assets.AutoBackground = false; auto.SetPressedNoSignal(false); Save(); PopulateBackgrounds(); } catch (Exception e) { Notice("背景导入失败：" + e.Message, true); } }), 350));              var removeBackground = Button("删除当前背景", () =>              {                  if (_dateBackground.Length == 0) return;                  try { DateSceneBackgrounds.Remove(_dateBackground); _dateBackgrounds = DateSceneBackgrounds.Read(out _); assets.Background = DateSceneBackgrounds.Closest(_dateBackgrounds, "", ""); Save(); PopulateBackgrounds(); }                  catch (Exception e) { Notice("背景删除失败：" + e.Message, true); }              }, 180); removeBackground.Name = "DateBackgroundDelete"; backgroundActions.AddChild(removeBackground);              var blurLabel = Text($"模糊强度 · {assets.BlurAmount:F1}", 18, _ink); box.AddChild(blurLabel);              var blurAmount = new HSlider { Name = "DateBlurAmount", MinValue = 0, MaxValue = 20, Step = 0, Value = assets.BlurAmount, CustomMinimumSize = new(600, 35) }; box.AddChild(blurAmount);              blurAmount.ValueChanged += value => { assets.BlurAmount = value; blurLabel.Text = $"模糊强度 · {value:F1}"; Apply(); };              blurAmount.DragEnded += changed => { if (changed) Save(); };              var fonts = new OptionButton { Name = "DateFontSize", CustomMinimumSize = new(0, 42) };              foreach (string label in new[] { "小号", "中号（默认）", "大号" }) fonts.AddItem(label);              fonts.Select(Math.Clamp(assets.FontSize, 0, 2)); box.AddChild(Text("字体大小", 18, _ink)); box.AddChild(fonts);              fonts.ItemSelected += value => { assets.FontSize = (int)value; Save(); };              var spacingLabel = Text($"字间距 · 额外增加 {assets.LetterSpacing:P0}", 18, _ink); box.AddChild(spacingLabel);              var spacing = new HSlider { Name = "DateLetterSpacing", MinValue = 0, MaxValue = 3, Step = .05, Value = assets.LetterSpacing, CustomMinimumSize = new(600, 35) }; box.AddChild(spacing);              spacing.TooltipText = "0% 使用原始间距；默认增加100%，约为原字间留白的两倍。";              spacing.ValueChanged += value => { assets.LetterSpacing = value; spacingLabel.Text = $"字间距 · 额外增加 {value:P0}"; Apply(); };              spacing.DragEnded += changed => { if (changed) Save(); };              var switches = new HBoxContainer(); switches.AddThemeConstantOverride("separation", 16); box.AddChild(switches);              var outline = new CheckBox { Name = "DateTextOutline", Text = "正文黑色描边", ButtonPressed = assets.TextOutline, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(292, 0) }; switches.AddChild(outline);              var affection = new CheckBox { Name = "DateShowAffection", Text = "显示好感徽章", ButtonPressed = assets.ShowAffectionBadge, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(292, 0) }; switches.AddChild(affection);              outline.Toggled += value => { assets.TextOutline = value; Save(); };              affection.Toggled += value => { assets.ShowAffectionBadge = value; Save(); };              var scaleLabel = Text($"立绘缩放 · {assets.SpriteScale:P0}", 18, _ink); box.AddChild(scaleLabel);              var scale = new HSlider { Name = "DateSpriteScale", MinValue = .25, MaxValue = 2.5, Step = .01, Value = assets.SpriteScale, CustomMinimumSize = new(600, 35) }; box.AddChild(scale);              scale.ValueChanged += value => { assets.SpriteScale = value; scaleLabel.Text = $"立绘缩放 · {value:P0}"; Apply(); };              scale.DragEnded += changed => { if (changed) Save(); };              var position = new HBoxContainer(); position.AddThemeConstantOverride("separation", 16); box.AddChild(position);              SpinBox Offset(string axis, double value, Action<double> change)              {                  position.AddChild(Text(axis, 17, _ink)); var input = new SpinBox { Name = "DateSprite" + axis, MinValue = -4096, MaxValue = 4096, Step = 1, Value = value, CustomMinimumSize = new(170, 42) };                  position.AddChild(input); input.ValueChanged += v => { change(v); Save(); }; return input;              }              var x = Offset("X", assets.SpriteX, v => assets.SpriteX = v); var y = Offset("Y", assets.SpriteY, v => assets.SpriteY = v);              box.AddChild(Button("恢复立绘默认大小与位置", () => { assets.SpriteScale = 1; assets.SpriteX = assets.SpriteY = 0; scale.SetValueNoSignal(1); x.SetValueNoSignal(0); y.SetValueNoSignal(0); scaleLabel.Text = "立绘缩放 · 100%"; Save(); }, 300));              var speedLabel = Text("文字速度 · 滑到最右立即显示全文", 18, _ink); box.AddChild(speedLabel);              var speed = new HSlider { Name = "DateTextSpeed", MinValue = 5, MaxValue = DateSceneView.InstantSpeed, Step = 0, Value = assets.TextSpeed, CustomMinimumSize = new(600, 35) }; box.AddChild(speed);              speed.ValueChanged += value => { assets.TextSpeed = value; speedLabel.Text = value >= DateSceneView.InstantSpeed ? "文字速度 · 立即显示全文" : $"文字速度 · {value:F0}字/秒"; Apply(); };              var fadeLabel = Text("文本框不透明度 · 底部100% / 上缘75% → 底部50% / 上缘0%\n上缘位于顶部下方15像素，顶部始终完全透明。", 16, _ink); box.AddChild(fadeLabel);              var fade = new HSlider { Name = "DatePanelFade", MinValue = 0, MaxValue = 1, Step = 0, Value = assets.PanelFade, CustomMinimumSize = new(600, 35) }; box.AddChild(fade);              fade.ValueChanged += value => { assets.PanelFade = value; Apply(); };              speed.DragEnded += changed => { if (changed) Save(); }; fade.DragEnded += changed => { if (changed) Save(); };              box.AddChild(Button("从本轮第一句重看", () => { _dateIndex = 0; ShowDateLine(); _cancelDialog?.Invoke(); }, 240));          }, showCancel: false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("场景设置", "背景与显示偏好保存在本机。", () => true, "关闭", outer =>          {              var scroll = new BroadcastScroll { Name = "DateSettingsScroll", CustomMinimumSize = new(660, Math.Clamp(_stage.Size.Y - 300, 330, 540)), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; outer.AddChild(scroll);              var box = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; box.AddThemeConstantOverride("separation", 14); scroll.AddChild(box);              var auto = new CheckBox { Name = "DateAutoBackground", Text = "根据场景和时间自动切换背景", ButtonPressed = assets.AutoBackground }; box.AddChild(auto);              var choices = new OptionButton { Name = "DateBackgroundChoice", CustomMinimumSize = new(0, 40), FitToLongestItem = false }; box.AddChild(choices);              void PopulateBackgrounds()              {                  choices.Clear(); foreach (var item in _dateBackgrounds) choices.AddItem(item.Id + " · " + item.Description);                  if (_dateBackgrounds.Count == 0) { choices.AddItem("请导入背景图片或ZIP背景包"); choices.SetItemDisabled(0, true); }                  choices.Select(Math.Max(0, _dateBackgrounds.FindIndex(b => b.Id == _dateBackground)));              }              choices.ItemSelected += index => { assets.Background = _dateBackgrounds[(int)index].Id; assets.AutoBackground = false; auto.SetPressedNoSignal(false); Save(); };              PopulateBackgrounds();              auto.Toggled += value => { assets.AutoBackground = value; Save(); PopulateBackgrounds(); };              var backgroundActions = new HBoxContainer(); backgroundActions.AddThemeConstantOverride("separation", 18); box.AddChild(backgroundActions);              backgroundActions.AddChild(Button("导入背景图片 / ZIP背景包", () => PickNestedFile("导入背景", [".png", ".jpg", ".jpeg", ".webp", ".zip"], path =>              { try { assets.Background = DateSceneBackgrounds.Import(path); _dateBackgrounds = DateSceneBackgrounds.Read(out _); assets.AutoBackground = false; auto.SetPressedNoSignal(false); Save(); PopulateBackgrounds(); } catch (Exception e) { Notice("背景导入失败：" + e.Message, true); } }), 350));              var removeBackground = Button("删除当前背景", () =>              {                  if (_dateBackground.Length == 0) return;                  try { DateSceneBackgrounds.Remove(_dateBackground); _dateBackgrounds = DateSceneBackgrounds.Read(out _); assets.Background = DateSceneBackgrounds.Closest(_dateBackgrounds, "", ""); Save(); PopulateBackgrounds(); }                  catch (Exception e) { Notice("背景删除失败：" + e.Message, true); }              }, 180); removeBackground.Name = "DateBackgroundDelete"; backgroundActions.AddChild(removeBackground);              var blurLabel = Text($"模糊强度 · {assets.BlurAmount:F1}", 18, _ink); box.AddChild(blurLabel);              var blurAmount = new HSlider { Name = "DateBlurAmount", MinValue = 0, MaxValue = 20, Step = 0, Value = assets.BlurAmount, CustomMinimumSize = new(600, 35) }; box.AddChild(blurAmount);              blurAmount.ValueChanged += value => { assets.BlurAmount = value; blurLabel.Text = $"模糊强度 · {value:F1}"; Apply(); };              blurAmount.DragEnded += changed => { if (changed) Save(); };              var fonts = new OptionButton { Name = "DateFontSize", CustomMinimumSize = new(0, 42) };              foreach (string label in new[] { "小号", "中号（默认）", "大号" }) fonts.AddItem(label);              fonts.Select(Math.Clamp(assets.FontSize, 0, 2)); box.AddChild(Text("字体大小", 18, _ink)); box.AddChild(fonts);              fonts.ItemSelected += value => { assets.FontSize = (int)value; Save(); };              var spacingLabel = Text($"字间距 · 额外增加 {assets.LetterSpacing:P0}", 18, _ink); box.AddChild(spacingLabel);              var spacing = new HSlider { Name = "DateLetterSpacing", MinValue = 0, MaxValue = 3, Step = .05, Value = assets.LetterSpacing, CustomMinimumSize = new(600, 35) }; box.AddChild(spacing);              spacing.TooltipText = "0% 使用原始间距；默认增加100%，约为原字间留白的两倍。";              spacing.ValueChanged += value => { assets.LetterSpacing = value; spacingLabel.Text = $"字间距 · 额外增加 {value:P0}"; Apply(); };              spacing.DragEnded += changed => { if (changed) Save(); };              var switches = new HBoxContainer(); switches.AddThemeConstantOverride("separation", 16); box.AddChild(switches);              var outline = new CheckBox { Name = "DateTextOutline", Text = "正文黑色描边", ButtonPressed = assets.TextOutline, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(292, 0) }; switches.AddChild(outline);              var affection = new CheckBox { Name = "DateShowAffection", Text = "显示好感徽章", ButtonPressed = assets.ShowAffectionBadge, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(292, 0) }; switches.AddChild(affection);              outline.Toggled += value => { assets.TextOutline = value; Save(); };              affection.Toggled += value => { assets.ShowAffectionBadge = value; Save(); };              var scaleLabel = Text($"立绘缩放 · {assets.SpriteScale:P0}", 18, _ink); box.AddChild(scaleLabel);              var scale = new HSlider { Name = "DateSpriteScale", MinValue = .25, MaxValue = 2.5, Step = .01, Value = assets.SpriteScale, CustomMinimumSize = new(600, 35) }; box.AddChild(scale);              scale.ValueChanged += value => { assets.SpriteScale = value; scaleLabel.Text = $"立绘缩放 · {value:P0}"; Apply(); };              scale.DragEnded += changed => { if (changed) Save(); };              var position = new HBoxContainer(); position.AddThemeConstantOverride("separation", 16); box.AddChild(position);              SpinBox Offset(string axis, double value, Action<double> change)              {                  position.AddChild(Text(axis, 17, _ink)); var input = new SpinBox { Name = "DateSprite" + axis, MinValue = -4096, MaxValue = 4096, Step = 1, Value = value, CustomMinimumSize = new(170, 42) };                  position.AddChild(input); input.ValueChanged += v => { change(v); Save(); }; return input;              }              var x = Offset("X", assets.SpriteX, v => assets.SpriteX = v); var y = Offset("Y", assets.SpriteY, v => assets.SpriteY = v);              box.AddChild(Button("恢复立绘默认大小与位置", () => { assets.SpriteScale = 1; assets.SpriteX = assets.SpriteY = 0; scale.SetValueNoSignal(1); x.SetValueNoSignal(0); y.SetValueNoSignal(0); scaleLabel.Text = "立绘缩放 · 100%"; Save(); }, 300));              var speedLabel = Text("文字速度 · 滑到最右立即显示全文", 18, _ink); box.AddChild(speedLabel);              var speed = new HSlider { Name = "DateTextSpeed", MinValue = 5, MaxValue = DateSceneView.InstantSpeed, Step = 0, Value = assets.TextSpeed, CustomMinimumSize = new(600, 35) }; box.AddChild(speed);              speed.ValueChanged += value => { assets.TextSpeed = value; speedLabel.Text = value >= DateSceneView.InstantSpeed ? "文字速度 · 立即显示全文" : $"文字速度 · {value:F0}字/秒"; Apply(); };              var fadeLabel = Text("文本框不透明度 · 底部100% / 上缘75% → 底部50% / 上缘0%\n上缘位于顶部下方15像素，顶部始终完全透明。", 16, _ink); box.AddChild(fadeLabel);              var fade = new HSlider { Name = "DatePanelFade", MinValue = 0, MaxValue = 1, Step = 0, Value = assets.PanelFade, CustomMinimumSize = new(600, 35) }; box.AddChild(fade);              fade.ValueChanged += value => { assets.PanelFade = value; Apply(); };              speed.DragEnded += changed => { if (changed) Save(); }; fade.DragEnded += changed => { if (changed) Save(); };              box.AddChild(Button("从本轮第一句重看", () => { _dateIndex = 0; ShowDateLine(); _cancelDialog?.Invoke(); }, 240));          }, showCancel: false);`
- `NationalSpire.CareerScreen.ShowDateLine()`；输入表达式：`ShowDateLine()`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowDateLine();`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("文本框不透明度 · 底部100% / 上缘75% → 底部50% / 上缘0%\n上缘位于顶部下方15像素，顶部始终完全透明。", 16, _ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("文本框不透明度 · 底部100% / 上缘75% → 底部50% / 上缘0%\n上缘位于顶部下方15像素，顶部始终完全透明。", 16, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("文字速度 · 滑到最右立即显示全文", 18, _ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("文字速度 · 滑到最右立即显示全文", 18, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("字体大小", 18, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text("字体大小", 18, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"立绘缩放 · {assets.SpriteScale:P0}", 18, _ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text($"立绘缩放 · {assets.SpriteScale:P0}", 18, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"模糊强度 · {assets.BlurAmount:F1}", 18, _ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text($"模糊强度 · {assets.BlurAmount:F1}", 18, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"字间距 · 额外增加 {assets.LetterSpacing:P0}", 18, _ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text($"字间距 · 额外增加 {assets.LetterSpacing:P0}", 18, _ink)`
- `NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`；输入表达式：`DateSceneAssetStore.Save(data, person, assets)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateSceneAssetStore.Save(data, person, assets);`
- `NationalSpire.DateSceneBackgrounds.Closest(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneBackground>, string, string)`；输入表达式：`DateSceneBackgrounds.Closest(_dateBackgrounds, "", "")`；返回值紧邻使用处：`AssignmentExpressionSyntax: assets.Background = DateSceneBackgrounds.Closest(_dateBackgrounds, "", "")`
- `NationalSpire.DateSceneBackgrounds.Import(string)`；输入表达式：`DateSceneBackgrounds.Import(path)`；返回值紧邻使用处：`AssignmentExpressionSyntax: assets.Background = DateSceneBackgrounds.Import(path)`
- `NationalSpire.DateSceneBackgrounds.Read(out string, string?)`；输入表达式：`DateSceneBackgrounds.Read(out _)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dateBackgrounds = DateSceneBackgrounds.Read(out _)`
- `NationalSpire.DateSceneBackgrounds.Remove(string)`；输入表达式：`DateSceneBackgrounds.Remove(_dateBackground)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateSceneBackgrounds.Remove(_dateBackground);`
- `Offset(string, double, System.Action<double>)`；输入表达式：`Offset("X", assets.SpriteX, v => assets.SpriteX = v)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Offset("X", assets.SpriteX, v => assets.SpriteX = v)`
- `Offset(string, double, System.Action<double>)`；输入表达式：`Offset("Y", assets.SpriteY, v => assets.SpriteY = v)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Offset("Y", assets.SpriteY, v => assets.SpriteY = v)`
- `PopulateBackgrounds()`；输入表达式：`PopulateBackgrounds()`；返回值紧邻使用处：`ExpressionStatementSyntax: PopulateBackgrounds();`
- `Save()`；输入表达式：`Save()`；返回值紧邻使用处：`ExpressionStatementSyntax: Save();`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _cancelDialog?.Invoke()`
- `System.Math.Clamp(float, float, float)`；输入表达式：`Math.Clamp(_stage.Size.Y - 300, 330, 540)`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(_stage.Size.Y - 300, 330, 540)`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(assets.FontSize, 0, 2)`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(assets.FontSize, 0, 2)`

**赋值（含属性/字段和局部值）：**

- `_dateBackgrounds` = `DateSceneBackgrounds.Read(out _)`
- `_dateIndex` = `0`
- `_dialogOverlay.TreeExiting` += `() => { try { DateSceneAssetStore.Save(data, person, assets); } catch (Exception e) { Notice(e.Message, true); } }`
- `affection.Toggled` += `value => { assets.ShowAffectionBadge = value; Save(); }`
- `assets.AutoBackground` = `false`
- `assets.AutoBackground` = `value`
- `assets.Background` = `_dateBackgrounds[(int)index].Id`
- `assets.Background` = `DateSceneBackgrounds.Closest(_dateBackgrounds, "", "")`
- `assets.Background` = `DateSceneBackgrounds.Import(path)`
- `assets.BlurAmount` = `value`
- `assets.FontSize` = `(int)value`
- `assets.LetterSpacing` = `value`
- `assets.PanelFade` = `value`
- `assets.ShowAffectionBadge` = `value`
- `assets.SpriteScale` = `1`
- `assets.SpriteScale` = `value`
- `assets.SpriteX` = `assets.SpriteY = 0`
- `assets.SpriteX` = `v`
- `assets.SpriteY` = `0`
- `assets.SpriteY` = `v`
- `assets.TextOutline` = `value`
- `assets.TextSpeed` = `value`
- `auto.Toggled` += `value => { assets.AutoBackground = value; Save(); PopulateBackgrounds(); }`
- `blurAmount.DragEnded` += `changed => { if (changed) Save(); }`
- `blurAmount.ValueChanged` += `value => { assets.BlurAmount = value; blurLabel.Text = $"模糊强度 · {value:F1}"; Apply(); }`
- `blurLabel.Text` = `$"模糊强度 · {value:F1}"`
- `ButtonPressed` = `assets.AutoBackground`
- `ButtonPressed` = `assets.ShowAffectionBadge`
- `ButtonPressed` = `assets.TextOutline`
- `choices.ItemSelected` += `index => { assets.Background = _dateBackgrounds[(int)index].Id; assets.AutoBackground = false; auto.SetPressedNoSignal(false); Save(); }`
- `CustomMinimumSize` = `new(0, 40)`
- `CustomMinimumSize` = `new(0, 42)`
- `CustomMinimumSize` = `new(292, 0)`
- `CustomMinimumSize` = `new(600, 35)`
- `CustomMinimumSize` = `new(660, Math.Clamp(_stage.Size.Y - 300, 330, 540))`
- `fade.DragEnded` += `changed => { if (changed) Save(); }`
- `fade.ValueChanged` += `value => { assets.PanelFade = value; Apply(); }`
- `FitToLongestItem` = `false`
- `fonts.ItemSelected` += `value => { assets.FontSize = (int)value; Save(); }`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `MaxValue` = `1`
- `MaxValue` = `2.5`
- `MaxValue` = `20`
- `MaxValue` = `3`
- `MaxValue` = `DateSceneView.InstantSpeed`
- `MinValue` = `.25`
- `MinValue` = `0`
- `MinValue` = `5`
- `Name` = `"DateAutoBackground"`
- `Name` = `"DateBackgroundChoice"`
- `Name` = `"DateBlurAmount"`
- `Name` = `"DateFontSize"`
- `Name` = `"DateLetterSpacing"`
- `Name` = `"DatePanelFade"`
- `Name` = `"DateSettingsScroll"`
- `Name` = `"DateShowAffection"`
- `Name` = `"DateSpriteScale"`
- `Name` = `"DateTextOutline"`
- `Name` = `"DateTextSpeed"`
- `outline.Toggled` += `value => { assets.TextOutline = value; Save(); }`
- `removeBackground.Name` = `"DateBackgroundDelete"`
- `scale.DragEnded` += `changed => { if (changed) Save(); }`
- `scale.ValueChanged` += `value => { assets.SpriteScale = value; scaleLabel.Text = $"立绘缩放 · {value:P0}"; Apply(); }`
- `scaleLabel.Text` = `"立绘缩放 · 100%"`
- `scaleLabel.Text` = `$"立绘缩放 · {value:P0}"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `spacing.DragEnded` += `changed => { if (changed) Save(); }`
- `spacing.TooltipText` = `"0% 使用原始间距；默认增加100%，约为原字间留白的两倍。"`
- `spacing.ValueChanged` += `value => { assets.LetterSpacing = value; spacingLabel.Text = $"字间距 · 额外增加 {value:P0}"; Apply(); }`
- `spacingLabel.Text` = `$"字间距 · 额外增加 {value:P0}"`
- `speed.DragEnded` += `changed => { if (changed) Save(); }`
- `speed.ValueChanged` += `value => { assets.TextSpeed = value; speedLabel.Text = value >= DateSceneView.InstantSpeed ? "文字速度 · 立即显示全文" : $"文字速度 · {value:F0}字/秒"; Apply(); }`
- `speedLabel.Text` = `value >= DateSceneView.InstantSpeed ? "文字速度 · 立即显示全文" : $"文字速度 · {value:F0}字/秒"`
- `Step` = `.01`
- `Step` = `.05`
- `Step` = `0`
- `Text` = `"根据场景和时间自动切换背景"`
- `Text` = `"显示好感徽章"`
- `Text` = `"正文黑色描边"`
- `Value` = `assets.BlurAmount`
- `Value` = `assets.LetterSpacing`
- `Value` = `assets.PanelFade`
- `Value` = `assets.SpriteScale`
- `Value` = `assets.TextSpeed`

<a id="symbol-c87d3c4db5f5"></a>

## `Apply() — void Apply()`

来源：源码第 339 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DateSceneSettings()`](DateSceneScreen.cs.md#symbol-0845ec2acab1)；[`Save()`](DateSceneScreen.cs.md#symbol-099c31bd66b5)

**调用：** [`NationalSpire.CareerScreen.ApplyDateBackground()`](DateSceneScreen.cs.md#symbol-4c2055af1c70)；[`NationalSpire.DateSceneView.AffectionVisibility(bool)`](DateSceneView.cs.md#symbol-7da14922fda4)；[`NationalSpire.DateSceneView.Preferences(int, double, double)`](DateSceneView.cs.md#symbol-878552c24bd8)；[`NationalSpire.DateSceneView.Presentation(double, double, double, bool)`](DateSceneView.cs.md#symbol-32ea38e8c82d)；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._dateView`；`NationalSpire.CareerScreen.ApplyDateBackground()`；`NationalSpire.DateSceneAssets.FontSize`；`NationalSpire.DateSceneAssets.LetterSpacing`；`NationalSpire.DateSceneAssets.PanelFade`；`NationalSpire.DateSceneAssets.ShowAffectionBadge`；`NationalSpire.DateSceneAssets.SpriteScale`；`NationalSpire.DateSceneAssets.SpriteX`；`NationalSpire.DateSceneAssets.SpriteY`；`NationalSpire.DateSceneAssets.TextOutline`；`NationalSpire.DateSceneAssets.TextSpeed`；`NationalSpire.DateSceneView.AffectionVisibility(bool)`；`NationalSpire.DateSceneView.Preferences(int, double, double)`；`NationalSpire.DateSceneView.Presentation(double, double, double, bool)`；`NationalSpire.DateSceneView.TextSpeed`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_dateView)`；返回值紧邻使用处：`BinaryExpressionSyntax: _dateView != null && IsInstanceValid(_dateView)`
- `NationalSpire.CareerScreen.ApplyDateBackground()`；输入表达式：`ApplyDateBackground()`；返回值紧邻使用处：`ExpressionStatementSyntax: ApplyDateBackground();`
- `NationalSpire.DateSceneView.AffectionVisibility(bool)`；输入表达式：`_dateView.AffectionVisibility(assets.ShowAffectionBadge)`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.AffectionVisibility(assets.ShowAffectionBadge);`
- `NationalSpire.DateSceneView.Preferences(int, double, double)`；输入表达式：`_dateView.Preferences(assets.FontSize, assets.PanelFade, assets.LetterSpacing)`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.Preferences(assets.FontSize, assets.PanelFade, assets.LetterSpacing);`
- `NationalSpire.DateSceneView.Presentation(double, double, double, bool)`；输入表达式：`_dateView.Presentation(assets.SpriteScale, assets.SpriteX, assets.SpriteY, assets.TextOutline)`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.Presentation(assets.SpriteScale, assets.SpriteX, assets.SpriteY, assets.TextOutline);`

**赋值（含属性/字段和局部值）：**

- `_dateView.TextSpeed` = `assets.TextSpeed`

<a id="symbol-099c31bd66b5"></a>

## `Save() — void Save()`

来源：源码第 340 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DateSceneSettings()`](DateSceneScreen.cs.md#symbol-0845ec2acab1)；[`Offset(string, double, System.Action<double>)`](DateSceneScreen.cs.md#symbol-7b83a59636e5)

**调用：** [`Apply()`](DateSceneScreen.cs.md#symbol-c87d3c4db5f5)；[`NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`](DateSceneAssets.cs.md#symbol-2bf1f40a912e)

**字段、属性、事件及方法组引用：** `Apply()`；`NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Apply()`；输入表达式：`Apply()`；返回值紧邻使用处：`ExpressionStatementSyntax: Apply();`
- `NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`；输入表达式：`DateSceneAssetStore.Save(data, person, assets)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateSceneAssetStore.Save(data, person, assets);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ee2dde19af2b"></a>

## `PopulateBackgrounds() — void PopulateBackgrounds()`

来源：源码第 347 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DateSceneSettings()`](DateSceneScreen.cs.md#symbol-0845ec2acab1)

**调用：** `Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.Clear()`；`Godot.OptionButton.Select(int)`；`Godot.OptionButton.SetItemDisabled(int, bool)`；`System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._dateBackground`；`NationalSpire.CareerScreen._dateBackgrounds`；`NationalSpire.DateSceneBackground.Description`；`NationalSpire.DateSceneBackground.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`choices.AddItem("请导入背景图片或ZIP背景包")`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.AddItem("请导入背景图片或ZIP背景包");`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`choices.AddItem(item.Id + " · " + item.Description)`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.AddItem(item.Id + " · " + item.Description);`
- `Godot.OptionButton.Clear()`；输入表达式：`choices.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.Clear();`
- `Godot.OptionButton.Select(int)`；输入表达式：`choices.Select(Math.Max(0, _dateBackgrounds.FindIndex(b => b.Id == _dateBackground)))`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.Select(Math.Max(0, _dateBackgrounds.FindIndex(b => b.Id == _dateBackground)));`
- `Godot.OptionButton.SetItemDisabled(int, bool)`；输入表达式：`choices.SetItemDisabled(0, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.SetItemDisabled(0, true);`
- `System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；输入表达式：`_dateBackgrounds.FindIndex(b => b.Id == _dateBackground)`；返回值紧邻使用处：`ArgumentSyntax: _dateBackgrounds.FindIndex(b => b.Id == _dateBackground)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, _dateBackgrounds.FindIndex(b => b.Id == _dateBackground))`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, _dateBackgrounds.FindIndex(b => b.Id == _dateBackground))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7b83a59636e5"></a>

## `Offset(string, double, System.Action<double>) — SpinBox Offset(string axis, double value, Action<double> change)`

来源：源码第 388 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DateSceneSettings()`](DateSceneScreen.cs.md#symbol-0845ec2acab1)

**调用：** [`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`Save()`](DateSceneScreen.cs.md#symbol-099c31bd66b5)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.SpinBox.SpinBox()`；`Godot.Vector2.Vector2(float, float)`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`Save()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`position.AddChild(input)`；返回值紧邻使用处：`ExpressionStatementSyntax: position.AddChild(input);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`position.AddChild(Text(axis, 17, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: position.AddChild(Text(axis, 17, _ink));`
- `Godot.SpinBox.SpinBox()`；输入表达式：`new SpinBox { Name = "DateSprite" + axis, MinValue = -4096, MaxValue = 4096, Step = 1, Value = value, CustomMinimumSize = new(170, 42) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new SpinBox { Name = "DateSprite" + axis, MinValue = -4096, MaxValue = 4096, Step = 1, Value = value, CustomMinimumSize = new(170, 42) }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(170, 42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(170, 42)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(axis, 17, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(axis, 17, _ink)`
- `Save()`；输入表达式：`Save()`；返回值紧邻使用处：`ExpressionStatementSyntax: Save();`
- `System.Action<T>.Invoke(T)`；输入表达式：`change(v)`；返回值紧邻使用处：`ExpressionStatementSyntax: change(v);`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(170, 42)`
- `input.ValueChanged` += `v => { change(v); Save(); }`
- `MaxValue` = `4096`
- `MinValue` = `-4096`
- `Name` = `"DateSprite" + axis`
- `Step` = `1`
- `Value` = `value`
