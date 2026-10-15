namespace NationalSpire;

/// <summary>
/// 投票用的「环境事实」提取。
///
/// **程序只提供事实，不给分、不预测票数。**
/// 票数由模型在生成帖子的同一次请求里给出 —— 因为投票选项是自由文本，
/// 程序解析不全，硬算会失准。
///
/// 另一个约束：投票者与读者都是 AI，只有数据、没看过对局过程。
/// 所以事实必须来自「可见数据」，不能要求看过过程。
///
/// 成本只与**选项数**有关（2–8），与人口无关；不调用模型、不增加请求。
/// </summary>
public static class PollFacts
{
    private const int MaxNameLen = 24;

    /// <summary>拼出注入提示词的事实块。没有可查事实时返回空串。</summary>
    public static string Describe(CareerData d, CommunityPoll poll)
        => Describe(d, poll.Question, poll.Options, null);

    public static string Describe(CareerData d, string question, List<string> options, CareerMatch? match)
    {
        var lines = new List<string> { "【本次投票的环境事实】程序查得，供判断票数时参照，不要照抄数字：", "问题：" + question };

        if (match != null) lines.AddRange(MatchContext(d, match));
        foreach (var option in options) lines.Add(FactOf(d, option, match != null));

        return string.Join('\n', lines);
    }

    // ---------- 单个选项 ----------

    private static string FactOf(CareerData d, string option, bool hasMatchCtx)
    {
        var text = option ?? "";

        if (FindPerson(d, text) is { } p)
        {
            var bits = new List<string>();
            if (p.Country.Length > 0) bits.Add(p.Country);
            if (p.Role.Length > 0) bits.Add(p.Role);
            if (p.Rating > 0) bits.Add("评分" + p.Rating);
            if (p.MaxAscension > 0) bits.Add("进阶" + p.MaxAscension);
            if (p.Wins + p.Losses > 0) bits.Add($"{p.Wins}胜{p.Losses}负");
            var form = p.Form.Length > 0 ? $"近{p.Form.Length}场{p.Form}" : "近期无正式比赛";
            bits.Add(form);
            var club = EsportsWorld.ClubName(d, p.ClubId);
            if (club != "自由选手") bits.Add("效力" + club);
            return $"- {option} → 人物：{string.Join('，', bits)}";
        }

        foreach (var country in EsportsWorld.Countries)
        {
            if (!ContainsWord(text, country, ["人", "系", "玩家", "选手", "们"])) continue;
            var fortune = CircuitLedger.Fortune(d, country);
            var rank = CircuitLedger.NationTable(d).FindIndex(x => x.Country == country) + 1;
            return $"- {option} → 国家：国运 {fortune}（第 {rank} 名）";
        }

        // 角色名从数据本身取，不硬编码——人物卡的 Character 字段就是角色
        var characters = d.People.Select(p => p.Character)
                                 .Where(c => !string.IsNullOrEmpty(c))
                                 .Distinct(StringComparer.Ordinal).ToList();
        foreach (var character in characters)
        {
            if (!ContainsWord(text, character, ["人", "系", "玩家", "们"])) continue;
            var mains = d.People.Where(p => p.Character == character).ToList();
            var avg = mains.Count > 0 ? mains.Average(p => p.MaxAscension) : 0;
            return $"- {option} → 角色：社区 {mains.Count} 人主玩，平均进阶 {avg:0.0}";
        }

        if (FindClub(d, text) is { } club2)
        {
            var members = d.People.Count(p => p.ClubId == club2.Id);
            var fans = d.People.Count(p => p.SupportedClubId == club2.Id);
            var best = d.People.Where(p => p.ClubId == club2.Id).Select(p => p.Rating).DefaultIfEmpty(0).Max();
            return $"- {option} → 俱乐部：{members} 名成员，支持者 {fans} 人，最高评分 {best}";
        }

        return $"- {option} → " + (hasMatchCtx ? "见上方本场事实" : "（无可查事实）");
    }

    // ---------- 比赛上下文 ----------

