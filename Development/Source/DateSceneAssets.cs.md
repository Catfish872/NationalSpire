# DateSceneAssets.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`221FBA04059B897FF6A611071896DFBB22D14667008260ACF09B1D78B783A823`。来源：[源码](../../DateSceneAssets.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.DateSceneAssets`、`NationalSpire.DateSceneBookmark`、`NationalSpire.DateSceneAssetStore`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-6796164638a3"></a>

## `NationalSpire.DateSceneAssets.OutfitId — public string OutfitId`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7e4a7fb6b309"></a>

## `NationalSpire.DateSceneAssets.Outfits — public Dictionary<string, Dictionary<string, string>> Outfits`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9b4e5db3b9c9"></a>

## `NationalSpire.DateSceneAssets.Sprites — public Dictionary<string, string> Sprites`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneAssets.OutfitId`；`NationalSpire.DateSceneAssets.Outfits`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Outfits.TryGetValue(OutfitId, out var sprites)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Outfits.TryGetValue(OutfitId, out var sprites) ? sprites : Outfits[OutfitId] = []`

**赋值（含属性/字段和局部值）：**

- `Outfits[OutfitId]` = `[]`
- `Outfits[OutfitId]` = `value`

<a id="symbol-4b926f70b1f4"></a>

## `NationalSpire.DateSceneAssets.Background — public string Background`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-0283d6a2efb1"></a>

## `NationalSpire.DateSceneAssets.SpriteScale — public double SpriteScale`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-312092802680"></a>

## `NationalSpire.DateSceneAssets.SpriteX — public double SpriteX`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-eae38babd0a2"></a>

## `NationalSpire.DateSceneAssets.SpriteY — public double SpriteY`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-190d596949e5"></a>

## `NationalSpire.DateSceneAssets.TextOutline — public bool TextOutline`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b383ac820b34"></a>

## `NationalSpire.DateSceneAssets.ShowAffectionBadge — public bool ShowAffectionBadge`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f21464949819"></a>

## `NationalSpire.DateSceneAssets.AutoBackground — public bool AutoBackground`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e80229f454ed"></a>

## `NationalSpire.DateSceneAssets.Blur — public bool Blur`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-63ee7f95662f"></a>

## `NationalSpire.DateSceneAssets.BlurAmount — public double BlurAmount`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-5e46f7d5af43"></a>

## `NationalSpire.DateSceneAssets.TextSpeed — public double TextSpeed`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-63e9129eaca4"></a>

## `NationalSpire.DateSceneAssets.FontSize — public int FontSize`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8d668ce2c816"></a>

## `NationalSpire.DateSceneAssets.LetterSpacing — public double LetterSpacing`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d08738dcd38e"></a>

## `NationalSpire.DateSceneAssets.PanelFade — public double PanelFade`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3df818df691e"></a>

## `NationalSpire.DateSceneAssets.Bookmarks — public Dictionary<string, DateSceneBookmark> Bookmarks`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c84043df96e9"></a>

## `NationalSpire.DateSceneBookmark.Turn — public string Turn`

来源：源码第 31 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-dc9d0f0a40b8"></a>

## `NationalSpire.DateSceneBookmark.ReplyHash — public string ReplyHash`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-5b05500e3c02"></a>

## `NationalSpire.DateSceneBookmark.Index — public int Index`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-5b7cd1e95015"></a>

## `NationalSpire.DateSceneAssetStore.EmotionForSprite(NationalSpire.PortraitDesign, string) — public static string? EmotionForSprite(PortraitDesign design, string id)`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CharacterDesignPackage.Write(NationalSpire.CareerData, NationalSpire.CareerPerson, NationalSpire.PlayerAvatar, string, NationalSpire.PortraitDesign?, NationalSpire.DateSceneAssets?)`](CharacterDesignPackage.cs.md#symbol-a0889fe0f5f4)；[`NationalSpire.DateSceneAssetStore.ImportNamedPack(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, System.IO.Compression.ZipArchive)`](DateSceneAssets.cs.md#symbol-c67565020030)；[`NationalSpire.DateSceneAssetStore.ImportOne(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string, string, bool)`](DateSceneAssets.cs.md#symbol-d165300a808a)；[`NationalSpire.DateSceneAssetStore.SaveEmotionEdit(NationalSpire.CareerData, string, NationalSpire.PortraitDesign, NationalSpire.PortraitDesign, NationalSpire.DateSceneAssets, string, string)`](DateSceneAssets.cs.md#symbol-e6562f4576e9)；[`NationalSpire.DateSceneAssetStore.SpriteKeys(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string)`](DateSceneAssets.cs.md#symbol-3b48b221efd8)

**调用：** `string.LastIndexOf(char)`；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.PortraitDesign.Emotions`；`NationalSpire.PortraitEmotion.Enabled`；`NationalSpire.PortraitEmotion.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.LastIndexOf(char)`；输入表达式：`id.LastIndexOf('_')`；返回值紧邻使用处：`EqualsValueClauseSyntax: = id.LastIndexOf('_')`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`id[(split + 1)..].All(char.IsAsciiDigit)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !id[(split + 1)..].All(char.IsAsciiDigit)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`design.Emotions.Any(e => e.Enabled && e.Id == emotion)`；返回值紧邻使用处：`ConditionalExpressionSyntax: design.Emotions.Any(e => e.Enabled && e.Id == emotion) ? emotion : null`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`design.Emotions.Any(e => e.Enabled && e.Id == id)`；返回值紧邻使用处：`IfStatementSyntax: if (design.Emotions.Any(e => e.Enabled && e.Id == id)) return id;`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3b48b221efd8"></a>

## `NationalSpire.DateSceneAssetStore.SpriteKeys(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string) — public static string[] SpriteKeys(DateSceneAssets assets, PortraitDesign design, string emotion)`

