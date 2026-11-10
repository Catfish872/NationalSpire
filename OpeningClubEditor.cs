using Godot;

namespace NationalSpire;

internal static class OpeningClubEditor
{
    internal static async Task Choose(Control parent, CareerData d, CareerOpeningWorld plan)
    {
        if (plan.ClubMode is not ("加盟" or "自建")) return;
        var window = new Window { Title=plan.ClubMode == "加盟" ? "选择初始俱乐部" : "创建俱乐部 · 安排阵容", Exclusive=true, Transient=true, Theme=parent.Theme };
        var done = new TaskCompletionSource<bool>();
        var panel = new PanelContainer(); panel.AddThemeStyleboxOverride("panel",CareerVisuals.Box("112230","385566",12,22));
        window.AddChild(panel); panel.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect);
        var body = new VBoxContainer(); body.AddThemeConstantOverride("separation",10); panel.AddChild(body);
        var intro = new Label { Text="初始资金  " + CareerMoney.Format(d.Credits) }; intro.AddThemeColorOverride("font_color",CareerVisuals.Gold); body.AddChild(intro);
        var status = new Label { AutowrapMode=TextServer.AutowrapMode.WordSmart }; body.AddChild(status);
        var region = EsportsWorld.Countries.Contains(plan.ClubCountry) ? plan.ClubCountry : d.Esports.Country;
        var draft = new ClubDraft { Region=region, Name=plan.ClubName, Sponsor=plan.ClubSponsor };
        var search = new LineEdit { PlaceholderText=plan.ClubMode=="自建" ? "自由市场 · 输入姓名可搜索全部 NPC" : "搜索俱乐部名称或赛区" }; body.AddChild(search);
        var scroll = new BroadcastScroll { SizeFlagsVertical=Control.SizeFlags.ExpandFill }; body.AddChild(scroll);
        var grid = new GridContainer { Columns=2, SizeFlagsHorizontal=Control.SizeFlags.ExpandFill }; scroll.AddChild(grid);
        string selectedClub = d.Esports.Clubs.FirstOrDefault(c => c.Name == plan.ClubName && c.Country == region)?.Id ?? ""; int page = 0;
        var nav = new HBoxContainer(); body.AddChild(nav);
        Button ButtonIn(Container row,string title,Action? click)
        {
            var b=new BroadcastButton { Text=title,CustomMinimumSize=new(100,40),SizeFlagsHorizontal=Control.SizeFlags.ExpandFill };
            row.AddChild(b); if(click!=null)b.Pressed+=click.Invoke; return b;
        }
        var slots = new HBoxContainer(); var seat = new OptionButton(); var contract=new OptionButton();
        if (plan.ClubMode=="自建")
        {
            body.AddChild(slots); body.MoveChild(slots,2);
            foreach(var s in new[]{"首发","轮换","青训","教练"}) seat.AddItem(s);
            foreach(var s in new[]{"稳定合同","成绩合同","成长合同"}) contract.AddItem(s);
            slots.AddChild(seat); slots.AddChild(contract);
        }
        var roster = new HFlowContainer(); body.AddChild(roster);
        var prev = ButtonIn(nav,"上一页",null); var pages=new Label(); nav.AddChild(pages);
        var next=ButtonIn(nav,"下一页",null);
        prev.Pressed+=()=>{page--; Render();}; next.Pressed+=()=>{page++; Render();};
        void Render()
        {
            CareerVisuals.ClearContent(grid); CareerVisuals.ClearContent(roster); var q=search.Text.Trim();
            var choices=new List<(string Title,string Detail,Action Select)>();
            if(plan.ClubMode=="加盟")
            {
                foreach(var club in d.Esports.Clubs.Where(c=>q.Length==0 || (c.Country+c.Name).Contains(q,StringComparison.OrdinalIgnoreCase))
                            .OrderByDescending(c=>c.Name==plan.ClubName).ThenByDescending(c=>c.Country==region).ThenBy(c=>c.Name))
                {
                    choices.Add((club.Name,club.Country+"赛区",()=>{ selectedClub=club.Id; Render(); }));
                }
                var current=EsportsWorld.Club(d,selectedClub);
                status.Text=current==null ? "选择要代表的俱乐部" : "已选择  "+current.Name+" · "+current.Country+"赛区";
            }
            else
            {
                var people=q.Length==0 ? OwnedClubs.Candidates(d) : d.People.Where(p=>!OwnedClubs.Humans(d).Contains(p.Id) && p.Id!="player" &&
                    (p.Name+" "+p.PublicName+" "+string.Join(" ",p.HandleAliases)).Contains(q,StringComparison.OrdinalIgnoreCase));
                foreach(var person in people)
                {
                    var p=person; var term=new[]{"steady","performance","growth"}[contract.Selected];
                    choices.Add((p.PublicName,EsportsWorld.Club(d,p.ClubId)?.Name ?? "自由选手",()=>{
                        draft.Signings.RemoveAll(s=>s.PersonId==p.Id);
                        draft.Signings.Add(new(){PersonId=p.Id,Plan=term,Position=seat.GetItemText(seat.Selected)}); Render();
                    }));
                }
                foreach(var pick in draft.Signings.ToArray()) ButtonIn(roster,pick.Position+" · "+CareerEngine.DisplayName(d,pick.PersonId)+" ×",()=>{draft.Signings.Remove(pick);Render();});
                status.Text=$"{draft.Name}  ·  {draft.Region}赛区    注册与签约合计  {CareerMoney.Format(OwnedClubs.InitialCost(d,draft))}";
            }
            int count=Math.Max(1,(choices.Count+9)/10);page=Math.Clamp(page,0,count-1);
            foreach(var c in choices.Skip(page*10).Take(10)) ButtonIn(grid,c.Title+"\n"+c.Detail,c.Select);
            pages.Text=$"{page+1} / {count}"; prev.Disabled=page==0;next.Disabled=page+1==count;
        }
        search.TextChanged+=_=>{page=0;Render();}; contract.ItemSelected+=_=>Render(); Render();
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
                var offer=CareerCommerce.Quote(d,club);d.Esports.Offers.Add(offer);d.Esports.License=Math.Max(3,d.Esports.License);
                if(EsportsWorld.AcceptOffer(d,offer) is { } err){status.Text=err;return;}
            }
            done.TrySetResult(true);
        });
        window.CloseRequested+=()=>done.TrySetResult(false);window.TreeExiting+=()=>done.TrySetResult(false);
        parent.AddChild(window); window.PopupCenteredClamped(new(820,620));
        try { if(!await done.Task) throw new OperationCanceledException("已返回开局设置。"); }
        finally { if(GodotObject.IsInstanceValid(window)) window.QueueFree(); }
    }
}
