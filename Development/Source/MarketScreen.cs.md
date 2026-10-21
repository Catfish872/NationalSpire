# MarketScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`1258FDCB0CFA57042D12A8456925040B5751314CAAC06E27E660ACDF351F52B0`。来源：[源码](../../MarketScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-333b046d27f4"></a>

## `NationalSpire.CareerScreen.MarketScreen(NationalSpire.CareerData) — private void MarketScreen(CareerData d)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Life(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-0cdff88b6131)

**调用：** [`NationalSpire.CareerScreen.MarketSubmit(NationalSpire.CareerData, NationalSpire.MarketOrder)`](MarketScreen.cs.md#symbol-fbc36ef790b1)；[`NationalSpire.CareerScreen.TeamButton(string, System.Action, int)`](CareerSession.cs.md#symbol-a13f3923812a)；[`NationalSpire.LifestyleArt.Icon(string)`](LifestyleArt.cs.md#symbol-91f9b2ac06fa)；[`NationalSpire.MarketTerminal.Bind(NationalSpire.CareerData, System.Action<NationalSpire.MarketOrder>, System.Action<string>)`](MarketTerminal.cs.md#symbol-09b1a1ea6de7)；`Godot.CanvasItem.Show()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.Reparent(Godot.Node, bool)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerListCache.Market`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._listCache`；`NationalSpire.CareerScreen.AdvanceCareerDay()`；`NationalSpire.CareerScreen.MarketSubmit(NationalSpire.CareerData, NationalSpire.MarketOrder)`；`NationalSpire.CareerScreen.OpenPerson(string)`；`NationalSpire.CareerScreen.TeamButton(string, System.Action, int)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.LifestyleArt.Icon(string)`；`NationalSpire.MarketTerminal.Bind(NationalSpire.CareerData, System.Action<NationalSpire.MarketOrder>, System.Action<string>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Show()`；输入表达式：`terminal.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: terminal.Show();`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(advance)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(advance);`
- `Godot.Node.Reparent(Godot.Node, bool)`；输入表达式：`terminal.Reparent(_content)`；返回值紧邻使用处：`ExpressionStatementSyntax: terminal.Reparent(_content);`
- `NationalSpire.CareerScreen.MarketSubmit(NationalSpire.CareerData, NationalSpire.MarketOrder)`；输入表达式：`MarketSubmit(ViewData, order)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: order => MarketSubmit(ViewData, order)`
- `NationalSpire.CareerScreen.TeamButton(string, System.Action, int)`；输入表达式：`TeamButton("推进一天 →", AdvanceCareerDay, 180)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = TeamButton("推进一天 →", AdvanceCareerDay, 180)`
- `NationalSpire.LifestyleArt.Icon(string)`；输入表达式：`LifestyleArt.Icon("活动与计划")`；返回值紧邻使用处：`AssignmentExpressionSyntax: advance.Icon = LifestyleArt.Icon("活动与计划")`
- `NationalSpire.MarketTerminal.Bind(NationalSpire.CareerData, System.Action<NationalSpire.MarketOrder>, System.Action<string>)`；输入表达式：`terminal.Bind(d, order => MarketSubmit(ViewData, order), OpenPerson)`；返回值紧邻使用处：`ExpressionStatementSyntax: terminal.Bind(d, order => MarketSubmit(ViewData, order), OpenPerson);`

**赋值（含属性/字段和局部值）：**

- `advance.Icon` = `LifestyleArt.Icon("活动与计划")`

<a id="symbol-871f6318461f"></a>

## `NationalSpire.CareerScreen.AdvanceCareerDay() — private void AdvanceCareerDay()`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerEngine.AdvanceOneDay(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-5b81bcd72cc1)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerEngine.AdvanceOneDay(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.ViewData`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.AdvanceOneDay(NationalSpire.CareerData)`；输入表达式：`CareerEngine.AdvanceOneDay(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.AdvanceOneDay(data)`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("propose-advance", number: data.Day + 1)`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand("propose-advance", number: data.Day + 1)) return;`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("比赛日需先完成或放弃比赛。", true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("比赛日需先完成或放弃比赛。", true);`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-fbc36ef790b1"></a>

## `NationalSpire.CareerScreen.MarketSubmit(NationalSpire.CareerData, NationalSpire.MarketOrder) — private async void MarketSubmit(CareerData d, MarketOrder order)`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.MarketScreen(NationalSpire.CareerData)`](MarketScreen.cs.md#symbol-333b046d27f4)

**调用：** [`NationalSpire.CareerMarket.OpenFee(NationalSpire.MarketAsset, decimal, int)`](CareerMarket.cs.md#symbol-8f53c28594f3)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.EconomicActions.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder)`](EconomicActions.cs.md#symbol-f0516c3ecf95)；[`NationalSpire.MarketClearing.Preview(NationalSpire.CareerData, NationalSpire.MarketOrder, bool)`](MarketClearing.cs.md#symbol-e90e0ab892c9)；[`NationalSpire.MarketClearing.Summary(NationalSpire.MarketClearing.Result)`](MarketClearing.cs.md#symbol-8655b084ac17)；[`NationalSpire.MarketTerminal.SetOrderMargin(decimal)`](MarketTerminal.cs.md#symbol-5c2e4be798a5)；[`Summary(string, decimal, decimal, Godot.Color)`](MarketScreen.cs.md#symbol-79a28ef9c10b)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.IsInsideTree()`；`NationalSpire.MarketInspection.MarketInspection(string, decimal, int, int[], bool)`；`System.Func<T, TResult>.Invoke(T)`（委托实际目标见流程文档）；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.InspectMarket`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Trading`；`NationalSpire.CareerListCache.Market`；`NationalSpire.CareerMarket.OpenFee(NationalSpire.MarketAsset, decimal, int)`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._lifeSection`；`NationalSpire.CareerScreen._listCache`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.EconomicActions.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder)`；`NationalSpire.MarketAccount.Cash`；`NationalSpire.MarketCatalog.ById`；`NationalSpire.MarketClearing.Preview(NationalSpire.CareerData, NationalSpire.MarketOrder, bool)`；`NationalSpire.MarketClearing.Summary(NationalSpire.MarketClearing.Result)`；`NationalSpire.MarketInspectionResult.Buy`；`NationalSpire.MarketInspectionResult.Revision`；`NationalSpire.MarketInspectionResult.Sell`；`NationalSpire.MarketOrder.Action`；`NationalSpire.MarketOrder.Amount`；`NationalSpire.MarketOrder.Asset`；`NationalSpire.MarketOrder.Direction`；`NationalSpire.MarketOrder.Leverage`；`NationalSpire.MarketOrder.QuoteRevision`；`NationalSpire.MarketOrderPreview.Accepted`；`NationalSpire.MarketOrderPreview.Fee`；`NationalSpire.MarketOrderPreview.Margin`；`NationalSpire.MarketOrderPreview.Reason`；`NationalSpire.MarketTerminal.SetOrderMargin(decimal)`；`Summary(string, decimal, decimal, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`columns.AddThemeConstantOverride("separation", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: columns.AddThemeConstantOverride("separation", 18);`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(this)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(this) && IsInsideTree()`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(this)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(this)`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(columns)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(columns);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(available ? "应用后返回下单区，再次点击做多或做空即可成交。" : "可以降低杠杆，或调整已有仓位后重新下单。", 17, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(available ? "应用后返回下单区，再次点击做多或做空即可成交。" : "可以降低杠杆，或调整已有仓位后重新下单。", 17, _ink));`
- `Godot.Node.IsInsideTree()`；输入表达式：`IsInsideTree()`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(this) && IsInsideTree()`
- `Godot.Node.IsInsideTree()`；输入表达式：`IsInsideTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInsideTree()`
- `NationalSpire.CareerMarket.OpenFee(NationalSpire.MarketAsset, decimal, int)`；输入表达式：`CareerMarket.OpenFee(MarketCatalog.ById[order.Asset], order.Amount, order.Leverage)`；返回值紧邻使用处：`ArgumentSyntax: CareerMarket.OpenFee(MarketCatalog.ById[order.Asset], order.Amount, order.Leverage)`
- `NationalSpire.CareerMarket.OpenFee(NationalSpire.MarketAsset, decimal, int)`；输入表达式：`CareerMarket.OpenFee(MarketCatalog.ById[order.Asset], order.Amount, order.Leverage)`；返回值紧邻使用处：`BinaryExpressionSyntax: order.Amount + CareerMarket.OpenFee(MarketCatalog.ById[order.Asset], order.Amount, order.Leverage)`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("market", text: JsonSerializer.Serialize(order))`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand("market", text: JsonSerializer.Serialize(order))) return;`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("报价已更新，请查看最新价格后确认。", true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("报价已更新，请查看最新价格后确认。", true);`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice("市场预览暂时失败，请重试。" + exception.Message, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice("市场预览暂时失败，请重试。" + exception.Message, true);`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(error ?? "交易已完成并保存。", error != null)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(error ?? "交易已完成并保存。", error != null);`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("调整下单数量", preview.Reason + "。", () =>                  {                      if (available) _listCache!.Market.SetOrderMargin(preview.Margin);                      return true;                  }, available ? "应用建议数量" : "自行调整", contents: box =>                  {                      var columns = new HBoxContainer(); columns.AddThemeConstantOverride("separation", 18); box.AddChild(columns);                      void Summary(string title, decimal margin, decimal fee, Color accent)                      {                          var card = Card(); card.SizeFlagsHorizontal = SizeFlags.ExpandFill; columns.AddChild(card);                          var content = Inner(card); content.AddChild(Text(title, 18, accent));                          content.AddChild(Text(CareerMoney.Compact(margin * order.Leverage), 26, accent));                          content.AddChild(Text("交易总额", 15, _ink));                          content.AddChild(Text("保证金  " + CareerMoney.Compact(margin) + "\n手续费  " + CareerMoney.Compact(fee), 17, _ink));                      }                      Summary("本次下单", order.Amount, CareerMarket.OpenFee(MarketCatalog.ById[order.Asset], order.Amount, order.Leverage), _gold);                      Summary("当前可成交", preview.Margin, preview.Fee, CareerVisuals.Teal);                      box.AddChild(Text(available ? "应用后返回下单区，再次点击做多或做空即可成交。" : "可以降低杠杆，或调整已有仓位后重新下单。", 17, _ink));                  }, showCancel: available, cancelText: "自行调整")`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("调整下单数量", preview.Reason + "。", () =>                  {                      if (available) _listCache!.Market.SetOrderMargin(preview.Margin);                      return true;                  }, available ? "应用建议数量" : "自行调整", contents: box =>                  {                      var columns = new HBoxContainer(); columns.AddThemeConstantOverride("separation", 18); box.AddChild(columns);                      void Summary(string title, decimal margin, decimal fee, Color accent)                      {                          var card = Card(); card.SizeFlagsHorizontal = SizeFlags.ExpandFill; columns.AddChild(card);                          var content = Inner(card); content.AddChild(Text(title, 18, accent));                          content.AddChild(Text(CareerMoney.Compact(margin * order.Leverage), 26, accent));                          content.AddChild(Text("交易总额", 15, _ink));                          content.AddChild(Text("保证金  " + CareerMoney.Compact(margin) + "\n手续费  " + CareerMoney.Compact(fee), 17, _ink));                      }                      Summary("本次下单", order.Amount, CareerMarket.OpenFee(MarketCatalog.ById[order.Asset], order.Amount, order.Leverage), _gold);                      Summary("当前可成交", preview.Margin, preview.Fee, CareerVisuals.Teal);                      box.AddChild(Text(available ? "应用后返回下单区，再次点击做多或做空即可成交。" : "可以降低杠杆，或调整已有仓位后重新下单。", 17, _ink));                  }, showCancel: available, cancelText: "自行调整");`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(available ? "应用后返回下单区，再次点击做多或做空即可成交。" : "可以降低杠杆，或调整已有仓位后重新下单。", 17, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(available ? "应用后返回下单区，再次点击做多或做空即可成交。" : "可以降低杠杆，或调整已有仓位后重新下单。", 17, _ink)`
- `NationalSpire.EconomicActions.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder)`；输入表达式：`EconomicActions.Trade(d, order)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = EconomicActions.Trade(d, order)`
- `NationalSpire.MarketClearing.Preview(NationalSpire.CareerData, NationalSpire.MarketOrder, bool)`；输入表达式：`MarketClearing.Preview(d, order)`；返回值紧邻使用处：`ArgumentSyntax: MarketClearing.Preview(d, order)`
- `NationalSpire.MarketClearing.Summary(NationalSpire.MarketClearing.Result)`；输入表达式：`MarketClearing.Summary(MarketClearing.Preview(d, order))`；返回值紧邻使用处：`AssignmentExpressionSyntax: preview = MarketClearing.Summary(MarketClearing.Preview(d, order))`
- `NationalSpire.MarketInspection.MarketInspection(string, decimal, int, int[], bool)`；输入表达式：`new(order.Asset, order.Amount, order.Leverage, [], true)`；返回值紧邻使用处：`ArgumentSyntax: new(order.Asset, order.Amount, order.Leverage, [], true)`
- `NationalSpire.MarketTerminal.SetOrderMargin(decimal)`；输入表达式：`_listCache!.Market.SetOrderMargin(preview.Margin)`；返回值紧邻使用处：`ExpressionStatementSyntax: _listCache!.Market.SetOrderMargin(preview.Margin);`
- `Summary(string, decimal, decimal, Godot.Color)`；输入表达式：`Summary("本次下单", order.Amount, CareerMarket.OpenFee(MarketCatalog.ById[order.Asset], order.Amount, order.Leverage), _gold)`；返回值紧邻使用处：`ExpressionStatementSyntax: Summary("本次下单", order.Amount, CareerMarket.OpenFee(MarketCatalog.ById[order.Asset], order.Amount, order.Leverage), _gold);`
- `Summary(string, decimal, decimal, Godot.Color)`；输入表达式：`Summary("当前可成交", preview.Margin, preview.Fee, CareerVisuals.Teal)`；返回值紧邻使用处：`ExpressionStatementSyntax: Summary("当前可成交", preview.Margin, preview.Fee, CareerVisuals.Teal);`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`d.InspectMarket(new(order.Asset, order.Amount, order.Leverage, [], true))`；返回值紧邻使用处：`AwaitExpressionSyntax: await d.InspectMarket(new(order.Asset, order.Amount, order.Leverage, [], true))`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(order)`；返回值紧邻使用处：`ArgumentSyntax: text: JsonSerializer.Serialize(order)`

**赋值（含属性/字段和局部值）：**

- `preview` = `MarketClearing.Summary(MarketClearing.Preview(d, order))`
- `preview` = `order.Direction > 0 ? result.Buy : result.Sell`
- `result` = `await d.InspectMarket(new(order.Asset, order.Amount, order.Leverage, [], true))`

<a id="symbol-79a28ef9c10b"></a>

## `Summary(string, decimal, decimal, Godot.Color) — void Summary(string title, decimal margin, decimal fee, Color accent)`

来源：源码第 48 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.MarketSubmit(NationalSpire.CareerData, NationalSpire.MarketOrder)`](MarketScreen.cs.md#symbol-fbc36ef790b1)

**调用：** [`NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`](LifeData.cs.md#symbol-9439f9696cab)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.MarketOrder.Leverage`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`columns.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: columns.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(Text("保证金  " + CareerMoney.Compact(margin) + "\n手续费  " + CareerMoney.Compact(fee), 17, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(Text("保证金  " + CareerMoney.Compact(margin) + "\n手续费  " + CareerMoney.Compact(fee), 17, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(Text("交易总额", 15, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(Text("交易总额", 15, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(Text(CareerMoney.Compact(margin * order.Leverage), 26, accent))`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(Text(CareerMoney.Compact(margin * order.Leverage), 26, accent));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(Text(title, 18, accent))`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(Text(title, 18, accent));`
- `NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`；输入表达式：`CareerMoney.Compact(fee)`；返回值紧邻使用处：`BinaryExpressionSyntax: "保证金  " + CareerMoney.Compact(margin) + "\n手续费  " + CareerMoney.Compact(fee)`
- `NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`；输入表达式：`CareerMoney.Compact(margin * order.Leverage)`；返回值紧邻使用处：`ArgumentSyntax: CareerMoney.Compact(margin * order.Leverage)`
- `NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`；输入表达式：`CareerMoney.Compact(margin)`；返回值紧邻使用处：`BinaryExpressionSyntax: "保证金  " + CareerMoney.Compact(margin)`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(card)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(card)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("保证金  " + CareerMoney.Compact(margin) + "\n手续费  " + CareerMoney.Compact(fee), 17, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text("保证金  " + CareerMoney.Compact(margin) + "\n手续费  " + CareerMoney.Compact(fee), 17, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("交易总额", 15, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text("交易总额", 15, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(CareerMoney.Compact(margin * order.Leverage), 26, accent)`；返回值紧邻使用处：`ArgumentSyntax: Text(CareerMoney.Compact(margin * order.Leverage), 26, accent)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(title, 18, accent)`；返回值紧邻使用处：`ArgumentSyntax: Text(title, 18, accent)`

**赋值（含属性/字段和局部值）：**

- `card.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
