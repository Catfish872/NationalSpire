# NationalDevelopment.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`8CA2167840392D4725A93C1F29FAD8EFD23914DCC9B5CAB16408C97E7D6C977B`。来源：[源码](../../NationalDevelopment.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.NationalDevelopment`、`NationalSpire.NationalDevelopment.Indicator`、`NationalSpire.NationalDevelopment.GrowthBreakdown`。

字段、事件及初始值（源码原样）：

```csharp
public const int Version = 1;
private const int MaintenancePerGroup = 40;
private static readonly int[] Costs = [100, 120, 150, 190, 240, 300, 380, 480, 600];
private static readonly string[] Groups = ["经济", "社会", "民生"];
private static readonly Dictionary<string, double> GroupWeight = new()
    {
        ["经济"] = 0.40, ["社会"] = 0.25, ["民生"] = 0.35,
    };
private static readonly Dictionary<string, double> GrowthWeight = new()
    {
        ["industry"] = 0.16, ["agriculture"] = 0.08, ["services"] = 0.16,
        ["security"] = 0.10, ["unity"] = 0.08, ["sentiment"] = 0.08,
        ["publicService"] = 0.12, ["infrastructure"] = 0.10, ["income"] = 0.12,
    };
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
private const double BaseGrowth = 0.006;
private const double LevelGrowth = 0.020;
private const double FortuneGrowth = 0.014;
private const int FortuneCap = 2000;
private const double GrowthFloor = -0.02, GrowthCeiling = 0.04;
```

<a id="symbol-995037c9b117"></a>

## `NationalSpire.NationalDevelopment.Get(string) — public static Indicator Get(string id)`

