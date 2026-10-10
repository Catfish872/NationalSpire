using System.Text;

namespace NationalSpire;

/// <summary>私信使用的具名公开资料；生涯事实常驻，社区材料按整篇来源及回复关系检索。</summary>
public static partial class PrivatePublicContext
{
    private static string Human(CareerData d) => d.LocalHumanId.Length > 0 ? d.LocalHumanId : "player";
    private static bool IsPlayer(CareerData d, string id) => id == Human(d) || d.LocalHumanId.Length == 0 && id == "player";
    private static string Name(CareerData d, string id) => IsPlayer(d, id) ? CareerEngine.Name(d) : CareerEngine.DisplayName(d, id);
    private static int ActualAscension(CareerResult r) => r.PlayedAscension ?? (r.OfficialAscensionVerified ? r.Ascension : -1);
    public static string IdentityText(CareerPerson p) => p.Handle.Length > 0
        ? $"游戏名为“{p.Handle}”、姓名{(p.Name.Length > 0 ? "为“" + p.Name + "”" : "未填写")}的角色"
        : p.Name.Length > 0 ? $"姓名为“{p.Name}”、未另设游戏名的角色" : "姓名和游戏名均未填写的角色";
    public static object CharacterProfile(CareerData d, CareerPerson p) => new
    {
        官方仲裁记录 = SpireArbitration.Memory(d, p),
        显示名称 = p.PublicName, 游戏名 = p.Handle, 姓名 = p.Name.Length > 0 ? p.Name : "未填写", 曾用游戏名 = p.HandleAliases,
        性别 = IdentityGender.Of(d, p.Id), 职业 = p.Role, 国家或地区 = p.Country, 所在地区 = p.Region,
        角色卡保存的背景介绍 = p.Biography, 性格概述 = p.Temperament, 打法 = p.Style, 性格 = PersonalityLibrary.PromptProfile(p.Personality),
        擅长角色 = CharacterIdentity.Aliases(d).GetValueOrDefault(p.Character, p.Character), 说话习惯 = p.Voice, 身份 = p.Identities,
        支持俱乐部 = p.SupportedClubId.Length > 0 ? EsportsWorld.ClubName(d, p.SupportedClubId) : "未记录",
        熟悉的人 = p.Connections.Select(id => CareerEngine.Person(d, id) is { } known ? IdentityText(known) : CareerEngine.DisplayName(d, id))
    };

