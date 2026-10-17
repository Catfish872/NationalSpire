# PrivateMemoryScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`01E3D94F20A14EFC67115F1B701B97DE64710D33A627C11ED385ABF32A9635AE`。来源：[源码](../../PrivateMemoryScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`、`NationalSpire.PrivateOrnament`、`NationalSpire.PrivateIdentityLayout`、`NationalSpire.PrivateMoodButton`。

字段、事件及初始值（源码原样）：

```csharp
private readonly HashSet<string> _privateExpandedIdentities = [];
```

<a id="symbol-65caddca194f"></a>

## `NationalSpire.CareerScreen.PrivateIdentity(NationalSpire.CareerData, string, bool) — private Control PrivateIdentity(CareerData data, string id, bool showProfile)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](PrivateMessageScreen.cs.md#symbol-8e28d3a34860)；[`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)

**调用：** `Godot.BaseButton.SetPressedNoSignal(bool)`；`Godot.Color.Color(string)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.Control()`；`Godot.Control.GetCombinedMinimumSize()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.MarginContainer.MarginContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.VSeparator.VSeparator()`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`](CareerAvatars.cs.md#symbol-9f2c4623a902)；[`NationalSpire.CareerScreen.PrivateIdentityButton(string, System.Action, bool)`](PrivateMemoryScreen.cs.md#symbol-a21359876a68)；[`NationalSpire.CareerScreen.PrivateIgnoreMouse(Godot.Node)`](PrivateMemoryScreen.cs.md#symbol-780ecbf2f8bf)；[`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-84294149ff91)；[`NationalSpire.CareerScreen.PrivateRelationshipText(string)`](PrivateMemoryScreen.cs.md#symbol-e18a6c59bf52)；[`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`](PrivateMessageScreen.cs.md#symbol-fb5e88f4639a)；[`NationalSpire.CareerTraining.MoodLevel(NationalSpire.CareerPerson, int)`](CareerTraining.cs.md#symbol-cd61283f2c46)；[`NationalSpire.CareerTraining.MoodUntil(NationalSpire.CareerPerson, int)`](CareerTraining.cs.md#symbol-b39797719d42)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.ClubCoaching.IsCoach(NationalSpire.CareerPerson)`](ClubCoaching.cs.md#symbol-8b4ec414486e)；`NationalSpire.PrivateIdentityLayout.PrivateIdentityLayout()`；[`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-8a6bb6e78fa5)；[`NationalSpire.PrivateMessages.RelationshipLabel(int)`](PrivateMessages.cs.md#symbol-f1f120717f00)；`NationalSpire.PrivateMoodButton.PrivateMoodButton()`；`NationalSpire.PrivateOrnament.PrivateOrnament()`；[`PositionDescription()`](PrivateMemoryScreen.cs.md#symbol-81d0ae62344e)；`System.Collections.Generic.HashSet<T>.Contains(T)`；`int.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CareerPerson.Role`；`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`；`NationalSpire.CareerScreen.PrivateIdentityButton(string, System.Action, bool)`；`NationalSpire.CareerScreen.PrivateIgnoreMouse(Godot.Node)`；`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；`NationalSpire.CareerScreen.PrivateRelationshipText(string)`；`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._privateExpandedIdentities`；`NationalSpire.CareerTraining.MoodLevel(NationalSpire.CareerPerson, int)`；`NationalSpire.CareerTraining.MoodUntil(NationalSpire.CareerPerson, int)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.ClubCoaching.IsCoach(NationalSpire.CareerPerson)`；`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateMessages.RelationshipLabel(int)`；`NationalSpire.PrivateMoodButton.Elevated`；`NationalSpire.PrivateOrnament.Kind`；`NationalSpire.PrivateRelation.Favour`；`NationalSpire.PrivateRelation.Impression`；`NationalSpire.PrivateRelation.Relationship`；`OpenProfile()`；`PositionDescription()`；`ToggleDetails()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`bondButton!.SetPressedNoSignal(details.Visible)`；返回值紧邻使用处：`ExpressionStatementSyntax: bondButton!.SetPressedNoSignal(details.Visible);`
- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`favourButton!.SetPressedNoSignal(details.Visible)`；返回值紧邻使用处：`ExpressionStatementSyntax: favourButton!.SetPressedNoSignal(details.Visible);`
- `Godot.Color.Color(string)`；输入表达式：`new Color("688498")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Modulate = new Color("688498")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("ffb6b6")`；返回值紧邻使用处：`ConditionalExpressionSyntax: mood > 0 ? CareerVisuals.Teal : new Color("ffb6b6")`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`content.AddThemeConstantOverride("separation", 22)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddThemeConstantOverride("separation", 22);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`details.AddThemeConstantOverride("separation", 24)`；返回值紧邻使用处：`ExpressionStatementSyntax: details.AddThemeConstantOverride("separation", 24);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`favour.AddThemeConstantOverride("separation", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: favour.AddThemeConstantOverride("separation", 8);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`identity.AddThemeConstantOverride("separation", 20)`；返回值紧邻使用处：`ExpressionStatementSyntax: identity.AddThemeConstantOverride("separation", 20);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`impression.AddThemeConstantOverride("separation", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: impression.AddThemeConstantOverride("separation", 8);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`inset.AddThemeConstantOverride("margin_bottom", showProfile ? 12 : 20)`；返回值紧邻使用处：`ExpressionStatementSyntax: inset.AddThemeConstantOverride("margin_bottom", showProfile ? 12 : 20);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`inset.AddThemeConstantOverride("margin_top", showProfile ? 0 : 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: inset.AddThemeConstantOverride("margin_top", showProfile ? 0 : 8);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`name.AddThemeConstantOverride("separation", 9)`；返回值紧邻使用处：`ExpressionStatementSyntax: name.AddThemeConstantOverride("separation", 9);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`padding.AddThemeConstantOverride("margin_left", 4)`；返回值紧邻使用处：`ExpressionStatementSyntax: padding.AddThemeConstantOverride("margin_left", 4);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`padding.AddThemeConstantOverride("margin_right", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: padding.AddThemeConstantOverride("margin_right", 8);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`relationText.AddThemeConstantOverride("separation", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: relationText.AddThemeConstantOverride("separation", 8);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`relationship.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: relationship.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`profile.AddThemeFontSizeOverride("font_size", 28)`；返回值紧邻使用处：`ExpressionStatementSyntax: profile.AddThemeFontSizeOverride("font_size", 28);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`description.AddThemeStyleboxOverride("panel", CareerVisuals.Box("182838", "00000000", 5, 6))`；返回值紧邻使用处：`ExpressionStatementSyntax: description.AddThemeStyleboxOverride("panel", CareerVisuals.Box("182838", "00000000", 5, 6));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel", new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel", new StyleBoxEmpty());`
- `Godot.Control.Control()`；输入表达式：`new Control { CustomMinimumSize = new(36, 48) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Control { CustomMinimumSize = new(36, 48) }`
- `Godot.Control.Control()`；输入表达式：`new Control { Name = "PrivateFavourIcon", CustomMinimumSize = new(94, 78) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Control { Name = "PrivateFavourIcon", CustomMinimumSize = new(94, 78) }`
- `Godot.Control.Control()`；输入表达式：`new Control { Name = "PrivateRelationshipIcon", CustomMinimumSize = new(36, 48), SizeFlagsVertical = SizeFlags.ShrinkCenter }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Control { Name = "PrivateRelationshipIcon", CustomMinimumSize = new(36, 48), SizeFlagsVertical = SizeFlags.ShrinkCenter }`
- `Godot.Control.GetCombinedMinimumSize()`；输入表达式：`padding.GetCombinedMinimumSize()`；返回值紧邻使用处：`AssignmentExpressionSyntax: bondButton.CustomMinimumSize = padding.GetCombinedMinimumSize()`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`caption.SetAnchorsAndOffsetsPreset(LayoutPreset.BottomWide)`；返回值紧邻使用处：`ExpressionStatementSyntax: caption.SetAnchorsAndOffsetsPreset(LayoutPreset.BottomWide);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`favour.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: favour.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`number.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: number.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`padding.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: padding.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { CustomMinimumSize = new(225, 0), SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = 1 }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { CustomMinimumSize = new(225, 0), SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = 1 }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { Name = "PrivateIdentityDetails", SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { Name = "PrivateIdentityDetails", SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.MarginContainer.MarginContainer()`；输入表达式：`new MarginContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MarginContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`bondButton.AddChild(padding)`；返回值紧邻使用处：`ExpressionStatementSyntax: bondButton.AddChild(padding);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(details)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(details);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(identityInset)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(identityInset);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`description.AddChild(status)`；返回值紧邻使用处：`ExpressionStatementSyntax: description.AddChild(status);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`details.AddChild(impression)`；返回值紧邻使用处：`ExpressionStatementSyntax: details.AddChild(impression);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`details.AddChild(new VSeparator { Modulate = new Color("688498") })`；返回值紧邻使用处：`ExpressionStatementSyntax: details.AddChild(new VSeparator { Modulate = new Color("688498") });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`details.AddChild(relationship)`；返回值紧邻使用处：`ExpressionStatementSyntax: details.AddChild(relationship);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`emblem.AddChild(new PrivateOrnament { Kind = "bond", MouseFilter = MouseFilterEnum.Ignore })`；返回值紧邻使用处：`ExpressionStatementSyntax: emblem.AddChild(new PrivateOrnament { Kind = "bond", MouseFilter = MouseFilterEnum.Ignore });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`favour.AddChild(caption)`；返回值紧邻使用处：`ExpressionStatementSyntax: favour.AddChild(caption);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`favour.AddChild(medal)`；返回值紧邻使用处：`ExpressionStatementSyntax: favour.AddChild(medal);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`favourButton!.AddChild(caption)`；返回值紧邻使用处：`ExpressionStatementSyntax: favourButton!.AddChild(caption);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`favourButton.AddChild(favour)`；返回值紧邻使用处：`ExpressionStatementSyntax: favourButton.AddChild(favour);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`icon.AddChild(new PrivateOrnament { Kind = "bond", MouseFilter = MouseFilterEnum.Ignore })`；返回值紧邻使用处：`ExpressionStatementSyntax: icon.AddChild(new PrivateOrnament { Kind = "bond", MouseFilter = MouseFilterEnum.Ignore });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`identity.AddChild(avatar)`；返回值紧邻使用处：`ExpressionStatementSyntax: identity.AddChild(avatar);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`identity.AddChild(bondButton)`；返回值紧邻使用处：`ExpressionStatementSyntax: identity.AddChild(bondButton);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`identity.AddChild(favour)`；返回值紧邻使用处：`ExpressionStatementSyntax: identity.AddChild(favour);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`identity.AddChild(favourButton)`；返回值紧邻使用处：`ExpressionStatementSyntax: identity.AddChild(favourButton);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`identity.AddChild(name)`；返回值紧邻使用处：`ExpressionStatementSyntax: identity.AddChild(name);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`identityInset.AddChild(identity)`；返回值紧邻使用处：`ExpressionStatementSyntax: identityInset.AddChild(identity);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`impression.AddChild(PrivateLine("对你的印象", 13, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: impression.AddChild(PrivateLine("对你的印象", 13, CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`impression.AddChild(PrivateText(relation.Impression.Length > 0 ? relation.Impression : "还没有留下具体印象", 18, relation.Impression.Length > 0 ? _ink : _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: impression.AddChild(PrivateText(relation.Impression.Length > 0 ? relation.Impression : "还没有留下具体印象", 18, relation.Impression.Length > 0 ? _ink : _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inset.AddChild(content)`；返回值紧邻使用处：`ExpressionStatementSyntax: inset.AddChild(content);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`medal.AddChild(new PrivateOrnament { Kind = "favour", MouseFilter = MouseFilterEnum.Ignore })`；返回值紧邻使用处：`ExpressionStatementSyntax: medal.AddChild(new PrivateOrnament { Kind = "favour", MouseFilter = MouseFilterEnum.Ignore });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`medal.AddChild(number)`；返回值紧邻使用处：`ExpressionStatementSyntax: medal.AddChild(number);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`moodButton.AddChild(description)`；返回值紧邻使用处：`ExpressionStatementSyntax: moodButton.AddChild(description);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`name.AddChild(PrivateText(person.PublicName, 26, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: name.AddChild(PrivateText(person.PublicName, 26, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`name.AddChild(moodButton)`；返回值紧邻使用处：`ExpressionStatementSyntax: name.AddChild(moodButton);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`name.AddChild(profile)`；返回值紧邻使用处：`ExpressionStatementSyntax: name.AddChild(profile);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`name.AddChild(role)`；返回值紧邻使用处：`ExpressionStatementSyntax: name.AddChild(role);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`name.AddChild(status)`；返回值紧邻使用处：`ExpressionStatementSyntax: name.AddChild(status);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`padding.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: padding.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(inset)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(inset);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(new PrivateOrnament { MouseFilter = MouseFilterEnum.Ignore })`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(new PrivateOrnament { MouseFilter = MouseFilterEnum.Ignore });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`relationText.AddChild(PrivateLine("交往关系", 13, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: relationText.AddChild(PrivateLine("交往关系", 13, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`relationText.AddChild(PrivateText(relation.Relationship == "初识" ? PrivateMessages.RelationshipLabel(relation.Favour) : relation.Relationship, 18, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: relationText.AddChild(PrivateText(relation.Relationship == "初识" ? PrivateMessages.RelationshipLabel(relation.Favour) : relation.Relationship, 18, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`relationship.AddChild(emblem)`；返回值紧邻使用处：`ExpressionStatementSyntax: relationship.AddChild(emblem);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`relationship.AddChild(relationText)`；返回值紧邻使用处：`ExpressionStatementSyntax: relationship.AddChild(relationText);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(icon)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(icon);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(valueLabel)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(valueLabel);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { Name = "PrivateIdentity", SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { Name = "PrivateIdentity", SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { Name = "PrivateMoodDescription", Visible = false, ZIndex = 1, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { Name = "PrivateMoodDescription", Visible = false, ZIndex = 1, MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty()`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxEmpty()`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { Name = "FavourMedal", CustomMinimumSize = new(94, 0), TooltipText = "对你的好感 · -100 至 100" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { Name = "FavourMedal", CustomMinimumSize = new(94, 0), TooltipText = "对你的好感 · -100 至 100" }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { Name = "PrivateImpression", SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = 2 }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { Name = "PrivateImpression", SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = 2 }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`ConditionalExpressionSyntax: showProfile ? new PrivateIdentityLayout() : new VBoxContainer()`
- `Godot.VSeparator.VSeparator()`；输入表达式：`new VSeparator { Modulate = new Color("688498") }`；返回值紧邻使用处：`ArgumentSyntax: new VSeparator { Modulate = new Color("688498") }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 89)`；返回值紧邻使用处：`AssignmentExpressionSyntax: identity.CustomMinimumSize = new(0, 89)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(225, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(225, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(36, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(36, 48)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(94, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(94, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(94, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: caption.CustomMinimumSize = new(94, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(94, 78)`；返回值紧邻使用处：`AssignmentExpressionSyntax: favourButton.CustomMinimumSize = new(94, 78)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(94, 78)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(94, 78)`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, id)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(data, id)!`
- `NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`；输入表达式：`Avatar(data, id, 72, showProfile, showProfile ? OpenProfile : null)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Avatar(data, id, 72, showProfile, showProfile ? OpenProfile : null)`
- `NationalSpire.CareerScreen.PrivateIdentityButton(string, System.Action, bool)`；输入表达式：`PrivateIdentityButton("PrivateFavourToggle", ToggleDetails, true)`；返回值紧邻使用处：`AssignmentExpressionSyntax: favourButton = PrivateIdentityButton("PrivateFavourToggle", ToggleDetails, true)`
- `NationalSpire.CareerScreen.PrivateIdentityButton(string, System.Action, bool)`；输入表达式：`PrivateIdentityButton("PrivateIdentityName", OpenProfile)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateIdentityButton("PrivateIdentityName", OpenProfile)`
- `NationalSpire.CareerScreen.PrivateIdentityButton(string, System.Action, bool)`；输入表达式：`PrivateIdentityButton("PrivateRelationshipToggle", ToggleDetails, true)`；返回值紧邻使用处：`AssignmentExpressionSyntax: bondButton = PrivateIdentityButton("PrivateRelationshipToggle", ToggleDetails, true)`
- `NationalSpire.CareerScreen.PrivateIgnoreMouse(Godot.Node)`；输入表达式：`PrivateIgnoreMouse(description)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateIgnoreMouse(description);`
- `NationalSpire.CareerScreen.PrivateIgnoreMouse(Godot.Node)`；输入表达式：`PrivateIgnoreMouse(favour)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateIgnoreMouse(favour);`
- `NationalSpire.CareerScreen.PrivateIgnoreMouse(Godot.Node)`；输入表达式：`PrivateIgnoreMouse(padding)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateIgnoreMouse(padding);`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine("交往关系", 13, _gold)`；返回值紧邻使用处：`ArgumentSyntax: PrivateLine("交往关系", 13, _gold)`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine("好感", 14, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateLine("好感", 14, _muted)`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine("对你的印象", 13, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: PrivateLine("对你的印象", 13, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine($"{(mood > 0 ? "状态振奋" : "状态低落")} · 剩余 {remaining} 天", 15, mood > 0 ? CareerVisuals.Teal : new Color("ffb6b6"))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateLine($"{(mood > 0 ? "状态振奋" : "状态低落")} · 剩余 {remaining} 天", 15, mood > 0 ? CareerVisuals.Teal : new Color("ffb6b6"))`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine(PrivateRelationshipText(value), 18, _ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateLine(PrivateRelationshipText(value), 18, _ink)`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine(relation.Favour.ToString(), 24, _gold)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateLine(relation.Favour.ToString(), 24, _gold)`
- `NationalSpire.CareerScreen.PrivateRelationshipText(string)`；输入表达式：`PrivateRelationshipText(value)`；返回值紧邻使用处：`ArgumentSyntax: PrivateRelationshipText(value)`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText(person.PublicName, 26, _ink)`；返回值紧邻使用处：`ArgumentSyntax: PrivateText(person.PublicName, 26, _ink)`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText(person.Role + (ClubCoaching.IsCoach(person) ? " · 俱乐部教练" : "") + " / " + person.Country, 14, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateText(person.Role + (ClubCoaching.IsCoach(person) ? " · 俱乐部教练" : "") + " / " + person.Country, 14, _muted)`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText(relation.Impression.Length > 0 ? relation.Impression : "还没有留下具体印象", 18, relation.Impression.Length > 0 ? _ink : _muted)`；返回值紧邻使用处：`ArgumentSyntax: PrivateText(relation.Impression.Length > 0 ? relation.Impression : "还没有留下具体印象", 18, relation.Impression.Length > 0 ? _ink : _muted)`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText(relation.Relationship == "初识" ? PrivateMessages.RelationshipLabel(relation.Favour) : relation.Relationship, 18, _ink)`；返回值紧邻使用处：`ArgumentSyntax: PrivateText(relation.Relationship == "初识" ? PrivateMessages.RelationshipLabel(relation.Favour) : relation.Relationship, 18, _ink)`
- `NationalSpire.CareerTraining.MoodLevel(NationalSpire.CareerPerson, int)`；输入表达式：`CareerTraining.MoodLevel(person, data.Day)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerTraining.MoodLevel(person, data.Day)`
- `NationalSpire.CareerTraining.MoodUntil(NationalSpire.CareerPerson, int)`；输入表达式：`CareerTraining.MoodUntil(person, data.Day)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerTraining.MoodUntil(person, data.Day) - data.Day`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("182838", "00000000", 5, 6)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("182838", "00000000", 5, 6)`
- `NationalSpire.ClubCoaching.IsCoach(NationalSpire.CareerPerson)`；输入表达式：`ClubCoaching.IsCoach(person)`；返回值紧邻使用处：`ConditionalExpressionSyntax: ClubCoaching.IsCoach(person) ? " · 俱乐部教练" : ""`
- `NationalSpire.PrivateIdentityLayout.PrivateIdentityLayout()`；输入表达式：`new PrivateIdentityLayout()`；返回值紧邻使用处：`ConditionalExpressionSyntax: showProfile ? new PrivateIdentityLayout() : new VBoxContainer()`
- `NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Relation(data, id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Relation(data, id)`
- `NationalSpire.PrivateMessages.RelationshipLabel(int)`；输入表达式：`PrivateMessages.RelationshipLabel(relation.Favour)`；返回值紧邻使用处：`ConditionalExpressionSyntax: relation.Relationship == "初识" ? PrivateMessages.RelationshipLabel(relation.Favour) : relation.Relationship`
- `NationalSpire.PrivateMoodButton.PrivateMoodButton()`；输入表达式：`new PrivateMoodButton { Name = "PrivateMoodButton", Elevated = mood > 0, TooltipText = $"剩余 {remaining} 天" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PrivateMoodButton { Name = "PrivateMoodButton", Elevated = mood > 0, TooltipText = $"剩余 {remaining} 天" }`
- `NationalSpire.PrivateOrnament.PrivateOrnament()`；输入表达式：`new PrivateOrnament { Kind = "bond", MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`ArgumentSyntax: new PrivateOrnament { Kind = "bond", MouseFilter = MouseFilterEnum.Ignore }`
- `NationalSpire.PrivateOrnament.PrivateOrnament()`；输入表达式：`new PrivateOrnament { Kind = "favour", MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`ArgumentSyntax: new PrivateOrnament { Kind = "favour", MouseFilter = MouseFilterEnum.Ignore }`
- `NationalSpire.PrivateOrnament.PrivateOrnament()`；输入表达式：`new PrivateOrnament { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`ArgumentSyntax: new PrivateOrnament { MouseFilter = MouseFilterEnum.Ignore }`
- `PositionDescription()`；输入表达式：`PositionDescription()`；返回值紧邻使用处：`ExpressionStatementSyntax: PositionDescription();`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`_privateExpandedIdentities.Contains(id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: caption.Visible = _privateExpandedIdentities.Contains(id)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`_privateExpandedIdentities.Contains(id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: details.Visible = _privateExpandedIdentities.Contains(id)`
- `int.ToString()`；输入表达式：`relation.Favour.ToString()`；返回值紧邻使用处：`ArgumentSyntax: relation.Favour.ToString()`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(225, 0)`
- `CustomMinimumSize` = `new(36, 48)`
- `CustomMinimumSize` = `new(94, 0)`
- `CustomMinimumSize` = `new(94, 78)`
- `Elevated` = `mood > 0`
- `Kind` = `"bond"`
- `Kind` = `"favour"`
- `Modulate` = `new Color("688498")`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Name` = `"FavourMedal"`
- `Name` = `"PrivateFavourIcon"`
- `Name` = `"PrivateIdentity"`
- `Name` = `"PrivateIdentityDetails"`
- `Name` = `"PrivateImpression"`
- `Name` = `"PrivateMoodButton"`
- `Name` = `"PrivateMoodDescription"`
- `Name` = `"PrivateRelationshipIcon"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsStretchRatio` = `1`
- `SizeFlagsStretchRatio` = `2`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `TooltipText` = `"对你的好感 · -100 至 100"`
- `TooltipText` = `$"剩余 {remaining} 天"`
- `Visible` = `false`
- `ZIndex` = `1`
- `avatar.Name` = `"PrivateIdentityAvatar"`
- `avatar.SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `bondButton.CustomMinimumSize` = `padding.GetCombinedMinimumSize()`
- `bondButton.SizeFlagsHorizontal` = `SizeFlags.ShrinkEnd`
- `bondButton.SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `bondButton.ToggleMode` = `true`
- `bondButton.TooltipText` = `value + " · 展开/收起关系与印象"`
- `bondButton` = `PrivateIdentityButton("PrivateRelationshipToggle", ToggleDetails, true)`
- `caption.CustomMinimumSize` = `new(94, 0)`
- `caption.HorizontalAlignment` = `HorizontalAlignment.Center`
- `caption.MouseFilter` = `MouseFilterEnum.Ignore`
- `caption.Name` = `"PrivateFavourCaption"`
- `caption.OffsetBottom` = `30`
- `caption.OffsetTop` = `8`
- `caption.Visible` = `_privateExpandedIdentities.Contains(id)`
- `description.MinimumSizeChanged` += `PositionDescription`
- `description.Visible` = `moodButton.ButtonPressed`
- `details.Visible` = `_privateExpandedIdentities.Contains(id)`
- `disclosure` = `details`
- `favourButton.CustomMinimumSize` = `new(94, 78)`
- `favourButton.SizeFlagsHorizontal` = `SizeFlags.ShrinkEnd`
- `favourButton.ToggleMode` = `true`
- `favourButton.TooltipText` = `"对你的好感 · -100 至 100；展开/收起关系与印象"`
- `favourButton` = `PrivateIdentityButton("PrivateFavourToggle", ToggleDetails, true)`
- `favourCaption` = `caption`
- `identity.CustomMinimumSize` = `new(0, 89)`
- `moodButton.Pressed` += `() => { description.Visible = moodButton.ButtonPressed; PositionDescription(); }`
- `moodButton.Resized` += `PositionDescription`
- `name.Name` = `"PrivateIdentityNameGroup"`
- `name.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `name.SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `number.HorizontalAlignment` = `HorizontalAlignment.Center`
- `number.OffsetBottom` = `-6`
- `number.VerticalAlignment` = `VerticalAlignment.Center`
- `padding.MinimumSizeChanged` += `() => bondButton.CustomMinimumSize = padding.GetCombinedMinimumSize()`
- `profile.Alignment` = `HorizontalAlignment.Left`
- `profile.SizeFlagsVertical` = `SizeFlags.Fill`
- `profile.TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`
- `profile.Text` = `person.PublicName`
- `profile.TooltipText` = `person.PublicName + " · 查看选手档案"`
- `role.AutowrapMode` = `TextServer.AutowrapMode.Off`
- `role.Name` = `"PrivateIdentityRole"`
- `role.TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`
- `role.TooltipText` = `role.Text`
- `status.AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `status.Name` = `"PrivateIdentityMood"`
- `valueLabel.HorizontalAlignment` = `HorizontalAlignment.Right`
- `valueLabel.Name` = `"PrivateRelationshipValue"`
- `valueLabel.VerticalAlignment` = `VerticalAlignment.Center`

<a id="symbol-785f1d3c2c76"></a>

## `OpenProfile() — void OpenProfile()`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerScreen.OpenPrivatePerson(string)`](PrivateMessageScreen.cs.md#symbol-bae5675b92b9)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.OpenPrivatePerson(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.OpenPrivatePerson(string)`；输入表达式：`OpenPrivatePerson(id)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => OpenPrivatePerson(id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-81d0ae62344e"></a>

## `PositionDescription() — void PositionDescription()`

来源：源码第 61 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateIdentity(NationalSpire.CareerData, string, bool)`](PrivateMemoryScreen.cs.md#symbol-65caddca194f)

**调用：** `Godot.Control.GetCombinedMinimumSize()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.GetCombinedMinimumSize()`；输入表达式：`description.GetCombinedMinimumSize()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: description.GetCombinedMinimumSize().Y`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(moodButton.Size.X + 12, (moodButton.Size.Y - description.GetCombinedMinimumSize().Y) / 2)`；返回值紧邻使用处：`AssignmentExpressionSyntax: description.Position = new(moodButton.Size.X + 12, (moodButton.Size.Y - description.GetCombinedMinimumSize().Y) / 2)`

**赋值（含属性/字段和局部值）：**

- `description.Position` = `new(moodButton.Size.X + 12, (moodButton.Size.Y - description.GetCombinedMinimumSize().Y) / 2)`

<a id="symbol-567313f0d0a0"></a>

## `ToggleDetails() — void ToggleDetails()`

来源：源码第 68 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.BaseButton.SetPressedNoSignal(bool)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Remove(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._privateExpandedIdentities`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`bondButton!.SetPressedNoSignal(expanded)`；返回值紧邻使用处：`ExpressionStatementSyntax: bondButton!.SetPressedNoSignal(expanded);`
- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`favourButton!.SetPressedNoSignal(expanded)`；返回值紧邻使用处：`ExpressionStatementSyntax: favourButton!.SetPressedNoSignal(expanded);`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`_privateExpandedIdentities.Add(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateExpandedIdentities.Add(id);`
- `System.Collections.Generic.HashSet<T>.Remove(T)`；输入表达式：`_privateExpandedIdentities.Remove(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_privateExpandedIdentities.Remove(id)`

**赋值（含属性/字段和局部值）：**

- `disclosure!.Visible` = `expanded`
- `favourCaption!.Visible` = `expanded`

<a id="symbol-e18a6c59bf52"></a>

## `NationalSpire.CareerScreen.PrivateRelationshipText(string) — private static string PrivateRelationshipText(string value)`

来源：源码第 139 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateIdentity(NationalSpire.CareerData, string, bool)`](PrivateMemoryScreen.cs.md#symbol-65caddca194f)

**调用：** `System.Globalization.StringInfo.GetTextElementEnumerator(string)`；`System.Globalization.TextElementEnumerator.GetTextElement()`；`System.Globalization.TextElementEnumerator.MoveNext()`；`System.Text.StringBuilder.Append(char)`；`System.Text.StringBuilder.Append(string?)`；`System.Text.StringBuilder.StringBuilder()`；`System.Text.StringBuilder.ToString()`；`string.Replace(string, string?)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Globalization.StringInfo.GetTextElementEnumerator(string)`；输入表达式：`System.Globalization.StringInfo.GetTextElementEnumerator(value.Replace("\r\n", "\n"))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = System.Globalization.StringInfo.GetTextElementEnumerator(value.Replace("\r\n", "\n"))`
- `System.Globalization.TextElementEnumerator.GetTextElement()`；输入表达式：`elements.GetTextElement()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = elements.GetTextElement()`
- `System.Globalization.TextElementEnumerator.MoveNext()`；输入表达式：`elements.MoveNext()`；返回值紧邻使用处：`WhileStatementSyntax: while (elements.MoveNext()) { string element = elements.GetTextElement(); if (element == "\n") { text.Append('\n'); column = 0; continue; } if (column == 15) { text.Append('\n'); column = 0; } text.Append(element); column++; }`
- `System.Text.StringBuilder.Append(char)`；输入表达式：`text.Append('\n')`；返回值紧邻使用处：`ExpressionStatementSyntax: text.Append('\n');`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`text.Append(element)`；返回值紧邻使用处：`ExpressionStatementSyntax: text.Append(element);`
- `System.Text.StringBuilder.StringBuilder()`；输入表达式：`new System.Text.StringBuilder()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new System.Text.StringBuilder()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`text.ToString()`；返回值紧邻使用处：`ReturnStatementSyntax: return text.ToString();`
- `string.Replace(string, string?)`；输入表达式：`value.Replace("\r\n", "\n")`；返回值紧邻使用处：`ArgumentSyntax: value.Replace("\r\n", "\n")`

**赋值（含属性/字段和局部值）：**

- `column` = `0`

<a id="symbol-a21359876a68"></a>

## `NationalSpire.CareerScreen.PrivateIdentityButton(string, System.Action, bool) — private static Button PrivateIdentityButton(string name, Action pressed, bool disclosure = false)`

来源：源码第 152 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateIdentity(NationalSpire.CareerData, string, bool)`](PrivateMemoryScreen.cs.md#symbol-65caddca194f)

**调用：** `Godot.Button.Button()`；`Godot.Color.Color(float, float, float, float)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Button.Button()`；输入表达式：`new Button { Name = name, Flat = true, MouseDefaultCursorShape = CursorShape.PointingHand, SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsVertical = SizeFlags.ShrinkCenter }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Button { Name = name, Flat = true, MouseDefaultCursorShape = CursorShape.PointingHand, SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsVertical = SizeFlags.ShrinkCenter }`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(1.25f, 1.25f, 1.25f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: button.Modulate = new Color(1.25f, 1.25f, 1.25f)`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("focus", disclosure ? new StyleBoxEmpty() : CareerVisuals.Box("00000000", "789aa4", 6, 0))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("focus", disclosure ? new StyleBoxEmpty() : CareerVisuals.Box("00000000", "789aa4", 6, 0));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("hover", new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("hover", new StyleBoxEmpty());`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("hover_pressed", CareerVisuals.Box("ffffff10", "70d4bc", 6, 0))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("hover_pressed", CareerVisuals.Box("ffffff10", "70d4bc", 6, 0));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("normal", new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("normal", new StyleBoxEmpty());`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("pressed", CareerVisuals.Box("ffffff08", "70d4bc", 6, 0))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("pressed", CareerVisuals.Box("ffffff08", "70d4bc", 6, 0));`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty()`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxEmpty()`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty()`；返回值紧邻使用处：`ConditionalExpressionSyntax: disclosure ? new StyleBoxEmpty() : CareerVisuals.Box("00000000", "789aa4", 6, 0)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("00000000", "789aa4", 6, 0)`；返回值紧邻使用处：`ConditionalExpressionSyntax: disclosure ? new StyleBoxEmpty() : CareerVisuals.Box("00000000", "789aa4", 6, 0)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("ffffff08", "70d4bc", 6, 0)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("ffffff08", "70d4bc", 6, 0)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("ffffff10", "70d4bc", 6, 0)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("ffffff10", "70d4bc", 6, 0)`

**赋值（含属性/字段和局部值）：**

- `Flat` = `true`
- `MouseDefaultCursorShape` = `CursorShape.PointingHand`
- `Name` = `name`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `button.Modulate` = `Colors.White`
- `button.Modulate` = `new Color(1.25f, 1.25f, 1.25f)`
- `button.MouseEntered` += `() => button.Modulate = new Color(1.25f, 1.25f, 1.25f)`
- `button.MouseExited` += `() => button.Modulate = Colors.White`
- `button.Pressed` += `pressed`

<a id="symbol-cd1de98ddea7"></a>

## `NationalSpire.CareerScreen.AddPrivateProfileChange(NationalSpire.PrivateProfileChange) — private void AddPrivateProfileChange(PrivateProfileChange change)`

来源：源码第 165 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)

**调用：** [`NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-5789f5c9047d)；[`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`](PrivateMessageScreen.cs.md#symbol-fb5e88f4639a)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.PrivateProfileChanges.Label(string)`](PrivateProfileChanges.cs.md#symbol-6c1d9008f7a2)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.VBoxContainer.VBoxContainer()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._privateBody`；`NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`；`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.PrivateProfileChange.After`；`NationalSpire.PrivateProfileChange.Before`；`NationalSpire.PrivateProfileChange.Field`；`NationalSpire.PrivateProfileChange.Reason`；`NationalSpire.PrivateProfileChanges.Label(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation", 10);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("203448", "668d9b", 8, 16))`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("203448", "668d9b", 8, 16));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateBody!.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateBody!.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(PrivateSelectableText("现在  " + change.After, 17, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(PrivateSelectableText("现在  " + change.After, 17, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(PrivateSelectableText("之前  " + (change.Before.Length > 0 ? change.Before : "未填写"), 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(PrivateSelectableText("之前  " + (change.Before.Length > 0 ? change.Before : "未填写"), 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(PrivateSelectableText(change.Reason, 15, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(PrivateSelectableText(change.Reason, 15, CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(PrivateText("档案变化 · " + PrivateProfileChanges.Label(change.Field), 18, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(PrivateText("档案变化 · " + PrivateProfileChanges.Label(change.Field), 18, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`card.AddChild(box)`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddChild(box);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer()`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`；输入表达式：`PrivateSelectableText("现在  " + change.After, 17, _ink)`；返回值紧邻使用处：`ArgumentSyntax: PrivateSelectableText("现在  " + change.After, 17, _ink)`
- `NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`；输入表达式：`PrivateSelectableText("之前  " + (change.Before.Length > 0 ? change.Before : "未填写"), 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: PrivateSelectableText("之前  " + (change.Before.Length > 0 ? change.Before : "未填写"), 15, _muted)`
- `NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`；输入表达式：`PrivateSelectableText(change.Reason, 15, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: PrivateSelectableText(change.Reason, 15, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText("档案变化 · " + PrivateProfileChanges.Label(change.Field), 18, _gold)`；返回值紧邻使用处：`ArgumentSyntax: PrivateText("档案变化 · " + PrivateProfileChanges.Label(change.Field), 18, _gold)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("203448", "668d9b", 8, 16)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("203448", "668d9b", 8, 16)`
- `NationalSpire.PrivateProfileChanges.Label(string)`；输入表达式：`PrivateProfileChanges.Label(change.Field)`；返回值紧邻使用处：`BinaryExpressionSyntax: "档案变化 · " + PrivateProfileChanges.Label(change.Field)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-74357ea296a8"></a>

## `NationalSpire.CareerScreen.AddPrivateLearning(NationalSpire.PrivateTurn, NationalSpire.PrivateLearning) — private void AddPrivateLearning(PrivateTurn turn, PrivateLearning learning)`

来源：源码第 174 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)

**调用：** [`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`](PrivateMessageScreen.cs.md#symbol-fb5e88f4639a)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`](CareerDialog.cs.md#symbol-d832b736b02b)；`Godot.Color.Color(string)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.Control()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.PrivateOrnament.PrivateOrnament()`；`string.IsNullOrWhiteSpace(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._privateBody`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.PrivateLearning.After`；`NationalSpire.PrivateLearning.Ascension`；`NationalSpire.PrivateLearning.Before`；`NationalSpire.PrivateLearning.Reason`；`NationalSpire.PrivateLearning.Topic`；`NationalSpire.PrivateOrnament.Kind`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("ffb6b6")`；返回值紧邻使用处：`ConditionalExpressionSyntax: change >= 0 ? CareerVisuals.Teal : new Color("ffb6b6")`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`content.AddThemeConstantOverride("separation", 5)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddThemeConstantOverride("separation", 5);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.Control()`；输入表达式：`new Control { CustomMinimumSize = new(32, 40) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Control { CustomMinimumSize = new(32, 40) }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateBody!.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateBody!.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(PrivateText($"{(change >= 0 ? "长期学习" : "错误理解")} · {learning.Topic}  {change:+0.00;-0.00;0.00}%", 16, change >= 0 ? CareerVisuals.Teal : new Color("ffb6b6")))`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(PrivateText($"{(change >= 0 ? "长期学习" : "错误理解")} · {learning.Topic}  {change:+0.00;-0.00;0.00}%", 16, change >= 0 ? CareerVisuals.Teal : new Color("ffb6b6")));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(PrivateText($"进阶 {learning.Ascension} 通关率 {learning.Before:P2} → {learning.After:P2}", 14, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(PrivateText($"进阶 {learning.Ascension} 通关率 {learning.Before:P2} → {learning.After:P2}", 14, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`icon.AddChild(new PrivateOrnament { Kind = "summary", MouseFilter = MouseFilterEnum.Ignore })`；返回值紧邻使用处：`ExpressionStatementSyntax: icon.AddChild(new PrivateOrnament { Kind = "summary", MouseFilter = MouseFilterEnum.Ignore });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(content)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(content);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(icon)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(icon);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(PrivateButton("详情", () => ShowCareerDialog("水平变化", learning.Reason, () => true, "关闭", showCancel: false), 62))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(PrivateButton("详情", () => ShowCareerDialog("水平变化", learning.Reason, () => true, "关闭", showCancel: false), 62));`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(32, 40)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(32, 40)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("详情", () => ShowCareerDialog("水平变化", learning.Reason, () => true, "关闭", showCancel: false), 62)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("详情", () => ShowCareerDialog("水平变化", learning.Reason, () => true, "关闭", showCancel: false), 62)`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText($"{(change >= 0 ? "长期学习" : "错误理解")} · {learning.Topic}  {change:+0.00;-0.00;0.00}%", 16, change >= 0 ? CareerVisuals.Teal : new Color("ffb6b6"))`；返回值紧邻使用处：`ArgumentSyntax: PrivateText($"{(change >= 0 ? "长期学习" : "错误理解")} · {learning.Topic}  {change:+0.00;-0.00;0.00}%", 16, change >= 0 ? CareerVisuals.Teal : new Color("ffb6b6"))`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText($"进阶 {learning.Ascension} 通关率 {learning.Before:P2} → {learning.After:P2}", 14, _muted)`；返回值紧邻使用处：`ArgumentSyntax: PrivateText($"进阶 {learning.Ascension} 通关率 {learning.Before:P2} → {learning.After:P2}", 14, _muted)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；输入表达式：`ShowCareerDialog("水平变化", learning.Reason, () => true, "关闭", showCancel: false)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ShowCareerDialog("水平变化", learning.Reason, () => true, "关闭", showCancel: false)`
- `NationalSpire.PrivateOrnament.PrivateOrnament()`；输入表达式：`new PrivateOrnament { Kind = "summary", MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`ArgumentSyntax: new PrivateOrnament { Kind = "summary", MouseFilter = MouseFilterEnum.Ignore }`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(learning.Reason)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !string.IsNullOrWhiteSpace(learning.Reason)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(32, 40)`
- `Kind` = `"summary"`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-1cd11d02c1b9"></a>

## `NationalSpire.CareerScreen.AddPrivateMood(NationalSpire.PrivateMood) — private void AddPrivateMood(PrivateMood mood)`

来源：源码第 185 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)

**调用：** [`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-84294149ff91)；[`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`](PrivateMessageScreen.cs.md#symbol-fb5e88f4639a)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Color.Color(string)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`string.IsNullOrWhiteSpace(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._privateBody`；`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.PrivateMood.After`；`NationalSpire.PrivateMood.Ascension`；`NationalSpire.PrivateMood.Before`；`NationalSpire.PrivateMood.Day`；`NationalSpire.PrivateMood.Days`；`NationalSpire.PrivateMood.Reason`；`NationalSpire.PrivateMood.Strength`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("d69299")`；返回值紧邻使用处：`ConditionalExpressionSyntax: mood.Strength >= 0 ? CareerVisuals.Teal : new Color("d69299")`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`content.AddThemeConstantOverride("separation", 9)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddThemeConstantOverride("separation", 9);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 16);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`card.AddThemeStyleboxOverride("panel", style)`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddThemeStyleboxOverride("panel", style);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateBody!.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateBody!.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`card.AddChild(content)`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddChild(content);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(PrivateText($"进阶 {mood.Ascension} 通关率 {mood.Before:P2} → {mood.After:P2}", 16, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(PrivateText($"进阶 {mood.Ascension} 通关率 {mood.Before:P2} → {mood.After:P2}", 16, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(PrivateText(mood.Reason, 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(PrivateText(mood.Reason, 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(heading)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(heading);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(PrivateLine(mood.Strength == 0 ? "状态影响已解除" : ViewData.Day >= mood.Day + mood.Days ? "已结束" : $"持续 {mood.Days} 天 · 逐日消退", 14, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(PrivateLine(mood.Strength == 0 ? "状态影响已解除" : ViewData.Day >= mood.Day + mood.Days ? "已结束" : $"持续 {mood.Days} 天 · 逐日消退", 14, _muted));`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer()`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine(mood.Strength == 0 ? "状态影响已解除" : ViewData.Day >= mood.Day + mood.Days ? "已结束" : $"持续 {mood.Days} 天 · 逐日消退", 14, _muted)`；返回值紧邻使用处：`ArgumentSyntax: PrivateLine(mood.Strength == 0 ? "状态影响已解除" : ViewData.Day >= mood.Day + mood.Days ? "已结束" : $"持续 {mood.Days} 天 · 逐日消退", 14, _muted)`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText($"{(mood.Strength == 0 ? "恢复正常" : mood.Strength > 0 ? "受到鼓舞" : "心态受影响")} · 短期状态", 17, style.BorderColor)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateText($"{(mood.Strength == 0 ? "恢复正常" : mood.Strength > 0 ? "受到鼓舞" : "心态受影响")} · 短期状态", 17, style.BorderColor)`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText($"进阶 {mood.Ascension} 通关率 {mood.Before:P2} → {mood.After:P2}", 16, _ink)`；返回值紧邻使用处：`ArgumentSyntax: PrivateText($"进阶 {mood.Ascension} 通关率 {mood.Before:P2} → {mood.After:P2}", 16, _ink)`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText(mood.Reason, 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: PrivateText(mood.Reason, 15, _muted)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("102431", "456577", 5, 14)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerVisuals.Box("102431", "456577", 5, 14)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(mood.Reason)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !string.IsNullOrWhiteSpace(mood.Reason)`

**赋值（含属性/字段和局部值）：**

- `heading.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `style.BorderColor` = `mood.Strength >= 0 ? CareerVisuals.Teal : new Color("d69299")`
- `style.BorderWidthLeft` = `3`

<a id="symbol-edceb57e3f1b"></a>

## `NationalSpire.CareerScreen.AddPrivateReasoning(NationalSpire.PrivateTurn, string) — private void AddPrivateReasoning(PrivateTurn turn, string text)`

来源：源码第 196 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerScreen.AddChatReasoning(string, string)`](PrivateMemoryScreen.cs.md#symbol-fdbe84837533)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.AddChatReasoning(string, string)`；`NationalSpire.PrivateTurn.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.AddChatReasoning(string, string)`；输入表达式：`AddChatReasoning(turn.Id, text)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => AddChatReasoning(turn.Id, text)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-fdbe84837533"></a>

## `NationalSpire.CareerScreen.AddChatReasoning(string, string) — private Action<string> AddChatReasoning(string turn, string text)`

来源：源码第 198 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPrivateReasoning(NationalSpire.PrivateTurn, string)`](PrivateMemoryScreen.cs.md#symbol-edceb57e3f1b)；[`NationalSpire.CareerScreen.RefreshGroupChat()`](GroupChatScreen.cs.md#symbol-b56fe79b2db7)；[`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)

**调用：** [`NationalSpire.CareerScreen.FocusPrivateReasoning(string)`](PrivateMessageScreen.cs.md#symbol-d2aaffe810db)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`Update(string)`](PrivateMemoryScreen.cs.md#symbol-7333e4535e5f)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.GodotObject.SetMeta(Godot.StringName, Godot.Variant)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Remove(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._privateBody`；`NationalSpire.CareerScreen._privateExpandedReasoning`；`NationalSpire.CareerScreen.FocusPrivateReasoning(string)`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`Update(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`section.AddThemeConstantOverride("separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: section.AddThemeConstantOverride("separation", 10);`
- `Godot.GodotObject.SetMeta(Godot.StringName, Godot.Variant)`；输入表达式：`section.SetMeta("reasoning_turn", turn)`；返回值紧邻使用处：`ExpressionStatementSyntax: section.SetMeta("reasoning_turn", turn);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateBody!.AddChild(section)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateBody!.AddChild(section);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`section.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: section.AddChild(button);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { Name = "PrivateReasoning", SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { Name = "PrivateReasoning", SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `NationalSpire.CareerScreen.FocusPrivateReasoning(string)`；输入表达式：`FocusPrivateReasoning(turn)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = FocusPrivateReasoning(turn)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("", () =>          {              if (!_privateExpandedReasoning.Add(turn)) _privateExpandedReasoning.Remove(turn);              Update(text); _ = FocusPrivateReasoning(turn);          }, 145)`；返回值紧邻使用处：`AssignmentExpressionSyntax: button = PrivateButton("", () =>          {              if (!_privateExpandedReasoning.Add(turn)) _privateExpandedReasoning.Remove(turn);              Update(text); _ = FocusPrivateReasoning(turn);          }, 145)`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`_privateExpandedReasoning.Add(turn)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_privateExpandedReasoning.Add(turn)`
- `System.Collections.Generic.HashSet<T>.Remove(T)`；输入表达式：`_privateExpandedReasoning.Remove(turn)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateExpandedReasoning.Remove(turn);`
- `Update(string)`；输入表达式：`Update(text)`；返回值紧邻使用处：`ExpressionStatementSyntax: Update(text);`

**赋值（含属性/字段和局部值）：**

- `_` = `FocusPrivateReasoning(turn)`
- `button` = `PrivateButton("", () =>          {              if (!_privateExpandedReasoning.Add(turn)) _privateExpandedReasoning.Remove(turn);              Update(text); _ = FocusPrivateReasoning(turn);          }, 145)`
- `Name` = `"PrivateReasoning"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-7333e4535e5f"></a>

## `Update(string) — void Update(string value)`

来源：源码第 203 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddChatReasoning(string, string)`](PrivateMemoryScreen.cs.md#symbol-fdbe84837533)

**调用：** [`NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-5789f5c9047d)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.ScrollContainer.ScrollContainer()`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.HashSet<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._privateExpandedReasoning`；`NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("10202d", "41586a", 6, 18))`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("10202d", "41586a", 6, 18));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scroll.AddChild(label)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.AddChild(label);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`section.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: section.AddChild(panel);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer()`；返回值紧邻使用处：`AssignmentExpressionSyntax: panel = new PanelContainer()`
- `Godot.ScrollContainer.ScrollContainer()`；输入表达式：`new ScrollContainer { CustomMinimumSize = new(0, 150), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ScrollContainer { CustomMinimumSize = new(0, 150), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 150)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 150)`
- `NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`；输入表达式：`PrivateSelectableText(text, 16, _muted)`；返回值紧邻使用处：`AssignmentExpressionSyntax: label = PrivateSelectableText(text, 16, _muted)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("10202d", "41586a", 6, 18)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("10202d", "41586a", 6, 18)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`_privateExpandedReasoning.Contains(turn)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _privateExpandedReasoning.Contains(turn)`

**赋值（含属性/字段和局部值）：**

- `button!.Text` = `expanded ? "思考过程 ▾" : "思考过程 ▸"`
- `CustomMinimumSize` = `new(0, 150)`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `label.Text` = `text`
- `label` = `PrivateSelectableText(text, 16, _muted)`
- `panel.Visible` = `expanded`
- `panel` = `new PanelContainer()`
- `section.Visible` = `text.Length > 0`
- `text` = `value`

<a id="symbol-5789f5c9047d"></a>

## `NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color) — private static RichTextLabel PrivateSelectableText(string text, int size, Color color)`

来源：源码第 224 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPrivateBubble(string, bool, NationalSpire.PrivateTurn)`](PrivateMessageScreen.cs.md#symbol-b24b4d693d2a)；[`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-c7881d245b3d)；[`NationalSpire.CareerScreen.AddPrivateProfileChange(NationalSpire.PrivateProfileChange)`](PrivateMemoryScreen.cs.md#symbol-cd1de98ddea7)；[`NationalSpire.CareerScreen.ArbitrationCard(NationalSpire.CareerData, NationalSpire.ArbitrationRecord)`](ArbitrationScreen.cs.md#symbol-8d41f13d5476)；[`NationalSpire.CareerScreen.GroupBubble(string, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>?)`](GroupChatScreen.cs.md#symbol-870e7cca58c0)；[`NationalSpire.CareerScreen.GroupOffer(NationalSpire.GroupChat, NationalSpire.GroupEffect, NationalSpire.PrivateOffer)`](GroupChatScreen.cs.md#symbol-3afa41099b93)；[`NationalSpire.CareerScreen.MentionText(NationalSpire.CareerData, string, int, Godot.Color, System.Collections.Generic.IEnumerable<string>?)`](MentionScreen.cs.md#symbol-2764c9b1b0cd)；[`NationalSpire.CareerScreen.PreviewPrivateAttachment(NationalSpire.PrivateOffer, bool)`](PrivateMemoryScreen.cs.md#symbol-5c877df45b85)；[`Update(string)`](PrivateMemoryScreen.cs.md#symbol-7333e4535e5f)

**调用：** `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.RichTextLabel.RichTextLabel()`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`label.AddThemeColorOverride("default_color", color)`；返回值紧邻使用处：`ExpressionStatementSyntax: label.AddThemeColorOverride("default_color", color);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`label.AddThemeFontSizeOverride("normal_font_size", size)`；返回值紧邻使用处：`ExpressionStatementSyntax: label.AddThemeFontSizeOverride("normal_font_size", size);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`label.AddThemeStyleboxOverride("focus", new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: label.AddThemeStyleboxOverride("focus", new StyleBoxEmpty());`
- `Godot.RichTextLabel.RichTextLabel()`；输入表达式：`new RichTextLabel { Name = "PrivateSelectableText", Text = text, FitContent = true, ScrollActive = false,              SelectionEnabled = true, BbcodeEnabled = false, AutowrapMode = TextServer.AutowrapMode.WordSmart,              SizeFlagsHorizontal = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Pass }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new RichTextLabel { Name = "PrivateSelectableText", Text = text, FitContent = true, ScrollActive = false,              SelectionEnabled = true, BbcodeEnabled = false, AutowrapMode = TextServer.AutowrapMode.WordSmart,              SizeFlagsHorizontal = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Pass }`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty()`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxEmpty()`

**赋值（含属性/字段和局部值）：**

- `AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `BbcodeEnabled` = `false`
- `FitContent` = `true`
- `MouseFilter` = `MouseFilterEnum.Pass`
- `Name` = `"PrivateSelectableText"`
- `ScrollActive` = `false`
- `SelectionEnabled` = `true`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Text` = `text`

<a id="symbol-780ecbf2f8bf"></a>

## `NationalSpire.CareerScreen.PrivateIgnoreMouse(Godot.Node) — private static void PrivateIgnoreMouse(Node parent)`

来源：源码第 233 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`MemoryTab(string, int, string, string)`](PrivateMemoryScreen.cs.md#symbol-477d5039b5b1)；[`NationalSpire.CareerScreen.CreatePrivateListRow()`](PrivateListRows.cs.md#symbol-ae3a09702cbd)；[`NationalSpire.CareerScreen.PrivateIdentity(NationalSpire.CareerData, string, bool)`](PrivateMemoryScreen.cs.md#symbol-65caddca194f)；[`NationalSpire.CareerScreen.PrivateIgnoreMouse(Godot.Node)`](PrivateMemoryScreen.cs.md#symbol-780ecbf2f8bf)；[`NationalSpire.CareerScreen.PrivateSharePicker(string)`](PrivateMemoryScreen.cs.md#symbol-b8d901a6cb80)

**调用：** [`NationalSpire.CareerScreen.PrivateIgnoreMouse(Godot.Node)`](PrivateMemoryScreen.cs.md#symbol-780ecbf2f8bf)；`Godot.Node.GetChildren(bool)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.PrivateIgnoreMouse(Godot.Node)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.GetChildren(bool)`；输入表达式：`parent.GetChildren()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var child in parent.GetChildren()) PrivateIgnoreMouse(child);`
- `NationalSpire.CareerScreen.PrivateIgnoreMouse(Godot.Node)`；输入表达式：`PrivateIgnoreMouse(child)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateIgnoreMouse(child);`

**赋值（含属性/字段和局部值）：**

- `control.MouseFilter` = `MouseFilterEnum.Ignore`

<a id="symbol-84294149ff91"></a>

## `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color) — private static Label PrivateLine(string text, int size, Color color)`

来源：源码第 235 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Field(string, int)`](GroupChatDialogs.cs.md#symbol-3e1134f6a6ce)；[`MemoryTab(string, int, string, string)`](PrivateMemoryScreen.cs.md#symbol-477d5039b5b1)；[`NationalSpire.CareerScreen.AddPrivateMood(NationalSpire.PrivateMood)`](PrivateMemoryScreen.cs.md#symbol-1cd11d02c1b9)；[`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-c7881d245b3d)；[`NationalSpire.CareerScreen.BuildChatPagination(NationalSpire.ChatComposerLayout)`](ChatHistoryScreen.cs.md#symbol-28d387d79595)；[`NationalSpire.CareerScreen.CreatePrivateListRow()`](PrivateListRows.cs.md#symbol-ae3a09702cbd)；[`NationalSpire.CareerScreen.GroupBubble(string, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>?)`](GroupChatScreen.cs.md#symbol-870e7cca58c0)；[`NationalSpire.CareerScreen.GroupMemberPicker(NationalSpire.GroupChat?, System.Action<System.Collections.Generic.List<string>>, bool, string, bool)`](GroupChatScreen.cs.md#symbol-26ccde004356)；[`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.PrivateAttachmentCard(NationalSpire.PrivateOffer, bool)`](PrivateMemoryScreen.cs.md#symbol-eb2b2a37c5d1)；[`NationalSpire.CareerScreen.PrivateEmpty(string, string)`](PrivateMemoryScreen.cs.md#symbol-e829c0d03f86)；[`NationalSpire.CareerScreen.PrivateIdentity(NationalSpire.CareerData, string, bool)`](PrivateMemoryScreen.cs.md#symbol-65caddca194f)；[`NationalSpire.CareerScreen.PrivateSharePicker(string)`](PrivateMemoryScreen.cs.md#symbol-b8d901a6cb80)；[`NationalSpire.CareerScreen.RefreshGroupChat()`](GroupChatScreen.cs.md#symbol-b56fe79b2db7)；[`NoticesThrough(long)`](GroupChatScreen.cs.md#symbol-dc7470e97b86)；[`Section(string)`](PrivateMemoryScreen.cs.md#symbol-55885a3fae26)

**调用：** [`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`](PrivateMessageScreen.cs.md#symbol-fb5e88f4639a)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText(text, size, color)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateText(text, size, color)`

**赋值（含属性/字段和局部值）：**

- `label.AutowrapMode` = `TextServer.AutowrapMode.Off`

<a id="symbol-5378f7528eb3"></a>

## `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float) — private static Button PrivateButton(string text, Action action, float width = 0)`

来源：源码第 237 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Action(string, string, System.Action, int)`](ChatHistoryScreen.cs.md#symbol-ed35dcf54e40)；[`Action(string, string)`](GroupChatScreen.cs.md#symbol-658b33639773)；[`Calendar()`](PrivateMessageScreen.cs.md#symbol-0520f87d39ff)；[`Choice(string, string, System.Action)`](GroupChatDialogs.cs.md#symbol-3dc272602b7d)；[`Choice(string, string, System.Action)`](PrivateMessageScreen.cs.md#symbol-f6ae234b5024)；[`MemoryTab(string, int, string, string)`](PrivateMemoryScreen.cs.md#symbol-477d5039b5b1)；[`NationalSpire.CareerScreen.AddChatReasoning(string, string)`](PrivateMemoryScreen.cs.md#symbol-fdbe84837533)；[`NationalSpire.CareerScreen.AddPrivateBubble(string, bool, NationalSpire.PrivateTurn)`](PrivateMessageScreen.cs.md#symbol-b24b4d693d2a)；[`NationalSpire.CareerScreen.AddPrivateLearning(NationalSpire.PrivateTurn, NationalSpire.PrivateLearning)`](PrivateMemoryScreen.cs.md#symbol-74357ea296a8)；[`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-c7881d245b3d)；[`NationalSpire.CareerScreen.ArbitrationCard(NationalSpire.CareerData, NationalSpire.ArbitrationRecord)`](ArbitrationScreen.cs.md#symbol-8d41f13d5476)；[`NationalSpire.CareerScreen.BuildPrivateComposerActions(Godot.VBoxContainer)`](PrivateMessageScreen.cs.md#symbol-a7be0d6513a6)；[`NationalSpire.CareerScreen.CreatePrivateListRow()`](PrivateListRows.cs.md#symbol-ae3a09702cbd)；[`NationalSpire.CareerScreen.GroupMemory()`](GroupChatDialogs.cs.md#symbol-bf729ae9b3eb)；[`NationalSpire.CareerScreen.GroupOffer(NationalSpire.GroupChat, NationalSpire.GroupEffect, NationalSpire.PrivateOffer)`](GroupChatScreen.cs.md#symbol-3afa41099b93)；[`NationalSpire.CareerScreen.GroupSidebar(Godot.VBoxContainer)`](GroupChatScreen.cs.md#symbol-88d7619ce50a)；[`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.PreviewGroupPrompt()`](GroupChatDialogs.cs.md#symbol-b6bc7a2d0206)；[`NationalSpire.CareerScreen.PreviewPrivatePrompt()`](PrivateMessageScreen.cs.md#symbol-aefc38a1fba3)；[`NationalSpire.CareerScreen.PrivateArbitrationDialog()`](ArbitrationScreen.cs.md#symbol-63e3d9aaa6df)；[`NationalSpire.CareerScreen.PrivateAttachmentCard(NationalSpire.PrivateOffer, bool)`](PrivateMemoryScreen.cs.md#symbol-eb2b2a37c5d1)；[`NationalSpire.CareerScreen.PrivateLineupCard(NationalSpire.CareerData, NationalSpire.CoachLineupRequest, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?)`](CoachScreen.cs.md#symbol-c01675f974f7)；[`NationalSpire.CareerScreen.PrivateMemory()`](PrivateMemoryScreen.cs.md#symbol-942a4a496637)；[`NationalSpire.CareerScreen.PrivateMessageMenu(NationalSpire.PrivateTurn, bool)`](PrivateMemoryScreen.cs.md#symbol-9a1e5f17a52a)；[`NationalSpire.CareerScreen.PrivateProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](PrivateMessageScreen.cs.md#symbol-8e28d3a34860)；[`NationalSpire.CareerScreen.PrivateSharePicker(string)`](PrivateMemoryScreen.cs.md#symbol-b8d901a6cb80)；[`NationalSpire.CareerScreen.PrivateTrainingCard(NationalSpire.CareerData, NationalSpire.CoachTrainingPlan, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?)`](CoachScreen.cs.md#symbol-c2e37e4a0f14)；[`NationalSpire.CareerScreen.RefreshGroupChat()`](GroupChatScreen.cs.md#symbol-b56fe79b2db7)；[`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)；[`NationalSpire.CareerScreen.RefreshPrivateProposal()`](PrivateMessageScreen.cs.md#symbol-fcf77d9c4194)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`](CareerDialog.cs.md#symbol-d832b736b02b)；[`Refresh()`](MentionComposer.cs.md#symbol-4f3b085d9a1d)；[`Section(string)`](PrivateMemoryScreen.cs.md#symbol-55885a3fae26)；[`ShowRows()`](CommunityShareScreen.cs.md#symbol-0be528ba26b5)

**调用：** [`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Button.Button()`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Button.Button()`；输入表达式：`new Button { Text = text, CustomMinimumSize = new(width, 42), SizeFlagsHorizontal = SizeFlags.ShrinkBegin, SizeFlagsVertical = SizeFlags.ShrinkCenter }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Button { Text = text, CustomMinimumSize = new(width, 42), SizeFlagsHorizontal = SizeFlags.ShrinkBegin, SizeFlagsVertical = SizeFlags.ShrinkCenter }`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`button.AddThemeFontSizeOverride("font_size", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeFontSizeOverride("font_size", 16);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("hover", CareerVisuals.Box("3a566e", "b9d6e8", 8, 10))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("hover", CareerVisuals.Box("3a566e", "b9d6e8", 8, 10));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("normal", CareerVisuals.Box("273d50", "506c81", 8, 10))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("normal", CareerVisuals.Box("273d50", "506c81", 8, 10));`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(width, 42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(width, 42)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("273d50", "506c81", 8, 10)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("273d50", "506c81", 8, 10)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("3a566e", "b9d6e8", 8, 10)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("3a566e", "b9d6e8", 8, 10)`

**赋值（含属性/字段和局部值）：**

- `button.Pressed` += `action`
- `CustomMinimumSize` = `new(width, 42)`
- `SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `Text` = `text`

<a id="symbol-e829c0d03f86"></a>

## `NationalSpire.CareerScreen.PrivateEmpty(string, string) — private void PrivateEmpty(string title, string detail)`

来源：源码第 245 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)

**调用：** [`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-84294149ff91)；`Godot.CenterContainer.CenterContainer()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.Control()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.PrivateIcon.PrivateIcon()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._privateBody`；`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CenterContainer.CenterContainer()`；输入表达式：`new CenterContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsVertical = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 180) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CenterContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsVertical = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 180) }`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation", 16);`
- `Godot.Control.Control()`；输入表达式：`new Control { CustomMinimumSize = new(0, 48) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Control { CustomMinimumSize = new(0, 48) }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateBody!.AddChild(center)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateBody!.AddChild(center);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(caption)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(caption);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(heading)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(heading);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(iconSpace)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(iconSpace);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`center.AddChild(box)`；返回值紧邻使用处：`ExpressionStatementSyntax: center.AddChild(box);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`iconSpace.AddChild(new PrivateIcon { Modulate = _gold })`；返回值紧邻使用处：`ExpressionStatementSyntax: iconSpace.AddChild(new PrivateIcon { Modulate = _gold });`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { CustomMinimumSize = new(480, 0) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { CustomMinimumSize = new(480, 0) }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 180)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 180)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 48)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(480, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(480, 0)`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine(detail, 17, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateLine(detail, 17, _muted)`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine(title, 24, _ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateLine(title, 24, _ink)`
- `NationalSpire.PrivateIcon.PrivateIcon()`；输入表达式：`new PrivateIcon { Modulate = _gold }`；返回值紧邻使用处：`ArgumentSyntax: new PrivateIcon { Modulate = _gold }`

**赋值（含属性/字段和局部值）：**

- `caption.HorizontalAlignment` = `HorizontalAlignment.Center`
- `CustomMinimumSize` = `new(0, 180)`
- `CustomMinimumSize` = `new(0, 48)`
- `CustomMinimumSize` = `new(480, 0)`
- `heading.HorizontalAlignment` = `HorizontalAlignment.Center`
- `Modulate` = `_gold`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ExpandFill`

<a id="symbol-a28ca2e86dec"></a>

## `NationalSpire.CareerScreen.PrivateAttachmentHeading(NationalSpire.PrivateOffer) — private static string PrivateAttachmentHeading(PrivateOffer a)`

来源：源码第 253 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PreviewPrivateAttachment(NationalSpire.PrivateOffer, bool)`](PrivateMemoryScreen.cs.md#symbol-5c877df45b85)；[`NationalSpire.CareerScreen.PrivateAttachmentCard(NationalSpire.PrivateOffer, bool)`](PrivateMemoryScreen.cs.md#symbol-eb2b2a37c5d1)

**调用：** [`NationalSpire.PrivateMessages.AttachmentTitle(NationalSpire.PrivateOffer)`](PrivateMessages.cs.md#symbol-e7bc6421b469)；`string.Split(char, int, System.StringSplitOptions)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityQuote.AuthorName`；`NationalSpire.CommunityQuote.ReplyId`；`NationalSpire.CommunityReporting.Kind`；`NationalSpire.CommunitySharing.Kind`；`NationalSpire.PrivateMessages.AttachmentTitle(NationalSpire.PrivateOffer)`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.Quote`；`NationalSpire.PrivateOffer.Weeks`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateMessages.AttachmentTitle(NationalSpire.PrivateOffer)`；输入表达式：`PrivateMessages.AttachmentTitle(a)`；返回值紧邻使用处：`ConditionalExpressionSyntax: a.Detail.Split('\n', 2)[0] is { Length: > 0 } title ? title : PrivateMessages.AttachmentTitle(a)`
- `NationalSpire.PrivateMessages.AttachmentTitle(NationalSpire.PrivateOffer)`；输入表达式：`PrivateMessages.AttachmentTitle(a)`；返回值紧邻使用处：`ConditionalExpressionSyntax: a.Kind == "training" ? $"训练计划 · {a.Weeks}周" : PrivateMessages.AttachmentTitle(a)`
- `string.Split(char, int, System.StringSplitOptions)`；输入表达式：`a.Detail.Split('\n', 2)`；返回值紧邻使用处：`ElementAccessExpressionSyntax: a.Detail.Split('\n', 2)[0]`

**赋值（含属性/字段和局部值）：**


<a id="symbol-eb2b2a37c5d1"></a>

## `NationalSpire.CareerScreen.PrivateAttachmentCard(NationalSpire.PrivateOffer, bool) — private PanelContainer PrivateAttachmentCard(PrivateOffer a, bool draft)`

来源：源码第 257 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPrivateBubble(string, bool, NationalSpire.PrivateTurn)`](PrivateMessageScreen.cs.md#symbol-b24b4d693d2a)；[`NationalSpire.CareerScreen.GroupBubble(string, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>?)`](GroupChatScreen.cs.md#symbol-870e7cca58c0)；[`NationalSpire.CareerScreen.RefreshPrivateAttachments()`](PrivateMemoryScreen.cs.md#symbol-b9d6c2084031)

**调用：** `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.VBoxContainer.VBoxContainer()`；[`NationalSpire.CareerScreen.PreviewPrivateAttachment(NationalSpire.PrivateOffer, bool)`](PrivateMemoryScreen.cs.md#symbol-5c877df45b85)；[`NationalSpire.CareerScreen.PrivateAttachmentHeading(NationalSpire.PrivateOffer)`](PrivateMemoryScreen.cs.md#symbol-a28ca2e86dec)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-84294149ff91)；[`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`](PrivateMessageScreen.cs.md#symbol-fb5e88f4639a)；[`NationalSpire.CareerScreen.RefreshPrivateAttachments()`](PrivateMemoryScreen.cs.md#symbol-b9d6c2084031)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`System.Collections.Generic.List<T>.Remove(T)`；`string.Contains(char)`；`string.IndexOf(char)`；`string.Replace(char, char)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.PreviewPrivateAttachment(NationalSpire.PrivateOffer, bool)`；`NationalSpire.CareerScreen.PrivateAttachmentHeading(NationalSpire.PrivateOffer)`；`NationalSpire.CareerScreen.PrivateAttachments`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；`NationalSpire.CareerScreen.RefreshPrivateAttachments()`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CommunityQuote.Body`；`NationalSpire.CommunityQuote.PostTitle`；`NationalSpire.CommunityReporting.Kind`；`NationalSpire.CommunitySharing.Kind`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.Quote`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`copy.AddThemeConstantOverride("separation", 4)`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddThemeConstantOverride("separation", 4);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`card.AddThemeStyleboxOverride("panel", style)`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddThemeStyleboxOverride("panel", style);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`card.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`copy.AddChild(body)`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddChild(body);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`copy.AddChild(description)`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddChild(description);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`copy.AddChild(source)`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddChild(source);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`copy.AddChild(title)`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddChild(title);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(PrivateButton("查看", () => PreviewPrivateAttachment(a), 60))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(PrivateButton("查看", () => PreviewPrivateAttachment(a), 60));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(copy)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(copy);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(remove)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(remove);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `NationalSpire.CareerScreen.PreviewPrivateAttachment(NationalSpire.PrivateOffer, bool)`；输入表达式：`PreviewPrivateAttachment(a)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => PreviewPrivateAttachment(a)`
- `NationalSpire.CareerScreen.PrivateAttachmentHeading(NationalSpire.PrivateOffer)`；输入表达式：`PrivateAttachmentHeading(a)`；返回值紧邻使用处：`ArgumentSyntax: PrivateAttachmentHeading(a)`
- `NationalSpire.CareerScreen.PrivateAttachmentHeading(NationalSpire.PrivateOffer)`；输入表达式：`PrivateAttachmentHeading(a)`；返回值紧邻使用处：`AssignmentExpressionSyntax: title.TooltipText = PrivateAttachmentHeading(a)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("×", () => { PrivateAttachments.Remove(a); RefreshPrivateAttachments(); }, 36)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton("×", () => { PrivateAttachments.Remove(a); RefreshPrivateAttachments(); }, 36)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("查看", () => PreviewPrivateAttachment(a), 60)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("查看", () => PreviewPrivateAttachment(a), 60)`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine("来源帖子 · " + quote.PostTitle, 14, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateLine("来源帖子 · " + quote.PostTitle, 14, _muted)`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine(PrivateAttachmentHeading(a), 17, _ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateLine(PrivateAttachmentHeading(a), 17, _ink)`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine(kind + (excerpt.Length > 0 ? " · " + excerpt : ""), 15, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateLine(kind + (excerpt.Length > 0 ? " · " + excerpt : ""), 15, _muted)`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText(quote.Body, 16, _ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateText(quote.Body, 16, _ink)`
- `NationalSpire.CareerScreen.RefreshPrivateAttachments()`；输入表达式：`RefreshPrivateAttachments()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshPrivateAttachments();`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("203448", "526e84", 6, 10)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerVisuals.Box("203448", "526e84", 6, 10)`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`PrivateAttachments.Remove(a)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateAttachments.Remove(a);`
- `string.Contains(char)`；输入表达式：`a.Detail.Contains('\n')`；返回值紧邻使用处：`ConditionalExpressionSyntax: a.Detail.Contains('\n') ? a.Detail[(a.Detail.IndexOf('\n') + 1)..].Replace('\n', ' ') : a.Detail`
- `string.IndexOf(char)`；输入表达式：`a.Detail.IndexOf('\n')`；返回值紧邻使用处：`BinaryExpressionSyntax: a.Detail.IndexOf('\n') + 1`
- `string.Replace(char, char)`；输入表达式：`a.Detail[(a.Detail.IndexOf('\n') + 1)..].Replace('\n', ' ')`；返回值紧邻使用处：`ConditionalExpressionSyntax: a.Detail.Contains('\n') ? a.Detail[(a.Detail.IndexOf('\n') + 1)..].Replace('\n', ' ') : a.Detail`

**赋值（含属性/字段和局部值）：**

- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `body.MaxLinesVisible` = `2`
- `body.MouseFilter` = `MouseFilterEnum.Pass`
- `body.Name` = `"QuoteBody"`
- `body.TooltipText` = `quote.Body`
- `card.Name` = `a.Kind == CommunityReporting.Kind ? "CommunityReportCard" : "CommunityQuoteCard"`
- `description.TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`
- `remove.TooltipText` = `"移除这条附件"`
- `source.MouseFilter` = `MouseFilterEnum.Pass`
- `source.Name` = `"QuoteSource"`
- `source.TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`
- `source.TooltipText` = `quote.PostTitle`
- `style.BorderColor` = `_gold`
- `style.BorderWidthLeft` = `3`
- `title.MouseFilter` = `MouseFilterEnum.Pass`
- `title.Name` = `"QuoteAuthor"`
- `title.TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`
- `title.TooltipText` = `PrivateAttachmentHeading(a)`

<a id="symbol-5c877df45b85"></a>

## `NationalSpire.CareerScreen.PreviewPrivateAttachment(NationalSpire.PrivateOffer, bool) — private void PreviewPrivateAttachment(PrivateOffer a, bool attach = false)`

来源：源码第 287 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateAttachmentCard(NationalSpire.PrivateOffer, bool)`](PrivateMemoryScreen.cs.md#symbol-eb2b2a37c5d1)；[`NationalSpire.CareerScreen.PrivateSharePicker(string)`](PrivateMemoryScreen.cs.md#symbol-b8d901a6cb80)

**调用：** [`NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`](PrivateMemoryScreen.cs.md#symbol-053a2c0af91b)；[`NationalSpire.CareerScreen.PrivateAttachmentHeading(NationalSpire.PrivateOffer)`](PrivateMemoryScreen.cs.md#symbol-a28ca2e86dec)；[`NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-5789f5c9047d)；[`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`](PrivateMessageScreen.cs.md#symbol-fb5e88f4639a)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`](CareerDialog.cs.md#symbol-d832b736b02b)；[`NationalSpire.PrivateMessages.AttachmentTitle(NationalSpire.PrivateOffer)`](PrivateMessages.cs.md#symbol-e7bc6421b469)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.ScrollContainer.ScrollContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`string.Contains(char)`；`string.IndexOf(char)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Math.Clamp(int, int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`；`NationalSpire.CareerScreen.PrivateAttachmentHeading(NationalSpire.PrivateOffer)`；`NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`；`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；`NationalSpire.PrivateMessages.AttachmentTitle(NationalSpire.PrivateOffer)`；`NationalSpire.PrivateOffer.Detail`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`body.AddThemeConstantOverride("separation", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddThemeConstantOverride("separation", 18);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(PrivateSelectableText(detail.Length > 0 ? detail : PrivateMessages.AttachmentTitle(a), 19, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(PrivateSelectableText(detail.Length > 0 ? detail : PrivateMessages.AttachmentTitle(a), 19, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(PrivateText(PrivateAttachmentHeading(a), 23, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(PrivateText(PrivateAttachmentHeading(a), 23, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scroll.AddChild(body)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.AddChild(body);`
- `Godot.ScrollContainer.ScrollContainer()`；输入表达式：`new ScrollContainer { CustomMinimumSize = new(820, height), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ScrollContainer { CustomMinimumSize = new(820, height), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(820, height)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(820, height)`
- `NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`；输入表达式：`AttachPrivate(a)`；返回值紧邻使用处：`ExpressionStatementSyntax: AttachPrivate(a);`
- `NationalSpire.CareerScreen.PrivateAttachmentHeading(NationalSpire.PrivateOffer)`；输入表达式：`PrivateAttachmentHeading(a)`；返回值紧邻使用处：`ArgumentSyntax: PrivateAttachmentHeading(a)`
- `NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`；输入表达式：`PrivateSelectableText(detail.Length > 0 ? detail : PrivateMessages.AttachmentTitle(a), 19, _ink)`；返回值紧邻使用处：`ArgumentSyntax: PrivateSelectableText(detail.Length > 0 ? detail : PrivateMessages.AttachmentTitle(a), 19, _ink)`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText(PrivateAttachmentHeading(a), 23, _gold)`；返回值紧邻使用处：`ArgumentSyntax: PrivateText(PrivateAttachmentHeading(a), 23, _gold)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；输入表达式：`ShowCareerDialog(attach ? "确认引用" : "引用内容", "", () => { if (attach) AttachPrivate(a); return true; }, attach ? "附到消息" : "关闭", box =>          {              int height = Math.Clamp(100 + (a.Detail.Length / 38 + a.Detail.Count(ch => ch == '\n')) * 29, 170, 420);              var scroll = new ScrollContainer { CustomMinimumSize = new(820, height), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);              var body = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; body.AddThemeConstantOverride("separation", 18); scroll.AddChild(body);              body.AddChild(PrivateText(PrivateAttachmentHeading(a), 23, _gold));              string detail = a.Detail.Contains('\n') ? a.Detail[(a.Detail.IndexOf('\n') + 1)..] : a.Detail;              body.AddChild(PrivateSelectableText(detail.Length > 0 ? detail : PrivateMessages.AttachmentTitle(a), 19, _ink));          }, showCancel: attach)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog(attach ? "确认引用" : "引用内容", "", () => { if (attach) AttachPrivate(a); return true; }, attach ? "附到消息" : "关闭", box =>          {              int height = Math.Clamp(100 + (a.Detail.Length / 38 + a.Detail.Count(ch => ch == '\n')) * 29, 170, 420);              var scroll = new ScrollContainer { CustomMinimumSize = new(820, height), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);              var body = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; body.AddThemeConstantOverride("separation", 18); scroll.AddChild(body);              body.AddChild(PrivateText(PrivateAttachmentHeading(a), 23, _gold));              string detail = a.Detail.Contains('\n') ? a.Detail[(a.Detail.IndexOf('\n') + 1)..] : a.Detail;              body.AddChild(PrivateSelectableText(detail.Length > 0 ? detail : PrivateMessages.AttachmentTitle(a), 19, _ink));          }, showCancel: attach);`
- `NationalSpire.PrivateMessages.AttachmentTitle(NationalSpire.PrivateOffer)`；输入表达式：`PrivateMessages.AttachmentTitle(a)`；返回值紧邻使用处：`ConditionalExpressionSyntax: detail.Length > 0 ? detail : PrivateMessages.AttachmentTitle(a)`
- `string.Contains(char)`；输入表达式：`a.Detail.Contains('\n')`；返回值紧邻使用处：`ConditionalExpressionSyntax: a.Detail.Contains('\n') ? a.Detail[(a.Detail.IndexOf('\n') + 1)..] : a.Detail`
- `string.IndexOf(char)`；输入表达式：`a.Detail.IndexOf('\n')`；返回值紧邻使用处：`BinaryExpressionSyntax: a.Detail.IndexOf('\n') + 1`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`a.Detail.Count(ch => ch == '\n')`；返回值紧邻使用处：`BinaryExpressionSyntax: a.Detail.Length / 38 + a.Detail.Count(ch => ch == '\n')`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(100 + (a.Detail.Length / 38 + a.Detail.Count(ch => ch == '\n')) * 29, 170, 420)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Clamp(100 + (a.Detail.Length / 38 + a.Detail.Count(ch => ch == '\n')) * 29, 170, 420)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(820, height)`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-053a2c0af91b"></a>

## `NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer) — private void AttachPrivate(PrivateOffer attachment)`

来源：源码第 299 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.GroupActions()`](GroupChatDialogs.cs.md#symbol-38cd67d996b6)；[`NationalSpire.CareerScreen.GroupTrainingPicker()`](GroupChatDialogs.cs.md#symbol-1e2068d8bf79)；[`NationalSpire.CareerScreen.PreviewPrivateAttachment(NationalSpire.PrivateOffer, bool)`](PrivateMemoryScreen.cs.md#symbol-5c877df45b85)；[`NationalSpire.CareerScreen.PrivateActions()`](PrivateMessageScreen.cs.md#symbol-6e8c11ead905)；[`NationalSpire.CareerScreen.PrivateLineupPicker()`](CoachScreen.cs.md#symbol-78315f2693ca)；[`NationalSpire.CareerScreen.PrivateMatchPicker()`](PrivateMessageScreen.cs.md#symbol-aa7339f37b26)；[`NationalSpire.CareerScreen.PrivateTrainingPicker()`](CoachScreen.cs.md#symbol-2609d8a7ba68)；[`NationalSpire.CareerScreen.ShareDiscussion(string, string)`](CommunityShareScreen.cs.md#symbol-038b648fdc83)

**调用：** [`NationalSpire.CareerScreen.RefreshPrivateAttachments()`](PrivateMemoryScreen.cs.md#symbol-b9d6c2084031)；`Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`；`Godot.CanvasItem.IsVisibleInTree()`；`Godot.Control.GrabFocus()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`long.ToString()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._groupSelection`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen._privateInput`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen._privateStatus`；`NationalSpire.CareerScreen.CurrentGroup`；`NationalSpire.CareerScreen.PrivateAttachments`；`NationalSpire.CareerScreen.RefreshPrivateAttachments()`；`NationalSpire.GroupChat.LastInteractionNumber`；`NationalSpire.PrivateOffer.ActorId`；`NationalSpire.PrivateOffer.GroupId`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.Participants`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(() => { if (IsInstanceValid(_privateInput) && _privateInput!.IsVisibleInTree()) _privateInput.GrabFocus(); }).CallDeferred()`；返回值紧邻使用处：`ExpressionStatementSyntax: Callable.From(() => { if (IsInstanceValid(_privateInput) && _privateInput!.IsVisibleInTree()) _privateInput.GrabFocus(); }).CallDeferred();`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(() => { if (IsInstanceValid(_privateInput) && _privateInput!.IsVisibleInTree()) _privateInput.GrabFocus(); })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(() => { if (IsInstanceValid(_privateInput) && _privateInput!.IsVisibleInTree()) _privateInput.GrabFocus(); }).CallDeferred`
- `Godot.CanvasItem.IsVisibleInTree()`；输入表达式：`_privateInput!.IsVisibleInTree()`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(_privateInput) && _privateInput!.IsVisibleInTree()`
- `Godot.Control.GrabFocus()`；输入表达式：`_privateInput.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateInput.GrabFocus();`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_privateInput)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(_privateInput) && _privateInput!.IsVisibleInTree()`
- `long.ToString()`；输入表达式：`((CurrentGroup?.LastInteractionNumber ?? 0) + PrivateAttachments.Count + 1).ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: attachment.Id = ((CurrentGroup?.LastInteractionNumber ?? 0) + PrivateAttachments.Count + 1).ToString()`
- `NationalSpire.CareerScreen.RefreshPrivateAttachments()`；输入表达式：`RefreshPrivateAttachments()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshPrivateAttachments();`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`_groupSelection.ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: attachment.Participants = _groupSelection.ToList()`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`PrivateAttachments.Add(attachment)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateAttachments.Add(attachment);`

**赋值（含属性/字段和局部值）：**

- `_privateStatus!.Text` = `"每条消息最多附加 8 项。"`
- `attachment.ActorId` = `_privatePerson`
- `attachment.GroupId` = `_privateGroup`
- `attachment.Id` = `((CurrentGroup?.LastInteractionNumber ?? 0) + PrivateAttachments.Count + 1).ToString()`
- `attachment.Participants` = `_groupSelection.ToList()`

<a id="symbol-b9d6c2084031"></a>

## `NationalSpire.CareerScreen.RefreshPrivateAttachments() — private void RefreshPrivateAttachments()`

来源：源码第 313 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AttachPrivate(NationalSpire.PrivateOffer)`](PrivateMemoryScreen.cs.md#symbol-053a2c0af91b)；[`NationalSpire.CareerScreen.PrivateAttachmentCard(NationalSpire.PrivateOffer, bool)`](PrivateMemoryScreen.cs.md#symbol-eb2b2a37c5d1)；[`NationalSpire.CareerScreen.SelectGroup(string, int)`](GroupChatScreen.cs.md#symbol-72d02215d0db)；[`NationalSpire.CareerScreen.SelectPrivate(string, int)`](PrivateMessageScreen.cs.md#symbol-ddace6dd7c79)；[`NationalSpire.CareerScreen.SendGroup()`](GroupChatScreen.cs.md#symbol-17b4992ac7c2)；[`NationalSpire.CareerScreen.SendPrivate()`](PrivateMessageScreen.cs.md#symbol-748ab66a7351)

**调用：** `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.ScrollContainer.GetVScrollBar()`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CareerScreen.PrivateAttachmentCard(NationalSpire.PrivateOffer, bool)`](PrivateMemoryScreen.cs.md#symbol-eb2b2a37c5d1)；[`NationalSpire.CareerScreen.ScrollPrivateToBottom()`](PrivateMessageScreen.cs.md#symbol-b2deefc4ba01)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`NationalSpire.ChatComposerPanel.SetAttachmentHeight(float)`](ChatComposerLayout.cs.md#symbol-b5a6e5f6347c)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.PrivateAttachmentCard(NationalSpire.PrivateOffer, bool)`；`NationalSpire.CareerScreen.PrivateAttachments`；`NationalSpire.CareerScreen.ScrollPrivateToBottom()`；`NationalSpire.CareerScreen._privateAttachmentScroll`；`NationalSpire.CareerScreen._privateAttachments`；`NationalSpire.CareerScreen._privateComposer`；`NationalSpire.CareerScreen._privateScroll`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.ChatComposerPanel.SetAttachmentHeight(float)`；`NationalSpire.CommunitySharing.Kind`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.Quote`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateAttachments.AddChild(PrivateAttachmentCard(a, true))`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateAttachments.AddChild(PrivateAttachmentCard(a, true));`
- `Godot.ScrollContainer.GetVScrollBar()`；输入表达式：`_privateScroll.GetVScrollBar()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _privateScroll.GetVScrollBar().MaxValue`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, height)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _privateAttachmentScroll.CustomMinimumSize = new(0, height)`
- `NationalSpire.CareerScreen.PrivateAttachmentCard(NationalSpire.PrivateOffer, bool)`；输入表达式：`PrivateAttachmentCard(a, true)`；返回值紧邻使用处：`ArgumentSyntax: PrivateAttachmentCard(a, true)`
- `NationalSpire.CareerScreen.ScrollPrivateToBottom()`；输入表达式：`ScrollPrivateToBottom()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = ScrollPrivateToBottom()`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(_privateAttachments)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(_privateAttachments);`
- `NationalSpire.ChatComposerPanel.SetAttachmentHeight(float)`；输入表达式：`_privateComposer.SetAttachmentHeight(height)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateComposer.SetAttachmentHeight(height);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateAttachments.Any(a => a.Kind == CommunitySharing.Kind && a.Quote != null)`；返回值紧邻使用处：`ConditionalExpressionSyntax: PrivateAttachments.Any(a => a.Kind == CommunitySharing.Kind && a.Quote != null) ? 122 : 72`

**赋值（含属性/字段和局部值）：**

- `_` = `ScrollPrivateToBottom()`
- `_privateAttachmentScroll.CustomMinimumSize` = `new(0, height)`
- `_privateAttachmentScroll.Visible` = `PrivateAttachments.Count > 0`

<a id="symbol-b8d901a6cb80"></a>

## `NationalSpire.CareerScreen.PrivateSharePicker(string) — private void PrivateSharePicker(string kind)`

来源：源码第 326 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.GroupActions()`](GroupChatDialogs.cs.md#symbol-38cd67d996b6)；[`NationalSpire.CareerScreen.PrivateActions()`](PrivateMessageScreen.cs.md#symbol-6e8c11ead905)

**调用：** [`NationalSpire.CareerScreen.PreviewPrivateAttachment(NationalSpire.PrivateOffer, bool)`](PrivateMemoryScreen.cs.md#symbol-5c877df45b85)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.PrivateIgnoreMouse(Godot.Node)`](PrivateMemoryScreen.cs.md#symbol-780ecbf2f8bf)；[`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-84294149ff91)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`](CareerDialog.cs.md#symbol-d832b736b02b)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.PrivateMessages.PrepareAttachments(NationalSpire.CareerData, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>)`](PrivateMessages.cs.md#symbol-f2d6d9cf9c86)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.MarginContainer.MarginContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChildCount(bool)`；`Godot.ScrollContainer.ScrollContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.PrivateOffer.PrivateOffer()`；`string.Contains(char)`；`string.IndexOf(char)`；`string.Replace(char, char)`；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Collections.Generic.IEnumerable<TSource>.AsEnumerable<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`

**字段、属性、事件及方法组引用：** `(string Id, string Label).Id`；`(string Id, string Label).Label`；`NationalSpire.CareerData.Results`；`NationalSpire.CareerResult.Day`；`NationalSpire.CareerResult.Event`；`NationalSpire.CareerResult.MatchId`；`NationalSpire.CareerResult.Outcome`；`NationalSpire.CareerScreen._cancelDialog`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen.PreviewPrivateAttachment(NationalSpire.PrivateOffer, bool)`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.PrivateIgnoreMouse(Godot.Node)`；`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CommunityPost.Day`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.Title`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.PrivateMessages.PrepareAttachments(NationalSpire.CareerData, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>)`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.MatchId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`copy.AddThemeConstantOverride("separation", 9)`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddThemeConstantOverride("separation", 9);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`list.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`margin.AddThemeConstantOverride("margin_" + edge, 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddThemeConstantOverride("margin_" + edge, 14);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.MarginContainer.MarginContainer()`；输入表达式：`new MarginContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MarginContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`choice.AddChild(margin)`；返回值紧邻使用处：`ExpressionStatementSyntax: choice.AddChild(margin);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`copy.AddChild(preview)`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddChild(preview);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`copy.AddChild(title)`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddChild(title);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`list.AddChild(choice)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddChild(choice);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`list.AddChild(Text("暂无可分享的记录", 18, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddChild(Text("暂无可分享的记录", 18, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`margin.AddChild(copy)`；返回值紧邻使用处：`ExpressionStatementSyntax: margin.AddChild(copy);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scroll.AddChild(list)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.AddChild(list);`
- `Godot.Node.GetChildCount(bool)`；输入表达式：`list.GetChildCount()`；返回值紧邻使用处：`BinaryExpressionSyntax: list.GetChildCount() == 0`
- `Godot.ScrollContainer.ScrollContainer()`；输入表达式：`new ScrollContainer { CustomMinimumSize = new(730, 420), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ScrollContainer { CustomMinimumSize = new(730, 420), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 104)`；返回值紧邻使用处：`AssignmentExpressionSyntax: choice.CustomMinimumSize = new(0, 104)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(730, 420)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(730, 420)`
- `NationalSpire.CareerScreen.PreviewPrivateAttachment(NationalSpire.PrivateOffer, bool)`；输入表达式：`PreviewPrivateAttachment(a, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: PreviewPrivateAttachment(a, true);`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("", () =>                  {                      _cancelDialog?.Invoke(); PreviewPrivateAttachment(a, true);                  }, 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton("", () =>                  {                      _cancelDialog?.Invoke(); PreviewPrivateAttachment(a, true);                  }, 0)`
- `NationalSpire.CareerScreen.PrivateIgnoreMouse(Godot.Node)`；输入表达式：`PrivateIgnoreMouse(margin)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateIgnoreMouse(margin);`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine((a.Detail.Contains('\n') ? a.Detail[(a.Detail.IndexOf('\n') + 1)..] : a.Detail).Replace('\n', ' '), 16, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateLine((a.Detail.Contains('\n') ? a.Detail[(a.Detail.IndexOf('\n') + 1)..] : a.Detail).Replace('\n', ' '), 16, _muted)`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine(entry.Label, 18, _ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateLine(entry.Label, 18, _ink)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；输入表达式：`ShowCareerDialog(kind == "result" ? "选择比赛" : "选择帖子", "", () => true, "关闭", box =>          {              var scroll = new ScrollContainer { CustomMinimumSize = new(730, 420), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);              var list = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; list.AddThemeConstantOverride("separation", 12); scroll.AddChild(list);              var choices = kind == "result" ? data.Results.AsEnumerable().Reverse().Take(30).Select(r => (Id: r.MatchId, Label: $"第{r.Day}天 · {r.Event} · {r.Outcome}"))                  : CommunityThreads.All(data).OrderByDescending(p => p.Day).Take(50).Select(p => (Id: p.Id, Label: $"第{p.Day}天 · {p.Title}"));              foreach (var entry in choices)              {                  var a = new PrivateOffer { Kind = kind, MatchId = entry.Id };                  if (PrivateMessages.PrepareAttachments(data, _privatePerson, [a]) != null) continue;                  var choice = PrivateButton("", () =>                  {                      _cancelDialog?.Invoke(); PreviewPrivateAttachment(a, true);                  }, 0); choice.SizeFlagsHorizontal = SizeFlags.ExpandFill; choice.CustomMinimumSize = new(0, 104); list.AddChild(choice);                  var margin = new MarginContainer(); choice.AddChild(margin); margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);                  foreach (var edge in new[] { "left", "right", "top", "bottom" }) margin.AddThemeConstantOverride("margin_" + edge, 14);                  var copy = new VBoxContainer(); copy.AddThemeConstantOverride("separation", 9); margin.AddChild(copy);                  var title = PrivateLine(entry.Label, 18, _ink); title.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis; copy.AddChild(title);                  var preview = PrivateLine((a.Detail.Contains('\n') ? a.Detail[(a.Detail.IndexOf('\n') + 1)..] : a.Detail).Replace('\n', ' '), 16, _muted); preview.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis; copy.AddChild(preview);                  PrivateIgnoreMouse(margin);              }              if (list.GetChildCount() == 0) list.AddChild(Text("暂无可分享的记录", 18, _muted));          }, showCancel: false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog(kind == "result" ? "选择比赛" : "选择帖子", "", () => true, "关闭", box =>          {              var scroll = new ScrollContainer { CustomMinimumSize = new(730, 420), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);              var list = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; list.AddThemeConstantOverride("separation", 12); scroll.AddChild(list);              var choices = kind == "result" ? data.Results.AsEnumerable().Reverse().Take(30).Select(r => (Id: r.MatchId, Label: $"第{r.Day}天 · {r.Event} · {r.Outcome}"))                  : CommunityThreads.All(data).OrderByDescending(p => p.Day).Take(50).Select(p => (Id: p.Id, Label: $"第{p.Day}天 · {p.Title}"));              foreach (var entry in choices)              {                  var a = new PrivateOffer { Kind = kind, MatchId = entry.Id };                  if (PrivateMessages.PrepareAttachments(data, _privatePerson, [a]) != null) continue;                  var choice = PrivateButton("", () =>                  {                      _cancelDialog?.Invoke(); PreviewPrivateAttachment(a, true);                  }, 0); choice.SizeFlagsHorizontal = SizeFlags.ExpandFill; choice.CustomMinimumSize = new(0, 104); list.AddChild(choice);                  var margin = new MarginContainer(); choice.AddChild(margin); margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);                  foreach (var edge in new[] { "left", "right", "top", "bottom" }) margin.AddThemeConstantOverride("margin_" + edge, 14);                  var copy = new VBoxContainer(); copy.AddThemeConstantOverride("separation", 9); margin.AddChild(copy);                  var title = PrivateLine(entry.Label, 18, _ink); title.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis; copy.AddChild(title);                  var preview = PrivateLine((a.Detail.Contains('\n') ? a.Detail[(a.Detail.IndexOf('\n') + 1)..] : a.Detail).Replace('\n', ' '), 16, _muted); preview.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis; copy.AddChild(preview);                  PrivateIgnoreMouse(margin);              }              if (list.GetChildCount() == 0) list.AddChild(Text("暂无可分享的记录", 18, _muted));          }, showCancel: false);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("暂无可分享的记录", 18, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("暂无可分享的记录", 18, _muted)`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).OrderByDescending`
- `NationalSpire.PrivateMessages.PrepareAttachments(NationalSpire.CareerData, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>)`；输入表达式：`PrivateMessages.PrepareAttachments(data, _privatePerson, [a])`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateMessages.PrepareAttachments(data, _privatePerson, [a]) != null`
- `NationalSpire.PrivateOffer.PrivateOffer()`；输入表达式：`new PrivateOffer { Kind = kind, MatchId = entry.Id }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PrivateOffer { Kind = kind, MatchId = entry.Id }`
- `string.Contains(char)`；输入表达式：`a.Detail.Contains('\n')`；返回值紧邻使用处：`ConditionalExpressionSyntax: a.Detail.Contains('\n') ? a.Detail[(a.Detail.IndexOf('\n') + 1)..] : a.Detail`
- `string.IndexOf(char)`；输入表达式：`a.Detail.IndexOf('\n')`；返回值紧邻使用处：`BinaryExpressionSyntax: a.Detail.IndexOf('\n') + 1`
- `string.Replace(char, char)`；输入表达式：`(a.Detail.Contains('\n') ? a.Detail[(a.Detail.IndexOf('\n') + 1)..] : a.Detail).Replace('\n', ' ')`；返回值紧邻使用处：`ArgumentSyntax: (a.Detail.Contains('\n') ? a.Detail[(a.Detail.IndexOf('\n') + 1)..] : a.Detail).Replace('\n', ' ')`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _cancelDialog?.Invoke()`
- `System.Collections.Generic.IEnumerable<TSource>.AsEnumerable<TSource>()`；输入表达式：`data.Results.AsEnumerable()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Results.AsEnumerable().Reverse`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`CommunityThreads.All(data).OrderByDescending(p => p.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).OrderByDescending(p => p.Day).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；输入表达式：`data.Results.AsEnumerable().Reverse()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Results.AsEnumerable().Reverse().Take`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`CommunityThreads.All(data).OrderByDescending(p => p.Day).Take(50).Select(p => (Id: p.Id, Label: $"第{p.Day}天 · {p.Title}"))`；返回值紧邻使用处：`ConditionalExpressionSyntax: kind == "result" ? data.Results.AsEnumerable().Reverse().Take(30).Select(r => (Id: r.MatchId, Label: $"第{r.Day}天 · {r.Event} · {r.Outcome}"))                  : CommunityThreads.All(data).OrderByDescending(p => p.Day).Take(50).Select(p => (Id: p.Id, Label: $"第{p.Day}天 · {p.Title}"))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`data.Results.AsEnumerable().Reverse().Take(30).Select(r => (Id: r.MatchId, Label: $"第{r.Day}天 · {r.Event} · {r.Outcome}"))`；返回值紧邻使用处：`ConditionalExpressionSyntax: kind == "result" ? data.Results.AsEnumerable().Reverse().Take(30).Select(r => (Id: r.MatchId, Label: $"第{r.Day}天 · {r.Event} · {r.Outcome}"))                  : CommunityThreads.All(data).OrderByDescending(p => p.Day).Take(50).Select(p => (Id: p.Id, Label: $"第{p.Day}天 · {p.Title}"))`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`CommunityThreads.All(data).OrderByDescending(p => p.Day).Take(50)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).OrderByDescending(p => p.Day).Take(50).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`data.Results.AsEnumerable().Reverse().Take(30)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Results.AsEnumerable().Reverse().Take(30).Select`

**赋值（含属性/字段和局部值）：**

- `choice.CustomMinimumSize` = `new(0, 104)`
- `choice.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `CustomMinimumSize` = `new(730, 420)`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `Kind` = `kind`
- `MatchId` = `entry.Id`
- `preview.TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `title.TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`

<a id="symbol-1c1072fdb98b"></a>

## `NationalSpire.CareerScreen.PrivateEditor(string, int, int) — private static TextEdit PrivateEditor(string text, int width = 790, int height = 330)`

来源：源码第 353 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.EditPrivateMessage(NationalSpire.PrivateTurn, bool)`](PrivateMemoryScreen.cs.md#symbol-fc1c08645b40)；[`NationalSpire.CareerScreen.EditPrivateSummary(NationalSpire.PrivateSummary, string)`](PrivateMemoryScreen.cs.md#symbol-92dafd8c57da)

**调用：** [`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.TextEdit.TextEdit()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`input.AddThemeFontSizeOverride("font_size", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: input.AddThemeFontSizeOverride("font_size", 18);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`input.AddThemeStyleboxOverride("normal", CareerVisuals.Box("101d2a", "3a576b", 10, 16))`；返回值紧邻使用处：`ExpressionStatementSyntax: input.AddThemeStyleboxOverride("normal", CareerVisuals.Box("101d2a", "3a576b", 10, 16));`
- `Godot.TextEdit.TextEdit()`；输入表达式：`new TextEdit { Text = text, CustomMinimumSize = new(width, height), WrapMode = TextEdit.LineWrappingMode.Boundary }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TextEdit { Text = text, CustomMinimumSize = new(width, height), WrapMode = TextEdit.LineWrappingMode.Boundary }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(width, height)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(width, height)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("101d2a", "3a576b", 10, 16)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("101d2a", "3a576b", 10, 16)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(width, height)`
- `Text` = `text`
- `WrapMode` = `TextEdit.LineWrappingMode.Boundary`

<a id="symbol-9a1e5f17a52a"></a>

## `NationalSpire.CareerScreen.PrivateMessageMenu(NationalSpire.PrivateTurn, bool) — private void PrivateMessageMenu(PrivateTurn turn, bool player)`

来源：源码第 358 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPrivateBubble(string, bool, NationalSpire.PrivateTurn)`](PrivateMessageScreen.cs.md#symbol-b24b4d693d2a)

**调用：** [`NationalSpire.CareerScreen.DeletePrivateMessage(NationalSpire.PrivateTurn, bool)`](PrivateMemoryScreen.cs.md#symbol-fa60614ca4c0)；[`NationalSpire.CareerScreen.EditPrivateMessage(NationalSpire.PrivateTurn, bool)`](PrivateMemoryScreen.cs.md#symbol-fc1c08645b40)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`](CareerDialog.cs.md#symbol-d832b736b02b)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._cancelDialog`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen.DeletePrivateMessage(NationalSpire.PrivateTurn, bool)`；`NationalSpire.CareerScreen.EditPrivateMessage(NationalSpire.PrivateTurn, bool)`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMessageCommand.Entry`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.PrivateTurn.RequestKind`；`NationalSpire.PrivateTurn.Status`；`NationalSpire.PrivateTurn.UserDeleted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 16);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(PrivateButton("编辑消息", () => { _cancelDialog?.Invoke(); EditPrivateMessage(turn, player); }, 220))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(PrivateButton("编辑消息", () => { _cancelDialog?.Invoke(); EditPrivateMessage(turn, player); }, 220));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(PrivateButton("删除消息", () => { _cancelDialog?.Invoke(); DeletePrivateMessage(turn, player); }, 220))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(PrivateButton("删除消息", () => { _cancelDialog?.Invoke(); DeletePrivateMessage(turn, player); }, 220));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(regenerate)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(regenerate);`
- `NationalSpire.CareerScreen.DeletePrivateMessage(NationalSpire.PrivateTurn, bool)`；输入表达式：`DeletePrivateMessage(turn, player)`；返回值紧邻使用处：`ExpressionStatementSyntax: DeletePrivateMessage(turn, player);`
- `NationalSpire.CareerScreen.EditPrivateMessage(NationalSpire.PrivateTurn, bool)`；输入表达式：`EditPrivateMessage(turn, player)`；返回值紧邻使用处：`ExpressionStatementSyntax: EditPrivateMessage(turn, player);`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("编辑消息", () => { _cancelDialog?.Invoke(); EditPrivateMessage(turn, player); }, 220)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("编辑消息", () => { _cancelDialog?.Invoke(); EditPrivateMessage(turn, player); }, 220)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("删除消息", () => { _cancelDialog?.Invoke(); DeletePrivateMessage(turn, player); }, 220)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("删除消息", () => { _cancelDialog?.Invoke(); DeletePrivateMessage(turn, player); }, 220)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("重新生成", () => { _cancelDialog?.Invoke(); PrivateCommand("dm-regenerate", new() { Entry = turn.Id }); }, 160)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton("重新生成", () => { _cancelDialog?.Invoke(); PrivateCommand("dm-regenerate", new() { Entry = turn.Id }); }, 160)`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`；输入表达式：`PrivateCommand("dm-regenerate", new() { Entry = turn.Id })`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateCommand("dm-regenerate", new() { Entry = turn.Id });`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；输入表达式：`ShowCareerDialog("管理消息", player ? "修改文字不撤销已发生的好感、水平变化与确认事项。" : "编辑只修改文字。重新生成会撤回本条回复的交互，再生成新回复。", () => true, "关闭", box =>          {              var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 16); box.AddChild(row);              row.AddChild(PrivateButton("编辑消息", () => { _cancelDialog?.Invoke(); EditPrivateMessage(turn, player); }, 220));              row.AddChild(PrivateButton("删除消息", () => { _cancelDialog?.Invoke(); DeletePrivateMessage(turn, player); }, 220));              if (!player)              {                  var c = PrivateMessages.Conversation(ViewData, _privatePerson);                  var regenerate = PrivateButton("重新生成", () => { _cancelDialog?.Invoke(); PrivateCommand("dm-regenerate", new() { Entry = turn.Id }); }, 160);                  regenerate.Disabled = turn != c.Turns.LastOrDefault() || turn.Status != "complete" || turn.UserDeleted || turn.RequestKind == "arbitration";                  regenerate.TooltipText = regenerate.Disabled ? "可重新生成最新一条完整回复。" : "撤回本条回复的交互，再生成新的回复与交互。";                  row.AddChild(regenerate);              }          }, showCancel: false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("管理消息", player ? "修改文字不撤销已发生的好感、水平变化与确认事项。" : "编辑只修改文字。重新生成会撤回本条回复的交互，再生成新回复。", () => true, "关闭", box =>          {              var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 16); box.AddChild(row);              row.AddChild(PrivateButton("编辑消息", () => { _cancelDialog?.Invoke(); EditPrivateMessage(turn, player); }, 220));              row.AddChild(PrivateButton("删除消息", () => { _cancelDialog?.Invoke(); DeletePrivateMessage(turn, player); }, 220));              if (!player)              {                  var c = PrivateMessages.Conversation(ViewData, _privatePerson);                  var regenerate = PrivateButton("重新生成", () => { _cancelDialog?.Invoke(); PrivateCommand("dm-regenerate", new() { Entry = turn.Id }); }, 160);                  regenerate.Disabled = turn != c.Turns.LastOrDefault() || turn.Status != "complete" || turn.UserDeleted || turn.RequestKind == "arbitration";                  regenerate.TooltipText = regenerate.Disabled ? "可重新生成最新一条完整回复。" : "撤回本条回复的交互，再生成新的回复与交互。";                  row.AddChild(regenerate);              }          }, showCancel: false);`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Entry = turn.Id }`；返回值紧邻使用处：`ArgumentSyntax: new() { Entry = turn.Id }`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(ViewData, _privatePerson)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(ViewData, _privatePerson)`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _cancelDialog?.Invoke()`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`c.Turns.LastOrDefault()`；返回值紧邻使用处：`BinaryExpressionSyntax: turn != c.Turns.LastOrDefault()`

**赋值（含属性/字段和局部值）：**

- `Entry` = `turn.Id`
- `regenerate.Disabled` = `turn != c.Turns.LastOrDefault() || turn.Status != "complete" || turn.UserDeleted || turn.RequestKind == "arbitration"`
- `regenerate.TooltipText` = `regenerate.Disabled ? "可重新生成最新一条完整回复。" : "撤回本条回复的交互，再生成新的回复与交互。"`

<a id="symbol-fc1c08645b40"></a>

## `NationalSpire.CareerScreen.EditPrivateMessage(NationalSpire.PrivateTurn, bool) — private void EditPrivateMessage(PrivateTurn turn, bool player)`

来源：源码第 375 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateMessageMenu(NationalSpire.PrivateTurn, bool)`](PrivateMemoryScreen.cs.md#symbol-9a1e5f17a52a)

**调用：** [`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.PrivateEditor(string, int, int)`](PrivateMemoryScreen.cs.md#symbol-1c1072fdb98b)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`](CareerDialog.cs.md#symbol-d832b736b02b)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；`string.IsNullOrWhiteSpace(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`；`NationalSpire.CareerScreen.PrivateEditor(string, int, int)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；`NationalSpire.PrivateMessageCommand.Entry`；`NationalSpire.PrivateMessageCommand.Part`；`NationalSpire.PrivateMessageCommand.Text`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.PrivateTurn.Reply`；`NationalSpire.PrivateTurn.User`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(input)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(input);`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`；输入表达式：`PrivateCommand("dm-edit", new() { Entry = turn.Id, Part = player ? "user" : "reply", Text = input.Text })`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateCommand("dm-edit", new() { Entry = turn.Id, Part = player ? "user" : "reply", Text = input.Text });`
- `NationalSpire.CareerScreen.PrivateEditor(string, int, int)`；输入表达式：`PrivateEditor(player ? turn.User : turn.Reply)`；返回值紧邻使用处：`AssignmentExpressionSyntax: input = PrivateEditor(player ? turn.User : turn.Reply)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；输入表达式：`ShowCareerDialog("编辑消息", "已有总结需在记忆管理中单独修改。", () =>          {              if (string.IsNullOrWhiteSpace(input!.Text)) return false;              PrivateCommand("dm-edit", new() { Entry = turn.Id, Part = player ? "user" : "reply", Text = input.Text }); return true;          }, "保存", box => { input = PrivateEditor(player ? turn.User : turn.Reply); box.AddChild(input); })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("编辑消息", "已有总结需在记忆管理中单独修改。", () =>          {              if (string.IsNullOrWhiteSpace(input!.Text)) return false;              PrivateCommand("dm-edit", new() { Entry = turn.Id, Part = player ? "user" : "reply", Text = input.Text }); return true;          }, "保存", box => { input = PrivateEditor(player ? turn.User : turn.Reply); box.AddChild(input); });`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Entry = turn.Id, Part = player ? "user" : "reply", Text = input.Text }`；返回值紧邻使用处：`ArgumentSyntax: new() { Entry = turn.Id, Part = player ? "user" : "reply", Text = input.Text }`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(input!.Text)`；返回值紧邻使用处：`IfStatementSyntax: if (string.IsNullOrWhiteSpace(input!.Text)) return false;`

**赋值（含属性/字段和局部值）：**

- `Entry` = `turn.Id`
- `input` = `PrivateEditor(player ? turn.User : turn.Reply)`
- `Part` = `player ? "user" : "reply"`
- `Text` = `input.Text`

<a id="symbol-fa60614ca4c0"></a>

## `NationalSpire.CareerScreen.DeletePrivateMessage(NationalSpire.PrivateTurn, bool) — private void DeletePrivateMessage(PrivateTurn turn, bool player)`

来源：源码第 384 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateMessageMenu(NationalSpire.PrivateTurn, bool)`](PrivateMemoryScreen.cs.md#symbol-9a1e5f17a52a)

**调用：** [`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`](CareerDialog.cs.md#symbol-d832b736b02b)；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；`NationalSpire.PrivateMessageCommand.Entry`；`NationalSpire.PrivateMessageCommand.Part`；`NationalSpire.PrivateTurn.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`；输入表达式：`PrivateCommand("dm-delete", new() { Entry = turn.Id, Part = player ? "user" : "reply" })`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateCommand("dm-delete", new() { Entry = turn.Id, Part = player ? "user" : "reply" });`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；输入表达式：`ShowCareerDialog("删除这条消息", "同时删除这条消息的未确认交互。总结及已确认事项保留。", () =>      { PrivateCommand("dm-delete", new() { Entry = turn.Id, Part = player ? "user" : "reply" }); return true; }, "删除")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => ShowCareerDialog("删除这条消息", "同时删除这条消息的未确认交互。总结及已确认事项保留。", () =>      { PrivateCommand("dm-delete", new() { Entry = turn.Id, Part = player ? "user" : "reply" }); return true; }, "删除")`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Entry = turn.Id, Part = player ? "user" : "reply" }`；返回值紧邻使用处：`ArgumentSyntax: new() { Entry = turn.Id, Part = player ? "user" : "reply" }`

**赋值（含属性/字段和局部值）：**

- `Entry` = `turn.Id`
- `Part` = `player ? "user" : "reply"`

<a id="symbol-942a4a496637"></a>

## `NationalSpire.CareerScreen.PrivateMemory() — private void PrivateMemory()`

来源：源码第 386 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`MemoryTab(string, int, string, string)`](PrivateMemoryScreen.cs.md#symbol-477d5039b5b1)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`](CareerAvatars.cs.md#symbol-9f2c4623a902)；[`NationalSpire.CareerScreen.GroupMemory()`](GroupChatDialogs.cs.md#symbol-bf729ae9b3eb)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`](PrivateMessageScreen.cs.md#symbol-fb5e88f4639a)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`](CareerDialog.cs.md#symbol-d832b736b02b)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；[`Section(string)`](PrivateMemoryScreen.cs.md#symbol-55885a3fae26)；`Godot.Color.Color(string)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.Control()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.HSeparator.HSeparator()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.ScrollContainer.ScrollContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；`NationalSpire.PrivateOrnament.PrivateOrnament()`；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `MemoryTab(string, int, string, string)`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen._cancelDialog`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen._privateStatus`；`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`；`NationalSpire.CareerScreen.GroupMemory()`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`；`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.PrivateConversation.BigSummaries`；`NationalSpire.PrivateConversation.SmallSummaries`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMessageCommand.Part`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOrnament.Kind`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.UserDeleted`；`Section(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("526a7c")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Modulate = new Color("526a7c")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("ffb6b6")`；返回值紧邻使用处：`ArgumentSyntax: new Color("ffb6b6")`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`clear.AddThemeColorOverride("font_color", new Color("ffb6b6"))`；返回值紧邻使用处：`ExpressionStatementSyntax: clear.AddThemeColorOverride("font_color", new Color("ffb6b6"));`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`heading.AddThemeConstantOverride("separation", 20)`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddThemeConstantOverride("separation", 20);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`list.AddThemeConstantOverride("separation", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddThemeConstantOverride("separation", 18);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`tabs.AddThemeConstantOverride("separation", 20)`；返回值紧邻使用处：`ExpressionStatementSyntax: tabs.AddThemeConstantOverride("separation", 20);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`title.AddThemeConstantOverride("separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: title.AddThemeConstantOverride("separation", 10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`toolbar.AddThemeConstantOverride("separation", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: toolbar.AddThemeConstantOverride("separation", 18);`
- `Godot.Control.Control()`；输入表达式：`new Control { CustomMinimumSize = new(68, 72) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Control { CustomMinimumSize = new(68, 72) }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.HSeparator.HSeparator()`；输入表达式：`new HSeparator { Modulate = new Color("526a7c") }`；返回值紧邻使用处：`ArgumentSyntax: new HSeparator { Modulate = new Color("526a7c") }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(clear)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(clear);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(heading)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(heading);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(new HSeparator { Modulate = new Color("526a7c") })`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(new HSeparator { Modulate = new Color("526a7c") });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(tabs)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(tabs);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(toolbar)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(toolbar);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`emblem.AddChild(new PrivateOrnament { Kind = "archive", MouseFilter = MouseFilterEnum.Ignore })`；返回值紧邻使用处：`ExpressionStatementSyntax: emblem.AddChild(new PrivateOrnament { Kind = "archive", MouseFilter = MouseFilterEnum.Ignore });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(Avatar(data, _privatePerson, 56, false))`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(Avatar(data, _privatePerson, 56, false));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(emblem)`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(emblem);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(title)`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(title);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scroll.AddChild(list)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.AddChild(list);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`title.AddChild(PrivateText("两类摘要都会保留，用于后续聊天。", 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: title.AddChild(PrivateText("两类摘要都会保留，用于后续聊天。", 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`title.AddChild(PrivateText(CareerEngine.DisplayName(data, _privatePerson), 23, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: title.AddChild(PrivateText(CareerEngine.DisplayName(data, _privatePerson), 23, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`toolbar.AddChild(action)`；返回值紧邻使用处：`ExpressionStatementSyntax: toolbar.AddChild(action);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`toolbar.AddChild(explanation)`；返回值紧邻使用处：`ExpressionStatementSyntax: toolbar.AddChild(explanation);`
- `Godot.ScrollContainer.ScrollContainer()`；输入表达式：`new ScrollContainer { CustomMinimumSize = new(800, 180), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ScrollContainer { CustomMinimumSize = new(800, 180), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(68, 72)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(68, 72)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(800, 180)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(800, 180)`
- `MemoryTab(string, int, string, string)`；输入表达式：`MemoryTab("合并摘要", c.BigSummaries.Count, "来自多条较早的摘要", "big")`；返回值紧邻使用处：`AssignmentExpressionSyntax: longTab = MemoryTab("合并摘要", c.BigSummaries.Count, "来自多条较早的摘要", "big")`
- `MemoryTab(string, int, string, string)`；输入表达式：`MemoryTab("聊天摘要", c.SmallSummaries.Count, "来自双方的聊天记录", "small")`；返回值紧邻使用处：`AssignmentExpressionSyntax: shortTab = MemoryTab("聊天摘要", c.SmallSummaries.Count, "来自双方的聊天记录", "small")`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, _privatePerson)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.DisplayName(data, _privatePerson)`
- `NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`；输入表达式：`Avatar(data, _privatePerson, 56, false)`；返回值紧邻使用处：`ArgumentSyntax: Avatar(data, _privatePerson, 56, false)`
- `NationalSpire.CareerScreen.GroupMemory()`；输入表达式：`GroupMemory()`；返回值紧邻使用处：`ExpressionStatementSyntax: GroupMemory();`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("清空聊天记录", () =>              {                  _cancelDialog?.Invoke(); ShowCareerDialog("清空当前聊天记录", "删除聊天及其未确认交互。总结、好感和已确认事项保留。", () => { PrivateCommand("dm-clear", new()); return true; }, "清空记录");              }, 180)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton("清空聊天记录", () =>              {                  _cancelDialog?.Invoke(); ShowCareerDialog("清空当前聊天记录", "删除聊天及其未确认交互。总结、好感和已确认事项保留。", () => { PrivateCommand("dm-clear", new()); return true; }, "清空记录");              }, 180)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("整理聊天", () => { _cancelDialog?.Invoke(); PrivateCommand("dm-summary", new() { Part = selectedKind }); }, 155)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton("整理聊天", () => { _cancelDialog?.Invoke(); PrivateCommand("dm-summary", new() { Part = selectedKind }); }, 155)`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`；输入表达式：`PrivateCommand("dm-clear", new())`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateCommand("dm-clear", new());`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`；输入表达式：`PrivateCommand("dm-summary", new() { Part = selectedKind })`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateCommand("dm-summary", new() { Part = selectedKind });`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText("", 16, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateText("", 16, _muted)`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText("两类摘要都会保留，用于后续聊天。", 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: PrivateText("两类摘要都会保留，用于后续聊天。", 16, _muted)`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText(CareerEngine.DisplayName(data, _privatePerson), 23, _ink)`；返回值紧邻使用处：`ArgumentSyntax: PrivateText(CareerEngine.DisplayName(data, _privatePerson), 23, _ink)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；输入表达式：`ShowCareerDialog("聊天记忆", "", () => true, "关闭", box =>          {              var heading = new HBoxContainer(); heading.AddThemeConstantOverride("separation", 20); box.AddChild(heading);              var emblem = new Control { CustomMinimumSize = new(68, 72) }; heading.AddChild(emblem);              emblem.AddChild(new PrivateOrnament { Kind = "archive", MouseFilter = MouseFilterEnum.Ignore });              var title = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; title.AddThemeConstantOverride("separation", 10); heading.AddChild(title);              title.AddChild(PrivateText(CareerEngine.DisplayName(data, _privatePerson), 23, _ink));              title.AddChild(PrivateText("两类摘要都会保留，用于后续聊天。", 16, _muted));              heading.AddChild(Avatar(data, _privatePerson, 56, false));              var tabs = new HBoxContainer(); tabs.AddThemeConstantOverride("separation", 20); box.AddChild(tabs);              var toolbar = new HBoxContainer(); toolbar.AddThemeConstantOverride("separation", 18); box.AddChild(toolbar);              var explanation = PrivateText("", 16, _muted); explanation.SizeFlagsHorizontal = SizeFlags.ExpandFill; toolbar.AddChild(explanation);              string selectedKind = "small";              var action = PrivateButton("整理聊天", () => { _cancelDialog?.Invoke(); PrivateCommand("dm-summary", new() { Part = selectedKind }); }, 155); toolbar.AddChild(action);              var scroll = new ScrollContainer { CustomMinimumSize = new(800, 180), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);              var list = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; list.AddThemeConstantOverride("separation", 18); scroll.AddChild(list);              Button? shortTab = null, longTab = null;              void Section(string kind)              {                  selectedKind = kind; CareerVisuals.ClearContent(list);                  var summaries = kind == "big" ? c.BigSummaries : c.SmallSummaries;                  explanation.Text = kind == "big" ? "将多条较早的聊天摘要整理成一条。" : "提取聊天中的经历、约定与重要细节。";                  action.Text = kind == "big" ? "合并旧摘要" : "整理聊天";                  action.Disabled = c.SummaryStatus.Length > 0 || (kind == "big" ? c.SmallSummaries.Count < 2 : PrivateMessages.Completed(c) == 0);                  foreach (var (tab, selected) in new[] { (shortTab!, kind == "small"), (longTab!, kind == "big") })                  {                      var style = CareerVisuals.Box(selected ? "263d50" : "122330", selected ? "d9bd7e" : "395064", 2, 16);                      style.BorderWidthBottom = selected ? 3 : 1; tab.AddThemeStyleboxOverride("normal", style);                  }                  scroll.CustomMinimumSize = new(800, summaries.Count == 0 ? 165 : Math.Min(360, 210 * summaries.Count));                  foreach (var s in summaries.AsEnumerable().Reverse())                  {                      var card = new PanelContainer(); var style = CareerVisuals.Box("101f2d", "3c5469", 3, 20); style.BorderWidthLeft = 3; card.AddThemeStyleboxOverride("panel", style); list.AddChild(card);                      var inner = new VBoxContainer(); inner.AddThemeConstantOverride("separation", 16); card.AddChild(inner);                      var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); inner.AddChild(row);                      var first = c.Turns.ElementAtOrDefault(s.From); var last = c.Turns.ElementAtOrDefault(s.Through - 1);                      string dates = first == null || last == null ? "已保存" : first.Day == last.Day                          ? $"第 {first.Season} 赛季 · 第 {SeasonCalendar.Day(data, first.Day)} 天" : first.Season == last.Season                          ? $"第 {first.Season} 赛季 · 第 {SeasonCalendar.Day(data, first.Day)}—{SeasonCalendar.Day(data, last.Day)} 天"                          : $"第 {first.Season} 赛季第 {SeasonCalendar.Day(data, first.Day)} 天—第 {last.Season} 赛季第 {SeasonCalendar.Day(data, last.Day)} 天";                      var label = PrivateLine(dates, 14, _gold); label.SizeFlagsHorizontal = SizeFlags.ExpandFill; row.AddChild(label);                      row.AddChild(PrivateButton("编辑", () => { _cancelDialog?.Invoke(); EditPrivateSummary(s, kind); }, 72));                      row.AddChild(PrivateButton("删除", () =>                      {                          string warning = s.IsLatest(c.SmallSummaries.Concat(c.BigSummaries)) ? "" : "删除这条总结可能导致永久丢失记忆。";                          _cancelDialog?.Invoke(); ShowCareerDialog("删除这条总结", warning, () => { PrivateCommand("dm-summary-delete", new() { Entry = s.Id, Part = kind }); return true; }, "确认删除");                      }, 72));                      inner.AddChild(PrivateText(s.Text, 18, _ink));                  }                  if (summaries.Count == 0)                  {                      var center = new CenterContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 155) }; list.AddChild(center);                      var empty = new HBoxContainer(); empty.AddThemeConstantOverride("separation", 26); center.AddChild(empty);                      var icon = new Control { CustomMinimumSize = new(56, 62) }; empty.AddChild(icon); icon.AddChild(new PrivateOrnament { Kind = kind == "big" ? "archive" : "summary", MouseFilter = MouseFilterEnum.Ignore });                      var words = new VBoxContainer { CustomMinimumSize = new(380, 0), SizeFlagsVertical = SizeFlags.ShrinkCenter }; words.AddThemeConstantOverride("separation", 12); empty.AddChild(words);                      words.AddChild(PrivateLine(kind == "big" ? "尚无合并摘要" : "尚无聊天摘要", 22, _ink));                      words.AddChild(PrivateLine(kind == "big" ? "积累多条聊天摘要后，可以合并整理。" : "继续聊天后自动整理，也可以手动整理。", 16, _muted));                  }              }              Button MemoryTab(string name, int count, string detail, string kind)              {                  var button = PrivateButton("", () => Section(kind), 390); button.CustomMinimumSize = new(390, 108); tabs.AddChild(button);                  var inset = new MarginContainer(); button.AddChild(inset); inset.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);                  foreach (string edge in new[] { "left", "right", "top", "bottom" }) inset.AddThemeConstantOverride("margin_" + edge, 18);                  var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 15); inset.AddChild(row);                  var icon = new Control { CustomMinimumSize = new(42, 50) }; row.AddChild(icon); icon.AddChild(new PrivateOrnament { Kind = kind == "big" ? "archive" : "summary" });                  var text = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; text.AddThemeConstantOverride("separation", 9); row.AddChild(text);                  text.AddChild(PrivateLine(name, 21, _ink)); text.AddChild(PrivateLine(detail, 14, _muted));                  row.AddChild(PrivateLine(count.ToString("00"), 30, _gold)); PrivateIgnoreMouse(inset); return button;              }              shortTab = MemoryTab("聊天摘要", c.SmallSummaries.Count, "来自双方的聊天记录", "small");              longTab = MemoryTab("合并摘要", c.BigSummaries.Count, "来自多条较早的摘要", "big"); Section("small");              box.AddChild(new HSeparator { Modulate = new Color("526a7c") });              var clear = PrivateButton("清空聊天记录", () =>              {                  _cancelDialog?.Invoke(); ShowCareerDialog("清空当前聊天记录", "删除聊天及其未确认交互。总结、好感和已确认事项保留。", () => { PrivateCommand("dm-clear", new()); return true; }, "清空记录");              }, 180); clear.AddThemeColorOverride("font_color", new Color("ffb6b6")); clear.Disabled = !c.Turns.Any(t => !(t.UserDeleted && t.ReplyDeleted)); box.AddChild(clear);          }, showCancel: false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("聊天记忆", "", () => true, "关闭", box =>          {              var heading = new HBoxContainer(); heading.AddThemeConstantOverride("separation", 20); box.AddChild(heading);              var emblem = new Control { CustomMinimumSize = new(68, 72) }; heading.AddChild(emblem);              emblem.AddChild(new PrivateOrnament { Kind = "archive", MouseFilter = MouseFilterEnum.Ignore });              var title = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; title.AddThemeConstantOverride("separation", 10); heading.AddChild(title);              title.AddChild(PrivateText(CareerEngine.DisplayName(data, _privatePerson), 23, _ink));              title.AddChild(PrivateText("两类摘要都会保留，用于后续聊天。", 16, _muted));              heading.AddChild(Avatar(data, _privatePerson, 56, false));              var tabs = new HBoxContainer(); tabs.AddThemeConstantOverride("separation", 20); box.AddChild(tabs);              var toolbar = new HBoxContainer(); toolbar.AddThemeConstantOverride("separation", 18); box.AddChild(toolbar);              var explanation = PrivateText("", 16, _muted); explanation.SizeFlagsHorizontal = SizeFlags.ExpandFill; toolbar.AddChild(explanation);              string selectedKind = "small";              var action = PrivateButton("整理聊天", () => { _cancelDialog?.Invoke(); PrivateCommand("dm-summary", new() { Part = selectedKind }); }, 155); toolbar.AddChild(action);              var scroll = new ScrollContainer { CustomMinimumSize = new(800, 180), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);              var list = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; list.AddThemeConstantOverride("separation", 18); scroll.AddChild(list);              Button? shortTab = null, longTab = null;              void Section(string kind)              {                  selectedKind = kind; CareerVisuals.ClearContent(list);                  var summaries = kind == "big" ? c.BigSummaries : c.SmallSummaries;                  explanation.Text = kind == "big" ? "将多条较早的聊天摘要整理成一条。" : "提取聊天中的经历、约定与重要细节。";                  action.Text = kind == "big" ? "合并旧摘要" : "整理聊天";                  action.Disabled = c.SummaryStatus.Length > 0 || (kind == "big" ? c.SmallSummaries.Count < 2 : PrivateMessages.Completed(c) == 0);                  foreach (var (tab, selected) in new[] { (shortTab!, kind == "small"), (longTab!, kind == "big") })                  {                      var style = CareerVisuals.Box(selected ? "263d50" : "122330", selected ? "d9bd7e" : "395064", 2, 16);                      style.BorderWidthBottom = selected ? 3 : 1; tab.AddThemeStyleboxOverride("normal", style);                  }                  scroll.CustomMinimumSize = new(800, summaries.Count == 0 ? 165 : Math.Min(360, 210 * summaries.Count));                  foreach (var s in summaries.AsEnumerable().Reverse())                  {                      var card = new PanelContainer(); var style = CareerVisuals.Box("101f2d", "3c5469", 3, 20); style.BorderWidthLeft = 3; card.AddThemeStyleboxOverride("panel", style); list.AddChild(card);                      var inner = new VBoxContainer(); inner.AddThemeConstantOverride("separation", 16); card.AddChild(inner);                      var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); inner.AddChild(row);                      var first = c.Turns.ElementAtOrDefault(s.From); var last = c.Turns.ElementAtOrDefault(s.Through - 1);                      string dates = first == null || last == null ? "已保存" : first.Day == last.Day                          ? $"第 {first.Season} 赛季 · 第 {SeasonCalendar.Day(data, first.Day)} 天" : first.Season == last.Season                          ? $"第 {first.Season} 赛季 · 第 {SeasonCalendar.Day(data, first.Day)}—{SeasonCalendar.Day(data, last.Day)} 天"                          : $"第 {first.Season} 赛季第 {SeasonCalendar.Day(data, first.Day)} 天—第 {last.Season} 赛季第 {SeasonCalendar.Day(data, last.Day)} 天";                      var label = PrivateLine(dates, 14, _gold); label.SizeFlagsHorizontal = SizeFlags.ExpandFill; row.AddChild(label);                      row.AddChild(PrivateButton("编辑", () => { _cancelDialog?.Invoke(); EditPrivateSummary(s, kind); }, 72));                      row.AddChild(PrivateButton("删除", () =>                      {                          string warning = s.IsLatest(c.SmallSummaries.Concat(c.BigSummaries)) ? "" : "删除这条总结可能导致永久丢失记忆。";                          _cancelDialog?.Invoke(); ShowCareerDialog("删除这条总结", warning, () => { PrivateCommand("dm-summary-delete", new() { Entry = s.Id, Part = kind }); return true; }, "确认删除");                      }, 72));                      inner.AddChild(PrivateText(s.Text, 18, _ink));                  }                  if (summaries.Count == 0)                  {                      var center = new CenterContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 155) }; list.AddChild(center);                      var empty = new HBoxContainer(); empty.AddThemeConstantOverride("separation", 26); center.AddChild(empty);                      var icon = new Control { CustomMinimumSize = new(56, 62) }; empty.AddChild(icon); icon.AddChild(new PrivateOrnament { Kind = kind == "big" ? "archive" : "summary", MouseFilter = MouseFilterEnum.Ignore });                      var words = new VBoxContainer { CustomMinimumSize = new(380, 0), SizeFlagsVertical = SizeFlags.ShrinkCenter }; words.AddThemeConstantOverride("separation", 12); empty.AddChild(words);                      words.AddChild(PrivateLine(kind == "big" ? "尚无合并摘要" : "尚无聊天摘要", 22, _ink));                      words.AddChild(PrivateLine(kind == "big" ? "积累多条聊天摘要后，可以合并整理。" : "继续聊天后自动整理，也可以手动整理。", 16, _muted));                  }              }              Button MemoryTab(string name, int count, string detail, string kind)              {                  var button = PrivateButton("", () => Section(kind), 390); button.CustomMinimumSize = new(390, 108); tabs.AddChild(button);                  var inset = new MarginContainer(); button.AddChild(inset); inset.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);                  foreach (string edge in new[] { "left", "right", "top", "bottom" }) inset.AddThemeConstantOverride("margin_" + edge, 18);                  var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 15); inset.AddChild(row);                  var icon = new Control { CustomMinimumSize = new(42, 50) }; row.AddChild(icon); icon.AddChild(new PrivateOrnament { Kind = kind == "big" ? "archive" : "summary" });                  var text = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; text.AddThemeConstantOverride("separation", 9); row.AddChild(text);                  text.AddChild(PrivateLine(name, 21, _ink)); text.AddChild(PrivateLine(detail, 14, _muted));                  row.AddChild(PrivateLine(count.ToString("00"), 30, _gold)); PrivateIgnoreMouse(inset); return button;              }              shortTab = MemoryTab("聊天摘要", c.SmallSummaries.Count, "来自双方的聊天记录", "small");              longTab = MemoryTab("合并摘要", c.BigSummaries.Count, "来自多条较早的摘要", "big"); Section("small");              box.AddChild(new HSeparator { Modulate = new Color("526a7c") });              var clear = PrivateButton("清空聊天记录", () =>              {                  _cancelDialog?.Invoke(); ShowCareerDialog("清空当前聊天记录", "删除聊天及其未确认交互。总结、好感和已确认事项保留。", () => { PrivateCommand("dm-clear", new()); return true; }, "清空记录");              }, 180); clear.AddThemeColorOverride("font_color", new Color("ffb6b6")); clear.Disabled = !c.Turns.Any(t => !(t.UserDeleted && t.ReplyDeleted)); box.AddChild(clear);          }, showCancel: false);`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；输入表达式：`ShowCareerDialog("清空当前聊天记录", "删除聊天及其未确认交互。总结、好感和已确认事项保留。", () => { PrivateCommand("dm-clear", new()); return true; }, "清空记录")`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("清空当前聊天记录", "删除聊天及其未确认交互。总结、好感和已确认事项保留。", () => { PrivateCommand("dm-clear", new()); return true; }, "清空记录");`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Part = selectedKind }`；返回值紧邻使用处：`ArgumentSyntax: new() { Part = selectedKind }`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new()`；返回值紧邻使用处：`ArgumentSyntax: new()`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, _privatePerson)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(data, _privatePerson)`
- `NationalSpire.PrivateOrnament.PrivateOrnament()`；输入表达式：`new PrivateOrnament { Kind = "archive", MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`ArgumentSyntax: new PrivateOrnament { Kind = "archive", MouseFilter = MouseFilterEnum.Ignore }`
- `Section(string)`；输入表达式：`Section("small")`；返回值紧邻使用处：`ExpressionStatementSyntax: Section("small");`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _cancelDialog?.Invoke()`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.Any(t => !(t.UserDeleted && t.ReplyDeleted))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !c.Turns.Any(t => !(t.UserDeleted && t.ReplyDeleted))`

**赋值（含属性/字段和局部值）：**

- `_privateStatus!.Text` = `"请先选择一位选手。"`
- `clear.Disabled` = `!c.Turns.Any(t => !(t.UserDeleted && t.ReplyDeleted))`
- `CustomMinimumSize` = `new(68, 72)`
- `CustomMinimumSize` = `new(800, 180)`
- `explanation.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `Kind` = `"archive"`
- `longTab` = `MemoryTab("合并摘要", c.BigSummaries.Count, "来自多条较早的摘要", "big")`
- `Modulate` = `new Color("526a7c")`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Part` = `selectedKind`
- `shortTab` = `MemoryTab("聊天摘要", c.SmallSummaries.Count, "来自双方的聊天记录", "small")`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-55885a3fae26"></a>

## `Section(string) — void Section(string kind)`

来源：源码第 408 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`MemoryTab(string, int, string, string)`](PrivateMemoryScreen.cs.md#symbol-477d5039b5b1)；[`NationalSpire.CareerScreen.PrivateMemory()`](PrivateMemoryScreen.cs.md#symbol-942a4a496637)

**调用：** [`NationalSpire.CareerScreen.EditPrivateSummary(NationalSpire.PrivateSummary, string)`](PrivateMemoryScreen.cs.md#symbol-92dafd8c57da)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-84294149ff91)；[`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`](PrivateMessageScreen.cs.md#symbol-fb5e88f4639a)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`](CareerDialog.cs.md#symbol-d832b736b02b)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`NationalSpire.PrivateMessages.Completed(NationalSpire.PrivateConversation)`](PrivateMessages.cs.md#symbol-3f3045d6546b)；[`NationalSpire.PrivateSummary.IsLatest(System.Collections.Generic.IEnumerable<NationalSpire.PrivateSummary>)`](PrivateMessageData.cs.md#symbol-db2a1a2d7b09)；[`NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-0f707d2c9895)；`Godot.CenterContainer.CenterContainer()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.Control()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；`NationalSpire.PrivateOrnament.PrivateOrnament()`；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Collections.Generic.IEnumerable<TSource>.AsEnumerable<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.ElementAtOrDefault<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._cancelDialog`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.EditPrivateSummary(NationalSpire.PrivateSummary, string)`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`；`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.PrivateConversation.BigSummaries`；`NationalSpire.PrivateConversation.SmallSummaries`；`NationalSpire.PrivateConversation.SummaryStatus`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMessageCommand.Entry`；`NationalSpire.PrivateMessageCommand.Part`；`NationalSpire.PrivateMessages.Completed(NationalSpire.PrivateConversation)`；`NationalSpire.PrivateOrnament.Kind`；`NationalSpire.PrivateSummary.From`；`NationalSpire.PrivateSummary.Id`；`NationalSpire.PrivateSummary.IsLatest(System.Collections.Generic.IEnumerable<NationalSpire.PrivateSummary>)`；`NationalSpire.PrivateSummary.Text`；`NationalSpire.PrivateSummary.Through`；`NationalSpire.PrivateTurn.Day`；`NationalSpire.PrivateTurn.Season`；`NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CenterContainer.CenterContainer()`；输入表达式：`new CenterContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 155) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CenterContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 155) }`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`empty.AddThemeConstantOverride("separation", 26)`；返回值紧邻使用处：`ExpressionStatementSyntax: empty.AddThemeConstantOverride("separation", 26);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`inner.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: inner.AddThemeConstantOverride("separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`words.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: words.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`card.AddThemeStyleboxOverride("panel", style)`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddThemeStyleboxOverride("panel", style);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`tab.AddThemeStyleboxOverride("normal", style)`；返回值紧邻使用处：`ExpressionStatementSyntax: tab.AddThemeStyleboxOverride("normal", style);`
- `Godot.Control.Control()`；输入表达式：`new Control { CustomMinimumSize = new(56, 62) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Control { CustomMinimumSize = new(56, 62) }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`card.AddChild(inner)`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddChild(inner);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`center.AddChild(empty)`；返回值紧邻使用处：`ExpressionStatementSyntax: center.AddChild(empty);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`empty.AddChild(icon)`；返回值紧邻使用处：`ExpressionStatementSyntax: empty.AddChild(icon);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`empty.AddChild(words)`；返回值紧邻使用处：`ExpressionStatementSyntax: empty.AddChild(words);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`icon.AddChild(new PrivateOrnament { Kind = kind == "big" ? "archive" : "summary", MouseFilter = MouseFilterEnum.Ignore })`；返回值紧邻使用处：`ExpressionStatementSyntax: icon.AddChild(new PrivateOrnament { Kind = kind == "big" ? "archive" : "summary", MouseFilter = MouseFilterEnum.Ignore });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inner.AddChild(PrivateText(s.Text, 18, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: inner.AddChild(PrivateText(s.Text, 18, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inner.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: inner.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`list.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`list.AddChild(center)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddChild(center);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(label)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(label);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(PrivateButton("编辑", () => { _cancelDialog?.Invoke(); EditPrivateSummary(s, kind); }, 72))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(PrivateButton("编辑", () => { _cancelDialog?.Invoke(); EditPrivateSummary(s, kind); }, 72));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(PrivateButton("删除", () =>                      {                          string warning = s.IsLatest(c.SmallSummaries.Concat(c.BigSummaries)) ? "" : "删除这条总结可能导致永久丢失记忆。";                          _cancelDialog?.Invoke(); ShowCareerDialog("删除这条总结", warning, () => { PrivateCommand("dm-summary-delete", new() { Entry = s.Id, Part = kind }); return true; }, "确认删除");                      }, 72))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(PrivateButton("删除", () =>                      {                          string warning = s.IsLatest(c.SmallSummaries.Concat(c.BigSummaries)) ? "" : "删除这条总结可能导致永久丢失记忆。";                          _cancelDialog?.Invoke(); ShowCareerDialog("删除这条总结", warning, () => { PrivateCommand("dm-summary-delete", new() { Entry = s.Id, Part = kind }); return true; }, "确认删除");                      }, 72));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`words.AddChild(PrivateLine(kind == "big" ? "积累多条聊天摘要后，可以合并整理。" : "继续聊天后自动整理，也可以手动整理。", 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: words.AddChild(PrivateLine(kind == "big" ? "积累多条聊天摘要后，可以合并整理。" : "继续聊天后自动整理，也可以手动整理。", 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`words.AddChild(PrivateLine(kind == "big" ? "尚无合并摘要" : "尚无聊天摘要", 22, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: words.AddChild(PrivateLine(kind == "big" ? "尚无合并摘要" : "尚无聊天摘要", 22, _ink));`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer()`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { CustomMinimumSize = new(380, 0), SizeFlagsVertical = SizeFlags.ShrinkCenter }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { CustomMinimumSize = new(380, 0), SizeFlagsVertical = SizeFlags.ShrinkCenter }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 155)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 155)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(380, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(380, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(56, 62)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(56, 62)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(800, summaries.Count == 0 ? 165 : Math.Min(360, 210 * summaries.Count))`；返回值紧邻使用处：`AssignmentExpressionSyntax: scroll.CustomMinimumSize = new(800, summaries.Count == 0 ? 165 : Math.Min(360, 210 * summaries.Count))`
- `NationalSpire.CareerScreen.EditPrivateSummary(NationalSpire.PrivateSummary, string)`；输入表达式：`EditPrivateSummary(s, kind)`；返回值紧邻使用处：`ExpressionStatementSyntax: EditPrivateSummary(s, kind);`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("编辑", () => { _cancelDialog?.Invoke(); EditPrivateSummary(s, kind); }, 72)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("编辑", () => { _cancelDialog?.Invoke(); EditPrivateSummary(s, kind); }, 72)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("删除", () =>                      {                          string warning = s.IsLatest(c.SmallSummaries.Concat(c.BigSummaries)) ? "" : "删除这条总结可能导致永久丢失记忆。";                          _cancelDialog?.Invoke(); ShowCareerDialog("删除这条总结", warning, () => { PrivateCommand("dm-summary-delete", new() { Entry = s.Id, Part = kind }); return true; }, "确认删除");                      }, 72)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("删除", () =>                      {                          string warning = s.IsLatest(c.SmallSummaries.Concat(c.BigSummaries)) ? "" : "删除这条总结可能导致永久丢失记忆。";                          _cancelDialog?.Invoke(); ShowCareerDialog("删除这条总结", warning, () => { PrivateCommand("dm-summary-delete", new() { Entry = s.Id, Part = kind }); return true; }, "确认删除");                      }, 72)`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`；输入表达式：`PrivateCommand("dm-summary-delete", new() { Entry = s.Id, Part = kind })`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateCommand("dm-summary-delete", new() { Entry = s.Id, Part = kind });`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine(dates, 14, _gold)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateLine(dates, 14, _gold)`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine(kind == "big" ? "积累多条聊天摘要后，可以合并整理。" : "继续聊天后自动整理，也可以手动整理。", 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: PrivateLine(kind == "big" ? "积累多条聊天摘要后，可以合并整理。" : "继续聊天后自动整理，也可以手动整理。", 16, _muted)`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine(kind == "big" ? "尚无合并摘要" : "尚无聊天摘要", 22, _ink)`；返回值紧邻使用处：`ArgumentSyntax: PrivateLine(kind == "big" ? "尚无合并摘要" : "尚无聊天摘要", 22, _ink)`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText(s.Text, 18, _ink)`；返回值紧邻使用处：`ArgumentSyntax: PrivateText(s.Text, 18, _ink)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；输入表达式：`ShowCareerDialog("删除这条总结", warning, () => { PrivateCommand("dm-summary-delete", new() { Entry = s.Id, Part = kind }); return true; }, "确认删除")`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("删除这条总结", warning, () => { PrivateCommand("dm-summary-delete", new() { Entry = s.Id, Part = kind }); return true; }, "确认删除");`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("101f2d", "3c5469", 3, 20)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerVisuals.Box("101f2d", "3c5469", 3, 20)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box(selected ? "263d50" : "122330", selected ? "d9bd7e" : "395064", 2, 16)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerVisuals.Box(selected ? "263d50" : "122330", selected ? "d9bd7e" : "395064", 2, 16)`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(list)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(list);`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Entry = s.Id, Part = kind }`；返回值紧邻使用处：`ArgumentSyntax: new() { Entry = s.Id, Part = kind }`
- `NationalSpire.PrivateMessages.Completed(NationalSpire.PrivateConversation)`；输入表达式：`PrivateMessages.Completed(c)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateMessages.Completed(c) == 0`
- `NationalSpire.PrivateOrnament.PrivateOrnament()`；输入表达式：`new PrivateOrnament { Kind = kind == "big" ? "archive" : "summary", MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`ArgumentSyntax: new PrivateOrnament { Kind = kind == "big" ? "archive" : "summary", MouseFilter = MouseFilterEnum.Ignore }`
- `NationalSpire.PrivateSummary.IsLatest(System.Collections.Generic.IEnumerable<NationalSpire.PrivateSummary>)`；输入表达式：`s.IsLatest(c.SmallSummaries.Concat(c.BigSummaries))`；返回值紧邻使用处：`ConditionalExpressionSyntax: s.IsLatest(c.SmallSummaries.Concat(c.BigSummaries)) ? "" : "删除这条总结可能导致永久丢失记忆。"`
- `NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Day(data, first.Day)`；返回值紧邻使用处：`InterpolationSyntax: {SeasonCalendar.Day(data, first.Day)}`
- `NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Day(data, last.Day)`；返回值紧邻使用处：`InterpolationSyntax: {SeasonCalendar.Day(data, last.Day)}`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _cancelDialog?.Invoke()`
- `System.Collections.Generic.IEnumerable<TSource>.AsEnumerable<TSource>()`；输入表达式：`summaries.AsEnumerable()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: summaries.AsEnumerable().Reverse`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`c.SmallSummaries.Concat(c.BigSummaries)`；返回值紧邻使用处：`ArgumentSyntax: c.SmallSummaries.Concat(c.BigSummaries)`
- `System.Collections.Generic.IEnumerable<TSource>.ElementAtOrDefault<TSource>(int)`；输入表达式：`c.Turns.ElementAtOrDefault(s.From)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Turns.ElementAtOrDefault(s.From)`
- `System.Collections.Generic.IEnumerable<TSource>.ElementAtOrDefault<TSource>(int)`；输入表达式：`c.Turns.ElementAtOrDefault(s.Through - 1)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Turns.ElementAtOrDefault(s.Through - 1)`
- `System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；输入表达式：`summaries.AsEnumerable().Reverse()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var s in summaries.AsEnumerable().Reverse())                  {                      var card = new PanelContainer(); var style = CareerVisuals.Box("101f2d", "3c5469", 3, 20); style.BorderWidthLeft = 3; card.AddThemeStyleboxOverride("panel", style); list.AddChild(card);                      var inner = new VBoxContainer(); inner.AddThemeConstantOverride("separation", 16); card.AddChild(inner);                      var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); inner.AddChild(row);                      var first = c.Turns.ElementAtOrDefault(s.From); var last = c.Turns.ElementAtOrDefault(s.Through - 1);                      string dates = first == null || last == null ? "已保存" : first.Day == last.Day                          ? $"第 {first.Season} 赛季 · 第 {SeasonCalendar.Day(data, first.Day)} 天" : first.Season == last.Season                          ? $"第 {first.Season} 赛季 · 第 {SeasonCalendar.Day(data, first.Day)}—{SeasonCalendar.Day(data, last.Day)} 天"                          : $"第 {first.Season} 赛季第 {SeasonCalendar.Day(data, first.Day)} 天—第 {last.Season} 赛季第 {SeasonCalendar.Day(data, last.Day)} 天";                      var label = PrivateLine(dates, 14, _gold); label.SizeFlagsHorizontal = SizeFlags.ExpandFill; row.AddChild(label);                      row.AddChild(PrivateButton("编辑", () => { _cancelDialog?.Invoke(); EditPrivateSummary(s, kind); }, 72));                      row.AddChild(PrivateButton("删除", () =>                      {                          string warning = s.IsLatest(c.SmallSummaries.Concat(c.BigSummaries)) ? "" : "删除这条总结可能导致永久丢失记忆。";                          _cancelDialog?.Invoke(); ShowCareerDialog("删除这条总结", warning, () => { PrivateCommand("dm-summary-delete", new() { Entry = s.Id, Part = kind }); return true; }, "确认删除");                      }, 72));                      inner.AddChild(PrivateText(s.Text, 18, _ink));                  }`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(360, 210 * summaries.Count)`；返回值紧邻使用处：`ConditionalExpressionSyntax: summaries.Count == 0 ? 165 : Math.Min(360, 210 * summaries.Count)`

**赋值（含属性/字段和局部值）：**

- `action.Disabled` = `c.SummaryStatus.Length > 0 || (kind == "big" ? c.SmallSummaries.Count < 2 : PrivateMessages.Completed(c) == 0)`
- `action.Text` = `kind == "big" ? "合并旧摘要" : "整理聊天"`
- `CustomMinimumSize` = `new(0, 155)`
- `CustomMinimumSize` = `new(380, 0)`
- `CustomMinimumSize` = `new(56, 62)`
- `Entry` = `s.Id`
- `explanation.Text` = `kind == "big" ? "将多条较早的聊天摘要整理成一条。" : "提取聊天中的经历、约定与重要细节。"`
- `Kind` = `kind == "big" ? "archive" : "summary"`
- `label.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Part` = `kind`
- `scroll.CustomMinimumSize` = `new(800, summaries.Count == 0 ? 165 : Math.Min(360, 210 * summaries.Count))`
- `selectedKind` = `kind`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `style.BorderWidthBottom` = `selected ? 3 : 1`
- `style.BorderWidthLeft` = `3`

<a id="symbol-477d5039b5b1"></a>

## `MemoryTab(string, int, string, string) — Button MemoryTab(string name, int count, string detail, string kind)`

来源：源码第 450 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateMemory()`](PrivateMemoryScreen.cs.md#symbol-942a4a496637)

**调用：** [`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.PrivateIgnoreMouse(Godot.Node)`](PrivateMemoryScreen.cs.md#symbol-780ecbf2f8bf)；[`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-84294149ff91)；[`Section(string)`](PrivateMemoryScreen.cs.md#symbol-55885a3fae26)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.Control()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.MarginContainer.MarginContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`int.ToString(string?)`；`NationalSpire.PrivateOrnament.PrivateOrnament()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.PrivateIgnoreMouse(Godot.Node)`；`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；`NationalSpire.PrivateOrnament.Kind`；`Section(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`inset.AddThemeConstantOverride("margin_" + edge, 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: inset.AddThemeConstantOverride("margin_" + edge, 18);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 15)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 15);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`text.AddThemeConstantOverride("separation", 9)`；返回值紧邻使用处：`ExpressionStatementSyntax: text.AddThemeConstantOverride("separation", 9);`
- `Godot.Control.Control()`；输入表达式：`new Control { CustomMinimumSize = new(42, 50) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Control { CustomMinimumSize = new(42, 50) }`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`inset.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: inset.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.MarginContainer.MarginContainer()`；输入表达式：`new MarginContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MarginContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`button.AddChild(inset)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddChild(inset);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`icon.AddChild(new PrivateOrnament { Kind = kind == "big" ? "archive" : "summary" })`；返回值紧邻使用处：`ExpressionStatementSyntax: icon.AddChild(new PrivateOrnament { Kind = kind == "big" ? "archive" : "summary" });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inset.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: inset.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(icon)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(icon);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(PrivateLine(count.ToString("00"), 30, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(PrivateLine(count.ToString("00"), 30, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(text)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(text);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`tabs.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: tabs.AddChild(button);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`text.AddChild(PrivateLine(detail, 14, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: text.AddChild(PrivateLine(detail, 14, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`text.AddChild(PrivateLine(name, 21, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: text.AddChild(PrivateLine(name, 21, _ink));`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(390, 108)`；返回值紧邻使用处：`AssignmentExpressionSyntax: button.CustomMinimumSize = new(390, 108)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(42, 50)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(42, 50)`
- `int.ToString(string?)`；输入表达式：`count.ToString("00")`；返回值紧邻使用处：`ArgumentSyntax: count.ToString("00")`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("", () => Section(kind), 390)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton("", () => Section(kind), 390)`
- `NationalSpire.CareerScreen.PrivateIgnoreMouse(Godot.Node)`；输入表达式：`PrivateIgnoreMouse(inset)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateIgnoreMouse(inset);`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine(count.ToString("00"), 30, _gold)`；返回值紧邻使用处：`ArgumentSyntax: PrivateLine(count.ToString("00"), 30, _gold)`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine(detail, 14, _muted)`；返回值紧邻使用处：`ArgumentSyntax: PrivateLine(detail, 14, _muted)`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine(name, 21, _ink)`；返回值紧邻使用处：`ArgumentSyntax: PrivateLine(name, 21, _ink)`
- `NationalSpire.PrivateOrnament.PrivateOrnament()`；输入表达式：`new PrivateOrnament { Kind = kind == "big" ? "archive" : "summary" }`；返回值紧邻使用处：`ArgumentSyntax: new PrivateOrnament { Kind = kind == "big" ? "archive" : "summary" }`
- `Section(string)`；输入表达式：`Section(kind)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Section(kind)`

**赋值（含属性/字段和局部值）：**

- `button.CustomMinimumSize` = `new(390, 108)`
- `CustomMinimumSize` = `new(42, 50)`
- `Kind` = `kind == "big" ? "archive" : "summary"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-92dafd8c57da"></a>

## `NationalSpire.CareerScreen.EditPrivateSummary(NationalSpire.PrivateSummary, string) — private void EditPrivateSummary(PrivateSummary summary, string kind)`

来源：源码第 470 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Section(string)`](PrivateMemoryScreen.cs.md#symbol-55885a3fae26)

**调用：** [`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.PrivateEditor(string, int, int)`](PrivateMemoryScreen.cs.md#symbol-1c1072fdb98b)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`](CareerDialog.cs.md#symbol-d832b736b02b)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；`string.IsNullOrWhiteSpace(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`；`NationalSpire.CareerScreen.PrivateEditor(string, int, int)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；`NationalSpire.PrivateMessageCommand.Entry`；`NationalSpire.PrivateMessageCommand.Part`；`NationalSpire.PrivateMessageCommand.Text`；`NationalSpire.PrivateSummary.Id`；`NationalSpire.PrivateSummary.Text`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(input)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(input);`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?)`；输入表达式：`PrivateCommand("dm-summary-edit", new() { Entry = summary.Id, Part = kind, Text = input.Text })`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateCommand("dm-summary-edit", new() { Entry = summary.Id, Part = kind, Text = input.Text });`
- `NationalSpire.CareerScreen.PrivateEditor(string, int, int)`；输入表达式：`PrivateEditor(summary.Text)`；返回值紧邻使用处：`AssignmentExpressionSyntax: input = PrivateEditor(summary.Text)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；输入表达式：`ShowCareerDialog(kind == "big" ? "编辑合并摘要" : "编辑聊天摘要", "", () =>          {              if (string.IsNullOrWhiteSpace(input!.Text)) return false;              PrivateCommand("dm-summary-edit", new() { Entry = summary.Id, Part = kind, Text = input.Text }); return true;          }, "保存", box => { input = PrivateEditor(summary.Text); box.AddChild(input); })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog(kind == "big" ? "编辑合并摘要" : "编辑聊天摘要", "", () =>          {              if (string.IsNullOrWhiteSpace(input!.Text)) return false;              PrivateCommand("dm-summary-edit", new() { Entry = summary.Id, Part = kind, Text = input.Text }); return true;          }, "保存", box => { input = PrivateEditor(summary.Text); box.AddChild(input); });`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Entry = summary.Id, Part = kind, Text = input.Text }`；返回值紧邻使用处：`ArgumentSyntax: new() { Entry = summary.Id, Part = kind, Text = input.Text }`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(input!.Text)`；返回值紧邻使用处：`IfStatementSyntax: if (string.IsNullOrWhiteSpace(input!.Text)) return false;`

**赋值（含属性/字段和局部值）：**

- `Entry` = `summary.Id`
- `input` = `PrivateEditor(summary.Text)`
- `Part` = `kind`
- `Text` = `input.Text`

<a id="symbol-00ef8b335cc8"></a>

## `NationalSpire.PrivateOrnament.Kind — public string Kind`

来源：源码第 484 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6b2a78e23b4b"></a>

## `NationalSpire.PrivateOrnament._Ready() — public override void _Ready()`

来源：源码第 485 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`

**赋值（含属性/字段和局部值）：**

- `Resized` += `QueueRedraw`

<a id="symbol-ddcb5a689cfe"></a>

## `NationalSpire.PrivateOrnament._Draw() — public override void _Draw()`

来源：源码第 486 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`C(float, float)`](PrivateMemoryScreen.cs.md#symbol-48e8d277709e)；[`Line(float, float, float, float, Godot.Color, float)`](PrivateMemoryScreen.cs.md#symbol-2434c9f8b2c0)；[`P(float, float)`](PrivateMemoryScreen.cs.md#symbol-f85c88b90c32)；`Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；`Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawPolyline(Godot.Vector2[], Godot.Color, float, bool)`；`Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；`Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float)`；`Godot.Color.Color(string)`；`Godot.Color.Darkened(float)`；`Godot.Color.Lightened(float)`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** `C(float, float)`；`Line(float, float, float, float, Godot.Color, float)`；`NationalSpire.CareerVisuals.Gold`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.PrivateOrnament.Kind`；`P(float, float)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `C(float, float)`；输入表达式：`C(14,12)`；返回值紧邻使用处：`ArgumentSyntax: C(14,12)`
- `C(float, float)`；输入表达式：`C(2,2)`；返回值紧邻使用处：`ExpressionElementSyntax: C(2,2)`
- `C(float, float)`；输入表达式：`C(2,22)`；返回值紧邻使用处：`ExpressionElementSyntax: C(2,22)`
- `C(float, float)`；输入表达式：`C(3,21)`；返回值紧邻使用处：`ExpressionElementSyntax: C(3,21)`
- `C(float, float)`；输入表达式：`C(3,3)`；返回值紧邻使用处：`ExpressionElementSyntax: C(3,3)`
- `C(float, float)`；输入表达式：`C(41,12)`；返回值紧邻使用处：`ArgumentSyntax: C(41,12)`
- `C(float, float)`；输入表达式：`C(53,7)`；返回值紧邻使用处：`ExpressionElementSyntax: C(53,7)`
- `C(float, float)`；输入表达式：`C(58,3)`；返回值紧邻使用处：`ExpressionElementSyntax: C(58,3)`
- `C(float, float)`；输入表达式：`C(62,2)`；返回值紧邻使用处：`ExpressionElementSyntax: C(62,2)`
- `C(float, float)`；输入表达式：`C(9,18)`；返回值紧邻使用处：`ExpressionElementSyntax: C(9,18)`
- `C(float, float)`；输入表达式：`C(9,7)`；返回值紧邻使用处：`ExpressionElementSyntax: C(9,7)`
- `Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；输入表达式：`DrawCircle(P(0,0),3*scale,gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawCircle(P(0,0),3*scale,gold);`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon([C(2,22),C(2,2),C(62,2),C(53,7),C(9,7),C(9,18)], gold.Darkened(.4f))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon([C(2,22),C(2,2),C(62,2),C(53,7),C(9,7),C(9,18)], gold.Darkened(.4f));`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon([new(Size.X - 6, y - 4), new(Size.X - 2, y), new(Size.X - 6, y + 4), new(Size.X - 10, y)], gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon([new(Size.X - 6, y - 4), new(Size.X - 2, y), new(Size.X - 6, y + 4), new(Size.X - 10, y)], gold);`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon([P(-18,-9),P(0,-19),P(18,-9),P(0,-13)],new Color("243c4c"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon([P(-18,-9),P(0,-19),P(18,-9),P(0,-13)],new Color("243c4c"));`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon([P(0,20),P(4,24),P(0,29),P(-4,24)],teal)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon([P(0,20),P(4,24),P(0,29),P(-4,24)],teal);`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon([P(7,17),P(12,22),P(7,29),P(2,22)],gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon([P(7,17),P(12,22),P(7,29),P(2,22)],gold);`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon([P(x,y+4),P(x+side*6,y-4),P(x+side*7,y),P(x,y+6)], i % 2 == 0 ? gold : gold.Darkened(.28f))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon([P(x,y+4),P(x+side*6,y-4),P(x+side*7,y),P(x,y+6)], i % 2 == 0 ? gold : gold.Darkened(.28f));`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon([rim[i], rim[next], inner[next], inner[i]], metal)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon([rim[i], rim[next], inner[next], inner[i]], metal);`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon(inner, new Color("0b1927"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon(inner, new Color("0b1927"));`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(C(14,12),C(41,12),dim,1,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(C(14,12),C(41,12),dim,1,true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(new(0, y), new(92, y), gold, 2, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(new(0, y), new(92, y), gold, 2, true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(new(0, y), new(Size.X, y), dim, 1, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(new(0, y), new(Size.X, y), dim, 1, true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(new(68,-23),new(Size.X-68,-23),new Color("526b7b"),1,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(new(68,-23),new(Size.X-68,-23),new Color("526b7b"),1,true);`
- `Godot.CanvasItem.DrawPolyline(Godot.Vector2[], Godot.Color, float, bool)`；输入表达式：`DrawPolyline(inner.Append(inner[0]).ToArray(), new Color("536470"), 1, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline(inner.Append(inner[0]).ToArray(), new Color("536470"), 1, true);`
- `Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；输入表达式：`DrawPolyline([C(3,21),C(3,3),C(58,3)], gold.Lightened(.25f), 1.5f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline([C(3,21),C(3,3),C(58,3)], gold.Lightened(.25f), 1.5f, true);`
- `Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；输入表达式：`DrawPolyline([P(-19,-7),P(-6,-20),P(9,-5),P(-4,8),P(-19,-7)],gold,1.8f,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline([P(-19,-7),P(-6,-20),P(9,-5),P(-4,8),P(-19,-7)],gold,1.8f,true);`
- `Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；输入表达式：`DrawPolyline([P(-8,6),P(5,-7),P(20,8),P(7,21),P(-8,6)],teal,1.8f,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline([P(-8,6),P(5,-7),P(20,8),P(7,21),P(-8,6)],teal,1.8f,true);`
- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；输入表达式：`DrawRect(paper,new Color("0e1d2b"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawRect(paper,new Color("0e1d2b"));`
- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float)`；输入表达式：`DrawRect(paper,gold,false,1.4f)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawRect(paper,gold,false,1.4f);`
- `Godot.Color.Color(string)`；输入表达式：`new Color("0b1927")`；返回值紧邻使用处：`ArgumentSyntax: new Color("0b1927")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("0e1d2b")`；返回值紧邻使用处：`ArgumentSyntax: new Color("0e1d2b")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("243c4c")`；返回值紧邻使用处：`ArgumentSyntax: new Color("243c4c")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("526b7b")`；返回值紧邻使用处：`ArgumentSyntax: new Color("526b7b")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("536470")`；返回值紧邻使用处：`ArgumentSyntax: new Color("536470")`
- `Godot.Color.Color(string)`；输入表达式：`new("53687a")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new("53687a")`
- `Godot.Color.Darkened(float)`；输入表达式：`gold.Darkened(.28f)`；返回值紧邻使用处：`ConditionalExpressionSyntax: i % 2 == 0 ? gold : gold.Darkened(.28f)`
- `Godot.Color.Darkened(float)`；输入表达式：`gold.Darkened(.45f)`；返回值紧邻使用处：`ConditionalExpressionSyntax: i is 2 or 3 ? gold.Darkened(.45f) : gold`
- `Godot.Color.Darkened(float)`；输入表达式：`gold.Darkened(.4f)`；返回值紧邻使用处：`ArgumentSyntax: gold.Darkened(.4f)`
- `Godot.Color.Lightened(float)`；输入表达式：`gold.Lightened(.25f)`；返回值紧邻使用处：`ArgumentSyntax: gold.Lightened(.25f)`
- `Godot.Color.Lightened(float)`；输入表达式：`gold.Lightened(.35f)`；返回值紧邻使用处：`ConditionalExpressionSyntax: i is 0 or 5 ? gold.Lightened(.35f) : i is 2 or 3 ? gold.Darkened(.45f) : gold`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(P(-23,-18),new Vector2(39,44)*scale)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Rect2(P(-23,-18),new Vector2(39,44)*scale)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(39,44)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(39,44)*scale`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, y)`；返回值紧邻使用处：`ArgumentSyntax: new(0, y)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(68,-23)`；返回值紧邻使用处：`ArgumentSyntax: new(68,-23)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(92, y)`；返回值紧邻使用处：`ArgumentSyntax: new(92, y)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(Size.X - 10, y)`；返回值紧邻使用处：`ExpressionElementSyntax: new(Size.X - 10, y)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(Size.X - 2, y)`；返回值紧邻使用处：`ExpressionElementSyntax: new(Size.X - 2, y)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(Size.X - 6, y - 4)`；返回值紧邻使用处：`ExpressionElementSyntax: new(Size.X - 6, y - 4)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(Size.X - 6, y + 4)`；返回值紧邻使用处：`ExpressionElementSyntax: new(Size.X - 6, y + 4)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(Size.X-68,-23)`；返回值紧邻使用处：`ArgumentSyntax: new(Size.X-68,-23)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(Size.X, y)`；返回值紧邻使用处：`ArgumentSyntax: new(Size.X, y)`
- `Line(float, float, float, float, Godot.Color, float)`；输入表达式：`Line(-14,-27,24,-27,dim)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(-14,-27,24,-27,dim);`
- `Line(float, float, float, float, Godot.Color, float)`；输入表达式：`Line(-14,-7,7,-7,teal,2)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(-14,-7,7,-7,teal,2);`
- `Line(float, float, float, float, Godot.Color, float)`；输入表达式：`Line(-14,0,7,0,dim)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(-14,0,7,0,dim);`
- `Line(float, float, float, float, Godot.Color, float)`；输入表达式：`Line(-14,7,2,7,dim)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(-14,7,2,7,dim);`
- `Line(float, float, float, float, Godot.Color, float)`；输入表达式：`Line(-18,-23,20,-23,gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(-18,-23,20,-23,gold);`
- `Line(float, float, float, float, Godot.Color, float)`；输入表达式：`Line(20,-23,20,19,gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(20,-23,20,19,gold);`
- `Line(float, float, float, float, Godot.Color, float)`；输入表达式：`Line(24,-27,24,15,dim)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(24,-27,24,15,dim);`
- `P(float, float)`；输入表达式：`P(-18,-9)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-18,-9)`
- `P(float, float)`；输入表达式：`P(-19,-7)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-19,-7)`
- `P(float, float)`；输入表达式：`P(-20,12)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-20,12)`
- `P(float, float)`；输入表达式：`P(-22,-11)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-22,-11)`
- `P(float, float)`；输入表达式：`P(-23,-18)`；返回值紧邻使用处：`ArgumentSyntax: P(-23,-18)`
- `P(float, float)`；输入表达式：`P(-24,15)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-24,15)`
- `P(float, float)`；输入表达式：`P(-26,-13)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-26,-13)`
- `P(float, float)`；输入表达式：`P(-4,24)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-4,24)`
- `P(float, float)`；输入表达式：`P(-4,8)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-4,8)`
- `P(float, float)`；输入表达式：`P(-6,-20)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-6,-20)`
- `P(float, float)`；输入表达式：`P(-8,6)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-8,6)`
- `P(float, float)`；输入表达式：`P(0,-13)`；返回值紧邻使用处：`ExpressionElementSyntax: P(0,-13)`
- `P(float, float)`；输入表达式：`P(0,-19)`；返回值紧邻使用处：`ExpressionElementSyntax: P(0,-19)`
- `P(float, float)`；输入表达式：`P(0,-22)`；返回值紧邻使用处：`ExpressionElementSyntax: P(0,-22)`
- `P(float, float)`；输入表达式：`P(0,-26)`；返回值紧邻使用处：`ExpressionElementSyntax: P(0,-26)`
- `P(float, float)`；输入表达式：`P(0,0)`；返回值紧邻使用处：`ArgumentSyntax: P(0,0)`
- `P(float, float)`；输入表达式：`P(0,20)`；返回值紧邻使用处：`ExpressionElementSyntax: P(0,20)`
- `P(float, float)`；输入表达式：`P(0,23)`；返回值紧邻使用处：`ExpressionElementSyntax: P(0,23)`
- `P(float, float)`；输入表达式：`P(0,27)`；返回值紧邻使用处：`ExpressionElementSyntax: P(0,27)`
- `P(float, float)`；输入表达式：`P(0,29)`；返回值紧邻使用处：`ExpressionElementSyntax: P(0,29)`
- `P(float, float)`；输入表达式：`P(12,22)`；返回值紧邻使用处：`ExpressionElementSyntax: P(12,22)`
- `P(float, float)`；输入表达式：`P(18,-9)`；返回值紧邻使用处：`ExpressionElementSyntax: P(18,-9)`
- `P(float, float)`；输入表达式：`P(2,22)`；返回值紧邻使用处：`ExpressionElementSyntax: P(2,22)`
- `P(float, float)`；输入表达式：`P(20,12)`；返回值紧邻使用处：`ExpressionElementSyntax: P(20,12)`
- `P(float, float)`；输入表达式：`P(20,8)`；返回值紧邻使用处：`ExpressionElementSyntax: P(20,8)`
- `P(float, float)`；输入表达式：`P(22,-11)`；返回值紧邻使用处：`ExpressionElementSyntax: P(22,-11)`
- `P(float, float)`；输入表达式：`P(24,15)`；返回值紧邻使用处：`ExpressionElementSyntax: P(24,15)`
- `P(float, float)`；输入表达式：`P(26,-13)`；返回值紧邻使用处：`ExpressionElementSyntax: P(26,-13)`
- `P(float, float)`；输入表达式：`P(4,24)`；返回值紧邻使用处：`ExpressionElementSyntax: P(4,24)`
- `P(float, float)`；输入表达式：`P(5,-7)`；返回值紧邻使用处：`ExpressionElementSyntax: P(5,-7)`
- `P(float, float)`；输入表达式：`P(7,17)`；返回值紧邻使用处：`ExpressionElementSyntax: P(7,17)`
- `P(float, float)`；输入表达式：`P(7,21)`；返回值紧邻使用处：`ExpressionElementSyntax: P(7,21)`
- `P(float, float)`；输入表达式：`P(7,29)`；返回值紧邻使用处：`ExpressionElementSyntax: P(7,29)`
- `P(float, float)`；输入表达式：`P(9,-5)`；返回值紧邻使用处：`ExpressionElementSyntax: P(9,-5)`
- `P(float, float)`；输入表达式：`P(x,y+4)`；返回值紧邻使用处：`ExpressionElementSyntax: P(x,y+4)`
- `P(float, float)`；输入表达式：`P(x,y+6)`；返回值紧邻使用处：`ExpressionElementSyntax: P(x,y+6)`
- `P(float, float)`；输入表达式：`P(x+side*6,y-4)`；返回值紧邻使用处：`ExpressionElementSyntax: P(x+side*6,y-4)`
- `P(float, float)`；输入表达式：`P(x+side*7,y)`；返回值紧邻使用处：`ExpressionElementSyntax: P(x+side*7,y)`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`inner.Append(inner[0])`；返回值紧邻使用处：`MemberAccessExpressionSyntax: inner.Append(inner[0]).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`inner.Append(inner[0]).ToArray()`；返回值紧邻使用处：`ArgumentSyntax: inner.Append(inner[0]).ToArray()`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(Size.X, Size.Y)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Min(Size.X, Size.Y) / 64`

**赋值（含属性/字段和局部值）：**

- `side` += `2`

<a id="symbol-48e8d277709e"></a>

## `C(float, float) — Vector2 C(float x, float y)`

来源：源码第 495 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateOrnament._Draw()`](PrivateMemoryScreen.cs.md#symbol-ddcb5a689cfe)

**调用：** `Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(right ? Size.X + 24 - x : x - 24, bottom ? Size.Y + 24 - y : y - 24)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new(right ? Size.X + 24 - x : x - 24, bottom ? Size.Y + 24 - y : y - 24)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f85c88b90c32"></a>

## `P(float, float) — Vector2 P(float x, float y)`

来源：源码第 512 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Line(float, float, float, float, Godot.Color, float)`](PrivateMemoryScreen.cs.md#symbol-2434c9f8b2c0)；[`NationalSpire.PrivateOrnament._Draw()`](PrivateMemoryScreen.cs.md#symbol-ddcb5a689cfe)

**调用：** `Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(x, y)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(x, y) * scale`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2434c9f8b2c0"></a>

## `Line(float, float, float, float, Godot.Color, float) — void Line(float x1, float y1, float x2, float y2, Color c, float width = 1.4f)`

来源：源码第 513 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateOrnament._Draw()`](PrivateMemoryScreen.cs.md#symbol-ddcb5a689cfe)

**调用：** [`P(float, float)`](PrivateMemoryScreen.cs.md#symbol-f85c88b90c32)；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`

**字段、属性、事件及方法组引用：** `P(float, float)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(P(x1, y1), P(x2, y2), c, width, true)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => DrawLine(P(x1, y1), P(x2, y2), c, width, true)`
- `P(float, float)`；输入表达式：`P(x1, y1)`；返回值紧邻使用处：`ArgumentSyntax: P(x1, y1)`
- `P(float, float)`；输入表达式：`P(x2, y2)`；返回值紧邻使用处：`ArgumentSyntax: P(x2, y2)`

**赋值（含属性/字段和局部值）：**
<a id="symbol-f8d8c06c69f7"></a>

## `NationalSpire.PrivateIdentityLayout._GetMinimumSize() — public override Vector2 _GetMinimumSize()`

来源：源码第 555 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(80, 72)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new(80, 72)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5d5ce9e5fcb2"></a>

## `NationalSpire.PrivateIdentityLayout._Notification(int) — public override void _Notification(int what)`

来源：源码第 556 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Container.FitChildInRect(Godot.Control, Godot.Rect2)`；`Godot.Control.GetCombinedMinimumSize()`；`Godot.Control.GetThemeFont(Godot.StringName, Godot.StringName)`；`Godot.Control.GetThemeFontSize(Godot.StringName, Godot.StringName)`；`Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；`Godot.Node.GetChild<T>(int, bool)`；`Godot.Node.GetChildCount(bool)`；`Godot.Node.GetChildren(bool)`；`Godot.Rect2.Rect2(float, float, float, float)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.IEnumerable.OfType<TResult>()`；`System.Math.Max(float, float)`；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Container.FitChildInRect(Godot.Control, Godot.Rect2)`；输入表达式：`FitChildInRect(id, new(0, 0, textWidth, height))`；返回值紧邻使用处：`ExpressionStatementSyntax: FitChildInRect(id, new(0, 0, textWidth, height));`
- `Godot.Container.FitChildInRect(Godot.Control, Godot.Rect2)`；输入表达式：`FitChildInRect(mood, new(textWidth + 20, (Size.Y - height) / 2, height, height))`；返回值紧邻使用处：`ExpressionStatementSyntax: FitChildInRect(mood, new(textWidth + 20, (Size.Y - height) / 2, height, height));`
- `Godot.Container.FitChildInRect(Godot.Control, Godot.Rect2)`；输入表达式：`FitChildInRect(role, new(0, (height + Size.Y - roleHeight) / 2, textWidth, roleHeight))`；返回值紧邻使用处：`ExpressionStatementSyntax: FitChildInRect(role, new(0, (height + Size.Y - roleHeight) / 2, textWidth, roleHeight));`
- `Godot.Control.GetCombinedMinimumSize()`；输入表达式：`id.GetCombinedMinimumSize()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: id.GetCombinedMinimumSize().Y`
- `Godot.Control.GetCombinedMinimumSize()`；输入表达式：`role.GetCombinedMinimumSize()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: role.GetCombinedMinimumSize().Y`
- `Godot.Control.GetThemeFont(Godot.StringName, Godot.StringName)`；输入表达式：`id.GetThemeFont("font")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: id.GetThemeFont("font").GetStringSize`
- `Godot.Control.GetThemeFont(Godot.StringName, Godot.StringName)`；输入表达式：`role.GetThemeFont("font")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: role.GetThemeFont("font").GetStringSize`
- `Godot.Control.GetThemeFontSize(Godot.StringName, Godot.StringName)`；输入表达式：`id.GetThemeFontSize("font_size")`；返回值紧邻使用处：`ArgumentSyntax: fontSize: id.GetThemeFontSize("font_size")`
- `Godot.Control.GetThemeFontSize(Godot.StringName, Godot.StringName)`；输入表达式：`role.GetThemeFontSize("font_size")`；返回值紧邻使用处：`ArgumentSyntax: fontSize: role.GetThemeFontSize("font_size")`
- `Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；输入表达式：`id.GetThemeFont("font").GetStringSize(id.Text, fontSize: id.GetThemeFontSize("font_size"))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: id.GetThemeFont("font").GetStringSize(id.Text, fontSize: id.GetThemeFontSize("font_size")).X`
- `Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；输入表达式：`role.GetThemeFont("font").GetStringSize(role.Text, fontSize: role.GetThemeFontSize("font_size"))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: role.GetThemeFont("font").GetStringSize(role.Text, fontSize: role.GetThemeFontSize("font_size")).X`
- `Godot.Node.GetChild<T>(int, bool)`；输入表达式：`GetChild<Button>(0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GetChild<Button>(0)`
- `Godot.Node.GetChild<T>(int, bool)`；输入表达式：`GetChild<Label>(1)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GetChild<Label>(1)`
- `Godot.Node.GetChildCount(bool)`；输入表达式：`GetChildCount()`；返回值紧邻使用处：`BinaryExpressionSyntax: GetChildCount() < 2`
- `Godot.Node.GetChildren(bool)`；输入表达式：`GetChildren()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetChildren().OfType<PrivateMoodButton>`
- `Godot.Rect2.Rect2(float, float, float, float)`；输入表达式：`new(0, (height + Size.Y - roleHeight) / 2, textWidth, roleHeight)`；返回值紧邻使用处：`ArgumentSyntax: new(0, (height + Size.Y - roleHeight) / 2, textWidth, roleHeight)`
- `Godot.Rect2.Rect2(float, float, float, float)`；输入表达式：`new(0, 0, textWidth, height)`；返回值紧邻使用处：`ArgumentSyntax: new(0, 0, textWidth, height)`
- `Godot.Rect2.Rect2(float, float, float, float)`；输入表达式：`new(textWidth + 20, (Size.Y - height) / 2, height, height)`；返回值紧邻使用处：`ArgumentSyntax: new(textWidth + 20, (Size.Y - height) / 2, height, height)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`GetChildren().OfType<PrivateMoodButton>().FirstOrDefault()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GetChildren().OfType<PrivateMoodButton>().FirstOrDefault()`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`GetChildren().OfType<PrivateMoodButton>()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetChildren().OfType<PrivateMoodButton>().FirstOrDefault`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(0, Size.X - height - 20)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Max(0, Size.X - height - 20)`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(id.GetThemeFont("font").GetStringSize(id.Text, fontSize: id.GetThemeFontSize("font_size")).X, role.GetThemeFont("font").GetStringSize(role.Text, fontSize: role.GetThemeFontSize("font_size")).X)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(id.GetThemeFont("font").GetStringSize(id.Text, fontSize: id.GetThemeFontSize("font_size")).X, role.GetThemeFont("font").GetStringSize(role.Text, fontSize: role.GetThemeFontSize("font_size")).X)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(width, Math.Max(id.GetThemeFont("font").GetStringSize(id.Text, fontSize: id.GetThemeFontSize("font_size")).X, role.GetThemeFont("font").GetStringSize(role.Text, fontSize: role.GetThemeFontSize("font_size")).X))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(width, Math.Max(id.GetThemeFont("font").GetStringSize(id.Text, fontSize: id.GetThemeFontSize("font_size")).X, role.GetThemeFont("font").GetStringSize(role.Text, fontSize: role.GetThemeFontSize("font_size")).X))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-634670e590f1"></a>

## `NationalSpire.PrivateMoodButton.Elevated — public bool Elevated`

来源：源码第 574 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-43448ac9d3a0"></a>

## `NationalSpire.PrivateMoodButton._Ready() — public override void _Ready()`

来源：源码第 575 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Color.Color(float, float, float, float)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.PrivateMoodButton.Elevated`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(1.3f, 1.3f, 1.3f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: SelfModulate = new Color(1.3f, 1.3f, 1.3f)`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`AddThemeStyleboxOverride("focus", new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: AddThemeStyleboxOverride("focus", new StyleBoxEmpty());`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`AddThemeStyleboxOverride(state, CareerVisuals.Box(fill, edge, 5, 0))`；返回值紧邻使用处：`ExpressionStatementSyntax: AddThemeStyleboxOverride(state, CareerVisuals.Box(fill, edge, 5, 0));`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty()`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxEmpty()`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box(fill, edge, 5, 0)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box(fill, edge, 5, 0)`

**赋值（含属性/字段和局部值）：**

- `MouseDefaultCursorShape` = `CursorShape.PointingHand`
- `MouseEntered` += `() => SelfModulate = new Color(1.3f, 1.3f, 1.3f)`
- `MouseExited` += `() => SelfModulate = Colors.White`
- `SelfModulate` = `Colors.White`
- `SelfModulate` = `new Color(1.3f, 1.3f, 1.3f)`
- `ToggleMode` = `true`

<a id="symbol-b4e595448b32"></a>

## `NationalSpire.PrivateMoodButton._Draw() — public override void _Draw()`

来源：源码第 584 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；`Godot.Color.Color(string)`；[`Point(float, float)`](PrivateMemoryScreen.cs.md#symbol-bdb6dddd654e)；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateMoodButton.Elevated`；`Point(float, float)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon([Point(0, .28f), Point(.26f, .02f), Point(.10f, .02f), Point(.10f, -.26f), Point(-.10f, -.26f), Point(-.10f, .02f), Point(-.26f, .02f)], new Color(Elevated ? "98dea6" : "edb8b8"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon([Point(0, .28f), Point(.26f, .02f), Point(.10f, .02f), Point(.10f, -.26f), Point(-.10f, -.26f), Point(-.10f, .02f), Point(-.26f, .02f)], new Color(Elevated ? "98dea6" : "edb8b8"));`
- `Godot.Color.Color(string)`；输入表达式：`new Color(Elevated ? "98dea6" : "edb8b8")`；返回值紧邻使用处：`ArgumentSyntax: new Color(Elevated ? "98dea6" : "edb8b8")`
- `Point(float, float)`；输入表达式：`Point(-.10f, -.26f)`；返回值紧邻使用处：`ExpressionElementSyntax: Point(-.10f, -.26f)`
- `Point(float, float)`；输入表达式：`Point(-.10f, .02f)`；返回值紧邻使用处：`ExpressionElementSyntax: Point(-.10f, .02f)`
- `Point(float, float)`；输入表达式：`Point(-.26f, .02f)`；返回值紧邻使用处：`ExpressionElementSyntax: Point(-.26f, .02f)`
- `Point(float, float)`；输入表达式：`Point(.10f, -.26f)`；返回值紧邻使用处：`ExpressionElementSyntax: Point(.10f, -.26f)`
- `Point(float, float)`；输入表达式：`Point(.10f, .02f)`；返回值紧邻使用处：`ExpressionElementSyntax: Point(.10f, .02f)`
- `Point(float, float)`；输入表达式：`Point(.26f, .02f)`；返回值紧邻使用处：`ExpressionElementSyntax: Point(.26f, .02f)`
- `Point(float, float)`；输入表达式：`Point(0, .28f)`；返回值紧邻使用处：`ExpressionElementSyntax: Point(0, .28f)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(Size.X, Size.Y)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(Size.X, Size.Y)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-bdb6dddd654e"></a>

## `Point(float, float) — Vector2 Point(float x, float y)`

来源：源码第 588 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMoodButton._Draw()`](PrivateMemoryScreen.cs.md#symbol-b4e595448b32)

**调用：** `Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(x, direction * y)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(x, direction * y) * side`

**赋值（含属性/字段和局部值）：**
