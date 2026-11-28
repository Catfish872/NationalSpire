# Compatibility/LeagueSolver/LeagueDuelScore.cs

[返回文件依赖索引](../../../SOURCE_MAP.md)

源码 SHA-256：`73CDDF272D347C5FBA0F5EDF7D6746246185EF4432D2FCF9CDB74BC43EFE0E8F`。来源：[源码](../../../../Compatibility/LeagueSolver/LeagueDuelScore.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Solver.LeagueDuelScore`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-ac2308975249"></a>

## `NationalSpire.Solver.LeagueDuelScore.Defender(int, int, bool, decimal, int) — internal static decimal Defender(int hp, int deferredDoom, bool dead, decimal setupScore, int stars)`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Evaluate(NationalSpire.Solver.LeagueForecast.Branch, out bool)`](LeagueForecast.cs.md#symbol-cee91d662755)

**调用：** `System.Math.Max(decimal, decimal)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Max(decimal, decimal)`；输入表达式：`Math.Max(.1m, hp - deferredDoom * .85m)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Max(.1m, hp - deferredDoom * .85m) * 1.6m`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f6d16ee490cf"></a>

## `NationalSpire.Solver.LeagueDuelScore.ForgedBlade(int, int) — internal static decimal ForgedBlade(int damage, int enemyHp)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Evaluate(NationalSpire.Solver.LeagueForecast.Branch, out bool)`](LeagueForecast.cs.md#symbol-cee91d662755)

**调用：** `System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Min(int, int)`；输入表达式：`Math.Min(damage, enemyHp)`；返回值紧邻使用处：`BinaryExpressionSyntax: .65m * Math.Min(damage, enemyHp)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b46044fcf41a"></a>

## `NationalSpire.Solver.LeagueDuelScore.Opponent(int, int, int, int, int, int, int, int, bool) — internal static decimal Opponent(int initialHp, int initialBlock, int hp, int attack, int through,         int poison, int activeDoom, int deferredDoom, bool defenderDead)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Evaluate(NationalSpire.Solver.LeagueForecast.Branch, out bool)`](LeagueForecast.cs.md#symbol-cee91d662755)

**调用：** `System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Min(int, int)`；输入表达式：`Math.Min(initialHp + initialBlock, attack + initialHp - hp)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Min(initialHp + initialBlock, attack + initialHp - hp)             + 1.5m * poison`

**赋值（含属性/字段和局部值）：**

- `value` += `initialHp`

<a id="symbol-3af1814ad272"></a>

## `NationalSpire.Solver.LeagueDuelScore.Continue(decimal, int, int) — internal static decimal Continue(decimal endScore, int usableCards, int energy)`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Expand(NationalSpire.Solver.LeagueForecast.Branch, System.Func<bool>)`](LeagueForecast.cs.md#symbol-24851435ee76)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**
