# LeagueSolverLink.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`AD75E5CF09E76EC40EE97363A2EF0B0ED2CD60BE9B3054A4F4655DC40344C2F0`。来源：[源码](../../LeagueSolverLink.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.LeagueSolverLink`、`NationalSpire.LeagueSolverLink.EngineContext`。

字段、事件及初始值（源码原样）：

```csharp
internal const string Unavailable="当前游戏版本不支持镜面对决";
internal static readonly bool Supported=typeof(Player).Assembly.GetType("MegaCrit.Sts2.Core.Entities.FoolArrows.ArrowSlot")!=null
        && typeof(MegaCrit.Sts2.Core.Runs.RunState).GetProperty("RunModels")!=null;
private readonly Assembly host=typeof(LeagueSolverLink).Assembly;
private readonly Func<decimal[],int[],bool[],int[],Task<CardModel?>>? _choose;
private readonly IDisposable? _session;
private readonly Func<int>? _aim;
private readonly Func<int[]>? _choices;
private static Func<CardModel[],int,string,int,int,int,int[]>? _actual;
private static Func<int[],(int Start,int Period,int Count)[]>? _reportRuns;
private static Func<IEnumerable<CardModel>,int>? _menu;
private readonly Func<bool>? _endTurn;
private readonly Func<(CardModel,int,int[])[]>? _rest;
private bool _failed;
private static readonly Lazy<Task<Type?>> Ready=new(()=>Task.Run(()=>{
        try{using var stream=typeof(LeagueSolverLink).Assembly.GetManifestResourceStream("NationalSpire.LeagueSolver.dll")!;
            var type=new EngineContext().LoadFromStream(stream).GetType("NationalSpire.Solver.LeagueForecast",true)!;
            type.GetMethod("Prepare")!.Invoke(null,null);
            _actual=type.GetMethod("SelectActual")!.CreateDelegate<Func<CardModel[],int,string,int,int,int,int[]>>();
            _reportRuns=type.GetMethod("ReportRuns")!.CreateDelegate<Func<int[],(int,int,int)[]>>();
            _menu=type.GetMethod("MenuKey")!.CreateDelegate<Func<IEnumerable<CardModel>,int>>();return type;
        }catch(Exception e){Diagnostics.Error("league-solver",e.GetBaseException());return null;}
    }));
```

<a id="symbol-14d09d14a26e"></a>

