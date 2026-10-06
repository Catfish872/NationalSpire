namespace NationalSpire;

public static class CareerNarrative
{
    public static List<CareerPerson> Audience(CareerData d, string key, string category, CareerMatch? match, List<string>? related)
    {
        var subject = related?.Select(id => CareerEngine.Person(d, id)).FirstOrDefault(p => p != null);
        string country = subject?.Country ?? d.Esports.Country;
        var competition = d.Esports.Competitions.FirstOrDefault(c => c.Id == match?.CompetitionId
            || key == "champion-" + c.Id || key.StartsWith("roundup-" + c.Id + "-"));
        if (!string.IsNullOrEmpty(competition?.Country)) country = competition.Country;
        bool international = match?.Kind is "continental" or "worldcup" or "worldfinal" or "masters"
            || category == "国际赛事" || key.StartsWith("draw-") || key.StartsWith("international-entry-");
        string kind = match?.Kind ?? (key == "honor-license-1" ? "local" : key == "honor-license-2" ? "city" : "");
        return d.People.Where(p => p.Id != "desk" && !SpireArbitration.Muted(p) && !d.HumanIds.Contains(p.Id) && (international || p.Country == country)
            && (kind != "local" || p.Role == "普通玩家")
            && (kind != "city" || p.Role is "普通玩家" or "青训选手")
            && (category != "训练日常" || subject?.Role != "普通玩家" || p.Role == "普通玩家")).ToList();
    }
    public static string PostAuthor(CareerData d, string key, string category, CareerMatch? match, List<string>? related)
    {
        var pool = NewsAudience(d, key, category, match, related);
        if (category == "训练日常" && related?.FirstOrDefault() is { } id && pool.Any(p => p.Id == id)) return id;
        if (category is "赛事公告" or "赛季" || key.StartsWith("draw-") || key.StartsWith("contract-")) return "desk";
        return pool.OrderBy(p => CareerEngine.StableHash(key + ":poster:" + p.Id)).FirstOrDefault()?.Id ?? "desk";
    }
    public static List<CareerPerson> NewsAudience(CareerData d, string key, string category, CareerMatch? match, List<string>? related)
    {
        var subjects = (related ?? []).Append(match?.OpponentId ?? "").ToHashSet();
        var recent = d.Posts.Take(4).SelectMany(p => p.Replies.Select(r => r.AuthorId).Append(p.AuthorId)).ToHashSet();
        return Audience(d, key, category, match, related).Where(p =>
        {
            if (!subjects.Contains(p.Id)) return true;
            // 与事件相关代表受到关注；是否本人出现在评论区另行决定，并随事件保存。
            int chance = EsportsWorld.IsProfessional(p) ? 35 : p.Role == "青训选手" ? 45 : 55;
            if (recent.Contains(p.Id)) chance -= 15;
            return CareerEngine.StableHash($"{d.WorldId}:{key}:attendance:{p.Id}") % 100 < chance;
        }).ToList();
    }
    public static string Feature(CareerData d, CareerPerson p)
    {
        string opening = (CareerEngine.StableHash(d.WorldId + p.Id) % 3) switch
        {
            0 => $"{EsportsWorld.ClubName(d, p.ClubId)}的{p.PublicName}常用{p.Character}，{p.Style}。",
            1 => $"谈到{p.Country}赛区的{p.PublicName}，观众最熟悉的还是{p.Character}：{p.Style}。",
            _ => $"本期关注{p.PublicName}。这位来自{p.Country}的选手目前效力于{EsportsWorld.ClubName(d, p.ClubId)}，惯用{p.Character}。"
        };
        return opening + $"公开履历中的最高通关进阶为 {p.MaxAscension}。" + (p.Form.Length > 0 ? $"最近的正式赛果为{p.Form}，下一场的发挥值得关注。" : "新赛季的正式比赛还未留下足够的战报，赛场表现仍待观察。");
    }
    private static string PublicNameText(string text, CareerData? data = null)
    {
        string name = data == null ? CareerEngine.PlayerName : CareerEngine.Name(data);
        // 先保护已写入的昵称，避免昵称本身包含“你”时误改。
        return text.Replace(name, "\uE000").Replace("你", name).Replace("\uE000", name);
    }
    public static string NewsBody(string body, CareerData? data = null)
    {
        body = System.Text.RegularExpressions.Regex.Replace(body, @"\s*关注\s*\+\d+[，,]\s*奖金\s*\+\d+。?", "");
        body = System.Text.RegularExpressions.Regex.Replace(body, @"[^。！？]*(?:与你|你的交手档案|从你的角度|你对这位选手|双方尚无正式对阵记录)[^。！？]*[。！？]?", "");
        body = body.Replace("你现在是", "选手你取得资格：")
            .Replace("前往赛事中心确认报名，代表", "确认报名后可代表")
            .Replace("签表可在电竞世界查看，", "签表现已公开，")
            .Replace("后续轮次自动报名", "晋级者将进入下一轮")
            .Replace("签约奖励已经到账", "双方已确认签约")
            .Replace("收官奖励", "赛季奖金")
            .Replace("本赛季尚未进入职业联赛。新赛季仍可参加选拔，已经取得的资格与荣誉继续保留。", "你本赛季未参加职业联赛，后续参赛安排有待公布。")
            .Replace("已取得的资格、俱乐部合同与荣誉将延续至新赛季。", "新赛季的席位竞争即将开始。");
        return PublicNameText(body, data).Trim();
    }
    public static bool RepairNews(CareerData data)
    {
        bool changed = false;
        foreach (var post in data.Posts.Where(p => p.EditorialVersion < 1 && p.AuthorId == "desk"))
        {
            post.Title = PublicNameText(post.Title, data);
            post.Body = NewsBody(post.Body, data);
            if (post.Analysis.Length == 0)
            {
                var match = data.Matches.FirstOrDefault(m => post.EventKey == "match" + m.Id);
                var audience = Audience(data, post.EventKey, post.Category, match, post.RelatedPeople);
                var used = new HashSet<string>();
                var authors = new HashSet<string>();
                foreach (var reply in post.Replies)
                {
                    if (audience.Any(p => p.Id == reply.AuthorId) && authors.Add(reply.AuthorId)) continue;
                    var person = audience.Where(p => !authors.Contains(p.Id)).OrderBy(p => CareerEngine.StableHash(post.Id + p.Id)).FirstOrDefault();
                    if (person == null) continue;
                    reply.AuthorId = person.Id; authors.Add(person.Id);
                    reply.Body = FreshReply(data, person, post.Category, match, CareerEngine.StableHash(post.Id + person.Id), post.EventKey, used);
                }
                post.AuthorId = PostAuthor(data, post.EventKey, post.Category, match, post.RelatedPeople);
                int count = 2 + CareerEngine.StableHash(post.Id) % 5;
                post.Replies = post.Replies.Take(count).ToList();
                foreach (var person in audience.Where(p => post.Replies.All(r => r.AuthorId != p.Id)).OrderBy(p => CareerEngine.StableHash(post.Id + p.Id)))
                {
                    if (post.Replies.Count >= count) break;
                    post.Replies.Add(new CommunityReply { AuthorId = person.Id, Body = FreshReply(data, person, post.Category, match, CareerEngine.StableHash(post.Id + person.Id), post.EventKey, used) });
                }
            }
            post.EditorialVersion = 1; changed = true;
        }
        return changed;
    }
    private static string Pick(string key, int seed) => NarrativeText.Pick(key, seed);
    public static string Evaluation(CareerData d, CareerPerson p)
    {
        if (!EsportsWorld.IsProfessional(p)) return "";
        int stable = CareerEngine.StableHash(d.WorldId + p.Id);
        int current = CareerEngine.StableHash(p.Id + p.Form + p.Wins + ":" + p.Losses);
        var duel = d.Esports.Duels.FirstOrDefault(x => x.PersonId == p.Id);
        string club = EsportsWorld.ClubName(d, p.ClubId);
        string introduction = (stable % 4) switch
        {
            0 => $"{p.PublicName}来自{p.Country}，目前效力于{club}。",
            1 => $"在{club}的阵容中，{p.PublicName}偏爱使用{p.Character}。",
            2 => $"{p.PublicName}的职业身份属于{club}，惯用角色是{p.Character}。",
            _ => $"{club}选手{p.PublicName}，来自{p.Country}赛区。"
        };
        string form = p.Form.Length == 0 ? (current % 4) switch
        {
            0 => "暂时没有近期正式比赛记录。", 1 => "新阶段的正式成绩还有待赛程展开。",
            2 => "近期状态尚缺少正式比赛作为依据。", _ => "目前还不能从近期赛果判断状态。"
        } : (current % 4) switch
        {
            0 => $"最近的正式赛果依次为{p.Form}。", 1 => $"近期状态记录：{p.Form}。",
            2 => $"最近{p.Form.Length}场正式比赛留下了{p.Form}的成绩。", _ => $"从最近的{p.Form}来看，后续发挥仍值得关注。"
        };
        string relationship = duel == null ? (stable % 4) switch
        {
            0 => "尚未与你正式交手。", 1 => "你的交手档案中还没有这位选手。", 2 => "双方尚无正式对阵记录。", _ => "第一次与你同场竞争仍有待赛程安排。"
        } : (current % 4) switch
        {
            0 => $"与你交手：你{duel.Wins}胜{duel.Draws}平{duel.Losses}负。",
            1 => $"双方交手记录中，你取得{duel.Wins}胜、{duel.Draws}平、{duel.Losses}负。",
            2 => $"从你的角度统计，历史交手为{duel.Wins}胜{duel.Draws}平{duel.Losses}负。",
            _ => $"你对这位选手的正式成绩是{duel.Wins}胜{duel.Draws}平{duel.Losses}负。"
        };
        return introduction + Pick("profile.trait", stable / 7) + "。" + Pick(p.MaxAscension >= 10 ? "profile.a10" : p.MaxAscension >= 9 ? "profile.a9" : "profile.a8", stable / 13) + form + relationship;
    }
    public static string PlayerEvaluation(CareerData d)
    {
        string tier = d.Esports.Honors.Any(h => h.Id.StartsWith("worldcup-") || h.Id.StartsWith("worldfinal-")) ? "world"
            : d.Esports.Honors.Any(h => h.Id.StartsWith("continental-")) ? "club"
            : d.Esports.BestClear >= 10 ? "a10" : d.Esports.BestClear >= 9 ? "a9"
            : d.Esports.WinStreak >= 3 ? "streak" : d.Esports.License >= 3 ? "pro" : d.Esports.License > 0 ? "youth" : "new";
        int seed = CareerEngine.StableHash(d.WorldId + ":player:" + d.Wins + ":" + d.Losses + ":" + d.Esports.Honors.Count);
        return Pick("player." + tier, seed).Replace("{streak}", d.Esports.WinStreak.ToString());
    }
    private static string Bank(CareerData d, CareerPerson p, string category, CareerMatch? match, int variant, string eventKey)
    {
        if (match != null)
        {
            if (match.Status == "退赛") return "withdraw";
            if (p.Id == match.OpponentId) return match.Draw ? "opponent.draw" : match.PlayerWon ? "opponent.loss" : "opponent.win";
            if (match.Decider.Contains("种子顺位")) return match.PlayerWon ? "seed.win" : "seed.loss";
            if (match.Draw) return "draw";
            if (match.OpponentWon && d.Results.Any(r => r.MatchId == match.Id && r.Win) && variant % 3 != 0) return match.PlayerWon ? "speed.win" : "speed.loss";
            if (!match.PlayerWon) return "loss";
            bool clear = d.Results.Any(r => r.MatchId == match.Id && r.Win);
            if (clear && match.RequiredAscension >= 9 && variant % 3 == 0) return match.RequiredAscension >= 10 ? "a10" : "a9";
            if (match.Kind is "continental" or "worldcup" && variant % 3 == 1)
                return match.Round == (match.Kind == "worldcup" ? 3 : 4) ? "final.win" : "international.win";
            if (d.Esports.Duels.Any(x => x.PersonId == match.OpponentId && x.Wins >= 2) && variant % 4 == 0) return "repeat.win";
            if (d.Wins == 1 && variant % 3 == 2) return "first.win";
            return EsportsWorld.IsProfessional(p) ? "win.pro" : p.Role == "青训选手" ? "win.youth" : "win.fan";
        }
        if (eventKey.StartsWith("champion-")) return "champion";
        if (eventKey.StartsWith("league-entry-") || eventKey.StartsWith("international-entry-")) return "entry";
        if (eventKey.StartsWith("draw-")) return "bracket";
        if (eventKey.StartsWith("knockout-") || eventKey.StartsWith("roundup-")) return "round";
        if (eventKey.StartsWith("qualification-") || eventKey.StartsWith("honor-license-")) return "qualification";
        if (eventKey.StartsWith("honor-sponsor-")) return "sponsor";
        return category switch
        {
            "转会" => "transfer", "俱乐部" => "entry", "国际赛事" => "international", "晋级" => "qualification",
            "生涯里程碑" => "honor", "训练日常" => "practice", "人物专访" => "feature", "赛季" => "season", _ => "news"
        };
    }
    public static string Reply(CareerData d, CareerPerson p, string category, CareerMatch? match, int variant, string eventKey = "")
    {
        int seed = (int)((uint)variant & int.MaxValue);
        string text = Pick(Bank(d, p, category, match, seed, eventKey), seed / 5);
        var duel = match == null ? null : d.Esports.Duels.FirstOrDefault(x => x.PersonId == match.OpponentId);
        text = text.Replace("{opponent}", match == null ? "对手" : CareerEngine.DisplayName(d, match.OpponentId)).Replace("{duelWins}", (duel?.Wins ?? 0).ToString());
        // 当事人的发言保持简短；其他人物按持久化性格补充一句立场。
        if (p.Role == "普通玩家" && match?.Kind is "continental" or "worldcup" && seed % 7 == 0)
            text += (seed % 4) switch
            {
                0 => $"我平时关注{p.Country}赛区，这次也想多看看其他选手。",
                1 => $"来自{p.Country}看台，比赛还是要按成绩说话。",
                2 => $"{p.Country}这边也有人在看这份战报。",
                _ => $"先从{p.Country}赛区过来留个记录。"
            };
        else if (p.Id != match?.OpponentId && seed % 4 != 0 && NarrativeText.Banks.ContainsKey("voice." + p.Temperament))
            text += Pick("voice." + p.Temperament, seed / 19);
        return text;
    }
    public static string FreshReply(CareerData d, CareerPerson p, string category, CareerMatch? match, int seed, string eventKey, ISet<string> used)
    {
        var recent = d.Posts.Take(12).SelectMany(post => post.Replies).Select(r => r.Body).ToHashSet();
        string text = "";
        for (int i = 0; i < 32; i++)
        {
            text = Reply(d, p, category, match, CareerEngine.StableHash(seed + ":" + i), eventKey);
            if (!recent.Contains(text) && !used.Contains(text)) break;
        }
        used.Add(text); return text;
    }
    public static (string Title, string Body) News(CareerData d, string key, string title, string body, string category, CareerMatch? match)
    {
        int seed = CareerEngine.StableHash(d.WorldId + key);
        if (match != null)
        {
            string opponent = CareerEngine.DisplayName(d, match.OpponentId);
            string outcome = match.Status == "退赛" ? "退赛" : match.Draw ? "战平" : match.PlayerWon ? "获胜" : "失利";
            title = (seed % 6) switch
            {
                0 => $"{match.Event}战报：你对阵{opponent}，{outcome}",
                1 => $"赛果确认｜{match.Event}，你{outcome}",
                2 => $"你与{opponent}的交手结束：{outcome}",
                3 => $"{match.Event} · {opponent}一战的结果公布：你{outcome}",
                4 => $"今日赛场：你在{match.Event}{outcome}",
                _ => $"正式战报｜你与{opponent}之战，{outcome}"
            };
        }
        else if (category is "训练日常" or "人物专访" or "海外赛区")
        {
            string[] headings = category == "训练日常" ? ["训练室消息", "今日练习簿", "赛场之外", "训练日观察", "日常战报", "社区练习记录"]
                : category == "人物专访" ? ["人物手记", "选手观察", "赛场面孔", "档案摘录", "本期人物", "职业圈侧记"]
                : ["海外战报", "各地赛场", "赛区速报", "联赛观察", "赛场简讯", "今日赛况"];
            int separator = title.IndexOf('：');
            title = headings[seed % headings.Length] + "：" + (separator >= 0 ? title[(separator + 1)..] : title);
        }
        if (match == null)
        {
            string bank = Bank(d, new CareerPerson(), category, null, seed, key);
            if (NarrativeText.Banks.ContainsKey("bulletin." + bank)) body = Pick("bulletin." + bank, seed / 7) + body;
        }
        return (PublicNameText(title, d), NewsBody(body, d));
    }
}


