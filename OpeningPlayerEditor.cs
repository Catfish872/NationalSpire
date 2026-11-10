using Godot;

namespace NationalSpire;

internal static class OpeningPlayerEditor
{
    internal static void Draw(VBoxContainer parent,CareerOpeningPlayer player,string defaultName,string defaultCountry,string? teamCountry=null,Action<string>? countryChanged=null)
    {
        var body=OpeningControls.Section(parent,"选手档案","contact-round","头像 · 身份 · 人物介绍",true);
        var dossier=new HBoxContainer();dossier.AddThemeConstantOverride("separation",18);body.AddChild(dossier);
        var portrait=new Button{CustomMinimumSize=new(108,108),SizeFlagsVertical=Control.SizeFlags.ShrinkCenter,AccessibilityName="选择头像",TooltipText="选择头像"};
        dossier.AddChild(portrait);
        var badge=new CareerAvatar{MouseFilter=Control.MouseFilterEnum.Ignore};portrait.AddChild(badge);badge.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect);badge.OffsetLeft=badge.OffsetTop=8;badge.OffsetRight=badge.OffsetBottom=-8;
        void Face(){badge.Art=AvatarImages.Read(player.Avatar??new())??CareerAvatars.Automatic(new CareerData(),"player");}
        Face();portrait.Pressed+=()=>CareerScreen.ChooseOpeningAvatar(parent,player.Avatar,avatar=>{player.Avatar=avatar;Face();});
        var details=new VBoxContainer{SizeFlagsHorizontal=Control.SizeFlags.ExpandFill};dossier.AddChild(details);
        var fields=new HBoxContainer();fields.AddThemeConstantOverride("separation",16);details.AddChild(fields);
        var name=new LineEdit{Text=player.Name,PlaceholderText=defaultName};OpeningControls.Field(fields,"姓名").AddChild(name);name.TextChanged+=v=>player.Name=v;
        var genders=new HBoxContainer();OpeningControls.Field(fields,"性别").AddChild(genders);var group=new ButtonGroup();
        foreach(var gender in IdentityGender.Choices)
            OpeningControls.Chip(genders,group,gender,gender==(player.Gender.Length==0?IdentityGender.Unset:player.Gender),()=>player.Gender=gender);
        var nations=new HFlowContainer();OpeningControls.Field(details,"国籍").AddChild(nations);var flags=new ButtonGroup();
        foreach(var n in EsportsWorld.Countries) OpeningControls.Chip(nations,flags,n,n==(player.Country.Length==0?defaultCountry:player.Country),()=>{player.Country=n;countryChanged?.Invoke(n);});
        if(teamCountry!=null) body.AddChild(OpeningControls.Label($"全队代表{teamCountry}参赛，外汇按{teamCountry}报价。"));
        var bio=new TextEdit{Text=player.Biography,PlaceholderText="写下选手的经历、身份或希望别人知道的事",CustomMinimumSize=new(0,66),WrapMode=TextEdit.LineWrappingMode.Boundary};
        OpeningControls.Field(body,"人物介绍").AddChild(bio);bio.TextChanged+=()=>player.Biography=bio.Text;
        var history=OpeningControls.Section(parent,"生涯起点","chart-no-axes-combined","资金 · 关注 · 战绩");
        var grid=new GridContainer{Columns=3};grid.AddThemeConstantOverride("h_separation",12);grid.AddThemeConstantOverride("v_separation",8);history.AddChild(grid);
        void Number(string title,string value,string hint,Action<string> set)
        {var input=new LineEdit{Text=value,PlaceholderText=hint};OpeningControls.Field(grid,title).AddChild(input);input.TextChanged+=set.Invoke;}
        int? Count(string s)=>int.TryParse(s,out var n)&&n>=0?n:null;
        Action refreshTerms=()=>{};
        Number("初始资金（美元）",player.Credits?.ToString()??"","0",s=>player.Credits=decimal.TryParse(s,out var n)&&n>=0?n:null);
        Number("个人关注",player.Fans?.ToString()??"","28",s=>{player.Fans=Count(s);refreshTerms();});
        grid.AddChild(new Control());
        Number("胜场",player.Wins?.ToString()??"","0",s=>player.Wins=Count(s));Number("平局",player.Draws?.ToString()??"","0",s=>player.Draws=Count(s));Number("负场",player.Losses?.ToString()??"","0",s=>player.Losses=Count(s));
        var sponsor=OpeningControls.Section(parent,"个人赞助","handshake","品牌与合同");
        var summary=OpeningControls.Label("",18,CareerVisuals.Gold);sponsor.AddChild(summary);
        var tools=new HBoxContainer();sponsor.AddChild(tools);
        var filter=new LineEdit{PlaceholderText="搜索品牌、赛区或赞助类型",SizeFlagsHorizontal=Control.SizeFlags.ExpandFill};tools.AddChild(filter);
        var none=new BroadcastButton{Text="无赞助"};tools.AddChild(none);
        var cards=new GridContainer{Columns=3};cards.AddThemeConstantOverride("h_separation",8);cards.AddThemeConstantOverride("v_separation",8);sponsor.AddChild(cards);
        var pager=new HBoxContainer();sponsor.AddChild(pager);
        var prev=new BroadcastButton{Text="上一页"};var pageLabel=OpeningControls.Label("");pageLabel.SizeFlagsHorizontal=Control.SizeFlags.ExpandFill;pageLabel.HorizontalAlignment=HorizontalAlignment.Center;
        var next=new BroadcastButton{Text="下一页"};pager.AddChild(prev);pager.AddChild(pageLabel);pager.AddChild(next);
        var catalog=RegionalOrganizations.SponsorCatalog().ToArray();string[] types=["稳定支持","成绩奖励","品牌推广"];int page=0;
        void DrawOffers(){
            CareerVisuals.ClearContent(cards);var matches=catalog.Where(o=>(o.Brand+o.Country+types[o.Sector]).Contains(filter.Text.Trim(),StringComparison.OrdinalIgnoreCase)).ToList();
            int pages=Math.Max(1,(matches.Count+5)/6);page=Math.Clamp(page,0,pages-1);
            foreach(var o in matches.Skip(page*6).Take(6)){
                var pick=new BroadcastButton{Text=o.Brand+"  ·  "+o.Country+"\n"+types[o.Sector],CustomMinimumSize=new(0,60),SizeFlagsHorizontal=Control.SizeFlags.ExpandFill,ToggleMode=true,ButtonPressed=player.Sponsor==o.Brand};
                cards.AddChild(pick);pick.Pressed+=()=>{player.Sponsor=o.Brand;refreshTerms();DrawOffers();};
            }
            if(matches.Count==0)cards.AddChild(OpeningControls.Label("没有匹配的品牌"));
            pageLabel.Text=$"{page+1} / {pages}";prev.Disabled=page==0;next.Disabled=page+1==pages;
        }
        refreshTerms=()=>{
            var o=catalog.FirstOrDefault(x=>x.Brand==player.Sponsor);
            if(o.Brand==null){summary.Text="无赞助 · 进入生涯后仍可签约";return;}
            var preview=new CareerData{Fans=player.Fans??28};
            var contract=CareerCommerce.BuildPersonalOffer(preview,o.Sector,o.Brand,1,SponsorIncome.PersonalTier(preview));
            summary.Text=$"{o.Brand}  ·  {contract.Plan}    基础赛季支持 {CareerMoney.Format(contract.Retainer)}  ·  胜场奖金 {CareerMoney.Format(contract.WinBonus)}"+(contract.FanBonus>0?$"  ·  关注 +{contract.FanBonus}":"");
        };
        refreshTerms();DrawOffers();filter.TextChanged+=_=>{page=0;DrawOffers();};none.Pressed+=()=>{player.Sponsor="";refreshTerms();DrawOffers();};
        prev.Pressed+=()=>{page--;DrawOffers();};next.Pressed+=()=>{page++;DrawOffers();};
    }
}