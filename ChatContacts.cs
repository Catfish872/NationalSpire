using System.Globalization;
using System.Text;

namespace NationalSpire;

/// <summary>通讯列表的本地显示偏好；记录与记忆仍归原会话所有。</summary>
public sealed class ChatContactPreferences
{
    public List<string> Pinned { get; set; } = [];
    public HashSet<string> Hidden { get; set; } = [];
    public string Sort { get; set; } = "time";
    public bool Reverse { get; set; }
    public bool ShowHidden { get; set; }
    public bool ShowRelationships { get; set; } = true;
    public void Pin(string key) { if (!Pinned.Remove(key)) Pinned.Insert(0, key); }
    public void Hide(string key) { if (!Hidden.Remove(key)) Hidden.Add(key); }
}
public sealed record ChatContact(string Id, bool Group, string Name, int Favour, long Order, int Day)
{
    public string Key => Group ? "group:" + Id : Id;
}
public static class ChatContacts
{
    public readonly record struct Events(bool Match, bool Date, bool MatchToday, bool DateToday, bool Wedding = false, bool WeddingToday = false);
    public static Events PendingEvents(CareerData data, IEnumerable<PrivateConversation> conversations, IReadOnlySet<string> pendingMatches)
    {
        bool match = false, date = false, matchToday = false, dateToday = false, wedding = false, weddingToday = false;
        foreach (var c in conversations)
            foreach (var o in c.Offers)
            {
                int day = PrivateAppointments.Date(data, o);
                if (o.Kind == "match" && o.State == "已确认" && pendingMatches.Contains(o.MatchId))
                { match = true; matchToday |= day == data.Day; }
                if (o.Kind == "activity" && c.DateSceneStates.GetValueOrDefault(o.Id) != "ended"
                    && (o.State == "已确认" && day >= data.Day || o.State == "已赴约" && (day == data.Day || c.DateSceneStates.GetValueOrDefault(o.Id) is "active" or "paused")))
                {
                    if (ConsumerInvitations.IsWedding(o)) { wedding = true; weddingToday |= day == data.Day; }
                    else { date = true; dateToday |= day == data.Day; }
                }
            }
        return new(match, date, matchToday, dateToday, wedding, weddingToday);
    }
    public static Dictionary<string, Events> EventIndicators(CareerData data)
    {
        var matches = data.Matches.Where(m => m.Status == "待赛" && m.Registered).Select(m => m.Id).ToHashSet();
        var result = PrivateMessages.Mailbox(data).Conversations.ToDictionary(p => p.Key, p => PendingEvents(data, [p.Value], matches));
        string human = GroupChats.Human(data) + "/";
        foreach (var group in GroupChats.Visible(data))
            result["group:" + group.Id] = PendingEvents(data, group.Interactions.Where(p => p.Key.StartsWith(human, StringComparison.Ordinal)).Select(p => p.Value), matches);
        return result;
    }
    public static string LastChatText(int today, int day) => day <= 0 ? "" : today <= day ? "今天" : $"{today - day}天前";
    private static readonly StringComparer Names = StringComparer.Create(CultureInfo.GetCultureInfo("zh-CN"), true);
    private static readonly Encoding Chinese = ChineseEncoding();
    private static Encoding ChineseEncoding() { Encoding.RegisterProvider(CodePagesEncodingProvider.Instance); return Encoding.GetEncoding(936); }
    public static char Initial(string name)
    {
        char first = name.FirstOrDefault(char.IsLetterOrDigit);
        if (first <= 127) return char.ToUpperInvariant(first);
        byte[] bytes = Chinese.GetBytes(first.ToString());
        if (bytes.Length != 2) return first;
        int code = bytes[0] * 256 + bytes[1] - 65536;
        int[] boundaries = [-20319, -20284, -19776, -19219, -18711, -18527, -18240, -17923, -17418, -16475, -16213, -15641, -15166, -14923, -14915, -14631, -14150, -14091, -13319, -12839, -12557, -11848, -11056, -10247];
        for (int i = 0; i < boundaries.Length - 1; i++) if (code >= boundaries[i] && code < boundaries[i + 1]) return "ABCDEFGHJKLMNOPQRSTWXYZ"[i];
        return first;
    }
    public static List<ChatContact> List(CareerData data, ChatContactPreferences preferences, string filter, string query)
    {
        var box = PrivateMessages.Mailbox(data); var people = data.People.ToDictionary(p => p.Id);
        var entries = new List<ChatContact>();
        if (filter != "群聊")
        {
            var ids = query.Length > 0 ? data.People.Where(p => !GroupChats.IsHuman(data, p.Id) && (p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(query, StringComparison.OrdinalIgnoreCase))).Select(p => p.Id)
                : box.Conversations.Keys.Concat(preferences.Pinned.Where(k => !k.StartsWith("group:", StringComparison.Ordinal))).Distinct();
            foreach (string id in ids)
            {
                if (!people.TryGetValue(id, out var p) || GroupChats.IsHuman(data, id)) continue;
                var turn = box.Conversations.GetValueOrDefault(id)?.Turns.LastOrDefault(PrivateMessages.VisibleInCommunications);
                entries.Add(new(id, false, p.PublicName, box.Relations.GetValueOrDefault(id)?.Favour ?? 0, Math.Max(turn?.UserOrder ?? 0, turn?.ReplyOrder ?? 0), turn?.Day ?? 0));
            }
        }
        if (filter != "私信")
            foreach (var group in GroupChats.Visible(data).Where(g => query.Length == 0 || g.Name.Contains(query, StringComparison.OrdinalIgnoreCase) || g.Members.Any(id => GroupChats.Name(data, id).Contains(query, StringComparison.OrdinalIgnoreCase))))
            {
                var turn = group.Turns.LastOrDefault(); var entry = group.Entries.LastOrDefault();
                long order = Math.Max(Math.Max(turn?.Order ?? 0, turn?.Replies.LastOrDefault()?.Order ?? 0), entry?.Order ?? 0);
                entries.Add(new(group.Id, true, group.Name, 0, order, Math.Max(turn?.Day ?? 0, entry?.Day ?? 0)));
            }
        var pins = preferences.Pinned.Select((key, i) => (key, i)).GroupBy(p => p.key).ToDictionary(g => g.Key, g => g.First().i);
        entries = entries.Where(e => preferences.ShowHidden || !preferences.Hidden.Contains(e.Key)).ToList();
        var pinned = entries.Where(e => pins.ContainsKey(e.Key)).OrderBy(e => pins[e.Key]);
        IEnumerable<ChatContact> others = entries.Where(e => !pins.ContainsKey(e.Key));
        others = (preferences.Sort, preferences.Reverse) switch
        {
            ("favour", false) => others.Where(e => !e.Group).OrderByDescending(e => e.Favour).ThenBy(e => e.Name, Names).ThenBy(e => e.Key, StringComparer.Ordinal),
            ("favour", true) => others.Where(e => !e.Group).OrderBy(e => e.Favour).ThenBy(e => e.Name, Names).ThenBy(e => e.Key, StringComparer.Ordinal),
            ("name", false) => others.OrderBy(e => Initial(e.Name)).ThenBy(e => e.Name, Names).ThenBy(e => e.Key, StringComparer.Ordinal),
            ("name", true) => others.OrderByDescending(e => Initial(e.Name)).ThenByDescending(e => e.Name, Names).ThenBy(e => e.Key, StringComparer.Ordinal),
            ("type", _) => others.OrderBy(e => e.Group != preferences.Reverse ? 0 : 1).ThenByDescending(e => e.Order).ThenByDescending(e => e.Day).ThenBy(e => e.Name, Names).ThenBy(e => e.Key, StringComparer.Ordinal),
            (_, true) => others.OrderBy(e => e.Order).ThenBy(e => e.Day).ThenBy(e => e.Name, Names).ThenBy(e => e.Key, StringComparer.Ordinal),
            _ => others.OrderByDescending(e => e.Order).ThenByDescending(e => e.Day).ThenBy(e => e.Name, Names).ThenBy(e => e.Key, StringComparer.Ordinal)
        };
        return pinned.Concat(others).ToList();
    }
}
