namespace NationalSpire;

/// <summary>多人约会仍用私信的交互规则；每人的撤回记录保存在主轮次。</summary>
public static class DateSceneEffects
{
    public static PrivateTurn? SourceTurn(PrivateMailbox mailbox, string person, string turnId)
    {
        if (mailbox.Conversations.TryGetValue(person, out var direct) && direct.Turns.FirstOrDefault(t => t.Id == turnId) is { } own) return own;
        return mailbox.Conversations.Values.SelectMany(c => c.Turns).FirstOrDefault(t =>
            t.DatePartyEffects.TryGetValue(person, out var child) && child.Id == turnId);
    }
    public static void Apply(CareerData data, PrivateConversation conversation, PrivateTurn turn, IReadOnlyList<Dictionary<string, string>> directives, int originalFavour)
    {
        if (turn.Applied) return;
        DateSceneInvitations.Respond(data, conversation, turn, directives);
        if (turn.Scene is not { Participants.Count: > 1 } scene)
        { PrivateMessages.Apply(data, conversation, turn, directives, originalFavour); DateGames.Respond(data, conversation, turn, directives); return; }
        var people = scene.Participants.Select(p => p.PersonId).ToHashSet();
        var host = new List<Dictionary<string, string>>();
        var others = new Dictionary<string, List<Dictionary<string, string>>>();
        foreach (var fields in directives)
        {
            string actor = fields.GetValueOrDefault("Actor", "");
            bool personal = fields.ContainsKey("Favour") || fields.ContainsKey("Attitude") || fields.ContainsKey("Relationship") || fields.ContainsKey("Skill") || fields.ContainsKey("Mood") || fields.ContainsKey("Profile");
            if (personal && (!people.Contains(actor) || !PrivateMessages.CanChat(data, actor))) { turn.Error += "\n一项交互缺少有效人物编号，已保留原值。"; continue; }
            if (!personal || actor == conversation.PersonId) { host.Add(fields); continue; }
            if (!others.TryGetValue(actor, out var list)) others[actor] = list = [];
            list.Add(fields);
        }
        PrivateMessages.Apply(data, conversation, turn, host, originalFavour);
        foreach (var (person, fields) in others)
        {
            var child = new PrivateTurn { Id = turn.Id + "/" + person, Day = turn.Day, Season = turn.Season, Status = "complete", User = turn.User,
                Reply = string.Join("\n", turn.SceneLines.Where(l => l.Speaker == person).Select(l => l.Text)) };
            if (child.Reply.Length == 0) { turn.Error += "\n缺少发言内容的人物交互已略过。"; continue; }
            PrivateMessages.Apply(data, PrivateMessages.Conversation(data, person), child, fields);
            turn.DatePartyEffects[person] = child;
            foreach (var undo in child.InteractionUndo) { undo.PersonId = person; turn.InteractionUndo.Add(undo); }
            if (child.Error.Length > 0) turn.Error += "\n" + CareerEngine.DisplayName(data, person) + "：" + child.Error;
        }
        DateGames.Respond(data, conversation, turn, directives);
    }
}
