# DateGameScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`E6FEF5DF0114A71373A7482DDA6A17B242F5409A60FE366CF65EB5DEA8CB53A1`。来源：[源码](../../DateGameScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
private Action? _dateRunResume;
private Button? _dateGameAction, _dateResumeGame;
private bool _dateManualGameInput, _datePhoneManualInput;
private string _dateInputTurn = "", _datePhonePerson = "", _datePhoneOffer = "";
private Button? _datePhoneReturn;
```

<a id="symbol-fdf5726e3b97"></a>

## `NationalSpire.CareerScreen.AddDateGameActions() — private void AddDateGameActions()`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)

**调用：** [`NationalSpire.AffectionArt.Texture(string)`](AffectionVisuals.cs.md#symbol-966474984d6a)；[`NationalSpire.CareerScreen.TickDateGameActions()`](DateGameScreen.cs.md#symbol-c55c74e4c1fe)；[`NationalSpire.DateSceneView.AddInputAction(string, Godot.Texture2D, System.Action, string)`](DateSceneView.cs.md#symbol-0d0da39d688e)

**字段、属性、事件及方法组引用：** `NationalSpire.AffectionArt.Texture(string)`；`NationalSpire.CareerScreen.DatePhone()`；`NationalSpire.CareerScreen.InviteDateGame()`；`NationalSpire.CareerScreen.ResumeDateGame()`；`NationalSpire.CareerScreen.TickDateGameActions()`；`NationalSpire.CareerScreen._dateGameAction`；`NationalSpire.CareerScreen._dateResumeGame`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.DateSceneView.AddInputAction(string, Godot.Texture2D, System.Action, string)`；`NationalSpire.DateSceneView.ExitButton`；`NationalSpire.DateSceneView.Resume`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AffectionArt.Texture(string)`；输入表达式：`AffectionArt.Texture("calendar-crossed-swords")`；返回值紧邻使用处：`ArgumentSyntax: AffectionArt.Texture("calendar-crossed-swords")`
- `NationalSpire.AffectionArt.Texture(string)`；输入表达式：`AffectionArt.Texture("date-phone")`；返回值紧邻使用处：`ArgumentSyntax: AffectionArt.Texture("date-phone")`
- `NationalSpire.CareerScreen.TickDateGameActions()`；输入表达式：`TickDateGameActions()`；返回值紧邻使用处：`ExpressionStatementSyntax: TickDateGameActions();`
- `NationalSpire.DateSceneView.AddInputAction(string, Godot.Texture2D, System.Action, string)`；输入表达式：`_dateView!.AddInputAction("DateGameInvite", AffectionArt.Texture("calendar-crossed-swords"), InviteDateGame, "发起对局邀请")`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dateGameAction = _dateView!.AddInputAction("DateGameInvite", AffectionArt.Texture("calendar-crossed-swords"), InviteDateGame, "发起对局邀请")`
- `NationalSpire.DateSceneView.AddInputAction(string, Godot.Texture2D, System.Action, string)`；输入表达式：`_dateView.AddInputAction("DatePhone", AffectionArt.Texture("date-phone"), DatePhone, "打开讯息")`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.AddInputAction("DatePhone", AffectionArt.Texture("date-phone"), DatePhone, "打开讯息");`

**赋值（含属性/字段和局部值）：**

- `_dateGameAction` = `_dateView!.AddInputAction("DateGameInvite", AffectionArt.Texture("calendar-crossed-swords"), InviteDateGame, "发起对局邀请")`
- `_dateResumeGame` = `_dateView.ExitButton`
- `_dateView.Resume` = `ResumeDateGame`

<a id="symbol-c55c74e4c1fe"></a>

## `NationalSpire.CareerScreen.TickDateGameActions() — private void TickDateGameActions()`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddDateGameActions()`](DateGameScreen.cs.md#symbol-fdf5726e3b97)；[`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)

**调用：** [`NationalSpire.CareerScreen.CanResumeDateGame()`](DateGameScreen.cs.md#symbol-936de630737d)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerScreen.CanResumeDateGame()`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._dateGameAction`；`NationalSpire.CareerScreen._dateResumeGame`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._starting`；`NationalSpire.DateSceneView.InputMode`；`NationalSpire.DateSceneView.ResumeGame`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.CanResumeDateGame()`；输入表达式：`CanResumeDateGame()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dateView.ResumeGame.Visible = CanResumeDateGame()`

**赋值（含属性/字段和局部值）：**

- `_dateGameAction.Disabled` = `!_dateView.InputMode || ViewData.PendingMatchId != null || _multiplayer != null`
- `_dateResumeGame.Disabled` = `_starting`
- `_dateResumeGame.Text` = `"退出约会 Esc"`
- `_dateView.ResumeGame.Disabled` = `_starting`
- `_dateView.ResumeGame.Visible` = `CanResumeDateGame()`

<a id="symbol-643d7d1bf1ef"></a>

## `NationalSpire.CareerScreen.InviteDateGame() — private void InviteDateGame()`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Control.GrabFocus()`；[`NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`](PrivateMemoryScreen.cs.md#symbol-053a2c0af91b)；[`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)；`NationalSpire.PrivateOffer.PrivateOffer()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`；`NationalSpire.CareerScreen.PrivateAttachments`；`NationalSpire.CareerScreen.TickDateScene()`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._dateOffer`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.DateGames.AttachmentKind`；`NationalSpire.DateSceneView.Editor`；`NationalSpire.DateSceneView.InputMode`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.MatchId`；`NationalSpire.PrivateOffer.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.GrabFocus()`；输入表达式：`_dateView.Editor.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.Editor.GrabFocus();`
- `NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`；输入表达式：`AttachPrivate(new() { Kind = DateGames.AttachmentKind, Title = "一起开一局", Detail = "邀请当前约会参加者游玩《杀戮尖塔2》切磋。", MatchId = _dateOffer })`；返回值紧邻使用处：`ExpressionStatementSyntax: AttachPrivate(new() { Kind = DateGames.AttachmentKind, Title = "一起开一局", Detail = "邀请当前约会参加者游玩《杀戮尖塔2》切磋。", MatchId = _dateOffer });`
- `NationalSpire.CareerScreen.TickDateScene()`；输入表达式：`TickDateScene()`；返回值紧邻使用处：`ExpressionStatementSyntax: TickDateScene();`
- `NationalSpire.PrivateOffer.PrivateOffer()`；输入表达式：`new() { Kind = DateGames.AttachmentKind, Title = "一起开一局", Detail = "邀请当前约会参加者游玩《杀戮尖塔2》切磋。", MatchId = _dateOffer }`；返回值紧邻使用处：`ArgumentSyntax: new() { Kind = DateGames.AttachmentKind, Title = "一起开一局", Detail = "邀请当前约会参加者游玩《杀戮尖塔2》切磋。", MatchId = _dateOffer }`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateAttachments.Any(a => a.Kind == DateGames.AttachmentKind)`；返回值紧邻使用处：`IfStatementSyntax: if (PrivateAttachments.Any(a => a.Kind == DateGames.AttachmentKind)) return;`

**赋值（含属性/字段和局部值）：**

- `Detail` = `"邀请当前约会参加者游玩《杀戮尖塔2》切磋。"`
- `Kind` = `DateGames.AttachmentKind`
- `MatchId` = `_dateOffer`
- `Title` = `"一起开一局"`

<a id="symbol-d1774dd40624"></a>

## `NationalSpire.CareerScreen.ShowDateGameChoices(NationalSpire.CareerMatch) — private void ShowDateGameChoices(CareerMatch match)`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ShowDateLine()`](DateSceneScreen.cs.md#symbol-1580b0be190e)

**调用：** [`NationalSpire.CareerScreen.DateGameStartDialog(NationalSpire.CareerMatch)`](DateGameScreen.cs.md#symbol-c88ac7d5c81a)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.ShowDateInput(bool, bool)`](DateGameScreen.cs.md#symbol-f7a3691c9897)；[`NationalSpire.DateSceneView.ShowGameChoices(System.Action, System.Action)`](DateSceneView.cs.md#symbol-c0903cec21b6)；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.DateGameStartDialog(NationalSpire.CareerMatch)`；`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；`NationalSpire.CareerScreen.ShowDateInput(bool, bool)`；`NationalSpire.CareerScreen._dateOffer`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.DateSceneView.ShowGameChoices(System.Action, System.Action)`；`NationalSpire.PrivateMessageCommand.Offer`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.DateGameStartDialog(NationalSpire.CareerMatch)`；输入表达式：`DateGameStartDialog(match)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => DateGameStartDialog(match)`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；输入表达式：`PrivateCommand("dm-date-game-cancel", new() { Offer = _dateOffer }, () => ShowDateInput())`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => PrivateCommand("dm-date-game-cancel", new() { Offer = _dateOffer }, () => ShowDateInput())`
- `NationalSpire.CareerScreen.ShowDateInput(bool, bool)`；输入表达式：`ShowDateInput()`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ShowDateInput()`
- `NationalSpire.DateSceneView.ShowGameChoices(System.Action, System.Action)`；输入表达式：`_dateView!.ShowGameChoices(() => DateGameStartDialog(match), () => PrivateCommand("dm-date-game-cancel", new() { Offer = _dateOffer }, () => ShowDateInput()))`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView!.ShowGameChoices(() => DateGameStartDialog(match), () => PrivateCommand("dm-date-game-cancel", new() { Offer = _dateOffer }, () => ShowDateInput()));`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Offer = _dateOffer }`；返回值紧邻使用处：`ArgumentSyntax: new() { Offer = _dateOffer }`

**赋值（含属性/字段和局部值）：**

- `Offer` = `_dateOffer`

<a id="symbol-c88ac7d5c81a"></a>

## `NationalSpire.CareerScreen.DateGameStartDialog(NationalSpire.CareerMatch) — private void DateGameStartDialog(CareerMatch match)`

来源：源码第 45 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ShowDateGameChoices(NationalSpire.CareerMatch)`](DateGameScreen.cs.md#symbol-d1774dd40624)

**调用：** `Godot.CanvasItem.QueueRedraw()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.OptionButton()`；`Godot.OptionButton.Select(int)`；`Godot.SpinBox.Apply()`；`Godot.SpinBox.SpinBox()`；`Godot.Vector2.Vector2(float, float)`；`MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`；[`NationalSpire.AvatarAssets.Load(string, int, bool, int)`](AvatarAssets.cs.md#symbol-00e6fbec5eac)；`NationalSpire.CareerAvatar.CareerAvatar()`；[`NationalSpire.CareerScreen.LaunchDateGame(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](DateGameScreen.cs.md#symbol-60cf62536a73)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.DateGames.AwaitingStart(NationalSpire.CareerData, string, string)`](DateGames.cs.md#symbol-30dbc76323ef)；[`NationalSpire.GameBridge.Characters()`](GameBridge.cs.md#symbol-1233494dda40)；[`NationalSpire.MatchRules.PreferredAscension(NationalSpire.CareerData, NationalSpire.CareerMatch)`](MatchRules.cs.md#symbol-73f327295a53)；`System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarAssets.Load(string, int, bool, int)`；`NationalSpire.CareerAvatar.Art`；`NationalSpire.CareerData.SelectedCharacter`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.RequiredAscension`；`NationalSpire.CareerScreen.LaunchDateGame(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._dateOffer`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateRunResume`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._starting`；`NationalSpire.DateGames.AwaitingStart(NationalSpire.CareerData, string, string)`；`NationalSpire.GameBridge.Characters()`；`NationalSpire.MatchRules.PreferredAscension(NationalSpire.CareerData, NationalSpire.CareerMatch)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`portrait.QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: portrait.QueueRedraw();`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`characterRow.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: characterRow.AddThemeConstantOverride("separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 16);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { Name = "DateGameCharacterRow" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { Name = "DateGameCharacterRow" }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text("出战角色", 18, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text("出战角色", 18, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(characterRow)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(characterRow);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`characterRow.AddChild(choice)`；返回值紧邻使用处：`ExpressionStatementSyntax: characterRow.AddChild(choice);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`characterRow.AddChild(portrait)`；返回值紧邻使用处：`ExpressionStatementSyntax: characterRow.AddChild(portrait);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(Text("挑战进阶", 18, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(Text("挑战进阶", 18, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(level)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(level);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`choice.AddItem(character.Title.GetFormattedText())`；返回值紧邻使用处：`ExpressionStatementSyntax: choice.AddItem(character.Title.GetFormattedText());`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { Name = "DateGameCharacter", CustomMinimumSize = new(456, 44), SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsVertical = SizeFlags.ShrinkCenter }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { Name = "DateGameCharacter", CustomMinimumSize = new(456, 44), SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsVertical = SizeFlags.ShrinkCenter }`
- `Godot.OptionButton.Select(int)`；输入表达式：`choice.Select(selected)`；返回值紧邻使用处：`ExpressionStatementSyntax: choice.Select(selected);`
- `Godot.SpinBox.Apply()`；输入表达式：`level!.Apply()`；返回值紧邻使用处：`ExpressionStatementSyntax: level!.Apply();`
- `Godot.SpinBox.SpinBox()`；输入表达式：`new SpinBox { Name = "DateGameAscension", MinValue = match.RequiredAscension, MaxValue = 10, Step = 1, Value = MatchRules.PreferredAscension(ViewData, match), CustomMinimumSize = new(160, 44) }`；返回值紧邻使用处：`AssignmentExpressionSyntax: level = new SpinBox { Name = "DateGameAscension", MinValue = match.RequiredAscension, MaxValue = 10, Step = 1, Value = MatchRules.PreferredAscension(ViewData, match), CustomMinimumSize = new(160, 44) }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(160, 44)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(160, 44)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(456, 44)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(456, 44)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(48, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(48, 48)`
- `MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；输入表达式：`character.Title.GetFormattedText()`；返回值紧邻使用处：`ArgumentSyntax: character.Title.GetFormattedText()`
- `MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；输入表达式：`characters[selected].Title.GetFormattedText()`；返回值紧邻使用处：`ArgumentSyntax: characters[selected].Title.GetFormattedText()`
- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`c.Id.ToString()`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Id.ToString() == ViewData.SelectedCharacter`
- `NationalSpire.AvatarAssets.Load(string, int, bool, int)`；输入表达式：`AvatarAssets.Load(characters[selected].Title.GetFormattedText(), 0, false)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Art = AvatarAssets.Load(characters[selected].Title.GetFormattedText(), 0, false)`
- `NationalSpire.AvatarAssets.Load(string, int, bool, int)`；输入表达式：`AvatarAssets.Load(characters[selected].Title.GetFormattedText(), 0, false)`；返回值紧邻使用处：`AssignmentExpressionSyntax: portrait.Art = AvatarAssets.Load(characters[selected].Title.GetFormattedText(), 0, false)`
- `NationalSpire.CareerAvatar.CareerAvatar()`；输入表达式：`new CareerAvatar { Name = "DateGameCharacterPortrait", Art = AvatarAssets.Load(characters[selected].Title.GetFormattedText(), 0, false), CustomMinimumSize = new(48, 48), SizeFlagsVertical = SizeFlags.ShrinkCenter, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CareerAvatar { Name = "DateGameCharacterPortrait", Art = AvatarAssets.Load(characters[selected].Title.GetFormattedText(), 0, false), CustomMinimumSize = new(48, 48), SizeFlagsVertical = SizeFlags.ShrinkCenter, MouseFilter = MouseFilterEnum.Ignore }`
- `NationalSpire.CareerScreen.LaunchDateGame(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`；输入表达式：`LaunchDateGame(match, characters[selected], (int)level.Value)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = LaunchDateGame(match, characters[selected], (int)level.Value)`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("没有可用角色。", true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("没有可用角色。", true);`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("开始约会对局", "选择本局使用的角色和进阶。", () => { if (_starting || DateGames.AwaitingStart(ViewData, _datePerson, _dateOffer)?.Id != match.Id) return false; level!.Apply(); _ = LaunchDateGame(match, characters[selected], (int)level.Value); return true; }, "开始游戏", box => { box.AddChild(Text("出战角色", 18, _ink)); var characterRow = new HBoxContainer { Name = "DateGameCharacterRow" }; characterRow.AddThemeConstantOverride("separation", 16); box.AddChild(characterRow); var portrait = new CareerAvatar { Name = "DateGameCharacterPortrait", Art = AvatarAssets.Load(characters[selected].Title.GetFormattedText(), 0, false), CustomMinimumSize = new(48, 48), SizeFlagsVertical = SizeFlags.ShrinkCenter, MouseFilter = MouseFilterEnum.Ignore }; characterRow.AddChild(portrait); var choice = new OptionButton { Name = "DateGameCharacter", CustomMinimumSize = new(456, 44), SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsVertical = SizeFlags.ShrinkCenter }; foreach (var character in characters) choice.AddItem(character.Title.GetFormattedText()); choice.Select(selected); choice.ItemSelected += i => { selected = (int)i; portrait.Art = AvatarAssets.Load(characters[selected].Title.GetFormattedText(), 0, false); portrait.QueueRedraw(); }; characterRow.AddChild(choice); var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 16); box.AddChild(row); row.AddChild(Text("挑战进阶", 18, _ink)); level = new SpinBox { Name = "DateGameAscension", MinValue = match.RequiredAscension, MaxValue = 10, Step = 1, Value = MatchRules.PreferredAscension(ViewData, match), CustomMinimumSize = new(160, 44) }; row.AddChild(level); })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("开始约会对局", "选择本局使用的角色和进阶。", () => { if (_starting || DateGames.AwaitingStart(ViewData, _datePerson, _dateOffer)?.Id != match.Id) return false; level!.Apply(); _ = LaunchDateGame(match, characters[selected], (int)level.Value); return true; }, "开始游戏", box => { box.AddChild(Text("出战角色", 18, _ink)); var characterRow = new HBoxContainer { Name = "DateGameCharacterRow" }; characterRow.AddThemeConstantOverride("separation", 16); box.AddChild(characterRow); var portrait = new CareerAvatar { Name = "DateGameCharacterPortrait", Art = AvatarAssets.Load(characters[selected].Title.GetFormattedText(), 0, false), CustomMinimumSize = new(48, 48), SizeFlagsVertical = SizeFlags.ShrinkCenter, MouseFilter = MouseFilterEnum.Ignore }; characterRow.AddChild(portrait); var choice = new OptionButton { Name = "DateGameCharacter", CustomMinimumSize = new(456, 44), SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsVertical = SizeFlags.ShrinkCenter }; foreach (var character in characters) choice.AddItem(character.Title.GetFormattedText()); choice.Select(selected); choice.ItemSelected += i => { selected = (int)i; portrait.Art = AvatarAssets.Load(characters[selected].Title.GetFormattedText(), 0, false); portrait.QueueRedraw(); }; characterRow.AddChild(choice); var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 16); box.AddChild(row); row.AddChild(Text("挑战进阶", 18, _ink)); level = new SpinBox { Name = "DateGameAscension", MinValue = match.RequiredAscension, MaxValue = 10, Step = 1, Value = MatchRules.PreferredAscension(ViewData, match), CustomMinimumSize = new(160, 44) }; row.AddChild(level); });`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("出战角色", 18, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text("出战角色", 18, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("挑战进阶", 18, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text("挑战进阶", 18, _ink)`
- `NationalSpire.DateGames.AwaitingStart(NationalSpire.CareerData, string, string)`；输入表达式：`DateGames.AwaitingStart(ViewData, _datePerson, _dateOffer)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: DateGames.AwaitingStart(ViewData, _datePerson, _dateOffer)?.Id`
- `NationalSpire.GameBridge.Characters()`；输入表达式：`GameBridge.Characters()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GameBridge.Characters()`
- `NationalSpire.MatchRules.PreferredAscension(NationalSpire.CareerData, NationalSpire.CareerMatch)`；输入表达式：`MatchRules.PreferredAscension(ViewData, match)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Value = MatchRules.PreferredAscension(ViewData, match)`
- `System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；输入表达式：`characters.FindIndex(c => c.Id.ToString() == ViewData.SelectedCharacter)`；返回值紧邻使用处：`ArgumentSyntax: characters.FindIndex(c => c.Id.ToString() == ViewData.SelectedCharacter)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, characters.FindIndex(c => c.Id.ToString() == ViewData.SelectedCharacter))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Max(0, characters.FindIndex(c => c.Id.ToString() == ViewData.SelectedCharacter))`

**赋值（含属性/字段和局部值）：**

- `Art` = `AvatarAssets.Load(characters[selected].Title.GetFormattedText(), 0, false)`
- `CustomMinimumSize` = `new(160, 44)`
- `CustomMinimumSize` = `new(456, 44)`
- `CustomMinimumSize` = `new(48, 48)`
- `MaxValue` = `10`
- `MinValue` = `match.RequiredAscension`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Name` = `"DateGameAscension"`
- `Name` = `"DateGameCharacter"`
- `Name` = `"DateGameCharacterPortrait"`
- `Name` = `"DateGameCharacterRow"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `Step` = `1`
- `Value` = `MatchRules.PreferredAscension(ViewData, match)`
- `_` = `LaunchDateGame(match, characters[selected], (int)level.Value)`
- `choice.ItemSelected` += `i => { selected = (int)i; portrait.Art = AvatarAssets.Load(characters[selected].Title.GetFormattedText(), 0, false); portrait.QueueRedraw(); }`
- `level` = `new SpinBox { Name = "DateGameAscension", MinValue = match.RequiredAscension, MaxValue = 10, Step = 1, Value = MatchRules.PreferredAscension(ViewData, match), CustomMinimumSize = new(160, 44) }`
- `portrait.Art` = `AvatarAssets.Load(characters[selected].Title.GetFormattedText(), 0, false)`
- `selected` = `(int)i`

<a id="symbol-91a1fe98cb30"></a>

## `NationalSpire.CareerScreen.DatePhone() — private void DatePhone()`

来源：源码第 71 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.Show()`；[`NationalSpire.CareerScreen.CloseDateScene()`](DateSceneScreen.cs.md#symbol-375f9bc3e86a)；[`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.SaveDateGameBookmark()`](DateGameScreen.cs.md#symbol-96b515b66a99)；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.CloseDateScene()`；`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；`NationalSpire.CareerScreen.SaveDateGameBookmark()`；`NationalSpire.CareerScreen._dateManualGameInput`；`NationalSpire.CareerScreen._dateOffer`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._datePhoneManualInput`；`NationalSpire.CareerScreen._datePhoneOffer`；`NationalSpire.CareerScreen._datePhonePerson`；`NationalSpire.CareerScreen._datePhoneReturn`；`NationalSpire.CareerScreen._dateRunResume`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.DateSceneView.InputMode`；`NationalSpire.DateSceneView.SpeakerId`；`NationalSpire.PrivateMessageCommand.Offer`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Show()`；输入表达式：`_datePhoneReturn.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: _datePhoneReturn.Show();`
- `NationalSpire.CareerScreen.CloseDateScene()`；输入表达式：`CloseDateScene()`；返回值紧邻使用处：`ExpressionStatementSyntax: CloseDateScene();`
- `NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；输入表达式：`OpenPrivateMessages(person)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenPrivateMessages(person);`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；输入表达式：`PrivateCommand("dm-date-pause", new() { Offer = _dateOffer }, () => { _datePhonePerson = _datePerson; _datePhoneOffer = _dateOffer; _datePhoneManualInput = _dateManualGameInput; var resume = _dateRunResume; _dateRunResume = null; CloseDateScene(); _dateRunResume = resume; OpenPrivateMessages(person); if (_datePhoneReturn != null) _datePhoneReturn.Show(); })`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateCommand("dm-date-pause", new() { Offer = _dateOffer }, () => { _datePhonePerson = _datePerson; _datePhoneOffer = _dateOffer; _datePhoneManualInput = _dateManualGameInput; var resume = _dateRunResume; _dateRunResume = null; CloseDateScene(); _dateRunResume = resume; OpenPrivateMessages(person); if (_datePhoneReturn != null) _datePhoneReturn.Show(); });`
- `NationalSpire.CareerScreen.SaveDateGameBookmark()`；输入表达式：`SaveDateGameBookmark()`；返回值紧邻使用处：`ExpressionStatementSyntax: SaveDateGameBookmark();`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Offer = _dateOffer }`；返回值紧邻使用处：`ArgumentSyntax: new() { Offer = _dateOffer }`

**赋值（含属性/字段和局部值）：**

- `Offer` = `_dateOffer`
- `_datePhoneManualInput` = `_dateManualGameInput`
- `_datePhoneOffer` = `_dateOffer`
- `_datePhonePerson` = `_datePerson`
- `_dateRunResume` = `null`
- `_dateRunResume` = `resume`

<a id="symbol-006d35effe08"></a>

## `NationalSpire.CareerScreen.ReturnFromDatePhone() — private void ReturnFromDatePhone()`

来源：源码第 85 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.Hide()`；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.OpenDateScene(string, bool, bool)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)；[`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`](DateSceneData.cs.md#symbol-0d3e014bcb63)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.OpenDateScene(string, bool, bool)`；`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._datePhoneManualInput`；`NationalSpire.CareerScreen._datePhoneOffer`；`NationalSpire.CareerScreen._datePhonePerson`；`NationalSpire.CareerScreen._datePhoneReturn`；`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`.Hide()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _datePhoneReturn?.Hide()`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("这场约会已经结束。", false)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("这场约会已经结束。", false);`
- `NationalSpire.CareerScreen.OpenDateScene(string, bool, bool)`；输入表达式：`OpenDateScene(offer, inputOnly: _datePhoneManualInput)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenDateScene(offer, inputOnly: _datePhoneManualInput);`
- `NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；输入表达式：`OpenPrivateMessages(person)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenPrivateMessages(person);`
- `NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；输入表达式：`DateScenes.Available(ViewData, o, conversation)`；返回值紧邻使用处：`BinaryExpressionSyntax: o.Id == offer && DateScenes.Available(ViewData, o, conversation)`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(ViewData, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(ViewData, person)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.Offers.Any(o => o.Id == offer && DateScenes.Available(ViewData, o, conversation))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !conversation.Offers.Any(o => o.Id == offer && DateScenes.Available(ViewData, o, conversation))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f7a3691c9897"></a>

## `NationalSpire.CareerScreen.ShowDateInput(bool, bool) — private void ShowDateInput(bool manualGame = false, bool keepWaiting = false)`

来源：源码第 94 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Applied()`](DateSceneHistoryScreen.cs.md#symbol-4386f1155e7c)；[`NationalSpire.CareerScreen.EditPreviousDateScene()`](DateSceneScreen.cs.md#symbol-68bbfe92ebcf)；[`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)；[`NationalSpire.CareerScreen.ShowDateGameChoices(NationalSpire.CareerMatch)`](DateGameScreen.cs.md#symbol-d1774dd40624)；[`NationalSpire.CareerScreen.ShowDateLine()`](DateSceneScreen.cs.md#symbol-1580b0be190e)；[`NationalSpire.CareerScreen.StartDateGameReply(NationalSpire.CareerMatch, string)`](DateGameScreen.cs.md#symbol-8963173330c9)

**调用：** [`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerScreen.CanResumeDateGame()`](DateGameScreen.cs.md#symbol-936de630737d)；[`NationalSpire.CareerScreen.ChooseDateReply(string)`](DateGameScreen.cs.md#symbol-d59ce1085050)；[`NationalSpire.DateSceneView.SetReplyChoices(string, System.Action, string, System.Action)`](DateSceneView.cs.md#symbol-697ad465ef9e)；[`NationalSpire.DateSceneView.ShowInput(string, bool, bool)`](DateSceneView.cs.md#symbol-4f0d075ed97b)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`；`string.IsNullOrWhiteSpace(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.CanResumeDateGame()`；`NationalSpire.CareerScreen.ChooseDateReply(string)`；`NationalSpire.CareerScreen.DateSceneExitChoices()`；`NationalSpire.CareerScreen.ResumeDateGame()`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._dateEditingTurn`；`NationalSpire.CareerScreen._dateInputTurn`；`NationalSpire.CareerScreen._dateManualGameInput`；`NationalSpire.CareerScreen._dateOffer`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.DateSceneView.SetReplyChoices(string, System.Action, string, System.Action)`；`NationalSpire.DateSceneView.ShowInput(string, bool, bool)`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.Scene`；`NationalSpire.PrivateTurn.SceneChoices`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(ViewData)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.Name(ViewData)`
- `NationalSpire.CareerScreen.CanResumeDateGame()`；输入表达式：`CanResumeDateGame()`；返回值紧邻使用处：`BinaryExpressionSyntax: _dateManualGameInput && CanResumeDateGame()`
- `NationalSpire.CareerScreen.ChooseDateReply(string)`；输入表达式：`ChooseDateReply(choices[0])`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ChooseDateReply(choices[0])`
- `NationalSpire.CareerScreen.ChooseDateReply(string)`；输入表达式：`ChooseDateReply(choices[1])`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ChooseDateReply(choices[1])`
- `NationalSpire.DateSceneView.SetReplyChoices(string, System.Action, string, System.Action)`；输入表达式：`_dateView.SetReplyChoices("返回游戏", ResumeDateGame, "结束约会", DateSceneExitChoices)`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.SetReplyChoices("返回游戏", ResumeDateGame, "结束约会", DateSceneExitChoices);`
- `NationalSpire.DateSceneView.SetReplyChoices(string, System.Action, string, System.Action)`；输入表达式：`_dateView.SetReplyChoices(choices[0], () => ChooseDateReply(choices[0]), choices[1], () => ChooseDateReply(choices[1]))`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.SetReplyChoices(choices[0], () => ChooseDateReply(choices[0]), choices[1], () => ChooseDateReply(choices[1]));`
- `NationalSpire.DateSceneView.ShowInput(string, bool, bool)`；输入表达式：`_dateView.ShowInput(CareerEngine.Name(ViewData), keepWaiting)`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.ShowInput(CareerEngine.Name(ViewData), keepWaiting);`
- `NationalSpire.DateSceneView.ShowInput(string, bool, bool)`；输入表达式：`_dateView.ShowInput(CareerEngine.Name(ViewData), keepWaiting, showChoices: false)`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.ShowInput(CareerEngine.Name(ViewData), keepWaiting, showChoices: false);`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(ViewData, _datePerson)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Conversation(ViewData, _datePerson).Turns`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`.Where(t => !string.IsNullOrWhiteSpace(t)).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: .Where(t => !string.IsNullOrWhiteSpace(t)).Distinct().Take`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateMessages.Conversation(ViewData, _datePerson).Turns.LastOrDefault(t => t.Scene?.OfferId == _dateOffer && !t.ReplyDeleted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(ViewData, _datePerson).Turns.LastOrDefault(t => t.Scene?.OfferId == _dateOffer && !t.ReplyDeleted)`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`.Where(t => !string.IsNullOrWhiteSpace(t)).Distinct().Take(2)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: .Where(t => !string.IsNullOrWhiteSpace(t)).Distinct().Take(2).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`.Where(t => !string.IsNullOrWhiteSpace(t)).Distinct().Take(2).ToList()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .SceneChoices?.Where(t => !string.IsNullOrWhiteSpace(t)).Distinct().Take(2).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Where(t => !string.IsNullOrWhiteSpace(t))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: .Where(t => !string.IsNullOrWhiteSpace(t)).Distinct`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`choices.Add(fallback)`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.Add(fallback);`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`choices.Contains(fallback)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !choices.Contains(fallback)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(t)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !string.IsNullOrWhiteSpace(t)`

**赋值（含属性/字段和局部值）：**

- `_dateInputTurn` = `turn?.Id ?? ""`
- `_dateManualGameInput` = `true`

<a id="symbol-d59ce1085050"></a>

## `NationalSpire.CareerScreen.ChooseDateReply(string) — private void ChooseDateReply(string text)`

来源：源码第 112 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ShowDateInput(bool, bool)`](DateGameScreen.cs.md#symbol-f7a3691c9897)

**调用：** [`NationalSpire.CareerScreen.SendDateScene()`](DateSceneScreen.cs.md#symbol-b811d23c8af3)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Func<TResult>.Invoke()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.SendDateScene()`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._dateMemory`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.DateMemoryRecorder.PendingChoice`；`NationalSpire.DateSceneView.Blocked`；`NationalSpire.DateSceneView.Editor`；`NationalSpire.DateSceneView.InputMode`；`NationalSpire.DateSceneView.Status`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateTurn.Status`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.SendDateScene()`；输入表达式：`SendDateScene()`；返回值紧邻使用处：`ExpressionStatementSyntax: SendDateScene();`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(ViewData, _datePerson)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Conversation(ViewData, _datePerson).Turns`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateMessages.Conversation(ViewData, _datePerson).Turns.Any(t => t.Status is "queued" or "sending")`；返回值紧邻使用处：`IfStatementSyntax: if (PrivateMessages.Conversation(ViewData, _datePerson).Turns.Any(t => t.Status is "queued" or "sending")) { _dateView.Status.Text = "当前回复还在生成，请等待完成。"; return; }`
- `System.Func<TResult>.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _dateView.Blocked?.Invoke()`

**赋值（含属性/字段和局部值）：**

- `_dateMemory.PendingChoice` = `text`
- `_dateView.Editor.Text` = `text`
- `_dateView.Status.Text` = `"当前回复还在生成，请等待完成。"`

<a id="symbol-8963173330c9"></a>

## `NationalSpire.CareerScreen.StartDateGameReply(NationalSpire.CareerMatch, string) — private void StartDateGameReply(CareerMatch match, string reason)`

来源：源码第 120 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenRunDate(MegaCrit.Sts2.Core.Nodes.NRun, NationalSpire.CareerMatch, System.Action, bool)`](DateGameScreen.cs.md#symbol-c74330b4dd26)；[`NationalSpire.CareerScreen.ReturnToDate(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu)`](DateGameReturn.cs.md#symbol-f14ac682e7c3)

**调用：** [`NationalSpire.CareerScreen.CanResumeDateGame()`](DateGameScreen.cs.md#symbol-936de630737d)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.SceneRequest(bool)`](DateSceneScreen.cs.md#symbol-277baf4e7cb8)；[`NationalSpire.CareerScreen.ShowDateInput(bool, bool)`](DateGameScreen.cs.md#symbol-f7a3691c9897)；[`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.DateSceneView.ShowWaiting(string, bool)`](DateSceneView.cs.md#symbol-c6c25a66fde3)；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMatch.DateGame`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerScreen.CanResumeDateGame()`；`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；`NationalSpire.CareerScreen.SceneRequest(bool)`；`NationalSpire.CareerScreen.ShowDateInput(bool, bool)`；`NationalSpire.CareerScreen.TickDateScene()`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._dateManualGameInput`；`NationalSpire.CareerScreen._dateState`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.DateGameState.ReturnPending`；`NationalSpire.DateSceneRequest.GameEvent`；`NationalSpire.DateSceneRequest.GameInvitation`；`NationalSpire.DateSceneRequest.GameMatchId`；`NationalSpire.DateSceneView.ShowWaiting(string, bool)`；`NationalSpire.DateSceneView.Status`；`NationalSpire.PrivateMessageCommand.Scene`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.CanResumeDateGame()`；输入表达式：`CanResumeDateGame()`；返回值紧邻使用处：`ArgumentSyntax: manualGame: CanResumeDateGame()`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；输入表达式：`PrivateCommand("dm-date-game-next", new() { Scene = request }, () => { accepted = true; _dateState = ""; TickDateScene(); if (reason == "result" && match.DateGame is { } game) { game.ReturnPending = false; CareerStore.Save(ViewData); } })`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateCommand("dm-date-game-next", new() { Scene = request }, () => { accepted = true; _dateState = ""; TickDateScene(); if (reason == "result" && match.DateGame is { } game) { game.ReturnPending = false; CareerStore.Save(ViewData); } });`
- `NationalSpire.CareerScreen.SceneRequest(bool)`；输入表达式：`SceneRequest()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = SceneRequest()`
- `NationalSpire.CareerScreen.ShowDateInput(bool, bool)`；输入表达式：`ShowDateInput(manualGame: CanResumeDateGame())`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowDateInput(manualGame: CanResumeDateGame());`
- `NationalSpire.CareerScreen.TickDateScene()`；输入表达式：`TickDateScene()`；返回值紧邻使用处：`ExpressionStatementSyntax: TickDateScene();`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(ViewData)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(ViewData);`
- `NationalSpire.DateSceneView.ShowWaiting(string, bool)`；输入表达式：`_dateView.ShowWaiting("正在根据对局进程继续对话…", false)`；返回值紧邻使用处：`ExpressionStatementSyntax: _dateView.ShowWaiting("正在根据对局进程继续对话…", false);`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Scene = request }`；返回值紧邻使用处：`ArgumentSyntax: new() { Scene = request }`

**赋值（含属性/字段和局部值）：**

- `Scene` = `request`
- `_dateManualGameInput` = `false`
- `_dateState` = `""`
- `_dateView.Status.Text` = `error`
- `accepted` = `true`
- `game.ReturnPending` = `false`
- `request.GameEvent` = `reason`
- `request.GameInvitation` = `false`
- `request.GameMatchId` = `match.Id`

<a id="symbol-60cf62536a73"></a>

## `NationalSpire.CareerScreen.LaunchDateGame(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int) — private async Task LaunchDateGame(CareerMatch match, MegaCrit.Sts2.Core.Models.CharacterModel character, int ascension)`

来源：源码第 138 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DateGameStartDialog(NationalSpire.CareerMatch)`](DateGameScreen.cs.md#symbol-c88ac7d5c81a)

**调用：** `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.SaveDateGameBookmark()`](DateGameScreen.cs.md#symbol-96b515b66a99)；[`NationalSpire.DateGameVoices.Default(NationalSpire.CareerData, string)`](DateGameVoices.cs.md#symbol-b457de19f0a7)；[`NationalSpire.DateGames.AwaitingStart(NationalSpire.CareerData, string, string)`](DateGames.cs.md#symbol-30dbc76323ef)；[`NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`](DateSceneAssets.cs.md#symbol-57fe620f4cc9)；[`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](GameBridge.cs.md#symbol-b93ed89d4fc6)；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMatch.DateGame`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.SaveDateGameBookmark()`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._dateOffer`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateRunResume`；`NationalSpire.CareerScreen._starting`；`NationalSpire.DateGameState.People`；`NationalSpire.DateGameState.Voices`；`NationalSpire.DateGameVoices.Default(NationalSpire.CareerData, string)`；`NationalSpire.DateGameVoices.Ids`；`NationalSpire.DateGames.AwaitingStart(NationalSpire.CareerData, string, string)`；`NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`；`NationalSpire.DateSceneAssets.GameVoice`；`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(this)`；返回值紧邻使用处：`BinaryExpressionSyntax: error != null && IsInstanceValid(this)`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(this)`；返回值紧邻使用处：`IfStatementSyntax: if (IsInstanceValid(this)) Notice("启动约会对局失败：" + e.Message, true);`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("启动约会对局失败：" + e.Message, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("启动约会对局失败：" + e.Message, true);`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(error, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(error, true);`
- `NationalSpire.CareerScreen.SaveDateGameBookmark()`；输入表达式：`SaveDateGameBookmark()`；返回值紧邻使用处：`ExpressionStatementSyntax: SaveDateGameBookmark();`
- `NationalSpire.DateGameVoices.Default(NationalSpire.CareerData, string)`；输入表达式：`DateGameVoices.Default(ViewData, person)`；返回值紧邻使用处：`ConditionalExpressionSyntax: DateGameVoices.Ids.Contains(art.GameVoice) ? art.GameVoice : DateGameVoices.Default(ViewData, person)`
- `NationalSpire.DateGames.AwaitingStart(NationalSpire.CareerData, string, string)`；输入表达式：`DateGames.AwaitingStart(ViewData, _datePerson, _dateOffer)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: DateGames.AwaitingStart(ViewData, _datePerson, _dateOffer)?.Id`
- `NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`；输入表达式：`DateSceneAssetStore.Read(ViewData, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateSceneAssetStore.Read(ViewData, person)`
- `NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`；输入表达式：`GameBridge.StartMatch(match, character, ascension)`；返回值紧邻使用处：`AwaitExpressionSyntax: await GameBridge.StartMatch(match, character, ascension)`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`DateGameVoices.Ids.Contains(art.GameVoice)`；返回值紧邻使用处：`ConditionalExpressionSyntax: DateGameVoices.Ids.Contains(art.GameVoice) ? art.GameVoice : DateGameVoices.Default(ViewData, person)`

**赋值（含属性/字段和局部值）：**

- `_starting` = `false`
- `_starting` = `true`
- `game.Voices[person]` = `DateGameVoices.Ids.Contains(art.GameVoice) ? art.GameVoice : DateGameVoices.Default(ViewData, person)`

<a id="symbol-c74330b4dd26"></a>

## `NationalSpire.CareerScreen.OpenRunDate(MegaCrit.Sts2.Core.Nodes.NRun, NationalSpire.CareerMatch, System.Action, bool) — internal static bool OpenRunDate(NRun run, CareerMatch match, Action resume, bool respond = false)`

来源：源码第 155 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.OpenDateGameChat(double)`](LiveDateGame.cs.md#symbol-6383bcf560b6)

**调用：** [`NationalSpire.CareerScreen.Close(bool)`](CareerScreen.cs.md#symbol-9bfd6bc6f6d3)；[`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)；[`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.OpenView(Godot.Control, NationalSpire.ICareerSession?, string?)`](CareerScreen.cs.md#symbol-2b6ef58a9693)；[`NationalSpire.CareerScreen.StartDateGameReply(NationalSpire.CareerMatch, string)`](DateGameScreen.cs.md#symbol-8963173330c9)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMatch.DateGame`；`NationalSpire.CareerScreen.Close(bool)`；`NationalSpire.CareerScreen.Current`；`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`；`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；`NationalSpire.CareerScreen.OpenView(Godot.Control, NationalSpire.ICareerSession?, string?)`；`NationalSpire.CareerScreen.StartDateGameReply(NationalSpire.CareerMatch, string)`；`NationalSpire.CareerScreen._datePresentationPending`；`NationalSpire.CareerScreen._dateRunResume`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.DateGameState.Host`；`NationalSpire.DateGameState.OfferId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.Close(bool)`；输入表达式：`failed.Close(force: true)`；返回值紧邻使用处：`ExpressionStatementSyntax: failed.Close(force: true);`
- `NationalSpire.CareerScreen.Close(bool)`；输入表达式：`screen.Close(force: true)`；返回值紧邻使用处：`ExpressionStatementSyntax: screen.Close(force: true);`
- `NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`；输入表达式：`screen.OpenDateSceneReady(game.OfferId, !respond, respond, () => { if (respond) screen.StartDateGameReply(match, "request"); })`；返回值紧邻使用处：`ExpressionStatementSyntax: screen.OpenDateSceneReady(game.OfferId, !respond, respond, () => { if (respond) screen.StartDateGameReply(match, "request"); });`
- `NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；输入表达式：`screen.OpenPrivateMessages(game.Host)`；返回值紧邻使用处：`ExpressionStatementSyntax: screen.OpenPrivateMessages(game.Host);`
- `NationalSpire.CareerScreen.OpenView(Godot.Control, NationalSpire.ICareerSession?, string?)`；输入表达式：`OpenView(run.GlobalUi, null, "首页")`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenView(run.GlobalUi, null, "首页");`
- `NationalSpire.CareerScreen.StartDateGameReply(NationalSpire.CareerMatch, string)`；输入表达式：`screen.StartDateGameReply(match, "request")`；返回值紧邻使用处：`ExpressionStatementSyntax: screen.StartDateGameReply(match, "request");`

**赋值（含属性/字段和局部值）：**

- `screen._dateRunResume` = `resume`

<a id="symbol-936de630737d"></a>

## `NationalSpire.CareerScreen.CanResumeDateGame() — private bool CanResumeDateGame()`

来源：源码第 174 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Applied()`](DateSceneHistoryScreen.cs.md#symbol-4386f1155e7c)；[`NationalSpire.CareerScreen.DateSceneExitChoices()`](DateSceneScreen.cs.md#symbol-52133982acce)；[`NationalSpire.CareerScreen.ResumeDateGame()`](DateGameScreen.cs.md#symbol-fa0cab10e943)；[`NationalSpire.CareerScreen.ShowDateInput(bool, bool)`](DateGameScreen.cs.md#symbol-f7a3691c9897)；[`NationalSpire.CareerScreen.StartDateGameReply(NationalSpire.CareerMatch, string)`](DateGameScreen.cs.md#symbol-8963173330c9)；[`NationalSpire.CareerScreen.TickDateGameActions()`](DateGameScreen.cs.md#symbol-c55c74e4c1fe)

**调用：** [`NationalSpire.DateGames.InProgress(NationalSpire.CareerData, string, string)`](DateGames.cs.md#symbol-a63bde99754a)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._dateOffer`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateRunResume`；`NationalSpire.CareerScreen._dateView`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.DateGames.InProgress(NationalSpire.CareerData, string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGames.InProgress(NationalSpire.CareerData, string, string)`；输入表达式：`DateGames.InProgress(ViewData, _datePerson, _dateOffer)`；返回值紧邻使用处：`BinaryExpressionSyntax: DateGames.InProgress(ViewData, _datePerson, _dateOffer) != null`

**赋值（含属性/字段和局部值）：**


<a id="symbol-fa0cab10e943"></a>

## `NationalSpire.CareerScreen.ResumeDateGame() — private void ResumeDateGame()`

来源：源码第 176 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DateSceneExitChoices()`](DateSceneScreen.cs.md#symbol-52133982acce)

**调用：** [`NationalSpire.CareerScreen.CanResumeDateGame()`](DateGameScreen.cs.md#symbol-936de630737d)；[`NationalSpire.CareerScreen.Close(bool)`](CareerScreen.cs.md#symbol-9bfd6bc6f6d3)；[`NationalSpire.CareerScreen.CloseDateScene()`](DateSceneScreen.cs.md#symbol-375f9bc3e86a)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.SaveDateGameBookmark()`](DateGameScreen.cs.md#symbol-96b515b66a99)；[`NationalSpire.DateGameReturn.PrepareSavedResume(NationalSpire.CareerData, string, string)`](DateGameReturn.cs.md#symbol-5f5af2e8993e)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；`System.Action.Invoke()`；`System.Exception.GetBaseException()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.CanResumeDateGame()`；`NationalSpire.CareerScreen.Close(bool)`；`NationalSpire.CareerScreen.CloseDateScene()`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；`NationalSpire.CareerScreen.SaveDateGameBookmark()`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._dateOffer`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateRunResume`；`NationalSpire.CareerScreen._starting`；`NationalSpire.DateGameReturn.PrepareSavedResume(NationalSpire.CareerData, string, string)`；`NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.PrivateMessageCommand.Offer`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.CanResumeDateGame()`；输入表达式：`CanResumeDateGame()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CanResumeDateGame()`
- `NationalSpire.CareerScreen.Close(bool)`；输入表达式：`Close(force: true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Close(force: true);`
- `NationalSpire.CareerScreen.CloseDateScene()`；输入表达式：`CloseDateScene()`；返回值紧邻使用处：`ExpressionStatementSyntax: CloseDateScene();`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("恢复对局失败：" + e.GetBaseException().Message, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("恢复对局失败：" + e.GetBaseException().Message, true);`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；输入表达式：`PrivateCommand("dm-date-pause", new() { Offer = _dateOffer })`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateCommand("dm-date-pause", new() { Offer = _dateOffer });`
- `NationalSpire.CareerScreen.SaveDateGameBookmark()`；输入表达式：`SaveDateGameBookmark()`；返回值紧邻使用处：`ExpressionStatementSyntax: SaveDateGameBookmark();`
- `NationalSpire.DateGameReturn.PrepareSavedResume(NationalSpire.CareerData, string, string)`；输入表达式：`DateGameReturn.PrepareSavedResume(ViewData, _datePerson, _dateOffer)`；返回值紧邻使用处：`AssignmentExpressionSyntax: loadSaved = DateGameReturn.PrepareSavedResume(ViewData, _datePerson, _dateOffer)`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("date.game.bookmark", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("date.game.bookmark", e);`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("date.game.resume.prepare", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("date.game.resume.prepare", e);`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Offer = _dateOffer }`；返回值紧邻使用处：`ArgumentSyntax: new() { Offer = _dateOffer }`
- `System.Action.Invoke()`；输入表达式：`loadSaved()`；返回值紧邻使用处：`ExpressionStatementSyntax: loadSaved();`
- `System.Exception.GetBaseException()`；输入表达式：`e.GetBaseException()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: e.GetBaseException().Message`

**赋值（含属性/字段和局部值）：**

- `Offer` = `_dateOffer`
- `_starting` = `false`
- `_starting` = `true`
- `loadSaved` = `DateGameReturn.PrepareSavedResume(ViewData, _datePerson, _dateOffer)`

<a id="symbol-96b515b66a99"></a>

## `NationalSpire.CareerScreen.SaveDateGameBookmark() — private void SaveDateGameBookmark()`

来源：源码第 204 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DatePhone()`](DateGameScreen.cs.md#symbol-91a1fe98cb30)；[`NationalSpire.CareerScreen.LaunchDateGame(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](DateGameScreen.cs.md#symbol-60cf62536a73)；[`NationalSpire.CareerScreen.ResumeDateGame()`](DateGameScreen.cs.md#symbol-fa0cab10e943)

**调用：** [`NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`](DateSceneAssets.cs.md#symbol-2bf1f40a912e)；`NationalSpire.DateSceneBookmark.DateSceneBookmark()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._dateAssets`；`NationalSpire.CareerScreen._dateIndex`；`NationalSpire.CareerScreen._dateOffer`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._dateReply`；`NationalSpire.CareerScreen._dateState`；`NationalSpire.CareerScreen._dateTurn`；`NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`；`NationalSpire.DateSceneAssets.Bookmarks`；`NationalSpire.DateSceneBookmark.Index`；`NationalSpire.DateSceneBookmark.ReplyHash`；`NationalSpire.DateSceneBookmark.Turn`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`；输入表达式：`DateSceneAssetStore.Save(ViewData, _datePerson, _dateAssets)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateSceneAssetStore.Save(ViewData, _datePerson, _dateAssets);`
- `NationalSpire.DateSceneBookmark.DateSceneBookmark()`；输入表达式：`new() { Turn = _dateTurn, ReplyHash = _dateReply, Index = _dateIndex }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dateAssets.Bookmarks[_dateOffer] = new() { Turn = _dateTurn, ReplyHash = _dateReply, Index = _dateIndex }`

**赋值（含属性/字段和局部值）：**

- `Index` = `_dateIndex`
- `ReplyHash` = `_dateReply`
- `Turn` = `_dateTurn`
- `_dateAssets.Bookmarks[_dateOffer]` = `new() { Turn = _dateTurn, ReplyHash = _dateReply, Index = _dateIndex }`

<a id="symbol-0a1b70a243b1"></a>

## `NationalSpire.CareerScreen.EditDateGameRules() — private void EditDateGameRules()`

来源：源码第 210 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`Fill()`](DateGameScreen.cs.md#symbol-70f585bf64d5)；`Godot.CheckBox.CheckBox()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OS.ShellShowInFileManager(string, bool)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.Clear()`；`Godot.OptionButton.OptionButton()`；`Godot.OptionButton.Select(int)`；`Godot.SpinBox.SpinBox()`；`Godot.TextEdit.TextEdit()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.CareerData.CareerData()`；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.PickNestedFile(string, string[], System.Action<string>, System.Action<string[]>?)`](CareerFilePicker.cs.md#symbol-ca0ccac08c64)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.Coop.CoopJson.Copy<T>(T)`](Coop/CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.DateGameContent.Apply(NationalSpire.CareerData, NationalSpire.DateGameContent.Bundle)`](DateGameContent.cs.md#symbol-5a89da7cbb82)；[`NationalSpire.DateGameContent.Import(NationalSpire.CareerData, string)`](DateGameContent.cs.md#symbol-2c2e135d0e20)；[`NationalSpire.DateGameContent.Snapshot(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.DateGameRule>?)`](DateGameContent.cs.md#symbol-f9fa9ec59680)；[`NationalSpire.DateGameContent.Write(string, NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.DateGameRule>?)`](DateGameContent.cs.md#symbol-7f516f204c6d)；[`NationalSpire.DateGames.Label(string)`](DateGames.cs.md#symbol-4695e14bac35)；[`NationalSpire.DateGames.Upgrade(NationalSpire.CareerData)`](DateGames.cs.md#symbol-2c3d1fff3942)；`NationalSpire.DateVoiceEdits.DateVoiceEdits()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.IO.File.ReadAllText(string)`；`System.IO.FileInfo.FileInfo(string)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`string.Split(char, System.StringSplitOptions)`

**字段、属性、事件及方法组引用：** `Fill()`；`NationalSpire.CareerData.DateGameRules`；`NationalSpire.CareerData.DateGameTiming`；`NationalSpire.CareerData.DateGameVoiceEdits`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.PickNestedFile(string, string[], System.Action<string>, System.Action<string[]>?)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.DateGameContent.Apply(NationalSpire.CareerData, NationalSpire.DateGameContent.Bundle)`；`NationalSpire.DateGameContent.Import(NationalSpire.CareerData, string)`；`NationalSpire.DateGameContent.Snapshot(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.DateGameRule>?)`；`NationalSpire.DateGameContent.Write(string, NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.DateGameRule>?)`；`NationalSpire.DateGameRule.Chat`；`NationalSpire.DateGameRule.Enabled`；`NationalSpire.DateGameRule.Threshold`；`NationalSpire.DateGameRule.Trigger`；`NationalSpire.DateGameVoices.Ids`；`NationalSpire.DateGameVoices.Labels`；`NationalSpire.DateGames.Label(string)`；`NationalSpire.DateGames.Upgrade(NationalSpire.CareerData)`；`NationalSpire.DateVoiceEdits.Triggers`；`NationalSpire.PromptTransfer.Desktop`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Fill()`；输入表达式：`Fill()`；返回值紧邻使用处：`ExpressionStatementSyntax: Fill();`
- `Godot.CheckBox.CheckBox()`；输入表达式：`new CheckBox { Text = "启用事件" }`；返回值紧邻使用处：`AssignmentExpressionSyntax: enabled = new CheckBox { Text = "启用事件" }`
- `Godot.CheckBox.CheckBox()`；输入表达式：`new CheckBox { Text = "请求聊天" }`；返回值紧邻使用处：`AssignmentExpressionSyntax: chat = new CheckBox { Text = "请求聊天" }`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`transfer.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: transfer.AddThemeConstantOverride("separation", 16);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text("阈值（单位见事件名称；其余事件忽略此项）", 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text("阈值（单位见事件名称；其余事件忽略此项）", 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(flags)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(flags);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(lines)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(lines);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(selector)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(selector);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(status)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(status);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(threshold)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(threshold);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(transfer)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(transfer);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(voices)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(voices);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`flags.AddChild(chat)`；返回值紧邻使用处：`ExpressionStatementSyntax: flags.AddChild(chat);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`flags.AddChild(enabled)`；返回值紧邻使用处：`ExpressionStatementSyntax: flags.AddChild(enabled);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`transfer.AddChild(Button("导入台词JSON", () => PickNestedFile("导入约会对局台词", [".json"], file => { try { if (new FileInfo(file).Length > 24 * 1024 * 1024) throw new InvalidDataException("文件超过24MB。"); working.DateGameRules = rules; string result = DateGameContent.Import(working, File.ReadAllText(file)); rules = working.DateGameRules; index = 0; selector.Clear(); foreach (var r in rules) selector.AddItem(DateGames.Label(r.Trigger)); selector.Select(0); Fill(); status.Text = result + "；点击保存应用。"; } catch (Exception e) { status.Text = "导入失败，原设置已保留：" + e.Message; } }), 220))`；返回值紧邻使用处：`ExpressionStatementSyntax: transfer.AddChild(Button("导入台词JSON", () => PickNestedFile("导入约会对局台词", [".json"], file => { try { if (new FileInfo(file).Length > 24 * 1024 * 1024) throw new InvalidDataException("文件超过24MB。"); working.DateGameRules = rules; string result = DateGameContent.Import(working, File.ReadAllText(file)); rules = working.DateGameRules; index = 0; selector.Clear(); foreach (var r in rules) selector.AddItem(DateGames.Label(r.Trigger)); selector.Select(0); Fill(); status.Text = result + "；点击保存应用。"; } catch (Exception e) { status.Text = "导入失败，原设置已保留：" + e.Message; } }), 220));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`transfer.AddChild(Button("导出全部台词", () => { try { string path = DateGameContent.Write(PromptTransfer.Desktop, working, rules); status.Text = "已导出：" + path; OS.ShellShowInFileManager(path); } catch (Exception e) { status.Text = "导出失败：" + e.Message; } }, 220))`；返回值紧邻使用处：`ExpressionStatementSyntax: transfer.AddChild(Button("导出全部台词", () => { try { string path = DateGameContent.Write(PromptTransfer.Desktop, working, rules); status.Text = "已导出：" + path; OS.ShellShowInFileManager(path); } catch (Exception e) { status.Text = "导出失败：" + e.Message; } }, 220));`
- `Godot.OS.ShellShowInFileManager(string, bool)`；输入表达式：`OS.ShellShowInFileManager(path)`；返回值紧邻使用处：`ExpressionStatementSyntax: OS.ShellShowInFileManager(path);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`selector.AddItem(DateGames.Label(r.Trigger))`；返回值紧邻使用处：`ExpressionStatementSyntax: selector.AddItem(DateGames.Label(r.Trigger));`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`voices.AddItem(name)`；返回值紧邻使用处：`ExpressionStatementSyntax: voices.AddItem(name);`
- `Godot.OptionButton.Clear()`；输入表达式：`selector.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: selector.Clear();`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { CustomMinimumSize = new(680, 44) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { CustomMinimumSize = new(680, 44) }`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { Name = "DateRulePersonality", CustomMinimumSize = new(680, 44) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { Name = "DateRulePersonality", CustomMinimumSize = new(680, 44) }`
- `Godot.OptionButton.Select(int)`；输入表达式：`selector.Select(0)`；返回值紧邻使用处：`ExpressionStatementSyntax: selector.Select(0);`
- `Godot.SpinBox.SpinBox()`；输入表达式：`new SpinBox { MinValue = 0, MaxValue = 3600, Step = 1, CustomMinimumSize = new(180, 44) }`；返回值紧邻使用处：`AssignmentExpressionSyntax: threshold = new SpinBox { MinValue = 0, MaxValue = 3600, Step = 1, CustomMinimumSize = new(180, 44) }`
- `Godot.TextEdit.TextEdit()`；输入表达式：`new TextEdit { Name = "DateRuleLines", CustomMinimumSize = new(680, 240), WrapMode = TextEdit.LineWrappingMode.Boundary }`；返回值紧邻使用处：`AssignmentExpressionSyntax: lines = new TextEdit { Name = "DateRuleLines", CustomMinimumSize = new(680, 240), WrapMode = TextEdit.LineWrappingMode.Boundary }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(180, 44)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(180, 44)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(680, 240)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(680, 240)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(680, 44)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(680, 44)`
- `NationalSpire.CareerData.CareerData()`；输入表达式：`new CareerData { DateGameRules = Coop.CoopJson.Copy(data.DateGameRules), DateGameTiming = Coop.CoopJson.Copy(data.DateGameTiming), DateGameVoiceEdits = Coop.CoopJson.Copy(data.DateGameVoiceEdits) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CareerData { DateGameRules = Coop.CoopJson.Copy(data.DateGameRules), DateGameTiming = Coop.CoopJson.Copy(data.DateGameTiming), DateGameVoiceEdits = Coop.CoopJson.Copy(data.DateGameVoiceEdits) }`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("导入台词JSON", () => PickNestedFile("导入约会对局台词", [".json"], file => { try { if (new FileInfo(file).Length > 24 * 1024 * 1024) throw new InvalidDataException("文件超过24MB。"); working.DateGameRules = rules; string result = DateGameContent.Import(working, File.ReadAllText(file)); rules = working.DateGameRules; index = 0; selector.Clear(); foreach (var r in rules) selector.AddItem(DateGames.Label(r.Trigger)); selector.Select(0); Fill(); status.Text = result + "；点击保存应用。"; } catch (Exception e) { status.Text = "导入失败，原设置已保留：" + e.Message; } }), 220)`；返回值紧邻使用处：`ArgumentSyntax: Button("导入台词JSON", () => PickNestedFile("导入约会对局台词", [".json"], file => { try { if (new FileInfo(file).Length > 24 * 1024 * 1024) throw new InvalidDataException("文件超过24MB。"); working.DateGameRules = rules; string result = DateGameContent.Import(working, File.ReadAllText(file)); rules = working.DateGameRules; index = 0; selector.Clear(); foreach (var r in rules) selector.AddItem(DateGames.Label(r.Trigger)); selector.Select(0); Fill(); status.Text = result + "；点击保存应用。"; } catch (Exception e) { status.Text = "导入失败，原设置已保留：" + e.Message; } }), 220)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("导出全部台词", () => { try { string path = DateGameContent.Write(PromptTransfer.Desktop, working, rules); status.Text = "已导出：" + path; OS.ShellShowInFileManager(path); } catch (Exception e) { status.Text = "导出失败：" + e.Message; } }, 220)`；返回值紧邻使用处：`ArgumentSyntax: Button("导出全部台词", () => { try { string path = DateGameContent.Write(PromptTransfer.Desktop, working, rules); status.Text = "已导出：" + path; OS.ShellShowInFileManager(path); } catch (Exception e) { status.Text = "导出失败：" + e.Message; } }, 220)`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("保存失败：" + e.Message, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("保存失败：" + e.Message, true);`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("约会对局的发言规则可在单人生涯中编辑。", false)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("约会对局的发言规则可在单人生涯中编辑。", false);`
- `NationalSpire.CareerScreen.PickNestedFile(string, string[], System.Action<string>, System.Action<string[]>?)`；输入表达式：`PickNestedFile("导入约会对局台词", [".json"], file => { try { if (new FileInfo(file).Length > 24 * 1024 * 1024) throw new InvalidDataException("文件超过24MB。"); working.DateGameRules = rules; string result = DateGameContent.Import(working, File.ReadAllText(file)); rules = working.DateGameRules; index = 0; selector.Clear(); foreach (var r in rules) selector.AddItem(DateGames.Label(r.Trigger)); selector.Select(0); Fill(); status.Text = result + "；点击保存应用。"; } catch (Exception e) { status.Text = "导入失败，原设置已保留：" + e.Message; } })`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => PickNestedFile("导入约会对局台词", [".json"], file => { try { if (new FileInfo(file).Length > 24 * 1024 * 1024) throw new InvalidDataException("文件超过24MB。"); working.DateGameRules = rules; string result = DateGameContent.Import(working, File.ReadAllText(file)); rules = working.DateGameRules; index = 0; selector.Clear(); foreach (var r in rules) selector.AddItem(DateGames.Label(r.Trigger)); selector.Select(0); Fill(); status.Text = result + "；点击保存应用。"; } catch (Exception e) { status.Text = "导入失败，原设置已保留：" + e.Message; } })`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("约会对局 · 发言与聊天触发", "选择性格后，每行填写一句该性格的完整事件台词。触发条件共用；请求聊天时先播出台词，玩家接受后在当前动作结束时打开约会。", () => { try { var bundle = DateGameContent.Snapshot(working, rules); DateGameContent.Apply(data, bundle); CareerStore.Save(data); return true; } catch (Exception e) { Notice("保存失败：" + e.Message, true); return false; } }, "保存", box => { var selector = new OptionButton { CustomMinimumSize = new(680, 44) }; foreach (var r in rules) selector.AddItem(DateGames.Label(r.Trigger)); box.AddChild(selector); var voices = new OptionButton { Name = "DateRulePersonality", CustomMinimumSize = new(680, 44) }; foreach (string name in DateGameVoices.Labels) voices.AddItem(name); box.AddChild(voices); voices.ItemSelected += i => { profile = DateGameVoices.Ids[(int)i]; Fill(); }; var flags = new HBoxContainer(); box.AddChild(flags); enabled = new CheckBox { Text = "启用事件" }; chat = new CheckBox { Text = "请求聊天" }; flags.AddChild(enabled); flags.AddChild(chat); threshold = new SpinBox { MinValue = 0, MaxValue = 3600, Step = 1, CustomMinimumSize = new(180, 44) }; box.AddChild(Text("阈值（单位见事件名称；其余事件忽略此项）", 16, _muted)); box.AddChild(threshold); lines = new TextEdit { Name = "DateRuleLines", CustomMinimumSize = new(680, 240), WrapMode = TextEdit.LineWrappingMode.Boundary }; box.AddChild(lines); lines.TextChanged += () => { if (filling) return; if (!working.DateGameVoiceEdits.TryGetValue(profile, out var edits)) working.DateGameVoiceEdits[profile] = edits = new(); edits.Triggers[rules[index].Trigger] = lines.Text.Split('\n', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries).ToList(); }; threshold.ValueChanged += v => rules[index].Threshold = v; enabled.Toggled += v => rules[index].Enabled = v; chat.Toggled += v => rules[index].Chat = v; selector.ItemSelected += i => { index = (int)i; Fill(); }; Fill(); var transfer = new HBoxContainer(); transfer.AddThemeConstantOverride("separation", 16); box.AddChild(transfer); var status = Text("导入后点击保存应用；取消保留原设置。", 16, _muted); transfer.AddChild(Button("导出全部台词", () => { try { string path = DateGameContent.Write(PromptTransfer.Desktop, working, rules); status.Text = "已导出：" + path; OS.ShellShowInFileManager(path); } catch (Exception e) { status.Text = "导出失败：" + e.Message; } }, 220)); transfer.AddChild(Button("导入台词JSON", () => PickNestedFile("导入约会对局台词", [".json"], file => { try { if (new FileInfo(file).Length > 24 * 1024 * 1024) throw new InvalidDataException("文件超过24MB。"); working.DateGameRules = rules; string result = DateGameContent.Import(working, File.ReadAllText(file)); rules = working.DateGameRules; index = 0; selector.Clear(); foreach (var r in rules) selector.AddItem(DateGames.Label(r.Trigger)); selector.Select(0); Fill(); status.Text = result + "；点击保存应用。"; } catch (Exception e) { status.Text = "导入失败，原设置已保留：" + e.Message; } }), 220)); box.AddChild(status); })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("约会对局 · 发言与聊天触发", "选择性格后，每行填写一句该性格的完整事件台词。触发条件共用；请求聊天时先播出台词，玩家接受后在当前动作结束时打开约会。", () => { try { var bundle = DateGameContent.Snapshot(working, rules); DateGameContent.Apply(data, bundle); CareerStore.Save(data); return true; } catch (Exception e) { Notice("保存失败：" + e.Message, true); return false; } }, "保存", box => { var selector = new OptionButton { CustomMinimumSize = new(680, 44) }; foreach (var r in rules) selector.AddItem(DateGames.Label(r.Trigger)); box.AddChild(selector); var voices = new OptionButton { Name = "DateRulePersonality", CustomMinimumSize = new(680, 44) }; foreach (string name in DateGameVoices.Labels) voices.AddItem(name); box.AddChild(voices); voices.ItemSelected += i => { profile = DateGameVoices.Ids[(int)i]; Fill(); }; var flags = new HBoxContainer(); box.AddChild(flags); enabled = new CheckBox { Text = "启用事件" }; chat = new CheckBox { Text = "请求聊天" }; flags.AddChild(enabled); flags.AddChild(chat); threshold = new SpinBox { MinValue = 0, MaxValue = 3600, Step = 1, CustomMinimumSize = new(180, 44) }; box.AddChild(Text("阈值（单位见事件名称；其余事件忽略此项）", 16, _muted)); box.AddChild(threshold); lines = new TextEdit { Name = "DateRuleLines", CustomMinimumSize = new(680, 240), WrapMode = TextEdit.LineWrappingMode.Boundary }; box.AddChild(lines); lines.TextChanged += () => { if (filling) return; if (!working.DateGameVoiceEdits.TryGetValue(profile, out var edits)) working.DateGameVoiceEdits[profile] = edits = new(); edits.Triggers[rules[index].Trigger] = lines.Text.Split('\n', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries).ToList(); }; threshold.ValueChanged += v => rules[index].Threshold = v; enabled.Toggled += v => rules[index].Enabled = v; chat.Toggled += v => rules[index].Chat = v; selector.ItemSelected += i => { index = (int)i; Fill(); }; Fill(); var transfer = new HBoxContainer(); transfer.AddThemeConstantOverride("separation", 16); box.AddChild(transfer); var status = Text("导入后点击保存应用；取消保留原设置。", 16, _muted); transfer.AddChild(Button("导出全部台词", () => { try { string path = DateGameContent.Write(PromptTransfer.Desktop, working, rules); status.Text = "已导出：" + path; OS.ShellShowInFileManager(path); } catch (Exception e) { status.Text = "导出失败：" + e.Message; } }, 220)); transfer.AddChild(Button("导入台词JSON", () => PickNestedFile("导入约会对局台词", [".json"], file => { try { if (new FileInfo(file).Length > 24 * 1024 * 1024) throw new InvalidDataException("文件超过24MB。"); working.DateGameRules = rules; string result = DateGameContent.Import(working, File.ReadAllText(file)); rules = working.DateGameRules; index = 0; selector.Clear(); foreach (var r in rules) selector.AddItem(DateGames.Label(r.Trigger)); selector.Select(0); Fill(); status.Text = result + "；点击保存应用。"; } catch (Exception e) { status.Text = "导入失败，原设置已保留：" + e.Message; } }), 220)); box.AddChild(status); });`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("导入后点击保存应用；取消保留原设置。", 16, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("导入后点击保存应用；取消保留原设置。", 16, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("阈值（单位见事件名称；其余事件忽略此项）", 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("阈值（单位见事件名称；其余事件忽略此项）", 16, _muted)`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(data);`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`Coop.CoopJson.Copy(data.DateGameRules)`；返回值紧邻使用处：`AssignmentExpressionSyntax: DateGameRules = Coop.CoopJson.Copy(data.DateGameRules)`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`Coop.CoopJson.Copy(data.DateGameTiming)`；返回值紧邻使用处：`AssignmentExpressionSyntax: DateGameTiming = Coop.CoopJson.Copy(data.DateGameTiming)`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`Coop.CoopJson.Copy(data.DateGameVoiceEdits)`；返回值紧邻使用处：`AssignmentExpressionSyntax: DateGameVoiceEdits = Coop.CoopJson.Copy(data.DateGameVoiceEdits)`
- `NationalSpire.DateGameContent.Apply(NationalSpire.CareerData, NationalSpire.DateGameContent.Bundle)`；输入表达式：`DateGameContent.Apply(data, bundle)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateGameContent.Apply(data, bundle);`
- `NationalSpire.DateGameContent.Import(NationalSpire.CareerData, string)`；输入表达式：`DateGameContent.Import(working, File.ReadAllText(file))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateGameContent.Import(working, File.ReadAllText(file))`
- `NationalSpire.DateGameContent.Snapshot(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.DateGameRule>?)`；输入表达式：`DateGameContent.Snapshot(working, rules)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateGameContent.Snapshot(working, rules)`
- `NationalSpire.DateGameContent.Write(string, NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.DateGameRule>?)`；输入表达式：`DateGameContent.Write(PromptTransfer.Desktop, working, rules)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateGameContent.Write(PromptTransfer.Desktop, working, rules)`
- `NationalSpire.DateGames.Label(string)`；输入表达式：`DateGames.Label(r.Trigger)`；返回值紧邻使用处：`ArgumentSyntax: DateGames.Label(r.Trigger)`
- `NationalSpire.DateGames.Upgrade(NationalSpire.CareerData)`；输入表达式：`DateGames.Upgrade(working)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateGames.Upgrade(working);`
- `NationalSpire.DateVoiceEdits.DateVoiceEdits()`；输入表达式：`new()`；返回值紧邻使用处：`AssignmentExpressionSyntax: edits = new()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`working.DateGameVoiceEdits.TryGetValue(profile, out var edits)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !working.DateGameVoiceEdits.TryGetValue(profile, out var edits)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`lines.Text.Split('\n', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: edits.Triggers[rules[index].Trigger] = lines.Text.Split('\n', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries).ToList()`
- `System.IO.File.ReadAllText(string)`；输入表达式：`File.ReadAllText(file)`；返回值紧邻使用处：`ArgumentSyntax: File.ReadAllText(file)`
- `System.IO.FileInfo.FileInfo(string)`；输入表达式：`new FileInfo(file)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new FileInfo(file).Length`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("文件超过24MB。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("文件超过24MB。");`
- `string.Split(char, System.StringSplitOptions)`；输入表达式：`lines.Text.Split('\n', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: lines.Text.Split('\n', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries).ToList`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(180, 44)`
- `CustomMinimumSize` = `new(680, 240)`
- `CustomMinimumSize` = `new(680, 44)`
- `DateGameRules` = `Coop.CoopJson.Copy(data.DateGameRules)`
- `DateGameTiming` = `Coop.CoopJson.Copy(data.DateGameTiming)`
- `DateGameVoiceEdits` = `Coop.CoopJson.Copy(data.DateGameVoiceEdits)`
- `MaxValue` = `3600`
- `MinValue` = `0`
- `Name` = `"DateRuleLines"`
- `Name` = `"DateRulePersonality"`
- `Step` = `1`
- `Text` = `"启用事件"`
- `Text` = `"请求聊天"`
- `WrapMode` = `TextEdit.LineWrappingMode.Boundary`
- `chat.Toggled` += `v => rules[index].Chat = v`
- `chat` = `new CheckBox { Text = "请求聊天" }`
- `edits.Triggers[rules[index].Trigger]` = `lines.Text.Split('\n', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries).ToList()`
- `edits` = `new()`
- `enabled.Toggled` += `v => rules[index].Enabled = v`
- `enabled` = `new CheckBox { Text = "启用事件" }`
- `index` = `(int)i`
- `index` = `0`
- `lines.TextChanged` += `() => { if (filling) return; if (!working.DateGameVoiceEdits.TryGetValue(profile, out var edits)) working.DateGameVoiceEdits[profile] = edits = new(); edits.Triggers[rules[index].Trigger] = lines.Text.Split('\n', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries).ToList(); }`
- `lines` = `new TextEdit { Name = "DateRuleLines", CustomMinimumSize = new(680, 240), WrapMode = TextEdit.LineWrappingMode.Boundary }`
- `profile` = `DateGameVoices.Ids[(int)i]`
- `rules[index].Chat` = `v`
- `rules[index].Enabled` = `v`
- `rules[index].Threshold` = `v`
- `rules` = `working.DateGameRules`
- `selector.ItemSelected` += `i => { index = (int)i; Fill(); }`
- `status.Text` = `"导入失败，原设置已保留：" + e.Message`
- `status.Text` = `"导出失败：" + e.Message`
- `status.Text` = `"已导出：" + path`
- `status.Text` = `result + "；点击保存应用。"`
- `threshold.ValueChanged` += `v => rules[index].Threshold = v`
- `threshold` = `new SpinBox { MinValue = 0, MaxValue = 3600, Step = 1, CustomMinimumSize = new(180, 44) }`
- `voices.ItemSelected` += `i => { profile = DateGameVoices.Ids[(int)i]; Fill(); }`
- `working.DateGameRules` = `rules`
- `working.DateGameVoiceEdits[profile]` = `edits = new()`

<a id="symbol-70f585bf64d5"></a>

## `Fill() — void Fill()`

来源：源码第 219 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.EditDateGameRules()`](DateGameScreen.cs.md#symbol-0a1b70a243b1)

**调用：** `Godot.BaseButton.SetPressedNoSignal(bool)`；`Godot.Range.SetValueNoSignal(double)`；[`NationalSpire.DateGameVoices.EventLines(NationalSpire.CareerData, string, NationalSpire.DateGameRule)`](DateGameVoices.cs.md#symbol-036aa782750d)；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateGameRule.Chat`；`NationalSpire.DateGameRule.Enabled`；`NationalSpire.DateGameRule.Threshold`；`NationalSpire.DateGameVoices.EventLines(NationalSpire.CareerData, string, NationalSpire.DateGameRule)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`chat!.SetPressedNoSignal(r.Chat)`；返回值紧邻使用处：`ExpressionStatementSyntax: chat!.SetPressedNoSignal(r.Chat);`
- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`enabled!.SetPressedNoSignal(r.Enabled)`；返回值紧邻使用处：`ExpressionStatementSyntax: enabled!.SetPressedNoSignal(r.Enabled);`
- `Godot.Range.SetValueNoSignal(double)`；输入表达式：`threshold!.SetValueNoSignal(r.Threshold)`；返回值紧邻使用处：`ExpressionStatementSyntax: threshold!.SetValueNoSignal(r.Threshold);`
- `NationalSpire.DateGameVoices.EventLines(NationalSpire.CareerData, string, NationalSpire.DateGameRule)`；输入表达式：`DateGameVoices.EventLines(working, profile, r)`；返回值紧邻使用处：`ArgumentSyntax: DateGameVoices.EventLines(working, profile, r)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n", DateGameVoices.EventLines(working, profile, r))`；返回值紧邻使用处：`AssignmentExpressionSyntax: lines!.Text = string.Join("\n", DateGameVoices.EventLines(working, profile, r))`

**赋值（含属性/字段和局部值）：**

- `filling` = `false`
- `filling` = `true`
- `lines!.Text` = `string.Join("\n", DateGameVoices.EventLines(working, profile, r))`

<a id="symbol-ad300bbb552d"></a>

## `NationalSpire.CareerScreen.AddDateVoiceSettings(Godot.VBoxContainer) — private void AddDateVoiceSettings(VBoxContainer box)`

来源：源码第 278 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DateSceneSettings()`](DateSceneScreen.cs.md#symbol-0845ec2acab1)

**调用：** `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.OptionButton()`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CareerScreen.DateParticipants()`](DateScenePartyScreen.cs.md#symbol-658316b8bf70)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`](DateSceneAssets.cs.md#symbol-57fe620f4cc9)；[`NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`](DateSceneAssets.cs.md#symbol-2bf1f40a912e)；[`Select()`](DateGameScreen.cs.md#symbol-c15130f82b97)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerMatch.DateGame`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerScreen.DateParticipants()`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._dateAssets`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.DateGameState.Voices`；`NationalSpire.DateGameVoices.Ids`；`NationalSpire.DateGameVoices.Labels`；`NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`；`NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`；`NationalSpire.DateSceneAssets.GameVoice`；`NationalSpire.DateSceneParticipant.Name`；`NationalSpire.DateSceneParticipant.PersonId`；`Select()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 16);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text("对局台词版本", 18, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text("对局台词版本", 18, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(person)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(person);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(voice)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(voice);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`person.AddItem(p.Name)`；返回值紧邻使用处：`ExpressionStatementSyntax: person.AddItem(p.Name);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`voice.AddItem(label)`；返回值紧邻使用处：`ExpressionStatementSyntax: voice.AddItem(label);`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { CustomMinimumSize = new(280, 42), SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { CustomMinimumSize = new(280, 42), SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { CustomMinimumSize = new(300, 42), SizeFlagsHorizontal = SizeFlags.ExpandFill, FitToLongestItem = false }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { CustomMinimumSize = new(300, 42), SizeFlagsHorizontal = SizeFlags.ExpandFill, FitToLongestItem = false }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(280, 42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(280, 42)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(300, 42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(300, 42)`
- `NationalSpire.CareerScreen.DateParticipants()`；输入表达式：`DateParticipants()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateParticipants()`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("对局台词版本", 18, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text("对局台词版本", 18, _ink)`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(ViewData)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(ViewData);`
- `NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`；输入表达式：`DateSceneAssetStore.Read(ViewData, id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: id == _datePerson ? _dateAssets! : DateSceneAssetStore.Read(ViewData, id)`
- `NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`；输入表达式：`DateSceneAssetStore.Save(ViewData, id, art)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateSceneAssetStore.Save(ViewData, id, art);`
- `Select()`；输入表达式：`Select()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _ => Select()`
- `Select()`；输入表达式：`Select()`；返回值紧邻使用处：`ExpressionStatementSyntax: Select();`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`ViewData.Matches.FirstOrDefault(m => m.Id == ViewData.PendingMatchId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: ViewData.Matches.FirstOrDefault(m => m.Id == ViewData.PendingMatchId)?.DateGame`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(280, 42)`
- `CustomMinimumSize` = `new(300, 42)`
- `FitToLongestItem` = `false`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `active.Voices[id]` = `art.GameVoice`
- `art.GameVoice` = `DateGameVoices.Ids[(int)index]`
- `person.ItemSelected` += `_ => Select()`
- `voice.ItemSelected` += `index => { string id = people[person.Selected].PersonId; var art = id == _datePerson ? _dateAssets! : DateSceneAssetStore.Read(ViewData, id); art.GameVoice = DateGameVoices.Ids[(int)index]; DateSceneAssetStore.Save(ViewData, id, art); if (ViewData.Matches.FirstOrDefault(m => m.Id == ViewData.PendingMatchId)?.DateGame is { } active) { active.Voices[id] = art.GameVoice; CareerStore.Save(ViewData); } }`

<a id="symbol-c15130f82b97"></a>

## `Select() — void Select()`

来源：源码第 288 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddDateVoiceSettings(Godot.VBoxContainer)`](DateGameScreen.cs.md#symbol-ad300bbb552d)

**调用：** `Godot.OptionButton.Select(int)`；[`NationalSpire.DateGameVoices.Default(NationalSpire.CareerData, string)`](DateGameVoices.cs.md#symbol-b457de19f0a7)；[`NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`](DateSceneAssets.cs.md#symbol-57fe620f4cc9)；`System.Array.IndexOf<T>(T[], T)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._dateAssets`；`NationalSpire.CareerScreen._datePerson`；`NationalSpire.DateGameVoices.Default(NationalSpire.CareerData, string)`；`NationalSpire.DateGameVoices.Ids`；`NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`；`NationalSpire.DateSceneAssets.GameVoice`；`NationalSpire.DateSceneParticipant.PersonId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.OptionButton.Select(int)`；输入表达式：`voice.Select(Math.Max(0, Array.IndexOf(DateGameVoices.Ids, art.GameVoice.Length > 0 ? art.GameVoice : DateGameVoices.Default(ViewData, id))))`；返回值紧邻使用处：`ExpressionStatementSyntax: voice.Select(Math.Max(0, Array.IndexOf(DateGameVoices.Ids, art.GameVoice.Length > 0 ? art.GameVoice : DateGameVoices.Default(ViewData, id))));`
- `NationalSpire.DateGameVoices.Default(NationalSpire.CareerData, string)`；输入表达式：`DateGameVoices.Default(ViewData, id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: art.GameVoice.Length > 0 ? art.GameVoice : DateGameVoices.Default(ViewData, id)`
- `NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`；输入表达式：`DateSceneAssetStore.Read(ViewData, id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: id == _datePerson ? _dateAssets! : DateSceneAssetStore.Read(ViewData, id)`
- `System.Array.IndexOf<T>(T[], T)`；输入表达式：`Array.IndexOf(DateGameVoices.Ids, art.GameVoice.Length > 0 ? art.GameVoice : DateGameVoices.Default(ViewData, id))`；返回值紧邻使用处：`ArgumentSyntax: Array.IndexOf(DateGameVoices.Ids, art.GameVoice.Length > 0 ? art.GameVoice : DateGameVoices.Default(ViewData, id))`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, Array.IndexOf(DateGameVoices.Ids, art.GameVoice.Length > 0 ? art.GameVoice : DateGameVoices.Default(ViewData, id)))`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, Array.IndexOf(DateGameVoices.Ids, art.GameVoice.Length > 0 ? art.GameVoice : DateGameVoices.Default(ViewData, id)))`

**赋值（含属性/字段和局部值）：**
