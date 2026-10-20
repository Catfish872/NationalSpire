using System.Text.Json;
using System.Text;

namespace NationalSpire;

public sealed record EventLive(string Title, string Story, int Options)
{
    public List<RandomEventOption> Choices { get; init; } = [];
    public string Reasoning { get; init; } = "";
    public string Phase { get; init; } = "排队中";
}

public sealed class RandomEventRecord
{
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public int Day { get; set; }
    public string State { get; set; } = "waiting";
    public string Seed { get; set; } = "";
    public string Category { get; set; } = "";
    public List<string> People { get; set; } = [];
    public string Materials { get; set; } = "";
    public string Title { get; set; } = "未知的际遇";
    public string Story { get; set; } = "";
    public string Reasoning { get; set; } = "";
    public List<RandomEventOption> Options { get; set; } = [];
    public string Error { get; set; } = "";
    public int Selected { get; set; } = -1;
    public bool Public { get; set; }
    public List<string> MatchIds { get; set; } = [];
    public HashSet<string> RememberedMatches { get; set; } = [];
}
public sealed class RandomEventOption
{
    public string Text { get; set; } = "";
    public string Result { get; set; } = "";
    public List<Dictionary<string, JsonElement>> Effects { get; set; } = [];
}
public sealed class EventStatus
{
    public string Source { get; set; } = "";
    public string Name { get; set; } = "";
    public int Until { get; set; }
    public double Percent { get; set; }
}

/// <summary>正文、选项和效果分开读取；完整选项才参与执行，流式半段仅用于显示。</summary>
public sealed class RandomEventParser
{
    private readonly StringBuilder _pending = new();
    public string Title { get; private set; } = "未知的际遇";
    public string Story { get; private set; } = "";
    public List<RandomEventOption> Options { get; } = [];
    public string LiveStory => Story + PartialStory(_pending.ToString());
    public void Feed(string chunk)
    {
        foreach (char ch in chunk)
            if (ch == '\n') { Read(_pending.ToString()); _pending.Clear(); } else _pending.Append(ch);
    }
    public void Finish() { Read(_pending.ToString()); _pending.Clear(); }
    public void Validate()
    {
        if (Story.Trim().Length == 0 || Options.Count is < 2 or > 4 || Options.Any(o => o.Text.Length == 0 || o.Result.Length == 0))
            throw new InvalidDataException("故事或结局尚未完整生成，可以重试或跳过。");
    }
    private void Read(string line)
    {
        line = line.Trim(); if (line.Length == 0 || line.StartsWith("```")) return;
        using var doc = JsonDocument.Parse(line); var root = doc.RootElement;
        if (root.TryGetProperty("title", out var title)) Title = title.GetString() ?? "";
        if (root.TryGetProperty("story", out var story)) Story += (story.GetString() ?? "") + "\n\n";
        if (root.TryGetProperty("option", out var option)) Options.Add(new()
        {
            Text = option.GetString() ?? "", Result = root.GetProperty("result").GetString() ?? "",
            Effects = root.TryGetProperty("effects", out var effects) ? JsonSerializer.Deserialize<List<Dictionary<string, JsonElement>>>(effects.GetRawText()) ?? [] : []
        });
    }
    private static string PartialStory(string text)
    {
        int key = text.IndexOf("\"story\"", StringComparison.Ordinal); if (key < 0) return "";
        int colon = text.IndexOf(':', key + 7); if (colon < 0) return "";
        int start = text.IndexOf('"', colon + 1); if (start < 0) return "";
        var result = new StringBuilder();
        for (int i = start + 1; i < text.Length; i++)
        {
            char ch = text[i]; if (ch == '"') break;
            if (ch == '\\')
            {
                if (++i >= text.Length) break;
                ch = text[i];
                if (ch == 'u')
                {
                    if (i + 4 >= text.Length) break;
                    if (ushort.TryParse(text.AsSpan(i + 1, 4), System.Globalization.NumberStyles.HexNumber, null, out ushort unicode)) result.Append((char)unicode);
                    i += 4; continue;
                }
                ch = ch switch { 'n' => '\n', 'r' => '\r', 't' => '\t', _ => ch };
            }
            result.Append(ch);
        }
        return result.ToString();
    }
}
