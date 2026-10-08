namespace NationalSpire;

/// <summary>失败成绩在玩家确认前只保存为待选择记录，不进入任何正式结算入口。</summary>
public sealed class FailureDecision
{
    public string Attempt { get; set; } = Guid.NewGuid().ToString("N");
    public CareerResult Result { get; set; } = new();
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
        var match = d.Matches.FirstOrDefault(m => m.Id == r.MatchId);
        if (match == null) throw new InvalidDataException("待确认比赛记录缺失。");
        d.Failure = null;
        CareerEngine.FinishMatch(d, match, r.Win, failure.Abandoned, r.Floor, r.Character,
            r.PlayedAscension ?? r.Ascension, r.Cards, r.RunSeconds ?? 0, r.DeckSummary, r.Evidence, r.CharacterId, confirmFailure: true);
    }
    public static CareerMatch Retry(CareerData d, bool newSeed)
    {
        var failure = d.Failure ?? throw new InvalidOperationException("没有待选择的失败。");
        var m = d.Matches.Single(m => m.Id == failure.Result.MatchId);
        if (newSeed)
        {
            m.Seed = "NS" + Guid.NewGuid().ToString("N")[..12].ToUpperInvariant();
            m.OpponentPrepared = false; m.OpponentSeconds = null; m.Live = null;
        }
        m.PlayerSeconds = null; m.PlayerFloor = 0; m.Draw = m.PlayerWon = false;
        d.PendingMatchId = null; d.PendingSince = 0;
        failure.RetryRequested = true;
        return m;
    }
}
