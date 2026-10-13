using System.Text.Json;

namespace ForexSpire;

/// <summary>旧旁路账户只读解析；只接受同世界同一天，避免用当前事实伪造历史。</summary>
public static class ForexLegacy
{
    public static (ForexState? State, string? Error) Read(string json, string worldId, int day, ForexState current)
    {
        if (current.LegacyImported) return (null, "本生涯已经导入过旧账户。");
        if (current.Account.TotalIn != 0 || current.Account.TotalOut != 0 || current.Account.Cash != 0 ||
            current.Account.Positions.Count > 0 || current.Account.Loan != null ||
            current.Records.Any(r => r.Kind is "open" or "close" or "borrow" or "repay"))
            return (null, "原生账户已有交易，不能覆盖。");
        using var document = JsonDocument.Parse(json);
        if (!document.RootElement.TryGetProperty("Runs", out var runs) || !runs.TryGetProperty(worldId, out var run))
            return (null, "旧存档没有当前世界的账户，未使用其他世界或 default 的资产。");
        var state = run.Deserialize<ForexState>() ?? throw new InvalidDataException("旧账户为空。");
        if (!state.Initialized || state.LastDay != day)
            return (null, "旧外汇日期与当前生涯不一致。请使用日期一致的生涯备份再导入；原文件未修改。");
        if (state.ForexVersion > 3) return (null, "旧账户版本高于当前支持范围。");
        var a = state.Account;
        bool Valid(double value) => double.IsFinite(value) && value >= 0 && value <= int.MaxValue;
        if (a == null || a.Positions == null || !Valid(a.Cash) || !Valid(a.TotalIn) || !Valid(a.TotalOut) ||
            state.Prices == null || state.Candles == null || state.SignalledRounds == null)
            return (null, "旧账户数据不完整，未导入。");
        if (a.Loan is { } loan && (!Valid(loan.Principal) || !Valid(loan.Owed) || !Valid(loan.DailyRate)))
            return (null, "旧借款数据无效。");
        foreach (var p in a.Positions)
            if (ForexRules.Pair(p.Pair) == null || p.Dir is not (1 or -1) || !ForexMath.IsValidLeverage(p.Leverage) ||
                !Valid(p.Margin) || !Valid(p.InitialMargin) || !Valid(p.Notional) || !Valid(p.Shares) ||
                !double.IsFinite(p.Entry) || p.Entry <= 0)
                return (null, "旧持仓数据无效，未导入。");
        if (a.Positions.Any(p => p.Id <= 0) || a.Positions.Select(p => p.Id).Distinct().Count() != a.Positions.Count)
            return (null, "旧持仓编号重复或无效，未导入。");
        if (a.Positions.Any(p => p.Id == int.MaxValue)) return (null, "旧持仓编号已超出范围。");
        a.NextPositionId = Math.Max(a.NextPositionId, a.Positions.Select(p => p.Id + 1).DefaultIfEmpty(1).Max());
        if (state.Prices.Any(p => !double.IsFinite(p.Value) || p.Value <= 0) ||
            state.Candles.Any(p => p.Value == null || p.Value.Any(v => !double.IsFinite(v) || v <= 0)))
            return (null, "旧行情数据无效，未导入。");
        return (state, null);
    }
}

