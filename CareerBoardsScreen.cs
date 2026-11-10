using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private int _rankSeason;
    private void AssetsPage(CareerData d)
    {
        var page = new VBoxContainer { Name="AssetsPage", CustomMinimumSize=new(0,840) };
        page.AddThemeConstantOverride("separation",26);
        _content.AddChild(page);
        var summary = new PanelContainer { Name="CashSummary", CustomMinimumSize=new(0,180) };
        var surface = CareerVisuals.Box("203438","485858",8,0);
        surface.ContentMarginLeft=42; surface.ContentMarginRight=39;
        surface.ContentMarginTop=surface.ContentMarginBottom=22;
        summary.AddThemeStyleboxOverride("panel",surface);
        var gradient = new GradientTexture2D { Gradient=new Gradient { Colors=[new Color("203438"),new Color("11222e")] },
            FillFrom=new(0,.35f), FillTo=new(.75f,.65f) };
        summary.Draw += () => {
            summary.DrawTextureRect(gradient,new Rect2(4,2,summary.Size.X-7,summary.Size.Y-4),false);
            summary.DrawLine(new(2,4),new(2,summary.Size.Y-4),_gold,3);
        };
        page.AddChild(summary);
        var metrics = new HBoxContainer { Alignment=BoxContainer.AlignmentMode.Center };
        metrics.AddThemeConstantOverride("separation",42); summary.AddChild(metrics);
        var balance = new VBoxContainer { SizeFlagsHorizontal=SizeFlags.ExpandFill, Alignment=BoxContainer.AlignmentMode.Center };
        balance.AddThemeConstantOverride("separation",4); metrics.AddChild(balance);
        var caption = new HBoxContainer(); caption.AddThemeConstantOverride("separation",10); balance.AddChild(caption);
        caption.AddChild(Glyph("wallet",22,_gold)); caption.AddChild(DashboardLabel("当前可用现金",21,_gold));
        var cash = DashboardLabel(CareerMoney.Format(CareerMoney.Balance(d)),66,_ink); cash.Name="AvailableCash";
        cash.AddThemeFontOverride("font",CareerVisuals.CashFont());
        cash.ClipText=true; balance.AddChild(cash);
        var divider = new ColorRect { Color=new Color("45606a"), CustomMinimumSize=new(1,58), SizeFlagsVertical=SizeFlags.ShrinkCenter };
        metrics.AddChild(divider);
        var ledger = d.Life.Ledger;
        void Metric(string title,string value,Color color)
        {
            var column = new VBoxContainer { Alignment=BoxContainer.AlignmentMode.Center };
            column.AddThemeConstantOverride("separation",6); metrics.AddChild(column);
            column.AddChild(DashboardLabel(title,17,_muted)); column.AddChild(DashboardLabel(value,22,color));
        }
        Metric("已记录收入","+"+CareerMoney.Format(ledger.Where(item=>item.Amount>0).Sum(item=>item.Amount)),CareerVisuals.Teal);
        Metric("已记录支出","−"+CareerMoney.Format(-ledger.Where(item=>item.Amount<0).Sum(item=>item.Amount)),new Color("efaaa3"));

        var columns = new HBoxContainer { SizeFlagsVertical=SizeFlags.ExpandFill };
        columns.AddThemeConstantOverride("separation",25); page.AddChild(columns);
        VBoxContainer Section(string name,int width)
        {
            var section = new VBoxContainer { CustomMinimumSize=new(width,0) };
            if (width==0) section.SizeFlagsHorizontal=SizeFlags.ExpandFill;
            section.AddThemeConstantOverride("separation",0); columns.AddChild(section);
            section.AddChild(new ColorRect { Color=new Color("46606b"), CustomMinimumSize=new(0,1) });
            var heading=DashboardLabel(name,23,_ink); heading.CustomMinimumSize=new(0,66); section.AddChild(heading);
            return section;
        }
        AddLedgerTable(Section("账户流水",0), d, ledger);

        var actions=Section("消费投资",245);
        foreach (var (name,tab,icon) in new[]{("商城","消费商城","store"),("投资","交易市场","chart-candlestick"),("国运","国运榜","landmark")})
        {
            var line=new HBoxContainer(); line.AddThemeConstantOverride("separation",11);
            var tile=new PanelContainer { CustomMinimumSize=new(42,42),SizeFlagsVertical=SizeFlags.ShrinkCenter,MouseFilter=MouseFilterEnum.Ignore };
            tile.AddThemeStyleboxOverride("panel",CareerVisuals.Box("203e46","203e46",6,10));
            tile.AddChild(Glyph(icon,21,CareerVisuals.Teal)); line.AddChild(tile);
            line.AddChild(DashboardLabel(name,20,_ink)); line.AddChild(Glyph("chevron-right",16,_muted));
            ActionRow(actions,"AssetDestination_"+tab,name,()=>OpenLifePage(tab),line,78,14,12,"142733","354c58","203d49");
            actions.AddChild(new Control {CustomMinimumSize=new(0,10),MouseFilter=MouseFilterEnum.Ignore});
        }
    }

    private const int LedgerRowHeight = 58;

    private void AddLedgerTable(VBoxContainer parent, CareerData data, IReadOnlyList<FinanceEntry> ledger, int visibleRows = 0)
    {
        var table = new VBoxContainer { Name = "LedgerTable", SizeFlagsVertical = SizeFlags.ExpandFill,
            MouseFilter = MouseFilterEnum.Stop, MouseForcePassScrollEvents = false };
        if (_scroll is BroadcastScroll page) table.MouseEntered += page.StopMotion;
        table.AddThemeConstantOverride("separation", 0);
        parent.AddChild(table);
        var header = Inset(0, 0);
        table.AddChild(header);
        header.AddChild(LedgerRow(["日期", "款项内容", "收入", "支出", "交易后余额"], true));
        var scroll = new BroadcastScroll { Name = "LedgerScroll", SizeFlagsVertical = SizeFlags.ExpandFill,
            HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled, MouseFilter = MouseFilterEnum.Stop, MouseForcePassScrollEvents = false };
        if (visibleRows > 0) scroll.CustomMinimumSize = new(0, LedgerRowHeight * Math.Clamp(ledger.Count, 1, visibleRows));
        table.AddChild(scroll);
        // The fixed header belongs to the same scroll area as the entries.
        table.GuiInput += input =>
        {
            if (input is InputEventMouseButton wheel && wheel.ButtonIndex is MouseButton.WheelUp or MouseButton.WheelDown)
            {
                if (wheel.Pressed) scroll.ScrollWheel(wheel.ButtonIndex == MouseButton.WheelDown ? 1 : -1, wheel.Factor);
                table.AcceptEvent();
            }
            else if (input is InputEventPanGesture pan)
            {
                scroll.StopMotion();
                var bar = scroll.GetVScrollBar();
                bar.Value += pan.Delta.Y * bar.Page / 8;
                table.AcceptEvent();
            }
        };
        var rows = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill };
        rows.AddThemeConstantOverride("separation", 0);
        scroll.AddChild(rows);
        void AlignHeader() => header.AddThemeConstantOverride("margin_right", Math.Max(0, Mathf.RoundToInt(scroll.Size.X - rows.Size.X)));
        rows.Resized += AlignHeader;
        scroll.Resized += AlignHeader;
        foreach (var item in ledger.Reverse().OrderByDescending(item => item.Day))
            rows.AddChild(LedgerRow([GameCalendar.Date(data, item.Day).ToString("yyyy.MM.dd"), item.Title,
                item.Amount > 0 ? "+" + CareerMoney.Format(item.Amount) : "—",
                item.Amount < 0 ? "−" + CareerMoney.Format(-item.Amount) : "—", CareerMoney.Format(item.Balance)], false));
        if (ledger.Count == 0) rows.AddChild(DashboardLabel("暂无收支记录", 17, CareerVisuals.Muted));
    }

    private static PanelContainer LedgerRow(string[] values,bool heading)
    {
        var panel=new PanelContainer { Name=heading ? "LedgerHeader" : "LedgerRow",CustomMinimumSize=new(0,heading ? 56 : LedgerRowHeight) };
        var style=CareerVisuals.Box(heading ? "1b303e" : "10212d","29414e",0,0);
        style.SetBorderWidthAll(0); style.BorderWidthBottom=1;
        panel.AddThemeStyleboxOverride("panel",style);
        var line=new HBoxContainer(); line.AddThemeConstantOverride("separation",0); panel.AddChild(line);
        int[] shares=[17,32,16,16,19];
        for (int i=0;i<values.Length;i++)
        {
            var cell=Inset(18,9); cell.SizeFlagsStretchRatio=shares[i]; line.AddChild(cell);
            Color color=heading || i==0 ? CareerVisuals.Muted : values[i]=="—" ? new Color("758899") :
                i==2 ? CareerVisuals.Teal : i==3 ? new Color("efaaa3") : CareerVisuals.Ink;
            var label=DashboardLabel(values[i],heading ? 16 : 18,color,wrap:i==1);
            label.ClipText=i!=1; label.HorizontalAlignment=i<2 ? HorizontalAlignment.Left : HorizontalAlignment.Right; cell.AddChild(label);
        }
        if (!heading)
        {
            panel.MouseEntered += () => { style.BgColor=new Color("1a303b"); };
            panel.MouseExited += () => { style.BgColor=new Color("10212d"); };
        }
        return panel;
    }
    private void RankingPage(CareerData d)
    {
        var tabs = TabStrip(_content,18,true,secondary:true);
        foreach (var name in new[] {"人气榜","世界排名","俱乐部排名","联赛个人榜","国运榜","世界荣誉","赛季排名","年度排名"})
            tabs.AddChild(UnderlineTab(name,()=>{ _board=name; Render(); }, _board==name,Math.Max(78,name.Length*18+20),18,ranking:true));
        switch (_board)
        {
            case "世界排名": CircuitRanking(d); break;
            case "国运榜": NationRanking(d); break;
            case "世界荣誉": WorldHonors(d); break;
            case "赛季排名": case "年度排名":
                var editions=d.Ceremonies.Where(c=>_board=="赛季排名" || c.YearTop.Count>0 || c.FullYear.Count>0).OrderByDescending(c=>c.Season).ToList();
                var ceremony=editions.FirstOrDefault(c=>c.Season==_rankSeason)??editions.FirstOrDefault();
                if(ceremony!=null)
                {
                    var select=new OptionButton();foreach(var edition in editions)select.AddItem($"第 {edition.Season} 赛季",edition.Season);
                    select.Select(editions.IndexOf(ceremony));select.ItemSelected+=index=>{_rankSeason=select.GetItemId((int)index);Render();};_content.AddChild(select);
                }
                var entries = _board=="赛季排名" ? ceremony?.FullSeason : ceremony?.FullYear;
                CeremonyRanking(d, entries is {Count:>0}?entries:_board=="赛季排名"?ceremony?.SeasonTop??[]:ceremony?.YearTop??[]);
                if(ceremony!=null) CeremonyCriteria(d,ceremony,_board=="年度排名"); break;
            case "俱乐部排名": case "联赛个人榜":
                var leagues = d.Esports.Competitions.Where(c=>c.Season==d.Season && c.Kind=="league").ToList();
                var regions = new HFlowContainer(); _content.AddChild(regions);
                var league = leagues.FirstOrDefault(c=>c.Country==_rankRegion) ?? leagues.FirstOrDefault(c=>c.Country==d.Esports.Country) ?? leagues.FirstOrDefault();
                foreach (var c in leagues) regions.AddChild(CaptionButton(c.Country,()=>{_rankRegion=c.Country;Render();},c==league));
                if (league != null) LeagueTable(d,league,_board=="俱乐部排名");
                else _content.AddChild(Text("本赛季尚无联赛排名",17,_muted));
                break;
            default: FanChart(d); break;
        }
    }
    private void LeagueTable(CareerData d, WorldCompetition c, bool clubs)
    {
        if (clubs)
        {
            _content.AddChild(Text("俱乐部积分：胜3分、平1分、负0分；同分比较个人对决胜场。前二进入洲际杯。",17,_ink));
            int rank=0;
            foreach (var row in CircuitWorld.TeamTable(c)) _content.AddChild(Text($"{++rank:00}   {CircuitWorld.TeamName(d,c,row.PersonId)}    {row.Points}分    {row.Wins}胜 {row.Draws}平 {row.Losses}负",19,row.PersonId==d.Esports.ClubId?_gold:_ink));
        }
        else if(c.Modern)
        {
            _content.AddChild(Text("奇数赛季个人表现前二自动进入世界总决赛；其余席位按世界积分和本季表现补齐。",17,CareerVisuals.Teal));
            foreach (var (row,rank) in EsportsWorld.Rankings(c).Take(6))
                _content.AddChild(PersonLink(d,row.PersonId,$"{rank:00}   {CareerEngine.DisplayName(d,row.PersonId)}   {row.Wins}胜 {row.Losses}负   ↗",36));
        }
        else LegacyLeagueTable(d,c);
    }
}
