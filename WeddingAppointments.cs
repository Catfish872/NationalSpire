namespace NationalSpire;

/// <summary>已接受的戒指或婚礼礼物解锁婚礼安排，赴约复用活动保存与公开事件入口。</summary>
public static class WeddingAppointments
{
    public const string GoodId = "grand-wedding";
    public static readonly GoodVerb Verb = new("wedding", "举办婚礼", 1, 0);
    private static IEnumerable<PrivateConversation> Conversations(CareerData data) => PrivateMessages.Mailbox(data).Conversations.Values
        .Concat(data.Chats.Groups.SelectMany(g => g.Interactions.Where(p => p.Key.StartsWith(GroupChats.Human(data) + "/", StringComparison.Ordinal)).Select(p => p.Value)));
    public static bool IsWedding(PrivateOffer offer) => offer.GoodId == GoodId || offer.GoodId == "oath-ring" && offer.GoodVerb == Verb.Id;
    public static IEnumerable<(string Id, string Person, long Remaining, string GoodId)> Services(CareerData data)
    {
        var offers = Conversations(data).SelectMany(c => c.Offers).ToArray();
        var used = offers.Where(o => o.Kind == "activity" && IsWedding(o) && o.ServiceId.Length > 0 && o.State is "已赴约" or "已结束")
            .GroupBy(o => o.ServiceId).ToDictionary(g => g.Key, g => g.LongCount());
        return offers.Where(o => o.Kind == "gift" && RelationshipGifts.Special(o.GoodId) && o.State == "已接受")
            .Select(o => (Id: o.GroupId + "/" + o.Id, Person: o.ActorId, Remaining: o.Quantity - used.GetValueOrDefault(o.GroupId + "/" + o.Id), GoodId: o.GoodId))
            .Where(s => s.Remaining > 0);
    }
    public static string? Error(CareerData data, PrivateOffer offer)
    {
        if (!IsWedding(offer)) return null;
        var service = Services(data).FirstOrDefault(s => s.Id == offer.ServiceId);
        var others = offer.Participants.Where(id => !GroupChats.IsHuman(data, id)).Distinct().ToArray();
        return service.Remaining > 0 && service.GoodId == offer.GoodId && others.Length == 1 && others[0] == service.Person ? null : "请选择双方已确认且尚未使用的婚礼安排。";
    }
    public static void Complete(CareerData data, PrivateOffer offer)
    {
        if (!IsWedding(offer)) return;
        foreach (string person in offer.Participants.Where(id => !GroupChats.IsHuman(data, id)).Distinct()) RelationshipPresentation.CompleteWedding(data, person);
        if (offer.PublicAttendance) SocialAppointments.PublishAttendance(data, offer);
    }
}
