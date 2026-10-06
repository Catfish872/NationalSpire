namespace NationalSpire;

/// <summary>扩充持久人物及关系，已有身份和当前赛程保持稳定。</summary>
public static class CircuitPeople
{
    private static readonly string[] Characters = ["铁甲战士", "静默猎手", "故障机器人", "亡灵契约师", "储君"];
    private static readonly string[][] Names = [
        ["山海竞技", "云帆竞技", "北辰竞技", "赤霄竞技"], ["青岚竞技", "朝凪竞技", "银杏竞技", "千羽竞技"],
        ["海潮竞技", "雪峰竞技", "苍穹竞技", "白昼竞技"], ["银杉竞技", "河谷竞技", "铁鹰竞技", "远山竞技"],
        ["晨露竞技", "虹桥竞技", "银泉竞技", "星河竞技"], ["赤金竞技", "海风竞技", "群星竞技", "飞鸟竞技"],
        ["白崖竞技", "红鹿竞技", "湖畔竞技", "橡树竞技"], ["荒原竞技", "蓝湾竞技", "高塔竞技", "曙光竞技"] ];
    public static void Ensure(CareerData d)
    {
        if (d.Esports.EcosystemVersion != 0) return;
        d.Esports.EcosystemVersion = 1;
        for (int country = 0; country < EsportsWorld.Countries.Length; country++)
        {
            string nation = EsportsWorld.Countries[country];
            d.Esports.Nations.Add(new() { Country = nation });
            for (int club = 0; club < 6; club++)
            {
                string id = $"c{country}{club}";
                if (EsportsWorld.Club(d, id) == null) d.Esports.Clubs.Add(new() { Id = id, Country = nation,
                    Name = RegionalOrganizations.ClubName(d, nation, id), Color = new[] { "dfb66f", "75c9bc", "8babd8", "cd92ac" }[club % 4],
                    Motto = new[] { "重视青训，也愿意等待新人成长", "凭稳定成绩争取国际赛场", "喜欢进攻，期待关键比赛的突破", "老将与新人共同争取下一座奖杯" }[club % 4] });
                var team = EsportsWorld.Club(d, id)!; CareerCommerce.ConfigureClub(d, team, true);
                int count = d.People.Count(p => p.ClubId == id && EsportsWorld.IsProfessional(p));
                for (int i = count; i < CareerCommerce.ProfessionalCount(d, id); i++) Add(d, $"tour-{id}-{i}", nation, id, i == 5 && team.Identity == "争冠强队" ? "世界顶尖" : "职业选手", i == 5 && team.Identity == "争冠强队" ? 9 : 8);
                int youth = d.People.Count(p => p.ClubId == id && p.Role == "青训选手");
                for (int i = youth; i < CareerCommerce.YouthCount(d, id); i++) Add(d, $"youth-{id}-{i}", nation, id, "青训选手", 6 + i % 2);
                Add(d, $"coach-{id}", nation, id, "教练", 7);
            }
            for (int i = d.People.Count(p => p.Country == nation && p.Role == "普通玩家"); i < 128; i++)
                Add(d, $"public-{country}-{i}", nation, "", "普通玩家", i % 4);
            foreach (string role in new[] { "主播", "解说员", "赛事记者", "退役选手" })
                for (int i = 0; i < 3; i++) Add(d, $"media-{country}-{role}-{i}", nation, "", role, role == "退役选手" ? 8 : 2 + i);
        }
        foreach (var p in d.People)
        {
            PersonalityLibrary.Ensure(d, p);
            int seed = CareerEngine.StableHash(p.Id + d.WorldId);
            if (p.Identities.Count == 0)
            {
                p.Identities.Add(p.Role);
                if (p.Role == "退役选手") p.Identities.Add(seed % 2 == 0 ? "解说员" : "主播");
                else if (seed % 7 == 0 && p.Role is "职业选手" or "青训选手" or "普通玩家") p.Identities.Add("视频作者");
            }
            if (p.SupportedClubId.Length == 0)
            {
                var clubs = d.Esports.Clubs.Where(c => c.Country == p.Country).ToList();
                if (clubs.Count > 0) p.SupportedClubId = clubs[seed % clubs.Count].Id;
            }
            if (p.Connections.Count == 0)
                p.Connections = d.People.Where(other => other.Id != p.Id && other.Country == p.Country && (p.ClubId.Length == 0 || other.ClubId == p.ClubId))
                    .OrderBy(other => CareerEngine.StableHash(p.Id + other.Id)).Take(2).Select(other => other.Id).ToList();
        }
        // 新人物单独补充资料，避免重新改写旧人物的风格。
    }
    private static void Add(CareerData d, string id, string country, string club, string role, int level)
    {
        if (CareerEngine.Person(d, id) != null) return;
        int seed = CareerEngine.StableHash(d.WorldId + id);
        d.People.Add(new() { Id = id, Name = WorldPeople.Name(d, id, country, role is "普通玩家" or "主播"), Country = country,
            ClubId = club, Region = country + (club.Length > 0 ? "职业赛区" : "社区"), Role = role, MaxAscension = level,
            Character = Characters[seed % 5], Style = WorldPeople.PlayingStyle(seed % 5, seed / 5), Rating = level >= 8 ? 1200 + seed % 350 : 630 + level * 55,
            Wins = level >= 6 ? 8 + seed % 30 : seed % 5, Losses = 40 + seed % 100,
            Biography = WorldPeople.Biography(role, seed) });
        NpcRecords.Initialize(d.People[^1], CareerEngine.StableHash(d.WorldId + ":records:" + id));
    }
    public static void SeasonChange(CareerData d)
    {
        if (d.Season <= 1 || d.Esports.LastRosterSeason >= d.Season) return;
        d.Esports.LastRosterSeason = d.Season;
        CareerCommerce.Operate(d);
        foreach (var club in d.Esports.Clubs.Where(c => c.Id != d.Esports.OwnedClub?.ClubId))
        {
            var youth = d.People.Where(p => p.ClubId == club.Id && p.Role == "青训选手").OrderByDescending(p => p.Rating).FirstOrDefault();
            if (youth == null) continue;
            // 已完成选拔认证的青训每四赛季获得轮换机会，老将转任教练或解说。
            if (d.Season % 4 == 0 && CareerEngine.StableHash(club.Id + d.Season) % 3 == 0)
            {
                var trial = MatchRules.Simulate(d, youth.Id, 8, d.WorldId + ":academy:" + youth.Id + d.Season);
                if (!trial.Cleared) { youth.Losses++; continue; }
                youth.Wins++;
                var veteran = d.People.Where(p => p.ClubId == club.Id && EsportsWorld.IsProfessional(p) && !OwnedClubs.TransferReserved(d, p.Id)).OrderBy(p => p.Rating).First();
                veteran.Role = "退役选手"; veteran.AbilityTemplate = ""; veteran.Identities = ["退役选手", "教练"];
                youth.Role = "职业选手"; if (youth.AbilityTemplate.Length > 0) youth.AbilityTemplate = "职业选手";
                youth.MaxAscension = 8; youth.Identities = ["职业选手", "青训出身"];
                youth.Connections = youth.Connections.Append(veteran.Id).Distinct().TakeLast(2).ToList();
                Add(d, $"academy-{club.Id}-{d.Season}", club.Country, club.Id, "青训选手", 6);
                PlayerIdentity.Ensure(d);
                var newcomer = d.People[^1]; PersonalityLibrary.Ensure(d, newcomer); newcomer.Identities = ["青训选手"];
                CircuitLedger.Remember(d, $"succession-{club.Id}-{d.Season}", $"{club.Name}的{veteran.PublicName}结束职业选手生涯并参与训练指导。{youth.PublicName}完成进阶8选拔认证，进入职业轮换阵容。", [veteran.Id, youth.Id]);
            }
        }
    }
}