    public static string Profiles(CareerData d, CareerPerson p, List<(int Start, int Length, string Group)>? changing = null)
    {
        string player = CareerEngine.Name(d);
        var b = new StringBuilder();
        b.AppendLine($"{p.PublicName}的当前资料");
        b.AppendLine($"{p.PublicName}是{p.Role}，归属{EsportsWorld.ClubName(d, p.ClubId)}；{p.PublicName}的战绩为{p.Wins}胜{p.Losses}负，最高通关进阶{p.MaxAscension}，累计冠军{p.Titles}次，世界积分{WorldPoints(d, p.Id)}，评分{p.Rating}。");
        int chanceStart = b.Length;
        b.AppendLine($"{p.PublicName}在进阶{p.MaxAscension}的基础通关率为{MatchRules.BaseChance(p, p.MaxAscension):P1}；计入当前培养、陪练、交流学习与短期状态后为{MatchRules.ClearChance(d, p, p.MaxAscension):P1}。");
        if (p.CustomClearChance is { } custom) b.AppendLine($"{p.PublicName}角色卡设定的进阶{p.MaxAscension}初始通关率为{custom:P1}；上述当前通关率已计入后续交流学习。");
        changing?.Add((chanceStart, b.Length - chanceStart, "learning"));
        if (p.RecordedWinStreak > 0) b.AppendLine($"{p.PublicName}的连胜纪录：{CameoContent.StreakText(p)}");
        if (p.Form.Length > 0) b.AppendLine($"{p.PublicName}近期比赛结果（从旧到新）：{string.Join("、", p.Form.ToCharArray())}。");
        Awards(p.Id, p.PublicName);
        var clubs = new HashSet<string>();
        if (ClubCoaching.IsCoach(p)) b.AppendLine($"{p.PublicName}担任俱乐部教练，不兼任选手；陪练系数×{ClubCoaching.Factor(p):0.#}。");
        Club(p.ClubId, p.PublicName);
        if (p.AiIntroduction.Length > 0 && p.IntroductionDay <= d.Day)
            b.AppendLine($"{PrivateAppointments.DateText(d, p.IntroductionDay)}的{p.PublicName}周刊档案：{p.AiIntroduction}");

        b.AppendLine($"\n{player}的当前资料");
        b.AppendLine($"{player}是与你聊天的玩家，性别为{d.PlayerGender}，来自{d.Esports.Country}；职业为{d.PlayerCard?.Role ?? EsportsWorld.LicenseName(d)}，参赛资格为{EsportsWorld.LicenseName(d)}。");
        b.AppendLine($"{player}的本生涯比赛战绩为{d.Wins}胜{d.Losses}负、{d.Draws}平，评分{d.Rating}，关注{d.Fans}。");
        var results = d.Results.Where(r => r.Day <= d.Day && r.Kind != "private-friendly").ToArray();
        int highest = results.Where(r => r.Win).Select(ActualAscension).Append(d.LocalHumanId.Length == 0 ? d.Esports.BestClear : -1).Max();
        b.AppendLine(highest >= 0 ? $"{player}的生涯最高通关：进阶{highest}。" : $"{player}尚无已确认的生涯通关进阶记录。");
        if (d.AvatarHighestClear > highest) b.AppendLine($"{player}的游戏档案最高通关：进阶{d.AvatarHighestClear}（包含本生涯以外的游戏记录）。");
        // 实际爬塔通关与赛事胜负分别统计，避免把未通关获胜或加赛进阶混为一谈。
        if (results.Length > 0)
        {
            int recentStart = b.Length;
            b.AppendLine($"{player}已记录的公开比赛，按实际挑战进阶统计：" + string.Join("；", results.GroupBy(ActualAscension).OrderByDescending(g => g.Key).Select(g =>
                $"{(g.Key < 0 ? "实际进阶未记录" : "进阶" + g.Key)}，{g.Count()}场，通关{g.Count(r => r.Win)}场，赛事获胜{g.Count(r => r.Outcome == "获胜")}场")) + "。");
            // 与当前人物的比赛在共同经历中展示双方结果，避免重复注入同一场。
            var recent = results.OrderByDescending(r => r.Day).Take(3).Where(r => r.OpponentId != p.Id && !r.OpponentParticipants.Contains(p.Id)).ToArray();
            if (recent.Length > 0) b.AppendLine($"{player}的近期公开赛果：");
            foreach (var r in recent)
                b.AppendLine($"{PrivateAppointments.DateText(d, r.Day)}，{player}在{r.Event}对阵{r.Opponent}，赛果{r.Outcome}；{(r.OfficialAscensionVerified ? "赛事规定进阶" + r.Ascension : "赛事规定进阶未核实")}，{player}{(ActualAscension(r) >= 0 ? "实际挑战进阶" + ActualAscension(r) : "实际挑战进阶未记录")}，使用{CharacterIdentity.ForResult(r)}，{MatchRules.Performance(r.Win, r.Floor, r.RunSeconds)}。");
            if (b.Length > recentStart) changing?.Add((recentStart, b.Length - recentStart, "results"));
        }
        if (d.PlayerCard is { } card)
        {
            if (card.Name.Length > 0) b.AppendLine($"{player}的姓名：{card.Name}。");
            if (card.Style.Length > 0) b.AppendLine($"{player}的打法偏好：{card.Style}。");
            if (card.Biography.Length > 0) b.AppendLine($"{player}的人物介绍：{card.Biography}");
            if (card.Character.Length > 0) b.AppendLine($"{player}擅长角色：{card.Character}。");
            if (card.Identities.Count > 0) b.AppendLine($"{player}的其他身份：{string.Join("、", card.Identities)}。");
            if (card.Region.Length > 0) b.AppendLine($"{player}所在地区：{card.Region}。");
            if (card.SupportedClubId.Length > 0) b.AppendLine($"{player}支持的俱乐部：{EsportsWorld.ClubName(d, card.SupportedClubId)}。");
            if (card.Voice.Length > 0) b.AppendLine($"{player}的说话习惯：{card.Voice}");
            if (card.Personality.Dimensions().Any(s => s.Length > 0)) b.AppendLine($"{player}自设角色卡中的性格：" + System.Text.Json.JsonSerializer.Serialize(PersonalityLibrary.PromptProfile(card.Personality), new System.Text.Json.JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping }));
        }
        if (d.SelectedCharacter.Length > 0) b.AppendLine($"{player}当前选择的角色：{CharacterIdentity.Aliases(d).GetValueOrDefault(d.SelectedCharacter, d.SelectedCharacter)}。");
        if (d.PlayerNameAliases.Count > 0) b.AppendLine($"{player}的曾用游戏名：{string.Join("、", d.PlayerNameAliases)}。");
        b.AppendLine($"{player}所属俱乐部：{EsportsWorld.ClubName(d, d.Esports.ClubId)}。" + (OwnedClubs.CanOperate(d) ? $"{player}是这家自建俱乐部的管理者。" : ""));
        if (ClubCoaching.PlayerFeatures(d))
            b.AppendLine($"{player}在俱乐部的岗位：{(ClubCoaching.PlayerReserve(d) ? "轮换" : "首发")}{(ClubCoaching.PlayerCoach(d) ? "，兼任教练" : "")}。");
        Club(d.Esports.ClubId, player);
        if (d.Esports.NationalTeam) b.AppendLine($"{player}入选{d.Esports.Country}国家队。");
        if (d.LocalHumanId.Length == 0) b.AppendLine($"{player}当前连胜{d.Esports.WinStreak}场，世界积分{WorldPoints(d, "player")}。");
        else b.AppendLine($"{player}的个人世界积分为{WorldPoints(d, Human(d))}。");
        Awards(Human(d), player);
        foreach (var group in d.Esports.Honors.Where(h => h.Day <= d.Day).GroupBy(h => (h.Title, Team: d.LocalHumanId.Length > 0 && !h.Id.StartsWith("ceremony-") && !h.Id.StartsWith("top20-"))))
            b.AppendLine($"{(group.Key.Team ? player + "所在合作队伍" : player)}的荣誉：{group.Key.Title}（{string.Join("、", group.Select(h => "第" + h.Season + "赛季").Distinct())}）。");
        if (CareerCommerce.ActiveSponsor(d) is { } sponsor && sponsor.SignedDay <= d.Day) b.AppendLine($"{player}的个人赞助商：{sponsor.Brand}，合作期为第{sponsor.StartSeason}至{sponsor.EndSeason}赛季。{sponsor.Description}");
        if (d.LocalHumanId.Length == 0 && d.PlayerIntroduction.Length > 0 && d.PlayerIntroductionDay <= d.Day)
            b.AppendLine($"{PrivateAppointments.DateText(d, d.PlayerIntroductionDay)}的{player}周刊档案：{d.PlayerIntroduction}");
        AppendCareerDetails(b, d, p, changing);
        b.AppendLine("\n性格使用说明：" + PersonalityLibrary.ProfileUsage);
        return b.ToString().TrimEnd();

