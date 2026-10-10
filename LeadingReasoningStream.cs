using System.Text;

namespace NationalSpire;

// 只识别正文开头的思考块；其中的交互示例不进入正文解析器。
internal sealed class LeadingReasoningStream(Action<string> content, Action<string> reasoning)
{
    private const string Open = "<think>", Close = "</think>";
    private readonly StringBuilder pending = new();
    private int state; // 0：判断开头；1：思考；2：正文

    public void Feed(string chunk)
    {
        if (state == 2) { content(chunk); return; }
        pending.Append(chunk);
        if (state == 0)
        {
            string start = pending.ToString().TrimStart();
            if (start.Length == 0 || Open.StartsWith(start, StringComparison.OrdinalIgnoreCase))
            {
                if (start.Length != Open.Length) return;
            }
            else if (!start.StartsWith(Open, StringComparison.OrdinalIgnoreCase))
            { state = 2; content(pending.ToString()); pending.Clear(); return; }
            pending.Clear(); pending.Append(start[Open.Length..]); state = 1;
        }
        string text = pending.ToString();
        int end = text.IndexOf(Close, StringComparison.OrdinalIgnoreCase);
        if (end >= 0)
        {
            reasoning(text[..end]); content(text[(end + Close.Length)..]);
            pending.Clear(); state = 2; return;
        }
        int keep = Math.Min(Close.Length - 1, text.Length);
        while (keep > 0 && !Close.StartsWith(text[^keep..], StringComparison.OrdinalIgnoreCase)) keep--;
        if (text.Length > keep) reasoning(text[..(text.Length - keep)]);
        pending.Clear(); if (keep > 0) pending.Append(text[^keep..]);
    }

    public void Finish()
    {
        if (pending.Length == 0) return;
        if (state == 1) reasoning(pending.ToString()); else content(pending.ToString());
        pending.Clear();
    }
}
