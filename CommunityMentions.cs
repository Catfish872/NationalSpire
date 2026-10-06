namespace NationalSpire;

public static class CommunityMentions
{
    public static string Token(CareerData data, CareerPerson person) => "@" + person.PublicName
        + (data.People.Count(p => p.PublicName == person.PublicName) > 1 ? "〔" + person.Id + "〕" : "");
    public static List<string> Resolve(CareerData data, string text)
    {
        var candidates = data.People.Where(p => !CommunityThreads.IsHuman(data, p.Id) && !SpireArbitration.Muted(p))
            .SelectMany(p => p.HandleAliases.Append(p.Name).Append(p.PublicName).Where(n => n.Length > 0)
                .Select(n => (p.Id, Token: "@" + n)).Append((p.Id, Token: Token(data, p))))
            .Distinct().OrderByDescending(p => p.Token.Length).ToArray();
        var result = new List<string>();
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] != '@') continue;
            foreach (var p in candidates)
            {
                if (!text.AsSpan(i).StartsWith(p.Token, StringComparison.OrdinalIgnoreCase)) continue;
                int end = i + p.Token.Length;
                if (end < text.Length && char.IsAsciiLetterOrDigit(text[end])) continue;
                if (!result.Contains(p.Id)) result.Add(p.Id);
                i = end - 1; break;
            }
        }
        return result;
    }
    public static List<string> Required(CommunityPost post, ISet<string> requested) =>
        (requested.Contains(post.Id) ? post.MentionedPeople : [])
        .Concat(post.Replies.Where(r => requested.Contains(r.Id)).SelectMany(r => r.MentionedPeople)).Distinct().ToList();
}
