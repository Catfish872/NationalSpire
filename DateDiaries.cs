using System.Text.Json;
using System.Text.RegularExpressions;

namespace NationalSpire;

public sealed class DateDiary
{
    public string OfferId { get; set; } = "";
    public int Season { get; set; }
    public int Day { get; set; }
    public string Title { get; set; } = "";
    public string Content { get; set; } = "";
    public string Location { get; set; } = "待整理";
    public string Summary { get; set; } = "";
}

/// <summary>约会日记独立于聊天分页和自动记忆压缩；与结束感想共用一次模型调用。</summary>
public static class DateDiaries
{
    public const string Protocol = "本次约会已由玩家明确结束。先以NPC身份发送自然的私信感想，再在回复末尾附一条隐藏日记标记："
            + "[DateDiary: 用NPC第一人称写下这次相处的经过、印象与感受, Location: 实际约会地点]。"
            + "日记依据下面完整的本次约会记录，约150至350字；只经历开场时如实简述。地点未明确时写地点未明确。"
            + "日记与私信同一轮输出；日记标记放在正文之后，内容中的方括号改用中文圆括号。其余私信交互标记沿用原规则。\n";
    public const string ToolEnding = "本次约会已结束。本轮同时提交两项内容：Replies填写NPC发给玩家的自然私聊感想；Interactions填写一项Type为date_diary的日记记录，DateDiary用NPC第一人称记述本次经过、印象与感受，约150至350字，Location填写实际地点，地点未明确时写地点未明确。只经历开场时如实简述。已有日记时根据本次完整记录重新整理，返回内容用于更新同一篇日记。其他实际交互按各项说明另行填写。";
    public static IReadOnlyList<DateDiary> Records(PrivateConversation conversation)
    {
        var records = conversation.DateDiaries.ToList();
        foreach (var group in conversation.Turns.Where(t => t.Scene is { Opening: true } or { Ending: true }).GroupBy(t => t.Scene!.OfferId))
        {
            if (records.Any(d => d.OfferId == group.Key)) continue;
            var first = group.First(); var offer = conversation.Offers.FirstOrDefault(o => o.Id == group.Key);
            var reflection = group.LastOrDefault(t => t.Scene!.Ending && t.Status == "complete" && !t.ReplyDeleted);
            records.Add(new() { OfferId = group.Key, Season = offer?.Season ?? first.Season, Day = offer?.Day ?? 0,
                Title = offer?.Title ?? first.Scene!.Title, Content = offer?.Detail ?? first.Scene!.Detail,
                Location = "历史记录未标注地点", Summary = reflection?.Reply ?? "这次约会尚未生成日记。" });
        }
        return records;
    }
    public static DateDiary Begin(PrivateConversation conversation, PrivateOffer offer)
    {
        if (conversation.DateDiaries.FirstOrDefault(d => d.OfferId == offer.Id) is { } old) return old;
        var entry = new DateDiary { OfferId = offer.Id, Season = offer.Season, Day = offer.Day, Title = offer.Title,
            Content = offer.Detail.StartsWith("约会内容：", StringComparison.Ordinal) ? offer.Detail[5..] : offer.Detail };
        conversation.DateDiaries.Add(entry); return entry;
    }
    public static string Guidance(PrivateConversation conversation, DateSceneRequest scene)
    {
        var turns = conversation.Turns.Where(t => t.Scene?.OfferId == scene.OfferId && !t.Scene.Ending && t.Status == "complete");
        if (ChatTools.InPrompt) return ToolEnding + "以下为本次约会的完整记录。\n"
            + JsonSerializer.Serialize(new { scene.Title, scene.Detail, turns = turns.Select(t => new { player = t.UserDeleted || t.Scene!.Opening ? null : t.User, npc = t.ReplyDeleted ? null : t.Reply }) });
        return Protocol
            + JsonSerializer.Serialize(new { scene.Title, scene.Detail, turns = turns.Select(t => new { player = t.UserDeleted || t.Scene!.Opening ? null : t.User, npc = t.ReplyDeleted ? null : t.Reply }) });
    }
    public static void Complete(PrivateConversation conversation, PrivateTurn turn, IEnumerable<Dictionary<string, string>> directives)
    {
        if (turn.Scene is not { Ending: true } scene) return;
        var offer = conversation.Offers.FirstOrDefault(o => o.Id == scene.OfferId); if (offer == null) return;
        var entry = Begin(conversation, offer);
        var fields = directives.LastOrDefault(f => f.ContainsKey("DateDiary"));
        string summary = fields?.GetValueOrDefault("DateDiary", "").Trim() ?? "";
        if (summary.Length == 0) { turn.Error += "\n本次感想已保留，约会日记尚未返回。"; return; }
        string location = fields?.GetValueOrDefault("Location", "").Trim() ?? "";
        if (location.Length == 0 && Regex.Match(turn.Reply, @"[,，]\s*Location\s*[:：]\s*([^\r\n\[\]]+)\]?\s*$", RegexOptions.IgnoreCase) is { Success: true } trailing)
        {
            location = trailing.Groups[1].Value.Trim();
            turn.Reply = turn.Reply[..trailing.Index].TrimEnd();
        }
        if (location.Length == 0 && Regex.Match(summary, @"\s*[（(]\s*(?:Location|地点)\s*[:：]\s*([^（）()]+)[）)]\s*$", RegexOptions.IgnoreCase) is { Success: true } inline)
        {
            location = inline.Groups[1].Value.Trim();
            summary = summary[..inline.Index].TrimEnd();
        }
        entry.Summary = summary.Length > 12000 ? summary[..12000] : summary;
        if (location.Length == 0) location = "地点未明确";
        entry.Location = location.Length == 0 ? "地点未明确" : location[..Math.Min(300, location.Length)];
    }
}
