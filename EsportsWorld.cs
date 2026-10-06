using System.Globalization;

namespace NationalSpire;

public static class EsportsWorld
{
    public static readonly string[] Countries = ["中国", "日本", "韩国", "德国", "法国", "巴西", "英国", "美国"];
    private static readonly string[][] ClubNames = [ ["龙门竞技", "长夜俱乐部"], ["月见竞技", "赤枫俱乐部"], ["白虎电竞", "晨星竞技"], ["莱茵守望", "黑森林竞技"], ["白鸢俱乐部", "蔚蓝竞技"], ["金羽竞技", "雨林俱乐部"], ["王冠竞技", "雾港俱乐部"], ["极光竞技", "边境俱乐部"] ];
    private static readonly string[] Characters = ["铁甲战士", "静默猎手", "故障机器人", "亡灵契约师", "储君"];
    private static readonly string[] Styles = ["力量与高费攻击", "中毒与弃牌", "充能球与集中", "奥斯蒂与末日", "辉星与铸剑"];
    public static string LicenseName(CareerData d) => new[] { "社区新人", "城市挑战者", "青训选手", "职业选手" }[Math.Clamp(d.Esports.License, 0, 3)];
    public static CareerClub? Club(CareerData d, string id) => d.Esports.Clubs.FirstOrDefault(c => c.Id == id);
    public static string ClubName(CareerData d, string id) => Club(d, id)?.Name ?? "自由选手";
    public static string ClubOf(CareerData d, string id) => id == "player" ? d.Esports.ClubId : CareerEngine.Person(d, id)?.ClubId ?? "";
    public static string CountryOf(CareerData d, string id) => id == "player" ? d.Esports.Country : CareerEngine.Person(d, id)?.Country ?? "";
    public static string HistoricClub(CareerData d, WorldCompetition c, string id) => c.EntrantClubs.GetValueOrDefault(id, ClubOf(d, id));
    public static string HistoricCountry(CareerData d, WorldCompetition c, string id) => c.EntrantCountries.GetValueOrDefault(id, CountryOf(d, id));
    public static int RatingOf(CareerData d, string id) => id == "player" ? d.Rating : CareerEngine.Person(d, id)?.Rating ?? 0;
    public static bool IsProfessional(CareerPerson p) => p.ClubPosition.Length > 0 ? p.ClubPosition is "首发" or "轮换"
        : p.Role is "职业选手" or "世界顶尖" || p.AbilityTemplate is "职业选手" or "世界顶尖";
    public static string StageName(string kind) => kind switch { "local" => "社区赛事", "city" => "城市公开赛", "academy" => "青训选拔", "open" => "赛区巡回公开赛", "league" => "国内职业联赛", "continental" => "洲际俱乐部冠军杯", "worldcup" => "国家队世界杯", "worldfinal" => "世界总决赛", "masters" => "世界纪录邀请赛", _ => "历史赛事" };
    public static string CupRound(string kind, int round) => kind == "worldcup" ? new[] { "八强赛", "半决赛", "决赛" }[Math.Clamp(round - 1, 0, 2)] : new[] { "十六强赛", "八强赛", "半决赛", "决赛" }[Math.Clamp(round - 1, 0, 3)];
    public static IEnumerable<CareerStanding> Ranked(WorldCompetition c) => c.Table.OrderByDescending(x => x.Points).ThenByDescending(x => x.Wins).ThenByDescending(x => x.Clears).ThenBy(x => c.Entrants.IndexOf(x.PersonId));
    public static WorldCompetition? PlayerLeague(CareerData d) => d.Esports.Competitions.FirstOrDefault(c => c.Season == d.Season && c.Kind == "league" && c.Country == (Club(d, d.Esports.ClubId)?.Country ?? d.Esports.Country));
    public static int DomesticRank(CareerData d)
    {
        var c = PlayerLeague(d); if (c == null || !c.PlayerEntered) return 0;
        return Ranked(c).ToList().FindIndex(x => x.PersonId == "player") + 1;
    }

