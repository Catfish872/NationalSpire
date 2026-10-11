# GameCharacterNames.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`8E6475046FBC7DBDB2F9DD03F31C66A144CD8DE011EDB99866C8C2DD5C4D0547`。来源：[源码](../../GameCharacterNames.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.GameCharacterNames`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly object Gate = new();
private static string? _language;
private static IReadOnlyDictionary<string, string> _originals = new Dictionary<string, string>();
```

<a id="symbol-67e74be938f6"></a>

## `NationalSpire.GameCharacterNames.IsOriginal(System.Type) — public static bool IsOriginal(Type type)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameCharacterNames.Originals()`](GameCharacterNames.cs.md#symbol-1e5c21407883)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-1e5c21407883"></a>

## `NationalSpire.GameCharacterNames.Originals() — public static IReadOnlyDictionary<string, string> Originals()`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameCharacterNames.Originals()`](GameCharacterNames.cs.md#symbol-1e5c21407883)

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

来源：源码第 51 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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
