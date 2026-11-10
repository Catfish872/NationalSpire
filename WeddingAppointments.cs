namespace NationalSpire;

/// <summary>已接受的戒指或婚礼礼物解锁婚礼安排，赴约复用活动保存与公开事件入口。</summary>
public static class WeddingAppointments
{
    public const string GoodId = "grand-wedding";
    public static readonly GoodVerb Verb = new("wedding", "举办婚礼", 1, 0);
    private static IEnumerable<PrivateConversation> Conversations(CareerData data) => PrivateMessages.Mailbox(data).Conversations.Values
        .Concat(data.Chats.Groups.SelectMany(g => g.Interactions.Where(p => p.Key.StartsWith(GroupChats.Human(data) + "/", StringComparison.Ordinal)).Select(p => p.Value))).Distinct();
    public static bool IsWedding(PrivateOffer offer) => offer.GoodId == GoodId || offer.GoodId == "oath-ring" && offer.GoodVerb == Verb.Id;
    public static string[] ServiceIds(PrivateOffer offer) => offer.WeddingServiceIds.Count > 0
        ? offer.WeddingServiceIds.ToArray() : offer.ServiceId.Length > 0 ? [offer.ServiceId] : [];
    private static IEnumerable<PrivateOffer> Accepted(CareerData data) => Conversations(data).SelectMany(c => c.Offers)
        .Where(o => o.Kind == "gift" && RelationshipGifts.Special(o.GoodId) && o.State == "已接受");
    public static string[] Partners(CareerData data, PrivateOffer offer)
    {
        if (!IsWedding(offer)) return [];
        var ids = ServiceIds(offer).ToHashSet();
        return Accepted(data).Where(o => ids.Contains(o.GroupId + "/" + o.Id)).Select(o => o.ActorId).Distinct().ToArray();
    }
    public static string Description(CareerData data, PrivateOffer offer) => IsWedding(offer)
        ? "结婚对象：" + CareerEngine.Name(data) + "与" + string.Join("、", Partners(data, offer).Select(id => GroupChats.Name(data, id))) + "；其余同行者作为宾客参加。" : "";
    public static IEnumerable<(string Id, string Person, long Remaining, string GoodId)> Services(CareerData data)
    {
        var offers = Conversations(data).SelectMany(c => c.Offers).ToArray();
        var used = offers.Where(o => o.Kind == "activity" && o.DateSourceGroup.Length == 0 && IsWedding(o) && o.State is "已赴约" or "已结束")
            .SelectMany(o => ServiceIds(o).Distinct()).GroupBy(id => id).ToDictionary(g => g.Key, g => g.LongCount());
        return offers.Where(o => o.Kind == "gift" && RelationshipGifts.Special(o.GoodId) && o.State == "已接受")
            .Select(o => (Id: o.GroupId + "/" + o.Id, Person: o.ActorId, Remaining: o.Quantity - used.GetValueOrDefault(o.GroupId + "/" + o.Id), GoodId: o.GoodId))
            .Where(s => s.Remaining > 0);
    }
    public static IEnumerable<(string Id, string Person, long Remaining, string GoodId)> ForParticipants(CareerData data, IEnumerable<string> participants)
    {
        var people = participants.ToHashSet(StringComparer.Ordinal);
        return Services(data).Where(service => people.Contains(service.Person));
    }
    public static string? Error(CareerData data, PrivateOffer offer)
    {
        if (!IsWedding(offer)) return null;
        var ids = ServiceIds(offer);
        if (ids.Length == 0 || ids.Distinct().Count() != ids.Length || ids[0] != offer.ServiceId) return "请选择结婚对象及各自已确认的婚礼服务。";
        var services = Services(data).ToDictionary(s => s.Id);
        var partners = new HashSet<string>();
        foreach (string id in ids)
        {
            if (!services.TryGetValue(id, out var service) || service.Remaining <= 0 || !offer.Participants.Contains(service.Person)
                || CareerEngine.Person(data, service.Person) == null || !partners.Add(service.Person)
                || id == offer.ServiceId && service.GoodId != offer.GoodId) return "每位结婚对象需要一份已确认且尚未使用的婚礼服务，并参加本次婚礼。";
        }
        return null;
    }
    public static void Complete(CareerData data, PrivateOffer offer)
    {
        if (!IsWedding(offer)) return;
        // 各份服务的接受者共同缔结誓约，参与名单中的其他人物保留宾客身份。
        foreach (string person in Partners(data, offer).Where(offer.Participants.Contains)) RelationshipPresentation.CompleteWedding(data, person);
        if (offer.PublicAttendance) SocialAppointments.PublishAttendance(data, offer);
    }
}
