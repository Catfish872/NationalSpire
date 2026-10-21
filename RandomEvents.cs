using System.Text.Json;

namespace NationalSpire;

public static class RandomEvents
{
    public static RandomEventRecord? Next(CareerData d, int through = int.MaxValue) => d.Life.RandomEvents
        .Where(e => e.Day >= d.Day && e.Day <= through && e.State is not ("complete" or "skipped"))
        .OrderBy(e => e.Day).FirstOrDefault();
    public static string? Stop(CareerData d, string id)
    {
        var e = Find(d, id); if (e == null || e.State != "generating" && e.CustomState != "generating") return null;
        AiService.CancelEvent(d, id);
        e.CustomState = e.CustomOption == null ? "idle" : "ready";
        e.State = e.Options.Count > 0 ? "ready" : "failed"; e.Error = "生成已停止，可以重新生成或跳过。";
        return null;
    }
    public static void Ensure(CareerData d, int? fromDay = null)
    {
        foreach (var e in d.Life.RandomEvents.Where(e => e.Day < d.Day && e.State is not ("complete" or "skipped"))) e.State = "skipped";
        long day = fromDay ?? Math.Max(d.Day, d.Life.RandomEvents.Select(e => (long)e.Day).DefaultIfEmpty(d.Day).Max());
        bool first = fromDay == null && d.Life.RandomEvents.Count == 0 && d.Life.RandomEventMinDays == 7 && d.Life.RandomEventMaxDays == 11;
        var dates = d.Life.RandomEvents.Select(e => e.Day).ToHashSet();
        var random = new Random(CareerEngine.StableHash(d.WorldId + ":questions:" + day));
        while (d.Life.RandomEventsEnabled && day <= (long)d.Day + 28)
        {
            day += random.NextInt64(first ? 6 : d.Life.RandomEventMinDays, (long)(first ? 10 : d.Life.RandomEventMaxDays) + 1);
            if (day > int.MaxValue) break;
            if (dates.Add((int)day)) d.Life.RandomEvents.Add(new() { Day = (int)day });
            first = false;
        }
        RememberMatches(d);
    }
    public static void SetFrequency(CareerData d, bool enabled, int minimum, int maximum)
    {
        minimum = Math.Max(1, minimum); maximum = Math.Max(minimum, maximum);
        d.Life.RandomEventsEnabled = enabled;
        d.Life.RandomEventMinDays = minimum; d.Life.RandomEventMaxDays = maximum;
        d.Life.RandomEvents.RemoveAll(e => e.Day > d.Day && e.State == "waiting" && e.Materials.Length == 0 && e.Story.Length == 0 && e.Options.Count == 0);
        Ensure(d, d.Day);
    }
    public static RandomEventRecord? Find(CareerData d, string id) => d.Life.RandomEvents.FirstOrDefault(e => e.Id == id);
    public static string? Start(CareerData d, string id)
    {
        var e = Find(d, id); if (e == null || e.Day != d.Day) return "请在事件当天参与。";
        if (e.State is "complete" or "skipped" || AiService.EventBusy(d, id)) return null;
        if (!d.Ai.Enabled) return "启用AI后可以生成事件，也可以直接跳过。";
        if (e.Materials.Length == 0)
        {
            var random = new Random(CareerEngine.StableHash(d.WorldId + ":event:" + e.Id));
            var used = d.Life.RandomEvents.Where(x => x.Seed.Length > 0).TakeLast(24).Select(x => x.Seed).ToHashSet();
            var selected = EventPools.SelectRandom(d.Ai, used, random);
            // 本地魔改：事件素材前缀标记参与者池，可叠加（同时出现时取交集）：
            //   【相识】= 最近论坛互动 / 私聊过 / 人际关联 / 同俱乐部 / 有好感（至少有交集的人）
            //   【同战队】【恋人】【同国家】【异性】= 对应范围；未标记 = 全部 NPC 完全随机。
            var filters = new HashSet<string>();
            string seedDetail = StripMarkers(selected.Detail, filters);
            e.Seed = seedDetail; e.Category = selected.Category;
            e.People = SelectPeople(d, random, filters.Count == 0 ? null : filters);
            e.Materials = RandomEventPrompts.Materials(d, e);
        }
        e.CustomOption = null; e.CustomAction = ""; e.CustomState = "idle"; e.CustomReasoning = "";
        e.State = "generating"; e.Error = ""; return null;
    }
    // 本地魔改：事件素材前缀 → 参与者池筛选条件（可叠加，取交集）。见 Start。
    internal static readonly (string Marker, string Filter)[] PoolMarkers =
    [
        ("【相识】", "acquaint"), ("【熟人】", "acquaint"), ("【认识】", "acquaint"), ("[相识]", "acquaint"),
        ("【同战队】", "team"), ("[同战队]", "team"),
        ("【恋人】", "lover"), ("[恋人]", "lover"),
        ("【同国家】", "country"), ("[同国家]", "country"),
        ("【异性】", "opposite"), ("[异性]", "opposite")
    ];
    // 本地魔改：filters=null 时全部可私聊 NPC 完全随机 0-3 人；否则按条件取交集后抽 1-3 人（可为 0 人）。
    internal static List<string> SelectPeople(CareerData d, Random random, ISet<string>? filters)
    {
        string human = GroupChats.Human(d);
        var candidates = d.People.Where(p => !GroupChats.IsHuman(d, p.Id) && PrivateMessages.CanChat(d, p.Id))
            .Select(p => p.Id).ToHashSet();
        if (candidates.Count == 0) return [];
        var score = new Dictionary<string, int>();
        void Bump(string id, int value)
        {
            if (id.Length == 0 || !candidates.Contains(id)) return;
            score[id] = score.GetValueOrDefault(id) + value;
        }
        var conversations = PrivateMessages.Mailbox(d).Conversations;
        foreach (string id in candidates)
        {
            var person = CareerEngine.Person(d, id);
            if (conversations.ContainsKey(id)) Bump(id, 5);      // 私聊过 = 认识
            if (person == null) continue;
            if (person.Connections.Contains(human)) Bump(id, 4); // 人际关联
            if (d.Esports.ClubId.Length > 0 && (person.ClubId == d.Esports.ClubId || person.SupportedClubId == d.Esports.ClubId)) Bump(id, 3);
            if (PrivateMessages.Favour(d, id) > 0) Bump(id, 1);
        }
        int since = d.Day - 14;
        foreach (var post in CommunityThreads.All(d).Where(p => p.Day >= since))
        {
            bool playerThread = CommunityThreads.IsHuman(d, post.AuthorId);
            bool playerReplied = post.Replies.Any(r => CommunityThreads.IsHuman(d, r.AuthorId));
            if (!playerThread && playerReplied) Bump(post.AuthorId, 6);   // 玩家去别人帖里互动
            if (playerThread || post.RelatedPeople.Contains(human))
                foreach (var reply in post.Replies.Where(r => !CommunityThreads.IsHuman(d, r.AuthorId)))
                    Bump(reply.AuthorId, 6);                               // 别人在玩家的帖子/相关帖里回复
            foreach (var reply in post.Replies.Where(r => !CommunityThreads.IsHuman(d, r.AuthorId)))
                if (post.Replies.Any(r => r.Id == reply.ParentId && CommunityThreads.IsHuman(d, r.AuthorId)))
                    Bump(reply.AuthorId, 4);                               // 回复了玩家的楼层
        }
        // 未标记事件：全部可私聊 NPC 完全随机，数量保持原来的 0–3。
        if (filters == null)
            return candidates.OrderBy(_ => random.Next()).Take(random.Next(4)).ToList();
        IEnumerable<string> pool = candidates;
        if (filters.Contains("acquaint")) pool = pool.Where(id => score.GetValueOrDefault(id) > 0);
        if (filters.Contains("team")) pool = pool.Where(id => SameTeam(d, id));
        if (filters.Contains("lover")) pool = pool.Where(id => IsLover(d, id));
        if (filters.Contains("country")) pool = pool.Where(id => SameCountry(d, id));
        if (filters.Contains("opposite")) pool = pool.Where(id => IsOppositeSex(d, id));
        var list = pool.ToList();
        if (list.Count == 0) return []; // 条件池为空：不塞不符合条件的陌生人
        int count = Math.Min(random.Next(1, 4), list.Count);
        return (filters.Contains("acquaint")
            ? list.OrderByDescending(id => score.GetValueOrDefault(id) + random.Next(3)).ThenBy(_ => random.Next())
            : list.OrderBy(_ => random.Next())).Take(count).ToList();
    }
    private static bool SameTeam(CareerData d, string id)
        => d.Esports.ClubId.Length > 0 && CareerEngine.Person(d, id) is { } p && p.ClubId == d.Esports.ClubId;
    private static bool SameCountry(CareerData d, string id)
        => d.Esports.Country.Length > 0 && CareerEngine.Person(d, id) is { } p && p.Country == d.Esports.Country;
    private static bool IsLover(CareerData d, string id)
    {
        var relation = PrivateMessages.Mailbox(d).Relations.GetValueOrDefault(id);
        return relation is { } r && (r.SelectedBond is >= 1 || r.OathConfirmed);
    }
    private static bool IsOppositeSex(CareerData d, string id)
    {
        string player = IdentityGender.Of(d, "player");
        if (player is not ("男" or "女")) return false;
        string gender = IdentityGender.Of(d, id);
        return gender is "男" or "女" && gender != player;
    }
    // 剥离素材行首的参与者池前缀，返回真正交给 AI 的故事素材；filters 收集对应条件。
    internal static string StripMarkers(string detail, ISet<string> filters)
    {
        string seed = detail;
        while (true)
        {
            bool hit = false;
            foreach (var (marker, filter) in PoolMarkers)
                if (seed.StartsWith(marker, StringComparison.Ordinal))
                { filters.Add(filter); seed = seed[marker.Length..].TrimStart(); hit = true; break; }
            if (!hit) return seed;
        }
    }
    public static string? Custom(CareerData d, string id, string action)
    {
        var e = Find(d, id);
        if (e == null || e.Day != d.Day || e.State != "ready") return "请先展开当天的故事。";
        if (AiService.EventBusy(d, id)) return "当前内容正在生成。";
        if (!d.Ai.Enabled) return "启用AI后可以生成行动结局。";
        if (string.IsNullOrWhiteSpace(action)) return "请填写你的行动。";
        action = action.Trim();
        if (action != e.CustomAction) e.CustomOption = null;
        e.CustomAction = action; e.CustomState = "generating"; e.Error = ""; return null;
    }
    public static string? ChooseCustom(CareerData d, string id, bool publicly)
    {
        var e = Find(d, id);
        if (e?.State == "complete") return null;
        if (e is not { State: "ready", CustomState: "ready", CustomOption: { } option }) return "请等待行动结局生成完成。";
        if (RandomEventEffects.Check(d, e, option) is { } error) return error;
        e.Options.Add(option);
        return Choose(d, id, e.Options.Count - 1, publicly);
    }
    public static string? Skip(CareerData d, string id)
    {
        var e = Find(d, id); if (e == null) return "事件已经不存在。";
        if (e.State != "complete") { e.State = "skipped"; e.CustomState = e.CustomOption == null ? "idle" : "ready"; AiService.CancelEvent(d, id); }
        return null;
    }
    public static string? Choose(CareerData d, string id, int index, bool publicly)
    {
        var e = Find(d, id); if (e == null) return "事件已经不存在。";
        if (e.State == "complete") return null;
        if (e.CustomState == "generating") return "请等待行动结局生成完成，或停止生成后选择。";
        if (e.State != "ready" || index < 0 || index >= e.Options.Count) return "请等待该事件的选项生成完成。";
        var option = e.Options[index];
        if (RandomEventEffects.Check(d, e, option) is { } error) return error;
        RandomEventEffects.Apply(d, e, option);
        foreach (string person in option.Effects.Select(effect => RandomEventEffects.PersonId(d, effect)).Where(id => id.Length > 0 && id != "player"))
            if (!e.People.Contains(person)) e.People.Add(person);
        e.Selected = index; e.Public = publicly; e.State = "complete";
        string fact = e.Story.Trim() + "\n玩家选择：" + option.Text + "\n实际结果：" + option.Result;
        Remember(d, e, e.Id, fact);
        if (publicly) CareerLife.AddEvent(d, "question:" + e.Id, "人物日常", e.Title, fact, e.People.Append(GroupChats.Human(d)).Distinct().ToList());
        return null;
    }
    private static void Remember(CareerData d, RandomEventRecord e, string id, string fact)
    {
        long order = GroupChats.NextOrder(d);
        string source = "随机事件 · " + e.Title + "；参与者：" + string.Join("、", e.People.Prepend(GroupChats.Human(d)).Select(p => GroupChats.Name(d, p)));
        foreach (string person in e.People.Where(p => PrivateMessages.CanChat(d, p)))
        {
            var box = PrivateMessages.Mailbox(d);
            if (!box.Conversations.TryGetValue(person, out var c)) box.Conversations[person] = c = new() { PersonId = person, EventOnly = true };
            if (c.Turns.Any(t => t.Id == "event:" + id)) continue;
            c.Turns.Add(new() { Id = "event:" + id, Day = d.Day, Season = d.Season, UserOrder = order, ReplyOrder = order,
                RequestKind = "event", User = source + "\n" + fact, Reply = "", ReplyDeleted = true, Status = "complete", Applied = true });
            c.MemoryRevision++;
        }
    }
    public static void RememberMatches(CareerData d)
    {
        foreach (var e in d.Life.RandomEvents.Where(e => e.State == "complete" && e.MatchIds.Count > e.RememberedMatches.Count))
            foreach (string id in e.MatchIds.Where(id => !e.RememberedMatches.Contains(id)))
                if (d.Matches.FirstOrDefault(m => m.Id == id && m.Status is not ("待赛" or "进行中")) is { } match)
                {
                    string text = $"由事件约定的{match.Event}：{match.Status}。";
                    if (match.PlayerSeconds.HasValue) text += $"玩家{(match.PlayerWon ? "获胜" : match.Draw ? "平局" : "失利")}，到达{match.PlayerFloor}层，用时{MatchRules.Time(match.PlayerSeconds.Value)}。";
                    Remember(d, e, id, text); e.RememberedMatches.Add(id);
                }
    }
}

