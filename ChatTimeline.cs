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
        return d.Chats.Groups.Where(g => g.Id != excludeGroup && g.Members.Any(members.Contains));
    }
    public static IEnumerable<Item> External(CareerData d, IEnumerable<string> people, string excludeGroup = "", string excludePrivate = "")
    {
        var members = people.ToHashSet();
        foreach (var (human, box) in Mailboxes(d))
        {
            foreach (var c in box.Conversations.Values.Where(c => members.Contains(c.PersonId) && (c.PersonId != excludePrivate || human != GroupChats.Human(d))))
            {
                string source = $"私信：{GroupChats.Name(d, human)}与{GroupChats.Name(d, c.PersonId)}；知情人：{GroupChats.Name(d, human)}、{GroupChats.Name(d, c.PersonId)}";
                foreach (var t in c.Turns.Where(t => t.Status == "complete" && t.Day <= d.Day).TakeLast(5))
                {
                    if (!t.UserDeleted) yield return new(t.UserOrder, t.Day, "user", GroupChats.Name(d, human) + "：" + PrivateMessagePrompts.UserText(t, c), source);
                    if (!t.ReplyDeleted) yield return new(t.ReplyOrder, t.Day, "user", GroupChats.Name(d, c.PersonId) + "：" + t.Reply, source);
                }
            }
        }
        foreach (var g in RelatedGroups(d, members, excludeGroup))
        {
            string source = $"群聊《{g.Name}》；知情人：{string.Join("、", g.Members.Select(id => GroupChats.Name(d, id)))}";
            foreach (var t in g.Turns.Where(t => t.Status == "complete" && t.Day <= d.Day).TakeLast(5))
            {
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
            Add($"群聊《{g.Name}》；知情人：{string.Join("、", g.Members.Select(id => GroupChats.Name(d, id)))}。", g.BigSummaries, g.SmallSummaries);
        return b.ToString();
    }
    public static string Text(CareerData d, Item item) => item.Source.Length == 0 ? item.Text :
        "<private_memory>\n" + item.Source + "\n" + PrivateAppointments.DateText(d, item.Day) + (item.Order == 0 ? "（旧记录未记录同日先后）" : "") + "\n" + item.Text + "\n</private_memory>";
    public static IEnumerable<Item> PrivateHistory(CareerData d, PrivateConversation c, PrivateTurn? pending)
    {
        var own = new List<Item>();
        foreach (var t in c.Turns.Skip(c.ContextStart).Where(t => t.Status == "complete" && t != pending))
        {
            if (!t.UserDeleted) own.Add(new(t.UserOrder, t.Day, "user", $"第 {t.Season} 赛季第 {SeasonCalendar.Day(d, t.Day)} 天，{CareerEngine.Name(d)}" + (t.RequestKind == "arbitration" ? "提交给官方的仲裁申请\n" : $"发给{GroupChats.Name(d, c.PersonId)}的消息\n") + PrivateMessagePrompts.UserText(t, c)));
            if (!t.ReplyDeleted) own.Add(new(t.ReplyOrder, t.Day, "assistant", t.Reply));
        }
        var recent = c.Turns.Where(t => t.Status == "complete").ToArray();
        int retained = PrivateMessages.Mailbox(d).Settings.RecentRounds;
        long start = recent.Length > retained ? recent.TakeLast(Math.Max(1, retained)).Select(t => t.UserOrder).DefaultIfEmpty(0).Min() : 0;
        return own.Concat(External(d, [c.PersonId], excludePrivate: c.PersonId)
            .Where(x => x.Order >= start && (pending == null || pending.UserOrder == 0 || x.Order < pending.UserOrder)))
            .OrderBy(x => x.Day).ThenBy(x => x.Order);
    }
    public static object[] PublicMemories(CareerData d, string person, int day) => d.Chats.Groups.Where(g => g.Members.Contains(person)).Select(g => (object)new
    {
        群聊 = g.Name, 说明 = "这是该人物参加的群聊记忆，不是帖子里已经公开的发言。其他人只知道公开说出的部分。", 知情人 = g.Members.Select(id => GroupChats.Name(d, id)).ToArray(),
        大总结 = g.BigSummaries.LastOrDefault(s => s.Through > 0 && s.Through <= g.Turns.Count && g.Turns[s.Through - 1].Day <= day)?.Text,
        小总结 = g.SmallSummaries.LastOrDefault(s => s.Through > 0 && s.Through <= g.Turns.Count && g.Turns[s.Through - 1].Day <= day)?.Text,
        最近记录 = g.Turns.Where(t => t.Status == "complete" && t.Day <= day).TakeLast(5).Select(t => new { 日期 = PrivateAppointments.DateText(d, t.Day), 发言 = t.Replies.Select(r => new { 人物 = GroupChats.Name(d, r.Author), 内容 = r.Text }), 玩家姓名 = GroupChats.Name(d, t.Sender), 玩家消息 = t.Text }).ToArray()
    }).ToArray();
}