来源：源码第 174 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.NationalDevelopment.Description(string, int)`](NationalDevelopment.cs.md#symbol-eb5d5925eb64)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.NationalDevelopment.All`；`NationalSpire.NationalDevelopment.Indicator.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`All.First(i => i.Id == id)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => All.First(i => i.Id == id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1688e440426e"></a>

## `NationalSpire.NationalDevelopment.InGroup(string) — public static IReadOnlyList<Indicator> InGroup(string group)`

来源：源码第 176 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.NationalDevelopment.PayMaintenance(NationalSpire.CareerData, NationalSpire.NationalLegacy, ref int)`](NationalDevelopment.cs.md#symbol-2430ad41a5d9)；[`NationalSpire.NationalDevelopment.Pick(NationalSpire.CareerData, NationalSpire.NationalLegacy, string, string, bool)`](NationalDevelopment.cs.md#symbol-ba4f9575e17b)；[`NationalSpire.NationalDevelopment.Upgrade(NationalSpire.CareerData, NationalSpire.NationalLegacy, int)`](NationalDevelopment.cs.md#symbol-30892377c440)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.NationalDevelopment.All`；`NationalSpire.NationalDevelopment.Indicator.Group`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`All.Where(i => i.Group == group).ToList()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => All.Where(i => i.Group == group).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`All.Where(i => i.Group == group)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: All.Where(i => i.Group == group).ToList`

**赋值（含属性/字段和局部值）：**


<a id="symbol-519bf129507f"></a>

## `NationalSpire.NationalDevelopment.Cost(int) — public static int Cost(int level)`

来源：源码第 178 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.NationalDevelopment.Upgrade(NationalSpire.CareerData, NationalSpire.NationalLegacy, int)`](NationalDevelopment.cs.md#symbol-30892377c440)

**调用：** `System.Math.Clamp(int, int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.NationalDevelopment.Costs`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(level, 0, 8)`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(level, 0, 8)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-eb5d5925eb64"></a>

## `NationalSpire.NationalDevelopment.Description(string, int) — public static string Description(string id, int level)`

来源：源码第 180 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DevelopmentScreen(NationalSpire.CareerData)`](DevelopmentScreen.cs.md#symbol-2d48676d5e88)

**调用：** [`NationalSpire.NationalDevelopment.Get(string)`](NationalDevelopment.cs.md#symbol-995037c9b117)；`System.Math.Clamp(int, int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.NationalDevelopment.Get(string)`；`NationalSpire.NationalDevelopment.Indicator.Levels`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.NationalDevelopment.Get(string)`；输入表达式：`Get(id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Get(id).Levels`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(level, 0, 9)`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(level, 0, 9)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7b51466d6927"></a>

## `NationalSpire.NationalDevelopment.Ensure(NationalSpire.CareerData) — public static void Ensure(CareerData d)`

来源：源码第 183 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.NormalizeRoster(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-eb11b96e7400)；[`NationalSpire.Coop.CoopCoordinator.CoopCoordinator(NationalSpire.Coop.ICoopTransport, NationalSpire.Coop.CoopStorage, string, string, string, System.Collections.Generic.IReadOnlySet<string>, NationalSpire.Coop.CoopStorage.Checkpoint?)`](Coop/CoopCoordinator.cs.md#symbol-778097f34ec3)；[`NationalSpire.NationalDevelopment.Contribute(NationalSpire.CareerData, NationalSpire.NationalLegacy, int)`](NationalDevelopment.cs.md#symbol-abd0a463c72f)；[`NationalSpire.NationalDevelopment.SeasonStart(NationalSpire.CareerData)`](NationalDevelopment.cs.md#symbol-e74fea2f7dca)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryAdd(TKey, TValue)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Season`；`NationalSpire.EsportsCareer.Nations`；`NationalSpire.NationalDevelopment.All`；`NationalSpire.NationalDevelopment.BaseGdp`；`NationalSpire.NationalDevelopment.BaseLevels`；`NationalSpire.NationalDevelopment.DefaultLevels`；`NationalSpire.NationalDevelopment.Groups`；`NationalSpire.NationalDevelopment.Indicator.Id`；`NationalSpire.NationalDevelopment.MaintenancePerGroup`；`NationalSpire.NationalDevelopment.Version`；`NationalSpire.NationalLegacy.Country`；`NationalSpire.NationalLegacy.DevelopmentVersion`；`NationalSpire.NationalLegacy.Gdp`；`NationalSpire.NationalLegacy.Indicators`；`NationalSpire.NationalLegacy.MaintenanceFunding`；`NationalSpire.NationalLegacy.Pending`；`NationalSpire.NationalLegacy.ReportSeason`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`n.Indicators.ContainsKey(All[i].Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !n.Indicators.ContainsKey(All[i].Id)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryAdd(TKey, TValue)`；输入表达式：`n.Pending.TryAdd(group, 0)`；返回值紧邻使用处：`ExpressionStatementSyntax: n.Pending.TryAdd(group, 0);`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`BaseGdp.GetValueOrDefault(n.Country, 20000)`；返回值紧邻使用处：`AssignmentExpressionSyntax: n.Gdp = BaseGdp.GetValueOrDefault(n.Country, 20000)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`BaseLevels.GetValueOrDefault(n.Country)`；返回值紧邻使用处：`BinaryExpressionSyntax: BaseLevels.GetValueOrDefault(n.Country) ?? DefaultLevels`

**赋值（含属性/字段和局部值）：**

- `n.DevelopmentVersion` = `Version`
- `n.Gdp` = `BaseGdp.GetValueOrDefault(n.Country, 20000)`
- `n.Indicators[All[i].Id]` = `levels[i]`
- `n.MaintenanceFunding` = `3 * MaintenancePerGroup`
- `n.ReportSeason` = `d.Season`

<a id="symbol-b758e69d4a1d"></a>

## `NationalSpire.NationalDevelopment.Level(NationalSpire.NationalLegacy, string) — public static int Level(NationalLegacy n, string id)`

来源：源码第 201 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DevelopmentScreen(NationalSpire.CareerData)`](DevelopmentScreen.cs.md#symbol-2d48676d5e88)；[`NationalSpire.MarketDynamics.Anchors(NationalSpire.CareerData)`](MarketDynamics.cs.md#symbol-9a7ffea26eec)；[`NationalSpire.NationalDevelopment.Breakdown(NationalSpire.NationalLegacy, int)`](NationalDevelopment.cs.md#symbol-eccbfc720363)；[`NationalSpire.NationalDevelopment.Contribute(NationalSpire.CareerData, NationalSpire.NationalLegacy, int)`](NationalDevelopment.cs.md#symbol-abd0a463c72f)；[`NationalSpire.NationalDevelopment.PayMaintenance(NationalSpire.CareerData, NationalSpire.NationalLegacy, ref int)`](NationalDevelopment.cs.md#symbol-2430ad41a5d9)；[`NationalSpire.NationalDevelopment.Pick(NationalSpire.CareerData, NationalSpire.NationalLegacy, string, string, bool)`](NationalDevelopment.cs.md#symbol-ba4f9575e17b)；[`NationalSpire.NationalDevelopment.RecordChanges(NationalSpire.NationalLegacy, System.Collections.Generic.Dictionary<string, int>)`](NationalDevelopment.cs.md#symbol-538b1f362d23)；[`NationalSpire.NationalDevelopment.SeasonStart(NationalSpire.CareerData)`](NationalDevelopment.cs.md#symbol-e74fea2f7dca)；[`NationalSpire.NationalDevelopment.Upgrade(NationalSpire.CareerData, NationalSpire.NationalLegacy, int)`](NationalDevelopment.cs.md#symbol-30892377c440)

**调用：** `System.Array.FindIndex<T>(T[], System.Predicate<T>)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Math.Clamp(int, int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.NationalDevelopment.All`；`NationalSpire.NationalDevelopment.BaseLevels`；`NationalSpire.NationalDevelopment.DefaultLevels`；`NationalSpire.NationalDevelopment.Indicator.Id`；`NationalSpire.NationalLegacy.Country`；`NationalSpire.NationalLegacy.Indicators`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Array.FindIndex<T>(T[], System.Predicate<T>)`；输入表达式：`Array.FindIndex(All, i => i.Id == id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Array.FindIndex(All, i => i.Id == id)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`n.Indicators.TryGetValue(id, out var value)`；返回值紧邻使用处：`IfStatementSyntax: if (n.Indicators.TryGetValue(id, out var value)) return Math.Clamp(value, 0, 9);`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`BaseLevels.GetValueOrDefault(n.Country)`；返回值紧邻使用处：`BinaryExpressionSyntax: BaseLevels.GetValueOrDefault(n.Country) ?? DefaultLevels`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(value, 0, 9)`；返回值紧邻使用处：`ReturnStatementSyntax: return Math.Clamp(value, 0, 9);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a5f9343d73de"></a>

## `NationalSpire.NationalDevelopment.SeasonFortune(NationalSpire.CareerData, string, int) — public static int SeasonFortune(CareerData d, string country, int season)`

来源：源码第 210 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DevelopmentScreen(NationalSpire.CareerData)`](DevelopmentScreen.cs.md#symbol-2d48676d5e88)；[`NationalSpire.NationalDevelopment.SeasonStart(NationalSpire.CareerData)`](NationalDevelopment.cs.md#symbol-e74fea2f7dca)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CircuitAward.Country`；`NationalSpire.CircuitAward.Fortune`；`NationalSpire.CircuitAward.Season`；`NationalSpire.EsportsCareer.CircuitAwards`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`d.Esports.CircuitAwards.Where(a => a.Country == country && a.Season == season).Sum(a => a.Fortune)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => d.Esports.CircuitAwards.Where(a => a.Country == country && a.Season == season).Sum(a => a.Fortune)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.CircuitAwards.Where(a => a.Country == country && a.Season == season)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.CircuitAwards.Where(a => a.Country == country && a.Season == season).Sum`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e74fea2f7dca"></a>

## `NationalSpire.NationalDevelopment.SeasonStart(NationalSpire.CareerData) — public static void SeasonStart(CareerData d)`

来源：源码第 214 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitLedger.SeasonStart(NationalSpire.CareerData)`](CircuitLedger.cs.md#symbol-b971fd6392cb)

**调用：** [`NationalSpire.NationalDevelopment.Ensure(NationalSpire.CareerData)`](NationalDevelopment.cs.md#symbol-7b51466d6927)；[`NationalSpire.NationalDevelopment.GrowGdp(NationalSpire.NationalLegacy, int)`](NationalDevelopment.cs.md#symbol-b5d4218e2bb4)；[`NationalSpire.NationalDevelopment.Level(NationalSpire.NationalLegacy, string)`](NationalDevelopment.cs.md#symbol-b758e69d4a1d)；[`NationalSpire.NationalDevelopment.PayMaintenance(NationalSpire.CareerData, NationalSpire.NationalLegacy, ref int)`](NationalDevelopment.cs.md#symbol-2430ad41a5d9)；[`NationalSpire.NationalDevelopment.RecordChanges(NationalSpire.NationalLegacy, System.Collections.Generic.Dictionary<string, int>)`](NationalDevelopment.cs.md#symbol-538b1f362d23)；[`NationalSpire.NationalDevelopment.SeasonFortune(NationalSpire.CareerData, string, int)`](NationalDevelopment.cs.md#symbol-a5f9343d73de)；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Season`；`NationalSpire.EsportsCareer.Nations`；`NationalSpire.NationalDevelopment.All`；`NationalSpire.NationalDevelopment.Ensure(NationalSpire.CareerData)`；`NationalSpire.NationalDevelopment.GrowGdp(NationalSpire.NationalLegacy, int)`；`NationalSpire.NationalDevelopment.Indicator.Id`；`NationalSpire.NationalDevelopment.Level(NationalSpire.NationalLegacy, string)`；`NationalSpire.NationalDevelopment.PayMaintenance(NationalSpire.CareerData, NationalSpire.NationalLegacy, ref int)`；`NationalSpire.NationalDevelopment.RecordChanges(NationalSpire.NationalLegacy, System.Collections.Generic.Dictionary<string, int>)`；`NationalSpire.NationalDevelopment.SeasonFortune(NationalSpire.CareerData, string, int)`；`NationalSpire.NationalLegacy.Country`；`NationalSpire.NationalLegacy.MaintenanceFunding`；`NationalSpire.NationalLegacy.ReportSeason`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.NationalDevelopment.Ensure(NationalSpire.CareerData)`；输入表达式：`Ensure(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: Ensure(d);`
- `NationalSpire.NationalDevelopment.GrowGdp(NationalSpire.NationalLegacy, int)`；输入表达式：`GrowGdp(n, SeasonFortune(d, n.Country, d.Season - 1))`；返回值紧邻使用处：`ExpressionStatementSyntax: GrowGdp(n, SeasonFortune(d, n.Country, d.Season - 1));`
- `NationalSpire.NationalDevelopment.Level(NationalSpire.NationalLegacy, string)`；输入表达式：`Level(n, i.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: i => Level(n, i.Id)`
- `NationalSpire.NationalDevelopment.PayMaintenance(NationalSpire.CareerData, NationalSpire.NationalLegacy, ref int)`；输入表达式：`PayMaintenance(d, n, ref maintenance)`；返回值紧邻使用处：`ExpressionStatementSyntax: PayMaintenance(d, n, ref maintenance);`
- `NationalSpire.NationalDevelopment.RecordChanges(NationalSpire.NationalLegacy, System.Collections.Generic.Dictionary<string, int>)`；输入表达式：`RecordChanges(n, before)`；返回值紧邻使用处：`ExpressionStatementSyntax: RecordChanges(n, before);`
- `NationalSpire.NationalDevelopment.SeasonFortune(NationalSpire.CareerData, string, int)`；输入表达式：`SeasonFortune(d, n.Country, d.Season - 1)`；返回值紧邻使用处：`ArgumentSyntax: SeasonFortune(d, n.Country, d.Season - 1)`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`All.ToDictionary(i => i.Id, i => Level(n, i.Id))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = All.ToDictionary(i => i.Id, i => Level(n, i.Id))`

**赋值（含属性/字段和局部值）：**

- `n.MaintenanceFunding` = `0`
- `n.ReportSeason` = `d.Season`

<a id="symbol-abd0a463c72f"></a>

## `NationalSpire.NationalDevelopment.Contribute(NationalSpire.CareerData, NationalSpire.NationalLegacy, int) — public static List<string> Contribute(CareerData d, NationalLegacy n, int amount)`

来源：源码第 230 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitLedger.Settle(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool)`](CircuitLedger.cs.md#symbol-8ff7b69864e0)；[`NationalSpire.NationalFortune.Add(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, string, int)`](NationalFortune.cs.md#symbol-b9fd32a76496)

**调用：** [`NationalSpire.NationalDevelopment.Ensure(NationalSpire.CareerData)`](NationalDevelopment.cs.md#symbol-7b51466d6927)；[`NationalSpire.NationalDevelopment.Level(NationalSpire.NationalLegacy, string)`](NationalDevelopment.cs.md#symbol-b758e69d4a1d)；[`NationalSpire.NationalDevelopment.RecordChanges(NationalSpire.NationalLegacy, System.Collections.Generic.Dictionary<string, int>)`](NationalDevelopment.cs.md#symbol-538b1f362d23)；[`NationalSpire.NationalDevelopment.Upgrade(NationalSpire.CareerData, NationalSpire.NationalLegacy, int)`](NationalDevelopment.cs.md#symbol-30892377c440)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Clear()`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.NationalDevelopment.All`；`NationalSpire.NationalDevelopment.Ensure(NationalSpire.CareerData)`；`NationalSpire.NationalDevelopment.Indicator.Id`；`NationalSpire.NationalDevelopment.Level(NationalSpire.NationalLegacy, string)`；`NationalSpire.NationalDevelopment.MaintenancePerGroup`；`NationalSpire.NationalDevelopment.RecordChanges(NationalSpire.NationalLegacy, System.Collections.Generic.Dictionary<string, int>)`；`NationalSpire.NationalDevelopment.Upgrade(NationalSpire.CareerData, NationalSpire.NationalLegacy, int)`；`NationalSpire.NationalLegacy.MaintenanceFunding`；`NationalSpire.NationalLegacy.NewsChanges`；`NationalSpire.NationalLegacy.NewsDay`；`NationalSpire.NationalLegacy.NewsFortune`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.NationalContribution`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.NationalDevelopment.Ensure(NationalSpire.CareerData)`；输入表达式：`Ensure(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: Ensure(d);`
- `NationalSpire.NationalDevelopment.Level(NationalSpire.NationalLegacy, string)`；输入表达式：`Level(n, i.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: i => Level(n, i.Id)`
- `NationalSpire.NationalDevelopment.RecordChanges(NationalSpire.NationalLegacy, System.Collections.Generic.Dictionary<string, int>)`；输入表达式：`RecordChanges(n, before)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RecordChanges(n, before)`
- `NationalSpire.NationalDevelopment.Upgrade(NationalSpire.CareerData, NationalSpire.NationalLegacy, int)`；输入表达式：`Upgrade(d, n, amount - maintenance)`；返回值紧邻使用处：`ExpressionStatementSyntax: Upgrade(d, n, amount - maintenance);`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.NationalContribution)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.NationalContribution)`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`All.ToDictionary(i => i.Id, i => Level(n, i.Id))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = All.ToDictionary(i => i.Id, i => Level(n, i.Id))`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`n.NewsChanges.Add(change)`；返回值紧邻使用处：`ExpressionStatementSyntax: n.NewsChanges.Add(change);`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`n.NewsChanges.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: n.NewsChanges.Clear();`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`n.NewsChanges.Contains(change)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !n.NewsChanges.Contains(change)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(3 * MaintenancePerGroup - n.MaintenanceFunding, amount)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(3 * MaintenancePerGroup - n.MaintenanceFunding, amount)`

**赋值（含属性/字段和局部值）：**

- `n.MaintenanceFunding` += `maintenance`
- `n.NewsDay` = `d.Day`
- `n.NewsFortune` += `amount`
- `n.NewsFortune` = `0`

<a id="symbol-538b1f362d23"></a>

## `NationalSpire.NationalDevelopment.RecordChanges(NationalSpire.NationalLegacy, System.Collections.Generic.Dictionary<string, int>) — private static List<string> RecordChanges(NationalLegacy n, Dictionary<string, int> before)`

来源：源码第 245 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.NationalDevelopment.Contribute(NationalSpire.CareerData, NationalSpire.NationalLegacy, int)`](NationalDevelopment.cs.md#symbol-abd0a463c72f)；[`NationalSpire.NationalDevelopment.SeasonStart(NationalSpire.CareerData)`](NationalDevelopment.cs.md#symbol-e74fea2f7dca)

**调用：** [`NationalSpire.NationalDevelopment.Level(NationalSpire.NationalLegacy, string)`](NationalDevelopment.cs.md#symbol-b758e69d4a1d)；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.NationalDevelopment.All`；`NationalSpire.NationalDevelopment.Indicator.Id`；`NationalSpire.NationalDevelopment.Indicator.Name`；`NationalSpire.NationalDevelopment.Level(NationalSpire.NationalLegacy, string)`；`NationalSpire.NationalLegacy.Country`；`NationalSpire.NationalLegacy.LastReport`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.NationalDevelopment.Level(NationalSpire.NationalLegacy, string)`；输入表达式：`Level(n, i.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: before[i.Id] != Level(n, i.Id)`
- `NationalSpire.NationalDevelopment.Level(NationalSpire.NationalLegacy, string)`；输入表达式：`Level(n, i.Id)`；返回值紧邻使用处：`InterpolationSyntax: {Level(n, i.Id)}`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("", changes)`；返回值紧邻使用处：`AssignmentExpressionSyntax: n.LastReport = string.Join("", changes)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`All.Where(i => before[i.Id] != Level(n, i.Id))              .Select(i => $"{n.Country}{i.Name} {before[i.Id]}→{Level(n, i.Id)}。")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: All.Where(i => before[i.Id] != Level(n, i.Id))              .Select(i => $"{n.Country}{i.Name} {before[i.Id]}→{Level(n, i.Id)}。").ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`All.Where(i => before[i.Id] != Level(n, i.Id))              .Select(i => $"{n.Country}{i.Name} {before[i.Id]}→{Level(n, i.Id)}。").ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = All.Where(i => before[i.Id] != Level(n, i.Id))              .Select(i => $"{n.Country}{i.Name} {before[i.Id]}→{Level(n, i.Id)}。").ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`All.Where(i => before[i.Id] != Level(n, i.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: All.Where(i => before[i.Id] != Level(n, i.Id))              .Select`

**赋值（含属性/字段和局部值）：**

- `n.LastReport` = `string.Join("", changes)`

<a id="symbol-620f6dd04f3a"></a>

## `NationalSpire.NationalDevelopment.TryPublish(NationalSpire.CareerData, System.Random) — public static bool TryPublish(CareerData d, Random random)`

来源：源码第 253 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.WorldEvents.Advance(NationalSpire.CareerData)`](WorldEvents.cs.md#symbol-6471e41e5007)

**调用：** [`NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`](CareerEngine.cs.md#symbol-cd8fd2c800e7)；[`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`](EsportsWorld.cs.md#symbol-c10dfd5a2e0e)；[`NationalSpire.SpireArbitration.Banned(NationalSpire.CareerPerson, int)`](SpireArbitration.cs.md#symbol-05f06b3ee7b9)；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Clear()`；`System.Random.Next(int)`；`System.Random.NextDouble()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.People`；`NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.Id`；`NationalSpire.EsportsCareer.Nations`；`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；`NationalSpire.NationalLegacy.Country`；`NationalSpire.NationalLegacy.Gdp`；`NationalSpire.NationalLegacy.NewsChanges`；`NationalSpire.NationalLegacy.NewsDay`；`NationalSpire.NationalLegacy.NewsFortune`；`NationalSpire.SpireArbitration.Banned(NationalSpire.CareerPerson, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`；输入表达式：`CareerEngine.Publish(d, key, n.Country + "国运发展公报",              $"第{n.NewsDay}天，{n.Country}在国际赛事中新增{n.NewsFortune}国运。" + string.Join("", n.NewsChanges)              + $"当前人均GDP {n.Gdp:N0}美元/年。", "国家发展", true, people)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerEngine.Publish(d, key, n.Country + "国运发展公报",              $"第{n.NewsDay}天，{n.Country}在国际赛事中新增{n.NewsFortune}国运。" + string.Join("", n.NewsChanges)              + $"当前人均GDP {n.Gdp:N0}美元/年。", "国家发展", true, people);`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(key + p.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => CareerEngine.StableHash(key + p.Id)`
- `NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；输入表达式：`EsportsWorld.IsProfessional(p)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.Country == n.Country && EsportsWorld.IsProfessional(p)`
- `NationalSpire.SpireArbitration.Banned(NationalSpire.CareerPerson, int)`；输入表达式：`SpireArbitration.Banned(p, d.Day)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !SpireArbitration.Banned(p, d.Day)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("", n.NewsChanges)`；返回值紧邻使用处：`BinaryExpressionSyntax: $"第{n.NewsDay}天，{n.Country}在国际赛事中新增{n.NewsFortune}国运。" + string.Join("", n.NewsChanges)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.People.Where(p => p.Country == n.Country && EsportsWorld.IsProfessional(p) && !SpireArbitration.Banned(p, d.Day))              .OrderBy(p => CareerEngine.StableHash(key + p.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.Country == n.Country && EsportsWorld.IsProfessional(p) && !SpireArbitration.Banned(p, d.Day))              .OrderBy(p => CareerEngine.StableHash(key + p.Id)).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`d.People.Where(p => p.Country == n.Country && EsportsWorld.IsProfessional(p) && !SpireArbitration.Banned(p, d.Day))              .OrderBy(p => CareerEngine.StableHash(key + p.Id)).Take(3).Select(p => p.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.Country == n.Country && EsportsWorld.IsProfessional(p) && !SpireArbitration.Banned(p, d.Day))              .OrderBy(p => CareerEngine.StableHash(key + p.Id)).Take(3).Select(p => p.Id).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`d.People.Where(p => p.Country == n.Country && EsportsWorld.IsProfessional(p) && !SpireArbitration.Banned(p, d.Day))              .OrderBy(p => CareerEngine.StableHash(key + p.Id)).Take(3)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.Country == n.Country && EsportsWorld.IsProfessional(p) && !SpireArbitration.Banned(p, d.Day))              .OrderBy(p => CareerEngine.StableHash(key + p.Id)).Take(3).Select`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`d.Esports.Nations.Where(n => n.NewsFortune > 0 && d.Day - n.NewsDay <= 7).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Esports.Nations.Where(n => n.NewsFortune > 0 && d.Day - n.NewsDay <= 7).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.People.Where(p => p.Country == n.Country && EsportsWorld.IsProfessional(p) && !SpireArbitration.Banned(p, d.Day))              .OrderBy(p => CareerEngine.StableHash(key + p.Id)).Take(3).Select(p => p.Id).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.People.Where(p => p.Country == n.Country && EsportsWorld.IsProfessional(p) && !SpireArbitration.Banned(p, d.Day))              .OrderBy(p => CareerEngine.StableHash(key + p.Id)).Take(3).Select(p => p.Id).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Nations.Where(n => n.NewsFortune > 0 && d.Day - n.NewsDay <= 7)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.Nations.Where(n => n.NewsFortune > 0 && d.Day - n.NewsDay <= 7).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Where(p => p.Country == n.Country && EsportsWorld.IsProfessional(p) && !SpireArbitration.Banned(p, d.Day))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.Country == n.Country && EsportsWorld.IsProfessional(p) && !SpireArbitration.Banned(p, d.Day))              .OrderBy`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`n.NewsChanges.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: n.NewsChanges.Clear();`
- `System.Random.Next(int)`；输入表达式：`random.Next(candidates.Length)`；返回值紧邻使用处：`ArgumentSyntax: random.Next(candidates.Length)`
- `System.Random.NextDouble()`；输入表达式：`random.NextDouble()`；返回值紧邻使用处：`BinaryExpressionSyntax: random.NextDouble() >= .3`

**赋值（含属性/字段和局部值）：**

- `n.NewsFortune` = `0`

<a id="symbol-eccbfc720363"></a>

## `NationalSpire.NationalDevelopment.Breakdown(NationalSpire.NationalLegacy, int) — public static GrowthBreakdown Breakdown(NationalLegacy n, int fortune)`

来源：源码第 279 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.NationalDevelopment.GrowGdp(NationalSpire.NationalLegacy, int)`](NationalDevelopment.cs.md#symbol-b5d4218e2bb4)

**调用：** [`NationalSpire.NationalDevelopment.Level(NationalSpire.NationalLegacy, string)`](NationalDevelopment.cs.md#symbol-b758e69d4a1d)；`NationalSpire.NationalDevelopment.GrowthBreakdown.GrowthBreakdown(double, double, double, double, double)`；`System.Math.Clamp(double, double, double)`；`System.Math.Log2(double)`；`System.Math.Max(int, int)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.NationalDevelopment.All`；`NationalSpire.NationalDevelopment.BaseGrowth`；`NationalSpire.NationalDevelopment.FortuneCap`；`NationalSpire.NationalDevelopment.FortuneGrowth`；`NationalSpire.NationalDevelopment.GrowthCeiling`；`NationalSpire.NationalDevelopment.GrowthFloor`；`NationalSpire.NationalDevelopment.GrowthWeight`；`NationalSpire.NationalDevelopment.Indicator.Id`；`NationalSpire.NationalDevelopment.Level(NationalSpire.NationalLegacy, string)`；`NationalSpire.NationalDevelopment.LevelGrowth`；`NationalSpire.NationalLegacy.Gdp`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.NationalDevelopment.GrowthBreakdown.GrowthBreakdown(double, double, double, double, double)`；输入表达式：`new GrowthBreakdown(BaseGrowth * convergence, structural * LevelGrowth * convergence, FortuneGrowth * strength * convergence,              convergence, Math.Clamp(basis * convergence, GrowthFloor, GrowthCeiling))`；返回值紧邻使用处：`ReturnStatementSyntax: return new GrowthBreakdown(BaseGrowth * convergence, structural * LevelGrowth * convergence, FortuneGrowth * strength * convergence,              convergence, Math.Clamp(basis * convergence, GrowthFloor, GrowthCeiling));`
- `NationalSpire.NationalDevelopment.Level(NationalSpire.NationalLegacy, string)`；输入表达式：`Level(n, indicator.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: Level(n, indicator.Id) - 5`
- `System.Math.Clamp(double, double, double)`；输入表达式：`Math.Clamp(basis * convergence, GrowthFloor, GrowthCeiling)`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(basis * convergence, GrowthFloor, GrowthCeiling)`
- `System.Math.Log2(double)`；输入表达式：`Math.Log2(Math.Max(1000, n.Gdp) / 40000.0)`；返回值紧邻使用处：`BinaryExpressionSyntax: 0.35 * Math.Log2(Math.Max(1000, n.Gdp) / 40000.0)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1000, n.Gdp)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Max(1000, n.Gdp) / 40000.0`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(fortune, 0)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(fortune, 0)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(Math.Max(fortune, 0), FortuneCap)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Min(Math.Max(fortune, 0), FortuneCap) / (double)FortuneCap`

**赋值（含属性/字段和局部值）：**

- `structural` += `GrowthWeight[indicator.Id] * (Level(n, indicator.Id) - 5) / 5.0`

<a id="symbol-b5d4218e2bb4"></a>

## `NationalSpire.NationalDevelopment.GrowGdp(NationalSpire.NationalLegacy, int) — private static void GrowGdp(NationalLegacy n, int fortune)`

来源：源码第 291 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.NationalDevelopment.SeasonStart(NationalSpire.CareerData)`](NationalDevelopment.cs.md#symbol-e74fea2f7dca)

**调用：** [`NationalSpire.NationalDevelopment.Breakdown(NationalSpire.NationalLegacy, int)`](NationalDevelopment.cs.md#symbol-eccbfc720363)；`System.Math.Round(double)`

**字段、属性、事件及方法组引用：** `NationalSpire.NationalDevelopment.Breakdown(NationalSpire.NationalLegacy, int)`；`NationalSpire.NationalDevelopment.GrowthBreakdown.Base`；`NationalSpire.NationalDevelopment.GrowthBreakdown.Convergence`；`NationalSpire.NationalDevelopment.GrowthBreakdown.Fortune`；`NationalSpire.NationalDevelopment.GrowthBreakdown.Level`；`NationalSpire.NationalDevelopment.GrowthBreakdown.Total`；`NationalSpire.NationalLegacy.Gdp`；`NationalSpire.NationalLegacy.GdpGrowth`；`NationalSpire.NationalLegacy.GrowthBase`；`NationalSpire.NationalLegacy.GrowthConvergence`；`NationalSpire.NationalLegacy.GrowthFortune`；`NationalSpire.NationalLegacy.GrowthFortunePart`；`NationalSpire.NationalLegacy.GrowthLevel`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.NationalDevelopment.Breakdown(NationalSpire.NationalLegacy, int)`；输入表达式：`Breakdown(n, fortune)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Breakdown(n, fortune)`
- `System.Math.Round(double)`；输入表达式：`Math.Round(n.Gdp * (1 + n.GdpGrowth))`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Round(n.Gdp * (1 + n.GdpGrowth))`

**赋值（含属性/字段和局部值）：**

- `n.Gdp` = `(int)Math.Round(n.Gdp * (1 + n.GdpGrowth))`
- `n.GdpGrowth` = `breakdown.Total`
- `n.GrowthBase` = `breakdown.Base`
- `n.GrowthConvergence` = `breakdown.Convergence`
- `n.GrowthFortune` = `fortune`
- `n.GrowthFortunePart` = `breakdown.Fortune`
- `n.GrowthLevel` = `breakdown.Level`

<a id="symbol-9715a2dc78f5"></a>

## `NationalSpire.NationalDevelopment.SeasonsPerYear(NationalSpire.CareerData) — public static double SeasonsPerYear(CareerData d)`

来源：源码第 305 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.NationalDevelopment.QuarterlyGdp(NationalSpire.CareerData, NationalSpire.NationalLegacy)`](NationalDevelopment.cs.md#symbol-7ac5ee741f9b)

**调用：** [`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-12bdfe5d4265)

**字段、属性、事件及方法组引用：** `NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Length(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: 365.0 / SeasonCalendar.Length(d)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7ac5ee741f9b"></a>

## `NationalSpire.NationalDevelopment.QuarterlyGdp(NationalSpire.CareerData, NationalSpire.NationalLegacy) — public static int QuarterlyGdp(CareerData d, NationalLegacy n)`

来源：源码第 308 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.NationalDevelopment.SeasonsPerYear(NationalSpire.CareerData)`](NationalDevelopment.cs.md#symbol-9715a2dc78f5)；`System.Math.Round(double)`

**字段、属性、事件及方法组引用：** `NationalSpire.NationalDevelopment.SeasonsPerYear(NationalSpire.CareerData)`；`NationalSpire.NationalLegacy.Gdp`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.NationalDevelopment.SeasonsPerYear(NationalSpire.CareerData)`；输入表达式：`SeasonsPerYear(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: n.Gdp / SeasonsPerYear(d)`
- `System.Math.Round(double)`；输入表达式：`Math.Round(n.Gdp / SeasonsPerYear(d))`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Round(n.Gdp / SeasonsPerYear(d))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2430ad41a5d9"></a>

## `NationalSpire.NationalDevelopment.PayMaintenance(NationalSpire.CareerData, NationalSpire.NationalLegacy, ref int) — private static List<string> PayMaintenance(CareerData d, NationalLegacy n, ref int budget)`

来源：源码第 310 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.NationalDevelopment.SeasonStart(NationalSpire.CareerData)`](NationalDevelopment.cs.md#symbol-e74fea2f7dca)

**调用：** [`NationalSpire.NationalDevelopment.InGroup(string)`](NationalDevelopment.cs.md#symbol-1688e440426e)；[`NationalSpire.NationalDevelopment.Level(NationalSpire.NationalLegacy, string)`](NationalDevelopment.cs.md#symbol-b758e69d4a1d)；[`NationalSpire.NationalDevelopment.Pick(NationalSpire.CareerData, NationalSpire.NationalLegacy, string, string, bool)`](NationalDevelopment.cs.md#symbol-ba4f9575e17b)；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`

**字段、属性、事件及方法组引用：** `NationalSpire.NationalDevelopment.Groups`；`NationalSpire.NationalDevelopment.Indicator.Id`；`NationalSpire.NationalDevelopment.InGroup(string)`；`NationalSpire.NationalDevelopment.Level(NationalSpire.NationalLegacy, string)`；`NationalSpire.NationalDevelopment.MaintenancePerGroup`；`NationalSpire.NationalDevelopment.Pick(NationalSpire.CareerData, NationalSpire.NationalLegacy, string, string, bool)`；`NationalSpire.NationalLegacy.Indicators`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.NationalDevelopment.InGroup(string)`；输入表达式：`InGroup(g)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: InGroup(g).Sum`
- `NationalSpire.NationalDevelopment.Level(NationalSpire.NationalLegacy, string)`；输入表达式：`Level(n, i.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: i => Level(n, i.Id)`
- `NationalSpire.NationalDevelopment.Level(NationalSpire.NationalLegacy, string)`；输入表达式：`Level(n, target)`；返回值紧邻使用处：`BinaryExpressionSyntax: Level(n, target) - 1`
- `NationalSpire.NationalDevelopment.Pick(NationalSpire.CareerData, NationalSpire.NationalLegacy, string, string, bool)`；输入表达式：`Pick(d, n, group, ":maintain:", aboveZero: true)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Pick(d, n, group, ":maintain:", aboveZero: true) is not { } target`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`Groups.OrderBy(g => InGroup(g).Sum(i => Level(n, i.Id)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Groups.OrderBy(g => InGroup(g).Sum(i => Level(n, i.Id))).ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`InGroup(g).Sum(i => Level(n, i.Id))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => InGroup(g).Sum(i => Level(n, i.Id))`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`Groups.OrderBy(g => InGroup(g).Sum(i => Level(n, i.Id))).ThenBy(g => g, StringComparer.Ordinal).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Groups.OrderBy(g => InGroup(g).Sum(i => Level(n, i.Id))).ThenBy(g => g, StringComparer.Ordinal).ToList()`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`dropped.Add(target)`；返回值紧邻使用处：`ExpressionStatementSyntax: dropped.Add(target);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<string>()`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`Groups.OrderBy(g => InGroup(g).Sum(i => Level(n, i.Id))).ThenBy(g => g, StringComparer.Ordinal)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Groups.OrderBy(g => InGroup(g).Sum(i => Level(n, i.Id))).ThenBy(g => g, StringComparer.Ordinal).ToList`

**赋值（含属性/字段和局部值）：**

- `budget` -= `MaintenancePerGroup`
- `n.Indicators[target]` = `Level(n, target) - 1`

<a id="symbol-30892377c440"></a>

## `NationalSpire.NationalDevelopment.Upgrade(NationalSpire.CareerData, NationalSpire.NationalLegacy, int) — private static void Upgrade(CareerData d, NationalLegacy n, int budget)`

来源：源码第 324 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.NationalDevelopment.Contribute(NationalSpire.CareerData, NationalSpire.NationalLegacy, int)`](NationalDevelopment.cs.md#symbol-abd0a463c72f)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.NationalDevelopment.Cost(int)`](NationalDevelopment.cs.md#symbol-519bf129507f)；[`NationalSpire.NationalDevelopment.InGroup(string)`](NationalDevelopment.cs.md#symbol-1688e440426e)；[`NationalSpire.NationalDevelopment.Level(NationalSpire.NationalLegacy, string)`](NationalDevelopment.cs.md#symbol-b758e69d4a1d)；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Season`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.NationalDevelopment.Cost(int)`；`NationalSpire.NationalDevelopment.Groups`；`NationalSpire.NationalDevelopment.GroupWeight`；`NationalSpire.NationalDevelopment.Indicator.Id`；`NationalSpire.NationalDevelopment.InGroup(string)`；`NationalSpire.NationalDevelopment.Level(NationalSpire.NationalLegacy, string)`；`NationalSpire.NationalLegacy.Country`；`NationalSpire.NationalLegacy.Indicators`；`NationalSpire.NationalLegacy.Pending`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash($"{d.WorldId}:{n.Country}:{d.Season}:{i.Id}:pick")`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: i => CareerEngine.StableHash($"{d.WorldId}:{n.Country}:{d.Season}:{i.Id}:pick")`
- `NationalSpire.NationalDevelopment.Cost(int)`；输入表达式：`Cost(Level(n, indicator.Id))`；返回值紧邻使用处：`AssignmentExpressionSyntax: pending -= Cost(Level(n, indicator.Id))`
- `NationalSpire.NationalDevelopment.Cost(int)`；输入表达式：`Cost(Level(n, indicator.Id))`；返回值紧邻使用处：`BinaryExpressionSyntax: pending >= Cost(Level(n, indicator.Id))`
- `NationalSpire.NationalDevelopment.InGroup(string)`；输入表达式：`InGroup(group)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: InGroup(group)                  .OrderBy`
- `NationalSpire.NationalDevelopment.Level(NationalSpire.NationalLegacy, string)`；输入表达式：`Level(n, i.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: Level(n, i.Id) < 9`
- `NationalSpire.NationalDevelopment.Level(NationalSpire.NationalLegacy, string)`；输入表达式：`Level(n, indicator.Id)`；返回值紧邻使用处：`ArgumentSyntax: Level(n, indicator.Id)`
- `NationalSpire.NationalDevelopment.Level(NationalSpire.NationalLegacy, string)`；输入表达式：`Level(n, indicator.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: Level(n, indicator.Id) + 1`
- `NationalSpire.NationalDevelopment.Level(NationalSpire.NationalLegacy, string)`；输入表达式：`Level(n, indicator.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: Level(n, indicator.Id) < 9`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`InGroup(group)                  .OrderBy(i => CareerEngine.StableHash($"{d.WorldId}:{n.Country}:{d.Season}:{i.Id}:pick"))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: InGroup(group)                  .OrderBy(i => CareerEngine.StableHash($"{d.WorldId}:{n.Country}:{d.Season}:{i.Id}:pick"))                  .Where`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`InGroup(group)                  .OrderBy(i => CareerEngine.StableHash($"{d.WorldId}:{n.Country}:{d.Season}:{i.Id}:pick"))                  .Where(i => Level(n, i.Id) < 9)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var indicator in InGroup(group)                  .OrderBy(i => CareerEngine.StableHash($"{d.WorldId}:{n.Country}:{d.Season}:{i.Id}:pick"))                  .Where(i => Level(n, i.Id) < 9))              {                  while (Level(n, indicator.Id) < 9 && pending >= Cost(Level(n, indicator.Id)))                  {                      pending -= Cost(Level(n, indicator.Id));                      n.Indicators[indicator.Id] = Level(n, indicator.Id) + 1;                  }              }`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`n.Pending.GetValueOrDefault(group)`；返回值紧邻使用处：`BinaryExpressionSyntax: n.Pending.GetValueOrDefault(group) + budget * GroupWeight[group]`

**赋值（含属性/字段和局部值）：**

- `n.Indicators[indicator.Id]` = `Level(n, indicator.Id) + 1`
- `n.Pending[group]` = `pending`
- `pending` -= `Cost(Level(n, indicator.Id))`

<a id="symbol-ba4f9575e17b"></a>

## `NationalSpire.NationalDevelopment.Pick(NationalSpire.CareerData, NationalSpire.NationalLegacy, string, string, bool) — private static string? Pick(CareerData d, NationalLegacy n, string group, string salt, bool aboveZero)`

来源：源码第 345 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.NationalDevelopment.PayMaintenance(NationalSpire.CareerData, NationalSpire.NationalLegacy, ref int)`](NationalDevelopment.cs.md#symbol-2430ad41a5d9)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.NationalDevelopment.InGroup(string)`](NationalDevelopment.cs.md#symbol-1688e440426e)；[`NationalSpire.NationalDevelopment.Level(NationalSpire.NationalLegacy, string)`](NationalDevelopment.cs.md#symbol-b758e69d4a1d)；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Season`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.NationalDevelopment.Indicator.Id`；`NationalSpire.NationalDevelopment.InGroup(string)`；`NationalSpire.NationalDevelopment.Level(NationalSpire.NationalLegacy, string)`；`NationalSpire.NationalLegacy.Country`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash($"{d.WorldId}:{n.Country}:{d.Season}:{group}{salt}")`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.StableHash($"{d.WorldId}:{n.Country}:{d.Season}:{group}{salt}") & 0x7fffffff`
- `NationalSpire.NationalDevelopment.InGroup(string)`；输入表达式：`InGroup(group)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: InGroup(group).Where`
- `NationalSpire.NationalDevelopment.Level(NationalSpire.NationalLegacy, string)`；输入表达式：`Level(n, i.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: Level(n, i.Id) < 9`
- `NationalSpire.NationalDevelopment.Level(NationalSpire.NationalLegacy, string)`；输入表达式：`Level(n, i.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: Level(n, i.Id) > 0`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`InGroup(group).Where(i => aboveZero ? Level(n, i.Id) > 0 : Level(n, i.Id) < 9).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = InGroup(group).Where(i => aboveZero ? Level(n, i.Id) > 0 : Level(n, i.Id) < 9).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`InGroup(group).Where(i => aboveZero ? Level(n, i.Id) > 0 : Level(n, i.Id) < 9)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: InGroup(group).Where(i => aboveZero ? Level(n, i.Id) > 0 : Level(n, i.Id) < 9).ToList`

**赋值（含属性/字段和局部值）：**
