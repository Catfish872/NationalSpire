namespace NationalSpire;

/// <summary>失败成绩在玩家确认前只保存为待选择记录，不进入任何正式结算入口。</summary>
public sealed class FailureDecision
{
    public string Attempt { get; set; } = Guid.NewGuid().ToString("N");
    public CareerResult Result { get; set; } = new();
    public RunPerformance? Opponent { get; set; }
    public bool Abandoned { get; set; }
    public bool RetryRequested { get; set; }
}

public static class MatchFailure
{
    public static string? Locked(CareerData d) => d.Failure == null ? null : "请先选择重赛或确认失败。";
    public static void Confirm(CareerData d)
    {
        if (d.Failure is not { } failure) return;
        var r = failure.Result;
        var match = RestoreMatch(d);
        d.Failure = null;
        CareerEngine.FinishMatch(d, match, r.Win, failure.Abandoned, r.Floor, r.Character,
            r.PlayedAscension ?? r.Ascension, r.Cards, r.RunSeconds ?? 0, r.DeckSummary, r.Evidence, r.CharacterId, confirmFailure: true, simulated: r.Simulated);
    }
    public static CareerMatch Retry(CareerData d, bool newSeed)
    {
        var failure = d.Failure ?? throw new InvalidOperationException("没有待选择的失败。");
        var m = RestoreMatch(d);
        if (newSeed)
        {
            m.Seed = "NS" + Guid.NewGuid().ToString("N")[..12].ToUpperInvariant();
            m.OpponentPrepared = false; m.OpponentSeconds = null; m.Live = null;
        }
        // 重赛重新计时，楼层观察、发言冷却和观众状态归属于本轮实际对局。
        if (m.Live != null) m.Live.Commentary = new();
        m.PlayerSeconds = null; m.PlayerFloor = 0; m.Draw = m.PlayerWon = false;
        d.PendingMatchId = null; d.PendingSince = 0;
        failure.RetryRequested = true;
        return m;
    }

    public static CareerMatch RestoreMatch(CareerData d)
    {
        var failure = d.Failure!;
        var match = d.Matches.Single(m => m.Id == failure.Result.MatchId);
        // 旧待确认记录在首次选择时保存原对手，后续确认和重新选择都读取同一份成绩。
        failure.Opponent ??= match.Seed == failure.Result.Seed && match.OpponentPrepared && match.OpponentSeconds.HasValue
            ? new(match.OpponentWon, match.OpponentFloor, match.OpponentSeconds.Value)
            : MatchRules.Simulate(d, match.OpponentId, match.RequiredAscension,
                d.WorldId + (d.CooperativeMembers > 1 ? ":coop:" : ":") + failure.Result.Seed,
                match.Day, d.CooperativeMembers > 1, d.Esports.Competitions.FirstOrDefault(c => c.Id == match.CompetitionId), failure.Result.Seed);
        var opponent = failure.Opponent.Value;
        match.Seed = failure.Result.Seed;
        match.OpponentWon = opponent.Cleared; match.OpponentFloor = opponent.Floor;
        match.OpponentSeconds = opponent.Seconds; match.OpponentPrepared = true;
        match.ChosenAscension = failure.Result.PlayedAscension ?? failure.Result.Ascension;
        return match;
    }
}
