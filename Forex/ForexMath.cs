namespace ForexSpire;

/// <summary>
/// 纯数值层：零外部依赖（不引用 Godot / NationalSpire），因此可离线单测。
/// 所有引擎规则都集中在这里，改平衡只改这一处。
/// </summary>
public static class ForexMath
{
    // ================= 出局因子（D7）=================

    /// <summary>
    /// 出局因子的**幅度**（正数）：首轮 1.0，逐轮减半，最后一轮为 0。
    /// 公式：(roundReached >= lastRound) ? 0 : 0.5^(roundReached − 1)
    ///
    /// 注意返回的是幅度而非带符号信号 —— 调用方负责施加负号（见 ForexEngine.ApplyFixture）。
    /// 设计文档表格里写的 −1.0 / −0.5 是**信号**，等于 −ElimMagnitude。
    /// </summary>
    public static double ElimMagnitude(int roundReached, int lastRound)
    {
        if (roundReached >= lastRound) return 0.0;
        if (roundReached < 1) roundReached = 1;
        return Math.Pow(0.5, roundReached - 1);
    }

    /// <summary>出局**信号**（负数），便于直接使用与断言。</summary>
    public static double ElimSignal(int roundReached, int lastRound) =>
        -ElimMagnitude(roundReached, lastRound);

    /// <summary>LastRound：worldfinal = 5，worldcup = 3。</summary>
    public static int LastRoundOf(string kind) => kind switch
    {
        "worldfinal" => 5,
        "worldcup" => 3,
        "continental" => 4,
        _ => 4,
    };

    /// <summary>是否参与汇率的国际赛事（R5：continental / league 权重为 0）。</summary>
    public static bool IsInternational(string kind) =>
        kind == "worldcup" || kind == "worldfinal";

    // ================= 国运漂移（D3 / R2）=================

    /// <summary>漂移系数钳制。R2：绝对值 ≤ 0.05%/日。</summary>
    public static double ClampDrift(double drift, double cap) =>
        Math.Max(-cap, Math.Min(cap, drift));

    public static double Drift(
        double fortuneX, double fortuneCn,
        double seasonX, double seasonCn,
        double a, double b, double cap)
    {
        double raw = a * (fortuneX - fortuneCn) + b * (seasonX - seasonCn);
        return ClampDrift(raw, cap);
    }

    // ================= 信号（D8 基准货币结构）=================

    /// <summary>
    /// 净信号 = bull(X) − bull(CN)，并钳在 ±cap。
    /// 中国是基准货币，其信号对 7 条曲线都是共享的负号项。
    /// </summary>
    public static double NetSignal(double bullX, double bullCn, double cap)
    {
        double net = bullX - bullCn;
        return Math.Max(-cap, Math.Min(cap, net));
    }

    public static double SignalReturn(double bullX, double bullCn, double cap, double unit) =>
        NetSignal(bullX, bullCn, cap) * unit;

    // ================= 定价（D3）=================

    /// <summary>
    /// 单日对数收益（直接标价法，1 CNY = X 外币）：
    ///   −drift − signal + σ·z + shock − meanReversion·ln(P/P0)
    ///
    /// 【符号约定 · 修正记录】传入的 drift / signal 都是「**该外币相对人民币走强**」的度量。
    /// 外币走强 ⇒ 1 元能换到的外币变少 ⇒ P(=X) **下降**，所以这两项取**负号**。
    ///
    /// 旧写法是 `drift + signal + sigma*z + shock + revert`（正号），方向是反的：
    /// 外币走强却让 P 上涨。存档实测特征为「英国输掉 5 场（bull(GBP) = −5，net 被钳到 −4）
    /// 时 CNY/GBP 一天跌 5.5%」——贬值国的汇率反而暴跌，与直觉和直标法都相反。
    /// </summary>
    public static double LogReturn(
        double open, double anchor,
        double drift, double signal, double sigma, double z,
        double shock, double meanReversion)
    {
        double revert = -meanReversion * Math.Log(open / anchor);
        return -drift - signal + sigma * z + shock + revert;
    }

    /// <summary>肥尾冲击（对数收益）。2% 概率触发，幅度 1.5σ~3.5σ，并封顶。</summary>
    public static double FatTail(
        double triggerRoll, double magRoll, double signRoll,
        double chance, double minMult, double maxMult, double sigma, double cap)
    {
        if (triggerRoll >= chance) return 0.0;
        double mag = minMult + magRoll * (maxMult - minMult);
        double sign = signRoll < 0.5 ? -1.0 : 1.0;
        double v = sign * mag * sigma;
        return Math.Max(-cap, Math.Min(cap, v));
    }

    // ================= 保证金数学（D4）=================

    public static double Notional(double margin, int leverage) => margin * leverage;

    public static double Shares(double margin, int leverage, double price) =>
        price <= 0 ? 0 : margin * leverage / price;

    /// <summary>持仓权益：Margin + Dir·Shares·(price − Entry)。</summary>
    public static double Equity(double margin, int dir, double shares, double entry, double price) =>
        margin + dir * shares * (price - entry);

    /// <summary>维持保证金率 10%。</summary>
    public static bool IsLiquidatable(double margin, int dir, double shares, double entry, double price) =>
        Equity(margin, dir, shares, entry, price) <= margin * ForexRules.MaintenanceRatio;

    /// <summary>强平价。</summary>
    public static double LiquidationPrice(double margin, int dir, double notional, double shares)
    {
        if (shares == 0) return 0;
        return (notional - dir * (1 - ForexRules.MaintenanceRatio) * margin) / shares;
    }

    /// <summary>开仓手续费：对名义仓位，杠杆越高越贵。</summary>
    public static double OpenFee(double margin, int leverage) =>
        margin * leverage * (ForexRules.OpenFeeRate + leverage * ForexRules.OpenFeeLeverageFactor);

    /// <summary>强平距离（占开仓价的百分比）。0.9/L 的直观体现。</summary>
    public static double RiskPercent(double entry, double liqPrice) =>
        entry <= 0 ? 0 : Math.Abs(liqPrice - entry) / entry * 100.0;

    // ================= 借款（D6）=================

    public static double LoanDailyRate(double principal) =>
        principal <= 500 ? 0.0002
        : principal <= 2000 ? 0.0004
        : 0.0007;

    /// <summary>单日复利计息。</summary>
    public static double AccrueInterest(double owed, double dailyRate) =>
        Math.Round((owed + Math.Round(owed * dailyRate * 100) / 100) * 100) / 100;

    // ================= 校验 =================

    public static bool IsValidLeverage(int lev) => Array.IndexOf(ForexRules.Leverages, lev) >= 0;
}
