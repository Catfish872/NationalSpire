# AvatarScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`A1ADBBF20BB6FEA4AD07C6848114658662150E9E32864955000B382D28A3BDCF`。来源：[源码](../../AvatarScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
private Control? _avatarOverlay;
private Action? _closeAvatar;
```

<a id="symbol-368e97fdd27f"></a>

## `NationalSpire.CareerScreen.OpenAvatarSettings(NationalSpire.CareerData, NationalSpire.PlayerAvatar?, System.Action<NationalSpire.PlayerAvatar>?, string, NationalSpire.AvatarArt?) — private void OpenAvatarSettings(CareerData data, PlayerAvatar? initial = null, Action<PlayerAvatar>? choose = null, string personId = "player", AvatarArt? automatic = null)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`](CharacterCardScreen.cs.md#symbol-a498f622bb3e)；[`NationalSpire.CareerScreen.PlayerProfile(NationalSpire.CareerData)`](ProfileScreen.cs.md#symbol-ce70d1ef24b8)

**调用：** [`CloseAvatar()`](AvatarScreen.cs.md#symbol-ef2b7f0f94fc)；[`Controls(Godot.Node)`](AvatarScreen.cs.md#symbol-ee01e39d3320)；[`Gallery()`](AvatarScreen.cs.md#symbol-e01b201de3dc)；[`NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`](AvatarHonors.cs.md#symbol-5207a1627331)；[`NationalSpire.AvatarImages.FromFile(string)`](AvatarImages.cs.md#symbol-2455dc6874f9)；[`NationalSpire.AvatarSources.Characters()`](AvatarSources.cs.md#symbol-6c772247bc69)；[`NationalSpire.AvatarSources.Steam()`](AvatarSources.cs.md#symbol-bc266fec0f45)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.OpenFilePicker(string, string[], System.Action<string>)`](CareerFilePicker.cs.md#symbol-e74b66910ad6)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`](CareerDialog.cs.md#symbol-d832b736b02b)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.PlayerAvatar.Validate()`](PlayerAvatar.cs.md#symbol-96ff07617629)；[`Select(NationalSpire.PlayerAvatar)`](AvatarScreen.cs.md#symbol-07697461993d)；`Godot.Color.Color(float, float, float, float)`；`Godot.ColorRect.ColorRect()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.GrabFocus()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.GridContainer.GridContainer()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.LineEdit.LineEdit()`；`Godot.MarginContainer.MarginContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetViewport()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`Godot.Viewport.GuiGetFocusOwner()`；`NationalSpire.BroadcastScroll.BroadcastScroll()`；`NationalSpire.CareerAvatar.CareerAvatar()`；`NationalSpire.PlayerAvatar.PlayerAvatar()`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；`System.Text.Json.JsonSerializerOptions.JsonSerializerOptions()`

**字段、属性、事件及方法组引用：** `(Godot.Control Control, Godot.Control.FocusModeEnum Mode).Control`；`(Godot.Control Control, Godot.Control.FocusModeEnum Mode).Mode`；`CloseAvatar()`；`Controls(Godot.Node)`；`Gallery()`；`NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.AvatarImages.FromFile(string)`；`NationalSpire.AvatarSources.Characters()`；`NationalSpire.AvatarSources.Steam()`；`NationalSpire.CareerAvatar.Identity`；`NationalSpire.CareerData.SelectedAvatar`；`NationalSpire.CareerScreen._avatarOverlay`；`NationalSpire.CareerScreen._closeAvatar`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._stage`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.OpenFilePicker(string, string[], System.Action<string>)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.PlayerAvatar.Validate()`；`Select(NationalSpire.PlayerAvatar)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CloseAvatar()`；输入表达式：`CloseAvatar()`；返回值紧邻使用处：`ExpressionStatementSyntax: CloseAvatar();`
- `Controls(Godot.Node)`；输入表达式：`Controls(_stage)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Controls(_stage).Where`
- `Gallery()`；输入表达式：`Gallery()`；返回值紧邻使用处：`ExpressionStatementSyntax: Gallery();`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new(0, 0, 0, .82f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Color = new(0, 0, 0, .82f)`
- `Godot.ColorRect.ColorRect()`；输入表达式：`new ColorRect { Name = "AvatarEditor", Color = new(0, 0, 0, .82f), MouseFilter = MouseFilterEnum.Stop, ZIndex = 20 }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ColorRect { Name = "AvatarEditor", Color = new(0, 0, 0, .82f), MouseFilter = MouseFilterEnum.Stop, ZIndex = 20 }`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`actions.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddThemeConstantOverride("separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation", 14);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("h_separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("h_separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("v_separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("v_separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`margin.AddThemeConstantOverride("margin_" + edge, 100)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddThemeConstantOverride("margin_" + edge, 100);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`margin.AddThemeConstantOverride("margin_" + edge, 55)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddThemeConstantOverride("margin_" + edge, 55);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`paging.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: paging.AddThemeConstantOverride("separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`previewRow.AddThemeConstantOverride("separation", 20)`；返回值紧邻使用处：`ExpressionStatementSyntax: previewRow.AddThemeConstantOverride("separation", 20);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`sources.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: sources.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.GrabFocus()`；输入表达式：`search.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: search.GrabFocus();`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(shade)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(shade)`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(status)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(status) && requestedRevision == selectionRevision`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(steam)`；返回值紧邻使用处：`IfStatementSyntax: if (IsInstanceValid(steam)) steam.Disabled = false;`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`shade.IsQueuedForDeletion()`；返回值紧邻使用处：`BinaryExpressionSyntax: !IsInstanceValid(shade) || shade.IsQueuedForDeletion()`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer { Name = "AvatarGallery", Columns = 3, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GridContainer { Name = "AvatarGallery", Columns = 3, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Name = "AvatarSearch", PlaceholderText = "搜索头像或卡牌名称", CustomMinimumSize = new(0, 46) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LineEdit { Name = "AvatarSearch", PlaceholderText = "搜索头像或卡牌名称", CustomMinimumSize = new(0, 46) }`
- `Godot.MarginContainer.MarginContainer()`；输入表达式：`new MarginContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MarginContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_stage.AddChild(shade)`；返回值紧邻使用处：`ExpressionStatementSyntax: _stage.AddChild(shade);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(Button("取消", CloseAvatar, 160))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(Button("取消", CloseAvatar, 160));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(Button(choose == null ? "保存头像" : "使用此头像", () =>         {             if (choose != null) { selected.Validate(); choose(selected); CloseAvatar(); return; }             ShowCareerDialog("保存头像", "使用当前预览作为本生涯头像？多人模式下，队友也会看到这张头像。", () =>             {                 if (MultiplayerCommand("avatar", text: JsonSerializer.Serialize(selected, new JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping }))) { CloseAvatar(); return true; }                 var old = data.SelectedAvatar;                 try { selected.Validate(); data.SelectedAvatar = selected; CareerStore.Save(data); CloseAvatar(); Render(); return true; }                 catch { data.SelectedAvatar = old; status.Text = "头像未能保存，请检查存档文件夹的写入权限。"; return true; }             });         }, 200))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(Button(choose == null ? "保存头像" : "使用此头像", () =>         {             if (choose != null) { selected.Validate(); choose(selected); CloseAvatar(); return; }             ShowCareerDialog("保存头像", "使用当前预览作为本生涯头像？多人模式下，队友也会看到这张头像。", () =>             {                 if (MultiplayerCommand("avatar", text: JsonSerializer.Serialize(selected, new JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping }))) { CloseAvatar(); return true; }                 var old = data.SelectedAvatar;                 try { selected.Validate(); data.SelectedAvatar = selected; CareerStore.Save(data); CloseAvatar(); Render(); return true; }                 catch { data.SelectedAvatar = old; status.Text = "头像未能保存，请检查存档文件夹的写入权限。"; return true; }             });         }, 200));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(actions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(paging)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(paging);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(previewRow)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(previewRow);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(search)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(search);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(sources)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(sources);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text("选择头像", 28, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text("选择头像", 28, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text("用于当前生涯的档案、社区和队伍展示。头像框与进阶角标照常保留。", 17, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text("用于当前生涯的档案、社区和队伍展示。头像框与进阶角标照常保留。", 17, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`details.AddChild(description)`；返回值紧邻使用处：`ExpressionStatementSyntax: details.AddChild(description);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`details.AddChild(status)`；返回值紧邻使用处：`ExpressionStatementSyntax: details.AddChild(status);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`margin.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddChild(panel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`paging.AddChild(next)`；返回值紧邻使用处：`ExpressionStatementSyntax: paging.AddChild(next);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`paging.AddChild(pages)`；返回值紧邻使用处：`ExpressionStatementSyntax: paging.AddChild(pages);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`paging.AddChild(previous)`；返回值紧邻使用处：`ExpressionStatementSyntax: paging.AddChild(previous);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`previewRow.AddChild(details)`；返回值紧邻使用处：`ExpressionStatementSyntax: previewRow.AddChild(details);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`previewRow.AddChild(preview)`；返回值紧邻使用处：`ExpressionStatementSyntax: previewRow.AddChild(preview);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scroll.AddChild(grid)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.AddChild(grid);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`shade.AddChild(margin)`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.AddChild(margin);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`sources.AddChild(Button("选择本地图片", () => OpenFilePicker("选择头像图片", [".png", ".jpg", ".jpeg", ".webp"], path =>         {             try { Select(AvatarImages.FromFile(path)); status.Text = "已预览本地图片，确认保存后生效。"; }             catch (Exception e) { status.Text = e is ArgumentException ? e.Message : "无法读取这张图片，请重新选择。"; }         }), 200))`；返回值紧邻使用处：`ExpressionStatementSyntax: sources.AddChild(Button("选择本地图片", () => OpenFilePicker("选择头像图片", [".png", ".jpg", ".jpeg", ".webp"], path =>         {             try { Select(AvatarImages.FromFile(path)); status.Text = "已预览本地图片，确认保存后生效。"; }             catch (Exception e) { status.Text = e is ArgumentException ? e.Message : "无法读取这张图片，请重新选择。"; }         }), 200));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`sources.AddChild(Button("游戏卡图", () => { category = "card"; search.Text = ""; page = 0; Gallery(); }, 170))`；返回值紧邻使用处：`ExpressionStatementSyntax: sources.AddChild(Button("游戏卡图", () => { category = "card"; search.Text = ""; page = 0; Gallery(); }, 170));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`sources.AddChild(Button("游戏头像", () => { category = "character"; search.Text = ""; page = 0; Gallery(); }, 170))`；返回值紧邻使用处：`ExpressionStatementSyntax: sources.AddChild(Button("游戏头像", () => { category = "character"; search.Text = ""; page = 0; Gallery(); }, 170));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`sources.AddChild(Button("自动头像", () => { Select(new()); status.Text = "恢复跟随角色的自动头像。"; }, 170))`；返回值紧邻使用处：`ExpressionStatementSyntax: sources.AddChild(Button("自动头像", () => { Select(new()); status.Text = "恢复跟随角色的自动头像。"; }, 170));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`sources.AddChild(steam)`；返回值紧邻使用处：`ExpressionStatementSyntax: sources.AddChild(steam);`
- `Godot.Node.GetViewport()`；输入表达式：`GetViewport()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetViewport().GuiGetFocusOwner`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 290)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 290)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 46)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 46)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(104, 104)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(104, 104)`
- `Godot.Viewport.GuiGetFocusOwner()`；输入表达式：`GetViewport().GuiGetFocusOwner()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GetViewport().GuiGetFocusOwner()`
- `NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`AvatarHonors.ForPerson(data, personId)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Identity = AvatarHonors.ForPerson(data, personId)`
- `NationalSpire.AvatarImages.FromFile(string)`；输入表达式：`AvatarImages.FromFile(path)`；返回值紧邻使用处：`ArgumentSyntax: AvatarImages.FromFile(path)`
- `NationalSpire.AvatarSources.Characters()`；输入表达式：`AvatarSources.Characters()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AvatarSources.Characters()`
- `NationalSpire.AvatarSources.Steam()`；输入表达式：`AvatarSources.Steam()`；返回值紧邻使用处：`AwaitExpressionSyntax: await AvatarSources.Steam()`
- `NationalSpire.BroadcastScroll.BroadcastScroll()`；输入表达式：`new BroadcastScroll { SizeFlagsVertical = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 290), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastScroll { SizeFlagsVertical = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 290), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `NationalSpire.CareerAvatar.CareerAvatar()`；输入表达式：`new CareerAvatar { Name = "AvatarPreview", CustomMinimumSize = new(104, 104), Identity = AvatarHonors.ForPerson(data, personId) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CareerAvatar { Name = "AvatarPreview", CustomMinimumSize = new(104, 104), Identity = AvatarHonors.ForPerson(data, personId) }`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("取消", CloseAvatar, 160)`；返回值紧邻使用处：`ArgumentSyntax: Button("取消", CloseAvatar, 160)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("上一页", () => { page--; Gallery(); }, 140)`；返回值紧邻使用处：`AssignmentExpressionSyntax: previous = Button("上一页", () => { page--; Gallery(); }, 140)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("下一页", () => { page++; Gallery(); }, 140)`；返回值紧邻使用处：`AssignmentExpressionSyntax: next = Button("下一页", () => { page++; Gallery(); }, 140)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("选择本地图片", () => OpenFilePicker("选择头像图片", [".png", ".jpg", ".jpeg", ".webp"], path =>         {             try { Select(AvatarImages.FromFile(path)); status.Text = "已预览本地图片，确认保存后生效。"; }             catch (Exception e) { status.Text = e is ArgumentException ? e.Message : "无法读取这张图片，请重新选择。"; }         }), 200)`；返回值紧邻使用处：`ArgumentSyntax: Button("选择本地图片", () => OpenFilePicker("选择头像图片", [".png", ".jpg", ".jpeg", ".webp"], path =>         {             try { Select(AvatarImages.FromFile(path)); status.Text = "已预览本地图片，确认保存后生效。"; }             catch (Exception e) { status.Text = e is ArgumentException ? e.Message : "无法读取这张图片，请重新选择。"; }         }), 200)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("游戏卡图", () => { category = "card"; search.Text = ""; page = 0; Gallery(); }, 170)`；返回值紧邻使用处：`ArgumentSyntax: Button("游戏卡图", () => { category = "card"; search.Text = ""; page = 0; Gallery(); }, 170)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("游戏头像", () => { category = "character"; search.Text = ""; page = 0; Gallery(); }, 170)`；返回值紧邻使用处：`ArgumentSyntax: Button("游戏头像", () => { category = "character"; search.Text = ""; page = 0; Gallery(); }, 170)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("自动头像", () => { Select(new()); status.Text = "恢复跟随角色的自动头像。"; }, 170)`；返回值紧邻使用处：`ArgumentSyntax: Button("自动头像", () => { Select(new()); status.Text = "恢复跟随角色的自动头像。"; }, 170)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("Steam 头像", () => { }, 180)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("Steam 头像", () => { }, 180)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button(choose == null ? "保存头像" : "使用此头像", () =>         {             if (choose != null) { selected.Validate(); choose(selected); CloseAvatar(); return; }             ShowCareerDialog("保存头像", "使用当前预览作为本生涯头像？多人模式下，队友也会看到这张头像。", () =>             {                 if (MultiplayerCommand("avatar", text: JsonSerializer.Serialize(selected, new JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping }))) { CloseAvatar(); return true; }                 var old = data.SelectedAvatar;                 try { selected.Validate(); data.SelectedAvatar = selected; CareerStore.Save(data); CloseAvatar(); Render(); return true; }                 catch { data.SelectedAvatar = old; status.Text = "头像未能保存，请检查存档文件夹的写入权限。"; return true; }             });         }, 200)`；返回值紧邻使用处：`ArgumentSyntax: Button(choose == null ? "保存头像" : "使用此头像", () =>         {             if (choose != null) { selected.Validate(); choose(selected); CloseAvatar(); return; }             ShowCareerDialog("保存头像", "使用当前预览作为本生涯头像？多人模式下，队友也会看到这张头像。", () =>             {                 if (MultiplayerCommand("avatar", text: JsonSerializer.Serialize(selected, new JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping }))) { CloseAvatar(); return true; }                 var old = data.SelectedAvatar;                 try { selected.Validate(); data.SelectedAvatar = selected; CareerStore.Save(data); CloseAvatar(); Render(); return true; }                 catch { data.SelectedAvatar = old; status.Text = "头像未能保存，请检查存档文件夹的写入权限。"; return true; }             });         }, 200)`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(panel)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(panel)`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("avatar", text: JsonSerializer.Serialize(selected, new JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping }))`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand("avatar", text: JsonSerializer.Serialize(selected, new JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping }))) { CloseAvatar(); return true; }`
- `NationalSpire.CareerScreen.OpenFilePicker(string, string[], System.Action<string>)`；输入表达式：`OpenFilePicker("选择头像图片", [".png", ".jpg", ".jpeg", ".webp"], path =>         {             try { Select(AvatarImages.FromFile(path)); status.Text = "已预览本地图片，确认保存后生效。"; }             catch (Exception e) { status.Text = e is ArgumentException ? e.Message : "无法读取这张图片，请重新选择。"; }         })`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenFilePicker("选择头像图片", [".png", ".jpg", ".jpeg", ".webp"], path =>         {             try { Select(AvatarImages.FromFile(path)); status.Text = "已预览本地图片，确认保存后生效。"; }             catch (Exception e) { status.Text = e is ArgumentException ? e.Message : "无法读取这张图片，请重新选择。"; }         })`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；输入表达式：`ShowCareerDialog("保存头像", "使用当前预览作为本生涯头像？多人模式下，队友也会看到这张头像。", () =>             {                 if (MultiplayerCommand("avatar", text: JsonSerializer.Serialize(selected, new JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping }))) { CloseAvatar(); return true; }                 var old = data.SelectedAvatar;                 try { selected.Validate(); data.SelectedAvatar = selected; CareerStore.Save(data); CloseAvatar(); Render(); return true; }                 catch { data.SelectedAvatar = old; status.Text = "头像未能保存，请检查存档文件夹的写入权限。"; return true; }             })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("保存头像", "使用当前预览作为本生涯头像？多人模式下，队友也会看到这张头像。", () =>             {                 if (MultiplayerCommand("avatar", text: JsonSerializer.Serialize(selected, new JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping }))) { CloseAvatar(); return true; }                 var old = data.SelectedAvatar;                 try { selected.Validate(); data.SelectedAvatar = selected; CareerStore.Save(data); CloseAvatar(); Render(); return true; }                 catch { data.SelectedAvatar = old; status.Text = "头像未能保存，请检查存档文件夹的写入权限。"; return true; }             });`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 16, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("", 16, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 23, _gold)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("", 23, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("图片会居中裁剪成正方形。确认保存后生效，原图片移动或删除不影响头像。", 17, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("图片会居中裁剪成正方形。确认保存后生效，原图片移动或删除不影响头像。", 17, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("选择头像", 28, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("选择头像", 28, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("用于当前生涯的档案、社区和队伍展示。头像框与进阶角标照常保留。", 17, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("用于当前生涯的档案、社区和队伍展示。头像框与进阶角标照常保留。", 17, _muted)`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(data);`
- `NationalSpire.PlayerAvatar.PlayerAvatar()`；输入表达式：`new()`；返回值紧邻使用处：`ArgumentSyntax: new()`
- `NationalSpire.PlayerAvatar.Validate()`；输入表达式：`selected.Validate()`；返回值紧邻使用处：`ExpressionStatementSyntax: selected.Validate();`
- `Select(NationalSpire.PlayerAvatar)`；输入表达式：`Select(avatar)`；返回值紧邻使用处：`ExpressionStatementSyntax: Select(avatar);`
- `Select(NationalSpire.PlayerAvatar)`；输入表达式：`Select(AvatarImages.FromFile(path))`；返回值紧邻使用处：`ExpressionStatementSyntax: Select(AvatarImages.FromFile(path));`
- `Select(NationalSpire.PlayerAvatar)`；输入表达式：`Select(new())`；返回值紧邻使用处：`ExpressionStatementSyntax: Select(new());`
- `Select(NationalSpire.PlayerAvatar)`；输入表达式：`Select(selected)`；返回值紧邻使用处：`ExpressionStatementSyntax: Select(selected);`
- `System.Action<T>.Invoke(T)`；输入表达式：`choose(selected)`；返回值紧邻使用处：`ExpressionStatementSyntax: choose(selected);`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Controls(_stage).Where(c => c.FocusMode != FocusModeEnum.None).Select(c => (Control: c, Mode: c.FocusMode))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Controls(_stage).Where(c => c.FocusMode != FocusModeEnum.None).Select(c => (Control: c, Mode: c.FocusMode)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`Controls(_stage).Where(c => c.FocusMode != FocusModeEnum.None).Select(c => (Control: c, Mode: c.FocusMode)).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Controls(_stage).Where(c => c.FocusMode != FocusModeEnum.None).Select(c => (Control: c, Mode: c.FocusMode)).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Controls(_stage).Where(c => c.FocusMode != FocusModeEnum.None)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Controls(_stage).Where(c => c.FocusMode != FocusModeEnum.None).Select`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(selected, new JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping })`；返回值紧邻使用处：`ArgumentSyntax: text: JsonSerializer.Serialize(selected, new JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping })`
- `System.Text.Json.JsonSerializerOptions.JsonSerializerOptions()`；输入表达式：`new JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping }`；返回值紧邻使用处：`ArgumentSyntax: new JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping }`

