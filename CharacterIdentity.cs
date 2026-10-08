using System.Text.Json.Nodes;

namespace NationalSpire;

public sealed record CharacterDefinition(string Id, string DisplayName);

/// <summary>原版职业按模型标识识别；皮肤显示名在运行时读取，不维护皮肤名称表。</summary>
public static class CharacterIdentity
{
    public static Func<IEnumerable<CharacterDefinition>> Source { get; set; } = () => [];
    private static readonly Dictionary<string, string> Originals = new(StringComparer.OrdinalIgnoreCase)
    {
        ["IRONCLAD"] = "铁甲战士", ["SILENT"] = "静默猎手", ["DEFECT"] = "故障机器人",
        ["NECROBINDER"] = "亡灵契约师", ["REGENT"] = "储君"
    };
    public static string? OriginalName(string id)
    {
        string key = id.StartsWith("CHARACTER.", StringComparison.OrdinalIgnoreCase) ? id[10..] : id;
        return Originals.GetValueOrDefault(key);
    }
    public static string ForResult(CareerResult result) => OriginalName(result.CharacterId) ?? result.Character;
    internal static Dictionary<string, string> Aliases(CareerData data)
    {
        var candidates = new List<(string Alias, string Original)>();
        void Add(string id, string display)
        {
            // 未知职业保留自身名称，同时参与重名检查，避免将真正的新职业误判为皮肤。
            string original = OriginalName(id) ?? display;
            if (display.Length > 0) candidates.Add((display, original));
            if (id.Length > 0) candidates.Add((id, original));
        }
        foreach (var pair in Originals) { Add(pair.Key, pair.Value); Add("CHARACTER." + pair.Key, pair.Value); }
        try { foreach (var character in Source()) Add(character.Id, character.DisplayName); }
        catch (Exception e) { Diagnostics.Error("character.identity", e); }
        foreach (var result in data.Results.Where(r => r.CharacterId.Length > 0)) Add(result.CharacterId, result.Character);
        return candidates.GroupBy(p => p.Alias, StringComparer.Ordinal).Where(g => g.Select(p => p.Original).Distinct().Count() == 1)
            .ToDictionary(g => g.Key, g => g.First().Original, StringComparer.Ordinal);
    }
    // 只处理即将发送的资料副本，界面、存档、原始发言和人物身份均保持原样。
    internal static void Apply(JsonNode node, IReadOnlyDictionary<string, string> aliases, IEnumerable<string>? identityNames = null)
    {
        var replacements = new Dictionary<string, string>(aliases, StringComparer.Ordinal);
        foreach (var pair in aliases.Where(p => p.Key != p.Value))
            replacements.TryAdd(pair.Key + "（" + pair.Value + "）", pair.Value);
        string Pattern(string name)
        {
            string escaped = System.Text.RegularExpressions.Regex.Escape(name);
            return name.All(c => char.IsAsciiLetterOrDigit(c) || c is '.' or '_')
                ? @"(?<![A-Za-z0-9_.])" + escaped + @"(?![A-Za-z0-9_.])" : escaped;
        }
        var names = (identityNames ?? []).Where(n => n.Length > 0).Distinct().OrderByDescending(n => n.Length).Select(Pattern).ToArray();
        var pattern = new System.Text.RegularExpressions.Regex((names.Length > 0 ? "(?<identity>" + string.Join("|", names) + ")|" : "") + string.Join("|", replacements.Keys
            .OrderByDescending(k => k.Length).ThenBy(k => k, StringComparer.Ordinal).Select(Pattern)));
        string Convert(string text) => pattern.Replace(text, match => match.Groups["identity"].Success ? match.Value : replacements[match.Value]);
        void Visit(JsonNode value, bool identity = false)
        {
            if (identity) return;
            if (value is JsonArray array)
                for (int i = 0; i < array.Count; i++)
                {
                    if (array[i] is JsonValue item && item.TryGetValue<string>(out var text)) array[i] = Convert(text);
                    else if (array[i] is { } child) Visit(child);
                }
            else if (value is JsonObject obj)
                foreach (string key in obj.Select(p => p.Key).ToArray())
                {
                    // 标识与姓名承担引用关系，不作为职业名称处理。
                    bool keep = key.Equals("name", StringComparison.OrdinalIgnoreCase) || key.EndsWith("Id", StringComparison.OrdinalIgnoreCase)
                        || key is "allowedAuthors" or "People" or "原ID" or "现ID";
                    if (keep) continue;
                    if (obj[key] is JsonValue item && item.TryGetValue<string>(out var text)) obj[key] = Convert(text);
                    else if (obj[key] is { } child) Visit(child);
                }
        }
        Visit(node);
    }
}
