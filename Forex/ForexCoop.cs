using System.Text.Json;

namespace ForexSpire;

/// <summary>个人资产不复制为共享市场资金；离线成员也按共同日期结算。</summary>
public sealed class ForexPortfolio
{
    public ForexAccount Account { get; set; } = new();
    public List<ForexRecord> Records { get; set; } = [];
    public int LastDay { get; set; }
    public ForexPortfolio Copy() => JsonSerializer.Deserialize<ForexPortfolio>(JsonSerializer.Serialize(this))!;
}

public sealed record ForexCoopStep(ForexState Market, Dictionary<string, ForexPortfolio> Members, bool Advanced);

public static class ForexCoop
{
    public static ForexState View(ForexState market, ForexPortfolio member)
    {
        var view = market.Copy();
        view.Account = member.Copy().Account;
        view.Records = member.Records.Concat(market.Records.Where(r => r.Kind == "signal"))
            .OrderByDescending(r => r.Day).Take(120).ToList();
        return view;
    }

    public static ForexCoopStep Advance(ForexState market, Dictionary<string, ForexPortfolio> members, ForexDay facts)
    {
        if (facts.Day <= market.LastDay) return new(market, members, false);
        if (members.Values.Any(p => p.LastDay != market.LastDay))
            throw new InvalidOperationException("成员外汇账户与共享市场日期不一致。");
        var next = market.Copy();
        if (next.Account.Cash != 0 || next.Account.Positions.Count > 0 || next.Account.Loan != null)
            throw new InvalidOperationException("共享市场不能持有个人资产。");
        ForexMarket.Advance(next, facts);
        var accounts = new Dictionary<string, ForexPortfolio>();
        foreach (var (id, portfolio) in members)
        {
            var copy = portfolio.Copy();
            var accountState = new ForexState { Account = copy.Account, Records = copy.Records, Prices = next.Prices };
            ForexMarket.SettleAccount(accountState, facts.Day);
            accountState.Record(facts.Day, "daily", "账户日结算 · 持仓 " + copy.Account.Positions.Count + " 笔");
            copy.LastDay = facts.Day;
            accounts[id] = copy;
        }
        return new(next, accounts, true);
    }

    public static (ForexPortfolio? Portfolio, decimal Wallet, decimal Change, string? Error) Trade(
        ForexState market, ForexPortfolio member, decimal wallet, int day, ForexOrder order)
    {
        if (market.LastDay != day || member.LastDay != day) return (null, wallet, 0, "账户结算日期异常，暂不能交易。");
        var candidate = ForexWallet.Apply(View(market, member), wallet, day, order);
        if (candidate.Error != null) return (null, wallet, 0, candidate.Error);
        // View里的市场信号不写回个人日志，防止每次交易重复复制。
        return (new ForexPortfolio { Account = candidate.State!.Account, LastDay = day,
            Records = candidate.State.Records.Where(r => r.Kind != "signal").Take(120).ToList() },
            candidate.Wallet, candidate.WalletChange, null);
    }
}

