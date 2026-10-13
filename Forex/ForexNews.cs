using System.Globalization;

namespace ForexSpire;

public sealed record ForexNewsMaterial(string Key, string Title, string Body);

/// <summary>只读公开行情与信号，完全不读取账户/私人交易/债务。</summary>
public static class ForexNews
{
    public static ForexNewsMaterial? Build(string worldId, ForexState market)
    {
        var signals = market.Records.Where(r => r.Day == market.LastDay && r.Kind == "signal").ToList();
        if (signals.Count == 0 || market.LastPublishedDay >= market.LastDay) return null;
        var lines = new List<string> { "收盘日：生涯第" + market.LastDay + "天。以下是已经发生的国家队赛果及汇率收盘事实。" };
        lines.AddRange(signals.Select(s => s.Text));
        lines.Add("中国为基准：净信号=该国信号减中国信号，限制在±4后乘1%。实际收盘还包含国运漂移、随机波动与均值回归，信号不等于实际涨跌幅。");
        foreach (var pair in ForexRules.Pairs)
        {
            double close = market.Prices[pair.Id];
            var history = market.Candles[pair.Id];
            double previous = history.Count >= 2 ? history[^2] : close;
            lines.Add(pair.Id + " · 收盘 " + close.ToString("F" + pair.Digits, CultureInfo.InvariantCulture) +
                " · 当日 " + ((close / previous - 1) * 100).ToString("+0.00;-0.00;0.00", CultureInfo.InvariantCulture) + "%");
        }
        lines.Add("数值上升表示人民币贬值（外币相对人民币走强），下降表示人民币升值。此材料只描述公开市场，不包含任何人的余额、借款、持仓或盈亏。不得编造未来行情或个人交易。");
        return new("forex-" + worldId + "-" + market.LastDay, "国家队赛果进入汇市 · 第" + market.LastDay + "天收盘", string.Join("\n", lines));
    }
}

