using System.Text.RegularExpressions;

namespace NationalSpire;

public static class CommunityMemorySearch
{
    /// <summary>一次同步上下文整理内复用纯文字计算；不缓存人物选择或生涯状态。</summary>
    public sealed class Request
    {
        private readonly Dictionary<string, HashSet<string>> _terms = new(StringComparer.Ordinal);
        internal HashSet<string> GetTerms(string text)
        {
            if (!_terms.TryGetValue(text, out var terms)) _terms.Add(text, terms = Terms(text));
            return terms;
        }
    }
    private static readonly System.Runtime.CompilerServices.ConditionalWeakTable<CareerData, Dictionary<string, (string Text, HashSet<string> Terms)>> Indexes = new();
    private static HashSet<string> Terms(string text)
    {
        var terms = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        foreach (Match match in Regex.Matches(text, @"[a-zA-Z0-9_]+|[\p{IsCJKUnifiedIdeographs}]+"))
        {
            string word = match.Value;
            if (word[0] <= 127) terms.Add(word);
            else for (int i = 0; i < word.Length - 1; i++) terms.Add(word.Substring(i, 2));
        }
        return terms;
    }
    private static readonly HashSet<string> ConversationNoise = ["今天", "明天", "昨天", "什么", "为什", "么是", "怎么", "知道", "这个", "那个", "现在", "时候", "事情", "没有", "不是", "可以", "还是", "到底", "一下", "你好", "在吗", "在不", "不在", "你说", "说的", "我们", "你们", "自己", "能不", "不能", "觉得"];
    public static bool MatchesTopic(string query, string text, Request? request = null)
    {
        var queryTerms = request?.GetTerms(query) ?? Terms(query);
        var textTerms = request?.GetTerms(text) ?? Terms(text);
        int matches = 0;
        foreach (string term in queryTerms)
            if (!ConversationNoise.Contains(term) && textTerms.Contains(term) && ++matches == 2) return true;
        return false;
    }
    public static List<CommunityMemory> PrivateAcquaintance(CareerData data, CareerPerson person)
    {
        string human = data.LocalHumanId.Length > 0 ? data.LocalHumanId : "player";
        var posts = CommunityThreads.All(data).DistinctBy(p => p.Id).ToDictionary(p => p.Id);
        var available = data.CommunityMemories.AsEnumerable().Reverse().Where(m => m.Day <= data.Day &&
            (!posts.TryGetValue(m.PostId, out var post) || !CommunityThreads.NewsPending(data, post))).ToArray();
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
    public static List<CommunityMemory> Retrieve(CareerData data, string query, IEnumerable<string> people, int day, ISet<string> excludedPosts, int count = 6, ISet<string>? excludedMemories = null, bool requireTopic = false, Request? request = null)
    {
        var identities = people.Where(id => id != "player" && id != "desk").Distinct()
            .Select((id, index) => (id, weight: index < 3 ? 8 : 3)).ToDictionary(x => x.id, x => x.weight);
        var queryTerms = request?.GetTerms(query) ?? Terms(query);
        var index = Indexes.GetOrCreateValue(data);
        HashSet<string> IndexedTerms(CommunityMemory memory)
        {
            if (index.TryGetValue(memory.Id, out var cached) && cached.Text == memory.Text) return cached.Terms;
            var terms = Terms(memory.Text); index[memory.Id] = (memory.Text, terms); return terms;
        }
        var unpublished = CommunityThreads.All(data).Where(p => CommunityThreads.NewsPending(data, p)).Select(p => p.Id).ToHashSet();
        var documents = data.CommunityMemories.Where(m => (m.Kind != "opinion" || !unpublished.Contains(m.PostId)) && m.Day <= day && !excludedPosts.Contains(m.PostId) && !(excludedMemories?.Contains(m.Id) ?? false))
            .Select(m => (Memory: m, Terms: IndexedTerms(m))).ToList();
        var frequencies = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        foreach (var doc in documents) foreach (var term in queryTerms)
            if (doc.Terms.Contains(term)) frequencies[term] = frequencies.GetValueOrDefault(term) + 1;
        double Score((CommunityMemory Memory, HashSet<string> Terms) doc)
        {
            double lexical = doc.Terms.Where(queryTerms.Contains).Sum(t => Math.Log(1 + (documents.Count + 1.0) / frequencies[t]));
            return lexical / Math.Sqrt(Math.Max(1, doc.Terms.Count)) + doc.Memory.People.Sum(id => identities.GetValueOrDefault(id))
                + (doc.Memory.Kind == "fact" ? 1 : 0) + 1.0 / (1 + Math.Max(0, day - doc.Memory.Day) / 28.0);
        }
        // 人物与话题匹配优先，日期只作轻微加权；久远的交手不会因过期而失去检索机会。
        var perPost = new Dictionary<string, int>();
        return documents.Where(d => requireTopic ? MatchesTopic(query, d.Memory.Text, request) : d.Terms.Overlaps(queryTerms) || d.Memory.People.Any(identities.ContainsKey))
            .OrderByDescending(Score).ThenByDescending(d => d.Memory.Day)
            .Where(d => { int used = perPost.GetValueOrDefault(d.Memory.PostId); perPost[d.Memory.PostId] = used + 1; return used < 2; })
            .Take(count).Select(d => d.Memory.Kind == "fact" ? new CommunityMemory { Id = d.Memory.Id, PostId = d.Memory.PostId, Day = d.Memory.Day, Kind = d.Memory.Kind, People = d.Memory.People, Text = GameText.Plain(AiGeneratedText.Memory(d.Memory)) } : d.Memory).ToList();
    }
}
