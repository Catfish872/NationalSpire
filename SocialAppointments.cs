namespace NationalSpire;

public static class SocialAppointments
{
    public const string ExpiredDate = "填写的邀约日期已过期，请重新约定日期";
    public static string StatusText(CareerData d, PrivateOffer o) => o.State == "已过期"
        || o.State == "待确认" && PrivateAppointments.Date(d, o) < d.Day ? "未建立约定；" + ExpiredDate : o.State;
    public const string Protocol = """
玩家主动提出或暗示活动意愿时，可以商谈活动。人物同意参加、提出新邀请、商定改期或决定取消时，必须在本轮回复中输出对应的 Activity 标记，程序据此登记活动。
每条活动标记完整填写 Activity、Id、Title、Date、Detail。
Activity 填邀请、接受、改期或取消；Id 填对应活动编号，新提议填0；Title 填活动名称；Date 填公历日期，格式为YYYY-MM-DD；Detail 填活动内容。
提出新活动：
[Activity: 邀请, Id: 0, Title: 一起看录像, Date: 2026-01-18, Detail: 讨论今天的比赛]
接受玩家提出的活动：
[Activity: 接受, Id: 14, Title: 一起看录像, Date: 2026-01-18, Detail: 讨论今天的比赛]
商谈改期：
[Activity: 改期, Id: 14, Title: 一起看录像, Date: 2026-01-19, Detail: 讨论今天的比赛]
谢绝或取消活动：
[Activity: 取消, Id: 14, Title: 一起看录像, Date: 2026-01-18, Detail: 讨论今天的比赛]
接受时按玩家附件填写活动资料；改期时填写商谈后的日期和内容；取消时填写对应活动的资料。
只有标记才登记交互，口头答应无法触发实际效果。
""";
    public static string GroupProtocol => Protocol
        .Replace("每条活动标记完整填写 Activity、Id、Title、Date、Detail。", "群聊活动完整填写 Activity、Id、Title、Date、Detail、Actor。Actor 填已经谈妥的完整参与者编号，包括参加活动的玩家，多人以竖线分隔。一项共同活动输出一条标记。处理活动附件时，逐一核对附件中的参与者，将已谈妥的完整名单填写到 Actor。")
        .Replace("Detail: 讨论今天的比赛]", "Detail: 讨论今天的比赛, Actor: p1|p2|p3]");
    public static IEnumerable<(PrivateConversation Conversation, PrivateOffer Offer)> All(CareerData d)
        => PrivateMessages.Mailbox(d).Conversations.Values.Concat(d.Chats.Groups.SelectMany(g => g.Interactions.Where(x => x.Key.StartsWith(GroupChats.Human(d) + "/")).Select(x => x.Value))).SelectMany(c => c.Offers.Where(o => o.Kind == "activity" && o.DateSourceGroup.Length == 0).Select(o => (c, o)));
    public static IEnumerable<(PrivateConversation Conversation, PrivateOffer Offer)> Due(CareerData d)
        => All(d).Where(x => x.Offer.State == "已确认" && PrivateAppointments.Date(d, x.Offer) == d.Day);
    public static void Expire(CareerData d)
    {
        foreach (var (_, o) in All(d).Where(x => x.Offer.State == "已确认" && PrivateAppointments.Date(d, x.Offer) < d.Day)) o.State = "未赴约";
    }
    public static void Respond(CareerData d, PrivateConversation c, PrivateTurn t, Dictionary<string, string> fields)
    {
        if (!GameCalendar.NormalizeFields(d, fields)) { t.Error += "\n活动需要名称和有效日期。"; return; }
        string action = fields.GetValueOrDefault("Activity", "");
        PrivateInteractionIds.Ensure(c);
        var old = c.Offers.FirstOrDefault(o => o.Kind == "activity" && o.Id == PrivateInteractionIds.Resolve(c, fields.GetValueOrDefault("Id")));
        var attachment = ChatAttachments.Find(c, t, "activity", fields);
        if (old == null && attachment != null) old = c.Offers.FirstOrDefault(o => o.Kind == "activity" && o.Id == attachment.Id);
        if (action == "取消")
        {
            if (old != null && old.State is "待确认" or "已确认") old.State = "已取消";
            else if (old == null && attachment != null) c.Offers.Add(new() { Id = attachment.Id, Kind = "activity", TurnId = t.Id, Title = attachment.Title, Detail = attachment.Detail,
                Season = attachment.Season, Day = attachment.Day, Participants = attachment.Participants.ToList(), State = "已取消" });
            if ((old ?? attachment) is { } cancelled) ConsumerAttachments.Resolve(d, cancelled, false);
            return;
        }
        if (action is not ("邀请" or "改期" or "接受")) return;
        if (old != null && action is "邀请" or "接受") return;
        var basis = old ?? attachment;
        if (action == "接受" && basis == null && fields.GetValueOrDefault("Id", "") is "" or "0") action = "邀请";
        if (action is "接受" or "改期" && basis == null) { t.Error += "\n请在活动附件中明确本次处理的活动编号。"; return; }
        var o = new PrivateOffer { Kind = "activity", TurnId = t.Id, Title = fields.GetValueOrDefault("Title", basis?.Title ?? ""),
            Detail = fields.GetValueOrDefault("Detail", basis?.Detail ?? ""), ReplacesOfferId = old?.Id ?? "",
            ConsumerAttachmentId = basis?.ConsumerAttachmentId ?? "", ServiceId = basis?.ServiceId ?? "", WeddingServiceIds = basis?.WeddingServiceIds.ToList() ?? [], GoodId = basis?.GoodId ?? "", GoodVerb = basis?.GoodVerb ?? "", Participants = basis?.Participants.ToList() ?? [GroupChats.Human(d), c.PersonId] };
        o.Season = int.TryParse(fields.GetValueOrDefault("Season"), out int season) ? season : basis?.Season ?? -1;
        o.Day = int.TryParse(fields.GetValueOrDefault("Day"), out int day) ? day : basis?.Day ?? -1;
        if (string.IsNullOrWhiteSpace(o.Title) || o.Season < 1 || o.Day < 1 || o.Day > SeasonCalendar.Length(d, o.Season))
        { t.Error += "\n活动需要名称和有效日期。"; return; }
        if (PrivateAppointments.Date(d, o) < d.Day)
        {
            o.State = "已过期"; c.Offers.Add(o);
            t.Error += "\n" + ExpiredDate; return;
        }
        bool accepted = attachment != null && o.Title == attachment.Title && o.Detail == attachment.Detail && o.Day == attachment.Day && o.Season == attachment.Season;
        if (accepted) { o.Id = attachment!.Id; o.State = "已确认"; ConsumerAttachments.Resolve(d, o, true); }
        c.Offers.Add(o);
    }
    public static string? Confirm(CareerData d, PrivateConversation c, PrivateOffer o)
    {
        if (o.State != "待确认") return "这项活动已处理。";
        if (PrivateAppointments.Date(d, o) < d.Day) return ExpiredDate;
        if (WeddingAppointments.Error(d, o) is { } weddingError) return weddingError;
        var source = c.Turns.FirstOrDefault(t => t.Id == o.TurnId);
        var before = source == null ? null : PrivateInteractionHistory.Capture(d, c.PersonId);
        if (c.Offers.FirstOrDefault(x => x.Id == o.ReplacesOfferId) is { } old) old.State = "已改期";
        o.State = "已确认"; ConsumerAttachments.Resolve(d, o, true);
        if (source != null && before != null) PrivateInteractionHistory.Record(d, c.PersonId, source, before);
        return null;
    }
    public static string? Attend(CareerData d, PrivateOffer o, bool publicly = false, bool scene = false)
    {
        if (o.Kind != "activity" || o.State != "已确认" || PrivateAppointments.Date(d, o) != d.Day) return "这项活动当前不能赴约。";
        var people = o.Participants.Where(id => !GroupChats.IsHuman(d, id)).Distinct().ToArray();
        if (WeddingAppointments.Error(d, o) is { } weddingError) return weddingError;
        if (ConsumerCatalog.Get(o.GoodId)?.InstantActivity == true)
        { if (ConsumerAttachments.Attend(d, o, publicly) is { } paidError) return paidError; }
        else if (o.GoodId.Length > 0 && !WeddingAppointments.IsWedding(o) && ConsumerEngine.Use(d, o.GoodId, o.GoodVerb, people, publicly) is { } error) return error;
        o.PublicAttendance = publicly; o.State = "已赴约";
        if (!scene) WeddingAppointments.Complete(d, o);
        if (publicly && o.GoodId.Length == 0) PublishAttendance(d, o);
        return null;
    }
    internal static void PublishAttendance(CareerData d, PrivateOffer o)
    {
        var people = o.Participants.Where(id => !GroupChats.IsHuman(d, id)).Distinct().ToArray();
        CareerLife.AddEvent(d, GroupChats.Human(d) + "/appointment-" + o.Id, "消费与生活", o.Title + "已完成",
            $"{CareerEngine.Name(d)}与{string.Join("、", people.Select(id => CareerEngine.DisplayName(d, id)))}参加了{o.Title}。活动内容：{o.Detail}。{WeddingAppointments.Description(d, o)}活动已经完成。", [GroupChats.Human(d), .. people]);
    }
}
