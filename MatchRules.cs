namespace NationalSpire;

public readonly record struct RunPerformance(bool Cleared, int Floor, double Seconds);

public readonly record struct ChanceFactors(double Basis, double Growth, double Practice, double Training, double Skill, double Mood, double Defense)
{
    public double Bonus => Growth + Practice + Training + Skill + Mood;
    public double Final => MatchRules.ApplyBonuses(Basis, Bonus);
    public string Display()
    {
        static string Percent(double value) => (value * 100).ToString(
            value != 0 && Math.Abs(value * 100) < .01 ? "0.##########" : "0.##",
            System.Globalization.CultureInfo.InvariantCulture) + "%";
        string formula = "基础" + Percent(Basis);
        foreach (var (name, value) in new[] { ("长期培养", Growth), ("陪练", Practice), ("临时训练", Training), ("交流学习", Skill), ("短期状态", Mood) })
            if (value != 0) formula += (value > 0 ? " + " : " − ") + name + Percent(Math.Abs(value));
        double total = Basis + Bonus;
        if (total > Final + 1e-12) formula += " − 高概率衰减" + Percent(total - Final);
        if (total < 0) formula += "，最低0%";
        return Percent(Final) + "（" + formula + "）";
    }
}

public static class MatchRules
{
    public static int PreferredAscension(CareerData data, CareerMatch match)
        => Math.Clamp(match.ChosenAscension ?? data.SelectedAscension, match.RequiredAscension, 10);

    public static double RivalTimeScale(int level) => level switch { 100 => .75, 10000 => 1.5, _ => 1 };
    public static void SetRivalLevel(CareerData data, int level)
    {
        if (level is not (100 or 1000 or 10000)) throw new ArgumentException("请选择有效的局内 AI 水平。");
        if (data.PendingMatchId != null) throw new InvalidOperationException("请在本场比赛结束后调整。");
        data.RivalLevel = level;
        foreach (var match in data.Matches.Where(m => m.Status == "待赛" && m.Live == null && m.PlayedAscension == null && m.PlayerSeconds == null))
        { match.OpponentPrepared = false; match.OpponentSeconds = null; }
    }
    private const string SeedCharacters = "0123456789ABCDEFGHJKLMNPQRSTUVWXYZ";
    public static string RandomizeSeed(string seed, string kind = "", int season = 0)
    {
        // 前八位保留赛事类别、赛季和原赛程身份；末六位只在首次开赛或加赛时随机生成。
        string prefix;
        if (seed.Length == 14 && seed.StartsWith("NS", StringComparison.Ordinal)
            && seed.All(SeedCharacters.Contains)) prefix = seed[..8];
        else
        {
            if (kind.Length == 0)
                kind = new[] { "worldfinal", "worldcup", "continental", "league", "academy", "local", "city", "masters", "open" }
                    .FirstOrDefault(value => seed.Contains(value, StringComparison.OrdinalIgnoreCase)) ?? "legacy";
            char eventCode = kind switch
            {
                "league" => 'L', "worldfinal" => 'F', "worldcup" => 'W', "continental" => 'T',
                "academy" => 'A', "local" => 'C', "city" => 'Y', "masters" => 'M', "open" => 'P', _ => 'X'
            };
            int identity = CareerEngine.StableHash(seed);
            Span<char> schedule = stackalloc char[4];
            for (int i = schedule.Length - 1; i >= 0; i--)
            {
                schedule[i] = SeedCharacters[identity % SeedCharacters.Length];
                identity /= SeedCharacters.Length;
            }
            prefix = "NS" + eventCode + SeedCharacters[Math.Abs(season) % SeedCharacters.Length] + new string(schedule);
        }
        Span<char> random = stackalloc char[6];
        for (int i = 0; i < random.Length; i++)
            random[i] = SeedCharacters[System.Security.Cryptography.RandomNumberGenerator.GetInt32(SeedCharacters.Length)];
        return prefix + new string(random);
    }

