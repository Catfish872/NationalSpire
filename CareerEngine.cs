namespace NationalSpire;

public static class CareerEngine
{
    public const string RandomCharacterChoice = "__random__";
    public static Func<string> PlayerNameSource { get; set; } = () => "参赛选手";
    public static string PlayerName { get { try { var name = PlayerNameSource(); return string.IsNullOrWhiteSpace(name) ? "参赛选手" : name; } catch { return "参赛选手"; } } }
    public static bool NormalizeRoster(CareerData data)
    {
        CareerMigration.UpgradeRules(data);
        EsportsWorld.Initialize(data);
        WorldPeople.Enrich(data);
        CircuitPeople.Ensure(data);
        OwnedClubs.EnsureMarket(data);
        CareerCommerce.Upgrade(data);
        SeasonCalendar.Upgrade(data);
        CareerLife.Ensure(data);
        bool changed = CircuitPeople.Replenish(data);
        changed |= EsportsWorld.ClearInvalidRegistrations(data);
        if (data.Esports.Competitions.Any(c => c.Season == data.Season && c.Modern)) CircuitWorld.EnsureOpenEvents(data);
        PlayerIdentity.Ensure(data);
        CameoContent.Ensure(data);
        NpcRecords.Ensure(data);
        PersonalityLibrary.EnsureAll(data);
        foreach (var person in data.People.Concat(data.Posts.Concat(data.SavedThreads).SelectMany(p => p.PeopleAtEvent)))
            person.Style = person.Style.Replace("星能", "辉星", StringComparison.Ordinal);
        if (data.Esports.Competitions.Any(c => c.Season == data.Season && c.Modern)) CircuitWorld.AutoEntry(data);
        EsportsWorld.RefreshLeagueMatches(data);
        WeeklyJournal.Initialize(data);
        AvatarHonors.Capture(data);
        return changed;
    }
    public static CareerData CreateNew(bool expanded = true, int cooperativeMembers = 1)
    {
        var data = new CareerData { CooperativeMembers = cooperativeMembers, LongSeasonsFrom = expanded ? 1 : 0, ContentPoolVersion = ContentPoolMigration.Version };
        // 旧赛制用于存档兼容回归；正常新生涯启用完整生态。
        if (!expanded) data.Esports.EcosystemVersion = -1;
        string[] characters = ["铁甲战士", "静默猎手", "故障机器人", "亡灵契约师", "储君"];
        string[] styles = ["偏爱力量与高费攻击", "偏爱中毒", "偏爱充能球", "依赖奥斯蒂", "重视辉星"];
        for (int i = 0; i < 22; i++)
        {
            int level = i < 10 ? i % 4 : i < 16 ? 6 + i % 2 : i == 21 ? 9 : 8;
            data.People.Add(new CareerPerson { Id = "p" + i, Name = WorldPeople.Name(data, "p" + i, "中国", i < 10), Country = "中国", Region = i < 10 ? "本地社区" : "国内赛区", Character = characters[i % 5], Style = styles[i % 5], MaxAscension = level,
                Wins = i < 10 ? i % 3 : 5 + i / 2, Losses = 24 + i * 3, Rating = 680 + level * 76 + i * 4,
                Role = level >= 9 ? "世界顶尖" : level >= 8 ? "职业选手" : level >= 6 ? "青训选手" : "普通玩家",
                Voice = new[] { "谨慎，喜欢引用战绩", "热情，容易放大单次表现", "偏爱本赛区选手，会承认对手的好成绩" }[i % 3] });
        }
        EsportsWorld.Initialize(data);
        WorldPeople.Enrich(data);
        if (expanded)
        {
            CircuitPeople.Ensure(data);
        OwnedClubs.EnsureMarket(data);
            CareerCommerce.Upgrade(data);
            PlayerIdentity.Ensure(data);
            data.Esports.Competitions.Clear(); data.Matches.Clear();
            CareerLife.Ensure(data);
            CameoContent.Ensure(data);
            CircuitWorld.StartSeason(data);
            var announcement = data.Posts.FirstOrDefault(p => p.EventKey == "ecosystem");
            if (announcement != null)
            {
                announcement.Body = "新赛季从社区选拔走向职业舞台。每个赛区六家俱乐部参加五轮团队联赛，个人表现前二进入世界总决赛，俱乐部前二取得洲际杯席位。每两个赛季举办国家队世界杯。国际赛事成绩将计入国运榜，支持选手、俱乐部和青训发展。";
                CommunityThreads.Remember(data, announcement);
            }
        }
        PlayerIdentity.Ensure(data);
        PersonalityLibrary.EnsureAll(data);
        NpcRecords.Ensure(data);
        WeeklyJournal.Initialize(data);
        AvatarHonors.Capture(data);
        return data;
    }
    public static CareerMatch? NextMatch(CareerData d) => d.Matches.Where(m => m.Status == "待赛" && m.Registered).OrderBy(m => m.Day).ThenByDescending(m => m.CompetitionId.Length > 0).FirstOrDefault();
    public static CareerMatch? NextAvailable(CareerData d) => d.Matches.FirstOrDefault(m => m.Status == "待赛" && m.Day >= d.Day && EsportsWorld.EntryReason(d, m) == null);
    public static CareerPerson? Person(CareerData d, string id) => d.People.FirstOrDefault(p => p.Id == id) ?? d.DeletedPeople.GetValueOrDefault(id);
    public static string Name(CareerData d) => string.IsNullOrWhiteSpace(d.PlayerAlias) ? PlayerName : d.PlayerAlias;
    public static string DisplayName(CareerData d, string id) => id == "player" ? Name(d) : Person(d, id)?.PublicName ?? "待抽签";