    public static void Initialize(CareerData d)
    {
        if (d.Esports.Initialized) return;
        d.Esports.Initialized = true;
        for (int country = 0; country < Countries.Length; country++)
        {
            for (int club = 0; club < 2; club++) d.Esports.Clubs.Add(new CareerClub
            {
                Id = $"c{country}{club}", Name = country == 0 ? ClubNames[country][club] : RegionalOrganizations.ClubName(d, Countries[country], $"c{country}{club}"), Country = Countries[country],
                Color = new[] { "dfb66f", "75c9bc", "8babd8", "cd92ac" }[(country + club) % 4],
                Motto = club == 0 ? "传统强队，重视稳定的赛季成绩" : "新锐阵容，愿意给有成绩的新选手机会"
            });
            for (int i = 0; i < 8; i++)
            {
                string id = country == 0 && i < 6 ? "p" + (i + 16) : $"pro{country}_{i}";
                var p = CareerEngine.Person(d, id);
                if (p == null) { p = new CareerPerson { Id = id, Name = WorldPeople.Name(d, id, Countries[country], false) }; d.People.Add(p); }
                p.Country = Countries[country]; p.Region = Countries[country] + "职业赛区"; p.ClubId = $"c{country}{i / 4}";
                p.MaxAscension = i == 5 ? 9 : 8; p.Role = i == 5 ? "世界顶尖" : "职业选手";
                p.Character = Characters[(country + i) % 5]; p.Style = Styles[(country + i) % 5];
                p.Rating = 1280 + i * 18 + country * 7; p.Wins = Math.Max(p.Wins, 12 + i * 2); p.Losses = Math.Max(p.Losses, 70 + country * 9 + i * 3);
                p.Voice = new[] { "传统派，喜欢用熟悉流派解释比赛", "谨慎，会先核对交手战绩", "自信，败给强者后愿意承认差距", "重视俱乐部荣誉，偏爱本队选手" }[i % 4];
            }
            for (int i = 0; i < 2; i++)
            {
                d.People.Add(new CareerPerson { Id = $"y{country}_{i}", Name = WorldPeople.Name(d, $"y{country}_{i}", Countries[country], false), Country = Countries[country], Region = Countries[country] + "青训中心", ClubId = $"c{country}{i}", Role = "青训选手", MaxAscension = 6 + i, Character = Characters[(country + i) % 5], Style = Styles[(country + i) % 5], Rating = 1040 + i * 60, Wins = 6 + i, Losses = 55 + country, Voice = "渴望职业合同，容易模仿明星的构筑" });
                if (country > 0) d.People.Add(new CareerPerson { Id = $"fan{country}_{i}", Name = WorldPeople.Name(d, $"fan{country}_{i}", Countries[country], true), Country = Countries[country], Region = Countries[country] + "社区", Role = "普通玩家", MaxAscension = i + 1, Character = Characters[(country + i) % 5], Style = "偏爱稀有牌", Rating = 650 + country * 8, Wins = 1 + i, Losses = 40 + country, Voice = i == 0 ? "主队球迷，情绪热烈" : "普通观众，经常在第一幕失败" });
            }
        }
        for (int i = 0; i < 16; i++) if (CareerEngine.Person(d, "p" + i) is { } p)
        {
            p.Country = d.Esports.Country; p.ClubId = "";
            if (i >= 10) { p.MaxAscension = 6 + i % 2; p.Role = "青训选手"; }
        }
        d.People.Add(new CareerPerson { Id = "desk", Name = "尖塔赛事中心", Role = "赛事记者", Country = "中国", Region = "国际赛事编辑部", MaxAscension = 2, Character = "铁甲战士", Style = "整理公开战报", Wins = 2, Losses = 32, Voice = "区分事实与评论，只引用已确认赛果" });
        d.People.Add(new CareerPerson { Id = "caster", Name = "解说席·闻笙", Role = "解说员", Country = "中国", Region = "赛事转播", MaxAscension = 4, Character = "静默猎手", Style = "按传统流派解释打法", Wins = 4, Losses = 51, Voice = "善于营造大赛气氛，不理解玩家真实思路" });
        d.Esports.BestClear = d.Results.Where(r => r.Win && r.OfficialAscensionVerified && !PrivateAppointments.IsPrivate(r)).Select(r => r.Ascension).DefaultIfEmpty(-1).Max();
        d.Esports.License = Math.Max(d.Esports.License, d.Esports.BestClear >= 8 ? 3 : d.Wins >= 2 ? 2 : d.Wins >= 1 ? 1 : 0);
        // 升级存档保留已完成赛事及正在进行的种子；只替换尚未开始的旧赛程。
        d.Matches.RemoveAll(m => m.Kind == "legacy" && m.Status == "待赛" && m.Id != d.PendingMatchId);
        StartSeason(d, true);
        for (int day = (d.Season - 1) * 28 + 1; day < d.Day; day++) EndDay(d, day, false);
        if (d.Esports.License >= 3) MakeOffers(d, false);
        CareerEngine.Publish(d, "ecosystem", "新的职业赛制公布：从社区走向世界", "社区杯→城市公开赛→青训选拔→职业俱乐部。国内联赛前二获得洲际杯候选资格；每两个赛季举行国家队世界杯，国家队还要求进阶八通关履历。所有国家的赛事都会独立进行。", "赛事公告", false);
    }

