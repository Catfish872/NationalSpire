# PortraitDesignScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`B97AADD68A24EAE4BB116854B045C153F1CCD350B93DC579995A5D1204349A52`。来源：[源码](../../PortraitDesignScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-3bb5119a73ca"></a>

## `NationalSpire.CareerScreen.OpenPortraitDesigner(NationalSpire.CareerData, string) — private void OpenPortraitDesigner(CareerData data, string id)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenDateAssets(NationalSpire.CareerData, string)`](DateSceneAssetScreen.cs.md#symbol-a45b4a628cd5)；[`NationalSpire.CareerScreen.PersonProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](ProfileScreen.cs.md#symbol-2d802d5a07b9)；[`NationalSpire.CareerScreen.PlayerProfile(NationalSpire.CareerData)`](ProfileScreen.cs.md#symbol-ce70d1ef24b8)

**调用：** [`CommitIds()`](PortraitDesignScreen.cs.md#symbol-46a98791b53f)；[`Controls(Godot.Node)`](PortraitDesignScreen.cs.md#symbol-eb4712515abb)；[`DrawPage()`](PortraitDesignScreen.cs.md#symbol-5edcd91edd93)；[`Infer()`](PortraitDesignScreen.cs.md#symbol-84dd4f56a6bf)；[`Message(string, bool)`](PortraitDesignScreen.cs.md#symbol-0585a8e825bd)；[`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`](CareerAvatars.cs.md#symbol-9f2c4623a902)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.PrivateIdentityButton(string, System.Action, bool)`](PrivateMemoryScreen.cs.md#symbol-67f8f263b4a9)；[`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-84294149ff91)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.CharacterCards.Read(NationalSpire.CareerData, string)`](CharacterCards.cs.md#symbol-3c3ff9c389dd)；[`NationalSpire.ClubCoaching.IsCoach(NationalSpire.CareerPerson)`](ClubCoaching.cs.md#symbol-8b4ec414486e)；[`NationalSpire.PortraitDesigns.Create(NationalSpire.CareerData, string, NationalSpire.CareerPerson?)`](PortraitDesign.cs.md#symbol-8afe4d7864a5)；[`NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`](PortraitDesignStore.cs.md#symbol-8db102d73ed8)；[`NationalSpire.PortraitDesignStore.Read(string, string)`](PortraitDesignStore.cs.md#symbol-2eeba99f517d)；[`NationalSpire.PortraitDesignStore.Save(string, NationalSpire.PortraitDesign)`](PortraitDesignStore.cs.md#symbol-2f8c936a01d4)；[`NationalSpire.PortraitPromptExport.Write(string, NationalSpire.PortraitDesign, string)`](PortraitPromptExport.cs.md#symbol-bb8047a026c0)；`Godot.Color.Color(float, float, float, float)`；`Godot.Color.Color(string)`；`Godot.ColorRect.ColorRect()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.Control()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.HSeparator.HSeparator()`；`Godot.MarginContainer.MarginContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetViewport()`；`Godot.OS.ShellShowInFileManager(string, bool)`；`Godot.PanelContainer.PanelContainer()`；`Godot.ProjectSettings.GlobalizePath(string)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`Godot.Viewport.GuiGetFocusOwner()`；`NationalSpire.BroadcastScroll.BroadcastScroll()`；`NationalSpire.PrivateIdentityLayout.PrivateIdentityLayout()`；`string.IsNullOrWhiteSpace(string?)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Environment.GetFolderPath(System.Environment.SpecialFolder)`；`System.Threading.CancellationTokenSource.Cancel()`

**字段、属性、事件及方法组引用：** `(Godot.Control Control, Godot.Control.FocusModeEnum Mode).Control`；`(Godot.Control Control, Godot.Control.FocusModeEnum Mode).Mode`；`Close()`；`CommitIds()`；`Controls(Godot.Node)`；`DrawPage()`；`Infer()`；`Message(string, bool)`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CareerPerson.Role`；`NationalSpire.CareerScreen._cancelDialog`；`NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._stage`；`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.PrivateIdentityButton(string, System.Action, bool)`；`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.CharacterCards.Read(NationalSpire.CareerData, string)`；`NationalSpire.ClubCoaching.IsCoach(NationalSpire.CareerPerson)`；`NationalSpire.PortraitDesign.Notes`；`NationalSpire.PortraitDesigns.Create(NationalSpire.CareerData, string, NationalSpire.CareerPerson?)`；`NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`；`NationalSpire.PortraitDesignStore.Read(string, string)`；`NationalSpire.PortraitDesignStore.Save(string, NationalSpire.PortraitDesign)`；`NationalSpire.PortraitPromptExport.Write(string, NationalSpire.PortraitDesign, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CommitIds()`；输入表达式：`CommitIds()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CommitIds()`
- `Controls(Godot.Node)`；输入表达式：`Controls(_stage)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Controls(_stage).Where`
- `DrawPage()`；输入表达式：`DrawPage()`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPage();`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new(0, 0, 0, .78f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Color = new(0, 0, 0, .78f)`
- `Godot.Color.Color(string)`；输入表达式：`new Color("688498")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Modulate = new Color("688498")`
- `Godot.ColorRect.ColorRect()`；输入表达式：`new ColorRect { Name = "PortraitDesigner", Color = new(0, 0, 0, .78f), ZIndex = 40, MouseFilter = MouseFilterEnum.Stop }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ColorRect { Name = "PortraitDesigner", Color = new(0, 0, 0, .78f), ZIndex = 40, MouseFilter = MouseFilterEnum.Stop }`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`actions.AddThemeConstantOverride("separation", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddThemeConstantOverride("separation", 14);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`header.AddThemeConstantOverride("separation", 20)`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddThemeConstantOverride("separation", 20);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`margin.AddThemeConstantOverride("margin_" + side, 32)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddThemeConstantOverride("margin_" + side, 32);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`margin.AddThemeConstantOverride("margin_" + side, 65)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddThemeConstantOverride("margin_" + side, 65);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`page.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: page.AddThemeConstantOverride("separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`root.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: root.AddThemeConstantOverride("separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`tabs.AddThemeConstantOverride("separation", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: tabs.AddThemeConstantOverride("separation", 14);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`title.AddThemeFontSizeOverride("font_size", 28)`；返回值紧邻使用处：`ExpressionStatementSyntax: title.AddThemeFontSizeOverride("font_size", 28);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("192c3e", "6b879b", 12, 24))`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("192c3e", "6b879b", 12, 24));`
- `Godot.Control.Control()`；输入表达式：`new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`ArgumentSyntax: new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { Name = "PortraitIdentity", CustomMinimumSize = new(0, 89) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { Name = "PortraitIdentity", CustomMinimumSize = new(0, 89) }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.HSeparator.HSeparator()`；输入表达式：`new HSeparator { Modulate = new Color("688498") }`；返回值紧邻使用处：`ArgumentSyntax: new HSeparator { Modulate = new Color("688498") }`
- `Godot.MarginContainer.MarginContainer()`；输入表达式：`new MarginContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MarginContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_stage.AddChild(shade)`；返回值紧邻使用处：`ExpressionStatementSyntax: _stage.AddChild(shade);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(Button("保存并关闭", Close, 165))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(Button("保存并关闭", Close, 165));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(export)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(export);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(infer)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(infer);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill })`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(avatar)`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(avatar);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(identity)`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(identity);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`identity.AddChild(role)`；返回值紧邻使用处：`ExpressionStatementSyntax: identity.AddChild(role);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`identity.AddChild(title)`；返回值紧邻使用处：`ExpressionStatementSyntax: identity.AddChild(title);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`margin.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddChild(panel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(root)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(root);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`root.AddChild(actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: root.AddChild(actions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`root.AddChild(header)`；返回值紧邻使用处：`ExpressionStatementSyntax: root.AddChild(header);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`root.AddChild(new HSeparator { Modulate = new Color("688498") })`；返回值紧邻使用处：`ExpressionStatementSyntax: root.AddChild(new HSeparator { Modulate = new Color("688498") });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`root.AddChild(scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: root.AddChild(scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`root.AddChild(status)`；返回值紧邻使用处：`ExpressionStatementSyntax: root.AddChild(status);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`root.AddChild(tabs)`；返回值紧邻使用处：`ExpressionStatementSyntax: root.AddChild(tabs);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`root.AddChild(Text("设计立绘", 26, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: root.AddChild(Text("设计立绘", 26, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scroll.AddChild(page)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.AddChild(page);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`shade.AddChild(margin)`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.AddChild(margin);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`tabs.AddChild(tab)`；返回值紧邻使用处：`ExpressionStatementSyntax: tabs.AddChild(tab);`
- `Godot.Node.GetViewport()`；输入表达式：`GetViewport()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetViewport().GuiGetFocusOwner`
- `Godot.OS.ShellShowInFileManager(string, bool)`；输入表达式：`OS.ShellShowInFileManager(zip)`；返回值紧邻使用处：`ExpressionStatementSyntax: OS.ShellShowInFileManager(zip);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { Name = "PortraitDesignerPanel" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { Name = "PortraitDesignerPanel" }`
- `Godot.ProjectSettings.GlobalizePath(string)`；输入表达式：`ProjectSettings.GlobalizePath("user://portrait_exports")`；返回值紧邻使用处：`AssignmentExpressionSyntax: destination = ProjectSettings.GlobalizePath("user://portrait_exports")`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 89)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 89)`
- `Godot.Viewport.GuiGetFocusOwner()`；输入表达式：`GetViewport().GuiGetFocusOwner()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GetViewport().GuiGetFocusOwner()`
- `Infer()`；输入表达式：`Infer()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = Infer()`
- `Message(string, bool)`；输入表达式：`Message("导出失败，编辑内容已保留：" + e.Message, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Message("导出失败，编辑内容已保留：" + e.Message, true);`
- `Message(string, bool)`；输入表达式：`Message("已导出：" + zip)`；返回值紧邻使用处：`ExpressionStatementSyntax: Message("已导出：" + zip);`
- `NationalSpire.BroadcastScroll.BroadcastScroll()`；输入表达式：`new BroadcastScroll { Name = "PortraitScroll", SizeFlagsVertical = SizeFlags.ExpandFill, HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastScroll { Name = "PortraitScroll", SizeFlagsVertical = SizeFlags.ExpandFill, HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`；输入表达式：`Avatar(data, id, 72, false)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Avatar(data, id, 72, false)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("保存并关闭", Close, 165)`；返回值紧邻使用处：`ArgumentSyntax: Button("保存并关闭", Close, 165)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("导出该套装提示词", () =>          {              if (!CommitIds()) return;              try              {                  PortraitDesignStore.Save(path, design);                  string destination = System.Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);                  if (string.IsNullOrWhiteSpace(destination)) destination = ProjectSettings.GlobalizePath("user://portrait_exports");                  string zip = PortraitPromptExport.Write(destination, design, person.PublicName); Message("已导出：" + zip); OS.ShellShowInFileManager(zip);              }              catch (Exception e) { Message("导出失败，编辑内容已保留：" + e.Message, true); }          }, 240)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("导出该套装提示词", () =>          {              if (!CommitIds()) return;              try              {                  PortraitDesignStore.Save(path, design);                  string destination = System.Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);                  if (string.IsNullOrWhiteSpace(destination)) destination = ProjectSettings.GlobalizePath("user://portrait_exports");                  string zip = PortraitPromptExport.Write(destination, design, person.PublicName); Message("已导出：" + zip); OS.ShellShowInFileManager(zip);              }              catch (Exception e) { Message("导出失败，编辑内容已保留：" + e.Message, true); }          }, 240)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("根据资料推测", () => { _ = Infer(); }, 180)`；返回值紧邻使用处：`AssignmentExpressionSyntax: infer = Button("根据资料推测", () => { _ = Infer(); }, 180)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button(text, () =>              {                  if (!CommitIds()) return;                  selectedTab = index; for (int i = 0; i < tabButtons.Count; i++) tabButtons[i].Modulate = i == index ? CareerVisuals.Teal : Colors.White;                  scroll.ScrollVertical = 0; DrawPage();              }, 165)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button(text, () =>              {                  if (!CommitIds()) return;                  selectedTab = index; for (int i = 0; i < tabButtons.Count; i++) tabButtons[i].Modulate = i == index ? CareerVisuals.Teal : Colors.White;                  scroll.ScrollVertical = 0; DrawPage();              }, 165)`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("读取立绘设计失败：" + e.Message, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("读取立绘设计失败：" + e.Message, true);`
- `NationalSpire.CareerScreen.PrivateIdentityButton(string, System.Action, bool)`；输入表达式：`PrivateIdentityButton("PortraitName", () => { })`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateIdentityButton("PortraitName", () => { })`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine(person.Role + (ClubCoaching.IsCoach(person) ? " · 俱乐部教练" : "") + "  /  " + person.Country, 14, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateLine(person.Role + (ClubCoaching.IsCoach(person) ? " · 俱乐部教练" : "") + "  /  " + person.Country, 14, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("设计立绘", 26, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("设计立绘", 26, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(design.Notes, 15, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text(design.Notes, 15, _muted)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("192c3e", "6b879b", 12, 24)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("192c3e", "6b879b", 12, 24)`
- `NationalSpire.CharacterCards.Read(NationalSpire.CareerData, string)`；输入表达式：`CharacterCards.Read(data, id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CharacterCards.Read(data, id)`
- `NationalSpire.ClubCoaching.IsCoach(NationalSpire.CareerPerson)`；输入表达式：`ClubCoaching.IsCoach(person)`；返回值紧邻使用处：`ConditionalExpressionSyntax: ClubCoaching.IsCoach(person) ? " · 俱乐部教练" : ""`
- `NationalSpire.PortraitDesigns.Create(NationalSpire.CareerData, string, NationalSpire.CareerPerson?)`；输入表达式：`PortraitDesigns.Create(data, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: PortraitDesignStore.Read(path, id) ?? PortraitDesigns.Create(data, id)`
- `NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`；输入表达式：`PortraitDesignStore.FilePath(data, id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PortraitDesignStore.FilePath(data, id)`
- `NationalSpire.PortraitDesignStore.Read(string, string)`；输入表达式：`PortraitDesignStore.Read(path, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: PortraitDesignStore.Read(path, id) ?? PortraitDesigns.Create(data, id)`
- `NationalSpire.PortraitDesignStore.Save(string, NationalSpire.PortraitDesign)`；输入表达式：`PortraitDesignStore.Save(path, design)`；返回值紧邻使用处：`ExpressionStatementSyntax: PortraitDesignStore.Save(path, design);`
- `NationalSpire.PortraitPromptExport.Write(string, NationalSpire.PortraitDesign, string)`；输入表达式：`PortraitPromptExport.Write(destination, design, person.PublicName)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PortraitPromptExport.Write(destination, design, person.PublicName)`
- `NationalSpire.PrivateIdentityLayout.PrivateIdentityLayout()`；输入表达式：`new PrivateIdentityLayout { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsVertical = SizeFlags.ShrinkCenter }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PrivateIdentityLayout { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsVertical = SizeFlags.ShrinkCenter }`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(destination)`；返回值紧邻使用处：`IfStatementSyntax: if (string.IsNullOrWhiteSpace(destination)) destination = ProjectSettings.GlobalizePath("user://portrait_exports");`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Controls(_stage).Where(c => c.FocusMode != FocusModeEnum.None).Select(c => (Control: c, Mode: c.FocusMode))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Controls(_stage).Where(c => c.FocusMode != FocusModeEnum.None).Select(c => (Control: c, Mode: c.FocusMode)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Controls(_stage).Where(c => c.FocusMode != FocusModeEnum.None).Select(c => (Control: c, Mode: c.FocusMode)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Controls(_stage).Where(c => c.FocusMode != FocusModeEnum.None).Select(c => (Control: c, Mode: c.FocusMode)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Controls(_stage).Where(c => c.FocusMode != FocusModeEnum.None)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Controls(_stage).Where(c => c.FocusMode != FocusModeEnum.None).Select`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`tabButtons.Add(tab)`；返回值紧邻使用处：`ExpressionStatementSyntax: tabButtons.Add(tab);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<Button>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<Button>()`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<Func<bool>>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<Func<bool>>()`
- `System.Environment.GetFolderPath(System.Environment.SpecialFolder)`；输入表达式：`System.Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = System.Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory)`
- `System.Threading.CancellationTokenSource.Cancel()`；输入表达式：`.Cancel()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: pending?.Cancel()`

**赋值（含属性/字段和局部值）：**

- `_` = `Infer()`
- `_cancelDialog` = `Close`
- `_dialogOverlay` = `shade`
- `avatar.SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `closed` = `true`
- `Color` = `new(0, 0, 0, .78f)`
- `CustomMinimumSize` = `new(0, 89)`
- `design` = `PortraitDesignStore.Read(path, id) ?? PortraitDesigns.Create(data, id)`
- `destination` = `ProjectSettings.GlobalizePath("user://portrait_exports")`
- `export.Name` = `"PortraitExport"`
- `f.Control.FocusMode` = `FocusModeEnum.None`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `infer.Name` = `"PortraitInfer"`
- `infer` = `Button("根据资料推测", () => { _ = Infer(); }, 180)`
- `Modulate` = `new Color("688498")`
- `MouseFilter` = `MouseFilterEnum.Stop`
- `Name` = `"PortraitDesigner"`
- `Name` = `"PortraitDesignerPanel"`
- `Name` = `"PortraitIdentity"`
- `Name` = `"PortraitScroll"`
- `role.TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`
- `scroll.ScrollVertical` = `0`
- `selectedTab` = `index`
- `shade.TreeExiting` += `() => { closed = true; pending?.Cancel(); }`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `status.MaxLinesVisible` = `2`
- `status.Name` = `"PortraitStatus"`
- `status.TooltipText` = `design.Notes`
- `tab.Name` = `"PortraitTab" + index`
- `tabButtons[0].Modulate` = `CareerVisuals.Teal`
- `tabButtons[i].Modulate` = `i == index ? CareerVisuals.Teal : Colors.White`
- `title.Alignment` = `HorizontalAlignment.Left`
- `title.Text` = `person.PublicName`
- `title.TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`
- `title.TooltipText` = `person.PublicName`
- `ZIndex` = `40`

<a id="symbol-eb4712515abb"></a>

## `Controls(Godot.Node) — IEnumerable<Control> Controls(Node node)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Controls(Godot.Node)`](PortraitDesignScreen.cs.md#symbol-eb4712515abb)；[`NationalSpire.CareerScreen.OpenPortraitDesigner(NationalSpire.CareerData, string)`](PortraitDesignScreen.cs.md#symbol-3bb5119a73ca)

**调用：** [`Controls(Godot.Node)`](PortraitDesignScreen.cs.md#symbol-eb4712515abb)；`Godot.Node.GetChildren(bool)`；`System.Array.Empty<T>()`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`

**字段、属性、事件及方法组引用：** `Controls(Godot.Node)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Controls(Godot.Node)`；输入表达式：`Controls(child)`；返回值紧邻使用处：`ArgumentSyntax: Controls(child)`
- `Godot.Node.GetChildren(bool)`；输入表达式：`node.GetChildren()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: node.GetChildren().SelectMany`
- `System.Array.Empty<T>()`；输入表达式：`Array.Empty<Control>()`；返回值紧邻使用处：`ConditionalExpressionSyntax: child is Control c ? new[] { c } : Array.Empty<Control>()`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`(child is Control c ? new[] { c } : Array.Empty<Control>()).Concat(Controls(child))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: child => (child is Control c ? new[] { c } : Array.Empty<Control>()).Concat(Controls(child))`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`node.GetChildren().SelectMany(child => (child is Control c ? new[] { c } : Array.Empty<Control>()).Concat(Controls(child)))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => node.GetChildren().SelectMany(child => (child is Control c ? new[] { c } : Array.Empty<Control>()).Concat(Controls(child)))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b5e3595bf2d6"></a>

## `Alive() — bool Alive()`

来源：源码第 42 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Infer()`](PortraitDesignScreen.cs.md#symbol-84dd4f56a6bf)

**调用：** [`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`](CareerStore.cs.md#symbol-ead7461ee7cb)；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.IsQueuedForDeletion()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(shade)`；返回值紧邻使用处：`BinaryExpressionSyntax: !closed && IsInstanceValid(shade)`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`shade.IsQueuedForDeletion()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !shade.IsQueuedForDeletion()`
- `NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；输入表达式：`CareerStore.IsCurrent(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: !closed && IsInstanceValid(shade) && !shade.IsQueuedForDeletion() && CareerStore.IsCurrent(data)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0585a8e825bd"></a>

## `Message(string, bool) — void Message(string text, bool error = false)`

来源：源码第 43 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Close()`](PortraitDesignScreen.cs.md#symbol-9a2763e37828)；[`CommitId()`](PortraitDesignScreen.cs.md#symbol-7f00b8a4d151)；[`Infer()`](PortraitDesignScreen.cs.md#symbol-84dd4f56a6bf)；[`NationalSpire.CareerScreen.OpenPortraitDesigner(NationalSpire.CareerData, string)`](PortraitDesignScreen.cs.md#symbol-3bb5119a73ca)

**调用：** `Godot.Color.Color(string)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("ee929d")`；返回值紧邻使用处：`ConditionalExpressionSyntax: error ? new Color("ee929d") : Colors.White`

**赋值（含属性/字段和局部值）：**

- `status.Modulate` = `error ? new Color("ee929d") : Colors.White`
- `status.Text` = `text`
- `status.TooltipText` = `text`

<a id="symbol-46a98791b53f"></a>

## `CommitIds() — bool CommitIds()`

来源：源码第 44 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Close()`](PortraitDesignScreen.cs.md#symbol-9a2763e37828)；[`DrawPage()`](PortraitDesignScreen.cs.md#symbol-5edcd91edd93)；[`Infer()`](PortraitDesignScreen.cs.md#symbol-84dd4f56a6bf)；[`NationalSpire.CareerScreen.OpenPortraitDesigner(NationalSpire.CareerData, string)`](PortraitDesignScreen.cs.md#symbol-3bb5119a73ca)

**调用：** `System.Func<TResult>.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Func<TResult>.Invoke()`；输入表达式：`commit()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !commit()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-559316585c52"></a>

## `Field(Godot.Control, string, string, System.Action<string>, string) — LineEdit Field(Control parent, string label, string value, Action<string> changed, string name)`

来源：源码第 45 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`DrawPage()`](PortraitDesignScreen.cs.md#symbol-5edcd91edd93)

**调用：** [`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation", 7)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation", 7);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`input.AddThemeFontSizeOverride("font_size", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: input.AddThemeFontSizeOverride("font_size", 18);`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Name = name, Text = value, CustomMinimumSize = new(0, 44), SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LineEdit { Name = name, Text = value, CustomMinimumSize = new(0, 44), SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(input)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(input);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(label, 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(label, 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(box)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(box);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 44)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 44)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(label, 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(label, 15, _muted)`
- `System.Action<T>.Invoke(T)`；输入表达式：`changed(value)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: value => changed(value)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(0, 44)`
- `input.ExpandToTextLength` = `false`
- `input.TextChanged` += `value => changed(value)`
- `Name` = `name`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Text` = `value`

<a id="symbol-3c033cf416e7"></a>

## `Grid(Godot.Control) — GridContainer Grid(Control parent)`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`DrawPage()`](PortraitDesignScreen.cs.md#symbol-5edcd91edd93)

**调用：** `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.GridContainer.GridContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("h_separation", 24)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("h_separation", 24);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("v_separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("v_separation", 16);`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(grid)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(grid);`

**赋值（含属性/字段和局部值）：**

- `Columns` = `2`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-5edcd91edd93"></a>

## `DrawPage() — void DrawPage()`

来源：源码第 56 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`DrawPage()`](PortraitDesignScreen.cs.md#symbol-5edcd91edd93)；[`Infer()`](PortraitDesignScreen.cs.md#symbol-84dd4f56a6bf)；[`NationalSpire.CareerScreen.OpenPortraitDesigner(NationalSpire.CareerData, string)`](PortraitDesignScreen.cs.md#symbol-3bb5119a73ca)

**调用：** [`CommitId()`](PortraitDesignScreen.cs.md#symbol-7f00b8a4d151)；[`CommitIds()`](PortraitDesignScreen.cs.md#symbol-46a98791b53f)；[`DrawPage()`](PortraitDesignScreen.cs.md#symbol-5edcd91edd93)；[`Field(Godot.Control, string, string, System.Action<string>, string)`](PortraitDesignScreen.cs.md#symbol-559316585c52)；[`Grid(Godot.Control)`](PortraitDesignScreen.cs.md#symbol-3c033cf416e7)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.DrawPortraitStyles(Godot.VBoxContainer, NationalSpire.PortraitDesign)`](PortraitStyleScreen.cs.md#symbol-f030328fcc3e)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.PortraitDesigns.CustomEmotion(NationalSpire.PortraitEmotion)`](PortraitDesign.cs.md#symbol-b97d830814e5)；[`NationalSpire.PortraitDesigns.NewEmotion(NationalSpire.PortraitDesign)`](PortraitDesign.cs.md#symbol-c1635a7761da)；[`NationalSpire.PortraitDesigns.NewOutfit(NationalSpire.PortraitDesign)`](PortraitDesign.cs.md#symbol-869d10ff2f64)；`Godot.CheckBox.CheckBox()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.HSeparator.HSeparator()`；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChildren(bool)`；`Godot.Node.QueueFree()`；`Godot.Node.RemoveChild(Godot.Node)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.OptionButton()`；`Godot.OptionButton.Select(int)`；`Godot.OptionButton.SetItemText(int, string)`；`Godot.PanelContainer.PanelContainer()`；`Godot.TextEdit.TextEdit()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Clear()`；`System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `CommitId()`；`CommitIds()`；`DrawPage()`；`Field(Godot.Control, string, string, System.Action<string>, string)`；`Grid(Godot.Control)`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.DrawPortraitStyles(Godot.VBoxContainer, NationalSpire.PortraitDesign)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.PortraitDesign.Basics`；`NationalSpire.PortraitDesign.DefaultEmotionId`；`NationalSpire.PortraitDesign.Emotions`；`NationalSpire.PortraitDesign.Outfits`；`NationalSpire.PortraitDesign.SelectedOutfit`；`NationalSpire.PortraitDesigns.BasicFields`；`NationalSpire.PortraitDesigns.CustomEmotion(NationalSpire.PortraitEmotion)`；`NationalSpire.PortraitDesigns.NewEmotion(NationalSpire.PortraitDesign)`；`NationalSpire.PortraitDesigns.NewOutfit(NationalSpire.PortraitDesign)`；`NationalSpire.PortraitDesigns.OutfitFields`；`NationalSpire.PortraitEmotion.Description`；`NationalSpire.PortraitEmotion.Enabled`；`NationalSpire.PortraitEmotion.Id`；`NationalSpire.PortraitEmotion.Name`；`NationalSpire.PortraitOutfit.Fields`；`NationalSpire.PortraitOutfit.Id`；`NationalSpire.PortraitOutfit.Name`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CommitId()`；输入表达式：`CommitId()`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => CommitId()`
- `CommitId()`；输入表达式：`CommitId()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _ => CommitId()`
- `CommitIds()`；输入表达式：`CommitIds()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CommitIds()`
- `DrawPage()`；输入表达式：`DrawPage()`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPage();`
- `Field(Godot.Control, string, string, System.Action<string>, string)`；输入表达式：`Field(grid, label, design.Basics.GetValueOrDefault(key, ""), v => design.Basics[key] = v, "PortraitBasic_" + key)`；返回值紧邻使用处：`ExpressionStatementSyntax: Field(grid, label, design.Basics.GetValueOrDefault(key, ""), v => design.Basics[key] = v, "PortraitBasic_" + key);`
- `Field(Godot.Control, string, string, System.Action<string>, string)`；输入表达式：`Field(grid, label, outfit.Fields.GetValueOrDefault(key, ""), v => outfit.Fields[key] = v, "PortraitOutfit_" + key)`；返回值紧邻使用处：`ExpressionStatementSyntax: Field(grid, label, outfit.Fields.GetValueOrDefault(key, ""), v => outfit.Fields[key] = v, "PortraitOutfit_" + key);`
- `Field(Godot.Control, string, string, System.Action<string>, string)`；输入表达式：`Field(page, "套装名称", outfit.Name, value => { outfit.Name = value; choice.SetItemText(index, value); }, "PortraitOutfitName")`；返回值紧邻使用处：`ExpressionStatementSyntax: Field(page, "套装名称", outfit.Name, value => { outfit.Name = value; choice.SetItemText(index, value); }, "PortraitOutfitName");`
- `Godot.CheckBox.CheckBox()`；输入表达式：`new CheckBox { Name = "PortraitEnabled_" + emotion.Id, ButtonPressed = emotion.Enabled, Disabled = emotion.Id == design.DefaultEmotionId, TooltipText = emotion.Id == design.DefaultEmotionId ? "平淡差分作为基准保留" : "加入导出包" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CheckBox { Name = "PortraitEnabled_" + emotion.Id, ButtonPressed = emotion.Enabled, Disabled = emotion.Id == design.DefaultEmotionId, TooltipText = emotion.Id == design.DefaultEmotionId ? "平淡差分作为基准保留" : "加入导出包" }`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation", 9)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation", 9);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 14);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`selector.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: selector.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`code.AddThemeFontSizeOverride("font_size", 15)`；返回值紧邻使用处：`ExpressionStatementSyntax: code.AddThemeFontSizeOverride("font_size", 15);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`description.AddThemeFontSizeOverride("font_size", 17)`；返回值紧邻使用处：`ExpressionStatementSyntax: description.AddThemeFontSizeOverride("font_size", 17);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("1d3344", "38586c", 7, 12))`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("1d3344", "38586c", 7, 12));`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.HSeparator.HSeparator()`；输入表达式：`new HSeparator()`；返回值紧邻使用处：`ArgumentSyntax: new HSeparator()`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Name = "PortraitEmotion_" + emotion.Id, Text = emotion.Name, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 42) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LineEdit { Name = "PortraitEmotion_" + emotion.Id, Text = emotion.Name, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 42) }`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Name = "PortraitEmotionId_" + emotion.Id, Text = emotion.Id, CustomMinimumSize = new(260, 42), ExpandToTextLength = false,                              TooltipText = "情绪ID：小写字母开头，可含数字和下划线，最长64位。回车或离开输入栏时应用；新导出的文件名和清单使用此ID。" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LineEdit { Name = "PortraitEmotionId_" + emotion.Id, Text = emotion.Id, CustomMinimumSize = new(260, 42), ExpandToTextLength = false,                              TooltipText = "情绪ID：小写字母开头，可含数字和下划线，最长64位。回车或离开输入栏时应用；新导出的文件名和清单使用此ID。" }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(description)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(description);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text("表情与动作", 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text("表情与动作", 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`card.AddChild(box)`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddChild(box);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`page.AddChild(addEmotion)`；返回值紧邻使用处：`ExpressionStatementSyntax: page.AddChild(addEmotion);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`page.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: page.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`page.AddChild(new HSeparator())`；返回值紧邻使用处：`ExpressionStatementSyntax: page.AddChild(new HSeparator());`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`page.AddChild(selector)`；返回值紧邻使用处：`ExpressionStatementSyntax: page.AddChild(selector);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(code)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(code);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(enabled)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(enabled);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(label)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(label);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`selector.AddChild(add)`；返回值紧邻使用处：`ExpressionStatementSyntax: selector.AddChild(add);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`selector.AddChild(choice)`；返回值紧邻使用处：`ExpressionStatementSyntax: selector.AddChild(choice);`
- `Godot.Node.GetChildren(bool)`；输入表达式：`page.GetChildren()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var child in page.GetChildren()) { page.RemoveChild(child); child.QueueFree(); }`
- `Godot.Node.QueueFree()`；输入表达式：`child.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: child.QueueFree();`
- `Godot.Node.RemoveChild(Godot.Node)`；输入表达式：`page.RemoveChild(child)`；返回值紧邻使用处：`ExpressionStatementSyntax: page.RemoveChild(child);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`choice.AddItem(item.Name)`；返回值紧邻使用处：`ExpressionStatementSyntax: choice.AddItem(item.Name);`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { Name = "PortraitOutfitChoice", FitToLongestItem = false, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 46) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { Name = "PortraitOutfitChoice", FitToLongestItem = false, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 46) }`
- `Godot.OptionButton.Select(int)`；输入表达式：`choice.Select(index)`；返回值紧邻使用处：`ExpressionStatementSyntax: choice.Select(index);`
- `Godot.OptionButton.SetItemText(int, string)`；输入表达式：`choice.SetItemText(index, value)`；返回值紧邻使用处：`ExpressionStatementSyntax: choice.SetItemText(index, value);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer()`
- `Godot.TextEdit.TextEdit()`；输入表达式：`new TextEdit { Name = "PortraitExpression_" + emotion.Id, Text = emotion.Description, CustomMinimumSize = new(0, 102),                          SizeFlagsHorizontal = SizeFlags.ExpandFill, WrapMode = TextEdit.LineWrappingMode.Boundary }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TextEdit { Name = "PortraitExpression_" + emotion.Id, Text = emotion.Description, CustomMinimumSize = new(0, 102),                          SizeFlagsHorizontal = SizeFlags.ExpandFill, WrapMode = TextEdit.LineWrappingMode.Boundary }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 102)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 102)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 42)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 46)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 46)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(110, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: code.CustomMinimumSize = new(110, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(260, 42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(260, 42)`
- `Grid(Godot.Control)`；输入表达式：`Grid(page)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Grid(page)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("＋ 添加情绪差分", () => { if (!CommitIds()) return; PortraitDesigns.NewEmotion(design); DrawPage(); }, 210)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("＋ 添加情绪差分", () => { if (!CommitIds()) return; PortraitDesigns.NewEmotion(design); DrawPage(); }, 210)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("+", () => { PortraitDesigns.NewOutfit(design); DrawPage(); }, 46)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("+", () => { PortraitDesigns.NewOutfit(design); DrawPage(); }, 46)`
- `NationalSpire.CareerScreen.DrawPortraitStyles(Godot.VBoxContainer, NationalSpire.PortraitDesign)`；输入表达式：`DrawPortraitStyles(page, design)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPortraitStyles(page, design);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("表情与动作", 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("表情与动作", 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("ID · " + emotion.Id, 13, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("ID · " + emotion.Id, 13, _muted)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("1d3344", "38586c", 7, 12)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("1d3344", "38586c", 7, 12)`
- `NationalSpire.PortraitDesigns.CustomEmotion(NationalSpire.PortraitEmotion)`；输入表达式：`PortraitDesigns.CustomEmotion(emotion)`；返回值紧邻使用处：`IfStatementSyntax: if (PortraitDesigns.CustomEmotion(emotion))                      {                          var code = new LineEdit { Name = "PortraitEmotionId_" + emotion.Id, Text = emotion.Id, CustomMinimumSize = new(260, 42), ExpandToTextLength = false,                              TooltipText = "情绪ID：小写字母开头，可含数字和下划线，最长64位。回车或离开输入栏时应用；新导出的文件名和清单使用此ID。" };                          code.AddThemeFontSizeOverride("font_size", 15); row.AddChild(code);                          bool CommitId()                          {                              if (PortraitDesigns.RenameEmotion(design, emotion, code.Text) is { } error)                              { code.Modulate = new Color("ee929d"); Message(error, true); return false; }                              bool corrected = code.Modulate != Colors.White; code.Text = emotion.Id; code.Modulate = Colors.White;                              if (corrected) Message("情绪ID已更新；再次导出时生成对应文件名与清单。");                              return true;                          }                          idEditors.Add(CommitId); code.TextSubmitted += _ => CommitId(); code.FocusExited += () => CommitId();                      }                      else                      {                          var code = Text("ID · " + emotion.Id, 13, _muted); code.CustomMinimumSize = new(110, 0); code.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis;                          code.AutowrapMode = TextServer.AutowrapMode.Off; code.TooltipText = emotion.Id; row.AddChild(code);                      }`
- `NationalSpire.PortraitDesigns.NewEmotion(NationalSpire.PortraitDesign)`；输入表达式：`PortraitDesigns.NewEmotion(design)`；返回值紧邻使用处：`ExpressionStatementSyntax: PortraitDesigns.NewEmotion(design);`
- `NationalSpire.PortraitDesigns.NewOutfit(NationalSpire.PortraitDesign)`；输入表达式：`PortraitDesigns.NewOutfit(design)`；返回值紧邻使用处：`ExpressionStatementSyntax: PortraitDesigns.NewOutfit(design);`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`design.Basics.GetValueOrDefault(key, "")`；返回值紧邻使用处：`ArgumentSyntax: design.Basics.GetValueOrDefault(key, "")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`outfit.Fields.GetValueOrDefault(key, "")`；返回值紧邻使用处：`ArgumentSyntax: outfit.Fields.GetValueOrDefault(key, "")`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`idEditors.Add(CommitId)`；返回值紧邻使用处：`ExpressionStatementSyntax: idEditors.Add(CommitId);`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`idEditors.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: idEditors.Clear();`
- `System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；输入表达式：`design.Outfits.FindIndex(o => o.Id == design.SelectedOutfit)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = design.Outfits.FindIndex(o => o.Id == design.SelectedOutfit)`

**赋值（含属性/字段和局部值）：**

- `add.Name` = `"PortraitNewOutfit"`
- `addEmotion.Name` = `"PortraitNewEmotion"`
- `ButtonPressed` = `emotion.Enabled`
- `choice.ItemSelected` += `value => { design.SelectedOutfit = design.Outfits[(int)value].Id; DrawPage(); }`
- `code.AutowrapMode` = `TextServer.AutowrapMode.Off`
- `code.CustomMinimumSize` = `new(110, 0)`
- `code.FocusExited` += `() => CommitId()`
- `code.TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`
- `code.TextSubmitted` += `_ => CommitId()`
- `code.TooltipText` = `emotion.Id`
- `CustomMinimumSize` = `new(0, 102)`
- `CustomMinimumSize` = `new(0, 42)`
- `CustomMinimumSize` = `new(0, 46)`
- `CustomMinimumSize` = `new(260, 42)`
- `description.TextChanged` += `() => emotion.Description = description.Text`
- `design.Basics[key]` = `v`
- `design.SelectedOutfit` = `design.Outfits[(int)value].Id`
- `Disabled` = `emotion.Id == design.DefaultEmotionId`
- `emotion.Description` = `description.Text`
- `emotion.Enabled` = `value`
- `emotion.Name` = `value`
- `enabled.Toggled` += `value => emotion.Enabled = value`
- `ExpandToTextLength` = `false`
- `FitToLongestItem` = `false`
- `label.TextChanged` += `value => emotion.Name = value`
- `Name` = `"PortraitEmotion_" + emotion.Id`
- `Name` = `"PortraitEmotionId_" + emotion.Id`
- `Name` = `"PortraitEnabled_" + emotion.Id`
- `Name` = `"PortraitExpression_" + emotion.Id`
- `Name` = `"PortraitOutfitChoice"`
- `outfit.Fields[key]` = `v`
- `outfit.Name` = `value`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Text` = `emotion.Description`
- `Text` = `emotion.Id`
- `Text` = `emotion.Name`
- `TooltipText` = `"情绪ID：小写字母开头，可含数字和下划线，最长64位。回车或离开输入栏时应用；新导出的文件名和清单使用此ID。"`
- `TooltipText` = `emotion.Id == design.DefaultEmotionId ? "平淡差分作为基准保留" : "加入导出包"`
- `WrapMode` = `TextEdit.LineWrappingMode.Boundary`

<a id="symbol-7f00b8a4d151"></a>

## `CommitId() — bool CommitId()`

来源：源码第 84 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`DrawPage()`](PortraitDesignScreen.cs.md#symbol-5edcd91edd93)

**调用：** [`Message(string, bool)`](PortraitDesignScreen.cs.md#symbol-0585a8e825bd)；[`NationalSpire.PortraitDesigns.RenameEmotion(NationalSpire.PortraitDesign, NationalSpire.PortraitEmotion, string)`](PortraitDesign.cs.md#symbol-72711df647d3)；`Godot.Color.Color(string)`

**字段、属性、事件及方法组引用：** `Message(string, bool)`；`NationalSpire.PortraitDesigns.RenameEmotion(NationalSpire.PortraitDesign, NationalSpire.PortraitEmotion, string)`；`NationalSpire.PortraitEmotion.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("ee929d")`；返回值紧邻使用处：`AssignmentExpressionSyntax: code.Modulate = new Color("ee929d")`
- `Message(string, bool)`；输入表达式：`Message("情绪ID已更新；再次导出时生成对应文件名与清单。")`；返回值紧邻使用处：`ExpressionStatementSyntax: Message("情绪ID已更新；再次导出时生成对应文件名与清单。");`
- `Message(string, bool)`；输入表达式：`Message(error, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Message(error, true);`
- `NationalSpire.PortraitDesigns.RenameEmotion(NationalSpire.PortraitDesign, NationalSpire.PortraitEmotion, string)`；输入表达式：`PortraitDesigns.RenameEmotion(design, emotion, code.Text)`；返回值紧邻使用处：`IsPatternExpressionSyntax: PortraitDesigns.RenameEmotion(design, emotion, code.Text) is { } error`

**赋值（含属性/字段和局部值）：**

- `code.Modulate` = `Colors.White`
- `code.Modulate` = `new Color("ee929d")`
- `code.Text` = `emotion.Id`

<a id="symbol-9a2763e37828"></a>

## `Close() — void Close()`

来源：源码第 132 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`CommitIds()`](PortraitDesignScreen.cs.md#symbol-46a98791b53f)；[`Message(string, bool)`](PortraitDesignScreen.cs.md#symbol-0585a8e825bd)；[`NationalSpire.PortraitDesignStore.Save(string, NationalSpire.PortraitDesign)`](PortraitDesignStore.cs.md#symbol-2f8c936a01d4)；`Godot.CanvasItem.Hide()`；`Godot.CanvasItem.IsVisibleInTree()`；`Godot.Control.GrabFocus()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.Node.IsInsideTree()`；`Godot.Node.QueueFree()`；`System.Threading.CancellationTokenSource.Cancel()`

**字段、属性、事件及方法组引用：** `(Godot.Control Control, Godot.Control.FocusModeEnum Mode).Control`；`(Godot.Control Control, Godot.Control.FocusModeEnum Mode).Mode`；`CommitIds()`；`Message(string, bool)`；`NationalSpire.CareerScreen._cancelDialog`；`NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.PortraitDesignStore.Save(string, NationalSpire.PortraitDesign)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CommitIds()`；输入表达式：`CommitIds()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CommitIds()`
- `Godot.CanvasItem.Hide()`；输入表达式：`shade.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.Hide();`
- `Godot.CanvasItem.IsVisibleInTree()`；输入表达式：`oldFocus.IsVisibleInTree()`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(oldFocus) && oldFocus.IsInsideTree() && oldFocus.IsVisibleInTree()`
- `Godot.Control.GrabFocus()`；输入表达式：`oldFocus.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: oldFocus.GrabFocus();`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(f.Control)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(f.Control) && !f.Control.IsQueuedForDeletion()`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(oldFocus)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(oldFocus) && oldFocus.IsInsideTree()`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`f.Control.IsQueuedForDeletion()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !f.Control.IsQueuedForDeletion()`
- `Godot.Node.IsInsideTree()`；输入表达式：`oldFocus.IsInsideTree()`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(oldFocus) && oldFocus.IsInsideTree()`
- `Godot.Node.QueueFree()`；输入表达式：`shade.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.QueueFree();`
- `Message(string, bool)`；输入表达式：`Message("保存失败，编辑内容仍保留：" + e.Message, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Message("保存失败，编辑内容仍保留：" + e.Message, true);`
- `NationalSpire.PortraitDesignStore.Save(string, NationalSpire.PortraitDesign)`；输入表达式：`PortraitDesignStore.Save(path, design)`；返回值紧邻使用处：`ExpressionStatementSyntax: PortraitDesignStore.Save(path, design);`
- `System.Threading.CancellationTokenSource.Cancel()`；输入表达式：`.Cancel()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: pending?.Cancel()`

**赋值（含属性/字段和局部值）：**

- `_cancelDialog` = `null`
- `_dialogOverlay` = `null`
- `closed` = `true`
- `f.Control.FocusMode` = `f.Mode`

<a id="symbol-84dd4f56a6bf"></a>

## `Infer() — async Task Infer()`

来源：源码第 145 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenPortraitDesigner(NationalSpire.CareerData, string)`](PortraitDesignScreen.cs.md#symbol-3bb5119a73ca)

**调用：** [`Alive()`](PortraitDesignScreen.cs.md#symbol-b5e3595bf2d6)；[`CommitIds()`](PortraitDesignScreen.cs.md#symbol-46a98791b53f)；[`DrawPage()`](PortraitDesignScreen.cs.md#symbol-5edcd91edd93)；[`Message(string, bool)`](PortraitDesignScreen.cs.md#symbol-0585a8e825bd)；[`NationalSpire.AiService.FailureReason(System.Exception)`](AiService.cs.md#symbol-a50bcbf6dda5)；[`NationalSpire.AiService.InferPortraitAsync(NationalSpire.CareerData, string, NationalSpire.PortraitDesign, System.Threading.CancellationToken)`](AiPortraitDesign.cs.md#symbol-b767cc172aa6)；[`NationalSpire.PlayerFacingText.LongError(string)`](PlayerFacingText.cs.md#symbol-f9422d3b8971)；[`NationalSpire.PortraitDesigns.MergeInference(NationalSpire.PortraitDesign, NationalSpire.PortraitDesign, string)`](PortraitDesign.cs.md#symbol-d981122aaf23)；[`NationalSpire.PortraitDesignStore.Save(string, NationalSpire.PortraitDesign)`](PortraitDesignStore.cs.md#symbol-2f8c936a01d4)；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；`System.Threading.CancellationToken.ThrowIfCancellationRequested()`；`System.Threading.CancellationTokenSource.Cancel()`；`System.Threading.CancellationTokenSource.CancellationTokenSource()`；`System.Threading.CancellationTokenSource.Dispose()`

**字段、属性、事件及方法组引用：** `Alive()`；`CommitIds()`；`DrawPage()`；`Message(string, bool)`；`NationalSpire.AiService.FailureReason(System.Exception)`；`NationalSpire.AiService.InferPortraitAsync(NationalSpire.CareerData, string, NationalSpire.PortraitDesign, System.Threading.CancellationToken)`；`NationalSpire.PlayerFacingText.LongError(string)`；`NationalSpire.PortraitDesign.Notes`；`NationalSpire.PortraitDesigns.Json`；`NationalSpire.PortraitDesigns.MergeInference(NationalSpire.PortraitDesign, NationalSpire.PortraitDesign, string)`；`NationalSpire.PortraitDesignStore.Save(string, NationalSpire.PortraitDesign)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Alive()`；输入表达式：`Alive()`；返回值紧邻使用处：`IfStatementSyntax: if (Alive()) infer!.Text = "根据资料推测";`
- `Alive()`；输入表达式：`Alive()`；返回值紧邻使用处：`IfStatementSyntax: if (Alive()) Message("推测未完成，可重试或直接编辑：" + PlayerFacingText.LongError(AiService.FailureReason(e)), true);`
- `Alive()`；输入表达式：`Alive()`；返回值紧邻使用处：`IfStatementSyntax: if (Alive()) Message("已停止推测，当前编辑已保留。");`
- `Alive()`；输入表达式：`Alive()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Alive()`
- `CommitIds()`；输入表达式：`CommitIds()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CommitIds()`
- `DrawPage()`；输入表达式：`DrawPage()`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPage();`
- `Message(string, bool)`；输入表达式：`Message("推测未完成，可重试或直接编辑：" + PlayerFacingText.LongError(AiService.FailureReason(e)), true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Message("推测未完成，可重试或直接编辑：" + PlayerFacingText.LongError(AiService.FailureReason(e)), true);`
- `Message(string, bool)`；输入表达式：`Message("已停止推测，当前编辑已保留。")`；返回值紧邻使用处：`ExpressionStatementSyntax: Message("已停止推测，当前编辑已保留。");`
- `Message(string, bool)`；输入表达式：`Message("正在结合人物资料和互动记忆推测；可继续编辑。")`；返回值紧邻使用处：`ExpressionStatementSyntax: Message("正在结合人物资料和互动记忆推测；可继续编辑。");`
- `Message(string, bool)`；输入表达式：`Message($"已补全 {changes} 项设定；手动编辑的字段已保留。" + design.Notes)`；返回值紧邻使用处：`ExpressionStatementSyntax: Message($"已补全 {changes} 项设定；手动编辑的字段已保留。" + design.Notes);`
- `NationalSpire.AiService.FailureReason(System.Exception)`；输入表达式：`AiService.FailureReason(e)`；返回值紧邻使用处：`ArgumentSyntax: AiService.FailureReason(e)`
- `NationalSpire.AiService.InferPortraitAsync(NationalSpire.CareerData, string, NationalSpire.PortraitDesign, System.Threading.CancellationToken)`；输入表达式：`AiService.InferPortraitAsync(data, id, baseline, cancel.Token)`；返回值紧邻使用处：`AwaitExpressionSyntax: await AiService.InferPortraitAsync(data, id, baseline, cancel.Token)`
- `NationalSpire.PlayerFacingText.LongError(string)`；输入表达式：`PlayerFacingText.LongError(AiService.FailureReason(e))`；返回值紧邻使用处：`BinaryExpressionSyntax: "推测未完成，可重试或直接编辑：" + PlayerFacingText.LongError(AiService.FailureReason(e))`
- `NationalSpire.PortraitDesigns.MergeInference(NationalSpire.PortraitDesign, NationalSpire.PortraitDesign, string)`；输入表达式：`PortraitDesigns.MergeInference(design, baseline, response)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PortraitDesigns.MergeInference(design, baseline, response)`
- `NationalSpire.PortraitDesignStore.Save(string, NationalSpire.PortraitDesign)`；输入表达式：`PortraitDesignStore.Save(path, design)`；返回值紧邻使用处：`ExpressionStatementSyntax: PortraitDesignStore.Save(path, design);`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<PortraitDesign>(JsonSerializer.Serialize(design, PortraitDesigns.Json), PortraitDesigns.Json)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: JsonSerializer.Deserialize<PortraitDesign>(JsonSerializer.Serialize(design, PortraitDesigns.Json), PortraitDesigns.Json)!`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(design, PortraitDesigns.Json)`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.Serialize(design, PortraitDesigns.Json)`
- `System.Threading.CancellationToken.ThrowIfCancellationRequested()`；输入表达式：`cancel.Token.ThrowIfCancellationRequested()`；返回值紧邻使用处：`ExpressionStatementSyntax: cancel.Token.ThrowIfCancellationRequested();`
- `System.Threading.CancellationTokenSource.Cancel()`；输入表达式：`pending.Cancel()`；返回值紧邻使用处：`ExpressionStatementSyntax: pending.Cancel();`
- `System.Threading.CancellationTokenSource.CancellationTokenSource()`；输入表达式：`new CancellationTokenSource()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CancellationTokenSource()`
- `System.Threading.CancellationTokenSource.Dispose()`；输入表达式：`cancel.Dispose()`；返回值紧邻使用处：`ExpressionStatementSyntax: cancel.Dispose();`

**赋值（含属性/字段和局部值）：**

- `infer!.Text` = `"根据资料推测"`
- `infer!.Text` = `"停止推测"`
- `pending` = `cancel`
- `pending` = `null`
- `scroll.ScrollVertical` = `position`
