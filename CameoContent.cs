namespace NationalSpire;

public sealed class CameoState
{
    public int Version { get; set; }
    public int Editions { get; set; }
    public int LastEndDay { get; set; }
}

public static class CameoContent
{
    public const int Version = 2;
    public sealed record Person(string Key, string Name, string Character, string Style, string Biography, string[] Identities, string Portrait);
    public sealed record Story(string Key, int Edition, string Title, string Body, string Image, string Video);
    public static readonly Person[] People =
    [
        new("baiqu", "白区se", "静默猎手", "玄武猎手，通过大量格挡抵御伤害",
            "白区se a1 53连高手 职业选手+主播 擅长静默猎手，通过大量的格挡让怪物难以撼动半分，被誉为“玄武猎手”。但是平时管不住手脚，总喜欢在各种店里办卡，明明之后就再也没去过那家店。", ["职业选手", "主播"], "baiqu.jpg"),
        new("xiaofu", "小夫", "故障机器人", "使用自行研发的卡9流派",
            "小夫 920连高手 惊人的连胜场数证明了他的实力 擅长故障机器人，使用其研发的卡9流派，无往不胜。曾经是上班族，不过如今已经是职业选手出道。有传言道他与白区se之间有某种难以言说的关系。", ["职业选手", "上班族出身"], "xiaofu.jpg"),
        new("caichu", "菜厨来辣", "铁甲战士", "抓取大量质量上乘的好卡来迅速提升战斗力",
            "菜厨来辣 主播 战士选手，擅长抓取大量质量上乘的好卡来迅速提升战斗力，不知道为什么，明明是战士选手，却选择了储君的卡牌作为头像......", ["职业选手", "主播"], "COSMIC_INDIFFERENCE"),
        new("guangtou", "愤怒的光头", "铁甲战士", "稳健而扎实的打法",
            "愤怒的光头 战士选手 稳健而扎实的打法吸引了大量的粉丝，平时也非常温和，是一名少有的正常选手。但是在某天直播的夜里，因不明原因愤怒异常......", ["职业选手", "主播"], "guangtou.jpg"),
        new("weijimi", "维基米游戏解说", "", "依赖关键牌，抓到关键牌时会惊声尖叫",
            "维基米游戏解说 成功从解说进入职业选手队伍的范例，其打法依赖于关键牌的获取。每当抓到关键牌时，总会发出惊声尖叫，仿佛在害怕着什么东西被刺破一样。", ["职业选手", "解说员"], "weijimi.jpg")
    ];
    public static readonly Story[] Stories =
    [
        new("cameo-dispute", 2, "震惊！白区se与小夫之间，居然闹出了这般矛盾！",
            "本台记者抢先报道，a1 53连高手白区se与920连高手小夫，近日就大卡组与小卡组的孰优孰劣问题，产生了激烈的口角，并进一步演变为斗殴！到底是什么，让两名职业选手如此大打出手？我们拍摄了事件发生时的珍贵历史影像。",
            "dispute.png", "https://www.bilibili.com/video/BV1hphY6sELv/"),
        new("cameo-duel", 3, "震惊！小夫920连胜 VS 白区sea153连胜 正式发起决斗！",
            "前段时间，两位选手之间的矛盾不仅没有得到解决，现在愈演愈烈，终于，二人发起了正式的决斗！本台记者冒着生命危险，成功记录下了这珍贵的一刻！",
            "duel.png", "https://www.bilibili.com/video/BV1Utey68EQj/")
    ];
    public static Story? FindStory(WeeklySlide slide) => Stories.FirstOrDefault(s => s.Key == slide.CameoStoryId);
    public static IEnumerable<WeeklySlide> GeneratedSlides(WeeklyEdition issue) => issue.Slides.Where(s => FindStory(s) == null && s.CeremonySeason == 0);
    public static List<WeeklySlide> VisibleSlides(WeeklyEdition issue) => issue.Slides
        .Where(s => s.CeremonySeason > 0 || issue.NewsWork.State == "completed" || issue.NewsWork.State == "disabled" && FindStory(s) != null)
        .OrderByDescending(s => s.CeremonySeason).ToList();

