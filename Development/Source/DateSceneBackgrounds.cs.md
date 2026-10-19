# DateSceneBackgrounds.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`6CA0941D2AC2F242DD568CEC922CFC6C79318E13ACAB57E79C8A6D10DFB6A0FF`。来源：[源码](../../DateSceneBackgrounds.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.DateSceneBackground`、`NationalSpire.DateBackgroundLibrary`、`NationalSpire.DateSceneBackgrounds`。

字段、事件及初始值（源码原样）：

```csharp
public static readonly string[] Extensions = [".png", ".jpg", ".jpeg", ".webp"];
private static readonly Dictionary<string, (long Length, DateTime Time, string Image)> PackCache = [];
```

<a id="symbol-6f68c6fcb4a6"></a>

## `NationalSpire.DateSceneBackground.Id — public string Id`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-086c6df19629"></a>

## `NationalSpire.DateSceneBackground.Description — public string Description`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-84252b82267e"></a>

## `NationalSpire.DateSceneBackground.Image — public string Image`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8ebd0e36bb12"></a>

## `NationalSpire.DateBackgroundLibrary.Images — public List<DateSceneBackground> Images`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a0738460ae9d"></a>

## `NationalSpire.DateBackgroundLibrary.Descriptions — public Dictionary<string, string> Descriptions`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6e6f7ed4d30c"></a>

## `NationalSpire.DateBackgroundLibrary.Removed — public HashSet<string> Removed`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7e409d1b4e9f"></a>

## `NationalSpire.DateSceneBackgrounds.AutomaticChoices(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneBackground>) — public static List<DateSceneBackground> AutomaticChoices(IEnumerable<DateSceneBackground> library)`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ApplyDateBackground()`](DateSceneScreen.cs.md#symbol-4c2055af1c70)；[`NationalSpire.CareerScreen.SceneRequest(bool)`](DateSceneScreen.cs.md#symbol-277baf4e7cb8)；[`NationalSpire.DateSceneBackgrounds.Closest(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneBackground>, string, string)`](DateSceneBackgrounds.cs.md#symbol-fe6e9e9ebd7b)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneBackground.Image`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`items.Where(b => b.Image.Length == 64).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = items.Where(b => b.Image.Length == 64).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`library.ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = library.ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`items.Where(b => b.Image.Length == 64)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: items.Where(b => b.Image.Length == 64).ToList`

**赋值（含属性/字段和局部值）：**


<a id="symbol-fe6e9e9ebd7b"></a>

## `NationalSpire.DateSceneBackgrounds.Closest(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneBackground>, string, string) — public static string Closest(IEnumerable<DateSceneBackground> library, string context, string current = "")`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ApplyDateBackground()`](DateSceneScreen.cs.md#symbol-4c2055af1c70)；[`NationalSpire.CareerScreen.DateSceneSettings()`](DateSceneScreen.cs.md#symbol-0845ec2acab1)

