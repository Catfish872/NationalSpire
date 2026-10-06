namespace NationalSpire;

public static class WeeklyArtChoice
{
    public sealed record Card(string Id, string Rarity);
    public static IEnumerable<string> Order(IEnumerable<Card> cards, int importance, string seed, IEnumerable<string> recent, IEnumerable<string> sameIssue)
    {
        string rarity = importance >= 3 ? "Rare" : importance == 2 ? "Uncommon" : "Common";
        var old = recent.ToHashSet(); var current = sameIssue.ToHashSet();
        // 保持新闻等级对应的稀有度；该稀有度用尽后才允许重复。
        return cards.DistinctBy(c => c.Id).OrderByDescending(c => c.Rarity == rarity)
            .ThenBy(c => current.Contains(c.Id)).ThenBy(c => old.Contains(c.Id))
            .ThenBy(c => CareerEngine.StableHash(seed + ":" + c.Id)).ThenBy(c => c.Id, StringComparer.Ordinal).Select(c => c.Id);
    }
}
