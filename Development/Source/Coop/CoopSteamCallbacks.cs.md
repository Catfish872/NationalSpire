# Coop/CoopSteamCallbacks.cs

[返回文件依赖索引](../../SOURCE_MAP.md)

源码 SHA-256：`DEC64E2916C740A389C92F3DA296EFCCB3CFF8C6DD981FBACA6334385E7D72A5`。来源：[源码](../../../Coop/CoopSteamCallbacks.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Coop.CoopSteamHostCallbacks`、`NationalSpire.Coop.CoopSteamClientCallbacks`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-27d843f41b19"></a>

## `NationalSpire.Coop.CoopSteamHostCallbacks.Prefix(Steamworks.SteamNetConnectionStatusChangedCallback_t, Steamworks.HSteamListenSocket) — public static bool Prefix(SteamNetConnectionStatusChangedCallback_t data, HSteamListenSocket ____socket)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopSteamHostCallbacks.Owns(uint, uint)`](CoopSteamCallbacks.cs.md#symbol-d518ecc1e95e)

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopRuntime.Bound`；`NationalSpire.Coop.CoopSteamHostCallbacks.Owns(uint, uint)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopSteamHostCallbacks.Owns(uint, uint)`；输入表达式：`Owns(____socket.m_HSteamListenSocket, data.m_info.m_hListenSocket.m_HSteamListenSocket)`；返回值紧邻使用处：`BinaryExpressionSyntax: !CoopRuntime.Bound || Owns(____socket.m_HSteamListenSocket, data.m_info.m_hListenSocket.m_HSteamListenSocket)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d518ecc1e95e"></a>

## `NationalSpire.Coop.CoopSteamHostCallbacks.Owns(uint, uint) — public static bool Owns(uint socket, uint incoming)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopSteamHostCallbacks.Prefix(Steamworks.SteamNetConnectionStatusChangedCallback_t, Steamworks.HSteamListenSocket)`](CoopSteamCallbacks.cs.md#symbol-27d843f41b19)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6bf2dcecea2f"></a>

## `NationalSpire.Coop.CoopSteamClientCallbacks.Prefix(Steamworks.SteamNetConnectionStatusChangedCallback_t, Steamworks.HSteamNetConnection?) — public static bool Prefix(SteamNetConnectionStatusChangedCallback_t data, HSteamNetConnection? ____conn)`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopRuntime.Bound`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**
