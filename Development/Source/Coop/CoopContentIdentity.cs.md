# Coop/CoopContentIdentity.cs

[返回文件依赖索引](../../SOURCE_MAP.md)

源码 SHA-256：`E70353CCB1D357E600737FA3887EFFEDA98EACB97AC1F679EB57A98BC946B990`。来源：[源码](../../../Coop/CoopContentIdentity.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Coop.CoopContentIdentity`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-e677ecf56ae1"></a>

## `NationalSpire.Coop.CoopContentIdentity.Create(string, uint, System.Collections.Generic.IEnumerable<string>?) — public static string Create(string release, uint gameContent, IEnumerable<string>? mods = null)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRuntime.Compatibility`](CoopRuntime.cs.md#symbol-252dd3ac9940)

**调用：** `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`string.StartsWith(string, System.StringComparison)`；`System.Collections.Generic.IEnumerable<T>.Order<T>(System.Collections.Generic.IComparer<T>?)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Convert.ToHexString(byte[])`；`System.Text.Encoding.GetBytes(string)`；`uint.ToString(System.IFormatProvider?)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n", wire)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = string.Join("\n", wire)`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`m.StartsWith("sts2_lan_connect_wire:", StringComparison.Ordinal)`；返回值紧邻使用处：`BinaryExpressionSyntax: m.StartsWith("sts2_lan_connect-", StringComparison.Ordinal)             || m.StartsWith("sts2_lan_connect_wire:", StringComparison.Ordinal)`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`m.StartsWith("sts2_lan_connect-", StringComparison.Ordinal)`；返回值紧邻使用处：`BinaryExpressionSyntax: m.StartsWith("sts2_lan_connect-", StringComparison.Ordinal)             || m.StartsWith("sts2_lan_connect_wire:", StringComparison.Ordinal)`
- `System.Collections.Generic.IEnumerable<T>.Order<T>(System.Collections.Generic.IComparer<T>?)`；输入表达式：`(mods ?? []).Where(m => m.StartsWith("sts2_lan_connect-", StringComparison.Ordinal)             || m.StartsWith("sts2_lan_connect_wire:", StringComparison.Ordinal)).Distinct().Order(StringComparer.Ordinal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = (mods ?? []).Where(m => m.StartsWith("sts2_lan_connect-", StringComparison.Ordinal)             || m.StartsWith("sts2_lan_connect_wire:", StringComparison.Ordinal)).Distinct().Order(StringComparer.Ordinal)`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`(mods ?? []).Where(m => m.StartsWith("sts2_lan_connect-", StringComparison.Ordinal)             || m.StartsWith("sts2_lan_connect_wire:", StringComparison.Ordinal)).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: (mods ?? []).Where(m => m.StartsWith("sts2_lan_connect-", StringComparison.Ordinal)             || m.StartsWith("sts2_lan_connect_wire:", StringComparison.Ordinal)).Distinct().Order`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`(mods ?? []).Where(m => m.StartsWith("sts2_lan_connect-", StringComparison.Ordinal)             || m.StartsWith("sts2_lan_connect_wire:", StringComparison.Ordinal))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: (mods ?? []).Where(m => m.StartsWith("sts2_lan_connect-", StringComparison.Ordinal)             || m.StartsWith("sts2_lan_connect_wire:", StringComparison.Ordinal)).Distinct`
- `System.Convert.ToHexString(byte[])`；输入表达式：`Convert.ToHexString(Encoding.UTF8.GetBytes(signature))`；返回值紧邻使用处：`BinaryExpressionSyntax: identity + "/" + Convert.ToHexString(Encoding.UTF8.GetBytes(signature))`
- `System.Text.Encoding.GetBytes(string)`；输入表达式：`Encoding.UTF8.GetBytes(signature)`；返回值紧邻使用处：`ArgumentSyntax: Encoding.UTF8.GetBytes(signature)`
- `uint.ToString(System.IFormatProvider?)`；输入表达式：`gameContent.ToString(CultureInfo.InvariantCulture)`；返回值紧邻使用处：`BinaryExpressionSyntax: "release/" + release + "/" + gameContent.ToString(CultureInfo.InvariantCulture)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-71a611ce4e39"></a>

## `NationalSpire.Coop.CoopContentIdentity.Difference(string, string) — public static string? Difference(string local, string remote)`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.Receive(ulong, NationalSpire.Coop.CoopWire)`](CoopCoordinator.cs.md#symbol-892f19740afa)

**调用：** `string.Split(char, System.StringSplitOptions)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Split(char, System.StringSplitOptions)`；输入表达式：`local.Split('/')`；返回值紧邻使用处：`EqualsValueClauseSyntax: = local.Split('/')`
- `string.Split(char, System.StringSplitOptions)`；输入表达式：`remote.Split('/')`；返回值紧邻使用处：`EqualsValueClauseSyntax: = remote.Split('/')`

**赋值（含属性/字段和局部值）：**
