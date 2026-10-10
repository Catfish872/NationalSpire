using System.Text.Json;

namespace NationalSpire;

/// <summary>建队与签约先校验后提交；所有经营收支进入玩家钱包。</summary>
public static class OwnedClubs
{
    public const int HumanWeeklyWage = 140, HumanWinBonus = 100;
    public const int FoundingCost = 5000, WeeklyOverhead = 80;
    public static readonly string[] Colors = ["69dfd3", "eed39b", "a997ed", "ee929d", "84b8ef"];
    public static bool IsOwner(CareerData d) => d.Esports.OwnedClub is { } own && own.ClubId == d.Esports.ClubId;
    public static string Tier(CareerPerson p) => p.MaxAscension >= 9 ? "明星选手" : p.MaxAscension >= 8 ? "职业主力" : p.MaxAscension >= 7 ? "潜力轮换" : "青训新秀";
    public static string PlanName(string plan) => plan switch { "performance" => "低薪高奖金", "growth" => "长期培养", _ => "固定薪资" };
    public static void EnsureMarket(CareerData d)
    {
        if (d.Esports.EcosystemVersion < 1) return;
        UpgradeEconomy(d);
        RepairContractRoster(d);
        foreach (var existing in d.People.Where(p => p.Id.StartsWith("free-agent-"))) InitializeRecruit(d, existing);
        d.Esports.FreeAgentVersion = 2;
        // 真实人物独立入档，不抽走现有俱乐部与历史赛事中的人。
        for (int i = 0; i < 24; i++)
        {
            string id = "free-agent-" + d.Esports.Country + "-" + i;
            if (d.People.Any(p => p.Id == id)) continue;
            int seed = CareerEngine.StableHash(d.WorldId + id), level = i < 8 ? 6 : i < 14 ? 7 : i < 21 ? 8 : 9;
            string[] chars = ["铁甲战士", "静默猎手", "故障机器人", "亡灵契约师", "储君"];
            var p = new CareerPerson { Id = id, Gender = IdentityGender.Assigned(d, id), Country = d.Esports.Country, Region = d.Esports.Country + "赛区",
                Name = WorldPeople.Name(d, id, d.Esports.Country, false), Role = level == 6 ? "青训选手" : "职业选手",
                MaxAscension = level, Rating = 680 + level * 76 + seed % 201, Character = chars[seed % 5],
                Style = WorldPeople.PlayingStyle(seed % 5, seed / 5), Biography = "自由选手，正在寻找适合自己的俱乐部。" };
            InitializeRecruit(d, p); PersonalityLibrary.Ensure(d, p); d.People.Add(p);
        }
    }
    private static void InitializeRecruit(CareerData d, CareerPerson p)
    {
        if (p.RecruitVersion >= 1) return;
        int seed = CareerEngine.StableHash(d.WorldId + p.Id);
        // 旧版漏记入档前败场，只补充这部分履历，保留已发生的比赛和胜场。
        p.Losses += 55 + seed % 96;
        p.Rating += 160;
        NpcRecords.Initialize(p, seed);
        d.WeeklyPersonBaselines.Remove(p.Id);
        p.RecruitVersion = 1;
    }
    public static bool IsRecruitable(CareerPerson p) => p.Id != "player";
    // 以有效合同和已记录席位修复旧档，不重新签约、扣款或重排历史赛事。
    public static bool RepairContractRoster(CareerData d, IEnumerable<PrivateMailbox>? mailboxes = null)
    {
        if (d.Esports.OwnedClub is not { } own) return false;
        bool changed = false;
        var boxes = mailboxes ?? new[] { d.Life.Mailbox };
        foreach (var contract in own.Contracts)
        {
            var p = CareerEngine.Person(d, contract.PersonId);
            if (p == null || Humans(d).Contains(p.Id) || p.ClubId.Length > 0 && p.ClubId != own.ClubId) continue;
            var positions = new[] { "首发", "轮换", "青训", "教练" }.Where(role => PositionList(own, role).Contains(p.Id)).ToArray();
            if (positions.Length > 1) continue;
            string position = positions.FirstOrDefault() ?? (contract.Position.Length > 0 ? contract.Position : p.ClubPosition);
            if (position.Length == 0)
                position = boxes.SelectMany(b => b.Conversations.GetValueOrDefault(p.Id)?.Offers ?? [])
                    .LastOrDefault(o => o.Kind == "contract" && o.State == "已确认" && o.Signing / 10m == contract.Signing
                        && o.Wage / 10m == contract.Wage && o.WinBonus / 10m == contract.WinBonus)?.Role ?? "";
            if (position is not ("首发" or "轮换" or "青训" or "教练")) continue;
            if (positions.Length == 0)
            {
                if (d.PendingMatchId != null || position == "首发" && own.Starters.Count >= Math.Max(3, ActiveHumans(d).Count)) continue;
                PositionList(own, position).Add(p.Id); changed = true;
            }
            if (p.ClubId != own.ClubId || p.ClubPosition != position || contract.Position != position) changed = true;
            p.ClubId = own.ClubId; p.ClubPosition = position; contract.Position = position;
        }
        return CharacterDeletion.RepairStarters(d) || changed;
    }
    public static List<CareerPerson> Candidates(CareerData d) => d.People.Where(p => p.ClubId.Length == 0
        && IsRecruitable(p) && !Humans(d).Contains(p.Id))
        .OrderByDescending(p => p.MaxAscension).ThenByDescending(p => p.Rating).ToList();
    public static OwnedPlayerContract Quote(CareerPerson p, string plan)
    {
        int tier = p.MaxAscension >= 9 ? 3 : p.MaxAscension >= 8 ? 2 : p.MaxAscension >= 7 ? 1 : 0;
        int wage = new[] { 25, 60, 140, 250 }[tier], signing = new[] { 200, 350, 600, 2500 }[tier];
        int terms = CareerEngine.StableHash(p.Id + ":contract");
        wage = (int)Math.Round(wage * (90 + terms % 21) / 100.0);
        signing = (int)Math.Round(signing * (85 + terms / 23 % 31) / 100.0);
        return new() { PersonId = p.Id, Plan = plan, Days = plan == "growth" ? 84 : 56,
            Signing = plan == "performance" ? signing * 3 / 5 : plan == "growth" ? signing / 2 : signing,
            Wage = plan == "performance" ? wage * 7 / 10 : plan == "growth" ? wage * 12 / 10 : wage,
            WinBonus = plan == "performance" ? wage : plan == "growth" ? wage / 5 : wage / 4 };
    }
    public static string? SigningError(CareerData d, ClubSigning signing, bool transfer = false)
    {
        var p = transfer ? CareerEngine.Person(d, signing.PersonId) : Candidates(d).FirstOrDefault(p => p.Id == signing.PersonId);
        if (p == null) return "这位选手已不在自由市场。";
        if (signing.Plan is not ("steady" or "performance" or "growth") || signing.Position is not ("首发" or "轮换" or "青训" or "教练")) return "合同或阵容位置无效。";
        return null;
    }
    public static OwnedSponsor SponsorQuote(CareerData d, string id) => id switch
    {
        "results" => new() { Id = id, Brand = RegionalOrganizations.Sponsor(d, d.Esports.Country, 1, "owned"), Weekly = 1100, WinBonus = 1000, FanRate = 15, EndDay = d.Day + 56 },
        "fans" => new() { Id = id, Brand = RegionalOrganizations.Sponsor(d, d.Esports.Country, 2, "owned"), Weekly = 1000, WinBonus = 300, FanRate = 4, EndDay = d.Day + 56 },
        _ => new() { Id = "steady", Brand = RegionalOrganizations.Sponsor(d, d.Esports.Country, 0, "owned"), Weekly = 1400, WinBonus = 400, FanRate = 10, EndDay = d.Day + 56 }
    };
    public static int SponsorWeekly(OwnedSponsor? s, int fans) => s == null ? 0 : s.Weekly + (int)(250 * Math.Log(1 + Math.Max(0, fans) / (1000.0 * Math.Max(1, s.FanRate))));
    public static int AudienceIncome(int fans) => 100 + (int)(150 * Math.Log(1 + Math.Max(0, fans) / 7500.0));
    public static decimal InitialCost(CareerData d, ClubDraft draft) => FoundingCost + draft.Signings.Sum(s =>
        CareerEngine.Person(d, s.PersonId) is { } p ? Quote(p, s.Plan).Signing : 0);
    public static decimal WeeklyWages(CareerData d, ClubDraft draft) => HumanWages(d) + draft.Signings.Sum(s => CareerEngine.Person(d, s.PersonId) is { } p ? Quote(p, s.Plan).Wage : 0);
    public static List<string> PaidHumans(CareerData d) => Humans(d).Where(id => id != (d.Esports.OwnedClub?.ManagerId is { } manager && d.HumanIds.Contains(manager) ? manager : Humans(d)[0])).ToList();
    public static int HumanWages(CareerData d) => PaidHumans(d).Count * HumanWeeklyWage;
    public static void AccrueHumanPay(CareerData d, int amount)
    {
        foreach (string id in PaidHumans(d))
            d.Esports.OwnedClub!.HumanPayDue[id] = checked(d.Esports.OwnedClub.HumanPayDue.GetValueOrDefault(id) + amount);
    }
    public static int GrantFans(OwnedClubState o, int baseGain)
    {
        if (baseGain <= 0) return 0;
        // 前一万关注保持初期速度，之后逐渐放缓；不足一人的部分留到下一次。
        double scale = 1 + Math.Max(0, o.Fans - 10000) / 20000.0;
        double gain = baseGain / (scale * scale) + o.FanRemainder;
        int added = Math.Min(int.MaxValue - o.Fans, (int)gain);
        o.FanRemainder = gain - added;
        o.Fans += added; return added;
    }
    public static int StartingFans(CareerData d) => Math.Max(300, Math.Min(5000, d.Fans / 3));
    public static void UpgradeEconomy(CareerData d)
    {
        if (d.Esports.OwnedClub is not { EconomyVersion: < 1 } o) return;
        if (o.Sponsor is { } old)
        {
            var updated = SponsorQuote(d, old.Id);
            old.Weekly = Math.Max(old.Weekly, updated.Weekly); old.WinBonus = Math.Max(old.WinBonus, updated.WinBonus);
            old.FanRate = updated.FanRate;
        }
        o.Fans = Math.Max(300, o.Fans); o.EconomyVersion = 1;
    }
    public static int AchievementWeekly(CareerData d, int? day = null) => d.Esports.OwnedClub?.AchievementSponsors
        .Where(s => day.HasValue ? s.StartDay < day.Value && s.EndDay >= day.Value : s.StartDay <= d.Day && s.EndDay > d.Day).Select(s => s.Weekly).DefaultIfEmpty().Max() ?? 0;
    public static (int Fans, int Weekly) PlacementReward(string kind, int rank)
    {
        var reward = rank switch { 1 => (3000, 1000), 2 => (2000, 700), 3 => (1200, 400), 4 => (800, 300), _ => (500, 200) };
        return kind == "continental" ? (reward.Item1 * 2, reward.Item2 * 2) : reward;
    }
    private static void AwardCommercial(CareerData d, string key, string title, int fans, int weekly)
    {
        var o = d.Esports.OwnedClub!;
        if (!o.RevenueAwards.Add(key)) return;
        fans = GrantFans(o, fans);
        o.AchievementSponsors.Add(new() { Title = title, Weekly = weekly, StartDay = d.Day, EndDay = d.Day + 56 });
        Pay(d, title + "赞助签约奖励", weekly * 2);
        Report(d, "赞助", title + "带来新赞助", $"关注增加{fans}，签约奖励{CareerMoney.Format(weekly * 2)}，未来八周成绩赞助每周{CareerMoney.Format(weekly)}。同类成绩赞助按最高档支付。", []);
    }
    public static void SettleAchievements(CareerData d)
    {
        if (!IsOwner(d)) return;
        var o = d.Esports.OwnedClub!;
        foreach (var c in d.Esports.Competitions.Where(c => c.TeamEvent && c.Kind is "league" or "continental" && c.Teams.Contains(o.ClubId)))
        {
            var ties = c.Fixtures.Where(f => f.HomeTeam == o.ClubId || f.AwayTeam == o.ClubId)
                .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)).OrderBy(g => g.Min(f => f.Day)).ThenBy(g => g.Key.Round).ToList();
            if (c.Kind == "league")
            {
                int streak = 0;
                foreach (var tie in ties)
                {
                    if (tie.Count() != (c.Cooperative ? 1 : 3) || tie.Any(f => !f.Finished)) break;
                    if (tie.Any(f => f.Walkover)) continue;
                    bool home = tie.Key.HomeTeam == o.ClubId;
                    bool won = tie.Count(f => f.WinnerId == (home ? f.HomeId : f.AwayId)) >= (c.Cooperative ? 1 : 2);
                    streak = won ? streak + 1 : 0;
                    if (streak == 3) AwardCommercial(d, c.Id + ":streak3", "联赛三连胜", 600, 300);
                    if (streak == 5) AwardCommercial(d, c.Id + ":streak5", "联赛五连胜", 1200, 600);
                }
            }
            if (!c.Finished || ties.Count == 0 || ties.Any(g => g.Any(f => !f.Finished))) continue;
            int rank = c.Kind == "league" ? CircuitWorld.TeamTable(c).FindIndex(t => t.PersonId == o.ClubId) + 1
                : c.ChampionTeam == o.ClubId ? 1 : 1 << (CircuitWorld.RoundCount(c) - ties.Max(g => g.Key.Round) + 1);
            if (rank < 1) continue;
            var reward = PlacementReward(c.Kind, rank);
            AwardCommercial(d, c.Id + ":placement", c.Name + (rank == 1 ? "冠军" : rank == 2 ? "亚军" : c.Kind == "league" ? $"第{rank}名" : $"{rank}强"), reward.Fans, reward.Weekly);
        }
    }
    public static int FirstLeagueDay(CareerData d) => d.Esports.Competitions.Where(c => c.Season == d.Season && c.Kind == "league" && c.Modern)
        .SelectMany(c => c.Fixtures).Select(f => f.Day).DefaultIfEmpty(SeasonCalendar.Start(d) + 22).Min();
    public static bool CanJoinThisSeason(CareerData d) => d.Day < FirstLeagueDay(d)
        && d.Esports.Competitions.Where(c => c.Season == d.Season && c.Kind == "league").All(c => c.Fixtures.All(f => !f.Finished));
    public static List<string> Humans(CareerData d) => d.HumanIds.Count > 0 ? d.HumanIds.ToList() : ["player"];
    public static List<string> ActiveHumans(CareerData d) => d.MatchHumanIds.Count > 0 ? d.MatchHumanIds.ToList() : Humans(d);
    public static int RequiredAiStarters(CareerData d) => Math.Max(0, 3 - (ClubCoaching.PlayerReserve(d) ? 0 : ActiveHumans(d).Count));
    public static string EntryText(CareerData d) => $"本季第 {SeasonCalendar.Day(d, FirstLeagueDay(d))} 天联赛开赛前可创建";
    public static string? CreationError(CareerData d, ClubDraft draft)
    {
        if (!CanJoinThisSeason(d)) return "本季联赛已开始，请在下赛季首场联赛前创建。";
        if (IsOwner(d)) return "你已经拥有一家俱乐部。";
        if (!EsportsWorld.Countries.Contains(draft.Region.Length == 0 ? d.Esports.Country : draft.Region)) return "请选择参赛地区。";
        if (d.Esports.EcosystemVersion < 1) return "请先载入完整生涯。";
        if (d.PendingMatchId != null) return "请先完成当前比赛。";
        if (string.IsNullOrWhiteSpace(draft.Name) || draft.Name.Trim().Length > 20 || draft.Name.Any(char.IsControl)) return "俱乐部名称须为 1—20 个字符。";
        if (d.Esports.Clubs.Any(c => c.Name == draft.Name.Trim())) return "已经有同名俱乐部。";
        if (!Colors.Contains(draft.Color) || draft.Sponsor is not ("steady" or "results" or "fans")) return "请选择队徽颜色和赞助方案。";
        if (draft.Signings.Select(s => s.PersonId).Distinct().Count() != draft.Signings.Count) return "同一位选手不能重复签约。";
        foreach (var s in draft.Signings) if (SigningError(d, s) is { } error) return error;
        int selected = draft.Signings.Count(s => s.Position == "首发"), required = RequiredAiStarters(d);
        if (selected > required) return $"首发已超出 {selected - required} 人，请调整为轮换或移除。";
        var missing = new List<string>();
        if (selected < required) missing.Add($"{required - selected} 名首发");
        int reserves = draft.Signings.Count(s => s.Position == "轮换");
        if (reserves < 3) missing.Add($"{3 - reserves} 名轮换");
        if (missing.Count > 0) return "还缺 " + string.Join("、", missing) + "。";
        decimal cost = InitialCost(d, draft);
        if (d.Credits < cost) return "资金不足，还差 " + CareerMoney.Format(cost - d.Credits) + "。";
        return null;
    }
    public static string? Create(CareerData d, ClubDraft draft)
    {
        if (CreationError(d, draft) is { } error) return error;
        // 所有校验和签表计算先在副本完成，提交前不改变当前生涯。
        var copy = JsonSerializer.Deserialize<CareerData>(JsonSerializer.Serialize(d))!;
        copy.LocalHumanId = d.LocalHumanId;
        copy.ExternalSave = _ => { };
        CreateCore(copy, draft);
        var original = (d.Esports, d.People, d.Matches, d.Standings, d.Life, d.CommunityMemories, d.Credits);
        try
        {
            d.Esports = copy.Esports; d.People = copy.People; d.Matches = copy.Matches; d.Standings = copy.Standings;
            d.Life = copy.Life; d.CommunityMemories = copy.CommunityMemories; d.Credits = copy.Credits;
            CareerStore.Save(d);
        }
        catch
        {
            (d.Esports, d.People, d.Matches, d.Standings, d.Life, d.CommunityMemories, d.Credits) = original;
            throw;
        }
        return null;
    }
    private static void CreateCore(CareerData d, ClubDraft draft)
    {
        string previousRegion = EsportsWorld.PlayerLeague(d)?.Country ?? d.Esports.Country;
        string region = draft.Region.Length == 0 ? d.Esports.Country : draft.Region;
        CircuitWorld.LeavePreseason(d);
        string id = "owned-" + d.WorldId;
        var own = new OwnedClubState { ClubId = id, FoundedDay = d.Day, NextPayDay = d.Day + 7, Fans = StartingFans(d), EconomyVersion = 1,
            Starters = ActiveHumans(d), Reserves = Humans(d).Except(ActiveHumans(d)).ToList(), ManagerId = d.LocalHumanId.Length > 0 ? d.LocalHumanId : "player", Sponsor = SponsorQuote(d, draft.Sponsor) };
        d.Esports.OwnedClub = own;
        d.Esports.Clubs.Add(new() { Id = id, Name = draft.Name.Trim(), Color = draft.Color, Country = region,
            Identity = "自建俱乐部", Motto = "从自己的队伍开始，向下一座冠军出发" });
        d.Esports.ClubId = id; d.Esports.License = Math.Max(3, d.Esports.License);
        EsportsWorld.ClearInvalidRegistrations(d);
        d.Esports.PlayerContract = null; d.Esports.Offers.Clear();
        Pay(d, "俱乐部注册与场地筹备", -FoundingCost);
        foreach (var s in draft.Signings) SignUnchecked(d, s);
        foreach (var person in d.People.Where(p => d.HumanIds.Contains(p.Id))) person.ClubId = id;
        OwnedClubSchedule.Join(d, previousRegion);
        CareerLife.AddEvent(d, "club-founded-" + id, "俱乐部", draft.Name.Trim() + "成立", CareerEngine.Name(d) + "组建了" + draft.Name.Trim()
            + "，签下" + string.Join("、", own.Contracts.Select(c => CareerEngine.DisplayName(d, c.PersonId))) + "。" + "新阵容将参加本季联赛。", [..Humans(d), ..own.Contracts.Select(c => c.PersonId)], true);
    }
    private static void SignUnchecked(CareerData d, ClubSigning signing, OwnedPlayerContract? negotiated = null)
    {
        var own = d.Esports.OwnedClub!; var p = CareerEngine.Person(d, signing.PersonId)!;
        var contract = negotiated ?? Quote(p, signing.Plan); contract.SignedDay = d.Day; contract.EndDay = d.Day + contract.Days;
        contract.Position = signing.Position;
        own.Contracts.Add(contract); p.ClubId = own.ClubId;
        UpdateRosterRole(p, signing.Position);
        PositionList(own, signing.Position).Add(p.Id);
        Pay(d, p.PublicName + "签约费", -contract.Signing);
    }
    public static List<string> PositionList(OwnedClubState own, string position) => position == "首发" ? own.Starters : position == "轮换" ? own.Reserves : position == "教练" ? own.Coaches : own.Youth;
    internal static void UpdateRosterRole(CareerPerson p, string position)
    {
        p.ClubPosition = position;
        // 自定义职业是角色资料；阵容席位单独记录，签约和换位不覆盖自定义名称。
        if (p.EditedCard || position == "教练") return;
        p.Role = position == "青训" ? "青训选手" : p.MaxAscension >= 9 ? "世界顶尖" : "职业选手";
    }
    public static string Position(OwnedClubState own, string id) => own.Starters.Contains(id) ? "首发" : own.Reserves.Contains(id) ? "轮换" : own.Coaches.Contains(id) ? "教练" : "青训";
    public static string? RecruitError(CareerData d, ClubSigning signing, OwnedPlayerContract? negotiated = null)
    {
        if (!IsOwner(d)) return "请先组建俱乐部。";
        if (d.PendingMatchId != null) return "请先结束当前比赛。";
        if (signing.Position == "首发" && StarterReplacementError(d, signing.ReplaceId) is { } replacementError) return replacementError;
        if (ReservedStarter(d, signing.ReplaceId)) return "这位首发已约定下赛季被转会选手接替。";
        if (SigningError(d, signing) is { } error) return error;
        if (CareerMoney.Balance(d) < (negotiated ?? Quote(CareerEngine.Person(d, signing.PersonId)!, signing.Plan)).Signing) return "签约资金不足。";
        return null;
    }
    public static string? Recruit(CareerData d, ClubSigning signing, OwnedPlayerContract? negotiated = null)
    {
        if (RecruitError(d, signing, negotiated) is { } error) return error;
        var o = d.Esports.OwnedClub!;
        if (signing.Position == "首发" && signing.ReplaceId.Length > 0) { o.Starters.Remove(signing.ReplaceId); o.Reserves.Add(signing.ReplaceId); UpdateRosterRole(CareerEngine.Person(d, signing.ReplaceId)!, "轮换"); }
        SignUnchecked(d, signing, negotiated);
        if (signing.Position != "教练") OwnedClubSchedule.UpdateLineup(d);
        Report(d, "签约", CareerEngine.DisplayName(d, signing.PersonId) + "加盟", "签订" + PlanName(signing.Plan) + "合同，进入" + signing.Position + "阵容。", [signing.PersonId]);
        CareerStore.Save(d); return null;
    }
    public static string? Swap(CareerData d, string first, string second)
    {
        if (!IsOwner(d) || d.PendingMatchId != null) return "比赛进行中，暂时不能调整阵容。";
        CharacterDeletion.RepairStarters(d);
        if (CharacterDeletion.DeletedStarterVacancy(d)) return CharacterDeletion.MissingStarter;
        var o = d.Esports.OwnedClub!;
        if (Humans(d).Contains(first) || Humans(d).Contains(second) || first == second || !o.Contracts.Any(c => c.PersonId == first) || !o.Contracts.Any(c => c.PersonId == second)) return "请选择两名不同的签约选手。";
        if (ReservedStarter(d, first) || ReservedStarter(d, second)) return "该首发席位已有下赛季转会约定，暂不能交换。";
        string a = Position(o, first), b = Position(o, second);
        if (a == "教练" || b == "教练") return "教练岗位请使用转任调整。";
        if (a == b) return "这两名选手的位置相同。";
        if ((b != "首发" && o.Contracts.Any(c => c.PersonId == first && c.GuaranteedStarter)) || (a != "首发" && o.Contracts.Any(c => c.PersonId == second && c.GuaranteedStarter))) return "明星合同约定首发席位。";
        PositionList(o, a).Remove(first); PositionList(o, b).Remove(second); PositionList(o, a).Add(second); PositionList(o, b).Add(first);
        o.Contracts.Single(c => c.PersonId == first).Position = b;
        o.Contracts.Single(c => c.PersonId == second).Position = a;
        foreach (string id in new[] { first, second }) UpdateRosterRole(CareerEngine.Person(d, id)!, Position(o, id));
        OwnedClubSchedule.UpdateLineup(d); CareerStore.Save(d); return null;
    }
    public static string? Release(CareerData d, string id, string replacement = "")
    {
        if (!IsOwner(d) || d.PendingMatchId != null) return "请先完成当前比赛。";
        var o = d.Esports.OwnedClub!; var c = o.Contracts.FirstOrDefault(c => c.PersonId == id);
        if (c == null) return "合同不存在。";
        if (ReservedStarter(d, id)) return "该首发已约定下赛季被转会选手接替，届时可解约。";
        bool starter = o.Starters.Contains(id);
        bool needsReplacement = starter && o.Starters.Count <= Math.Max(3, ActiveHumans(d).Count);
        if (needsReplacement && (!o.Reserves.Contains(replacement) || o.Reserves.Count <= 3)) return "请先补充一名轮换，再选择接替首发的选手。";
        if (!starter && o.Reserves.Contains(id) && o.Reserves.Count <= 3) return "请保留至少三名轮换。";
        decimal fee = ExitFee(d, c);
        if (CareerMoney.Balance(d) < fee) return "解约费用不足。";
        Pay(d, CareerEngine.DisplayName(d, id) + "解约补偿", -fee);
        if (starter) { o.Starters.Remove(id); if (needsReplacement) { o.Reserves.Remove(replacement); o.Starters.Add(replacement); UpdateRosterRole(CareerEngine.Person(d, replacement)!, "首发"); } }
        o.Contracts.Remove(c); o.Reserves.Remove(id); o.Youth.Remove(id); o.Coaches.Remove(id); o.CoachAppointments.RemoveAll(a => a.PersonId == id); ClubCoaching.StopTraining(d, id); CareerEngine.Person(d, id)!.ClubId = ""; CareerEngine.Person(d, id)!.ClubPosition = "";
        OwnedClubSchedule.UpdateLineup(d);
        CareerTraining.InvalidateForecast(d);
        Report(d, "转会", CareerEngine.DisplayName(d, id) + "离队", "双方结束球员合同，选手重新进入自由市场。", [id]);
        CareerStore.Save(d); return null;
    }
    public static string? Assign(CareerData d, string id, string position)
    {
        if (!IsOwner(d) || d.PendingMatchId != null) return "请先完成当前比赛。";
        var o = d.Esports.OwnedClub!;
        bool wasCoach = o.Coaches.Contains(id);
        if (!o.Contracts.Any(c => c.PersonId == id) || position is not ("轮换" or "青训") || o.Starters.Contains(id)) return "首发调整请使用交换阵容。";
        if (position == "青训" && o.Reserves.Contains(id) && o.Reserves.Count <= 3) return "请保留三名轮换。";
        o.Coaches.Remove(id); o.Reserves.Remove(id); o.Youth.Remove(id); PositionList(o, position).Add(id);
        o.Contracts.Single(c => c.PersonId == id).Position = position;
        UpdateRosterRole(CareerEngine.Person(d, id)!, position);
        if (wasCoach) { ClubCoaching.StopTraining(d, id); CareerTraining.InvalidateForecast(d); }
        CareerStore.Save(d); return null;
    }
    public static decimal ExitFee(CareerData d, OwnedPlayerContract c) => Math.Min(4, Math.Max(0, (c.EndDay - d.Day + 6) / 7)) * c.Wage;
    public static bool TransferReserved(CareerData d, string id) => d.Esports.OwnedClub?.Transfers.Any(t => !t.Arrived && t.Contract.PersonId == id) == true;
    public static bool ReservedStarter(CareerData d, string id) => id.Length > 0 && d.Esports.OwnedClub?.Transfers.Any(t => !t.Arrived && t.ReplaceId == id) == true;
    public static List<string> ReplaceableStarters(CareerData d) => d.Esports.OwnedClub!.Starters.Where(id => !Humans(d).Contains(id)
        && !d.Esports.OwnedClub.Contracts.Any(c => c.PersonId == id && c.GuaranteedStarter) && !ReservedStarter(d, id)).ToList();
    public static string? StarterReplacementError(CareerData d, string replacement)
    {
        if (!IsOwner(d)) return "请先组建俱乐部。";
        var available = ReplaceableStarters(d);
        if (available.Contains(replacement)) return null;
        if (available.Count > 0) return "请选择转入轮换的现役首发，新选手将接替其席位。";
        var own = d.Esports.OwnedClub!;
        var reasons = new List<string>();
        if (own.Starters.Any(id => Humans(d).Contains(id))) reasons.Add("真人固定首发");
        if (own.Starters.Any(id => !Humans(d).Contains(id) && own.Contracts.Any(c => c.PersonId == id && c.GuaranteedStarter))) reasons.Add("现役选手有首发保障合同");
        if (own.Starters.Any(id => ReservedStarter(d, id))) reasons.Add("席位已预约给下赛季加盟选手");
        return "暂无可替换的首发" + (reasons.Count > 0 ? "：" + string.Join("；", reasons) : "") + "。";
    }
    public static int TransferFee(CareerPerson p) => (int)(Quote(p, "steady").Signing * 3 + Quote(p, "steady").Wage * 4);
    public static string? TransferError(CareerData d, ClubSigning signing, OwnedPlayerContract? negotiated = null)
    {
        if (!IsOwner(d)) return "请先组建俱乐部。";
        if (d.PendingMatchId != null) return "请先完成当前比赛。";
        var p = CareerEngine.Person(d, signing.PersonId);
        if (p == null || Humans(d).Contains(p.Id) || p.ClubId.Length == 0 || p.ClubId == d.Esports.ClubId
            || !IsRecruitable(p)) return "这位选手不接受转会洽谈。";
        if (TransferReserved(d, p.Id)) return "已经签订下赛季加盟合同。";
        if (SigningError(d, signing, true) is { } error) return error;
        if (signing.Position == "首发" && StarterReplacementError(d, signing.ReplaceId) is { } replacementError) return replacementError;
        if (CareerMoney.Balance(d) < TransferFee(p) + (negotiated ?? Quote(p, signing.Plan)).Signing) return "转会与签约资金不足。";
        return null;
    }
    public static string? ArrangeTransfer(CareerData d, ClubSigning signing, OwnedPlayerContract? negotiated = null)
    {
        if (TransferError(d, signing, negotiated) is { } error) return error;
        var p = CareerEngine.Person(d, signing.PersonId)!;
        var contract = negotiated ?? Quote(p, signing.Plan);
        contract.Position = signing.Position;
        int fee = TransferFee(p);
        d.Esports.OwnedClub!.Transfers.Add(new() { SellerId = p.ClubId, ArrivalSeason = d.Season + 1, Position = signing.Position, ReplaceId = signing.Position == "首发" ? signing.ReplaceId : "", Fee = fee, Contract = contract });
        Pay(d, p.PublicName + "转会与签约", -fee - contract.Signing);
        if (EsportsWorld.Club(d, p.ClubId) is { } seller) seller.Budget += fee;
        Report(d, "转会", p.PublicName + "将在下赛季加盟", $"与{EsportsWorld.ClubName(d, p.ClubId)}达成协议，转会费{CareerMoney.Format(fee)}，进入{signing.Position}阵容。本赛季继续代表原俱乐部出战。", [p.Id]);
        CareerStore.Save(d); return null;
    }
    // 新赛季生成签表前执行，合同金额沿用签字时的报价，避免重复收取预付款。
    public static void ArriveTransfers(CareerData d)
    {
        if (!IsOwner(d)) return;
        var o = d.Esports.OwnedClub!;
        foreach (var transfer in o.Transfers.Where(t => !t.Arrived && t.ArrivalSeason <= d.Season))
        {
            var c = transfer.Contract; var p = CareerEngine.Person(d, c.PersonId)!;
            var mailbox = transfer.SourceHumanId.Length == 0 ? d.Life.Mailbox : d.PrivateMemorySources.GetValueOrDefault(transfer.SourceHumanId);
            var turn = mailbox?.Conversations.GetValueOrDefault(p.Id)?.Turns.FirstOrDefault(t => t.Id == transfer.SourceTurnId);
            var originalMailbox = d.Life.Mailbox; string originalHuman = d.LocalHumanId;
            // 加盟仍属于原合同交互，使用来源轮次保存撤回记录，不通过金额猜测关联。
            System.Text.Json.Nodes.JsonObject? before = null;
            if (turn != null)
            {
                d.Life.Mailbox = mailbox!; d.LocalHumanId = transfer.SourceHumanId;
            }
            try
            {
                if (turn != null) before = PrivateInteractionHistory.Capture(d, p.Id, true);
                c.SignedDay = d.Day; c.EndDay = d.Day + c.Days;
                if (transfer.Position == "首发")
                {
                    o.Starters.Remove(transfer.ReplaceId); o.Reserves.Add(transfer.ReplaceId); UpdateRosterRole(CareerEngine.Person(d, transfer.ReplaceId)!, "轮换");
                }
                c.Position = transfer.Position;
                o.Contracts.Add(c); PositionList(o, transfer.Position).Add(p.Id);
                p.ClubId = o.ClubId; UpdateRosterRole(p, transfer.Position);
                transfer.Arrived = true;
                Report(d, "转会", p.PublicName + "正式报到", $"新赛季合同生效，进入{transfer.Position}阵容。", [p.Id]);
                if (turn != null) PrivateInteractionHistory.Record(d, p.Id, turn, before!, true);
            }
            finally { d.Life.Mailbox = originalMailbox; d.LocalHumanId = originalHuman; }
        }
    }
    public static void Pay(CareerData d, string title, decimal amount)
    {
        var o = d.Esports.OwnedClub!;
        CareerMoney.Add(d, amount); o.CashFlow += amount; CareerMoney.Record(d, title, amount);
        o.Ledger.Add(new() { Day = d.Day, Title = title, Amount = amount, Balance = CareerMoney.Balance(d) });
        if (o.Ledger.Count > 96) o.Ledger.RemoveAt(0);
    }
    public static double PracticeBonus(CareerData d, string person, int asc, int? day = null)
    {
        if (!IsOwner(d) || d.Esports.OwnedClub is not { } o || !o.Starters.Contains(person) || Humans(d).Contains(person) || o.Debt > 0) return 0;
        return (GroupPractice(d, o.Reserves, asc, day) + GroupPractice(d, o.Youth, asc, day)) * ClubCoaching.Factor(d);
    }
    public static double PracticeContribution(CareerData d, CareerPerson p, int asc, int? day = null)
    {
        // 同一生涯固定个人差异，刷新、读档与多人视角不会重新取值。
        string world = d.AvatarWorldId.Length > 0 ? d.AvatarWorldId : d.WorldId;
        double variation = CareerEngine.StableHash(world + ":club-practice:" + p.Id) % 10001 / 10000.0;
        // 陪练自身的培养和状态影响贡献；不再计入他人的陪练贡献，避免递归反馈。
        double chance = MatchRules.Evaluate(d, p, asc, day, includePractice: false).Final;
        double ability = chance / (.5 + chance);
        return (.007 + .001 * ability + .002 * variation) * .95;
    }
    public static double GroupPractice(CareerData d, IEnumerable<string> ids, int asc, int? day = null)
    {
        var members = ids.Distinct().Where(id => !Humans(d).Contains(id)).Select(id => d.People.FirstOrDefault(p => p.Id == id)).Where(p => p != null && !ClubCoaching.IsCoach(p)).ToList();
        // 各组前三人全额计入；之后按1/(n·(1+ln n))递减，继续增加但没有固定封顶值。
        return members.Select(p => PracticeContribution(d, p!, asc, day)).OrderByDescending(value => value)
            .Select((value, index) => index < 3 ? value : value / ((index - 1) * (1 + Math.Log(index - 1)))).Sum();
    }
    public static int? BreakEvenFans(OwnedSponsor? sponsor, decimal weeklyCost)
    {
        int low = 0, high = 10000;
        while (SponsorWeekly(sponsor, high) + AudienceIncome(high) < weeklyCost)
        {
            if (high == int.MaxValue) return null;
            high = (int)Math.Min(int.MaxValue, (long)high * 2);
        }
        while (low < high) { int mid = low + (high - low) / 2; if (SponsorWeekly(sponsor, mid) + AudienceIncome(mid) >= weeklyCost) high = mid; else low = mid + 1; }
        return low;
    }
    public static string? ChangeSponsor(CareerData d, string id)
    {
        if (!IsOwner(d) || id is not ("steady" or "results" or "fans")) return "赞助方案无效。";
        var o = d.Esports.OwnedClub!;
        if (o.Sponsor is { } old && d.Day < old.EndDay) o.NextSponsor = id;
        else o.Sponsor = SponsorQuote(d, id);
        Report(d, "赞助", "俱乐部确认赞助合作", SponsorQuote(d, id).Brand + "将在当前合约结束后接续合作。", []); CareerStore.Save(d); return null;
    }
    public static void Advance(CareerData d)
    {
        if (!IsOwner(d)) return;
        var o = d.Esports.OwnedClub!;
        SettleResults(d);
        while (d.Day >= o.NextPayDay)
        {
            int date = o.NextPayDay; o.NextPayDay += 7;
            if (o.Sponsor is { } previous && previous.EndDay <= date && o.NextSponsor.Length > 0)
            { o.Sponsor = SponsorQuote(d, o.NextSponsor); o.NextSponsor = ""; }
            if (o.Sponsor is { } s)
            {
                // 默认续约写入签约条件，不重新领取一次性奖金。
                while (s.EndDay < date) s.EndDay += 56;
                Pay(d, "俱乐部赞助周结 · " + s.Brand, SponsorWeekly(s, o.Fans));
            }
            int achievement = AchievementWeekly(d, date);
            if (achievement > 0) Pay(d, "俱乐部成绩赞助周结", achievement);
            Pay(d, "俱乐部会员与周边收入", AudienceIncome(o.Fans));
            AccrueHumanPay(d, HumanWeeklyWage);
            decimal bill = WeeklyOverhead + o.Contracts.Sum(c => c.Wage) + o.Debt;
            decimal paid = Math.Min(Math.Max(0, CareerMoney.Balance(d)), bill); o.Debt = bill - paid;
            Pay(d, "俱乐部周薪与运营" + (o.Debt > 0 ? "（部分支付）" : ""), -paid);
            foreach (var c in o.Contracts)
            {
                while (c.EndDay < date) c.EndDay += c.Days;
                if (c.Position != "教练" && (o.Youth.Contains(c.PersonId) || c.Plan == "growth") && o.Debt == 0 && CareerEngine.Person(d, c.PersonId) is { } p)
                {
                    CareerTraining.Grow(d, p.Id, 25, d.Season);
                    if (o.Youth.Contains(p.Id) && p.MaxAscension < 8)
                    {
                        int next = p.MaxAscension + 1;
                        var run = MatchRules.Simulate(d, p.Id, next, d.WorldId + ":youth-test:" + p.Id + date, date);
                        if (run.Cleared) { p.Wins++; p.MaxAscension = next; } else p.Losses++;
                    }
                }
            }
            if (o.Debt > 0) CareerLife.AddEvent(d, "club-debt-" + date, "俱乐部", "俱乐部周结资金不足", "尚有" + CareerMoney.Format(o.Debt) + "待支付，陪练与青训暂停。", ["player"]);
        }
    }
    public static void SettleResults(CareerData d)
    {
        if (!IsOwner(d)) return;
        var o = d.Esports.OwnedClub!;
        UpgradeEconomy(d);
        foreach (var c in d.Esports.Competitions.Where(c => c.TeamEvent && c.Kind is "league" or "continental"))
            foreach (var tie in c.Fixtures.Where(f => f.HomeTeam == o.ClubId || f.AwayTeam == o.ClubId)
                .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)).Where(g => g.Count() == (c.Cooperative ? 1 : 3) && g.All(f => f.Finished)))
            {
                string receipt = c.Id + ":" + tie.Key.Round + ":" + tie.Key.HomeTeam + ":" + tie.Key.AwayTeam;
                if (!o.PaidResults.Add(receipt)) continue;
                bool home = tie.Key.HomeTeam == o.ClubId;
                int wins = tie.Count(f => f.WinnerId == (home ? f.HomeId : f.AwayId));
                GrantFans(o, wins >= (c.Cooperative ? 1 : 2) ? 400 : 120);
                if (c.Cooperative && wins >= 1) AccrueHumanPay(d, HumanWinBonus);
                if (wins >= (c.Cooperative ? 1 : 2) && o.Sponsor is { } sponsor) Pay(d, "俱乐部获胜赞助奖金", sponsor.WinBonus);
                foreach (var f in tie.Where(f => f.WinnerId == (home ? f.HomeId : f.AwayId)))
                    if (!c.Cooperative && o.Contracts.FirstOrDefault(ct => ct.PersonId == f.WinnerId) is { } contract)
                    {
                        decimal paid = Math.Min(Math.Max(0, CareerMoney.Balance(d)), contract.WinBonus);
                        Pay(d, CareerEngine.DisplayName(d, f.WinnerId) + "获胜奖金", -paid); o.Debt += contract.WinBonus - paid;
                    }
            }
        SettleAchievements(d);
    }
    public static void Report(CareerData d, string topic, string title, string detail, List<string> people) =>
        CareerLife.AddEvent(d, "owned-" + Guid.NewGuid().ToString("N"), topic, EsportsWorld.ClubName(d, d.Esports.ClubId) + " · " + title, detail, [d.Esports.OwnedClub?.ManagerId ?? "player", ..people], true);
    public static bool CanOperate(CareerData d) => IsOwner(d) && (d.LocalHumanId.Length == 0 || d.LocalHumanId == d.Esports.OwnedClub!.ManagerId);
    public static string CompleteActivity(CareerData d, LifeActivity a)
    {
        if (!CanOperate(d) || a.ClubId != d.Esports.OwnedClub!.ClubId) return "原俱乐部安排结束。";
        var o = d.Esports.OwnedClub!;
        if (ClubPrograms.IsTraining(a)) return "训练完成。" + CareerTraining.Gains(d, a);
        if (a.LongProject)
        {
            int total = 0;
            foreach (var c in o.Contracts.Where(c => c.Position != "教练")) total += CareerTraining.Grow(d, c.PersonId, a.TermsVersion >= 3 ? 100 : 50, d.Season);
            return total > 0 ? "签约选手取得长期训练进步。" : "训练进度已累计。";
        }
        int fans = GrantFans(o, CareerLife.ActivityBenefit(a, 300 + CareerEngine.StableHash(d.WorldId + a.Id) % 301));
        return $"俱乐部新增 {fans} 位关注者。";
    }
    public static string? Command(CareerData d, string kind, string target, string text)
    {
        switch (kind)
        {
            case "create": return Create(d, JsonSerializer.Deserialize<ClubDraft>(text) ?? throw new InvalidDataException("草案为空。"));
            case "recruit": return Recruit(d, JsonSerializer.Deserialize<ClubSigning>(text) ?? throw new InvalidDataException("签约内容为空。"));
            case "transfer": return ArrangeTransfer(d, JsonSerializer.Deserialize<ClubSigning>(text) ?? throw new InvalidDataException("合同为空。"));
            case "coach": return ClubCoaching.Appoint(d, target, text);
            case "coach-cancel": d.Esports.OwnedClub!.CoachAppointments.RemoveAll(a => a.PersonId == target); CareerStore.Save(d); return null;
            case "player-coach": return ClubCoaching.SetPlayerCoach(d, text == "1");
            case "player-position": return ClubCoaching.SetPlayerPosition(d, target, text);
            case "training-cancel": ClubCoaching.StopTraining(d, target); CareerStore.Save(d); return null;
            case "swap": return Swap(d, target, text);
            case "release": return Release(d, target, text);
            case "position": return Assign(d, target, text);
            case "sponsor": return ChangeSponsor(d, target);
            case "region": return OwnedClubSchedule.ChangeRegion(d, target);
            case "debt": return PayDebt(d);
            default: return "俱乐部操作无效。";
        }
    }
    public static string? PayDebt(CareerData d)
    {
        if (!IsOwner(d) || d.Esports.OwnedClub!.Debt <= 0 && !d.Esports.OwnedClub.HumanPayDue.Values.Any(value => value > 0)) return "没有待支付款项。";
        if (d.Esports.OwnedClub.Debt == 0) return null;
        decimal amount = Math.Min(Math.Max(0, CareerMoney.Balance(d)), d.Esports.OwnedClub.Debt);
        if (amount == 0) return "当前资金不足。";
        d.Esports.OwnedClub.Debt -= amount; Pay(d, "补发俱乐部欠款", -amount); CareerStore.Save(d); return null;
    }
}

