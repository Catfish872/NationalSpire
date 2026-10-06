using System.Text.Json;
using System.Text.Json.Nodes;

namespace NationalSpire;

/// <summary>仅保存一条回复实际改变的字段，重新生成时逆序撤回，保留期间发生的其他变化。</summary>
public sealed class PrivateInteractionUndo
{
    public JsonObject Before { get; set; } = new();
    public JsonObject After { get; set; } = new();
    public bool Contract { get; set; }
}

public static class PrivateInteractionHistory
{
    private static JsonNode? Node<T>(T value) => JsonSerializer.SerializeToNode(value);
    public static JsonObject Capture(CareerData d, string id, bool contract = false)
    {
        var p = CareerEngine.Person(d, id)!;
        var learning = Node(p.Learning)!.AsObject();
        foreach (string key in new[] { "MoodDay", "MoodUntil", "MoodStrength" }) learning.Remove(key);
        var snapshot = new JsonObject
        {
            ["profile"] = Node(PrivateProfileChanges.Fields.ToDictionary(f => f, f => PrivateProfileChanges.Value(p, f))),
            ["receipts"] = Node(p.PrivateProfileReceipts), ["learning"] = learning,
            ["mood"] = Node(new { p.Learning.MoodDay, p.Learning.MoodUntil, p.Learning.MoodStrength }),
            ["relation"] = Node(PrivateMessages.Relation(d, id)),
            ["offers"] = Node(PrivateMessages.Conversation(d, id).Offers),
            ["privateMatches"] = Node(d.Matches.Where(m => PrivateAppointments.IsPrivate(m) && m.OpponentId == id).ToList())
        };
        if (!contract) return snapshot;
        snapshot["club"] = p.ClubId; snapshot["role"] = p.Role;
        snapshot["position"] = p.ClubPosition;
        snapshot["rosterRoles"] = Node(d.People.Where(x => x.ClubId == d.Esports.ClubId).ToDictionary(x => x.Id, x => new { x.Role, x.ClubPosition }));
        snapshot["credits"] = CareerMoney.Balance(d); snapshot["owned"] = Node(d.Esports.OwnedClub);
        snapshot["clubBudgets"] = Node(d.Esports.Clubs.ToDictionary(c => c.Id, c => c.Budget));
        snapshot["matches"] = Node(d.Matches); snapshot["competitions"] = Node(d.Esports.Competitions);
        snapshot["events"] = Node(d.Life.Events); snapshot["ledger"] = Node(d.Life.Ledger);
        snapshot["memories"] = Node(d.CommunityMemories);
        return snapshot;
    }

    public static void Record(CareerData d, string id, PrivateTurn turn, JsonObject before, bool contract = false)
    {
        if (contract && d.LocalHumanId.Length > 0)
        {
            var oldIds = before["events"]!.AsArray().Select(e => e!["Id"]!.GetValue<string>()).ToHashSet();
            foreach (var e in d.Life.Events.Where(e => !oldIds.Contains(e.Id) && !e.Id.StartsWith(d.LocalHumanId + "/"))) e.Id = d.LocalHumanId + "/" + e.Id;
        }
        var after = Capture(d, id, contract);
        var change = Difference(before, after);
        if (change is { } pair) turn.InteractionUndo.Add(new() { Before = (JsonObject)pair.Before!, After = (JsonObject)pair.After!, Contract = contract });
    }

    // 对象按字段、数组按稳定身份保存差异；不在每一轮复制完整人物或世界存档。
    private static string Identity(JsonNode? n) => n is JsonObject o
        ? o["Id"]?.ToJsonString() ?? o["PersonId"]?.ToJsonString() ?? n.ToJsonString() : n?.ToJsonString() ?? "null";
    private static (JsonNode? Before, JsonNode? After)? Difference(JsonNode? before, JsonNode? after, string path = "")
    {
        if (JsonNode.DeepEquals(before, after)) return null;
        if (path == "/mood") return (before?.DeepClone(), after?.DeepClone());
        if (before is JsonObject a && after is JsonObject b)
        {
            var left = new JsonObject(); var right = new JsonObject();
            foreach (string key in a.Select(p => p.Key).Union(b.Select(p => p.Key)))
                if (Difference(a[key], b[key], path + "/" + key) is { } pair)
                { left[key] = pair.Before; right[key] = pair.After; }
            return (left, right);
        }
        if (before is JsonArray x && after is JsonArray y)
        {
            // 保留变化项的完整内容，数组元素的其他字段用于和后续编辑比较。
            var left = new JsonArray(); var right = new JsonArray();
            foreach (var item in x.Where(n => !y.Any(m => JsonNode.DeepEquals(n, m)))) left.Add(item?.DeepClone());
            foreach (var item in y.Where(n => !x.Any(m => JsonNode.DeepEquals(n, m)))) right.Add(item?.DeepClone());
            // 执行凭据是集合，其余列表记录原顺序，撤回首发交换时不能改变阵容位置。
            var order = path is "/receipts" or "/learning/Receipts" or "/learning/Sources" ? null : Node(x.Select(Identity).ToArray());
            return (new JsonObject { ["$items"] = left, ["$order"] = order }, new JsonObject { ["$items"] = right });
        }
        return (before?.DeepClone(), after?.DeepClone());
    }

