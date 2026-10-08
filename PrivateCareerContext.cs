using System.Text;

namespace NationalSpire;

public static partial class PrivatePublicContext
{
    private static int WorldPoints(CareerData d, string id) => d.Esports.CircuitAwards
        .Where(a => a.PersonId == id && a.Day <= d.Day && a.Points > 0 && a.Season > d.Season - 4 && a.Season <= d.Season)
        .OrderByDescending(a => a.Points).ThenByDescending(a => a.Season).Take(6).Sum(a => a.Points);
    // 动态事实独立于保存的提示词和人物自述，直接使用当前生涯中已发生的记录。
    private static void AppendCareerDetails(StringBuilder b, CareerData d, CareerPerson p, List<(int Start, int Length, string Group)>? changing = null)
    {
        string player = CareerEngine.Name(d);
        var meetings = d.Results.Where(r => r.Day <= d.Day && (r.OpponentId == p.Id || r.OpponentParticipants.Contains(p.Id))).OrderBy(r => r.Day).ToArray();
        int resultsStart = b.Length;
        if (meetings.Length > 0)
        {
            b.AppendLine($"\n{player}与{p.PublicName}的已记录交手（包括私下切磋）：从{player}一方统计，{meetings.Count(r => r.Outcome == "获胜")}胜、{meetings.Count(r => r.Outcome == "失利")}负、{meetings.Count(r => r.Outcome == "平局")}平、{meetings.Count(r => r.Outcome == "退赛")}次退赛。");
        }
        AppendRecentResults(b, d, p);
        if (b.Length > resultsStart) changing?.Add((resultsStart, b.Length - resultsStart, "results"));
        foreach (var competition in d.Esports.Competitions.Where(c => c.Season == d.Season && !c.Finished))
        {
            var ranked = EsportsWorld.Ranked(competition).ToList();
            foreach (string id in new[] { p.Id, Human(d) })
            {
                var teams = competition.Rosters.Where(r => r.Value.Contains(id)).Select(r => competition.Kind == "worldcup" ? r.Key + "国家队" : EsportsWorld.ClubName(d, r.Key)).ToArray();
                if (teams.Length > 0) b.AppendLine($"{Name(d, id)}已列入{competition.Name}的{string.Join("、", teams)}参赛名单。");
                int index = ranked.FindIndex(s => s.PersonId == id);
                if (index >= 0) b.AppendLine($"{Name(d, id)}在本赛季{competition.Name}的当前积分榜排名为第{index + 1}，积分{ranked[index].Points}，{ranked[index].Wins}胜{ranked[index].Losses}负{ranked[index].Draws}平；赛事仍在进行。");
            }
        }
        if (d.Esports.OwnedClub is { } owned)
        {
            if (owned.Contracts.FirstOrDefault(c => c.PersonId == p.Id && c.SignedDay <= d.Day) is { } contract)
                b.AppendLine($"{p.PublicName}与{EsportsWorld.ClubName(d, owned.ClubId)}的现有合同：{ContractTerms(d, contract)}，阵容位置为{OwnedClubs.Position(owned, p.Id)}。" + (contract.GuaranteedStarter ? "合同约定首发席位。" : ""));
            if (owned.Transfers.FirstOrDefault(t => !t.Arrived && t.Contract.PersonId == p.Id && t.Contract.SignedDay <= d.Day) is { } transfer)
                b.AppendLine($"{p.PublicName}已签订转会合同，将于第{transfer.ArrivalSeason}赛季从{EsportsWorld.ClubName(d, transfer.SellerId)}加盟{EsportsWorld.ClubName(d, owned.ClubId)}，约定位置为{transfer.Position}；当前尚未加盟。签字费{CareerMoney.Format(transfer.Contract.Signing)}，周薪{CareerMoney.Format(transfer.Contract.Wage)}，胜场奖金{CareerMoney.Format(transfer.Contract.WinBonus)}，加盟后合同{transfer.Contract.Days / 7}周。");
        }
        if (d.Esports.PlayerContract is { } playerContract && playerContract.ClubId == d.Esports.ClubId)
            b.AppendLine($"{player}与{EsportsWorld.ClubName(d, playerContract.ClubId)}的现有合同：{CareerCommerce.ClubTerms(playerContract)}。");
        // 只读取本次会话的缘由。共享的状态数值不能用来获取另一名玩家的私信内容。
        double mood = CareerTraining.MoodLevel(p, d.Day);
        if (mood != 0)
        {
            int moodStart = b.Length;
            int shock = SpireArbitration.ShockDay(p, d.Day), until = CareerTraining.MoodUntil(p, d.Day);
            b.AppendLine($"{p.PublicName}当前比赛状态从{PrivateAppointments.DateText(d, shock >= 0 ? shock : p.Learning.MoodDay)}持续至{PrivateAppointments.DateText(d, until)}之前，剩余{until - d.Day}天，" + (shock >= 0 ? "仲裁期间保持最严重负面等级，期满解除。" : "效果逐日减弱。"));
            var cause = PrivateMessages.Conversation(d, p.Id).Turns.Where(t => !t.UserDeleted && !t.ReplyDeleted && t.Status == "complete")
                .Select(t => t.Mood).LastOrDefault(m => m != null && m.Day == p.Learning.MoodDay && m.Day + m.Days == p.Learning.MoodUntil && m.Strength == p.Learning.MoodStrength);
            if (cause != null) b.AppendLine($"{p.PublicName}在本次私信中记录的状态缘由：{cause.Reason}");
            changing?.Add((moodStart, b.Length - moodStart, "mood"));
        }
        foreach (var activity in d.Life.Activities.Where(a => a.StartedDay <= d.Day && a.Status == "进行中" &&
            (a.PersonId == p.Id || a.TrainingTargets.Contains(p.Id))))
            b.AppendLine($"{p.PublicName}正在参与{activity.Title}，{PrivateAppointments.DateText(d, activity.StartedDay)}开始，预计{PrivateAppointments.DateText(d, activity.FinishDay)}结束。{activity.Detail}");
    }