## `NationalSpire.LeagueSolverLink.EngineContext.Load(System.Reflection.AssemblyName) — protected override Assembly? Load(AssemblyName name)`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `string.StartsWith(string, System.StringComparison)`；`System.AppDomain.GetAssemblies()`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.IO.Compression.ZipArchive.GetEntry(string)`；`System.IO.Compression.ZipArchive.ZipArchive(System.IO.Stream)`；`System.IO.Compression.ZipArchiveEntry.Open()`；`System.IO.MemoryStream.MemoryStream()`；`System.IO.Stream.CopyTo(System.IO.Stream)`；`System.Reflection.Assembly.GetManifestResourceStream(string)`；`System.Reflection.Assembly.GetName()`；`System.Reflection.AssemblyName.ReferenceMatchesDefinition(System.Reflection.AssemblyName?, System.Reflection.AssemblyName?)`；`System.Runtime.Loader.AssemblyLoadContext.GetLoadContext(System.Reflection.Assembly)`；`System.Runtime.Loader.AssemblyLoadContext.LoadFromStream(System.IO.Stream)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueSolverLink.EngineContext.host`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.StartsWith(string, System.StringComparison)`；输入表达式：`name.Name!.StartsWith("STS2-RitsuLib",StringComparison.Ordinal)`；返回值紧邻使用处：`BinaryExpressionSyntax: name.Name=="CombatSolver" || name.Name!.StartsWith("STS2-RitsuLib",StringComparison.Ordinal)`
- `System.AppDomain.GetAssemblies()`；输入表达式：`AppDomain.CurrentDomain.GetAssemblies()`；返回值紧邻使用处：`ArgumentSyntax: AppDomain.CurrentDomain.GetAssemblies()`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`GetLoadContext(host)!.Assemblies.Concat(AppDomain.CurrentDomain.GetAssemblies())`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetLoadContext(host)!.Assemblies.Concat(AppDomain.CurrentDomain.GetAssemblies()).FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`GetLoadContext(host)!.Assemblies.Concat(AppDomain.CurrentDomain.GetAssemblies()).FirstOrDefault(a=>AssemblyName.ReferenceMatchesDefinition(a.GetName(),name))`；返回值紧邻使用处：`ReturnStatementSyntax: return GetLoadContext(host)!.Assemblies.Concat(AppDomain.CurrentDomain.GetAssemblies()).FirstOrDefault(a=>AssemblyName.ReferenceMatchesDefinition(a.GetName(),name));`
- `System.IO.Compression.ZipArchive.GetEntry(string)`；输入表达式：`pack.GetEntry(name.Name+".dll")`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: pack.GetEntry(name.Name+".dll")!`
- `System.IO.Compression.ZipArchive.ZipArchive(System.IO.Stream)`；输入表达式：`new ZipArchive(host.GetManifestResourceStream("NationalSpire.LeagueEngine.zip")!)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new ZipArchive(host.GetManifestResourceStream("NationalSpire.LeagueEngine.zip")!)`
- `System.IO.Compression.ZipArchiveEntry.Open()`；输入表达式：`pack.GetEntry(name.Name+".dll")!.Open()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =pack.GetEntry(name.Name+".dll")!.Open()`
- `System.IO.MemoryStream.MemoryStream()`；输入表达式：`new MemoryStream()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new MemoryStream()`
- `System.IO.Stream.CopyTo(System.IO.Stream)`；输入表达式：`input.CopyTo(bytes)`；返回值紧邻使用处：`ExpressionStatementSyntax: input.CopyTo(bytes);`
- `System.Reflection.Assembly.GetManifestResourceStream(string)`；输入表达式：`host.GetManifestResourceStream("NationalSpire.LeagueEngine.zip")`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: host.GetManifestResourceStream("NationalSpire.LeagueEngine.zip")!`
- `System.Reflection.Assembly.GetName()`；输入表达式：`a.GetName()`；返回值紧邻使用处：`ArgumentSyntax: a.GetName()`
- `System.Reflection.AssemblyName.ReferenceMatchesDefinition(System.Reflection.AssemblyName?, System.Reflection.AssemblyName?)`；输入表达式：`AssemblyName.ReferenceMatchesDefinition(a.GetName(),name)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: a=>AssemblyName.ReferenceMatchesDefinition(a.GetName(),name)`
- `System.Runtime.Loader.AssemblyLoadContext.GetLoadContext(System.Reflection.Assembly)`；输入表达式：`GetLoadContext(host)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: GetLoadContext(host)!`
- `System.Runtime.Loader.AssemblyLoadContext.LoadFromStream(System.IO.Stream)`；输入表达式：`LoadFromStream(bytes)`；返回值紧邻使用处：`ReturnStatementSyntax: return LoadFromStream(bytes);`

**赋值（含属性/字段和局部值）：**

- `bytes.Position` = `0`

<a id="symbol-068f8650e5ad"></a>

## `NationalSpire.LeagueSolverLink.Choices — internal int[] Choices`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Func<TResult>.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueSolverLink._choices`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Func<TResult>.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _choices?.Invoke()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d9be4df14cd3"></a>

## `NationalSpire.LeagueSolverLink.ReportRuns(int[]) — internal static (int Start,int Period,int Count)[] ReportRuns(int[] actions)`

来源：源码第 35 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DuelRecorder.Sequence(System.Collections.Generic.List<NationalSpire.DuelRecorder.Play>)`](DuelRecorder.cs.md#symbol-6720ee798acf)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Func<T, TResult>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueSolverLink._reportRuns`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；输入表达式：`actions.Select((_,i)=>(i,1,1))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: actions.Select((_,i)=>(i,1,1)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`actions.Select((_,i)=>(i,1,1)).ToArray()`；返回值紧邻使用处：`BinaryExpressionSyntax: _reportRuns?.Invoke(actions) ?? actions.Select((_,i)=>(i,1,1)).ToArray()`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`.Invoke(actions)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _reportRuns?.Invoke(actions)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f476bafa7737"></a>

## `NationalSpire.LeagueSolverLink.Menu(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>) — internal static int Menu(IEnumerable<CardModel> cards)`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueDuel.SelectActual(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, MegaCrit.Sts2.Core.Entities.Cards.PileType, int, int, string)`](LeagueCardChoices.cs.md#symbol-251ed5837391)

