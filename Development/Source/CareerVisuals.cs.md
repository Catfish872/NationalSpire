# CareerVisuals.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`89E24524D2E099BCCAFC39A31AE4F930401FB4FB041EC203F37E2563FE180457`。来源：[源码](../../CareerVisuals.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerVisuals`、`NationalSpire.CareerArt`。

字段、事件及初始值（源码原样）：

```csharp
private static Font? _font;
private static Theme? _theme;
private static readonly Dictionary<(int Weight,int Tracking),FontVariation> TextFonts = new();
private static Font? _rasterFace;
private static readonly Lazy<SystemFont> ColorEmoji = new(() => new SystemFont {
        FontNames = ["Segoe UI Emoji", "Apple Color Emoji", "Noto Color Emoji"],
        AllowSystemFallback = true, MultichannelSignedDistanceField = false
    });
private static int _fontDensity = 1;
private static FontVariation? _cashFont;
public static readonly Color Ink = new("f2f6fa"), Muted = new("aabecb"), Gold = new("eed39b"), Teal = new("80e7db"), Lime = new("c4f36b");
```

<a id="symbol-4b83714363d0"></a>

## `NationalSpire.CareerVisuals.InterfaceFont() — private static Font InterfaceFont()`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerVisuals.InterfaceText(int, int)`](CareerVisuals.cs.md#symbol-a7767494d113)

**调用：** `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.ResourceLoader.Exists(string, string)`；`Godot.ResourceLoader.Load<T>(string, string, Godot.ResourceLoader.CacheMode)`；`Godot.SystemFont.SystemFont()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals._font`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(_font)`；返回值紧邻使用处：`BinaryExpressionSyntax: _font != null && GodotObject.IsInstanceValid(_font)`
- `Godot.ResourceLoader.Exists(string, string)`；输入表达式：`ResourceLoader.Exists(path)`；返回值紧邻使用处：`BinaryExpressionSyntax: ResourceLoader.Exists(path) && ResourceLoader.Load<Font>(path) is { } font`
- `Godot.ResourceLoader.Load<T>(string, string, Godot.ResourceLoader.CacheMode)`；输入表达式：`ResourceLoader.Load<Font>(path)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ResourceLoader.Load<Font>(path) is { } font`
- `Godot.SystemFont.SystemFont()`；输入表达式：`new SystemFont          {              FontNames = ["Microsoft YaHei UI", "Microsoft YaHei", "Noto Sans CJK SC"],              AllowSystemFallback = true, MultichannelSignedDistanceField = true,              MsdfPixelRange = 24, MsdfSize = 48          }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _font = new SystemFont          {              FontNames = ["Microsoft YaHei UI", "Microsoft YaHei", "Noto Sans CJK SC"],              AllowSystemFallback = true, MultichannelSignedDistanceField = true,              MsdfPixelRange = 24, MsdfSize = 48          }`

**赋值（含属性/字段和局部值）：**

- `_font` = `font`
- `_font` = `new SystemFont          {              FontNames = ["Microsoft YaHei UI", "Microsoft YaHei", "Noto Sans CJK SC"],              AllowSystemFallback = true, MultichannelSignedDistanceField = true,              MsdfPixelRange = 24, MsdfSize = 48          }`
- `AllowSystemFallback` = `true`
- `FontNames` = `["Microsoft YaHei UI", "Microsoft YaHei", "Noto Sans CJK SC"]`
- `MsdfPixelRange` = `24`
- `MsdfSize` = `48`
- `MultichannelSignedDistanceField` = `true`

<a id="symbol-5daf1ac7266e"></a>

## `NationalSpire.CareerVisuals.EmojiFont — internal static Font EmojiFont`

来源：源码第 30 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.ColorEmoji`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-450a39fba218"></a>

## `NationalSpire.CareerVisuals.FitTextDensity(float) — internal static void FitTextDensity(float outputScale)`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Fit()`](DashboardViewport.cs.md#symbol-689ddf36dc19)