    public static void StartSeason(CareerData d, bool migrating = false)
    {
        if (d.Esports.EcosystemVersion >= 1)
        {
            CircuitWorld.StartSeason(d);
            d.Esports.Offers.RemoveAll(o => o.ExpiresDay < d.Day);
            if (d.Esports.License >= 3) MakeOffers(d, d.Esports.Honors.Any(h => h.Id.StartsWith("worldfinal-") || h.Id.StartsWith("continental-") || h.Id.StartsWith("worldcup-")));
            return;
        }
        int start = (d.Season - 1) * 28;
        d.Esports.NationalTeam = false;
        d.Esports.Competitions.RemoveAll(c => c.Season < d.Season - 4);
        d.Esports.Offers.RemoveAll(o => o.ExpiresDay < d.Day);
        foreach (string country in Countries)
        {
            var entrants = d.People.Where(p => p.Country == country && IsProfessional(p)).OrderByDescending(p => p.Rating).ThenBy(p => p.Id, StringComparer.Ordinal).Take(8).Select(p => p.Id).ToList();
            var c = new WorldCompetition { Id = $"league-{d.Season}-{Array.IndexOf(Countries, country)}", Name = country + "职业联赛", Country = country, Season = d.Season, Entrants = entrants, Table = entrants.Select(id => new CareerStanding { PersonId = id }).ToList() };
            SnapshotEntrants(d, c);
            var rotation = entrants.ToList();
            for (int round = 1; round <= 3; round++)
            {
                for (int i = 0; i < 4; i++) c.Fixtures.Add(new WorldFixture { Id = $"{c.Id}-{round}-{i}", Day = start + 9 + round * 3, Round = round, HomeId = rotation[i], AwayId = rotation[7 - i] });
                rotation.Insert(1, rotation[^1]); rotation.RemoveAt(rotation.Count - 1);
            }
            d.Esports.Competitions.Add(c);
        }
        void Add(int day, string kind, string title, int ascension, int prize, string opponent = "", int round = 0)
        {
            if (migrating && start + day < d.Day || d.Matches.Any(m => m.Id == d.PendingMatchId && m.Day == start + day)) return;
            d.Matches.Add(new CareerMatch { Day = start + day, Kind = kind, Event = title, OpponentId = opponent, RequiredAscension = ascension, Prize = prize, Round = round, Seed = $"NS{d.Season:X}{day:X}{CareerEngine.StableHash(d.WorldId + kind + d.Season + round):X8}" });
        }
        var locals = d.People.Where(p => p.Country == d.Esports.Country && p.Role == "普通玩家").ToList();
        Add(3, "local", "街区周末杯", 0, 45, locals[d.Season % locals.Count].Id);
        Add(6, "city", "城市新秀公开赛", 3, 100, d.People.First(p => p.Role == "青训选手" && p.Country == d.Esports.Country).Id);
        Add(9, "academy", "职业青训选拔赛", 6, 180, "p15");
        for (int r = 1; r <= 3; r++) Add(9 + r * 3, "league", $"职业联赛 · 第 {r} 轮", 8, 260, round: r);
        string cup = d.Season % 2 == 0 ? "worldcup" : "continental";
        int rounds = cup == "worldcup" ? 3 : 4;
        for (int r = 1; r <= rounds; r++) Add(26 - (rounds - r) * 2, cup, StageName(cup) + " · " + CupRound(cup, r), r == rounds ? 9 : 8, 400 + r * 180, round: r);
        Add(28, "masters", "世界纪录邀请赛", 10, 1200, d.People.Where(p => p.MaxAscension == 9).OrderByDescending(p => p.Rating).First().Id);
        d.Matches = d.Matches.OrderBy(m => m.Day).ToList();
        RefreshLeagueMatches(d);
        if (!migrating && d.Season > 1) TransferWindow(d);
        if (d.Esports.License >= 3) MakeOffers(d, false);
    }

    private static string LeagueSlot(CareerData d, WorldCompetition c) => c.PlayerEntered ? "player" : c.Entrants.LastOrDefault(id => ClubOf(d, id) == d.Esports.ClubId) ?? c.Entrants[^1];
    public static void RefreshLeagueMatches(CareerData d)
    {
        var c = PlayerLeague(d); if (c == null) return;
        if (c.Modern) { if (c.PlayerEntered) CircuitWorld.SchedulePlayer(d, c); return; }
        foreach (var m in d.Matches.Where(m => m.Kind == "league" && m.Day > (d.Season - 1) * 28 && m.Day <= d.Season * 28 && m.Status == "待赛"))
        {
            var f = c.Fixtures.FirstOrDefault(f => f.Round == m.Round && (f.HomeId == LeagueSlot(d, c) || f.AwayId == LeagueSlot(d, c)));
            if (f == null) continue;
            m.CompetitionId = c.Id; m.FixtureId = f.Id; m.Event = c.Name + $" · 第 {m.Round} 轮";
            m.OpponentId = f.HomeId == LeagueSlot(d, c) ? f.AwayId : f.HomeId;
        }
        d.Standings = c.PlayerEntered ? c.Table : [];
    }

