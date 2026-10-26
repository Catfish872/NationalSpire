# PrivateMessageScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`73A4AFB2E504491F255048C992B01E7AAB11E508E64705A8DD2B9928D701C85F`。来源：[源码](../../PrivateMessageScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`、`NationalSpire.PrivateIcon`。

字段、事件及初始值（源码原样）：

```csharp
private Control? _privateOverlay;
private Control? _privateList;
private VBoxContainer? _privateBody;
private Label? _privateTitle, _privateStatus;
private ScrollContainer? _privateScroll;
private TextEdit? _privateInput;
private Button? _privateSend, _privateBadge;
private HBoxContainer? _privateHeading;
private VBoxContainer? _privateAttachments;
private ScrollContainer? _privateAttachmentScroll;
private readonly Dictionary<string, List<PrivateOffer>> _privateAttachmentDrafts = [];
private VBoxContainer? _privateProposal;
private string _privateProposalSignature = "";
private string _privatePerson = "", _privateQuery = "", _privateSignature = "", _privateListSignature = "";
private double _privateClock;
private readonly Dictionary<string, string> _privateDrafts = [];
private readonly HashSet<string> _privateExpandedReasoning = [];
private int _privateScrollRevision;
private ChatComposerLayout? _privateActions;
private Action<bool>? _privateExpressions;
private ChatComposerPanel? _privateComposer;
private Action<string>? _privateStreamText, _privateStreamThought;
private string _privateStreamLastText = "", _privateStreamLastThought = "";
```

<a id="symbol-ed8deb9a37e5"></a>

## `NationalSpire.CareerScreen.PrivateAttachments — private List<PrivateOffer> PrivateAttachments`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._privateAttachmentDrafts`；`NationalSpire.CareerScreen.ChatDraftKey`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_privateAttachmentDrafts.TryGetValue(ChatDraftKey, out var items)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _privateAttachmentDrafts.TryGetValue(ChatDraftKey, out var items) ? items : _privateAttachmentDrafts[ChatDraftKey] = []`

**赋值（含属性/字段和局部值）：**

- `_privateAttachmentDrafts[ChatDraftKey]` = `[]`

<a id="symbol-fb5e88f4639a"></a>

## `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color) — private static Label PrivateText(string value, int size, Color color)`

