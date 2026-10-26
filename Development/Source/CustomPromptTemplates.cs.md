# CustomPromptTemplates.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`932D12695800EB8D31950F11E4824DDEC729F8048D583E8C58513601B2D29BDD`。来源：[源码](../../CustomPromptTemplates.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CustomPromptTemplate`、`NationalSpire.PromptLibrary`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-e716567ed318"></a>

## `NationalSpire.CustomPromptTemplate.Name — public string Name`

来源：源码第 5 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ebe9349bfbbc"></a>

## `NationalSpire.CustomPromptTemplate.BaseTemplate — public string BaseTemplate`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.PromptLibrary.DefaultTemplate`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ff0d52d25723"></a>

## `NationalSpire.CustomPromptTemplate.Sections — public Dictionary<string, string> Sections`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e767896f5ab7"></a>

## `NationalSpire.PromptLibrary.CanDeleteTemplate(NationalSpire.AiOptions, string) — public static bool CanDeleteTemplate(AiOptions options, string id)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenPromptSettings(NationalSpire.CareerData)`](PromptScreen.cs.md#symbol-fda1b116cf88)；[`NationalSpire.PromptLibrary.DeleteTemplate(NationalSpire.AiOptions, string)`](CustomPromptTemplates.cs.md#symbol-c0e48d11dac8)；[`Show()`](PromptScreen.cs.md#symbol-26218fc52477)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.CustomPromptTemplates`；`NationalSpire.PromptLibrary.Templates`；`NationalSpire.PromptTemplate.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`.ContainsKey(id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: options.CustomPromptTemplates?.ContainsKey(id)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`Templates.Any(t => t.Id == id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Templates.Any(t => t.Id == id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a50c03cf514e"></a>

## `NationalSpire.PromptLibrary.DeletionFallback(NationalSpire.AiOptions, string) — public static string DeletionFallback(AiOptions options, string id)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenPromptSettings(NationalSpire.CareerData)`](PromptScreen.cs.md#symbol-fda1b116cf88)；[`NationalSpire.PromptLibrary.DeleteTemplate(NationalSpire.AiOptions, string)`](CustomPromptTemplates.cs.md#symbol-c0e48d11dac8)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.CustomPromptTemplates`；`NationalSpire.CustomPromptTemplate.BaseTemplate`；`NationalSpire.PromptLibrary.DefaultTemplate`；`NationalSpire.PromptLibrary.Templates`；`NationalSpire.PromptTemplate.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`.TryGetValue(id, out var custom)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: options.CustomPromptTemplates?.TryGetValue(id, out var custom)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`Templates.Any(t => t.Id == custom.BaseTemplate)`；返回值紧邻使用处：`BinaryExpressionSyntax: options.CustomPromptTemplates?.TryGetValue(id, out var custom) == true && Templates.Any(t => t.Id == custom.BaseTemplate)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c0e48d11dac8"></a>

## `NationalSpire.PromptLibrary.DeleteTemplate(NationalSpire.AiOptions, string) — public static void DeleteTemplate(AiOptions options, string id)`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenPromptSettings(NationalSpire.CareerData)`](PromptScreen.cs.md#symbol-fda1b116cf88)

