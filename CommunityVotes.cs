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

    // 长词在前，按命中片段前进；否定表达先于其中包含的肯定词匹配。
    private static readonly (string Text, int Tone)[] Expressions =
    [
        ("不同意", -1), ("不赞同", -1), ("不支持", -1), ("不认可", -1), ("说得不对", -1),
        ("并非垃圾", 0), ("不是垃圾", 0), ("不是造谣", 0), ("没有造谣", 0),
        ("支持", 1), ("赞同", 1), ("认可", 1), ("说得对", 1), ("恭喜", 1), ("加油", 1),
        ("感谢", 1), ("谢谢", 1), ("精彩", 1), ("厉害", 1), ("👍", 1),
        ("反对", -1), ("质疑", -1), ("胡说", -1), ("造谣", -1), ("垃圾", -1), ("恶心", -1), ("👎", -1)
    ];

    /// <summary>随正文更新统一计算主楼和评论；调用者沿原保存通道提交结果。</summary>
    public static void Update(CareerData data, CommunityPost post)
    {
        var people = data.People.ToDictionary(p => p.Id);
        var replies = post.Replies.ToDictionary(r => r.Id);
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
        int Calculate(string id, string author, string body, string target, bool main, int responses)
        {
            int fans = Fans(author), targetFans = target == author ? 0 : Fans(target);
            int tone = Tone(body);
            double reach = (12 + Math.Sqrt(fans) + .25 * Math.Sqrt(prominence)) * occasion
                * (main ? 1 : .35) * (1 + .2 * Math.Log(1 + responses));
            if (body.Length < 8) reach *= .6;
            string seed = post.Id + ":" + id + ":" + body;
            double support = .56 + Math.Min(.12, .018 * Math.Log10(1d + fans))
                + .28 * (2 * Variation(seed, "stance") - 1) + .04 * tone;
            // 提及对象的支持者改变投票倾向；相同俱乐部与熟人关系影响讨论接受度。
            if (targetFans > 0) support += .22 * tone * Math.Sqrt(targetFans / (1d + fans + targetFans));
            if (people.TryGetValue(author, out var person))
            {
                if (person.Connections.Contains(target)) support += .03 * tone;
                if (people.TryGetValue(target, out var other) && other.ClubId.Length > 0
                    && (person.ClubId == other.ClubId || person.SupportedClubId == other.ClubId)) support += .04 * tone;
                if (person.Role.Contains("职业", StringComparison.Ordinal) || person.Titles > 0) support += .02;
            }
            support = Math.Clamp(support, .05, .95);
            return (int)Math.Round(reach * (.65 + .7 * Variation(seed, "reach")) * (2 * support - 1));
        }
        bool changed = false;
        int root = Calculate(post.Id, post.AuthorId, post.Title + "\n" + post.Body,
            post.MentionedPeople.FirstOrDefault() ?? post.RelatedPeople.FirstOrDefault(p => p != post.AuthorId) ?? "", true, post.Replies.Count);
        changed |= post.AudienceScore != root; post.AudienceScore = root;
        foreach (var reply in post.Replies)
        {
            string target = reply.MentionedPeople.FirstOrDefault()
                ?? (replies.TryGetValue(reply.ParentId, out var parent) ? parent.AuthorId : post.AuthorId);
            int next = Calculate(reply.Id, reply.AuthorId, reply.Body, target, false, children[reply.Id].Count());
            changed |= reply.AudienceScore != next; reply.AudienceScore = next;
        }
        if (changed) post.VoteRevision++;
    }

    private static double Variation(string seed, string purpose)
        => CareerEngine.StableHash(seed + ":audience:" + purpose) / (double)int.MaxValue;

    private static int Tone(string body)
    {
        int total = 0;
        for (int i = 0; i < body.Length; i++)
            foreach (var expression in Expressions)
                if (body.AsSpan(i).StartsWith(expression.Text, StringComparison.Ordinal))
                { total += expression.Tone; i += expression.Text.Length - 1; break; }
        return Math.Sign(total);
    }

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
