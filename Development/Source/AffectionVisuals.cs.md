# AffectionVisuals.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`80602E1793B5AC3A6B5FC32BE22B3A78684397BB1E9BE8CD047A1FFCF2DCC39C`。来源：[源码](../../AffectionVisuals.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.AffectionArt`、`NationalSpire.AffectionBadge`、`NationalSpire.RelationshipIcon`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly Dictionary<string, Texture2D> Textures = new(StringComparer.Ordinal);
public static readonly string[] Numbers = ["c27a89", "c2bddb", "e6c98e", "a1e5dd", "d0c3f5", "ffe3ef"];
public static readonly string[] ProgressColors = ["74324a", "c2bddb", "e6c98e", "a1e5dd", "d0c3f5", "f3a6c7"];
private int _display;
private long _revision = -1;
```

<a id="symbol-966474984d6a"></a>

## `NationalSpire.AffectionArt.Texture(string) — public static Texture2D Texture(string name)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AffectionBadge._Draw()`](AffectionVisuals.cs.md#symbol-dc75b39bdb21)；[`NationalSpire.CalendarDayButton._Ready()`](CalendarDayButton.cs.md#symbol-48874665eb45)；[`NationalSpire.CareerAvatar.DrawHonors(NationalSpire.AvatarIdentity)`](CareerAvatars.cs.md#symbol-e94ed9976fb6)；[`NationalSpire.CareerScreen.CreatePrivateListRow()`](PrivateListRows.cs.md#symbol-ae3a09702cbd)；[`NationalSpire.ContactRowButton._Draw()`](ContactRowButton.cs.md#symbol-4e5488f37cc5)；[`NationalSpire.RelationshipIcon._Draw()`](AffectionVisuals.cs.md#symbol-3decdc09f2fd)

**调用：** `Godot.Image.Image()`；`Godot.Image.LoadSvgFromString(string, float)`；`Godot.ImageTexture.CreateFromImage(Godot.Image)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.IO.StreamReader.ReadToEnd()`；`System.IO.StreamReader.StreamReader(System.IO.Stream)`；`System.Reflection.Assembly.GetManifestResourceStream(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.AffectionArt.Textures`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Image.Image()`；输入表达式：`new Image()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Image()`
- `Godot.Image.LoadSvgFromString(string, float)`；输入表达式：`image.LoadSvgFromString(reader.ReadToEnd())`；返回值紧邻使用处：`BinaryExpressionSyntax: image.LoadSvgFromString(reader.ReadToEnd()) != Error.Ok`
- `Godot.ImageTexture.CreateFromImage(Godot.Image)`；输入表达式：`ImageTexture.CreateFromImage(image)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Textures[name] = ImageTexture.CreateFromImage(image)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Textures.TryGetValue(name, out var texture)`；返回值紧邻使用处：`IfStatementSyntax: if (Textures.TryGetValue(name, out var texture)) return texture;`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("关系美术资源无法读取：" + name)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("关系美术资源无法读取：" + name);`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("缺少关系美术资源：" + name)`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidDataException("缺少关系美术资源：" + name)`
- `System.IO.StreamReader.ReadToEnd()`；输入表达式：`reader.ReadToEnd()`；返回值紧邻使用处：`ArgumentSyntax: reader.ReadToEnd()`
- `System.IO.StreamReader.StreamReader(System.IO.Stream)`；输入表达式：`new StreamReader(stream)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StreamReader(stream)`
- `System.Reflection.Assembly.GetManifestResourceStream(string)`；输入表达式：`typeof(AffectionArt).Assembly.GetManifestResourceStream("NationalSpire.Affection." + name + ".svg")`；返回值紧邻使用处：`BinaryExpressionSyntax: typeof(AffectionArt).Assembly.GetManifestResourceStream("NationalSpire.Affection." + name + ".svg")              ?? throw new InvalidDataException("缺少关系美术资源：" + name)`

**赋值（含属性/字段和局部值）：**

- `Textures[name]` = `ImageTexture.CreateFromImage(image)`

<a id="symbol-35024e2bf40f"></a>

## `NationalSpire.AffectionBadge.Relation — public PrivateRelation Relation`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `NationalSpire.PrivateRelation.PrivateRelation()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateRelation.PrivateRelation()`；输入表达式：`new()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-985ca94111cd"></a>

## `NationalSpire.AffectionBadge.Compact — public bool Compact`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-4ff387bfe107"></a>

## `NationalSpire.AffectionBadge.Bind(NationalSpire.PrivateRelation) — public void Bind(PrivateRelation relation)`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView.Relationship(NationalSpire.PrivateRelation)`](DateSceneView.cs.md#symbol-949c1add6c05)

**调用：** `Godot.CanvasItem.QueueRedraw()`；`Godot.Node.SetProcess(bool)`；`object.ReferenceEquals(object?, object?)`

**字段、属性、事件及方法组引用：** `NationalSpire.AffectionBadge._display`；`NationalSpire.AffectionBadge._revision`；`NationalSpire.AffectionBadge.Relation`；`NationalSpire.PrivateRelation.Favour`；`NationalSpire.PrivateRelation.Revision`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueRedraw();`
- `Godot.Node.SetProcess(bool)`；输入表达式：`SetProcess(true)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetProcess(true);`
- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(Relation, relation)`；返回值紧邻使用处：`BinaryExpressionSyntax: ReferenceEquals(Relation, relation) && _revision == relation.Revision`

**赋值（含属性/字段和局部值）：**

- `_revision` = `relation.Revision`
- `Relation` = `relation`

<a id="symbol-a519379153a6"></a>

## `NationalSpire.AffectionBadge._Ready() — public override void _Ready()`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.PrivateRelation.DisplayFavour()`](PrivateMessageData.cs.md#symbol-f0a89e196dbe)；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.Node.SetProcess(bool)`

**字段、属性、事件及方法组引用：** `NationalSpire.AffectionBadge._display`；`NationalSpire.AffectionBadge.Relation`；`NationalSpire.PrivateRelation.DisplayFavour()`；`NationalSpire.PrivateRelation.Favour`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Node.SetProcess(bool)`；输入表达式：`SetProcess(_display != Relation.Favour)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetProcess(_display != Relation.Favour);`
- `NationalSpire.PrivateRelation.DisplayFavour()`；输入表达式：`Relation.DisplayFavour()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _display = Relation.DisplayFavour()`

**赋值（含属性/字段和局部值）：**

- `_display` = `Relation.DisplayFavour()`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Resized` += `QueueRedraw`

<a id="symbol-a2bdd075fae3"></a>

## `NationalSpire.AffectionBadge._Process(double) — public override void _Process(double delta)`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.PrivateRelation.DisplayFavour()`](PrivateMessageData.cs.md#symbol-f0a89e196dbe)；`Godot.CanvasItem.QueueRedraw()`；`Godot.Node.SetProcess(bool)`

**字段、属性、事件及方法组引用：** `NationalSpire.AffectionBadge._display`；`NationalSpire.AffectionBadge.Relation`；`NationalSpire.PrivateRelation.DisplayFavour()`；`NationalSpire.PrivateRelation.Favour`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueRedraw();`
- `Godot.Node.SetProcess(bool)`；输入表达式：`SetProcess(false)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetProcess(false);`
- `NationalSpire.PrivateRelation.DisplayFavour()`；输入表达式：`Relation.DisplayFavour()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Relation.DisplayFavour()`

**赋值（含属性/字段和局部值）：**

- `_display` = `next`

<a id="symbol-dc75b39bdb21"></a>

## `NationalSpire.AffectionBadge._Draw() — public override void _Draw()`

来源：源码第 46 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.AffectionArt.Texture(string)`](AffectionVisuals.cs.md#symbol-966474984d6a)；[`NationalSpire.RelationshipPresentation.OathAppearance(NationalSpire.PrivateRelation?)`](RelationshipPresentation.cs.md#symbol-bac5ded19066)；[`NationalSpire.RelationshipPresentation.Progress(int)`](RelationshipPresentation.cs.md#symbol-d986c8a42da8)；[`NationalSpire.RelationshipPresentation.Tier(int)`](RelationshipPresentation.cs.md#symbol-46c9c691f66a)；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawString(Godot.Font, Godot.Vector2, string, Godot.HorizontalAlignment, float, int, Godot.Color?, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation, float)`；`Godot.CanvasItem.DrawTextureRect(Godot.Texture2D, Godot.Rect2, bool, Godot.Color?, bool)`；`Godot.Color.Color(string)`；`Godot.Control.GetThemeDefaultFont()`；`Godot.Font.GetAscent(int)`；`Godot.Font.GetDescent(int)`；`Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.Vector2.DistanceTo(Godot.Vector2)`；`Godot.Vector2.Lerp(Godot.Vector2, float)`；`Godot.Vector2.Vector2(float, float)`；`int.ToString(System.IFormatProvider?)`；`System.Math.Max(int, int)`；`System.Math.Min(float, float)`；`System.Math.Round(double)`

**字段、属性、事件及方法组引用：** `NationalSpire.AffectionArt.Numbers`；`NationalSpire.AffectionArt.ProgressColors`；`NationalSpire.AffectionArt.Texture(string)`；`NationalSpire.AffectionBadge._display`；`NationalSpire.AffectionBadge.Compact`；`NationalSpire.AffectionBadge.Relation`；`NationalSpire.PrivateRelation.Appearance`；`NationalSpire.RelationshipAppearance.Lover`；`NationalSpire.RelationshipPresentation.OathAppearance(NationalSpire.PrivateRelation?)`；`NationalSpire.RelationshipPresentation.Progress(int)`；`NationalSpire.RelationshipPresentation.Tier(int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(center + line[i-1]*scale, center + end*scale, new Color(AffectionArt.ProgressColors[tier]), 2.9f*scale, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(center + line[i-1]*scale, center + end*scale, new Color(AffectionArt.ProgressColors[tier]), 2.9f*scale, true);`
- `Godot.CanvasItem.DrawString(Godot.Font, Godot.Vector2, string, Godot.HorizontalAlignment, float, int, Godot.Color?, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation, float)`；输入表达式：`DrawString(font, position, text, fontSize: fontSize, modulate: new Color(bond == "oath" ? "662d57" : AffectionArt.Numbers[tier]))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawString(font, position, text, fontSize: fontSize, modulate: new Color(bond == "oath" ? "662d57" : AffectionArt.Numbers[tier]));`
- `Godot.CanvasItem.DrawTextureRect(Godot.Texture2D, Godot.Rect2, bool, Godot.Color?, bool)`；输入表达式：`DrawTextureRect(AffectionArt.Texture(asset + "-base"), bounds, false)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawTextureRect(AffectionArt.Texture(asset + "-base"), bounds, false);`
- `Godot.CanvasItem.DrawTextureRect(Godot.Texture2D, Godot.Rect2, bool, Godot.Color?, bool)`；输入表达式：`DrawTextureRect(AffectionArt.Texture(asset + "-cover"), bounds, false)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawTextureRect(AffectionArt.Texture(asset + "-cover"), bounds, false);`
- `Godot.Color.Color(string)`；输入表达式：`new Color(AffectionArt.ProgressColors[tier])`；返回值紧邻使用处：`ArgumentSyntax: new Color(AffectionArt.ProgressColors[tier])`
- `Godot.Color.Color(string)`；输入表达式：`new Color(bond == "oath" ? "662d57" : AffectionArt.Numbers[tier])`；返回值紧邻使用处：`ArgumentSyntax: modulate: new Color(bond == "oath" ? "662d57" : AffectionArt.Numbers[tier])`
- `Godot.Control.GetThemeDefaultFont()`；输入表达式：`GetThemeDefaultFont()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GetThemeDefaultFont()`
- `Godot.Font.GetAscent(int)`；输入表达式：`font.GetAscent(fontSize)`；返回值紧邻使用处：`BinaryExpressionSyntax: font.GetAscent(fontSize)-font.GetDescent(fontSize)`
- `Godot.Font.GetDescent(int)`；输入表达式：`font.GetDescent(fontSize)`；返回值紧邻使用处：`BinaryExpressionSyntax: font.GetAscent(fontSize)-font.GetDescent(fontSize)`
- `Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；输入表达式：`font.GetStringSize(text, fontSize: fontSize)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = font.GetStringSize(text, fontSize: fontSize)`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(center - new Vector2(40,34) * scale, new Vector2(80,68) * scale)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Rect2(center - new Vector2(40,34) * scale, new Vector2(80,68) * scale)`
- `Godot.Vector2.DistanceTo(Godot.Vector2)`；输入表达式：`line[i-1].DistanceTo(line[i])`；返回值紧邻使用处：`AssignmentExpressionSyntax: length += line[i-1].DistanceTo(line[i])`
- `Godot.Vector2.DistanceTo(Godot.Vector2)`；输入表达式：`line[i-1].DistanceTo(line[i])`；返回值紧邻使用处：`EqualsValueClauseSyntax: = line[i-1].DistanceTo(line[i])`
- `Godot.Vector2.Lerp(Godot.Vector2, float)`；输入表达式：`line[i-1].Lerp(line[i], Math.Min(1, remaining / segment))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = line[i-1].Lerp(line[i], Math.Min(1, remaining / segment))`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-size.X/2, (font.GetAscent(fontSize)-font.GetDescent(fontSize))/2)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(-size.X/2, (font.GetAscent(fontSize)-font.GetDescent(fontSize))/2)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(40,34)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(40,34) * scale`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(80,68)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(80,68) * scale`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(-21.2f,12)`；返回值紧邻使用处：`ExpressionElementSyntax: new(-21.2f,12)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(-22,13.5f)`；返回值紧邻使用处：`ExpressionElementSyntax: new(-22,13.5f)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(-22.4f,-9.7f)`；返回值紧邻使用处：`ExpressionElementSyntax: new(-22.4f,-9.7f)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(-24,-12)`；返回值紧邻使用处：`ExpressionElementSyntax: new(-24,-12)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,-20.7f)`；返回值紧邻使用处：`ExpressionElementSyntax: new(0,-20.7f)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,-24)`；返回值紧邻使用处：`ExpressionElementSyntax: new(0,-24)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(21.2f,12)`；返回值紧邻使用处：`ExpressionElementSyntax: new(21.2f,12)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(22,13.5f)`；返回值紧邻使用处：`ExpressionElementSyntax: new(22,13.5f)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(22.4f,-9.7f)`；返回值紧邻使用处：`ExpressionElementSyntax: new(22.4f,-9.7f)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(24,-12)`；返回值紧邻使用处：`ExpressionElementSyntax: new(24,-12)`
- `int.ToString(System.IFormatProvider?)`；输入表达式：`_display.ToString(System.Globalization.CultureInfo.InvariantCulture)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _display.ToString(System.Globalization.CultureInfo.InvariantCulture)`
- `NationalSpire.AffectionArt.Texture(string)`；输入表达式：`AffectionArt.Texture(asset + "-base")`；返回值紧邻使用处：`ArgumentSyntax: AffectionArt.Texture(asset + "-base")`
- `NationalSpire.AffectionArt.Texture(string)`；输入表达式：`AffectionArt.Texture(asset + "-cover")`；返回值紧邻使用处：`ArgumentSyntax: AffectionArt.Texture(asset + "-cover")`
- `NationalSpire.RelationshipPresentation.OathAppearance(NationalSpire.PrivateRelation?)`；输入表达式：`RelationshipPresentation.OathAppearance(Relation)`；返回值紧邻使用处：`ConditionalExpressionSyntax: RelationshipPresentation.OathAppearance(Relation) ? "oath" : Relation.Appearance.Lover && _display >= 60 ? "lover" : "none"`
- `NationalSpire.RelationshipPresentation.Progress(int)`；输入表达式：`RelationshipPresentation.Progress(_display)`；返回值紧邻使用处：`BinaryExpressionSyntax: length * RelationshipPresentation.Progress(_display)`
- `NationalSpire.RelationshipPresentation.Tier(int)`；输入表达式：`RelationshipPresentation.Tier(_display)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RelationshipPresentation.Tier(_display)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(_display <= -100 ? 12 : 14, fontSize)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Max(_display <= -100 ? 12 : 14, fontSize) - 1`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(1, remaining / segment)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(1, remaining / segment)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(Size.X / (Compact ? 60 : 80), Size.Y / 68)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(Size.X / (Compact ? 60 : 80), Size.Y / 68)`
- `System.Math.Round(double)`；输入表达式：`Math.Round((_display <= -100 ? 16 : _display < 0 ? 19 : _display >= 100 ? 20 : 22) * scale)`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Round((_display <= -100 ? 16 : _display < 0 ? 19 : _display >= 100 ? 20 : 22) * scale)`

**赋值（含属性/字段和局部值）：**

- `fontSize` = `Math.Max(_display <= -100 ? 12 : 14, fontSize) - 1`
- `length` += `line[i-1].DistanceTo(line[i])`
- `line[i].X` *= `.94f`
- `remaining` -= `segment`

<a id="symbol-88d21bec4a9a"></a>

## `NationalSpire.RelationshipIcon.Bond — public string Bond`

来源：源码第 81 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8c40554b200f"></a>

## `NationalSpire.RelationshipIcon.Tight — public bool Tight`

来源：源码第 82 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-5a4b857ca21c"></a>

## `NationalSpire.RelationshipIcon._Ready() — public override void _Ready()`

来源：源码第 83 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`

