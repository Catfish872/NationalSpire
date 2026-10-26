# GameCharacterNames.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`1ED87538A03E187A341D158CB85C300E580483B7502FD7330F813ADF5E03C0C7`。来源：[源码](../../GameCharacterNames.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.GameCharacterNames`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly object Gate = new();
private static string? _language;
private static IReadOnlyDictionary<string, string> _originals = new Dictionary<string, string>();
private static string? _healthLanguage;
private static IReadOnlyDictionary<string, int> _startingHp = new Dictionary<string, int>();
```

<a id="symbol-1bb238743407"></a>

## `NationalSpire.GameCharacterNames.StartingHp(string) — public static int StartingHp(string character)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopLive.Update()`](Coop/CoopLive.cs.md#symbol-fe745d15ee63)；[`NationalSpire.LiveRunBridge.EnsurePlan(ref bool)`](LiveRunBridge.cs.md#symbol-0dd1ac28e6cd)；[`NationalSpire.LiveRunBridge.UpdateDateGame(NationalSpire.LiveMatchState, NationalSpire.RivalProgress, double, ref bool)`](LiveDateGame.cs.md#symbol-cb87a418530f)

**调用：** [`NationalSpire.GameBridge.Characters()`](GameBridge.cs.md#symbol-1233494dda40)；[`NationalSpire.GameCharacterNames.Read(string)`](GameCharacterNames.cs.md#symbol-cf770f36edc2)；`MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IEqualityComparer<TKey>?)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>, System.Collections.Generic.IEqualityComparer<TKey>?)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`

**字段、属性、事件及方法组引用：** `(string Name, int Hp).Hp`；`(string Name, int Hp).Name`；`NationalSpire.GameBridge.Characters()`；`NationalSpire.GameCharacterNames._healthLanguage`；`NationalSpire.GameCharacterNames._startingHp`；`NationalSpire.GameCharacterNames.Gate`；`NationalSpire.GameCharacterNames.Read(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；输入表达式：`model.Title.GetFormattedText()`；返回值紧邻使用处：`InitializerExpressionSyntax: { model.Id.ToString(), model.Id.Entry, model.Title.GetFormattedText(),                         chinese.GetValueOrDefault(key, ""), english.GetValueOrDefault(key, "") }`
- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`model.Id.ToString()`；返回值紧邻使用处：`InitializerExpressionSyntax: { model.Id.ToString(), model.Id.Entry, model.Title.GetFormattedText(),                         chinese.GetValueOrDefault(key, ""), english.GetValueOrDefault(key, "") }`
- `NationalSpire.GameBridge.Characters()`；输入表达式：`GameBridge.Characters()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var model in GameBridge.Characters())                 {                     string key = model.Id.Entry + ".title";                     foreach (string name in new[] { model.Id.ToString(), model.Id.Entry, model.Title.GetFormattedText(),                         chinese.GetValueOrDefault(key, ""), english.GetValueOrDefault(key, "") })                         if (name.Length > 0) names.Add((name, model.StartingHp));                 }`
- `NationalSpire.GameCharacterNames.Read(string)`；输入表达式：`Read("eng")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Read("eng")`
- `NationalSpire.GameCharacterNames.Read(string)`；输入表达式：`Read("zhs")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Read("zhs")`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`g.Select(n => n.Hp).Distinct().Count()`；返回值紧邻使用处：`BinaryExpressionSyntax: g.Select(n => n.Hp).Distinct().Count() == 1`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`g.Select(n => n.Hp).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Select(n => n.Hp).Distinct().Count`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；输入表达式：`g.First()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.First().Hp`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IEqualityComparer<TKey>?)`；输入表达式：`names.GroupBy(n => n.Name, StringComparer.OrdinalIgnoreCase)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: names.GroupBy(n => n.Name, StringComparer.OrdinalIgnoreCase)                     .Where`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`g.Select(n => n.Hp)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Select(n => n.Hp).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>, System.Collections.Generic.IEqualityComparer<TKey>?)`；输入表达式：`names.GroupBy(n => n.Name, StringComparer.OrdinalIgnoreCase)                     .Where(g => g.Select(n => n.Hp).Distinct().Count() == 1)                     .ToDictionary(g => g.Key, g => g.First().Hp, StringComparer.OrdinalIgnoreCase)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _startingHp = names.GroupBy(n => n.Name, StringComparer.OrdinalIgnoreCase)                     .Where(g => g.Select(n => n.Hp).Distinct().Count() == 1)                     .ToDictionary(g => g.Key, g => g.First().Hp, StringComparer.OrdinalIgnoreCase)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`names.GroupBy(n => n.Name, StringComparer.OrdinalIgnoreCase)                     .Where(g => g.Select(n => n.Hp).Distinct().Count() == 1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: names.GroupBy(n => n.Name, StringComparer.OrdinalIgnoreCase)                     .Where(g => g.Select(n => n.Hp).Distinct().Count() == 1)                     .ToDictionary`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`_startingHp.GetValueOrDefault(character, 75)`；返回值紧邻使用处：`ReturnStatementSyntax: return _startingHp.GetValueOrDefault(character, 75);`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`chinese.GetValueOrDefault(key, "")`；返回值紧邻使用处：`InitializerExpressionSyntax: { model.Id.ToString(), model.Id.Entry, model.Title.GetFormattedText(),                         chinese.GetValueOrDefault(key, ""), english.GetValueOrDefault(key, "") }`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`english.GetValueOrDefault(key, "")`；返回值紧邻使用处：`InitializerExpressionSyntax: { model.Id.ToString(), model.Id.Entry, model.Title.GetFormattedText(),                         chinese.GetValueOrDefault(key, ""), english.GetValueOrDefault(key, "") }`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`names.Add((name, model.StartingHp))`；返回值紧邻使用处：`ExpressionStatementSyntax: names.Add((name, model.StartingHp));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<(string Name, int Hp)>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<(string Name, int Hp)>()`

