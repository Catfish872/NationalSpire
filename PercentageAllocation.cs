namespace NationalSpire;

/// <summary>百分比以千分单位保存调整结果；保留锁定项，本次输入在可用额度内固定，其余项目均摊差额。</summary>
public static class PercentageAllocation
{
    public static double[] Normalize(IEnumerable<double> weights)
    {
        var values = weights.ToArray();
        if (values.Length == 0) return [];
        if (values.Any(x => !double.IsFinite(x) || x < 0)) throw new ArgumentException("比例应为有效的非负数。");
        double total = values.Sum();
        var raw = values.Select(x => total > 0 ? x / total * 1000 : 1000d / values.Length).ToArray();
        var units = raw.Select(x => (int)Math.Floor(x)).ToArray();
        foreach (int i in Enumerable.Range(0, units.Length).OrderByDescending(i => raw[i] - units[i]).Take(1000 - units.Sum())) units[i]++;
        return units.Select(x => x / 10d).ToArray();
    }

    public static double[] Adjust(IReadOnlyList<double> percentages, int edited, double value, IReadOnlyList<bool>? locked = null)
    {
        if (edited < 0 || edited >= percentages.Count || !double.IsFinite(value)) throw new ArgumentException("请选择有效的比例。");
        if (locked != null && locked.Count != percentages.Count) throw new ArgumentException("锁定状态应与比例项目对应。");
        var units = Normalize(percentages).Select(x => (int)Math.Round(x * 10)).ToArray();
        var available = Enumerable.Range(0, units.Length).Where(i => i != edited && locked?[i] != true).ToArray();
        if (locked?[edited] == true || available.Length == 0) return units.Select(x => x / 10d).ToArray();
        int capacity = units[edited] + available.Sum(i => units[i]);
        units[edited] = (int)Math.Round(Math.Clamp(value, 0, capacity / 10d) * 10);
        int delta = 1000 - units.Sum();
        while (delta != 0)
        {
            int sign = Math.Sign(delta);
            var active = available.Where(i => sign > 0 ? units[i] < 1000 : units[i] > 0).ToArray();
            int amount = Math.Abs(delta), share = amount / active.Length, extra = amount % active.Length;
            for (int n = 0; n < active.Length; n++)
            {
                int i = active[n], change = Math.Min(share + (n < extra ? 1 : 0), sign > 0 ? 1000 - units[i] : units[i]);
                units[i] += sign * change; delta -= sign * change;
            }
        }
        return units.Select(x => x / 10d).ToArray();
    }
}
