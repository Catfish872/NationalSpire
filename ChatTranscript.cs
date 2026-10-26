using System.Text;

namespace NationalSpire;

/// <summary>通讯正文的只读导出；从本会话完整记录选择字段，独立于分页及模型上下文。</summary>
public static class ChatTranscript
{
    public sealed record Message(string AuthorId, int Day, long Order, string Text);
    public sealed record Document(string Title, string ConversationId, string Kind, List<Message> Messages);

    public static Document Private(CareerData data, PrivateConversation conversation)
    {
        var messages = new List<Message>();
        foreach (var turn in conversation.Turns.Where(PrivateMessages.VisibleInCommunications))
        {
            if (turn.RequestKind == "event") continue;
            if (!turn.UserDeleted && turn.ProactiveReason.Length == 0 && turn.Scene?.Ending != true && turn.User.Length > 0)
                messages.Add(new(GroupChats.Human(data), turn.Day, turn.UserOrder, turn.User));
            if (!turn.ReplyDeleted && turn.Reply.Length > 0)
                messages.Add(new(conversation.PersonId, turn.Day, turn.ReplyOrder, turn.Reply));
        }
        return new(GroupChats.Name(data, conversation.PersonId), conversation.PersonId, "私聊", Ordered(messages));
    }

    public static Document Group(CareerData data, GroupChat group)
    {
        var messages = group.Entries.Where(e => !e.Notice && e.Text.Length > 0)
            .Select(e => new Message(e.Author, e.Day, e.Order, e.Text)).ToList();
        foreach (var turn in group.Turns)
        {
            if (turn.Text.Length > 0) messages.Add(new(turn.Sender, turn.Day, turn.Order, turn.Text));
            if (turn.Status == "complete")
            {
                foreach (var reply in turn.Replies.Where(r => !r.Notice && r.Text.Length > 0))
                    messages.Add(new(reply.Author, reply.Day, reply.Order, reply.Text));
            }
            else
            {
                // 中断回复沿用通讯的正文解析器，只导出已保存且可显示的发言。
                var parser = new GroupStreamParser(); parser.Feed(turn.Raw);
                foreach (var (speech, index) in parser.Messages.Select((speech, index) => (speech, index)))
                {
                    string author = group.Resolve(speech.Author), body = speech.Body.ToString().Trim();
                    if (body.Length > 0 && GroupChats.SpeechUnavailable(data, group, author).Length == 0)
                        messages.Add(new(author, turn.Day, index < turn.SpeechOrders.Count ? turn.SpeechOrders[index] : turn.Order, body));
                }
            }
        }
        return new(group.Name, group.Id, "群聊", Ordered(messages));
    }

    private static List<Message> Ordered(IEnumerable<Message> messages) => messages.OrderBy(m => m.Day).ThenBy(m => m.Order).ToList();

    public static string Markdown(CareerData data, Document document)
    {
        static string Inline(string value) => value.Replace("\r", " ").Replace("\n", " ").Replace("`", "\\`");
        var text = new StringBuilder().AppendLine("# " + document.Kind + "记录 · " + Inline(document.Title))
            .AppendLine().AppendLine("会话 ID：" + Inline(document.ConversationId))
            .AppendLine().AppendLine("时间使用存档中的游戏日期；同日消息按发言顺序排列。")
            .AppendLine().AppendLine($"共 {document.Messages.Count} 条已保存消息。");
        int index = 0;
        foreach (var message in document.Messages)
        {
            text.AppendLine().AppendLine($"## {++index} · {Inline(GroupChats.Name(data, message.AuthorId))}")
                .AppendLine().AppendLine("人物 ID：" + Inline(message.AuthorId))
                .AppendLine().AppendLine("日期：" + GameCalendar.Text(data, message.Day))
                .AppendLine().AppendLine("发言顺序：" + (message.Order > 0 ? message.Order.ToString() : "旧记录未保存同日顺序"))
                .AppendLine();
            foreach (string line in message.Text.Replace("\r\n", "\n").Split('\n')) text.Append("> ").AppendLine(line);
        }
        return text.ToString();
    }

    public static string Write(CareerData data, Document document, string directory)
    {
        Directory.CreateDirectory(directory);
        string path = Path.Combine(directory, $"国运尖塔-{document.Kind}记录-{DateTime.Now:yyyyMMdd-HHmmss}-{Guid.NewGuid():N}.md");
        using var writer = new StreamWriter(new FileStream(path, FileMode.CreateNew, FileAccess.Write), new UTF8Encoding(false));
        writer.Write(Markdown(data, document)); return path;
    }
}