    public static void Ensure(CareerData data)
    {
        foreach (var person in data.People.Where(p => p.CameoId.Length > 0)) person.Gender = "男";
        if (data.Esports.EcosystemVersion < 0 || data.Cameos.Version >= Version) return;
        if (data.Cameos.Version == 1) { UpgradeRecords(data); return; }
        var clubs = data.Esports.Clubs.Where(c => c.Country == "中国").Select(c => c.Id).ToHashSet();
        var pendingOpponent = data.Matches.FirstOrDefault(m => m.Id == data.PendingMatchId)?.OpponentId;
        var known = data.Results.Select(r => r.OpponentId)
            .Concat(data.Posts.Concat(data.SavedThreads).SelectMany(p => p.RelatedPeople.Concat(p.Replies.Select(r => r.AuthorId)).Append(p.AuthorId)))
            .Concat(data.WeeklyEditions.SelectMany(w => w.Profiles.Select(p => p.Id).Concat(w.Slides.SelectMany(s => s.People)))).ToHashSet();
        foreach (var definition in People)
        {
            if (data.People.Any(p => p.CameoId == definition.Key)) continue;
            // 保留名额及赛事主键；相识程度相同时，优先选择尚未出现在玩家视野中的人物。
            var person = data.People.Where(p => p.CameoId.Length == 0 && p.Country == "中国" && clubs.Contains(p.ClubId)
                    && EsportsWorld.IsProfessional(p) && p.Id != pendingOpponent)
                .OrderBy(p => data.Life.Relationships.GetValueOrDefault(p.Id)).ThenBy(p => known.Contains(p.Id))
                .ThenBy(p => data.People.Count(c => c.CameoId.Length > 0 && c.ClubId == p.ClubId))
                .ThenBy(p => CareerEngine.StableHash(data.WorldId + ":cameo:" + p.Id)).FirstOrDefault();
            if (person == null) return;
            person.CameoId = definition.Key;
            person.Gender = "男";
            person.Name = person.Handle = definition.Name;
            person.HandleAliases.Clear();
            if (definition.Character.Length > 0) person.Character = definition.Character;
            person.Style = definition.Style;
            person.Biography = definition.Biography;
            person.Identities = definition.Identities.ToList();
            person.AiIntroduction = ""; person.IntroductionDay = 0;
            person.SupportedClubId = person.ClubId;
            person.Connections.Clear();
            foreach (var other in data.People) other.Connections.Remove(person.Id);
            // 人物介绍沿用提供的原文，连胜事迹在统一升级步骤中写入履历。
            person.Temperament = definition.Key == "guangtou" ? "温和" : "";
            person.Voice = definition.Key == "weijimi" ? "抓到关键牌时容易惊声尖叫" : "";
            person.Personality = new() { Version = 1 };
            data.WeeklyPersonBaselines.Remove(person.Id);
        }
        var pair = data.People.Where(p => p.CameoId is "baiqu" or "xiaofu").ToList();
        foreach (var person in pair) person.Connections = pair.Where(p => p != person).Select(p => p.Id).ToList();
        data.Cameos.Version = 1;
        data.Cameos.LastEndDay = data.WeeklyEditions.Select(w => w.EndDay).DefaultIfEmpty(0).Max();
        UpgradeRecords(data);
    }

    public static string StreakText(CareerPerson person) => person.RecordedWinStreak <= 0 ? "" :
        $"连胜纪录 {person.RecordedWinStreak} 场" + (person.RecordedStreakAscension >= 0 ? $" · 进阶 {person.RecordedStreakAscension}" : "");

    private static void UpgradeRecords(CareerData data)
    {
        foreach (var person in data.People.Where(p => p.CameoId.Length > 0))
        {
            ApplyRecord(person);
            person.AiIntroduction = "";
            person.IntroductionDay = 0;
            // 补入生涯开始前的既有履历，不能算作本期新增通关。
            data.WeeklyPersonBaselines.Remove(person.Id);
        }
        foreach (var snapshot in data.Posts.Concat(data.SavedThreads).SelectMany(p => p.PeopleAtEvent))
        {
            var current = data.People.FirstOrDefault(p => p.Id == snapshot.Id && p.CameoId.Length > 0 && p.PublicName == snapshot.PublicName);
            if (current == null) continue;
            snapshot.CameoId = current.CameoId; snapshot.Biography = current.Biography;
            ApplyRecord(snapshot);
        }
        data.Cameos.Version = Version;
    }

    private static void ApplyRecord(CareerPerson person)
    {
        int streak = person.CameoId switch { "baiqu" => 53, "xiaofu" => 920, _ => 0 };
        if (streak == 0) return;
        person.RecordedWinStreak = Math.Max(person.RecordedWinStreak, streak);
        person.RecordedStreakAscension = person.CameoId == "baiqu" ? 1 : -1;
        person.Wins = Math.Max(person.Wins, streak);
    }

    public static void CloseEdition(CareerData data, WeeklyEdition issue)
    {
        if (data.Cameos.Version == 0 || issue.EndDay <= data.Cameos.LastEndDay) return;
        data.Cameos.LastEndDay = issue.EndDay;
        data.Cameos.Editions = Math.Min(4, data.Cameos.Editions + 1);
        foreach (var story in Stories.Where(s => s.Edition == data.Cameos.Editions))
        {
            Append(data, issue, story);
            CircuitLedger.Remember(data, story.Key, story.Body, issue.Slides.Single(s => s.CameoStoryId == story.Key).People);
        }
    }

    public static void AppendPreview(CareerData data)
    {
        var issue = data.WeeklyEditions.MaxBy(w => w.EndDay) ?? throw new InvalidOperationException("当前生涯尚无周刊。");
        Ensure(data);
        foreach (var story in Stories) Append(data, issue, story);
    }

    private static void Append(CareerData data, WeeklyEdition issue, Story story)
    {
        if (issue.Slides.Any(s => s.CameoStoryId == story.Key)) return;
        issue.Slides.Add(new() { Id = story.Key, CameoStoryId = story.Key, Topic = "选手动态", Title = story.Title, Body = story.Body,
            Facts = story.Body, Character = "静默猎手", Importance = 3,
            People = data.People.Where(p => p.CameoId is "baiqu" or "xiaofu").Select(p => p.Id).ToList() });
        issue.Revision++;
    }
}