**赋值（含属性/字段和局部值）：**

- `_avatarOverlay` = `shade`
- `_closeAvatar` = `CloseAvatar`
- `category` = `"card"`
- `category` = `"character"`
- `Color` = `new(0, 0, 0, .82f)`
- `Columns` = `3`
- `CustomMinimumSize` = `new(0, 290)`
- `CustomMinimumSize` = `new(0, 46)`
- `CustomMinimumSize` = `new(104, 104)`
- `data.SelectedAvatar` = `old`
- `data.SelectedAvatar` = `selected`
- `Encoder` = `System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping`
- `entry.Control.FocusMode` = `FocusModeEnum.None`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `Identity` = `AvatarHonors.ForPerson(data, personId)`
- `MouseFilter` = `MouseFilterEnum.Stop`
- `Name` = `"AvatarEditor"`
- `Name` = `"AvatarGallery"`
- `Name` = `"AvatarPreview"`
- `Name` = `"AvatarSearch"`
- `next` = `Button("下一页", () => { page++; Gallery(); }, 140)`
- `page` = `0`
- `PlaceholderText` = `"搜索头像或卡牌名称"`
- `previous` = `Button("上一页", () => { page--; Gallery(); }, 140)`
- `search.Text` = `""`
- `search.TextChanged` += `_ => { page = 0; Gallery(); }`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ExpandFill`
- `status.Text` = `"恢复跟随角色的自动头像。"`
- `status.Text` = `"头像未能保存，请检查存档文件夹的写入权限。"`
- `status.Text` = `"已读取当前 Steam 头像，确认保存后生效。"`
- `status.Text` = `"已预览本地图片，确认保存后生效。"`
- `status.Text` = `"正在读取你的 Steam 头像……"`
- `status.Text` = `e is ArgumentException ? e.Message : "无法读取这张图片，请重新选择。"`
- `status.Text` = `e is ArgumentException ? e.Message : "暂时无法读取 Steam 头像，请确认 Steam 已登录后重试。"`
- `steam.Disabled` = `false`
- `steam.Disabled` = `true`
- `steam.Pressed` += `async () =>         {             int requestedRevision = selectionRevision;             steam.Disabled = true; status.Text = "正在读取你的 Steam 头像……";             try             {                 var avatar = await AvatarSources.Steam();                 if (!IsInstanceValid(shade) || shade.IsQueuedForDeletion() || requestedRevision != selectionRevision) return;                 Select(avatar); status.Text = "已读取当前 Steam 头像，确认保存后生效。";             }             catch (Exception e) { if (IsInstanceValid(status) && requestedRevision == selectionRevision) status.Text = e is ArgumentException ? e.Message : "暂时无法读取 Steam 头像，请确认 Steam 已登录后重试。"; }             finally { if (IsInstanceValid(steam)) steam.Disabled = false; }         }`
- `ZIndex` = `20`

<a id="symbol-ee01e39d3320"></a>

## `Controls(Godot.Node) — IEnumerable<Control> Controls(Node node)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Controls(Godot.Node)`](AvatarScreen.cs.md#symbol-ee01e39d3320)；[`NationalSpire.CareerScreen.OpenAvatarSettings(NationalSpire.CareerData, NationalSpire.PlayerAvatar?, System.Action<NationalSpire.PlayerAvatar>?, string, NationalSpire.AvatarArt?)`](AvatarScreen.cs.md#symbol-368e97fdd27f)

**调用：** [`Controls(Godot.Node)`](AvatarScreen.cs.md#symbol-ee01e39d3320)；`Godot.Node.GetChildren(bool)`；`System.Array.Empty<T>()`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`

