namespace ForexSpire;

/// <summary>汇率精度与初始价。</summary>
public sealed record ForexPair(string Id, string Country, string Name, double Initial, int Digits)
{
    /// <summary>游戏汇率指标：保留原始初始值；上升表示外币相对人民币走强。</summary>
    public string Ticker => Id;
}

/// <summary>一笔持仓。Margin 为当前保证金（被强平/利息侵蚀），InitialMargin 为开仓时的总额。</summary>
public sealed class ForexPosition
{
    public int Id { get; set; }
    public string Pair { get; set; } = "";
    /// <summary>+1 做多，-1 做空。</summary>
    public int Dir { get; set; }
    public int Leverage { get; set; } = 1;
    public double Margin { get; set; }
    public double InitialMargin { get; set; }
    public double Notional { get; set; }
    public double Shares { get; set; }
    public double Entry { get; set; }
    public bool Warned { get; set; }
    public bool Borrowed { get; set; }
    /// <summary>开仓所在生涯日，用于限时统计。</summary>
    public int OpenedDay { get; set; }

    /// <summary>持仓权益：Margin + Dir·Shares·(price − Entry)。线性于价格，无复利。</summary>
    public double Equity(double price) => ForexMath.Equity(Margin, Dir, Shares, Entry, price);

    /// <summary>强平线：维持保证金率 10%（R4：不允许负余额，故由引擎在权益≤阈值时强平）。</summary>
    public bool IsLiquidatable(double price) =>
        ForexMath.IsLiquidatable(Margin, Dir, Shares, Entry, price);

    /// <summary>强平价（正数）。</summary>
    public double LiquidationPrice => ForexMath.LiquidationPrice(Margin, Dir, Notional, Shares);
}

/// <summary>一笔借款。</summary>
public sealed class ForexLoan
{
    public double Principal { get; set; }
    /// <summary>累计未还（含利息），复利按日。</summary>
    public double Owed { get; set; }
    public double DailyRate { get; set; }
    public int BorrowedDay { get; set; }
}

/// <summary>
/// 外汇账户：独立账本（D5）。Cash 为可用余额，TotalIn/TotalOut 记录与生涯钱包的进出，
/// 用于净盈亏统计。强平只影响外汇账户，不扣生涯钱包；未还借款仍单独记债。
/// </summary>
public sealed class ForexAccount
{
    public double Cash { get; set; }
    public double TotalIn { get; set; }
    public double TotalOut { get; set; }
    public List<ForexPosition> Positions { get; set; } = new();
    public ForexLoan? Loan { get; set; }
    public int NextPositionId { get; set; } = 1;

    public double UsedMargin
    {
        get
        {
            double s = 0;
            foreach (var p in Positions) s += p.Margin;
            return s;
        }
    }

    public double Floating(Func<string, double> priceOf)
    {
        double s = 0;
        foreach (var p in Positions) s += p.Equity(priceOf(p.Pair)) - p.Margin;
        return s;
    }

    public double Equity(Func<string, double> priceOf) => Cash + UsedMargin + Floating(priceOf);

    public double Debt => Loan?.Owed ?? 0;
}

/// <summary>
/// 全局数值参数。全部来自 FOREX_DESIGN_SPEC.md，改这里即可调平衡。
/// </summary>
public static class ForexRules
{
    // —— D8：7 条人民币直盘（德法各自独立）——
    public static readonly ForexPair[] Pairs =
    {
        new("CNY/JPY", "日本", "日元", 20.50, 4),
        new("CNY/KRW", "韩国", "韩元", 190.00, 4),
        new("CNY/DEM", "德国", "马克", 0.2550, 5),
        new("CNY/FRF", "法国", "法郎", 0.8550, 5),
        new("CNY/BRL", "巴西", "雷亚尔", 0.8200, 5),
        new("CNY/GBP", "英国", "英镑", 0.1100, 5),
        new("CNY/USD", "美国", "美元", 0.1400, 5),
    };

    /// <summary>基准货币（人民币）所属国。</summary>
    public const string BaseCountry = "中国";

    // —— D3：定价 ——
    /// <summary>日波动率。R1：0.8% 为硬上限。</summary>
    public const double DailySigma = 0.008;
    /// <summary>肥尾触发概率。</summary>
    public const double FatTailChance = 0.02;
    public const double FatTailMin = 1.5;
    public const double FatTailMax = 3.5;
    /// <summary>肥尾绝对封顶（对数收益）。</summary>
    public const double FatTailCap = 0.028;
    /// <summary>均值回归强度：−k·ln(P/P0)。</summary>
    public const double MeanReversion = 0.03;
    /// <summary>国运漂移系数（累计项）。R2：a·累计差 + b·赛季差 ≤ 0.05%/日。</summary>
    public const double DriftA = 0.0000012;
    public const double DriftB = 0.0000030;
    /// <summary>R2 硬上限：国运漂移绝对值不超过 0.05%/日。</summary>
    public const double DriftCap = 0.0005;

    // —— D7：外战信号 ——
    /// <summary>单位信号幅度。Δ = clamp(net, ±4) × 此值。</summary>
    public const double SignalUnit = 0.010;
    /// <summary>net 的封顶（信号个数）。</summary>
    public const double SignalNetCap = 4.0;
    /// <summary>晋级恒定利好。</summary>
    public const double BullAdvance = 1.0;
    /// <summary>夺冠额外利好。</summary>
    public const double BullChampion = 2.0;

    // —— D4：杠杆与强平 ——
    public static readonly int[] Leverages = { 1, 2, 3, 5, 10, 20, 50, 100 };
    public const double MaintenanceRatio = 0.10;
    /// <summary>单笔最低保证金（Credits 内部单位）。</summary>
    public const double MinMargin = 10.0;
    /// <summary>单笔最高保证金。</summary>
    public const double MaxMargin = 5000.0;

    // —— 费用 ——
    /// <summary>开仓手续费率（对名义仓位）。</summary>
    public const double OpenFeeRate = 0.00005;
    public const double OpenFeeLeverageFactor = 0.000005;

    // —— D6：借款（无持仓成本，只有借款利息）——
    public const double LoanMax = 5000.0;
    public const double LoanMin = 50.0;

    // 计算实现统一放在 ForexMath，避免两处公式漂移
    public static double OpenFee(double margin, int leverage) => ForexMath.OpenFee(margin, leverage);

    /// <summary>借款日利率分档。</summary>
    public static double LoanDailyRate(double principal) => ForexMath.LoanDailyRate(principal);

    /// <summary>R2 校验：漂移必须被钳在 DriftCap 内。</summary>
    public static double ClampDrift(double drift) => ForexMath.ClampDrift(drift, DriftCap);

    public static bool IsValidLeverage(int lev) => ForexMath.IsValidLeverage(lev);

    public static ForexPair? Pair(string id)
    {
        foreach (var p in Pairs) if (p.Id == id) return p;
        return null;
    }
}
