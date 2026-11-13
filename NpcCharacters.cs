namespace NationalSpire;

/// <summary>固定身份顺序用于保存与打法；当前游戏可用的身份用于新建 NPC。</summary>
public static class NpcCharacters
{
    public static IReadOnlyList<string> Names { get; } = Array.AsReadOnly(new[] { "铁甲战士", "静默猎手", "故障机器人", "亡灵契约师", "储君", "愚者" });
    private static readonly string[] Entries = ["IRONCLAD", "SILENT", "DEFECT", "NECROBINDER", "REGENT", "FOOL"];
    private static Func<IEnumerable<string>> _source = () => Entries.Take(5);
    private static IReadOnlyList<int>? _available;
    public static Func<IEnumerable<string>> Source
    {
        get => _source;
        set { _source = value; _available = null; }
    }
    public static IReadOnlyList<int> Available
    {
        get
        {
            if (_available != null) return _available;
            var current = Source().ToHashSet(StringComparer.Ordinal);
            return _available = Array.AsReadOnly(Entries.Select((entry, index) => (entry, index))
                .Where(pair => current.Contains(pair.entry)).Select(pair => pair.index).ToArray());
        }
    }
    public static int Select(int seed) => Available[(int)((uint)seed % (uint)Available.Count)];
    public static int Index(string name)
    {
        string entry = name.StartsWith("CHARACTER.", StringComparison.OrdinalIgnoreCase) ? name[10..] : name;
        for (int i = 0; i < Names.Count; i++) if (Names[i] == name || Entries[i].Equals(entry, StringComparison.OrdinalIgnoreCase)) return i;
        return name.Equals("The Fool", StringComparison.OrdinalIgnoreCase) ? 5 : -1;
    }
}
