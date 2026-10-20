# RandomEventArt.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`CC154400CD94F4214208911652CCFE66BEDC53A474F66B30ABA4C60AC10F00E8`。来源：[源码](../../RandomEventArt.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.RandomEventArt`、`NationalSpire.EventEmblem`。

字段、事件及初始值（源码原样）：

```csharp
public const string UnknownIcon = "res://images/atlases/ui_atlas.sprites/map/icons/map_unknown.tres";
private static readonly Dictionary<string, string[]> Pools = new()
    {
        ["日常"] = ["living_room", "park", "bg_cityRiver_day", "game:wood_carvings"],
        ["饮食"] = ["gourmet_street", "restaurant", "kitchen", "game:tea_master"],
        ["阅读"] = ["art_museum", "living_room", "game:self_help_book", "game:waterlogged_scriptorium"],
        ["户外"] = ["park", "bg_cityRiver_day", "manor_exterior", "game:dense_vegetation"],
        ["夜色"] = ["bg_cityRiver_night", "aurora_street", "bg_cityRiver_evening"],
        ["训练"] = ["training_room", "championship_contest_venue", "game:battleworn_dummy"],
        ["手作"] = ["training_room", "art_museum", "game:wood_carvings", "game:tinker_time"],
        ["交易"] = ["auction", "gourmet_street", "game:relic_trader"],
        ["相聚"] = ["living_room", "restaurant", "park", "game:round_tea_party"],
        ["音乐"] = ["concert_hall", "livehouse", "ktv"],
    };
private Texture2D? _icon;
```

<a id="symbol-1d9dc9e2c817"></a>

## `NationalSpire.RandomEventArt.Category(string) — public static string Category(string seed)`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.RandomEventArt.Category(NationalSpire.RandomEventRecord)`](RandomEventArt.cs.md#symbol-4d27d6b0c40b)

