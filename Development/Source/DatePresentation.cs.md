# DatePresentation.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`7708B3536E0659E7C544916FD686E68AEEFA825068EA9343F78E2B3CA093AE5E`。来源：[源码](../../DatePresentation.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.DatePresentation`、`NationalSpire.DatePresentation.Source`、`NationalSpire.DatePresentation.Selection`。

字段、事件及初始值（源码原样）：

```csharp

```

<a id="symbol-e11de19c3625"></a>

## `NationalSpire.DatePresentation.Selection.Person — public string Person`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-1e2dbccd228d"></a>

## `NationalSpire.DatePresentation.Selection.Portrait — public Source Portrait`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8d7ce26d9330"></a>

## `NationalSpire.DatePresentation.Selection.Outfit — public string Outfit`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-912fea611ab1"></a>

## `NationalSpire.DatePresentation.Selection.Library — public AppearanceLibrary.Entry? Library`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-5c1c7037cb23"></a>

## `NationalSpire.DatePresentation.Selection.Voice — public string Voice`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9855f582740d"></a>

## `NationalSpire.DatePresentation.Pending(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>) — public static string[] Pending(CareerData data, IEnumerable<string> people)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConfigureDatePresentation(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>, System.Action, System.Action, bool)`](DatePresentationScreen.cs.md#symbol-ae7a16c86641)

