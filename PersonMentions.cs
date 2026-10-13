namespace NationalSpire;

/// <summary>本地人物名称索引；最长名称优先，重名仅在相关人物中能够唯一确定时链接。</summary>
public sealed class PersonMentions
{
    public sealed record Match(int Start, int Length, string PersonId);
    private sealed class Branch
    {
        public Dictionary<char, Branch> Children { get; } = [];
        public HashSet<string> People { get; } = [];
    }
    private readonly Branch _root = new();
    public PersonMentions(IEnumerable<(string Id, string Name)> names)
    {
        foreach (var (id, name) in names)
        {
            if (name.Trim().Length < 2 || name.Length > 100) continue;
            var node = _root;
            foreach (char raw in name)
            {
                char c = char.ToUpperInvariant(raw);
                if (!node.Children.TryGetValue(c, out var child)) node.Children[c] = child = new();
                node = child;
            }
            node.People.Add(id);
        }
    }
    private static bool Latin(char c) => c is >= 'a' and <= 'z' or >= 'A' and <= 'Z' or >= '0' and <= '9' or '_' or '-';

    /// <summary>@ 人物与"选人"弹窗共用的搜索：在**全部人物**里按昵称 / 姓名匹配，前缀命中优先。
    /// 空查询返回世界名录的开头一段（与 @ 输入框刚打出 "@" 时的行为一致）。</summary>
    public static List<CareerPerson> Search(CareerData d, string query, int take) => d.People
        .Where(p => PrivateMessages.CanChat(d, p.Id))
        .Where(p => query.Length == 0 || p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(query, StringComparison.OrdinalIgnoreCase))
        .OrderByDescending(p => query.Length > 0 && p.PublicName.StartsWith(query, StringComparison.OrdinalIgnoreCase))
        .ThenBy(p => p.PublicName)
        .Take(take).ToList();
    public List<Match> Find(string text, IEnumerable<string>? related = null)
    {
        var context = related?.ToHashSet() ?? [];
        var result = new List<Match>();
        for (int start = 0; start < text.Length; start++)
        {
            if (Latin(text[start]) && start > 0 && Latin(text[start - 1])) continue;
            var node = _root; Match? best = null;
            for (int end = start; end < text.Length && node.Children.TryGetValue(char.ToUpperInvariant(text[end]), out node); end++)
            {
                if (node.People.Count == 0 || Latin(text[end]) && end + 1 < text.Length && Latin(text[end + 1])) continue;
                var candidates = node.People.Count == 1 ? node.People.ToList() : node.People.Where(context.Contains).ToList();
                // 较长重名也覆盖较短匹配，避免把完整昵称的一部分链接到另一个人。
                best = candidates.Count == 1 ? new(start, end - start + 1, candidates[0]) : null;
            }
            if (best == null) continue;
            result.Add(best); start += best.Length - 1;
        }
        return result;
    }
}
