using NationalSpire.Coop;

namespace NationalSpire;

/// <summary>单人经济操作复用原存储提交；多人规则已在独立副本上执行，不再复制或保存。</summary>
public static class EconomicActions
{
    public static string? Save(CareerData data, Func<CareerData, string?> apply)
    {
        using var timing = UiPerformance.Measure(UiPerformance.Work.EconomicSave);
        var candidate = CoopJson.Copy(data); CoopJson.Detached(candidate);
        if (apply(candidate) is { } error) return error;
        var before = data.EncodingHeader();
        Copy(candidate, data);
        return Persist(data, () => Copy(before, data));
    }
    public static string? Trade(CareerData data, MarketOrder order)
    {
        using var timing = UiPerformance.Measure(UiPerformance.Work.EconomicSave);
        // 与多人交易相同，只提供行情、日期和资金；复制将被修改的账户及流水，不复制聊天与帖子。
        var candidate = new CareerData { Day = data.Day, Market = data.Market, Credits = data.Credits,
            Life = CoopJson.Copy(new CareerLifeState { Trading = data.Life.Trading, CreditFraction = data.Life.CreditFraction, Ledger = data.Life.Ledger }) };
        if (CareerMarket.Trade(candidate, order) is { } error) return error;
        var before = (data.Credits, data.Life.Trading, data.Life.CreditFraction, data.Life.Ledger);
        data.Credits = candidate.Credits; data.Life.Trading = candidate.Life.Trading;
        data.Life.CreditFraction = candidate.Life.CreditFraction; data.Life.Ledger = candidate.Life.Ledger;
        return Persist(data, () => (data.Credits, data.Life.Trading, data.Life.CreditFraction, data.Life.Ledger) = before);
    }
    private static string? Persist(CareerData data, Action revert)
    {
        try { CareerStore.Save(data); return null; }
        catch (Exception exception)
        {
            revert(); Diagnostics.Error("economy.save", exception);
            return "操作未能保存，资金与物品保持原状。";
        }
    }
    private static void Copy(CareerData from, CareerData to)
    {
        to.Life = from.Life; to.Credits = from.Credits; to.Fans = from.Fans;
        to.Posts = from.Posts; to.SavedThreads = from.SavedThreads; to.CommunityMemories = from.CommunityMemories;
    }
}