**调用：** [`NationalSpire.DateSceneBackgrounds.AutomaticChoices(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneBackground>)`](DateSceneBackgrounds.cs.md#symbol-7e409d1b4e9f)；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；`System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；[`Terms(string)`](DateSceneBackgrounds.cs.md#symbol-2a39848a916a)；`string.StartsWith(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneBackground.Description`；`NationalSpire.DateSceneBackground.Id`；`NationalSpire.DateSceneBackgrounds.AutomaticChoices(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneBackground>)`；`Terms(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneBackgrounds.AutomaticChoices(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneBackground>)`；输入表达式：`AutomaticChoices(library)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AutomaticChoices(library).OrderByDescending`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`query.Contains(t)`；返回值紧邻使用处：`ConditionalExpressionSyntax: query.Contains(t) ? t.StartsWith("scene:") ? 4 : 1 : 0`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`AutomaticChoices(library).OrderByDescending(b => Terms(b.Id + " " + b.Description).Sum(t => query.Contains(t) ? t.StartsWith("scene:") ? 4 : 1 : 0)) .ThenByDescending(b => b.Id == current).ThenBy(b => b.Id, StringComparer.Ordinal).FirstOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: AutomaticChoices(library).OrderByDescending(b => Terms(b.Id + " " + b.Description).Sum(t => query.Contains(t) ? t.StartsWith("scene:") ? 4 : 1 : 0)) .ThenByDescending(b => b.Id == current).ThenBy(b => b.Id, StringComparer.Ordinal).FirstOrDefault()?.Id`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`AutomaticChoices(library).OrderByDescending(b => Terms(b.Id + " " + b.Description).Sum(t => query.Contains(t) ? t.StartsWith("scene:") ? 4 : 1 : 0))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AutomaticChoices(library).OrderByDescending(b => Terms(b.Id + " " + b.Description).Sum(t => query.Contains(t) ? t.StartsWith("scene:") ? 4 : 1 : 0)) .ThenByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`Terms(b.Id + " " + b.Description).Sum(t => query.Contains(t) ? t.StartsWith("scene:") ? 4 : 1 : 0)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: b => Terms(b.Id + " " + b.Description).Sum(t => query.Contains(t) ? t.StartsWith("scene:") ? 4 : 1 : 0)`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`AutomaticChoices(library).OrderByDescending(b => Terms(b.Id + " " + b.Description).Sum(t => query.Contains(t) ? t.StartsWith("scene:") ? 4 : 1 : 0)) .ThenByDescending(b => b.Id == current).ThenBy(b => b.Id, StringComparer.Ordinal)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AutomaticChoices(library).OrderByDescending(b => Terms(b.Id + " " + b.Description).Sum(t => query.Contains(t) ? t.StartsWith("scene:") ? 4 : 1 : 0)) .ThenByDescending(b => b.Id == current).ThenBy(b => b.Id, StringComparer.Ordinal).FirstOrDefault`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`AutomaticChoices(library).OrderByDescending(b => Terms(b.Id + " " + b.Description).Sum(t => query.Contains(t) ? t.StartsWith("scene:") ? 4 : 1 : 0)) .ThenByDescending(b => b.Id == current)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AutomaticChoices(library).OrderByDescending(b => Terms(b.Id + " " + b.Description).Sum(t => query.Contains(t) ? t.StartsWith("scene:") ? 4 : 1 : 0)) .ThenByDescending(b => b.Id == current).ThenBy`
- `Terms(string)`；输入表达式：`Terms(b.Id + " " + b.Description)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Terms(b.Id + " " + b.Description).Sum`
- `Terms(string)`；输入表达式：`Terms(context)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Terms(context)`
- `string.StartsWith(string)`；输入表达式：`t.StartsWith("scene:")`；返回值紧邻使用处：`ConditionalExpressionSyntax: t.StartsWith("scene:") ? 4 : 1`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2a39848a916a"></a>

## `Terms(string) — static HashSet<string> Terms(string text)`

来源：源码第 30 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneBackgrounds.Closest(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneBackground>, string, string)`](DateSceneBackgrounds.cs.md#symbol-fe6e9e9ebd7b)

**调用：** `System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.HashSet(System.Collections.Generic.IEqualityComparer<T>?)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Text.RegularExpressions.Regex.Matches(string, string)`；`string.Substring(int, int)`；`string.ToLowerInvariant()`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`terms.Add("scene:" + i)`；返回值紧邻使用处：`ExpressionStatementSyntax: terms.Add("scene:" + i);`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`terms.Add(value)`；返回值紧邻使用处：`ExpressionStatementSyntax: terms.Add(value);`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`terms.Add(value.Substring(i, 2))`；返回值紧邻使用处：`ExpressionStatementSyntax: terms.Add(value.Substring(i, 2));`
- `System.Collections.Generic.HashSet<T>.HashSet(System.Collections.Generic.IEqualityComparer<T>?)`；输入表达式：`new HashSet<string>(StringComparer.OrdinalIgnoreCase)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HashSet<string>(StringComparer.OrdinalIgnoreCase)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`aliases[i].Any(terms.Contains)`；返回值紧邻使用处：`IfStatementSyntax: if (aliases[i].Any(terms.Contains)) terms.Add("scene:" + i);`
- `System.Text.RegularExpressions.Regex.Matches(string, string)`；输入表达式：`System.Text.RegularExpressions.Regex.Matches(text.ToLowerInvariant(), "[a-z0-9]+|[\\u4e00-\\u9fff]+")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (System.Text.RegularExpressions.Match word in System.Text.RegularExpressions.Regex.Matches(text.ToLowerInvariant(), "[a-z0-9]+|[\\u4e00-\\u9fff]+")) { string value = word.Value; terms.Add(value); if (value[0] >= '\u4e00') for (int i = 0; i + 1 < value.Length; i++) terms.Add(value.Substring(i, 2)); }`
- `string.Substring(int, int)`；输入表达式：`value.Substring(i, 2)`；返回值紧邻使用处：`ArgumentSyntax: value.Substring(i, 2)`
- `string.ToLowerInvariant()`；输入表达式：`text.ToLowerInvariant()`；返回值紧邻使用处：`ArgumentSyntax: text.ToLowerInvariant()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d0eca57dcb77"></a>

## `NationalSpire.DateSceneBackgrounds.FilePath — public static string FilePath`

来源：源码第 50 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.IO.Path.Combine(string, string)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneAssetStore.DirectoryPath`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(DateSceneAssetStore.DirectoryPath, "background-library.json")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Path.Combine(DateSceneAssetStore.DirectoryPath, "background-library.json")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-19bb6c988fd7"></a>

## `NationalSpire.DateSceneBackgrounds.SafeId(string) — public static bool SafeId(string id)`

来源：源码第 51 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneBackgrounds.Describe(string, string)`](DateSceneBackgrounds.cs.md#symbol-c96b7de63f9b)；[`NationalSpire.DateSceneBackgrounds.ImageId(string)`](DateSceneBackgrounds.cs.md#symbol-2aeddbe7d881)；[`NationalSpire.DateSceneBackgrounds.Read(out string, string?)`](DateSceneBackgrounds.cs.md#symbol-b6c3bc7d87d9)；[`NationalSpire.DateSceneBackgrounds.Remove(string)`](DateSceneBackgrounds.cs.md#symbol-b7d6d0097052)；[`NationalSpire.DateScenes.Validate(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest)`](DateSceneData.cs.md#symbol-190a72e967ad)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`char.IsLetterOrDigit(char)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`id.All(c => char.IsLetterOrDigit(c) || c is '_' or '-')`；返回值紧邻使用处：`BinaryExpressionSyntax: id.Length is > 0 and <= 100 && id.All(c => char.IsLetterOrDigit(c) || c is '_' or '-')`
- `char.IsLetterOrDigit(char)`；输入表达式：`char.IsLetterOrDigit(c)`；返回值紧邻使用处：`BinaryExpressionSyntax: char.IsLetterOrDigit(c) || c is '_' or '-'`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2aeddbe7d881"></a>

## `NationalSpire.DateSceneBackgrounds.ImageId(string) — public static string ImageId(string path)`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneBackgrounds.Import(string)`](DateSceneBackgrounds.cs.md#symbol-2c3c4974b94b)；[`NationalSpire.DateSceneBackgrounds.Read(out string, string?)`](DateSceneBackgrounds.cs.md#symbol-b6c3bc7d87d9)

**调用：** [`NationalSpire.DateSceneBackgrounds.SafeId(string)`](DateSceneBackgrounds.cs.md#symbol-19bb6c988fd7)；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.IO.Path.GetFileNameWithoutExtension(string?)`；`string.Replace(char, char)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneBackgrounds.SafeId(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneBackgrounds.SafeId(string)`；输入表达式：`SafeId(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !SafeId(id)`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("背景文件名请使用文字、数字、下划线或短横线（最多100个字符）。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("背景文件名请使用文字、数字、下划线或短横线（最多100个字符）。");`
- `System.IO.Path.GetFileNameWithoutExtension(string?)`；输入表达式：`Path.GetFileNameWithoutExtension(path)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Path.GetFileNameWithoutExtension(path).Replace`
- `string.Replace(char, char)`；输入表达式：`Path.GetFileNameWithoutExtension(path).Replace(' ', '_')`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Path.GetFileNameWithoutExtension(path).Replace(' ', '_')`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d691e3cad5b2"></a>

## `NationalSpire.DateSceneBackgrounds.PackageDirectory — public static string PackageDirectory`

来源：源码第 58 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.OS.GetExecutablePath()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.IO.Path.Combine(string, string)`；`System.IO.Path.Combine(string, string, string, string)`；`System.IO.Path.GetDirectoryName(string?)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.OS.GetExecutablePath()`；输入表达式：`OS.GetExecutablePath()`；返回值紧邻使用处：`ArgumentSyntax: OS.GetExecutablePath()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`candidates.FirstOrDefault(Directory.Exists)`；返回值紧邻使用处：`BinaryExpressionSyntax: candidates.FirstOrDefault(Directory.Exists) ?? candidates[1]`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(assembly, "date-backgrounds")`；返回值紧邻使用处：`ExpressionElementSyntax: Path.Combine(assembly, "date-backgrounds")`
- `System.IO.Path.Combine(string, string, string, string)`；输入表达式：`Path.Combine(executable, "mods", "NationalSpire", "date-backgrounds")`；返回值紧邻使用处：`ExpressionElementSyntax: Path.Combine(executable, "mods", "NationalSpire", "date-backgrounds")`
- `System.IO.Path.GetDirectoryName(string?)`；输入表达式：`Path.GetDirectoryName(OS.GetExecutablePath())`；返回值紧邻使用处：`BinaryExpressionSyntax: Path.GetDirectoryName(OS.GetExecutablePath()) ?? AppContext.BaseDirectory`
- `System.IO.Path.GetDirectoryName(string?)`；输入表达式：`Path.GetDirectoryName(typeof(DateSceneBackgrounds).Assembly.Location)`；返回值紧邻使用处：`BinaryExpressionSyntax: Path.GetDirectoryName(typeof(DateSceneBackgrounds).Assembly.Location) ?? executable`

**赋值（含属性/字段和局部值）：**


<a id="symbol-83be75e40148"></a>

## `NationalSpire.DateSceneBackgrounds.ReadUser() — private static DateBackgroundLibrary ReadUser()`

来源：源码第 68 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneBackgrounds.Describe(string, string)`](DateSceneBackgrounds.cs.md#symbol-c96b7de63f9b)；[`NationalSpire.DateSceneBackgrounds.Import(string)`](DateSceneBackgrounds.cs.md#symbol-2c3c4974b94b)；[`NationalSpire.DateSceneBackgrounds.Read(out string, string?)`](DateSceneBackgrounds.cs.md#symbol-b6c3bc7d87d9)；[`NationalSpire.DateSceneBackgrounds.RegisterLegacy(string)`](DateSceneBackgrounds.cs.md#symbol-7feab11c4c5b)；[`NationalSpire.DateSceneBackgrounds.Remove(string)`](DateSceneBackgrounds.cs.md#symbol-b7d6d0097052)

**调用：** `NationalSpire.DateBackgroundLibrary.DateBackgroundLibrary()`；`System.IO.File.Exists(string?)`；`System.IO.File.ReadAllText(string)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneBackgrounds.FilePath`；`NationalSpire.PortraitDesigns.Json`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateBackgroundLibrary.DateBackgroundLibrary()`；输入表达式：`new()`；返回值紧邻使用处：`BinaryExpressionSyntax: JsonSerializer.Deserialize<DateBackgroundLibrary>(File.ReadAllText(FilePath), PortraitDesigns.Json) ?? new()`
- `NationalSpire.DateBackgroundLibrary.DateBackgroundLibrary()`；输入表达式：`new()`；返回值紧邻使用处：`ConditionalExpressionSyntax: File.Exists(FilePath) ? JsonSerializer.Deserialize<DateBackgroundLibrary>(File.ReadAllText(FilePath), PortraitDesigns.Json) ?? new() : new()`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(FilePath)`；返回值紧邻使用处：`ConditionalExpressionSyntax: File.Exists(FilePath) ? JsonSerializer.Deserialize<DateBackgroundLibrary>(File.ReadAllText(FilePath), PortraitDesigns.Json) ?? new() : new()`
- `System.IO.File.ReadAllText(string)`；输入表达式：`File.ReadAllText(FilePath)`；返回值紧邻使用处：`ArgumentSyntax: File.ReadAllText(FilePath)`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<DateBackgroundLibrary>(File.ReadAllText(FilePath), PortraitDesigns.Json)`；返回值紧邻使用处：`BinaryExpressionSyntax: JsonSerializer.Deserialize<DateBackgroundLibrary>(File.ReadAllText(FilePath), PortraitDesigns.Json) ?? new()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-449c9ebefeb1"></a>

## `NationalSpire.DateSceneBackgrounds.Save(NationalSpire.DateBackgroundLibrary) — private static void Save(DateBackgroundLibrary library)`

来源：源码第 70 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneBackgrounds.Describe(string, string)`](DateSceneBackgrounds.cs.md#symbol-c96b7de63f9b)；[`NationalSpire.DateSceneBackgrounds.Import(string)`](DateSceneBackgrounds.cs.md#symbol-2c3c4974b94b)；[`NationalSpire.DateSceneBackgrounds.RegisterLegacy(string)`](DateSceneBackgrounds.cs.md#symbol-7feab11c4c5b)；[`NationalSpire.DateSceneBackgrounds.Remove(string)`](DateSceneBackgrounds.cs.md#symbol-b7d6d0097052)

**调用：** `System.Guid.NewGuid()`；`System.Guid.ToString(string?)`；`System.IO.Directory.CreateDirectory(string)`；`System.IO.File.Delete(string)`；`System.IO.File.Exists(string?)`；`System.IO.File.Move(string, string, bool)`；`System.IO.File.WriteAllText(string, string?)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneAssetStore.DirectoryPath`；`NationalSpire.DateSceneBackgrounds.FilePath`；`NationalSpire.PortraitDesigns.Json`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`BinaryExpressionSyntax: FilePath + "." + Guid.NewGuid().ToString("N")`
- `System.IO.Directory.CreateDirectory(string)`；输入表达式：`Directory.CreateDirectory(DateSceneAssetStore.DirectoryPath)`；返回值紧邻使用处：`ExpressionStatementSyntax: Directory.CreateDirectory(DateSceneAssetStore.DirectoryPath);`
- `System.IO.File.Delete(string)`；输入表达式：`File.Delete(temporary)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Delete(temporary);`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(temporary)`；返回值紧邻使用处：`IfStatementSyntax: if (File.Exists(temporary)) File.Delete(temporary);`
- `System.IO.File.Move(string, string, bool)`；输入表达式：`File.Move(temporary, FilePath, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Move(temporary, FilePath, true);`
- `System.IO.File.WriteAllText(string, string?)`；输入表达式：`File.WriteAllText(temporary, JsonSerializer.Serialize(library, PortraitDesigns.Json))`；返回值紧邻使用处：`ExpressionStatementSyntax: File.WriteAllText(temporary, JsonSerializer.Serialize(library, PortraitDesigns.Json));`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(library, PortraitDesigns.Json)`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.Serialize(library, PortraitDesigns.Json)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b6c3bc7d87d9"></a>

## `NationalSpire.DateSceneBackgrounds.Read(out string, string?) — public static List<DateSceneBackground> Read(out string warning, string? packageDirectory = null)`

来源：源码第 76 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DateSceneSettings()`](DateSceneScreen.cs.md#symbol-0845ec2acab1)；[`NationalSpire.CareerScreen.OpenDateBackgroundLibrary(NationalSpire.CareerData, string)`](DateSceneBackgroundScreen.cs.md#symbol-887a25fb10fa)；[`NationalSpire.CareerScreen.OpenDateScene(string)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)

**调用：** [`NationalSpire.DateSceneAssetStore.BlobPath(string)`](DateSceneAssets.cs.md#symbol-1b33c2ffb1f6)；[`NationalSpire.DateSceneAssetStore.ImportBackground(string)`](DateSceneAssets.cs.md#symbol-255ccc15c761)；`NationalSpire.DateSceneBackground.DateSceneBackground()`；[`NationalSpire.DateSceneBackgrounds.ImageId(string)`](DateSceneBackgrounds.cs.md#symbol-2aeddbe7d881)；[`NationalSpire.DateSceneBackgrounds.ReadUser()`](DateSceneBackgrounds.cs.md#symbol-83be75e40148)；[`NationalSpire.DateSceneBackgrounds.SafeId(string)`](DateSceneBackgrounds.cs.md#symbol-19bb6c988fd7)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<T>.Order<T>(System.Collections.Generic.IComparer<T>?)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.IO.Directory.EnumerateFiles(string)`；`System.IO.Directory.Exists(string?)`；`System.IO.File.Exists(string?)`；`System.IO.FileInfo.FileInfo(string)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.IO.Path.GetExtension(string?)`；`System.IO.Path.GetFileName(string?)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`string.Replace(char, char)`；`string.ToLowerInvariant()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateBackgroundLibrary.Descriptions`；`NationalSpire.DateBackgroundLibrary.Images`；`NationalSpire.DateBackgroundLibrary.Removed`；`NationalSpire.DateSceneAssetStore.BlobPath(string)`；`NationalSpire.DateSceneAssetStore.ImportBackground(string)`；`NationalSpire.DateSceneBackground.Description`；`NationalSpire.DateSceneBackground.Id`；`NationalSpire.DateSceneBackground.Image`；`NationalSpire.DateSceneBackgrounds.Extensions`；`NationalSpire.DateSceneBackgrounds.ImageId(string)`；`NationalSpire.DateSceneBackgrounds.PackCache`；`NationalSpire.DateSceneBackgrounds.PackageDirectory`；`NationalSpire.DateSceneBackgrounds.ReadUser()`；`NationalSpire.DateSceneBackgrounds.SafeId(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneAssetStore.BlobPath(string)`；输入表达式：`DateSceneAssetStore.BlobPath(cached.Image)`；返回值紧邻使用处：`ArgumentSyntax: DateSceneAssetStore.BlobPath(cached.Image)`
- `NationalSpire.DateSceneAssetStore.BlobPath(string)`；输入表达式：`DateSceneAssetStore.BlobPath(item.Image)`；返回值紧邻使用处：`ArgumentSyntax: DateSceneAssetStore.BlobPath(item.Image)`
- `NationalSpire.DateSceneAssetStore.ImportBackground(string)`；输入表达式：`DateSceneAssetStore.ImportBackground(file)`；返回值紧邻使用处：`ArgumentSyntax: DateSceneAssetStore.ImportBackground(file)`
- `NationalSpire.DateSceneBackground.DateSceneBackground()`；输入表达式：`new() { Id = id, Image = cached.Image, Description = id.Replace('_', ' ').Replace('-', ' ') }`；返回值紧邻使用处：`AssignmentExpressionSyntax: items[id] = new() { Id = id, Image = cached.Image, Description = id.Replace('_', ' ').Replace('-', ' ') }`
- `NationalSpire.DateSceneBackgrounds.ImageId(string)`；输入表达式：`ImageId(file)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ImageId(file)`
- `NationalSpire.DateSceneBackgrounds.ReadUser()`；输入表达式：`ReadUser()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ReadUser()`
- `NationalSpire.DateSceneBackgrounds.SafeId(string)`；输入表达式：`SafeId(item.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !SafeId(item.Id)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`items.ContainsKey(id)`；返回值紧邻使用处：`IfStatementSyntax: if (items.ContainsKey(id)) throw new InvalidDataException("预载背景ID重复：" + id);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, DateSceneBackground>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, DateSceneBackground>()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`items.Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: items.Remove(id);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`PackCache.TryGetValue(file, out var cached)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PackCache.TryGetValue(file, out var cached)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`library.Descriptions.TryGetValue(item.Id, out string? description)`；返回值紧邻使用处：`IfStatementSyntax: if (library.Descriptions.TryGetValue(item.Id, out string? description)) item.Description = description;`
- `System.Collections.Generic.IEnumerable<T>.Order<T>(System.Collections.Generic.IComparer<T>?)`；输入表达式：`Directory.EnumerateFiles(directory).Where(p => Extensions.Contains(Path.GetExtension(p).ToLowerInvariant())).Order(StringComparer.Ordinal)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string file in Directory.EnumerateFiles(directory).Where(p => Extensions.Contains(Path.GetExtension(p).ToLowerInvariant())).Order(StringComparer.Ordinal)) { try { string id = ImageId(file); var info = new FileInfo(file); if (!PackCache.TryGetValue(file, out var cached) || cached.Length != info.Length || cached.Time != info.LastWriteTimeUtc || !File.Exists(DateSceneAssetStore.BlobPath(cached.Image))) { cached = (info.Length, info.LastWriteTimeUtc, DateSceneAssetStore.ImportBackground(file)); PackCache[file] = cached; } if (items.ContainsKey(id)) throw new InvalidDataException("预载背景ID重复：" + id); items[id] = new() { Id = id, Image = cached.Image, Description = id.Replace('_', ' ').Replace('-', ' ') }; } catch (Exception e) { errors.Add(Path.GetFileName(file) + "：" + e.Message); } }`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`Extensions.Contains(Path.GetExtension(p).ToLowerInvariant())`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => Extensions.Contains(Path.GetExtension(p).ToLowerInvariant())`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`items.Values.ToList()`；返回值紧邻使用处：`ReturnStatementSyntax: return items.Values.ToList();`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Directory.EnumerateFiles(directory).Where(p => Extensions.Contains(Path.GetExtension(p).ToLowerInvariant()))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Directory.EnumerateFiles(directory).Where(p => Extensions.Contains(Path.GetExtension(p).ToLowerInvariant())).Order`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`errors.Add("本地背景库：" + e.Message)`；返回值紧邻使用处：`ExpressionStatementSyntax: errors.Add("本地背景库：" + e.Message);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`errors.Add("背景缺失或编号无效：" + item.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: errors.Add("背景缺失或编号无效：" + item.Id);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`errors.Add(Path.GetFileName(file) + "：" + e.Message)`；返回值紧邻使用处：`ExpressionStatementSyntax: errors.Add(Path.GetFileName(file) + "：" + e.Message);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<string>()`
- `System.IO.Directory.EnumerateFiles(string)`；输入表达式：`Directory.EnumerateFiles(directory)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Directory.EnumerateFiles(directory).Where`
- `System.IO.Directory.Exists(string?)`；输入表达式：`Directory.Exists(directory)`；返回值紧邻使用处：`IfStatementSyntax: if (Directory.Exists(directory)) { foreach (string file in Directory.EnumerateFiles(directory).Where(p => Extensions.Contains(Path.GetExtension(p).ToLowerInvariant())).Order(StringComparer.Ordinal)) { try { string id = ImageId(file); var info = new FileInfo(file); if (!PackCache.TryGetValue(file, out var cached) || cached.Length != info.Length || cached.Time != info.LastWriteTimeUtc || !File.Exists(DateSceneAssetStore.BlobPath(cached.Image))) { cached = (info.Length, info.LastWriteTimeUtc, DateSceneAssetStore.ImportBackground(file)); PackCache[file] = cached; } if (items.ContainsKey(id)) throw new InvalidDataException("预载背景ID重复：" + id); items[id] = new() { Id = id, Image = cached.Image, Description = id.Replace('_', ' ').Replace('-', ' ') }; } catch (Exception e) { errors.Add(Path.GetFileName(file) + "：" + e.Message); } } }`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(DateSceneAssetStore.BlobPath(cached.Image))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !File.Exists(DateSceneAssetStore.BlobPath(cached.Image))`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(DateSceneAssetStore.BlobPath(item.Image))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !File.Exists(DateSceneAssetStore.BlobPath(item.Image))`
- `System.IO.FileInfo.FileInfo(string)`；输入表达式：`new FileInfo(file)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new FileInfo(file)`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("预载背景ID重复：" + id)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("预载背景ID重复：" + id);`
- `System.IO.Path.GetExtension(string?)`；输入表达式：`Path.GetExtension(p)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Path.GetExtension(p).ToLowerInvariant`
- `System.IO.Path.GetFileName(string?)`；输入表达式：`Path.GetFileName(file)`；返回值紧邻使用处：`BinaryExpressionSyntax: Path.GetFileName(file) + "："`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n", errors)`；返回值紧邻使用处：`AssignmentExpressionSyntax: warning = string.Join("\n", errors)`
- `string.Replace(char, char)`；输入表达式：`id.Replace('_', ' ')`；返回值紧邻使用处：`MemberAccessExpressionSyntax: id.Replace('_', ' ').Replace`
- `string.Replace(char, char)`；输入表达式：`id.Replace('_', ' ').Replace('-', ' ')`；返回值紧邻使用处：`AssignmentExpressionSyntax: Description = id.Replace('_', ' ').Replace('-', ' ')`
- `string.ToLowerInvariant()`；输入表达式：`Path.GetExtension(p).ToLowerInvariant()`；返回值紧邻使用处：`ArgumentSyntax: Path.GetExtension(p).ToLowerInvariant()`

**赋值（含属性/字段和局部值）：**

- `Description` = `id.Replace('_', ' ').Replace('-', ' ')`
- `Id` = `id`
- `Image` = `cached.Image`
- `PackCache[file]` = `cached`
- `cached` = `(info.Length, info.LastWriteTimeUtc, DateSceneAssetStore.ImportBackground(file))`
- `item.Description` = `description`
- `items[id]` = `new() { Id = id, Image = cached.Image, Description = id.Replace('_', ' ').Replace('-', ' ') }`
- `items[item.Id]` = `item`
- `warning` = `string.Join("\n", errors)`

<a id="symbol-c96b7de63f9b"></a>

## `NationalSpire.DateSceneBackgrounds.Describe(string, string) — public static void Describe(string id, string description)`

来源：源码第 111 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Commit()`](DateSceneBackgroundScreen.cs.md#symbol-975117ecae31)

**调用：** [`NationalSpire.DateSceneBackgrounds.ReadUser()`](DateSceneBackgrounds.cs.md#symbol-83be75e40148)；[`NationalSpire.DateSceneBackgrounds.SafeId(string)`](DateSceneBackgrounds.cs.md#symbol-19bb6c988fd7)；[`NationalSpire.DateSceneBackgrounds.Save(NationalSpire.DateBackgroundLibrary)`](DateSceneBackgrounds.cs.md#symbol-449c9ebefeb1)；`System.IO.InvalidDataException.InvalidDataException(string?)`；`string.Trim()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateBackgroundLibrary.Descriptions`；`NationalSpire.DateSceneBackgrounds.ReadUser()`；`NationalSpire.DateSceneBackgrounds.SafeId(string)`；`NationalSpire.DateSceneBackgrounds.Save(NationalSpire.DateBackgroundLibrary)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneBackgrounds.ReadUser()`；输入表达式：`ReadUser()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ReadUser()`
- `NationalSpire.DateSceneBackgrounds.SafeId(string)`；输入表达式：`SafeId(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !SafeId(id)`
- `NationalSpire.DateSceneBackgrounds.Save(NationalSpire.DateBackgroundLibrary)`；输入表达式：`Save(library)`；返回值紧邻使用处：`ExpressionStatementSyntax: Save(library);`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("背景ID无效。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("背景ID无效。");`
- `string.Trim()`；输入表达式：`description.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: library.Descriptions[id] = description.Trim()`

**赋值（含属性/字段和局部值）：**

- `library.Descriptions[id]` = `description.Trim()`

<a id="symbol-b7d6d0097052"></a>

## `NationalSpire.DateSceneBackgrounds.Remove(string) — public static void Remove(string id)`

来源：源码第 116 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DateSceneSettings()`](DateSceneScreen.cs.md#symbol-0845ec2acab1)；[`NationalSpire.CareerScreen.OpenDateBackgroundLibrary(NationalSpire.CareerData, string)`](DateSceneBackgroundScreen.cs.md#symbol-887a25fb10fa)

**调用：** [`NationalSpire.DateSceneBackgrounds.ReadUser()`](DateSceneBackgrounds.cs.md#symbol-83be75e40148)；[`NationalSpire.DateSceneBackgrounds.SafeId(string)`](DateSceneBackgrounds.cs.md#symbol-19bb6c988fd7)；[`NationalSpire.DateSceneBackgrounds.Save(NationalSpire.DateBackgroundLibrary)`](DateSceneBackgrounds.cs.md#symbol-449c9ebefeb1)；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；`System.IO.InvalidDataException.InvalidDataException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateBackgroundLibrary.Descriptions`；`NationalSpire.DateBackgroundLibrary.Images`；`NationalSpire.DateBackgroundLibrary.Removed`；`NationalSpire.DateSceneBackground.Id`；`NationalSpire.DateSceneBackgrounds.ReadUser()`；`NationalSpire.DateSceneBackgrounds.SafeId(string)`；`NationalSpire.DateSceneBackgrounds.Save(NationalSpire.DateBackgroundLibrary)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneBackgrounds.ReadUser()`；输入表达式：`ReadUser()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ReadUser()`
- `NationalSpire.DateSceneBackgrounds.SafeId(string)`；输入表达式：`SafeId(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !SafeId(id)`
- `NationalSpire.DateSceneBackgrounds.Save(NationalSpire.DateBackgroundLibrary)`；输入表达式：`Save(library)`；返回值紧邻使用处：`ExpressionStatementSyntax: Save(library);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`library.Descriptions.Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: library.Descriptions.Remove(id);`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`library.Removed.Add(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: library.Removed.Add(id);`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`library.Images.RemoveAll(b => b.Id == id)`；返回值紧邻使用处：`ExpressionStatementSyntax: library.Images.RemoveAll(b => b.Id == id);`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("背景ID无效。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("背景ID无效。");`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7feab11c4c5b"></a>

## `NationalSpire.DateSceneBackgrounds.RegisterLegacy(string) — public static string RegisterLegacy(string image)`

来源：源码第 121 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenDateScene(string)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)

**调用：** [`NationalSpire.DateSceneAssetStore.Texture(string, bool)`](DateSceneAssets.cs.md#symbol-616d47ee9d6a)；`NationalSpire.DateSceneBackground.DateSceneBackground()`；[`NationalSpire.DateSceneBackgrounds.ReadUser()`](DateSceneBackgrounds.cs.md#symbol-83be75e40148)；[`NationalSpire.DateSceneBackgrounds.Save(NationalSpire.DateBackgroundLibrary)`](DateSceneBackgrounds.cs.md#symbol-449c9ebefeb1)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateBackgroundLibrary.Images`；`NationalSpire.DateSceneAssetStore.Texture(string, bool)`；`NationalSpire.DateSceneBackground.Description`；`NationalSpire.DateSceneBackground.Id`；`NationalSpire.DateSceneBackground.Image`；`NationalSpire.DateSceneBackgrounds.ReadUser()`；`NationalSpire.DateSceneBackgrounds.Save(NationalSpire.DateBackgroundLibrary)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneAssetStore.Texture(string, bool)`；输入表达式：`DateSceneAssetStore.Texture(image, false)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateSceneAssetStore.Texture(image, false)`
- `NationalSpire.DateSceneBackground.DateSceneBackground()`；输入表达式：`new() { Id = id, Image = image, Description = "原先导入的背景；可在背景库补充地点与时间说明" }`；返回值紧邻使用处：`ArgumentSyntax: new() { Id = id, Image = image, Description = "原先导入的背景；可在背景库补充地点与时间说明" }`
- `NationalSpire.DateSceneBackgrounds.ReadUser()`；输入表达式：`ReadUser()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ReadUser()`
- `NationalSpire.DateSceneBackgrounds.Save(NationalSpire.DateBackgroundLibrary)`；输入表达式：`Save(library)`；返回值紧邻使用处：`ExpressionStatementSyntax: Save(library);`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`library.Images.FirstOrDefault(i => i.Image == image)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = library.Images.FirstOrDefault(i => i.Image == image)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`library.Images.Add(new() { Id = id, Image = image, Description = "原先导入的背景；可在背景库补充地点与时间说明" })`；返回值紧邻使用处：`ExpressionStatementSyntax: library.Images.Add(new() { Id = id, Image = image, Description = "原先导入的背景；可在背景库补充地点与时间说明" });`

**赋值（含属性/字段和局部值）：**

- `Description` = `"原先导入的背景；可在背景库补充地点与时间说明"`
- `Id` = `id`
- `Image` = `image`

<a id="symbol-2c3c4974b94b"></a>

## `NationalSpire.DateSceneBackgrounds.Import(string) — public static string Import(string path)`

来源：源码第 129 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DateSceneSettings()`](DateSceneScreen.cs.md#symbol-0845ec2acab1)；[`NationalSpire.CareerScreen.OpenDateBackgroundLibrary(NationalSpire.CareerData, string)`](DateSceneBackgroundScreen.cs.md#symbol-887a25fb10fa)

**调用：** [`NationalSpire.DateSceneAssetStore.ImportBackground(string)`](DateSceneAssets.cs.md#symbol-255ccc15c761)；[`NationalSpire.DateSceneAssetStore.ImportBackgroundBytes(byte[], string)`](DateSceneAssets.cs.md#symbol-d04a3543dc27)；`NationalSpire.DateSceneBackground.DateSceneBackground()`；[`NationalSpire.DateSceneBackgrounds.ImageId(string)`](DateSceneBackgrounds.cs.md#symbol-2aeddbe7d881)；[`NationalSpire.DateSceneBackgrounds.ReadUser()`](DateSceneBackgrounds.cs.md#symbol-83be75e40148)；[`NationalSpire.DateSceneBackgrounds.Save(NationalSpire.DateBackgroundLibrary)`](DateSceneBackgrounds.cs.md#symbol-449c9ebefeb1)；`System.Collections.Generic.HashSet<T>.Remove(T)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；`System.IO.Compression.ZipArchiveEntry.Open()`；`System.IO.Compression.ZipFile.OpenRead(string)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.IO.MemoryStream.MemoryStream()`；`System.IO.MemoryStream.ToArray()`；`System.IO.Path.GetExtension(string?)`；`System.IO.Stream.CopyTo(System.IO.Stream)`；`string.Contains(char)`；`string.Equals(string?, System.StringComparison)`；`string.Replace(char, char)`；`string.Split(char, System.StringSplitOptions)`；`string.StartsWith(char)`；`string.StartsWith(string)`；`string.ToLowerInvariant()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateBackgroundLibrary.Images`；`NationalSpire.DateBackgroundLibrary.Removed`；`NationalSpire.DateSceneAssetStore.ImportBackground(string)`；`NationalSpire.DateSceneAssetStore.ImportBackgroundBytes(byte[], string)`；`NationalSpire.DateSceneBackground.Description`；`NationalSpire.DateSceneBackground.Id`；`NationalSpire.DateSceneBackground.Image`；`NationalSpire.DateSceneBackgrounds.Extensions`；`NationalSpire.DateSceneBackgrounds.ImageId(string)`；`NationalSpire.DateSceneBackgrounds.ReadUser()`；`NationalSpire.DateSceneBackgrounds.Save(NationalSpire.DateBackgroundLibrary)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneAssetStore.ImportBackground(string)`；输入表达式：`DateSceneAssetStore.ImportBackground(path)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Image = DateSceneAssetStore.ImportBackground(path)`
- `NationalSpire.DateSceneAssetStore.ImportBackgroundBytes(byte[], string)`；输入表达式：`DateSceneAssetStore.ImportBackgroundBytes(output.ToArray(), Path.GetExtension(entry.Name))`；返回值紧邻使用处：`AssignmentExpressionSyntax: Image = DateSceneAssetStore.ImportBackgroundBytes(output.ToArray(), Path.GetExtension(entry.Name))`
- `NationalSpire.DateSceneBackground.DateSceneBackground()`；输入表达式：`new() { Id = id, Image = DateSceneAssetStore.ImportBackground(path), Description = id.Replace('_', ' ').Replace('-', ' ') }`；返回值紧邻使用处：`ArgumentSyntax: new() { Id = id, Image = DateSceneAssetStore.ImportBackground(path), Description = id.Replace('_', ' ').Replace('-', ' ') }`
- `NationalSpire.DateSceneBackground.DateSceneBackground()`；输入表达式：`new() { Id = id, Image = DateSceneAssetStore.ImportBackgroundBytes(output.ToArray(), Path.GetExtension(entry.Name)), Description = id.Replace('_', ' ').Replace('-', ' ') }`；返回值紧邻使用处：`ArgumentSyntax: new() { Id = id, Image = DateSceneAssetStore.ImportBackgroundBytes(output.ToArray(), Path.GetExtension(entry.Name)), Description = id.Replace('_', ' ').Replace('-', ' ') }`
- `NationalSpire.DateSceneBackgrounds.ImageId(string)`；输入表达式：`ImageId(entry.Name)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ImageId(entry.Name)`
- `NationalSpire.DateSceneBackgrounds.ImageId(string)`；输入表达式：`ImageId(path)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ImageId(path)`
- `NationalSpire.DateSceneBackgrounds.ReadUser()`；输入表达式：`ReadUser()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ReadUser()`
- `NationalSpire.DateSceneBackgrounds.Save(NationalSpire.DateBackgroundLibrary)`；输入表达式：`Save(library)`；返回值紧邻使用处：`ExpressionStatementSyntax: Save(library);`
- `System.Collections.Generic.HashSet<T>.Remove(T)`；输入表达式：`library.Removed.Remove(item.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: library.Removed.Remove(item.Id);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`added.Any(i => i.Id == id)`；返回值紧邻使用处：`IfStatementSyntax: if (added.Any(i => i.Id == id)) throw new InvalidDataException("背景包中的ID重复：" + id);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`entry.FullName.Split('/').Any(p => p is ".." or "." || p.Contains(':'))`；返回值紧邻使用处：`BinaryExpressionSyntax: entry.FullName.Contains('\\') || entry.FullName.StartsWith('/') || entry.FullName.Split('/').Any(p => p is ".." or "." || p.Contains(':'))`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`Extensions.Contains(Path.GetExtension(e.Name).ToLowerInvariant())`；返回值紧邻使用处：`BinaryExpressionSyntax: Extensions.Contains(Path.GetExtension(e.Name).ToLowerInvariant()) && !e.FullName.StartsWith("__MACOSX/")`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`archive.Entries.Where(e => Extensions.Contains(Path.GetExtension(e.Name).ToLowerInvariant()) && !e.FullName.StartsWith("__MACOSX/"))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var entry in archive.Entries.Where(e => Extensions.Contains(Path.GetExtension(e.Name).ToLowerInvariant()) && !e.FullName.StartsWith("__MACOSX/"))) { if (entry.FullName.Contains('\\') || entry.FullName.StartsWith('/') || entry.FullName.Split('/').Any(p => p is ".." or "." || p.Contains(':'))) throw new InvalidDataException("背景包中的图片路径无效。"); string id = ImageId(entry.Name); total += entry.Length; if (added.Any(i => i.Id == id)) throw new InvalidDataException("背景包中的ID重复：" + id); if (entry.Length > 64 * 1024 * 1024 || total > 512L * 1024 * 1024) throw new InvalidDataException("背景包过大，请分批导入。"); using var input = entry.Open(); using var output = new MemoryStream(); input.CopyTo(output); added.Add(new() { Id = id, Image = DateSceneAssetStore.ImportBackgroundBytes(output.ToArray(), Path.GetExtension(entry.Name)), Description = id.Replace('_', ' ').Replace('-', ' ') }); }`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`added.Add(new() { Id = id, Image = DateSceneAssetStore.ImportBackground(path), Description = id.Replace('_', ' ').Replace('-', ' ') })`；返回值紧邻使用处：`ExpressionStatementSyntax: added.Add(new() { Id = id, Image = DateSceneAssetStore.ImportBackground(path), Description = id.Replace('_', ' ').Replace('-', ' ') });`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`added.Add(new() { Id = id, Image = DateSceneAssetStore.ImportBackgroundBytes(output.ToArray(), Path.GetExtension(entry.Name)), Description = id.Replace('_', ' ').Replace('-', ' ') })`；返回值紧邻使用处：`ExpressionStatementSyntax: added.Add(new() { Id = id, Image = DateSceneAssetStore.ImportBackgroundBytes(output.ToArray(), Path.GetExtension(entry.Name)), Description = id.Replace('_', ' ').Replace('-', ' ') });`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`library.Images.Add(item)`；返回值紧邻使用处：`ExpressionStatementSyntax: library.Images.Add(item);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<DateSceneBackground>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<DateSceneBackground>()`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`library.Images.RemoveAll(i => i.Id == item.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: library.Images.RemoveAll(i => i.Id == item.Id);`
- `System.IO.Compression.ZipArchiveEntry.Open()`；输入表达式：`entry.Open()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = entry.Open()`
- `System.IO.Compression.ZipFile.OpenRead(string)`；输入表达式：`ZipFile.OpenRead(path)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ZipFile.OpenRead(path)`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("背景包中没有PNG、JPG或WebP图片。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("背景包中没有PNG、JPG或WebP图片。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("背景包中的ID重复：" + id)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("背景包中的ID重复：" + id);`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("背景包中的图片路径无效。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("背景包中的图片路径无效。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("背景包过大，请分批导入。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("背景包过大，请分批导入。");`
- `System.IO.MemoryStream.MemoryStream()`；输入表达式：`new MemoryStream()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MemoryStream()`
- `System.IO.MemoryStream.ToArray()`；输入表达式：`output.ToArray()`；返回值紧邻使用处：`ArgumentSyntax: output.ToArray()`
- `System.IO.Path.GetExtension(string?)`；输入表达式：`Path.GetExtension(e.Name)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Path.GetExtension(e.Name).ToLowerInvariant`
- `System.IO.Path.GetExtension(string?)`；输入表达式：`Path.GetExtension(entry.Name)`；返回值紧邻使用处：`ArgumentSyntax: Path.GetExtension(entry.Name)`
- `System.IO.Path.GetExtension(string?)`；输入表达式：`Path.GetExtension(path)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Path.GetExtension(path).Equals`
- `System.IO.Stream.CopyTo(System.IO.Stream)`；输入表达式：`input.CopyTo(output)`；返回值紧邻使用处：`ExpressionStatementSyntax: input.CopyTo(output);`
- `string.Contains(char)`；输入表达式：`entry.FullName.Contains('\\')`；返回值紧邻使用处：`BinaryExpressionSyntax: entry.FullName.Contains('\\') || entry.FullName.StartsWith('/')`
- `string.Contains(char)`；输入表达式：`p.Contains(':')`；返回值紧邻使用处：`BinaryExpressionSyntax: p is ".." or "." || p.Contains(':')`
- `string.Equals(string?, System.StringComparison)`；输入表达式：`Path.GetExtension(path).Equals(".zip", StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`IfStatementSyntax: if (Path.GetExtension(path).Equals(".zip", StringComparison.OrdinalIgnoreCase)) { using var archive = ZipFile.OpenRead(path); long total = 0; foreach (var entry in archive.Entries.Where(e => Extensions.Contains(Path.GetExtension(e.Name).ToLowerInvariant()) && !e.FullName.StartsWith("__MACOSX/"))) { if (entry.FullName.Contains('\\') || entry.FullName.StartsWith('/') || entry.FullName.Split('/').Any(p => p is ".." or "." || p.Contains(':'))) throw new InvalidDataException("背景包中的图片路径无效。"); string id = ImageId(entry.Name); total += entry.Length; if (added.Any(i => i.Id == id)) throw new InvalidDataException("背景包中的ID重复：" + id); if (entry.Length > 64 * 1024 * 1024 || total > 512L * 1024 * 1024) throw new InvalidDataException("背景包过大，请分批导入。"); using var input = entry.Open(); using var output = new MemoryStream(); input.CopyTo(output); added.Add(new() { Id = id, Image = DateSceneAssetStore.ImportBackgroundBytes(output.ToArray(), Path.GetExtension(entry.Name)), Description = id.Replace('_', ' ').Replace('-', ' ') }); } } else { string id = ImageId(path); added.Add(new() { Id = id, Image = DateSceneAssetStore.ImportBackground(path), Description = id.Replace('_', ' ').Replace('-', ' ') }); }`
- `string.Replace(char, char)`；输入表达式：`id.Replace('_', ' ')`；返回值紧邻使用处：`MemberAccessExpressionSyntax: id.Replace('_', ' ').Replace`
- `string.Replace(char, char)`；输入表达式：`id.Replace('_', ' ').Replace('-', ' ')`；返回值紧邻使用处：`AssignmentExpressionSyntax: Description = id.Replace('_', ' ').Replace('-', ' ')`
- `string.Split(char, System.StringSplitOptions)`；输入表达式：`entry.FullName.Split('/')`；返回值紧邻使用处：`MemberAccessExpressionSyntax: entry.FullName.Split('/').Any`
- `string.StartsWith(char)`；输入表达式：`entry.FullName.StartsWith('/')`；返回值紧邻使用处：`BinaryExpressionSyntax: entry.FullName.Contains('\\') || entry.FullName.StartsWith('/')`
- `string.StartsWith(string)`；输入表达式：`e.FullName.StartsWith("__MACOSX/")`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !e.FullName.StartsWith("__MACOSX/")`
- `string.ToLowerInvariant()`；输入表达式：`Path.GetExtension(e.Name).ToLowerInvariant()`；返回值紧邻使用处：`ArgumentSyntax: Path.GetExtension(e.Name).ToLowerInvariant()`

**赋值（含属性/字段和局部值）：**

- `Description` = `id.Replace('_', ' ').Replace('-', ' ')`
- `Id` = `id`
- `Image` = `DateSceneAssetStore.ImportBackground(path)`
- `Image` = `DateSceneAssetStore.ImportBackgroundBytes(output.ToArray(), Path.GetExtension(entry.Name))`
- `total` += `entry.Length`
