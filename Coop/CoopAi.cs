namespace NationalSpire.Coop;

/// <summary>任务保留自己的资料快照，只合并生成内容，不能覆盖正在变化的经济和赛程。</summary>
public sealed class CoopAi(CoopCoordinator session)
{
    private bool _running, _pending;
    private string _generation = Guid.NewGuid().ToString("N");
    public void Stop() => _generation = Guid.NewGuid().ToString("N");
    public async Task Process(bool retry = false)
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
                await AiService.ProcessInteractionsAsync(CommunityThreads.PendingIds(data).ToArray(), data);
            }
        }
        catch (Exception e) { Diagnostics.Error("coop.ai", e); }
        finally { _running = false; }
    }
    private static void Replace(List<CommunityPost> posts, CommunityPost updated)
    { int index = posts.FindIndex(p => p.Id == updated.Id); if (index >= 0) posts[index] = updated; }
}
