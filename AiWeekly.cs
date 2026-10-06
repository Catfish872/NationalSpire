using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace NationalSpire;

public static partial class AiService
{
    private static readonly HashSet<(CareerData Data, int Week)> ScheduledEditions = [];
    public static async Task ProcessWeeklyAsync(CareerData? requestedData = null)
    {
        var data = requestedData ?? CareerStore.Data;
        if (!data.Ai.Enabled) return;
        if (WeeklyJournal.ActivateLatest(data)) CareerStore.Save(data);
        PublicationBacklog.Compact(data, false);
        foreach (var issue in data.WeeklyEditions.OrderByDescending(w => w.Week).Take(1).ToList())
        {
            if (!CareerStore.IsCurrent(data) || !data.Ai.Enabled) return;
            lock (ScheduledEditions) if (!ScheduledEditions.Add((data, issue.Week))) continue;
            try
            {
                if (issue.ProfilesWork.State == "idle") await GenerateWeekly(data, issue, true, false);
                if (issue.NewsWork.State == "idle") await GenerateWeekly(data, issue, false, false);
            }
            finally { lock (ScheduledEditions) ScheduledEditions.Remove((data, issue.Week)); }
        }
    }
    public static Task RetryWeeklyAsync(int week, bool profiles, CareerData? requestedData = null)
    {
        var data = requestedData ?? CareerStore.Data;
        var issue = data.WeeklyEditions.FirstOrDefault(w => w.Week == week);
        return issue == null ? Task.CompletedTask : GenerateWeekly(data, issue, profiles, true);
    }
    private static async Task GenerateWeekly(CareerData data, WeeklyEdition issue, bool profiles, bool retry)
    {
        var work = profiles ? issue.ProfilesWork : issue.NewsWork;
        if (!data.Ai.Enabled || !PublicationBacklog.Latest(data, issue) || work.State != (retry ? "failed" : "idle")) return;
        // 入队前同步标记，重复进入界面不会再调度同一项。
        CommunityThreads.SetWork(work, "queued"); CareerStore.Save(data);
        string trace = Guid.NewGuid().ToString("N");
        string failure = "配置或生涯已切换，请重新提交";
        void Fail(string message) { failure = message; Status = "周刊生成失败：" + message; CommunityThreads.SetWork(work, "failed", message); }
        // 初次编写仍先更新介绍再撰写周刊；独立重试只锁定自身任务。
        using var lease = await EnterQueueAsync(data, [$"edition:{issue.Week}:" + (profiles ? "profiles" : "news")], [work]);
        try
        {
            if (!data.Ai.Enabled || !CareerStore.IsCurrent(data) || work.State == "superseded" || !PublicationBacklog.Latest(data, issue)) return;
            if (profiles ? issue.Profiles.Count == 0 : !CameoContent.GeneratedSlides(issue).Any()) { CommunityThreads.SetWork(work, "completed"); return; }
            string? key = CurrentKey; string endpoint = data.Ai.Endpoint, model = data.Ai.Model;
            if (string.IsNullOrWhiteSpace(key)) { Fail("未设置密钥"); return; }
            if (!TryGetEndpoint(endpoint, out var uri)) { Fail("接口地址无效"); return; }
            await WaitForRequestStartAsync(data, [work]);
            bool Current() => data.Ai.Enabled && CareerStore.IsCurrent(data) && key == CurrentKey && endpoint == data.Ai.Endpoint && model == data.Ai.Model
                && work.State != "superseded" && PublicationBacklog.Latest(data, issue);
            if (!Current()) return;
            // 引用此前实际发布的介绍，跳过的期数通过累计履历衔接。
            if (profiles) foreach (var profile in issue.Profiles)
            {
                var prior = data.WeeklyEditions.Where(w => w.EndDay < issue.EndDay)
                    .OrderByDescending(w => w.EndDay).SelectMany(w => w.Profiles).FirstOrDefault(p => p.Id == profile.Id && p.Updated.Length > 0);
                if (prior != null) profile.Previous = prior.Updated;
            }
            var wire = new AiWireProtocol(data);
            if (!profiles)
                issue.Memory = CommunityMemorySearch.Retrieve(data, string.Join(" ", CameoContent.GeneratedSlides(issue).Select(s => s.Topic)),
                    CameoContent.GeneratedSlides(issue).SelectMany(s => s.People).Distinct(), issue.StartDay - 1, new HashSet<string>(), 5);
            string context = BuildWeeklyContext(issue, profiles);
            string payload = JsonSerializer.Serialize(new { model, stream = false,
                messages = new[] { new { role = "system", content = ComposeSystem(data.Ai, profiles ? "profiles" : "weekly") }, new { role = "user", content = wire.Encode(context) } } }, Json);
            CommunityThreads.SetWork(work, "sending");
            int today = int.Parse(DateTime.UtcNow.ToString("yyyyMMdd"));
            if (data.Ai.RequestDay != today) { data.Ai.RequestDay = today; data.Ai.RequestsToday = 0; }
            data.Ai.RequestsToday++; CareerStore.Save(data);
            Status = $"第 {issue.Week} 周：" + (profiles ? "正在更新选手介绍" : "正在编写周刊");
            using var request = new HttpRequestMessage(HttpMethod.Post, uri);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", key);
            request.Content = new StringContent(payload, Encoding.UTF8, "application/json");
            using var response = await SendAsync(request, data, trace, profiles ? "profiles" : "weekly", [issue.Week.ToString()]);
            if (!response.IsSuccessStatusCode) { Fail(await HttpFailure(response)); return; }
            string content = wire.Decode(await ReadResponseCompletion(response), expectedArray: profiles ? "profiles" : "slides");
            if (!Current()) return;
            ApplyWeeklyResponse(data, issue, profiles, content);
            Diagnostics.Record("ai.applied", new { trace, kind = profiles ? "profiles" : "weekly", issue.Week });
            CommunityThreads.SetWork(work, "completed"); issue.Revision++;
            Status = $"第 {issue.Week} 周" + (profiles ? "选手介绍已更新" : "周刊已发布");
        }
        catch (Exception e) { Diagnostics.Error("ai.weekly:" + trace, e); Fail(FailureReason(e)); }
        finally
        {
            if (!PublicationBacklog.Latest(data, issue)) CommunityThreads.SetWork(work, "superseded");
            else if (work.State is not ("completed" or "superseded")) CommunityThreads.SetWork(work, "failed", failure);
            CareerStore.Save(data);
        }
    }
    internal static string BuildWeeklyContext(WeeklyEdition issue, bool profiles)
    {
        if (profiles) return JsonSerializer.Serialize(new { week = issue.Week, fromDay = issue.StartDay, asOfDay = issue.EndDay,
            profiles = issue.Profiles.Select(p => new { p.Id, p.Name, p.Gender, p.Background, History = GameText.Plain(p.History), ThisWeek = GameText.Plain(p.ThisWeek), p.Previous }) }, Json);
        var selected = CameoContent.GeneratedSlides(issue).SelectMany(s => s.People).ToHashSet();
        return JsonSerializer.Serialize(new { week = issue.Week, fromDay = issue.StartDay, asOfDay = issue.EndDay,
            cooperation = issue.Cooperation,
            slides = CameoContent.GeneratedSlides(issue).Select(s => new { s.Id, s.Topic, Facts = GameText.Plain(s.Facts), advertisement = s.Advertisement }),
            profiles = issue.Profiles.Where(p => selected.Contains(p.Id)).Select(p => new { p.Name, p.Gender, p.Background, introduction = p.Updated.Length > 0 ? p.Updated : p.Previous }),
            memory = issue.Memory, schedule = PublicSchedule.ForPrompt(issue.Schedule) }, Json);
    }
    internal static void ApplyWeeklyResponse(CareerData data, WeeklyEdition issue, bool profiles, string content)
    {
        using var document = JsonDocument.Parse(content);
        var rows = document.RootElement.GetProperty(profiles ? "profiles" : "slides").EnumerateArray().ToList();
        var expected = profiles ? issue.Profiles.Select(p => p.Id).ToHashSet() : CameoContent.GeneratedSlides(issue).Select(s => s.Id).ToHashSet();
        var staged = new List<(string Id, string Title, string Body)>();
        foreach (var row in rows)
        {
            string id = row.GetProperty("id").GetString() ?? "";
            string body = row.GetProperty("body").GetString() ?? "";
            string title = profiles ? "" : row.GetProperty("title").GetString() ?? "";
            if (!expected.Remove(id) || string.IsNullOrWhiteSpace(body) || !profiles && string.IsNullOrWhiteSpace(title))
                throw new InvalidDataException("周刊编号或正文不符合请求");
            staged.Add((id, title, body));
        }
        if (expected.Count > 0) throw new InvalidDataException("周刊批次不完整");
        foreach (var row in staged)
        {
            if (profiles)
            {
                issue.Profiles.Single(p => p.Id == row.Id).Updated = row.Body;
                if (row.Id == "player" && data.PlayerIntroductionDay <= issue.EndDay)
                { data.PlayerIntroduction = row.Body; data.PlayerIntroductionDay = issue.EndDay; }
                else if (CareerEngine.Person(data, row.Id) is { } person && person.IntroductionDay <= issue.EndDay)
                { person.AiIntroduction = row.Body; person.IntroductionDay = issue.EndDay; }
            }
            else
            {
                var slide = issue.Slides.Single(s => s.Id == row.Id); slide.Title = row.Title; slide.Body = row.Body;
                foreach (var e in data.Life.Events.Where(e => slide.EventIds.Contains(e.Id))) e.EditionWeek = issue.Week;
                if (slide.Advertisement) continue;
                string memoryId = $"weekly:{issue.Week}:{slide.Id}";
                data.CommunityMemories.RemoveAll(m => m.Id == memoryId);
                data.CommunityMemories.Add(new() { Id = memoryId, PostId = memoryId, Day = issue.EndDay, Kind = "opinion", People = slide.People,
                    Text = $"第{issue.Week}周周刊编辑评论《{slide.Title}》：{slide.Body}" });
            }
        }
    }
}