    // 每场比赛仅生成一次额外随机值；旧档正在进行的比赛继续沿用原种子。
    public static void PrepareSeed(CareerData data, CareerMatch match)
    {
        if (match.SeedRandomized || match.Status != "待赛" || data.PendingMatchId == match.Id
            || match.Live != null || match.PlayedAscension != null || match.PlayerSeconds != null) return;
        string next;
        do { next = RandomizeSeed(match.Seed, match.Kind, data.Season); }
        while (next == match.Seed || data.Matches.Any(other => other.Id != match.Id && other.Seed == next));
        match.Seed = next;
        match.SeedRandomized = true;
        match.OpponentPrepared = false;
        match.OpponentSeconds = null;
    }

    private static double RatingEffect(CareerPerson person)
    {
        double value = (person.Rating - (680 + person.MaxAscension * 76)) / 400.0;
        return value <= 1 ? Math.Max(-1, value) : 1 + Math.Log(value);
    }
    public static double ClearChance(CareerPerson person, int officialAscension, double chanceBonus = 0, int? day = null)
    {
        return ApplyBonuses(BaseChance(person, officialAscension), chanceBonus + CareerTraining.SkillBonus(person)
            + (day.HasValue ? CareerTraining.MoodBonus(person, day.Value) : 0));
    }
    public static double BaseChance(CareerPerson person, int officialAscension)
    {
        if (person.CustomClearChance is { } custom)
            return CustomChanceAtAscension(custom, person.MaxAscension, officialAscension);
        double rating = RatingEffect(person);
        int form = person.Form.TakeLast(5).Sum(c => c == '胜' ? 1 : c == '负' ? -1 : 0);
        double chance = Math.Max(0.00001, CareerEngine.WinChance(officialAscension, person.MaxAscension)
            * Math.Exp(rating * 0.06 + form * 0.008));
        if (officialAscension >= 9 && person.MaxAscension < officialAscension)
            chance *= Math.Pow(0.35, officialAscension - person.MaxAscension);
        return chance <= .94 ? chance : 1 - .0036 / (chance - .88);
    }

    // 所有加成先按百分点求和，再统一处理边界；自定义的高基础概率保持原值。
    public static double ApplyBonuses(double basis, double bonus)
    {
        double total = basis + bonus, start = Math.Max(.94, basis);
        if (total <= start) return Math.Clamp(total, 0, 1);
        double remaining = 1 - start;
        return remaining <= 0 ? 1 : 1 - remaining * remaining / (remaining + total - start);
    }

    public static ChanceFactors Evaluate(CareerData data, CareerPerson person, int ascension, int? day = null, bool includePractice = true)
    {
        int date = day ?? data.Day;
        return new(BaseChance(person, ascension), CareerTraining.Permanent(data, person.Id, ascension),
            includePractice ? OwnedClubs.PracticeBonus(data, person.Id, ascension, date) : 0,
            Math.Max(CareerTraining.Temporary(data, person.Id, date), TeamPreparations.Bonus(data, person.Id, date)), CareerTraining.SkillBonus(person),
            CareerTraining.MoodBonus(person, date), CareerTraining.Temporary(data, person.Id, date, true));
    }

    public static double ClearChance(CareerData data, CareerPerson person, int ascension, int? day = null)
        => Evaluate(data, person, ascension, day).Final;

    public static ChanceFactors TeamChance(CareerData data, WorldCompetition? competition, string id, string rosterSeed, int ascension, int day)
    {
        var roster = CircuitWorld.CooperativeRoster(data, competition, id, rosterSeed);
        if (roster.Count != data.CooperativeMembers) throw new InvalidOperationException("对手队伍人数不足。");
        var values = roster.Select(p => Evaluate(data, p, ascension, day)).ToList();
        // 各成员使用同一计算入口，队伍各项取平均，人数不会放大培养收益。
        return new(values.Average(v => v.Basis), values.Average(v => v.Growth), values.Average(v => v.Practice),
            values.Average(v => v.Training), values.Average(v => v.Skill), values.Average(v => v.Mood), values.Average(v => v.Defense));
    }

    public static RunPerformance Simulate(CareerData data, string id, int ascension, string seed, int? day = null,
        bool cooperative = false, WorldCompetition? competition = null, string? rosterSeed = null)
    {
        int date = day ?? data.Day;
        var person = cooperative ? CircuitWorld.CooperativePerformance(data, competition, id, rosterSeed ?? seed, date)
            : CareerEngine.Person(data, id) ?? throw new InvalidOperationException("选手不存在。");
        var factors = cooperative ? TeamChance(data, competition, id, rosterSeed ?? seed, ascension, date)
            : Evaluate(data, person, ascension, date);
        return SimulatePerformance(person, ascension, seed, cooperative, factors.Final, factors.Defense, data.RivalLevel, date);
    }

