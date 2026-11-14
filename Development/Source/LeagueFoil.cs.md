# LeagueFoil.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`C5A0A5B24AE4076EE80E7F0E897B9735189A752DC8D264E46A5D337EF0E4995E`。来源：[源码](../../LeagueFoil.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.LeagueFoil`。

字段、事件及初始值（源码原样）：

```csharp
public Color Ink=new("dfbc79");
public bool Wide;
```

<a id="symbol-f0e40c526c49"></a>

## `NationalSpire.LeagueFoil._Draw() — public override void _Draw()`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawPolyline(Godot.Vector2[], Godot.Color, float, bool)`；`Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；`Godot.Color.Color(Godot.Color, float)`；`Godot.Color.Color(string)`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.Vector2.Rotated(float)`；`Godot.Vector2.Vector2(float, float)`；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueFoil.Ink`；`NationalSpire.LeagueFoil.Wide`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(center,r*(.52f+i*.15f),0,Mathf.Tau,100,new Color(Ink,i==2?.58f:.22f),i==2?1.7f:1f,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(center,r*(.52f+i*.15f),0,Mathf.Tau,100,new Color(Ink,i==2?.58f:.22f),i==2?1.7f:1f,true);`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon(peak,new Color("34444b"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon(peak,new Color("34444b"));`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(center+dir*r*.88f,center+dir*r*(i%5==0?1.02f:.94f),new Color(Ink,.56f),1,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(center+dir*r*.88f,center+dir*r*(i%5==0?1.02f:.94f),new Color(Ink,.56f),1,true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(new(x-sz.Y*.32f,sz.Y), new(x,0),new Color(Ink,.045f),1,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(new(x-sz.Y*.32f,sz.Y), new(x,0),new Color(Ink,.045f),1,true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(p,p+new Vector2(0,i<2?13:-13),Ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(p,p+new Vector2(0,i<2?13:-13),Ink);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(p,p+new Vector2(i%2==0?17:-17,0),Ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(p,p+new Vector2(i%2==0?17:-17,0),Ink);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(peak[0],peak[^1],Ink,2,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(peak[0],peak[^1],Ink,2,true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(peak[2],center+new Vector2(.04f,.36f)*r,Ink,1,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(peak[2],center+new Vector2(.04f,.36f)*r,Ink,1,true);`
- `Godot.CanvasItem.DrawPolyline(Godot.Vector2[], Godot.Color, float, bool)`；输入表达式：`DrawPolyline(peak,Ink,2,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline(peak,Ink,2,true);`
- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；输入表达式：`DrawRect(new(Vector2.Zero,sz),new Color("101d2b"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawRect(new(Vector2.Zero,sz),new Color("101d2b"));`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(Ink,.045f)`；返回值紧邻使用处：`ArgumentSyntax: new Color(Ink,.045f)`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(Ink,.56f)`；返回值紧邻使用处：`ArgumentSyntax: new Color(Ink,.56f)`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(Ink,i==2?.58f:.22f)`；返回值紧邻使用处：`ArgumentSyntax: new Color(Ink,i==2?.58f:.22f)`
- `Godot.Color.Color(string)`；输入表达式：`new Color("101d2b")`；返回值紧邻使用处：`ArgumentSyntax: new Color("101d2b")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("34444b")`；返回值紧邻使用处：`ArgumentSyntax: new Color("34444b")`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new(Vector2.Zero,sz)`；返回值紧邻使用处：`ArgumentSyntax: new(Vector2.Zero,sz)`
- `Godot.Vector2.Rotated(float)`；输入表达式：`Vector2.Up.Rotated(i*Mathf.Tau/40)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Vector2.Up.Rotated(i*Mathf.Tau/40)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-.13f,-.04f)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(-.13f,-.04f)*r`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-.48f,.39f)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(-.48f,.39f)*r`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(.04f,.36f)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(.04f,.36f)*r`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(.16f,-.21f)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(.16f,-.21f)*r`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(.48f,.39f)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(.48f,.39f)*r`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2((i%2==0?14:sz.X-14),(i<2?14:sz.Y-14))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Vector2((i%2==0?14:sz.X-14),(i<2?14:sz.Y-14))`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0,-.62f)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(0,-.62f)*r`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0,i<2?13:-13)`；返回值紧邻使用处：`BinaryExpressionSyntax: p+new Vector2(0,i<2?13:-13)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(i%2==0?17:-17,0)`；返回值紧邻使用处：`BinaryExpressionSyntax: p+new Vector2(i%2==0?17:-17,0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(sz.X*.77f,sz.Y*.51f)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Wide?new Vector2(sz.X*.77f,sz.Y*.51f):sz*.5f`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(x-sz.Y*.32f,sz.Y)`；返回值紧邻使用处：`ArgumentSyntax: new(x-sz.Y*.32f,sz.Y)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(x,0)`；返回值紧邻使用处：`ArgumentSyntax: new(x,0)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(sz.X*.42f,sz.Y*.34f)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Wide?Math.Min(sz.Y*.43f,sz.X*.25f):Math.Min(sz.X*.42f,sz.Y*.34f)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(sz.Y*.43f,sz.X*.25f)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Wide?Math.Min(sz.Y*.43f,sz.X*.25f):Math.Min(sz.X*.42f,sz.Y*.34f)`

**赋值（含属性/字段和局部值）：**
