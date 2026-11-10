# CareerAvatars.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`33457575D6295B3D57835C6434997279BAB252508C1C58FE2C7075513F7ED288`。来源：[源码](../../CareerAvatars.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.AvatarArt`、`NationalSpire.CareerAvatars`、`NationalSpire.CareerAvatarIcon`、`NationalSpire.CareerAvatar`、`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
internal const int Pixels = 48;
private StyleBoxFlat? _frame;
internal const float ArtworkInset = 4;
private AvatarIdentity? _identity;
private AvatarArt _art = new(null, CareerVisuals.Teal, "");
private bool _choosingFrame;
```

<a id="symbol-b9f8261f2cf2"></a>

## `NationalSpire.CareerAvatars.MainCharacter(NationalSpire.CareerData, string) — public static string MainCharacter(CareerData data, string personId)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerAvatars.Automatic(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-2bfa078d007b)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)；[`NationalSpire.CareerScreen.PlayerProfile(NationalSpire.CareerData)`](ProfileScreen.cs.md#symbol-ce70d1ef24b8)；[`NationalSpire.CareerScreen.RosterMember(NationalSpire.CareerData, NationalSpire.OwnedClubState, Godot.VBoxContainer, string, string, bool)`](ClubRosterScreen.cs.md#symbol-8191d4b2f80f)；[`Side(bool, string, bool)`](FixtureScheduleScreen.cs.md#symbol-766128f05c3d)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.GameBridge.Characters()`](GameBridge.cs.md#symbol-1233494dda40)；[`NationalSpire.PlayerArchive.Read(bool)`](PlayerArchive.cs.md#symbol-153514d4aa72)；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`string.Equals(string?, System.StringComparison)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.ArchiveSnapshot.Recent`；`NationalSpire.CareerData.HumanIds`；`NationalSpire.CareerData.PlayerCard`；`NationalSpire.CareerData.SelectedCharacter`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.Character`；`NationalSpire.GameBridge.Characters()`；`NationalSpire.PlayerArchive.Read(bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`c.Id.ToString()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Id.ToString().Equals`
- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`player.Character.ToString()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = player.Character.ToString()`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, personId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: CareerEngine.Person(data, personId)?.Character`
- `NationalSpire.GameBridge.Characters()`；输入表达式：`GameBridge.Characters()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GameBridge.Characters()`
- `NationalSpire.PlayerArchive.Read(bool)`；输入表达式：`PlayerArchive.Read()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PlayerArchive.Read().Recent`
- `string.Equals(string?, System.StringComparison)`；输入表达式：`c.Id.ToString().Equals(character, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => c.Id.ToString().Equals(character, StringComparison.OrdinalIgnoreCase)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`available.Any(c => c.Id.ToString().Equals(character, StringComparison.OrdinalIgnoreCase))`；返回值紧邻使用处：`IfStatementSyntax: if (available.Any(c => c.Id.ToString().Equals(character, StringComparison.OrdinalIgnoreCase))) return character;`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`PlayerArchive.Read().Recent.FirstOrDefault()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PlayerArchive.Read().Recent.FirstOrDefault()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-eb2a2d40fdf7"></a>

## `NationalSpire.CareerAvatars.HomeCardVariation(NationalSpire.CareerData) — public static int HomeCardVariation(CareerData data)`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddProfileCards(NationalSpire.CareerData, Godot.GridContainer, System.Collections.Generic.IEnumerable<NationalSpire.CareerPerson>)`](CareerListCache.cs.md#symbol-13c7d56a75c4)；[`NationalSpire.CareerScreen.AvatarWardrobe(NationalSpire.CareerData, Godot.VBoxContainer)`](CareerAvatars.cs.md#symbol-a00951e0b13d)；[`NationalSpire.CareerScreen.BindPortrait(NationalSpire.CareerData, string, NationalSpire.CareerAvatar, Godot.Button?)`](CareerAvatars.cs.md#symbol-37774acf84fe)；[`NationalSpire.CareerScreen.BoardLine(Godot.Container, NationalSpire.CareerData, int, string, string, string, string?, bool)`](CareerBoardsScreen.cs.md#symbol-7d1cd449d003)；[`NationalSpire.CareerScreen.NpcAvatarFramePicker(NationalSpire.CareerData, string)`](NpcAvatarFrameScreen.cs.md#symbol-ca2807c0402f)；[`NationalSpire.CareerScreen.OpenDateAssets(NationalSpire.CareerData, string)`](DateSceneAssetScreen.cs.md#symbol-a45b4a628cd5)；[`NationalSpire.CareerScreen.ShowPrivateListRows()`](PrivateListRows.cs.md#symbol-a42f68b15faf)；[`NationalSpire.Coop.CoopLive.Update()`](Coop/CoopLive.cs.md#symbol-fe745d15ee63)；[`NationalSpire.Coop.CoopLive.UpdateMap(NationalSpire.Coop.CoopRun, MegaCrit.Sts2.Core.Map.ActMap, int)`](Coop/CoopLive.cs.md#symbol-3ddf0280ec69)；[`NationalSpire.Coop.CoopScreen.WaitingRoom(NationalSpire.Coop.CoopWorld)`](Coop/CoopScreen.cs.md#symbol-b46abec89d85)；[`NationalSpire.GroupAvatar.Update(NationalSpire.CareerData, NationalSpire.GroupChat)`](GroupAvatar.cs.md#symbol-5d97e2be271b)；[`NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?)`](LiveRunBridge.cs.md#symbol-c7a514513ce3)；[`NationalSpire.LiveRunBridge.UpdateDateGame(NationalSpire.LiveMatchState, NationalSpire.RivalProgress, double, ref bool)`](LiveDateGame.cs.md#symbol-cb87a418530f)；[`NationalSpire.LiveRunBridge.UpdateDateGameAction(NationalSpire.DateGameState, double)`](LiveDateGame.cs.md#symbol-e4061f52dd90)；[`NationalSpire.LiveRunBridge.UpdateMap(NationalSpire.LiveMatchState, NationalSpire.RivalProgress, double)`](LiveRunBridge.cs.md#symbol-cedfec15a9e5)

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

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Face()`](OpeningPlayerEditor.cs.md#symbol-bfa0e310c4c5)；[`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-cd3d95caefab)；[`Select(NationalSpire.PlayerAvatar)`](AvatarScreen.cs.md#symbol-223ba7b715b1)

**调用：** [`NationalSpire.AvatarAssets.Load(string, int, bool, int)`](AvatarAssets.cs.md#symbol-00e6fbec5eac)；[`NationalSpire.CameoAssets.ForPerson(string)`](CameoAssets.cs.md#symbol-c95ad2877552)；[`NationalSpire.CareerAvatars.MainCharacter(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-b9f8261f2cf2)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarAssets.Load(string, int, bool, int)`；`NationalSpire.CameoAssets.ForPerson(string)`；`NationalSpire.CareerAvatars.MainCharacter(NationalSpire.CareerData, string)`；`NationalSpire.CareerData.AvatarWorldId`；`NationalSpire.CareerData.LocalHumanId`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerPerson.CameoId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AvatarAssets.Load(string, int, bool, int)`；输入表达式：`AvatarAssets.Load(MainCharacter(data, personId), variant, id != "player" && variant % 3 != 0)`；返回值紧邻使用处：`ReturnStatementSyntax: return AvatarAssets.Load(MainCharacter(data, personId), variant, id != "player" && variant % 3 != 0);`
- `NationalSpire.CameoAssets.ForPerson(string)`；输入表达式：`CameoAssets.ForPerson(CareerEngine.Person(data, personId)?.CameoId ?? "")`；返回值紧邻使用处：`IsPatternExpressionSyntax: CameoAssets.ForPerson(CareerEngine.Person(data, personId)?.CameoId ?? "") is { } cameo`
- `NationalSpire.CareerAvatars.MainCharacter(NationalSpire.CareerData, string)`；输入表达式：`MainCharacter(data, personId)`；返回值紧邻使用处：`ArgumentSyntax: MainCharacter(data, personId)`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, personId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: CareerEngine.Person(data, personId)?.CameoId`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(world + ":avatar:" + id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.StableHash(world + ":avatar:" + id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5872dc762557"></a>

## `NationalSpire.CareerAvatarIcon.Art — internal AvatarArt Art`

来源：源码第 51 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `NationalSpire.AvatarArt.AvatarArt(Godot.Texture2D?, Godot.Color, string)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Teal`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AvatarArt.AvatarArt(Godot.Texture2D?, Godot.Color, string)`；输入表达式：`new(null, CareerVisuals.Teal, "")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new(null, CareerVisuals.Teal, "")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7e565f43c338"></a>

## `NationalSpire.CareerAvatarIcon._GetWidth() — public override int _GetWidth()`

来源：源码第 53 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerAvatarIcon.Pixels`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e9659c222de6"></a>

## `NationalSpire.CareerAvatarIcon._GetHeight() — public override int _GetHeight()`

来源：源码第 54 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerAvatarIcon.Pixels`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3a11dc3796e7"></a>

## `NationalSpire.CareerAvatarIcon._HasAlpha() — public override bool _HasAlpha()`

来源：源码第 55 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-04736bccb048"></a>

## `NationalSpire.CareerAvatarIcon._Draw(Godot.Rid, Godot.Vector2, Godot.Color, bool) — public override void _Draw(Rid canvas, Vector2 pos, Color modulate, bool transpose)`

来源：源码第 56 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerAvatarIcon._DrawRect(Godot.Rid, Godot.Rect2, bool, Godot.Color, bool)`](CareerAvatars.cs.md#symbol-25bdc2cdab7c)；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerAvatarIcon._DrawRect(Godot.Rid, Godot.Rect2, bool, Godot.Color, bool)`；`NationalSpire.CareerAvatarIcon.Pixels`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(pos, new Vector2(Pixels, Pixels))`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(pos, new Vector2(Pixels, Pixels))`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(Pixels, Pixels)`；返回值紧邻使用处：`ArgumentSyntax: new Vector2(Pixels, Pixels)`
- `NationalSpire.CareerAvatarIcon._DrawRect(Godot.Rid, Godot.Rect2, bool, Godot.Color, bool)`；输入表达式：`_DrawRect(canvas, new Rect2(pos, new Vector2(Pixels, Pixels)), false, modulate, transpose)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>          _DrawRect(canvas, new Rect2(pos, new Vector2(Pixels, Pixels)), false, modulate, transpose)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-25bdc2cdab7c"></a>

## `NationalSpire.CareerAvatarIcon._DrawRect(Godot.Rid, Godot.Rect2, bool, Godot.Color, bool) — public override void _DrawRect(Rid canvas, Rect2 rect, bool tile, Color modulate, bool transpose)`

来源：源码第 58 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerAvatarIcon._Draw(Godot.Rid, Godot.Vector2, Godot.Color, bool)`](CareerAvatars.cs.md#symbol-04736bccb048)

**调用：** [`NationalSpire.CareerAvatar.DrawFace(Godot.Rid, Godot.Rect2, Godot.Rect2, NationalSpire.AvatarArt, Godot.Color)`](CareerAvatars.cs.md#symbol-4439612bdd87)；[`NationalSpire.CareerAvatar.PortraitFrame(NationalSpire.AvatarArt, NationalSpire.AvatarIdentity?, bool)`](CareerAvatars.cs.md#symbol-3f66fd9ce111)；`Godot.Rect2.Grow(float)`；`Godot.StyleBox.Draw(Godot.Rid, Godot.Rect2)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerAvatar.ArtworkInset`；`NationalSpire.CareerAvatar.DrawFace(Godot.Rid, Godot.Rect2, Godot.Rect2, NationalSpire.AvatarArt, Godot.Color)`；`NationalSpire.CareerAvatar.PortraitFrame(NationalSpire.AvatarArt, NationalSpire.AvatarIdentity?, bool)`；`NationalSpire.CareerAvatarIcon._frame`；`NationalSpire.CareerAvatarIcon.Art`；`NationalSpire.CareerAvatarIcon.Pixels`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Rect2.Grow(float)`；输入表达式：`rect.Grow(-CareerAvatar.ArtworkInset * rect.Size.X / Pixels)`；返回值紧邻使用处：`ArgumentSyntax: rect.Grow(-CareerAvatar.ArtworkInset * rect.Size.X / Pixels)`
- `Godot.StyleBox.Draw(Godot.Rid, Godot.Rect2)`；输入表达式：`_frame.Draw(canvas, rect)`；返回值紧邻使用处：`ExpressionStatementSyntax: _frame.Draw(canvas, rect);`
- `NationalSpire.CareerAvatar.DrawFace(Godot.Rid, Godot.Rect2, Godot.Rect2, NationalSpire.AvatarArt, Godot.Color)`；输入表达式：`CareerAvatar.DrawFace(canvas, rect, rect.Grow(-CareerAvatar.ArtworkInset * rect.Size.X / Pixels), Art, modulate)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerAvatar.DrawFace(canvas, rect, rect.Grow(-CareerAvatar.ArtworkInset * rect.Size.X / Pixels), Art, modulate);`
- `NationalSpire.CareerAvatar.PortraitFrame(NationalSpire.AvatarArt, NationalSpire.AvatarIdentity?, bool)`；输入表达式：`CareerAvatar.PortraitFrame(Art)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _frame ??= CareerAvatar.PortraitFrame(Art)`

**赋值（含属性/字段和局部值）：**

- `_frame` ??= `CareerAvatar.PortraitFrame(Art)`

<a id="symbol-9870012e2860"></a>

## `NationalSpire.CareerAvatar.PersonId — public string PersonId`

来源：源码第 70 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f5408642a13b"></a>

## `NationalSpire.CareerAvatar.Simplified — public bool Simplified`

来源：源码第 71 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-0465ac243ff9"></a>

## `NationalSpire.CareerAvatar.Identity — public AvatarIdentity? Identity`

来源：源码第 73 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

来源：源码第 75 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.QueueRedraw()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerAvatar._art`；`NationalSpire.CareerAvatar._frame`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueRedraw();`

**赋值（含属性/字段和局部值）：**

- `_art` = `value`
- `_frame` = `null`

<a id="symbol-3f66fd9ce111"></a>

## `NationalSpire.CareerAvatar.PortraitFrame(NationalSpire.AvatarArt, NationalSpire.AvatarIdentity?, bool) — internal static StyleBoxFlat PortraitFrame(AvatarArt art, AvatarIdentity? identity = null, bool simplified = false)`

来源：源码第 76 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerAvatar._Draw()`](CareerAvatars.cs.md#symbol-d0d51d45c800)；[`NationalSpire.CareerAvatarIcon._DrawRect(Godot.Rid, Godot.Rect2, bool, Godot.Color, bool)`](CareerAvatars.cs.md#symbol-25bdc2cdab7c)

**调用：** [`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Color.ToHtml(bool)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarArt.Accent`；`NationalSpire.AvatarFrame.Color`；`NationalSpire.AvatarIdentity.DisplayFrame`；`NationalSpire.AvatarIdentity.SelectedFrame`；`NationalSpire.AvatarIdentity.UseOathFrame`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.ToHtml(bool)`；输入表达式：`art.Accent.ToHtml()`；返回值紧邻使用处：`BinaryExpressionSyntax: identity?.DisplayFrame.Color ?? art.Accent.ToHtml()`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("0b1b22", identity?.UseOathFrame == true || identity?.SelectedFrame is "friend" or "intimate" or "lover" or "cat"              ? "00000000" : identity?.DisplayFrame.Color ?? art.Accent.ToHtml(), simplified ? 3 : 8, 0)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>          CareerVisuals.Box("0b1b22", identity?.UseOathFrame == true || identity?.SelectedFrame is "friend" or "intimate" or "lover" or "cat"              ? "00000000" : identity?.DisplayFrame.Color ?? art.Accent.ToHtml(), simplified ? 3 : 8, 0)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-bc3fdbe7e550"></a>

## `NationalSpire.CareerAvatar.PortraitRegion(Godot.Texture2D) — private static Rect2 PortraitRegion(Texture2D texture)`

来源：源码第 80 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerAvatar.DrawFace(Godot.Rid, Godot.Rect2, Godot.Rect2, NationalSpire.AvatarArt, Godot.Color)`](CareerAvatars.cs.md#symbol-4439612bdd87)

**调用：** `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.Texture2D.GetSize()`；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2((size - square) / 2, square)`；返回值紧邻使用处：`ReturnStatementSyntax: return new Rect2((size - square) / 2, square);`
- `Godot.Texture2D.GetSize()`；输入表达式：`texture.GetSize()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = texture.GetSize()`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(size.X, size.Y)`；返回值紧邻使用处：`BinaryExpressionSyntax: Vector2.One * Math.Min(size.X, size.Y)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-bfff6df76fbd"></a>

## `NationalSpire.CareerAvatar._Ready() — public override void _Ready()`

来源：源码第 86 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Resized` += `QueueRedraw`

<a id="symbol-d0d51d45c800"></a>

## `NationalSpire.CareerAvatar._Draw() — public override void _Draw()`

来源：源码第 87 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerAvatar.DrawFace(Godot.Rid, Godot.Rect2, Godot.Rect2, NationalSpire.AvatarArt, Godot.Color)`](CareerAvatars.cs.md#symbol-4439612bdd87)；[`NationalSpire.CareerAvatar.DrawHonors(NationalSpire.AvatarIdentity)`](CareerAvatars.cs.md#symbol-e94ed9976fb6)；[`NationalSpire.CareerAvatar.PortraitFrame(NationalSpire.AvatarArt, NationalSpire.AvatarIdentity?, bool)`](CareerAvatars.cs.md#symbol-3f66fd9ce111)；`Godot.CanvasItem.DrawStyleBox(Godot.StyleBox, Godot.Rect2)`；`Godot.CanvasItem.GetCanvasItem()`；`Godot.Rect2.Grow(float)`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarFrame.Grade`；`NationalSpire.AvatarIdentity.DisplayFrame`；`NationalSpire.AvatarIdentity.SelectedFrame`；`NationalSpire.AvatarIdentity.UseOathFrame`；`NationalSpire.CareerAvatar._frame`；`NationalSpire.CareerAvatar.Art`；`NationalSpire.CareerAvatar.ArtworkInset`；`NationalSpire.CareerAvatar.DrawFace(Godot.Rid, Godot.Rect2, Godot.Rect2, NationalSpire.AvatarArt, Godot.Color)`；`NationalSpire.CareerAvatar.DrawHonors(NationalSpire.AvatarIdentity)`；`NationalSpire.CareerAvatar.Identity`；`NationalSpire.CareerAvatar.PortraitFrame(NationalSpire.AvatarArt, NationalSpire.AvatarIdentity?, bool)`；`NationalSpire.CareerAvatar.Simplified`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawStyleBox(Godot.StyleBox, Godot.Rect2)`；输入表达式：`DrawStyleBox(_frame, Identity?.SelectedFrame is "friend" or "intimate" or "lover" or "cat" ? inner : bounds)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawStyleBox(_frame, Identity?.SelectedFrame is "friend" or "intimate" or "lover" or "cat" ? inner : bounds);`
- `Godot.CanvasItem.GetCanvasItem()`；输入表达式：`GetCanvasItem()`；返回值紧邻使用处：`ArgumentSyntax: GetCanvasItem()`
- `Godot.Rect2.Grow(float)`；输入表达式：`bounds.Grow(-inset)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = bounds.Grow(-inset)`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(Vector2.Zero, Size)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Rect2(Vector2.Zero, Size)`
- `NationalSpire.CareerAvatar.DrawFace(Godot.Rid, Godot.Rect2, Godot.Rect2, NationalSpire.AvatarArt, Godot.Color)`；输入表达式：`DrawFace(GetCanvasItem(), bounds, inner, Art, Colors.White)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawFace(GetCanvasItem(), bounds, inner, Art, Colors.White);`
- `NationalSpire.CareerAvatar.DrawHonors(NationalSpire.AvatarIdentity)`；输入表达式：`DrawHonors(identity)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawHonors(identity);`
- `NationalSpire.CareerAvatar.PortraitFrame(NationalSpire.AvatarArt, NationalSpire.AvatarIdentity?, bool)`；输入表达式：`PortraitFrame(Art, Identity, Simplified)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _frame ??= PortraitFrame(Art, Identity, Simplified)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(2, Size.X * .06f)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Simplified ? Math.Min(2, Size.X * .06f) : ArtworkInset`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(Size.X, Size.Y)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Min(Size.X, Size.Y) * .09f`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(Size.X, Size.Y)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Min(Size.X, Size.Y) * (framed.DisplayFrame.Grade >= 6 ? .14f : .105f)`

**赋值（含属性/字段和局部值）：**

- `_frame` ??= `PortraitFrame(Art, Identity, Simplified)`

<a id="symbol-4439612bdd87"></a>

## `NationalSpire.CareerAvatar.DrawFace(Godot.Rid, Godot.Rect2, Godot.Rect2, NationalSpire.AvatarArt, Godot.Color) — internal static void DrawFace(Rid canvas, Rect2 bounds, Rect2 inner, AvatarArt art, Color modulate)`

来源：源码第 99 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerAvatar._Draw()`](CareerAvatars.cs.md#symbol-d0d51d45c800)；[`NationalSpire.CareerAvatarIcon._DrawRect(Godot.Rid, Godot.Rect2, bool, Godot.Color, bool)`](CareerAvatars.cs.md#symbol-25bdc2cdab7c)

**调用：** [`NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`](AvatarAssets.cs.md#symbol-1d4beb6f533e)；[`NationalSpire.CareerAvatar.PortraitRegion(Godot.Texture2D)`](CareerAvatars.cs.md#symbol-bc3fdbe7e550)；`Godot.Rect2.GetCenter()`；`Godot.RenderingServer.CanvasItemAddCircle(Godot.Rid, Godot.Vector2, float, Godot.Color)`；`Godot.RenderingServer.CanvasItemAddPolyline(Godot.Rid, System.ReadOnlySpan<Godot.Vector2>, System.ReadOnlySpan<Godot.Color>, float, bool)`；`Godot.Texture2D.DrawRectRegion(Godot.Rid, Godot.Rect2, Godot.Rect2, Godot.Color?, bool, bool)`；`Godot.Vector2.FromAngle(float)`；`Godot.Vector2.Vector2(float, float)`；`System.Math.Max(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarArt.Accent`；`NationalSpire.AvatarArt.Texture`；`NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`；`NationalSpire.CareerAvatar.PortraitRegion(Godot.Texture2D)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Rect2.GetCenter()`；输入表达式：`bounds.GetCenter()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = bounds.GetCenter()`
- `Godot.RenderingServer.CanvasItemAddCircle(Godot.Rid, Godot.Vector2, float, Godot.Color)`；输入表达式：`RenderingServer.CanvasItemAddCircle(canvas, center + new Vector2(0, -size.Y * .15f), size.X * .14f, color)`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderingServer.CanvasItemAddCircle(canvas, center + new Vector2(0, -size.Y * .15f), size.X * .14f, color);`
- `Godot.RenderingServer.CanvasItemAddPolyline(Godot.Rid, System.ReadOnlySpan<Godot.Vector2>, System.ReadOnlySpan<Godot.Color>, float, bool)`；输入表达式：`RenderingServer.CanvasItemAddPolyline(canvas, shoulders, [color], Math.Max(3, size.X * .1f), true)`；返回值紧邻使用处：`ExpressionStatementSyntax: RenderingServer.CanvasItemAddPolyline(canvas, shoulders, [color], Math.Max(3, size.X * .1f), true);`
- `Godot.Texture2D.DrawRectRegion(Godot.Rid, Godot.Rect2, Godot.Rect2, Godot.Color?, bool, bool)`；输入表达式：`texture.DrawRectRegion(canvas, inner, PortraitRegion(texture), modulate)`；返回值紧邻使用处：`ExpressionStatementSyntax: texture.DrawRectRegion(canvas, inner, PortraitRegion(texture), modulate);`
- `Godot.Vector2.FromAngle(float)`；输入表达式：`Vector2.FromAngle(Mathf.Pi + Mathf.Pi * i / (shoulders.Length - 1))`；返回值紧邻使用处：`BinaryExpressionSyntax: Vector2.FromAngle(Mathf.Pi + Mathf.Pi * i / (shoulders.Length - 1)) * (size.X * .27f)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, -size.Y * .15f)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(0, -size.Y * .15f)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, size.Y * .33f)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(0, size.Y * .33f)`
- `NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`；输入表达式：`AvatarAssets.Usable(texture)`；返回值紧邻使用处：`BinaryExpressionSyntax: art.Texture is { } texture && AvatarAssets.Usable(texture)`
- `NationalSpire.CareerAvatar.PortraitRegion(Godot.Texture2D)`；输入表达式：`PortraitRegion(texture)`；返回值紧邻使用处：`ArgumentSyntax: PortraitRegion(texture)`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(3, size.X * .1f)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(3, size.X * .1f)`

**赋值（含属性/字段和局部值）：**

- `shoulders[i]` = `origin + Vector2.FromAngle(Mathf.Pi + Mathf.Pi * i / (shoulders.Length - 1)) * (size.X * .27f)`

<a id="symbol-e94ed9976fb6"></a>

## `NationalSpire.CareerAvatar.DrawHonors(NationalSpire.AvatarIdentity) — private void DrawHonors(AvatarIdentity identity)`

来源：源码第 117 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerAvatar._Draw()`](CareerAvatars.cs.md#symbol-d0d51d45c800)

**调用：** [`At(float, float)`](CareerAvatars.cs.md#symbol-e35912f0068f)；[`Line(float, float, float, float)`](CareerAvatars.cs.md#symbol-84f4c37cf199)；[`NationalSpire.AffectionArt.Texture(string)`](AffectionVisuals.cs.md#symbol-966474984d6a)；[`NationalSpire.CareerAvatar.DrawMetalFrame(NationalSpire.AvatarFrame)`](AvatarFrameDrawing.cs.md#symbol-85654168c2bc)；`Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；`Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float)`；`Godot.CanvasItem.DrawString(Godot.Font, Godot.Vector2, string, Godot.HorizontalAlignment, float, int, Godot.Color?, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation, float)`；`Godot.CanvasItem.DrawTextureRect(Godot.Texture2D, Godot.Rect2, bool, Godot.Color?, bool)`；`Godot.Color.Color(string)`；`Godot.Color.Lightened(float)`；`Godot.Control.GetThemeDefaultFont()`；`Godot.Font.GetAscent(int)`；`Godot.Font.GetDescent(int)`；`Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.Vector2.Vector2(float, float)`；`int.ToString(System.IFormatProvider?)`；`System.Math.Clamp(float, float, float)`；`System.Math.Max(float, float)`

**字段、属性、事件及方法组引用：** `At(float, float)`；`Line(float, float, float, float)`；`NationalSpire.AffectionArt.Texture(string)`；`NationalSpire.AvatarFrame.Color`；`NationalSpire.AvatarFrame.Grade`；`NationalSpire.AvatarIdentity.Ascension`；`NationalSpire.AvatarIdentity.DisplayFrame`；`NationalSpire.AvatarIdentity.Role`；`NationalSpire.AvatarIdentity.SelectedFrame`；`NationalSpire.AvatarIdentity.UseOathFrame`；`NationalSpire.CareerAvatar.DrawMetalFrame(NationalSpire.AvatarFrame)`

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
- `Godot.CanvasItem.DrawString(Godot.Font, Godot.Vector2, string, Godot.HorizontalAlignment, float, int, Godot.Color?, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation, float)`；输入表达式：`DrawString(font,center + new Vector2(-size.X/2,(font.GetAscent(fontSize)-font.GetDescent(fontSize))/2),                  number,fontSize:fontSize,modulate:Colors.White)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawString(font,center + new Vector2(-size.X/2,(font.GetAscent(fontSize)-font.GetDescent(fontSize))/2),                  number,fontSize:fontSize,modulate:Colors.White);`
- `Godot.CanvasItem.DrawTextureRect(Godot.Texture2D, Godot.Rect2, bool, Godot.Color?, bool)`；输入表达式：`DrawTextureRect(AffectionArt.Texture("frame-" + identity.SelectedFrame), new Rect2(Vector2.Zero, Size), false)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawTextureRect(AffectionArt.Texture("frame-" + identity.SelectedFrame), new Rect2(Vector2.Zero, Size), false);`
- `Godot.CanvasItem.DrawTextureRect(Godot.Texture2D, Godot.Rect2, bool, Godot.Color?, bool)`；输入表达式：`DrawTextureRect(AffectionArt.Texture("oath-frame"), new Rect2(-Size * .1f, Size * 1.2f), false)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawTextureRect(AffectionArt.Texture("oath-frame"), new Rect2(-Size * .1f, Size * 1.2f), false);`
- `Godot.Color.Color(string)`；输入表达式：`new Color("06101c")`；返回值紧邻使用处：`ArgumentSyntax: new Color("06101c")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("0c1925")`；返回值紧邻使用处：`ArgumentSyntax: new Color("0c1925")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("7cc5c0")`；返回值紧邻使用处：`ArgumentSyntax: new Color("7cc5c0")`
- `Godot.Color.Color(string)`；输入表达式：`new Color(identity.UseOathFrame ? "dce6f1" : identity.DisplayFrame.Color)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Color(identity.UseOathFrame ? "dce6f1" : identity.DisplayFrame.Color)`
- `Godot.Color.Lightened(float)`；输入表达式：`color.Lightened(.35f)`；返回值紧邻使用处：`ArgumentSyntax: color.Lightened(.35f)`
- `Godot.Control.GetThemeDefaultFont()`；输入表达式：`GetThemeDefaultFont()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GetThemeDefaultFont()`
- `Godot.Font.GetAscent(int)`；输入表达式：`font.GetAscent(fontSize)`；返回值紧邻使用处：`BinaryExpressionSyntax: font.GetAscent(fontSize)-font.GetDescent(fontSize)`
- `Godot.Font.GetDescent(int)`；输入表达式：`font.GetDescent(fontSize)`；返回值紧邻使用处：`BinaryExpressionSyntax: font.GetAscent(fontSize)-font.GetDescent(fontSize)`
- `Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；输入表达式：`font.GetStringSize(number,fontSize:fontSize)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = font.GetStringSize(number,fontSize:fontSize)`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(-Size * .1f, Size * 1.2f)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(-Size * .1f, Size * 1.2f)`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(At(-4, -4), new Vector2(8, 7) * unit)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(At(-4, -4), new Vector2(8, 7) * unit)`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(Vector2.Zero, Size)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(Vector2.Zero, Size)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-size.X/2,(font.GetAscent(fontSize)-font.GetDescent(fontSize))/2)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(-size.X/2,(font.GetAscent(fontSize)-font.GetDescent(fontSize))/2)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(8, 7)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(8, 7) * unit`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(radius + 1, h - radius - 1)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Vector2(radius + 1, h - radius - 1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(w - radius - 1, h - radius - 1)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Vector2(w - radius - 1, h - radius - 1)`
- `int.ToString(System.IFormatProvider?)`；输入表达式：`identity.Ascension.ToString(System.Globalization.CultureInfo.InvariantCulture)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = identity.Ascension.ToString(System.Globalization.CultureInfo.InvariantCulture)`
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
- `NationalSpire.AffectionArt.Texture(string)`；输入表达式：`AffectionArt.Texture("frame-" + identity.SelectedFrame)`；返回值紧邻使用处：`ArgumentSyntax: AffectionArt.Texture("frame-" + identity.SelectedFrame)`
- `NationalSpire.AffectionArt.Texture(string)`；输入表达式：`AffectionArt.Texture("oath-frame")`；返回值紧邻使用处：`ArgumentSyntax: AffectionArt.Texture("oath-frame")`
- `NationalSpire.CareerAvatar.DrawMetalFrame(NationalSpire.AvatarFrame)`；输入表达式：`DrawMetalFrame(identity.DisplayFrame)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawMetalFrame(identity.DisplayFrame);`
- `System.Math.Clamp(float, float, float)`；输入表达式：`Math.Clamp(w * .175f, 7, 17)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Clamp(w * .175f, 7, 17)`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(1.5f, radius * .16f)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(1.5f, radius * .16f)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e35912f0068f"></a>

## `At(float, float) — Vector2 At(float x, float y)`

来源：源码第 144 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Line(float, float, float, float)`](CareerAvatars.cs.md#symbol-84f4c37cf199)；[`NationalSpire.CareerAvatar.DrawHonors(NationalSpire.AvatarIdentity)`](CareerAvatars.cs.md#symbol-e94ed9976fb6)

**调用：** `Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(x, y)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(x, y) * unit`

**赋值（含属性/字段和局部值）：**


<a id="symbol-84f4c37cf199"></a>

## `Line(float, float, float, float) — void Line(float x, float y, float x2, float y2)`

来源：源码第 145 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerAvatar.DrawHonors(NationalSpire.AvatarIdentity)`](CareerAvatars.cs.md#symbol-e94ed9976fb6)

**调用：** [`At(float, float)`](CareerAvatars.cs.md#symbol-e35912f0068f)；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`

**字段、属性、事件及方法组引用：** `At(float, float)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `At(float, float)`；输入表达式：`At(x, y)`；返回值紧邻使用处：`ArgumentSyntax: At(x, y)`
- `At(float, float)`；输入表达式：`At(x2, y2)`；返回值紧邻使用处：`ArgumentSyntax: At(x2, y2)`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(At(x, y), At(x2, y2), Colors.White, 1.3f, true)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => DrawLine(At(x, y), At(x2, y2), Colors.White, 1.3f, true)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a00951e0b13d"></a>

## `NationalSpire.CareerScreen.AvatarWardrobe(NationalSpire.CareerData, Godot.VBoxContainer) — private void AvatarWardrobe(CareerData data, VBoxContainer box)`

来源：源码第 164 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

来源：源码第 185 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

来源：源码第 191 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

来源：源码第 199 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildDashboardShell()`](CareerDashboard.cs.md#symbol-168b77d78644)；[`NationalSpire.CareerScreen.CeremonyAwards(NationalSpire.CareerData, NationalSpire.CeremonyRecord)`](CeremonyScreen.cs.md#symbol-554512484279)；[`NationalSpire.CareerScreen.CeremonyHero(NationalSpire.CareerData, NationalSpire.CeremonyRecord)`](CeremonyScreen.cs.md#symbol-7344f4112178)；[`NationalSpire.CareerScreen.GroupBubble(string, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>?)`](GroupChatScreen.cs.md#symbol-870e7cca58c0)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.HomeIdentity(NationalSpire.CareerData, Godot.VBoxContainer)`](CareerDashboard.cs.md#symbol-69636991bb5e)；[`NationalSpire.CareerScreen.OpenPortraitDesigner(NationalSpire.CareerData, string)`](PortraitDesignScreen.cs.md#symbol-3bb5119a73ca)；[`NationalSpire.CareerScreen.PlayerBanner(NationalSpire.CareerData, string)`](BroadcastVisuals.cs.md#symbol-936e32073293)；[`NationalSpire.CareerScreen.PrivateIdentity(NationalSpire.CareerData, string, bool)`](PrivateMemoryScreen.cs.md#symbol-65caddca194f)；[`NationalSpire.CareerScreen.PrivateMemory()`](PrivateMemoryScreen.cs.md#symbol-942a4a496637)；[`NationalSpire.CareerScreen.RefreshGroupChat()`](GroupChatScreen.cs.md#symbol-b56fe79b2db7)；[`NationalSpire.CareerScreen.RosterCandidate(NationalSpire.CareerData, Godot.VBoxContainer, string, string)`](ClubRosterScreen.cs.md#symbol-e2f1b514a2f4)；[`NationalSpire.CareerScreen.RosterMember(NationalSpire.CareerData, NationalSpire.OwnedClubState, Godot.VBoxContainer, string, string, bool)`](ClubRosterScreen.cs.md#symbol-8191d4b2f80f)；[`NationalSpire.CareerScreen.WithAvatar(NationalSpire.CareerData, string, Godot.Control, int, bool)`](CareerAvatars.cs.md#symbol-830dff168a3d)；[`Participant(string, string, string, bool, string?)`](MatchArenaScreen.cs.md#symbol-c7b37568ec95)；[`ShowRows()`](CommunityShareScreen.cs.md#symbol-2e7b710b7d77)；[`ShowRows()`](PeoplePickerScreen.cs.md#symbol-2c92b42fbd16)

**调用：** [`NationalSpire.CareerScreen.BindPortrait(NationalSpire.CareerData, string, NationalSpire.CareerAvatar, Godot.Button?)`](CareerAvatars.cs.md#symbol-37774acf84fe)；[`NationalSpire.CareerScreen.OpenPerson(string)`](CareerNavigation.cs.md#symbol-4430ec2bce8b)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；`Godot.Color.Color(float, float, float, float)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.BroadcastButton.BroadcastButton()`；`NationalSpire.CareerAvatar.CareerAvatar()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerAvatar.PersonId`；`NationalSpire.CareerScreen.BindPortrait(NationalSpire.CareerData, string, NationalSpire.CareerAvatar, Godot.Button?)`；`NationalSpire.CareerScreen.OpenPerson(string)`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.AvatarControl`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(1.15f, 1.15f, 1.15f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: picture.Modulate = new Color(1.15f, 1.15f, 1.15f)`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride(state, new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride(state, new StyleBoxEmpty());`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`picture.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: picture.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`button.AddChild(picture)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddChild(picture);`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty()`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxEmpty()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(size, size)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(size, size)`
- `NationalSpire.BroadcastButton.BroadcastButton()`；输入表达式：`new BroadcastButton { CustomMinimumSize = new Vector2(size, size), SizeFlagsHorizontal = SizeFlags.ShrinkBegin,              SizeFlagsVertical = SizeFlags.ShrinkCenter, FocusMode = FocusModeEnum.All }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastButton { CustomMinimumSize = new Vector2(size, size), SizeFlagsHorizontal = SizeFlags.ShrinkBegin,              SizeFlagsVertical = SizeFlags.ShrinkCenter, FocusMode = FocusModeEnum.All }`
- `NationalSpire.CareerAvatar.CareerAvatar()`；输入表达式：`new CareerAvatar { PersonId = personId, CustomMinimumSize = new Vector2(size, size),              SizeFlagsHorizontal = SizeFlags.ShrinkBegin, SizeFlagsVertical = SizeFlags.ShrinkCenter }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CareerAvatar { PersonId = personId, CustomMinimumSize = new Vector2(size, size),              SizeFlagsHorizontal = SizeFlags.ShrinkBegin, SizeFlagsVertical = SizeFlags.ShrinkCenter }`
- `NationalSpire.CareerScreen.BindPortrait(NationalSpire.CareerData, string, NationalSpire.CareerAvatar, Godot.Button?)`；输入表达式：`BindPortrait(data, personId, picture, button)`；返回值紧邻使用处：`ExpressionStatementSyntax: BindPortrait(data, personId, picture, button);`
- `NationalSpire.CareerScreen.BindPortrait(NationalSpire.CareerData, string, NationalSpire.CareerAvatar, Godot.Button?)`；输入表达式：`BindPortrait(data, personId, picture)`；返回值紧邻使用处：`ExpressionStatementSyntax: BindPortrait(data, personId, picture);`
- `NationalSpire.CareerScreen.OpenPerson(string)`；输入表达式：`OpenPerson(personId)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenPerson(personId)`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.AvatarControl)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.AvatarControl)`

**赋值（含属性/字段和局部值）：**

- `button.MouseEntered` += `() => picture.Modulate = new Color(1.15f, 1.15f, 1.15f)`
- `button.MouseExited` += `() => picture.Modulate = Colors.White`
- `button.Pressed` += `open ?? (() => OpenPerson(personId))`
- `CustomMinimumSize` = `new Vector2(size, size)`
- `FocusMode` = `FocusModeEnum.All`
- `PersonId` = `personId`
- `picture.Modulate` = `Colors.White`
- `picture.Modulate` = `new Color(1.15f, 1.15f, 1.15f)`
- `SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`

<a id="symbol-37774acf84fe"></a>

## `NationalSpire.CareerScreen.BindPortrait(NationalSpire.CareerData, string, NationalSpire.CareerAvatar, Godot.Button?) — private static void BindPortrait(CareerData data, string id, CareerAvatar picture, Button? button = null)`

来源：源码第 215 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`](CareerAvatars.cs.md#symbol-9f2c4623a902)；[`NationalSpire.CareerScreen.UpdateHeaderAccount(NationalSpire.CareerData)`](CareerDashboard.cs.md#symbol-52ec8ee2b3ad)

**调用：** [`NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`](AvatarHonors.cs.md#symbol-5207a1627331)；[`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-cd3d95caefab)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.AvatarIdentity.Description`；`NationalSpire.CareerAvatar.Art`；`NationalSpire.CareerAvatar.Identity`；`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`AvatarHonors.ForPerson(data, id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AvatarHonors.ForPerson(data, id)`
- `NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`CareerAvatars.ForPerson(data, id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerAvatars.ForPerson(data, id)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.DisplayName(data, id) + " · "`

**赋值（含属性/字段和局部值）：**

- `button.TooltipText` = `CareerEngine.DisplayName(data, id) + " · " + identity.Description + "\n查看人物档案"`
- `picture.Art` = `art`
- `picture.Identity` = `identity`
- `picture.TooltipText` = `identity.Description`

<a id="symbol-830dff168a3d"></a>

## `NationalSpire.CareerScreen.WithAvatar(NationalSpire.CareerData, string, Godot.Control, int, bool) — private HBoxContainer WithAvatar(CareerData data, string id, Control content, int size = 52, bool clickable = true)`

来源：源码第 225 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPostCard(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.Container)`](CareerScreen.cs.md#symbol-ce65b4128fee)；[`NationalSpire.CareerScreen.CeremonyRanking(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CeremonyRank>)`](CeremonyScreen.cs.md#symbol-73500bb64a58)；[`NationalSpire.CareerScreen.Competition(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CareerWorldScreen.cs.md#symbol-35113b1f49bd)；[`NationalSpire.CareerScreen.PersonLink(NationalSpire.CareerData, string, string, int)`](CareerAvatars.cs.md#symbol-89d5865e1272)；[`NationalSpire.CareerScreen.RenderDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-1799ee450143)；[`NationalSpire.CareerScreen.RenderPostHeader(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-4c514e4927ad)；[`NationalSpire.CareerScreen.RenderTeam()`](CareerSession.cs.md#symbol-0aab3af4bc96)

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

来源：源码第 230 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubMarket(NationalSpire.CareerData, bool)`](OwnedClubScreen.cs.md#symbol-b1e2f4fe72a4)；[`NationalSpire.CareerScreen.ClubSummary(NationalSpire.CareerData, NationalSpire.CareerClub, Godot.Container)`](CareerWorldScreen.cs.md#symbol-119e71d5db33)；[`NationalSpire.CareerScreen.Competition(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CareerWorldScreen.cs.md#symbol-35113b1f49bd)；[`NationalSpire.CareerScreen.FanChart(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-509582b2b893)；[`NationalSpire.CareerScreen.Honors(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-fd656e0e98e6)；[`NationalSpire.CareerScreen.NationRanking(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-b665478390f0)；[`NationalSpire.CareerScreen.OwnedClubPanel(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-d7bcae181c6a)；[`NationalSpire.CareerScreen.PersonProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](ProfileScreen.cs.md#symbol-2d802d5a07b9)；[`NationalSpire.CareerScreen.WorldHonors(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-3c1f80d447a9)；[`Side(bool)`](BroadcastVisuals.cs.md#symbol-c3c634913058)；[`Side(System.Collections.Generic.List<NationalSpire.CompetitionPlayer>, string)`](SettlementScreen.cs.md#symbol-719dd946cfee)

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