    public static string? EntryReason(CareerData d, CareerMatch m)
    {
        if (PrivateAppointments.IsPrivate(m)) return CareerEngine.Person(d, m.OpponentId) == null ? "约战对象已不存在。" : null;
        if (d.Esports.Competitions.FirstOrDefault(c => c.Id == m.CompetitionId)?.Modern == true)
            return m.OpponentId.Length > 0 ? null : "等待下一轮对阵。";
        if (m.Kind == "legacy") return null;
        var w = d.Esports;
        if (m.Kind == "local") return w.License < 3 ? null : "社区杯面向业余和青训选手。";
        if (m.Kind == "city") return w.License is 1 or 2 ? null : w.License < 1 ? "先在街区杯获胜，或完成双方通关的平局。" : "职业选手可报名赛区巡回公开赛。";
        if (m.Kind == "open") return w.License >= 2 ? null : "巡回公开赛面向青训及职业选手。";
        if (m.Kind == "academy") return w.License == 2 ? null : w.License < 2 ? "先取得城市公开赛认证。" : "已持有职业资格，无需重复参加青训选拔。";
        if (m.Kind == "league")
        {
            if (w.License < 3) return "需要通过青训选拔，取得职业资格。";
            if (w.ClubId == "") return "先在赛事与俱乐部接受一份俱乐部合同。";
            var league = PlayerLeague(d);
            if (league?.PlayerEntered == true) return null;
            return d.Day <= (d.Season - 1) * 28 + 12 ? null : "本赛季联赛报名已经截止，下赛季可以再次报名。";
        }
        if (m.Kind is "continental" or "worldcup")
        {
            if (w.License < 3 || w.ClubId == "") return "需要职业资格和俱乐部合同。";
            var league = PlayerLeague(d);
            if (league?.Finished != true) return "国内联赛结束后，前二获得国际赛事候选资格。";
            if (DomesticRank(d) is < 1 or > 2) return "本赛季国内联赛未进入前二。";
            if (m.Kind == "worldcup" && w.BestClear < 8) return "国家队还要求至少一场生涯赛事中的进阶八通关。";
            var cup = d.Esports.Competitions.FirstOrDefault(c => c.Season == d.Season && c.Kind == m.Kind);
            if (cup == null) return "等待第 19 天的国际赛事抽签。";
            if (m.Round > 1 && !cup.Fixtures.Any(f => f.Id == m.FixtureId && (f.HomeId == "player" || f.AwayId == "player"))) return "必须赢得上一轮淘汰赛才能晋级。";
            return null;
        }
        if (m.Kind == "masters") return w.Honors.Any(h => h.Id.StartsWith("continental-") || h.Id.StartsWith("worldcup-") || h.Id.StartsWith("worldfinal-")) && w.BestClear >= 9 ? null : "仅邀请国际赛事冠军，且需要进阶九通关履历。";
        return "赛事尚未开放。";
    }

    public static string? Register(CareerData d, CareerMatch m, bool value)
    {
        if (d.Esports.Competitions.FirstOrDefault(c => c.Id == m.CompetitionId)?.Modern == true)
        {
            if (!value && m.Registered) return "席位已确认，比赛日可选择退赛。";
            m.Registered = value; m.RegistrationDeclined = !value; return null;
        }
        if (!value && m.Kind is "league" or "continental" or "worldcup" && m.Registered) return "已确认的联赛或淘汰赛席位不能取消报名；比赛日可以退赛。";
        if (!value) { m.Registered = false; m.RegistrationDeclined = true; return null; }
        string? reason = EntryReason(d, m); if (reason != null) return reason;
        m.RegistrationDeclined = false;
        if (m.Kind == "league")
        {
            var c = PlayerLeague(d)!;
            if (!c.PlayerEntered) ReplaceEntrant(d, c, LeagueSlot(d, c), "player");
            c.PlayerEntered = true; RefreshLeagueMatches(d);
            foreach (var game in d.Matches.Where(x => x.CompetitionId == c.Id && x.Status == "待赛" && x.Day >= d.Day)) game.Registered = true;
            CareerEngine.Publish(d, "league-entry-" + d.Season, $"{ClubName(d, d.Esports.ClubId)}确认首发：你进入职业联赛", "三轮联赛席位已经确认，赛程将依次推进。积分前二的争夺，将决定国际赛事资格。", "俱乐部", true);
        }
        else if (m.Kind is "continental" or "worldcup")
        {
            var c = d.Esports.Competitions.First(x => x.Season == d.Season && x.Kind == m.Kind);
            if (!c.PlayerEntered)
            {
                var slot = CupSlot(d, c);
                ReplaceEntrant(d, c, slot, "player"); c.PlayerEntered = true;
                if (m.Kind == "worldcup")
                {
                    d.Esports.NationalTeam = true;
                    Milestone(d, "national-debut", "身披国家队战袍", $"你被选为{d.Esports.Country}代表，出征国家队世界杯。", 350, 200);
                }
                CareerEngine.Publish(d, "international-entry-" + d.Season, m.Kind == "worldcup" ? $"国家队官宣：你将代表{d.Esports.Country}出征" : $"洲际杯首秀：你代表{ClubName(d, d.Esports.ClubId)}进入十六强", "淘汰赛签表已经确认。每轮胜者晋级，平局按抽签时公布的种子顺位判定；后续轮次自动报名。", "国际赛事", true);
            }
            RefreshCupMatches(d, c);
        }
        m.Registered = true;
        return null;
    }
    private static void ReplaceEntrant(CareerData d, WorldCompetition c, string oldId, string newId)
    {
        int index = c.Entrants.IndexOf(oldId); if (index < 0) throw new InvalidOperationException("赛事席位缺失。");
        c.Entrants[index] = newId;
        c.EntrantClubs.Remove(oldId); c.EntrantCountries.Remove(oldId);
        c.EntrantClubs[newId] = ClubOf(d, newId); c.EntrantCountries[newId] = CountryOf(d, newId);
        var row = c.Table.FirstOrDefault(x => x.PersonId == oldId); if (row != null) row.PersonId = newId;
        foreach (var f in c.Fixtures.Where(f => !f.Finished)) { if (f.HomeId == oldId) f.HomeId = newId; if (f.AwayId == oldId) f.AwayId = newId; }
    }
    private static void SnapshotEntrants(CareerData d, WorldCompetition c)
    {
        c.EntrantClubs = c.Entrants.ToDictionary(id => id, id => ClubOf(d, id));
        c.EntrantCountries = c.Entrants.ToDictionary(id => id, id => CountryOf(d, id));
    }
    private static string CupSlot(CareerData d, WorldCompetition c) => c.Kind == "worldcup" ? c.Entrants.First(id => CountryOf(d, id) == d.Esports.Country) : c.Entrants.FirstOrDefault(id => ClubOf(d, id) == d.Esports.ClubId) ?? c.Entrants.First(id => CountryOf(d, id) == d.Esports.Country);

