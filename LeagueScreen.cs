using Godot;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Commands;
using MegaCrit.Sts2.Core.Nodes.Audio;

namespace NationalSpire;

public partial class CareerScreen
{
    private static readonly string[] LeaguePages=["集卡","开包","收藏","交易","组卡","对战"];
    private static bool LeaguePage(string s)=>LeaguePages.Contains(s);
    private static readonly string[] SuitColors=["8faab5","68d7ec","f0bf6d","ed95ce"];
    private int _leaguePage;private string _leagueFilter="";
    private bool _leagueBusy;private string _leagueRival="";
    private HashSet<string>? _poolDraft;
    private static void LeagueSound(string sound){if(NAudioManager.Instance!=null)SfxCmd.Play(sound);}
    private void LeagueGo(string dest){_poolDraft=null;_leaguePage=0;_leagueFilter="";_deckQuery="";_deckOffset=0;OpenLifePage(dest);}
    private void LeagueAction(string action,string id="",int n=0,Control? origin=null){
        var source=action=="remove"?_deckSlots.GetValueOrDefault(id):action=="add"?_deckShelf.GetValueOrDefault(id):origin;
        var from=(source??origin)?.GetGlobalRect().GetCenter();var deckOffset=_deckStrip!=null&&IsInstanceValid(_deckStrip)?_deckStrip.ScrollHorizontal:0;
        var position=_scroll.ScrollVertical;var section=_lifeSection;
        void Done(){_deckOffset=action=="captain"?0:deckOffset;Render();if((action is "add" or "swap" or "remove" or "upgrade" or "downgrade" or "buy" or "sell")&&section==_lifeSection){
            _=RestoreScrollAsync(position,_renderVersion);if(from.HasValue&&section=="组卡")_=DeckMotion(action,action=="swap"?id.Split('|')[1]:id,from.Value,_renderVersion);}
            if(action=="pack"&&_lifeSection=="开包")LeagueReveal(ViewData.Life.League.Latest.ToArray(),true);
            if(action=="result"&&_lifeSection=="对战"&&ViewData.Life.League.LastDuel is {} receipt&&receipt.Fight.Match==System.Text.Json.JsonSerializer.Deserialize<LeagueFinish>(id)?.Match)LeagueAward(receipt);}
        if(MultiplayerCommand("league",action,id,n,accepted:Done))return;
        if(LeagueCards.Apply(ViewData,action,id,n) is {} err){Notice(err,true);return;}
        CareerStore.Save(ViewData);Done();
    }
    private static HBoxContainer LeagueRow(Control parent,int gap=12){var row=new HBoxContainer();row.AddThemeConstantOverride("separation",gap);parent.AddChild(row);return row;}
    private static Label LeagueNumber(string value,int width,Color color){
        var text=Text(value,18,color);text.AutowrapMode=TextServer.AutowrapMode.Off;
        text.CustomMinimumSize=new(width,0);text.HorizontalAlignment=HorizontalAlignment.Center;text.VerticalAlignment=VerticalAlignment.Center;return text;
    }
    private void LeagueMetric(Control row,string title,string value){
        var group=LeagueRow(row,8);group.AddChild(LeagueNumber(title,40,_muted));group.AddChild(LeagueNumber(value,70,_gold));
    }
    private void LeagueScreen(CareerData d){
        var nav=TabStrip(_content,24,secondary:true);
        foreach(var name in LeaguePages)nav.AddChild(UnderlineTab(name=="集卡"?"总览":name,()=>LeagueGo(name),_lifeSection==name,105));
        var album=d.Life.League;
        if(_lifeSection=="集卡"||_lifeSection=="开包"){
            bool opening=_lifeSection=="开包";
            var banner=new LeagueFoil{Wide=true,CustomMinimumSize=new(0,opening?270:300)};_content.AddChild(banner);
            var copy=new VBoxContainer{Position=new(42,32),CustomMinimumSize=new(620,0)};copy.AddThemeConstantOverride("separation",10);banner.AddChild(copy);
            copy.AddChild(Text("国运尖塔  /  职业联赛",16,_gold));
            copy.AddChild(Text(opening?"联赛典藏卡包":"尖塔藏牌馆",49,_ink));
            copy.AddChild(Text(opening?$"每包五张   ·   {LeagueCards.Pool(album).Length} 个职业与无色牌":"收录原画，构筑牌组，迎战联赛选手。",21,_muted));
            var actions=LeagueRow(copy);
            if(opening){
                foreach(int count in new[]{1,10}){var b=LeagueButton((count==1?"开启一包":"开启十包")+"   "+CareerMoney.Format(LeagueCards.PackCost*count),()=>LeagueAction("pack",n:count),235,kind:count==10?LeagueControl.Primary:LeagueControl.Action);b.Disabled=CareerMoney.Balance(d)<LeagueCards.PackCost*count;actions.AddChild(b);}
            }else actions.AddChild(LeagueButton("前往开包   →",()=>LeagueGo("开包"),200));
            if(opening){
                var line=LeagueRow(_content,26);LeagueMetric(line,"蓝卡保底",$"{album.BlueWait} / 10 包");LeagueMetric(line,"金卡保底",$"{album.GoldWait} / 80 包");
                line.AddChild(LeagueButton("编辑卡池",()=>{_poolDraft=LeagueCards.Pool(album).ToHashSet();Render();},158));
                if(_poolDraft is {} draft){
                    var panel=Card();_content.AddChild(panel);var box=Inner(panel);int min=Math.Min(6,LeagueCards.Roles.Length);
                    box.AddChild(Text($"卡包职业    {draft.Count} 已选    /    至少 {min} 个",23,_gold));
                    var roles=new HFlowContainer();box.AddChild(roles);
                    foreach(var role in LeagueCards.Roles){var id=role.Id.Entry;roles.AddChild(LeagueButton(LeagueCards.GroupName(id),()=>{if(!draft.Remove(id))draft.Add(id);Render();},155,draft.Contains(id),emblem:role.IconTexture));}
                    var footer=LeagueRow(box);var save=LeagueButton("保存卡池",()=>{var ids=System.Text.Json.JsonSerializer.Serialize(draft.Order().ToArray());_poolDraft=null;LeagueAction("pool",ids);},155,kind:LeagueControl.Primary);
                    save.Disabled=draft.Count<min;footer.AddChild(save);footer.AddChild(LeagueButton("取消",()=>{_poolDraft=null;Render();},110));
                }
                if(album.Latest.Any(LeagueCards.Catalog.ContainsKey)){
                    line.AddChild(LeagueButton("回顾上次开包",()=>LeagueReveal(album.Latest.ToArray()),180));
                    var results=album.Latest.Select(id=>LeagueCards.Catalog.GetValueOrDefault(id)).OfType<LeagueCards.Entry>();
                    LeagueGrid(results.OrderByDescending(card=>card.Tier),d,"回顾");
                }
            }else{
                var row=LeagueRow(_content,20);
                foreach(var (title,note,dest) in new[]{("我的图鉴",$"已收录 {album.Owned.Count(x=>x.Value>0)} 种","收藏"),("今日交易","查看今日在售单卡","交易"),("出战牌组",$"{LeagueCards.Deck(album)?.Values.Sum()??0} 张已编入","组卡"),("匹配对战","挑战联赛选手","对战")}){
                    var panel=Card();panel.SizeFlagsHorizontal=SizeFlags.ExpandFill;row.AddChild(panel);var body=Inner(panel);body.AddChild(Text(title,25,_gold));body.AddChild(Text(note,17,_muted));body.AddChild(LeagueButton("进入   →",()=>LeagueGo(dest),120));
                }
            }return;
        }
        if(_lifeSection=="对战"){LeagueArena(d);return;}
        if(_lifeSection=="组卡"){
            var roleRow=new HFlowContainer();_content.AddChild(roleRow);foreach(var role in LeagueCards.Roles){string id=role.Id.Entry;roleRow.AddChild(LeagueButton(LeagueCards.GroupName(id),()=>LeagueAction("captain",id),155,album.Captain==id,emblem:role.IconTexture));}
            if(LeagueCards.Deck(album) is {} deck){var counts=deck.Where(x=>LeagueCards.Catalog.ContainsKey(x.Key)).ToArray();int Count(Func<LeagueCards.Entry,bool> pred)=>counts.Where(x=>pred(LeagueCards.Catalog[x.Key])).Sum(x=>x.Value);
                if(!album.StandardDecks.Contains(album.Captain))_content.AddChild(LeagueButton("整理为新版 35 张牌组",()=>LeagueAction("captain",album.Captain),235));var row=LeagueRow(_content,14);LeagueMetric(row,"牌组",$"{deck.Values.Sum()} / {LeagueCards.DeckSize}");
                LeagueMetric(row,"蓝卡",$"{Count(c=>c.Tier==1)} / 10");LeagueMetric(row,"金卡",$"{Count(c=>c.Tier==2)} / 5");
                LeagueMetric(row,"先古",$"{Count(c=>c.Tier==3)} / 1");LeagueMetric(row,"无色",$"{Count(c=>c.Group=="COLORLESS")} / 5");DeckEditor(d,deck);return;}
        else{_content.AddChild(Text("选择出战职业，领取该职业的三十五张起始牌。",22,_gold));return;}
        }
        var filters=LeagueRow(_content);foreach(var tag in new[]{""}.Concat(LeagueCards.Grades)){filters.AddChild(LeagueButton(tag==""?"全部":tag,()=>{_leagueFilter=tag;_leaguePage=0;Render();},98,_leagueFilter==tag,tag==""?"8cc5c9":SuitColors[Array.IndexOf(LeagueCards.Grades,tag)],kind:LeagueControl.Filter));}
        IEnumerable<LeagueCards.Entry> list=_lifeSection=="交易"?LeagueCards.Offers(d):LeagueCards.Catalog.Values.Where(c=>album.Owned.GetValueOrDefault(c.Id)>0);
        if(_leagueFilter!="")list=list.Where(c=>LeagueCards.Grades[c.Tier]==_leagueFilter);
        LeagueGrid(list.OrderByDescending(c=>c.Tier).ThenBy(c=>c.Title),d,_lifeSection);
    }
    private int ShelfTop(Control page)=>Math.Max(0,(int)(_content.GetGlobalTransform().AffineInverse()*page.GlobalPosition).Y-60);
    private void LeagueGrid(IEnumerable<LeagueCards.Entry> source,CareerData d,string mode,Control? dest=null){
        dest??=_content;
        var all=source.ToArray();const int count=25;int pages=Math.Max(1,(all.Length+count-1)/count);_leaguePage=Math.Clamp(_leaguePage,0,pages-1);
        if(all.Length==0){dest.AddChild(Text(mode=="交易"?"今天还没有这种稀有度的挂牌。":mode=="组卡"&&_deckQuery.Length>0?"没有符合搜索条件的牌。":"还没有收录这类卡牌。",20,_muted));return;}
        var page=new VBoxContainer();dest.AddChild(page);
        if(pages>1){var viewport=_scroll;void FitPage()=>page.CustomMinimumSize=new(0,Math.Max(0,viewport.Size.Y-36));FitPage();viewport.Resized+=FitPage;page.TreeExiting+=()=>viewport.Resized-=FitPage;}var grid=new GridContainer{Columns=5};grid.AddThemeConstantOverride("h_separation",12);grid.AddThemeConstantOverride("v_separation",12);page.AddChild(grid);
        var a=d.Life.League;foreach(var c in all.Skip(_leaguePage*count).Take(count)){
            var tile=LeagueTile(c,out var body);grid.AddChild(tile);if(mode=="组卡")_deckShelf[c.Id]=body.GetChild<Control>(0);int owned=a.Owned.GetValueOrDefault(c.Id);
            var rail=new PanelContainer{SizeFlagsHorizontal=SizeFlags.ShrinkCenter};
            var plaque=CareerVisuals.Box("1d2b33","536069",16,2);plaque.BorderColor=new Color("33434a").Lerp(new Color(SuitColors[c.Tier]),.32f);rail.AddThemeStyleboxOverride("panel",plaque);body.AddChild(rail);
            var bar=LeagueRow(rail,2);bar.Alignment=BoxContainer.AlignmentMode.Center;bar.CustomMinimumSize=new(0,38);
            if(mode=="交易"){int price=LeagueCards.Ask(d,c);var b=LeagueButton(CareerMoney.Format(price),()=>LeagueAction("buy",c.Id),156,emblem:NavigationIcon("coins"));b.TooltipText="购买"+c.Title;b.Disabled=CareerMoney.Balance(d)<price;bar.AddChild(b);}
            else if(mode=="组卡"){int qty=LeagueCards.Deck(a)!.GetValueOrDefault(c.Id);
                bar.AddChild(LeagueNumber("持有 "+owned,76,_muted));
                var deck=LeagueCards.Deck(a)!;bool full=deck.Values.Sum()==LeagueCards.DeckSize;
                var add=full?DeckKey("swap","替换","用"+c.Title+"替换牌组中的一张牌",()=>DeckSwap(c,tile),qty<owned&&deck.Keys.Any(k=>LeagueCards.CanReplace(a,k,c)))
                    :DeckKey("add","加入","加入一张"+c.Title,()=>LeagueAction("add",c.Id,origin:tile),qty<owned&&LeagueCards.Limit(deck,c,role:a.Captain)==null);bar.AddChild(add);}
            else{bar.AddChild(LeagueNumber("持有 × "+owned,100,_muted));int sell=owned-LeagueCards.Reserved(a,c.Id);if(mode=="收藏"&&sell>0)bar.AddChild(LeagueButton("出售",()=>ConfirmLife("出售余卡",$"出售 {sell} 张{c.Title}，收入 {CareerMoney.Format((decimal)sell*LeagueCards.Bids[c.Tier])}。",()=>LeagueAction("sell",c.Id,sell)),85));}
        }
        void Turn(int n){
            int y=ShelfTop(page);_leaguePage=n;StoreFaces(page);dest.RemoveChild(page);page.QueueFree();
            if(mode=="组卡")_deckShelf.Clear();LeagueGrid(all,d,mode,dest);_=RestoreScrollAsync(y,_renderVersion);
        }
        if(pages>1){var bar=LeagueRow(page);var prev=LeagueButton("上一页",()=>Turn(_leaguePage-1),120);prev.Disabled=_leaguePage==0;bar.AddChild(prev);bar.AddChild(Text($"{_leaguePage+1} / {pages}",18,_muted));var next=LeagueButton("下一页",()=>Turn(_leaguePage+1),120);next.Disabled=_leaguePage+1==pages;bar.AddChild(next);}
    }
    // 只保留近期使用的原版卡面，按钮和价格始终读取当前存档。收藏与上方牌组可以同时展示同一张牌。
    private readonly LinkedList<((CardModel,bool) Key,MegaCrit.Sts2.Core.Nodes.Cards.NCard Face)> _recentFaces=new();
    private void StoreFaces(Control section){
        if(!IsInsideTree())return;
        foreach(var node in GetTree().GetNodesInGroup("NationalSpireLeagueCards")){
            if(node is not LeagueCardFace face||!section.IsAncestorOf(face)||face.Detach() is not {} native)continue;
            _recentFaces.AddFirst((face.Identity,native));
        }
        while(_recentFaces.Count>2*25+LeagueCards.DeckSize){_recentFaces.Last!.Value.Face.QueueFree();_recentFaces.RemoveLast();}
    }
    private MegaCrit.Sts2.Core.Nodes.Cards.NCard? TakeFace(CardModel model,bool upgraded){
        for(var n=_recentFaces.First;n!=null;n=n.Next)if(n.Value.Key==(model,upgraded)){_recentFaces.Remove(n);return n.Value.Face;}
        return null;
    }
    private PanelContainer LeagueTile(LeagueCards.Entry card,out VBoxContainer body,bool upgraded=false,Action? inspectAction=null){
        var tile=new PanelContainer{SizeFlagsHorizontal=SizeFlags.ExpandFill,CustomMinimumSize=new(185,0)};
        var ink=new Color(SuitColors[card.Tier]);
        var mat=new StyleBoxEmpty();mat.ContentMarginLeft=mat.ContentMarginRight=5;mat.ContentMarginTop=8;mat.ContentMarginBottom=5;
        tile.AddThemeStyleboxOverride("panel",mat);
        body=new VBoxContainer();body.AddThemeConstantOverride("separation",6);tile.AddChild(body);
        var display=new LeagueCardFace();body.AddChild(display);display.AddToGroup("NationalSpireLeagueCards");display.ShowCard(card.Model,card.Tier,new Color(SuitColors[card.Tier]),upgraded,TakeFace(card.Model,upgraded));
        var inspect=new Button{Flat=true,MouseDefaultCursorShape=CursorShape.PointingHand,TooltipText="放大查看 · "+card.Title+(card.PartyHint.Length>0?"\n"+card.PartyHint:"")};
        inspect.AddThemeStyleboxOverride("normal",new StyleBoxEmpty());inspect.AddThemeStyleboxOverride("hover",new StyleBoxEmpty());
        display.AddChild(inspect);inspect.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);inspect.MouseEntered+=()=>display.Highlight(true);inspect.MouseExited+=()=>display.Highlight(false);
        inspect.FocusEntered+=()=>display.Highlight(true);inspect.FocusExited+=()=>display.Highlight(false);
        inspect.Pressed+=inspectAction??(()=>LeagueInspect(card,upgraded));return tile;
    }
    private void LeagueInspect(LeagueCards.Entry card,bool upgraded=false){
        var shade=new ColorRect{Name="LeagueCardInspection",Color=new Color("09111bea"),MouseFilter=MouseFilterEnum.Stop,ZIndex=110};(_dialogOverlay??_stage).AddChild(shade);shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        var center=new CenterContainer();shade.AddChild(center);center.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        var column=new VBoxContainer();column.AddThemeConstantOverride("separation",16);center.AddChild(column);
        if(card.PartyHint.Length>0)column.AddChild(LeagueNumber(card.PartyHint,320,_gold));
        var face=new LeagueCardFace();column.AddChild(face);face.ShowCard(card.Model,card.Tier,new Color(SuitColors[card.Tier]),upgraded);face.CustomMinimumSize=new(400,558);
        var close=LeagueButton("返回",()=>shade.QueueFree(),155,kind:LeagueControl.Back);column.AddChild(close);close.GrabFocus();
        shade.GuiInput+=e=>{if(e is InputEventMouseButton {Pressed:true,ButtonIndex:MouseButton.Left})shade.QueueFree();};
    }
    private static readonly AudioStreamMP3?[] PackSounds=new AudioStreamMP3?[3];
    private static void PlayPackSound(Control parent,int tier){
        int i=Math.Min(2,tier);
        if(PackSounds[i]==null){
            var file=new[]{"white","blue","gold"}[i];
            using var input=typeof(CareerScreen).Assembly.GetManifestResourceStream($"NationalSpire.CardPacks.{file}.mp3")!;
            using var data=new MemoryStream();input.CopyTo(data);PackSounds[i]=new AudioStreamMP3{Data=data.ToArray()};
        }
        var settings=MegaCrit.Sts2.Core.Saves.SaveManager.Instance.SettingsSave;
        var volume=settings.VolumeMaster*settings.VolumeSfx;if(volume<=0)return;
        var player=new AudioStreamPlayer{Stream=PackSounds[i],VolumeDb=Mathf.LinearToDb(volume*volume)};parent.AddChild(player);player.Finished+=player.QueueFree;player.Play();
    }
    private void LeagueReveal(string[] ids,bool opening=false){
        int HighestFrom(int start)=>ids.Skip(start).Where(LeagueCards.Catalog.ContainsKey).Select(id=>LeagueCards.Catalog[id].Tier).DefaultIfEmpty(-1).Max();
        int highest=HighestFrom(0);
        int highestHeard=-1;
        var overlay=new ColorRect{Color=new Color("0b141df8"),MouseFilter=MouseFilterEnum.Stop,ZIndex=100};_stage.AddChild(overlay);overlay.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        var frame=new CenterContainer();overlay.AddChild(frame);frame.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        var stack=new VBoxContainer();stack.AddThemeConstantOverride("separation",28);frame.AddChild(stack);
        stack.AddChild(Text("联赛典藏    /    开包揭晓",29,_gold));var row=LeagueRow(stack,18);var buttons=LeagueRow(stack);
        int index=0;var tweens=new List<Tween>();void Reveal(){
            foreach(var t in tweens)t.Kill();tweens.Clear();CareerVisuals.ClearContent(row);
            foreach(string id in ids.Skip(index).Take(5)){
                if(!LeagueCards.Catalog.TryGetValue(id,out var card))continue;
                var slot=new Control{CustomMinimumSize=new(218,310)};row.AddChild(slot);
                var face=LeagueTile(card,out _);slot.AddChild(face);face.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);face.PivotOffset=new(109,155);face.Scale=new(.01f,1);face.Hide();
                var back=new LeagueFoil{Ink=new Color(SuitColors[card.Tier])};slot.AddChild(back);back.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);back.PivotOffset=new(109,155);
                int pos=row.GetChildCount()-1;var t=slot.CreateTween();tweens.Add(t);t.TweenInterval((index==0?1.1:.18)+pos*.19+(card.Tier>1?.24:0));t.TweenProperty(back,"scale:x",.01,.15);t.TweenCallback(Callable.From(()=>{
                    back.Hide();face.Show();
                    if(opening){PlayPackSound(_stage,card.Tier);highestHeard=Math.Max(highestHeard,card.Tier);}
                    if(card.Tier>0){var dust=new LeagueSeal{Burst=true,Ink=new Color(SuitColors[card.Tier]),MouseFilter=MouseFilterEnum.Ignore};slot.AddChild(dust);dust.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);}
                }));t.TweenProperty(face,"scale:x",1,.24).SetTrans(Tween.TransitionType.Cubic).SetEase(Tween.EaseType.Out);
            }CareerVisuals.ClearContent(buttons);buttons.AddChild(Text($"{index/5+1} / {(ids.Length+4)/5} 包",20,_muted));if(index+5<ids.Length)buttons.AddChild(LeagueButton("开启下一包",()=>{index+=5;Reveal();},180));buttons.AddChild(LeagueButton("查看全部",ShowAll,160));
        }
        void ShowAll(){
            if(overlay.IsQueuedForDeletion())return;
            overlay.QueueFree();
            foreach(var t in tweens)t.Kill();
            if(opening){
                int remaining=index==0?highest:HighestFrom(index);
                if(remaining>highestHeard)PlayPackSound(_stage,remaining);
            }
        }
        Reveal();
        var seal=new LeagueSeal{Ink=new Color(SuitColors[Math.Max(0,highest)]),MouseFilter=MouseFilterEnum.Ignore};
        overlay.AddChild(seal);seal.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
    }
}
