# CareerNames.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`9D06BFC58BDC23D12129409D7186AA553FB205E42612617F4CC9CFFA2C7C5F84`。来源：[源码](../../CareerNames.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerNames`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-81992f19fc48"></a>

## `NationalSpire.CareerNames.Validate(NationalSpire.CareerData, string) — public static string? Validate(CareerData data, string value)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerNames.Rename(NationalSpire.CareerData, string)`](CareerNames.cs.md#symbol-68b4cb4672cb)；[`NationalSpire.Coop.CoopRules.AddMember(NationalSpire.Coop.CoopWorld, ulong, string)`](Coop/CoopRules.cs.md#symbol-fedd425e9ea0)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)

**调用：** `char.GetUnicodeCategory(char)`；`char.IsControl(char)`；`string.Trim()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource, System.Collections.Generic.IEqualityComparer<TSource>?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.People`；`NationalSpire.CareerPerson.HandleAliases`；`NationalSpire.CareerPerson.Name`；`NationalSpire.CareerPerson.PublicName`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `char.GetUnicodeCategory(char)`；输入表达式：`char.GetUnicodeCategory(c)`；返回值紧邻使用处：`BinaryExpressionSyntax: char.GetUnicodeCategory(c) == UnicodeCategory.Format`
- `char.IsControl(char)`；输入表达式：`char.IsControl(c)`；返回值紧邻使用处：`BinaryExpressionSyntax: char.IsControl(c) || c is '[' or ']' or '<' or '>'`
- `string.Trim()`；输入表达式：`value.Trim()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = value.Trim()`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.People.Any(p => p.HandleAliases.Append(p.PublicName).Append(p.Name).Contains(name, StringComparer.OrdinalIgnoreCase))`；返回值紧邻使用处：`IfStatementSyntax: if (data.People.Any(p => p.HandleAliases.Append(p.PublicName).Append(p.Name).Contains(name, StringComparer.OrdinalIgnoreCase)))             return "这个名字已有其他人物使用，请换一个名字。";`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`name.Any(c => char.IsControl(c) || c is '[' or ']' or '<' or '>' || char.GetUnicodeCategory(c) == UnicodeCategory.Format)`；返回值紧邻使用处：`IfStatementSyntax: if (name.Any(c => char.IsControl(c) || c is '[' or ']' or '<' or '>' || char.GetUnicodeCategory(c) == UnicodeCategory.Format))             return "游戏名不能包含换行、隐藏字符或标记符号。";`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`p.HandleAliases.Append(p.PublicName).Append(p.Name)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.HandleAliases.Append(p.PublicName).Append(p.Name).Contains`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`p.HandleAliases.Append(p.PublicName)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.HandleAliases.Append(p.PublicName).Append`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource, System.Collections.Generic.IEqualityComparer<TSource>?)`；输入表达式：`p.HandleAliases.Append(p.PublicName).Append(p.Name).Contains(name, StringComparer.OrdinalIgnoreCase)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => p.HandleAliases.Append(p.PublicName).Append(p.Name).Contains(name, StringComparer.OrdinalIgnoreCase)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-68b4cb4672cb"></a>

## `NationalSpire.CareerNames.Rename(NationalSpire.CareerData, string) — public static string? Rename(CareerData data, string value)`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RenamePlayer(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-b0bc87216d33)

**调用：** [`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerNames.Validate(NationalSpire.CareerData, string)`](CareerNames.cs.md#symbol-81992f19fc48)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；`string.Trim()`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource, System.Collections.Generic.IEqualityComparer<TSource>?)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.PlayerAlias`；`NationalSpire.CareerData.PlayerNameAliases`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerNames.Validate(NationalSpire.CareerData, string)`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.Name(data)`
- `NationalSpire.CareerNames.Validate(NationalSpire.CareerData, string)`；输入表达式：`Validate(data, name)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Validate(data, name) is { } error`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(data);`
- `string.Trim()`；输入表达式：`value.Trim()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = value.Trim()`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource, System.Collections.Generic.IEqualityComparer<TSource>?)`；输入表达式：`data.PlayerNameAliases.Contains(old, StringComparer.OrdinalIgnoreCase)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !data.PlayerNameAliases.Contains(old, StringComparer.OrdinalIgnoreCase)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`data.PlayerNameAliases.ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.PlayerNameAliases.ToList()`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`data.PlayerNameAliases.Add(old)`；返回值紧邻使用处：`ExpressionStatementSyntax: data.PlayerNameAliases.Add(old);`

**赋值（含属性/字段和局部值）：**

- `data.PlayerAlias` = `name`
- `data.PlayerAlias` = `previous`
- `data.PlayerNameAliases` = `aliases`
