namespace NationalSpire;

public sealed class PrivateProfileChange
{
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public string Field { get; set; } = "";
    public string Before { get; set; } = "";
    public string After { get; set; } = "";
    public string Reason { get; set; } = "";
}

public static class PrivateProfileChanges
{
    public static readonly string[] Fields = ["性格类型", "性格概述", "判断事情的习惯", "交往习惯", "面对压力", "玩笑偏好", "亲疏立场", "求知倾向", "打法", "说话习惯", "擅长角色"];
    public static string Label(string field) => field switch
    {
        "性格类型" => "性格", "判断事情的习惯" => "判断依据", "交往习惯" => "说话动机", "面对压力" => "受挫反应",
        "玩笑偏好" => "玩笑习惯", "亲疏立场" => "维护立场", "求知倾向" => "关注与好奇", "打法" => "打法偏好", "说话习惯" => "表达习惯", _ => field
    };
    public static string Value(CareerPerson p, string field) => field switch
    {
        "性格类型" => p.Personality.Kind, "性格概述" => p.Temperament, "判断事情的习惯" => p.Personality.Evidence,
        "交往习惯" => p.Personality.Social, "面对压力" => p.Personality.Pressure, "玩笑偏好" => p.Personality.Humor,
        "亲疏立场" => p.Personality.Loyalty, "求知倾向" => p.Personality.Curiosity, "打法" => p.Style,
        "说话习惯" => p.Voice, "擅长角色" => p.Character, _ => ""
    };
    public static bool Apply(CareerPerson p, PrivateProfileChange change)
    {
        change.Field = Fields.FirstOrDefault(f => f == change.Field || Label(f) == change.Field) ?? change.Field;
        if (!Fields.Contains(change.Field) || string.IsNullOrWhiteSpace(change.After) || change.After.Length > 1200
            || string.IsNullOrWhiteSpace(change.Reason) || p.PrivateProfileReceipts.Contains(change.Id)) return false;
        if (change.Field == "擅长角色" && !new[] { "铁甲战士", "静默猎手", "故障机器人", "亡灵契约师", "储君" }.Contains(change.After)
            && !CharacterIdentity.Source().Any(c => c.DisplayName == change.After || c.Id == change.After)) return false;
        change.Before = Value(p, change.Field);
        SetValue(p, change.Field, change.After);
        p.Personality.Version = PersonalityLibrary.Version;
        p.PrivateProfileReceipts.Add(change.Id);
        return true;
    }
    internal static void SetValue(CareerPerson p, string field, string value)
    {
        switch (field)
        {
            case "性格类型": p.Personality.Kind = value; break;
            case "性格概述": p.Temperament = value; break;
            case "判断事情的习惯": p.Personality.Evidence = value; break;
            case "交往习惯": p.Personality.Social = value; break;
            case "面对压力": p.Personality.Pressure = value; break;
            case "玩笑偏好": p.Personality.Humor = value; break;
            case "亲疏立场": p.Personality.Loyalty = value; break;
            case "求知倾向": p.Personality.Curiosity = value; break;
            case "打法": p.Style = value; break;
            case "说话习惯": p.Voice = value; break;
            case "擅长角色": p.Character = CharacterIdentity.OriginalName(value) ?? value; break;
        }
    }
    // 房主仅合并尚未执行的字段变更，不用异步请求快照覆盖整个选手资料。
    public static void Merge(CareerData data, PrivateMailbox mailbox)
    {
        foreach (var c in mailbox.Conversations.Values)
            if (CareerEngine.Person(data, c.PersonId) is { } p)
                foreach (var change in c.Turns.Where(t => t.Applied).SelectMany(t => t.ProfileChanges)) Apply(p, change);
    }
    public static string? Publish(CareerData data, string person, PrivateOffer offer)
    {
        if (offer.Kind != "publish" || offer.State != "待确认") return "这篇帖子已经处理。";
        if (!PrivateMessages.CanChat(data, person) || string.IsNullOrWhiteSpace(offer.Title) || string.IsNullOrWhiteSpace(offer.Detail)) return "帖子缺少标题或正文。";
        if (CareerEngine.Person(data, person) is { } p && SpireArbitration.Muted(p) && !p.Arbitrations.Any(r => offer.Id == "arbitration-" + r.Id && r.Upheld)) return "该角色账号已封禁。";
        string id = "private-post-" + offer.Id;
        if (!CommunityThreads.All(data).Any(p => p.Id == id))
        {
            var post = new CommunityPost { Id = id, AuthorId = person, Title = offer.Title, Body = offer.Detail,
                Day = data.Day, Category = "选手动态", PersonalPost = true, NeedsReaction = true, RelatedPeople = [person, data.LocalHumanId.Length > 0 ? data.LocalHumanId : "player"] };
            post.RelatedPeople = post.RelatedPeople.Concat(offer.RelatedPeople).Distinct().ToList();
            post.MentionedPeople = CommunityMentions.Resolve(data, post.Title + "\n" + post.Body).Concat(offer.RelatedPeople).Distinct().ToList();
            post.NewsGeneration.State = "completed";
            data.Posts.Insert(0, post); CommunityThreads.Remember(data, post); CommunityThreads.TrimFeed(data);
        }
        offer.MatchId = id; offer.State = "已确认"; return null;
    }
}
