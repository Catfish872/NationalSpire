namespace NationalSpire;

/// <summary>国际赛事国运分配至国家维护与发展，赛季开始结算维护和人均产值变化。</summary>
public static class NationalDevelopment
{
    public const int Version = 2;

    /// <summary>0→1 … 8→9 的升级价（凹形：前期便宜、9 级仍贵）。</summary>
    private static readonly int[] Costs = [100, 120, 150, 190, 240, 300, 380, 480, 600];

    private static readonly string[] Groups = ["经济", "社会", "民生"];

    /// <summary>GDP 增速的结构权重（合计 1.0）。用上赛季末的等级计算，所以收入也能纳入而不会自激。</summary>
    private static readonly Dictionary<string, double> GrowthWeight = new()
    {
        ["industry"] = 0.16, ["agriculture"] = 0.08, ["services"] = 0.16,
        ["security"] = 0.10, ["unity"] = 0.08, ["sentiment"] = 0.08,
        ["publicService"] = 0.12, ["infrastructure"] = 0.10, ["income"] = 0.12,
    };

    public sealed record Indicator(string Id, string Name, string Group, string[] Levels);

    public static readonly Indicator[] All =
    [
        new("industry", "工业水平", "经济",
        [
            "除手工作坊与零星采矿，几乎没有现代工业，工业品全部依赖进口或黑市。",
            "只有少量初级加工厂与轻工业，重工业空白，现代工业品极度依赖进口。",
            "能生产基础消费品与简单机械，重工业薄弱，高附加值产品完全靠进口。",
            "大部分基础工业品可以自产，中端产品部分国产，高端环节仍受制于人。",
            "重工业基础扎实，轻工业门类齐全，制造业约占 GDP 15%，技术升级缓慢。",
            "工业体系完整，高端制造起步，制造业占 GDP 15%–20%，出口有竞争力。",
            "重工业与高端制造均衡，关键领域基本自主，工业机器人密度领先。",
            "从精密机床到航空发动机基本自主，技术工人占劳动人口多数。",
            "全产业链自主可控，引领新一代工业革命，工业产值占 GDP 超 30%。",
            "高度智能、绿色、分布式的制造体系，工业与服务业深度融合并定义全球标准。",
        ]),
        new("agriculture", "农业水平", "经济",
        [
            "种粮只为糊口，几乎没有余粮，一遇天灾即成饥荒；化肥与农机极度匮乏。",
            "勉强糊口，余粮极少，饥荒变少但仍然存在；粮食靠配给，化肥农药稀缺。",
            "铁制农具与畜力为主，化肥稀缺，产量低且不稳，灾年需要大量进口。",
            "化肥与良种有限使用，单位产量中等，主要产粮区基本自给。",
            "平原地区部分机械化，多数农村仍靠人力畜力；粮食自给但没有余粮。",
            "主要产粮区实现机械化，偏远地区仍用畜力；粮食自给有余。",
            "拖拉机、化肥与良种普及，农业产出率高，农村基础设施完善。",
            "少数农业人口养活全国，粮食与农产品出口是重要外汇来源。",
            "卫星导航、无人机与智能灌溉普及，农业碳足迹低，出口高附加值农产品。",
            "垂直农场、细胞农业与 AI 管理，农业与生态协调，粮食安全绝对保障。",
        ]),
        new("services", "高新与服务产业", "经济",
        [
            "除政府机构与零星商店，几乎没有现代服务业，基础服务网络瘫痪。",
            "只有少量零售、修理与小商业，集中在首都；生产性服务业近乎为零。",
            "零售、修理与小商业遍布城乡，生产性服务业薄弱，服务业占 GDP 30%–40%。",
            "商业、餐饮、运输等传统服务业吸纳大量就业，高端服务开始出现，占 GDP 40%–50%。",
            "银行、保险、法律与咨询成熟，高等教育普及率较高，服务业占 GDP 50%–60%。",
            "金融、教育、医疗与科研成为支柱，信息与数字经济发达，占 GDP 60%–70%。",
            "研发投入占 GDP 超 4%，专利与版权出口领先，服务业与制造业深度融合。",
            "数字经济占 GDP 超 60%，远程办公普及，城乡数字鸿沟基本消除。",
            "AI、量子计算与生物科技引领，个性化服务普及，工作时长大幅缩短。",
            "人人享有优质服务，工作与生活平衡，服务业与自然和谐共生。",
        ]),
        new("security", "治安稳定", "社会",
        [
            "帮派与极端组织活跃，有组织犯罪频发，部分地区处于无人管辖状态。",
            "政府权威受挑战，暴力犯罪高发，警力疲于奔命，部分地区由地方势力控制。",
            "犯罪率偏高，示威时有发生，偏远地区控制力薄弱，秩序主要靠警力维持。",
            "大城市治安尚可，偏远地区仍有犯罪与骚乱，警力资源紧张。",
            "偶有犯罪与示威，政府能有效控制，司法系统基本正常运转。",
            "街头安全，抗议稀少且和平，司法运转正常，警察受民众信任。",
            "犯罪率极低，警务高效且受尊重，社区自治与专业警务结合。",
            "恶性案件几乎绝迹，社会信任度高，人们普遍感到安全而自由。",
            "社区自治与专业警务完美衔接，维持治安的社会成本极低。",
            "夜不闭户、路不拾遗，人人安居乐业，安全已不再需要被讨论。",
        ]),
        new("unity", "人群团结", "社会",
        [
            "阶级或民族矛盾激化，暴力冲突频发，社会共识瓦解。",
            "不同群体视彼此为敌人，贫富阶层彼此隔绝，城乡对立尖锐。",
            "社会分裂为敌对的阵营，性别与族群暴力普遍，阶层之间筑起高墙。",
            "政治极化，罢工与族群冲突常态化，性别与阶层差距持续扩大。",
            "存在阶层与地区矛盾，权利名义平等而实际差距明显。",
            "贫富、城乡与性别差异显著，靠惯性与强制力维持，偶发歧视引发争议。",
            "主流群体间有共识，少数群体与女性仍受一定歧视，但总体可控。",
            "各群体基本和谐，平等政策落实较好，贫富差距在可控范围。",
            "阶级、民族与性别之间几乎没有隔阂，国家认同感强，社会流动性高。",
            "歧视被彻底消除，机会完全平等，人人都有归属感。",
        ]),
        new("sentiment", "社会风向", "社会",
        [
            "弥漫末日情绪，阴谋论与极端意识形态大行其道。",
            "民众陷入恐慌，抢购、逃亡与私刑成为常态，舆论被极端声音主导。",
            "街头抗议与暴力增多，极端组织招募顺利，社交平台充斥仇恨言论。",
            "对现状普遍不满，怀旧与极端思想蔓延，公共讨论充满戾气。",
            "人们对公共事务漠不关心，只关心自己与家人的生存，情绪低沉。",
            "专注个人生活，政治冷感但情绪稳定，流行文化偏向娱乐。",
            "有抱怨但总体满意，文化创作活跃，人们愿意参与公共事务。",
            "多数人相信日子会变好，风气开放包容，志愿服务与社区活动增多。",
            "对未来充满信心，流行文化繁荣，公共讨论理性而活跃。",
            "社会充满希望与善意，舆论理性，文化百花齐放，人们普遍感到幸福。",
        ]),
        new("publicService", "公共服务", "民生",
        [
            "医院缺药、学校缺师，供水供电时断时续。",
            "医院勉强开门却严重缺员，学校断续停课，疫病流行，公共品极度匮乏。",
            "只有大城市有像样的医院与学校，农村基本靠自救。",
            "城市有正规医院与学校，农村靠简陋诊所与识字班，质量参差。",
            "主要城市服务齐全，农村有基本保障，城乡差距明显。",
            "城乡基本医保与学校覆盖，供水供电可靠，服务质量较好。",
            "免费医疗与教育覆盖全国，水电稳定，城乡差距较小。",
            "全民医保、免费高等教育与智慧政务，服务响应迅速且个性化。",
            "公共服务与科技深度融合，质量全球领先，民众满意度极高。",
            "从摇篮到坟墓的全生命周期保障，公共服务成为社会最自豪的基石。",
        ]),
        new("infrastructure", "基础设施", "民生",
        [
            "部分桥梁倒塌、铁路中断，跨区域交通与通讯不畅。",
            "公路铁路大面积损毁，港口淤塞，通讯靠人力传递，跨区域交通基本中断。",
            "道路坑洼，铁路年久失修，经常停电停水，通讯覆盖有限且不稳定。",
            "只有几条主要铁路与公路，通讯依赖邮政，电力供应不稳定。",
            "主要城市间有铁路与公路，农村道路差，电力与通讯覆盖主要城镇。",
            "铁路与公路网基本成型，偏远地区仍不便，电力与通讯覆盖大部分地区。",
            "主要城市与工业区交通便利，电力通讯覆盖大部分国土，维护良好。",
            "高速、铁路、港口、电网与通讯全覆盖且维护良好，区域发展均衡。",
            "交通、能源与通讯全面数字化，基础设施与城市管理深度融合。",
            "超高速轨道、全域 5G/6G、智能电网与绿色建筑，基建与自然和谐共生。",
        ]),
        new("income", "人均收入", "民生",
        [
            "日均不足十美元，靠国际援助或非正规经济维生。",
            "在贫困线附近，经常要削减食物或医疗开支，几乎没有储蓄。",
            "收入仅够基本生活，教育与医疗是沉重负担。",
            "温饱有余而改善空间大，高房价压缩可支配收入。",
            "基本生活无忧，教育与医疗仍是较大负担，储蓄有限。",
            "生活无忧，耐用品消费普遍，高税负或高房价影响生活质量。",
            "多数家庭有稳定高收入，能负担教育、医疗与奢侈消费。",
            "中产占绝对多数，消费与投资能力强，社会福利完善。",
            "全民财务自由，工作时长大幅缩短，生活质量领先。",
            "物质极大丰富，精神文化需求得到满足，人人有充分发展机会。",
        ]),
    ];

