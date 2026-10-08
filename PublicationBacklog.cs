namespace NationalSpire;

/// <summary>合并待生成任务，帖子、赛果和历史快照继续保留。</summary>
public static class PublicationBacklog
{
    public static bool Latest(CareerData data, WeeklyEdition issue) => !data.WeeklyEditions.Any(w => w.Week > issue.Week);
    public static List<CommunityPost> Select(IEnumerable<CommunityPost> candidates, int count, CareerData? data = null)
    {
        string Topic(CommunityPost p) => p.EventKey.StartsWith("match") ? "player-match"
            : p.EventKey.StartsWith("roundup-") || p.EventKey.StartsWith("knockout-") || p.EventKey.StartsWith("champion-") ? "world-match"
            : p.EventKey.StartsWith("life-update-") ? "player-life" : p.NewsTopic.Length > 0 ? p.NewsTopic : p.Category;
        var recent = data == null ? [] : CommunityThreads.All(data).Where(p => p.NewsGeneration.State == "completed")
            .OrderByDescending(p => p.Day).Take(8).ToList();
        var ordered = candidates.OrderByDescending(p => p.EventKey.StartsWith("prematch-") && (data == null || p.Day == data.Day))
            .ThenByDescending(p => p.EventKey.StartsWith("match"))
            .ThenByDescending(p => p.Priority * 10 - Math.Min(15, recent.Count(r => Topic(r) == Topic(p)) * 4))
            .ThenByDescending(p => p.Day).ToList();
        return ordered.DistinctBy(Topic).Concat(ordered).DistinctBy(p => p.Id).Take(Math.Clamp(count, 1, AiOptions.MaximumNewsPostCount)).ToList();
    }
    public static void Compact(CareerData data, bool selectNews = true)
    {
        foreach (var post in CommunityThreads.All(data).Where(p => CareerEngine.ExcludedAutomaticPreview(data, p)
            && p.NewsGeneration.State != "completed"))
        {
            post.AiPending = false;
            CommunityThreads.SetWork(post.NewsGeneration, "superseded");
        }
        foreach (var issue in data.WeeklyEditions.Where(w => !Latest(data, w)))
            foreach (var work in new[] { issue.ProfilesWork, issue.NewsWork })
                if (work.State is "idle" or "queued" or "sending" or "failed") CommunityThreads.SetWork(work, "superseded");
        var automatic = CommunityThreads.All(data).Where(p => p.AuthorId != "player" && !p.Replies.Any(r => r.AuthorId == "player")
            && p.NewsGeneration.State != "completed").ToList();
        var recent = automatic.Where(p => p.Day >= data.Day - 6 && p.AiPending && p.NewsGeneration.State is "idle" or "queued" or "sending").ToList();
        var selected = selectNews ? Select(recent, data.Ai.MaxNewsPosts, data).Select(p => p.Id).ToHashSet() : recent.Select(p => p.Id).ToHashSet();
        foreach (var post in automatic)
        {
            bool stale = post.Day < data.Day - 6;
            bool excess = selectNews && post.AiPending && (post.NewsGeneration.State is "idle" or "queued") && !selected.Contains(post.Id);
            if (!stale && !excess) continue;
            post.AiPending = false;
            if (post.NewsGeneration.State is "idle" or "queued" or "sending" or "failed") CommunityThreads.SetWork(post.NewsGeneration, "superseded");
        }
    }
}
