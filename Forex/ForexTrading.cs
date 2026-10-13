namespace ForexSpire;

/// <summary>账户操作纯逻辑；钱包和保存由宿主对候选状态一次提交。</summary>
public static class ForexTrading
{
    public static double Withdrawable(ForexState state) => Math.Max(0, Math.Min(state.Account.Cash,
        state.Account.Equity(p => state.Prices.GetValueOrDefault(p, 1)) - state.Account.UsedMargin - state.Account.Debt));

    public static string? Execute(ForexState state, int day, string action, double amount,
        string pair = "", int direction = 1, int leverage = 1, int positionId = 0)
    {
        var account = state.Account;
        if (action != "close" && (!double.IsFinite(amount) || amount <= 0 || amount > int.MaxValue))
            return "请输入有效的正数金额。";
        switch (action)
        {
            case "deposit":
                if (!double.IsFinite(account.Cash + amount)) return "金额超出账户范围。";
                account.Cash += amount; account.TotalIn += amount;
                state.Record(day, action, "从生涯钱包存入", amount); return null;
            case "withdraw":
                if (amount > Withdrawable(state)) return "超过可取金额，需保留保证金与待还借款。";
                account.Cash -= amount; account.TotalOut += amount;
                state.Record(day, action, "取回生涯钱包", amount); return null;
            case "open":
                if (ForexRules.Pair(pair) == null || !state.Prices.TryGetValue(pair, out double price) ||
                    !double.IsFinite(price) || price <= 0) return "货币对或报价无效。";
                if (direction is not (1 or -1) || !ForexMath.IsValidLeverage(leverage)) return "交易方向或杠杆无效。";
                if (amount < ForexRules.MinMargin || amount > ForexRules.MaxMargin) return "保证金须在 $100～$50,000 之间。";
                if (account.Positions.Count >= 8) return "最多同时持有 8 笔持仓。";
                if (account.NextPositionId <= 0 || account.NextPositionId == int.MaxValue) return "持仓编号超出范围，暂不能开仓。";
                double fee = ForexMath.OpenFee(amount, leverage);
                if (amount + fee > account.Cash) return "余额不足以支付保证金和手续费。";
                account.Cash -= amount + fee;
                account.Positions.Add(new()
                {
                    Id = account.NextPositionId++, Pair = pair, Dir = direction, Leverage = leverage,
                    Margin = amount, InitialMargin = amount, Notional = amount * leverage,
                    Shares = ForexMath.Shares(amount, leverage, price), Entry = price, OpenedDay = day
                });
                state.Record(day, action, pair + " " + (direction > 0 ? "做多" : "做空") + " " + leverage + "× · 开仓手续费", fee);
                return null;
            case "close":
                var position = account.Positions.FirstOrDefault(p => p.Id == positionId);
                if (position == null) return "持仓已平仓或不存在。";
                double payout = Math.Max(0, position.Equity(state.Prices.GetValueOrDefault(position.Pair, position.Entry)));
                account.Cash += payout; account.Positions.Remove(position);
                state.Record(day, action, position.Pair + " 已平仓 · 实现盈亏", payout - position.Margin); return null;
            case "borrow":
                if (account.Loan != null) return "请先还清当前借款。";
                if (amount < ForexRules.LoanMin || amount > ForexRules.LoanMax) return "借款须在 $500～$50,000 之间。";
                account.Loan = new() { Principal = amount, Owed = amount, DailyRate = ForexMath.LoanDailyRate(amount), BorrowedDay = day };
                account.Cash += amount; state.Record(day, action, "借入资金", amount); return null;
            case "repay":
                if (account.Loan == null) return "当前没有借款。";
                double pay = Math.Min(amount, Math.Min(account.Cash, account.Loan.Owed));
                if (pay <= 0) return "没有可用于还款的余额。";
                account.Cash -= pay; account.Loan.Owed -= pay;
                if (account.Loan.Owed < 0.005) account.Loan = null;
                state.Record(day, action, "偿还借款", pay); return null;
            default: return "交易操作无效。";
        }
    }
}

