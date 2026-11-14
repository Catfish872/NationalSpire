using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private string _deckQuery="";
    private int _deckOffset;
    private ScrollContainer? _deckStrip;
    private readonly Dictionary<string,Control> _deckSlots=[],_deckShelf=[];
    private static readonly Dictionary<string,Texture2D> DeckIcons=[];
    private static Texture2D DeckIcon(string action){
        if(DeckIcons.TryGetValue(action,out var icon))return icon;
        string paths=action switch{
            "upgrade"=>"<path d='m5 20 8-9 2 2-8 9z M10 6l4-4 7 6-4 4-2-2-2 2-4-4 2-2z' fill='currentColor'/>",
            "downgrade"=>"<path d='M9 5 4 10l5 5M5 10h9a5 5 0 0 1 0 10h-3'/>",
            "add"=>"<path d='M4 14v6h16v-6M12 3v12m-5-5 5 5 5-5'/>",
            "swap"=>"<path d='M3 8h16m-4-4 4 4-4 4M21 16H5m4-4-4 4 4 4'/>",
            _=>"<path d='M4 14v6h16v-6M12 15V3m-5 5 5-5 5 5'/>"};
        var im=new Image();im.LoadSvgFromString("<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='28' height='28' color='white' fill='none' stroke='white' stroke-linecap='round' stroke-linejoin='round' stroke-width='1.8'>"+paths+"</svg>");
        return DeckIcons[action]=ImageTexture.CreateFromImage(im);
    }
    private void DeckSwap(LeagueCards.Entry next,Control origin){
        var a=ViewData.Life.League;var deck=LeagueCards.Deck(a)!;
        var shade=new ColorRect{Color=new Color("09111bf2"),MouseFilter=MouseFilterEnum.Stop,ZIndex=120};_stage.AddChild(shade);shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        var center=new CenterContainer();shade.AddChild(center);center.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        var pane=new VBoxContainer();center.AddChild(pane);pane.AddThemeConstantOverride("separation",16);
        pane.AddChild(Text("选择要移出的牌",32,_gold));var strip=LeagueRow(pane,30);
        var left=new VBoxContainer();strip.AddChild(left);var face=new LeagueCardFace();left.AddChild(face);face.ShowCard(next.Model,next.Tier,new Color(SuitColors[next.Tier]));face.CustomMinimumSize=new(235,326);
        left.AddChild(LeagueNumber("加入一张   ·   "+next.Title,235,_gold));
        var scroll=new ScrollContainer{CustomMinimumSize=new(510,352),HorizontalScrollMode=ScrollContainer.ScrollMode.Disabled};strip.AddChild(scroll);
        var options=new VBoxContainer{SizeFlagsHorizontal=SizeFlags.ExpandFill};scroll.AddChild(options);options.AddThemeConstantOverride("separation",6);
        foreach(var id in deck.Keys.Where(k=>LeagueCards.CanReplace(a,k,next)).OrderBy(k=>LeagueCards.Catalog.GetValueOrDefault(k)?.Title??k,StringComparer.CurrentCulture)){
            var old=LeagueCards.Catalog.GetValueOrDefault(id);string title=old?.Title??id;int refund=old!=null&&LeagueCards.Upgraded(a,id)==deck[id]?LeagueCards.UpgradeCost(old):0;
            var key=LeagueButton(title+"   × "+deck[id]+(refund>0?"     返还 "+refund+" 点":""),()=>{shade.QueueFree();LeagueAction("swap",id+"|"+next.Id,origin:origin);},420,accent:old==null?"90c7ca":SuitColors[old.Tier]);
            key.TooltipText="移出一张"+title+"，加入一张"+next.Title;options.AddChild(key);
        }
        var cancel=LeagueButton("返回",shade.QueueFree,100,kind:LeagueControl.Back);cancel.SizeFlagsHorizontal=SizeFlags.ShrinkEnd;pane.AddChild(cancel);cancel.GrabFocus();
    }
    private static Button DeckKey(string action,string title,string hint,Action pressed,bool enabled){
        var key=LeagueButton(title,pressed,85,accent:action=="upgrade"?"ebc680":"90c7ca",emblem:DeckIcon(action));key.CustomMinimumSize=new(85,35);
        key.AddThemeConstantOverride("icon_max_width",19);key.AddThemeConstantOverride("h_separation",4);
        key.TooltipText=hint;key.AccessibilityName=hint;key.Disabled=!enabled;return key;
    }
    private void DeckEditor(CareerData d,Dictionary<string,int> deck){
        var a=d.Life.League;_deckSlots.Clear();_deckShelf.Clear();
        var head=LeagueRow(_content,18);head.AddChild(Text("出战牌组",25,_gold));
        int used=LeagueCards.Points(a);head.AddChild(Text($"升级点   {used} / {LeagueCards.UpgradeBudget}",18,_ink));
        head.AddChild(Text("白卡、蓝卡 1 点   ·   金卡、先古 2 点",16,_muted));
        var strip=new LeagueDeckStrip{CustomMinimumSize=new(0,356),VerticalScrollMode=ScrollContainer.ScrollMode.Disabled};
        _deckStrip=strip;_content.AddChild(strip);var row=LeagueRow(strip,12);
        foreach(var (id,count) in deck.OrderBy(p=>LeagueCards.Catalog.GetValueOrDefault(p.Key)?.Title,StringComparer.CurrentCulture)){
            if(!LeagueCards.Catalog.TryGetValue(id,out var c)){
                row.AddChild(LeagueButton(id+" × "+count,()=>LeagueAction("remove",id),180));continue;
            }
            int up=LeagueCards.Upgraded(a,id);
            var cell=LeagueTile(c,out var column,up>0,()=>LeagueInspect(c,up>0));cell.SizeFlagsHorizontal=SizeFlags.ShrinkBegin;row.AddChild(cell);
            var face=column.GetChild<Control>(0);face.CustomMinimumSize=new(186,248);_deckSlots[id]=face;
            var stats=LeagueRow(column,16);stats.Alignment=BoxContainer.AlignmentMode.Center;
            void CountMark(Texture2D icon,string hint,int value,Color ink){
                var item=LeagueRow(stats,4);item.TooltipText=hint;item.AccessibilityName=hint+" "+value;
                item.AddChild(new TextureRect{Texture=icon,Modulate=ink,CustomMinimumSize=new(20,20),ExpandMode=TextureRect.ExpandModeEnum.IgnoreSize,StretchMode=TextureRect.StretchModeEnum.KeepAspectCentered,MouseFilter=MouseFilterEnum.Ignore});
                item.AddChild(LeagueNumber(value.ToString(),19,ink));
            }
            CountMark(NavigationIcon("layers")!,"入组张数",count,_ink);CountMark(DeckIcon("upgrade"),"已升级张数",up,up>0?_gold:_muted);
            var bar=LeagueRow(column,5);bar.Alignment=BoxContainer.AlignmentMode.Center;
            bool fixedCard=LeagueCards.Fixed(c,a.Captain)>0;
            bar.AddChild(DeckKey("remove",fixedCard?"固定":"移出",fixedCard?"基础牌固定占位，可以锻造。":"移出一张"+c.Title,()=>LeagueAction("remove",id,origin:face),!fixedCard));
            var upgrade=DeckKey("upgrade","锻造","查看"+c.Title+"的升级与点数",()=>DeckSmith(c),c.Model.MaxUpgradeLevel>0);
            bar.AddChild(upgrade);
        }
        if(deck.Count==0)row.AddChild(Text("从下方收藏中添加第一张牌。",18,_muted));
        strip.SetDeferred(ScrollContainer.PropertyName.ScrollHorizontal,_deckOffset);
        var tools=LeagueRow(_content,15);tools.AddChild(Text("我的收藏",24,_ink));
        var search=new LineEdit{Name="LeagueDeckSearch",Text=_deckQuery,PlaceholderText="搜索牌名或效果",ClearButtonEnabled=true,CustomMinimumSize=new(260,42)};
        tools.AddChild(search);
        foreach(var tag in new[]{""}.Concat(LeagueCards.Grades))
            tools.AddChild(LeagueButton(tag==""?"全部":tag,()=>{int y=ShelfTop(tools)+60;_deckOffset=strip.ScrollHorizontal;_leagueFilter=tag;_leaguePage=0;Render();_=RestoreScrollAsync(y,_renderVersion);},77,_leagueFilter==tag,tag==""?"8cc5c9":SuitColors[Array.IndexOf(LeagueCards.Grades,tag)],kind:LeagueControl.Filter));
        var shelf=new VBoxContainer();_content.AddChild(shelf);
        var owned=LeagueCards.Catalog.Values.Where(c=>a.Owned.GetValueOrDefault(c.Id)>0&&LeagueCards.Usable(c,a.Captain))
            .Where(c=>_leagueFilter.Length==0||LeagueCards.Grades[c.Tier]==_leagueFilter)
            .OrderByDescending(c=>c.Tier).ThenBy(c=>c.Title,StringComparer.CurrentCulture).ToArray();
        void Browse(){
            StoreFaces(shelf);CareerVisuals.ClearContent(shelf);_deckShelf.Clear();string q=_deckQuery.Trim();
            LeagueGrid(owned.Where(c=>q.Length==0||c.Title.Contains(q,StringComparison.CurrentCultureIgnoreCase)||c.Model.Description.GetRawText().Contains(q,StringComparison.CurrentCultureIgnoreCase)),d,"组卡",shelf);
        }
        search.TextChanged+=q=>{_deckQuery=q;_leaguePage=0;Browse();};Browse();
    }
    private void DeckSmith(LeagueCards.Entry card){
        var a=ViewData.Life.League;int qty=LeagueCards.Deck(a)!.GetValueOrDefault(card.Id),up=LeagueCards.Upgraded(a,card.Id),cost=LeagueCards.UpgradeCost(card);
        var shade=new ColorRect{Color=new Color("09111bf2"),MouseFilter=MouseFilterEnum.Stop,ZIndex=120};_stage.AddChild(shade);shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        var center=new CenterContainer();shade.AddChild(center);center.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        var content=new VBoxContainer();center.AddChild(content);content.AddThemeConstantOverride("separation",12);
        content.AddChild(Text(card.Title+"   ·   锻造",32,_gold));var pair=LeagueRow(content,28);
        foreach(bool next in new[]{false,true}){var column=new VBoxContainer();pair.AddChild(column);var face=new LeagueCardFace();column.AddChild(face);
            face.ShowCard(card.Model,card.Tier,new Color(SuitColors[card.Tier]),next);face.CustomMinimumSize=new(245,338);
            column.AddChild(LeagueNumber(next?"升级后":"原牌",180,next?_gold:_muted));}
        content.AddChild(LeagueNumber($"入组 {qty} 张    ·    已升级 {up} 张    ·    剩余 {LeagueCards.UpgradeBudget-LeagueCards.Points(a)} 点",360,_ink));
        var actions=LeagueRow(content,10);actions.Alignment=BoxContainer.AlignmentMode.Center;
        void Apply(string op){shade.QueueFree();LeagueAction(op,card.Id,origin:_deckSlots.GetValueOrDefault(card.Id));}
        actions.AddChild(DeckKey("upgrade",$"升级一张 · {cost} 点","升级一张"+card.Title+"，消耗 "+cost+" 点",()=>Apply("upgrade"),up<qty&&LeagueCards.Points(a)+cost<=LeagueCards.UpgradeBudget));
        actions.AddChild(DeckKey("downgrade","撤销一张","撤销一张升级，返还点数",()=>Apply("downgrade"),up>0));
        var close=LeagueButton("返回",shade.QueueFree,90,kind:LeagueControl.Back);actions.AddChild(close);close.GrabFocus();
    }
    private async Task DeckMotion(string action,string id,Vector2 from,int version){
        await ToSignal(GetTree(),SceneTree.SignalName.ProcessFrame);
        if(!IsInstanceValid(this)||!IsInsideTree()||_renderVersion!=version||_deckStrip==null||!IsInstanceValid(_deckStrip)||!LeagueCards.Catalog.TryGetValue(id,out var entry))return;
        _deckSlots.TryGetValue(id,out var slot);_deckShelf.TryGetValue(id,out var shelf);
        if(slot!=null)_deckStrip.EnsureControlVisible(slot);
        await ToSignal(GetTree(),SceneTree.SignalName.ProcessFrame);
        if(!IsInstanceValid(this)||!IsInsideTree()||_renderVersion!=version)return;
        var dest=(action=="remove"?shelf:slot)??_deckStrip;
        var rect=_scroll.GetGlobalRect();Vector2 Visible(Vector2 p)=>p.Clamp(rect.Position+new Vector2(60,54),rect.End-new Vector2(60,54));
        Vector2 to=Visible(dest.GetGlobalRect().GetCenter());from=Visible(from);
        var flight=new LeagueCardFace{Name="LeagueMovingCard",MouseFilter=MouseFilterEnum.Ignore,ZIndex=90};_stage.AddChild(flight);
        flight.ShowCard(entry.Model,entry.Tier,new Color(SuitColors[entry.Tier]),action=="upgrade");
        flight.Size=new(180,272);var half=flight.Size*.5f;flight.PivotOffset=half;
        if(action is "upgrade" or "downgrade")from=to+new Vector2(0,-28);
        flight.GlobalPosition=from-half;flight.Scale=Vector2.One*.72f;flight.Rotation=action=="remove"?-.055f:.055f;
        var motion=flight.CreateTween().SetParallel();motion.TweenProperty(flight,"global_position",to-half,.44).SetTrans(Tween.TransitionType.Sine).SetEase(Tween.EaseType.InOut);
        motion.TweenProperty(flight,"scale",Vector2.One*.93f,.42);motion.TweenProperty(flight,"rotation",0,.42);
        motion.Chain().TweenProperty(flight,"modulate:a",0,.12);motion.Chain().TweenCallback(Callable.From(flight.QueueFree));
    }
}

// 横向牌架独占指针下的滚轮。到达端点时也消费本次输入，其他区域继续由纵向容器处理。
internal partial class LeagueDeckStrip : ScrollContainer {
    public override void _Input(InputEvent e){
        if(!IsVisibleInTree()||e is not InputEventMouseButton {Pressed:true} w || w.ButtonIndex is not (MouseButton.WheelUp or MouseButton.WheelDown or MouseButton.WheelLeft or MouseButton.WheelRight))return;
        var hovered=GetViewport().GuiGetHoveredControl();if(hovered==null||hovered!=this&&!IsAncestorOf(hovered))return;
        int sign=w.ButtonIndex is MouseButton.WheelUp or MouseButton.WheelLeft?-1:1;
        ScrollHorizontal+=sign*Math.Max(1,(int)(86*w.Factor));GetViewport().SetInputAsHandled();
    }
}
