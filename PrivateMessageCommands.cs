using System.Text.Json;

namespace NationalSpire;

public sealed class PrivateMessageCommand
{
    public bool? ToolMode { get; set; }
    public DateSceneRequest? Scene { get; set; }
    public bool SceneAttendance { get; set; }
    public string Text { get; set; } = "";
    public string Offer { get; set; } = "";
    public string Replacement { get; set; } = "";
    public PrivateOffer? Request { get; set; }
    public List<PrivateOffer> Attachments { get; set; } = [];
    public string Entry { get; set; } = "";
    public string Part { get; set; } = "";
    public PrivateHistorySettings? Settings { get; set; }
    public ProactiveChatSettings? Proactive { get; set; }
}
public static class PrivateMessageCommands
{
    public static string? Apply(CareerData data, string kind, string person, PrivateMessageCommand command)
    {
        var error = ApplyCore(data, kind, person, command);
        if (error == null && kind is "dm-send" or "dm-retry" or "dm-regenerate" or "dm-date-open" or "dm-date-end" or "dm-date-revise")
        {
            var pending = PrivateMessages.Conversation(data, person).Turns.LastOrDefault(t => t.Status == "queued");
            if (pending != null) { pending.ToolMode = command.ToolMode ?? data.Ai.ChatTools; pending.ToolCalls.Clear(); }
        }
        return error;
    }
    private static string? ApplyCore(CareerData data, string kind, string person, PrivateMessageCommand command)
    {
        if (kind == "consumer-attach") return ConsumerAttachments.Prepare(data, person, command.Part, command.Request!);
        if (kind == "consumer-remove") return ConsumerAttachments.Remove(data, command.Entry);
        if (kind == "dm-avatar-frame") return NpcAvatarFrames.Select(data, person, command.Text);
        if (kind == "dm-settings") { command.Settings!.Validate(); PrivateMessages.Mailbox(data).Settings = command.Settings; return null; }
        if (kind is "dm-date-open" or "dm-date-revise" or "dm-send" or "dm-retry" or "dm-regenerate" or "dm-arbitrate" && AiService.PrivateBusy(data, person)) return "正在结束上一条请求，请稍候再发送。";
        var c = PrivateMessages.Conversation(data, person);
        if (MatchFailure.Locked(data) is { } failure) return failure;
        if (kind is "dm-edit" or "dm-delete" or "dm-clear" or "dm-summary-edit" or "dm-summary-delete" or "dm-summary")
            return PrivateMessages.Manage(data, c, kind, command);
        switch (kind)
        {
            case "dm-date-revise":
                if (AiService.PrivateBusy(data, person) || c.Turns.Any(t => t.Status is "queued" or "sending")) return "请等待上一条请求停止后再发送。";
                var revision = c.Turns.LastOrDefault();
                if (revision == null || revision.Id != command.Entry || revision.Status != "failed" || revision.Scene is not { Ending: false } || revision.UserDeleted || revision.ReplyDeleted) return "这条约会消息已不可修订，请刷新场景。";
                if (DateScenes.Validate(data, c, revision.Scene) is { } revisionError) return revisionError;
                if (string.IsNullOrWhiteSpace(command.Text)) return "请填写消息。";
                revision.User = command.Text.Trim(); revision.Status = "queued"; revision.Error = revision.Reply = revision.Reasoning = "";
                revision.Context = ""; revision.SceneLines.Clear(); c.MemoryRevision++;
                return null;
            case "dm-date-pause": case "dm-date-end":
                return DateScenes.Leave(data, c, command.Offer, kind == "dm-date-end");
            case "dm-date-open":
                if (command.Scene == null) return "场景信息缺失。";
                if (DateScenes.Validate(data, c, command.Scene) is { } sceneError) return sceneError;
                if (c.Turns.Any(t => t.Scene?.OfferId == command.Scene.OfferId && t.Scene.Opening && !t.ReplyDeleted)) return "本次活动已有开场，请继续已有场景。";
                if (CareerEngine.Person(data, person) is { } muted && SpireArbitration.Muted(muted)) return "该角色账号已封禁，普通私信已停止。";
                command.Scene.Opening = true;
                var opening = PrivateMessages.Enqueue(data, person, "（进入约会场景 · " + command.Scene.Title + "）");
                opening.Scene = Coop.CoopJson.Copy(command.Scene); c.DateSceneStates[command.Scene.OfferId] = "active"; return null;

            case "dm-manage": return ChatMembership.Private(data, c, command.Part);
            case "dm-proactive": return command.Proactive == null ? "请选择主动联系设置。" : ProactiveChats.Configure(c.Proactive, command.Proactive);
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
                PrivateOffer? report = null;
                if (command.Request != null)
                {
                    if (command.Request.Kind != CommunityReporting.Kind || command.Request.Quote is not { } source) return "社区举报来源无效。";
                    try { report = CommunityReporting.Create(data, person, source.PostId, source.ReplyId); }
                    catch (InvalidOperationException e) { return e.Message; }
                }
                string reason = string.IsNullOrWhiteSpace(command.Text)
                    ? report != null ? "举报这条社区内容及其作者，请结合来源帖上下文和既有裁决规则审理。"
                        : "申请尖塔仲裁，请审理双方完整往来及此前裁决的履行情况。"
                    : command.Text;
                var application = PrivateMessages.Enqueue(data, person, reason, report);
                application.RequestKind = "arbitration"; return null;
            case "dm-regenerate":
                var latest = c.Turns.LastOrDefault();
                if (latest == null || latest.Id != command.Entry || latest.Status != "complete" || latest.UserDeleted || latest.ReplyDeleted || latest.RequestKind == "arbitration")
                    return "只能重新生成最新一条完整回复。";
                if (latest.Scene != null && DateScenes.Validate(data, c, latest.Scene) is { } regenerateSceneError) return regenerateSceneError;
                if (PrivateInteractionHistory.Rewind(data, c, latest) is { } rewindError) return rewindError;
                latest.PreviousReply = latest.Reply; latest.PreviousReasoning = latest.Reasoning;
                latest.Regenerating = true; latest.Status = "queued"; latest.Reply = ""; latest.Reasoning = ""; latest.Error = "";
                // 后台旧总结失效；新回复从撤回后的关系、日程和资料重新生成。
                c.MemoryRevision++; return null;
            case "dm-send":
                if (command.Scene != null && DateScenes.Validate(data, c, command.Scene) is { } dateError) return dateError;
                if (CareerEngine.Person(data, person) is { } banned && SpireArbitration.Muted(banned)) return "该角色账号已封禁；仍可查看记录、申请仲裁及要求履行致歉。";
                if (command.Request?.Kind == "match" && PrivateAppointments.Error(data, person, command.Request) is { } requestError) return requestError;
                if (PrivateMessages.PrepareAttachments(data, person, command.Attachments) is { } attachmentError) return attachmentError;
                var sent = PrivateMessages.Enqueue(data, person, command.Text, command.Request, command.Attachments);
                ConsumerAttachments.Sent(data, command.Attachments);
                if (command.Scene != null) { sent.Scene = Coop.CoopJson.Copy(command.Scene); sent.Scene.Opening = false; c.DateSceneStates[command.Scene.OfferId] = "active"; }
                return null;
            case "dm-select": PrivateMessages.Mailbox(data).LastPerson = person; return null;
            case "dm-read": c.SeenCount = c.Turns.Count(t => t.Status == "complete"); return null;
            case "dm-retry":
                if (c.Turns.Any(t => t.Status is "queued" or "sending")) return "上一条回复尚未结束。";
                var last = c.Turns.LastOrDefault();
                if (last?.Status != "failed") return "没有需要重试的消息。";
                if (last.RequestKind == "arbitration" && last.UserDeleted) return "该仲裁申请已删除，请重新提交。";
                if (last.Scene != null && DateScenes.Validate(data, c, last.Scene) is { } retrySceneError) return retrySceneError;
                last.Status = "queued"; last.Error = ""; last.Reply = ""; last.Reasoning = ""; return null;
            case "dm-stop":
                foreach (var t in c.Turns.Where(t => t.Status is "queued" or "sending")) RestoreInterrupted(t, "已停止生成。");
                AiService.CancelPrivate(data, person); return null;
            case "dm-confirm": case "dm-decline":
                var offer = c.Offers.FirstOrDefault(o => o.Id == command.Offer);
                if (offer == null) return "这项邀约已不存在。";
                if (offer.Kind == "favour")
                { PrivateMessages.ConfirmFavour(data, c, offer, kind == "dm-confirm"); return null; }
                if (offer.Kind == "activity")
                {
                    if (kind == "dm-decline") { if (offer.State is not ("待确认" or "已确认")) return "这项活动已处理。"; offer.State = "已取消"; ConsumerAttachments.Resolve(data, offer, false); return null; }
                    return SocialAppointments.Confirm(data, c, offer);
                }
                if (offer.Kind == "publish" && kind == "dm-decline")
                { if (offer.State != "待确认") return "已发布的帖子请在社区查看。"; offer.State = "已取消"; ConsumerAttachments.Resolve(data, offer, false); return null; }
                if (kind == "dm-decline") return offer.Kind == "contract" && offer.State != "待确认" ? "已签订的合同请在选手档案中管理。" : PrivateAppointments.Cancel(data, offer);
                if (offer.Kind == "publish") { var result = PrivateProfileChanges.Publish(data, person, offer); if (result == null) SpireArbitration.Merge(data, PrivateMessages.Mailbox(data)); return result; }
                string? confirmationError = offer.Kind == "match" ? PrivateAppointments.Confirm(data, person, offer) : PrivateContracts.Confirm(data, person, offer, command.Replacement);
                if (confirmationError != null) RecordFailure(data, person, command, confirmationError);
                else offer.Detail = "";
                return confirmationError;
            case "dm-training-cancel": ClubCoaching.StopTraining(data, person); return null;
            case "dm-lineup-cancel": return CoachLineups.Cancel(data, person, command.Offer);
            case "dm-attend":
                var activity = c.Offers.FirstOrDefault(o => o.Id == command.Offer);
                return activity == null ? "活动已不存在。" : SocialAppointments.Attend(data, activity, command.Part == "public", command.SceneAttendance);
            default: return "私信操作无效。";
        }
    }
    public static bool RecordFailure(CareerData data, string person, PrivateMessageCommand command, string error)
    {
        if (!PrivateMessages.Mailbox(data).Conversations.TryGetValue(person, out var conversation)) return false;
        var offer = conversation.Offers.FirstOrDefault(o => o.Id == command.Offer && o.State == "待确认" && o.Kind is "contract" or "match");
        if (offer == null || offer.Detail == error) return false;
        offer.Detail = error;
        return true;
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