**调用：** `System.Func<T, TResult>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueSolverLink._menu`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`.Invoke(cards)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _menu?.Invoke(cards)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-306fe0a674de"></a>

## `NationalSpire.LeagueSolverLink.SelectActual(MegaCrit.Sts2.Core.Models.CardModel[], int, string, int, int, int) — internal static int[] SelectActual(CardModel[] cards,int pile,string purpose,int effect,int min,int max)`

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueDuel.SelectActual(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, MegaCrit.Sts2.Core.Entities.Cards.PileType, int, int, string)`](LeagueCardChoices.cs.md#symbol-251ed5837391)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Func<T1, T2, T3, T4, T5, T6, TResult>.Invoke(T1, T2, T3, T4, T5, T6)`（委托实际目标见流程文档）；`System.Linq.Enumerable.Range(int, int)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueSolverLink._actual`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Enumerable.Range(0,Math.Min(min,cards.Length)).ToArray()`；返回值紧邻使用处：`BinaryExpressionSyntax: _actual?.Invoke(cards,pile,purpose,effect,min,max)??Enumerable.Range(0,Math.Min(min,cards.Length)).ToArray()`
- `System.Func<T1, T2, T3, T4, T5, T6, TResult>.Invoke(T1, T2, T3, T4, T5, T6)`；输入表达式：`.Invoke(cards,pile,purpose,effect,min,max)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _actual?.Invoke(cards,pile,purpose,effect,min,max)`
- `System.Linq.Enumerable.Range(int, int)`；输入表达式：`Enumerable.Range(0,Math.Min(min,cards.Length))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0,Math.Min(min,cards.Length)).ToArray`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(min,cards.Length)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(min,cards.Length)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-dc17819f0527"></a>

## `NationalSpire.LeagueSolverLink.EndTurn — internal bool EndTurn`

来源：源码第 41 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Func<TResult>.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueSolverLink._endTurn`；`NationalSpire.LeagueSolverLink._failed`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Func<TResult>.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _endTurn?.Invoke()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b49116be4e1d"></a>

## `NationalSpire.LeagueSolverLink.Aim — internal int Aim`

来源：源码第 43 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Func<TResult>.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueSolverLink._aim`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Func<TResult>.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _aim?.Invoke()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f083c8d9e98a"></a>

## `NationalSpire.LeagueSolverLink.Rest() — internal (CardModel,int,int[])[] Rest()`

来源：源码第 44 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueDuel.PlayTurn()`](LeagueDuel.cs.md#symbol-e8cbe8f2353a)

**调用：** `System.Func<TResult>.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueSolverLink._rest`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Func<TResult>.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _rest?.Invoke()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-bebd33b71b8c"></a>

## `NationalSpire.LeagueSolverLink.LeagueSolverLink() — private LeagueSolverLink()`

来源：源码第 46 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueSolverLink.Open(MegaCrit.Sts2.Core.Entities.Players.Player, int, string[], int)`](LeagueSolverLink.cs.md#symbol-09cdebc60677)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8d93e22218d4"></a>

## `NationalSpire.LeagueSolverLink.LeagueSolverLink(object) — private LeagueSolverLink(object session)`

来源：源码第 47 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueSolverLink.Open(MegaCrit.Sts2.Core.Entities.Players.Player, int, string[], int)`](LeagueSolverLink.cs.md#symbol-09cdebc60677)

**调用：** `object.GetType()`；`System.Reflection.MethodInfo.CreateDelegate<T>(object?)`；`System.Type.GetMethod(string)`；`System.Type.GetProperty(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueSolverLink._aim`；`NationalSpire.LeagueSolverLink._choices`；`NationalSpire.LeagueSolverLink._choose`；`NationalSpire.LeagueSolverLink._endTurn`；`NationalSpire.LeagueSolverLink._rest`；`NationalSpire.LeagueSolverLink._session`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `object.GetType()`；输入表达式：`session.GetType()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: session.GetType().GetMethod`
- `object.GetType()`；输入表达式：`session.GetType()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: session.GetType().GetProperty`
- `System.Reflection.MethodInfo.CreateDelegate<T>(object?)`；输入表达式：`session.GetType().GetMethod("Choose")!.CreateDelegate<Func<decimal[],int[],bool[],int[],Task<CardModel?>>>(session)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _choose=session.GetType().GetMethod("Choose")!.CreateDelegate<Func<decimal[],int[],bool[],int[],Task<CardModel?>>>(session)`
- `System.Reflection.MethodInfo.CreateDelegate<T>(object?)`；输入表达式：`session.GetType().GetMethod("Continuation")!.CreateDelegate<Func<(CardModel,int,int[])[]>>(session)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _rest=session.GetType().GetMethod("Continuation")!.CreateDelegate<Func<(CardModel,int,int[])[]>>(session)`
- `System.Reflection.MethodInfo.CreateDelegate<T>(object?)`；输入表达式：`session.GetType().GetProperty("EndTurn")!.GetMethod!.CreateDelegate<Func<bool>>(session)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _endTurn=session.GetType().GetProperty("EndTurn")!.GetMethod!.CreateDelegate<Func<bool>>(session)`
- `System.Reflection.MethodInfo.CreateDelegate<T>(object?)`；输入表达式：`session.GetType().GetProperty("LastAim")!.GetMethod!.CreateDelegate<Func<int>>(session)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _aim=session.GetType().GetProperty("LastAim")!.GetMethod!.CreateDelegate<Func<int>>(session)`
- `System.Reflection.MethodInfo.CreateDelegate<T>(object?)`；输入表达式：`session.GetType().GetProperty("LastChoices")!.GetMethod!.CreateDelegate<Func<int[]>>(session)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _choices=session.GetType().GetProperty("LastChoices")!.GetMethod!.CreateDelegate<Func<int[]>>(session)`
- `System.Type.GetMethod(string)`；输入表达式：`session.GetType().GetMethod("Choose")`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: session.GetType().GetMethod("Choose")!`
- `System.Type.GetMethod(string)`；输入表达式：`session.GetType().GetMethod("Continuation")`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: session.GetType().GetMethod("Continuation")!`
- `System.Type.GetProperty(string)`；输入表达式：`session.GetType().GetProperty("EndTurn")`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: session.GetType().GetProperty("EndTurn")!`
- `System.Type.GetProperty(string)`；输入表达式：`session.GetType().GetProperty("LastAim")`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: session.GetType().GetProperty("LastAim")!`
- `System.Type.GetProperty(string)`；输入表达式：`session.GetType().GetProperty("LastChoices")`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: session.GetType().GetProperty("LastChoices")!`

**赋值（含属性/字段和局部值）：**

- `_aim` = `session.GetType().GetProperty("LastAim")!.GetMethod!.CreateDelegate<Func<int>>(session)`
- `_choices` = `session.GetType().GetProperty("LastChoices")!.GetMethod!.CreateDelegate<Func<int[]>>(session)`
- `_choose` = `session.GetType().GetMethod("Choose")!.CreateDelegate<Func<decimal[],int[],bool[],int[],Task<CardModel?>>>(session)`
- `_endTurn` = `session.GetType().GetProperty("EndTurn")!.GetMethod!.CreateDelegate<Func<bool>>(session)`
- `_rest` = `session.GetType().GetMethod("Continuation")!.CreateDelegate<Func<(CardModel,int,int[])[]>>(session)`
- `_session` = `(IDisposable)session`

<a id="symbol-1ecd89ef590b"></a>

## `NationalSpire.LeagueSolverLink.Prepare() — public static void Prepare()`

来源：源码第 57 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LeagueMatch(NationalSpire.CareerData, NationalSpire.CareerMatch?)`](LeagueArenaScreen.cs.md#symbol-601c9785c32a)；[`NationalSpire.LeagueNativeMatch.StartTeam(NationalSpire.Coop.CoopCoordinator, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>)`](LeagueTeamMatch.cs.md#symbol-81e11d18adc7)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueSolverLink.Ready`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `_` = `Ready.Value`

<a id="symbol-ce2e91f8951a"></a>

## `NationalSpire.LeagueSolverLink.PrepareChoices() — internal static Task PrepareChoices()`

来源：源码第 58 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueDuel.PlayTurn()`](LeagueDuel.cs.md#symbol-e8cbe8f2353a)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueSolverLink.Ready`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-09cdebc60677"></a>

## `NationalSpire.LeagueSolverLink.Open(MegaCrit.Sts2.Core.Entities.Players.Player, int, string[], int) — public static async Task<LeagueSolverLink> Open(Player rival,int tier,string[] setup,int preference)`

来源：源码第 59 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueDuel.PlayTurn()`](LeagueDuel.cs.md#symbol-e8cbe8f2353a)

**调用：** [`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；[`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`](ArchitectFinal.cs.md#symbol-dfa68774ae32)；[`NationalSpire.LeagueSolverLink.LeagueSolverLink()`](LeagueSolverLink.cs.md#symbol-bebd33b71b8c)；[`NationalSpire.LeagueSolverLink.LeagueSolverLink(object)`](LeagueSolverLink.cs.md#symbol-8d93e22218d4)；`System.Activator.CreateInstance(System.Type, params object?[]?)`；`System.Exception.GetBaseException()`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.LeagueDuel.Exit`；`NationalSpire.LeagueNativeMatch.AddedDoom(int)`；`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`；`NationalSpire.LeagueSolverLink.Ready`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("league-solver",e.GetBaseException())`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("league-solver",e.GetBaseException());`
- `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`；输入表达式：`LeagueNativeMatch.For(rival)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: LeagueNativeMatch.For(rival)?.Exit`
- `NationalSpire.LeagueSolverLink.LeagueSolverLink()`；输入表达式：`new()`；返回值紧邻使用处：`ReturnStatementSyntax: return new();`
- `NationalSpire.LeagueSolverLink.LeagueSolverLink(object)`；输入表达式：`new(Activator.CreateInstance(adapter,rival,tier,setup,(Func<int,int>)LeagueNativeMatch.AddedDoom,preference,LeagueNativeMatch.For(rival)?.Exit??default(CancellationToken))!)`；返回值紧邻使用处：`ReturnStatementSyntax: return new(Activator.CreateInstance(adapter,rival,tier,setup,(Func<int,int>)LeagueNativeMatch.AddedDoom,preference,LeagueNativeMatch.For(rival)?.Exit??default(CancellationToken))!);`
- `System.Activator.CreateInstance(System.Type, params object?[]?)`；输入表达式：`Activator.CreateInstance(adapter,rival,tier,setup,(Func<int,int>)LeagueNativeMatch.AddedDoom,preference,LeagueNativeMatch.For(rival)?.Exit??default(CancellationToken))`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: Activator.CreateInstance(adapter,rival,tier,setup,(Func<int,int>)LeagueNativeMatch.AddedDoom,preference,LeagueNativeMatch.For(rival)?.Exit??default(CancellationToken))!`
- `System.Exception.GetBaseException()`；输入表达式：`e.GetBaseException()`；返回值紧邻使用处：`ArgumentSyntax: e.GetBaseException()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-09769e33fa77"></a>

## `NationalSpire.LeagueSolverLink.Choose(decimal[], int[], bool[], int[]) — public async Task<CardModel?> Choose(decimal[] amounts,int[] properties,bool[] capped,int[] dealers)`

来源：源码第 64 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueDuel.PlayTurn()`](LeagueDuel.cs.md#symbol-e8cbe8f2353a)

**调用：** [`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；`System.Exception.GetBaseException()`；`System.Func<T1, T2, T3, T4, TResult>.Invoke(T1, T2, T3, T4)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.LeagueSolverLink._choose`；`NationalSpire.LeagueSolverLink._failed`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("league-solver",e.GetBaseException())`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("league-solver",e.GetBaseException());`
- `System.Exception.GetBaseException()`；输入表达式：`e.GetBaseException()`；返回值紧邻使用处：`ArgumentSyntax: e.GetBaseException()`
- `System.Func<T1, T2, T3, T4, TResult>.Invoke(T1, T2, T3, T4)`；输入表达式：`_choose(amounts,properties,capped,dealers)`；返回值紧邻使用处：`AwaitExpressionSyntax: await _choose(amounts,properties,capped,dealers)`

**赋值（含属性/字段和局部值）：**

- `_failed` = `true`

<a id="symbol-5b2af3661a9f"></a>

## `NationalSpire.LeagueSolverLink.Dispose() — public void Dispose()`

来源：源码第 68 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.IDisposable.Dispose()`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueSolverLink._session`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.IDisposable.Dispose()`；输入表达式：`.Dispose()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _session?.Dispose()`

**赋值（含属性/字段和局部值）：**
