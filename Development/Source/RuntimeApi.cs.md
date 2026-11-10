# RuntimeApi.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`93513ECFBFA8D094B760CF73E3AECA02205825AF47AE9D4DBC44E04AA6EAFB6E`。来源：[源码](../../RuntimeApi.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.SeedApi`、`NationalSpire.RuntimeApi`。

字段、事件及初始值（源码原样）：

```csharp
private readonly MethodInfo _hash;
private readonly ConstructorInfo _constructor;
```

<a id="symbol-bb6c23fe6eff"></a>

## `NationalSpire.SeedApi.Description — public string Description`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Reflection.MethodBase.GetParameters()`

**字段、属性、事件及方法组引用：** `NationalSpire.SeedApi._constructor`；`NationalSpire.SeedApi._hash`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`_constructor.GetParameters()`；返回值紧邻使用处：`ElementAccessExpressionSyntax: _constructor.GetParameters()[0]`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9d647f8b4928"></a>

## `NationalSpire.SeedApi.SeedApi(System.Type, System.Type) — public SeedApi(Type helper, Type rng)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.MissingMethodException.MissingMethodException(string?, string?)`；`System.NotSupportedException.NotSupportedException(string?)`；`System.Type.GetConstructor(System.Type[])`；`System.Type.GetMethod(string, System.Reflection.BindingFlags, System.Type[])`

**字段、属性、事件及方法组引用：** `NationalSpire.SeedApi._constructor`；`NationalSpire.SeedApi._hash`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.MissingMethodException.MissingMethodException(string?, string?)`；输入表达式：`new MissingMethodException(helper.FullName, "GetDeterministicHashCode")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new MissingMethodException(helper.FullName, "GetDeterministicHashCode")`
- `System.MissingMethodException.MissingMethodException(string?, string?)`；输入表达式：`new MissingMethodException(rng.FullName, $".ctor({width.Name}, String)")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new MissingMethodException(rng.FullName, $".ctor({width.Name}, String)")`
- `System.NotSupportedException.NotSupportedException(string?)`；输入表达式：`new NotSupportedException("未知的种子哈希类型：" + _hash.ReturnType)`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new NotSupportedException("未知的种子哈希类型：" + _hash.ReturnType)`
- `System.Type.GetConstructor(System.Type[])`；输入表达式：`rng.GetConstructor([width, typeof(string)])`；返回值紧邻使用处：`BinaryExpressionSyntax: rng.GetConstructor([width, typeof(string)])              ?? throw new MissingMethodException(rng.FullName, $".ctor({width.Name}, String)")`
- `System.Type.GetMethod(string, System.Reflection.BindingFlags, System.Type[])`；输入表达式：`helper.GetMethod("GetDeterministicHashCode", BindingFlags.Public | BindingFlags.Static, [typeof(string)])`；返回值紧邻使用处：`BinaryExpressionSyntax: helper.GetMethod("GetDeterministicHashCode", BindingFlags.Public | BindingFlags.Static, [typeof(string)])              ?? throw new MissingMethodException(helper.FullName, "GetDeterministicHashCode")`

**赋值（含属性/字段和局部值）：**

- `_constructor` = `rng.GetConstructor([width, typeof(string)])              ?? throw new MissingMethodException(rng.FullName, $".ctor({width.Name}, String)")`
- `_hash` = `helper.GetMethod("GetDeterministicHashCode", BindingFlags.Public | BindingFlags.Static, [typeof(string)])              ?? throw new MissingMethodException(helper.FullName, "GetDeterministicHashCode")`

<a id="symbol-84805f281f9e"></a>

## `NationalSpire.SeedApi.FromText(string, string) — public object FromText(string seed, string stream)`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameCompatibility.ActRng(string)`](GameCompatibility.cs.md#symbol-68363869a9cf)

