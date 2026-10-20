# ProfileScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`7C5CC5760FEF060F3FF501F9CA7AAFBFE6E3901B4779E81A18E77A71AD5EADA3`。来源：[源码](../../ProfileScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
private bool _showGameArchive;
```

<a id="symbol-70ada758a361"></a>

## `NationalSpire.CareerScreen.ProfileActions() — private static HFlowContainer ProfileActions()`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PersonProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](ProfileScreen.cs.md#symbol-2d802d5a07b9)；[`NationalSpire.CareerScreen.PlayerProfile(NationalSpire.CareerData)`](ProfileScreen.cs.md#symbol-ce70d1ef24b8)；[`NationalSpire.CareerScreen.Profiles(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-70740adc3b48)

**调用：** `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HFlowContainer.HFlowContainer()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("h_separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("h_separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("v_separation", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("v_separation", 14);`
- `Godot.HFlowContainer.HFlowContainer()`；输入表达式：`new HFlowContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HFlowContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`

**赋值（含属性/字段和局部值）：**

- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-078e0ffb0ebe"></a>

## `NationalSpire.CareerScreen.ProfileSection(string) — private VBoxContainer ProfileSection(string title)`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PersonProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](ProfileScreen.cs.md#symbol-2d802d5a07b9)；[`NationalSpire.CareerScreen.PlayerProfile(NationalSpire.CareerData)`](ProfileScreen.cs.md#symbol-ce70d1ef24b8)；[`NationalSpire.CareerScreen.PrivateProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](PrivateMessageScreen.cs.md#symbol-8e28d3a34860)；[`NationalSpire.CareerScreen.ShowArchive()`](CareerScreen.cs.md#symbol-ce008839cea8)

