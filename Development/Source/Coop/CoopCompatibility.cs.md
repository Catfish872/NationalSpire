# Coop/CoopCompatibility.cs

[返回文件依赖索引](../../SOURCE_MAP.md)

源码 SHA-256：`B0C6F359BB4342D6B9E3220A1642444BF8E2981A656612436897BE4B2794E99E`。来源：[源码](../../../Coop/CoopCompatibility.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Coop.CoopCompatibility`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-c71e5d5de570"></a>

## `NationalSpire.Coop.CoopCompatibility.Check(bool) — public static string? Check(bool requirePatches = true)`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRuntime.Connect(bool, string, string, int, string, string, string)`](CoopRuntime.cs.md#symbol-5c58a004498a)

**调用：** [`NationalSpire.Coop.NativeLobbyApi.Validate()`](NativeLobbyApi.cs.md#symbol-de1b7a4fe8ee)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](../Diagnostics.cs.md#symbol-cb39203375a5)；[`NationalSpire.GameCompatibility.ActRng(string)`](../GameCompatibility.cs.md#symbol-68363869a9cf)；[`NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`](../RuntimeApi.cs.md#symbol-8426661c18c8)；`HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；`HarmonyLib.Harmony.GetPatchInfo(System.Reflection.MethodBase)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`

**字段、属性、事件及方法组引用：** `(System.Type Type, string Name).Name`；`(System.Type Type, string Name).Type`；`NationalSpire.Coop.NativeLobbyApi.Validate()`；`NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.GameCompatibility.ActRng(string)`；`NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(item.Type, item.Name)`；返回值紧邻使用处：`BinaryExpressionSyntax: AccessTools.Method(item.Type, item.Name) == null`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(patch == typeof(CoopPathPatch) ? typeof(RunSaveManager) : typeof(SaveManager), patch == typeof(CoopPathPatch) ? "GetRunSavePath" : "SaveRunHistory")`；返回值紧邻使用处：`ConditionalExpressionSyntax: patch == typeof(CoopSavePatch) ? save : AccessTools.Method(patch == typeof(CoopPathPatch) ? typeof(RunSaveManager) : typeof(SaveManager), patch == typeof(CoopPathPatch) ? "GetRunSavePath" : "SaveRunHistory")`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(RunManager), "ReturnToMainMenuWithError")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AccessTools.Method(typeof(RunManager), "ReturnToMainMenuWithError")`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(RunSaveManager), "SaveRun", [typeof(SerializableRun), typeof(bool)])`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AccessTools.Method(typeof(RunSaveManager), "SaveRun", [typeof(SerializableRun), typeof(bool)])`
- `HarmonyLib.Harmony.GetPatchInfo(System.Reflection.MethodBase)`；输入表达式：`Harmony.GetPatchInfo(disconnect)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Harmony.GetPatchInfo(disconnect)?.Prefixes.Any(p => p.PatchMethod.DeclaringType == typeof(CoopDisconnectMenuPatch))`
- `HarmonyLib.Harmony.GetPatchInfo(System.Reflection.MethodBase)`；输入表达式：`Harmony.GetPatchInfo(method)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Harmony.GetPatchInfo(method)`
- `NationalSpire.Coop.NativeLobbyApi.Validate()`；输入表达式：`NativeLobbyApi.Validate()`；返回值紧邻使用处：`ExpressionStatementSyntax: NativeLobbyApi.Validate();`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("coop.compatibility", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("coop.compatibility", e);`
- `NationalSpire.GameCompatibility.ActRng(string)`；输入表达式：`GameCompatibility.ActRng("COOP-COMPATIBILITY")`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = GameCompatibility.ActRng("COOP-COMPATIBILITY")`
- `NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`；输入表达式：`RuntimeApi.Bind(typeof(NGame), "LoadRun", false, typeof(RunState), typeof(SerializableRoom))`；返回值紧邻使用处：`ExpressionStatementSyntax: RuntimeApi.Bind(typeof(NGame), "LoadRun", false, typeof(RunState), typeof(SerializableRoom));`
- `NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`；输入表达式：`RuntimeApi.Bind(typeof(NGame), "StartNewMultiplayerRun", false, typeof(StartRunLobby), typeof(bool), typeof(List<ActModel>), typeof(List<ModifierModel>), typeof(string), typeof(int))`；返回值紧邻使用处：`ExpressionStatementSyntax: RuntimeApi.Bind(typeof(NGame), "StartNewMultiplayerRun", false, typeof(StartRunLobby), typeof(bool), typeof(List<ActModel>), typeof(List<ModifierModel>), typeof(string), typeof(int));`
- `NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`；输入表达式：`RuntimeApi.Bind(typeof(RunManager), "SetUpSavedMultiplayer", false, typeof(RunState), typeof(LoadRunLobby))`；返回值紧邻使用处：`ExpressionStatementSyntax: RuntimeApi.Bind(typeof(RunManager), "SetUpSavedMultiplayer", false, typeof(RunState), typeof(LoadRunLobby));`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Prefixes.Any(p => p.PatchMethod.DeclaringType == typeof(CoopDisconnectMenuPatch))`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Harmony.GetPatchInfo(disconnect)?.Prefixes.Any(p => p.PatchMethod.DeclaringType == typeof(CoopDisconnectMenuPatch))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`info.Prefixes.Concat(info.Postfixes).Any(p => p.PatchMethod.DeclaringType == patch)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !info.Prefixes.Concat(info.Postfixes).Any(p => p.PatchMethod.DeclaringType == patch)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`info.Prefixes.Concat(info.Postfixes)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: info.Prefixes.Concat(info.Postfixes).Any`

**赋值（含属性/字段和局部值）：**

- `_` = `GameCompatibility.ActRng("COOP-COMPATIBILITY")`
