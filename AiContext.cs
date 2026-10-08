using System.Text.Json;

namespace NationalSpire;

public static partial class AiService
{
    private static object PlayerPublicRecord(CareerData data, int day, bool includeEvidence = true) => new
    {
        gender = data.PlayerGender,
        characterCard = data.PlayerCard == null ? null : new { registeredName = data.PlayerCard.Name, data.PlayerCard.Role,
            data.PlayerCard.Style, data.PlayerCard.Biography, Personality = PersonalityLibrary.PromptProfile(data.PlayerCard.Personality), data.PlayerCard.Character },
        introduction = data.PlayerIntroductionDay <= day ? data.PlayerIntroduction : "",
        introductionAsOfDay = data.PlayerIntroductionDay <= day ? data.PlayerIntroductionDay : 0,
        worldHonors = CircuitLedger.PublicStanding(data, "player", day),
        cooperationAsOfDay = day,
        cooperation = CareerCommerce.PublicState(data, day),
        recentEvidence = data.Results.Where(r => includeEvidence && r.OfficialAscensionVerified && r.Day <= day && r.Kind != "private-friendly").TakeLast(1)
            .Select(r => new { r.Day, r.Event, r.Opponent, Character = CharacterIdentity.ForResult(r), r.Outcome, officialAscension = r.Ascension, challenge = MatchRules.ChallengeNote(r, data.CooperativeMembers > 1), cleared = r.Win,
                elapsed = MatchRules.Time(r.RunSeconds), finishEvidence = r.Evidence.ForPrompt() })
    };
    private static object? MatchContext(CareerData data, CommunityPost post)
    {
        var result = data.Results.FirstOrDefault(r => post.EventKey == "match" + r.MatchId && r.OfficialAscensionVerified);
        if (result == null) return null;
        var match = data.Matches.FirstOrDefault(m => m.Id == result.MatchId);
        var opponent = post.PeopleAtEvent.FirstOrDefault(p => p.Id == result.OpponentId);
        var previous = data.Results.TakeWhile(r => !ReferenceEquals(r, result)).Where(r => r.OfficialAscensionVerified && r.Kind != "private-friendly").ToList();
        return new
        {
            result.Event, result.Day, officialAscension = result.Ascension, challenge = MatchRules.ChallengeNote(result, data.CooperativeMembers > 1), result.Outcome, result.WorldImpact,
            cooperative = data.CooperativeMembers > 1 ? new { members = data.HumanIds.Select(id => new { id, name = CareerEngine.DisplayName(data, id), gender = IdentityGender.Of(data, id) }),
                facts = post.SourceBody, rule = "同队玩家共同爬塔，对方也是等人数队伍；通关和胜负属于整队，不能解读为个人单挑。" } : null,
            player = new { name = CareerEngine.Name(data), gender = data.PlayerGender, Character = CharacterIdentity.ForResult(result), cleared = result.Win, result.Floor, elapsed = MatchRules.Time(result.RunSeconds),
                ratingChange = result.RatingDelta, deck = result.DeckSummary.Select(GameText.Plain), keyCards = result.Cards.Take(5).Select(GameText.Plain), finishEvidence = result.Evidence.ForPrompt() },
            opponent = new { name = result.Opponent, gender = IdentityGender.Of(data, result.OpponentId), character = opponent?.Character, style = opponent?.Style, role = opponent?.Role,
                bestAscension = opponent?.MaxAscension, profileAsOfDay = opponent == null ? (int?)null : result.Day, rating = opponent?.Rating, recentForm = opponent?.Form,
                cleared = match?.OpponentWon, floor = match?.OpponentFloor, elapsed = MatchRules.Time(match?.OpponentSeconds),
                deck = (string[]?)null },
            pastMeetings = previous.Where(r => r.OpponentId == result.OpponentId).TakeLast(2).Select(r => new { r.Day, r.Event, r.Outcome, Character = CharacterIdentity.ForResult(r), r.Ascension, challenge = MatchRules.ChallengeNote(r, data.CooperativeMembers > 1), elapsed = MatchRules.Time(r.RunSeconds) }),
            previousSameCharacter = previous.Where(r => CharacterIdentity.ForResult(r) == CharacterIdentity.ForResult(result)).TakeLast(1).Select(r => new { r.Day, r.Outcome, r.Ascension, challenge = MatchRules.ChallengeNote(r, data.CooperativeMembers > 1), elapsed = MatchRules.Time(r.RunSeconds), r.Win }),
            firstClearAtThisLevel = result.Win && data.Esports.Honors.Any(h => h.Id == "clear-" + result.Ascension && h.Day == result.Day)
                && !previous.Any(r => r.Win && r.Ascension >= result.Ascension),
            recentResults = previous.TakeLast(3).Select(r => new { r.Day, r.Event, r.Opponent, r.Outcome })
        };
    }
    private static string BuildNewsContext(CareerData data, List<CommunityPost> pending)
    {
        PersonalityLibrary.EnsureAll(data);
        string occasion = "news:" + string.Join("|", pending.Select(p => p.Id).Order(StringComparer.Ordinal));
        int contextDay = pending.Max(p => p.Day);
        var persons = PromptPeople(data, pending);
        var supplied = persons.Select(p => p.Id).ToHashSet();
        var excluded = pending.Select(p => p.Id).ToHashSet();
        object NewsPerson(CareerPerson person)
        {
            int cutoff = pending.Min(p => p.Day);
            var personalPosts = pending.Where(p => p.AuthorId == person.Id || p.Replies.Any(r => r.AuthorId == person.Id));
            var snapshot = pending.Where(p => p.Day <= cutoff).SelectMany(p => p.PeopleAtEvent.Select(who => (Who: who, p.Day)))
                .FirstOrDefault(x => x.Who.Id == person.Id);
            // 历史身份、战绩仍按事件快照，当前性格重置只用于新的发言，不改写旧记录。
            return snapshot.Who == null ? Persona(data, person, occasion, cutoff, privatePosts: personalPosts)
                : Persona(data, snapshot.Who, occasion, cutoff, snapshot.Day, person.Personality, privatePosts: personalPosts);
        }
        var memories = CommunityMemorySearch.Retrieve(data, string.Join(" ", pending.Select(p => p.Title + " " + p.Body)),
            pending.SelectMany(p => p.RelatedPeople).Concat(persons.Select(p => p.Id)), contextDay, excluded);
        var posts = pending.Select(p => new
        {
            p.Id, p.AuthorId, topic = p.SourceTitle.Length > 0 ? p.SourceTitle : p.Title,
            facts = MatchContext(data, p) == null ? (p.SourceBody.Length > 0 ? p.SourceBody : p.Body) : p.RelatedFacts.Length > 0 ? p.RelatedFacts : null, eventDay = p.Day, p.Category,
            replyCount = Math.Clamp(p.Replies.Select(r => r.AuthorId).Distinct().Count(supplied.Contains), 2, 4),
            allowedAuthors = p.Replies.Select(r => r.AuthorId).Append(p.AuthorId).Distinct().Where(supplied.Contains).ToArray(),
            对玩家的态度 = ReplyAttitudes(data, p, persons.Where(person => p.Replies.Any(r => r.AuthorId == person.Id) || p.AuthorId == person.Id), occasion),
            match = MatchContext(data, p)
        }).ToArray();
        return JsonSerializer.Serialize(new
        {
            day = data.Day, season = data.Season, player = new { name = CareerEngine.Name(data), gender = data.PlayerGender },
            // 荣誉带日期，避免把后来取得的头衔写入旧新闻。
            honors = data.Esports.Honors.Where(h => h.Day <= contextDay).TakeLast(3).Select(h => new { h.Title, h.Day, h.Season }),
            seasonHistory = data.SeasonHistory.TakeLast(2).Select(s => new { s.Season, s.Rank, s.Points }),
            schedules = pending.GroupBy(p => p.Day).Select(group => PublicSchedule.ForPrompt(group.Key == data.Day
                ? PublicSchedule.Capture(data, group.SelectMany(p => p.RelatedPeople)) : group.Select(p => p.Schedule).FirstOrDefault(s => s != null))),
            playerRecord = PlayerPublicRecord(data, pending.Min(p => p.Day), !pending.Any(p => p.EventKey.StartsWith("match"))), attitudeScale = PersonalityLibrary.AttitudeScale,
            态度说明 = "涉及玩家时，采用对应帖子中面向该玩家的态度；其他话题使用人物本次态度。", people = persons.Select(NewsPerson), communityMemory = memories, posts
        }, Json);
    }
}
