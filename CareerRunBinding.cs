namespace NationalSpire;

/// <summary>继续对局和赛后结算共用赛事识别；兼容标记仅用于识别，不改写原生随机种子。</summary>
public static class CareerRunBinding
{
    public static bool SameSeed(string expected, string actual)
    {
        if (string.IsNullOrEmpty(expected) || string.IsNullOrEmpty(actual)) return false;
        if (string.Equals(expected, actual, StringComparison.OrdinalIgnoreCase)) return true;
        // 原生 SerializableRunV18ToV19 在旧种子前添加一次 old，RunRngSet 据此使用旧哈希。
        // 只承认本模组赛事种子的这一种单向迁移，保留完整后缀，不能任意删除前缀。
        return expected.StartsWith("NS", StringComparison.Ordinal) && actual.StartsWith("old", StringComparison.Ordinal)
            && string.Equals(expected, actual[3..], StringComparison.OrdinalIgnoreCase);
    }

    public static CareerMatch? Find(CareerData data, string seed, string character, int ascension,
        int playerCount, bool standard, long? startTime = null)
    {
        if (data.PendingMatchId == null || playerCount != 1 || !standard
            || character != data.SelectedCharacter || ascension != data.SelectedAscension
            || (startTime.HasValue && data.PendingSince != 0 && startTime.Value < data.PendingSince - 5)) return null;
        return data.Matches.FirstOrDefault(m => m.Id == data.PendingMatchId && m.Status == "待赛" && SameSeed(m.Seed, seed));
    }
}
