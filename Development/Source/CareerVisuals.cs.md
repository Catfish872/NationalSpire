# CareerVisuals.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`5522FB49F1D9E3212B07BE437396A8C05A566BB67E16C619541B14410201F38D`。来源：[源码](../../CareerVisuals.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerVisuals`、`NationalSpire.CareerArt`。

字段、事件及初始值（源码原样）：

```csharp
private static Font? _font;
private static Theme? _theme;
public static readonly Color Ink = new("f2f6fa"), Muted = new("bbcad6"), Gold = new("eed39b"), Teal = new("80e7db"), Lime = new("c4f36b");
```

<a id="symbol-da585957e2e0"></a>

## `NationalSpire.CareerVisuals.WarmText(string) — internal static void WarmText(string text)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerListCache._Process(double)`](CareerListCache.cs.md#symbol-e8085c360313)

**调用：** [`NationalSpire.CareerVisuals.InterfaceFont()`](CareerVisuals.cs.md#symbol-4b83714363d0)；`Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.InterfaceFont()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；输入表达式：`InterfaceFont().GetStringSize(text, fontSize: 19)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => InterfaceFont().GetStringSize(text, fontSize: 19)`
- `NationalSpire.CareerVisuals.InterfaceFont()`；输入表达式：`InterfaceFont()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: InterfaceFont().GetStringSize`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4b83714363d0"></a>

## `NationalSpire.CareerVisuals.InterfaceFont() — private static Font InterfaceFont()`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerVisuals.CreateTheme()`](CareerVisuals.cs.md#symbol-a5f88af9f360)；[`NationalSpire.CareerVisuals.WarmText(string)`](CareerVisuals.cs.md#symbol-da585957e2e0)

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

<a id="symbol-561d8fe38106"></a>

## `NationalSpire.CareerVisuals.ClearContent(Godot.Node) — public static void ClearContent(Node parent)`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Calendar()`](PrivateMessageScreen.cs.md#symbol-b1df6df4c515)；[`Draw()`](DateSceneAssetScreen.cs.md#symbol-1f678296da64)；[`Gallery()`](AvatarScreen.cs.md#symbol-e01b201de3dc)；[`NationalSpire.CareerScreen.EditFailedDateScene()`](DateSceneScreen.cs.md#symbol-11eaa513a64e)；[`NationalSpire.CareerScreen.RefreshDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityScreen.cs.md#symbol-ad7fb59cd134)；[`NationalSpire.CareerScreen.RefreshGroupChat()`](GroupChatScreen.cs.md#symbol-b56fe79b2db7)；[`NationalSpire.CareerScreen.RefreshPrivateAttachments()`](PrivateMemoryScreen.cs.md#symbol-b9d6c2084031)；[`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)；[`NationalSpire.CareerScreen.RefreshPrivateProposal()`](PrivateMessageScreen.cs.md#symbol-fcf77d9c4194)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.RenderWeeklySlide(NationalSpire.CareerData, bool)`](WeeklyScreen.cs.md#symbol-184e7ff58940)；[`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)；[`NationalSpire.CareerScreen.ToggleDiscussion(NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-10637dfc37f0)；[`NationalSpire.Coop.CoopScreen.Render()`](Coop/CoopScreen.cs.md#symbol-adc6058122f7)；[`Refresh()`](MentionComposer.cs.md#symbol-13231b1d37b1)；[`Section(string)`](PrivateMemoryScreen.cs.md#symbol-7f736cfb08b6)；[`Show(bool)`](CommunityReplyExpressions.cs.md#symbol-5bada39e1ed4)

**调用：** [`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；`Godot.CanvasItem.Hide()`；`Godot.GodotObject.GetInstanceId()`；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.Node.GetChildren(bool)`；`Godot.Node.QueueFree()`

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

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BeginReply(NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-6bc7befbb991)；[`NationalSpire.CareerScreen.CloseThreadReply(string, string)`](CommunityScreen.cs.md#symbol-65baf7e888c9)；[`NationalSpire.CareerScreen.CompleteThreadReply(string, string, string)`](CommunityScreen.cs.md#symbol-d9fcfe778254)；[`NationalSpire.CareerScreen.FocusComposerAsync(string)`](CommunityScreen.cs.md#symbol-1b316c95919c)；[`NationalSpire.CareerScreen.GiftRecipientPicker(NationalSpire.CareerData, NationalSpire.Good, int, bool, string?, int, bool)`](ConsumerGiftScreen.cs.md#symbol-55244dcd20ef)；[`NationalSpire.CareerScreen.PrivateGiftPicker()`](ConsumerGiftScreen.cs.md#symbol-53b0d3e663d2)；[`NationalSpire.CareerScreen.RebuildThreadReplies(NationalSpire.CareerData, NationalSpire.CommunityPost, System.Action)`](CommunityScreen.cs.md#symbol-283b456d2a7a)；[`NationalSpire.CareerScreen.RefreshDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityScreen.cs.md#symbol-ad7fb59cd134)；[`NationalSpire.CareerScreen.RenderReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.PanelContainer?)`](CommunityScreen.cs.md#symbol-85990747d510)；[`NationalSpire.CareerScreen.RenderRootReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityScreen.cs.md#symbol-f92fad8b113e)；[`NationalSpire.CareerScreen.RenderWeeklySlide(NationalSpire.CareerData, bool)`](WeeklyScreen.cs.md#symbol-184e7ff58940)；[`NationalSpire.CareerScreen.RetireReplyComposer()`](CommunityScreen.cs.md#symbol-aebacdaad363)；[`NationalSpire.CareerScreen.ShareDiscussion(string, string)`](CommunityShareScreen.cs.md#symbol-038b648fdc83)；[`NationalSpire.CareerScreen.ToggleDiscussion(NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-10637dfc37f0)；[`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`](CareerVisuals.cs.md#symbol-347d38705528)

**调用：** [`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`](CareerVisuals.cs.md#symbol-347d38705528)；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.Node.GetChildren(bool)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`child.IsQueuedForDeletion()`；返回值紧邻使用处：`IfStatementSyntax: if (child.IsQueuedForDeletion()) continue;`
- `Godot.Node.GetChildren(bool)`；输入表达式：`parent.GetChildren()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var child in parent.GetChildren())          {              if (child.IsQueuedForDeletion()) continue;              if (child.Name == name) return child;              if (FindContent(child, name) is { } found) return found;          }`
- `NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`；输入表达式：`FindContent(child, name)`；返回值紧邻使用处：`IsPatternExpressionSyntax: FindContent(child, name) is { } found`

**赋值（含属性/字段和局部值）：**


<a id="symbol-96a89aa3b493"></a>

## `NationalSpire.CareerVisuals.Box(string, string, int, int) — public static StyleBoxFlat Box(string fill, string border = "304554", int radius = 8, int padding = 20)`

来源：源码第 49 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Action(string, int)`](ConsumerGiftControls.cs.md#symbol-b0521545852f)；[`DrawPage()`](PortraitDesignScreen.cs.md#symbol-4a5867e03395)；[`Highlight()`](MentionComposer.cs.md#symbol-3e7861204903)；[`Memo(Godot.Control, string, string, System.Action<string>, string?)`](CharacterCardScreen.cs.md#symbol-203ab71fae9d)；[`Metric(string, string, string, Godot.Color, bool)`](OwnedClubScreen.cs.md#symbol-531f8b9327ea)；[`NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string, System.Action<System.Action>?)`](AiSettingsPanel.cs.md#symbol-8fb9cbc85381)；[`NationalSpire.CalendarDayButton._Ready()`](CalendarDayButton.cs.md#symbol-48874665eb45)；[`NationalSpire.CareerAvatar._Draw()`](CareerAvatars.cs.md#symbol-d0d51d45c800)；[`NationalSpire.CareerListCache.AddProfile()`](CareerListCache.cs.md#symbol-25cd78ebfabe)；[`NationalSpire.CareerScreen.AddMentionPicker(Godot.TextEdit, Godot.VBoxContainer)`](MentionComposer.cs.md#symbol-8702f28d36a7)；[`NationalSpire.CareerScreen.AddPausedDateScenes(NationalSpire.CareerData, NationalSpire.PrivateConversation)`](DateSceneScreen.cs.md#symbol-a5b10d9fb0b8)；[`NationalSpire.CareerScreen.AddPrivateBubble(string, bool, NationalSpire.PrivateTurn)`](PrivateMessageScreen.cs.md#symbol-b24b4d693d2a)；[`NationalSpire.CareerScreen.AddPrivateMood(NationalSpire.PrivateMood)`](PrivateMemoryScreen.cs.md#symbol-1cd11d02c1b9)；[`NationalSpire.CareerScreen.AddPrivateOath(NationalSpire.CareerData, NationalSpire.PrivateRelation)`](PrivateOathScreen.cs.md#symbol-bcbfed5b53c6)；[`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-c7881d245b3d)；[`NationalSpire.CareerScreen.AddPrivateProfileChange(NationalSpire.PrivateProfileChange)`](PrivateMemoryScreen.cs.md#symbol-cd1de98ddea7)；[`NationalSpire.CareerScreen.ArbitrationCard(NationalSpire.CareerData, NationalSpire.ArbitrationRecord)`](ArbitrationScreen.cs.md#symbol-8d41f13d5476)；[`NationalSpire.CareerScreen.Build()`](CareerScreen.cs.md#symbol-8b4784fe3138)；[`NationalSpire.CareerScreen.BuildPrivateComposerActions(Godot.VBoxContainer)`](PrivateMessageScreen.cs.md#symbol-a7be0d6513a6)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.CeremonyAwards(NationalSpire.CareerData, NationalSpire.CeremonyRecord)`](CeremonyScreen.cs.md#symbol-554512484279)；[`NationalSpire.CareerScreen.CeremonyHero(NationalSpire.CareerData, NationalSpire.CeremonyRecord)`](CeremonyScreen.cs.md#symbol-7344f4112178)；[`NationalSpire.CareerScreen.CeremonyInvitation(NationalSpire.CareerData)`](CeremonyScreen.cs.md#symbol-fe94e59081ff)；[`NationalSpire.CareerScreen.CeremonyRanking(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CeremonyRank>)`](CeremonyScreen.cs.md#symbol-73500bb64a58)；[`NationalSpire.CareerScreen.CeremonyWeeklyCover(NationalSpire.CareerData, NationalSpire.WeeklySlide, bool)`](CeremonyScreen.cs.md#symbol-96e48591b6f3)；[`NationalSpire.CareerScreen.ClubCard(string, string?, bool)`](OwnedClubScreen.cs.md#symbol-dea530bc8e29)；[`NationalSpire.CareerScreen.ClubDirectory(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-27a995f7ce9f)；[`NationalSpire.CareerScreen.CompetitionOverview(NationalSpire.CareerData, NationalSpire.CompetitionReview)`](SettlementScreen.cs.md#symbol-f0fb4e109457)；[`NationalSpire.CareerScreen.ContactMenu(Godot.Vector2, System.Action<Godot.VBoxContainer>, int)`](ChatContactScreen.cs.md#symbol-20cc99232e33)；[`NationalSpire.CareerScreen.DateDiaryEntryDialog(NationalSpire.CareerData, string, string)`](DateDiaryScreen.cs.md#symbol-fb4ba1a3b5fa)；[`NationalSpire.CareerScreen.Emphasize(Godot.Button)`](BroadcastVisuals.cs.md#symbol-ddd68d13b687)；[`NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`](BroadcastVisuals.cs.md#symbol-15d48434171e)；[`NationalSpire.CareerScreen.GroupBubble(string, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>?)`](GroupChatScreen.cs.md#symbol-870e7cca58c0)；[`NationalSpire.CareerScreen.GroupOffer(NationalSpire.GroupChat, NationalSpire.GroupEffect, NationalSpire.PrivateOffer)`](GroupChatScreen.cs.md#symbol-3afa41099b93)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)；[`NationalSpire.CareerScreen.OpenCharacterCardCore(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?, NationalSpire.CharacterDesignPackage.Imported?)`](CharacterCardScreen.cs.md#symbol-c2fe452ad056)；[`NationalSpire.CareerScreen.OpenPortraitDesigner(NationalSpire.CareerData, string)`](PortraitDesignScreen.cs.md#symbol-3bb5119a73ca)；[`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.PlayerBanner(NationalSpire.CareerData, string)`](BroadcastVisuals.cs.md#symbol-936e32073293)；[`NationalSpire.CareerScreen.PrivateArbitrationDialog()`](ArbitrationScreen.cs.md#symbol-63e3d9aaa6df)；[`NationalSpire.CareerScreen.PrivateAttachmentCard(NationalSpire.PrivateOffer, bool)`](PrivateMemoryScreen.cs.md#symbol-eb2b2a37c5d1)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.PrivateEditor(string, int, int)`](PrivateMemoryScreen.cs.md#symbol-1c1072fdb98b)；[`NationalSpire.CareerScreen.PrivateIdentity(NationalSpire.CareerData, string, bool)`](PrivateMemoryScreen.cs.md#symbol-65caddca194f)；[`NationalSpire.CareerScreen.PrivateIdentityButton(string, System.Action, bool)`](PrivateMemoryScreen.cs.md#symbol-67f8f263b4a9)；[`NationalSpire.CareerScreen.PrivateLineupCard(NationalSpire.CareerData, NationalSpire.CoachLineupRequest, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?)`](CoachScreen.cs.md#symbol-c01675f974f7)；[`NationalSpire.CareerScreen.PrivateProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](PrivateMessageScreen.cs.md#symbol-8e28d3a34860)；[`NationalSpire.CareerScreen.PrivateTrainingCard(NationalSpire.CareerData, NationalSpire.CoachTrainingPlan, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?)`](CoachScreen.cs.md#symbol-c2e37e4a0f14)；[`NationalSpire.CareerScreen.ProfileSection(string)`](ProfileScreen.cs.md#symbol-078e0ffb0ebe)；[`NationalSpire.CareerScreen.RefreshGroupChat()`](GroupChatScreen.cs.md#symbol-b56fe79b2db7)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.RenderWeeklyDetail(NationalSpire.CareerData)`](WeeklyScreen.cs.md#symbol-b3f0ffc5fb7d)；[`NationalSpire.CareerScreen.RenderWeeklySlide(NationalSpire.CareerData, bool)`](WeeklyScreen.cs.md#symbol-184e7ff58940)；[`NationalSpire.CareerScreen.Settlement(NationalSpire.CareerData)`](SettlementScreen.cs.md#symbol-ec46df6667fd)；[`NationalSpire.CareerScreen.ShareDiscussion(string, string)`](CommunityShareScreen.cs.md#symbol-038b648fdc83)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`](CareerDialog.cs.md#symbol-d832b736b02b)；[`NationalSpire.CareerScreen.WeeklyArt(NationalSpire.WeeklyEdition, NationalSpire.WeeklySlide, bool)`](WeeklyScreen.cs.md#symbol-d6f13958bba4)；[`NationalSpire.CareerVisuals.CreateTheme()`](CareerVisuals.cs.md#symbol-a5f88af9f360)；[`NationalSpire.CommunityReplyButton._Ready()`](CommunityDiscussionVisuals.cs.md#symbol-1e11e4f0b913)；[`NationalSpire.CommunityReplyExpressions.CategoryButton(string, string, int)`](CommunityReplyExpressions.cs.md#symbol-8fcfa40b1631)；[`NationalSpire.CommunityReportButton._Ready()`](CommunityDiscussionVisuals.cs.md#symbol-a9c948c158eb)；[`NationalSpire.CommunityShareButton._Ready()`](CommunityDiscussionVisuals.cs.md#symbol-c9b514864c3c)；[`NationalSpire.CommunityVoteButton._Ready()`](CommunityDiscussionVisuals.cs.md#symbol-19ed81df80db)；[`NationalSpire.ConsumerQuantity.Initialize(int)`](ConsumerGiftControls.cs.md#symbol-a0db04226b0a)；[`NationalSpire.ConsumerVisuals.Style(bool, bool)`](ConsumerVisuals.cs.md#symbol-340545590823)；[`NationalSpire.Coop.CoopLive.ConfirmStop()`](Coop/CoopLive.cs.md#symbol-30b59f1772bc)；[`NationalSpire.Coop.CoopScreen.Card(Godot.Node, string, Godot.Color?)`](Coop/CoopScreen.cs.md#symbol-eab6cd747232)；[`NationalSpire.Coop.CoopScreen.WaitingRoom(NationalSpire.Coop.CoopWorld)`](Coop/CoopScreen.cs.md#symbol-b46abec89d85)；[`NationalSpire.DateSceneView._Ready()`](DateSceneView.cs.md#symbol-db339768c993)；[`NationalSpire.DateSceneView.ActionButton(string, System.Action, string, int)`](DateSceneView.cs.md#symbol-1ed75a76342e)；[`NationalSpire.DateSceneView.WaitingBubble()`](DateSceneWaiting.cs.md#symbol-865fad94731c)；[`NationalSpire.GroupAvatar._Draw()`](GroupAvatar.cs.md#symbol-7d1ac12346aa)；[`NationalSpire.LiveRaceHud._Ready()`](LiveRaceHud.cs.md#symbol-b5a8cd9a2617)；[`NationalSpire.LiveRaceHud.SpeechPanel(string, string, string, NationalSpire.AvatarArt?, NationalSpire.AvatarIdentity?, bool)`](LiveRaceHud.cs.md#symbol-53c07f0e6874)；[`NationalSpire.MarketTerminal.Build()`](MarketTerminal.cs.md#symbol-285abee5b9f5)；[`NationalSpire.MarketTerminal.MarketTerminal()`](MarketTerminal.cs.md#symbol-ca583ab46f87)；[`NationalSpire.MarketTerminal.Panel(Godot.Node, float)`](MarketTerminal.cs.md#symbol-3d766989e03d)；[`NationalSpire.MarketVisuals.ActionStyle(Godot.Button, string)`](MarketVisuals.cs.md#symbol-5703b8242580)；[`NationalSpire.MarketVisuals.Card(string, bool, bool)`](MarketVisuals.cs.md#symbol-aef7b9c00c48)；[`NationalSpire.PrivateMoodButton._Ready()`](PrivateMemoryScreen.cs.md#symbol-43448ac9d3a0)；[`NationalSpire.RivalMapOverlay._Ready()`](LiveRaceHud.cs.md#symbol-71fa48f8cc62)；[`Preview()`](NpcAvatarFrameScreen.cs.md#symbol-81e2560db041)；[`Rows()`](ConsumerGiftScreen.cs.md#symbol-136ca1d3e38e)；[`Section(string)`](PrivateMemoryScreen.cs.md#symbol-7f736cfb08b6)；[`ShowRows()`](CommunityShareScreen.cs.md#symbol-2e7b710b7d77)；[`Side(System.Collections.Generic.List<NationalSpire.CompetitionPlayer>, string)`](SettlementScreen.cs.md#symbol-49b1e1a15f4b)；[`Update(string)`](PrivateMemoryScreen.cs.md#symbol-22551d099964)

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

来源：源码第 56 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerListCache.For(Godot.Node)`](CareerListCache.cs.md#symbol-eba9914ced8b)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.OpenView(Godot.Control, NationalSpire.ICareerSession?, string?)`](CareerScreen.cs.md#symbol-2b6ef58a9693)；[`NationalSpire.Coop.CoopLive.ConfirmStop()`](Coop/CoopLive.cs.md#symbol-30b59f1772bc)；[`NationalSpire.Coop.CoopMenuPatch.Postfix(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu)`](Coop/CoopRuntime.cs.md#symbol-898c6637244f)；[`NationalSpire.Coop.CoopScreen.Open(Godot.Control, bool)`](Coop/CoopScreen.cs.md#symbol-c9ac083daf6c)；[`NationalSpire.LiveRaceHud._Ready()`](LiveRaceHud.cs.md#symbol-b5a8cd9a2617)；[`NationalSpire.MarketTerminal.MarketTerminal()`](MarketTerminal.cs.md#symbol-ca583ab46f87)；[`NationalSpire.MenuPatch.Postfix(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu)`](GameBridge.cs.md#symbol-6939e359db40)；[`NationalSpire.RivalMapOverlay._Ready()`](LiveRaceHud.cs.md#symbol-71fa48f8cc62)

**调用：** [`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.CareerVisuals.InterfaceFont()`](CareerVisuals.cs.md#symbol-4b83714363d0)；`Godot.Color.Color(string)`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Image.Image()`；`Godot.Image.LoadSvgFromString(string, float)`；`Godot.ImageTexture.CreateFromImage(Godot.Image)`；`Godot.Theme.SetColor(Godot.StringName, Godot.StringName, Godot.Color)`；`Godot.Theme.SetConstant(Godot.StringName, Godot.StringName, int)`；`Godot.Theme.SetIcon(Godot.StringName, Godot.StringName, Godot.Texture2D)`；`Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；`Godot.Theme.Theme()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals._theme`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Gold`；`NationalSpire.CareerVisuals.Ink`；`NationalSpire.CareerVisuals.InterfaceFont()`；`NationalSpire.CareerVisuals.Muted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("9baebb")`；返回值紧邻使用处：`ArgumentSyntax: new Color("9baebb")`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(_theme)`；返回值紧邻使用处：`BinaryExpressionSyntax: _theme != null && GodotObject.IsInstanceValid(_theme)`
- `Godot.Image.Image()`；输入表达式：`new Image()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Image()`
- `Godot.Image.LoadSvgFromString(string, float)`；输入表达式：`image.LoadSvgFromString("<svg xmlns='http://www.w3.org/2000/svg' width='20' height='20'><rect x='1' y='1' width='18' height='18' rx='4' fill='#142536' stroke='#82b8bc' stroke-width='2'/>"                  + (selected ? "<path d='M5 10 L9 14 L15 6' fill='none' stroke='#70d4bc' stroke-width='2.5'/>" : "") + "</svg>")`；返回值紧邻使用处：`ExpressionStatementSyntax: image.LoadSvgFromString("<svg xmlns='http://www.w3.org/2000/svg' width='20' height='20'><rect x='1' y='1' width='18' height='18' rx='4' fill='#142536' stroke='#82b8bc' stroke-width='2'/>"                  + (selected ? "<path d='M5 10 L9 14 L15 6' fill='none' stroke='#70d4bc' stroke-width='2.5'/>" : "") + "</svg>");`
- `Godot.ImageTexture.CreateFromImage(Godot.Image)`；输入表达式：`ImageTexture.CreateFromImage(image)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ImageTexture.CreateFromImage(image)`
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
- `Godot.Theme.SetConstant(Godot.StringName, Godot.StringName, int)`；输入表达式：`theme.SetConstant("h_separation", "CheckBox", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetConstant("h_separation", "CheckBox", 10);`
- `Godot.Theme.SetConstant(Godot.StringName, Godot.StringName, int)`；输入表达式：`theme.SetConstant("separation", "HBoxContainer", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetConstant("separation", "HBoxContainer", 16);`
- `Godot.Theme.SetConstant(Godot.StringName, Godot.StringName, int)`；输入表达式：`theme.SetConstant("separation", "VBoxContainer", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetConstant("separation", "VBoxContainer", 12);`
- `Godot.Theme.SetIcon(Godot.StringName, Godot.StringName, Godot.Texture2D)`；输入表达式：`theme.SetIcon(state + "_disabled", "CheckBox", icon)`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetIcon(state + "_disabled", "CheckBox", icon);`
- `Godot.Theme.SetIcon(Godot.StringName, Godot.StringName, Godot.Texture2D)`；输入表达式：`theme.SetIcon(state, "CheckBox", icon)`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetIcon(state, "CheckBox", icon);`
- `Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；输入表达式：`theme.SetStylebox("disabled", type, Box("111e2b", "263746", 8, 14))`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetStylebox("disabled", type, Box("111e2b", "263746", 8, 14));`
- `Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；输入表达式：`theme.SetStylebox("focus", "LineEdit", Box("172e3e", "70d4bc", 8, 12))`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetStylebox("focus", "LineEdit", Box("172e3e", "70d4bc", 8, 12));`
- `Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；输入表达式：`theme.SetStylebox("focus", type, focus)`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetStylebox("focus", type, focus);`
- `Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；输入表达式：`theme.SetStylebox("grabber_highlight", "VScrollBar", Box("69dfd3", "69dfd3", 3, 4))`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetStylebox("grabber_highlight", "VScrollBar", Box("69dfd3", "69dfd3", 3, 4));`
- `Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；输入表达式：`theme.SetStylebox("grabber_pressed", "VScrollBar", Box("c4f36b", "c4f36b", 3, 4))`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetStylebox("grabber_pressed", "VScrollBar", Box("c4f36b", "c4f36b", 3, 4));`
- `Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；输入表达式：`theme.SetStylebox("grabber", "VScrollBar", Box("425c6b", "425c6b", 3, 4))`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetStylebox("grabber", "VScrollBar", Box("425c6b", "425c6b", 3, 4));`
- `Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；输入表达式：`theme.SetStylebox("hover_pressed", type, Box("304f60", "70d4bc", 8, 14))`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetStylebox("hover_pressed", type, Box("304f60", "70d4bc", 8, 14));`
- `Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；输入表达式：`theme.SetStylebox("hover", "PopupMenu", Box("28495a", radius: 4, padding: 8))`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetStylebox("hover", "PopupMenu", Box("28495a", radius: 4, padding: 8));`
- `Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；输入表达式：`theme.SetStylebox("hover", type, Box("28495a", "70d4bc", 8, 14))`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetStylebox("hover", type, Box("28495a", "70d4bc", 8, 14));`
- `Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；输入表达式：`theme.SetStylebox("normal", "LineEdit", Box("101c2a", "395365", 8, 12))`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetStylebox("normal", "LineEdit", Box("101c2a", "395365", 8, 12));`
- `Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；输入表达式：`theme.SetStylebox("normal", type, Box("1d3040", "395365", 8, 14))`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetStylebox("normal", type, Box("1d3040", "395365", 8, 14));`
- `Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；输入表达式：`theme.SetStylebox("panel", "PopupMenu", Box("122331"))`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetStylebox("panel", "PopupMenu", Box("122331"));`
- `Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；输入表达式：`theme.SetStylebox("pressed", type, Box("304f60", "e5c18b", 8, 14))`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetStylebox("pressed", type, Box("304f60", "e5c18b", 8, 14));`
- `Godot.Theme.SetStylebox(Godot.StringName, Godot.StringName, Godot.StyleBox)`；输入表达式：`theme.SetStylebox("scroll", "VScrollBar", Box("0b1520", "0b1520", 3, 4))`；返回值紧邻使用处：`ExpressionStatementSyntax: theme.SetStylebox("scroll", "VScrollBar", Box("0b1520", "0b1520", 3, 4));`
- `Godot.Theme.Theme()`；输入表达式：`new Theme { DefaultFontSize = 19 }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Theme { DefaultFontSize = 19 }`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`Box("00000000", "789aa4", 8, 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Box("00000000", "789aa4", 8, 0)`
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
- `NationalSpire.CareerVisuals.InterfaceFont()`；输入表达式：`InterfaceFont()`；返回值紧邻使用处：`AssignmentExpressionSyntax: theme.DefaultFont = InterfaceFont()`

**赋值（含属性/字段和局部值）：**

- `_theme` = `theme`
- `DefaultFontSize` = `19`
- `focus.BorderWidthBottom` = `2`
- `focus.BorderWidthLeft` = `focus.BorderWidthTop = focus.BorderWidthRight = focus.BorderWidthBottom = 2`
- `focus.BorderWidthRight` = `focus.BorderWidthBottom = 2`
- `focus.BorderWidthTop` = `focus.BorderWidthRight = focus.BorderWidthBottom = 2`
- `theme.DefaultFont` = `InterfaceFont()`

<a id="symbol-2e147648c65a"></a>

## `NationalSpire.CareerArt.Compact — public bool Compact`

来源：源码第 109 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d84f3eec1f4c"></a>

## `NationalSpire.CareerArt._Ready() — public override void _Ready()`

来源：源码第 110 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Resized` += `QueueRedraw`

<a id="symbol-867304600ece"></a>

## `NationalSpire.CareerArt._Draw() — public override void _Draw()`

来源：源码第 111 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`P(float, float)`](CareerVisuals.cs.md#symbol-b04f436ef063)；`Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；`Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；`Godot.Color.Color(float, float, float, float)`；`Godot.Color.Color(string)`；`Godot.Vector2.Vector2(float, float)`；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Gold`；`P(float, float)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(center, r * .78f, -.8f, 3.6f, 64, new Color("587e72"), 2, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(center, r * .78f, -.8f, 3.6f, 64, new Color("587e72"), 2, true);`
- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(center, r, 0, Mathf.Tau, 96, faint, 1.5f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(center, r, 0, Mathf.Tau, 96, faint, 1.5f, true);`
- `Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；输入表达式：`DrawCircle(P(.1f, -1.13f), 4, CareerVisuals.Gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawCircle(P(.1f, -1.13f), 4, CareerVisuals.Gold);`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon([P(-.6f, .85f), P(-.38f, -.12f), P(-.14f, .05f), P(.1f, -1.02f), P(.34f, -.35f), P(.44f, .85f)], new Color("355c56"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon([P(-.6f, .85f), P(-.38f, -.12f), P(-.14f, .05f), P(.1f, -1.02f), P(.34f, -.35f), P(.44f, .85f)], new Color("355c56"));`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(center + new Vector2(-r * 1.35f, 0), center + new Vector2(r * 1.35f, 0), faint, 1, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(center + new Vector2(-r * 1.35f, 0), center + new Vector2(r * 1.35f, 0), faint, 1, true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(center + new Vector2(0, -r * 1.35f), center + new Vector2(0, r * 1.35f), faint, 1, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(center + new Vector2(0, -r * 1.35f), center + new Vector2(0, r * 1.35f), faint, 1, true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(P(-.05f, .16f + i * .17f), P(.23f, .16f + i * .17f), new Color("9ba886"), 2, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(P(-.05f, .16f + i * .17f), P(.23f, .16f + i * .17f), new Color("9ba886"), 2, true);`
- `Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；输入表达式：`DrawPolyline([P(-.6f,.85f), P(-.38f,-.12f), P(-.14f,.05f), P(.1f,-1.02f), P(.34f,-.35f), P(.44f,.85f)], CareerVisuals.Gold, 2, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline([P(-.6f,.85f), P(-.38f,-.12f), P(-.14f,.05f), P(.1f,-1.02f), P(.34f,-.35f), P(.44f,.85f)], CareerVisuals.Gold, 2, true);`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(.44f, .83f, .74f, .14f)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Color(.44f, .83f, .74f, .14f)`
- `Godot.Color.Color(string)`；输入表达式：`new Color("355c56")`；返回值紧邻使用处：`ArgumentSyntax: new Color("355c56")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("587e72")`；返回值紧邻使用处：`ArgumentSyntax: new Color("587e72")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("9ba886")`；返回值紧邻使用处：`ArgumentSyntax: new Color("9ba886")`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-r * 1.35f, 0)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(-r * 1.35f, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, -r * 1.35f)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(0, -r * 1.35f)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, r * 1.35f)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(0, r * 1.35f)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(r * 1.35f, 0)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(r * 1.35f, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(Size.X * .65f, Size.Y * .47f)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Vector2(Size.X * .65f, Size.Y * .47f)`
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

来源：源码第 120 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerArt._Draw()`](CareerVisuals.cs.md#symbol-867304600ece)

**调用：** `Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(x, y)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(x, y) * r`

**赋值（含属性/字段和局部值）：**