    private static JsonNode? Revert(JsonNode? current, JsonNode? before, JsonNode? after, string path = "")
    {
        // 状态等级与起止日期属于同一项效果；后续独立状态不能只回退其中一个字段。
        if (path == "/mood") return (JsonNode.DeepEquals(current, after) ? before : current)?.DeepClone();
        if (before is JsonObject listBefore && after is JsonObject listAfter && current is JsonArray list
            && listBefore["$items"] is JsonArray oldItems && listAfter["$items"] is JsonArray newItems)
        {
            var restored = (JsonArray)Revert(list, oldItems, newItems, path)!;
            if (listBefore["$order"] is JsonArray order)
            {
                var identities = order.Select(n => n!.GetValue<string>()).ToList();
                foreach (var item in oldItems.Where(n => !newItems.Any(m => Identity(n) == Identity(m))))
                {
                    int at = Enumerable.Range(0, restored.Count).FirstOrDefault(i => Identity(restored[i]) == Identity(item), -1);
                    if (at < 0) continue;
                    var node = restored[at]; restored.RemoveAt(at);
                    var following = identities.Skip(identities.IndexOf(Identity(item)) + 1).ToHashSet();
                    int insert = Enumerable.Range(0, restored.Count).FirstOrDefault(i => following.Contains(Identity(restored[i])), restored.Count);
                    restored.Insert(insert, node);
                }
            }
            return restored;
        }
        if (before is JsonObject a && after is JsonObject b && current is JsonObject c)
        {
            foreach (string key in a.Select(p => p.Key).Union(b.Select(p => p.Key)))
            {
                var value = Revert(c[key], a[key], b[key], path + "/" + key);
                if (value == null) c.Remove(key); else c[key] = value;
            }
            return c.DeepClone();
        }
        if (before is JsonArray x && after is JsonArray y && current is JsonArray z)
        {
            foreach (var added in y)
            {
                var old = x.FirstOrDefault(n => Identity(n) == Identity(added));
                int index = Enumerable.Range(0, z.Count).FirstOrDefault(i => Identity(z[i]) == Identity(added), -1);
                if (index < 0) continue;
                if (old == null) z.RemoveAt(index);
                else z[index] = Revert(z[index], old, added, path);
            }
            foreach (var removed in x.Where(n => !y.Any(m => Identity(n) == Identity(m))))
                if (!z.Any(n => Identity(n) == Identity(removed)))
                {
                    var following = x.SkipWhile(n => Identity(n) != Identity(removed)).Skip(1).Select(Identity).ToHashSet();
                    int insert = Enumerable.Range(0, z.Count).FirstOrDefault(i => following.Contains(Identity(z[i])), z.Count);
                    z.Insert(insert, removed?.DeepClone());
                }
            return z.DeepClone();
        }
        if (JsonNode.DeepEquals(current, after)) return before?.DeepClone();
        // 金额、累计学习等数值只撤回本次增减，保留后来发生的独立增减。
        bool additive = path is "/credits" or "/owned/CashFlow" or "/learning/ChanceShift" or "/learning/Exposure" or "/relation/Favour"
            || path.StartsWith("/learning/Topics/") || path.StartsWith("/clubBudgets/");
        if (additive && current?.GetValueKind() == JsonValueKind.Number && (before == null || before.GetValueKind() == JsonValueKind.Number) && after?.GetValueKind() == JsonValueKind.Number)
        {
            decimal value = current.Deserialize<decimal>() - after.Deserialize<decimal>() + (before?.Deserialize<decimal>() ?? 0);
            return value == decimal.Truncate(value) ? JsonValue.Create((long)value) : JsonValue.Create(value);
        }
        return current?.DeepClone();
    }

