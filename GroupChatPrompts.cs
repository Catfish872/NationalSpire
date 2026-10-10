using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace NationalSpire;

public static class GroupChatPrompts
{
    public static readonly string[] SectionIds = ["group", "group-summary", "group-long-summary"];
    public static string Guide => PrivateMessagePrompts.Guide
        .Replace("你是本次人物资料中的角色，正在通过国运尖塔的私信与玩家聊天。正文是你发送给玩家的中文消息。", "你扮演本群的 NPC 成员，与真人成员共同聊天。每个人依据自己的身份、经历和知情范围说话。真人成员的消息由本人发送。")
        .Replace("私信", "群聊").Replace("只写这个人实际发给对方的消息。", "围绕玩家最新消息和本群正在讨论的话题接话。有话要回应的人发言，其他成员可以沉默，不要求所有人每轮发言；不要为了展示各人的性格而安排轮流发言。允许相互接话、同一人多次发言。人物资料、帖子和赛程用于理解当前交流，不要逐人另起一个背景话题。");
    public static string SmallSummary => PrivateMessagePrompts.SmallSummary.Replace("以你的第一人称视角和性格口吻记录信息", "明确使用各参与者姓名记录信息，区分各人的说法、决定和实际结果");
    public static string BigSummary => PrivateMessagePrompts.BigSummary.Replace("以人物的第一人称和性格口吻记录，保留双方身份", "明确使用各参与者姓名记录，保留各方身份");
    public const string Format = """
每条发言以单独一行 [Speaker: p2] 开始，p2 换成本群人物表的编号，随后直接写正文；换人或同一人再次发言时再写一个 Speaker 标记。不输出 JSON 外壳，不替真人发言。
按当前话题决定谁先接话，不按人物编号或名单顺序轮流发言，同一人可以再次接话，其他人可以不发言。
Speaker 只能填写本群可发言的 NPC 编号，不替真人发言。Actor 通常填写作出决定或变化的 NPC；Activity 的 Actor 可以填写实际提出活动的玩家。账号已封禁的 NPC 不能发言或发起交互。
所有发言之后，另起一行 [Actions]，再逐条输出实际发生的交互标记。没有交互可以省略 Actions。只有标记才登记交互，口头答应不代替标记。
交互沿用下方字段，并在每项标记内增加 Actor（作出决定或变化的人物编号）。关系和约战增加 Target（对方编号）。Actor 不能省略，也不能根据最后一位发言者推断。
NPC 向另一名 NPC 提出约战也须输出 Match 标记，例如 [Match: 邀请, Actor: p2, Target: p3, Season: 1, Day: 18, Ascension: 6, Mode: 切磋]；Actor 填发起者，Target 填对手，日期与进阶按实际商谈填写。
例如 [Favour: 40, Actor: p2, Target: p1] 表示 p2 对 p1 的好感更新为40；[Skill: 1, Actor: p2, Topic: 选牌, Reason: 理解了精简牌组的条件] 只改变 p2 的学习。
本轮训练附件指定 NPC 教练时，教练先用 [Training: 同意, Actor: p3, Id: 12] 或拒绝表态，受训者再用 [Training: 接受, Actor: p2, Id: 12]；玩家已担任教练的附件由受训者直接接受。Id 填对应训练附件的编号。如果没有训练附件但是玩家有安排训练的意向，则教练和受训者先在正文中商谈，收到对应附件后再输出训练标记。
活动用 Participants 填谈妥的完整人员编号，以竖线分隔，例如 [Activity: 邀请, Actor: p2, Participants: p1|p2|p3, Title: 一起看录像, Season: 2, Day: 18, Detail: 讨论今天的比赛]。这是一个共同安排，不逐人输出同意标记；改期、取消引用已有活动 Id。
玩家已提出活动意愿，且活动内容、日期与参与者已经谈妥时，须输出完整 Activity 标记，不能只在正文答应。Actor 填实际发起人的编号，可以是玩家或 NPC；Participants 填谈妥的全部参与者。
发帖 Actor 为作者，Related 可指定希望在帖子下回应的人物，例如 [Post: 发布, Actor: p2, Related: p3|p4, Title: 训练小结, Body: 发帖正文]。指定的相关人物也会参与该帖的回复。
以下交互条件分别适用于实际 Actor；其中对玩家的关系使用 Target 指明，人物只能提交自己的状态、学习与档案变化。普通发言不需要交互标记。
""";
    public static string Section(CareerData d, string id) => d.PrivatePromptSnapshot.GetValueOrDefault(id) ?? PromptLibrary.Get(d.Ai, id);
    public static string UserText(CareerData d, GroupChat g, GroupTurn t) => t.Text + (t.Attachments.Count == 0 ? "" : "\n附带内容\n" + string.Join("\n\n", t.Attachments.Select(a =>
        "编号" + a.Id + " · " + PrivateMessages.AttachmentTitle(a) + "\n对象：" + string.Join("、", a.Participants.Select(id => g.Alias(id) + " " + GroupChats.Name(d, id)))
        + (a.ActorId.Length > 0 ? "\n处理人：" + g.Alias(a.ActorId) + " " + GroupChats.Name(d, a.ActorId) : "")
        + (a.CoachId.Length > 0 ? "\n负责教练：" + g.Alias(a.CoachId) + " " + GroupChats.Name(d, a.CoachId) : "") + "\n" + a.Detail)));
    internal static string InteractionContext(CareerData d, GroupChat g, int recent, string person = "", string turnId = "")
    {
        var turns = g.Turns.Where(t => t.Status == "complete").TakeLast(recent).SelectMany(t => t.Effects).Select(e => e.Turn).ToHashSet();
        var lines = new List<string>();
        foreach (var (key, lane) in g.Interactions)
        {
            var parts = key.Split('/');
            string actor = GroupChats.Name(d, lane.PersonId), target = GroupChats.Name(d, parts.Length > 2 && parts[2].Length > 0 ? parts[2] : parts[0]);
            foreach (var o in lane.Offers.Where(o => turnId.Length == 0 || o.TurnId == turnId))
            {
                if (person.Length > 0 && lane.PersonId != person && !(o.Kind == "activity" && o.Participants.Contains(person))) continue;
                var plan = ClubCoaching.TrainingPlans(d).FirstOrDefault(p => p.Id == o.Id);
                var lineup = d.Esports.LineupRequests.FirstOrDefault(r => r.Id == o.Id);
                var match = d.Matches.FirstOrDefault(m => m.Id == o.MatchId);
                bool active = o.State == "待确认" || o.Kind == "activity" && o.State == "已确认" || plan?.State == "进行中" || lineup?.State == "待生效" || o.Kind == "match" && match?.Status is "待赛" or "进行中";
                if (turnId.Length == 0 && !active && !turns.Contains(o.TurnId)) continue;
                string content = o.Kind switch
                {
                    "activity" => $"活动《{o.Title}》，参与者{string.Join("、", o.Participants.Select(id => GroupChats.Name(d, id)))}，第{o.Season}赛季第{o.Day}天，{o.Detail}，{o.State}",
                    "match" => $"{actor}与{target}的{o.Mode}，第{o.Season}赛季第{o.Day}天，进阶{o.Ascension}，{match?.Status ?? o.State}。{o.Detail}",
                    "contract" => $"{actor}的合同报价，签字费{o.Signing}美元、周薪{o.Wage}美元、胜场奖金{o.WinBonus}美元，{o.Weeks}周，席位{o.Role}，{o.State}。{o.Detail}",
                    "publish" => $"{actor}的帖子《{o.Title}》，{(o.State == "已确认" ? "已发布" : o.State)}。{o.Detail}",
                    "training" => $"{actor}的训练《{o.Detail}》，{o.Weeks}周，{plan?.State ?? o.State}" + (plan == null ? "" : $"，负责教练{(plan.CoachId.Length > 0 ? GroupChats.Name(d, plan.CoachId) : target)}，{PrivateAppointments.DateText(d, plan.StartDay)}至{PrivateAppointments.DateText(d, plan.EndDay)}，已完成{plan.PaidWeeks}周"),
                    "lineup" => lineup == null ? $"阵容调整，{o.State}" : CoachLineups.Description(d, lineup) + $"，第{lineup.Season}赛季，{lineup.State}。{lineup.Reason}",
                    "favour" => $"{actor}对{target}的好感拟调整为{o.FavourTargets.LastOrDefault()}，{o.State}",
                    _ => o.Title + "，" + o.State
                };
                lines.Add($"交互编号{PrivateInteractionIds.Number(lane, o)}，{actor}：{content}");
            }
        }
        return string.Join("\n", lines);
    }
    public static List<Dictionary<string, string>> Compose(CareerData d, GroupChat g, GroupTurn? pending = null)
    {
        var messages = new List<Dictionary<string, string>>();
        void Add(string role, string text) { if (text.Length > 0) messages.Add(new() { ["role"] = role, ["content"] = text }); }
        var protocols = string.Join("\n", PrivateMessagePrompts.Protocol, PrivateMessagePrompts.SkillProtocol, PrivateMessagePrompts.MoodProtocol,
            PrivateMessagePrompts.MatchProtocol, PrivateMessagePrompts.PostProtocol, PrivateMessagePrompts.ProfileProtocol,
            PrivateMessagePrompts.ContractProtocol, ClubCoaching.Protocol, CoachLineups.Protocol, SocialAppointments.Protocol)
            .Replace("你可以从玩家的具体讲解中", "各人可以从交流中的具体讲解中")
            .Replace("玩家提供了具体、适用条件明确的做法", "交流中提供了具体、适用条件明确的做法");
        // 例子补齐人物，避免旧私信例子与群聊固定协议互相矛盾。
        protocols = Regex.Replace(protocols, @"\[(Favour|Attitude|Relationship|Match|Contract|Skill|Mood|Post|Profile|Activity|Training|Lineup):([^\]\n]*)\]", m =>
            "[" + m.Groups[1].Value + ":" + m.Groups[2].Value + ", Actor: p2" + (m.Groups[1].Value is "Favour" or "Attitude" or "Relationship" or "Match" ? ", Target: p1" : "") + "]");
        Add("system", Section(d, "world") + "\n\n" + Section(d, "group") + "\n\n" + protocols + "\n\n" + Format + "\n" + ChatTimeline.Privacy);
        var profiles = new StringBuilder($"当前群聊：《{g.Name}》\n群成员：\n");
        foreach (string id in g.Members)
        {
            profiles.AppendLine(g.Alias(id) + "：" + GroupChats.Name(d, id) + (GroupChats.IsHuman(d, id) ? "（真人，由本人发言）" : GroupChats.CanSpeak(d, id) ? "（NPC，可发言）" : "（NPC，账号已封禁，不能发言或发起交互）"));
            if (id == GroupChats.Human(d)) profiles.AppendLine($"国籍{d.Esports.Country}，评分{d.Rating}，所属俱乐部{EsportsWorld.ClubName(d, d.Esports.ClubId)}。");
            if (CareerEngine.Person(d, id) is { } p)
            {
                profiles.AppendLine(JsonSerializer.Serialize(PrivatePublicContext.CharacterProfile(d, p), new JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping }));
                profiles.AppendLine($"评分{p.Rating}，最高通关进阶{p.MaxAscension}，所属俱乐部{EsportsWorld.ClubName(d, p.ClubId)}，席位{CoachLineups.Position(d, p)}。");
                PrivatePublicContext.AppendRecentResults(profiles, d, p);
            }
        }
        profiles.AppendLine("性格使用说明：" + PersonalityLibrary.ProfileUsage);
        foreach (var former in g.Aliases.Where(x => !g.Members.Contains(x.Key))) profiles.AppendLine($"以往成员：{former.Value} {GroupChats.Name(d, former.Key)}（已离群，仅用于识别历史记录）。");
        string player = GroupChats.Name(d, GroupChats.Human(d));
        profiles.AppendLine($"{player}的本生涯战绩：{d.Wins}胜{d.Losses}负、{d.Draws}平。参赛资格：{EsportsWorld.LicenseName(d)}。");
        if (d.PlayerCard is { } card) profiles.AppendLine($"{player}的角色资料：{card.Biography}；打法：{card.Style}；擅长角色：{card.Character}。");
        if (ClubCoaching.PlayerFeatures(d)) profiles.AppendLine($"{player}的俱乐部岗位：{(ClubCoaching.PlayerReserve(d) ? "轮换" : "首发")}{(ClubCoaching.PlayerCoach(d) ? "，兼任教练" : "")}。");
        foreach (var r in d.Results.OrderByDescending(r => r.Day).Take(3).Reverse()) profiles.AppendLine($"{PrivateAppointments.DateText(d, r.Day)}，{player}参加{r.Event}，对手{r.Opponent}，实际进阶{r.PlayedAscension ?? r.Ascension}，{MatchRules.Performance(r.Win, r.Floor, r.RunSeconds)}，赛事结果{r.Outcome}。");
        foreach (string club in g.Members.Select(id => CareerEngine.Person(d, id)?.ClubId ?? (id == GroupChats.Human(d) ? d.Esports.ClubId : "")).Where(id => id.Length > 0).Distinct().Order(StringComparer.Ordinal))
            profiles.AppendLine($"{EsportsWorld.ClubName(d, club)}成员：" + string.Join("；", CoachLineups.Members(d, club).Select(p => $"{p.PublicName}（{CoachLineups.Position(d, p)}，评分{p.Rating}，最高进阶{p.MaxAscension}）")));
        Add("user", profiles.ToString());
        var fixedPosts = new Dictionary<string, string>(); var topicPosts = new Dictionary<string, string>();
        string query = string.Join("\n", g.Turns.Where(t => t.Status == "complete").TakeLast(2).Select(t => t.Text).Append(pending?.Text ?? ""));
        foreach (var p in g.Members.Select(id => CareerEngine.Person(d, id)).OfType<CareerPerson>().Where(p => !GroupChats.IsHuman(d, p.Id)))
        {
            var baseline = new List<(string Id, string Text)>(); var topical = new List<(string Id, string Text)>();
            PrivatePublicContext.Community(d, p, "", completePosts: baseline);
            PrivatePublicContext.Community(d, p, query, completePosts: topical);
            foreach (var post in baseline) fixedPosts.TryAdd(post.Id, post.Text);
            foreach (var post in topical) topicPosts.TryAdd(post.Id, post.Text);
        }
        Add("user", string.Join("\n\n", fixedPosts.OrderBy(x => x.Key, StringComparer.Ordinal).Select(x => x.Value)));
        Add("user", ChatTimeline.Summaries(d, g.Members, g.Id));
        foreach (var s in g.BigSummaries.Concat(g.SmallSummaries)) Add("user", $"本群第{s.From + 1}至{s.Through}轮总结\n" + s.Text);
        var completed = g.Turns.Select((t, i) => (t, i)).Where(x => x.t.Status == "complete").ToArray();
        int recentStart = completed.Length > g.Settings.RecentRounds ? completed[completed.Length - g.Settings.RecentRounds - 1].i + 1 : 0;
        int start = Math.Min(g.SummarizedThrough, recentStart);
        long externalStart = recentStart > 0 ? g.Turns.Skip(recentStart).Select(t => t.Order).DefaultIfEmpty(d.Chats.Order + 1).Min() : 0;
        var own = new List<ChatTimeline.Item>();
        foreach (var t in g.Turns.Skip(start).Where(t => t.Status == "complete" && t != pending))
        {
            if (t.Text.Length > 0 || t.Attachments.Count > 0) own.Add(new(t.Order, t.Day, "user", PrivateAppointments.DateText(d, t.Day) + "，" + GroupChats.Name(d, t.Sender) + "发到本群：\n" + UserText(d, g, t)));
            foreach (var r in t.Replies) own.Add(new(r.Order, r.Day, "assistant", "[Speaker: " + g.Alias(r.Author) + "]\n" + r.Text));
        }
        long first = start > 0 ? own.Select(x => x.Order).DefaultIfEmpty(0).Min() : 0;
        own.AddRange(g.Entries.Where(e => e.Order >= first).Select(e => new ChatTimeline.Item(e.Order, e.Day, "user", PrivateAppointments.DateText(d, e.Day) + "，" + e.Text)));
        own.AddRange(ChatTimeline.External(d, g.Members, g.Id).Where(e => e.Order >= externalStart && (pending == null || e.Order < pending.Order)));
        foreach (var item in own.OrderBy(x => x.Day).ThenBy(x => x.Order)) Add(item.Role, ChatTimeline.Text(d, item));
        Add("user", string.Join("\n\n", topicPosts.Where(x => !fixedPosts.ContainsKey(x.Key)).OrderBy(x => x.Key, StringComparer.Ordinal).Select(x => x.Value)));
        var state = new StringBuilder("当前日期：" + PrivateAppointments.DateText(d, d.Day) + "\n");
        foreach (string id in g.Members.Where(id => PrivateMessages.CanChat(d, id)))
        {
            var p = CareerEngine.Person(d, id)!;
            state.AppendLine($"{g.Alias(id)}：当前状态等级{CareerTraining.MoodLevel(p, d.Day):0.##}；当前进阶{p.MaxAscension}通关率{MatchRules.ClearChance(d, p, p.MaxAscension):P1}。");
            if (OwnedClubs.CanOperate(d)) state.AppendLine(PrivateContracts.Guidance(d, p));
            string training = ClubCoaching.TrainingContext(d, id), lineup = CoachLineups.Context(d, id);
            if (training.Length > 0) state.AppendLine(training);
            if (lineup.Length > 0) state.AppendLine(lineup);
            foreach (var (human, box) in ChatTimeline.Mailboxes(d).Where(x => g.Members.Contains(x.Key)))
                if (box.Relations.TryGetValue(id, out var r)) state.AppendLine($"<private_memory>\n{GroupChats.Name(d, id)}的个人态度：对{GroupChats.Name(d, human)}好感{r.Favour}，关系{r.Relationship}，印象{r.Impression}。知情人：{GroupChats.Name(d, id)}。\n</private_memory>");
        }
        foreach (var pair in d.Chats.Relations)
        {
            var ids = pair.Key.Split('/');
            if (ids.Length == 2 && ids.All(g.Members.Contains)) state.AppendLine($"<private_memory>\n{GroupChats.Name(d, ids[0])}的个人态度：对{GroupChats.Name(d, ids[1])}好感{pair.Value.Favour}，关系{pair.Value.Relationship}，印象{pair.Value.Impression}。知情人：{GroupChats.Name(d, ids[0])}。\n</private_memory>");
        }
        var schedule = g.Members.Where(id => PrivateMessages.CanChat(d, id)).SelectMany(id => Enumerable.Range(d.Day, 15).SelectMany(day => PrivateAppointments.Schedule(d, id, day))).Distinct();
        foreach (var entry in schedule) state.AppendLine(PrivateAppointments.DateText(d, entry.Day) + "：" + entry.Description);
        state.AppendLine(InteractionContext(d, g, g.Settings.RecentRounds));
        foreach (var other in ChatTimeline.RelatedGroups(d, g.Members, g.Id).OrderBy(other => other.Id, StringComparer.Ordinal))
        {
            string interactions = InteractionContext(d, other, 5);
            if (interactions.Length > 0) state.AppendLine($"<private_memory>\n群聊《{other.Name}》的交互当前状态；知情人：{string.Join("、", other.Members.Select(id => GroupChats.Name(d, id)))}\n{interactions}\n</private_memory>");
        }
        Add("user", state.ToString());
        if (pending != null) Add("user", PrivateAppointments.DateText(d, pending.Day) + "，" + GroupChats.Name(d, pending.Sender) + "发到本群：\n" + UserText(d, g, pending));
        var node = JsonSerializer.SerializeToNode(messages)!;
        CharacterIdentity.Apply(node, CharacterIdentity.Aliases(d), d.People.SelectMany(p => p.HandleAliases.Append(p.Name).Append(p.Handle)).Concat(d.PlayerNameAliases).Append(CareerEngine.Name(d)));
        return node.Deserialize<List<Dictionary<string, string>>>()!;
    }
}
