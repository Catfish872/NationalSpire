namespace NationalSpire;

public sealed class RunEvidence
{
    public int? FinalHp { get; set; }
    public int? MaxHp { get; set; }
    public int? PotionSlots { get; set; }
    public int? PotionsUsed { get; set; }
    public bool PotionsRecorded { get; set; }
    public List<string> RemainingPotions { get; set; } = [];
    public List<RunBadge> Badges { get; set; } = [];
    // null 表示旧战报未记录；空集合表示本局没有确认击败的精英或 BOSS。
    public List<RunEncounter>? DefeatedEncounters { get; set; }
    public RunEvidence PlainText() => new()
    {
        FinalHp = FinalHp, MaxHp = MaxHp, PotionSlots = PotionSlots, PotionsUsed = PotionsUsed,
        PotionsRecorded = PotionsRecorded, RemainingPotions = RemainingPotions.Select(GameText.Plain).ToList(),
        Badges = Badges.Select(b => new RunBadge { Name = GameText.Plain(b.Name), Description = GameText.Plain(b.Description), Rarity = b.Rarity }).ToList(),
        DefeatedEncounters = DefeatedEncounters?.Select(e => e with { Name = GameText.Plain(e.Name) }).ToList()
    };
    public string EncounterSummary() => DefeatedEncounters is not { Count: > 0 } ? "" : string.Join("；",
        DefeatedEncounters.GroupBy(e => e.Kind).Select(g => (g.Key == "Boss" ? "击败BOSS：" : "击败精英：")
            + string.Join("、", g.Select(e => $"{e.Name}（第{e.Act}幕，第{e.Floor}层）"))));

    public static List<RunEncounter> CompletedEncounters(IReadOnlyList<RunEncounter> rooms, bool cleared, bool finalRoomCompleted)
        => rooms.Where((room, index) => room.Kind is "Elite" or "Boss"
            && (index < rooms.Count - 1 || cleared || finalRoomCompleted)).ToList();
    public string Summary()
    {
        var parts = new List<string>();
        if (FinalHp != null && MaxHp > 0) parts.Add($"结算生命 {FinalHp}/{MaxHp}");
        if (PotionsRecorded) parts.Add($"结算剩余药水 {RemainingPotions.Count} 瓶" + (RemainingPotions.Count > 0 ? "（" + string.Join("、", RemainingPotions) + "）" : ""));
        if (PotionsUsed != null) parts.Add($"本局使用药水 {PotionsUsed} 次");
        if (Badges.Count > 0) parts.Add("结算徽章：" + string.Join("；", Badges.Select(b => b.Name + "（" + b.Description + "）")));
        if (EncounterSummary() is { Length: > 0 } encounters) parts.Add(encounters);
        return GameText.Plain(string.Join("；", parts));
    }
}
public sealed record RunEncounter(int Act, int Floor, string Kind, string Name);
public sealed class RunBadge
{
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public string Rarity { get; set; } = "";
}
