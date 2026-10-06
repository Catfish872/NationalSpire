namespace NationalSpire;

/// <summary>合同由玩家确认；经营支出与赛季结算各执行一次。</summary>
public static class CareerCommerce
{
    public const int Version = 1;
    private static readonly string[] Identities = ["争冠强队", "青训俱乐部", "商业俱乐部", "重建俱乐部"];
    private static readonly string[][] Brands = [
        ["篝火训练用品", "橡木装备", "远行运动", "磐石护具"],
        ["星港外设", "棱镜显示", "雷鸣键盘", "疾风竞技椅"],
        ["金羽饮品", "云帆通讯", "晨钟咖啡", "晴空影像"] ];
    public static int IdentityIndex(CareerData d, string club) => CareerEngine.StableHash(d.WorldId + ":club:" + club) % 4;
    public static int ProfessionalCount(CareerData d, string club) => IdentityIndex(d, club) switch { 0 => 7, 1 => 5, 2 => 6, _ => 4 };
    public static int YouthCount(CareerData d, string club) => IdentityIndex(d, club) switch { 0 => 2, 1 => 5, 2 => 1, _ => 3 };

    public static void ConfigureClub(CareerData d, CareerClub club, bool fresh)
    {
        if (club.Identity.Length > 0) return;
        int kind = IdentityIndex(d, club.Id), seed = CareerEngine.StableHash(d.WorldId + club.Id + ":finance");
        club.Identity = Identities[kind];
        club.OperatingIncome = (kind switch { 0 => 10000, 1 => 7500, 2 => 12000, _ => 6500 }) + seed % 151;
        if (fresh) club.Budget = (kind switch { 0 => 60000, 1 => 28000, 2 => 48000, _ => 20000 }) + seed % 6001;
        club.Motto = RegionalOrganizations.ClubDescription(d, club, kind);
    }
    public static void Upgrade(CareerData d)
    {
        if (d.Esports.CommerceVersion >= Version || d.Esports.EcosystemVersion < 1) return;
        d.Esports.CommerceVersion = Version;
        foreach (var club in d.Esports.Clubs) ConfigureClub(d, club, false);
        // 旧版自动合作转为已结束的历史，保留此前收入，重新提供自主签约机会。
        foreach (var sponsor in d.Esports.Sponsors.Where(s => s.TargetId == "player" && !s.Accepted)) sponsor.EndedDay = d.Day;
        foreach (var honor in d.Esports.Honors.Where(h => h.Id is "sponsor-local" or "sponsor-global"))
        { honor.Title = "早期参赛支持"; honor.Detail = "此前获得的参赛支持已保留。个人赞助可在商业合作中自行选择。"; }
        if (!OwnedClubs.IsOwner(d) && d.Esports.PlayerContract == null && EsportsWorld.Club(d, d.Esports.ClubId) is { } current)
        { d.Esports.PlayerContract = Quote(d, current); d.Esports.ClubPaidSeason = d.Season; }
        foreach (var offer in d.Esports.Offers)
            if (EsportsWorld.Club(d, offer.ClubId) is { } club) CopyTerms(Quote(d, club), offer);
        if (d.Esports.Sponsors.Any(s => s.TargetId == "player" && !s.Accepted))
        {
            const string correction = "此前自动安排的品牌支持已经结束，已发放奖励保留。新的个人赞助由选手确认后生效。";
            CircuitLedger.Remember(d, "commerce-transition", CareerEngine.Name(d) + "：" + correction, ["player"]);
            // 结束事件使用升级当天的日期，避免把后来的合同状态写入早期记忆。
            foreach (var post in CommunityThreads.All(d).Where(p => p.EventKey is "honor-sponsor-local" or "honor-sponsor-global"))
            {
                if (post.AiPending)
                {
                    post.AiPending = false;
                    CommunityThreads.SetWork(post.NewsGeneration, "superseded");
                    post.Title = "早期参赛支持";
                    post.Body = $"{CareerEngine.Name(d)}此前获得的参赛支持已保留。新的个人赞助由选手自行选择。";
                    post.SourceTitle = post.Title; post.SourceBody = post.Body;
                    if (!post.Replies.Any(r => r.AuthorId == "player")) post.Replies.Clear();
                    d.CommunityMemories.RemoveAll(m => m.PostId == post.Id);
                    CommunityThreads.Remember(d, post); post.Revision++;
                }
            }
        }
        RefreshOffers(d);
        Capture(d);
    }
    public static ClubOffer Quote(CareerData d, CareerClub club)
    {
        int tier = 1 + Math.Min(7, d.Esports.CircuitAwards.Count(a => a.PersonId == "player" && a.Place == "冠军" && a.Kind != "league"));
        int kind = IdentityIndex(d, club.Id);
        int signing = Math.Min(Math.Max(0, club.Budget / 5), (kind switch { 0 => 3000, 1 => 1400, 2 => 2400, _ => 1800 }) * tier);
        return new() { ClubId = club.Id, ExpiresDay = d.Day + 28, SigningBonus = signing,
            SeasonPay = (kind switch { 0 => 2400, 1 => 1200, 2 => 1800, _ => 1000 }) * tier,
            WinBonus = (kind switch { 0 => 25, 1 => 30, 2 => 15, _ => 45 }) * tier,
            FanBonus = kind == 2 ? 30 : 0, GoalWins = kind == 0 ? 4 : kind == 3 ? 2 : 3,
            GoalReward = (kind switch { 0 => 400, 1 => 330, 2 => 260, _ => 360 }) * tier };
    }
    private static void CopyTerms(ClubOffer from, ClubOffer to)
    { to.SigningBonus = from.SigningBonus; to.SeasonPay = from.SeasonPay; to.WinBonus = from.WinBonus; to.FanBonus = from.FanBonus; to.GoalWins = from.GoalWins; to.GoalReward = from.GoalReward; }
    public static string ClubTerms(ClubOffer c) => $"签约奖金 {CareerMoney.Format(c.SigningBonus)} · 每赛季报酬 {CareerMoney.Format(c.SeasonPay)} · 代表俱乐部每胜一场奖金 {CareerMoney.Format(c.WinBonus)}"
        + (c.FanBonus > 0 ? $"、关注 +{c.FanBonus}" : "") + $"\n本季代表俱乐部赢下 {c.GoalWins} 场，再奖励 {CareerMoney.Format(c.GoalReward)}。";
    public static SponsorContract? ActiveSponsor(CareerData d) => d.Esports.Sponsors.LastOrDefault(s => s.TargetId == "player" && s.Accepted && s.EndedDay == 0 && s.StartSeason <= d.Season && s.EndSeason >= d.Season);
    public static void RefreshOffers(CareerData d)
    {
        if (d.CooperativeMembers > 1) return;
        if (d.Esports.EcosystemVersion < 1) return;
        var w = d.Esports;
        foreach (var contract in w.Sponsors.Where(s => s.TargetId == "player" && s.Accepted && s.EndedDay == 0 && s.EndSeason < d.Season))
        {
            contract.EndedDay = d.Day;
            CircuitLedger.Remember(d, "expiry-" + contract.Id, $"{CareerEngine.Name(d)}与{contract.Brand}的个人赞助到期，新合同等待选手确认。", ["player"]);
        }
        w.SponsorOffers.RemoveAll(s => s.ExpiresDay < d.Day);
        if (w.License < 3 || ActiveSponsor(d) != null) { Capture(d); return; }
        if (w.SponsorOffers.Count > 0) { Capture(d); return; }
        int tier = 1 + Math.Min(7, w.CircuitAwards.Count(a => a.PersonId == "player" && a.Place == "冠军" && a.Kind != "league"));
        var previous = w.Sponsors.LastOrDefault(s => s.TargetId == "player" && s.Accepted);
        for (int plan = 0; plan < 3; plan++)
        {
            int seed = CareerEngine.StableHash(d.WorldId + ":brand:" + plan + ":" + d.Season);
            var regional = RegionalOrganizations.Sponsors(w.Country, plan);
            string brand = previous != null && (regional.Contains(previous.Brand) || Brands[plan].Contains(previous.Brand)) ? previous.Brand : regional[seed % regional.Length];
            w.SponsorOffers.Add(new() { Id = $"player-{d.Season}-{d.Day}-{plan}", TargetId = "player", Brand = brand,
                Plan = plan switch { 0 => "稳定支持", 1 => "成绩奖励", _ => "品牌推广" }, StartSeason = d.Season, EndSeason = d.Season + 1,
                ExpiresDay = d.Day + 28, Retainer = (plan switch { 0 => 320, 1 => 140, _ => 200 }) * tier,
                WinBonus = (plan switch { 0 => 20, 1 => 65, _ => 25 }) * tier, FanBonus = plan == 2 ? 35 * tier : 0,
                Description = RegionalOrganizations.SponsorDescription(brand), Slogan = RegionalOrganizations.SponsorSlogan(brand) });
        }
        CircuitLedger.Remember(d, $"sponsor-invitations-{d.Season}-{d.Day}", $"{CareerEngine.Name(d)}收到三份个人赞助邀请，等待本人选择确认。", ["player"]);
        Capture(d);
    }
    public static string SponsorTerms(SponsorContract c) => $"每赛季支持 {CareerMoney.Format(c.Retainer)} · 每场获胜奖金 {CareerMoney.Format(c.WinBonus)}"
        + (c.FanBonus > 0 ? $"、关注 +{c.FanBonus}" : "") + $" · 合作至第 {c.EndSeason} 赛季";
    public static string? AcceptSponsor(CareerData d, SponsorContract offer)
    {
        if (!d.Esports.SponsorOffers.Contains(offer) || offer.ExpiresDay < d.Day || d.Esports.License < 3) return "这份赞助邀请已经失效。";
        if (ActiveSponsor(d) != null) return "当前已有个人赞助，合同到期后可重新选择。";
        offer.Accepted = true; offer.SignedDay = d.Day; offer.PaidSeason = d.Season;
        d.Esports.Sponsors.Add(offer); d.Esports.SponsorOffers.Clear(); d.Credits += offer.Retainer;
        string fact = $"{CareerEngine.Name(d)}确认与{offer.Brand}签约。{SponsorTerms(offer)}。本季支持已经到账。";
        if (!d.Esports.Milestones.Contains("sponsor-confirmed"))
        { d.Esports.Milestones.Add("sponsor-confirmed"); d.Esports.Honors.Add(new() { Id = "sponsor-confirmed", Title = "首份个人赞助", Detail = fact, Day = d.Day, Season = d.Season }); }
        Capture(d);
        CareerLife.AddEvent(d, "sponsor-confirmed-" + offer.Id, "赞助", CareerEngine.Name(d) + "与" + offer.Brand + "达成合作", fact, ["player"], true);
        CareerMoney.Record(d, "个人赞助签约支持", offer.Retainer);
        CareerStore.Save(d); return null;
    }
    public static void SignedClub(CareerData d, ClubOffer offer)
    {
        d.Esports.PlayerContract = offer;
        // 同季转会只发签约奖金，赛季津贴每季领取一次。
        int pay = d.Esports.ClubPaidSeason < d.Season ? offer.SeasonPay : 0;
        if (pay > 0) { d.Credits += pay; d.Esports.ClubPaidSeason = d.Season; }
        CareerMoney.Record(d, "俱乐部签约与本季报酬", offer.SigningBonus + pay);
        if (EsportsWorld.Club(d, offer.ClubId) is { } club) Spend(d, club, offer.SigningBonus + pay);
        Capture(d);
    }
    public static int ClubWins(CareerData d, string club) => d.Esports.Competitions.Where(c => c.Season == d.Season && c.Kind is "league" or "continental")
        .Sum(c => c.Fixtures.Count(f => f.Finished && f.WinnerId == "player" && c.EntrantClubs.GetValueOrDefault("player") == club));
    public static void PlayerMatch(CareerData d, CareerMatch match)
    {
        if (d.Esports.EcosystemVersion < 1) return;
        RefreshOffers(d);
        if (!match.PlayerWon || d.Esports.CommercialPaidMatches.Contains(match.Id)) return;
        d.Esports.CommercialPaidMatches.Add(match.Id);
        if (d.Esports.CommercialPaidMatches.Count > 256) d.Esports.CommercialPaidMatches.RemoveAt(0);
        if (ActiveSponsor(d) is { } sponsor) { d.Credits += sponsor.WinBonus; d.Fans += sponsor.FanBonus; }
        var contract = d.Esports.PlayerContract;
        var competition = d.Esports.Competitions.FirstOrDefault(c => c.Id == match.CompetitionId);
        if (contract == null || competition == null || competition.Kind is not ("league" or "continental") || competition.EntrantClubs.GetValueOrDefault("player") != contract.ClubId) return;
        d.Credits += contract.WinBonus; d.Fans += contract.FanBonus;
        int goal = 0;
        if (d.Esports.ClubGoalSeason != d.Season && ClubWins(d, contract.ClubId) >= contract.GoalWins)
        {
            d.Esports.ClubGoalSeason = d.Season; goal = contract.GoalReward; d.Credits += goal;
            CircuitLedger.Remember(d, "club-goal-" + d.Season, $"{CareerEngine.Name(d)}完成{EsportsWorld.ClubName(d, contract.ClubId)}本季{contract.GoalWins}胜目标，获得额外奖励{CareerMoney.Format(goal)}。", ["player"]);
        }
        if (EsportsWorld.Club(d, contract.ClubId) is { } club) Spend(d, club, contract.WinBonus + goal);
    }
    public static void SeasonStart(CareerData d)
    {
        int before = d.Credits;
        RefreshOffers(d);
        if (ActiveSponsor(d) is { } sponsor && sponsor.PaidSeason < d.Season) { sponsor.PaidSeason = d.Season; d.Credits += sponsor.Retainer; }
        if (d.Esports.PlayerContract is { } contract && d.Esports.ClubPaidSeason < d.Season)
        { d.Esports.ClubPaidSeason = d.Season; d.Credits += contract.SeasonPay; if (EsportsWorld.Club(d, contract.ClubId) is { } club) Spend(d, club, contract.SeasonPay); }
        CareerMoney.Record(d, "新赛季合同与赞助收入", d.Credits - before);
        // 完结合同只保留近四季；合作事件由原有历史检索提供。
        d.Esports.Sponsors.RemoveAll(s => s.EndSeason < d.Season - 4);
        Capture(d);
    }
    public static int TrainingInvestment(int amount, int scale) => amount <= scale ? amount
        : (int)Math.Round(scale * (1 + Math.Log(amount / (double)scale)));
    public static int Develop(CareerPerson person, int investment, string seed, double pace = 1)
    {
        if (investment <= 0) return 0;
        double difficulty = 1 + Math.Max(0, person.Rating - (620 + person.MaxAscension * 95)) / 180.0;
        double baseGain = 12 * Math.Log(1 + investment / 420.0) / (difficulty * difficulty);
        double factor = person.MaxAscension >= 9 ? .025 : person.MaxAscension >= 8 ? .15 : person.MaxAscension >= 7 ? .45 : 1;
        double variation = .85 + CareerEngine.StableHash(seed + person.Id) % 10001 / 10000.0 * .3;
        double amount = person.RatingGrowthRemainder + baseGain * factor * pace * variation;
        int gain = checked((int)Math.Floor(amount));
        person.RatingGrowthRemainder = amount - gain;
        person.Rating = checked(person.Rating + gain); return gain;
    }
    public static void Operate(CareerData d) => ClubOperations.Advance(d);
    public static void Capture(CareerData d)
    {
        var sponsor = ActiveSponsor(d);
        string summary = (d.Esports.ClubId.Length == 0 ? "自由选手" : "效力" + EsportsWorld.ClubName(d, d.Esports.ClubId)) + "；"
            + (sponsor == null ? "个人赞助待签约" : $"个人赞助{ sponsor.Brand}，第{sponsor.StartSeason}至{sponsor.EndSeason}赛季，赛季支持{CareerMoney.Format(sponsor.Retainer)}、胜场奖金{CareerMoney.Format(sponsor.WinBonus)}" + (sponsor.FanBonus > 0 ? $"、胜场推广增加{sponsor.FanBonus}关注" : ""))
            + (sponsor == null && d.Esports.SponsorOffers.Count > 0 ? "；待确认邀请：" + string.Join('、', d.Esports.SponsorOffers.Take(3).Select(s => s.Brand)) : "");
        var history = d.Esports.CommercialHistory;
        if (history.LastOrDefault()?.Summary == summary) return;
        if (history.LastOrDefault()?.Day == d.Day) history.RemoveAt(history.Count - 1);
        history.Add(new() { Day = d.Day, Summary = summary });
        if (history.Count > 32) history.RemoveAt(0);
    }
    public static string PublicState(CareerData d, int day) => d.Esports.CommercialHistory.LastOrDefault(s => s.Day <= day)?.Summary ?? "该日期的合作状态暂无记录";
    private static void Spend(CareerData d, CareerClub club, int amount)
    {
        int available = Math.Max(0, club.Budget - club.TrainingFund);
        if (amount > available) club.SeasonReport += $" 股东补充{CareerMoney.Format(amount - available)}，履行选手合同。";
        if (amount > available) { club.Budget += amount - available; ClubOperations.Entry(club, d.Day, "股东补充合同资金", amount - available); }
        club.Budget -= amount;
        ClubOperations.Entry(club, d.Day, "履行选手合同", -amount);
    }
}
