# LeagueCardFace.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`68F7B786B0AF1F6964BC4AC69D3C1A4055DAAB345883BDDE788DAA7D22BD56F3`。来源：[源码](../../LeagueCardFace.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.LeagueCardFace`。

字段、事件及初始值（源码原样）：

```csharp
private NCard? _face;
private Color _ink;
private int _grade;
private bool _lit;
private static Shader? _foil;
private static Shader? _edge;
```

<a id="symbol-dcb2c9c09a0f"></a>

## `NationalSpire.LeagueCardFace.Identity — internal (CardModel Model,bool Upgraded) Identity`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-5fdb1791bb4a"></a>

## `NationalSpire.LeagueCardFace.Detach() — internal NCard? Detach()`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.StoreFaces(Godot.Control)`](LeagueScreen.cs.md#symbol-65c1aeb6b0cb)

**调用：** `Godot.Node.IsNodeReady()`；`Godot.Node.RemoveChild(Godot.Node)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueCardFace._face`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.IsNodeReady()`；输入表达式：`face.IsNodeReady()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !face.IsNodeReady()`
- `Godot.Node.RemoveChild(Godot.Node)`；输入表达式：`RemoveChild(face)`；返回值紧邻使用处：`ExpressionStatementSyntax: RemoveChild(face);`

**赋值（含属性/字段和局部值）：**

- `_face` = `null`

<a id="symbol-2232c5fe9aae"></a>

## `NationalSpire.LeagueCardFace.Highlight(bool) — public void Highlight(bool lit)`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LeagueTile(NationalSpire.LeagueCards.Entry, out Godot.VBoxContainer, bool, System.Action?)`](LeagueScreen.cs.md#symbol-3fa69e107266)

**调用：** [`NationalSpire.LeagueCardFace.Arrange()`](LeagueCardFace.cs.md#symbol-14698b697826)；`Godot.CanvasItem.QueueRedraw()`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueCardFace._lit`；`NationalSpire.LeagueCardFace.Arrange()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueRedraw();`
- `NationalSpire.LeagueCardFace.Arrange()`；输入表达式：`Arrange()`；返回值紧邻使用处：`ExpressionStatementSyntax: Arrange();`

**赋值（含属性/字段和局部值）：**

- `_lit` = `lit`

<a id="symbol-2438fe5bd009"></a>

## `NationalSpire.LeagueCardFace._Draw() — public override void _Draw()`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`V(float, float)`](LeagueCardFace.cs.md#symbol-916fd1c69810)；`Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；`Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；`Godot.Color.Color(Godot.Color, float)`；`Godot.Color.Color(string)`；`Godot.Color.Lerp(Godot.Color, float)`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.Vector2.Vector2(float, float)`；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueCardFace._grade`；`NationalSpire.LeagueCardFace._ink`；`NationalSpire.LeagueCardFace._lit`；`V(float, float)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon([pt+Vector2.Up*2.5f,pt+Vector2.Right*2.5f,pt+Vector2.Down*2.5f,pt+Vector2.Left*2.5f],_ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon([pt+Vector2.Up*2.5f,pt+Vector2.Right*2.5f,pt+Vector2.Down*2.5f,pt+Vector2.Left*2.5f],_ink);`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon([V(1,k+15),V(1,k),V(k,1),V(k+15,1),V(k+4,4),V(4,k+4)],new Color(_ink,_lit?.95f:.66f))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon([V(1,k+15),V(1,k),V(k,1),V(k+15,1),V(k+4,4),V(4,k+4)],new Color(_ink,_lit?.95f:.66f));`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon(rim,new Color("19252c").Lerp(_ink,_lit?.19f:.075f))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon(rim,new Color("19252c").Lerp(_ink,_lit?.19f:.075f));`
- `Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；输入表达式：`DrawPolyline([..rim,rim[0]],new Color(_ink,_lit?.77f:.32f),1.4f,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline([..rim,rim[0]],new Color(_ink,_lit?.77f:.32f),1.4f,true);`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(_ink,_lit?.77f:.32f)`；返回值紧邻使用处：`ArgumentSyntax: new Color(_ink,_lit?.77f:.32f)`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(_ink,_lit?.95f:.66f)`；返回值紧邻使用处：`ArgumentSyntax: new Color(_ink,_lit?.95f:.66f)`
- `Godot.Color.Color(string)`；输入表达式：`new Color("19252c")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new Color("19252c").Lerp`
- `Godot.Color.Lerp(Godot.Color, float)`；输入表达式：`new Color("19252c").Lerp(_ink,_lit?.19f:.075f)`；返回值紧邻使用处：`ArgumentSyntax: new Color("19252c").Lerp(_ink,_lit?.19f:.075f)`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(c-new Vector2(w,h)*.5f,new(w,h))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Rect2(c-new Vector2(w,h)*.5f,new(w,h))`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(c.X+7*(i-_grade*.5f),ey-3)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Vector2(c.X+7*(i-_grade*.5f),ey-3)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(dx>0?x:ex,dy>0?y:ey)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Vector2(dx>0?x:ex,dy>0?y:ey)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(w,h)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(w,h)*.5f`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(ex-k,ey)`；返回值紧邻使用处：`ExpressionElementSyntax: new(ex-k,ey)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(ex-k,y)`；返回值紧邻使用处：`ExpressionElementSyntax: new(ex-k,y)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(ex,ey-k)`；返回值紧邻使用处：`ExpressionElementSyntax: new(ex,ey-k)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(ex,y+k)`；返回值紧邻使用处：`ExpressionElementSyntax: new(ex,y+k)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(w,h)`；返回值紧邻使用处：`ArgumentSyntax: new(w,h)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(x,ey-k)`；返回值紧邻使用处：`ExpressionElementSyntax: new(x,ey-k)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(x,y+k)`；返回值紧邻使用处：`ExpressionElementSyntax: new(x,y+k)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(x+k,ey)`；返回值紧邻使用处：`ExpressionElementSyntax: new(x+k,ey)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(x+k,y)`；返回值紧邻使用处：`ExpressionElementSyntax: new(x+k,y)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(15,w*.07f)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Math.Min(15,w*.07f)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(Size.X-12,h*.74f)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Math.Min(Size.X-12,h*.74f)`
- `V(float, float)`；输入表达式：`V(1,k)`；返回值紧邻使用处：`ExpressionElementSyntax: V(1,k)`
- `V(float, float)`；输入表达式：`V(1,k+15)`；返回值紧邻使用处：`ExpressionElementSyntax: V(1,k+15)`
- `V(float, float)`；输入表达式：`V(4,k+4)`；返回值紧邻使用处：`ExpressionElementSyntax: V(4,k+4)`
- `V(float, float)`；输入表达式：`V(k,1)`；返回值紧邻使用处：`ExpressionElementSyntax: V(k,1)`
- `V(float, float)`；输入表达式：`V(k+15,1)`；返回值紧邻使用处：`ExpressionElementSyntax: V(k+15,1)`
- `V(float, float)`；输入表达式：`V(k+4,4)`；返回值紧邻使用处：`ExpressionElementSyntax: V(k+4,4)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-916fd1c69810"></a>

## `V(float, float) — Vector2 V(float a,float b)`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueCardFace._Draw()`](LeagueCardFace.cs.md#symbol-2438fe5bd009)

**调用：** `Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(a*dx,b*dy)`；返回值紧邻使用处：`BinaryExpressionSyntax: o+new Vector2(a*dx,b*dy)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5eaf3fbab931"></a>

## `NationalSpire.LeagueCardFace.MountEdge(int, Godot.Color) — private void MountEdge(int grade,Color ink)`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueCardFace.ShowCard(MegaCrit.Sts2.Core.Models.CardModel, int, Godot.Color, bool, MegaCrit.Sts2.Core.Nodes.Cards.NCard?)`](LeagueCardFace.cs.md#symbol-50215c17339c)

**调用：** [`Place()`](LeagueCardFace.cs.md#symbol-d31c8fc7bfd3)；`Godot.ColorRect.ColorRect()`；`Godot.GodotObject.GetInstanceId()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Shader.Shader()`；`Godot.ShaderMaterial.SetShaderParameter(Godot.StringName, Godot.Variant)`；`Godot.ShaderMaterial.ShaderMaterial()`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueCardFace._edge`；`Place()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ColorRect.ColorRect()`；输入表达式：`new ColorRect{Material=mat,MouseFilter=MouseFilterEnum.Ignore}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new ColorRect{Material=mat,MouseFilter=MouseFilterEnum.Ignore}`
- `Godot.GodotObject.GetInstanceId()`；输入表达式：`GetInstanceId()`；返回值紧邻使用处：`BinaryExpressionSyntax: GetInstanceId()%127`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(light)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(light);`
- `Godot.Shader.Shader()`；输入表达式：`new Shader{Code=@"shader_type canvas_item;             uniform vec4 ink : source_color; uniform int grade; uniform float shift;             void fragment(){                 vec2 q=abs(UV-0.5);                 vec2 halfsize=vec2(0.5)-vec2(0.024,0.019);                 vec2 d=q-halfsize; float dist=max(max(d.x,d.y),(d.x+d.y+0.034)*0.707);                 float rim=1.0-smoothstep(0.0025,0.011,abs(dist));                 float bloom=(1.0-smoothstep(0.003,0.022,abs(dist)))*0.21;                 float a=atan(UV.y-0.5,UV.x-0.5)/6.283185;                 float track=cos(6.283185*(a-TIME*0.12+shift));                 float glint=smoothstep(0.50,0.98,track);                 if(grade>=2)glint=max(glint,0.70*smoothstep(0.80,0.99,-track));                 vec3 tint=grade==3?mix(ink.rgb,vec3(0.27,0.93,0.96),0.5+0.5*sin(a*6.283185+TIME*0.6)):ink.rgb;                 COLOR=vec4(mix(tint,vec3(1.0),0.48*glint),clamp((rim+bloom)*(0.10+0.055*float(grade)+glint*(0.45+0.12*float(grade))),0.0,0.94));}"}`；返回值紧邻使用处：`AssignmentExpressionSyntax: _edge??=new Shader{Code=@"shader_type canvas_item;             uniform vec4 ink : source_color; uniform int grade; uniform float shift;             void fragment(){                 vec2 q=abs(UV-0.5);                 vec2 halfsize=vec2(0.5)-vec2(0.024,0.019);                 vec2 d=q-halfsize; float dist=max(max(d.x,d.y),(d.x+d.y+0.034)*0.707);                 float rim=1.0-smoothstep(0.0025,0.011,abs(dist));                 float bloom=(1.0-smoothstep(0.003,0.022,abs(dist)))*0.21;                 float a=atan(UV.y-0.5,UV.x-0.5)/6.283185;                 float track=cos(6.283185*(a-TIME*0.12+shift));                 float glint=smoothstep(0.50,0.98,track);                 if(grade>=2)glint=max(glint,0.70*smoothstep(0.80,0.99,-track));                 vec3 tint=grade==3?mix(ink.rgb,vec3(0.27,0.93,0.96),0.5+0.5*sin(a*6.283185+TIME*0.6)):ink.rgb;                 COLOR=vec4(mix(tint,vec3(1.0),0.48*glint),clamp((rim+bloom)*(0.10+0.055*float(grade)+glint*(0.45+0.12*float(grade))),0.0,0.94));}"}`
- `Godot.ShaderMaterial.SetShaderParameter(Godot.StringName, Godot.Variant)`；输入表达式：`mat.SetShaderParameter("grade",grade)`；返回值紧邻使用处：`ExpressionStatementSyntax: mat.SetShaderParameter("grade",grade);`
- `Godot.ShaderMaterial.SetShaderParameter(Godot.StringName, Godot.Variant)`；输入表达式：`mat.SetShaderParameter("ink",ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: mat.SetShaderParameter("ink",ink);`
- `Godot.ShaderMaterial.SetShaderParameter(Godot.StringName, Godot.Variant)`；输入表达式：`mat.SetShaderParameter("shift",GetInstanceId()%127/127f)`；返回值紧邻使用处：`ExpressionStatementSyntax: mat.SetShaderParameter("shift",GetInstanceId()%127/127f);`
- `Godot.ShaderMaterial.ShaderMaterial()`；输入表达式：`new ShaderMaterial{Shader=_edge}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new ShaderMaterial{Shader=_edge}`
- `Place()`；输入表达式：`Place()`；返回值紧邻使用处：`ExpressionStatementSyntax: Place();`

**赋值（含属性/字段和局部值）：**

- `_edge` ??= `new Shader{Code=@"shader_type canvas_item;             uniform vec4 ink : source_color; uniform int grade; uniform float shift;             void fragment(){                 vec2 q=abs(UV-0.5);                 vec2 halfsize=vec2(0.5)-vec2(0.024,0.019);                 vec2 d=q-halfsize; float dist=max(max(d.x,d.y),(d.x+d.y+0.034)*0.707);                 float rim=1.0-smoothstep(0.0025,0.011,abs(dist));                 float bloom=(1.0-smoothstep(0.003,0.022,abs(dist)))*0.21;                 float a=atan(UV.y-0.5,UV.x-0.5)/6.283185;                 float track=cos(6.283185*(a-TIME*0.12+shift));                 float glint=smoothstep(0.50,0.98,track);                 if(grade>=2)glint=max(glint,0.70*smoothstep(0.80,0.99,-track));                 vec3 tint=grade==3?mix(ink.rgb,vec3(0.27,0.93,0.96),0.5+0.5*sin(a*6.283185+TIME*0.6)):ink.rgb;                 COLOR=vec4(mix(tint,vec3(1.0),0.48*glint),clamp((rim+bloom)*(0.10+0.055*float(grade)+glint*(0.45+0.12*float(grade))),0.0,0.94));}"}`
- `Code` = `@"shader_type canvas_item;             uniform vec4 ink : source_color; uniform int grade; uniform float shift;             void fragment(){                 vec2 q=abs(UV-0.5);                 vec2 halfsize=vec2(0.5)-vec2(0.024,0.019);                 vec2 d=q-halfsize; float dist=max(max(d.x,d.y),(d.x+d.y+0.034)*0.707);                 float rim=1.0-smoothstep(0.0025,0.011,abs(dist));                 float bloom=(1.0-smoothstep(0.003,0.022,abs(dist)))*0.21;                 float a=atan(UV.y-0.5,UV.x-0.5)/6.283185;                 float track=cos(6.283185*(a-TIME*0.12+shift));                 float glint=smoothstep(0.50,0.98,track);                 if(grade>=2)glint=max(glint,0.70*smoothstep(0.80,0.99,-track));                 vec3 tint=grade==3?mix(ink.rgb,vec3(0.27,0.93,0.96),0.5+0.5*sin(a*6.283185+TIME*0.6)):ink.rgb;                 COLOR=vec4(mix(tint,vec3(1.0),0.48*glint),clamp((rim+bloom)*(0.10+0.055*float(grade)+glint*(0.45+0.12*float(grade))),0.0,0.94));}"`
- `Material` = `mat`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Resized` += `Place`
- `Shader` = `_edge`

<a id="symbol-d31c8fc7bfd3"></a>

## `Place() — void Place()`

来源：源码第 49 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueCardFace.MountEdge(int, Godot.Color)`](LeagueCardFace.cs.md#symbol-5eaf3fbab931)

**调用：** `Godot.Vector2.Vector2(float, float)`；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(w,h)`；返回值紧邻使用处：`AssignmentExpressionSyntax: light.Size=new(w,h)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(Size.X-12,h*.74f)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Math.Min(Size.X-12,h*.74f)`

**赋值（含属性/字段和局部值）：**

- `light.Position` = `(Size-light.Size)*.5f`
- `light.Size` = `new(w,h)`

<a id="symbol-50215c17339c"></a>

## `NationalSpire.LeagueCardFace.ShowCard(MegaCrit.Sts2.Core.Models.CardModel, int, Godot.Color, bool, MegaCrit.Sts2.Core.Nodes.Cards.NCard?) — public void ShowCard(CardModel model,int grade,Color tint,bool upgraded=false,NCard? reuse=null)`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DeckMotion(string, string, Godot.Vector2, int)`](LeagueDeckEditor.cs.md#symbol-669631bd65bf)；[`NationalSpire.CareerScreen.DeckSmith(NationalSpire.LeagueCards.Entry)`](LeagueDeckEditor.cs.md#symbol-92429c805c31)；[`NationalSpire.CareerScreen.DeckSwap(NationalSpire.LeagueCards.Entry, Godot.Control)`](LeagueDeckEditor.cs.md#symbol-19b872317e2a)；[`NationalSpire.CareerScreen.LeagueInspect(NationalSpire.LeagueCards.Entry, bool)`](LeagueScreen.cs.md#symbol-69ed9740453e)；[`NationalSpire.CareerScreen.LeagueTile(NationalSpire.LeagueCards.Entry, out Godot.VBoxContainer, bool, System.Action?)`](LeagueScreen.cs.md#symbol-3fa69e107266)

**调用：** [`NationalSpire.LeagueCardFace.Arrange()`](LeagueCardFace.cs.md#symbol-14698b697826)；[`NationalSpire.LeagueCardFace.Finish(MegaCrit.Sts2.Core.Models.CardModel, int, Godot.Color)`](LeagueCardFace.cs.md#symbol-446ddd0974c9)；[`NationalSpire.LeagueCardFace.MountEdge(int, Godot.Color)`](LeagueCardFace.cs.md#symbol-5eaf3fbab931)；[`NationalSpire.LeagueCards.Improve(MegaCrit.Sts2.Core.Models.CardModel)`](LeagueCards.cs.md#symbol-f7cfc6d3c1a6)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PackedScene.Instantiate<T>(Godot.PackedScene.GenEditState)`；`Godot.ResourceLoader.Load<T>(string, string, Godot.ResourceLoader.CacheMode)`；`Godot.Vector2.Vector2(float, float)`；`MegaCrit.Sts2.Core.Models.CardModel.ToMutable()`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueCardFace._face`；`NationalSpire.LeagueCardFace._grade`；`NationalSpire.LeagueCardFace._ink`；`NationalSpire.LeagueCardFace.Arrange()`；`NationalSpire.LeagueCardFace.Finish(MegaCrit.Sts2.Core.Models.CardModel, int, Godot.Color)`；`NationalSpire.LeagueCardFace.Identity`；`NationalSpire.LeagueCardFace.MountEdge(int, Godot.Color)`；`NationalSpire.LeagueCards.Improve(MegaCrit.Sts2.Core.Models.CardModel)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(_face)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(_face);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(reuse)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(reuse);`
- `Godot.PackedScene.Instantiate<T>(Godot.PackedScene.GenEditState)`；输入表达式：`ResourceLoader.Load<PackedScene>("res://scenes/cards/card.tscn").Instantiate<NCard>()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _face=ResourceLoader.Load<PackedScene>("res://scenes/cards/card.tscn").Instantiate<NCard>()`
- `Godot.ResourceLoader.Load<T>(string, string, Godot.ResourceLoader.CacheMode)`；输入表达式：`ResourceLoader.Load<PackedScene>("res://scenes/cards/card.tscn")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ResourceLoader.Load<PackedScene>("res://scenes/cards/card.tscn").Instantiate<NCard>`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(180,272)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(180,272)`
- `MegaCrit.Sts2.Core.Models.CardModel.ToMutable()`；输入表达式：`model.ToMutable()`；返回值紧邻使用处：`ConditionalExpressionSyntax: model.IsMutable?model:model.ToMutable()`
- `NationalSpire.LeagueCardFace.Arrange()`；输入表达式：`Arrange()`；返回值紧邻使用处：`ExpressionStatementSyntax: Arrange();`
- `NationalSpire.LeagueCardFace.Finish(MegaCrit.Sts2.Core.Models.CardModel, int, Godot.Color)`；输入表达式：`Finish(model,grade,tint)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>Finish(model,grade,tint)`
- `NationalSpire.LeagueCardFace.MountEdge(int, Godot.Color)`；输入表达式：`MountEdge(grade,tint)`；返回值紧邻使用处：`ExpressionStatementSyntax: MountEdge(grade,tint);`
- `NationalSpire.LeagueCards.Improve(MegaCrit.Sts2.Core.Models.CardModel)`；输入表达式：`LeagueCards.Improve(copy)`；返回值紧邻使用处：`ConditionalExpressionSyntax: upgraded?LeagueCards.Improve(copy):copy`

**赋值（含属性/字段和局部值）：**

- `_face.Model` = `upgraded?LeagueCards.Improve(copy):copy`
- `_face.Ready` += `()=>Finish(model,grade,tint)`
- `_face` = `ResourceLoader.Load<PackedScene>("res://scenes/cards/card.tscn").Instantiate<NCard>()`
- `_face` = `reuse`
- `_grade` = `grade`
- `_ink` = `tint`
- `CustomMinimumSize` = `new(180,272)`
- `Identity` = `(model,upgraded)`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Resized` += `Arrange`

<a id="symbol-446ddd0974c9"></a>

## `NationalSpire.LeagueCardFace.Finish(MegaCrit.Sts2.Core.Models.CardModel, int, Godot.Color) — private void Finish(CardModel model,int grade,Color tint)`

来源：源码第 61 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueCardFace.ShowCard(MegaCrit.Sts2.Core.Models.CardModel, int, Godot.Color, bool, MegaCrit.Sts2.Core.Nodes.Cards.NCard?)`](LeagueCardFace.cs.md#symbol-50215c17339c)

**调用：** `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetNode<T>(Godot.NodePath)`；`Godot.ResourceLoader.Exists(string, string)`；`Godot.ResourceLoader.Load<T>(string, string, Godot.ResourceLoader.CacheMode)`；`Godot.Shader.Shader()`；`Godot.ShaderMaterial.SetShaderParameter(Godot.StringName, Godot.Variant)`；`Godot.ShaderMaterial.ShaderMaterial()`；`Godot.TextureRect.TextureRect()`；`MegaCrit.Sts2.Core.Nodes.Cards.NCard.UpdateVisuals(MegaCrit.Sts2.Core.Entities.Cards.PileType, MegaCrit.Sts2.Core.Entities.Cards.CardPreviewMode)`；`string.ToLowerInvariant()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueCardFace._face`；`NationalSpire.LeagueCardFace._foil`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`overlay.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: overlay.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`source.AddChild(overlay)`；返回值紧邻使用处：`ExpressionStatementSyntax: source.AddChild(overlay);`
- `Godot.Node.GetNode<T>(Godot.NodePath)`；输入表达式：`_face.GetNode<TextureRect>(grade==3?"%AncientBorder":"%Frame")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =_face.GetNode<TextureRect>(grade==3?"%AncientBorder":"%Frame")`
- `Godot.Node.GetNode<T>(Godot.NodePath)`；输入表达式：`_face.GetNode<TextureRect>(grade==3?"%AncientPortrait":"%Portrait")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _face.GetNode<TextureRect>(grade==3?"%AncientPortrait":"%Portrait").Texture`
- `Godot.ResourceLoader.Exists(string, string)`；输入表达式：`ResourceLoader.Exists(model.PortraitPath)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ResourceLoader.Exists(model.PortraitPath)`
- `Godot.ResourceLoader.Exists(string, string)`；输入表达式：`ResourceLoader.Exists(p)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p=>ResourceLoader.Exists(p)`
- `Godot.ResourceLoader.Load<T>(string, string, Godot.ResourceLoader.CacheMode)`；输入表达式：`ResourceLoader.Load<Texture2D>(path)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _face.GetNode<TextureRect>(grade==3?"%AncientPortrait":"%Portrait").Texture=ResourceLoader.Load<Texture2D>(path)`
- `Godot.Shader.Shader()`；输入表达式：`new Shader{Code=@"shader_type canvas_item;             uniform vec4 ink : source_color;             uniform float intensity;             uniform int grade;             void fragment(){vec4 frame=texture(TEXTURE,UV);             float metal=dot(frame.rgb,vec3(0.25,0.58,0.17));             float bevel=pow(abs(UV.x*2.0-1.0),3.0);             float satin=0.08+0.15*metal+0.09*bevel;             float phase=fract(UV.x*0.38+UV.y*0.66-TIME*(0.11+float(grade)*0.008)+float(grade)*0.21);             float gleam=1.0-smoothstep(0.035,0.20,abs(phase-0.42));             vec3 hue=ink.rgb;             if(grade>=2) gleam+=0.45*(1.0-smoothstep(0.01,0.036,abs(phase-0.56)));             if(grade==3) hue=mix(hue,vec3(0.43,0.84,0.87),0.5+0.4*sin(6.28*(UV.y+phase)));             COLOR=vec4(mix(hue,vec3(0.96,0.91,0.82),clamp(metal*0.30+gleam*0.65,0.0,0.88)),frame.a*(satin*intensity+gleam*(0.32+0.105*float(grade))));}"}`；返回值紧邻使用处：`AssignmentExpressionSyntax: _foil??=new Shader{Code=@"shader_type canvas_item;             uniform vec4 ink : source_color;             uniform float intensity;             uniform int grade;             void fragment(){vec4 frame=texture(TEXTURE,UV);             float metal=dot(frame.rgb,vec3(0.25,0.58,0.17));             float bevel=pow(abs(UV.x*2.0-1.0),3.0);             float satin=0.08+0.15*metal+0.09*bevel;             float phase=fract(UV.x*0.38+UV.y*0.66-TIME*(0.11+float(grade)*0.008)+float(grade)*0.21);             float gleam=1.0-smoothstep(0.035,0.20,abs(phase-0.42));             vec3 hue=ink.rgb;             if(grade>=2) gleam+=0.45*(1.0-smoothstep(0.01,0.036,abs(phase-0.56)));             if(grade==3) hue=mix(hue,vec3(0.43,0.84,0.87),0.5+0.4*sin(6.28*(UV.y+phase)));             COLOR=vec4(mix(hue,vec3(0.96,0.91,0.82),clamp(metal*0.30+gleam*0.65,0.0,0.88)),frame.a*(satin*intensity+gleam*(0.32+0.105*float(grade))));}"}`
- `Godot.ShaderMaterial.SetShaderParameter(Godot.StringName, Godot.Variant)`；输入表达式：`material.SetShaderParameter("grade",grade)`；返回值紧邻使用处：`ExpressionStatementSyntax: material.SetShaderParameter("grade",grade);`
- `Godot.ShaderMaterial.SetShaderParameter(Godot.StringName, Godot.Variant)`；输入表达式：`material.SetShaderParameter("ink",tint)`；返回值紧邻使用处：`ExpressionStatementSyntax: material.SetShaderParameter("ink",tint);`
- `Godot.ShaderMaterial.SetShaderParameter(Godot.StringName, Godot.Variant)`；输入表达式：`material.SetShaderParameter("intensity",.5f+.17f*grade)`；返回值紧邻使用处：`ExpressionStatementSyntax: material.SetShaderParameter("intensity",.5f+.17f*grade);`
- `Godot.ShaderMaterial.ShaderMaterial()`；输入表达式：`new ShaderMaterial{Shader=_foil}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new ShaderMaterial{Shader=_foil}`
- `Godot.TextureRect.TextureRect()`；输入表达式：`new TextureRect{Texture=source.Texture,ExpandMode=source.ExpandMode,StretchMode=source.StretchMode,MouseFilter=MouseFilterEnum.Ignore}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new TextureRect{Texture=source.Texture,ExpandMode=source.ExpandMode,StretchMode=source.StretchMode,MouseFilter=MouseFilterEnum.Ignore}`
- `MegaCrit.Sts2.Core.Nodes.Cards.NCard.UpdateVisuals(MegaCrit.Sts2.Core.Entities.Cards.PileType, MegaCrit.Sts2.Core.Entities.Cards.CardPreviewMode)`；输入表达式：`_face.UpdateVisuals(PileType.None,CardPreviewMode.Normal)`；返回值紧邻使用处：`ExpressionStatementSyntax: _face.UpdateVisuals(PileType.None,CardPreviewMode.Normal);`
- `string.ToLowerInvariant()`；输入表达式：`model.Id.Entry.ToLowerInvariant()`；返回值紧邻使用处：`InterpolationSyntax: {model.Id.Entry.ToLowerInvariant()}`
- `string.ToLowerInvariant()`；输入表达式：`model.Pool.Title.ToLowerInvariant()`；返回值紧邻使用处：`InterpolationSyntax: {model.Pool.Title.ToLowerInvariant()}`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`new[]{model.BetaPortraitPath,$"res://images/packed/card_portraits/{model.Pool.Title.ToLowerInvariant()}/{model.Id.Entry.ToLowerInvariant()}.png",CardModel.MissingPortraitPath}.FirstOrDefault(p=>ResourceLoader.Exists(p))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new[]{model.BetaPortraitPath,$"res://images/packed/card_portraits/{model.Pool.Title.ToLowerInvariant()}/{model.Id.Entry.ToLowerInvariant()}.png",CardModel.MissingPortraitPath}.FirstOrDefault(p=>ResourceLoader.Exists(p))`

**赋值（含属性/字段和局部值）：**

- `_face.GetNode<TextureRect>(grade==3?"%AncientPortrait":"%Portrait").Texture` = `ResourceLoader.Load<Texture2D>(path)`
- `_foil` ??= `new Shader{Code=@"shader_type canvas_item;             uniform vec4 ink : source_color;             uniform float intensity;             uniform int grade;             void fragment(){vec4 frame=texture(TEXTURE,UV);             float metal=dot(frame.rgb,vec3(0.25,0.58,0.17));             float bevel=pow(abs(UV.x*2.0-1.0),3.0);             float satin=0.08+0.15*metal+0.09*bevel;             float phase=fract(UV.x*0.38+UV.y*0.66-TIME*(0.11+float(grade)*0.008)+float(grade)*0.21);             float gleam=1.0-smoothstep(0.035,0.20,abs(phase-0.42));             vec3 hue=ink.rgb;             if(grade>=2) gleam+=0.45*(1.0-smoothstep(0.01,0.036,abs(phase-0.56)));             if(grade==3) hue=mix(hue,vec3(0.43,0.84,0.87),0.5+0.4*sin(6.28*(UV.y+phase)));             COLOR=vec4(mix(hue,vec3(0.96,0.91,0.82),clamp(metal*0.30+gleam*0.65,0.0,0.88)),frame.a*(satin*intensity+gleam*(0.32+0.105*float(grade))));}"}`
- `Code` = `@"shader_type canvas_item;             uniform vec4 ink : source_color;             uniform float intensity;             uniform int grade;             void fragment(){vec4 frame=texture(TEXTURE,UV);             float metal=dot(frame.rgb,vec3(0.25,0.58,0.17));             float bevel=pow(abs(UV.x*2.0-1.0),3.0);             float satin=0.08+0.15*metal+0.09*bevel;             float phase=fract(UV.x*0.38+UV.y*0.66-TIME*(0.11+float(grade)*0.008)+float(grade)*0.21);             float gleam=1.0-smoothstep(0.035,0.20,abs(phase-0.42));             vec3 hue=ink.rgb;             if(grade>=2) gleam+=0.45*(1.0-smoothstep(0.01,0.036,abs(phase-0.56)));             if(grade==3) hue=mix(hue,vec3(0.43,0.84,0.87),0.5+0.4*sin(6.28*(UV.y+phase)));             COLOR=vec4(mix(hue,vec3(0.96,0.91,0.82),clamp(metal*0.30+gleam*0.65,0.0,0.88)),frame.a*(satin*intensity+gleam*(0.32+0.105*float(grade))));}"`
- `ExpandMode` = `source.ExpandMode`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `overlay.Material` = `material`
- `Shader` = `_foil`
- `StretchMode` = `source.StretchMode`
- `Texture` = `source.Texture`

<a id="symbol-14698b697826"></a>

## `NationalSpire.LeagueCardFace.Arrange() — private void Arrange()`

来源：源码第 87 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueCardFace.Highlight(bool)`](LeagueCardFace.cs.md#symbol-2232c5fe9aae)；[`NationalSpire.LeagueCardFace.ShowCard(MegaCrit.Sts2.Core.Models.CardModel, int, Godot.Color, bool, MegaCrit.Sts2.Core.Nodes.Cards.NCard?)`](LeagueCardFace.cs.md#symbol-50215c17339c)

**调用：** `System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueCardFace._face`；`NationalSpire.LeagueCardFace._lit`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Min(float, float)`；输入表达式：`Math.Min((Size.X-24)/300f,(Size.Y-22)/422f)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Min((Size.X-24)/300f,(Size.Y-22)/422f)*(_lit?1.027f:1f)`

**赋值（含属性/字段和局部值）：**

- `_face.Position` = `Size*.5f`
- `_face.Scale` = `Vector2.One*scale`
