namespace NationalSpire;

public sealed class CareerLifeState
{
    public decimal CreditFraction { get; set; }
    public PrivateMailbox Mailbox { get; set; } = new();
    public HashSet<string> RepairReceipts { get; set; } = [];
    public List<string> RepairNotices { get; set; } = [];
    public int Version { get; set; }
    public int OfferRound { get; set; }
    public int LastDecisionDay { get; set; }
    public int Preparation { get; set; }
    public int Facilities { get; set; }
    public Dictionary<string, FigurineState> Figurines { get; set; } = [];
    public List<string> Shop { get; set; } = [];
    public int RestockDay { get; set; }
    public int NextOfferDay { get; set; }
    public int NextProjectDay { get; set; }
    public int NextWorldEventDay { get; set; }
    public long PrizeTotal { get; set; }
    public List<LifeActivity> Activities { get; set; } = [];
    public List<LifeEvent> Events { get; set; } = [];
    public List<FinanceEntry> Ledger { get; set; } = [];
    public Dictionary<string, string> Collection { get; set; } = [];
    public Dictionary<string, int> Relationships { get; set; } = [];
    public Dictionary<string, int> LastTopics { get; set; } = [];
    public Dictionary<string, int> GrowthThisSeason { get; set; } = [];
    public int GrowthSeason { get; set; }
}

public sealed class LifeActivity
{
    public int TermsVersion { get; set; }
    public string TrainingKind { get; set; } = "";
    public List<string> TrainingTargets { get; set; } = [];
    public int TrainingStart { get; set; }
    public int TrainingEnd { get; set; }
    public int TrainingWeeksPaid { get; set; }
    public Dictionary<string, int> TrainingGained { get; set; } = [];
    public int TemporaryPoints { get; set; }
    public int WeeklyGrowthPoints { get; set; }
    public int DefensePoints { get; set; }
    public int Round { get; set; }
    public int PaidCost { get; set; } = -1;
    public string Id { get; set; } = "";
    public string Kind { get; set; } = "";
    public string Variant { get; set; } = "";
    public string Title { get; set; } = "";
    public string Detail { get; set; } = "";
    public string PersonId { get; set; } = "";
    public string ClubId { get; set; } = "";
    public string Setting { get; set; } = "";
    public int Cost { get; set; }
    public int OfferedDay { get; set; }
    public int ExpiresDay { get; set; }
    public int StartedDay { get; set; }
    public int FinishDay { get; set; }
    public int Duration { get; set; }
    public int ProgressDay { get; set; }
    public bool Public { get; set; }
    public bool LongProject { get; set; }
    public string Status { get; set; } = "可安排";
    public string Result { get; set; } = "";
}

public sealed class LifeEvent
{
    public string Id { get; set; } = "";
    public int Day { get; set; }
    public string Topic { get; set; } = "";
    public string Title { get; set; } = "";
    public string Detail { get; set; } = "";
    public List<string> People { get; set; } = [];
    public bool Important { get; set; }
    public string PostId { get; set; } = "";
    public int EditionWeek { get; set; }
}

public sealed class FinanceEntry
{
    public int Day { get; set; }
    public string Title { get; set; } = "";
    public decimal Amount { get; set; }
    public decimal Balance { get; set; }
}

/// <summary>旧档金额保留原始记账单位；所有新界面与事件统一按十美元兑换显示，避免重复迁移余额。</summary>
public static class CareerMoney
{
    public static string Format(decimal units) => "$" + (units * 10).ToString("#,0.##", System.Globalization.CultureInfo.InvariantCulture);
    public static decimal Balance(CareerData d) => d.Credits + d.Life.CreditFraction;
    public static void Add(CareerData d, decimal amount)
    {
        decimal balance = Balance(d) + amount;
        d.Credits = checked((int)decimal.Floor(balance));
        d.Life.CreditFraction = balance - d.Credits;
    }
    // 历史社区文字只调整展示，原始发言与金额记录保留。
    public static string Display(string text) => System.Text.RegularExpressions.Regex.Replace(text,
        @"(?<![\d.,$])(?<amount>\d[\d,]*(?:\.\d+)?)(?<scale>万|亿)?\s*美元", m =>
        {
            if (!decimal.TryParse(m.Groups["amount"].Value, System.Globalization.NumberStyles.Number,
                System.Globalization.CultureInfo.InvariantCulture, out var amount)) return m.Value;
            decimal scale = m.Groups["scale"].Value switch { "万" => 10000, "亿" => 100000000, _ => 1 };
            if (amount > decimal.MaxValue / scale) return m.Value;
            return "$" + (amount * scale).ToString("#,0.##", System.Globalization.CultureInfo.InvariantCulture);
        });
    public static string Historical(string text)
    {
        // 只转换有明确货币名词的旧事实；已带单位的数值以及玩家原话继续保留。
        return System.Text.RegularExpressions.Regex.Replace(text,
            @"(奖金|签约奖励|收官奖励|赛季支持|胜场奖金|运营收入|阵容支出|训练投入|转会费|国家奖励)(\s*)(\d+)(?![\d,]|\s*美元)",
            m => m.Groups[1].Value + m.Groups[2].Value + Format(long.Parse(m.Groups[3].Value)));
    }
    public static void Record(CareerData d, string title, decimal amount)
    {
        if (amount == 0) return;
        d.Life.Ledger.Add(new() { Day = d.Day, Title = title, Amount = amount, Balance = Balance(d) });
        if (d.Life.Ledger.Count > 96) d.Life.Ledger.RemoveRange(0, d.Life.Ledger.Count - 96);
    }
}