来源：源码第 30 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPrivateLearning(NationalSpire.PrivateTurn, NationalSpire.PrivateLearning)`](PrivateMemoryScreen.cs.md#symbol-74357ea296a8)；[`NationalSpire.CareerScreen.AddPrivateMood(NationalSpire.PrivateMood)`](PrivateMemoryScreen.cs.md#symbol-1cd11d02c1b9)；[`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-c7881d245b3d)；[`NationalSpire.CareerScreen.AddPrivateProfileChange(NationalSpire.PrivateProfileChange)`](PrivateMemoryScreen.cs.md#symbol-cd1de98ddea7)；[`NationalSpire.CareerScreen.ArbitrationCard(NationalSpire.CareerData, NationalSpire.ArbitrationRecord)`](ArbitrationScreen.cs.md#symbol-8d41f13d5476)；[`NationalSpire.CareerScreen.GiftReceipt(NationalSpire.PrivateOffer)`](ChatAttachmentScreen.cs.md#symbol-bb34e71c1240)；[`NationalSpire.CareerScreen.GroupMemberPicker(NationalSpire.GroupChat?, System.Action<System.Collections.Generic.List<string>>, bool, string, bool, bool)`](GroupChatScreen.cs.md#symbol-26ccde004356)；[`NationalSpire.CareerScreen.GroupMemory()`](GroupChatDialogs.cs.md#symbol-bf729ae9b3eb)；[`NationalSpire.CareerScreen.GroupOffer(NationalSpire.GroupChat, NationalSpire.GroupEffect, NationalSpire.PrivateOffer)`](GroupChatScreen.cs.md#symbol-3afa41099b93)；[`NationalSpire.CareerScreen.GroupTrainingPicker()`](GroupChatDialogs.cs.md#symbol-1e2068d8bf79)；[`NationalSpire.CareerScreen.PreviewPrivateAttachment(NationalSpire.PrivateOffer, bool)`](PrivateMemoryScreen.cs.md#symbol-5c877df45b85)；[`NationalSpire.CareerScreen.PrivateArbitrationDialog()`](ArbitrationScreen.cs.md#symbol-63e3d9aaa6df)；[`NationalSpire.CareerScreen.PrivateAttachmentCard(NationalSpire.PrivateOffer, bool)`](PrivateMemoryScreen.cs.md#symbol-eb2b2a37c5d1)；[`NationalSpire.CareerScreen.PrivateIdentity(NationalSpire.CareerData, string, bool)`](PrivateMemoryScreen.cs.md#symbol-65caddca194f)；[`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-84294149ff91)；[`NationalSpire.CareerScreen.PrivateLineupCard(NationalSpire.CareerData, NationalSpire.CoachLineupRequest, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?)`](CoachScreen.cs.md#symbol-c01675f974f7)；[`NationalSpire.CareerScreen.PrivateLineupPicker()`](CoachScreen.cs.md#symbol-78315f2693ca)；[`NationalSpire.CareerScreen.PrivateMemory()`](PrivateMemoryScreen.cs.md#symbol-942a4a496637)；[`NationalSpire.CareerScreen.PrivateTrainingCard(NationalSpire.CareerData, NationalSpire.CoachTrainingPlan, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?)`](CoachScreen.cs.md#symbol-c2e37e4a0f14)；[`NationalSpire.CareerScreen.RefreshGroupChat()`](GroupChatScreen.cs.md#symbol-b56fe79b2db7)；[`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)；[`Section(string)`](PrivateMemoryScreen.cs.md#symbol-3776534c6c5a)

**调用：** [`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(value, size, color)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text(value, size, color)`

**赋值（含属性/字段和局部值）：**

- `label.Text` = `value`

<a id="symbol-3ff4e47d4271"></a>

## `NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int) — private void OpenPrivateMessages(string person = "", string group = "", int page = -1)`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Accepted()`](ConsumerCommerceScreen.cs.md#symbol-bf6f71fa2076)；[`NationalSpire.CareerScreen.AddPausedDateScenes(NationalSpire.CareerData, NationalSpire.PrivateConversation)`](DateSceneScreen.cs.md#symbol-a5b10d9fb0b8)；[`NationalSpire.CareerScreen.ArbitrationCard(NationalSpire.CareerData, NationalSpire.ArbitrationRecord)`](ArbitrationScreen.cs.md#symbol-8d41f13d5476)；[`NationalSpire.CareerScreen.Back()`](CareerNavigation.cs.md#symbol-08af62207fef)；[`NationalSpire.CareerScreen.Build()`](CareerScreen.cs.md#symbol-8b4784fe3138)；[`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.DatePhone()`](DateGameScreen.cs.md#symbol-91a1fe98cb30)；[`NationalSpire.CareerScreen.GroupOffer(NationalSpire.GroupChat, NationalSpire.GroupEffect, NationalSpire.PrivateOffer)`](GroupChatScreen.cs.md#symbol-3afa41099b93)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.OpenRunDate(MegaCrit.Sts2.Core.Nodes.NRun, NationalSpire.CareerMatch, System.Action, bool)`](DateGameScreen.cs.md#symbol-c74330b4dd26)；[`NationalSpire.CareerScreen.PrivateProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](PrivateMessageScreen.cs.md#symbol-8e28d3a34860)；[`NationalSpire.CareerScreen.ReportDiscussion(string, string)`](ArbitrationScreen.cs.md#symbol-4223b2b95c14)；[`NationalSpire.CareerScreen.ReturnFromDatePhone()`](DateGameScreen.cs.md#symbol-006d35effe08)；[`NationalSpire.CareerScreen.ReturnToDate(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu)`](DateGameReturn.cs.md#symbol-f14ac682e7c3)；[`NationalSpire.CareerScreen.SelectGroup(string, int)`](GroupChatScreen.cs.md#symbol-72d02215d0db)；[`NationalSpire.CareerScreen.ShareDiscussion(string, string)`](CommunityShareScreen.cs.md#symbol-038b648fdc83)

**调用：** `Godot.Color.Color(string)`；`Godot.ColorRect.ColorRect()`；`Godot.ConfigFile.GetValue(string, string, Godot.Variant)`；`Godot.Control.AcceptEvent()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.Control()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.MarginContainer.MarginContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.ScrollContainer.GetVScrollBar()`；`Godot.ScrollContainer.ScrollContainer()`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`；`Godot.TextEdit.TextEdit()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Variant.AsString()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.BroadcastScroll.BroadcastScroll()`；[`NationalSpire.CareerScreen.BuildContactSearch(Godot.VBoxContainer)`](ChatContactScreen.cs.md#symbol-3c7d41806831)；[`NationalSpire.CareerScreen.BuildPrivateComposerActions(Godot.VBoxContainer)`](PrivateMessageScreen.cs.md#symbol-a7be0d6513a6)；[`NationalSpire.CareerScreen.GroupSidebar(Godot.VBoxContainer)`](GroupChatScreen.cs.md#symbol-88d7619ce50a)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.LoadChatPreferences()`](ChatHistoryScreen.cs.md#symbol-d1d5bc5023c7)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.PrivateEmpty(string, string)`](PrivateMemoryScreen.cs.md#symbol-e829c0d03f86)；[`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-84294149ff91)；[`NationalSpire.CareerScreen.RefreshPrivateList()`](PrivateMessageScreen.cs.md#symbol-fca825e025fa)；[`NationalSpire.CareerScreen.SelectGroup(string, int)`](GroupChatScreen.cs.md#symbol-72d02215d0db)；[`NationalSpire.CareerScreen.SelectPrivate(string, int)`](PrivateMessageScreen.cs.md#symbol-be8cf79217b4)；[`NationalSpire.CareerScreen.SendPrivate()`](PrivateMessageScreen.cs.md#symbol-748ab66a7351)；[`NationalSpire.CareerScreen.ShowPrivateListRows()`](PrivateListRows.cs.md#symbol-a42f68b15faf)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.ChatComposerPanel.Bind(Godot.Control, Godot.VBoxContainer, Godot.TextEdit, Godot.ScrollContainer, Godot.Control)`](ChatComposerLayout.cs.md#symbol-65c9c36a106d)；`NationalSpire.ChatComposerPanel.ChatComposerPanel()`；[`NationalSpire.GroupChats.Visible(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-81f7f177c347)；`NationalSpire.PrivateIcon.PrivateIcon()`；[`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-25194feb6779)；[`NationalSpire.PrivateMessages.ListedInCommunications(NationalSpire.PrivateConversation)`](PrivateMessages.cs.md#symbol-eb7a8aaa6a38)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Clear()`；`System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`string.StartsWith(string, System.StringComparison)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Failure`；`NationalSpire.CareerScreen.BuildContactSearch(Godot.VBoxContainer)`；`NationalSpire.CareerScreen.BuildPrivateComposerActions(Godot.VBoxContainer)`；`NationalSpire.CareerScreen.ChatPreferenceKey`；`NationalSpire.CareerScreen.ChatPreferences`；`NationalSpire.CareerScreen.ChatSettingsMenu()`；`NationalSpire.CareerScreen.ClosePrivateMessages()`；`NationalSpire.CareerScreen.GroupSidebar(Godot.VBoxContainer)`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.LoadChatPreferences()`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.PrivateEmpty(string, string)`；`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；`NationalSpire.CareerScreen.RefreshPrivateList()`；`NationalSpire.CareerScreen.ReturnFromDatePhone()`；`NationalSpire.CareerScreen.SelectGroup(string, int)`；`NationalSpire.CareerScreen.SelectPrivate(string, int)`；`NationalSpire.CareerScreen.SendPrivate()`；`NationalSpire.CareerScreen.ShowPrivateListRows()`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._datePhoneOffer`；`NationalSpire.CareerScreen._datePhoneReturn`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._privateAttachmentScroll`；`NationalSpire.CareerScreen._privateAttachments`；`NationalSpire.CareerScreen._privateBody`；`NationalSpire.CareerScreen._privateComposer`；`NationalSpire.CareerScreen._privateEntries`；`NationalSpire.CareerScreen._privateHeading`；`NationalSpire.CareerScreen._privateInput`；`NationalSpire.CareerScreen._privateList`；`NationalSpire.CareerScreen._privateListEmpty`；`NationalSpire.CareerScreen._privateListScroll`；`NationalSpire.CareerScreen._privateListSignature`；`NationalSpire.CareerScreen._privateOverlay`；`NationalSpire.CareerScreen._privateProposal`；`NationalSpire.CareerScreen._privateProposalSignature`；`NationalSpire.CareerScreen._privateRows`；`NationalSpire.CareerScreen._privateScroll`；`NationalSpire.CareerScreen._privateSend`；`NationalSpire.CareerScreen._privateSignature`；`NationalSpire.CareerScreen._privateStatus`；`NationalSpire.CareerScreen._privateTitle`；`NationalSpire.CareerScreen._stage`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.ChatComposerPanel.Bind(Godot.Control, Godot.VBoxContainer, Godot.TextEdit, Godot.ScrollContainer, Godot.Control)`；`NationalSpire.GroupChat.Id`；`NationalSpire.GroupChats.Visible(NationalSpire.CareerData)`；`NationalSpire.PrivateConversation.LastReplyOrder`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateIcon.Gear`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMailbox.LastPerson`；`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；`NationalSpire.PrivateMessages.ListedInCommunications(NationalSpire.PrivateConversation)`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateTurn.Day`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.PhoneOpen`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("0a121d")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Color = new Color("0a121d")`
- `Godot.ColorRect.ColorRect()`；输入表达式：`new ColorRect { Name = "PrivateMessages", Color = new Color("0a121d"), MouseFilter = MouseFilterEnum.Stop, ZIndex = 22 }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ColorRect { Name = "PrivateMessages", Color = new Color("0a121d"), MouseFilter = MouseFilterEnum.Stop, ZIndex = 22 }`
- `Godot.ConfigFile.GetValue(string, string, Godot.Variant)`；输入表达式：`ChatPreferences.GetValue(ChatPreferenceKey, "last", "")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ChatPreferences.GetValue(ChatPreferenceKey, "last", "").AsString`
- `Godot.Control.AcceptEvent()`；输入表达式：`_privateInput.AcceptEvent()`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateInput.AcceptEvent();`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_privateAttachments.AddThemeConstantOverride("separation", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateAttachments.AddThemeConstantOverride("separation", 8);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_privateBody.AddThemeConstantOverride("separation", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateBody.AddThemeConstantOverride("separation", 18);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_privateHeading.AddThemeConstantOverride("separation", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateHeading.AddThemeConstantOverride("separation", 18);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_privateProposal.AddThemeConstantOverride("separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateProposal.AddThemeConstantOverride("separation", 10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`brand.AddThemeConstantOverride("separation", 3)`；返回值紧邻使用处：`ExpressionStatementSyntax: brand.AddThemeConstantOverride("separation", 3);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`chat.AddThemeConstantOverride("separation", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: chat.AddThemeConstantOverride("separation", 14);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`columns.AddThemeConstantOverride("separation", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: columns.AddThemeConstantOverride("separation", 14);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`composerBody.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: composerBody.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`header.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddThemeConstantOverride("separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`layout.AddThemeConstantOverride("separation", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: layout.AddThemeConstantOverride("separation", 18);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`margin.AddThemeConstantOverride("margin_" + edge, 30)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddThemeConstantOverride("margin_" + edge, 30);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`sidebar.AddThemeConstantOverride("separation", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: sidebar.AddThemeConstantOverride("separation", 18);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`_privateInput.AddThemeFontSizeOverride("font_size", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateInput.AddThemeFontSizeOverride("font_size", 18);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`_privateInput.AddThemeStyleboxOverride("focus", new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateInput.AddThemeStyleboxOverride("focus", new StyleBoxEmpty());`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`_privateInput.AddThemeStyleboxOverride("normal", new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateInput.AddThemeStyleboxOverride("normal", new StyleBoxEmpty());`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`composer.AddThemeStyleboxOverride("panel", CareerVisuals.Box("0d1926", "688498", 10, 14))`；返回值紧邻使用处：`ExpressionStatementSyntax: composer.AddThemeStyleboxOverride("panel", CareerVisuals.Box("0d1926", "688498", 10, 14));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`left.AddThemeStyleboxOverride("panel", CareerVisuals.Box("101b29", "3c5265", 12, 16))`；返回值紧邻使用处：`ExpressionStatementSyntax: left.AddThemeStyleboxOverride("panel", CareerVisuals.Box("101b29", "3c5265", 12, 16));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`main.AddThemeStyleboxOverride("panel", CareerVisuals.Box("182838", "405b70", 12, 24))`；返回值紧邻使用处：`ExpressionStatementSyntax: main.AddThemeStyleboxOverride("panel", CareerVisuals.Box("182838", "405b70", 12, 24));`
- `Godot.Control.Control()`；输入表达式：`new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`ArgumentSyntax: new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Control.Control()`；输入表达式：`new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _privateList = new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`_privateListEmpty.SetAnchorsAndOffsetsPreset(LayoutPreset.TopWide)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateListEmpty.SetAnchorsAndOffsetsPreset(LayoutPreset.TopWide);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { SizeFlagsVertical = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { SizeFlagsVertical = SizeFlags.ExpandFill }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _privateHeading = new HBoxContainer()`
- `Godot.MarginContainer.MarginContainer()`；输入表达式：`new MarginContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MarginContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateAttachmentScroll.AddChild(_privateAttachments)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateAttachmentScroll.AddChild(_privateAttachments);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateHeading.AddChild(_privateTitle)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateHeading.AddChild(_privateTitle);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateList.AddChild(_privateListEmpty)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateList.AddChild(_privateListEmpty);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateScroll.AddChild(_privateBody)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateScroll.AddChild(_privateBody);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_stage.AddChild(shade)`；返回值紧邻使用处：`ExpressionStatementSyntax: _stage.AddChild(shade);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`brand.AddChild(PrivateLine("国运尖塔 · 选手通讯", 14, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: brand.AddChild(PrivateLine("国运尖塔 · 选手通讯", 14, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`brand.AddChild(PrivateLine("通讯", 30, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: brand.AddChild(PrivateLine("通讯", 30, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`chat.AddChild(_privateHeading)`；返回值紧邻使用处：`ExpressionStatementSyntax: chat.AddChild(_privateHeading);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`chat.AddChild(_privateScroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: chat.AddChild(_privateScroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`chat.AddChild(_privateStatus)`；返回值紧邻使用处：`ExpressionStatementSyntax: chat.AddChild(_privateStatus);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`chat.AddChild(composer)`；返回值紧邻使用处：`ExpressionStatementSyntax: chat.AddChild(composer);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`columns.AddChild(left)`；返回值紧邻使用处：`ExpressionStatementSyntax: columns.AddChild(left);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`columns.AddChild(main)`；返回值紧邻使用处：`ExpressionStatementSyntax: columns.AddChild(main);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`composer.AddChild(composerBody)`；返回值紧邻使用处：`ExpressionStatementSyntax: composer.AddChild(composerBody);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`composerBody.AddChild(_privateAttachmentScroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: composerBody.AddChild(_privateAttachmentScroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`composerBody.AddChild(_privateInput)`；返回值紧邻使用处：`ExpressionStatementSyntax: composerBody.AddChild(_privateInput);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(PrivateButton("关闭", ClosePrivateMessages, 100))`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(PrivateButton("关闭", ClosePrivateMessages, 100));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(_datePhoneReturn)`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(_datePhoneReturn);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(brand)`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(brand);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill })`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(settings)`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(settings);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`layout.AddChild(_privateProposal)`；返回值紧邻使用处：`ExpressionStatementSyntax: layout.AddChild(_privateProposal);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`layout.AddChild(columns)`；返回值紧邻使用处：`ExpressionStatementSyntax: layout.AddChild(columns);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`layout.AddChild(header)`；返回值紧邻使用处：`ExpressionStatementSyntax: layout.AddChild(header);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`listScroll.AddChild(_privateList)`；返回值紧邻使用处：`ExpressionStatementSyntax: listScroll.AddChild(_privateList);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`margin.AddChild(layout)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddChild(layout);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`settings.AddChild(new PrivateIcon { Gear = true, MouseFilter = MouseFilterEnum.Ignore })`；返回值紧邻使用处：`ExpressionStatementSyntax: settings.AddChild(new PrivateIcon { Gear = true, MouseFilter = MouseFilterEnum.Ignore });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`shade.AddChild(margin)`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.AddChild(margin);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`sidebar.AddChild(listScroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: sidebar.AddChild(listScroll);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer()`
- `Godot.ScrollContainer.GetVScrollBar()`；输入表达式：`listScroll.GetVScrollBar()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: listScroll.GetVScrollBar().ValueChanged`
- `Godot.ScrollContainer.ScrollContainer()`；输入表达式：`new ScrollContainer { HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled, Visible = false }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _privateAttachmentScroll = new ScrollContainer { HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled, Visible = false }`
- `Godot.ScrollContainer.ScrollContainer()`；输入表达式：`new ScrollContainer { SizeFlagsVertical = SizeFlags.ExpandFill, HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ScrollContainer { SizeFlagsVertical = SizeFlags.ExpandFill, HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty()`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxEmpty()`
- `Godot.TextEdit.TextEdit()`；输入表达式：`new TextEdit { Name = "PrivateMessageInput", PlaceholderText = "发送消息…", CustomMinimumSize = new(0, 68), WrapMode = TextEdit.LineWrappingMode.Boundary, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _privateInput = new TextEdit { Name = "PrivateMessageInput", PlaceholderText = "发送消息…", CustomMinimumSize = new(0, 68), WrapMode = TextEdit.LineWrappingMode.Boundary, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _privateAttachments = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsVertical = SizeFlags.ExpandFill }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _privateBody = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsVertical = SizeFlags.ExpandFill }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _privateProposal = new VBoxContainer()`
- `Godot.Variant.AsString()`；输入表达式：`ChatPreferences.GetValue(ChatPreferenceKey, "last", "").AsString()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ChatPreferences.GetValue(ChatPreferenceKey, "last", "").AsString()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 68)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 68)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(260, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _privateListEmpty.CustomMinimumSize = new(260, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(290, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: left.CustomMinimumSize = new(290, 0)`
- `NationalSpire.BroadcastScroll.BroadcastScroll()`；输入表达式：`new BroadcastScroll { SizeFlagsVertical = SizeFlags.ExpandFill, HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _privateScroll = new BroadcastScroll { SizeFlagsVertical = SizeFlags.ExpandFill, HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `NationalSpire.CareerScreen.BuildContactSearch(Godot.VBoxContainer)`；输入表达式：`BuildContactSearch(sidebar)`；返回值紧邻使用处：`ExpressionStatementSyntax: BuildContactSearch(sidebar);`
- `NationalSpire.CareerScreen.BuildPrivateComposerActions(Godot.VBoxContainer)`；输入表达式：`BuildPrivateComposerActions(composerBody)`；返回值紧邻使用处：`ExpressionStatementSyntax: BuildPrivateComposerActions(composerBody);`
- `NationalSpire.CareerScreen.GroupSidebar(Godot.VBoxContainer)`；输入表达式：`GroupSidebar(sidebar)`；返回值紧邻使用处：`ExpressionStatementSyntax: GroupSidebar(sidebar);`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(left)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(left)`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(main)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(main)`
- `NationalSpire.CareerScreen.LoadChatPreferences()`；输入表达式：`LoadChatPreferences()`；返回值紧邻使用处：`ExpressionStatementSyntax: LoadChatPreferences();`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("", ChatSettingsMenu, 52)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton("", ChatSettingsMenu, 52)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("关闭", ClosePrivateMessages, 100)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("关闭", ClosePrivateMessages, 100)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("返回约会", ReturnFromDatePhone, 150)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _datePhoneReturn = PrivateButton("返回约会", ReturnFromDatePhone, 150)`
- `NationalSpire.CareerScreen.PrivateEmpty(string, string)`；输入表达式：`PrivateEmpty("选择一位选手", "搜索姓名，或从选手档案发起私信。")`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateEmpty("选择一位选手", "搜索姓名，或从选手档案发起私信。");`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine("国运尖塔 · 选手通讯", 14, _muted)`；返回值紧邻使用处：`ArgumentSyntax: PrivateLine("国运尖塔 · 选手通讯", 14, _muted)`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine("通讯", 30, _gold)`；返回值紧邻使用处：`ArgumentSyntax: PrivateLine("通讯", 30, _gold)`
- `NationalSpire.CareerScreen.RefreshPrivateList()`；输入表达式：`RefreshPrivateList()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshPrivateList();`
- `NationalSpire.CareerScreen.SelectGroup(string, int)`；输入表达式：`SelectGroup(group, page)`；返回值紧邻使用处：`ExpressionStatementSyntax: SelectGroup(group, page);`
- `NationalSpire.CareerScreen.SelectPrivate(string, int)`；输入表达式：`SelectPrivate(person, page)`；返回值紧邻使用处：`ExpressionStatementSyntax: SelectPrivate(person, page);`
- `NationalSpire.CareerScreen.SendPrivate()`；输入表达式：`SendPrivate()`；返回值紧邻使用处：`ExpressionStatementSyntax: SendPrivate();`
- `NationalSpire.CareerScreen.ShowPrivateListRows()`；输入表达式：`ShowPrivateListRows()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _ => ShowPrivateListRows()`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 14, _muted)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _privateStatus = Text("", 14, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("搜索选手，或从档案发起私信。", 16, _muted)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _privateListEmpty = Text("搜索选手，或从档案发起私信。", 16, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("选择一位选手", 25, _ink)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _privateTitle = Text("选择一位选手", 25, _ink)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("0d1926", "688498", 10, 14)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("0d1926", "688498", 10, 14)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("101b29", "3c5265", 12, 16)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("101b29", "3c5265", 12, 16)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("182838", "405b70", 12, 24)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("182838", "405b70", 12, 24)`
- `NationalSpire.ChatComposerPanel.Bind(Godot.Control, Godot.VBoxContainer, Godot.TextEdit, Godot.ScrollContainer, Godot.Control)`；输入表达式：`composer.Bind(main, composerBody, _privateInput, _privateAttachmentScroll, _privateHeading)`；返回值紧邻使用处：`ExpressionStatementSyntax: composer.Bind(main, composerBody, _privateInput, _privateAttachmentScroll, _privateHeading);`
- `NationalSpire.ChatComposerPanel.ChatComposerPanel()`；输入表达式：`new ChatComposerPanel { Name = "PrivateComposer" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ChatComposerPanel { Name = "PrivateComposer" }`
- `NationalSpire.GroupChats.Visible(NationalSpire.CareerData)`；输入表达式：`GroupChats.Visible(ViewData)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GroupChats.Visible(ViewData).Any`
- `NationalSpire.PrivateIcon.PrivateIcon()`；输入表达式：`new PrivateIcon { Gear = true, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`ArgumentSyntax: new PrivateIcon { Gear = true, MouseFilter = MouseFilterEnum.Ignore }`
- `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.CanChat(ViewData, person)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PrivateMessages.CanChat(ViewData, person)`
- `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.CanChat(ViewData, person)`；返回值紧邻使用处：`BinaryExpressionSyntax: group.Length == 0 && person.Length > 0 && PrivateMessages.CanChat(ViewData, person)`
- `NationalSpire.PrivateMessages.ListedInCommunications(NationalSpire.PrivateConversation)`；输入表达式：`PrivateMessages.ListedInCommunications(lastConversation)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PrivateMessages.ListedInCommunications(lastConversation)`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(ViewData)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(ViewData).LastPerson`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(ViewData)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(ViewData).Conversations`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.PhoneOpen, "通讯")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.PhoneOpen, "通讯")`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`PrivateMessages.Mailbox(ViewData).Conversations.TryGetValue(person, out var lastConversation)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PrivateMessages.Mailbox(ViewData).Conversations.TryGetValue(person, out var lastConversation)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`GroupChats.Visible(ViewData).Any(g => g.Id == group)`；返回值紧邻使用处：`BinaryExpressionSyntax: group.Length > 0 && GroupChats.Visible(ViewData).Any(g => g.Id == group)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`PrivateMessages.Mailbox(ViewData).Conversations.Values.Where(PrivateMessages.ListedInCommunications).OrderByDescending(c => c.LastReplyOrder).ThenByDescending(c => c.Turns.LastOrDefault()?.Day ?? 0).FirstOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: PrivateMessages.Mailbox(ViewData).Conversations.Values.Where(PrivateMessages.ListedInCommunications).OrderByDescending(c => c.LastReplyOrder).ThenByDescending(c => c.Turns.LastOrDefault()?.Day ?? 0).FirstOrDefault()?.PersonId`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`c.Turns.LastOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: c.Turns.LastOrDefault()?.Day`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`PrivateMessages.Mailbox(ViewData).Conversations.Values.Where(PrivateMessages.ListedInCommunications).OrderByDescending(c => c.LastReplyOrder)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(ViewData).Conversations.Values.Where(PrivateMessages.ListedInCommunications).OrderByDescending(c => c.LastReplyOrder).ThenByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateMessages.Mailbox(ViewData).Conversations.Values.Where(PrivateMessages.ListedInCommunications)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(ViewData).Conversations.Values.Where(PrivateMessages.ListedInCommunications).OrderByDescending`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`_privateEntries.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateEntries.Clear();`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`_privateRows.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateRows.Clear();`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`PrivateMessages.Mailbox(ViewData).Conversations.Values.Where(PrivateMessages.ListedInCommunications).OrderByDescending(c => c.LastReplyOrder).ThenByDescending(c => c.Turns.LastOrDefault()?.Day ?? 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(ViewData).Conversations.Values.Where(PrivateMessages.ListedInCommunications).OrderByDescending(c => c.LastReplyOrder).ThenByDescending(c => c.Turns.LastOrDefault()?.Day ?? 0).FirstOrDefault`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`last.StartsWith("group:", StringComparison.Ordinal)`；返回值紧邻使用处：`IfStatementSyntax: if (last.StartsWith("group:", StringComparison.Ordinal)) group = last[6..]; else if (last.Length > 0) person = last; else { person = PrivateMessages.Mailbox(ViewData).LastPerson; if (!PrivateMessages.CanChat(ViewData, person) || !PrivateMessages.Mailbox(ViewData).Conversations.TryGetValue(person, out var lastConversation) || !PrivateMessages.ListedInCommunications(lastConversation)) person = PrivateMessages.Mailbox(ViewData).Conversations.Values.Where(PrivateMessages.ListedInCommunications).OrderByDescending(c => c.LastReplyOrder).ThenByDescending(c => c.Turns.LastOrDefault()?.Day ?? 0).FirstOrDefault()?.PersonId ?? ""; }`

**赋值（含属性/字段和局部值）：**

- `Color` = `new Color("0a121d")`
- `CustomMinimumSize` = `new(0, 68)`
- `Gear` = `true`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `MouseFilter` = `MouseFilterEnum.Stop`
- `Name` = `"PrivateComposer"`
- `Name` = `"PrivateMessageInput"`
- `Name` = `"PrivateMessages"`
- `PlaceholderText` = `"发送消息…"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ExpandFill`
- `Visible` = `false`
- `WrapMode` = `TextEdit.LineWrappingMode.Boundary`
- `ZIndex` = `22`
- `_datePhoneReturn.Name` = `"DatePhoneReturn"`
- `_datePhoneReturn.Visible` = `_datePhoneOffer.Length > 0`
- `_datePhoneReturn` = `PrivateButton("返回约会", ReturnFromDatePhone, 150)`
- `_privateAttachmentScroll` = `new ScrollContainer { HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled, Visible = false }`
- `_privateAttachments` = `new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `_privateBody` = `new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsVertical = SizeFlags.ExpandFill }`
- `_privateComposer` = `composer`
- `_privateHeading` = `new HBoxContainer()`
- `_privateInput.GuiInput` += `input => { if (input is InputEventKey { Pressed: true, Echo: false, CtrlPressed: true, Keycode: Key.Enter }) { _privateInput.AcceptEvent(); SendPrivate(); } }`
- `_privateInput` = `new TextEdit { Name = "PrivateMessageInput", PlaceholderText = "发送消息…", CustomMinimumSize = new(0, 68), WrapMode = TextEdit.LineWrappingMode.Boundary, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `_privateList.Resized` += `ShowPrivateListRows`
- `_privateListEmpty.CustomMinimumSize` = `new(260, 0)`
- `_privateListEmpty` = `Text("搜索选手，或从档案发起私信。", 16, _muted)`
- `_privateListScroll` = `listScroll`
- `_privateListSignature` = `""`
- `_privateList` = `new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `_privateOverlay` = `shade`
- `_privateProposalSignature` = `""`
- `_privateProposal` = `new VBoxContainer()`
- `_privateScroll` = `new BroadcastScroll { SizeFlagsVertical = SizeFlags.ExpandFill, HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `_privateSend!.Disabled` = `true`
- `_privateSignature` = `_privateListSignature = ""`
- `_privateStatus` = `Text("", 14, _muted)`
- `_privateTitle` = `Text("选择一位选手", 25, _ink)`
- `group` = `last[6..]`
- `left.CustomMinimumSize` = `new(290, 0)`
- `left.SizeFlagsHorizontal` = `SizeFlags.Fill`
- `listScroll.GetVScrollBar().ValueChanged` += `_ => ShowPrivateListRows()`
- `listScroll.Resized` += `ShowPrivateListRows`
- `person` = `PrivateMessages.Mailbox(ViewData).Conversations.Values.Where(PrivateMessages.ListedInCommunications).OrderByDescending(c => c.LastReplyOrder).ThenByDescending(c => c.Turns.LastOrDefault()?.Day ?? 0).FirstOrDefault()?.PersonId ?? ""`
- `person` = `PrivateMessages.Mailbox(ViewData).LastPerson`
- `person` = `last`
- `settings.Name` = `"ChatSettingsButton"`
- `settings.TooltipText` = `"通讯设置"`

<a id="symbol-a7be0d6513a6"></a>

## `NationalSpire.CareerScreen.BuildPrivateComposerActions(Godot.VBoxContainer) — private void BuildPrivateComposerActions(VBoxContainer composerBody)`

来源：源码第 106 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)

**调用：** `Godot.BaseButton.SetPressedNoSignal(bool)`；`Godot.CanvasItem.QueueRedraw()`；`Godot.Color.Color(string)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.GetCombinedMinimumSize()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.MarginContainer.MarginContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；[`NationalSpire.CareerScreen.BuildChatModelButton(Godot.HBoxContainer)`](ChatUtilitiesScreen.cs.md#symbol-f49b1a0725a3)；[`NationalSpire.CareerScreen.BuildChatPagination(NationalSpire.ChatComposerLayout)`](ChatHistoryScreen.cs.md#symbol-5fc0f2f77de5)；[`NationalSpire.CareerScreen.BuildChatToolToggle(Godot.HBoxContainer)`](ChatToolToggle.cs.md#symbol-cdbc2a8ad7ca)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-84294149ff91)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`NationalSpire.ChatComposerExpandIcon.ChatComposerExpandIcon()`；`NationalSpire.ChatComposerLayout.ChatComposerLayout()`；[`NationalSpire.ChatComposerLayout.CompactButtons(Godot.Control)`](ChatComposerLayout.cs.md#symbol-50b5fb8cff87)；[`NationalSpire.ChatComposerPanel.Toggle()`](ChatComposerLayout.cs.md#symbol-19c3c4544409)；[`NationalSpire.CommunityReplyExpressions.Attach(Godot.TextEdit, Godot.VBoxContainer, Godot.HBoxContainer, Godot.Control?)`](CommunityReplyExpressions.cs.md#symbol-c53b052266e4)；`System.Action<T>.Invoke(T)`；`System.MathF.Round(float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.BuildChatModelButton(Godot.HBoxContainer)`；`NationalSpire.CareerScreen.BuildChatPagination(NationalSpire.ChatComposerLayout)`；`NationalSpire.CareerScreen.BuildChatToolToggle(Godot.HBoxContainer)`；`NationalSpire.CareerScreen.PrivateActions()`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；`NationalSpire.CareerScreen.SendPrivate()`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._privateActions`；`NationalSpire.CareerScreen._privateComposer`；`NationalSpire.CareerScreen._privateExpressions`；`NationalSpire.CareerScreen._privateInput`；`NationalSpire.CareerScreen._privateSend`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.ChatComposerExpandIcon.Expanded`；`NationalSpire.ChatComposerLayout.ButtonScale`；`NationalSpire.ChatComposerLayout.CompactButtons(Godot.Control)`；`NationalSpire.ChatComposerLayout.SendWidthIncrease`；`NationalSpire.ChatComposerPanel.ExpansionChanged`；`NationalSpire.ChatComposerPanel.Toggle()`；`NationalSpire.CommunityReplyExpressions.Attach(Godot.TextEdit, Godot.VBoxContainer, Godot.HBoxContainer, Godot.Control?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`expand.SetPressedNoSignal(value)`；返回值紧邻使用处：`ExpressionStatementSyntax: expand.SetPressedNoSignal(value);`
- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`expandIcon.QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: expandIcon.QueueRedraw();`
- `Godot.Color.Color(string)`；输入表达式：`new Color("172330")`；返回值紧邻使用处：`ArgumentSyntax: new Color("172330")`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_privateSend.AddThemeColorOverride("font_color", new Color("172330"))`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateSend.AddThemeColorOverride("font_color", new Color("172330"));`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`left.AddThemeConstantOverride("separation", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: left.AddThemeConstantOverride("separation", 14);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`sendActions.AddThemeConstantOverride("separation", 7)`；返回值紧邻使用处：`ExpressionStatementSyntax: sendActions.AddThemeConstantOverride("separation", 7);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`shortcutMargin.AddThemeConstantOverride("margin_right", (int)MathF.Round(_privateSend.GetCombinedMinimumSize().X * (1 - ChatComposerLayout.ButtonScale) / 2))`；返回值紧邻使用处：`ExpressionStatementSyntax: shortcutMargin.AddThemeConstantOverride("margin_right", (int)MathF.Round(_privateSend.GetCombinedMinimumSize().X * (1 - ChatComposerLayout.ButtonScale) / 2));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`_privateSend.AddThemeStyleboxOverride("normal", CareerVisuals.Box("d9bd7e", "f0dca7", 8, 12))`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateSend.AddThemeStyleboxOverride("normal", CareerVisuals.Box("d9bd7e", "f0dca7", 8, 12));`
- `Godot.Control.GetCombinedMinimumSize()`；输入表达式：`_privateSend.GetCombinedMinimumSize()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _privateSend.GetCombinedMinimumSize().X`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { Name = "PrivateComposerSendActions" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { Name = "PrivateComposerSendActions" }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { Name = "PrivateComposerTools" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { Name = "PrivateComposerTools" }`
- `Godot.MarginContainer.MarginContainer()`；输入表达式：`new MarginContainer { SizeFlagsVertical = SizeFlags.ShrinkCenter }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MarginContainer { SizeFlagsVertical = SizeFlags.ShrinkCenter }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(left)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(left);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(sendActions)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(sendActions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`composerBody.AddChild(actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: composerBody.AddChild(actions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`expand.AddChild(expandIcon)`；返回值紧邻使用处：`ExpressionStatementSyntax: expand.AddChild(expandIcon);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`left.AddChild(more)`；返回值紧邻使用处：`ExpressionStatementSyntax: left.AddChild(more);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`sendActions.AddChild(_privateSend)`；返回值紧邻使用处：`ExpressionStatementSyntax: sendActions.AddChild(_privateSend);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`sendActions.AddChild(expand)`；返回值紧邻使用处：`ExpressionStatementSyntax: sendActions.AddChild(expand);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`sendActions.AddChild(shortcutMargin)`；返回值紧邻使用处：`ExpressionStatementSyntax: sendActions.AddChild(shortcutMargin);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`shortcutMargin.AddChild(shortcut)`；返回值紧邻使用处：`ExpressionStatementSyntax: shortcutMargin.AddChild(shortcut);`
- `NationalSpire.CareerScreen.BuildChatModelButton(Godot.HBoxContainer)`；输入表达式：`BuildChatModelButton(left)`；返回值紧邻使用处：`ExpressionStatementSyntax: BuildChatModelButton(left);`
- `NationalSpire.CareerScreen.BuildChatPagination(NationalSpire.ChatComposerLayout)`；输入表达式：`BuildChatPagination(actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: BuildChatPagination(actions);`
- `NationalSpire.CareerScreen.BuildChatToolToggle(Godot.HBoxContainer)`；输入表达式：`BuildChatToolToggle(sendActions)`；返回值紧邻使用处：`ExpressionStatementSyntax: BuildChatToolToggle(sendActions);`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("", () => _privateComposer!.Toggle(), 48)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton("", () => _privateComposer!.Toggle(), 48)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("发送", SendPrivate, 80 + ChatComposerLayout.SendWidthIncrease)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _privateSend = PrivateButton("发送", SendPrivate, 80 + ChatComposerLayout.SendWidthIncrease)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("＋", PrivateActions, 54)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton("＋", PrivateActions, 54)`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine("Ctrl + Enter 发送", 12, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateLine("Ctrl + Enter 发送", 12, _muted)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("d9bd7e", "f0dca7", 8, 12)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("d9bd7e", "f0dca7", 8, 12)`
- `NationalSpire.ChatComposerExpandIcon.ChatComposerExpandIcon()`；输入表达式：`new ChatComposerExpandIcon { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ChatComposerExpandIcon { MouseFilter = MouseFilterEnum.Ignore }`
- `NationalSpire.ChatComposerLayout.ChatComposerLayout()`；输入表达式：`new ChatComposerLayout { Name = "PrivateComposerActions", SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ChatComposerLayout { Name = "PrivateComposerActions", SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `NationalSpire.ChatComposerLayout.CompactButtons(Godot.Control)`；输入表达式：`ChatComposerLayout.CompactButtons(actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: ChatComposerLayout.CompactButtons(actions);`
- `NationalSpire.ChatComposerPanel.Toggle()`；输入表达式：`_privateComposer!.Toggle()`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => _privateComposer!.Toggle()`
- `NationalSpire.CommunityReplyExpressions.Attach(Godot.TextEdit, Godot.VBoxContainer, Godot.HBoxContainer, Godot.Control?)`；输入表达式：`CommunityReplyExpressions.Attach(_privateInput!, composerBody, left, actions)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _privateExpressions = CommunityReplyExpressions.Attach(_privateInput!, composerBody, left, actions)`
- `System.Action<T>.Invoke(T)`；输入表达式：`_privateExpressions(false)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateExpressions(false);`
- `System.MathF.Round(float)`；输入表达式：`MathF.Round(_privateSend.GetCombinedMinimumSize().X * (1 - ChatComposerLayout.ButtonScale) / 2)`；返回值紧邻使用处：`CastExpressionSyntax: (int)MathF.Round(_privateSend.GetCombinedMinimumSize().X * (1 - ChatComposerLayout.ButtonScale) / 2)`

**赋值（含属性/字段和局部值）：**

- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Name` = `"PrivateComposerActions"`
- `Name` = `"PrivateComposerSendActions"`
- `Name` = `"PrivateComposerTools"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `_privateActions` = `actions`
- `_privateComposer!.ExpansionChanged` += `value => { expand.SetPressedNoSignal(value); expandIcon.Expanded = value; expandIcon.QueueRedraw(); }`
- `_privateExpressions` = `CommunityReplyExpressions.Attach(_privateInput!, composerBody, left, actions)`
- `_privateSend.Name` = `"PrivateSend"`
- `_privateSend.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `_privateSend.SizeFlagsVertical` = `SizeFlags.Fill`
- `_privateSend.TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`
- `_privateSend.TooltipText` = `"Ctrl+Enter 发送"`
- `_privateSend` = `PrivateButton("发送", SendPrivate, 80 + ChatComposerLayout.SendWidthIncrease)`
- `expand.Name` = `"PrivateExpand"`
- `expand.SizeFlagsVertical` = `SizeFlags.Fill`
- `expand.ToggleMode` = `true`
- `expand.TooltipText` = `"放大输入框 / 恢复默认大小"`
- `expandIcon.Expanded` = `value`
- `more.Name` = `"PrivateMoreActions"`
- `more.SizeFlagsVertical` = `SizeFlags.Fill`
- `shortcut.Name` = `"PrivateSendShortcut"`
- `shortcut.SizeFlagsVertical` = `SizeFlags.ShrinkCenter`

<a id="symbol-eb21fd76632c"></a>

## `NationalSpire.CareerScreen.ClosePrivateMessages() — private void ClosePrivateMessages()`

来源：源码第 136 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen._Input(Godot.InputEvent)`](CareerScreen.cs.md#symbol-a9891646fd75)；[`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-c7881d245b3d)；[`NationalSpire.CareerScreen.GroupOffer(NationalSpire.GroupChat, NationalSpire.GroupEffect, NationalSpire.PrivateOffer)`](GroupChatScreen.cs.md#symbol-3afa41099b93)

**调用：** [`NationalSpire.CareerScreen.ClosePrivateMessagesCore(bool)`](PrivateMessageScreen.cs.md#symbol-db8b0a9ff8de)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ClosePrivateMessagesCore(bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.ClosePrivateMessagesCore(bool)`；输入表达式：`ClosePrivateMessagesCore(true)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => ClosePrivateMessagesCore(true)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-db8b0a9ff8de"></a>

## `NationalSpire.CareerScreen.ClosePrivateMessagesCore(bool) — private void ClosePrivateMessagesCore(bool render)`

来源：源码第 138 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClosePrivateMessages()`](PrivateMessageScreen.cs.md#symbol-eb21fd76632c)；[`NationalSpire.CareerScreen.OpenGroupPerson(string)`](GroupChatScreen.cs.md#symbol-1eb7b9a65ede)；[`NationalSpire.CareerScreen.OpenPrivateOfferCalendar(NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-730bf8884640)；[`NationalSpire.CareerScreen.OpenPrivatePerson(string)`](PrivateMessageScreen.cs.md#symbol-bae5675b92b9)

**调用：** `Godot.Node.QueueFree()`；[`NationalSpire.CareerScreen.CloseChatContextMenu()`](ChatContextMenuScreen.cs.md#symbol-02269de4e133)；[`NationalSpire.CareerScreen.CloseContactMenu()`](ChatContactScreen.cs.md#symbol-878c75543fa8)；[`NationalSpire.CareerScreen.CloseDateScene()`](DateSceneScreen.cs.md#symbol-375f9bc3e86a)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.ChatHistoryPage<T>.Reset(int)`](ChatHistoryPage.cs.md#symbol-e836f7b91e73)；`System.Collections.Generic.HashSet<T>.Clear()`；`System.Collections.Generic.List<T>.Clear()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ChatDraftKey`；`NationalSpire.CareerScreen.CloseChatContextMenu()`；`NationalSpire.CareerScreen.CloseContactMenu()`；`NationalSpire.CareerScreen.CloseDateScene()`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._boundData`；`NationalSpire.CareerScreen._chatPageSize`；`NationalSpire.CareerScreen._datePhoneOffer`；`NationalSpire.CareerScreen._datePhonePerson`；`NationalSpire.CareerScreen._datePhoneReturn`；`NationalSpire.CareerScreen._groupPages`；`NationalSpire.CareerScreen._groupReasoningUpdate`；`NationalSpire.CareerScreen._groupStreamLabels`；`NationalSpire.CareerScreen._groupStreamParser`；`NationalSpire.CareerScreen._privateActions`；`NationalSpire.CareerScreen._privateComposer`；`NationalSpire.CareerScreen._privateDrafts`；`NationalSpire.CareerScreen._privateExpandedTraining`；`NationalSpire.CareerScreen._privateExpressions`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen._privateInput`；`NationalSpire.CareerScreen._privateOverlay`；`NationalSpire.CareerScreen._privatePages`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen._privateScrollRevision`；`NationalSpire.CareerScreen._privateStreamText`；`NationalSpire.CareerScreen._privateStreamThought`；`NationalSpire.ChatHistoryPage<T>.Reset(int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.QueueFree()`；输入表达式：`_privateOverlay.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateOverlay.QueueFree();`
- `NationalSpire.CareerScreen.CloseChatContextMenu()`；输入表达式：`CloseChatContextMenu()`；返回值紧邻使用处：`ExpressionStatementSyntax: CloseChatContextMenu();`
- `NationalSpire.CareerScreen.CloseContactMenu()`；输入表达式：`CloseContactMenu()`；返回值紧邻使用处：`ExpressionStatementSyntax: CloseContactMenu();`
- `NationalSpire.CareerScreen.CloseDateScene()`；输入表达式：`CloseDateScene()`；返回值紧邻使用处：`ExpressionStatementSyntax: CloseDateScene();`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.ChatHistoryPage<T>.Reset(int)`；输入表达式：`_groupPages.Reset(_chatPageSize)`；返回值紧邻使用处：`ExpressionStatementSyntax: _groupPages.Reset(_chatPageSize);`
- `NationalSpire.ChatHistoryPage<T>.Reset(int)`；输入表达式：`_privatePages.Reset(_chatPageSize)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privatePages.Reset(_chatPageSize);`
- `System.Collections.Generic.HashSet<T>.Clear()`；输入表达式：`_privateExpandedTraining.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateExpandedTraining.Clear();`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`_groupStreamLabels.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _groupStreamLabels.Clear();`

**赋值（含属性/字段和局部值）：**

- `_boundData` = `ViewData`
- `_datePhoneOffer` = `""`
- `_datePhonePerson` = `_datePhoneOffer = ""`
- `_datePhoneReturn` = `null`
- `_groupReasoningUpdate` = `null`
- `_groupStreamParser` = `null`
- `_privateActions` = `null`
- `_privateComposer` = `null`
- `_privateDrafts[ChatDraftKey]` = `_privateInput.Text`
- `_privateExpressions` = `null`
- `_privateGroup` = `""`
- `_privateOverlay` = `null`
- `_privatePerson` = `""`
- `_privateStreamText` = `_privateStreamThought = _groupReasoningUpdate = null`
- `_privateStreamThought` = `_groupReasoningUpdate = null`

<a id="symbol-bae5675b92b9"></a>

## `NationalSpire.CareerScreen.OpenPrivatePerson(string) — private void OpenPrivatePerson(string person)`

来源：源码第 152 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`OpenProfile()`](PrivateMemoryScreen.cs.md#symbol-62a9132d4681)

**调用：** [`NationalSpire.CareerScreen.CaptureLocation()`](CareerNavigation.cs.md#symbol-67f7f7696f8a)；[`NationalSpire.CareerScreen.ClosePrivateMessagesCore(bool)`](PrivateMessageScreen.cs.md#symbol-db8b0a9ff8de)；[`NationalSpire.CareerScreen.UpdateNavigation()`](CareerNavigation.cs.md#symbol-a6094a69b6d7)；[`NationalSpire.CareerScreen.Visit(System.Action)`](CareerNavigation.cs.md#symbol-d49752019228)；`System.Collections.Generic.Stack<T>.Pop()`；`System.Collections.Generic.Stack<T>.Push(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Failure`；`NationalSpire.CareerScreen._backHistory`；`NationalSpire.CareerScreen._personId`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen._privateScroll`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen.CaptureLocation()`；`NationalSpire.CareerScreen.ChatPage`；`NationalSpire.CareerScreen.ClosePrivateMessagesCore(bool)`；`NationalSpire.CareerScreen.Location.ChatPage`；`NationalSpire.CareerScreen.Location.ChatScroll`；`NationalSpire.CareerScreen.Location.PrivatePerson`；`NationalSpire.CareerScreen.UpdateNavigation()`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen.Visit(System.Action)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.CaptureLocation()`；输入表达式：`CaptureLocation()`；返回值紧邻使用处：`WithExpressionSyntax: CaptureLocation() with { PrivatePerson = _privatePerson, ChatScroll = _privateScroll!.ScrollVertical, ChatPage = ChatPage }`
- `NationalSpire.CareerScreen.ClosePrivateMessagesCore(bool)`；输入表达式：`ClosePrivateMessagesCore(false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClosePrivateMessagesCore(false);`
- `NationalSpire.CareerScreen.UpdateNavigation()`；输入表达式：`UpdateNavigation()`；返回值紧邻使用处：`ExpressionStatementSyntax: UpdateNavigation();`
- `NationalSpire.CareerScreen.Visit(System.Action)`；输入表达式：`Visit(() => { _tab = "选手档案"; _personId = person; })`；返回值紧邻使用处：`ExpressionStatementSyntax: Visit(() => { _tab = "选手档案"; _personId = person; });`
- `System.Collections.Generic.Stack<T>.Pop()`；输入表达式：`_backHistory.Pop()`；返回值紧邻使用处：`ExpressionStatementSyntax: _backHistory.Pop();`
- `System.Collections.Generic.Stack<T>.Push(T)`；输入表达式：`_backHistory.Push(previous)`；返回值紧邻使用处：`ExpressionStatementSyntax: _backHistory.Push(previous);`

**赋值（含属性/字段和局部值）：**

- `_personId` = `person`
- `_tab` = `"选手档案"`
- `ChatPage` = `ChatPage`
- `ChatScroll` = `_privateScroll!.ScrollVertical`
- `PrivatePerson` = `_privatePerson`

<a id="symbol-be8cf79217b4"></a>

## `NationalSpire.CareerScreen.SelectPrivate(string, int) — private void SelectPrivate(string person, int page = -1)`

来源：源码第 160 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ChatMenuItems(string, bool)`](ChatManagementScreen.cs.md#symbol-99485204d7d6)；[`NationalSpire.CareerScreen.CreatePrivateListRow()`](PrivateListRows.cs.md#symbol-ae3a09702cbd)；[`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.RestoreChatDialog()`](ChatManagementScreen.cs.md#symbol-812702bacb1e)；[`Open(System.Action)`](ChatManagementScreen.cs.md#symbol-f889b0a7e3d1)

**调用：** [`NationalSpire.CareerScreen.BindChatPage(bool)`](ChatHistoryScreen.cs.md#symbol-e22063fef4cb)；[`NationalSpire.CareerScreen.InvalidateChatPage(int)`](ChatHistoryScreen.cs.md#symbol-110069df9a95)；[`NationalSpire.CareerScreen.RefreshPrivateAttachments()`](PrivateMemoryScreen.cs.md#symbol-b9d6c2084031)；[`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)；[`NationalSpire.CareerScreen.ResetChatPage()`](ChatHistoryScreen.cs.md#symbol-0a8a3b0ae98b)；[`NationalSpire.CareerScreen.SaveChatPreferences()`](ChatHistoryScreen.cs.md#symbol-614208ed0b0d)；[`NationalSpire.ChatHistoryPage<T>.Move(int)`](ChatHistoryPage.cs.md#symbol-27c362fe5d02)；[`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-25194feb6779)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._privateDrafts`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen._privateInput`；`NationalSpire.CareerScreen._privateListSignature`；`NationalSpire.CareerScreen._privatePages`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen._privateSend`；`NationalSpire.CareerScreen.BindChatPage(bool)`；`NationalSpire.CareerScreen.ChatDraftKey`；`NationalSpire.CareerScreen.InvalidateChatPage(int)`；`NationalSpire.CareerScreen.RefreshPrivateAttachments()`；`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`；`NationalSpire.CareerScreen.ResetChatPage()`；`NationalSpire.CareerScreen.SaveChatPreferences()`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.ChatHistoryPage<T>.Move(int)`；`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.BindChatPage(bool)`；输入表达式：`BindChatPage(true)`；返回值紧邻使用处：`ExpressionStatementSyntax: BindChatPage(true);`
- `NationalSpire.CareerScreen.InvalidateChatPage(int)`；输入表达式：`InvalidateChatPage(0)`；返回值紧邻使用处：`ExpressionStatementSyntax: InvalidateChatPage(0);`
- `NationalSpire.CareerScreen.RefreshPrivateAttachments()`；输入表达式：`RefreshPrivateAttachments()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshPrivateAttachments();`
- `NationalSpire.CareerScreen.RefreshPrivateChat(bool)`；输入表达式：`RefreshPrivateChat()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshPrivateChat();`
- `NationalSpire.CareerScreen.ResetChatPage()`；输入表达式：`ResetChatPage()`；返回值紧邻使用处：`ExpressionStatementSyntax: ResetChatPage();`
- `NationalSpire.CareerScreen.SaveChatPreferences()`；输入表达式：`SaveChatPreferences()`；返回值紧邻使用处：`ExpressionStatementSyntax: SaveChatPreferences();`
- `NationalSpire.ChatHistoryPage<T>.Move(int)`；输入表达式：`_privatePages.Move(page)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privatePages.Move(page);`
- `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.CanChat(ViewData, person)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PrivateMessages.CanChat(ViewData, person)`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(ViewData, person)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateMessages.Conversation(ViewData, person);`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`_privateDrafts.GetValueOrDefault(person, "")`；返回值紧邻使用处：`AssignmentExpressionSyntax: _privateInput!.Text = _privateDrafts.GetValueOrDefault(person, "")`

**赋值（含属性/字段和局部值）：**

- `_privateDrafts[_privatePerson]` = `_privateInput!.Text`
- `_privateDrafts[ChatDraftKey]` = `_privateInput.Text`
- `_privateGroup` = `""`
- `_privateInput!.Text` = `_privateDrafts.GetValueOrDefault(person, "")`
- `_privateListSignature` = `""`
- `_privatePerson` = `person`
- `_privateSend!.Disabled` = `false`

<a id="symbol-3877a8ac5969"></a>

## `NationalSpire.CareerScreen.TickPrivate(double) — private void TickPrivate(double delta)`

来源：源码第 174 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen._Process(double)`](CareerScreen.cs.md#symbol-de0dbc5f9504)

**调用：** [`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)；[`NationalSpire.CareerScreen.RefreshPrivateList()`](PrivateMessageScreen.cs.md#symbol-fca825e025fa)；[`NationalSpire.CareerScreen.RefreshPrivateProposal()`](PrivateMessageScreen.cs.md#symbol-fcf77d9c4194)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.GroupChats.Visible(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-81f7f177c347)；[`NationalSpire.ICareerSession.Refresh()`](CareerSession.cs.md#symbol-bae3aaaf496d)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；[`NationalSpire.PrivateMessages.UnreadInCommunications(NationalSpire.PrivateConversation)`](PrivateMessages.cs.md#symbol-8f55a4576019)；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._privateBadge`；`NationalSpire.CareerScreen._privateClock`；`NationalSpire.CareerScreen._privateOverlay`；`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`；`NationalSpire.CareerScreen.RefreshPrivateList()`；`NationalSpire.CareerScreen.RefreshPrivateProposal()`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerVisuals.Gold`；`NationalSpire.GroupChat.Seen`；`NationalSpire.GroupChat.Turns`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.GroupChats.Visible(NationalSpire.CareerData)`；`NationalSpire.GroupTurn.Status`；`NationalSpire.ICareerSession.Refresh()`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateMessages.UnreadInCommunications(NationalSpire.PrivateConversation)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.RefreshPrivateChat(bool)`；输入表达式：`RefreshPrivateChat()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshPrivateChat();`
- `NationalSpire.CareerScreen.RefreshPrivateList()`；输入表达式：`RefreshPrivateList()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshPrivateList();`
- `NationalSpire.CareerScreen.RefreshPrivateProposal()`；输入表达式：`RefreshPrivateProposal()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshPrivateProposal();`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(ViewData)`；返回值紧邻使用处：`ArgumentSyntax: GroupChats.Human(ViewData)`
- `NationalSpire.GroupChats.Visible(NationalSpire.CareerData)`；输入表达式：`GroupChats.Visible(ViewData)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GroupChats.Visible(ViewData).Sum`
- `NationalSpire.ICareerSession.Refresh()`；输入表达式：`.Refresh()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _multiplayer?.Refresh()`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(ViewData)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Mailbox(ViewData)`
- `NationalSpire.PrivateMessages.UnreadInCommunications(NationalSpire.PrivateConversation)`；输入表达式：`PrivateMessages.UnreadInCommunications(c)`；返回值紧邻使用处：`ArgumentSyntax: PrivateMessages.UnreadInCommunications(c)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Turns.Count(t => t.Status == "complete")`；返回值紧邻使用处：`BinaryExpressionSyntax: g.Turns.Count(t => t.Status == "complete") - g.Seen.GetValueOrDefault(GroupChats.Human(ViewData))`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`box.Conversations.Values.Sum(c => Math.Max(0, PrivateMessages.UnreadInCommunications(c)))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = box.Conversations.Values.Sum(c => Math.Max(0, PrivateMessages.UnreadInCommunications(c)))`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`GroupChats.Visible(ViewData).Sum(g => Math.Max(0, g.Turns.Count(t => t.Status == "complete") - g.Seen.GetValueOrDefault(GroupChats.Human(ViewData))))`；返回值紧邻使用处：`AssignmentExpressionSyntax: unread += GroupChats.Visible(ViewData).Sum(g => Math.Max(0, g.Turns.Count(t => t.Status == "complete") - g.Seen.GetValueOrDefault(GroupChats.Human(ViewData))))`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`g.Seen.GetValueOrDefault(GroupChats.Human(ViewData))`；返回值紧邻使用处：`BinaryExpressionSyntax: g.Turns.Count(t => t.Status == "complete") - g.Seen.GetValueOrDefault(GroupChats.Human(ViewData))`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, g.Turns.Count(t => t.Status == "complete") - g.Seen.GetValueOrDefault(GroupChats.Human(ViewData)))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => Math.Max(0, g.Turns.Count(t => t.Status == "complete") - g.Seen.GetValueOrDefault(GroupChats.Human(ViewData)))`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, PrivateMessages.UnreadInCommunications(c))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => Math.Max(0, PrivateMessages.UnreadInCommunications(c))`

**赋值（含属性/字段和局部值）：**

- `_privateBadge.Modulate` = `unread > 0 ? CareerVisuals.Gold : Colors.White`
- `_privateBadge.TooltipText` = `unread > 0 ? $"通讯 · {unread} 条未读" : "通讯"`
- `_privateClock` += `delta`
- `_privateClock` = `0`
- `unread` += `GroupChats.Visible(ViewData).Sum(g => Math.Max(0, g.Turns.Count(t => t.Status == "complete") - g.Seen.GetValueOrDefault(GroupChats.Human(ViewData))))`

<a id="symbol-fcf77d9c4194"></a>

## `NationalSpire.CareerScreen.RefreshPrivateProposal() — private void RefreshPrivateProposal()`

来源：源码第 184 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.TickPrivate(double)`](PrivateMessageScreen.cs.md#symbol-3877a8ac5969)

**调用：** [`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-e21b0ff1d18b)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._privateProposal`；`NationalSpire.CareerScreen._privateProposalSignature`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.ICareerSession.HasVoted`；`NationalSpire.ICareerSession.Host`；`NationalSpire.ICareerSession.ProposalId`；`NationalSpire.ICareerSession.ProposalText`；`NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`buttons.AddThemeConstantOverride("separation", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: buttons.AddThemeConstantOverride("separation", 14);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateProposal.AddChild(buttons)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateProposal.AddChild(buttons);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateProposal.AddChild(Text(_multiplayer.ProposalText, 17, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateProposal.AddChild(Text(_multiplayer.ProposalText, 17, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`buttons.AddChild(approve)`；返回值紧邻使用处：`ExpressionStatementSyntax: buttons.AddChild(approve);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`buttons.AddChild(PrivateButton("取消安排", () => _multiplayer.Send("cancel"), 160))`；返回值紧邻使用处：`ExpressionStatementSyntax: buttons.AddChild(PrivateButton("取消安排", () => _multiplayer.Send("cancel"), 160));`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton(_multiplayer.HasVoted ? "已准备，等待队友" : "准备开赛", () => _multiplayer.Send("confirm", _multiplayer.ProposalId), 220)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton(_multiplayer.HasVoted ? "已准备，等待队友" : "准备开赛", () => _multiplayer.Send("confirm", _multiplayer.ProposalId), 220)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("取消安排", () => _multiplayer.Send("cancel"), 160)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("取消安排", () => _multiplayer.Send("cancel"), 160)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(_multiplayer.ProposalText, 17, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(_multiplayer.ProposalText, 17, _gold)`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(_privateProposal)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(_privateProposal);`
- `NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?)`；输入表达式：`_multiplayer.Send("cancel")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => _multiplayer.Send("cancel")`
- `NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?)`；输入表达式：`_multiplayer.Send("confirm", _multiplayer.ProposalId)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => _multiplayer.Send("confirm", _multiplayer.ProposalId)`

**赋值（含属性/字段和局部值）：**

- `_privateProposalSignature` = `signature`
- `approve.Disabled` = `_multiplayer.HasVoted`

<a id="symbol-fca825e025fa"></a>

## `NationalSpire.CareerScreen.RefreshPrivateList() — private void RefreshPrivateList()`

来源：源码第 197 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildContactSearch(Godot.VBoxContainer)`](ChatContactScreen.cs.md#symbol-3c7d41806831)；[`NationalSpire.CareerScreen.GroupSidebar(Godot.VBoxContainer)`](GroupChatScreen.cs.md#symbol-88d7619ce50a)；[`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.SaveContactPreferences()`](ChatContactScreen.cs.md#symbol-ecb1bd4e6ac2)；[`NationalSpire.CareerScreen.SelectGroup(string, int)`](GroupChatScreen.cs.md#symbol-72d02215d0db)；[`NationalSpire.CareerScreen.SetChatPinned(string, bool)`](ChatContextMenuScreen.cs.md#symbol-8689933c2c76)；[`NationalSpire.CareerScreen.TickPrivate(double)`](PrivateMessageScreen.cs.md#symbol-3877a8ac5969)；[`Removed()`](ChatManagementScreen.cs.md#symbol-0702711e2eee)

**调用：** [`NationalSpire.CareerScreen.ShowPrivateListRows()`](PrivateListRows.cs.md#symbol-a42f68b15faf)；[`NationalSpire.ChatContacts.EventIndicators(NationalSpire.CareerData)`](ChatContacts.cs.md#symbol-e894a486e226)；[`NationalSpire.ChatContacts.List(NationalSpire.CareerData, NationalSpire.ChatContactPreferences, string, string)`](ChatContacts.cs.md#symbol-9d6a9ed3895a)；[`NationalSpire.GroupChats.Visible(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-81f7f177c347)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Vector2.Vector2(float, float)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.List<T>.Clear()`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerScreen._chatFilter`；`NationalSpire.CareerScreen._chatPinRanks`；`NationalSpire.CareerScreen._contactPreferences`；`NationalSpire.CareerScreen._privateEntries`；`NationalSpire.CareerScreen._privateEvents`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen._privateList`；`NationalSpire.CareerScreen._privateListSignature`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen._privateQuery`；`NationalSpire.CareerScreen._renderVersion`；`NationalSpire.CareerScreen.ShowPrivateListRows()`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.ChatContactPreferences.Pinned`；`NationalSpire.ChatContacts.EventIndicators(NationalSpire.CareerData)`；`NationalSpire.ChatContacts.List(NationalSpire.CareerData, NationalSpire.ChatContactPreferences, string, string)`；`NationalSpire.GroupChat.Id`；`NationalSpire.GroupChat.Revision`；`NationalSpire.GroupChat.Turns`；`NationalSpire.GroupChats.Visible(NationalSpire.CareerData)`；`NationalSpire.PrivateConversation.LastReplyOrder`；`NationalSpire.PrivateConversation.MemoryRevision`；`NationalSpire.PrivateConversation.SeenCount`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateTurn.Status`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.PrivateList`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_privateList)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(_privateList)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, Math.Max(30, _privateEntries.Count * 94 - 12))`；返回值紧邻使用处：`AssignmentExpressionSyntax: _privateList.CustomMinimumSize = new(0, Math.Max(30, _privateEntries.Count * 94 - 12))`
- `NationalSpire.CareerScreen.ShowPrivateListRows()`；输入表达式：`ShowPrivateListRows()`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowPrivateListRows();`
- `NationalSpire.ChatContacts.EventIndicators(NationalSpire.CareerData)`；输入表达式：`ChatContacts.EventIndicators(data)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _privateEvents = ChatContacts.EventIndicators(data)`
- `NationalSpire.ChatContacts.List(NationalSpire.CareerData, NationalSpire.ChatContactPreferences, string, string)`；输入表达式：`ChatContacts.List(data, _contactPreferences, _chatFilter, _privateQuery)`；返回值紧邻使用处：`ArgumentSyntax: ChatContacts.List(data, _contactPreferences, _chatFilter, _privateQuery)`
- `NationalSpire.GroupChats.Visible(NationalSpire.CareerData)`；输入表达式：`GroupChats.Visible(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GroupChats.Visible(data).Select`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Mailbox(data)`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.PrivateList, "通讯")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.PrivateList, "通讯")`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("|", GroupChats.Visible(data).Select(g => g.Id + ":" + g.Revision + ":" + g.Turns.Count))`；返回值紧邻使用处：`BinaryExpressionSyntax: data.Day + ":" + _renderVersion + ":" + _chatFilter + _privateGroup + string.Join("|", GroupChats.Visible(data).Select(g => g.Id + ":" + g.Revision + ":" + g.Turns.Count))`
- `string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；输入表达式：`string.Join('|', box.Conversations.Select(p => p.Key + p.Value.Turns.Count + ":" + p.Value.Turns.LastOrDefault()?.Status + ":" + p.Value.SeenCount + ":" + p.Value.MemoryRevision + ":" + p.Value.LastReplyOrder))`；返回值紧邻使用处：`BinaryExpressionSyntax: data.Day + ":" + _renderVersion + ":" + _chatFilter + _privateGroup + string.Join("|", GroupChats.Visible(data).Select(g => g.Id + ":" + g.Revision + ":" + g.Turns.Count)) + _privatePerson + _privateQuery + string.Join('|', box.Conversations.Select(p => p.Key + p.Value.Turns.Count + ":" + p.Value.Turns.LastOrDefault()?.Status + ":" + p.Value.SeenCount + ":" + p.Value.MemoryRevision + ":" + p.Value.LastReplyOrder))`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`p.Value.Turns.LastOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: p.Value.Turns.LastOrDefault()?.Status`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`_chatPinRanks.OrderBy(p => p.Value)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _chatPinRanks.OrderBy(p => p.Value).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`_chatPinRanks.OrderBy(p => p.Value).Select(p => p.Key)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _chatPinRanks.OrderBy(p => p.Value).Select(p => p.Key).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`box.Conversations.Select(p => p.Key + p.Value.Turns.Count + ":" + p.Value.Turns.LastOrDefault()?.Status + ":" + p.Value.SeenCount + ":" + p.Value.MemoryRevision + ":" + p.Value.LastReplyOrder)`；返回值紧邻使用处：`ArgumentSyntax: box.Conversations.Select(p => p.Key + p.Value.Turns.Count + ":" + p.Value.Turns.LastOrDefault()?.Status + ":" + p.Value.SeenCount + ":" + p.Value.MemoryRevision + ":" + p.Value.LastReplyOrder)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`GroupChats.Visible(data).Select(g => g.Id + ":" + g.Revision + ":" + g.Turns.Count)`；返回值紧邻使用处：`ArgumentSyntax: GroupChats.Visible(data).Select(g => g.Id + ":" + g.Revision + ":" + g.Turns.Count)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`_chatPinRanks.OrderBy(p => p.Value).Select(p => p.Key).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _contactPreferences.Pinned = _chatPinRanks.OrderBy(p => p.Value).Select(p => p.Key).ToList()`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`_privateEntries.AddRange(ChatContacts.List(data, _contactPreferences, _chatFilter, _privateQuery))`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateEntries.AddRange(ChatContacts.List(data, _contactPreferences, _chatFilter, _privateQuery));`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`_privateEntries.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateEntries.Clear();`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(30, _privateEntries.Count * 94 - 12)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(30, _privateEntries.Count * 94 - 12)`

**赋值（含属性/字段和局部值）：**

- `_contactPreferences.Pinned` = `_chatPinRanks.OrderBy(p => p.Value).Select(p => p.Key).ToList()`
- `_privateEvents` = `ChatContacts.EventIndicators(data)`
- `_privateList.CustomMinimumSize` = `new(0, Math.Max(30, _privateEntries.Count * 94 - 12))`
- `_privateListSignature` = `signature`

<a id="symbol-45a464c95599"></a>

## `NationalSpire.CareerScreen.UpdatePrivateStream(string, string, bool) — private void UpdatePrivateStream(string text, string thought, bool follow)`

来源：源码第 214 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)

**调用：** [`NationalSpire.CareerScreen.ScrollPrivateToBottom()`](PrivateMessageScreen.cs.md#symbol-b2deefc4ba01)；`Godot.ScrollContainer.GetVScrollBar()`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._privateScroll`；`NationalSpire.CareerScreen._privateStreamLastText`；`NationalSpire.CareerScreen._privateStreamLastThought`；`NationalSpire.CareerScreen._privateStreamText`；`NationalSpire.CareerScreen._privateStreamThought`；`NationalSpire.CareerScreen.ChatAtLatest`；`NationalSpire.CareerScreen.ScrollPrivateToBottom()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ScrollContainer.GetVScrollBar()`；输入表达式：`_privateScroll.GetVScrollBar()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _privateScroll.GetVScrollBar().MaxValue`
- `NationalSpire.CareerScreen.ScrollPrivateToBottom()`；输入表达式：`ScrollPrivateToBottom()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = ScrollPrivateToBottom()`
- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke(text)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _privateStreamText?.Invoke(text)`
- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke(thought)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _privateStreamThought?.Invoke(thought)`

**赋值（含属性/字段和局部值）：**

- `_` = `ScrollPrivateToBottom()`
- `_privateStreamLastText` = `text`
- `_privateStreamLastThought` = `thought`

<a id="symbol-cef7c0adba54"></a>

## `NationalSpire.CareerScreen.RefreshPrivateChat(bool) — private void RefreshPrivateChat(bool follow = true)`

来源：源码第 222 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildChatPagination(NationalSpire.ChatComposerLayout)`](ChatHistoryScreen.cs.md#symbol-5fc0f2f77de5)；[`NationalSpire.CareerScreen.ChangeChatPage(int)`](ChatHistoryScreen.cs.md#symbol-0e399328f32b)；[`NationalSpire.CareerScreen.LatestChatPage()`](ChatHistoryScreen.cs.md#symbol-566a2e34c9dd)；[`NationalSpire.CareerScreen.LeaveDateScene(bool)`](DateSceneScreen.cs.md#symbol-942f3afae68b)；[`NationalSpire.CareerScreen.SelectPrivate(string, int)`](PrivateMessageScreen.cs.md#symbol-be8cf79217b4)；[`NationalSpire.CareerScreen.TickPrivate(double)`](PrivateMessageScreen.cs.md#symbol-3877a8ac5969)

**调用：** `Godot.Color.Color(string)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.ScrollContainer.GetVScrollBar()`；[`NationalSpire.AiService.PrivateKey(NationalSpire.CareerData, string)`](AiPrivateMessages.cs.md#symbol-97ba03595bc3)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerScreen.AddChatReasoning(string, string)`](PrivateMemoryScreen.cs.md#symbol-fdbe84837533)；[`NationalSpire.CareerScreen.AddPausedDateScenes(NationalSpire.CareerData, NationalSpire.PrivateConversation)`](DateSceneScreen.cs.md#symbol-a5b10d9fb0b8)；[`NationalSpire.CareerScreen.AddPrivateBubble(string, bool, NationalSpire.PrivateTurn)`](PrivateMessageScreen.cs.md#symbol-b24b4d693d2a)；[`NationalSpire.CareerScreen.AddPrivateLearning(NationalSpire.PrivateTurn, NationalSpire.PrivateLearning)`](PrivateMemoryScreen.cs.md#symbol-74357ea296a8)；[`NationalSpire.CareerScreen.AddPrivateMood(NationalSpire.PrivateMood)`](PrivateMemoryScreen.cs.md#symbol-1cd11d02c1b9)；[`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-c7881d245b3d)；[`NationalSpire.CareerScreen.AddPrivateProfileChange(NationalSpire.PrivateProfileChange)`](PrivateMemoryScreen.cs.md#symbol-cd1de98ddea7)；[`NationalSpire.CareerScreen.ArbitrationCard(NationalSpire.CareerData, NationalSpire.ArbitrationRecord)`](ArbitrationScreen.cs.md#symbol-8d41f13d5476)；[`NationalSpire.CareerScreen.BindChatPage(bool)`](ChatHistoryScreen.cs.md#symbol-e22063fef4cb)；[`NationalSpire.CareerScreen.FinishChatPage(bool)`](ChatHistoryScreen.cs.md#symbol-7519bc2ca961)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.PrivateEmpty(string, string)`](PrivateMemoryScreen.cs.md#symbol-e829c0d03f86)；[`NationalSpire.CareerScreen.PrivateIdentity(NationalSpire.CareerData, string, bool)`](PrivateMemoryScreen.cs.md#symbol-65caddca194f)；[`NationalSpire.CareerScreen.PrivateLineupCard(NationalSpire.CareerData, NationalSpire.CoachLineupRequest, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?)`](CoachScreen.cs.md#symbol-c01675f974f7)；[`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`](PrivateMessageScreen.cs.md#symbol-fb5e88f4639a)；[`NationalSpire.CareerScreen.RefreshGroupChat()`](GroupChatScreen.cs.md#symbol-b56fe79b2db7)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerScreen.TrainingCompletions(System.Collections.Generic.IEnumerable<NationalSpire.PrivateOffer>, long, long)`](CoachScreen.cs.md#symbol-c316f7a67f3e)；[`NationalSpire.CareerScreen.TrainingCompletionsThrough(System.Collections.Generic.Queue<NationalSpire.CoachTrainingPlan>, long)`](CoachScreen.cs.md#symbol-9deab8f6abda)；[`NationalSpire.CareerScreen.UpdatePrivateStream(string, string, bool)`](PrivateMessageScreen.cs.md#symbol-45a464c95599)；[`NationalSpire.CareerTraining.MoodLevel(NationalSpire.CareerPerson, int)`](CareerTraining.cs.md#symbol-cd61283f2c46)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`NationalSpire.ClubCoaching.TrainingContext(NationalSpire.CareerData, string)`](ClubCoaching.cs.md#symbol-b2b767ed4fea)；[`NationalSpire.CoachLineups.Context(NationalSpire.CareerData, string)`](CoachLineups.cs.md#symbol-1299df81c255)；[`NationalSpire.DateSceneEffects.SourceTurn(NationalSpire.PrivateMailbox, string, string)`](DateSceneEffects.cs.md#symbol-b961def8188f)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；[`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-8a6bb6e78fa5)；[`NationalSpire.PrivateMessages.VisibleInCommunications(NationalSpire.PrivateTurn)`](PrivateMessages.cs.md#symbol-b69ec8c11bc6)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Last<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.PrivateKey(NationalSpire.CareerData, string)`；`NationalSpire.AiService.PrivateLive`；`NationalSpire.AiService.PrivateReasoningLive`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen.AddChatReasoning(string, string)`；`NationalSpire.CareerScreen.AddPausedDateScenes(NationalSpire.CareerData, NationalSpire.PrivateConversation)`；`NationalSpire.CareerScreen.AddPrivateBubble(string, bool, NationalSpire.PrivateTurn)`；`NationalSpire.CareerScreen.AddPrivateLearning(NationalSpire.PrivateTurn, NationalSpire.PrivateLearning)`；`NationalSpire.CareerScreen.AddPrivateMood(NationalSpire.PrivateMood)`；`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.CareerScreen.AddPrivateProfileChange(NationalSpire.PrivateProfileChange)`；`NationalSpire.CareerScreen.ArbitrationCard(NationalSpire.CareerData, NationalSpire.ArbitrationRecord)`；`NationalSpire.CareerScreen.BindChatPage(bool)`；`NationalSpire.CareerScreen.ChatAtBottom`；`NationalSpire.CareerScreen.ChatAtLatest`；`NationalSpire.CareerScreen.FinishChatPage(bool)`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；`NationalSpire.CareerScreen.PrivateEmpty(string, string)`；`NationalSpire.CareerScreen.PrivateIdentity(NationalSpire.CareerData, string, bool)`；`NationalSpire.CareerScreen.PrivateLineupCard(NationalSpire.CareerData, NationalSpire.CoachLineupRequest, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?)`；`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；`NationalSpire.CareerScreen.RefreshGroupChat()`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.TrainingCompletions(System.Collections.Generic.IEnumerable<NationalSpire.PrivateOffer>, long, long)`；`NationalSpire.CareerScreen.TrainingCompletionsThrough(System.Collections.Generic.Queue<NationalSpire.CoachTrainingPlan>, long)`；`NationalSpire.CareerScreen.UpdatePrivateStream(string, string, bool)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._privateBody`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen._privateHeading`；`NationalSpire.CareerScreen._privateInput`；`NationalSpire.CareerScreen._privatePages`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen._privateScroll`；`NationalSpire.CareerScreen._privateSend`；`NationalSpire.CareerScreen._privateSignature`；`NationalSpire.CareerScreen._privateStatus`；`NationalSpire.CareerScreen._privateStreamLastText`；`NationalSpire.CareerScreen._privateStreamLastThought`；`NationalSpire.CareerScreen._privateStreamText`；`NationalSpire.CareerScreen._privateStreamThought`；`NationalSpire.CareerTraining.MoodLevel(NationalSpire.CareerPerson, int)`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.ChatHistoryPage<T>.Count`；`NationalSpire.ChatHistoryPage<T>.Next`；`NationalSpire.ChatHistoryPage<T>.Page`；`NationalSpire.ChatHistoryPage<T>.Size`；`NationalSpire.ChatHistoryPage<T>.Visible`；`NationalSpire.ClubCoaching.TrainingContext(NationalSpire.CareerData, string)`；`NationalSpire.CoachLineupRequest.ClubId`；`NationalSpire.CoachLineupRequest.Coach`；`NationalSpire.CoachLineupRequest.TurnId`；`NationalSpire.CoachLineups.Context(NationalSpire.CareerData, string)`；`NationalSpire.DateSceneEffects.SourceTurn(NationalSpire.PrivateMailbox, string, string)`；`NationalSpire.DateSceneRequest.Ending`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsCareer.LineupRequests`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.PrivateConversation.DateSceneStates`；`NationalSpire.PrivateConversation.MemoryRevision`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateConversation.SeenCount`；`NationalSpire.PrivateConversation.SummaryError`；`NationalSpire.PrivateConversation.SummaryStatus`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateMessages.VisibleInCommunications(NationalSpire.PrivateTurn)`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.State`；`NationalSpire.PrivateOffer.TurnId`；`NationalSpire.PrivateRelation.Revision`；`NationalSpire.PrivateTurn.Arbitration`；`NationalSpire.PrivateTurn.Day`；`NationalSpire.PrivateTurn.Error`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.PrivateTurn.Learning`；`NationalSpire.PrivateTurn.Mood`；`NationalSpire.PrivateTurn.ProactiveReason`；`NationalSpire.PrivateTurn.ProfileChanges`；`NationalSpire.PrivateTurn.Reasoning`；`NationalSpire.PrivateTurn.Reply`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.RequestKind`；`NationalSpire.PrivateTurn.Scene`；`NationalSpire.PrivateTurn.Status`；`NationalSpire.PrivateTurn.User`；`NationalSpire.PrivateTurn.UserDeleted`；`NationalSpire.PrivateTurn.UserOrder`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.PrivateChat`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("ee929d")`；返回值紧邻使用处：`ArgumentSyntax: new Color("ee929d")`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateBody.AddChild(ArbitrationCard(data, ruling))`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateBody.AddChild(ArbitrationCard(data, ruling));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateBody.AddChild(PrivateButton("重试这条回复", () => PrivateCommand("dm-retry", new()), 180))`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateBody.AddChild(PrivateButton("重试这条回复", () => PrivateCommand("dm-retry", new()), 180));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateBody.AddChild(PrivateText(turn.Error, 14, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateBody.AddChild(PrivateText(turn.Error, 14, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateBody.AddChild(PrivateText(turn.Error, 15, new Color("ee929d")))`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateBody.AddChild(PrivateText(turn.Error, 15, new Color("ee929d")));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateBody.AddChild(PrivateText(turn.User, 17, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateBody.AddChild(PrivateText(turn.User, 17, CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateBody.AddChild(Text("尖塔仲裁 · " + (turn.Status == "failed" ? "审理中断" : "正在审理"), 20, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateBody.AddChild(Text("尖塔仲裁 · " + (turn.Status == "failed" ? "审理中断" : "正在审理"), 20, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateBody.AddChild(Text($"{GameCalendar.Text(data, turn.Day)}", 12, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateBody.AddChild(Text($"{GameCalendar.Text(data, turn.Day)}", 12, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateHeading!.AddChild(PrivateIdentity(data, _privatePerson, true))`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateHeading!.AddChild(PrivateIdentity(data, _privatePerson, true));`
- `Godot.ScrollContainer.GetVScrollBar()`；输入表达式：`_privateScroll.GetVScrollBar()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _privateScroll.GetVScrollBar().MaxValue`
- `NationalSpire.AiService.PrivateKey(NationalSpire.CareerData, string)`；输入表达式：`AiService.PrivateKey(data, _privatePerson)`；返回值紧邻使用处：`ArgumentSyntax: AiService.PrivateKey(data, _privatePerson)`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, _privatePerson)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(data, _privatePerson)!`
- `NationalSpire.CareerScreen.AddChatReasoning(string, string)`；输入表达式：`AddChatReasoning(turn.Id, reasoning)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AddChatReasoning(turn.Id, reasoning)`
- `NationalSpire.CareerScreen.AddPausedDateScenes(NationalSpire.CareerData, NationalSpire.PrivateConversation)`；输入表达式：`AddPausedDateScenes(data, c)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddPausedDateScenes(data, c);`
- `NationalSpire.CareerScreen.AddPrivateBubble(string, bool, NationalSpire.PrivateTurn)`；输入表达式：`AddPrivateBubble(reply, false, turn)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AddPrivateBubble(reply, false, turn)`
- `NationalSpire.CareerScreen.AddPrivateBubble(string, bool, NationalSpire.PrivateTurn)`；输入表达式：`AddPrivateBubble(turn.User, true, turn)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddPrivateBubble(turn.User, true, turn);`
- `NationalSpire.CareerScreen.AddPrivateLearning(NationalSpire.PrivateTurn, NationalSpire.PrivateLearning)`；输入表达式：`AddPrivateLearning(turn, learning)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddPrivateLearning(turn, learning);`
- `NationalSpire.CareerScreen.AddPrivateMood(NationalSpire.PrivateMood)`；输入表达式：`AddPrivateMood(mood)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddPrivateMood(mood);`
- `NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`AddPrivateOffer(data, offer)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddPrivateOffer(data, offer);`
- `NationalSpire.CareerScreen.AddPrivateProfileChange(NationalSpire.PrivateProfileChange)`；输入表达式：`AddPrivateProfileChange(change)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddPrivateProfileChange(change);`
- `NationalSpire.CareerScreen.ArbitrationCard(NationalSpire.CareerData, NationalSpire.ArbitrationRecord)`；输入表达式：`ArbitrationCard(data, ruling)`；返回值紧邻使用处：`ArgumentSyntax: ArbitrationCard(data, ruling)`
- `NationalSpire.CareerScreen.BindChatPage(bool)`；输入表达式：`BindChatPage(ChatAtBottom && follow)`；返回值紧邻使用处：`ExpressionStatementSyntax: BindChatPage(ChatAtBottom && follow);`
- `NationalSpire.CareerScreen.FinishChatPage(bool)`；输入表达式：`FinishChatPage(bottom && follow)`；返回值紧邻使用处：`ExpressionStatementSyntax: FinishChatPage(bottom && follow);`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("重试这条回复", () => PrivateCommand("dm-retry", new()), 180)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("重试这条回复", () => PrivateCommand("dm-retry", new()), 180)`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；输入表达式：`PrivateCommand("dm-read", new())`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateCommand("dm-read", new());`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；输入表达式：`PrivateCommand("dm-retry", new())`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => PrivateCommand("dm-retry", new())`
- `NationalSpire.CareerScreen.PrivateEmpty(string, string)`；输入表达式：`PrivateEmpty("开始聊天", "消息与邀约会保存在这里。")`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateEmpty("开始聊天", "消息与邀约会保存在这里。");`
- `NationalSpire.CareerScreen.PrivateIdentity(NationalSpire.CareerData, string, bool)`；输入表达式：`PrivateIdentity(data, _privatePerson, true)`；返回值紧邻使用处：`ArgumentSyntax: PrivateIdentity(data, _privatePerson, true)`
- `NationalSpire.CareerScreen.PrivateLineupCard(NationalSpire.CareerData, NationalSpire.CoachLineupRequest, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?)`；输入表达式：`PrivateLineupCard(data, request, _privateBody)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateLineupCard(data, request, _privateBody);`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText(turn.Error, 14, _muted)`；返回值紧邻使用处：`ArgumentSyntax: PrivateText(turn.Error, 14, _muted)`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText(turn.Error, 15, new Color("ee929d"))`；返回值紧邻使用处：`ArgumentSyntax: PrivateText(turn.Error, 15, new Color("ee929d"))`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText(turn.User, 17, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: PrivateText(turn.User, 17, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.RefreshGroupChat()`；输入表达式：`RefreshGroupChat()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshGroupChat();`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("尖塔仲裁 · " + (turn.Status == "failed" ? "审理中断" : "正在审理"), 20, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("尖塔仲裁 · " + (turn.Status == "failed" ? "审理中断" : "正在审理"), 20, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"{GameCalendar.Text(data, turn.Day)}", 12, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"{GameCalendar.Text(data, turn.Day)}", 12, _muted)`
- `NationalSpire.CareerScreen.TrainingCompletions(System.Collections.Generic.IEnumerable<NationalSpire.PrivateOffer>, long, long)`；输入表达式：`TrainingCompletions(c.Offers, _privatePages.Page == 0 ? 0 : visibleTurns.FirstOrDefault()?.UserOrder ?? 0, _privatePages.Next?.UserOrder ?? long.MaxValue)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = TrainingCompletions(c.Offers, _privatePages.Page == 0 ? 0 : visibleTurns.FirstOrDefault()?.UserOrder ?? 0, _privatePages.Next?.UserOrder ?? long.MaxValue)`
- `NationalSpire.CareerScreen.TrainingCompletionsThrough(System.Collections.Generic.Queue<NationalSpire.CoachTrainingPlan>, long)`；输入表达式：`TrainingCompletionsThrough(completions, long.MaxValue)`；返回值紧邻使用处：`ExpressionStatementSyntax: TrainingCompletionsThrough(completions, long.MaxValue);`
- `NationalSpire.CareerScreen.TrainingCompletionsThrough(System.Collections.Generic.Queue<NationalSpire.CoachTrainingPlan>, long)`；输入表达式：`TrainingCompletionsThrough(completions, turn.UserOrder)`；返回值紧邻使用处：`ExpressionStatementSyntax: TrainingCompletionsThrough(completions, turn.UserOrder);`
- `NationalSpire.CareerScreen.UpdatePrivateStream(string, string, bool)`；输入表达式：`UpdatePrivateStream(live, thinking, follow)`；返回值紧邻使用处：`ExpressionStatementSyntax: UpdatePrivateStream(live, thinking, follow);`
- `NationalSpire.CareerTraining.MoodLevel(NationalSpire.CareerPerson, int)`；输入表达式：`CareerTraining.MoodLevel(CareerEngine.Person(data, _privatePerson)!, data.Day)`；返回值紧邻使用处：`BinaryExpressionSyntax: "|" + CareerTraining.MoodLevel(CareerEngine.Person(data, _privatePerson)!, data.Day)`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(_privateBody)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(_privateBody);`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(_privateHeading!)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(_privateHeading!);`
- `NationalSpire.ClubCoaching.TrainingContext(NationalSpire.CareerData, string)`；输入表达式：`ClubCoaching.TrainingContext(data, _privatePerson)`；返回值紧邻使用处：`BinaryExpressionSyntax: "|" + ClubCoaching.TrainingContext(data, _privatePerson)`
- `NationalSpire.CoachLineups.Context(NationalSpire.CareerData, string)`；输入表达式：`CoachLineups.Context(data, _privatePerson)`；返回值紧邻使用处：`BinaryExpressionSyntax: "|" + CoachLineups.Context(data, _privatePerson)`
- `NationalSpire.DateSceneEffects.SourceTurn(NationalSpire.PrivateMailbox, string, string)`；输入表达式：`DateSceneEffects.SourceTurn(PrivateMessages.Mailbox(data), c.PersonId, offer.TurnId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: DateSceneEffects.SourceTurn(PrivateMessages.Mailbox(data), c.PersonId, offer.TurnId) is { Scene: not null, UserDeleted: false, ReplyDeleted: false }`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(data, turn.Day)`；返回值紧邻使用处：`InterpolationSyntax: {GameCalendar.Text(data, turn.Day)}`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new()`；返回值紧邻使用处：`ArgumentSyntax: new()`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, _privatePerson)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(data, _privatePerson)`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`ArgumentSyntax: PrivateMessages.Mailbox(data)`
- `NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Relation(data, _privatePerson)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Relation(data, _privatePerson)`
- `NationalSpire.PrivateMessages.VisibleInCommunications(NationalSpire.PrivateTurn)`；输入表达式：`PrivateMessages.VisibleInCommunications(current)`；返回值紧邻使用处：`BinaryExpressionSyntax: AiService.PrivateReasoningLive.TryGetValue(AiService.PrivateKey(data, _privatePerson), out var thought) && c.Turns.LastOrDefault() is { Status: "sending" } current && PrivateMessages.VisibleInCommunications(current)`
- `NationalSpire.PrivateMessages.VisibleInCommunications(NationalSpire.PrivateTurn)`；输入表达式：`PrivateMessages.VisibleInCommunications(last)`；返回值紧邻使用处：`BinaryExpressionSyntax: AiService.PrivateLive.TryGetValue(AiService.PrivateKey(data, _privatePerson), out var update) && c.Turns.LastOrDefault() is { Status: "sending" } last && PrivateMessages.VisibleInCommunications(last)`
- `NationalSpire.PrivateMessages.VisibleInCommunications(NationalSpire.PrivateTurn)`；输入表达式：`PrivateMessages.VisibleInCommunications(t)`；返回值紧邻使用处：`BinaryExpressionSyntax: t.Id == offer.TurnId && PrivateMessages.VisibleInCommunications(t)`
- `NationalSpire.PrivateMessages.VisibleInCommunications(NationalSpire.PrivateTurn)`；输入表达式：`PrivateMessages.VisibleInCommunications(turn)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PrivateMessages.VisibleInCommunications(turn)`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.PrivateChat, "通讯")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.PrivateChat, "通讯")`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`AiService.PrivateLive.TryGetValue(AiService.PrivateKey(data, _privatePerson), out var update)`；返回值紧邻使用处：`BinaryExpressionSyntax: AiService.PrivateLive.TryGetValue(AiService.PrivateKey(data, _privatePerson), out var update) && c.Turns.LastOrDefault() is { Status: "sending" } last`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`AiService.PrivateReasoningLive.TryGetValue(AiService.PrivateKey(data, _privatePerson), out var thought)`；返回值紧邻使用处：`BinaryExpressionSyntax: AiService.PrivateReasoningLive.TryGetValue(AiService.PrivateKey(data, _privatePerson), out var thought) && c.Turns.LastOrDefault() is { Status: "sending" } current`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.Any(t => t.Status is "queued" or "sending")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Turns.Any(t => t.Status is "queued" or "sending")`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`visibleTurns.Any(t => t.Id == offer.TurnId && PrivateMessages.VisibleInCommunications(t))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !visibleTurns.Any(t => t.Id == offer.TurnId && PrivateMessages.VisibleInCommunications(t))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`visibleTurns.Any(t => t.Id == r.TurnId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !visibleTurns.Any(t => t.Id == r.TurnId)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.Count(t => t.Status == "complete")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Turns.Count(t => t.Status == "complete")`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`visibleTurns.FirstOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: visibleTurns.FirstOrDefault()?.UserOrder`
- `System.Collections.Generic.IEnumerable<TSource>.Last<TSource>()`；输入表达式：`c.Turns.Last()`；返回值紧邻使用处：`BinaryExpressionSyntax: turn == c.Turns.Last()`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`c.Turns.LastOrDefault()`；返回值紧邻使用处：`IsPatternExpressionSyntax: c.Turns.LastOrDefault() is { Status: "sending" } last`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`c.Turns.LastOrDefault()`；返回值紧邻使用处：`IsPatternExpressionSyntax: c.Turns.LastOrDefault() is { Status: "sending" } current`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`c.Turns.LastOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: c.Turns.LastOrDefault()?.Status`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`c.Turns.LastOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: c.Turns.LastOrDefault()?.Reply`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`c.Turns.LastOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: c.Turns.LastOrDefault()?.Error`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`c.DateSceneStates.Select(s => s.Key + ":" + s.Value)`；返回值紧邻使用处：`ArgumentSyntax: c.DateSceneStates.Select(s => s.Key + ":" + s.Value)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`c.Offers.Select(o => o.State)`；返回值紧邻使用处：`ArgumentSyntax: c.Offers.Select(o => o.State)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`_privatePages.Visible.ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _privatePages.Visible.ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Offers.Where(o => o.Kind == "favour" && o.State == "待确认")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var offer in c.Offers.Where(o => o.Kind == "favour" && o.State == "待确认")) if (DateSceneEffects.SourceTurn(PrivateMessages.Mailbox(data), c.PersonId, offer.TurnId) is { Scene: not null, UserDeleted: false, ReplyDeleted: false } && !visibleTurns.Any(t => t.Id == offer.TurnId && PrivateMessages.VisibleInCommunications(t))) AddPrivateOffer(data, offer);`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Offers.Where(o => o.TurnId == turn.Id)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var offer in c.Offers.Where(o => o.TurnId == turn.Id)) AddPrivateOffer(data, offer);`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Esports.LineupRequests.Where(r => r.Coach == _privatePerson && r.ClubId == data.Esports.ClubId && !visibleTurns.Any(t => t.Id == r.TurnId))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var request in data.Esports.LineupRequests.Where(r => r.Coach == _privatePerson && r.ClubId == data.Esports.ClubId && !visibleTurns.Any(t => t.Id == r.TurnId))) PrivateLineupCard(data, request, _privateBody);`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`turn.ProfileChanges.Where(_ => !turn.ReplyDeleted)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var change in turn.ProfileChanges.Where(_ => !turn.ReplyDeleted)) AddPrivateProfileChange(change);`
- `string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；输入表达式：`string.Join(',', c.DateSceneStates.Select(s => s.Key + ":" + s.Value))`；返回值紧邻使用处：`BinaryExpressionSyntax: "|" + string.Join(',', c.DateSceneStates.Select(s => s.Key + ":" + s.Value))`
- `string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；输入表达式：`string.Join(',', c.Offers.Select(o => o.State))`；返回值紧邻使用处：`BinaryExpressionSyntax: data.Day + "|" + c.MemoryRevision + "|" + c.SummaryStatus + c.Turns.Count + "|" + c.Turns.LastOrDefault()?.Status + "|" + c.Turns.LastOrDefault()?.Reply + "|" + c.Turns.LastOrDefault()?.Error + "|" + c.SummaryError + "|" + string.Join(',', c.Offers.Select(o => o.State))`

**赋值（含属性/字段和局部值）：**

- `_privateSend!.Text` = `busy ? "停止生成" : "发送"`
- `_privateSignature` = `signature`
- `_privateStatus!.Text` = `c.SummaryError.Length > 0 ? c.SummaryError : busy ? "正在回复…" : c.SummaryStatus`
- `_privateStatus.Visible` = `_privateStatus.Text.Length > 0`
- `_privateStreamLastText` = `live`
- `_privateStreamLastThought` = `thinking`
- `_privateStreamText` = `_privateStreamThought = null`
- `_privateStreamText` = `updateReply`
- `_privateStreamThought` = `null`
- `_privateStreamThought` = `updateReasoning`
- `signature` += `"|" + CareerTraining.MoodLevel(CareerEngine.Person(data, _privatePerson)!, data.Day)`
- `signature` += `"|" + ClubCoaching.TrainingContext(data, _privatePerson)`
- `signature` += `"|" + CoachLineups.Context(data, _privatePerson)`
- `signature` += `"|" + _privatePages.Page + ":" + _privatePages.Size`
- `signature` += `"|" + string.Join(',', c.DateSceneStates.Select(s => s.Key + ":" + s.Value))`

<a id="symbol-b2deefc4ba01"></a>

## `NationalSpire.CareerScreen.ScrollPrivateToBottom() — private Task ScrollPrivateToBottom()`

来源：源码第 304 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.FinishChatPage(bool)`](ChatHistoryScreen.cs.md#symbol-7519bc2ca961)；[`NationalSpire.CareerScreen.RefreshPrivateAttachments()`](PrivateMemoryScreen.cs.md#symbol-b9d6c2084031)；[`NationalSpire.CareerScreen.UpdateGroupStream(NationalSpire.GroupChat, string, string)`](GroupChatScreen.cs.md#symbol-c33de3d8ae73)；[`NationalSpire.CareerScreen.UpdatePrivateStream(string, string, bool)`](PrivateMessageScreen.cs.md#symbol-45a464c95599)

**调用：** [`NationalSpire.CareerScreen.ScrollChatTo(int)`](ChatHistoryScreen.cs.md#symbol-b728511cec65)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ScrollChatTo(int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.ScrollChatTo(int)`；输入表达式：`ScrollChatTo(int.MaxValue)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => ScrollChatTo(int.MaxValue)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d2aaffe810db"></a>

## `NationalSpire.CareerScreen.FocusPrivateReasoning(string) — private async Task FocusPrivateReasoning(string turn)`

来源：源码第 305 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddChatReasoning(string, string)`](PrivateMemoryScreen.cs.md#symbol-fdbe84837533)

**调用：** `Godot.GodotObject.GetMeta(Godot.StringName, Godot.Variant)`；`Godot.GodotObject.HasMeta(Godot.StringName)`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.ToSignal(Godot.GodotObject, Godot.StringName)`；`Godot.Node.GetChildren(bool)`；`Godot.Node.GetTree()`；`Godot.ScrollContainer.EnsureControlVisible(Godot.Control)`；`Godot.Variant.AsString()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.IEnumerable.OfType<TResult>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._privateBody`；`NationalSpire.CareerScreen._privateOverlay`；`NationalSpire.CareerScreen._privateScroll`；`NationalSpire.CareerScreen._privateScrollRevision`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.GetMeta(Godot.StringName, Godot.Variant)`；输入表达式：`c.GetMeta("reasoning_turn")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.GetMeta("reasoning_turn").AsString`
- `Godot.GodotObject.HasMeta(Godot.StringName)`；输入表达式：`c.HasMeta("reasoning_turn")`；返回值紧邻使用处：`BinaryExpressionSyntax: c.HasMeta("reasoning_turn") && c.GetMeta("reasoning_turn").AsString() == turn`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_privateBody)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(_privateBody)`
- `Godot.GodotObject.ToSignal(Godot.GodotObject, Godot.StringName)`；输入表达式：`ToSignal(GetTree(), SceneTree.SignalName.ProcessFrame)`；返回值紧邻使用处：`AwaitExpressionSyntax: await ToSignal(GetTree(), SceneTree.SignalName.ProcessFrame)`
- `Godot.Node.GetChildren(bool)`；输入表达式：`_privateBody!.GetChildren()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _privateBody!.GetChildren().OfType<Control>`
- `Godot.Node.GetTree()`；输入表达式：`GetTree()`；返回值紧邻使用处：`ArgumentSyntax: GetTree()`
- `Godot.ScrollContainer.EnsureControlVisible(Godot.Control)`；输入表达式：`_privateScroll!.EnsureControlVisible(section)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateScroll!.EnsureControlVisible(section);`
- `Godot.Variant.AsString()`；输入表达式：`c.GetMeta("reasoning_turn").AsString()`；返回值紧邻使用处：`BinaryExpressionSyntax: c.GetMeta("reasoning_turn").AsString() == turn`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`_privateBody!.GetChildren().OfType<Control>().FirstOrDefault(c => c.HasMeta("reasoning_turn") && c.GetMeta("reasoning_turn").AsString() == turn)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _privateBody!.GetChildren().OfType<Control>().FirstOrDefault(c => c.HasMeta("reasoning_turn") && c.GetMeta("reasoning_turn").AsString() == turn)`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`_privateBody!.GetChildren().OfType<Control>()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _privateBody!.GetChildren().OfType<Control>().FirstOrDefault`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b24b4d693d2a"></a>

## `NationalSpire.CareerScreen.AddPrivateBubble(string, bool, NationalSpire.PrivateTurn) — private Action<string> AddPrivateBubble(string text, bool player, PrivateTurn turn)`

来源：源码第 313 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)

**调用：** [`NationalSpire.CareerScreen.PrivateAttachmentCard(NationalSpire.PrivateOffer, bool)`](PrivateMemoryScreen.cs.md#symbol-eb2b2a37c5d1)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.PrivateMessageMenu(NationalSpire.PrivateTurn, bool)`](PrivateMemoryScreen.cs.md#symbol-9a1e5f17a52a)；[`NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-5789f5c9047d)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.CommunityReporting.IsReport(NationalSpire.PrivateTurn)`](CommunityReporting.cs.md#symbol-a1449ae7cb1c)；[`Update(string)`](PrivateMessageScreen.cs.md#symbol-fc2c3ca22db6)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.Control()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`System.Math.Clamp(int, int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._privateBody`；`NationalSpire.CareerScreen.PrivateAttachmentCard(NationalSpire.PrivateOffer, bool)`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.PrivateMessageMenu(NationalSpire.PrivateTurn, bool)`；`NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CommunityReporting.IsReport(NationalSpire.PrivateTurn)`；`NationalSpire.PrivateTurn.Attachments`；`NationalSpire.PrivateTurn.Request`；`Update(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`content.AddThemeConstantOverride("separation", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddThemeConstantOverride("separation", 8);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 8);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`bubble.AddThemeStyleboxOverride("panel", CareerVisuals.Box(player ? "304b60" : "223649", player ? "597f98" : "405c72", 10, 16))`；返回值紧邻使用处：`ExpressionStatementSyntax: bubble.AddThemeStyleboxOverride("panel", CareerVisuals.Box(player ? "304b60" : "223649", player ? "597f98" : "405c72", 10, 16));`
- `Godot.Control.Control()`；输入表达式：`new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(65, 0) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(65, 0) }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, Alignment = player ? BoxContainer.AlignmentMode.End : BoxContainer.AlignmentMode.Begin }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, Alignment = player ? BoxContainer.AlignmentMode.End : BoxContainer.AlignmentMode.Begin }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateBody!.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateBody!.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`bubble.AddChild(content)`；返回值紧邻使用处：`ExpressionStatementSyntax: bubble.AddChild(content);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(message)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(message);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(PrivateAttachmentCard(a, false))`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(PrivateAttachmentCard(a, false));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(PrivateAttachmentCard(turn.Request!, false))`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(PrivateAttachmentCard(turn.Request!, false));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(blank)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(blank);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(bubble)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(bubble);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(more)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(more);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { CustomMinimumSize = new(player && turn.Attachments.Count > 0 ? 640 : Math.Clamp(text.Length * 18 + 40, 200, 680), 0) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { CustomMinimumSize = new(player && turn.Attachments.Count > 0 ? 640 : Math.Clamp(text.Length * 18 + 40, 200, 680), 0) }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(65, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(65, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(player && turn.Attachments.Count > 0 ? 640 : Math.Clamp(text.Length * 18 + 40, 200, 680), 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(player && turn.Attachments.Count > 0 ? 640 : Math.Clamp(text.Length * 18 + 40, 200, 680), 0)`
- `NationalSpire.CareerScreen.PrivateAttachmentCard(NationalSpire.PrivateOffer, bool)`；输入表达式：`PrivateAttachmentCard(a, false)`；返回值紧邻使用处：`ArgumentSyntax: PrivateAttachmentCard(a, false)`
- `NationalSpire.CareerScreen.PrivateAttachmentCard(NationalSpire.PrivateOffer, bool)`；输入表达式：`PrivateAttachmentCard(turn.Request!, false)`；返回值紧邻使用处：`ArgumentSyntax: PrivateAttachmentCard(turn.Request!, false)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("···", () => PrivateMessageMenu(turn, player), 42)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton("···", () => PrivateMessageMenu(turn, player), 42)`
- `NationalSpire.CareerScreen.PrivateMessageMenu(NationalSpire.PrivateTurn, bool)`；输入表达式：`PrivateMessageMenu(turn, player)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => PrivateMessageMenu(turn, player)`
- `NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`；输入表达式：`PrivateSelectableText(text, 19, _ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateSelectableText(text, 19, _ink)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box(player ? "304b60" : "223649", player ? "597f98" : "405c72", 10, 16)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box(player ? "304b60" : "223649", player ? "597f98" : "405c72", 10, 16)`
- `NationalSpire.CommunityReporting.IsReport(NationalSpire.PrivateTurn)`；输入表达式：`CommunityReporting.IsReport(turn)`；返回值紧邻使用处：`BinaryExpressionSyntax: player && CommunityReporting.IsReport(turn)`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(text.Length * 18 + 40, 200, 680)`；返回值紧邻使用处：`ConditionalExpressionSyntax: player && turn.Attachments.Count > 0 ? 640 : Math.Clamp(text.Length * 18 + 40, 200, 680)`
- `Update(string)`；输入表达式：`Update(text)`；返回值紧邻使用处：`ExpressionStatementSyntax: Update(text);`

**赋值（含属性/字段和局部值）：**

- `Alignment` = `player ? BoxContainer.AlignmentMode.End : BoxContainer.AlignmentMode.Begin`
- `CustomMinimumSize` = `new(65, 0)`
- `CustomMinimumSize` = `new(player && turn.Attachments.Count > 0 ? 640 : Math.Clamp(text.Length * 18 + 40, 200, 680), 0)`
- `more.TooltipText` = `player ? "管理消息" : "管理消息与重新生成"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-fc2c3ca22db6"></a>

## `Update(string) — void Update(string value)`

来源：源码第 326 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPrivateBubble(string, bool, NationalSpire.PrivateTurn)`](PrivateMessageScreen.cs.md#symbol-b24b4d693d2a)

**调用：** `Godot.Vector2.Vector2(float, float)`；`System.Math.Clamp(int, int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateTurn.Attachments`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(player && turn.Attachments.Count > 0 ? 640 : Math.Clamp(value.Length * 18 + 40, 200, 680), 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: bubble.CustomMinimumSize = new(player && turn.Attachments.Count > 0 ? 640 : Math.Clamp(value.Length * 18 + 40, 200, 680), 0)`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(value.Length * 18 + 40, 200, 680)`；返回值紧邻使用处：`ConditionalExpressionSyntax: player && turn.Attachments.Count > 0 ? 640 : Math.Clamp(value.Length * 18 + 40, 200, 680)`

**赋值（含属性/字段和局部值）：**

- `bubble.CustomMinimumSize` = `new(player && turn.Attachments.Count > 0 ? 640 : Math.Clamp(value.Length * 18 + 40, 200, 680), 0)`
- `message.Text` = `value`
- `row.Visible` = `value.Length > 0 || player && turn.Attachments.Count > 0`

<a id="symbol-748ab66a7351"></a>

## `NationalSpire.CareerScreen.SendPrivate() — private void SendPrivate()`

来源：源码第 334 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.SendDateScene()`](DateSceneScreen.cs.md#symbol-b811d23c8af3)

**调用：** `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；[`NationalSpire.CareerScreen.LatestChatPage()`](ChatHistoryScreen.cs.md#symbol-566a2e34c9dd)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.RefreshPrivateAttachments()`](PrivateMemoryScreen.cs.md#symbol-b9d6c2084031)；[`NationalSpire.CareerScreen.SceneRequest(bool)`](DateSceneScreen.cs.md#symbol-277baf4e7cb8)；[`NationalSpire.CareerScreen.SendGroup()`](GroupChatScreen.cs.md#symbol-17b4992ac7c2)；[`NationalSpire.ChatComposerPanel.SetExpanded(bool)`](ChatComposerLayout.cs.md#symbol-37f504323d88)；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；`string.IsNullOrWhiteSpace(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.LatestChatPage()`；`NationalSpire.CareerScreen.PrivateAttachments`；`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；`NationalSpire.CareerScreen.RefreshPrivateAttachments()`；`NationalSpire.CareerScreen.SceneRequest(bool)`；`NationalSpire.CareerScreen.SendGroup()`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._dateManualGameInput`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.CareerScreen._privateAttachmentDrafts`；`NationalSpire.CareerScreen._privateComposer`；`NationalSpire.CareerScreen._privateDrafts`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen._privateInput`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.ChatComposerPanel.SetExpanded(bool)`；`NationalSpire.DateSceneView.Editor`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMessageCommand.Attachments`；`NationalSpire.PrivateMessageCommand.Scene`；`NationalSpire.PrivateMessageCommand.Text`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateTurn.Status`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_privateInput)`；返回值紧邻使用处：`BinaryExpressionSyntax: _privatePerson == person && _privateInput != null && IsInstanceValid(_privateInput)`
- `NationalSpire.CareerScreen.LatestChatPage()`；输入表达式：`LatestChatPage()`；返回值紧邻使用处：`ExpressionStatementSyntax: LatestChatPage();`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；输入表达式：`PrivateCommand("dm-send", new() { Text = text, Attachments = attachments, Scene = _dateView == null ? null : SceneRequest() }, () => { if (_dateView != null) _dateManualGameInput = false; if (_privateAttachmentDrafts.TryGetValue(person, out var pending)) pending.RemoveAll(a => attachments.Contains(a)); if (_dateView != null && _datePerson == person && _dateView.Editor.Text == text) _dateView.Editor.Text = ""; if (_privateDrafts.GetValueOrDefault(person) == text) _privateDrafts.Remove(person); if (_privatePerson == person && _privateInput != null && IsInstanceValid(_privateInput)) { if (_privateInput.Text == text) _privateInput.Text = ""; RefreshPrivateAttachments(); LatestChatPage(); } })`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateCommand("dm-send", new() { Text = text, Attachments = attachments, Scene = _dateView == null ? null : SceneRequest() }, () => { if (_dateView != null) _dateManualGameInput = false; if (_privateAttachmentDrafts.TryGetValue(person, out var pending)) pending.RemoveAll(a => attachments.Contains(a)); if (_dateView != null && _datePerson == person && _dateView.Editor.Text == text) _dateView.Editor.Text = ""; if (_privateDrafts.GetValueOrDefault(person) == text) _privateDrafts.Remove(person); if (_privatePerson == person && _privateInput != null && IsInstanceValid(_privateInput)) { if (_privateInput.Text == text) _privateInput.Text = ""; RefreshPrivateAttachments(); LatestChatPage(); } });`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；输入表达式：`PrivateCommand("dm-stop", new())`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateCommand("dm-stop", new());`
- `NationalSpire.CareerScreen.RefreshPrivateAttachments()`；输入表达式：`RefreshPrivateAttachments()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshPrivateAttachments();`
- `NationalSpire.CareerScreen.SceneRequest(bool)`；输入表达式：`SceneRequest()`；返回值紧邻使用处：`ConditionalExpressionSyntax: _dateView == null ? null : SceneRequest()`
- `NationalSpire.CareerScreen.SendGroup()`；输入表达式：`SendGroup()`；返回值紧邻使用处：`ExpressionStatementSyntax: SendGroup();`
- `NationalSpire.ChatComposerPanel.SetExpanded(bool)`；输入表达式：`.SetExpanded(false)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _privateComposer?.SetExpanded(false)`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new()`；返回值紧邻使用处：`ArgumentSyntax: new()`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Text = text, Attachments = attachments, Scene = _dateView == null ? null : SceneRequest() }`；返回值紧邻使用处：`ArgumentSyntax: new() { Text = text, Attachments = attachments, Scene = _dateView == null ? null : SceneRequest() }`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(ViewData, _privatePerson)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(ViewData, _privatePerson)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`_privateDrafts.Remove(person)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateDrafts.Remove(person);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_privateAttachmentDrafts.TryGetValue(person, out var pending)`；返回值紧邻使用处：`IfStatementSyntax: if (_privateAttachmentDrafts.TryGetValue(person, out var pending)) pending.RemoveAll(a => attachments.Contains(a));`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.Any(t => t.Status is "queued" or "sending")`；返回值紧邻使用处：`IfStatementSyntax: if (c.Turns.Any(t => t.Status is "queued" or "sending")) { PrivateCommand("dm-stop", new()); return; }`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`PrivateAttachments.ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateAttachments.ToList()`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`_privateDrafts.GetValueOrDefault(person)`；返回值紧邻使用处：`BinaryExpressionSyntax: _privateDrafts.GetValueOrDefault(person) == text`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`attachments.Contains(a)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: a => attachments.Contains(a)`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`pending.RemoveAll(a => attachments.Contains(a))`；返回值紧邻使用处：`ExpressionStatementSyntax: pending.RemoveAll(a => attachments.Contains(a));`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(text)`；返回值紧邻使用处：`BinaryExpressionSyntax: string.IsNullOrWhiteSpace(text) && PrivateAttachments.Count == 0`

**赋值（含属性/字段和局部值）：**

- `Attachments` = `attachments`
- `Scene` = `_dateView == null ? null : SceneRequest()`
- `Text` = `text`
- `_dateManualGameInput` = `false`
- `_dateView.Editor.Text` = `""`
- `_privateInput.Text` = `""`

<a id="symbol-7d2faf7b7d58"></a>

## `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?) — private void PrivateCommand(string kind, PrivateMessageCommand command, Action? accepted = null, string? target = null, Action<string>? failed = null)`

来源：源码第 353 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddDateSceneAction(NationalSpire.CareerData, NationalSpire.PrivateOffer, Godot.HBoxContainer)`](DateSceneScreen.cs.md#symbol-413adf55a103)；[`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-c7881d245b3d)；[`NationalSpire.CareerScreen.ArbitrationCard(NationalSpire.CareerData, NationalSpire.ArbitrationRecord)`](ArbitrationScreen.cs.md#symbol-8d41f13d5476)；[`NationalSpire.CareerScreen.ConfirmChatRemoval(bool)`](ChatManagementScreen.cs.md#symbol-0e0563dae4b1)；[`NationalSpire.CareerScreen.DatePhone()`](DateGameScreen.cs.md#symbol-91a1fe98cb30)；[`NationalSpire.CareerScreen.DeleteDateDiaryDialog(NationalSpire.CareerData, string, NationalSpire.DateDiary, NationalSpire.DateSceneMemory?)`](DateDiaryScreen.cs.md#symbol-d6865c262849)；[`NationalSpire.CareerScreen.DeleteDateHistoryReply(string, string, string, NationalSpire.DateSceneMemory?, System.Action?)`](DateSceneHistoryScreen.cs.md#symbol-aab4554aa037)；[`NationalSpire.CareerScreen.DeletePrivateMessage(NationalSpire.PrivateTurn, bool)`](PrivateMemoryScreen.cs.md#symbol-fa60614ca4c0)；[`NationalSpire.CareerScreen.EditPrivateMessage(NationalSpire.PrivateTurn, bool)`](PrivateMemoryScreen.cs.md#symbol-fc1c08645b40)；[`NationalSpire.CareerScreen.EditPrivateSummary(NationalSpire.PrivateSummary, string)`](PrivateMemoryScreen.cs.md#symbol-92dafd8c57da)；[`NationalSpire.CareerScreen.InviteDateParticipant(string)`](DateScenePartyScreen.cs.md#symbol-71141f3538db)；[`NationalSpire.CareerScreen.LeaveDateScene(bool)`](DateSceneScreen.cs.md#symbol-942f3afae68b)；[`NationalSpire.CareerScreen.OpenDateScene(string, bool, bool)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)；[`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)；[`NationalSpire.CareerScreen.PrivateArbitrationDialog()`](ArbitrationScreen.cs.md#symbol-63e3d9aaa6df)；[`NationalSpire.CareerScreen.PrivateLineupCard(NationalSpire.CareerData, NationalSpire.CoachLineupRequest, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?)`](CoachScreen.cs.md#symbol-c01675f974f7)；[`NationalSpire.CareerScreen.PrivateMemory()`](PrivateMemoryScreen.cs.md#symbol-942a4a496637)；[`NationalSpire.CareerScreen.PrivateMessageMenu(NationalSpire.PrivateTurn, bool)`](PrivateMemoryScreen.cs.md#symbol-9a1e5f17a52a)；[`NationalSpire.CareerScreen.PrivateSettings()`](PrivateMessageScreen.cs.md#symbol-e86e401f7314)；[`NationalSpire.CareerScreen.PrivateTrainingCard(NationalSpire.CareerData, NationalSpire.CoachTrainingPlan, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?)`](CoachScreen.cs.md#symbol-c2e37e4a0f14)；[`NationalSpire.CareerScreen.ProactiveChatDialog()`](ChatManagementScreen.cs.md#symbol-f9397f5fb6b7)；[`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)；[`NationalSpire.CareerScreen.ReportDiscussion(string, string)`](ArbitrationScreen.cs.md#symbol-4223b2b95c14)；[`NationalSpire.CareerScreen.RestoreChatDialog()`](ChatManagementScreen.cs.md#symbol-812702bacb1e)；[`NationalSpire.CareerScreen.ResumeDateGame()`](DateGameScreen.cs.md#symbol-fa0cab10e943)；[`NationalSpire.CareerScreen.SendDateScene()`](DateSceneScreen.cs.md#symbol-b811d23c8af3)；[`NationalSpire.CareerScreen.SendPrivate()`](PrivateMessageScreen.cs.md#symbol-748ab66a7351)；[`NationalSpire.CareerScreen.ShowDateGameChoices(NationalSpire.CareerMatch)`](DateGameScreen.cs.md#symbol-d1774dd40624)；[`NationalSpire.CareerScreen.StartDateGameReply(NationalSpire.CareerMatch, string)`](DateGameScreen.cs.md#symbol-8963173330c9)；[`Section(string)`](PrivateMemoryScreen.cs.md#symbol-3776534c6c5a)

**调用：** [`Fail(string)`](PrivateMessageScreen.cs.md#symbol-681bb0cabd9b)；[`NationalSpire.AiService.FailureReason(System.Exception)`](AiService.cs.md#symbol-a50bcbf6dda5)；[`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`](AiDiscussion.cs.md#symbol-63a666dde156)；[`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`](AiPrivateMessages.cs.md#symbol-935c714481c1)；[`NationalSpire.AiService.SummarizePrivateManually(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string)`](AiPrivateMessages.cs.md#symbol-88f72cb1c19e)；[`NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`](AiSettingsStore.cs.md#symbol-b37e55b3af97)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`](CareerStore.cs.md#symbol-ead7461ee7cb)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.ICareerSession.Refresh()`](CareerSession.cs.md#symbol-bae3aaaf496d)；[`NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-e21b0ff1d18b)；[`NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-81ef5fba41b8)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`System.Action.Invoke()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `Fail(string)`；`NationalSpire.AiOptions.ChatTools`；`NationalSpire.AiService.FailureReason(System.Exception)`；`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`；`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`；`NationalSpire.AiService.SummarizePrivateManually(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string)`；`NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；`NationalSpire.ArbitrationRecord.Id`；`NationalSpire.ArbitrationRecord.PostId`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.Arbitrations`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._privateListSignature`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen._privateSignature`；`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.ICareerSession.Refresh()`；`NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?)`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateMessageCommand.Entry`；`NationalSpire.PrivateMessageCommand.Offer`；`NationalSpire.PrivateMessageCommand.ToolMode`；`NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.MatchId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Fail(string)`；输入表达式：`Fail(AiService.FailureReason(e))`；返回值紧邻使用处：`ExpressionStatementSyntax: Fail(AiService.FailureReason(e));`
- `Fail(string)`；输入表达式：`Fail(error)`；返回值紧邻使用处：`ExpressionStatementSyntax: Fail(error);`
- `NationalSpire.AiService.FailureReason(System.Exception)`；输入表达式：`AiService.FailureReason(e)`；返回值紧邻使用处：`ArgumentSyntax: AiService.FailureReason(e)`
- `NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`；输入表达式：`AiService.ProcessInteractionsAsync([published.MatchId], data)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AiService.ProcessInteractionsAsync([published.MatchId], data)`
- `NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`；输入表达式：`AiService.ProcessInteractionsAsync([ruling.PostId], data)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AiService.ProcessInteractionsAsync([ruling.PostId], data)`
- `NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`；输入表达式：`AiService.ProcessPrivateAsync(() => CareerStore.IsCurrent(data) ? data : null, CareerStore.Save, person)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AiService.ProcessPrivateAsync(() => CareerStore.IsCurrent(data) ? data : null, CareerStore.Save, person)`
- `NationalSpire.AiService.SummarizePrivateManually(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string)`；输入表达式：`AiService.SummarizePrivateManually(() => CareerStore.IsCurrent(data) ? data : null, CareerStore.Save, person)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AiService.SummarizePrivateManually(() => CareerStore.IsCurrent(data) ? data : null, CareerStore.Save, person)`
- `NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；输入表达式：`AiSettingsStore.Load(ViewData.Ai)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AiSettingsStore.Load(ViewData.Ai).ChatTools`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, person)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(data, person)!`
- `NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；输入表达式：`CareerStore.IsCurrent(data)`；返回值紧邻使用处：`ConditionalExpressionSyntax: CareerStore.IsCurrent(data) ? data : null`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(data);`
- `NationalSpire.ICareerSession.Refresh()`；输入表达式：`_multiplayer.Refresh()`；返回值紧邻使用处：`ExpressionStatementSyntax: _multiplayer.Refresh();`
- `NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?)`；输入表达式：`_multiplayer.Send(kind, person, JsonSerializer.Serialize(command), accepted: () => { accepted?.Invoke(); _multiplayer.Refresh(); _privateListSignature = _privateSignature = ""; })`；返回值紧邻使用处：`ExpressionStatementSyntax: _multiplayer.Send(kind, person, JsonSerializer.Serialize(command), accepted: () => { accepted?.Invoke(); _multiplayer.Refresh(); _privateListSignature = _privateSignature = ""; });`
- `NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`；输入表达式：`PrivateMessageCommands.Apply(data, kind, person, command)`；返回值紧邻使用处：`IsPatternExpressionSyntax: PrivateMessageCommands.Apply(data, kind, person, command) is { } error`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, person)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Conversation(data, person).Offers`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: accepted?.Invoke()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`CareerEngine.Person(data, person)!.Arbitrations.FirstOrDefault(r => r.Id == command.Entry)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerEngine.Person(data, person)!.Arbitrations.FirstOrDefault(r => r.Id == command.Entry) is { PostId.Length: > 0 } ruling`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateMessages.Conversation(data, person).Offers.FirstOrDefault(o => o.Id == command.Offer)`；返回值紧邻使用处：`IsPatternExpressionSyntax: PrivateMessages.Conversation(data, person).Offers.FirstOrDefault(o => o.Id == command.Offer) is { Kind: "publish" } published`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(command)`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.Serialize(command)`

**赋值（含属性/字段和局部值）：**

- `_` = `AiService.ProcessInteractionsAsync([published.MatchId], data)`
- `_` = `AiService.ProcessInteractionsAsync([ruling.PostId], data)`
- `_` = `AiService.ProcessPrivateAsync(() => CareerStore.IsCurrent(data) ? data : null, CareerStore.Save, person)`
- `_` = `AiService.SummarizePrivateManually(() => CareerStore.IsCurrent(data) ? data : null, CareerStore.Save, person)`
- `_privateListSignature` = `_privateSignature = ""`
- `_privateSignature` = `""`
- `command.ToolMode` = `AiSettingsStore.Load(ViewData.Ai).ChatTools`

<a id="symbol-681bb0cabd9b"></a>

## `Fail(string) — void Fail(string message)`

来源：源码第 357 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)

**调用：** [`NationalSpire.CareerScreen.ShowPrivateCommandError(string)`](PrivateMessageScreen.cs.md#symbol-b6171f4aaa2c)；`System.Action<T>.Invoke(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ShowPrivateCommandError(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.ShowPrivateCommandError(string)`；输入表达式：`ShowPrivateCommandError(message)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowPrivateCommandError(message);`
- `System.Action<T>.Invoke(T)`；输入表达式：`failed(message)`；返回值紧邻使用处：`ExpressionStatementSyntax: failed(message);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b6171f4aaa2c"></a>

## `NationalSpire.CareerScreen.ShowPrivateCommandError(string) — private void ShowPrivateCommandError(string error)`

来源：源码第 383 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Fail(string)`](PrivateMessageScreen.cs.md#symbol-681bb0cabd9b)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)

**调用：** `Godot.CanvasItem.Show()`；`Godot.Node.FindChild(string, bool, bool)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._dateView`；`NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.CareerScreen._privateStatus`；`NationalSpire.DateSceneView.Status`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Show()`；输入表达式：`_privateStatus.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateStatus.Show();`
- `Godot.CanvasItem.Show()`；输入表达式：`reason.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: reason.Show();`
- `Godot.Node.FindChild(string, bool, bool)`；输入表达式：`.FindChild("DateAttendanceError", true, false)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _dialogOverlay?.FindChild("DateAttendanceError", true, false)`

**赋值（含属性/字段和局部值）：**

- `_dateView.Status.Text` = `error`
- `_privateStatus.Text` = `error`
- `reason.Text` = `error`

<a id="symbol-e86e401f7314"></a>

## `NationalSpire.CareerScreen.PrivateSettings() — private void PrivateSettings()`

来源：源码第 390 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`Field(string, int, int, int)`](PrivateMessageScreen.cs.md#symbol-8b106e87b359)；`Godot.Color.Color(string)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；[`NationalSpire.CareerScreen.GroupSettings()`](GroupChatDialogs.cs.md#symbol-a263539cc71f)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`NationalSpire.PrivateHistorySettings.PrivateHistorySettings()`；[`NationalSpire.PrivateHistorySettings.Validate()`](PrivateMessageData.cs.md#symbol-2608e8077b19)；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)

**字段、属性、事件及方法组引用：** `Field(string, int, int, int)`；`NationalSpire.CareerScreen.GroupSettings()`；`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.PrivateHistorySettings.MaximumRounds`；`NationalSpire.PrivateHistorySettings.MergeOldest`；`NationalSpire.PrivateHistorySettings.RecentRounds`；`NationalSpire.PrivateHistorySettings.SmallSummaryLimit`；`NationalSpire.PrivateHistorySettings.Validate()`；`NationalSpire.PrivateMailbox.Settings`；`NationalSpire.PrivateMessageCommand.Settings`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Field(string, int, int, int)`；输入表达式：`Field("总结后保留此前轮数", current.RecentRounds, 0, 499)`；返回值紧邻使用处：`AssignmentExpressionSyntax: recent = Field("总结后保留此前轮数", current.RecentRounds, 0, 499)`
- `Field(string, int, int, int)`；输入表达式：`Field("每次合并最旧的几条摘要", current.MergeOldest, 2, 100)`；返回值紧邻使用处：`AssignmentExpressionSyntax: merge = Field("每次合并最旧的几条摘要", current.MergeOldest, 2, 100)`
- `Field(string, int, int, int)`；输入表达式：`Field("聊天摘要达到多少条时合并", current.SmallSummaryLimit, 2, 100)`；返回值紧邻使用处：`AssignmentExpressionSyntax: limit = Field("聊天摘要达到多少条时合并", current.SmallSummaryLimit, 2, 100)`
- `Field(string, int, int, int)`；输入表达式：`Field("超过多少轮开始总结", current.MaximumRounds, 5, 500)`；返回值紧邻使用处：`AssignmentExpressionSyntax: maximum = Field("超过多少轮开始总结", current.MaximumRounds, 5, 500)`
- `Godot.Color.Color(string)`；输入表达式：`new Color("ee929d")`；返回值紧邻使用处：`ArgumentSyntax: new Color("ee929d")`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text("保留轮数另加当前一轮。提示词在模组设置中修改。", 14, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text("保留轮数另加当前一轮。提示词在模组设置中修改。", 14, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(error)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(error);`
- `NationalSpire.CareerScreen.GroupSettings()`；输入表达式：`GroupSettings()`；返回值紧邻使用处：`ExpressionStatementSyntax: GroupSettings();`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；输入表达式：`PrivateCommand("dm-settings", new() { Settings = settings })`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateCommand("dm-settings", new() { Settings = settings });`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("聊天记录", "总结在后台进行，聊天可以继续。原始记录完整保留。", () => { var settings = new PrivateHistorySettings { MaximumRounds = (int)maximum!.Value, RecentRounds = (int)recent!.Value, SmallSummaryLimit = (int)limit!.Value, MergeOldest = (int)merge!.Value }; try { settings.Validate(); PrivateCommand("dm-settings", new() { Settings = settings }); return true; } catch (Exception e) { error!.Text = e.Message; return false; } }, "保存", box => { SpinBox Field(string label, int value, int min, int max) { var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 30); box.AddChild(row); row.AddChild(Text(label, 17, _ink)); var input = new SpinBox { MinValue = min, MaxValue = max, Value = value, CustomMinimumSize = new(160, 45) }; row.AddChild(input); return input; } maximum = Field("超过多少轮开始总结", current.MaximumRounds, 5, 500); recent = Field("总结后保留此前轮数", current.RecentRounds, 0, 499); limit = Field("聊天摘要达到多少条时合并", current.SmallSummaryLimit, 2, 100); merge = Field("每次合并最旧的几条摘要", current.MergeOldest, 2, 100); box.AddChild(Text("保留轮数另加当前一轮。提示词在模组设置中修改。", 14, _muted)); error = Text("", 15, new Color("ee929d")); box.AddChild(error); })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("聊天记录", "总结在后台进行，聊天可以继续。原始记录完整保留。", () => { var settings = new PrivateHistorySettings { MaximumRounds = (int)maximum!.Value, RecentRounds = (int)recent!.Value, SmallSummaryLimit = (int)limit!.Value, MergeOldest = (int)merge!.Value }; try { settings.Validate(); PrivateCommand("dm-settings", new() { Settings = settings }); return true; } catch (Exception e) { error!.Text = e.Message; return false; } }, "保存", box => { SpinBox Field(string label, int value, int min, int max) { var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 30); box.AddChild(row); row.AddChild(Text(label, 17, _ink)); var input = new SpinBox { MinValue = min, MaxValue = max, Value = value, CustomMinimumSize = new(160, 45) }; row.AddChild(input); return input; } maximum = Field("超过多少轮开始总结", current.MaximumRounds, 5, 500); recent = Field("总结后保留此前轮数", current.RecentRounds, 0, 499); limit = Field("聊天摘要达到多少条时合并", current.SmallSummaryLimit, 2, 100); merge = Field("每次合并最旧的几条摘要", current.MergeOldest, 2, 100); box.AddChild(Text("保留轮数另加当前一轮。提示词在模组设置中修改。", 14, _muted)); error = Text("", 15, new Color("ee929d")); box.AddChild(error); });`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 15, new Color("ee929d"))`；返回值紧邻使用处：`AssignmentExpressionSyntax: error = Text("", 15, new Color("ee929d"))`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("保留轮数另加当前一轮。提示词在模组设置中修改。", 14, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("保留轮数另加当前一轮。提示词在模组设置中修改。", 14, _muted)`
- `NationalSpire.PrivateHistorySettings.PrivateHistorySettings()`；输入表达式：`new PrivateHistorySettings { MaximumRounds = (int)maximum!.Value, RecentRounds = (int)recent!.Value, SmallSummaryLimit = (int)limit!.Value, MergeOldest = (int)merge!.Value }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PrivateHistorySettings { MaximumRounds = (int)maximum!.Value, RecentRounds = (int)recent!.Value, SmallSummaryLimit = (int)limit!.Value, MergeOldest = (int)merge!.Value }`
- `NationalSpire.PrivateHistorySettings.Validate()`；输入表达式：`settings.Validate()`；返回值紧邻使用处：`ExpressionStatementSyntax: settings.Validate();`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Settings = settings }`；返回值紧邻使用处：`ArgumentSyntax: new() { Settings = settings }`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(ViewData)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(ViewData).Settings`

**赋值（含属性/字段和局部值）：**

- `MaximumRounds` = `(int)maximum!.Value`
- `MergeOldest` = `(int)merge!.Value`
- `RecentRounds` = `(int)recent!.Value`
- `Settings` = `settings`
- `SmallSummaryLimit` = `(int)limit!.Value`
- `error!.Text` = `e.Message`
- `error` = `Text("", 15, new Color("ee929d"))`
- `limit` = `Field("聊天摘要达到多少条时合并", current.SmallSummaryLimit, 2, 100)`
- `maximum` = `Field("超过多少轮开始总结", current.MaximumRounds, 5, 500)`
- `merge` = `Field("每次合并最旧的几条摘要", current.MergeOldest, 2, 100)`
- `recent` = `Field("总结后保留此前轮数", current.RecentRounds, 0, 499)`

<a id="symbol-8b106e87b359"></a>

## `Field(string, int, int, int) — SpinBox Field(string label, int value, int min, int max)`

来源：源码第 401 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateSettings()`](PrivateMessageScreen.cs.md#symbol-e86e401f7314)

**调用：** [`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.SpinBox.SpinBox()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 30)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 30);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(input)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(input);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(Text(label, 17, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(Text(label, 17, _ink));`
- `Godot.SpinBox.SpinBox()`；输入表达式：`new SpinBox { MinValue = min, MaxValue = max, Value = value, CustomMinimumSize = new(160, 45) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new SpinBox { MinValue = min, MaxValue = max, Value = value, CustomMinimumSize = new(160, 45) }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(160, 45)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(160, 45)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(label, 17, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(label, 17, _ink)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(160, 45)`
- `MaxValue` = `max`
- `MinValue` = `min`
- `Value` = `value`

<a id="symbol-aefc38a1fba3"></a>

## `NationalSpire.CareerScreen.PreviewPrivatePrompt() — private void PreviewPrivatePrompt()`

来源：源码第 414 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`](AiSettingsStore.cs.md#symbol-b37e55b3af97)；[`NationalSpire.CareerScreen.PreviewGroupPrompt()`](GroupChatDialogs.cs.md#symbol-b6bc7a2d0206)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.ChatTools.Create(NationalSpire.CareerData, NationalSpire.PrivateConversation?, NationalSpire.PrivateTurn?, NationalSpire.GroupChat?)`](ChatTools.cs.md#symbol-da501aed0ab9)；[`NationalSpire.ChatTools.Enabled(NationalSpire.AiOptions, bool?)`](ChatTools.cs.md#symbol-ad4027d40944)；[`NationalSpire.PrivateMessagePrompts.Compose(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn?, string?, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-de94bbbea5ea)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.DisplayServer.ClipboardSet(string)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.TextEdit.TextEdit()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.PrivateTurn.PrivateTurn()`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.List<T>.Add(T)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；`System.Text.Json.JsonSerializerOptions.JsonSerializerOptions()`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.ChatTools`；`NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen._privateInput`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen.PreviewGroupPrompt()`；`NationalSpire.CareerScreen.PrivateAttachments`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.ChatToolRequest.Definitions`；`NationalSpire.ChatTools.Create(NationalSpire.CareerData, NationalSpire.PrivateConversation?, NationalSpire.PrivateTurn?, NationalSpire.GroupChat?)`；`NationalSpire.ChatTools.Enabled(NationalSpire.AiOptions, bool?)`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMessagePrompts.Compose(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn?, string?, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateTurn.Attachments`；`NationalSpire.PrivateTurn.Day`；`NationalSpire.PrivateTurn.Season`；`NationalSpire.PrivateTurn.Status`；`NationalSpire.PrivateTurn.ToolMode`；`NationalSpire.PrivateTurn.User`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`edit.AddThemeFontSizeOverride("font_size", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: edit.AddThemeFontSizeOverride("font_size", 16);`
- `Godot.DisplayServer.ClipboardSet(string)`；输入表达式：`DisplayServer.ClipboardSet(preview)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => DisplayServer.ClipboardSet(preview)`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(edit)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(edit);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(PrivateButton("复制完整提示词", () => DisplayServer.ClipboardSet(preview), 200))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(PrivateButton("复制完整提示词", () => DisplayServer.ClipboardSet(preview), 200));`
- `Godot.TextEdit.TextEdit()`；输入表达式：`new TextEdit { Text = preview, Editable = false, CustomMinimumSize = new(950, 580), WrapMode = TextEdit.LineWrappingMode.Boundary }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TextEdit { Text = preview, Editable = false, CustomMinimumSize = new(950, 580), WrapMode = TextEdit.LineWrappingMode.Boundary }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(950, 580)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(950, 580)`
- `NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；输入表达式：`AiSettingsStore.Load(d.Ai)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AiSettingsStore.Load(d.Ai).ChatTools`
- `NationalSpire.CareerScreen.PreviewGroupPrompt()`；输入表达式：`PreviewGroupPrompt()`；返回值紧邻使用处：`ExpressionStatementSyntax: PreviewGroupPrompt();`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("复制完整提示词", () => DisplayServer.ClipboardSet(preview), 200)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("复制完整提示词", () => DisplayServer.ClipboardSet(preview), 200)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("私信提示词预览", "当前草稿与实际上下文。交互格式由模组管理。", () => true, "关闭", box =>          {              var edit = new TextEdit { Text = preview, Editable = false, CustomMinimumSize = new(950, 580), WrapMode = TextEdit.LineWrappingMode.Boundary }; edit.AddThemeFontSizeOverride("font_size", 16); box.AddChild(edit);              box.AddChild(PrivateButton("复制完整提示词", () => DisplayServer.ClipboardSet(preview), 200));          }, showCancel: false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("私信提示词预览", "当前草稿与实际上下文。交互格式由模组管理。", () => true, "关闭", box =>          {              var edit = new TextEdit { Text = preview, Editable = false, CustomMinimumSize = new(950, 580), WrapMode = TextEdit.LineWrappingMode.Boundary }; edit.AddThemeFontSizeOverride("font_size", 16); box.AddChild(edit);              box.AddChild(PrivateButton("复制完整提示词", () => DisplayServer.ClipboardSet(preview), 200));          }, showCancel: false);`
- `NationalSpire.ChatTools.Create(NationalSpire.CareerData, NationalSpire.PrivateConversation?, NationalSpire.PrivateTurn?, NationalSpire.GroupChat?)`；输入表达式：`ChatTools.Create(d, copy, pending)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ChatTools.Create(d, copy, pending).Definitions`
- `NationalSpire.ChatTools.Enabled(NationalSpire.AiOptions, bool?)`；输入表达式：`ChatTools.Enabled(d.Ai, pending.ToolMode)`；返回值紧邻使用处：`IfStatementSyntax: if (ChatTools.Enabled(d.Ai, pending.ToolMode)) preview += "\n\ntools\n" + JsonSerializer.Serialize(ChatTools.Create(d, copy, pending).Definitions, new JsonSerializerOptions { WriteIndented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping });`
- `NationalSpire.PrivateMessagePrompts.Compose(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn?, string?, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`；输入表达式：`PrivateMessagePrompts.Compose(d, copy, pending)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessagePrompts.Compose(d, copy, pending).Select`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(d, _privatePerson)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(d, _privatePerson)`
- `NationalSpire.PrivateTurn.PrivateTurn()`；输入表达式：`new() { ToolMode = AiSettingsStore.Load(d.Ai).ChatTools, Day = d.Day, Season = d.Season, User = _privateInput?.Text ?? "", Attachments = PrivateAttachments.ToList() }`；返回值紧邻使用处：`AssignmentExpressionSyntax: pending = new() { ToolMode = AiSettingsStore.Load(d.Ai).ChatTools, Day = d.Day, Season = d.Season, User = _privateInput?.Text ?? "", Attachments = PrivateAttachments.ToList() }`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n\n────────────────\n\n", PrivateMessagePrompts.Compose(d, copy, pending).Select(m => m["role"] + "\n" + m["content"]))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = string.Join("\n\n────────────────\n\n", PrivateMessagePrompts.Compose(d, copy, pending).Select(m => m["role"] + "\n" + m["content"]))`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`copy.Turns.LastOrDefault(t => t.Status is "queued" or "sending")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = copy.Turns.LastOrDefault(t => t.Status is "queued" or "sending")`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`PrivateMessagePrompts.Compose(d, copy, pending).Select(m => m["role"] + "\n" + m["content"])`；返回值紧邻使用处：`ArgumentSyntax: PrivateMessagePrompts.Compose(d, copy, pending).Select(m => m["role"] + "\n" + m["content"])`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`PrivateAttachments.ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Attachments = PrivateAttachments.ToList()`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`copy.Turns.Add(pending)`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.Turns.Add(pending);`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<PrivateConversation>(JsonSerializer.Serialize(c))`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: JsonSerializer.Deserialize<PrivateConversation>(JsonSerializer.Serialize(c))!`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(c)`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.Serialize(c)`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(ChatTools.Create(d, copy, pending).Definitions, new JsonSerializerOptions { WriteIndented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping })`；返回值紧邻使用处：`BinaryExpressionSyntax: "\n\ntools\n" + JsonSerializer.Serialize(ChatTools.Create(d, copy, pending).Definitions, new JsonSerializerOptions { WriteIndented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping })`
- `System.Text.Json.JsonSerializerOptions.JsonSerializerOptions()`；输入表达式：`new JsonSerializerOptions { WriteIndented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping }`；返回值紧邻使用处：`ArgumentSyntax: new JsonSerializerOptions { WriteIndented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping }`

**赋值（含属性/字段和局部值）：**

- `Attachments` = `PrivateAttachments.ToList()`
- `CustomMinimumSize` = `new(950, 580)`
- `Day` = `d.Day`
- `Editable` = `false`
- `Encoder` = `System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping`
- `pending` = `new() { ToolMode = AiSettingsStore.Load(d.Ai).ChatTools, Day = d.Day, Season = d.Season, User = _privateInput?.Text ?? "", Attachments = PrivateAttachments.ToList() }`
- `preview` += `"\n\ntools\n" + JsonSerializer.Serialize(ChatTools.Create(d, copy, pending).Definitions, new JsonSerializerOptions { WriteIndented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping })`
- `Season` = `d.Season`
- `Text` = `preview`
- `ToolMode` = `AiSettingsStore.Load(d.Ai).ChatTools`
- `User` = `_privateInput?.Text ?? ""`
- `WrapMode` = `TextEdit.LineWrappingMode.Boundary`
- `WriteIndented` = `true`

<a id="symbol-6e8c11ead905"></a>

## `NationalSpire.CareerScreen.PrivateActions() — private void PrivateActions()`

来源：源码第 431 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenDateScene(string, bool, bool)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)；[`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)

**调用：** [`Choice(string, string, System.Action)`](PrivateMessageScreen.cs.md#symbol-9ea0661130d0)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`](PrivateMemoryScreen.cs.md#symbol-053a2c0af91b)；[`NationalSpire.CareerScreen.GroupActions()`](GroupChatDialogs.cs.md#symbol-38cd67d996b6)；[`NationalSpire.CareerScreen.PrivateSharePicker(string)`](PrivateMemoryScreen.cs.md#symbol-b8d901a6cb80)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.ClubCoaching.PlayerCoach(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-26fb5cc468c4)；[`NationalSpire.CoachLineups.CanRequest(NationalSpire.CareerData, string)`](CoachLineups.cs.md#symbol-7ddb21934c39)；[`NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-871ad0e2a2c9)；[`NationalSpire.OwnedClubs.IsRecruitable(NationalSpire.CareerPerson)`](OwnedClubs.cs.md#symbol-11345d1ef285)；[`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-8a6bb6e78fa5)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.GridContainer.GridContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`NationalSpire.PrivateOffer.PrivateOffer()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `Choice(string, string, System.Action)`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`；`NationalSpire.CareerScreen.GroupActions()`；`NationalSpire.CareerScreen.PrivateActivityPicker()`；`NationalSpire.CareerScreen.PrivateArbitrationDialog()`；`NationalSpire.CareerScreen.PrivateGiftPicker()`；`NationalSpire.CareerScreen.PrivateLineupPicker()`；`NationalSpire.CareerScreen.PrivateMatchPicker()`；`NationalSpire.CareerScreen.PrivateOathAttachment()`；`NationalSpire.CareerScreen.PrivateSharePicker(string)`；`NationalSpire.CareerScreen.PrivateTrainingPicker()`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.ClubCoaching.PlayerCoach(NationalSpire.CareerData)`；`NationalSpire.CoachLineups.CanRequest(NationalSpire.CareerData, string)`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.IsRecruitable(NationalSpire.CareerPerson)`；`NationalSpire.OwnedClubState.Contracts`；`NationalSpire.OwnedPlayerContract.PersonId`；`NationalSpire.OwnedPlayerContract.Position`；`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateRelation.OathConfirmed`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Choice(string, string, System.Action)`；输入表达式：`Choice("调整阵容", "商谈下赛季席位", PrivateLineupPicker)`；返回值紧邻使用处：`ExpressionStatementSyntax: Choice("调整阵容", "商谈下赛季席位", PrivateLineupPicker);`
- `Choice(string, string, System.Action)`；输入表达式：`Choice("分享帖子", "选择一篇社区讨论", () => PrivateSharePicker("post"))`；返回值紧邻使用处：`ExpressionStatementSyntax: Choice("分享帖子", "选择一篇社区讨论", () => PrivateSharePicker("post"));`
- `Choice(string, string, System.Action)`；输入表达式：`Choice("复盘比赛", "附上真实比赛记录", () => PrivateSharePicker("result"))`；返回值紧邻使用处：`ExpressionStatementSyntax: Choice("复盘比赛", "附上真实比赛记录", () => PrivateSharePicker("result"));`
- `Choice(string, string, System.Action)`；输入表达式：`Choice("尖塔仲裁", "申请官方审理与裁决", PrivateArbitrationDialog)`；返回值紧邻使用处：`ExpressionStatementSyntax: Choice("尖塔仲裁", "申请官方审理与裁决", PrivateArbitrationDialog);`
- `Choice(string, string, System.Action)`；输入表达式：`Choice("解除誓约", "向对方提出解除请求", PrivateOathAttachment)`；返回值紧邻使用处：`ExpressionStatementSyntax: Choice("解除誓约", "向对方提出解除请求", PrivateOathAttachment);`
- `Choice(string, string, System.Action)`；输入表达式：`Choice("商谈合同", "邀请对方提出条件", () => AttachPrivate(new() { Kind = "contract" }))`；返回值紧邻使用处：`ExpressionStatementSyntax: Choice("商谈合同", "邀请对方提出条件", () => AttachPrivate(new() { Kind = "contract" }));`
- `Choice(string, string, System.Action)`；输入表达式：`Choice("约定活动", "选择内容与日期", PrivateActivityPicker)`；返回值紧邻使用处：`ExpressionStatementSyntax: Choice("约定活动", "选择内容与日期", PrivateActivityPicker);`
- `Choice(string, string, System.Action)`；输入表达式：`Choice("约一局", "选择日期与进阶", PrivateMatchPicker)`；返回值紧邻使用处：`ExpressionStatementSyntax: Choice("约一局", "选择日期与进阶", PrivateMatchPicker);`
- `Choice(string, string, System.Action)`；输入表达式：`Choice("赠送礼物", "选择物品与数量", PrivateGiftPicker)`；返回值紧邻使用处：`ExpressionStatementSyntax: Choice("赠送礼物", "选择物品与数量", PrivateGiftPicker);`
- `Choice(string, string, System.Action)`；输入表达式：`Choice("制定训练计划", "填写内容与训练周期", PrivateTrainingPicker)`；返回值紧邻使用处：`ExpressionStatementSyntax: Choice("制定训练计划", "填写内容与训练周期", PrivateTrainingPicker);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("h_separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("h_separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("v_separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("v_separation", 16);`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer { Columns = 2 }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GridContainer { Columns = 2 }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(grid)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(grid);`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(ViewData, _privatePerson)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.Person(ViewData, _privatePerson)`
- `NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`；输入表达式：`AttachPrivate(new() { Kind = "contract" })`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => AttachPrivate(new() { Kind = "contract" })`
- `NationalSpire.CareerScreen.GroupActions()`；输入表达式：`GroupActions()`；返回值紧邻使用处：`ExpressionStatementSyntax: GroupActions();`
- `NationalSpire.CareerScreen.PrivateSharePicker(string)`；输入表达式：`PrivateSharePicker("post")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => PrivateSharePicker("post")`
- `NationalSpire.CareerScreen.PrivateSharePicker(string)`；输入表达式：`PrivateSharePicker("result")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => PrivateSharePicker("result")`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("添加到消息", "选好后可以继续输入，发送时一并附上。", () => true, "关闭", box =>          {              var grid = new GridContainer { Columns = 2 }; grid.AddThemeConstantOverride("h_separation", 16); grid.AddThemeConstantOverride("v_separation", 16); box.AddChild(grid);              void Choice(string title, string detail, Action action) { var b = PrivateButton(title + "\n" + detail, () => { _cancelDialog?.Invoke(); action(); }, 300); b.CustomMinimumSize = new(300, 86); grid.AddChild(b); }              if (ClubCoaching.PlayerCoach(ViewData) && ViewData.Esports.OwnedClub!.Contracts.Any(c => c.PersonId == _privatePerson && c.Position != "教练"))                  Choice("制定训练计划", "填写内容与训练周期", PrivateTrainingPicker);              if (CoachLineups.CanRequest(ViewData, _privatePerson)) Choice("调整阵容", "商谈下赛季席位", PrivateLineupPicker);              Choice("约一局", "选择日期与进阶", PrivateMatchPicker);              Choice("赠送礼物", "选择物品与数量", PrivateGiftPicker);              if (PrivateMessages.Relation(ViewData, _privatePerson).OathConfirmed) Choice("解除誓约", "向对方提出解除请求", PrivateOathAttachment);              Choice("约定活动", "选择内容与日期", PrivateActivityPicker);              Choice("复盘比赛", "附上真实比赛记录", () => PrivateSharePicker("result"));              Choice("尖塔仲裁", "申请官方审理与裁决", PrivateArbitrationDialog);              Choice("分享帖子", "选择一篇社区讨论", () => PrivateSharePicker("post"));              var target = CareerEngine.Person(ViewData, _privatePerson);              if (OwnedClubs.CanOperate(ViewData) && target != null && target.ClubId != ViewData.Esports.ClubId && OwnedClubs.IsRecruitable(target))                  Choice("商谈合同", "邀请对方提出条件", () => AttachPrivate(new() { Kind = "contract" }));          }, showCancel: false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("添加到消息", "选好后可以继续输入，发送时一并附上。", () => true, "关闭", box =>          {              var grid = new GridContainer { Columns = 2 }; grid.AddThemeConstantOverride("h_separation", 16); grid.AddThemeConstantOverride("v_separation", 16); box.AddChild(grid);              void Choice(string title, string detail, Action action) { var b = PrivateButton(title + "\n" + detail, () => { _cancelDialog?.Invoke(); action(); }, 300); b.CustomMinimumSize = new(300, 86); grid.AddChild(b); }              if (ClubCoaching.PlayerCoach(ViewData) && ViewData.Esports.OwnedClub!.Contracts.Any(c => c.PersonId == _privatePerson && c.Position != "教练"))                  Choice("制定训练计划", "填写内容与训练周期", PrivateTrainingPicker);              if (CoachLineups.CanRequest(ViewData, _privatePerson)) Choice("调整阵容", "商谈下赛季席位", PrivateLineupPicker);              Choice("约一局", "选择日期与进阶", PrivateMatchPicker);              Choice("赠送礼物", "选择物品与数量", PrivateGiftPicker);              if (PrivateMessages.Relation(ViewData, _privatePerson).OathConfirmed) Choice("解除誓约", "向对方提出解除请求", PrivateOathAttachment);              Choice("约定活动", "选择内容与日期", PrivateActivityPicker);              Choice("复盘比赛", "附上真实比赛记录", () => PrivateSharePicker("result"));              Choice("尖塔仲裁", "申请官方审理与裁决", PrivateArbitrationDialog);              Choice("分享帖子", "选择一篇社区讨论", () => PrivateSharePicker("post"));              var target = CareerEngine.Person(ViewData, _privatePerson);              if (OwnedClubs.CanOperate(ViewData) && target != null && target.ClubId != ViewData.Esports.ClubId && OwnedClubs.IsRecruitable(target))                  Choice("商谈合同", "邀请对方提出条件", () => AttachPrivate(new() { Kind = "contract" }));          }, showCancel: false);`
- `NationalSpire.ClubCoaching.PlayerCoach(NationalSpire.CareerData)`；输入表达式：`ClubCoaching.PlayerCoach(ViewData)`；返回值紧邻使用处：`BinaryExpressionSyntax: ClubCoaching.PlayerCoach(ViewData) && ViewData.Esports.OwnedClub!.Contracts.Any(c => c.PersonId == _privatePerson && c.Position != "教练")`
- `NationalSpire.CoachLineups.CanRequest(NationalSpire.CareerData, string)`；输入表达式：`CoachLineups.CanRequest(ViewData, _privatePerson)`；返回值紧邻使用处：`IfStatementSyntax: if (CoachLineups.CanRequest(ViewData, _privatePerson)) Choice("调整阵容", "商谈下赛季席位", PrivateLineupPicker);`
- `NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.CanOperate(ViewData)`；返回值紧邻使用处：`BinaryExpressionSyntax: OwnedClubs.CanOperate(ViewData) && target != null`
- `NationalSpire.OwnedClubs.IsRecruitable(NationalSpire.CareerPerson)`；输入表达式：`OwnedClubs.IsRecruitable(target)`；返回值紧邻使用处：`BinaryExpressionSyntax: OwnedClubs.CanOperate(ViewData) && target != null && target.ClubId != ViewData.Esports.ClubId && OwnedClubs.IsRecruitable(target)`
- `NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Relation(ViewData, _privatePerson)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Relation(ViewData, _privatePerson).OathConfirmed`
- `NationalSpire.PrivateOffer.PrivateOffer()`；输入表达式：`new() { Kind = "contract" }`；返回值紧邻使用处：`ArgumentSyntax: new() { Kind = "contract" }`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`ViewData.Esports.OwnedClub!.Contracts.Any(c => c.PersonId == _privatePerson && c.Position != "教练")`；返回值紧邻使用处：`BinaryExpressionSyntax: ClubCoaching.PlayerCoach(ViewData) && ViewData.Esports.OwnedClub!.Contracts.Any(c => c.PersonId == _privatePerson && c.Position != "教练")`

**赋值（含属性/字段和局部值）：**

- `Columns` = `2`
- `Kind` = `"contract"`

<a id="symbol-9ea0661130d0"></a>

## `Choice(string, string, System.Action) — void Choice(string title, string detail, Action action)`

来源：源码第 438 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateActions()`](PrivateMessageScreen.cs.md#symbol-6e8c11ead905)

**调用：** [`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`；`System.Action.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._cancelDialog`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`grid.AddChild(b)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddChild(b);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(300, 86)`；返回值紧邻使用处：`AssignmentExpressionSyntax: b.CustomMinimumSize = new(300, 86)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton(title + "\n" + detail, () => { _cancelDialog?.Invoke(); action(); }, 300)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton(title + "\n" + detail, () => { _cancelDialog?.Invoke(); action(); }, 300)`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _cancelDialog?.Invoke()`
- `System.Action.Invoke()`；输入表达式：`action()`；返回值紧邻使用处：`ExpressionStatementSyntax: action();`

**赋值（含属性/字段和局部值）：**

- `b.CustomMinimumSize` = `new(300, 86)`

<a id="symbol-aa7339f37b26"></a>

## `NationalSpire.CareerScreen.PrivateMatchPicker() — private void PrivateMatchPicker()`

来源：源码第 454 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`Calendar()`](PrivateMessageScreen.cs.md#symbol-941d226e179c)；[`NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`](PrivateMemoryScreen.cs.md#symbol-053a2c0af91b)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.PrivateAppointments.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-e7f8b7355ddf)；`Godot.Color.Color(string)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.OptionButton()`；`Godot.ScrollContainer.ScrollContainer()`；`Godot.SpinBox.SpinBox()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.PrivateOffer.PrivateOffer()`

**字段、属性、事件及方法组引用：** `Calendar()`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.PrivateAppointments.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateOffer.Ascension`；`NationalSpire.PrivateOffer.Day`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.Mode`；`NationalSpire.PrivateOffer.Season`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Calendar()`；输入表达式：`Calendar()`；返回值紧邻使用处：`ExpressionStatementSyntax: Calendar();`
- `Godot.Color.Color(string)`；输入表达式：`new Color("ee929d")`；返回值紧邻使用处：`ArgumentSyntax: new Color("ee929d")`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`calendar.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: calendar.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 18);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(error)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(error);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(selected)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(selected);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(asc)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(asc);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(modes)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(modes);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(seasonPicker)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(seasonPicker);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scroll.AddChild(calendar)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.AddChild(calendar);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`modes.AddItem("公开挑战")`；返回值紧邻使用处：`ExpressionStatementSyntax: modes.AddItem("公开挑战");`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`modes.AddItem("朋友切磋")`；返回值紧邻使用处：`ExpressionStatementSyntax: modes.AddItem("朋友切磋");`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`seasonPicker.AddItem("本赛季")`；返回值紧邻使用处：`ExpressionStatementSyntax: seasonPicker.AddItem("本赛季");`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`seasonPicker.AddItem("下赛季")`；返回值紧邻使用处：`ExpressionStatementSyntax: seasonPicker.AddItem("下赛季");`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton()`
- `Godot.ScrollContainer.ScrollContainer()`；输入表达式：`new ScrollContainer { CustomMinimumSize = new(740, 440), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ScrollContainer { CustomMinimumSize = new(740, 440), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `Godot.SpinBox.SpinBox()`；输入表达式：`new SpinBox { MinValue = 0, MaxValue = 10, Prefix = "进阶", CustomMinimumSize = new(160, 45) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new SpinBox { MinValue = 0, MaxValue = 10, Prefix = "进阶", CustomMinimumSize = new(160, 45) }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`AssignmentExpressionSyntax: calendar = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(160, 45)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(160, 45)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(740, 440)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(740, 440)`
- `NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`；输入表达式：`AttachPrivate(request)`；返回值紧邻使用处：`ExpressionStatementSyntax: AttachPrivate(request);`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("约一局", "已有赛程显示在日历中。选好后附到消息。", () =>          {              var request = new PrivateOffer { Kind = "match", Season = season, Day = day, Ascension = ascension, Mode = mode };              if (PrivateAppointments.Error(ViewData, _privatePerson, request) is { } reason) { error!.Text = reason; return false; }              AttachPrivate(request); return true;          }, "添加到消息", box =>          {              var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 18); box.AddChild(row);              var seasonPicker = new OptionButton(); seasonPicker.AddItem("本赛季"); seasonPicker.AddItem("下赛季"); row.AddChild(seasonPicker);              seasonPicker.ItemSelected += index => { season = data.Season + (int)index; day = 0; selected!.Text = "请选择日期"; Calendar(); };              var asc = new SpinBox { MinValue = 0, MaxValue = 10, Prefix = "进阶", CustomMinimumSize = new(160, 45) }; asc.ValueChanged += value => ascension = (int)value; row.AddChild(asc);              var modes = new OptionButton(); modes.AddItem("朋友切磋"); modes.AddItem("公开挑战"); modes.ItemSelected += index => mode = index == 0 ? "切磋" : "挑战"; row.AddChild(modes);              selected = Text("请选择日期", 17, CareerVisuals.Teal); box.AddChild(selected);              var scroll = new ScrollContainer { CustomMinimumSize = new(740, 440), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);              calendar = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; calendar.AddThemeConstantOverride("separation", 12); scroll.AddChild(calendar); Calendar();              error = Text("", 15, new Color("ee929d")); box.AddChild(error);          })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("约一局", "已有赛程显示在日历中。选好后附到消息。", () =>          {              var request = new PrivateOffer { Kind = "match", Season = season, Day = day, Ascension = ascension, Mode = mode };              if (PrivateAppointments.Error(ViewData, _privatePerson, request) is { } reason) { error!.Text = reason; return false; }              AttachPrivate(request); return true;          }, "添加到消息", box =>          {              var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 18); box.AddChild(row);              var seasonPicker = new OptionButton(); seasonPicker.AddItem("本赛季"); seasonPicker.AddItem("下赛季"); row.AddChild(seasonPicker);              seasonPicker.ItemSelected += index => { season = data.Season + (int)index; day = 0; selected!.Text = "请选择日期"; Calendar(); };              var asc = new SpinBox { MinValue = 0, MaxValue = 10, Prefix = "进阶", CustomMinimumSize = new(160, 45) }; asc.ValueChanged += value => ascension = (int)value; row.AddChild(asc);              var modes = new OptionButton(); modes.AddItem("朋友切磋"); modes.AddItem("公开挑战"); modes.ItemSelected += index => mode = index == 0 ? "切磋" : "挑战"; row.AddChild(modes);              selected = Text("请选择日期", 17, CareerVisuals.Teal); box.AddChild(selected);              var scroll = new ScrollContainer { CustomMinimumSize = new(740, 440), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);              calendar = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; calendar.AddThemeConstantOverride("separation", 12); scroll.AddChild(calendar); Calendar();              error = Text("", 15, new Color("ee929d")); box.AddChild(error);          });`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 15, new Color("ee929d"))`；返回值紧邻使用处：`AssignmentExpressionSyntax: error = Text("", 15, new Color("ee929d"))`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("请选择日期", 17, CareerVisuals.Teal)`；返回值紧邻使用处：`AssignmentExpressionSyntax: selected = Text("请选择日期", 17, CareerVisuals.Teal)`
- `NationalSpire.PrivateAppointments.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Error(ViewData, _privatePerson, request)`；返回值紧邻使用处：`IsPatternExpressionSyntax: PrivateAppointments.Error(ViewData, _privatePerson, request) is { } reason`
- `NationalSpire.PrivateOffer.PrivateOffer()`；输入表达式：`new PrivateOffer { Kind = "match", Season = season, Day = day, Ascension = ascension, Mode = mode }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PrivateOffer { Kind = "match", Season = season, Day = day, Ascension = ascension, Mode = mode }`

**赋值（含属性/字段和局部值）：**

- `asc.ValueChanged` += `value => ascension = (int)value`
- `ascension` = `(int)value`
- `Ascension` = `ascension`
- `calendar` = `new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `CustomMinimumSize` = `new(160, 45)`
- `CustomMinimumSize` = `new(740, 440)`
- `day` = `0`
- `Day` = `day`
- `error!.Text` = `reason`
- `error` = `Text("", 15, new Color("ee929d"))`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `Kind` = `"match"`
- `MaxValue` = `10`
- `MinValue` = `0`
- `mode` = `index == 0 ? "切磋" : "挑战"`
- `Mode` = `mode`
- `modes.ItemSelected` += `index => mode = index == 0 ? "切磋" : "挑战"`
- `Prefix` = `"进阶"`
- `season` = `data.Season + (int)index`
- `Season` = `season`
- `seasonPicker.ItemSelected` += `index => { season = data.Season + (int)index; day = 0; selected!.Text = "请选择日期"; Calendar(); }`
- `selected!.Text` = `"请选择日期"`
- `selected` = `Text("请选择日期", 17, CareerVisuals.Teal)`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-941d226e179c"></a>

## `Calendar() — void Calendar()`

来源：源码第 458 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateMatchPicker()`](PrivateMessageScreen.cs.md#symbol-aa7339f37b26)

**调用：** [`NationalSpire.CareerScreen.AppointmentCalendar(NationalSpire.CareerData, int, System.Collections.Generic.IEnumerable<string>, int, System.Action<int>)`](AppointmentCalendarScreen.cs.md#symbol-b5cb4cb371f4)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；[`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-ee7b01d76b23)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen.AppointmentCalendar(NationalSpire.CareerData, int, System.Collections.Generic.IEnumerable<string>, int, System.Action<int>)`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`calendar!.AddChild(AppointmentCalendar(data, season, [_privatePerson], day, value =>              { day = value; selected!.Text = $"{GameCalendar.Text(data, SeasonCalendar.Start(data, season) + day)}"; }))`；返回值紧邻使用处：`ExpressionStatementSyntax: calendar!.AddChild(AppointmentCalendar(data, season, [_privatePerson], day, value =>              { day = value; selected!.Text = $"{GameCalendar.Text(data, SeasonCalendar.Start(data, season) + day)}"; }));`
- `NationalSpire.CareerScreen.AppointmentCalendar(NationalSpire.CareerData, int, System.Collections.Generic.IEnumerable<string>, int, System.Action<int>)`；输入表达式：`AppointmentCalendar(data, season, [_privatePerson], day, value =>              { day = value; selected!.Text = $"{GameCalendar.Text(data, SeasonCalendar.Start(data, season) + day)}"; })`；返回值紧邻使用处：`ArgumentSyntax: AppointmentCalendar(data, season, [_privatePerson], day, value =>              { day = value; selected!.Text = $"{GameCalendar.Text(data, SeasonCalendar.Start(data, season) + day)}"; })`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(calendar!)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(calendar!);`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(data, SeasonCalendar.Start(data, season) + day)`；返回值紧邻使用处：`InterpolationSyntax: {GameCalendar.Text(data, SeasonCalendar.Start(data, season) + day)}`
- `NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Start(data, season)`；返回值紧邻使用处：`BinaryExpressionSyntax: SeasonCalendar.Start(data, season) + day`

**赋值（含属性/字段和局部值）：**

- `day` = `value`
- `selected!.Text` = `$"{GameCalendar.Text(data, SeasonCalendar.Start(data, season) + day)}"`

<a id="symbol-730bf8884640"></a>

## `NationalSpire.CareerScreen.OpenPrivateOfferCalendar(NationalSpire.PrivateOffer) — private void OpenPrivateOfferCalendar(PrivateOffer offer)`

来源：源码第 482 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-c7881d245b3d)

**调用：** [`NationalSpire.CareerScreen.CaptureLocation()`](CareerNavigation.cs.md#symbol-67f7f7696f8a)；[`NationalSpire.CareerScreen.ClosePrivateMessagesCore(bool)`](PrivateMessageScreen.cs.md#symbol-db8b0a9ff8de)；[`NationalSpire.CareerScreen.UpdateNavigation()`](CareerNavigation.cs.md#symbol-a6094a69b6d7)；[`NationalSpire.CareerScreen.Visit(System.Action)`](CareerNavigation.cs.md#symbol-d49752019228)；[`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-15c716ec61a1)；`System.Collections.Generic.Stack<T>.Pop()`；`System.Collections.Generic.Stack<T>.Push(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._backHistory`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen._privateScroll`；`NationalSpire.CareerScreen._selectedDay`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen.CaptureLocation()`；`NationalSpire.CareerScreen.ChatPage`；`NationalSpire.CareerScreen.ClosePrivateMessagesCore(bool)`；`NationalSpire.CareerScreen.Location.ChatPage`；`NationalSpire.CareerScreen.Location.ChatScroll`；`NationalSpire.CareerScreen.Location.PrivatePerson`；`NationalSpire.CareerScreen.UpdateNavigation()`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen.Visit(System.Action)`；`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.CaptureLocation()`；输入表达式：`CaptureLocation()`；返回值紧邻使用处：`WithExpressionSyntax: CaptureLocation() with { PrivatePerson = _privatePerson, ChatScroll = _privateScroll!.ScrollVertical, ChatPage = ChatPage }`
- `NationalSpire.CareerScreen.ClosePrivateMessagesCore(bool)`；输入表达式：`ClosePrivateMessagesCore(false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClosePrivateMessagesCore(false);`
- `NationalSpire.CareerScreen.UpdateNavigation()`；输入表达式：`UpdateNavigation()`；返回值紧邻使用处：`ExpressionStatementSyntax: UpdateNavigation();`
- `NationalSpire.CareerScreen.Visit(System.Action)`；输入表达式：`Visit(() => { _tab = "日程"; _selectedDay = day; })`；返回值紧邻使用处：`ExpressionStatementSyntax: Visit(() => { _tab = "日程"; _selectedDay = day; });`
- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Date(ViewData, offer)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateAppointments.Date(ViewData, offer)`
- `System.Collections.Generic.Stack<T>.Pop()`；输入表达式：`_backHistory.Pop()`；返回值紧邻使用处：`ExpressionStatementSyntax: _backHistory.Pop();`
- `System.Collections.Generic.Stack<T>.Push(T)`；输入表达式：`_backHistory.Push(previous)`；返回值紧邻使用处：`ExpressionStatementSyntax: _backHistory.Push(previous);`

**赋值（含属性/字段和局部值）：**

- `_selectedDay` = `day`
- `_tab` = `"日程"`
- `ChatPage` = `ChatPage`
- `ChatScroll` = `_privateScroll!.ScrollVertical`
- `PrivatePerson` = `_privatePerson`

<a id="symbol-c7881d245b3d"></a>

## `NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer) — private void AddPrivateOffer(CareerData data, PrivateOffer offer)`

来源：源码第 490 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)

**调用：** `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.OptionButton()`；`Godot.PanelContainer.PanelContainer()`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerScreen.AddCompletedDateCard(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](DateDiaryScreen.cs.md#symbol-0154b9cfbb28)；[`NationalSpire.CareerScreen.AddDateSceneAction(NationalSpire.CareerData, NationalSpire.PrivateOffer, Godot.HBoxContainer)`](DateSceneScreen.cs.md#symbol-413adf55a103)；[`NationalSpire.CareerScreen.ClosePrivateMessages()`](PrivateMessageScreen.cs.md#symbol-eb21fd76632c)；[`NationalSpire.CareerScreen.GiftReceipt(NationalSpire.PrivateOffer)`](ChatAttachmentScreen.cs.md#symbol-bb34e71c1240)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.OpenPost(NationalSpire.CommunityPost)`](CareerNavigation.cs.md#symbol-3888620952df)；[`NationalSpire.CareerScreen.OpenPrivateOfferCalendar(NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-730bf8884640)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-84294149ff91)；[`NationalSpire.CareerScreen.PrivateLineupCard(NationalSpire.CareerData, NationalSpire.CoachLineupRequest, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?)`](CoachScreen.cs.md#symbol-c01675f974f7)；[`NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-5789f5c9047d)；[`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`](PrivateMessageScreen.cs.md#symbol-fb5e88f4639a)；[`NationalSpire.CareerScreen.PrivateTrainingCard(NationalSpire.CareerData, NationalSpire.CoachTrainingPlan, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?)`](CoachScreen.cs.md#symbol-c2e37e4a0f14)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.ClubCoaching.TrainingPlans(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-1ed5bef75319)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；[`NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-871ad0e2a2c9)；[`NationalSpire.OwnedClubs.ReplaceableStarters(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-e1cbaaf9f832)；[`NationalSpire.OwnedClubs.StarterReplacementError(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-e4678a15386e)；[`NationalSpire.OwnedClubs.TransferFee(NationalSpire.CareerPerson)`](OwnedClubs.cs.md#symbol-35a81fabab41)；[`NationalSpire.OwnedClubs.TransferTime(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-c16d35ec992f)；[`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-15c716ec61a1)；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；[`NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-13f25fec3dea)；[`NationalSpire.SocialAppointments.StatusText(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](SocialAppointments.cs.md#symbol-56b98eeeac09)；[`NationalSpire.WeddingAppointments.Description(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-b0c3ba2ccdb6)；[`NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-f30a9608f6f8)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`string.StartsWith(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.Status`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerScreen.AddCompletedDateCard(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；`NationalSpire.CareerScreen.AddDateSceneAction(NationalSpire.CareerData, NationalSpire.PrivateOffer, Godot.HBoxContainer)`；`NationalSpire.CareerScreen.ClosePrivateMessages()`；`NationalSpire.CareerScreen.GiftReceipt(NationalSpire.PrivateOffer)`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.OpenPost(NationalSpire.CommunityPost)`；`NationalSpire.CareerScreen.OpenPrivateOfferCalendar(NationalSpire.PrivateOffer)`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；`NationalSpire.CareerScreen.PrivateLineupCard(NationalSpire.CareerData, NationalSpire.CoachLineupRequest, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?)`；`NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`；`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；`NationalSpire.CareerScreen.PrivateTrainingCard(NationalSpire.CareerData, NationalSpire.CoachTrainingPlan, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._privateBody`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.ClubCoaching.TrainingPlans(NationalSpire.CareerData)`；`NationalSpire.CoachLineupRequest.Id`；`NationalSpire.CoachTrainingPlan.Id`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.EsportsCareer.LineupRequests`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.OathAttachments.Kind`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.ReplaceableStarters(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.StarterReplacementError(NationalSpire.CareerData, string)`；`NationalSpire.OwnedClubs.TransferFee(NationalSpire.CareerPerson)`；`NationalSpire.OwnedClubs.TransferTime(NationalSpire.CareerData)`；`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateConversation.DateSceneStates`；`NationalSpire.PrivateMessageCommand.Offer`；`NationalSpire.PrivateMessageCommand.Part`；`NationalSpire.PrivateMessageCommand.Replacement`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.Ascension`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.FavourBefore`；`NationalSpire.PrivateOffer.FavourTargets`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.MatchId`；`NationalSpire.PrivateOffer.Mode`；`NationalSpire.PrivateOffer.Role`；`NationalSpire.PrivateOffer.Signing`；`NationalSpire.PrivateOffer.State`；`NationalSpire.PrivateOffer.Title`；`NationalSpire.PrivateOffer.Wage`；`NationalSpire.PrivateOffer.Weeks`；`NationalSpire.PrivateOffer.WinBonus`；`NationalSpire.SocialAppointments.StatusText(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.WeddingAppointments.Description(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`actions.AddThemeConstantOverride("separation", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddThemeConstantOverride("separation", 14);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`actions.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddThemeConstantOverride("separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation", 14);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`contents.AddThemeConstantOverride("separation", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: contents.AddThemeConstantOverride("separation", 14);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`inner.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: inner.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("2c3947", "b89e67", 8, 16))`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("2c3947", "b89e67", 8, 16));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("203448", "70acae", 10, 20))`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("203448", "70acae", 10, 20));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("203448", "b89e67", 8, 16))`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("203448", "b89e67", 8, 16));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`postCard.AddThemeStyleboxOverride("panel", CareerVisuals.Box("203448", "b89e67", 8, 16))`；返回值紧邻使用处：`ExpressionStatementSyntax: postCard.AddThemeStyleboxOverride("panel", CareerVisuals.Box("203448", "b89e67", 8, 16));`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateBody!.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateBody!.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateBody!.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateBody!.AddChild(panel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateBody!.AddChild(postCard)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateBody!.AddChild(postCard);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(PrivateButton("取消约战", () => PrivateCommand("dm-decline", new() { Offer = offer.Id }), 140))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(PrivateButton("取消约战", () => PrivateCommand("dm-decline", new() { Offer = offer.Id }), 140));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(PrivateButton("拒绝", () => PrivateCommand("dm-decline", new() { Offer = offer.Id }), 110))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(PrivateButton("拒绝", () => PrivateCommand("dm-decline", new() { Offer = offer.Id }), 110));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(PrivateButton("拒绝", () => PrivateCommand("dm-decline", new() { Offer = offer.Id }), 90))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(PrivateButton("拒绝", () => PrivateCommand("dm-decline", new() { Offer = offer.Id }), 90));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(PrivateButton("查看帖子 ↗", () => { ClosePrivateMessages(); OpenPost(post); }, 150))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(PrivateButton("查看帖子 ↗", () => { ClosePrivateMessages(); OpenPost(post); }, 150));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(PrivateButton("查看日程", () => OpenPrivateOfferCalendar(offer), 140))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(PrivateButton("查看日程", () => OpenPrivateOfferCalendar(offer), 140));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(PrivateButton(offer.Id.StartsWith("arbitration-") ? "要求公开道歉" : "确认发布", () => PrivateCommand("dm-confirm", new() { Offer = offer.Id }), 130))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(PrivateButton(offer.Id.StartsWith("arbitration-") ? "要求公开道歉" : "确认发布", () => PrivateCommand("dm-confirm", new() { Offer = offer.Id }), 130));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(confirm)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(confirm);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(PrivateText($"签字费 ${offer.Signing:#,0.##} · 周薪 ${offer.Wage:#,0.##}\n胜场奖金 ${offer.WinBonus:#,0.##} · {offer.Weeks}周 · {offer.Role}", 17, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(PrivateText($"签字费 ${offer.Signing:#,0.##} · 周薪 ${offer.Wage:#,0.##}\n胜场奖金 ${offer.WinBonus:#,0.##} · {offer.Weeks}周 · {offer.Role}", 17, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(PrivateText(offer.Detail, 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(PrivateText(offer.Detail, 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text("接替哪位首发（原首发转入轮换）", 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text("接替哪位首发（原首发转入轮换）", 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text("转会费 " + CareerMoney.Format(OwnedClubs.TransferFee(p)) + " · " + OwnedClubs.TransferTime(data), 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text("转会费 " + CareerMoney.Format(OwnedClubs.TransferFee(p)) + " · " + OwnedClubs.TransferTime(data), 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text($"{GameCalendar.Text(data, PrivateAppointments.Date(data, offer))} · 进阶{offer.Ascension} · {offer.Mode}", 17, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text($"{GameCalendar.Text(data, PrivateAppointments.Date(data, offer))} · 进阶{offer.Ascension} · {offer.Mode}", 17, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text((offer.Kind == "match" ? "约战" : "合同报价") + " · " + offer.State, 20, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text((offer.Kind == "match" ? "约战" : "合同报价") + " · " + offer.State, 20, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(OwnedClubs.StarterReplacementError(data, "")!, 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(OwnedClubs.StarterReplacementError(data, "")!, 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(actions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(replacementPicker)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(replacementPicker);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`contents.AddChild(PrivateSelectableText(offer.Detail, 17, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: contents.AddChild(PrivateSelectableText(offer.Detail, 17, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`contents.AddChild(PrivateSelectableText(offer.Title, 21, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: contents.AddChild(PrivateSelectableText(offer.Title, 21, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`contents.AddChild(PrivateText((offer.Id.StartsWith("arbitration-") ? "官方要求 · 公开致歉" : "社区发帖") + " · " + (offer.State == "已确认" ? "已发布" : offer.State), 16, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: contents.AddChild(PrivateText((offer.Id.StartsWith("arbitration-") ? "官方要求 · 公开致歉" : "社区发帖") + " · " + (offer.State == "已确认" ? "已发布" : offer.State), 16, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`contents.AddChild(actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: contents.AddChild(actions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inner.AddChild(PrivateText(WeddingAppointments.Description(ViewData, offer), 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: inner.AddChild(PrivateText(WeddingAppointments.Description(ViewData, offer), 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inner.AddChild(PrivateText(offer.Detail, 18, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: inner.AddChild(PrivateText(offer.Detail, 18, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inner.AddChild(Text(GameCalendar.Text(data, PrivateAppointments.Date(data, offer)) + " · " + SocialAppointments.StatusText(data, offer), 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: inner.AddChild(Text(GameCalendar.Text(data, PrivateAppointments.Date(data, offer)) + " · " + SocialAppointments.StatusText(data, offer), 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inner.AddChild(Text(offer.Title, 23, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: inner.AddChild(Text(offer.Title, 23, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inner.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: inner.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(PrivateButton("保留原值", () => PrivateCommand("dm-decline", new() { Offer = offer.Id }), 120))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(PrivateButton("保留原值", () => PrivateCommand("dm-decline", new() { Offer = offer.Id }), 120));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(PrivateButton("公开赴约", () => PrivateCommand("dm-attend", new() { Offer = offer.Id, Part = "public" }), 140))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(PrivateButton("公开赴约", () => PrivateCommand("dm-attend", new() { Offer = offer.Id, Part = "public" }), 140));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(PrivateButton("取消", () => PrivateCommand("dm-decline", new() { Offer = offer.Id }), 100))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(PrivateButton("取消", () => PrivateCommand("dm-decline", new() { Offer = offer.Id }), 100));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(PrivateButton("应用", () => PrivateCommand("dm-confirm", new() { Offer = offer.Id }), 90))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(PrivateButton("应用", () => PrivateCommand("dm-confirm", new() { Offer = offer.Id }), 90));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(PrivateButton("查看日程", () => OpenPrivateOfferCalendar(offer), 120))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(PrivateButton("查看日程", () => OpenPrivateOfferCalendar(offer), 120));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(PrivateButton("确认约定", () => PrivateCommand("dm-confirm", new() { Offer = offer.Id }), 150))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(PrivateButton("确认约定", () => PrivateCommand("dm-confirm", new() { Offer = offer.Id }), 150));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(PrivateButton("私密赴约", () => PrivateCommand("dm-attend", new() { Offer = offer.Id }), 140))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(PrivateButton("私密赴约", () => PrivateCommand("dm-attend", new() { Offer = offer.Id }), 140));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(label)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(label);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`replacementPicker.AddItem("选择首发")`；返回值紧邻使用处：`ExpressionStatementSyntax: replacementPicker.AddItem("选择首发");`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`replacementPicker.AddItem(CareerEngine.DisplayName(data, id))`；返回值紧邻使用处：`ExpressionStatementSyntax: replacementPicker.AddItem(CareerEngine.DisplayName(data, id));`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { Name = "PrivateContractReplacement", SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new Vector2(0, 50) }`；返回值紧邻使用处：`AssignmentExpressionSyntax: replacementPicker = new OptionButton { Name = "PrivateContractReplacement", SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new Vector2(0, 50) }`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { Name = "PrivateFavourCard" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { Name = "PrivateFavourCard" }`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { Name = "SocialActivityCard" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { Name = "SocialActivityCard" }`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, 50)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(0, 50)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, id)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.DisplayName(data, id)`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(ViewData, _privatePerson)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerEngine.Person(ViewData, _privatePerson) is { ClubId.Length: > 0 } p`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, _privatePerson)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerEngine.Person(data, _privatePerson) is { ClubId.Length: > 0 } p`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(OwnedClubs.TransferFee(p))`；返回值紧邻使用处：`BinaryExpressionSyntax: "转会费 " + CareerMoney.Format(OwnedClubs.TransferFee(p))`
- `NationalSpire.CareerScreen.AddCompletedDateCard(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；输入表达式：`AddCompletedDateCard(data, _privatePerson, offer)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddCompletedDateCard(data, _privatePerson, offer);`
- `NationalSpire.CareerScreen.AddDateSceneAction(NationalSpire.CareerData, NationalSpire.PrivateOffer, Godot.HBoxContainer)`；输入表达式：`AddDateSceneAction(data, offer, row)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddDateSceneAction(data, offer, row);`
- `NationalSpire.CareerScreen.ClosePrivateMessages()`；输入表达式：`ClosePrivateMessages()`；返回值紧邻使用处：`ExpressionStatementSyntax: ClosePrivateMessages();`
- `NationalSpire.CareerScreen.GiftReceipt(NationalSpire.PrivateOffer)`；输入表达式：`GiftReceipt(offer)`；返回值紧邻使用处：`ExpressionStatementSyntax: GiftReceipt(offer);`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(card)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(card)`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(panel)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(panel)`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(postCard)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(postCard)`
- `NationalSpire.CareerScreen.OpenPost(NationalSpire.CommunityPost)`；输入表达式：`OpenPost(post)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenPost(post);`
- `NationalSpire.CareerScreen.OpenPrivateOfferCalendar(NationalSpire.PrivateOffer)`；输入表达式：`OpenPrivateOfferCalendar(offer)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenPrivateOfferCalendar(offer)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("保留原值", () => PrivateCommand("dm-decline", new() { Offer = offer.Id }), 120)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("保留原值", () => PrivateCommand("dm-decline", new() { Offer = offer.Id }), 120)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("公开赴约", () => PrivateCommand("dm-attend", new() { Offer = offer.Id, Part = "public" }), 140)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("公开赴约", () => PrivateCommand("dm-attend", new() { Offer = offer.Id, Part = "public" }), 140)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("取消", () => PrivateCommand("dm-decline", new() { Offer = offer.Id }), 100)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("取消", () => PrivateCommand("dm-decline", new() { Offer = offer.Id }), 100)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("取消约战", () => PrivateCommand("dm-decline", new() { Offer = offer.Id }), 140)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("取消约战", () => PrivateCommand("dm-decline", new() { Offer = offer.Id }), 140)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("应用", () => PrivateCommand("dm-confirm", new() { Offer = offer.Id }), 90)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("应用", () => PrivateCommand("dm-confirm", new() { Offer = offer.Id }), 90)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("拒绝", () => PrivateCommand("dm-decline", new() { Offer = offer.Id }), 110)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("拒绝", () => PrivateCommand("dm-decline", new() { Offer = offer.Id }), 110)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("拒绝", () => PrivateCommand("dm-decline", new() { Offer = offer.Id }), 90)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("拒绝", () => PrivateCommand("dm-decline", new() { Offer = offer.Id }), 90)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("查看帖子 ↗", () => { ClosePrivateMessages(); OpenPost(post); }, 150)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("查看帖子 ↗", () => { ClosePrivateMessages(); OpenPost(post); }, 150)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("查看日程", () => OpenPrivateOfferCalendar(offer), 120)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("查看日程", () => OpenPrivateOfferCalendar(offer), 120)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("查看日程", () => OpenPrivateOfferCalendar(offer), 140)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("查看日程", () => OpenPrivateOfferCalendar(offer), 140)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("确认约定", () => PrivateCommand("dm-confirm", new() { Offer = offer.Id }), 150)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("确认约定", () => PrivateCommand("dm-confirm", new() { Offer = offer.Id }), 150)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("私密赴约", () => PrivateCommand("dm-attend", new() { Offer = offer.Id }), 140)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("私密赴约", () => PrivateCommand("dm-attend", new() { Offer = offer.Id }), 140)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton(offer.Id.StartsWith("arbitration-") ? "要求公开道歉" : "确认发布", () => PrivateCommand("dm-confirm", new() { Offer = offer.Id }), 130)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton(offer.Id.StartsWith("arbitration-") ? "要求公开道歉" : "确认发布", () => PrivateCommand("dm-confirm", new() { Offer = offer.Id }), 130)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton(offer.Kind == "match" ? "确认安排" : "确认签约", () => { string detail = offer.Kind == "match" ? $"{GameCalendar.Text(data, PrivateAppointments.Date(data, offer))} · 进阶{offer.Ascension} · {offer.Mode}" : $"首次支付 ${(offer.Signing + (CareerEngine.Person(ViewData, _privatePerson) is { ClubId.Length: > 0 } p ? OwnedClubs.TransferFee(p) * 10 : 0)):#,0.##}；每周 ${offer.Wage:#,0.##}，每次获胜 ${offer.WinBonus:#,0.##}。合同 {offer.Weeks} 周，进入{offer.Role}阵容。"; if (offer.Kind == "match") { PrivateCommand("dm-confirm", new() { Offer = offer.Id }); return; } ShowCareerDialog("确认" + (offer.Kind == "match" ? "约战" : "合同"), detail, () => { PrivateCommand("dm-confirm", new() { Offer = offer.Id, Replacement = replacement }); return true; }); }, 160)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton(offer.Kind == "match" ? "确认安排" : "确认签约", () => { string detail = offer.Kind == "match" ? $"{GameCalendar.Text(data, PrivateAppointments.Date(data, offer))} · 进阶{offer.Ascension} · {offer.Mode}" : $"首次支付 ${(offer.Signing + (CareerEngine.Person(ViewData, _privatePerson) is { ClubId.Length: > 0 } p ? OwnedClubs.TransferFee(p) * 10 : 0)):#,0.##}；每周 ${offer.Wage:#,0.##}，每次获胜 ${offer.WinBonus:#,0.##}。合同 {offer.Weeks} 周，进入{offer.Role}阵容。"; if (offer.Kind == "match") { PrivateCommand("dm-confirm", new() { Offer = offer.Id }); return; } ShowCareerDialog("确认" + (offer.Kind == "match" ? "约战" : "合同"), detail, () => { PrivateCommand("dm-confirm", new() { Offer = offer.Id, Replacement = replacement }); return true; }); }, 160)`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；输入表达式：`PrivateCommand("dm-attend", new() { Offer = offer.Id })`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => PrivateCommand("dm-attend", new() { Offer = offer.Id })`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；输入表达式：`PrivateCommand("dm-attend", new() { Offer = offer.Id, Part = "public" })`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => PrivateCommand("dm-attend", new() { Offer = offer.Id, Part = "public" })`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；输入表达式：`PrivateCommand("dm-confirm", new() { Offer = offer.Id })`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => PrivateCommand("dm-confirm", new() { Offer = offer.Id })`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；输入表达式：`PrivateCommand("dm-confirm", new() { Offer = offer.Id })`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateCommand("dm-confirm", new() { Offer = offer.Id });`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；输入表达式：`PrivateCommand("dm-confirm", new() { Offer = offer.Id, Replacement = replacement })`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateCommand("dm-confirm", new() { Offer = offer.Id, Replacement = replacement });`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；输入表达式：`PrivateCommand("dm-decline", new() { Offer = offer.Id })`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => PrivateCommand("dm-decline", new() { Offer = offer.Id })`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine($"好感 {current} → {target}（{target - current:+0;-0;0}）" + state, 18, _gold)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateLine($"好感 {current} → {target}（{target - current:+0;-0;0}）" + state, 18, _gold)`
- `NationalSpire.CareerScreen.PrivateLineupCard(NationalSpire.CareerData, NationalSpire.CoachLineupRequest, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?)`；输入表达式：`PrivateLineupCard(data, request, _privateBody!)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateLineupCard(data, request, _privateBody!);`
- `NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`；输入表达式：`PrivateSelectableText(offer.Detail, 17, _ink)`；返回值紧邻使用处：`ArgumentSyntax: PrivateSelectableText(offer.Detail, 17, _ink)`
- `NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`；输入表达式：`PrivateSelectableText(offer.Title, 21, _ink)`；返回值紧邻使用处：`ArgumentSyntax: PrivateSelectableText(offer.Title, 21, _ink)`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText($"签字费 ${offer.Signing:#,0.##} · 周薪 ${offer.Wage:#,0.##}\n胜场奖金 ${offer.WinBonus:#,0.##} · {offer.Weeks}周 · {offer.Role}", 17, _ink)`；返回值紧邻使用处：`ArgumentSyntax: PrivateText($"签字费 ${offer.Signing:#,0.##} · 周薪 ${offer.Wage:#,0.##}\n胜场奖金 ${offer.WinBonus:#,0.##} · {offer.Weeks}周 · {offer.Role}", 17, _ink)`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText((offer.Id.StartsWith("arbitration-") ? "官方要求 · 公开致歉" : "社区发帖") + " · " + (offer.State == "已确认" ? "已发布" : offer.State), 16, _gold)`；返回值紧邻使用处：`ArgumentSyntax: PrivateText((offer.Id.StartsWith("arbitration-") ? "官方要求 · 公开致歉" : "社区发帖") + " · " + (offer.State == "已确认" ? "已发布" : offer.State), 16, _gold)`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText(WeddingAppointments.Description(ViewData, offer), 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: PrivateText(WeddingAppointments.Description(ViewData, offer), 16, _muted)`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText(offer.Detail, 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: PrivateText(offer.Detail, 15, _muted)`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText(offer.Detail, 18, _ink)`；返回值紧邻使用处：`ArgumentSyntax: PrivateText(offer.Detail, 18, _ink)`
- `NationalSpire.CareerScreen.PrivateTrainingCard(NationalSpire.CareerData, NationalSpire.CoachTrainingPlan, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?)`；输入表达式：`PrivateTrainingCard(data, plan, _privateBody!)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateTrainingCard(data, plan, _privateBody!);`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("确认" + (offer.Kind == "match" ? "约战" : "合同"), detail, () => { PrivateCommand("dm-confirm", new() { Offer = offer.Id, Replacement = replacement }); return true; })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("确认" + (offer.Kind == "match" ? "约战" : "合同"), detail, () => { PrivateCommand("dm-confirm", new() { Offer = offer.Id, Replacement = replacement }); return true; });`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("接替哪位首发（原首发转入轮换）", 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("接替哪位首发（原首发转入轮换）", 16, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("转会费 " + CareerMoney.Format(OwnedClubs.TransferFee(p)) + " · " + OwnedClubs.TransferTime(data), 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("转会费 " + CareerMoney.Format(OwnedClubs.TransferFee(p)) + " · " + OwnedClubs.TransferTime(data), 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"{GameCalendar.Text(data, PrivateAppointments.Date(data, offer))} · 进阶{offer.Ascension} · {offer.Mode}", 17, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text($"{GameCalendar.Text(data, PrivateAppointments.Date(data, offer))} · 进阶{offer.Ascension} · {offer.Mode}", 17, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text((offer.Kind == "match" ? "约战" : "合同报价") + " · " + offer.State, 20, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text((offer.Kind == "match" ? "约战" : "合同报价") + " · " + offer.State, 20, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(GameCalendar.Text(data, PrivateAppointments.Date(data, offer)) + " · " + SocialAppointments.StatusText(data, offer), 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(GameCalendar.Text(data, PrivateAppointments.Date(data, offer)) + " · " + SocialAppointments.StatusText(data, offer), 16, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(OwnedClubs.StarterReplacementError(data, "")!, 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(OwnedClubs.StarterReplacementError(data, "")!, 16, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(offer.Title, 23, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(offer.Title, 23, _gold)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("203448", "70acae", 10, 20)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("203448", "70acae", 10, 20)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("203448", "b89e67", 8, 16)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("203448", "b89e67", 8, 16)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("2c3947", "b89e67", 8, 16)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("2c3947", "b89e67", 8, 16)`
- `NationalSpire.ClubCoaching.TrainingPlans(NationalSpire.CareerData)`；输入表达式：`ClubCoaching.TrainingPlans(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ClubCoaching.TrainingPlans(data).FirstOrDefault`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).FirstOrDefault`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(data, PrivateAppointments.Date(data, offer))`；返回值紧邻使用处：`BinaryExpressionSyntax: GameCalendar.Text(data, PrivateAppointments.Date(data, offer)) + " · "`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(data, PrivateAppointments.Date(data, offer))`；返回值紧邻使用处：`InterpolationSyntax: {GameCalendar.Text(data, PrivateAppointments.Date(data, offer))}`
- `NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.CanOperate(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: offer.Kind == "contract" && offer.Role == "首发" && OwnedClubs.CanOperate(data)`
- `NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.CanOperate(data)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !OwnedClubs.CanOperate(data)`
- `NationalSpire.OwnedClubs.ReplaceableStarters(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.ReplaceableStarters(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = OwnedClubs.ReplaceableStarters(data)`
- `NationalSpire.OwnedClubs.StarterReplacementError(NationalSpire.CareerData, string)`；输入表达式：`OwnedClubs.StarterReplacementError(data, "")`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: OwnedClubs.StarterReplacementError(data, "")!`
- `NationalSpire.OwnedClubs.StarterReplacementError(NationalSpire.CareerData, string)`；输入表达式：`OwnedClubs.StarterReplacementError(data, replacement)`；返回值紧邻使用处：`BinaryExpressionSyntax: OwnedClubs.StarterReplacementError(data, replacement) != null`
- `NationalSpire.OwnedClubs.TransferFee(NationalSpire.CareerPerson)`；输入表达式：`OwnedClubs.TransferFee(p)`；返回值紧邻使用处：`ArgumentSyntax: OwnedClubs.TransferFee(p)`
- `NationalSpire.OwnedClubs.TransferFee(NationalSpire.CareerPerson)`；输入表达式：`OwnedClubs.TransferFee(p)`；返回值紧邻使用处：`BinaryExpressionSyntax: OwnedClubs.TransferFee(p) * 10`
- `NationalSpire.OwnedClubs.TransferTime(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.TransferTime(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: "转会费 " + CareerMoney.Format(OwnedClubs.TransferFee(p)) + " · " + OwnedClubs.TransferTime(data)`
- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Date(data, offer)`；返回值紧邻使用处：`ArgumentSyntax: PrivateAppointments.Date(data, offer)`
- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Date(data, offer)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateAppointments.Date(data, offer) == data.Day`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Offer = offer.Id }`；返回值紧邻使用处：`ArgumentSyntax: new() { Offer = offer.Id }`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Offer = offer.Id, Part = "public" }`；返回值紧邻使用处：`ArgumentSyntax: new() { Offer = offer.Id, Part = "public" }`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Offer = offer.Id, Replacement = replacement }`；返回值紧邻使用处：`ArgumentSyntax: new() { Offer = offer.Id, Replacement = replacement }`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, _privatePerson)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Conversation(data, _privatePerson).DateSceneStates`
- `NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Favour(data, _privatePerson)`；返回值紧邻使用处：`ConditionalExpressionSyntax: offer.State == "待确认" ? PrivateMessages.Favour(data, _privatePerson) : offer.FavourBefore`
- `NationalSpire.SocialAppointments.StatusText(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`SocialAppointments.StatusText(data, offer)`；返回值紧邻使用处：`BinaryExpressionSyntax: GameCalendar.Text(data, PrivateAppointments.Date(data, offer)) + " · " + SocialAppointments.StatusText(data, offer)`
- `NationalSpire.WeddingAppointments.Description(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`WeddingAppointments.Description(ViewData, offer)`；返回值紧邻使用处：`ArgumentSyntax: WeddingAppointments.Description(ViewData, offer)`
- `NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`；输入表达式：`WeddingAppointments.IsWedding(offer)`；返回值紧邻使用处：`IfStatementSyntax: if (WeddingAppointments.IsWedding(offer)) inner.AddChild(PrivateText(WeddingAppointments.Description(ViewData, offer), 16, _muted));`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Matches.Any(m => m.Id == offer.MatchId && m.Status == "待赛")`；返回值紧邻使用处：`BinaryExpressionSyntax: offer.State == "已确认" && offer.Kind == "match" && data.Matches.Any(m => m.Id == offer.MatchId && m.Status == "待赛")`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`ClubCoaching.TrainingPlans(data).FirstOrDefault(p => p.Id == offer.Id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ClubCoaching.TrainingPlans(data).FirstOrDefault(p => p.Id == offer.Id) is { } plan`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(data).FirstOrDefault(p => p.Id == offer.MatchId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CommunityThreads.All(data).FirstOrDefault(p => p.Id == offer.MatchId) is { } post`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Esports.LineupRequests.FirstOrDefault(r => r.Id == offer.Id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: data.Esports.LineupRequests.FirstOrDefault(r => r.Id == offer.Id) is { } request`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`PrivateMessages.Conversation(data, _privatePerson).DateSceneStates.GetValueOrDefault(offer.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateMessages.Conversation(data, _privatePerson).DateSceneStates.GetValueOrDefault(offer.Id) == "ended"`
- `string.StartsWith(string)`；输入表达式：`offer.Id.StartsWith("arbitration-")`；返回值紧邻使用处：`ConditionalExpressionSyntax: offer.Id.StartsWith("arbitration-") ? "官方要求 · 公开致歉" : "社区发帖"`
- `string.StartsWith(string)`；输入表达式：`offer.Id.StartsWith("arbitration-")`；返回值紧邻使用处：`ConditionalExpressionSyntax: offer.Id.StartsWith("arbitration-") ? "要求公开道歉" : "确认发布"`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new Vector2(0, 50)`
- `Name` = `"PrivateContractReplacement"`
- `Name` = `"PrivateFavourCard"`
- `Name` = `"SocialActivityCard"`
- `Offer` = `offer.Id`
- `Part` = `"public"`
- `Replacement` = `replacement`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `confirm.Disabled` = `!OwnedClubs.CanOperate(data) || needsReplacement`
- `confirm.Disabled` = `OwnedClubs.StarterReplacementError(data, replacement) != null`
- `label.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `replacementPicker.ItemSelected` += `_ => confirm.Disabled = OwnedClubs.StarterReplacementError(data, replacement) != null`
- `replacementPicker.ItemSelected` += `index => replacement = index > 0 ? ids[(int)index - 1] : ""`
- `replacementPicker` = `new OptionButton { Name = "PrivateContractReplacement", SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new Vector2(0, 50) }`
- `replacement` = `index > 0 ? ids[(int)index - 1] : ""`

<a id="symbol-8e28d3a34860"></a>

## `NationalSpire.CareerScreen.PrivateProfile(NationalSpire.CareerData, NationalSpire.CareerPerson) — private void PrivateProfile(CareerData data, CareerPerson person)`

来源：源码第 609 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PersonProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](ProfileScreen.cs.md#symbol-2d802d5a07b9)

**调用：** `Godot.Control.Control()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；[`NationalSpire.CareerScreen.ArbitrationCard(NationalSpire.CareerData, NationalSpire.ArbitrationRecord)`](ArbitrationScreen.cs.md#symbol-8d41f13d5476)；[`NationalSpire.CareerScreen.DateDiaryButton(System.Action, int)`](DateDiaryScreen.cs.md#symbol-da0fd94c90a9)；[`NationalSpire.CareerScreen.DateDiaryDialog(NationalSpire.CareerData, string)`](DateDiaryScreen.cs.md#symbol-2e181417b5e0)；[`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.PrivateIdentity(NationalSpire.CareerData, string, bool)`](PrivateMemoryScreen.cs.md#symbol-65caddca194f)；[`NationalSpire.CareerScreen.ProfileSection(string)`](ProfileScreen.cs.md#symbol-078e0ffb0ebe)；[`NationalSpire.DateDiaries.ForPerson(NationalSpire.CareerData, string)`](DateDiaries.cs.md#symbol-61a0ccdee0e3)；[`NationalSpire.DateSceneMemories.ForPerson(NationalSpire.CareerData, string, out string)`](DateSceneMemories.cs.md#symbol-8302de288689)；[`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-25194feb6779)；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`

**字段、属性、事件及方法组引用：** `NationalSpire.ArbitrationRecord.Day`；`NationalSpire.CareerPerson.Arbitrations`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerScreen.ArbitrationCard(NationalSpire.CareerData, NationalSpire.ArbitrationRecord)`；`NationalSpire.CareerScreen.DateDiaryButton(System.Action, int)`；`NationalSpire.CareerScreen.DateDiaryDialog(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.PrivateIdentity(NationalSpire.CareerData, string, bool)`；`NationalSpire.CareerScreen.ProfileSection(string)`；`NationalSpire.DateDiaries.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.DateSceneMemories.ForPerson(NationalSpire.CareerData, string, out string)`；`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.Control()`；输入表达式：`new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`ArgumentSyntax: new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { Name = "ProfileRelationshipActions", SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { Name = "ProfileRelationshipActions", SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(DateDiaryButton(() => DateDiaryDialog(data, person.Id), 160))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(DateDiaryButton(() => DateDiaryDialog(data, person.Id), 160));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(PrivateButton("发送私信", () => OpenPrivateMessages(person.Id), 160))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(PrivateButton("发送私信", () => OpenPrivateMessages(person.Id), 160));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill })`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(PrivateIdentity(data, person.Id, false))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(PrivateIdentity(data, person.Id, false));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(actions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`official.AddChild(ArbitrationCard(data, record))`；返回值紧邻使用处：`ExpressionStatementSyntax: official.AddChild(ArbitrationCard(data, record));`
- `NationalSpire.CareerScreen.ArbitrationCard(NationalSpire.CareerData, NationalSpire.ArbitrationRecord)`；输入表达式：`ArbitrationCard(data, record)`；返回值紧邻使用处：`ArgumentSyntax: ArbitrationCard(data, record)`
- `NationalSpire.CareerScreen.DateDiaryButton(System.Action, int)`；输入表达式：`DateDiaryButton(() => DateDiaryDialog(data, person.Id), 160)`；返回值紧邻使用处：`ArgumentSyntax: DateDiaryButton(() => DateDiaryDialog(data, person.Id), 160)`
- `NationalSpire.CareerScreen.DateDiaryDialog(NationalSpire.CareerData, string)`；输入表达式：`DateDiaryDialog(data, person.Id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => DateDiaryDialog(data, person.Id)`
- `NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；输入表达式：`OpenPrivateMessages(person.Id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenPrivateMessages(person.Id)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("发送私信", () => OpenPrivateMessages(person.Id), 160)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("发送私信", () => OpenPrivateMessages(person.Id), 160)`
- `NationalSpire.CareerScreen.PrivateIdentity(NationalSpire.CareerData, string, bool)`；输入表达式：`PrivateIdentity(data, person.Id, false)`；返回值紧邻使用处：`ArgumentSyntax: PrivateIdentity(data, person.Id, false)`
- `NationalSpire.CareerScreen.ProfileSection(string)`；输入表达式：`ProfileSection("与你的关系")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ProfileSection("与你的关系")`
- `NationalSpire.CareerScreen.ProfileSection(string)`；输入表达式：`ProfileSection("官方仲裁档案")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ProfileSection("官方仲裁档案")`
- `NationalSpire.DateDiaries.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`DateDiaries.ForPerson(data, person.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateDiaries.ForPerson(data, person.Id).Count`
- `NationalSpire.DateSceneMemories.ForPerson(NationalSpire.CareerData, string, out string)`；输入表达式：`DateSceneMemories.ForPerson(data, person.Id, out _)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateSceneMemories.ForPerson(data, person.Id, out _).Count`
- `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.CanChat(data, person.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PrivateMessages.CanChat(data, person.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`person.Arbitrations.OrderByDescending(r => r.Day)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var record in person.Arbitrations.OrderByDescending(r => r.Day)) official.AddChild(ArbitrationCard(data, record));`

**赋值（含属性/字段和局部值）：**

- `Name` = `"ProfileRelationshipActions"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-817b28271c34"></a>

## `NationalSpire.PrivateIcon.Gear — public bool Gear`

来源：源码第 625 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-1a7b63a73436"></a>

## `NationalSpire.PrivateIcon._Ready() — public override void _Ready()`

来源：源码第 626 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-fb8df0cf306a"></a>

## `NationalSpire.PrivateIcon._Draw() — public override void _Draw()`

来源：源码第 627 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float)`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.Vector2.FromAngle(float)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Ink`；`NationalSpire.PrivateIcon.Gear`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(center, 3, 0, Mathf.Tau, 24, color, 2, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(center, 3, 0, Mathf.Tau, 24, color, 2, true);`
- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(center, 8, 0, Mathf.Tau, 32, color, 2, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(center, 8, 0, Mathf.Tau, 32, color, 2, true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(center + direction * 8, center + direction * 12, color, 3, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(center + direction * 8, center + direction * 12, color, 3, true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(rect.Position + new Vector2(26, 0), center + new Vector2(0, 2), color, 1.8f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(rect.Position + new Vector2(26, 0), center + new Vector2(0, 2), color, 1.8f, true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(rect.Position, center + new Vector2(0, 2), color, 1.8f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(rect.Position, center + new Vector2(0, 2), color, 1.8f, true);`
- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float)`；输入表达式：`DrawRect(rect, color, false, 1.8f)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawRect(rect, color, false, 1.8f);`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(center - new Vector2(13, 9), new Vector2(26, 18))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Rect2(center - new Vector2(13, 9), new Vector2(26, 18))`
- `Godot.Vector2.FromAngle(float)`；输入表达式：`Vector2.FromAngle(i * Mathf.Tau / 8)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Vector2.FromAngle(i * Mathf.Tau / 8)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, 2)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(0, 2)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(13, 9)`；返回值紧邻使用处：`BinaryExpressionSyntax: center - new Vector2(13, 9)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(26, 0)`；返回值紧邻使用处：`BinaryExpressionSyntax: rect.Position + new Vector2(26, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(26, 18)`；返回值紧邻使用处：`ArgumentSyntax: new Vector2(26, 18)`

**赋值（含属性/字段和局部值）：**