    public static void EndDay(CareerData d, int day, bool publish = true)
    {
        foreach (var c in d.Esports.Competitions.Where(c => c.Season == d.Season).ToList())
        {
            foreach (var f in c.Fixtures.Where(f => f.Day == day && !f.Finished).ToList()) SimulateFixture(d, c, f);
            if (c.Modern) { CircuitWorld.AdvanceCompetition(d, c, day, publish); continue; }
            if (c.Kind == "league" && !c.Finished && c.Fixtures.All(f => f.Finished))
            {
                c.Finished = true; c.ChampionId = Ranked(c).First().PersonId; Crown(d, c, publish);
                if (c.PlayerEntered)
                {
                    int rank = DomesticRank(d);
                    if (rank <= 2 && publish) CareerEngine.Publish(d, "qualification-" + d.Season, $"国际赛事资格到手：你以联赛第 {rank} 名出线", $"{c.Name}收官，你获得国际赛事候选资格。前往赛事中心确认报名，代表{ClubName(d, d.Esports.ClubId)}出场。", "晋级", true);
                }
            }
            if (c.Kind != "league" && !c.Finished && c.Fixtures.Any(f => f.Day == day))
            {
                int round = c.Fixtures.Max(f => f.Round);
                var fixtures = c.Fixtures.Where(f => f.Round == round).ToList();
                if (fixtures.All(f => f.Finished))
                {
                    var winners = fixtures.Select(f => f.WinnerId).ToList();
                    if (publish && winners.Count > 1) CareerEngine.Publish(d, $"knockout-{c.Id}-{round}", c.Name + " · " + CupRound(c.Kind, round) + "战报", "晋级名单：" + string.Join("、", winners.Select(id => CareerEngine.DisplayName(d, id))) + "。下一轮签表已经更新。", "国际赛事", true, winners.Take(3).ToList());
                    if (winners.Count == 1) { c.Finished = true; c.ChampionId = winners[0]; Crown(d, c, publish); }
                    else { AddCupRound(c, winners, round + 1, day + 2); RefreshCupMatches(d, c); }
                }
            }
            if (publish && c.Kind == "league" && c.Fixtures.Any(f => f.Day == day) && c.Country != d.Esports.Country && Array.IndexOf(Countries, c.Country) == (day + d.Season) % Countries.Length)
                CareerEngine.Publish(d, $"roundup-{c.Id}-{day}", $"海外赛场：{c.Name}战报", string.Join("；", c.Fixtures.Where(f => f.Day == day).Take(2).Select(f => f.Draw ? $"{CareerEngine.DisplayName(d, f.HomeId)}战平{CareerEngine.DisplayName(d, f.AwayId)}" : $"{CareerEngine.DisplayName(d, f.WinnerId)}击败{CareerEngine.DisplayName(d, f.HomeId == f.WinnerId ? f.AwayId : f.HomeId)}")), "海外赛区", true);
        }
        if (SeasonCalendar.Day(d, day) == SeasonCalendar.LeagueEnd(d))
        {
            if (d.Esports.Competitions.Any(c => c.Season == d.Season && c.Modern)) CircuitWorld.CreateFinals(d, publish);
            else CreateInternational(d, publish);
        }
    }

    private static void SimulateFixture(CareerData d, WorldCompetition c, WorldFixture f)
    {
        bool walkover = f.HomeId == "player" || f.AwayId == "player";
        int asc = c.Modern ? f.Ascension : c.Kind != "league" && (f.Day - 1) % 28 + 1 == 26 ? 9 : 8;
        RunPerformance Run(string id, string seed) => id == "player" ? new(false, 0, 0)
            : MatchRules.Simulate(d, id, asc, seed, f.Day, d.CooperativeMembers > 1, c, f.Id);
        var a = Run(f.HomeId, d.WorldId + ":" + f.Id); var b = Run(f.AwayId, d.WorldId + ":" + f.Id);
        int score = walkover ? (f.HomeId == "player" ? -1 : 1) : MatchRules.Compare(a, b);
        walkover |= a.Floor < 0 || b.Floor < 0;
        if (c.Modern && !walkover)
            for (int replay = 1; score == 0; replay++)
            {
                a = Run(f.HomeId, d.WorldId + f.Id + ":replay:" + replay);
                b = Run(f.AwayId, d.WorldId + f.Id + ":replay:" + replay);
                score = MatchRules.Compare(a, b);
            }
        bool draw = score == 0;
        if (draw && c.Kind != "league") { score = c.Entrants.IndexOf(f.HomeId) < c.Entrants.IndexOf(f.AwayId) ? 1 : -1; draw = false; }
        f.HomeCleared = a.Cleared; f.AwayCleared = b.Cleared; f.HomeFloor = a.Floor; f.AwayFloor = b.Floor; f.Walkover = walkover;
        f.HomeSeconds = a.Seconds; f.AwaySeconds = b.Seconds;
        FinishFixture(d, c, f, draw ? "" : score > 0 ? f.HomeId : f.AwayId, draw);
    }

