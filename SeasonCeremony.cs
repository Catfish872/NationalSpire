namespace NationalSpire;

public sealed class CeremonyRank
{
    public string Name { get; set; } = "";
    public int Place { get; set; }
    public bool Shared { get; set; }
    public List<string> Breakdown { get; set; } = [];
    public string Id { get; set; } = "";
    public int Score { get; set; }
    public int Matches { get; set; }
    public int Wins { get; set; }
    public int Clears { get; set; }
}

public sealed class CeremonyAward
{
    public string WinnerName { get; set; } = "";
    public List<string> Recipients { get; set; } = [];
    public string Title { get; set; } = "";
    public string WinnerId { get; set; } = "";
    public string ClubId { get; set; } = "";
    public int Score { get; set; }
    public string Reason { get; set; } = "";
}

public sealed class CeremonyRecord
{
    public int RulesVersion { get; set; }
    public List<CeremonyRank> FullSeason { get; set; } = [];
    public List<CeremonyRank> FullYear { get; set; } = [];
    public int Season { get; set; }
    public int Year { get; set; }
    public int Day { get; set; }
    public List<CeremonyRank> SeasonTop { get; set; } = [];
    public List<CeremonyRank> YearTop { get; set; } = [];
    public List<CeremonyAward> Awards { get; set; } = [];
}

public static class SeasonCeremony
{
    private static int Weight(string kind) => kind switch
    {
        "worldfinal" => 20, "worldcup" => 16, "continental" => 14,
        "league" => 10, _ => 8
    };

