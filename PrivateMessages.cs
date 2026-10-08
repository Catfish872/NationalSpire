using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace NationalSpire;

/// <summary>关系、记录与交互分别保存；网络回复结束前不执行任何交互。</summary>
public static class PrivateMessages
{
    public static object[] PublicMemory(CareerData data, CareerPerson person, IEnumerable<CommunityPost> posts, int day)
    {
        var humans = posts.SelectMany(p => p.RelatedPeople.Concat(p.Replies.Select(r => r.AuthorId)).Append(p.AuthorId))
            .Where(id => CommunityThreads.IsHuman(data, id)).Distinct().ToArray();
        var result = new List<object>();
        foreach (string human in humans)
        {
            var box = data.PrivateMemorySources.GetValueOrDefault(human)
                ?? (human == "player" || human == data.LocalHumanId ? Mailbox(data) : null);
            if (box == null) continue;
            box.Relations.TryGetValue(person.Id, out var relation);
            box.Conversations.TryGetValue(person.Id, out var conversation);
            if (relation == null && conversation == null) continue;
            string name = CareerEngine.DisplayName(data, human);
            var entry = new Dictionary<string, object?> { ["对象"] = name, ["对象Id"] = human,
                ["关系"] = relation?.Relationship ?? "初识", ["好感"] = relation?.Favour ?? 0, ["印象"] = relation?.Impression ?? "" };
            if (conversation != null)
            {
                PrivateInteractionIds.Ensure(conversation);
                var messages = conversation.Turns.Select((t, i) => (t, i)).Reverse().SelectMany(item =>
                {
                    var (t, i) = item;
                    var lines = new List<(int Index, int Season, int Day, string Speaker, string Text)>();
                    if (t.Status != "complete" || t.Day > day) return lines;
                    if (!t.ReplyDeleted) lines.Add((i, t.Season, t.Day, person.PublicName, t.Reply));
                    if (!t.UserDeleted) lines.Add((i, t.Season, t.Day, name, PrivateMessagePrompts.UserText(t, conversation)));
                    return lines;
                }).Take(10).Reverse().ToArray();
                bool Available(PrivateSummary s) => s.Through > 0 && s.Through <= conversation.Turns.Count && conversation.Turns[s.Through - 1].Day <= day;
                var big = conversation.BigSummaries.LastOrDefault(Available);
                var small = conversation.SmallSummaries.LastOrDefault(s => Available(s) && s.Through > (big?.Through ?? 0));
                // 首条消息可能截在一轮中间，此时保留摘要，避免丢失该轮的另一条消息。
                if (small != null && messages.Length > 0 && small.From > messages[0].Index) small = null;
                object? Summary(PrivateSummary? s)
                {
                    if (s == null) return null;
                    var start = conversation.Turns[Math.Clamp(s.From, 0, conversation.Turns.Count - 1)];
                    var end = conversation.Turns[s.Through - 1];
                    return new { 日期 = $"{PrivateAppointments.DateText(data, start.Day)}至{PrivateAppointments.DateText(data, end.Day)}", 内容 = s.Text };
                }
                entry["说明"] = $"以下是{person.PublicName}与{name}的私信摘要和最近记录。摘要由{person.PublicName}以第一人称记录，其中‘我’指{person.PublicName}，‘你’指{name}。";
                entry["长期摘要"] = Summary(big); entry["近期摘要"] = Summary(small);
                entry["最近记录"] = messages.Select(m => new { 日期 = PrivateAppointments.DateText(data, m.Day), 发言人 = m.Speaker, 内容 = m.Text }).ToArray();
            }
            result.Add(entry);
        }
        return result.ToArray();
    }
    public static PrivateMailbox Mailbox(CareerData data) => Mailbox(data.Life);
    public static PrivateMailbox Mailbox(CareerLifeState life)
    {
        var box = life.Mailbox;
        if (box.Version == 0)
        {
            foreach (var (id, value) in life.Relationships.ToArray())
            {
                box.Relations.TryAdd(id, new() { Favour = Math.Clamp(value * 3, -100, 100), Relationship = value > 0 ? "熟人" : "初识" });
                life.Relationships[id] = box.Relations[id].Favour;
            }
            box.Version = 1;
        }
        if (box.Version < 2)
        {
            foreach (var c in box.Conversations.Values) RemoveDeletedOffers(c);
            box.Version = 2;
        }
        return box;
    }
    public static void RemoveDeletedOffers(PrivateConversation c)
    {
        // 已确认事项已进入赛程或合同，删除文字不能替代取消赛事、解约等操作。
        int removed = c.Offers.RemoveAll(o => o.State is not ("已确认" or "已赴约") &&
            !c.Turns.Any(t => t.Id == o.TurnId && !t.UserDeleted && !t.ReplyDeleted));
        if (removed > 0) c.MemoryRevision++;
    }
    public static PrivateRelation Relation(CareerData data, string id)
    {
        var box = Mailbox(data);
        if (!box.Relations.TryGetValue(id, out var relation)) box.Relations[id] = relation = new();
        return relation;
    }
    public static int Favour(CareerData data, string id) => Mailbox(data).Relations.GetValueOrDefault(id)?.Favour ?? 0;
    public static void ChangeFavour(CareerData data, string id, int delta)
    {
        var relation = Relation(data, id); relation.Favour = Math.Clamp(relation.Favour + delta, -100, 100); relation.Revision++;
        data.Life.Relationships[id] = relation.Favour;
    }
    public static string RelationshipLabel(int favour) => favour switch
    { >= 80 => "十分亲近", >= 40 => "亲近", >= 15 => "熟悉", <= -80 => "敌视", <= -40 => "反感", <= -15 => "疏远", _ => "初识" };
    public static bool CanChat(CareerData data, string id) => id != "player" && !data.HumanIds.Contains(id) && data.People.Any(p => p.Id == id);
    public static PrivateConversation Conversation(CareerData data, string id)
    {
        if (!CanChat(data, id)) throw new ArgumentException("只能与 NPC 私信。");
        var box = Mailbox(data);
        if (!box.Conversations.TryGetValue(id, out var c)) box.Conversations[id] = c = new() { PersonId = id };
        return c;
    }
    public static PrivateTurn Enqueue(CareerData data, string id, string text, PrivateOffer? request = null, List<PrivateOffer>? attachments = null)
    {
        if ((string.IsNullOrWhiteSpace(text) && attachments?.Count is not > 0 && request == null) || text.Length > 8000) throw new ArgumentException("请填写消息或添加附件，正文最多 8000 字。");
        var c = Conversation(data, id);
        if (c.Turns.Any(t => t.Status is "queued" or "sending")) throw new InvalidOperationException("请等待当前回复，或先停止生成。");
        var turn = new PrivateTurn { User = text.Trim(), Day = data.Day, Season = data.Season, Request = request, RequestKind = request?.Kind ?? "", Attachments = attachments ?? [] };
        c.Turns.Add(turn); PrivateInteractionIds.Ensure(c); return turn;
    }
    public static int Completed(PrivateConversation c) => c.Turns.Skip(c.ContextStart).Count(t => t.Status == "complete" && !(t.UserDeleted && t.ReplyDeleted));

