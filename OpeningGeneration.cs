using System.Text.Json;
using System.Text.Json.Serialization;

namespace NationalSpire;

internal static class OpeningGeneration
{
    private sealed class Form
    {
        public string? Name {get;set;}
        public string? Biography {get;set;}
        public string? Avatar {get;set;}
        [JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)] public string? TeamCountry {get;set;}
        public string? Country {get;set;}
        public string? Gender {get;set;}
        public decimal? Credits {get;set;}
        public int? Wins {get;set;}
        public int? Draws {get;set;}
        public int? Losses {get;set;}
        public string? Sponsor {get;set;}
        public int? Season {get;set;}
        public string? ClubMode {get;set;}
        public string? ClubName {get;set;}
        public string? ClubCountry {get;set;}
        public string? ClubSponsor {get;set;}
        public Dictionary<string,Dictionary<string,int>>? Levels {get;set;}
        public string? PromptTemplate {get;set;}
        public int? RivalLevel {get;set;}
        public Dictionary<string,double>? Weights {get;set;}
        public Dictionary<string,Dictionary<string,double>>? StyleWeights {get;set;}
    }
    internal const string Instruction="根据玩家描述填写这次生涯的开局设置。保留玩家明确指定的内容，其余设置结合描述和可选值填写。玩家介绍用可直接放入人物档案的文字。只返回本次开局配置。";
    internal static async Task Generate(NpcGenerationSetup setup,string guide,CancellationToken token)
    {
        var ai=setup.Ai!;var p=setup.Personal;var w=setup.World;
        var avatars=AvatarSources.Characters();
        var current=new Form{TeamCountry=setup.TeamCountry,Avatar=p.Avatar?.Label,Name=p.Name,Biography=p.Biography,Country=p.Country,Gender=p.Gender,Credits=p.Credits,Wins=p.Wins,Draws=p.Draws,Losses=p.Losses,
            Sponsor=p.Sponsor,Season=w.Season,ClubMode=w.ClubMode,ClubName=w.ClubName,ClubCountry=w.ClubCountry,ClubSponsor=w.ClubSponsor,Levels=w.Levels,
            PromptTemplate=PromptLibrary.TemplateId(ai),RivalLevel=setup.RivalLevel, Weights=setup.Pool.Categories.ToDictionary(c=>c.Id,c=>c.Weight),
            StyleWeights=setup.Pool.Categories.ToDictionary(c=>c.Id,c=>c.Styles.ToDictionary(s=>s.Id,s=>s.Weight))};
        var templates=PromptLibrary.AvailableTemplates(ai).ToArray();
        var options=new { 国籍和赛区=EsportsWorld.Countries,游戏头像=avatars.Select(a=>a.Name),性别=IdentityGender.Choices,个人赞助=RegionalOrganizations.SponsorCatalog().Select(s=>s.Brand),
            俱乐部形式=new[]{"","加盟","自建"},俱乐部赞助=new[]{"","steady","results","fans"},国运指标=NationalDevelopment.All.Select(i=>new{i.Id,i.Name}),
            提示词模板=templates.Select(t=>new{t.Id,t.Name}),性格分类=setup.Pool.Categories.Select(c=>new{c.Id,c.Name,styles=c.Styles.Select(s=>new{s.Id,s.Name})}),对手水平=AiSettingsPanel.RivalLevels };
        var messages=new List<Dictionary<string,string>>{
            new(){["role"]="system",["content"]=Instruction},
            new(){["role"]="user",["content"]="开局设置 JSON（Credits 为美元，Levels 按赛区、指标编号填写 0 至 9 级，Weights 为类别百分比，StyleWeights 为各类别内风格的百分比，各组合计 100）\n"
                +JsonSerializer.Serialize(current,DateSceneParty.PromptJson)+"\n可选值\n"+JsonSerializer.Serialize(options,DateSceneParty.PromptJson)+"\n玩家描述\n"+guide}};
        var context=new CareerData{Ai=ai};using var timeout=CancellationTokenSource.CreateLinkedTokenSource(token);
        timeout.CancelAfter(TimeSpan.FromMinutes(Math.Clamp(ai.RequestTimeoutMinutes,2,30)));
        var reply=await AiService.RequestPrivateAsync(context,messages,false,null,timeout.Token,context:"career-opening",task:AiRouting.Default);
        var start=reply.IndexOf('{');var end=reply.LastIndexOf('}');
        if(start<0||end<start)throw new InvalidDataException("模型未返回开局配置。");
        var f=JsonSerializer.Deserialize<Form>(reply[start..(end+1)],new JsonSerializerOptions{PropertyNameCaseInsensitive=true}) ?? throw new InvalidDataException("模型返回的开局配置为空。");
        token.ThrowIfCancellationRequested();
        if(setup.TeamCountry!=null && EsportsWorld.Countries.Contains(f.TeamCountry))setup.TeamCountry=f.TeamCountry;
        if(f.Avatar is { Length:>0 } label && label!=current.Avatar && avatars.FirstOrDefault(a=>a.Name==label)?.Read() is { } art && AvatarAssets.Usable(art.Texture))
            p.Avatar=AvatarImages.FromArt(art,"character");
        p.Name=f.Name??p.Name;p.Biography=f.Biography??p.Biography;
        if(EsportsWorld.Countries.Contains(f.Country))p.Country=f.Country!;if(IdentityGender.Choices.Contains(f.Gender))p.Gender=f.Gender!;
        if(f.Credits>=0)p.Credits=f.Credits;if(f.Wins>=0)p.Wins=f.Wins;if(f.Losses>=0)p.Losses=f.Losses;if(f.Draws>=0)p.Draws=f.Draws;
        if(f.Sponsor==""||RegionalOrganizations.SponsorCatalog().Any(s=>s.Brand==f.Sponsor))p.Sponsor=f.Sponsor!;
        if(f.Season>0)w.Season=f.Season.Value;if(f.ClubMode is "" or "加盟" or "自建")w.ClubMode=f.ClubMode;
        w.ClubName=f.ClubName??w.ClubName;if(EsportsWorld.Countries.Contains(f.ClubCountry))w.ClubCountry=f.ClubCountry!;
        if(f.ClubSponsor is "" or "steady" or "results" or "fans")w.ClubSponsor=f.ClubSponsor;
        if(f.Levels!=null) foreach(var (n,levels) in f.Levels.Where(x=>EsportsWorld.Countries.Contains(x.Key)))
            foreach(var i in NationalDevelopment.All)if(levels.TryGetValue(i.Id,out int level)&&level is >=0 and <=9)
                { if(!w.Levels.ContainsKey(n))w.Levels[n]=[];w.Levels[n][i.Id]=level; }
        if(templates.Any(t=>t.Id==f.PromptTemplate)&&f.PromptTemplate!=current.PromptTemplate)
            {PromptLibrary.SelectTemplate(ai,f.PromptTemplate!);setup.Pool=PersonalityPools.Read(ai);}
        if(f.RivalLevel is { } rival && AiSettingsPanel.RivalLevels.Contains(rival))setup.RivalLevel=rival;
        if(f.StyleWeights!=null) foreach(var c in setup.Pool.Categories)
            if(f.StyleWeights.TryGetValue(c.Id,out var styles)) foreach(var s in c.Styles)
                if(styles.TryGetValue(s.Id,out var value)&&double.IsFinite(value)&&value>=0)s.Weight=value;
        if(f.Weights!=null)foreach(var c in setup.Pool.Categories)if(f.Weights.TryGetValue(c.Id,out var rate)&&rate>=0)c.Weight=rate;
    }
}
