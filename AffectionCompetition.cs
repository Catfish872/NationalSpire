namespace NationalSpire;

/// <summary>联机采用对该NPC好感最高的玩家；永久成长在实际结算时应用，直接概率修正实时计算。</summary>
public static class AffectionCompetition
{
    public static (string Player, int Favour) Reference(CareerData data, string person)
    {
        if (data.HumanIds.Count == 0) return ("player", PrivateMessages.Favour(data, person));
        return data.HumanIds.Select(id => (Player: id, Favour: id == data.LocalHumanId ? PrivateMessages.Favour(data, person)
            : data.HumanFavours.GetValueOrDefault(id)?.GetValueOrDefault(person) ?? 0))
            .OrderByDescending(p => p.Favour).ThenBy(p => p.Player, StringComparer.Ordinal).First();
    }
    public static int Favour(CareerData data, string person) => Reference(data, person).Favour;
    public static bool Teammate(CareerData data, string person)
    {
        string player = Reference(data, person).Player;
        string club = player == "player" ? data.Esports.ClubId : CareerEngine.Person(data, player)?.ClubId ?? data.Esports.ClubId;
        return club.Length > 0 && CareerEngine.Person(data, person)?.ClubId == club;
    }
    private static bool Eligible(CareerData data, string person) => data.AffectionLinkedClearChance && person != "player" && !data.HumanIds.Contains(person);
    public static double Growth(CareerData data, string person)
    {
        if (!Eligible(data, person) || !Teammate(data, person)) return 1;
        int favour = Math.Clamp(Favour(data, person), -50, 100);
        return favour >= 0 ? 1 + favour / 100d : 1 + .99 * favour / 50d;
    }
    public static double Direct(CareerData data, string person)
    {
        if (!Eligible(data, person)) return 0;
        int favour = Math.Clamp(Favour(data, person), -50, 100);
        return Teammate(data, person) ? favour >= 0 ? favour / 1000d : favour / 500d : -Math.Max(0, favour) / 1000d;
    }
    public static void Snapshot(CareerData data, LifeActivity activity)
        => activity.AffectionGrowth = activity.TrainingTargets.ToDictionary(id => id, id => Growth(data, id));
    public static double Temporary(CareerData data, LifeActivity activity, string person)
        => data.AffectionLinkedClearChance ? activity.AffectionGrowth.GetValueOrDefault(person, 1) : 1;
    public static void Set(CareerData data, bool enabled)
    { data.AffectionLinkedClearChance = enabled; CareerTraining.InvalidateForecast(data); }
}