    /// <summary>
    /// 「这把该不该抬进阶」「这场谁会赢」这类要读帖子关联的那场比赛。
    /// 核心是**双方评分对比**，它正是判断势均力敌与否的依据。
    /// </summary>
    private static IEnumerable<string> MatchContext(CareerData d, CareerMatch m)
    {
        var opponent = CareerEngine.Person(d, m.OpponentId);
        yield return $"· 本场：{m.Event}（{EsportsWorld.StageName(m.Kind)}），第 {m.Day} 天";
        yield return $"· 赛事要求进阶 {m.RequiredAscension}"
                   + (m.PlayedAscension != null ? $"，实际参赛进阶 {m.PlayedAscension}" : "，尚未确定参赛进阶");

        var mine = d.PlayerCard?.Rating ?? d.Rating;
        var bits = new List<string> { "评分" + mine };
        if (d.Esports.BestClear > 0) bits.Add("最高进阶" + d.Esports.BestClear);
        if (d.Esports.WinStreak > 0) bits.Add("连胜" + d.Esports.WinStreak);
        var recent = RecentForm(d, 5);
        if (recent.Length > 0) bits.Add($"近{recent.Length}场{recent}");
        yield return $"· 玩家 {CareerEngine.Name(d)}：{string.Join('，', bits)}";

        if (opponent != null)
        {
            var obits = new List<string>();
            if (opponent.Country.Length > 0) obits.Add(opponent.Country);
            if (opponent.Rating > 0) obits.Add("评分" + opponent.Rating);
            if (opponent.MaxAscension > 0) obits.Add("进阶" + opponent.MaxAscension);
            obits.Add(opponent.Form.Length > 0 ? $"近{opponent.Form.Length}场{opponent.Form}" : "近期无正式比赛");
            yield return $"· 对手 {opponent.PublicName}：{string.Join('，', obits)}";

            var theirs = opponent.Rating;
            if (theirs > 0)
                yield return $"· 评分对比：玩家 {mine} vs 对手 {theirs}，"
                           + (mine > theirs ? $"玩家高 {mine - theirs}" : mine < theirs ? $"玩家低 {theirs - mine}" : "持平");
        }
        else
        {
            yield return $"· 对手：{m.OpponentId}（档案暂缺）";
        }
    }

    /// <summary>玩家近 N 场战绩。PlayerCard.Form 为空，只能从赛果算。</summary>
    public static string RecentForm(CareerData d, int n)
    {
        var tail = d.Results.TakeLast(n).ToList();
        return string.Concat(tail.Select(r => r.Win ? "胜" : "负"));
    }

    // ---------- 名字与整词匹配 ----------

    /// <summary>
    /// 按名字找人。
    ///
    /// 关键：**同一起始位置取最长的名字**。
    /// 「罗明」是「罗明辉」的前缀，若先命中短名就会认错人。
    /// </summary>
    public static CareerPerson? FindPerson(CareerData d, string text)
    {
        if (string.IsNullOrEmpty(text)) return null;
        var limit = Math.Min(text.Length, MaxNameLen);
        for (int i = 0; i < limit; i++)
        {
            CareerPerson? best = null; int bestLen = 0;
            foreach (var p in d.People)
            {
                foreach (var name in new[] { p.Handle, p.Name })
                {
                    if (string.IsNullOrEmpty(name) || name.Length < 2 || name.Length <= bestLen) continue;
                    if (i + name.Length > text.Length) continue;
                    if (string.CompareOrdinal(text, i, name, 0, name.Length) != 0) continue;
                    best = p; bestLen = name.Length;
                }
            }
            if (best != null) return best;
        }
        return null;
    }

    /// <summary>整词匹配，排除「中国人」「猎人系」这类无关词组。</summary>
    private static bool ContainsWord(string text, string word, string[] suffixes)
    {
        int from = 0;
        while (true)
        {
            int at = text.IndexOf(word, from, StringComparison.Ordinal);
            if (at < 0) return false;
            int after = at + word.Length;
            bool blocked = false;
            foreach (var s in suffixes)
                if (after + s.Length <= text.Length && string.CompareOrdinal(text, after, s, 0, s.Length) == 0)
                { blocked = true; break; }
            if (!blocked) return true;
            from = at + 1;
        }
    }

    private static CareerClub? FindClub(CareerData d, string text)
        => d.Esports.Clubs.FirstOrDefault(c => c.Name.Length > 0 && text.Contains(c.Name, StringComparison.Ordinal));
}
