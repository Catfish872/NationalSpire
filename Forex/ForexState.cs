using System.Text.Json;

namespace ForexSpire;

/// <summary>随生涯保存的外汇数据。版本独立于 CareerData.Version。</summary>
public sealed class ForexState
{
    public int ForexVersion { get; set; } = 3;
    public ForexAccount Account { get; set; } = new();
    public Dictionary<string, double> Prices { get; set; } = [];
    // 仅收盘序列，不伪装成日内 OHLC。
    public Dictionary<string, List<double>> Candles { get; set; } = [];
    public Dictionary<string, List<ForexCandle>> Bars { get; set; } = [];
    public HashSet<string> SettledFixtures { get; set; } = [];
    // 为旧旁路存档迁移保留，原生消费改按 fixture 去重。
    public Dictionary<string, int> SignalledRounds { get; set; } = [];
    public int LastDay { get; set; }
    public bool Initialized { get; set; }
    public bool LegacyImported { get; set; }
    public int LastPublishedDay { get; set; }
    public List<ForexRecord> Records { get; set; } = [];
    public const int MaxCandles = 180;
    public ForexState Copy() => JsonSerializer.Deserialize<ForexState>(JsonSerializer.Serialize(this))!;
    public void Record(int day, string kind, string text, double amount = 0)
    {
        Records.Insert(0, new() { Day = day, Kind = kind, Text = text, Amount = amount });
        if (Records.Count > 120) Records.RemoveRange(120, Records.Count - 120);
    }
}

public sealed class ForexRecord
{
    public int Day { get; set; }
    public string Kind { get; set; } = "";
    public string Text { get; set; } = "";
    public double Amount { get; set; }
}

/// <summary>一场已完赛 fixture 的事实，宿主适配层负责筛选，核心再校验。</summary>
public sealed record ForexFixture(string Key, string Competition, string Kind, int Round,
    string HomeCountry, string AwayCountry, bool HomeWon);

public sealed class ForexDay
{
    public string WorldId { get; init; } = "";
    public int Day { get; init; }
    public int Season { get; init; }
    public List<ForexFixture> Fixtures { get; init; } = [];
    public Dictionary<string, double> Drift { get; init; } = [];
}

