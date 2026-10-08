namespace NationalSpire;

public static class CareerMigration
{
    public static void UpgradeRules(CareerData data)
    {
        // 只清理旧版本误存的固定写作指令，保留战报事实与人物发言。
        foreach (var post in data.Posts.Concat(data.SavedThreads))
        {
            post.SourceBody = post.SourceBody.Replace("胜负属于整队，不能写成几场个人单挑。", "");
            post.RelatedFacts = post.RelatedFacts.Replace("胜负属于整队，不能写成几场个人单挑。", "");
        }
        foreach (var memory in data.CommunityMemories)
            memory.Text = memory.Text.Replace("胜负属于整队，不能写成几场个人单挑。", "");
        if (data.Version >= 4) return;
        if (!data.Esports.Initialized && data.Results.Any(r => r.Win && r.Ascension >= 8))
            data.Esports.License = Math.Max(data.Esports.License, 3);
        foreach (var result in data.Results)
        {
            var match = data.Matches.FirstOrDefault(m => m.Id == result.MatchId);
            result.PlayedAscension ??= match?.PlayedAscension ?? result.Ascension;
            int? official = match?.RequiredAscension ?? result.Kind switch
            {
                "local" => 0, "city" => 3, "academy" => 6, "league" => 8,
                "masters" => 10, "continental" or "worldcup" => (result.Day - 1) % SeasonCalendar.ShortLength + 1 == 26 ? 9 : 8, _ => null
            };
            result.OfficialAscensionVerified = official.HasValue;
            if (official.HasValue) result.Ascension = official.Value;
            // 旧战报没有可靠计时，不重新裁定胜负，也不追溯发放挑战奖励。
            var post = data.Posts.FirstOrDefault(p => p.EventKey == "match" + result.MatchId);
            if (post != null && match != null) post.Body = MatchRules.Report(match, result);
        }
        data.Esports.BestClear = data.Results.Where(r => r.Win && r.OfficialAscensionVerified && !PrivateAppointments.IsPrivate(r)).Select(r => r.Ascension).DefaultIfEmpty(-1).Max();
        data.Esports.Honors.RemoveAll(h => h.Id.StartsWith("clear-"));
        data.Esports.Milestones.RemoveAll(id => id.StartsWith("clear-"));
        foreach (var result in data.Results.Where(r => r.Win && r.OfficialAscensionVerified && r.Ascension >= 8).DistinctBy(r => r.Ascension))
        {
            string id = "clear-" + result.Ascension;
            data.Esports.Milestones.Add(id);
            data.Esports.Honors.Add(new CareerHonor { Id = id, Title = $"进阶 {result.Ascension} 通关认证", Day = result.Day,
                Season = Math.Max(1, (result.Day - 1) / SeasonCalendar.ShortLength + 1), Detail = "根据赛事规定进阶核实的通关履历。" });
        }
        // 旧社区可能引用实际挑战进阶；完整旧讨论保留在升级备份中。
        data.Posts.RemoveAll(p => p.EventKey.StartsWith("honor-clear-") || p.EventKey.StartsWith("match")
            && !data.Results.Any(r => r.OfficialAscensionVerified && p.EventKey == "match" + r.MatchId));
        foreach (var post in data.Posts)
        {
            post.Analysis = "";
            var match = data.Matches.FirstOrDefault(m => post.EventKey == "match" + m.Id);
            foreach (var reply in post.Replies)
                if (CareerEngine.Person(data, reply.AuthorId) is { } person)
                    reply.Body = CareerNarrative.Reply(data, person, post.Category, match, CareerEngine.StableHash(post.Id + person.Id));
        }
        data.Version = 4;
    }
}