来源：源码第 46 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Draw()`](DateSceneAssetScreen.cs.md#symbol-44fc11efbaa6)；[`NationalSpire.CareerScreen.HasDateArt(NationalSpire.CareerData, string)`](DateSceneScreen.cs.md#symbol-694ba8dec04c)；[`NationalSpire.CareerScreen.SpriteVariants(string)`](DateSceneScreen.cs.md#symbol-e038e794d751)；[`NationalSpire.DateSceneAssetStore.Ready(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign?)`](DateSceneAssets.cs.md#symbol-79425fed4748)

**调用：** [`NationalSpire.DateSceneAssetStore.EmotionForSprite(NationalSpire.PortraitDesign, string)`](DateSceneAssets.cs.md#symbol-5b7cd1e95015)；`System.Collections.Generic.IEnumerable<T>.Order<T>(System.Collections.Generic.IComparer<T>?)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneAssets.Sprites`；`NationalSpire.DateSceneAssetStore.EmotionForSprite(NationalSpire.PortraitDesign, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneAssetStore.EmotionForSprite(NationalSpire.PortraitDesign, string)`；输入表达式：`EmotionForSprite(design, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: EmotionForSprite(design, id) == emotion`
- `System.Collections.Generic.IEnumerable<T>.Order<T>(System.Collections.Generic.IComparer<T>?)`；输入表达式：`assets.Sprites.Keys.Where(id => EmotionForSprite(design, id) == emotion).Order(StringComparer.Ordinal)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: assets.Sprites.Keys.Where(id => EmotionForSprite(design, id) == emotion).Order(StringComparer.Ordinal).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`assets.Sprites.Keys.Where(id => EmotionForSprite(design, id) == emotion).Order(StringComparer.Ordinal).ToArray()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => assets.Sprites.Keys.Where(id => EmotionForSprite(design, id) == emotion).Order(StringComparer.Ordinal).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`assets.Sprites.Keys.Where(id => EmotionForSprite(design, id) == emotion)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: assets.Sprites.Keys.Where(id => EmotionForSprite(design, id) == emotion).Order`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ac5aec527a9d"></a>

## `NationalSpire.DateSceneAssetStore.ContinueHintDismissed() — public static bool ContinueHintDismissed()`

来源：源码第 48 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView._Ready()`](DateSceneView.cs.md#symbol-db339768c993)

**调用：** `Godot.ConfigFile.ConfigFile()`；`Godot.ConfigFile.GetValue(string, string, Godot.Variant)`；`Godot.ConfigFile.Load(string)`；`Godot.Variant.AsBool()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ConfigFile.ConfigFile()`；输入表达式：`new ConfigFile()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ConfigFile()`
- `Godot.ConfigFile.GetValue(string, string, Godot.Variant)`；输入表达式：`config.GetValue("scene", "continue_hint_dismissed", false)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: config.GetValue("scene", "continue_hint_dismissed", false).AsBool`
- `Godot.ConfigFile.Load(string)`；输入表达式：`config.Load("user://NationalSpire_date_scene.cfg")`；返回值紧邻使用处：`ExpressionStatementSyntax: config.Load("user://NationalSpire_date_scene.cfg");`
- `Godot.Variant.AsBool()`；输入表达式：`config.GetValue("scene", "continue_hint_dismissed", false).AsBool()`；返回值紧邻使用处：`ReturnStatementSyntax: return config.GetValue("scene", "continue_hint_dismissed", false).AsBool();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f98f286cc92d"></a>

## `NationalSpire.DateSceneAssetStore.DismissContinueHint() — public static void DismissContinueHint()`

来源：源码第 53 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView.Click(Godot.InputEvent)`](DateSceneView.cs.md#symbol-cb37d8aeee1d)

**调用：** `Godot.ConfigFile.ConfigFile()`；`Godot.ConfigFile.Load(string)`；`Godot.ConfigFile.Save(string)`；`Godot.ConfigFile.SetValue(string, string, Godot.Variant)`；`System.IO.IOException.IOException(string?)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ConfigFile.ConfigFile()`；输入表达式：`new ConfigFile()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ConfigFile()`
- `Godot.ConfigFile.Load(string)`；输入表达式：`config.Load("user://NationalSpire_date_scene.cfg")`；返回值紧邻使用处：`ExpressionStatementSyntax: config.Load("user://NationalSpire_date_scene.cfg");`
- `Godot.ConfigFile.Save(string)`；输入表达式：`config.Save("user://NationalSpire_date_scene.cfg")`；返回值紧邻使用处：`BinaryExpressionSyntax: config.Save("user://NationalSpire_date_scene.cfg") != Error.Ok`
- `Godot.ConfigFile.SetValue(string, string, Godot.Variant)`；输入表达式：`config.SetValue("scene", "continue_hint_dismissed", true)`；返回值紧邻使用处：`ExpressionStatementSyntax: config.SetValue("scene", "continue_hint_dismissed", true);`
- `System.IO.IOException.IOException(string?)`；输入表达式：`new IOException("场景提示偏好保存失败。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new IOException("场景提示偏好保存失败。");`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b24ca2aeb1cc"></a>

## `NationalSpire.DateSceneAssetStore.DirectoryPath — public static string DirectoryPath`

来源：源码第 59 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.ProjectSettings.GlobalizePath(string)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ProjectSettings.GlobalizePath(string)`；输入表达式：`ProjectSettings.GlobalizePath("user://national_spire_portraits/scenes")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => ProjectSettings.GlobalizePath("user://national_spire_portraits/scenes")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-81bb8bd9a964"></a>

## `NationalSpire.DateSceneAssetStore.PathFor(NationalSpire.CareerData, string) — public static string PathFor(CareerData data, string person)`

来源：源码第 60 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.HasDateArt(NationalSpire.CareerData, string)`](DateSceneScreen.cs.md#symbol-694ba8dec04c)；[`NationalSpire.CharacterDesignPackage.Installation.Installation(NationalSpire.CareerData, string, NationalSpire.PortraitDesign, NationalSpire.DateSceneAssets)`](CharacterDesignPackage.cs.md#symbol-27a8ea8feef4)；[`NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`](DateSceneAssets.cs.md#symbol-57fe620f4cc9)；[`NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`](DateSceneAssets.cs.md#symbol-2bf1f40a912e)

**调用：** [`NationalSpire.PortraitDesignStore.Key(NationalSpire.CareerData, string)`](PortraitDesignStore.cs.md#symbol-2ed1ee155b2d)；`System.IO.Path.Combine(string, string)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneAssetStore.DirectoryPath`；`NationalSpire.PortraitDesignStore.Key(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PortraitDesignStore.Key(NationalSpire.CareerData, string)`；输入表达式：`PortraitDesignStore.Key(data, person)`；返回值紧邻使用处：`BinaryExpressionSyntax: PortraitDesignStore.Key(data, person) + ".json"`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(DirectoryPath, PortraitDesignStore.Key(data, person) + ".json")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Path.Combine(DirectoryPath, PortraitDesignStore.Key(data, person) + ".json")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-57fe620f4cc9"></a>

## `NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string) — public static DateSceneAssets Read(CareerData data, string person)`

来源：源码第 61 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AppearanceLibrary.Apply(NationalSpire.CareerData, string, NationalSpire.AppearanceLibrary.Package)`](AppearanceLibrary.cs.md#symbol-35fa453dd634)；[`NationalSpire.CareerScreen.HasDateArt(NationalSpire.CareerData, string)`](DateSceneScreen.cs.md#symbol-694ba8dec04c)；[`NationalSpire.CareerScreen.NewDateEmotion(NationalSpire.CareerData, string, string)`](DateSceneAssetScreen.cs.md#symbol-29862ab95d64)；[`NationalSpire.CareerScreen.OpenDateAssets(NationalSpire.CareerData, string)`](DateSceneAssetScreen.cs.md#symbol-a45b4a628cd5)；[`NationalSpire.CareerScreen.OpenDateScene(string)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)；[`NationalSpire.CareerScreen.PromptDateScene(string)`](DateSceneScreen.cs.md#symbol-d6c92b4f494c)；[`NationalSpire.CharacterDesignPackage.Write(NationalSpire.CareerData, NationalSpire.CareerPerson, NationalSpire.PlayerAvatar, string, NationalSpire.PortraitDesign?, NationalSpire.DateSceneAssets?)`](CharacterDesignPackage.cs.md#symbol-a0889fe0f5f4)

**调用：** [`NationalSpire.DateSceneAssetStore.PathFor(NationalSpire.CareerData, string)`](DateSceneAssets.cs.md#symbol-81bb8bd9a964)；`NationalSpire.DateSceneAssets.DateSceneAssets()`；`System.IO.File.Exists(string?)`；`System.IO.File.ReadAllText(string)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneAssets.Blur`；`NationalSpire.DateSceneAssets.BlurAmount`；`NationalSpire.DateSceneAssetStore.PathFor(NationalSpire.CareerData, string)`；`NationalSpire.PortraitDesigns.Json`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneAssets.DateSceneAssets()`；输入表达式：`new()`；返回值紧邻使用处：`BinaryExpressionSyntax: JsonSerializer.Deserialize<DateSceneAssets>(File.ReadAllText(path), PortraitDesigns.Json) ?? new()`
- `NationalSpire.DateSceneAssets.DateSceneAssets()`；输入表达式：`new()`；返回值紧邻使用处：`ConditionalExpressionSyntax: File.Exists(path) ? JsonSerializer.Deserialize<DateSceneAssets>(File.ReadAllText(path), PortraitDesigns.Json) ?? new() : new()`
- `NationalSpire.DateSceneAssetStore.PathFor(NationalSpire.CareerData, string)`；输入表达式：`PathFor(data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PathFor(data, person)`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(path)`；返回值紧邻使用处：`ConditionalExpressionSyntax: File.Exists(path) ? JsonSerializer.Deserialize<DateSceneAssets>(File.ReadAllText(path), PortraitDesigns.Json) ?? new() : new()`
- `System.IO.File.ReadAllText(string)`；输入表达式：`File.ReadAllText(path)`；返回值紧邻使用处：`ArgumentSyntax: File.ReadAllText(path)`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<DateSceneAssets>(File.ReadAllText(path), PortraitDesigns.Json)`；返回值紧邻使用处：`BinaryExpressionSyntax: JsonSerializer.Deserialize<DateSceneAssets>(File.ReadAllText(path), PortraitDesigns.Json) ?? new()`

**赋值（含属性/字段和局部值）：**

- `assets.Blur` = `true`
- `assets.BlurAmount` = `0`

<a id="symbol-2bf1f40a912e"></a>

## `NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets) — public static void Save(CareerData data, string person, DateSceneAssets assets)`

来源：源码第 68 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Draw()`](DateSceneAssetScreen.cs.md#symbol-44fc11efbaa6)；[`Import(System.Action<NationalSpire.DateSceneAssets, string>, string[])`](DateSceneAssetScreen.cs.md#symbol-5d9a90f3c871)；[`NationalSpire.CareerScreen.AdvanceDateScene()`](DateSceneScreen.cs.md#symbol-96e53c8a266f)；[`NationalSpire.CareerScreen.DateSceneSettings()`](DateSceneScreen.cs.md#symbol-0845ec2acab1)；[`NationalSpire.CareerScreen.LeaveDateScene(bool)`](DateSceneScreen.cs.md#symbol-942f3afae68b)；[`NationalSpire.CareerScreen.OpenDateAssets(NationalSpire.CareerData, string)`](DateSceneAssetScreen.cs.md#symbol-a45b4a628cd5)；[`NationalSpire.CharacterDesignPackage.Installation.Installation(NationalSpire.CareerData, string, NationalSpire.PortraitDesign, NationalSpire.DateSceneAssets)`](CharacterDesignPackage.cs.md#symbol-27a8ea8feef4)；[`NationalSpire.DateSceneAssetStore.SaveEmotionEdit(NationalSpire.CareerData, string, NationalSpire.PortraitDesign, NationalSpire.PortraitDesign, NationalSpire.DateSceneAssets, string, string)`](DateSceneAssets.cs.md#symbol-e6562f4576e9)；[`Save()`](DateSceneScreen.cs.md#symbol-5e2413f0aa95)

**调用：** [`NationalSpire.DateSceneAssetStore.PathFor(NationalSpire.CareerData, string)`](DateSceneAssets.cs.md#symbol-81bb8bd9a964)；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`；`System.IO.Directory.CreateDirectory(string)`；`System.IO.File.Delete(string)`；`System.IO.File.Exists(string?)`；`System.IO.File.Move(string, string, bool)`；`System.IO.File.WriteAllText(string, string?)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneAssetStore.DirectoryPath`；`NationalSpire.DateSceneAssetStore.PathFor(NationalSpire.CareerData, string)`；`NationalSpire.PortraitDesigns.Json`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneAssetStore.PathFor(NationalSpire.CareerData, string)`；输入表达式：`PathFor(data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PathFor(data, person)`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`BinaryExpressionSyntax: path + "." + Guid.NewGuid().ToString("N")`
- `System.IO.Directory.CreateDirectory(string)`；输入表达式：`Directory.CreateDirectory(DirectoryPath)`；返回值紧邻使用处：`ExpressionStatementSyntax: Directory.CreateDirectory(DirectoryPath);`
- `System.IO.File.Delete(string)`；输入表达式：`File.Delete(temporary)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Delete(temporary);`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(temporary)`；返回值紧邻使用处：`IfStatementSyntax: if (File.Exists(temporary)) File.Delete(temporary);`
- `System.IO.File.Move(string, string, bool)`；输入表达式：`File.Move(temporary, path, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Move(temporary, path, true);`
- `System.IO.File.WriteAllText(string, string?)`；输入表达式：`File.WriteAllText(temporary, JsonSerializer.Serialize(assets, PortraitDesigns.Json))`；返回值紧邻使用处：`ExpressionStatementSyntax: File.WriteAllText(temporary, JsonSerializer.Serialize(assets, PortraitDesigns.Json));`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(assets, PortraitDesigns.Json)`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.Serialize(assets, PortraitDesigns.Json)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e8871d339d39"></a>

## `NationalSpire.DateSceneAssetStore.Hash(byte[]) — public static string Hash(byte[] bytes)`

来源：源码第 74 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)；[`NationalSpire.CharacterDesignPackage.Read(NationalSpire.CareerData, System.IO.Stream)`](CharacterDesignPackage.cs.md#symbol-b6e606c27a93)；[`NationalSpire.CharacterDesignPackage.Write(NationalSpire.CareerData, NationalSpire.CareerPerson, NationalSpire.PlayerAvatar, string, NationalSpire.PortraitDesign?, NationalSpire.DateSceneAssets?)`](CharacterDesignPackage.cs.md#symbol-a0889fe0f5f4)；[`NationalSpire.DateSceneAssetStore.ImportBackgroundBytes(byte[], string)`](DateSceneAssets.cs.md#symbol-d04a3543dc27)；[`NationalSpire.DateSceneAssetStore.ImportNamedPack(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, System.IO.Compression.ZipArchive)`](DateSceneAssets.cs.md#symbol-c67565020030)；[`NationalSpire.DateSceneAssetStore.ImportOne(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string, string, bool)`](DateSceneAssets.cs.md#symbol-d165300a808a)；[`NationalSpire.DateSceneAssetStore.ImportPack(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string)`](DateSceneAssets.cs.md#symbol-57176c13d299)；[`NationalSpire.DateSceneAssetStore.Pixels(string, bool)`](DateSceneAssets.cs.md#symbol-b176dfac69ce)；[`NationalSpire.DateSceneAssetStore.Store(byte[], string)`](DateSceneAssets.cs.md#symbol-a774cf2421cf)；[`NationalSpire.DateSceneAssetStore.StoreSprite(byte[])`](DateSceneAssets.cs.md#symbol-d6c8bc9f985e)

**调用：** `string.ToLowerInvariant()`；`System.Convert.ToHexString(byte[])`；`System.Security.Cryptography.SHA256.HashData(byte[])`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.ToLowerInvariant()`；输入表达式：`Convert.ToHexString(SHA256.HashData(bytes)).ToLowerInvariant()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Convert.ToHexString(SHA256.HashData(bytes)).ToLowerInvariant()`
- `System.Convert.ToHexString(byte[])`；输入表达式：`Convert.ToHexString(SHA256.HashData(bytes))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Convert.ToHexString(SHA256.HashData(bytes)).ToLowerInvariant`
- `System.Security.Cryptography.SHA256.HashData(byte[])`；输入表达式：`SHA256.HashData(bytes)`；返回值紧邻使用处：`ArgumentSyntax: SHA256.HashData(bytes)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1b33c2ffb1f6"></a>

## `NationalSpire.DateSceneAssetStore.BlobPath(string) — public static string BlobPath(string hash)`

来源：源码第 75 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.HasDateArt(NationalSpire.CareerData, string)`](DateSceneScreen.cs.md#symbol-694ba8dec04c)；[`NationalSpire.CharacterDesignPackage.Write(NationalSpire.CareerData, NationalSpire.CareerPerson, NationalSpire.PlayerAvatar, string, NationalSpire.PortraitDesign?, NationalSpire.DateSceneAssets?)`](CharacterDesignPackage.cs.md#symbol-a0889fe0f5f4)；[`NationalSpire.DateSceneAssetStore.Pixels(string, bool)`](DateSceneAssets.cs.md#symbol-b176dfac69ce)；[`NationalSpire.DateSceneAssetStore.Store(byte[], string)`](DateSceneAssets.cs.md#symbol-a774cf2421cf)；[`NationalSpire.DateSceneBackgrounds.Read(out string, string?)`](DateSceneBackgrounds.cs.md#symbol-b6c3bc7d87d9)；[`NationalSpire.DateSceneBackgrounds.ResolveImage(string)`](DateSceneBackgrounds.cs.md#symbol-05e1fa49f816)

**调用：** `char.IsAsciiHexDigit(char)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.IO.Path.Combine(string, string, string)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneAssetStore.DirectoryPath`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `char.IsAsciiHexDigit(char)`；输入表达式：`char.IsAsciiHexDigit(c)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !char.IsAsciiHexDigit(c)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`hash.Any(c => !char.IsAsciiHexDigit(c))`；返回值紧邻使用处：`BinaryExpressionSyntax: hash.Length != 64 || hash.Any(c => !char.IsAsciiHexDigit(c))`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("图像缓存编号无效。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("图像缓存编号无效。");`
- `System.IO.Path.Combine(string, string, string)`；输入表达式：`Path.Combine(DirectoryPath, "images", hash + ".png")`；返回值紧邻使用处：`ReturnStatementSyntax: return Path.Combine(DirectoryPath, "images", hash + ".png");`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a774cf2421cf"></a>

## `NationalSpire.DateSceneAssetStore.Store(byte[], string) — internal static void Store(byte[] bytes, string hash)`

来源：源码第 81 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AppearanceLibrary.Save(string, NationalSpire.CharacterDesignPackage.Imported, string?)`](AppearanceLibrary.cs.md#symbol-c4c0756e8854)；[`NationalSpire.CharacterDesignPackage.Installation.PackageAssets(NationalSpire.CharacterDesignPackage.Imported)`](CharacterDesignPackage.cs.md#symbol-5f1bf4d63999)；[`NationalSpire.DateSceneAssetStore.ImportBackgroundBytes(byte[], string)`](DateSceneAssets.cs.md#symbol-d04a3543dc27)；[`NationalSpire.DateSceneAssetStore.ImportNamedPack(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, System.IO.Compression.ZipArchive)`](DateSceneAssets.cs.md#symbol-c67565020030)；[`NationalSpire.DateSceneAssetStore.ImportOne(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string, string, bool)`](DateSceneAssets.cs.md#symbol-d165300a808a)；[`NationalSpire.DateSceneAssetStore.ImportPack(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string)`](DateSceneAssets.cs.md#symbol-57176c13d299)；[`NationalSpire.DateSceneAssetStore.StoreSprite(byte[])`](DateSceneAssets.cs.md#symbol-d6c8bc9f985e)

**调用：** [`NationalSpire.DateSceneAssetStore.BlobPath(string)`](DateSceneAssets.cs.md#symbol-1b33c2ffb1f6)；[`NationalSpire.DateSceneAssetStore.Hash(byte[])`](DateSceneAssets.cs.md#symbol-e8871d339d39)；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`；`System.IO.Directory.CreateDirectory(string)`；`System.IO.File.Delete(string)`；`System.IO.File.Exists(string?)`；`System.IO.File.Move(string, string, bool)`；`System.IO.File.ReadAllBytes(string)`；`System.IO.File.WriteAllBytes(string, byte[])`；`System.IO.Path.GetDirectoryName(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneAssetStore.BlobPath(string)`；`NationalSpire.DateSceneAssetStore.Hash(byte[])`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneAssetStore.BlobPath(string)`；输入表达式：`BlobPath(hash)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = BlobPath(hash)`
- `NationalSpire.DateSceneAssetStore.Hash(byte[])`；输入表达式：`Hash(File.ReadAllBytes(path))`；返回值紧邻使用处：`BinaryExpressionSyntax: Hash(File.ReadAllBytes(path)) == hash`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`BinaryExpressionSyntax: path + "." + Guid.NewGuid().ToString("N")`
- `System.IO.Directory.CreateDirectory(string)`；输入表达式：`Directory.CreateDirectory(Path.GetDirectoryName(path)!)`；返回值紧邻使用处：`ExpressionStatementSyntax: Directory.CreateDirectory(Path.GetDirectoryName(path)!);`
- `System.IO.File.Delete(string)`；输入表达式：`File.Delete(temp)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Delete(temp);`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(path)`；返回值紧邻使用处：`BinaryExpressionSyntax: File.Exists(path) && Hash(File.ReadAllBytes(path)) == hash`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(temp)`；返回值紧邻使用处：`IfStatementSyntax: if (File.Exists(temp)) File.Delete(temp);`
- `System.IO.File.Move(string, string, bool)`；输入表达式：`File.Move(temp, path, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Move(temp, path, true);`
- `System.IO.File.ReadAllBytes(string)`；输入表达式：`File.ReadAllBytes(path)`；返回值紧邻使用处：`ArgumentSyntax: File.ReadAllBytes(path)`
- `System.IO.File.WriteAllBytes(string, byte[])`；输入表达式：`File.WriteAllBytes(temp, bytes)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.WriteAllBytes(temp, bytes);`
- `System.IO.Path.GetDirectoryName(string?)`；输入表达式：`Path.GetDirectoryName(path)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: Path.GetDirectoryName(path)!`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5cd819ad6952"></a>

## `NationalSpire.DateSceneAssetStore.ReadImage(byte[], bool) — public static Image ReadImage(byte[] bytes, bool sprite)`

来源：源码第 88 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CharacterDesignPackage.Read(NationalSpire.CareerData, System.IO.Stream)`](CharacterDesignPackage.cs.md#symbol-b6e606c27a93)；[`NationalSpire.CharacterDesignPackage.Write(NationalSpire.CareerData, NationalSpire.CareerPerson, NationalSpire.PlayerAvatar, string, NationalSpire.PortraitDesign?, NationalSpire.DateSceneAssets?)`](CharacterDesignPackage.cs.md#symbol-a0889fe0f5f4)；[`NationalSpire.DateSceneAssetStore.ImportNamedPack(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, System.IO.Compression.ZipArchive)`](DateSceneAssets.cs.md#symbol-c67565020030)；[`NationalSpire.DateSceneAssetStore.ImportOne(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string, string, bool)`](DateSceneAssets.cs.md#symbol-d165300a808a)；[`NationalSpire.DateSceneAssetStore.ImportPack(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string)`](DateSceneAssets.cs.md#symbol-57176c13d299)；[`NationalSpire.DateSceneAssetStore.Pixels(string, bool)`](DateSceneAssets.cs.md#symbol-b176dfac69ce)；[`NationalSpire.DateSceneAssetStore.ReadBackgroundImage(byte[], string)`](DateSceneAssets.cs.md#symbol-e78822490246)；[`NationalSpire.DateSceneAssetStore.StoreSprite(byte[])`](DateSceneAssets.cs.md#symbol-d6c8bc9f985e)

**调用：** `Godot.GodotObject.Dispose()`；`Godot.Image.Convert(Godot.Image.Format)`；`Godot.Image.DetectAlpha()`；`Godot.Image.GetData()`；`Godot.Image.Image()`；`Godot.Image.IsEmpty()`；`Godot.Image.LoadPngFromBuffer(byte[])`；`System.Buffers.Binary.BinaryPrimitives.ReadUInt32BigEndian(System.ReadOnlySpan<byte>)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.Span<T>.SequenceEqual<T>(System.ReadOnlySpan<T>)`；`T[]?.AsSpan<T>(int, int)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.Dispose()`；输入表达式：`image.Dispose()`；返回值紧邻使用处：`ExpressionStatementSyntax: image.Dispose();`
- `Godot.Image.Convert(Godot.Image.Format)`；输入表达式：`image.Convert(Image.Format.Rgba8)`；返回值紧邻使用处：`ExpressionStatementSyntax: image.Convert(Image.Format.Rgba8);`
- `Godot.Image.DetectAlpha()`；输入表达式：`image.DetectAlpha()`；返回值紧邻使用处：`BinaryExpressionSyntax: image.DetectAlpha() == Image.AlphaMode.None`
- `Godot.Image.GetData()`；输入表达式：`image.GetData()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = image.GetData()`
- `Godot.Image.Image()`；输入表达式：`new Image()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Image()`
- `Godot.Image.IsEmpty()`；输入表达式：`image.IsEmpty()`；返回值紧邻使用处：`BinaryExpressionSyntax: image.LoadPngFromBuffer(bytes) != Error.Ok || image.IsEmpty()`
- `Godot.Image.LoadPngFromBuffer(byte[])`；输入表达式：`image.LoadPngFromBuffer(bytes)`；返回值紧邻使用处：`BinaryExpressionSyntax: image.LoadPngFromBuffer(bytes) != Error.Ok`
- `System.Buffers.Binary.BinaryPrimitives.ReadUInt32BigEndian(System.ReadOnlySpan<byte>)`；输入表达式：`System.Buffers.Binary.BinaryPrimitives.ReadUInt32BigEndian(bytes.AsSpan(16, 4))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = System.Buffers.Binary.BinaryPrimitives.ReadUInt32BigEndian(bytes.AsSpan(16, 4))`
- `System.Buffers.Binary.BinaryPrimitives.ReadUInt32BigEndian(System.ReadOnlySpan<byte>)`；输入表达式：`System.Buffers.Binary.BinaryPrimitives.ReadUInt32BigEndian(bytes.AsSpan(20, 4))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = System.Buffers.Binary.BinaryPrimitives.ReadUInt32BigEndian(bytes.AsSpan(20, 4))`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("立绘使用包含透明像素的PNG，显示时按图片比例适配。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("立绘使用包含透明像素的PNG，显示时按图片比例适配。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("立绘完全透明，请导入含有人物的PNG。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("立绘完全透明，请导入含有人物的PNG。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("请选择完整的PNG图片（单张至多64MB）。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("请选择完整的PNG图片（单张至多64MB）。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("图片尺寸过大或无效，请缩小图片。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("图片尺寸过大或无效，请缩小图片。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("PNG图片无法读取。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("PNG图片无法读取。");`
- `System.Span<T>.SequenceEqual<T>(System.ReadOnlySpan<T>)`；输入表达式：`bytes.AsSpan(0, 8).SequenceEqual(new byte[] { 137, 80, 78, 71, 13, 10, 26, 10 })`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !bytes.AsSpan(0, 8).SequenceEqual(new byte[] { 137, 80, 78, 71, 13, 10, 26, 10 })`
- `T[]?.AsSpan<T>(int, int)`；输入表达式：`bytes.AsSpan(0, 8)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: bytes.AsSpan(0, 8).SequenceEqual`
- `T[]?.AsSpan<T>(int, int)`；输入表达式：`bytes.AsSpan(16, 4)`；返回值紧邻使用处：`ArgumentSyntax: bytes.AsSpan(16, 4)`
- `T[]?.AsSpan<T>(int, int)`；输入表达式：`bytes.AsSpan(20, 4)`；返回值紧邻使用处：`ArgumentSyntax: bytes.AsSpan(20, 4)`

**赋值（含属性/字段和局部值）：**

- `i` += `4`
- `visible` = `true`

<a id="symbol-d165300a808a"></a>

## `NationalSpire.DateSceneAssetStore.ImportOne(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string, string, bool) — public static void ImportOne(DateSceneAssets assets, PortraitDesign design, string id, string file, bool append = false)`

来源：源码第 105 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Draw()`](DateSceneAssetScreen.cs.md#symbol-44fc11efbaa6)

**调用：** [`NationalSpire.DateSceneAssetStore.EmotionForSprite(NationalSpire.PortraitDesign, string)`](DateSceneAssets.cs.md#symbol-5b7cd1e95015)；[`NationalSpire.DateSceneAssetStore.Hash(byte[])`](DateSceneAssets.cs.md#symbol-e8871d339d39)；[`NationalSpire.DateSceneAssetStore.ReadImage(byte[], bool)`](DateSceneAssets.cs.md#symbol-5cd819ad6952)；[`NationalSpire.DateSceneAssetStore.Store(byte[], string)`](DateSceneAssets.cs.md#symbol-a774cf2421cf)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.IO.File.ReadAllBytes(string)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.IO.Path.GetFileNameWithoutExtension(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneAssets.OutfitId`；`NationalSpire.DateSceneAssets.Sprites`；`NationalSpire.DateSceneAssetStore.EmotionForSprite(NationalSpire.PortraitDesign, string)`；`NationalSpire.DateSceneAssetStore.Hash(byte[])`；`NationalSpire.DateSceneAssetStore.ReadImage(byte[], bool)`；`NationalSpire.DateSceneAssetStore.Store(byte[], string)`；`NationalSpire.PortraitDesign.Emotions`；`NationalSpire.PortraitDesign.SelectedOutfit`；`NationalSpire.PortraitEmotion.Enabled`；`NationalSpire.PortraitEmotion.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneAssetStore.EmotionForSprite(NationalSpire.PortraitDesign, string)`；输入表达式：`EmotionForSprite(design, filename)`；返回值紧邻使用处：`BinaryExpressionSyntax: EmotionForSprite(design, filename) == id`
- `NationalSpire.DateSceneAssetStore.Hash(byte[])`；输入表达式：`Hash(bytes)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Hash(bytes)`
- `NationalSpire.DateSceneAssetStore.ReadImage(byte[], bool)`；输入表达式：`ReadImage(bytes, true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ReadImage(bytes, true)`
- `NationalSpire.DateSceneAssetStore.Store(byte[], string)`；输入表达式：`Store(bytes, hash)`；返回值紧邻使用处：`ExpressionStatementSyntax: Store(bytes, hash);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`assets.Sprites.ContainsKey(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: assets.Sprites.ContainsKey(id) || design.Emotions.Any(e => e.Id == id)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`design.Emotions.Any(e => e.Enabled && e.Id == id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !design.Emotions.Any(e => e.Enabled && e.Id == id)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`design.Emotions.Any(e => e.Id == id)`；返回值紧邻使用处：`BinaryExpressionSyntax: assets.Sprites.ContainsKey(id) || design.Emotions.Any(e => e.Id == id)`
- `System.IO.File.ReadAllBytes(string)`；输入表达式：`File.ReadAllBytes(file)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = File.ReadAllBytes(file)`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("该情绪ID未在当前设计中启用。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("该情绪ID未在当前设计中启用。");`
- `System.IO.Path.GetFileNameWithoutExtension(string?)`；输入表达式：`Path.GetFileNameWithoutExtension(file)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Path.GetFileNameWithoutExtension(file)`

**赋值（含属性/字段和局部值）：**

- `assets.OutfitId` = `design.SelectedOutfit`
- `assets.Sprites[id]` = `hash`
- `id` = `emotion + "_" + index++`
- `id` = `filename`

<a id="symbol-d6c8bc9f985e"></a>

## `NationalSpire.DateSceneAssetStore.StoreSprite(byte[]) — public static string StoreSprite(byte[] bytes)`

来源：源码第 119 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.DateSceneAssetStore.Hash(byte[])`](DateSceneAssets.cs.md#symbol-e8871d339d39)；[`NationalSpire.DateSceneAssetStore.ReadImage(byte[], bool)`](DateSceneAssets.cs.md#symbol-5cd819ad6952)；[`NationalSpire.DateSceneAssetStore.Store(byte[], string)`](DateSceneAssets.cs.md#symbol-a774cf2421cf)

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneAssetStore.Hash(byte[])`；`NationalSpire.DateSceneAssetStore.ReadImage(byte[], bool)`；`NationalSpire.DateSceneAssetStore.Store(byte[], string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneAssetStore.Hash(byte[])`；输入表达式：`Hash(bytes)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Hash(bytes)`
- `NationalSpire.DateSceneAssetStore.ReadImage(byte[], bool)`；输入表达式：`ReadImage(bytes, true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ReadImage(bytes, true)`
- `NationalSpire.DateSceneAssetStore.Store(byte[], string)`；输入表达式：`Store(bytes, hash)`；返回值紧邻使用处：`ExpressionStatementSyntax: Store(bytes, hash);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e6562f4576e9"></a>

## `NationalSpire.DateSceneAssetStore.SaveEmotionEdit(NationalSpire.CareerData, string, NationalSpire.PortraitDesign, NationalSpire.PortraitDesign, NationalSpire.DateSceneAssets, string, string) — public static void SaveEmotionEdit(CareerData data, string person, PortraitDesign previous, PortraitDesign design, DateSceneAssets assets, string oldId, string newId)`

来源：源码第 123 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.NewDateEmotion(NationalSpire.CareerData, string, string)`](DateSceneAssetScreen.cs.md#symbol-29862ab95d64)

**调用：** [`NationalSpire.Coop.CoopJson.Copy<T>(T)`](Coop/CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.DateSceneAssetStore.EmotionForSprite(NationalSpire.PortraitDesign, string)`](DateSceneAssets.cs.md#symbol-5b7cd1e95015)；[`NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`](DateSceneAssets.cs.md#symbol-2bf1f40a912e)；[`NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`](PortraitDesignStore.cs.md#symbol-8db102d73ed8)；[`NationalSpire.PortraitDesignStore.Save(string, NationalSpire.PortraitDesign)`](PortraitDesignStore.cs.md#symbol-2f8c936a01d4)；`System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.IO.InvalidDataException.InvalidDataException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.DateSceneAssets.Outfits`；`NationalSpire.DateSceneAssetStore.EmotionForSprite(NationalSpire.PortraitDesign, string)`；`NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`；`NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`；`NationalSpire.PortraitDesignStore.Save(string, NationalSpire.PortraitDesign)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`Coop.CoopJson.Copy(assets)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Coop.CoopJson.Copy(assets)`
- `NationalSpire.DateSceneAssetStore.EmotionForSprite(NationalSpire.PortraitDesign, string)`；输入表达式：`EmotionForSprite(design, key)`；返回值紧邻使用处：`BinaryExpressionSyntax: EmotionForSprite(design, key) != newId`
- `NationalSpire.DateSceneAssetStore.EmotionForSprite(NationalSpire.PortraitDesign, string)`；输入表达式：`EmotionForSprite(design, key)`；返回值紧邻使用处：`BinaryExpressionSyntax: EmotionForSprite(previous, key) != EmotionForSprite(design, key)`
- `NationalSpire.DateSceneAssetStore.EmotionForSprite(NationalSpire.PortraitDesign, string)`；输入表达式：`EmotionForSprite(previous, key)`；返回值紧邻使用处：`BinaryExpressionSyntax: EmotionForSprite(previous, key) != EmotionForSprite(design, key)`
- `NationalSpire.DateSceneAssetStore.EmotionForSprite(NationalSpire.PortraitDesign, string)`；输入表达式：`EmotionForSprite(previous, key)`；返回值紧邻使用处：`BinaryExpressionSyntax: EmotionForSprite(previous, key) != oldId`
- `NationalSpire.DateSceneAssetStore.EmotionForSprite(NationalSpire.PortraitDesign, string)`；输入表达式：`EmotionForSprite(previous, p.Key)`；返回值紧邻使用处：`BinaryExpressionSyntax: EmotionForSprite(previous, p.Key) == oldId`
- `NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`；输入表达式：`Save(data, person, assets)`；返回值紧邻使用处：`ExpressionStatementSyntax: Save(data, person, assets);`
- `NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`；输入表达式：`Save(data, person, copy)`；返回值紧邻使用处：`ExpressionStatementSyntax: Save(data, person, copy);`
- `NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`；输入表达式：`PortraitDesignStore.FilePath(data, person)`；返回值紧邻使用处：`ArgumentSyntax: PortraitDesignStore.FilePath(data, person)`
- `NationalSpire.PortraitDesignStore.Save(string, NationalSpire.PortraitDesign)`；输入表达式：`PortraitDesignStore.Save(PortraitDesignStore.FilePath(data, person), design)`；返回值紧邻使用处：`ExpressionStatementSyntax: PortraitDesignStore.Save(PortraitDesignStore.FilePath(data, person), design);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；输入表达式：`sprites.Add(newId + item.Key[oldId.Length..], item.Value)`；返回值紧邻使用处：`ExpressionStatementSyntax: sprites.Add(newId + item.Key[oldId.Length..], item.Value);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`sprites.ContainsKey(key)`；返回值紧邻使用处：`BinaryExpressionSyntax: sprites.ContainsKey(key) || EmotionForSprite(design, key) != newId`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`sprites.Remove(item.Key)`；返回值紧邻使用处：`ExpressionStatementSyntax: sprites.Remove(item.Key);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`sprites.Keys.Any(key => EmotionForSprite(previous, key) != oldId && EmotionForSprite(previous, key) != EmotionForSprite(design, key))`；返回值紧邻使用处：`IfStatementSyntax: if (sprites.Keys.Any(key => EmotionForSprite(previous, key) != oldId && EmotionForSprite(previous, key) != EmotionForSprite(design, key)))                      throw new InvalidDataException("新ID会占用另一情绪的立绘编号，请换一个ID。");`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`sprites.Where(p => EmotionForSprite(previous, p.Key) == oldId).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = sprites.Where(p => EmotionForSprite(previous, p.Key) == oldId).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`sprites.Where(p => EmotionForSprite(previous, p.Key) == oldId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: sprites.Where(p => EmotionForSprite(previous, p.Key) == oldId).ToArray`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("新ID会占用另一情绪的立绘编号，请换一个ID。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("新ID会占用另一情绪的立绘编号，请换一个ID。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("新ID与现有立绘编号冲突，请换一个ID。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("新ID与现有立绘编号冲突，请换一个ID。");`

**赋值（含属性/字段和局部值）：**


<a id="symbol-57176c13d299"></a>

## `NationalSpire.DateSceneAssetStore.ImportPack(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string) — public static void ImportPack(DateSceneAssets assets, PortraitDesign design, string path)`

来源：源码第 143 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenDateAssets(NationalSpire.CareerData, string)`](DateSceneAssetScreen.cs.md#symbol-a45b4a628cd5)

**调用：** [`NationalSpire.DateSceneAssetStore.Hash(byte[])`](DateSceneAssets.cs.md#symbol-e8871d339d39)；[`NationalSpire.DateSceneAssetStore.ImportNamedPack(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, System.IO.Compression.ZipArchive)`](DateSceneAssets.cs.md#symbol-c67565020030)；[`NationalSpire.DateSceneAssetStore.ReadImage(byte[], bool)`](DateSceneAssets.cs.md#symbol-5cd819ad6952)；[`NationalSpire.DateSceneAssetStore.Store(byte[], string)`](DateSceneAssets.cs.md#symbol-a774cf2421cf)；[`Read(string)`](DateSceneAssets.cs.md#symbol-2066b89030bb)；`string.EndsWith(string, System.StringComparison)`；`string.Equals(string?, System.StringComparison)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.IO.Compression.ZipFile.OpenRead(string)`；`System.IO.File.ReadAllBytes(string)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.IO.Path.GetExtension(string?)`；`System.Text.Encoding.GetBytes(string)`；`System.Text.Json.JsonDocument.Parse(System.ReadOnlyMemory<byte>, System.Text.Json.JsonDocumentOptions)`；`System.Text.Json.JsonElement.EnumerateArray()`；`System.Text.Json.JsonElement.GetProperty(string)`；`System.Text.Json.JsonElement.GetString()`

**字段、属性、事件及方法组引用：** `(string Hash, byte[] Bytes).Bytes`；`(string Hash, byte[] Bytes).Hash`；`NationalSpire.DateSceneAssets.OutfitId`；`NationalSpire.DateSceneAssets.Sprites`；`NationalSpire.DateSceneAssetStore.Hash(byte[])`；`NationalSpire.DateSceneAssetStore.ImportNamedPack(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, System.IO.Compression.ZipArchive)`；`NationalSpire.DateSceneAssetStore.ReadImage(byte[], bool)`；`NationalSpire.DateSceneAssetStore.Store(byte[], string)`；`NationalSpire.PortraitDesign.DefaultEmotionId`；`NationalSpire.PortraitDesign.Emotions`；`NationalSpire.PortraitDesign.PersonId`；`NationalSpire.PortraitDesign.SelectedOutfit`；`NationalSpire.PortraitEmotion.Enabled`；`NationalSpire.PortraitEmotion.Id`；`Read(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneAssetStore.Hash(byte[])`；输入表达式：`Hash(bytes)`；返回值紧邻使用处：`ArgumentSyntax: Hash(bytes)`
- `NationalSpire.DateSceneAssetStore.Hash(byte[])`；输入表达式：`Hash(System.Text.Encoding.UTF8.GetBytes(design.PersonId))`；返回值紧邻使用处：`ElementAccessExpressionSyntax: Hash(System.Text.Encoding.UTF8.GetBytes(design.PersonId))[..16]`
- `NationalSpire.DateSceneAssetStore.ImportNamedPack(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, System.IO.Compression.ZipArchive)`；输入表达式：`ImportNamedPack(assets, design, archive)`；返回值紧邻使用处：`ExpressionStatementSyntax: ImportNamedPack(assets, design, archive);`
- `NationalSpire.DateSceneAssetStore.ReadImage(byte[], bool)`；输入表达式：`ReadImage(bytes, true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ReadImage(bytes, true)`
- `NationalSpire.DateSceneAssetStore.Store(byte[], string)`；输入表达式：`Store(item.Bytes, item.Hash)`；返回值紧邻使用处：`ExpressionStatementSyntax: Store(item.Bytes, item.Hash);`
- `Read(string)`；输入表达式：`Read("manifest.json")`；返回值紧邻使用处：`ConditionalExpressionSyntax: archive == null ? File.ReadAllBytes(path) : Read("manifest.json")`
- `Read(string)`；输入表达式：`Read(file)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Read(file)`
- `string.EndsWith(string, System.StringComparison)`；输入表达式：`file.EndsWith('/' + id + ".png", StringComparison.Ordinal)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !file.EndsWith('/' + id + ".png", StringComparison.Ordinal)`
- `string.Equals(string?, System.StringComparison)`；输入表达式：`Path.GetExtension(path).Equals(".zip", StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Path.GetExtension(path).Equals(".zip", StringComparison.OrdinalIgnoreCase) ? ZipFile.OpenRead(path) : null`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；输入表达式：`accepted.Add(id, (Hash(bytes), bytes))`；返回值紧邻使用处：`ExpressionStatementSyntax: accepted.Add(id, (Hash(bytes), bytes));`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`accepted.ContainsKey(design.DefaultEmotionId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !accepted.ContainsKey(design.DefaultEmotionId)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`accepted.ContainsKey(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: !allowed.Contains(id) || accepted.ContainsKey(id)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, (string Hash, byte[] Bytes)>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, (string Hash, byte[] Bytes)>()`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`allowed.Contains(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !allowed.Contains(id)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`archive.Entries.Any(e => e.FullName == "manifest.json")`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !archive.Entries.Any(e => e.FullName == "manifest.json")`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`design.Emotions.Where(e => e.Enabled).Select(e => e.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: design.Emotions.Where(e => e.Enabled).Select(e => e.Id).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`accepted.ToDictionary(p => p.Key, p => p.Value.Hash)`；返回值紧邻使用处：`AssignmentExpressionSyntax: assets.Sprites = accepted.ToDictionary(p => p.Key, p => p.Value.Hash)`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`design.Emotions.Where(e => e.Enabled).Select(e => e.Id).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = design.Emotions.Where(e => e.Enabled).Select(e => e.Id).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`design.Emotions.Where(e => e.Enabled)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: design.Emotions.Where(e => e.Enabled).Select`
- `System.IO.Compression.ZipFile.OpenRead(string)`；输入表达式：`ZipFile.OpenRead(path)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Path.GetExtension(path).Equals(".zip", StringComparison.OrdinalIgnoreCase) ? ZipFile.OpenRead(path) : null`
- `System.IO.File.ReadAllBytes(string)`；输入表达式：`File.ReadAllBytes(path)`；返回值紧邻使用处：`ConditionalExpressionSyntax: archive == null ? File.ReadAllBytes(path) : Read("manifest.json")`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("立绘包缺少默认差分：" + design.DefaultEmotionId)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("立绘包缺少默认差分：" + design.DefaultEmotionId);`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("清单与当前角色或套装不匹配，请使用该角色当前套装导出的清单。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("清单与当前角色或套装不匹配，请使用该角色当前套装导出的清单。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("情绪ID、文件名或启用状态与设计不匹配：" + id)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("情绪ID、文件名或启用状态与设计不匹配：" + id);`
- `System.IO.Path.GetExtension(string?)`；输入表达式：`Path.GetExtension(path)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Path.GetExtension(path).Equals`
- `System.Text.Encoding.GetBytes(string)`；输入表达式：`System.Text.Encoding.UTF8.GetBytes(design.PersonId)`；返回值紧邻使用处：`ArgumentSyntax: System.Text.Encoding.UTF8.GetBytes(design.PersonId)`
- `System.Text.Json.JsonDocument.Parse(System.ReadOnlyMemory<byte>, System.Text.Json.JsonDocumentOptions)`；输入表达式：`JsonDocument.Parse(archive == null ? File.ReadAllBytes(path) : Read("manifest.json"))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = JsonDocument.Parse(archive == null ? File.ReadAllBytes(path) : Read("manifest.json"))`
- `System.Text.Json.JsonElement.EnumerateArray()`；输入表达式：`manifest.GetProperty("sprites").EnumerateArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var entry in manifest.GetProperty("sprites").EnumerateArray())          {              string id = entry.GetProperty("emotionId").GetString() ?? "", file = entry.GetProperty("file").GetString() ?? "";              if (!allowed.Contains(id) || accepted.ContainsKey(id) || !file.EndsWith('/' + id + ".png", StringComparison.Ordinal)) throw new InvalidDataException("情绪ID、文件名或启用状态与设计不匹配：" + id);              byte[] bytes = Read(file); using var image = ReadImage(bytes, true); accepted.Add(id, (Hash(bytes), bytes));          }`
- `System.Text.Json.JsonElement.GetProperty(string)`；输入表达式：`entry.GetProperty("emotionId")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: entry.GetProperty("emotionId").GetString`
- `System.Text.Json.JsonElement.GetProperty(string)`；输入表达式：`entry.GetProperty("file")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: entry.GetProperty("file").GetString`
- `System.Text.Json.JsonElement.GetProperty(string)`；输入表达式：`manifest.GetProperty("characterId")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: manifest.GetProperty("characterId").GetString`
- `System.Text.Json.JsonElement.GetProperty(string)`；输入表达式：`manifest.GetProperty("outfitId")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: manifest.GetProperty("outfitId").GetString`
- `System.Text.Json.JsonElement.GetProperty(string)`；输入表达式：`manifest.GetProperty("sprites")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: manifest.GetProperty("sprites").EnumerateArray`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`entry.GetProperty("emotionId").GetString()`；返回值紧邻使用处：`BinaryExpressionSyntax: entry.GetProperty("emotionId").GetString() ?? ""`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`entry.GetProperty("file").GetString()`；返回值紧邻使用处：`BinaryExpressionSyntax: entry.GetProperty("file").GetString() ?? ""`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`manifest.GetProperty("characterId").GetString()`；返回值紧邻使用处：`BinaryExpressionSyntax: manifest.GetProperty("characterId").GetString() != character`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`manifest.GetProperty("outfitId").GetString()`；返回值紧邻使用处：`BinaryExpressionSyntax: manifest.GetProperty("outfitId").GetString() != design.SelectedOutfit`

**赋值（含属性/字段和局部值）：**

- `assets.OutfitId` = `design.SelectedOutfit`
- `assets.Sprites` = `accepted.ToDictionary(p => p.Key, p => p.Value.Hash)`

<a id="symbol-2066b89030bb"></a>

## `Read(string) — byte[] Read(string name)`

来源：源码第 147 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneAssetStore.ImportPack(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string)`](DateSceneAssets.cs.md#symbol-57176c13d299)

**调用：** `string.Contains(char)`；`string.Replace(char, char)`；`string.Split(char, System.StringSplitOptions)`；`string.StartsWith(char)`；`string.StartsWith(string, System.StringComparison)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.IO.Compression.ZipArchiveEntry.Open()`；`System.IO.File.ReadAllBytes(string)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.IO.MemoryStream.MemoryStream()`；`System.IO.MemoryStream.ToArray()`；`System.IO.Path.Combine(string, string)`；`System.IO.Path.GetDirectoryName(string?)`；`System.IO.Path.GetFullPath(string)`；`System.IO.Stream.CopyTo(System.IO.Stream)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Contains(char)`；输入表达式：`name.Contains('\\')`；返回值紧邻使用处：`BinaryExpressionSyntax: name.Contains('\\') || name.StartsWith('/')`
- `string.Contains(char)`；输入表达式：`p.Contains(':')`；返回值紧邻使用处：`BinaryExpressionSyntax: p is ".." or "." || p.Contains(':')`
- `string.Replace(char, char)`；输入表达式：`name.Replace('/', Path.DirectorySeparatorChar)`；返回值紧邻使用处：`ArgumentSyntax: name.Replace('/', Path.DirectorySeparatorChar)`
- `string.Split(char, System.StringSplitOptions)`；输入表达式：`name.Split('/')`；返回值紧邻使用处：`MemberAccessExpressionSyntax: name.Split('/').Any`
- `string.StartsWith(char)`；输入表达式：`name.StartsWith('/')`；返回值紧邻使用处：`BinaryExpressionSyntax: name.Contains('\\') || name.StartsWith('/')`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`resolved.StartsWith(root, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !resolved.StartsWith(root, StringComparison.OrdinalIgnoreCase)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`name.Split('/').Any(p => p is ".." or "." || p.Contains(':'))`；返回值紧邻使用处：`BinaryExpressionSyntax: name.Contains('\\') || name.StartsWith('/') || name.Split('/').Any(p => p is ".." or "." || p.Contains(':'))`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`archive.Entries.Where(e => e.FullName == name).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = archive.Entries.Where(e => e.FullName == name).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`archive.Entries.Where(e => e.FullName == name)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: archive.Entries.Where(e => e.FullName == name).ToArray`
- `System.IO.Compression.ZipArchiveEntry.Open()`；输入表达式：`found[0].Open()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = found[0].Open()`
- `System.IO.File.ReadAllBytes(string)`；输入表达式：`File.ReadAllBytes(resolved)`；返回值紧邻使用处：`ReturnStatementSyntax: return File.ReadAllBytes(resolved);`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("单张图片超过64MB，请缩小文件后重新导出。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("单张图片超过64MB，请缩小文件后重新导出。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("立绘包缺少或重复文件：" + name)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("立绘包缺少或重复文件：" + name);`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("清单中的图片路径无效。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("清单中的图片路径无效。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("图片路径超出清单目录。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("图片路径超出清单目录。");`
- `System.IO.MemoryStream.MemoryStream()`；输入表达式：`new MemoryStream()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MemoryStream()`
- `System.IO.MemoryStream.ToArray()`；输入表达式：`output.ToArray()`；返回值紧邻使用处：`ReturnStatementSyntax: return output.ToArray();`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(root, name.Replace('/', Path.DirectorySeparatorChar))`；返回值紧邻使用处：`ArgumentSyntax: Path.Combine(root, name.Replace('/', Path.DirectorySeparatorChar))`
- `System.IO.Path.GetDirectoryName(string?)`；输入表达式：`Path.GetDirectoryName(path)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: Path.GetDirectoryName(path)!`
- `System.IO.Path.GetFullPath(string)`；输入表达式：`Path.GetFullPath(Path.Combine(root, name.Replace('/', Path.DirectorySeparatorChar)))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Path.GetFullPath(Path.Combine(root, name.Replace('/', Path.DirectorySeparatorChar)))`
- `System.IO.Path.GetFullPath(string)`；输入表达式：`Path.GetFullPath(Path.GetDirectoryName(path)!)`；返回值紧邻使用处：`BinaryExpressionSyntax: Path.GetFullPath(Path.GetDirectoryName(path)!) + Path.DirectorySeparatorChar`
- `System.IO.Stream.CopyTo(System.IO.Stream)`；输入表达式：`input.CopyTo(output)`；返回值紧邻使用处：`ExpressionStatementSyntax: input.CopyTo(output);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c67565020030"></a>

## `NationalSpire.DateSceneAssetStore.ImportNamedPack(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, System.IO.Compression.ZipArchive) — private static void ImportNamedPack(DateSceneAssets assets, PortraitDesign design, ZipArchive archive)`

来源：源码第 176 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneAssetStore.ImportPack(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string)`](DateSceneAssets.cs.md#symbol-57176c13d299)

**调用：** [`NationalSpire.DateSceneAssetStore.EmotionForSprite(NationalSpire.PortraitDesign, string)`](DateSceneAssets.cs.md#symbol-5b7cd1e95015)；[`NationalSpire.DateSceneAssetStore.Hash(byte[])`](DateSceneAssets.cs.md#symbol-e8871d339d39)；[`NationalSpire.DateSceneAssetStore.ReadImage(byte[], bool)`](DateSceneAssets.cs.md#symbol-5cd819ad6952)；[`NationalSpire.DateSceneAssetStore.Store(byte[], string)`](DateSceneAssets.cs.md#symbol-a774cf2421cf)；`string.Contains(char)`；`string.EndsWith(string, System.StringComparison)`；`string.Split(char, System.StringSplitOptions)`；`string.StartsWith(char)`；`string.StartsWith(string)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IDictionary<TKey, TValue>)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.IO.Compression.ZipArchiveEntry.Open()`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.IO.MemoryStream.MemoryStream()`；`System.IO.MemoryStream.ToArray()`；`System.IO.Path.GetFileNameWithoutExtension(string?)`；`System.IO.Stream.CopyTo(System.IO.Stream)`

**字段、属性、事件及方法组引用：** `(string Hash, byte[] Bytes).Bytes`；`(string Hash, byte[] Bytes).Hash`；`NationalSpire.DateSceneAssets.OutfitId`；`NationalSpire.DateSceneAssets.Outfits`；`NationalSpire.DateSceneAssets.Sprites`；`NationalSpire.DateSceneAssetStore.EmotionForSprite(NationalSpire.PortraitDesign, string)`；`NationalSpire.DateSceneAssetStore.Hash(byte[])`；`NationalSpire.DateSceneAssetStore.ReadImage(byte[], bool)`；`NationalSpire.DateSceneAssetStore.Store(byte[], string)`；`NationalSpire.PortraitDesign.DefaultEmotionId`；`NationalSpire.PortraitDesign.SelectedOutfit`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneAssetStore.EmotionForSprite(NationalSpire.PortraitDesign, string)`；输入表达式：`EmotionForSprite(design, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: EmotionForSprite(design, id) == design.DefaultEmotionId`
- `NationalSpire.DateSceneAssetStore.EmotionForSprite(NationalSpire.PortraitDesign, string)`；输入表达式：`EmotionForSprite(design, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: EmotionForSprite(design, id) == null`
- `NationalSpire.DateSceneAssetStore.Hash(byte[])`；输入表达式：`Hash(bytes)`；返回值紧邻使用处：`ArgumentSyntax: Hash(bytes)`
- `NationalSpire.DateSceneAssetStore.ReadImage(byte[], bool)`；输入表达式：`ReadImage(bytes, true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ReadImage(bytes, true)`
- `NationalSpire.DateSceneAssetStore.Store(byte[], string)`；输入表达式：`Store(item.Bytes, item.Hash)`；返回值紧邻使用处：`ExpressionStatementSyntax: Store(item.Bytes, item.Hash);`
- `string.Contains(char)`；输入表达式：`entry.FullName.Contains('\\')`；返回值紧邻使用处：`BinaryExpressionSyntax: entry.FullName.Contains('\\') || entry.FullName.StartsWith('/')`
- `string.Contains(char)`；输入表达式：`p.Contains(':')`；返回值紧邻使用处：`BinaryExpressionSyntax: p is ".." or "." || p.Contains(':')`
- `string.EndsWith(string, System.StringComparison)`；输入表达式：`e.FullName.EndsWith(".png", StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: e.FullName.EndsWith(".png", StringComparison.OrdinalIgnoreCase) && !e.FullName.StartsWith("__MACOSX/")`
- `string.Split(char, System.StringSplitOptions)`；输入表达式：`entry.FullName.Split('/')`；返回值紧邻使用处：`MemberAccessExpressionSyntax: entry.FullName.Split('/').Any`
- `string.StartsWith(char)`；输入表达式：`entry.FullName.StartsWith('/')`；返回值紧邻使用处：`BinaryExpressionSyntax: entry.FullName.Contains('\\') || entry.FullName.StartsWith('/')`
- `string.StartsWith(string)`；输入表达式：`e.FullName.StartsWith("__MACOSX/")`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !e.FullName.StartsWith("__MACOSX/")`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；输入表达式：`accepted.Add(id, (Hash(bytes), bytes))`；返回值紧邻使用处：`ExpressionStatementSyntax: accepted.Add(id, (Hash(bytes), bytes));`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`accepted.ContainsKey(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: EmotionForSprite(design, id) == null || accepted.ContainsKey(id)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, (string Hash, byte[] Bytes)>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, (string Hash, byte[] Bytes)>()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IDictionary<TKey, TValue>)`；输入表达式：`new Dictionary<string, string>(assets.Outfits.GetValueOrDefault(design.SelectedOutfit) ?? [])`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, string>(assets.Outfits.GetValueOrDefault(design.SelectedOutfit) ?? [])`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`entry.FullName.Split('/').Any(p => p is ".." or "." || p.Contains(':'))`；返回值紧邻使用处：`BinaryExpressionSyntax: entry.FullName.Contains('\\') || entry.FullName.StartsWith('/') || entry.FullName.Split('/').Any(p => p is ".." or "." || p.Contains(':'))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`merged.Keys.Any(id => EmotionForSprite(design, id) == design.DefaultEmotionId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !merged.Keys.Any(id => EmotionForSprite(design, id) == design.DefaultEmotionId)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`archive.Entries.Where(e => e.FullName.EndsWith(".png", StringComparison.OrdinalIgnoreCase) && !e.FullName.StartsWith("__MACOSX/"))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var entry in archive.Entries.Where(e => e.FullName.EndsWith(".png", StringComparison.OrdinalIgnoreCase) && !e.FullName.StartsWith("__MACOSX/")))          {              if (entry.FullName.Contains('\\') || entry.FullName.StartsWith('/') || entry.FullName.Split('/').Any(p => p is ".." or "." || p.Contains(':')))                  throw new InvalidDataException("立绘包中的图片路径无效。");              string id = Path.GetFileNameWithoutExtension(entry.Name);              if (EmotionForSprite(design, id) == null || accepted.ContainsKey(id)) throw new InvalidDataException("PNG文件名须为情绪ID或情绪ID_数字，且文件名唯一：" + id);              total += entry.Length;              if (entry.Length > 64 * 1024 * 1024 || total > 512L * 1024 * 1024) throw new InvalidDataException("立绘包过大，请分批导入。");              using var input = entry.Open(); using var output = new MemoryStream(); input.CopyTo(output); byte[] bytes = output.ToArray();              using var image = ReadImage(bytes, true); accepted.Add(id, (Hash(bytes), bytes));          }`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`assets.Outfits.GetValueOrDefault(design.SelectedOutfit)`；返回值紧邻使用处：`BinaryExpressionSyntax: assets.Outfits.GetValueOrDefault(design.SelectedOutfit) ?? []`
- `System.IO.Compression.ZipArchiveEntry.Open()`；输入表达式：`entry.Open()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = entry.Open()`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("立绘包过大，请分批导入。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("立绘包过大，请分批导入。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("立绘包中的图片路径无效。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("立绘包中的图片路径无效。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("立绘包中没有PNG图片。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("立绘包中没有PNG图片。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("PNG文件名须为情绪ID或情绪ID_数字，且文件名唯一：" + id)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("PNG文件名须为情绪ID或情绪ID_数字，且文件名唯一：" + id);`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException($"请提供{design.DefaultEmotionId}.png或{design.DefaultEmotionId}_数字.png默认立绘。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException($"请提供{design.DefaultEmotionId}.png或{design.DefaultEmotionId}_数字.png默认立绘。");`
- `System.IO.MemoryStream.MemoryStream()`；输入表达式：`new MemoryStream()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MemoryStream()`
- `System.IO.MemoryStream.ToArray()`；输入表达式：`output.ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = output.ToArray()`
- `System.IO.Path.GetFileNameWithoutExtension(string?)`；输入表达式：`Path.GetFileNameWithoutExtension(entry.Name)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Path.GetFileNameWithoutExtension(entry.Name)`
- `System.IO.Stream.CopyTo(System.IO.Stream)`；输入表达式：`input.CopyTo(output)`；返回值紧邻使用处：`ExpressionStatementSyntax: input.CopyTo(output);`

**赋值（含属性/字段和局部值）：**

- `assets.OutfitId` = `design.SelectedOutfit`
- `assets.Sprites` = `merged`
- `merged[item.Key]` = `item.Value.Hash`
- `total` += `entry.Length`

<a id="symbol-255ccc15c761"></a>

## `NationalSpire.DateSceneAssetStore.ImportBackground(string) — public static string ImportBackground(string path)`

来源：源码第 198 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneBackgrounds.Import(string)`](DateSceneBackgrounds.cs.md#symbol-2c3c4974b94b)；[`NationalSpire.DateSceneBackgrounds.Read(out string, string?)`](DateSceneBackgrounds.cs.md#symbol-b6c3bc7d87d9)

**调用：** [`NationalSpire.DateSceneAssetStore.ImportBackgroundBytes(byte[], string)`](DateSceneAssets.cs.md#symbol-d04a3543dc27)；`System.IO.File.ReadAllBytes(string)`；`System.IO.FileInfo.FileInfo(string)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.IO.Path.GetExtension(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneAssetStore.ImportBackgroundBytes(byte[], string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneAssetStore.ImportBackgroundBytes(byte[], string)`；输入表达式：`ImportBackgroundBytes(File.ReadAllBytes(path), Path.GetExtension(path))`；返回值紧邻使用处：`ReturnStatementSyntax: return ImportBackgroundBytes(File.ReadAllBytes(path), Path.GetExtension(path));`
- `System.IO.File.ReadAllBytes(string)`；输入表达式：`File.ReadAllBytes(path)`；返回值紧邻使用处：`ArgumentSyntax: File.ReadAllBytes(path)`
- `System.IO.FileInfo.FileInfo(string)`；输入表达式：`new FileInfo(path)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new FileInfo(path).Length`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("背景图片超过64MB，请缩小后导入。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("背景图片超过64MB，请缩小后导入。");`
- `System.IO.Path.GetExtension(string?)`；输入表达式：`Path.GetExtension(path)`；返回值紧邻使用处：`ArgumentSyntax: Path.GetExtension(path)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d04a3543dc27"></a>

## `NationalSpire.DateSceneAssetStore.ImportBackgroundBytes(byte[], string) — public static string ImportBackgroundBytes(byte[] bytes, string extension)`

来源：源码第 203 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneAssetStore.ImportBackground(string)`](DateSceneAssets.cs.md#symbol-255ccc15c761)；[`NationalSpire.DateSceneBackgrounds.Import(string)`](DateSceneBackgrounds.cs.md#symbol-2c3c4974b94b)；[`NationalSpire.DateSceneBackgrounds.ResolveImage(string)`](DateSceneBackgrounds.cs.md#symbol-05e1fa49f816)

**调用：** [`NationalSpire.DateSceneAssetStore.Hash(byte[])`](DateSceneAssets.cs.md#symbol-e8871d339d39)；[`NationalSpire.DateSceneAssetStore.ReadBackgroundImage(byte[], string)`](DateSceneAssets.cs.md#symbol-e78822490246)；[`NationalSpire.DateSceneAssetStore.Store(byte[], string)`](DateSceneAssets.cs.md#symbol-a774cf2421cf)；`Godot.Image.SavePngToBuffer()`；`string.Equals(string?, System.StringComparison)`；`System.IO.InvalidDataException.InvalidDataException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneAssetStore.Hash(byte[])`；`NationalSpire.DateSceneAssetStore.ReadBackgroundImage(byte[], string)`；`NationalSpire.DateSceneAssetStore.Store(byte[], string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Image.SavePngToBuffer()`；输入表达式：`image.SavePngToBuffer()`；返回值紧邻使用处：`AssignmentExpressionSyntax: bytes = image.SavePngToBuffer()`
- `NationalSpire.DateSceneAssetStore.Hash(byte[])`；输入表达式：`Hash(bytes)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Hash(bytes)`
- `NationalSpire.DateSceneAssetStore.ReadBackgroundImage(byte[], string)`；输入表达式：`ReadBackgroundImage(bytes, extension)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ReadBackgroundImage(bytes, extension)`
- `NationalSpire.DateSceneAssetStore.Store(byte[], string)`；输入表达式：`Store(bytes, hash)`；返回值紧邻使用处：`ExpressionStatementSyntax: Store(bytes, hash);`
- `string.Equals(string?, System.StringComparison)`；输入表达式：`extension.Equals(".png", StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !extension.Equals(".png", StringComparison.OrdinalIgnoreCase)`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("请选择完整的PNG图片（单张至多64MB）。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("请选择完整的PNG图片（单张至多64MB）。");`

**赋值（含属性/字段和局部值）：**

- `bytes` = `image.SavePngToBuffer()`

<a id="symbol-e78822490246"></a>

## `NationalSpire.DateSceneAssetStore.ReadBackgroundImage(byte[], string) — public static Image ReadBackgroundImage(byte[] bytes, string extension)`

来源：源码第 210 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneAssetStore.ImportBackgroundBytes(byte[], string)`](DateSceneAssets.cs.md#symbol-d04a3543dc27)；[`NationalSpire.DateSceneBackgrounds.Pixels(string)`](DateSceneBackgrounds.cs.md#symbol-3098b5a3a6eb)

**调用：** [`NationalSpire.DateSceneAssetStore.ReadImage(byte[], bool)`](DateSceneAssets.cs.md#symbol-5cd819ad6952)；`Godot.GodotObject.Dispose()`；`Godot.Image.GetHeight()`；`Godot.Image.GetWidth()`；`Godot.Image.Image()`；`Godot.Image.IsEmpty()`；`Godot.Image.LoadJpgFromBuffer(byte[])`；`Godot.Image.LoadPngFromBuffer(byte[])`；`Godot.Image.LoadWebpFromBuffer(byte[])`；`string.Equals(string?, System.StringComparison)`；`string.ToLowerInvariant()`；`System.IO.InvalidDataException.InvalidDataException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneAssetStore.ReadImage(byte[], bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.Dispose()`；输入表达式：`image.Dispose()`；返回值紧邻使用处：`ExpressionStatementSyntax: image.Dispose();`
- `Godot.Image.GetHeight()`；输入表达式：`image.GetHeight()`；返回值紧邻使用处：`BinaryExpressionSyntax: (long)image.GetWidth() * image.GetHeight()`
- `Godot.Image.GetWidth()`；输入表达式：`image.GetWidth()`；返回值紧邻使用处：`CastExpressionSyntax: (long)image.GetWidth()`
- `Godot.Image.Image()`；输入表达式：`new Image()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Image()`
- `Godot.Image.IsEmpty()`；输入表达式：`image.IsEmpty()`；返回值紧邻使用处：`BinaryExpressionSyntax: result != Error.Ok || image.IsEmpty()`
- `Godot.Image.LoadJpgFromBuffer(byte[])`；输入表达式：`image.LoadJpgFromBuffer(bytes)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: ".jpg" or ".jpeg" => image.LoadJpgFromBuffer(bytes)`
- `Godot.Image.LoadPngFromBuffer(byte[])`；输入表达式：`image.LoadPngFromBuffer(bytes)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: _ => image.LoadPngFromBuffer(bytes)`
- `Godot.Image.LoadWebpFromBuffer(byte[])`；输入表达式：`image.LoadWebpFromBuffer(bytes)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: ".webp" => image.LoadWebpFromBuffer(bytes)`
- `NationalSpire.DateSceneAssetStore.ReadImage(byte[], bool)`；输入表达式：`ReadImage(bytes, false)`；返回值紧邻使用处：`ReturnStatementSyntax: return ReadImage(bytes, false);`
- `string.Equals(string?, System.StringComparison)`；输入表达式：`extension.Equals(".png", StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`IfStatementSyntax: if (extension.Equals(".png", StringComparison.OrdinalIgnoreCase)) return ReadImage(bytes, false);`
- `string.ToLowerInvariant()`；输入表达式：`extension.ToLowerInvariant()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = extension.ToLowerInvariant()`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("背景图片超过64MB，请缩小后导入。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("背景图片超过64MB，请缩小后导入。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("背景图片无法读取。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("背景图片无法读取。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("图片尺寸过大或无效，请缩小图片。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("图片尺寸过大或无效，请缩小图片。");`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b176dfac69ce"></a>

## `NationalSpire.DateSceneAssetStore.Pixels(string, bool) — public static Image Pixels(string hash, bool sprite = true)`

来源：源码第 220 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneAssetStore.Texture(string, bool)`](DateSceneAssets.cs.md#symbol-616d47ee9d6a)；[`NationalSpire.DateSceneBackgrounds.Pixels(string)`](DateSceneBackgrounds.cs.md#symbol-3098b5a3a6eb)

**调用：** [`NationalSpire.DateSceneAssetStore.BlobPath(string)`](DateSceneAssets.cs.md#symbol-1b33c2ffb1f6)；[`NationalSpire.DateSceneAssetStore.Hash(byte[])`](DateSceneAssets.cs.md#symbol-e8871d339d39)；[`NationalSpire.DateSceneAssetStore.ReadImage(byte[], bool)`](DateSceneAssets.cs.md#symbol-5cd819ad6952)；`System.IO.File.ReadAllBytes(string)`；`System.IO.InvalidDataException.InvalidDataException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneAssetStore.BlobPath(string)`；`NationalSpire.DateSceneAssetStore.Hash(byte[])`；`NationalSpire.DateSceneAssetStore.ReadImage(byte[], bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneAssetStore.BlobPath(string)`；输入表达式：`BlobPath(hash)`；返回值紧邻使用处：`ArgumentSyntax: BlobPath(hash)`
- `NationalSpire.DateSceneAssetStore.Hash(byte[])`；输入表达式：`Hash(bytes)`；返回值紧邻使用处：`BinaryExpressionSyntax: Hash(bytes) != hash`
- `NationalSpire.DateSceneAssetStore.ReadImage(byte[], bool)`；输入表达式：`ReadImage(bytes, sprite)`；返回值紧邻使用处：`ReturnStatementSyntax: return ReadImage(bytes, sprite);`
- `System.IO.File.ReadAllBytes(string)`；输入表达式：`File.ReadAllBytes(BlobPath(hash))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = File.ReadAllBytes(BlobPath(hash))`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("立绘缓存已损坏，请重新导入。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("立绘缓存已损坏，请重新导入。");`

**赋值（含属性/字段和局部值）：**


<a id="symbol-616d47ee9d6a"></a>

## `NationalSpire.DateSceneAssetStore.Texture(string, bool) — public static Texture2D Texture(string hash, bool sprite = true)`

来源：源码第 225 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DateTexture(string)`](DateSceneScreen.cs.md#symbol-f1499ce9d9b1)；[`NationalSpire.DateSceneAssetStore.Ready(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign?)`](DateSceneAssets.cs.md#symbol-79425fed4748)；[`NationalSpire.DateSceneBackgrounds.RegisterLegacy(string)`](DateSceneBackgrounds.cs.md#symbol-7feab11c4c5b)；[`Select(int)`](AppearanceLibraryScreen.cs.md#symbol-76eb3d9afaf1)

**调用：** [`NationalSpire.DateSceneAssetStore.Pixels(string, bool)`](DateSceneAssets.cs.md#symbol-b176dfac69ce)；`Godot.ImageTexture.CreateFromImage(Godot.Image)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneAssetStore.Pixels(string, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ImageTexture.CreateFromImage(Godot.Image)`；输入表达式：`ImageTexture.CreateFromImage(image)`；返回值紧邻使用处：`ReturnStatementSyntax: return ImageTexture.CreateFromImage(image);`
- `NationalSpire.DateSceneAssetStore.Pixels(string, bool)`；输入表达式：`Pixels(hash, sprite)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Pixels(hash, sprite)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-79425fed4748"></a>

## `NationalSpire.DateSceneAssetStore.Ready(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign?) — public static string? Ready(DateSceneAssets assets, PortraitDesign? design)`

来源：源码第 229 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenDateScene(string)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)；[`NationalSpire.CareerScreen.PromptDateScene(string)`](DateSceneScreen.cs.md#symbol-d6c92b4f494c)

**调用：** [`NationalSpire.DateSceneAssetStore.SpriteKeys(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string)`](DateSceneAssets.cs.md#symbol-3b48b221efd8)；[`NationalSpire.DateSceneAssetStore.Texture(string, bool)`](DateSceneAssets.cs.md#symbol-616d47ee9d6a)

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneAssets.OutfitId`；`NationalSpire.DateSceneAssets.Sprites`；`NationalSpire.DateSceneAssetStore.SpriteKeys(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string)`；`NationalSpire.DateSceneAssetStore.Texture(string, bool)`；`NationalSpire.PortraitDesign.DefaultEmotionId`；`NationalSpire.PortraitDesign.SelectedOutfit`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneAssetStore.SpriteKeys(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string)`；输入表达式：`SpriteKeys(assets, design, design.DefaultEmotionId)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string key in SpriteKeys(assets, design, design.DefaultEmotionId))              try { using var texture = Texture(assets.Sprites[key]); return null; } catch { }`
- `NationalSpire.DateSceneAssetStore.Texture(string, bool)`；输入表达式：`Texture(assets.Sprites[key])`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Texture(assets.Sprites[key])`

**赋值（含属性/字段和局部值）：**

- `assets.OutfitId` = `design.SelectedOutfit`
