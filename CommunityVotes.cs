namespace NationalSpire;

/// <summary>程序模拟受众投票；内容更新时计算，界面读取已保存的分数与玩家投票。</summary>
public static class CommunityVotes
{
    public static string VoterId(CareerData data) => string.IsNullOrEmpty(data.LocalHumanId) ? "player" : data.LocalHumanId;
    public static int Choice(CareerData data, CommunityPost post) => Choice(post.PlayerVotes, VoterId(data));
    public static int Choice(CareerData data, CommunityReply reply) => Choice(reply.PlayerVotes, VoterId(data));
    public static long Score(CommunityPost post) => Score(AudienceScore(post.AudienceScore), post.PlayerVotes);
    public static long Score(CareerData data, CommunityReply reply) => Score(AudienceScore(data, reply), reply.PlayerVotes);
    // 沿用社区展示倍率，玩家亲自投票继续按一票计算。
    private const int AudienceMultiplier = 6;
    private const int PlayerReplyMultiplier = 16;
    public static long AudienceScore(int? basis) => (long)(basis ?? 0) * AudienceMultiplier;
    public static long AudienceScore(CareerData data, CommunityReply reply)
        => (long)(reply.AudienceScore ?? 0) * (CommunityThreads.IsHuman(data, reply.AuthorId) ? PlayerReplyMultiplier : AudienceMultiplier);

    /// <summary>随正文更新统一计算主楼和评论；调用者沿原保存通道提交结果。</summary>
    public static void Update(CareerData data, CommunityPost post)
    {
        var people = data.People.ToDictionary(p => p.Id);
        var children = post.Replies.ToLookup(r => r.ParentId);
        var followers = new Dictionary<string, int>();
        int Fans(string id)
        {
            if (followers.TryGetValue(id, out int count)) return count;
            count = id == "player" || id == data.LocalHumanId ? data.Fans
                : people.TryGetValue(id, out var person) ? CareerAudience.Followers(person) : 0;
            return followers[id] = Math.Max(0, count);
        }
        double prominence = post.RelatedPeople.Select(Fans).DefaultIfEmpty(0).Max();
        double occasion = post.MatchKind switch
        { "worldcup" or "worldfinal" or "masters" => 3, "continental" => 2, "league" => 1.5, _ => 1 };
        int Calculate(string id, string author, string body, bool main, int responses)
        {
            int fans = Fans(author);
            double reach = (12 + Math.Sqrt(fans) + .25 * Math.Sqrt(prominence)) * occasion
                * (main ? 1 : .35) * (1 + .2 * Math.Log(1 + responses));
            if (body.Length < 8) reach *= .6;
            string seed = post.Id + ":" + id + ":" + body;
            string authorSeed = post.Id + ":" + author;
            double support = .56 + Math.Min(.12, .018 * Math.Log10(1d + fans))
                + .28 * (2 * Variation(authorSeed, "stance") - 1);
            // 一篇讨论内同一作者共享受众倾向，单条内容只改变传播数量。
            if (author == post.AuthorId) support += .04;
            if (people.TryGetValue(author, out var person))
            {
                if (person.Connections.Contains(post.AuthorId)) support += .03;
                if (people.TryGetValue(post.AuthorId, out var other) && other.ClubId.Length > 0
                    && (person.ClubId == other.ClubId || person.SupportedClubId == other.ClubId)) support += .04;
                if (person.Role.Contains("职业", StringComparison.Ordinal) || person.Titles > 0) support += .02;
            }
            support = Math.Clamp(support, .05, .95);
            double score = reach * (.65 + .7 * Variation(seed, "reach")) * (2 * support - 1);
            return score >= 0 ? (int)Math.Round(score)
                : (int)Math.Round((2 * Variation(authorSeed, "mixed-reception") - .8) * Math.Pow(1 + Math.Abs(score), .2));
        }
        bool changed = false;
        int root = Calculate(post.Id, post.AuthorId, post.Title + "\n" + post.Body, true, post.Replies.Count);
        changed |= post.AudienceScore != root; post.AudienceScore = root;
        foreach (var reply in post.Replies)
        {
            int next = Calculate(reply.Id, reply.AuthorId, reply.Body, false, children[reply.Id].Count());
            changed |= reply.AudienceScore != next; reply.AudienceScore = next;
        }
        if (changed) post.VoteRevision++;
    }

    private static double Variation(string seed, string purpose)
        => CareerEngine.StableHash(seed + ":audience:" + purpose) / (double)int.MaxValue;

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

}
