# LeagueDeckEditor.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`AE82DFC5AC695BE7BE52F1DA82C2C8F34541092CA2CAB03C270FB54FEE33C5D3`。来源：[源码](../../LeagueDeckEditor.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`、`NationalSpire.LeagueDeckStrip`。

字段、事件及初始值（源码原样）：

```csharp
private string _deckQuery="";
private int _deckOffset;
private ScrollContainer? _deckStrip;
private readonly Dictionary<string,Control> _deckSlots=[],_deckShelf=[];
private static readonly Dictionary<string,Texture2D> DeckIcons=[];
```

<a id="symbol-01b82580d5ea"></a>

## `NationalSpire.CareerScreen.DeckIcon(string) — private static Texture2D DeckIcon(string action)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DeckEditor(NationalSpire.CareerData, System.Collections.Generic.Dictionary<string, int>)`](LeagueDeckEditor.cs.md#symbol-825b0bb2327f)；[`NationalSpire.CareerScreen.DeckKey(string, string, string, System.Action, bool)`](LeagueDeckEditor.cs.md#symbol-947b5653f588)

**调用：** `Godot.Image.Image()`；`Godot.Image.LoadSvgFromString(string, float)`；`Godot.ImageTexture.CreateFromImage(Godot.Image)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.DeckIcons`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Image.Image()`；输入表达式：`new Image()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Image()`
- `Godot.Image.LoadSvgFromString(string, float)`；输入表达式：`im.LoadSvgFromString("<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='28' height='28' color='white' fill='none' stroke='white' stroke-linecap='round' stroke-linejoin='round' stroke-width='1.8'>"+paths+"</svg>")`；返回值紧邻使用处：`ExpressionStatementSyntax: im.LoadSvgFromString("<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='28' height='28' color='white' fill='none' stroke='white' stroke-linecap='round' stroke-linejoin='round' stroke-width='1.8'>"+paths+"</svg>");`
- `Godot.ImageTexture.CreateFromImage(Godot.Image)`；输入表达式：`ImageTexture.CreateFromImage(im)`；返回值紧邻使用处：`AssignmentExpressionSyntax: DeckIcons[action]=ImageTexture.CreateFromImage(im)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`DeckIcons.TryGetValue(action,out var icon)`；返回值紧邻使用处：`IfStatementSyntax: if(DeckIcons.TryGetValue(action,out var icon))return icon;`

**赋值（含属性/字段和局部值）：**

- `DeckIcons[action]` = `ImageTexture.CreateFromImage(im)`

<a id="symbol-19b872317e2a"></a>

## `NationalSpire.CareerScreen.DeckSwap(NationalSpire.LeagueCards.Entry, Godot.Control) — private void DeckSwap(LeagueCards.Entry next,Control origin)`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LeagueGrid(System.Collections.Generic.IEnumerable<NationalSpire.LeagueCards.Entry>, NationalSpire.CareerData, string, Godot.Control?)`](LeagueScreen.cs.md#symbol-315dac8c42bd)

