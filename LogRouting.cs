namespace NationalSpire;

internal enum LogArea { Runtime, Private, Group, Community, Weekly, Event, Match, Storage }

public static partial class Diagnostics
{
    // 文件组按功能固定，人物、会话和重试编号只进入记录正文。
    private static readonly string[] LogNames = ["national-spire.log", "private.jsonl", "group.jsonl", "community.jsonl",
        "weekly.jsonl", "random-events.jsonl", "matches.jsonl", "storage.jsonl"];
    private sealed record LogContext(LogArea Area, string Context);
    private static readonly AsyncLocal<LogContext?> CurrentLog = new();
    private sealed class LogScope(LogContext? previous) : IDisposable
    { public void Dispose() => CurrentLog.Value = previous; }

    internal static IDisposable BeginLog(LogArea area, string context)
    {
        var previous = CurrentLog.Value;
        CurrentLog.Value = new(area, context);
        return new LogScope(previous);
    }

    internal static IDisposable RequestLog(string task, string context)
        => BeginLog(CurrentLog.Value?.Area ?? (task switch
        { "group" => LogArea.Group, "event" => LogArea.Event, _ => LogArea.Private }),
            context.Length > 0 ? context : CurrentLog.Value?.Context ?? "");

    private static LogArea AreaFor(string category)
    {
        int end = category.IndexOf('.');
        string prefix = end < 0 ? category : category[..end];
        // 共用请求代码沿用发起功能，不能按共用方法的 private 名称归类。
        if (prefix is "private" or "ai" or "chat") return CurrentLog.Value?.Area ?? (prefix == "private" ? LogArea.Private : LogArea.Runtime);
        return prefix switch
        {
            "group" => LogArea.Group, "community" or "discussion" => LogArea.Community,
            "weekly" => LogArea.Weekly, "event" => LogArea.Event,
            "match" or "simulation" or "run" => LogArea.Match,
            "career" or "coop" or "save" or "native" => LogArea.Storage,
            _ => CurrentLog.Value?.Area ?? LogArea.Runtime
        };
    }

    private static IEnumerable<KeyValuePair<string, string>> ReadAutomaticLogs()
        => LogNames.SelectMany(ReadLogs);
}
