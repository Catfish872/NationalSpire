using System.Globalization;

namespace NationalSpire;

public sealed class CoachAppointment
{
    public string PersonId { get; set; } = "";
    public string Replacement { get; set; } = "";
    public int Season { get; set; }
}

public sealed class CoachTrainingPlan
{
    public string CoachId { get; set; } = "";
    public string Id { get; set; } = "";
    public string PersonId { get; set; } = "";
    public string TurnId { get; set; } = "";
    public string ClubId { get; set; } = "";
    public string Content { get; set; } = "";
    public int StartDay { get; set; }
    public int Weeks { get; set; }
    public int PaidWeeks { get; set; }
    public double Gained { get; set; }
    public string State { get; set; } = "进行中";
    public int EndDay => StartDay + Weeks * 7;
}

/// <summary>教练岗位独立于选手能力；赛季席位调整在生成签表前生效。</summary>
public static class ClubCoaching
{
    public static bool PlayerFeatures(CareerData d) => OwnedClubs.CanOperate(d) && !CareerTraining.Multiplayer(d);
    public static bool PlayerReserve(CareerData d) => PlayerFeatures(d) && d.Esports.OwnedClub!.PlayerReserve;
    public static bool PlayerCoach(CareerData d) => PlayerFeatures(d) && d.Esports.OwnedClub!.PlayerCoach;
    public static bool IsCoach(CareerPerson p) => p.ClubPosition == "教练";
    public static double Factor(CareerPerson p) => p.MaxAscension >= 9 ? 1.3 : p.MaxAscension >= 8 ? 1.2 : 1.1;
    public static double Factor(CareerData d) => d.Esports.OwnedClub is { } o
        ? o.Coaches.Where(id => d.People.Any(p => p.Id == id && p.ClubId == o.ClubId && IsCoach(p)) && o.Contracts.Any(c => c.PersonId == id && c.Position == "教练"))
            .Select(id => Factor(CareerEngine.Person(d, id)!)).DefaultIfEmpty(1).Max() : 1;
    public static bool Scheduled(CareerData d, string id) => d.Matches.Any(m => m.Status == "待赛" && m.OpponentId == id
        && !PrivateAppointments.IsPrivate(m) && m.Day > SeasonCalendar.Start(d) && m.Day <= SeasonCalendar.Start(d) + SeasonCalendar.Length(d))
        || d.Esports.Competitions.Any(c => c.Season == d.Season
        && c.Fixtures.Any(f => !f.Finished && (f.HomeId == id || f.AwayId == id
            || c.Cooperative && ((c.Rosters.TryGetValue(f.HomeTeam, out var home) && home.Contains(id))
                || (c.Rosters.TryGetValue(f.AwayTeam, out var away) && away.Contains(id))))));
    public static List<string> Replacements(CareerData d, string exclude = "") => d.Esports.OwnedClub is not { } o ? []
        : o.Contracts.Where(c => c.PersonId != exclude && c.Position is "轮换" or "青训"
            && !OwnedClubs.TransferReserved(d, c.PersonId) && !o.CoachAppointments.Any(a => a.PersonId == c.PersonId)
            && !OwnedClubs.ReservedStarter(d, c.PersonId) && d.People.Any(p => p.Id == c.PersonId && p.ClubId == o.ClubId && !IsCoach(p)))
            .Select(c => c.PersonId).Where(id => EsportsWorld.IsProfessional(CareerEngine.Person(d, id)!)
                || CareerEngine.Person(d, id)!.MaxAscension >= 8).ToList();
    public static string? Appoint(CareerData d, string id, string replacement)
    {
        if (!OwnedClubs.CanOperate(d) || d.PendingMatchId != null) return "请在比赛结束后调整俱乐部岗位。";
        var o = d.Esports.OwnedClub!;
        var contract = o.Contracts.FirstOrDefault(c => c.PersonId == id);
        if (contract == null || !d.People.Any(p => p.Id == id && p.ClubId == o.ClubId)) return "请选择本队签约选手。";
        if (contract.Position == "教练") return "已经担任教练。";
        if (contract.GuaranteedStarter || OwnedClubs.ReservedStarter(d, id)) return "该选手的首发席位已有合同约定。";
        if (o.Starters.Contains(id) && !Replacements(d, id).Contains(replacement)) return "请选择符合资格的接替首发。";
        if (Scheduled(d, id))
        {
            o.CoachAppointments.RemoveAll(a => a.PersonId == id);
            o.CoachAppointments.Add(new() { PersonId = id, Replacement = replacement, Season = d.Season + 1 });
        }
        else Convert(d, id, replacement);
        CareerTraining.InvalidateForecast(d); CareerStore.Save(d); return null;
    }
    private static void Convert(CareerData d, string id, string replacement)
    {
        var o = d.Esports.OwnedClub!;
        if (o.Starters.Contains(id)) Move(d, replacement, "首发");
        Move(d, id, "教练"); o.CoachAppointments.RemoveAll(a => a.PersonId == id);
        StopTraining(d, id);
    }
    public static void Move(CareerData d, string id, string position)
    {
        var o = d.Esports.OwnedClub!;
        foreach (string role in new[] { "首发", "轮换", "青训", "教练" }) OwnedClubs.PositionList(o, role).Remove(id);
        OwnedClubs.PositionList(o, position).Add(id);
        var c = o.Contracts.FirstOrDefault(c => c.PersonId == id);
        if (c != null) c.Position = position;
        if (CareerEngine.Person(d, id) is { } p) p.ClubPosition = position;
    }
    public static string? SetPlayerCoach(CareerData d, bool value)
    {
        if (!PlayerFeatures(d)) return "教练任职适用于单人生涯的自建俱乐部。";
        d.Esports.OwnedClub!.PlayerCoach = value;
        if (!value) foreach (var p in d.Esports.OwnedClub.CoachTraining.Where(p => p.State == "进行中" && p.CoachId.Length == 0)) p.State = "已取消";
        CareerStore.Save(d); return null;
    }
    public static string? PlayerPositionError(CareerData d, string position, string replacement)
    {
        if (!PlayerFeatures(d)) return "首发身份调整适用于单人生涯的自建俱乐部。";
        if (position == "取消") return null;
        if (position is not ("首发" or "轮换")) return "请选择首发或轮换。";
        if (position == "轮换" && !Replacements(d).Contains(replacement)) return "请选择符合资格的接替首发。";
        if (position == "首发" && OwnedClubs.StarterReplacementError(d, replacement) is { } e) return e;
        return null;
    }
    internal static void ClearPlayerPosition(OwnedClubState o)
    { o.PlayerPositionSeason = 0; o.PlayerReplacement = o.PlayerNextPosition = o.PlayerPositionRequest = ""; }
    public static string? SetPlayerPosition(CareerData d, string position, string replacement)
    {
        if (PlayerPositionError(d, position, replacement) is { } error) return error;
        var o = d.Esports.OwnedClub!;
        if (position == "取消")
        {
            if (d.Esports.LineupRequests.FirstOrDefault(r => r.Id == o.PlayerPositionRequest && r.State == "待生效") is { } pending) pending.State = "已取消";
            ClearPlayerPosition(o); CareerStore.Save(d); return null;
        }
        foreach (var r in d.Esports.LineupRequests.Where(r => r.State == "待生效" && r.ClubId == o.ClubId
            && (r.First == "player" || r.Second == "player" || r.First == replacement || r.Second == replacement))) r.State = "已替换";
        o.PlayerPositionRequest = "";
        o.PlayerPositionSeason = d.Season + 1; o.PlayerNextPosition = position; o.PlayerReplacement = replacement;
        CareerStore.Save(d); return null;
    }
    public static void SeasonStart(CareerData d)
    {
        if (!OwnedClubs.IsOwner(d)) return;
        var o = d.Esports.OwnedClub!;
        foreach (var a in o.CoachAppointments.Where(a => a.Season <= d.Season).ToList())
        {
            var c = o.Contracts.FirstOrDefault(c => c.PersonId == a.PersonId);
            bool valid = c != null && !c.GuaranteedStarter && !OwnedClubs.ReservedStarter(d, a.PersonId)
                && d.People.Any(p => p.Id == a.PersonId && p.ClubId == o.ClubId)
                && (!o.Starters.Contains(a.PersonId) || Replacements(d, a.PersonId).Contains(a.Replacement));
            if (valid) Convert(d, a.PersonId, a.Replacement);
            else { o.CoachAppointments.Remove(a); Notice(d, "教练调整未生效", "原席位保留，接替人选或合同条件已变化。"); }
        }
        if (o.PlayerPositionSeason == 0 || o.PlayerPositionSeason > d.Season) return;
        bool reserve = o.PlayerNextPosition == "轮换";
        bool available = PlayerFeatures(d) && (reserve ? Replacements(d).Contains(o.PlayerReplacement)
            : OwnedClubs.ReplaceableStarters(d).Contains(o.PlayerReplacement));
        if (available)
        {
            Move(d, o.PlayerReplacement, reserve ? "首发" : "轮换");
            o.PlayerReserve = reserve; Move(d, "player", reserve ? "轮换" : "首发");
        }
        else Notice(d, "首发调整未生效", "原席位保留，接替人选或合同条件已变化。");
        if (d.Esports.LineupRequests.FirstOrDefault(r => r.Id == o.PlayerPositionRequest && r.State == "待生效") is { } request)
        {
            request.State = available ? "已生效" : "未生效";
            if (!available) request.Reason = "接替人选或合同条件已变化。";
        }
        ClearPlayerPosition(o);
    }
    private static void Notice(CareerData d, string title, string text) => CareerLife.AddEvent(d,
        "coach-notice-" + Guid.NewGuid().ToString("N"), "俱乐部", title, text, ["player"]);

