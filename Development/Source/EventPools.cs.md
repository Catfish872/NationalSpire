# EventPools.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`1B015278363E82C82C9FDCF26F2D0E53C3911EE74FCAB06E3FABA295BBCAED69`。来源：[源码](../../EventPools.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.EventPoolEntry`、`NationalSpire.EventPoolCategory`、`NationalSpire.RandomEventSeed`、`NationalSpire.EventPools`、`NationalSpire.EventPools.Cache`、`NationalSpire.EventPools.Snapshot`。

字段、事件及初始值（源码原样）：

```csharp
public static readonly EventPoolCategory[] Categories =
        new[] { "日常", "饮食", "阅读", "户外", "夜色", "训练", "手作", "交易", "相聚", "音乐" }
            .Select(n => new EventPoolCategory("event:" + n, n, "随机事件"))
            .Concat(WorldEvents.Topics.Select(t => t.Key).Distinct().Select(n => new EventPoolCategory("daily:" + n, n, "普通日常")))
            .Concat(WorldEvents.MatchTopics.Select(t => t.Key).Distinct().Select(n => new EventPoolCategory("daily:" + n, n, "赛后日常"))).ToArray();
private static readonly Dictionary<string, EventPoolEntry[]> Defaults = Categories.ToDictionary(c => c.Id, c =>
        c.Group == "随机事件" ? RandomEventSeeds.All.Where(s => RandomEventSeeds.Category(s) == c.Name).Select(s => new EventPoolEntry("", s)).ToArray()
        : WorldEvents.Topics.Concat(WorldEvents.MatchTopics).Where(t => t.Key == c.Name).Select(t => new EventPoolEntry(t.Title, t.Detail)).ToArray());
private static readonly HashSet<string> MatchCategories = WorldEvents.MatchTopics.Select(t => t.Key).ToHashSet();
private static readonly ConditionalWeakTable<AiOptions, Cache> Caches = new();
public string Template = "";
public Dictionary<string, List<EventPoolEntry>>? Source;
public Snapshot? Value;
```

<a id="symbol-6f63389c2175"></a>

## `NationalSpire.EventPools.Snapshot.Random — public RandomEventSeed[] Random`

来源：源码第 31 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-1a01d17a798a"></a>

## `NationalSpire.EventPools.Snapshot.Daily — internal WorldEvents.Topic[] Daily`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ad26f786c066"></a>

## `NationalSpire.EventPools.Snapshot.DailyCount — public int DailyCount`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.EventPools.Snapshot.Daily`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7bc0b6445755"></a>

## `NationalSpire.EventPools.Snapshot.RandomUsesDefault — public bool RandomUsesDefault`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2a8cc9a21a7c"></a>

## `NationalSpire.EventPools.IsMatchCategory(string) — public static bool IsMatchCategory(string category)`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.WorldEvents.PublishDaily(NationalSpire.CareerData, System.Random, string)`](WorldEvents.cs.md#symbol-8fcd6ba2bc77)

**调用：** `System.Collections.Generic.HashSet<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.EventPools.MatchCategories`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`MatchCategories.Contains(category)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => MatchCategories.Contains(category)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-762000094040"></a>

## `NationalSpire.EventPools.Default(string) — public static IReadOnlyList<EventPoolEntry> Default(string id)`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.EventPools.Defaults`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b2e4f2014e69"></a>

## `NationalSpire.EventPools.Copy(System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<NationalSpire.EventPoolEntry>>) — public static Dictionary<string, List<EventPoolEntry>> Copy(IReadOnlyDictionary<string, List<EventPoolEntry>> source)`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EventPools.Overrides(NationalSpire.AiOptions, string?)`](EventPools.cs.md#symbol-bc809b41fa9c)；[`NationalSpire.EventPools.Save(NationalSpire.AiOptions, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<NationalSpire.EventPoolEntry>>, string?)`](EventPools.cs.md#symbol-a7331058425b)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`source.ToDictionary(p => p.Key, p => p.Value.ToList())`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => source.ToDictionary(p => p.Key, p => p.Value.ToList())`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`p.Value.ToList()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => p.Value.ToList()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-bc809b41fa9c"></a>

