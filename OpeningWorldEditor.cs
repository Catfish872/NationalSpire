using Godot;

namespace NationalSpire;

internal static class OpeningWorldEditor
{
    internal static Action<string> Draw(VBoxContainer parent, CareerOpeningWorld world,string region="中国")
    {
        var body=OpeningControls.Section(parent,"赛季与俱乐部","trophy","加入时间 · 参赛身份",true);
        var row=new HBoxContainer(); row.AddThemeConstantOverride("separation",18);body.AddChild(row);
        VBoxContainer Field(string caption)
        {
            var col=new VBoxContainer();row.AddChild(col);col.AddChild(new Label{Text=caption});return col;
        }
        var season=new SpinBox{MinValue=1,MaxValue=100,AllowGreater=true,Step=1,Value=world.Season,CustomMinimumSize=new(120,40)};
        Field("加入赛季").AddChild(season);season.ValueChanged+=v=>world.Season=(int)v;
        var clubField=Field("参赛身份");clubField.SizeFlagsHorizontal=Control.SizeFlags.ExpandFill;
        var modes=new HFlowContainer();clubField.AddChild(modes);
        var extras=new VBoxContainer();body.AddChild(extras);extras.Visible=world.ClubMode=="自建";
        var join=new HBoxContainer();join.AddThemeConstantOverride("separation",12);body.AddChild(join);join.Visible=world.ClubMode=="加盟";
        join.AddChild(CareerScreen.Glyph("flag",22,CareerVisuals.Teal));
        var team=OpeningControls.Label(world.JoiningClub is { } c?$"{c.Name}  ·  {c.Country}赛区":"开始时选择俱乐部",20,CareerVisuals.Ink);
        team.SizeFlagsHorizontal=Control.SizeFlags.ExpandFill;join.AddChild(team);
        var group=new ButtonGroup();
        foreach(var (id,label) in new[]{("","自由选手"),("加盟","加盟现有俱乐部"),("自建","创建俱乐部")})
            OpeningControls.Chip(modes,group,label,world.ClubMode==id,()=>{world.ClubMode=id;extras.Visible=id=="自建";join.Visible=id=="加盟";});
        var name=new LineEdit{Text=world.ClubName,PlaceholderText="俱乐部名称"};OpeningControls.Field(extras,"队名").AddChild(name);name.TextChanged+=v=>world.ClubName=v;
        var regions=new HFlowContainer();OpeningControls.Field(extras,"俱乐部赛区").AddChild(regions);var regionGroup=new ButtonGroup();
        var terms=OpeningControls.Label("");
        var regionButtons=EsportsWorld.Countries.ToDictionary(n=>n,n=>OpeningControls.Chip(regions,regionGroup,n,n==(world.ClubCountry.Length==0?region:world.ClubCountry),()=>{world.ClubCountry=n;Terms();}));
        var sponsors=new HFlowContainer();OpeningControls.Field(extras,"建队赞助").AddChild(sponsors);var sponsorGroup=new ButtonGroup();
        extras.AddChild(terms);
        void Terms(){if(world.ClubSponsor==""){terms.Text="无赞助收入";return;}
            var d=new CareerData();d.Esports.Country=world.ClubCountry.Length==0?region:world.ClubCountry;var offer=OwnedClubs.SponsorQuote(d,world.ClubSponsor);
            terms.Text=$"每周支持 {CareerMoney.Format(offer.Weekly)}    胜场奖金 {CareerMoney.Format(offer.WinBonus)}"; }
        foreach(var (id,label) in new[]{("","无赞助"),("steady","稳定支持"),("results","成绩奖励"),("fans","品牌推广")})
            OpeningControls.Chip(sponsors,sponsorGroup,label,id==world.ClubSponsor,()=>{world.ClubSponsor=id;Terms();});
        Terms();
        var expanded=OpeningControls.Section(parent,"各国初始发展水平","landmark","经济 · 社会 · 民生",world.Levels.Count>0);
        expanded.AddChild(OpeningControls.Label("每项默认随世界发展。拖动滑块指定加入生涯时的等级，点击还原可恢复自然发展。"));
        var countries=new HFlowContainer();expanded.AddChild(countries);var grid=new GridContainer{Columns=3};grid.AddThemeConstantOverride("h_separation",18);grid.AddThemeConstantOverride("v_separation",12);expanded.AddChild(grid);
        var tabs=new ButtonGroup();string chosen=EsportsWorld.Countries[0];
        void Nation()
        {
            CareerVisuals.ClearContent(grid);
            foreach(var indicator in NationalDevelopment.All)
            {
                var field=new VBoxContainer{SizeFlagsHorizontal=Control.SizeFlags.ExpandFill};grid.AddChild(field);field.AddChild(new Label{Text=indicator.Name});
                string nation=chosen;bool custom=world.Levels.GetValueOrDefault(nation)?.TryGetValue(indicator.Id,out _)==true;
                var level=new HSlider{MinValue=0,MaxValue=9,Step=1,TickCount=10,TicksOnBorders=true,Value=world.Levels.GetValueOrDefault(nation)?.GetValueOrDefault(indicator.Id)??0,CustomMinimumSize=new(115,34),SizeFlagsHorizontal=Control.SizeFlags.ExpandFill};
                var line=new HBoxContainer();field.AddChild(line);line.AddChild(level);
                var readout=new Label{Text=custom?$"{level.Value:0} 级":"自然",CustomMinimumSize=new(42,0)};line.AddChild(readout);
                var reset=new BroadcastButton{Text="还原",Disabled=!custom};line.AddChild(reset);
                void Set(int value){if(!world.Levels.TryGetValue(nation,out var levels))world.Levels[nation]=levels=[];levels[indicator.Id]=value;readout.Text=$"{value} 级";reset.Disabled=false;}
                level.ValueChanged+=v=>Set((int)v);level.DragStarted+=()=>Set((int)level.Value);
                reset.Pressed+=()=>{if(world.Levels.TryGetValue(nation,out var levels)){levels.Remove(indicator.Id);if(levels.Count==0)world.Levels.Remove(nation);}level.SetValueNoSignal(0);readout.Text="自然";reset.Disabled=true;};
            }
        }
        foreach(var n in EsportsWorld.Countries)
        {
            var b=new BroadcastButton{Text=n,ToggleMode=true,ButtonGroup=tabs,ButtonPressed=n==chosen};countries.AddChild(b);
            b.Pressed+=()=>{chosen=n;Nation();};
        }
        Nation();
        return n=>{region=n;if(world.ClubCountry.Length==0 && regionButtons.TryGetValue(n,out var current)){current.ButtonPressed=true;Terms();}};
    }
}
