using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace NationalSpire;

public static partial class AiService
{
    public static List<PromptTestSource> TestSources(CareerData data, string scene) => scene switch
    {
        "news" => CommunityThreads.All(data).Where(p => p.AuthorId != "player" && data.People.Any(who => who.Id == p.AuthorId))
            .OrderByDescending(p => p.Day).Select(p => new PromptTestSource(scene, p.Id, $"第 {p.Day} 天 · {p.Title}")).ToList(),
        "discussion" => CommunityThreads.All(data).OrderByDescending(p => p.Day)
            .Select(p => new PromptTestSource(scene, p.Id, $"第 {p.Day} 天 · {p.Title}")).ToList(),
        "profiles" => data.WeeklyEditions.OrderByDescending(w => w.Week).SelectMany(w => w.Profiles
            .Select(p => new PromptTestSource(scene, p.Id, $"第 {w.Week} 周 · {p.Name}", w.Week))).ToList(),
        "weekly" => data.WeeklyEditions.OrderByDescending(w => w.Week).SelectMany(w => w.Slides
            .Select(s => new PromptTestSource(scene, s.Id, $"第 {w.Week} 周 · {(s.Title.Length > 0 ? s.Title : s.Topic)}", w.Week))).ToList(),
        _ => []
    };

    private static T TestCopy<T>(T source) => JsonSerializer.Deserialize<T>(JsonSerializer.Serialize(source, Json))!;

    public static PromptTestSession CreateTestSession(CareerData data, PromptTestSource source, string message = "")
    {
        // 一次选择固定材料；重试只替换创作要求，生成结果始终写入独立副本。
        var snapshot = TestCopy(data);
        CareerLife.Ensure(snapshot);
        string context, target = source.Id;
        if (source.Scene is "news" or "discussion")
        {
            var post = CommunityThreads.All(snapshot).Single(p => p.Id == source.Id);
            if (source.Scene == "news") context = BuildNewsContext(snapshot, [post]);
            else
            {
                if (string.IsNullOrWhiteSpace(message)) throw new ArgumentException("请填写用来测试的留言。");
                var reply = new CommunityReply { AuthorId = "player", Day = snapshot.Day, Body = message.Trim(), NeedsReaction = true };
                post.Replies.Add(reply); target = reply.Id;
                context = BuildDiscussionPrompt(snapshot, new HashSet<string> { target }, [post]);
            }
        }
        else
        {
            var issue = snapshot.WeeklyEditions.Single(w => w.Week == source.Week);
            if (source.Scene == "profiles")
            {
                issue.Profiles = issue.Profiles.Where(p => p.Id == source.Id).ToList();
                if (issue.Profiles.Count != 1) throw new ArgumentException("选手介绍材料已失效，请重新选择。");
                var profile = issue.Profiles[0];
                var prior = snapshot.WeeklyEditions.Where(w => w.EndDay < issue.EndDay).OrderByDescending(w => w.EndDay)
                    .SelectMany(w => w.Profiles).FirstOrDefault(p => p.Id == profile.Id && p.Updated.Length > 0);
                if (prior != null) profile.Previous = prior.Updated;
            }
            else if (source.Scene == "weekly")
            {
                issue.Slides = issue.Slides.Where(s => s.Id == source.Id).ToList();
                if (issue.Slides.Count != 1) throw new ArgumentException("周刊材料已失效，请重新选择。");
                issue.Memory = CommunityMemorySearch.Retrieve(snapshot, issue.Slides[0].Topic, issue.Slides[0].People,
                    issue.StartDay - 1, new HashSet<string>(), 5);
            }
            else throw new ArgumentException("未知测试场景。");
            context = BuildWeeklyContext(issue, source.Scene == "profiles");
        }
        return new() { Source = source, Message = message, Snapshot = snapshot, Owner = data, Context = context, TargetId = target };
    }

