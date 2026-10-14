# RelicArt.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`2750EE9F4B1B290527E8F2843B6981730A1BA2D6D525831332AA134F82BF4063`。来源：[源码](../../RelicArt.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.RelicArt`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly Dictionary<string, Texture2D> Cache = [];
```

<a id="symbol-1d35c476ee42"></a>

## `NationalSpire.RelicArt.Read(string) — internal static Texture2D? Read(string id)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerListCache._Process(double)`](CareerListCache.cs.md#symbol-e8085c360313)；[`NationalSpire.CareerScreen.FigurineCard(NationalSpire.CareerData, Godot.GridContainer, NationalSpire.CareerRelics.Item, bool)`](LifeScreen.cs.md#symbol-8732620351f6)

**调用：** [`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.ResourceLoader.Exists(string, string)`；`Godot.ResourceLoader.Load<T>(string, string, Godot.ResourceLoader.CacheMode)`；`string.ToLowerInvariant()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.RelicArt.Cache`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(cached)`；返回值紧邻使用处：`BinaryExpressionSyntax: Cache.TryGetValue(id, out var cached) && GodotObject.IsInstanceValid(cached)`
- `Godot.ResourceLoader.Exists(string, string)`；输入表达式：`ResourceLoader.Exists(path)`；返回值紧邻使用处：`BinaryExpressionSyntax: ResourceLoader.Exists(path) && ResourceLoader.Load<Texture2D>(path) is { } texture`
- `Godot.ResourceLoader.Load<T>(string, string, Godot.ResourceLoader.CacheMode)`；输入表达式：`ResourceLoader.Load<Texture2D>(path)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ResourceLoader.Load<Texture2D>(path) is { } texture`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("figurine.art." + id, e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("figurine.art." + id, e);`
- `string.ToLowerInvariant()`；输入表达式：`id.ToLowerInvariant()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = id.ToLowerInvariant()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Cache.TryGetValue(id, out var cached)`；返回值紧邻使用处：`BinaryExpressionSyntax: Cache.TryGetValue(id, out var cached) && GodotObject.IsInstanceValid(cached)`

**赋值（含属性/字段和局部值）：**

- `Cache[id]` = `texture`