    public static void ResolvePlayerFixture(CareerData d, CareerMatch m, bool playerClear, bool abandoned)
    {
        var c = d.Esports.Competitions.FirstOrDefault(c => c.Id == m.CompetitionId);
        var f = c?.Fixtures.FirstOrDefault(f => f.Id == m.FixtureId); if (c == null || f == null || f.Finished) return;
        f.HomeCleared = f.HomeId == "player" ? playerClear : m.OpponentWon;
        f.AwayCleared = f.AwayId == "player" ? playerClear : m.OpponentWon;
        f.HomeFloor = f.HomeId == "player" ? m.PlayerFloor : m.OpponentFloor;
        f.AwayFloor = f.AwayId == "player" ? m.PlayerFloor : m.OpponentFloor;
        f.HomeSeconds = f.HomeId == "player" ? m.PlayerSeconds : m.OpponentSeconds;
        f.AwaySeconds = f.AwayId == "player" ? m.PlayerSeconds : m.OpponentSeconds;
        f.Walkover = abandoned;
        FinishFixture(d, c, f, m.Draw ? "" : m.PlayerWon ? "player" : m.OpponentId, m.Draw);
    }
    private static void FinishFixture(CareerData d, WorldCompetition c, WorldFixture f, string winner, bool draw)
    {
        if (f.Finished) return;
        SeasonCeremony.RecordParticipants(d, c, f);
        f.Finished = true; f.WinnerId = winner; f.Draw = draw;
        foreach (string id in new[] { f.HomeId, f.AwayId })
        {
            var table = c.Table.FirstOrDefault(x => x.PersonId == id);
            if (table != null) { if (f.HomeId == id ? f.HomeCleared : f.AwayCleared) table.Clears++; if (draw) { table.Draws++; table.Points++; } else if (winner == id) { table.Wins++; table.Points += 3; } else table.Losses++; }
            var people = c.Cooperative && id != "player" ? CircuitWorld.CooperativeRoster(d, c, id, f.Id)
                : new List<CareerPerson>();
            if (people.Count == 0 && CareerEngine.Person(d, id) is { } individual) people.Add(individual);
            foreach (var person in people)
            {
            bool clear = f.HomeId == id ? f.HomeCleared : f.AwayCleared;
            if (clear) person.Wins++; else person.Losses++;
            if (clear) person.MaxAscension = Math.Max(person.MaxAscension, c.Modern ? f.Ascension : (f.Day - 1) % 28 + 1 == 26 && c.Kind != "league" ? 9 : 8);
            if (person.MaxAscension >= 9) person.Role = "世界顶尖";
            person.Rating = Math.Clamp(person.Rating + (draw ? 2 : winner == id ? 12 : -5), 900, 2100);
            person.Form = (person.Form + (draw ? "平" : winner == id ? "胜" : "负")); if (person.Form.Length > 5) person.Form = person.Form[^5..];
            }
        }
        OwnedClubs.SettleResults(d);
    }

    public static void BreakKnockoutTie(CareerData d, CareerMatch m)
    {
        if (!m.Draw || m.Kind is not ("continental" or "worldcup")) return;
        var c = d.Esports.Competitions.First(x => x.Id == m.CompetitionId);
        int own = c.Entrants.IndexOf("player"), opponent = c.Entrants.IndexOf(m.OpponentId);
        m.Draw = false; m.PlayerWon = own < opponent;
        m.Decider = $"双方成绩相同；按赛前种子顺位判定（你为 {own + 1} 号，对手为 {opponent + 1} 号）。";
    }

