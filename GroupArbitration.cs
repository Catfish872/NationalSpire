using System.Text.Json;

namespace NationalSpire;

public static class GroupArbitration
{
    public static List<Dictionary<string, string>> Compose(CareerData d, GroupChat g, GroupTurn t)
    {
        var source = GroupChatPrompts.Compose(d, g, t);
        source[0]["content"] = GroupChatPrompts.Section(d, "world") + "\n" + SpireArbitration.Prompt + "\n" + ChatTimeline.Privacy + "\n" + """
本次同时审理多名被申请人，分别作出裁决，不因同处一个群聊就认定所有人有责任。
输出一个 JSON 对象：Decisions 是裁决数组，每项包含 Person（被申请人人物编号）与 Decision（上述单人裁决对象）；PublicTitle、PublicBody 为所有申请成立者共同承担具体责任的统一公开致歉草稿，由其中一名责任人代表发布。各 Decision 的 Apology 为该人发到本群的致歉。每人分别填写自己的处罚与性格变化；未成立者不承担他人的处罚。
""";
        foreach (var message in source.Skip(1)) if (message["role"] == "assistant") { message["role"] = "user"; message["content"] = "本群已经发生的发言\n" + message["content"]; }
        source.Add(new() { ["role"] = "user", ["content"] = "本次被申请人：" + string.Join("、", t.ArbitrationTargets.Select(id => g.Alias(id) + " " + GroupChats.Name(d, id))) + "\n申请内容：" + t.Text });
        return source;
    }
    public static void LinkPublication(CareerData d, GroupChat g, string localTurn)
    {
        var turn = g.Turns.FirstOrDefault(t => t.ArbitrationTargets.Count > 0 && t.Effects.Any(e => e.Turn == localTurn));
        if (turn == null) return;
        var post = turn.Effects.SelectMany(e => g.Interactions[e.Lane].Offers).FirstOrDefault(o => o.TurnId == localTurn && o.State == "已确认" && o.Kind == "publish");
        if (post == null) return;
        foreach (var effect in turn.Effects)
        {
            var record = g.Interactions[effect.Lane].Turns.FirstOrDefault(t => t.Id == effect.Turn)?.Arbitration;
            if (record?.Upheld != true) continue;
            record.PostId = post.MatchId;
            if (CareerEngine.Person(d, effect.Person)?.Arbitrations.FirstOrDefault(r => r.Id == record.Id) is { } saved) saved.PostId = post.MatchId;
        }
    }
    public static void Apply(CareerData d, GroupChat g, GroupTurn t, string raw)
    {
        using var doc = JsonDocument.Parse(raw.Trim().Trim('`').Trim().StartsWith("json", StringComparison.OrdinalIgnoreCase) ? raw.Trim().Trim('`').Trim()[4..].Trim() : raw.Trim().Trim('`').Trim());
        var root = doc.RootElement;
        var parsed = new List<(string Person, ArbitrationDecision Decision)>();
        foreach (var row in root.GetProperty("Decisions").EnumerateArray())
        {
            string id = g.Resolve(row.GetProperty("Person").GetString() ?? "");
            if (!t.ArbitrationTargets.Contains(id) || parsed.Any(x => x.Person == id)) continue;
            parsed.Add((id, SpireArbitration.Parse(row.GetProperty("Decision").GetRawText())));
        }
        if (parsed.Count != t.ArbitrationTargets.Count) throw new InvalidDataException("仲裁返回缺少部分被申请人的裁决，尚未执行处罚。");
        var guilty = parsed.Where(x => x.Decision.Upheld).Select(x => x.Person).ToArray();
        string representative = guilty.Length > 0 ? guilty[Random.Shared.Next(guilty.Length)] : "";
        // 全部裁决先验证，避免第二人的字段错误留下第一人的处罚。
        var probe = GroupChats.PreviewCopy(d);
        Execute(probe, probe.Chats.Groups.Single(x => x.Id == g.Id), probe.Chats.Groups.Single(x => x.Id == g.Id).Turns.Single(x => x.Id == t.Id));
        Execute(d, g, t);
        void Execute(CareerData data, GroupChat group, GroupTurn turn)
        {
            foreach (var (person, decision) in parsed)
                GroupChats.InLane(data, group, turn.Sender, person, "", c =>
                {
                    var local = new PrivateTurn { Id = turn.Id + ":arbitration:" + person, User = turn.Text, Day = turn.Day, Season = data.Season, RequestKind = "arbitration" };
                    c.Turns.Add(local); SpireArbitration.Complete(data, c, local, decision);
                    c.LastInteractionNumber = Math.Max(c.LastInteractionNumber, group.LastInteractionNumber); PrivateInteractionIds.Ensure(c);
                    foreach (var offer in c.Offers) PrivateInteractionIds.Number(c, offer);
                    group.LastInteractionNumber = c.LastInteractionNumber;
                    var post = c.Offers.FirstOrDefault(o => o.TurnId == local.Id);
                    if (post != null)
                    {
                        if (person != representative) c.Offers.Remove(post);
                        else
                        {
                            if (root.TryGetProperty("PublicTitle", out var title)) post.Title = title.GetString() ?? post.Title;
                            if (root.TryGetProperty("PublicBody", out var body)) post.Detail = body.GetString() ?? post.Detail;
                            post.RelatedPeople = guilty.Where(id => id != representative).ToList(); post.GroupId = group.Id; post.ActorId = person;
                        }
                    }
                    if (decision.Apology.Length > 0) turn.Replies.Add(new() { Author = person, Text = decision.Apology, Day = turn.Day, TurnId = turn.Id, Order = GroupChats.NextOrder(data) });
                    turn.Notices.Add(GroupChats.Name(data, person) + "：" + decision.Finding);
                    turn.Effects.Add(new() { Human = turn.Sender, Person = person, Lane = turn.Sender + "/" + person + "/", Turn = local.Id });
                    return true;
                });
        }
    }
}
