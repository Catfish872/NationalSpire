namespace NationalSpire;

// 世界存档仅保存数值与去重摘要，私信原话和变化原因留在各自信箱。
public sealed class NpcLearning
{
    public double ChanceShift { get; set; }
    public double Exposure { get; set; }
    public Dictionary<string, double> Topics { get; set; } = [];
    public HashSet<string> Receipts { get; set; } = [];
    public HashSet<string> Sources { get; set; } = [];
    public int MoodDay { get; set; }
    public int MoodUntil { get; set; }
    public double MoodStrength { get; set; }
    public bool MoodAggregated { get; set; }
}

public sealed class PlayerDevelopment
{
    // 每100点对应1%通关率加成；不足1点的进度单独保存，避免逐期取整丢失。
    public int Points { get; set; }
    public double Remainder { get; set; }
    public Dictionary<int, double> SeasonRemainders { get; set; } = [];
    public Dictionary<int, int> BySeason { get; set; } = [];
}

public static class CareerTraining
{
    public static readonly string[] LearningTopics = ["选牌", "出牌", "路线", "资源", "构筑", "机制"];
    public static double SkillBonus(CareerPerson person) => person.Learning.ChanceShift;
    public static double MoodBonus(CareerPerson person, int day) => .08 * MoodLevel(person, day);
    public static double MoodLevel(CareerPerson person, int day)
    {
        var state = person.Learning;
        double normal = day < state.MoodDay || day >= state.MoodUntil ? 0 : state.MoodStrength * (state.MoodUntil - day) / Math.Max(1, state.MoodUntil - state.MoodDay);
        // 仲裁处分在三周内保持最大负面等级，普通鼓励不能提前解除官方处分。
        return !state.MoodAggregated && SpireArbitration.ShockDay(person, day) >= 0 ? -3 : normal;
    }
    public static int MoodUntil(CareerPerson person, int day) => SpireArbitration.ShockDay(person, day) is >= 0 and var start ? start + 21 : person.Learning.MoodUntil;
    public static bool RecordMood(CareerData data, string personId, PrivateMood mood)
    {
        if (!PrivateMessages.CanChat(data, personId) || Math.Abs((long)mood.Strength) > 3
            // 旧存档已生成的1—3天记录仍可回放；新回复在交互入口要求7—21天。
            || mood.Days is < 1 or > 21 || mood.Day != data.Day || mood.Id.Length == 0 || mood.Source.Length == 0) return false;
        var person = CareerEngine.Person(data, personId)!; var state = person.Learning;
        if (SpireArbitration.ShockDay(person, data.Day) >= 0) return false;
        string receipt = "mood:" + mood.Id, source = "mood:" + mood.Source;
        if (state.Receipts.Contains(receipt) || state.Sources.Contains(source)) return false;
        mood.Ascension = person.MaxAscension; mood.Before = MatchRules.ClearChance(data, person, person.MaxAscension);
        mood.After = mood.Before;
        state.Receipts.Add(receipt); state.Sources.Add(source);
        // 标记是更新后的状态；减弱、恢复正常和重新估计持续时间均替换原状态。
        state.MoodStrength = mood.Strength; state.MoodDay = mood.Day; state.MoodUntil = mood.Day + mood.Days;
        mood.After = MatchRules.ClearChance(data, person, person.MaxAscension);
        InvalidateForecast(data); return true;
    }
    private static void InvalidateForecast(CareerData data)
    {
        // 学习也会影响陪练贡献和多人队伍，未开赛预估统一失效；进行中的成绩保持不变。
        foreach (var match in data.Matches.Where(m => m.Status == "待赛" && m.Live == null && m.Id != data.PendingMatchId
            && m.PlayedAscension == null && m.PlayerSeconds == null))
        { match.OpponentPrepared = false; match.OpponentSeconds = null; }
    }
    public static bool RecordLesson(CareerData data, string personId, PrivateLearning lesson)
    {
        if (!PrivateMessages.CanChat(data, personId)
            || lesson.Strength == 0 || Math.Abs((long)lesson.Strength) > 3 || lesson.Id.Length == 0 || lesson.Source.Length == 0) return false;
        var person = CareerEngine.Person(data, personId)!; var state = person.Learning;
        if (state.Receipts.Contains(lesson.Id) || state.Sources.Contains(lesson.Source)) return false;
        lesson.Ascension = person.MaxAscension;
        lesson.Before = MatchRules.ClearChance(data, person, person.MaxAscension);
        double magnitude = Math.Abs(lesson.Strength), topic = state.Topics.GetValueOrDefault(lesson.Topic);
        // 双重平方根递减，长期收益趋缓但没有累计硬上限；正负交替不会重置阻力。
        state.ChanceShift += .018 * lesson.Strength / Math.Sqrt(1 + (state.Exposure + magnitude / 2) / 6)
            / Math.Sqrt(1 + (topic + magnitude / 2) / 4);
        state.Exposure += magnitude; state.Topics[lesson.Topic] = topic + magnitude;
        state.Receipts.Add(lesson.Id); state.Sources.Add(lesson.Source);
        lesson.After = MatchRules.ClearChance(data, person, person.MaxAscension);
        // 已经开赛的对手表现不重算；尚未开赛的预估下次按新水平生成。
        InvalidateForecast(data);
        return true;
    }
    public static void MergePrivateLearning(CareerData world, PrivateMailbox mailbox)
    {
        foreach (var c in mailbox.Conversations.Values)
            foreach (var turn in c.Turns.Where(t => t.Status == "complete" && t.Applied))
            {
                if (turn.Learning != null) RecordLesson(world, c.PersonId, turn.Learning);
                if (turn.Mood != null) RecordMood(world, c.PersonId, turn.Mood);
            }
    }
    public static bool Multiplayer(CareerData d) => d.CooperativeMembers > 1 || d.LocalHumanId.Length > 0;
    public static bool IsTraining(LifeActivity a) => a.Kind is "备赛" or "培养";
    public static string Kind(string title) => title switch
    {
        "全队长期合练" or "全队教练课程" => "team-growth",
        "个人长期指导" or "个人录像精读" => "growth",
        "阶段复盘指导" or "队友巩固训练" => "mixed",
        "弱点专项陪练" or "赛前防守陪练" => "defense",
        "队内对局练习" or "赛程模拟训练" or "全队稳定性训练" or "队伍节奏训练" or "全队赛前对练" => "team",
        _ => "single"
    };
    public static List<CareerPerson> Targets(CareerData d)
    {
        var roster = d.Esports.Competitions.Where(c => c.Season == d.Season && c.Kind == "league")
            .SelectMany(c => c.Rosters.GetValueOrDefault(d.Esports.ClubId) ?? []).ToHashSet();
        return d.People.Where(p => p.ClubId == d.Esports.ClubId && EsportsWorld.IsProfessional(p) && !d.HumanIds.Contains(p.Id))
            .OrderByDescending(p => roster.Contains(p.Id)).ThenBy(p => p.PublicName).ToList();
    }
    public static bool ActiveRoster(CareerData d, string id) => d.Esports.Competitions.Any(c => c.Season == d.Season
        && c.Kind == "league" && (c.Rosters.GetValueOrDefault(d.Esports.ClubId)?.Contains(id) ?? false));
    private static int WeeklyRate(LifeActivity a) => (Kind(a.Title) switch
    { "growth" => 50, "team-growth" => a.TermsVersion >= 2 ? 20 : 25, "mixed" => 25, _ => 0 }) * (a.TermsVersion >= 3 ? 2 : 1);
    private static int TemporaryRate(LifeActivity a) => (Kind(a.Title) switch
    { "single" => 1200, "team" => a.TermsVersion >= 2 ? 400 : 600, "mixed" => 400, _ => 0 }) * (a.TermsVersion >= 3 ? 2 : 1);
    private static int DefenseRate(LifeActivity a) => Kind(a.Title) == "defense" ? (a.TermsVersion >= 3 ? 2000 : 1000) : 0;
    public static void Snapshot(CareerData d, LifeActivity a, bool legacy = false)
    {
        a.TrainingKind = legacy ? a.Title.Contains("队内") || a.Title.Contains("全队") || a.Title.Contains("赛程模拟") || a.Title.Contains("队伍") ? "team" : "single" : Kind(a.Title);
        bool team = a.TrainingKind is "team" or "team-growth";
        a.TrainingTargets = team ? Targets(d).Where(p => ActiveRoster(d, p.Id)).Select(p => p.Id).ToList() : [a.PersonId];
        a.TemporaryPoints = legacy ? (a.TrainingKind == "team" ? 600 : 1200) : TemporaryRate(a);
        a.WeeklyGrowthPoints = WeeklyRate(a);
        a.DefensePoints = DefenseRate(a);
        a.TrainingStart = a.StartedDay + 1;
        a.TrainingEnd = a.StartedDay + 28;
        a.FinishDay = a.TrainingEnd + 1;
    }
    private static int SeasonAt(CareerData d, int day)
    {
        int season = d.Season;
        while (season > 1 && day <= SeasonCalendar.Start(d, season)) season--;
        while (day > SeasonCalendar.Start(d, season) + SeasonCalendar.Length(d, season)) season++;
        return season;
    }
    internal static int ExpectedGrowth(CareerData d, LifeActivity a, string id, int weekly)
    {
        var existing = d.Development.GetValueOrDefault(id);
        var state = new PlayerDevelopment { Points = existing?.Points ?? 0, Remainder = existing?.Remainder ?? 0,
            BySeason = existing?.BySeason.ToDictionary(p => p.Key, p => p.Value) ?? [],
            SeasonRemainders = existing?.SeasonRemainders.ToDictionary(p => p.Key, p => p.Value) ?? [] };
        int initial = state.Points;
        int start = a.TrainingStart > 0 ? a.TrainingStart : d.Day + 1;
        for (int week = a.TrainingWeeksPaid + 1; week <= 4; week++) ApplyGrowth(state, weekly, SeasonAt(d, start + week * 7 - 1));
        return state.Points - initial;
    }
    // 对成长阻力积分，分批与一次投入结果一致；小数部分入档，后期仍持续累积。
    private static int ApplyGrowth(PlayerDevelopment state, int amount, int season)
    {
        if (amount <= 0) return 0;
        double total = state.Points + state.Remainder;
        double current = state.BySeason.GetValueOrDefault(season) + state.SeasonRemainders.GetValueOrDefault(season);
        double low = 0, high = amount;
        for (int i = 0; i < 52; i++)
        {
            double delta = (low + high) / 2;
            if (GrowthCost(total, current, delta) < amount) low = delta; else high = delta;
        }
        double growth = (low + high) / 2;
        int previous = state.Points;
        double newTotal = total + growth, newSeason = current + growth;
        state.Points = checked((int)Math.Floor(newTotal)); state.Remainder = newTotal - state.Points;
        state.BySeason[season] = checked((int)Math.Floor(newSeason)); state.SeasonRemainders[season] = newSeason - state.BySeason[season];
        return state.Points - previous;
    }
    private static double GrowthCost(double total, double current, double gain)
    {
        // 累计成长按指数增加培养难度，季内继续递减；积分保证分批结算收益一致。
        const double lifetimeScale = 1200, seasonScale = 800;
        double u = gain / lifetimeScale, exponential, weighted;
        if (u < .1)
        {
            // 小增量使用正项级数，避免两个近似值相减导致长期培养进度丢失。
            exponential = 0; weighted = 0; double term = 1;
            for (int n = 1; n <= 12; n++)
            {
                term *= u / n; exponential += term; weighted += (n - 1) * term;
            }
        }
        else
        {
            double value = Math.Exp(u); exponential = value - 1; weighted = (u - 1) * value + 1;
        }
        return Math.Exp(total / lifetimeScale) * lifetimeScale
            * ((1 + current / seasonScale) * exponential + lifetimeScale / seasonScale * weighted);
    }
    public static void Advance(CareerData d, LifeActivity a)
    {
        if (a.WeeklyGrowthPoints <= 0) return;
        int weeks = Math.Clamp((d.Day - a.TrainingStart) / 7, 0, 4);
        while (a.TrainingWeeksPaid < weeks)
        {
            int date = a.TrainingStart + (++a.TrainingWeeksPaid * 7) - 1;
            int season = SeasonAt(d, date);
            foreach (string id in a.TrainingTargets)
                a.TrainingGained[id] = a.TrainingGained.GetValueOrDefault(id) + Grow(d, id, a.WeeklyGrowthPoints, season);
            a.Result = $"培养进度 {a.TrainingWeeksPaid}/4 周\n" + Gains(d, a);
        }
    }
    public static string Gains(CareerData d, LifeActivity a) => string.Join("、", a.TrainingGained.Select(p =>
        $"{CareerEngine.DisplayName(d, p.Key)}永久通关率 +{p.Value / 100.0:0.##}%"));
    public static int Grow(CareerData d, string id, int amount, int season)
    {
        if (CareerEngine.Person(d, id) == null) return 0;
        if (!d.Development.TryGetValue(id, out var state)) d.Development[id] = state = new();
        int gained = ApplyGrowth(state, amount, season);
        if (gained > 0) InvalidateForecast(d);
        return gained;
    }
    public static double Permanent(CareerData d, string id, int ascension)
        => (d.Development.GetValueOrDefault(id)?.Points ?? 0) / 10000.0;
    public static double Temporary(CareerData d, WorldCompetition c, string id, int day, bool defense = false)
        => Temporary(d, id, day, defense);
    public static double Temporary(CareerData d, string id, int day, bool defense = false)
    {
        string club = CareerEngine.Person(d, id)?.ClubId ?? "";
        if (club.Length == 0) return 0;
        return d.Life.Activities.Where(a => (IsTraining(a) || ClubPrograms.IsTraining(a)) && a.ClubId == club && (a.Status is "进行中" or "已完成")
            && a.TrainingTargets.Contains(id) && day >= a.TrainingStart && day <= a.TrainingEnd)
            .Select(a => defense ? a.DefensePoints : a.TemporaryPoints).DefaultIfEmpty().Max() / 10000.0;
    }
    private static List<string> Beneficiaries(CareerData d, LifeActivity a, string kind) =>
        a.TrainingTargets.Count > 0 ? a.TrainingTargets : kind is "team" or "team-growth"
            ? Targets(d).Where(p => ActiveRoster(d, p.Id)).Select(p => p.Id).ToList() : [a.PersonId];

