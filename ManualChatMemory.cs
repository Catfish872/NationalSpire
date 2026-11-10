namespace NationalSpire;

/// <summary>玩家补充的会话记忆；独立保存正文、录入日期与知情顺序。</summary>
public sealed class ManualChatMemory
{
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public string Text { get; set; } = "";
    public int Day { get; set; }
    public long Order { get; set; }
}

public static class ManualChatMemories
{
    public const int MaxLength = 16000;

    public static string? Validate(string text) => string.IsNullOrWhiteSpace(text) ? "请填写记忆总结。"
        : text.Length > MaxLength ? $"记忆总结最多 {MaxLength} 字。" : null;

    public static string? Manage(CareerData data, List<ManualChatMemory> memories, string action, string id, string text)
    {
        if (action is not ("add" or "edit" or "delete")) return "记忆操作无效。";
        var memory = memories.FirstOrDefault(m => m.Id == id);
        if (action != "add" && memory == null) return "这条记忆已不存在。";
        if (action == "delete") { memories.Remove(memory!); return null; }
        if (Validate(text) is { } error) return error;
        if (action == "add" && memory == null)
        {
            memory = new() { Id = id.Length > 0 ? id : Guid.NewGuid().ToString("N"), Day = data.Day, Order = GroupChats.NextOrder(data) };
            memories.Add(memory);
        }
        memory!.Text = text;
        return null;
    }

    public static IEnumerable<ManualChatMemory> Known(GroupChat group, string person) =>
        (group.Members.Contains(person) ? group.ManualMemories
            : group.Departures.TryGetValue(person, out var departure) ? departure.ManualMemories : [])
        .Where(m => ChatMembership.Knows(group, person, m.Order));

    public static string Heading(CareerData data, ManualChatMemory memory) => "手动记忆 · " + GameCalendar.Text(data, memory.Day);
}