**调用：** `Godot.Mathf.CeilToInt(float)`；`Godot.Mathf.NearestPo2(int)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals._fontDensity`；`NationalSpire.CareerVisuals._rasterFace`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Mathf.CeilToInt(float)`；输入表达式：`Mathf.CeilToInt(outputScale - .001f)`；返回值紧邻使用处：`ArgumentSyntax: Mathf.CeilToInt(outputScale - .001f)`
- `Godot.Mathf.NearestPo2(int)`；输入表达式：`Mathf.NearestPo2(Math.Max(1, Mathf.CeilToInt(outputScale - .001f)))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Mathf.NearestPo2(Math.Max(1, Mathf.CeilToInt(outputScale - .001f)))`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1, Mathf.CeilToInt(outputScale - .001f))`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(1, Mathf.CeilToInt(outputScale - .001f))`

**赋值（含属性/字段和局部值）：**

- `_fontDensity` = `density`
- `file.Oversampling` = `density`
- `system.Oversampling` = `density`

<a id="symbol-a7767494d113"></a>

## `NationalSpire.CareerVisuals.InterfaceText(int, int) — internal static Font InterfaceText(int weight = 400, int tracking = 0)`

来源：源码第 42 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CalendarDayButton._Ready()`](CalendarDayButton.cs.md#symbol-48874665eb45)；[`NationalSpire.CareerScreen.ArenaIconButton(string, string, System.Action, bool)`](MatchArenaScreen.cs.md#symbol-a95468bbc287)；[`NationalSpire.CareerScreen.ArenaTextAction(string, string, Godot.Color, System.Action)`](MatchArenaScreen.cs.md#symbol-2b8f5772ff95)；[`NationalSpire.CareerScreen.BuildDashboardShell()`](CareerDashboard.cs.md#symbol-168b77d78644)；[`NationalSpire.CareerScreen.DashboardTheme()`](DashboardControls.cs.md#symbol-72d1c6b180c3)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.RosterCandidate(NationalSpire.CareerData, Godot.VBoxContainer, string, string)`](ClubRosterScreen.cs.md#symbol-e2f1b514a2f4)；[`NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`](DashboardControls.cs.md#symbol-d545a37403bd)；[`NationalSpire.CareerVisuals.CashFont()`](CareerVisuals.cs.md#symbol-0a825f4f143c)；[`NationalSpire.CareerVisuals.CreateTheme()`](CareerVisuals.cs.md#symbol-a5f88af9f360)；[`Participant(string, string, string, bool, string?)`](MatchArenaScreen.cs.md#symbol-4b1c40dcef7b)

**调用：** `Godot.FontVariation.FontVariation()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Resource.Duplicate(bool)`；[`NationalSpire.CareerVisuals.InterfaceFont()`](CareerVisuals.cs.md#symbol-4b83714363d0)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.EmojiFont`；`NationalSpire.CareerVisuals.InterfaceFont()`；`NationalSpire.CareerVisuals.TextFonts`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.FontVariation.FontVariation()`；输入表达式：`new FontVariation { BaseFont = native }`；返回值紧邻使用处：`ConditionalExpressionSyntax: native is FontVariation original ? (FontVariation)original.Duplicate(false) : new FontVariation { BaseFont = native }`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(cached)`；返回值紧邻使用处：`BinaryExpressionSyntax: TextFonts.TryGetValue((weight,tracking),out var cached) && GodotObject.IsInstanceValid(cached)`
- `Godot.Resource.Duplicate(bool)`；输入表达式：`original.Duplicate(false)`；返回值紧邻使用处：`CastExpressionSyntax: (FontVariation)original.Duplicate(false)`
- `NationalSpire.CareerVisuals.InterfaceFont()`；输入表达式：`InterfaceFont()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = InterfaceFont()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`TextFonts.TryGetValue((weight,tracking),out var cached)`；返回值紧邻使用处：`BinaryExpressionSyntax: TextFonts.TryGetValue((weight,tracking),out var cached) && GodotObject.IsInstanceValid(cached)`

**赋值（含属性/字段和局部值）：**

- `BaseFont` = `native`
- `TextFonts[(weight,tracking)]` = `variant`
- `variant.Fallbacks` = `[EmojiFont, .. variant.Fallbacks]`
- `variant.SpacingGlyph` += `tracking`
- `variant.VariationEmbolden` += `.6f`

<a id="symbol-0a825f4f143c"></a>

## `NationalSpire.CareerVisuals.CashFont() — internal static Font CashFont()`

来源：源码第 54 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AssetsPage(NationalSpire.CareerData)`](CareerBoardsScreen.cs.md#symbol-5d55d72dcdea)

**调用：** `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Resource.Duplicate(bool)`；[`NationalSpire.CareerVisuals.InterfaceText(int, int)`](CareerVisuals.cs.md#symbol-a7767494d113)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.InterfaceText(int, int)`；`NationalSpire.CareerVisuals._cashFont`；`NationalSpire.CareerVisuals._fontDensity`；`NationalSpire.CareerVisuals._rasterFace`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(_cashFont)`；返回值紧邻使用处：`BinaryExpressionSyntax: _cashFont != null && GodotObject.IsInstanceValid(_cashFont)`
- `Godot.Resource.Duplicate(bool)`；输入表达式：`InterfaceText(700,2).Duplicate(false)`；返回值紧邻使用处：`CastExpressionSyntax: (FontVariation)InterfaceText(700,2).Duplicate(false)`
- `Godot.Resource.Duplicate(bool)`；输入表达式：`variant.BaseFont.Duplicate(false)`；返回值紧邻使用处：`CastExpressionSyntax: (Font)variant.BaseFont.Duplicate(false)`
- `NationalSpire.CareerVisuals.InterfaceText(int, int)`；输入表达式：`InterfaceText(700,2)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: InterfaceText(700,2).Duplicate`

**赋值（含属性/字段和局部值）：**

- `_cashFont` = `variant`
- `_rasterFace` = `(Font)variant.BaseFont.Duplicate(false)`
- `file.MultichannelSignedDistanceField` = `false`
- `file.Oversampling` = `_fontDensity`
- `system.MultichannelSignedDistanceField` = `false`
- `system.Oversampling` = `_fontDensity`
- `variant.BaseFont` = `_rasterFace`

<a id="symbol-561d8fe38106"></a>

## `NationalSpire.CareerVisuals.ClearContent(Godot.Node) — public static void ClearContent(Node parent)`

来源：源码第 68 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Calendar()`](ConsumerPickerScreen.cs.md#symbol-8eb2036c6dbc)；[`Calendar()`](PrivateMessageScreen.cs.md#symbol-941d226e179c)；[`Draw()`](DateSceneAssetScreen.cs.md#symbol-44fc11efbaa6)；[`Files()`](NpcGenerationScreen.cs.md#symbol-bbc9ef0af3ad)；[`Gallery()`](AvatarScreen.cs.md#symbol-e01b201de3dc)；[`Groups()`](ConsumerPickerScreen.cs.md#symbol-0aa3d7203ee8)；[`Members()`](ConsumerPickerScreen.cs.md#symbol-cf168b0ee57f)；[`NationalSpire.CareerScreen.DashboardHeader(NationalSpire.CareerData)`](CareerDashboard.cs.md#symbol-959727dcb8cd)；[`NationalSpire.CareerScreen.EditPreviousDateScene()`](DateSceneScreen.cs.md#symbol-68bbfe92ebcf)；[`NationalSpire.CareerScreen.PopulateCommunityFeed(NationalSpire.CareerData, Godot.VBoxContainer)`](CommunityFilters.cs.md#symbol-09f2fb6e4563)；[`NationalSpire.CareerScreen.RefreshDateSceneAttachments()`](DateSceneScreen.cs.md#symbol-4cd4fd18856d)；[`NationalSpire.CareerScreen.RefreshDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityScreen.cs.md#symbol-ad7fb59cd134)；[`NationalSpire.CareerScreen.RefreshGroupChat()`](GroupChatScreen.cs.md#symbol-b56fe79b2db7)；[`NationalSpire.CareerScreen.RefreshPrivateAttachments()`](PrivateMemoryScreen.cs.md#symbol-b9d6c2084031)；[`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)；[`NationalSpire.CareerScreen.RefreshPrivateProposal()`](PrivateMessageScreen.cs.md#symbol-fcf77d9c4194)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.RenderWeeklySlide(NationalSpire.CareerData, bool)`](WeeklyScreen.cs.md#symbol-184e7ff58940)；[`NationalSpire.CareerScreen.RosterSwapDialog(NationalSpire.CareerData, string, System.Collections.Generic.List<string>, string)`](ClubRosterScreen.cs.md#symbol-fb8f38826212)；[`NationalSpire.CareerScreen.ToggleDiscussion(NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-10637dfc37f0)；[`NationalSpire.Coop.CoopScreen.Render()`](Coop/CoopScreen.cs.md#symbol-adc6058122f7)；[`NationalSpire.DateSceneView.SetReplyChoices(string, System.Action, string, System.Action)`](DateSceneView.cs.md#symbol-697ad465ef9e)；[`NationalSpire.DateSceneView.ShowGameChoices(System.Action, System.Action)`](DateSceneView.cs.md#symbol-c0903cec21b6)；[`NationalSpire.EventStoryView.Display(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.EventLive?, bool)`](RandomEventScreen.cs.md#symbol-f847e9f29b0e)；[`NationalSpire.EventStoryView.ShowResultEffects(NationalSpire.CareerData, NationalSpire.RandomEventOption, Godot.VBoxContainer)`](RandomEventScreen.cs.md#symbol-5fbf79c036d6)；[`Rebuild()`](PersonalityPoolScreen.cs.md#symbol-c37b212c8504)；[`Refresh()`](ConsumerPickerScreen.cs.md#symbol-8376c45db5bc)；[`Refresh()`](MentionComposer.cs.md#symbol-13231b1d37b1)；[`Removed()`](ChatManagementScreen.cs.md#symbol-0702711e2eee)；[`Section(string)`](PrivateMemoryScreen.cs.md#symbol-3776534c6c5a)；[`Show(bool)`](CommunityReplyExpressions.cs.md#symbol-5bada39e1ed4)；[`Show(bool)`](ConsumerPickerScreen.cs.md#symbol-bfd48d04a658)；[`WeddingChoices()`](ConsumerPickerScreen.cs.md#symbol-667c9af3e555)；[`Weights()`](NpcGenerationScreen.cs.md#symbol-3c35095e983c)

**调用：** `Godot.CanvasItem.Hide()`；`Godot.GodotObject.GetInstanceId()`；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.Node.GetChildren(bool)`；`Godot.Node.QueueFree()`；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)

**字段、属性、事件及方法组引用：** `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.Clear`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`item.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: item.Hide();`
- `Godot.GodotObject.GetInstanceId()`；输入表达式：`child.GetInstanceId()`；返回值紧邻使用处：`BinaryExpressionSyntax: "Retired_" + child.GetInstanceId()`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`child.IsQueuedForDeletion()`；返回值紧邻使用处：`IfStatementSyntax: if (child.IsQueuedForDeletion()) continue;`
- `Godot.Node.GetChildren(bool)`；输入表达式：`parent.GetChildren()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var child in parent.GetChildren())          {              if (child.IsQueuedForDeletion()) continue;              if (child is CanvasItem item) item.Hide();              child.ProcessMode = Node.ProcessModeEnum.Disabled;              child.Name = "Retired_" + child.GetInstanceId();              child.QueueFree();          }`
- `Godot.Node.QueueFree()`；输入表达式：`child.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: child.QueueFree();`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.Clear)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.Clear)`

**赋值（含属性/字段和局部值）：**

- `child.Name` = `"Retired_" + child.GetInstanceId()`
- `child.ProcessMode` = `Node.ProcessModeEnum.Disabled`

<a id="symbol-347d38705528"></a>

## `NationalSpire.CareerVisuals.FindContent(Godot.Node, string) — public static Node? FindContent(Node parent, string name)`

来源：源码第 82 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BeginReply(NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-6bc7befbb991)；[`NationalSpire.CareerScreen.CloseThreadReply(string, string)`](CommunityScreen.cs.md#symbol-65baf7e888c9)；[`NationalSpire.CareerScreen.CompleteThreadReply(string, string, string)`](CommunityScreen.cs.md#symbol-d9fcfe778254)；[`NationalSpire.CareerScreen.CurrentPlanScroll()`](CalendarPlansScreen.cs.md#symbol-22ea50ffc52d)；[`NationalSpire.CareerScreen.FocusComposerAsync(string)`](CommunityScreen.cs.md#symbol-1b316c95919c)；[`NationalSpire.CareerScreen.RebuildThreadReplies(NationalSpire.CareerData, NationalSpire.CommunityPost, System.Action)`](CommunityScreen.cs.md#symbol-283b456d2a7a)；[`NationalSpire.CareerScreen.RefreshDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityScreen.cs.md#symbol-ad7fb59cd134)；[`NationalSpire.CareerScreen.RenderReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.PanelContainer?)`](CommunityScreen.cs.md#symbol-85990747d510)；[`NationalSpire.CareerScreen.RenderRootReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityScreen.cs.md#symbol-f92fad8b113e)；[`NationalSpire.CareerScreen.RenderWeeklySlide(NationalSpire.CareerData, bool)`](WeeklyScreen.cs.md#symbol-184e7ff58940)；[`NationalSpire.CareerScreen.RetireReplyComposer()`](CommunityScreen.cs.md#symbol-aebacdaad363)；[`NationalSpire.CareerScreen.ShareDiscussion(string, string)`](CommunityShareScreen.cs.md#symbol-038b648fdc83)；[`NationalSpire.CareerScreen.ToggleDiscussion(NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-10637dfc37f0)；[`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`](CareerVisuals.cs.md#symbol-347d38705528)

**调用：** `Godot.GodotObject.IsQueuedForDeletion()`；`Godot.Node.GetChildren(bool)`；[`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`](CareerVisuals.cs.md#symbol-347d38705528)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`child.IsQueuedForDeletion()`；返回值紧邻使用处：`IfStatementSyntax: if (child.IsQueuedForDeletion()) continue;`
- `Godot.Node.GetChildren(bool)`；输入表达式：`parent.GetChildren()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var child in parent.GetChildren())          {              if (child.IsQueuedForDeletion()) continue;              if (child.Name == name) return child;              if (FindContent(child, name) is { } found) return found;          }`
- `NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`；输入表达式：`FindContent(child, name)`；返回值紧邻使用处：`IsPatternExpressionSyntax: FindContent(child, name) is { } found`

**赋值（含属性/字段和局部值）：**


<a id="symbol-96a89aa3b493"></a>

## `NationalSpire.CareerVisuals.Box(string, string, int, int) — public static StyleBoxFlat Box(string fill, string border = "304554", int radius = 8, int padding = 20)`

来源：源码第 92 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Action(string, int)`](ConsumerGiftControls.cs.md#symbol-53199fb9fdba)；[`Add(float, string, string, int)`](AiSettingsPanel.cs.md#symbol-3c5dd1fa546c)；[`AddHeading(Godot.Control, string, string, bool, bool)`](FixtureScheduleScreen.cs.md#symbol-76b1908501df)；[`Blank()`](CareerScreen.cs.md#symbol-ebc009b5fb40)；[`CardBody(string)`](ClubRosterScreen.cs.md#symbol-a4dfe3b780ab)；[`DrawPage()`](PortraitDesignScreen.cs.md#symbol-5edcd91edd93)；[`Field(string, int, string)`](RandomEventScreen.cs.md#symbol-7c1b2f0b68b4)；[`Highlight()`](MentionComposer.cs.md#symbol-3e7861204903)；[`Memo(Godot.Control, string, string, System.Action<string>, string?)`](CharacterCardScreen.cs.md#symbol-b0e1c4e4d371)；[`Metric(string, string, string, Godot.Color, bool)`](OwnedClubScreen.cs.md#symbol-531f8b9327ea)；[`NationalSpire.AiTaskRoutePicker.Configure(NationalSpire.AiOptions, string, System.Action, System.Action<string, bool>)`](AiTaskRoutePicker.cs.md#symbol-7a35c2ddf3d1)；[`NationalSpire.BracketInspector.Attach(Godot.Control, Godot.ScrollContainer)`](BracketInspector.cs.md#symbol-ddfed770fc0f)；[`NationalSpire.CalendarDayButton.SelectDate(bool)`](CalendarDayButton.cs.md#symbol-c7e15f459308)；[`NationalSpire.CareerAvatar.PortraitFrame(NationalSpire.AvatarArt, NationalSpire.AvatarIdentity?, bool)`](CareerAvatars.cs.md#symbol-3f66fd9ce111)；[`NationalSpire.CareerListCache.AddProfile()`](CareerListCache.cs.md#symbol-25cd78ebfabe)；[`NationalSpire.CareerScreen.AddCompletedDateCard(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](DateDiaryScreen.cs.md#symbol-0154b9cfbb28)；[`NationalSpire.CareerScreen.AddMentionPicker(Godot.TextEdit, Godot.VBoxContainer)`](MentionComposer.cs.md#symbol-8702f28d36a7)；[`NationalSpire.CareerScreen.AddPausedDateScenes(NationalSpire.CareerData, NationalSpire.PrivateConversation)`](DateSceneScreen.cs.md#symbol-a5b10d9fb0b8)；[`NationalSpire.CareerScreen.AddPrivateBubble(string, bool, NationalSpire.PrivateTurn)`](PrivateMessageScreen.cs.md#symbol-b24b4d693d2a)；[`NationalSpire.CareerScreen.AddPrivateMood(NationalSpire.PrivateMood)`](PrivateMemoryScreen.cs.md#symbol-1cd11d02c1b9)；[`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-c7881d245b3d)；[`NationalSpire.CareerScreen.AddPrivateProfileChange(NationalSpire.PrivateProfileChange)`](PrivateMemoryScreen.cs.md#symbol-cd1de98ddea7)；[`NationalSpire.CareerScreen.ArbitrationCard(NationalSpire.CareerData, NationalSpire.ArbitrationRecord)`](ArbitrationScreen.cs.md#symbol-8d41f13d5476)；[`NationalSpire.CareerScreen.ArenaIconButton(string, string, System.Action, bool)`](MatchArenaScreen.cs.md#symbol-a95468bbc287)；[`NationalSpire.CareerScreen.AssetsPage(NationalSpire.CareerData)`](CareerBoardsScreen.cs.md#symbol-5d55d72dcdea)；[`NationalSpire.CareerScreen.BuildAppearanceLibrary(Godot.VBoxContainer, NationalSpire.CareerData, string, System.Action<(NationalSpire.PortraitDesign Design, NationalSpire.DateSceneAssets Assets)>, System.Action<string, System.Action>?)`](AppearanceLibraryScreen.cs.md#symbol-6c40b8e1641a)；[`NationalSpire.CareerScreen.BuildDashboardShell()`](CareerDashboard.cs.md#symbol-168b77d78644)；[`NationalSpire.CareerScreen.BuildPrivateComposerActions(Godot.VBoxContainer)`](PrivateMessageScreen.cs.md#symbol-a7be0d6513a6)；[`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.CeremonyAwards(NationalSpire.CareerData, NationalSpire.CeremonyRecord)`](CeremonyScreen.cs.md#symbol-554512484279)；[`NationalSpire.CareerScreen.CeremonyHero(NationalSpire.CareerData, NationalSpire.CeremonyRecord)`](CeremonyScreen.cs.md#symbol-7344f4112178)；[`NationalSpire.CareerScreen.CeremonyInvitation(NationalSpire.CareerData)`](CeremonyScreen.cs.md#symbol-fe94e59081ff)；[`NationalSpire.CareerScreen.CeremonyRanking(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CeremonyRank>)`](CeremonyScreen.cs.md#symbol-73500bb64a58)；[`NationalSpire.CareerScreen.CeremonyWeeklyCover(NationalSpire.CareerData, NationalSpire.WeeklySlide, bool)`](CeremonyScreen.cs.md#symbol-96e48591b6f3)；[`NationalSpire.CareerScreen.ClubCard(string, string?, bool)`](OwnedClubScreen.cs.md#symbol-dea530bc8e29)；[`NationalSpire.CareerScreen.ClubSummary(NationalSpire.CareerData, NationalSpire.CareerClub, Godot.Container)`](CareerWorldScreen.cs.md#symbol-119e71d5db33)；[`NationalSpire.CareerScreen.CompetitionOverview(NationalSpire.CareerData, NationalSpire.CompetitionReview)`](SettlementScreen.cs.md#symbol-f0fb4e109457)；[`NationalSpire.CareerScreen.ConsumerAttachmentConfirmation(NationalSpire.ConsumerComposer, NationalSpire.PrivateOffer, System.Action?)`](ConsumerCommerceScreen.cs.md#symbol-f3a03a858f88)；[`NationalSpire.CareerScreen.ConsumerEditor(bool, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?, string, string, NationalSpire.CareerScreen.ConsumerEdit?)`](ConsumerPickerScreen.cs.md#symbol-0f5d28176960)；[`NationalSpire.CareerScreen.ContactMenu(Godot.Vector2, System.Action<Godot.VBoxContainer>, int)`](ChatContactScreen.cs.md#symbol-20cc99232e33)；[`NationalSpire.CareerScreen.DateDiaryButton(System.Action, int)`](DateDiaryScreen.cs.md#symbol-da0fd94c90a9)；[`NationalSpire.CareerScreen.DateDiaryEntryDialog(NationalSpire.CareerData, string, string)`](DateDiaryScreen.cs.md#symbol-fb4ba1a3b5fa)；[`NationalSpire.CareerScreen.Emphasize(Godot.Button)`](BroadcastVisuals.cs.md#symbol-ddd68d13b687)；[`NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`](BroadcastVisuals.cs.md#symbol-15d48434171e)；[`NationalSpire.CareerScreen.FlatPanel(Godot.Container, string, int, string, int)`](CareerDashboard.cs.md#symbol-a0e5a4138c47)；[`NationalSpire.CareerScreen.GiftReceipt(NationalSpire.PrivateOffer)`](ChatAttachmentScreen.cs.md#symbol-bb34e71c1240)；[`NationalSpire.CareerScreen.GroupBubble(string, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>?)`](GroupChatScreen.cs.md#symbol-870e7cca58c0)；[`NationalSpire.CareerScreen.GroupOffer(NationalSpire.GroupChat, NationalSpire.GroupEffect, NationalSpire.PrivateOffer)`](GroupChatScreen.cs.md#symbol-3afa41099b93)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.InternationalBracket(NationalSpire.CareerData, NationalSpire.WorldCompetition, Godot.HBoxContainer)`](FixtureScheduleScreen.cs.md#symbol-992db6cc73f9)；[`NationalSpire.CareerScreen.LedgerRow(string[], bool)`](CareerBoardsScreen.cs.md#symbol-ebfdc210bad4)；[`NationalSpire.CareerScreen.ManualMemoryCard(Godot.VBoxContainer, NationalSpire.ManualChatMemory)`](ManualMemoryScreen.cs.md#symbol-aad226291778)；[`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)；[`NationalSpire.CareerScreen.OpenCharacterCardCore(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?, NationalSpire.CharacterDesignPackage.Imported?)`](CharacterCardScreen.cs.md#symbol-c2fe452ad056)；[`NationalSpire.CareerScreen.OpenEventPoolSettings(NationalSpire.CareerData)`](EventPoolScreen.cs.md#symbol-8608563c139b)；[`NationalSpire.CareerScreen.OpenPortraitDesigner(NationalSpire.CareerData, string)`](PortraitDesignScreen.cs.md#symbol-3bb5119a73ca)；[`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.PlanPane(NationalSpire.CareerData, Godot.VBoxContainer, Godot.ScrollContainer, System.Collections.Generic.List<NationalSpire.CareerScreen.CalendarPlan>, NationalSpire.CalendarDayButton[])`](CalendarPlansScreen.cs.md#symbol-078c4f908d4c)；[`NationalSpire.CareerScreen.PlayerBanner(NationalSpire.CareerData, string)`](BroadcastVisuals.cs.md#symbol-936e32073293)；[`NationalSpire.CareerScreen.PrivateArbitrationDialog()`](ArbitrationScreen.cs.md#symbol-63e3d9aaa6df)；[`NationalSpire.CareerScreen.PrivateAttachmentCard(NationalSpire.PrivateOffer, bool)`](PrivateMemoryScreen.cs.md#symbol-eb2b2a37c5d1)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.PrivateEditor(string, int, int)`](PrivateMemoryScreen.cs.md#symbol-1c1072fdb98b)；[`NationalSpire.CareerScreen.PrivateIdentity(NationalSpire.CareerData, string, bool)`](PrivateMemoryScreen.cs.md#symbol-65caddca194f)；[`NationalSpire.CareerScreen.PrivateIdentityButton(string, System.Action, bool)`](PrivateMemoryScreen.cs.md#symbol-67f8f263b4a9)；[`NationalSpire.CareerScreen.PrivateLineupCard(NationalSpire.CareerData, NationalSpire.CoachLineupRequest, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?)`](CoachScreen.cs.md#symbol-c01675f974f7)；[`NationalSpire.CareerScreen.PrivateTrainingCard(NationalSpire.CareerData, NationalSpire.CoachTrainingPlan, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?)`](CoachScreen.cs.md#symbol-c2e37e4a0f14)；[`NationalSpire.CareerScreen.ProfileSection(string)`](ProfileScreen.cs.md#symbol-078e0ffb0ebe)；[`NationalSpire.CareerScreen.RailCount(Godot.Button)`](CareerDashboard.cs.md#symbol-980545ae56ef)；[`NationalSpire.CareerScreen.RefreshGroupChat()`](GroupChatScreen.cs.md#symbol-b56fe79b2db7)；[`NationalSpire.CareerScreen.RenderWeeklyDetail(NationalSpire.CareerData)`](WeeklyScreen.cs.md#symbol-b3f0ffc5fb7d)；[`NationalSpire.CareerScreen.RenderWeeklySlide(NationalSpire.CareerData, bool)`](WeeklyScreen.cs.md#symbol-184e7ff58940)；[`NationalSpire.CareerScreen.RosterMembers(NationalSpire.CareerData, NationalSpire.OwnedClubState)`](ClubRosterScreen.cs.md#symbol-9ed06d3d7953)；[`NationalSpire.CareerScreen.RosterSwapDialog(NationalSpire.CareerData, string, System.Collections.Generic.List<string>, string)`](ClubRosterScreen.cs.md#symbol-fb8f38826212)；[`NationalSpire.CareerScreen.SaveRow(Godot.VBoxContainer, string, string, string, bool, System.Func<string, System.Threading.Tasks.Task>, bool)`](CareerLibraryScreen.cs.md#symbol-ba7dbc5dacaa)；[`NationalSpire.CareerScreen.Settlement(NationalSpire.CareerData)`](SettlementScreen.cs.md#symbol-ec46df6667fd)；[`NationalSpire.CareerScreen.ShareDiscussion(string, string)`](CommunityShareScreen.cs.md#symbol-038b648fdc83)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`](CareerDialog.cs.md#symbol-df0355cc8433)；[`NationalSpire.CareerScreen.ShowChatContextMenu(string, bool, Godot.Vector2)`](ChatContextMenuScreen.cs.md#symbol-0f3f090eb3e9)；[`NationalSpire.CareerScreen.ShowChatModelPicker(Godot.Button, string)`](ChatUtilitiesScreen.cs.md#symbol-cc67f52fc948)；[`NationalSpire.CareerScreen.ShowJourneyEncounter()`](EventJourneyScreen.cs.md#symbol-4e94d6a77974)；[`NationalSpire.CareerScreen.SurfaceStyle(string, string, int, int)`](DashboardControls.cs.md#symbol-86a5104d5792)；[`NationalSpire.CareerScreen.WeeklyArt(NationalSpire.WeeklyEdition, NationalSpire.WeeklySlide, bool)`](WeeklyScreen.cs.md#symbol-d6f13958bba4)；[`NationalSpire.CareerVisuals.CreateTheme()`](CareerVisuals.cs.md#symbol-a5f88af9f360)；[`NationalSpire.CommunityReplyButton._Ready()`](CommunityDiscussionVisuals.cs.md#symbol-1e11e4f0b913)；[`NationalSpire.CommunityReplyExpressions.CategoryButton(string, string, int)`](CommunityReplyExpressions.cs.md#symbol-8fcfa40b1631)；[`NationalSpire.CommunityReportButton._Ready()`](CommunityDiscussionVisuals.cs.md#symbol-a9c948c158eb)；[`NationalSpire.CommunityShareButton._Ready()`](CommunityDiscussionVisuals.cs.md#symbol-c9b514864c3c)；[`NationalSpire.CommunityVoteButton._Ready()`](CommunityDiscussionVisuals.cs.md#symbol-19ed81df80db)；[`NationalSpire.ConsumerQuantity.Initialize(int)`](ConsumerGiftControls.cs.md#symbol-a0db04226b0a)；[`NationalSpire.ConsumerVisuals.Style(bool, bool)`](ConsumerVisuals.cs.md#symbol-340545590823)；[`NationalSpire.Coop.CoopLive.ConfirmStop()`](Coop/CoopLive.cs.md#symbol-30b59f1772bc)；[`NationalSpire.Coop.CoopScreen.Card(Godot.Node, string, Godot.Color?)`](Coop/CoopScreen.cs.md#symbol-eab6cd747232)；[`NationalSpire.Coop.CoopScreen.WaitingRoom(NationalSpire.Coop.CoopWorld)`](Coop/CoopScreen.cs.md#symbol-b46abec89d85)；[`NationalSpire.DateSceneView.ActionButton(string, System.Action, string, int)`](DateSceneView.cs.md#symbol-1ed75a76342e)；[`NationalSpire.DateSceneView.AddChoiceCopy(Godot.Button, string)`](DateSceneView.cs.md#symbol-ee5b6c67d3d5)；[`NationalSpire.DateSceneView.ShowGameChoices(System.Action, System.Action)`](DateSceneView.cs.md#symbol-c0903cec21b6)；[`NationalSpire.DateSceneView.WaitingBubble(NationalSpire.DateSceneView.WaitingActor)`](DateSceneWaiting.cs.md#symbol-865fad94731c)；[`NationalSpire.DateSceneView._Ready()`](DateSceneView.cs.md#symbol-db339768c993)；[`NationalSpire.EventStoryButton._Ready()`](RandomEventScreen.cs.md#symbol-3b729478e92e)；[`NationalSpire.EventStoryView.ActionButton(string, System.Action)`](RandomEventScreen.cs.md#symbol-8068df83bcbc)；[`NationalSpire.EventStoryView.BuildCustomAction(Godot.VBoxContainer)`](RandomEventCustomScreen.cs.md#symbol-9f8527a6f5e4)；[`NationalSpire.EventStoryView.ShowResultEffects(NationalSpire.CareerData, NationalSpire.RandomEventOption, Godot.VBoxContainer)`](RandomEventScreen.cs.md#symbol-5fbf79c036d6)；[`NationalSpire.EventStoryView._Ready()`](RandomEventScreen.cs.md#symbol-d31ee33f7cb0)；[`NationalSpire.GroupAvatar._Draw()`](GroupAvatar.cs.md#symbol-7d1ac12346aa)；[`NationalSpire.LiveRaceHud.ShowChatRequest(string, string, string, NationalSpire.AvatarArt, NationalSpire.AvatarIdentity, double, bool, Godot.Button, System.Action)`](LiveRaceHud.cs.md#symbol-e42d7e040efa)；[`NationalSpire.LiveRaceHud.SpeechPanel(string, string, string, NationalSpire.AvatarArt?, NationalSpire.AvatarIdentity?, bool, float)`](LiveRaceHud.cs.md#symbol-53c07f0e6874)；[`NationalSpire.LiveRaceHud._Ready()`](LiveRaceHud.cs.md#symbol-b5a8cd9a2617)；[`NationalSpire.LiveRequestButton.LiveRequestButton()`](LiveRequestButton.cs.md#symbol-e8accbc7d310)；[`NationalSpire.MarketTerminal.Build()`](MarketTerminal.cs.md#symbol-285abee5b9f5)；[`NationalSpire.MarketTerminal.MarketTerminal()`](MarketTerminal.cs.md#symbol-ca583ab46f87)；[`NationalSpire.MarketTerminal.Panel(Godot.Node, float)`](MarketTerminal.cs.md#symbol-3d766989e03d)；[`NationalSpire.MarketVisuals.ActionStyle(Godot.Button, string)`](MarketVisuals.cs.md#symbol-5703b8242580)；[`NationalSpire.MarketVisuals.Card(string, bool, bool)`](MarketVisuals.cs.md#symbol-aef7b9c00c48)；[`NationalSpire.MatchStartWatch.ShowNotice()`](MatchStartWatch.cs.md#symbol-c904f0fb2bfd)；[`NationalSpire.PercentageSlider._Ready()`](PercentageSlider.cs.md#symbol-5afc59be40b9)；[`NationalSpire.PrivateMoodButton._Ready()`](PrivateMemoryScreen.cs.md#symbol-43448ac9d3a0)；[`NationalSpire.RivalMapOverlay._Ready()`](LiveRaceHud.cs.md#symbol-71fa48f8cc62)；[`Paint(bool)`](ChatToolToggle.cs.md#symbol-3ff003a6c7cb)；[`Preview()`](NpcAvatarFrameScreen.cs.md#symbol-e09ed14299e2)；[`Reward(string, string, string)`](SettlementScreen.cs.md#symbol-af03f0ffe7a7)；[`Section(string)`](PrivateMemoryScreen.cs.md#symbol-3776534c6c5a)；[`ShowRows()`](CommunityShareScreen.cs.md#symbol-2e7b710b7d77)；[`ShowRows()`](PeoplePickerScreen.cs.md#symbol-0dac44c0ee6b)；[`Side(System.Collections.Generic.List<NationalSpire.CompetitionPlayer>, string)`](SettlementScreen.cs.md#symbol-4dfe6435cbee)；[`Side(bool, string, bool)`](FixtureScheduleScreen.cs.md#symbol-c3e9952725d3)；[`Update(string)`](PrivateMemoryScreen.cs.md#symbol-2ffaba195530)；[`Weights()`](NpcGenerationScreen.cs.md#symbol-3c35095e983c)

**调用：** `Godot.Color.Color(string)`；`Godot.StyleBoxFlat.StyleBoxFlat()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color(border)`；返回值紧邻使用处：`AssignmentExpressionSyntax: BorderColor = new Color(border)`
- `Godot.Color.Color(string)`；输入表达式：`new Color(fill)`；返回值紧邻使用处：`AssignmentExpressionSyntax: BgColor = new Color(fill)`
- `Godot.StyleBoxFlat.StyleBoxFlat()`；输入表达式：`new()      {          BgColor = new Color(fill), BorderColor = new Color(border), BorderWidthLeft = 1, BorderWidthRight = 1,          BorderWidthTop = 1, BorderWidthBottom = 1, CornerRadiusTopLeft = radius, CornerRadiusTopRight = radius,          CornerRadiusBottomLeft = radius, CornerRadiusBottomRight = radius,          ContentMarginLeft = padding, ContentMarginRight = padding, ContentMarginTop = padding, ContentMarginBottom = padding      }`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new()      {          BgColor = new Color(fill), BorderColor = new Color(border), BorderWidthLeft = 1, BorderWidthRight = 1,          BorderWidthTop = 1, BorderWidthBottom = 1, CornerRadiusTopLeft = radius, CornerRadiusTopRight = radius,          CornerRadiusBottomLeft = radius, CornerRadiusBottomRight = radius,          ContentMarginLeft = padding, ContentMarginRight = padding, ContentMarginTop = padding, ContentMarginBottom = padding      }`

**赋值（含属性/字段和局部值）：**

- `BgColor` = `new Color(fill)`
- `BorderColor` = `new Color(border)`
- `BorderWidthBottom` = `1`
- `BorderWidthLeft` = `1`
- `BorderWidthRight` = `1`
- `BorderWidthTop` = `1`
- `ContentMarginBottom` = `padding`
- `ContentMarginLeft` = `padding`
- `ContentMarginRight` = `padding`
- `ContentMarginTop` = `padding`
- `CornerRadiusBottomLeft` = `radius`
- `CornerRadiusBottomRight` = `radius`
- `CornerRadiusTopLeft` = `radius`
- `CornerRadiusTopRight` = `radius`

<a id="symbol-a5f88af9f360"></a>

## `NationalSpire.CareerVisuals.CreateTheme() — public static Theme CreateTheme()`

来源：源码第 99 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerListCache.For(Godot.Node)`](CareerListCache.cs.md#symbol-eba9914ced8b)；[`NationalSpire.CareerScreen.ArenaCharacterMenu(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CharacterModel>, int, int, System.Action<int>)`](MatchArenaScreen.cs.md#symbol-22155287ec1d)；[`NationalSpire.CareerScreen.DashboardTheme()`](DashboardControls.cs.md#symbol-72d1c6b180c3)；[`NationalSpire.CareerScreen.SelectNpcGeneration(Godot.Control, NationalSpire.AiOptions, System.Func<NationalSpire.NpcGenerationSetup, System.Threading.Tasks.Task>, System.Action?)`](NpcGenerationScreen.cs.md#symbol-4a76a0da98d8)；[`NationalSpire.Coop.CoopLive.ConfirmStop()`](Coop/CoopLive.cs.md#symbol-30b59f1772bc)；[`NationalSpire.Coop.CoopMenuPatch.Postfix(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu)`](Coop/CoopRuntime.cs.md#symbol-898c6637244f)；[`NationalSpire.Coop.CoopScreen.Open(Godot.Control, bool)`](Coop/CoopScreen.cs.md#symbol-c9ac083daf6c)；[`NationalSpire.LiveRaceHud._Ready()`](LiveRaceHud.cs.md#symbol-b5a8cd9a2617)；[`NationalSpire.MarketTerminal.MarketTerminal()`](MarketTerminal.cs.md#symbol-ca583ab46f87)；[`NationalSpire.MatchStartWatch.ShowNotice()`](MatchStartWatch.cs.md#symbol-c904f0fb2bfd)；[`NationalSpire.MenuPatch.Postfix(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu)`](GameBridge.cs.md#symbol-6939e359db40)；[`NationalSpire.RivalMapOverlay._Ready()`](LiveRaceHud.cs.md#symbol-71fa48f8cc62)

**调用：** `Godot.Color.Color(string)`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Image.Image()`；`Godot.Image.LoadSvgFromString(string, float)`；`Godot.ImageTexture.CreateFromImage(Godot.Image)`；`Godot.Theme.SetColor(Godot.StringName, Godot.StringName, Godot.Color)`；`Godot.Theme.SetConstant(Godot.StringName, Godot.StringName, int)`；`Godot.Theme.SetFontSize(Godot.StringName, Godot.StringName, int)`；`Godot.Theme.SetIcon(Godot.StringName, Godot.StringName, Godot.Texture2D)`；`Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；`Godot.Theme.Theme()`；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.CareerVisuals.InterfaceText(int, int)`](CareerVisuals.cs.md#symbol-a7767494d113)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Gold`；`NationalSpire.CareerVisuals.Ink`；`NationalSpire.CareerVisuals.InterfaceText(int, int)`；`NationalSpire.CareerVisuals.Muted`；`NationalSpire.CareerVisuals._theme`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("9baebb")`；返回值紧邻使用处：`ArgumentSyntax: new Color("9baebb")`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(_theme)`；返回值紧邻使用处：`BinaryExpressionSyntax: _theme != null && GodotObject.IsInstanceValid(_theme)`
- `Godot.Image.Image()`；输入表达式：`new Image()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Image()`
- `Godot.Image.LoadSvgFromString(string, float)`；输入表达式：`image.LoadSvgFromString("<svg xmlns='http://www.w3.org/2000/svg' width='20' height='20'><rect x='1' y='1' width='18' height='18' rx='4' fill='#142536' stroke='#82b8bc' stroke-width='2'/>" + (selected ? "<path d='M5 10 L9 14 L15 6' fill='none' stroke='#70d4bc' stroke-width='2.5'/>" : "") + "</svg>")`；返回值紧邻使用处：`ExpressionStatementSyntax: image.LoadSvgFromString("<svg xmlns='http://www.w3.org/2000/svg' width='20' height='20'><rect x='1' y='1' width='18' height='18' rx='4' fill='#142536' stroke='#82b8bc' stroke-width='2'/>" + (selected ? "<path d='M5 10 L9 14 L15 6' fill='none' stroke='#70d4bc' stroke-width='2.5'/>" : "") + "</svg>");`
- `Godot.Image.LoadSvgFromString(string, float)`；输入表达式：`svg.LoadSvgFromString($"<svg xmlns='http://www.w3.org/2000/svg' width='34' height='20'><rect x='1' y='1' width='32' height='18' rx='9' fill='{track}'/><circle cx='{(on?24:10)}' cy='10' r='6' fill='{knob}'/></svg>")`；返回值紧邻使用处：`ExpressionStatementSyntax: svg.LoadSvgFromString($"<svg xmlns='http://www.w3.org/2000/svg' width='34' height='20'><rect x='1' y='1' width='32' height='18' rx='9' fill='{track}'/><circle cx='{(on?24:10)}' cy='10' r='6' fill='{knob}'/></svg>");`
- `Godot.ImageTexture.CreateFromImage(Godot.Image)`；输入表达式：`ImageTexture.CreateFromImage(image)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ImageTexture.CreateFromImage(image)`
- `Godot.ImageTexture.CreateFromImage(Godot.Image)`；输入表达式：`ImageTexture.CreateFromImage(svg)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ImageTexture.CreateFromImage(svg)`
- `Godot.Theme.SetColor(Godot.StringName, Godot.StringName, Godot.Color)`；输入表达式：`theme.SetColor("caret_color", "TextEdit", Gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetColor("caret_color", "TextEdit", Gold);`
- `Godot.Theme.SetColor(Godot.StringName, Godot.StringName, Godot.Color)`；输入表达式：`theme.SetColor("font_color", "Label", Ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetColor("font_color", "Label", Ink);`
- `Godot.Theme.SetColor(Godot.StringName, Godot.StringName, Godot.Color)`；输入表达式：`theme.SetColor("font_color", "LineEdit", Ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetColor("font_color", "LineEdit", Ink);`
- `Godot.Theme.SetColor(Godot.StringName, Godot.StringName, Godot.Color)`；输入表达式：`theme.SetColor("font_color", "TextEdit", Ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetColor("font_color", "TextEdit", Ink);`
- `Godot.Theme.SetColor(Godot.StringName, Godot.StringName, Godot.Color)`；输入表达式：`theme.SetColor("font_color", type, Ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetColor("font_color", type, Ink);`
- `Godot.Theme.SetColor(Godot.StringName, Godot.StringName, Godot.Color)`；输入表达式：`theme.SetColor("font_disabled_color", type, new Color("9baebb"))`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetColor("font_disabled_color", type, new Color("9baebb"));`
- `Godot.Theme.SetColor(Godot.StringName, Godot.StringName, Godot.Color)`；输入表达式：`theme.SetColor("font_hover_color", type, Colors.White)`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetColor("font_hover_color", type, Colors.White);`
- `Godot.Theme.SetColor(Godot.StringName, Godot.StringName, Godot.Color)`；输入表达式：`theme.SetColor("font_placeholder_color", "LineEdit", Muted)`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetColor("font_placeholder_color", "LineEdit", Muted);`
- `Godot.Theme.SetColor(Godot.StringName, Godot.StringName, Godot.Color)`；输入表达式：`theme.SetColor("font_placeholder_color", "TextEdit", Muted)`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetColor("font_placeholder_color", "TextEdit", Muted);`
- `Godot.Theme.SetColor(Godot.StringName, Godot.StringName, Godot.Color)`；输入表达式：`theme.SetColor("font_pressed_color", type, Gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetColor("font_pressed_color", type, Gold);`
- `Godot.Theme.SetConstant(Godot.StringName, Godot.StringName, int)`；输入表达式：`theme.SetConstant("check_v_offset","CheckButton",0)`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetConstant("check_v_offset","CheckButton",0);`
- `Godot.Theme.SetConstant(Godot.StringName, Godot.StringName, int)`；输入表达式：`theme.SetConstant("h_separation", "CheckBox", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetConstant("h_separation", "CheckBox", 10);`
- `Godot.Theme.SetConstant(Godot.StringName, Godot.StringName, int)`；输入表达式：`theme.SetConstant("h_separation","CheckButton",8)`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetConstant("h_separation","CheckButton",8);`
- `Godot.Theme.SetConstant(Godot.StringName, Godot.StringName, int)`；输入表达式：`theme.SetConstant("separation", "HBoxContainer", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetConstant("separation", "HBoxContainer", 16);`
- `Godot.Theme.SetConstant(Godot.StringName, Godot.StringName, int)`；输入表达式：`theme.SetConstant("separation", "VBoxContainer", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetConstant("separation", "VBoxContainer", 12);`
- `Godot.Theme.SetFontSize(Godot.StringName, Godot.StringName, int)`；输入表达式：`theme.SetFontSize("font_size","CheckButton",15)`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetFontSize("font_size","CheckButton",15);`
- `Godot.Theme.SetIcon(Godot.StringName, Godot.StringName, Godot.Texture2D)`；输入表达式：`theme.SetIcon(key,"CheckButton",icon)`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetIcon(key,"CheckButton",icon);`
- `Godot.Theme.SetIcon(Godot.StringName, Godot.StringName, Godot.Texture2D)`；输入表达式：`theme.SetIcon(state + "_disabled", "CheckBox", icon)`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetIcon(state + "_disabled", "CheckBox", icon);`
- `Godot.Theme.SetIcon(Godot.StringName, Godot.StringName, Godot.Texture2D)`；输入表达式：`theme.SetIcon(state, "CheckBox", icon)`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetIcon(state, "CheckBox", icon);`
- `Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；输入表达式：`theme.SetStylebox("disabled", type, Box("111e2b", "263746", 8, 14))`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetStylebox("disabled", type, Box("111e2b", "263746", 8, 14));`
- `Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；输入表达式：`theme.SetStylebox("focus", "LineEdit", Box("172e3e", "70d4bc", 8, 12))`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetStylebox("focus", "LineEdit", Box("172e3e", "70d4bc", 8, 12));`
- `Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；输入表达式：`theme.SetStylebox("focus", type, focus)`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetStylebox("focus", type, focus);`
- `Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；输入表达式：`theme.SetStylebox("focus","CheckButton",Box("00000000","80e7db",5,0))`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetStylebox("focus","CheckButton",Box("00000000","80e7db",5,0));`
- `Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；输入表达式：`theme.SetStylebox("grabber", "VScrollBar", Box("425c6b", "425c6b", 3, 4))`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetStylebox("grabber", "VScrollBar", Box("425c6b", "425c6b", 3, 4));`
- `Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；输入表达式：`theme.SetStylebox("grabber_highlight", "VScrollBar", Box("69dfd3", "69dfd3", 3, 4))`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetStylebox("grabber_highlight", "VScrollBar", Box("69dfd3", "69dfd3", 3, 4));`
- `Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；输入表达式：`theme.SetStylebox("grabber_pressed", "VScrollBar", Box("c4f36b", "c4f36b", 3, 4))`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetStylebox("grabber_pressed", "VScrollBar", Box("c4f36b", "c4f36b", 3, 4));`
- `Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；输入表达式：`theme.SetStylebox("hover", "PopupMenu", Box("28495a", radius: 4, padding: 8))`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetStylebox("hover", "PopupMenu", Box("28495a", radius: 4, padding: 8));`
- `Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；输入表达式：`theme.SetStylebox("hover", type, Box("28495a", "70d4bc", 8, 14))`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetStylebox("hover", type, Box("28495a", "70d4bc", 8, 14));`
- `Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；输入表达式：`theme.SetStylebox("hover_pressed", type, Box("304f60", "70d4bc", 8, 14))`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetStylebox("hover_pressed", type, Box("304f60", "70d4bc", 8, 14));`
- `Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；输入表达式：`theme.SetStylebox("normal", "LineEdit", Box("101c2a", "395365", 8, 12))`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetStylebox("normal", "LineEdit", Box("101c2a", "395365", 8, 12));`
- `Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；输入表达式：`theme.SetStylebox("normal", type, Box("1d3040", "395365", 8, 14))`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetStylebox("normal", type, Box("1d3040", "395365", 8, 14));`
- `Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；输入表达式：`theme.SetStylebox("panel", "PopupMenu", Box("122331"))`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetStylebox("panel", "PopupMenu", Box("122331"));`
- `Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；输入表达式：`theme.SetStylebox("pressed", type, Box("304f60", "e5c18b", 8, 14))`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetStylebox("pressed", type, Box("304f60", "e5c18b", 8, 14));`
- `Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；输入表达式：`theme.SetStylebox("scroll", "VScrollBar", Box("0b1520", "0b1520", 3, 4))`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetStylebox("scroll", "VScrollBar", Box("0b1520", "0b1520", 3, 4));`
- `Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；输入表达式：`theme.SetStylebox(state,"CheckButton",Box(lit?"28434c":"142632",lit?"658c91":"395365",5,6))`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetStylebox(state,"CheckButton",Box(lit?"28434c":"142632",lit?"658c91":"395365",5,6));`
- `Godot.Theme.Theme()`；输入表达式：`new Theme { DefaultFontSize = 19 }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Theme { DefaultFontSize = 19 }`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`Box("00000000", "789aa4", 8, 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Box("00000000", "789aa4", 8, 0)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`Box("00000000","80e7db",5,0)`；返回值紧邻使用处：`ArgumentSyntax: Box("00000000","80e7db",5,0)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`Box("0b1520", "0b1520", 3, 4)`；返回值紧邻使用处：`ArgumentSyntax: Box("0b1520", "0b1520", 3, 4)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`Box("101c2a", "395365", 8, 12)`；返回值紧邻使用处：`ArgumentSyntax: Box("101c2a", "395365", 8, 12)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`Box("111e2b", "263746", 8, 14)`；返回值紧邻使用处：`ArgumentSyntax: Box("111e2b", "263746", 8, 14)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`Box("122331")`；返回值紧邻使用处：`ArgumentSyntax: Box("122331")`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`Box("172e3e", "70d4bc", 8, 12)`；返回值紧邻使用处：`ArgumentSyntax: Box("172e3e", "70d4bc", 8, 12)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`Box("1d3040", "395365", 8, 14)`；返回值紧邻使用处：`ArgumentSyntax: Box("1d3040", "395365", 8, 14)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`Box("28495a", "70d4bc", 8, 14)`；返回值紧邻使用处：`ArgumentSyntax: Box("28495a", "70d4bc", 8, 14)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`Box("28495a", radius: 4, padding: 8)`；返回值紧邻使用处：`ArgumentSyntax: Box("28495a", radius: 4, padding: 8)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`Box("304f60", "70d4bc", 8, 14)`；返回值紧邻使用处：`ArgumentSyntax: Box("304f60", "70d4bc", 8, 14)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`Box("304f60", "e5c18b", 8, 14)`；返回值紧邻使用处：`ArgumentSyntax: Box("304f60", "e5c18b", 8, 14)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`Box("425c6b", "425c6b", 3, 4)`；返回值紧邻使用处：`ArgumentSyntax: Box("425c6b", "425c6b", 3, 4)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`Box("69dfd3", "69dfd3", 3, 4)`；返回值紧邻使用处：`ArgumentSyntax: Box("69dfd3", "69dfd3", 3, 4)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`Box("c4f36b", "c4f36b", 3, 4)`；返回值紧邻使用处：`ArgumentSyntax: Box("c4f36b", "c4f36b", 3, 4)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`Box(lit?"28434c":"142632",lit?"658c91":"395365",5,6)`；返回值紧邻使用处：`ArgumentSyntax: Box(lit?"28434c":"142632",lit?"658c91":"395365",5,6)`
- `NationalSpire.CareerVisuals.InterfaceText(int, int)`；输入表达式：`InterfaceText(tracking: 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: theme.DefaultFont = InterfaceText(tracking: 0)`

**赋值（含属性/字段和局部值）：**

- `DefaultFontSize` = `19`
- `_theme` = `theme`
- `focus.BorderWidthBottom` = `2`
- `focus.BorderWidthLeft` = `focus.BorderWidthTop = focus.BorderWidthRight = focus.BorderWidthBottom = 2`
- `focus.BorderWidthRight` = `focus.BorderWidthBottom = 2`
- `focus.BorderWidthTop` = `focus.BorderWidthRight = focus.BorderWidthBottom = 2`
- `theme.DefaultFont` = `InterfaceText(tracking: 0)`

<a id="symbol-2e147648c65a"></a>

## `NationalSpire.CareerArt.Compact — public bool Compact`

来源：源码第 172 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d84f3eec1f4c"></a>

## `NationalSpire.CareerArt._Ready() — public override void _Ready()`

来源：源码第 173 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Resized` += `QueueRedraw`

<a id="symbol-867304600ece"></a>

## `NationalSpire.CareerArt._Draw() — public override void _Draw()`

来源：源码第 174 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；`Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；`Godot.Color.Color(float, float, float, float)`；`Godot.Color.Color(string)`；`Godot.Vector2.Vector2(float, float)`；[`P(float, float)`](CareerVisuals.cs.md#symbol-b04f436ef063)；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerArt.Compact`；`NationalSpire.CareerVisuals.Gold`；`P(float, float)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(center, r * .78f, -.8f, 3.6f, 64, new Color("587e72"), 2, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(center, r * .78f, -.8f, 3.6f, 64, new Color("587e72"), 2, true);`
- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(center, r, 0, Mathf.Tau, 96, faint, 1.5f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(center, r, 0, Mathf.Tau, 96, faint, 1.5f, true);`
- `Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；输入表达式：`DrawCircle(P(.1f, -1.13f), 4, CareerVisuals.Gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawCircle(P(.1f, -1.13f), 4, CareerVisuals.Gold);`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon([P(-.6f, .85f), P(-.38f, -.12f), P(-.14f, .05f), P(.1f, -1.02f), P(.34f, -.35f), P(.44f, .85f)], new Color("355c56"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon([P(-.6f, .85f), P(-.38f, -.12f), P(-.14f, .05f), P(.1f, -1.02f), P(.34f, -.35f), P(.44f, .85f)], new Color("355c56"));`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(P(-.05f, .16f + i * .17f), P(.23f, .16f + i * .17f), new Color("9ba886"), 2, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(P(-.05f, .16f + i * .17f), P(.23f, .16f + i * .17f), new Color("9ba886"), 2, true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(center + new Vector2(-r * 1.35f, 0), center + new Vector2(r * 1.35f, 0), faint, 1, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(center + new Vector2(-r * 1.35f, 0), center + new Vector2(r * 1.35f, 0), faint, 1, true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(center + new Vector2(0, -r * 1.35f), center + new Vector2(0, r * 1.35f), faint, 1, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(center + new Vector2(0, -r * 1.35f), center + new Vector2(0, r * 1.35f), faint, 1, true);`
- `Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；输入表达式：`DrawPolyline([P(-.6f,.85f), P(-.38f,-.12f), P(-.14f,.05f), P(.1f,-1.02f), P(.34f,-.35f), P(.44f,.85f)], CareerVisuals.Gold, 2, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline([P(-.6f,.85f), P(-.38f,-.12f), P(-.14f,.05f), P(.1f,-1.02f), P(.34f,-.35f), P(.44f,.85f)], CareerVisuals.Gold, 2, true);`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(.44f, .83f, .74f, .14f)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Color(.44f, .83f, .74f, .14f)`
- `Godot.Color.Color(string)`；输入表达式：`new Color("355c56")`；返回值紧邻使用处：`ArgumentSyntax: new Color("355c56")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("587e72")`；返回值紧邻使用处：`ArgumentSyntax: new Color("587e72")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("9ba886")`；返回值紧邻使用处：`ArgumentSyntax: new Color("9ba886")`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-r * 1.35f, 0)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(-r * 1.35f, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, -r * 1.35f)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(0, -r * 1.35f)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, r * 1.35f)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(0, r * 1.35f)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(Size.X * (Compact ? .5f : .65f), Size.Y * .47f)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Vector2(Size.X * (Compact ? .5f : .65f), Size.Y * .47f)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(r * 1.35f, 0)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(r * 1.35f, 0)`
- `P(float, float)`；输入表达式：`P(-.05f, .16f + i * .17f)`；返回值紧邻使用处：`ArgumentSyntax: P(-.05f, .16f + i * .17f)`
- `P(float, float)`；输入表达式：`P(-.14f, .05f)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-.14f, .05f)`
- `P(float, float)`；输入表达式：`P(-.14f,.05f)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-.14f,.05f)`
- `P(float, float)`；输入表达式：`P(-.38f, -.12f)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-.38f, -.12f)`
- `P(float, float)`；输入表达式：`P(-.38f,-.12f)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-.38f,-.12f)`
- `P(float, float)`；输入表达式：`P(-.6f, .85f)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-.6f, .85f)`
- `P(float, float)`；输入表达式：`P(-.6f,.85f)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-.6f,.85f)`
- `P(float, float)`；输入表达式：`P(.1f, -1.02f)`；返回值紧邻使用处：`ExpressionElementSyntax: P(.1f, -1.02f)`
- `P(float, float)`；输入表达式：`P(.1f, -1.13f)`；返回值紧邻使用处：`ArgumentSyntax: P(.1f, -1.13f)`
- `P(float, float)`；输入表达式：`P(.1f,-1.02f)`；返回值紧邻使用处：`ExpressionElementSyntax: P(.1f,-1.02f)`
- `P(float, float)`；输入表达式：`P(.23f, .16f + i * .17f)`；返回值紧邻使用处：`ArgumentSyntax: P(.23f, .16f + i * .17f)`
- `P(float, float)`；输入表达式：`P(.34f, -.35f)`；返回值紧邻使用处：`ExpressionElementSyntax: P(.34f, -.35f)`
- `P(float, float)`；输入表达式：`P(.34f,-.35f)`；返回值紧邻使用处：`ExpressionElementSyntax: P(.34f,-.35f)`
- `P(float, float)`；输入表达式：`P(.44f, .85f)`；返回值紧邻使用处：`ExpressionElementSyntax: P(.44f, .85f)`
- `P(float, float)`；输入表达式：`P(.44f,.85f)`；返回值紧邻使用处：`ExpressionElementSyntax: P(.44f,.85f)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(Size.X, Size.Y)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Min(Size.X, Size.Y) * .34f`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b04f436ef063"></a>

## `P(float, float) — Vector2 P(float x, float y)`

来源：源码第 183 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerArt._Draw()`](CareerVisuals.cs.md#symbol-867304600ece)

**调用：** `Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(x, y)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(x, y) * r`

**赋值（含属性/字段和局部值）：**
