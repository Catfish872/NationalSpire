namespace NationalSpire;

/// <summary>群聊日程保留原记录；专用私信场景以唯一来源引用承载共同约会轮次。</summary>
public static class DateGroupBridge
{
    private static bool IsOpen(PrivateOffer offer) => offer.State is "已确认" or "已赴约";
    private static PrivateOffer? Source(CareerData data, PrivateOffer proxy) => data.Chats.Groups
        .FirstOrDefault(g => g.Id == proxy.DateSourceGroup)?.Interactions.Values.SelectMany(c => c.Offers)
        .FirstOrDefault(o => o.Id == proxy.DateSourceOffer && o.Kind == "activity");
    public static bool SourceActive(CareerData data, PrivateOffer proxy) => proxy.DateSourceGroup.Length == 0
        || Source(data, proxy) is { } source && IsOpen(source);
    public static (PrivateConversation Conversation, PrivateOffer Offer)? Find(CareerData data, string group, string source)
    {
        foreach (var c in PrivateMessages.Mailbox(data).Conversations.Values)
            if (c.Offers.FirstOrDefault(o => o.DateSourceGroup == group && o.DateSourceOffer == source) is { } offer) return (c, offer);
        return null;
    }
    public static string? Begin(CareerData data, GroupChat group, PrivateOffer source)
    {
        if (source.Kind != "activity" || !source.Participants.Contains(GroupChats.Human(data))) return "需要参加这项活动才能进入约会。";
        var people = source.Participants.Where(p => !GroupChats.IsHuman(data, p) && CareerEngine.Person(data, p) != null).Distinct().ToList();
        if (people.Count == 0) return "这项活动尚无NPC参加者。";
        if (Find(data, group.Id, source.Id) is { } existing)
            return DateScenes.Available(data, existing.Offer, existing.Conversation) ? null : "这场约会已经结束。";
        if (source.State == "已确认")
        { if (SocialAppointments.Attend(data, source, scene: true) is { } error) return error; }
        else if (source.State != "已赴约" || PrivateAppointments.Date(data, source) != data.Day) return "请在约定当天赴约。";
        string host = people.Contains(source.ActorId) ? source.ActorId : people[0];
        var proxy = Coop.CoopJson.Copy(source);
        proxy.DateSourceGroup = group.Id; proxy.DateSourceOffer = source.Id;
        proxy.Id = "group-date-" + group.Id + "-" + source.Id; proxy.GroupId = ""; proxy.ActorId = host;
        proxy.TurnId = "";
        PrivateMessages.Conversation(data, host).Offers.Add(proxy);
        return null;
    }
    public static void Sync(CareerData data, PrivateOffer proxy)
    {
        if (proxy.DateSourceGroup.Length == 0) return;
        var group = data.Chats.Groups.FirstOrDefault(g => g.Id == proxy.DateSourceGroup);
        var source = Source(data, proxy);
        if (source != null && IsOpen(source)) { source.State = proxy.State; source.Participants = proxy.Participants.ToList(); group!.Revision++; }
    }
    public static void Merge(CareerData world, CareerData view)
    {
        var proxies = PrivateMessages.Mailbox(view).Conversations.Values.SelectMany(c => c.Offers)
            .Where(o => o.DateSourceGroup.Length > 0).GroupBy(o => o.DateSourceGroup);
        foreach (var references in proxies)
        {
            var source = view.Chats.Groups.FirstOrDefault(g => g.Id == references.Key);
            var target = world.Chats.Groups.FirstOrDefault(g => g.Id == references.Key);
            if (source == null || target == null || source.Revision <= target.Revision || !target.Members.Contains(GroupChats.Human(view))) continue;
            bool changed = false;
            foreach (var proxy in references)
            {
                var from = source.Interactions.Values.SelectMany(c => c.Offers).FirstOrDefault(o => o.Id == proxy.DateSourceOffer && o.Kind == "activity");
                var to = target.Interactions.Values.SelectMany(c => c.Offers).FirstOrDefault(o => o.Id == proxy.DateSourceOffer && o.Kind == "activity");
                // 群聊版本包含其他聊天操作；较新版本仍可能携带已经失效的本地场景副本。
                if (from == null || to == null || !IsOpen(to) || from.State != proxy.State || !from.Participants.SequenceEqual(proxy.Participants)) continue;
                if (to.State == from.State && to.Participants.SequenceEqual(from.Participants)) continue;
                to.State = from.State; to.Participants = from.Participants.ToList(); changed = true;
            }
            if (changed) target.Revision++;
        }
    }
}
