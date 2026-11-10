using Godot;

namespace NationalSpire;

internal static class OpeningClubEditor
{
    private static string? Sign(CareerData d,CareerClub club)
    {
        var offer=CareerCommerce.Quote(d,club);d.Esports.Offers.Add(offer);d.Esports.License=Math.Max(3,d.Esports.License);
        var error=EsportsWorld.AcceptOffer(d,offer);if(error!=null)d.Esports.Offers.Remove(offer);
        return error;
    }
    internal static async Task Choose(Control parent, CareerData d, CareerOpeningWorld plan)
    {
        if (plan.ClubMode is not ("加盟" or "自建")) return;
        var initialClubId=plan.ClubMode=="加盟" && plan.JoiningClub is { } pick && EsportsWorld.Club(d,pick.Id) is { } team && team.Name==pick.Name && team.Country==pick.Country ? team.Id : "";
        var host=LandscapeViewport.StageOf(parent);
        var previous=host.GetViewport().GuiGetFocusOwner();
        var done=new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
        var shade=new OpeningClubOverlay{Color=new(0,0,0,.76f),Name="OpeningClubOverlay",ZIndex=145,FocusBehaviorRecursive=Control.FocusBehaviorRecursiveEnum.Enabled,Dismiss=()=>done.TrySetResult(false)};
        var underlying=host.GetChildren().OfType<Control>().Where(c=>c.Visible).Select(c=>(c,c.FocusBehaviorRecursive)).ToArray();
        foreach(var (c,_) in underlying)c.FocusBehaviorRecursive=Control.FocusBehaviorRecursiveEnum.Disabled;
        host.AddChild(shade);shade.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect);
        var center=new CenterContainer();shade.AddChild(center);center.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect);
        var panel=new PanelContainer{CustomMinimumSize=new(1000,690)};panel.AddThemeStyleboxOverride("panel",CareerVisuals.Box("112230","385566",12,22));center.AddChild(panel);
        var body=new VBoxContainer();body.AddThemeConstantOverride("separation",10);panel.AddChild(body);
        var header=new HBoxContainer();header.AddThemeConstantOverride("separation",12);body.AddChild(header);
        header.AddChild(CareerScreen.Glyph("users-round",26,CareerVisuals.Gold));header.AddChild(new Label{Text=plan.ClubMode=="加盟"?"选择初始俱乐部":"创建俱乐部 · 安排阵容"});
        var intro = new Label { Text="初始资金  " + CareerMoney.Format(d.Credits) }; intro.AddThemeColorOverride("font_color",CareerVisuals.Gold); body.AddChild(intro);
        var status = new Label { AutowrapMode=TextServer.AutowrapMode.WordSmart }; body.AddChild(status);
        var region = EsportsWorld.Countries.Contains(plan.ClubCountry) ? plan.ClubCountry : d.Esports.Country;
        var draft = new ClubDraft { Region=region, Name=plan.ClubName, Sponsor=plan.ClubSponsor };
        var search = new LineEdit { PlaceholderText=plan.ClubMode=="自建" ? "自由市场 · 输入姓名可搜索全部 NPC" : "搜索俱乐部名称或赛区" }; body.AddChild(search);
        var scroll = new BroadcastScroll { SizeFlagsVertical=Control.SizeFlags.ExpandFill }; body.AddChild(scroll);
        var grid = new GridContainer { Columns=2, SizeFlagsHorizontal=Control.SizeFlags.ExpandFill }; grid.AddThemeConstantOverride("h_separation",10);grid.AddThemeConstantOverride("v_separation",8);scroll.AddChild(grid);
        string selectedClub = initialClubId; int page = 0;
        var nav = new HBoxContainer(); body.AddChild(nav);
        Button ButtonIn(Container row,string title,Action? click)
        {
            var b=new BroadcastButton { Text=title,CustomMinimumSize=new(100,40),SizeFlagsHorizontal=Control.SizeFlags.ExpandFill };
            row.AddChild(b); if(click!=null)b.Pressed+=click.Invoke; return b;
        }
        string seat="首发",term="steady";
        var rosterPane=new ScrollContainer{Visible=false,CustomMinimumSize=new(0,64),HorizontalScrollMode=ScrollContainer.ScrollMode.Disabled};body.AddChild(rosterPane);var roster = new HFlowContainer{SizeFlagsHorizontal=Control.SizeFlags.ExpandFill};rosterPane.AddChild(roster);
        var prev = ButtonIn(nav,"上一页",null); var pages=new Label(); nav.AddChild(pages);
        var next=ButtonIn(nav,"下一页",null);
        prev.Pressed+=()=>{page--; Render();}; next.Pressed+=()=>{page++; Render();};
        void Render()
        {
            CareerVisuals.ClearContent(grid); CareerVisuals.ClearContent(roster); var q=search.Text.Trim();
            int total;
            void Tile(string title,string details,string icon,bool chosen,Action select)=>OpeningControls.Card(grid,title,details,icon,chosen,select);
            if(plan.ClubMode=="加盟"){
                var clubs=d.Esports.Clubs.Where(c=>q.Length==0||(c.Country+c.Name).Contains(q,StringComparison.OrdinalIgnoreCase)).OrderByDescending(c=>c.Id==initialClubId).ThenByDescending(c=>c.Country==region).ThenBy(c=>c.Name).ToList();
                total=clubs.Count;page=Math.Clamp(page,0,Math.Max(0,(total-1)/10));
                foreach(var club in clubs.Skip(page*10).Take(10)){
                    var offer=CareerCommerce.Quote(d,club);
                    Tile(club.Name,$"{club.Country}赛区  ·  赛季薪资 {CareerMoney.Format(offer.SeasonPay)}","flag",selectedClub==club.Id,()=>{selectedClub=club.Id;Render();});
                }
                var selected=EsportsWorld.Club(d,selectedClub);
                if(selected==null)status.Text="选择俱乐部查看阵容与合同。";
                else {var o=CareerCommerce.Quote(d,selected);var names=d.People.Where(p=>p.ClubId==selectedClub&&EsportsWorld.IsProfessional(p)).OrderByDescending(p=>p.Rating).Take(5).Select(p=>p.PublicName);
                    status.Text=$"{selected.Name}    签约金 {CareerMoney.Format(o.SigningBonus)}    赛季薪资 {CareerMoney.Format(o.SeasonPay)}    胜场奖金 {CareerMoney.Format(o.WinBonus)}\n职业阵容    {string.Join("、",names)}";}
            }else{
                var humans=OwnedClubs.Humans(d);
                var people=(q.Length==0?OwnedClubs.Candidates(d):d.People.Where(p=>p.Id!="player"&&!humans.Contains(p.Id)&&(p.Name+" "+p.PublicName+" "+string.Join(" ",p.HandleAliases)).Contains(q,StringComparison.OrdinalIgnoreCase))).ToList();
                total=people.Count;page=Math.Clamp(page,0,Math.Max(0,(total-1)/10));rosterPane.Visible=draft.Signings.Count>0;
                foreach(var p in people.Skip(page*10).Take(10)){
                    var quote=OwnedClubs.Quote(p,term);
                    Tile(p.PublicName,$"{EsportsWorld.Club(d,p.ClubId)?.Name??"自由选手"}  ·  进阶 {p.MaxAscension}  ·  签约 {CareerMoney.Format(quote.Signing)}","contact-round",draft.Signings.Any(s=>s.PersonId==p.Id),()=>{
                        draft.Signings.RemoveAll(s=>s.PersonId==p.Id);draft.Signings.Add(new(){PersonId=p.Id,Plan=term,Position=seat});Render();});
                }
                foreach(var pick in draft.Signings.ToArray())ButtonIn(roster,pick.Position+" · "+CareerEngine.DisplayName(d,pick.PersonId)+" ×",()=>{draft.Signings.Remove(pick);Render();});
                var cost=OwnedClubs.InitialCost(d,draft);status.Text=$"{draft.Name}  ·  {draft.Region}赛区    注册与签约 {CareerMoney.Format(cost)}    结余 {CareerMoney.Format(CareerMoney.Balance(d)-cost)}";
            }
            int count=Math.Max(1,(total+9)/10);if(total==0)grid.AddChild(OpeningControls.Label("没有匹配的结果"));scroll.ScrollVertical=0;
            pages.Text=$"{page+1} / {count}"; prev.Disabled=page==0;next.Disabled=page+1==count;
        }
        if (plan.ClubMode=="自建")
        {
            var slots=new VBoxContainer(); body.AddChild(slots); body.MoveChild(slots,2);
            var positions=new HBoxContainer();slots.AddChild(positions);positions.AddChild(new Label{Text="签约席位",CustomMinimumSize=new(86,0)});var seatGroup=new ButtonGroup();
            foreach(var s in new[]{"首发","轮换","青训","教练"})OpeningControls.Chip(positions,seatGroup,s,s==seat,()=>seat=s);
            var contracts=new HBoxContainer();slots.AddChild(contracts);contracts.AddChild(new Label{Text="合同方案",CustomMinimumSize=new(86,0)});var termGroup=new ButtonGroup();
            foreach(var (id,name) in new[]{("steady","稳定合同"),("performance","成绩合同"),("growth","成长合同")})
                OpeningControls.Chip(contracts,termGroup,name,id==term,()=>{term=id;Render();});
        }
        search.TextChanged+=_=>{page=0;Render();}; Render();
        var actions=new HBoxContainer(); body.AddChild(actions);
        ButtonIn(actions,"返回开局设置",()=>done.TrySetResult(false));
        ButtonIn(actions,plan.ClubMode=="加盟" ? "确认加盟" : "确认建队",()=>{
            if(plan.ClubMode=="自建")
            {
                if(OwnedClubs.CreationError(d,draft,true) is { } err){status.Text=err;return;}
                OwnedClubs.CreateAtOpening(d,draft);
            }
            else
            {
                if(EsportsWorld.Club(d,selectedClub) is not { } club){status.Text="请选择一家俱乐部。";return;}
                if(Sign(d,club) is { } err){status.Text=err;return;}
            }
            done.TrySetResult(true);
        });
        shade.TreeExiting+=()=>done.TrySetResult(false);search.GrabFocus();
        try { if(!await done.Task) throw new OperationCanceledException("已返回开局设置。"); }
        finally { if(GodotObject.IsInstanceValid(shade))shade.QueueFree();foreach(var (c,focus) in underlying)if(GodotObject.IsInstanceValid(c))c.FocusBehaviorRecursive=focus;
            if(GodotObject.IsInstanceValid(previous)&&previous.IsVisibleInTree())previous.GrabFocus(); }
    }
}

internal partial class OpeningClubOverlay : ColorRect
{
    internal Action? Dismiss;
    public override void _Input(InputEvent e){
        if(e is InputEventKey{Pressed:true,Echo:false,Keycode:Key.Escape}){GetViewport().SetInputAsHandled();Dismiss?.Invoke();}
    }
}
