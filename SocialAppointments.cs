namespace NationalSpire;

public static class SocialAppointments
{
    public const string ExpiredDate = "填写的邀约日期已过期，请重新约定日期";
    public static string StatusText(CareerData d, PrivateOffer o) => All(d).Any(x => x.Offer.Id == o.Id && x.Conversation.DateSceneStates.GetValueOrDefault(o.Id) == "ended") ? "已结束" : o.State == "已过期"
        || o.State == "待确认" && PrivateAppointments.Date(d, o) < d.Day ? "未建立约定；" + ExpiredDate : o.State;
    public const string Protocol = """
玩家主动提出或暗示活动意愿时，才可商谈活动，名称与内容按双方交流自定。只有下列标记生成待确认约定，口头答应不产生记录；玩家确认后记入日程。
[Activity: 邀请, Title: 一起看录像, Season: 2, Day: 18, Detail: 讨论今天的比赛]
修改已有约定使用 [Activity: 改期, Id: 14, Season: 2, Day: 19]，取消使用 [Activity: 取消, Id: 14]，Id 填对应活动的编号。活动不等同比赛，不自行承诺资金或能力奖励。
""";
    public static IEnumerable<(PrivateConversation Conversation, PrivateOffer Offer)> All(CareerData d)
        => PrivateMessages.Mailbox(d).Conversations.Values.Concat(GroupChats.Visible(d).SelectMany(g => g.Interactions.Where(x => x.Key.StartsWith(GroupChats.Human(d) + "/")).Select(x => x.Value))).SelectMany(c => c.Offers.Where(o => o.Kind == "activity").Select(o => (c, o)));
    public static IEnumerable<(PrivateConversation Conversation, PrivateOffer Offer)> Due(CareerData d)
        => All(d).Where(x => x.Offer.State == "已确认" && PrivateAppointments.Date(d, x.Offer) == d.Day);
    public static void Expire(CareerData d)
    {
        foreach (var (_, o) in All(d).Where(x => x.Offer.State == "已确认" && PrivateAppointments.Date(d, x.Offer) < d.Day)) o.State = "未赴约";
    }
    public static void Respond(CareerData d, PrivateConversation c, PrivateTurn t, Dictionary<string, string> fields)
    {
        string action = fields.GetValueOrDefault("Activity", "");
        PrivateInteractionIds.Ensure(c);
        var old = c.Offers.FirstOrDefault(o => o.Kind == "activity" && o.Id == PrivateInteractionIds.Resolve(c, fields.GetValueOrDefault("Id")));
        if (action is "接受" or "拒绝")
        {
            var invitation = ConsumerInvitations.Pending(c).FirstOrDefault(a => a.Id == PrivateInteractionIds.Resolve(c, fields.GetValueOrDefault("Id")));
            if (invitation == null || t.Status != "complete" || t.ReplyDeleted) { t.Error += "\n约会邀请编号无效或已处理。"; return; }
            if (action == "拒绝")
            {
                c.Offers.Add(new() { Kind = "activity", TurnId = t.Id, Title = invitation.Title, Detail = "此次约会邀请已被婉拒。", State = "已拒绝", SourceInvitationId = invitation.Id,
                    Season = d.Season, Day = SeasonCalendar.Day(d, d.Day) }); return;
            }
            var accepted = new Dictionary<string, string>(fields) { ["Activity"] = "邀请", ["Title"] = invitation.Title, ["Detail"] = invitation.Detail };
            int count = c.Offers.Count; Respond(d, c, t, accepted);
            if (c.Offers.Count > count && c.Offers[^1].State == "待确认")
            {
                var created = c.Offers[^1];
                if (ConsumerInvitationStock.Accept(d, c.PersonId, invitation) is { } inventoryError)
                { c.Offers.Remove(created); t.Error += "\n" + inventoryError; return; }
                created.SourceInvitationId = invitation.Id; created.GoodId = invitation.GoodId; created.GoodVerb = invitation.GoodVerb;
                created.Detail = "约会内容：" + invitation.Title + (invitation.GoodVerb.Length > 0 ? " · " + ConsumerCatalog.Get(invitation.GoodId)?.Name : "");
                created.State = "已确认";
            }
            return;
        }
        if (action == "取消") { if (old != null && old.State is "待确认" or "已确认") old.State = "已取消"; return; }
        if (action is not ("邀请" or "改期") || action == "改期" && (old == null || old.State is not ("待确认" or "已确认"))) { t.Error += "\n活动编号或动作无效。"; return; }
        var o = new PrivateOffer { Kind = "activity", TurnId = t.Id, Title = fields.GetValueOrDefault("Title", old?.Title ?? ""),
            Detail = fields.GetValueOrDefault("Detail", old?.Detail ?? ""), ReplacesOfferId = old?.Id ?? "" };
        o.Season = int.TryParse(fields.GetValueOrDefault("Season"), out int season) ? season : -1;
        o.Day = int.TryParse(fields.GetValueOrDefault("Day"), out int day) ? day : -1;
        if (string.IsNullOrWhiteSpace(o.Title) || o.Season < 1 || o.Day < 1 || o.Day > SeasonCalendar.Length(d, o.Season))
        { t.Error += "\n活动需要名称和有效日期。"; return; }
        if (PrivateAppointments.Date(d, o) < d.Day)
        {
            o.State = "已过期"; c.Offers.Add(o);
            t.Error += "\n" + ExpiredDate; return;
        }
        c.Offers.Add(o);
        if (action == "改期" && old!.SourceInvitationId.Length > 0)
        {
            o.SourceInvitationId = old.SourceInvitationId; o.GoodId = old.GoodId; o.GoodVerb = old.GoodVerb;
            old.State = "已改期"; o.State = "已确认";
        }
    }
    public static string? Confirm(CareerData d, PrivateConversation c, PrivateOffer o)
    {
        if (o.State != "待确认") return "这项活动已处理。";
        if (PrivateAppointments.Date(d, o) < d.Day) return ExpiredDate;
        var source = c.Turns.FirstOrDefault(t => t.Id == o.TurnId);
        var before = source == null ? null : PrivateInteractionHistory.Capture(d, c.PersonId);
        if (c.Offers.FirstOrDefault(x => x.Id == o.ReplacesOfferId) is { } old) old.State = "已改期";
        o.State = "已确认";
        if (source != null && before != null) PrivateInteractionHistory.Record(d, c.PersonId, source, before);
        return null;
    }
    public static string? Attend(CareerData d, PrivateOffer o)
    {
        if (o.Kind != "activity" || o.State != "已确认" || PrivateAppointments.Date(d, o) != d.Day) return "这项活动当前不能赴约。";
        o.State = "已赴约"; return null;
    }
}
