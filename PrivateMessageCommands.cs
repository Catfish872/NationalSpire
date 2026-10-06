using System.Text.Json;

namespace NationalSpire;

public sealed class PrivateMessageCommand
{
    public string Text { get; set; } = "";
    public string Offer { get; set; } = "";
    public string Replacement { get; set; } = "";
    public PrivateOffer? Request { get; set; }
    public List<PrivateOffer> Attachments { get; set; } = [];
    public string Entry { get; set; } = "";
    public string Part { get; set; } = "";
    public PrivateHistorySettings? Settings { get; set; }
}
public static class PrivateMessageCommands
{
    public static string? Apply(CareerData data, string kind, string person, PrivateMessageCommand command)
    {
        if (kind == "dm-settings") { command.Settings!.Validate(); PrivateMessages.Mailbox(data).Settings = command.Settings; return null; }
        if (kind is "dm-send" or "dm-retry" or "dm-regenerate" or "dm-arbitrate" && AiService.PrivateBusy(data, person)) return "正在结束上一条请求，请稍候再发送。";
        var c = PrivateMessages.Conversation(data, person);
        if (kind is "dm-edit" or "dm-delete" or "dm-clear" or "dm-summary-edit" or "dm-summary-delete" or "dm-summary")
            return PrivateMessages.Manage(data, c, kind, command);
        switch (kind)
        {
            case "dm-arbitration-apology":
                var ruling = CareerEngine.Person(data, person)!.Arbitrations.FirstOrDefault(r => r.Id == command.Entry && r.Upheld);
                if (ruling == null || ruling.ApplicantId != (data.LocalHumanId.Length > 0 ? data.LocalHumanId : "player")) return "只有该案申请人可以要求公开道歉。";
                if (ruling.PostId.Length > 0) return "这份公开道歉已经发布。";
                var apology = c.Offers.FirstOrDefault(o => o.Id == "arbitration-" + ruling.Id);
                if (apology == null) { apology = new() { Id = "arbitration-" + ruling.Id, Kind = "publish", TurnId = ruling.Id, Title = ruling.PublicTitle, Detail = ruling.PublicBody }; c.Offers.Add(apology); }
                apology.State = "待确认";
                var publicationError = PrivateProfileChanges.Publish(data, person, apology);
                if (publicationError == null) { ruling.PostId = apology.MatchId; SpireArbitration.Merge(data, PrivateMessages.Mailbox(data)); }
                return publicationError;
            case "dm-arbitrate":
                if (c.Turns.Any(t => t.Status is "queued" or "sending")) return "请先等待当前回复结束。";
                var application = PrivateMessages.Enqueue(data, person, string.IsNullOrWhiteSpace(command.Text) ? "申请尖塔仲裁，请审理双方完整往来及此前裁决的履行情况。" : command.Text);
                application.RequestKind = "arbitration"; return null;
            case "dm-regenerate":
                var latest = c.Turns.LastOrDefault();
                if (latest == null || latest.Id != command.Entry || latest.Status != "complete" || latest.UserDeleted || latest.ReplyDeleted || latest.RequestKind == "arbitration")
                    return "只能重新生成最新一条完整回复。";
                if (PrivateInteractionHistory.Rewind(data, c, latest) is { } rewindError) return rewindError;
                latest.PreviousReply = latest.Reply; latest.PreviousReasoning = latest.Reasoning;
                latest.Regenerating = true; latest.Status = "queued"; latest.Reply = ""; latest.Reasoning = ""; latest.Error = "";
                // 后台旧总结失效；新回复从撤回后的关系、日程和资料重新生成。
                c.MemoryRevision++; return null;
            case "dm-send":
                if (CareerEngine.Person(data, person) is { } banned && SpireArbitration.Muted(banned)) return "该角色账号已封禁；仍可查看记录、申请仲裁及要求履行致歉。";
                if (command.Request?.Kind == "match" && PrivateAppointments.Error(data, person, command.Request) is { } requestError) return requestError;
                if (PrivateMessages.PrepareAttachments(data, person, command.Attachments) is { } attachmentError) return attachmentError;
                PrivateMessages.Enqueue(data, person, command.Text, command.Request, command.Attachments); return null;
            case "dm-select": PrivateMessages.Mailbox(data).LastPerson = person; return null;
            case "dm-read": c.SeenCount = c.Turns.Count(t => t.Status == "complete"); return null;
            case "dm-retry":
                if (c.Turns.Any(t => t.Status is "queued" or "sending")) return "上一条回复尚未结束。";
                var last = c.Turns.LastOrDefault();
                if (last?.Status != "failed") return "没有需要重试的消息。";
                last.Status = "queued"; last.Error = ""; last.Reply = ""; last.Reasoning = ""; return null;
            case "dm-stop":
                foreach (var t in c.Turns.Where(t => t.Status is "queued" or "sending")) RestoreInterrupted(t, "已停止生成。");
                AiService.CancelPrivate(data, person); return null;
            case "dm-confirm": case "dm-decline":
                var offer = c.Offers.FirstOrDefault(o => o.Id == command.Offer);
                if (offer == null) return "这项邀约已不存在。";
                if (offer.Kind == "publish" && kind == "dm-decline")
                { if (offer.State != "待确认") return "已发布的帖子请在社区查看。"; offer.State = "已取消"; return null; }
                if (kind == "dm-decline") return offer.Kind == "contract" && offer.State != "待确认" ? "已签订的合同请在选手档案中管理。" : PrivateAppointments.Cancel(data, offer);
                if (offer.Kind == "publish") { var result = PrivateProfileChanges.Publish(data, person, offer); if (result == null) SpireArbitration.Merge(data, PrivateMessages.Mailbox(data)); return result; }
                return offer.Kind == "match" ? PrivateAppointments.Confirm(data, person, offer) : PrivateContracts.Confirm(data, person, offer, command.Replacement);
            default: return "私信操作无效。";
        }
    }
    public static void RestoreInterrupted(PrivateTurn turn, string error)
    {
        turn.Error = error;
        if (turn.Regenerating)
        {
            turn.Reply = turn.PreviousReply; turn.Reasoning = turn.PreviousReasoning; turn.Status = "failed";
            turn.Error += " 原交互已撤回，保留原文供查看，可重试生成。";
            turn.PreviousReply = turn.PreviousReasoning = ""; turn.Regenerating = false;
        }
        else turn.Status = "failed";
    }
    public static void Recover(CareerLifeState life)
    {
        foreach (var c in life.Mailbox.Conversations.Values)
        {
            PrivateMessages.RemoveDeletedOffers(c);
            c.SummaryStatus = ""; c.SummaryRequest = "";
            foreach (var t in c.Turns.Where(t => t.Status is "queued" or "sending")) RestoreInterrupted(t, "上次回复中断，可以重试。");
        }
    }
}