    public static string? PrepareAttachments(CareerData data, string person, List<PrivateOffer> attachments)
    {
        if (attachments.Count > 8) return "每条消息最多附加 8 项。";
        foreach (var a in attachments)
        {
            if (a.Kind == "match") { if (PrivateAppointments.Error(data, person, a) is { } error) return error; }
            else if (a.Kind == "training") { if (ClubCoaching.TrainingError(data, person, a) is { } error) return error; }
            else if (a.Kind == "lineup") { if (CoachLineups.Error(data, person, a) is { } error) return error; a.Detail = CoachLineups.Prepare(data, a); }
            else if (a.Kind == "contract") { if (!OwnedClubs.CanOperate(data)) return "请先组建并管理自己的俱乐部。"; }
            else if (a.Kind == "result")
            {
                var r = data.Results.FirstOrDefault(r => r.MatchId == a.MatchId); if (r == null) return "这份比赛记录已不存在。";
                a.Detail = $"第{r.Day}天 · {r.Event} · {r.Outcome} · 进阶{r.PlayedAscension ?? r.Ascension} · 第{r.Floor}层 · {MatchRules.Time(r.RunSeconds)}\n" + string.Join("、", r.Cards.Take(8));
            }
            else if (a.Kind == "post")
            {
                var p = CommunityThreads.All(data).FirstOrDefault(p => p.Id == a.MatchId); if (p == null) return "这篇帖子已不存在。";
                a.PostRevision = p.Revision;
                a.Detail = p.Title + "\n" + PrivatePublicContext.PostText(data, p, CareerEngine.Person(data, person)!);
            }
            else if (a.Kind != "advice") return "附件类型无效。";
            if (a.Kind == "advice" && a.Detail.Length > 8000) return "附加文字过长。";
        }
        return null;
    }
    public static string AttachmentTitle(PrivateOffer a) => a.Kind switch
    {
        "match" => $"{a.Mode} · 第{a.Season}赛季第{a.Day}天 · A{a.Ascension}",
        "lineup" => "阵容调整", "training" => $"训练计划 · {a.Weeks}周", "contract" => "商谈合同", "result" => "复盘比赛", "post" => "分享帖子", "advice" => "附加文字", _ => "附件"
    };
    public static string? Manage(CareerData data, PrivateConversation c, string kind, PrivateMessageCommand command)
    {
        if (c.Turns.Any(t => t.Status is "queued" or "sending")) return "请先等待回复完成，或停止生成。";
        if (kind == "dm-summary")
        {
            if (c.SummaryStatus.Length > 0) return "正在总结，请稍候。";
            if (command.Part == "big" ? c.SmallSummaries.Count == 0 : Completed(c) == 0) return "没有可以总结的记录。";
            c.SummaryRequest = command.Part == "big" ? "big" : "small"; return null;
        }
        if (command.Text.Length > 16000) return "内容最多 16000 字。";
        if (kind == "dm-clear")
        {
            foreach (var t in c.Turns) { t.User = t.Reply = t.Context = t.Reasoning = ""; t.UserDeleted = t.ReplyDeleted = true; t.Attachments.Clear(); t.Request = null; }
            c.ContextStart = c.Turns.Count; c.SeenCount = c.Turns.Count(t => t.Status == "complete");
        }
        else if (kind is "dm-summary-edit" or "dm-summary-delete")
        {
            var list = command.Part == "big" ? c.BigSummaries : c.SmallSummaries;
            var summary = list.FirstOrDefault(s => s.Id == command.Entry); if (summary == null) return "这条总结已不存在。";
            if (kind == "dm-summary-delete") list.Remove(summary);
            else { if (string.IsNullOrWhiteSpace(command.Text)) return "总结不能为空。"; summary.Text = command.Text.Trim(); }
        }
        else
        {
            var t = c.Turns.FirstOrDefault(t => t.Id == command.Entry); if (t == null) return "这条消息已不存在。";
            if (command.Part is not ("user" or "reply")) return "消息类型无效。";
            bool user = command.Part == "user", delete = kind == "dm-delete";
            if (!delete && string.IsNullOrWhiteSpace(command.Text)) return "消息不能为空。";
            if (user) { t.User = delete ? "" : command.Text.Trim(); t.UserDeleted = delete; if (delete) { t.Attachments.Clear(); t.Request = null; } }
            else { t.Reply = delete ? "" : command.Text.Trim(); t.ReplyDeleted = delete; t.Reasoning = ""; }
            t.Context = "";
        }
        RemoveDeletedOffers(c);
        c.MemoryRevision++; c.SummaryError = "";
        return null;
    }
    public static void FinishSmallSummary(PrivateConversation c, PrivateHistorySettings settings, int snapshotEnd, string text)
    {
        if (string.IsNullOrWhiteSpace(text)) throw new InvalidDataException("聊天总结返回了空内容。");
        c.SmallSummaries.Add(new() { Text = text.Trim(), From = c.ContextStart, Through = snapshotEnd });
        var complete = c.Turns.Select((t, i) => (t, i)).Where(x => x.t.Status == "complete" && !(x.t.UserDeleted && x.t.ReplyDeleted)).ToArray();
        // 当前一轮加此前 N 轮；尚未包含在本次总结内的记录始终保留。
        int recent = complete.Length > settings.RecentRounds ? complete[complete.Length - settings.RecentRounds - 1].i : 0;
        c.ContextStart = Math.Max(c.ContextStart, Math.Min(snapshotEnd, recent)); c.SummaryError = "";
    }
    public static void FinishBigSummary(PrivateConversation c, IReadOnlyCollection<string> ids, string text)
    {
        if (string.IsNullOrWhiteSpace(text)) throw new InvalidDataException("长期总结返回了空内容。");
        if (!ids.All(id => c.SmallSummaries.Any(s => s.Id == id))) return;
        c.BigSummaries.Add(new() { Text = text.Trim(), From = c.SmallSummaries.Where(s => ids.Contains(s.Id)).Min(s => s.From), Through = c.SmallSummaries.Where(s => ids.Contains(s.Id)).Max(s => s.Through) });
        c.SmallSummaries.RemoveAll(s => ids.Contains(s.Id)); c.SummaryError = "";
    }
    public static void Apply(CareerData data, PrivateConversation c, PrivateTurn turn, IReadOnlyList<Dictionary<string, string>> directives, int? originalFavour = null)
    {
        if (turn.Applied) return;
        PrivateInteractionIds.Ensure(c);
        var before = PrivateInteractionHistory.Capture(data, c.PersonId);
        foreach (var fields in directives)
        {
            if (fields.ContainsKey("Activity")) SocialAppointments.Respond(data, c, turn, fields);
            if (fields.ContainsKey("Training")) ClubCoaching.AcceptTraining(data, c, turn, fields);
            if (fields.ContainsKey("Lineup")) CoachLineups.Respond(data, c, turn, fields);
            else if (fields.TryGetValue("Post", out var publication) && publication == "发布")
            {
                string title = fields.GetValueOrDefault("Title", ""), body = fields.GetValueOrDefault("Body", "");
                if (turn.Status != "complete" || turn.ReplyDeleted || string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(body)) { turn.Error = "帖子缺少标题或正文，未发布。"; continue; }
                c.Offers.Add(new() { Kind = "publish", TurnId = turn.Id, Title = title, Detail = body });
            }
            else if (fields.TryGetValue("Profile", out var field))
            {
                var change = new PrivateProfileChange { Field = field, After = fields.GetValueOrDefault("Value", ""), Reason = fields.GetValueOrDefault("Reason", "") };
                var person = CareerEngine.Person(data, c.PersonId)!;
                if (turn.Status != "complete" || !PrivateProfileChanges.Apply(person, change)) { turn.Error = "档案变化字段或内容无效，未执行。"; continue; }
                turn.ProfileChanges.Add(change);
            }
            else if (fields.TryGetValue("Mood", out var moodValue) && turn.Mood == null)
            {
                string reason = fields.GetValueOrDefault("Reason", "").Trim();
                if (turn.Status != "complete") continue;
                int mood = int.TryParse(moodValue, out int parsedMood) && parsedMood is >= -3 and <= 3
                    ? parsedMood : (int)Math.Round(CareerTraining.MoodLevel(CareerEngine.Person(data, c.PersonId)!, data.Day));
                int days = int.TryParse(fields.GetValueOrDefault("Days"), out int parsedDays) && parsedDays is >= 7 and <= 21 ? parsedDays : 14;
                if (SpireArbitration.ShockDay(CareerEngine.Person(data, c.PersonId)!, data.Day) >= 0)
                { turn.Error += "\n仲裁处罚期间维持最低状态，本次普通状态更新未执行。"; continue; }
                var change = new PrivateMood { Id = turn.Id, Strength = mood, Day = data.Day, Days = days, Reason = reason,
                    Source = turn.Id };
                if (CareerTraining.RecordMood(data, c.PersonId, change)) turn.Mood = change;
            }
            else if (fields.TryGetValue("Skill", out var strength) && turn.Learning == null)
            {
                string reason = fields.GetValueOrDefault("Reason", "").Trim();
                string topic = fields.GetValueOrDefault("Topic", "").Trim();
                bool valid = int.TryParse(strength, out int amount) && amount != 0 && Math.Abs((long)amount) <= 3
                    && turn.Status == "complete" && !turn.ReplyDeleted && !string.IsNullOrWhiteSpace(turn.Reply);
                if (topic.Length == 0) topic = "综合";
                if (!valid) { turn.Error = "水平变化程度无效，请填写 -3 至 -1 或 1 至 3。"; continue; }
                string source = turn.Id;
                var lesson = new PrivateLearning { Id = turn.Id, Source = source, Topic = topic, Strength = amount, Reason = reason };
                if (CareerTraining.RecordLesson(data, c.PersonId, lesson)) turn.Learning = lesson;
            }
            else if (fields.ContainsKey("Favour") || fields.ContainsKey("Attitude") || fields.ContainsKey("Relationship"))
            {
                var relation = Relation(data, c.PersonId);
                if (fields.TryGetValue("Favour", out var proposed) && decimal.TryParse(proposed, NumberStyles.Float, CultureInfo.InvariantCulture, out var value))
                    ChangeFavour(data, c.PersonId, (int)Math.Clamp(decimal.Round(value, 0, MidpointRounding.AwayFromZero), -100, 100) - relation.Favour);
                if (fields.TryGetValue("Attitude", out var impression)) relation.Impression = impression.Trim();
                if (fields.TryGetValue("Relationship", out var label)) relation.Relationship = label.Trim();
                relation.Revision++;
            }
            else if (fields.TryGetValue("Match", out var action))
            {
                PrivateAppointments.Respond(data, c, turn, fields, action);
            }
            else if (fields.TryGetValue("Contract", out var contract) && contract == "要价" && OwnedClubs.CanOperate(data))
            {
                var offer = new PrivateOffer { Kind = "contract", TurnId = turn.Id, Signing = Money(fields, "Signing"), Wage = Money(fields, "Wage"), WinBonus = Money(fields, "WinBonus"), Weeks = Number(fields, "Weeks"), Role = fields.GetValueOrDefault("Role", "轮换") };
                if (PrivateContracts.Error(data, c.PersonId, offer) is { } error) { offer.State = "无效"; offer.Detail = error; }
                c.Offers.Add(offer);
            }
        }
        PrivateInteractionIds.Ensure(c);
        turn.Applied = true;
        PrivateInteractionHistory.Record(data, c.PersonId, turn, before);
    }
    private static decimal Money(Dictionary<string, string> fields, string key) => decimal.TryParse(fields.GetValueOrDefault(key), NumberStyles.Number, CultureInfo.InvariantCulture, out decimal n) ? n : 0;
    private static int Number(Dictionary<string, string> fields, string key) => int.TryParse(fields.GetValueOrDefault(key), NumberStyles.Integer, CultureInfo.InvariantCulture, out int n) ? n : -1;
}

