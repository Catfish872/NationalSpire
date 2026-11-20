using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private static PanelContainer ReportPanel(string fill, string edge, int padding = 14)
    {
        var panel = new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill };
        panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box(fill,edge,7,padding));
        return panel;
    }
    private static Label ReportCell(string value, int width, Color ink, bool first = false)
    {
        var cell = Text(value,16,ink);
        cell.AutowrapMode = TextServer.AutowrapMode.Off;
        cell.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis;
        cell.HorizontalAlignment = first ? HorizontalAlignment.Left : HorizontalAlignment.Center;
        cell.CustomMinimumSize = new(width,26);
        cell.SizeFlagsHorizontal = first ? SizeFlags.ExpandFill : SizeFlags.ShrinkCenter;
        cell.TooltipText = value;
        return cell;
    }
    private void DuelReportView(VBoxContainer parent, DuelReport report, bool inDialog)
    {
        var view = new VBoxContainer { Name="DuelReportView",SizeFlagsHorizontal=SizeFlags.ExpandFill };
        view.AddThemeConstantOverride("separation",12); parent.AddChild(view);
        var roster = new HBoxContainer { SizeFlagsHorizontal=SizeFlags.ExpandFill };
        roster.AddThemeConstantOverride("separation",12);
        if(inDialog && report.People.GroupBy(p=>p.Opponent).Any(side=>side.Count()>2)){
            var members=new ScrollContainer { CustomMinimumSize=new(0,190),HorizontalScrollMode=ScrollContainer.ScrollMode.Disabled };
            view.AddChild(members);members.AddChild(roster);
        }else view.AddChild(roster);
        foreach(bool opponent in new[]{false,true}){
            var color = opponent ? _gold : CareerVisuals.Teal;
            var panel = ReportPanel(opponent?"28292b":"152d36",opponent?"61503a":"345760");
            roster.AddChild(panel); var box = Inner(panel);
            var caption = new HBoxContainer(); box.AddChild(caption);
            caption.AddChild(Text((opponent?"对手":"我方")+(opponent==report.OpponentOpens?"  ·  先手":"  ·  后手"),16,color));
            if(opponent!=report.PlayersWon){
                var won=Text("获胜",16,_gold);won.HorizontalAlignment=HorizontalAlignment.Right;caption.AddChild(won);
            }
            foreach(var p in report.People.Where(p=>p.Opponent==opponent)){
                var row = new HBoxContainer();row.AddThemeConstantOverride("separation",12);box.AddChild(row);
                var art=p.PersonId.Length>0?CareerAvatars.ForPerson(ViewData,p.PersonId):AvatarAssets.Load(p.Character,0,false);
                row.AddChild(new CareerAvatar{Art=art,CustomMinimumSize=new(48,48),SizeFlagsVertical=SizeFlags.ShrinkCenter,MouseFilter=MouseFilterEnum.Ignore});
                var id=new VBoxContainer{SizeFlagsHorizontal=SizeFlags.ExpandFill};row.AddChild(id);
                id.AddChild(Text(p.Name,20,_ink));id.AddChild(Text(p.Character,15,_muted));
                var life=new VBoxContainer{SizeFlagsVertical=SizeFlags.ShrinkCenter};row.AddChild(life);
                var hp=Text($"{p.OpenHp}/{p.OpenMax} → {p.EndHp}/{p.EndMax}",16,color);hp.AutowrapMode=TextServer.AutowrapMode.Off;hp.TooltipText=$"开局 {p.OpenHp}/{p.OpenMax}  ·  终局 {p.EndHp}/{p.EndMax}";life.AddChild(hp);
                var meter=new ProgressBar{CustomMinimumSize=new(94,5),MaxValue=Math.Max(1,p.EndMax),Value=p.EndHp,ShowPercentage=false};
                meter.AddThemeStyleboxOverride("background",CareerVisuals.Box("0e1923","0e1923",2,0));
                meter.AddThemeStyleboxOverride("fill",CareerVisuals.Box(opponent?"b59a66":"65b8b4",opponent?"b59a66":"65b8b4",2,0));life.AddChild(meter);
            }
        }
        if(report.Note.Length>0)view.AddChild(Text(report.Note,17,_gold));
        var tabRow=TabStrip(view,12);
        var header = new MarginContainer();
        view.AddChild(header);
        var scroll=new ScrollContainer{CustomMinimumSize=new(inDialog?800:0,inDialog?285:380),HorizontalScrollMode=ScrollContainer.ScrollMode.Disabled};
        view.AddChild(scroll);
        var body=new VBoxContainer{SizeFlagsHorizontal=SizeFlags.ExpandFill};body.AddThemeConstantOverride("separation",8);scroll.AddChild(body);
        void AlignHeader() => header.AddThemeConstantOverride("margin_right",Math.Max(0,(int)Math.Round(scroll.Size.X-body.Size.X)));
        body.Resized += AlignHeader;
        scroll.Resized += AlignHeader;
        void Select(int page){
            if(inDialog)scroll.CustomMinimumSize=new(800,page==2?342:285);
            CareerVisuals.ClearContent(tabRow);CareerVisuals.ClearContent(header);CareerVisuals.ClearContent(body);scroll.ScrollVertical=0;
            header.Visible=page==0;
            string[] tabs=[$"回合战况  {report.Rounds.Count}",report.Replay==null?"关键牌序":"出牌顺序","相关牌面"];
            for(int i=0;i<tabs.Length;i++){int dest=i;tabRow.AddChild(UnderlineTab(tabs[i],()=>Select(dest),i==page,130,18));}
            if(page==0)RoundTable(header,body,report);
            else if(page==1){
                if(report.Replay==null)body.AddChild(Text("历史战报仅保存了关键回合的牌序。",16,_muted));
                foreach(var round in report.Rounds){
                    var plays=report.Replay is {} replay
                        ? replay.Rounds[round.Number].Select(s=>new DuelCardStep(s.Actor,s.Card,s.Target,s.Generated))
                        : round.Sequence.SelectMany(run=>Enumerable.Range(0,run.Repeats).SelectMany(_=>run.Cards));
                    if(report.Replay==null && round.Sequence.Count==0)continue;
                    var panel=ReportPanel("142530","304653");body.AddChild(panel);var box=Inner(panel);
                    box.AddChild(Text($"第 {round.Number} 回合  ·  完整出牌顺序",18,_gold));
                    int last=-1; HFlowContainer? flow=null;
                    foreach(var action in plays){
                            var p=report.People[action.Actor];
                            if(action.Actor!=last){
                                box.AddChild(Text(p.Name,16,p.Opponent?_gold:CareerVisuals.Teal)); last=action.Actor;
                                flow=new HFlowContainer();flow.AddThemeConstantOverride("h_separation",6);flow.AddThemeConstantOverride("v_separation",7);box.AddChild(flow);
                            }
                            if(flow!.GetChildCount()>0)flow.AddChild(ReportCell("›",14,_muted));
                            var chip=ReportPanel("1d3340","3b5260",7);chip.SizeFlagsHorizontal=SizeFlags.ShrinkBegin;
                            flow.AddChild(chip);var label=Text(action.Card+(action.Generated?"  ✧":""),17,_ink);
                            label.TooltipText=string.Join(" · ",new[]{action.Generated?"战中获得":"",action.Target.Length>0?"目标 "+action.Target:""}.Where(t=>t.Length>0));
                            label.AutowrapMode=TextServer.AutowrapMode.Off;chip.AddChild(label);
                    }
                    if(last<0) box.AddChild(Text("本回合未出牌",16,_muted));
                }
            }else{
                if(report.Replay is {} replay){
                    var played=replay.Rounds.Values.SelectMany(steps=>steps).ToLookup(s=>s.Actor,s=>s.Face);
                    for(int i=0;i<report.People.Count;i++){
                        var deck=replay.Decks[i];
                        var inDeck=deck.ToHashSet();
                        Faces(report.People[i].Name+"的起始牌组",deck.Select(id=>replay.Faces[id]),"张");
                        Faces(report.People[i].Name+"在战中另行打出的牌面",played[i].Where(id=>!inDeck.Contains(id)).Select(id=>replay.Faces[id]),"次");
                    }
                }else{
                    body.AddChild(Text("历史战报仅保存了部分牌面。",16,_muted));
                    foreach(var p in report.People)Faces(p.Name+"的部分牌面",p.Deck,"");
                    Faces("关键回合另见牌面",report.PlayedFaces,"");
                }
                void Faces(string title,IEnumerable<DuelCardFace> faces,string unit){
                    var items=faces.GroupBy(f=>f).ToList();if(items.Count==0)return;
                    body.AddChild(Text(title,18,_gold));
                    var grid=new GridContainer{Columns=Math.Max(1,(int)(body.Size.X/235)),SizeFlagsHorizontal=SizeFlags.ExpandFill};
                    grid.AddThemeConstantOverride("h_separation",12);grid.AddThemeConstantOverride("v_separation",10);body.AddChild(grid);
                    foreach(var item in items){
                        var tile=ReportCard(item.Key,out var stack);
                        grid.AddChild(tile);
                        if(unit.Length>0){
                            var count=Text(unit=="张"?$"牌组中 {item.Count()} 张":$"打出 {item.Count()} 次",16,_muted);
                            count.HorizontalAlignment=HorizontalAlignment.Center;stack.AddChild(count);
                        }
                    }
                }
            }
        }
        Select(0);
    }
    private Control ReportCard(DuelCardFace face,out VBoxContainer stack){
        var model=MegaCrit.Sts2.Core.Models.ModelDb.GetByIdOrNull<MegaCrit.Sts2.Core.Models.CardModel>(new("CARD",face.Id));
        if(model!=null){
            try{
                var snapshot=face.State is {} json
                    ? System.Text.Json.JsonSerializer.Deserialize<MegaCrit.Sts2.Core.Saves.Runs.SerializableCard>(json)
                    : new MegaCrit.Sts2.Core.Saves.Runs.SerializableCard{Id=model.Id,CurrentUpgradeLevel=face.Level??0};
                if(snapshot!=null){
                    var saved=MegaCrit.Sts2.Core.Models.CardModel.FromSerializable(snapshot);
                    if(face.Level==null && saved.IsUpgradable && face.Text.StartsWith(GameText.Plain(saved.Title)+"+",StringComparison.Ordinal))
                        LeagueCards.Improve(saved);
                    var entry=new LeagueCards.Entry(saved,"",Math.Max(0,LeagueCards.CollectionTier(model)));
                    var tile=LeagueTile(entry,out stack);
                    stack.GetChild<LeagueCardFace>(0).CustomMinimumSize=new(205,282);
                    return tile;
                }
            }catch(Exception){ /* 已卸载的附魔仍可从战报中阅读原有牌效。 */ }
        }
        var archive=stack=new VBoxContainer();
        var panel=ReportPanel("142530","304653");archive.AddChild(panel);
        panel.AddChild(Text(face.Text.Length>0?face.Text:face.Id,18,_ink));return archive;
    }
    private void RoundTable(MarginContainer header,VBoxContainer body,DuelReport report){
        bool doom=report.Rounds.Any(r=>r.Totals.Any(s=>s.DoomIntent!=0||s.Doom!=0));
        int[] widths=[54,105,46,72,72,72,46,46,68,68];
        string[] icons=["","","ui/reward_screen/reward_icon_card.png","packed/intents/attack/intent_attack_1.png","ui/combat/block.png",
            "atlases/ui_atlas.sprites/top_bar/top_bar_heart.tres","packed/combat_ui/draw_pile.png","packed/sprite_fonts/colorless_energy_icon.png",
            "packed/intents/intent_debuff.png","atlases/power_atlas.sprites/doom_power.tres"];
        void Row(VBoxContainer box,string[] values,Color ink,bool headings=false){
            var line=new HBoxContainer();line.AddThemeConstantOverride("separation",4);box.AddChild(line);
            for(int i=0;i<(doom?10:8);i++){
                var cell=ReportCell(values[i],widths[i],ink,i==1);
                line.AddChild(cell);
                if(!headings || i<2)continue;
                var texture=ResourceLoader.Load<Texture2D>("res://images/"+icons[i]);
                if(texture==null)continue;
                cell.Text="";
                cell.MouseFilter=MouseFilterEnum.Pass;
                var icon=new TextureRect{Texture=texture,ExpandMode=TextureRect.ExpandModeEnum.IgnoreSize,
                    StretchMode=TextureRect.StretchModeEnum.KeepAspectCentered,MouseFilter=MouseFilterEnum.Ignore};
                cell.AddChild(icon);
                icon.SetAnchorsAndOffsetsPreset(LayoutPreset.Center);
                icon.OffsetLeft=-14;icon.OffsetRight=14;icon.OffsetTop=-14;icon.OffsetBottom=14;
            }
        }
        var heading=ReportPanel("14232f","2c414e",8);header.AddChild(heading);
        Row(Inner(heading),["回合","选手","出牌","攻击意图","格挡抵消","实际伤害","抽牌","耗能","灾厄意图","施加层数"],_muted,true);
        foreach(var r in report.Rounds){
            var panel=ReportPanel("101e29","283c49",8);body.AddChild(panel);var box=Inner(panel);
            for(int i=0;i<r.Totals.Count;i++){
                var p=report.People[i];var s=r.Totals[i];
                Row(box,[i==0?r.Number.ToString():"",p.Name,$"{s.Cards}",$"{s.Attack}",$"{s.Block}",$"{s.Damage}",$"{s.Draw}",$"{s.Energy}",$"{s.DoomIntent}",$"{s.Doom}"],p.Opponent?_gold:CareerVisuals.Teal);
            }
        }
    }
}
