# DateSceneAssets.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`030D524B66BADF13304CE54A002D1BF956B17C13CF0E1FE307AE435635449F8C`。来源：[源码](../../DateSceneAssets.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.DatePortraitPlacement`、`NationalSpire.DateSceneAssets`、`NationalSpire.DateSceneBookmark`、`NationalSpire.DateSceneAssetStore`。

字段、事件及初始值（源码原样）：

```csharp

```

<a id="symbol-67e9c0f8f2dc"></a>

## `NationalSpire.DatePortraitPlacement.Normalized() — public DatePortraitPlacement Normalized()`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DatePortraitPlacement.FromAssets(NationalSpire.DateSceneAssets)`](DateSceneAssets.cs.md#symbol-841784a6385f)；[`NationalSpire.DateSceneView.PortraitPlacements(System.Collections.Generic.IReadOnlyDictionary<string, NationalSpire.DatePortraitPlacement>)`](DateSceneCast.cs.md#symbol-80abec64fd7f)

**调用：** `NationalSpire.DatePortraitPlacement.DatePortraitPlacement(double, double)`；`System.Math.Clamp(double, double, double)`；`double.IsFinite(double)`

**字段、属性、事件及方法组引用：** `NationalSpire.DatePortraitPlacement.Scale`；`NationalSpire.DatePortraitPlacement.Y`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DatePortraitPlacement.DatePortraitPlacement(double, double)`；输入表达式：`new(Math.Clamp(double.IsFinite(Scale) ? Scale : 1, .25, 2.5), Math.Clamp(double.IsFinite(Y) ? Y : 0, -200, 200))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new(Math.Clamp(double.IsFinite(Scale) ? Scale : 1, .25, 2.5), Math.Clamp(double.IsFinite(Y) ? Y : 0, -200, 200))`
- `System.Math.Clamp(double, double, double)`；输入表达式：`Math.Clamp(double.IsFinite(Scale) ? Scale : 1, .25, 2.5)`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(double.IsFinite(Scale) ? Scale : 1, .25, 2.5)`
- `System.Math.Clamp(double, double, double)`；输入表达式：`Math.Clamp(double.IsFinite(Y) ? Y : 0, -200, 200)`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(double.IsFinite(Y) ? Y : 0, -200, 200)`
- `double.IsFinite(double)`；输入表达式：`double.IsFinite(Scale)`；返回值紧邻使用处：`ConditionalExpressionSyntax: double.IsFinite(Scale) ? Scale : 1`
- `double.IsFinite(double)`；输入表达式：`double.IsFinite(Y)`；返回值紧邻使用处：`ConditionalExpressionSyntax: double.IsFinite(Y) ? Y : 0`

**赋值（含属性/字段和局部值）：**


<a id="symbol-841784a6385f"></a>

## `NationalSpire.DatePortraitPlacement.FromAssets(NationalSpire.DateSceneAssets) — public static DatePortraitPlacement FromAssets(DateSceneAssets assets)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Commit(Godot.LineEdit, bool)`](DateScenePortraitSettings.cs.md#symbol-2a982aac4aea)；[`NationalSpire.CareerScreen.ApplyDatePortraitPlacements()`](DateScenePortraitSettings.cs.md#symbol-9e6a2d77a042)；[`ShowValues()`](DateScenePortraitSettings.cs.md#symbol-092acdac73f7)

**调用：** `NationalSpire.DatePortraitPlacement.DatePortraitPlacement(double, double)`；[`NationalSpire.DatePortraitPlacement.Normalized()`](DateSceneAssets.cs.md#symbol-67e9c0f8f2dc)

**字段、属性、事件及方法组引用：** `NationalSpire.DatePortraitPlacement.Normalized()`；`NationalSpire.DateSceneAssets.SpriteScale`；`NationalSpire.DateSceneAssets.SpriteY`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DatePortraitPlacement.DatePortraitPlacement(double, double)`；输入表达式：`new DatePortraitPlacement(assets.SpriteScale, -assets.SpriteY)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new DatePortraitPlacement(assets.SpriteScale, -assets.SpriteY).Normalized`
- `NationalSpire.DatePortraitPlacement.Normalized()`；输入表达式：`new DatePortraitPlacement(assets.SpriteScale, -assets.SpriteY).Normalized()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new DatePortraitPlacement(assets.SpriteScale, -assets.SpriteY).Normalized()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-6796164638a3"></a>

## `NationalSpire.DateSceneAssets.OutfitId — public string OutfitId`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7e4a7fb6b309"></a>

## `NationalSpire.DateSceneAssets.Outfits — public Dictionary<string, Dictionary<string, string>> Outfits`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9b4e5db3b9c9"></a>

## `NationalSpire.DateSceneAssets.Sprites — public Dictionary<string, string> Sprites`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-0283d6a2efb1"></a>

## `NationalSpire.DateSceneAssets.SpriteScale — public double SpriteScale`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-312092802680"></a>

## `NationalSpire.DateSceneAssets.SpriteX — public double SpriteX`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-eae38babd0a2"></a>

## `NationalSpire.DateSceneAssets.SpriteY — public double SpriteY`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-190d596949e5"></a>

## `NationalSpire.DateSceneAssets.TextOutline — public bool TextOutline`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b383ac820b34"></a>

## `NationalSpire.DateSceneAssets.ShowAffectionBadge — public bool ShowAffectionBadge`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f21464949819"></a>

## `NationalSpire.DateSceneAssets.AutoBackground — public bool AutoBackground`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e80229f454ed"></a>

## `NationalSpire.DateSceneAssets.Blur — public bool Blur`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-63ee7f95662f"></a>

## `NationalSpire.DateSceneAssets.BlurAmount — public double BlurAmount`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-5e46f7d5af43"></a>

## `NationalSpire.DateSceneAssets.TextSpeed — public double TextSpeed`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-63e9129eaca4"></a>

## `NationalSpire.DateSceneAssets.FontSize — public int FontSize`

来源：源码第 30 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8d668ce2c816"></a>

## `NationalSpire.DateSceneAssets.LetterSpacing — public double LetterSpacing`

来源：源码第 31 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d08738dcd38e"></a>

## `NationalSpire.DateSceneAssets.PanelFade — public double PanelFade`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3df818df691e"></a>

## `NationalSpire.DateSceneAssets.Bookmarks — public Dictionary<string, DateSceneBookmark> Bookmarks`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-5c5969d14e3e"></a>

## `NationalSpire.DateSceneAssets.GameVoice — public string GameVoice`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-1d62e350fc2b"></a>

## `NationalSpire.DateSceneAssets.PresentationConfirmed — public bool PresentationConfirmed`

来源：源码第 35 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3cca0387131c"></a>

## `NationalSpire.DateSceneAssets.UseDefaultPortrait — public bool UseDefaultPortrait`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c84043df96e9"></a>

## `NationalSpire.DateSceneBookmark.Turn — public string Turn`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-dc9d0f0a40b8"></a>

## `NationalSpire.DateSceneBookmark.ReplyHash — public string ReplyHash`

来源：源码第 41 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-5b05500e3c02"></a>

## `NationalSpire.DateSceneBookmark.Index — public int Index`

来源：源码第 42 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-5b7cd1e95015"></a>

## `NationalSpire.DateSceneAssetStore.EmotionForSprite(NationalSpire.PortraitDesign, string) — public static string? EmotionForSprite(PortraitDesign design, string id)`

来源：源码第 47 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CharacterDesignPackage.Write(NationalSpire.CareerData, NationalSpire.CareerPerson, NationalSpire.PlayerAvatar, string, NationalSpire.PortraitDesign?, NationalSpire.DateSceneAssets?)`](CharacterDesignPackage.cs.md#symbol-a0889fe0f5f4)；[`NationalSpire.DateSceneAssetStore.ImportOne(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string, string, bool)`](DateSceneAssets.cs.md#symbol-d165300a808a)；[`NationalSpire.DateSceneAssetStore.SaveEmotionEdit(NationalSpire.CareerData, string, NationalSpire.PortraitDesign, NationalSpire.PortraitDesign, NationalSpire.DateSceneAssets, string, string)`](DateSceneAssets.cs.md#symbol-e6562f4576e9)；[`NationalSpire.DateSceneAssetStore.SpriteKeys(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string)`](DateSceneAssets.cs.md#symbol-3b48b221efd8)

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

来源：源码第 55 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Draw()`](DateSceneAssetScreen.cs.md#symbol-44fc11efbaa6)；[`NationalSpire.CareerScreen.DateParticipants()`](DateScenePartyScreen.cs.md#symbol-658316b8bf70)；[`NationalSpire.CareerScreen.LoadDateParty(NationalSpire.CareerData, string, string)`](DateScenePartyScreen.cs.md#symbol-e7d1a77e170a)；[`NationalSpire.CareerScreen.PartyTexture(string, string)`](DateScenePartyScreen.cs.md#symbol-53bfcf8e2a43)；[`NationalSpire.CareerScreen.PartyWaitingTextures(string)`](DateScenePartyScreen.cs.md#symbol-44daf22689a3)；[`NationalSpire.CareerScreen.RefreshDateMemoryPeople()`](DateSceneMemoryScreen.cs.md#symbol-afd6840c2c58)；[`NationalSpire.DateSceneAssetStore.Ready(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign?)`](DateSceneAssets.cs.md#symbol-79425fed4748)；[`NationalSpire.DateSceneTesting.Initialize(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>)`](DateSceneTesting.cs.md#symbol-91667df79532)；[`Select(int)`](DatePresentationScreen.cs.md#symbol-dbcf354665de)

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

来源：源码第 57 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

来源：源码第 62 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView.AdvanceDialogue()`](DateSceneView.cs.md#symbol-b412d34b179e)

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

来源：源码第 68 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.ProjectSettings.GlobalizePath(string)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ProjectSettings.GlobalizePath(string)`；输入表达式：`ProjectSettings.GlobalizePath("user://national_spire_portraits/scenes")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => ProjectSettings.GlobalizePath("user://national_spire_portraits/scenes")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-81bb8bd9a964"></a>

## `NationalSpire.DateSceneAssetStore.PathFor(NationalSpire.CareerData, string) — public static string PathFor(CareerData data, string person)`

来源：源码第 69 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CharacterDesignPackage.Installation.Installation(NationalSpire.CareerData, string, NationalSpire.PortraitDesign, NationalSpire.DateSceneAssets)`](CharacterDesignPackage.cs.md#symbol-27a8ea8feef4)；[`NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`](DateSceneAssets.cs.md#symbol-57fe620f4cc9)；[`NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets)`](DateSceneAssets.cs.md#symbol-2bf1f40a912e)

**调用：** [`NationalSpire.PortraitDesignStore.Key(NationalSpire.CareerData, string)`](PortraitDesignStore.cs.md#symbol-2ed1ee155b2d)；`System.IO.Path.Combine(string, string)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneAssetStore.DirectoryPath`；`NationalSpire.PortraitDesignStore.Key(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PortraitDesignStore.Key(NationalSpire.CareerData, string)`；输入表达式：`PortraitDesignStore.Key(data, person)`；返回值紧邻使用处：`BinaryExpressionSyntax: PortraitDesignStore.Key(data, person) + ".json"`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(DirectoryPath, PortraitDesignStore.Key(data, person) + ".json")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Path.Combine(DirectoryPath, PortraitDesignStore.Key(data, person) + ".json")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-57fe620f4cc9"></a>

## `NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string) — public static DateSceneAssets Read(CareerData data, string person)`

来源：源码第 70 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AppearanceLibrary.Prepare(NationalSpire.CareerData, string, NationalSpire.AppearanceLibrary.Package)`](AppearanceLibrary.cs.md#symbol-bca14526873f)；[`NationalSpire.CareerScreen.AddDateVoiceSettings(Godot.VBoxContainer)`](DateGameScreen.cs.md#symbol-ad300bbb552d)；[`NationalSpire.CareerScreen.DateSceneSettings()`](DateSceneScreen.cs.md#symbol-0845ec2acab1)；[`NationalSpire.CareerScreen.LaunchDateGame(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](DateGameScreen.cs.md#symbol-60cf62536a73)；[`NationalSpire.CareerScreen.LoadDateParty(NationalSpire.CareerData, string, string)`](DateScenePartyScreen.cs.md#symbol-e7d1a77e170a)；[`NationalSpire.CareerScreen.NewDateEmotion(NationalSpire.CareerData, string, string)`](DateSceneAssetScreen.cs.md#symbol-29862ab95d64)；[`NationalSpire.CareerScreen.OpenCharacterCardCore(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?, NationalSpire.CharacterDesignPackage.Imported?)`](CharacterCardScreen.cs.md#symbol-c2fe452ad056)；[`NationalSpire.CareerScreen.OpenDateAssets(NationalSpire.CareerData, string)`](DateSceneAssetScreen.cs.md#symbol-a45b4a628cd5)；[`NationalSpire.CareerScreen.OpenDateScene(string, bool, bool)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)；[`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)；[`NationalSpire.CharacterDesignPackage.Write(NationalSpire.CareerData, NationalSpire.CareerPerson, NationalSpire.PlayerAvatar, string, NationalSpire.PortraitDesign?, NationalSpire.DateSceneAssets?)`](CharacterDesignPackage.cs.md#symbol-a0889fe0f5f4)；[`NationalSpire.DatePresentation.Initial(NationalSpire.CareerData, string, bool)`](DatePresentation.cs.md#symbol-8371585517ce)；[`NationalSpire.DatePresentation.Pending(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`](DatePresentation.cs.md#symbol-9855f582740d)；[`NationalSpire.DatePresentation.Prepare(NationalSpire.CareerData, NationalSpire.DatePresentation.Selection)`](DatePresentation.cs.md#symbol-dba968a252db)；[`NationalSpire.DateSceneAssetStore.HasImportedSprites(NationalSpire.CareerData, string)`](DateSceneAssets.cs.md#symbol-364c6958d307)；[`NationalSpire.DateSceneTesting.Initialize(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>)`](DateSceneTesting.cs.md#symbol-91667df79532)；[`Select()`](DateGameScreen.cs.md#symbol-c15130f82b97)

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

<a id="symbol-364c6958d307"></a>

## `NationalSpire.DateSceneAssetStore.HasImportedSprites(NationalSpire.CareerData, string) — public static bool HasImportedSprites(CareerData data, string person)`

来源：源码第 77 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`ShowRows()`](PeoplePickerScreen.cs.md#symbol-0dac44c0ee6b)

**调用：** [`NationalSpire.DateSceneAssetStore.BlobPath(string)`](DateSceneAssets.cs.md#symbol-1b33c2ffb1f6)；[`NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`](DateSceneAssets.cs.md#symbol-57fe620f4cc9)；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.IO.File.Exists(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneAssetStore.BlobPath(string)`；`NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`；`NationalSpire.DateSceneAssets.Outfits`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneAssetStore.BlobPath(string)`；输入表达式：`BlobPath(hash)`；返回值紧邻使用处：`ArgumentSyntax: BlobPath(hash)`
- `NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`；输入表达式：`Read(data, person)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Read(data, person).Outfits`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`hash.All(char.IsAsciiHexDigit)`；返回值紧邻使用处：`BinaryExpressionSyntax: hash.Length == 64 && hash.All(char.IsAsciiHexDigit)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`Read(data, person).Outfits.Values.SelectMany(outfit => outfit.Values).Any(hash => hash.Length == 64 && hash.All(char.IsAsciiHexDigit) && File.Exists(BlobPath(hash)))`；返回值紧邻使用处：`ReturnStatementSyntax: return Read(data, person).Outfits.Values.SelectMany(outfit => outfit.Values).Any(hash => hash.Length == 64 && hash.All(char.IsAsciiHexDigit) && File.Exists(BlobPath(hash)));`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`Read(data, person).Outfits.Values.SelectMany(outfit => outfit.Values)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Read(data, person).Outfits.Values.SelectMany(outfit => outfit.Values).Any`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(BlobPath(hash))`；返回值紧邻使用处：`BinaryExpressionSyntax: hash.Length == 64 && hash.All(char.IsAsciiHexDigit) && File.Exists(BlobPath(hash))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2bf1f40a912e"></a>

## `NationalSpire.DateSceneAssetStore.Save(NationalSpire.CareerData, string, NationalSpire.DateSceneAssets) — public static void Save(CareerData data, string person, DateSceneAssets assets)`

来源：源码第 86 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Draw()`](DateSceneAssetScreen.cs.md#symbol-44fc11efbaa6)；[`Import(System.Action<NationalSpire.DateSceneAssets, string>, string[])`](DateSceneAssetScreen.cs.md#symbol-5d9a90f3c871)；[`NationalSpire.CareerScreen.AddDateVoiceSettings(Godot.VBoxContainer)`](DateGameScreen.cs.md#symbol-ad300bbb552d)；[`NationalSpire.CareerScreen.AdvanceDateScene()`](DateSceneScreen.cs.md#symbol-96e53c8a266f)；[`NationalSpire.CareerScreen.DateSceneSettings()`](DateSceneScreen.cs.md#symbol-0845ec2acab1)；[`NationalSpire.CareerScreen.LeaveDateScene(bool)`](DateSceneScreen.cs.md#symbol-942f3afae68b)；[`NationalSpire.CareerScreen.OpenDateAssets(NationalSpire.CareerData, string)`](DateSceneAssetScreen.cs.md#symbol-a45b4a628cd5)；[`NationalSpire.CareerScreen.SaveDateGameBookmark()`](DateGameScreen.cs.md#symbol-96b515b66a99)；[`NationalSpire.CharacterDesignPackage.Installation.Installation(NationalSpire.CareerData, string, NationalSpire.PortraitDesign, NationalSpire.DateSceneAssets)`](CharacterDesignPackage.cs.md#symbol-27a8ea8feef4)；[`NationalSpire.DateSceneAssetStore.SaveEmotionEdit(NationalSpire.CareerData, string, NationalSpire.PortraitDesign, NationalSpire.PortraitDesign, NationalSpire.DateSceneAssets, string, string)`](DateSceneAssets.cs.md#symbol-e6562f4576e9)；[`Save()`](DateSceneScreen.cs.md#symbol-5e2413f0aa95)；[`SaveDirty()`](DateScenePortraitSettings.cs.md#symbol-66856ca56b04)

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

来源：源码第 92 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)；[`NationalSpire.CareerScreen.RememberDateImage(Godot.Texture2D)`](DateSceneMemoryScreen.cs.md#symbol-5fae395fe1f4)；[`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)；[`NationalSpire.CharacterDesignPackage.Read(NationalSpire.CareerData, System.IO.Stream, bool)`](CharacterDesignPackage.cs.md#symbol-abec8cae7c17)；[`NationalSpire.CharacterDesignPackage.Write(NationalSpire.CareerData, NationalSpire.CareerPerson, NationalSpire.PlayerAvatar, string, NationalSpire.PortraitDesign?, NationalSpire.DateSceneAssets?)`](CharacterDesignPackage.cs.md#symbol-a0889fe0f5f4)；[`NationalSpire.DateSceneAssetStore.ImportBackgroundBytes(byte[], string)`](DateSceneAssets.cs.md#symbol-d04a3543dc27)；[`NationalSpire.DateSceneAssetStore.ImportOne(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string, string, bool)`](DateSceneAssets.cs.md#symbol-d165300a808a)；[`NationalSpire.DateSceneAssetStore.Pixels(string, bool)`](DateSceneAssets.cs.md#symbol-b176dfac69ce)；[`NationalSpire.DateSceneAssetStore.Store(byte[], string)`](DateSceneAssets.cs.md#symbol-a774cf2421cf)；[`NationalSpire.DateSceneAssetStore.StoreSprite(byte[])`](DateSceneAssets.cs.md#symbol-d6c8bc9f985e)；[`NationalSpire.DateSceneMemories.FilePath(NationalSpire.CareerData, string)`](DateSceneMemories.cs.md#symbol-c6266089e238)；[`NationalSpire.PortraitPackageImport.Merge(NationalSpire.PortraitPackageImport.Plan, NationalSpire.PortraitDesign, NationalSpire.DateSceneAssets, System.Collections.Generic.ISet<string>)`](PortraitPackageImport.cs.md#symbol-63ab2a20968e)

**调用：** `string.ToLowerInvariant()`；`System.Convert.ToHexString(byte[])`；`System.Security.Cryptography.SHA256.HashData(byte[])`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.ToLowerInvariant()`；输入表达式：`Convert.ToHexString(SHA256.HashData(bytes)).ToLowerInvariant()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Convert.ToHexString(SHA256.HashData(bytes)).ToLowerInvariant()`
- `System.Convert.ToHexString(byte[])`；输入表达式：`Convert.ToHexString(SHA256.HashData(bytes))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Convert.ToHexString(SHA256.HashData(bytes)).ToLowerInvariant`
- `System.Security.Cryptography.SHA256.HashData(byte[])`；输入表达式：`SHA256.HashData(bytes)`；返回值紧邻使用处：`ArgumentSyntax: SHA256.HashData(bytes)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1b33c2ffb1f6"></a>

## `NationalSpire.DateSceneAssetStore.BlobPath(string) — public static string BlobPath(string hash)`

来源：源码第 93 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LoadDateParty(NationalSpire.CareerData, string, string)`](DateScenePartyScreen.cs.md#symbol-e7d1a77e170a)；[`NationalSpire.CharacterDesignPackage.Write(NationalSpire.CareerData, NationalSpire.CareerPerson, NationalSpire.PlayerAvatar, string, NationalSpire.PortraitDesign?, NationalSpire.DateSceneAssets?)`](CharacterDesignPackage.cs.md#symbol-a0889fe0f5f4)；[`NationalSpire.DateSceneAssetStore.HasImportedSprites(NationalSpire.CareerData, string)`](DateSceneAssets.cs.md#symbol-364c6958d307)；[`NationalSpire.DateSceneAssetStore.Pixels(string, bool)`](DateSceneAssets.cs.md#symbol-b176dfac69ce)；[`NationalSpire.DateSceneAssetStore.Store(byte[], string)`](DateSceneAssets.cs.md#symbol-a774cf2421cf)；[`NationalSpire.DateSceneBackgrounds.Read(out string, string?)`](DateSceneBackgrounds.cs.md#symbol-b6c3bc7d87d9)；[`NationalSpire.DateSceneBackgrounds.ResolveImage(string)`](DateSceneBackgrounds.cs.md#symbol-05e1fa49f816)

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

来源：源码第 99 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AppearanceLibrary.Save(string, NationalSpire.CharacterDesignPackage.Imported, string?)`](AppearanceLibrary.cs.md#symbol-c4c0756e8854)；[`NationalSpire.CareerScreen.RememberDateImage(Godot.Texture2D)`](DateSceneMemoryScreen.cs.md#symbol-5fae395fe1f4)；[`NationalSpire.CharacterDesignPackage.Installation.PackageAssets(NationalSpire.CharacterDesignPackage.Imported)`](CharacterDesignPackage.cs.md#symbol-5f1bf4d63999)；[`NationalSpire.DateSceneAssetStore.ImportBackgroundBytes(byte[], string)`](DateSceneAssets.cs.md#symbol-d04a3543dc27)；[`NationalSpire.DateSceneAssetStore.ImportOne(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string, string, bool)`](DateSceneAssets.cs.md#symbol-d165300a808a)；[`NationalSpire.DateSceneAssetStore.StoreSprite(byte[])`](DateSceneAssets.cs.md#symbol-d6c8bc9f985e)；[`NationalSpire.PortraitPackageImport.Merge(NationalSpire.PortraitPackageImport.Plan, NationalSpire.PortraitDesign, NationalSpire.DateSceneAssets, System.Collections.Generic.ISet<string>)`](PortraitPackageImport.cs.md#symbol-63ab2a20968e)

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

来源：源码第 106 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Add(string)`](PortraitPackageImport.cs.md#symbol-df572b3fedc4)；[`NationalSpire.CharacterDesignPackage.Read(NationalSpire.CareerData, System.IO.Stream, bool)`](CharacterDesignPackage.cs.md#symbol-abec8cae7c17)；[`NationalSpire.CharacterDesignPackage.Write(NationalSpire.CareerData, NationalSpire.CareerPerson, NationalSpire.PlayerAvatar, string, NationalSpire.PortraitDesign?, NationalSpire.DateSceneAssets?)`](CharacterDesignPackage.cs.md#symbol-a0889fe0f5f4)；[`NationalSpire.DateSceneAssetStore.ImportOne(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string, string, bool)`](DateSceneAssets.cs.md#symbol-d165300a808a)；[`NationalSpire.DateSceneAssetStore.Pixels(string, bool)`](DateSceneAssets.cs.md#symbol-b176dfac69ce)；[`NationalSpire.DateSceneAssetStore.ReadBackgroundImage(byte[], string)`](DateSceneAssets.cs.md#symbol-e78822490246)；[`NationalSpire.DateSceneAssetStore.StoreSprite(byte[])`](DateSceneAssets.cs.md#symbol-d6c8bc9f985e)

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

来源：源码第 123 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Draw()`](DateSceneAssetScreen.cs.md#symbol-44fc11efbaa6)

**调用：** [`NationalSpire.DateSceneAssetStore.EmotionForSprite(NationalSpire.PortraitDesign, string)`](DateSceneAssets.cs.md#symbol-5b7cd1e95015)；[`NationalSpire.DateSceneAssetStore.Hash(byte[])`](DateSceneAssets.cs.md#symbol-e8871d339d39)；[`NationalSpire.DateSceneAssetStore.ReadImage(byte[], bool)`](DateSceneAssets.cs.md#symbol-5cd819ad6952)；[`NationalSpire.DateSceneAssetStore.Store(byte[], string)`](DateSceneAssets.cs.md#symbol-a774cf2421cf)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.IO.File.ReadAllBytes(string)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.IO.Path.GetFileNameWithoutExtension(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneAssetStore.EmotionForSprite(NationalSpire.PortraitDesign, string)`；`NationalSpire.DateSceneAssetStore.Hash(byte[])`；`NationalSpire.DateSceneAssetStore.ReadImage(byte[], bool)`；`NationalSpire.DateSceneAssetStore.Store(byte[], string)`；`NationalSpire.DateSceneAssets.OutfitId`；`NationalSpire.DateSceneAssets.Sprites`；`NationalSpire.DateSceneAssets.UseDefaultPortrait`；`NationalSpire.PortraitDesign.Emotions`；`NationalSpire.PortraitDesign.SelectedOutfit`；`NationalSpire.PortraitEmotion.Enabled`；`NationalSpire.PortraitEmotion.Id`

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
- `assets.UseDefaultPortrait` = `false`
- `id` = `emotion + "_" + index++`
- `id` = `filename`

<a id="symbol-d6c8bc9f985e"></a>

## `NationalSpire.DateSceneAssetStore.StoreSprite(byte[]) — public static string StoreSprite(byte[] bytes)`

来源：源码第 137 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

来源：源码第 141 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

来源：源码第 161 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.PortraitPackageImport.Merge(NationalSpire.PortraitPackageImport.Plan, NationalSpire.PortraitDesign, NationalSpire.DateSceneAssets, System.Collections.Generic.ISet<string>)`](PortraitPackageImport.cs.md#symbol-63ab2a20968e)；[`NationalSpire.PortraitPackageImport.Plan.Unknown(NationalSpire.PortraitDesign)`](PortraitPackageImport.cs.md#symbol-c60dfaaef123)；[`NationalSpire.PortraitPackageImport.Read(NationalSpire.CareerData?, string, NationalSpire.PortraitDesign)`](PortraitPackageImport.cs.md#symbol-f3684b8edd44)；`System.Collections.Generic.HashSet<T>.HashSet()`；`System.IO.InvalidDataException.InvalidDataException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneAssets.OutfitId`；`NationalSpire.DateSceneAssets.Outfits`；`NationalSpire.PortraitPackageImport.Merge(NationalSpire.PortraitPackageImport.Plan, NationalSpire.PortraitDesign, NationalSpire.DateSceneAssets, System.Collections.Generic.ISet<string>)`；`NationalSpire.PortraitPackageImport.Plan.Unknown(NationalSpire.PortraitDesign)`；`NationalSpire.PortraitPackageImport.Read(NationalSpire.CareerData?, string, NationalSpire.PortraitDesign)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PortraitPackageImport.Merge(NationalSpire.PortraitPackageImport.Plan, NationalSpire.PortraitDesign, NationalSpire.DateSceneAssets, System.Collections.Generic.ISet<string>)`；输入表达式：`PortraitPackageImport.Merge(plan, design, assets, new HashSet<string>())`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PortraitPackageImport.Merge(plan, design, assets, new HashSet<string>())`
- `NationalSpire.PortraitPackageImport.Plan.Unknown(NationalSpire.PortraitDesign)`；输入表达式：`plan.Unknown(design)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: plan.Unknown(design).Length`
- `NationalSpire.PortraitPackageImport.Read(NationalSpire.CareerData?, string, NationalSpire.PortraitDesign)`；输入表达式：`PortraitPackageImport.Read(null, path, design)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PortraitPackageImport.Read(null, path, design)`
- `System.Collections.Generic.HashSet<T>.HashSet()`；输入表达式：`new HashSet<string>()`；返回值紧邻使用处：`ArgumentSyntax: new HashSet<string>()`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("请在导入窗口确认新情绪差分后导入。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("请在导入窗口确认新情绪差分后导入。");`

**赋值（含属性/字段和局部值）：**

- `assets.OutfitId` = `merged.Assets.OutfitId`
- `assets.Outfits` = `merged.Assets.Outfits`

<a id="symbol-255ccc15c761"></a>

## `NationalSpire.DateSceneAssetStore.ImportBackground(string) — public static string ImportBackground(string path)`

来源：源码第 168 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

来源：源码第 173 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

来源：源码第 180 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

来源：源码第 190 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

来源：源码第 195 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PartyTexture(string, string)`](DateScenePartyScreen.cs.md#symbol-53bfcf8e2a43)；[`NationalSpire.CareerScreen.PartyWaitingTextures(string)`](DateScenePartyScreen.cs.md#symbol-44daf22689a3)；[`NationalSpire.DateMemoryPlayback.Texture(string)`](DateSceneMemoryPlayback.cs.md#symbol-29553f3d3337)；[`NationalSpire.DateSceneAssetStore.Ready(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign?)`](DateSceneAssets.cs.md#symbol-79425fed4748)；[`NationalSpire.DateSceneBackgrounds.RegisterLegacy(string)`](DateSceneBackgrounds.cs.md#symbol-7feab11c4c5b)；[`NationalSpire.DateSceneTesting.Initialize(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>)`](DateSceneTesting.cs.md#symbol-91667df79532)；[`Select(int)`](AppearanceLibraryScreen.cs.md#symbol-76eb3d9afaf1)；[`Select(int)`](DatePresentationScreen.cs.md#symbol-dbcf354665de)

**调用：** [`NationalSpire.DateSceneAssetStore.Pixels(string, bool)`](DateSceneAssets.cs.md#symbol-b176dfac69ce)；`Godot.ImageTexture.CreateFromImage(Godot.Image)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneAssetStore.Pixels(string, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ImageTexture.CreateFromImage(Godot.Image)`；输入表达式：`ImageTexture.CreateFromImage(image)`；返回值紧邻使用处：`ReturnStatementSyntax: return ImageTexture.CreateFromImage(image);`
- `NationalSpire.DateSceneAssetStore.Pixels(string, bool)`；输入表达式：`Pixels(hash, sprite)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Pixels(hash, sprite)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-79425fed4748"></a>

## `NationalSpire.DateSceneAssetStore.Ready(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign?) — public static string? Ready(DateSceneAssets assets, PortraitDesign? design)`

来源：源码第 199 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenDateScene(string, bool, bool)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)；[`NationalSpire.DatePresentation.Initial(NationalSpire.CareerData, string, bool)`](DatePresentation.cs.md#symbol-8371585517ce)；[`NationalSpire.DatePresentation.Prepare(NationalSpire.CareerData, NationalSpire.DatePresentation.Selection)`](DatePresentation.cs.md#symbol-dba968a252db)；[`NationalSpire.DateSceneTesting.Initialize(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>)`](DateSceneTesting.cs.md#symbol-91667df79532)

**调用：** [`NationalSpire.DateSceneAssetStore.SpriteKeys(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string)`](DateSceneAssets.cs.md#symbol-3b48b221efd8)；[`NationalSpire.DateSceneAssetStore.Texture(string, bool)`](DateSceneAssets.cs.md#symbol-616d47ee9d6a)

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneAssets.OutfitId`；`NationalSpire.DateSceneAssets.Sprites`；`NationalSpire.DateSceneAssetStore.SpriteKeys(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string)`；`NationalSpire.DateSceneAssetStore.Texture(string, bool)`；`NationalSpire.PortraitDesign.DefaultEmotionId`；`NationalSpire.PortraitDesign.SelectedOutfit`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneAssetStore.SpriteKeys(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign, string)`；输入表达式：`SpriteKeys(assets, design, design.DefaultEmotionId)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string key in SpriteKeys(assets, design, design.DefaultEmotionId))              try { using var texture = Texture(assets.Sprites[key]); return null; } catch { }`
- `NationalSpire.DateSceneAssetStore.Texture(string, bool)`；输入表达式：`Texture(assets.Sprites[key])`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Texture(assets.Sprites[key])`

**赋值（含属性/字段和局部值）：**

- `assets.OutfitId` = `design.SelectedOutfit`
