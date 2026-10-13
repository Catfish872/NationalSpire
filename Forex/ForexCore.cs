namespace ForexSpire;

/// <summary>
/// 一场国际赛事里、某个选手打到的最深轮次。
/// </summary>
public readonly record struct RoundReach(int Round, bool Advanced, bool Champion);

/// <summary>
/// 赛事轮次快照：纯数据，不含任何宿主类型。
/// </summary>
public sealed class CompSnapshot
{
    public string Id { get; init; } = "";
    public string Name { get; init; } = "";
    public string Kind { get; init; } = "";
    /// <summary>本赛事当前已完赛的最高轮次（0 = 尚无完赛轮）。</summary>
    public int FinishedRound { get; init; }
    /// <summary>该国在本轮中产生的逐条信号（已按国汇总前的原始明细）。</summary>
    public List<CompRoundEvent> Rounds { get; init; } = new();
}

/// <summary>某赛事某轮里，各选手的结果明细。</summary>
public sealed class CompRoundEvent
{
    public int Round { get; init; }
    /// <summary>选手结果：(国家, 是否晋级, 是否夺冠)。</summary>
    public List<(string Country, bool Advanced, bool Champion)> Results { get; init; } = new();
}

/// <summary>
/// 纯状态机层：不含 Godot / NationalSpire 依赖，因此可离线全量自测。
///
/// 之所以单独抽出：宿主类型无法在 Godot 运行时之外实例化
/// （GodotSharp 的 ProjectSettings 会 P/Invoke 原生库并直接崩溃），
/// 所以任何触碰 CareerData 的逻辑都无法离线验证。把核心算法搬到这里，
/// 才能真正测到"逐轮信号"这类最容易写错的逻辑。
/// </summary>
public static class ForexCore
{
    /// <summary>出局因子的幅度：首轮 1.0，逐轮减半，最后一轮 0。</summary>
    public static double ElimMagnitude(int roundReached, int lastRound) =>
        ForexMath.ElimMagnitude(roundReached, lastRound);

    /// <summary>
    /// 汇总一批「新完赛轮次」产生的信号。
    ///
    /// 规则（D7）：
    ///   每轮晋级成功 → 该国 +1.0（恒定）
    ///   每轮出局     → 该国 −ElimMagnitude(round, lastRound)
    ///   夺冠         → 额外 +2.0
    /// 且**只有国家队赛事参与**（worldcup / worldfinal，R5）。
    /// </summary>
    public static Dictionary<string, double> Aggregate(
        IEnumerable<CompRoundEvent> newRounds, int lastRound)
    {
        var bull = new Dictionary<string, double>();

        foreach (var ev in newRounds)
        {
            foreach (var (country, advanced, champion) in ev.Results)
            {
                if (country.Length == 0) continue;

                bool isFinal = ev.Round >= lastRound;
                double delta;

                if (advanced)
                {
                    delta = ForexRules.BullAdvance + (champion ? ForexRules.BullChampion : 0.0);
                }
                else
                {
                    // 决赛告负：不利空
                    delta = isFinal ? 0.0 : -ElimMagnitude(ev.Round, lastRound);
                }

                if (delta == 0.0) continue;
                bull.TryGetValue(country, out double cur);
                bull[country] = cur + delta;
            }
        }

        return bull;
    }

    /// <summary>
    /// 净信号 → 汇率冲击（D8 基准货币结构）：
    ///   net(X) = bull(X) − bull(CN)，钳在 ±cap，再乘单位幅度。
    /// </summary>
    public static double SignalFor(
        IReadOnlyDictionary<string, double> bull, string country, string baseCountry,
        double cap, double unit)
    {
        bull.TryGetValue(country, out double x);
        bull.TryGetValue(baseCountry, out double cn);
        return ForexMath.SignalReturn(x, cn, cap, unit);
    }

    /// <summary>
    /// 单日定价。step 返回新的收盘价。
    /// </summary>
    public static double StepPrice(
        double open, double anchor, double drift, double signal,
        double sigma, double z, double shock, double meanReversion)
    {
        double delta = ForexMath.LogReturn(open, anchor, drift, signal, sigma, z, shock, meanReversion);
        double close = open * Math.Exp(delta);
        return close <= 0.0001 ? 0.0001 : close;
    }

    /// <summary>
    /// 对一组持仓跑一次强平检查（R4：不允许负余额）。
    /// 返回被强平的持仓索引（从后往前，便于安全移除）。
    /// </summary>
    public static List<int> FindLiquidations(
        IReadOnlyList<(double Margin, int Dir, double Shares, double Entry)> positions,
        Func<string, double> priceOf,
        IReadOnlyList<string> pairs)
    {
        var hits = new List<int>();
        for (int i = 0; i < positions.Count; i++)
        {
            var p = positions[i];
            double price = priceOf(pairs[i]);
            if (ForexMath.IsLiquidatable(p.Margin, p.Dir, p.Shares, p.Entry, price))
                hits.Add(i);
        }
        return hits;
    }
}
