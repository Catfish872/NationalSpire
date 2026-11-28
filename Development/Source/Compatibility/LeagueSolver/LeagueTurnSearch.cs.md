# Compatibility/LeagueSolver/LeagueTurnSearch.cs

[返回文件依赖索引](../../../SOURCE_MAP.md)

源码 SHA-256：`85D00D2A0DF992B4DA9A4C1445012C3EA97285DF9EE5D0B7775EFAE7AA3307A9`。来源：[源码](../../../../Compatibility/LeagueSolver/LeagueTurnSearch.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Solver.LeagueTurnSearch`、`NationalSpire.Solver.LeagueTurnSearch.Candidate<T, TKey>`、`NationalSpire.Solver.LeagueTurnSearch.Result<T>`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-5402dafc266a"></a>

## `NationalSpire.Solver.LeagueTurnSearch.Choose<T, TKey>(T, decimal, int, System.Threading.CancellationToken, System.Func<T, System.Func<bool>, System.Collections.Generic.IEnumerable<NationalSpire.Solver.LeagueTurnSearch.Candidate<T, TKey>>>) — internal static Result<T> Choose<T,TKey>(T pass,decimal passScore,int level,CancellationToken exit,         Func<T,Func<bool>,IEnumerable<Candidate<T,TKey>>> expand) where TKey:notnull`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueForecast.Choose(decimal[], int[], bool[], int[])`](LeagueForecast.cs.md#symbol-25d92d14be68)

**调用：** [`Expired()`](LeagueTurnSearch.cs.md#symbol-1c3fec5f3a2f)；`NationalSpire.Solver.LeagueTurnSearch.Result<T>.Result(T, int, bool)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Diagnostics.Stopwatch.GetTimestamp()`；`System.Func<T1, T2, TResult>.Invoke(T1, T2)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `(T State, decimal Score).Score`；`(T State, decimal Score).State`；`Expired()`；`NationalSpire.Solver.LeagueTurnSearch.Candidate<T, TKey>.ContinueScore`；`NationalSpire.Solver.LeagueTurnSearch.Candidate<T, TKey>.EndScore`；`NationalSpire.Solver.LeagueTurnSearch.Candidate<T, TKey>.Key`；`NationalSpire.Solver.LeagueTurnSearch.Candidate<T, TKey>.Lethal`；`NationalSpire.Solver.LeagueTurnSearch.Candidate<T, TKey>.State`；`NationalSpire.Solver.LeagueTurnSearch.Candidate<T, TKey>.WinsTie`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Expired()`；输入表达式：`Expired()`；返回值紧邻使用处：`IfStatementSyntax: if(Expired())break;`
- `Expired()`；输入表达式：`Expired()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Expired()`
- `NationalSpire.Solver.LeagueTurnSearch.Result<T>.Result(T, int, bool)`；输入表达式：`new(best,compared,timedOut)`；返回值紧邻使用处：`ReturnStatementSyntax: return new(best,compared,timedOut);`
- `NationalSpire.Solver.LeagueTurnSearch.Result<T>.Result(T, int, bool)`；输入表达式：`new(candidate.State,compared,timedOut)`；返回值紧邻使用处：`ReturnStatementSyntax: return new(candidate.State,compared,timedOut);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<TKey,decimal>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Dictionary<TKey,decimal>()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`visited.TryGetValue(candidate.Key,out var previous)`；返回值紧邻使用处：`BinaryExpressionSyntax: visited.TryGetValue(candidate.Key,out var previous) && previous>=candidate.ContinueScore`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`next.OrderByDescending(item=>item.Score)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: next.OrderByDescending(item=>item.Score).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`next.OrderByDescending(item=>item.Score).Take(3+2*level).Select(item=>item.State)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: next.OrderByDescending(item=>item.Score).Take(3+2*level).Select(item=>item.State).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`next.OrderByDescending(item=>item.Score).Take(3+2*level)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: next.OrderByDescending(item=>item.Score).Take(3+2*level).Select`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`next.OrderByDescending(item=>item.Score).Take(3+2*level).Select(item=>item.State).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: frontier=next.OrderByDescending(item=>item.Score).Take(3+2*level).Select(item=>item.State).ToList()`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`next.Add((candidate.State,candidate.ContinueScore))`；返回值紧邻使用处：`ExpressionStatementSyntax: next.Add((candidate.State,candidate.ContinueScore));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<(T State,decimal Score)>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<(T State,decimal Score)>()`
- `System.Diagnostics.Stopwatch.GetTimestamp()`；输入表达式：`Stopwatch.GetTimestamp()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Stopwatch.GetTimestamp()`
- `System.Func<T1, T2, TResult>.Invoke(T1, T2)`；输入表达式：`expand(parent,Expired)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var candidate in expand(parent,Expired)){                     compared++;                     if(candidate.Lethal)return new(candidate.State,compared,timedOut);                     if(candidate.EndScore>bestEnd || candidate.EndScore==bestEnd &&                         (hasMove?candidate.ContinueScore>bestContinue:candidate.WinsTie)){                         best=candidate.State;bestEnd=candidate.EndScore;bestContinue=candidate.ContinueScore;hasMove=true;                     }                     if(visited.TryGetValue(candidate.Key,out var previous) && previous>=candidate.ContinueScore)continue;                     visited[candidate.Key]=candidate.ContinueScore;                     next.Add((candidate.State,candidate.ContinueScore));                 }`

**赋值（含属性/字段和局部值）：**

- `best` = `candidate.State`
- `bestContinue` = `candidate.ContinueScore`
- `bestEnd` = `candidate.EndScore`
- `frontier` = `next.OrderByDescending(item=>item.Score).Take(3+2*level).Select(item=>item.State).ToList()`
- `hasMove` = `true`
- `rootComplete` = `true`
- `visited[candidate.Key]` = `candidate.ContinueScore`

<a id="symbol-1c3fec5f3a2f"></a>

## `Expired() — bool Expired()`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Solver.LeagueTurnSearch.Choose<T, TKey>(T, decimal, int, System.Threading.CancellationToken, System.Func<T, System.Func<bool>, System.Collections.Generic.IEnumerable<NationalSpire.Solver.LeagueTurnSearch.Candidate<T, TKey>>>)`](LeagueTurnSearch.cs.md#symbol-5402dafc266a)

**调用：** `System.Diagnostics.Stopwatch.GetElapsedTime(long)`；`System.Threading.CancellationToken.ThrowIfCancellationRequested()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Diagnostics.Stopwatch.GetElapsedTime(long)`；输入表达式：`Stopwatch.GetElapsedTime(start)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Stopwatch.GetElapsedTime(start).TotalMilliseconds`
- `System.Threading.CancellationToken.ThrowIfCancellationRequested()`；输入表达式：`exit.ThrowIfCancellationRequested()`；返回值紧邻使用处：`ExpressionStatementSyntax: exit.ThrowIfCancellationRequested();`

**赋值（含属性/字段和局部值）：**

- `timedOut` = `true`