/// <summary>俱乐部项目复用活动存档与成长结算；付款时固定名单、费率和有效日期。</summary>
public static class ClubPrograms
{
    private sealed record Terms(int Temporary = 0, int Weekly = 0, int Defense = 0, bool Academy = false);
    private static Terms? Get(string title) => title switch
    {
        "全队集中备赛" => new(Temporary: 800),
        "高压战斗特训" => new(Defense: 1400),
        "建设青训课程" => new(Weekly: 75, Academy: true),
        "整理战队录像库" => new(Weekly: 50),
        "教练驻队指导" => new(Temporary: 600, Weekly: 50),
        "建立全队训练体系" => new(Weekly: 75),
        _ => null
    };
    private static Terms Effective(LifeActivity a)
    {
        var t = Get(a.Title)!;
        return a.TermsVersion >= 3 ? t with { Temporary = t.Temporary * 2, Weekly = t.Weekly * 2, Defense = t.Defense * 2 } : t;
    }
    public static bool IsTraining(LifeActivity a) => a.Kind == "经营" && a.TermsVersion >= 2 && Get(a.Title) != null;
    private static List<string> Targets(CareerData d, string title)
    {
        if (d.Esports.OwnedClub is not { } o || o.ClubId != d.Esports.ClubId) return [];
        bool academy = Get(title)?.Academy == true;
        return o.Contracts.Select(c => c.PersonId).Where(id => !OwnedClubs.Humans(d).Contains(id)
            && CareerEngine.Person(d, id)?.ClubId == o.ClubId && !o.Coaches.Contains(id) && (!academy || o.Reserves.Contains(id) || o.Youth.Contains(id))).Distinct().ToList();
    }
    public static bool CanOffer(CareerData d, string title)
    {
        var terms = Get(title);
        if (terms == null) return true;
        // 多人的比赛由真人操作，不销售不会作用于真人对局的临时能力。
        return !(CareerTraining.Multiplayer(d) && (terms.Temporary > 0 || terms.Defense > 0)) && Targets(d, title).Count > 0;
    }
    public static string? Error(CareerData d, LifeActivity a)
    {
        if (!OwnedClubs.CanOperate(d) || a.ClubId != d.Esports.OwnedClub?.ClubId) return "这项安排属于此前的俱乐部。";
        if (!CanOffer(d, a.Title)) return "当前没有适用的签约选手。";
        return null;
    }
    public static void Snapshot(CareerData d, LifeActivity a)
    {
        var t = Effective(a);
        a.TrainingKind = "club"; a.TrainingTargets = Targets(d, a.Title);
        a.TemporaryPoints = t.Temporary; a.DefensePoints = t.Defense; a.WeeklyGrowthPoints = t.Weekly;
        a.TrainingStart = a.StartedDay + 1; a.TrainingEnd = a.StartedDay + 28; a.FinishDay = a.TrainingEnd + 1;
    }
    public static void Advance(CareerData d, LifeActivity a)
    {
        if (a.ClubId != d.Esports.OwnedClub?.ClubId || !OwnedClubs.CanOperate(d)) return;
        a.TrainingTargets.RemoveAll(id => CareerEngine.Person(d, id)?.ClubId != a.ClubId
            || !d.Esports.OwnedClub.Contracts.Any(c => c.PersonId == id));
        CareerTraining.Advance(d, a);
    }
    public static string Description(CareerData d, LifeActivity a)
    {
        var t = Effective(a);
        int temporary = a.TrainingStart > 0 ? a.TemporaryPoints : t.Temporary;
        int defense = a.TrainingStart > 0 ? a.DefensePoints : t.Defense;
        int weekly = a.TrainingStart > 0 ? a.WeeklyGrowthPoints : t.Weekly;
        var ids = a.TrainingStart > 0 ? a.TrainingTargets : Targets(d, a.Title);
        string scope = (t.Academy ? "轮换与青训" : "全体签约选手") + $" · {ids.Count} 人";
        var effects = new List<string>();
        if (temporary > 0) effects.Add($"通关率 +{temporary / 100.0:0.##}%，持续 28 天");
        if (defense > 0) effects.Add($"未通关时，首幕出局率最多降低 {defense / 100.0:0.##}%，持续 28 天");
        if (weekly > 0)
        {
            var gains = ids.Select(id => CareerTraining.ExpectedGrowth(d, a, id, weekly) + a.TrainingGained.GetValueOrDefault(id)).DefaultIfEmpty().ToList();
            string value = gains.Max() == 0 ? "<0.01%（继续累计）" : gains.Min() == gains.Max() ? $"+{gains.Min() / 100.0:0.##}%" : $"+{gains.Min() / 100.0:0.##}%～{gains.Max() / 100.0:0.##}%";
            effects.Add($"每人预计永久提升 {value}，分四周结算");
        }
        return scope + "\n" + string.Join("\n", effects);
    }
    public static string Details(CareerData d, LifeActivity a) => "次日起生效，持续四周。临时效果取最高值，不叠加。永久成长随累计提升和本季投入逐渐减慢，小数进度保留，各进阶均生效。\n"
        + string.Join("、", (a.TrainingStart > 0 ? a.TrainingTargets : Targets(d, a.Title)).Select(id => CareerEngine.DisplayName(d, id)));
}