        void Awards(string id, string name)
        {
            foreach (var group in d.Esports.CircuitAwards.Where(a => a.PersonId == id && a.Day <= d.Day).GroupBy(a => (a.Event, a.Place)))
                b.AppendLine($"{name}的赛事荣誉：{group.Key.Event}{group.Key.Place}（{string.Join("、", group.Select(a => "第" + a.Season + "赛季").Distinct())}）。");
        }
        void Club(string id, string name)
        {
            if (!clubs.Add(id) || EsportsWorld.Club(d, id) is not { } club) return;
            b.AppendLine($"{name}所属的{club.Name}来自{club.Country}，累计冠军{club.Titles}次。{club.Motto}");
            AppendClubDetails(b, d, club, p.Id, changing);
        }
    }

    public static string Community(CareerData d, CareerPerson person, string query, ISet<string>? attached = null, List<(string Id, string Text)>? completePosts = null)
    {
        var posts = CommunityThreads.All(d).Where(p => p.Day <= d.Day && !CommunityThreads.NewsPending(d, p)).ToArray();
        var available = posts.ToDictionary(p => p.Id);
        var memories = CommunityMemorySearch.PrivateAcquaintance(d, person);
        memories.AddRange(CommunityMemorySearch.Retrieve(d, query, [person.Id, Human(d)], d.Day, new HashSet<string>(), 5,
            excludedMemories: memories.Select(m => m.Id).ToHashSet(), requireTopic: true));
        bool PlayerRelated(CommunityPost p) => IsPlayer(d, p.AuthorId) || p.RelatedPeople.Any(id => IsPlayer(d, id)) || p.Replies.Any(r => r.Day <= d.Day && IsPlayer(d, r.AuthorId));
        int LastActivity(CommunityPost p) => p.Replies.Where(r => r.Day <= d.Day && (r.AuthorId == person.Id || IsPlayer(d, r.AuthorId))).Select(r => r.Day).Append(p.Day).Max();
        bool Topic(CommunityPost p) => CommunityMemorySearch.MatchesTopic(query, p.Title + "\n" + p.Body);
        var selected = new List<CommunityPost>();
        void Add(IEnumerable<CommunityPost> sources, int count)
            => selected.AddRange(sources.Where(p => attached?.Contains(p.Id) != true && selected.All(s => s.Id != p.Id)).Take(count));
        // 原帖只发送一次。保留双方近期公开往来，让“刚才那个帖子”也能找到完整语境。
        var ownPosts = posts.Where(p => p.AuthorId == person.Id || p.Replies.Any(r => r.Day <= d.Day && r.AuthorId == person.Id)).ToArray();
        Add(ownPosts.OrderByDescending(LastActivity), 1);
        Add(ownPosts.Where(p => Topic(p) || PlayerRelated(p)).OrderByDescending(Topic).ThenByDescending(PlayerRelated).ThenByDescending(LastActivity), 2);
        Add(posts.Where(PlayerRelated).OrderByDescending(LastActivity), 1);
        Add(posts.Where(p => PlayerRelated(p) && Topic(p)).OrderByDescending(p => p.Priority).ThenByDescending(LastActivity), 2);
        Add(memories.Where(m => available.ContainsKey(m.PostId)).Select(m => available[m.PostId]).DistinctBy(p => p.Id), 2);
        Add(posts.Where(Topic).OrderByDescending(LastActivity), 2);
        var b = new StringBuilder();
        foreach (var post in selected)
        {
            string fullPost = PostText(d, post, person, query, memories);
            b.AppendLine(fullPost);
            completePosts?.Add((post.Id, fullPost));
        }
        // 原帖已归档删除时仍保留记忆条目；同一来源已展开后不再重复其摘录。
        var selectedIds = selected.Select(p => p.Id).Concat(attached ?? new HashSet<string>()).ToHashSet();
        var remaining = memories.Where(m => !selectedIds.Contains(m.PostId)).ToArray();
        var missingSources = remaining.Select(m => m.PostId).Where(id => !available.ContainsKey(id)).ToHashSet();
        var originals = d.CommunityMemories.Where(m => m.Day <= d.Day && missingSources.Contains(m.PostId) &&
            (m.Id == m.PostId + ":fact" || m.Id == m.PostId + ":editorial"));
        foreach (var memory in originals.Concat(remaining).DistinctBy(m => m.Id))
            b.AppendLine($"{PrivateAppointments.DateText(d, memory.Day)}，{(memory.Kind == "fact" ? "已记录事件" : "社区发言，仅代表发言者的观点或猜测")}：{memory.Text}");
        return b.ToString().Trim();
    }
    public static string PostText(CareerData d, CommunityPost post, CareerPerson person, string query = "", IEnumerable<CommunityMemory>? sourceMemories = null)
    {
        var b = new StringBuilder();
        var memories = sourceMemories ?? [];
            b.AppendLine($"\n《{post.Title}》｜{PrivateAppointments.DateText(d, post.Day)}｜发帖者：{Name(d, post.AuthorId)}");
            b.AppendLine($"帖子原文（{Name(d, post.AuthorId)}的公开发言）：\n{post.Body}");
            if (post.SourceBody.Length > 0 && post.SourceBody != post.Body && !CommunityThreads.IsHuman(d, post.AuthorId))
                b.AppendLine($"这篇帖子对应的已记录事件：{GameText.Plain(post.SourceBody)}");
            // 与社区回帖共用选取规则，既提供人物发言，也提供他人回应及讨论发展。
            var replies = post.Replies.Where(r => r.Day <= d.Day).DistinctBy(r => r.Id).ToDictionary(r => r.Id);
            var chosen = post.Replies.Where(r => r.Day <= d.Day && (r.AuthorId == person.Id || IsPlayer(d, r.AuthorId))).TakeLast(6)
                .Concat(post.Replies.Where(r => r.Day <= d.Day && CommunityMemorySearch.MatchesTopic(query, r.Body)).TakeLast(2)).Select(r => r.Id).ToHashSet();
            foreach (var memory in memories.Where(m => m.PostId == post.Id))
                foreach (var reply in replies.Values.Where(r => memory.Id == post.Id + ":" + r.Id)) chosen.Add(reply.Id);
            var conversation = CommunityThreads.ContextReplies(post, d.Day, anchors: chosen);
            if (conversation.Count > 0) b.AppendLine(conversation.Count == replies.Count ? "帖子讨论（完整记录）：" : "帖子讨论（开头、近期发言与相关回复分支）：");
            foreach (var reply in conversation)
            {
                string target = replies.TryGetValue(reply.ParentId, out var parent) ? Name(d, parent.AuthorId) : "原帖";
                b.AppendLine($"{PrivateAppointments.DateText(d, reply.Day)}，{Name(d, reply.AuthorId)}回复{target}：{reply.Body}");
            }
        return b.ToString().Trim();
    }

}
