# LeagueTurnPlan.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`2BBBDEFF61A90651A22559BC24BD964491450268C1F81410793949BAC2787DAA`。来源：[源码](../../LeagueTurnPlan.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.LeagueTurnPlan`、`NationalSpire.LeagueTurnPlan.Move`、`NationalSpire.LeagueTurnPlan.Path`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-df3baa0c08bc"></a>

## `NationalSpire.LeagueTurnPlan.Choose(MegaCrit.Sts2.Core.Entities.Players.Player, decimal, int) — internal static CardModel? Choose(Player rival,decimal threat,int tier)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueDuel.Act()`](LeagueDuel.cs.md#symbol-0b7f3276ecd9)

**调用：** [`Score(NationalSpire.LeagueTurnPlan.Path)`](LeagueTurnPlan.cs.md#symbol-9c646c1fc2ee)；`MegaCrit.Sts2.Core.Models.CardModel.CanPlay()`；`NationalSpire.LeagueTurnPlan.Path.Path(ulong, int, int, int, decimal, decimal, decimal, int, int)`；`System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, int, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`

**字段、属性、事件及方法组引用：** `Inspect(MegaCrit.Sts2.Core.Models.CardModel)`；`NationalSpire.LeagueTurnPlan.Move.Card`；`NationalSpire.LeagueTurnPlan.Move.Cost`；`NationalSpire.LeagueTurnPlan.Move.Damage`；`NationalSpire.LeagueTurnPlan.Move.Draw`；`NationalSpire.LeagueTurnPlan.Move.Energy`；`NationalSpire.LeagueTurnPlan.Move.Guard`；`NationalSpire.LeagueTurnPlan.Move.Slam`；`NationalSpire.LeagueTurnPlan.Move.Stars`；`NationalSpire.LeagueTurnPlan.Move.Strength`；`NationalSpire.LeagueTurnPlan.Move.Weak`；`NationalSpire.LeagueTurnPlan.Path.Attack`；`NationalSpire.LeagueTurnPlan.Path.Energy`；`NationalSpire.LeagueTurnPlan.Path.First`；`NationalSpire.LeagueTurnPlan.Path.Guard`；`NationalSpire.LeagueTurnPlan.Path.Stars`；`NationalSpire.LeagueTurnPlan.Path.Strength`；`NationalSpire.LeagueTurnPlan.Path.Used`；`NationalSpire.LeagueTurnPlan.Path.Value`；`NationalSpire.LeagueTurnPlan.Path.Weak`；`Score(NationalSpire.LeagueTurnPlan.Path)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Models.CardModel.CanPlay()`；输入表达式：`m.Card.CanPlay()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: m=>m.Card.CanPlay()`
- `NationalSpire.LeagueTurnPlan.Path.Path(ulong, int, int, int, decimal, decimal, decimal, int, int)`；输入表达式：`new Path(0,-1,state.Energy,state.Stars,0,0,0,0,0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Path(0,-1,state.Energy,state.Stars,0,0,0,0,0)`
- `NationalSpire.LeagueTurnPlan.Path.Path(ulong, int, int, int, decimal, decimal, decimal, int, int)`；输入表达式：`new Path(p.Used|bit,p.First<0?i:p.First,p.Energy-m.Cost+m.Energy,p.Stars-m.Stars,p.Guard+m.Guard,p.Attack+damage,                     p.Value+m.Draw*2.4m+m.Energy*1.5m+(m.Card.Type==CardType.Power?2.5m:0)+m.Strength+m.Weak+.15m,p.Strength+m.Strength,p.Weak+m.Weak)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Path(p.Used|bit,p.First<0?i:p.First,p.Energy-m.Cost+m.Energy,p.Stars-m.Stars,p.Guard+m.Guard,p.Attack+damage,                     p.Value+m.Draw*2.4m+m.Energy*1.5m+(m.Card.Type==CardType.Power?2.5m:0)+m.Strength+m.Weak+.15m,p.Strength+m.Strength,p.Weak+m.Weak)`
- `Score(NationalSpire.LeagueTurnPlan.Path)`；输入表达式：`Score(best)`；返回值紧邻使用处：`BinaryExpressionSyntax: Score(q)>Score(best)`
- `Score(NationalSpire.LeagueTurnPlan.Path)`；输入表达式：`Score(q)`；返回值紧邻使用处：`BinaryExpressionSyntax: Score(q)>Score(best)`
- `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`next.OrderByDescending(Score).ThenByDescending(q=>q.Energy).DistinctBy(q=>(q.Used,q.Energy,q.Stars,q.Guard,q.Attack,q.Strength,q.Weak))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: next.OrderByDescending(Score).ThenByDescending(q=>q.Energy).DistinctBy(q=>(q.Used,q.Energy,q.Stars,q.Guard,q.Attack,q.Strength,q.Weak)).Take`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`moves.Where((_,i)=>legal[i]).Select(m=>m.Card).FirstOrDefault()`；返回值紧邻使用处：`ConditionalExpressionSyntax: best.First<0?moves.Where((_,i)=>legal[i]).Select(m=>m.Card).FirstOrDefault():moves[best.First].Card`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`next.OrderByDescending(Score)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: next.OrderByDescending(Score).ThenByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`moves.Select(m=>m.Card.CanPlay())`；返回值紧邻使用处：`MemberAccessExpressionSyntax: moves.Select(m=>m.Card.CanPlay()).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`moves.Where((_,i)=>legal[i]).Select(m=>m.Card)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: moves.Where((_,i)=>legal[i]).Select(m=>m.Card).FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`state.Hand.Cards.Take(64).Select(Inspect)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: state.Hand.Cards.Take(64).Select(Inspect).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`next.OrderByDescending(Score).ThenByDescending(q=>q.Energy).DistinctBy(q=>(q.Used,q.Energy,q.Stars,q.Guard,q.Attack,q.Strength,q.Weak)).Take(width)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: next.OrderByDescending(Score).ThenByDescending(q=>q.Energy).DistinctBy(q=>(q.Used,q.Energy,q.Stars,q.Guard,q.Attack,q.Strength,q.Weak)).Take(width).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`state.Hand.Cards.Take(64)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: state.Hand.Cards.Take(64).Select`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`moves.Select(m=>m.Card.CanPlay()).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =moves.Select(m=>m.Card.CanPlay()).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`state.Hand.Cards.Take(64).Select(Inspect).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =state.Hand.Cards.Take(64).Select(Inspect).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`next.OrderByDescending(Score).ThenByDescending(q=>q.Energy).DistinctBy(q=>(q.Used,q.Energy,q.Stars,q.Guard,q.Attack,q.Strength,q.Weak)).Take(width).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: front=next.OrderByDescending(Score).ThenByDescending(q=>q.Energy).DistinctBy(q=>(q.Used,q.Energy,q.Stars,q.Guard,q.Attack,q.Strength,q.Weak)).Take(width).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, int, bool>)`；输入表达式：`moves.Where((_,i)=>legal[i])`；返回值紧邻使用处：`MemberAccessExpressionSyntax: moves.Where((_,i)=>legal[i]).Select`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`next.Add(q)`；返回值紧邻使用处：`ExpressionStatementSyntax: next.Add(q);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<Path>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<Path>()`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<Path>{initial}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<Path>{initial}`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`next.OrderByDescending(Score).ThenByDescending(q=>q.Energy)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: next.OrderByDescending(Score).ThenByDescending(q=>q.Energy).DistinctBy`

**赋值（含属性/字段和局部值）：**

- `best` = `q`
- `damage` = `(damage+p.Strength)*(p.Weak>0?1.5m:1m)`
- `front` = `next.OrderByDescending(Score).ThenByDescending(q=>q.Energy).DistinctBy(q=>(q.Used,q.Energy,q.Stars,q.Guard,q.Attack,q.Strength,q.Weak)).Take(width).ToList()`

<a id="symbol-e98627dad565"></a>

## `Inspect(MegaCrit.Sts2.Core.Models.CardModel) — Move Inspect(CardModel c)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`V(string)`](LeagueTurnPlan.cs.md#symbol-cc8f5a2de603)；`MegaCrit.Sts2.Core.Entities.Cards.CardEnergyCost.GetAmountToSpend()`；`MegaCrit.Sts2.Core.Models.CardModel.GetStarCostWithModifiers()`；`NationalSpire.LeagueTurnPlan.Move.Move(MegaCrit.Sts2.Core.Models.CardModel, int, int, decimal, decimal, int, int, int, int, bool)`；`System.Math.Max(decimal, decimal)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `V(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Entities.Cards.CardEnergyCost.GetAmountToSpend()`；输入表达式：`c.EnergyCost.GetAmountToSpend()`；返回值紧邻使用处：`ArgumentSyntax: c.EnergyCost.GetAmountToSpend()`
- `MegaCrit.Sts2.Core.Models.CardModel.GetStarCostWithModifiers()`；输入表达式：`c.GetStarCostWithModifiers()`；返回值紧邻使用处：`ArgumentSyntax: c.GetStarCostWithModifiers()`
- `NationalSpire.LeagueTurnPlan.Move.Move(MegaCrit.Sts2.Core.Models.CardModel, int, int, decimal, decimal, int, int, int, int, bool)`；输入表达式：`new(c,c.EnergyCost.GetAmountToSpend(),Math.Max(0,c.GetStarCostWithModifiers()),damage,V("Block"),(int)V("Cards"),(int)V("Energy"),strength,vulnerable,id=="BODY_SLAM")`；返回值紧邻使用处：`ReturnStatementSyntax: return new(c,c.EnergyCost.GetAmountToSpend(),Math.Max(0,c.GetStarCostWithModifiers()),damage,V("Block"),(int)V("Cards"),(int)V("Energy"),strength,vulnerable,id=="BODY_SLAM");`
- `System.Math.Max(decimal, decimal)`；输入表达式：`Math.Max(1,V("Repeat"))`；返回值紧邻使用处：`AssignmentExpressionSyntax: damage*=Math.Max(1,V("Repeat"))`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0,c.GetStarCostWithModifiers())`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0,c.GetStarCostWithModifiers())`
- `V(string)`；输入表达式：`V("Block")`；返回值紧邻使用处：`ArgumentSyntax: V("Block")`
- `V(string)`；输入表达式：`V("Cards")`；返回值紧邻使用处：`CastExpressionSyntax: (int)V("Cards")`
- `V(string)`；输入表达式：`V("Damage")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =V("Damage")`
- `V(string)`；输入表达式：`V("Energy")`；返回值紧邻使用处：`CastExpressionSyntax: (int)V("Energy")`
- `V(string)`；输入表达式：`V("Repeat")`；返回值紧邻使用处：`ArgumentSyntax: V("Repeat")`
- `V(string)`；输入表达式：`V("StrengthPower")`；返回值紧邻使用处：`CastExpressionSyntax: (int)V("StrengthPower")`
- `V(string)`；输入表达式：`V("VulnerablePower")`；返回值紧邻使用处：`CastExpressionSyntax: (int)V("VulnerablePower")`

