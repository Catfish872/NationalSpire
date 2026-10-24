namespace NationalSpire;

/// <summary>明确选择模拟时，从已保存的选手赛果采样；不改变未出场比赛的处理。</summary>
public static class PlayerSimulation
{
    public static double WinChance(int wins, int losses, int draws)
    {
        long total = (long)wins + losses + draws;
        return total == 0 ? 1 : (double)wins / total;
    }

    /// <summary>按历史采样表现，再按资料胜率保障获胜；调整后的对手成绩随比赛保存。</summary>
    public static RunPerformance Sample(CareerData d, CareerMatch match, IEnumerable<CareerResult>? history = null, int? ascension = null, double? winChance = null)
    {
        using var timing = UiPerformance.Measure(UiPerformance.Work.PlayerSimulation);
        int levelPlayed = ascension ?? match.RequiredAscension;
        var records = (history ?? d.Results).Where(r => r.Outcome != "退赛" && r.RunSeconds is > 0)
            .GroupBy(r => r.MatchId).Select(g => g.First()).ToArray();
        var actual = records.Where(r => !r.Simulated).ToArray();
        if (actual.Length > 0) records = actual;
        var level = records.Where(r => (r.PlayedAscension ?? r.Ascension) == levelPlayed).ToArray();
        if (level.Length > 0) records = level;
        if (records.Length == 0)
        {
            var professionals = d.People.Where(EsportsWorld.IsProfessional).ToArray();
            double chance = professionals.Length == 0 ? .2 : professionals.Average(p => MatchRules.ClearChance(d, p, levelPlayed));
            double mean = MatchRules.CompletionCenter(true, chance) + (d.CooperativeMembers > 1 ? 1800 : 0);
            mean *= MatchRules.RivalTimeScale(d.RivalLevel);
            // Compare 按整数秒比较，因此首次必胜必须至少快一个完整秒。
            if (match.OpponentWon && match.OpponentSeconds is > 0) mean = Math.Min(mean, Math.Max(.001, Math.Floor(match.OpponentSeconds.Value) - 1));
            var first = VaryTime(d, match, new(true, 0, mean));
            if (match.OpponentWon && match.OpponentSeconds is > 0)
                first = first with { Seconds = Math.Min(first.Seconds, Math.Max(.001, Math.Floor(match.OpponentSeconds.Value) - 1)) };
            return EnsureWin(match, first);
        }
        var rng = new Random(CareerEngine.StableHash(d.WorldId + ":player-simulation:" + match.Seed));
        bool clear = rng.NextDouble() < (double)records.Count(r => r.Win) / records.Length;
        var similar = records.Where(r => r.Win == clear).ToArray();
        int floor = clear ? 0 : similar[rng.Next(similar.Length)].Floor;
        var result = VaryTime(d, match, new(clear, floor, similar.Average(r => r.RunSeconds!.Value)));
        var outcomeRng = new Random(CareerEngine.StableHash(d.WorldId + ":player-simulation-outcome:" + match.Seed));
        return outcomeRng.NextDouble() < (winChance ?? WinChance(d.Wins, d.Losses, d.Draws)) ? EnsureWin(match, result) : result;
    }

    private static RunPerformance EnsureWin(CareerMatch match, RunPerformance result)
    {
        // 正式结算保留三位小数，再按整数秒比较；此处采用相同精度。
        var settled = result with { Seconds = Math.Round(result.Seconds, 3) };
        if (MatchRules.Compare(settled, new(match.OpponentWon, match.OpponentFloor, match.OpponentSeconds ?? 0)) > 0)
            return result;
        if (result.Cleared)
            match.OpponentSeconds = Math.Floor(settled.Seconds) + 1;
        else
        {
            result = result with { Floor = Math.Max(1, result.Floor) };
            match.OpponentWon = false;
            match.OpponentFloor = result.Floor - 1;
        }
        return result;
    }

    private static RunPerformance VaryTime(CareerData d, CareerMatch match, RunPerformance result)
    {
        double lower = result.Seconds * .97, upper = result.Seconds * 1.03;
        // 用时采用独立种子，通关与失败楼层继续沿用原来的抽取结果。
        var rng = new Random(CareerEngine.StableHash(d.WorldId + ":player-simulation-time:" + match.Seed));
        return result with { Seconds = lower + (upper - lower) * rng.NextDouble() };
    }

    public static string? Run(CareerData d, CareerMatch match, string character, string characterId, int? ascension = null)
    {
        if (d.PendingMatchId != null || d.Failure != null || match.Day != d.Day || match.Status != "待赛" || !match.Registered)
            return "请先完成当前比赛，再模拟当天已报名的比赛。";
        if (EsportsWorld.EntryReason(d, match) is { } error) return error;
        MatchRules.PrepareSeed(d, match); MatchRules.PrepareOpponent(d, match);
        var result = Sample(d, match, ascension: ascension);
        CareerEngine.FinishMatch(d, match, result.Cleared, false, result.Floor, character, ascension ?? match.RequiredAscension, [], result.Seconds,
            characterId: characterId, simulated: true);
        return null;
    }
}
