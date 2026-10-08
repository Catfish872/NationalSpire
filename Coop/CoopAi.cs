namespace NationalSpire.Coop;

/// <summary>任务保留自己的资料快照，只合并生成内容，不能覆盖正在变化的经济和赛程。</summary>
public sealed class CoopAi(CoopCoordinator session)
{
    private bool _running, _pending;
    private readonly object _gate = new();
    private readonly HashSet<(string Generation, string World, string Epoch, string Message)> _discussions = [];
    private string _generation = Guid.NewGuid().ToString("N");
    public void Stop() { lock (_gate) _generation = Guid.NewGuid().ToString("N"); }
    public Task Process(bool retry = false)
    {
        lock (_gate)
        {
            if (!session.Host || session.World == null) return Task.CompletedTask;
            var source = session.World;
            var tasks = new List<Task>();
            foreach (string id in CommunityThreads.PendingIds(source.World).ToArray())
            {
                var key = (_generation, source.Id, source.Epoch, id);
                if (_discussions.Add(key)) tasks.Add(ProcessDiscussion(source, key));
            }
            tasks.Add(ProcessPublications(retry));
            return Task.WhenAll(tasks);
        }
    }
    private async Task ProcessDiscussion(CoopWorld source, (string Generation, string World, string Epoch, string Message) key)
    {
        try
        {
            var data = CoopJson.Copy(source.World); data.Ai = AiSettingsStore.Load(new());
            data.PrivateMemorySources = source.Members.ToDictionary(m => m.PersonId, m => CoopJson.Copy(m.Life.Mailbox));
            var originalReplies = CommunityThreads.All(data).SelectMany(p => p.Replies).Select(r => r.Id).ToHashSet();
            data.ExternalCurrent = () => key.Generation == _generation && session.World?.Id == key.World && session.World?.Epoch == key.Epoch;
            data.ExternalSave = _ =>
            {
                lock (_gate)
                {
                if (!data.ExternalCurrent()) return;
                var next = CoopJson.Copy(session.World!); CoopJson.Detached(next.World); bool changed = false;
                foreach (var post in CommunityThreads.All(data))
                {
                    var current = CommunityThreads.All(next.World).FirstOrDefault(p => p.Id == post.Id);
                    if (current == null) continue;
                    bool updated = false;
                    // 每项请求只追加自己的新评论、更新自己的处理状态，保留其他并发请求的结果。
                    foreach (var reply in post.Replies.Where(r => !originalReplies.Contains(r.Id)))
                        if (!current.Replies.Any(r => r.Id == reply.Id)) { current.Replies.Add(CoopJson.Copy(reply)); updated = true; }
                    if (post.Id == key.Message && (current.NeedsReaction != post.NeedsReaction
                        || CoopJson.Hash(CoopJson.Bytes(current.ReactionGeneration)) != CoopJson.Hash(CoopJson.Bytes(post.ReactionGeneration))))
                    { current.NeedsReaction = post.NeedsReaction; current.ReactionGeneration = CoopJson.Copy(post.ReactionGeneration); updated = true; }
                    if (post.Replies.FirstOrDefault(r => r.Id == key.Message) is { } generated
                        && current.Replies.FirstOrDefault(r => r.Id == key.Message) is { } existing
                        && (existing.NeedsReaction != generated.NeedsReaction
                            || CoopJson.Hash(CoopJson.Bytes(existing.ReactionGeneration)) != CoopJson.Hash(CoopJson.Bytes(generated.ReactionGeneration))))
                    { existing.NeedsReaction = generated.NeedsReaction; existing.ReactionGeneration = CoopJson.Copy(generated.ReactionGeneration); updated = true; }
                    if (updated) { current.Revision++; CommunityThreads.Remember(next.World, current); changed = true; }
                }
                if (changed) { next.Revision++; session.Commit(next, session.NativeSave); }
                }
            };
            await AiService.ProcessInteractionsAsync([key.Message], data);
        }
        catch (Exception e) { Diagnostics.Error("coop.ai.discussion", e); }
        finally { lock (_gate) _discussions.Remove(key); }
    }
    private async Task ProcessPublications(bool retry)
    {
        if (!session.Host || session.World == null) return;
        _pending = true; if (_running) return; _running = true;
        string generation = _generation;
        try
        {
            while (_pending && generation == _generation && session.World != null)
            {
                _pending = false;
                var source = session.World;
                var data = CoopJson.Copy(source.World); data.Ai = AiSettingsStore.Load(new());
                data.PrivateMemorySources = source.Members.ToDictionary(m => m.PersonId, m => CoopJson.Copy(m.Life.Mailbox));
                var knownPosts = CommunityThreads.All(data).ToDictionary(p => p.Id, p => CoopJson.Hash(CoopJson.Bytes(p)));
                var originalReplies = CommunityThreads.All(data).ToDictionary(p => p.Id, p => p.Replies.Select(r => r.Id).ToHashSet());
                var knownWeeks = data.WeeklyEditions.ToDictionary(p => p.Week, p => CoopJson.Hash(CoopJson.Bytes(p)));
                data.ExternalCurrent = () => generation == _generation && session.World?.Id == source.Id && session.World?.Epoch == source.Epoch;
                data.ExternalSave = _ =>
                {
                    lock (_gate)
                    {
                    if (!data.ExternalCurrent()) return;
                    var next = CoopJson.Copy(session.World!); CoopJson.Detached(next.World); bool changed = false;
                    foreach (var post in CommunityThreads.All(data))
                    {
                        string hash = CoopJson.Hash(CoopJson.Bytes(post));
                        if (knownPosts.GetValueOrDefault(post.Id) == hash) continue;
                        var current = CommunityThreads.All(next.World).FirstOrDefault(p => p.Id == post.Id);
                        if (current == null || current.SourceBody != post.SourceBody) continue;
                        var updated = CoopJson.Copy(post);
                        // 只保留任务开始后新增的回复，已被生成结果替换的预制评论不能重新加入。
                        var original = originalReplies.GetValueOrDefault(post.Id);
                        updated.NeedsReaction = current.NeedsReaction; updated.ReactionGeneration = CoopJson.Copy(current.ReactionGeneration);
                        for (int i = 0; i < updated.Replies.Count; i++)
                            if (original?.Contains(updated.Replies[i].Id) == true && current.Replies.FirstOrDefault(r => r.Id == updated.Replies[i].Id) is { } latest)
                                updated.Replies[i] = CoopJson.Copy(latest);
                        updated.Replies.AddRange(current.Replies.Where(r => original?.Contains(r.Id) != true && !updated.Replies.Any(a => a.Id == r.Id)));
                        updated.Revision = Math.Max(current.Revision, updated.Revision) + 1;
                        Replace(next.World.Posts, updated); Replace(next.World.SavedThreads, updated);
                        CommunityThreads.Remember(next.World, updated); knownPosts[post.Id] = hash; changed = true;
                    }
                    foreach (var issue in data.WeeklyEditions)
                    {
                        string hash = CoopJson.Hash(CoopJson.Bytes(issue));
                        if (knownWeeks.GetValueOrDefault(issue.Week) == hash) continue;
                        int index = next.World.WeeklyEditions.FindIndex(w => w.Week == issue.Week);
                        if (index < 0) continue;
                        next.World.WeeklyEditions[index] = CoopJson.Copy(issue); knownWeeks[issue.Week] = hash; changed = true;
                        foreach (var profile in issue.Profiles)
                        {
                            var generated = CareerEngine.Person(data, profile.Id);
                            var current = CareerEngine.Person(next.World, profile.Id);
                            if (generated != null && current != null && generated.IntroductionDay >= current.IntroductionDay)
                            { current.AiIntroduction = generated.AiIntroduction; current.IntroductionDay = generated.IntroductionDay; }
                        }
                        if (data.PlayerIntroductionDay >= next.World.PlayerIntroductionDay)
                        { next.World.PlayerIntroduction = data.PlayerIntroduction; next.World.PlayerIntroductionDay = data.PlayerIntroductionDay; }
                        foreach (var memory in data.CommunityMemories.Where(m => m.Id.StartsWith($"weekly:{issue.Week}:", StringComparison.Ordinal)))
                        { next.World.CommunityMemories.RemoveAll(m => m.Id == memory.Id); next.World.CommunityMemories.Add(CoopJson.Copy(memory)); }
                        foreach (var activity in data.Life.Events.Where(e => e.EditionWeek == issue.Week))
                        {
                            foreach (var target in next.World.Life.Events.Concat(next.Members.SelectMany(m => m.Life.Events)).Where(e => e.Id == activity.Id)) target.EditionWeek = issue.Week;
                        }
                    }
                    if (changed) { next.Revision++; session.Commit(next, session.NativeSave); }
                    }
                };
                if (retry)
                {
                    await AiService.ProcessNewsAsync("*", data);
                    if (data.WeeklyEditions.LastOrDefault() is { } latest)
                    {
                        await AiService.RetryWeeklyAsync(latest.Week, true, data);
                        await AiService.RetryWeeklyAsync(latest.Week, false, data);
                    }
                    retry = false;
                }
                await AiService.ProcessPendingAsync(data);
            }
        }
        catch (Exception e) { Diagnostics.Error("coop.ai", e); }
        finally { _running = false; }
    }
    private static void Replace(List<CommunityPost> posts, CommunityPost updated)
    { int index = posts.FindIndex(p => p.Id == updated.Id); if (index >= 0) posts[index] = updated; }
}
