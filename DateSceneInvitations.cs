namespace NationalSpire;

public sealed class DateSceneInvitation
{
    public string Host { get; set; } = "";
    public string OfferId { get; set; } = "";
    public string State { get; set; } = "pending";
}

/// <summary>加入已有约会只扩展原日程；NPC 的明确接受为写入参与者的条件。</summary>
public static class DateSceneInvitations
{
    public const string Protocol = "这是加入已有约会的邀请。依据你的意愿回复，并在正文后输出 [DateJoin: 接受] 或 [DateJoin: 拒绝]；接受会加入该日程。";
    public static string? Invite(CareerData data, string host, string offerId, string target)
    {
        var conversation = PrivateMessages.Conversation(data, host);
        var offer = conversation.Offers.FirstOrDefault(o => o.Id == offerId);
        if (offer == null || !DateGroupBridge.SourceActive(data, offer) || !DateSceneParty.Eligible(data, offer, conversation) || offer.State is not ("已确认" or "已赴约")
            || conversation.DateSceneStates.GetValueOrDefault(offerId) == "ended") return "请选择仍在进行或已经确认的约会。";
        var people = DateSceneParty.People(data, offer, host);
        if (people.Contains(target)) return "约会已有该成员。";
        if (!PrivateMessages.CanChat(data, target)) return "该人物当前无法接收邀请。";
        var receiver = PrivateMessages.Conversation(data, target);
        if (AiService.PrivateBusy(data, target) || receiver.Turns.Any(t => t.Status is "queued" or "sending")) return "请等待该人物上一条回复结束。";
        if (receiver.Turns.Any(t => t.DateInvitation is { State: "pending" } i && i.Host == host && i.OfferId == offerId)) return "该人物正在考虑这项邀请。";
        var turn = PrivateMessages.Enqueue(data, target, $"邀请你一起参加{PrivateAppointments.DateText(data, PrivateAppointments.Date(data, offer))}的《{offer.Title}》。已有参与者：{string.Join("、", people.Select(id => CareerEngine.DisplayName(data, id)))}。活动内容：{offer.Detail}。你愿意加入吗？");
        turn.DateInvitation = new() { Host = host, OfferId = offerId }; return null;
    }
    public static void Respond(CareerData data, PrivateConversation receiver, PrivateTurn turn, IReadOnlyList<Dictionary<string, string>> directives)
    {
        if (turn.DateInvitation is not { State: "pending" } invitation) return;
        string? decision = directives.LastOrDefault(f => f.ContainsKey("DateJoin"))?.GetValueOrDefault("DateJoin");
        if (decision == "拒绝") { invitation.State = "declined"; return; }
        if (decision != "接受") { invitation.State = "unresolved"; turn.Error += "\n加入约会的决定尚未确认，可再次邀请。"; return; }
        var host = PrivateMessages.Conversation(data, invitation.Host); var offer = host.Offers.FirstOrDefault(o => o.Id == invitation.OfferId);
        if (offer == null || !DateGroupBridge.SourceActive(data, offer) || offer.State is not ("已确认" or "已赴约") || host.DateSceneStates.GetValueOrDefault(offer.Id) == "ended")
        { invitation.State = "expired"; turn.Error += "\n原约会已经结束，本次加入失效。"; return; }
        offer.Participants = new[] { GroupChats.Human(data), host.PersonId }.Concat(offer.Participants).Append(receiver.PersonId).Distinct().ToList();
        DateGroupBridge.Sync(data, offer);
        invitation.State = "accepted";
    }
}