**调用：** [`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation", 20)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation", 20);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("142332", "314958", 8, 24))`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("142332", "314958", 8, 24));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(title, 22, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(title, 22, _gold));`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(card)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(card)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(title, 22, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(title, 22, _gold)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("142332", "314958", 8, 24)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("142332", "314958", 8, 24)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-578cf06bda89"></a>

## `NationalSpire.CareerScreen.ProfileFields(Godot.VBoxContainer, params (string Label, string Value)[]) — private void ProfileFields(VBoxContainer box, params (string Label, string Value)[] fields)`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PersonProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](ProfileScreen.cs.md#symbol-2d802d5a07b9)；[`NationalSpire.CareerScreen.PlayerProfile(NationalSpire.CareerData)`](ProfileScreen.cs.md#symbol-ce70d1ef24b8)；[`NationalSpire.CareerScreen.ShowArchive()`](CareerScreen.cs.md#symbol-ce008839cea8)

**调用：** [`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.GridContainer.GridContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `(string Label, string Value).Label`；`(string Label, string Value).Value`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`column.AddThemeConstantOverride("separation", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddThemeConstantOverride("separation", 8);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("h_separation", 32)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("h_separation", 32);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("v_separation", 22)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("v_separation", 22);`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer { Columns = fields.Count(f => f.Value.Length > 0) == 1 ? 1 : 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GridContainer { Columns = fields.Count(f => f.Value.Length > 0) == 1 ? 1 : 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(grid)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(grid);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`column.AddChild(Text(field.Label, 14, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddChild(Text(field.Label, 14, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`column.AddChild(Text(field.Value, 18, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddChild(Text(field.Value, 18, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`grid.AddChild(column)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddChild(column);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(field.Label, 14, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(field.Label, 14, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(field.Value, 18, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(field.Value, 18, _ink)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`fields.Count(f => f.Value.Length > 0)`；返回值紧邻使用处：`BinaryExpressionSyntax: fields.Count(f => f.Value.Length > 0) == 1`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`fields.Where(f => f.Value.Length > 0)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var field in fields.Where(f => f.Value.Length > 0))          {              var column = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill };              column.AddThemeConstantOverride("separation", 8); grid.AddChild(column);              column.AddChild(Text(field.Label, 14, _muted));              column.AddChild(Text(field.Value, 18, _ink));          }`

**赋值（含属性/字段和局部值）：**

- `Columns` = `fields.Count(f => f.Value.Length > 0) == 1 ? 1 : 2`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-faa45696cdee"></a>

## `NationalSpire.CareerScreen.ProfileStats(params (string Label, string Value)[]) — private void ProfileStats(params (string Label, string Value)[] fields)`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PersonProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](ProfileScreen.cs.md#symbol-2d802d5a07b9)；[`NationalSpire.CareerScreen.PlayerProfile(NationalSpire.CareerData)`](ProfileScreen.cs.md#symbol-ce70d1ef24b8)

**调用：** [`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `(string Label, string Value).Label`；`(string Label, string Value).Value`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 18);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { Name = "ProfileStats", SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { Name = "ProfileStats", SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(field.Label, 14, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(field.Label, 14, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(field.Value, 24, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(field.Value, 24, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(panel);`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(panel)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(panel)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(field.Label, 14, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(field.Label, 14, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(field.Value, 24, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(field.Value, 24, _ink)`

**赋值（含属性/字段和局部值）：**

- `Name` = `"ProfileStats"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-ce70d1ef24b8"></a>

## `NationalSpire.CareerScreen.PlayerProfile(NationalSpire.CareerData) — private void PlayerProfile(CareerData data)`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Profiles(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-70740adc3b48)

**调用：** [`NationalSpire.CareerAvatars.MainCharacter(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-b9f8261f2cf2)；[`NationalSpire.CareerScreen.AvatarWardrobe(NationalSpire.CareerData, Godot.VBoxContainer)`](CareerAvatars.cs.md#symbol-a00951e0b13d)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.OpenAvatarSettings(NationalSpire.CareerData, NationalSpire.PlayerAvatar?, System.Action<NationalSpire.PlayerAvatar>?, string, NationalSpire.AvatarArt?)`](AvatarScreen.cs.md#symbol-368e97fdd27f)；[`NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`](CharacterCardScreen.cs.md#symbol-a498f622bb3e)；[`NationalSpire.CareerScreen.OpenPortraitDesigner(NationalSpire.CareerData, string)`](PortraitDesignScreen.cs.md#symbol-3bb5119a73ca)；[`NationalSpire.CareerScreen.PlayerBanner(NationalSpire.CareerData, string)`](BroadcastVisuals.cs.md#symbol-936e32073293)；[`NationalSpire.CareerScreen.ProfileActions()`](ProfileScreen.cs.md#symbol-70ada758a361)；[`NationalSpire.CareerScreen.ProfileEntry(Godot.VBoxContainer, string, string, Godot.Color)`](ProfileScreen.cs.md#symbol-69bc6ca2a621)；[`NationalSpire.CareerScreen.ProfileFields(Godot.VBoxContainer, params (string Label, string Value)[])`](ProfileScreen.cs.md#symbol-578cf06bda89)；[`NationalSpire.CareerScreen.ProfileSection(string)`](ProfileScreen.cs.md#symbol-078e0ffb0ebe)；[`NationalSpire.CareerScreen.ProfileStats(params (string Label, string Value)[])`](ProfileScreen.cs.md#symbol-faa45696cdee)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.ShowArchive()`](CareerScreen.cs.md#symbol-ce008839cea8)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CircuitLedger.Points(NationalSpire.CareerData, string)`](CircuitLedger.cs.md#symbol-73238d706495)；[`NationalSpire.CircuitLedger.PublicStanding(NationalSpire.CareerData, string, int)`](CircuitLedger.cs.md#symbol-08cb65a2d635)；[`NationalSpire.ClubCoaching.PlayerCoach(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-26fb5cc468c4)；[`NationalSpire.ClubCoaching.PlayerFeatures(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-e30d7b812432)；[`NationalSpire.ClubCoaching.PlayerReserve(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-c5c2fb20bef5)；[`NationalSpire.EsportsWorld.LicenseName(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-921c23662473)；[`NationalSpire.GameBridge.Characters()`](GameBridge.cs.md#symbol-1233494dda40)；[`NationalSpire.MatchRules.AscensionLabel(NationalSpire.CareerResult)`](MatchRules.cs.md#symbol-a28dd7ef0ece)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`；`int.ToString()`；`int.ToString(string?)`；`MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerAvatars.MainCharacter(NationalSpire.CareerData, string)`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Draws`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Fans`；`NationalSpire.CareerData.Losses`；`NationalSpire.CareerData.PlayerCard`；`NationalSpire.CareerData.PlayerGender`；`NationalSpire.CareerData.PlayerIntroduction`；`NationalSpire.CareerData.PlayerIntroductionDay`；`NationalSpire.CareerData.Results`；`NationalSpire.CareerData.Wins`；`NationalSpire.CareerHonor.Season`；`NationalSpire.CareerHonor.Title`；`NationalSpire.CareerPerson.Biography`；`NationalSpire.CareerPerson.Character`；`NationalSpire.CareerPerson.Name`；`NationalSpire.CareerPerson.Role`；`NationalSpire.CareerPerson.Style`；`NationalSpire.CareerResult.Event`；`NationalSpire.CareerResult.Floor`；`NationalSpire.CareerResult.Outcome`；`NationalSpire.CareerScreen._choosingFrame`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._showGameArchive`；`NationalSpire.CareerScreen.AvatarWardrobe(NationalSpire.CareerData, Godot.VBoxContainer)`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.OpenAvatarSettings(NationalSpire.CareerData, NationalSpire.PlayerAvatar?, System.Action<NationalSpire.PlayerAvatar>?, string, NationalSpire.AvatarArt?)`；`NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`；`NationalSpire.CareerScreen.OpenPortraitDesigner(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen.PlayerBanner(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen.ProfileActions()`；`NationalSpire.CareerScreen.ProfileEntry(Godot.VBoxContainer, string, string, Godot.Color)`；`NationalSpire.CareerScreen.ProfileFields(Godot.VBoxContainer, params (string Label, string Value)[])`；`NationalSpire.CareerScreen.ProfileSection(string)`；`NationalSpire.CareerScreen.ProfileStats(params (string Label, string Value)[])`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.ShowArchive()`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.CircuitLedger.Points(NationalSpire.CareerData, string)`；`NationalSpire.CircuitLedger.PublicStanding(NationalSpire.CareerData, string, int)`；`NationalSpire.ClubCoaching.PlayerCoach(NationalSpire.CareerData)`；`NationalSpire.ClubCoaching.PlayerFeatures(NationalSpire.CareerData)`；`NationalSpire.ClubCoaching.PlayerReserve(NationalSpire.CareerData)`；`NationalSpire.EsportsCareer.Honors`；`NationalSpire.EsportsCareer.WinStreak`；`NationalSpire.EsportsWorld.LicenseName(NationalSpire.CareerData)`；`NationalSpire.GameBridge.Characters()`；`NationalSpire.MatchRules.AscensionLabel(NationalSpire.CareerResult)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`entry.AddThemeConstantOverride("separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: entry.AddThemeConstantOverride("separation", 10);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Button(_showGameArchive ? "收起游戏总档案" : "查看游戏总档案", () => { _showGameArchive = !_showGameArchive; Render(); }, 220))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Button(_showGameArchive ? "收起游戏总档案" : "查看游戏总档案", () => { _showGameArchive = !_showGameArchive; Render(); }, 220));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(PlayerBanner(data, "player"))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(PlayerBanner(data, "player"));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text((ClubCoaching.PlayerReserve(data) ? "俱乐部轮换" : "俱乐部首发") + (ClubCoaching.PlayerCoach(data) ? " · 兼任教练" : ""), 18, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text((ClubCoaching.PlayerReserve(data) ? "俱乐部轮换" : "俱乐部首发") + (ClubCoaching.PlayerCoach(data) ? " · 兼任教练" : ""), 18, CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(toolbar)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(toolbar);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`entry.AddChild(Text($"{MatchRules.AscensionLabel(result)} · 第 {result.Floor} 层", 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: entry.AddChild(Text($"{MatchRules.AscensionLabel(result)} · 第 {result.Floor} 层", 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`honors.AddChild(Text("暂无荣誉记录", 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: honors.AddChild(Text("暂无荣誉记录", 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`honors.AddChild(Text(standing, 17, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: honors.AddChild(Text(standing, 17, CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`ProfileSection("人物介绍").AddChild(Text(card.Biography, 18, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: ProfileSection("人物介绍").AddChild(Text(card.Biography, 18, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`ProfileSection($"周刊档案 · 第 {data.PlayerIntroductionDay / 7} 周").AddChild(Text(data.PlayerIntroduction, 18, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: ProfileSection($"周刊档案 · 第 {data.PlayerIntroductionDay / 7} 周").AddChild(Text(data.PlayerIntroduction, 18, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`results.AddChild(entry)`；返回值紧邻使用处：`ExpressionStatementSyntax: results.AddChild(entry);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`toolbar.AddChild(Button(_choosingFrame ? "收起头像框" : "更换头像框", () => { _choosingFrame = !_choosingFrame; Render(); }, 165))`；返回值紧邻使用处：`ExpressionStatementSyntax: toolbar.AddChild(Button(_choosingFrame ? "收起头像框" : "更换头像框", () => { _choosingFrame = !_choosingFrame; Render(); }, 165));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`toolbar.AddChild(Button("编辑角色", () => OpenCharacterCard(data, "player"), 165))`；返回值紧邻使用处：`ExpressionStatementSyntax: toolbar.AddChild(Button("编辑角色", () => OpenCharacterCard(data, "player"), 165));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`toolbar.AddChild(Button("更换头像", () => OpenAvatarSettings(data), 165))`；返回值紧邻使用处：`ExpressionStatementSyntax: toolbar.AddChild(Button("更换头像", () => OpenAvatarSettings(data), 165));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`toolbar.AddChild(Button("设计立绘", () => OpenPortraitDesigner(data, "player"), 165))`；返回值紧邻使用处：`ExpressionStatementSyntax: toolbar.AddChild(Button("设计立绘", () => OpenPortraitDesigner(data, "player"), 165));`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `int.ToString()`；输入表达式：`CircuitLedger.Points(data, "player").ToString()`；返回值紧邻使用处：`ArgumentSyntax: CircuitLedger.Points(data, "player").ToString()`
- `int.ToString(string?)`；输入表达式：`data.Fans.ToString("N0")`；返回值紧邻使用处：`ArgumentSyntax: data.Fans.ToString("N0")`
- `MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；输入表达式：`.Title.GetFormattedText()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: GameBridge.Characters().FirstOrDefault(c => c.Id.ToString() == character)?.Title.GetFormattedText()`
- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`c.Id.ToString()`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Id.ToString() == character`
- `NationalSpire.CareerAvatars.MainCharacter(NationalSpire.CareerData, string)`；输入表达式：`CareerAvatars.MainCharacter(data, "player")`；返回值紧邻使用处：`BinaryExpressionSyntax: card?.Character ?? CareerAvatars.MainCharacter(data, "player")`
- `NationalSpire.CareerScreen.AvatarWardrobe(NationalSpire.CareerData, Godot.VBoxContainer)`；输入表达式：`AvatarWardrobe(data, ProfileSection("头像框"))`；返回值紧邻使用处：`ExpressionStatementSyntax: AvatarWardrobe(data, ProfileSection("头像框"));`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button(_choosingFrame ? "收起头像框" : "更换头像框", () => { _choosingFrame = !_choosingFrame; Render(); }, 165)`；返回值紧邻使用处：`ArgumentSyntax: Button(_choosingFrame ? "收起头像框" : "更换头像框", () => { _choosingFrame = !_choosingFrame; Render(); }, 165)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button(_showGameArchive ? "收起游戏总档案" : "查看游戏总档案", () => { _showGameArchive = !_showGameArchive; Render(); }, 220)`；返回值紧邻使用处：`ArgumentSyntax: Button(_showGameArchive ? "收起游戏总档案" : "查看游戏总档案", () => { _showGameArchive = !_showGameArchive; Render(); }, 220)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("编辑角色", () => OpenCharacterCard(data, "player"), 165)`；返回值紧邻使用处：`ArgumentSyntax: Button("编辑角色", () => OpenCharacterCard(data, "player"), 165)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("更换头像", () => OpenAvatarSettings(data), 165)`；返回值紧邻使用处：`ArgumentSyntax: Button("更换头像", () => OpenAvatarSettings(data), 165)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("设计立绘", () => OpenPortraitDesigner(data, "player"), 165)`；返回值紧邻使用处：`ArgumentSyntax: Button("设计立绘", () => OpenPortraitDesigner(data, "player"), 165)`
- `NationalSpire.CareerScreen.OpenAvatarSettings(NationalSpire.CareerData, NationalSpire.PlayerAvatar?, System.Action<NationalSpire.PlayerAvatar>?, string, NationalSpire.AvatarArt?)`；输入表达式：`OpenAvatarSettings(data)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenAvatarSettings(data)`
- `NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`；输入表达式：`OpenCharacterCard(data, "player")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenCharacterCard(data, "player")`
- `NationalSpire.CareerScreen.OpenPortraitDesigner(NationalSpire.CareerData, string)`；输入表达式：`OpenPortraitDesigner(data, "player")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenPortraitDesigner(data, "player")`
- `NationalSpire.CareerScreen.PlayerBanner(NationalSpire.CareerData, string)`；输入表达式：`PlayerBanner(data, "player")`；返回值紧邻使用处：`ArgumentSyntax: PlayerBanner(data, "player")`
- `NationalSpire.CareerScreen.ProfileActions()`；输入表达式：`ProfileActions()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ProfileActions()`
- `NationalSpire.CareerScreen.ProfileEntry(Godot.VBoxContainer, string, string, Godot.Color)`；输入表达式：`ProfileEntry(entry, result.Event, result.Outcome, _ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: ProfileEntry(entry, result.Event, result.Outcome, _ink);`
- `NationalSpire.CareerScreen.ProfileEntry(Godot.VBoxContainer, string, string, Godot.Color)`；输入表达式：`ProfileEntry(honors, honor.Title, $"第 {honor.Season} 赛季", _gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: ProfileEntry(honors, honor.Title, $"第 {honor.Season} 赛季", _gold);`
- `NationalSpire.CareerScreen.ProfileFields(Godot.VBoxContainer, params (string Label, string Value)[])`；输入表达式：`ProfileFields(info, ("构筑偏好", card.Style))`；返回值紧邻使用处：`ExpressionStatementSyntax: ProfileFields(info, ("构筑偏好", card.Style));`
- `NationalSpire.CareerScreen.ProfileFields(Godot.VBoxContainer, params (string Label, string Value)[])`；输入表达式：`ProfileFields(info, ("性别", data.PlayerGender), ("职业", card?.Role ?? EsportsWorld.LicenseName(data)),              ("擅长角色", character), ("姓名", card?.Name ?? ""),              ("参赛资格", card != null && card.Role != EsportsWorld.LicenseName(data) ? EsportsWorld.LicenseName(data) : ""),              ("当前连胜", data.Esports.WinStreak > 0 ? $"{data.Esports.WinStreak} 场" : ""))`；返回值紧邻使用处：`ExpressionStatementSyntax: ProfileFields(info, ("性别", data.PlayerGender), ("职业", card?.Role ?? EsportsWorld.LicenseName(data)),              ("擅长角色", character), ("姓名", card?.Name ?? ""),              ("参赛资格", card != null && card.Role != EsportsWorld.LicenseName(data) ? EsportsWorld.LicenseName(data) : ""),              ("当前连胜", data.Esports.WinStreak > 0 ? $"{data.Esports.WinStreak} 场" : ""));`
- `NationalSpire.CareerScreen.ProfileSection(string)`；输入表达式：`ProfileSection("近期赛事")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ProfileSection("近期赛事")`
- `NationalSpire.CareerScreen.ProfileSection(string)`；输入表达式：`ProfileSection("人物介绍")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ProfileSection("人物介绍").AddChild`
- `NationalSpire.CareerScreen.ProfileSection(string)`；输入表达式：`ProfileSection("人物资料")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ProfileSection("人物资料")`
- `NationalSpire.CareerScreen.ProfileSection(string)`；输入表达式：`ProfileSection("荣誉与排名")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ProfileSection("荣誉与排名")`
- `NationalSpire.CareerScreen.ProfileSection(string)`；输入表达式：`ProfileSection("头像框")`；返回值紧邻使用处：`ArgumentSyntax: ProfileSection("头像框")`
- `NationalSpire.CareerScreen.ProfileSection(string)`；输入表达式：`ProfileSection($"周刊档案 · 第 {data.PlayerIntroductionDay / 7} 周")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ProfileSection($"周刊档案 · 第 {data.PlayerIntroductionDay / 7} 周").AddChild`
- `NationalSpire.CareerScreen.ProfileStats(params (string Label, string Value)[])`；输入表达式：`ProfileStats(("生涯战绩", $"{data.Wins} 胜  {data.Draws} 平  {data.Losses} 负"),              ("关注", data.Fans.ToString("N0")), ("世界积分", CircuitLedger.Points(data, "player").ToString()))`；返回值紧邻使用处：`ExpressionStatementSyntax: ProfileStats(("生涯战绩", $"{data.Wins} 胜  {data.Draws} 平  {data.Losses} 负"),              ("关注", data.Fans.ToString("N0")), ("世界积分", CircuitLedger.Points(data, "player").ToString()));`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.ShowArchive()`；输入表达式：`ShowArchive()`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowArchive();`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("暂无荣誉记录", 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("暂无荣誉记录", 16, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text((ClubCoaching.PlayerReserve(data) ? "俱乐部轮换" : "俱乐部首发") + (ClubCoaching.PlayerCoach(data) ? " · 兼任教练" : ""), 18, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Text((ClubCoaching.PlayerReserve(data) ? "俱乐部轮换" : "俱乐部首发") + (ClubCoaching.PlayerCoach(data) ? " · 兼任教练" : ""), 18, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"{MatchRules.AscensionLabel(result)} · 第 {result.Floor} 层", 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"{MatchRules.AscensionLabel(result)} · 第 {result.Floor} 层", 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(card.Biography, 18, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(card.Biography, 18, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(data.PlayerIntroduction, 18, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(data.PlayerIntroduction, 18, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(standing, 17, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Text(standing, 17, CareerVisuals.Teal)`
- `NationalSpire.CircuitLedger.Points(NationalSpire.CareerData, string)`；输入表达式：`CircuitLedger.Points(data, "player")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CircuitLedger.Points(data, "player").ToString`
- `NationalSpire.CircuitLedger.PublicStanding(NationalSpire.CareerData, string, int)`；输入表达式：`CircuitLedger.PublicStanding(data, "player", data.Day)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CircuitLedger.PublicStanding(data, "player", data.Day)`
- `NationalSpire.ClubCoaching.PlayerCoach(NationalSpire.CareerData)`；输入表达式：`ClubCoaching.PlayerCoach(data)`；返回值紧邻使用处：`ConditionalExpressionSyntax: ClubCoaching.PlayerCoach(data) ? " · 兼任教练" : ""`
- `NationalSpire.ClubCoaching.PlayerFeatures(NationalSpire.CareerData)`；输入表达式：`ClubCoaching.PlayerFeatures(data)`；返回值紧邻使用处：`IfStatementSyntax: if (ClubCoaching.PlayerFeatures(data))              _content.AddChild(Text((ClubCoaching.PlayerReserve(data) ? "俱乐部轮换" : "俱乐部首发") + (ClubCoaching.PlayerCoach(data) ? " · 兼任教练" : ""), 18, CareerVisuals.Teal));`
- `NationalSpire.ClubCoaching.PlayerReserve(NationalSpire.CareerData)`；输入表达式：`ClubCoaching.PlayerReserve(data)`；返回值紧邻使用处：`ConditionalExpressionSyntax: ClubCoaching.PlayerReserve(data) ? "俱乐部轮换" : "俱乐部首发"`
- `NationalSpire.EsportsWorld.LicenseName(NationalSpire.CareerData)`；输入表达式：`EsportsWorld.LicenseName(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: card?.Role ?? EsportsWorld.LicenseName(data)`
- `NationalSpire.EsportsWorld.LicenseName(NationalSpire.CareerData)`；输入表达式：`EsportsWorld.LicenseName(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: card.Role != EsportsWorld.LicenseName(data)`
- `NationalSpire.EsportsWorld.LicenseName(NationalSpire.CareerData)`；输入表达式：`EsportsWorld.LicenseName(data)`；返回值紧邻使用处：`ConditionalExpressionSyntax: card != null && card.Role != EsportsWorld.LicenseName(data) ? EsportsWorld.LicenseName(data) : ""`
- `NationalSpire.GameBridge.Characters()`；输入表达式：`GameBridge.Characters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GameBridge.Characters().FirstOrDefault`
- `NationalSpire.MatchRules.AscensionLabel(NationalSpire.CareerResult)`；输入表达式：`MatchRules.AscensionLabel(result)`；返回值紧邻使用处：`InterpolationSyntax: {MatchRules.AscensionLabel(result)}`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`GameBridge.Characters().FirstOrDefault(c => c.Id.ToString() == character)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: GameBridge.Characters().FirstOrDefault(c => c.Id.ToString() == character)?.Title.GetFormattedText()`
- `System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；输入表达式：`data.Esports.Honors.TakeLast(4).Reverse()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var honor in data.Esports.Honors.TakeLast(4).Reverse())              ProfileEntry(honors, honor.Title, $"第 {honor.Season} 赛季", _gold);`
- `System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；输入表达式：`data.Results.TakeLast(3).Reverse()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var result in data.Results.TakeLast(3).Reverse())              {                  var entry = new VBoxContainer(); entry.AddThemeConstantOverride("separation", 10); results.AddChild(entry);                  ProfileEntry(entry, result.Event, result.Outcome, _ink);                  entry.AddChild(Text($"{MatchRules.AscensionLabel(result)} · 第 {result.Floor} 层", 15, _muted));              }`
- `System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；输入表达式：`data.Esports.Honors.TakeLast(4)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Esports.Honors.TakeLast(4).Reverse`
- `System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；输入表达式：`data.Results.TakeLast(3)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Results.TakeLast(3).Reverse`

**赋值（含属性/字段和局部值）：**

- `_choosingFrame` = `!_choosingFrame`
- `_showGameArchive` = `!_showGameArchive`
- `character` = `GameBridge.Characters().FirstOrDefault(c => c.Id.ToString() == character)?.Title.GetFormattedText() ?? character`
- `toolbar.Name` = `"ProfileToolbar"`

<a id="symbol-2d802d5a07b9"></a>

## `NationalSpire.CareerScreen.PersonProfile(NationalSpire.CareerData, NationalSpire.CareerPerson) — private void PersonProfile(CareerData data, CareerPerson person)`

来源：源码第 100 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Profiles(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-70740adc3b48)

**调用：** [`NationalSpire.CameoContent.StreakText(NationalSpire.CareerPerson)`](CameoContent.cs.md#symbol-4b0402048b3d)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerNarrative.Evaluation(NationalSpire.CareerData, NationalSpire.CareerPerson)`](CareerNarrative.cs.md#symbol-63592bc97cd1)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.CanEditCharacter(NationalSpire.CareerData, string)`](CharacterCardScreen.cs.md#symbol-e038ea7a677f)；[`NationalSpire.CareerScreen.ClubProfileActions(NationalSpire.CareerData, NationalSpire.CareerPerson, Godot.VBoxContainer)`](OwnedClubScreen.cs.md#symbol-07281993c5a0)；[`NationalSpire.CareerScreen.NpcAvatarFramePicker(NationalSpire.CareerData, string)`](NpcAvatarFrameScreen.cs.md#symbol-ca2807c0402f)；[`NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`](CharacterCardScreen.cs.md#symbol-a498f622bb3e)；[`NationalSpire.CareerScreen.OpenDateAssets(NationalSpire.CareerData, string)`](DateSceneAssetScreen.cs.md#symbol-a45b4a628cd5)；[`NationalSpire.CareerScreen.OpenPortraitDesigner(NationalSpire.CareerData, string)`](PortraitDesignScreen.cs.md#symbol-3bb5119a73ca)；[`NationalSpire.CareerScreen.PersonLink(NationalSpire.CareerData, string, string, int)`](CareerAvatars.cs.md#symbol-89d5865e1272)；[`NationalSpire.CareerScreen.PlayerBanner(NationalSpire.CareerData, string)`](BroadcastVisuals.cs.md#symbol-936e32073293)；[`NationalSpire.CareerScreen.PrivateProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](PrivateMessageScreen.cs.md#symbol-8e28d3a34860)；[`NationalSpire.CareerScreen.ProfileActions()`](ProfileScreen.cs.md#symbol-70ada758a361)；[`NationalSpire.CareerScreen.ProfileFields(Godot.VBoxContainer, params (string Label, string Value)[])`](ProfileScreen.cs.md#symbol-578cf06bda89)；[`NationalSpire.CareerScreen.ProfileSection(string)`](ProfileScreen.cs.md#symbol-078e0ffb0ebe)；[`NationalSpire.CareerScreen.ProfileStats(params (string Label, string Value)[])`](ProfileScreen.cs.md#symbol-faa45696cdee)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerTraining.MoodLevel(NationalSpire.CareerPerson, int)`](CareerTraining.cs.md#symbol-cd61283f2c46)；[`NationalSpire.CareerTraining.MoodUntil(NationalSpire.CareerPerson, int)`](CareerTraining.cs.md#symbol-b39797719d42)；[`NationalSpire.ChanceFactors.Display()`](MatchRules.cs.md#symbol-065d0664a7cb)；[`NationalSpire.CircuitLedger.Points(NationalSpire.CareerData, string)`](CircuitLedger.cs.md#symbol-73238d706495)；[`NationalSpire.CircuitLedger.PublicStanding(NationalSpire.CareerData, string, int)`](CircuitLedger.cs.md#symbol-08cb65a2d635)；[`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-54b1e9fa0cf0)；[`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`](EsportsWorld.cs.md#symbol-c10dfd5a2e0e)；[`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-24bc82bdbbd4)；[`NationalSpire.IdentityGender.Of(NationalSpire.CareerData, string)`](IdentityGender.cs.md#symbol-961507352d98)；[`NationalSpire.MatchRules.Evaluate(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?, bool)`](MatchRules.cs.md#symbol-92264d5fcfdd)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.GodotObject.Free()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChildCount(bool)`；`Godot.VBoxContainer.VBoxContainer()`；`int.ToString()`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CameoContent.StreakText(NationalSpire.CareerPerson)`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerNarrative.Evaluation(NationalSpire.CareerData, NationalSpire.CareerPerson)`；`NationalSpire.CareerPerson.AiIntroduction`；`NationalSpire.CareerPerson.Biography`；`NationalSpire.CareerPerson.CameoId`；`NationalSpire.CareerPerson.Character`；`NationalSpire.CareerPerson.Connections`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Identities`；`NationalSpire.CareerPerson.IntroductionDay`；`NationalSpire.CareerPerson.Losses`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.CareerPerson.RecordedWinStreak`；`NationalSpire.CareerPerson.Style`；`NationalSpire.CareerPerson.SupportedClubId`；`NationalSpire.CareerPerson.Wins`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.CanEditCharacter(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen.ClubProfileActions(NationalSpire.CareerData, NationalSpire.CareerPerson, Godot.VBoxContainer)`；`NationalSpire.CareerScreen.NpcAvatarFramePicker(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`；`NationalSpire.CareerScreen.OpenDateAssets(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen.OpenPortraitDesigner(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen.PersonLink(NationalSpire.CareerData, string, string, int)`；`NationalSpire.CareerScreen.PlayerBanner(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen.PrivateProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`；`NationalSpire.CareerScreen.ProfileActions()`；`NationalSpire.CareerScreen.ProfileFields(Godot.VBoxContainer, params (string Label, string Value)[])`；`NationalSpire.CareerScreen.ProfileSection(string)`；`NationalSpire.CareerScreen.ProfileStats(params (string Label, string Value)[])`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerTraining.MoodLevel(NationalSpire.CareerPerson, int)`；`NationalSpire.CareerTraining.MoodUntil(NationalSpire.CareerPerson, int)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.ChanceFactors.Display()`；`NationalSpire.CircuitLedger.Points(NationalSpire.CareerData, string)`；`NationalSpire.CircuitLedger.PublicStanding(NationalSpire.CareerData, string, int)`；`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.IdentityGender.Of(NationalSpire.CareerData, string)`；`NationalSpire.MatchRules.Evaluate(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`contract.AddThemeConstantOverride("separation", 20)`；返回值紧邻使用处：`ExpressionStatementSyntax: contract.AddThemeConstantOverride("separation", 20);`
- `Godot.GodotObject.Free()`；输入表达式：`contract.Free()`；返回值紧邻使用处：`ExpressionStatementSyntax: contract.Free();`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(PlayerBanner(data, person.Id))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(PlayerBanner(data, person.Id));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(toolbar)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(toolbar);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`bio.AddChild(Text(CareerNarrative.Evaluation(data, person), 17, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: bio.AddChild(Text(CareerNarrative.Evaluation(data, person), 17, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`bio.AddChild(Text(person.Biography, 18, person.CameoId.Length > 0 ? _gold : _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: bio.AddChild(Text(person.Biography, 18, person.CameoId.Length > 0 ? _gold : _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`ProfileSection("俱乐部合同").AddChild(contract)`；返回值紧邻使用处：`ExpressionStatementSyntax: ProfileSection("俱乐部合同").AddChild(contract);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`ProfileSection("连胜纪录").AddChild(Text(CameoContent.StreakText(person), 18, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: ProfileSection("连胜纪录").AddChild(Text(CameoContent.StreakText(person), 18, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`ProfileSection("赛事排名").AddChild(Text(standing, 17, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: ProfileSection("赛事排名").AddChild(Text(standing, 17, CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`ProfileSection($"周刊档案 · 第 {person.IntroductionDay / 7} 周").AddChild(Text(person.AiIntroduction, 18, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: ProfileSection($"周刊档案 · 第 {person.IntroductionDay / 7} 周").AddChild(Text(person.AiIntroduction, 18, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`relations.AddChild(PersonLink(data, id, CareerEngine.DisplayName(data, id) + "   ↗", 40))`；返回值紧邻使用处：`ExpressionStatementSyntax: relations.AddChild(PersonLink(data, id, CareerEngine.DisplayName(data, id) + "   ↗", 40));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`toolbar.AddChild(Button("编辑角色", () => OpenCharacterCard(data, person.Id), 165))`；返回值紧邻使用处：`ExpressionStatementSyntax: toolbar.AddChild(Button("编辑角色", () => OpenCharacterCard(data, person.Id), 165));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`toolbar.AddChild(Button("立绘与场景", () => OpenDateAssets(data, person.Id), 165))`；返回值紧邻使用处：`ExpressionStatementSyntax: toolbar.AddChild(Button("立绘与场景", () => OpenDateAssets(data, person.Id), 165));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`toolbar.AddChild(Button("设计立绘", () => OpenPortraitDesigner(data, person.Id), 165))`；返回值紧邻使用处：`ExpressionStatementSyntax: toolbar.AddChild(Button("设计立绘", () => OpenPortraitDesigner(data, person.Id), 165));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`toolbar.AddChild(Button("选择头像框", () => NpcAvatarFramePicker(data, person.Id), 165))`；返回值紧邻使用处：`ExpressionStatementSyntax: toolbar.AddChild(Button("选择头像框", () => NpcAvatarFramePicker(data, person.Id), 165));`
- `Godot.Node.GetChildCount(bool)`；输入表达式：`contract.GetChildCount()`；返回值紧邻使用处：`BinaryExpressionSyntax: contract.GetChildCount() > 0`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `int.ToString()`；输入表达式：`CircuitLedger.Points(data, person.Id).ToString()`；返回值紧邻使用处：`ArgumentSyntax: CircuitLedger.Points(data, person.Id).ToString()`
- `NationalSpire.CameoContent.StreakText(NationalSpire.CareerPerson)`；输入表达式：`CameoContent.StreakText(person)`；返回值紧邻使用处：`ArgumentSyntax: CameoContent.StreakText(person)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.DisplayName(data, id) + "   ↗"`
- `NationalSpire.CareerNarrative.Evaluation(NationalSpire.CareerData, NationalSpire.CareerPerson)`；输入表达式：`CareerNarrative.Evaluation(data, person)`；返回值紧邻使用处：`ArgumentSyntax: CareerNarrative.Evaluation(data, person)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("编辑角色", () => OpenCharacterCard(data, person.Id), 165)`；返回值紧邻使用处：`ArgumentSyntax: Button("编辑角色", () => OpenCharacterCard(data, person.Id), 165)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("立绘与场景", () => OpenDateAssets(data, person.Id), 165)`；返回值紧邻使用处：`ArgumentSyntax: Button("立绘与场景", () => OpenDateAssets(data, person.Id), 165)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("设计立绘", () => OpenPortraitDesigner(data, person.Id), 165)`；返回值紧邻使用处：`ArgumentSyntax: Button("设计立绘", () => OpenPortraitDesigner(data, person.Id), 165)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("选择头像框", () => NpcAvatarFramePicker(data, person.Id), 165)`；返回值紧邻使用处：`ArgumentSyntax: Button("选择头像框", () => NpcAvatarFramePicker(data, person.Id), 165)`
- `NationalSpire.CareerScreen.CanEditCharacter(NationalSpire.CareerData, string)`；输入表达式：`CanEditCharacter(data, person.Id)`；返回值紧邻使用处：`IfStatementSyntax: if (CanEditCharacter(data, person.Id)) toolbar.AddChild(Button("编辑角色", () => OpenCharacterCard(data, person.Id), 165));`
- `NationalSpire.CareerScreen.ClubProfileActions(NationalSpire.CareerData, NationalSpire.CareerPerson, Godot.VBoxContainer)`；输入表达式：`ClubProfileActions(data, person, contract)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClubProfileActions(data, person, contract);`
- `NationalSpire.CareerScreen.NpcAvatarFramePicker(NationalSpire.CareerData, string)`；输入表达式：`NpcAvatarFramePicker(data, person.Id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => NpcAvatarFramePicker(data, person.Id)`
- `NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`；输入表达式：`OpenCharacterCard(data, person.Id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenCharacterCard(data, person.Id)`
- `NationalSpire.CareerScreen.OpenDateAssets(NationalSpire.CareerData, string)`；输入表达式：`OpenDateAssets(data, person.Id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenDateAssets(data, person.Id)`
- `NationalSpire.CareerScreen.OpenPortraitDesigner(NationalSpire.CareerData, string)`；输入表达式：`OpenPortraitDesigner(data, person.Id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenPortraitDesigner(data, person.Id)`
- `NationalSpire.CareerScreen.PersonLink(NationalSpire.CareerData, string, string, int)`；输入表达式：`PersonLink(data, id, CareerEngine.DisplayName(data, id) + "   ↗", 40)`；返回值紧邻使用处：`ArgumentSyntax: PersonLink(data, id, CareerEngine.DisplayName(data, id) + "   ↗", 40)`
- `NationalSpire.CareerScreen.PlayerBanner(NationalSpire.CareerData, string)`；输入表达式：`PlayerBanner(data, person.Id)`；返回值紧邻使用处：`ArgumentSyntax: PlayerBanner(data, person.Id)`
- `NationalSpire.CareerScreen.PrivateProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`；输入表达式：`PrivateProfile(data, person)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateProfile(data, person);`
- `NationalSpire.CareerScreen.ProfileActions()`；输入表达式：`ProfileActions()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ProfileActions()`
- `NationalSpire.CareerScreen.ProfileFields(Godot.VBoxContainer, params (string Label, string Value)[])`；输入表达式：`ProfileFields(info, ("短期状态", (mood > 0 ? "振奋" : "低落") + $" · 剩余 {CareerTraining.MoodUntil(person, data.Day) - data.Day} 天"),                  ("状态变化", "随日期逐渐消退"))`；返回值紧邻使用处：`ExpressionStatementSyntax: ProfileFields(info, ("短期状态", (mood > 0 ? "振奋" : "低落") + $" · 剩余 {CareerTraining.MoodUntil(person, data.Day) - data.Day} 天"),                  ("状态变化", "随日期逐渐消退"));`
- `NationalSpire.CareerScreen.ProfileFields(Godot.VBoxContainer, params (string Label, string Value)[])`；输入表达式：`ProfileFields(info, ("性别", IdentityGender.Of(data, person.Id)), ("擅长角色", person.Character),              ("身份", string.Join(" / ", person.Identities)), ("构筑偏好", person.Style),              ("关注俱乐部", person.SupportedClubId.Length > 0 ? EsportsWorld.ClubName(data, person.SupportedClubId) : ""))`；返回值紧邻使用处：`ExpressionStatementSyntax: ProfileFields(info, ("性别", IdentityGender.Of(data, person.Id)), ("擅长角色", person.Character),              ("身份", string.Join(" / ", person.Identities)), ("构筑偏好", person.Style),              ("关注俱乐部", person.SupportedClubId.Length > 0 ? EsportsWorld.ClubName(data, person.SupportedClubId) : ""));`
- `NationalSpire.CareerScreen.ProfileFields(Godot.VBoxContainer, params (string Label, string Value)[])`；输入表达式：`ProfileFields(info, ($"进阶 {person.MaxAscension} 当前通关率", MatchRules.Evaluate(data, person, person.MaxAscension).Display()))`；返回值紧邻使用处：`ExpressionStatementSyntax: ProfileFields(info, ($"进阶 {person.MaxAscension} 当前通关率", MatchRules.Evaluate(data, person, person.MaxAscension).Display()));`
- `NationalSpire.CareerScreen.ProfileSection(string)`；输入表达式：`ProfileSection("俱乐部合同")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ProfileSection("俱乐部合同").AddChild`
- `NationalSpire.CareerScreen.ProfileSection(string)`；输入表达式：`ProfileSection("连胜纪录")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ProfileSection("连胜纪录").AddChild`
- `NationalSpire.CareerScreen.ProfileSection(string)`；输入表达式：`ProfileSection("人物介绍")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ProfileSection("人物介绍")`
- `NationalSpire.CareerScreen.ProfileSection(string)`；输入表达式：`ProfileSection("人物资料")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ProfileSection("人物资料")`
- `NationalSpire.CareerScreen.ProfileSection(string)`；输入表达式：`ProfileSection("赛事排名")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ProfileSection("赛事排名").AddChild`
- `NationalSpire.CareerScreen.ProfileSection(string)`；输入表达式：`ProfileSection("熟悉的人")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ProfileSection("熟悉的人")`
- `NationalSpire.CareerScreen.ProfileSection(string)`；输入表达式：`ProfileSection($"周刊档案 · 第 {person.IntroductionDay / 7} 周")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ProfileSection($"周刊档案 · 第 {person.IntroductionDay / 7} 周").AddChild`
- `NationalSpire.CareerScreen.ProfileStats(params (string Label, string Value)[])`；输入表达式：`ProfileStats(("累计战绩", $"{person.Wins} 胜  {person.Losses} 负"),              ("历史胜率", total == 0 ? "暂无战绩" : $"{100.0 * person.Wins / total:0.#}%"),              ("世界积分", CircuitLedger.Points(data, person.Id).ToString()))`；返回值紧邻使用处：`ExpressionStatementSyntax: ProfileStats(("累计战绩", $"{person.Wins} 胜  {person.Losses} 负"),              ("历史胜率", total == 0 ? "暂无战绩" : $"{100.0 * person.Wins / total:0.#}%"),              ("世界积分", CircuitLedger.Points(data, person.Id).ToString()));`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(CameoContent.StreakText(person), 18, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(CameoContent.StreakText(person), 18, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(CareerNarrative.Evaluation(data, person), 17, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(CareerNarrative.Evaluation(data, person), 17, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(person.AiIntroduction, 18, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(person.AiIntroduction, 18, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(person.Biography, 18, person.CameoId.Length > 0 ? _gold : _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(person.Biography, 18, person.CameoId.Length > 0 ? _gold : _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(standing, 17, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Text(standing, 17, CareerVisuals.Teal)`
- `NationalSpire.CareerTraining.MoodLevel(NationalSpire.CareerPerson, int)`；输入表达式：`CareerTraining.MoodLevel(person, data.Day)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerTraining.MoodLevel(person, data.Day) is var mood`
- `NationalSpire.CareerTraining.MoodUntil(NationalSpire.CareerPerson, int)`；输入表达式：`CareerTraining.MoodUntil(person, data.Day)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerTraining.MoodUntil(person, data.Day) - data.Day`
- `NationalSpire.ChanceFactors.Display()`；输入表达式：`MatchRules.Evaluate(data, person, person.MaxAscension).Display()`；返回值紧邻使用处：`ArgumentSyntax: MatchRules.Evaluate(data, person, person.MaxAscension).Display()`
- `NationalSpire.CircuitLedger.Points(NationalSpire.CareerData, string)`；输入表达式：`CircuitLedger.Points(data, person.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CircuitLedger.Points(data, person.Id).ToString`
- `NationalSpire.CircuitLedger.PublicStanding(NationalSpire.CareerData, string, int)`；输入表达式：`CircuitLedger.PublicStanding(data, person.Id, data.Day)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CircuitLedger.PublicStanding(data, person.Id, data.Day)`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubName(data, person.SupportedClubId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: person.SupportedClubId.Length > 0 ? EsportsWorld.ClubName(data, person.SupportedClubId) : ""`
- `NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；输入表达式：`EsportsWorld.IsProfessional(person)`；返回值紧邻使用处：`BinaryExpressionSyntax: person.CameoId.Length == 0 && EsportsWorld.IsProfessional(person)`
- `NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.IsHuman(data, person.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !GroupChats.IsHuman(data, person.Id)`
- `NationalSpire.IdentityGender.Of(NationalSpire.CareerData, string)`；输入表达式：`IdentityGender.Of(data, person.Id)`；返回值紧邻使用处：`ArgumentSyntax: IdentityGender.Of(data, person.Id)`
- `NationalSpire.MatchRules.Evaluate(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?, bool)`；输入表达式：`MatchRules.Evaluate(data, person, person.MaxAscension)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: MatchRules.Evaluate(data, person, person.MaxAscension).Display`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join(" / ", person.Identities)`；返回值紧邻使用处：`ArgumentSyntax: string.Join(" / ", person.Identities)`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`person.Connections.Take(2)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string id in person.Connections.Take(2)) relations.AddChild(PersonLink(data, id, CareerEngine.DisplayName(data, id) + "   ↗", 40));`

**赋值（含属性/字段和局部值）：**


<a id="symbol-69bc6ca2a621"></a>

## `NationalSpire.CareerScreen.ProfileEntry(Godot.VBoxContainer, string, string, Godot.Color) — private void ProfileEntry(VBoxContainer parent, string title, string detail, Color color)`

来源：源码第 145 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PlayerProfile(NationalSpire.CareerData)`](ProfileScreen.cs.md#symbol-ce70d1ef24b8)；[`NationalSpire.CareerScreen.ShowArchive()`](CareerScreen.cs.md#symbol-ce008839cea8)

**调用：** [`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 24)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 24);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(label)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(label);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(Text(title, 18, color))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(Text(title, 18, color));`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(125, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: label.CustomMinimumSize = new(125, 0)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(detail, 15, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text(detail, 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(title, 18, color)`；返回值紧邻使用处：`ArgumentSyntax: Text(title, 18, color)`

**赋值（含属性/字段和局部值）：**

- `label.CustomMinimumSize` = `new(125, 0)`
- `label.HorizontalAlignment` = `HorizontalAlignment.Right`
- `label.SizeFlagsHorizontal` = `SizeFlags.ShrinkEnd`