    public static bool GrowthAvailable(CareerData d, LifeActivity a) => Beneficiaries(d, a, Kind(a.Title)).Any(id => CareerEngine.Person(d, id) != null);
    public static string Description(CareerData d, LifeActivity a)
    {
        string kind = a.TrainingKind.Length > 0 ? a.TrainingKind : Kind(a.Title);
        var targets = Beneficiaries(d, a, kind);
        int weeklyRate = a.TrainingStart > 0 ? a.WeeklyGrowthPoints : WeeklyRate(a);
        var gains = targets.Select(id => ExpectedGrowth(d, a, id, weeklyRate) + a.TrainingGained.GetValueOrDefault(id)).DefaultIfEmpty().ToList();
        string growthText = gains.Max() == 0 && weeklyRate > 0 ? "<0.01%（继续累计）" : gains.Min() == gains.Max() ? $"+{gains.Min() / 100.0:0.##}%" : $"+{gains.Min() / 100.0:0.##}～{gains.Max() / 100.0:0.##}%";
        double temporaryRate = (a.TrainingStart > 0 ? a.TemporaryPoints : TemporaryRate(a)) / 100.0;
        double defenseRate = (a.TrainingStart > 0 ? a.DefensePoints : DefenseRate(a)) / 100.0;
        string effect = kind switch
        {
            "team" => $"全队通关率 +{temporaryRate:0.##}%，持续 28 天",
            "growth" => $"预计永久提升 {growthText}，分四周结算",
            "team-growth" => $"全队预计永久提升 {growthText}，分四周结算",
            "mixed" => $"通关率 +{temporaryRate:0.##}% 持续 28 天；预计永久 {growthText}，分四周结算",
            "defense" => $"未通关时，首幕出局率最多降低 {defenseRate:0.##}%",
            _ => $"通关率 +{temporaryRate:0.##}%，持续 28 天"
        };
        var forecasts = new List<string>();
        foreach (string id in targets)
        {
            var p = CareerEngine.Person(d, id); if (p == null) continue;
            var competition = d.Esports.Competitions.FirstOrDefault(c => c.Season == d.Season && c.Kind == "league" && c.EntrantClubs.ContainsKey(id));
            int asc = competition?.Fixtures.FirstOrDefault()?.Ascension ?? 8;
            int weekly = a.TrainingStart > 0 ? a.WeeklyGrowthPoints : WeeklyRate(a);
            int growth = ExpectedGrowth(d, a, id, weekly);
            if (weekly > 0)
            {
                var current = MatchRules.Evaluate(d, p, asc);
                var improved = current with { Growth = current.Growth + growth / 10000.0 };
                forecasts.Add($"{p.PublicName} · 按当前状态，培养后通关率约 {current.Final:P2} → {improved.Final:P2}");
            }
            else if (kind != "defense")
            {
                int date = a.TrainingStart > 0 ? Math.Clamp(d.Day, a.TrainingStart, a.TrainingEnd) : d.Day + 1;
                var current = MatchRules.Evaluate(d, p, asc, date);
                var improved = current with { Training = Math.Max(current.Training, temporaryRate / 100.0) };
                forecasts.Add($"{p.PublicName} · 通关率约 {current.Final:P2} → {improved.Final:P2}");
            }
            else forecasts.Add(p.PublicName);
        }
        return effect + "\n" + string.Join("\n", forecasts);
    }

    public static string Details(CareerData d, LifeActivity a)
    {
        string kind = a.TrainingKind.Length > 0 ? a.TrainingKind : Kind(a.Title);
        string dates = a.TrainingStart > 0 ? $"第 {a.TrainingStart}—{a.TrainingEnd} 天有效。" : "次日起生效，共 4 周。";
        string limits = "临时效果取最高值。永久成长随累计提升和本季投入逐渐减慢，小数进度保留；转会不丢失，各进阶均生效。";
        string caps = string.Join("\n", Beneficiaries(d, a, kind).Select(id => {
            var state = d.Development.GetValueOrDefault(id);
            int total = state?.Points ?? 0;
            return $"{CareerEngine.DisplayName(d, id)}：累计提升 {total / 100.0:0.##}%，本季提升 {(state?.BySeason.GetValueOrDefault(d.Season) ?? 0) / 100.0:0.##}%。";
        }));
        return dates + "\n" + limits + "\n" + caps;
    }
}