public static class RandomEventEffects
{
    private static readonly string[] Kinds = ["wallet", "fans", "clubFans", "item", "favour", "impression", "status", "learning", "market", "development", "challenge"];
    public static string Kind(Dictionary<string, JsonElement> e) => Kinds.FirstOrDefault(e.ContainsKey) ?? "";
    private static decimal Number(Dictionary<string, JsonElement> e, string key) => e[key].ValueKind == JsonValueKind.Number ? e[key].GetDecimal()
        : decimal.Parse(e[key].GetString()!, System.Globalization.CultureInfo.InvariantCulture);
    private static string Text(Dictionary<string, JsonElement> e, string key) => e[key].GetString() ?? "";
    internal static string Person(Dictionary<string, JsonElement> e)
    {
        string kind = Kind(e);
        return kind is "favour" or "impression" or "status" or "learning" or "challenge" ? Text(e, kind) : "";
    }
    internal static bool IsPlayer(CareerData d, string id) => id == "player" || d.HumanIds.Contains(id);
    // 人物引用宽容解析：编号 → 玩家/玩家别名 → 现役/历史人物编号 → 现役/历史人物姓名/别名唯一匹配。
    internal static string Resolve(CareerData d, string text)
    {
        if (string.IsNullOrWhiteSpace(text)) return "";
        if (IsPlayer(d, text)) return text;
        if (text == CareerEngine.Name(d) || text == d.PlayerAlias || d.PlayerNameAliases.Contains(text)) return "player";
        if (CareerEngine.Person(d, text) != null) return text;
        var matches = d.People.Concat(d.DeletedPeople.Values)
            .Where(p => p.Name == text || p.PublicName == text || p.Handle == text || p.HandleAliases.Contains(text))
            .DistinctBy(p => p.Id).ToList();
        return matches.Count == 1 ? matches[0].Id : "";
    }
    internal static string PersonId(CareerData d, Dictionary<string, JsonElement> e) => Resolve(d, Person(e));
    private static CareerPerson? TargetPerson(CareerData d, string id)
    {
        if (id.Length == 0) return null;
        if (id == "player") { d.PlayerCard ??= CharacterCards.Read(d, "player"); return d.PlayerCard; }
        return CareerEngine.Person(d, id);
    }
    public static string? Check(CareerData d, RandomEventRecord record, RandomEventOption option)
    {
        string? error = CheckEffects(d, record, option);
        if (error != null) Diagnostics.RecordEventCheck(d, record, option, error);
        return error;
    }
    private static string? CheckEffects(CareerData d, RandomEventRecord record, RandomEventOption option)
    {
        decimal wallet = CareerMoney.Balance(d) * 10;
        var stock = d.Life.Consumer.Goods.Where(g => !g.Consumed).GroupBy(g => g.Id).ToDictionary(g => g.Key, g => (decimal)g.Sum(x => x.Quantity));
        try
        {
            foreach (var e in option.Effects)
            {
                string kind = Kind(e);
                if (kind.Length == 0 || Kinds.Count(e.ContainsKey) != 1) return "这一选项的效果格式有误，可以选择其他选项或重新生成。";
                if (kind is "favour" or "impression" or "status" or "learning" or "challenge")
                {
                    string personId = PersonId(d, e);
                    if (personId.Length == 0) return "选项涉及的人物编号未对应到当前存档中的人物。";
                    if (kind == "challenge")
                    {
                        if (IsPlayer(d, personId)) return "约战对象不能是玩家本人。";
                        if (TargetPerson(d, personId) == null) return "选项涉及的人物编号未对应到当前存档中的人物。";
                    }
                    if (kind is "status" or "learning" && TargetPerson(d, personId) == null)
                        return "选项涉及的人物编号未对应到当前存档中的人物。";
                }
                switch (kind)
                {
                    case "wallet": wallet += Number(e, kind); if (wallet < 0) return "钱包余额不足，可选择其他方案或跳过。"; break;
                    case "fans": _ = checked(d.Fans + (int)Number(e, kind)); break;
                    case "clubFans": if (!OwnedClubs.IsOwner(d)) return "当前没有经营的俱乐部。"; _ = checked(d.Esports.OwnedClub!.Fans + (int)Number(e, kind)); break;
                    case "item":
                        string good = Text(e, kind); if (ConsumerCatalog.Get(good)?.Collectible != true) return "该商品无法作为库存物品。";
                        decimal count = Number(e, "count"); if (count != decimal.Truncate(count)) return "物品数量应为整数。";
                        stock[good] = stock.GetValueOrDefault(good) + count;
                        if (stock[good] < 0 || stock[good] > long.MaxValue) return "所需物品数量与当前库存不符。";
                        break;
                    case "favour": _ = checked(PrivateMessages.Favour(d, Text(e, kind)) + (int)Number(e, "value")); break;
                    case "impression": _ = Text(e, "text"); break;
                    case "status": if (Number(e, "days") <= 0) return "临时状态的持续时间需要大于零。"; _ = checked(d.Day + (int)Number(e, "days")); _ = Number(e, "percent"); _ = Text(e, "name"); break;
                    case "learning": _ = Number(e, "percent"); break;
                    case "market": if (!d.Market.Quotes.ContainsKey(Text(e, kind)) || Number(e, "percent") <= -100) return "该品牌或行情幅度无法执行。"; break;
                    case "development": if (!d.Esports.Nations.Any(n => n.Country == Text(e, kind)) || Number(e, "points") < 0) return "建设投入需要有效国家及非负点数。"; _ = checked((int)Number(e, "points") * 7); break;
                    case "challenge":
                        if (!GameCalendar.TryDay(d, Text(e, "date"), out int day) || day < d.Day) return "约战日期已经过去。";
                        if (Number(e, "ascension") is < 0 or > 10 || Text(e, "mode") is not ("切磋" or "挑战")) return "约战进阶或模式无效。";
                        if (PrivateAppointments.Error(d, Text(e, kind), new() { Season = GameCalendar.Season(d, day), Day = SeasonCalendar.Day(d, day), Ascension = (int)Number(e, "ascension"), Mode = Text(e, "mode") }) is { } invalid) return invalid;
                        break;
                }
            }
        }
        catch (Exception error) when (error is FormatException or InvalidOperationException or KeyNotFoundException or OverflowException)
        { return "这一选项的效果字段不完整，可以选择其他选项或重新生成。"; }
        return null;
    }
    public static string Preview(CareerData d, RandomEventOption option)
    {
        var lines = new List<string>();
        foreach (var e in option.Effects)
            try
            {
                string kind = Kind(e), id = Resolve(d, Person(e)), person = id.Length > 0 ? CareerEngine.DisplayName(d, id) : "";
                lines.Add(kind switch
                {
                    "wallet" => "钱包 " + (Number(e, kind) >= 0 ? "+" : "−") + CareerMoney.Format(Math.Abs(Number(e, kind)) / 10),
                    "fans" => $"个人关注 {Number(e, kind):+0;-0}", "clubFans" => $"俱乐部关注 {Number(e, kind):+0;-0}",
                    "item" => $"{ConsumerCatalog.Get(Text(e, kind))?.Name} {Number(e, "count"):+0;-0}",
                    "favour" => $"{person}好感 {Number(e, "value"):+0;-0}", "impression" => person + "的印象：" + Text(e, "text"),
                    "status" => $"{person} · {Text(e, "name")}：模拟发挥 {Number(e, "percent"):+0.##;-0.##}%，持续{Number(e, "days")}天",
                    "learning" => $"{person}长期模拟水平 {Number(e, "percent"):+0.##;-0.##}%",
                    "market" => $"{MarketCatalog.Assets.FirstOrDefault(a => a.Id == Text(e, kind))?.Name}报价 {Number(e, "percent"):+0.##;-0.##}%",
                    "development" => $"{Text(e, kind)}建设投入 +{Number(e, "points")}国运对应进度",
                    "challenge" => $"{Text(e, "date")} · 与{person}{Text(e, "mode")} · 进阶{Number(e, "ascension")}", _ => "效果格式待修正"
                });
            }
            catch { lines.Add("效果格式待修正"); }
        return lines.Count == 0 ? "按所选结局结束这次经历" : string.Join("\n", lines);
    }
    public static void Apply(CareerData d, RandomEventRecord record, RandomEventOption option)
    {
        foreach (var e in option.Effects)
        {
            string kind = Kind(e);
            switch (kind)
            {
                case "wallet": decimal amount = Number(e, kind) / 10; CareerMoney.Add(d, amount); CareerMoney.Record(d, record.Title, amount); break;
                case "fans": d.Fans = Math.Max(0, d.Fans + (int)Number(e, kind)); break;
                case "clubFans": d.Esports.OwnedClub!.Fans = Math.Max(0, d.Esports.OwnedClub.Fans + (int)Number(e, kind)); break;
                case "item": ConsumerEngine.ChangeInventory(d, ConsumerCatalog.Get(Text(e, kind))!, (long)Number(e, "count")); break;
                case "favour":
                    if (!IsPlayer(d, Resolve(d, Text(e, kind)))) PrivateMessages.ChangeFavour(d, Resolve(d, Text(e, kind)), (int)Number(e, "value")); break;
                case "impression":
                    if (!IsPlayer(d, Resolve(d, Text(e, kind)))) { var relation = PrivateMessages.Relation(d, Resolve(d, Text(e, kind))); relation.Impression = Text(e, "text"); relation.Revision++; } break;
                case "status":
                    if (TargetPerson(d, Resolve(d, Text(e, kind))) is { } statusTarget)
                    { statusTarget.Learning.EventStatuses.Add(new() { Source = record.Id, Name = Text(e, "name"), Percent = (double)Number(e, "percent"), Until = d.Day + (int)Number(e, "days") }); CareerTraining.InvalidateForecast(d); }
                    break;
                case "learning":
                    if (TargetPerson(d, Resolve(d, Text(e, kind))) is { } learningTarget)
                    { learningTarget.Learning.ChanceShift += (double)Number(e, "percent") / 100; CareerTraining.InvalidateForecast(d); }
                    break;
                case "market": CareerMarket.EventPrice(d, Text(e, kind), Number(e, "percent"), record.Id, record.Title); break;
                case "development": NationalDevelopment.Contribute(d, d.Esports.Nations.Single(n => n.Country == Text(e, kind)), (int)Number(e, "points"), record.Title); break;
                case "challenge":
                    GameCalendar.TryDay(d, Text(e, "date"), out int day);
                    var match = PrivateAppointments.CreateMatch(d, Text(e, kind), day, (int)Number(e, "ascension"), Text(e, "mode"), "际遇"); record.MatchIds.Add(match.Id); break;
            }
        }
    }
}