    public const string ScoringRules = "每场获胜10分、平局5分；通关另加5分，未通关每到达12层加1分、最多3分。联赛×1，洲际杯×1.4，世界杯×1.6，世界总决赛×2，其他正式赛事×0.8。加权后四舍五入；挑战进阶通关每提高一级另加2分、最多4分。弃权不计，同场只计一次。";
    public const string ClubRules = "俱乐部按整轮团队对抗计分：获胜3分、平局1分、全队通关另加1分。不同人数不重复计分；同分比较团队胜场、全队通关次数，仍相同则并列。";
    private static bool ProfessionalEvent(WorldCompetition c) => c.Kind is "league" or "continental" or "worldcup" or "worldfinal" or "masters";
    public static void EnsureDebuts(CareerData data)
    {
        if (data.DebutVersion >= 1) return;
        foreach (var p in data.People.Where(EsportsWorld.IsProfessional)) data.ProfessionalDebuts.TryAdd(p.Id, 0);
        foreach (var c in data.Esports.Competitions.Where(ProfessionalEvent).OrderBy(c => c.Season))
        foreach (var f in c.Fixtures.Where(f => f.Finished && !f.Walkover))
        foreach (var id in Participants(data,c,f,true).Concat(Participants(data,c,f,false)))
            if (id == "player" || data.HumanIds.Contains(id) || CareerEngine.Person(data,id)?.Identities.Contains("青训出身") == true)
                if (!data.ProfessionalDebuts.TryGetValue(id, out int season) || season == 0) data.ProfessionalDebuts[id] = c.Season;
        data.DebutVersion = 1;
    }
    public static List<string> Participants(CareerData d, WorldCompetition c, WorldFixture f, bool home)
    {
        var saved = home ? f.HomeParticipants : f.AwayParticipants;
        if (saved.Count > 0) return saved;
        string id = home ? f.HomeId : f.AwayId;
        if (id.Length == 0) return [];
        if (d.CooperativeMembers <= 1 && !c.Cooperative) return [id];
        if (id == "player") return d.MatchHumanIds.Count > 0 ? d.MatchHumanIds.ToList() : d.HumanIds.Count > 0 ? d.HumanIds.ToList() : [id];
        if (CareerEngine.Person(d, id) == null) return [id];
        return c.Rosters.Values.FirstOrDefault(r => r.Contains(id))?.ToList()
            ?? CircuitWorld.CooperativeRoster(d,c,id,f.Id).Select(p=>p.Id).ToList();
    }
    public static void RecordParticipants(CareerData d, WorldCompetition c, WorldFixture f)
    {
        EnsureDebuts(d);
        f.HomeParticipants = Participants(d,c,f,true).ToList(); f.AwayParticipants = Participants(d,c,f,false).ToList();
        if (!ProfessionalEvent(c)) return;
        foreach (string id in f.HomeParticipants.Concat(f.AwayParticipants))
            if (id == "player" || d.HumanIds.Contains(id) || !d.ProfessionalDebuts.ContainsKey(id)) d.ProfessionalDebuts.TryAdd(id,c.Season);
    }
    private static bool EqualRank(CeremonyRank a, CeremonyRank b) => a.Score == b.Score && a.Wins == b.Wins && a.Clears == b.Clears;
    private static List<CeremonyRank> Rank(CareerData data, Func<WorldCompetition, bool> includes)
    {
        var rows = new Dictionary<string, CeremonyRank>();
        var seen = new HashSet<string>();
        foreach (var competition in data.Esports.Competitions.Where(includes))
        foreach (var fixture in competition.Fixtures.Where(f => f.Finished && !f.Walkover))
        {
            if (!seen.Add(competition.Id + ":" + fixture.Id)) continue;
            foreach (bool home in new[] { true, false })
            {
                string representative = home ? fixture.HomeId : fixture.AwayId;
                bool clear = home ? fixture.HomeCleared : fixture.AwayCleared;
                int floor = home ? fixture.HomeFloor : fixture.AwayFloor;
                int baseScore = (fixture.WinnerId == representative ? 10 : fixture.Draw ? 5 : 0) + (clear ? 5 : Math.Clamp(floor / 12, 0, 3));
                int challenge = 0;
                if (representative == "player" && clear && data.Matches.FirstOrDefault(m=>m.FixtureId==fixture.Id) is { } match && match.PlayedAscension > fixture.Ascension)
                    challenge = Math.Min(4, (match.PlayedAscension.Value-fixture.Ascension)*2);
                var participants = Participants(data,competition,fixture,home);
                foreach (string id in participants.Distinct())
                {
                    if (!rows.TryGetValue(id,out var row)) rows[id] = row = new() { Id=id, Name=CareerEngine.DisplayName(data,id) };
                    int points = (baseScore * Weight(competition.Kind) + 5) / 10 + challenge;
                    row.Score += points; row.Matches++; row.Shared |= participants.Count > 1;
                    if (fixture.WinnerId == representative) row.Wins++;
                    if (clear) row.Clears++;
                    row.Breakdown.Add($"{competition.Name} · 第{fixture.Round}轮：基础{baseScore}×{Weight(competition.Kind)/10.0:0.0}，挑战加{challenge}，本场{points}分" + (participants.Count>1?"（共同成绩）":""));
                }
            }
        }
        var sorted = rows.Values.OrderByDescending(r=>r.Score).ThenByDescending(r=>r.Wins).ThenByDescending(r=>r.Clears).ThenBy(r=>r.Id,StringComparer.Ordinal).ToList();
        for(int i=0;i<sorted.Count;i++) sorted[i].Place = i>0 && EqualRank(sorted[i],sorted[i-1]) ? sorted[i-1].Place : i+1;
        return sorted;
    }
    private static CeremonyAward PersonAward(string title, CeremonyRank? row, string reason) => new() {Title=title, WinnerId=row?.Id??"",WinnerName=row?.Name??"",Score=row?.Score??0,Reason=reason,Recipients=row==null?[]:[row.Id]};
    private static void PeopleAwards(CeremonyRecord record,string title,IEnumerable<CeremonyRank> candidates,string reason)
    {
        var rows=candidates.ToList(); if(rows.Count==0) return;
        foreach(var row in rows.TakeWhile(r=>EqualRank(r,rows[0]))) record.Awards.Add(PersonAward(title,row,reason));
    }
    private static void ClubAwards(CareerData data,CeremonyRecord record,int first,int last,string title)
    {
        var rows=new Dictionary<string,CeremonyRank>();
        foreach(var c in data.Esports.Competitions.Where(c=>c.Season>=first&&c.Season<=last&&c.TeamEvent))
        foreach(var tie in c.Fixtures.GroupBy(f=>(f.Round,f.HomeTeam,f.AwayTeam)).Where(g=>g.Count()>=(c.Cooperative?1:3)&&g.All(f=>f.Finished)))
        {
            int home=tie.Count(f=>f.WinnerId==f.HomeId), away=tie.Count(f=>f.WinnerId==f.AwayId);
            foreach(bool side in new[]{true,false})
            {
                string id=side?tie.Key.HomeTeam:tie.Key.AwayTeam;
                if(!data.Esports.Clubs.Any(t=>t.Id==id))continue;
                if(!rows.TryGetValue(id,out var row))rows[id]=row=new(){Id=id};
                bool win=side?home>away:away>home, clear=tie.All(f=>side?f.HomeCleared:f.AwayCleared);
                row.Score+=(win?3:home==away?1:0)+(clear?1:0); if(win)row.Wins++;if(clear)row.Clears++;
            }
        }
        var ranked=rows.Values.OrderByDescending(r=>r.Score).ThenByDescending(r=>r.Wins).ThenByDescending(r=>r.Clears).ToList();
        if(ranked.Count==0)return;
        foreach(var row in ranked.TakeWhile(r=>EqualRank(r,ranked[0])))
        {
            var humans=data.CooperativeMembers>1?data.HumanIds:new List<string>{"player"};
            var recipients=humans.Where(id=>data.Esports.Competitions.Any(c=>c.Season>=first&&c.Season<=last&&c.EntrantClubs.GetValueOrDefault(id=="player"||data.HumanIds.Contains(id)?"player":id)==row.Id&&c.Fixtures.Any(f=>f.Finished&&!f.Walkover&&(f.HomeId=="player"||f.AwayId=="player")))).ToList();
            record.Awards.Add(new(){Title=title,ClubId=row.Id,WinnerName=EsportsWorld.ClubName(data,row.Id),Score=row.Score,Reason=ClubRules,Recipients=recipients});
        }
    }
    private static IEnumerable<CeremonyRank> Rookies(CareerData data, List<CeremonyRank> ranks, int first, int last)
    {
        var appearances = new Dictionary<string, int>();
        foreach (var c in data.Esports.Competitions.Where(c => ProfessionalEvent(c) && c.Season >= first && c.Season <= last))
        foreach (var f in c.Fixtures.Where(f => f.Finished && !f.Walkover).DistinctBy(f => f.Id))
        foreach (string id in Participants(data, c, f, true).Concat(Participants(data, c, f, false)).Distinct())
            appearances[id] = appearances.GetValueOrDefault(id) + 1;
        return ranks.Where(r => appearances.GetValueOrDefault(r.Id) >= 2 && data.ProfessionalDebuts.TryGetValue(r.Id, out int season) && season >= first && season <= last);
    }

