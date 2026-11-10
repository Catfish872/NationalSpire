using Godot;

namespace NationalSpire;

internal static class OpeningWorldEditor
{
    internal static void Draw(VBoxContainer parent, CareerOpeningWorld world)
    {
        var card=new BroadcastPanel { Accent=CareerVisuals.Gold };
        card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("152633","365565",10,16));parent.AddChild(card);
        var body=new VBoxContainer();card.AddChild(body);
        var heading=new Label{Text="赛季与俱乐部"}; heading.AddThemeColorOverride("font_color",CareerVisuals.Gold);body.AddChild(heading);
        var row=new HFlowContainer(); row.AddThemeConstantOverride("h_separation",12);body.AddChild(row);
        VBoxContainer Field(string caption)
        {
            var col=new VBoxContainer();row.AddChild(col);col.AddChild(new Label{Text=caption});return col;
        }
        var season=new SpinBox{MinValue=1,MaxValue=100,AllowGreater=true,Step=1,Value=world.Season,CustomMinimumSize=new(120,40)};
        Field("加入赛季").AddChild(season);season.ValueChanged+=v=>world.Season=(int)v;
        OptionButton Choice(string caption,string[] names,string[] values,string current,Action<string> set)
        {
            var box=new OptionButton{FitToLongestItem=false,CustomMinimumSize=new(150,40)};Field(caption).AddChild(box);
            foreach(var n in names) box.AddItem(n);box.Select(Math.Max(0,Array.IndexOf(values,current)));box.ItemSelected+=i=>set(values[(int)i]);return box;
        }
        var extras=new HFlowContainer();body.AddChild(extras);var top=row;row=extras;
        var name=new LineEdit{Text=world.ClubName,PlaceholderText="俱乐部名称",CustomMinimumSize=new(166,40)};Field("队名").AddChild(name);name.TextChanged+=v=>world.ClubName=v;
        Choice("参赛地区",["沿用赛区",..EsportsWorld.Countries],["",..EsportsWorld.Countries],world.ClubCountry,v=>world.ClubCountry=v);
        Choice("俱乐部赞助",["无赞助","稳定支持","成绩奖励","品牌推广"],["","steady","results","fans"],world.ClubSponsor,v=>world.ClubSponsor=v);
        row=top;extras.Visible=world.ClubMode=="自建";
        Choice("俱乐部",["自由选手","加盟现有俱乐部","创建俱乐部"],["","加盟","自建"],world.ClubMode,v=>{world.ClubMode=v;extras.Visible=v=="自建";});
        var expanded=new VBoxContainer{Visible=world.Levels.Count>0};
        var show=new CareerDisclosureButton{Text="各国初始发展水平",ArrowOnLeft=true,ToggleMode=true,ButtonPressed=expanded.Visible};
        body.AddChild(show);body.AddChild(expanded);show.Toggled+=on=>expanded.Visible=on;
        var countries=new HFlowContainer();expanded.AddChild(countries);var grid=new GridContainer{Columns=3};expanded.AddChild(grid);
        var tabs=new ButtonGroup();string chosen=EsportsWorld.Countries[0];
        void Nation()
        {
            CareerVisuals.ClearContent(grid);
            foreach(var indicator in NationalDevelopment.All)
            {
                var field=new VBoxContainer{SizeFlagsHorizontal=Control.SizeFlags.ExpandFill};grid.AddChild(field);field.AddChild(new Label{Text=indicator.Name});
                var choices=new OptionButton();choices.AddItem("沿用世界发展");for(int i=0;i<=9;i++)choices.AddItem(i+" 级");
                choices.Select(world.Levels.GetValueOrDefault(chosen)?.TryGetValue(indicator.Id,out int lvl)==true?lvl+1:0);
                field.AddChild(choices);string nation=chosen;choices.ItemSelected+=index=>{
                    if(!world.Levels.TryGetValue(nation,out var levels)) world.Levels[nation]=levels=[];
                    if(index>0)levels[indicator.Id]=(int)index-1;else levels.Remove(indicator.Id);
                    if(levels.Count==0)world.Levels.Remove(nation);
                };
            }
        }
        foreach(var n in EsportsWorld.Countries)
        {
            var b=new BroadcastButton{Text=n,ToggleMode=true,ButtonGroup=tabs,ButtonPressed=n==chosen};countries.AddChild(b);
            b.Pressed+=()=>{chosen=n;Nation();};
        }
        Nation();
    }
}
