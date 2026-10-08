using System.Net.Http.Headers;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using Godot;

namespace NationalSpire;

public static partial class AiService
{
    private static readonly AiRequestQueue Queue = new();
    private static readonly SemaphoreSlim StartGate = new(1, 1);
    public static void RefreshConcurrency(AiOptions? options = null) => Queue.Configure((options ?? CareerStore.Data.Ai).MaxConcurrentRequests);
    private static Task<IDisposable> EnterQueueAsync(CareerData data, IEnumerable<string> keys, IEnumerable<AiWorkState> works)
    {
        Queue.Configure(data.Ai.MaxConcurrentRequests);
        var states = works.ToArray();
        return Queue.EnterAsync(data, keys, reason => SetWaiting(states, reason));
    }
    private static void SetWaiting(IEnumerable<AiWorkState> works, string reason)
    {
        bool changed = false;
        foreach (var work in works)
            if (work.State == "queued" && work.WaitReason != reason) { work.WaitReason = reason; changed = true; }
        if (changed && reason.Length > 0) Diagnostics.Record("ai.wait", reason);
    }
    private static async Task WaitForRequestStartAsync(CareerData data, IEnumerable<AiWorkState> works)
    {
        var states = works.ToArray();
        if (StartGate.CurrentCount == 0) SetWaiting(states, "正在等待前一项发送，随后按请求间隔继续……");
        await StartGate.WaitAsync();
        try
        {
            while (data.Ai.Enabled && CareerStore.IsCurrent(data))
            {
                int interval = Math.Clamp(data.Ai.MinimumIntervalSeconds, 0, 300);
                var wait = TimeSpan.FromSeconds(interval) - (DateTimeOffset.UtcNow - _lastRequest);
                if (wait <= TimeSpan.Zero) break;
                Status = "等待请求间隔";
                SetWaiting(states, $"正在等待请求间隔（设置为 {interval} 秒）……");
                // 设置调整及生涯切换在等待期间生效。
                await Task.Delay(TimeSpan.FromMilliseconds(Math.Min(500, wait.TotalMilliseconds)));
            }
            _lastRequest = DateTimeOffset.UtcNow;
        }
        finally { SetWaiting(states, ""); StartGate.Release(); }
    }
    private static readonly System.Net.Http.HttpClient Client = new() { Timeout = System.Threading.Timeout.InfiniteTimeSpan };
    private static readonly JsonSerializerOptions Json = new() { Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping };
    internal static readonly HttpRequestOptionsKey<TimeSpan> TimeoutOption = new("NationalSpire.Timeout");
    private static async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CareerData data, string trace, string kind, IEnumerable<string> targets)
    {
        request.Options.Set(TimeoutOption, TimeSpan.FromMinutes(Math.Clamp(data.Ai.RequestTimeoutMinutes, 2, 30)));
        Diagnostics.RegisterSecret(request.Headers.Authorization?.Parameter);
        Diagnostics.Record("ai.request", new { trace, kind, targets = targets.ToArray(), data.Day, data.Season,
            endpoint = request.RequestUri?.ToString(), data.Ai.Model, data.Ai.RequestTimeoutMinutes, data.Ai.MaxConcurrentRequests,
            payload = request.Content == null ? "" : await request.Content.ReadAsStringAsync() });
        var timer = System.Diagnostics.Stopwatch.StartNew();
        HttpResponseMessage response;
        try { response = await Transport(request); }
        catch (Exception e)
        {
            Diagnostics.Record("ai.transport-failed", new { trace, kind, elapsedMilliseconds = timer.ElapsedMilliseconds, exception = e.ToString() });
            throw;
        }
        try
        {
            string body = await response.Content.ReadAsStringAsync();
            Diagnostics.Record("ai.response", new { trace, kind, status = (int)response.StatusCode,
                elapsedMilliseconds = timer.ElapsedMilliseconds, characters = body.Length, body });
            return response;
        }
        catch { response.Dispose(); throw; }
    }
    private static async Task<HttpResponseMessage> SendTransportAsync(HttpRequestMessage request)
    {
        var duration = request.Options.TryGetValue(TimeoutOption, out var value) ? value : TimeSpan.FromMinutes(10);
        using var timeout = new CancellationTokenSource(duration);
        return await Client.SendAsync(request, timeout.Token);
    }
    private static DateTimeOffset _lastRequest;
    public static string Status { get; private set; } = "尚未请求";
    private static string? _sessionKey = AiSettingsStore.ReadKey();
    private static string? CurrentKey => !string.IsNullOrWhiteSpace(_sessionKey) ? _sessionKey : System.Environment.GetEnvironmentVariable("NATIONAL_SPIRE_API_KEY");
    public static void SetSessionKey(string value) => _sessionKey = value;
    public static string? PersistKey(string value)
    {
        Diagnostics.RegisterSecret(value);
        bool deleting = string.IsNullOrWhiteSpace(value);
        try
        {
            AiSettingsStore.SaveKey(value); _sessionKey = value;
            Diagnostics.Record("ai.credential.saved", new { deleting, available = HasKey });
            return null;
        }
        catch (Exception e)
        {
            _sessionKey = value;
            Diagnostics.Record("ai.credential.save-failed", new { deleting, available = HasKey, error = e.GetType().Name });
            return deleting ? "本次启动已清除密钥；删除本机文件失败：" + e.GetType().Name
                : "密钥暂存于本次启动；加密保存失败：" + e.GetType().Name;
        }
    }
    public static bool HasKey => !string.IsNullOrWhiteSpace(CurrentKey);
    internal static string FailureReason(Exception error)
    {
        string prefix = error is OperationCanceledException ? "等待响应超时，后端可能仍在生成。\n" : "";
        var messages = new List<string>();
        for (Exception? current = error; current != null; current = current.InnerException)
            messages.Add(current.GetType().Name + ": " + current.Message);
        return Diagnostics.Redact(prefix + string.Join("\n", messages));
    }
    internal static async Task<string> HttpFailure(HttpResponseMessage response) => Diagnostics.Redact(
        $"HTTP {(int)response.StatusCode} {response.ReasonPhrase}\n" + await response.Content.ReadAsStringAsync());
    internal static bool TryGetEndpoint(string? endpoint, out Uri uri)
    {
        // 自建后端可能通过远程 HTTP 提供服务；新闻与互动统一使用同一地址规则。
        uri = null!;
        if (!Uri.TryCreate(endpoint?.Trim(), UriKind.Absolute, out var parsed)
            || parsed.Scheme is not ("http" or "https") || string.IsNullOrEmpty(parsed.Host)) return false;
        var builder = new UriBuilder(parsed);
        string path = builder.Path.TrimEnd('/');
        if (!path.EndsWith("/chat/completions", StringComparison.OrdinalIgnoreCase))
            path += "/chat/completions";
        builder.Path = path;
        uri = builder.Uri; return true;
    }
    public static async Task ProcessPendingAsync(CareerData? requestedData = null)
    {
        await Task.WhenAll(ProcessNewsAsync(null, requestedData), ProcessWeeklyAsync(requestedData));
    }
    public static Task RetryNewsAsync(string postId) => ProcessNewsAsync(postId);
    public static Task RetryFailedNewsAsync() => ProcessNewsAsync("*");
    internal static List<CommunityPost> SelectNewsBatch(IEnumerable<CommunityPost> candidates, int count)
    {
        return PublicationBacklog.Select(candidates, count);
    }

    public static async Task ProcessNewsAsync(string? retryId, CareerData? requestedData = null)
    {
        var data = requestedData ?? CareerStore.Data;
        if (!data.Ai.Enabled) { Status = "离线社区模式"; return; }
        PublicationBacklog.Compact(data, false);
        var candidates = CommunityThreads.All(data).Where(p => !CareerEngine.ExcludedAutomaticPreview(data, p) && !CommunityThreads.IsHuman(data, p.AuthorId)
            && (retryId != null ? (retryId == "*" || p.Id == retryId) && p.NewsGeneration.State == "failed"
                : p.AiPending && p.Day >= data.Day - 7 && p.NewsGeneration.State == "idle" && !p.Replies.Any(r => CommunityThreads.IsHuman(data, r.AuthorId))))
            .ToList();
        var pending = retryId != null && retryId != "*" ? candidates : PublicationBacklog.Select(candidates, data.Ai.MaxNewsPosts, data);
        if (pending.Count == 0) return;
        if (retryId == null)
        {
            foreach (var post in candidates.Except(pending))
            {
                post.AiPending = false;
                CommunityThreads.SetWork(post.NewsGeneration, "superseded");
            }
        }
        foreach (var post in pending) { CommunityThreads.SetWork(post.NewsGeneration, "queued"); CommunityThreads.Remember(data, post); }
        CareerStore.Save(data);
        // 总帖数仍由配置决定；限制单次输出规模，避免大批次截断后全部重试。
        foreach (var batch in pending.Chunk(5)) await ProcessNewsBatchAsync(data, batch.ToList());
    }

    private static async Task ProcessNewsBatchAsync(CareerData data, List<CommunityPost> pending)
    {
        string trace = Guid.NewGuid().ToString("N");
        string failure = "请求中断或配置已改变，可重试";
        void Fail(string message) { failure = message; Status = message; }
        using var lease = await EnterQueueAsync(data, pending.Select(p => "post:" + p.Id), pending.Select(p => p.NewsGeneration));
        try
        {
            pending.RemoveAll(p => p.NewsGeneration.State == "superseded");
            if (pending.Count == 0 || !CareerStore.IsCurrent(data)) return;
            var key = CurrentKey; string endpoint = data.Ai.Endpoint, model = data.Ai.Model;
            if (!data.Ai.Enabled) return;
            if (string.IsNullOrWhiteSpace(key)) { Fail("未设置密钥"); return; }
            if (!TryGetEndpoint(endpoint, out var uri)) { Fail("接口地址无效，请填写完整的 http:// 或 https:// 地址"); return; }
            await WaitForRequestStartAsync(data, pending.Select(p => p.NewsGeneration));
            if (!data.Ai.Enabled || !CareerStore.IsCurrent(data) || CurrentKey != key || data.Ai.Endpoint != endpoint || data.Ai.Model != model) return;
            pending.RemoveAll(p => p.NewsGeneration.State == "superseded");
            if (pending.Count == 0) return;
            int today = int.Parse(DateTime.UtcNow.ToString("yyyyMMdd"));
            if (data.Ai.RequestDay != today) { data.Ai.RequestDay = today; data.Ai.RequestsToday = 0; }
            // 发送时固定可用人物和原楼层，响应期间新增留言不会改变校验权限。
            var snapshots = pending.Select(p => JsonSerializer.Deserialize<CommunityPost>(JsonSerializer.Serialize(p, Json))!).ToList();
            var wire = new AiWireProtocol(data);
            var payload = BuildNewsPayload(data, snapshots, wire);
            var allowed = PromptPeople(data, snapshots).Select(p => p.Id).ToHashSet();
            foreach (var post in pending) CommunityThreads.SetWork(post.NewsGeneration, "sending");
            data.Ai.RequestsToday++; CareerStore.Save(data); Status = "正在生成社区讨论";
            using var request = new HttpRequestMessage(HttpMethod.Post, uri);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", key);
            request.Content = new StringContent(payload, Encoding.UTF8, "application/json");
            using var response = await SendAsync(request, data, trace, "news", pending.Select(p => p.Id));
            if (!response.IsSuccessStatusCode) { Fail(await HttpFailure(response)); return; }
            var content = wire.Decode(await ReadResponseCompletion(response), expectedArray: "posts");
            if (!data.Ai.Enabled || !CareerStore.IsCurrent(data) || key != CurrentKey || endpoint != data.Ai.Endpoint || model != data.Ai.Model) return;
            if (pending.Any(p => p.NewsGeneration.State == "superseded"))
            { foreach (var p in pending) { p.AiPending = false; CommunityThreads.SetWork(p.NewsGeneration, "superseded"); } return; }
            ApplyNewsResponse(data, pending, content, snapshots, allowed);
            Diagnostics.Record("ai.applied", new { trace, kind = "news", posts = pending.Select(p => p.Id).ToArray() });
            Status = $"已发布 {pending.Count} 篇 AI 更新"; CareerStore.Save(data);
        }
        catch (Exception e) { Diagnostics.Error("ai.news:" + trace, e); Fail(FailureReason(e)); GD.PushWarning("[NationalSpire] 新闻生成：" + failure); }
        finally
        {
            foreach (var post in pending.Where(p => p.NewsGeneration.State is not ("completed" or "superseded")))
            { CommunityThreads.SetWork(post.NewsGeneration, "failed", failure); post.Revision++; CommunityThreads.Remember(data, post); }
            CareerStore.Save(data);
        }
    }

    private static string BuildPayload(CareerData data, List<CommunityPost> pending) => BuildNewsPayload(data, pending, new AiWireProtocol(data));
    private static string BuildNewsPayload(CareerData data, List<CommunityPost> pending, AiWireProtocol wire) => JsonSerializer.Serialize(new
    {
        model = data.Ai.Model,
        stream = false,
        messages = new[] { new { role = "system", content = ComposeSystem(data.Ai, "news") }, new { role = "user", content = wire.Encode(BuildPrompt(data, pending)) } }
    }, Json);

    private static string BuildPrompt(CareerData data, List<CommunityPost> pending) => BuildNewsContext(data, pending);

    private static List<CareerPerson> PromptPeople(CareerData data, List<CommunityPost> pending)
    {
        // 帖数增加时先覆盖全部作者和每帖两名评论者，防止后面的帖子缺少可发言人物。
        var ids = pending.Select(p => p.AuthorId).Concat(pending.SelectMany(p => p.Replies.Take(2).Select(r => r.AuthorId)))
            .Concat(pending.SelectMany(p => p.Replies).Select(r => r.AuthorId))
            .Distinct().Take(Math.Max(12, pending.Count * 4)).ToHashSet();
        return data.People.Where(p => ids.Contains(p.Id) && !CommunityThreads.IsHuman(data, p.Id)).ToList();
    }

    private static void ApplyResponse(CareerData data, List<CommunityPost> pending, string content)
        => ApplyNewsResponse(data, pending, content, pending, PromptPeople(data, pending).Select(p => p.Id).ToHashSet());
    private static void ApplyNewsResponse(CareerData data, List<CommunityPost> pending, string content, List<CommunityPost> snapshots, HashSet<string> allowed)
    {
        using var parsed = JsonDocument.Parse(content);
        var staged = new List<(CommunityPost Post, string Title, string Body, List<CommunityReply> Replies)>();
        var seen = new HashSet<string>();
        foreach (var item in parsed.RootElement.GetProperty("posts").EnumerateArray())
        {
            string id = item.GetProperty("id").GetString() ?? "";
            var post = pending.FirstOrDefault(p => p.Id == id);
            if (post == null || CommunityThreads.IsHuman(data, post.AuthorId) || !seen.Add(id)) throw new InvalidDataException("帖子 ID 不符合请求");
            string body = item.GetProperty("body").GetString() ?? "";
            string title = item.GetProperty("title").GetString() ?? "";
            if (string.IsNullOrWhiteSpace(title)) throw new InvalidDataException("标题无效");
            if (string.IsNullOrWhiteSpace(body)) throw new InvalidDataException("正文无效");
            var original = snapshots.Single(p => p.Id == id);
            var permitted = original.Replies.Select(r => r.AuthorId).Append(original.AuthorId).Where(allowed.Contains).ToHashSet();
            var replies = ParseReplies(item.GetProperty("replies"), post, permitted, false, data.Day);
            if (replies.Any(r => CareerEngine.Person(data, r.AuthorId) is { } p && SpireArbitration.Muted(p))
                || CareerEngine.Person(data, post.AuthorId) is { } author && SpireArbitration.Muted(author))
                throw new InvalidDataException("发言者受到封号处分，本次内容未发布。");
            staged.Add((post, title, body, replies));
        }
        if (staged.Count != pending.Count) throw new InvalidDataException("批次不完整");
        // 整批校验后一次提交；生成完整帖子，同时另存官方事实供赛果核对。
        foreach (var item in staged)
        {
            if (item.Post.SourceBody.Length == 0) { item.Post.SourceTitle = item.Post.Title; item.Post.SourceBody = item.Post.Body; }
            item.Post.Title = item.Title; item.Post.Body = item.Body; item.Post.Analysis = "";
            if (item.Post.Replies.Any(r => CommunityThreads.IsHuman(data, r.AuthorId))) item.Post.Replies.AddRange(item.Replies);
            else item.Post.Replies = item.Replies;
            item.Post.AiPending = false; item.Post.Revision++;
            CommunityThreads.SetWork(item.Post.NewsGeneration, "completed"); CommunityThreads.Remember(data, item.Post);
        }
    }

    internal static async Task<string> ReadResponseCompletion(HttpResponseMessage response)
    {
        string body = await response.Content.ReadAsStringAsync();
        try
        {
            using var document = JsonDocument.Parse(body);
            return ReadCompletion(document.RootElement);
        }
        catch (Exception error) when (error is JsonException or KeyNotFoundException or InvalidDataException or InvalidOperationException or IndexOutOfRangeException)
        {
            throw new InvalidDataException(Diagnostics.Redact($"HTTP {(int)response.StatusCode} {response.ReasonPhrase}\n" + body), error);
        }
    }
    private static string ReadCompletion(JsonElement envelope)
    {
        if (envelope.TryGetProperty("error", out var error)) throw new InvalidDataException(error.GetRawText());
        var choice = envelope.GetProperty("choices")[0];
        // 即使被截断的片段恰好能解析，也不能当作完整回答提交。
        if (choice.TryGetProperty("finish_reason", out var reason) && reason.ValueKind != JsonValueKind.Null
            && reason.GetString() != "stop") throw new InvalidDataException("模型未正常结束输出");
        string? content = choice.GetProperty("message").GetProperty("content").GetString();
        return !string.IsNullOrWhiteSpace(content) ? content : throw new InvalidDataException("模型未返回内容");
    }
}