    public static CeremonyRecord Capture(CareerData data, int season)
    {
        int year = CircuitLedger.Year(season);
        EnsureDebuts(data);
        var record = new CeremonyRecord { Season=season,Year=year,Day=data.Day,RulesVersion=2 };
        var ranks=Rank(data,c=>c.Season==season); record.FullSeason=ranks; record.SeasonTop=ranks.Where(r=>r.Place<=20).ToList();
        PeopleAwards(record,"赛季最佳选手",ranks.Where(r=>r.Matches>=2),"本赛季正式比赛综合表现第一。同成绩并列。");
        foreach(var league in data.Esports.Competitions.Where(c=>c.Season==season&&c.Kind=="league"))
            PeopleAwards(record,"联赛 MVP",Rank(data,c=>c.Id==league.Id).Where(r=>r.Matches>=2),league.Name+"正式比赛表现第一。同成绩并列。");
        PeopleAwards(record,"赛季最佳新秀",Rookies(data,ranks,season,season),"本赛季首次参加职业比赛，至少出场两次。");
        ClubAwards(data,record,season,season,"赛季最佳俱乐部");
        if(season%4==0)
        {
            var annual=Rank(data,c=>c.Season>=season-3&&c.Season<=season); record.FullYear=annual;record.YearTop=annual.Where(r=>r.Place<=20).ToList();
            PeopleAwards(record,"年度最佳选手",annual,"全年正式比赛综合表现第一。同成绩并列。");
            PeopleAwards(record,"年度最佳新秀",Rookies(data,annual,season-3,season),"今年首次参加职业比赛，至少出场两次。");
            ClubAwards(data,record,season-3,season,"年度最佳俱乐部");
        }
        return record;
    }
    public static int RewardAmount(CeremonyAward a) => a.Title.StartsWith("年度")?240:90;
    public static string RewardKey(CeremonyRecord r,CeremonyAward a) => $"ceremony-{r.Season}-{a.Title}-{a.WinnerId}-{a.ClubId}";
    public static void Close(CareerData data)
    {
        if(data.Ceremonies.Any(c=>c.Season==data.Season))return;
        var ceremony=Capture(data,data.Season);data.Ceremonies.Add(ceremony);data.PendingCeremonySeason=data.Season;
        EnsureWeeklyCovers(data);
        if(data.CooperativeMembers>1)return;
        foreach(var a in ceremony.Awards.Where(a=>a.WinnerId=="player"||a.Recipients.Contains("player")))
        {
            string key=RewardKey(ceremony,a); if(!data.CeremonyRewardReceipts.Add(key))continue;
            data.Fans+=RewardAmount(a); data.Esports.Honors.Add(new(){Id=key,Season=data.Season,Day=data.Day,Title=a.Title,Detail=a.Reason});
        }
        var top=ceremony.YearTop.FirstOrDefault(r=>r.Id=="player");
        if(top!=null && data.CeremonyRewardReceipts.Add($"top20-{ceremony.Season}"))
        { data.Fans+=120; data.Esports.Honors.Add(new(){Id=$"top20-{ceremony.Season}",Season=data.Season,Day=data.Day,Title=$"年度 TOP 20 · 第{top.Place}名",Detail=$"年度评选{top.Score}分。"}); }
    }

