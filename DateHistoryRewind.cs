using NationalSpire.Coop;

namespace NationalSpire;

public static class DateHistoryRewind
{
    public static string? Apply(CareerData data, string person, PrivateMessageCommand command, bool save = false)
    {
        var current = PrivateMessages.Conversation(data, person);
        if (current.Turns.LastOrDefault()?.Id == command.Replacement && command.Replacement.Length > 0) return null;
        if (MatchFailure.Locked(data) is { } locked) return locked;
        if (AiService.PrivateBusy(data, person) || current.Turns.Any(t => t.Status is "queued" or "sending")) return "请等待当前回复结束后再重新输入。";
        if (current.MemoryRevision.ToString() != command.Part || current.Turns.LastOrDefault()?.Id != command.Text) return "对话已更新，请重新打开历史记录后选择。";
        int index = current.Turns.FindIndex(t => t.Id == command.Entry);
        if (index < 0 || current.Turns[index] is not { Status: "complete", UserDeleted: false, ReplyDeleted: false, Scene: { Opening: false, Ending: false, GameEvent.Length: 0 } } selected
            || selected.Scene.OfferId != command.Offer || command.Replacement.Length == 0) return "这段对话已不可重新输入。";
        var candidate = CoopJson.Copy(data);
        candidate.LocalHumanId = data.LocalHumanId;
        candidate.ExternalCurrent = () => false; candidate.ExternalSave = _ => { };
        var conversation = PrivateMessages.Conversation(candidate, person);
        if (DateScenes.Validate(candidate, conversation, conversation.Turns[index].Scene!, retained: true) is { } invalid) return invalid;
        var removed = conversation.Turns.Skip(index).ToList();
        foreach (var turn in removed.AsEnumerable().Reverse())
        {
            if (turn.DateInvitation is { State: "accepted" } || turn.RequestKind == "arbitration") return "后续记录包含已生效的共同约会或仲裁，请保留这些记录。";
            if (PrivateInteractionHistory.Rewind(candidate, conversation, turn) is { } error) return error;
        }
        var draft = CoopJson.Copy(conversation.Turns[index]);
        draft.Id = command.Replacement; draft.Status = "failed"; draft.Error = "已返回这段对话，请编辑后发送。";
        draft.Reply = draft.Reasoning = draft.PreviousReply = draft.PreviousReasoning = draft.Context = "";
        draft.Regenerating = false; draft.SceneLines.Clear(); draft.SceneChoices.Clear(); draft.ToolCalls.Clear();
        conversation.RewoundDateTurns.UnionWith(removed.Select(t => t.Id));
        conversation.Turns.RemoveRange(index, conversation.Turns.Count - index); conversation.Turns.Add(draft);
        conversation.ContextStart = Math.Min(conversation.ContextStart, index);
        conversation.SeenCount = Math.Min(conversation.SeenCount, conversation.Turns.Count);
        conversation.MemoryRevision++; conversation.SummaryRequest = conversation.SummaryStatus = conversation.SummaryError = "";
        var before = data.EncodingHeader();
        Copy(candidate, data);
        try { if (save) CareerStore.Save(data); }
        catch { Copy(before, data); throw; }
        return null;
    }

    private static void Copy(CareerData from, CareerData to)
    {
        to.Life = from.Life; to.People = from.People; to.Esports = from.Esports; to.Matches = from.Matches; to.Credits = from.Credits;
        to.Posts = from.Posts; to.SavedThreads = from.SavedThreads; to.CommunityMemories = from.CommunityMemories;
    }
}