    private static void Restore(CareerData d, string id, JsonObject state, bool contract)
    {
        var p = CareerEngine.Person(d, id)!;
        foreach (var field in state["profile"]!.AsObject()) PrivateProfileChanges.SetValue(p, field.Key, field.Value!.GetValue<string>());
        p.PrivateProfileReceipts = state["receipts"]!.Deserialize<HashSet<string>>()!;
        p.Learning = state["learning"]!.Deserialize<NpcLearning>()!;
        p.Learning.MoodDay = state["mood"]!["MoodDay"]!.Deserialize<int>();
        p.Learning.MoodUntil = state["mood"]!["MoodUntil"]!.Deserialize<int>();
        p.Learning.MoodStrength = state["mood"]!["MoodStrength"]!.Deserialize<double>();
        var relation = state["relation"]!.Deserialize<PrivateRelation>()!;
        relation.Favour = Math.Clamp(relation.Favour, -100, 100);
        PrivateMessages.Mailbox(d).Relations[id] = relation; d.Life.Relationships[id] = relation.Favour;
        if (state["offers"] != null) PrivateMessages.Conversation(d, id).Offers = state["offers"]!.Deserialize<List<PrivateOffer>>()!;
        if (state["privateMatches"] != null)
        {
            d.Matches.RemoveAll(m => PrivateAppointments.IsPrivate(m) && m.OpponentId == id);
            d.Matches.AddRange(state["privateMatches"]!.Deserialize<List<CareerMatch>>()!);
        }
        if (!contract) return;
        p.ClubId = state["club"]!.GetValue<string>(); p.Role = state["role"]!.GetValue<string>();
        p.ClubPosition = state["position"]?.GetValue<string>() ?? p.ClubPosition;
        d.Credits = 0; d.Life.CreditFraction = 0; CareerMoney.Add(d, state["credits"]!.Deserialize<decimal>()); d.Esports.OwnedClub = state["owned"]?.Deserialize<OwnedClubState>();
        if (state["rosterRoles"] is JsonObject roles)
            foreach (var entry in roles)
                if (CareerEngine.Person(d, entry.Key) is { } member)
                { member.Role = entry.Value!["Role"]!.GetValue<string>(); member.ClubPosition = entry.Value!["ClubPosition"]!.GetValue<string>(); }
        var budgets = state["clubBudgets"]!.Deserialize<Dictionary<string, int>>()!;
        foreach (var club in d.Esports.Clubs) if (budgets.TryGetValue(club.Id, out int amount)) club.Budget = amount;
        d.Matches = state["matches"]!.Deserialize<List<CareerMatch>>()!;
        d.Esports.Competitions = state["competitions"]!.Deserialize<List<WorldCompetition>>()!;
        d.Life.Events = state["events"]!.Deserialize<List<LifeEvent>>()!;
        d.Life.Ledger = state["ledger"]!.Deserialize<List<FinanceEntry>>()!;
        d.CommunityMemories = state["memories"]!.Deserialize<List<CommunityMemory>>()!;
    }

    public static string? Rewind(CareerData d, PrivateConversation c, PrivateTurn turn)
    {
        var offers = c.Offers.Where(o => o.TurnId == turn.Id).ToList();
        if (offers.Any(o => o.Kind == "match" && o.MatchId.Length > 0 && d.Matches.Any(m => m.Id == o.MatchId && (d.PendingMatchId == m.Id || m.Status is not ("待赛" or "已取消")))))
            return "这条回复的约战已经开始或结算，无法通过重新生成撤回赛果。";
        if (offers.Any(o => o.Kind == "contract" && o.State == "已确认") && !turn.InteractionUndo.Any(u => u.Contract))
            return "这条旧回复的合同没有保存回退记录，请先在俱乐部处理合同。";
        if (turn.InteractionUndo.Count == 0 && (turn.Learning != null || turn.Mood != null))
            return "这条旧回复未保存水平或状态变化前的数据，无法完整回退。新回复会保存回退记录。";
        foreach (var undo in turn.InteractionUndo.AsEnumerable().Reverse())
        {
            var state = Revert(Capture(d, c.PersonId, undo.Contract), undo.Before, undo.After);
            Restore(d, c.PersonId, (JsonObject)state!, undo.Contract);
        }
        if (turn.InteractionUndo.Count == 0)
        {
            // 旧版本已经保存了档案变更前的值，可直接恢复；旧邀约依据来源轮次清理。
            var p = CareerEngine.Person(d, c.PersonId)!;
            foreach (var change in turn.ProfileChanges.AsEnumerable().Reverse())
                if (PrivateProfileChanges.Value(p, change.Field) == change.After) PrivateProfileChanges.SetValue(p, change.Field, change.Before);
            foreach (var change in turn.ProfileChanges) p.PrivateProfileReceipts.Remove(change.Id);
        }
        foreach (var offer in offers)
        {
            if (offer.Kind == "match") d.Matches.RemoveAll(m => m.Id == offer.MatchId && PrivateAppointments.IsPrivate(m));
            if (offer.Kind == "publish" && offer.MatchId.Length > 0)
            {
                d.Posts.RemoveAll(p => p.Id == offer.MatchId); d.SavedThreads.RemoveAll(p => p.Id == offer.MatchId);
                d.CommunityMemories.RemoveAll(m => m.PostId == offer.MatchId);
            }
        }
        c.Offers.RemoveAll(o => o.TurnId == turn.Id);
        int index = c.Turns.IndexOf(turn);
        var summaries = c.SmallSummaries.Concat(c.BigSummaries).Where(s => s.Through > index).ToList();
        if (summaries.Count > 0) c.ContextStart = Math.Min(c.ContextStart, summaries.Min(s => s.From));
        c.SmallSummaries.RemoveAll(s => summaries.Contains(s)); c.BigSummaries.RemoveAll(s => summaries.Contains(s));
        turn.InteractionUndo.Clear(); turn.ProfileChanges.Clear(); turn.Learning = null; turn.Mood = null; turn.Applied = false; turn.Context = "";
        foreach (var match in d.Matches.Where(m => m.OpponentId == c.PersonId && m.Status == "待赛" && m.Live == null && m.Id != d.PendingMatchId))
        { match.OpponentPrepared = false; match.OpponentSeconds = null; }
        return null;
    }
}