**赋值（含属性/字段和局部值）：**

- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Resized` += `QueueRedraw`

<a id="symbol-3decdc09f2fd"></a>

## `NationalSpire.RelationshipIcon._Draw() — public override void _Draw()`

来源：源码第 84 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.AffectionArt.Texture(string)`](AffectionVisuals.cs.md#symbol-966474984d6a)；`Godot.CanvasItem.DrawTextureRect(Godot.Texture2D, Godot.Rect2, bool, Godot.Color?, bool)`；`Godot.CanvasItem.DrawTextureRectRegion(Godot.Texture2D, Godot.Rect2, Godot.Rect2, Godot.Color?, bool, bool)`；`Godot.Rect2.Rect2(float, float, float, float)`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.Vector2.Vector2(float, float)`；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.AffectionArt.Texture(string)`；`NationalSpire.RelationshipIcon.Bond`；`NationalSpire.RelationshipIcon.Tight`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawTextureRect(Godot.Texture2D, Godot.Rect2, bool, Godot.Color?, bool)`；输入表达式：`DrawTextureRect(texture, rect, false)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawTextureRect(texture, rect, false);`
- `Godot.CanvasItem.DrawTextureRectRegion(Godot.Texture2D, Godot.Rect2, Godot.Rect2, Godot.Color?, bool, bool)`；输入表达式：`DrawTextureRectRegion(texture, rect, new Rect2(24, 24, 144, 144))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawTextureRectRegion(texture, rect, new Rect2(24, 24, 144, 144));`
- `Godot.Rect2.Rect2(float, float, float, float)`；输入表达式：`new Rect2(24, 24, 144, 144)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(24, 24, 144, 144)`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2((Size-new Vector2(size,size))/2, new(size,size))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Rect2((Size-new Vector2(size,size))/2, new(size,size))`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(size,size)`；返回值紧邻使用处：`BinaryExpressionSyntax: Size-new Vector2(size,size)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(size,size)`；返回值紧邻使用处：`ArgumentSyntax: new(size,size)`
- `NationalSpire.AffectionArt.Texture(string)`；输入表达式：`AffectionArt.Texture("bond-" + Bond)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AffectionArt.Texture("bond-" + Bond)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(Size.X, Size.Y)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(Size.X, Size.Y)`

**赋值（含属性/字段和局部值）：**