**调用：** [`NationalSpire.CareerScreen.LeagueAction(string, string, int, Godot.Control?)`](LeagueScreen.cs.md#symbol-c5858ab8fb69)；[`NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`](LeaguePresentation.cs.md#symbol-3412750f7453)；[`NationalSpire.CareerScreen.LeagueNumber(string, int, Godot.Color)`](LeagueScreen.cs.md#symbol-c7e40485fba6)；[`NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`](LeagueScreen.cs.md#symbol-df3facf7c8b0)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.LeagueCardFace.ShowCard(MegaCrit.Sts2.Core.Models.CardModel, int, Godot.Color, bool, MegaCrit.Sts2.Core.Nodes.Cards.NCard?)`](LeagueCardFace.cs.md#symbol-50215c17339c)；[`NationalSpire.LeagueCards.CanReplace(NationalSpire.LeagueAlbum, string, NationalSpire.LeagueCards.Entry)`](LeagueCards.cs.md#symbol-a4faf18d19e7)；[`NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum)`](LeagueCards.cs.md#symbol-330c11ebf6f4)；[`NationalSpire.LeagueCards.UpgradeCost(NationalSpire.LeagueCards.Entry)`](LeagueCards.cs.md#symbol-ef07629a8beb)；[`NationalSpire.LeagueCards.Upgraded(NationalSpire.LeagueAlbum, string)`](LeagueCards.cs.md#symbol-c7bdf32dc0de)；`Godot.CenterContainer.CenterContainer()`；`Godot.Color.Color(string)`；`Godot.ColorRect.ColorRect()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.GrabFocus()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.QueueFree()`；`Godot.ScrollContainer.ScrollContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.LeagueCardFace.LeagueCardFace()`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.League`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._stage`；`NationalSpire.CareerScreen.LeagueAction(string, string, int, Godot.Control?)`；`NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；`NationalSpire.CareerScreen.LeagueControl.Back`；`NationalSpire.CareerScreen.LeagueNumber(string, int, Godot.Color)`；`NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`；`NationalSpire.CareerScreen.SuitColors`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.LeagueCardFace.ShowCard(MegaCrit.Sts2.Core.Models.CardModel, int, Godot.Color, bool, MegaCrit.Sts2.Core.Nodes.Cards.NCard?)`；`NationalSpire.LeagueCards.CanReplace(NationalSpire.LeagueAlbum, string, NationalSpire.LeagueCards.Entry)`；`NationalSpire.LeagueCards.Catalog`；`NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum)`；`NationalSpire.LeagueCards.Entry.Id`；`NationalSpire.LeagueCards.Entry.Model`；`NationalSpire.LeagueCards.Entry.Tier`；`NationalSpire.LeagueCards.Entry.Title`；`NationalSpire.LeagueCards.UpgradeCost(NationalSpire.LeagueCards.Entry)`；`NationalSpire.LeagueCards.Upgraded(NationalSpire.LeagueAlbum, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CenterContainer.CenterContainer()`；输入表达式：`new CenterContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new CenterContainer()`
- `Godot.Color.Color(string)`；输入表达式：`new Color("09111bf2")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Color=new Color("09111bf2")`
- `Godot.Color.Color(string)`；输入表达式：`new Color(SuitColors[next.Tier])`；返回值紧邻使用处：`ArgumentSyntax: new Color(SuitColors[next.Tier])`
- `Godot.ColorRect.ColorRect()`；输入表达式：`new ColorRect{Color=new Color("09111bf2"),MouseFilter=MouseFilterEnum.Stop,ZIndex=120}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new ColorRect{Color=new Color("09111bf2"),MouseFilter=MouseFilterEnum.Stop,ZIndex=120}`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`options.AddThemeConstantOverride("separation",6)`；返回值紧邻使用处：`ExpressionStatementSyntax: options.AddThemeConstantOverride("separation",6);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`pane.AddThemeConstantOverride("separation",16)`；返回值紧邻使用处：`ExpressionStatementSyntax: pane.AddThemeConstantOverride("separation",16);`
- `Godot.Control.GrabFocus()`；输入表达式：`cancel.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: cancel.GrabFocus();`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`center.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: center.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_stage.AddChild(shade)`；返回值紧邻使用处：`ExpressionStatementSyntax: _stage.AddChild(shade);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`center.AddChild(pane)`；返回值紧邻使用处：`ExpressionStatementSyntax: center.AddChild(pane);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`left.AddChild(face)`；返回值紧邻使用处：`ExpressionStatementSyntax: left.AddChild(face);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`left.AddChild(LeagueNumber("加入一张   ·   "+next.Title,235,_gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: left.AddChild(LeagueNumber("加入一张   ·   "+next.Title,235,_gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`options.AddChild(key)`；返回值紧邻使用处：`ExpressionStatementSyntax: options.AddChild(key);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`pane.AddChild(cancel)`；返回值紧邻使用处：`ExpressionStatementSyntax: pane.AddChild(cancel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`pane.AddChild(Text("选择要移出的牌",32,_gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: pane.AddChild(Text("选择要移出的牌",32,_gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scroll.AddChild(options)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.AddChild(options);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`shade.AddChild(center)`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.AddChild(center);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`strip.AddChild(left)`；返回值紧邻使用处：`ExpressionStatementSyntax: strip.AddChild(left);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`strip.AddChild(scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: strip.AddChild(scroll);`
- `Godot.Node.QueueFree()`；输入表达式：`shade.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.QueueFree();`
- `Godot.ScrollContainer.ScrollContainer()`；输入表达式：`new ScrollContainer{CustomMinimumSize=new(510,352),HorizontalScrollMode=ScrollContainer.ScrollMode.Disabled}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new ScrollContainer{CustomMinimumSize=new(510,352),HorizontalScrollMode=ScrollContainer.ScrollMode.Disabled}`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer()`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer{SizeFlagsHorizontal=SizeFlags.ExpandFill}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer{SizeFlagsHorizontal=SizeFlags.ExpandFill}`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(235,326)`；返回值紧邻使用处：`AssignmentExpressionSyntax: face.CustomMinimumSize=new(235,326)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(510,352)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(510,352)`
- `NationalSpire.CareerScreen.LeagueAction(string, string, int, Godot.Control?)`；输入表达式：`LeagueAction("swap",id+"|"+next.Id,origin:origin)`；返回值紧邻使用处：`ExpressionStatementSyntax: LeagueAction("swap",id+"|"+next.Id,origin:origin);`
- `NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；输入表达式：`LeagueButton("返回",shade.QueueFree,100,kind:LeagueControl.Back)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueButton("返回",shade.QueueFree,100,kind:LeagueControl.Back)`
- `NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；输入表达式：`LeagueButton(title+"   × "+deck[id]+(refund>0?"     返还 "+refund+" 点":""),()=>{shade.QueueFree();LeagueAction("swap",id+"|"+next.Id,origin:origin);},420,accent:old==null?"90c7ca":SuitColors[old.Tier])`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueButton(title+"   × "+deck[id]+(refund>0?"     返还 "+refund+" 点":""),()=>{shade.QueueFree();LeagueAction("swap",id+"|"+next.Id,origin:origin);},420,accent:old==null?"90c7ca":SuitColors[old.Tier])`
- `NationalSpire.CareerScreen.LeagueNumber(string, int, Godot.Color)`；输入表达式：`LeagueNumber("加入一张   ·   "+next.Title,235,_gold)`；返回值紧邻使用处：`ArgumentSyntax: LeagueNumber("加入一张   ·   "+next.Title,235,_gold)`
- `NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`；输入表达式：`LeagueRow(pane,30)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueRow(pane,30)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("选择要移出的牌",32,_gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("选择要移出的牌",32,_gold)`
- `NationalSpire.LeagueCardFace.LeagueCardFace()`；输入表达式：`new LeagueCardFace()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new LeagueCardFace()`
- `NationalSpire.LeagueCardFace.ShowCard(MegaCrit.Sts2.Core.Models.CardModel, int, Godot.Color, bool, MegaCrit.Sts2.Core.Nodes.Cards.NCard?)`；输入表达式：`face.ShowCard(next.Model,next.Tier,new Color(SuitColors[next.Tier]))`；返回值紧邻使用处：`ExpressionStatementSyntax: face.ShowCard(next.Model,next.Tier,new Color(SuitColors[next.Tier]));`
- `NationalSpire.LeagueCards.CanReplace(NationalSpire.LeagueAlbum, string, NationalSpire.LeagueCards.Entry)`；输入表达式：`LeagueCards.CanReplace(a,k,next)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: k=>LeagueCards.CanReplace(a,k,next)`
- `NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum)`；输入表达式：`LeagueCards.Deck(a)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: LeagueCards.Deck(a)!`
- `NationalSpire.LeagueCards.UpgradeCost(NationalSpire.LeagueCards.Entry)`；输入表达式：`LeagueCards.UpgradeCost(old)`；返回值紧邻使用处：`ConditionalExpressionSyntax: old!=null&&LeagueCards.Upgraded(a,id)==deck[id]?LeagueCards.UpgradeCost(old):0`
- `NationalSpire.LeagueCards.Upgraded(NationalSpire.LeagueAlbum, string)`；输入表达式：`LeagueCards.Upgraded(a,id)`；返回值紧邻使用处：`BinaryExpressionSyntax: LeagueCards.Upgraded(a,id)==deck[id]`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`deck.Keys.Where(k=>LeagueCards.CanReplace(a,k,next)).OrderBy(k=>LeagueCards.Catalog.GetValueOrDefault(k)?.Title??k,StringComparer.CurrentCulture)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var id in deck.Keys.Where(k=>LeagueCards.CanReplace(a,k,next)).OrderBy(k=>LeagueCards.Catalog.GetValueOrDefault(k)?.Title??k,StringComparer.CurrentCulture)){             var old=LeagueCards.Catalog.GetValueOrDefault(id);string title=old?.Title??id;int refund=old!=null&&LeagueCards.Upgraded(a,id)==deck[id]?LeagueCards.UpgradeCost(old):0;             var key=LeagueButton(title+"   × "+deck[id]+(refund>0?"     返还 "+refund+" 点":""),()=>{shade.QueueFree();LeagueAction("swap",id+"|"+next.Id,origin:origin);},420,accent:old==null?"90c7ca":SuitColors[old.Tier]);             key.TooltipText="移出一张"+title+"，加入一张"+next.Title;options.AddChild(key);         }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`deck.Keys.Where(k=>LeagueCards.CanReplace(a,k,next))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: deck.Keys.Where(k=>LeagueCards.CanReplace(a,k,next)).OrderBy`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`LeagueCards.Catalog.GetValueOrDefault(id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueCards.Catalog.GetValueOrDefault(id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`LeagueCards.Catalog.GetValueOrDefault(k)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: LeagueCards.Catalog.GetValueOrDefault(k)?.Title`

**赋值（含属性/字段和局部值）：**

- `cancel.SizeFlagsHorizontal` = `SizeFlags.ShrinkEnd`
- `Color` = `new Color("09111bf2")`
- `CustomMinimumSize` = `new(510,352)`
- `face.CustomMinimumSize` = `new(235,326)`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `key.TooltipText` = `"移出一张"+title+"，加入一张"+next.Title`
- `MouseFilter` = `MouseFilterEnum.Stop`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `ZIndex` = `120`

<a id="symbol-947b5653f588"></a>

## `NationalSpire.CareerScreen.DeckKey(string, string, string, System.Action, bool) — private static Button DeckKey(string action,string title,string hint,Action pressed,bool enabled)`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DeckEditor(NationalSpire.CareerData, System.Collections.Generic.Dictionary<string, int>)`](LeagueDeckEditor.cs.md#symbol-825b0bb2327f)；[`NationalSpire.CareerScreen.DeckSmith(NationalSpire.LeagueCards.Entry)`](LeagueDeckEditor.cs.md#symbol-92429c805c31)；[`NationalSpire.CareerScreen.LeagueGrid(System.Collections.Generic.IEnumerable<NationalSpire.LeagueCards.Entry>, NationalSpire.CareerData, string, Godot.Control?)`](LeagueScreen.cs.md#symbol-315dac8c42bd)

**调用：** [`NationalSpire.CareerScreen.DeckIcon(string)`](LeagueDeckEditor.cs.md#symbol-01b82580d5ea)；[`NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`](LeaguePresentation.cs.md#symbol-3412750f7453)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.DeckIcon(string)`；`NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`key.AddThemeConstantOverride("h_separation",4)`；返回值紧邻使用处：`ExpressionStatementSyntax: key.AddThemeConstantOverride("h_separation",4);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`key.AddThemeConstantOverride("icon_max_width",19)`；返回值紧邻使用处：`ExpressionStatementSyntax: key.AddThemeConstantOverride("icon_max_width",19);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(85,35)`；返回值紧邻使用处：`AssignmentExpressionSyntax: key.CustomMinimumSize=new(85,35)`
- `NationalSpire.CareerScreen.DeckIcon(string)`；输入表达式：`DeckIcon(action)`；返回值紧邻使用处：`ArgumentSyntax: emblem:DeckIcon(action)`
- `NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；输入表达式：`LeagueButton(title,pressed,85,accent:action=="upgrade"?"ebc680":"90c7ca",emblem:DeckIcon(action))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueButton(title,pressed,85,accent:action=="upgrade"?"ebc680":"90c7ca",emblem:DeckIcon(action))`

**赋值（含属性/字段和局部值）：**

- `key.AccessibilityName` = `hint`
- `key.CustomMinimumSize` = `new(85,35)`
- `key.Disabled` = `!enabled`
- `key.TooltipText` = `hint`

<a id="symbol-825b0bb2327f"></a>

## `NationalSpire.CareerScreen.DeckEditor(NationalSpire.CareerData, System.Collections.Generic.Dictionary<string, int>) — private void DeckEditor(CareerData d,Dictionary<string,int> deck)`

来源：源码第 45 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LeagueScreen(NationalSpire.CareerData)`](LeagueScreen.cs.md#symbol-6b4f6cdfeec1)

**调用：** [`Browse()`](LeagueDeckEditor.cs.md#symbol-3160728b0b5b)；[`CountMark(Godot.Texture2D, string, int, Godot.Color)`](LeagueDeckEditor.cs.md#symbol-c1f645acc6ef)；[`NationalSpire.CareerScreen.DeckIcon(string)`](LeagueDeckEditor.cs.md#symbol-01b82580d5ea)；[`NationalSpire.CareerScreen.DeckKey(string, string, string, System.Action, bool)`](LeagueDeckEditor.cs.md#symbol-947b5653f588)；[`NationalSpire.CareerScreen.DeckSmith(NationalSpire.LeagueCards.Entry)`](LeagueDeckEditor.cs.md#symbol-92429c805c31)；[`NationalSpire.CareerScreen.LeagueAction(string, string, int, Godot.Control?)`](LeagueScreen.cs.md#symbol-c5858ab8fb69)；[`NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`](LeaguePresentation.cs.md#symbol-3412750f7453)；[`NationalSpire.CareerScreen.LeagueInspect(NationalSpire.LeagueCards.Entry, bool)`](LeagueScreen.cs.md#symbol-69ed9740453e)；[`NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`](LeagueScreen.cs.md#symbol-df3facf7c8b0)；[`NationalSpire.CareerScreen.LeagueTile(NationalSpire.LeagueCards.Entry, out Godot.VBoxContainer, bool, System.Action?)`](LeagueScreen.cs.md#symbol-3fa69e107266)；[`NationalSpire.CareerScreen.NavigationIcon(string)`](CareerDashboard.cs.md#symbol-3c49977c9503)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`](CareerScreen.cs.md#symbol-9df94d88557a)；[`NationalSpire.CareerScreen.ShelfTop(Godot.Control)`](LeagueScreen.cs.md#symbol-ac7580704af1)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`](LeagueCards.cs.md#symbol-b5fd3c07325e)；[`NationalSpire.LeagueCards.Points(NationalSpire.LeagueAlbum)`](LeagueCards.cs.md#symbol-86ddd4ab46bb)；[`NationalSpire.LeagueCards.Upgraded(NationalSpire.LeagueAlbum, string)`](LeagueCards.cs.md#symbol-c7bdf32dc0de)；[`NationalSpire.LeagueCards.Usable(NationalSpire.LeagueCards.Entry, string)`](LeagueCards.cs.md#symbol-af27d1eb2fda)；`Godot.GodotObject.SetDeferred(Godot.StringName, Godot.Variant)`；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChild<T>(int, bool)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.LeagueDeckStrip.LeagueDeckStrip()`；`System.Array.IndexOf<T>(T[], T)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`

**字段、属性、事件及方法组引用：** `Browse()`；`CountMark(Godot.Texture2D, string, int, Godot.Color)`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.League`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._deckOffset`；`NationalSpire.CareerScreen._deckQuery`；`NationalSpire.CareerScreen._deckShelf`；`NationalSpire.CareerScreen._deckSlots`；`NationalSpire.CareerScreen._deckStrip`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._leagueFilter`；`NationalSpire.CareerScreen._leaguePage`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._renderVersion`；`NationalSpire.CareerScreen.DeckIcon(string)`；`NationalSpire.CareerScreen.DeckKey(string, string, string, System.Action, bool)`；`NationalSpire.CareerScreen.DeckSmith(NationalSpire.LeagueCards.Entry)`；`NationalSpire.CareerScreen.LeagueAction(string, string, int, Godot.Control?)`；`NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；`NationalSpire.CareerScreen.LeagueControl.Filter`；`NationalSpire.CareerScreen.LeagueInspect(NationalSpire.LeagueCards.Entry, bool)`；`NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`；`NationalSpire.CareerScreen.LeagueTile(NationalSpire.LeagueCards.Entry, out Godot.VBoxContainer, bool, System.Action?)`；`NationalSpire.CareerScreen.NavigationIcon(string)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`；`NationalSpire.CareerScreen.ShelfTop(Godot.Control)`；`NationalSpire.CareerScreen.SuitColors`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.LeagueAlbum.Captain`；`NationalSpire.LeagueAlbum.Owned`；`NationalSpire.LeagueCards.Catalog`；`NationalSpire.LeagueCards.Entry.Id`；`NationalSpire.LeagueCards.Entry.Model`；`NationalSpire.LeagueCards.Entry.Tier`；`NationalSpire.LeagueCards.Entry.Title`；`NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`；`NationalSpire.LeagueCards.Grades`；`NationalSpire.LeagueCards.Points(NationalSpire.LeagueAlbum)`；`NationalSpire.LeagueCards.UpgradeBudget`；`NationalSpire.LeagueCards.Upgraded(NationalSpire.LeagueAlbum, string)`；`NationalSpire.LeagueCards.Usable(NationalSpire.LeagueCards.Entry, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Browse()`；输入表达式：`Browse()`；返回值紧邻使用处：`ExpressionStatementSyntax: Browse();`
- `CountMark(Godot.Texture2D, string, int, Godot.Color)`；输入表达式：`CountMark(DeckIcon("upgrade"),"已升级张数",up,up>0?_gold:_muted)`；返回值紧邻使用处：`ExpressionStatementSyntax: CountMark(DeckIcon("upgrade"),"已升级张数",up,up>0?_gold:_muted);`
- `CountMark(Godot.Texture2D, string, int, Godot.Color)`；输入表达式：`CountMark(NavigationIcon("layers")!,"入组张数",count,_ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: CountMark(NavigationIcon("layers")!,"入组张数",count,_ink);`
- `Godot.GodotObject.SetDeferred(Godot.StringName, Godot.Variant)`；输入表达式：`strip.SetDeferred(ScrollContainer.PropertyName.ScrollHorizontal,_deckOffset)`；返回值紧邻使用处：`ExpressionStatementSyntax: strip.SetDeferred(ScrollContainer.PropertyName.ScrollHorizontal,_deckOffset);`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit{Name="LeagueDeckSearch",Text=_deckQuery,PlaceholderText="搜索牌名或效果",ClearButtonEnabled=true,CustomMinimumSize=new(260,42)}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new LineEdit{Name="LeagueDeckSearch",Text=_deckQuery,PlaceholderText="搜索牌名或效果",ClearButtonEnabled=true,CustomMinimumSize=new(260,42)}`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(shelf)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(shelf);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(strip)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(strip);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`bar.AddChild(DeckKey("remove",fixedCard?"固定":"移出",fixedCard?"基础牌固定占位，可以锻造。":"移出一张"+c.Title,()=>LeagueAction("remove",id,origin:face),!fixedCard))`；返回值紧邻使用处：`ExpressionStatementSyntax: bar.AddChild(DeckKey("remove",fixedCard?"固定":"移出",fixedCard?"基础牌固定占位，可以锻造。":"移出一张"+c.Title,()=>LeagueAction("remove",id,origin:face),!fixedCard));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`bar.AddChild(upgrade)`；返回值紧邻使用处：`ExpressionStatementSyntax: bar.AddChild(upgrade);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`head.AddChild(Text("白卡、蓝卡 1 点   ·   金卡、先古 2 点",16,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: head.AddChild(Text("白卡、蓝卡 1 点   ·   金卡、先古 2 点",16,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`head.AddChild(Text("出战牌组",25,_gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: head.AddChild(Text("出战牌组",25,_gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`head.AddChild(Text($"升级点   {used} / {LeagueCards.UpgradeBudget}",18,_ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: head.AddChild(Text($"升级点   {used} / {LeagueCards.UpgradeBudget}",18,_ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(cell)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(cell);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(LeagueButton(id+" × "+count,()=>LeagueAction("remove",id),180))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(LeagueButton(id+" × "+count,()=>LeagueAction("remove",id),180));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(Text("从下方收藏中添加第一张牌。",18,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(Text("从下方收藏中添加第一张牌。",18,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`tools.AddChild(LeagueButton(tag==""?"全部":tag,()=>{int y=ShelfTop(tools)+60;_deckOffset=strip.ScrollHorizontal;_leagueFilter=tag;_leaguePage=0;Render();_=RestoreScrollAsync(y,_renderVersion);},77,_leagueFilter==tag,tag==""?"8cc5c9":SuitColors[Array.IndexOf(LeagueCards.Grades,tag)],kind:LeagueControl.Filter))`；返回值紧邻使用处：`ExpressionStatementSyntax: tools.AddChild(LeagueButton(tag==""?"全部":tag,()=>{int y=ShelfTop(tools)+60;_deckOffset=strip.ScrollHorizontal;_leagueFilter=tag;_leaguePage=0;Render();_=RestoreScrollAsync(y,_renderVersion);},77,_leagueFilter==tag,tag==""?"8cc5c9":SuitColors[Array.IndexOf(LeagueCards.Grades,tag)],kind:LeagueControl.Filter));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`tools.AddChild(search)`；返回值紧邻使用处：`ExpressionStatementSyntax: tools.AddChild(search);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`tools.AddChild(Text("我的收藏",24,_ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: tools.AddChild(Text("我的收藏",24,_ink));`
- `Godot.Node.GetChild<T>(int, bool)`；输入表达式：`column.GetChild<Control>(0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =column.GetChild<Control>(0)`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,356)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(0,356)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(186,248)`；返回值紧邻使用处：`AssignmentExpressionSyntax: face.CustomMinimumSize=new(186,248)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(260,42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(260,42)`
- `NationalSpire.CareerScreen.DeckIcon(string)`；输入表达式：`DeckIcon("upgrade")`；返回值紧邻使用处：`ArgumentSyntax: DeckIcon("upgrade")`
- `NationalSpire.CareerScreen.DeckKey(string, string, string, System.Action, bool)`；输入表达式：`DeckKey("remove",fixedCard?"固定":"移出",fixedCard?"基础牌固定占位，可以锻造。":"移出一张"+c.Title,()=>LeagueAction("remove",id,origin:face),!fixedCard)`；返回值紧邻使用处：`ArgumentSyntax: DeckKey("remove",fixedCard?"固定":"移出",fixedCard?"基础牌固定占位，可以锻造。":"移出一张"+c.Title,()=>LeagueAction("remove",id,origin:face),!fixedCard)`
- `NationalSpire.CareerScreen.DeckKey(string, string, string, System.Action, bool)`；输入表达式：`DeckKey("upgrade","锻造","查看"+c.Title+"的升级与点数",()=>DeckSmith(c),c.Model.MaxUpgradeLevel>0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =DeckKey("upgrade","锻造","查看"+c.Title+"的升级与点数",()=>DeckSmith(c),c.Model.MaxUpgradeLevel>0)`
- `NationalSpire.CareerScreen.DeckSmith(NationalSpire.LeagueCards.Entry)`；输入表达式：`DeckSmith(c)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>DeckSmith(c)`
- `NationalSpire.CareerScreen.LeagueAction(string, string, int, Godot.Control?)`；输入表达式：`LeagueAction("remove",id,origin:face)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>LeagueAction("remove",id,origin:face)`
- `NationalSpire.CareerScreen.LeagueAction(string, string, int, Godot.Control?)`；输入表达式：`LeagueAction("remove",id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>LeagueAction("remove",id)`
- `NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；输入表达式：`LeagueButton(id+" × "+count,()=>LeagueAction("remove",id),180)`；返回值紧邻使用处：`ArgumentSyntax: LeagueButton(id+" × "+count,()=>LeagueAction("remove",id),180)`
- `NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；输入表达式：`LeagueButton(tag==""?"全部":tag,()=>{int y=ShelfTop(tools)+60;_deckOffset=strip.ScrollHorizontal;_leagueFilter=tag;_leaguePage=0;Render();_=RestoreScrollAsync(y,_renderVersion);},77,_leagueFilter==tag,tag==""?"8cc5c9":SuitColors[Array.IndexOf(LeagueCards.Grades,tag)],kind:LeagueControl.Filter)`；返回值紧邻使用处：`ArgumentSyntax: LeagueButton(tag==""?"全部":tag,()=>{int y=ShelfTop(tools)+60;_deckOffset=strip.ScrollHorizontal;_leagueFilter=tag;_leaguePage=0;Render();_=RestoreScrollAsync(y,_renderVersion);},77,_leagueFilter==tag,tag==""?"8cc5c9":SuitColors[Array.IndexOf(LeagueCards.Grades,tag)],kind:LeagueControl.Filter)`
- `NationalSpire.CareerScreen.LeagueInspect(NationalSpire.LeagueCards.Entry, bool)`；输入表达式：`LeagueInspect(c,up>0)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>LeagueInspect(c,up>0)`
- `NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`；输入表达式：`LeagueRow(_content,15)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueRow(_content,15)`
- `NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`；输入表达式：`LeagueRow(_content,18)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueRow(_content,18)`
- `NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`；输入表达式：`LeagueRow(column,16)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueRow(column,16)`
- `NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`；输入表达式：`LeagueRow(column,5)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueRow(column,5)`
- `NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`；输入表达式：`LeagueRow(strip,12)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueRow(strip,12)`
- `NationalSpire.CareerScreen.LeagueTile(NationalSpire.LeagueCards.Entry, out Godot.VBoxContainer, bool, System.Action?)`；输入表达式：`LeagueTile(c,out var column,up>0,()=>LeagueInspect(c,up>0))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueTile(c,out var column,up>0,()=>LeagueInspect(c,up>0))`
- `NationalSpire.CareerScreen.NavigationIcon(string)`；输入表达式：`NavigationIcon("layers")`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: NavigationIcon("layers")!`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.RestoreScrollAsync(int, int)`；输入表达式：`RestoreScrollAsync(y,_renderVersion)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _=RestoreScrollAsync(y,_renderVersion)`
- `NationalSpire.CareerScreen.ShelfTop(Godot.Control)`；输入表达式：`ShelfTop(tools)`；返回值紧邻使用处：`BinaryExpressionSyntax: ShelfTop(tools)+60`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("白卡、蓝卡 1 点   ·   金卡、先古 2 点",16,_muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("白卡、蓝卡 1 点   ·   金卡、先古 2 点",16,_muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("出战牌组",25,_gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("出战牌组",25,_gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("从下方收藏中添加第一张牌。",18,_muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("从下方收藏中添加第一张牌。",18,_muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("我的收藏",24,_ink)`；返回值紧邻使用处：`ArgumentSyntax: Text("我的收藏",24,_ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"升级点   {used} / {LeagueCards.UpgradeBudget}",18,_ink)`；返回值紧邻使用处：`ArgumentSyntax: Text($"升级点   {used} / {LeagueCards.UpgradeBudget}",18,_ink)`
- `NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`；输入表达式：`LeagueCards.Fixed(c,a.Captain)`；返回值紧邻使用处：`BinaryExpressionSyntax: LeagueCards.Fixed(c,a.Captain)>0`
- `NationalSpire.LeagueCards.Points(NationalSpire.LeagueAlbum)`；输入表达式：`LeagueCards.Points(a)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueCards.Points(a)`
- `NationalSpire.LeagueCards.Upgraded(NationalSpire.LeagueAlbum, string)`；输入表达式：`LeagueCards.Upgraded(a,id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueCards.Upgraded(a,id)`
- `NationalSpire.LeagueCards.Usable(NationalSpire.LeagueCards.Entry, string)`；输入表达式：`LeagueCards.Usable(c,a.Captain)`；返回值紧邻使用处：`BinaryExpressionSyntax: a.Owned.GetValueOrDefault(c.Id)>0&&LeagueCards.Usable(c,a.Captain)`
- `NationalSpire.LeagueDeckStrip.LeagueDeckStrip()`；输入表达式：`new LeagueDeckStrip{CustomMinimumSize=new(0,356),VerticalScrollMode=ScrollContainer.ScrollMode.Disabled}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new LeagueDeckStrip{CustomMinimumSize=new(0,356),VerticalScrollMode=ScrollContainer.ScrollMode.Disabled}`
- `System.Array.IndexOf<T>(T[], T)`；输入表达式：`Array.IndexOf(LeagueCards.Grades,tag)`；返回值紧邻使用处：`ArgumentSyntax: Array.IndexOf(LeagueCards.Grades,tag)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_deckShelf.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _deckShelf.Clear();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_deckSlots.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _deckSlots.Clear();`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`new[]{""}.Concat(LeagueCards.Grades)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var tag in new[]{""}.Concat(LeagueCards.Grades))             tools.AddChild(LeagueButton(tag==""?"全部":tag,()=>{int y=ShelfTop(tools)+60;_deckOffset=strip.ScrollHorizontal;_leagueFilter=tag;_leaguePage=0;Render();_=RestoreScrollAsync(y,_renderVersion);},77,_leagueFilter==tag,tag==""?"8cc5c9":SuitColors[Array.IndexOf(LeagueCards.Grades,tag)],kind:LeagueControl.Filter));`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`deck.OrderBy(p=>LeagueCards.Catalog.GetValueOrDefault(p.Key)?.Title,StringComparer.CurrentCulture)`；返回值紧邻使用处：`ForEachVariableStatementSyntax: foreach(var (id,count) in deck.OrderBy(p=>LeagueCards.Catalog.GetValueOrDefault(p.Key)?.Title,StringComparer.CurrentCulture)){             if(!LeagueCards.Catalog.TryGetValue(id,out var c)){                 row.AddChild(LeagueButton(id+" × "+count,()=>LeagueAction("remove",id),180));continue;             }             int up=LeagueCards.Upgraded(a,id);             var cell=LeagueTile(c,out var column,up>0,()=>LeagueInspect(c,up>0));cell.SizeFlagsHorizontal=SizeFlags.ShrinkBegin;row.AddChild(cell);             var face=column.GetChild<Control>(0);face.CustomMinimumSize=new(186,248);_deckSlots[id]=face;             var stats=LeagueRow(column,16);stats.Alignment=BoxContainer.AlignmentMode.Center;             void CountMark(Texture2D icon,string hint,int value,Color ink){                 var item=LeagueRow(stats,4);item.TooltipText=hint;item.AccessibilityName=hint+" "+value;                 item.AddChild(new TextureRect{Texture=icon,Modulate=ink,CustomMinimumSize=new(20,20),ExpandMode=TextureRect.ExpandModeEnum.IgnoreSize,StretchMode=TextureRect.StretchModeEnum.KeepAspectCentered,MouseFilter=MouseFilterEnum.Ignore});                 item.AddChild(LeagueNumber(value.ToString(),19,ink));             }             CountMark(NavigationIcon("layers")!,"入组张数",count,_ink);CountMark(DeckIcon("upgrade"),"已升级张数",up,up>0?_gold:_muted);             var bar=LeagueRow(column,5);bar.Alignment=BoxContainer.AlignmentMode.Center;             bool fixedCard=LeagueCards.Fixed(c,a.Captain)>0;             bar.AddChild(DeckKey("remove",fixedCard?"固定":"移出",fixedCard?"基础牌固定占位，可以锻造。":"移出一张"+c.Title,()=>LeagueAction("remove",id,origin:face),!fixedCard));             var upgrade=DeckKey("upgrade","锻造","查看"+c.Title+"的升级与点数",()=>DeckSmith(c),c.Model.MaxUpgradeLevel>0);             bar.AddChild(upgrade);         }`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`LeagueCards.Catalog.Values.Where(c=>a.Owned.GetValueOrDefault(c.Id)>0&&LeagueCards.Usable(c,a.Captain))             .Where(c=>_leagueFilter.Length==0||LeagueCards.Grades[c.Tier]==_leagueFilter)             .OrderByDescending(c=>c.Tier)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: LeagueCards.Catalog.Values.Where(c=>a.Owned.GetValueOrDefault(c.Id)>0&&LeagueCards.Usable(c,a.Captain))             .Where(c=>_leagueFilter.Length==0||LeagueCards.Grades[c.Tier]==_leagueFilter)             .OrderByDescending(c=>c.Tier).ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`LeagueCards.Catalog.Values.Where(c=>a.Owned.GetValueOrDefault(c.Id)>0&&LeagueCards.Usable(c,a.Captain))             .Where(c=>_leagueFilter.Length==0||LeagueCards.Grades[c.Tier]==_leagueFilter)             .OrderByDescending(c=>c.Tier).ThenBy(c=>c.Title,StringComparer.CurrentCulture).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueCards.Catalog.Values.Where(c=>a.Owned.GetValueOrDefault(c.Id)>0&&LeagueCards.Usable(c,a.Captain))             .Where(c=>_leagueFilter.Length==0||LeagueCards.Grades[c.Tier]==_leagueFilter)             .OrderByDescending(c=>c.Tier).ThenBy(c=>c.Title,StringComparer.CurrentCulture).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`LeagueCards.Catalog.Values.Where(c=>a.Owned.GetValueOrDefault(c.Id)>0&&LeagueCards.Usable(c,a.Captain))             .Where(c=>_leagueFilter.Length==0||LeagueCards.Grades[c.Tier]==_leagueFilter)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: LeagueCards.Catalog.Values.Where(c=>a.Owned.GetValueOrDefault(c.Id)>0&&LeagueCards.Usable(c,a.Captain))             .Where(c=>_leagueFilter.Length==0||LeagueCards.Grades[c.Tier]==_leagueFilter)             .OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`LeagueCards.Catalog.Values.Where(c=>a.Owned.GetValueOrDefault(c.Id)>0&&LeagueCards.Usable(c,a.Captain))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: LeagueCards.Catalog.Values.Where(c=>a.Owned.GetValueOrDefault(c.Id)>0&&LeagueCards.Usable(c,a.Captain))             .Where`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`a.Owned.GetValueOrDefault(c.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: a.Owned.GetValueOrDefault(c.Id)>0`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`LeagueCards.Catalog.GetValueOrDefault(p.Key)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: LeagueCards.Catalog.GetValueOrDefault(p.Key)?.Title`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`LeagueCards.Catalog.TryGetValue(id,out var c)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !LeagueCards.Catalog.TryGetValue(id,out var c)`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`LeagueCards.Catalog.Values.Where(c=>a.Owned.GetValueOrDefault(c.Id)>0&&LeagueCards.Usable(c,a.Captain))             .Where(c=>_leagueFilter.Length==0||LeagueCards.Grades[c.Tier]==_leagueFilter)             .OrderByDescending(c=>c.Tier).ThenBy(c=>c.Title,StringComparer.CurrentCulture)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: LeagueCards.Catalog.Values.Where(c=>a.Owned.GetValueOrDefault(c.Id)>0&&LeagueCards.Usable(c,a.Captain))             .Where(c=>_leagueFilter.Length==0||LeagueCards.Grades[c.Tier]==_leagueFilter)             .OrderByDescending(c=>c.Tier).ThenBy(c=>c.Title,StringComparer.CurrentCulture).ToArray`

**赋值（含属性/字段和局部值）：**

- `_` = `RestoreScrollAsync(y,_renderVersion)`
- `_deckOffset` = `strip.ScrollHorizontal`
- `_deckQuery` = `q`
- `_deckSlots[id]` = `face`
- `_deckStrip` = `strip`
- `_leagueFilter` = `tag`
- `_leaguePage` = `0`
- `bar.Alignment` = `BoxContainer.AlignmentMode.Center`
- `cell.SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`
- `ClearButtonEnabled` = `true`
- `CustomMinimumSize` = `new(0,356)`
- `CustomMinimumSize` = `new(260,42)`
- `face.CustomMinimumSize` = `new(186,248)`
- `Name` = `"LeagueDeckSearch"`
- `PlaceholderText` = `"搜索牌名或效果"`
- `search.TextChanged` += `q=>{_deckQuery=q;_leaguePage=0;Browse();}`
- `stats.Alignment` = `BoxContainer.AlignmentMode.Center`
- `Text` = `_deckQuery`
- `VerticalScrollMode` = `ScrollContainer.ScrollMode.Disabled`

<a id="symbol-c1f645acc6ef"></a>

## `CountMark(Godot.Texture2D, string, int, Godot.Color) — void CountMark(Texture2D icon,string hint,int value,Color ink)`

来源：源码第 60 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DeckEditor(NationalSpire.CareerData, System.Collections.Generic.Dictionary<string, int>)`](LeagueDeckEditor.cs.md#symbol-825b0bb2327f)

**调用：** [`NationalSpire.CareerScreen.LeagueNumber(string, int, Godot.Color)`](LeagueScreen.cs.md#symbol-c7e40485fba6)；[`NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`](LeagueScreen.cs.md#symbol-df3facf7c8b0)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.TextureRect.TextureRect()`；`Godot.Vector2.Vector2(float, float)`；`int.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.LeagueNumber(string, int, Godot.Color)`；`NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`item.AddChild(LeagueNumber(value.ToString(),19,ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: item.AddChild(LeagueNumber(value.ToString(),19,ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`item.AddChild(new TextureRect{Texture=icon,Modulate=ink,CustomMinimumSize=new(20,20),ExpandMode=TextureRect.ExpandModeEnum.IgnoreSize,StretchMode=TextureRect.StretchModeEnum.KeepAspectCentered,MouseFilter=MouseFilterEnum.Ignore})`；返回值紧邻使用处：`ExpressionStatementSyntax: item.AddChild(new TextureRect{Texture=icon,Modulate=ink,CustomMinimumSize=new(20,20),ExpandMode=TextureRect.ExpandModeEnum.IgnoreSize,StretchMode=TextureRect.StretchModeEnum.KeepAspectCentered,MouseFilter=MouseFilterEnum.Ignore});`
- `Godot.TextureRect.TextureRect()`；输入表达式：`new TextureRect{Texture=icon,Modulate=ink,CustomMinimumSize=new(20,20),ExpandMode=TextureRect.ExpandModeEnum.IgnoreSize,StretchMode=TextureRect.StretchModeEnum.KeepAspectCentered,MouseFilter=MouseFilterEnum.Ignore}`；返回值紧邻使用处：`ArgumentSyntax: new TextureRect{Texture=icon,Modulate=ink,CustomMinimumSize=new(20,20),ExpandMode=TextureRect.ExpandModeEnum.IgnoreSize,StretchMode=TextureRect.StretchModeEnum.KeepAspectCentered,MouseFilter=MouseFilterEnum.Ignore}`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(20,20)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(20,20)`
- `int.ToString()`；输入表达式：`value.ToString()`；返回值紧邻使用处：`ArgumentSyntax: value.ToString()`
- `NationalSpire.CareerScreen.LeagueNumber(string, int, Godot.Color)`；输入表达式：`LeagueNumber(value.ToString(),19,ink)`；返回值紧邻使用处：`ArgumentSyntax: LeagueNumber(value.ToString(),19,ink)`
- `NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`；输入表达式：`LeagueRow(stats,4)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueRow(stats,4)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(20,20)`
- `ExpandMode` = `TextureRect.ExpandModeEnum.IgnoreSize`
- `item.AccessibilityName` = `hint+" "+value`
- `item.TooltipText` = `hint`
- `Modulate` = `ink`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `StretchMode` = `TextureRect.StretchModeEnum.KeepAspectCentered`
- `Texture` = `icon`

<a id="symbol-3160728b0b5b"></a>

## `Browse() — void Browse()`

来源：源码第 83 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DeckEditor(NationalSpire.CareerData, System.Collections.Generic.Dictionary<string, int>)`](LeagueDeckEditor.cs.md#symbol-825b0bb2327f)

**调用：** [`NationalSpire.CareerScreen.LeagueGrid(System.Collections.Generic.IEnumerable<NationalSpire.LeagueCards.Entry>, NationalSpire.CareerData, string, Godot.Control?)`](LeagueScreen.cs.md#symbol-315dac8c42bd)；[`NationalSpire.CareerScreen.StoreFaces(Godot.Control)`](LeagueScreen.cs.md#symbol-65c1aeb6b0cb)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；`MegaCrit.Sts2.Core.Localization.LocString.GetRawText()`；`string.Contains(string, System.StringComparison)`；`string.Trim()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._deckQuery`；`NationalSpire.CareerScreen._deckShelf`；`NationalSpire.CareerScreen.LeagueGrid(System.Collections.Generic.IEnumerable<NationalSpire.LeagueCards.Entry>, NationalSpire.CareerData, string, Godot.Control?)`；`NationalSpire.CareerScreen.StoreFaces(Godot.Control)`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.LeagueCards.Entry.Model`；`NationalSpire.LeagueCards.Entry.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Localization.LocString.GetRawText()`；输入表达式：`c.Model.Description.GetRawText()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Model.Description.GetRawText().Contains`
- `NationalSpire.CareerScreen.LeagueGrid(System.Collections.Generic.IEnumerable<NationalSpire.LeagueCards.Entry>, NationalSpire.CareerData, string, Godot.Control?)`；输入表达式：`LeagueGrid(owned.Where(c=>q.Length==0||c.Title.Contains(q,StringComparison.CurrentCultureIgnoreCase)||c.Model.Description.GetRawText().Contains(q,StringComparison.CurrentCultureIgnoreCase)),d,"组卡",shelf)`；返回值紧邻使用处：`ExpressionStatementSyntax: LeagueGrid(owned.Where(c=>q.Length==0||c.Title.Contains(q,StringComparison.CurrentCultureIgnoreCase)||c.Model.Description.GetRawText().Contains(q,StringComparison.CurrentCultureIgnoreCase)),d,"组卡",shelf);`
- `NationalSpire.CareerScreen.StoreFaces(Godot.Control)`；输入表达式：`StoreFaces(shelf)`；返回值紧邻使用处：`ExpressionStatementSyntax: StoreFaces(shelf);`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(shelf)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(shelf);`
- `string.Contains(string, System.StringComparison)`；输入表达式：`c.Model.Description.GetRawText().Contains(q,StringComparison.CurrentCultureIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: q.Length==0||c.Title.Contains(q,StringComparison.CurrentCultureIgnoreCase)||c.Model.Description.GetRawText().Contains(q,StringComparison.CurrentCultureIgnoreCase)`
- `string.Contains(string, System.StringComparison)`；输入表达式：`c.Title.Contains(q,StringComparison.CurrentCultureIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: q.Length==0||c.Title.Contains(q,StringComparison.CurrentCultureIgnoreCase)`
- `string.Trim()`；输入表达式：`_deckQuery.Trim()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =_deckQuery.Trim()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_deckShelf.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _deckShelf.Clear();`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`owned.Where(c=>q.Length==0||c.Title.Contains(q,StringComparison.CurrentCultureIgnoreCase)||c.Model.Description.GetRawText().Contains(q,StringComparison.CurrentCultureIgnoreCase))`；返回值紧邻使用处：`ArgumentSyntax: owned.Where(c=>q.Length==0||c.Title.Contains(q,StringComparison.CurrentCultureIgnoreCase)||c.Model.Description.GetRawText().Contains(q,StringComparison.CurrentCultureIgnoreCase))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-92429c805c31"></a>

## `NationalSpire.CareerScreen.DeckSmith(NationalSpire.LeagueCards.Entry) — private void DeckSmith(LeagueCards.Entry card)`

来源：源码第 89 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DeckEditor(NationalSpire.CareerData, System.Collections.Generic.Dictionary<string, int>)`](LeagueDeckEditor.cs.md#symbol-825b0bb2327f)

**调用：** [`Apply(string)`](LeagueDeckEditor.cs.md#symbol-904d637856af)；[`NationalSpire.CareerScreen.DeckKey(string, string, string, System.Action, bool)`](LeagueDeckEditor.cs.md#symbol-947b5653f588)；[`NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`](LeaguePresentation.cs.md#symbol-3412750f7453)；[`NationalSpire.CareerScreen.LeagueNumber(string, int, Godot.Color)`](LeagueScreen.cs.md#symbol-c7e40485fba6)；[`NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`](LeagueScreen.cs.md#symbol-df3facf7c8b0)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.LeagueCardFace.ShowCard(MegaCrit.Sts2.Core.Models.CardModel, int, Godot.Color, bool, MegaCrit.Sts2.Core.Nodes.Cards.NCard?)`](LeagueCardFace.cs.md#symbol-50215c17339c)；[`NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum)`](LeagueCards.cs.md#symbol-330c11ebf6f4)；[`NationalSpire.LeagueCards.Points(NationalSpire.LeagueAlbum)`](LeagueCards.cs.md#symbol-86ddd4ab46bb)；[`NationalSpire.LeagueCards.UpgradeCost(NationalSpire.LeagueCards.Entry)`](LeagueCards.cs.md#symbol-ef07629a8beb)；[`NationalSpire.LeagueCards.Upgraded(NationalSpire.LeagueAlbum, string)`](LeagueCards.cs.md#symbol-c7bdf32dc0de)；`Godot.CenterContainer.CenterContainer()`；`Godot.Color.Color(string)`；`Godot.ColorRect.ColorRect()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.GrabFocus()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.LeagueCardFace.LeagueCardFace()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `Apply(string)`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.League`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._stage`；`NationalSpire.CareerScreen.DeckKey(string, string, string, System.Action, bool)`；`NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；`NationalSpire.CareerScreen.LeagueControl.Back`；`NationalSpire.CareerScreen.LeagueNumber(string, int, Godot.Color)`；`NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`；`NationalSpire.CareerScreen.SuitColors`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.LeagueCardFace.ShowCard(MegaCrit.Sts2.Core.Models.CardModel, int, Godot.Color, bool, MegaCrit.Sts2.Core.Nodes.Cards.NCard?)`；`NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum)`；`NationalSpire.LeagueCards.Entry.Id`；`NationalSpire.LeagueCards.Entry.Model`；`NationalSpire.LeagueCards.Entry.Tier`；`NationalSpire.LeagueCards.Entry.Title`；`NationalSpire.LeagueCards.Points(NationalSpire.LeagueAlbum)`；`NationalSpire.LeagueCards.UpgradeBudget`；`NationalSpire.LeagueCards.UpgradeCost(NationalSpire.LeagueCards.Entry)`；`NationalSpire.LeagueCards.Upgraded(NationalSpire.LeagueAlbum, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Apply(string)`；输入表达式：`Apply("downgrade")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>Apply("downgrade")`
- `Apply(string)`；输入表达式：`Apply("upgrade")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>Apply("upgrade")`
- `Godot.CenterContainer.CenterContainer()`；输入表达式：`new CenterContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new CenterContainer()`
- `Godot.Color.Color(string)`；输入表达式：`new Color("09111bf2")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Color=new Color("09111bf2")`
- `Godot.Color.Color(string)`；输入表达式：`new Color(SuitColors[card.Tier])`；返回值紧邻使用处：`ArgumentSyntax: new Color(SuitColors[card.Tier])`
- `Godot.ColorRect.ColorRect()`；输入表达式：`new ColorRect{Color=new Color("09111bf2"),MouseFilter=MouseFilterEnum.Stop,ZIndex=120}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new ColorRect{Color=new Color("09111bf2"),MouseFilter=MouseFilterEnum.Stop,ZIndex=120}`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`content.AddThemeConstantOverride("separation",12)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddThemeConstantOverride("separation",12);`
- `Godot.Control.GrabFocus()`；输入表达式：`close.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: close.GrabFocus();`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`center.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: center.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_stage.AddChild(shade)`；返回值紧邻使用处：`ExpressionStatementSyntax: _stage.AddChild(shade);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(close)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(close);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(DeckKey("downgrade","撤销一张","撤销一张升级，返还点数",()=>Apply("downgrade"),up>0))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(DeckKey("downgrade","撤销一张","撤销一张升级，返还点数",()=>Apply("downgrade"),up>0));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(DeckKey("upgrade",$"升级一张 · {cost} 点","升级一张"+card.Title+"，消耗 "+cost+" 点",()=>Apply("upgrade"),up<qty&&LeagueCards.Points(a)+cost<=LeagueCards.UpgradeBudget))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(DeckKey("upgrade",$"升级一张 · {cost} 点","升级一张"+card.Title+"，消耗 "+cost+" 点",()=>Apply("upgrade"),up<qty&&LeagueCards.Points(a)+cost<=LeagueCards.UpgradeBudget));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`center.AddChild(content)`；返回值紧邻使用处：`ExpressionStatementSyntax: center.AddChild(content);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`column.AddChild(face)`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddChild(face);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`column.AddChild(LeagueNumber(next?"升级后":"原牌",180,next?_gold:_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddChild(LeagueNumber(next?"升级后":"原牌",180,next?_gold:_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(LeagueNumber($"入组 {qty} 张    ·    已升级 {up} 张    ·    剩余 {LeagueCards.UpgradeBudget-LeagueCards.Points(a)} 点",360,_ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(LeagueNumber($"入组 {qty} 张    ·    已升级 {up} 张    ·    剩余 {LeagueCards.UpgradeBudget-LeagueCards.Points(a)} 点",360,_ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(Text(card.Title+"   ·   锻造",32,_gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(Text(card.Title+"   ·   锻造",32,_gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`pair.AddChild(column)`；返回值紧邻使用处：`ExpressionStatementSyntax: pair.AddChild(column);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`shade.AddChild(center)`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.AddChild(center);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(245,338)`；返回值紧邻使用处：`AssignmentExpressionSyntax: face.CustomMinimumSize=new(245,338)`
- `NationalSpire.CareerScreen.DeckKey(string, string, string, System.Action, bool)`；输入表达式：`DeckKey("downgrade","撤销一张","撤销一张升级，返还点数",()=>Apply("downgrade"),up>0)`；返回值紧邻使用处：`ArgumentSyntax: DeckKey("downgrade","撤销一张","撤销一张升级，返还点数",()=>Apply("downgrade"),up>0)`
- `NationalSpire.CareerScreen.DeckKey(string, string, string, System.Action, bool)`；输入表达式：`DeckKey("upgrade",$"升级一张 · {cost} 点","升级一张"+card.Title+"，消耗 "+cost+" 点",()=>Apply("upgrade"),up<qty&&LeagueCards.Points(a)+cost<=LeagueCards.UpgradeBudget)`；返回值紧邻使用处：`ArgumentSyntax: DeckKey("upgrade",$"升级一张 · {cost} 点","升级一张"+card.Title+"，消耗 "+cost+" 点",()=>Apply("upgrade"),up<qty&&LeagueCards.Points(a)+cost<=LeagueCards.UpgradeBudget)`
- `NationalSpire.CareerScreen.LeagueButton(string, System.Action, float, bool, string, Godot.Texture2D?, NationalSpire.CareerScreen.LeagueControl)`；输入表达式：`LeagueButton("返回",shade.QueueFree,90,kind:LeagueControl.Back)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueButton("返回",shade.QueueFree,90,kind:LeagueControl.Back)`
- `NationalSpire.CareerScreen.LeagueNumber(string, int, Godot.Color)`；输入表达式：`LeagueNumber($"入组 {qty} 张    ·    已升级 {up} 张    ·    剩余 {LeagueCards.UpgradeBudget-LeagueCards.Points(a)} 点",360,_ink)`；返回值紧邻使用处：`ArgumentSyntax: LeagueNumber($"入组 {qty} 张    ·    已升级 {up} 张    ·    剩余 {LeagueCards.UpgradeBudget-LeagueCards.Points(a)} 点",360,_ink)`
- `NationalSpire.CareerScreen.LeagueNumber(string, int, Godot.Color)`；输入表达式：`LeagueNumber(next?"升级后":"原牌",180,next?_gold:_muted)`；返回值紧邻使用处：`ArgumentSyntax: LeagueNumber(next?"升级后":"原牌",180,next?_gold:_muted)`
- `NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`；输入表达式：`LeagueRow(content,10)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueRow(content,10)`
- `NationalSpire.CareerScreen.LeagueRow(Godot.Control, int)`；输入表达式：`LeagueRow(content,28)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueRow(content,28)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(card.Title+"   ·   锻造",32,_gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(card.Title+"   ·   锻造",32,_gold)`
- `NationalSpire.LeagueCardFace.LeagueCardFace()`；输入表达式：`new LeagueCardFace()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new LeagueCardFace()`
- `NationalSpire.LeagueCardFace.ShowCard(MegaCrit.Sts2.Core.Models.CardModel, int, Godot.Color, bool, MegaCrit.Sts2.Core.Nodes.Cards.NCard?)`；输入表达式：`face.ShowCard(card.Model,card.Tier,new Color(SuitColors[card.Tier]),next)`；返回值紧邻使用处：`ExpressionStatementSyntax: face.ShowCard(card.Model,card.Tier,new Color(SuitColors[card.Tier]),next);`
- `NationalSpire.LeagueCards.Deck(NationalSpire.LeagueAlbum)`；输入表达式：`LeagueCards.Deck(a)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: LeagueCards.Deck(a)!`
- `NationalSpire.LeagueCards.Points(NationalSpire.LeagueAlbum)`；输入表达式：`LeagueCards.Points(a)`；返回值紧邻使用处：`BinaryExpressionSyntax: LeagueCards.Points(a)+cost`
- `NationalSpire.LeagueCards.Points(NationalSpire.LeagueAlbum)`；输入表达式：`LeagueCards.Points(a)`；返回值紧邻使用处：`BinaryExpressionSyntax: LeagueCards.UpgradeBudget-LeagueCards.Points(a)`
- `NationalSpire.LeagueCards.UpgradeCost(NationalSpire.LeagueCards.Entry)`；输入表达式：`LeagueCards.UpgradeCost(card)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueCards.UpgradeCost(card)`
- `NationalSpire.LeagueCards.Upgraded(NationalSpire.LeagueAlbum, string)`；输入表达式：`LeagueCards.Upgraded(a,card.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueCards.Upgraded(a,card.Id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`LeagueCards.Deck(a)!.GetValueOrDefault(card.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueCards.Deck(a)!.GetValueOrDefault(card.Id)`

**赋值（含属性/字段和局部值）：**

- `actions.Alignment` = `BoxContainer.AlignmentMode.Center`
- `Color` = `new Color("09111bf2")`
- `face.CustomMinimumSize` = `new(245,338)`
- `MouseFilter` = `MouseFilterEnum.Stop`
- `ZIndex` = `120`

<a id="symbol-904d637856af"></a>

## `Apply(string) — void Apply(string op)`

来源：源码第 100 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DeckSmith(NationalSpire.LeagueCards.Entry)`](LeagueDeckEditor.cs.md#symbol-92429c805c31)

**调用：** [`NationalSpire.CareerScreen.LeagueAction(string, string, int, Godot.Control?)`](LeagueScreen.cs.md#symbol-c5858ab8fb69)；`Godot.Node.QueueFree()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._deckSlots`；`NationalSpire.CareerScreen.LeagueAction(string, string, int, Godot.Control?)`；`NationalSpire.LeagueCards.Entry.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.QueueFree()`；输入表达式：`shade.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.QueueFree();`
- `NationalSpire.CareerScreen.LeagueAction(string, string, int, Godot.Control?)`；输入表达式：`LeagueAction(op,card.Id,origin:_deckSlots.GetValueOrDefault(card.Id))`；返回值紧邻使用处：`ExpressionStatementSyntax: LeagueAction(op,card.Id,origin:_deckSlots.GetValueOrDefault(card.Id));`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`_deckSlots.GetValueOrDefault(card.Id)`；返回值紧邻使用处：`ArgumentSyntax: origin:_deckSlots.GetValueOrDefault(card.Id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-669631bd65bf"></a>

## `NationalSpire.CareerScreen.DeckMotion(string, string, Godot.Vector2, int) — private async Task DeckMotion(string action,string id,Vector2 from,int version)`

来源：源码第 105 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Done()`](LeagueScreen.cs.md#symbol-d964f7e2b387)

**调用：** [`NationalSpire.LeagueCardFace.ShowCard(MegaCrit.Sts2.Core.Models.CardModel, int, Godot.Color, bool, MegaCrit.Sts2.Core.Nodes.Cards.NCard?)`](LeagueCardFace.cs.md#symbol-50215c17339c)；[`Visible(Godot.Vector2)`](LeagueDeckEditor.cs.md#symbol-dd8e3eaf50dc)；`Godot.Callable.From(System.Action)`；`Godot.Color.Color(string)`；`Godot.Control.GetGlobalRect()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.ToSignal(Godot.GodotObject, Godot.StringName)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.CreateTween()`；`Godot.Node.GetTree()`；`Godot.Node.IsInsideTree()`；`Godot.PropertyTweener.SetEase(Godot.Tween.EaseType)`；`Godot.PropertyTweener.SetTrans(Godot.Tween.TransitionType)`；`Godot.Rect2.GetCenter()`；`Godot.ScrollContainer.EnsureControlVisible(Godot.Control)`；`Godot.Tween.Chain()`；`Godot.Tween.SetParallel(bool)`；`Godot.Tween.TweenCallback(Godot.Callable)`；`Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.LeagueCardFace.LeagueCardFace()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._deckShelf`；`NationalSpire.CareerScreen._deckSlots`；`NationalSpire.CareerScreen._deckStrip`；`NationalSpire.CareerScreen._renderVersion`；`NationalSpire.CareerScreen._scroll`；`NationalSpire.CareerScreen._stage`；`NationalSpire.CareerScreen.SuitColors`；`NationalSpire.LeagueCardFace.ShowCard(MegaCrit.Sts2.Core.Models.CardModel, int, Godot.Color, bool, MegaCrit.Sts2.Core.Nodes.Cards.NCard?)`；`NationalSpire.LeagueCards.Catalog`；`NationalSpire.LeagueCards.Entry.Model`；`NationalSpire.LeagueCards.Entry.Tier`；`Visible(Godot.Vector2)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(flight.QueueFree)`；返回值紧邻使用处：`ArgumentSyntax: Callable.From(flight.QueueFree)`
- `Godot.Color.Color(string)`；输入表达式：`new Color(SuitColors[entry.Tier])`；返回值紧邻使用处：`ArgumentSyntax: new Color(SuitColors[entry.Tier])`
- `Godot.Control.GetGlobalRect()`；输入表达式：`_scroll.GetGlobalRect()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =_scroll.GetGlobalRect()`
- `Godot.Control.GetGlobalRect()`；输入表达式：`dest.GetGlobalRect()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: dest.GetGlobalRect().GetCenter`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_deckStrip)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(_deckStrip)`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(this)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(this)`
- `Godot.GodotObject.ToSignal(Godot.GodotObject, Godot.StringName)`；输入表达式：`ToSignal(GetTree(),SceneTree.SignalName.ProcessFrame)`；返回值紧邻使用处：`AwaitExpressionSyntax: await ToSignal(GetTree(),SceneTree.SignalName.ProcessFrame)`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_stage.AddChild(flight)`；返回值紧邻使用处：`ExpressionStatementSyntax: _stage.AddChild(flight);`
- `Godot.Node.CreateTween()`；输入表达式：`flight.CreateTween()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: flight.CreateTween().SetParallel`
- `Godot.Node.GetTree()`；输入表达式：`GetTree()`；返回值紧邻使用处：`ArgumentSyntax: GetTree()`
- `Godot.Node.IsInsideTree()`；输入表达式：`IsInsideTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInsideTree()`
- `Godot.PropertyTweener.SetEase(Godot.Tween.EaseType)`；输入表达式：`motion.TweenProperty(flight,"global_position",to-half,.44).SetTrans(Tween.TransitionType.Sine).SetEase(Tween.EaseType.InOut)`；返回值紧邻使用处：`ExpressionStatementSyntax: motion.TweenProperty(flight,"global_position",to-half,.44).SetTrans(Tween.TransitionType.Sine).SetEase(Tween.EaseType.InOut);`
- `Godot.PropertyTweener.SetTrans(Godot.Tween.TransitionType)`；输入表达式：`motion.TweenProperty(flight,"global_position",to-half,.44).SetTrans(Tween.TransitionType.Sine)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: motion.TweenProperty(flight,"global_position",to-half,.44).SetTrans(Tween.TransitionType.Sine).SetEase`
- `Godot.Rect2.GetCenter()`；输入表达式：`dest.GetGlobalRect().GetCenter()`；返回值紧邻使用处：`ArgumentSyntax: dest.GetGlobalRect().GetCenter()`
- `Godot.ScrollContainer.EnsureControlVisible(Godot.Control)`；输入表达式：`_deckStrip.EnsureControlVisible(slot)`；返回值紧邻使用处：`ExpressionStatementSyntax: _deckStrip.EnsureControlVisible(slot);`
- `Godot.Tween.Chain()`；输入表达式：`motion.Chain()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: motion.Chain().TweenCallback`
- `Godot.Tween.Chain()`；输入表达式：`motion.Chain()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: motion.Chain().TweenProperty`
- `Godot.Tween.SetParallel(bool)`；输入表达式：`flight.CreateTween().SetParallel()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =flight.CreateTween().SetParallel()`
- `Godot.Tween.TweenCallback(Godot.Callable)`；输入表达式：`motion.Chain().TweenCallback(Callable.From(flight.QueueFree))`；返回值紧邻使用处：`ExpressionStatementSyntax: motion.Chain().TweenCallback(Callable.From(flight.QueueFree));`
- `Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；输入表达式：`motion.Chain().TweenProperty(flight,"modulate:a",0,.12)`；返回值紧邻使用处：`ExpressionStatementSyntax: motion.Chain().TweenProperty(flight,"modulate:a",0,.12);`
- `Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；输入表达式：`motion.TweenProperty(flight,"global_position",to-half,.44)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: motion.TweenProperty(flight,"global_position",to-half,.44).SetTrans`
- `Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；输入表达式：`motion.TweenProperty(flight,"rotation",0,.42)`；返回值紧邻使用处：`ExpressionStatementSyntax: motion.TweenProperty(flight,"rotation",0,.42);`
- `Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；输入表达式：`motion.TweenProperty(flight,"scale",Vector2.One*.93f,.42)`；返回值紧邻使用处：`ExpressionStatementSyntax: motion.TweenProperty(flight,"scale",Vector2.One*.93f,.42);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0,-28)`；返回值紧邻使用处：`BinaryExpressionSyntax: to+new Vector2(0,-28)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(180,272)`；返回值紧邻使用处：`AssignmentExpressionSyntax: flight.Size=new(180,272)`
- `NationalSpire.LeagueCardFace.LeagueCardFace()`；输入表达式：`new LeagueCardFace{Name="LeagueMovingCard",MouseFilter=MouseFilterEnum.Ignore,ZIndex=90}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new LeagueCardFace{Name="LeagueMovingCard",MouseFilter=MouseFilterEnum.Ignore,ZIndex=90}`
- `NationalSpire.LeagueCardFace.ShowCard(MegaCrit.Sts2.Core.Models.CardModel, int, Godot.Color, bool, MegaCrit.Sts2.Core.Nodes.Cards.NCard?)`；输入表达式：`flight.ShowCard(entry.Model,entry.Tier,new Color(SuitColors[entry.Tier]),action=="upgrade")`；返回值紧邻使用处：`ExpressionStatementSyntax: flight.ShowCard(entry.Model,entry.Tier,new Color(SuitColors[entry.Tier]),action=="upgrade");`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_deckShelf.TryGetValue(id,out var shelf)`；返回值紧邻使用处：`ExpressionStatementSyntax: _deckShelf.TryGetValue(id,out var shelf);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_deckSlots.TryGetValue(id,out var slot)`；返回值紧邻使用处：`ExpressionStatementSyntax: _deckSlots.TryGetValue(id,out var slot);`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`LeagueCards.Catalog.TryGetValue(id,out var entry)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !LeagueCards.Catalog.TryGetValue(id,out var entry)`
- `Visible(Godot.Vector2)`；输入表达式：`Visible(dest.GetGlobalRect().GetCenter())`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Visible(dest.GetGlobalRect().GetCenter())`
- `Visible(Godot.Vector2)`；输入表达式：`Visible(from)`；返回值紧邻使用处：`AssignmentExpressionSyntax: from=Visible(from)`

**赋值（含属性/字段和局部值）：**

- `flight.GlobalPosition` = `from-half`
- `flight.PivotOffset` = `half`
- `flight.Rotation` = `action=="remove"?-.055f:.055f`
- `flight.Scale` = `Vector2.One*.72f`
- `flight.Size` = `new(180,272)`
- `from` = `to+new Vector2(0,-28)`
- `from` = `Visible(from)`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Name` = `"LeagueMovingCard"`
- `ZIndex` = `90`

<a id="symbol-dd8e3eaf50dc"></a>

## `Visible(Godot.Vector2) — Vector2 Visible(Vector2 p)`

来源：源码第 113 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DeckMotion(string, string, Godot.Vector2, int)`](LeagueDeckEditor.cs.md#symbol-669631bd65bf)

**调用：** `Godot.Vector2.Clamp(Godot.Vector2, Godot.Vector2)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Clamp(Godot.Vector2, Godot.Vector2)`；输入表达式：`p.Clamp(rect.Position+new Vector2(60,54),rect.End-new Vector2(60,54))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>p.Clamp(rect.Position+new Vector2(60,54),rect.End-new Vector2(60,54))`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(60,54)`；返回值紧邻使用处：`BinaryExpressionSyntax: rect.End-new Vector2(60,54)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(60,54)`；返回值紧邻使用处：`BinaryExpressionSyntax: rect.Position+new Vector2(60,54)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7d7f7f686ab1"></a>

## `NationalSpire.LeagueDeckStrip._Input(Godot.InputEvent) — public override void _Input(InputEvent e)`

来源：源码第 128 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.IsVisibleInTree()`；`Godot.Node.GetViewport()`；`Godot.Node.IsAncestorOf(Godot.Node)`；`Godot.Viewport.GuiGetHoveredControl()`；`Godot.Viewport.SetInputAsHandled()`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.IsVisibleInTree()`；输入表达式：`IsVisibleInTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsVisibleInTree()`
- `Godot.Node.GetViewport()`；输入表达式：`GetViewport()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetViewport().GuiGetHoveredControl`
- `Godot.Node.GetViewport()`；输入表达式：`GetViewport()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetViewport().SetInputAsHandled`
- `Godot.Node.IsAncestorOf(Godot.Node)`；输入表达式：`IsAncestorOf(hovered)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsAncestorOf(hovered)`
- `Godot.Viewport.GuiGetHoveredControl()`；输入表达式：`GetViewport().GuiGetHoveredControl()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =GetViewport().GuiGetHoveredControl()`
- `Godot.Viewport.SetInputAsHandled()`；输入表达式：`GetViewport().SetInputAsHandled()`；返回值紧邻使用处：`ExpressionStatementSyntax: GetViewport().SetInputAsHandled();`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1,(int)(86*w.Factor))`；返回值紧邻使用处：`BinaryExpressionSyntax: sign*Math.Max(1,(int)(86*w.Factor))`

**赋值（含属性/字段和局部值）：**

- `ScrollHorizontal` += `sign*Math.Max(1,(int)(86*w.Factor))`
