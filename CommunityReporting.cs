using System.Text.Encodings.Web;
using System.Text.Json;

namespace NationalSpire;

/// <summary>从权威社区内容建立举报案件快照；提交、审理及处罚沿用私信仲裁。</summary>
public static class CommunityReporting
{
    public const string Kind = "community-report";
    private static readonly JsonSerializerOptions ReportJson = new() { Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping };

    public static bool IsReport(PrivateTurn turn) => turn.RequestKind == "arbitration" && turn.Request?.Kind == Kind;

    public static PrivateOffer Create(CareerData data, string personId, string postId, string replyId = "")
    {
        var report = CommunitySharing.Create(data, postId, replyId);
        var quote = report.Quote!;
        replyId = quote.ReplyId;
        if (quote.AuthorId != personId || !PrivateMessages.CanChat(data, personId))
            throw new InvalidOperationException("社区举报仅针对该内容的 NPC 作者，请重新打开来源内容。");
        var post = CommunityThreads.All(data).First(p => p.Id == quote.PostId);
        var discussion = CommunityThreads.ContextReplies(post, data.Day, anchors: replyId.Length > 0 ? [replyId] : null);
        int total = post.Replies.Where(r => r.Day <= data.Day).DistinctBy(r => r.Id).Count();
        string Evidence() => JsonSerializer.Serialize(new
        {
            type = "community_report",
            sourcePost = new { id = quote.PostId, revision = quote.PostRevision, title = quote.PostTitle,
                authorId = quote.PostAuthorId, author = quote.PostAuthorName, day = quote.PostDay, body = quote.PostBody,
                recordedEvent = quote.PostAiSourceBody ?? quote.PostSourceBody },
            reported = new { id = replyId.Length == 0 ? quote.PostId : replyId, kind = replyId.Length == 0 ? "post" : "reply",
                parentId = quote.ParentId, authorId = quote.AuthorId, author = quote.AuthorName, day = quote.Day, body = quote.Body },
            discussionComplete = discussion.Count == total,
            totalReplies = total,
            discussion = discussion.Select(r => new { id = r.Id, parentId = r.ParentId, authorId = r.AuthorId,
                author = CareerEngine.DisplayName(data, r.AuthorId), day = r.Day, body = r.Body })
        }, ReportJson);
        report.Kind = Kind;
        report.Detail = "社区举报案件材料\n" + report.Detail + "\n\n来源帖子正文\n" + quote.PostBody
            + (quote.PostSourceBody.Length > 0 ? "\n\n已记录事件\n" + quote.PostSourceBody : "")
            + (discussion.Count > 0 ? (discussion.Count == total ? "\n\n帖子讨论（完整记录）\n" : "\n\n帖子讨论（开头、近期与被举报分支）\n")
                + string.Join("\n\n", discussion.Select(r => CareerEngine.DisplayName(data, r.AuthorId) + "：\n" + r.Body)) : "");
        report.AiDetail = "社区举报案件材料\n" + Evidence();
        return report;
    }
}
