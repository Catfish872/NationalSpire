# Coop/CoopMarket.cs

[返回文件依赖索引](../../SOURCE_MAP.md)

源码 SHA-256：`6E45D9F9A0783DCAEF1753F0EEE189E0F576C1DA3F8EC22B22BF4170520FF18A`。来源：[源码](../../../Coop/CoopMarket.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Coop.CoopRules`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-a60daf1be116"></a>

## `NationalSpire.Coop.CoopRules.Trade(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.MarketOrder) — private static string? Trade(CoopWorld transaction, CoopMember member, MarketOrder order)`

来源：源码第 5 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](CoopRules.cs.md#symbol-71eae0adc0d0)

**调用：** [`NationalSpire.CareerMarket.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder)`](../CareerMarket.cs.md#symbol-6b9ac5b0686c)；`NationalSpire.CareerData.CareerData()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Credits`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Market`；`NationalSpire.CareerMarket.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder)`；`NationalSpire.Coop.CoopMember.Credits`；`NationalSpire.Coop.CoopMember.Life`；`NationalSpire.Coop.CoopWorld.World`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerData.CareerData()`；输入表达式：`new CareerData { Day = transaction.World.Day, Market = transaction.World.Market, Credits = member.Credits, Life = member.Life }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CareerData { Day = transaction.World.Day, Market = transaction.World.Market, Credits = member.Credits, Life = member.Life }`
- `NationalSpire.CareerMarket.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder)`；输入表达式：`CareerMarket.Trade(data, order)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerMarket.Trade(data, order)`

**赋值（含属性/字段和局部值）：**

- `Credits` = `member.Credits`
- `Day` = `transaction.World.Day`
- `Life` = `member.Life`
- `Market` = `transaction.World.Market`
- `member.Credits` = `data.Credits`

<a id="symbol-b6088377cb72"></a>

## `NationalSpire.Coop.CoopRules.BindMarket(NationalSpire.Coop.CoopWorld) — private static void BindMarket(CoopWorld world)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](CoopRules.cs.md#symbol-71eae0adc0d0)；[`NationalSpire.Coop.CoopRules.Settle(NationalSpire.Coop.CoopWorld, string, bool, bool, int, double, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer>, System.Collections.Generic.Dictionary<ulong, NationalSpire.CareerResult>?, bool, bool, bool)`](CoopRules.cs.md#symbol-926ebe8770ca)

**调用：** [`NationalSpire.CareerMarket.Account(NationalSpire.MarketState, NationalSpire.MarketAccount, int)`](../CareerMarket.cs.md#symbol-a92beec78217)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Market`；`NationalSpire.CareerData.MarketAccounts`；`NationalSpire.CareerData.MarketSponsors`；`NationalSpire.CareerLifeState.Trading`；`NationalSpire.CareerMarket.Account(NationalSpire.MarketState, NationalSpire.MarketAccount, int)`；`NationalSpire.Coop.CoopMember.Life`；`NationalSpire.Coop.CoopMember.PersonId`；`NationalSpire.Coop.CoopMember.Sponsors`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopRun.Characters`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.SponsorContract.TargetId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMarket.Account(NationalSpire.MarketState, NationalSpire.MarketAccount, int)`；输入表达式：`CareerMarket.Account(data.Market, member.Life.Trading, day)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMarket.Account(data.Market, member.Life.Trading, day);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`world.Run.Characters.ContainsKey(m.SteamId)`；返回值紧邻使用处：`BinaryExpressionSyntax: world.Run == null || world.Run.Characters.ContainsKey(m.SteamId)`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`world.Members              .Where(m => id == m.PersonId || id == "player" && (world.Run == null || world.Run.Characters.ContainsKey(m.SteamId)))              .SelectMany(m => m.Sponsors.Where(s => s.TargetId == "player"))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => world.Members              .Where(m => id == m.PersonId || id == "player" && (world.Run == null || world.Run.Characters.ContainsKey(m.SteamId)))              .SelectMany(m => m.Sponsors.Where(s => s.TargetId == "player"))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`m.Sponsors.Where(s => s.TargetId == "player")`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: m => m.Sponsors.Where(s => s.TargetId == "player")`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`world.Members              .Where(m => id == m.PersonId || id == "player" && (world.Run == null || world.Run.Characters.ContainsKey(m.SteamId)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: world.Members              .Where(m => id == m.PersonId || id == "player" && (world.Run == null || world.Run.Characters.ContainsKey(m.SteamId)))              .SelectMany`

**赋值（含属性/字段和局部值）：**

- `world.World.MarketAccounts` = `(data, day) =>          {              foreach (var member in world.Members) CareerMarket.Account(data.Market, member.Life.Trading, day);          }`
- `world.World.MarketSponsors` = `id => world.Members              .Where(m => id == m.PersonId || id == "player" && (world.Run == null || world.Run.Characters.ContainsKey(m.SteamId)))              .SelectMany(m => m.Sponsors.Where(s => s.TargetId == "player"))`