    /// <summary>9 项指标基值，顺序与 All 一致。9 级是"理想国"，所以起点压在 3–7 的中段。</summary>
    private static readonly Dictionary<string, int[]> BaseLevels = new()
    {
        ["中国"] = [6, 5, 5, 6, 5, 5, 5, 6, 3],
        ["日本"] = [6, 4, 6, 6, 5, 5, 6, 6, 4],
        ["韩国"] = [6, 4, 6, 5, 5, 5, 5, 6, 4],
        ["德国"] = [6, 5, 6, 6, 6, 6, 6, 6, 5],
        ["法国"] = [5, 5, 6, 5, 5, 5, 6, 6, 5],
        ["巴西"] = [4, 6, 4, 3, 4, 4, 4, 4, 2],
        ["英国"] = [5, 5, 6, 5, 5, 5, 6, 6, 5],
        // 美国人均 GDP 高、中位收入低，收入故意给 5 而不是按 GDP 推出来的 6。
        ["美国"] = [6, 6, 7, 4, 4, 4, 5, 5, 5],
    };

    private static readonly int[] DefaultLevels = [5, 5, 5, 5, 5, 5, 5, 5, 4];

    private static readonly Dictionary<string, int> BaseGdp = new()
    {
        ["中国"] = 12600, ["日本"] = 33000, ["韩国"] = 33000, ["德国"] = 52000,
        ["法国"] = 44000, ["巴西"] = 9000, ["英国"] = 46000, ["美国"] = 76000,
    };