**调用：** [`NationalSpire.SeedApi.FromValue(object, string)`](RuntimeApi.cs.md#symbol-346ec3f6612f)；`System.Reflection.MethodBase.Invoke(object?, object?[]?)`

**字段、属性、事件及方法组引用：** `NationalSpire.SeedApi._hash`；`NationalSpire.SeedApi.FromValue(object, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.SeedApi.FromValue(object, string)`；输入表达式：`FromValue(_hash.Invoke(null, [seed])!, stream)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => FromValue(_hash.Invoke(null, [seed])!, stream)`
- `System.Reflection.MethodBase.Invoke(object?, object?[]?)`；输入表达式：`_hash.Invoke(null, [seed])`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: _hash.Invoke(null, [seed])!`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e32ac6048df2"></a>

## `NationalSpire.SeedApi.FromRun(object, string) — public object FromRun(object runRng, string stream)`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameCompatibility.MapRng(object, int)`](GameCompatibility.cs.md#symbol-a2187753991c)

**调用：** [`NationalSpire.SeedApi.FromValue(object, string)`](RuntimeApi.cs.md#symbol-346ec3f6612f)；`object.GetType()`；`System.MissingMemberException.MissingMemberException(string?, string?)`；`System.Reflection.PropertyInfo.GetValue(object?)`；`System.Type.GetProperty(string, System.Reflection.BindingFlags)`

**字段、属性、事件及方法组引用：** `NationalSpire.SeedApi.FromValue(object, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.SeedApi.FromValue(object, string)`；输入表达式：`FromValue(property.GetValue(runRng)!, stream)`；返回值紧邻使用处：`ReturnStatementSyntax: return FromValue(property.GetValue(runRng)!, stream);`
- `object.GetType()`；输入表达式：`runRng.GetType()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: runRng.GetType().FullName`
- `object.GetType()`；输入表达式：`runRng.GetType()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: runRng.GetType().GetProperty`
- `System.MissingMemberException.MissingMemberException(string?, string?)`；输入表达式：`new MissingMemberException(runRng.GetType().FullName, "Seed")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new MissingMemberException(runRng.GetType().FullName, "Seed")`
- `System.Reflection.PropertyInfo.GetValue(object?)`；输入表达式：`property.GetValue(runRng)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: property.GetValue(runRng)!`
- `System.Type.GetProperty(string, System.Reflection.BindingFlags)`；输入表达式：`runRng.GetType().GetProperty("Seed", BindingFlags.Public | BindingFlags.Instance)`；返回值紧邻使用处：`BinaryExpressionSyntax: runRng.GetType().GetProperty("Seed", BindingFlags.Public | BindingFlags.Instance)              ?? throw new MissingMemberException(runRng.GetType().FullName, "Seed")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-346ec3f6612f"></a>

## `NationalSpire.SeedApi.FromValue(object, string) — private object FromValue(object value, string stream)`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.SeedApi.FromRun(object, string)`](RuntimeApi.cs.md#symbol-e32ac6048df2)；[`NationalSpire.SeedApi.FromText(string, string)`](RuntimeApi.cs.md#symbol-84805f281f9e)

**调用：** `System.NotSupportedException.NotSupportedException(string?)`；`System.Reflection.ConstructorInfo.Invoke(object?[]?)`；`System.Reflection.MethodBase.GetParameters()`

**字段、属性、事件及方法组引用：** `NationalSpire.SeedApi._constructor`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.NotSupportedException.NotSupportedException(string?)`；输入表达式：`new NotSupportedException("32 位随机数收到不匹配的种子类型")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new NotSupportedException("32 位随机数收到不匹配的种子类型")`
- `System.NotSupportedException.NotSupportedException(string?)`；输入表达式：`new NotSupportedException("64 位随机数收到不匹配的种子类型")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new NotSupportedException("64 位随机数收到不匹配的种子类型")`
- `System.Reflection.ConstructorInfo.Invoke(object?[]?)`；输入表达式：`_constructor.Invoke([number, stream])`；返回值紧邻使用处：`ReturnStatementSyntax: return _constructor.Invoke([number, stream]);`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`_constructor.GetParameters()`；返回值紧邻使用处：`ElementAccessExpressionSyntax: _constructor.GetParameters()[0]`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8426661c18c8"></a>

## `NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[]) — public static MethodInfo Bind(Type type, string name, bool isStatic, params Type[] supplied)`

来源：源码第 41 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCompatibility.Check(bool)`](Coop/CoopCompatibility.cs.md#symbol-c71e5d5de570)；[`NationalSpire.Coop.CoopSteamRunPlatform.BeginNew(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>, string, int, System.Threading.CancellationToken)`](Coop/CoopNativeRun.cs.md#symbol-b889ef6fb033)；[`NationalSpire.Coop.CoopSteamRunPlatform.BeginSaved(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby, System.Threading.CancellationToken)`](Coop/CoopNativeRun.cs.md#symbol-dc951f669f46)；[`NationalSpire.Coop.NativeLobbyApi.AddLocal(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, MegaCrit.Sts2.Core.Unlocks.UnlockState, int)`](Coop/NativeLobbyApi.cs.md#symbol-896eb2d8b472)；[`NationalSpire.Coop.NativeLobbyApi.Connect(object, MegaCrit.Sts2.Core.Multiplayer.NetClientGameService, System.Threading.CancellationToken)`](Coop/NativeLobbyApi.cs.md#symbol-2d450bb2d13d)；[`NationalSpire.Coop.NativeLobbyApi.Players(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby)`](Coop/NativeLobbyApi.cs.md#symbol-92249f368b32)；[`NationalSpire.Coop.NativeLobbyApi.Validate()`](Coop/NativeLobbyApi.cs.md#symbol-de1b7a4fe8ee)；[`NationalSpire.Coop.NativeLobbyApi.Version()`](Coop/NativeLobbyApi.cs.md#symbol-b0693755b371)；[`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](GameBridge.cs.md#symbol-b93ed89d4fc6)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.MissingMethodException.MissingMethodException(string?, string?)`；`System.Reflection.AmbiguousMatchException.AmbiguousMatchException(string?)`；`System.Reflection.MethodBase.GetParameters()`；`System.Type.GetMethods(System.Reflection.BindingFlags)`；`System.Type.IsAssignableFrom(System.Type?)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`p.Skip(supplied.Length).All(a => a.HasDefaultValue)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.Length >= supplied.Length                  && supplied.Select((t, i) => p[i].ParameterType.IsAssignableFrom(t)).All(b => b)                  && p.Skip(supplied.Length).All(a => a.HasDefaultValue)`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`supplied.Select((t, i) => p[i].ParameterType.IsAssignableFrom(t)).All(b => b)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.Length >= supplied.Length                  && supplied.Select((t, i) => p[i].ParameterType.IsAssignableFrom(t)).All(b => b)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`type.GetMethods(BindingFlags.Public | (isStatic ? BindingFlags.Static : BindingFlags.Instance))              .Where(m => m.Name == name && !m.ContainsGenericParameters)              .Where(m => { var p = m.GetParameters(); return p.Length >= supplied.Length                  && supplied.Select((t, i) => p[i].ParameterType.IsAssignableFrom(t)).All(b => b)                  && p.Skip(supplied.Length).All(a => a.HasDefaultValue); }).OrderBy(m => m.GetParameters().Length)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: type.GetMethods(BindingFlags.Public | (isStatic ? BindingFlags.Static : BindingFlags.Instance))              .Where(m => m.Name == name && !m.ContainsGenericParameters)              .Where(m => { var p = m.GetParameters(); return p.Length >= supplied.Length                  && supplied.Select((t, i) => p[i].ParameterType.IsAssignableFrom(t)).All(b => b)                  && p.Skip(supplied.Length).All(a => a.HasDefaultValue); }).OrderBy(m => m.GetParameters().Length).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；输入表达式：`supplied.Select((t, i) => p[i].ParameterType.IsAssignableFrom(t))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: supplied.Select((t, i) => p[i].ParameterType.IsAssignableFrom(t)).All`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`p.Skip(supplied.Length)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.Skip(supplied.Length).All`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`type.GetMethods(BindingFlags.Public | (isStatic ? BindingFlags.Static : BindingFlags.Instance))              .Where(m => m.Name == name && !m.ContainsGenericParameters)              .Where(m => { var p = m.GetParameters(); return p.Length >= supplied.Length                  && supplied.Select((t, i) => p[i].ParameterType.IsAssignableFrom(t)).All(b => b)                  && p.Skip(supplied.Length).All(a => a.HasDefaultValue); }).OrderBy(m => m.GetParameters().Length).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = type.GetMethods(BindingFlags.Public | (isStatic ? BindingFlags.Static : BindingFlags.Instance))              .Where(m => m.Name == name && !m.ContainsGenericParameters)              .Where(m => { var p = m.GetParameters(); return p.Length >= supplied.Length                  && supplied.Select((t, i) => p[i].ParameterType.IsAssignableFrom(t)).All(b => b)                  && p.Skip(supplied.Length).All(a => a.HasDefaultValue); }).OrderBy(m => m.GetParameters().Length).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`type.GetMethods(BindingFlags.Public | (isStatic ? BindingFlags.Static : BindingFlags.Instance))              .Where(m => m.Name == name && !m.ContainsGenericParameters)              .Where(m => { var p = m.GetParameters(); return p.Length >= supplied.Length                  && supplied.Select((t, i) => p[i].ParameterType.IsAssignableFrom(t)).All(b => b)                  && p.Skip(supplied.Length).All(a => a.HasDefaultValue); })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: type.GetMethods(BindingFlags.Public | (isStatic ? BindingFlags.Static : BindingFlags.Instance))              .Where(m => m.Name == name && !m.ContainsGenericParameters)              .Where(m => { var p = m.GetParameters(); return p.Length >= supplied.Length                  && supplied.Select((t, i) => p[i].ParameterType.IsAssignableFrom(t)).All(b => b)                  && p.Skip(supplied.Length).All(a => a.HasDefaultValue); }).OrderBy`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`type.GetMethods(BindingFlags.Public | (isStatic ? BindingFlags.Static : BindingFlags.Instance))              .Where(m => m.Name == name && !m.ContainsGenericParameters)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: type.GetMethods(BindingFlags.Public | (isStatic ? BindingFlags.Static : BindingFlags.Instance))              .Where(m => m.Name == name && !m.ContainsGenericParameters)              .Where`
- `System.MissingMethodException.MissingMethodException(string?, string?)`；输入表达式：`new MissingMethodException(type.FullName, name)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new MissingMethodException(type.FullName, name);`
- `System.Reflection.AmbiguousMatchException.AmbiguousMatchException(string?)`；输入表达式：`new AmbiguousMatchException(type.FullName + "." + name)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new AmbiguousMatchException(type.FullName + "." + name);`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`candidates[0].GetParameters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: candidates[0].GetParameters().Length`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`candidates[1].GetParameters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: candidates[1].GetParameters().Length`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`m.GetParameters()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = m.GetParameters()`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`m.GetParameters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: m.GetParameters().Length`
- `System.Type.GetMethods(System.Reflection.BindingFlags)`；输入表达式：`type.GetMethods(BindingFlags.Public | (isStatic ? BindingFlags.Static : BindingFlags.Instance))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: type.GetMethods(BindingFlags.Public | (isStatic ? BindingFlags.Static : BindingFlags.Instance))              .Where`
- `System.Type.IsAssignableFrom(System.Type?)`；输入表达式：`p[i].ParameterType.IsAssignableFrom(t)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: (t, i) => p[i].ParameterType.IsAssignableFrom(t)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-65f56c93bd1a"></a>

## `NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[]) — public static object? Invoke(MethodInfo method, object? instance, params object?[] supplied)`

来源：源码第 53 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopSteamRunPlatform.BeginNew(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>, string, int, System.Threading.CancellationToken)`](Coop/CoopNativeRun.cs.md#symbol-b889ef6fb033)；[`NationalSpire.Coop.CoopSteamRunPlatform.BeginSaved(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby, System.Threading.CancellationToken)`](Coop/CoopNativeRun.cs.md#symbol-dc951f669f46)；[`NationalSpire.Coop.NativeLobbyApi.AddLocal(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, MegaCrit.Sts2.Core.Unlocks.UnlockState, int)`](Coop/NativeLobbyApi.cs.md#symbol-896eb2d8b472)；[`NationalSpire.Coop.NativeLobbyApi.Connect(object, MegaCrit.Sts2.Core.Multiplayer.NetClientGameService, System.Threading.CancellationToken)`](Coop/NativeLobbyApi.cs.md#symbol-2d450bb2d13d)；[`NationalSpire.Coop.NativeLobbyApi.Players(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby)`](Coop/NativeLobbyApi.cs.md#symbol-92249f368b32)；[`NationalSpire.Coop.NativeLobbyApi.Version()`](Coop/NativeLobbyApi.cs.md#symbol-b0693755b371)；[`NationalSpire.DateGameReturn.PrepareSavedResume(NationalSpire.CareerData, string, string)`](DateGameReturn.cs.md#symbol-5f5af2e8993e)；[`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](GameBridge.cs.md#symbol-b93ed89d4fc6)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Reflection.MethodBase.GetParameters()`；`System.Reflection.MethodBase.Invoke(object?, object?[]?)`；`System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(System.Exception)`；`System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；输入表达式：`method.GetParameters().Select((p, i) => i < supplied.Length ? supplied[i] : p.DefaultValue)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: method.GetParameters().Select((p, i) => i < supplied.Length ? supplied[i] : p.DefaultValue).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`method.GetParameters().Select((p, i) => i < supplied.Length ? supplied[i] : p.DefaultValue).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = method.GetParameters().Select((p, i) => i < supplied.Length ? supplied[i] : p.DefaultValue).ToArray()`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`method.GetParameters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: method.GetParameters().Select`
- `System.Reflection.MethodBase.Invoke(object?, object?[]?)`；输入表达式：`method.Invoke(instance, arguments)`；返回值紧邻使用处：`ReturnStatementSyntax: return method.Invoke(instance, arguments);`
- `System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(System.Exception)`；输入表达式：`ExceptionDispatchInfo.Capture(e.InnerException)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ExceptionDispatchInfo.Capture(e.InnerException).Throw`
- `System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()`；输入表达式：`ExceptionDispatchInfo.Capture(e.InnerException).Throw()`；返回值紧邻使用处：`ExpressionStatementSyntax: ExceptionDispatchInfo.Capture(e.InnerException).Throw();`

**赋值（含属性/字段和局部值）：**
