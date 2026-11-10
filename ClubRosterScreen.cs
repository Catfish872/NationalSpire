using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private static readonly string[] RosterPositions = ["首发","教练","轮换","青训"];

    private void RosterMembers(CareerData data, OwnedClubState club)
    {
        var humans = OwnedClubs.Humans(data).ToHashSet();
        foreach (string role in RosterPositions)
        {
            var ids = OwnedClubs.PositionList(club,role).ToList();
            if (role=="教练" && ClubCoaching.PlayerCoach(data) && !ids.Contains("player")) ids.Insert(0,"player");
            var panel = new PanelContainer();
            var surface = CareerVisuals.Box("152534","334958",8,24);
            surface.ContentMarginTop = surface.ContentMarginBottom = 20;
            panel.AddThemeStyleboxOverride("panel",surface);
            panel.Draw += () => panel.DrawLine(new(17,1),new(63,1),new Color("799aa5"),2);
            _content.AddChild(panel);
            var group = new VBoxContainer(); group.AddThemeConstantOverride("separation",0); panel.AddChild(group);
            var heading = new HBoxContainer(); heading.AddThemeConstantOverride("separation",8); group.AddChild(heading);
            var title = DashboardLabel(role,23,_gold); title.SizeFlagsHorizontal=SizeFlags.ShrinkBegin; heading.AddChild(title);
            var count = DashboardLabel("/ "+ids.Count+" 人", 18, _muted); heading.AddChild(count);
            if (role == "教练")
            {
                count.SizeFlagsHorizontal = SizeFlags.ShrinkBegin;
                heading.AddChild(new Control { CustomMinimumSize = new(8, 0), MouseFilter = MouseFilterEnum.Ignore });
                var label = DashboardLabel("当前陪练系数", 20, _muted);
                label.SizeFlagsHorizontal = SizeFlags.ShrinkBegin; heading.AddChild(label);
                heading.AddChild(DashboardLabel($"×{ClubCoaching.Factor(data):0.#}", 20, CareerVisuals.Teal));
                group.AddChild(DashboardLabel("教练提升轮换与青训陪练效果，多名教练取最高加成。", 16, _muted, true));
            }
            if (ClubCoaching.PlayerFeatures(data))
            {
                if (role=="首发" && club.PlayerReserve)
                    heading.AddChild(RosterTool("恢复首发",()=>PlayerPositionDialog(data)));
                if (role=="教练" && !club.PlayerCoach)
                    heading.AddChild(RosterTool("兼任教练",()=>TogglePlayerCoach(data)));
                if (role=="首发" && club.PlayerPositionSeason>0)
                {
                    var pending = new HBoxContainer(); group.AddChild(pending);
                    pending.AddChild(DashboardLabel($"第{club.PlayerPositionSeason}赛季转为{club.PlayerNextPosition} · 与{CareerEngine.DisplayName(data,club.PlayerReplacement)}调整席位",16,_gold,true));
                    pending.AddChild(RosterTool("撤销席位申请",()=>ClubAction(data,"player-position",target:"取消")));
                }
            }
            if (ids.Count == 0) group.AddChild(DashboardLabel("前往招募选择选手。",16,_muted));
            for (int index=0; index<ids.Count; index++)
            {
                if (index>0) group.AddChild(Hairline("526e8059"));
                var padding = Inset(0,14);
                if (index==ids.Count-1) padding.AddThemeConstantOverride("margin_bottom",0);
                group.AddChild(padding);
                var member = new VBoxContainer(); padding.AddChild(member);
                RosterMember(data,club,member,ids[index],role,humans.Contains(ids[index]));
            }
        }
    }

    private void RosterMember(CareerData data, OwnedClubState club, VBoxContainer parent, string id, string role, bool human)
    {
        var line = new HBoxContainer {Name="RosterMember_"+id}; line.AddThemeConstantOverride("separation",22); parent.AddChild(line);
        var person = CareerEngine.Person(data,id);
        string name = CareerEngine.DisplayName(data,id);
        var identity = new HBoxContainer(); identity.AddThemeConstantOverride("separation",12);
        identity.AddChild(Avatar(data,id,49,false));
        var labels = new VBoxContainer {SizeFlagsHorizontal=SizeFlags.ExpandFill,Alignment=BoxContainer.AlignmentMode.Center};
        labels.AddThemeConstantOverride("separation",3); identity.AddChild(labels);
        var nameLabel=DashboardLabel(name,20,_ink); nameLabel.TextOverrunBehavior=TextServer.OverrunBehavior.TrimEllipsis;
        labels.AddChild(nameLabel);
        string rank = human || person==null ? role : OwnedClubs.Tier(person);
        if (id=="player" && ClubCoaching.PlayerCoach(data)) rank+=" · 兼任教练";
        string character = ArenaCharacterName(CareerAvatars.MainCharacter(data,id));
        var subtitle = DashboardLabel(character.Length==0 ? rank : rank+" · "+character,15,_muted,true);
        labels.AddChild(subtitle); identity.AddChild(Glyph("chevron-right",17,_muted));
        var open = ActionRow(line,"RosterIdentity",name,()=>OpenPerson(id),identity,61,8,5,"1b303e","395365","28434c");
        var nameCard = open.GetParent<Control>(); nameCard.CustomMinimumSize=new(220,61);
        nameCard.SizeFlagsStretchRatio=.81f; nameCard.SizeFlagsVertical=SizeFlags.ShrinkCenter;
        open.TooltipText=string.Join(" · ",new[]{name,rank,person?.Role,character}.Where(s=>!string.IsNullOrEmpty(s)).Distinct());
        var facts = new VBoxContainer {Name="RosterFacts",CustomMinimumSize=new(300,0),SizeFlagsHorizontal=SizeFlags.ExpandFill,
            SizeFlagsVertical=SizeFlags.ShrinkCenter};
        facts.AddThemeConstantOverride("separation",4); line.AddChild(facts);
        var tools = new HFlowContainer {Name="RosterTools",CustomMinimumSize=new(560,0),SizeFlagsHorizontal=SizeFlags.ExpandFill,
            SizeFlagsStretchRatio=1.52f,SizeFlagsVertical=SizeFlags.ShrinkCenter, Alignment=FlowContainer.AlignmentMode.End};
        tools.AddThemeConstantOverride("h_separation",10); tools.AddThemeConstantOverride("v_separation",8); line.AddChild(tools);
        if (human)
        {
            if (id == "player" || id == club.ManagerId)
            {
                int highest = id=="player" ? data.AvatarHighestClear : data.HumanClears.GetValueOrDefault(id,-1);
                string level = highest < 0 ? "—" : highest.ToString();
                string rate = id=="player" || id==data.LocalHumanId ? PlayerArchive.Read(false).WinRate :
                    person != null && person.Wins+person.Losses>0 ? $"{100.0*person.Wins/(person.Wins+person.Losses):0.#}%" : "—";
                facts.AddChild(DashboardLabel($"最高进阶 {level} · 通关率 {rate}",16,_ink,true));
                facts.AddChild(DashboardLabel("俱乐部部长",15,_muted));
            }
            if (ClubCoaching.PlayerFeatures(data) && id=="player")
            {
                if (role=="首发")
                {
                    var candidates = ClubCoaching.Replacements(data);
                    var picker = ClubSelect(["退出首发",..candidates.Select(i=>CareerEngine.DisplayName(data,i))],0,index=>
                    { if (index>0) PlayerPositionDialog(data,candidates[index-1]); });
                    picker.Name="PlayerSeatExchange"; picker.SetItemDisabled(0,true); StyleRosterPicker(picker,190,43);
                    picker.Disabled=candidates.Count==0; picker.ItemSelected+=_=>picker.Select(0); tools.AddChild(picker);
                }
                if (role=="首发" || role=="教练")
                    tools.AddChild(RosterTool(club.PlayerCoach ? "结束教练" : "兼任教练",()=>TogglePlayerCoach(data)));
            }
            if (OwnedClubs.PaidHumans(data).Contains(id))
                facts.AddChild(DashboardLabel($"周薪 {CareerMoney.Format(club.HumanWeeklyWage)} · 获胜 {CareerMoney.Format(club.HumanWinBonus)} · 待付 {CareerMoney.Format(club.HumanPayDue.GetValueOrDefault(id))}",15,_muted,true));
            return;
        }
        var contract = club.Contracts.FirstOrDefault(c=>c.PersonId==id);
        if (contract==null || person==null) return;
        facts.AddChild(DashboardLabel(role=="教练" ? $"陪练系数 ×{ClubCoaching.Factor(person):0.#}" :
            $"进阶 {person.MaxAscension} · A8 预计通关率 {MatchRules.ClearChance(data,person,8)*100:0.#}%",16,_ink,true));
        facts.AddChild(DashboardLabel($"{OwnedClubs.PlanName(contract.Plan)} · 周薪 {CareerMoney.Format(contract.Wage)} · 获胜 {CareerMoney.Format(contract.WinBonus)} · {GameCalendar.Date(data,contract.EndDay):M/d} 续约",15,_muted,true));
        if (!CanManageClub) return;
        void Tool(string text,Action command) => tools.AddChild(RosterTool(text,command));
        if (role!="教练")
        {
            var candidates=RosterPositions.Where(r=>r!=role && r!="教练").SelectMany(r=>OwnedClubs.PositionList(club,r))
                .Where(member=>club.Contracts.Any(c=>c.PersonId==member)).ToList();
            if (candidates.Count>0)
            {
                var select=ClubSelect(["交换位置",..candidates.Select(i=>CareerEngine.DisplayName(data,i))],0,index=>
                { if (index>0) RosterSwapDialog(data,id,candidates,candidates[index-1]); });
                select.Name="RosterExchange"; select.SetItemDisabled(0,true); StyleRosterPicker(select,190,43);
                select.ItemSelected+=_=>select.Select(0); tools.AddChild(select);
            }
            Tool("转任教练",()=>CoachAppointmentDialog(data,id));
        }
        string[] destinations=role switch { "教练"=>["轮换","青训"], "青训"=>["轮换"], "轮换"=>["青训"], _=>[] };
        foreach (string destination in destinations)
        {
            string action=(role=="教练"?"转回":"调入")+destination;
            string detail=role=="教练" ? $"{name} · 立即转回{destination}\n保留合同待遇与期限。停止其负责的未完成训练，已获得成长保留。" : $"将 {name} 调入{destination}？";
            Tool(action,()=>ShowCareerDialog(action,detail,()=>{ClubAction(data,"position",destination,id);return true;}));
        }
        if (role!="首发") Tool("解除合同",()=>ShowCareerDialog("解除合同",$"{name} 的解约补偿为 {CareerMoney.Format(OwnedClubs.ExitFee(data,contract))}。",
            ()=>{ClubAction(data,"release",target:id);return true;}));
        if (club.CoachAppointments.FirstOrDefault(a=>a.PersonId==id) is { } appointment)
        {
            var pending = new HBoxContainer(); pending.AddThemeConstantOverride("separation",16); parent.AddChild(pending);
            var note=DashboardLabel($"第 {appointment.Season} 赛季转任教练",16,_gold); note.SizeFlagsHorizontal=SizeFlags.ShrinkBegin; pending.AddChild(note);
            pending.AddChild(RosterTool("取消调整",()=>ClubAction(data,"coach-cancel",target:id),90,32));
        }
    }

    private static void StyleRosterPicker(OptionButton picker,int width,int height)
    {
        picker.CustomMinimumSize=new(width,height); picker.FitToLongestItem=false;
        picker.SizeFlagsHorizontal = width > 0 ? SizeFlags.ShrinkEnd : SizeFlags.ExpandFill;
        picker.AddThemeFontSizeOverride("font_size",16);
        ButtonSurface(picker,"1d3040","395365","28434c","658c91",7,6);
    }

    private Button RosterTool(string title,Action action,int width=116,int height=43)
    {
        var button=ClubButton(title,action,width); button.CustomMinimumSize=new(width,height);
        button.AddThemeFontSizeOverride("font_size",16);
        ButtonSurface(button,"1d3040","395365","28434c","658c91",6,6);
        return button;
    }

    private void RosterCandidate(CareerData data,VBoxContainer card,string id,string label)
    {
        var person=CareerEngine.Person(data,id)!;
        card.AddChild(DashboardLabel(label+" · "+OwnedClubs.Position(data.Esports.OwnedClub!,id),15,_muted));
        var portrait=Avatar(data,id,104,false); portrait.SizeFlagsHorizontal=SizeFlags.ShrinkCenter;
        var portraitMargin=Inset(0,8); card.AddChild(portraitMargin); portraitMargin.AddChild(portrait);
        var name=new HBoxContainer {Alignment=BoxContainer.AlignmentMode.Center}; name.AddThemeConstantOverride("separation",6); card.AddChild(name);
        var small=DashboardLabel("ID",12,_muted); small.SizeFlagsHorizontal=SizeFlags.ShrinkBegin; name.AddChild(small);
        var identity=DashboardLabel(person.PublicName,23,_ink,true);
        identity.CustomMinimumSize=new(Math.Min(295,Mathf.Ceil(CareerVisuals.InterfaceText().GetStringSize(person.PublicName,fontSize:23).X)+2),0);
        identity.HorizontalAlignment=HorizontalAlignment.Center; identity.SizeFlagsHorizontal=SizeFlags.ShrinkBegin; name.AddChild(identity);
        var inset=Inset(0,0); inset.AddThemeConstantOverride("margin_top",10); card.AddChild(inset);
        var stats=new VBoxContainer(); stats.AddThemeConstantOverride("separation",6); inset.AddChild(stats);
        void Stat(string key,string value)
        {
            var row=new HBoxContainer(); row.AddThemeConstantOverride("separation",12); stats.AddChild(row);
            row.AddChild(DashboardLabel(key,16,_muted));
            var field=DashboardLabel(value,16,_ink,true); field.HorizontalAlignment=HorizontalAlignment.Right; row.AddChild(field);
        }
        Stat("最高进阶",person.MaxAscension.ToString()); Stat("A8 预计通关率",$"{MatchRules.ClearChance(data,person,8)*100:0.#}%");
        Stat("称号",AvatarHonors.ForPerson(data,id).Frame.Name);
    }

    private void RosterSwapDialog(CareerData data,string outgoing,List<string> candidates,string incoming)
    {
        var opened=data.Esports.OwnedClub!;
        string clubId=opened.ClubId, oldPosition=OwnedClubs.Position(opened,outgoing);
        var positions=candidates.ToDictionary(id=>id,id=>OwnedClubs.Position(opened,id));
        var surface=CareerVisuals.Box("142633","65838e",10,32);
        surface.ContentMarginTop=surface.ContentMarginBottom=27; surface.ShadowColor=new Color("00000070"); surface.ShadowSize=18;
        Button swap=null!, release=null!;
        Label feedback=null!, fee=null!;
        string? Stale(CareerData live) => !CanManageClub || live.Esports.OwnedClub is not { } club || club.ClubId!=clubId
            || !club.Contracts.Any(c=>c.PersonId==outgoing) || !club.Contracts.Any(c=>c.PersonId==incoming)
            || OwnedClubs.Position(club,outgoing)!=oldPosition || OwnedClubs.Position(club,incoming)!=positions[incoming] ? "队员席位已变化，请重新选择。" : null;
        void Check()
        {
            var live=ViewData;
            string? stale=Stale(live);
            string? swapError=stale??OwnedClubs.SwapError(live,outgoing,incoming);
            string? releaseError=stale??OwnedClubs.ReplaceAndReleaseError(live,outgoing,incoming);
            swap.Disabled=swapError!=null; release.Disabled=releaseError!=null;
            feedback.Text=swapError==releaseError ? swapError??"" : string.Join("　",new[]{
                swapError==null?"":"替换 · "+swapError, releaseError==null?"":"解约并更换 · "+releaseError}.Where(s=>s.Length>0));
            feedback.Visible=feedback.Text.Length>0;
            var contract=live.Esports.OwnedClub?.Contracts.FirstOrDefault(c=>c.PersonId==outgoing);
            fee.Text=contract==null?"—":CareerMoney.Format(OwnedClubs.ExitFee(live,contract));
        }
        bool Submit(bool terminate)
        {
            Check(); if ((terminate?release:swap).Disabled) return false;
            if (terminate) _cancelDialog?.Invoke();
            ClubAction(ViewData,terminate?"replace-release":"swap",incoming,outgoing);
            return true;
        }
        ShowCareerDialog("调整阵容","",()=>Submit(false),"替换",body=>
        {
            body.GetParent<PanelContainer>().CustomMinimumSize=new(880,0); body.CustomMinimumSize=Vector2.Zero;
            body.GetChild<Label>(0).AddThemeFontSizeOverride("font_size",30); body.AddThemeConstantOverride("separation",18);
            var pair=new HBoxContainer {Name="SwapPair"}; pair.AddThemeConstantOverride("separation",0); body.AddChild(pair);
            VBoxContainer CardBody(string name)
            {
                var panel=new PanelContainer {Name=name,SizeFlagsHorizontal=SizeFlags.ExpandFill};
                var style=CareerVisuals.Box("192e3c","3a5464",7,19); style.ContentMarginTop=15;style.ContentMarginBottom=16;
                panel.AddThemeStyleboxOverride("panel",style); pair.AddChild(panel);
                var box=Inner(panel);box.AddThemeConstantOverride("separation",4); return box;
            }
            RosterCandidate(data,CardBody("OutgoingCard"),outgoing,"被替换选手");
            var arrow=new CenterContainer {CustomMinimumSize=new(52,0)}; pair.AddChild(arrow); arrow.AddChild(Glyph("arrow-right-left",24,CareerVisuals.Teal));
            var next=CardBody("IncomingCard");
            var fields=new VBoxContainer(); fields.AddThemeConstantOverride("separation",4); next.AddChild(fields); RosterCandidate(data,fields,incoming,"替换选手");
            var pickerMargin=Inset(0,0); pickerMargin.AddThemeConstantOverride("margin_top",8); next.AddChild(pickerMargin);
            var picker=ClubSelect(candidates.Select(id=>CareerEngine.DisplayName(data,id)).ToArray(),candidates.IndexOf(incoming),index=>
            {
                incoming=candidates[index]; CareerVisuals.ClearContent(fields);
                if (Stale(ViewData)==null) RosterCandidate(ViewData,fields,incoming,"替换选手");
                Check();
            });
            StyleRosterPicker(picker,0,38); picker.Name="SwapCandidate"; pickerMargin.AddChild(picker);
            var costs=new HBoxContainer(); body.AddChild(costs); costs.AddChild(DashboardLabel("解约补偿",17,_muted));
            fee=DashboardLabel("",18,_gold); fee.HorizontalAlignment=HorizontalAlignment.Right; costs.AddChild(fee);
            feedback=DashboardLabel("",16,new Color("e1bd8a"),true); feedback.Name="SwapFeedback"; body.AddChild(feedback);
        },surface:surface,footer:(buttons,cancel,accept)=>
        {
            swap=accept; release=RosterTool("解约并更换",()=>Submit(true)); buttons.AddChild(release);
            buttons.Name="RosterDialogActions"; buttons.AddThemeConstantOverride("separation",13);
            foreach (var b in new[]{cancel,swap,release}) { b.CustomMinimumSize=new(b==release?137:88,47); b.AddThemeFontSizeOverride("font_size",18); }
            ButtonSurface(cancel,"00000000","304a5a","28434c","658c91",9);
            ButtonSurface(swap,"31545b","7b9487","385d61","eed39b",9); swap.AddThemeColorOverride("font_color",_gold);
            ButtonSurface(release,"3c2b2d","815851","533638","cc8f86",9); release.AddThemeColorOverride("font_color",new Color("f0bbb4"));
            Check();
        });
    }
}