    public static Indicator Get(string id) => All.First(i => i.Id == id);

    public static IReadOnlyList<Indicator> InGroup(string group) => All.Where(i => i.Group == group).ToList();

    public static int Cost(int level) => Costs[Math.Clamp(level, 0, 8)];

    public static string Description(string id, int level) => Get(id).Levels[Math.Clamp(level, 0, 9)];
    public static double Enhancement(NationalLegacy n, string id, int day)
    {
        double progress = n.ExtraProgress.GetValueOrDefault(id) * Math.Pow(.5, Math.Max(0, day - n.ExtraProgressDay) / 14.0);
        return progress >= 600.0 / 99 ? progress / (600 + progress) : 0;
    }
    public static double IncomeBonus(CareerData d, string country) => d.Esports.Nations.FirstOrDefault(n => n.Country == country) is { } n
        ? .2 * All.Average(i => Enhancement(n, i.Id, d.Day)) : 0;
    private static void DecayExtra(NationalLegacy n, int day)
    {
        double decay = Math.Pow(.5, Math.Max(0, day - n.ExtraProgressDay) / 14.0);
        foreach (string id in n.ExtraProgress.Keys.ToArray())
        {
            double value = n.ExtraProgress[id] * decay;
            n.ExtraProgress[id] = value >= 600.0 / 99 ? value : 0;
        }
        n.ExtraProgressDay = day;
    }
    public static string ProgressText(NationalLegacy n, string id)
    {
        double value = n.Progress.GetValueOrDefault(id);
        return value < 0 ? $"降级进度{-value:0.#%}" : Level(n, id) == 9 ? "已满级" : $"升级进度{value:0.#%}";
    }
    public static Dictionary<string, int[]> Snapshot(CareerData d, IEnumerable<string> countries) => countries.Distinct(StringComparer.Ordinal)
        .Select(country => d.Esports.Nations.FirstOrDefault(n => n.Country == country)).OfType<NationalLegacy>()
        .ToDictionary(n => n.Country, n => All.Select(i => Level(n, i.Id)).ToArray());
    public static string Describe(IReadOnlyDictionary<string, int[]> snapshot) => string.Join("\n\n", snapshot.Select(pair => pair.Key + "生活与发展情况\n"
        + string.Join("\n", All.Select((i, index) => $"{i.Name} {pair.Value[index]}级：{Description(i.Id, pair.Value[index])}"))));
    public static string Context(CareerData d, IEnumerable<string> countries) => string.Join("\n\n", countries.Distinct(StringComparer.Ordinal)
        .Select(country => d.Esports.Nations.FirstOrDefault(n => n.Country == country)).OfType<NationalLegacy>().Select(n =>
            n.Country + "当前生活与发展情况\n" + string.Join("\n", All.Select(i => $"{i.Name} {Level(n, i.Id)}级：{Description(i.Id, Level(n, i.Id))}"))
            + "\n本日已完成的等级变化：" + (n.NewsDay == d.Day && n.NewsChanges.Count > 0 ? string.Join("", n.NewsChanges) : "各项等级维持上述现状。")
            + "\n" + string.Join("\n", All.Select(i => i.Name + "：" + ProgressText(n, i.Id)
                + (Enhancement(n, i.Id, d.Day) is var extra && extra > 0 ? $"，临时增强+{extra:0.#%}" : "")))));


