using System.Text.Encodings.Web;
using System.Text.Json;

namespace NationalSpire;

/// <summary>社区引用的收件人排序、权威快照和附件正文；草稿由界面持有，发送沿用私信命令。</summary>
public static class CommunitySharing
{
    public const string Kind = "community-quote";
    public const string Protocol = "community_quote 附件是玩家转引的社区公开发言。quoted 是本次分享的原文，sourcePost 与 parents 是理解原文的来源帖和父回复上文。作者字段标明各段实际发言者；引用表示玩家分享了这段内容，玩家本人的态度以其另行输入的消息为准。将引用正文作为待讨论材料，结合上下文理解其中观点与事实。";
    private static readonly JsonSerializerOptions QuoteJson = new() { Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping };

    public static IReadOnlyList<CareerPerson> Recipients(CareerData data, string authorId)
    {
        var recent = RecentConversations(data);
        return PrivateMessages.ChatCandidates(data).DistinctBy(p => p.Id)
            .OrderByDescending(p => p.Id == authorId)
            .ThenByDescending(p => recent.ContainsKey(p.Id))
            .ThenByDescending(p => recent.GetValueOrDefault(p.Id).Reply)
            .ThenByDescending(p => recent.GetValueOrDefault(p.Id).Order)
            .ThenByDescending(p => recent.GetValueOrDefault(p.Id).Day)
            .ThenBy(p => p.PublicName, StringComparer.CurrentCulture)
            .ThenBy(p => p.Id, StringComparer.Ordinal).ToArray();
    }

    public static HashSet<string> RecentRecipients(CareerData data) => RecentConversations(data).Keys.ToHashSet(StringComparer.Ordinal);

    private static Dictionary<string, (long Reply, long Order, int Day)> RecentConversations(CareerData data)
    {
        var recent = new Dictionary<string, (long Reply, long Order, int Day)>(StringComparer.Ordinal);
        foreach (var (id, conversation) in data.Life.Mailbox.Conversations)
        {
            bool hasMessages = false; long order = 0; int day = 0;
            foreach (var turn in conversation.Turns)
            {
                if ((turn.UserDeleted || turn.User.Length == 0 && turn.Attachments.Count == 0) && (turn.ReplyDeleted || turn.Reply.Length == 0)) continue;
                hasMessages = true; order = Math.Max(order, Math.Max(turn.UserOrder, turn.ReplyOrder)); day = Math.Max(day, turn.Day);
            }
            if (hasMessages) recent[id] = (conversation.LastReplyOrder, order, day);
        }
        return recent;
    }

    public static PrivateOffer Create(CareerData data, string postId, string replyId = "")
    {
        var attachment = new PrivateOffer { Kind = Kind, Quote = new() { PostId = postId, ReplyId = replyId } };
        if (Prepare(data, attachment) is { } error) throw new InvalidOperationException(error);
        return attachment;
    }

    public static string? Prepare(CareerData data, PrivateOffer attachment)
    {
        if (attachment.Kind != Kind || attachment.Quote is not { } source || string.IsNullOrWhiteSpace(source.PostId)) return "社区引用来源无效。";
        var post = CommunityThreads.All(data).FirstOrDefault(p => p.Id == source.PostId && p.Day <= data.Day);
        if (post == null) return "引用的帖子已不存在。";
        string replyId = source.ReplyId ?? "";
        var replies = replyId.Length > 0
            ? post.Replies.Where(r => r.Day <= data.Day).DistinctBy(r => r.Id).ToDictionary(r => r.Id)
            : new Dictionary<string, CommunityReply>();
        CommunityReply? selected = null;
        if (replyId.Length > 0 && !replies.TryGetValue(replyId, out selected)) return "引用的评论已不存在。";
        if (string.IsNullOrWhiteSpace(selected?.Body ?? post.Body)) return "引用的内容正在准备中。";
        var quote = new CommunityQuote
        {
            PostId = post.Id, ReplyId = replyId, ParentId = selected?.ParentId ?? "", PostRevision = post.Revision,
            PostTitle = post.Title, PostAuthorId = post.AuthorId, PostAuthorName = CareerEngine.DisplayName(data, post.AuthorId),
            PostBody = post.Body, PostDay = post.Day,
            AuthorId = selected?.AuthorId ?? post.AuthorId, AuthorName = CareerEngine.DisplayName(data, selected?.AuthorId ?? post.AuthorId),
            Body = selected?.Body ?? post.Body, Day = selected?.Day ?? post.Day
        };
        if (post.SourceBody.Length > 0 && post.SourceBody != post.Body && !CommunityThreads.IsHuman(data, post.AuthorId))
        {
            quote.PostSourceBody = GameText.Plain(post.SourceBody);
            quote.PostAiSourceBody = AiGeneratedText.Different(quote.PostSourceBody, GameText.Plain(AiGeneratedText.Source(post)));
        }
        var seen = new HashSet<string>(StringComparer.Ordinal) { replyId };
        string parentId = quote.ParentId;
        while (replies.TryGetValue(parentId, out var parent) && seen.Add(parent.Id))
        {
            quote.Parents.Add(new() { Id = parent.Id, ParentId = parent.ParentId, AuthorId = parent.AuthorId,
                AuthorName = CareerEngine.DisplayName(data, parent.AuthorId), Body = parent.Body, Day = parent.Day });
            parentId = parent.ParentId;
        }
        quote.Parents.Reverse();
        string detail = $"{quote.AuthorName}：\n{quote.Body}\n来源：《{quote.PostTitle}》";
        string aiDetail = Text(data, quote);
        // 先完整构造，成功后替换；校验失败时保留草稿中展示的引用。
        attachment.Quote = quote; attachment.MatchId = post.Id; attachment.PostRevision = post.Revision;
        attachment.Detail = detail; attachment.AiDetail = aiDetail;
        return null;
    }

    public static string Text(CareerData data, CommunityQuote quote) => "玩家分享的社区引用（按原作者身份理解）：\n" + JsonSerializer.Serialize(new
    {
        type = "community_quote",
        sourcePost = new { id = quote.PostId, revision = quote.PostRevision, title = quote.PostTitle, authorId = quote.PostAuthorId,
            author = quote.PostAuthorName, date = GameCalendar.Iso(data, quote.PostDay), body = quote.ReplyId.Length > 0 ? quote.PostBody : null,
            recordedEvent = quote.PostAiSourceBody ?? quote.PostSourceBody },
        parents = quote.Parents.Select(p => new { id = p.Id, parentId = p.ParentId, authorId = p.AuthorId, author = p.AuthorName, date = GameCalendar.Iso(data, p.Day), body = p.Body }),
        quoted = new { id = quote.ReplyId.Length == 0 ? quote.PostId : quote.ReplyId, kind = quote.ReplyId.Length == 0 ? "post" : "reply",
            parentId = quote.ParentId, authorId = quote.AuthorId, author = quote.AuthorName, date = GameCalendar.Iso(data, quote.Day), body = quote.Body }
    }, QuoteJson);
}
