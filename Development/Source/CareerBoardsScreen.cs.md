# CareerBoardsScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`20FECB13958FCF876653D52B223D3C3FF38A98A66359C087F3AFD339B361310A`。来源：[源码](../../CareerBoardsScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
private int _rankSeason;
private const int LedgerRowHeight = 58;
```

<a id="symbol-5d55d72dcdea"></a>

## `NationalSpire.CareerScreen.AssetsPage(NationalSpire.CareerData) — private void AssetsPage(CareerData d)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Life(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-0cdff88b6131)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)

**调用：** [`Metric(string, string, Godot.Color)`](CareerBoardsScreen.cs.md#symbol-e7dc817a7a1f)；[`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`](LifeData.cs.md#symbol-de5af63fa4e7)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerScreen.ActionRow(Godot.Container, string, string, System.Action, Godot.Control, int, int, int, string, string, string)`](DashboardControls.cs.md#symbol-5fcff8206cb6)；[`NationalSpire.CareerScreen.AddLedgerTable(Godot.VBoxContainer, NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<NationalSpire.FinanceEntry>, int)`](CareerBoardsScreen.cs.md#symbol-efdf49030123)；[`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`](DashboardControls.cs.md#symbol-1c4fb2c61c90)；[`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`](DashboardControls.cs.md#symbol-23c9e2f4b76f)；[`NationalSpire.CareerScreen.OpenLifePage(string)`](CareerDashboard.cs.md#symbol-0d80fbb19407)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.CareerVisuals.CashFont()`](CareerVisuals.cs.md#symbol-0a825f4f143c)；[`Section(string, int)`](CareerBoardsScreen.cs.md#symbol-23bd28020c8d)；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawTextureRect(Godot.Texture2D, Godot.Rect2, bool, Godot.Color?, bool)`；`Godot.Color.Color(string)`；`Godot.ColorRect.ColorRect()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontOverride(Godot.StringName, Godot.Font)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.Control()`；`Godot.Gradient.Gradient()`；`Godot.GradientTexture2D.GradientTexture2D()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.Rect2.Rect2(float, float, float, float)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, decimal>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `Metric(string, string, Godot.Color)`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Ledger`；`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.ActionRow(Godot.Container, string, string, System.Action, Godot.Control, int, int, int, string, string, string)`；`NationalSpire.CareerScreen.AddLedgerTable(Godot.VBoxContainer, NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<NationalSpire.FinanceEntry>, int)`；`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；`NationalSpire.CareerScreen.OpenLifePage(string)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.CashFont()`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.FinanceEntry.Amount`；`Section(string, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`summary.DrawLine(new(2,4),new(2,summary.Size.Y-4),_gold,3)`；返回值紧邻使用处：`ExpressionStatementSyntax: summary.DrawLine(new(2,4),new(2,summary.Size.Y-4),_gold,3);`
- `Godot.CanvasItem.DrawTextureRect(Godot.Texture2D, Godot.Rect2, bool, Godot.Color?, bool)`；输入表达式：`summary.DrawTextureRect(gradient,new Rect2(4,2,summary.Size.X-7,summary.Size.Y-4),false)`；返回值紧邻使用处：`ExpressionStatementSyntax: summary.DrawTextureRect(gradient,new Rect2(4,2,summary.Size.X-7,summary.Size.Y-4),false);`
- `Godot.Color.Color(string)`；输入表达式：`new Color("11222e")`；返回值紧邻使用处：`ExpressionElementSyntax: new Color("11222e")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("203438")`；返回值紧邻使用处：`ExpressionElementSyntax: new Color("203438")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("45606a")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Color=new Color("45606a")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("efaaa3")`；返回值紧邻使用处：`ArgumentSyntax: new Color("efaaa3")`
- `Godot.ColorRect.ColorRect()`；输入表达式：`new ColorRect { Color=new Color("45606a"), CustomMinimumSize=new(1,58), SizeFlagsVertical=SizeFlags.ShrinkCenter }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ColorRect { Color=new Color("45606a"), CustomMinimumSize=new(1,58), SizeFlagsVertical=SizeFlags.ShrinkCenter }`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`balance.AddThemeConstantOverride("separation",4)`；返回值紧邻使用处：`ExpressionStatementSyntax: balance.AddThemeConstantOverride("separation",4);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`caption.AddThemeConstantOverride("separation",10)`；返回值紧邻使用处：`ExpressionStatementSyntax: caption.AddThemeConstantOverride("separation",10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`columns.AddThemeConstantOverride("separation",25)`；返回值紧邻使用处：`ExpressionStatementSyntax: columns.AddThemeConstantOverride("separation",25);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`line.AddThemeConstantOverride("separation",11)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddThemeConstantOverride("separation",11);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`metrics.AddThemeConstantOverride("separation",42)`；返回值紧邻使用处：`ExpressionStatementSyntax: metrics.AddThemeConstantOverride("separation",42);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`page.AddThemeConstantOverride("separation",26)`；返回值紧邻使用处：`ExpressionStatementSyntax: page.AddThemeConstantOverride("separation",26);`
- `Godot.Control.AddThemeFontOverride(Godot.StringName, Godot.Font)`；输入表达式：`cash.AddThemeFontOverride("font",CareerVisuals.CashFont())`；返回值紧邻使用处：`ExpressionStatementSyntax: cash.AddThemeFontOverride("font",CareerVisuals.CashFont());`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`summary.AddThemeStyleboxOverride("panel",surface)`；返回值紧邻使用处：`ExpressionStatementSyntax: summary.AddThemeStyleboxOverride("panel",surface);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`tile.AddThemeStyleboxOverride("panel",CareerVisuals.Box("203e46","203e46",6,10))`；返回值紧邻使用处：`ExpressionStatementSyntax: tile.AddThemeStyleboxOverride("panel",CareerVisuals.Box("203e46","203e46",6,10));`
- `Godot.Control.Control()`；输入表达式：`new Control {CustomMinimumSize=new(0,10),MouseFilter=MouseFilterEnum.Ignore}`；返回值紧邻使用处：`ArgumentSyntax: new Control {CustomMinimumSize=new(0,10),MouseFilter=MouseFilterEnum.Ignore}`
- `Godot.Gradient.Gradient()`；输入表达式：`new Gradient { Colors=[new Color("203438"),new Color("11222e")] }`；返回值紧邻使用处：`AssignmentExpressionSyntax: Gradient=new Gradient { Colors=[new Color("203438"),new Color("11222e")] }`
- `Godot.GradientTexture2D.GradientTexture2D()`；输入表达式：`new GradientTexture2D { Gradient=new Gradient { Colors=[new Color("203438"),new Color("11222e")] },              FillFrom=new(0,.35f), FillTo=new(.75f,.65f) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GradientTexture2D { Gradient=new Gradient { Colors=[new Color("203438"),new Color("11222e")] },              FillFrom=new(0,.35f), FillTo=new(.75f,.65f) }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { Alignment=BoxContainer.AlignmentMode.Center }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { Alignment=BoxContainer.AlignmentMode.Center }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { SizeFlagsVertical=SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { SizeFlagsVertical=SizeFlags.ExpandFill }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(page)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(page);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(new Control {CustomMinimumSize=new(0,10),MouseFilter=MouseFilterEnum.Ignore})`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(new Control {CustomMinimumSize=new(0,10),MouseFilter=MouseFilterEnum.Ignore});`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`balance.AddChild(caption)`；返回值紧邻使用处：`ExpressionStatementSyntax: balance.AddChild(caption);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`balance.AddChild(cash)`；返回值紧邻使用处：`ExpressionStatementSyntax: balance.AddChild(cash);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`caption.AddChild(DashboardLabel("当前可用现金",21,_gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: caption.AddChild(DashboardLabel("当前可用现金",21,_gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`caption.AddChild(Glyph("wallet",22,_gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: caption.AddChild(Glyph("wallet",22,_gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(DashboardLabel(name,20,_ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(DashboardLabel(name,20,_ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(Glyph("chevron-right",16,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(Glyph("chevron-right",16,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(tile)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(tile);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`metrics.AddChild(balance)`；返回值紧邻使用处：`ExpressionStatementSyntax: metrics.AddChild(balance);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`metrics.AddChild(divider)`；返回值紧邻使用处：`ExpressionStatementSyntax: metrics.AddChild(divider);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`page.AddChild(columns)`；返回值紧邻使用处：`ExpressionStatementSyntax: page.AddChild(columns);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`page.AddChild(summary)`；返回值紧邻使用处：`ExpressionStatementSyntax: page.AddChild(summary);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`summary.AddChild(metrics)`；返回值紧邻使用处：`ExpressionStatementSyntax: summary.AddChild(metrics);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`tile.AddChild(Glyph(icon,21,CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: tile.AddChild(Glyph(icon,21,CareerVisuals.Teal));`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { CustomMinimumSize=new(42,42),SizeFlagsVertical=SizeFlags.ShrinkCenter,MouseFilter=MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new PanelContainer { CustomMinimumSize=new(42,42),SizeFlagsVertical=SizeFlags.ShrinkCenter,MouseFilter=MouseFilterEnum.Ignore }`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { Name="CashSummary", CustomMinimumSize=new(0,180) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { Name="CashSummary", CustomMinimumSize=new(0,180) }`
- `Godot.Rect2.Rect2(float, float, float, float)`；输入表达式：`new Rect2(4,2,summary.Size.X-7,summary.Size.Y-4)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(4,2,summary.Size.X-7,summary.Size.Y-4)`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { Name="AssetsPage", CustomMinimumSize=new(0,840) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { Name="AssetsPage", CustomMinimumSize=new(0,840) }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal=SizeFlags.ExpandFill, Alignment=BoxContainer.AlignmentMode.Center }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal=SizeFlags.ExpandFill, Alignment=BoxContainer.AlignmentMode.Center }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(.75f,.65f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: FillTo=new(.75f,.65f)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,.35f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: FillFrom=new(0,.35f)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,10)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(0,10)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,180)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(0,180)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,840)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(0,840)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(1,58)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(1,58)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(2,4)`；返回值紧邻使用处：`ArgumentSyntax: new(2,4)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(2,summary.Size.Y-4)`；返回值紧邻使用处：`ArgumentSyntax: new(2,summary.Size.Y-4)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(42,42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(42,42)`
- `Metric(string, string, Godot.Color)`；输入表达式：`Metric("已记录收入","+"+CareerMoney.Format(ledger.Where(item=>item.Amount>0).Sum(item=>item.Amount)),CareerVisuals.Teal)`；返回值紧邻使用处：`ExpressionStatementSyntax: Metric("已记录收入","+"+CareerMoney.Format(ledger.Where(item=>item.Amount>0).Sum(item=>item.Amount)),CareerVisuals.Teal);`
- `Metric(string, string, Godot.Color)`；输入表达式：`Metric("已记录支出","−"+CareerMoney.Format(-ledger.Where(item=>item.Amount<0).Sum(item=>item.Amount)),new Color("efaaa3"))`；返回值紧邻使用处：`ExpressionStatementSyntax: Metric("已记录支出","−"+CareerMoney.Format(-ledger.Where(item=>item.Amount<0).Sum(item=>item.Amount)),new Color("efaaa3"));`
- `NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；输入表达式：`CareerMoney.Balance(d)`；返回值紧邻使用处：`ArgumentSyntax: CareerMoney.Balance(d)`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(-ledger.Where(item=>item.Amount<0).Sum(item=>item.Amount))`；返回值紧邻使用处：`BinaryExpressionSyntax: "−"+CareerMoney.Format(-ledger.Where(item=>item.Amount<0).Sum(item=>item.Amount))`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(CareerMoney.Balance(d))`；返回值紧邻使用处：`ArgumentSyntax: CareerMoney.Format(CareerMoney.Balance(d))`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(ledger.Where(item=>item.Amount>0).Sum(item=>item.Amount))`；返回值紧邻使用处：`BinaryExpressionSyntax: "+"+CareerMoney.Format(ledger.Where(item=>item.Amount>0).Sum(item=>item.Amount))`
- `NationalSpire.CareerScreen.ActionRow(Godot.Container, string, string, System.Action, Godot.Control, int, int, int, string, string, string)`；输入表达式：`ActionRow(actions,"AssetDestination_"+tab,name,()=>OpenLifePage(tab),line,78,14,12,"142733","354c58","203d49")`；返回值紧邻使用处：`ExpressionStatementSyntax: ActionRow(actions,"AssetDestination_"+tab,name,()=>OpenLifePage(tab),line,78,14,12,"142733","354c58","203d49");`
- `NationalSpire.CareerScreen.AddLedgerTable(Godot.VBoxContainer, NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<NationalSpire.FinanceEntry>, int)`；输入表达式：`AddLedgerTable(Section("账户流水",0), d, ledger)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddLedgerTable(Section("账户流水",0), d, ledger);`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel("当前可用现金",21,_gold)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel("当前可用现金",21,_gold)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(CareerMoney.Format(CareerMoney.Balance(d)),66,_ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DashboardLabel(CareerMoney.Format(CareerMoney.Balance(d)),66,_ink)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(name,20,_ink)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(name,20,_ink)`
- `NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；输入表达式：`Glyph("chevron-right",16,_muted)`；返回值紧邻使用处：`ArgumentSyntax: Glyph("chevron-right",16,_muted)`
- `NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；输入表达式：`Glyph("wallet",22,_gold)`；返回值紧邻使用处：`ArgumentSyntax: Glyph("wallet",22,_gold)`
- `NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；输入表达式：`Glyph(icon,21,CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Glyph(icon,21,CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.OpenLifePage(string)`；输入表达式：`OpenLifePage(tab)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>OpenLifePage(tab)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("203438","485858",8,0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerVisuals.Box("203438","485858",8,0)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("203e46","203e46",6,10)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("203e46","203e46",6,10)`
- `NationalSpire.CareerVisuals.CashFont()`；输入表达式：`CareerVisuals.CashFont()`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.CashFont()`
- `Section(string, int)`；输入表达式：`Section("消费投资",245)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Section("消费投资",245)`
- `Section(string, int)`；输入表达式：`Section("账户流水",0)`；返回值紧邻使用处：`ArgumentSyntax: Section("账户流水",0)`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, decimal>)`；输入表达式：`ledger.Where(item=>item.Amount<0).Sum(item=>item.Amount)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: -ledger.Where(item=>item.Amount<0).Sum(item=>item.Amount)`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, decimal>)`；输入表达式：`ledger.Where(item=>item.Amount>0).Sum(item=>item.Amount)`；返回值紧邻使用处：`ArgumentSyntax: ledger.Where(item=>item.Amount>0).Sum(item=>item.Amount)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`ledger.Where(item=>item.Amount<0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ledger.Where(item=>item.Amount<0).Sum`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`ledger.Where(item=>item.Amount>0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ledger.Where(item=>item.Amount>0).Sum`

**赋值（含属性/字段和局部值）：**

- `Alignment` = `BoxContainer.AlignmentMode.Center`
- `cash.ClipText` = `true`
- `cash.Name` = `"AvailableCash"`
- `Color` = `new Color("45606a")`
- `Colors` = `[new Color("203438"),new Color("11222e")]`
- `CustomMinimumSize` = `new(0,10)`
- `CustomMinimumSize` = `new(0,180)`
- `CustomMinimumSize` = `new(0,840)`
- `CustomMinimumSize` = `new(1,58)`
- `CustomMinimumSize` = `new(42,42)`
- `FillFrom` = `new(0,.35f)`
- `FillTo` = `new(.75f,.65f)`
- `Gradient` = `new Gradient { Colors=[new Color("203438"),new Color("11222e")] }`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Name` = `"AssetsPage"`
- `Name` = `"CashSummary"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `summary.Draw` += `() => {              summary.DrawTextureRect(gradient,new Rect2(4,2,summary.Size.X-7,summary.Size.Y-4),false);              summary.DrawLine(new(2,4),new(2,summary.Size.Y-4),_gold,3);          }`
- `surface.ContentMarginBottom` = `22`
- `surface.ContentMarginLeft` = `42`
- `surface.ContentMarginRight` = `39`
- `surface.ContentMarginTop` = `surface.ContentMarginBottom=22`

<a id="symbol-e7dc817a7a1f"></a>

## `Metric(string, string, Godot.Color) — void Metric(string title,string value,Color color)`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AssetsPage(NationalSpire.CareerData)`](CareerBoardsScreen.cs.md#symbol-5d55d72dcdea)

**调用：** [`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`](DashboardControls.cs.md#symbol-1c4fb2c61c90)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`column.AddThemeConstantOverride("separation",6)`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddThemeConstantOverride("separation",6);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`column.AddChild(DashboardLabel(title,17,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddChild(DashboardLabel(title,17,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`column.AddChild(DashboardLabel(value,22,color))`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddChild(DashboardLabel(value,22,color));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`metrics.AddChild(column)`；返回值紧邻使用处：`ExpressionStatementSyntax: metrics.AddChild(column);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { Alignment=BoxContainer.AlignmentMode.Center }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { Alignment=BoxContainer.AlignmentMode.Center }`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(title,17,_muted)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(title,17,_muted)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(value,22,color)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(value,22,color)`

**赋值（含属性/字段和局部值）：**

- `Alignment` = `BoxContainer.AlignmentMode.Center`

<a id="symbol-23bd28020c8d"></a>

## `Section(string, int) — VBoxContainer Section(string name,int width)`

来源：源码第 48 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AssetsPage(NationalSpire.CareerData)`](CareerBoardsScreen.cs.md#symbol-5d55d72dcdea)

**调用：** [`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`](DashboardControls.cs.md#symbol-1c4fb2c61c90)；`Godot.Color.Color(string)`；`Godot.ColorRect.ColorRect()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("46606b")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Color=new Color("46606b")`
- `Godot.ColorRect.ColorRect()`；输入表达式：`new ColorRect { Color=new Color("46606b"), CustomMinimumSize=new(0,1) }`；返回值紧邻使用处：`ArgumentSyntax: new ColorRect { Color=new Color("46606b"), CustomMinimumSize=new(0,1) }`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`section.AddThemeConstantOverride("separation",0)`；返回值紧邻使用处：`ExpressionStatementSyntax: section.AddThemeConstantOverride("separation",0);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`columns.AddChild(section)`；返回值紧邻使用处：`ExpressionStatementSyntax: columns.AddChild(section);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`section.AddChild(heading)`；返回值紧邻使用处：`ExpressionStatementSyntax: section.AddChild(heading);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`section.AddChild(new ColorRect { Color=new Color("46606b"), CustomMinimumSize=new(0,1) })`；返回值紧邻使用处：`ExpressionStatementSyntax: section.AddChild(new ColorRect { Color=new Color("46606b"), CustomMinimumSize=new(0,1) });`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { CustomMinimumSize=new(width,0) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { CustomMinimumSize=new(width,0) }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,1)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(0,1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,66)`；返回值紧邻使用处：`AssignmentExpressionSyntax: heading.CustomMinimumSize=new(0,66)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(width,0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(width,0)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(name,23,_ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =DashboardLabel(name,23,_ink)`

**赋值（含属性/字段和局部值）：**

- `Color` = `new Color("46606b")`
- `CustomMinimumSize` = `new(0,1)`
- `CustomMinimumSize` = `new(width,0)`
- `heading.CustomMinimumSize` = `new(0,66)`
- `section.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-efdf49030123"></a>

## `NationalSpire.CareerScreen.AddLedgerTable(Godot.VBoxContainer, NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<NationalSpire.FinanceEntry>, int) — private void AddLedgerTable(VBoxContainer parent, CareerData data, IReadOnlyList<FinanceEntry> ledger, int visibleRows = 0)`

来源：源码第 74 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AssetsPage(NationalSpire.CareerData)`](CareerBoardsScreen.cs.md#symbol-5d55d72dcdea)；[`NationalSpire.CareerScreen.OwnedClubPanel(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-d7bcae181c6a)

**调用：** [`NationalSpire.BroadcastScroll.ScrollWheel(int, double)`](BroadcastVisuals.cs.md#symbol-482eddf2d675)；[`NationalSpire.BroadcastScroll.StopMotion()`](BroadcastVisuals.cs.md#symbol-b858c7de4b8d)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`](DashboardControls.cs.md#symbol-1c4fb2c61c90)；[`NationalSpire.CareerScreen.Inset(int, int)`](DashboardControls.cs.md#symbol-ebb2fedbb4fc)；[`NationalSpire.CareerScreen.LedgerRow(string[], bool)`](CareerBoardsScreen.cs.md#symbol-ebfdc210bad4)；[`NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-8a08be365f83)；`Godot.Control.AcceptEvent()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.ScrollContainer.GetVScrollBar()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.BroadcastScroll.BroadcastScroll()`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；`System.DateOnly.ToString(string?)`；`System.Math.Clamp(int, int, int)`

**字段、属性、事件及方法组引用：** `AlignHeader()`；`NationalSpire.BroadcastScroll.ScrollWheel(int, double)`；`NationalSpire.BroadcastScroll.StopMotion()`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerScreen._scroll`；`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；`NationalSpire.CareerScreen.Inset(int, int)`；`NationalSpire.CareerScreen.LedgerRow(string[], bool)`；`NationalSpire.CareerScreen.LedgerRowHeight`；`NationalSpire.CareerVisuals.Muted`；`NationalSpire.FinanceEntry.Amount`；`NationalSpire.FinanceEntry.Balance`；`NationalSpire.FinanceEntry.Day`；`NationalSpire.FinanceEntry.Title`；`NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AcceptEvent()`；输入表达式：`table.AcceptEvent()`；返回值紧邻使用处：`ExpressionStatementSyntax: table.AcceptEvent();`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`rows.AddThemeConstantOverride("separation", 0)`；返回值紧邻使用处：`ExpressionStatementSyntax: rows.AddThemeConstantOverride("separation", 0);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`table.AddThemeConstantOverride("separation", 0)`；返回值紧邻使用处：`ExpressionStatementSyntax: table.AddThemeConstantOverride("separation", 0);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`header.AddChild(LedgerRow(["日期", "款项内容", "收入", "支出", "交易后余额"], true))`；返回值紧邻使用处：`ExpressionStatementSyntax: header.AddChild(LedgerRow(["日期", "款项内容", "收入", "支出", "交易后余额"], true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(table)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(table);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`rows.AddChild(DashboardLabel("暂无收支记录", 17, CareerVisuals.Muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: rows.AddChild(DashboardLabel("暂无收支记录", 17, CareerVisuals.Muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`rows.AddChild(LedgerRow([GameCalendar.Date(data, item.Day).ToString("yyyy.MM.dd"), item.Title,                  item.Amount > 0 ? "+" + CareerMoney.Format(item.Amount) : "—",                  item.Amount < 0 ? "−" + CareerMoney.Format(-item.Amount) : "—", CareerMoney.Format(item.Balance)], false))`；返回值紧邻使用处：`ExpressionStatementSyntax: rows.AddChild(LedgerRow([GameCalendar.Date(data, item.Day).ToString("yyyy.MM.dd"), item.Title,                  item.Amount > 0 ? "+" + CareerMoney.Format(item.Amount) : "—",                  item.Amount < 0 ? "−" + CareerMoney.Format(-item.Amount) : "—", CareerMoney.Format(item.Balance)], false));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scroll.AddChild(rows)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.AddChild(rows);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`table.AddChild(header)`；返回值紧邻使用处：`ExpressionStatementSyntax: table.AddChild(header);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`table.AddChild(scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: table.AddChild(scroll);`
- `Godot.ScrollContainer.GetVScrollBar()`；输入表达式：`scroll.GetVScrollBar()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = scroll.GetVScrollBar()`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { Name = "LedgerTable", SizeFlagsVertical = SizeFlags.ExpandFill,              MouseFilter = MouseFilterEnum.Stop, MouseForcePassScrollEvents = false }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { Name = "LedgerTable", SizeFlagsVertical = SizeFlags.ExpandFill,              MouseFilter = MouseFilterEnum.Stop, MouseForcePassScrollEvents = false }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, LedgerRowHeight * Math.Clamp(ledger.Count, 1, visibleRows))`；返回值紧邻使用处：`AssignmentExpressionSyntax: scroll.CustomMinimumSize = new(0, LedgerRowHeight * Math.Clamp(ledger.Count, 1, visibleRows))`
- `NationalSpire.BroadcastScroll.BroadcastScroll()`；输入表达式：`new BroadcastScroll { Name = "LedgerScroll", SizeFlagsVertical = SizeFlags.ExpandFill,              HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled, MouseFilter = MouseFilterEnum.Stop, MouseForcePassScrollEvents = false }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastScroll { Name = "LedgerScroll", SizeFlagsVertical = SizeFlags.ExpandFill,              HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled, MouseFilter = MouseFilterEnum.Stop, MouseForcePassScrollEvents = false }`
- `NationalSpire.BroadcastScroll.ScrollWheel(int, double)`；输入表达式：`scroll.ScrollWheel(wheel.ButtonIndex == MouseButton.WheelDown ? 1 : -1, wheel.Factor)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.ScrollWheel(wheel.ButtonIndex == MouseButton.WheelDown ? 1 : -1, wheel.Factor);`
- `NationalSpire.BroadcastScroll.StopMotion()`；输入表达式：`scroll.StopMotion()`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.StopMotion();`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(-item.Amount)`；返回值紧邻使用处：`BinaryExpressionSyntax: "−" + CareerMoney.Format(-item.Amount)`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(item.Amount)`；返回值紧邻使用处：`BinaryExpressionSyntax: "+" + CareerMoney.Format(item.Amount)`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(item.Balance)`；返回值紧邻使用处：`ExpressionElementSyntax: CareerMoney.Format(item.Balance)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel("暂无收支记录", 17, CareerVisuals.Muted)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel("暂无收支记录", 17, CareerVisuals.Muted)`
- `NationalSpire.CareerScreen.Inset(int, int)`；输入表达式：`Inset(0, 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inset(0, 0)`
- `NationalSpire.CareerScreen.LedgerRow(string[], bool)`；输入表达式：`LedgerRow(["日期", "款项内容", "收入", "支出", "交易后余额"], true)`；返回值紧邻使用处：`ArgumentSyntax: LedgerRow(["日期", "款项内容", "收入", "支出", "交易后余额"], true)`
- `NationalSpire.CareerScreen.LedgerRow(string[], bool)`；输入表达式：`LedgerRow([GameCalendar.Date(data, item.Day).ToString("yyyy.MM.dd"), item.Title,                  item.Amount > 0 ? "+" + CareerMoney.Format(item.Amount) : "—",                  item.Amount < 0 ? "−" + CareerMoney.Format(-item.Amount) : "—", CareerMoney.Format(item.Balance)], false)`；返回值紧邻使用处：`ArgumentSyntax: LedgerRow([GameCalendar.Date(data, item.Day).ToString("yyyy.MM.dd"), item.Title,                  item.Amount > 0 ? "+" + CareerMoney.Format(item.Amount) : "—",                  item.Amount < 0 ? "−" + CareerMoney.Format(-item.Amount) : "—", CareerMoney.Format(item.Balance)], false)`
- `NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Date(data, item.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GameCalendar.Date(data, item.Day).ToString`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`ledger.Reverse().OrderByDescending(item => item.Day)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var item in ledger.Reverse().OrderByDescending(item => item.Day))              rows.AddChild(LedgerRow([GameCalendar.Date(data, item.Day).ToString("yyyy.MM.dd"), item.Title,                  item.Amount > 0 ? "+" + CareerMoney.Format(item.Amount) : "—",                  item.Amount < 0 ? "−" + CareerMoney.Format(-item.Amount) : "—", CareerMoney.Format(item.Balance)], false));`
- `System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；输入表达式：`ledger.Reverse()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ledger.Reverse().OrderByDescending`
- `System.DateOnly.ToString(string?)`；输入表达式：`GameCalendar.Date(data, item.Day).ToString("yyyy.MM.dd")`；返回值紧邻使用处：`ExpressionElementSyntax: GameCalendar.Date(data, item.Day).ToString("yyyy.MM.dd")`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(ledger.Count, 1, visibleRows)`；返回值紧邻使用处：`BinaryExpressionSyntax: LedgerRowHeight * Math.Clamp(ledger.Count, 1, visibleRows)`

**赋值（含属性/字段和局部值）：**

- `bar.Value` += `pan.Delta.Y * bar.Page / 8`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `MouseFilter` = `MouseFilterEnum.Stop`
- `MouseForcePassScrollEvents` = `false`
- `Name` = `"LedgerScroll"`
- `Name` = `"LedgerTable"`
- `rows.Resized` += `AlignHeader`
- `scroll.CustomMinimumSize` = `new(0, LedgerRowHeight * Math.Clamp(ledger.Count, 1, visibleRows))`
- `scroll.Resized` += `AlignHeader`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ExpandFill`
- `table.GuiInput` += `input =>          {              if (input is InputEventMouseButton wheel && wheel.ButtonIndex is MouseButton.WheelUp or MouseButton.WheelDown)              {                  if (wheel.Pressed) scroll.ScrollWheel(wheel.ButtonIndex == MouseButton.WheelDown ? 1 : -1, wheel.Factor);                  table.AcceptEvent();              }              else if (input is InputEventPanGesture pan)              {                  scroll.StopMotion();                  var bar = scroll.GetVScrollBar();                  bar.Value += pan.Delta.Y * bar.Page / 8;                  table.AcceptEvent();              }          }`
- `table.MouseEntered` += `page.StopMotion`

<a id="symbol-97bb28cca4a2"></a>

## `AlignHeader() — void AlignHeader()`

来源：源码第 107 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Mathf.RoundToInt(float)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`header.AddThemeConstantOverride("margin_right", Math.Max(0, Mathf.RoundToInt(scroll.Size.X - rows.Size.X)))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => header.AddThemeConstantOverride("margin_right", Math.Max(0, Mathf.RoundToInt(scroll.Size.X - rows.Size.X)))`
- `Godot.Mathf.RoundToInt(float)`；输入表达式：`Mathf.RoundToInt(scroll.Size.X - rows.Size.X)`；返回值紧邻使用处：`ArgumentSyntax: Mathf.RoundToInt(scroll.Size.X - rows.Size.X)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, Mathf.RoundToInt(scroll.Size.X - rows.Size.X))`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, Mathf.RoundToInt(scroll.Size.X - rows.Size.X))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ebfdc210bad4"></a>

## `NationalSpire.CareerScreen.LedgerRow(string[], bool) — private static PanelContainer LedgerRow(string[] values,bool heading)`

来源：源码第 117 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddLedgerTable(Godot.VBoxContainer, NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<NationalSpire.FinanceEntry>, int)`](CareerBoardsScreen.cs.md#symbol-efdf49030123)

**调用：** [`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`](DashboardControls.cs.md#symbol-1c4fb2c61c90)；[`NationalSpire.CareerScreen.Inset(int, int)`](DashboardControls.cs.md#symbol-ebb2fedbb4fc)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Color.Color(string)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.StyleBoxFlat.SetBorderWidthAll(int)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；`NationalSpire.CareerScreen.Inset(int, int)`；`NationalSpire.CareerScreen.LedgerRowHeight`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Ink`；`NationalSpire.CareerVisuals.Muted`；`NationalSpire.CareerVisuals.Teal`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("10212d")`；返回值紧邻使用处：`AssignmentExpressionSyntax: style.BgColor=new Color("10212d")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("1a303b")`；返回值紧邻使用处：`AssignmentExpressionSyntax: style.BgColor=new Color("1a303b")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("758899")`；返回值紧邻使用处：`ConditionalExpressionSyntax: values[i]=="—" ? new Color("758899") :                  i==2 ? CareerVisuals.Teal : i==3 ? new Color("efaaa3") : CareerVisuals.Ink`
- `Godot.Color.Color(string)`；输入表达式：`new Color("efaaa3")`；返回值紧邻使用处：`ConditionalExpressionSyntax: i==3 ? new Color("efaaa3") : CareerVisuals.Ink`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`line.AddThemeConstantOverride("separation",0)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddThemeConstantOverride("separation",0);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel",style)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel",style);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`cell.AddChild(label)`；返回值紧邻使用处：`ExpressionStatementSyntax: cell.AddChild(label);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(cell)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(cell);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(line)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(line);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { Name=heading ? "LedgerHeader" : "LedgerRow",CustomMinimumSize=new(0,heading ? 56 : LedgerRowHeight) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new PanelContainer { Name=heading ? "LedgerHeader" : "LedgerRow",CustomMinimumSize=new(0,heading ? 56 : LedgerRowHeight) }`
- `Godot.StyleBoxFlat.SetBorderWidthAll(int)`；输入表达式：`style.SetBorderWidthAll(0)`；返回值紧邻使用处：`ExpressionStatementSyntax: style.SetBorderWidthAll(0);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,heading ? 56 : LedgerRowHeight)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(0,heading ? 56 : LedgerRowHeight)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(values[i],heading ? 16 : 18,color,wrap:i==1)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =DashboardLabel(values[i],heading ? 16 : 18,color,wrap:i==1)`
- `NationalSpire.CareerScreen.Inset(int, int)`；输入表达式：`Inset(18,9)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Inset(18,9)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box(heading ? "1b303e" : "10212d","29414e",0,0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CareerVisuals.Box(heading ? "1b303e" : "10212d","29414e",0,0)`

**赋值（含属性/字段和局部值）：**

- `cell.SizeFlagsStretchRatio` = `shares[i]`
- `CustomMinimumSize` = `new(0,heading ? 56 : LedgerRowHeight)`
- `label.ClipText` = `i!=1`
- `label.HorizontalAlignment` = `i<2 ? HorizontalAlignment.Left : HorizontalAlignment.Right`
- `Name` = `heading ? "LedgerHeader" : "LedgerRow"`
- `panel.MouseEntered` += `() => { style.BgColor=new Color("1a303b"); }`
- `panel.MouseExited` += `() => { style.BgColor=new Color("10212d"); }`
- `style.BgColor` = `new Color("10212d")`
- `style.BgColor` = `new Color("1a303b")`
- `style.BorderWidthBottom` = `1`

<a id="symbol-c8e7b9304826"></a>

## `NationalSpire.CareerScreen.RankingPage(NationalSpire.CareerData) — private void RankingPage(CareerData d)`

来源：源码第 140 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)

**调用：** [`NationalSpire.CareerScreen.BoardNotice(string, string, string)`](CareerBoardsScreen.cs.md#symbol-837344ae2c72)；[`NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`](CareerDashboard.cs.md#symbol-22831701f7f1)；[`NationalSpire.CareerScreen.CeremonyCriteria(NationalSpire.CareerData, NationalSpire.CeremonyRecord, bool)`](CeremonyScreen.cs.md#symbol-ba3629b0b234)；[`NationalSpire.CareerScreen.CeremonyRanking(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CeremonyRank>)`](CeremonyScreen.cs.md#symbol-73500bb64a58)；[`NationalSpire.CareerScreen.CircuitRanking(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-b3ab649f5b65)；[`NationalSpire.CareerScreen.FanChart(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-509582b2b893)；[`NationalSpire.CareerScreen.LeagueTable(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool)`](CareerBoardsScreen.cs.md#symbol-8456ab4b34a8)；[`NationalSpire.CareerScreen.NationRanking(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-b665478390f0)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.TabStrip(Godot.Container, int, bool, bool)`](CareerDashboard.cs.md#symbol-5eacabf68317)；[`NationalSpire.CareerScreen.UnderlineTab(string, System.Action, bool, int, int, bool, bool)`](CareerDashboard.cs.md#symbol-fd46a77c3667)；[`NationalSpire.CareerScreen.WorldHonors(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-3c1f80d447a9)；`Godot.HFlowContainer.HFlowContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.GetItemId(int)`；`Godot.OptionButton.OptionButton()`；`Godot.OptionButton.Select(int)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.IndexOf(T)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Ceremonies`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerScreen._board`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._rankRegion`；`NationalSpire.CareerScreen._rankSeason`；`NationalSpire.CareerScreen.BoardNotice(string, string, string)`；`NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`；`NationalSpire.CareerScreen.CeremonyCriteria(NationalSpire.CareerData, NationalSpire.CeremonyRecord, bool)`；`NationalSpire.CareerScreen.CeremonyRanking(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CeremonyRank>)`；`NationalSpire.CareerScreen.CircuitRanking(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.FanChart(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.LeagueTable(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool)`；`NationalSpire.CareerScreen.NationRanking(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.TabStrip(Godot.Container, int, bool, bool)`；`NationalSpire.CareerScreen.UnderlineTab(string, System.Action, bool, int, int, bool, bool)`；`NationalSpire.CareerScreen.WorldHonors(NationalSpire.CareerData)`；`NationalSpire.CeremonyRecord.FullSeason`；`NationalSpire.CeremonyRecord.FullYear`；`NationalSpire.CeremonyRecord.Season`；`NationalSpire.CeremonyRecord.SeasonTop`；`NationalSpire.CeremonyRecord.YearTop`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.WorldCompetition.Country`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Season`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.HFlowContainer.HFlowContainer()`；输入表达式：`new HFlowContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HFlowContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(regions)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(regions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(select)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(select);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`regions.AddChild(CaptionButton(c.Country,()=>{_rankRegion=c.Country;Render();},c==league))`；返回值紧邻使用处：`ExpressionStatementSyntax: regions.AddChild(CaptionButton(c.Country,()=>{_rankRegion=c.Country;Render();},c==league));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`tabs.AddChild(UnderlineTab(name,()=>{ _board=name; Render(); }, _board==name,Math.Max(78,name.Length*18+20),18,ranking:true))`；返回值紧邻使用处：`ExpressionStatementSyntax: tabs.AddChild(UnderlineTab(name,()=>{ _board=name; Render(); }, _board==name,Math.Max(78,name.Length*18+20),18,ranking:true));`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`select.AddItem($"第 {edition.Season} 赛季",edition.Season)`；返回值紧邻使用处：`ExpressionStatementSyntax: select.AddItem($"第 {edition.Season} 赛季",edition.Season);`
- `Godot.OptionButton.GetItemId(int)`；输入表达式：`select.GetItemId((int)index)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _rankSeason=select.GetItemId((int)index)`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new OptionButton()`
- `Godot.OptionButton.Select(int)`；输入表达式：`select.Select(editions.IndexOf(ceremony))`；返回值紧邻使用处：`ExpressionStatementSyntax: select.Select(editions.IndexOf(ceremony));`
- `NationalSpire.CareerScreen.BoardNotice(string, string, string)`；输入表达式：`BoardNotice("flag","本赛季尚无联赛排名","联赛建立后可按赛区查看参赛名单与积分。")`；返回值紧邻使用处：`ExpressionStatementSyntax: BoardNotice("flag","本赛季尚无联赛排名","联赛建立后可按赛区查看参赛名单与积分。");`
- `NationalSpire.CareerScreen.BoardNotice(string, string, string)`；输入表达式：`BoardNotice("trophy","年度排名尚未公布","每四个赛季评选一次，汇总这四个赛季的正式比赛表现。")`；返回值紧邻使用处：`ExpressionStatementSyntax: BoardNotice("trophy","年度排名尚未公布","每四个赛季评选一次，汇总这四个赛季的正式比赛表现。");`
- `NationalSpire.CareerScreen.BoardNotice(string, string, string)`；输入表达式：`BoardNotice("trophy","赛季排名尚未公布","赛季结束后，可在这里查看选手在正式比赛中的排名。")`；返回值紧邻使用处：`ExpressionStatementSyntax: BoardNotice("trophy","赛季排名尚未公布","赛季结束后，可在这里查看选手在正式比赛中的排名。");`
- `NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`；输入表达式：`CaptionButton(c.Country,()=>{_rankRegion=c.Country;Render();},c==league)`；返回值紧邻使用处：`ArgumentSyntax: CaptionButton(c.Country,()=>{_rankRegion=c.Country;Render();},c==league)`
- `NationalSpire.CareerScreen.CeremonyCriteria(NationalSpire.CareerData, NationalSpire.CeremonyRecord, bool)`；输入表达式：`CeremonyCriteria(d,ceremony,_board=="年度排名")`；返回值紧邻使用处：`ExpressionStatementSyntax: CeremonyCriteria(d,ceremony,_board=="年度排名");`
- `NationalSpire.CareerScreen.CeremonyRanking(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CeremonyRank>)`；输入表达式：`CeremonyRanking(d,rows)`；返回值紧邻使用处：`ExpressionStatementSyntax: CeremonyRanking(d,rows);`
- `NationalSpire.CareerScreen.CircuitRanking(NationalSpire.CareerData)`；输入表达式：`CircuitRanking(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CircuitRanking(d);`
- `NationalSpire.CareerScreen.FanChart(NationalSpire.CareerData)`；输入表达式：`FanChart(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: FanChart(d);`
- `NationalSpire.CareerScreen.LeagueTable(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool)`；输入表达式：`LeagueTable(d,league,_board=="俱乐部排名")`；返回值紧邻使用处：`ExpressionStatementSyntax: LeagueTable(d,league,_board=="俱乐部排名");`
- `NationalSpire.CareerScreen.NationRanking(NationalSpire.CareerData)`；输入表达式：`NationRanking(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: NationRanking(d);`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.TabStrip(Godot.Container, int, bool, bool)`；输入表达式：`TabStrip(_content,18,true,secondary:true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = TabStrip(_content,18,true,secondary:true)`
- `NationalSpire.CareerScreen.UnderlineTab(string, System.Action, bool, int, int, bool, bool)`；输入表达式：`UnderlineTab(name,()=>{ _board=name; Render(); }, _board==name,Math.Max(78,name.Length*18+20),18,ranking:true)`；返回值紧邻使用处：`ArgumentSyntax: UnderlineTab(name,()=>{ _board=name; Render(); }, _board==name,Math.Max(78,name.Length*18+20),18,ranking:true)`
- `NationalSpire.CareerScreen.WorldHonors(NationalSpire.CareerData)`；输入表达式：`WorldHonors(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: WorldHonors(d);`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`editions.FirstOrDefault()`；返回值紧邻使用处：`BinaryExpressionSyntax: editions.FirstOrDefault(c=>c.Season==_rankSeason)??editions.FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`leagues.FirstOrDefault()`；返回值紧邻使用处：`BinaryExpressionSyntax: leagues.FirstOrDefault(c=>c.Country==d.Esports.Country) ?? leagues.FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`editions.FirstOrDefault(c=>c.Season==_rankSeason)`；返回值紧邻使用处：`BinaryExpressionSyntax: editions.FirstOrDefault(c=>c.Season==_rankSeason)??editions.FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`leagues.FirstOrDefault(c=>c.Country==_rankRegion)`；返回值紧邻使用处：`BinaryExpressionSyntax: leagues.FirstOrDefault(c=>c.Country==_rankRegion) ?? leagues.FirstOrDefault(c=>c.Country==d.Esports.Country) ?? leagues.FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`leagues.FirstOrDefault(c=>c.Country==d.Esports.Country)`；返回值紧邻使用处：`BinaryExpressionSyntax: leagues.FirstOrDefault(c=>c.Country==d.Esports.Country) ?? leagues.FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Ceremonies.Where(c=>_board=="赛季排名" || c.YearTop.Count>0 || c.FullYear.Count>0).OrderByDescending(c=>c.Season)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Ceremonies.Where(c=>_board=="赛季排名" || c.YearTop.Count>0 || c.FullYear.Count>0).OrderByDescending(c=>c.Season).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.Ceremonies.Where(c=>_board=="赛季排名" || c.YearTop.Count>0 || c.FullYear.Count>0).OrderByDescending(c=>c.Season).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =d.Ceremonies.Where(c=>_board=="赛季排名" || c.YearTop.Count>0 || c.FullYear.Count>0).OrderByDescending(c=>c.Season).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.Esports.Competitions.Where(c=>c.Season==d.Season && c.Kind=="league").ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Esports.Competitions.Where(c=>c.Season==d.Season && c.Kind=="league").ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Ceremonies.Where(c=>_board=="赛季排名" || c.YearTop.Count>0 || c.FullYear.Count>0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Ceremonies.Where(c=>_board=="赛季排名" || c.YearTop.Count>0 || c.FullYear.Count>0).OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.Where(c=>c.Season==d.Season && c.Kind=="league")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.Competitions.Where(c=>c.Season==d.Season && c.Kind=="league").ToList`
- `System.Collections.Generic.List<T>.IndexOf(T)`；输入表达式：`editions.IndexOf(ceremony)`；返回值紧邻使用处：`ArgumentSyntax: editions.IndexOf(ceremony)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(78,name.Length*18+20)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(78,name.Length*18+20)`

**赋值（含属性/字段和局部值）：**

- `_board` = `name`
- `_rankRegion` = `c.Country`
- `_rankSeason` = `select.GetItemId((int)index)`
- `select.ItemSelected` += `index=>{_rankSeason=select.GetItemId((int)index);Render();}`

<a id="symbol-837344ae2c72"></a>

## `NationalSpire.CareerScreen.BoardNotice(string, string, string) — private void BoardNotice(string icon, string title, string detail)`

来源：源码第 175 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.CircuitRanking(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-b3ab649f5b65)；[`NationalSpire.CareerScreen.RankingPage(NationalSpire.CareerData)`](CareerBoardsScreen.cs.md#symbol-c8e7b9304826)；[`NationalSpire.CareerScreen.WorldHonors(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-3c1f80d447a9)

**调用：** [`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`](DashboardControls.cs.md#symbol-23c9e2f4b76f)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 18);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(panel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`copy.AddChild(Text(detail, 17, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddChild(Text(detail, 17, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`copy.AddChild(Text(title, 24, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddChild(Text(title, 24, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`Inner(panel).AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: Inner(panel).AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(copy)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(copy);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(Glyph(icon, 36, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(Glyph(icon, 36, _gold));`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；输入表达式：`Glyph(icon, 36, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Glyph(icon, 36, _gold)`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(panel)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Inner(panel).AddChild`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(detail, 17, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(detail, 17, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(title, 24, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(title, 24, _ink)`

**赋值（含属性/字段和局部值）：**

- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-7d1cd449d003"></a>

## `NationalSpire.CareerScreen.BoardLine(Godot.Container, NationalSpire.CareerData, int, string, string, string, string?, bool) — private void BoardLine(Container parent,CareerData d,int place,string name,string context,string value,string? person=null,bool own=false)`

来源：源码第 184 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.CircuitRanking(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-b3ab649f5b65)；[`NationalSpire.CareerScreen.FanChart(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-509582b2b893)；[`NationalSpire.CareerScreen.LeagueTable(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool)`](CareerBoardsScreen.cs.md#symbol-8456ab4b34a8)；[`NationalSpire.CareerScreen.LegacyLeagueTable(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CareerWorldScreen.cs.md#symbol-56f2bf2ccf4f)

**调用：** [`NationalSpire.CareerScreen.ActionRow(Godot.Container, string, string, System.Action, Godot.Control, int, int, int, string, string, string)`](DashboardControls.cs.md#symbol-5fcff8206cb6)；[`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`](CareerAvatars.cs.md#symbol-9f2c4623a902)；[`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`](DashboardControls.cs.md#symbol-1c4fb2c61c90)；[`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`](DashboardControls.cs.md#symbol-23c9e2f4b76f)；[`NationalSpire.CareerScreen.OpenPerson(string)`](CareerNavigation.cs.md#symbol-4430ec2bce8b)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`int.ToString(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.ActionRow(Godot.Container, string, string, System.Action, Godot.Control, int, int, int, string, string, string)`；`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`；`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；`NationalSpire.CareerScreen.OpenPerson(string)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Teal`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation",16)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation",16);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`badge.AddThemeStyleboxOverride("panel",CareerVisuals.Box(place<=3?"393326":"1b303d",place<=3?"8d764a":"3c5362",7,4))`；返回值紧邻使用处：`ExpressionStatementSyntax: badge.AddThemeStyleboxOverride("panel",CareerVisuals.Box(place<=3?"393326":"1b303d",place<=3?"8d764a":"3c5362",7,4));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel",CareerVisuals.Box("152733",own?"ae9360":"2d434f",6,12))`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel",CareerVisuals.Box("152733",own?"ae9360":"2d434f",6,12));`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer{MouseFilter=MouseFilterEnum.Ignore}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HBoxContainer{MouseFilter=MouseFilterEnum.Ignore}`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`badge.AddChild(rank)`；返回值紧邻使用处：`ExpressionStatementSyntax: badge.AddChild(rank);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`identity.AddChild(DashboardLabel(context,15,_muted,true))`；返回值紧邻使用处：`ExpressionStatementSyntax: identity.AddChild(DashboardLabel(context,15,_muted,true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`identity.AddChild(DashboardLabel(name,19,own?_gold:_ink,true))`；返回值紧邻使用处：`ExpressionStatementSyntax: identity.AddChild(DashboardLabel(name,19,own?_gold:_ink,true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(panel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(Avatar(d,person,46,false))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(Avatar(d,person,46,false));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(badge)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(badge);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(Glyph("chevron-right",16,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(Glyph("chevron-right",16,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(Glyph("flag",24,CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(Glyph("flag",24,CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(identity)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(identity);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(metric)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(metric);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new PanelContainer()`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer{CustomMinimumSize=new(56,42),SizeFlagsVertical=SizeFlags.ShrinkCenter,MouseFilter=MouseFilterEnum.Ignore}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new PanelContainer{CustomMinimumSize=new(56,42),SizeFlagsVertical=SizeFlags.ShrinkCenter,MouseFilter=MouseFilterEnum.Ignore}`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer{SizeFlagsHorizontal=SizeFlags.ExpandFill,Alignment=BoxContainer.AlignmentMode.Center,MouseFilter=MouseFilterEnum.Ignore}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer{SizeFlagsHorizontal=SizeFlags.ExpandFill,Alignment=BoxContainer.AlignmentMode.Center,MouseFilter=MouseFilterEnum.Ignore}`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(56,42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(56,42)`
- `int.ToString(string?)`；输入表达式：`place.ToString("00")`；返回值紧邻使用处：`ArgumentSyntax: place.ToString("00")`
- `NationalSpire.CareerScreen.ActionRow(Godot.Container, string, string, System.Action, Godot.Control, int, int, int, string, string, string)`；输入表达式：`ActionRow(parent,"Standing_"+place,name,()=>OpenPerson(person),row,66,14,6,"152733",own?"ae9360":"2d434f","213c49")`；返回值紧邻使用处：`ExpressionStatementSyntax: ActionRow(parent,"Standing_"+place,name,()=>OpenPerson(person),row,66,14,6,"152733",own?"ae9360":"2d434f","213c49");`
- `NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`；输入表达式：`Avatar(d,person,46,false)`；返回值紧邻使用处：`ArgumentSyntax: Avatar(d,person,46,false)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(context,15,_muted,true)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(context,15,_muted,true)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(name,19,own?_gold:_ink,true)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(name,19,own?_gold:_ink,true)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(place.ToString("00"),23,own||place<=3?_gold:_muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =DashboardLabel(place.ToString("00"),23,own||place<=3?_gold:_muted)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(value,20,CareerVisuals.Teal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =DashboardLabel(value,20,CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；输入表达式：`Glyph("chevron-right",16,_muted)`；返回值紧邻使用处：`ArgumentSyntax: Glyph("chevron-right",16,_muted)`
- `NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；输入表达式：`Glyph("flag",24,CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Glyph("flag",24,CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.OpenPerson(string)`；输入表达式：`OpenPerson(person)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>OpenPerson(person)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("152733",own?"ae9360":"2d434f",6,12)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("152733",own?"ae9360":"2d434f",6,12)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box(place<=3?"393326":"1b303d",place<=3?"8d764a":"3c5362",7,4)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box(place<=3?"393326":"1b303d",place<=3?"8d764a":"3c5362",7,4)`

**赋值（含属性/字段和局部值）：**

- `Alignment` = `BoxContainer.AlignmentMode.Center`
- `CustomMinimumSize` = `new(56,42)`
- `metric.HorizontalAlignment` = `HorizontalAlignment.Right`
- `metric.SizeFlagsHorizontal` = `SizeFlags.ShrinkEnd`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `rank.HorizontalAlignment` = `HorizontalAlignment.Center`
- `rank.VerticalAlignment` = `VerticalAlignment.Center`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`

<a id="symbol-8456ab4b34a8"></a>

## `NationalSpire.CareerScreen.LeagueTable(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool) — private void LeagueTable(CareerData d, WorldCompetition c, bool clubs)`

来源：源码第 200 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ModernCompetition(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CircuitScreen.cs.md#symbol-6edbcc2815f7)；[`NationalSpire.CareerScreen.RankingPage(NationalSpire.CareerData)`](CareerBoardsScreen.cs.md#symbol-c8e7b9304826)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerScreen.BoardLine(Godot.Container, NationalSpire.CareerData, int, string, string, string, string?, bool)`](CareerBoardsScreen.cs.md#symbol-7d1cd449d003)；[`NationalSpire.CareerScreen.LegacyLeagueTable(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CareerWorldScreen.cs.md#symbol-56f2bf2ccf4f)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CircuitWorld.TeamName(NationalSpire.CareerData, NationalSpire.WorldCompetition, string)`](CircuitWorld.cs.md#symbol-74904a83d22a)；[`NationalSpire.CircuitWorld.TeamTable(NationalSpire.WorldCompetition)`](CircuitWorld.cs.md#symbol-ca39b3e6a0f0)；[`NationalSpire.EsportsWorld.Rankings(NationalSpire.WorldCompetition)`](EsportsWorld.cs.md#symbol-1382bbc5c3c3)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen.BoardLine(Godot.Container, NationalSpire.CareerData, int, string, string, string, string?, bool)`；`NationalSpire.CareerScreen.LegacyLeagueTable(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerStanding.Draws`；`NationalSpire.CareerStanding.Losses`；`NationalSpire.CareerStanding.PersonId`；`NationalSpire.CareerStanding.Points`；`NationalSpire.CareerStanding.Wins`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.CircuitWorld.TeamName(NationalSpire.CareerData, NationalSpire.WorldCompetition, string)`；`NationalSpire.CircuitWorld.TeamTable(NationalSpire.WorldCompetition)`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsWorld.Rankings(NationalSpire.WorldCompetition)`；`NationalSpire.WorldCompetition.Modern`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("俱乐部积分：胜3分、平1分、负0分；同分比较个人对决胜场。前二进入洲际杯。",17,_ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("俱乐部积分：胜3分、平1分、负0分；同分比较个人对决胜场。前二进入洲际杯。",17,_ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("奇数赛季前两名直通世界总决赛，其余席位按世界积分和本季表现补齐。",17,CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("奇数赛季前两名直通世界总决赛，其余席位按世界积分和本季表现补齐。",17,CareerVisuals.Teal));`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d,row.PersonId)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.DisplayName(d,row.PersonId)`
- `NationalSpire.CareerScreen.BoardLine(Godot.Container, NationalSpire.CareerData, int, string, string, string, string?, bool)`；输入表达式：`BoardLine(_content,d,++rank,CircuitWorld.TeamName(d,c,row.PersonId),$"{row.Wins} 胜   {row.Draws} 平   {row.Losses} 负",$"{row.Points} 分",own:row.PersonId==d.Esports.ClubId)`；返回值紧邻使用处：`ExpressionStatementSyntax: BoardLine(_content,d,++rank,CircuitWorld.TeamName(d,c,row.PersonId),$"{row.Wins} 胜   {row.Draws} 平   {row.Losses} 负",$"{row.Points} 分",own:row.PersonId==d.Esports.ClubId);`
- `NationalSpire.CareerScreen.BoardLine(Godot.Container, NationalSpire.CareerData, int, string, string, string, string?, bool)`；输入表达式：`BoardLine(_content,d,rank,CareerEngine.DisplayName(d,row.PersonId),$"{row.Wins} 胜   {row.Draws} 平   {row.Losses} 负",$"{row.Points} 分",row.PersonId,row.PersonId=="player")`；返回值紧邻使用处：`ExpressionStatementSyntax: BoardLine(_content,d,rank,CareerEngine.DisplayName(d,row.PersonId),$"{row.Wins} 胜   {row.Draws} 平   {row.Losses} 负",$"{row.Points} 分",row.PersonId,row.PersonId=="player");`
- `NationalSpire.CareerScreen.LegacyLeagueTable(NationalSpire.CareerData, NationalSpire.WorldCompetition)`；输入表达式：`LegacyLeagueTable(d,c)`；返回值紧邻使用处：`ExpressionStatementSyntax: LegacyLeagueTable(d,c);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("俱乐部积分：胜3分、平1分、负0分；同分比较个人对决胜场。前二进入洲际杯。",17,_ink)`；返回值紧邻使用处：`ArgumentSyntax: Text("俱乐部积分：胜3分、平1分、负0分；同分比较个人对决胜场。前二进入洲际杯。",17,_ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("奇数赛季前两名直通世界总决赛，其余席位按世界积分和本季表现补齐。",17,CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Text("奇数赛季前两名直通世界总决赛，其余席位按世界积分和本季表现补齐。",17,CareerVisuals.Teal)`
- `NationalSpire.CircuitWorld.TeamName(NationalSpire.CareerData, NationalSpire.WorldCompetition, string)`；输入表达式：`CircuitWorld.TeamName(d,c,row.PersonId)`；返回值紧邻使用处：`ArgumentSyntax: CircuitWorld.TeamName(d,c,row.PersonId)`
- `NationalSpire.CircuitWorld.TeamTable(NationalSpire.WorldCompetition)`；输入表达式：`CircuitWorld.TeamTable(c)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var row in CircuitWorld.TeamTable(c)) BoardLine(_content,d,++rank,CircuitWorld.TeamName(d,c,row.PersonId),$"{row.Wins} 胜   {row.Draws} 平   {row.Losses} 负",$"{row.Points} 分",own:row.PersonId==d.Esports.ClubId);`
- `NationalSpire.EsportsWorld.Rankings(NationalSpire.WorldCompetition)`；输入表达式：`EsportsWorld.Rankings(c)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: EsportsWorld.Rankings(c).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`EsportsWorld.Rankings(c).Take(6)`；返回值紧邻使用处：`ForEachVariableStatementSyntax: foreach (var (row,rank) in EsportsWorld.Rankings(c).Take(6))                  BoardLine(_content,d,rank,CareerEngine.DisplayName(d,row.PersonId),$"{row.Wins} 胜   {row.Draws} 平   {row.Losses} 负",$"{row.Points} 分",row.PersonId,row.PersonId=="player");`

**赋值（含属性/字段和局部值）：**
