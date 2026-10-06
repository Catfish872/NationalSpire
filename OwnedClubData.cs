namespace NationalSpire;

public sealed class OwnedClubState
{
    public int EconomyVersion { get; set; }
    public HashSet<string> RevenueAwards { get; set; } = [];
    public List<OwnedAchievementSponsor> AchievementSponsors { get; set; } = [];
    public string ClubId { get; set; } = "";
    public int FoundedDay { get; set; }
    public int NextPayDay { get; set; }
    public int Fans { get; set; }
    public double FanRemainder { get; set; }
    public Dictionary<string, int> HumanPayDue { get; set; } = [];
    public decimal Debt { get; set; }
    public decimal CashFlow { get; set; }
    public string ManagerId { get; set; } = "player";
    // 建队前的未开赛签表完整保留，历史赛果不参与重排。
    public WorldCompetition? PreviousLeague { get; set; }
    public List<CareerMatch> PreviousMatches { get; set; } = [];
    public string NextSponsor { get; set; } = "";
    public string NextRegion { get; set; } = "";
    public List<string> Starters { get; set; } = [];
    public List<string> Reserves { get; set; } = [];
    public List<string> Youth { get; set; } = [];
    public List<OwnedPlayerContract> Contracts { get; set; } = [];
    public List<OwnedTransfer> Transfers { get; set; } = [];
    public OwnedSponsor? Sponsor { get; set; }
    public HashSet<string> PaidResults { get; set; } = [];
    public List<FinanceEntry> Ledger { get; set; } = [];
}
public sealed class OwnedPlayerContract
{
    public string Position { get; set; } = "";
    public string PersonId { get; set; } = "";
    public string Plan { get; set; } = "steady";
    public decimal Signing { get; set; }
    public decimal Wage { get; set; }
    public decimal WinBonus { get; set; }
    public int SignedDay { get; set; }
    public int EndDay { get; set; }
    public int Days { get; set; }
    public bool GuaranteedStarter { get; set; }
}
public sealed class OwnedSponsor
{
    public string Id { get; set; } = "";
    public string Brand { get; set; } = "";
    public int Weekly { get; set; }
    public int WinBonus { get; set; }
    public int FanRate { get; set; }
    public int EndDay { get; set; }
}
// 草案只保存于界面，最终确认前不影响资金、原俱乐部或世界人物。
public sealed class ClubDraft
{
    public string Region { get; set; } = "";
    public string Name { get; set; } = "";
    public string Color { get; set; } = "69dfd3";
    public string Sponsor { get; set; } = "steady";
    public List<ClubSigning> Signings { get; set; } = [];
}
public sealed class ClubSigning
{
    public string PersonId { get; set; } = "";
    public string Plan { get; set; } = "steady";
    public string Position { get; set; } = "轮换";
    public string ReplaceId { get; set; } = "";
}

public sealed class OwnedTransfer
{
    public string SellerId { get; set; } = "";
    public string ReplaceId { get; set; } = "";
    public string Position { get; set; } = "轮换";
    public int ArrivalSeason { get; set; }
    public int Fee { get; set; }
    public bool Arrived { get; set; }
    public OwnedPlayerContract Contract { get; set; } = new();
}

public sealed class OwnedAchievementSponsor
{
    public string Title { get; set; } = "";
    public int Weekly { get; set; }
    public int StartDay { get; set; }
    public int EndDay { get; set; }
}
