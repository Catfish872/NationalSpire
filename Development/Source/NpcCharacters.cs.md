# NpcCharacters.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`0E6FE2D68156F2436291A4567EFEC0F51593F723E9DB3F4D9F0298FA0AB45083`。来源：[源码](../../NpcCharacters.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.NpcCharacters`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly string[] Entries = ["IRONCLAD", "SILENT", "DEFECT", "NECROBINDER", "REGENT", "FOOL"];
private static Func<IEnumerable<string>> _source = () => Entries.Take(5);
private static IReadOnlyList<int>? _available;
```

<a id="symbol-00cc4d3c9bf2"></a>

## `NationalSpire.NpcCharacters.Names — public static IReadOnlyList<string> Names`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Array.AsReadOnly<T>(T[])`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Array.AsReadOnly<T>(T[])`；输入表达式：`Array.AsReadOnly(new[] { "铁甲战士", "静默猎手", "故障机器人", "亡灵契约师", "储君", "愚者" })`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Array.AsReadOnly(new[] { "铁甲战士", "静默猎手", "故障机器人", "亡灵契约师", "储君", "愚者" })`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c012b639c059"></a>

## `NationalSpire.NpcCharacters.Source — public static Func<IEnumerable<string>> Source`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.NpcCharacters._available`；`NationalSpire.NpcCharacters._source`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `_available` = `null`
- `_source` = `value`

<a id="symbol-225354e9627a"></a>

## `NationalSpire.NpcCharacters.Available — public static IReadOnlyList<int> Available`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Array.AsReadOnly<T>(T[])`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>(System.Collections.Generic.IEqualityComparer<TSource>?)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `(string entry, int index).entry`；`(string entry, int index).index`；`NationalSpire.NpcCharacters._available`；`NationalSpire.NpcCharacters.Entries`；`NationalSpire.NpcCharacters.Source`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Array.AsReadOnly<T>(T[])`；输入表达式：`Array.AsReadOnly(Entries.Select((entry, index) => (entry, index))                 .Where(pair => current.Contains(pair.entry)).Select(pair => pair.index).ToArray())`；返回值紧邻使用处：`AssignmentExpressionSyntax: _available = Array.AsReadOnly(Entries.Select((entry, index) => (entry, index))                 .Where(pair => current.Contains(pair.entry)).Select(pair => pair.index).ToArray())`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`current.Contains(pair.entry)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: pair => current.Contains(pair.entry)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；输入表达式：`Entries.Select((entry, index) => (entry, index))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Entries.Select((entry, index) => (entry, index))                 .Where`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Entries.Select((entry, index) => (entry, index))                 .Where(pair => current.Contains(pair.entry)).Select(pair => pair.index)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Entries.Select((entry, index) => (entry, index))                 .Where(pair => current.Contains(pair.entry)).Select(pair => pair.index).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Entries.Select((entry, index) => (entry, index))                 .Where(pair => current.Contains(pair.entry)).Select(pair => pair.index).ToArray()`；返回值紧邻使用处：`ArgumentSyntax: Entries.Select((entry, index) => (entry, index))                 .Where(pair => current.Contains(pair.entry)).Select(pair => pair.index).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>(System.Collections.Generic.IEqualityComparer<TSource>?)`；输入表达式：`Source().ToHashSet(StringComparer.Ordinal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Source().ToHashSet(StringComparer.Ordinal)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Entries.Select((entry, index) => (entry, index))                 .Where(pair => current.Contains(pair.entry))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Entries.Select((entry, index) => (entry, index))                 .Where(pair => current.Contains(pair.entry)).Select`
- `System.Func<TResult>.Invoke()`；输入表达式：`Source()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Source().ToHashSet`

**赋值（含属性/字段和局部值）：**

- `_available` = `Array.AsReadOnly(Entries.Select((entry, index) => (entry, index))                 .Where(pair => current.Contains(pair.entry)).Select(pair => pair.index).ToArray())`

<a id="symbol-1a316b5ad8a4"></a>

## `NationalSpire.NpcCharacters.Select(int) — public static int Select(int seed)`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.CreateNew(bool, int, NationalSpire.PersonalityPool?, string?, string?, string)`](CareerEngine.cs.md#symbol-d3b571ec95e8)；[`NationalSpire.CircuitPeople.Add(NationalSpire.CareerData, string, string, string, string, int)`](CircuitPeople.cs.md#symbol-1bc89c911651)；[`NationalSpire.EsportsWorld.Initialize(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-ca5840a56e8d)；[`NationalSpire.OwnedClubs.EnsureMarket(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-3dba497c8606)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.NpcCharacters.Available`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8f7f43f17d89"></a>

## `NationalSpire.NpcCharacters.Index(string) — public static int Index(string name)`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ContentPoolMigration.Refresh(NationalSpire.CareerData)`](ContentPoolMigration.cs.md#symbol-fb1d019899b2)；[`NationalSpire.GameCharacterNames.StartingHp(string)`](GameCharacterNames.cs.md#symbol-1bb238743407)；[`NationalSpire.PrivateProfileChanges.Apply(NationalSpire.CareerPerson, NationalSpire.PrivateProfileChange)`](PrivateProfileChanges.cs.md#symbol-c409575d5f79)；[`NationalSpire.WorldPeople.Enrich(NationalSpire.CareerData)`](WorldPeople.cs.md#symbol-243cbdaa90c2)

**调用：** `string.Equals(string?, System.StringComparison)`；`string.StartsWith(string, System.StringComparison)`

**字段、属性、事件及方法组引用：** `NationalSpire.NpcCharacters.Entries`；`NationalSpire.NpcCharacters.Names`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Equals(string?, System.StringComparison)`；输入表达式：`Entries[i].Equals(entry, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: Names[i] == name || Entries[i].Equals(entry, StringComparison.OrdinalIgnoreCase)`
- `string.Equals(string?, System.StringComparison)`；输入表达式：`name.Equals("The Fool", StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`ConditionalExpressionSyntax: name.Equals("The Fool", StringComparison.OrdinalIgnoreCase) ? 5 : -1`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`name.StartsWith("CHARACTER.", StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`ConditionalExpressionSyntax: name.StartsWith("CHARACTER.", StringComparison.OrdinalIgnoreCase) ? name[10..] : name`

**赋值（含属性/字段和局部值）：**
