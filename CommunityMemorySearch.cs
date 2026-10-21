namespace NationalSpire;

public static class CommunityMemorySearch
{
    /// <summary>一次同步上下文整理内复用纯文字计算；不缓存人物选择或生涯状态。</summary>
    public sealed class Request
    {
        private readonly Dictionary<string, HashSet<string>> _terms = new(StringComparer.Ordinal);
        private readonly Dictionary<(CareerData Data, int Day, string Query), Search> _searches = [];
        private readonly Dictionary<(CareerData Data, int Day), Dictionary<string, PostActivity>> _posts = [];
        private readonly Dictionary<(CareerData Data, int Day), List<CommunityPost>> _recentPlayerPosts = [];
        private readonly Dictionary<(CommunityPost Post, string Query), bool> _topics = [];
        private readonly Dictionary<(CareerData Data, int Day, string Person), List<CommunityMemory>> _acquaintances = [];
        private readonly Dictionary<(CareerData Data, int Day), (Dictionary<string, CommunityPost> Posts, ILookup<string, CommunityMemory> People)> _acquaintancePools = [];
        internal (Dictionary<string, CommunityPost> Posts, ILookup<string, CommunityMemory> People) AcquaintancePool(CareerData data)
        {
            var key = (data, data.Day);
            if (_acquaintancePools.TryGetValue(key, out var pool)) return pool;
            var posts = CommunityThreads.All(data).DistinctBy(p => p.Id).ToDictionary(p => p.Id);
            var available = data.CommunityMemories.AsEnumerable().Reverse().Where(m => m.Day <= data.Day &&
                (!posts.TryGetValue(m.PostId, out var post) || !CommunityThreads.NewsPending(data, post)));
            pool = (posts, available.SelectMany(m => m.People.Distinct().Select(id => (id, m))).ToLookup(x => x.id, x => x.m));
            _acquaintancePools.Add(key, pool); return pool;
        }
        internal Dictionary<string, PostActivity> Posts(CareerData data)
        {
            var key = (data, data.Day);
            if (_posts.TryGetValue(key, out var posts)) return posts;
            string human = data.LocalHumanId.Length > 0 ? data.LocalHumanId : "player";
            posts = CommunityThreads.All(data).Where(p => p.Day <= data.Day && !CommunityThreads.NewsPending(data, p)).ToDictionary(p => p.Id, p =>
            {
                var activity = p.Replies.Where(r => r.Day <= data.Day).GroupBy(r => r.AuthorId).ToDictionary(g => g.Key, g => g.Max(r => r.Day));
                return new PostActivity(p, activity, p.AuthorId == human || p.RelatedPeople.Contains(human) || activity.ContainsKey(human));
            });
            _posts.Add(key, posts); return posts;
        }
        internal bool Topic(CommunityPost post, string query)
        {
            if (!_topics.TryGetValue((post, query), out bool result))
                _topics.Add((post, query), result = MatchesTopic(query, post.Title + "\n" + post.Body, this));
            return result;
        }
        public IReadOnlyList<CommunityPost> RecentPlayerPosts(CareerData data, int day)
        {
            if (!_recentPlayerPosts.TryGetValue((data, day), out var posts))
            {
                posts = Posts(data).Values.Select(a => a.Post)
                    .Where(p => p.Day >= day - 27 && p.Day <= day && (CommunityThreads.IsHuman(data, p.AuthorId)
                        || p.PersonalPost && p.RelatedPeople.Any(id => CommunityThreads.IsHuman(data, id))))
                    .OrderByDescending(p => p.Day).Take(3).ToList();
                _recentPlayerPosts.Add((data, day), posts);
            }
            return posts;
        }
        internal List<CommunityMemory> Acquaintance(CareerData data, CareerPerson person)
        {
            var key = (data, data.Day, person.Id);
            if (!_acquaintances.TryGetValue(key, out var records)) _acquaintances.Add(key, records = PrivateAcquaintance(data, person, this));
            return new(records);
        }
        internal Search Prepare(CareerData data, int day, string query)
        {
            var key = (data, day, query);
            if (!_searches.TryGetValue(key, out var search)) _searches.Add(key, search = BuildSearch(data, day, GetTerms(query)));
            return search;
        }
        internal HashSet<string> GetTerms(string text)
        {
            if (!_terms.TryGetValue(text, out var terms)) _terms.Add(text, terms = Terms(text));
            return terms;
        }
    }
    internal sealed record PostActivity(CommunityPost Post, Dictionary<string, int> LastByAuthor, bool PlayerRelated);
    private static readonly System.Runtime.CompilerServices.ConditionalWeakTable<CareerData, System.Collections.Concurrent.ConcurrentDictionary<string, (string Text, HashSet<string> Terms)>> Indexes = new();
    private static HashSet<string> Terms(string text)
    {
        var terms = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        static bool Latin(char c) => c is >= 'a' and <= 'z' or >= 'A' and <= 'Z' or >= '0' and <= '9' or '_';
        static bool Chinese(char c) => c is >= '\u4e00' and <= '\u9fff';
        for (int i = 0; i < text.Length;)
        {
            int start = i;
            if (Latin(text[i]))
            {
                while (i < text.Length && Latin(text[i])) i++;
                terms.Add(text[start..i]);
            }
            else if (Chinese(text[i]))
            {
                while (i < text.Length && Chinese(text[i])) i++;
                for (int j = start; j + 1 < i; j++) terms.Add(text.Substring(j, 2));
            }
            else i++;
        }
        return terms;
    }
    private static readonly HashSet<string> ConversationNoise = ["今天", "明天", "昨天", "什么", "为什", "么是", "怎么", "知道", "这个", "那个", "现在", "时候", "事情", "没有", "不是", "可以", "还是", "到底", "一下", "你好", "在吗", "在不", "不在", "你说", "说的", "我们", "你们", "自己", "能不", "不能", "觉得"];
    public static bool MatchesTopic(string query, string text, Request? request = null)
    {
        var queryTerms = request?.GetTerms(query) ?? Terms(query);
        if (queryTerms.Count(t => !ConversationNoise.Contains(t)) < 2) return false;
        var textTerms = request?.GetTerms(text) ?? Terms(text);
        return MatchesTopic(queryTerms, textTerms);
    }
    private static bool MatchesTopic(HashSet<string> queryTerms, HashSet<string> textTerms)
    {
        int matches = 0;
        foreach (string term in queryTerms)
            if (!ConversationNoise.Contains(term) && textTerms.Contains(term) && ++matches == 2) return true;
        return false;
    }
    private sealed class ReplyTerms
    {
        private string _text = "";
        private HashSet<string> _terms = [];
        internal HashSet<string> Get(string text)
        {
            lock (this)
            {
                if (_text != text) { _text = text; _terms = Terms(text); }
                return _terms;
            }
        }
    }
    private static readonly System.Runtime.CompilerServices.ConditionalWeakTable<CommunityReply, ReplyTerms> ReplyIndexes = new();
    public static double TopicScore(string query, CommunityReply reply, Request request)
    {
        return TopicScore(request.GetTerms(query), reply);
    }
    internal static double TopicScore(HashSet<string> queryTerms, CommunityReply reply)
    {
        var terms = ReplyIndexes.GetOrCreateValue(reply).Get(reply.Body);
        int matches = 0;
        var smaller = queryTerms.Count < terms.Count ? queryTerms : terms;
        var larger = queryTerms.Count < terms.Count ? terms : queryTerms;
        foreach (string term in smaller) if (!ConversationNoise.Contains(term) && larger.Contains(term)) matches++;
        return matches >= 2 ? matches / Math.Sqrt(Math.Max(1, terms.Count)) : 0;
    }
    public static List<CommunityMemory> PrivateAcquaintance(CareerData data, CareerPerson person, Request? request = null)
    {
        using var measurement = UiPerformance.Measure(UiPerformance.Work.CommunityAcquaintance);
        string human = data.LocalHumanId.Length > 0 ? data.LocalHumanId : "player";
        var pool = (request ?? new()).AcquaintancePool(data);
        var posts = pool.Posts;
        var available = pool.People[person.Id];
        var names = person.HandleAliases.Append(person.PublicName).Where(n => n.Length > 0).Distinct().ToArray();
        bool Own(CommunityMemory m) => m.Kind == "opinion" && m.People.Contains(person.Id) && names.Any(name =>
            m.Text.StartsWith(name + "：", StringComparison.Ordinal) || m.Text.StartsWith(name + "发帖", StringComparison.Ordinal));
        var own = available.Where(Own).OrderByDescending(m => m.Day).Take(3);
        var shared = available.Where(m => m.Kind == "fact" && m.People.Contains(person.Id) && m.People.Contains(human))
            .OrderByDescending(m => m.Day).Take(2);
        return own.Concat(shared).DistinctBy(m => m.Id).Select(m => new CommunityMemory
        {
            Id = m.Id, PostId = m.PostId, Day = m.Day, Kind = m.Kind, People = m.People,
            Text = posts.TryGetValue(m.PostId, out var post) ? $"《{post.Title}》中的记录：{AiGeneratedText.Memory(m)}" : AiGeneratedText.Memory(m)
        }).ToList();
    }
    public static List<CommunityMemory> Retrieve(CareerData data, string query, IEnumerable<string> people, int day, ISet<string> excludedPosts, int count = 6, ISet<string>? excludedMemories = null, bool requireTopic = false, Request? request = null, IEnumerable<CommunityPost>? playerTopics = null)
    {
        using var measurement = UiPerformance.Measure(UiPerformance.Work.CommunityRetrieve);
        var identities = people.Where(id => id != "player" && id != "desk").Distinct()
            .Select((id, index) => (id, weight: index < 3 ? 8 : 3)).ToDictionary(x => x.id, x => x.weight);
        var queryTerms = request?.GetTerms(query) ?? Terms(query);
        if (requireTopic && queryTerms.Count(t => !ConversationNoise.Contains(t)) < 2) return [];
        request ??= new();
        var search = request.Prepare(data, day, query);
        var excluded = (excludedMemories ?? new HashSet<string>()).Where(search.ById.ContainsKey).Select(id => search.ById[id]).Concat(excludedPosts.SelectMany(id => search.ByPost[id])).DistinctBy(d => d.Memory.Id).ToArray();
        var excludedIds = excluded.Select(d => d.Memory.Id).ToHashSet();
        var frequencies = new Dictionary<string, int>(search.Frequencies, StringComparer.OrdinalIgnoreCase);
        foreach (var doc in excluded) foreach (string term in doc.Matches) frequencies[term]--;
        int countAvailable = search.Documents.Count - excluded.Length;
        var weights = frequencies.Where(p => p.Value > 0).ToDictionary(p => p.Key, p => Math.Log(1 + (countAvailable + 1.0) / p.Value), StringComparer.OrdinalIgnoreCase);
        double Score(Document doc) => doc.Matches.Sum(t => weights[t]) / Math.Sqrt(Math.Max(1, doc.TermCount))
            + doc.Memory.People.Sum(id => identities.GetValueOrDefault(id))
            + (doc.Memory.Kind == "fact" ? 1 : 0) + 1.0 / (1 + Math.Max(0, day - doc.Memory.Day) / 28.0);
        // 人物与话题匹配优先，日期只作轻微加权；久远的交手不会因过期而失去检索机会。
        var perPost = new Dictionary<string, int>();
        var selected = (requireTopic ? search.Topics : search.Documents).Where(d => !excludedIds.Contains(d.Memory.Id) && (requireTopic ? d.Topic : d.Matches.Length > 0 || d.Memory.People.Any(identities.ContainsKey)))
            .OrderByDescending(Score).ThenByDescending(d => d.Memory.Day)
            .Where(d => { int used = perPost.GetValueOrDefault(d.Memory.PostId); perPost[d.Memory.PostId] = used + 1; return used < 2; })
            .Take(count).ToList();
        if (playerTopics?.Any(p => CommunityThreads.IsHuman(data, p.AuthorId)
            || p.RelatedPeople.Any(id => CommunityThreads.IsHuman(data, id))
            || data.Results.Any(r => r.Day <= day && r.OfficialAscensionVerified && p.EventKey == "match" + r.MatchId)) == true)
        {
            // 先确定三篇近期公开帖，再合并同帖；重复项占用名额，正文沿用同一记录与输出入口。
            var recent = request.RecentPlayerPosts(data, day);
            var supplied = selected.Select(d => d.Memory.PostId).Concat(excludedPosts).Concat(excluded.Select(d => d.Memory.PostId)).ToHashSet();
            foreach (var post in recent)
                if (supplied.Add(post.Id) && search.ById.TryGetValue(post.Id + ":fact", out var document)) selected.Add(document);
        }
        return selected.Select(d => d.Memory.Kind == "fact" ? new CommunityMemory { Id = d.Memory.Id, PostId = d.Memory.PostId, Day = d.Memory.Day, Kind = d.Memory.Kind, People = d.Memory.People, Text = GameText.Plain(AiGeneratedText.Memory(d.Memory)) } : d.Memory).ToList();
    }
    internal sealed record Document(CommunityMemory Memory, int TermCount, string[] Matches, bool Topic);
    internal sealed class Search(List<Document> documents, Dictionary<string, int> frequencies)
    {
        internal List<Document> Documents { get; } = documents;
        internal Dictionary<string, int> Frequencies { get; } = frequencies;
        internal Dictionary<string, Document> ById { get; } = documents.ToDictionary(d => d.Memory.Id);
        internal ILookup<string, Document> ByPost { get; } = documents.ToLookup(d => d.Memory.PostId);
        internal List<Document> Topics { get; } = documents.Where(d => d.Topic).ToList();
    }
    private static Search BuildSearch(CareerData data, int day, HashSet<string> queryTerms)
    {
        var index = Indexes.GetOrCreateValue(data);
        var unpublished = CommunityThreads.All(data).Where(p => CommunityThreads.NewsPending(data, p)).Select(p => p.Id).ToHashSet();
        var documents = new List<Document>();
        var frequencies = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        foreach (var memory in data.CommunityMemories.Where(m => m.Day <= day && (m.Kind != "opinion" || !unpublished.Contains(m.PostId))))
        {
            if (!index.TryGetValue(memory.Id, out var cached) || cached.Text != memory.Text)
                index[memory.Id] = cached = (memory.Text, Terms(memory.Text));
            var matches = (queryTerms.Count < cached.Terms.Count ? queryTerms.Where(cached.Terms.Contains) : cached.Terms.Where(queryTerms.Contains)).ToArray();
            foreach (string term in matches) frequencies[term] = frequencies.GetValueOrDefault(term) + 1;
            documents.Add(new(memory, cached.Terms.Count, matches, matches.Count(t => !ConversationNoise.Contains(t)) >= 2));
        }
        return new(documents, frequencies);
    }

}
