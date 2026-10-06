using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace NationalSpire;

public static partial class AiService
{
    internal static Func<HttpRequestMessage, Task<HttpResponseMessage>> Transport = SendTransportAsync;
    private static readonly HashSet<(CareerData Data, string Id)> ScheduledInteractions = [];
    public static async Task ProcessInteractionsAsync(IEnumerable<string> ids, CareerData? requestedData = null)
    {
        var data = requestedData ?? CareerStore.Data;
        var requested = ids.ToHashSet(); requested.IntersectWith(CommunityThreads.PendingIds(data));
        lock (ScheduledInteractions) requested.RemoveWhere(id => !ScheduledInteractions.Add((data, id)));
        if (requested.Count == 0) return;
        var scheduled = requested.ToArray(); Status = "社区回应已排队";
        string trace = Guid.NewGuid().ToString("N");
        string failure = "请求中断或配置已改变，可重试";
        void Fail(string message) { failure = message; Status = message; }
        CommunityThreads.SetInteractionState(data, requested, "queued"); CareerStore.Save(data);
        // 入队时固定涉及的帖子；发送前读取这些帖子的最新内容，保持同帖回应顺序。
        var targets = ReactionTargets(data, requested);
        var works = targets.Where(p => requested.Contains(p.Id)).Select(p => p.ReactionGeneration)
            .Concat(targets.SelectMany(p => p.Replies).Where(r => requested.Contains(r.Id)).Select(r => r.ReactionGeneration)).ToArray();
        using var lease = await EnterQueueAsync(data, targets.Select(p => "post:" + p.Id), works);
        try
        {
            if (!CareerStore.IsCurrent(data)) return;
            requested.IntersectWith(CommunityThreads.PendingIds(data));
            if (requested.Count == 0) return;
            if (!data.Ai.Enabled)
            { CommunityThreads.OfflineReactions(data, requested); CareerStore.Save(data); Status = "社区已有离线回应"; return; }
            var key = CurrentKey; string endpoint = data.Ai.Endpoint, model = data.Ai.Model;
            if (string.IsNullOrWhiteSpace(key)) { Fail("未设置密钥"); return; }
            if (!TryGetEndpoint(endpoint, out var uri))
            { Fail("接口地址无效，请填写完整的 http:// 或 https:// 地址"); return; }
            await WaitForRequestStartAsync(data, works);
            if (!CareerStore.IsCurrent(data) || !data.Ai.Enabled || key != CurrentKey || endpoint != data.Ai.Endpoint || model != data.Ai.Model) return;
            int today = int.Parse(DateTime.UtcNow.ToString("yyyyMMdd"));
            if (data.Ai.RequestDay != today) { data.Ai.RequestDay = today; data.Ai.RequestsToday = 0; }
            string context = BuildDiscussionPrompt(data, requested, targets);
            // 权限以实际发送的上下文为准，不受等待期间新增人物或楼层影响。
            var permissions = ReadDiscussionPermissions(context);
            var wire = new AiWireProtocol(data);
            string payload = JsonSerializer.Serialize(new { model, stream = false,
                messages = new[] { new { role = "system", content = ComposeSystem(data.Ai, "discussion") }, new { role = "user", content = wire.Encode(context) } } }, Json);
            CommunityThreads.SetInteractionState(data, requested, "sending");
            data.Ai.RequestsToday++; CareerStore.Save(data); Status = "正在生成社区回应";
            using var request = new HttpRequestMessage(HttpMethod.Post, uri);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", key);
            request.Content = new StringContent(payload, Encoding.UTF8, "application/json");
            using var response = await SendAsync(request, data, trace, "discussion", requested);
            if (!response.IsSuccessStatusCode) { Fail(await HttpFailure(response)); return; }
            string content = wire.Decode(await ReadResponseCompletion(response), expectedArray: "reactions");
            if (!CareerStore.IsCurrent(data) || !data.Ai.Enabled || key != CurrentKey || endpoint != data.Ai.Endpoint || model != data.Ai.Model) return;
            ApplyDiscussionCore(data, requested, targets, content, permissions);
            Diagnostics.Record("ai.applied", new { trace, kind = "discussion", targets = requested.ToArray() });
            Status = "社区回应已更新"; CareerStore.Save(data);
        }
        catch (Exception e) { Diagnostics.Error("ai.discussion:" + trace, e); Fail(FailureReason(e)); Godot.GD.PushWarning("[NationalSpire] 社区互动：" + failure); }
        finally
        {
            try
            {
                var remaining = CommunityThreads.PendingIds(data).Where(scheduled.Contains).ToHashSet();
                CommunityThreads.SetInteractionState(data, remaining, "failed", failure);
                CommunityThreads.SetInteractionState(data, scheduled.Except(remaining).ToHashSet(), "completed");
                CareerStore.Save(data);
            }
            finally
            {
                lock (ScheduledInteractions) foreach (var id in scheduled) ScheduledInteractions.Remove((data, id));
            }
        }
    }
    internal static List<CommunityPost> ReactionTargets(CareerData data, ISet<string> requested)
    {
        var sources = CommunityThreads.All(data).Where(p => requested.Contains(p.Id) || p.Replies.Any(r => requested.Contains(r.Id))).ToList();
        if (sources.Count == 0) return [];
        var related = sources.SelectMany(p => p.RelatedPeople).Where(id => id != "player" && id != "desk").ToHashSet();
        return sources.Concat(data.Posts.Where(p => !sources.Contains(p) && p.Day >= sources.Min(s => s.Day)
            && p.RelatedPeople.Any(related.Contains)).Take(2)).DistinctBy(p => p.Id).ToList();
    }
    private static List<CareerPerson> DiscussionPeople(CareerData data, CommunityPost post, ISet<string> requested)
    {
        var addressed = post.Replies.Where(r => requested.Contains(r.Id)).Select(r => post.Replies.FirstOrDefault(p => p.Id == r.ParentId)?.AuthorId).ToHashSet();
        var involved = post.Replies.Select(r => r.AuthorId).ToHashSet();
        var mentioned = CommunityMentions.Required(post, requested).Select(id => CareerEngine.Person(data, id)).OfType<CareerPerson>().Where(p => !CommunityThreads.IsHuman(data, p.Id) && !SpireArbitration.Muted(p)).ToList();
        return mentioned.Concat(CommunityThreads.Audience(data, post).Where(p => mentioned.All(m => m.Id != p.Id)).OrderByDescending(p => addressed.Contains(p.Id)).ThenByDescending(p => p.Id == post.AuthorId)
            .ThenByDescending(p => involved.Contains(p.Id)).ThenBy(p => CareerEngine.StableHash(post.Id + p.Id) % 1000 - Math.Abs(DiscussionFavour(data, p.Id, post, requested)) * 3).Take(Math.Max(0, 4 - mentioned.Count))).ToList();
    }
    private static int DiscussionFavour(CareerData data, string person, CommunityPost post, ISet<string> requested)
    {
        string? human = post.Replies.LastOrDefault(r => requested.Contains(r.Id) && CommunityThreads.IsHuman(data, r.AuthorId))?.AuthorId
            ?? (CommunityThreads.IsHuman(data, post.AuthorId) ? post.AuthorId : post.RelatedPeople.FirstOrDefault(id => CommunityThreads.IsHuman(data, id)));
        if (human == null) return 0;
        return human == "player" || human == data.LocalHumanId ? PrivateMessages.Favour(data, person)
            : data.HumanFavours.GetValueOrDefault(human)?.GetValueOrDefault(person) ?? 0;
    }
    private static object[] ReplyAttitudes(CareerData data, CommunityPost post, IEnumerable<CareerPerson> people, string occasion)
    {
        var humans = post.RelatedPeople.Concat(post.Replies.Select(r => r.AuthorId)).Append(post.AuthorId)
            .Where(id => CommunityThreads.IsHuman(data, id)).Distinct().ToArray();
        return people.SelectMany(p => humans.Select(human => (object)new
        {
            发言者 = p.Id, 面向玩家 = human,
            本次态度 = PersonalityLibrary.CommunityAttitude(data, p.Id, p.Personality, human,
                human == "player" || human == data.LocalHumanId ? PrivateMessages.Favour(data, p.Id) : data.HumanFavours.GetValueOrDefault(human)?.GetValueOrDefault(p.Id) ?? 0)
        })).ToArray();
    }
    private static object Persona(CareerData data, CareerPerson p, string occasion, int? day = null, int? profileDay = null, PersonalityProfile? profile = null, int favour = 0, IEnumerable<CommunityPost>? privatePosts = null)
    {
        bool known = (profileDay ?? data.Day) <= (day ?? data.Day);
        var person = new Dictionary<string, object?> {
            ["Id"] = p.Id, ["Name"] = p.PublicName, ["registeredName"] = p.Name,
            ["官方仲裁记录"] = SpireArbitration.Memory(data, p),
            ["身份说明"] = PrivatePublicContext.IdentityText(p), ["曾用游戏名"] = p.HandleAliases,
            ["所在地区"] = p.Region,
            ["gender"] = p.CameoId.Length > 0 ? "男" : p.Gender.Length > 0 ? p.Gender : IdentityGender.Of(data, p.Id),
            ["Role"] = p.Role, ["Country"] = p.Country, ["profileAsOfDay"] = known ? (int?)(profileDay ?? data.Day) : null,
            ["club"] = known ? EsportsWorld.ClubName(data, p.ClubId) : null, ["Character"] = p.Character, ["Style"] = p.Style,
            ["identities"] = p.Identities, ["familiarPeople"] = p.Connections.Take(2).Select(id => CareerEngine.DisplayName(data, id)),
            ["worldHonors"] = CircuitLedger.PublicStanding(data, p.Id, day ?? data.Day), ["MaxAscension"] = known ? (int?)p.MaxAscension : null,
            ["Wins"] = known ? (int?)p.Wins : null, ["Losses"] = known ? (int?)p.Losses : null,
            ["introduction"] = p.IntroductionDay <= (day ?? data.Day) ? p.AiIntroduction : "",
            ["introductionAsOfDay"] = p.IntroductionDay <= (day ?? data.Day) ? p.IntroductionDay : 0,
            ["supports"] = p.SupportedClubId.Length == 0 ? "" : EsportsWorld.ClubName(data, p.SupportedClubId)
        };
        if (profile == null) { PersonalityLibrary.Ensure(data, p); profile = p.Personality; }
        person["personality"] = PersonalityLibrary.PromptProfile(profile);
        if (privatePosts != null && PrivateMessages.PublicMemory(data, p, privatePosts, day ?? data.Day) is { Length: > 0 } memory) person["私下往来"] = memory;
        var humans = privatePosts?.SelectMany(post => post.RelatedPeople.Concat(post.Replies.Select(r => r.AuthorId)).Append(post.AuthorId))
            .Where(id => CommunityThreads.IsHuman(data, id)).Distinct().ToArray() ?? [];
        string target = humans.Length == 1 ? humans[0] : "community";
        int relationFavour = target == "player" || target == data.LocalHumanId ? PrivateMessages.Favour(data, p.Id)
            : data.HumanFavours.GetValueOrDefault(target)?.GetValueOrDefault(p.Id) ?? 0;
        person["attitude"] = PersonalityLibrary.CommunityAttitude(data, p.Id, profile, target, relationFavour);
        if (p.Biography.Length > 0) person["background"] = p.Biography;
        if (p.Voice.Length > 0) person["voice"] = p.Voice;
        if (p.Temperament.Length > 0) person["性格概述"] = p.Temperament;
        if (p.RecordedWinStreak > 0) person["streakRecord"] = CameoContent.StreakText(p);
        return person;
    }
    private static string BuildDiscussionPrompt(CareerData data, ISet<string> requested, List<CommunityPost> targets)
    {
        PersonalityLibrary.EnsureAll(data);
        string occasion = "discussion:" + string.Join("|", requested.Order(StringComparer.Ordinal));
        var schedule = PublicSchedule.Capture(data, targets.SelectMany(p => p.RelatedPeople));
        var people = targets.SelectMany(p => DiscussionPeople(data, p, requested)).DistinctBy(p => p.Id).ToList();
        var queued = targets.SelectMany(p => p.Replies.Where(r => requested.Contains(r.Id)).Select(r => new
        { r.Id, postId = p.Id, kind = "reply" }).Concat(requested.Contains(p.Id) ? [new { p.Id, postId = p.Id, kind = "post" }] : [])).ToArray();
        string query = string.Join(" ", targets.Where(p => requested.Contains(p.Id) || p.Replies.Any(r => requested.Contains(r.Id)))
            .Select(p => p.Title + " " + (requested.Contains(p.Id) ? p.Body : string.Join(" ", p.Replies.Where(r => requested.Contains(r.Id)).Select(r => r.Body)))));
        var contexts = targets.Select(post =>
        {
            bool complete = requested.Contains(post.Id) || post.Replies.Any(r => requested.Contains(r.Id)) || post.Replies.Count <= 40;
            var conversation = CommunityThreads.ContextReplies(post, data.Day, complete);
            return new { post.Id, post.AuthorId, post.Title, post.Day, post.Body,
                bodyKind = CommunityThreads.IsHuman(data, post.AuthorId) || post.PersonalPost || post.SourceBody.Length > 0 ? "opinion" : "fact",
                officialRecord = !CommunityThreads.IsHuman(data, post.AuthorId) && post.SourceBody.Length > 0 ? post.SourceBody : null,
                mentionRequests = post.Replies.Where(r => requested.Contains(r.Id)).Select(r => new { messageId = r.Id, requiredAuthors = r.MentionedPeople.Where(id => CareerEngine.Person(data, id) is { } p && !SpireArbitration.Muted(p)).ToArray() })
                    .Concat(requested.Contains(post.Id) ? [new { messageId = post.Id, requiredAuthors = post.MentionedPeople.Where(id => CareerEngine.Person(data, id) is { } p && !SpireArbitration.Muted(p)).ToArray() }] : []).ToArray(),
                match = MatchContext(data, post), allowedAuthors = DiscussionPeople(data, post, requested).Select(p => p.Id).ToArray(),
                对玩家的态度 = ReplyAttitudes(data, post, DiscussionPeople(data, post, requested), occasion),
                conversationScope = complete ? "完整帖子" : "附带相关帖子：最初两层、最近十六层及其父回复",
                conversation = conversation.Select(r => new { r.Id, r.ParentId, r.AuthorId, r.Day, r.Body }).ToArray() };
        }).ToArray();
        var suppliedMemory = contexts.SelectMany(p => p.conversation.Select(r => p.Id + ":" + r.Id))
            .Concat(targets.SelectMany(p => new[] { p.Id + ":fact", p.Id + ":editorial", p.Id + ":result" })).ToHashSet();
        // 同帖旧分支也可检索；只排除已在正文和父级链提供的内容，避免重复传输。
        query += " " + string.Join(" ", contexts.SelectMany(p => p.conversation).Select(r => r.Body));
        var scheduledOpponents = data.Matches.Where(m => schedule.Upcoming.Any(s => s.Day == m.Day && s.Event == m.Event)).Select(m => m.OpponentId);
        var memoryPeople = targets.SelectMany(p => p.RelatedPeople).Concat(scheduledOpponents)
            .Concat(contexts.SelectMany(p => p.conversation).Where(r => !CommunityThreads.IsHuman(data, r.AuthorId)).Select(r => r.AuthorId))
            .Concat(people.Select(p => p.Id));
        var memories = CommunityMemorySearch.Retrieve(data, query, memoryPeople, data.Day, new HashSet<string>(), 8, suppliedMemory);
        var names = targets.Select(p => p.AuthorId).Concat(contexts.SelectMany(p => p.conversation.Select(r => r.AuthorId)))
            .Where(id => id != "player" && people.All(p => p.Id != id)).Distinct()
            .Select(id => new { Id = id, name = CareerEngine.DisplayName(data, id), gender = IdentityGender.Of(data, id) });
        var latest = data.Results.LastOrDefault(r => r.OfficialAscensionVerified && r.Day <= data.Day && r.Kind != "private-friendly");
        bool hasLatestEvidence = latest != null && memories.Any(m => m.Id.EndsWith(":result") && m.Day == latest.Day && m.People.Contains("player") && m.People.Contains(latest.OpponentId));
        return JsonSerializer.Serialize(new { day = data.Day, player = new { name = CareerEngine.Name(data), gender = data.PlayerGender }, schedule = PublicSchedule.ForPrompt(schedule), playerRecord = PlayerPublicRecord(data, data.Day, !hasLatestEvidence && !contexts.Any(c => c.match != null)), queued, targets = contexts,
            attitudeScale = PersonalityLibrary.AttitudeScale, 态度说明 = "涉及玩家时，采用对应帖子中面向该玩家的态度；其他话题使用人物本次态度。", people = people.Select(p => Persona(data, p, occasion, privatePosts: targets.Where(t => DiscussionPeople(data, t, requested).Any(s => s.Id == p.Id)))), otherSpeakers = names, memory = memories,
            career = new { data.Esports.Country, data.Esports.BestClear, data.Esports.WinStreak,
                honors = data.Esports.Honors.TakeLast(3).Select(h => new { h.Title, h.Day, h.Season }) } }, Json);
    }
    private sealed record DiscussionPermission(HashSet<string> Authors, HashSet<string> Parents);
    private static Dictionary<string, DiscussionPermission> ReadDiscussionPermissions(string context)
    {
        using var document = JsonDocument.Parse(context);
        return document.RootElement.GetProperty("targets").EnumerateArray().ToDictionary(p => p.GetProperty("Id").GetString()!,
            p => new DiscussionPermission(p.GetProperty("allowedAuthors").EnumerateArray().Select(a => a.GetString()!).ToHashSet(),
                p.GetProperty("conversation").EnumerateArray().Select(r => r.GetProperty("Id").GetString()!).ToHashSet()));
    }
    internal static List<CommunityReply> ParseReplies(JsonElement array, CommunityPost post, ISet<string> allowed, bool existingParents, int day, ISet<string>? requested = null, ISet<string>? suppliedParents = null)
    {
        var result = new List<CommunityReply>(); var aliases = new Dictionary<string, string>();
        var existing = existingParents ? post.Replies.Select(r => r.Id).ToHashSet() : new HashSet<string>();
        if (suppliedParents != null) existing.IntersectWith(suppliedParents);
        foreach (var item in array.EnumerateArray())
        {
            string localId = item.GetProperty("id").GetString() ?? "";
            string author = item.GetProperty("authorId").GetString() ?? "";
            string parent = item.GetProperty("parentId").GetString() ?? "";
            string body = item.GetProperty("body").GetString() ?? "";
            if (string.IsNullOrWhiteSpace(localId) || existing.Contains(localId) || aliases.ContainsKey(localId) || !allowed.Contains(author) || author == "player" || string.IsNullOrWhiteSpace(body))
                throw new InvalidDataException("回复标识或人物无效");
            if (parent.Length > 0 && !existing.Contains(parent) && !aliases.ContainsKey(parent)) throw new InvalidDataException("回复目标无效或顺序错误");
            var covers = requested == null ? new List<string>()
                : item.TryGetProperty("covers", out var covered) ? covered.EnumerateArray().Select(x => x.GetString() ?? "").Distinct().ToList()
                : requested.Contains(parent) ? new List<string> { parent }
                : parent.Length == 0 && requested.Contains(post.Id) ? new List<string> { post.Id } : [];
            if (covers.Any(id => !requested!.Contains(id))) throw new InvalidDataException("回应了不在本轮队列中的留言");
            var reply = new CommunityReply { AiGenerated = true, AuthorId = author, ParentId = aliases.GetValueOrDefault(parent, parent), Body = body, Day = day, Covers = covers };
            aliases[localId] = reply.Id; result.Add(reply);
        }
        if (result.Count == 0) throw new InvalidDataException("缺少回复");
        return result;
    }
    internal static void ApplyDiscussion(CareerData data, ISet<string> requested, List<CommunityPost> targets, string content)
        => ApplyDiscussionCore(data, requested, targets, content, ReadDiscussionPermissions(BuildDiscussionPrompt(data, requested, targets)));
    private static void ApplyDiscussionCore(CareerData data, ISet<string> requested, List<CommunityPost> targets, string content, Dictionary<string, DiscussionPermission> permissions)
    {
        using var parsed = JsonDocument.Parse(content);
        var staged = new List<(CommunityPost Post, List<CommunityReply> Replies)>(); var seen = new HashSet<string>();
        foreach (var item in parsed.RootElement.GetProperty("reactions").EnumerateArray())
        {
            string id = item.GetProperty("postId").GetString() ?? "";
            var post = targets.FirstOrDefault(p => p.Id == id);
            if (post == null || !seen.Add(id) || !CommunityThreads.All(data).Contains(post)) throw new InvalidDataException("回应帖子无效");
            if (!permissions.TryGetValue(id, out var permission)) throw new InvalidDataException("帖子未包含于请求");
            staged.Add((post, ParseReplies(item.GetProperty("replies"), post, permission.Authors, true, data.Day, requested, permission.Parents)));
        }
        if (staged.SelectMany(s => s.Replies).Any(r => CareerEngine.Person(data, r.AuthorId) is { } p && SpireArbitration.Muted(p)))
            throw new InvalidDataException("回复期间有人受到封号处分，请重新生成其他选手的回应。");
        if (!requested.SetEquals(staged.SelectMany(s => s.Replies).SelectMany(r => r.Covers))) throw new InvalidDataException("留言批次未完整回应");
        foreach (var item in staged)
        {
            var mentions = item.Post.Replies.Where(r => requested.Contains(r.Id)).Select(r => (r.Id, r.MentionedPeople))
                .Concat(requested.Contains(item.Post.Id) ? [(item.Post.Id, item.Post.MentionedPeople)] : []);
            foreach (var (id, authors) in mentions)
                foreach (string author in authors.Where(a => CareerEngine.Person(data, a) is { } p && !SpireArbitration.Muted(p)))
                    if (!item.Replies.Any(r => r.AuthorId == author && r.Covers.Contains(id))) throw new InvalidDataException("被 @ 的选手尚未完整回应，可以重试。");
        }
        var awaiting = CommunityThreads.PendingIds(data).ToHashSet();
        if (!requested.All(awaiting.Contains)) throw new InvalidDataException("本轮留言状态已变化");
        foreach (var item in staged) { item.Post.Replies.AddRange(item.Replies); item.Post.Revision++; CommunityThreads.Remember(data, item.Post); }
        foreach (var r in CommunityThreads.All(data).SelectMany(p => p.Replies).Where(r => requested.Contains(r.Id))) r.NeedsReaction = false;
        foreach (var p in CommunityThreads.All(data).Where(p => requested.Contains(p.Id))) p.NeedsReaction = false;
    }
}