    private static void CreateInternational(CareerData d, bool publish)
    {
        string kind = d.Season % 2 == 0 ? "worldcup" : "continental";
        if (d.Esports.Competitions.Any(c => c.Season == d.Season && c.Kind == kind)) return;
        var entrants = new List<string>();
        foreach (var league in d.Esports.Competitions.Where(c => c.Season == d.Season && c.Kind == "league"))
        {
            var eligible = Ranked(league).Where(s => s.PersonId != "player").Select(s => s.PersonId).ToList();
            if (kind == "worldcup") entrants.Add(eligible.First());
            else foreach (var club in d.Esports.Clubs.Where(c => c.Country == league.Country && league.EntrantClubs.Values.Contains(c.Id))) entrants.Add(eligible.First(id => ClubOf(d, id) == club.Id));
        }
        entrants = entrants.OrderByDescending(id => RatingOf(d, id)).ThenBy(id => id, StringComparer.Ordinal).ToList();
        var cup = new WorldCompetition { Id = kind + "-" + d.Season, Kind = kind, Name = StageName(kind), Season = d.Season, Country = "国际", Entrants = entrants };
        SnapshotEntrants(d, cup);
        AddCupRound(cup, entrants, 1, (d.Season - 1) * 28 + (kind == "worldcup" ? 22 : 20));
        d.Esports.Competitions.Add(cup); RefreshCupMatches(d, cup);
        if (publish) CareerEngine.Publish(d, "draw-" + d.Season, cup.Name + "抽签揭晓", $"{entrants.Count} 个席位已经确定。{(kind == "worldcup" ? "各国代表为国家荣誉出战" : "各俱乐部代表争夺洲际最高荣誉")}。签表可在电竞世界查看，国内联赛前二可确认自己的候选席位。", "国际赛事", true);
    }
    private static void AddCupRound(WorldCompetition c, List<string> entrants, int round, int day)
    {
        for (int i = 0; i < entrants.Count / 2; i++) c.Fixtures.Add(new WorldFixture { Id = $"{c.Id}-{round}-{i}", Day = day, Round = round, HomeId = round == 1 ? entrants[i] : entrants[i * 2], AwayId = round == 1 ? entrants[^(i + 1)] : entrants[i * 2 + 1] });
    }
    private static void RefreshCupMatches(CareerData d, WorldCompetition c)
    {
        foreach (var m in d.Matches.Where(m => m.Kind == c.Kind && m.Day > (d.Season - 1) * 28 && m.Status == "待赛"))
        {
            m.CompetitionId = c.Id;
            string slot = c.PlayerEntered ? "player" : CupSlot(d, c);
            var f = c.Fixtures.FirstOrDefault(f => f.Round == m.Round && (f.HomeId == slot || f.AwayId == slot));
            if (f == null)
            {
                bool lost = c.PlayerEntered && c.Fixtures.Any(f => f.Finished && (f.HomeId == "player" || f.AwayId == "player") && f.WinnerId != "player");
                if (lost) { m.Status = "未晋级"; m.Registered = false; }
                continue;
            }
            m.FixtureId = f.Id; m.OpponentId = f.HomeId == slot ? f.AwayId : f.HomeId;
            if (c.PlayerEntered) m.Registered = true;
        }
    }

