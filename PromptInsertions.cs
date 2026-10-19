using Godot;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace NationalSpire;

public sealed class PromptInsertion
{
    public string Text { get; set; } = "";
    public int Position { get; set; }
}
public sealed class PromptInsertionSettings
{
    public List<PromptInsertion> Slots { get; set; } = [];
    public Dictionary<string, bool[]> Enabled { get; set; } = [];
}
/// <summary>本机共用四段文字，按输入场景保存启用状态；请求保存独立快照。</summary>
public static class PromptInsertions
{
    public static readonly string[] Positions = ["在所有提示词前插入", "在对话输入前插入", "在对话输入后插入", "在所有提示词后插入"];
    public static readonly string[] Scenes = ["private", "group", "community", "date"];
    public static string FilePath => ProjectSettings.GlobalizePath("user://national_spire_prompt_insertions.json");
    private static PromptInsertionSettings? _settings;
    public static PromptInsertionSettings Settings
    {
        get
        {
            if (_settings != null) return _settings;
            try { _settings = File.Exists(FilePath) ? JsonSerializer.Deserialize<PromptInsertionSettings>(File.ReadAllText(FilePath)) : null; }
            catch { GD.PushWarning("[NationalSpire] 提示词插入配置读取失败，使用空白配置。"); }
            _settings ??= new(); Normalize(_settings); return _settings;
        }
    }
    public static void Normalize(PromptInsertionSettings settings)
    {
        settings.Slots ??= []; settings.Enabled ??= [];
        settings.Slots = Enumerable.Range(0, 4).Select(i => settings.Slots.ElementAtOrDefault(i) ?? new()).ToList();
        foreach (var slot in settings.Slots) { slot.Text ??= ""; slot.Position = Math.Clamp(slot.Position, 0, 3); }
        foreach (string scene in Scenes) settings.Enabled[scene] = Enumerable.Range(0, 4).Select(i => settings.Enabled.GetValueOrDefault(scene)?.ElementAtOrDefault(i) == true).ToArray();
    }
    public static void Save()
    {
        string path = FilePath; Directory.CreateDirectory(Path.GetDirectoryName(path)!);
        string temporary = path + ".tmp";
        try { File.WriteAllText(temporary, JsonSerializer.Serialize(Settings, PortraitDesigns.Json)); File.Move(temporary, path, true); }
        finally { if (File.Exists(temporary)) File.Delete(temporary); }
    }
    public static List<PromptInsertion> Capture(string scene)
        => Copy(Settings.Slots.Where((s, i) => Settings.Enabled.GetValueOrDefault(scene)?.ElementAtOrDefault(i) == true));
    public static List<PromptInsertion> Copy(IEnumerable<PromptInsertion>? entries)
        => (entries ?? []).Where(s => s != null && s.Position is >= 0 and <= 3 && !string.IsNullOrWhiteSpace(s.Text)).Take(4)
            .Select(s => new PromptInsertion { Text = s.Text, Position = s.Position }).ToList();
    public static string Around(string text, IEnumerable<PromptInsertion>? entries, int before, int after)
    {
        var active = (entries ?? []).ToArray();
        string prefix = string.Join("\n", active.Where(s => s.Position == before).Select(s => s.Text));
        string suffix = string.Join("\n", active.Where(s => s.Position == after).Select(s => s.Text));
        return (prefix.Length > 0 ? prefix + "\n" : "") + text + (suffix.Length > 0 ? "\n" + suffix : "");
    }
    public static List<Dictionary<string, string>> Apply(List<Dictionary<string, string>> messages, IEnumerable<PromptInsertion>? entries)
    {
        if (messages.Count == 0) return messages;
        var active = (entries ?? []).ToArray();
        messages[0]["content"] = Around(messages[0]["content"], active, 0, -1);
        messages[^1]["content"] = Around(messages[^1]["content"], active, -1, 3);
        return messages;
    }
    internal static List<Dictionary<string, string>> Discussion(AiWireProtocol wire, ISet<string> requested, List<CommunityPost> posts, string system, string context)
    {
        var node = JsonNode.Parse(context)!;
        var snapshots = new List<List<PromptInsertion>>();
        foreach (var target in node["targets"]!.AsArray().OfType<JsonObject>())
        {
            var post = posts.Single(p => p.Id == target["Id"]!.GetValue<string>());
            if (requested.Contains(post.Id)) { target["Body"] = Around(post.Body, post.PromptInsertions, 1, 2); snapshots.Add(post.PromptInsertions); }
            foreach (var reply in target["conversation"]!.AsArray().OfType<JsonObject>())
            {
                string id = reply["Id"]!.GetValue<string>();
                if (!requested.Contains(id)) continue;
                var source = post.Replies.Single(r => r.Id == id);
                reply["Body"] = Around(source.Body, source.PromptInsertions, 1, 2); snapshots.Add(source.PromptInsertions);
            }
        }
        var unique = snapshots.DistinctBy(s => JsonSerializer.Serialize(s)).SelectMany(s => s);
        return Apply([new() { ["role"] = "system", ["content"] = system }, new() { ["role"] = "user", ["content"] = wire.Encode(node.ToJsonString(PortraitDesigns.Json)) }], unique);
    }
}
