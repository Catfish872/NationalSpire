namespace NationalSpire;

public sealed class CoachLineupRequest
{
    public string Id { get; set; } = "";
    public string Actor { get; set; } = "";
    public string Coach { get; set; } = "";
    public string TurnId { get; set; } = "";
    public string ClubId { get; set; } = "";
    public string First { get; set; } = "";
    public string Second { get; set; } = "";
    public string FirstPosition { get; set; } = "";
    public string SecondPosition { get; set; } = "";
    public int Season { get; set; }
    public string State { get; set; } = "待生效";
    public string Reason { get; set; } = "";
}

public static class CoachLineups
{
    public const string Protocol = """
本轮附件包含阵容调整请求时，根据具体内容和情况决定是否同意。同意输出 [Lineup: 同意, Id: 13]，拒绝输出 [Lineup: 拒绝, Id: 13]，Id 填对应附件的编号；口头答复不会登记处理结果。同意的调整在下赛季生效。如果没有阵容调整附件但是玩家有调整意向，则先在正文中商谈阵容，收到对应附件后再输出同意或拒绝标记。
""";
    public static bool Coach(CareerPerson p) => p.ClubPosition == "教练" || p.ClubPosition.Length == 0 && (p.Role == "教练" || p.Identities.Contains("教练"));
    public static bool CanRequest(CareerData d, string coach) => d.Esports.ClubId.Length > 0
        && d.People.Any(p => p.Id == coach && p.ClubId == d.Esports.ClubId && Coach(p));
    public static List<string> Roster(CareerData d, string club)
    {
        var preferred = EsportsWorld.Club(d, club)?.PreferredStarters ?? [];
        return d.People.Where(p => p.ClubId == club && EsportsWorld.IsProfessional(p) && !Coach(p))
            .OrderBy(p => preferred.Contains(p.Id) ? preferred.IndexOf(p.Id) : int.MaxValue)
            .ThenByDescending(p => p.Rating + CareerEngine.StableHash(d.WorldId + p.Id + d.Season) % 180)
            .Take(d.CooperativeMembers > 1 ? d.CooperativeMembers : 3).Select(p => p.Id).ToList();
    }
    private static List<string> CurrentRoster(CareerData d, string club) => d.Esports.Competitions
        .Where(c => c.Kind == "league" && c.Season <= d.Season && c.Rosters.ContainsKey(club))
        .OrderByDescending(c => c.Season).FirstOrDefault()?.Rosters[club] ?? Roster(d, club);
    public static string Position(CareerData d, CareerPerson p)
    {
        if (d.Esports.OwnedClub is { } own && own.ClubId == p.ClubId) return OwnedClubs.Position(own, p.Id);
        if (Coach(p)) return "教练";
        if (CurrentRoster(d, p.ClubId).Contains(p.Id)) return "首发";
        if (p.ClubPosition == "青训" || p.ClubPosition.Length == 0 && p.Role == "青训选手") return "青训";
        return EsportsWorld.IsProfessional(p) ? "轮换" : p.ClubPosition.Length > 0 ? p.ClubPosition : p.Role;
    }
    public static List<CareerPerson> Members(CareerData d, string club) => d.People.Where(p => p.ClubId == club)
        .OrderBy(p => p.Id, StringComparer.Ordinal).ToList();
    public static CareerPerson? Person(CareerData d, string id) => id == "player" && ClubCoaching.PlayerFeatures(d)
        ? CharacterCards.Read(d, id) : CareerEngine.Person(d, id);
    public static List<CareerPerson> Candidates(CareerData d) => Members(d, d.Esports.ClubId)
        .Where(p => !d.HumanIds.Contains(p.Id) && p.Id != "player" && Position(d, p) is "首发" or "轮换" or "青训")
        .Concat(ClubCoaching.PlayerFeatures(d) ? new[] { CharacterCards.Read(d, "player") } : [])
        .OrderBy(p => p.Id == "player" ? -1 : Position(d, p) == "首发" ? 0 : Position(d, p) == "轮换" ? 1 : 2).ToList();
    public static string? Error(CareerData d, string coach, PrivateOffer attachment)
    {
        if (!CanRequest(d, coach)) return "请选择本队教练商谈阵容。";
        return MemberError(d, d.Esports.ClubId, attachment.FirstPerson, attachment.SecondPerson);
    }
    private static string? MemberError(CareerData d, string club, string first, string second, string? firstPosition = null, string? secondPosition = null)
    {
        if (first == "player" || second == "player")
        {
            if (!ClubCoaching.PlayerFeatures(d) || d.Esports.OwnedClub!.ClubId != club) return "首发身份调整适用于单人生涯的自建俱乐部。";
            string other = first == "player" ? second : first;
            var member = d.People.FirstOrDefault(p => p.Id == other && p.ClubId == club && !d.HumanIds.Contains(p.Id));
            if (other == "player" || member == null) return "请选择一名本队选手交换席位。";
            string playerPosition = OwnedClubs.Position(d.Esports.OwnedClub, "player"), otherPosition = Position(d, member);
            if (firstPosition != null && (firstPosition != (first == "player" ? playerPosition : otherPosition)
                || secondPosition != (second == "player" ? playerPosition : otherPosition))) return "队员席位已经变化，请重新商谈。";
            if (otherPosition is not ("首发" or "轮换")) return "玩家可在首发与轮换之间调整，请选择对应席位的队员。";
            if (playerPosition == otherPosition) return "这两名队员的席位相同。";
            return ClubCoaching.PlayerPositionError(d, otherPosition, other);
        }
        var a = d.People.FirstOrDefault(p => p.Id == first && p.ClubId == club);
        var b = d.People.FirstOrDefault(p => p.Id == second && p.ClubId == club);
        if (a == null || b == null || first == second || first == "player" || second == "player" || d.HumanIds.Contains(first) || d.HumanIds.Contains(second)) return "请选择两名不同的本队 NPC 选手。";
        string left = Position(d, a), right = Position(d, b);
        if (Coach(a) || Coach(b) || left is not ("首发" or "轮换" or "青训") || right is not ("首发" or "轮换" or "青训")) return "教练不兼任选手，请选择首发、轮换或青训队员。";
        if (firstPosition != null && (left != firstPosition || right != secondPosition)) return "队员席位已经变化，请重新商谈。";
        if (left == right) return "这两名队员的席位相同。";
        if (d.Esports.OwnedClub is { } own && own.ClubId == club)
        {
            if (!own.Contracts.Any(c => c.PersonId == first) || !own.Contracts.Any(c => c.PersonId == second)) return "队员合同已经结束。";
            if (OwnedClubs.ReservedStarter(d, first) || OwnedClubs.ReservedStarter(d, second)) return "该首发席位已有下赛季转会约定。";
            if (own.Contracts.Any(c => c.GuaranteedStarter && (c.PersonId == first && right != "首发" || c.PersonId == second && left != "首发"))) return "合同约定的首发席位不能转为替补。";
        }
        var promoted = left == "首发" ? b : right == "首发" ? a : null;
        if (promoted != null && !EsportsWorld.IsProfessional(promoted) && promoted.MaxAscension < 8) return "接替首发的队员尚未满足职业赛事资格。";
        return null;
    }
    public static string Description(CareerData d, CoachLineupRequest r) => $"{CareerEngine.DisplayName(d, r.First)}：{r.FirstPosition} → {r.SecondPosition}；{CareerEngine.DisplayName(d, r.Second)}：{r.SecondPosition} → {r.FirstPosition}";
    public static string Prepare(CareerData d, PrivateOffer a) => $"{CareerEngine.DisplayName(d, a.FirstPerson)}（{Position(d, Person(d, a.FirstPerson)!)}）与{CareerEngine.DisplayName(d, a.SecondPerson)}（{Position(d, Person(d, a.SecondPerson)!)}）交换席位，第{d.Season + 1}赛季生效。";
    public static void Respond(CareerData d, PrivateConversation c, PrivateTurn turn, Dictionary<string, string> fields)
    {
        var action = fields.GetValueOrDefault("Lineup");
        PrivateInteractionIds.Ensure(c);
        var a = turn.Attachments.FirstOrDefault(a => a.Kind == "lineup" && a.Id == PrivateInteractionIds.Resolve(c, fields.GetValueOrDefault("Id")));
        if (a == null || action is not ("同意" or "拒绝")) { turn.Error += "\n缺少对应阵容附件或处理格式不正确，未执行。"; return; }
        string id = turn.Id + ":" + a.Id;
        if (d.Esports.LineupRequests.Any(r => r.Id == id)) return;
        var r = new CoachLineupRequest { Id = id, Actor = d.LocalHumanId.Length > 0 ? d.LocalHumanId : "player", Coach = c.PersonId, TurnId = turn.Id,
            ClubId = d.Esports.ClubId, First = a.FirstPerson, Second = a.SecondPerson, Season = d.Season + 1, State = action == "拒绝" ? "已拒绝" : "待生效" };
        r.FirstPosition = Person(d, r.First) is { } p ? Position(d, p) : "";
        r.SecondPosition = Person(d, r.Second) is { } q ? Position(d, q) : "";
        if (Error(d, c.PersonId, a) is { } error) { r.State = "未生效"; r.Reason = error; }
        Register(d, r);
        c.Offers.Add(new() { Id = id, Kind = "lineup", TurnId = turn.Id, State = r.State });
    }
    private static void Register(CareerData d, CoachLineupRequest request)
    {
        if (request.State == "待生效")
        {
            foreach (var old in d.Esports.LineupRequests.Where(r => r.State == "待生效" && r.ClubId == request.ClubId
                && (r.First == request.First || r.First == request.Second || r.Second == request.First || r.Second == request.Second))) old.State = "已替换";
            if (d.Esports.OwnedClub is { } own && own.ClubId == request.ClubId)
            {
                if (own.PlayerPositionSeason > 0 && (request.First == "player" || request.Second == "player"
                    || request.First == own.PlayerReplacement || request.Second == own.PlayerReplacement)) ClubCoaching.ClearPlayerPosition(own);
                if (request.First == "player" || request.Second == "player")
                {
                    own.PlayerPositionSeason = request.Season;
                    own.PlayerReplacement = request.First == "player" ? request.Second : request.First;
                    own.PlayerNextPosition = request.First == "player" ? request.SecondPosition : request.FirstPosition;
                    own.PlayerPositionRequest = request.Id;
                }
            }
        }
        d.Esports.LineupRequests.Add(request);
    }
    // 房主只合并这次回复新增的安排，不能覆盖其他成员同时登记的请求。
    public static void Merge(CareerData world, CareerData generated)
    {
        foreach (var request in generated.Esports.LineupRequests.Where(r => !world.Esports.LineupRequests.Any(x => x.Id == r.Id)))
        {
            var copy = System.Text.Json.JsonSerializer.Deserialize<CoachLineupRequest>(System.Text.Json.JsonSerializer.Serialize(request))!;
            if (copy.State == "待生效" && MemberError(world, copy.ClubId, copy.First, copy.Second, copy.FirstPosition, copy.SecondPosition) is { } error)
            { copy.State = "未生效"; copy.Reason = error; }
            Register(world, copy);
        }
    }
    public static string? Cancel(CareerData d, string coach, string id)
    {
        var r = d.Esports.LineupRequests.FirstOrDefault(r => r.Id == id && r.Coach == coach && r.ClubId == d.Esports.ClubId);
        if (r?.State != "待生效") return "这项阵容调整已经处理。";
        r.State = "已取消";
        if (d.Esports.OwnedClub is { } own && own.PlayerPositionRequest == r.Id) ClubCoaching.ClearPlayerPosition(own);
        return null;
    }
    public static void SeasonStart(CareerData d)
    {
        foreach (var r in d.Esports.LineupRequests.Where(r => r.State == "待生效" && r.Season <= d.Season))
        {
            if (MemberError(d, r.ClubId, r.First, r.Second, r.FirstPosition, r.SecondPosition) is { } error)
            { r.State = "未生效"; r.Reason = error; }
            else if (d.Esports.OwnedClub is { } own && own.ClubId == r.ClubId)
            {
                ClubCoaching.Move(d, r.First, r.SecondPosition); ClubCoaching.Move(d, r.Second, r.FirstPosition);
                OwnedClubs.UpdateRosterRole(CareerEngine.Person(d, r.First)!, r.SecondPosition);
                OwnedClubs.UpdateRosterRole(CareerEngine.Person(d, r.Second)!, r.FirstPosition);
                r.State = "已生效";
            }
            else if (EsportsWorld.Club(d, r.ClubId) is { } club)
            {
                if (club.PreferredStarters.Count == 0) club.PreferredStarters = CurrentRoster(d, club.Id).ToList();
                int first = club.PreferredStarters.IndexOf(r.First), second = club.PreferredStarters.IndexOf(r.Second);
                if (first >= 0) club.PreferredStarters[first] = r.Second;
                if (second >= 0) club.PreferredStarters[second] = r.First;
                OwnedClubs.UpdateRosterRole(CareerEngine.Person(d, r.First)!, r.SecondPosition);
                OwnedClubs.UpdateRosterRole(CareerEngine.Person(d, r.Second)!, r.FirstPosition);
                r.State = "已生效";
            }
            CareerLife.AddEvent(d, "lineup:" + r.Id, "俱乐部", "阵容调整 · " + r.State, Description(d, r) + (r.Reason.Length > 0 ? "。" + r.Reason : ""), [r.First, r.Second]);
        }
        CareerTraining.InvalidateForecast(d);
    }
    public static string Context(CareerData d, string coach) => string.Join("\n", d.Esports.LineupRequests.Where(r => r.ClubId == d.Esports.ClubId && r.Coach == coach)
        .Select(r => $"第{r.Season}赛季阵容调整：{Description(d, r)}；{r.State}{(r.Reason.Length > 0 ? "，" + r.Reason : "")}。"));
    public static void Deleted(CareerData d, string id)
    {
        foreach (var r in d.Esports.LineupRequests.Where(r => r.State == "待生效" && (r.First == id || r.Second == id)))
        {
            r.State = "未生效"; r.Reason = "队员已删除。";
            if (d.Esports.OwnedClub is { } own && own.PlayerPositionRequest == r.Id) ClubCoaching.ClearPlayerPosition(own);
        }
    }
}
