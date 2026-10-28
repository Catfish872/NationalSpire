# Coop/CoopStorage.cs

[返回文件依赖索引](../../SOURCE_MAP.md)

源码 SHA-256：`14B4E07C4DC50295C49309C19ADF0627D2EA3CB8F9B382C0066C3AC87FAE8D02`。来源：[源码](../../../Coop/CoopStorage.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Coop.CoopStorage`、`NationalSpire.Coop.CoopStorage.DirectoryWork`、`NationalSpire.Coop.CoopStorage.Manifest`、`NationalSpire.Coop.CoopStorage.Checkpoint`。

字段、事件及初始值（源码原样）：

```csharp
public readonly object Gate = new();
public Task Tail = Task.CompletedTask;
public int Writes;
private static readonly object DirectoriesGate = new();
private static readonly Dictionary<string, DirectoryWork> Directories = new(StringComparer.OrdinalIgnoreCase);
```

<a id="symbol-664485faad0d"></a>

## `NationalSpire.Coop.CoopStorage.Work(string) — private DirectoryWork Work(string id)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopStorage.BackupBeforeDevelopment(NationalSpire.Coop.CoopWorld, byte[]?)`](CoopStorage.cs.md#symbol-955953e36f17)；[`NationalSpire.Coop.CoopStorage.Delete(string)`](CoopStorage.cs.md#symbol-cf3c1fbdf7f4)；[`NationalSpire.Coop.CoopStorage.ImportArchive(byte[])`](CoopStorage.cs.md#symbol-73147f08e733)；[`NationalSpire.Coop.CoopStorage.Load(string)`](CoopStorage.cs.md#symbol-efe4d419a020)；[`NationalSpire.Coop.CoopStorage.Save(NationalSpire.Coop.CoopWorld, byte[]?)`](CoopStorage.cs.md#symbol-a4c240447248)；[`NationalSpire.Coop.CoopStorage.Schedule<T>(string, System.Func<T>, System.Threading.CancellationToken, bool)`](CoopStorage.cs.md#symbol-e7e3aa0f9a7c)

**调用：** [`NationalSpire.Coop.CoopStorage.DirectoryFor(string)`](CoopStorage.cs.md#symbol-9914499d45a1)；`NationalSpire.Coop.CoopStorage.DirectoryWork.DirectoryWork()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.IO.Path.GetFullPath(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopStorage.Directories`；`NationalSpire.Coop.CoopStorage.DirectoriesGate`；`NationalSpire.Coop.CoopStorage.DirectoryFor(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopStorage.DirectoryFor(string)`；输入表达式：`DirectoryFor(id)`；返回值紧邻使用处：`ArgumentSyntax: DirectoryFor(id)`
- `NationalSpire.Coop.CoopStorage.DirectoryWork.DirectoryWork()`；输入表达式：`new()`；返回值紧邻使用处：`AssignmentExpressionSyntax: work = new()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Directories.TryGetValue(path, out var work)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Directories.TryGetValue(path, out var work)`
- `System.IO.Path.GetFullPath(string)`；输入表达式：`Path.GetFullPath(DirectoryFor(id))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Path.GetFullPath(DirectoryFor(id))`

**赋值（含属性/字段和局部值）：**

- `Directories[path]` = `work = new()`
- `work` = `new()`

<a id="symbol-e7e3aa0f9a7c"></a>

## `NationalSpire.Coop.CoopStorage.Schedule<T>(string, System.Func<T>, System.Threading.CancellationToken, bool) — private Task<T> Schedule<T>(string id, Func<T> action, CancellationToken token = default, bool write = false)`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopStorage.DeleteAsync(string)`](CoopStorage.cs.md#symbol-896c6be28762)；[`NationalSpire.Coop.CoopStorage.ExportArchiveAsync(string)`](CoopStorage.cs.md#symbol-fc7f730c7e18)；[`NationalSpire.Coop.CoopStorage.LoadAsync(string)`](CoopStorage.cs.md#symbol-98401b01dd9e)；[`NationalSpire.Coop.CoopStorage.SaveAsync(NationalSpire.Coop.CoopWorld, byte[]?, System.Threading.CancellationToken)`](CoopStorage.cs.md#symbol-26bf729f0b72)

**调用：** [`NationalSpire.Coop.CoopStorage.Work(string)`](CoopStorage.cs.md#symbol-664485faad0d)；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）；`System.Threading.CancellationToken.ThrowIfCancellationRequested()`；`System.Threading.Tasks.Task.ConfigureAwait(bool)`；`System.Threading.Tasks.Task.Run<TResult>(System.Func<System.Threading.Tasks.Task<TResult>?>)`；`System.Threading.Tasks.Task<TResult>.ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>>, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopStorage.DirectoriesGate`；`NationalSpire.Coop.CoopStorage.DirectoryWork.Tail`；`NationalSpire.Coop.CoopStorage.DirectoryWork.Writes`；`NationalSpire.Coop.CoopStorage.Work(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopStorage.Work(string)`；输入表达式：`Work(id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Work(id)`
- `System.Func<TResult>.Invoke()`；输入表达式：`action()`；返回值紧邻使用处：`ReturnStatementSyntax: return action();`
- `System.Threading.CancellationToken.ThrowIfCancellationRequested()`；输入表达式：`token.ThrowIfCancellationRequested()`；返回值紧邻使用处：`ExpressionStatementSyntax: token.ThrowIfCancellationRequested();`
- `System.Threading.Tasks.Task.ConfigureAwait(bool)`；输入表达式：`previous.ConfigureAwait(false)`；返回值紧邻使用处：`AwaitExpressionSyntax: await previous.ConfigureAwait(false)`
- `System.Threading.Tasks.Task.Run<TResult>(System.Func<System.Threading.Tasks.Task<TResult>?>)`；输入表达式：`Task.Run(async () =>              {                  try                  {                      // 前一项错误由原调用者处理；目录协调不新增业务重试或阻断后续操作。                      try { await previous.ConfigureAwait(false); } catch { }                      token.ThrowIfCancellationRequested();                      return action();                  }                  finally { if (write) lock (DirectoriesGate) work.Writes--; }              })`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Task.Run(async () =>              {                  try                  {                      // 前一项错误由原调用者处理；目录协调不新增业务重试或阻断后续操作。                      try { await previous.ConfigureAwait(false); } catch { }                      token.ThrowIfCancellationRequested();                      return action();                  }                  finally { if (write) lock (DirectoriesGate) work.Writes--; }              })`
- `System.Threading.Tasks.Task<TResult>.ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>>, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions, System.Threading.Tasks.TaskScheduler)`；输入表达式：`task.ContinueWith(t => { _ = t.Exception; }, CancellationToken.None, TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default)`；返回值紧邻使用处：`AssignmentExpressionSyntax: work.Tail = task.ContinueWith(t => { _ = t.Exception; }, CancellationToken.None, TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default)`

**赋值（含属性/字段和局部值）：**

- `_` = `t.Exception`
- `work.Tail` = `task.ContinueWith(t => { _ = t.Exception; }, CancellationToken.None, TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default)`

<a id="symbol-26bf729f0b72"></a>

## `NationalSpire.Coop.CoopStorage.SaveAsync(NationalSpire.Coop.CoopWorld, byte[]?, System.Threading.CancellationToken) — public Task SaveAsync(CoopWorld world, byte[]? run, CancellationToken token = default)`

来源：源码第 41 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.SaveReceived(NationalSpire.Coop.CoopSnapshot, bool, ulong)`](CoopReception.cs.md#symbol-a9de6eef033e)

**调用：** [`NationalSpire.Coop.CoopStorage.Save(NationalSpire.Coop.CoopWorld, byte[]?)`](CoopStorage.cs.md#symbol-a4c240447248)；[`NationalSpire.Coop.CoopStorage.Schedule<T>(string, System.Func<T>, System.Threading.CancellationToken, bool)`](CoopStorage.cs.md#symbol-e7e3aa0f9a7c)

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopStorage.Save(NationalSpire.Coop.CoopWorld, byte[]?)`；`NationalSpire.Coop.CoopStorage.Schedule<T>(string, System.Func<T>, System.Threading.CancellationToken, bool)`；`NationalSpire.Coop.CoopWorld.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopStorage.Save(NationalSpire.Coop.CoopWorld, byte[]?)`；输入表达式：`Save(world, run)`；返回值紧邻使用处：`ExpressionStatementSyntax: Save(world, run);`
- `NationalSpire.Coop.CoopStorage.Schedule<T>(string, System.Func<T>, System.Threading.CancellationToken, bool)`；输入表达式：`Schedule(world.Id, () => { Save(world, run); return true; }, token, true)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Schedule(world.Id, () => { Save(world, run); return true; }, token, true)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-98401b01dd9e"></a>

## `NationalSpire.Coop.CoopStorage.LoadAsync(string) — public Task<Checkpoint> LoadAsync(string id)`

来源：源码第 43 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRuntime.Connect(bool, string, string, int, string, string, string)`](CoopRuntime.cs.md#symbol-5c58a004498a)；[`NationalSpire.Coop.CoopStorage.ListAsync()`](CoopStorage.cs.md#symbol-91a27633a0d4)

**调用：** [`NationalSpire.Coop.CoopStorage.Load(string)`](CoopStorage.cs.md#symbol-efe4d419a020)；[`NationalSpire.Coop.CoopStorage.Schedule<T>(string, System.Func<T>, System.Threading.CancellationToken, bool)`](CoopStorage.cs.md#symbol-e7e3aa0f9a7c)

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopStorage.Load(string)`；`NationalSpire.Coop.CoopStorage.Schedule<T>(string, System.Func<T>, System.Threading.CancellationToken, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopStorage.Load(string)`；输入表达式：`Load(id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Load(id)`
- `NationalSpire.Coop.CoopStorage.Schedule<T>(string, System.Func<T>, System.Threading.CancellationToken, bool)`；输入表达式：`Schedule(id, () => Load(id))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Schedule(id, () => Load(id))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-fc7f730c7e18"></a>

## `NationalSpire.Coop.CoopStorage.ExportArchiveAsync(string) — public Task<byte[]> ExportArchiveAsync(string id)`

来源：源码第 44 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCareerLibrary()`](../CareerLibraryScreen.cs.md#symbol-57e1d5f83960)

**调用：** [`NationalSpire.Coop.CoopStorage.ExportArchive(string)`](CoopStorage.cs.md#symbol-2c9c2a0b54fe)；[`NationalSpire.Coop.CoopStorage.Schedule<T>(string, System.Func<T>, System.Threading.CancellationToken, bool)`](CoopStorage.cs.md#symbol-e7e3aa0f9a7c)

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopStorage.ExportArchive(string)`；`NationalSpire.Coop.CoopStorage.Schedule<T>(string, System.Func<T>, System.Threading.CancellationToken, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopStorage.ExportArchive(string)`；输入表达式：`ExportArchive(id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ExportArchive(id)`
- `NationalSpire.Coop.CoopStorage.Schedule<T>(string, System.Func<T>, System.Threading.CancellationToken, bool)`；输入表达式：`Schedule(id, () => ExportArchive(id))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Schedule(id, () => ExportArchive(id))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-896c6be28762"></a>

## `NationalSpire.Coop.CoopStorage.DeleteAsync(string) — public Task DeleteAsync(string id)`

来源：源码第 45 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCareerLibrary()`](../CareerLibraryScreen.cs.md#symbol-57e1d5f83960)；[`NationalSpire.Coop.CoopScreen.Entrance()`](CoopScreen.cs.md#symbol-ef98f9c7ba09)

**调用：** [`NationalSpire.Coop.CoopStorage.Delete(string)`](CoopStorage.cs.md#symbol-cf3c1fbdf7f4)；[`NationalSpire.Coop.CoopStorage.Schedule<T>(string, System.Func<T>, System.Threading.CancellationToken, bool)`](CoopStorage.cs.md#symbol-e7e3aa0f9a7c)

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopStorage.Delete(string)`；`NationalSpire.Coop.CoopStorage.Schedule<T>(string, System.Func<T>, System.Threading.CancellationToken, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopStorage.Delete(string)`；输入表达式：`Delete(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: Delete(id);`
- `NationalSpire.Coop.CoopStorage.Schedule<T>(string, System.Func<T>, System.Threading.CancellationToken, bool)`；输入表达式：`Schedule(id, () => { Delete(id); return true; })`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Schedule(id, () => { Delete(id); return true; })`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f6efb73a242b"></a>

## `NationalSpire.Coop.CoopStorage.ImportArchiveAsync(byte[]) — public Task<string> ImportArchiveAsync(byte[] bytes)`

来源：源码第 46 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCareerLibrary()`](../CareerLibraryScreen.cs.md#symbol-57e1d5f83960)

**调用：** [`NationalSpire.Coop.CoopStorage.ImportArchive(byte[])`](CoopStorage.cs.md#symbol-73147f08e733)；`System.Threading.Tasks.Task.Run<TResult>(System.Func<TResult>)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopStorage.ImportArchive(byte[])`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopStorage.ImportArchive(byte[])`；输入表达式：`ImportArchive(bytes)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ImportArchive(bytes)`
- `System.Threading.Tasks.Task.Run<TResult>(System.Func<TResult>)`；输入表达式：`Task.Run(() => ImportArchive(bytes))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Task.Run(() => ImportArchive(bytes))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-91a27633a0d4"></a>

## `NationalSpire.Coop.CoopStorage.ListAsync() — public async Task<List<Checkpoint>> ListAsync()`

来源：源码第 47 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCareerLibrary()`](../CareerLibraryScreen.cs.md#symbol-57e1d5f83960)；[`NationalSpire.Coop.CoopScreen.Entrance()`](CoopScreen.cs.md#symbol-ef98f9c7ba09)

**调用：** [`NationalSpire.Coop.CoopStorage.LoadAsync(string)`](CoopStorage.cs.md#symbol-98401b01dd9e)；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.IO.Directory.Exists(string?)`；`System.IO.Directory.GetDirectories(string)`；`System.IO.Path.GetFileName(string?)`；`System.Threading.Tasks.Task.Run<TResult>(System.Func<TResult>)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopStorage.LoadAsync(string)`；`NationalSpire.Coop.CoopStorage.Root`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopStorage.LoadAsync(string)`；输入表达式：`LoadAsync(Path.GetFileName(dir))`；返回值紧邻使用处：`AwaitExpressionSyntax: await LoadAsync(Path.GetFileName(dir))`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`result.Add(await LoadAsync(Path.GetFileName(dir)))`；返回值紧邻使用处：`ExpressionStatementSyntax: result.Add(await LoadAsync(Path.GetFileName(dir)));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<Checkpoint>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<Checkpoint>()`
- `System.IO.Directory.Exists(string?)`；输入表达式：`Directory.Exists(Root)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Directory.Exists(Root) ? Directory.GetDirectories(Root) : []`
- `System.IO.Directory.GetDirectories(string)`；输入表达式：`Directory.GetDirectories(Root)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Directory.Exists(Root) ? Directory.GetDirectories(Root) : []`
- `System.IO.Path.GetFileName(string?)`；输入表达式：`Path.GetFileName(dir)`；返回值紧邻使用处：`ArgumentSyntax: Path.GetFileName(dir)`
- `System.Threading.Tasks.Task.Run<TResult>(System.Func<TResult>)`；输入表达式：`Task.Run(() => Directory.Exists(Root) ? Directory.GetDirectories(Root) : [])`；返回值紧邻使用处：`AwaitExpressionSyntax: await Task.Run(() => Directory.Exists(Root) ? Directory.GetDirectories(Root) : [])`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2fdee68ee8dc"></a>

## `NationalSpire.Coop.CoopStorage.Root — public string Root`

来源：源码第 55 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9914499d45a1"></a>

## `NationalSpire.Coop.CoopStorage.DirectoryFor(string) — private string DirectoryFor(string id)`

来源：源码第 58 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopStorage.BackupBeforeDevelopment(NationalSpire.Coop.CoopWorld, byte[]?)`](CoopStorage.cs.md#symbol-955953e36f17)；[`NationalSpire.Coop.CoopStorage.Delete(string)`](CoopStorage.cs.md#symbol-cf3c1fbdf7f4)；[`NationalSpire.Coop.CoopStorage.ImportArchive(byte[])`](CoopStorage.cs.md#symbol-73147f08e733)；[`NationalSpire.Coop.CoopStorage.Load(string)`](CoopStorage.cs.md#symbol-efe4d419a020)；[`NationalSpire.Coop.CoopStorage.Save(NationalSpire.Coop.CoopWorld, byte[]?)`](CoopStorage.cs.md#symbol-a4c240447248)；[`NationalSpire.Coop.CoopStorage.Work(string)`](CoopStorage.cs.md#symbol-664485faad0d)

**调用：** `System.Guid.TryParseExact(string?, string?, out System.Guid)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.IO.Path.Combine(string, string)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopStorage.Root`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Guid.TryParseExact(string?, string?, out System.Guid)`；输入表达式：`Guid.TryParseExact(id, "N", out _)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Guid.TryParseExact(id, "N", out _)`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("生涯标识无效。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("生涯标识无效。");`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(Root, id)`；返回值紧邻使用处：`ReturnStatementSyntax: return Path.Combine(Root, id);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-987dca599488"></a>

## `NationalSpire.Coop.CoopStorage.List() — public IEnumerable<Checkpoint> List()`

来源：源码第 63 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopStorage.Load(string)`](CoopStorage.cs.md#symbol-efe4d419a020)；`System.IO.Directory.Exists(string?)`；`System.IO.Directory.GetDirectories(string)`；`System.IO.Path.GetFileName(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopStorage.Load(string)`；`NationalSpire.Coop.CoopStorage.Root`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopStorage.Load(string)`；输入表达式：`Load(Path.GetFileName(dir))`；返回值紧邻使用处：`AssignmentExpressionSyntax: cp = Load(Path.GetFileName(dir))`
- `System.IO.Directory.Exists(string?)`；输入表达式：`Directory.Exists(Root)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Directory.Exists(Root)`
- `System.IO.Directory.GetDirectories(string)`；输入表达式：`Directory.GetDirectories(Root)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var dir in Directory.GetDirectories(Root))          {              Checkpoint? cp = null;              try { cp = Load(Path.GetFileName(dir)); } catch { }              if (cp != null) yield return cp;          }`
- `System.IO.Path.GetFileName(string?)`；输入表达式：`Path.GetFileName(dir)`；返回值紧邻使用处：`ArgumentSyntax: Path.GetFileName(dir)`

**赋值（含属性/字段和局部值）：**

- `cp` = `Load(Path.GetFileName(dir))`

<a id="symbol-9dfe7ef480f7"></a>

## `NationalSpire.Coop.CoopStorage.PublicCopy(NationalSpire.Coop.CoopWorld) — public static CoopWorld PublicCopy(CoopWorld world)`

来源：源码第 73 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCareerSession.Export()`](CoopCareerSession.cs.md#symbol-24a80da4bec4)

**调用：** [`NationalSpire.Coop.CoopJson.PublicBytes<T>(T)`](CoopData.cs.md#symbol-3f5e7638f9e9)；[`NationalSpire.Coop.CoopJson.Read<T>(byte[])`](CoopData.cs.md#symbol-1f7bf7625062)

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopJson.PublicBytes<T>(T)`；`NationalSpire.Coop.CoopJson.Read<T>(byte[])`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopJson.PublicBytes<T>(T)`；输入表达式：`CoopJson.PublicBytes(world)`；返回值紧邻使用处：`ArgumentSyntax: CoopJson.PublicBytes(world)`
- `NationalSpire.Coop.CoopJson.Read<T>(byte[])`；输入表达式：`CoopJson.Read<CoopWorld>(CoopJson.PublicBytes(world))`；返回值紧邻使用处：`ReturnStatementSyntax: return CoopJson.Read<CoopWorld>(CoopJson.PublicBytes(world));`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4eabc44f08d2"></a>

## `NationalSpire.Coop.CoopStorage.IsArchive(byte[]) — public static bool IsArchive(byte[] bytes)`

来源：源码第 77 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCareerLibrary()`](../CareerLibraryScreen.cs.md#symbol-57e1d5f83960)

**调用：** `System.IO.Compression.ZipArchive.GetEntry(string)`；`System.IO.Compression.ZipArchive.ZipArchive(System.IO.Stream, System.IO.Compression.ZipArchiveMode)`；`System.IO.MemoryStream.MemoryStream(byte[])`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.IO.Compression.ZipArchive.GetEntry(string)`；输入表达式：`zip.GetEntry("world.json")`；返回值紧邻使用处：`BinaryExpressionSyntax: zip.GetEntry("world.json") != null`
- `System.IO.Compression.ZipArchive.ZipArchive(System.IO.Stream, System.IO.Compression.ZipArchiveMode)`；输入表达式：`new ZipArchive(new MemoryStream(bytes), ZipArchiveMode.Read)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ZipArchive(new MemoryStream(bytes), ZipArchiveMode.Read)`
- `System.IO.MemoryStream.MemoryStream(byte[])`；输入表达式：`new MemoryStream(bytes)`；返回值紧邻使用处：`ArgumentSyntax: new MemoryStream(bytes)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2c9c2a0b54fe"></a>

## `NationalSpire.Coop.CoopStorage.ExportArchive(string) — public byte[] ExportArchive(string id)`

来源：源码第 82 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopStorage.ExportArchiveAsync(string)`](CoopStorage.cs.md#symbol-fc7f730c7e18)

**调用：** [`NationalSpire.Coop.CoopJson.PublicBytes<T>(T)`](CoopData.cs.md#symbol-3f5e7638f9e9)；[`NationalSpire.Coop.CoopStorage.Load(string)`](CoopStorage.cs.md#symbol-efe4d419a020)；`System.IO.Compression.ZipArchive.CreateEntry(string)`；`System.IO.Compression.ZipArchive.ZipArchive(System.IO.Stream, System.IO.Compression.ZipArchiveMode, bool)`；`System.IO.Compression.ZipArchiveEntry.Open()`；`System.IO.MemoryStream.MemoryStream()`；`System.IO.MemoryStream.ToArray()`；`System.IO.Stream.Write(System.ReadOnlySpan<byte>)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopJson.PublicBytes<T>(T)`；`NationalSpire.Coop.CoopStorage.Checkpoint.Run`；`NationalSpire.Coop.CoopStorage.Checkpoint.World`；`NationalSpire.Coop.CoopStorage.Load(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopJson.PublicBytes<T>(T)`；输入表达式：`CoopJson.PublicBytes(checkpoint.World)`；返回值紧邻使用处：`ArgumentSyntax: CoopJson.PublicBytes(checkpoint.World)`
- `NationalSpire.Coop.CoopStorage.Load(string)`；输入表达式：`Load(id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Load(id)`
- `System.IO.Compression.ZipArchive.CreateEntry(string)`；输入表达式：`zip.CreateEntry("run.bin")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: zip.CreateEntry("run.bin").Open`
- `System.IO.Compression.ZipArchive.CreateEntry(string)`；输入表达式：`zip.CreateEntry("world.json")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: zip.CreateEntry("world.json").Open`
- `System.IO.Compression.ZipArchive.ZipArchive(System.IO.Stream, System.IO.Compression.ZipArchiveMode, bool)`；输入表达式：`new ZipArchive(buffer, ZipArchiveMode.Create, true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ZipArchive(buffer, ZipArchiveMode.Create, true)`
- `System.IO.Compression.ZipArchiveEntry.Open()`；输入表达式：`zip.CreateEntry("run.bin").Open()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = zip.CreateEntry("run.bin").Open()`
- `System.IO.Compression.ZipArchiveEntry.Open()`；输入表达式：`zip.CreateEntry("world.json").Open()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = zip.CreateEntry("world.json").Open()`
- `System.IO.MemoryStream.MemoryStream()`；输入表达式：`new MemoryStream()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MemoryStream()`
- `System.IO.MemoryStream.ToArray()`；输入表达式：`buffer.ToArray()`；返回值紧邻使用处：`ReturnStatementSyntax: return buffer.ToArray();`
- `System.IO.Stream.Write(System.ReadOnlySpan<byte>)`；输入表达式：`stream.Write(checkpoint.Run)`；返回值紧邻使用处：`ExpressionStatementSyntax: stream.Write(checkpoint.Run);`
- `System.IO.Stream.Write(System.ReadOnlySpan<byte>)`；输入表达式：`stream.Write(CoopJson.PublicBytes(checkpoint.World))`；返回值紧邻使用处：`ExpressionStatementSyntax: stream.Write(CoopJson.PublicBytes(checkpoint.World));`

**赋值（含属性/字段和局部值）：**


<a id="symbol-73147f08e733"></a>

## `NationalSpire.Coop.CoopStorage.ImportArchive(byte[]) — public string ImportArchive(byte[] bytes)`

来源：源码第 93 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopStorage.ImportArchiveAsync(byte[])`](CoopStorage.cs.md#symbol-f6efb73a242b)

**调用：** [`NationalSpire.Coop.CoopJson.Read<T>(byte[])`](CoopData.cs.md#symbol-1f7bf7625062)；[`NationalSpire.Coop.CoopStorage.DirectoryFor(string)`](CoopStorage.cs.md#symbol-9914499d45a1)；[`NationalSpire.Coop.CoopStorage.Save(NationalSpire.Coop.CoopWorld, byte[]?)`](CoopStorage.cs.md#symbol-a4c240447248)；[`NationalSpire.Coop.CoopStorage.Work(string)`](CoopStorage.cs.md#symbol-664485faad0d)；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`；`System.Guid.TryParseExact(string?, string?, out System.Guid)`；`System.IO.Compression.ZipArchive.GetEntry(string)`；`System.IO.Compression.ZipArchive.ZipArchive(System.IO.Stream, System.IO.Compression.ZipArchiveMode)`；`System.IO.Compression.ZipArchiveEntry.Open()`；`System.IO.Directory.CreateDirectory(string)`；`System.IO.Directory.Exists(string?)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.IO.MemoryStream.MemoryStream()`；`System.IO.MemoryStream.MemoryStream(byte[])`；`System.IO.MemoryStream.ToArray()`；`System.IO.Stream.CopyTo(System.IO.Stream)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.People`；`NationalSpire.CareerData.WorldId`；`NationalSpire.Coop.CoopJson.Read<T>(byte[])`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopRun.Phase`；`NationalSpire.Coop.CoopRun.Terminal`；`NationalSpire.Coop.CoopStorage.DirectoriesGate`；`NationalSpire.Coop.CoopStorage.DirectoryFor(string)`；`NationalSpire.Coop.CoopStorage.DirectoryWork.Writes`；`NationalSpire.Coop.CoopStorage.Save(NationalSpire.Coop.CoopWorld, byte[]?)`；`NationalSpire.Coop.CoopStorage.Work(string)`；`NationalSpire.Coop.CoopWorld.Id`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.Owner`；`NationalSpire.Coop.CoopWorld.Proposal`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Coop.CoopWorld.Schema`；`NationalSpire.Coop.CoopWorld.World`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopJson.Read<T>(byte[])`；输入表达式：`CoopJson.Read<CoopWorld>(buffer.ToArray())`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopJson.Read<CoopWorld>(buffer.ToArray())`
- `NationalSpire.Coop.CoopStorage.DirectoryFor(string)`；输入表达式：`DirectoryFor(world.Id)`；返回值紧邻使用处：`ArgumentSyntax: DirectoryFor(world.Id)`
- `NationalSpire.Coop.CoopStorage.Save(NationalSpire.Coop.CoopWorld, byte[]?)`；输入表达式：`Save(world, run)`；返回值紧邻使用处：`ExpressionStatementSyntax: Save(world, run);`
- `NationalSpire.Coop.CoopStorage.Work(string)`；输入表达式：`Work(world.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Work(world.Id).Writes`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`world.Members.Select(m => m.SteamId).Distinct().Count()`；返回值紧邻使用处：`BinaryExpressionSyntax: world.Members.Select(m => m.SteamId).Distinct().Count() != world.Members.Count`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`world.Members.Select(m => m.SteamId).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: world.Members.Select(m => m.SteamId).Distinct().Count`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`world.Members.Select(m => m.SteamId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: world.Members.Select(m => m.SteamId).Distinct`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`AssignmentExpressionSyntax: world.Id = Guid.NewGuid().ToString("N")`
- `System.Guid.TryParseExact(string?, string?, out System.Guid)`；输入表达式：`Guid.TryParseExact(world.Id, "N", out _)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Guid.TryParseExact(world.Id, "N", out _)`
- `System.IO.Compression.ZipArchive.GetEntry(string)`；输入表达式：`zip.GetEntry("run.bin")`；返回值紧邻使用处：`IsPatternExpressionSyntax: zip.GetEntry("run.bin") is { } native`
- `System.IO.Compression.ZipArchive.GetEntry(string)`；输入表达式：`zip.GetEntry("world.json")`；返回值紧邻使用处：`BinaryExpressionSyntax: zip.GetEntry("world.json") ?? throw new InvalidDataException("没有多人生涯内容。")`
- `System.IO.Compression.ZipArchive.ZipArchive(System.IO.Stream, System.IO.Compression.ZipArchiveMode)`；输入表达式：`new ZipArchive(new MemoryStream(bytes), ZipArchiveMode.Read)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ZipArchive(new MemoryStream(bytes), ZipArchiveMode.Read)`
- `System.IO.Compression.ZipArchiveEntry.Open()`；输入表达式：`(zip.GetEntry("world.json") ?? throw new InvalidDataException("没有多人生涯内容。")).Open()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = (zip.GetEntry("world.json") ?? throw new InvalidDataException("没有多人生涯内容。")).Open()`
- `System.IO.Compression.ZipArchiveEntry.Open()`；输入表达式：`native.Open()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = native.Open()`
- `System.IO.Directory.CreateDirectory(string)`；输入表达式：`Directory.CreateDirectory(DirectoryFor(world.Id))`；返回值紧邻使用处：`ExpressionStatementSyntax: Directory.CreateDirectory(DirectoryFor(world.Id));`
- `System.IO.Directory.Exists(string?)`；输入表达式：`Directory.Exists(DirectoryFor(world.Id))`；返回值紧邻使用处：`BinaryExpressionSyntax: Directory.Exists(DirectoryFor(world.Id)) || Work(world.Id).Writes > 0`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("比赛存档缺失。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("比赛存档缺失。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("多人生涯结构无效。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("多人生涯结构无效。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("没有多人生涯内容。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidDataException("没有多人生涯内容。")`
- `System.IO.MemoryStream.MemoryStream()`；输入表达式：`new MemoryStream()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MemoryStream()`
- `System.IO.MemoryStream.MemoryStream(byte[])`；输入表达式：`new MemoryStream(bytes)`；返回值紧邻使用处：`ArgumentSyntax: new MemoryStream(bytes)`
- `System.IO.MemoryStream.ToArray()`；输入表达式：`buffer.ToArray()`；返回值紧邻使用处：`ArgumentSyntax: buffer.ToArray()`
- `System.IO.MemoryStream.ToArray()`；输入表达式：`target.ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: run = target.ToArray()`
- `System.IO.Stream.CopyTo(System.IO.Stream)`；输入表达式：`source.CopyTo(buffer)`；返回值紧邻使用处：`ExpressionStatementSyntax: source.CopyTo(buffer);`
- `System.IO.Stream.CopyTo(System.IO.Stream)`；输入表达式：`stream.CopyTo(target)`；返回值紧邻使用处：`ExpressionStatementSyntax: stream.CopyTo(target);`

**赋值（含属性/字段和局部值）：**

- `run` = `target.ToArray()`
- `world.Id` = `Guid.NewGuid().ToString("N")`
- `world.Proposal` = `null`
- `world.World.WorldId` = `world.Id`

<a id="symbol-955953e36f17"></a>

## `NationalSpire.Coop.CoopStorage.BackupBeforeDevelopment(NationalSpire.Coop.CoopWorld, byte[]?) — public void BackupBeforeDevelopment(CoopWorld world, byte[]? run)`

来源：源码第 110 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.CoopCoordinator(NationalSpire.Coop.ICoopTransport, NationalSpire.Coop.CoopStorage, string, string, string, System.Collections.Generic.IReadOnlySet<string>, NationalSpire.Coop.CoopStorage.Checkpoint?)`](CoopCoordinator.cs.md#symbol-778097f34ec3)

**调用：** [`NationalSpire.Coop.CoopJson.PublicBytes<T>(T)`](CoopData.cs.md#symbol-3f5e7638f9e9)；[`NationalSpire.Coop.CoopStorage.DirectoryFor(string)`](CoopStorage.cs.md#symbol-9914499d45a1)；[`NationalSpire.Coop.CoopStorage.Durable(string, byte[])`](CoopStorage.cs.md#symbol-db05a63d4feb)；[`NationalSpire.Coop.CoopStorage.Work(string)`](CoopStorage.cs.md#symbol-664485faad0d)；`System.IO.Directory.CreateDirectory(string)`；`System.IO.File.Exists(string?)`；`System.IO.Path.Combine(string, string)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopJson.PublicBytes<T>(T)`；`NationalSpire.Coop.CoopStorage.DirectoryFor(string)`；`NationalSpire.Coop.CoopStorage.DirectoryWork.Gate`；`NationalSpire.Coop.CoopStorage.Durable(string, byte[])`；`NationalSpire.Coop.CoopStorage.Work(string)`；`NationalSpire.Coop.CoopWorld.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopJson.PublicBytes<T>(T)`；输入表达式：`CoopJson.PublicBytes(world)`；返回值紧邻使用处：`ArgumentSyntax: CoopJson.PublicBytes(world)`
- `NationalSpire.Coop.CoopStorage.DirectoryFor(string)`；输入表达式：`DirectoryFor(world.Id)`；返回值紧邻使用处：`ArgumentSyntax: DirectoryFor(world.Id)`
- `NationalSpire.Coop.CoopStorage.Durable(string, byte[])`；输入表达式：`Durable(file, CoopJson.PublicBytes(world))`；返回值紧邻使用处：`ExpressionStatementSyntax: Durable(file, CoopJson.PublicBytes(world));`
- `NationalSpire.Coop.CoopStorage.Durable(string, byte[])`；输入表达式：`Durable(Path.Combine(dir, "run.bin"), run)`；返回值紧邻使用处：`ExpressionStatementSyntax: Durable(Path.Combine(dir, "run.bin"), run);`
- `NationalSpire.Coop.CoopStorage.Work(string)`；输入表达式：`Work(world.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Work(world.Id).Gate`
- `System.IO.Directory.CreateDirectory(string)`；输入表达式：`Directory.CreateDirectory(dir)`；返回值紧邻使用处：`ExpressionStatementSyntax: Directory.CreateDirectory(dir);`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(file)`；返回值紧邻使用处：`IfStatementSyntax: if (File.Exists(file)) return;`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(dir, "run.bin")`；返回值紧邻使用处：`ArgumentSyntax: Path.Combine(dir, "run.bin")`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(dir, "world.json")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Path.Combine(dir, "world.json")`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(DirectoryFor(world.Id), "pre-development3")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Path.Combine(DirectoryFor(world.Id), "pre-development3")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-cf3c1fbdf7f4"></a>

## `NationalSpire.Coop.CoopStorage.Delete(string) — public void Delete(string id)`

来源：源码第 122 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopStorage.DeleteAsync(string)`](CoopStorage.cs.md#symbol-896c6be28762)

**调用：** [`NationalSpire.Coop.CoopStorage.DirectoryFor(string)`](CoopStorage.cs.md#symbol-9914499d45a1)；[`NationalSpire.Coop.CoopStorage.Work(string)`](CoopStorage.cs.md#symbol-664485faad0d)；`string.StartsWith(string, System.StringComparison)`；`string.TrimEnd(char)`；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`；`System.IO.Directory.CreateDirectory(string)`；`System.IO.Directory.Exists(string?)`；`System.IO.Directory.Move(string, string)`；`System.IO.File.GetAttributes(string)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.IO.Path.Combine(string, string)`；`System.IO.Path.GetFullPath(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopStorage.DirectoryFor(string)`；`NationalSpire.Coop.CoopStorage.DirectoryWork.Gate`；`NationalSpire.Coop.CoopStorage.Root`；`NationalSpire.Coop.CoopStorage.Work(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopStorage.DirectoryFor(string)`；输入表达式：`DirectoryFor(id)`；返回值紧邻使用处：`ArgumentSyntax: DirectoryFor(id)`
- `NationalSpire.Coop.CoopStorage.Work(string)`；输入表达式：`Work(id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Work(id).Gate`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`source.StartsWith(rootPath, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !source.StartsWith(rootPath, StringComparison.OrdinalIgnoreCase)`
- `string.TrimEnd(char)`；输入表达式：`Path.GetFullPath(Root).TrimEnd(Path.DirectorySeparatorChar)`；返回值紧邻使用处：`BinaryExpressionSyntax: Path.GetFullPath(Root).TrimEnd(Path.DirectorySeparatorChar) + Path.DirectorySeparatorChar`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`BinaryExpressionSyntax: id + "-" + Guid.NewGuid().ToString("N")`
- `System.IO.Directory.CreateDirectory(string)`；输入表达式：`Directory.CreateDirectory(deleted)`；返回值紧邻使用处：`ExpressionStatementSyntax: Directory.CreateDirectory(deleted);`
- `System.IO.Directory.Exists(string?)`；输入表达式：`Directory.Exists(source)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Directory.Exists(source)`
- `System.IO.Directory.Move(string, string)`；输入表达式：`Directory.Move(source, Path.Combine(deleted, id + "-" + Guid.NewGuid().ToString("N")))`；返回值紧邻使用处：`ExpressionStatementSyntax: Directory.Move(source, Path.Combine(deleted, id + "-" + Guid.NewGuid().ToString("N")));`
- `System.IO.File.GetAttributes(string)`；输入表达式：`File.GetAttributes(source)`；返回值紧邻使用处：`BinaryExpressionSyntax: File.GetAttributes(source) & FileAttributes.ReparsePoint`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("不能删除重定向目录。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("不能删除重定向目录。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("存档路径无效。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("存档路径无效。");`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(deleted, id + "-" + Guid.NewGuid().ToString("N"))`；返回值紧邻使用处：`ArgumentSyntax: Path.Combine(deleted, id + "-" + Guid.NewGuid().ToString("N"))`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(Root, ".deleted")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Path.Combine(Root, ".deleted")`
- `System.IO.Path.GetFullPath(string)`；输入表达式：`Path.GetFullPath(DirectoryFor(id))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Path.GetFullPath(DirectoryFor(id))`
- `System.IO.Path.GetFullPath(string)`；输入表达式：`Path.GetFullPath(Root)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Path.GetFullPath(Root).TrimEnd`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a4c240447248"></a>

## `NationalSpire.Coop.CoopStorage.Save(NationalSpire.Coop.CoopWorld, byte[]?) — public void Save(CoopWorld world, byte[]? run)`

来源：源码第 136 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`](CoopCoordinator.cs.md#symbol-e1dfe22e8221)；[`NationalSpire.Coop.CoopStorage.ImportArchive(byte[])`](CoopStorage.cs.md#symbol-73147f08e733)；[`NationalSpire.Coop.CoopStorage.SaveAsync(NationalSpire.Coop.CoopWorld, byte[]?, System.Threading.CancellationToken)`](CoopStorage.cs.md#symbol-26bf729f0b72)

**调用：** [`NationalSpire.Coop.CoopJson.Bytes<T>(T)`](CoopData.cs.md#symbol-faeb54cab7ee)；[`NationalSpire.Coop.CoopJson.Hash(byte[])`](CoopData.cs.md#symbol-ca6c9ee59a2a)；[`NationalSpire.Coop.CoopJson.PublicBytes<T>(T)`](CoopData.cs.md#symbol-3f5e7638f9e9)；[`NationalSpire.Coop.CoopJson.Read<T>(byte[])`](CoopData.cs.md#symbol-1f7bf7625062)；[`NationalSpire.Coop.CoopStorage.DirectoryFor(string)`](CoopStorage.cs.md#symbol-9914499d45a1)；[`NationalSpire.Coop.CoopStorage.Durable(string, byte[])`](CoopStorage.cs.md#symbol-db05a63d4feb)；[`NationalSpire.Coop.CoopStorage.Work(string)`](CoopStorage.cs.md#symbol-664485faad0d)；[`NationalSpire.Coop.CoopWorld.CheckpointHeader(string)`](CoopData.cs.md#symbol-c00698332c46)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](../UiPerformance.cs.md#symbol-fb8ca8555fbe)；`NationalSpire.Coop.CoopStorage.Manifest.Manifest(string, string, string)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.HashSet<T>.HashSet()`；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`；`System.Guid.TryParseExact(string?, string?, out System.Guid)`；`System.IO.Directory.CreateDirectory(string)`；`System.IO.Directory.Delete(string, bool)`；`System.IO.Directory.GetDirectories(string)`；`System.IO.File.Exists(string?)`；`System.IO.File.Move(string, string)`；`System.IO.File.ReadAllBytes(string)`；`System.IO.File.Replace(string, string, string?)`；`System.IO.Path.Combine(string, string)`；`System.IO.Path.GetFileName(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopJson.Bytes<T>(T)`；`NationalSpire.Coop.CoopJson.Hash(byte[])`；`NationalSpire.Coop.CoopJson.PublicBytes<T>(T)`；`NationalSpire.Coop.CoopJson.Read<T>(byte[])`；`NationalSpire.Coop.CoopStorage.DirectoryFor(string)`；`NationalSpire.Coop.CoopStorage.DirectoryWork.Gate`；`NationalSpire.Coop.CoopStorage.Durable(string, byte[])`；`NationalSpire.Coop.CoopStorage.Manifest.Directory`；`NationalSpire.Coop.CoopStorage.Work(string)`；`NationalSpire.Coop.CoopWorld.CheckpointHeader(string)`；`NationalSpire.Coop.CoopWorld.Id`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.CoopCleanup`；`NationalSpire.UiPerformance.Work.CoopHash`；`NationalSpire.UiPerformance.Work.CoopManifest`；`NationalSpire.UiPerformance.Work.CoopSave`；`NationalSpire.UiPerformance.Work.CoopSerialize`；`NationalSpire.UiPerformance.Work.CoopWriteRun`；`NationalSpire.UiPerformance.Work.CoopWriteWorld`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopJson.Bytes<T>(T)`；输入表达式：`CoopJson.Bytes(manifest)`；返回值紧邻使用处：`ArgumentSyntax: CoopJson.Bytes(manifest)`
- `NationalSpire.Coop.CoopJson.Hash(byte[])`；输入表达式：`CoopJson.Hash(bytes)`；返回值紧邻使用处：`ArgumentSyntax: CoopJson.Hash(bytes)`
- `NationalSpire.Coop.CoopJson.Hash(byte[])`；输入表达式：`CoopJson.Hash(run)`；返回值紧邻使用处：`ConditionalExpressionSyntax: run == null ? "" : CoopJson.Hash(run)`
- `NationalSpire.Coop.CoopJson.PublicBytes<T>(T)`；输入表达式：`CoopJson.PublicBytes(world.CheckpointHeader(id))`；返回值紧邻使用处：`AssignmentExpressionSyntax: bytes = CoopJson.PublicBytes(world.CheckpointHeader(id))`
- `NationalSpire.Coop.CoopJson.Read<T>(byte[])`；输入表达式：`CoopJson.Read<Manifest>(File.ReadAllBytes(Path.Combine(dir, "previous.json")))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CoopJson.Read<Manifest>(File.ReadAllBytes(Path.Combine(dir, "previous.json"))).Directory`
- `NationalSpire.Coop.CoopStorage.DirectoryFor(string)`；输入表达式：`DirectoryFor(world.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DirectoryFor(world.Id)`
- `NationalSpire.Coop.CoopStorage.Durable(string, byte[])`；输入表达式：`Durable(next, CoopJson.Bytes(manifest))`；返回值紧邻使用处：`ExpressionStatementSyntax: Durable(next, CoopJson.Bytes(manifest));`
- `NationalSpire.Coop.CoopStorage.Durable(string, byte[])`；输入表达式：`Durable(Path.Combine(checkpoint, "run.bin"), run)`；返回值紧邻使用处：`ExpressionStatementSyntax: Durable(Path.Combine(checkpoint, "run.bin"), run);`
- `NationalSpire.Coop.CoopStorage.Durable(string, byte[])`；输入表达式：`Durable(Path.Combine(checkpoint, "world.json"), bytes)`；返回值紧邻使用处：`ExpressionStatementSyntax: Durable(Path.Combine(checkpoint, "world.json"), bytes);`
- `NationalSpire.Coop.CoopStorage.Manifest.Manifest(string, string, string)`；输入表达式：`new Manifest(id, CoopJson.Hash(bytes), run == null ? "" : CoopJson.Hash(run))`；返回值紧邻使用处：`AssignmentExpressionSyntax: manifest = new Manifest(id, CoopJson.Hash(bytes), run == null ? "" : CoopJson.Hash(run))`
- `NationalSpire.Coop.CoopStorage.Work(string)`；输入表达式：`Work(world.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Work(world.Id).Gate`
- `NationalSpire.Coop.CoopWorld.CheckpointHeader(string)`；输入表达式：`world.CheckpointHeader(id)`；返回值紧邻使用处：`ArgumentSyntax: world.CheckpointHeader(id)`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.CoopCleanup)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.CoopCleanup)`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.CoopHash)`；返回值紧邻使用处：`UsingStatementSyntax: using (UiPerformance.Measure(UiPerformance.Work.CoopHash)) manifest = new Manifest(id, CoopJson.Hash(bytes), run == null ? "" : CoopJson.Hash(run));`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.CoopManifest)`；返回值紧邻使用处：`UsingStatementSyntax: using (UiPerformance.Measure(UiPerformance.Work.CoopManifest))          {              Durable(next, CoopJson.Bytes(manifest));              if (File.Exists(current)) File.Replace(next, current, Path.Combine(dir, "previous.json"));              else File.Move(next, current);          }`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.CoopSave)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.CoopSave)`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.CoopSerialize)`；返回值紧邻使用处：`UsingStatementSyntax: using (UiPerformance.Measure(UiPerformance.Work.CoopSerialize)) bytes = CoopJson.PublicBytes(world.CheckpointHeader(id));`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.CoopWriteRun)`；返回值紧邻使用处：`UsingStatementSyntax: using (UiPerformance.Measure(UiPerformance.Work.CoopWriteRun)) Durable(Path.Combine(checkpoint, "run.bin"), run);`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.CoopWriteWorld)`；返回值紧邻使用处：`UsingStatementSyntax: using (UiPerformance.Measure(UiPerformance.Work.CoopWriteWorld)) Durable(Path.Combine(checkpoint, "world.json"), bytes);`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`keep.Add(CoopJson.Read<Manifest>(File.ReadAllBytes(Path.Combine(dir, "previous.json"))).Directory)`；返回值紧邻使用处：`ExpressionStatementSyntax: keep.Add(CoopJson.Read<Manifest>(File.ReadAllBytes(Path.Combine(dir, "previous.json"))).Directory);`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`keep.Contains(Path.GetFileName(old))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !keep.Contains(Path.GetFileName(old))`
- `System.Collections.Generic.HashSet<T>.HashSet()`；输入表达式：`new HashSet<string> { id }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HashSet<string> { id }`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Guid.NewGuid().ToString("N")`
- `System.Guid.TryParseExact(string?, string?, out System.Guid)`；输入表达式：`Guid.TryParseExact(Path.GetFileName(old), "N", out _)`；返回值紧邻使用处：`BinaryExpressionSyntax: Guid.TryParseExact(Path.GetFileName(old), "N", out _) && !keep.Contains(Path.GetFileName(old))`
- `System.IO.Directory.CreateDirectory(string)`；输入表达式：`Directory.CreateDirectory(checkpoint)`；返回值紧邻使用处：`ExpressionStatementSyntax: Directory.CreateDirectory(checkpoint);`
- `System.IO.Directory.Delete(string, bool)`；输入表达式：`Directory.Delete(old, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Directory.Delete(old, true);`
- `System.IO.Directory.GetDirectories(string)`；输入表达式：`Directory.GetDirectories(dir)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var old in Directory.GetDirectories(dir))              if (Guid.TryParseExact(Path.GetFileName(old), "N", out _) && !keep.Contains(Path.GetFileName(old)))                  try { Directory.Delete(old, true); } catch { }`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(current)`；返回值紧邻使用处：`IfStatementSyntax: if (File.Exists(current)) File.Replace(next, current, Path.Combine(dir, "previous.json"));              else File.Move(next, current);`
- `System.IO.File.Move(string, string)`；输入表达式：`File.Move(next, current)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Move(next, current);`
- `System.IO.File.ReadAllBytes(string)`；输入表达式：`File.ReadAllBytes(Path.Combine(dir, "previous.json"))`；返回值紧邻使用处：`ArgumentSyntax: File.ReadAllBytes(Path.Combine(dir, "previous.json"))`
- `System.IO.File.Replace(string, string, string?)`；输入表达式：`File.Replace(next, current, Path.Combine(dir, "previous.json"))`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Replace(next, current, Path.Combine(dir, "previous.json"));`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(checkpoint, "run.bin")`；返回值紧邻使用处：`ArgumentSyntax: Path.Combine(checkpoint, "run.bin")`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(checkpoint, "world.json")`；返回值紧邻使用处：`ArgumentSyntax: Path.Combine(checkpoint, "world.json")`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(dir, "current.json")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Path.Combine(dir, "current.json")`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(dir, "previous.json")`；返回值紧邻使用处：`ArgumentSyntax: Path.Combine(dir, "previous.json")`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(dir, id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Path.Combine(dir, id)`
- `System.IO.Path.GetFileName(string?)`；输入表达式：`Path.GetFileName(old)`；返回值紧邻使用处：`ArgumentSyntax: Path.GetFileName(old)`

**赋值（含属性/字段和局部值）：**

- `bytes` = `CoopJson.PublicBytes(world.CheckpointHeader(id))`
- `manifest` = `new Manifest(id, CoopJson.Hash(bytes), run == null ? "" : CoopJson.Hash(run))`

<a id="symbol-efe4d419a020"></a>

## `NationalSpire.Coop.CoopStorage.Load(string) — public Checkpoint Load(string id)`

来源：源码第 166 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopStorage.ExportArchive(string)`](CoopStorage.cs.md#symbol-2c9c2a0b54fe)；[`NationalSpire.Coop.CoopStorage.List()`](CoopStorage.cs.md#symbol-987dca599488)；[`NationalSpire.Coop.CoopStorage.LoadAsync(string)`](CoopStorage.cs.md#symbol-98401b01dd9e)

**调用：** [`NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`](CoopData.cs.md#symbol-85d2410ea3ba)；[`NationalSpire.Coop.CoopJson.Hash(byte[])`](CoopData.cs.md#symbol-ca6c9ee59a2a)；[`NationalSpire.Coop.CoopJson.Read<T>(byte[])`](CoopData.cs.md#symbol-1f7bf7625062)；[`NationalSpire.Coop.CoopStorage.DirectoryFor(string)`](CoopStorage.cs.md#symbol-9914499d45a1)；[`NationalSpire.Coop.CoopStorage.Work(string)`](CoopStorage.cs.md#symbol-664485faad0d)；[`NationalSpire.Diagnostics.RetainErrors(NationalSpire.Coop.CoopWorld)`](../ErrorDiagnostics.cs.md#symbol-fd99f468e9e7)；`NationalSpire.Coop.CoopStorage.Checkpoint.Checkpoint(NationalSpire.Coop.CoopWorld, byte[]?)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Guid.TryParseExact(string?, string?, out System.Guid)`；`System.IO.File.ReadAllBytes(string)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.IO.Path.Combine(string, string)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`；`NationalSpire.Coop.CoopJson.Hash(byte[])`；`NationalSpire.Coop.CoopJson.Read<T>(byte[])`；`NationalSpire.Coop.CoopRun.Phase`；`NationalSpire.Coop.CoopStorage.DirectoryFor(string)`；`NationalSpire.Coop.CoopStorage.DirectoryWork.Gate`；`NationalSpire.Coop.CoopStorage.Manifest.Directory`；`NationalSpire.Coop.CoopStorage.Manifest.RunHash`；`NationalSpire.Coop.CoopStorage.Manifest.WorldHash`；`NationalSpire.Coop.CoopStorage.Work(string)`；`NationalSpire.Coop.CoopWorld.Id`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Coop.CoopWorld.Schema`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.Diagnostics.RetainErrors(NationalSpire.Coop.CoopWorld)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`；输入表达式：`CoopJson.Detached(w.World)`；返回值紧邻使用处：`ExpressionStatementSyntax: CoopJson.Detached(w.World);`
- `NationalSpire.Coop.CoopJson.Hash(byte[])`；输入表达式：`CoopJson.Hash(bytes)`；返回值紧邻使用处：`BinaryExpressionSyntax: CoopJson.Hash(bytes) != m.WorldHash`
- `NationalSpire.Coop.CoopJson.Hash(byte[])`；输入表达式：`CoopJson.Hash(run)`；返回值紧邻使用处：`BinaryExpressionSyntax: CoopJson.Hash(run) != m.RunHash`
- `NationalSpire.Coop.CoopJson.Read<T>(byte[])`；输入表达式：`CoopJson.Read<CoopWorld>(bytes)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopJson.Read<CoopWorld>(bytes)`
- `NationalSpire.Coop.CoopJson.Read<T>(byte[])`；输入表达式：`CoopJson.Read<Manifest>(File.ReadAllBytes(Path.Combine(dir, name)))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopJson.Read<Manifest>(File.ReadAllBytes(Path.Combine(dir, name)))`
- `NationalSpire.Coop.CoopStorage.Checkpoint.Checkpoint(NationalSpire.Coop.CoopWorld, byte[]?)`；输入表达式：`new(w, run)`；返回值紧邻使用处：`ReturnStatementSyntax: return new(w, run);`
- `NationalSpire.Coop.CoopStorage.DirectoryFor(string)`；输入表达式：`DirectoryFor(id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DirectoryFor(id)`
- `NationalSpire.Coop.CoopStorage.Work(string)`；输入表达式：`Work(id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Work(id).Gate`
- `NationalSpire.Diagnostics.RetainErrors(NationalSpire.Coop.CoopWorld)`；输入表达式：`Diagnostics.RetainErrors(w)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.RetainErrors(w);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`candidates.Add((m, bytes, run))`；返回值紧邻使用处：`ExpressionStatementSyntax: candidates.Add((m, bytes, run));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<(Manifest Manifest, byte[] World, byte[]? Run)>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<(Manifest Manifest, byte[] World, byte[]? Run)>()`
- `System.Guid.TryParseExact(string?, string?, out System.Guid)`；输入表达式：`Guid.TryParseExact(m.Directory, "N", out _)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Guid.TryParseExact(m.Directory, "N", out _)`
- `System.IO.File.ReadAllBytes(string)`；输入表达式：`File.ReadAllBytes(Path.Combine(cp, "run.bin"))`；返回值紧邻使用处：`ConditionalExpressionSyntax: m.RunHash.Length == 0 ? null : File.ReadAllBytes(Path.Combine(cp, "run.bin"))`
- `System.IO.File.ReadAllBytes(string)`；输入表达式：`File.ReadAllBytes(Path.Combine(cp, "world.json"))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = File.ReadAllBytes(Path.Combine(cp, "world.json"))`
- `System.IO.File.ReadAllBytes(string)`；输入表达式：`File.ReadAllBytes(Path.Combine(dir, name))`；返回值紧邻使用处：`ArgumentSyntax: File.ReadAllBytes(Path.Combine(dir, name))`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("没有可恢复的完整共同生涯检查点。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("没有可恢复的完整共同生涯检查点。");`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(cp, "run.bin")`；返回值紧邻使用处：`ArgumentSyntax: Path.Combine(cp, "run.bin")`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(cp, "world.json")`；返回值紧邻使用处：`ArgumentSyntax: Path.Combine(cp, "world.json")`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(dir, m.Directory)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Path.Combine(dir, m.Directory)`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(dir, name)`；返回值紧邻使用处：`ArgumentSyntax: Path.Combine(dir, name)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-db05a63d4feb"></a>

## `NationalSpire.Coop.CoopStorage.Durable(string, byte[]) — private static void Durable(string file, byte[] bytes)`

来源：源码第 201 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopStorage.BackupBeforeDevelopment(NationalSpire.Coop.CoopWorld, byte[]?)`](CoopStorage.cs.md#symbol-955953e36f17)；[`NationalSpire.Coop.CoopStorage.Save(NationalSpire.Coop.CoopWorld, byte[]?)`](CoopStorage.cs.md#symbol-a4c240447248)

**调用：** `System.IO.FileStream.FileStream(string, System.IO.FileMode, System.IO.FileAccess, System.IO.FileShare, int, System.IO.FileOptions)`；`System.IO.FileStream.Flush(bool)`；`System.IO.FileStream.Write(System.ReadOnlySpan<byte>)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.IO.FileStream.FileStream(string, System.IO.FileMode, System.IO.FileAccess, System.IO.FileShare, int, System.IO.FileOptions)`；输入表达式：`new FileStream(file, FileMode.Create, FileAccess.Write, FileShare.None, 65536, FileOptions.WriteThrough)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new FileStream(file, FileMode.Create, FileAccess.Write, FileShare.None, 65536, FileOptions.WriteThrough)`
- `System.IO.FileStream.Flush(bool)`；输入表达式：`stream.Flush(true)`；返回值紧邻使用处：`ExpressionStatementSyntax: stream.Flush(true);`
- `System.IO.FileStream.Write(System.ReadOnlySpan<byte>)`；输入表达式：`stream.Write(bytes)`；返回值紧邻使用处：`ExpressionStatementSyntax: stream.Write(bytes);`

**赋值（含属性/字段和局部值）：**
