using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace NationalSpire;

public static partial class AiService
{
    internal static Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> PrivateTransport =
        (request, token) => Client!.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, token);
    private static readonly Dictionary<string, CancellationTokenSource> PrivateRequests = [];
    private static readonly HashSet<string> PrivateSummaries = [];
    private static readonly AiRequestQueue PrivateForegroundQueue = new();
    private static readonly SemaphoreSlim PrivateSummaryQueue = new(1, 1);
    public static readonly Dictionary<string, (string Turn, string Text)> PrivateLive = [];
    public static readonly Dictionary<string, (string Turn, string Text)> PrivateReasoningLive = [];
    public static string PrivateKey(CareerData data, string person) => data.WorldId + "/" + person;
    public static void CancelPrivate(CareerData data, string person)
    { if (PrivateRequests.TryGetValue(PrivateKey(data, person), out var cancel)) cancel.Cancel(); }
    public static bool PrivateBusy(CareerData data, string person) => PrivateRequests.ContainsKey(PrivateKey(data, person));
    public static Task SummarizePrivateManually(Func<CareerData?> current, Action<CareerData> save, string person) => SummarizePrivateAsync(current, save, person);

    public static async Task ProcessPrivateAsync(Func<CareerData?> current, Action<CareerData> save, string person,
        Action<string, string>? progress = null)
    {
        var data = current(); if (data == null || !PrivateMessages.CanChat(data, person)) return;
        string key = PrivateKey(data, person);
        var resolve = current;
        current = () => resolve() is { } latest && PrivateMessages.CanChat(latest, person) && PrivateKey(latest, person) == key ? latest : null;
        if (PrivateRequests.ContainsKey(key)) return;
        var conversation = PrivateMessages.Conversation(data, person);
        var turn = conversation.Turns.FirstOrDefault(t => t.Status == "queued"); if (turn == null) return;
        using var cancel = new CancellationTokenSource(TimeSpan.FromMinutes(Math.Clamp(data.Ai.RequestTimeoutMinutes, 2, 30)));
        PrivateRequests[key] = cancel;
        string turnId = turn.Id;
        void Notify(string text)
        {
            try { progress?.Invoke(turnId, text); }
            catch (Exception e) { Diagnostics.Record("private.delivery.failed", new { person, error = FailureReason(e) }); }
        }
        int originalFavour = PrivateMessages.Favour(data, person);
        try
        {
            if (!data.Ai.Enabled) throw new InvalidOperationException("请先启用 AI。");
            PrivateForegroundQueue.Configure(data.Ai.MaxConcurrentRequests);
            using var lease = await EnterPrivateQueue(data, key, cancel.Token);
            cancel.Token.ThrowIfCancellationRequested();
            data = current(); if (data == null) return;
            conversation = PrivateMessages.Conversation(data, person);
            turn = conversation.Turns.First(t => t.Id == turnId);
            if (turn.Status != "queued") return;
            if (turn.RequestKind != "arbitration" && SpireArbitration.Muted(CareerEngine.Person(data, person)!)) throw new InvalidOperationException("该角色账号已封禁，普通私信已停止。");
            originalFavour = PrivateMessages.Favour(data, person);
            turn.Context = PrivateMessagePrompts.Context(data, conversation, turn);
            turn.Status = "sending"; turn.Error = ""; save(data);
            if (turn.RequestKind == "arbitration")
            {
                var record = new StringBuilder();
                string response = await RequestPrivateAsync(data.Ai, SpireArbitration.Compose(data, conversation, turn), false, null, cancel.Token, chunk => record.Append(chunk));
                var decision = SpireArbitration.Parse(response);
                cancel.Token.ThrowIfCancellationRequested();
                data = current(); if (data == null) return;
                conversation = PrivateMessages.Conversation(data, person);
                turn = conversation.Turns.First(t => t.Id == turnId);
                if (turn.Status != "sending") return;
                SpireArbitration.Complete(data, conversation, turn, decision);
                turn.Reasoning = record.ToString(); save(data); Notify(turn.Reply); return;
            }
            var messages = PrivateMessagePrompts.Compose(data, conversation, turn);
            var parser = new PrivateStreamParser();
            var reasoning = new StringBuilder();
            var lastProgress = DateTime.MinValue;
            void Progress(string chunk)
            {
                parser.Feed(chunk); PrivateLive[key] = (turnId, parser.Text);
                if ((DateTime.UtcNow - lastProgress).TotalMilliseconds < 100) return;
                lastProgress = DateTime.UtcNow; Notify(parser.Text);
            }
            void Thinking(string chunk)
            {
                reasoning.Append(chunk); PrivateReasoningLive[key] = (turnId, reasoning.ToString());
                if ((DateTime.UtcNow - lastProgress).TotalMilliseconds < 100) return;
                lastProgress = DateTime.UtcNow; Notify(parser.Text);
            }
            await RequestPrivateAsync(data.Ai, messages, true, Progress, cancel.Token, Thinking);
            cancel.Token.ThrowIfCancellationRequested(); parser.Finish();
            data = current(); if (data == null || PrivateKey(data, person) != key || !PrivateMessages.CanChat(data, person)) return;
            conversation = PrivateMessages.Conversation(data, person);
            turn = conversation.Turns.First(t => t.Id == turnId);
            if (turn.Status != "sending") return;
            if (SpireArbitration.Muted(CareerEngine.Person(data, person)!)) throw new InvalidOperationException("该角色账号已封禁，普通私信已停止。");
            if (string.IsNullOrWhiteSpace(parser.Text)) throw new InvalidDataException("私信回复为空。");
            turn.Reply = parser.Text.Trim(); turn.Reasoning = reasoning.ToString(); turn.Status = "complete"; turn.Error = parser.Error;
            PrivateMessages.Apply(data, conversation, turn, parser.Directives, originalFavour);
            turn.Regenerating = false; turn.PreviousReply = turn.PreviousReasoning = "";
            conversation.LastReplyOrder = Math.Max(DateTime.UtcNow.Ticks, PrivateMessages.Mailbox(data).Conversations.Values.Max(x => x.LastReplyOrder) + 1);
            save(data); Notify(turn.Reply);
            // 总结独立执行，主回复结束即可继续聊天。
            _ = SummarizePrivateAsync(current, save, person);
        }
        catch (Exception e)
        {
            data = current();
            if (data != null && PrivateKey(data, person) == key && PrivateMessages.CanChat(data, person))
            {
                var failed = PrivateMessages.Conversation(data, person).Turns.FirstOrDefault(t => t.Id == turnId);
                if (failed != null && failed.Status != "complete")
                {
                    if (!failed.Regenerating)
                    {
                        failed.Reply = PrivateLive.GetValueOrDefault(key).Text ?? "";
                        failed.Reasoning = PrivateReasoningLive.GetValueOrDefault(key).Text ?? "";
                    }
                    PrivateMessageCommands.RestoreInterrupted(failed, e is OperationCanceledException ? "生成已停止或超时，可以重试。" : FailureReason(e)); save(data);
                }
            }
            Diagnostics.Record("private.failed", new { person, turnId, error = FailureReason(e) });
        }
        finally { PrivateLive.Remove(key); PrivateReasoningLive.Remove(key); PrivateRequests.Remove(key); }
    }

    private static async Task<IDisposable> EnterPrivateQueue(CareerData data, string key, CancellationToken token)
    {
        var pending = PrivateForegroundQueue.EnterAsync(data, [key]);
        try { return await pending.WaitAsync(token); }
        catch (OperationCanceledException)
        {
            // 队列获得名额后归还，已经取消的请求不会访问服务。
            _ = ReleasePending(); throw;
        }
        async Task ReleasePending() { using var lease = await pending; }
    }

    internal static async Task<string> RequestPrivateAsync(AiOptions options, List<Dictionary<string, string>> messages, bool stream,
        Action<string>? progress, CancellationToken token, Action<string>? reasoning = null)
    {
        if (string.IsNullOrWhiteSpace(CurrentKey)) throw new InvalidOperationException("请先在模组设置中保存密钥。");
        if (!TryGetEndpoint(options.Endpoint, out var endpoint)) throw new ArgumentException("接口地址无效。");
        using var request = new HttpRequestMessage(HttpMethod.Post, endpoint);
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", CurrentKey);
        request.Content = new StringContent(JsonSerializer.Serialize(new { model = options.Model, messages, stream }, Json), Encoding.UTF8, "application/json");
        Diagnostics.RegisterSecret(CurrentKey);
        Diagnostics.Record("private.request", new { stream, options.Model, messages = messages.Count, characters = messages.Sum(m => m["content"].Length) });
        using var response = await PrivateTransport(request, token);
        if (!response.IsSuccessStatusCode) throw new HttpRequestException(await HttpFailure(response));
        if (!stream || response.Content.Headers.ContentType?.MediaType == "application/json")
        {
            string body = await response.Content.ReadAsStringAsync(token);
            using var document = JsonDocument.Parse(body);
            if (document.RootElement.TryGetProperty("error", out var error)) throw new InvalidDataException(error.ToString());
            LogPrivateUsage(document.RootElement);
            var choice = document.RootElement.GetProperty("choices")[0];
            if (choice.TryGetProperty("finish_reason", out var finish) && finish.ValueKind == JsonValueKind.String && finish.GetString() != "stop")
                throw new InvalidDataException("回复未完整结束：" + finish.GetString());
            var message = choice.GetProperty("message");
            reasoning?.Invoke(PrivateReasoning(message));
            string content = message.GetProperty("content").GetString() ?? "";
            progress?.Invoke(content); return content;
        }
        using var reader = new StreamReader(await response.Content.ReadAsStreamAsync(token));
        var result = new StringBuilder(); var eventData = new StringBuilder(); bool done = false, completed = false; int reasoningSize = 0;
        void Event()
        {
            if (eventData.Length == 0) return;
            string content = eventData.ToString().Trim(); eventData.Clear();
            if (content == "[DONE]") { done = true; return; }
            using var document = JsonDocument.Parse(content); var root = document.RootElement;
            if (root.TryGetProperty("error", out var error)) throw new InvalidDataException(error.ToString());
            LogPrivateUsage(root);
            if (!root.TryGetProperty("choices", out var choices) || choices.GetArrayLength() == 0) return;
            var first = choices[0];
            if (first.TryGetProperty("finish_reason", out var finish) && finish.ValueKind == JsonValueKind.String)
            {
                if (finish.GetString() != "stop") throw new InvalidDataException("私信回复未完整结束：" + finish.GetString());
                completed = true;
            }
            if (first.TryGetProperty("delta", out var delta))
            {
                string thought = PrivateReasoning(delta); reasoningSize += thought.Length;
                if (thought.Length > 0) reasoning?.Invoke(thought);
                if (delta.TryGetProperty("content", out var text) && text.ValueKind == JsonValueKind.String)
                { string chunk = text.GetString()!; result.Append(chunk); progress?.Invoke(chunk); }
            }
        }
        while (await reader.ReadLineAsync(token) is { } line)
        {
            if (line.Length == 0) { Event(); if (done) break; }
            else if (line.StartsWith("data:", StringComparison.Ordinal)) { if (eventData.Length > 0) eventData.Append('\n'); eventData.Append(line[5..].TrimStart()); }
            if (result.Length + eventData.Length + reasoningSize > 100000) throw new InvalidDataException("私信回复过长，已停止接收。");
        }
        Event();
        if (!done && !completed) throw new IOException("回复连接提前结束，交互未执行，请重试。");
        return result.ToString();
    }
    private static string PrivateReasoning(JsonElement message)
    {
        foreach (string key in new[] { "reasoning_content", "reasoning" })
            if (message.TryGetProperty(key, out var value) && value.ValueKind == JsonValueKind.String) return value.GetString() ?? "";
        return "";
    }
    private static void LogPrivateUsage(JsonElement root)
    {
        if (root.TryGetProperty("usage", out var usage)) Diagnostics.Record("private.usage", usage.ToString());
    }

    private static async Task SummarizePrivateAsync(Func<CareerData?> current, Action<CareerData> save, string person)
    {
        var data = current(); if (data == null || !PrivateMessages.CanChat(data, person)) return;
        string key = PrivateKey(data, person); if (!PrivateSummaries.Add(key)) return;
        var resolve = current;
        current = () => resolve() is { } latest && PrivateMessages.CanChat(latest, person) && PrivateKey(latest, person) == key ? latest : null;
        long revision = PrivateMessages.Conversation(data, person).MemoryRevision;
        try
        {
            var c = PrivateMessages.Conversation(data, person); var settings = data.Life.Mailbox.Settings;
            string manual = c.SummaryRequest; c.SummaryRequest = "";
            settings.Validate();
            if (manual == "small" || manual != "big" && PrivateMessages.Completed(c) > settings.MaximumRounds)
            {
                c.SummaryStatus = "正在整理聊天记忆"; save(data);
                int end = c.Turns.FindLastIndex(t => t.Status == "complete") + 1;
                PrivateInteractionIds.Ensure(c);
                var snapshot = c.Turns.Skip(c.ContextStart).Take(end - c.ContextStart).Where(t => t.Status == "complete" && !(t.UserDeleted && t.ReplyDeleted)).Select(t => new { 日期 = $"第 {t.Season} 赛季第 {t.Day - SeasonCalendar.Start(data, t.Season)} 天", 玩家 = t.UserDeleted ? null : PrivateMessagePrompts.UserText(t, c), 你 = t.ReplyDeleted ? null : t.Reply }).ToArray();
                string text = await Summarize(data, person, "private-summary", JsonSerializer.Serialize(snapshot, Json));
                data = current(); if (data == null) return; c = PrivateMessages.Conversation(data, person);
                if (c.MemoryRevision != revision) return;
                PrivateMessages.FinishSmallSummary(c, data.Life.Mailbox.Settings, end, text); save(data);
            }
            data = current(); if (data == null) return; c = PrivateMessages.Conversation(data, person); settings = data.Life.Mailbox.Settings;
            if (manual == "big" || c.SmallSummaries.Count >= settings.SmallSummaryLimit)
            {
                c.SummaryStatus = "正在合并长期记忆"; save(data);
                var snapshot = c.SmallSummaries.Take(settings.MergeOldest).ToArray();
                string text = await Summarize(data, person, "private-long-summary", string.Join("\n\n", snapshot.Select(s => s.Text)));
                data = current(); if (data == null) return; c = PrivateMessages.Conversation(data, person);
                if (c.MemoryRevision != revision) return;
                PrivateMessages.FinishBigSummary(c, snapshot.Select(s => s.Id).ToArray(), text); save(data);
            }
        }
        catch (Exception e)
        {
            data = current(); if (data != null) { PrivateMessages.Conversation(data, person).SummaryError = "记忆总结失败，下次回复后重试：" + FailureReason(e); save(data); }
        }
        finally
        {
            PrivateSummaries.Remove(key);
            data = current();
            if (data != null && PrivateMessages.Conversation(data, person) is { } c && c.SummaryStatus.Length > 0) { c.SummaryStatus = ""; save(data); }
        }
    }
    private static Task<string> Summarize(CareerData data, string person, string section, string content)
    {
        var p = CareerEngine.Person(data, person)!;
        List<Dictionary<string, string>> messages = [new() { ["role"] = "system", ["content"] = PromptLibrary.Get(data.Ai, section) + $"\n你是{p.PublicName}，以{p.PublicName}的第一人称整理与玩家{CareerEngine.Name(data)}的聊天。\n{p.PublicName}的性格 " + JsonSerializer.Serialize(PersonalityLibrary.PromptProfile(p.Personality), Json) }, new() { ["role"] = "user", ["content"] = content }];
        var node = JsonSerializer.SerializeToNode(messages)!; CharacterIdentity.Apply(node, CharacterIdentity.Aliases(data));
        messages = node.Deserialize<List<Dictionary<string, string>>>()!;
        return SummaryRequest(data.Ai, messages);
    }
    private static async Task<string> SummaryRequest(AiOptions options, List<Dictionary<string, string>> messages)
    {
        using var timeout = new CancellationTokenSource(TimeSpan.FromMinutes(Math.Clamp(options.RequestTimeoutMinutes, 2, 30)));
        await PrivateSummaryQueue.WaitAsync(timeout.Token);
        try { return await RequestPrivateAsync(options, messages, false, null, timeout.Token); }
        finally { PrivateSummaryQueue.Release(); }
    }
}
