# ConsumerEvents.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`8942B6A01ECB867DE0E3AB7B7B754B956843DE34548C55D54783B3D44F14BD7B`。来源：[源码](../../ConsumerEvents.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.ConsumerEvents`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-046119a7c75d"></a>

## `NationalSpire.ConsumerEvents.Purchase(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>) — public static void Purchase(CareerData data, string detail, IReadOnlyList<string> guests)`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ConsumerEngine.Buy(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>?, int)`](ConsumerEngine.cs.md#symbol-af8f54536df7)

**调用：** [`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`](CareerLife.cs.md#symbol-0ea81cb3e558)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；`string.StartsWith(string, System.StringComparison)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.CommunityMemories`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`；`NationalSpire.CareerLifeState.Consumer`；`NationalSpire.CareerLifeState.Events`；`NationalSpire.CommunityMemory.Id`；`NationalSpire.CommunityMemory.People`；`NationalSpire.CommunityMemory.Text`；`NationalSpire.ConsumerState.PurchaseCount`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.LifeEvent.Day`；`NationalSpire.LifeEvent.Detail`；`NationalSpire.LifeEvent.EditionWeek`；`NationalSpire.LifeEvent.Id`；`NationalSpire.LifeEvent.People`；`NationalSpire.LifeEvent.PostId`；`NationalSpire.LifeEvent.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.Name(data) + "的购物与消费"`
- `NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`；输入表达式：`CareerLife.AddEvent(data, prefix + data.Life.Consumer.PurchaseCount, "消费与生活",                 CareerEngine.Name(data) + "的购物与消费", detail, people)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerLife.AddEvent(data, prefix + data.Life.Consumer.PurchaseCount, "消费与生活",                 CareerEngine.Name(data) + "的购物与消费", detail, people);`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GroupChats.Human(data)`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`e.Id.StartsWith(prefix, StringComparison.Ordinal)`；返回值紧邻使用处：`BinaryExpressionSyntax: e.Id.StartsWith(prefix, StringComparison.Ordinal)             && e.Day == data.Day`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`entry.People.Concat(people)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: entry.People.Concat(people).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`new[] { human }.Concat(guests)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { human }.Concat(guests).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`entry.People.Concat(people).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: entry.People.Concat(people).Distinct().ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`new[] { human }.Concat(guests).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { human }.Concat(guests).Distinct().ToList`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.CommunityMemories.FirstOrDefault(m => m.Id == "life-fact:" + entry.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.CommunityMemories.FirstOrDefault(m => m.Id == "life-fact:" + entry.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Life.Events.LastOrDefault(e => e.Id.StartsWith(prefix, StringComparison.Ordinal)             && e.Day == data.Day && e.PostId.Length == 0 && e.EditionWeek == 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Life.Events.LastOrDefault(e => e.Id.StartsWith(prefix, StringComparison.Ordinal)             && e.Day == data.Day && e.PostId.Length == 0 && e.EditionWeek == 0)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`entry.People.Concat(people).Distinct().ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: entry.People = entry.People.Concat(people).Distinct().ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`entry.People.ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: fact.People = entry.People.ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`new[] { human }.Concat(guests).Distinct().ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new[] { human }.Concat(guests).Distinct().ToList()`

**赋值（含属性/字段和局部值）：**

- `entry.Detail` += `"\n" + detail`
- `entry.People` = `entry.People.Concat(people).Distinct().ToList()`
- `fact.People` = `entry.People.ToList()`
- `fact.Text` = `entry.Title + "：" + entry.Detail`

<a id="symbol-49f04620b21e"></a>

## `NationalSpire.ConsumerEvents.Activity(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.GoodVerb, System.Collections.Generic.IReadOnlyList<string>) — public static void Activity(CareerData data, Good good, GoodVerb verb, IReadOnlyList<string> guests)`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ConsumerAttachments.Attend(NationalSpire.CareerData, NationalSpire.PrivateOffer, bool)`](ConsumerAttachments.cs.md#symbol-c0f0a7c39a70)；[`NationalSpire.ConsumerEngine.Use(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>, bool, bool)`](ConsumerEngine.cs.md#symbol-137637f9e576)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`](CareerLife.cs.md#symbol-0ea81cb3e558)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`；`NationalSpire.CareerLifeState.Consumer`；`NationalSpire.ConsumerState.PartyCount`；`NationalSpire.Good.Name`；`NationalSpire.GoodVerb.Name`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => CareerEngine.DisplayName(data, id)`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(data)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.Name(data)}`
- `NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`；输入表达式：`CareerLife.AddEvent(data, human + "/party-" + data.Life.Consumer.PartyCount, "消费与生活", verb.Name + "已完成",             $"{CareerEngine.Name(data)}使用{good.Name}举办的{verb.Name}已经结束。" + (people.Length > 0 ? "参加者：" + people + "。" : ""), [human, .. guests])`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerLife.AddEvent(data, human + "/party-" + data.Life.Consumer.PartyCount, "消费与生活", verb.Name + "已完成",             $"{CareerEngine.Name(data)}使用{good.Name}举办的{verb.Name}已经结束。" + (people.Length > 0 ? "参加者：" + people + "。" : ""), [human, .. guests]);`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GroupChats.Human(data)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", guests.Select(id => CareerEngine.DisplayName(data, id)))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = string.Join("、", guests.Select(id => CareerEngine.DisplayName(data, id)))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`guests.Select(id => CareerEngine.DisplayName(data, id))`；返回值紧邻使用处：`ArgumentSyntax: guests.Select(id => CareerEngine.DisplayName(data, id))`

**赋值（含属性/字段和局部值）：**
