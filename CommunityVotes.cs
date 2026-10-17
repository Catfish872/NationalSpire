namespace NationalSpire;

/// <summary>AI 受众净值与玩家选择分别保存，界面和命令共用投票与版本合并规则。</summary>
public static class CommunityVotes
{
    public static string VoterId(CareerData data) => string.IsNullOrEmpty(data.LocalHumanId) ? "player" : data.LocalHumanId;
    public static int Choice(CareerData data, CommunityPost post) => Choice(post.PlayerVotes, VoterId(data));
    public static int Choice(CareerData data, CommunityReply reply) => Choice(reply.PlayerVotes, VoterId(data));
    public static long Score(CommunityPost post) => Score(AudienceScore(post.AiNetScore), post.PlayerVotes);
    public static long Score(CareerData data, CommunityReply reply) => Score(AudienceScore(data, reply), reply.PlayerVotes);
    // 主楼及NPC回复6倍，玩家回复维持16倍；读取时应用，存档保留AI原值。
    private const int AudienceMultiplier = 6;
    private const int PlayerReplyMultiplier = 16;
    public static long AudienceScore(int? basis) => (long)(basis ?? 0) * AudienceMultiplier;
    public static long AudienceScore(CareerData data, CommunityReply reply)
        => (long)(reply.AiNetScore ?? 0) * (CommunityThreads.IsHuman(data, reply.AuthorId) ? PlayerReplyMultiplier : AudienceMultiplier);

    private static int Choice(Dictionary<string, int>? votes, string voter)
        => votes?.GetValueOrDefault(voter) is -1 or 1 ? votes[voter] : 0;

    private static long Score(long audience, Dictionary<string, int>? votes)
        => audience + (votes?.Values.Where(v => v is -1 or 1).Sum(v => (long)v) ?? 0);

    /// <summary>写入目标选择；0 表示取消。调用方负责沿所属生涯的原保存通道持久化。</summary>
    public static bool SetVote(CareerData data, string postId, string replyId, int vote, string voterId = "player")
    {
        if (vote is < -1 or > 1) throw new InvalidOperationException("赞踩选择无效。");
        if (!CommunityThreads.IsHuman(data, voterId)) throw new InvalidOperationException("投票玩家无效。");
        var post = CommunityThreads.All(data).FirstOrDefault(p => p.Id == postId)
            ?? throw new InvalidOperationException("帖子已不存在。");
        var reply = replyId.Length == 0 ? null : (post.Replies.FirstOrDefault(r => r.Id == replyId)
            ?? throw new InvalidOperationException("回复的楼层已不存在。"));
        var votes = reply == null ? (post.PlayerVotes ??= []) : (reply.PlayerVotes ??= []);
        if (Choice(votes, voterId) == vote) return false;
        if (vote == 0) votes.Remove(voterId); else votes[voterId] = vote;
        post.VoteRevision++;
        return true;
    }

    public static bool ApplyScore(CommunityPost post, int? score, long sourceRevision)
    {
        if (!score.HasValue || sourceRevision < post.AiScoreRevision
            || (post.AiNetScore == score && post.AiScoreRevision == sourceRevision)) return false;
        post.AiNetScore = score; post.AiScoreRevision = sourceRevision;
        return true;
    }

    public static bool ApplyScore(CommunityReply reply, int? score, long sourceRevision)
    {
        if (!score.HasValue || sourceRevision < reply.AiScoreRevision
            || (reply.AiNetScore == score && reply.AiScoreRevision == sourceRevision)) return false;
        reply.AiNetScore = score; reply.AiScoreRevision = sourceRevision;
        return true;
    }
}