    public const string Protocol = """
本轮附件中存在训练计划时，根据具体内容和情况决定是否接受；接受须输出 [Training: 接受, Id: 12]，Id 填对应训练附件的编号；口头答应不会实际生效。接受已有训练的新安排会刷新期限，不叠加训练效果或时长。如果没有训练计划附件但是玩家有安排训练的意向，则先在正文中商谈训练内容，收到对应附件后再输出接受训练标记。
""";
    // 自建俱乐部沿用原存储位置，普通俱乐部训练由生涯保存。
    public static IEnumerable<CoachTrainingPlan> TrainingPlans(CareerData d) =>
        d.Esports.CoachTraining.Concat(d.Esports.OwnedClub?.CoachTraining ?? []);
    private static List<CoachTrainingPlan> TrainingStore(CareerData d, string club) =>
        d.Esports.OwnedClub is { } o && o.ClubId == club ? o.CoachTraining : d.Esports.CoachTraining;
    internal static void RestoreTraining(CareerData d, string person, List<CoachTrainingPlan> plans)
    {
        d.Esports.CoachTraining.RemoveAll(p => p.PersonId == person);
        d.Esports.OwnedClub?.CoachTraining.RemoveAll(p => p.PersonId == person);
        foreach (var plan in plans) TrainingStore(d, plan.ClubId).Add(plan);
    }
    private static bool TrainingMember(CareerData d, string person, string club) => club.Length > 0
        && d.People.Any(p => p.Id == person && p.ClubId == club && !IsCoach(p))
        && (d.Esports.OwnedClub is not { } o || o.ClubId != club
            || o.Contracts.Any(c => c.PersonId == person && c.Position is "首发" or "轮换" or "青训"));
    public static string? TrainingError(CareerData d, string person, PrivateOffer attachment)
    {
        if (attachment.CoachId.Length > 0)
        {
            if (!attachment.CoachAccepted || !CoachLineups.CanRequest(d, attachment.CoachId)) return "训练尚未由本队教练接受。";
        }
        else if (!PlayerCoach(d)) return "请先在俱乐部兼任教练。";
        if (!TrainingMember(d, person, d.Esports.ClubId)) return "训练对象须为本队选手。";
        if (attachment.Weeks is < 1 or > 4 || string.IsNullOrWhiteSpace(attachment.Detail)) return "请填写训练内容并选择1—4周。";
        return null;
    }
    public static void AcceptTraining(CareerData d, PrivateConversation c, PrivateTurn t, Dictionary<string, string> fields)
    {
        if (fields.GetValueOrDefault("Training") != "接受") return;
        PrivateInteractionIds.Ensure(c);
        var a = t.Attachments.FirstOrDefault(a => a.Kind == "training" && a.Id == PrivateInteractionIds.Resolve(c, fields.GetValueOrDefault("Id")));
        if (a == null) { t.Error += "\n缺少对应训练附件，未执行。"; return; }
        if (TrainingError(d, c.PersonId, a) is { } error) { t.Error += "\n" + error; return; }
        var plans = TrainingStore(d, d.Esports.ClubId);
        string id = t.Id + ":" + a.Id;
        if (plans.Any(p => p.Id == id)) return;
        foreach (var old in plans.Where(p => p.PersonId == c.PersonId && p.State == "进行中")) old.State = "已替换";
        plans.Add(new() { Id = id, PersonId = c.PersonId, ClubId = d.Esports.ClubId, TurnId = t.Id,
            Content = a.Detail, StartDay = d.Day, Weeks = a.Weeks, CoachId = a.CoachId });
        c.Offers.Add(new() { Id = id, Kind = "training", TurnId = t.Id, State = "已接受", Detail = a.Detail, Weeks = a.Weeks });
    }
    public static void Advance(CareerData d)
    {
        foreach (var plan in TrainingPlans(d).Where(p => p.State == "进行中"))
        {
            if (!(plan.CoachId.Length > 0 ? CoachLineups.CanRequest(d, plan.CoachId) : PlayerCoach(d))
                || plan.ClubId != d.Esports.ClubId || !TrainingMember(d, plan.PersonId, plan.ClubId)) { plan.State = "已取消"; continue; }
            int due = Math.Clamp((d.Day - plan.StartDay) / 7, 0, plan.Weeks);
            while (plan.PaidWeeks < due)
            {
                int week = ++plan.PaidWeeks;
                var before = CareerEngine.Person(d, plan.PersonId)!.Learning.ChanceShift;
                CareerTraining.RecordLesson(d, plan.PersonId, new PrivateLearning { Id = "coach:" + plan.Id + ":" + week, Topic = plan.Content, Strength = 1, Source = "coach:" + plan.Id + ":" + week, Reason = plan.Content });
                plan.Gained += CareerEngine.Person(d, plan.PersonId)!.Learning.ChanceShift - before;
            }
            if (plan.PaidWeeks == plan.Weeks) plan.State = "已完成";
        }
    }
    public static void StopTraining(CareerData d, string id)
    {
        foreach (var plan in TrainingPlans(d).Where(p => (p.PersonId == id || p.CoachId == id) && p.State == "进行中")) plan.State = "已取消";
    }
    public static string TrainingContext(CareerData d, string id)
    {
        var p = TrainingPlans(d).LastOrDefault(p => p.PersonId == id);
        return p == null ? "" : $"\n教练训练《{p.Content}》：{PrivateAppointments.DateText(d, p.StartDay)}开始，{PrivateAppointments.DateText(d, p.EndDay)}结束，{p.State}，已完成{p.PaidWeeks}/{p.Weeks}周，已获得{p.Gained * 100:0.##}个百分点的永久成长。";
    }
}
