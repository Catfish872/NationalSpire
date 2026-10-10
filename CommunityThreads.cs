namespace NationalSpire;

public static class CommunityThreads
{
    public static bool IsHuman(CareerData data, string id) => id == "player" || data.HumanIds.Contains(id);
    public static void SetInteractionState(CareerData data, ISet<string> ids, string state, string error = "")
    {
        foreach (var post in All(data))
        {
            if (ids.Contains(post.Id) && (CommunityThreads.IsHuman(data, post.AuthorId) || post.PersonalPost)) SetWork(post.ReactionGeneration, state, error);
            foreach (var reply in post.Replies.Where(r => ids.Contains(r.Id) && CommunityThreads.IsHuman(data, r.AuthorId))) SetWork(reply.ReactionGeneration, state, error);
        }
    }
    public static void SetWork(AiWorkState work, string state, string error = "") { work.State = state; work.Error = error; work.WaitReason = ""; }
    public static bool RecoverInterrupted(CareerData data)
    {
        bool changed = false;
        void Recover(AiWorkState work, bool pending)
        {
            if (work.State == "failed" && work.Error == "今日请求额度已用完")
            { work.Error = "旧版调用限制已移除，可重试"; changed = true; }
            if (!pending || work.State is "failed" or "completed") return;
            SetWork(work, "failed", "上次回应未完成，可重试"); changed = true;
        }
        foreach (var post in All(data))
        {
            if (post.NewsGeneration.State == "failed" && post.NewsGeneration.Error == "今日请求额度已用完")
            { post.NewsGeneration.Error = "旧版调用限制已移除，可重试"; changed = true; }
            Recover(post.ReactionGeneration, (CommunityThreads.IsHuman(data, post.AuthorId) || post.PersonalPost) && post.NeedsReaction);
            foreach (var r in post.Replies) Recover(r.ReactionGeneration, CommunityThreads.IsHuman(data, r.AuthorId) && r.NeedsReaction);
            if (post.NewsGeneration.State is "queued" or "sending")
            { SetWork(post.NewsGeneration, "failed", "上次生成中断，可重试"); changed = true; }
            else if (post.EditorialVersion == 0 && !post.AiPending && post.SourceBody.Length > 0 && post.NewsGeneration.State == "idle")
            { SetWork(post.NewsGeneration, "completed"); changed = true; }
        }
        return changed;
    }
    public static IEnumerable<CommunityPost> All(CareerData data) => data.Posts.Concat(data.SavedThreads).DistinctBy(p => p.Id);
    /// <summary>社区回帖与私信共享讨论上下文：短帖完整，长帖保留开头、近期讨论及引用分支。</summary>
    public static List<CommunityReply> ContextReplies(CommunityPost post, int day, bool complete = false, IEnumerable<string>? anchors = null)
    {
        var replies = post.Replies.Where(r => r.Day <= day).DistinctBy(r => r.Id).ToList();
        if (complete || replies.Count <= 40) return replies;
        var index = replies.ToDictionary(r => r.Id);
        var focus = (anchors ?? []).Where(index.ContainsKey).ToHashSet();
        var chosen = replies.Take(2).Concat(replies.TakeLast(16)).Select(r => r.Id).Concat(focus)
            .Concat(replies.Where(r => focus.Contains(r.ParentId)).Select(r => r.Id)).ToHashSet();
        foreach (string id in chosen.ToArray())
        {
            string parent = index[id].ParentId;
            while (index.TryGetValue(parent, out var reply) && chosen.Add(parent)) parent = reply.ParentId;
        }
        return replies.Where(r => chosen.Contains(r.Id)).ToList();
    }
    public static bool NewsPending(CareerData data, CommunityPost post) => data.Ai.Enabled && !CommunityThreads.IsHuman(data, post.AuthorId)
        && post.NewsGeneration.State is not ("failed" or "completed") && (post.AiPending || post.NewsGeneration.State is "queued" or "sending");
    public static int Unread(CareerData data) => All(data).Count(p => p.Revision > p.SeenRevision);
    public static IEnumerable<CommunityReply> Pending(CareerData data) => All(data).SelectMany(p => p.Replies).Where(r => CommunityThreads.IsHuman(data, r.AuthorId) && r.NeedsReaction);
    public static IEnumerable<string> PendingIds(CareerData data) => Pending(data).Select(r => r.Id)
        .Concat(All(data).Where(p => (CommunityThreads.IsHuman(data, p.AuthorId) || p.PersonalPost) && p.NeedsReaction).Select(p => p.Id));
    public static CommunityPost Publish(CareerData data, string title, string body)
    {
        if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(body)) throw new InvalidOperationException("请填写标题和正文。");
        var post = new CommunityPost { Title = title.Trim(), Body = body.Trim(), AuthorId = "player", Day = data.Day,
            Category = "玩家讨论", MatchKind = "local", RelatedPeople = ["player"], NeedsReaction = true, SeenRevision = 1 };
        post.MentionedPeople = CommunityMentions.Resolve(data, post.Title + "\n" + post.Body);
        data.Posts.Insert(0, post); Remember(data, post); TrimFeed(data); CareerStore.Save(data); return post;
    }
    public static bool Normalize(CareerData data)
    {
        if (data.CommunityVersion >= 3) return false;
        foreach (var post in All(data))
        {
            if (data.CommunityVersion < 2)
            {
                post.Revision = Math.Max(1, post.Revision);
                var known = new HashSet<string>();
                foreach (var r in post.Replies)
                {
                    if (string.IsNullOrEmpty(r.Id) || known.Contains(r.Id)) r.Id = Guid.NewGuid().ToString("N");
                    if (!known.Contains(r.ParentId)) r.ParentId = "";
                    known.Add(r.Id); if (r.Day == 0) r.Day = post.Day;
                }
                post.MatchKind = data.Matches.FirstOrDefault(m => post.EventKey == "match" + m.Id)?.Kind ?? post.MatchKind;
            }
            if (CommunityMentions.Remember(data, post) || data.CommunityVersion < 2) Remember(data, post);
        }
        data.CommunityVersion = 3; return true;
    }
    public static void MarkRead(CareerData data, CommunityPost post)
    {
        if (post.SeenRevision == post.Revision) return;
        post.SeenRevision = post.Revision; CareerStore.Save(data);
    }
    public static int MarkProgramRead(CareerData data)
    {
        int count = 0;
        foreach (var post in All(data).Where(p => !CommunityThreads.IsHuman(data, p.AuthorId) && p.NewsGeneration.State != "completed"
            && !p.Replies.Any(r => CommunityThreads.IsHuman(data, r.AuthorId) || r.AiGenerated) && p.Revision > p.SeenRevision))
        { post.SeenRevision = post.Revision; count++; }
        if (count > 0) CareerStore.Save(data);
        return count;
    }
    public static CommunityReply Submit(CareerData data, CommunityPost post, string parentId, string body)
    {
        if (!All(data).Contains(post)) throw new InvalidOperationException("帖子已不存在。");
        if (string.IsNullOrWhiteSpace(body)) throw new InvalidOperationException("请先填写回复内容。");
        if (parentId.Length > 0 && !post.Replies.Any(r => r.Id == parentId)) throw new InvalidOperationException("回复目标已不存在。");
        var reply = new CommunityReply { AuthorId = "player", ParentId = parentId, Body = body.Trim(), Day = data.Day, NeedsReaction = true };
        reply.MentionedPeople = CommunityMentions.Resolve(data, reply.Body);
        post.Replies.Add(reply); post.AiPending = false;
        post.Revision++; post.SeenRevision = post.Revision;
        Remember(data, post); CareerStore.Save(data); return reply;
    }
    public static void MakeOfflineThreads(CommunityPost post)
    {
        for (int i = 0; i < post.Replies.Count; i++)
        {
            var reply = post.Replies[i]; reply.Day = post.Day;
            if (i > 0 && (i == 1 || CareerEngine.StableHash(post.Id + i) % 3 == 0))
            {
                reply.ParentId = post.Replies[i - 1].Id;
                reply.Body = new[] { "接着这层说一句，", "看完上面的讨论，", "我也在关注这个，", "这事我想再补一句：" }[i % 4] + reply.Body;
            }
        }
    }
    public static (int Floor, int Depth) Position(CommunityPost post, CommunityReply reply)
    {
        int depth = 0; var root = reply; var seen = new HashSet<string> { reply.Id };
        while (root.ParentId.Length > 0 && post.Replies.FirstOrDefault(r => r.Id == root.ParentId) is { } parent && seen.Add(parent.Id))
        { root = parent; depth++; }
        int floor = post.Replies.Where(r => r.ParentId.Length == 0).TakeWhile(r => r.Id != root.Id).Count() + 1;
        return (floor, depth);
    }
    public static List<CommunityReply> ReadingOrder(CommunityPost post)
    {
        var children = post.Replies.ToLookup(r => r.ParentId);
        var result = new List<CommunityReply>(); var seen = new HashSet<string>();
        var stack = new Stack<CommunityReply>(children[""].Reverse());
        while (stack.TryPop(out var reply))
        {
            if (!seen.Add(reply.Id)) continue;
            result.Add(reply);
            foreach (var child in children[reply.Id].Reverse()) stack.Push(child);
        }
        result.AddRange(post.Replies.Where(r => seen.Add(r.Id))); return result;
    }
    public static List<CareerPerson> Audience(CareerData data, CommunityPost post)
    {
        var match = data.Matches.FirstOrDefault(m => post.EventKey == "match" + m.Id)
            ?? (post.MatchKind.Length == 0 ? null : new CareerMatch { Kind = post.MatchKind });
        // 玩家帖子仍按发帖者赛区选择普通观众，历史提及人物由推荐与资料列表另外加入。
        var related = IsHuman(data, post.AuthorId) ? new List<string> { post.AuthorId } : post.RelatedPeople;
        return CareerNarrative.Audience(data, post.EventKey, post.Category, match, related).Where(p => !IsHuman(data, p.Id) && !SpireArbitration.Muted(p)).ToList();
    }
    public static void OfflineReactions(CareerData data, IReadOnlySet<string> requested)
    {
        foreach (var post in All(data).ToList())
        {
            var requests = post.Replies.Where(r => r.NeedsReaction && requested.Contains(r.Id)).ToList();
            bool root = (CommunityThreads.IsHuman(data, post.AuthorId) || post.PersonalPost) && post.NeedsReaction && requested.Contains(post.Id);
            if (requests.Count == 0 && !root) continue;
            var answered = new HashSet<(string Author, string Request)>();
            if (root)
            {
                var person = Audience(data, post).OrderBy(p => CareerEngine.StableHash(post.Id + p.Id)).FirstOrDefault();
                if (person != null)
                {
                    post.Replies.Add(new CommunityReply { AuthorId = person.Id, Day = data.Day,
                        Body = new[] { "看到本人发帖了，先来留个位置。我也在这个赛区玩，平时主要看社区杯。", "楼主也逛这里啊。我刚结束自己的对局，过来看看大家在聊什么。", "来了，这边熟悉的名字越来越多了。" }[CareerEngine.StableHash(post.Id) % 3] });
                    post.NeedsReaction = false;
                    answered.Add((person.Id, post.Id));
                }
            }
            foreach (var group in requests.GroupBy(r => Position(post, r).Floor))
            {
                var last = group.Last();
                var target = post.Replies.FirstOrDefault(r => r.Id == last.ParentId);
                var audience = Audience(data, post);
                var person = audience.FirstOrDefault(p => p.Id == target?.AuthorId)
                    ?? audience.OrderBy(p => CareerEngine.StableHash(last.Id + p.Id)).FirstOrDefault();
                if (person == null) continue;
                string name = CareerEngine.Name(data);
                string body = person.Temperament switch
                {
                    "谨慎求证" => $"{name}这条我看了。我自己的成绩还不稳定，暂时不敢把打法讲得太满。",
                    "热情直率" => $"{name}本人也来聊了！我平时就在这个区看比赛，没想到能在评论区碰见。",
                    _ => new[] { "这层有意思，平时光顾着看战报，很少看到当事人来聊。", "看到了。我自己还经常在前面几层翻车，先听大家聊。", "刚翻到这里，前面的讨论也补看了。" }[CareerEngine.StableHash(last.Id) % 3]
                };
                post.Replies.Add(new CommunityReply { AuthorId = person.Id, ParentId = last.Id, Day = data.Day, Body = body });
                foreach (var r in group) { r.NeedsReaction = false; answered.Add((person.Id, r.Id)); }
            }
            var mentionRequests = requests.Select(r => (r.Id, r.MentionedPeople)).Concat(root ? [(post.Id, post.MentionedPeople)] : []);
            foreach (var (id, authors) in mentionRequests)
                foreach (string author in authors.Where(a => data.People.Any(p => p.Id == a && !SpireArbitration.Muted(p)) && !IsHuman(data, a)))
                    if (!answered.Contains((author, id)))
                        post.Replies.Add(new() { AuthorId = author, ParentId = id == post.Id ? "" : id, Day = data.Day, Body = "看到你叫我了，我过来看看。" });
            post.Revision++; Remember(data, post);
        }
    }
    public static void Remember(CareerData data, CommunityPost post)
    {
        CommunityMentions.Remember(data, post);
        void Put(CommunityMemory memory)
        {
            int i = data.CommunityMemories.FindIndex(m => m.Id == memory.Id);
            if (i >= 0) data.CommunityMemories[i] = memory; else data.CommunityMemories.Add(memory);
        }
        Put(new CommunityMemory { Id = post.Id + ":fact", PostId = post.Id, Day = post.Day, Kind = CommunityThreads.IsHuman(data, post.AuthorId) || post.PersonalPost ? "opinion" : "fact", People = post.RelatedPeople.Append(post.AuthorId).Distinct().ToList(),
            Text = (CommunityThreads.IsHuman(data, post.AuthorId) || post.PersonalPost ? CareerEngine.DisplayName(data, post.AuthorId) + "发帖：" : "") + (post.SourceTitle.Length > 0 ? post.SourceTitle : post.Title) + "：" + (post.SourceBody.Length > 0 ? post.SourceBody : post.Body) });
        if (NewsPending(data, post))
        { data.CommunityMemories.RemoveAll(m => m.PostId == post.Id && m.Kind == "opinion"); return; }
        if (post.SourceBody.Length > 0 && post.NewsGeneration.State == "completed")
            Put(new CommunityMemory { Id = post.Id + ":editorial", PostId = post.Id, Day = post.Day, Kind = "opinion", People = post.RelatedPeople.Append(post.AuthorId).Distinct().ToList(),
                Text = CareerEngine.DisplayName(data, post.AuthorId) + "发帖《" + post.Title + "》：" + post.Body });
        foreach (var r in post.Replies.TakeLast(12))
            Put(new CommunityMemory { Id = post.Id + ":" + r.Id, PostId = post.Id, Day = r.Day, Kind = "opinion", People = [r.AuthorId], Text = CareerEngine.DisplayName(data, r.AuthorId) + "：" + r.Body });
    }
    public static void RememberMatch(CareerData data, CareerResult result)
    {
        var post = data.Posts.FirstOrDefault(p => p.EventKey == "match" + result.MatchId);
        if (post == null) return;
        string id = post.Id + ":result";
        if (data.CommunityMemories.Any(m => m.Id == id)) return;
        data.CommunityMemories.Add(new CommunityMemory { Id = id, PostId = post.Id, Day = result.Day,
            People = ["player", result.OpponentId], Text = $"{result.Event}，{CareerEngine.Name(data)}使用{result.Character}对阵{result.Opponent}。赛事进阶 {result.Ascension}，{result.Outcome}；{MatchRules.Performance(result.Win, result.Floor, result.RunSeconds)}；评分变化 {result.RatingDelta:+0;-0;0}。" + MatchRules.ChallengeNote(result, data.CooperativeMembers > 1) + "卡组：" + string.Join("，", result.DeckSummary) + "。" + result.Evidence.Summary() + result.WorldImpact });
    }
    public static void TrimFeed(CareerData data)
    {
        foreach (var post in data.Posts.Skip(120).ToList())
        {
            Remember(data, post);
            // 玩家参与过的完整讨论永久保留，避免队列及楼中楼引用悬空。
            if ((post.PersonalPost || CommunityThreads.IsHuman(data, post.AuthorId) || post.Replies.Any(r => CommunityThreads.IsHuman(data, r.AuthorId))) && !data.SavedThreads.Any(p => p.Id == post.Id)) data.SavedThreads.Add(post);
        }
        if (data.Posts.Count > 120) data.Posts.RemoveRange(120, data.Posts.Count - 120);
    }
}

