# CeremonyScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`5716755B1DA08318989D1649E40AE747286E13DE35F91FC77141DAF810F0FA25`。来源：[源码](../../CeremonyScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`、`NationalSpire.CeremonyMedallion`。

字段、事件及初始值（源码原样）：

```csharp
private int _ceremonySeason;
private string _ceremonySection = "获奖名单";
private bool _ceremonyRules;
private float _time;
```

<a id="symbol-f5db35fa605b"></a>

## `NationalSpire.CareerScreen.OpenCeremony() — private void OpenCeremony()`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.CeremonyInvitation(NationalSpire.CareerData)`](CeremonyScreen.cs.md#symbol-fe94e59081ff)；[`NationalSpire.CareerScreen.RenderWeeklyDetail(NationalSpire.CareerData)`](WeeklyScreen.cs.md#symbol-b3f0ffc5fb7d)

**调用：** [`NationalSpire.CareerScreen.OpenWorldSection(string)`](CareerNavigation.cs.md#symbol-e41ea7b0d93d)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.OpenWorldSection(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.OpenWorldSection(string)`；输入表达式：`OpenWorldSection("颁奖盛典")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => OpenWorldSection("颁奖盛典")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-96e48591b6f3"></a>

## `NationalSpire.CareerScreen.CeremonyWeeklyCover(NationalSpire.CareerData, NationalSpire.WeeklySlide, bool) — private Control CeremonyWeeklyCover(CareerData data, WeeklySlide slide, bool large)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.WeeklyArt(NationalSpire.WeeklyEdition, NationalSpire.WeeklySlide, bool)`](WeeklyScreen.cs.md#symbol-d6f13958bba4)

**调用：** [`NationalSpire.CareerScreen.CeremonyLine(string, int, Godot.Color, float)`](CeremonyScreen.cs.md#symbol-746b7a635071)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.CeremonyMedallion.CeremonyMedallion()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Ceremonies`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen.CeremonyLine(string, int, Godot.Color, float)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.CeremonyRecord.Season`；`NationalSpire.CeremonyRecord.Year`；`NationalSpire.CeremonyRecord.YearTop`；`NationalSpire.WeeklySlide.CeremonySeason`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation", large ? 10 : 3)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation", large ? 10 : 3);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("172d3d", "d2ac66", 10, large ? 26 : 10))`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("172d3d", "d2ac66", 10, large ? 26 : 10));`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`panel.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(caption)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(caption);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(imprint)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(imprint);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(new CeremonyMedallion { CustomMinimumSize = new Vector2(large ? 112 : 72, large ? 112 : 72),              SizeFlagsHorizontal = SizeFlags.ShrinkCenter, MouseFilter = MouseFilterEnum.Ignore })`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(new CeremonyMedallion { CustomMinimumSize = new Vector2(large ? 112 : 72, large ? 112 : 72),              SizeFlagsHorizontal = SizeFlags.ShrinkCenter, MouseFilter = MouseFilterEnum.Ignore });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(title)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(title);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(box)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(box);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { Name = "CeremonyWeeklyCover", MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { Name = "CeremonyWeeklyCover", MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { Alignment = BoxContainer.AlignmentMode.Center, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { Alignment = BoxContainer.AlignmentMode.Center, MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, 260)`；返回值紧邻使用处：`AssignmentExpressionSyntax: panel.CustomMinimumSize = new Vector2(0, 260)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(large ? 112 : 72, large ? 112 : 72)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(large ? 112 : 72, large ? 112 : 72)`
- `NationalSpire.CareerScreen.CeremonyLine(string, int, Godot.Color, float)`；输入表达式：`CeremonyLine("NATIONAL SPIRE  /  HONOURS", large ? 15 : 10, CareerVisuals.Teal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CeremonyLine("NATIONAL SPIRE  /  HONOURS", large ? 15 : 10, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.CeremonyLine(string, int, Godot.Color, float)`；输入表达式：`CeremonyLine(annual ? "年度荣誉特刊" : "赛季荣誉特刊", large ? 32 : 21, _gold)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CeremonyLine(annual ? "年度荣誉特刊" : "赛季荣誉特刊", large ? 32 : 21, _gold)`
- `NationalSpire.CareerScreen.CeremonyLine(string, int, Godot.Color, float)`；输入表达式：`CeremonyLine(annual ? $"第 {record!.Year} 年 · 年度 TOP 20 与各项大奖" : $"第 {slide.CeremonySeason} 赛季 · 荣誉揭晓", large ? 18 : 12, _ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CeremonyLine(annual ? $"第 {record!.Year} 年 · 年度 TOP 20 与各项大奖" : $"第 {slide.CeremonySeason} 赛季 · 荣誉揭晓", large ? 18 : 12, _ink)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("172d3d", "d2ac66", 10, large ? 26 : 10)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("172d3d", "d2ac66", 10, large ? 26 : 10)`
- `NationalSpire.CeremonyMedallion.CeremonyMedallion()`；输入表达式：`new CeremonyMedallion { CustomMinimumSize = new Vector2(large ? 112 : 72, large ? 112 : 72),              SizeFlagsHorizontal = SizeFlags.ShrinkCenter, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`ArgumentSyntax: new CeremonyMedallion { CustomMinimumSize = new Vector2(large ? 112 : 72, large ? 112 : 72),              SizeFlagsHorizontal = SizeFlags.ShrinkCenter, MouseFilter = MouseFilterEnum.Ignore }`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Ceremonies.FirstOrDefault(c => c.Season == slide.CeremonySeason)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Ceremonies.FirstOrDefault(c => c.Season == slide.CeremonySeason)`

**赋值（含属性/字段和局部值）：**

- `Alignment` = `BoxContainer.AlignmentMode.Center`
- `caption.HorizontalAlignment` = `HorizontalAlignment.Center`
- `CustomMinimumSize` = `new Vector2(large ? 112 : 72, large ? 112 : 72)`
- `imprint.HorizontalAlignment` = `HorizontalAlignment.Center`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Name` = `"CeremonyWeeklyCover"`
- `panel.CustomMinimumSize` = `new Vector2(0, 260)`
- `panel.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsHorizontal` = `SizeFlags.ShrinkCenter`
- `title.HorizontalAlignment` = `HorizontalAlignment.Center`

<a id="symbol-746b7a635071"></a>

## `NationalSpire.CareerScreen.CeremonyLine(string, int, Godot.Color, float) — private static Label CeremonyLine(string value, int size, Color color, float width = 0)`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.CeremonyAwards(NationalSpire.CareerData, NationalSpire.CeremonyRecord)`](CeremonyScreen.cs.md#symbol-554512484279)；[`NationalSpire.CareerScreen.CeremonyHero(NationalSpire.CareerData, NationalSpire.CeremonyRecord)`](CeremonyScreen.cs.md#symbol-7344f4112178)；[`NationalSpire.CareerScreen.CeremonyRanking(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CeremonyRank>)`](CeremonyScreen.cs.md#symbol-73500bb64a58)；[`NationalSpire.CareerScreen.CeremonyWeeklyCover(NationalSpire.CareerData, NationalSpire.WeeklySlide, bool)`](CeremonyScreen.cs.md#symbol-96e48591b6f3)

**调用：** [`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(width, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: label.CustomMinimumSize = new Vector2(width, 0)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(value, size, color)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text(value, size, color)`

**赋值（含属性/字段和局部值）：**

- `label.AutowrapMode` = `TextServer.AutowrapMode.Off`
- `label.ClipText` = `true`
- `label.CustomMinimumSize` = `new Vector2(width, 0)`
- `label.SizeFlagsHorizontal` = `SizeFlags.Fill`
- `label.SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `label.TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`
- `label.TooltipText` = `value`

<a id="symbol-bffce7c9ff06"></a>

## `NationalSpire.CareerScreen.CeremonySelf(NationalSpire.CareerData) — private static string CeremonySelf(CareerData data)`

来源：源码第 47 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Ceremony(NationalSpire.CareerData)`](CeremonyScreen.cs.md#symbol-4a515aec3125)；[`NationalSpire.CareerScreen.CeremonyHero(NationalSpire.CareerData, NationalSpire.CeremonyRecord)`](CeremonyScreen.cs.md#symbol-7344f4112178)；[`NationalSpire.CareerScreen.CeremonyOwn(NationalSpire.CareerData, NationalSpire.CeremonyAward)`](CeremonyScreen.cs.md#symbol-1ef726bb1397)；[`NationalSpire.CareerScreen.CeremonyRanking(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CeremonyRank>)`](CeremonyScreen.cs.md#symbol-73500bb64a58)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.LocalHumanId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-1ef726bb1397"></a>

## `NationalSpire.CareerScreen.CeremonyOwn(NationalSpire.CareerData, NationalSpire.CeremonyAward) — private bool CeremonyOwn(CareerData data, CeremonyAward award)`

来源：源码第 48 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.CeremonyAwards(NationalSpire.CareerData, NationalSpire.CeremonyRecord)`](CeremonyScreen.cs.md#symbol-554512484279)；[`NationalSpire.CareerScreen.CeremonyHero(NationalSpire.CareerData, NationalSpire.CeremonyRecord)`](CeremonyScreen.cs.md#symbol-7344f4112178)；[`NationalSpire.CareerScreen.CeremonyInvitation(NationalSpire.CareerData)`](CeremonyScreen.cs.md#symbol-fe94e59081ff)

**调用：** [`NationalSpire.CareerScreen.CeremonySelf(NationalSpire.CareerData)`](CeremonyScreen.cs.md#symbol-bffce7c9ff06)；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerScreen.CeremonySelf(NationalSpire.CareerData)`；`NationalSpire.CeremonyAward.ClubId`；`NationalSpire.CeremonyAward.Recipients`；`NationalSpire.CeremonyAward.WinnerId`；`NationalSpire.CeremonyAward.WinnerName`；`NationalSpire.EsportsCareer.ClubId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.CeremonySelf(NationalSpire.CareerData)`；输入表达式：`CeremonySelf(data)`；返回值紧邻使用处：`ArgumentSyntax: CeremonySelf(data)`
- `NationalSpire.CareerScreen.CeremonySelf(NationalSpire.CareerData)`；输入表达式：`CeremonySelf(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: award.WinnerId == CeremonySelf(data)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`award.Recipients.Contains(CeremonySelf(data))`；返回值紧邻使用处：`BinaryExpressionSyntax: award.WinnerId == CeremonySelf(data) || award.Recipients.Contains(CeremonySelf(data))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2125ea5bc3b0"></a>

## `NationalSpire.CareerScreen.CeremonyWinner(NationalSpire.CareerData, NationalSpire.CeremonyAward) — private string CeremonyWinner(CareerData data, CeremonyAward award)`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.CeremonyAwards(NationalSpire.CareerData, NationalSpire.CeremonyRecord)`](CeremonyScreen.cs.md#symbol-554512484279)；[`NationalSpire.CareerScreen.CeremonyHero(NationalSpire.CareerData, NationalSpire.CeremonyRecord)`](CeremonyScreen.cs.md#symbol-7344f4112178)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-54b1e9fa0cf0)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.LocalHumanId`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CeremonyAward.ClubId`；`NationalSpire.CeremonyAward.WinnerId`；`NationalSpire.CeremonyAward.WinnerName`；`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, award.WinnerId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: award.WinnerId == "player" && data.LocalHumanId.Length > 0 ? "共同参赛阵容" : CareerEngine.DisplayName(data, award.WinnerId)`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubName(data, award.ClubId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: award.ClubId.Length > 0          ? EsportsWorld.ClubName(data, award.ClubId) : award.WinnerId == "player" && data.LocalHumanId.Length > 0 ? "共同参赛阵容" : CareerEngine.DisplayName(data, award.WinnerId)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-fe94e59081ff"></a>

## `NationalSpire.CareerScreen.CeremonyInvitation(NationalSpire.CareerData) — private void CeremonyInvitation(CareerData data)`

来源：源码第 55 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.Honors(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-fd656e0e98e6)

**调用：** [`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.CeremonyOwn(NationalSpire.CareerData, NationalSpire.CeremonyAward)`](CeremonyScreen.cs.md#symbol-1ef726bb1397)；[`NationalSpire.CareerScreen.Emphasize(Godot.Button)`](BroadcastVisuals.cs.md#symbol-ddd68d13b687)；[`NationalSpire.CareerScreen.OpenCeremony()`](CeremonyScreen.cs.md#symbol-f5db35fa605b)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.CeremonyMedallion.CeremonyMedallion()`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Ceremonies`；`NationalSpire.CareerScreen._ceremonySeason`；`NationalSpire.CareerScreen._ceremonySection`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.CeremonyOwn(NationalSpire.CareerData, NationalSpire.CeremonyAward)`；`NationalSpire.CareerScreen.Emphasize(Godot.Button)`；`NationalSpire.CareerScreen.OpenCeremony()`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CeremonyAward.Title`；`NationalSpire.CeremonyRecord.Awards`；`NationalSpire.CeremonyRecord.Season`；`NationalSpire.CeremonyRecord.Year`；`NationalSpire.CeremonyRecord.YearTop`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 20)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 20);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("202f37", "8d794f", 10, 20))`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("202f37", "8d794f", 10, 20));`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`caption.AddChild(Text(latest == null ? "赛季颁奖盛典" : latest.YearTop.Count > 0              ? $"第 {latest.Year} 年度荣誉之夜" : $"第 {latest.Season} 赛季 · 荣誉揭晓", 23, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: caption.AddChild(Text(latest == null ? "赛季颁奖盛典" : latest.YearTop.Count > 0              ? $"第 {latest.Year} 年度荣誉之夜" : $"第 {latest.Season} 赛季 · 荣誉揭晓", 23, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`caption.AddChild(Text(latest == null ? "赛季结束后揭晓奖项，历届荣誉在这里保存。"              : honors.Length > 0 ? "你的本届荣誉  ·  " + honors : "本届获奖名单与选手排名已经公布。", 16, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: caption.AddChild(Text(latest == null ? "赛季结束后揭晓奖项，历届荣誉在这里保存。"              : honors.Length > 0 ? "你的本届荣誉  ·  " + honors : "本届获奖名单与选手排名已经公布。", 16, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`card.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(caption)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(caption);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(enter)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(enter);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(new CeremonyMedallion { CustomMinimumSize = new Vector2(72, 72), SizeFlagsVertical = SizeFlags.ShrinkCenter })`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(new CeremonyMedallion { CustomMinimumSize = new Vector2(72, 72), SizeFlagsVertical = SizeFlags.ShrinkCenter });`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(72, 72)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(72, 72)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button(latest == null ? "查看盛典   →" : "查看本届盛典   →", () =>          { _ceremonySeason = latest?.Season ?? 0; _ceremonySection = "获奖名单"; OpenCeremony(); }, 210)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button(latest == null ? "查看盛典   →" : "查看本届盛典   →", () =>          { _ceremonySeason = latest?.Season ?? 0; _ceremonySection = "获奖名单"; OpenCeremony(); }, 210)`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.CeremonyOwn(NationalSpire.CareerData, NationalSpire.CeremonyAward)`；输入表达式：`CeremonyOwn(data, a)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: a => CeremonyOwn(data, a)`
- `NationalSpire.CareerScreen.Emphasize(Godot.Button)`；输入表达式：`Emphasize(enter)`；返回值紧邻使用处：`ExpressionStatementSyntax: Emphasize(enter);`
- `NationalSpire.CareerScreen.OpenCeremony()`；输入表达式：`OpenCeremony()`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenCeremony();`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(latest == null ? "赛季颁奖盛典" : latest.YearTop.Count > 0              ? $"第 {latest.Year} 年度荣誉之夜" : $"第 {latest.Season} 赛季 · 荣誉揭晓", 23, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(latest == null ? "赛季颁奖盛典" : latest.YearTop.Count > 0              ? $"第 {latest.Year} 年度荣誉之夜" : $"第 {latest.Season} 赛季 · 荣誉揭晓", 23, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(latest == null ? "赛季结束后揭晓奖项，历届荣誉在这里保存。"              : honors.Length > 0 ? "你的本届荣誉  ·  " + honors : "本届获奖名单与选手排名已经公布。", 16, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(latest == null ? "赛季结束后揭晓奖项，历届荣誉在这里保存。"              : honors.Length > 0 ? "你的本届荣誉  ·  " + honors : "本届获奖名单与选手排名已经公布。", 16, _ink)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("202f37", "8d794f", 10, 20)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("202f37", "8d794f", 10, 20)`
- `NationalSpire.CeremonyMedallion.CeremonyMedallion()`；输入表达式：`new CeremonyMedallion { CustomMinimumSize = new Vector2(72, 72), SizeFlagsVertical = SizeFlags.ShrinkCenter }`；返回值紧邻使用处：`ArgumentSyntax: new CeremonyMedallion { CustomMinimumSize = new Vector2(72, 72), SizeFlagsVertical = SizeFlags.ShrinkCenter }`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join(" · ", latest.Awards.Where(a => CeremonyOwn(data, a)).Select(a => a.Title))`；返回值紧邻使用处：`ConditionalExpressionSyntax: latest == null ? "" : string.Join(" · ", latest.Awards.Where(a => CeremonyOwn(data, a)).Select(a => a.Title))`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`data.Ceremonies.OrderByDescending(c => c.Season).FirstOrDefault()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Ceremonies.OrderByDescending(c => c.Season).FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`data.Ceremonies.OrderByDescending(c => c.Season)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Ceremonies.OrderByDescending(c => c.Season).FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`latest.Awards.Where(a => CeremonyOwn(data, a)).Select(a => a.Title)`；返回值紧邻使用处：`ArgumentSyntax: latest.Awards.Where(a => CeremonyOwn(data, a)).Select(a => a.Title)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`latest.Awards.Where(a => CeremonyOwn(data, a))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: latest.Awards.Where(a => CeremonyOwn(data, a)).Select`

**赋值（含属性/字段和局部值）：**

- `_ceremonySeason` = `latest?.Season ?? 0`
- `_ceremonySection` = `"获奖名单"`
- `card.Name` = `"CeremonyInvitation"`
- `CustomMinimumSize` = `new Vector2(72, 72)`
- `enter.SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`

<a id="symbol-4a515aec3125"></a>

## `NationalSpire.CareerScreen.Ceremony(NationalSpire.CareerData) — private void Ceremony(CareerData data)`

来源：源码第 74 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.World(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-ce5a79e2aa5c)

**调用：** [`NationalSpire.CareerScreen.AddHeading(string, string)`](CareerScreen.cs.md#symbol-40a63c9955a7)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.CeremonyAwards(NationalSpire.CareerData, NationalSpire.CeremonyRecord)`](CeremonyScreen.cs.md#symbol-554512484279)；[`NationalSpire.CareerScreen.CeremonyHero(NationalSpire.CareerData, NationalSpire.CeremonyRecord)`](CeremonyScreen.cs.md#symbol-7344f4112178)；[`NationalSpire.CareerScreen.CeremonyRanking(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CeremonyRank>)`](CeremonyScreen.cs.md#symbol-73500bb64a58)；[`NationalSpire.CareerScreen.CeremonySelf(NationalSpire.CareerData)`](CeremonyScreen.cs.md#symbol-bffce7c9ff06)；[`NationalSpire.CareerScreen.Emphasize(Godot.Button)`](BroadcastVisuals.cs.md#symbol-ddd68d13b687)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.OpenWorldSection(string)`](CareerNavigation.cs.md#symbol-e41ea7b0d93d)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`](CareerScreen.cs.md#symbol-9df94d88557a)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.Control()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.GetItemId(int)`；`Godot.OptionButton.OptionButton()`；`Godot.OptionButton.Select(int)`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；`System.Collections.Generic.List<T>.List()`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Ceremonies`；`NationalSpire.CareerScreen._ceremonyRules`；`NationalSpire.CareerScreen._ceremonySeason`；`NationalSpire.CareerScreen._ceremonySection`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._renderVersion`；`NationalSpire.CareerScreen._scroll`；`NationalSpire.CareerScreen.AddHeading(string, string)`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.CeremonyAwards(NationalSpire.CareerData, NationalSpire.CeremonyRecord)`；`NationalSpire.CareerScreen.CeremonyHero(NationalSpire.CareerData, NationalSpire.CeremonyRecord)`；`NationalSpire.CareerScreen.CeremonyRanking(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CeremonyRank>)`；`NationalSpire.CareerScreen.CeremonySelf(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.Emphasize(Godot.Button)`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.OpenWorldSection(string)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CeremonyRank.Breakdown`；`NationalSpire.CeremonyRank.Id`；`NationalSpire.CeremonyRecord.FullSeason`；`NationalSpire.CeremonyRecord.FullYear`；`NationalSpire.CeremonyRecord.RulesVersion`；`NationalSpire.CeremonyRecord.Season`；`NationalSpire.CeremonyRecord.SeasonTop`；`NationalSpire.CeremonyRecord.Year`；`NationalSpire.CeremonyRecord.YearTop`；`NationalSpire.SeasonCeremony.ClubRules`；`NationalSpire.SeasonCeremony.ScoringRules`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`controls.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: controls.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`sections.AddThemeConstantOverride("separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: sections.AddThemeConstantOverride("separation", 10);`
- `Godot.Control.Control()`；输入表达式：`new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`ArgumentSyntax: new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { Name = "CeremonySections" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { Name = "CeremonySections" }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(controls)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(controls);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(method)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(method);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(rules)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(rules);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(sections)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(sections);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`controls.AddChild(Button("荣誉室", () => OpenWorldSection("荣誉室"), 120))`；返回值紧邻使用处：`ExpressionStatementSyntax: controls.AddChild(Button("荣誉室", () => OpenWorldSection("荣誉室"), 120));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`controls.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill })`；返回值紧邻使用处：`ExpressionStatementSyntax: controls.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`controls.AddChild(selection)`；返回值紧邻使用处：`ExpressionStatementSyntax: controls.AddChild(selection);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`explanation.AddChild(Text(line, 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: explanation.AddChild(Text(line, 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`explanation.AddChild(Text(record.RulesVersion >= 2 ? SeasonCeremony.ScoringRules : "此届按旧版规则授予，保留原始得分与荣誉。新规则从更新后举行的盛典执行。", 16, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: explanation.AddChild(Text(record.RulesVersion >= 2 ? SeasonCeremony.ScoringRules : "此届按旧版规则授予，保留原始得分与荣誉。新规则从更新后举行的盛典执行。", 16, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`explanation.AddChild(Text(SeasonCeremony.ClubRules + "新秀以首次职业参赛记录为准，至少出场两次。", 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: explanation.AddChild(Text(SeasonCeremony.ClubRules + "新秀以首次职业参赛记录为准，至少出场两次。", 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`sections.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: sections.AddChild(button);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`selection.AddItem(item.YearTop.Count > 0                  ? $"第 {item.Year} 年度 · 第 {item.Season} 赛季" : $"第 {item.Season} 赛季", item.Season)`；返回值紧邻使用处：`ExpressionStatementSyntax: selection.AddItem(item.YearTop.Count > 0                  ? $"第 {item.Year} 年度 · 第 {item.Season} 赛季" : $"第 {item.Season} 赛季", item.Season);`
- `Godot.OptionButton.GetItemId(int)`；输入表达式：`selection.GetItemId((int)chosen)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ceremonySeason = selection.GetItemId((int)chosen)`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { Name = "CeremonyArchive", CustomMinimumSize = new Vector2(240, 48) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { Name = "CeremonyArchive", CustomMinimumSize = new Vector2(240, 48) }`
- `Godot.OptionButton.Select(int)`；输入表达式：`selection.Select(Math.Max(0, archives.FindIndex(c => c.Season == record?.Season)))`；返回值紧邻使用处：`ExpressionStatementSyntax: selection.Select(Math.Max(0, archives.FindIndex(c => c.Season == record?.Season)));`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(240, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(240, 48)`
- `NationalSpire.CareerScreen.AddHeading(string, string)`；输入表达式：`AddHeading("赛季颁奖盛典", "第一个赛季结束后揭晓奖项，并自动展示本届盛典。")`；返回值紧邻使用处：`ExpressionStatementSyntax: AddHeading("赛季颁奖盛典", "第一个赛季结束后揭晓奖项，并自动展示本届盛典。");`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button(_ceremonyRules ? "收起评选依据" : "查看评选依据", () =>          { int y = _scroll.ScrollVertical; _ceremonyRules = !_ceremonyRules; Render(); _ = RestoreScrollAsync(y, _renderVersion); }, 180)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button(_ceremonyRules ? "收起评选依据" : "查看评选依据", () =>          { int y = _scroll.ScrollVertical; _ceremonyRules = !_ceremonyRules; Render(); _ = RestoreScrollAsync(y, _renderVersion); }, 180)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("荣誉室", () => OpenWorldSection("荣誉室"), 120)`；返回值紧邻使用处：`ArgumentSyntax: Button("荣誉室", () => OpenWorldSection("荣誉室"), 120)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button(section, () => { _ceremonySection = section; _scroll.ScrollVertical = 0; Render(); }, 180)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button(section, () => { _ceremonySection = section; _scroll.ScrollVertical = 0; Render(); }, 180)`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.CeremonyAwards(NationalSpire.CareerData, NationalSpire.CeremonyRecord)`；输入表达式：`CeremonyAwards(data, record)`；返回值紧邻使用处：`ExpressionStatementSyntax: CeremonyAwards(data, record);`
- `NationalSpire.CareerScreen.CeremonyHero(NationalSpire.CareerData, NationalSpire.CeremonyRecord)`；输入表达式：`CeremonyHero(data, record)`；返回值紧邻使用处：`ExpressionStatementSyntax: CeremonyHero(data, record);`
- `NationalSpire.CareerScreen.CeremonyRanking(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CeremonyRank>)`；输入表达式：`CeremonyRanking(data, _ceremonySection == "年度 TOP 20" ? (record.FullYear.Count > 0 ? record.FullYear : record.YearTop) : (record.FullSeason.Count > 0 ? record.FullSeason : record.SeasonTop))`；返回值紧邻使用处：`ExpressionStatementSyntax: CeremonyRanking(data, _ceremonySection == "年度 TOP 20" ? (record.FullYear.Count > 0 ? record.FullYear : record.YearTop) : (record.FullSeason.Count > 0 ? record.FullSeason : record.SeasonTop));`
- `NationalSpire.CareerScreen.CeremonySelf(NationalSpire.CareerData)`；输入表达式：`CeremonySelf(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: r.Id==CeremonySelf(data)`
- `NationalSpire.CareerScreen.Emphasize(Godot.Button)`；输入表达式：`Emphasize(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: Emphasize(button);`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(method)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(method)`
- `NationalSpire.CareerScreen.OpenWorldSection(string)`；输入表达式：`OpenWorldSection("荣誉室")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenWorldSection("荣誉室")`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`；输入表达式：`RestoreScrollAsync(y, _renderVersion)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = RestoreScrollAsync(y, _renderVersion)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(line, 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(line, 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(record.RulesVersion >= 2 ? SeasonCeremony.ScoringRules : "此届按旧版规则授予，保留原始得分与荣誉。新规则从更新后举行的盛典执行。", 16, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(record.RulesVersion >= 2 ? SeasonCeremony.ScoringRules : "此届按旧版规则授予，保留原始得分与荣誉。新规则从更新后举行的盛典执行。", 16, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(SeasonCeremony.ClubRules + "新秀以首次职业参赛记录为准，至少出场两次。", 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(SeasonCeremony.ClubRules + "新秀以首次职业参赛记录为准，至少出场两次。", 16, _muted)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`archives.FirstOrDefault()`；返回值紧邻使用处：`BinaryExpressionSyntax: archives.FirstOrDefault(c => c.Season == _ceremonySeason) ?? archives.FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`(_ceremonySection == "年度 TOP 20" ? record.FullYear : record.FullSeason).FirstOrDefault(r=>r.Id==CeremonySelf(data))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = (_ceremonySection == "年度 TOP 20" ? record.FullYear : record.FullSeason).FirstOrDefault(r=>r.Id==CeremonySelf(data))`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`archives.FirstOrDefault(c => c.Season == _ceremonySeason)`；返回值紧邻使用处：`BinaryExpressionSyntax: archives.FirstOrDefault(c => c.Season == _ceremonySeason) ?? archives.FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`data.Ceremonies.OrderByDescending(c => c.Season)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Ceremonies.OrderByDescending(c => c.Season).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`data.Ceremonies.OrderByDescending(c => c.Season).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Ceremonies.OrderByDescending(c => c.Season).ToList()`
- `System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；输入表达式：`archives.FindIndex(c => c.Season == record?.Season)`；返回值紧邻使用处：`ArgumentSyntax: archives.FindIndex(c => c.Season == record?.Season)`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<string> { "获奖名单", "本季排名" }`；返回值紧邻使用处：`ConditionalExpressionSyntax: record.YearTop.Count > 0 ? new List<string> { "获奖名单", "年度 TOP 20", "本季排名" } : new List<string> { "获奖名单", "本季排名" }`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<string> { "获奖名单", "年度 TOP 20", "本季排名" }`；返回值紧邻使用处：`ConditionalExpressionSyntax: record.YearTop.Count > 0 ? new List<string> { "获奖名单", "年度 TOP 20", "本季排名" } : new List<string> { "获奖名单", "本季排名" }`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, archives.FindIndex(c => c.Season == record?.Season))`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, archives.FindIndex(c => c.Season == record?.Season))`

**赋值（含属性/字段和局部值）：**

- `_` = `RestoreScrollAsync(y, _renderVersion)`
- `_ceremonyRules` = `!_ceremonyRules`
- `_ceremonySeason` = `selection.GetItemId((int)chosen)`
- `_ceremonySection` = `"本季排名"`
- `_ceremonySection` = `section`
- `_scroll.ScrollVertical` = `0`
- `CustomMinimumSize` = `new Vector2(240, 48)`
- `Name` = `"CeremonyArchive"`
- `Name` = `"CeremonySections"`
- `selection.ItemSelected` += `chosen =>              { _ceremonySeason = selection.GetItemId((int)chosen); _scroll.ScrollVertical = 0; Render(); }`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-7344f4112178"></a>

## `NationalSpire.CareerScreen.CeremonyHero(NationalSpire.CareerData, NationalSpire.CeremonyRecord) — private void CeremonyHero(CareerData data, CeremonyRecord record)`

来源：源码第 122 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Ceremony(NationalSpire.CareerData)`](CeremonyScreen.cs.md#symbol-4a515aec3125)

**调用：** [`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`](CareerAvatars.cs.md#symbol-9f2c4623a902)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.CeremonyLine(string, int, Godot.Color, float)`](CeremonyScreen.cs.md#symbol-746b7a635071)；[`NationalSpire.CareerScreen.CeremonyOwn(NationalSpire.CareerData, NationalSpire.CeremonyAward)`](CeremonyScreen.cs.md#symbol-1ef726bb1397)；[`NationalSpire.CareerScreen.CeremonySelf(NationalSpire.CareerData)`](CeremonyScreen.cs.md#symbol-bffce7c9ff06)；[`NationalSpire.CareerScreen.CeremonyWinner(NationalSpire.CareerData, NationalSpire.CeremonyAward)`](CeremonyScreen.cs.md#symbol-2125ea5bc3b0)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Color.Color(string)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.CeremonyMedallion.CeremonyMedallion()`；`string.StartsWith(string)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastPanel.Accent`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.CeremonyLine(string, int, Godot.Color, float)`；`NationalSpire.CareerScreen.CeremonyOwn(NationalSpire.CareerData, NationalSpire.CeremonyAward)`；`NationalSpire.CareerScreen.CeremonySelf(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.CeremonyWinner(NationalSpire.CareerData, NationalSpire.CeremonyAward)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.CeremonyAward.Title`；`NationalSpire.CeremonyAward.WinnerId`；`NationalSpire.CeremonyMedallion.ShowCrown`；`NationalSpire.CeremonyRank.Id`；`NationalSpire.CeremonyRank.Place`；`NationalSpire.CeremonyRecord.Awards`；`NationalSpire.CeremonyRecord.Season`；`NationalSpire.CeremonyRecord.Year`；`NationalSpire.CeremonyRecord.YearTop`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("e5bc72")`；返回值紧邻使用处：`AssignmentExpressionSyntax: panel.Accent = new Color("e5bc72")`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`opening.AddThemeConstantOverride("separation", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: opening.AddThemeConstantOverride("separation", 8);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`stage.AddThemeConstantOverride("separation", 28)`；返回值紧邻使用处：`ExpressionStatementSyntax: stage.AddThemeConstantOverride("separation", 28);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`hero.AddThemeStyleboxOverride("panel", CareerVisuals.Box("1e303d", "c4a56b", 12, 26))`；返回值紧邻使用处：`ExpressionStatementSyntax: hero.AddThemeStyleboxOverride("panel", CareerVisuals.Box("1e303d", "c4a56b", 12, 26));`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`portrait.SetAnchorsAndOffsetsPreset(LayoutPreset.Center)`；返回值紧邻使用处：`ExpressionStatementSyntax: portrait.SetAnchorsAndOffsetsPreset(LayoutPreset.Center);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(hero)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(hero);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`hero.AddChild(stage)`；返回值紧邻使用处：`ExpressionStatementSyntax: hero.AddChild(stage);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`medal.AddChild(portrait)`；返回值紧邻使用处：`ExpressionStatementSyntax: medal.AddChild(portrait);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`opening.AddChild(CeremonyLine($"NATIONAL SPIRE   /   SEASON {record.Season:00}", 13, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: opening.AddChild(CeremonyLine($"NATIONAL SPIRE   /   SEASON {record.Season:00}", 13, CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`opening.AddChild(Text($"你入选年度 TOP 20 · 第 {annualTop.Place} 名 · 关注 +120", 24, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: opening.AddChild(Text($"你入选年度 TOP 20 · 第 {annualTop.Place} 名 · 关注 +120", 24, CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`opening.AddChild(Text(CeremonyWinner(data, feature) + "  ·  " + feature.Title, 24, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: opening.AddChild(Text(CeremonyWinner(data, feature) + "  ·  " + feature.Title, 24, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`opening.AddChild(Text(personal.Count > 0 ? $"你在本届获得 {personal.Count} 项荣誉，成绩已收入生涯档案。"              : "本届荣誉已经揭晓，正式比赛的每一份成绩都有记录。", 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: opening.AddChild(Text(personal.Count > 0 ? $"你在本届获得 {personal.Count} 项荣誉，成绩已收入生涯档案。"              : "本届荣誉已经揭晓，正式比赛的每一份成绩都有记录。", 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`opening.AddChild(Text(record.YearTop.Count > 0 ? $"第 {record.Year} 年度荣誉之夜" : $"第 {record.Season} 赛季 · 颁奖盛典", 32, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: opening.AddChild(Text(record.YearTop.Count > 0 ? $"第 {record.Year} 年度荣誉之夜" : $"第 {record.Season} 赛季 · 颁奖盛典", 32, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`stage.AddChild(medal)`；返回值紧邻使用处：`ExpressionStatementSyntax: stage.AddChild(medal);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`stage.AddChild(opening)`；返回值紧邻使用处：`ExpressionStatementSyntax: stage.AddChild(opening);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(152, 174)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(152, 174)`
- `NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`；输入表达式：`Avatar(data, feature.WinnerId, 76, true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Avatar(data, feature.WinnerId, 76, true)`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.CeremonyLine(string, int, Godot.Color, float)`；输入表达式：`CeremonyLine($"NATIONAL SPIRE   /   SEASON {record.Season:00}", 13, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: CeremonyLine($"NATIONAL SPIRE   /   SEASON {record.Season:00}", 13, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.CeremonyOwn(NationalSpire.CareerData, NationalSpire.CeremonyAward)`；输入表达式：`CeremonyOwn(data, a)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: a => CeremonyOwn(data, a)`
- `NationalSpire.CareerScreen.CeremonySelf(NationalSpire.CareerData)`；输入表达式：`CeremonySelf(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: a.WinnerId == CeremonySelf(data)`
- `NationalSpire.CareerScreen.CeremonySelf(NationalSpire.CareerData)`；输入表达式：`CeremonySelf(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: r.Id == CeremonySelf(data)`
- `NationalSpire.CareerScreen.CeremonyWinner(NationalSpire.CareerData, NationalSpire.CeremonyAward)`；输入表达式：`CeremonyWinner(data, feature)`；返回值紧邻使用处：`BinaryExpressionSyntax: CeremonyWinner(data, feature) + "  ·  "`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"你入选年度 TOP 20 · 第 {annualTop.Place} 名 · 关注 +120", 24, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Text($"你入选年度 TOP 20 · 第 {annualTop.Place} 名 · 关注 +120", 24, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(CeremonyWinner(data, feature) + "  ·  " + feature.Title, 24, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(CeremonyWinner(data, feature) + "  ·  " + feature.Title, 24, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(personal.Count > 0 ? $"你在本届获得 {personal.Count} 项荣誉，成绩已收入生涯档案。"              : "本届荣誉已经揭晓，正式比赛的每一份成绩都有记录。", 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(personal.Count > 0 ? $"你在本届获得 {personal.Count} 项荣誉，成绩已收入生涯档案。"              : "本届荣誉已经揭晓，正式比赛的每一份成绩都有记录。", 16, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(record.YearTop.Count > 0 ? $"第 {record.Year} 年度荣誉之夜" : $"第 {record.Season} 赛季 · 颁奖盛典", 32, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(record.YearTop.Count > 0 ? $"第 {record.Year} 年度荣誉之夜" : $"第 {record.Season} 赛季 · 颁奖盛典", 32, _gold)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("1e303d", "c4a56b", 12, 26)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("1e303d", "c4a56b", 12, 26)`
- `NationalSpire.CeremonyMedallion.CeremonyMedallion()`；输入表达式：`new CeremonyMedallion { CustomMinimumSize = new Vector2(152, 174), SizeFlagsVertical = SizeFlags.ShrinkCenter }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CeremonyMedallion { CustomMinimumSize = new Vector2(152, 174), SizeFlagsVertical = SizeFlags.ShrinkCenter }`
- `string.StartsWith(string)`；输入表达式：`a.Title.StartsWith("年度")`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: a => a.Title.StartsWith("年度")`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`personal.FirstOrDefault()`；返回值紧邻使用处：`BinaryExpressionSyntax: personal.FirstOrDefault() ?? record.Awards.OrderByDescending(a => a.Title.StartsWith("年度")).FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`record.Awards.OrderByDescending(a => a.Title.StartsWith("年度")).FirstOrDefault()`；返回值紧邻使用处：`BinaryExpressionSyntax: personal.FirstOrDefault() ?? record.Awards.OrderByDescending(a => a.Title.StartsWith("年度")).FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`personal.FirstOrDefault(a => a.WinnerId == CeremonySelf(data))`；返回值紧邻使用处：`BinaryExpressionSyntax: personal.FirstOrDefault(a => a.WinnerId == CeremonySelf(data)) ?? personal.FirstOrDefault() ?? record.Awards.OrderByDescending(a => a.Title.StartsWith("年度")).FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`record.YearTop.FirstOrDefault(r => r.Id == CeremonySelf(data))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = record.YearTop.FirstOrDefault(r => r.Id == CeremonySelf(data))`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`record.Awards.OrderByDescending(a => a.Title.StartsWith("年度"))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: record.Awards.OrderByDescending(a => a.Title.StartsWith("年度")).FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`record.Awards.Where(a => CeremonyOwn(data, a)).OrderByDescending(a => a.Title.StartsWith("年度"))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: record.Awards.Where(a => CeremonyOwn(data, a)).OrderByDescending(a => a.Title.StartsWith("年度")).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`record.Awards.Where(a => CeremonyOwn(data, a)).OrderByDescending(a => a.Title.StartsWith("年度")).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = record.Awards.Where(a => CeremonyOwn(data, a)).OrderByDescending(a => a.Title.StartsWith("年度")).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`record.Awards.Where(a => CeremonyOwn(data, a))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: record.Awards.Where(a => CeremonyOwn(data, a)).OrderByDescending`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new Vector2(152, 174)`
- `hero.Name` = `"CeremonyHero"`
- `medal.ShowCrown` = `false`
- `panel.Accent` = `new Color("e5bc72")`
- `portrait.OffsetBottom` = `38`
- `portrait.OffsetLeft` = `portrait.OffsetTop = -38`
- `portrait.OffsetRight` = `portrait.OffsetBottom = 38`
- `portrait.OffsetTop` = `-38`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`

<a id="symbol-554512484279"></a>

## `NationalSpire.CareerScreen.CeremonyAwards(NationalSpire.CareerData, NationalSpire.CeremonyRecord) — private void CeremonyAwards(CareerData data, CeremonyRecord record)`

来源：源码第 150 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Ceremony(NationalSpire.CareerData)`](CeremonyScreen.cs.md#symbol-4a515aec3125)

**调用：** [`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`](CareerAvatars.cs.md#symbol-9f2c4623a902)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.CeremonyLine(string, int, Godot.Color, float)`](CeremonyScreen.cs.md#symbol-746b7a635071)；[`NationalSpire.CareerScreen.CeremonyOwn(NationalSpire.CareerData, NationalSpire.CeremonyAward)`](CeremonyScreen.cs.md#symbol-1ef726bb1397)；[`NationalSpire.CareerScreen.CeremonyWinner(NationalSpire.CareerData, NationalSpire.CeremonyAward)`](CeremonyScreen.cs.md#symbol-2125ea5bc3b0)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.SeasonCeremony.RewardAmount(NationalSpire.CeremonyAward)`](SeasonCeremony.cs.md#symbol-728070e4daae)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.GridContainer.GridContainer()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.CeremonyMedallion.CeremonyMedallion()`；`string.Replace(char, char)`；`string.StartsWith(string)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastPanel.Accent`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.CeremonyLine(string, int, Godot.Color, float)`；`NationalSpire.CareerScreen.CeremonyOwn(NationalSpire.CareerData, NationalSpire.CeremonyAward)`；`NationalSpire.CareerScreen.CeremonyWinner(NationalSpire.CareerData, NationalSpire.CeremonyAward)`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.CeremonyAward.Reason`；`NationalSpire.CeremonyAward.Score`；`NationalSpire.CeremonyAward.Title`；`NationalSpire.CeremonyAward.WinnerId`；`NationalSpire.CeremonyRecord.Awards`；`NationalSpire.SeasonCeremony.RewardAmount(NationalSpire.CeremonyAward)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("h_separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("h_separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("v_separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("v_separation", 16);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 16)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 16);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`card.AddThemeStyleboxOverride("panel", CareerVisuals.Box(own ? "243b3d" : "142737", own ? "bfa266" : "3d5665", 10, 22))`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddThemeStyleboxOverride("panel", CareerVisuals.Box(own ? "243b3d" : "142737", own ? "bfa266" : "3d5665", 10, 22));`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer { Name = "CeremonyAwardGrid", Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GridContainer { Name = "CeremonyAwardGrid", Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(grid)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(grid);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("本季正式比赛尚不足以评出奖项。赛季记录已经保留。", 18, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("本季正式比赛尚不足以评出奖项。赛季记录已经保留。", 18, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text($"获奖关注 +{SeasonCeremony.RewardAmount(award)} · 已收入荣誉档案", 15, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text($"获奖关注 +{SeasonCeremony.RewardAmount(award)} · 已收入荣誉档案", 15, CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(award.Reason, 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(award.Reason, 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(title)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(title);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`grid.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`identity.AddChild(CeremonyLine($"评选得分  {award.Score}", 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: identity.AddChild(CeremonyLine($"评选得分  {award.Score}", 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`identity.AddChild(name)`；返回值紧邻使用处：`ExpressionStatementSyntax: identity.AddChild(name);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(Avatar(data, award.WinnerId, 62, true))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(Avatar(data, award.WinnerId, 62, true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(identity)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(identity);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(new CeremonyMedallion { CustomMinimumSize = new Vector2(62, 62) })`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(new CeremonyMedallion { CustomMinimumSize = new Vector2(62, 62) });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`title.AddChild(CeremonyLine("你的荣誉", 13, CareerVisuals.Teal, 72))`；返回值紧邻使用处：`ExpressionStatementSyntax: title.AddChild(CeremonyLine("你的荣誉", 13, CareerVisuals.Teal, 72));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`title.AddChild(CeremonyLine(award.Title, 20, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: title.AddChild(CeremonyLine(award.Title, 20, _gold));`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsVertical = SizeFlags.ShrinkCenter }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsVertical = SizeFlags.ShrinkCenter }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, 186)`；返回值紧邻使用处：`AssignmentExpressionSyntax: card.CustomMinimumSize = new Vector2(0, 186)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(62, 62)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(62, 62)`
- `NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`；输入表达式：`Avatar(data, award.WinnerId, 62, true)`；返回值紧邻使用处：`ArgumentSyntax: Avatar(data, award.WinnerId, 62, true)`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.CeremonyLine(string, int, Godot.Color, float)`；输入表达式：`CeremonyLine("你的荣誉", 13, CareerVisuals.Teal, 72)`；返回值紧邻使用处：`ArgumentSyntax: CeremonyLine("你的荣誉", 13, CareerVisuals.Teal, 72)`
- `NationalSpire.CareerScreen.CeremonyLine(string, int, Godot.Color, float)`；输入表达式：`CeremonyLine($"评选得分  {award.Score}", 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: CeremonyLine($"评选得分  {award.Score}", 15, _muted)`
- `NationalSpire.CareerScreen.CeremonyLine(string, int, Godot.Color, float)`；输入表达式：`CeremonyLine(award.Title, 20, _gold)`；返回值紧邻使用处：`ArgumentSyntax: CeremonyLine(award.Title, 20, _gold)`
- `NationalSpire.CareerScreen.CeremonyLine(string, int, Godot.Color, float)`；输入表达式：`CeremonyLine(CeremonyWinner(data, award), 25, _ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CeremonyLine(CeremonyWinner(data, award), 25, _ink)`
- `NationalSpire.CareerScreen.CeremonyOwn(NationalSpire.CareerData, NationalSpire.CeremonyAward)`；输入表达式：`CeremonyOwn(data, a)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: a => CeremonyOwn(data, a)`
- `NationalSpire.CareerScreen.CeremonyOwn(NationalSpire.CareerData, NationalSpire.CeremonyAward)`；输入表达式：`CeremonyOwn(data, award)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CeremonyOwn(data, award)`
- `NationalSpire.CareerScreen.CeremonyWinner(NationalSpire.CareerData, NationalSpire.CeremonyAward)`；输入表达式：`CeremonyWinner(data, award)`；返回值紧邻使用处：`ArgumentSyntax: CeremonyWinner(data, award)`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(card)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(card)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("本季正式比赛尚不足以评出奖项。赛季记录已经保留。", 18, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("本季正式比赛尚不足以评出奖项。赛季记录已经保留。", 18, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"获奖关注 +{SeasonCeremony.RewardAmount(award)} · 已收入荣誉档案", 15, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Text($"获奖关注 +{SeasonCeremony.RewardAmount(award)} · 已收入荣誉档案", 15, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(award.Reason, 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(award.Reason, 15, _muted)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box(own ? "243b3d" : "142737", own ? "bfa266" : "3d5665", 10, 22)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box(own ? "243b3d" : "142737", own ? "bfa266" : "3d5665", 10, 22)`
- `NationalSpire.CeremonyMedallion.CeremonyMedallion()`；输入表达式：`new CeremonyMedallion { CustomMinimumSize = new Vector2(62, 62) }`；返回值紧邻使用处：`ArgumentSyntax: new CeremonyMedallion { CustomMinimumSize = new Vector2(62, 62) }`
- `NationalSpire.SeasonCeremony.RewardAmount(NationalSpire.CeremonyAward)`；输入表达式：`SeasonCeremony.RewardAmount(award)`；返回值紧邻使用处：`InterpolationSyntax: {SeasonCeremony.RewardAmount(award)}`
- `string.Replace(char, char)`；输入表达式：`award.Title.Replace(' ', '_')`；返回值紧邻使用处：`BinaryExpressionSyntax: "CeremonyAward_" + award.Title.Replace(' ', '_')`
- `string.StartsWith(string)`；输入表达式：`a.Title.StartsWith("年度")`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: a => a.Title.StartsWith("年度")`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`record.Awards.OrderByDescending(a => CeremonyOwn(data, a))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: record.Awards.OrderByDescending(a => CeremonyOwn(data, a)).ThenByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`record.Awards.OrderByDescending(a => CeremonyOwn(data, a)).ThenByDescending(a => a.Title.StartsWith("年度")).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = record.Awards.OrderByDescending(a => CeremonyOwn(data, a)).ThenByDescending(a => a.Title.StartsWith("年度")).ToList()`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`record.Awards.OrderByDescending(a => CeremonyOwn(data, a)).ThenByDescending(a => a.Title.StartsWith("年度"))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: record.Awards.OrderByDescending(a => CeremonyOwn(data, a)).ThenByDescending(a => a.Title.StartsWith("年度")).ToList`

**赋值（含属性/字段和局部值）：**

- `card.CustomMinimumSize` = `new Vector2(0, 186)`
- `card.Name` = `"CeremonyAward_" + award.Title.Replace(' ', '_')`
- `Columns` = `2`
- `CustomMinimumSize` = `new Vector2(62, 62)`
- `name.Name` = `"CeremonyWinnerName"`
- `Name` = `"CeremonyAwardGrid"`
- `panel.Accent` = `own ? _gold : CareerVisuals.Teal`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`

<a id="symbol-73500bb64a58"></a>

## `NationalSpire.CareerScreen.CeremonyRanking(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CeremonyRank>) — private void CeremonyRanking(CareerData data, List<CeremonyRank> entries)`

来源：源码第 179 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Ceremony(NationalSpire.CareerData)`](CeremonyScreen.cs.md#symbol-4a515aec3125)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerScreen.CeremonyLine(string, int, Godot.Color, float)`](CeremonyScreen.cs.md#symbol-746b7a635071)；[`NationalSpire.CareerScreen.CeremonySelf(NationalSpire.CareerData)`](CeremonyScreen.cs.md#symbol-bffce7c9ff06)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerScreen.WithAvatar(NationalSpire.CareerData, string, Godot.Control, int, bool)`](CareerAvatars.cs.md#symbol-830dff168a3d)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.MarginContainer.MarginContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`int.ToString()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, int, bool>)`；`System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `(T1, T2).Item1`；`(T1, T2).Item2`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.CeremonyLine(string, int, Godot.Color, float)`；`NationalSpire.CareerScreen.CeremonySelf(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.WithAvatar(NationalSpire.CareerData, string, Godot.Control, int, bool)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CeremonyRank.Clears`；`NationalSpire.CeremonyRank.Id`；`NationalSpire.CeremonyRank.Matches`；`NationalSpire.CeremonyRank.Name`；`NationalSpire.CeremonyRank.Place`；`NationalSpire.CeremonyRank.Score`；`NationalSpire.CeremonyRank.Shared`；`NationalSpire.CeremonyRank.Wins`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`columns.AddThemeConstantOverride("separation", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: columns.AddThemeConstantOverride("separation", 18);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`header.AddThemeConstantOverride("margin_left", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddThemeConstantOverride("margin_left", 18);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`header.AddThemeConstantOverride("margin_right", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddThemeConstantOverride("margin_right", 18);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`line.AddThemeConstantOverride("separation", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddThemeConstantOverride("separation", 18);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`list.AddThemeConstantOverride("separation", 7)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddThemeConstantOverride("separation", 7);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`strip.AddThemeStyleboxOverride("panel", CareerVisuals.Box(own ? "27403f" : i < 3 ? "233646" : "142535", own ? "d2ac66" : "344c59", 7, 18))`；返回值紧邻使用处：`ExpressionStatementSyntax: strip.AddThemeStyleboxOverride("panel", CareerVisuals.Box(own ? "27403f" : i < 3 ? "233646" : "142535", own ? "d2ac66" : "344c59", 7, 18));`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.MarginContainer.MarginContainer()`；输入表达式：`new MarginContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MarginContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(list)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(list);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("本期尚无可展示的正式比赛成绩。", 18, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("本期尚无可展示的正式比赛成绩。", 18, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("你本期的完整比赛记录可在生涯战报中查看。", 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("你本期的完整比赛记录可在生涯战报中查看。", 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text(playerRank >= 0              ? $"你位列第 {(entries[playerRank].Place > 0 ? entries[playerRank].Place : playerRank + 1)} 名 · {entries[playerRank].Score} 分"              : "本期前二十名 · 按正式比赛评选得分排名", 23, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text(playerRank >= 0              ? $"你位列第 {(entries[playerRank].Place > 0 ? entries[playerRank].Place : playerRank + 1)} 名 · {entries[playerRank].Score} 分"              : "本期前二十名 · 按正式比赛评选得分排名", 23, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`columns.AddChild(CeremonyLine("名次", 14, _muted, 54))`；返回值紧邻使用处：`ExpressionStatementSyntax: columns.AddChild(CeremonyLine("名次", 14, _muted, 54));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`columns.AddChild(CeremonyLine("选手", 14, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: columns.AddChild(CeremonyLine("选手", 14, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`columns.AddChild(label)`；返回值紧邻使用处：`ExpressionStatementSyntax: columns.AddChild(label);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(columns)`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(columns);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(rank)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(rank);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(value)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(value);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(WithAvatar(data, entry.Id, name, 44, true))`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(WithAvatar(data, entry.Id, name, 44, true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`list.AddChild(header)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddChild(header);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`list.AddChild(strip)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddChild(strip);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`strip.AddChild(line)`；返回值紧邻使用处：`ExpressionStatementSyntax: strip.AddChild(line);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { Name = $"CeremonyRank_{i + 1}", SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { Name = $"CeremonyRank_{i + 1}", SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { Name = "CeremonyRanking", SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { Name = "CeremonyRanking", SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `int.ToString()`；输入表达式：`metric.Item1.ToString()`；返回值紧邻使用处：`ArgumentSyntax: metric.Item1.ToString()`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, entry.Id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: entry.Name.Length > 0 ? entry.Name : CareerEngine.DisplayName(data, entry.Id)`
- `NationalSpire.CareerScreen.CeremonyLine(string, int, Godot.Color, float)`；输入表达式：`CeremonyLine("名次", 14, _muted, 54)`；返回值紧邻使用处：`ArgumentSyntax: CeremonyLine("名次", 14, _muted, 54)`
- `NationalSpire.CareerScreen.CeremonyLine(string, int, Godot.Color, float)`；输入表达式：`CeremonyLine("选手", 14, _muted)`；返回值紧邻使用处：`ArgumentSyntax: CeremonyLine("选手", 14, _muted)`
- `NationalSpire.CareerScreen.CeremonyLine(string, int, Godot.Color, float)`；输入表达式：`CeremonyLine((entry.Name.Length > 0 ? entry.Name : CareerEngine.DisplayName(data, entry.Id)) + (entry.Shared ? " · 共同成绩" : ""), 21, own ? _gold : _ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CeremonyLine((entry.Name.Length > 0 ? entry.Name : CareerEngine.DisplayName(data, entry.Id)) + (entry.Shared ? " · 共同成绩" : ""), 21, own ? _gold : _ink)`
- `NationalSpire.CareerScreen.CeremonyLine(string, int, Godot.Color, float)`；输入表达式：`CeremonyLine($"{(entry.Place > 0 ? entry.Place : i + 1):00}", 25, i < 3 || own ? _gold : _muted, 54)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CeremonyLine($"{(entry.Place > 0 ? entry.Place : i + 1):00}", 25, i < 3 || own ? _gold : _muted, 54)`
- `NationalSpire.CareerScreen.CeremonyLine(string, int, Godot.Color, float)`；输入表达式：`CeremonyLine(caption, 14, _muted, caption == "评选得分" ? 110 : 76)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CeremonyLine(caption, 14, _muted, caption == "评选得分" ? 110 : 76)`
- `NationalSpire.CareerScreen.CeremonyLine(string, int, Godot.Color, float)`；输入表达式：`CeremonyLine(metric.Item1.ToString(), metric.Item2 == 110 ? 24 : 18, metric.Item2 == 110 ? _gold : _muted, metric.Item2)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CeremonyLine(metric.Item1.ToString(), metric.Item2 == 110 ? 24 : 18, metric.Item2 == 110 ? _gold : _muted, metric.Item2)`
- `NationalSpire.CareerScreen.CeremonySelf(NationalSpire.CareerData)`；输入表达式：`CeremonySelf(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: entry.Id == CeremonySelf(data)`
- `NationalSpire.CareerScreen.CeremonySelf(NationalSpire.CareerData)`；输入表达式：`CeremonySelf(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: r.Id == CeremonySelf(data)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("本期尚无可展示的正式比赛成绩。", 18, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("本期尚无可展示的正式比赛成绩。", 18, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("你本期的完整比赛记录可在生涯战报中查看。", 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("你本期的完整比赛记录可在生涯战报中查看。", 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(playerRank >= 0              ? $"你位列第 {(entries[playerRank].Place > 0 ? entries[playerRank].Place : playerRank + 1)} 名 · {entries[playerRank].Score} 分"              : "本期前二十名 · 按正式比赛评选得分排名", 23, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(playerRank >= 0              ? $"你位列第 {(entries[playerRank].Place > 0 ? entries[playerRank].Place : playerRank + 1)} 名 · {entries[playerRank].Score} 分"              : "本期前二十名 · 按正式比赛评选得分排名", 23, _gold)`
- `NationalSpire.CareerScreen.WithAvatar(NationalSpire.CareerData, string, Godot.Control, int, bool)`；输入表达式：`WithAvatar(data, entry.Id, name, 44, true)`；返回值紧邻使用处：`ArgumentSyntax: WithAvatar(data, entry.Id, name, 44, true)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box(own ? "27403f" : i < 3 ? "233646" : "142535", own ? "d2ac66" : "344c59", 7, 18)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box(own ? "27403f" : i < 3 ? "233646" : "142535", own ? "d2ac66" : "344c59", 7, 18)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`entries.Where((r, i) => (r.Place > 0 ? r.Place : i + 1) <= 20 || r.Id == CeremonySelf(data)).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = entries.Where((r, i) => (r.Place > 0 ? r.Place : i + 1) <= 20 || r.Id == CeremonySelf(data)).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, int, bool>)`；输入表达式：`entries.Where((r, i) => (r.Place > 0 ? r.Place : i + 1) <= 20 || r.Id == CeremonySelf(data))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: entries.Where((r, i) => (r.Place > 0 ? r.Place : i + 1) <= 20 || r.Id == CeremonySelf(data)).ToList`
- `System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；输入表达式：`entries.FindIndex(r => r.Id == CeremonySelf(data))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = entries.FindIndex(r => r.Id == CeremonySelf(data))`

**赋值（含属性/字段和局部值）：**

- `label.HorizontalAlignment` = `HorizontalAlignment.Right`
- `name.Name` = `"CeremonyRankName"`
- `Name` = `"CeremonyRanking"`
- `Name` = `$"CeremonyRank_{i + 1}"`
- `rank.Name` = `"CeremonyRankNumber"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `value.HorizontalAlignment` = `HorizontalAlignment.Right`
- `value.Name` = `metric.Item2 == 110 ? "CeremonyRankScore" : "CeremonyRankStat"`

<a id="symbol-098193003e28"></a>

## `NationalSpire.CeremonyMedallion.ShowCrown — public bool ShowCrown`

来源：源码第 221 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8358bb29d344"></a>

## `NationalSpire.CeremonyMedallion._Process(double) — public override void _Process(double delta)`

来源：源码第 223 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.QueueRedraw()`

**字段、属性、事件及方法组引用：** `NationalSpire.CeremonyMedallion._time`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueRedraw();`

**赋值（含属性/字段和局部值）：**

- `_time` += `(float)delta`

<a id="symbol-6691d5972279"></a>

## `NationalSpire.CeremonyMedallion._Draw() — public override void _Draw()`

来源：源码第 224 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`P(float, float)`](CeremonyScreen.cs.md#symbol-766b9ee52716)；`Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；`Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.Color.Color(string)`；`Godot.Mathf.Cos(float)`；`Godot.Mathf.Sin(float)`；`Godot.Vector2.Vector2(float, float)`；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CeremonyMedallion._time`；`NationalSpire.CeremonyMedallion.ShowCrown`；`P(float, float)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(center, radius * .87f, 0, Mathf.Tau, 96, new Color("7c7864"), 2, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(center, radius * .87f, 0, Mathf.Tau, 96, new Color("7c7864"), 2, true);`
- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(center, radius, 0, Mathf.Tau, 96, gold, 4, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(center, radius, 0, Mathf.Tau, 96, gold, 4, true);`
- `Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；输入表达式：`DrawCircle(center, radius, new Color("253c45"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawCircle(center, radius, new Color("253c45"));`
- `Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；输入表达式：`DrawCircle(P(0, -.6f), 5, pale)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawCircle(P(0, -.6f), 5, pale);`
- `Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；输入表达式：`DrawCircle(P(i * .28f, -.13f), 3, pale)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawCircle(P(i * .28f, -.13f), 3, pale);`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon([P(-.63f, -.34f), P(-.32f, -.12f), P(0, -.59f), P(.32f, -.12f), P(.63f, -.34f), P(.48f, .29f), P(-.48f, .29f)], gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon([P(-.63f, -.34f), P(-.32f, -.12f), P(0, -.59f), P(.32f, -.12f), P(.63f, -.34f), P(.48f, .29f), P(-.48f, .29f)], gold);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(center + direction * (radius * 1.03f), center + direction * (radius * (i % 3 == 0 ? 1.25f : 1.14f)),                  gold with { A = i % 3 == 0 ? .62f : .28f }, i % 3 == 0 ? 2 : 1, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(center + direction * (radius * 1.03f), center + direction * (radius * (i % 3 == 0 ? 1.25f : 1.14f)),                  gold with { A = i % 3 == 0 ? .62f : .28f }, i % 3 == 0 ? 2 : 1, true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(P(-.38f, .42f), P(.38f, .42f), pale, 5, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(P(-.38f, .42f), P(.38f, .42f), pale, 5, true);`
- `Godot.Color.Color(string)`；输入表达式：`new Color("253c45")`；返回值紧邻使用处：`ArgumentSyntax: new Color("253c45")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("7c7864")`；返回值紧邻使用处：`ArgumentSyntax: new Color("7c7864")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("e7c27e")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Color("e7c27e")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("fae7bc")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Color("fae7bc")`
- `Godot.Mathf.Cos(float)`；输入表达式：`Mathf.Cos(angle)`；返回值紧邻使用处：`ArgumentSyntax: Mathf.Cos(angle)`
- `Godot.Mathf.Sin(float)`；输入表达式：`Mathf.Sin(angle)`；返回值紧邻使用处：`ArgumentSyntax: Mathf.Sin(angle)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(Mathf.Cos(angle), Mathf.Sin(angle))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new(Mathf.Cos(angle), Mathf.Sin(angle))`
- `P(float, float)`；输入表达式：`P(-.32f, -.12f)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-.32f, -.12f)`
- `P(float, float)`；输入表达式：`P(-.38f, .42f)`；返回值紧邻使用处：`ArgumentSyntax: P(-.38f, .42f)`
- `P(float, float)`；输入表达式：`P(-.48f, .29f)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-.48f, .29f)`
- `P(float, float)`；输入表达式：`P(-.63f, -.34f)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-.63f, -.34f)`
- `P(float, float)`；输入表达式：`P(.32f, -.12f)`；返回值紧邻使用处：`ExpressionElementSyntax: P(.32f, -.12f)`
- `P(float, float)`；输入表达式：`P(.38f, .42f)`；返回值紧邻使用处：`ArgumentSyntax: P(.38f, .42f)`
- `P(float, float)`；输入表达式：`P(.48f, .29f)`；返回值紧邻使用处：`ExpressionElementSyntax: P(.48f, .29f)`
- `P(float, float)`；输入表达式：`P(.63f, -.34f)`；返回值紧邻使用处：`ExpressionElementSyntax: P(.63f, -.34f)`
- `P(float, float)`；输入表达式：`P(0, -.59f)`；返回值紧邻使用处：`ExpressionElementSyntax: P(0, -.59f)`
- `P(float, float)`；输入表达式：`P(0, -.6f)`；返回值紧邻使用处：`ArgumentSyntax: P(0, -.6f)`
- `P(float, float)`；输入表达式：`P(i * .28f, -.13f)`；返回值紧邻使用处：`ArgumentSyntax: P(i * .28f, -.13f)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(Size.X, Size.Y)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Min(Size.X, Size.Y) * .38f`

**赋值（含属性/字段和局部值）：**

- `A` = `i % 3 == 0 ? .62f : .28f`

<a id="symbol-766b9ee52716"></a>

## `P(float, float) — Vector2 P(float x, float y)`

来源：源码第 239 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CeremonyMedallion._Draw()`](CeremonyScreen.cs.md#symbol-6691d5972279)

**调用：** `Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(x, y)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(x, y) * radius`

**赋值（含属性/字段和局部值）：**