**赋值（含属性/字段和局部值）：**

- `_healthLanguage` = `language`
- `_startingHp` = `names.GroupBy(n => n.Name, StringComparer.OrdinalIgnoreCase)                     .Where(g => g.Select(n => n.Hp).Distinct().Count() == 1)                     .ToDictionary(g => g.Key, g => g.First().Hp, StringComparer.OrdinalIgnoreCase)`

<a id="symbol-67e74be938f6"></a>

## `NationalSpire.GameCharacterNames.IsOriginal(System.Type) — public static bool IsOriginal(Type type)`

来源：源码第 41 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameCharacterNames.Originals()`](GameCharacterNames.cs.md#symbol-1e5c21407883)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-1e5c21407883"></a>

## `NationalSpire.GameCharacterNames.Originals() — public static IReadOnlyDictionary<string, string> Originals()`

来源：源码第 42 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.GameCharacterNames.IsOriginal(System.Type)`](GameCharacterNames.cs.md#symbol-67e74be938f6)；[`NationalSpire.GameCharacterNames.Read(string)`](GameCharacterNames.cs.md#symbol-cf770f36edc2)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；`MegaCrit.Sts2.Core.Models.ModelDb.GetByIdOrNull<T>(MegaCrit.Sts2.Core.Models.ModelId)`；`MegaCrit.Sts2.Core.Models.ModelDb.GetId(System.Type)`；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`object.GetType()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IEqualityComparer<TKey>?)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Reflection.Assembly.GetTypes()`；`System.Type.IsSubclassOf(System.Type)`

**字段、属性、事件及方法组引用：** `NationalSpire.GameCharacterNames._language`；`NationalSpire.GameCharacterNames._originals`；`NationalSpire.GameCharacterNames.Gate`；`NationalSpire.GameCharacterNames.IsOriginal(System.Type)`；`NationalSpire.GameCharacterNames.Read(string)`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.CharacterClassify`；`NationalSpire.UiPerformance.Work.CharacterPrepare`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Models.ModelDb.GetByIdOrNull<T>(MegaCrit.Sts2.Core.Models.ModelId)`；输入表达式：`ModelDb.GetByIdOrNull<CharacterModel>(id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ModelDb.GetByIdOrNull<CharacterModel>(id)`
- `MegaCrit.Sts2.Core.Models.ModelDb.GetId(System.Type)`；输入表达式：`ModelDb.GetId(type)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ModelDb.GetId(type)`
- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`id.ToString()`；返回值紧邻使用处：`ArgumentSyntax: id.ToString()`
- `NationalSpire.GameCharacterNames.IsOriginal(System.Type)`；输入表达式：`IsOriginal(registered.GetType())`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsOriginal(registered.GetType())`
- `NationalSpire.GameCharacterNames.Read(string)`；输入表达式：`Read("eng")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Read("eng")`
- `NationalSpire.GameCharacterNames.Read(string)`；输入表达式：`Read(language)`；返回值紧邻使用处：`ConditionalExpressionSyntax: language == "eng" ? english : Read(language)`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.CharacterClassify)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.CharacterClassify)`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.CharacterPrepare)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.CharacterPrepare)`
- `object.GetType()`；输入表达式：`registered.GetType()`；返回值紧邻使用处：`ArgumentSyntax: registered.GetType()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IEqualityComparer<TKey>?)`；输入表达式：`new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`typeof(CharacterModel).Assembly.GetTypes().Where(t => !t.IsAbstract && t.IsSubclassOf(typeof(CharacterModel)))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var type in typeof(CharacterModel).Assembly.GetTypes().Where(t => !t.IsAbstract && t.IsSubclassOf(typeof(CharacterModel))))             {                 var id = ModelDb.GetId(type);                 var registered = ModelDb.GetByIdOrNull<CharacterModel>(id);                 if (registered != null && !IsOriginal(registered.GetType())) continue;                 string key = id.Entry + ".title";                 string? name = localized.GetValueOrDefault(key) ?? english.GetValueOrDefault(key);                 if (name == null) continue;                 names[id.ToString()] = name; names[id.Entry] = name;             }`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`english.GetValueOrDefault(key)`；返回值紧邻使用处：`BinaryExpressionSyntax: localized.GetValueOrDefault(key) ?? english.GetValueOrDefault(key)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`localized.GetValueOrDefault(key)`；返回值紧邻使用处：`BinaryExpressionSyntax: localized.GetValueOrDefault(key) ?? english.GetValueOrDefault(key)`
- `System.Reflection.Assembly.GetTypes()`；输入表达式：`typeof(CharacterModel).Assembly.GetTypes()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: typeof(CharacterModel).Assembly.GetTypes().Where`
- `System.Type.IsSubclassOf(System.Type)`；输入表达式：`t.IsSubclassOf(typeof(CharacterModel))`；返回值紧邻使用处：`BinaryExpressionSyntax: !t.IsAbstract && t.IsSubclassOf(typeof(CharacterModel))`

**赋值（含属性/字段和局部值）：**

- `_language` = `language`
- `_originals` = `names`
- `names[id.Entry]` = `name`
- `names[id.ToString()]` = `name`

<a id="symbol-cf770f36edc2"></a>

## `NationalSpire.GameCharacterNames.Read(string) — private static Dictionary<string, string> Read(string language)`

来源：源码第 66 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameCharacterNames.Originals()`](GameCharacterNames.cs.md#symbol-1e5c21407883)；[`NationalSpire.GameCharacterNames.StartingHp(string)`](GameCharacterNames.cs.md#symbol-1bb238743407)

**调用：** [`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；`Godot.FileAccess.GetAsText(bool)`；`Godot.FileAccess.Open(string, Godot.FileAccess.ModeFlags)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.CharacterResourceParse`；`NationalSpire.UiPerformance.Work.CharacterResourceRead`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.FileAccess.GetAsText(bool)`；输入表达式：`file.GetAsText()`；返回值紧邻使用处：`AssignmentExpressionSyntax: text = file.GetAsText()`
- `Godot.FileAccess.Open(string, Godot.FileAccess.ModeFlags)`；输入表达式：`Godot.FileAccess.Open("res://localization/" + language + "/characters.json", Godot.FileAccess.ModeFlags.Read)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Godot.FileAccess.Open("res://localization/" + language + "/characters.json", Godot.FileAccess.ModeFlags.Read)`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.CharacterResourceParse)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.CharacterResourceParse)`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.CharacterResourceRead)`；返回值紧邻使用处：`UsingStatementSyntax: using (UiPerformance.Measure(UiPerformance.Work.CharacterResourceRead))         {             using var file = Godot.FileAccess.Open("res://localization/" + language + "/characters.json", Godot.FileAccess.ModeFlags.Read);             if (file == null) return new();             text = file.GetAsText();         }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new()`；返回值紧邻使用处：`ReturnStatementSyntax: return new();`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<Dictionary<string, string>>(text)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: JsonSerializer.Deserialize<Dictionary<string, string>>(text)!`

**赋值（含属性/字段和局部值）：**

- `text` = `file.GetAsText()`

<a id="symbol-2ba1db314dbc"></a>

## `NationalSpire.GameCharacterNames.Definitions(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CharacterModel>) — public static IEnumerable<CharacterDefinition> Definitions(IEnumerable<CharacterModel> characters)`

来源：源码第 78 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Entry.Init()`](Entry.cs.md#symbol-f4f7468c39e8)

**调用：** [`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；`MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`NationalSpire.CharacterDefinition.CharacterDefinition(string, string)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.CharacterDefinitions`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；输入表达式：`c.Title.GetFormattedText()`；返回值紧邻使用处：`ArgumentSyntax: c.Title.GetFormattedText()`
- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`c.Id.ToString()`；返回值紧邻使用处：`ArgumentSyntax: c.Id.ToString()`
- `NationalSpire.CharacterDefinition.CharacterDefinition(string, string)`；输入表达式：`new CharacterDefinition(c.Id.ToString(), c.Title.GetFormattedText())`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => new CharacterDefinition(c.Id.ToString(), c.Title.GetFormattedText())`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.CharacterDefinitions)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.CharacterDefinitions)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`characters.Select(c => new CharacterDefinition(c.Id.ToString(), c.Title.GetFormattedText()))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: characters.Select(c => new CharacterDefinition(c.Id.ToString(), c.Title.GetFormattedText())).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`characters.Select(c => new CharacterDefinition(c.Id.ToString(), c.Title.GetFormattedText())).ToArray()`；返回值紧邻使用处：`ReturnStatementSyntax: return characters.Select(c => new CharacterDefinition(c.Id.ToString(), c.Title.GetFormattedText())).ToArray();`

**赋值（含属性/字段和局部值）：**
