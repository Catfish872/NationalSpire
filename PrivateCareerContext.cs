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
        var meetings = d.Results.Where(r => r.Day <= d.Day && r.OpponentId == p.Id).OrderBy(r => r.Day).ToArray();
        if (meetings.Length > 0)
        {
            b.AppendLine($"\n{player}与{p.PublicName}的已记录交手（包括私下切磋）：从{player}一方统计，{meetings.Count(r => r.Outcome == "获胜")}胜、{meetings.Count(r => r.Outcome == "失利")}负、{meetings.Count(r => r.Outcome == "平局")}平、{meetings.Count(r => r.Outcome == "退赛")}次退赛。");
            var r = meetings[^1];
            b.AppendLine($"最近交手为{PrivateAppointments.DateText(d, r.Day)}的{r.Event}，{player}的赛果为{r.Outcome}，{player}{(ActualAscension(r) >= 0 ? "实际挑战进阶" + ActualAscension(r) : "实际挑战进阶未记录")}，{MatchRules.Performance(r.Win, r.Floor, r.RunSeconds)}。");
        }
        var fixtures = d.Esports.Competitions.SelectMany(c => c.Fixtures
            .Where(f => f.Finished && f.Day <= d.Day && (f.HomeId == p.Id || f.AwayId == p.Id || f.HomeParticipants.Contains(p.Id) || f.AwayParticipants.Contains(p.Id)))
            .Select(f => (Competition: c, Fixture: f))).OrderByDescending(x => x.Fixture.Day).Take(3);
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
            b.AppendLine($"{PrivateAppointments.DateText(d, f.Day)}，{subject}在{competition.Name}对阵{opponent}，赛果为{result}，赛事进阶{f.Ascension}。"
                + (f.Walkover ? "本场为弃权判定。" : $"{subject}的爬塔表现：{MatchRules.Performance(home ? f.HomeCleared : f.AwayCleared, home ? f.HomeFloor : f.AwayFloor, home ? f.HomeSeconds : f.AwaySeconds)}。"));
        }
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
    private static string ContractTerms(CareerData d, OwnedPlayerContract c) =>
        $"{PrivateAppointments.DateText(d, c.SignedDay)}签订，签字费{CareerMoney.Format(c.Signing)}，周薪{CareerMoney.Format(c.Wage)}，胜场奖金{CareerMoney.Format(c.WinBonus)}，{PrivateAppointments.DateText(d, c.EndDay)}续约";

    private static void AppendClubDetails(StringBuilder b, CareerData d, CareerClub club)
    {
        if (club.Identity.Length > 0) b.AppendLine($"{club.Name}的俱乐部介绍：{club.Identity}");
        if (d.Esports.OwnedClub is { } own && own.ClubId == club.Id)
        {
            b.AppendLine($"{club.Name}由{ Name(d, own.ManagerId)}管理，成立于{PrivateAppointments.DateText(d, own.FoundedDay)}。");
            foreach (var (role, members) in new[] { ("首发", own.Starters), ("轮换", own.Reserves), ("青训", own.Youth) })
                if (members.Count > 0) b.AppendLine($"{club.Name}的{role}：{string.Join("、", members.Select(id => Name(d, id)))}。");
            if (own.Sponsor is { } sponsor) b.AppendLine($"{club.Name}的俱乐部赞助商：{sponsor.Brand}，本期合作至{PrivateAppointments.DateText(d, sponsor.EndDay)}。");
        }
        else
        {
            var roster = d.People.Where(p => p.ClubId == club.Id).Select(p => p.PublicName + "（" + p.Role + "）").ToList();
            if (d.Esports.ClubId == club.Id && d.LocalHumanId.Length == 0) roster.Insert(0, CareerEngine.Name(d) + "（玩家）");
            if (roster.Count > 0) b.AppendLine($"{club.Name}的现有成员：{string.Join("、", roster)}。");
            var sponsor = d.Esports.Sponsors.LastOrDefault(s => s.TargetId == club.Id && s.Accepted && s.EndedDay == 0 && s.SignedDay <= d.Day && s.StartSeason <= d.Season && s.EndSeason >= d.Season);
            if (sponsor != null) b.AppendLine($"{club.Name}的俱乐部赞助商：{sponsor.Brand}。{sponsor.Description}");
        }
    }
}
