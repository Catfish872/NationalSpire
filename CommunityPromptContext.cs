using System.Text;

namespace NationalSpire;

/// <summary>按整次聊天选择评论分支；帖子正文与事件事实由调用者完整提供。</summary>
public static class CommunityPromptContext
{
    public static Dictionary<string, List<CommunityReply>> SelectReplies(IEnumerable<CommunityPost> sources, int day,
        IEnumerable<string> participants, string query, CommunityMemorySearch.Request request, IEnumerable<CommunityMemory>? sourceMemories = null)
    {
        using var measurement = UiPerformance.Measure(UiPerformance.Work.CommunityBranches);
        var people = participants.ToHashSet();
        var posts = sources.DistinctBy(p => p.Id).OrderBy(p => p.Id, StringComparer.Ordinal).ToArray();
        var candidates = posts.SelectMany(p => p.Replies.Where(r => r.Day <= day).DistinctBy(r => r.Id)
            .Select((r, index) => (Post: p, Reply: r, Index: index))).ToArray();
        var recent = candidates.Where(x => people.Contains(x.Reply.AuthorId))
            .OrderByDescending(x => x.Reply.Day).ThenByDescending(x => x.Index).ThenBy(x => x.Reply.Id, StringComparer.Ordinal).Take(8);
        var queryTerms = request.GetTerms(query);
        var topical = candidates.Select(x => (Item: x, Score: CommunityMemorySearch.TopicScore(queryTerms, x.Reply)))
            .Where(x => x.Score > 0).OrderByDescending(x => x.Score).ThenByDescending(x => x.Item.Reply.Day)
            .ThenBy(x => x.Item.Reply.Id, StringComparer.Ordinal).Take(8).Select(x => x.Item);
        var required = sourceMemories?.Select(m => m.Id).ToHashSet();
        var anchors = recent.Concat(topical).Concat(candidates.Where(x => required?.Contains(x.Post.Id + ":" + x.Reply.Id) == true))
            .DistinctBy(x => (x.Post.Id, x.Reply.Id)).ToLookup(x => x.Post.Id, x => x.Reply);
        var result = new Dictionary<string, List<CommunityReply>>();
        foreach (var post in posts)
        {
            var available = post.Replies.Where(r => r.Day <= day).DistinctBy(r => r.Id).ToDictionary(r => r.Id);
            var chosen = new HashSet<string>();
            void AddChain(CommunityReply reply)
            {
                while (chosen.Add(reply.Id) && available.TryGetValue(reply.ParentId, out var parent)) reply = parent;
            }
            foreach (var reply in anchors[post.Id])
            {
                AddChain(reply);
                var response = available.Values.Where(r => r.ParentId == reply.Id).OrderByDescending(r => r.Day).ThenByDescending(r => post.Replies.IndexOf(r)).FirstOrDefault();
                if (response != null) AddChain(response);
            }
            result[post.Id] = available.Values.Where(r => chosen.Contains(r.Id)).ToList();
        }
        return result;
    }

    public static string Comments(CareerData data, IEnumerable<CommunityPost> posts, Dictionary<string, List<CommunityReply>> selected)
    {
        var text = new StringBuilder();
        foreach (var post in posts.DistinctBy(p => p.Id).OrderBy(p => p.Id, StringComparer.Ordinal))
        {
            if (!selected.TryGetValue(post.Id, out var replies) || replies.Count == 0) continue;
            text.AppendLine($"《{post.Title}》的相关讨论（发言代表作者的观点）");
            var parents = replies.ToDictionary(r => r.Id);
            foreach (var reply in replies)
            {
                string target = parents.TryGetValue(reply.ParentId, out var parent) ? CareerEngine.DisplayName(data, parent.AuthorId) : "原帖";
                text.AppendLine($"{PrivateAppointments.DateText(data, reply.Day)}，{CareerEngine.DisplayName(data, reply.AuthorId)}回复{target}：{reply.Body}");
            }
        }
        return text.ToString().Trim();
    }
}