    private static double CustomChanceAtAscension(double custom, int highest, int ascension)
    {
        custom = Math.Clamp(custom, 0, 1);
        highest = Math.Clamp(highest, 0, 10);
        ascension = Math.Clamp(ascension, 0, 10);
        if (ascension == highest) return custom;
        double reference = CareerEngine.WinChance(highest, highest);
        double target = reference;
        // 原难度表部分低水平区间有阶跃，换算时保持难度单调，避免越级反而更容易。
        for (int level = highest + 1; level <= ascension; level++)
        {
            double next = CareerEngine.WinChance(level, highest);
            if (level >= 9) next *= Math.Pow(.35, level - highest);
            target = Math.Min(target, next);
        }
        for (int level = highest - 1; level >= ascension; level--)
            target = Math.Max(target, CareerEngine.WinChance(level, highest));
        // 难度提高时按通关概率比例降低，难度降低时按失败概率比例减少失败。
        // 沿用现有进阶难度差异，同时避免降低进阶后直接截断为 100%。
        return target < reference ? custom * target / reference
            : 1 - (1 - custom) * (1 - target) / (1 - reference);
    }

    // 每场使用独立种子；实际挑战进阶不参与对手的模拟或赛事排名。
    public static RunPerformance Simulate(CareerPerson person, int officialAscension, string seed, bool cooperative = false, double chanceBonus = 0, double defenseBonus = 0, int rivalLevel = 1000, int? day = null)
        => SimulatePerformance(person, officialAscension, seed, cooperative, ClearChance(person, officialAscension, chanceBonus, day), defenseBonus, rivalLevel, day);

    private static RunPerformance SimulatePerformance(CareerPerson person, int officialAscension, string seed, bool cooperative, double chance, double defenseBonus, int rivalLevel, int? day)
    {
        if (SpireArbitration.Banned(person, day ?? 0)) return new(false, -1, 0);
        var rng = new Random(CareerEngine.StableHash($"performance:{seed}:{person.Id}:{officialAscension}"));
        double rating = RatingEffect(person);
        int form = person.Form.TakeLast(5).Sum(c => c == '胜' ? 1 : c == '负' ? -1 : 0);
        double performance = rng.NextDouble();
        bool clear = performance < chance;
        double stage = rng.NextDouble();
        int floor = clear ? 0 : FailureFloor(chance, defenseBonus, stage, rng.NextDouble());
        // 完整通关的平均用时按职业身份区分；失败仍按实际止步楼层折算。
        int comfort = person.MaxAscension - officialAscension;
        bool professional = EsportsWorld.IsProfessional(person);
        double baseline = Math.Max(professional ? 3300 : 4800,
            (professional ? 3600 : 5100) - comfort * 90 - rating * 90 - form * 10);
        // 多人队伍完整通关基准增加半小时，职业差异和随机波动沿用原计算。
        double teamOffset = cooperative ? 1800 : 0;
        baseline += teamOffset;
        double seconds = baseline * (.88 + rng.NextDouble() * .24);
        if (comfort >= 3 && rng.NextDouble() < .025) seconds = Math.Min(seconds, 2100 + teamOffset + rng.NextDouble() * 540);
        double minimum = cooperative ? 3600 : 2700;
        // 低于下限时保留个人差异，避免大量选手同时停在整点。
        if (seconds < minimum) seconds = minimum + CareerEngine.StableHash(seed + ":minimum:" + person.Id) % 301;
        seconds = Math.Round(seconds);
        // 仅缩放最终用时，不额外取随机数，通关结果、止步楼层与个人差异沿用原计算。
        double original = clear ? seconds : Math.Round(seconds * floor / 50);
        return new(clear, floor, original * RivalTimeScale(rivalLevel));
    }