**调用：** [`NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`](DateSceneAssets.cs.md#symbol-57fe620f4cc9)；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`；`NationalSpire.DateSceneAssets.PresentationConfirmed`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`；输入表达式：`DateSceneAssetStore.Read(data, p)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateSceneAssetStore.Read(data, p).PresentationConfirmed`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`people.Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: people.Distinct().Where`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`people.Distinct().Where(p => !DateSceneAssetStore.Read(data, p).PresentationConfirmed).ToArray()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => people.Distinct().Where(p => !DateSceneAssetStore.Read(data, p).PresentationConfirmed).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`people.Distinct().Where(p => !DateSceneAssetStore.Read(data, p).PresentationConfirmed)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: people.Distinct().Where(p => !DateSceneAssetStore.Read(data, p).PresentationConfirmed).ToArray`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8371585517ce"></a>

## `NationalSpire.DatePresentation.Initial(NationalSpire.CareerData, string, bool) — public static Selection Initial(CareerData data, string person, bool first)`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConfigureDatePresentation(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>, System.Action, System.Action, bool)`](DatePresentationScreen.cs.md#symbol-ae7a16c86641)

**调用：** [`NationalSpire.DateGameVoices.Default(NationalSpire.CareerData, string)`](DateGameVoices.cs.md#symbol-b457de19f0a7)；`NationalSpire.DatePresentation.Selection.Selection()`；[`NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`](DateSceneAssets.cs.md#symbol-57fe620f4cc9)；[`NationalSpire.DateSceneAssetStore.Ready(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign?)`](DateSceneAssets.cs.md#symbol-79425fed4748)；[`NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`](PortraitDesignStore.cs.md#symbol-8db102d73ed8)；[`NationalSpire.PortraitDesignStore.Read(string, string)`](PortraitDesignStore.cs.md#symbol-2eeba99f517d)；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateGameVoices.Default(NationalSpire.CareerData, string)`；`NationalSpire.DateGameVoices.Ids`；`NationalSpire.DatePresentation.Selection.Outfit`；`NationalSpire.DatePresentation.Selection.Person`；`NationalSpire.DatePresentation.Selection.Portrait`；`NationalSpire.DatePresentation.Selection.Voice`；`NationalSpire.DatePresentation.Source.Current`；`NationalSpire.DatePresentation.Source.Default`；`NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`；`NationalSpire.DateSceneAssetStore.Ready(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign?)`；`NationalSpire.DateSceneAssets.GameVoice`；`NationalSpire.DateSceneAssets.UseDefaultPortrait`；`NationalSpire.PortraitDesign.Outfits`；`NationalSpire.PortraitDesign.SelectedOutfit`；`NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`；`NationalSpire.PortraitDesignStore.Read(string, string)`；`NationalSpire.PortraitOutfit.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGameVoices.Default(NationalSpire.CareerData, string)`；输入表达式：`DateGameVoices.Default(data, person)`；返回值紧邻使用处：`ConditionalExpressionSyntax: first || !DateGameVoices.Ids.Contains(assets.GameVoice) ? DateGameVoices.Default(data, person) : assets.GameVoice`
- `NationalSpire.DatePresentation.Selection.Selection()`；输入表达式：`new() { Person = person, Portrait = outfit.Length > 0 ? Source.Current : Source.Default, Outfit = outfit, Voice = first || !DateGameVoices.Ids.Contains(assets.GameVoice) ? DateGameVoices.Default(data, person) : assets.GameVoice }`；返回值紧邻使用处：`ReturnStatementSyntax: return new() { Person = person, Portrait = outfit.Length > 0 ? Source.Current : Source.Default, Outfit = outfit, Voice = first || !DateGameVoices.Ids.Contains(assets.GameVoice) ? DateGameVoices.Default(data, person) : assets.GameVoice };`
- `NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`；输入表达式：`DateSceneAssetStore.Read(data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateSceneAssetStore.Read(data, person)`
- `NationalSpire.DateSceneAssetStore.Ready(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign?)`；输入表达式：`DateSceneAssetStore.Ready(assets, design)`；返回值紧邻使用处：`BinaryExpressionSyntax: DateSceneAssetStore.Ready(assets, design) == null`
- `NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`；输入表达式：`PortraitDesignStore.FilePath(data, person)`；返回值紧邻使用处：`ArgumentSyntax: PortraitDesignStore.FilePath(data, person)`
- `NationalSpire.PortraitDesignStore.Read(string, string)`；输入表达式：`PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person)`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`DateGameVoices.Ids.Contains(assets.GameVoice)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !DateGameVoices.Ids.Contains(assets.GameVoice)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`design.Outfits.OrderByDescending(o => o.Id == selected)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var candidate in design.Outfits.OrderByDescending(o => o.Id == selected)) { design.SelectedOutfit = candidate.Id; if (DateSceneAssetStore.Ready(assets, design) == null) { outfit = candidate.Id; break; } }`

**赋值（含属性/字段和局部值）：**

- `Outfit` = `outfit`
- `Person` = `person`
- `Portrait` = `outfit.Length > 0 ? Source.Current : Source.Default`
- `Voice` = `first || !DateGameVoices.Ids.Contains(assets.GameVoice) ? DateGameVoices.Default(data, person) : assets.GameVoice`
- `design.SelectedOutfit` = `candidate.Id`
- `outfit` = `candidate.Id`

<a id="symbol-dba968a252db"></a>

## `NationalSpire.DatePresentation.Prepare(NationalSpire.CareerData, NationalSpire.DatePresentation.Selection) — public static (PortraitDesign Design, DateSceneAssets Assets) Prepare(CareerData data, Selection selection)`

来源：源码第 31 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DatePresentation.Save(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<NationalSpire.DatePresentation.Selection>)`](DatePresentation.cs.md#symbol-6b2ede6c9f6f)；[`Select(int)`](DatePresentationScreen.cs.md#symbol-dbcf354665de)

**调用：** [`NationalSpire.AppearanceLibrary.Load(NationalSpire.CareerData, NationalSpire.AppearanceLibrary.Entry)`](AppearanceLibrary.cs.md#symbol-310593b772c6)；[`NationalSpire.AppearanceLibrary.Prepare(NationalSpire.CareerData, string, NationalSpire.AppearanceLibrary.Package)`](AppearanceLibrary.cs.md#symbol-bca14526873f)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`](DateSceneAssets.cs.md#symbol-57fe620f4cc9)；[`NationalSpire.DateSceneAssetStore.Ready(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign?)`](DateSceneAssets.cs.md#symbol-79425fed4748)；[`NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`](PortraitDesignStore.cs.md#symbol-8db102d73ed8)；[`NationalSpire.PortraitDesignStore.Read(string, string)`](PortraitDesignStore.cs.md#symbol-2eeba99f517d)；[`NationalSpire.PortraitDesigns.Create(NationalSpire.CareerData, string, NationalSpire.CareerPerson?)`](PortraitDesign.cs.md#symbol-8afe4d7864a5)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.IO.InvalidDataException.InvalidDataException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.AppearanceLibrary.Load(NationalSpire.CareerData, NationalSpire.AppearanceLibrary.Entry)`；`NationalSpire.AppearanceLibrary.Prepare(NationalSpire.CareerData, string, NationalSpire.AppearanceLibrary.Package)`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.DateGameVoices.Ids`；`NationalSpire.DatePresentation.Selection.Library`；`NationalSpire.DatePresentation.Selection.Outfit`；`NationalSpire.DatePresentation.Selection.Person`；`NationalSpire.DatePresentation.Selection.Portrait`；`NationalSpire.DatePresentation.Selection.Voice`；`NationalSpire.DatePresentation.Source.Current`；`NationalSpire.DatePresentation.Source.Default`；`NationalSpire.DatePresentation.Source.Library`；`NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`；`NationalSpire.DateSceneAssetStore.Ready(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign?)`；`NationalSpire.DateSceneAssets.GameVoice`；`NationalSpire.DateSceneAssets.OutfitId`；`NationalSpire.DateSceneAssets.PresentationConfirmed`；`NationalSpire.DateSceneAssets.UseDefaultPortrait`；`NationalSpire.PortraitDesign.Outfits`；`NationalSpire.PortraitDesign.SelectedOutfit`；`NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`；`NationalSpire.PortraitDesignStore.Read(string, string)`；`NationalSpire.PortraitDesigns.Create(NationalSpire.CareerData, string, NationalSpire.CareerPerson?)`；`NationalSpire.PortraitOutfit.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AppearanceLibrary.Load(NationalSpire.CareerData, NationalSpire.AppearanceLibrary.Entry)`；输入表达式：`AppearanceLibrary.Load(data, selection.Library)`；返回值紧邻使用处：`ArgumentSyntax: AppearanceLibrary.Load(data, selection.Library)`
- `NationalSpire.AppearanceLibrary.Prepare(NationalSpire.CareerData, string, NationalSpire.AppearanceLibrary.Package)`；输入表达式：`AppearanceLibrary.Prepare(data, selection.Person, AppearanceLibrary.Load(data, selection.Library))`；返回值紧邻使用处：`AssignmentExpressionSyntax: (design, assets) = AppearanceLibrary.Prepare(data, selection.Person, AppearanceLibrary.Load(data, selection.Library))`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, selection.Person)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.DisplayName(data, selection.Person) + "的所选套装缺少可用默认立绘，请选择其他立绘。"`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, selection.Person)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.Person(data, selection.Person) == null`
- `NationalSpire.DateSceneAssetStore.Read(NationalSpire.CareerData, string)`；输入表达式：`DateSceneAssetStore.Read(data, selection.Person)`；返回值紧邻使用处：`AssignmentExpressionSyntax: assets = DateSceneAssetStore.Read(data, selection.Person)`
- `NationalSpire.DateSceneAssetStore.Ready(NationalSpire.DateSceneAssets, NationalSpire.PortraitDesign?)`；输入表达式：`DateSceneAssetStore.Ready(assets, design)`；返回值紧邻使用处：`BinaryExpressionSyntax: DateSceneAssetStore.Ready(assets, design) != null`
- `NationalSpire.PortraitDesignStore.FilePath(NationalSpire.CareerData, string)`；输入表达式：`PortraitDesignStore.FilePath(data, selection.Person)`；返回值紧邻使用处：`ArgumentSyntax: PortraitDesignStore.FilePath(data, selection.Person)`
- `NationalSpire.PortraitDesignStore.Read(string, string)`；输入表达式：`PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, selection.Person), selection.Person)`；返回值紧邻使用处：`BinaryExpressionSyntax: PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, selection.Person), selection.Person) ?? PortraitDesigns.Create(data, selection.Person)`
- `NationalSpire.PortraitDesigns.Create(NationalSpire.CareerData, string, NationalSpire.CareerPerson?)`；输入表达式：`PortraitDesigns.Create(data, selection.Person)`；返回值紧邻使用处：`BinaryExpressionSyntax: PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, selection.Person), selection.Person) ?? PortraitDesigns.Create(data, selection.Person)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`design.Outfits.Any(o => o.Id == design.SelectedOutfit)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !design.Outfits.Any(o => o.Id == design.SelectedOutfit)`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`DateGameVoices.Ids.Contains(selection.Voice)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !DateGameVoices.Ids.Contains(selection.Voice)`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("角色或播报口吻已失效，请重新选择。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("角色或播报口吻已失效，请重新选择。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("请选择形象包。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("请选择形象包。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException(CareerEngine.DisplayName(data, selection.Person) + "的所选套装缺少可用默认立绘，请选择其他立绘。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException(CareerEngine.DisplayName(data, selection.Person) + "的所选套装缺少可用默认立绘，请选择其他立绘。");`

**赋值（含属性/字段和局部值）：**

- `(design, assets)` = `AppearanceLibrary.Prepare(data, selection.Person, AppearanceLibrary.Load(data, selection.Library))`
- `assets.GameVoice` = `selection.Voice`
- `assets.OutfitId` = `design.SelectedOutfit`
- `assets.PresentationConfirmed` = `true`
- `assets.UseDefaultPortrait` = `selection.Portrait == Source.Default`
- `assets` = `DateSceneAssetStore.Read(data, selection.Person)`
- `design.SelectedOutfit` = `selection.Outfit`
- `design` = `PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, selection.Person), selection.Person) ?? PortraitDesigns.Create(data, selection.Person)`

<a id="symbol-6b2ede6c9f6f"></a>

## `NationalSpire.DatePresentation.Save(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<NationalSpire.DatePresentation.Selection>) — public static void Save(CareerData data, IReadOnlyList<Selection> selections)`

来源：源码第 53 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConfigureDatePresentation(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>, System.Action, System.Action, bool)`](DatePresentationScreen.cs.md#symbol-ae7a16c86641)

**调用：** [`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`](CareerStore.cs.md#symbol-ead7461ee7cb)；[`NationalSpire.CharacterDesignPackage.Installation.Commit()`](CharacterDesignPackage.cs.md#symbol-6147750def14)；[`NationalSpire.CharacterDesignPackage.Installation.Dispose()`](CharacterDesignPackage.cs.md#symbol-9c5c348e084c)；[`NationalSpire.CharacterDesignPackage.Installation.Installation(NationalSpire.CareerData, string, NationalSpire.PortraitDesign, NationalSpire.DateSceneAssets)`](CharacterDesignPackage.cs.md#symbol-27a8ea8feef4)；[`NationalSpire.DatePresentation.Prepare(NationalSpire.CareerData, NationalSpire.DatePresentation.Selection)`](DatePresentation.cs.md#symbol-dba968a252db)；`System.Collections.Generic.IEnumerable<TSource>.AsEnumerable<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.InvalidOperationException.InvalidOperationException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；`NationalSpire.CharacterDesignPackage.Installation.Commit()`；`NationalSpire.CharacterDesignPackage.Installation.Dispose()`；`NationalSpire.DatePresentation.Prepare(NationalSpire.CareerData, NationalSpire.DatePresentation.Selection)`；`NationalSpire.DatePresentation.Selection.Person`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；输入表达式：`CareerStore.IsCurrent(data)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CareerStore.IsCurrent(data)`
- `NationalSpire.CharacterDesignPackage.Installation.Commit()`；输入表达式：`install.Commit()`；返回值紧邻使用处：`ExpressionStatementSyntax: install.Commit();`
- `NationalSpire.CharacterDesignPackage.Installation.Dispose()`；输入表达式：`install.Dispose()`；返回值紧邻使用处：`ExpressionStatementSyntax: install.Dispose();`
- `NationalSpire.CharacterDesignPackage.Installation.Installation(NationalSpire.CareerData, string, NationalSpire.PortraitDesign, NationalSpire.DateSceneAssets)`；输入表达式：`new(data, item.Person, item.Value.Design, item.Value.Assets)`；返回值紧邻使用处：`ArgumentSyntax: new(data, item.Person, item.Value.Design, item.Value.Assets)`
- `NationalSpire.DatePresentation.Prepare(NationalSpire.CareerData, NationalSpire.DatePresentation.Selection)`；输入表达式：`Prepare(data, s)`；返回值紧邻使用处：`ArgumentSyntax: Value: Prepare(data, s)`
- `System.Collections.Generic.IEnumerable<TSource>.AsEnumerable<TSource>()`；输入表达式：`installations.AsEnumerable()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: installations.AsEnumerable().Reverse`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`selections.Select(s => s.Person).Distinct().Count()`；返回值紧邻使用处：`BinaryExpressionSyntax: selections.Select(s => s.Person).Distinct().Count() != selections.Count`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`selections.Select(s => s.Person).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: selections.Select(s => s.Person).Distinct().Count`
- `System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；输入表达式：`installations.AsEnumerable().Reverse()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var install in installations.AsEnumerable().Reverse()) install.Dispose();`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`selections.Select(s => (s.Person, Value: Prepare(data, s)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: selections.Select(s => (s.Person, Value: Prepare(data, s))).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`selections.Select(s => s.Person)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: selections.Select(s => s.Person).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`selections.Select(s => (s.Person, Value: Prepare(data, s))).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = selections.Select(s => (s.Person, Value: Prepare(data, s))).ToArray()`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`installations.Add(new(data, item.Person, item.Value.Design, item.Value.Assets))`；返回值紧邻使用处：`ExpressionStatementSyntax: installations.Add(new(data, item.Person, item.Value.Design, item.Value.Assets));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<CharacterDesignPackage.Installation>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<CharacterDesignPackage.Installation>()`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("角色选择重复。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("角色选择重复。");`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("生涯已切换，请重新打开约会。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("生涯已切换，请重新打开约会。");`

**赋值（含属性/字段和局部值）：**
