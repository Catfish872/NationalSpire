using System.Text.Json;
using NationalSpire.Coop;

namespace NationalSpire;

public static partial class Diagnostics
{
    internal const int ErrorTextLimit = 1000;
    private const string ErrorReference = "\n诊断编号：";

    /// <summary>完整原文进入所属功能日志，存档字段保留摘要及可定位编号。</summary>
    internal static string RetainError(string error, LogArea area, string context)
    {
        if (error.Length <= ErrorTextLimit) return error;
        string id = Guid.NewGuid().ToString("N");
        using (BeginLog(area, context)) Record("error.full", new { id, context, error });
        string reference = ErrorReference + (int)area + "/" + id;
        string text = PlayerFacingText.LongError(error);
        return (text.Length <= ErrorTextLimit - reference.Length ? text : text[..(ErrorTextLimit - reference.Length - 1)] + "…") + reference;
    }

    internal static string ErrorExplanation(string error)
        => ReadErrorReference(error, out _, out _, out int marker) ? error[..marker] : error;

    private static bool ReadErrorReference(string error, out int area, out string id, out int marker)
    {
        area = 0; id = ""; marker = error.LastIndexOf(ErrorReference, StringComparison.Ordinal);
        if (marker < 0) return false;
        var reference = error[(marker + ErrorReference.Length)..].Split('/');
        if (reference.Length != 2 || !int.TryParse(reference[0], out area) || area < 0 || area >= LogNames.Length
            || !Guid.TryParseExact(reference[1], "N", out _)) return false;
        id = reference[1]; return true;
    }

    /// <summary>只在复制时读取原文；已轮换的记录返回明确的保留范围说明。</summary>
    public static string ErrorDetail(string error)
    {
        if (!ReadErrorReference(error, out int area, out string reference, out _)) return Redact(error);
        string? Find(string line)
        {
            if (!line.Contains(reference, StringComparison.Ordinal)) return null;
            try
            {
                using var row = JsonDocument.Parse(line);
                if (!row.RootElement.TryGetProperty("category", out var category) || category.GetString() != "error.full") return null;
                if (!row.RootElement.TryGetProperty("detail", out var body) || body.ValueKind != JsonValueKind.String) return null;
                using var detail = JsonDocument.Parse(body.GetString()!);
                return detail.RootElement.ValueKind == JsonValueKind.Object && detail.RootElement.TryGetProperty("id", out var id)
                    && id.ValueKind == JsonValueKind.String && id.GetString() == reference
                    && detail.RootElement.TryGetProperty("error", out var original) && original.ValueKind == JsonValueKind.String ? original.GetString() : null;
            }
            catch (JsonException) { return null; }
        }
        foreach (var file in ReadLogs(LogNames[area]))
        {
            using var reader = new StringReader(file.Value);
            while (reader.ReadLine() is { } line) if (Find(line) is { } original) return original;
        }
        string[] recent;
        lock (Gate) recent = Events.ToArray();
        foreach (string line in recent) if (Find(line) is { } original) return original;
        return Redact(error) + "\n完整报错已超出该功能最近5份日志的保留范围。";
    }

    /// <summary>保存、读取和导出共用同一处理；已经带编号的摘要直接沿用。</summary>
    internal static bool RetainErrors(CareerData data)
    {
        string world = data.WorldId;
        bool changed = RetainLifeErrors(data.Life, world + "/" + data.LocalHumanId);
        foreach (var source in data.PrivateMemorySources) changed |= RetainMailboxErrors(source.Value, world + "/" + source.Key);
        foreach (var group in data.Chats.Groups)
        {
            string context = world + "/group/" + group.Id;
            foreach (var conversation in group.Interactions)
            {
                conversation.Value.SummaryError = Keep(conversation.Value.SummaryError, LogArea.Group, context + "/interaction/" + conversation.Key + "/summary");
                foreach (var turn in conversation.Value.Turns)
                    turn.Error = Keep(turn.Error, LogArea.Group, context + "/interaction/" + conversation.Key + "/" + turn.Id);
            }
            group.SummaryError = Keep(group.SummaryError, LogArea.Group, context + "/summary");
            foreach (var turn in group.Turns)
            {
                turn.Error = Keep(turn.Error, LogArea.Group, context + "/" + turn.Id);
                for (int i = 0; i < turn.Notices.Count; i++) turn.Notices[i] = Keep(turn.Notices[i], LogArea.Group, context + "/" + turn.Id + "/notice/" + i);
            }
        }
        foreach (var post in CommunityThreads.All(data))
        {
            string context = world + "/post/" + post.Id;
            Work(post.NewsGeneration, LogArea.Community, context + "/news");
            Work(post.ReactionGeneration, LogArea.Community, context + "/reaction");
            foreach (var reply in post.Replies) Work(reply.ReactionGeneration, LogArea.Community, context + "/reply/" + reply.Id);
        }
        foreach (var issue in data.WeeklyEditions)
        {
            Work(issue.ProfilesWork, LogArea.Weekly, world + "/weekly/" + issue.Week + "/profiles");
            Work(issue.NewsWork, LogArea.Weekly, world + "/weekly/" + issue.Week + "/news");
        }
        return changed;
        void Work(AiWorkState work, LogArea area, string context) => work.Error = Keep(work.Error, area, context);
        string Keep(string error, LogArea area, string context)
        { changed |= error.Length > ErrorTextLimit; return RetainError(error, area, context); }
    }

    private static bool RetainMailboxErrors(PrivateMailbox mailbox, string context)
    {
        bool changed = false;
        foreach (var pair in mailbox.Conversations)
        {
            string conversation = context + "/private/" + pair.Key;
            changed |= pair.Value.SummaryError.Length > ErrorTextLimit;
            pair.Value.SummaryError = RetainError(pair.Value.SummaryError, LogArea.Private, conversation + "/summary");
            foreach (var turn in pair.Value.Turns)
            {
                changed |= turn.Error.Length > ErrorTextLimit;
                turn.Error = RetainError(turn.Error, LogArea.Private, conversation + "/" + turn.Id);
            }
        }
        return changed;
    }

    private static bool RetainLifeErrors(CareerLifeState life, string context)
    {
        bool changed = RetainMailboxErrors(life.Mailbox, context);
        foreach (var record in life.RandomEvents)
        {
            changed |= record.Error.Length > ErrorTextLimit;
            record.Error = RetainError(record.Error, LogArea.Event, context + "/event/" + record.Id);
        }
        return changed;
    }

    internal static void RetainErrors(CoopWorld world)
    {
        RetainErrors(world.World);
        foreach (var member in world.Members) RetainLifeErrors(member.Life, world.Id + "/" + member.PersonId);
    }
}