**调用：** [`NationalSpire.PromptLibrary.CanDeleteTemplate(NationalSpire.AiOptions, string)`](CustomPromptTemplates.cs.md#symbol-e767896f5ab7)；[`NationalSpire.PromptLibrary.DeletionFallback(NationalSpire.AiOptions, string)`](CustomPromptTemplates.cs.md#symbol-a50c03cf514e)；[`NationalSpire.PromptLibrary.SelectTemplate(NationalSpire.AiOptions, string)`](PromptTemplates.cs.md#symbol-50231e85e9e7)；[`NationalSpire.PromptLibrary.TemplateId(NationalSpire.AiOptions)`](PromptTemplates.cs.md#symbol-51c9e7869e6e)；`System.ArgumentException.ArgumentException(string?)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.CustomPromptTemplates`；`NationalSpire.AiOptions.EventPoolOverrides`；`NationalSpire.AiOptions.PromptTemplateOverrides`；`NationalSpire.PromptLibrary.CanDeleteTemplate(NationalSpire.AiOptions, string)`；`NationalSpire.PromptLibrary.DeletionFallback(NationalSpire.AiOptions, string)`；`NationalSpire.PromptLibrary.SelectTemplate(NationalSpire.AiOptions, string)`；`NationalSpire.PromptLibrary.TemplateId(NationalSpire.AiOptions)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PromptLibrary.CanDeleteTemplate(NationalSpire.AiOptions, string)`；输入表达式：`CanDeleteTemplate(options, id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CanDeleteTemplate(options, id)`
- `NationalSpire.PromptLibrary.DeletionFallback(NationalSpire.AiOptions, string)`；输入表达式：`DeletionFallback(options, id)`；返回值紧邻使用处：`ArgumentSyntax: DeletionFallback(options, id)`
- `NationalSpire.PromptLibrary.SelectTemplate(NationalSpire.AiOptions, string)`；输入表达式：`SelectTemplate(options, DeletionFallback(options, id))`；返回值紧邻使用处：`ExpressionStatementSyntax: SelectTemplate(options, DeletionFallback(options, id));`
- `NationalSpire.PromptLibrary.TemplateId(NationalSpire.AiOptions)`；输入表达式：`TemplateId(options)`；返回值紧邻使用处：`BinaryExpressionSyntax: TemplateId(options) == id`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("只能删除自建提示词模板。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("只能删除自建提示词模板。");`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`.Remove(id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: options.PromptTemplateOverrides?.Remove(id)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`options.CustomPromptTemplates.Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: options.CustomPromptTemplates.Remove(id);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`options.EventPoolOverrides.Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: options.EventPoolOverrides.Remove(id);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-034310e38b45"></a>

## `NationalSpire.PromptLibrary.AvailableTemplates(NationalSpire.AiOptions) — public static IReadOnlyList<PromptTemplate> AvailableTemplates(AiOptions options)`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConfirmPromptImport(NationalSpire.CareerData, string, System.Action)`](PromptScreen.cs.md#symbol-b9da8509093b)；[`NationalSpire.CareerScreen.OpenNpcGeneration(NationalSpire.AiOptions, System.Action<NationalSpire.NpcGenerationSetup>, bool, System.Func<NationalSpire.NpcGenerationSetup, System.Threading.Tasks.Task>?, int, bool)`](NpcGenerationScreen.cs.md#symbol-fa734ac20da4)；[`NationalSpire.CareerScreen.OpenPromptSettings(NationalSpire.CareerData)`](PromptScreen.cs.md#symbol-fda1b116cf88)；[`NationalSpire.PromptLibrary.CreateTemplate(NationalSpire.AiOptions, string, string)`](CustomPromptTemplates.cs.md#symbol-89804de92137)；[`NationalSpire.PromptLibrary.SelectTemplate(NationalSpire.AiOptions, string)`](PromptTemplates.cs.md#symbol-50231e85e9e7)；[`NationalSpire.PromptLibrary.Template(NationalSpire.AiOptions)`](PromptTemplates.cs.md#symbol-facad1ba9cab)；[`NationalSpire.PromptLibrary.TemplateId(NationalSpire.AiOptions)`](PromptTemplates.cs.md#symbol-51c9e7869e6e)；[`NationalSpire.PromptLibrary.ValidateTemplateName(NationalSpire.AiOptions, string, string?)`](CustomPromptTemplates.cs.md#symbol-e36cb8ec09d7)；[`NationalSpire.PromptTransfer.Apply(NationalSpire.AiOptions, NationalSpire.PromptTransfer.Bundle, string?)`](PromptTransfer.cs.md#symbol-3403e8b82dd8)；[`RefreshWorlds()`](NpcGenerationScreen.cs.md#symbol-a2752f80a146)；[`Show()`](PromptScreen.cs.md#symbol-26218fc52477)

**调用：** `NationalSpire.PromptTemplate.PromptTemplate(string, string, string)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.CustomPromptTemplates`；`NationalSpire.CustomPromptTemplate.Name`；`NationalSpire.PromptLibrary.Templates`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PromptTemplate.PromptTemplate(string, string, string)`；输入表达式：`new PromptTemplate(p.Key, p.Value.Name, "自建模板 · 内容独立保存")`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => new PromptTemplate(p.Key, p.Value.Name, "自建模板 · 内容独立保存")`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new()`；返回值紧邻使用处：`BinaryExpressionSyntax: options.CustomPromptTemplates ?? new()`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`Templates.Concat(         (options.CustomPromptTemplates ?? new()).Select(p => new PromptTemplate(p.Key, p.Value.Name, "自建模板 · 内容独立保存")))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Templates.Concat(         (options.CustomPromptTemplates ?? new()).Select(p => new PromptTemplate(p.Key, p.Value.Name, "自建模板 · 内容独立保存"))).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`(options.CustomPromptTemplates ?? new()).Select(p => new PromptTemplate(p.Key, p.Value.Name, "自建模板 · 内容独立保存"))`；返回值紧邻使用处：`ArgumentSyntax: (options.CustomPromptTemplates ?? new()).Select(p => new PromptTemplate(p.Key, p.Value.Name, "自建模板 · 内容独立保存"))`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Templates.Concat(         (options.CustomPromptTemplates ?? new()).Select(p => new PromptTemplate(p.Key, p.Value.Name, "自建模板 · 内容独立保存"))).ToArray()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Templates.Concat(         (options.CustomPromptTemplates ?? new()).Select(p => new PromptTemplate(p.Key, p.Value.Name, "自建模板 · 内容独立保存"))).ToArray()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e36cb8ec09d7"></a>

## `NationalSpire.PromptLibrary.ValidateTemplateName(NationalSpire.AiOptions, string, string?) — public static string ValidateTemplateName(AiOptions options, string name, string? exceptId = null)`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenPromptSettings(NationalSpire.CareerData)`](PromptScreen.cs.md#symbol-fda1b116cf88)；[`NationalSpire.PromptLibrary.CreateTemplate(NationalSpire.AiOptions, string, string)`](CustomPromptTemplates.cs.md#symbol-89804de92137)；[`NationalSpire.PromptTransfer.Validate(NationalSpire.PromptTransfer.Bundle)`](PromptTransfer.cs.md#symbol-c81f82a79264)

**调用：** [`NationalSpire.PromptLibrary.AvailableTemplates(NationalSpire.AiOptions)`](CustomPromptTemplates.cs.md#symbol-034310e38b45)；`string.Equals(string?, System.StringComparison)`；`string.Trim()`；`System.ArgumentException.ArgumentException(string?)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.PromptLibrary.AvailableTemplates(NationalSpire.AiOptions)`；`NationalSpire.PromptTemplate.Id`；`NationalSpire.PromptTemplate.Name`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PromptLibrary.AvailableTemplates(NationalSpire.AiOptions)`；输入表达式：`AvailableTemplates(options)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AvailableTemplates(options).Any`
- `string.Equals(string?, System.StringComparison)`；输入表达式：`t.Name.Equals(name, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: t.Id != exceptId && t.Name.Equals(name, StringComparison.OrdinalIgnoreCase)`
- `string.Trim()`；输入表达式：`name.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: name = name.Trim()`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("模板名称需要 1—40 个字符。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("模板名称需要 1—40 个字符。");`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("已有同名模板，请换一个名称。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("已有同名模板，请换一个名称。");`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`AvailableTemplates(options).Any(t => t.Id != exceptId && t.Name.Equals(name, StringComparison.OrdinalIgnoreCase))`；返回值紧邻使用处：`IfStatementSyntax: if (AvailableTemplates(options).Any(t => t.Id != exceptId && t.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))             throw new ArgumentException("已有同名模板，请换一个名称。");`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`name.Any(char.IsControl)`；返回值紧邻使用处：`BinaryExpressionSyntax: name.Length is < 1 or > 40 || name.Any(char.IsControl)`

**赋值（含属性/字段和局部值）：**

- `name` = `name.Trim()`

<a id="symbol-89804de92137"></a>

## `NationalSpire.PromptLibrary.CreateTemplate(NationalSpire.AiOptions, string, string) — public static string CreateTemplate(AiOptions options, string name, string baseId)`

来源：源码第 41 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenPromptSettings(NationalSpire.CareerData)`](PromptScreen.cs.md#symbol-fda1b116cf88)

**调用：** [`NationalSpire.EventPools.Overrides(NationalSpire.AiOptions, string?)`](EventPools.cs.md#symbol-bc809b41fa9c)；[`NationalSpire.EventPools.Save(NationalSpire.AiOptions, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<NationalSpire.EventPoolEntry>>, string?)`](EventPools.cs.md#symbol-a7331058425b)；[`NationalSpire.PromptLibrary.AvailableTemplates(NationalSpire.AiOptions)`](CustomPromptTemplates.cs.md#symbol-034310e38b45)；[`NationalSpire.PromptLibrary.Get(NationalSpire.AiOptions, string)`](PromptLibrary.cs.md#symbol-3f64d002bbbe)；[`NationalSpire.PromptLibrary.SelectTemplate(NationalSpire.AiOptions, string)`](PromptTemplates.cs.md#symbol-50231e85e9e7)；[`NationalSpire.PromptLibrary.TemplateId(NationalSpire.AiOptions)`](PromptTemplates.cs.md#symbol-51c9e7869e6e)；[`NationalSpire.PromptLibrary.ValidateTemplateName(NationalSpire.AiOptions, string, string?)`](CustomPromptTemplates.cs.md#symbol-e36cb8ec09d7)；`NationalSpire.AiOptions.AiOptions()`；`NationalSpire.CustomPromptTemplate.CustomPromptTemplate()`；`System.ArgumentException.ArgumentException(string?)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.CustomPromptTemplates`；`NationalSpire.AiOptions.PromptOverrides`；`NationalSpire.AiOptions.PromptTemplate`；`NationalSpire.AiOptions.PromptTemplateOverrides`；`NationalSpire.CustomPromptTemplate.BaseTemplate`；`NationalSpire.CustomPromptTemplate.Name`；`NationalSpire.CustomPromptTemplate.Sections`；`NationalSpire.EventPools.Overrides(NationalSpire.AiOptions, string?)`；`NationalSpire.EventPools.Save(NationalSpire.AiOptions, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<NationalSpire.EventPoolEntry>>, string?)`；`NationalSpire.PromptLibrary.AvailableTemplates(NationalSpire.AiOptions)`；`NationalSpire.PromptLibrary.Get(NationalSpire.AiOptions, string)`；`NationalSpire.PromptLibrary.Sections`；`NationalSpire.PromptLibrary.SelectTemplate(NationalSpire.AiOptions, string)`；`NationalSpire.PromptLibrary.TemplateId(NationalSpire.AiOptions)`；`NationalSpire.PromptLibrary.ValidateTemplateName(NationalSpire.AiOptions, string, string?)`；`NationalSpire.PromptSection.Id`；`NationalSpire.PromptTemplate.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiOptions.AiOptions()`；输入表达式：`new AiOptions { PromptTemplate = baseId, CustomPromptTemplates = options.CustomPromptTemplates ?? new(),             PromptOverrides = baseId == TemplateId(options) ? options.PromptOverrides : options.PromptTemplateOverrides?.GetValueOrDefault(baseId) ?? new() }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new AiOptions { PromptTemplate = baseId, CustomPromptTemplates = options.CustomPromptTemplates ?? new(),             PromptOverrides = baseId == TemplateId(options) ? options.PromptOverrides : options.PromptTemplateOverrides?.GetValueOrDefault(baseId) ?? new() }`
- `NationalSpire.CustomPromptTemplate.CustomPromptTemplate()`；输入表达式：`new CustomPromptTemplate { Name = name, BaseTemplate = builtIn,             Sections = Sections.ToDictionary(s => s.Id, s => Get(source, s.Id)) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CustomPromptTemplate { Name = name, BaseTemplate = builtIn,             Sections = Sections.ToDictionary(s => s.Id, s => Get(source, s.Id)) }`
- `NationalSpire.EventPools.Overrides(NationalSpire.AiOptions, string?)`；输入表达式：`EventPools.Overrides(options, baseId)`；返回值紧邻使用处：`ArgumentSyntax: EventPools.Overrides(options, baseId)`
- `NationalSpire.EventPools.Save(NationalSpire.AiOptions, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<NationalSpire.EventPoolEntry>>, string?)`；输入表达式：`EventPools.Save(options, EventPools.Overrides(options, baseId), id)`；返回值紧邻使用处：`ExpressionStatementSyntax: EventPools.Save(options, EventPools.Overrides(options, baseId), id);`
- `NationalSpire.PromptLibrary.AvailableTemplates(NationalSpire.AiOptions)`；输入表达式：`AvailableTemplates(options)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AvailableTemplates(options).Any`
- `NationalSpire.PromptLibrary.Get(NationalSpire.AiOptions, string)`；输入表达式：`Get(source, s.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: s => Get(source, s.Id)`
- `NationalSpire.PromptLibrary.SelectTemplate(NationalSpire.AiOptions, string)`；输入表达式：`SelectTemplate(options, id)`；返回值紧邻使用处：`ExpressionStatementSyntax: SelectTemplate(options, id);`
- `NationalSpire.PromptLibrary.TemplateId(NationalSpire.AiOptions)`；输入表达式：`TemplateId(options)`；返回值紧邻使用处：`BinaryExpressionSyntax: baseId == TemplateId(options)`
- `NationalSpire.PromptLibrary.ValidateTemplateName(NationalSpire.AiOptions, string, string?)`；输入表达式：`ValidateTemplateName(options, name)`；返回值紧邻使用处：`AssignmentExpressionSyntax: name = ValidateTemplateName(options, name)`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("请选择基础模板。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("请选择基础模板。");`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；输入表达式：`options.CustomPromptTemplates.Add(id, created)`；返回值紧邻使用处：`ExpressionStatementSyntax: options.CustomPromptTemplates.Add(id, created);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new()`；返回值紧邻使用处：`AssignmentExpressionSyntax: options.CustomPromptTemplates ??= new()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new()`；返回值紧邻使用处：`BinaryExpressionSyntax: options.CustomPromptTemplates ?? new()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new()`；返回值紧邻使用处：`BinaryExpressionSyntax: options.PromptTemplateOverrides?.GetValueOrDefault(baseId) ?? new()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`.TryGetValue(baseId, out var custom)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: options.CustomPromptTemplates?.TryGetValue(baseId, out var custom)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`AvailableTemplates(options).Any(t => t.Id == baseId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !AvailableTemplates(options).Any(t => t.Id == baseId)`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`Sections.ToDictionary(s => s.Id, s => Get(source, s.Id))`；返回值紧邻使用处：`AssignmentExpressionSyntax: Sections = Sections.ToDictionary(s => s.Id, s => Get(source, s.Id))`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`.GetValueOrDefault(baseId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: options.PromptTemplateOverrides?.GetValueOrDefault(baseId)`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`BinaryExpressionSyntax: "custom-" + Guid.NewGuid().ToString("N")`

**赋值（含属性/字段和局部值）：**

- `BaseTemplate` = `builtIn`
- `CustomPromptTemplates` = `options.CustomPromptTemplates ?? new()`
- `Name` = `name`
- `name` = `ValidateTemplateName(options, name)`
- `options.CustomPromptTemplates` ??= `new()`
- `PromptOverrides` = `baseId == TemplateId(options) ? options.PromptOverrides : options.PromptTemplateOverrides?.GetValueOrDefault(baseId) ?? new()`
- `PromptTemplate` = `baseId`
- `Sections` = `Sections.ToDictionary(s => s.Id, s => Get(source, s.Id))`
