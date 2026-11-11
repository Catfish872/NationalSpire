using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private static HBoxContainer InfoRow(Container parent)
    {
        var row = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Ignore };
        row.AddThemeConstantOverride("separation", 14); parent.AddChild(row); return row;
    }
    private static VBoxContainer InfoColumn(Container parent)
    {
        var col = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, Alignment = BoxContainer.AlignmentMode.Center, MouseFilter = MouseFilterEnum.Ignore };
        col.AddThemeConstantOverride("separation", 4); parent.AddChild(col); return col;
    }
    private VBoxContainer ChoiceField(Container parent, string title)
    {
        var col = InfoColumn(parent); col.AddChild(Text(title, 16, _muted)); return col;
    }
    private void StatStrip(Container parent, Color color, params (string Title, string Value)[] stats)
    {
        var row = InfoRow(parent);
        foreach (var stat in stats)
        {
            if (row.GetChildCount() > 0)
                row.AddChild(new ColorRect { Color = new Color("385264"), CustomMinimumSize = new(1,0), MouseFilter = MouseFilterEnum.Ignore });
            var col = InfoColumn(row); col.AddChild(Text(stat.Title, 15, _muted)); col.AddChild(Text(stat.Value, 20, color));
        }
    }
    private static VBoxContainer FoldDetails(Container parent, Container buttons, string label)
    {
        var content = new VBoxContainer { Visible = false }; parent.AddChild(content);
        var toggle = new CareerDisclosureButton { Text = label, Flat = true, ToggleMode = true, ArrowInset = 8,
            Alignment = HorizontalAlignment.Left,
            CustomMinimumSize = new(0,36), SizeFlagsHorizontal = SizeFlags.ShrinkBegin };
        toggle.AddThemeFontSizeOverride("font_size",16);
        foreach (var state in new[] {"normal","hover","pressed","hover_pressed","disabled"})
        {
            var padding = new StyleBoxEmpty { ContentMarginLeft=8, ContentMarginRight=32, ContentMarginTop=3, ContentMarginBottom=3 };
            toggle.AddThemeStyleboxOverride(state,padding);
        }
        buttons.AddChild(toggle);
        toggle.Toggled += open => { content.Visible=open; toggle.QueueRedraw(); }; return content;
    }
    private void PracticeRules(Container parent)
    {
        var bar = InfoRow(parent);
        var more = FoldDetails(parent,bar,"陪练贡献");
        more.AddChild(Text("轮换、青训分组计算，各组按陪练贡献排序。",16,_muted));
        StatStrip(more,_ink,("组内前 3 名","100%"),("第 4 名","约 30%"),("第 5 名","约 16%"),("此后","逐人递减"));
    }
    private HBoxContainer SponsorLine(string title, string badge, string first, string second, Color color, bool heading=false)
    {
        var line = new HBoxContainer { MouseFilter=MouseFilterEnum.Ignore }; line.AddThemeConstantOverride("separation",12);
        var brand = InfoRow(line); brand.SizeFlagsStretchRatio=1.7f;
        var name = DashboardLabel(title,heading?16:19,color); name.SizeFlagsHorizontal=SizeFlags.ShrinkBegin; brand.AddChild(name);
        if(badge.Length>0) brand.AddChild(DashboardLabel(badge,15,CareerVisuals.Teal));
        foreach (string value in new[]{first,second})
        {
            var field=DashboardLabel(value,heading?16:19,color,true);field.SizeFlagsHorizontal=SizeFlags.ExpandFill;
            field.HorizontalAlignment=HorizontalAlignment.Right;line.AddChild(field);
        }
        return line;
    }
    private void ClubBrandOffers(CareerData d, OwnedClubState o)
    {
        var box=ClubCard("");var head=InfoRow(box); InfoColumn(head).AddChild(Text("俱乐部品牌赞助",25,_ink));
        var active=o.Sponsor;
        if(active!=null) { var end=DashboardLabel("本期至 "+GameCalendar.Text(d,active.EndDay),16,_muted); end.SizeFlagsHorizontal=SizeFlags.ShrinkEnd; head.AddChild(end); }
        int fans=ClubAudience.Total(d,o.ClubId);
        var offers=new[]{"steady","results","fans"}.Select(id=>(id,offer:OwnedClubs.SponsorQuote(d,id))).ToArray();
        int Weekly(OwnedSponsor s)=>OwnedClubs.SponsorWeekly(s,fans);
        int Win(OwnedSponsor s)=>OwnedClubs.SponsorWinBonus(s,fans);
        bool Current(OwnedSponsor s)=>active!=null && s.Brand==active.Brand && Weekly(s)==Weekly(active) && Win(s)==Win(active);
        void StaticLine(Control line) { var inset=Inset(14,4);box.AddChild(inset);inset.AddChild(line); }
        StaticLine(SponsorLine(active==null?"选择合作品牌":"选择下期品牌","", "预计周收入","预计每胜奖金",_muted,true));
        if(active!=null && !offers.Any(v=>Current(v.offer)))
            StaticLine(SponsorLine(active.Brand,"本期",CareerMoney.Format(Weekly(active)),CareerMoney.Format(Win(active)),_ink));
        foreach(var (id,s) in offers)
        {
            bool current=Current(s),next=o.NextSponsor==id;
            string badge=string.Join("  ",new[]{current?"本期":"",next?"下期已选":""}.Where(t=>t.Length>0));
            var line=SponsorLine(s.Brand,badge,CareerMoney.Format(Weekly(s)),CareerMoney.Format(Win(s)),_ink);
            var button=ActionRow(box,"ClubSponsor_"+id,s.Brand,()=>ShowCareerDialog(active==null?"确认赞助":"确认下期赞助",
                active==null?"选择 "+s.Brand+"？":"选择 "+s.Brand+"？当前合同按期执行。",()=>{ ClubAction(d,"sponsor",target:id);return true; }),
                line,48,14,6,next?"203e43":"162a37",next?"63b7b2":"344b58","24414d");
            button.Disabled=!CanManageClub;if(button.Disabled)button.TooltipText="由房主管理俱乐部";
        }
        box.AddChild(Hairline()); var footer=InfoRow(box);
        InfoColumn(footer).AddChild(Text("8 周一约 · 到期自动续约",16,_muted));
        var brands=FoldDetails(box,footer,"品牌介绍");
        foreach(var (_,s) in offers) brands.AddChild(Text(s.Brand+" · "+RegionalOrganizations.SponsorDescription(s.Brand),16,_ink));
        var settlement=FoldDetails(box,footer,"结算说明");
        StatStrip(settlement,_ink,("表中报价","按当前俱乐部关注数估算"),("实际收入","按付款时的俱乐部关注数结算"));
    }
    private void AchievementOffers(CareerData d, OwnedClubState o)
    {
        var box=ClubCard("成绩赞助");
        StatStrip(box,_gold,("本周按最高一档领取",CareerMoney.Format(OwnedClubs.AchievementWeekly(d))),("每份期限","8 周"));
        var deals=o.AchievementSponsors.Where(s=>s.StartDay<=d.Day && s.EndDay>d.Day).OrderByDescending(s=>s.Weekly).ToList();
        if (deals.Count>0) box.AddChild(SponsorLine("有效赞助","","每周金额","到期日",_muted,true));
        foreach(var deal in deals) box.AddChild(SponsorLine(deal.Title,"",CareerMoney.Format(deal.Weekly),GameCalendar.Text(d,deal.EndDay),_ink));
        var bar=InfoRow(box);var rules=FoldDetails(box,bar,"查看奖励规则");
        rules.AddChild(Text("联赛连胜奖励每季每档一次。签约奖为每周金额的两倍。",16,_muted));
        rules.AddChild(SponsorLine("达成成绩","","增加关注","每周金额",_muted,true));
        void Reward(string title,int fans,int weekly)=>rules.AddChild(SponsorLine(title,"",$"+{fans:N0}",CareerMoney.Format(weekly),_ink));
        Reward("联赛三连胜",600,300);Reward("联赛五连胜",1200,600);
        foreach(var kind in new[]{"league","continental"})
            foreach(var rank in new[]{1,2,3,4,5})
            {
                if(kind=="continental" && rank==3)continue;
                var reward=OwnedClubs.PlacementReward(kind,rank);
                var stage = rank==5?"其余名次":kind=="continental" && rank==4?"四强":$"第 {rank} 名";
                Reward((kind=="league"?"联赛 · ":"洲际赛 · ")+stage,reward.Fans,reward.Weekly);
            }
    }
}
