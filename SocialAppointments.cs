namespace NationalSpire;

public static class SocialAppointments
{
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
        if (action == "取消") { if (old != null && old.State is "待确认" or "已确认") old.State = "已取消"; return; }
        if (action is not ("邀请" or "改期") || action == "改期" && (old == null || old.State is not ("待确认" or "已确认"))) { t.Error += "\n活动编号或动作无效。"; return; }
        var o = new PrivateOffer { Kind = "activity", TurnId = t.Id, Title = fields.GetValueOrDefault("Title", old?.Title ?? ""),
            Detail = fields.GetValueOrDefault("Detail", old?.Detail ?? ""), ReplacesOfferId = old?.Id ?? "" };
        o.Season = int.TryParse(fields.GetValueOrDefault("Season"), out int season) ? season : -1;
        o.Day = int.TryParse(fields.GetValueOrDefault("Day"), out int day) ? day : -1;
        if (string.IsNullOrWhiteSpace(o.Title) || o.Season < d.Season || o.Day < 1 || o.Day > SeasonCalendar.Length(d, o.Season)
            || PrivateAppointments.Date(d, o) < d.Day) { t.Error += "\n活动需要名称和有效日期。"; return; }
        c.Offers.Add(o);
    }
    public static string? Confirm(CareerData d, PrivateConversation c, PrivateOffer o)
    {
        if (o.State != "待确认") return "这项活动已处理。";
        if (PrivateAppointments.Date(d, o) < d.Day) return "活动日期已过，请重新商谈。";
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
