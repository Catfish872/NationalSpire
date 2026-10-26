# AiRouting.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`070B747D8B0BE5386026FAE360C8E62DD9E87FCFF7A6104279C9B9D004E57C3D`。来源：[源码](../../AiRouting.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.AiConnectionProfile`、`NationalSpire.AiRouting`、`NationalSpire.AiConnection`。

字段、事件及初始值（源码原样）：

```csharp
public const string Default = "default";
public static readonly (string Id, string Name)[] Tasks =
    [
        ("weekly", "周刊与介绍"), ("news", "发帖"), ("discussion", "回帖"),
        ("private", "私聊"), ("group", "群聊"), ("private-summary", "私聊总结"),
        ("group-summary", "群聊总结"), ("arbitration", "聊天仲裁"), ("event", "随机事件")
    ];
```

<a id="symbol-6cd4cd07a433"></a>

## `NationalSpire.AiConnectionProfile.Name — public string Name`

来源：源码第 5 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-4ba4ef004c6c"></a>

## `NationalSpire.AiConnectionProfile.Endpoint — public string Endpoint`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d983c9c68bf7"></a>

## `NationalSpire.AiConnectionProfile.Model — public string Model`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7a203ffde56e"></a>

## `NationalSpire.AiRouting.Ensure(NationalSpire.AiOptions) — public static void Ensure(AiOptions options)`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiRouting.Assign(NationalSpire.AiOptions, string, string, System.Action)`](AiRouting.cs.md#symbol-dcdbadb40401)；[`NationalSpire.AiRouting.NextName(NationalSpire.AiOptions)`](AiRouting.cs.md#symbol-761de1a86dc4)；[`NationalSpire.AiRouting.ProfileId(NationalSpire.AiOptions, string)`](AiRouting.cs.md#symbol-ccbfd0b083bc)；[`NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string, System.Action<System.Action>?)`](AiSettingsPanel.cs.md#symbol-8fb9cbc85381)；[`NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`](AiSettingsStore.cs.md#symbol-b37e55b3af97)；[`NationalSpire.CareerScreen.OpenNpcGeneration(NationalSpire.AiOptions, System.Action<NationalSpire.NpcGenerationSetup>, bool, System.Func<NationalSpire.NpcGenerationSetup, System.Threading.Tasks.Task>?, int, bool)`](NpcGenerationScreen.cs.md#symbol-fa734ac20da4)；[`NationalSpire.CareerScreen.ShowChatModelPicker(Godot.Button, string)`](ChatUtilitiesScreen.cs.md#symbol-cc67f52fc948)

**调用：** `NationalSpire.AiConnectionProfile.AiConnectionProfile()`