**调用：** [`NationalSpire.RandomEventSeeds.Category(string)`](RandomEventSeeds.cs.md#symbol-be664de1cd8d)

**字段、属性、事件及方法组引用：** `NationalSpire.RandomEventSeeds.Category(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RandomEventSeeds.Category(string)`；输入表达式：`RandomEventSeeds.Category(seed)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => RandomEventSeeds.Category(seed)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4d27d6b0c40b"></a>

## `NationalSpire.RandomEventArt.Category(NationalSpire.RandomEventRecord) — public static string Category(RandomEventRecord e)`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EventStoryView.Display(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.EventLive?, bool)`](RandomEventScreen.cs.md#symbol-f847e9f29b0e)；[`NationalSpire.RandomEventArt.Select(NationalSpire.RandomEventRecord)`](RandomEventArt.cs.md#symbol-e34111fd0431)

**调用：** [`NationalSpire.RandomEventArt.Category(string)`](RandomEventArt.cs.md#symbol-1d9dc9e2c817)

**字段、属性、事件及方法组引用：** `NationalSpire.RandomEventArt.Category(string)`；`NationalSpire.RandomEventRecord.Category`；`NationalSpire.RandomEventRecord.Seed`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RandomEventArt.Category(string)`；输入表达式：`Category(e.Seed)`；返回值紧邻使用处：`ConditionalExpressionSyntax: e.Category.Length > 0 ? e.Category : Category(e.Seed)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e34111fd0431"></a>

## `NationalSpire.RandomEventArt.Select(NationalSpire.RandomEventRecord) — public static string Select(RandomEventRecord e)`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EventStoryView.Display(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.EventLive?, bool)`](RandomEventScreen.cs.md#symbol-f847e9f29b0e)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.RandomEventArt.Category(NationalSpire.RandomEventRecord)`](RandomEventArt.cs.md#symbol-4d27d6b0c40b)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.RandomEventArt.Category(NationalSpire.RandomEventRecord)`；`NationalSpire.RandomEventArt.Pools`；`NationalSpire.RandomEventRecord.Id`；`NationalSpire.RandomEventRecord.Seed`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(e.Id + ":art:" + e.Seed)`；返回值紧邻使用处：`CastExpressionSyntax: (uint)CareerEngine.StableHash(e.Id + ":art:" + e.Seed)`
- `NationalSpire.RandomEventArt.Category(NationalSpire.RandomEventRecord)`；输入表达式：`Category(e)`；返回值紧邻使用处：`ArgumentSyntax: Category(e)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5147b98e47ca"></a>

## `NationalSpire.RandomEventArt.Load(string) — public static Texture2D? Load(string id)`

来源：源码第 30 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ShowJourneyEncounter()`](EventJourneyScreen.cs.md#symbol-4e94d6a77974)；[`NationalSpire.EventStoryView.Display(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.EventLive?, bool)`](RandomEventScreen.cs.md#symbol-f847e9f29b0e)

**调用：** [`NationalSpire.DateSceneBackgrounds.Read(out string, string?)`](DateSceneBackgrounds.cs.md#symbol-b6c3bc7d87d9)；[`NationalSpire.DateSceneView.CreateBackground(string)`](DateSceneView.cs.md#symbol-30a197722f91)；`Godot.GD.Load<T>(string)`；`Godot.ResourceLoader.Exists(string, string)`；`string.StartsWith(string, System.StringComparison)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneBackground.Id`；`NationalSpire.DateSceneBackground.Image`；`NationalSpire.DateSceneBackgrounds.Read(out string, string?)`；`NationalSpire.DateSceneView.CreateBackground(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GD.Load<T>(string)`；输入表达式：`GD.Load<Texture2D>(path)`；返回值紧邻使用处：`ConditionalExpressionSyntax: ResourceLoader.Exists(path) ? GD.Load<Texture2D>(path) : null`
- `Godot.ResourceLoader.Exists(string, string)`；输入表达式：`ResourceLoader.Exists(path)`；返回值紧邻使用处：`ConditionalExpressionSyntax: ResourceLoader.Exists(path) ? GD.Load<Texture2D>(path) : null`
- `NationalSpire.DateSceneBackgrounds.Read(out string, string?)`；输入表达式：`DateSceneBackgrounds.Read(out _)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateSceneBackgrounds.Read(out _).FirstOrDefault`
- `NationalSpire.DateSceneView.CreateBackground(string)`；输入表达式：`DateSceneView.CreateBackground(entry.Image)`；返回值紧邻使用处：`ConditionalExpressionSyntax: entry == null ? null : DateSceneView.CreateBackground(entry.Image)`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`id.StartsWith("game:", StringComparison.Ordinal)`；返回值紧邻使用处：`IfStatementSyntax: if (id.StartsWith("game:", StringComparison.Ordinal))          {              string path = "res://images/events/" + id[5..] + ".png";              return ResourceLoader.Exists(path) ? GD.Load<Texture2D>(path) : null;          }`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`DateSceneBackgrounds.Read(out _).FirstOrDefault(b => b.Id == id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateSceneBackgrounds.Read(out _).FirstOrDefault(b => b.Id == id)`

**赋值（含属性/字段和局部值）：**

- `id` = `"bg_cityRiver_evening"`

<a id="symbol-b4f1de4518b3"></a>

## `NationalSpire.EventEmblem._Ready() — public override void _Ready()`

来源：源码第 47 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.AtlasTexture.AtlasTexture()`；`Godot.GD.Load<T>(string)`；`Godot.ResourceLoader.Exists(string, string)`

**字段、属性、事件及方法组引用：** `NationalSpire.EventEmblem._icon`；`NationalSpire.RandomEventArt.UnknownIcon`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.AtlasTexture.AtlasTexture()`；输入表达式：`new AtlasTexture { Atlas = atlas.Atlas, Region = atlas.Region }`；返回值紧邻使用处：`ConditionalExpressionSyntax: icon is AtlasTexture atlas ? new AtlasTexture { Atlas = atlas.Atlas, Region = atlas.Region } : icon`
- `Godot.GD.Load<T>(string)`；输入表达式：`GD.Load<Texture2D>(RandomEventArt.UnknownIcon)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GD.Load<Texture2D>(RandomEventArt.UnknownIcon)`
- `Godot.ResourceLoader.Exists(string, string)`；输入表达式：`ResourceLoader.Exists(RandomEventArt.UnknownIcon)`；返回值紧邻使用处：`IfStatementSyntax: if (ResourceLoader.Exists(RandomEventArt.UnknownIcon))          {              var icon = GD.Load<Texture2D>(RandomEventArt.UnknownIcon);              _icon = icon is AtlasTexture atlas ? new AtlasTexture { Atlas = atlas.Atlas, Region = atlas.Region } : icon;          }`

**赋值（含属性/字段和局部值）：**

- `_icon` = `icon is AtlasTexture atlas ? new AtlasTexture { Atlas = atlas.Atlas, Region = atlas.Region } : icon`
- `Atlas` = `atlas.Atlas`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Region` = `atlas.Region`
- `Resized` += `QueueRedraw`

<a id="symbol-6e57b64df6f1"></a>

## `NationalSpire.EventEmblem._Draw() — public override void _Draw()`

来源：源码第 57 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；`Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；`Godot.CanvasItem.DrawString(Godot.Font, Godot.Vector2, string, Godot.HorizontalAlignment, float, int, Godot.Color?, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation, float)`；`Godot.CanvasItem.DrawTextureRect(Godot.Texture2D, Godot.Rect2, bool, Godot.Color?, bool)`；`Godot.Color.Color(string)`；`Godot.Control.GetThemeDefaultFont()`；`Godot.Font.GetAscent(int)`；`Godot.Font.GetDescent(int)`；`Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.Vector2.Vector2(float, float)`；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Teal`；`NationalSpire.EventEmblem._icon`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(c, r, -.3f, Mathf.Pi * .82f, 30, gold, 1, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(c, r, -.3f, Mathf.Pi * .82f, 30, gold, 1, true);`
- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(c, r, Mathf.Pi - .3f, Mathf.Pi * 1.82f, 30, gold, 1, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(c, r, Mathf.Pi - .3f, Mathf.Pi * 1.82f, 30, gold, 1, true);`
- `Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；输入表达式：`DrawCircle(c, r, new Color("182d3b"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawCircle(c, r, new Color("182d3b"));`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon([p + new Vector2(-3, 0), p + new Vector2(0, -3), p + new Vector2(3, 0), p + new Vector2(0, 3)], CareerVisuals.Teal)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon([p + new Vector2(-3, 0), p + new Vector2(0, -3), p + new Vector2(3, 0), p + new Vector2(0, 3)], CareerVisuals.Teal);`
- `Godot.CanvasItem.DrawString(Godot.Font, Godot.Vector2, string, Godot.HorizontalAlignment, float, int, Godot.Color?, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation, float)`；输入表达式：`DrawString(font, c + new Vector2(-measure.X / 2, (font.GetAscent(size) - font.GetDescent(size)) / 2), "?", fontSize: size, modulate: gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawString(font, c + new Vector2(-measure.X / 2, (font.GetAscent(size) - font.GetDescent(size)) / 2), "?", fontSize: size, modulate: gold);`
- `Godot.CanvasItem.DrawTextureRect(Godot.Texture2D, Godot.Rect2, bool, Godot.Color?, bool)`；输入表达式：`DrawTextureRect(_icon, new Rect2(c - Vector2.One * r * .76f, Vector2.One * r * 1.52f), false, gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawTextureRect(_icon, new Rect2(c - Vector2.One * r * .76f, Vector2.One * r * 1.52f), false, gold);`
- `Godot.Color.Color(string)`；输入表达式：`new Color("182d3b")`；返回值紧邻使用处：`ArgumentSyntax: new Color("182d3b")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("c7ae7a")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Color("c7ae7a")`
- `Godot.Control.GetThemeDefaultFont()`；输入表达式：`GetThemeDefaultFont()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GetThemeDefaultFont()`
- `Godot.Font.GetAscent(int)`；输入表达式：`font.GetAscent(size)`；返回值紧邻使用处：`BinaryExpressionSyntax: font.GetAscent(size) - font.GetDescent(size)`
- `Godot.Font.GetDescent(int)`；输入表达式：`font.GetDescent(size)`；返回值紧邻使用处：`BinaryExpressionSyntax: font.GetAscent(size) - font.GetDescent(size)`
- `Godot.Font.GetStringSize(string, Godot.HorizontalAlignment, float, int, Godot.TextServer.JustificationFlag, Godot.TextServer.Direction, Godot.TextServer.Orientation)`；输入表达式：`font.GetStringSize("?", fontSize: size)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = font.GetStringSize("?", fontSize: size)`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(c - Vector2.One * r * .76f, Vector2.One * r * 1.52f)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(c - Vector2.One * r * .76f, Vector2.One * r * 1.52f)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-3, 0)`；返回值紧邻使用处：`BinaryExpressionSyntax: p + new Vector2(-3, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-measure.X / 2, (font.GetAscent(size) - font.GetDescent(size)) / 2)`；返回值紧邻使用处：`BinaryExpressionSyntax: c + new Vector2(-measure.X / 2, (font.GetAscent(size) - font.GetDescent(size)) / 2)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, -3)`；返回值紧邻使用处：`BinaryExpressionSyntax: p + new Vector2(0, -3)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, 3)`；返回值紧邻使用处：`BinaryExpressionSyntax: p + new Vector2(0, 3)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(3, 0)`；返回值紧邻使用处：`BinaryExpressionSyntax: p + new Vector2(3, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(sign * r, 0)`；返回值紧邻使用处：`BinaryExpressionSyntax: c + new Vector2(sign * r, 0)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(Size.X, Size.Y)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Min(Size.X, Size.Y) * .43f`

**赋值（含属性/字段和局部值）：**