## `NationalSpire.EventPools.Overrides(NationalSpire.AiOptions, string?) — public static Dictionary<string, List<EventPoolEntry>> Overrides(AiOptions options, string? template = null)`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenEventPoolSettings(NationalSpire.CareerData)`](EventPoolScreen.cs.md#symbol-8608563c139b)；[`NationalSpire.PromptLibrary.CreateTemplate(NationalSpire.AiOptions, string, string)`](CustomPromptTemplates.cs.md#symbol-89804de92137)；[`NationalSpire.PromptTransfer.Export(NationalSpire.AiOptions, System.Collections.Generic.IReadOnlyDictionary<string, string>)`](PromptTransfer.cs.md#symbol-0bce76771cbe)

**调用：** [`NationalSpire.EventPools.Copy(System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<NationalSpire.EventPoolEntry>>)`](EventPools.cs.md#symbol-b2e4f2014e69)；[`NationalSpire.PromptLibrary.TemplateId(NationalSpire.AiOptions)`](PromptTemplates.cs.md#symbol-51c9e7869e6e)；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.EventPoolOverrides`；`NationalSpire.EventPools.Copy(System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<NationalSpire.EventPoolEntry>>)`；`NationalSpire.PromptLibrary.TemplateId(NationalSpire.AiOptions)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.EventPools.Copy(System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<NationalSpire.EventPoolEntry>>)`；输入表达式：`Copy(bank)`；返回值紧邻使用处：`ConditionalExpressionSyntax: options.EventPoolOverrides.TryGetValue(template ?? PromptLibrary.TemplateId(options), out var bank) ? Copy(bank) : new()`
- `NationalSpire.PromptLibrary.TemplateId(NationalSpire.AiOptions)`；输入表达式：`PromptLibrary.TemplateId(options)`；返回值紧邻使用处：`BinaryExpressionSyntax: template ?? PromptLibrary.TemplateId(options)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new()`；返回值紧邻使用处：`ConditionalExpressionSyntax: options.EventPoolOverrides.TryGetValue(template ?? PromptLibrary.TemplateId(options), out var bank) ? Copy(bank) : new()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`options.EventPoolOverrides.TryGetValue(template ?? PromptLibrary.TemplateId(options), out var bank)`；返回值紧邻使用处：`ConditionalExpressionSyntax: options.EventPoolOverrides.TryGetValue(template ?? PromptLibrary.TemplateId(options), out var bank) ? Copy(bank) : new()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-fd48371b9a06"></a>

## `NationalSpire.EventPools.Entries(System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<NationalSpire.EventPoolEntry>>, string) — public static IReadOnlyList<EventPoolEntry> Entries(IReadOnlyDictionary<string, List<EventPoolEntry>> bank, string id)`

来源：源码第 42 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`ShowCategory()`](EventPoolScreen.cs.md#symbol-e27bbf8a9d14)

**调用：** `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.EventPools.Defaults`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`bank.TryGetValue(id, out var entries)`；返回值紧邻使用处：`ConditionalExpressionSyntax: bank.TryGetValue(id, out var entries) ? entries : Defaults[id]`

**赋值（含属性/字段和局部值）：**


<a id="symbol-6ad85cc3eabc"></a>

## `NationalSpire.EventPools.Validate(System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<NationalSpire.EventPoolEntry>>) — public static void Validate(IReadOnlyDictionary<string, List<EventPoolEntry>> bank)`

来源：源码第 44 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EventPools.Save(NationalSpire.AiOptions, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<NationalSpire.EventPoolEntry>>, string?)`](EventPools.cs.md#symbol-a7331058425b)；[`NationalSpire.PromptTransfer.Validate(NationalSpire.PromptTransfer.Bundle)`](PromptTransfer.cs.md#symbol-c81f82a79264)

**调用：** `string.IsNullOrWhiteSpace(string?)`；`string.StartsWith(string)`；`System.ArgumentException.ArgumentException(string?)`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.EventPoolEntry.Detail`；`NationalSpire.EventPoolEntry.Title`；`NationalSpire.EventPools.Defaults`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(entries[i].Detail)`；返回值紧邻使用处：`BinaryExpressionSyntax: entries[i] == null || string.IsNullOrWhiteSpace(entries[i].Detail)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(entries[i].Title)`；返回值紧邻使用处：`BinaryExpressionSyntax: id.StartsWith("daily:") && string.IsNullOrWhiteSpace(entries[i].Title)`
- `string.StartsWith(string)`；输入表达式：`id.StartsWith("daily:")`；返回值紧邻使用处：`BinaryExpressionSyntax: id.StartsWith("daily:") && string.IsNullOrWhiteSpace(entries[i].Title)`
- `string.StartsWith(string)`；输入表达式：`id.StartsWith("daily:")`；返回值紧邻使用处：`ConditionalExpressionSyntax: id.StartsWith("daily:") ? "标题和内容。" : "素材内容。"`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("事件池分类不存在：" + id)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("事件池分类不存在：" + id);`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("事件池分类需要使用条目列表：" + id)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("事件池分类需要使用条目列表：" + id);`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException($"{id} 第 {i + 1} 条需要填写" + (id.StartsWith("daily:") ? "标题和内容。" : "素材内容。"))`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException($"{id} 第 {i + 1} 条需要填写" + (id.StartsWith("daily:") ? "标题和内容。" : "素材内容。"));`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`Defaults.ContainsKey(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Defaults.ContainsKey(id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a7331058425b"></a>

## `NationalSpire.EventPools.Save(NationalSpire.AiOptions, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<NationalSpire.EventPoolEntry>>, string?) — public static void Save(AiOptions options, IReadOnlyDictionary<string, List<EventPoolEntry>> bank, string? template = null)`

来源：源码第 55 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenEventPoolSettings(NationalSpire.CareerData)`](EventPoolScreen.cs.md#symbol-8608563c139b)；[`NationalSpire.PromptLibrary.CreateTemplate(NationalSpire.AiOptions, string, string)`](CustomPromptTemplates.cs.md#symbol-89804de92137)；[`NationalSpire.PromptTransfer.Apply(NationalSpire.AiOptions, NationalSpire.PromptTransfer.Bundle, string?)`](PromptTransfer.cs.md#symbol-3403e8b82dd8)

**调用：** [`NationalSpire.EventPools.Copy(System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<NationalSpire.EventPoolEntry>>)`](EventPools.cs.md#symbol-b2e4f2014e69)；[`NationalSpire.EventPools.Validate(System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<NationalSpire.EventPoolEntry>>)`](EventPools.cs.md#symbol-6ad85cc3eabc)；[`NationalSpire.PromptLibrary.TemplateId(NationalSpire.AiOptions)`](PromptTemplates.cs.md#symbol-51c9e7869e6e)；`System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>.Remove(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.EventPoolOverrides`；`NationalSpire.EventPools.Caches`；`NationalSpire.EventPools.Copy(System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<NationalSpire.EventPoolEntry>>)`；`NationalSpire.EventPools.Validate(System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<NationalSpire.EventPoolEntry>>)`；`NationalSpire.PromptLibrary.TemplateId(NationalSpire.AiOptions)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.EventPools.Copy(System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<NationalSpire.EventPoolEntry>>)`；输入表达式：`Copy(bank)`；返回值紧邻使用处：`AssignmentExpressionSyntax: options.EventPoolOverrides[template ?? PromptLibrary.TemplateId(options)] = Copy(bank)`
- `NationalSpire.EventPools.Validate(System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<NationalSpire.EventPoolEntry>>)`；输入表达式：`Validate(bank)`；返回值紧邻使用处：`ExpressionStatementSyntax: Validate(bank);`
- `NationalSpire.PromptLibrary.TemplateId(NationalSpire.AiOptions)`；输入表达式：`PromptLibrary.TemplateId(options)`；返回值紧邻使用处：`BinaryExpressionSyntax: template ?? PromptLibrary.TemplateId(options)`
- `System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>.Remove(TKey)`；输入表达式：`Caches.Remove(options)`；返回值紧邻使用处：`ExpressionStatementSyntax: Caches.Remove(options);`

**赋值（含属性/字段和局部值）：**

- `options.EventPoolOverrides[template ?? PromptLibrary.TemplateId(options)]` = `Copy(bank)`

<a id="symbol-5c94170cef9e"></a>

## `NationalSpire.EventPools.Get(NationalSpire.AiOptions) — public static Snapshot Get(AiOptions options)`

来源：源码第 61 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenEventPoolSettings(NationalSpire.CareerData)`](EventPoolScreen.cs.md#symbol-8608563c139b)；[`NationalSpire.EventPools.Get(NationalSpire.CareerData)`](EventPools.cs.md#symbol-251ecd73d129)；[`NationalSpire.EventPools.SelectRandom(NationalSpire.AiOptions, System.Collections.Generic.ISet<string>, System.Random)`](EventPools.cs.md#symbol-1c1bd4e75154)

**调用：** [`NationalSpire.EventPools.Build(System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<NationalSpire.EventPoolEntry>>)`](EventPools.cs.md#symbol-3077931c8bfc)；[`NationalSpire.PromptLibrary.TemplateId(NationalSpire.AiOptions)`](PromptTemplates.cs.md#symbol-51c9e7869e6e)；`object.ReferenceEquals(object?, object?)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>.GetOrCreateValue(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.EventPoolOverrides`；`NationalSpire.EventPools.Build(System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<NationalSpire.EventPoolEntry>>)`；`NationalSpire.EventPools.Cache.Source`；`NationalSpire.EventPools.Cache.Template`；`NationalSpire.EventPools.Cache.Value`；`NationalSpire.EventPools.Caches`；`NationalSpire.PromptLibrary.TemplateId(NationalSpire.AiOptions)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.EventPools.Build(System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<NationalSpire.EventPoolEntry>>)`；输入表达式：`Build(source ?? new())`；返回值紧邻使用处：`AssignmentExpressionSyntax: cache.Value = Build(source ?? new())`
- `NationalSpire.PromptLibrary.TemplateId(NationalSpire.AiOptions)`；输入表达式：`PromptLibrary.TemplateId(options)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PromptLibrary.TemplateId(options)`
- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(cache.Source, source)`；返回值紧邻使用处：`BinaryExpressionSyntax: cache.Value != null && cache.Template == template && ReferenceEquals(cache.Source, source)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new()`；返回值紧邻使用处：`BinaryExpressionSyntax: source ?? new()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`options.EventPoolOverrides.TryGetValue(template, out var source)`；返回值紧邻使用处：`ExpressionStatementSyntax: options.EventPoolOverrides.TryGetValue(template, out var source);`
- `System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>.GetOrCreateValue(TKey)`；输入表达式：`Caches.GetOrCreateValue(options)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Caches.GetOrCreateValue(options)`

**赋值（含属性/字段和局部值）：**

- `cache.Source` = `source`
- `cache.Template` = `template`
- `cache.Value` = `Build(source ?? new())`

<a id="symbol-251ecd73d129"></a>

## `NationalSpire.EventPools.Get(NationalSpire.CareerData) — public static Snapshot Get(CareerData data)`

来源：源码第 71 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.WorldEvents.PublishDaily(NationalSpire.CareerData, System.Random, string)`](WorldEvents.cs.md#symbol-8fcd6ba2bc77)

**调用：** [`NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`](AiSettingsStore.cs.md#symbol-b37e55b3af97)；[`NationalSpire.EventPools.Get(NationalSpire.AiOptions)`](EventPools.cs.md#symbol-5c94170cef9e)

**字段、属性、事件及方法组引用：** `NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerData.CooperativeMembers`；`NationalSpire.EventPools.Get(NationalSpire.AiOptions)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；输入表达式：`AiSettingsStore.Load(data.Ai)`；返回值紧邻使用处：`ConditionalExpressionSyntax: data.CooperativeMembers > 1 ? AiSettingsStore.Load(data.Ai) : data.Ai`
- `NationalSpire.EventPools.Get(NationalSpire.AiOptions)`；输入表达式：`Get(data.CooperativeMembers > 1 ? AiSettingsStore.Load(data.Ai) : data.Ai)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Get(data.CooperativeMembers > 1 ? AiSettingsStore.Load(data.Ai) : data.Ai)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3077931c8bfc"></a>

## `NationalSpire.EventPools.Build(System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<NationalSpire.EventPoolEntry>>) — public static Snapshot Build(IReadOnlyDictionary<string, List<EventPoolEntry>> bank)`

来源：源码第 72 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConfirmPromptImport(NationalSpire.CareerData, string, System.Action)`](PromptScreen.cs.md#symbol-b9da8509093b)；[`NationalSpire.EventPools.Get(NationalSpire.AiOptions)`](EventPools.cs.md#symbol-5c94170cef9e)

**调用：** [`NationalSpire.RandomEventSeeds.Category(string)`](RandomEventSeeds.cs.md#symbol-be664de1cd8d)；`NationalSpire.EventPools.Snapshot.Snapshot()`；`NationalSpire.RandomEventSeed.RandomEventSeed(string, string)`；`NationalSpire.WorldEvents.Topic.Topic(string, string, string)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.HashSet()`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.List<T>.List()`；`System.Collections.Generic.List<T>.ToArray()`

**字段、属性、事件及方法组引用：** `NationalSpire.EventPoolCategory.Group`；`NationalSpire.EventPoolCategory.Id`；`NationalSpire.EventPoolCategory.Name`；`NationalSpire.EventPoolEntry.Detail`；`NationalSpire.EventPoolEntry.Title`；`NationalSpire.EventPools.Categories`；`NationalSpire.EventPools.Snapshot.Daily`；`NationalSpire.EventPools.Snapshot.Random`；`NationalSpire.EventPools.Snapshot.RandomUsesDefault`；`NationalSpire.RandomEventSeeds.All`；`NationalSpire.RandomEventSeeds.Category(string)`；`NationalSpire.WorldEvents.MatchTopics`；`NationalSpire.WorldEvents.Topic.Key`；`NationalSpire.WorldEvents.Topics`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.EventPools.Snapshot.Snapshot()`；输入表达式：`new() { Random = random.ToArray(), Daily = daily.ToArray(), RandomUsesDefault = fallback }`；返回值紧邻使用处：`ReturnStatementSyntax: return new() { Random = random.ToArray(), Daily = daily.ToArray(), RandomUsesDefault = fallback };`
- `NationalSpire.RandomEventSeed.RandomEventSeed(string, string)`；输入表达式：`new RandomEventSeed(category, e.Detail)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: e => new RandomEventSeed(category, e.Detail)`
- `NationalSpire.RandomEventSeed.RandomEventSeed(string, string)`；输入表达式：`new RandomEventSeed(category.Name, e.Detail)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: e => new RandomEventSeed(category.Name, e.Detail)`
- `NationalSpire.RandomEventSeed.RandomEventSeed(string, string)`；输入表达式：`new RandomEventSeed(RandomEventSeeds.Category(s), s)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: s => new RandomEventSeed(RandomEventSeeds.Category(s), s)`
- `NationalSpire.RandomEventSeed.RandomEventSeed(string, string)`；输入表达式：`new(category, seed)`；返回值紧邻使用处：`ArgumentSyntax: new(category, seed)`
- `NationalSpire.RandomEventSeeds.Category(string)`；输入表达式：`RandomEventSeeds.Category(s)`；返回值紧邻使用处：`ArgumentSyntax: RandomEventSeeds.Category(s)`
- `NationalSpire.RandomEventSeeds.Category(string)`；输入表达式：`RandomEventSeeds.Category(seed)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RandomEventSeeds.Category(seed)`
- `NationalSpire.WorldEvents.Topic.Topic(string, string, string)`；输入表达式：`new WorldEvents.Topic(topic.Key, e.Title, e.Detail)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: e => new WorldEvents.Topic(topic.Key, e.Title, e.Detail)`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`replaced.Add(category.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: bank.TryGetValue(category.Id, out var entries) && replaced.Add(category.Id)`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`replaced.Add(id)`；返回值紧邻使用处：`IfStatementSyntax: if (replaced.Add(id)) daily.AddRange(entries.Select(e => new WorldEvents.Topic(topic.Key, e.Title, e.Detail)));`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`replaced.Add(id)`；返回值紧邻使用处：`IfStatementSyntax: if (replaced.Add(id)) random.AddRange(entries.Select(e => new RandomEventSeed(category, e.Detail)));`
- `System.Collections.Generic.HashSet<T>.HashSet()`；输入表达式：`new HashSet<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HashSet<string>()`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`WorldEvents.Topics.Concat(WorldEvents.MatchTopics)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var topic in WorldEvents.Topics.Concat(WorldEvents.MatchTopics))         {             string id = "daily:" + topic.Key;             if (!bank.TryGetValue(id, out var entries)) daily.Add(topic);             else if (replaced.Add(id)) daily.AddRange(entries.Select(e => new WorldEvents.Topic(topic.Key, e.Title, e.Detail)));         }`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`entries.Select(e => new RandomEventSeed(category, e.Detail))`；返回值紧邻使用处：`ArgumentSyntax: entries.Select(e => new RandomEventSeed(category, e.Detail))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`entries.Select(e => new RandomEventSeed(category.Name, e.Detail))`；返回值紧邻使用处：`ArgumentSyntax: entries.Select(e => new RandomEventSeed(category.Name, e.Detail))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`entries.Select(e => new WorldEvents.Topic(topic.Key, e.Title, e.Detail))`；返回值紧邻使用处：`ArgumentSyntax: entries.Select(e => new WorldEvents.Topic(topic.Key, e.Title, e.Detail))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`RandomEventSeeds.All.Select(s => new RandomEventSeed(RandomEventSeeds.Category(s), s))`；返回值紧邻使用处：`ArgumentSyntax: RandomEventSeeds.All.Select(s => new RandomEventSeed(RandomEventSeeds.Category(s), s))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Categories.Where(c => c.Group == "随机事件")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var category in Categories.Where(c => c.Group == "随机事件"))             if (bank.TryGetValue(category.Id, out var entries) && replaced.Add(category.Id))                 random.AddRange(entries.Select(e => new RandomEventSeed(category.Name, e.Detail)));`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`bank.TryGetValue(category.Id, out var entries)`；返回值紧邻使用处：`BinaryExpressionSyntax: bank.TryGetValue(category.Id, out var entries) && replaced.Add(category.Id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`bank.TryGetValue(id, out var entries)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !bank.TryGetValue(id, out var entries)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`daily.Add(topic)`；返回值紧邻使用处：`ExpressionStatementSyntax: daily.Add(topic);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`random.Add(new(category, seed))`；返回值紧邻使用处：`ExpressionStatementSyntax: random.Add(new(category, seed));`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`daily.AddRange(entries.Select(e => new WorldEvents.Topic(topic.Key, e.Title, e.Detail)))`；返回值紧邻使用处：`ExpressionStatementSyntax: daily.AddRange(entries.Select(e => new WorldEvents.Topic(topic.Key, e.Title, e.Detail)));`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`random.AddRange(entries.Select(e => new RandomEventSeed(category, e.Detail)))`；返回值紧邻使用处：`ExpressionStatementSyntax: random.AddRange(entries.Select(e => new RandomEventSeed(category, e.Detail)));`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`random.AddRange(entries.Select(e => new RandomEventSeed(category.Name, e.Detail)))`；返回值紧邻使用处：`ExpressionStatementSyntax: random.AddRange(entries.Select(e => new RandomEventSeed(category.Name, e.Detail)));`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`random.AddRange(RandomEventSeeds.All.Select(s => new RandomEventSeed(RandomEventSeeds.Category(s), s)))`；返回值紧邻使用处：`ExpressionStatementSyntax: random.AddRange(RandomEventSeeds.All.Select(s => new RandomEventSeed(RandomEventSeeds.Category(s), s)));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<RandomEventSeed>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<RandomEventSeed>()`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<WorldEvents.Topic>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<WorldEvents.Topic>()`
- `System.Collections.Generic.List<T>.ToArray()`；输入表达式：`daily.ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Daily = daily.ToArray()`
- `System.Collections.Generic.List<T>.ToArray()`；输入表达式：`random.ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Random = random.ToArray()`

**赋值（含属性/字段和局部值）：**

- `Daily` = `daily.ToArray()`
- `Random` = `random.ToArray()`
- `RandomUsesDefault` = `fallback`

<a id="symbol-1c1bd4e75154"></a>

## `NationalSpire.EventPools.SelectRandom(NationalSpire.AiOptions, System.Collections.Generic.ISet<string>, System.Random) — public static RandomEventSeed SelectRandom(AiOptions options, ISet<string> recent, Random random)`

来源：源码第 97 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.RandomEvents.Start(NationalSpire.CareerData, string)`](RandomEvents.cs.md#symbol-605db3348248)

**调用：** [`NationalSpire.EventPools.Get(NationalSpire.AiOptions)`](EventPools.cs.md#symbol-5c94170cef9e)；`System.Collections.Generic.ICollection<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Random.Next(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.EventPools.Get(NationalSpire.AiOptions)`；`NationalSpire.EventPools.Snapshot.Random`；`NationalSpire.RandomEventSeed.Detail`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.EventPools.Get(NationalSpire.AiOptions)`；输入表达式：`Get(options)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Get(options).Random`
- `System.Collections.Generic.ICollection<T>.Contains(T)`；输入表达式：`recent.Contains(s.Detail)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !recent.Contains(s.Detail)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`all.Where(s => !recent.Contains(s.Detail)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = all.Where(s => !recent.Contains(s.Detail)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`all.Where(s => !recent.Contains(s.Detail))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: all.Where(s => !recent.Contains(s.Detail)).ToArray`
- `System.Random.Next(int)`；输入表达式：`random.Next(candidates.Length)`；返回值紧邻使用处：`ArgumentSyntax: random.Next(candidates.Length)`

**赋值（含属性/字段和局部值）：**

- `candidates` = `all`

<a id="symbol-2eb5f48b0ab7"></a>

## `NationalSpire.EventPools.BulkText(string, System.Collections.Generic.IEnumerable<NationalSpire.EventPoolEntry>) — public static string BulkText(string id, IEnumerable<EventPoolEntry> entries)`

来源：源码第 104 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenEventPoolSettings(NationalSpire.CareerData)`](EventPoolScreen.cs.md#symbol-8608563c139b)；[`ShowCategory()`](EventPoolScreen.cs.md#symbol-e27bbf8a9d14)

**调用：** [`Escape(string)`](EventPools.cs.md#symbol-99d8572adf2e)；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`string.StartsWith(string)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`

**字段、属性、事件及方法组引用：** `Escape(string)`；`NationalSpire.EventPoolEntry.Detail`；`NationalSpire.EventPoolEntry.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Escape(string)`；输入表达式：`Escape(e.Detail)`；返回值紧邻使用处：`BinaryExpressionSyntax: (id.StartsWith("daily:") ? Escape(e.Title) + "｜" : "") + Escape(e.Detail)`
- `Escape(string)`；输入表达式：`Escape(e.Title)`；返回值紧邻使用处：`BinaryExpressionSyntax: Escape(e.Title) + "｜"`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n", entries.Select(e => (id.StartsWith("daily:") ? Escape(e.Title) + "｜" : "") + Escape(e.Detail)))`；返回值紧邻使用处：`ReturnStatementSyntax: return string.Join("\n", entries.Select(e => (id.StartsWith("daily:") ? Escape(e.Title) + "｜" : "") + Escape(e.Detail)));`
- `string.StartsWith(string)`；输入表达式：`id.StartsWith("daily:")`；返回值紧邻使用处：`ConditionalExpressionSyntax: id.StartsWith("daily:") ? Escape(e.Title) + "｜" : ""`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`entries.Select(e => (id.StartsWith("daily:") ? Escape(e.Title) + "｜" : "") + Escape(e.Detail))`；返回值紧邻使用处：`ArgumentSyntax: entries.Select(e => (id.StartsWith("daily:") ? Escape(e.Title) + "｜" : "") + Escape(e.Detail))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-99d8572adf2e"></a>

## `Escape(string) — static string Escape(string s)`

来源：源码第 106 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EventPools.BulkText(string, System.Collections.Generic.IEnumerable<NationalSpire.EventPoolEntry>)`](EventPools.cs.md#symbol-2eb5f48b0ab7)

**调用：** `string.Replace(string, string?)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Replace(string, string?)`；输入表达式：`s.Replace("\\", "\\\\").Replace("\r", "").Replace("\n", "\\n").Replace("｜", "\\｜")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => s.Replace("\\", "\\\\").Replace("\r", "").Replace("\n", "\\n").Replace("｜", "\\｜")`
- `string.Replace(string, string?)`；输入表达式：`s.Replace("\\", "\\\\").Replace("\r", "").Replace("\n", "\\n")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: s.Replace("\\", "\\\\").Replace("\r", "").Replace("\n", "\\n").Replace`
- `string.Replace(string, string?)`；输入表达式：`s.Replace("\\", "\\\\").Replace("\r", "")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: s.Replace("\\", "\\\\").Replace("\r", "").Replace`
- `string.Replace(string, string?)`；输入表达式：`s.Replace("\\", "\\\\")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: s.Replace("\\", "\\\\").Replace`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4888d28a4905"></a>

## `NationalSpire.EventPools.ParseBulk(string, string) — public static List<EventPoolEntry> ParseBulk(string id, string text)`

来源：源码第 109 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Commit()`](EventPoolScreen.cs.md#symbol-15a258d19400)

**调用：** `NationalSpire.EventPoolEntry.EventPoolEntry(string, string)`；`string.IsNullOrWhiteSpace(string?)`；`string.Replace(string, string?)`；`string.Split(char, System.StringSplitOptions)`；`string.StartsWith(string)`；`string.Trim()`；`System.ArgumentException.ArgumentException(string?)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Text.StringBuilder.Append(char)`；`System.Text.StringBuilder.Clear()`；`System.Text.StringBuilder.StringBuilder()`；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.EventPoolEntry.EventPoolEntry(string, string)`；输入表达式：`new(fields.Count == 2 ? fields[0] : "", fields[^1])`；返回值紧邻使用处：`ArgumentSyntax: new(fields.Count == 2 ? fields[0] : "", fields[^1])`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(raw)`；返回值紧邻使用处：`IfStatementSyntax: if (string.IsNullOrWhiteSpace(raw)) continue;`
- `string.Replace(string, string?)`；输入表达式：`text.Replace("\r", "")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.Replace("\r", "").Split`
- `string.Split(char, System.StringSplitOptions)`；输入表达式：`text.Replace("\r", "").Split('\n')`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string raw in text.Replace("\r", "").Split('\n'))         {             line++; if (string.IsNullOrWhiteSpace(raw)) continue;             var fields = new List<string>(); var current = new StringBuilder();             for (int i = 0; i < raw.Length; i++)             {                 char c = raw[i];                 if (c == '\\' && i + 1 < raw.Length && raw[i + 1] is 'n' or '\\' or '｜')                 { c = raw[++i]; current.Append(c == 'n' ? '\n' : c); }                 else if (c == '｜' && fields.Count == 0 && id.StartsWith("daily:")) { fields.Add(current.ToString().Trim()); current.Clear(); }                 else current.Append(c);             }             fields.Add(current.ToString().Trim());             if (fields.Any(string.IsNullOrWhiteSpace) || (id.StartsWith("daily:") && fields.Count != 2))                 throw new ArgumentException($"第 {line} 行：" + (id.StartsWith("daily:") ? "请填写标题｜内容。" : "请填写素材内容。"));             result.Add(new(fields.Count == 2 ? fields[0] : "", fields[^1]));         }`
- `string.StartsWith(string)`；输入表达式：`id.StartsWith("daily:")`；返回值紧邻使用处：`BinaryExpressionSyntax: c == '｜' && fields.Count == 0 && id.StartsWith("daily:")`
- `string.StartsWith(string)`；输入表达式：`id.StartsWith("daily:")`；返回值紧邻使用处：`BinaryExpressionSyntax: id.StartsWith("daily:") && fields.Count != 2`
- `string.StartsWith(string)`；输入表达式：`id.StartsWith("daily:")`；返回值紧邻使用处：`ConditionalExpressionSyntax: id.StartsWith("daily:") ? "请填写标题｜内容。" : "请填写素材内容。"`
- `string.Trim()`；输入表达式：`current.ToString().Trim()`；返回值紧邻使用处：`ArgumentSyntax: current.ToString().Trim()`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException($"第 {line} 行：" + (id.StartsWith("daily:") ? "请填写标题｜内容。" : "请填写素材内容。"))`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException($"第 {line} 行：" + (id.StartsWith("daily:") ? "请填写标题｜内容。" : "请填写素材内容。"));`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`fields.Any(string.IsNullOrWhiteSpace)`；返回值紧邻使用处：`BinaryExpressionSyntax: fields.Any(string.IsNullOrWhiteSpace) || (id.StartsWith("daily:") && fields.Count != 2)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`fields.Add(current.ToString().Trim())`；返回值紧邻使用处：`ExpressionStatementSyntax: fields.Add(current.ToString().Trim());`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`result.Add(new(fields.Count == 2 ? fields[0] : "", fields[^1]))`；返回值紧邻使用处：`ExpressionStatementSyntax: result.Add(new(fields.Count == 2 ? fields[0] : "", fields[^1]));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<EventPoolEntry>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<EventPoolEntry>()`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<string>()`
- `System.Text.StringBuilder.Append(char)`；输入表达式：`current.Append(c == 'n' ? '\n' : c)`；返回值紧邻使用处：`ExpressionStatementSyntax: current.Append(c == 'n' ? '\n' : c);`
- `System.Text.StringBuilder.Append(char)`；输入表达式：`current.Append(c)`；返回值紧邻使用处：`ExpressionStatementSyntax: current.Append(c);`
- `System.Text.StringBuilder.Clear()`；输入表达式：`current.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: current.Clear();`
- `System.Text.StringBuilder.StringBuilder()`；输入表达式：`new StringBuilder()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StringBuilder()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`current.ToString()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: current.ToString().Trim`

**赋值（含属性/字段和局部值）：**

- `c` = `raw[++i]`
