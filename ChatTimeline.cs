using System.Text;

namespace NationalSpire;

public static class ChatTimeline
{
    public sealed record Item(long Order, int Day, string Role, string Text, string Source = "");
    public const string Privacy = "历史中穿插的外部会话记录，表示交流在相应位置发生于其他私信或群聊，不表示内容曾发送到当前会话。只有标注的知情人物知道其中内容；其他人物依据知情人在当前会话实际说出的内容回应。来源摘要中的我、你按照标注的作者和对象理解。";
    public const string PrivateHistoryNote = "聊天记录中可能穿插有外部会话记录，表示这段交流记录在对应时间发生于其他群聊。";
    public static IEnumerable<GroupChat> RelatedGroups(CareerData d, IEnumerable<string> people, string excludeGroup = "")
    {
        var members = people.Where(id => !GroupChats.IsHuman(d, id)).ToHashSet();
        return d.Chats.Groups.Where(g => g.Id != excludeGroup && members.Any(p => ChatMembership.Knows(g, p)));
    }
    public static IEnumerable<Item> External(CareerData d, IEnumerable<string> people, string excludeGroup = "", string excludePrivate = "")
    {
        var members = people.ToHashSet();
        var events = new HashSet<string>();
        foreach (var (human, box) in Mailboxes(d))
        {
            foreach (var c in box.Conversations.Values.Where(c => members.Contains(c.PersonId) && (c.PersonId != excludePrivate || human != GroupChats.Human(d))))
            {
                string source = $"私信：{GroupChats.Name(d, human)}与{GroupChats.Name(d, c.PersonId)}；知情人：{GroupChats.Name(d, human)}、{GroupChats.Name(d, c.PersonId)}";
                foreach (var t in c.Turns.Where(t => t.Status == "complete" && t.Day <= d.Day).TakeLast(5))
                {
                    if (t.RequestKind == "event")
                    {
                        if (!t.UserDeleted && events.Add(t.Id))
                        {
                            var readers = Mailboxes(d).SelectMany(m => m.Value.Conversations.Values).Where(v => members.Contains(v.PersonId) && v.Turns.Any(r => r.Id == t.Id && !r.UserDeleted)).Select(v => GroupChats.Name(d, v.PersonId)).Distinct();
                            yield return new(t.UserOrder, t.Day, "user", t.User, "共同经历；知情人：" + string.Join("、", readers));
                        }
                        continue;
                    }
                    string historySource = source + (DateGames.HistorySource(t) is { Length: > 0 } gameSource ? "；" + gameSource : "");
                    if (!t.UserDeleted && t.ProactiveReason.Length == 0 && string.IsNullOrEmpty(t.Scene?.GameEvent)) yield return new(t.UserOrder, t.Day, "user", GroupChats.Name(d, human) + "：" + PrivateMessagePrompts.UserText(d, t, c), historySource);
                    if (!t.ReplyDeleted) yield return new(t.ReplyOrder, t.Day, "user", GroupChats.Name(d, c.PersonId) + "：" + t.Reply, historySource);
                }
            }
        }
        foreach (var g in RelatedGroups(d, members, excludeGroup))
        {
            foreach (var t in g.Turns.Where(t => t.Status == "complete" && t.Day <= d.Day && members.Any(p => ChatMembership.Knows(g, p, t.Order))).TakeLast(5))
            {
                string source = $"群聊《{g.Name}》；知情人：{string.Join("、", ChatMembership.Readers(g, t.Order).Select(id => GroupChats.Name(d, id)))}";
                if (t.Text.Length > 0 || t.Attachments.Count > 0) yield return new(t.Order, t.Day, "user", GroupChats.Name(d, t.Sender) + "：" + GroupChatPrompts.UserText(d, g, t), source);
                foreach (var r in t.Replies) yield return new(r.Order, r.Day, "user", GroupChats.Name(d, r.Author) + "：" + r.Text, source);
            }
        }
    }
    public static IEnumerable<KeyValuePair<string, PrivateMailbox>> Mailboxes(CareerData d)
        => d.PrivateMemorySources.Concat(new[] { KeyValuePair.Create(GroupChats.Human(d), d.Life.Mailbox) }).DistinctBy(p => p.Key);
    public static string Summaries(CareerData d, IEnumerable<string> people, string excludeGroup = "", string excludePrivate = "")
    {
        var members = people.ToHashSet(); var b = new StringBuilder();
        void Add(string source, IEnumerable<PrivateSummary> big, IEnumerable<PrivateSummary> small)
        {
            var large = big.LastOrDefault(); var recent = small.LastOrDefault(s => s.Through > (large?.Through ?? 0));
            if (large == null && recent == null) return;
            b.AppendLine("<private_memory>").AppendLine(source);
            if (large != null) b.AppendLine($"长期总结（第{large.From + 1}至{large.Through}轮）：" + large.Text);
            if (recent != null) b.AppendLine($"近期总结（第{recent.From + 1}至{recent.Through}轮）：" + recent.Text);
            b.AppendLine("</private_memory>");
        }
        foreach (var (human, box) in Mailboxes(d).OrderBy(x => x.Key, StringComparer.Ordinal))
            foreach (var c in box.Conversations.Values.Where(c => members.Contains(c.PersonId) && (c.PersonId != excludePrivate || human != GroupChats.Human(d))).OrderBy(c => c.PersonId, StringComparer.Ordinal))
                Add($"私信知情人：{GroupChats.Name(d, human)}、{GroupChats.Name(d, c.PersonId)}。第一人称总结作者：{GroupChats.Name(d, c.PersonId)}，对象：{GroupChats.Name(d, human)}。", c.BigSummaries, c.SmallSummaries);
        foreach (var g in RelatedGroups(d, members, excludeGroup).OrderBy(g => g.Id, StringComparer.Ordinal))
        {
            var summaries = members.Where(p => ChatMembership.Knows(g, p)).SelectMany(p => new[] { true, false }
                .SelectMany(big => ChatMembership.Summaries(g, p, big).TakeLast(1).Select(s => (Person: p, Big: big, Summary: s))))
                .GroupBy(x => (x.Big, x.Summary.Id));
            foreach (var group in summaries)
            {
                var first = group.First();
                Add($"群聊《{g.Name}》；知情人：{string.Join("、", group.Select(x => GroupChats.Name(d, x.Person)))}。",
                    first.Big ? [first.Summary] : [], first.Big ? [] : [first.Summary]);
            }
        }
        return b.ToString();
    }
    public static string Text(CareerData d, Item item) => item.Source.Length == 0 ? item.Text :
        "<private_memory>\n" + item.Source + "\n" + PrivateAppointments.DateText(d, item.Day) + (item.Order == 0 ? "（旧记录未记录同日先后）" : "") + "\n" + item.Text + "\n</private_memory>";
    public static IEnumerable<Item> PrivateHistory(CareerData d, PrivateConversation c, PrivateTurn? pending)
    {
        var own = new List<Item>();
        foreach (var t in c.Turns.Skip(c.ContextStart).Where(t => t.Status == "complete" && t != pending))
        {
            if (t.RequestKind == "event") { if (!t.UserDeleted) own.Add(new(t.UserOrder, t.Day, "user", Text(d, new(t.UserOrder, t.Day, "user", t.User, "共同经历")))); continue; }
            string source = DateGames.HistorySource(t);
            if (!t.UserDeleted && t.ProactiveReason.Length == 0 && string.IsNullOrEmpty(t.Scene?.GameEvent)) own.Add(new(t.UserOrder, t.Day, "user", $"{GameCalendar.Text(d, t.Day)}，{CareerEngine.Name(d)}" + (t.RequestKind == "arbitration" ? "提交给官方的仲裁申请\n" : pending?.Scene != null && t.Scene != null ? "在约会中的消息\n" : $"发给{GroupChats.Name(d, c.PersonId)}的消息\n") + PrivateMessagePrompts.UserText(d, t, c), source));
            if (!t.ReplyDeleted) own.Add(new(t.ReplyOrder, t.Day, "assistant", pending?.Scene != null && t.Scene != null ? DateScenes.PromptHistory(t, c.PersonId) : t.Reply, source));
        }
        var recent = c.Turns.Where(t => t.Status == "complete").ToArray();
        int retained = PrivateMessages.Mailbox(d).Settings.RecentRounds;
        long start = recent.Length > retained ? recent.TakeLast(Math.Max(1, retained)).Select(t => t.UserOrder).DefaultIfEmpty(0).Min() : 0;
        return own.Concat(External(d, [c.PersonId], excludePrivate: c.PersonId)
            .Where(x => x.Order >= start && (pending == null || pending.UserOrder == 0 || x.Order < pending.UserOrder)))
            .OrderBy(x => x.Day).ThenBy(x => x.Order);
    }
    public static object[] PublicMemories(CareerData d, string person, int day) => d.Chats.Groups.Where(g => ChatMembership.Knows(g, person)).Select(g => PublicMemory(d, g, person, day)).ToArray();
    private static object PublicMemory(CareerData d, GroupChat g, string person, int day) => new
    {
        群聊 = g.Name, 说明 = "这是该人物参加的群聊记忆，不是帖子里已经公开的发言。其他人只知道公开说出的部分。", 知情人 = g.Members.Select(id => GroupChats.Name(d, id)).ToArray(),
        大总结 = ChatMembership.Summaries(g, person, true).LastOrDefault(s => g.Turns[s.Through - 1].Day <= day)?.Text,
        小总结 = ChatMembership.Summaries(g, person, false).LastOrDefault(s => g.Turns[s.Through - 1].Day <= day)?.Text,
        最近记录 = g.Turns.Where(t => t.Status == "complete" && t.Day <= day && ChatMembership.Knows(g, person, t.Order)).TakeLast(5).Select(t => new { 日期 = PrivateAppointments.DateText(d, t.Day), 知情人 = ChatMembership.Readers(g, t.Order).Select(p => GroupChats.Name(d, p)).ToArray(), 发言 = t.Replies.Select(r => new { 人物 = GroupChats.Name(d, r.Author), 内容 = r.Text }), 玩家姓名 = GroupChats.Name(d, t.Sender), 玩家消息 = t.Text }).ToArray()
    };

    /// <summary>一次发帖或回帖请求共享群聊资料；日期与群聊编号共同确定可见版本。</summary>
    public sealed class PublicMemoryRequest(CareerData data)
    {
        private readonly Dictionary<(string Group, int Day, long From, long Through), object> _records = [];
        public string[] For(string person, int day) => data.Chats.Groups.Where(g => ChatMembership.Knows(g, person))
            .OrderBy(g => g.Id, StringComparer.Ordinal).Select(g =>
            {
                long from = g.MemoryStarts.GetValueOrDefault(person), through = g.Members.Contains(person) ? long.MaxValue : g.Departures[person].ThroughOrder;
                string id = g.Id + ":" + day + ":" + from + ":" + through;
                if (!_records.ContainsKey((g.Id, day, from, through))) _records.Add((g.Id, day, from, through), new { reference = id, content = PublicMemory(data, g, person, day) });
                return id;
            }).ToArray();
        public object[] Records => _records.OrderBy(x => x.Key.Group, StringComparer.Ordinal).ThenBy(x => x.Key.Day).Select(x => x.Value).ToArray();
    }
}