    public static bool AdvanceOneDay(CareerData d)
    {
        if (d.Failure != null || d.PendingMatchId != null || NextMatch(d) is { } next && next.Day <= d.Day) return false;
        MoveToNextDay(d); PublishMatchDay(d); CareerStore.Save(d); return true;
    }
    private static void MoveToNextDay(CareerData d)
    {
        foreach (var missed in d.Matches.Where(m => m.Status == "待赛" && !m.Registered && m.Day <= d.Day)) missed.Status = "未报名";
        EsportsWorld.EndDay(d, d.Day);
        // 先把这一段里被跳过的周报补齐（读档跳天、回滚存档都可能导致缺期），再推进日期。
        WeeklyJournal.ClosePending(d, d.Day);
        d.Day++;
        SocialAppointments.Expire(d);
        // 实时社区弹幕每 7 个生涯日清理一次过时条目：社区话题一周后基本就凉了，
        // 旧条目留着会一直占着加权抽取的名额，让弹幕和当前局势脱节。
        // 放在日期推进处（而不是局内更新里），这样不依赖 AI 当前是否在跑、也不要求玩家正在打比赛。
        AiDanmakuStore.PurgeStale(d.Day);
        if (d.Day > SeasonCalendar.End(d))
        {
            AwardSeason(d); d.Season++;
            d.Matches.RemoveAll(m => m.Day <= SeasonCalendar.Start(d, Math.Max(1, d.Season - 3)));
            EsportsWorld.StartSeason(d);
            Publish(d, "season-" + d.Season, $"第 {d.Season} 赛季开幕", d.Season % 2 == 0 ? "国家队世界杯赛季正式开启。各国职业联赛将决定代表候选人，职业圈开始争夺国家队名单。" : "新赛程已经公布。国内联赛、洲际俱乐部冠军杯和转会窗口同步开启，世界各地的选手重新出发。", "赛季", true);
        }
        if (d.CooperativeMembers <= 1) CareerLife.Advance(d);
        ClubOperations.Advance(d);
        OwnedClubs.Advance(d);
        CareerLife.PublishPending(d);
        SimulateWorld(d);
        AvatarHonors.Capture(d);
        CareerCommerce.RefreshOffers(d);
        if (d.Esports.EcosystemVersion >= 1) CircuitWorld.AutoEntry(d);
        // 世界赛状态在这天所有赛事结算完之后刷新：开始时置 true，结束时置 false。
        WorldStage.Refresh(d);
    }
    public static int AdvanceToMatch(CareerData d)
    {
        var next = NextMatch(d); if (next == null) return 0;
        return AdvanceToDay(d, next.Day);
    }
    public static int AdvanceToDay(CareerData d, int target)
    {
        int count = 0;
        try
        {
            while (d.Day < target && count < 84 && d.Failure == null && d.PendingMatchId == null && !(NextMatch(d) is { } next && next.Day <= d.Day))
            { MoveToNextDay(d); count++; if (SocialAppointments.Due(d).Any()) break; }
        }
        finally { if (count > 0) { PublishMatchDay(d); PublicationBacklog.Compact(d); CareerStore.Save(d); } }
        return count;
    }
    public static void PublishMatchDay(CareerData d)
    {
        EsportsWorld.ClearInvalidRegistrations(d);
        var match = NextMatch(d);
        if (d.PendingMatchId != null || match == null || match.Day != d.Day || match.Kind == "private-friendly") return;
        string key = "prematch-" + match.Id;
        if (CommunityThreads.All(d).Any(p => p.EventKey == key)) return;
        var opponent = Person(d, match.OpponentId);
        string title = $"{match.Event}今日开赛，{Name(d)}对阵{opponent?.PublicName ?? "待公布对手"}";
        string body = $"第{d.Day}天，{match.Event}即将进行。{Name(d)}已报名，对手为{opponent?.PublicName ?? "待公布对手"}，赛事进阶{match.RequiredAscension}。比赛尚未开始，暂无本场赛果。";
        if (d.CooperativeMembers > 1) body += $"双方以{d.CooperativeMembers}人队伍参赛。";
        Publish(d, key, title, body, "赛前讨论", true, ["player", match.OpponentId]);
    }
    public static bool ExcludedAutomaticPreview(CareerData d, CommunityPost post)
    {
        if (!post.EventKey.StartsWith("prematch-", StringComparison.Ordinal)) return false;
        var match = d.Matches.FirstOrDefault(m => post.EventKey == "prematch-" + m.Id);
        if (post.MatchKind == "private-friendly" || match?.Kind == "private-friendly") return true;
        return match is { Registered: false, Status: "待赛", Kind: "local" or "city" or "academy" }
            && EsportsWorld.EntryReason(d, match) != null;
    }
    public static string? SetRegistration(CareerData d, CareerMatch match, bool registered)
    {
        if (MatchFailure.Locked(d) is { } failure) return failure;
        if (!d.Matches.Contains(match) || match.Status != "待赛" || match.Day < d.Day || d.PendingMatchId != null) return "比赛已经关闭，或当前对局尚未结束。";
        var error = EsportsWorld.Register(d, match, registered);
        if (error == null) CareerStore.Save(d);
        return error;
    }
    private static void SimulateWorld(CareerData d)
    {
        var rng = new Random(StableHash($"{d.WorldId}:world:{d.Day}"));
        for (int i = 0; i < 2; i++)
        {
            var eligiblePeople = d.People.Where(p => !d.HumanIds.Contains(p.Id)).ToList();
            var person = eligiblePeople[rng.Next(eligiblePeople.Count)];
            if (person.Role is "赛事记者" or "解说员") continue;
            int asc = rng.Next(Math.Max(1, person.MaxAscension + 1));
            var practice = MatchRules.Simulate(d, person.Id, asc, d.WorldId + ":practice:" + d.Day + ":" + i);
            bool win = practice.Cleared;
            if (win) person.Wins++; else person.Losses++;
            if (d.Esports.EcosystemVersion < 1 && d.Day % 4 == 0 && i == 0)
            {
                string result = win ? $"在进阶 {asc} 完成通关" : $"在进阶 {asc} 第 {practice.Floor} 层止步";
                Publish(d, "practice-" + d.Day, $"{person.Country}社区：{person.PublicName}的训练日", $"{person.PublicName}{result}。这是一场日常训练，不计入正式比赛积分。", "训练日常", true, [person.Id]);
            }
        }
        if (d.Esports.EcosystemVersion >= 1) { WorldEvents.Advance(d); return; }
        if (d.Day % 7 == 2)
        {
            var p = d.People.Where(EsportsWorld.IsProfessional).OrderBy(p => StableHash(p.Id + d.Day)).First();
            Publish(d, "feature-" + d.Day, $"人物观察：{EsportsWorld.ClubName(d, p.ClubId)}的{p.PublicName}", CareerNarrative.Feature(d, p), "人物专访", true, [p.Id]);
        }
        if (d.Esports.EcosystemVersion >= 1 && d.Day % 7 == 5) WorldActivity(d, rng);
    }
    private static void WorldActivity(CareerData d, Random rng)
    {
        var club = d.Esports.Clubs[rng.Next(d.Esports.Clubs.Count)];
        var members = d.People.Where(p => p.ClubId == club.Id && EsportsWorld.IsProfessional(p)).ToList();
        if (members.Count == 0) return;
        var person = members[rng.Next(members.Count)];
        var league = d.Esports.Competitions.FirstOrDefault(c => c.Season == d.Season && c.Kind == "league" && c.Country == club.Country);
        var upcoming = league?.Fixtures.FirstOrDefault(f => f.Day >= d.Day && (f.HomeTeam == club.Id || f.AwayTeam == club.Id));
        string date = upcoming == null ? "俱乐部进入休整阶段。" : $"下一轮联赛安排在第{upcoming.Day}天。";
        (string title, string body) = rng.Next(5) switch
        {
            0 => ($"{club.Name}开放训练室", $"{person.PublicName}参加俱乐部公开训练，分享{person.Character}的练习经历。{date}"),
            1 => ($"{club.Name}举办青训交流日", $"{person.PublicName}与俱乐部青训队一起复盘{person.Character}的常用构筑。交流围绕其惯用方式展开：{person.Style}。"),
            2 => ($"{club.Country}赛区应援活动", $"{club.Name}举办观赛交流，{person.PublicName}参与观众问答。{date}"),
            3 => ($"{person.PublicName}参加赛区访谈", $"{person.PublicName}介绍在{club.Name}的训练安排，目前最高通关进阶{person.MaxAscension}，近期正式赛状态：{(person.Form.Length > 0 ? person.Form : "等待新赛程")}。{date}"),
            _ => ($"{club.Name}发布训练室日记", $"{person.PublicName}担任本期训练室记录人，主题为{person.Character}的选牌习惯。其偏好是{person.Style}。{date}")
        };
        // 世界事件独立留存，关闭 AI 时仍可进入双周刊的事实检索。
        d.CommunityMemories.Add(new() { Id = "activity:" + d.Day, Day = d.Day, Kind = "fact", People = [person.Id], Text = title + "：" + body });
        Publish(d, "activity-" + d.Day, title, body, "俱乐部动态", true, [person.Id]);
    }
    public static double WinChance(int ascension, int skill)
    {
        skill = Math.Clamp(skill, 0, 10);
        if (ascension >= 10) return skill >= 10 ? .0008 : skill >= 9 ? .0003 : .00001;
        if (ascension == 9) return skill >= 9 ? .018 : skill >= 8 ? .0015 : .0001;
        if (ascension == 8) return skill >= 9 ? .48 : skill == 8 ? .16 : skill == 7 ? .065 : skill == 6 ? .025 : .003;
        if (ascension == 7) return skill >= 9 ? .73 : skill == 8 ? .55 : skill == 7 ? .40 : skill == 6 ? .22 : .06;
        if (skill >= 6) return Math.Clamp(.50 + (skill - 6) * .08 + (6 - ascension) * .085, .01, .92);
        double local = skill switch { 0 => .56, 1 => .49, 2 => .44, 5 => .43, _ => .42 };
        return Math.Clamp(local + (skill - ascension) * .09, .03, .88);
    }
    public static void FinishMatch(CareerData d, CareerMatch m, bool runClear, bool abandoned, int floor, string character, int ascension, List<string> cards, double runSeconds, List<string>? deckSummary = null, RunEvidence? evidence = null, string characterId = "", bool forfeit = false, bool confirmFailure = false)
    {
        // 局内放弃按未通关及当前层数比较成绩；未出场退赛由大厅显式传入。
        runClear = runClear && !abandoned && !forfeit;
        if (d.Failure != null && !confirmFailure) return;
        if (!d.Matches.Contains(m) || m.Status != "待赛" || !m.Registered || m.Day != d.Day || ascension < m.RequiredAscension || ascension > 10) return;
        var opponent = Person(d, m.OpponentId); if (opponent == null) return;
        if (!double.IsFinite(runSeconds) || runSeconds < 0 || runClear && !forfeit && runSeconds == 0) return;
        int settledSeason = d.Season;
        var honorsBefore = d.Esports.Honors.Select(h => h.Title).ToHashSet();
        var postsBeforeResult = d.Posts.Select(p => p.Id).ToHashSet();
        MatchRules.PrepareOpponent(d, m);
        m.PlayerFloor = Math.Max(0, floor); m.PlayedAscension = ascension; m.PlayerSeconds = Math.Round(runSeconds, 3);
        int comparison = forfeit ? -1 : MatchRules.Compare(new(runClear, m.PlayerFloor, m.PlayerSeconds.Value),
            new(m.OpponentWon, m.OpponentFloor, m.OpponentSeconds!.Value));
        m.Draw = comparison == 0;
        m.PlayerWon = comparison > 0;
        if (!confirmFailure && !forfeit && comparison < 0)
        {
            if (d.Failure != null) return;
            d.Failure = new() { Abandoned = abandoned, Result = new() { MatchId = m.Id, Kind = m.Kind,
                CompetitionId = m.CompetitionId, OpponentId = m.OpponentId, Opponent = opponent.PublicName,
                Day = d.Day, Event = m.Event, Outcome = "失利", Character = character, CharacterId = characterId,
                Ascension = m.RequiredAscension, PlayedAscension = ascension, RunSeconds = m.PlayerSeconds,
                Win = runClear, Floor = floor, Seed = m.Seed, Cards = cards, DeckSummary = deckSummary ?? [], Evidence = evidence ?? new() } };
            d.PendingMatchId = null; d.PendingSince = 0;
            CareerStore.Save(d); return;
        }
        if (runClear && !forfeit) d.AvatarHighestClear = Math.Max(d.AvatarHighestClear, ascension);
        if (CircuitWorld.ReplayTie(d, m)) return;
        m.Decider = runClear && m.OpponentWon && !forfeit ? "双方通关，按游戏记录的通关用时比较，较快者获胜。" : "";
        EsportsWorld.BreakKnockoutTie(d, m);
        m.Status = forfeit ? "退赛" : "已结算";
        if (PrivateAppointments.IsPrivate(m))
        {
            NpcRecords.RecordPrivateClear(d, m);
            var friendly = new CareerResult { MatchId = m.Id, Kind = m.Kind, OpponentId = m.OpponentId, Outcome = forfeit ? "退赛" : m.Draw ? "平局" : m.PlayerWon ? "获胜" : "失利",
                Day = d.Day, Event = m.Event, Opponent = opponent.PublicName, Character = character, CharacterId = characterId, Ascension = m.RequiredAscension,
                PlayedAscension = ascension, RunSeconds = m.PlayerSeconds, Win = runClear && !forfeit, Floor = floor, Seed = m.Seed, Cards = cards,
                DeckSummary = deckSummary ?? [], Evidence = evidence ?? new() };
            d.Results.Add(friendly); d.PendingMatchId = null; d.PendingSince = 0;
            if (m.Kind == "private-challenge") Publish(d, "match" + m.Id, m.Event + " · " + friendly.Outcome, MatchRules.Report(m, friendly, d.CooperativeMembers > 1), "约战", true, [m.OpponentId], m);
            if (!d.Matches.Any(game => game.Registered && game.Status == "待赛" && game.Day == d.Day)) MoveToNextDay(d);
            friendly.Settlement = SettlementRecords.Capture(d, m, settledSeason); d.PendingSettlementId = m.Id;
            CareerStore.Save(d); return;
        }
        int rating = d.Rating, fans = d.Fans, credits = d.Credits;
        int weight = m.Kind switch { "league" => 2, "continental" => 4, "worldcup" => 6, "worldfinal" => 8, "masters" => 8, _ => 1 };
        double multiplier = forfeit ? 1 : MatchRules.RewardMultiplier(m.RequiredAscension, ascension);
        if (m.PlayerWon) { d.Wins++; d.Rating += 20 + m.RequiredAscension * 3; d.Fans += MatchRules.Reward(weight * (25 + m.RequiredAscension * 12), multiplier); d.Credits += MatchRules.Reward(m.Prize, multiplier); }
        else if (m.Draw) { d.Draws++; d.Rating += 8; d.Fans += MatchRules.Reward(weight * 15, multiplier); d.Credits += MatchRules.Reward(m.Prize / 2, multiplier); }
        else { d.Losses++; d.Rating = Math.Max(500, d.Rating - 7); if (!forfeit) d.Fans += Math.Max(3, floor / 3); }
        EsportsWorld.ResolvePlayerFixture(d, m, runClear && !forfeit, forfeit);
        if (m.CompetitionId == "")
        {
            if (m.OpponentWon) { opponent.Wins++; opponent.MaxAscension = Math.Max(opponent.MaxAscension, m.RequiredAscension); }
            else opponent.Losses++;
            opponent.Rating = Math.Clamp(opponent.Rating + (m.Draw ? 2 : m.PlayerWon ? -5 : 12), 500, 2100);
            opponent.Form = opponent.Form + (m.Draw ? "平" : m.PlayerWon ? "负" : "胜");
            if (opponent.Form.Length > 5) opponent.Form = opponent.Form[^5..];
        }
        EsportsWorld.AfterPlayerMatch(d, m, runClear, forfeit);
        CircuitLedger.PlayerMatch(d, m);
        CircuitWorld.AutoEntry(d);
        string verdict = forfeit ? "退赛" : m.Draw ? "平局" : m.PlayerWon ? "获胜" : "失利";
        var record = new CareerResult { MatchId = m.Id, Kind = m.Kind, CompetitionId = m.CompetitionId, OpponentId = m.OpponentId, Outcome = verdict, Day = d.Day, Event = m.Event, Opponent = opponent.PublicName, Character = character, CharacterId = characterId, Ascension = m.RequiredAscension, PlayedAscension = ascension, RunSeconds = m.PlayerSeconds, RewardMultiplier = multiplier, Win = runClear && !forfeit, Floor = floor, Seed = m.Seed, Cards = cards };
        d.Results.Add(record);
        record.DeckSummary = deckSummary ?? [];
        record.Evidence = evidence ?? new();
        CareerRelics.Match(d, m, record, forfeit, rating);
        record.RatingDelta = d.Rating - rating;
        Publish(d, "match" + m.Id, $"{m.Event}：你对阵{opponent.PublicName}，{verdict}", MatchRules.Report(m, record, d.CooperativeMembers > 1), EsportsWorld.StageName(m.Kind), true, [m.OpponentId], m);
        // 同一场比赛带来的资格与荣誉放进同一份战报材料，减少重复选题。
        var resultPost = d.Posts.FirstOrDefault(p => p.EventKey == "match" + m.Id);
        var related = d.Posts.Where(p => !postsBeforeResult.Contains(p.Id) && p != resultPost && p.Day == m.Day
            && (p.EventKey.StartsWith("honor-") || p.EventKey.StartsWith("qualification-") || p.EventKey == "champion-" + m.CompetitionId)).ToList();
        if (resultPost != null && related.Count > 0)
        {
            resultPost.RelatedFacts = string.Join("\n", related.Select(p => p.SourceTitle + "：" + p.SourceBody));
            resultPost.SourceBody += "\n" + resultPost.RelatedFacts;
            foreach (var extra in related) d.Posts.Remove(extra);
            CommunityThreads.Remember(d, resultPost);
        }
        record.RatingDelta = d.Rating - rating; record.FansDelta = d.Fans - fans; record.Prize = d.Credits - credits;
        d.Life.PrizeTotal += m.PlayerWon ? MatchRules.Reward(m.Prize, multiplier) : m.Draw ? MatchRules.Reward(m.Prize / 2, multiplier) : 0;
        CareerMoney.Record(d, m.Event + "赛后结算（含合同及荣誉收入）", record.Prize);
        d.PendingMatchId = null; d.PendingSince = 0;
        // 同日自愿报名与正式席位可以并存，完成当天全部已报名比赛后再推进日期。
        if (!d.Matches.Any(game => game.Registered && game.Status == "待赛" && game.Day == d.Day)) MoveToNextDay(d);
        record.WorldImpact = CircuitLedger.MatchImpact(d, m);
        if (record.WorldImpact.Length > 0 && d.Posts.FirstOrDefault(p => p.EventKey == "match" + m.Id) is { } matchPost)
        {
            matchPost.Body += record.WorldImpact; matchPost.SourceBody += record.WorldImpact; matchPost.Revision++;
            CommunityThreads.Remember(d, matchPost);
        }
        record.Settlement = SettlementRecords.Capture(d, m, settledSeason);
        record.Settlement.Honors = d.Esports.Honors.Where(h => !honorsBefore.Contains(h.Title)).Select(h => h.Title).Take(4).ToList();
        d.PendingSettlementId = m.Id;
        CommunityThreads.RememberMatch(d, record);
        AvatarHonors.Capture(d);
        if (d.Results.Count > 200) d.Results.RemoveRange(0, d.Results.Count - 200);
        CareerStore.Save(d);
    }
    public static void Forfeit(CareerData d, CareerMatch m)
    {
        if (d.Failure != null || d.PendingMatchId != null) return;
        FinishMatch(d, m, false, false, 0, "未出场", m.RequiredAscension, [], 0, forfeit: true);
    }
    public static void Publish(CareerData d, string key, string title, string body, string category, bool aiPending, List<string>? related = null, CareerMatch? match = null)
    {
        if (d.Posts.Any(p => p.EventKey == key)) return;
        int priority = match != null || related?.Contains("player") == true || new[] { "honor-", "contract-", "qualification-", "league-entry-", "international-entry-" }.Any(key.StartsWith) ? 3 : category == "国际赛事" ? 2 : 1;
        if (!d.Ai.Enabled && !IsImportantNews(key, priority)) return;
        var rng = new Random(StableHash(key + d.WorldId));
        var recentAuthors = d.Posts.Take(4).SelectMany(p => p.Replies).GroupBy(r => r.AuthorId).ToDictionary(g => g.Key, g => g.Count());
        var audience = CareerNarrative.NewsAudience(d, key, category, match, related);
        var candidates = audience.OrderBy(p => recentAuthors.GetValueOrDefault(p.Id)).ThenBy(p => StableHash(key + p.Id)).Take(12).ToList();
        if (related != null) foreach (var id in related) if (audience.FirstOrDefault(p => p.Id == id) is { } p && !candidates.Contains(p)) candidates.Insert(0, p);
        var authors = new List<CareerPerson>();
        foreach (var role in new[] { "普通玩家", "青训选手", "职业选手" })
        {
            var p = candidates.FirstOrDefault(p => p.Role == role);
            if (p != null) authors.Add(p);
        }
        if (related?.FirstOrDefault() is { } featured && audience.FirstOrDefault(p => p.Id == featured) is { } person && !authors.Contains(person)) authors.Add(person);
        int replyCount = 2 + rng.Next(5);
        foreach (var candidate in candidates) if (authors.Count < replyCount && !authors.Contains(candidate)) authors.Add(candidate);
        string factTitle = title.Replace("你", Name(d)), factBody = body.Replace("你", Name(d));
        (title, body) = CareerNarrative.News(d, key, title, body, category, match);
        var post = new CommunityPost { MatchKind = match?.Kind ?? "", EditorialVersion = 1, SourceTitle = factTitle, SourceBody = factBody, Priority = priority, Day = d.Day, EventKey = key, Title = title, Body = body, Category = category, AuthorId = CareerNarrative.PostAuthor(d, key, category, match, related), RelatedPeople = related ?? [], AiPending = aiPending };
        if (category == "训练日常" && Person(d, post.AuthorId) is { } writer)
        {
            int start = post.Body.IndexOf(writer.Name, StringComparison.Ordinal);
            if (start >= 0) post.Body = post.Body[start..].Replace(writer.Name, "我");
        }
        var used = new HashSet<string>();
        post.Replies = authors.Take(replyCount).Select(p => new CommunityReply { AuthorId = p.Id, Body = CareerNarrative.FreshReply(d, p, category, match, rng.Next(), key, used) }).ToList();
        CommunityThreads.MakeOfflineThreads(post);
        var participants = post.Replies.Select(r => r.AuthorId).Append(post.AuthorId).Concat(post.RelatedPeople).ToHashSet();
        post.PeopleAtEvent = d.People.Where(p => participants.Contains(p.Id)).Select(p => new CareerPerson
        {
            Id = p.Id, Name = p.Name, Handle = p.Handle, EditedCard = p.EditedCard, Gender = IdentityGender.Of(d, p.Id), Role = p.Role, Country = p.Country, ClubId = p.ClubId, Character = p.Character, Style = p.Style,
            CameoId = p.CameoId, Biography = p.CameoId.Length > 0 ? p.Biography : "", RecordedWinStreak = p.RecordedWinStreak, RecordedStreakAscension = p.RecordedStreakAscension,
            MaxAscension = p.MaxAscension, Wins = p.Wins, Losses = p.Losses, Rating = p.Rating, Form = p.Form,
            Personality = p.Personality, SupportedClubId = p.SupportedClubId, AiIntroduction = p.AiIntroduction, IntroductionDay = p.IntroductionDay,
            Identities = p.Identities.ToList(), Connections = p.Connections.ToList()
        }).ToList();
        if (aiPending) post.Schedule = PublicSchedule.Capture(d, post.RelatedPeople);
        d.Posts.Insert(0, post); CommunityThreads.Remember(d, post); CommunityThreads.TrimFeed(d);
    }
    public static bool IsImportantNews(string key, int priority) => priority >= 3 || key == "ecosystem"
        || new[] { "champion-", "qualification-", "knockout-", "draw-", "transfer-", "season-", "recap-" }.Any(key.StartsWith);
    public static int StableHash(string value)
    {
        unchecked { uint hash = 2166136261; foreach (char c in value) { hash ^= c; hash *= 16777619; } return (int)(hash & 0x7fffffff); }
    }
    private static void AwardSeason(CareerData d)
    {
        SeasonCeremony.Close(d);
        var league = EsportsWorld.PlayerLeague(d);
        int rank = league?.PlayerEntered == true ? EsportsWorld.DomesticRank(d) : 0;
        int points = league?.Table.FirstOrDefault(x => x.PersonId == "player")?.Points ?? 0;
        int prize = rank == 0 || points == 0 ? 0 : rank == 1 ? 240 : rank <= 3 ? 100 : 20;
        d.Credits += prize; d.Life.PrizeTotal += prize; CareerMoney.Record(d, "赛季名次奖金", prize);
        d.SeasonHistory.Add(new SeasonRecap { Season = d.Season, Rank = rank, Points = points, Prize = prize });
        Publish(d, "recap-" + d.Season, $"第 {d.Season} 赛季收官", rank == 0 ? "本赛季尚未进入职业联赛。新赛季仍可参加选拔，已经取得的资格与荣誉继续保留。" : $"你获得国内联赛第 {rank} 名，积分 {points}，收官奖励 {CareerMoney.Format(prize)}。已取得的资格、俱乐部合同与荣誉将延续至新赛季。", "赛季", true);
    }
}