    private static void AppendRecentResults(StringBuilder b, CareerData d, CareerPerson p)
    {
        var records = new List<(string Key, int Day, int Order, string Text)>();
        var fixtures = d.Esports.Competitions.SelectMany(c => c.Fixtures
            .Where(f => f.Finished && f.Day <= d.Day && (f.HomeId == p.Id || f.AwayId == p.Id || f.HomeParticipants.Contains(p.Id) || f.AwayParticipants.Contains(p.Id)))
            .Select(f => (Competition: c, Fixture: f)));
        foreach (var (competition, f) in fixtures)
        {
            bool home = f.HomeId == p.Id || f.HomeParticipants.Contains(p.Id);
            string side = home ? f.HomeId : f.AwayId;
            bool teamSide = (home ? f.HomeParticipants : f.AwayParticipants).Count > 1;
            string subject = side == p.Id && !teamSide ? p.PublicName : p.PublicName + "所在队伍";
            string opponentId = home ? f.AwayId : f.HomeId, opponentTeam = home ? f.AwayTeam : f.HomeTeam;
            var opponentMembers = home ? f.AwayParticipants : f.HomeParticipants;
            string opponent = opponentMembers.Count > 1 ? string.Join("、", opponentMembers.Select(id => Name(d, id))) + "组成的队伍"
                : opponentId.Length > 0 ? Name(d, opponentId) : competition.Kind == "worldcup" ? opponentTeam + "国家队" : EsportsWorld.ClubName(d, opponentTeam);
            string result = f.Draw ? "平局" : f.WinnerId == side ? "获胜" : "失利";
            var match = d.Matches.FirstOrDefault(m => m.FixtureId == f.Id && m.CompetitionId == competition.Id);
            int order = match == null ? -1 : d.Results.FindIndex(r => r.MatchId == match.Id);
            var recorded = order >= 0 ? d.Results[order] : null;
            string actual = recorded == null ? "" : $"{CareerEngine.Name(d)}实际挑战{(ActualAscension(recorded) >= 0 ? "进阶" + ActualAscension(recorded) : "进阶未记录")}，使用{CharacterIdentity.ForResult(recorded)}。";
            records.Add(("fixture:" + competition.Id + ":" + f.Id, f.Day, order,
                $"{PrivateAppointments.DateText(d, f.Day)}，{subject}与{opponent}完成正式比赛“{competition.Name}”，赛事进阶{f.Ascension}。"
                + (f.Walkover ? "本场为弃权判定。" : $"{subject}：{MatchRules.Performance(home ? f.HomeCleared : f.AwayCleared, home ? f.HomeFloor : f.AwayFloor, home ? f.HomeSeconds : f.AwaySeconds)}；{opponent}：{MatchRules.Performance(home ? f.AwayCleared : f.HomeCleared, home ? f.AwayFloor : f.HomeFloor, home ? f.AwaySeconds : f.HomeSeconds)}。")
                + $"{subject}{result}。" + actual));
        }
        foreach (var (r, index) in d.Results.Select((r, index) => (r, index)).Where(x => x.r.Day <= d.Day
            && (x.r.OpponentId == p.Id || x.r.OpponentParticipants.Contains(p.Id))))
        {
            var match = d.Matches.FirstOrDefault(m => m.Id == r.MatchId);
            string key = match?.FixtureId.Length > 0 ? "fixture:" + match.CompetitionId + ":" + match.FixtureId
                : r.MatchId.Length > 0 ? "match:" + r.MatchId : "legacy:" + index;
            if (records.Any(x => x.Key == key)) continue;
            string type = r.Kind == "private-friendly" ? "私下切磋" : r.Kind == "private-challenge" ? "公开挑战" : "正式比赛“" + r.Event + "”";
            bool team = r.PlayerParticipants.Count > 1 || r.OpponentParticipants.Count > 1 || d.HumanIds.Count > 1;
            string player = team ? string.Join("、", r.PlayerParticipants.Count > 0 ? r.PlayerParticipants.Select(id => Name(d, id)) : d.HumanIds.Select(id => Name(d, id))) + "所在队伍" : CareerEngine.Name(d);
            string npc = team ? (r.OpponentParticipants.Count > 0 ? string.Join("、", r.OpponentParticipants.Select(id => Name(d, id))) : Name(d, r.OpponentId)) + "所在队伍" : p.PublicName;
            string other = r.Settlement?.OpponentPerformance is { Length: > 0 } performance ? performance : (match?.Status == "已结算" && match.OpponentPrepared
                ? MatchRules.Performance(match.OpponentWon, match.OpponentFloor, match.OpponentSeconds) : "爬塔表现未记录");
            string ascension = ActualAscension(r) >= 0 ? "进阶" + ActualAscension(r) : "进阶未记录";
            records.Add((key, r.Day, index, $"{PrivateAppointments.DateText(d, r.Day)}，{player}与{npc}完成{type}。{player}挑战{ascension}，使用{CharacterIdentity.ForResult(r)}，{MatchRules.Performance(r.Win, r.Floor, r.RunSeconds)}；{npc}挑战进阶{r.Ascension}，{other}。{player}的对战结果为{r.Outcome}。"));
        }
        var recent = records.OrderByDescending(r => r.Day).ThenByDescending(r => r.Order).Take(3).Reverse().ToArray();
        if (recent.Length > 0) b.AppendLine($"\n{p.PublicName}实际参加的近期比赛（从旧到新）\n" + string.Join("\n", recent.Select(r => r.Text)));
    }
    private static string ContractTerms(CareerData d, OwnedPlayerContract c) =>
        $"{PrivateAppointments.DateText(d, c.SignedDay)}签订，签字费{CareerMoney.Format(c.Signing)}，周薪{CareerMoney.Format(c.Wage)}，胜场奖金{CareerMoney.Format(c.WinBonus)}，{PrivateAppointments.DateText(d, c.EndDay)}续约";

