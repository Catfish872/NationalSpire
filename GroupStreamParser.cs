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
    private readonly StringBuilder _header = new();
    private bool _actions;
    public string Error { get; private set; } = "";
    public void Feed(string value)
    {
        foreach (char c in value)
        {
            if (_actions) { Actions.Feed(c.ToString()); continue; }
            if (_header.Length > 0)
            {
                _header.Append(c);
                if (c == ']')
                {
                    string header = _header.ToString(); _header.Clear();
                    var speaker = Regex.Match(header, @"^\[\s*Speaker\s*[:：]\s*([^\]\s]+)\s*\]$", RegexOptions.IgnoreCase);
                    if (speaker.Success) Messages.Add(new(speaker.Groups[1].Value));
                    else if (Regex.IsMatch(header, @"^\[\s*Actions\s*\]$", RegexOptions.IgnoreCase)) _actions = true;
                    else if (Regex.IsMatch(header, @"^\[\s*(Favour|Attitude|Relationship|Training|Lineup|Activity|Contract|Match|Mood|Skill|Post|Profile)\s*[:：]", RegexOptions.IgnoreCase))
                    { _actions = true; Actions.Feed(header); }
                    else Append(header);
                }
                else if (c == '\n') { Append(_header.ToString()); _header.Clear(); }
                continue;
            }
            if (c == '[') { _header.Append(c); continue; }
            Append(c.ToString());
        }
    }
    private void Append(string text)
    {
        if (Messages.Count > 0) Messages[^1].Body.Append(text);
        else if (!string.IsNullOrWhiteSpace(text) && !text.Trim().StartsWith("```")) Error = "部分发言缺少人物编号，未归入聊天。";
    }
    public void Finish()
    {
        if (_header.Length > 0) { Error = "末尾标记未完整返回。"; _header.Clear(); }
        Actions.Finish();
        if (Actions.Error.Length > 0) Error = Actions.Error;
    }
}