    /// <summary>旧档迁移：缺字段的国家按国别基值补齐，只做一次。</summary>
    public static void Ensure(CareerData d)
    {
        foreach (var n in d.Esports.Nations)
        {
            var levels = BaseLevels.GetValueOrDefault(n.Country) ?? DefaultLevels;
            for (int i = 0; i < All.Length; i++)
                if (!n.Indicators.ContainsKey(All[i].Id)) n.Indicators[All[i].Id] = levels[i];
            if (n.Gdp <= 0) n.Gdp = BaseGdp.GetValueOrDefault(n.Country, 20000);
            if (n.DevelopmentVersion < Version)
            {
                DecayExtra(n, d.Day);
                // 旧类别余额原额均分至类内三项，换算为当前等级的升级进度。
                foreach (var i in All)
                {
                    double balance = n.Pending.GetValueOrDefault(i.Group) / 3;
                    if (Level(n, i.Id) == 9) n.ExtraProgress[i.Id] = n.ExtraProgress.GetValueOrDefault(i.Id) + balance;
                    else n.Progress[i.Id] = n.Progress.GetValueOrDefault(i.Id) + balance / Cost(Level(n, i.Id));
                }
                n.Pending.Clear();
                n.MaintenanceFunding = 0;
                n.DevelopmentVersion = Version;
                n.ReportSeason = Math.Max(n.ReportSeason, d.Season);
            }
        }
    }

    public static int Level(NationalLegacy n, string id)
    {
        if (n.Indicators.TryGetValue(id, out var value)) return Math.Clamp(value, 0, 9);
        var levels = BaseLevels.GetValueOrDefault(n.Country) ?? DefaultLevels;
        int index = Array.FindIndex(All, i => i.Id == id);
        return index < 0 ? 5 : levels[index];
    }

    /// <summary>某国某个赛季的国运总额。</summary>
    public static int SeasonFortune(CareerData d, string country, int season)
        => d.Esports.CircuitAwards.Where(a => a.Country == country && a.Season == season).Sum(a => a.Fortune);


    public static void SeasonStart(CareerData d)
    {
        Ensure(d);
        foreach (var n in d.Esports.Nations)
        {
            if (n.ReportSeason >= d.Season) continue;
            GrowGdp(n, SeasonFortune(d, n.Country, d.Season - 1));
            DecayExtra(n, d.Day);
            n.ReportSeason = d.Season;
        }
    }

    public static List<string> Contribute(CareerData d, NationalLegacy n, int amount, string source = "")
    {
        using var timing = UiPerformance.Measure(UiPerformance.Work.NationalContribution);
        Ensure(d);
        var before = All.ToDictionary(i => i.Id, i => Level(n, i.Id));
        var enhancements = Upgrade(d, n, amount * 7.0, source);
        var changes = RecordChanges(n, before);
        changes.AddRange(enhancements);
        if (changes.Count > 0) n.LastReport = string.Join("", changes);
        RememberChanges(d, n, changes);
        n.NewsFortune += amount;
        n.NewsPending = amount != 0 || n.NewsPending == true;
        return changes;
    }

