namespace NationalSpire.Coop;

public static partial class CoopRules
{
    /// <summary>在线成员只决定下一场出场名单；历次成绩仍保留实际参赛者。</summary>
    public static void SetParticipants(CoopWorld w, IReadOnlySet<ulong> ids)
    {
        var d = w.World;
        var active = w.Members.Where(m => ids.Contains(m.SteamId)).ToList();
        d.CooperativeMembers = active.Count;
        d.MatchHumanIds = active.Select(m => m.PersonId).ToList();
        if (d.Esports.OwnedClub is { } owned)
        {
            foreach (var m in w.Members)
            {
                owned.Starters.Remove(m.PersonId); owned.Reserves.Remove(m.PersonId);
                (ids.Contains(m.SteamId) ? owned.Starters : owned.Reserves).Add(m.PersonId);
                if (CareerEngine.Person(d, m.PersonId) is { } p) p.ClubPosition = ids.Contains(m.SteamId) ? "首发" : "轮换";
            }
            int capacity = Math.Max(3, active.Count);
            foreach (string id in owned.Starters.Where(id => !d.HumanIds.Contains(id)).Reverse().ToList())
            {
                if (owned.Starters.Count <= capacity) break;
                owned.Starters.Remove(id); if (!owned.Reserves.Contains(id)) owned.Reserves.Add(id);
                if (CareerEngine.Person(d, id) is { } p) p.ClubPosition = "轮换";
            }
            foreach (string id in owned.Reserves.Where(id => !d.HumanIds.Contains(id) && owned.Contracts.Any(c => c.PersonId == id)).ToList())
            {
                if (owned.Starters.Count >= capacity) break;
                owned.Reserves.Remove(id); owned.Starters.Add(id);
                if (CareerEngine.Person(d, id) is { } p) p.ClubPosition = "首发";
            }
        }
        CircuitWorld.EnsureHumanRosters(d);
    }
}