    // 季末周刊先结刊、随后才颁奖，因此将封面补入刚结刊的当期，而不等待下一期。
    public static bool EnsureWeeklyCovers(CareerData data)
    {
        bool changed = false;
        foreach (var record in data.Ceremonies)
        {
            int end = record.Day % 14 == 1 ? record.Day - 1 : (record.Day + 13) / 14 * 14;
            var issue = data.WeeklyEditions.FirstOrDefault(w => w.EndDay == end);
            if (issue == null) continue;
            var slide = issue.Slides.FirstOrDefault(s => s.CeremonySeason == record.Season)
                ?? issue.Slides.FirstOrDefault(s => s.Topic == "赛季颁奖盛典" && s.Facts.StartsWith($"第{record.Season}赛季颁奖结果"));
            bool update = false;
            if (slide == null)
            {
                slide = CreateWeeklyCover(data, record); issue.Slides.Insert(0, slide); update = true;
            }
            else
            {
                if (slide.CeremonySeason == 0)
                {
                    var cover = CreateWeeklyCover(data, record);
                    slide.CeremonySeason = record.Season;
                    if (slide.Title.Length == 0) slide.Title = cover.Title;
                    if (slide.Body.Length == 0) slide.Body = cover.Body;
                    update = true;
                }
                if (issue.Slides.IndexOf(slide) != 0) { issue.Slides.Remove(slide); issue.Slides.Insert(0, slide); update = true; }
            }
            if (update) { issue.Revision++; changed = true; }
        }
        return changed;
    }

    public static WeeklySlide CreateWeeklyCover(CareerData data, CeremonyRecord record)
    {
        bool annual = record.YearTop.Count > 0;
        string title = annual ? $"第 {record.Year} 年度荣誉揭晓" : $"第 {record.Season} 赛季荣誉揭晓";
        string winners = string.Join("\n\n", record.Awards.OrderByDescending(a => a.Title.StartsWith("年度")).Select(a =>
            a.Title + " · " + (a.WinnerName.Length > 0 ? a.WinnerName : a.ClubId.Length > 0 ? EsportsWorld.ClubName(data, a.ClubId) : CareerEngine.DisplayName(data, a.WinnerId))
            + $"\n评选得分 {a.Score}。{a.Reason}"));
        string leaders = annual ? "\n\n年度 TOP 20 已公布\n" + string.Join("\n", record.YearTop.Take(3).Select((r, i) =>
            $"第 {(r.Place > 0 ? r.Place : i + 1)} 名  {(r.Name.Length > 0 ? r.Name : CareerEngine.DisplayName(data, r.Id))} · {r.Score} 分")) : "";
        return new WeeklySlide { Id = "ceremony-" + record.Season, CeremonySeason = record.Season,
            Topic = "赛季颁奖盛典", Character = "储君", Importance = 3, Title = title,
            Body = title + "。\n\n" + (winners.Length > 0 ? winners : "本季参赛记录已经归档，本届尚无符合条件的获奖者。") + leaders,
            Facts = $"第{record.Season}赛季颁奖结果。" + winners + leaders,
            People = record.Awards.Select(a => a.WinnerId).Where(id => id.Length > 0).Distinct().ToList() };
    }

    // 预览只构造界面数据，不改变赛果、奖项或关注数。
    public static CeremonyRecord Preview(CareerData data)
    {
        int year = CircuitLedger.Year(data.Season);
        var sample = new CeremonyRecord { Season = year * 4, Year = year, Day = data.Day };
        sample.SeasonTop.Add(new() { Id = "player", Score = 148, Matches = 10, Wins = 8, Clears = 7 });
        sample.YearTop.Add(new() { Id = "player", Score = 482, Matches = 32, Wins = 27, Clears = 24 });
        int score = 139;
        foreach (var person in data.People.Where(p => EsportsWorld.IsProfessional(p)).Take(19))
        {
            sample.SeasonTop.Add(new() { Id = person.Id, Score = score, Matches = 10, Wins = 7, Clears = 6 });
            sample.YearTop.Add(new() { Id = person.Id, Score = score * 3, Matches = 30, Wins = 20, Clears = 18 });
            score -= 5;
        }
        sample.Awards.Add(PersonAward("赛季最佳选手", sample.SeasonTop[0], "本赛季正式比赛综合表现第一。"));
        sample.Awards.Add(PersonAward("联赛 MVP", sample.SeasonTop[0], "仅计算本赛季职业联赛的正式对局。"));
        sample.Awards.Add(PersonAward("年度最佳选手", sample.YearTop[0], "全年正式比赛综合得分第一。"));
        sample.Awards.Add(new() { Title = "年度最佳俱乐部", ClubId = data.Esports.ClubId, Score = 52,
            Reason = "团队正式对局按获胜、战平与通关累计。" });
        return sample;
    }
}