    private static void Crown(CareerData d, WorldCompetition c, bool publish)
    {
        string name = CareerEngine.DisplayName(d, c.ChampionId);
        if (CareerEngine.Person(d, c.ChampionId) is { } p) p.Titles++;
        if (c.Kind != "worldcup" && Club(d, HistoricClub(d, c, c.ChampionId)) is { } club) club.Titles++;
        if (c.ChampionId == "player")
        {
            string honorId = c.Kind + "-" + d.Season;
            Milestone(d, honorId, c.Name + "冠军", $"第 {d.Season} 赛季，{ClubName(d, d.Esports.ClubId)}的你登上冠军领奖台。", c.Kind == "worldcup" ? 2200 : c.Kind == "continental" ? 1400 : 500, c.Kind == "league" ? 500 : 1500);
            if (c.Kind != "league") MakeOffers(d, true);
        }
        if (publish) CareerEngine.Publish(d, "champion-" + c.Id, $"{c.Name}落幕：{name}夺冠", $"{(c.Kind == "worldcup" ? CountryOf(d, c.ChampionId) : ClubName(d, ClubOf(d, c.ChampionId)))}收获本赛季冠军。完整对阵与结果已收录在赛事档案。", c.Kind == "league" ? "国内联赛" : "国际赛事", true, [c.ChampionId]);
        RefreshLeagueMatches(d);
    }
    public static void AfterPlayerMatch(CareerData d, CareerMatch m, bool runClear, bool abandoned)
    {
        var w = d.Esports;
        if (runClear && !abandoned) w.BestClear = Math.Max(w.BestClear, m.RequiredAscension);
        w.WinStreak = m.PlayerWon ? w.WinStreak + 1 : m.Draw ? w.WinStreak : 0;
        var duel = w.Duels.FirstOrDefault(x => x.PersonId == m.OpponentId);
        if (duel == null) { duel = new CareerDuel { PersonId = m.OpponentId }; w.Duels.Add(duel); }
        if (m.PlayerWon) duel.Wins++; else if (m.Draw) duel.Draws++; else duel.Losses++; duel.LastDay = d.Day;
        bool passed = !abandoned && (m.PlayerWon || m.Draw && runClear);
        int target = m.Kind switch { "local" => 1, "city" => 2, "academy" => 3, _ => 0 };
        if (passed && target > w.License)
        {
            w.License = target;
            Milestone(d, "license-" + target, target == 3 ? "取得职业资格" : target == 2 ? "获得青训邀请" : "走出社区赛场", $"{m.Event}的成绩通过认证，你现在是{LicenseName(d)}。", target * 65, target * 50);
            if (target == 3) MakeOffers(d, false);
        }
        if (runClear && !abandoned && (m.RequiredAscension) >= 8) Milestone(d, "clear-" + m.RequiredAscension, $"进阶 {m.RequiredAscension} 通关认证", "职业圈正在研究这份通关战报，不同赛区开始关注你的下一场表现。", (m.RequiredAscension) >= 9 ? 500 : 200, 120);
        if (w.WinStreak >= 3) Milestone(d, "streak-3", "三连胜，新星升起", "连续三场赛事获胜，你第一次登上赛区焦点栏目。", 120, 100);
        CareerCommerce.RefreshOffers(d);
    }
    public static void Milestone(CareerData d, string id, string title, string detail, int fans, int money)
    {
        if (OwnedClubs.IsOwner(d)) return;
        if (d.Esports.Milestones.Contains(id)) return;
        d.Esports.Milestones.Add(id); d.Fans += fans; d.Credits += money;
        d.Esports.Honors.Add(new CareerHonor { Id = id, Title = title, Detail = detail, Season = d.Season, Day = d.Day });
        CareerEngine.Publish(d, "honor-" + id, title, detail, "生涯里程碑", true);
    }
    private static void MakeOffers(CareerData d, bool international)
    {
        var candidates = d.Esports.Clubs.Where(c => international ? c.Country != d.Esports.Country : c.Country == d.Esports.Country)
            .Where(c => d.Esports.Competitions.Any(league => league.Season == d.Season && league.Kind == "league" && (league.Modern ? league.Teams.Contains(c.Id) : league.EntrantClubs.Values.Contains(c.Id))))
            .OrderBy(c => CareerEngine.StableHash(d.WorldId + c.Id + d.Season)).DistinctBy(c => c.Identity.Length > 0 ? c.Identity : c.Id).Take(3);
        foreach (var club in candidates.Where(c => c.Id != d.Esports.ClubId))
        {
            var offer = d.Esports.Offers.FirstOrDefault(o => o.ClubId == club.Id);
            if (offer != null) { offer.ExpiresDay = Math.Max(offer.ExpiresDay, d.Day + 28); continue; }
            d.Esports.Offers.Add(CareerCommerce.Quote(d, club));
        }
    }
    public static string? AcceptOffer(CareerData d, ClubOffer offer)
    {
        if (OwnedClubs.IsOwner(d)) return "你正在经营自己的俱乐部。";
        if (!d.Esports.Offers.Contains(offer) || offer.ExpiresDay < d.Day || d.Esports.License < 3) return "合同已经失效。";
        if (d.PendingMatchId != null || d.Esports.Competitions.Any(c => c.Season == d.Season && c.PlayerEntered && !c.Finished && (!c.Modern || c.Fixtures.Any(f => f.Finished)))) return "当前赛事尚未结束，暂时不能转会。";
        int deadline = d.Esports.Competitions.Any(c => c.Season == d.Season && c.Modern) ? SeasonCalendar.LeagueDeadline(d) : 12;
        if (d.Esports.ClubId.Length > 0 && SeasonCalendar.Day(d, d.Day) > deadline) return $"转会窗口为每赛季第 1—{deadline} 天。自由选手可随时签约，错过报名期则参加下一季联赛。";
        string old = ClubName(d, d.Esports.ClubId);
        CircuitWorld.LeavePreseason(d);
        d.Esports.ClubId = offer.ClubId; d.Credits += offer.SigningBonus; d.Esports.Offers.Clear();
        CareerCommerce.SignedClub(d, offer);
        CircuitWorld.AutoEntry(d);
        RefreshLeagueMatches(d);
        CareerLife.AddEvent(d, "contract-" + d.Season + "-" + d.Esports.ClubId, "转会", $"{CareerEngine.Name(d)}加盟{ClubName(d, d.Esports.ClubId)}", $"从{old}开启新篇章，签约奖励已经到账。{CareerCommerce.ClubTerms(offer)}", ["player"], true);
        CareerStore.Save(d); return null;
    }
    private static void TransferWindow(CareerData d)
    {
        int country = d.Season % Countries.Length;
        var roster = d.People.Where(p => IsProfessional(p) && p.Country == Countries[country]).OrderBy(p => p.Rating).ToList();
        var a = roster.First(p => p.ClubId == $"c{country}0"); var b = roster.First(p => p.ClubId == $"c{country}1");
        (a.ClubId, b.ClubId) = (b.ClubId, a.ClubId);
        CareerEngine.Publish(d, "transfer-" + d.Season, $"转会窗口：{a.PublicName}加盟{ClubName(d, a.ClubId)}", $"{Countries[country]}赛区完成阵容调整，{b.PublicName}同时转投{ClubName(d, b.ClubId)}。两支俱乐部都把国际赛事资格列为新赛季目标。", "转会", true, [a.Id, b.Id]);
    }
    public static string NextGoal(CareerData d) => d.Esports.EcosystemVersion >= 1 && d.Esports.License >= 3 && d.Esports.ClubId.Length > 0
        ? CareerEngine.NextMatch(d) is { } next ? $"下一场：{next.Event} · 第 {SeasonCalendar.Day(d, next.Day)} 天，日程已安排" : "本阶段赛事结束，推进日程迎接新赛季"
        : d.Esports.License switch
    {
        0 => "赢下街区杯，取得城市公开赛资格；通关后战平也能晋级。",
        1 => "赢下城市公开赛，取得青训选拔资格；通关后战平也能晋级。",
        2 => "通过青训选拔，争取职业资格和俱乐部合同。",
        _ when d.Esports.ClubId == "" => "签约一家俱乐部，参加国内职业联赛。",
        _ when PlayerLeague(d)?.PlayerEntered != true => "报名国内职业联赛 → 争取前二与国际赛事席位",
        _ => d.Season % 2 == 0 ? "联赛前二 + 生涯进阶八通关 → 国家队世界杯" : "联赛前二 → 洲际俱乐部冠军杯 → 世界纪录邀请"
    };
}
