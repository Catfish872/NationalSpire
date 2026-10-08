using System.Text.Json;

namespace NationalSpire;

public sealed class WeeklyEdition
{
    public int ArtVersion { get; set; }
    public string Cooperation { get; set; } = "";
    public PublicSchedule? Schedule { get; set; }
    public int Week { get; set; }
    public int EndDay { get; set; }
    public int PeriodDays { get; set; } = 7;
    public int StartDay => EndDay - PeriodDays + 1;
    public string PeriodLabel => PeriodDays == 14 ? $"第 {Week - 1}—{Week} 周" : $"第 {Week} 周";
    public AiWorkState ProfilesWork { get; set; } = new();
    public AiWorkState NewsWork { get; set; } = new();
    public List<WeeklyProfile> Profiles { get; set; } = [];
    public List<WeeklySlide> Slides { get; set; } = [];
    public List<CommunityMemory> Memory { get; set; } = [];
    public long Revision { get; set; }
    public long SeenRevision { get; set; }
}
public sealed class WeeklyProfile
{
    public string Gender { get; set; } = "";
    public string Id { get; set; } = "";
    public string Name { get; set; } = "";
    public string Background { get; set; } = "";
    public string History { get; set; } = "";
    public string ThisWeek { get; set; } = "";
    public string Previous { get; set; } = "";
    public string Updated { get; set; } = "";
}
public sealed class WeeklySlide
{
    public int CeremonySeason { get; set; }
    public string CameoStoryId { get; set; } = "";
    public string ArtCardId { get; set; } = "";
    public List<string> EventIds { get; set; } = [];
    public string Id { get; set; } = "";
    public string Topic { get; set; } = "";
    public string Facts { get; set; } = "";
    public List<string> People { get; set; } = [];
    public string Character { get; set; } = "";
    public int Importance { get; set; }
    public bool Advertisement { get; set; }
    public string Title { get; set; } = "";
    public string Body { get; set; } = "";
}

public static class WeeklyJournal
{
    private sealed record Performance(string Id, int Day, string Event, string Opponent, bool Clear, int Floor, double? Seconds, string Outcome, int Ascension, string? Challenge = null);
    private static string Fingerprint(CareerPerson p) => $"{p.Wins}:{p.Losses}:{p.Rating}:{p.ClubId}:{p.Form}:{p.Titles}:{p.MaxAscension}";
    public static void Initialize(CareerData data)
    {
        foreach (var person in data.People) data.WeeklyPersonBaselines.TryAdd(person.Id, Fingerprint(person));
    }
    public static bool Recover(CareerData data)
    {
        bool changed = SeasonCeremony.EnsureWeeklyCovers(data);
        foreach (var slide in data.WeeklyEditions.SelectMany(w => w.Slides).Where(s => CameoContent.FindStory(s) != null && s.Topic != "选手动态"))
        { slide.Topic = "选手动态"; changed = true; }
        foreach (var issue in data.WeeklyEditions)
            foreach (var work in new[] { issue.ProfilesWork, issue.NewsWork })
                if (work.State is "sending" or "queued")
                { CommunityThreads.SetWork(work, "failed", "上次生成中断，可重试本项"); changed = true; }
        return changed;
    }
    public static bool ActivateLatest(CareerData data)
    {
        if (!data.Ai.Enabled || data.WeeklyEditions.MaxBy(w => w.Week) is not { } latest) return false;
        bool changed = false;
        foreach (var work in new[] { latest.ProfilesWork, latest.NewsWork })
            if (work.State == "disabled") { CommunityThreads.SetWork(work, "idle"); changed = true; }
        return changed;
    }
    public static void CloseWeek(CareerData data)
    {
        if (data.Day % 14 != 0 || data.WeeklyEditions.Any(w => w.EndDay == data.Day)) return;
        CloseNow(data);
    }

