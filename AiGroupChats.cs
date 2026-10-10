using System.Text;
using System.Text.Json;

namespace NationalSpire;

public static partial class AiService
{
    private static readonly Dictionary<string, CancellationTokenSource> GroupRequests = [];
    private static readonly HashSet<string> GroupSummaries = [];
    public static readonly Dictionary<string, string> GroupLive = [];
    public static readonly Dictionary<string, (string Turn, string Text)> GroupReasoningLive = [];
    public static string GroupKey(CareerData d, string group) => (d.AvatarWorldId.Length > 0 ? d.AvatarWorldId : d.WorldId) + "/group/" + group;
    public static void CancelGroup(CareerData d, string group)
    { if (GroupRequests.TryGetValue(GroupKey(d, group), out var request)) request.Cancel(); }
    public static async Task ProcessGroupAsync(Func<CareerData?> current, Action<CareerData> save, string group, Action<string>? progress = null)
    {
        var d = current(); var g = d?.Chats.Groups.FirstOrDefault(g => g.Id == group);
        var turn = g?.Turns.FirstOrDefault(t => t.Status == "queued");
        if (d == null || g == null) return;
        if (turn == null) { await SummarizeGroupAsync(current, save, group); return; }
        string key = GroupKey(d, group), id = turn.Id;
        if (GroupRequests.ContainsKey(key)) return;
        using var cancel = new CancellationTokenSource(TimeSpan.FromMinutes(Math.Clamp(d.Ai.RequestTimeoutMinutes, 2, 30)));
        GroupRequests[key] = cancel;
        var raw = new StringBuilder(); var reasoning = new StringBuilder(); var parser = new GroupStreamParser();
        DateTime sent = DateTime.MinValue;
        void Reasoning(string chunk)
        {
            reasoning.Append(chunk); GroupReasoningLive[key] = (id, reasoning.ToString());
            if ((DateTime.UtcNow - sent).TotalMilliseconds >= 100) { sent = DateTime.UtcNow; Notify(); }
        }
        void Notify()
        {
            try { progress?.Invoke(raw.ToString()); }
            catch (Exception e) { Diagnostics.Record("group.delivery.failed", new { group, turn = id, error = FailureReason(e) }); }
        }
        try
        {
            if (!d.Ai.Enabled) throw new InvalidOperationException("请先启用 AI。");
            PrivateForegroundQueue.Configure(d.Ai.MaxConcurrentRequests);
            using var lease = await EnterPrivateQueue(d, key, cancel.Token);
            d = current(); g = d?.Chats.Groups.FirstOrDefault(x => x.Id == group); turn = g?.Turns.FirstOrDefault(x => x.Id == id);
            if (d == null || g == null || turn?.Status != "queued") return;
            turn.Status = "sending"; save(d);
            if (turn.ArbitrationTargets.Count > 0)
            {
                string verdict = await RequestPrivateAsync(d.Ai, GroupArbitration.Compose(d, g, turn), false, null, cancel.Token, Reasoning, context: "group/" + group + "/" + id);
                d = current(); g = d?.Chats.Groups.FirstOrDefault(x => x.Id == group); turn = g?.Turns.FirstOrDefault(x => x.Id == id);
                if (d == null || g == null || turn == null) return;
                cancel.Token.ThrowIfCancellationRequested(); GroupArbitration.Apply(d, g, turn, verdict);
                turn.Status = "complete"; turn.Reasoning = reasoning.ToString(); g.Revision++; save(d); return;
            }
            var messages = GroupChatPrompts.Compose(d, g, turn);
            await RequestPrivateAsync(d.Ai, messages, true, chunk =>
            {
                raw.Append(chunk); parser.Feed(chunk); GroupLive[key] = raw.ToString();
                if (parser.Messages.Count > turn.SpeechOrders.Count)
                {
                    var latest = current(); var active = latest?.Chats.Groups.FirstOrDefault(x => x.Id == group)?.Turns.FirstOrDefault(x => x.Id == id);
                    if (latest != null && active != null)
                    {
                        while (active.SpeechOrders.Count < parser.Messages.Count) active.SpeechOrders.Add(GroupChats.NextOrder(latest));
                        turn.SpeechOrders = active.SpeechOrders.ToList(); save(latest);
                    }
                }
                if ((DateTime.UtcNow - sent).TotalMilliseconds >= 100) { sent = DateTime.UtcNow; Notify(); }
            }, cancel.Token, Reasoning, context: "group/" + group + "/" + id);
            cancel.Token.ThrowIfCancellationRequested(); parser.Finish();
            Diagnostics.Record("group.parsed", new { group, turn = id, speakers = parser.Messages.Select(s => s.Author).ToArray(), interactions = parser.Actions.Directives, error = parser.Error });
            d = current(); g = d?.Chats.Groups.FirstOrDefault(x => x.Id == group); turn = g?.Turns.FirstOrDefault(x => x.Id == id);
            if (d == null || g == null || turn?.Status != "sending") return;
            turn.Raw = raw.ToString(); turn.Reasoning = reasoning.ToString(); turn.Error = parser.Error;
            int speechIndex = -1;
            foreach (var speech in parser.Messages)
            {
                speechIndex++;
                string author = g.Resolve(speech.Author); string text = speech.Body.ToString().Trim();
                if (text.Length == 0) continue;
                string unavailable = GroupChats.SpeechUnavailable(d, g, author);
                if (unavailable.Length > 0) { turn.Notices.Add("一条发言未发送：" + unavailable); continue; }
                turn.Replies.Add(new() { Author = author, Text = text, Day = turn.Day, Order = speechIndex < turn.SpeechOrders.Count ? turn.SpeechOrders[speechIndex] : GroupChats.NextOrder(d), TurnId = turn.Id });
            }
            if (turn.Replies.Count == 0 && parser.Actions.Directives.Count == 0) throw new InvalidDataException("没有返回可识别的群聊消息，请重试。");
            GroupInteractions.Apply(d, g, turn, parser.Actions.Directives);
            turn.Status = "complete";
            g.Revision++; save(d); Notify();
            _ = SummarizeGroupAsync(current, save, group);
        }
        catch (Exception e)
        {
            d = current(); g = d?.Chats.Groups.FirstOrDefault(x => x.Id == group); turn = g?.Turns.FirstOrDefault(x => x.Id == id);
            if (d != null && g != null && turn != null && turn.Status != "complete")
            { turn.Status = "failed"; turn.Raw = raw.ToString(); turn.Reasoning = reasoning.ToString(); turn.Error = e is OperationCanceledException ? "回复中断，交互未执行，可以重试。" : FailureReason(e); g.Revision++; save(d); }
            Diagnostics.Record("group.failed", new { group, turn = id, error = FailureReason(e) });
        }
        finally { GroupRequests.Remove(key); GroupLive.Remove(key); GroupReasoningLive.Remove(key); }
    }
    public static async Task SummarizeGroupAsync(Func<CareerData?> current, Action<CareerData> save, string group, string manual = "")
    {
        var d = current(); var g = d?.Chats.Groups.FirstOrDefault(g => g.Id == group);
        if (d == null || g == null) return;
        string key = GroupKey(d, group); if (!GroupSummaries.Add(key)) return;
        long revision = g.Revision;
        try
        {
            int end = g.Turns.FindLastIndex(t => t.Status == "complete") + 1;
            int from = g.SummarizedThrough;
            if (manual == "small" || manual != "big" && g.Turns.Skip(from).Count(t => t.Status == "complete") >= g.Settings.SummaryEvery)
            {
                g.SummaryStatus = "正在整理聊天记忆"; save(d);
                var own = g.Turns.Skip(from).Take(end - from).Where(t => t.Status == "complete").Select(t => new
                {
                    日期 = PrivateAppointments.DateText(d, t.Day), 玩家 = GroupChats.Name(d, t.Sender), 消息 = GroupChatPrompts.UserText(d, g, t),
                    发言 = t.Replies.Select(r => new { 姓名 = GroupChats.Name(d, r.Author), 内容 = r.Text }),
                    变化 = t.Effects.Where(e => e.Text.Length > 0).Select(e => GroupChats.Name(d, e.Person) + "：" + e.Text).Concat(t.Notices),
                    交互 = t.Effects.Select(e => GroupChatPrompts.InteractionContext(d, g, 0, turnId: e.Turn)).Where(text => text.Length > 0)
                });
                long first = from == 0 ? 0 : g.Turns.Skip(from).Take(end - from).Select(t => t.Order).DefaultIfEmpty(0).Min();
                long last = g.Turns.Take(end).SelectMany(t => t.Replies.Select(r => r.Order).Append(t.Order)).DefaultIfEmpty(0).Max();
                string source = JsonSerializer.Serialize(new { 群聊 = g.Name, 聊天 = own, 成员变化 = g.Entries.Where(e => e.Order >= first && e.Order <= last).Select(e => new { 日期 = PrivateAppointments.DateText(d, e.Day), e.Text }) }, Json);
                string text = await SummaryRequest(d.Ai, [new() { ["role"] = "system", ["content"] = GroupChatPrompts.Section(d, "group-summary") }, new() { ["role"] = "user", ["content"] = source }]);
                d = current(); g = d?.Chats.Groups.FirstOrDefault(g => g.Id == group);
                if (d == null || g == null || g.Revision != revision) return;
                if (string.IsNullOrWhiteSpace(text)) throw new InvalidDataException("群聊总结为空。");
                g.SmallSummaries.Add(new() { From = from, Through = end, Text = text }); g.SummarizedThrough = end; g.SummaryError = ""; save(d);
            }
            if (manual == "big" || g.SmallSummaries.Count >= g.Settings.SmallSummaryLimit)
            {
                var selected = g.SmallSummaries.Take(g.Settings.MergeOldest).ToArray(); if (selected.Length == 0) return;
                g.SummaryStatus = "正在合并长期记忆"; save(d);
                string text = await SummaryRequest(d.Ai, [new() { ["role"] = "system", ["content"] = GroupChatPrompts.Section(d, "group-long-summary") }, new() { ["role"] = "user", ["content"] = string.Join("\n\n", selected.Select(s => s.Text)) }]);
                d = current(); g = d?.Chats.Groups.FirstOrDefault(g => g.Id == group);
                if (d == null || g == null || g.Revision != revision) return;
                if (string.IsNullOrWhiteSpace(text)) throw new InvalidDataException("群聊长期总结为空。");
                var ids = selected.Select(s => s.Id).ToHashSet(); g.SmallSummaries.RemoveAll(s => ids.Contains(s.Id));
                g.BigSummaries.Add(new() { From = selected.Min(s => s.From), Through = selected.Max(s => s.Through), Text = text }); save(d);
            }
        }
        catch (Exception e) { d = current(); g = d?.Chats.Groups.FirstOrDefault(x => x.Id == group); if (d != null && g != null) { g.SummaryError = "总结未完成，下次回复后重试：" + FailureReason(e); save(d); } }
        finally { GroupSummaries.Remove(key); d = current(); g = d?.Chats.Groups.FirstOrDefault(x => x.Id == group); if (d != null && g != null) { g.SummaryStatus = ""; save(d); } }
    }
}
