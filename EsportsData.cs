namespace NationalSpire;

public sealed class EsportsCareer
{
    public int OrganizationContentVersion { get; set; }
    public OwnedClubState? OwnedClub { get; set; }
    public List<CoachTrainingPlan> CoachTraining { get; set; } = [];
    public List<CoachLineupRequest> LineupRequests { get; set; } = [];
    public int FreeAgentVersion { get; set; }
    public int CommerceVersion { get; set; }
    public List<SponsorContract> SponsorOffers { get; set; } = [];
    public ClubOffer? PlayerContract { get; set; }
    public int ClubPaidSeason { get; set; }
    public int ClubGoalSeason { get; set; }
    public int PromotionSeason { get; set; }
    public int DonationSeason { get; set; }
    public List<string> CommercialPaidMatches { get; set; } = [];
    public List<CommercialSnapshot> CommercialHistory { get; set; } = [];
    public int EcosystemVersion { get; set; }
    public int LastDividendSeason { get; set; }
    public int LastRosterSeason { get; set; }
    public List<CircuitAward> CircuitAwards { get; set; } = [];
    public List<SponsorContract> Sponsors { get; set; } = [];
    public List<NationalLegacy> Nations { get; set; } = [];
    public bool Initialized { get; set; }
    public int License { get; set; }
    public string Country { get; set; } = "中国";
    public string ClubId { get; set; } = "";
    public bool NationalTeam { get; set; }
    public int BestClear { get; set; } = -1;
    public int WinStreak { get; set; }
    public List<CareerClub> Clubs { get; set; } = [];
    public List<WorldCompetition> Competitions { get; set; } = [];
    public List<ClubOffer> Offers { get; set; } = [];
    public List<CareerHonor> Honors { get; set; } = [];
    public List<CareerDuel> Duels { get; set; } = [];
    public List<string> Milestones { get; set; } = [];
}
public sealed class CareerClub
{
    public List<string> PreferredStarters { get; set; } = [];
    public int NextOperatingDay { get; set; }
    public int LastTransferSeason { get; set; }
    public List<FinanceEntry> Ledger { get; set; } = [];
    public string Identity { get; set; } = "";
    public int OperatingIncome { get; set; }
    public int LastOperatingSeason { get; set; }
    public int TrainingFund { get; set; }
    public string SeasonReport { get; set; } = "";
    public int Budget { get; set; }
    public string Id { get; set; } = "";
    public string Name { get; set; } = "";
    public string Country { get; set; } = "";
    public string Motto { get; set; } = "";
    public string Color { get; set; } = "70d4bc";
    public int Titles { get; set; }
}
public sealed class WorldCompetition
{
    public bool Cooperative { get; set; }
    public int PrizeVersion { get; set; }
    public int CalendarDays { get; set; } = 28;
    public int CalendarStart { get; set; }
    public bool Modern { get; set; }
    public string PlayerReplacedId { get; set; } = "";
    public bool TeamEvent { get; set; }
    public string ChampionTeam { get; set; } = "";
    public List<string> Teams { get; set; } = [];
    public Dictionary<string, List<string>> Rosters { get; set; } = [];
    public string Id { get; set; } = "";
    public string Name { get; set; } = "";
    public string Kind { get; set; } = "league";
    public string Country { get; set; } = "";
    public int Season { get; set; }
    public List<string> Entrants { get; set; } = [];
    public Dictionary<string, string> EntrantClubs { get; set; } = [];
    public Dictionary<string, string> EntrantCountries { get; set; } = [];
    public List<CareerStanding> Table { get; set; } = [];
    public List<WorldFixture> Fixtures { get; set; } = [];
    public string ChampionId { get; set; } = "";
    public bool Finished { get; set; }
    public bool PlayerEntered { get; set; }
}
public sealed class WorldFixture
{
    public List<string> HomeParticipants { get; set; } = [];
    public List<string> AwayParticipants { get; set; } = [];
    public string HomeTeam { get; set; } = "";
    public string AwayTeam { get; set; } = "";
    public int Ascension { get; set; } = 8;
    public string Id { get; set; } = "";
    public int Day { get; set; }
    public int Round { get; set; }
    public string HomeId { get; set; } = "";
    public string AwayId { get; set; } = "";
    public string WinnerId { get; set; } = "";
    public bool Draw { get; set; }
    public bool Finished { get; set; }
    public int HomeFloor { get; set; }
    public int AwayFloor { get; set; }
    public bool HomeCleared { get; set; }
    public bool AwayCleared { get; set; }
    public double? HomeSeconds { get; set; }
    public double? AwaySeconds { get; set; }
    public bool Walkover { get; set; }
}

public sealed class CircuitAward
{
    public string CompetitionId { get; set; } = "";
    public string PersonId { get; set; } = "";
    public string Country { get; set; } = "";
    public string ClubId { get; set; } = "";
    public string Event { get; set; } = "";
    public string Kind { get; set; } = "";
    public string Place { get; set; } = "";
    public int Stage { get; set; }
    public int Points { get; set; }
    public int Fortune { get; set; }
    public int Season { get; set; }
    public int Day { get; set; }
}
public sealed class SponsorContract
{
    public string Description { get; set; } = "";
    public string Plan { get; set; } = "";
    public bool Accepted { get; set; }
    public int SignedDay { get; set; }
    public int EndedDay { get; set; }
    public int FanBonus { get; set; }
    public int ExpiresDay { get; set; }
    public string Id { get; set; } = "";
    public string Brand { get; set; } = "";
    public string TargetId { get; set; } = "";
    public string Slogan { get; set; } = "";
    public int StartSeason { get; set; }
    public int EndSeason { get; set; }
    public int Retainer { get; set; }
    public int WinBonus { get; set; }
    public int PaidSeason { get; set; }
    public List<string> PaidMatches { get; set; } = [];
}
public sealed class NationalLegacy
{
    public string Country { get; set; } = "";
    public int Treasury { get; set; }
    public int Development { get; set; }
    public int Titles { get; set; }
}
public sealed class ClubOffer
{
    public int SeasonPay { get; set; }
    public int WinBonus { get; set; }
    public int FanBonus { get; set; }
    public int GoalWins { get; set; }
    public int GoalReward { get; set; }
    public string ClubId { get; set; } = "";
    public int ExpiresDay { get; set; }
    public int SigningBonus { get; set; }
}
public sealed class CommercialSnapshot
{
    public int Day { get; set; }
    public string Summary { get; set; } = "";
}
public sealed class CareerHonor
{
    public string Id { get; set; } = "";
    public string Title { get; set; } = "";
    public int Day { get; set; }
    public int Season { get; set; }
    public string Detail { get; set; } = "";
}
public sealed class CareerDuel
{
    public string PersonId { get; set; } = "";
    public int Wins { get; set; }
    public int Draws { get; set; }
    public int Losses { get; set; }
    public int LastDay { get; set; }
}
