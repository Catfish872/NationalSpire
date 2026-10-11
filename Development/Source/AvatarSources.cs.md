# AvatarSources.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`D27E4E838DD057F8060AA787F4117A91EB2E8C8CD769071EB94004BF4B12FF3A`。来源：[源码](../../AvatarSources.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.AvatarChoice`、`NationalSpire.AvatarSources`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-6c772247bc69"></a>

## `NationalSpire.AvatarSources.Characters() — public static IReadOnlyList<AvatarChoice> Characters()`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenAvatarSettings(NationalSpire.CareerData, NationalSpire.PlayerAvatar?, System.Action<NationalSpire.PlayerAvatar>?, string, NationalSpire.AvatarArt?)`](AvatarScreen.cs.md#symbol-368e97fdd27f)

**调用：** [`NationalSpire.AvatarAssets.Load(string, int, bool, int)`](AvatarAssets.cs.md#symbol-00e6fbec5eac)；[`NationalSpire.GameBridge.Characters()`](GameBridge.cs.md#symbol-1233494dda40)；[`NationalSpire.GameText.Plain(string)`](GameText.cs.md#symbol-e2c48dec4564)；`MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`NationalSpire.AvatarChoice.AvatarChoice(string, string, string, System.Func<NationalSpire.AvatarArt?>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarAssets.Load(string, int, bool, int)`；`NationalSpire.GameBridge.Characters()`；`NationalSpire.GameText.Plain(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；输入表达式：`c.Title.GetFormattedText()`；返回值紧邻使用处：`ArgumentSyntax: c.Title.GetFormattedText()`
- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`c.Id.ToString()`；返回值紧邻使用处：`ArgumentSyntax: c.Id.ToString()`
- `NationalSpire.AvatarAssets.Load(string, int, bool, int)`；输入表达式：`AvatarAssets.Load(c.Id.ToString(), 0, false)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => AvatarAssets.Load(c.Id.ToString(), 0, false)`
- `NationalSpire.AvatarChoice.AvatarChoice(string, string, string, System.Func<NationalSpire.AvatarArt?>)`；输入表达式：`new AvatarChoice(c.Id.ToString(), GameText.Plain(c.Title.GetFormattedText()), "游戏头像", () => AvatarAssets.Load(c.Id.ToString(), 0, false))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c =>         new AvatarChoice(c.Id.ToString(), GameText.Plain(c.Title.GetFormattedText()), "游戏头像", () => AvatarAssets.Load(c.Id.ToString(), 0, false))`
- `NationalSpire.GameBridge.Characters()`；输入表达式：`GameBridge.Characters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GameBridge.Characters().Select`
- `NationalSpire.GameText.Plain(string)`；输入表达式：`GameText.Plain(c.Title.GetFormattedText())`；返回值紧邻使用处：`ArgumentSyntax: GameText.Plain(c.Title.GetFormattedText())`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`GameBridge.Characters().Select(c =>         new AvatarChoice(c.Id.ToString(), GameText.Plain(c.Title.GetFormattedText()), "游戏头像", () => AvatarAssets.Load(c.Id.ToString(), 0, false)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GameBridge.Characters().Select(c =>         new AvatarChoice(c.Id.ToString(), GameText.Plain(c.Title.GetFormattedText()), "游戏头像", () => AvatarAssets.Load(c.Id.ToString(), 0, false))).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`GameBridge.Characters().Select(c =>         new AvatarChoice(c.Id.ToString(), GameText.Plain(c.Title.GetFormattedText()), "游戏头像", () => AvatarAssets.Load(c.Id.ToString(), 0, false))).ToList()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => GameBridge.Characters().Select(c =>         new AvatarChoice(c.Id.ToString(), GameText.Plain(c.Title.GetFormattedText()), "游戏头像", () => AvatarAssets.Load(c.Id.ToString(), 0, false))).ToList()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3bc6741f18ea"></a>

## `NationalSpire.AvatarSources.Cards() — public static IReadOnlyList<AvatarChoice> Cards()`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Gallery()`](AvatarScreen.cs.md#symbol-e01b201de3dc)

**调用：** [`NationalSpire.GameText.Plain(string)`](GameText.cs.md#symbol-e2c48dec4564)；`Godot.ResourceLoader.Exists(string, string)`；`Godot.ResourceLoader.Load<T>(string, string, Godot.ResourceLoader.CacheMode)`；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`NationalSpire.AvatarArt.AvatarArt(Godot.Texture2D?, Godot.Color, string)`；`NationalSpire.AvatarChoice.AvatarChoice(string, string, string, System.Func<NationalSpire.AvatarArt?>)`；`System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarChoice.Name`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.GameText.Plain(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ResourceLoader.Exists(string, string)`；输入表达式：`ResourceLoader.Exists(path)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ResourceLoader.Exists(path)`
- `Godot.ResourceLoader.Load<T>(string, string, Godot.ResourceLoader.CacheMode)`；输入表达式：`ResourceLoader.Load<Texture2D>(path)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ResourceLoader.Load<Texture2D>(path) is { } texture`
- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`card.Id.ToString()`；返回值紧邻使用处：`ArgumentSyntax: card.Id.ToString()`
- `NationalSpire.AvatarArt.AvatarArt(Godot.Texture2D?, Godot.Color, string)`；输入表达式：`new(texture, CareerVisuals.Teal, name)`；返回值紧邻使用处：`ConditionalExpressionSyntax: ResourceLoader.Load<Texture2D>(path) is { } texture ? new(texture, CareerVisuals.Teal, name) : null`
- `NationalSpire.AvatarChoice.AvatarChoice(string, string, string, System.Func<NationalSpire.AvatarArt?>)`；输入表达式：`new(card.Id.ToString(), name, "卡图", () =>                     ResourceLoader.Load<Texture2D>(path) is { } texture ? new(texture, CareerVisuals.Teal, name) : null)`；返回值紧邻使用处：`ArgumentSyntax: new(card.Id.ToString(), name, "卡图", () =>                     ResourceLoader.Load<Texture2D>(path) is { } texture ? new(texture, CareerVisuals.Teal, name) : null)`
- `NationalSpire.GameText.Plain(string)`；输入表达式：`GameText.Plain(card.Title)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GameText.Plain(card.Title)`
- `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`ModelDb.AllCards.DistinctBy(c => c.Id)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var card in ModelDb.AllCards.DistinctBy(c => c.Id))         {             try             {                 string path = card.PortraitPath, name = GameText.Plain(card.Title);                 if (!ResourceLoader.Exists(path)) continue;                 result.Add(new(card.Id.ToString(), name, "卡图", () =>                     ResourceLoader.Load<Texture2D>(path) is { } texture ? new(texture, CareerVisuals.Teal, name) : null));             }             catch { /* 个别模组资源无效时，其余卡图仍可选择。 */ }         }`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`result.OrderBy(c => c.Name, StringComparer.CurrentCulture)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: result.OrderBy(c => c.Name, StringComparer.CurrentCulture).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`result.OrderBy(c => c.Name, StringComparer.CurrentCulture).ToList()`；返回值紧邻使用处：`ReturnStatementSyntax: return result.OrderBy(c => c.Name, StringComparer.CurrentCulture).ToList();`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`result.Add(new(card.Id.ToString(), name, "卡图", () =>                     ResourceLoader.Load<Texture2D>(path) is { } texture ? new(texture, CareerVisuals.Teal, name) : null))`；返回值紧邻使用处：`ExpressionStatementSyntax: result.Add(new(card.Id.ToString(), name, "卡图", () =>                     ResourceLoader.Load<Texture2D>(path) is { } texture ? new(texture, CareerVisuals.Teal, name) : null));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<AvatarChoice>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<AvatarChoice>()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-bc266fec0f45"></a>

## `NationalSpire.AvatarSources.Steam() — public static async Task<PlayerAvatar> Steam()`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenAvatarSettings(NationalSpire.CareerData, NationalSpire.PlayerAvatar?, System.Action<NationalSpire.PlayerAvatar>?, string, NationalSpire.AvatarArt?)`](AvatarScreen.cs.md#symbol-368e97fdd27f)

**调用：** [`NationalSpire.AvatarImages.FromImage(Godot.Image, string, string)`](AvatarImages.cs.md#symbol-14844fefd20e)；`Godot.Image.CreateFromData(int, int, bool, Godot.Image.Format, byte[])`；`Steamworks.SteamFriends.GetLargeFriendAvatar(Steamworks.CSteamID)`；`Steamworks.SteamUser.BLoggedOn()`；`Steamworks.SteamUser.GetSteamID()`；`Steamworks.SteamUtils.GetImageRGBA(int, byte[], int)`；`Steamworks.SteamUtils.GetImageSize(int, out uint, out uint)`；`System.ArgumentException.ArgumentException(string?)`；`System.Threading.Tasks.Task.Delay(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarImages.FromImage(Godot.Image, string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Image.CreateFromData(int, int, bool, Godot.Image.Format, byte[])`；输入表达式：`Image.CreateFromData((int)width, (int)height, false, Image.Format.Rgba8, rgba)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Image.CreateFromData((int)width, (int)height, false, Image.Format.Rgba8, rgba)`
- `NationalSpire.AvatarImages.FromImage(Godot.Image, string, string)`；输入表达式：`AvatarImages.FromImage(image, "steam", "Steam 头像")`；返回值紧邻使用处：`ReturnStatementSyntax: return AvatarImages.FromImage(image, "steam", "Steam 头像");`
- `Steamworks.SteamFriends.GetLargeFriendAvatar(Steamworks.CSteamID)`；输入表达式：`SteamFriends.GetLargeFriendAvatar(id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: handle = SteamFriends.GetLargeFriendAvatar(id)`
- `Steamworks.SteamFriends.GetLargeFriendAvatar(Steamworks.CSteamID)`；输入表达式：`SteamFriends.GetLargeFriendAvatar(id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = SteamFriends.GetLargeFriendAvatar(id)`
- `Steamworks.SteamUser.BLoggedOn()`；输入表达式：`SteamUser.BLoggedOn()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !SteamUser.BLoggedOn()`
- `Steamworks.SteamUser.GetSteamID()`；输入表达式：`SteamUser.GetSteamID()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = SteamUser.GetSteamID()`
- `Steamworks.SteamUtils.GetImageRGBA(int, byte[], int)`；输入表达式：`SteamUtils.GetImageRGBA(handle, rgba, rgba.Length)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !SteamUtils.GetImageRGBA(handle, rgba, rgba.Length)`
- `Steamworks.SteamUtils.GetImageSize(int, out uint, out uint)`；输入表达式：`SteamUtils.GetImageSize(handle, out uint width, out uint height)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !SteamUtils.GetImageSize(handle, out uint width, out uint height)`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("请先登录 Steam。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("请先登录 Steam。");`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("无法读取 Steam 头像。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("无法读取 Steam 头像。");`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("暂时无法取得 Steam 头像，请稍后重试。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("暂时无法取得 Steam 头像，请稍后重试。");`
- `System.Threading.Tasks.Task.Delay(int)`；输入表达式：`Task.Delay(250)`；返回值紧邻使用处：`AwaitExpressionSyntax: await Task.Delay(250)`

**赋值（含属性/字段和局部值）：**

- `handle` = `SteamFriends.GetLargeFriendAvatar(id)`
