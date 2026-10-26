# DateSceneScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`1F898188142E3FEBBC44170131C18726A285B0CA178DABA2C24B019C6F3A00B3`。来源：[源码](../../DateSceneScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

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
```

<a id="symbol-d6c92b4f494c"></a>

## `NationalSpire.CareerScreen.PromptDateScene(string) — private void PromptDateScene(string offer)`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddDateSceneAction(NationalSpire.CareerData, NationalSpire.PrivateOffer, Godot.HBoxContainer)`](DateSceneScreen.cs.md#symbol-413adf55a103)

**调用：** `Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；[`NationalSpire.CareerScreen.OpenDateScene(string, bool, bool)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`](CareerStore.cs.md#symbol-ead7461ee7cb)；[`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`](DateSceneData.cs.md#symbol-0d3e014bcb63)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.OpenDateScene(string, bool, bool)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(() => { if (IsInstanceValid(this) && CareerStore.IsCurrent(data)) OpenDateScene(offer); }).CallDeferred()`；返回值紧邻使用处：`ExpressionStatementSyntax: Callable.From(() => { if (IsInstanceValid(this) && CareerStore.IsCurrent(data)) OpenDateScene(offer); }).CallDeferred();`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(() => { if (IsInstanceValid(this) && CareerStore.IsCurrent(data)) OpenDateScene(offer); })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(() => { if (IsInstanceValid(this) && CareerStore.IsCurrent(data)) OpenDateScene(offer); }).CallDeferred`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(this)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(this) && CareerStore.IsCurrent(data)`
- `NationalSpire.CareerScreen.OpenDateScene(string, bool, bool)`；输入表达式：`OpenDateScene(offer)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenDateScene(offer);`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("进入约会场景", "以视觉小说方式继续这次活动；尚未导入立绘的角色使用默认剪影。", () => { Callable.From(() => { if (IsInstanceValid(this) && CareerStore.IsCurrent(data)) OpenDateScene(offer); }).CallDeferred(); return true; }, "进入场景", cancelText: "继续私聊")`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("进入约会场景", "以视觉小说方式继续这次活动；尚未导入立绘的角色使用默认剪影。", () => { Callable.From(() => { if (IsInstanceValid(this) && CareerStore.IsCurrent(data)) OpenDateScene(offer); }).CallDeferred(); return true; }, "进入场景", cancelText: "继续私聊");`
- `NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；输入表达式：`CareerStore.IsCurrent(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(this) && CareerStore.IsCurrent(data)`
- `NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；输入表达式：`DateScenes.Available(data, o, conversation)`；返回值紧邻使用处：`BinaryExpressionSyntax: o.Id == offer && DateScenes.Available(data, o, conversation)`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(data, person)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.Offers.Any(o => o.Id == offer && DateScenes.Available(data, o, conversation))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !conversation.Offers.Any(o => o.Id == offer && DateScenes.Available(data, o, conversation))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-277baf4e7cb8"></a>

## `NationalSpire.CareerScreen.SceneRequest(bool) — private DateSceneRequest SceneRequest(bool opening = false)`

来源：源码第 30 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenDateScene(string, bool, bool)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)；[`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)；[`NationalSpire.CareerScreen.SendPrivate()`](PrivateMessageScreen.cs.md#symbol-748ab66a7351)；[`NationalSpire.CareerScreen.StartDateGameReply(NationalSpire.CareerMatch, string)`](DateGameScreen.cs.md#symbol-8963173330c9)

**调用：** [`NationalSpire.CareerScreen.DateParticipants()`](DateScenePartyScreen.cs.md#symbol-658316b8bf70)；[`NationalSpire.DateSceneBackgrounds.AutomaticChoices(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneBackground>)`](DateSceneBackgrounds.cs.md#symbol-7e409d1b4e9f)；`NationalSpire.DateSceneRequest.DateSceneRequest()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.DateParticipants()`；`NationalSpire.CareerScreen.PrivateAttachments`；`NationalSpire.CareerScreen._dateAssets`；`NationalSpire.CareerScreen._dateBackground`；`NationalSpire.CareerScreen._dateBackgrounds`；`NationalSpire.CareerScreen._dateDesign`；`NationalSpire.CareerScreen._dateOffer`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.DateGames.AttachmentKind`；`NationalSpire.DateSceneAssets.OutfitId`；`NationalSpire.DateSceneBackground.Description`；`NationalSpire.DateSceneBackground.Id`；`NationalSpire.DateSceneBackgrounds.AutomaticChoices(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneBackground>)`；`NationalSpire.DateSceneParticipant.Emotions`；`NationalSpire.DateSceneParticipant.PersonId`；`NationalSpire.DateSceneRequest.Backgrounds`；`NationalSpire.DateSceneRequest.CurrentBackground`；`NationalSpire.DateSceneRequest.DefaultEmotionId`；`NationalSpire.DateSceneRequest.Emotions`；`NationalSpire.DateSceneRequest.GameInvitation`；`NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.DateSceneRequest.Opening`；`NationalSpire.DateSceneRequest.OutfitId`；`NationalSpire.DateSceneRequest.Participants`；`NationalSpire.PortraitDesign.DefaultEmotionId`；`NationalSpire.PrivateOffer.Kind`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.DateParticipants()`；输入表达式：`DateParticipants()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Participants = DateParticipants()`
- `NationalSpire.CareerScreen.DateParticipants()`；输入表达式：`DateParticipants()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateParticipants().First`
- `NationalSpire.DateSceneBackgrounds.AutomaticChoices(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneBackground>)`；输入表达式：`DateSceneBackgrounds.AutomaticChoices(_dateBackgrounds)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateSceneBackgrounds.AutomaticChoices(_dateBackgrounds).ToDictionary`
- `NationalSpire.DateSceneRequest.DateSceneRequest()`；输入表达式：`new() { OfferId = _dateOffer, OutfitId = _dateAssets!.OutfitId, Opening = opening, Participants = DateParticipants(), DefaultEmotionId = _dateDesign!.DefaultEmotionId, Emotions = DateParticipants().First(p => p.PersonId == _datePerson).Emotions, GameInvitation = PrivateAttachments.Any(a => a.Kind == DateGames.AttachmentKind), Backgrounds = DateSceneBackgrounds.AutomaticChoices(_dateBackgrounds).ToDictionary(b => b.Id, b => b.Description), CurrentBackground = _dateBackground }`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new() { OfferId = _dateOffer, OutfitId = _dateAssets!.OutfitId, Opening = opening, Participants = DateParticipants(), DefaultEmotionId = _dateDesign!.DefaultEmotionId, Emotions = DateParticipants().First(p => p.PersonId == _datePerson).Emotions, GameInvitation = PrivateAttachments.Any(a => a.Kind == DateGames.AttachmentKind), Backgrounds = DateSceneBackgrounds.AutomaticChoices(_dateBackgrounds).ToDictionary(b => b.Id, b => b.Description), CurrentBackground = _dateBackground }`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateAttachments.Any(a => a.Kind == DateGames.AttachmentKind)`；返回值紧邻使用处：`AssignmentExpressionSyntax: GameInvitation = PrivateAttachments.Any(a => a.Kind == DateGames.AttachmentKind)`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`DateParticipants().First(p => p.PersonId == _datePerson)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateParticipants().First(p => p.PersonId == _datePerson).Emotions`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`DateSceneBackgrounds.AutomaticChoices(_dateBackgrounds).ToDictionary(b => b.Id, b => b.Description)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Backgrounds = DateSceneBackgrounds.AutomaticChoices(_dateBackgrounds).ToDictionary(b => b.Id, b => b.Description)`

**赋值（含属性/字段和局部值）：**

- `Backgrounds` = `DateSceneBackgrounds.AutomaticChoices(_dateBackgrounds).ToDictionary(b => b.Id, b => b.Description)`
- `CurrentBackground` = `_dateBackground`
- `DefaultEmotionId` = `_dateDesign!.DefaultEmotionId`
- `Emotions` = `DateParticipants().First(p => p.PersonId == _datePerson).Emotions`
- `GameInvitation` = `PrivateAttachments.Any(a => a.Kind == DateGames.AttachmentKind)`
- `OfferId` = `_dateOffer`
- `Opening` = `opening`
- `OutfitId` = `_dateAssets!.OutfitId`
- `Participants` = `DateParticipants()`

<a id="symbol-bb8a80d5df80"></a>

## `NationalSpire.CareerScreen.OpenDateScene(string, bool, bool) — private void OpenDateScene(string offer, bool inputOnly = false, bool deferReply = false)`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPausedDateScenes(NationalSpire.CareerData, NationalSpire.PrivateConversation)`](DateSceneScreen.cs.md#symbol-a5b10d9fb0b8)；[`NationalSpire.CareerScreen.GroupOffer(NationalSpire.GroupChat, NationalSpire.GroupEffect, NationalSpire.PrivateOffer)`](GroupChatScreen.cs.md#symbol-3afa41099b93)；[`NationalSpire.CareerScreen.PromptDateScene(string)`](DateSceneScreen.cs.md#symbol-d6c92b4f494c)；[`NationalSpire.CareerScreen.ReturnFromDatePhone()`](DateGameScreen.cs.md#symbol-006d35effe08)

**调用：** [`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`；输入表达式：`OpenDateSceneReady(offer, inputOnly, deferReply, null)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => OpenDateSceneReady(offer, inputOnly, deferReply, null)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-bf30200a2448"></a>

## `NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?) — private void OpenDateSceneReady(string offer, bool inputOnly, bool deferReply, Action? ready)`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenDateScene(string, bool, bool)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)；[`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)；[`NationalSpire.CareerScreen.OpenRunDate(MegaCrit.Sts2.Core.Nodes.NRun, NationalSpire.CareerMatch, System.Action, bool)`](DateGameScreen.cs.md#symbol-c74330b4dd26)；[`NationalSpire.CareerScreen.ReturnToDate(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu)`](DateGameReturn.cs.md#symbol-f14ac682e7c3)

**调用：** `Godot.CanvasItem.Hide()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；[`NationalSpire.AffectionArt.Texture(string)`](AffectionVisuals.cs.md#symbol-966474984d6a)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerScreen.AddDateGameActions()`](DateGameScreen.cs.md#symbol-fdf5726e3b97)；[`NationalSpire.CareerScreen.ApplyDatePortraitPlacements()`](DateScenePortraitSettings.cs.md#symbol-9e6a2d77a042)；[`NationalSpire.CareerScreen.BeginDateMemory(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](DateSceneMemoryScreen.cs.md#symbol-e0190873cf74)；[`NationalSpire.CareerScreen.CloseDateScene()`](DateSceneScreen.cs.md#symbol-375f9bc3e86a)；[`NationalSpire.CareerScreen.ConfigureDatePresentation(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>, System.Action, System.Action, bool)`](DatePresentationScreen.cs.md#symbol-ae7a16c86641)；[`NationalSpire.CareerScreen.ConfigureModelPermission(Godot.Button)`](ChatUtilitiesScreen.cs.md#symbol-c65a765f7f74)；[`NationalSpire.CareerScreen.DateParticipants()`](DateScenePartyScreen.cs.md#symbol-658316b8bf70)；[`NationalSpire.CareerScreen.DeleteDateHistoryReply(string, string, string, NationalSpire.DateSceneMemory?, System.Action?)`](DateSceneHistoryScreen.cs.md#symbol-aab4554aa037)；[`NationalSpire.CareerScreen.LoadDateParty(NationalSpire.CareerData, string, string)`](DateScenePartyScreen.cs.md#symbol-e7d1a77e170a)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)；[`NationalSpire.CareerScreen.PartyTexture(string, string)`](DateScenePartyScreen.cs.md#symbol-53bfcf8e2a43)；[`NationalSpire.CareerScreen.PartyWaitingTextures(string)`](DateScenePartyScreen.cs.md#symbol-44daf22689a3)；[`NationalSpire.CareerScreen.PrivateActions()`](PrivateMessageScreen.cs.md#symbol-6e8c11ead905)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.SceneRequest(bool)`](DateSceneScreen.cs.md#symbol-277baf4e7cb8)；[`NationalSpire.CareerScreen.ShowChatModelPicker(Godot.Button, string)`](ChatUtilitiesScreen.cs.md#symbol-cc67f52fc948)；[`NationalSpire.CareerScreen.ShowDateInput(bool, bool)`](DateGameScreen.cs.md#symbol-f7a3691c9897)；[`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)；[`NationalSpire.DateSceneAssetStore.Hash(byte[])`](DateSceneAssets.cs.md#symbol-e8871d339d39)；[`NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`](DateSceneAssets.cs.md#symbol-57fe620f4cc9)；[`NationalSpire.DateSceneBackgrounds.Read(out string, string?)`](DateSceneBackgrounds.cs.md#symbol-b6c3bc7d87d9)；[`NationalSpire.DateSceneBackgrounds.RegisterLegacy(string)`](DateSceneBackgrounds.cs.md#symbol-7feab11c4c5b)；`NationalSpire.DateSceneBookmark.DateSceneBookmark()`；`NationalSpire.DateSceneCast.DateSceneCast(string, string, System.Func<Godot.Texture2D>)`；[`NationalSpire.DateSceneParty.People(NationalSpire.CareerData, NationalSpire.PrivateOffer, string)`](DateSceneParty.cs.md#symbol-f9cb6b2133b0)；`NationalSpire.DateSceneRequest.DateSceneRequest()`；[`NationalSpire.DateSceneView.AddInputAction(string, Godot.Texture2D, System.Action, string)`](DateSceneView.cs.md#symbol-0d0da39d688e)；[`NationalSpire.DateSceneView.AffectionVisibility(bool)`](DateSceneView.cs.md#symbol-7da14922fda4)；[`NationalSpire.DateSceneView.Background(string, bool, double)`](DateSceneView.cs.md#symbol-9c58edcaf529)；`NationalSpire.DateSceneView.DateSceneView()`；[`NationalSpire.DateSceneView.Preferences(int, double, double)`](DateSceneView.cs.md#symbol-878552c24bd8)；[`NationalSpire.DateSceneView.Presentation(double, double, double, bool)`](DateSceneView.cs.md#symbol-32ea38e8c82d)；[`NationalSpire.DateSceneView.SetCast(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneCast>)`](DateSceneCast.cs.md#symbol-913514fd78e1)；[`NationalSpire.DateSceneView.ShowWaiting(string, bool)`](DateSceneView.cs.md#symbol-c6c25a66fde3)；[`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`](DateSceneData.cs.md#symbol-0d3e014bcb63)；[`NationalSpire.DateScenes.History(NationalSpire.PrivateConversation, string, string, int, string, string)`](DateSceneData.cs.md#symbol-13e129fe5e9e)；[`NationalSpire.DateScenes.HistoryEntries(NationalSpire.PrivateConversation, string, string, int, string, string)`](DateSceneData.cs.md#symbol-e8fbec0a77e3)；[`NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`](DateSceneData.cs.md#symbol-801111e76ca9)；[`NationalSpire.DateScenes.Validate(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest, bool)`](DateSceneData.cs.md#symbol-190a72e967ad)；[`NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`](PortraitDesignStore.cs.md#symbol-8db102d73ed8)；[`NationalSpire.PortraitDesignStore.Key(NationalSpire.CareerData, string)`](PortraitDesignStore.cs.md#symbol-2ed1ee155b2d)；[`NationalSpire.PortraitDesignStore.Read(string, string)`](PortraitDesignStore.cs.md#symbol-2eeba99f517d)；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`System.Action.Invoke()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.InvalidOperationException.InvalidOperationException(string?)`；`System.Text.Encoding.GetBytes(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.AffectionArt.Texture(string)`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.AddDateGameActions()`；`NationalSpire.CareerScreen.AdvanceDateScene()`；`NationalSpire.CareerScreen.ApplyDatePortraitPlacements()`；`NationalSpire.CareerScreen.BeginDateMemory(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.CareerScreen.ChatModelPickerOpen`；`NationalSpire.CareerScreen.CloseDateScene()`；`NationalSpire.CareerScreen.ConfigureDatePresentation(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>, System.Action, System.Action, bool)`；`NationalSpire.CareerScreen.ConfigureModelPermission(Godot.Button)`；`NationalSpire.CareerScreen.DateParticipants()`；`NationalSpire.CareerScreen.DateSceneExitChoices()`；`NationalSpire.CareerScreen.DateSceneSettings()`；`NationalSpire.CareerScreen.DeleteDateHistoryReply(string, string, string, NationalSpire.DateSceneMemory?, System.Action?)`；`NationalSpire.CareerScreen.EditPreviousDateScene()`；`NationalSpire.CareerScreen.LoadDateParty(NationalSpire.CareerData, string, string)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`；`NationalSpire.CareerScreen.PartyTexture(string, string)`；`NationalSpire.CareerScreen.PartyWaitingTextures(string)`；`NationalSpire.CareerScreen.PrivateActions()`；`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；`NationalSpire.CareerScreen.SceneRequest(bool)`；`NationalSpire.CareerScreen.SendDateScene()`；`NationalSpire.CareerScreen.ShowChatModelPicker(Godot.Button, string)`；`NationalSpire.CareerScreen.ShowDateInput(bool, bool)`；`NationalSpire.CareerScreen.TickDateScene()`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._dateAssets`；`NationalSpire.CareerScreen._dateAttachments`；`NationalSpire.CareerScreen._dateBackground`；`NationalSpire.CareerScreen._dateBackgrounds`；`NationalSpire.CareerScreen._dateDesign`；`NationalSpire.CareerScreen._dateEditingTurn`；`NationalSpire.CareerScreen._dateIndex`；`NationalSpire.CareerScreen._dateInitialBackground`；`NationalSpire.CareerScreen._dateInputTurn`；`NationalSpire.CareerScreen._dateKey`；`NationalSpire.CareerScreen._dateLines`；`NationalSpire.CareerScreen._dateManualGameInput`；`NationalSpire.CareerScreen._dateMemory`；`NationalSpire.CareerScreen._dateOffer`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateReply`；`NationalSpire.CareerScreen._dateSource`；`NationalSpire.CareerScreen._dateState`；`NationalSpire.CareerScreen._dateTurn`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen._privateInput`；`NationalSpire.CareerScreen._privateOverlay`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen._stage`；`NationalSpire.DateSceneAssetStore.Hash(byte[])`；`NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`；`NationalSpire.DateSceneAssets.Background`；`NationalSpire.DateSceneAssets.BlurAmount`；`NationalSpire.DateSceneAssets.Bookmarks`；`NationalSpire.DateSceneAssets.FontSize`；`NationalSpire.DateSceneAssets.LetterSpacing`；`NationalSpire.DateSceneAssets.OutfitId`；`NationalSpire.DateSceneAssets.PanelFade`；`NationalSpire.DateSceneAssets.ShowAffectionBadge`；`NationalSpire.DateSceneAssets.TextOutline`；`NationalSpire.DateSceneAssets.TextSpeed`；`NationalSpire.DateSceneBackground.Id`；`NationalSpire.DateSceneBackground.Image`；`NationalSpire.DateSceneBackgrounds.Read(out string, string?)`；`NationalSpire.DateSceneBackgrounds.RegisterLegacy(string)`；`NationalSpire.DateSceneBookmark.Index`；`NationalSpire.DateSceneBookmark.ReplyHash`；`NationalSpire.DateSceneBookmark.Turn`；`NationalSpire.DateSceneParticipant.DefaultEmotionId`；`NationalSpire.DateSceneParticipant.Name`；`NationalSpire.DateSceneParticipant.PersonId`；`NationalSpire.DateSceneParty.People(NationalSpire.CareerData, NationalSpire.PrivateOffer, string)`；`NationalSpire.DateSceneRequest.DefaultEmotionId`；`NationalSpire.DateSceneRequest.Emotions`；`NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.DateSceneRequest.OutfitId`；`NationalSpire.DateSceneRequest.Participants`；`NationalSpire.DateSceneView.AddAttachment`；`NationalSpire.DateSceneView.AddInputAction(string, Godot.Texture2D, System.Action, string)`；`NationalSpire.DateSceneView.Advance`；`NationalSpire.DateSceneView.AffectionVisibility(bool)`；`NationalSpire.DateSceneView.Background(string, bool, double)`；`NationalSpire.DateSceneView.Blocked`；`NationalSpire.DateSceneView.DeleteHistoryReply`；`NationalSpire.DateSceneView.EditPrevious`；`NationalSpire.DateSceneView.Editor`；`NationalSpire.DateSceneView.Exit`；`NationalSpire.DateSceneView.HistoryEntries`；`NationalSpire.DateSceneView.HistoryText`；`NationalSpire.DateSceneView.Preferences(int, double, double)`；`NationalSpire.DateSceneView.Presentation(double, double, double, bool)`；`NationalSpire.DateSceneView.RetryStop`；`NationalSpire.DateSceneView.ReturnToEdit`；`NationalSpire.DateSceneView.SetCast(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneCast>)`；`NationalSpire.DateSceneView.Settings`；`NationalSpire.DateSceneView.ShowWaiting(string, bool)`；`NationalSpire.DateSceneView.Status`；`NationalSpire.DateSceneView.Submit`；`NationalSpire.DateSceneView.TextSpeed`；`NationalSpire.DateSceneView.Tick`；`NationalSpire.DateSceneView.WaitingDefault`；`NationalSpire.DateSceneView.WaitingPortraits`；`NationalSpire.DateSceneView.WaitingSprites`；`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；`NationalSpire.DateScenes.History(NationalSpire.PrivateConversation, string, string, int, string, string)`；`NationalSpire.DateScenes.HistoryEntries(NationalSpire.PrivateConversation, string, string, int, string, string)`；`NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`；`NationalSpire.DateScenes.Validate(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest, bool)`；`NationalSpire.PortraitDesign.DefaultEmotionId`；`NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`；`NationalSpire.PortraitDesignStore.Key(NationalSpire.CareerData, string)`；`NationalSpire.PortraitDesignStore.Read(string, string)`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMessageCommand.Scene`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.PrivateTurn.Reply`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.Scene`；`NationalSpire.PrivateTurn.Status`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`.Hide()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _privateOverlay?.Hide()`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`view.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: view.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_privateInput)`；返回值紧邻使用处：`BinaryExpressionSyntax: _privateInput != null && IsInstanceValid(_privateInput)`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_stage.AddChild(view)`；返回值紧邻使用处：`ExpressionStatementSyntax: _stage.AddChild(view);`
- `NationalSpire.AffectionArt.Texture(string)`；输入表达式：`AffectionArt.Texture("chat-model")`；返回值紧邻使用处：`ArgumentSyntax: AffectionArt.Texture("chat-model")`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(ViewData, _datePerson)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.DisplayName(ViewData, _datePerson)`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(ViewData)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.Name(ViewData)`
- `NationalSpire.CareerScreen.AddDateGameActions()`；输入表达式：`AddDateGameActions()`；返回值紧邻使用处：`ExpressionStatementSyntax: AddDateGameActions();`
- `NationalSpire.CareerScreen.ApplyDatePortraitPlacements()`；输入表达式：`ApplyDatePortraitPlacements()`；返回值紧邻使用处：`ExpressionStatementSyntax: ApplyDatePortraitPlacements();`
- `NationalSpire.CareerScreen.BeginDateMemory(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`BeginDateMemory(data, appointment)`；返回值紧邻使用处：`ExpressionStatementSyntax: BeginDateMemory(data, appointment);`
- `NationalSpire.CareerScreen.CloseDateScene()`；输入表达式：`CloseDateScene()`；返回值紧邻使用处：`ExpressionStatementSyntax: CloseDateScene();`
- `NationalSpire.CareerScreen.ConfigureDatePresentation(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>, System.Action, System.Action, bool)`；输入表达式：`ConfigureDatePresentation(data, DateSceneParty.People(data, appointment, person), () => { if (_privatePerson == person) OpenDateSceneReady(offer, inputOnly, deferReply, ready); else CloseDateScene(); }, CloseDateScene)`；返回值紧邻使用处：`IfStatementSyntax: if (ConfigureDatePresentation(data, DateSceneParty.People(data, appointment, person), () => { if (_privatePerson == person) OpenDateSceneReady(offer, inputOnly, deferReply, ready); else CloseDateScene(); }, CloseDateScene)) return;`
- `NationalSpire.CareerScreen.ConfigureModelPermission(Godot.Button)`；输入表达式：`ConfigureModelPermission(modelButton)`；返回值紧邻使用处：`ExpressionStatementSyntax: ConfigureModelPermission(modelButton);`
- `NationalSpire.CareerScreen.DateParticipants()`；输入表达式：`DateParticipants()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Participants = DateParticipants()`
- `NationalSpire.CareerScreen.DateParticipants()`；输入表达式：`DateParticipants()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateParticipants().Select`
- `NationalSpire.CareerScreen.DeleteDateHistoryReply(string, string, string, NationalSpire.DateSceneMemory?, System.Action?)`；输入表达式：`DeleteDateHistoryReply(_datePerson, _dateOffer, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => DeleteDateHistoryReply(_datePerson, _dateOffer, id)`
- `NationalSpire.CareerScreen.LoadDateParty(NationalSpire.CareerData, string, string)`；输入表达式：`LoadDateParty(data, person, offer)`；返回值紧邻使用处：`ExpressionStatementSyntax: LoadDateParty(data, person, offer);`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("打开约会场景失败：" + e.Message, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("打开约会场景失败：" + e.Message, true);`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("本次修订保留原消息附件；新附件可在下一轮添加。", false)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("本次修订保留原消息附件；新附件可在下一轮添加。", false);`
- `NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`；输入表达式：`OpenDateSceneReady(offer, inputOnly, deferReply, ready)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenDateSceneReady(offer, inputOnly, deferReply, ready);`
- `NationalSpire.CareerScreen.PartyTexture(string, string)`；输入表达式：`PartyTexture(p.PersonId, p.DefaultEmotionId)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => PartyTexture(p.PersonId, p.DefaultEmotionId)`
- `NationalSpire.CareerScreen.PartyTexture(string, string)`；输入表达式：`PartyTexture(person, _dateDesign.DefaultEmotionId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PartyTexture(person, _dateDesign.DefaultEmotionId)`
- `NationalSpire.CareerScreen.PartyWaitingTextures(string)`；输入表达式：`PartyWaitingTextures(person.Length > 0 ? person : _datePerson)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: person => PartyWaitingTextures(person.Length > 0 ? person : _datePerson)`
- `NationalSpire.CareerScreen.PrivateActions()`；输入表达式：`PrivateActions()`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateActions();`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；输入表达式：`PrivateCommand("dm-date-open", new() { Scene = SceneRequest(true) })`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateCommand("dm-date-open", new() { Scene = SceneRequest(true) });`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；输入表达式：`PrivateCommand(PrivateMessages.Conversation(ViewData, _datePerson).Turns.Any(t => t.Status is "queued" or "sending") ? "dm-stop" : "dm-retry", new())`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => PrivateCommand(PrivateMessages.Conversation(ViewData, _datePerson).Turns.Any(t => t.Status is "queued" or "sending") ? "dm-stop" : "dm-retry", new())`
- `NationalSpire.CareerScreen.SceneRequest(bool)`；输入表达式：`SceneRequest(true)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Scene = SceneRequest(true)`
- `NationalSpire.CareerScreen.ShowChatModelPicker(Godot.Button, string)`；输入表达式：`ShowChatModelPicker(modelButton!, "private")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ShowChatModelPicker(modelButton!, "private")`
- `NationalSpire.CareerScreen.ShowDateInput(bool, bool)`；输入表达式：`ShowDateInput(manualGame: true)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowDateInput(manualGame: true);`
- `NationalSpire.CareerScreen.TickDateScene()`；输入表达式：`TickDateScene()`；返回值紧邻使用处：`ExpressionStatementSyntax: TickDateScene();`
- `NationalSpire.DateSceneAssetStore.Hash(byte[])`；输入表达式：`DateSceneAssetStore.Hash(Encoding.UTF8.GetBytes(latest.Reply))`；返回值紧邻使用处：`AssignmentExpressionSyntax: ReplyHash = DateSceneAssetStore.Hash(Encoding.UTF8.GetBytes(latest.Reply))`
- `NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`；输入表达式：`DateSceneAssetStore.Read(data, person)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dateAssets = DateSceneAssetStore.Read(data, person)`
- `NationalSpire.DateSceneBackgrounds.Read(out string, string?)`；输入表达式：`DateSceneBackgrounds.Read(out string backgroundWarning)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dateBackgrounds = DateSceneBackgrounds.Read(out string backgroundWarning)`
- `NationalSpire.DateSceneBackgrounds.RegisterLegacy(string)`；输入表达式：`DateSceneBackgrounds.RegisterLegacy(_dateAssets.Background)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dateAssets.Background = DateSceneBackgrounds.RegisterLegacy(_dateAssets.Background)`
- `NationalSpire.DateSceneBookmark.DateSceneBookmark()`；输入表达式：`new() { Turn = latest.Id, ReplyHash = DateSceneAssetStore.Hash(Encoding.UTF8.GetBytes(latest.Reply)), Index = DateScenes.Lines(latest).Count }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dateAssets.Bookmarks[offer] = new() { Turn = latest.Id, ReplyHash = DateSceneAssetStore.Hash(Encoding.UTF8.GetBytes(latest.Reply)), Index = DateScenes.Lines(latest).Count }`
- `NationalSpire.DateSceneCast.DateSceneCast(string, string, System.Func<Godot.Texture2D>)`；输入表达式：`new DateSceneCast(p.PersonId, p.Name, () => PartyTexture(p.PersonId, p.DefaultEmotionId))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => new DateSceneCast(p.PersonId, p.Name, () => PartyTexture(p.PersonId, p.DefaultEmotionId))`
- `NationalSpire.DateSceneParty.People(NationalSpire.CareerData, NationalSpire.PrivateOffer, string)`；输入表达式：`DateSceneParty.People(data, appointment, person)`；返回值紧邻使用处：`ArgumentSyntax: DateSceneParty.People(data, appointment, person)`
- `NationalSpire.DateSceneRequest.DateSceneRequest()`；输入表达式：`new DateSceneRequest { Participants = DateParticipants(), OfferId = offer, OutfitId = _dateAssets.OutfitId, DefaultEmotionId = _dateDesign!.DefaultEmotionId, Emotions = new() { [_dateDesign.DefaultEmotionId] = "默认" } }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new DateSceneRequest { Participants = DateParticipants(), OfferId = offer, OutfitId = _dateAssets.OutfitId, DefaultEmotionId = _dateDesign!.DefaultEmotionId, Emotions = new() { [_dateDesign.DefaultEmotionId] = "默认" } }`
- `NationalSpire.DateSceneView.AddInputAction(string, Godot.Texture2D, System.Action, string)`；输入表达式：`view.AddInputAction("DateModelButton", AffectionArt.Texture("chat-model"), () => ShowChatModelPicker(modelButton!, "private"), "切换私聊和约会使用的模型方案")`；返回值紧邻使用处：`AssignmentExpressionSyntax: modelButton = view.AddInputAction("DateModelButton", AffectionArt.Texture("chat-model"), () => ShowChatModelPicker(modelButton!, "private"), "切换私聊和约会使用的模型方案")`
- `NationalSpire.DateSceneView.AffectionVisibility(bool)`；输入表达式：`view.AffectionVisibility(_dateAssets.ShowAffectionBadge)`；返回值紧邻使用处：`ExpressionStatementSyntax: view.AffectionVisibility(_dateAssets.ShowAffectionBadge);`
- `NationalSpire.DateSceneView.Background(string, bool, double)`；输入表达式：`view.Background(_dateBackgrounds.FirstOrDefault(b => b.Id == _dateBackground)?.Image ?? "", true, _dateAssets.BlurAmount)`；返回值紧邻使用处：`ExpressionStatementSyntax: view.Background(_dateBackgrounds.FirstOrDefault(b => b.Id == _dateBackground)?.Image ?? "", true, _dateAssets.BlurAmount);`
- `NationalSpire.DateSceneView.DateSceneView()`；输入表达式：`new DateSceneView { TextSpeed = _dateAssets.TextSpeed, WaitingSprites = [initialTexture], WaitingDefault = initialTexture }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new DateSceneView { TextSpeed = _dateAssets.TextSpeed, WaitingSprites = [initialTexture], WaitingDefault = initialTexture }`
- `NationalSpire.DateSceneView.Preferences(int, double, double)`；输入表达式：`view.Preferences(_dateAssets.FontSize, _dateAssets.PanelFade, _dateAssets.LetterSpacing)`；返回值紧邻使用处：`ExpressionStatementSyntax: view.Preferences(_dateAssets.FontSize, _dateAssets.PanelFade, _dateAssets.LetterSpacing);`
- `NationalSpire.DateSceneView.Presentation(double, double, double, bool)`；输入表达式：`view.Presentation(1, 0, 0, _dateAssets.TextOutline)`；返回值紧邻使用处：`ExpressionStatementSyntax: view.Presentation(1, 0, 0, _dateAssets.TextOutline);`
- `NationalSpire.DateSceneView.SetCast(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneCast>)`；输入表达式：`view.SetCast(DateParticipants().Select(p => new DateSceneCast(p.PersonId, p.Name, () => PartyTexture(p.PersonId, p.DefaultEmotionId))))`；返回值紧邻使用处：`ExpressionStatementSyntax: view.SetCast(DateParticipants().Select(p => new DateSceneCast(p.PersonId, p.Name, () => PartyTexture(p.PersonId, p.DefaultEmotionId))));`
- `NationalSpire.DateSceneView.ShowWaiting(string, bool)`；输入表达式：`view.ShowWaiting("正在根据对局进程继续对话…", false)`；返回值紧邻使用处：`ExpressionStatementSyntax: view.ShowWaiting("正在根据对局进程继续对话…", false);`
- `NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；输入表达式：`DateScenes.Available(data, appointment, PrivateMessages.Conversation(data, person))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !DateScenes.Available(data, appointment, PrivateMessages.Conversation(data, person))`
- `NationalSpire.DateScenes.History(NationalSpire.PrivateConversation, string, string, int, string, string)`；输入表达式：`DateScenes.History(PrivateMessages.Conversation(ViewData, _datePerson), _dateOffer, _dateState == "complete" ? _dateTurn : "", _dateIndex, CareerEngine.Name(ViewData), CareerEngine.DisplayName(ViewData, _datePerson))`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => DateScenes.History(PrivateMessages.Conversation(ViewData, _datePerson), _dateOffer, _dateState == "complete" ? _dateTurn : "", _dateIndex, CareerEngine.Name(ViewData), CareerEngine.DisplayName(ViewData, _datePerson))`
- `NationalSpire.DateScenes.HistoryEntries(NationalSpire.PrivateConversation, string, string, int, string, string)`；输入表达式：`DateScenes.HistoryEntries(PrivateMessages.Conversation(ViewData, _datePerson), _dateOffer, _dateState == "complete" ? _dateTurn : "", _dateIndex, CareerEngine.Name(ViewData), CareerEngine.DisplayName(ViewData, _datePerson))`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => DateScenes.HistoryEntries(PrivateMessages.Conversation(ViewData, _datePerson), _dateOffer, _dateState == "complete" ? _dateTurn : "", _dateIndex, CareerEngine.Name(ViewData), CareerEngine.DisplayName(ViewData, _datePerson))`
- `NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`；输入表达式：`DateScenes.Lines(latest)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateScenes.Lines(latest).Count`
- `NationalSpire.DateScenes.Validate(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest, bool)`；输入表达式：`DateScenes.Validate(data, PrivateMessages.Conversation(data, person), check)`；返回值紧邻使用处：`IsPatternExpressionSyntax: DateScenes.Validate(data, PrivateMessages.Conversation(data, person), check) is { } error`
- `NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`；输入表达式：`PortraitDesignStore.FilePath(data, person)`；返回值紧邻使用处：`ArgumentSyntax: PortraitDesignStore.FilePath(data, person)`
- `NationalSpire.PortraitDesignStore.Key(NationalSpire.CareerData, string)`；输入表达式：`PortraitDesignStore.Key(data, person)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dateKey = PortraitDesignStore.Key(data, person)`
- `NationalSpire.PortraitDesignStore.Read(string, string)`；输入表达式：`PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dateDesign = PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person)`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new()`；返回值紧邻使用处：`ArgumentSyntax: new()`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Scene = SceneRequest(true) }`；返回值紧邻使用处：`ArgumentSyntax: new() { Scene = SceneRequest(true) }`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(ViewData, _datePerson)`；返回值紧邻使用处：`ArgumentSyntax: PrivateMessages.Conversation(ViewData, _datePerson)`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(ViewData, _datePerson)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Conversation(ViewData, _datePerson).Turns`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, person)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Conversation(data, person).Offers`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, person)`；返回值紧邻使用处：`ArgumentSyntax: PrivateMessages.Conversation(data, person)`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(data, person)`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: ready?.Invoke()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new() { [_dateDesign.DefaultEmotionId] = "默认" }`；返回值紧邻使用处：`AssignmentExpressionSyntax: Emotions = new() { [_dateDesign.DefaultEmotionId] = "默认" }`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`_dateAssets.Background.All(char.IsAsciiHexDigit)`；返回值紧邻使用处：`BinaryExpressionSyntax: _dateAssets.Background.Length == 64 && _dateAssets.Background.All(char.IsAsciiHexDigit)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateMessages.Conversation(ViewData, _datePerson).Turns.Any(t => t.Status is "queued" or "sending")`；返回值紧邻使用处：`ConditionalExpressionSyntax: PrivateMessages.Conversation(ViewData, _datePerson).Turns.Any(t => t.Status is "queued" or "sending") ? "dm-stop" : "dm-retry"`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`_dateBackgrounds.Any(b => b.Id == _dateAssets.Background)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _dateBackgrounds.Any(b => b.Id == _dateAssets.Background) ? _dateAssets.Background : ""`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.Any(t => t.Scene?.OfferId == offer && !t.ReplyDeleted)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !c.Turns.Any(t => t.Scene?.OfferId == offer && !t.ReplyDeleted)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateMessages.Conversation(data, person).Offers.FirstOrDefault(o => o.Id == offer)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(data, person).Offers.FirstOrDefault(o => o.Id == offer)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`_dateBackgrounds.FirstOrDefault(b => b.Id == _dateBackground)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _dateBackgrounds.FirstOrDefault(b => b.Id == _dateBackground)?.Image`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.LastOrDefault(t => t.Scene?.OfferId == offer && !t.ReplyDeleted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Turns.LastOrDefault(t => t.Scene?.OfferId == offer && !t.ReplyDeleted)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`DateParticipants().Select(p => new DateSceneCast(p.PersonId, p.Name, () => PartyTexture(p.PersonId, p.DefaultEmotionId)))`；返回值紧邻使用处：`ArgumentSyntax: DateParticipants().Select(p => new DateSceneCast(p.PersonId, p.Name, () => PartyTexture(p.PersonId, p.DefaultEmotionId)))`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("这项约会已结束或尚未赴约。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("这项约会已结束或尚未赴约。");`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException(error)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException(error);`
- `System.Text.Encoding.GetBytes(string)`；输入表达式：`Encoding.UTF8.GetBytes(latest.Reply)`；返回值紧邻使用处：`ArgumentSyntax: Encoding.UTF8.GetBytes(latest.Reply)`

**赋值（含属性/字段和局部值）：**

- `DefaultEmotionId` = `_dateDesign!.DefaultEmotionId`
- `Emotions` = `new() { [_dateDesign.DefaultEmotionId] = "默认" }`
- `Index` = `DateScenes.Lines(latest).Count`
- `OfferId` = `offer`
- `OutfitId` = `_dateAssets.OutfitId`
- `Participants` = `DateParticipants()`
- `ReplyHash` = `DateSceneAssetStore.Hash(Encoding.UTF8.GetBytes(latest.Reply))`
- `Scene` = `SceneRequest(true)`
- `TextSpeed` = `_dateAssets.TextSpeed`
- `Turn` = `latest.Id`
- `WaitingDefault` = `initialTexture`
- `WaitingSprites` = `[initialTexture]`
- `[_dateDesign.DefaultEmotionId]` = `"默认"`
- `_dateAssets.Background` = `""`
- `_dateAssets.Background` = `DateSceneBackgrounds.RegisterLegacy(_dateAssets.Background)`
- `_dateAssets.Bookmarks[offer]` = `new() { Turn = latest.Id, ReplyHash = DateSceneAssetStore.Hash(Encoding.UTF8.GetBytes(latest.Reply)), Index = DateScenes.Lines(latest).Count }`
- `_dateAssets` = `DateSceneAssetStore.Read(data, person)`
- `_dateAttachments` = `_dateSource = ""`
- `_dateBackground` = `_dateInitialBackground = _dateBackgrounds.Any(b => b.Id == _dateAssets.Background) ? _dateAssets.Background : ""`
- `_dateBackgrounds` = `DateSceneBackgrounds.Read(out string backgroundWarning)`
- `_dateDesign` = `PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person)`
- `_dateEditingTurn` = `""`
- `_dateIndex` = `0`
- `_dateInitialBackground` = `_dateBackgrounds.Any(b => b.Id == _dateAssets.Background) ? _dateAssets.Background : ""`
- `_dateInputTurn` = `""`
- `_dateKey` = `PortraitDesignStore.Key(data, person)`
- `_dateLines` = `[]`
- `_dateManualGameInput` = `inputOnly`
- `_dateMemory` = `null`
- `_dateOffer` = `offer`
- `_datePerson` = `person`
- `_dateReply` = `_dateState = _dateAttachments = _dateSource = ""`
- `_dateSource` = `""`
- `_dateState` = `_dateAttachments = _dateSource = ""`
- `_dateTurn` = `_dateReply = _dateState = _dateAttachments = _dateSource = ""`
- `_dateView` = `view`
- `_privateInput.Text` = `view.Editor.Text`
- `modelButton` = `view.AddInputAction("DateModelButton", AffectionArt.Texture("chat-model"), () => ShowChatModelPicker(modelButton!, "private"), "切换私聊和约会使用的模型方案")`
- `view.AddAttachment` = `() => { if (_dateEditingTurn.Length == 0) PrivateActions(); else Notice("本次修订保留原消息附件；新附件可在下一轮添加。", false); }`
- `view.Advance` = `AdvanceDateScene`
- `view.Blocked` = `() => _dialogOverlay != null || ChatModelPickerOpen`
- `view.DeleteHistoryReply` = `id => DeleteDateHistoryReply(_datePerson, _dateOffer, id)`
- `view.EditPrevious` = `EditPreviousDateScene`
- `view.Editor.TextChanged` += `() => { if (_privateInput != null && IsInstanceValid(_privateInput)) _privateInput.Text = view.Editor.Text; }`
- `view.Editor.Text` = `_privateInput!.Text`
- `view.Exit` = `DateSceneExitChoices`
- `view.HistoryEntries` = `() => DateScenes.HistoryEntries(PrivateMessages.Conversation(ViewData, _datePerson), _dateOffer, _dateState == "complete" ? _dateTurn : "", _dateIndex, CareerEngine.Name(ViewData), CareerEngine.DisplayName(ViewData, _datePerson))`
- `view.HistoryText` = `() => DateScenes.History(PrivateMessages.Conversation(ViewData, _datePerson), _dateOffer, _dateState == "complete" ? _dateTurn : "", _dateIndex, CareerEngine.Name(ViewData), CareerEngine.DisplayName(ViewData, _datePerson))`
- `view.RetryStop` = `() => PrivateCommand(PrivateMessages.Conversation(ViewData, _datePerson).Turns.Any(t => t.Status is "queued" or "sending") ? "dm-stop" : "dm-retry", new())`
- `view.ReturnToEdit` = `EditPreviousDateScene`
- `view.Settings` = `DateSceneSettings`
- `view.Status.Text` = `"回忆记录准备失败：" + e.Message`
- `view.Status.Text` = `backgroundWarning`
- `view.Submit` = `SendDateScene`
- `view.Tick` = `TickDateScene`
- `view.WaitingPortraits` = `person => PartyWaitingTextures(person.Length > 0 ? person : _datePerson)`

<a id="symbol-375f9bc3e86a"></a>

## `NationalSpire.CareerScreen.CloseDateScene() — private void CloseDateScene()`

来源：源码第 111 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen._ExitTree()`](CareerScreen.cs.md#symbol-5aaebf0ee0ab)；[`NationalSpire.CareerScreen.ClosePrivateMessagesCore(bool)`](PrivateMessageScreen.cs.md#symbol-db8b0a9ff8de)；[`NationalSpire.CareerScreen.DatePhone()`](DateGameScreen.cs.md#symbol-91a1fe98cb30)；[`NationalSpire.CareerScreen.LeaveDateScene(bool)`](DateSceneScreen.cs.md#symbol-942f3afae68b)；[`NationalSpire.CareerScreen.OpenDateScene(string, bool, bool)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)；[`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)；[`NationalSpire.CareerScreen.RefreshDateParty()`](DateScenePartyScreen.cs.md#symbol-3918c1aaf95a)；[`NationalSpire.CareerScreen.ResumeDateGame()`](DateGameScreen.cs.md#symbol-fa0cab10e943)；[`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)

**调用：** [`NationalSpire.CareerScreen.Close(bool)`](CareerScreen.cs.md#symbol-9bfd6bc6f6d3)；[`NationalSpire.CareerScreen.ReleaseDateSceneView()`](DateSceneScreen.cs.md#symbol-ea637ecbc4b0)；`System.Action.Invoke()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Close(bool)`；`NationalSpire.CareerScreen.ReleaseDateSceneView()`；`NationalSpire.CareerScreen._dateRunResume`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.Close(bool)`；输入表达式：`Close(force: true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Close(force: true);`
- `NationalSpire.CareerScreen.ReleaseDateSceneView()`；输入表达式：`ReleaseDateSceneView()`；返回值紧邻使用处：`ExpressionStatementSyntax: ReleaseDateSceneView();`
- `System.Action.Invoke()`；输入表达式：`resume()`；返回值紧邻使用处：`ExpressionStatementSyntax: resume();`

**赋值（含属性/字段和局部值）：**

- `_dateRunResume` = `null`

<a id="symbol-ea637ecbc4b0"></a>

## `NationalSpire.CareerScreen.ReleaseDateSceneView() — private void ReleaseDateSceneView()`

来源：源码第 124 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.CloseDateScene()`](DateSceneScreen.cs.md#symbol-375f9bc3e86a)

**调用：** `Godot.CanvasItem.Show()`；`Godot.GodotObject.Dispose()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Node.QueueFree()`；[`NationalSpire.CareerScreen.SaveDateMemory(bool)`](DateSceneMemoryScreen.cs.md#symbol-c76191deb959)；`System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；`System.Collections.Generic.HashSet<T>.Clear()`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.List<T>.Clear()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.SaveDateMemory(bool)`；`NationalSpire.CareerScreen._dateAssets`；`NationalSpire.CareerScreen._dateBackgrounds`；`NationalSpire.CareerScreen._dateDefaultPeople`；`NationalSpire.CareerScreen._dateDesign`；`NationalSpire.CareerScreen._dateGameAction`；`NationalSpire.CareerScreen._dateMissingTextures`；`NationalSpire.CareerScreen._dateOffer`；`NationalSpire.CareerScreen._datePartyArt`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateResumeGame`；`NationalSpire.CareerScreen._dateTextureWarning`；`NationalSpire.CareerScreen._dateTextures`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.CareerScreen._privateDrafts`；`NationalSpire.CareerScreen._privateInput`；`NationalSpire.CareerScreen._privateOverlay`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen._privateSignature`；`NationalSpire.DateSceneView.Editor`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Show()`；输入表达式：`_privateOverlay.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateOverlay.Show();`
- `Godot.GodotObject.Dispose()`；输入表达式：`texture.Dispose()`；返回值紧邻使用处：`ExpressionStatementSyntax: texture.Dispose();`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_dateView)`；返回值紧邻使用处：`BinaryExpressionSyntax: _dateView != null && IsInstanceValid(_dateView)`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_privateInput)`；返回值紧邻使用处：`BinaryExpressionSyntax: _privatePerson == _datePerson && _privateInput != null && IsInstanceValid(_privateInput)`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_privateOverlay)`；返回值紧邻使用处：`BinaryExpressionSyntax: _privateOverlay != null && IsInstanceValid(_privateOverlay)`
- `Godot.Node.QueueFree()`；输入表达式：`_dateView.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.QueueFree();`
- `NationalSpire.CareerScreen.SaveDateMemory(bool)`；输入表达式：`SaveDateMemory()`；返回值紧邻使用处：`ExpressionStatementSyntax: SaveDateMemory();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_datePartyArt.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _datePartyArt.Clear();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_dateTextures.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateTextures.Clear();`
- `System.Collections.Generic.HashSet<T>.Clear()`；输入表达式：`_dateDefaultPeople.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateDefaultPeople.Clear();`
- `System.Collections.Generic.HashSet<T>.Clear()`；输入表达式：`_dateMissingTextures.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateMissingTextures.Clear();`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`_dateTextures.Values.Distinct()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var texture in _dateTextures.Values.Distinct()) texture.Dispose();`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`_dateBackgrounds.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateBackgrounds.Clear();`

**赋值（含属性/字段和局部值）：**

- `_dateAssets` = `null`
- `_dateDesign` = `null`
- `_dateGameAction` = `_dateResumeGame = null`
- `_dateOffer` = `""`
- `_datePerson` = `_dateOffer = ""`
- `_dateResumeGame` = `null`
- `_dateTextureWarning` = `""`
- `_dateView` = `null`
- `_privateDrafts[_datePerson]` = `_dateView.Editor.Text`
- `_privateInput.Text` = `_dateView.Editor.Text`
- `_privateSignature` = `""`

<a id="symbol-52133982acce"></a>

## `NationalSpire.CareerScreen.DateSceneExitChoices() — private void DateSceneExitChoices()`

来源：源码第 141 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen._Input(Godot.InputEvent)`](CareerScreen.cs.md#symbol-a9891646fd75)

**调用：** `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.Control()`；`Godot.Control.GetCombinedMinimumSize()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.FindChild(string, bool, bool)`；`Godot.Node.GetParent()`；`Godot.Node.MoveChild(Godot.Node, int)`；[`NationalSpire.CareerScreen.CanResumeDateGame()`](DateGameScreen.cs.md#symbol-936de630737d)；[`NationalSpire.CareerScreen.LeaveDateScene(bool)`](DateSceneScreen.cs.md#symbol-942f3afae68b)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.ResumeDateGame()`](DateGameScreen.cs.md#symbol-fa0cab10e943)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；`System.Action.Invoke()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.CanResumeDateGame()`；`NationalSpire.CareerScreen.LeaveDateScene(bool)`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.ResumeDateGame()`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen._cancelDialog`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.CareerScreen._dialogOverlay`

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
- `NationalSpire.CareerScreen.CanResumeDateGame()`；输入表达式：`CanResumeDateGame()`；返回值紧邻使用处：`ConditionalExpressionSyntax: CanResumeDateGame() ? PrivateButton("返回游戏", () => { _cancelDialog?.Invoke(); ResumeDateGame(); }, 150) : PrivateButton("暂时返回私聊", () => LeaveDateScene(false), 150)`
- `NationalSpire.CareerScreen.LeaveDateScene(bool)`；输入表达式：`LeaveDateScene(false)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => LeaveDateScene(false)`
- `NationalSpire.CareerScreen.LeaveDateScene(bool)`；输入表达式：`LeaveDateScene(true)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => LeaveDateScene(true)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("暂时返回私聊", () => LeaveDateScene(false), 150)`；返回值紧邻使用处：`ConditionalExpressionSyntax: CanResumeDateGame() ? PrivateButton("返回游戏", () => { _cancelDialog?.Invoke(); ResumeDateGame(); }, 150) : PrivateButton("暂时返回私聊", () => LeaveDateScene(false), 150)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("结束约会", () => LeaveDateScene(true), 150)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton("结束约会", () => LeaveDateScene(true), 150)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("返回游戏", () => { _cancelDialog?.Invoke(); ResumeDateGame(); }, 150)`；返回值紧邻使用处：`ConditionalExpressionSyntax: CanResumeDateGame() ? PrivateButton("返回游戏", () => { _cancelDialog?.Invoke(); ResumeDateGame(); }, 150) : PrivateButton("暂时返回私聊", () => LeaveDateScene(false), 150)`
- `NationalSpire.CareerScreen.ResumeDateGame()`；输入表达式：`ResumeDateGame()`；返回值紧邻使用处：`ExpressionStatementSyntax: ResumeDateGame();`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("返回私聊", "结束约会后返回私聊，聊天记录继续保留。暂时返回会保留当前进度。", () => true, "继续约会", showCancel: false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("返回私聊", "结束约会后返回私聊，聊天记录继续保留。暂时返回会保留当前进度。", () => true, "继续约会", showCancel: false);`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _cancelDialog?.Invoke()`

**赋值（含属性/字段和局部值）：**

- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `button.SizeFlagsVertical` = `SizeFlags.Fill`
- `end.CustomMinimumSize` = `pause.CustomMinimumSize = resume.GetCombinedMinimumSize()`
- `pause.CustomMinimumSize` = `resume.GetCombinedMinimumSize()`
- `row.Alignment` = `BoxContainer.AlignmentMode.Begin`

<a id="symbol-942f3afae68b"></a>

## `NationalSpire.CareerScreen.LeaveDateScene(bool) — private void LeaveDateScene(bool end)`

来源：源码第 158 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DateSceneExitChoices()`](DateSceneScreen.cs.md#symbol-52133982acce)

**调用：** [`NationalSpire.CareerScreen.CloseDateScene()`](DateSceneScreen.cs.md#symbol-375f9bc3e86a)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)；[`NationalSpire.CareerScreen.SaveDateMemory(bool)`](DateSceneMemoryScreen.cs.md#symbol-c76191deb959)；[`NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`](DateSceneAssets.cs.md#symbol-2bf1f40a912e)；`NationalSpire.DateSceneBookmark.DateSceneBookmark()`；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；`System.Action.Invoke()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.CloseDateScene()`；`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`；`NationalSpire.CareerScreen.SaveDateMemory(bool)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._cancelDialog`；`NationalSpire.CareerScreen._dateAssets`；`NationalSpire.CareerScreen._dateIndex`；`NationalSpire.CareerScreen._dateOffer`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateReply`；`NationalSpire.CareerScreen._dateState`；`NationalSpire.CareerScreen._dateTurn`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`；`NationalSpire.DateSceneAssets.Bookmarks`；`NationalSpire.DateSceneBookmark.Index`；`NationalSpire.DateSceneBookmark.ReplyHash`；`NationalSpire.DateSceneBookmark.Turn`；`NationalSpire.DateSceneView.Status`；`NationalSpire.PrivateMessageCommand.Offer`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.CloseDateScene()`；输入表达式：`CloseDateScene()`；返回值紧邻使用处：`ExpressionStatementSyntax: CloseDateScene();`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；输入表达式：`PrivateCommand(end ? "dm-date-end" : "dm-date-pause", new() { Offer = _dateOffer }, () => { SaveDateMemory(end); _cancelDialog?.Invoke(); CloseDateScene(); RefreshPrivateChat(); })`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateCommand(end ? "dm-date-end" : "dm-date-pause", new() { Offer = _dateOffer }, () => { SaveDateMemory(end); _cancelDialog?.Invoke(); CloseDateScene(); RefreshPrivateChat(); });`
- `NationalSpire.CareerScreen.RefreshPrivateChat(bool)`；输入表达式：`RefreshPrivateChat()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshPrivateChat();`
- `NationalSpire.CareerScreen.SaveDateMemory(bool)`；输入表达式：`SaveDateMemory(end)`；返回值紧邻使用处：`ExpressionStatementSyntax: SaveDateMemory(end);`
- `NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`；输入表达式：`DateSceneAssetStore.Save(ViewData, _datePerson, _dateAssets)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateSceneAssetStore.Save(ViewData, _datePerson, _dateAssets);`
- `NationalSpire.DateSceneBookmark.DateSceneBookmark()`；输入表达式：`new() { Turn = _dateTurn, ReplyHash = _dateReply, Index = _dateIndex }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dateAssets.Bookmarks[_dateOffer] = new() { Turn = _dateTurn, ReplyHash = _dateReply, Index = _dateIndex }`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Offer = _dateOffer }`；返回值紧邻使用处：`ArgumentSyntax: new() { Offer = _dateOffer }`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _cancelDialog?.Invoke()`

**赋值（含属性/字段和局部值）：**

- `Index` = `_dateIndex`
- `Offer` = `_dateOffer`
- `ReplyHash` = `_dateReply`
- `Turn` = `_dateTurn`
- `_dateAssets.Bookmarks[_dateOffer]` = `new() { Turn = _dateTurn, ReplyHash = _dateReply, Index = _dateIndex }`
- `_dateView.Status.Text` = `"保存约会状态失败：" + e.Message`

<a id="symbol-a5b10d9fb0b8"></a>

## `NationalSpire.CareerScreen.AddPausedDateScenes(NationalSpire.CareerData, NationalSpire.PrivateConversation) — private void AddPausedDateScenes(CareerData data, PrivateConversation conversation)`

来源：源码第 170 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)

**调用：** `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.InviteDateParticipant(string)`](DateScenePartyScreen.cs.md#symbol-71141f3538db)；[`NationalSpire.CareerScreen.OpenDateScene(string, bool, bool)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)；[`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.DateSceneParty.People(NationalSpire.CareerData, NationalSpire.PrivateOffer, string)`](DateSceneParty.cs.md#symbol-f9cb6b2133b0)；[`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`](DateSceneData.cs.md#symbol-0d3e014bcb63)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.InviteDateParticipant(string)`；`NationalSpire.CareerScreen.OpenDateScene(string, bool, bool)`；`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._privateBody`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.DateSceneParty.People(NationalSpire.CareerData, NationalSpire.PrivateOffer, string)`；`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；`NationalSpire.PrivateConversation.DateSceneStates`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`actions.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddThemeConstantOverride("separation", 16);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("353042", "cf9db9", 10, 16))`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("353042", "cf9db9", 10, 16));`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateBody!.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateBody!.AddChild(panel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(PrivateButton("继续约会", () => { OpenPrivateMessages(host); OpenDateScene(offer.Id); }, 180))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(PrivateButton("继续约会", () => { OpenPrivateMessages(host); OpenDateScene(offer.Id); }, 180));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(PrivateButton("邀请其他人", () => { OpenPrivateMessages(host); InviteDateParticipant(offer.Id); }, 180))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(PrivateButton("邀请其他人", () => { OpenPrivateMessages(host); InviteDateParticipant(offer.Id); }, 180));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text("约会中 · " + offer.Title, 20, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text("约会中 · " + offer.Title, 20, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(actions);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { Name = "DateResumeCard" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { Name = "DateResumeCard" }`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(panel)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(panel)`
- `NationalSpire.CareerScreen.InviteDateParticipant(string)`；输入表达式：`InviteDateParticipant(offer.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: InviteDateParticipant(offer.Id);`
- `NationalSpire.CareerScreen.OpenDateScene(string, bool, bool)`；输入表达式：`OpenDateScene(offer.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenDateScene(offer.Id);`
- `NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；输入表达式：`OpenPrivateMessages(host)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenPrivateMessages(host);`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("继续约会", () => { OpenPrivateMessages(host); OpenDateScene(offer.Id); }, 180)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("继续约会", () => { OpenPrivateMessages(host); OpenDateScene(offer.Id); }, 180)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("邀请其他人", () => { OpenPrivateMessages(host); InviteDateParticipant(offer.Id); }, 180)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("邀请其他人", () => { OpenPrivateMessages(host); InviteDateParticipant(offer.Id); }, 180)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("约会中 · " + offer.Title, 20, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text("约会中 · " + offer.Title, 20, _ink)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("353042", "cf9db9", 10, 16)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("353042", "cf9db9", 10, 16)`
- `NationalSpire.DateSceneParty.People(NationalSpire.CareerData, NationalSpire.PrivateOffer, string)`；输入表达式：`DateSceneParty.People(data, o, c.PersonId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateSceneParty.People(data, o, c.PersonId).Contains`
- `NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；输入表达式：`DateScenes.Available(data, o, c)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.DateSceneStates.GetValueOrDefault(o.Id) is "active" or "paused" && DateScenes.Available(data, o, c)`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`c.Offers .Where(o => c.DateSceneStates.GetValueOrDefault(o.Id) is "active" or "paused" && DateScenes.Available(data, o, c) && DateSceneParty.People(data, o, c.PersonId).Contains(conversation.PersonId)).Select(o => (Host: c.PersonId, Offer: o))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => c.Offers .Where(o => c.DateSceneStates.GetValueOrDefault(o.Id) is "active" or "paused" && DateScenes.Available(data, o, c) && DateSceneParty.People(data, o, c.PersonId).Contains(conversation.PersonId)).Select(o => (Host: c.PersonId, Offer: o))`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.Values.SelectMany(c => c.Offers .Where(o => c.DateSceneStates.GetValueOrDefault(o.Id) is "active" or "paused" && DateScenes.Available(data, o, c) && DateSceneParty.People(data, o, c.PersonId).Contains(conversation.PersonId)).Select(o => (Host: c.PersonId, Offer: o)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations.Values.SelectMany(c => c.Offers .Where(o => c.DateSceneStates.GetValueOrDefault(o.Id) is "active" or "paused" && DateScenes.Available(data, o, c) && DateSceneParty.People(data, o, c.PersonId).Contains(conversation.PersonId)).Select(o => (Host: c.PersonId, Offer: o))).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.Values.SelectMany(c => c.Offers .Where(o => c.DateSceneStates.GetValueOrDefault(o.Id) is "active" or "paused" && DateScenes.Available(data, o, c) && DateSceneParty.People(data, o, c.PersonId).Contains(conversation.PersonId)).Select(o => (Host: c.PersonId, Offer: o))).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Mailbox(data).Conversations.Values.SelectMany(c => c.Offers .Where(o => c.DateSceneStates.GetValueOrDefault(o.Id) is "active" or "paused" && DateScenes.Available(data, o, c) && DateSceneParty.People(data, o, c.PersonId).Contains(conversation.PersonId)).Select(o => (Host: c.PersonId, Offer: o))).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Offers .Where(o => c.DateSceneStates.GetValueOrDefault(o.Id) is "active" or "paused" && DateScenes.Available(data, o, c) && DateSceneParty.People(data, o, c.PersonId).Contains(conversation.PersonId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Offers .Where(o => c.DateSceneStates.GetValueOrDefault(o.Id) is "active" or "paused" && DateScenes.Available(data, o, c) && DateSceneParty.People(data, o, c.PersonId).Contains(conversation.PersonId)).Select`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`c.DateSceneStates.GetValueOrDefault(o.Id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: c.DateSceneStates.GetValueOrDefault(o.Id) is "active" or "paused"`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`DateSceneParty.People(data, o, c.PersonId).Contains(conversation.PersonId)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.DateSceneStates.GetValueOrDefault(o.Id) is "active" or "paused" && DateScenes.Available(data, o, c) && DateSceneParty.People(data, o, c.PersonId).Contains(conversation.PersonId)`

**赋值（含属性/字段和局部值）：**

- `Name` = `"DateResumeCard"`

<a id="symbol-5923316321e9"></a>

## `NationalSpire.CareerScreen.TickDateScene() — private void TickDateScene()`

来源：源码第 184 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.InviteDateGame()`](DateGameScreen.cs.md#symbol-643d7d1bf1ef)；[`NationalSpire.CareerScreen.OpenDateScene(string, bool, bool)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)；[`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)；[`NationalSpire.CareerScreen.SendDateScene()`](DateSceneScreen.cs.md#symbol-b811d23c8af3)；[`NationalSpire.CareerScreen.StartDateGameReply(NationalSpire.CareerMatch, string)`](DateGameScreen.cs.md#symbol-8963173330c9)

**调用：** [`NationalSpire.AiService.PrivateKey(NationalSpire.CareerData, string)`](AiPrivateMessages.cs.md#symbol-97ba03595bc3)；[`NationalSpire.CareerScreen.AppendDateLine(NationalSpire.DateSceneLine)`](DateSceneScreen.cs.md#symbol-243385a70bb8)；[`NationalSpire.CareerScreen.CanEditPreviousDate(NationalSpire.PrivateTurn?)`](DateSceneScreen.cs.md#symbol-270cb56b5044)；[`NationalSpire.CareerScreen.CloseDateScene()`](DateSceneScreen.cs.md#symbol-375f9bc3e86a)；[`NationalSpire.CareerScreen.RefreshDateParty()`](DateScenePartyScreen.cs.md#symbol-3918c1aaf95a)；[`NationalSpire.CareerScreen.RefreshDateSceneAttachments()`](DateSceneScreen.cs.md#symbol-4cd4fd18856d)；[`NationalSpire.CareerScreen.SaveDateMemory(bool)`](DateSceneMemoryScreen.cs.md#symbol-c76191deb959)；[`NationalSpire.CareerScreen.ShowDateLine()`](DateSceneScreen.cs.md#symbol-1580b0be190e)；[`NationalSpire.CareerScreen.SyncDateMemory()`](DateSceneMemoryScreen.cs.md#symbol-4103852c245a)；[`NationalSpire.CareerScreen.TickDateGameActions()`](DateGameScreen.cs.md#symbol-c55c74e4c1fe)；[`NationalSpire.DateSceneAssetStore.Hash(byte[])`](DateSceneAssets.cs.md#symbol-e8871d339d39)；[`NationalSpire.DateSceneView.Relationship(NationalSpire.PrivateRelation, string, bool)`](DateSceneView.cs.md#symbol-949c1add6c05)；[`NationalSpire.DateSceneView.ShowWaiting(string, bool)`](DateSceneView.cs.md#symbol-c6c25a66fde3)；[`NationalSpire.DateSceneView.Streaming(bool)`](DateSceneView.cs.md#symbol-e7a96de3c199)；[`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`](DateSceneData.cs.md#symbol-0d3e014bcb63)；[`NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`](DateSceneData.cs.md#symbol-801111e76ca9)；[`NationalSpire.PortraitDesignStore.Key(NationalSpire.CareerData, string)`](PortraitDesignStore.cs.md#symbol-2ed1ee155b2d)；[`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-25194feb6779)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；[`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-8a6bb6e78fa5)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Math.Clamp(int, int, int)`；`System.Math.Min(int, int)`；`System.Text.Encoding.GetBytes(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.PrivateKey(NationalSpire.CareerData, string)`；`NationalSpire.AiService.PrivateSceneLive`；`NationalSpire.CareerScreen.AppendDateLine(NationalSpire.DateSceneLine)`；`NationalSpire.CareerScreen.CanEditPreviousDate(NationalSpire.PrivateTurn?)`；`NationalSpire.CareerScreen.CloseDateScene()`；`NationalSpire.CareerScreen.RefreshDateParty()`；`NationalSpire.CareerScreen.RefreshDateSceneAttachments()`；`NationalSpire.CareerScreen.SaveDateMemory(bool)`；`NationalSpire.CareerScreen.ShowDateLine()`；`NationalSpire.CareerScreen.SyncDateMemory()`；`NationalSpire.CareerScreen.TickDateGameActions()`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._dateAssets`；`NationalSpire.CareerScreen._dateEditingTurn`；`NationalSpire.CareerScreen._dateIndex`；`NationalSpire.CareerScreen._dateInitialBackground`；`NationalSpire.CareerScreen._dateInputTurn`；`NationalSpire.CareerScreen._dateKey`；`NationalSpire.CareerScreen._dateLines`；`NationalSpire.CareerScreen._dateManualGameInput`；`NationalSpire.CareerScreen._dateOffer`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateReply`；`NationalSpire.CareerScreen._dateSource`；`NationalSpire.CareerScreen._dateState`；`NationalSpire.CareerScreen._dateTurn`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen._privateStatus`；`NationalSpire.DateSceneAssetStore.Hash(byte[])`；`NationalSpire.DateSceneAssets.Bookmarks`；`NationalSpire.DateSceneBookmark.Index`；`NationalSpire.DateSceneBookmark.ReplyHash`；`NationalSpire.DateSceneBookmark.Turn`；`NationalSpire.DateSceneRequest.CurrentBackground`；`NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.DateSceneView.EditPreviousButton`；`NationalSpire.DateSceneView.InputMode`；`NationalSpire.DateSceneView.Relationship(NationalSpire.PrivateRelation, string, bool)`；`NationalSpire.DateSceneView.ShowWaiting(string, bool)`；`NationalSpire.DateSceneView.SpeakerId`；`NationalSpire.DateSceneView.Status`；`NationalSpire.DateSceneView.Streaming(bool)`；`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；`NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`；`NationalSpire.PortraitDesignStore.Key(NationalSpire.CareerData, string)`；`NationalSpire.PrivateConversation.DateSceneStates`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateTurn.Error`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.PrivateTurn.Reply`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.Scene`；`NationalSpire.PrivateTurn.Status`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.PrivateKey(NationalSpire.CareerData, string)`；输入表达式：`AiService.PrivateKey(data, _datePerson)`；返回值紧邻使用处：`ArgumentSyntax: AiService.PrivateKey(data, _datePerson)`
- `NationalSpire.CareerScreen.AppendDateLine(NationalSpire.DateSceneLine)`；输入表达式：`AppendDateLine(_dateLines[Math.Min(_dateIndex, _dateLines.Count - 1)])`；返回值紧邻使用处：`ExpressionStatementSyntax: AppendDateLine(_dateLines[Math.Min(_dateIndex, _dateLines.Count - 1)]);`
- `NationalSpire.CareerScreen.AppendDateLine(NationalSpire.DateSceneLine)`；输入表达式：`AppendDateLine(_dateLines[_dateIndex])`；返回值紧邻使用处：`ExpressionStatementSyntax: AppendDateLine(_dateLines[_dateIndex]);`
- `NationalSpire.CareerScreen.CanEditPreviousDate(NationalSpire.PrivateTurn?)`；输入表达式：`CanEditPreviousDate(c.Turns.LastOrDefault())`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CanEditPreviousDate(c.Turns.LastOrDefault())`
- `NationalSpire.CareerScreen.CloseDateScene()`；输入表达式：`CloseDateScene()`；返回值紧邻使用处：`ExpressionStatementSyntax: CloseDateScene();`
- `NationalSpire.CareerScreen.RefreshDateParty()`；输入表达式：`RefreshDateParty()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !RefreshDateParty()`
- `NationalSpire.CareerScreen.RefreshDateSceneAttachments()`；输入表达式：`RefreshDateSceneAttachments()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshDateSceneAttachments();`
- `NationalSpire.CareerScreen.SaveDateMemory(bool)`；输入表达式：`SaveDateMemory()`；返回值紧邻使用处：`ExpressionStatementSyntax: SaveDateMemory();`
- `NationalSpire.CareerScreen.SaveDateMemory(bool)`；输入表达式：`SaveDateMemory(c.DateSceneStates.GetValueOrDefault(_dateOffer) == "ended")`；返回值紧邻使用处：`ExpressionStatementSyntax: SaveDateMemory(c.DateSceneStates.GetValueOrDefault(_dateOffer) == "ended");`
- `NationalSpire.CareerScreen.ShowDateLine()`；输入表达式：`ShowDateLine()`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowDateLine();`
- `NationalSpire.CareerScreen.SyncDateMemory()`；输入表达式：`SyncDateMemory()`；返回值紧邻使用处：`ExpressionStatementSyntax: SyncDateMemory();`
- `NationalSpire.CareerScreen.TickDateGameActions()`；输入表达式：`TickDateGameActions()`；返回值紧邻使用处：`ExpressionStatementSyntax: TickDateGameActions();`
- `NationalSpire.DateSceneAssetStore.Hash(byte[])`；输入表达式：`DateSceneAssetStore.Hash(Encoding.UTF8.GetBytes(turn.Reply))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateSceneAssetStore.Hash(Encoding.UTF8.GetBytes(turn.Reply))`
- `NationalSpire.DateSceneView.Relationship(NationalSpire.PrivateRelation, string, bool)`；输入表达式：`_dateView.Relationship(PrivateMessages.Relation(data, speaker), speaker)`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.Relationship(PrivateMessages.Relation(data, speaker), speaker);`
- `NationalSpire.DateSceneView.ShowWaiting(string, bool)`；输入表达式：`_dateView.ShowWaiting(_privateStatus?.Text.Length > 0 ? _privateStatus.Text : "正在准备开场…", true)`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.ShowWaiting(_privateStatus?.Text.Length > 0 ? _privateStatus.Text : "正在准备开场…", true);`
- `NationalSpire.DateSceneView.ShowWaiting(string, bool)`；输入表达式：`_dateView.ShowWaiting(turn.Status == "failed" ? turn.Error : "正在生成完整回复与情绪差分…", turn.Status == "failed")`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.ShowWaiting(turn.Status == "failed" ? turn.Error : "正在生成完整回复与情绪差分…", turn.Status == "failed");`
- `NationalSpire.DateSceneView.Streaming(bool)`；输入表达式：`_dateView.Streaming(false)`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.Streaming(false);`
- `NationalSpire.DateSceneView.Streaming(bool)`；输入表达式：`_dateView.Streaming(true)`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.Streaming(true);`
- `NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；输入表达式：`DateScenes.Available(data, o, c)`；返回值紧邻使用处：`BinaryExpressionSyntax: o.Id == _dateOffer && DateScenes.Available(data, o, c)`
- `NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`；输入表达式：`DateScenes.Lines(turn)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dateLines = DateScenes.Lines(turn)`
- `NationalSpire.PortraitDesignStore.Key(NationalSpire.CareerData, string)`；输入表达式：`PortraitDesignStore.Key(data, _datePerson)`；返回值紧邻使用处：`BinaryExpressionSyntax: PortraitDesignStore.Key(data, _datePerson) != _dateKey`
- `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.CanChat(data, _datePerson)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PrivateMessages.CanChat(data, _datePerson)`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, _datePerson)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(data, _datePerson)`
- `NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Relation(data, speaker)`；返回值紧邻使用处：`ArgumentSyntax: PrivateMessages.Relation(data, speaker)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Offers.Any(o => o.Id == _dateOffer && DateScenes.Available(data, o, c))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !c.Offers.Any(o => o.Id == _dateOffer && DateScenes.Available(data, o, c))`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`c.Turns.LastOrDefault()`；返回值紧邻使用处：`ArgumentSyntax: c.Turns.LastOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.LastOrDefault(t => t.Scene?.OfferId == _dateOffer && !t.ReplyDeleted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Turns.LastOrDefault(t => t.Scene?.OfferId == _dateOffer && !t.ReplyDeleted)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`AiService.PrivateSceneLive.GetValueOrDefault(AiService.PrivateKey(data, _datePerson))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AiService.PrivateSceneLive.GetValueOrDefault(AiService.PrivateKey(data, _datePerson))`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`_dateAssets.Bookmarks.GetValueOrDefault(_dateOffer)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _dateAssets.Bookmarks.GetValueOrDefault(_dateOffer)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`c.DateSceneStates.GetValueOrDefault(_dateOffer)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.DateSceneStates.GetValueOrDefault(_dateOffer) == "ended"`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(bookmark.Index, 0, _dateLines.Count)`；返回值紧邻使用处：`ConditionalExpressionSyntax: bookmark?.Turn == turn.Id && bookmark.ReplyHash == hash ? Math.Clamp(bookmark.Index, 0, _dateLines.Count) : 0`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(_dateIndex, _dateLines.Count - 1)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(_dateIndex, _dateLines.Count - 1)`
- `System.Text.Encoding.GetBytes(string)`；输入表达式：`Encoding.UTF8.GetBytes(turn.Reply)`；返回值紧邻使用处：`ArgumentSyntax: Encoding.UTF8.GetBytes(turn.Reply)`

**赋值（含属性/字段和局部值）：**

- `_dateEditingTurn` = `""`
- `_dateIndex` = `0`
- `_dateIndex` = `bookmark?.Turn == turn.Id && bookmark.ReplyHash == hash ? Math.Clamp(bookmark.Index, 0, _dateLines.Count) : 0`
- `_dateInitialBackground` = `turn.Scene!.CurrentBackground`
- `_dateInitialBackground` = `turn.Scene?.CurrentBackground ?? ""`
- `_dateInputTurn` = `""`
- `_dateLines` = `DateScenes.Lines(turn)`
- `_dateLines` = `live.Lines`
- `_dateManualGameInput` = `false`
- `_dateReply` = `hash`
- `_dateSource` = `turn.Reply`
- `_dateState` = `"complete"`
- `_dateState` = `"streaming"`
- `_dateState` = `state`
- `_dateTurn` = `turn.Id`
- `_dateView.EditPreviousButton.Disabled` = `_dateEditingTurn.Length > 0 || !CanEditPreviousDate(c.Turns.LastOrDefault())`
- `_dateView.Status.Text` = `turn.Error`

<a id="symbol-4cd4fd18856d"></a>

## `NationalSpire.CareerScreen.RefreshDateSceneAttachments() — private void RefreshDateSceneAttachments()`

来源：源码第 235 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)

**调用：** `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；[`NationalSpire.CareerScreen.PrivateAttachmentCard(NationalSpire.PrivateOffer, bool)`](PrivateMemoryScreen.cs.md#symbol-eb2b2a37c5d1)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`NationalSpire.DateSceneView.ShowAttachments()`](DateSceneView.cs.md#symbol-f99d5e4e9b59)；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.PrivateAttachmentCard(NationalSpire.PrivateOffer, bool)`；`NationalSpire.CareerScreen.PrivateAttachments`；`NationalSpire.CareerScreen._dateAttachments`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.DateSceneView.Attachments`；`NationalSpire.DateSceneView.ShowAttachments()`；`NationalSpire.PrivateOffer.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_dateView.Attachments.AddChild(PrivateAttachmentCard(item, true))`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.Attachments.AddChild(PrivateAttachmentCard(item, true));`
- `NationalSpire.CareerScreen.PrivateAttachmentCard(NationalSpire.PrivateOffer, bool)`；输入表达式：`PrivateAttachmentCard(item, true)`；返回值紧邻使用处：`ArgumentSyntax: PrivateAttachmentCard(item, true)`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(_dateView.Attachments)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(_dateView.Attachments);`
- `NationalSpire.DateSceneView.ShowAttachments()`；输入表达式：`_dateView.ShowAttachments()`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.ShowAttachments();`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`PrivateAttachments.Select(a => a.Id)`；返回值紧邻使用处：`ArgumentSyntax: PrivateAttachments.Select(a => a.Id)`
- `string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；输入表达式：`string.Join('|', PrivateAttachments.Select(a => a.Id))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = string.Join('|', PrivateAttachments.Select(a => a.Id))`

**赋值（含属性/字段和局部值）：**

- `_dateAttachments` = `attachments`

<a id="symbol-243385a70bb8"></a>

## `NationalSpire.CareerScreen.AppendDateLine(NationalSpire.DateSceneLine) — private void AppendDateLine(DateSceneLine line)`

来源：源码第 245 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerScreen.ApplyDateBackground()`](DateSceneScreen.cs.md#symbol-4c2055af1c70)；[`NationalSpire.CareerScreen.CaptureDateMemory()`](DateSceneMemoryScreen.cs.md#symbol-7b36ced91124)；[`NationalSpire.CareerScreen.PartyTexture(string, string)`](DateScenePartyScreen.cs.md#symbol-53bfcf8e2a43)；[`NationalSpire.DateSceneView.AppendLine(System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, System.Func<(string Name, Godot.Texture2D Texture)>?)`](DateSceneView.cs.md#symbol-eecb2292c03b)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen.ApplyDateBackground()`；`NationalSpire.CareerScreen.CaptureDateMemory()`；`NationalSpire.CareerScreen.PartyTexture(string, string)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._dateIndex`；`NationalSpire.CareerScreen._dateLines`；`NationalSpire.CareerScreen._datePartyArt`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.DateSceneLine.Emotion`；`NationalSpire.DateSceneLine.Speaker`；`NationalSpire.DateSceneView.AppendLine(System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, System.Func<(string Name, Godot.Texture2D Texture)>?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(ViewData, speaker)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.DisplayName(ViewData, speaker)`
- `NationalSpire.CareerScreen.ApplyDateBackground()`；输入表达式：`ApplyDateBackground()`；返回值紧邻使用处：`ExpressionStatementSyntax: ApplyDateBackground();`
- `NationalSpire.CareerScreen.CaptureDateMemory()`；输入表达式：`CaptureDateMemory()`；返回值紧邻使用处：`ExpressionStatementSyntax: CaptureDateMemory();`
- `NationalSpire.CareerScreen.PartyTexture(string, string)`；输入表达式：`PartyTexture(speaker, line.Emotion)`；返回值紧邻使用处：`ArgumentSyntax: PartyTexture(speaker, line.Emotion)`
- `NationalSpire.DateSceneView.AppendLine(System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, System.Func<(string Name, Godot.Texture2D Texture)>?)`；输入表达式：`_dateView!.AppendLine(_dateLines, Math.Min(_dateIndex, _dateLines.Count - 1), () => { string speaker = _datePartyArt.ContainsKey(line.Speaker) ? line.Speaker : _datePerson; return (CareerEngine.DisplayName(ViewData, speaker), PartyTexture(speaker, line.Emotion)); })`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView!.AppendLine(_dateLines, Math.Min(_dateIndex, _dateLines.Count - 1), () => { string speaker = _datePartyArt.ContainsKey(line.Speaker) ? line.Speaker : _datePerson; return (CareerEngine.DisplayName(ViewData, speaker), PartyTexture(speaker, line.Emotion)); });`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`_datePartyArt.ContainsKey(line.Speaker)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _datePartyArt.ContainsKey(line.Speaker) ? line.Speaker : _datePerson`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(_dateIndex, _dateLines.Count - 1)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(_dateIndex, _dateLines.Count - 1)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1580b0be190e"></a>

## `NationalSpire.CareerScreen.ShowDateLine() — private void ShowDateLine()`

来源：源码第 255 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AdvanceDateScene()`](DateSceneScreen.cs.md#symbol-96e53c8a266f)；[`NationalSpire.CareerScreen.DateSceneSettings()`](DateSceneScreen.cs.md#symbol-0845ec2acab1)；[`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerScreen.ApplyDateBackground()`](DateSceneScreen.cs.md#symbol-4c2055af1c70)；[`NationalSpire.CareerScreen.CaptureDateMemory()`](DateSceneMemoryScreen.cs.md#symbol-7b36ced91124)；[`NationalSpire.CareerScreen.PartyTexture(string, string)`](DateScenePartyScreen.cs.md#symbol-53bfcf8e2a43)；[`NationalSpire.CareerScreen.ShowDateGameChoices(NationalSpire.CareerMatch)`](DateGameScreen.cs.md#symbol-d1774dd40624)；[`NationalSpire.CareerScreen.ShowDateInput(bool, bool)`](DateGameScreen.cs.md#symbol-f7a3691c9897)；[`NationalSpire.DateGames.AwaitingStart(NationalSpire.CareerData, string, string)`](DateGames.cs.md#symbol-30dbc76323ef)；[`NationalSpire.DateSceneView.ShowRoundLine(System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, string, Godot.Texture2D)`](DateSceneCast.cs.md#symbol-35177f2945fc)；[`NationalSpire.DateSceneView.Streaming(bool)`](DateSceneView.cs.md#symbol-e7a96de3c199)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen.ApplyDateBackground()`；`NationalSpire.CareerScreen.CaptureDateMemory()`；`NationalSpire.CareerScreen.PartyTexture(string, string)`；`NationalSpire.CareerScreen.ShowDateGameChoices(NationalSpire.CareerMatch)`；`NationalSpire.CareerScreen.ShowDateInput(bool, bool)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._dateIndex`；`NationalSpire.CareerScreen._dateLines`；`NationalSpire.CareerScreen._dateOffer`；`NationalSpire.CareerScreen._datePartyArt`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateRunResume`；`NationalSpire.CareerScreen._dateState`；`NationalSpire.CareerScreen._dateTextureWarning`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.DateGames.AwaitingStart(NationalSpire.CareerData, string, string)`；`NationalSpire.DateSceneLine.Emotion`；`NationalSpire.DateSceneLine.Speaker`；`NationalSpire.DateSceneView.ShowRoundLine(System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, string, Godot.Texture2D)`；`NationalSpire.DateSceneView.Status`；`NationalSpire.DateSceneView.Streaming(bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(ViewData, speaker)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.DisplayName(ViewData, speaker)`
- `NationalSpire.CareerScreen.ApplyDateBackground()`；输入表达式：`ApplyDateBackground()`；返回值紧邻使用处：`ExpressionStatementSyntax: ApplyDateBackground();`
- `NationalSpire.CareerScreen.CaptureDateMemory()`；输入表达式：`CaptureDateMemory()`；返回值紧邻使用处：`ExpressionStatementSyntax: CaptureDateMemory();`
- `NationalSpire.CareerScreen.PartyTexture(string, string)`；输入表达式：`PartyTexture(speaker, line.Emotion)`；返回值紧邻使用处：`ArgumentSyntax: PartyTexture(speaker, line.Emotion)`
- `NationalSpire.CareerScreen.ShowDateGameChoices(NationalSpire.CareerMatch)`；输入表达式：`ShowDateGameChoices(game)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowDateGameChoices(game);`
- `NationalSpire.CareerScreen.ShowDateInput(bool, bool)`；输入表达式：`ShowDateInput()`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowDateInput();`
- `NationalSpire.DateGames.AwaitingStart(NationalSpire.CareerData, string, string)`；输入表达式：`DateGames.AwaitingStart(ViewData, _datePerson, _dateOffer)`；返回值紧邻使用处：`IsPatternExpressionSyntax: DateGames.AwaitingStart(ViewData, _datePerson, _dateOffer) is { } game`
- `NationalSpire.DateSceneView.ShowRoundLine(System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, string, Godot.Texture2D)`；输入表达式：`_dateView.ShowRoundLine(_dateLines, _dateIndex, CareerEngine.DisplayName(ViewData, speaker), PartyTexture(speaker, line.Emotion))`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.ShowRoundLine(_dateLines, _dateIndex, CareerEngine.DisplayName(ViewData, speaker), PartyTexture(speaker, line.Emotion));`
- `NationalSpire.DateSceneView.Streaming(bool)`；输入表达式：`_dateView.Streaming(_dateState == "streaming")`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.Streaming(_dateState == "streaming");`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`_datePartyArt.ContainsKey(line.Speaker)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _datePartyArt.ContainsKey(line.Speaker) ? line.Speaker : _datePerson`

**赋值（含属性/字段和局部值）：**

- `_dateView.Status.Text` = `_dateTextureWarning`

<a id="symbol-413adf55a103"></a>

## `NationalSpire.CareerScreen.AddDateSceneAction(NationalSpire.CareerData, NationalSpire.PrivateOffer, Godot.HBoxContainer) — private void AddDateSceneAction(CareerData data, PrivateOffer offer, HBoxContainer row)`

来源：源码第 274 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-c7881d245b3d)

**调用：** `Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`；`Godot.CanvasItem.Hide()`；`Godot.Color.Color(string)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CareerScreen.InviteDateParticipant(string)`](DateScenePartyScreen.cs.md#symbol-71141f3538db)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.PromptDateScene(string)`](DateSceneScreen.cs.md#symbol-d6c92b4f494c)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`NationalSpire.DateChoiceButton.DateChoiceButton()`；[`NationalSpire.DateSceneParty.Eligible(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`](DateSceneParty.cs.md#symbol-0b65821baf62)；[`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`](DateSceneData.cs.md#symbol-0d3e014bcb63)；[`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-15c716ec61a1)；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`System.Action.Invoke()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerScreen.InviteDateParticipant(string)`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；`NationalSpire.CareerScreen.PromptDateScene(string)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen._cancelDialog`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.DateChoiceButton.Caption`；`NationalSpire.DateChoiceButton.Public`；`NationalSpire.DateChoiceButton.Subtitle`；`NationalSpire.DateSceneParty.Eligible(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateConversation.DateSceneStates`；`NationalSpire.PrivateMessageCommand.Offer`；`NationalSpire.PrivateMessageCommand.Part`；`NationalSpire.PrivateMessageCommand.SceneAttendance`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.State`

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
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(PrivateButton("邀请其他人", () => InviteDateParticipant(offer.Id), 150))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(PrivateButton("邀请其他人", () => InviteDateParticipant(offer.Id), 150));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(button);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(150, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(150, 48)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(290, 150)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(290, 150)`
- `NationalSpire.CareerScreen.InviteDateParticipant(string)`；输入表达式：`InviteDateParticipant(offer.Id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => InviteDateParticipant(offer.Id)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("邀请其他人", () => InviteDateParticipant(offer.Id), 150)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("邀请其他人", () => InviteDateParticipant(offer.Id), 150)`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；输入表达式：`PrivateCommand("dm-attend", new() { Offer = offer.Id, Part = visible ? "public" : "", SceneAttendance = true }, () => { _cancelDialog?.Invoke(); Callable.From(() => PromptDateScene(offer.Id)).CallDeferred(); })`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => PrivateCommand("dm-attend", new() { Offer = offer.Id, Part = visible ? "public" : "", SceneAttendance = true }, () => { _cancelDialog?.Invoke(); Callable.From(() => PromptDateScene(offer.Id)).CallDeferred(); })`
- `NationalSpire.CareerScreen.PromptDateScene(string)`；输入表达式：`PromptDateScene(offer.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: PromptDateScene(offer.Id);`
- `NationalSpire.CareerScreen.PromptDateScene(string)`；输入表达式：`PromptDateScene(offer.Id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => PromptDateScene(offer.Id)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("专属约会", "选择这次赴约的公开方式。", () => true, "取消", box => { var choices = new HBoxContainer(); choices.AddThemeConstantOverride("separation", 20); box.AddChild(choices); foreach (bool visible in new[] { false, true }) { var choice = new DateChoiceButton { Name = visible ? "DatePublicChoice" : "DatePrivateChoice", Caption = visible ? "公开赴约" : "私密赴约", Subtitle = visible ? "让这次相聚成为公开经历" : "将这次相聚留在彼此之间", Public = visible, CustomMinimumSize = new(290, 150), SizeFlagsHorizontal = SizeFlags.ExpandFill }; choice.Pressed += () => PrivateCommand("dm-attend", new() { Offer = offer.Id, Part = visible ? "public" : "", SceneAttendance = true }, () => { _cancelDialog?.Invoke(); Callable.From(() => PromptDateScene(offer.Id)).CallDeferred(); }); choices.AddChild(choice); } var error = Text("", 16, new Color("ee929d")); error.Name = "DateAttendanceError"; error.Hide(); box.AddChild(error); }, showCancel: false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("专属约会", "选择这次赴约的公开方式。", () => true, "取消", box => { var choices = new HBoxContainer(); choices.AddThemeConstantOverride("separation", 20); box.AddChild(choices); foreach (bool visible in new[] { false, true }) { var choice = new DateChoiceButton { Name = visible ? "DatePublicChoice" : "DatePrivateChoice", Caption = visible ? "公开赴约" : "私密赴约", Subtitle = visible ? "让这次相聚成为公开经历" : "将这次相聚留在彼此之间", Public = visible, CustomMinimumSize = new(290, 150), SizeFlagsHorizontal = SizeFlags.ExpandFill }; choice.Pressed += () => PrivateCommand("dm-attend", new() { Offer = offer.Id, Part = visible ? "public" : "", SceneAttendance = true }, () => { _cancelDialog?.Invoke(); Callable.From(() => PromptDateScene(offer.Id)).CallDeferred(); }); choices.AddChild(choice); } var error = Text("", 16, new Color("ee929d")); error.Name = "DateAttendanceError"; error.Hide(); box.AddChild(error); }, showCancel: false);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 16, new Color("ee929d"))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("", 16, new Color("ee929d"))`
- `NationalSpire.DateChoiceButton.DateChoiceButton()`；输入表达式：`new DateChoiceButton { Name = "ExclusiveDate", Caption = conversation.DateSceneStates.GetValueOrDefault(offer.Id) == "paused" ? "继续约会" : "专属约会", CustomMinimumSize = new(150, 48), SizeFlagsVertical = SizeFlags.ShrinkCenter }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new DateChoiceButton { Name = "ExclusiveDate", Caption = conversation.DateSceneStates.GetValueOrDefault(offer.Id) == "paused" ? "继续约会" : "专属约会", CustomMinimumSize = new(150, 48), SizeFlagsVertical = SizeFlags.ShrinkCenter }`
- `NationalSpire.DateChoiceButton.DateChoiceButton()`；输入表达式：`new DateChoiceButton { Name = visible ? "DatePublicChoice" : "DatePrivateChoice", Caption = visible ? "公开赴约" : "私密赴约", Subtitle = visible ? "让这次相聚成为公开经历" : "将这次相聚留在彼此之间", Public = visible, CustomMinimumSize = new(290, 150), SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new DateChoiceButton { Name = visible ? "DatePublicChoice" : "DatePrivateChoice", Caption = visible ? "公开赴约" : "私密赴约", Subtitle = visible ? "让这次相聚成为公开经历" : "将这次相聚留在彼此之间", Public = visible, CustomMinimumSize = new(290, 150), SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `NationalSpire.DateSceneParty.Eligible(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；输入表达式：`DateSceneParty.Eligible(data, offer, conversation)`；返回值紧邻使用处：`BinaryExpressionSyntax: DateSceneParty.Eligible(data, offer, conversation) && offer.State is "已确认" or "已赴约"`
- `NationalSpire.DateSceneParty.Eligible(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；输入表达式：`DateSceneParty.Eligible(data, offer, conversation)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !DateSceneParty.Eligible(data, offer, conversation)`
- `NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；输入表达式：`DateScenes.Available(data, offer, conversation)`；返回值紧邻使用处：`BinaryExpressionSyntax: attend || DateScenes.Available(data, offer, conversation)`
- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Date(data, offer)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateAppointments.Date(data, offer) == data.Day`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Offer = offer.Id, Part = visible ? "public" : "", SceneAttendance = true }`；返回值紧邻使用处：`ArgumentSyntax: new() { Offer = offer.Id, Part = visible ? "public" : "", SceneAttendance = true }`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, _privatePerson)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(data, _privatePerson)`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _cancelDialog?.Invoke()`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`conversation.DateSceneStates.GetValueOrDefault(offer.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: conversation.DateSceneStates.GetValueOrDefault(offer.Id) == "paused"`

**赋值（含属性/字段和局部值）：**

- `Caption` = `conversation.DateSceneStates.GetValueOrDefault(offer.Id) == "paused" ? "继续约会" : "专属约会"`
- `Caption` = `visible ? "公开赴约" : "私密赴约"`
- `CustomMinimumSize` = `new(150, 48)`
- `CustomMinimumSize` = `new(290, 150)`
- `Name` = `"ExclusiveDate"`
- `Name` = `visible ? "DatePublicChoice" : "DatePrivateChoice"`
- `Offer` = `offer.Id`
- `Part` = `visible ? "public" : ""`
- `Public` = `visible`
- `SceneAttendance` = `true`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `Subtitle` = `visible ? "让这次相聚成为公开经历" : "将这次相聚留在彼此之间"`
- `button.Pressed` += `() => { if (!attend) { PromptDateScene(offer.Id); return; } ShowCareerDialog("专属约会", "选择这次赴约的公开方式。", () => true, "取消", box => { var choices = new HBoxContainer(); choices.AddThemeConstantOverride("separation", 20); box.AddChild(choices); foreach (bool visible in new[] { false, true }) { var choice = new DateChoiceButton { Name = visible ? "DatePublicChoice" : "DatePrivateChoice", Caption = visible ? "公开赴约" : "私密赴约", Subtitle = visible ? "让这次相聚成为公开经历" : "将这次相聚留在彼此之间", Public = visible, CustomMinimumSize = new(290, 150), SizeFlagsHorizontal = SizeFlags.ExpandFill }; choice.Pressed += () => PrivateCommand("dm-attend", new() { Offer = offer.Id, Part = visible ? "public" : "", SceneAttendance = true }, () => { _cancelDialog?.Invoke(); Callable.From(() => PromptDateScene(offer.Id)).CallDeferred(); }); choices.AddChild(choice); } var error = Text("", 16, new Color("ee929d")); error.Name = "DateAttendanceError"; error.Hide(); box.AddChild(error); }, showCancel: false); }`
- `choice.Pressed` += `() => PrivateCommand("dm-attend", new() { Offer = offer.Id, Part = visible ? "public" : "", SceneAttendance = true }, () => { _cancelDialog?.Invoke(); Callable.From(() => PromptDateScene(offer.Id)).CallDeferred(); })`
- `error.Name` = `"DateAttendanceError"`

<a id="symbol-4d37da1a3f4b"></a>

## `NationalSpire.CareerScreen.SelectDateBackground(string) — private void SelectDateBackground(string id)`

来源：源码第 302 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

来源：源码第 309 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Apply()`](DateSceneScreen.cs.md#symbol-1f00e77adbe1)；[`NationalSpire.CareerScreen.AppendDateLine(NationalSpire.DateSceneLine)`](DateSceneScreen.cs.md#symbol-243385a70bb8)；[`NationalSpire.CareerScreen.ShowDateLine()`](DateSceneScreen.cs.md#symbol-1580b0be190e)

**调用：** [`NationalSpire.CareerScreen.SelectDateBackground(string)`](DateSceneScreen.cs.md#symbol-4d37da1a3f4b)；[`NationalSpire.DateSceneBackgrounds.At(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneBackground>, System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, string, string)`](DateSceneBackgrounds.cs.md#symbol-0f51af8c0e19)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.SelectDateBackground(string)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._dateAssets`；`NationalSpire.CareerScreen._dateBackgrounds`；`NationalSpire.CareerScreen._dateIndex`；`NationalSpire.CareerScreen._dateInitialBackground`；`NationalSpire.CareerScreen._dateLines`；`NationalSpire.CareerScreen._dateOffer`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.DateSceneAssets.AutoBackground`；`NationalSpire.DateSceneAssets.Background`；`NationalSpire.DateSceneBackgrounds.At(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneBackground>, System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, string, string)`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.SelectDateBackground(string)`；输入表达式：`SelectDateBackground(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: SelectDateBackground(id);`
- `NationalSpire.DateSceneBackgrounds.At(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneBackground>, System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, string, string)`；输入表达式：`DateSceneBackgrounds.At(_dateBackgrounds, _dateLines, _dateIndex, _dateInitialBackground, offer?.Title + " " + offer?.Detail)`；返回值紧邻使用处：`AssignmentExpressionSyntax: id = DateSceneBackgrounds.At(_dateBackgrounds, _dateLines, _dateIndex, _dateInitialBackground, offer?.Title + " " + offer?.Detail)`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(ViewData, _datePerson)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Conversation(ViewData, _datePerson).Offers`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateMessages.Conversation(ViewData, _datePerson).Offers.FirstOrDefault(o => o.Id == _dateOffer)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(ViewData, _datePerson).Offers.FirstOrDefault(o => o.Id == _dateOffer)`

**赋值（含属性/字段和局部值）：**

- `id` = `DateSceneBackgrounds.At(_dateBackgrounds, _dateLines, _dateIndex, _dateInitialBackground, offer?.Title + " " + offer?.Detail)`

<a id="symbol-96e53c8a266f"></a>

## `NationalSpire.CareerScreen.AdvanceDateScene() — private void AdvanceDateScene()`

来源：源码第 320 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerScreen.CaptureDateMemory()`](DateSceneMemoryScreen.cs.md#symbol-7b36ced91124)；[`NationalSpire.CareerScreen.SaveDateMemory(bool)`](DateSceneMemoryScreen.cs.md#symbol-c76191deb959)；[`NationalSpire.CareerScreen.ShowDateLine()`](DateSceneScreen.cs.md#symbol-1580b0be190e)；[`NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`](DateSceneAssets.cs.md#symbol-2bf1f40a912e)；`NationalSpire.DateSceneBookmark.DateSceneBookmark()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.CaptureDateMemory()`；`NationalSpire.CareerScreen.SaveDateMemory(bool)`；`NationalSpire.CareerScreen.ShowDateLine()`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._dateAssets`；`NationalSpire.CareerScreen._dateIndex`；`NationalSpire.CareerScreen._dateLines`；`NationalSpire.CareerScreen._dateOffer`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateReply`；`NationalSpire.CareerScreen._dateState`；`NationalSpire.CareerScreen._dateTurn`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`；`NationalSpire.DateSceneAssets.Bookmarks`；`NationalSpire.DateSceneBookmark.Index`；`NationalSpire.DateSceneBookmark.ReplyHash`；`NationalSpire.DateSceneBookmark.Turn`；`NationalSpire.DateSceneView.Status`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.CaptureDateMemory()`；输入表达式：`CaptureDateMemory()`；返回值紧邻使用处：`ExpressionStatementSyntax: CaptureDateMemory();`
- `NationalSpire.CareerScreen.SaveDateMemory(bool)`；输入表达式：`SaveDateMemory()`；返回值紧邻使用处：`ExpressionStatementSyntax: SaveDateMemory();`
- `NationalSpire.CareerScreen.ShowDateLine()`；输入表达式：`ShowDateLine()`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowDateLine();`
- `NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`；输入表达式：`DateSceneAssetStore.Save(ViewData, _datePerson, _dateAssets)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateSceneAssetStore.Save(ViewData, _datePerson, _dateAssets);`
- `NationalSpire.DateSceneBookmark.DateSceneBookmark()`；输入表达式：`new() { Turn = _dateTurn, ReplyHash = _dateReply, Index = _dateIndex }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dateAssets!.Bookmarks[_dateOffer] = new() { Turn = _dateTurn, ReplyHash = _dateReply, Index = _dateIndex }`

**赋值（含属性/字段和局部值）：**

- `Index` = `_dateIndex`
- `ReplyHash` = `_dateReply`
- `Turn` = `_dateTurn`
- `_dateAssets!.Bookmarks[_dateOffer]` = `new() { Turn = _dateTurn, ReplyHash = _dateReply, Index = _dateIndex }`
- `_dateView.Status.Text` = `"播放进度保存失败：" + e.Message`
- `_dateView.Status.Text` = `"正在续写当前回复…"`

<a id="symbol-b811d23c8af3"></a>

## `NationalSpire.CareerScreen.SendDateScene() — private void SendDateScene()`

来源：源码第 334 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ChooseDateReply(string)`](DateGameScreen.cs.md#symbol-d59ce1085050)

**调用：** `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.SendPrivate()`](PrivateMessageScreen.cs.md#symbol-748ab66a7351)；[`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；`NationalSpire.CareerScreen.SendPrivate()`；`NationalSpire.CareerScreen.TickDateScene()`；`NationalSpire.CareerScreen._dateAssets`；`NationalSpire.CareerScreen._dateEditingTurn`；`NationalSpire.CareerScreen._dateManualGameInput`；`NationalSpire.CareerScreen._dateOffer`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateState`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.CareerScreen._privateDrafts`；`NationalSpire.CareerScreen._privateInput`；`NationalSpire.DateSceneAssets.Bookmarks`；`NationalSpire.DateSceneView.DialogueHidden`；`NationalSpire.DateSceneView.Editor`；`NationalSpire.DateSceneView.HistoryOpen`；`NationalSpire.DateSceneView.InputMode`；`NationalSpire.PrivateMessageCommand.Entry`；`NationalSpire.PrivateMessageCommand.Text`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_privateInput)`；返回值紧邻使用处：`BinaryExpressionSyntax: _privateInput != null && IsInstanceValid(_privateInput)`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；输入表达式：`PrivateCommand("dm-date-revise", new() { Entry = _dateEditingTurn, Text = _dateView.Editor.Text }, () => { _dateManualGameInput = false; _dateEditingTurn = ""; _dateState = ""; _dateAssets?.Bookmarks.Remove(_dateOffer); if (_dateView != null) _dateView.Editor.Text = ""; if (_privateInput != null && IsInstanceValid(_privateInput)) _privateInput.Text = ""; _privateDrafts.Remove(_datePerson); TickDateScene(); })`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateCommand("dm-date-revise", new() { Entry = _dateEditingTurn, Text = _dateView.Editor.Text }, () => { _dateManualGameInput = false; _dateEditingTurn = ""; _dateState = ""; _dateAssets?.Bookmarks.Remove(_dateOffer); if (_dateView != null) _dateView.Editor.Text = ""; if (_privateInput != null && IsInstanceValid(_privateInput)) _privateInput.Text = ""; _privateDrafts.Remove(_datePerson); TickDateScene(); });`
- `NationalSpire.CareerScreen.SendPrivate()`；输入表达式：`SendPrivate()`；返回值紧邻使用处：`ExpressionStatementSyntax: SendPrivate();`
- `NationalSpire.CareerScreen.TickDateScene()`；输入表达式：`TickDateScene()`；返回值紧邻使用处：`ExpressionStatementSyntax: TickDateScene();`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Entry = _dateEditingTurn, Text = _dateView.Editor.Text }`；返回值紧邻使用处：`ArgumentSyntax: new() { Entry = _dateEditingTurn, Text = _dateView.Editor.Text }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`.Bookmarks.Remove(_dateOffer)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _dateAssets?.Bookmarks.Remove(_dateOffer)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`_privateDrafts.Remove(_datePerson)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateDrafts.Remove(_datePerson);`

**赋值（含属性/字段和局部值）：**

- `Entry` = `_dateEditingTurn`
- `Text` = `_dateView.Editor.Text`
- `_dateEditingTurn` = `""`
- `_dateManualGameInput` = `false`
- `_dateState` = `""`
- `_dateView.Editor.Text` = `""`
- `_privateInput!.Text` = `_dateView.Editor.Text`
- `_privateInput.Text` = `""`

<a id="symbol-270cb56b5044"></a>

## `NationalSpire.CareerScreen.CanEditPreviousDate(NationalSpire.PrivateTurn?) — private bool CanEditPreviousDate(PrivateTurn? turn)`

来源：源码第 352 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.EditPreviousDateScene()`](DateSceneScreen.cs.md#symbol-68bbfe92ebcf)；[`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._dateOffer`；`NationalSpire.DateSceneRequest.Ending`；`NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.DateSceneRequest.Opening`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.RequestKind`；`NationalSpire.PrivateTurn.Scene`；`NationalSpire.PrivateTurn.Status`；`NationalSpire.PrivateTurn.UserDeleted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-68bbfe92ebcf"></a>

## `NationalSpire.CareerScreen.EditPreviousDateScene() — private void EditPreviousDateScene()`

来源：源码第 355 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.TextEdit.GetCaretLine(int)`；`Godot.TextEdit.GetLine(int)`；`Godot.TextEdit.GetLineCount()`；`Godot.TextEdit.SetCaretColumn(int, bool, int)`；`Godot.TextEdit.SetCaretLine(int, bool, bool, int, int)`；[`NationalSpire.CareerScreen.CanEditPreviousDate(NationalSpire.PrivateTurn?)`](DateSceneScreen.cs.md#symbol-270cb56b5044)；[`NationalSpire.CareerScreen.PrivateAttachmentCard(NationalSpire.PrivateOffer, bool)`](PrivateMemoryScreen.cs.md#symbol-eb2b2a37c5d1)；[`NationalSpire.CareerScreen.ShowDateInput(bool, bool)`](DateGameScreen.cs.md#symbol-f7a3691c9897)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`NationalSpire.DateSceneView.ShowAttachments()`](DateSceneView.cs.md#symbol-f99d5e4e9b59)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.CanEditPreviousDate(NationalSpire.PrivateTurn?)`；`NationalSpire.CareerScreen.PrivateAttachmentCard(NationalSpire.PrivateOffer, bool)`；`NationalSpire.CareerScreen.ShowDateInput(bool, bool)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._dateEditingTurn`；`NationalSpire.CareerScreen._dateManualGameInput`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.CareerScreen._privateDrafts`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.DateSceneRequest.GameEvent`；`NationalSpire.DateSceneRequest.Opening`；`NationalSpire.DateSceneView.Attachments`；`NationalSpire.DateSceneView.Editor`；`NationalSpire.DateSceneView.ShowAttachments()`；`NationalSpire.DateSceneView.Status`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateTurn.Attachments`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.PrivateTurn.Scene`；`NationalSpire.PrivateTurn.Status`；`NationalSpire.PrivateTurn.User`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_dateView.Attachments.AddChild(PrivateAttachmentCard(item, false))`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.Attachments.AddChild(PrivateAttachmentCard(item, false));`
- `Godot.TextEdit.GetCaretLine(int)`；输入表达式：`_dateView.Editor.GetCaretLine()`；返回值紧邻使用处：`ArgumentSyntax: _dateView.Editor.GetCaretLine()`
- `Godot.TextEdit.GetLine(int)`；输入表达式：`_dateView.Editor.GetLine(_dateView.Editor.GetCaretLine())`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _dateView.Editor.GetLine(_dateView.Editor.GetCaretLine()).Length`
- `Godot.TextEdit.GetLineCount()`；输入表达式：`_dateView.Editor.GetLineCount()`；返回值紧邻使用处：`BinaryExpressionSyntax: _dateView.Editor.GetLineCount() - 1`
- `Godot.TextEdit.SetCaretColumn(int, bool, int)`；输入表达式：`_dateView.Editor.SetCaretColumn(_dateView.Editor.GetLine(_dateView.Editor.GetCaretLine()).Length)`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.Editor.SetCaretColumn(_dateView.Editor.GetLine(_dateView.Editor.GetCaretLine()).Length);`
- `Godot.TextEdit.SetCaretLine(int, bool, bool, int, int)`；输入表达式：`_dateView.Editor.SetCaretLine(_dateView.Editor.GetLineCount() - 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.Editor.SetCaretLine(_dateView.Editor.GetLineCount() - 1);`
- `NationalSpire.CareerScreen.CanEditPreviousDate(NationalSpire.PrivateTurn?)`；输入表达式：`CanEditPreviousDate(turn)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CanEditPreviousDate(turn)`
- `NationalSpire.CareerScreen.PrivateAttachmentCard(NationalSpire.PrivateOffer, bool)`；输入表达式：`PrivateAttachmentCard(item, false)`；返回值紧邻使用处：`ArgumentSyntax: PrivateAttachmentCard(item, false)`
- `NationalSpire.CareerScreen.ShowDateInput(bool, bool)`；输入表达式：`ShowDateInput(keepWaiting: turn.Status == "failed")`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowDateInput(keepWaiting: turn.Status == "failed");`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(_dateView.Attachments)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(_dateView.Attachments);`
- `NationalSpire.DateSceneView.ShowAttachments()`；输入表达式：`_dateView.ShowAttachments()`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.ShowAttachments();`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(ViewData, _datePerson)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Conversation(ViewData, _datePerson).Turns`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`PrivateMessages.Conversation(ViewData, _datePerson).Turns.LastOrDefault()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(ViewData, _datePerson).Turns.LastOrDefault()`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`_privateDrafts.GetValueOrDefault(_datePerson)`；返回值紧邻使用处：`IsPatternExpressionSyntax: _privateDrafts.GetValueOrDefault(_datePerson) is { Length: > 0 } draft`

**赋值（含属性/字段和局部值）：**

- `_dateEditingTurn` = `turn!.Id`
- `_dateManualGameInput` = `false`
- `_dateView.Editor.Text` = `turn.Status == "failed" && _privateDrafts.GetValueOrDefault(_datePerson) is { Length: > 0 } draft ? draft : turn.Scene!.Opening || turn.Scene.GameEvent.Length > 0 ? "" : turn.User`
- `_dateView.Status.Text` = `"编辑后点击发送，将替换本轮回复；原附件继续保留。"`

<a id="symbol-0845ec2acab1"></a>

## `NationalSpire.CareerScreen.DateSceneSettings() — private void DateSceneSettings()`

来源：源码第 368 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`Apply()`](DateSceneScreen.cs.md#symbol-1f00e77adbe1)；[`FitSettings()`](DateSceneScreen.cs.md#symbol-fee359acff6f)；`Godot.BaseButton.SetPressedNoSignal(bool)`；`Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`；`Godot.CheckBox.CheckBox()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.HSlider.HSlider()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.OptionButton()`；`Godot.OptionButton.Select(int)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.BroadcastScroll.BroadcastScroll()`；[`NationalSpire.CareerScreen.AddDateMemorySetting(Godot.VBoxContainer)`](DateSceneMemoryScreen.cs.md#symbol-e85e0fc39965)；[`NationalSpire.CareerScreen.AddDatePortraitSettings(Godot.VBoxContainer, NationalSpire.CareerData)`](DateScenePortraitSettings.cs.md#symbol-354a9a454cf2)；[`NationalSpire.CareerScreen.AddDateVoiceSettings(Godot.VBoxContainer)`](DateGameScreen.cs.md#symbol-ad300bbb552d)；[`NationalSpire.CareerScreen.ApplyDatePortraitPlacements()`](DateScenePortraitSettings.cs.md#symbol-9e6a2d77a042)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.ConfigureDatePresentation(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>, System.Action, System.Action, bool)`](DatePresentationScreen.cs.md#symbol-ae7a16c86641)；[`NationalSpire.CareerScreen.DateParticipants()`](DateScenePartyScreen.cs.md#symbol-658316b8bf70)；[`NationalSpire.CareerScreen.LoadDateParty(NationalSpire.CareerData, string, string)`](DateScenePartyScreen.cs.md#symbol-e7d1a77e170a)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.PartyTexture(string, string)`](DateScenePartyScreen.cs.md#symbol-53bfcf8e2a43)；[`NationalSpire.CareerScreen.PickNestedFile(string, string[], System.Action<string>, System.Action<string[]>?)`](CareerFilePicker.cs.md#symbol-ca0ccac08c64)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.CareerScreen.ShowDateLine()`](DateSceneScreen.cs.md#symbol-1580b0be190e)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`](CareerStore.cs.md#symbol-ead7461ee7cb)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.DateGames.InProgress(NationalSpire.CareerData, string, string)`](DateGames.cs.md#symbol-a63bde99754a)；[`NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`](DateSceneAssets.cs.md#symbol-57fe620f4cc9)；[`NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`](DateSceneAssets.cs.md#symbol-2bf1f40a912e)；[`NationalSpire.DateSceneBackgrounds.Closest(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneBackground>, string, string)`](DateSceneBackgrounds.cs.md#symbol-fe6e9e9ebd7b)；[`NationalSpire.DateSceneBackgrounds.Import(string)`](DateSceneBackgrounds.cs.md#symbol-2c3c4974b94b)；[`NationalSpire.DateSceneBackgrounds.Read(out string, string?)`](DateSceneBackgrounds.cs.md#symbol-b6c3bc7d87d9)；[`NationalSpire.DateSceneBackgrounds.Remove(string)`](DateSceneBackgrounds.cs.md#symbol-b7d6d0097052)；`NationalSpire.DateSceneCast.DateSceneCast(string, string, System.Func<Godot.Texture2D>)`；[`NationalSpire.DateSceneView.SetCast(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneCast>)`](DateSceneCast.cs.md#symbol-913514fd78e1)；[`NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`](PortraitDesignStore.cs.md#symbol-8db102d73ed8)；[`NationalSpire.PortraitDesignStore.Read(string, string)`](PortraitDesignStore.cs.md#symbol-2eeba99f517d)；[`PopulateBackgrounds()`](DateSceneScreen.cs.md#symbol-bb23956847a8)；[`Save()`](DateSceneScreen.cs.md#symbol-5e2413f0aa95)；`System.Action.Invoke()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Math.Clamp(float, float, float)`；`System.Math.Clamp(int, int, int)`

**字段、属性、事件及方法组引用：** `Apply()`；`FitSettings()`；`NationalSpire.CareerMatch.DateGame`；`NationalSpire.CareerScreen.AddDateMemorySetting(Godot.VBoxContainer)`；`NationalSpire.CareerScreen.AddDatePortraitSettings(Godot.VBoxContainer, NationalSpire.CareerData)`；`NationalSpire.CareerScreen.AddDateVoiceSettings(Godot.VBoxContainer)`；`NationalSpire.CareerScreen.ApplyDatePortraitPlacements()`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.ConfigureDatePresentation(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>, System.Action, System.Action, bool)`；`NationalSpire.CareerScreen.DateParticipants()`；`NationalSpire.CareerScreen.LoadDateParty(NationalSpire.CareerData, string, string)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.PartyTexture(string, string)`；`NationalSpire.CareerScreen.PickNestedFile(string, string[], System.Action<string>, System.Action<string[]>?)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.ShowDateLine()`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._cancelDialog`；`NationalSpire.CareerScreen._dateAssets`；`NationalSpire.CareerScreen._dateBackground`；`NationalSpire.CareerScreen._dateBackgrounds`；`NationalSpire.CareerScreen._dateDesign`；`NationalSpire.CareerScreen._dateIndex`；`NationalSpire.CareerScreen._dateLines`；`NationalSpire.CareerScreen._dateOffer`；`NationalSpire.CareerScreen._datePartyArt`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._stage`；`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.DateGameState.Voices`；`NationalSpire.DateGames.InProgress(NationalSpire.CareerData, string, string)`；`NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`；`NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`；`NationalSpire.DateSceneAssets.AutoBackground`；`NationalSpire.DateSceneAssets.Background`；`NationalSpire.DateSceneAssets.BlurAmount`；`NationalSpire.DateSceneAssets.FontSize`；`NationalSpire.DateSceneAssets.GameVoice`；`NationalSpire.DateSceneAssets.LetterSpacing`；`NationalSpire.DateSceneAssets.PanelFade`；`NationalSpire.DateSceneAssets.ShowAffectionBadge`；`NationalSpire.DateSceneAssets.TextOutline`；`NationalSpire.DateSceneAssets.TextSpeed`；`NationalSpire.DateSceneBackground.Id`；`NationalSpire.DateSceneBackgrounds.Closest(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneBackground>, string, string)`；`NationalSpire.DateSceneBackgrounds.Import(string)`；`NationalSpire.DateSceneBackgrounds.Read(out string, string?)`；`NationalSpire.DateSceneBackgrounds.Remove(string)`；`NationalSpire.DateSceneParticipant.DefaultEmotionId`；`NationalSpire.DateSceneParticipant.Name`；`NationalSpire.DateSceneParticipant.PersonId`；`NationalSpire.DateSceneView.InputMode`；`NationalSpire.DateSceneView.InstantSpeed`；`NationalSpire.DateSceneView.SetCast(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneCast>)`；`NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`；`NationalSpire.PortraitDesignStore.Read(string, string)`；`PopulateBackgrounds()`；`Save()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Apply()`；输入表达式：`Apply()`；返回值紧邻使用处：`ExpressionStatementSyntax: Apply();`
- `FitSettings()`；输入表达式：`FitSettings()`；返回值紧邻使用处：`ExpressionStatementSyntax: FitSettings();`
- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`auto.SetPressedNoSignal(false)`；返回值紧邻使用处：`ExpressionStatementSyntax: auto.SetPressedNoSignal(false);`
- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(() => { if (_dateView == null || !CareerStore.IsCurrent(data)) return; ConfigureDatePresentation(data, _datePartyArt.Keys.ToArray(), () => { if (_dateView == null) return; _dateDesign = PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person); _dateAssets = DateSceneAssetStore.Read(data, person); LoadDateParty(data, person, _dateOffer); _dateView.SetCast(DateParticipants().Select(p => new DateSceneCast(p.PersonId, p.Name, () => PartyTexture(p.PersonId, p.DefaultEmotionId)))); ApplyDatePortraitPlacements(); if (DateGames.InProgress(data, person, _dateOffer)?.DateGame is { } game) { foreach (var p in _datePartyArt) game.Voices[p.Key] = p.Value.Assets.GameVoice; CareerStore.Save(data); } if (!_dateView.InputMode && _dateLines.Count > 0) ShowDateLine(); }, () => { }, firstOnly: false); }).CallDeferred()`；返回值紧邻使用处：`ExpressionStatementSyntax: Callable.From(() => { if (_dateView == null || !CareerStore.IsCurrent(data)) return; ConfigureDatePresentation(data, _datePartyArt.Keys.ToArray(), () => { if (_dateView == null) return; _dateDesign = PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person); _dateAssets = DateSceneAssetStore.Read(data, person); LoadDateParty(data, person, _dateOffer); _dateView.SetCast(DateParticipants().Select(p => new DateSceneCast(p.PersonId, p.Name, () => PartyTexture(p.PersonId, p.DefaultEmotionId)))); ApplyDatePortraitPlacements(); if (DateGames.InProgress(data, person, _dateOffer)?.DateGame is { } game) { foreach (var p in _datePartyArt) game.Voices[p.Key] = p.Value.Assets.GameVoice; CareerStore.Save(data); } if (!_dateView.InputMode && _dateLines.Count > 0) ShowDateLine(); }, () => { }, firstOnly: false); }).CallDeferred();`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(() => { if (_dateView == null || !CareerStore.IsCurrent(data)) return; ConfigureDatePresentation(data, _datePartyArt.Keys.ToArray(), () => { if (_dateView == null) return; _dateDesign = PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person); _dateAssets = DateSceneAssetStore.Read(data, person); LoadDateParty(data, person, _dateOffer); _dateView.SetCast(DateParticipants().Select(p => new DateSceneCast(p.PersonId, p.Name, () => PartyTexture(p.PersonId, p.DefaultEmotionId)))); ApplyDatePortraitPlacements(); if (DateGames.InProgress(data, person, _dateOffer)?.DateGame is { } game) { foreach (var p in _datePartyArt) game.Voices[p.Key] = p.Value.Assets.GameVoice; CareerStore.Save(data); } if (!_dateView.InputMode && _dateLines.Count > 0) ShowDateLine(); }, () => { }, firstOnly: false); })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(() => { if (_dateView == null || !CareerStore.IsCurrent(data)) return; ConfigureDatePresentation(data, _datePartyArt.Keys.ToArray(), () => { if (_dateView == null) return; _dateDesign = PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person); _dateAssets = DateSceneAssetStore.Read(data, person); LoadDateParty(data, person, _dateOffer); _dateView.SetCast(DateParticipants().Select(p => new DateSceneCast(p.PersonId, p.Name, () => PartyTexture(p.PersonId, p.DefaultEmotionId)))); ApplyDatePortraitPlacements(); if (DateGames.InProgress(data, person, _dateOffer)?.DateGame is { } game) { foreach (var p in _datePartyArt) game.Voices[p.Key] = p.Value.Assets.GameVoice; CareerStore.Save(data); } if (!_dateView.InputMode && _dateLines.Count > 0) ShowDateLine(); }, () => { }, firstOnly: false); }).CallDeferred`
- `Godot.CheckBox.CheckBox()`；输入表达式：`new CheckBox { Name = "DateAutoBackground", Text = "根据场景和时间自动切换背景", ButtonPressed = assets.AutoBackground }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CheckBox { Name = "DateAutoBackground", Text = "根据场景和时间自动切换背景", ButtonPressed = assets.AutoBackground }`
- `Godot.CheckBox.CheckBox()`；输入表达式：`new CheckBox { Name = "DateShowAffection", Text = "显示好感徽章", ButtonPressed = assets.ShowAffectionBadge, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(292, 0) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CheckBox { Name = "DateShowAffection", Text = "显示好感徽章", ButtonPressed = assets.ShowAffectionBadge, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(292, 0) }`
- `Godot.CheckBox.CheckBox()`；输入表达式：`new CheckBox { Name = "DateTextOutline", Text = "正文黑色描边", ButtonPressed = assets.TextOutline, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(292, 0) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CheckBox { Name = "DateTextOutline", Text = "正文黑色描边", ButtonPressed = assets.TextOutline, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(292, 0) }`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`backgroundActions.AddThemeConstantOverride("separation", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: backgroundActions.AddThemeConstantOverride("separation", 18);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation", 14);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`switches.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: switches.AddThemeConstantOverride("separation", 16);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.HSlider.HSlider()`；输入表达式：`new HSlider { Name = "DateBlurAmount", MinValue = 0, MaxValue = 20, Step = 0, Value = assets.BlurAmount, CustomMinimumSize = new(600, 35) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HSlider { Name = "DateBlurAmount", MinValue = 0, MaxValue = 20, Step = 0, Value = assets.BlurAmount, CustomMinimumSize = new(600, 35) }`
- `Godot.HSlider.HSlider()`；输入表达式：`new HSlider { Name = "DateLetterSpacing", MinValue = 0, MaxValue = 3, Step = .05, Value = assets.LetterSpacing, CustomMinimumSize = new(600, 35) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HSlider { Name = "DateLetterSpacing", MinValue = 0, MaxValue = 3, Step = .05, Value = assets.LetterSpacing, CustomMinimumSize = new(600, 35) }`
- `Godot.HSlider.HSlider()`；输入表达式：`new HSlider { Name = "DatePanelFade", MinValue = 0, MaxValue = 1, Step = 0, Value = assets.PanelFade, CustomMinimumSize = new(600, 35) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HSlider { Name = "DatePanelFade", MinValue = 0, MaxValue = 1, Step = 0, Value = assets.PanelFade, CustomMinimumSize = new(600, 35) }`
- `Godot.HSlider.HSlider()`；输入表达式：`new HSlider { Name = "DateTextSpeed", MinValue = 5, MaxValue = DateSceneView.InstantSpeed, Step = 0, Value = assets.TextSpeed, CustomMinimumSize = new(600, 35) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HSlider { Name = "DateTextSpeed", MinValue = 5, MaxValue = DateSceneView.InstantSpeed, Step = 0, Value = assets.TextSpeed, CustomMinimumSize = new(600, 35) }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`backgroundActions.AddChild(Button("导入背景图片 / ZIP背景包", () => PickNestedFile("导入背景", [".png", ".jpg", ".jpeg", ".webp", ".zip"], path => { try { assets.Background = DateSceneBackgrounds.Import(path); _dateBackgrounds = DateSceneBackgrounds.Read(out _); assets.AutoBackground = false; auto.SetPressedNoSignal(false); Save(); PopulateBackgrounds(); } catch (Exception e) { Notice("背景导入失败：" + e.Message, true); } }), 350))`；返回值紧邻使用处：`ExpressionStatementSyntax: backgroundActions.AddChild(Button("导入背景图片 / ZIP背景包", () => PickNestedFile("导入背景", [".png", ".jpg", ".jpeg", ".webp", ".zip"], path => { try { assets.Background = DateSceneBackgrounds.Import(path); _dateBackgrounds = DateSceneBackgrounds.Read(out _); assets.AutoBackground = false; auto.SetPressedNoSignal(false); Save(); PopulateBackgrounds(); } catch (Exception e) { Notice("背景导入失败：" + e.Message, true); } }), 350));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`backgroundActions.AddChild(removeBackground)`；返回值紧邻使用处：`ExpressionStatementSyntax: backgroundActions.AddChild(removeBackground);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Button("从本轮第一句重看", () => { _dateIndex = 0; ShowDateLine(); _cancelDialog?.Invoke(); }, 240))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Button("从本轮第一句重看", () => { _dateIndex = 0; ShowDateLine(); _cancelDialog?.Invoke(); }, 240));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Button("选择约会立绘与播报口吻", () => { _cancelDialog?.Invoke(); Callable.From(() => { if (_dateView == null || !CareerStore.IsCurrent(data)) return; ConfigureDatePresentation(data, _datePartyArt.Keys.ToArray(), () => { if (_dateView == null) return; _dateDesign = PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person); _dateAssets = DateSceneAssetStore.Read(data, person); LoadDateParty(data, person, _dateOffer); _dateView.SetCast(DateParticipants().Select(p => new DateSceneCast(p.PersonId, p.Name, () => PartyTexture(p.PersonId, p.DefaultEmotionId)))); ApplyDatePortraitPlacements(); if (DateGames.InProgress(data, person, _dateOffer)?.DateGame is { } game) { foreach (var p in _datePartyArt) game.Voices[p.Key] = p.Value.Assets.GameVoice; CareerStore.Save(data); } if (!_dateView.InputMode && _dateLines.Count > 0) ShowDateLine(); }, () => { }, firstOnly: false); }).CallDeferred(); }, 360))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Button("选择约会立绘与播报口吻", () => { _cancelDialog?.Invoke(); Callable.From(() => { if (_dateView == null || !CareerStore.IsCurrent(data)) return; ConfigureDatePresentation(data, _datePartyArt.Keys.ToArray(), () => { if (_dateView == null) return; _dateDesign = PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person); _dateAssets = DateSceneAssetStore.Read(data, person); LoadDateParty(data, person, _dateOffer); _dateView.SetCast(DateParticipants().Select(p => new DateSceneCast(p.PersonId, p.Name, () => PartyTexture(p.PersonId, p.DefaultEmotionId)))); ApplyDatePortraitPlacements(); if (DateGames.InProgress(data, person, _dateOffer)?.DateGame is { } game) { foreach (var p in _datePartyArt) game.Voices[p.Key] = p.Value.Assets.GameVoice; CareerStore.Save(data); } if (!_dateView.InputMode && _dateLines.Count > 0) ShowDateLine(); }, () => { }, firstOnly: false); }).CallDeferred(); }, 360));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text("字体大小", 18, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text("字体大小", 18, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(auto)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(auto);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(backgroundActions)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(backgroundActions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(blurAmount)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(blurAmount);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(blurLabel)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(blurLabel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(choices)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(choices);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(fade)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(fade);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(fadeLabel)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(fadeLabel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(fonts)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(fonts);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(spacing)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(spacing);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(spacingLabel)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(spacingLabel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(speed)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(speed);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(speedLabel)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(speedLabel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(switches)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(switches);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`outer.AddChild(scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: outer.AddChild(scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scroll.AddChild(box)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.AddChild(box);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`switches.AddChild(affection)`；返回值紧邻使用处：`ExpressionStatementSyntax: switches.AddChild(affection);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`switches.AddChild(outline)`；返回值紧邻使用处：`ExpressionStatementSyntax: switches.AddChild(outline);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`fonts.AddItem(label)`；返回值紧邻使用处：`ExpressionStatementSyntax: fonts.AddItem(label);`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { Name = "DateBackgroundChoice", CustomMinimumSize = new(0, 40), FitToLongestItem = false }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { Name = "DateBackgroundChoice", CustomMinimumSize = new(0, 40), FitToLongestItem = false }`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { Name = "DateFontSize", CustomMinimumSize = new(0, 42) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { Name = "DateFontSize", CustomMinimumSize = new(0, 42) }`
- `Godot.OptionButton.Select(int)`；输入表达式：`fonts.Select(Math.Clamp(assets.FontSize, 0, 2))`；返回值紧邻使用处：`ExpressionStatementSyntax: fonts.Select(Math.Clamp(assets.FontSize, 0, 2));`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 40)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 40)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 42)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(292, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(292, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(600, 35)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(600, 35)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(660, Math.Clamp(_stage.Size.Y - 300, 330, 540))`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(660, Math.Clamp(_stage.Size.Y - 300, 330, 540))`
- `NationalSpire.BroadcastScroll.BroadcastScroll()`；输入表达式：`new BroadcastScroll { Name = "DateSettingsScroll", CustomMinimumSize = new(660, Math.Clamp(_stage.Size.Y - 300, 330, 540)), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastScroll { Name = "DateSettingsScroll", CustomMinimumSize = new(660, Math.Clamp(_stage.Size.Y - 300, 330, 540)), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `NationalSpire.CareerScreen.AddDateMemorySetting(Godot.VBoxContainer)`；输入表达式：`AddDateMemorySetting(box)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddDateMemorySetting(box);`
- `NationalSpire.CareerScreen.AddDatePortraitSettings(Godot.VBoxContainer, NationalSpire.CareerData)`；输入表达式：`AddDatePortraitSettings(box, data)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddDatePortraitSettings(box, data);`
- `NationalSpire.CareerScreen.AddDateVoiceSettings(Godot.VBoxContainer)`；输入表达式：`AddDateVoiceSettings(box)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddDateVoiceSettings(box);`
- `NationalSpire.CareerScreen.ApplyDatePortraitPlacements()`；输入表达式：`ApplyDatePortraitPlacements()`；返回值紧邻使用处：`ExpressionStatementSyntax: ApplyDatePortraitPlacements();`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("从本轮第一句重看", () => { _dateIndex = 0; ShowDateLine(); _cancelDialog?.Invoke(); }, 240)`；返回值紧邻使用处：`ArgumentSyntax: Button("从本轮第一句重看", () => { _dateIndex = 0; ShowDateLine(); _cancelDialog?.Invoke(); }, 240)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("删除当前背景", () => { if (_dateBackground.Length == 0) return; try { DateSceneBackgrounds.Remove(_dateBackground); _dateBackgrounds = DateSceneBackgrounds.Read(out _); assets.Background = DateSceneBackgrounds.Closest(_dateBackgrounds, "", ""); Save(); PopulateBackgrounds(); } catch (Exception e) { Notice("背景删除失败：" + e.Message, true); } }, 180)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("删除当前背景", () => { if (_dateBackground.Length == 0) return; try { DateSceneBackgrounds.Remove(_dateBackground); _dateBackgrounds = DateSceneBackgrounds.Read(out _); assets.Background = DateSceneBackgrounds.Closest(_dateBackgrounds, "", ""); Save(); PopulateBackgrounds(); } catch (Exception e) { Notice("背景删除失败：" + e.Message, true); } }, 180)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("导入背景图片 / ZIP背景包", () => PickNestedFile("导入背景", [".png", ".jpg", ".jpeg", ".webp", ".zip"], path => { try { assets.Background = DateSceneBackgrounds.Import(path); _dateBackgrounds = DateSceneBackgrounds.Read(out _); assets.AutoBackground = false; auto.SetPressedNoSignal(false); Save(); PopulateBackgrounds(); } catch (Exception e) { Notice("背景导入失败：" + e.Message, true); } }), 350)`；返回值紧邻使用处：`ArgumentSyntax: Button("导入背景图片 / ZIP背景包", () => PickNestedFile("导入背景", [".png", ".jpg", ".jpeg", ".webp", ".zip"], path => { try { assets.Background = DateSceneBackgrounds.Import(path); _dateBackgrounds = DateSceneBackgrounds.Read(out _); assets.AutoBackground = false; auto.SetPressedNoSignal(false); Save(); PopulateBackgrounds(); } catch (Exception e) { Notice("背景导入失败：" + e.Message, true); } }), 350)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("选择约会立绘与播报口吻", () => { _cancelDialog?.Invoke(); Callable.From(() => { if (_dateView == null || !CareerStore.IsCurrent(data)) return; ConfigureDatePresentation(data, _datePartyArt.Keys.ToArray(), () => { if (_dateView == null) return; _dateDesign = PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person); _dateAssets = DateSceneAssetStore.Read(data, person); LoadDateParty(data, person, _dateOffer); _dateView.SetCast(DateParticipants().Select(p => new DateSceneCast(p.PersonId, p.Name, () => PartyTexture(p.PersonId, p.DefaultEmotionId)))); ApplyDatePortraitPlacements(); if (DateGames.InProgress(data, person, _dateOffer)?.DateGame is { } game) { foreach (var p in _datePartyArt) game.Voices[p.Key] = p.Value.Assets.GameVoice; CareerStore.Save(data); } if (!_dateView.InputMode && _dateLines.Count > 0) ShowDateLine(); }, () => { }, firstOnly: false); }).CallDeferred(); }, 360)`；返回值紧邻使用处：`ArgumentSyntax: Button("选择约会立绘与播报口吻", () => { _cancelDialog?.Invoke(); Callable.From(() => { if (_dateView == null || !CareerStore.IsCurrent(data)) return; ConfigureDatePresentation(data, _datePartyArt.Keys.ToArray(), () => { if (_dateView == null) return; _dateDesign = PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person); _dateAssets = DateSceneAssetStore.Read(data, person); LoadDateParty(data, person, _dateOffer); _dateView.SetCast(DateParticipants().Select(p => new DateSceneCast(p.PersonId, p.Name, () => PartyTexture(p.PersonId, p.DefaultEmotionId)))); ApplyDatePortraitPlacements(); if (DateGames.InProgress(data, person, _dateOffer)?.DateGame is { } game) { foreach (var p in _datePartyArt) game.Voices[p.Key] = p.Value.Assets.GameVoice; CareerStore.Save(data); } if (!_dateView.InputMode && _dateLines.Count > 0) ShowDateLine(); }, () => { }, firstOnly: false); }).CallDeferred(); }, 360)`
- `NationalSpire.CareerScreen.ConfigureDatePresentation(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>, System.Action, System.Action, bool)`；输入表达式：`ConfigureDatePresentation(data, _datePartyArt.Keys.ToArray(), () => { if (_dateView == null) return; _dateDesign = PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person); _dateAssets = DateSceneAssetStore.Read(data, person); LoadDateParty(data, person, _dateOffer); _dateView.SetCast(DateParticipants().Select(p => new DateSceneCast(p.PersonId, p.Name, () => PartyTexture(p.PersonId, p.DefaultEmotionId)))); ApplyDatePortraitPlacements(); if (DateGames.InProgress(data, person, _dateOffer)?.DateGame is { } game) { foreach (var p in _datePartyArt) game.Voices[p.Key] = p.Value.Assets.GameVoice; CareerStore.Save(data); } if (!_dateView.InputMode && _dateLines.Count > 0) ShowDateLine(); }, () => { }, firstOnly: false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ConfigureDatePresentation(data, _datePartyArt.Keys.ToArray(), () => { if (_dateView == null) return; _dateDesign = PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person); _dateAssets = DateSceneAssetStore.Read(data, person); LoadDateParty(data, person, _dateOffer); _dateView.SetCast(DateParticipants().Select(p => new DateSceneCast(p.PersonId, p.Name, () => PartyTexture(p.PersonId, p.DefaultEmotionId)))); ApplyDatePortraitPlacements(); if (DateGames.InProgress(data, person, _dateOffer)?.DateGame is { } game) { foreach (var p in _datePartyArt) game.Voices[p.Key] = p.Value.Assets.GameVoice; CareerStore.Save(data); } if (!_dateView.InputMode && _dateLines.Count > 0) ShowDateLine(); }, () => { }, firstOnly: false);`
- `NationalSpire.CareerScreen.DateParticipants()`；输入表达式：`DateParticipants()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateParticipants().Select`
- `NationalSpire.CareerScreen.LoadDateParty(NationalSpire.CareerData, string, string)`；输入表达式：`LoadDateParty(data, person, _dateOffer)`；返回值紧邻使用处：`ExpressionStatementSyntax: LoadDateParty(data, person, _dateOffer);`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("背景删除失败：" + e.Message, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("背景删除失败：" + e.Message, true);`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("背景导入失败：" + e.Message, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("背景导入失败：" + e.Message, true);`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(e.Message, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(e.Message, true);`
- `NationalSpire.CareerScreen.PartyTexture(string, string)`；输入表达式：`PartyTexture(p.PersonId, p.DefaultEmotionId)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => PartyTexture(p.PersonId, p.DefaultEmotionId)`
- `NationalSpire.CareerScreen.PickNestedFile(string, string[], System.Action<string>, System.Action<string[]>?)`；输入表达式：`PickNestedFile("导入背景", [".png", ".jpg", ".jpeg", ".webp", ".zip"], path => { try { assets.Background = DateSceneBackgrounds.Import(path); _dateBackgrounds = DateSceneBackgrounds.Read(out _); assets.AutoBackground = false; auto.SetPressedNoSignal(false); Save(); PopulateBackgrounds(); } catch (Exception e) { Notice("背景导入失败：" + e.Message, true); } })`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => PickNestedFile("导入背景", [".png", ".jpg", ".jpeg", ".webp", ".zip"], path => { try { assets.Background = DateSceneBackgrounds.Import(path); _dateBackgrounds = DateSceneBackgrounds.Read(out _); assets.AutoBackground = false; auto.SetPressedNoSignal(false); Save(); PopulateBackgrounds(); } catch (Exception e) { Notice("背景导入失败：" + e.Message, true); } })`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("场景设置", "背景与显示偏好保存在本机。", () => true, "关闭", outer => { var scroll = new BroadcastScroll { Name = "DateSettingsScroll", CustomMinimumSize = new(660, Math.Clamp(_stage.Size.Y - 300, 330, 540)), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; outer.AddChild(scroll); void FitSettings() => scroll.CustomMinimumSize = new(660, Math.Clamp(_stage.Size.Y - 300, 220, 540)); _stage.Resized += FitSettings; scroll.TreeExiting += () => _stage.Resized -= FitSettings; FitSettings(); var box = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; box.AddThemeConstantOverride("separation", 14); scroll.AddChild(box); AddDateMemorySetting(box); AddDateVoiceSettings(box); box.AddChild(Button("选择约会立绘与播报口吻", () => { _cancelDialog?.Invoke(); Callable.From(() => { if (_dateView == null || !CareerStore.IsCurrent(data)) return; ConfigureDatePresentation(data, _datePartyArt.Keys.ToArray(), () => { if (_dateView == null) return; _dateDesign = PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person); _dateAssets = DateSceneAssetStore.Read(data, person); LoadDateParty(data, person, _dateOffer); _dateView.SetCast(DateParticipants().Select(p => new DateSceneCast(p.PersonId, p.Name, () => PartyTexture(p.PersonId, p.DefaultEmotionId)))); ApplyDatePortraitPlacements(); if (DateGames.InProgress(data, person, _dateOffer)?.DateGame is { } game) { foreach (var p in _datePartyArt) game.Voices[p.Key] = p.Value.Assets.GameVoice; CareerStore.Save(data); } if (!_dateView.InputMode && _dateLines.Count > 0) ShowDateLine(); }, () => { }, firstOnly: false); }).CallDeferred(); }, 360)); var auto = new CheckBox { Name = "DateAutoBackground", Text = "根据场景和时间自动切换背景", ButtonPressed = assets.AutoBackground }; box.AddChild(auto); var choices = new OptionButton { Name = "DateBackgroundChoice", CustomMinimumSize = new(0, 40), FitToLongestItem = false }; box.AddChild(choices); void PopulateBackgrounds() { choices.Clear(); foreach (var item in _dateBackgrounds) choices.AddItem(item.Id + " · " + item.Description); if (_dateBackgrounds.Count == 0) { choices.AddItem("请导入背景图片或ZIP背景包"); choices.SetItemDisabled(0, true); } choices.Select(Math.Max(0, _dateBackgrounds.FindIndex(b => b.Id == _dateBackground))); } choices.ItemSelected += index => { assets.Background = _dateBackgrounds[(int)index].Id; assets.AutoBackground = false; auto.SetPressedNoSignal(false); Save(); }; PopulateBackgrounds(); auto.Toggled += value => { assets.AutoBackground = value; Save(); PopulateBackgrounds(); }; var backgroundActions = new HBoxContainer(); backgroundActions.AddThemeConstantOverride("separation", 18); box.AddChild(backgroundActions); backgroundActions.AddChild(Button("导入背景图片 / ZIP背景包", () => PickNestedFile("导入背景", [".png", ".jpg", ".jpeg", ".webp", ".zip"], path => { try { assets.Background = DateSceneBackgrounds.Import(path); _dateBackgrounds = DateSceneBackgrounds.Read(out _); assets.AutoBackground = false; auto.SetPressedNoSignal(false); Save(); PopulateBackgrounds(); } catch (Exception e) { Notice("背景导入失败：" + e.Message, true); } }), 350)); var removeBackground = Button("删除当前背景", () => { if (_dateBackground.Length == 0) return; try { DateSceneBackgrounds.Remove(_dateBackground); _dateBackgrounds = DateSceneBackgrounds.Read(out _); assets.Background = DateSceneBackgrounds.Closest(_dateBackgrounds, "", ""); Save(); PopulateBackgrounds(); } catch (Exception e) { Notice("背景删除失败：" + e.Message, true); } }, 180); removeBackground.Name = "DateBackgroundDelete"; backgroundActions.AddChild(removeBackground); var blurLabel = Text($"模糊强度 · {assets.BlurAmount:F1}", 18, _ink); box.AddChild(blurLabel); var blurAmount = new HSlider { Name = "DateBlurAmount", MinValue = 0, MaxValue = 20, Step = 0, Value = assets.BlurAmount, CustomMinimumSize = new(600, 35) }; box.AddChild(blurAmount); blurAmount.ValueChanged += value => { assets.BlurAmount = value; blurLabel.Text = $"模糊强度 · {value:F1}"; Apply(); }; blurAmount.DragEnded += changed => { if (changed) Save(); }; var fonts = new OptionButton { Name = "DateFontSize", CustomMinimumSize = new(0, 42) }; foreach (string label in new[] { "小号", "中号（默认）", "大号" }) fonts.AddItem(label); fonts.Select(Math.Clamp(assets.FontSize, 0, 2)); box.AddChild(Text("字体大小", 18, _ink)); box.AddChild(fonts); fonts.ItemSelected += value => { assets.FontSize = (int)value; Save(); }; var spacingLabel = Text($"字间距 · 额外增加 {assets.LetterSpacing:P0}", 18, _ink); box.AddChild(spacingLabel); var spacing = new HSlider { Name = "DateLetterSpacing", MinValue = 0, MaxValue = 3, Step = .05, Value = assets.LetterSpacing, CustomMinimumSize = new(600, 35) }; box.AddChild(spacing); spacing.TooltipText = "0% 使用原始间距；默认增加100%，约为原字间留白的两倍。"; spacing.ValueChanged += value => { assets.LetterSpacing = value; spacingLabel.Text = $"字间距 · 额外增加 {value:P0}"; Apply(); }; spacing.DragEnded += changed => { if (changed) Save(); }; var switches = new HBoxContainer(); switches.AddThemeConstantOverride("separation", 16); box.AddChild(switches); var outline = new CheckBox { Name = "DateTextOutline", Text = "正文黑色描边", ButtonPressed = assets.TextOutline, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(292, 0) }; switches.AddChild(outline); var affection = new CheckBox { Name = "DateShowAffection", Text = "显示好感徽章", ButtonPressed = assets.ShowAffectionBadge, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(292, 0) }; switches.AddChild(affection); outline.Toggled += value => { assets.TextOutline = value; Save(); }; affection.Toggled += value => { assets.ShowAffectionBadge = value; Save(); }; AddDatePortraitSettings(box, data); var speedLabel = Text("文字速度 · 滑到最右立即显示全文", 18, _ink); box.AddChild(speedLabel); var speed = new HSlider { Name = "DateTextSpeed", MinValue = 5, MaxValue = DateSceneView.InstantSpeed, Step = 0, Value = assets.TextSpeed, CustomMinimumSize = new(600, 35) }; box.AddChild(speed); speed.ValueChanged += value => { assets.TextSpeed = value; speedLabel.Text = value >= DateSceneView.InstantSpeed ? "文字速度 · 立即显示全文" : $"文字速度 · {value:F0}字/秒"; Apply(); }; var fadeLabel = Text("文本框不透明度 · 底部100% / 上缘75% → 底部50% / 上缘0%\n上缘位于顶部下方15像素，顶部始终完全透明。", 16, _ink); box.AddChild(fadeLabel); var fade = new HSlider { Name = "DatePanelFade", MinValue = 0, MaxValue = 1, Step = 0, Value = assets.PanelFade, CustomMinimumSize = new(600, 35) }; box.AddChild(fade); fade.ValueChanged += value => { assets.PanelFade = value; Apply(); }; speed.DragEnded += changed => { if (changed) Save(); }; fade.DragEnded += changed => { if (changed) Save(); }; box.AddChild(Button("从本轮第一句重看", () => { _dateIndex = 0; ShowDateLine(); _cancelDialog?.Invoke(); }, 240)); }, showCancel: false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("场景设置", "背景与显示偏好保存在本机。", () => true, "关闭", outer => { var scroll = new BroadcastScroll { Name = "DateSettingsScroll", CustomMinimumSize = new(660, Math.Clamp(_stage.Size.Y - 300, 330, 540)), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; outer.AddChild(scroll); void FitSettings() => scroll.CustomMinimumSize = new(660, Math.Clamp(_stage.Size.Y - 300, 220, 540)); _stage.Resized += FitSettings; scroll.TreeExiting += () => _stage.Resized -= FitSettings; FitSettings(); var box = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; box.AddThemeConstantOverride("separation", 14); scroll.AddChild(box); AddDateMemorySetting(box); AddDateVoiceSettings(box); box.AddChild(Button("选择约会立绘与播报口吻", () => { _cancelDialog?.Invoke(); Callable.From(() => { if (_dateView == null || !CareerStore.IsCurrent(data)) return; ConfigureDatePresentation(data, _datePartyArt.Keys.ToArray(), () => { if (_dateView == null) return; _dateDesign = PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person); _dateAssets = DateSceneAssetStore.Read(data, person); LoadDateParty(data, person, _dateOffer); _dateView.SetCast(DateParticipants().Select(p => new DateSceneCast(p.PersonId, p.Name, () => PartyTexture(p.PersonId, p.DefaultEmotionId)))); ApplyDatePortraitPlacements(); if (DateGames.InProgress(data, person, _dateOffer)?.DateGame is { } game) { foreach (var p in _datePartyArt) game.Voices[p.Key] = p.Value.Assets.GameVoice; CareerStore.Save(data); } if (!_dateView.InputMode && _dateLines.Count > 0) ShowDateLine(); }, () => { }, firstOnly: false); }).CallDeferred(); }, 360)); var auto = new CheckBox { Name = "DateAutoBackground", Text = "根据场景和时间自动切换背景", ButtonPressed = assets.AutoBackground }; box.AddChild(auto); var choices = new OptionButton { Name = "DateBackgroundChoice", CustomMinimumSize = new(0, 40), FitToLongestItem = false }; box.AddChild(choices); void PopulateBackgrounds() { choices.Clear(); foreach (var item in _dateBackgrounds) choices.AddItem(item.Id + " · " + item.Description); if (_dateBackgrounds.Count == 0) { choices.AddItem("请导入背景图片或ZIP背景包"); choices.SetItemDisabled(0, true); } choices.Select(Math.Max(0, _dateBackgrounds.FindIndex(b => b.Id == _dateBackground))); } choices.ItemSelected += index => { assets.Background = _dateBackgrounds[(int)index].Id; assets.AutoBackground = false; auto.SetPressedNoSignal(false); Save(); }; PopulateBackgrounds(); auto.Toggled += value => { assets.AutoBackground = value; Save(); PopulateBackgrounds(); }; var backgroundActions = new HBoxContainer(); backgroundActions.AddThemeConstantOverride("separation", 18); box.AddChild(backgroundActions); backgroundActions.AddChild(Button("导入背景图片 / ZIP背景包", () => PickNestedFile("导入背景", [".png", ".jpg", ".jpeg", ".webp", ".zip"], path => { try { assets.Background = DateSceneBackgrounds.Import(path); _dateBackgrounds = DateSceneBackgrounds.Read(out _); assets.AutoBackground = false; auto.SetPressedNoSignal(false); Save(); PopulateBackgrounds(); } catch (Exception e) { Notice("背景导入失败：" + e.Message, true); } }), 350)); var removeBackground = Button("删除当前背景", () => { if (_dateBackground.Length == 0) return; try { DateSceneBackgrounds.Remove(_dateBackground); _dateBackgrounds = DateSceneBackgrounds.Read(out _); assets.Background = DateSceneBackgrounds.Closest(_dateBackgrounds, "", ""); Save(); PopulateBackgrounds(); } catch (Exception e) { Notice("背景删除失败：" + e.Message, true); } }, 180); removeBackground.Name = "DateBackgroundDelete"; backgroundActions.AddChild(removeBackground); var blurLabel = Text($"模糊强度 · {assets.BlurAmount:F1}", 18, _ink); box.AddChild(blurLabel); var blurAmount = new HSlider { Name = "DateBlurAmount", MinValue = 0, MaxValue = 20, Step = 0, Value = assets.BlurAmount, CustomMinimumSize = new(600, 35) }; box.AddChild(blurAmount); blurAmount.ValueChanged += value => { assets.BlurAmount = value; blurLabel.Text = $"模糊强度 · {value:F1}"; Apply(); }; blurAmount.DragEnded += changed => { if (changed) Save(); }; var fonts = new OptionButton { Name = "DateFontSize", CustomMinimumSize = new(0, 42) }; foreach (string label in new[] { "小号", "中号（默认）", "大号" }) fonts.AddItem(label); fonts.Select(Math.Clamp(assets.FontSize, 0, 2)); box.AddChild(Text("字体大小", 18, _ink)); box.AddChild(fonts); fonts.ItemSelected += value => { assets.FontSize = (int)value; Save(); }; var spacingLabel = Text($"字间距 · 额外增加 {assets.LetterSpacing:P0}", 18, _ink); box.AddChild(spacingLabel); var spacing = new HSlider { Name = "DateLetterSpacing", MinValue = 0, MaxValue = 3, Step = .05, Value = assets.LetterSpacing, CustomMinimumSize = new(600, 35) }; box.AddChild(spacing); spacing.TooltipText = "0% 使用原始间距；默认增加100%，约为原字间留白的两倍。"; spacing.ValueChanged += value => { assets.LetterSpacing = value; spacingLabel.Text = $"字间距 · 额外增加 {value:P0}"; Apply(); }; spacing.DragEnded += changed => { if (changed) Save(); }; var switches = new HBoxContainer(); switches.AddThemeConstantOverride("separation", 16); box.AddChild(switches); var outline = new CheckBox { Name = "DateTextOutline", Text = "正文黑色描边", ButtonPressed = assets.TextOutline, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(292, 0) }; switches.AddChild(outline); var affection = new CheckBox { Name = "DateShowAffection", Text = "显示好感徽章", ButtonPressed = assets.ShowAffectionBadge, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(292, 0) }; switches.AddChild(affection); outline.Toggled += value => { assets.TextOutline = value; Save(); }; affection.Toggled += value => { assets.ShowAffectionBadge = value; Save(); }; AddDatePortraitSettings(box, data); var speedLabel = Text("文字速度 · 滑到最右立即显示全文", 18, _ink); box.AddChild(speedLabel); var speed = new HSlider { Name = "DateTextSpeed", MinValue = 5, MaxValue = DateSceneView.InstantSpeed, Step = 0, Value = assets.TextSpeed, CustomMinimumSize = new(600, 35) }; box.AddChild(speed); speed.ValueChanged += value => { assets.TextSpeed = value; speedLabel.Text = value >= DateSceneView.InstantSpeed ? "文字速度 · 立即显示全文" : $"文字速度 · {value:F0}字/秒"; Apply(); }; var fadeLabel = Text("文本框不透明度 · 底部100% / 上缘75% → 底部50% / 上缘0%\n上缘位于顶部下方15像素，顶部始终完全透明。", 16, _ink); box.AddChild(fadeLabel); var fade = new HSlider { Name = "DatePanelFade", MinValue = 0, MaxValue = 1, Step = 0, Value = assets.PanelFade, CustomMinimumSize = new(600, 35) }; box.AddChild(fade); fade.ValueChanged += value => { assets.PanelFade = value; Apply(); }; speed.DragEnded += changed => { if (changed) Save(); }; fade.DragEnded += changed => { if (changed) Save(); }; box.AddChild(Button("从本轮第一句重看", () => { _dateIndex = 0; ShowDateLine(); _cancelDialog?.Invoke(); }, 240)); }, showCancel: false);`
- `NationalSpire.CareerScreen.ShowDateLine()`；输入表达式：`ShowDateLine()`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowDateLine();`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("字体大小", 18, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text("字体大小", 18, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("文字速度 · 滑到最右立即显示全文", 18, _ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("文字速度 · 滑到最右立即显示全文", 18, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("文本框不透明度 · 底部100% / 上缘75% → 底部50% / 上缘0%\n上缘位于顶部下方15像素，顶部始终完全透明。", 16, _ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("文本框不透明度 · 底部100% / 上缘75% → 底部50% / 上缘0%\n上缘位于顶部下方15像素，顶部始终完全透明。", 16, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"字间距 · 额外增加 {assets.LetterSpacing:P0}", 18, _ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text($"字间距 · 额外增加 {assets.LetterSpacing:P0}", 18, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"模糊强度 · {assets.BlurAmount:F1}", 18, _ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text($"模糊强度 · {assets.BlurAmount:F1}", 18, _ink)`
- `NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；输入表达式：`CareerStore.IsCurrent(data)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CareerStore.IsCurrent(data)`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(data);`
- `NationalSpire.DateGames.InProgress(NationalSpire.CareerData, string, string)`；输入表达式：`DateGames.InProgress(data, person, _dateOffer)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: DateGames.InProgress(data, person, _dateOffer)?.DateGame`
- `NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`；输入表达式：`DateSceneAssetStore.Read(data, person)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dateAssets = DateSceneAssetStore.Read(data, person)`
- `NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`；输入表达式：`DateSceneAssetStore.Save(data, person, assets)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateSceneAssetStore.Save(data, person, assets);`
- `NationalSpire.DateSceneBackgrounds.Closest(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneBackground>, string, string)`；输入表达式：`DateSceneBackgrounds.Closest(_dateBackgrounds, "", "")`；返回值紧邻使用处：`AssignmentExpressionSyntax: assets.Background = DateSceneBackgrounds.Closest(_dateBackgrounds, "", "")`
- `NationalSpire.DateSceneBackgrounds.Import(string)`；输入表达式：`DateSceneBackgrounds.Import(path)`；返回值紧邻使用处：`AssignmentExpressionSyntax: assets.Background = DateSceneBackgrounds.Import(path)`
- `NationalSpire.DateSceneBackgrounds.Read(out string, string?)`；输入表达式：`DateSceneBackgrounds.Read(out _)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dateBackgrounds = DateSceneBackgrounds.Read(out _)`
- `NationalSpire.DateSceneBackgrounds.Remove(string)`；输入表达式：`DateSceneBackgrounds.Remove(_dateBackground)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateSceneBackgrounds.Remove(_dateBackground);`
- `NationalSpire.DateSceneCast.DateSceneCast(string, string, System.Func<Godot.Texture2D>)`；输入表达式：`new DateSceneCast(p.PersonId, p.Name, () => PartyTexture(p.PersonId, p.DefaultEmotionId))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => new DateSceneCast(p.PersonId, p.Name, () => PartyTexture(p.PersonId, p.DefaultEmotionId))`
- `NationalSpire.DateSceneView.SetCast(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneCast>)`；输入表达式：`_dateView.SetCast(DateParticipants().Select(p => new DateSceneCast(p.PersonId, p.Name, () => PartyTexture(p.PersonId, p.DefaultEmotionId))))`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.SetCast(DateParticipants().Select(p => new DateSceneCast(p.PersonId, p.Name, () => PartyTexture(p.PersonId, p.DefaultEmotionId))));`
- `NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`；输入表达式：`PortraitDesignStore.FilePath(data, person)`；返回值紧邻使用处：`ArgumentSyntax: PortraitDesignStore.FilePath(data, person)`
- `NationalSpire.PortraitDesignStore.Read(string, string)`；输入表达式：`PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dateDesign = PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person)`
- `PopulateBackgrounds()`；输入表达式：`PopulateBackgrounds()`；返回值紧邻使用处：`ExpressionStatementSyntax: PopulateBackgrounds();`
- `Save()`；输入表达式：`Save()`；返回值紧邻使用处：`ExpressionStatementSyntax: Save();`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _cancelDialog?.Invoke()`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`DateParticipants().Select(p => new DateSceneCast(p.PersonId, p.Name, () => PartyTexture(p.PersonId, p.DefaultEmotionId)))`；返回值紧邻使用处：`ArgumentSyntax: DateParticipants().Select(p => new DateSceneCast(p.PersonId, p.Name, () => PartyTexture(p.PersonId, p.DefaultEmotionId)))`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`_datePartyArt.Keys.ToArray()`；返回值紧邻使用处：`ArgumentSyntax: _datePartyArt.Keys.ToArray()`
- `System.Math.Clamp(float, float, float)`；输入表达式：`Math.Clamp(_stage.Size.Y - 300, 330, 540)`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(_stage.Size.Y - 300, 330, 540)`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(assets.FontSize, 0, 2)`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(assets.FontSize, 0, 2)`

**赋值（含属性/字段和局部值）：**

- `ButtonPressed` = `assets.AutoBackground`
- `ButtonPressed` = `assets.ShowAffectionBadge`
- `ButtonPressed` = `assets.TextOutline`
- `CustomMinimumSize` = `new(0, 40)`
- `CustomMinimumSize` = `new(0, 42)`
- `CustomMinimumSize` = `new(292, 0)`
- `CustomMinimumSize` = `new(600, 35)`
- `CustomMinimumSize` = `new(660, Math.Clamp(_stage.Size.Y - 300, 330, 540))`
- `FitToLongestItem` = `false`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `MaxValue` = `1`
- `MaxValue` = `20`
- `MaxValue` = `3`
- `MaxValue` = `DateSceneView.InstantSpeed`
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
- `Name` = `"DateTextOutline"`
- `Name` = `"DateTextSpeed"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Step` = `.05`
- `Step` = `0`
- `Text` = `"显示好感徽章"`
- `Text` = `"根据场景和时间自动切换背景"`
- `Text` = `"正文黑色描边"`
- `Value` = `assets.BlurAmount`
- `Value` = `assets.LetterSpacing`
- `Value` = `assets.PanelFade`
- `Value` = `assets.TextSpeed`
- `_dateAssets` = `DateSceneAssetStore.Read(data, person)`
- `_dateBackgrounds` = `DateSceneBackgrounds.Read(out _)`
- `_dateDesign` = `PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person)`
- `_dateIndex` = `0`
- `_dialogOverlay.TreeExiting` += `() => { try { DateSceneAssetStore.Save(data, person, assets); } catch (Exception e) { Notice(e.Message, true); } }`
- `_stage.Resized` += `FitSettings`
- `_stage.Resized` -= `FitSettings`
- `affection.Toggled` += `value => { assets.ShowAffectionBadge = value; Save(); }`
- `assets.AutoBackground` = `false`
- `assets.AutoBackground` = `value`
- `assets.Background` = `DateSceneBackgrounds.Closest(_dateBackgrounds, "", "")`
- `assets.Background` = `DateSceneBackgrounds.Import(path)`
- `assets.Background` = `_dateBackgrounds[(int)index].Id`
- `assets.BlurAmount` = `value`
- `assets.FontSize` = `(int)value`
- `assets.LetterSpacing` = `value`
- `assets.PanelFade` = `value`
- `assets.ShowAffectionBadge` = `value`
- `assets.TextOutline` = `value`
- `assets.TextSpeed` = `value`
- `auto.Toggled` += `value => { assets.AutoBackground = value; Save(); PopulateBackgrounds(); }`
- `blurAmount.DragEnded` += `changed => { if (changed) Save(); }`
- `blurAmount.ValueChanged` += `value => { assets.BlurAmount = value; blurLabel.Text = $"模糊强度 · {value:F1}"; Apply(); }`
- `blurLabel.Text` = `$"模糊强度 · {value:F1}"`
- `choices.ItemSelected` += `index => { assets.Background = _dateBackgrounds[(int)index].Id; assets.AutoBackground = false; auto.SetPressedNoSignal(false); Save(); }`
- `fade.DragEnded` += `changed => { if (changed) Save(); }`
- `fade.ValueChanged` += `value => { assets.PanelFade = value; Apply(); }`
- `fonts.ItemSelected` += `value => { assets.FontSize = (int)value; Save(); }`
- `game.Voices[p.Key]` = `p.Value.Assets.GameVoice`
- `outline.Toggled` += `value => { assets.TextOutline = value; Save(); }`
- `removeBackground.Name` = `"DateBackgroundDelete"`
- `scroll.TreeExiting` += `() => _stage.Resized -= FitSettings`
- `spacing.DragEnded` += `changed => { if (changed) Save(); }`
- `spacing.TooltipText` = `"0% 使用原始间距；默认增加100%，约为原字间留白的两倍。"`
- `spacing.ValueChanged` += `value => { assets.LetterSpacing = value; spacingLabel.Text = $"字间距 · 额外增加 {value:P0}"; Apply(); }`
- `spacingLabel.Text` = `$"字间距 · 额外增加 {value:P0}"`
- `speed.DragEnded` += `changed => { if (changed) Save(); }`
- `speed.ValueChanged` += `value => { assets.TextSpeed = value; speedLabel.Text = value >= DateSceneView.InstantSpeed ? "文字速度 · 立即显示全文" : $"文字速度 · {value:F0}字/秒"; Apply(); }`
- `speedLabel.Text` = `value >= DateSceneView.InstantSpeed ? "文字速度 · 立即显示全文" : $"文字速度 · {value:F0}字/秒"`

<a id="symbol-1f00e77adbe1"></a>

## `Apply() — void Apply()`

来源：源码第 372 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DateSceneSettings()`](DateSceneScreen.cs.md#symbol-0845ec2acab1)；[`Save()`](DateSceneScreen.cs.md#symbol-5e2413f0aa95)

**调用：** `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；[`NationalSpire.CareerScreen.ApplyDateBackground()`](DateSceneScreen.cs.md#symbol-4c2055af1c70)；[`NationalSpire.CareerScreen.ApplyDatePortraitPlacements()`](DateScenePortraitSettings.cs.md#symbol-9e6a2d77a042)；[`NationalSpire.DateSceneView.AffectionVisibility(bool)`](DateSceneView.cs.md#symbol-7da14922fda4)；[`NationalSpire.DateSceneView.Preferences(int, double, double)`](DateSceneView.cs.md#symbol-878552c24bd8)；[`NationalSpire.DateSceneView.Presentation(double, double, double, bool)`](DateSceneView.cs.md#symbol-32ea38e8c82d)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ApplyDateBackground()`；`NationalSpire.CareerScreen.ApplyDatePortraitPlacements()`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.DateSceneAssets.FontSize`；`NationalSpire.DateSceneAssets.LetterSpacing`；`NationalSpire.DateSceneAssets.PanelFade`；`NationalSpire.DateSceneAssets.ShowAffectionBadge`；`NationalSpire.DateSceneAssets.TextOutline`；`NationalSpire.DateSceneAssets.TextSpeed`；`NationalSpire.DateSceneView.AffectionVisibility(bool)`；`NationalSpire.DateSceneView.Preferences(int, double, double)`；`NationalSpire.DateSceneView.Presentation(double, double, double, bool)`；`NationalSpire.DateSceneView.TextSpeed`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_dateView)`；返回值紧邻使用处：`BinaryExpressionSyntax: _dateView != null && IsInstanceValid(_dateView)`
- `NationalSpire.CareerScreen.ApplyDateBackground()`；输入表达式：`ApplyDateBackground()`；返回值紧邻使用处：`ExpressionStatementSyntax: ApplyDateBackground();`
- `NationalSpire.CareerScreen.ApplyDatePortraitPlacements()`；输入表达式：`ApplyDatePortraitPlacements()`；返回值紧邻使用处：`ExpressionStatementSyntax: ApplyDatePortraitPlacements();`
- `NationalSpire.DateSceneView.AffectionVisibility(bool)`；输入表达式：`_dateView.AffectionVisibility(assets.ShowAffectionBadge)`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.AffectionVisibility(assets.ShowAffectionBadge);`
- `NationalSpire.DateSceneView.Preferences(int, double, double)`；输入表达式：`_dateView.Preferences(assets.FontSize, assets.PanelFade, assets.LetterSpacing)`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.Preferences(assets.FontSize, assets.PanelFade, assets.LetterSpacing);`
- `NationalSpire.DateSceneView.Presentation(double, double, double, bool)`；输入表达式：`_dateView.Presentation(1, 0, 0, assets.TextOutline)`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.Presentation(1, 0, 0, assets.TextOutline);`

**赋值（含属性/字段和局部值）：**

- `_dateView.TextSpeed` = `assets.TextSpeed`

<a id="symbol-5e2413f0aa95"></a>

## `Save() — void Save()`

来源：源码第 373 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DateSceneSettings()`](DateSceneScreen.cs.md#symbol-0845ec2acab1)

**调用：** [`Apply()`](DateSceneScreen.cs.md#symbol-1f00e77adbe1)；[`NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`](DateSceneAssets.cs.md#symbol-2bf1f40a912e)

**字段、属性、事件及方法组引用：** `Apply()`；`NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Apply()`；输入表达式：`Apply()`；返回值紧邻使用处：`ExpressionStatementSyntax: Apply();`
- `NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`；输入表达式：`DateSceneAssetStore.Save(data, person, assets)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateSceneAssetStore.Save(data, person, assets);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-fee359acff6f"></a>

## `FitSettings() — void FitSettings()`

来源：源码第 377 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DateSceneSettings()`](DateSceneScreen.cs.md#symbol-0845ec2acab1)

**调用：** `Godot.Vector2.Vector2(float, float)`；`System.Math.Clamp(float, float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._stage`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(660, Math.Clamp(_stage.Size.Y - 300, 220, 540))`；返回值紧邻使用处：`AssignmentExpressionSyntax: scroll.CustomMinimumSize = new(660, Math.Clamp(_stage.Size.Y - 300, 220, 540))`
- `System.Math.Clamp(float, float, float)`；输入表达式：`Math.Clamp(_stage.Size.Y - 300, 220, 540)`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(_stage.Size.Y - 300, 220, 540)`

**赋值（含属性/字段和局部值）：**

- `scroll.CustomMinimumSize` = `new(660, Math.Clamp(_stage.Size.Y - 300, 220, 540))`

<a id="symbol-bb23956847a8"></a>

## `PopulateBackgrounds() — void PopulateBackgrounds()`

来源：源码第 407 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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