    // confirmedExternalSend 仅在界面展示接收地址、材料并取得玩家确认后传入 true。
    public static async Task TestPromptAsync(CareerData owner, PromptTestSession test, IReadOnlyDictionary<string, string> drafts, bool confirmedExternalSend = false)
    {
        if (!confirmedExternalSend || test.Running) return;
        test.Running = true;
        CommunityThreads.SetWork(test.Work, "queued");
        string trace = Guid.NewGuid().ToString("N");
        try
        {
            if (!ReferenceEquals(test.Owner, owner) || !CareerStore.IsCurrent(owner)) throw new ArgumentException("生涯已切换，请重新选择材料。");
            var options = TestCopy(owner.Ai);
            foreach (var draft in drafts) PromptLibrary.Save(options, draft.Key, draft.Value);
            string? key = CurrentKey;
            if (!owner.Ai.Enabled) throw new ArgumentException("请先在 模组设置中开启 AI。");
            if (string.IsNullOrWhiteSpace(key)) throw new ArgumentException("请先在 模组设置中填写密钥。");
            if (!TryGetEndpoint(options.Endpoint, out var uri)) throw new ArgumentException("接口地址无效。");
            bool Current() => CareerStore.IsCurrent(owner) && owner.Ai.Enabled && CurrentKey == key
                && owner.Ai.Endpoint == options.Endpoint && owner.Ai.Model == options.Model;
            using var lease = await EnterQueueAsync(owner, ["prompt-preview"], [test.Work]);
            await WaitForRequestStartAsync(owner, [test.Work]);
            if (!Current()) throw new ArgumentException("设置或生涯已切换，请重新测试。");
            var data = TestCopy(test.Snapshot);
            var wire = new AiWireProtocol(data);
            string payload = JsonSerializer.Serialize(new { model = options.Model, stream = false,
                messages = new[] { new { role = "system", content = ComposeSystem(options, test.Source.Scene) },
                    new { role = "user", content = wire.Encode(test.Context) } } }, Json);
            int today = int.Parse(DateTime.UtcNow.ToString("yyyyMMdd"));
            if (owner.Ai.RequestDay != today) { owner.Ai.RequestDay = today; owner.Ai.RequestsToday = 0; }
            owner.Ai.RequestsToday++; CareerStore.Save(owner);
            CommunityThreads.SetWork(test.Work, "sending");
            using var request = new HttpRequestMessage(HttpMethod.Post, uri);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", key);
            request.Content = new StringContent(payload, Encoding.UTF8, "application/json");
            using var response = await SendAsync(request, owner, trace, "prompt-test-" + test.Source.Scene, [test.Source.Id]);
            if (!response.IsSuccessStatusCode) throw new ArgumentException(await HttpFailure(response));
            string content = wire.Decode(await ReadResponseCompletion(response), expectedArray: test.Source.Scene switch
                { "discussion" => "reactions", "weekly" => "slides", "profiles" => "profiles", _ => "posts" });
            if (!Current()) throw new ArgumentException("设置或生涯已切换，本次结果已放弃。");
            string preview = ApplyTestResponse(data, test, content);
            test.Previous = test.Result; test.Result = preview;
            CommunityThreads.SetWork(test.Work, "completed");
        }
        catch (Exception e)
        {
            Diagnostics.Error("ai.prompt-test:" + trace, e);
            CommunityThreads.SetWork(test.Work, "failed", e is ArgumentException ? e.Message : FailureReason(e));
        }
        finally { test.Running = false; }
    }

    private static string ApplyTestResponse(CareerData data, PromptTestSession test, string content)
    {
        if (test.Source.Scene is "news" or "discussion")
        {
            var post = CommunityThreads.All(data).Single(p => p.Id == test.Source.Id);
            var oldIds = post.Replies.Select(r => r.Id).ToHashSet();
            if (test.Source.Scene == "news") ApplyNewsResponse(data, [post], content);
            else ApplyDiscussionCore(data, new HashSet<string> { test.TargetId }, [post], content, ReadDiscussionPermissions(test.Context));
            var lines = new List<string> { post.Title, CareerEngine.DisplayName(data, post.AuthorId), post.Body };
            if (test.Source.Scene == "discussion") lines.Add("测试留言：" + test.Message);
            var replies = post.Replies.Where(r => !oldIds.Contains(r.Id)).ToList();
            for (int i = 0; i < replies.Count; i++)
            {
                var r = replies[i]; var parent = post.Replies.FirstOrDefault(p => p.Id == r.ParentId);
                lines.Add($"{i + 1}. {CareerEngine.DisplayName(data, r.AuthorId)}" + (parent == null ? "" : " → " + CareerEngine.DisplayName(data, parent.AuthorId)) + "\n" + r.Body);
            }
            return string.Join("\n\n", lines);
        }
        var issue = data.WeeklyEditions.Single(w => w.Week == test.Source.Week);
        bool profiles = test.Source.Scene == "profiles";
        ApplyWeeklyResponse(data, issue, profiles, content);
        return profiles ? string.Join("\n\n", issue.Profiles.Select(p => p.Name + "\n" + p.Updated))
            : string.Join("\n\n", issue.Slides.Select(s => s.Title + "\n" + s.Body));
    }
}
