# LifestyleArt.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`55E852DDB80BDC87B7D11585E32B0B56B949491A1119E1861A2BFAF34F5CFB60`。来源：[源码](../../LifestyleArt.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.LifestyleArt`。

字段、事件及初始值（源码原样）：

```csharp
public static readonly string[] Sections = ["活动与计划", "我的空间", "消费商城", "交易市场", "人气榜", "公开消息", "收支记录"];
private static readonly Dictionary<string, Texture2D> Icons = [];
```

<a id="symbol-91f9b2ac06fa"></a>

## `NationalSpire.LifestyleArt.Icon(string) — public static Texture2D Icon(string section)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`ActionButton(string, string, System.Action)`](MarketVisuals.cs.md#symbol-183827086673)；[`NationalSpire.CareerListCache._Process(double)`](CareerListCache.cs.md#symbol-e8085c360313)；[`NationalSpire.CareerScreen.Life(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-0cdff88b6131)；[`NationalSpire.CareerScreen.MarketScreen(NationalSpire.CareerData)`](MarketScreen.cs.md#symbol-333b046d27f4)；[`NationalSpire.MarketAssetButton.Bind(NationalSpire.MarketAsset, NationalSpire.MarketQuote, bool, bool)`](MarketVisuals.cs.md#symbol-4e16b3f4bac4)；[`NationalSpire.MarketPositionCard.Bind(NationalSpire.MarketPosition?, NationalSpire.MarketQuote?, long, NationalSpire.MarketExecution.Exit?, bool)`](MarketVisuals.cs.md#symbol-fd36a7e27494)；[`NationalSpire.MarketPositionCard.MarketPositionCard(System.Action, System.Action<NationalSpire.MarketOrder>)`](MarketVisuals.cs.md#symbol-66bfead77ff7)；[`NationalSpire.MarketTerminal.Build()`](MarketTerminal.cs.md#symbol-285abee5b9f5)；[`NationalSpire.MarketTerminal.RefreshSelection()`](MarketTerminal.cs.md#symbol-c8cd06b76400)；[`NationalSpire.MarketVisuals.ActionStyle(Godot.Button, string)`](MarketVisuals.cs.md#symbol-5703b8242580)

