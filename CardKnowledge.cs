namespace NationalSpire;

public sealed record CardReference(string Id, string Name, string Description);

/// <summary>加载后的卡牌定义按首字建立索引；每次只读取本轮玩家文字，固定指令保持同一前缀。</summary>
public static class CardKnowledge
{
    public static Func<IEnumerable<CardReference>> Source { get; set; } = () => [];
    public static Func<string> SourceVersion { get; set; } = () => "";
    private static readonly object Gate = new();
    private static string? _version;
    private static Dictionary<char, CardReference[]> _index = [];
    public static string Find(string text)
    {
        if (string.IsNullOrWhiteSpace(text)) return "";
        Dictionary<char, CardReference[]> index;
        lock (Gate)
        {
            string version = SourceVersion();
            if (_version != version)
            {
                _index = Source().Where(c => c.Name.Length > 0).GroupBy(c => char.ToUpperInvariant(c.Name[0]))
                    .ToDictionary(g => g.Key, g => g.OrderByDescending(c => c.Name.Length).ThenBy(c => c.Id, StringComparer.Ordinal).ToArray());
                _version = version;
            }
            index = _index;
        }
        var found = new Dictionary<string, CardReference>();
        for (int i = 0; i < text.Length; i++)
        {
            if (!index.TryGetValue(char.ToUpperInvariant(text[i]), out var candidates)) continue;
            int longest = 0;
            foreach (var card in candidates)
                if (card.Name.Length >= longest && text.AsSpan(i).StartsWith(card.Name, StringComparison.OrdinalIgnoreCase))
                { longest = card.Name.Length; found.TryAdd(card.Id, card); }
            if (longest > 0) i += longest - 1;
        }
        return found.Count == 0 ? "" : "本轮提及的卡牌\n" + string.Join("\n", found.Values.Select(c => c.Description));
    }
}
