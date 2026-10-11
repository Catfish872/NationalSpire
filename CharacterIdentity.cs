
namespace NationalSpire;

public sealed record CharacterDefinition(string Id, string DisplayName);

/// <summary>职业名称从游戏提供；只处理独立职业字段，不扫描玩家或模型正文。</summary>
public static class CharacterIdentity
{
    public static Func<IEnumerable<CharacterDefinition>> Source { get; set; } = () => [];
    private static readonly IReadOnlyDictionary<string, string> Empty = new Dictionary<string, string>();
    public static Func<IReadOnlyDictionary<string, string>> OriginalSource { get; set; } = () => Empty;
    public static string? OriginalName(string id)
    {
        return OriginalSource().GetValueOrDefault(id);
    }
    public static string ForResult(CareerResult result)
    {
        using var cost = UiPerformance.Measure(UiPerformance.Work.CharacterName);
        return Resolve(result.CharacterId, result.Character, ReadDefinitions);
    }
    private static string Resolve(string id, string display, Func<IEnumerable<CharacterDefinition>> source)
    {
        if (OriginalName(id) is { } original) return original;
        return source().FirstOrDefault(c => string.Equals(c.Id, id, StringComparison.OrdinalIgnoreCase))?.DisplayName
            ?? (display.Length > 0 ? display : id);
    }
    // 仅转换程序提供的职业字段，用户文字和已保存的历史正文不经过替换。
    public static string Name(CareerData data, string name)
    {
        using var cost = UiPerformance.Measure(UiPerformance.Work.CharacterName);
        var aliases = Aliases(data);
        if (aliases.TryGetValue(name, out string? converted)) return converted;
        if (OriginalName(name) is { } original) return original;
        foreach (var pair in aliases)
            if (pair.Key != pair.Value && name == pair.Key + "（" + pair.Value + "）") return pair.Value;
        return name;
    }
    internal static Dictionary<string, string> Aliases(CareerData data)
    {
        var candidates = new List<(string Alias, string Original)>();
        void Add(string id, string display, string? resolved = null)
        {
            // 未知职业保留自身名称，同时参与重名检查，避免将真正的新职业误判为皮肤。
            string original = resolved ?? OriginalName(id) ?? display;
            if (display.Length > 0) candidates.Add((display, original));
            if (id.Length > 0) candidates.Add((id, original));
        }
        var definitions = ReadDefinitions();
        foreach (var pair in OriginalSource()) Add(pair.Key, pair.Value);
        foreach (var character in definitions) Add(character.Id, character.DisplayName);
        foreach (var result in data.Results.Where(r => r.CharacterId.Length > 0))
            Add(result.CharacterId, result.Character, Resolve(result.CharacterId, result.Character, () => definitions));
        // 有多个来源的同名文字保留原值，不能将模组界面名称当作原版编号。
        return candidates.GroupBy(p => p.Alias, StringComparer.Ordinal)
            .ToDictionary(g => g.Key, g => g.Select(p => p.Original).Distinct().Count() == 1 ? g.First().Original : g.Key, StringComparer.Ordinal);
    }
    private static CharacterDefinition[] ReadDefinitions()
    {
        try { return Source().ToArray(); }
        catch (Exception e) { Diagnostics.Error("character.identity", e); return []; }
    }
}