**调用：** [`NationalSpire.MarketVisuals.Accent(string)`](MarketVisuals.cs.md#symbol-7251a1de5493)；`Godot.Color.ToHtml(bool)`；`Godot.Image.Image()`；`Godot.Image.LoadSvgFromString(string, float)`；`Godot.ImageTexture.CreateFromImage(Godot.Image)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.LifestyleArt.Icons`；`NationalSpire.MarketVisuals.Accent(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.ToHtml(bool)`；输入表达式：`MarketVisuals.Accent(section).ToHtml(false)`；返回值紧邻使用处：`ConditionalExpressionSyntax: section is "训练装备" or "电竞设备" or "日常消费" or "外汇" or "做多" or "做空" ? MarketVisuals.Accent(section).ToHtml(false) : "8bd9cd"`
- `Godot.Image.Image()`；输入表达式：`new Image()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Image()`
- `Godot.Image.LoadSvgFromString(string, float)`；输入表达式：`image.LoadSvgFromString("<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32'><path d='" + path + "' fill='none' stroke='#" + color + "' stroke-width='1.7' stroke-linecap='round' stroke-linejoin='round'/></svg>")`；返回值紧邻使用处：`ExpressionStatementSyntax: image.LoadSvgFromString("<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32'><path d='" + path + "' fill='none' stroke='#" + color + "' stroke-width='1.7' stroke-linecap='round' stroke-linejoin='round'/></svg>");`
- `Godot.ImageTexture.CreateFromImage(Godot.Image)`；输入表达式：`ImageTexture.CreateFromImage(image)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Icons[section] = ImageTexture.CreateFromImage(image)`
- `NationalSpire.MarketVisuals.Accent(string)`；输入表达式：`MarketVisuals.Accent(section)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: MarketVisuals.Accent(section).ToHtml`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Icons.TryGetValue(section, out var icon)`；返回值紧邻使用处：`IfStatementSyntax: if (Icons.TryGetValue(section, out var icon)) return icon;`

**赋值（含属性/字段和局部值）：**

- `Icons[section]` = `ImageTexture.CreateFromImage(image)`

<a id="symbol-baf138bcab5f"></a>

## `NationalSpire.LifestyleArt.Category — public string Category`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e67effd5a6cb"></a>

## `NationalSpire.LifestyleArt.ProductId — public string ProductId`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-aacb36d25f1b"></a>

## `NationalSpire.LifestyleArt._Ready() — public override void _Ready()`

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Resized` += `QueueRedraw`

<a id="symbol-8b1cbb5282e0"></a>

## `NationalSpire.LifestyleArt._Draw() — public override void _Draw()`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`Line(float, float, float, float, Godot.Color?)`](LifestyleArt.cs.md#symbol-c3cb30fce98c)；[`NationalSpire.ConsumerProductArt.Texture(string)`](ConsumerProductArt.cs.md#symbol-888e0fff64ed)；[`P(float, float)`](LifestyleArt.cs.md#symbol-e50dcf6d6a45)；`Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；`Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float)`；`Godot.CanvasItem.DrawTextureRect(Godot.Texture2D, Godot.Rect2, bool, Godot.Color?, bool)`；`Godot.Color.Color(string)`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.Vector2.Vector2(float, float)`；`string.Contains(string)`；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** `Line(float, float, float, float, Godot.Color?)`；`NationalSpire.CareerVisuals.Gold`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.ConsumerProductArt.Texture(string)`；`NationalSpire.LifestyleArt.Category`；`NationalSpire.LifestyleArt.ProductId`；`P(float, float)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(center, 87 * scale, -.5f, 4.5f, 48, teal, scale, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(center, 87 * scale, -.5f, 4.5f, 48, teal, scale, true);`
- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(P(0,-30),32*scale,0,Mathf.Tau,40,ink,2*scale,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(P(0,-30),32*scale,0,Mathf.Tau,40,ink,2*scale,true);`
- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(P(34,-8),20*scale,-1.5f,1.5f,20,ink,2*scale,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(P(34,-8),20*scale,-1.5f,1.5f,20,ink,2*scale,true);`
- `Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；输入表达式：`DrawCircle(center, 76 * scale, new Color("153846"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawCircle(center, 76 * scale, new Color("153846"));`
- `Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；输入表达式：`DrawCircle(P(-42,30),14*scale,teal)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawCircle(P(-42,30),14*scale,teal);`
- `Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；输入表达式：`DrawCircle(P(0,-30),32*scale,teal)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawCircle(P(0,-30),32*scale,teal);`
- `Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；输入表达式：`DrawCircle(P(45,30),14*scale,teal)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawCircle(P(45,30),14*scale,teal);`
- `Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；输入表达式：`DrawCircle(P(x,-45),4*scale,ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawCircle(P(x,-45),4*scale,ink);`
- `Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；输入表达式：`DrawPolyline([P(-28,-12),P(28,-12),P(0,58),P(-28,-12)], ink, 2*scale,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline([P(-28,-12),P(28,-12),P(0,58),P(-28,-12)], ink, 2*scale,true);`
- `Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；输入表达式：`DrawPolyline([P(-35,18),P(-25,-17),P(28,-17),P(42,18)],ink,2*scale,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline([P(-35,18),P(-25,-17),P(28,-17),P(42,18)],ink,2*scale,true);`
- `Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；输入表达式：`DrawPolyline([P(-42,-30),P(34,-30),P(29,35),P(-35,35),P(-42,-30)],ink,2*scale,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline([P(-42,-30),P(34,-30),P(29,35),P(-35,35),P(-42,-30)],ink,2*scale,true);`
- `Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；输入表达式：`DrawPolyline([P(-43,8),P(-22,-12),P(-2,-1),P(20,-30),P(42,-20)],CareerVisuals.Teal,3*scale,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline([P(-43,8),P(-22,-12),P(-2,-1),P(20,-30),P(42,-20)],CareerVisuals.Teal,3*scale,true);`
- `Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；输入表达式：`DrawPolyline([P(-50,-20),P(-25,-45),P(25,-45),P(50,-20),P(0,48),P(-50,-20),P(50,-20)],ink,2*scale,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline([P(-50,-20),P(-25,-45),P(25,-45),P(50,-20),P(0,48),P(-50,-20),P(50,-20)],ink,2*scale,true);`
- `Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；输入表达式：`DrawPolyline([P(-62,-42),P(62,-42),P(62,24),P(-62,24),P(-62,-42)],ink,2*scale,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline([P(-62,-42),P(62,-42),P(62,24),P(-62,24),P(-62,-42)],ink,2*scale,true);`
- `Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；输入表达式：`DrawPolyline([P(-72,28),P(-65,-4),P(-30,-12),P(-12,-38),P(32,-38),P(56,-7),P(76,2),P(76,28),P(-72,28)],ink,2*scale,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline([P(-72,28),P(-65,-4),P(-30,-12),P(-12,-38),P(32,-38),P(56,-7),P(76,2),P(76,28),P(-72,28)],ink,2*scale,true);`
- `Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；输入表达式：`DrawPolyline([P(-75,18),P(70,18),P(40,47),P(-48,47),P(-75,18)],ink,2*scale,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline([P(-75,18),P(70,18),P(40,47),P(-48,47),P(-75,18)],ink,2*scale,true);`
- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float)`；输入表达式：`DrawRect(new Rect2(P(-55,-10),new Vector2(110,58)*scale),ink,false,2*scale)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawRect(new Rect2(P(-55,-10),new Vector2(110,58)*scale),ink,false,2*scale);`
- `Godot.CanvasItem.DrawTextureRect(Godot.Texture2D, Godot.Rect2, bool, Godot.Color?, bool)`；输入表达式：`DrawTextureRect(product, new Rect2(P(-65, -65), new Vector2(130, 130) * scale), false)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawTextureRect(product, new Rect2(P(-65, -65), new Vector2(130, 130) * scale), false);`
- `Godot.Color.Color(string)`；输入表达式：`new Color("153846")`；返回值紧邻使用处：`ArgumentSyntax: new Color("153846")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("436c72")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Color("436c72")`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(P(-55,-10),new Vector2(110,58)*scale)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(P(-55,-10),new Vector2(110,58)*scale)`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(P(-65, -65), new Vector2(130, 130) * scale)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(P(-65, -65), new Vector2(130, 130) * scale)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(110,58)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(110,58)*scale`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(130, 130)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(130, 130) * scale`
- `Line(float, float, float, float, Godot.Color?)`；输入表达式：`Line(-10,-17,-10,-46)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(-10,-17,-10,-46);`
- `Line(float, float, float, float, Godot.Color?)`；输入表达式：`Line(-10,-46,30,-32)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(-10,-46,30,-32);`
- `Line(float, float, float, float, Godot.Color?)`；输入表达式：`Line(-20,-49,-14,-67,teal)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(-20,-49,-14,-67,teal);`
- `Line(float, float, float, float, Godot.Color?)`；输入表达式：`Line(-20,6,12,30)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(-20,6,12,30);`
- `Line(float, float, float, float, Godot.Color?)`；输入表达式：`Line(-25,-45,0,48)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(-25,-45,0,48);`
- `Line(float, float, float, float, Godot.Color?)`；输入表达式：`Line(-30,-12,56,-7)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(-30,-12,56,-7);`
- `Line(float, float, float, float, Godot.Color?)`；输入表达式：`Line(-30,45,30,45)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(-30,45,30,45);`
- `Line(float, float, float, float, Godot.Color?)`；输入表达式：`Line(-48+i*37,63,-25+i*37,63,teal)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(-48+i*37,63,-25+i*37,63,teal);`
- `Line(float, float, float, float, Godot.Color?)`；输入表达式：`Line(-52,46,51,46)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(-52,46,51,46);`
- `Line(float, float, float, float, Godot.Color?)`；输入表达式：`Line(-55,12,55,12)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(-55,12,55,12);`
- `Line(float, float, float, float, Godot.Color?)`；输入表达式：`Line(-55,32,55,32)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(-55,32,55,32);`
- `Line(float, float, float, float, Godot.Color?)`；输入表达式：`Line(-62,-22,15,-55)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(-62,-22,15,-55);`
- `Line(float, float, float, float, Godot.Color?)`；输入表达式：`Line(-62,40,-62,-22)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(-62,40,-62,-22);`
- `Line(float, float, float, float, Godot.Color?)`；输入表达式：`Line(-62,40,65,40)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(-62,40,65,40);`
- `Line(float, float, float, float, Godot.Color?)`；输入表达式：`Line(-72,-18,15,-66)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(-72,-18,15,-66);`
- `Line(float, float, float, float, Godot.Color?)`；输入表达式：`Line(-78, 57, 78, 57, teal)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(-78, 57, 78, 57, teal);`
- `Line(float, float, float, float, Godot.Color?)`；输入表达式：`Line(0,24,0,45)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(0,24,0,45);`
- `Line(float, float, float, float, Godot.Color?)`；输入表达式：`Line(10,-38,10,-10)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(10,-38,10,-10);`
- `Line(float, float, float, float, Godot.Color?)`；输入表达式：`Line(15,-55,15,40)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(15,-55,15,40);`
- `Line(float, float, float, float, Godot.Color?)`；输入表达式：`Line(15,-55,65,-18)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(15,-55,65,-18);`
- `Line(float, float, float, float, Godot.Color?)`；输入表达式：`Line(15,-66,75,-18)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(15,-66,75,-18);`
- `Line(float, float, float, float, Godot.Color?)`；输入表达式：`Line(20,6,-12,30)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(20,6,-12,30);`
- `Line(float, float, float, float, Godot.Color?)`；输入表达式：`Line(25,-45,0,48)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(25,-45,0,48);`
- `Line(float, float, float, float, Godot.Color?)`；输入表达式：`Line(30,-32,-10,-22)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(30,-32,-10,-22);`
- `Line(float, float, float, float, Godot.Color?)`；输入表达式：`Line(30,2,49,2)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(30,2,49,2);`
- `Line(float, float, float, float, Godot.Color?)`；输入表达式：`Line(30,40,30,2)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(30,40,30,2);`
- `Line(float, float, float, float, Godot.Color?)`；输入表达式：`Line(49,2,49,40)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(49,2,49,40);`
- `Line(float, float, float, float, Godot.Color?)`；输入表达式：`Line(65,-18,65,40)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(65,-18,65,40);`
- `Line(float, float, float, float, Godot.Color?)`；输入表达式：`Line(8,-47,14,-65,teal)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(8,-47,14,-65,teal);`
- `Line(float, float, float, float, Godot.Color?)`；输入表达式：`Line(x,-12,x,-37)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(x,-12,x,-37);`
- `Line(float, float, float, float, Godot.Color?)`；输入表达式：`Line(x,-5,x,16)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(x,-5,x,16);`
- `Line(float, float, float, float, Godot.Color?)`；输入表达式：`Line(x,-5,x+10,-5)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(x,-5,x+10,-5);`
- `Line(float, float, float, float, Godot.Color?)`；输入表达式：`Line(x,16,x+10,16)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(x,16,x+10,16);`
- `Line(float, float, float, float, Godot.Color?)`；输入表达式：`Line(x+10,-5,x+10,16)`；返回值紧邻使用处：`ExpressionStatementSyntax: Line(x+10,-5,x+10,16);`
- `NationalSpire.ConsumerProductArt.Texture(string)`；输入表达式：`ConsumerProductArt.Texture(ProductId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ConsumerProductArt.Texture(ProductId) is { } product`
- `P(float, float)`；输入表达式：`P(-12,-38)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-12,-38)`
- `P(float, float)`；输入表达式：`P(-2,-1)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-2,-1)`
- `P(float, float)`；输入表达式：`P(-22,-12)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-22,-12)`
- `P(float, float)`；输入表达式：`P(-25,-17)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-25,-17)`
- `P(float, float)`；输入表达式：`P(-25,-45)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-25,-45)`
- `P(float, float)`；输入表达式：`P(-28,-12)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-28,-12)`
- `P(float, float)`；输入表达式：`P(-30,-12)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-30,-12)`
- `P(float, float)`；输入表达式：`P(-35,18)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-35,18)`
- `P(float, float)`；输入表达式：`P(-35,35)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-35,35)`
- `P(float, float)`；输入表达式：`P(-42,-30)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-42,-30)`
- `P(float, float)`；输入表达式：`P(-42,30)`；返回值紧邻使用处：`ArgumentSyntax: P(-42,30)`
- `P(float, float)`；输入表达式：`P(-43,8)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-43,8)`
- `P(float, float)`；输入表达式：`P(-48,47)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-48,47)`
- `P(float, float)`；输入表达式：`P(-50,-20)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-50,-20)`
- `P(float, float)`；输入表达式：`P(-55,-10)`；返回值紧邻使用处：`ArgumentSyntax: P(-55,-10)`
- `P(float, float)`；输入表达式：`P(-62,-42)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-62,-42)`
- `P(float, float)`；输入表达式：`P(-62,24)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-62,24)`
- `P(float, float)`；输入表达式：`P(-65, -65)`；返回值紧邻使用处：`ArgumentSyntax: P(-65, -65)`
- `P(float, float)`；输入表达式：`P(-65,-4)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-65,-4)`
- `P(float, float)`；输入表达式：`P(-72,28)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-72,28)`
- `P(float, float)`；输入表达式：`P(-75,18)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-75,18)`
- `P(float, float)`；输入表达式：`P(0,-30)`；返回值紧邻使用处：`ArgumentSyntax: P(0,-30)`
- `P(float, float)`；输入表达式：`P(0,48)`；返回值紧邻使用处：`ExpressionElementSyntax: P(0,48)`
- `P(float, float)`；输入表达式：`P(0,58)`；返回值紧邻使用处：`ExpressionElementSyntax: P(0,58)`
- `P(float, float)`；输入表达式：`P(20,-30)`；返回值紧邻使用处：`ExpressionElementSyntax: P(20,-30)`
- `P(float, float)`；输入表达式：`P(25,-45)`；返回值紧邻使用处：`ExpressionElementSyntax: P(25,-45)`
- `P(float, float)`；输入表达式：`P(28,-12)`；返回值紧邻使用处：`ExpressionElementSyntax: P(28,-12)`
- `P(float, float)`；输入表达式：`P(28,-17)`；返回值紧邻使用处：`ExpressionElementSyntax: P(28,-17)`
- `P(float, float)`；输入表达式：`P(29,35)`；返回值紧邻使用处：`ExpressionElementSyntax: P(29,35)`
- `P(float, float)`；输入表达式：`P(32,-38)`；返回值紧邻使用处：`ExpressionElementSyntax: P(32,-38)`
- `P(float, float)`；输入表达式：`P(34,-30)`；返回值紧邻使用处：`ExpressionElementSyntax: P(34,-30)`
- `P(float, float)`；输入表达式：`P(34,-8)`；返回值紧邻使用处：`ArgumentSyntax: P(34,-8)`
- `P(float, float)`；输入表达式：`P(40,47)`；返回值紧邻使用处：`ExpressionElementSyntax: P(40,47)`
- `P(float, float)`；输入表达式：`P(42,-20)`；返回值紧邻使用处：`ExpressionElementSyntax: P(42,-20)`
- `P(float, float)`；输入表达式：`P(42,18)`；返回值紧邻使用处：`ExpressionElementSyntax: P(42,18)`
- `P(float, float)`；输入表达式：`P(45,30)`；返回值紧邻使用处：`ArgumentSyntax: P(45,30)`
- `P(float, float)`；输入表达式：`P(50,-20)`；返回值紧邻使用处：`ExpressionElementSyntax: P(50,-20)`
- `P(float, float)`；输入表达式：`P(56,-7)`；返回值紧邻使用处：`ExpressionElementSyntax: P(56,-7)`
- `P(float, float)`；输入表达式：`P(62,-42)`；返回值紧邻使用处：`ExpressionElementSyntax: P(62,-42)`
- `P(float, float)`；输入表达式：`P(62,24)`；返回值紧邻使用处：`ExpressionElementSyntax: P(62,24)`
- `P(float, float)`；输入表达式：`P(70,18)`；返回值紧邻使用处：`ExpressionElementSyntax: P(70,18)`
- `P(float, float)`；输入表达式：`P(76,2)`；返回值紧邻使用处：`ExpressionElementSyntax: P(76,2)`
- `P(float, float)`；输入表达式：`P(76,28)`；返回值紧邻使用处：`ExpressionElementSyntax: P(76,28)`
- `P(float, float)`；输入表达式：`P(x,-45)`；返回值紧邻使用处：`ArgumentSyntax: P(x,-45)`
- `string.Contains(string)`；输入表达式：`Category.Contains("车")`；返回值紧邻使用处：`BinaryExpressionSyntax: Category.Contains("车") || Category.Contains("交通")`
- `string.Contains(string)`；输入表达式：`Category.Contains("穿戴")`；返回值紧邻使用处：`BinaryExpressionSyntax: Category.Contains("穿戴") || Category.Contains("珠宝")`
- `string.Contains(string)`；输入表达式：`Category.Contains("蛋糕")`；返回值紧邻使用处：`IfStatementSyntax: if (Category.Contains("蛋糕"))          {              DrawRect(new Rect2(P(-55,-10),new Vector2(110,58)*scale),ink,false,2*scale);              Line(-55,12,55,12);Line(-55,32,55,32);              foreach(float x in new[]{-25f,0f,25f}){Line(x,-12,x,-37);DrawCircle(P(x,-45),4*scale,ink);}          }          else if (Category.Contains("穿戴") || Category.Contains("珠宝"))          {              DrawPolyline([P(-50,-20),P(-25,-45),P(25,-45),P(50,-20),P(0,48),P(-50,-20),P(50,-20)],ink,2*scale,true);              Line(-25,-45,0,48);Line(25,-45,0,48);          }          else if (Category.Contains("房") || Category.Contains("住宅") || Category.Contains("地产") || Category.Contains("家居"))          {              Line(-62,40,-62,-22);Line(-62,-22,15,-55);Line(15,-55,65,-18);Line(65,-18,65,40);Line(-62,40,65,40);              Line(-72,-18,15,-66);Line(15,-66,75,-18);Line(15,-55,15,40);Line(30,40,30,2);Line(30,2,49,2);Line(49,2,49,40);              for(int i=0;i<3;i++){ float x=-46+i*19;Line(x,-5,x,16);Line(x,-5,x+10,-5);Line(x+10,-5,x+10,16);Line(x,16,x+10,16); }          }          else if (Category.Contains("车") || Category.Contains("交通"))          {              DrawPolyline([P(-72,28),P(-65,-4),P(-30,-12),P(-12,-38),P(32,-38),P(56,-7),P(76,2),P(76,28),P(-72,28)],ink,2*scale,true);              Line(-30,-12,56,-7);Line(10,-38,10,-10);DrawCircle(P(-42,30),14*scale,teal);DrawCircle(P(45,30),14*scale,teal);          }          else if (Category.Contains("艇") || Category.Contains("航") || Category.Contains("游"))          {              DrawPolyline([P(-75,18),P(70,18),P(40,47),P(-48,47),P(-75,18)],ink,2*scale,true);              DrawPolyline([P(-35,18),P(-25,-17),P(28,-17),P(42,18)],ink,2*scale,true);Line(-10,-17,-10,-46);Line(-10,-46,30,-32);Line(30,-32,-10,-22);              for(int i=0;i<3;i++)Line(-48+i*37,63,-25+i*37,63,teal);          }          else if (Category.Contains("数码") || Category.Contains("设备") || Category.Contains("运营"))          {              DrawPolyline([P(-62,-42),P(62,-42),P(62,24),P(-62,24),P(-62,-42)],ink,2*scale,true);Line(0,24,0,45);Line(-30,45,30,45);              DrawPolyline([P(-43,8),P(-22,-12),P(-2,-1),P(20,-30),P(42,-20)],CareerVisuals.Teal,3*scale,true);          }          else          {              DrawPolyline([P(-42,-30),P(34,-30),P(29,35),P(-35,35),P(-42,-30)],ink,2*scale,true);              DrawArc(P(34,-8),20*scale,-1.5f,1.5f,20,ink,2*scale,true);Line(-52,46,51,46);Line(-20,-49,-14,-67,teal);Line(8,-47,14,-65,teal);          }`
- `string.Contains(string)`；输入表达式：`Category.Contains("地产")`；返回值紧邻使用处：`BinaryExpressionSyntax: Category.Contains("房") || Category.Contains("住宅") || Category.Contains("地产")`
- `string.Contains(string)`；输入表达式：`Category.Contains("房")`；返回值紧邻使用处：`BinaryExpressionSyntax: Category.Contains("房") || Category.Contains("住宅")`
- `string.Contains(string)`；输入表达式：`Category.Contains("航")`；返回值紧邻使用处：`BinaryExpressionSyntax: Category.Contains("艇") || Category.Contains("航")`
- `string.Contains(string)`；输入表达式：`Category.Contains("家居")`；返回值紧邻使用处：`BinaryExpressionSyntax: Category.Contains("房") || Category.Contains("住宅") || Category.Contains("地产") || Category.Contains("家居")`
- `string.Contains(string)`；输入表达式：`Category.Contains("交通")`；返回值紧邻使用处：`BinaryExpressionSyntax: Category.Contains("车") || Category.Contains("交通")`
- `string.Contains(string)`；输入表达式：`Category.Contains("设备")`；返回值紧邻使用处：`BinaryExpressionSyntax: Category.Contains("数码") || Category.Contains("设备")`
- `string.Contains(string)`；输入表达式：`Category.Contains("数码")`；返回值紧邻使用处：`BinaryExpressionSyntax: Category.Contains("数码") || Category.Contains("设备")`
- `string.Contains(string)`；输入表达式：`Category.Contains("甜筒")`；返回值紧邻使用处：`IfStatementSyntax: if (Category.Contains("甜筒"))          {              DrawPolyline([P(-28,-12),P(28,-12),P(0,58),P(-28,-12)], ink, 2*scale,true);              DrawCircle(P(0,-30),32*scale,teal);DrawArc(P(0,-30),32*scale,0,Mathf.Tau,40,ink,2*scale,true);              Line(-20,6,12,30);Line(20,6,-12,30);          }          else if (Category.Contains("蛋糕"))          {              DrawRect(new Rect2(P(-55,-10),new Vector2(110,58)*scale),ink,false,2*scale);              Line(-55,12,55,12);Line(-55,32,55,32);              foreach(float x in new[]{-25f,0f,25f}){Line(x,-12,x,-37);DrawCircle(P(x,-45),4*scale,ink);}          }          else if (Category.Contains("穿戴") || Category.Contains("珠宝"))          {              DrawPolyline([P(-50,-20),P(-25,-45),P(25,-45),P(50,-20),P(0,48),P(-50,-20),P(50,-20)],ink,2*scale,true);              Line(-25,-45,0,48);Line(25,-45,0,48);          }          else if (Category.Contains("房") || Category.Contains("住宅") || Category.Contains("地产") || Category.Contains("家居"))          {              Line(-62,40,-62,-22);Line(-62,-22,15,-55);Line(15,-55,65,-18);Line(65,-18,65,40);Line(-62,40,65,40);              Line(-72,-18,15,-66);Line(15,-66,75,-18);Line(15,-55,15,40);Line(30,40,30,2);Line(30,2,49,2);Line(49,2,49,40);              for(int i=0;i<3;i++){ float x=-46+i*19;Line(x,-5,x,16);Line(x,-5,x+10,-5);Line(x+10,-5,x+10,16);Line(x,16,x+10,16); }          }          else if (Category.Contains("车") || Category.Contains("交通"))          {              DrawPolyline([P(-72,28),P(-65,-4),P(-30,-12),P(-12,-38),P(32,-38),P(56,-7),P(76,2),P(76,28),P(-72,28)],ink,2*scale,true);              Line(-30,-12,56,-7);Line(10,-38,10,-10);DrawCircle(P(-42,30),14*scale,teal);DrawCircle(P(45,30),14*scale,teal);          }          else if (Category.Contains("艇") || Category.Contains("航") || Category.Contains("游"))          {              DrawPolyline([P(-75,18),P(70,18),P(40,47),P(-48,47),P(-75,18)],ink,2*scale,true);              DrawPolyline([P(-35,18),P(-25,-17),P(28,-17),P(42,18)],ink,2*scale,true);Line(-10,-17,-10,-46);Line(-10,-46,30,-32);Line(30,-32,-10,-22);              for(int i=0;i<3;i++)Line(-48+i*37,63,-25+i*37,63,teal);          }          else if (Category.Contains("数码") || Category.Contains("设备") || Category.Contains("运营"))          {              DrawPolyline([P(-62,-42),P(62,-42),P(62,24),P(-62,24),P(-62,-42)],ink,2*scale,true);Line(0,24,0,45);Line(-30,45,30,45);              DrawPolyline([P(-43,8),P(-22,-12),P(-2,-1),P(20,-30),P(42,-20)],CareerVisuals.Teal,3*scale,true);          }          else          {              DrawPolyline([P(-42,-30),P(34,-30),P(29,35),P(-35,35),P(-42,-30)],ink,2*scale,true);              DrawArc(P(34,-8),20*scale,-1.5f,1.5f,20,ink,2*scale,true);Line(-52,46,51,46);Line(-20,-49,-14,-67,teal);Line(8,-47,14,-65,teal);          }`
- `string.Contains(string)`；输入表达式：`Category.Contains("艇")`；返回值紧邻使用处：`BinaryExpressionSyntax: Category.Contains("艇") || Category.Contains("航")`
- `string.Contains(string)`；输入表达式：`Category.Contains("游")`；返回值紧邻使用处：`BinaryExpressionSyntax: Category.Contains("艇") || Category.Contains("航") || Category.Contains("游")`
- `string.Contains(string)`；输入表达式：`Category.Contains("运营")`；返回值紧邻使用处：`BinaryExpressionSyntax: Category.Contains("数码") || Category.Contains("设备") || Category.Contains("运营")`
- `string.Contains(string)`；输入表达式：`Category.Contains("珠宝")`；返回值紧邻使用处：`BinaryExpressionSyntax: Category.Contains("穿戴") || Category.Contains("珠宝")`
- `string.Contains(string)`；输入表达式：`Category.Contains("住宅")`；返回值紧邻使用处：`BinaryExpressionSyntax: Category.Contains("房") || Category.Contains("住宅")`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(Size.X, Size.Y)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Min(Size.X, Size.Y) / 200`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e50dcf6d6a45"></a>