/// <summary>括号可能跨越任意网络分片；普通括号原样显示，协议正文从不显示。</summary>
public sealed class PrivateStreamParser
{
    private readonly StringBuilder _visible = new(), _pending = new();
    private int _depth;
    public string Text => _visible.ToString();
    public List<Dictionary<string, string>> Directives { get; } = [];
    public string Error { get; private set; } = "";
    private static bool Known(string text) => Regex.IsMatch(text, @"^\[\s*(Favour|Attitude|Relationship|Match|Contract|Skill|Mood|Post|Profile|Activity|Training|Lineup)\s*[:：]", RegexOptions.IgnoreCase);
    public void Feed(string text)
    {
        foreach (char ch in text)
        {
            if (_pending.Length == 0) { if (ch == '[') { _pending.Append(ch); _depth = 1; } else _visible.Append(ch); continue; }
            _pending.Append(ch);
            if (ch == '[') _depth++;
            if (ch != ']' || --_depth != 0) continue;
            string block = _pending.ToString(); _pending.Clear();
            if (!Known(block)) { _visible.Append(block); continue; }
            var fields = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            // 印象中可以含有逗号，仅在下一个字段开始时分隔。
            foreach (var segment in Segments(block[1..^1]))
            {
                int colon = segment.IndexOfAny(new[] { ':', '：' });
                if (colon <= 0 || !fields.TryAdd(segment[..colon].Trim(), segment[(colon + 1)..].Trim())) { fields.Clear(); break; }
            }
            string[] allowed = fields.ContainsKey("Lineup") ? ["Lineup", "Id"] : fields.ContainsKey("Training") ? ["Training", "Id"] : fields.ContainsKey("Activity") ? ["Activity", "Id", "Title", "Detail", "Season", "Day"]
                : fields.ContainsKey("Post") ? ["Post", "Title", "Body"]
                : fields.ContainsKey("Profile") ? ["Profile", "Value", "Reason"]
                : fields.ContainsKey("Favour") || fields.ContainsKey("Attitude") || fields.ContainsKey("Relationship") ? ["Favour", "Attitude", "Relationship"]
                : fields.ContainsKey("Skill") ? ["Skill", "Topic", "Evidence", "Reason"]
                : fields.ContainsKey("Mood") ? ["Mood", "Days", "Evidence", "Reason"]
                : fields.ContainsKey("Match") ? ["Match", "Season", "Day", "Ascension", "Mode"]
                : fields.ContainsKey("Contract") ? ["Contract", "Signing", "Wage", "WinBonus", "Weeks", "Role"] : [];
            if (fields.Count > 0 && fields.Keys.All(k => allowed.Contains(k, StringComparer.OrdinalIgnoreCase))) Directives.Add(fields);
            else Error = "交互格式不完整，未执行。";
        }
    }
    public void Finish()
    {
        if (_pending.Length == 0) return;
        if (Known(_pending.ToString())) Error = "交互标记没有结束，未执行。";
        else _visible.Append(_pending);
        _pending.Clear();
        _depth = 0;
    }
    private static IEnumerable<string> Segments(string text)
    {
        int depth = 0, start = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '[') depth++;
            else if (text[i] == ']') depth--;
            else if (depth == 0 && text[i] is ',' or '，' && Regex.IsMatch(text[(i + 1)..], @"^\s*[A-Za-z]+\s*[:：]"))
            { yield return text[start..i]; start = i + 1; }
        }
        yield return text[start..];
    }
}
