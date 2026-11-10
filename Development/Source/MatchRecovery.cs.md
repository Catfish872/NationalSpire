# MatchRecovery.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`A7E6AF0C29E50ED2EAFCE05EE1FDF3D2A01BE8150D09B51AAFA710D49121159E`。来源：[源码](../../MatchRecovery.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.MatchRecovery`。

字段、事件及初始值（源码原样）：

```csharp
public const string SingleplayerInUse = "请在主菜单手动放弃当前对局，或切回对应生涯完成对局。";
```

<a id="symbol-c41f1e6650d2"></a>

## `NationalSpire.MatchRecovery.HistoryCandidates(System.Collections.Generic.IEnumerable<string>, long) — public static IEnumerable<string> HistoryCandidates(IEnumerable<string> files, long pendingSince)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameBridge.RecoverPending()`](GameBridge.cs.md#symbol-7e7d899f5086)

**调用：** `long.TryParse(string?, out long)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.IO.Path.GetFileNameWithoutExtension(string?)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `long.TryParse(string?, out long)`；输入表达式：`long.TryParse(Path.GetFileNameWithoutExtension(file), out long time)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !long.TryParse(Path.GetFileNameWithoutExtension(file), out long time)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`files         .Where(file => pendingSince <= 0 || !long.TryParse(Path.GetFileNameWithoutExtension(file), out long time) || time >= pendingSince - 5)         .OrderByDescending(file => file, StringComparer.Ordinal)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => files         .Where(file => pendingSince <= 0 || !long.TryParse(Path.GetFileNameWithoutExtension(file), out long time) || time >= pendingSince - 5)         .OrderByDescending(file => file, StringComparer.Ordinal)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`files         .Where(file => pendingSince <= 0 || !long.TryParse(Path.GetFileNameWithoutExtension(file), out long time) || time >= pendingSince - 5)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: files         .Where(file => pendingSince <= 0 || !long.TryParse(Path.GetFileNameWithoutExtension(file), out long time) || time >= pendingSince - 5)         .OrderByDescending`
- `System.IO.Path.GetFileNameWithoutExtension(string?)`；输入表达式：`Path.GetFileNameWithoutExtension(file)`；返回值紧邻使用处：`ArgumentSyntax: Path.GetFileNameWithoutExtension(file)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b40088da85fc"></a>

## `NationalSpire.MatchRecovery.Message(bool, bool, bool) — public static string Message(bool multiplayer, bool hasSave, bool inProgress)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameBridge.RecoveryMessageFor(bool)`](GameBridge.cs.md#symbol-6b85087ac133)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.MatchRecovery.SingleplayerInUse`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**
