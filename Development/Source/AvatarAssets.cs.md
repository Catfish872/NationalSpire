# AvatarAssets.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`0ACCCEF4221F69C56019BB1FC20B3ACAE713385CAAE07570ADA25AEA07DC7AD0`。来源：[源码](../../AvatarAssets.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.AvatarAssets`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly Dictionary<string, AvatarArt> Cache = new(StringComparer.Ordinal);
private static readonly Dictionary<string, AvatarArt> WeeklyCache = new();
private static readonly Dictionary<string, string> CharacterAliases = new(StringComparer.OrdinalIgnoreCase)
    {
        ["铁甲战士"] = "IRONCLAD", ["静默猎手"] = "SILENT", ["故障机器人"] = "DEFECT",
        ["亡灵契约师"] = "NECROBINDER", ["储君"] = "REGENT"
    };
```

<a id="symbol-2e945d7b39a4"></a>

## `NationalSpire.AvatarAssets.Invalidate() — public static void Invalidate()`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MenuPatch.Postfix(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu)`](GameBridge.cs.md#symbol-6939e359db40)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarAssets.Cache`；`NationalSpire.AvatarAssets.WeeklyCache`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`Cache.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: Cache.Clear();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`WeeklyCache.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: WeeklyCache.Clear();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-00e6fbec5eac"></a>

## `NationalSpire.AvatarAssets.Load(string, int, bool, int) — public static AvatarArt Load(string character, int variation, bool preferCard, int newsImportance = 0)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`AutomaticPortrait()`](CharacterCardScreen.cs.md#symbol-545b829b2369)；[`NationalSpire.AvatarAssets.LoadWeekly(NationalSpire.CareerData, NationalSpire.WeeklyEdition, NationalSpire.WeeklySlide)`](AvatarAssets.cs.md#symbol-92f1e0aef1b2)；[`NationalSpire.AvatarSources.Characters()`](AvatarSources.cs.md#symbol-6c772247bc69)；[`NationalSpire.CareerAvatars.Automatic(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-2bfa078d007b)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)；[`NationalSpire.CareerScreen.WithCharacterAvatar(string, Godot.Control)`](CareerAvatars.cs.md#symbol-eadfa70c0822)

**调用：** [`Card()`](AvatarAssets.cs.md#symbol-93fdb45d3092)；[`NationalSpire.AvatarAssets.ResolveCharacter(string)`](AvatarAssets.cs.md#symbol-4587b5cfa519)；[`NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`](AvatarAssets.cs.md#symbol-1d4beb6f533e)；`Godot.Color.Lightened(float)`；`Godot.ResourceLoader.Exists(string, string)`；`Godot.ResourceLoader.Load<T>(string, string, Godot.ResourceLoader.CacheMode)`；`MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；`NationalSpire.AvatarArt.AvatarArt(Godot.Texture2D?, Godot.Color, string)`；`string.Contains(string, System.StringComparison)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `Card()`；`NationalSpire.AvatarArt.Texture`；`NationalSpire.AvatarAssets.Cache`；`NationalSpire.AvatarAssets.ResolveCharacter(string)`；`NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`；`NationalSpire.CareerVisuals.Teal`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Card()`；输入表达式：`Card()`；返回值紧邻使用处：`IsPatternExpressionSyntax: Card() is { } art`
- `Card()`；输入表达式：`Card()`；返回值紧邻使用处：`IsPatternExpressionSyntax: Card() is { } fallback`
- `Godot.Color.Lightened(float)`；输入表达式：`model.NameColor.Lightened(.25f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: color = model.NameColor.Lightened(.25f)`
- `Godot.ResourceLoader.Exists(string, string)`；输入表达式：`ResourceLoader.Exists(path)`；返回值紧邻使用处：`BinaryExpressionSyntax: ResourceLoader.Exists(path) && ResourceLoader.Load<Texture2D>(path) is { } texture`
- `Godot.ResourceLoader.Load<T>(string, string, Godot.ResourceLoader.CacheMode)`；输入表达式：`ResourceLoader.Load<Texture2D>(path)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ResourceLoader.Load<Texture2D>(path) is { } texture`
- `MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；输入表达式：`model.Title.GetFormattedText()`；返回值紧邻使用处：`ArgumentSyntax: model.Title.GetFormattedText()`
- `NationalSpire.AvatarArt.AvatarArt(Godot.Texture2D?, Godot.Color, string)`；输入表达式：`new(icon, color, model.Title.GetFormattedText())`；返回值紧邻使用处：`AssignmentExpressionSyntax: Cache[key] = new(icon, color, model.Title.GetFormattedText())`
- `NationalSpire.AvatarArt.AvatarArt(Godot.Texture2D?, Godot.Color, string)`；输入表达式：`new(null, CareerVisuals.Teal, character.Length == 0 ? "尚无常用角色" : character)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Cache[key] = new(null, CareerVisuals.Teal, character.Length == 0 ? "尚无常用角色" : character)`
- `NationalSpire.AvatarArt.AvatarArt(Godot.Texture2D?, Godot.Color, string)`；输入表达式：`new(null, color, character)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Cache[key] = new(null, color, character)`
- `NationalSpire.AvatarArt.AvatarArt(Godot.Texture2D?, Godot.Color, string)`；输入表达式：`new(texture, color, model.Title.GetFormattedText())`；返回值紧邻使用处：`AssignmentExpressionSyntax: Cache[key] = new(texture, color, model.Title.GetFormattedText())`
- `NationalSpire.AvatarAssets.ResolveCharacter(string)`；输入表达式：`ResolveCharacter(character)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ResolveCharacter(character)`
- `NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`；输入表达式：`Usable(cached.Texture)`；返回值紧邻使用处：`BinaryExpressionSyntax: Cache.TryGetValue(key, out var cached) && Usable(cached.Texture)`
- `NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`；输入表达式：`Usable(icon)`；返回值紧邻使用处：`BinaryExpressionSyntax: model.IconTexture is { } icon && Usable(icon)`
- `NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`；输入表达式：`Usable(texture)`；返回值紧邻使用处：`BinaryExpressionSyntax: ResourceLoader.Exists(path) && ResourceLoader.Load<Texture2D>(path) is { } texture && Usable(texture)`
- `string.Contains(string, System.StringComparison)`；输入表达式：`p.Contains("character_icon_", StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => p.Contains("character_icon_", StringComparison.OrdinalIgnoreCase)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`Cache.Remove(key)`；返回值紧邻使用处：`ExpressionStatementSyntax: Cache.Remove(key);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Cache.TryGetValue(key, out var cached)`；返回值紧邻使用处：`BinaryExpressionSyntax: Cache.TryGetValue(key, out var cached) && Usable(cached.Texture)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`model.AssetPaths.Concat(model.AssetPathsCharacterSelect)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: model.AssetPaths.Concat(model.AssetPathsCharacterSelect).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`model.AssetPaths.Concat(model.AssetPathsCharacterSelect).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: model.AssetPaths.Concat(model.AssetPathsCharacterSelect).Distinct().Where`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`model.AssetPaths.Concat(model.AssetPathsCharacterSelect).Distinct().Where(p => p.Contains("character_icon_", StringComparison.OrdinalIgnoreCase))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var path in model.AssetPaths.Concat(model.AssetPathsCharacterSelect).Distinct().Where(p => p.Contains("character_icon_", StringComparison.OrdinalIgnoreCase)))                  if (ResourceLoader.Exists(path) && ResourceLoader.Load<Texture2D>(path) is { } texture && Usable(texture))                      return Cache[key] = new(texture, color, model.Title.GetFormattedText());`

**赋值（含属性/字段和局部值）：**

- `Cache[key]` = `art`
- `Cache[key]` = `fallback`
- `Cache[key]` = `new(icon, color, model.Title.GetFormattedText())`
- `Cache[key]` = `new(null, CareerVisuals.Teal, character.Length == 0 ? "尚无常用角色" : character)`
- `Cache[key]` = `new(null, color, character)`
- `Cache[key]` = `new(texture, color, model.Title.GetFormattedText())`
- `color` = `model.NameColor.Lightened(.25f)`
- `variation` = `preferCard ? (int)((uint)variation % 12) : 0`

<a id="symbol-93fdb45d3092"></a>

## `Card() — AvatarArt? Card()`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AvatarAssets.Load(string, int, bool, int)`](AvatarAssets.cs.md#symbol-00e6fbec5eac)

**调用：** [`NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`](AvatarAssets.cs.md#symbol-1d4beb6f533e)；[`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；`Godot.ResourceLoader.Exists(string, string)`；`Godot.ResourceLoader.Load<T>(string, string, Godot.ResourceLoader.CacheMode)`；`MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；`NationalSpire.AvatarArt.AvatarArt(Godot.Texture2D?, Godot.Color, string)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Enum.ToString()`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`；`NationalSpire.CareerEngine.StableHash(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ResourceLoader.Exists(string, string)`；输入表达式：`ResourceLoader.Exists(card.PortraitPath)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ResourceLoader.Exists(card.PortraitPath)`
- `Godot.ResourceLoader.Load<T>(string, string, Godot.ResourceLoader.CacheMode)`；输入表达式：`ResourceLoader.Load<Texture2D>(card.PortraitPath)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ResourceLoader.Load<Texture2D>(card.PortraitPath) is { } texture`
- `MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；输入表达式：`model.Title.GetFormattedText()`；返回值紧邻使用处：`BinaryExpressionSyntax: model.Title.GetFormattedText() + " · "`
- `NationalSpire.AvatarArt.AvatarArt(Godot.Texture2D?, Godot.Color, string)`；输入表达式：`new(texture, color, model.Title.GetFormattedText() + " · " + card.Title)`；返回值紧邻使用处：`ReturnStatementSyntax: return new(texture, color, model.Title.GetFormattedText() + " · " + card.Title);`
- `NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`；输入表达式：`Usable(texture)`；返回值紧邻使用处：`BinaryExpressionSyntax: ResourceLoader.Load<Texture2D>(card.PortraitPath) is { } texture && Usable(texture)`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(variation + ":" + c.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => CareerEngine.StableHash(variation + ":" + c.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`model.CardPool.AllCards.OrderByDescending(c => newsImportance > 0 && c.Rarity.ToString() == rarity)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: model.CardPool.AllCards.OrderByDescending(c => newsImportance > 0 && c.Rarity.ToString() == rarity)                      .ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`model.CardPool.AllCards.OrderByDescending(c => newsImportance > 0 && c.Rarity.ToString() == rarity)                      .ThenBy(c => CareerEngine.StableHash(variation + ":" + c.Id)).Take(8)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = model.CardPool.AllCards.OrderByDescending(c => newsImportance > 0 && c.Rarity.ToString() == rarity)                      .ThenBy(c => CareerEngine.StableHash(variation + ":" + c.Id)).Take(8)`
- `System.Enum.ToString()`；输入表达式：`c.Rarity.ToString()`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Rarity.ToString() == rarity`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`model.CardPool.AllCards.OrderByDescending(c => newsImportance > 0 && c.Rarity.ToString() == rarity)                      .ThenBy(c => CareerEngine.StableHash(variation + ":" + c.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: model.CardPool.AllCards.OrderByDescending(c => newsImportance > 0 && c.Rarity.ToString() == rarity)                      .ThenBy(c => CareerEngine.StableHash(variation + ":" + c.Id)).Take`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4587b5cfa519"></a>

## `NationalSpire.AvatarAssets.ResolveCharacter(string) — private static CharacterModel? ResolveCharacter(string character)`

来源：源码第 60 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AvatarAssets.Load(string, int, bool, int)`](AvatarAssets.cs.md#symbol-00e6fbec5eac)；[`NationalSpire.AvatarAssets.LoadWeekly(NationalSpire.CareerData, NationalSpire.WeeklyEdition, NationalSpire.WeeklySlide)`](AvatarAssets.cs.md#symbol-92f1e0aef1b2)

**调用：** [`NationalSpire.GameBridge.Characters()`](GameBridge.cs.md#symbol-1233494dda40)；`MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`string.Equals(string?, System.StringComparison)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarAssets.CharacterAliases`；`NationalSpire.GameBridge.Characters()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；输入表达式：`candidate.Title.GetFormattedText()`；返回值紧邻使用处：`BinaryExpressionSyntax: candidate.Title.GetFormattedText() == character`
- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`c.Id.ToString()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Id.ToString().Equals`
- `NationalSpire.GameBridge.Characters()`；输入表达式：`GameBridge.Characters()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var candidate in GameBridge.Characters())              {                  try { if (candidate.Title.GetFormattedText() == character) { model = candidate; break; } }                  catch { /* 单个 Mod 的本地化资源异常不影响其他角色。 */ }              }`
- `NationalSpire.GameBridge.Characters()`；输入表达式：`GameBridge.Characters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GameBridge.Characters().FirstOrDefault`
- `string.Equals(string?, System.StringComparison)`；输入表达式：`c.Id.Entry.Equals(alias, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Id.ToString().Equals(alias, StringComparison.OrdinalIgnoreCase)              || c.Id.Entry.Equals(alias, StringComparison.OrdinalIgnoreCase)`
- `string.Equals(string?, System.StringComparison)`；输入表达式：`c.Id.ToString().Equals(alias, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Id.ToString().Equals(alias, StringComparison.OrdinalIgnoreCase)              || c.Id.Entry.Equals(alias, StringComparison.OrdinalIgnoreCase)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`GameBridge.Characters().FirstOrDefault(c => c.Id.ToString().Equals(alias, StringComparison.OrdinalIgnoreCase)              || c.Id.Entry.Equals(alias, StringComparison.OrdinalIgnoreCase))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GameBridge.Characters().FirstOrDefault(c => c.Id.ToString().Equals(alias, StringComparison.OrdinalIgnoreCase)              || c.Id.Entry.Equals(alias, StringComparison.OrdinalIgnoreCase))`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`CharacterAliases.GetValueOrDefault(character, character)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CharacterAliases.GetValueOrDefault(character, character)`

**赋值（含属性/字段和局部值）：**

- `model` = `candidate`

<a id="symbol-5b05259c8c83"></a>

## `NationalSpire.AvatarAssets.LoadCard(string, string) — public static AvatarArt? LoadCard(string id, string description)`

来源：源码第 75 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CameoAssets.ForPerson(string)`](CameoAssets.cs.md#symbol-c95ad2877552)

**调用：** [`NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`](AvatarAssets.cs.md#symbol-1d4beb6f533e)；[`NationalSpire.GameBridge.Characters()`](GameBridge.cs.md#symbol-1233494dda40)；`Godot.ResourceLoader.Exists(string, string)`；`Godot.ResourceLoader.Load<T>(string, string, Godot.ResourceLoader.CacheMode)`；`NationalSpire.AvatarArt.AvatarArt(Godot.Texture2D?, Godot.Color, string)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarArt.Texture`；`NationalSpire.AvatarAssets.Cache`；`NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.GameBridge.Characters()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ResourceLoader.Exists(string, string)`；输入表达式：`ResourceLoader.Exists(card.PortraitPath)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ResourceLoader.Exists(card.PortraitPath)`
- `Godot.ResourceLoader.Load<T>(string, string, Godot.ResourceLoader.CacheMode)`；输入表达式：`ResourceLoader.Load<Texture2D>(card.PortraitPath)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ResourceLoader.Load<Texture2D>(card.PortraitPath)`
- `NationalSpire.AvatarArt.AvatarArt(Godot.Texture2D?, Godot.Color, string)`；输入表达式：`new(texture, CareerVisuals.Teal, description)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Cache[key] = new(texture, CareerVisuals.Teal, description)`
- `NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`；输入表达式：`Usable(cached.Texture)`；返回值紧邻使用处：`BinaryExpressionSyntax: Cache.TryGetValue(key, out var cached) && Usable(cached.Texture)`
- `NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`；输入表达式：`Usable(texture)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Usable(texture) ? Cache[key] = new(texture, CareerVisuals.Teal, description) : null`
- `NationalSpire.GameBridge.Characters()`；输入表达式：`GameBridge.Characters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GameBridge.Characters().SelectMany`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Cache.TryGetValue(key, out var cached)`；返回值紧邻使用处：`BinaryExpressionSyntax: Cache.TryGetValue(key, out var cached) && Usable(cached.Texture)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`GameBridge.Characters().SelectMany(c => c.CardPool.AllCards).FirstOrDefault(c => c.Id.Entry == id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GameBridge.Characters().SelectMany(c => c.CardPool.AllCards).FirstOrDefault(c => c.Id.Entry == id)`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`GameBridge.Characters().SelectMany(c => c.CardPool.AllCards)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GameBridge.Characters().SelectMany(c => c.CardPool.AllCards).FirstOrDefault`

**赋值（含属性/字段和局部值）：**

- `Cache[key]` = `new(texture, CareerVisuals.Teal, description)`

<a id="symbol-92f1e0aef1b2"></a>

## `NationalSpire.AvatarAssets.LoadWeekly(NationalSpire.CareerData, NationalSpire.WeeklyEdition, NationalSpire.WeeklySlide) — public static AvatarArt LoadWeekly(CareerData data, WeeklyEdition issue, WeeklySlide slide)`

来源：源码第 84 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.WeeklyArt(NationalSpire.WeeklyEdition, NationalSpire.WeeklySlide, bool)`](WeeklyScreen.cs.md#symbol-d6f13958bba4)

**调用：** [`NationalSpire.AvatarAssets.Load(string, int, bool, int)`](AvatarAssets.cs.md#symbol-00e6fbec5eac)；[`NationalSpire.AvatarAssets.ResolveCharacter(string)`](AvatarAssets.cs.md#symbol-4587b5cfa519)；[`NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`](AvatarAssets.cs.md#symbol-1d4beb6f533e)；[`NationalSpire.CameoAssets.ForStory(NationalSpire.WeeklySlide)`](CameoAssets.cs.md#symbol-89a6e69b1880)；[`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；[`NationalSpire.WeeklyArtChoice.Order(System.Collections.Generic.IEnumerable<NationalSpire.WeeklyArtChoice.Card>, int, string, System.Collections.Generic.IEnumerable<string>, System.Collections.Generic.IEnumerable<string>)`](WeeklyArtChoice.cs.md#symbol-f72366311c26)；`Godot.Color.Lightened(float)`；`Godot.ResourceLoader.Exists(string, string)`；`Godot.ResourceLoader.Load<T>(string, string, Godot.ResourceLoader.CacheMode)`；`MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`NationalSpire.AvatarArt.AvatarArt(Godot.Texture2D?, Godot.Color, string)`；`NationalSpire.WeeklyArtChoice.Card.Card(string, string)`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Enum.ToString()`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarArt.Texture`；`NationalSpire.AvatarAssets.Load(string, int, bool, int)`；`NationalSpire.AvatarAssets.ResolveCharacter(string)`；`NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`；`NationalSpire.AvatarAssets.WeeklyCache`；`NationalSpire.CameoAssets.ForStory(NationalSpire.WeeklySlide)`；`NationalSpire.CareerData.WeeklyEditions`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.WeeklyArtChoice.Order(System.Collections.Generic.IEnumerable<NationalSpire.WeeklyArtChoice.Card>, int, string, System.Collections.Generic.IEnumerable<string>, System.Collections.Generic.IEnumerable<string>)`；`NationalSpire.WeeklyEdition.ArtVersion`；`NationalSpire.WeeklyEdition.Slides`；`NationalSpire.WeeklyEdition.Week`；`NationalSpire.WeeklySlide.ArtCardId`；`NationalSpire.WeeklySlide.Character`；`NationalSpire.WeeklySlide.Id`；`NationalSpire.WeeklySlide.Importance`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Lightened(float)`；输入表达式：`model.NameColor.Lightened(.25f)`；返回值紧邻使用处：`ArgumentSyntax: model.NameColor.Lightened(.25f)`
- `Godot.ResourceLoader.Exists(string, string)`；输入表达式：`ResourceLoader.Exists(c.PortraitPath)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => ResourceLoader.Exists(c.PortraitPath)`
- `Godot.ResourceLoader.Exists(string, string)`；输入表达式：`ResourceLoader.Exists(card.PortraitPath)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ResourceLoader.Exists(card.PortraitPath)`
- `Godot.ResourceLoader.Load<T>(string, string, Godot.ResourceLoader.CacheMode)`；输入表达式：`ResourceLoader.Load<Texture2D>(card.PortraitPath)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ResourceLoader.Load<Texture2D>(card.PortraitPath)`
- `MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；输入表达式：`model.Title.GetFormattedText()`；返回值紧邻使用处：`BinaryExpressionSyntax: model.Title.GetFormattedText() + " · "`
- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`.Id.ToString()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: oldModel.CardPool.AllCards.OrderByDescending(c => old.Importance > 0 && c.Rarity.ToString() == rarity)                      .ThenBy(c => CareerEngine.StableHash(variant + ":" + c.Id)).Take(8)                      .FirstOrDefault(c => ResourceLoader.Exists(c.PortraitPath))?.Id.ToString()`
- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`c.Id.ToString()`；返回值紧邻使用处：`ArgumentSyntax: c.Id.ToString()`
- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`c.Id.ToString()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => c.Id.ToString()`
- `NationalSpire.AvatarArt.AvatarArt(Godot.Texture2D?, Godot.Color, string)`；输入表达式：`new(texture, model.NameColor.Lightened(.25f), model.Title.GetFormattedText() + " · " + card.Title)`；返回值紧邻使用处：`AssignmentExpressionSyntax: art = new(texture, model.NameColor.Lightened(.25f), model.Title.GetFormattedText() + " · " + card.Title)`
- `NationalSpire.AvatarAssets.Load(string, int, bool, int)`；输入表达式：`Load(slide.Character, 0, true, slide.Importance)`；返回值紧邻使用处：`ReturnStatementSyntax: return Load(slide.Character, 0, true, slide.Importance);`
- `NationalSpire.AvatarAssets.Load(string, int, bool, int)`；输入表达式：`Load(slide.Character, CareerEngine.StableHash(data.WorldId + issue.Week + slide.Id), true, slide.Importance)`；返回值紧邻使用处：`ReturnStatementSyntax: return Load(slide.Character, CareerEngine.StableHash(data.WorldId + issue.Week + slide.Id), true, slide.Importance);`
- `NationalSpire.AvatarAssets.ResolveCharacter(string)`；输入表达式：`ResolveCharacter(old.Character)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ResolveCharacter(old.Character)`
- `NationalSpire.AvatarAssets.ResolveCharacter(string)`；输入表达式：`ResolveCharacter(slide.Character)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ResolveCharacter(slide.Character)`
- `NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`；输入表达式：`Usable(art.Texture)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Usable(art.Texture)`
- `NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`；输入表达式：`Usable(texture)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Usable(texture)`
- `NationalSpire.CameoAssets.ForStory(NationalSpire.WeeklySlide)`；输入表达式：`CameoAssets.ForStory(slide)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CameoAssets.ForStory(slide) is { } cameo`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash($"weekly:{oldIssue.Week}:{old.Id}")`；返回值紧邻使用处：`CastExpressionSyntax: (uint)CareerEngine.StableHash($"weekly:{oldIssue.Week}:{old.Id}")`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(data.WorldId + issue.Week + slide.Id)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.StableHash(data.WorldId + issue.Week + slide.Id)`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(variant + ":" + c.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => CareerEngine.StableHash(variant + ":" + c.Id)`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(data);`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("weekly.art", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("weekly.art", e);`
- `NationalSpire.WeeklyArtChoice.Card.Card(string, string)`；输入表达式：`new WeeklyArtChoice.Card(c.Id.ToString(), c.Rarity.ToString())`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => new WeeklyArtChoice.Card(c.Id.ToString(), c.Rarity.ToString())`
- `NationalSpire.WeeklyArtChoice.Order(System.Collections.Generic.IEnumerable<NationalSpire.WeeklyArtChoice.Card>, int, string, System.Collections.Generic.IEnumerable<string>, System.Collections.Generic.IEnumerable<string>)`；输入表达式：`WeeklyArtChoice.Order(cards.Values.Select(c => new WeeklyArtChoice.Card(c.Id.ToString(), c.Rarity.ToString())),                  slide.Importance, $"{data.WorldId}:weekly:{issue.Week}:{slide.Id}", previous, same)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = WeeklyArtChoice.Order(cards.Values.Select(c => new WeeklyArtChoice.Card(c.Id.ToString(), c.Rarity.ToString())),                  slide.Importance, $"{data.WorldId}:weekly:{issue.Week}:{slide.Id}", previous, same)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`cards.ContainsKey(slide.ArtCardId)`；返回值紧邻使用处：`IfStatementSyntax: if (cards.ContainsKey(slide.ArtCardId)) order = new[] { slide.ArtCardId }.Concat(order).Distinct();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`WeeklyCache.Remove(WeeklyCache.Keys.First())`；返回值紧邻使用处：`ExpressionStatementSyntax: WeeklyCache.Remove(WeeklyCache.Keys.First());`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`WeeklyCache.TryGetValue(key, out var art)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !WeeklyCache.TryGetValue(key, out var art)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`new[] { slide.ArtCardId }.Concat(order)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { slide.ArtCardId }.Concat(order).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`new[] { slide.ArtCardId }.Concat(order).Distinct()`；返回值紧邻使用处：`AssignmentExpressionSyntax: order = new[] { slide.ArtCardId }.Concat(order).Distinct()`
- `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`model.CardPool.AllCards.DistinctBy(c => c.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: model.CardPool.AllCards.DistinctBy(c => c.Id).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；输入表达式：`WeeklyCache.Keys.First()`；返回值紧邻使用处：`ArgumentSyntax: WeeklyCache.Keys.First()`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.WeeklyEditions.First(w => w.Slides.Contains(old))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.WeeklyEditions.First(w => w.Slides.Contains(old))`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`oldModel.CardPool.AllCards.OrderByDescending(c => old.Importance > 0 && c.Rarity.ToString() == rarity)                      .ThenBy(c => CareerEngine.StableHash(variant + ":" + c.Id)).Take(8)                      .FirstOrDefault(c => ResourceLoader.Exists(c.PortraitPath))`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: oldModel.CardPool.AllCards.OrderByDescending(c => old.Importance > 0 && c.Rarity.ToString() == rarity)                      .ThenBy(c => CareerEngine.StableHash(variant + ":" + c.Id)).Take(8)                      .FirstOrDefault(c => ResourceLoader.Exists(c.PortraitPath))?.Id.ToString()`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`data.WeeklyEditions.Where(w => w.Week < issue.Week).OrderByDescending(w => w.Week)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.WeeklyEditions.Where(w => w.Week < issue.Week).OrderByDescending(w => w.Week).Take`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`oldModel.CardPool.AllCards.OrderByDescending(c => old.Importance > 0 && c.Rarity.ToString() == rarity)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: oldModel.CardPool.AllCards.OrderByDescending(c => old.Importance > 0 && c.Rarity.ToString() == rarity)                      .ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`cards.Values.Select(c => new WeeklyArtChoice.Card(c.Id.ToString(), c.Rarity.ToString()))`；返回值紧邻使用处：`ArgumentSyntax: cards.Values.Select(c => new WeeklyArtChoice.Card(c.Id.ToString(), c.Rarity.ToString()))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`issue.Slides.Where(s => s != slide).Select(s => s.ArtCardId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: issue.Slides.Where(s => s != slide).Select(s => s.ArtCardId).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`previousSlides.Select(s => s.ArtCardId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: previousSlides.Select(s => s.ArtCardId).Where`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`data.WeeklyEditions.Where(w => w.Week < issue.Week).OrderByDescending(w => w.Week).Take(2).SelectMany(w => w.Slides)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.WeeklyEditions.Where(w => w.Week < issue.Week).OrderByDescending(w => w.Week).Take(2).SelectMany(w => w.Slides).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`data.WeeklyEditions.Where(w => w.Week < issue.Week).OrderByDescending(w => w.Week).Take(2)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.WeeklyEditions.Where(w => w.Week < issue.Week).OrderByDescending(w => w.Week).Take(2).SelectMany`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`oldModel.CardPool.AllCards.OrderByDescending(c => old.Importance > 0 && c.Rarity.ToString() == rarity)                      .ThenBy(c => CareerEngine.StableHash(variant + ":" + c.Id)).Take(8)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: oldModel.CardPool.AllCards.OrderByDescending(c => old.Importance > 0 && c.Rarity.ToString() == rarity)                      .ThenBy(c => CareerEngine.StableHash(variant + ":" + c.Id)).Take(8)                      .FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`order.Take(16)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string id in order.Take(16))              {                  var card = cards[id];                  string key = model.Id + ":" + id;                  if (!WeeklyCache.TryGetValue(key, out var art) || !Usable(art.Texture))                  {                      if (!ResourceLoader.Exists(card.PortraitPath)) continue;                      try                      {                          var texture = ResourceLoader.Load<Texture2D>(card.PortraitPath);                          if (!Usable(texture)) continue;                          art = new(texture, model.NameColor.Lightened(.25f), model.Title.GetFormattedText() + " · " + card.Title);                          if (WeeklyCache.Count >= 64) WeeklyCache.Remove(WeeklyCache.Keys.First());                          WeeklyCache[key] = art;                      }                      catch { continue; }                  }                  if (slide.ArtCardId != id) { slide.ArtCardId = id; CareerStore.Save(data); }                  return art;              }`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`model.CardPool.AllCards.DistinctBy(c => c.Id).ToDictionary(c => c.Id.ToString())`；返回值紧邻使用处：`EqualsValueClauseSyntax: = model.CardPool.AllCards.DistinctBy(c => c.Id).ToDictionary(c => c.Id.ToString())`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`data.WeeklyEditions.Where(w => w.Week < issue.Week).OrderByDescending(w => w.Week).Take(2).SelectMany(w => w.Slides).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.WeeklyEditions.Where(w => w.Week < issue.Week).OrderByDescending(w => w.Week).Take(2).SelectMany(w => w.Slides).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.WeeklyEditions.Where(w => w.Week < issue.Week)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.WeeklyEditions.Where(w => w.Week < issue.Week).OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`issue.Slides.Where(s => s != slide).Select(s => s.ArtCardId).Where(id => id.Length > 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = issue.Slides.Where(s => s != slide).Select(s => s.ArtCardId).Where(id => id.Length > 0)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`issue.Slides.Where(s => s != slide)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: issue.Slides.Where(s => s != slide).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`previousSlides.Select(s => s.ArtCardId).Where(id => id.Length > 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = previousSlides.Select(s => s.ArtCardId).Where(id => id.Length > 0)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`previousSlides.Where(s => s.ArtCardId.Length == 0)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var old in previousSlides.Where(s => s.ArtCardId.Length == 0))              {                  var oldIssue = data.WeeklyEditions.First(w => w.Slides.Contains(old));                  if (oldIssue.ArtVersion > 0) continue;                  var oldModel = ResolveCharacter(old.Character);                  if (oldModel == null) continue;                  int variant = (int)((uint)CareerEngine.StableHash($"weekly:{oldIssue.Week}:{old.Id}") % 12);                  string rarity = old.Importance >= 3 ? "Rare" : old.Importance == 2 ? "Uncommon" : "Common";                  old.ArtCardId = oldModel.CardPool.AllCards.OrderByDescending(c => old.Importance > 0 && c.Rarity.ToString() == rarity)                      .ThenBy(c => CareerEngine.StableHash(variant + ":" + c.Id)).Take(8)                      .FirstOrDefault(c => ResourceLoader.Exists(c.PortraitPath))?.Id.ToString() ?? "";              }`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`w.Slides.Contains(old)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: w => w.Slides.Contains(old)`
- `System.Enum.ToString()`；输入表达式：`c.Rarity.ToString()`；返回值紧邻使用处：`ArgumentSyntax: c.Rarity.ToString()`
- `System.Enum.ToString()`；输入表达式：`c.Rarity.ToString()`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Rarity.ToString() == rarity`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`oldModel.CardPool.AllCards.OrderByDescending(c => old.Importance > 0 && c.Rarity.ToString() == rarity)                      .ThenBy(c => CareerEngine.StableHash(variant + ":" + c.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: oldModel.CardPool.AllCards.OrderByDescending(c => old.Importance > 0 && c.Rarity.ToString() == rarity)                      .ThenBy(c => CareerEngine.StableHash(variant + ":" + c.Id)).Take`

**赋值（含属性/字段和局部值）：**

- `art` = `new(texture, model.NameColor.Lightened(.25f), model.Title.GetFormattedText() + " · " + card.Title)`
- `old.ArtCardId` = `oldModel.CardPool.AllCards.OrderByDescending(c => old.Importance > 0 && c.Rarity.ToString() == rarity)                      .ThenBy(c => CareerEngine.StableHash(variant + ":" + c.Id)).Take(8)                      .FirstOrDefault(c => ResourceLoader.Exists(c.PortraitPath))?.Id.ToString() ?? ""`
- `order` = `new[] { slide.ArtCardId }.Concat(order).Distinct()`
- `slide.ArtCardId` = `id`
- `WeeklyCache[key]` = `art`

<a id="symbol-1d4beb6f533e"></a>

## `NationalSpire.AvatarAssets.Usable(Godot.Texture2D?) — public static bool Usable(Texture2D? texture)`

来源：源码第 135 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Card()`](AvatarAssets.cs.md#symbol-93fdb45d3092)；[`Gallery()`](AvatarScreen.cs.md#symbol-e01b201de3dc)；[`NationalSpire.AvatarAssets.Load(string, int, bool, int)`](AvatarAssets.cs.md#symbol-00e6fbec5eac)；[`NationalSpire.AvatarAssets.LoadCard(string, string)`](AvatarAssets.cs.md#symbol-5b05259c8c83)；[`NationalSpire.AvatarAssets.LoadWeekly(NationalSpire.CareerData, NationalSpire.WeeklyEdition, NationalSpire.WeeklySlide)`](AvatarAssets.cs.md#symbol-92f1e0aef1b2)；[`NationalSpire.AvatarImages.FromArt(NationalSpire.AvatarArt, string)`](AvatarImages.cs.md#symbol-11dcaf1a0f5d)；[`NationalSpire.AvatarImages.FromCharacterCardArt(Godot.Node, NationalSpire.AvatarArt)`](AvatarImages.cs.md#symbol-f46bb00e33dc)；[`NationalSpire.CameoAssets.Load(string, string)`](CameoAssets.cs.md#symbol-2f79106cbc73)；[`NationalSpire.LiveRunBridge.UpdateMap(NationalSpire.LiveMatchState, NationalSpire.RivalProgress, double)`](LiveRunBridge.cs.md#symbol-cedfec15a9e5)

**调用：** `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Texture2D.GetHeight()`；`Godot.Texture2D.GetWidth()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(texture)`；返回值紧邻使用处：`BinaryExpressionSyntax: texture != null && GodotObject.IsInstanceValid(texture)`
- `Godot.Texture2D.GetHeight()`；输入表达式：`texture.GetHeight()`；返回值紧邻使用处：`BinaryExpressionSyntax: texture.GetHeight() > 0`
- `Godot.Texture2D.GetWidth()`；输入表达式：`texture.GetWidth()`；返回值紧邻使用处：`BinaryExpressionSyntax: texture.GetWidth() > 0`

**赋值（含属性/字段和局部值）：**