    private static void RememberChanges(CareerData d, NationalLegacy n, IEnumerable<string> changes)
    {
        if (n.NewsDay != d.Day) { n.NewsFortune = 0; n.NewsChanges.Clear(); }
        n.NewsDay = d.Day;
        foreach (string change in changes) if (!n.NewsChanges.Contains(change)) n.NewsChanges.Add(change);
    }

    private static List<string> RecordChanges(NationalLegacy n, Dictionary<string, int> before)
    {
        var changes = All.Where(i => before[i.Id] != Level(n, i.Id))
            .Select(i => $"{n.Country}{i.Name} {before[i.Id]}→{Level(n, i.Id)}。原有情况：{Description(i.Id, before[i.Id])}当前情况：{Description(i.Id, Level(n, i.Id))}").ToList();
        if (changes.Count > 0) n.LastReport = string.Join("", changes);
        return changes;
    }

    public static NationalLegacy[] NewsCandidates(CareerData d) => d.Esports.Nations
        .Where(n => (n.NewsPending ?? n.NewsFortune != 0) && d.Day - n.NewsDay <= 7).ToArray();

    public static bool TryPublish(CareerData d, Random random)
    {
        var candidates = NewsCandidates(d);
        if (candidates.Length == 0) return false;
        var n = candidates[random.Next(candidates.Length)];
        string key = $"development-{n.Country}-{n.NewsDay}";
        var people = d.People.Where(p => p.Country == n.Country && EsportsWorld.IsProfessional(p) && !SpireArbitration.Banned(p, d.Day))
            .OrderBy(p => CareerEngine.StableHash(key + p.Id)).Take(3).Select(p => p.Id).ToList();
        var competitions = d.Esports.Competitions.Where(c => c.Fixtures.Any(f => f.Day == n.NewsDay && f.Finished && f.Fortune.Any(a => c.EntrantCountries.GetValueOrDefault(a.Key) == n.Country))).ToArray();
        string matches = string.Join("\n", competitions.Select(c => WorldEvents.FixtureFacts(d, c, c.Fixtures.Where(f => f.Day == n.NewsDay && f.Fortune.Any(a => c.EntrantCountries.GetValueOrDefault(a.Key) == n.Country)))));
        CareerEngine.Publish(d, key, n.Country + "国运发展公报",
            $"{GameCalendar.Text(d, n.NewsDay)}，{n.Country}在国际赛事中国运净变化{n.NewsFortune:+0;-0;0}。" + string.Join("", n.NewsChanges)
            + $"当前人均GDP {n.Gdp:N0}美元/年。\n" + matches
            + "\n" + Context(d, [n.Country])
            + "\n请结合本次比赛与当地生活情况组织报道和人物讨论。各项指标的现状、上升、下降及建设进度以本次资料为准。人物从自己的身份、经历和处境出发，谈论这些变化带来的影响。", "国家发展", true, people);
        n.NewsFortune = 0; n.NewsPending = false;
        return true;
    }

    private const double BaseGrowth = 0.006;      // 基础 0.6%/季
    private const double LevelGrowth = 0.020;     // 等级结构项 ±2%/季（结构项范围约 ±1）
    private const double FortuneGrowth = 0.014;   // 本赛季国运线性加到最多 +1.4%
    private const int FortuneCap = 2000;          // 达到这个点数就吃满国运项
    private const double GrowthFloor = -0.02, GrowthCeiling = 0.04;

    /// <summary>一次结算的增速构成。数值都是"折算后"的（已乘收敛系数），界面与公报直接展示这三项。</summary>
    public sealed record GrowthBreakdown(double Base, double Level, double Fortune, double Convergence, double Total);

    /// <summary>用当前（= 上赛季末的）九项等级与本季国运算增速。GrowGdp、界面、公报、校验工具共用这一处公式，
    /// 避免"文档一个公式、代码另一个公式"。</summary>
    public static GrowthBreakdown Breakdown(NationalLegacy n, int fortune)
    {
        double structural = 0;
        foreach (var indicator in All)
            structural += GrowthWeight[indicator.Id] * (Level(n, indicator.Id) - 5) / 5.0;
        double convergence = 1 - 0.35 * Math.Log2(Math.Max(1000, n.Gdp) / 40000.0);
        double strength = Math.Clamp(fortune, -FortuneCap, FortuneCap) / (double)FortuneCap;
        double basis = BaseGrowth + structural * LevelGrowth + FortuneGrowth * strength;
        return new GrowthBreakdown(BaseGrowth * convergence, structural * LevelGrowth * convergence, FortuneGrowth * strength * convergence,
            convergence, Math.Clamp(basis * convergence, GrowthFloor, GrowthCeiling));
    }

