namespace NationalSpire;

public static partial class AiService
{
    private static readonly Dictionary<string, CancellationTokenSource> EventRequests = [];
    public static readonly Dictionary<string, EventLive> EventLive = [];
    public static string EventKey(CareerData d, string id) => d.WorldId + "/event/" + id;
    public static bool EventBusy(CareerData d, string id) => EventRequests.ContainsKey(EventKey(d, id));
    public static void CancelEvent(CareerData d, string id) { if (EventRequests.TryGetValue(EventKey(d, id), out var cancel)) cancel.Cancel(); }
    public static async Task ProcessEventAsync(Func<CareerData?> current, Action<CareerData> save, string id, Action<EventLive>? progress = null)
    {
        var d = current(); if (d == null || RandomEvents.Find(d, id) is not { } e || e.State != "generating" && e.CustomState != "generating") return;
        bool custom = e.CustomState == "generating";
        string key = EventKey(d, id); if (EventRequests.ContainsKey(key)) return;
        using var cancel = new CancellationTokenSource(TimeSpan.FromMinutes(Math.Clamp(d.Ai.RequestTimeoutMinutes, 2, 30)));
        EventRequests[key] = cancel;
        EventLive.Remove(key);
        var thoughts = new System.Text.StringBuilder();
        try
        {
            var parser = new RandomEventParser(custom ? e.CustomAction : null); long last = 0;
            string phase = "排队中";
            void Update(bool force = false)
            {
                if (!force && Environment.TickCount64 - last < 100) return;
                last = Environment.TickCount64;
                var live = new EventLive(parser.Title, parser.LiveStory, parser.Options.Count)
                { Choices = parser.Options.ToList(), Reasoning = thoughts.ToString(), Phase = phase };
                EventLive[key] = live;
                try { progress?.Invoke(live); } catch (Exception error) { Diagnostics.Error("event.progress", error); }
            }
            Update(true);
            PrivateForegroundQueue.Configure(d.Ai.MaxConcurrentRequests);
            using var lease = await EnterPrivateQueue(d, key, cancel.Token);
            phase = "等待响应"; Update(true);
            await RequestPrivateAsync(d.Ai, RandomEventPrompts.Compose(d, e, d.Ai, custom), true, chunk =>
            {
                parser.Feed(chunk); phase = "正在书写"; Update();
            }, cancel.Token, reasoning: chunk => { thoughts.Append(chunk); phase = "正在思考"; Update(); }, context: key, task: "event");
            parser.Finish(); cancel.Token.ThrowIfCancellationRequested();
            d = current(); if (d == null || EventKey(d, id) != key || RandomEvents.Find(d, id) is not { } latest || (custom ? latest.CustomState : latest.State) != "generating") return;
            parser.Validate();
            if (custom)
            {
                latest.CustomOption = parser.Options.Single(); latest.CustomReasoning = thoughts.ToString(); latest.CustomState = "ready"; latest.Error = ""; save(d); return;
            }
            latest.Title = parser.Title; latest.Story = parser.Story; latest.Options = parser.Options; latest.Reasoning = thoughts.ToString(); latest.State = "ready"; latest.Error = ""; save(d);
        }
        catch (Exception error)
        {
            d = current();
            if (d != null && EventKey(d, id) == key && RandomEvents.Find(d, id) is { } latest && (custom ? latest.CustomState : latest.State) == "generating")
            { if (custom) { latest.CustomState = latest.CustomOption == null ? "idle" : "ready"; latest.CustomReasoning = thoughts.ToString(); } else { latest.State = latest.Options.Count > 0 ? "ready" : "failed"; if (latest.Options.Count == 0) latest.Reasoning = thoughts.ToString(); } latest.Error = error is OperationCanceledException ? "生成已停止，可以重试或跳过。" : FailureReason(error); save(d); }
            Diagnostics.Record("event.failed", new { id, error = FailureReason(error) });
        }
        finally { EventRequests.Remove(key); EventLive.Remove(key); }
    }
}