**字段、属性、事件及方法组引用：** `NationalSpire.AiConnectionProfile.Endpoint`；`NationalSpire.AiConnectionProfile.Model`；`NationalSpire.AiConnectionProfile.Name`；`NationalSpire.AiOptions.ConnectionProfiles`；`NationalSpire.AiOptions.Endpoint`；`NationalSpire.AiOptions.Model`；`NationalSpire.AiRouting.Default`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiConnectionProfile.AiConnectionProfile()`；输入表达式：`new() { Name = Default, Endpoint = options.Endpoint, Model = options.Model }`；返回值紧邻使用处：`AssignmentExpressionSyntax: options.ConnectionProfiles[Default] = new() { Name = Default, Endpoint = options.Endpoint, Model = options.Model }`

**赋值（含属性/字段和局部值）：**

- `Endpoint` = `options.Endpoint`
- `Model` = `options.Model`
- `Name` = `Default`
- `options.ConnectionProfiles[Default]` = `new() { Name = Default, Endpoint = options.Endpoint, Model = options.Model }`

<a id="symbol-a9d92e7d36e8"></a>

## `NationalSpire.AiRouting.Category(string) — public static string Category(string task)`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiRouting.Assign(NationalSpire.AiOptions, string, string, System.Action)`](AiRouting.cs.md#symbol-dcdbadb40401)；[`NationalSpire.AiRouting.ProfileId(NationalSpire.AiOptions, string)`](AiRouting.cs.md#symbol-ccbfd0b083bc)；[`NationalSpire.AiTaskRoutePicker.Configure(NationalSpire.AiOptions, string, System.Action, System.Action<string, bool>)`](AiTaskRoutePicker.cs.md#symbol-7a35c2ddf3d1)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ccbfd0b083bc"></a>

## `NationalSpire.AiRouting.ProfileId(NationalSpire.AiOptions, string) — public static string ProfileId(AiOptions options, string task)`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiRouting.Assign(NationalSpire.AiOptions, string, string, System.Action)`](AiRouting.cs.md#symbol-dcdbadb40401)；[`NationalSpire.AiRouting.Profile(NationalSpire.AiOptions, string)`](AiRouting.cs.md#symbol-d1386c5a387e)；[`NationalSpire.AiService.Connection(NationalSpire.AiOptions, string)`](AiService.cs.md#symbol-8c02bb75b41a)；[`NationalSpire.AiTaskRoutePicker.Refresh()`](AiTaskRoutePicker.cs.md#symbol-8a208d29fd78)；[`NationalSpire.CareerScreen.ShowChatModelPicker(Godot.Button, string)`](ChatUtilitiesScreen.cs.md#symbol-cc67f52fc948)

**调用：** [`NationalSpire.AiRouting.Category(string)`](AiRouting.cs.md#symbol-a9d92e7d36e8)；[`NationalSpire.AiRouting.Ensure(NationalSpire.AiOptions)`](AiRouting.cs.md#symbol-7a203ffde56e)；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.TaskProfiles`；`NationalSpire.AiRouting.Category(string)`；`NationalSpire.AiRouting.Default`；`NationalSpire.AiRouting.Ensure(NationalSpire.AiOptions)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiRouting.Category(string)`；输入表达式：`Category(task)`；返回值紧邻使用处：`ArgumentSyntax: Category(task)`
- `NationalSpire.AiRouting.Ensure(NationalSpire.AiOptions)`；输入表达式：`Ensure(options)`；返回值紧邻使用处：`ExpressionStatementSyntax: Ensure(options);`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`options.TaskProfiles.GetValueOrDefault(Category(task), Default)`；返回值紧邻使用处：`ReturnStatementSyntax: return options.TaskProfiles.GetValueOrDefault(Category(task), Default);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d1386c5a387e"></a>

## `NationalSpire.AiRouting.Profile(NationalSpire.AiOptions, string) — public static AiConnectionProfile Profile(AiOptions options, string task)`

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.AiRouting.ProfileId(NationalSpire.AiOptions, string)`](AiRouting.cs.md#symbol-ccbfd0b083bc)

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.ConnectionProfiles`；`NationalSpire.AiRouting.ProfileId(NationalSpire.AiOptions, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiRouting.ProfileId(NationalSpire.AiOptions, string)`；输入表达式：`ProfileId(options, task)`；返回值紧邻使用处：`ArgumentSyntax: ProfileId(options, task)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-dcdbadb40401"></a>

## `NationalSpire.AiRouting.Assign(NationalSpire.AiOptions, string, string, System.Action) — public static void Assign(AiOptions options, string task, string profile, Action save)`

来源：源码第 43 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiTaskRoutePicker.Configure(NationalSpire.AiOptions, string, System.Action, System.Action<string, bool>)`](AiTaskRoutePicker.cs.md#symbol-7a35c2ddf3d1)；[`NationalSpire.CareerScreen.ShowChatModelPicker(Godot.Button, string)`](ChatUtilitiesScreen.cs.md#symbol-cc67f52fc948)

**调用：** [`NationalSpire.AiRouting.Category(string)`](AiRouting.cs.md#symbol-a9d92e7d36e8)；[`NationalSpire.AiRouting.Ensure(NationalSpire.AiOptions)`](AiRouting.cs.md#symbol-7a203ffde56e)；[`NationalSpire.AiRouting.ProfileId(NationalSpire.AiOptions, string)`](AiRouting.cs.md#symbol-ccbfd0b083bc)；`System.Action.Invoke()`；`System.ArgumentException.ArgumentException(string?)`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.ConnectionProfiles`；`NationalSpire.AiOptions.TaskProfiles`；`NationalSpire.AiRouting.Category(string)`；`NationalSpire.AiRouting.Ensure(NationalSpire.AiOptions)`；`NationalSpire.AiRouting.ProfileId(NationalSpire.AiOptions, string)`；`NationalSpire.AiRouting.Tasks`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiRouting.Category(string)`；输入表达式：`Category(task)`；返回值紧邻使用处：`AssignmentExpressionSyntax: task = Category(task)`
- `NationalSpire.AiRouting.Ensure(NationalSpire.AiOptions)`；输入表达式：`Ensure(options)`；返回值紧邻使用处：`ExpressionStatementSyntax: Ensure(options);`
- `NationalSpire.AiRouting.ProfileId(NationalSpire.AiOptions, string)`；输入表达式：`ProfileId(options, task)`；返回值紧邻使用处：`BinaryExpressionSyntax: ProfileId(options, task) == profile`
- `System.Action.Invoke()`；输入表达式：`save()`；返回值紧邻使用处：`ExpressionStatementSyntax: save();`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("请选择有效的任务和连接方案。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("请选择有效的任务和连接方案。");`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`options.ConnectionProfiles.ContainsKey(profile)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !options.ConnectionProfiles.ContainsKey(profile)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`options.TaskProfiles.Remove(task)`；返回值紧邻使用处：`ExpressionStatementSyntax: options.TaskProfiles.Remove(task);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`options.TaskProfiles.TryGetValue(task, out string? previous)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = options.TaskProfiles.TryGetValue(task, out string? previous)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`Tasks.Any(t => t.Id == task)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Tasks.Any(t => t.Id == task)`

**赋值（含属性/字段和局部值）：**

- `options.TaskProfiles[task]` = `previous!`
- `options.TaskProfiles[task]` = `profile`
- `task` = `Category(task)`

<a id="symbol-761de1a86dc4"></a>

## `NationalSpire.AiRouting.NextName(NationalSpire.AiOptions) — public static string NextName(AiOptions options)`

来源：源码第 59 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Load(string, bool)`](AiSettingsPanel.cs.md#symbol-96678e748257)

**调用：** [`NationalSpire.AiRouting.Ensure(NationalSpire.AiOptions)`](AiRouting.cs.md#symbol-7a203ffde56e)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiConnectionProfile.Name`；`NationalSpire.AiOptions.ConnectionProfiles`；`NationalSpire.AiRouting.Default`；`NationalSpire.AiRouting.Ensure(NationalSpire.AiOptions)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiRouting.Ensure(NationalSpire.AiOptions)`；输入表达式：`Ensure(options)`；返回值紧邻使用处：`ExpressionStatementSyntax: Ensure(options);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`options.ConnectionProfiles.Values.Any(p => p.Name == name)`；返回值紧邻使用处：`WhileStatementSyntax: while (options.ConnectionProfiles.Values.Any(p => p.Name == name)) name = Default + ++number;`

**赋值（含属性/字段和局部值）：**

- `name` = `Default + ++number`