    private static void GrowGdp(NationalLegacy n, int fortune)
    {
        var breakdown = Breakdown(n, fortune);
        n.GdpGrowth = breakdown.Total;
        // 存下来的是"当时"的输入与拆解：结算完等级就被买高了，事后再算只会得到一个和 GdpGrowth 对不上的数。
        n.GrowthFortune = fortune;
        n.GrowthBase = breakdown.Base;
        n.GrowthLevel = breakdown.Level;
        n.GrowthFortunePart = breakdown.Fortune;
        n.GrowthConvergence = breakdown.Convergence;
        n.Gdp = (int)Math.Round(n.Gdp * (1 + n.GdpGrowth));
    }

    /// <summary>每年几个赛季（84 天或 28 天一季）。Gdp 是年化人均 GDP，用它才能折成一季的产出。</summary>
    public static double SeasonsPerYear(CareerData d) => 365.0 / SeasonCalendar.Length(d);

    /// <summary>一季的人均产出 ≈ 年化人均 GDP ÷ 每年赛季数。界面与公报拿它回答"一季怎么这么高"。</summary>
    public static int QuarterlyGdp(CareerData d, NationalLegacy n) => (int)Math.Round(n.Gdp / SeasonsPerYear(d));

    /// <summary>每次沿用原三类随机权重，类内均分；等级变化后按新成本继续折算剩余建设量。</summary>
    private static List<string> Upgrade(CareerData d, NationalLegacy n, double budget, string source)
    {
        DecayExtra(n, d.Day);
        var random = new Random(CareerEngine.StableHash($"{d.WorldId}:{n.Country}:{d.Day}:{source}:construction"));
        int primary = random.Next(Groups.Length);
        double main = .7 + random.NextDouble() * .2, secondary = (1 - main) * random.NextDouble();
        double[] weights = new double[Groups.Length];
        weights[primary] = main; weights[(primary + 1) % 3] = secondary; weights[(primary + 2) % 3] = 1 - main - secondary;
        double overflow = 0;
        var full = new List<Indicator>();
        for (int group = 0; group < Groups.Length; group++)
        foreach (var indicator in All.Where(i => i.Group == Groups[group]))
        {
            string id = indicator.Id;
            double delta = budget * weights[group] / 3;
            if (delta < 0)
            {
                double used = Math.Min(n.ExtraProgress.GetValueOrDefault(id), -delta);
                double remaining = n.ExtraProgress.GetValueOrDefault(id) - used;
                n.ExtraProgress[id] = remaining >= 600.0 / 99 ? remaining : 0;
                delta += used;
            }
            int sign = delta > 0 ? 1 : -1;
            double amount = Math.Abs(delta), progress = n.Progress.GetValueOrDefault(id);
            while (amount > 1e-8)
            {
                int level = Level(n, id);
                double cost = sign > 0 ? Cost(level) : .8 * Cost(9 - level);
                if (level == 9 && sign > 0)
                {
                    double used = Math.Min(amount, Math.Max(0, -progress) * cost);
                    progress += used / cost;
                    if (amount - used > 1e-8) { overflow += amount - used; full.Add(indicator); }
                    break;
                }
                if (level == 0 && sign < 0) { progress = Math.Max(0, progress - amount / cost); break; }
                double needed = (1 - sign * progress) * cost;
                if (amount < needed - 1e-8) { progress += sign * amount / cost; break; }
                amount -= needed; progress = 0; n.Indicators[id] = level + sign;
            }
            n.Progress[id] = progress;
        }
        var changes = new List<string>();
        if (overflow > 0)
        {
            var indicator = full[CareerEngine.StableHash($"{d.WorldId}:{n.Country}:{source}:0") % full.Count];
            double before = Enhancement(n, indicator.Id, d.Day);
            double value = n.ExtraProgress.GetValueOrDefault(indicator.Id) + overflow;
            n.ExtraProgress[indicator.Id] = value >= 600.0 / 99 ? value : 0;
            double after = Enhancement(n, indicator.Id, d.Day);
            if (after > 0) changes.Add($"{n.Country}{indicator.Name}临时增强 {before:0.#%}→{after:0.#%}。新增满级建设投入已计入，增强随日期逐渐衰减。");
        }
        return changes;
    }
}
