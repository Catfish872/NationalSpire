# MarketScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`9B8AEA3322CF02EDC00EA7B7F4805433E4A44DFEF56CD1DF3398CF3FBF382D24`。来源：[源码](../../MarketScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-333b046d27f4"></a>

## `NationalSpire.CareerScreen.MarketScreen(NationalSpire.CareerData) — private void MarketScreen(CareerData d)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Life(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-0cdff88b6131)

**调用：** [`NationalSpire.CareerScreen.MarketSubmit(NationalSpire.CareerData, NationalSpire.MarketOrder)`](MarketScreen.cs.md#symbol-fbc36ef790b1)；[`NationalSpire.MarketTerminal.Bind(NationalSpire.CareerData, System.Action<NationalSpire.MarketOrder>, System.Action<string>)`](MarketTerminal.cs.md#symbol-09b1a1ea6de7)；`Godot.CanvasItem.Show()`；`Godot.Node.Reparent(Godot.Node, bool)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerListCache.Market`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._listCache`；`NationalSpire.CareerScreen.MarketSubmit(NationalSpire.CareerData, NationalSpire.MarketOrder)`；`NationalSpire.CareerScreen.OpenPerson(string)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.MarketTerminal.Bind(NationalSpire.CareerData, System.Action<NationalSpire.MarketOrder>, System.Action<string>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Show()`；输入表达式：`terminal.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: terminal.Show();`
- `Godot.Node.Reparent(Godot.Node, bool)`；输入表达式：`terminal.Reparent(_content)`；返回值紧邻使用处：`ExpressionStatementSyntax: terminal.Reparent(_content);`
- `NationalSpire.CareerScreen.MarketSubmit(NationalSpire.CareerData, NationalSpire.MarketOrder)`；输入表达式：`MarketSubmit(ViewData, order)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: order => MarketSubmit(ViewData, order)`
- `NationalSpire.MarketTerminal.Bind(NationalSpire.CareerData, System.Action<NationalSpire.MarketOrder>, System.Action<string>)`；输入表达式：`terminal.Bind(d, order => MarketSubmit(ViewData, order), OpenPerson)`；返回值紧邻使用处：`ExpressionStatementSyntax: terminal.Bind(d, order => MarketSubmit(ViewData, order), OpenPerson);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-fbc36ef790b1"></a>

## `NationalSpire.CareerScreen.MarketSubmit(NationalSpire.CareerData, NationalSpire.MarketOrder) — private void MarketSubmit(CareerData d, MarketOrder order)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.MarketScreen(NationalSpire.CareerData)`](MarketScreen.cs.md#symbol-333b046d27f4)

**调用：** [`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.EconomicActions.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder)`](EconomicActions.cs.md#symbol-f0516c3ecf95)；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.EconomicActions.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("market", text: JsonSerializer.Serialize(order))`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand("market", text: JsonSerializer.Serialize(order))) return;`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(error ?? "交易已完成并保存。", error != null)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(error ?? "交易已完成并保存。", error != null);`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.EconomicActions.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder)`；输入表达式：`EconomicActions.Trade(d, order)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = EconomicActions.Trade(d, order)`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(order)`；返回值紧邻使用处：`ArgumentSyntax: text: JsonSerializer.Serialize(order)`

**赋值（含属性/字段和局部值）：**
