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
    public static void Ensure(CareerData d)
    {
        foreach (var e in d.Life.RandomEvents.Where(e => e.Day < d.Day && e.State is not ("complete" or "skipped"))) e.State = "skipped";
        int day = Math.Max(d.Day, d.Life.RandomEvents.Select(e => e.Day + 1).DefaultIfEmpty(d.Day).Max());
        var random = new Random(CareerEngine.StableHash(d.WorldId + ":questions:" + day));
        while (day <= d.Day + 28)
        {
            day += random.Next(6, 11);
            d.Life.RandomEvents.Add(new() { Day = day });
        }
        RememberMatches(d);
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
            e.Seed = selected.Detail; e.Category = selected.Category;
            e.People = d.People.Where(p => !GroupChats.IsHuman(d, p.Id) && PrivateMessages.CanChat(d, p.Id)).OrderBy(_ => random.Next()).Take(random.Next(4)).Select(p => p.Id).ToList();
            e.Materials = RandomEventPrompts.Materials(d, e);
        }
        e.CustomOption = null; e.CustomAction = ""; e.CustomState = "idle"; e.CustomReasoning = "";
        e.State = "generating"; e.Error = ""; return null;
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
        foreach (string person in option.Effects.Select(RandomEventEffects.Person).Where(id => id.Length > 0))
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
    public static string? Check(CareerData d, RandomEventRecord record, RandomEventOption option)
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
                    if (!PrivateMessages.CanChat(d, Person(e))) return "选项涉及的人物编号未对应到当前存档中的人物。";
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
                string kind = Kind(e), id = Person(e), person = id.Length > 0 ? CareerEngine.DisplayName(d, id) : "";
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
                case "favour": PrivateMessages.ChangeFavour(d, Text(e, kind), (int)Number(e, "value")); break;
                case "impression": var relation = PrivateMessages.Relation(d, Text(e, kind)); relation.Impression = Text(e, "text"); relation.Revision++; break;
                case "status": CareerEngine.Person(d, Text(e, kind))!.Learning.EventStatuses.Add(new() { Source = record.Id, Name = Text(e, "name"), Percent = (double)Number(e, "percent"), Until = d.Day + (int)Number(e, "days") }); CareerTraining.InvalidateForecast(d); break;
                case "learning": CareerEngine.Person(d, Text(e, kind))!.Learning.ChanceShift += (double)Number(e, "percent") / 100; CareerTraining.InvalidateForecast(d); break;
                case "market": CareerMarket.EventPrice(d, Text(e, kind), Number(e, "percent"), record.Id, record.Title); break;
                case "development": NationalDevelopment.Contribute(d, d.Esports.Nations.Single(n => n.Country == Text(e, kind)), (int)Number(e, "points"), record.Title); break;
                case "challenge":
                    GameCalendar.TryDay(d, Text(e, "date"), out int day);
                    var match = PrivateAppointments.CreateMatch(d, Text(e, kind), day, (int)Number(e, "ascension"), Text(e, "mode"), "际遇"); record.MatchIds.Add(match.Id); break;
            }
        }
    }
}
