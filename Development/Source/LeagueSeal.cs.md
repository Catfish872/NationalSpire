# LeagueSeal.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`0BFA7AC739BF8DEC6CFE8B1C71FAE483F0D134D7F65BE5D8D7839C1D98CD76AD`。来源：[源码](../../LeagueSeal.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.LeagueSeal`。

字段、事件及初始值（源码原样）：

```csharp
public Color Ink=new("e5bf7a");
private float _age;
public bool Burst;
```

<a id="symbol-e0071b6c696e"></a>

## `NationalSpire.LeagueSeal._Process(double) — public override void _Process(double delta)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.QueueRedraw()`；`Godot.Node.QueueFree()`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueSeal._age`；`NationalSpire.LeagueSeal.Burst`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueRedraw();`
- `Godot.Node.QueueFree()`；输入表达式：`QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueFree();`

**赋值（含属性/字段和局部值）：**

- `_age` += `(float)delta`

<a id="symbol-39f09858288d"></a>

## `NationalSpire.LeagueSeal._Draw() — public override void _Draw()`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawPolyline(Godot.Vector2[], Godot.Color, float, bool)`；`Godot.Color.Color(Godot.Color, float)`；`Godot.Color.Color(string)`；`Godot.Mathf.Ease(float, float)`；`Godot.Mathf.Sqrt(float)`；`Godot.Vector2.Rotated(float)`；`Godot.Vector2.Vector2(float, float)`；`System.Math.Clamp(float, float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueSeal._age`；`NationalSpire.LeagueSeal.Burst`；`NationalSpire.LeagueSeal.Ink`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(edge,72,side==1?-Mathf.Pi/2:Mathf.Pi/2,side==1?Mathf.Pi/2:3*Mathf.Pi/2,44,Ink,2,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(edge,72,side==1?-Mathf.Pi/2:Mathf.Pi/2,side==1?Mathf.Pi/2:3*Mathf.Pi/2,44,Ink,2,true);`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon(points,new Color(side==1?"2e3238":"26343d"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon(points,new Color(side==1?"2e3238":"26343d"));`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(edge+new Vector2(side*12,-135+i*3),edge+new Vector2(side*122,-135+i*3),new Color(Ink,.45f),1)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(edge+new Vector2(side*12,-135+i*3),edge+new Vector2(side*122,-135+i*3),new Color(Ink,.45f),1);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(pos-dir*(3+8*(1-light)),pos+dir*2,glow,1+(i%2),true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(pos-dir*(3+8*(1-light)),pos+dir*2,glow,1+(i%2),true);`
- `Godot.CanvasItem.DrawPolyline(Godot.Vector2[], Godot.Color, float, bool)`；输入表达式：`DrawPolyline(points,Ink,2,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline(points,Ink,2,true);`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(Ink,.45f)`；返回值紧邻使用处：`ArgumentSyntax: new Color(Ink,.45f)`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(Ink,(1-light)*(.3f+.7f*(i%3)/2))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Color(Ink,(1-light)*(.3f+.7f*(i%3)/2))`
- `Godot.Color.Color(string)`；输入表达式：`new Color(side==1?"2e3238":"26343d")`；返回值紧邻使用处：`ArgumentSyntax: new Color(side==1?"2e3238":"26343d")`
- `Godot.Mathf.Ease(float, float)`；输入表达式：`Mathf.Ease(Math.Clamp((p-.48f)/.52f,0,1),2.2f)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Mathf.Ease(Math.Clamp((p-.48f)/.52f,0,1),2.2f)`
- `Godot.Mathf.Sqrt(float)`；输入表达式：`Mathf.Sqrt(light)`；返回值紧邻使用处：`BinaryExpressionSyntax: (Burst?140:270)*Mathf.Sqrt(light)`
- `Godot.Vector2.Rotated(float)`；输入表达式：`Vector2.Right.Rotated(angle)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Vector2.Right.Rotated(angle)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-side*5,15)`；返回值紧邻使用处：`BinaryExpressionSyntax: edge+new Vector2(-side*5,15)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0,-h)`；返回值紧邻使用处：`BinaryExpressionSyntax: edge+new Vector2(0,-h)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0,h)`；返回值紧邻使用处：`BinaryExpressionSyntax: edge+new Vector2(0,h)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(side*12,-135+i*3)`；返回值紧邻使用处：`BinaryExpressionSyntax: edge+new Vector2(side*12,-135+i*3)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(side*122,-135+i*3)`；返回值紧邻使用处：`BinaryExpressionSyntax: edge+new Vector2(side*122,-135+i*3)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(side*6,-43)`；返回值紧邻使用处：`BinaryExpressionSyntax: edge+new Vector2(side*6,-43)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(side*split*Size.X*.65f,0)`；返回值紧邻使用处：`BinaryExpressionSyntax: mid+new Vector2(side*split*Size.X*.65f,0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(side*w,-h)`；返回值紧邻使用处：`BinaryExpressionSyntax: edge+new Vector2(side*w,-h)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(side*w,h)`；返回值紧邻使用处：`BinaryExpressionSyntax: edge+new Vector2(side*w,h)`
- `System.Math.Clamp(float, float, float)`；输入表达式：`Math.Clamp(_age/(Burst?1:.95f),0,1)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Math.Clamp(_age/(Burst?1:.95f),0,1)`
- `System.Math.Clamp(float, float, float)`；输入表达式：`Math.Clamp((p-.45f)*2,0,1)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Burst?p:Math.Clamp((p-.45f)*2,0,1)`
- `System.Math.Clamp(float, float, float)`；输入表达式：`Math.Clamp((p-.48f)/.52f,0,1)`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp((p-.48f)/.52f,0,1)`

**赋值（含属性/字段和局部值）：**

- `side` += `2`