    internal static int FailureFloor(double chance, double defenseBonus, double stageRoll, double floorRoll)
    {
        // 使用计入全部加成后的概率，不重复叠加评分或最高进阶的影响。
        // 每个概率档都保留三幕失败的机会；通关率越高，幕次和幕内楼层均向后移动。
        double strength = Math.Clamp(chance, 0, 1);
        double early = .48 - .40 * strength, late = .20 + .55 * strength;
        double reduction = Math.Min(Math.Max(0, defenseBonus), Math.Max(0, early - .05));
        early -= reduction; late += reduction;
        var (first, count) = stageRoll < early ? (4, 13) : stageRoll >= 1 - late ? (35, 16) : (18, 16);
        double position = Math.Pow(floorRoll, 1 / (1 + 2 * strength));
        return first + Math.Min(count - 1, (int)(position * count));
    }

    // 正数表示左方获胜。通关优先；都通关比较用时，都未通关比较楼层。
    public static int Compare(RunPerformance left, RunPerformance right)
    {
        int clear = left.Cleared.CompareTo(right.Cleared);
        if (clear != 0) return clear;
        return left.Cleared ? Math.Floor(right.Seconds).CompareTo(Math.Floor(left.Seconds)) : left.Floor.CompareTo(right.Floor);
    }

    public static void PrepareOpponent(CareerData data, CareerMatch match)
    {
        if (match.OpponentPrepared) return;
        var person = CareerEngine.Person(data, match.OpponentId) ?? throw new InvalidOperationException("对手不存在");
        var result = Simulate(data, person.Id, match.RequiredAscension, data.WorldId + ":" + match.Seed, match.Day,
            data.CooperativeMembers > 1, data.Esports.Competitions.FirstOrDefault(c => c.Id == match.CompetitionId), match.Seed);
        match.OpponentWon = result.Cleared; match.OpponentFloor = result.Floor;
        match.OpponentSeconds = result.Seconds; match.OpponentPrepared = true;
    }

    public static double RewardMultiplier(int officialAscension, int playedAscension) => 1 + Math.Clamp(playedAscension - officialAscension, 0, 10) * 0.15;
    public static int Reward(int amount, double multiplier) => (int)Math.Round(amount * multiplier, MidpointRounding.AwayFromZero);
    public static string Time(double? seconds)
    {
        if (seconds is not > 0 || !double.IsFinite(seconds.Value)) return "用时未记录";
        long total = (long)Math.Floor(seconds.Value);
        return (total >= 3600 ? $"{total / 3600}小时" : "") + $"{total / 60 % 60}分{total % 60:00}秒";
    }
    public static string Performance(bool cleared, int floor, double? seconds) => cleared ? "通关 · " + Time(seconds) : floor < 0 ? "禁赛缺席" : $"止步第 {floor} 层";
    public static string AscensionLabel(CareerResult result) => result.OfficialAscensionVerified ? $"赛事进阶 {result.Ascension}" : "旧赛制记录 · 赛事进阶未核实";
    public static string? ChallengeNote(CareerResult result, bool cooperative = false) =>
        result.OfficialAscensionVerified && result.PlayedAscension is { } played && played > result.Ascension
            ? $"{(cooperative ? "玩家队伍" : "玩家")}主动提高挑战进阶，以进阶 {played} 参赛；{(cooperative ? "对手队伍" : "对手")}仍按赛事进阶 {result.Ascension} 参赛。"
            : null;
    public static string Report(CareerMatch match, CareerResult result, bool cooperative = false)
    {
        string own = Performance(result.Win, result.Floor, result.RunSeconds);
        string other = Performance(match.OpponentWon, match.OpponentFloor, match.OpponentSeconds);
        string details = (CareerEngine.StableHash(match.Seed) % 4) switch
        {
            0 => $"你的成绩：{own}；{result.Opponent}{other}。赛事判定：{result.Outcome}。",
            1 => $"本场记录为你{result.Outcome}。你{own}；对手{result.Opponent}{other}。",
            2 => $"{result.Opponent}交出{other}的成绩；你的战报为{own}。最终你{result.Outcome}。",
            _ => $"双方战报已确认：你{own}，{result.Opponent}{other}。本场结果：你{result.Outcome}。"
        };
        return $"赛事进阶 {match.RequiredAscension}。" + ChallengeNote(result, cooperative) + details + match.Decider;
    }
}