**赋值（含属性/字段和局部值）：**

- `damage` *= `Math.Max(1,V("Repeat"))`
- `damage` = `4`

<a id="symbol-cc8f5a2de603"></a>

## `V(string) — decimal V(string name)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Inspect(MegaCrit.Sts2.Core.Models.CardModel)`](LeagueTurnPlan.cs.md#symbol-e98627dad565)

**调用：** `MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVarSet.TryGetValue(string, out MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVarSet.TryGetValue(string, out MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar)`；输入表达式：`c.DynamicVars.TryGetValue(name,out var v)`；返回值紧邻使用处：`ConditionalExpressionSyntax: c.DynamicVars.TryGetValue(name,out var v)?v.BaseValue:0`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9c646c1fc2ee"></a>

## `Score(NationalSpire.LeagueTurnPlan.Path) — decimal Score(Path p)`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueTurnPlan.Choose(MegaCrit.Sts2.Core.Entities.Players.Player, decimal, int)`](LeagueTurnPlan.cs.md#symbol-df3baa0c08bc)

**调用：** `System.Math.Min(decimal, decimal)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueTurnPlan.Path.Attack`；`NationalSpire.LeagueTurnPlan.Path.Energy`；`NationalSpire.LeagueTurnPlan.Path.Guard`；`NationalSpire.LeagueTurnPlan.Path.Value`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Min(decimal, decimal)`；输入表达式：`Math.Min(threat,p.Guard)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Min(threat,p.Guard)*(threat>=rival.Creature.CurrentHp?4:1.65m)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(3,p.Energy)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Min(3,p.Energy)*.12m`

**赋值（含属性/字段和局部值）：**