    private static void AppendClubDetails(StringBuilder b, CareerData d, CareerClub club, string speaker, List<(int Start, int Length, string Group)>? changing)
    {
        if (club.Identity.Length > 0) b.AppendLine($"{club.Name}的俱乐部介绍：{club.Identity}");
        if (d.Esports.OwnedClub is { } own && own.ClubId == club.Id)
        {
            b.AppendLine($"{club.Name}由{ Name(d, own.ManagerId)}管理，成立于{PrivateAppointments.DateText(d, own.FoundedDay)}。");
            foreach (var (role, members) in new[] { ("首发", own.Starters), ("轮换", own.Reserves), ("青训", own.Youth), ("教练", own.Coaches) })
                if (members.Count > 0) b.AppendLine($"{club.Name}的{role}：{string.Join("、", members.Select(Brief))}。");
            if (own.Sponsor is { } sponsor) b.AppendLine($"{club.Name}的俱乐部赞助商：{sponsor.Brand}，本期合作至{PrivateAppointments.DateText(d, sponsor.EndDay)}。");
        }
        else
        {
            foreach (var group in CoachLineups.Members(d, club.Id).GroupBy(p => CoachLineups.Position(d, p)))
                b.AppendLine($"{club.Name}的{group.Key}：{string.Join("、", group.Select(p => Brief(p.Id)))}。");
            if (d.Esports.ClubId == club.Id && d.LocalHumanId.Length == 0) b.AppendLine($"{Name(d, "player")}：本队玩家。");
            var sponsor = d.Esports.Sponsors.LastOrDefault(s => s.TargetId == club.Id && s.Accepted && s.EndedDay == 0 && s.SignedDay <= d.Day && s.StartSeason <= d.Season && s.EndSeason >= d.Season);
            if (sponsor != null) b.AppendLine($"{club.Name}的俱乐部赞助商：{sponsor.Brand}。{sponsor.Description}");
        }
        var rates = CoachLineups.Members(d, club.Id).Where(p => p.Id != speaker && p.Id != d.LocalHumanId && !d.HumanIds.Contains(p.Id)
            && !CoachLineups.Coach(p) && CoachLineups.Position(d, p) is "首发" or "轮换" or "青训").ToArray();
        if (rates.Length > 0)
        {
            int start = b.Length;
            b.AppendLine($"{club.Name}队员当前水平：" + string.Join("；", rates.Select(p => $"{p.PublicName}，评分{p.Rating}，A{p.MaxAscension}通关率{MatchRules.ClearChance(d, p, p.MaxAscension):P1}")) + "。");
            changing?.Add((start, b.Length - start, "learning"));
        }
        string Brief(string id) => id == "player" || id == d.LocalHumanId ? Name(d, id) + "（玩家）"
            : CareerEngine.Person(d, id) is { } p ? $"{p.PublicName}（{p.Role}·最高A{p.MaxAscension}）" : Name(d, id);
    }
}