**字段、属性、事件及方法组引用：** `Controls(Godot.Node)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Controls(Godot.Node)`；输入表达式：`Controls(child)`；返回值紧邻使用处：`ArgumentSyntax: Controls(child)`
- `Godot.Node.GetChildren(bool)`；输入表达式：`node.GetChildren()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: node.GetChildren().SelectMany`
- `System.Array.Empty<T>()`；输入表达式：`Array.Empty<Control>()`；返回值紧邻使用处：`ConditionalExpressionSyntax: child is Control control ? new[] { control } : Array.Empty<Control>()`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`(child is Control control ? new[] { control } : Array.Empty<Control>()).Concat(Controls(child))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: child =>             (child is Control control ? new[] { control } : Array.Empty<Control>()).Concat(Controls(child))`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`node.GetChildren().SelectMany(child =>             (child is Control control ? new[] { control } : Array.Empty<Control>()).Concat(Controls(child)))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => node.GetChildren().SelectMany(child =>             (child is Control control ? new[] { control } : Array.Empty<Control>()).Concat(Controls(child)))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-07697461993d"></a>

## `Select(NationalSpire.PlayerAvatar) — void Select(PlayerAvatar avatar)`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Gallery()`](AvatarScreen.cs.md#symbol-e01b201de3dc)；[`NationalSpire.CareerScreen.OpenAvatarSettings(NationalSpire.CareerData, NationalSpire.PlayerAvatar?, System.Action<NationalSpire.PlayerAvatar>?, string, NationalSpire.AvatarArt?)`](AvatarScreen.cs.md#symbol-368e97fdd27f)

**调用：** [`NationalSpire.AvatarImages.Read(NationalSpire.PlayerAvatar?)`](AvatarImages.cs.md#symbol-1edd50772202)；[`NationalSpire.CareerAvatars.Automatic(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-2bfa078d007b)

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarImages.Read(NationalSpire.PlayerAvatar?)`；`NationalSpire.CareerAvatar.Art`；`NationalSpire.CareerAvatars.Automatic(NationalSpire.CareerData, string)`；`NationalSpire.PlayerAvatar.Label`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AvatarImages.Read(NationalSpire.PlayerAvatar?)`；输入表达式：`AvatarImages.Read(avatar)`；返回值紧邻使用处：`BinaryExpressionSyntax: AvatarImages.Read(avatar) ?? automatic ?? CareerAvatars.Automatic(data, personId)`
- `NationalSpire.CareerAvatars.Automatic(NationalSpire.CareerData, string)`；输入表达式：`CareerAvatars.Automatic(data, personId)`；返回值紧邻使用处：`BinaryExpressionSyntax: automatic ?? CareerAvatars.Automatic(data, personId)`

**赋值（含属性/字段和局部值）：**

- `description.Text` = `avatar.Label`
- `preview.Art` = `AvatarImages.Read(avatar) ?? automatic ?? CareerAvatars.Automatic(data, personId)`
- `selected` = `avatar`

<a id="symbol-e01b201de3dc"></a>

## `Gallery() — void Gallery()`

来源：源码第 51 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenAvatarSettings(NationalSpire.CareerData, NationalSpire.PlayerAvatar?, System.Action<NationalSpire.PlayerAvatar>?, string, NationalSpire.AvatarArt?)`](AvatarScreen.cs.md#symbol-368e97fdd27f)

**调用：** [`NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`](AvatarAssets.cs.md#symbol-1d4beb6f533e)；[`NationalSpire.AvatarImages.FromArt(NationalSpire.AvatarArt, string)`](AvatarImages.cs.md#symbol-11dcaf1a0f5d)；[`NationalSpire.AvatarSources.Cards()`](AvatarSources.cs.md#symbol-3bc6741f18ea)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`Select(NationalSpire.PlayerAvatar)`](AvatarScreen.cs.md#symbol-07697461993d)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.AvatarArt.AvatarArt(Godot.Texture2D?, Godot.Color, string)`；`NationalSpire.CareerAvatar.CareerAvatar()`；`string.Contains(string, System.StringComparison)`；`string.Trim()`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）；`System.Math.Clamp(int, int, int)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarArt.Texture`；`NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`；`NationalSpire.AvatarChoice.Name`；`NationalSpire.AvatarChoice.Read`；`NationalSpire.AvatarImages.FromArt(NationalSpire.AvatarArt, string)`；`NationalSpire.AvatarSources.Cards()`；`NationalSpire.CareerAvatar.Art`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.CareerVisuals.Teal`；`Select(NationalSpire.PlayerAvatar)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`item.AddThemeConstantOverride("separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: item.AddThemeConstantOverride("separation", 10);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 78) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 78) }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`grid.AddChild(item)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddChild(item);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`item.AddChild(choose)`；返回值紧邻使用处：`ExpressionStatementSyntax: item.AddChild(choose);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`item.AddChild(new CareerAvatar { Art = art ?? new(null, CareerVisuals.Teal, choice.Name), CustomMinimumSize = new(70, 70), SizeFlagsVertical = SizeFlags.ShrinkCenter })`；返回值紧邻使用处：`ExpressionStatementSyntax: item.AddChild(new CareerAvatar { Art = art ?? new(null, CareerVisuals.Teal, choice.Name), CustomMinimumSize = new(70, 70), SizeFlagsVertical = SizeFlags.ShrinkCenter });`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 78)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 78)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(70, 70)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(70, 70)`
- `NationalSpire.AvatarArt.AvatarArt(Godot.Texture2D?, Godot.Color, string)`；输入表达式：`new(null, CareerVisuals.Teal, choice.Name)`；返回值紧邻使用处：`BinaryExpressionSyntax: art ?? new(null, CareerVisuals.Teal, choice.Name)`
- `NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`；输入表达式：`AvatarAssets.Usable(art?.Texture)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !AvatarAssets.Usable(art?.Texture)`
- `NationalSpire.AvatarImages.FromArt(NationalSpire.AvatarArt, string)`；输入表达式：`AvatarImages.FromArt(art!, category)`；返回值紧邻使用处：`ArgumentSyntax: AvatarImages.FromArt(art!, category)`
- `NationalSpire.AvatarSources.Cards()`；输入表达式：`AvatarSources.Cards()`；返回值紧邻使用处：`AssignmentExpressionSyntax: cards ??= AvatarSources.Cards()`
- `NationalSpire.CareerAvatar.CareerAvatar()`；输入表达式：`new CareerAvatar { Art = art ?? new(null, CareerVisuals.Teal, choice.Name), CustomMinimumSize = new(70, 70), SizeFlagsVertical = SizeFlags.ShrinkCenter }`；返回值紧邻使用处：`ArgumentSyntax: new CareerAvatar { Art = art ?? new(null, CareerVisuals.Teal, choice.Name), CustomMinimumSize = new(70, 70), SizeFlagsVertical = SizeFlags.ShrinkCenter }`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button(choice.Name, () =>                 {                     try { Select(AvatarImages.FromArt(art!, category)); status.Text = "已预览，点击保存头像后生效。"; }                     catch (Exception e) { status.Text = e.Message; }                 }, 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button(choice.Name, () =>                 {                     try { Select(AvatarImages.FromArt(art!, category)); status.Text = "已预览，点击保存头像后生效。"; }                     catch (Exception e) { status.Text = e.Message; }                 }, 0)`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(grid)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(grid);`
- `Select(NationalSpire.PlayerAvatar)`；输入表达式：`Select(AvatarImages.FromArt(art!, category))`；返回值紧邻使用处：`ExpressionStatementSyntax: Select(AvatarImages.FromArt(art!, category));`
- `string.Contains(string, System.StringComparison)`；输入表达式：`c.Name.Contains(search.Text.Trim(), StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => c.Name.Contains(search.Text.Trim(), StringComparison.OrdinalIgnoreCase)`
- `string.Trim()`；输入表达式：`search.Text.Trim()`；返回值紧邻使用处：`ArgumentSyntax: search.Text.Trim()`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`choices.Skip(page * pageSize)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: choices.Skip(page * pageSize).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`choices.Skip(page * pageSize).Take(pageSize)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var choice in choices.Skip(page * pageSize).Take(pageSize))             {                 AvatarArt? art = null; try { art = choice.Read(); } catch { }                 var item = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 78) }; item.AddThemeConstantOverride("separation", 10); grid.AddChild(item);                 item.AddChild(new CareerAvatar { Art = art ?? new(null, CareerVisuals.Teal, choice.Name), CustomMinimumSize = new(70, 70), SizeFlagsVertical = SizeFlags.ShrinkCenter });                 var choose = Button(choice.Name, () =>                 {                     try { Select(AvatarImages.FromArt(art!, category)); status.Text = "已预览，点击保存头像后生效。"; }                     catch (Exception e) { status.Text = e.Message; }                 }, 0);                 choose.AutowrapMode = TextServer.AutowrapMode.WordSmart; choose.SizeFlagsHorizontal = SizeFlags.ExpandFill; choose.Disabled = !AvatarAssets.Usable(art?.Texture); item.AddChild(choose);             }`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`(category == "character" ? characters : cards ??= AvatarSources.Cards())                 .Where(c => c.Name.Contains(search.Text.Trim(), StringComparison.OrdinalIgnoreCase)).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = (category == "character" ? characters : cards ??= AvatarSources.Cards())                 .Where(c => c.Name.Contains(search.Text.Trim(), StringComparison.OrdinalIgnoreCase)).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`(category == "character" ? characters : cards ??= AvatarSources.Cards())                 .Where(c => c.Name.Contains(search.Text.Trim(), StringComparison.OrdinalIgnoreCase))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: (category == "character" ? characters : cards ??= AvatarSources.Cards())                 .Where(c => c.Name.Contains(search.Text.Trim(), StringComparison.OrdinalIgnoreCase)).ToList`
- `System.Func<TResult>.Invoke()`；输入表达式：`choice.Read()`；返回值紧邻使用处：`AssignmentExpressionSyntax: art = choice.Read()`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(page, 0, totalPages - 1)`；返回值紧邻使用处：`AssignmentExpressionSyntax: page = Math.Clamp(page, 0, totalPages - 1)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1, (choices.Count + pageSize - 1) / pageSize)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Max(1, (choices.Count + pageSize - 1) / pageSize)`

**赋值（含属性/字段和局部值）：**

- `Art` = `art ?? new(null, CareerVisuals.Teal, choice.Name)`
- `art` = `choice.Read()`
- `cards` ??= `AvatarSources.Cards()`
- `choose.AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `choose.Disabled` = `!AvatarAssets.Usable(art?.Texture)`
- `choose.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `CustomMinimumSize` = `new(0, 78)`
- `CustomMinimumSize` = `new(70, 70)`
- `next.Disabled` = `page + 1 >= totalPages`
- `page` = `Math.Clamp(page, 0, totalPages - 1)`
- `pages.Text` = `choices.Count == 0 ? "没有找到匹配的图片" : $"{page + 1} / {totalPages} · 共 {choices.Count} 张"`
- `previous.Disabled` = `page == 0`
- `scroll.ScrollVertical` = `0`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `status.Text` = `"已预览，点击保存头像后生效。"`
- `status.Text` = `e.Message`

<a id="symbol-ef2b7f0f94fc"></a>

## `CloseAvatar() — void CloseAvatar()`

来源：源码第 98 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenAvatarSettings(NationalSpire.CareerData, NationalSpire.PlayerAvatar?, System.Action<NationalSpire.PlayerAvatar>?, string, NationalSpire.AvatarArt?)`](AvatarScreen.cs.md#symbol-368e97fdd27f)

**调用：** `Godot.CanvasItem.Hide()`；`Godot.CanvasItem.IsVisibleInTree()`；`Godot.Control.GrabFocus()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.Node.IsInsideTree()`；`Godot.Node.QueueFree()`；`Godot.Node.RemoveChild(Godot.Node)`

**字段、属性、事件及方法组引用：** `(Godot.Control Control, Godot.Control.FocusModeEnum Mode).Control`；`(Godot.Control Control, Godot.Control.FocusModeEnum Mode).Mode`；`NationalSpire.CareerScreen._avatarOverlay`；`NationalSpire.CareerScreen._closeAvatar`；`NationalSpire.CareerScreen._stage`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`shade.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.Hide();`
- `Godot.CanvasItem.IsVisibleInTree()`；输入表达式：`previousFocus.IsVisibleInTree()`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(previousFocus) && previousFocus.IsInsideTree() && !previousFocus.IsQueuedForDeletion() && previousFocus.IsVisibleInTree()`
- `Godot.Control.GrabFocus()`；输入表达式：`previousFocus.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: previousFocus.GrabFocus();`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(entry.Control)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(entry.Control) && !entry.Control.IsQueuedForDeletion()`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(previousFocus)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(previousFocus) && previousFocus.IsInsideTree()`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`entry.Control.IsQueuedForDeletion()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !entry.Control.IsQueuedForDeletion()`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`previousFocus.IsQueuedForDeletion()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !previousFocus.IsQueuedForDeletion()`
- `Godot.Node.IsInsideTree()`；输入表达式：`previousFocus.IsInsideTree()`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(previousFocus) && previousFocus.IsInsideTree()`
- `Godot.Node.QueueFree()`；输入表达式：`shade.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.QueueFree();`
- `Godot.Node.RemoveChild(Godot.Node)`；输入表达式：`_stage.RemoveChild(shade)`；返回值紧邻使用处：`ExpressionStatementSyntax: _stage.RemoveChild(shade);`

**赋值（含属性/字段和局部值）：**

- `_avatarOverlay` = `null`
- `_closeAvatar` = `null`
- `entry.Control.FocusMode` = `entry.Mode`
