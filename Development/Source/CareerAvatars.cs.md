# CareerAvatars.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`A78328F7A9F68514F0D59B9D93CFAC2A10015D3A317A6A051CBBFCC342589D76`。来源：[源码](../../CareerAvatars.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.AvatarArt`、`NationalSpire.CareerAvatars`、`NationalSpire.CareerAvatar`、`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
private StyleBoxFlat? _frame;
private AvatarIdentity? _identity;
private AvatarArt _art = new(null, CareerVisuals.Teal, "");
private bool _choosingFrame;
```

<a id="symbol-b9f8261f2cf2"></a>

## `NationalSpire.CareerAvatars.MainCharacter(NationalSpire.CareerData, string) — public static string MainCharacter(CareerData data, string personId)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerAvatars.Automatic(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-2bfa078d007b)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.PlayerProfile(NationalSpire.CareerData)`](ProfileScreen.cs.md#symbol-ce70d1ef24b8)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.GameBridge.Characters()`](GameBridge.cs.md#symbol-1233494dda40)；[`NationalSpire.PlayerArchive.Read(bool)`](PlayerArchive.cs.md#symbol-153514d4aa72)；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>(System.Collections.Generic.IEqualityComparer<TSource>?)`

**字段、属性、事件及方法组引用：** `NationalSpire.ArchiveSnapshot.Recent`；`NationalSpire.CareerData.HumanIds`；`NationalSpire.CareerData.PlayerCard`；`NationalSpire.CareerData.SelectedCharacter`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.Character`；`NationalSpire.GameBridge.Characters()`；`NationalSpire.PlayerArchive.Read(bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`character.Id.ToString()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: character => character.Id.ToString()`
- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`player.Character.ToString()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = player.Character.ToString()`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, personId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: CareerEngine.Person(data, personId)?.Character`
- `NationalSpire.GameBridge.Characters()`；输入表达式：`GameBridge.Characters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GameBridge.Characters().Select`
- `NationalSpire.PlayerArchive.Read(bool)`；输入表达式：`PlayerArchive.Read()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PlayerArchive.Read().Recent`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`available.Contains(character)`；返回值紧邻使用处：`IfStatementSyntax: if (available.Contains(character)) return character;`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`PlayerArchive.Read().Recent.FirstOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: PlayerArchive.Read().Recent.FirstOrDefault()?.Players`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`GameBridge.Characters().Select(character => character.Id.ToString())`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GameBridge.Characters().Select(character => character.Id.ToString()).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>(System.Collections.Generic.IEqualityComparer<TSource>?)`；输入表达式：`GameBridge.Characters().Select(character => character.Id.ToString()).ToHashSet(StringComparer.OrdinalIgnoreCase)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GameBridge.Characters().Select(character => character.Id.ToString()).ToHashSet(StringComparer.OrdinalIgnoreCase)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-eb2a2d40fdf7"></a>

## `NationalSpire.CareerAvatars.HomeCardVariation(NationalSpire.CareerData) — public static int HomeCardVariation(CareerData data)`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.PlayerArchive.Read(bool)`](PlayerArchive.cs.md#symbol-153514d4aa72)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.ArchiveSnapshot.Recent`；`NationalSpire.CareerData.HumanIds`；`NationalSpire.CareerData.Results`；`NationalSpire.CareerData.SelectedCharacter`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerResult.MatchId`；`NationalSpire.PlayerArchive.Read(bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash($"{data.WorldId}:home-card:{data.Results.LastOrDefault()?.MatchId}:{data.SelectedCharacter}")`；返回值紧邻使用处：`ConditionalExpressionSyntax: data.HumanIds.Count > 0 ? CareerEngine.StableHash($"{data.WorldId}:home-card:{data.Results.LastOrDefault()?.MatchId}:{data.SelectedCharacter}") :          CareerEngine.StableHash($"{data.WorldId}:home-card:{PlayerArchive.Read().Recent.FirstOrDefault()?.StartTime ?? 0}")`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash($"{data.WorldId}:home-card:{PlayerArchive.Read().Recent.FirstOrDefault()?.StartTime ?? 0}")`；返回值紧邻使用处：`ConditionalExpressionSyntax: data.HumanIds.Count > 0 ? CareerEngine.StableHash($"{data.WorldId}:home-card:{data.Results.LastOrDefault()?.MatchId}:{data.SelectedCharacter}") :          CareerEngine.StableHash($"{data.WorldId}:home-card:{PlayerArchive.Read().Recent.FirstOrDefault()?.StartTime ?? 0}")`
- `NationalSpire.PlayerArchive.Read(bool)`；输入表达式：`PlayerArchive.Read()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PlayerArchive.Read().Recent`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`PlayerArchive.Read().Recent.FirstOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: PlayerArchive.Read().Recent.FirstOrDefault()?.StartTime`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`data.Results.LastOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: data.Results.LastOrDefault()?.MatchId`

**赋值（含属性/字段和局部值）：**


<a id="symbol-cd3d95caefab"></a>

## `NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string) — public static AvatarArt ForPerson(CareerData data, string personId)`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddProfileCards(NationalSpire.CareerData, Godot.GridContainer, System.Collections.Generic.IEnumerable<NationalSpire.CareerPerson>)`](CareerListCache.cs.md#symbol-13c7d56a75c4)；[`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`](CareerAvatars.cs.md#symbol-9f2c4623a902)；[`NationalSpire.CareerScreen.AvatarWardrobe(NationalSpire.CareerData, Godot.VBoxContainer)`](CareerAvatars.cs.md#symbol-a00951e0b13d)；[`NationalSpire.CareerScreen.ShowPrivateListRows()`](PrivateListRows.cs.md#symbol-a42f68b15faf)；[`NationalSpire.Coop.CoopLive.Update()`](Coop/CoopLive.cs.md#symbol-fe745d15ee63)；[`NationalSpire.Coop.CoopLive.UpdateMap(NationalSpire.Coop.CoopRun, MegaCrit.Sts2.Core.Map.ActMap, int)`](Coop/CoopLive.cs.md#symbol-3ddf0280ec69)；[`NationalSpire.Coop.CoopScreen.WaitingRoom(NationalSpire.Coop.CoopWorld)`](Coop/CoopScreen.cs.md#symbol-b46abec89d85)；[`NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?)`](LiveRunBridge.cs.md#symbol-c7a514513ce3)；[`NationalSpire.LiveRunBridge.UpdateMap(NationalSpire.LiveMatchState, NationalSpire.RivalProgress, double)`](LiveRunBridge.cs.md#symbol-cedfec15a9e5)

**调用：** [`NationalSpire.AvatarImages.Read(NationalSpire.PlayerAvatar?)`](AvatarImages.cs.md#symbol-1edd50772202)；[`NationalSpire.CareerAvatars.Automatic(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-2bfa078d007b)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarImages.Read(NationalSpire.PlayerAvatar?)`；`NationalSpire.CareerAvatars.Automatic(NationalSpire.CareerData, string)`；`NationalSpire.CareerData.HumanAvatars`；`NationalSpire.CareerData.SelectedAvatar`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.Avatar`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.Avatar`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AvatarImages.Read(NationalSpire.PlayerAvatar?)`；输入表达式：`AvatarImages.Read(selected)`；返回值紧邻使用处：`IsPatternExpressionSyntax: AvatarImages.Read(selected) is { } custom`
- `NationalSpire.CareerAvatars.Automatic(NationalSpire.CareerData, string)`；输入表达式：`Automatic(data, personId)`；返回值紧邻使用处：`ReturnStatementSyntax: return Automatic(data, personId);`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, personId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: CareerEngine.Person(data, personId)?.Avatar`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.Avatar)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.Avatar)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`data.HumanAvatars.GetValueOrDefault(personId)`；返回值紧邻使用处：`BinaryExpressionSyntax: data.HumanAvatars.GetValueOrDefault(personId) ?? CareerEngine.Person(data, personId)?.Avatar`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2bfa078d007b"></a>

## `NationalSpire.CareerAvatars.Automatic(NationalSpire.CareerData, string) — public static AvatarArt Automatic(CareerData data, string personId)`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-cd3d95caefab)；[`Select(NationalSpire.PlayerAvatar)`](AvatarScreen.cs.md#symbol-07697461993d)

**调用：** [`NationalSpire.AvatarAssets.Load(string, int, bool, int)`](AvatarAssets.cs.md#symbol-00e6fbec5eac)；[`NationalSpire.CameoAssets.ForPerson(string)`](CameoAssets.cs.md#symbol-c95ad2877552)；[`NationalSpire.CareerAvatars.MainCharacter(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-b9f8261f2cf2)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarAssets.Load(string, int, bool, int)`；`NationalSpire.CameoAssets.ForPerson(string)`；`NationalSpire.CareerAvatars.MainCharacter(NationalSpire.CareerData, string)`；`NationalSpire.CareerData.AvatarWorldId`；`NationalSpire.CareerData.LocalHumanId`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerPerson.CameoId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AvatarAssets.Load(string, int, bool, int)`；输入表达式：`AvatarAssets.Load(MainCharacter(data, personId), variant, id != "player" && variant % 3 != 0)`；返回值紧邻使用处：`ReturnStatementSyntax: return AvatarAssets.Load(MainCharacter(data, personId), variant, id != "player" && variant % 3 != 0);`
- `NationalSpire.CameoAssets.ForPerson(string)`；输入表达式：`CameoAssets.ForPerson(CareerEngine.Person(data, personId)?.CameoId ?? "")`；返回值紧邻使用处：`IsPatternExpressionSyntax: CameoAssets.ForPerson(CareerEngine.Person(data, personId)?.CameoId ?? "") is { } cameo`
- `NationalSpire.CareerAvatars.MainCharacter(NationalSpire.CareerData, string)`；输入表达式：`MainCharacter(data, personId)`；返回值紧邻使用处：`ArgumentSyntax: MainCharacter(data, personId)`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, personId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: CareerEngine.Person(data, personId)?.CameoId`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(world + ":avatar:" + id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.StableHash(world + ":avatar:" + id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9870012e2860"></a>

## `NationalSpire.CareerAvatar.PersonId — public string PersonId`

来源：源码第 46 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-0465ac243ff9"></a>

## `NationalSpire.CareerAvatar.Identity — public AvatarIdentity? Identity`

来源：源码第 48 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.QueueRedraw()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerAvatar._frame`；`NationalSpire.CareerAvatar._identity`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueRedraw();`

**赋值（含属性/字段和局部值）：**

- `_frame` = `null`
- `_identity` = `value`

<a id="symbol-831fda1db2d0"></a>

## `NationalSpire.CareerAvatar.Art — public AvatarArt Art`

来源：源码第 50 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.QueueRedraw()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerAvatar._art`；`NationalSpire.CareerAvatar._frame`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueRedraw();`

**赋值（含属性/字段和局部值）：**

- `_art` = `value`
- `_frame` = `null`

<a id="symbol-bfff6df76fbd"></a>

## `NationalSpire.CareerAvatar._Ready() — public override void _Ready()`

来源：源码第 51 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Resized` += `QueueRedraw`

<a id="symbol-d0d51d45c800"></a>

## `NationalSpire.CareerAvatar._Draw() — public override void _Draw()`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerAvatar.DrawHonors(NationalSpire.AvatarIdentity)`](CareerAvatars.cs.md#symbol-e94ed9976fb6)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；`Godot.CanvasItem.DrawStyleBox(Godot.StyleBox, Godot.Rect2)`；`Godot.CanvasItem.DrawTextureRectRegion(Godot.Texture2D, Godot.Rect2, Godot.Rect2, Godot.Color?, bool, bool)`；`Godot.Color.ToHtml(bool)`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Rect2.Grow(float)`；`Godot.Rect2.Rect2(float, float, float, float)`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.Texture2D.GetHeight()`；`Godot.Texture2D.GetWidth()`；`Godot.Vector2.Vector2(float, float)`；`System.Math.Max(float, float)`；`System.Math.Min(float, float)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarArt.Accent`；`NationalSpire.AvatarArt.Texture`；`NationalSpire.AvatarFrame.Color`；`NationalSpire.AvatarFrame.Grade`；`NationalSpire.AvatarIdentity.Frame`；`NationalSpire.CareerAvatar._frame`；`NationalSpire.CareerAvatar.Art`；`NationalSpire.CareerAvatar.DrawHonors(NationalSpire.AvatarIdentity)`；`NationalSpire.CareerAvatar.Identity`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(center + new Vector2(0, Size.Y * .33f), Size.X * .27f, Mathf.Pi, Mathf.Tau, 24, Art.Accent, Math.Max(3, Size.X * .1f), true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(center + new Vector2(0, Size.Y * .33f), Size.X * .27f, Mathf.Pi, Mathf.Tau, 24, Art.Accent, Math.Max(3, Size.X * .1f), true);`
- `Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；输入表达式：`DrawCircle(center + new Vector2(0, -Size.Y * .15f), Size.X * .14f, Art.Accent)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawCircle(center + new Vector2(0, -Size.Y * .15f), Size.X * .14f, Art.Accent);`
- `Godot.CanvasItem.DrawStyleBox(Godot.StyleBox, Godot.Rect2)`；输入表达式：`DrawStyleBox(_frame, bounds)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawStyleBox(_frame, bounds);`
- `Godot.CanvasItem.DrawTextureRectRegion(Godot.Texture2D, Godot.Rect2, Godot.Rect2, Godot.Color?, bool, bool)`；输入表达式：`DrawTextureRectRegion(texture, inner, source)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawTextureRectRegion(texture, inner, source);`
- `Godot.Color.ToHtml(bool)`；输入表达式：`Art.Accent.ToHtml()`；返回值紧邻使用处：`BinaryExpressionSyntax: Identity?.Frame.Color ?? Art.Accent.ToHtml()`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(texture)`；返回值紧邻使用处：`BinaryExpressionSyntax: Art.Texture is { } texture && GodotObject.IsInstanceValid(texture)`
- `Godot.Rect2.Grow(float)`；输入表达式：`bounds.Grow(-inset)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = bounds.Grow(-inset)`
- `Godot.Rect2.Rect2(float, float, float, float)`；输入表达式：`new Rect2((texture.GetWidth() - edge) / 2, (texture.GetHeight() - edge) / 2, edge, edge)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Rect2((texture.GetWidth() - edge) / 2, (texture.GetHeight() - edge) / 2, edge, edge)`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(Vector2.Zero, Size)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Rect2(Vector2.Zero, Size)`
- `Godot.Texture2D.GetHeight()`；输入表达式：`texture.GetHeight()`；返回值紧邻使用处：`ArgumentSyntax: texture.GetHeight()`
- `Godot.Texture2D.GetHeight()`；输入表达式：`texture.GetHeight()`；返回值紧邻使用处：`BinaryExpressionSyntax: texture.GetHeight() - edge`
- `Godot.Texture2D.GetHeight()`；输入表达式：`texture.GetHeight()`；返回值紧邻使用处：`BinaryExpressionSyntax: texture.GetHeight() > 0`
- `Godot.Texture2D.GetWidth()`；输入表达式：`texture.GetWidth()`；返回值紧邻使用处：`ArgumentSyntax: texture.GetWidth()`
- `Godot.Texture2D.GetWidth()`；输入表达式：`texture.GetWidth()`；返回值紧邻使用处：`BinaryExpressionSyntax: texture.GetWidth() - edge`
- `Godot.Texture2D.GetWidth()`；输入表达式：`texture.GetWidth()`；返回值紧邻使用处：`BinaryExpressionSyntax: texture.GetWidth() > 0`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, -Size.Y * .15f)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(0, -Size.Y * .15f)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, Size.Y * .33f)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(0, Size.Y * .33f)`
- `NationalSpire.CareerAvatar.DrawHonors(NationalSpire.AvatarIdentity)`；输入表达式：`DrawHonors(identity)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawHonors(identity);`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("0b1b22", Identity?.Frame.Color ?? Art.Accent.ToHtml(), 8, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _frame ??= CareerVisuals.Box("0b1b22", Identity?.Frame.Color ?? Art.Accent.ToHtml(), 8, 0)`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(3, Size.X * .1f)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(3, Size.X * .1f)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(Size.X, Size.Y)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Min(Size.X, Size.Y) * (framed.Frame.Grade >= 6 ? .14f : .105f)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(texture.GetWidth(), texture.GetHeight())`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(texture.GetWidth(), texture.GetHeight())`

**赋值（含属性/字段和局部值）：**

- `_frame` ??= `CareerVisuals.Box("0b1b22", Identity?.Frame.Color ?? Art.Accent.ToHtml(), 8, 0)`

<a id="symbol-e94ed9976fb6"></a>

## `NationalSpire.CareerAvatar.DrawHonors(NationalSpire.AvatarIdentity) — private void DrawHonors(AvatarIdentity identity)`

来源：源码第 74 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerAvatar._Draw()`](CareerAvatars.cs.md#symbol-d0d51d45c800)

**调用：** [`At(float, float)`](CareerAvatars.cs.md#symbol-83fd6e2c9a90)；[`Line(float, float, float, float)`](CareerAvatars.cs.md#symbol-e7558533dbb7)；[`NationalSpire.CareerAvatar.DrawMetalFrame(NationalSpire.AvatarFrame)`](AvatarFrameDrawing.cs.md#symbol-85654168c2bc)；`Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；`Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float)`；`Godot.CanvasItem.DrawString(Godot.Font, Godot.Vector2, string, Godot.HorizontalAlignment, float, int, Godot.Color?, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation, float)`；`Godot.Color.Color(string)`；`Godot.Color.Lightened(float)`；`Godot.Control.GetThemeDefaultFont()`；`Godot.Font.GetAscent(int)`；`Godot.Font.GetDescent(int)`；`Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.Vector2.Vector2(float, float)`；`int.ToString()`；`System.Math.Clamp(float, float, float)`；`System.Math.Max(float, float)`

**字段、属性、事件及方法组引用：** `At(float, float)`；`Line(float, float, float, float)`；`NationalSpire.AvatarFrame.Color`；`NationalSpire.AvatarFrame.Grade`；`NationalSpire.AvatarIdentity.Ascension`；`NationalSpire.AvatarIdentity.Frame`；`NationalSpire.AvatarIdentity.Role`；`NationalSpire.CareerAvatar.DrawMetalFrame(NationalSpire.AvatarFrame)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `At(float, float)`；输入表达式：`At(-2, -4)`；返回值紧邻使用处：`ExpressionElementSyntax: At(-2, -4)`
- `At(float, float)`；输入表达式：`At(-2, 4)`；返回值紧邻使用处：`ExpressionElementSyntax: At(-2, 4)`
- `At(float, float)`；输入表达式：`At(-4, -4)`；返回值紧邻使用处：`ArgumentSyntax: At(-4, -4)`
- `At(float, float)`；输入表达式：`At(0, -4)`；返回值紧邻使用处：`ArgumentSyntax: At(0, -4)`
- `At(float, float)`；输入表达式：`At(0, 0)`；返回值紧邻使用处：`ArgumentSyntax: At(0, 0)`
- `At(float, float)`；输入表达式：`At(4, 0)`；返回值紧邻使用处：`ExpressionElementSyntax: At(4, 0)`
- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(At(0, 0), 3.5f * unit, 0, Mathf.Pi, 12, Colors.White, 1, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(At(0, 0), 3.5f * unit, 0, Mathf.Pi, 12, Colors.White, 1, true);`
- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(center, radius - 1, 0, Mathf.Tau, 32, color, Math.Max(1.5f, radius * .16f), true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(center, radius - 1, 0, Mathf.Tau, 32, color, Math.Max(1.5f, radius * .16f), true);`
- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(center, radius - 3, Mathf.Pi, Mathf.Tau * .92f, 16, color.Lightened(.35f), 1, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(center, radius - 3, Mathf.Pi, Mathf.Tau * .92f, 16, color.Lightened(.35f), 1, true);`
- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(origin, radius - 1, 0, Mathf.Tau, 24, new Color("7cc5c0"), 1, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(origin, radius - 1, 0, Mathf.Tau, 24, new Color("7cc5c0"), 1, true);`
- `Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；输入表达式：`DrawCircle(center, radius, new Color("06101c"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawCircle(center, radius, new Color("06101c"));`
- `Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；输入表达式：`DrawCircle(origin, radius, new Color("0c1925"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawCircle(origin, radius, new Color("0c1925"));`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon([At(-2, -4), At(4, 0), At(-2, 4)], Colors.White)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon([At(-2, -4), At(4, 0), At(-2, 4)], Colors.White);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(At(0, -4), At(0, 0), Colors.White, 3 * unit, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(At(0, -4), At(0, 0), Colors.White, 3 * unit, true);`
- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float)`；输入表达式：`DrawRect(new Rect2(At(-4, -4), new Vector2(8, 7) * unit), Colors.White, false, 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawRect(new Rect2(At(-4, -4), new Vector2(8, 7) * unit), Colors.White, false, 1);`
- `Godot.CanvasItem.DrawString(Godot.Font, Godot.Vector2, string, Godot.HorizontalAlignment, float, int, Godot.Color?, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation, float)`；输入表达式：`DrawString(font, center + new Vector2(-textSize.X / 2, (font.GetAscent(fontSize) - font.GetDescent(fontSize)) / 2), number, fontSize: fontSize, modulate: Colors.White)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawString(font, center + new Vector2(-textSize.X / 2, (font.GetAscent(fontSize) - font.GetDescent(fontSize)) / 2), number, fontSize: fontSize, modulate: Colors.White);`
- `Godot.Color.Color(string)`；输入表达式：`new Color("06101c")`；返回值紧邻使用处：`ArgumentSyntax: new Color("06101c")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("0c1925")`；返回值紧邻使用处：`ArgumentSyntax: new Color("0c1925")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("7cc5c0")`；返回值紧邻使用处：`ArgumentSyntax: new Color("7cc5c0")`
- `Godot.Color.Color(string)`；输入表达式：`new Color(identity.Frame.Color)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Color(identity.Frame.Color)`
- `Godot.Color.Lightened(float)`；输入表达式：`color.Lightened(.35f)`；返回值紧邻使用处：`ArgumentSyntax: color.Lightened(.35f)`
- `Godot.Control.GetThemeDefaultFont()`；输入表达式：`GetThemeDefaultFont()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GetThemeDefaultFont()`
- `Godot.Font.GetAscent(int)`；输入表达式：`font.GetAscent(fontSize)`；返回值紧邻使用处：`BinaryExpressionSyntax: font.GetAscent(fontSize) - font.GetDescent(fontSize)`
- `Godot.Font.GetDescent(int)`；输入表达式：`font.GetDescent(fontSize)`；返回值紧邻使用处：`BinaryExpressionSyntax: font.GetAscent(fontSize) - font.GetDescent(fontSize)`
- `Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；输入表达式：`font.GetStringSize(number, fontSize: fontSize)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = font.GetStringSize(number, fontSize: fontSize)`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(At(-4, -4), new Vector2(8, 7) * unit)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(At(-4, -4), new Vector2(8, 7) * unit)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-textSize.X / 2, (font.GetAscent(fontSize) - font.GetDescent(fontSize)) / 2)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(-textSize.X / 2, (font.GetAscent(fontSize) - font.GetDescent(fontSize)) / 2)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(8, 7)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(8, 7) * unit`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(radius + 1, h - radius - 1)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Vector2(radius + 1, h - radius - 1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(w - radius - 1, h - radius - 1)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Vector2(w - radius - 1, h - radius - 1)`
- `int.ToString()`；输入表达式：`identity.Ascension.ToString()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = identity.Ascension.ToString()`
- `Line(float, float, float, float)`；输入表达式：`Line(-2, 1, 2, -2)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(-2, 1, 2, -2);`
- `Line(float, float, float, float)`；输入表达式：`Line(-2, 5, 2, 5)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(-2, 5, 2, 5);`
- `Line(float, float, float, float)`；输入表达式：`Line(-2, 5, 4, 5)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(-2, 5, 4, 5);`
- `Line(float, float, float, float)`；输入表达式：`Line(-3, -4, 3, -4)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(-3, -4, 3, -4);`
- `Line(float, float, float, float)`；输入表达式：`Line(-3, -4, 3, 4)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(-3, -4, 3, 4);`
- `Line(float, float, float, float)`；输入表达式：`Line(-3, 3, -4, 5)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(-3, 3, -4, 5);`
- `Line(float, float, float, float)`；输入表达式：`Line(-3, 3, 3, -3)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(-3, 3, 3, -3);`
- `Line(float, float, float, float)`；输入表达式：`Line(-3, 4, 3, 4)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(-3, 4, 3, 4);`
- `Line(float, float, float, float)`；输入表达式：`Line(0, 3, 0, 5)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(0, 3, 0, 5);`
- `Line(float, float, float, float)`；输入表达式：`Line(3, -4, -3, 4)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(3, -4, -3, 4);`
- `NationalSpire.CareerAvatar.DrawMetalFrame(NationalSpire.AvatarFrame)`；输入表达式：`DrawMetalFrame(identity.Frame)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawMetalFrame(identity.Frame);`
- `System.Math.Clamp(float, float, float)`；输入表达式：`Math.Clamp(w * .175f, 7, 17)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Clamp(w * .175f, 7, 17)`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(1.5f, radius * .16f)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(1.5f, radius * .16f)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-83fd6e2c9a90"></a>

## `At(float, float) — Vector2 At(float x, float y)`

来源：源码第 96 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Line(float, float, float, float)`](CareerAvatars.cs.md#symbol-e7558533dbb7)；[`NationalSpire.CareerAvatar.DrawHonors(NationalSpire.AvatarIdentity)`](CareerAvatars.cs.md#symbol-e94ed9976fb6)

**调用：** `Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(x, y)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(x, y) * unit`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e7558533dbb7"></a>

## `Line(float, float, float, float) — void Line(float x, float y, float x2, float y2)`

来源：源码第 97 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerAvatar.DrawHonors(NationalSpire.AvatarIdentity)`](CareerAvatars.cs.md#symbol-e94ed9976fb6)

**调用：** [`At(float, float)`](CareerAvatars.cs.md#symbol-83fd6e2c9a90)；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`

**字段、属性、事件及方法组引用：** `At(float, float)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `At(float, float)`；输入表达式：`At(x, y)`；返回值紧邻使用处：`ArgumentSyntax: At(x, y)`
- `At(float, float)`；输入表达式：`At(x2, y2)`；返回值紧邻使用处：`ArgumentSyntax: At(x2, y2)`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(At(x, y), At(x2, y2), Colors.White, 1.3f, true)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => DrawLine(At(x, y), At(x2, y2), Colors.White, 1.3f, true)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a00951e0b13d"></a>

## `NationalSpire.CareerScreen.AvatarWardrobe(NationalSpire.CareerData, Godot.VBoxContainer) — private void AvatarWardrobe(CareerData data, VBoxContainer box)`

来源：源码第 115 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PlayerProfile(NationalSpire.CareerData)`](ProfileScreen.cs.md#symbol-ce70d1ef24b8)

**调用：** [`NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`](AvatarHonors.cs.md#symbol-5207a1627331)；[`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-cd3d95caefab)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.ChooseFrame(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-5700a0d050b5)；[`NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`](BroadcastVisuals.cs.md#symbol-15d48434171e)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`Godot.Color.Color(float, float, float, float)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.GridContainer.GridContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.AvatarIdentity.AvatarIdentity(NationalSpire.AvatarFrame, int, string, string)`；`NationalSpire.CareerAvatar.CareerAvatar()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarFrame.Id`；`NationalSpire.AvatarFrame.Name`；`NationalSpire.AvatarFrame.Requirement`；`NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.AvatarHonors.Frames`；`NationalSpire.AvatarIdentity.Ascension`；`NationalSpire.CareerAvatar.Art`；`NationalSpire.CareerAvatar.Identity`；`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.CareerData.AvatarFrames`；`NationalSpire.CareerData.SelectedAvatarFrame`；`NationalSpire.CareerScreen._choosingFrame`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.ChooseFrame(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(.6f, .6f, .6f)`；返回值紧邻使用处：`ConditionalExpressionSyntax: unlocked ? Colors.White : new Color(.6f, .6f, .6f)`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("h_separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("h_separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("v_separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("v_separation", 12);`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer { Columns = 3, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GridContainer { Columns = 3, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(FilterButton("自动佩戴最高荣誉", data.SelectedAvatarFrame == "auto", () => ChooseFrame(data, "auto"), 235))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(FilterButton("自动佩戴最高荣誉", data.SelectedAvatarFrame == "auto", () => ChooseFrame(data, "auto"), 235));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(grid)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(grid);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text("已解锁的头像框永久保留。", 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text("已解锁的头像框永久保留。", 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`details.AddChild(preview)`；返回值紧邻使用处：`ExpressionStatementSyntax: details.AddChild(preview);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`details.AddChild(select)`；返回值紧邻使用处：`ExpressionStatementSyntax: details.AddChild(select);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`details.AddChild(Text(unlocked ? data.AvatarFrames[frame.Id].Length > 0 ? data.AvatarFrames[frame.Id] : "已解锁" : frame.Requirement, 14, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: details.AddChild(Text(unlocked ? data.AvatarFrames[frame.Id].Length > 0 ? data.AvatarFrames[frame.Id] : "已解锁" : frame.Requirement, 14, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`grid.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddChild(panel);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(64, 64)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(64, 64)`
- `NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`AvatarHonors.ForPerson(data, "player")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AvatarHonors.ForPerson(data, "player")`
- `NationalSpire.AvatarIdentity.AvatarIdentity(NationalSpire.AvatarFrame, int, string, string)`；输入表达式：`new(frame, identity.Ascension, "", "")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Identity = new(frame, identity.Ascension, "", "")`
- `NationalSpire.CareerAvatar.CareerAvatar()`；输入表达式：`new CareerAvatar { Art = CareerAvatars.ForPerson(data, "player"), Identity = new(frame, identity.Ascension, "", ""),                  CustomMinimumSize = new Vector2(64, 64), SizeFlagsHorizontal = SizeFlags.ShrinkCenter,                  Modulate = unlocked ? Colors.White : new Color(.6f, .6f, .6f) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CareerAvatar { Art = CareerAvatars.ForPerson(data, "player"), Identity = new(frame, identity.Ascension, "", ""),                  CustomMinimumSize = new Vector2(64, 64), SizeFlagsHorizontal = SizeFlags.ShrinkCenter,                  Modulate = unlocked ? Colors.White : new Color(.6f, .6f, .6f) }`
- `NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`CareerAvatars.ForPerson(data, "player")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Art = CareerAvatars.ForPerson(data, "player")`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.ChooseFrame(NationalSpire.CareerData, string)`；输入表达式：`ChooseFrame(data, "auto")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ChooseFrame(data, "auto")`
- `NationalSpire.CareerScreen.ChooseFrame(NationalSpire.CareerData, string)`；输入表达式：`ChooseFrame(data, frame.Id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ChooseFrame(data, frame.Id)`
- `NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`；输入表达式：`FilterButton("自动佩戴最高荣誉", data.SelectedAvatarFrame == "auto", () => ChooseFrame(data, "auto"), 235)`；返回值紧邻使用处：`ArgumentSyntax: FilterButton("自动佩戴最高荣誉", data.SelectedAvatarFrame == "auto", () => ChooseFrame(data, "auto"), 235)`
- `NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float)`；输入表达式：`FilterButton(frame.Name, data.SelectedAvatarFrame == frame.Id, () => ChooseFrame(data, frame.Id), 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = FilterButton(frame.Name, data.SelectedAvatarFrame == frame.Id, () => ChooseFrame(data, frame.Id), 0)`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(panel)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(panel)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("已解锁的头像框永久保留。", 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("已解锁的头像框永久保留。", 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(unlocked ? data.AvatarFrames[frame.Id].Length > 0 ? data.AvatarFrames[frame.Id] : "已解锁" : frame.Requirement, 14, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(unlocked ? data.AvatarFrames[frame.Id].Length > 0 ? data.AvatarFrames[frame.Id] : "已解锁" : frame.Requirement, 14, _muted)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`data.AvatarFrames.ContainsKey(frame.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.AvatarFrames.ContainsKey(frame.Id)`

**赋值（含属性/字段和局部值）：**

- `Art` = `CareerAvatars.ForPerson(data, "player")`
- `Columns` = `3`
- `CustomMinimumSize` = `new Vector2(64, 64)`
- `Identity` = `new(frame, identity.Ascension, "", "")`
- `Modulate` = `unlocked ? Colors.White : new Color(.6f, .6f, .6f)`
- `panel.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `select.Disabled` = `!unlocked`
- `select.Name` = `"AvatarFrame_" + frame.Id`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsHorizontal` = `SizeFlags.ShrinkCenter`

<a id="symbol-5700a0d050b5"></a>

## `NationalSpire.CareerScreen.ChooseFrame(NationalSpire.CareerData, string) — private void ChooseFrame(CareerData data, string frame)`

来源：源码第 136 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AvatarWardrobe(NationalSpire.CareerData, Godot.VBoxContainer)`](CareerAvatars.cs.md#symbol-a00951e0b13d)

**调用：** [`NationalSpire.AvatarHonors.Select(NationalSpire.CareerData, string)`](AvatarHonors.cs.md#symbol-0a58a1c49eb1)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`](CareerScreen.cs.md#symbol-9df94d88557a)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarHonors.Select(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen._renderVersion`；`NationalSpire.CareerScreen._scroll`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AvatarHonors.Select(NationalSpire.CareerData, string)`；输入表达式：`AvatarHonors.Select(data, frame)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !AvatarHonors.Select(data, frame)`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("frame", frame)`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand("frame", frame)) return;`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`；输入表达式：`RestoreScrollAsync(y, _renderVersion)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = RestoreScrollAsync(y, _renderVersion)`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(data);`

**赋值（含属性/字段和局部值）：**

- `_` = `RestoreScrollAsync(y, _renderVersion)`

<a id="symbol-eadfa70c0822"></a>

## `NationalSpire.CareerScreen.WithCharacterAvatar(string, Godot.Control) — private HBoxContainer WithCharacterAvatar(string character, Control content)`

来源：源码第 142 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ShowArchive()`](CareerScreen.cs.md#symbol-ce008839cea8)

**调用：** [`NationalSpire.AvatarAssets.Load(string, int, bool, int)`](AvatarAssets.cs.md#symbol-00e6fbec5eac)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.CareerAvatar.CareerAvatar()`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarAssets.Load(string, int, bool, int)`；`NationalSpire.CareerAvatar.Art`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 12);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(content)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(content);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(new CareerAvatar { Art = AvatarAssets.Load(character, 0, false),              CustomMinimumSize = new Vector2(48, 48), SizeFlagsVertical = SizeFlags.ShrinkCenter })`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(new CareerAvatar { Art = AvatarAssets.Load(character, 0, false),              CustomMinimumSize = new Vector2(48, 48), SizeFlagsVertical = SizeFlags.ShrinkCenter });`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(48, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(48, 48)`
- `NationalSpire.AvatarAssets.Load(string, int, bool, int)`；输入表达式：`AvatarAssets.Load(character, 0, false)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Art = AvatarAssets.Load(character, 0, false)`
- `NationalSpire.CareerAvatar.CareerAvatar()`；输入表达式：`new CareerAvatar { Art = AvatarAssets.Load(character, 0, false),              CustomMinimumSize = new Vector2(48, 48), SizeFlagsVertical = SizeFlags.ShrinkCenter }`；返回值紧邻使用处：`ArgumentSyntax: new CareerAvatar { Art = AvatarAssets.Load(character, 0, false),              CustomMinimumSize = new Vector2(48, 48), SizeFlagsVertical = SizeFlags.ShrinkCenter }`

**赋值（含属性/字段和局部值）：**

- `Art` = `AvatarAssets.Load(character, 0, false)`
- `CustomMinimumSize` = `new Vector2(48, 48)`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`

<a id="symbol-9f2c4623a902"></a>

## `NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?) — private Control Avatar(CareerData data, string personId, int size = 52, bool clickable = true, Action? open = null)`

来源：源码第 150 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.CeremonyAwards(NationalSpire.CareerData, NationalSpire.CeremonyRecord)`](CeremonyScreen.cs.md#symbol-554512484279)；[`NationalSpire.CareerScreen.CeremonyHero(NationalSpire.CareerData, NationalSpire.CeremonyRecord)`](CeremonyScreen.cs.md#symbol-7344f4112178)；[`NationalSpire.CareerScreen.GroupBubble(string, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>?)`](GroupChatScreen.cs.md#symbol-870e7cca58c0)；[`NationalSpire.CareerScreen.PlayerBanner(NationalSpire.CareerData, string)`](BroadcastVisuals.cs.md#symbol-936e32073293)；[`NationalSpire.CareerScreen.PrivateIdentity(NationalSpire.CareerData, string, bool)`](PrivateMemoryScreen.cs.md#symbol-65caddca194f)；[`NationalSpire.CareerScreen.PrivateMemory()`](PrivateMemoryScreen.cs.md#symbol-942a4a496637)；[`NationalSpire.CareerScreen.RefreshGroupChat()`](GroupChatScreen.cs.md#symbol-b56fe79b2db7)；[`NationalSpire.CareerScreen.WithAvatar(NationalSpire.CareerData, string, Godot.Control, int, bool)`](CareerAvatars.cs.md#symbol-830dff168a3d)；[`ShowRows()`](CommunityShareScreen.cs.md#symbol-2e7b710b7d77)；[`ShowRows()`](GroupChatScreen.cs.md#symbol-0c716f3f9d5a)

**调用：** [`NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`](AvatarHonors.cs.md#symbol-5207a1627331)；[`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-cd3d95caefab)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerScreen.OpenPerson(string)`](CareerNavigation.cs.md#symbol-4430ec2bce8b)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；`Godot.Color.Color(float, float, float, float)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.BroadcastButton.BroadcastButton()`；`NationalSpire.CareerAvatar.CareerAvatar()`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.AvatarIdentity.Description`；`NationalSpire.CareerAvatar.Art`；`NationalSpire.CareerAvatar.Identity`；`NationalSpire.CareerAvatar.PersonId`；`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen.OpenPerson(string)`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.AvatarControl`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(1.15f, 1.15f, 1.15f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: picture.Modulate = new Color(1.15f, 1.15f, 1.15f)`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride(state, new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride(state, new StyleBoxEmpty());`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`picture.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: picture.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`button.AddChild(picture)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddChild(picture);`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty()`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxEmpty()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(size, size)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(size, size)`
- `NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`AvatarHonors.ForPerson(data, personId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AvatarHonors.ForPerson(data, personId)`
- `NationalSpire.BroadcastButton.BroadcastButton()`；输入表达式：`new BroadcastButton { CustomMinimumSize = new Vector2(size, size), SizeFlagsHorizontal = SizeFlags.ShrinkBegin,              SizeFlagsVertical = SizeFlags.ShrinkCenter, TooltipText = CareerEngine.DisplayName(data, personId) + " · " + identity.Description + "\n查看人物档案", FocusMode = FocusModeEnum.All }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastButton { CustomMinimumSize = new Vector2(size, size), SizeFlagsHorizontal = SizeFlags.ShrinkBegin,              SizeFlagsVertical = SizeFlags.ShrinkCenter, TooltipText = CareerEngine.DisplayName(data, personId) + " · " + identity.Description + "\n查看人物档案", FocusMode = FocusModeEnum.All }`
- `NationalSpire.CareerAvatar.CareerAvatar()`；输入表达式：`new CareerAvatar { PersonId = personId, Art = art, Identity = identity, CustomMinimumSize = new Vector2(size, size),              SizeFlagsHorizontal = SizeFlags.ShrinkBegin, SizeFlagsVertical = SizeFlags.ShrinkCenter }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CareerAvatar { PersonId = personId, Art = art, Identity = identity, CustomMinimumSize = new Vector2(size, size),              SizeFlagsHorizontal = SizeFlags.ShrinkBegin, SizeFlagsVertical = SizeFlags.ShrinkCenter }`
- `NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`CareerAvatars.ForPerson(data, personId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerAvatars.ForPerson(data, personId)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, personId)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.DisplayName(data, personId) + " · "`
- `NationalSpire.CareerScreen.OpenPerson(string)`；输入表达式：`OpenPerson(personId)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenPerson(personId)`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.AvatarControl)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.AvatarControl)`

**赋值（含属性/字段和局部值）：**

- `Art` = `art`
- `button.MouseEntered` += `() => picture.Modulate = new Color(1.15f, 1.15f, 1.15f)`
- `button.MouseExited` += `() => picture.Modulate = Colors.White`
- `button.Pressed` += `open ?? (() => OpenPerson(personId))`
- `CustomMinimumSize` = `new Vector2(size, size)`
- `FocusMode` = `FocusModeEnum.All`
- `Identity` = `identity`
- `PersonId` = `personId`
- `picture.Modulate` = `Colors.White`
- `picture.Modulate` = `new Color(1.15f, 1.15f, 1.15f)`
- `picture.TooltipText` = `identity.Description`
- `SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `TooltipText` = `CareerEngine.DisplayName(data, personId) + " · " + identity.Description + "\n查看人物档案"`

<a id="symbol-830dff168a3d"></a>

## `NationalSpire.CareerScreen.WithAvatar(NationalSpire.CareerData, string, Godot.Control, int, bool) — private HBoxContainer WithAvatar(CareerData data, string id, Control content, int size = 52, bool clickable = true)`

来源：源码第 167 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Contender(string, string, string, string, string)`](SettlementScreen.cs.md#symbol-cce12ddd3cdd)；[`NationalSpire.CareerScreen.AddPostCard(NationalSpire.CareerData, NationalSpire.CommunityPost, bool)`](CareerScreen.cs.md#symbol-d5523b24e9f1)；[`NationalSpire.CareerScreen.CeremonyRanking(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CeremonyRank>)`](CeremonyScreen.cs.md#symbol-73500bb64a58)；[`NationalSpire.CareerScreen.Competition(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CareerWorldScreen.cs.md#symbol-35113b1f49bd)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)；[`NationalSpire.CareerScreen.PersonLink(NationalSpire.CareerData, string, string, int)`](CareerAvatars.cs.md#symbol-89d5865e1272)；[`NationalSpire.CareerScreen.RenderDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-1799ee450143)；[`NationalSpire.CareerScreen.RenderPostHeader(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-4c514e4927ad)；[`NationalSpire.CareerScreen.RenderTeam()`](CareerSession.cs.md#symbol-0aab3af4bc96)；[`NationalSpire.CareerScreen.World(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-ce5a79e2aa5c)

**调用：** [`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`](CareerAvatars.cs.md#symbol-9f2c4623a902)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 12);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(Avatar(data, id, size, clickable))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(Avatar(data, id, size, clickable));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(content)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(content);`
- `NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`；输入表达式：`Avatar(data, id, size, clickable)`；返回值紧邻使用处：`ArgumentSyntax: Avatar(data, id, size, clickable)`

**赋值（含属性/字段和局部值）：**

- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-89d5865e1272"></a>

## `NationalSpire.CareerScreen.PersonLink(NationalSpire.CareerData, string, string, int) — private HBoxContainer PersonLink(CareerData data, string id, string caption, int size = 40)`

来源：源码第 172 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.CircuitRanking(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-b3ab649f5b65)；[`NationalSpire.CareerScreen.ClubDirectory(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-27a995f7ce9f)；[`NationalSpire.CareerScreen.ClubMarket(NationalSpire.CareerData, bool)`](OwnedClubScreen.cs.md#symbol-b1e2f4fe72a4)；[`NationalSpire.CareerScreen.Competition(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CareerWorldScreen.cs.md#symbol-35113b1f49bd)；[`NationalSpire.CareerScreen.FanChart(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-509582b2b893)；[`NationalSpire.CareerScreen.Honors(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-fd656e0e98e6)；[`NationalSpire.CareerScreen.ModernCompetition(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CircuitScreen.cs.md#symbol-6edbcc2815f7)；[`NationalSpire.CareerScreen.NationRanking(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-b665478390f0)；[`NationalSpire.CareerScreen.OwnedClubPanel(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-d7bcae181c6a)；[`NationalSpire.CareerScreen.PersonProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](ProfileScreen.cs.md#symbol-2d802d5a07b9)；[`NationalSpire.CareerScreen.WorldHonors(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-3c1f80d447a9)；[`Side(bool)`](BroadcastVisuals.cs.md#symbol-f3d2df3d6c54)；[`Side(System.Collections.Generic.List<NationalSpire.CompetitionPlayer>, string)`](SettlementScreen.cs.md#symbol-49b1e1a15f4b)

**调用：** [`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.OpenPerson(string)`](CareerNavigation.cs.md#symbol-4430ec2bce8b)；[`NationalSpire.CareerScreen.WithAvatar(NationalSpire.CareerData, string, Godot.Control, int, bool)`](CareerAvatars.cs.md#symbol-830dff168a3d)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.OpenPerson(string)`；`NationalSpire.CareerScreen.WithAvatar(NationalSpire.CareerData, string, Godot.Control, int, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button(caption, () => OpenPerson(id))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button(caption, () => OpenPerson(id))`
- `NationalSpire.CareerScreen.OpenPerson(string)`；输入表达式：`OpenPerson(id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenPerson(id)`
- `NationalSpire.CareerScreen.WithAvatar(NationalSpire.CareerData, string, Godot.Control, int, bool)`；输入表达式：`WithAvatar(data, id, button, size)`；返回值紧邻使用处：`ReturnStatementSyntax: return WithAvatar(data, id, button, size);`

**赋值（含属性/字段和局部值）：**

- `button.Alignment` = `HorizontalAlignment.Left`
- `button.AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `button.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
