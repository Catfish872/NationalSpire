namespace NationalSpire;

public static partial class WorldPeople
{
    public const int ContentVersion = 2;
    private static readonly string[][] FamilyNames =
    [
        ["林", "陈", "许", "沈", "陆", "周", "顾", "程", "叶", "纪", "宋", "唐", "梁", "姜", "韩", "白", "余", "苏", "江", "秦", "郑", "温", "方", "谢"],
        ["佐藤", "北原", "森川", "白石", "藤井", "水野", "高桥", "小川", "星野", "浅野", "松本", "宫崎", "石田", "长谷川", "西村", "岛田"],
        ["金", "朴", "李", "崔", "韩", "郑", "尹", "姜", "赵", "申", "林", "吴", "柳", "徐", "安", "车"],
        ["韦伯", "瓦格纳", "贝克尔", "霍夫曼", "舒尔茨", "科赫", "里希特", "克莱因", "沃尔夫", "施耐德", "费舍尔", "克鲁格", "布劳恩", "凯勒", "福格尔", "哈特曼"],
        ["马丁", "贝尔纳", "杜布瓦", "莫罗", "洛朗", "西蒙", "勒费弗尔", "米歇尔", "加尼耶", "鲁索", "布朗", "吉拉尔", "佩兰", "谢瓦利耶", "罗谢", "富尼耶"],
        ["席尔瓦", "桑托斯", "奥利维拉", "科斯塔", "佩雷拉", "阿尔梅达", "费雷拉", "罗德里格斯", "里贝罗", "卡瓦略", "戈麦斯", "马丁斯", "利马", "巴博萨", "罗沙", "梅洛"],
        ["里德", "沃克", "格林", "贝内特", "克拉克", "特纳", "斯科特", "库珀", "摩根", "布鲁克斯", "伍德", "贝利", "福克斯", "普赖斯", "休斯", "科尔"],
        ["米勒", "帕克", "哈里斯", "里维拉", "陈", "罗宾逊", "罗德里格兹", "李", "杨", "卡特", "金", "埃文斯", "罗素", "迪亚兹", "托雷斯", "墨菲"]
    ];
    private static readonly string[][] GivenNames =
    [
        ["岚", "栖", "知行", "归", "映", "墨", "澈", "舟", "晴", "予", "昭", "宁", "序", "遥", "川", "芷", "一鸣", "微", "星河", "景明", "望舒", "闻溪", "砚秋", "清和", "时雨", "云生", "承安", "以南", "思齐", "知夏", "柏言", "沐阳"],
        ["遥", "凛", "直树", "葵", "诚", "莲", "悠", "澪", "千夏", "奏", "凉介", "真琴", "明里", "隼人", "诗织", "夏希"],
        ["道允", "知勋", "瑞真", "敏赫", "秀彬", "河俊", "恩书", "泰旭", "智安", "书妍", "贤宇", "志浩", "恩彩", "承佑", "多恩", "宥真"],
        ["卢卡斯", "约纳斯", "莱昂", "菲利克斯", "汉娜", "米娅", "埃米尔", "莫里茨", "莉娜", "保罗", "克拉拉", "芬恩", "艾米莉", "尼克拉斯", "尤莉娅", "西蒙"],
        ["雨果", "朱尔", "艾玛", "路易", "克洛伊", "加布里埃尔", "卡米耶", "诺埃", "玛农", "卢卡", "莱娅", "阿黛尔", "拉斐尔", "西奥", "爱丽丝", "纳唐"],
        ["卢卡斯", "加布里埃拉", "佩德罗", "比安卡", "拉斐尔", "蒂亚戈", "朱莉娅", "马特乌斯", "玛丽安娜", "费利佩", "布鲁诺", "拉里萨", "卡约", "贝阿特丽斯", "安娜", "莱昂纳多"],
        ["奥利弗", "阿米莉亚", "乔治", "弗雷娅", "亚瑟", "伊莎贝拉", "西奥", "艾薇", "哈里", "艾拉", "查理", "露西", "奥斯卡", "格蕾丝", "阿尔菲", "菲比"],
        ["诺亚", "奥利维娅", "伊桑", "艾娃", "梅森", "索菲娅", "洛根", "米娅", "莉莉", "詹姆斯", "佐伊", "利亚姆", "哈珀", "艾登", "艾米丽", "本杰明"]
    ];
    private static readonly string[] NickStarts = ["晚班", "周末", "北门", "旧街", "路过的", "不熬夜的", "背包里的", "午后", "雨天", "月台", "三号看台", "不喝咖啡的", "仓库", "海边", "山脚", "隔壁", "今天也在", "小镇", "纸箱", "复盘室", "食堂", "末班车", "路灯下的", "蓝色", "长椅上的", "慢半拍的", "暖气旁的", "体育馆", "放学后的", "深夜", "星期五的", "后排", "天台", "河岸边的", "候车室", "海盐味的", "旧书店", "橙色", "晴天", "北站", "猫窝旁的", "看台边的", "周末", "月光下的", "散步中的", "自动售货机旁的", "晚归的", "客厅里的"];
    private static readonly string[] NickEnds = ["爬塔人", "空瓶", "纸鹤", "蘑菇", "小熊", "存档员", "围观群众", "薯条", "打工人", "观赛笔记", "松鼠", "手柄", "薄荷", "旧地图", "盐汽水", "橘子", "队旗", "失眠鱼", "空背包", "小石头", "折纸", "没带钥匙", "收藏家", "卡牌盒", "热可可", "三叶草", "矿泉水", "看台票", "半块饼干", "白板", "铁罐", "收音机", "果冻", "风筝", "耳机", "布丁", "企鹅", "观星人", "仙人掌", "柠檬糖", "小鲸鱼", "球鞋", "邮差", "毛线团", "面包片", "风铃", "记分员", "观众席"];
    private static readonly string[] Temperaments = ["热情", "谨慎", "传统", "好胜", "幽默", "温和", "怀疑", "考据"];
    private static readonly string[] Voices = ["情绪外露，喜欢简短感叹，承认自己看不懂复杂打法", "先核对结果再下判断，措辞克制", "习惯用固定流派解释选牌，对混合构筑困惑", "关注胜负和下一次交手，承认已经发生的失利", "用自身失误自嘲，不杜撰比赛过程", "关心选手成长与低谷，不盲目吹捧", "对新星持保留态度，面对连续成绩会逐渐改口", "喜欢查赛程与历史战绩，不把猜测说成事实"];
    private static readonly string[][] Styles =
    [
        ["力量叠加，偏爱高费攻击", "消耗牌配合，选牌较为保守", "生命交换，愿意为输出承担风险", "格挡积累，常担心后期输出", "多次攻击，优先寻找力量来源", "围绕少数升级攻击牌规划路线"],
        ["中毒积累，习惯等待关键牌", "弃牌配合，偏爱熟悉的过牌组合", "小刀与多次攻击，容易高估连续出牌", "格挡与中毒，打法偏慢", "偏爱低费攻击，选牌积极", "重视保留手牌，依赖固定构筑范本"],
        ["闪电球输出，偏爱增加球位", "冰霜球防御，打法谨慎", "集中与充能球，依赖关键能力牌", "黑暗球积累，习惯等待爆发", "球体触发，喜欢追求单回合高输出", "偏爱零费攻击，对球体构筑较为保守"],
        ["围绕奥斯蒂攻击，偏爱稳定的召唤支援", "奥斯蒂承担伤害，路线选择谨慎", "末日积累，愿意延长战斗", "偏爱奥斯蒂与末日混合构筑", "优先寻找熟悉的召唤配合", "重视召唤持续性，升级选择保守"],
        ["辉星积累，偏爱后期集中输出", "铸剑构筑，围绕熟悉的攻击安排升级", "辉星与高费牌，选牌较为贪心", "偏爱低费过渡，等待核心牌出现", "铸剑与防御，前期路线谨慎", "习惯保留辉星，对消耗时机比较犹豫"]
    ];
    private static readonly string[] ProBios = ["常在赛前整理往届战报，把熟悉的选牌顺序记进笔记。", "训练结束后仍会留在复盘室，但更愿意讨论自己熟悉的角色。", "习惯保存失利的种子，希望下一次能用同一种构筑走得更远。", "比赛前喜欢独自准备，公开采访通常比场上表现克制。", "经常参与队内交流，对自己认定的核心牌很有耐心。", "喜欢研究其他赛区的招牌构筑，临场采用时仍然谨慎。", "会认真阅读支持者的赛后讨论，也会记下质疑自己的观点。", "赛前安排规律，训练笔记里保留着大量被划掉的构筑计划。"];
    private static readonly string[] YouthBios = ["把职业选手的牌组抄进练习本，还在寻找适合自己的打法。", "训练时常与同伴交换种子，期待下一次选拔机会。", "会反复观看熟悉角色的战报，遇到陌生构筑容易迟疑。", "总把职业联赛日程贴在桌边，平时从低进阶练习开始。", "对俱乐部试训充满期待，也清楚自己还缺少稳定成绩。", "习惯写下当天最遗憾的一次选择，第二天重新尝试。"];
    private static readonly string[] FanBios = ["工作之余爬塔，观赛时间通常比自己的对局更长。", "和朋友一起追比赛，最常讨论的是自己没见过的卡牌。", "喜欢收藏赛后战报，自己的挑战仍经常止步前期。", "比赛日会提前安排时间，平时偶尔参加社区活动。", "比起争论打法，更愿意记住那些让自己印象深刻的选手。", "常在社区分享失败经历，希望有一天也能交出漂亮战报。", "喜欢在通勤时阅读赛区新闻，对本地选手格外熟悉。", "看过不少比赛，却仍常被同一类敌人挡住去路。"];
    internal static string[] Surnames(string country) => FamilyNames[HumanNames.Region(country)];
    public static int NameCombinations => HumanNames.NameCount + HumanNames.WholeHandleCount;
    public static string Name(CareerData data, string id, string country, bool nickname)
    {
        var used = data.People.Where(p => p.Id != id).Select(p => p.Name).ToHashSet(StringComparer.Ordinal);
        var rng = new Random(CareerEngine.StableHash(data.WorldId + ":name:" + id));
        string gender = IdentityGender.Of(data, id);
        if (gender == IdentityGender.Unset) gender = IdentityGender.Assigned(data, id);
        for (int attempt = 0; attempt < 2048; attempt++)
        {
            string name = nickname ? HumanNames.Nickname(country, gender, rng) : HumanNames.LegalName(country, gender, rng);
            if (!used.Contains(name)) return name;
        }
        string basis = nickname ? "看台常客" : "新人";
        int suffix = 1; while (used.Contains(basis + suffix)) suffix++;
        return basis + suffix;
    }
    public static void Enrich(CareerData data)
    {
        if (data.ContentVersion >= ContentVersion) return;
        string[] characters = ["铁甲战士", "静默猎手", "故障机器人", "亡灵契约师", "储君"];
        foreach (string country in EsportsWorld.Countries)
        {
            int count = data.People.Count(p => p.Country == country && p.Role == "普通玩家");
            for (int i = count; i < 12; i++)
            {
                string id = $"crowd-{Array.IndexOf(EsportsWorld.Countries, country)}-{i}";
                if (data.People.Any(p => p.Id == id)) continue;
                var rng = new Random(CareerEngine.StableHash(data.WorldId + id));
                data.People.Add(new CareerPerson { Id = id, Name = Name(data, id, country, true), Country = country, Region = country + "社区",
                    Role = "普通玩家", Character = characters[rng.Next(5)], MaxAscension = rng.Next(4), Wins = rng.Next(1, 6), Losses = rng.Next(30, 95), Rating = rng.Next(620, 860) });
            }
        }
        foreach (var person in data.People)
        {
            PersonalityLibrary.Ensure(data, person);
            if (person.EditedCard || person.CameoId.Length > 0 || person.Role is "赛事记者" or "解说员") continue;
            var rng = new Random(CareerEngine.StableHash(data.WorldId + ":identity:" + person.Id));
            int voice = rng.Next(Temperaments.Length);
            if (person.Temperament.Length == 0) person.Temperament = Temperaments[voice];
            person.Voice = Voices[voice];
            if (person.Biography.Length == 0)
            {
                var bank = EsportsWorld.IsProfessional(person) ? ProBios : person.Role == "青训选手" ? YouthBios : FanBios;
                person.Biography = bank[rng.Next(bank.Length)];
            }
            int character = Array.IndexOf(characters, person.Character);
            if (character >= 0) person.Style = Styles[character][rng.Next(Styles[character].Length)];
            if (person.SupportedClubId.Length == 0)
            {
                var clubs = data.Esports.Clubs.Where(c => c.Country == person.Country).ToArray();
                if (clubs.Length > 0) person.SupportedClubId = clubs[rng.Next(clubs.Length)].Id;
            }
        }
        data.ContentVersion = ContentVersion;
    }
}

