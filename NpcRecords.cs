namespace NationalSpire;

/// <summary>补齐NPC的既有通关履历，不修改实际比赛结果或真人战绩。</summary>
public static class NpcRecords
{
    public const int Version = 1;
    public static bool Ensure(CareerData data)
    {
        bool changed = RestorePrivateClears(data);
        foreach (var person in data.People.Where(p => !data.HumanIds.Contains(p.Id) && p.Id != "player" && p.Role != "联机选手"))
        {
            if (person.EditedCard || person.RecordVersion >= Version) continue;
            Initialize(person, CareerEngine.StableHash(data.WorldId + ":records:" + person.Id));
            // 迁移补齐的是开档前履历，不计为本期新增通关。
            data.WeeklyPersonBaselines.Remove(person.Id);
            changed = true;
        }
        return changed;
    }
    // 只使用已结算且明确记录通关的对局；赛事胜负不代表是否完成爬塔。
    public static bool RestorePrivateClears(CareerData data)
    {
        bool changed = false;
        foreach (var match in data.Matches.Where(m => m.Day <= data.Day && m.Status == "已结算" && PrivateAppointments.IsPrivate(m)))
            changed |= RecordPrivateClear(data, match);
        return changed;
    }
    public static bool RecordPrivateClear(CareerData data, CareerMatch match)
    {
        if (!PrivateAppointments.IsPrivate(match) || match.Status != "已结算" || !match.OpponentPrepared || !match.OpponentWon
            || match.OpponentSeconds is not > 0 || !double.IsFinite(match.OpponentSeconds.Value)
            || match.RequiredAscension is < 0 or > 10 || data.HumanIds.Contains(match.OpponentId) || match.OpponentId == "player"
            || CareerEngine.Person(data, match.OpponentId) is not { } person) return false;
        int highest = Math.Max(person.PrivateHighestClear, match.RequiredAscension);
        int max = Math.Max(person.MaxAscension, highest);
        bool changed = highest != person.PrivateHighestClear || max != person.MaxAscension;
        person.PrivateHighestClear = highest; person.MaxAscension = max;
        return changed;
    }
    public static void Initialize(CareerPerson person, int seed)
    {
        int level = Math.Clamp(person.MaxAscension, 0, 10);
        var rng = new Random(seed);
        double low = level switch { 0 => .01, <= 3 => .03 + level * .015, <= 5 => .08, <= 7 => .12, 8 => .16, _ => .22 };
        double rate = low + rng.NextDouble() * (level >= 6 ? .14 : .07);
        int minimum = level > 0 ? level + 1 : 0;
        int wins = (int)Math.Round(Math.Max(0, person.Losses) * rate / (1 - rate));
        int updated = Math.Max(person.Wins, Math.Max(minimum, wins));
        if (updated != person.Wins) { person.AiIntroduction = ""; person.IntroductionDay = 0; }
        person.Wins = updated;
        person.RecordVersion = Version;
    }
}
