namespace NationalSpire;

internal static class ContentPoolMigration
{
    internal const int Version = 2;
    internal static void Refresh(CareerData data)
    {
        if (data.ContentPoolVersion >= Version) return;
        // 已参加比赛、公开发言或进入历史资料的人物保持身份；新素材用于尚未接触的人物。
        var posts = data.Posts.Concat(data.SavedThreads).ToArray();
        var known = data.Results.Select(r => r.OpponentId)
            .Concat(data.Matches.Select(m => m.OpponentId))
            .Concat(posts.SelectMany(p => p.RelatedPeople.Concat(p.Replies.Select(r => r.AuthorId)).Concat(p.PeopleAtEvent.Select(p => p.Id)).Append(p.AuthorId)))
            .Concat(data.CommunityMemories.SelectMany(m => m.People))
            .Concat(data.WeeklyEditions.SelectMany(w => w.Profiles.Select(p => p.Id).Concat(w.Slides.SelectMany(s => s.People))))
            .ToHashSet(StringComparer.Ordinal);
        // 兼容早期缺少关联人物字段的已发表文本。
        string publicText = string.Join('\n', posts.Select(p => p.Title + p.Body + string.Join('\n', p.Replies.Select(r => r.Body))))
            + string.Join('\n', data.WeeklyEditions.SelectMany(w => w.Slides).Select(s => s.Title + s.Body));
        foreach (var person in data.People.Where(p => !p.EditedCard && p.CameoId.Length == 0 && !data.HumanIds.Contains(p.Id) && !p.Id.StartsWith("human-") && !known.Contains(p.Id) && p.AiIntroduction.Length == 0 && p.HandleAliases.Count == 0))
        {
            if (person.PublicName.Length > 0 && publicText.Contains(person.PublicName, StringComparison.Ordinal)) continue;
            if (PlayerIdentity.Eligible(person))
            { if (person.Handle.Length > 0) person.HandleAliases.Add(person.Handle); person.Handle = ""; }
            else if (person.Role == "普通玩家")
            { string old = person.Name; person.Name = WorldPeople.Name(data, person.Id, person.Country, true); if (person.Name != old) person.HandleAliases.Add(old); }
            if (data.ContentPoolVersion >= 1) continue;
            int seed = CareerEngine.StableHash(data.WorldId + ":expanded-profile:" + person.Id);
            person.Biography = WorldPeople.Biography(person.Role, seed);
            int character = Array.IndexOf(new[] { "铁甲战士", "静默猎手", "故障机器人", "亡灵契约师", "储君" }, person.Character);
            if (character >= 0) person.Style = WorldPeople.PlayingStyle(character, seed);
            person.Personality.Version = 0;
            PersonalityLibrary.Ensure(data, person);
        }
        data.ContentPoolVersion = Version;
    }
}
