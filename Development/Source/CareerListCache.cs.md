# CareerListCache.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`652827A9A88106CE26F4E8E384C38E1F2B17EA15A09DAD72298D37733BFD53A9`。来源：[源码](../../CareerListCache.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerListCache`、`NationalSpire.CareerListCache.ProfileRow`、`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
internal required PanelContainer Card;
internal required Label Role, RealName, Character, Rating;
internal required Button Name;
internal required CareerAvatar Avatar;
internal Action? Open;
internal readonly List<ProfileRow> Profiles = [];
private MarketTerminal? _market;
private bool _idle;
private string? _glyphs;
private int _glyphPosition;
private int _iconPosition;
private int _relicPosition;
private CareerListCache? _listCache;
```

<a id="symbol-8e4ce39fadc2"></a>

## `NationalSpire.CareerListCache.Market — internal MarketTerminal Market`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.MarketTerminal.MarketTerminal()`](MarketTerminal.cs.md#symbol-ca583ab46f87)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerListCache._market`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(_market)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(_market);`
- `NationalSpire.MarketTerminal.MarketTerminal()`；输入表达式：`new MarketTerminal()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _market = new MarketTerminal()`

**赋值（含属性/字段和局部值）：**

- `_market` = `new MarketTerminal()`

<a id="symbol-eba9914ced8b"></a>

## `NationalSpire.CareerListCache.For(Godot.Node) — internal static CareerListCache For(Node menu)`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenView(Godot.Control, NationalSpire.ICareerSession?, string?)`](CareerScreen.cs.md#symbol-2b6ef58a9693)；[`NationalSpire.MainMenuEntries.Bind(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu, Godot.Button)`](MainMenuEntries.cs.md#symbol-04f3caa98ff1)

**调用：** [`NationalSpire.CareerVisuals.CreateTheme()`](CareerVisuals.cs.md#symbol-a5f88af9f360)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChildren(bool)`；`NationalSpire.CareerListCache.CareerListCache()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.IEnumerable.OfType<TResult>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerListCache._idle`；`NationalSpire.CareerVisuals.CreateTheme()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`menu.AddChild(cache)`；返回值紧邻使用处：`ExpressionStatementSyntax: menu.AddChild(cache);`
- `Godot.Node.GetChildren(bool)`；输入表达式：`menu.GetChildren()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: menu.GetChildren().OfType<CareerListCache>`
- `NationalSpire.CareerListCache.CareerListCache()`；输入表达式：`new CareerListCache { Name = "NationalSpireListCache", Visible = false, Theme = CareerVisuals.CreateTheme(), _idle = true }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CareerListCache { Name = "NationalSpireListCache", Visible = false, Theme = CareerVisuals.CreateTheme(), _idle = true }`
- `NationalSpire.CareerVisuals.CreateTheme()`；输入表达式：`CareerVisuals.CreateTheme()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Theme = CareerVisuals.CreateTheme()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`menu.GetChildren().OfType<CareerListCache>().FirstOrDefault()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = menu.GetChildren().OfType<CareerListCache>().FirstOrDefault()`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`menu.GetChildren().OfType<CareerListCache>()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: menu.GetChildren().OfType<CareerListCache>().FirstOrDefault`

**赋值（含属性/字段和局部值）：**

- `_idle` = `true`
- `Name` = `"NationalSpireListCache"`
- `Theme` = `CareerVisuals.CreateTheme()`
- `Visible` = `false`

<a id="symbol-e8085c360313"></a>

## `NationalSpire.CareerListCache._Process(double) — public override void _Process(double delta)`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerListCache.AddProfile()`](CareerListCache.cs.md#symbol-25cd78ebfabe)；[`NationalSpire.CareerVisuals.WarmText(string)`](CareerVisuals.cs.md#symbol-da585957e2e0)；[`NationalSpire.LifestyleArt.Icon(string)`](LifestyleArt.cs.md#symbol-91f9b2ac06fa)；[`NationalSpire.MarketTerminal.Prepare(double)`](MarketTerminal.cs.md#symbol-64aae4a775dc)；[`NationalSpire.RelicArt.Read(string)`](RelicArt.cs.md#symbol-1d35c476ee42)；`Godot.Node.SetProcess(bool)`；`string.Concat(System.Collections.Generic.IEnumerable<string?>)`；`string.String(char[]?)`；`string.Substring(int, int)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerListCache._glyphPosition`；`NationalSpire.CareerListCache._glyphs`；`NationalSpire.CareerListCache._iconPosition`；`NationalSpire.CareerListCache._idle`；`NationalSpire.CareerListCache._relicPosition`；`NationalSpire.CareerListCache.AddProfile()`；`NationalSpire.CareerListCache.Market`；`NationalSpire.CareerListCache.Profiles`；`NationalSpire.CareerRelics.Catalog`；`NationalSpire.CareerRelics.Item.Id`；`NationalSpire.CareerScreen.Current`；`NationalSpire.CareerVisuals.WarmText(string)`；`NationalSpire.Coop.CoopScreen.Current`；`NationalSpire.LifestyleArt.Icon(string)`；`NationalSpire.LifestyleArt.Sections`；`NationalSpire.MarketTerminal.Prepare(double)`；`NationalSpire.NamePools.CrowdEnds`；`NationalSpire.NamePools.CrowdStarts`；`NationalSpire.PromptLibrary.Sections`；`NationalSpire.PromptSection.DefaultText`；`NationalSpire.RelicArt.Read(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.SetProcess(bool)`；输入表达式：`SetProcess(false)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetProcess(false);`
- `NationalSpire.CareerListCache.AddProfile()`；输入表达式：`AddProfile()`；返回值紧邻使用处：`ExpressionStatementSyntax: AddProfile();`
- `NationalSpire.CareerVisuals.WarmText(string)`；输入表达式：`CareerVisuals.WarmText(_glyphs.Substring(_glyphPosition, length))`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.WarmText(_glyphs.Substring(_glyphPosition, length));`
- `NationalSpire.LifestyleArt.Icon(string)`；输入表达式：`LifestyleArt.Icon(LifestyleArt.Sections[_iconPosition++])`；返回值紧邻使用处：`ExpressionStatementSyntax: LifestyleArt.Icon(LifestyleArt.Sections[_iconPosition++]);`
- `NationalSpire.MarketTerminal.Prepare(double)`；输入表达式：`Market.Prepare(2)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Market.Prepare(2)`
- `NationalSpire.RelicArt.Read(string)`；输入表达式：`RelicArt.Read(CareerRelics.Catalog[_relicPosition++].Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: RelicArt.Read(CareerRelics.Catalog[_relicPosition++].Id);`
- `string.Concat(System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Concat(PromptLibrary.Sections.Select(s => s.DefaultText).Concat(NamePools.CrowdStarts).Concat(NamePools.CrowdEnds))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: string.Concat(PromptLibrary.Sections.Select(s => s.DefaultText).Concat(NamePools.CrowdStarts).Concat(NamePools.CrowdEnds)).Distinct`
- `string.String(char[]?)`；输入表达式：`new string(string.Concat(PromptLibrary.Sections.Select(s => s.DefaultText).Concat(NamePools.CrowdStarts).Concat(NamePools.CrowdEnds)).Distinct().ToArray())`；返回值紧邻使用处：`AssignmentExpressionSyntax: _glyphs ??= new string(string.Concat(PromptLibrary.Sections.Select(s => s.DefaultText).Concat(NamePools.CrowdStarts).Concat(NamePools.CrowdEnds)).Distinct().ToArray())`
- `string.Substring(int, int)`；输入表达式：`_glyphs.Substring(_glyphPosition, length)`；返回值紧邻使用处：`ArgumentSyntax: _glyphs.Substring(_glyphPosition, length)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`PromptLibrary.Sections.Select(s => s.DefaultText).Concat(NamePools.CrowdStarts).Concat(NamePools.CrowdEnds)`；返回值紧邻使用处：`ArgumentSyntax: PromptLibrary.Sections.Select(s => s.DefaultText).Concat(NamePools.CrowdStarts).Concat(NamePools.CrowdEnds)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`PromptLibrary.Sections.Select(s => s.DefaultText).Concat(NamePools.CrowdStarts)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PromptLibrary.Sections.Select(s => s.DefaultText).Concat(NamePools.CrowdStarts).Concat`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`string.Concat(PromptLibrary.Sections.Select(s => s.DefaultText).Concat(NamePools.CrowdStarts).Concat(NamePools.CrowdEnds)).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: string.Concat(PromptLibrary.Sections.Select(s => s.DefaultText).Concat(NamePools.CrowdStarts).Concat(NamePools.CrowdEnds)).Distinct().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`PromptLibrary.Sections.Select(s => s.DefaultText)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PromptLibrary.Sections.Select(s => s.DefaultText).Concat`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`string.Concat(PromptLibrary.Sections.Select(s => s.DefaultText).Concat(NamePools.CrowdStarts).Concat(NamePools.CrowdEnds)).Distinct().ToArray()`；返回值紧邻使用处：`ArgumentSyntax: string.Concat(PromptLibrary.Sections.Select(s => s.DefaultText).Concat(NamePools.CrowdStarts).Concat(NamePools.CrowdEnds)).Distinct().ToArray()`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(32, _glyphs.Length - _glyphPosition)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(32, _glyphs.Length - _glyphPosition)`

**赋值（含属性/字段和局部值）：**

- `_glyphPosition` += `length`
- `_glyphs` ??= `new string(string.Concat(PromptLibrary.Sections.Select(s => s.DefaultText).Concat(NamePools.CrowdStarts).Concat(NamePools.CrowdEnds)).Distinct().ToArray())`
- `_glyphs` = `null`
- `_idle` = `false`

<a id="symbol-25cd78ebfabe"></a>

## `NationalSpire.CareerListCache.AddProfile() — internal ProfileRow AddProfile()`

来源：源码第 50 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerListCache._Process(double)`](CareerListCache.cs.md#symbol-e8085c360313)；[`NationalSpire.CareerScreen.AddProfileCards(NationalSpire.CareerData, Godot.GridContainer, System.Collections.Generic.IEnumerable<NationalSpire.CareerPerson>)`](CareerListCache.cs.md#symbol-13c7d56a75c4)

**调用：** [`Label(int, Godot.Color)`](CareerListCache.cs.md#symbol-626fffef4f61)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Color.Color(float, float, float, float)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.BroadcastButton.BroadcastButton()`；`NationalSpire.BroadcastPanel.BroadcastPanel()`；`NationalSpire.CareerAvatar.CareerAvatar()`；`NationalSpire.CareerListCache.ProfileRow.ProfileRow()`；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `Label(int, Godot.Color)`；`NationalSpire.CareerListCache.ProfileRow.Avatar`；`NationalSpire.CareerListCache.ProfileRow.Card`；`NationalSpire.CareerListCache.ProfileRow.Character`；`NationalSpire.CareerListCache.ProfileRow.Name`；`NationalSpire.CareerListCache.ProfileRow.Open`；`NationalSpire.CareerListCache.ProfileRow.Rating`；`NationalSpire.CareerListCache.ProfileRow.RealName`；`NationalSpire.CareerListCache.ProfileRow.Role`；`NationalSpire.CareerListCache.Profiles`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Gold`；`NationalSpire.CareerVisuals.Ink`；`NationalSpire.CareerVisuals.Muted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(1.15f, 1.15f, 1.15f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: avatar.Modulate = new Color(1.15f, 1.15f, 1.15f)`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`name.AddThemeColorOverride("font_color", CareerVisuals.Ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: name.AddThemeColorOverride("font_color", CareerVisuals.Ink);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`line.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`name.AddThemeFontSizeOverride("font_size", 23)`；返回值紧邻使用处：`ExpressionStatementSyntax: name.AddThemeFontSizeOverride("font_size", 23);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`avatarButton.AddThemeStyleboxOverride(state, new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: avatarButton.AddThemeStyleboxOverride(state, new StyleBoxEmpty());`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("142332"))`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("142332"));`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`avatar.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: avatar.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`avatarButton.AddChild(avatar)`；返回值紧邻使用处：`ExpressionStatementSyntax: avatarButton.AddChild(avatar);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(character)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(character);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(line)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(line);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(rating)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(rating);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(realName)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(realName);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(role)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(role);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`card.AddChild(box)`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddChild(box);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(avatarButton)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(avatarButton);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(name)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(name);`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty()`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxEmpty()`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 48)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(52, 52)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(52, 52)`
- `Label(int, Godot.Color)`；输入表达式：`Label(13, CareerVisuals.Muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Label(13, CareerVisuals.Muted)`
- `Label(int, Godot.Color)`；输入表达式：`Label(14, CareerVisuals.Gold)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Label(14, CareerVisuals.Gold)`
- `Label(int, Godot.Color)`；输入表达式：`Label(14, CareerVisuals.Muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Label(14, CareerVisuals.Muted)`
- `Label(int, Godot.Color)`；输入表达式：`Label(16, CareerVisuals.Ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Label(16, CareerVisuals.Ink)`
- `NationalSpire.BroadcastButton.BroadcastButton()`；输入表达式：`new BroadcastButton { CustomMinimumSize = new(0, 48), Alignment = HorizontalAlignment.Left, SizeFlagsHorizontal = SizeFlags.ExpandFill, AutowrapMode = TextServer.AutowrapMode.WordSmart }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastButton { CustomMinimumSize = new(0, 48), Alignment = HorizontalAlignment.Left, SizeFlagsHorizontal = SizeFlags.ExpandFill, AutowrapMode = TextServer.AutowrapMode.WordSmart }`
- `NationalSpire.BroadcastButton.BroadcastButton()`；输入表达式：`new BroadcastButton { CustomMinimumSize = new(52, 52), SizeFlagsHorizontal = SizeFlags.ShrinkBegin, SizeFlagsVertical = SizeFlags.ShrinkCenter, FocusMode = FocusModeEnum.All }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastButton { CustomMinimumSize = new(52, 52), SizeFlagsHorizontal = SizeFlags.ShrinkBegin, SizeFlagsVertical = SizeFlags.ShrinkCenter, FocusMode = FocusModeEnum.All }`
- `NationalSpire.BroadcastPanel.BroadcastPanel()`；输入表达式：`new BroadcastPanel { SizeFlagsHorizontal = SizeFlags.ExpandFill, Theme = Theme }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastPanel { SizeFlagsHorizontal = SizeFlags.ExpandFill, Theme = Theme }`
- `NationalSpire.CareerAvatar.CareerAvatar()`；输入表达式：`new CareerAvatar { CustomMinimumSize = new(52, 52) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CareerAvatar { CustomMinimumSize = new(52, 52) }`
- `NationalSpire.CareerListCache.ProfileRow.ProfileRow()`；输入表达式：`new ProfileRow { Card = card, Role = role, Name = name, RealName = realName, Character = character, Rating = rating, Avatar = avatar }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ProfileRow { Card = card, Role = role, Name = name, RealName = realName, Character = character, Rating = rating, Avatar = avatar }`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("142332")`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("142332")`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: row.Open?.Invoke()`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`Profiles.Add(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: Profiles.Add(row);`

**赋值（含属性/字段和局部值）：**

- `Alignment` = `HorizontalAlignment.Left`
- `AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `avatar.Modulate` = `Colors.White`
- `avatar.Modulate` = `new Color(1.15f, 1.15f, 1.15f)`
- `Avatar` = `avatar`
- `avatarButton.MouseEntered` += `() => avatar.Modulate = new Color(1.15f, 1.15f, 1.15f)`
- `avatarButton.MouseExited` += `() => avatar.Modulate = Colors.White`
- `avatarButton.Pressed` += `() => row.Open?.Invoke()`
- `Card` = `card`
- `Character` = `character`
- `CustomMinimumSize` = `new(0, 48)`
- `CustomMinimumSize` = `new(52, 52)`
- `FocusMode` = `FocusModeEnum.All`
- `name.Pressed` += `() => row.Open?.Invoke()`
- `Name` = `name`
- `Rating` = `rating`
- `RealName` = `realName`
- `Role` = `role`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `Theme` = `Theme`

<a id="symbol-626fffef4f61"></a>

## `Label(int, Godot.Color) — Label Label(int size, Color color)`

来源：源码第 55 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerListCache.AddProfile()`](CareerListCache.cs.md#symbol-25cd78ebfabe)

**调用：** `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Label.Label()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`label.AddThemeColorOverride("font_color", color)`；返回值紧邻使用处：`ExpressionStatementSyntax: label.AddThemeColorOverride("font_color", color);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`label.AddThemeConstantOverride("line_spacing", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: label.AddThemeConstantOverride("line_spacing", 8);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`label.AddThemeFontSizeOverride("font_size", size)`；返回值紧邻使用处：`ExpressionStatementSyntax: label.AddThemeFontSizeOverride("font_size", size);`
- `Godot.Label.Label()`；输入表达式：`new Label { MouseFilter = MouseFilterEnum.Ignore, AutowrapMode = TextServer.AutowrapMode.WordSmart, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Label { MouseFilter = MouseFilterEnum.Ignore, AutowrapMode = TextServer.AutowrapMode.WordSmart, SizeFlagsHorizontal = SizeFlags.ExpandFill }`

**赋值（含属性/字段和局部值）：**

- `AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-395e4ab9a213"></a>

## `NationalSpire.CareerListCache.Release() — internal void Release()`

来源：源码第 77 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen._ExitTree()`](CareerScreen.cs.md#symbol-5aaebf0ee0ab)；[`NationalSpire.CareerScreen.Close(bool)`](CareerScreen.cs.md#symbol-9bfd6bc6f6d3)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)

**调用：** [`NationalSpire.MarketTerminal.Unbind()`](MarketTerminal.cs.md#symbol-76844d4631c4)；`Godot.CanvasItem.Hide()`；`Godot.Node.GetParent()`；`Godot.Node.Reparent(Godot.Node, bool)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerListCache._market`；`NationalSpire.CareerListCache.ProfileRow.Card`；`NationalSpire.CareerListCache.ProfileRow.Open`；`NationalSpire.CareerListCache.Profiles`；`NationalSpire.MarketTerminal.Unbind()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`_market.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _market.Hide();`
- `Godot.CanvasItem.Hide()`；输入表达式：`row.Card.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: row.Card.Hide();`
- `Godot.Node.GetParent()`；输入表达式：`_market.GetParent()`；返回值紧邻使用处：`BinaryExpressionSyntax: _market.GetParent() != this`
- `Godot.Node.GetParent()`；输入表达式：`r.Card.GetParent()`；返回值紧邻使用处：`BinaryExpressionSyntax: r.Card.GetParent() != this`
- `Godot.Node.Reparent(Godot.Node, bool)`；输入表达式：`_market.Reparent(this)`；返回值紧邻使用处：`ExpressionStatementSyntax: _market.Reparent(this);`
- `Godot.Node.Reparent(Godot.Node, bool)`；输入表达式：`row.Card.Reparent(this)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.Card.Reparent(this);`
- `NationalSpire.MarketTerminal.Unbind()`；输入表达式：`_market.Unbind()`；返回值紧邻使用处：`ExpressionStatementSyntax: _market.Unbind();`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Profiles.Where(r => r.Card.GetParent() != this)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var row in Profiles.Where(r => r.Card.GetParent() != this))          { row.Open = null; row.Card.Hide(); row.Card.Reparent(this); }`

**赋值（含属性/字段和局部值）：**

- `row.Open` = `null`

<a id="symbol-13c7d56a75c4"></a>

## `NationalSpire.CareerScreen.AddProfileCards(NationalSpire.CareerData, Godot.GridContainer, System.Collections.Generic.IEnumerable<NationalSpire.CareerPerson>) — private void AddProfileCards(CareerData data, GridContainer grid, IEnumerable<CareerPerson> people)`

来源：源码第 93 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Profiles(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-70740adc3b48)

**调用：** [`NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`](AvatarHonors.cs.md#symbol-5207a1627331)；[`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-cd3d95caefab)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerListCache.AddProfile()`](CareerListCache.cs.md#symbol-25cd78ebfabe)；[`NationalSpire.CareerMoney.Display(string)`](LifeData.cs.md#symbol-4a2afc43261a)；[`NationalSpire.CareerScreen.OpenPerson(string)`](CareerNavigation.cs.md#symbol-4430ec2bce8b)；[`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-54b1e9fa0cf0)；[`NationalSpire.IdentityGender.Of(NationalSpire.CareerData, string)`](IdentityGender.cs.md#symbol-961507352d98)；`Godot.CanvasItem.Show()`；`Godot.Node.GetParent()`；`Godot.Node.Reparent(Godot.Node, bool)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.AvatarIdentity.Description`；`NationalSpire.CareerAvatar.Art`；`NationalSpire.CareerAvatar.Identity`；`NationalSpire.CareerAvatar.PersonId`；`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerListCache.AddProfile()`；`NationalSpire.CareerListCache.ProfileRow.Avatar`；`NationalSpire.CareerListCache.ProfileRow.Card`；`NationalSpire.CareerListCache.ProfileRow.Character`；`NationalSpire.CareerListCache.ProfileRow.Name`；`NationalSpire.CareerListCache.ProfileRow.Open`；`NationalSpire.CareerListCache.ProfileRow.Rating`；`NationalSpire.CareerListCache.ProfileRow.RealName`；`NationalSpire.CareerListCache.ProfileRow.Role`；`NationalSpire.CareerListCache.Profiles`；`NationalSpire.CareerMoney.Display(string)`；`NationalSpire.CareerPerson.Character`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.Handle`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.CareerPerson.Name`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CareerPerson.Rating`；`NationalSpire.CareerPerson.Role`；`NationalSpire.CareerScreen._listCache`；`NationalSpire.CareerScreen.OpenPerson(string)`；`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；`NationalSpire.IdentityGender.Of(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Show()`；输入表达式：`row.Card.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: row.Card.Show();`
- `Godot.Node.GetParent()`；输入表达式：`row.Avatar.GetParent()`；返回值紧邻使用处：`CastExpressionSyntax: (Control)row.Avatar.GetParent()`
- `Godot.Node.Reparent(Godot.Node, bool)`；输入表达式：`row.Card.Reparent(grid)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.Card.Reparent(grid);`
- `NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`AvatarHonors.ForPerson(data, id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: row.Avatar.Identity = AvatarHonors.ForPerson(data, id)`
- `NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`CareerAvatars.ForPerson(data, id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: row.Avatar.Art = CareerAvatars.ForPerson(data, id)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.DisplayName(data, id) + " · "`
- `NationalSpire.CareerListCache.AddProfile()`；输入表达式：`_listCache.AddProfile()`；返回值紧邻使用处：`ConditionalExpressionSyntax: index < _listCache!.Profiles.Count ? _listCache.Profiles[index] : _listCache.AddProfile()`
- `NationalSpire.CareerMoney.Display(string)`；输入表达式：`CareerMoney.Display(person.Character + " / " + EsportsWorld.ClubName(data, person.ClubId))`；返回值紧邻使用处：`AssignmentExpressionSyntax: row.Character.Text = CareerMoney.Display(person.Character + " / " + EsportsWorld.ClubName(data, person.ClubId))`
- `NationalSpire.CareerMoney.Display(string)`；输入表达式：`CareerMoney.Display(person.Name)`；返回值紧邻使用处：`AssignmentExpressionSyntax: row.RealName.Text = CareerMoney.Display(person.Name)`
- `NationalSpire.CareerMoney.Display(string)`；输入表达式：`CareerMoney.Display(person.PublicName + "   ↗")`；返回值紧邻使用处：`AssignmentExpressionSyntax: row.Name.Text = CareerMoney.Display(person.PublicName + "   ↗")`
- `NationalSpire.CareerMoney.Display(string)`；输入表达式：`CareerMoney.Display(person.Role + "  /  " + person.Country + "  ·  " + IdentityGender.Of(data, id))`；返回值紧邻使用处：`AssignmentExpressionSyntax: row.Role.Text = CareerMoney.Display(person.Role + "  /  " + person.Country + "  ·  " + IdentityGender.Of(data, id))`
- `NationalSpire.CareerScreen.OpenPerson(string)`；输入表达式：`OpenPerson(id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenPerson(id)`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubName(data, person.ClubId)`；返回值紧邻使用处：`BinaryExpressionSyntax: person.Character + " / " + EsportsWorld.ClubName(data, person.ClubId)`
- `NationalSpire.IdentityGender.Of(NationalSpire.CareerData, string)`；输入表达式：`IdentityGender.Of(data, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: person.Role + "  /  " + person.Country + "  ·  " + IdentityGender.Of(data, id)`

**赋值（含属性/字段和局部值）：**

- `((Control)row.Avatar.GetParent()).TooltipText` = `CareerEngine.DisplayName(data, id) + " · " + row.Avatar.Identity.Description + "\n查看人物档案"`
- `row.Avatar.Art` = `CareerAvatars.ForPerson(data, id)`
- `row.Avatar.Identity` = `AvatarHonors.ForPerson(data, id)`
- `row.Avatar.Modulate` = `Colors.White`
- `row.Avatar.PersonId` = `id`
- `row.Character.Text` = `CareerMoney.Display(person.Character + " / " + EsportsWorld.ClubName(data, person.ClubId))`
- `row.Name.Text` = `CareerMoney.Display(person.PublicName + "   ↗")`
- `row.Open` = `() => OpenPerson(id)`
- `row.Rating.Text` = `$"最高进阶 {person.MaxAscension}    ·    {person.Rating} 分"`
- `row.RealName.Text` = `CareerMoney.Display(person.Name)`
- `row.RealName.Visible` = `person.Handle.Length > 0 && person.Name.Length > 0`
- `row.Role.Text` = `CareerMoney.Display(person.Role + "  /  " + person.Country + "  ·  " + IdentityGender.Of(data, id))`