## `P(float, float) — Vector2 P(float x, float y)`

来源：源码第 43 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Line(float, float, float, float, Godot.Color?)`](LifestyleArt.cs.md#symbol-c3cb30fce98c)；[`NationalSpire.LifestyleArt._Draw()`](LifestyleArt.cs.md#symbol-8b1cbb5282e0)

**调用：** `Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(x, y)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(x, y) * scale`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c3cb30fce98c"></a>

## `Line(float, float, float, float, Godot.Color?) — void Line(float x, float y, float xx, float yy, Color? c = null)`

来源：源码第 45 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LifestyleArt._Draw()`](LifestyleArt.cs.md#symbol-8b1cbb5282e0)

**调用：** [`P(float, float)`](LifestyleArt.cs.md#symbol-e50dcf6d6a45)；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`

**字段、属性、事件及方法组引用：** `P(float, float)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(P(x,y),P(xx,yy),c ?? ink,2*scale,true)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => DrawLine(P(x,y),P(xx,yy),c ?? ink,2*scale,true)`
- `P(float, float)`；输入表达式：`P(x,y)`；返回值紧邻使用处：`ArgumentSyntax: P(x,y)`
- `P(float, float)`；输入表达式：`P(xx,yy)`；返回值紧邻使用处：`ArgumentSyntax: P(xx,yy)`

**赋值（含属性/字段和局部值）：**