    /// <summary>
    /// 补齐被跳过的周报。原来只在「恰好走到 14 的倍数那一天」才出报，
    /// 读档跳天、回滚存档、或一次推进多天时，中间那些周期会被永久跳过，周报栏就一直空着。
    /// 这里按绝对日从生涯第 1 天起每 14 天一期，把到当前天为止缺的期数依次补上。
    /// </summary>
    public static int ClosePending(CareerData data, int pass)
    {
        int target = Math.Min(data.Day, pass);
        if (target < 14) return 0;
        int closed = 0;
        int day = data.Day;
        // 从生涯第 1 期开始逐期检查：已有的跳过，缺的按那一期的日期补上。
        // 注意不能拿"已有期数的最大值"当起点——列表为空时那样会从很靠后的期数起算，一期都补不出来。
        for (int end = 14; end <= target; end += 14)
        {
            if (data.WeeklyEditions.Any(w => w.EndDay == end)) continue;
            // 补发时要按那一期的日期生成内容，否则会把当前的战绩塞进历史周报里。
            data.Day = end;
            try { CloseNow(data); closed++; }
            catch (Exception e) { Diagnostics.Error("weekly.backfill", e); }
        }
        data.Day = day;
        return closed;
    }

    private static void CloseNow(CareerData data)
    {
        int start = data.Day - 13;
        var issue = new WeeklyEdition { ArtVersion = 1, Week = data.Day / 7, EndDay = data.Day, PeriodDays = 14, Cooperation = CareerCommerce.PublicState(data, data.Day) };
        var performances = new List<Performance>();
        var results = data.Results.Where(r => r.Day >= start && r.Day <= data.Day && r.OfficialAscensionVerified && r.Kind != "private-friendly").ToList();
        foreach (var result in results)
        {
            performances.Add(new("player", result.Day, result.Event, result.Opponent, result.Win, result.Floor, result.RunSeconds, result.Outcome, result.Ascension, MatchRules.ChallengeNote(result, data.CooperativeMembers > 1)));
            var match = data.Matches.FirstOrDefault(m => m.Id == result.MatchId);
            // 正式赛的对手在赛程表中统计；本地比赛单独补充，避免重复。
            if (match != null && match.FixtureId.Length == 0)
                performances.Add(new(result.OpponentId, result.Day, result.Event, CareerEngine.Name(data), match.OpponentWon,
                    match.OpponentFloor, match.OpponentSeconds, match.Draw ? "平局" : match.PlayerWon ? "负" : "胜", result.Ascension));
        }
        foreach (var competition in data.Esports.Competitions)
            foreach (var fixture in competition.Fixtures.Where(f => f.Finished && f.Day >= start && f.Day <= data.Day))
                foreach (string id in new[] { fixture.HomeId, fixture.AwayId })
                {
                    if (id == "player" && results.Any(r => data.Matches.Any(m => m.Id == r.MatchId && m.FixtureId == fixture.Id))) continue;
                    bool home = id == fixture.HomeId;
                    int asc = competition.Modern ? fixture.Ascension : competition.Kind != "league" && (fixture.Day - 1) % 28 + 1 == 26 ? 9 : 8;
                    performances.Add(new(id, fixture.Day, competition.Name, CareerEngine.DisplayName(data, home ? fixture.AwayId : fixture.HomeId),
                        home ? fixture.HomeCleared : fixture.AwayCleared, home ? fixture.HomeFloor : fixture.AwayFloor,
                        home ? fixture.HomeSeconds : fixture.AwaySeconds, fixture.Draw ? "平局" : fixture.WinnerId == id ? "胜" : "负", asc));
                }
        string WeekStats(string id)
        {
            var matches = performances.Where(p => p.Id == id).ToList();
            if (matches.Count == 0) return "本期正式比赛0场。";
            return $"本期正式比赛 {matches.Count} 场，{matches.Count(p => p.Outcome.Contains('胜'))} 胜、{matches.Count(p => p.Outcome.Contains('平'))} 平、{matches.Count(p => p.Clear)} 次通关。"
                + string.Join("；", matches.OrderByDescending(p => p.Day).Take(3).Select(p => $"第{p.Day}天 {p.Event}，对{p.Opponent} {p.Outcome}，赛事进阶{p.Ascension}，{MatchRules.Performance(p.Clear, p.Floor, p.Seconds)}" + (p.Challenge == null ? "" : "。" + p.Challenge)));
        }
        foreach (var person in data.People)
        {
            string fingerprint = Fingerprint(person);
            var baseline = data.WeeklyPersonBaselines.GetValueOrDefault(person.Id, fingerprint).Split(':');
            int oldWins = int.TryParse(baseline.ElementAtOrDefault(0), out int wins) ? wins : person.Wins;
            int oldLosses = int.TryParse(baseline.ElementAtOrDefault(1), out int losses) ? losses : person.Losses;
            bool changed = data.WeeklyPersonBaselines.GetValueOrDefault(person.Id) != fingerprint || performances.Any(p => p.Id == person.Id);
            data.WeeklyPersonBaselines[person.Id] = fingerprint;
            if (!changed || !(EsportsWorld.IsProfessional(person) || person.Role == "青训选手" || performances.Any(p => p.Id == person.Id))) continue;
            issue.Profiles.Add(new() { Id = person.Id, Name = person.PublicName, Gender = IdentityGender.Of(data, person.Id),
                Background = $"姓名{person.Name}，{person.Country}，{person.Role}，{EsportsWorld.ClubName(data, person.ClubId)}，{person.Character}，{person.Style}" + (person.CameoId.Length > 0 ? "；" + person.Biography : ""),
                History = $"累计通关{person.Wins}次/失败{person.Losses}次（含训练），最高进阶{person.MaxAscension}，评分{person.Rating}，冠军{person.Titles}次" + (person.RecordedWinStreak > 0 ? "；" + CameoContent.StreakText(person) : ""),
                ThisWeek = WeekStats(person.Id) + $" 本期累计新增通关{person.Wins - oldWins}次/失败{person.Losses - oldLosses}次（含训练）。", Previous = person.AiIntroduction });
        }
        if (performances.Any(p => p.Id == "player") || data.Esports.Honors.Any(h => h.Day >= start && h.Day <= data.Day))
            issue.Profiles.Insert(0, new() { Id = "player", Name = CareerEngine.Name(data), Gender = data.PlayerGender,
                Background = $"{data.Esports.Country}，{EsportsWorld.LicenseName(data)}；{CareerCommerce.PublicState(data, data.Day)}",
                History = $"正式比赛累计{data.Wins}胜/{data.Draws}平/{data.Losses}负，评分{data.Rating}；赛事最高通关进阶{data.Esports.BestClear}。"
                    + string.Join("；", data.Esports.Honors.TakeLast(3).Select(h => $"第{h.Day}天 {h.Title}")),
                ThisWeek = WeekStats("player") + " " + string.Join("；", results.Select(r => $"第{r.Day}天：{r.Evidence.Summary()}")), Previous = data.PlayerIntroduction });

        // 人口扩展后按与本期主线的关系选编；其余人物的数值档案实时更新，后续周刊继续轮换。
        if (data.Esports.EcosystemVersion >= 1)
        {
            var opponents = results.Select(r => r.OpponentId).ToHashSet();
            issue.Profiles = issue.Profiles.OrderByDescending(p => p.Id == "player").ThenByDescending(p => opponents.Contains(p.Id))
                .ThenByDescending(p => CareerEngine.Person(data, p.Id)?.ClubId == data.Esports.ClubId && data.Esports.ClubId.Length > 0)
                .ThenBy(p => CareerEngine.Person(data, p.Id)?.IntroductionDay ?? 0).ThenBy(p => CareerEngine.StableHash(p.Id + issue.Week)).Take(16).ToList();
            foreach (var p in issue.Profiles) p.History += "；" + CircuitLedger.PublicStanding(data, p.Id, data.Day);
        }

        if (results.Count > 0)
        {
            var focus = results.OrderByDescending(r => r.Win).ThenByDescending(r => r.Ascension).ThenByDescending(r => r.Day).First();
            issue.Slides.Add(new() { Topic = "本期选手焦点", Character = focus.Character, Importance = focus.Win && focus.Ascension >= 8 ? 3 : 2,
                People = ["player", focus.OpponentId], Facts = WeekStats("player") + $"。焦点对局：第{focus.Day}天，{CareerEngine.Name(data)}使用{focus.Character}，卡组：{string.Join('、', focus.DeckSummary)}。{focus.Evidence.Summary()}。关键牌面：{string.Join('；', focus.Cards.Take(5))}" });
        }
        foreach (var competition in data.Esports.Competitions.Where(c => c.Fixtures.Any(f => f.Finished && f.Day >= start && f.Day <= data.Day))
            .OrderByDescending(c => c.Finished).ThenByDescending(c => c.Kind != "league").ThenByDescending(c => c.Country == data.Esports.Country).Take(2))
        {
            var fixtures = competition.Fixtures.Where(f => f.Finished && f.Day >= start && f.Day <= data.Day)
                .OrderByDescending(f => f.HomeId == "player" || f.AwayId == "player").ThenByDescending(f => f.Round).Take(6).ToList();
            string personId = competition.Finished ? competition.ChampionId : fixtures.Where(f => f.WinnerId.Length > 0).Select(f => f.WinnerId).FirstOrDefault() ?? fixtures[0].HomeId;
            issue.Slides.Add(new() { Topic = competition.Name, Character = CareerEngine.Person(data, personId)?.Character ?? results.LastOrDefault()?.Character ?? "铁甲战士",
                Importance = competition.Finished || competition.Kind != "league" ? 3 : 2, People = fixtures.SelectMany(f => new[] { f.HomeId, f.AwayId }).Distinct().ToList(),
                Facts = (competition.Finished ? $"冠军：{(competition.TeamEvent ? CircuitWorld.TeamName(data, competition, competition.ChampionTeam) : CareerEngine.DisplayName(data, competition.ChampionId))}。" : "比赛仍在进行。")
                    + string.Join("；", fixtures.Select(f => $"第{f.Day}天 {CareerEngine.DisplayName(data, f.HomeId)} vs {CareerEngine.DisplayName(data, f.AwayId)}："
                        + (f.Draw ? "平局" : CareerEngine.DisplayName(data, f.WinnerId) + "胜") + (f.Walkover ? "（弃权判定）" : "")
                        + $"；赛事进阶{(competition.Modern ? f.Ascension : competition.Kind != "league" && (f.Day - 1) % 28 + 1 == 26 ? 9 : 8)}，双方表现 {MatchRules.Performance(f.HomeCleared, f.HomeFloor, f.HomeSeconds)} / {MatchRules.Performance(f.AwayCleared, f.AwayFloor, f.AwaySeconds)}")) });
        }
        var representedPosts = data.Posts.Where(p => p.EventKey.StartsWith("match")).Select(p => p.Id).ToHashSet();
        var events = data.CommunityMemories.Where(m => m.Kind == "fact" && !m.Id.StartsWith("life-fact:") && m.Day >= start && m.Day <= data.Day && !m.Id.EndsWith(":result") && !representedPosts.Contains(m.PostId))
            .OrderByDescending(m => m.People.Contains("player")).ThenByDescending(m => m.Day).Take(3).ToList();
        if (events.Count > 0 || issue.Slides.Count == 0 && !data.Life.Events.Any(e => e.Day <= data.Day && e.EditionWeek == 0 && (e.Day >= start || e.Important)))
            issue.Slides.Add(new() { Topic = "赛场内外", Character = "储君", Importance = 1, People = events.SelectMany(m => m.People).Distinct().ToList(),
                Facts = events.Count > 0 ? string.Join("\n", events.Select(m => $"第{m.Day}天 {m.Text}")) : "休赛周：本期正式比赛0场、重大事件0件，选题为简短休赛札记。" });
        // 公告与阶段成果使用原有周刊文章结构；旧的重要事项在实际刊出前继续保留。
        var publicEvents = data.Life.Events.Where(e => e.Day <= data.Day && e.EditionWeek == 0 && (e.Day >= start || e.Important))
            .OrderByDescending(e => e.Important).ThenByDescending(e => e.Id.EndsWith(":finish"))
            .ThenBy(e => CommunityThreads.All(data).Any(p => p.Id == e.PostId && p.NewsGeneration.State == "completed"))
            .ThenByDescending(e => e.Day).Take(8).ToList();
        foreach (var group in publicEvents.Chunk(4))
            issue.Slides.Add(new() { Topic = group.Any(e => e.Important) ? "生涯与俱乐部要闻" : "赛场之外的新鲜事", Character = "储君",
                Importance = group.Any(e => e.Important) ? 2 : 1, EventIds = group.Select(e => e.Id).ToList(),
                People = group.SelectMany(e => e.People).Distinct().Take(8).ToList(),
                Facts = string.Join("\n", group.Select(e => $"第{e.Day}天，{e.Title}：{e.Detail}")) });
        var rng = new Random(CareerEngine.StableHash(data.WorldId + ":weekly:" + issue.Week));
        if (data.Esports.Clubs.Count > 0 && rng.Next(4) != 0)
        {
            var club = rng.Next(2) == 0 && EsportsWorld.Club(data, data.Esports.ClubId) is { } own ? own : data.Esports.Clubs[rng.Next(data.Esports.Clubs.Count)];
            var representative = data.People.FirstOrDefault(p => p.ClubId == club.Id);
            var personal = rng.Next(3) == 0 ? CareerCommerce.ActiveSponsor(data) : null;
            var sponsor = personal ?? data.Esports.Sponsors.FirstOrDefault(s => s.TargetId == club.Id && s.StartSeason <= data.Season && s.EndSeason >= data.Season);
            issue.Slides.Add(new() { Topic = personal == null ? "俱乐部推广" : "合作品牌推广", Advertisement = true, Importance = 1, Character = personal == null ? representative?.Character ?? "静默猎手" : results.LastOrDefault()?.Character ?? "铁甲战士",
                People = personal != null ? ["player"] : representative == null ? [] : [representative.Id], Facts = (personal == null ? $"虚构世界的趣味广告：{club.Country}，{club.Name}，俱乐部介绍：{club.Motto}。" : $"虚构世界的趣味广告：{CareerEngine.Name(data)}的个人合作品牌。") + (sponsor == null ? "" : $"合作品牌{ sponsor.Brand}，合作至第{sponsor.EndSeason}赛季，品牌介绍：{sponsor.Description}。广告口号：{sponsor.Slogan}。") + "创作方向："
                    + new[] { "观众应援", "训练室日常自嘲", "俱乐部周边的夸张创意", "向新观众介绍俱乐部" }[rng.Next(4)]
                    + (personal == null ? "。推广形式为面向故事内观众的俱乐部形象创意。" : "。推广形式为面向故事内观众的选手与合作品牌形象创意。") });
        }
        for (int i = 0; i < issue.Slides.Count; i++) issue.Slides[i].Id = "s" + (i + 1);
        var people = issue.Slides.SelectMany(s => s.People).Distinct().ToList();
        issue.Memory = CommunityMemorySearch.Retrieve(data, string.Join(" ", issue.Slides.Select(s => s.Topic)), people, start - 1, new HashSet<string>(), 5);
        issue.Schedule = PublicSchedule.Capture(data, people);
        // 序列化快照隔离后续日期与介绍更新；关闭 AI 时不积累待发送的收费任务。
        issue = JsonSerializer.Deserialize<WeeklyEdition>(JsonSerializer.Serialize(issue))!;
        if (!data.Ai.Enabled) { issue.ProfilesWork.State = "disabled"; issue.NewsWork.State = "disabled"; }
        data.WeeklyEditions.Add(issue);
        CameoContent.CloseEdition(data, issue);
        SeasonCeremony.EnsureWeeklyCovers(data);
        PublicationBacklog.Compact(data, false);
    }
}
