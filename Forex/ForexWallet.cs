namespace ForexSpire;

public sealed record ForexOrder(string Action, double Amount, string Pair = "", int Direction = 1, int Leverage = 1, int PositionId = 0);
public sealed record ForexTransaction(ForexState? State, decimal Wallet, decimal WalletChange, string? Error);

/// <summary>原生与联机共用的钱包/账户候选事务，不触碰任何文件。</summary>
public static class ForexWallet
{
    public static ForexTransaction Apply(ForexState current, decimal wallet, int day, ForexOrder order)
    {
        ForexTransaction Reject(string text) => new(null, wallet, 0, text);
        if (order.Action != "close" && (!double.IsFinite(order.Amount) || order.Amount <= 0 || order.Amount > int.MaxValue))
            return Reject("请输入有效的正数金额。");
        decimal change = order.Action == "deposit" ? -(decimal)order.Amount : order.Action == "withdraw" ? (decimal)order.Amount : 0;
        decimal target = wallet + change;
        if (target < 0) return Reject("生涯钱包余额不足。");
        if (target > int.MaxValue) return Reject("生涯钱包金额超出保存范围。");
        var state = current.Copy();
        string? error = ForexTrading.Execute(state, day, order.Action, order.Amount, order.Pair, order.Direction, order.Leverage, order.PositionId);
        return error == null ? new(state, target, change, null) : Reject(error);
    }
}

