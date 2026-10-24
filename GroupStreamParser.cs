using System.Text;
using System.Text.RegularExpressions;

namespace NationalSpire;

/// <summary>发言标题识别后立即输出正文；交互独立解析，不要求整个响应组成一个 JSON。</summary>
public sealed class GroupStreamParser
{
    public sealed class Speech(string author)
    {
        public string Author { get; } = author;
        public StringBuilder Body { get; } = new();
    }
    public List<Speech> Messages { get; } = [];
    public PrivateStreamParser Actions { get; } = new("Actor", "Target", "Participants", "Related", "Coach");
    private static readonly Regex Canonical = new(@"^\[\s*Speaker\s*[:：]\s*([^\]\s]+)\s*\]$", RegexOptions.IgnoreCase | RegexOptions.Compiled);
    private static readonly Regex Number = new(@"(?<![\p{L}\p{N}_])p\s*([0-9]+)(?![\p{L}\p{N}_])", RegexOptions.IgnoreCase | RegexOptions.Compiled);
    private static readonly Regex NumberFirst = new(@"^(?:(?:Speaker|发言人|说话人|人物|角色)\s*[:：]?\s*)?p\s*[0-9]+(?:\s*[:：,，|｜/·\-—(（]\s*[^\r\n]+|\s+[^\r\n]+)?$", RegexOptions.IgnoreCase | RegexOptions.Compiled);
    private static readonly Regex NameFirst = new(@"^[^\[\]【】［］()（）:：|｜/]+?[\s:：|｜/·\-—(（]+p\s*[0-9]+\s*[)）]?$", RegexOptions.IgnoreCase | RegexOptions.Compiled);
    private static readonly string[] SpeakerLabels = ["Speaker", "发言人", "说话人", "人物", "角色"];
    private readonly StringBuilder _header = new();
    private bool _actions, _lineStart = true, _headerAtStart;
    private char _close;
    public string Error { get; private set; } = "";
    public void Feed(string value)
    {
        foreach (char c in value)
        {
            if (_actions) { Actions.Feed(c.ToString()); continue; }
            if (_header.Length > 0)
            {
                _header.Append(c);
                if (_close == '\0')
                {
                    string pending = _header.ToString();
                    if (c is ':' or '：' or '\n')
                    {
                        string heading = pending.Trim().TrimEnd(':', '：').TrimEnd();
                        if (TrySpeaker(heading, out string author)) { Messages.Add(new(author)); _header.Clear(); _lineStart = c == '\n'; }
                        else if (c == '\n') { Append(pending); _header.Clear(); }
                    }
                    if (_header.Length > 0 && !BarePrefix(pending)) { Append(pending); _header.Clear(); }
                }
                else if (c == _close)
                {
                    string header = _header.ToString(); _header.Clear();
                    var speaker = Canonical.Match(header);
                    if (Regex.IsMatch(header, @"^\[\s*Actions\s*\]$", RegexOptions.IgnoreCase)) _actions = true;
                    else if (Regex.IsMatch(header, @"^\[\s*(Favour|Attitude|Relationship|Training|Lineup|Activity|Gift|Oath|Contract|Match|Mood|Skill|Post|Profile)\s*[:：]", RegexOptions.IgnoreCase))
                    { _actions = true; Actions.Feed(header); }
                    // 简写只识别行首标题；正文中的人物编号引用仍属于当前发言。
                    else if ((_headerAtStart || speaker.Success) && TrySpeaker(header[1..^1].Trim(), out string author)) { Messages.Add(new(author)); _lineStart = false; }
                    else if (speaker.Success) { Messages.Add(new(Normalize(speaker.Groups[1].Value))); _lineStart = false; }
                    else Append(header);
                }
                else if (c == '\n') { Append(_header.ToString()); _header.Clear(); }
                continue;
            }
            char close = c switch { '[' => ']', '【' => '】', '［' => '］', '(' => ')', '（' => '）', _ => '\0' };
            if (c == '[' || _lineStart && close != '\0') { _header.Append(c); _close = close; _headerAtStart = _lineStart; continue; }
            if (_lineStart && !char.IsWhiteSpace(c) && BarePrefix(c.ToString())) { _header.Append(c); _close = '\0'; continue; }
            Append(c.ToString());
        }
    }
    private void Append(string text)
    {
        foreach (char c in text) { if (c == '\n') _lineStart = true; else if (!char.IsWhiteSpace(c)) _lineStart = false; }
        if (Messages.Count > 0) Messages[^1].Body.Append(text);
        else if (!string.IsNullOrWhiteSpace(text) && !text.Trim().StartsWith("```")) Error = "部分发言缺少人物编号，未归入聊天。";
    }
    private static string Normalize(string author) => Regex.IsMatch(author, @"^p[0-9]+$", RegexOptions.IgnoreCase) ? author.ToLowerInvariant() : author;
    private static bool TrySpeaker(string heading, out string author)
    {
        var numbers = Number.Matches(heading); author = "";
        if (numbers.Count != 1 || !(NumberFirst.IsMatch(heading) || NameFirst.IsMatch(heading))) return false;
        author = "p" + numbers[0].Groups[1].Value; return true;
    }
    private static bool BarePrefix(string text)
    {
        foreach (string label in SpeakerLabels)
        {
            if (label.StartsWith(text, StringComparison.OrdinalIgnoreCase)) return true;
            if (text.StartsWith(label, StringComparison.OrdinalIgnoreCase)) { text = text[label.Length..].TrimStart().TrimStart(':', '：').TrimStart(); break; }
        }
        return text.Length == 0 || Regex.IsMatch(text, @"^p\s*[0-9]*\s*$", RegexOptions.IgnoreCase);
    }
    public void Finish()
    {
        if (_header.Length > 0) { if (_close != ']') Append(_header.ToString()); else Error = "末尾标记未完整返回。"; _header.Clear(); }
        Actions.Finish();
        if (Actions.Error.Length > 0) Error = Actions.Error;
    }
}
