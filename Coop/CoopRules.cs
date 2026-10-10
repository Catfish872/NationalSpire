namespace NationalSpire.Coop;

/// <summary>所有玩家命令在主机串行执行；在副本上计算成功后整体提交，不切换单人全局存档。</summary>
public static partial class CoopRules
{
    public static CoopWorld Create(ulong owner, string name, string playerName, int capacity, string country)
    {
        if (capacity is < 2 or > 4 || !EsportsWorld.Countries.Contains(country)) throw new InvalidDataException("队伍设置无效。");
        var w = new CoopWorld { Owner = owner, Capacity = capacity, Name = string.IsNullOrWhiteSpace(name) ? "共同生涯" : name.Trim() };
        w.World = CareerEngine.CreateNew(cooperativeMembers: capacity);
        CoopJson.Detached(w.World); w.World.WorldId = w.Id; w.World.PlayerAlias = w.Name;
        w.World.Esports.Country = country; OwnedClubs.EnsureMarket(w.World); w.World.Ai.Enabled = false;
        w.World.Esports.Competitions.Clear(); w.World.Matches.Clear(); CircuitWorld.StartSeason(w.World);
        w.World.Life.Activities.Clear(); w.World.Life.Figurines.Clear();
        AddMember(w, owner, playerName); return w;
    }
    public static void AddMember(CoopWorld w, ulong id, string name)
    {
        if (w.Members.Any(m => m.SteamId == id)) return;
        if (id == 0) throw new InvalidOperationException("玩家身份无效。");
        if (CareerNames.Validate(w.World, name) is { } error) throw new InvalidOperationException(error);
        var member = new CoopMember { SteamId = id, Name = name.Trim(), Life = new() { Version = CareerLife.Version, NextOfferDay = w.World.Day + 2, NextProjectDay = w.World.Day + 21 } };
        w.Members.Add(member); var view = View(w, member); CareerRelics.Shop(view); member.Life = view.Life; RefreshPeople(w); w.Revision++;
    }
    public static CareerData View(CoopWorld w, CoopMember m)
    {
        var d = CoopJson.Copy(w.World); CoopJson.Detached(d);
        d.AvatarWorldId = w.Id; d.LocalHumanId = m.PersonId;
        d.CooperativeMembers = 1; d.WorldId = w.Id + "-" + m.SteamId;
        d.PlayerAlias = m.Name; d.PlayerGender = m.Gender; d.PlayerNameAliases = m.Aliases.ToList(); d.Credits = m.Credits; d.Fans = m.Fans; d.Rating = m.Rating;
        d.Wins = m.Wins; d.Losses = m.Losses; d.Draws = m.Draws; d.AvatarHighestClear = m.HighestClear;
        d.SelectedAvatarFrame = m.AvatarFrame;
        d.SelectedAvatar = CoopJson.Copy(m.Avatar);
        d.PlayerCard = m.Card == null ? null : CoopJson.Copy(m.Card);
        d.SelectedCharacter = m.Character; d.RandomCharacter = m.RandomCharacter; d.Life = CoopJson.Copy(m.Life); d.Results = CoopJson.Copy(m.Results);
        d.PendingCeremonySeason = w.World.PendingCeremonySeason > m.SeenCeremonySeason ? w.World.PendingCeremonySeason : 0;
        d.Esports.Honors.RemoveAll(h => h.Id.StartsWith("ceremony-") || h.Id.StartsWith("top20-"));
        d.Esports.Honors.AddRange(CoopJson.Copy(m.CeremonyHonors));
        d.Esports.Sponsors = CoopJson.Copy(m.Sponsors); d.Esports.SponsorOffers = CoopJson.Copy(m.SponsorOffers);
        // 团队合同已经由世界结算，个人商业结算只处理自己的赞助。
        d.Esports.PlayerContract = null; d.Esports.CommercialPaidMatches = [];
        return d;
    }
    private static void Capture(CoopWorld w, CoopMember m, CareerData d)
    {
        var oldPosts = CommunityThreads.All(w.World).Select(p => p.Id).ToHashSet();
        foreach (var post in CommunityThreads.All(d).Where(p => !oldPosts.Contains(p.Id)))
        { post.RelatedPeople = post.RelatedPeople.Select(id => id == "player" ? m.PersonId : id).ToList(); }
        w.World.Chats.Order = Math.Max(w.World.Chats.Order, d.Chats.Order);
        m.Name = d.PlayerAlias; m.Aliases = d.PlayerNameAliases; m.Credits = d.Credits; m.Fans = d.Fans; m.Rating = d.Rating;
        m.Wins = d.Wins; m.Losses = d.Losses; m.Draws = d.Draws; m.HighestClear = d.AvatarHighestClear;
        m.Life = d.Life; m.Sponsors = d.Esports.Sponsors; m.SponsorOffers = d.Esports.SponsorOffers; m.Results = d.Results;
        w.World.People = d.People; w.World.Esports.Clubs = d.Esports.Clubs;
        w.World.Development = d.Development;
        w.World.Esports.LineupRequests = d.Esports.LineupRequests;
        w.World.Esports.CoachTraining = d.Esports.CoachTraining;
        if (m.SteamId == w.Owner) w.World.Esports.OwnedClub = d.Esports.OwnedClub;
        w.World.Posts = d.Posts; w.World.SavedThreads = d.SavedThreads; w.World.CommunityMemories = d.CommunityMemories;
        foreach (var ev in m.Life.Events)
        {
            ev.People = ev.People.Select(id => id == "player" ? m.PersonId : id).ToList();
            if (!ev.Id.StartsWith(m.PersonId + "/", StringComparison.Ordinal)) ev.Id = m.PersonId + "/" + ev.Id;
        }
        RefreshPeople(w);
    }
    public static void RefreshPeople(CoopWorld w)
    {
        w.World.HumanFavours = w.Members.ToDictionary(m => m.PersonId, m => PrivateMessages.Mailbox(m.Life).Relations.ToDictionary(p => p.Key, p => p.Value.Favour));
        AvatarHonors.Capture(w.World);
        w.World.HumanIds = w.Members.Select(m => m.PersonId).ToList();
        w.World.HumanFrames = w.Members.ToDictionary(m => m.PersonId, m => m.AvatarFrame);
        w.World.HumanAvatars = w.Members.ToDictionary(m => m.PersonId, m => m.Avatar);
        w.World.HumanClears = w.Members.ToDictionary(m => m.PersonId, m => m.HighestClear);
        foreach (var m in w.Members)
        {
            var p = w.World.People.FirstOrDefault(p => p.Id == m.PersonId);
            if (p == null) { p = new CareerPerson { Id = m.PersonId }; w.World.People.Add(p); }
            if (m.Card != null)
            {
                p = CoopJson.Copy(m.Card); p.Id = m.PersonId;
                w.World.People.RemoveAll(x => x.Id == m.PersonId); w.World.People.Add(p);
            }
            p.Name = m.Card?.Name ?? m.Name; p.Handle = m.Name; p.Gender = m.Gender; p.HandleAliases = m.Aliases.ToList(); p.Country = w.World.Esports.Country;
            p.ClubId = w.World.Esports.ClubId; p.Rating = m.Rating; p.Wins = m.Wins; p.Losses = m.Losses;
            if (w.World.Esports.OwnedClub is { } owned) p.ClubPosition = owned.Starters.Contains(m.PersonId) ? "首发" : "轮换";
            p.MaxAscension = m.Card?.MaxAscension ?? Math.Max(0, m.HighestClear); p.Role = m.Card?.Role ?? "联机选手"; p.Region = p.Country + "赛区";
            p.Character = m.Card?.Character ?? m.Character; p.Biography = m.Card?.Biography ?? "共同生涯的真人队员，发言由本人提交。";
        }
        // 人物同步不改变当前比赛或赛季已记录的出场名单。
    }
    public static (CoopWorld World, CoopOutcome Outcome) Apply(CoopWorld original, ulong sender, CoopCommand command, IReadOnlySet<ulong> online, IReadOnlySet<string> characters)
    {
        CoopOutcome Reject(string error) => new(false, error);
        if (!original.Members.Any(m => m.SteamId == sender)) return (original, Reject("身份不属于本生涯。"));
        if (command.World != original.Id || command.Epoch != original.Epoch) return (original, Reject("房间会话已改变，请重新同步。"));
        if (command.Id.Length is < 1 or > 80 || command.Kind != "character-card" && command.Text.Length > (command.Kind == "avatar" ? PlayerAvatar.MaxText : (command.Kind.StartsWith("dm-") || command.Kind.StartsWith("group-")) ? 160000 : 16000) || command.Target.Length > 256) return (original, Reject("操作内容无效。"));
        string key = sender + "/" + command.Id, fingerprint = CoopJson.Hash(CoopJson.Bytes(command));
        if (original.Receipts.TryGetValue(key, out var receipt)) return (original, receipt.Fingerprint == fingerprint ? new(true, receipt.Result, true) : Reject("请求标识冲突。"));
        // 同一提议的投票互不覆盖；其他队员先确认或阅读消息后，仍接受该提议的确认。
        bool sameProposal = command.Kind == "confirm" && original.Proposal?.Id == command.Target
            && command.Revision <= original.Revision;
        if (command.Revision != original.Revision && !sameProposal) return (original, Reject("状态已更新，请查看最新内容后重新操作。"));
        var w = CoopJson.Copy(original); CoopJson.Detached(w.World);
        var member = w.Members.Single(m => m.SteamId == sender);
        string? error = null;
        try
        {
            bool full = online.Count is >= 2 and <= 4;
            if (w.World.Failure != null && command.Kind is not ("failure-confirm" or "failure-retry") && !(w.World.Failure.RetryRequested && command.Kind is "confirm" or "cancel")) return (original, Reject(MatchFailure.Locked(w.World)!));
            if (w.Proposal is { } ready && ready.Participants.Count > 0 && !ready.Participants.SetEquals(online)) w.Proposal = null;
            if (!command.Kind.StartsWith("dm-") && !command.Kind.StartsWith("group-") && command.Kind is not ("propose-enter" or "ceremony-read" or "read" or "cancel" or "reading" or "character" or "avatar" or "gender" or "rival-level" or "failure-confirm" or "failure-retry" or "abandon-run") && !full) return (original, Reject("需要2—4位在线队员。"));
            if (w.Run != null && !command.Kind.StartsWith("dm-") && !command.Kind.StartsWith("group-") && command.Kind is not ("ceremony-read" or "read" or "cancel" or "reading" or "propose-resume" or "propose-enter" or "confirm" or "avatar" or "gender" or "failure-confirm" or "failure-retry" or "abandon-run" or "restart-run")) return (original, Reject("当前比赛尚未结束，请继续对局。"));
            if (command.Kind.StartsWith("group-", StringComparison.Ordinal)) error = GroupCommand(w, member, command);
            else if (command.Kind.StartsWith("dm-", StringComparison.Ordinal)) error = PrivateCommand(w, member, command);
            else if (command.Kind.StartsWith("owned-", StringComparison.Ordinal))
            {
                if (sender != w.Owner) return (original, Reject("俱乐部由房主管理。"));
                if (w.Proposal != null) return (original, Reject("请先完成或取消当前团队提议。"));
                var world = w.World; world.Credits = member.Credits; world.Life.CreditFraction = member.Life.CreditFraction;
                world.LocalHumanId = member.PersonId;
                error = OwnedClubs.Command(world, command.Kind[6..], command.Target, command.Text);
                world.LocalHumanId = "";
                if (error != null) return (original, Reject(error));
                member.Credits = world.Credits; member.Life.CreditFraction = world.Life.CreditFraction;
                if (world.Esports.OwnedClub is { } owned) owned.ManagerId = member.PersonId;
                PayClubMembers(w);
            }
            else switch (command.Kind)
            {
                case "character-card":
                    if (w.Proposal != null) { error = "请先完成或取消当前团队提议。"; break; }
                    var cardEdit = CharacterCards.Decode(command.Text);
                    if (cardEdit.Target == "player" && !cardEdit.Create)
                    {
                        var cardView = View(w, member);
                        error = CharacterCards.Apply(cardView, cardEdit);
                        if (error == null)
                        {
                            member.Card = cardView.PlayerCard; member.Name = cardView.PlayerAlias; member.Gender = cardView.PlayerGender;
                            member.Avatar = cardView.SelectedAvatar; member.Aliases = cardView.PlayerNameAliases;
                            member.Rating = cardView.Rating; member.Wins = cardView.Wins; member.Losses = cardView.Losses;
                        }
                    }
                    else if (sender != w.Owner) error = "NPC 角色由房主编辑。";
                    else if (w.World.HumanIds.Contains(cardEdit.Target)) error = "真人角色由本人编辑。";
                    else error = CharacterCards.Apply(w.World, cardEdit);
                    break;
                case "character-delete":
                    if (sender != w.Owner) { error = "NPC角色由房主管理。"; break; }
                    error = CharacterDeletion.Delete(w.World, command.Target);
                    if (error == null) foreach (var m in w.Members)
                    {
                        m.Life.Mailbox.Conversations.Remove(command.Target); m.Life.Mailbox.Relations.Remove(command.Target);
                        if (m.Life.Mailbox.LastPerson == command.Target) m.Life.Mailbox.LastPerson = "";
                        foreach (var a in m.Life.Activities) { a.TrainingTargets.Remove(command.Target); if (a.PersonId == command.Target && a.Status is "可安排" or "进行中") a.Status = "已取消"; }
                    }
                    break;
                case "failure-confirm":
                    if (sender != w.Owner) return (original, Reject("比赛结果由房主确认。"));
                    if (w.Run?.Terminal is not { } terminal || w.World.Failure == null) return (original, Reject("没有待确认的失败。"));
                    w.World.Failure = null;
                    w = Settle(w, w.Run.Attempt, terminal.Win, false, terminal.Floor, terminal.Seconds, terminal.Players, terminal.Details, true);
                    break;
                case "failure-retry":
                    if (sender != w.Owner) return (original, Reject("重赛由房主安排。"));
                    if (w.World.Failure == null) return (original, Reject("没有待选择的失败。"));
                    if (!full) return (original, Reject("重赛需要2—4位在线队员。"));
                    var retried = MatchFailure.Retry(w.World, command.Text == "new");
                    w.Run = null; w.LatestCheckpoint = "";
                    w.Proposal = new() { Kind = "start", Target = retried.Id, Number = retried.ChosenAscension ?? retried.RequiredAscension, Participants = online.ToHashSet(), Votes = [sender], Label = "准备重赛 · " + retried.Event };
                    break;
                case "restart-run": case "abandon-run":
                    if (sender != w.Owner || w.Run?.Phase != "paused") return (original, Reject("请先暂停当前比赛，由房主处理。"));
                    var interrupted = w.World.Matches.Single(m => m.Id == w.Run.MatchId);
                    if (command.Kind == "abandon-run")
                    {
                        var stopped = w.Run;
                        var stoppedPlayers = stopped.Characters.Select(p => new CoopLivePlayer(p.Key, p.Value, 0, 0, true)).ToList();
                        w = Settle(w, stopped.Attempt, false, true, 0, 0, stoppedPlayers, confirmFailure: true, forfeit: true);
                        break;
                    }
                    w.Run = null; w.LatestCheckpoint = ""; w.World.PendingMatchId = null; w.World.PendingSince = 0;
                    {
                        if (!full) return (original, Reject("重赛需要2—4位在线队员。"));
                        w.Proposal = new() { Kind = "start", Target = interrupted.Id, Number = interrupted.ChosenAscension ?? interrupted.RequiredAscension, Participants = online.ToHashSet(), Votes = [sender], Label = "重新准备 · " + interrupted.Event };
                    }
                    break;
                case "gender":
                    if (!IdentityGender.Choices.Contains(command.Text)) error = "请选择性别。";
                    else { member.Gender = command.Text; RefreshPeople(w); }
                    break;
                case "rival-level":
                    if (sender != w.Owner) error = "局内 AI 水平由房主设置。";
                    else if (w.Proposal != null) error = "请先完成或取消当前团队提议。";
                    else MatchRules.SetRivalLevel(w.World, command.Number);
                    break;
                case "ascension":
                    var selectedMatch = w.World.Matches.FirstOrDefault(m => m.Id == command.Target && m.Status == "待赛");
                    if (sender != w.Owner) error = "全队挑战进阶由房主设置。";
                    else if (w.Proposal != null) error = "请先完成或取消当前团队提议。";
                    else if (selectedMatch == null || command.Number < selectedMatch.RequiredAscension || command.Number > 10)
                        error = "挑战进阶超出本场范围。";
                    else selectedMatch.ChosenAscension = w.World.SelectedAscension = command.Number;
                    break;
                case "character":
                    if (command.Target == CareerEngine.RandomCharacterChoice && characters.Count > 0) { member.RandomCharacter = true; w.Proposal = null; }
                    else if (!characters.Contains(command.Target)) error = "这个角色当前不可用。";
                    else { member.Character = command.Target; member.RandomCharacter = false; w.Proposal = null; }
                    break;
                case "rename":
                    if (member.Name == command.Text.Trim()) break;
                    error = CareerNames.Validate(w.World, command.Text);
                    if (error == null) { member.Aliases.Add(member.Name); member.Name = command.Text.Trim(); }
                    break;
                case "frame":
                    var appearance = View(w, member);
                    AvatarHonors.Capture(appearance);
                    if (!AvatarHonors.Select(appearance, command.Target)) error = "尚未获得这个头像框。";
                    else member.AvatarFrame = command.Target;
                    break;
                case "avatar":
                    member.Avatar = PlayerAvatar.Read(command.Text);
                    break;
                case "team-preparation":
                    if (sender != w.Owner) { error = "集体备赛由房主安排。"; break; }
                    var prepView = View(w, member);
                    error = TeamPreparations.Buy(prepView, command.Target);
                    if (error == null) { w.World.TeamPreparations = prepView.TeamPreparations; Capture(w, member, prepView); }
                    break;
                case "relic": case "activity": case "skip": case "sponsor":
                    var view = View(w, member);
                    if (command.Kind == "relic") error = CareerRelics.Buy(view, command.Target);
                    if (command.Kind == "activity") error = CareerLife.Accept(view, command.Target);
                    if (command.Kind == "skip") CareerLife.SkipRound(view);
                    if (command.Kind == "sponsor")
                    {
                        var offer = view.Esports.SponsorOffers.FirstOrDefault(s => s.Id == command.Target);
                        error = offer == null ? "赞助邀请已失效。" : CareerCommerce.AcceptSponsor(view, offer);
                    }
                    if (error == null) Capture(w, member, view);
                    break;
                case "post":
                    if (string.IsNullOrWhiteSpace(command.Target) || string.IsNullOrWhiteSpace(command.Text)) { error = "请填写标题和正文。"; break; }
                    var post = new CommunityPost { AuthorId = member.PersonId, Title = command.Target.Trim(), Body = command.Text.Trim(), Day = w.World.Day,
                        Category = "玩家讨论", RelatedPeople = [member.PersonId], NeedsReaction = true };
                    post.MentionedPeople = CommunityMentions.Resolve(w.World, post.Title + "\n" + post.Body);
                    w.World.Posts.Insert(0, post); CommunityThreads.Remember(w.World, post); CommunityThreads.TrimFeed(w.World);
                    break;
                case "reply":
                    var target = CommunityThreads.All(w.World).FirstOrDefault(p => p.Id == command.Target);
                    if (target == null || string.IsNullOrWhiteSpace(command.Text)) { error = "帖子不存在或回复为空。"; break; }
                    // 回复目标由完整 ID 指定，客户端不能冒充其他作者。
                    if (command.Parent.Length > 0 && !target.Replies.Any(r => r.Id == command.Parent)) { error = "回复的楼层已不存在。"; break; }
                    target.Replies.Add(new CommunityReply { AuthorId = member.PersonId, ParentId = command.Parent, Body = command.Text.Trim(), Day = w.World.Day, NeedsReaction = true, MentionedPeople = CommunityMentions.Resolve(w.World, command.Text) });
                    target.AiPending = false; target.Revision++; CommunityThreads.Remember(w.World, target); break;
                case "reading":
                    var reading = CoopJson.Read<CoopReading>(System.Text.Encoding.UTF8.GetBytes(command.Text));
                    foreach (var pair in reading.Posts)
                        if (CommunityThreads.All(w.World).FirstOrDefault(p => p.Id == pair.Key) is { } rp)
                            member.ReadPosts[pair.Key] = Math.Max(member.ReadPosts.GetValueOrDefault(pair.Key), Math.Min(pair.Value, rp.Revision));
                    foreach (var pair in reading.Weeks)
                        if (w.World.WeeklyEditions.FirstOrDefault(p => p.Week == pair.Key) is { } rw)
                            member.ReadWeeks[pair.Key] = Math.Max(member.ReadWeeks.GetValueOrDefault(pair.Key), Math.Min(pair.Value, rw.Revision));
                    if (member.Results.Any(r => r.MatchId == reading.Settlement)) member.SeenSettlement = reading.Settlement;
                    break;
                case "read":
                    if (CommunityThreads.All(w.World).FirstOrDefault(p => p.Id == command.Target) is { } read) member.ReadPosts[read.Id] = read.Revision;
                    break;
                case "ceremony-read":
                    if (int.TryParse(command.Target, out int season) && w.World.Ceremonies.Any(c => c.Season == season))
                        member.SeenCeremonySeason = Math.Max(member.SeenCeremonySeason, season);
                    break;
                case "cancel":
                    if (w.Proposal?.Votes.Contains(sender) == true || sender == w.Owner) w.Proposal = null;
                    break;
                case "confirm":
                    if (w.Proposal == null || w.Proposal.Id != command.Target) { error = "这项提议已经失效。"; break; }
                    w.Proposal.Votes.Add(sender);
                    if (w.Proposal.Participants.All(id => w.Proposal.Votes.Contains(id))) { error = ExecuteProposal(w, w.Proposal, characters); w.Proposal = null; }
                    break;
                default:
                    if (!command.Kind.StartsWith("propose-", StringComparison.Ordinal)) { error = "不支持这项操作。"; break; }
                    if (sender != w.Owner) { error = "团队安排由房主操作。"; break; }
                    if (w.Proposal != null) { error = "请先完成或取消当前提议。"; break; }
                    string kind = command.Kind[8..];
                    if (kind is not ("advance" or "register" or "club" or "start" or "resume" or "enter" or "auto")) { error = "团队安排无效。"; break; }
                    if (kind == "resume" && w.Run?.Phase != "paused") { error = "正在连接比赛，请等待连接完成。"; break; }
                    var proposal = new CoopProposal { Kind = kind, Target = command.Target, Number = command.Number, Votes = [sender], Participants = online.ToHashSet(), Label = ProposalLabel(w, kind, command.Target, command.Number) };
                    if (kind is "start" or "resume") w.Proposal = proposal;
                    else error = ExecuteProposal(w, proposal, characters);
                    break;
            }
            if (error != null) return (SavePrivateFailure(original, sender, command, error), Reject(error));
            RefreshPeople(w); w.Revision++;
            w.Receipts[key] = new(fingerprint, "已完成", w.Revision);
            // 有界保存旧收据；已淘汰请求的修订号仍会阻止它再次生效。
            while (w.Receipts.Count > 4096) w.Receipts.Remove(w.Receipts.Keys.First());
            return (w, new(true, "已完成"));
        }
        catch (Exception e) { return (original, Reject("操作未提交：" + e.Message)); }
    }
    public static string ProposalLabel(CoopWorld w, string kind, string target, int number) => kind switch
    {
        "enter" => "全员进入多人生涯", "auto" => number == 1 ? "开启选拔赛自动报名" : "暂停选拔赛自动报名",
        "resume" => "从共同检查点继续比赛", "advance" => $"一起推进到第 {number} 天", "register" => (number == 1 ? "报名 " : "取消报名 ") + w.World.Matches.FirstOrDefault(m => m.Id == target)?.Event,
        "club" => "全队签约 " + EsportsWorld.ClubName(w.World, target), "start" => $"开始 {w.World.Matches.FirstOrDefault(m => m.Id == target)?.Event} · 挑战进阶 {number}", _ => "团队安排"
    };
    private static string? ExecuteProposal(CoopWorld w, CoopProposal p, IReadOnlySet<string> characters)
    {
        var d = w.World;
        switch (p.Kind)
        {
            case "dm-match": return ConfirmPrivateMatch(w, p);
            case "enter":
                w.CareerStarted = true; w.EntrySequence++; return null;
            case "auto":
                d.AutoQualifiers = p.Number == 1;
                if (d.AutoQualifiers) CircuitWorld.AutoEntry(d);
                else foreach (var game in d.Matches.Where(m => m.Kind is "local" or "city" or "academy" && m.Status == "待赛" && m.Id != d.PendingMatchId)) game.Registered = false;
                return null;
            case "resume": if (w.Run == null) return "没有待恢复的比赛。";
                if (w.Run.Phase != "paused") return "请先保存退出当前比赛，等待全队暂停后继续。";
                w.Run.ResumeCount++; w.Run.FailureReason = ""; w.Run.Phase = "preparing"; return null;
            case "advance":
                if (p.Number <= d.Day || p.Number > d.Day + 84) return "日期范围无效。";
                while (d.Day < p.Number)
                {
                    UseOwnerWallet(w);
                    decimal before = CareerMoney.Balance(d); decimal clubBefore = d.Esports.OwnedClub?.CashFlow ?? 0;
                    if (!CareerEngine.AdvanceOneDay(d)) break;
                    Distribute(w, CareerMoney.Balance(d) - before, clubBefore); AdvanceMembers(w);
                    if (w.Members.Any(m => SocialAppointments.Due(View(w, m)).Any())) break;
                }
                return null;
            case "register":
                var match = d.Matches.FirstOrDefault(m => m.Id == p.Target);
                return match == null ? "赛事已不存在。" : CareerEngine.SetRegistration(d, match, p.Number == 1);
            case "club":
                var offer = d.Esports.Offers.FirstOrDefault(o => o.ClubId == p.Target);
                if (offer == null) return "合同邀请已失效。";
                int credits = d.Credits;
                string? error = EsportsWorld.AcceptOffer(d, offer);
                if (error == null) Distribute(w, d.Credits - credits);
                return error;
            case "start": return Prepare(w, p.Target, p.Number, characters, p.Participants);
            default: return "团队安排无效。";
        }
    }
    private static void AddMoney(CoopMember member, decimal amount)
    {
        decimal balance = member.Credits + member.Life.CreditFraction + amount;
        member.Credits = checked((int)decimal.Floor(balance));
        member.Life.CreditFraction = balance - member.Credits;
    }
    private static void UseOwnerWallet(CoopWorld w)
    {
        if (!OwnedClubs.IsOwner(w.World)) return;
        var owner = w.Members.Single(m => m.SteamId == w.Owner);
        w.World.Credits = owner.Credits; w.World.Life.CreditFraction = owner.Life.CreditFraction;
        w.World.PrivateMemorySources = w.Members.ToDictionary(m => m.PersonId, m => m.Life.Mailbox);
    }
    private static void Distribute(CoopWorld w, decimal amount, decimal? clubBefore = null, IReadOnlySet<ulong>? participants = null)
    {
        if (clubBefore.HasValue && w.World.Esports.OwnedClub is { } club)
        {
            decimal clubAmount = club.CashFlow - clubBefore.Value;
            var owner = w.Members.Single(m => m.SteamId == w.Owner); AddMoney(owner, clubAmount);
            if (clubAmount != 0) owner.Life.Ledger.Add(new() { Day = w.World.Day, Title = "俱乐部经营结算", Amount = clubAmount, Balance = owner.Credits + owner.Life.CreditFraction });
            amount -= clubAmount;
        }
        if (amount == 0) { PayClubMembers(w); return; }
        var recipients = w.Members.Where(m => participants == null || participants.Contains(m.SteamId)).OrderBy(m => m.SteamId).ToList();
        decimal quotient = decimal.Truncate(amount / recipients.Count), remainder = amount - quotient * recipients.Count;
        foreach (var m in recipients)
        {
            decimal extra = Math.Clamp(remainder, -1m, 1m); decimal delta = quotient + extra; remainder -= extra;
            AddMoney(m, delta); m.Life.Ledger.Add(new() { Day = w.World.Day, Title = "团队收入分配", Amount = delta, Balance = m.Credits + m.Life.CreditFraction });
        }
        PayClubMembers(w);
    }
    public static void PayClubMembers(CoopWorld w)
    {
        var d = w.World;
        if (!OwnedClubs.IsOwner(d)) return;
        var o = d.Esports.OwnedClub!;
        var host = w.Members.Single(m => m.SteamId == w.Owner);
        var guests = w.Members.Where(m => m.SteamId != w.Owner && o.HumanPayDue.GetValueOrDefault(m.PersonId) > 0).OrderBy(m => m.SteamId).ToList();
        long total = guests.Sum(m => (long)o.HumanPayDue[m.PersonId]);
        int budget = (int)Math.Min(Math.Max(0, host.Credits), total);
        d.Credits = host.Credits; d.Life.CreditFraction = host.Life.CreditFraction;
        foreach (var guest in guests)
        {
            int due = o.HumanPayDue[guest.PersonId];
            int payment = (int)((long)budget * due / total);
            budget -= payment; total -= due;
            if (payment == 0) continue;
            o.HumanPayDue[guest.PersonId] -= payment;
            string title = guest.Name + "工资与比赛奖金";
            OwnedClubs.Pay(d, title, -payment);
            host.Credits = d.Credits; host.Life.CreditFraction = d.Life.CreditFraction;
            host.Life.Ledger.Add(new() { Day = d.Day, Title = title, Amount = -payment, Balance = host.Credits + host.Life.CreditFraction });
            guest.Credits += payment;
            guest.Life.Ledger.Add(new() { Day = d.Day, Title = "俱乐部工资与比赛奖金", Amount = payment, Balance = guest.Credits + guest.Life.CreditFraction });
        }
    }
    public static void AdvanceMembers(CoopWorld w)
    {
        PayClubMembers(w);
        PayCeremonies(w);
        foreach (var m in w.Members)
        {
            var view = View(w, m);
            CareerLife.Advance(view);
            SocialAppointments.Expire(view);
            if (m.PaidSeason < view.Season) { CareerCommerce.SeasonStart(view); m.PaidSeason = view.Season; }
            else CareerCommerce.RefreshOffers(view);
            Capture(w, m, view);
        }
        w.World.Life.Events.RemoveAll(e => e.Id.StartsWith("human-", StringComparison.Ordinal));
        w.World.Life.Events.AddRange(w.Members.SelectMany(m => m.Life.Events).Select(CoopJson.Copy));
        var events = w.Members.SelectMany(m => m.Life.Events).Where(e => e.PostId.Length == 0 && e.Day < w.World.Day && e.Day >= w.World.Day - 7)
            .OrderByDescending(e => e.Important).ThenByDescending(e => e.Day).Take(8).ToList();
        if (events.Count > 0 && w.World.Ai.Enabled)
        {
            string key = "life-update-" + w.World.Day;
            CareerEngine.Publish(w.World, key, w.Name + "的近期安排", string.Join("\n", events.Select(e => $"第 {e.Day} 天 · {e.Title} · {e.Detail}")), "人物日常", true, events.SelectMany(e => e.People).Distinct().ToList());
            if (w.World.Posts.FirstOrDefault(p => p.EventKey == key) is { } post) foreach (var e in events) e.PostId = post.Id;
        }
    }
    public static void PayCeremonies(CoopWorld w)
    {
        foreach (var record in w.World.Ceremonies)
        foreach (var member in w.Members)
        {
            foreach (var award in record.Awards.Where(a => a.WinnerId == member.PersonId || a.Recipients.Contains(member.PersonId)
                || record.RulesVersion < 2 && (a.WinnerId == "player" || a.ClubId.Length > 0 && w.World.Esports.Competitions.Any(c =>
                    c.Season <= record.Season && c.Season >= (a.Title.StartsWith("年度") ? record.Season - 3 : record.Season)
                    && c.EntrantClubs.GetValueOrDefault("player") == a.ClubId && c.Fixtures.Any(f => f.Finished && !f.Walkover && (f.HomeId == "player" || f.AwayId == "player"))))))
            {
                string key = SeasonCeremony.RewardKey(record, award);
                if (!member.CeremonyReceipts.Add(key)) continue;
                member.Fans += SeasonCeremony.RewardAmount(award);
                member.CeremonyHonors.Add(new() { Id = key, Season = record.Season, Day = record.Day, Title = award.Title, Detail = award.Reason });
            }
            var top = record.YearTop.FirstOrDefault(r => r.Id == member.PersonId || record.RulesVersion < 2 && r.Id == "player");
            if (top != null && member.CeremonyReceipts.Add("top20-" + record.Season))
            {
                member.Fans += 120;
                member.CeremonyHonors.Add(new() { Id = "top20-" + record.Season, Season = record.Season, Day = record.Day,
                    Title = $"年度 TOP 20 · 第{(top.Place > 0 ? top.Place : record.YearTop.IndexOf(top) + 1)}名", Detail = $"共同成绩，年度评选{top.Score}分。" });
            }
        }
    }
    public static List<CareerPerson> Opponents(CoopWorld w, CareerMatch match)
    {
        var competition = w.World.Esports.Competitions.FirstOrDefault(c => c.Id == match.CompetitionId);
        var result = CircuitWorld.CooperativeRoster(w.World, competition, match.OpponentId, match.Seed);
        if (result.Count != w.World.CooperativeMembers) throw new InvalidOperationException("对手队伍人数不足，赛事不能开始。");
        return result;
    }
    public static string? Prepare(CoopWorld w, string matchId, int ascension, IReadOnlySet<string> characters, IReadOnlySet<ulong>? participants = null)
    {
        var d = w.World; var m = d.Matches.FirstOrDefault(m => m.Id == matchId);
        if (m == null || m.Status != "待赛" || !m.Registered || m.Day != d.Day || d.PendingMatchId != null || w.Run != null) return "这场比赛当前不能开始。";
        if (ascension < m.RequiredAscension || ascension > 10) return "挑战进阶超出本场范围。";
        if (EsportsWorld.EntryReason(d, m) is { } error) return error;
        var roster = w.Members.Where(m => participants == null || participants.Contains(m.SteamId)).ToList();
        if (characters.Count == 0 || roster.Count is < 2 or > 4 || roster.Any(m => !m.RandomCharacter && !characters.Contains(m.Character))) return "请在线队员选择可用角色（2—4人）。";
        SetParticipants(w, roster.Select(m => m.SteamId).ToHashSet());
        // 原版多人大厅会规范化自定义种子；绑定与模拟必须使用同一规范形式。
        MatchRules.PrepareSeed(d, m);
        m.Seed = m.Seed.ToUpperInvariant().Replace('O', '0').Replace('I', '1').Trim();
        var rivals = Opponents(w, m);
        // 团队表现取决于整体能力与配合，不复制某一人的单人成绩。
        var competition = d.Esports.Competitions.FirstOrDefault(c => c.Id == m.CompetitionId);
        var perf = MatchRules.Simulate(d, m.OpponentId, m.RequiredAscension, d.WorldId + ":coop:" + m.Seed, m.Day, true,
            competition, m.Seed);
        m.OpponentPrepared = true; m.OpponentWon = perf.Cleared; m.OpponentFloor = perf.Floor; m.OpponentSeconds = perf.Seconds;
        w.Run = new() { MatchId = m.Id, Seed = m.Seed, Ascension = ascension, Characters = roster.ToDictionary(p => p.SteamId, p => p.RandomCharacter ? CareerEngine.RandomCharacterChoice : p.Character), Opponents = rivals.Select(p => p.Id).ToList() };
        d.Failure = null;
        m.ChosenAscension = d.SelectedAscension = ascension;
        Diagnostics.RecordMatch(w, "prepared");
        w.RosterLocked = true; d.PendingMatchId = m.Id; d.PendingSince = DateTimeOffset.UtcNow.ToUnixTimeSeconds(); return null;
    }
    public static CoopWorld Settle(CoopWorld original, string attempt, bool clear, bool abandoned, int floor, double seconds, List<CoopLivePlayer> players, Dictionary<ulong, CareerResult>? details = null, bool confirmFailure = false, bool forfeit = false)
    {
        clear = clear && !abandoned;
        if (original.Settlements.Any(s => s.Attempt == attempt)) return original;
        if (original.Run is not { } run || run.Attempt != attempt || !double.IsFinite(seconds) || seconds < 0 || clear && seconds <= 0) throw new InvalidOperationException("结算对局不匹配。");
        if (!players.Select(p => p.Id).Order().SequenceEqual(run.Characters.Keys.Order())) throw new InvalidOperationException("结算成员不完整。");
        var w = CoopJson.Copy(original); CoopJson.Detached(w.World); var d = w.World;
        UseOwnerWallet(w);
        decimal clubBefore = d.Esports.OwnedClub?.CashFlow ?? 0;
        var match = d.Matches.Single(m => m.Id == run.MatchId); decimal money = CareerMoney.Balance(d); int day = d.Day, rating = d.Rating, fans = d.Fans;
        var participants = run.Characters.Keys.ToHashSet();
        var played = w.Members.Where(m => participants.Contains(m.SteamId)).ToList();
        SetParticipants(w, participants);
        var before = played.ToDictionary(m => m.SteamId, m => m.Credits);
        // 遭遇属于共同路线，世界战报保存一次；各人的生命、药水与牌组仍分别保存。
        var teamEvidence = new RunEvidence
        {
            DefeatedEncounters = details?.Values.FirstOrDefault(p => p.Evidence.DefeatedEncounters != null)?.Evidence.DefeatedEncounters?.ToList()
        };
        Diagnostics.RecordMatch(w, "settlement-input", new { clear, abandoned, floor, seconds, players, details }, includePlan: true);
        CareerEngine.FinishMatch(d, match, clear, abandoned, floor, "合作队伍", run.Ascension, [], seconds, evidence: teamEvidence, confirmFailure: confirmFailure, forfeit: forfeit);
        if (d.Failure is { } pending)
        {
            pending.Result.PlayerParticipants = played.Select(m => m.PersonId).ToList();
            pending.Result.OpponentParticipants = run.Opponents.ToList();
            w.Run!.Terminal = new(clear, floor, seconds, players) { Details = details ?? [] };
            w.Run.Phase = "decision"; w.LatestCheckpoint = ""; w.Revision++; return w;
        }
        Diagnostics.RecordMatch(w, "settlement-output", new { match.PlayerWon, match.Draw, result = d.Results.LastOrDefault(r => r.MatchId == match.Id) });
        if (match.Status == "待赛")
        {
            // 同成绩加赛沿用原有规则，释放原版对局后全队重新确认下一次尝试。
            w.Run = null; w.LatestCheckpoint = ""; w.Revision++; return w;
        }
        Distribute(w, CareerMoney.Balance(d) - money, clubBefore, participants);
        var record = d.Results.Last(r => r.MatchId == match.Id);
        record.PlayerParticipants = played.Select(m => m.PersonId).ToList();
        record.OpponentParticipants = run.Opponents.ToList();
        foreach (var member in played)
        {
            int priorRating = member.Rating, priorFans = member.Fans;
            member.Rating = Math.Max(500, member.Rating + d.Rating - rating); member.Fans += d.Fans - fans;
            if (!PrivateAppointments.IsPrivate(match)) { if (match.Draw) member.Draws++; else if (match.PlayerWon) member.Wins++; else member.Losses++; }
            if (clear && !abandoned) member.HighestClear = Math.Max(member.HighestClear, run.Ascension);
            var personal = CoopJson.Copy(record); personal.Character = member.Character; personal.CharacterId = member.Character;
            if (details?.TryGetValue(member.SteamId, out var detail) == true)
            { personal.Character = detail.Character; personal.CharacterId = detail.CharacterId.Length > 0 ? detail.CharacterId : member.Character; personal.Cards = detail.Cards; personal.DeckSummary = detail.DeckSummary; personal.Evidence = detail.Evidence; }
            member.Results.Add(personal); if (member.Results.Count > 200) member.Results.RemoveAt(0);
            var view = View(w, member);
            if (!PrivateAppointments.IsPrivate(match)) { CareerCommerce.PlayerMatch(view, match); CareerRelics.Match(view, match, view.Results.Last(), false, member.Rating - record.RatingDelta); }
            var personalResult = view.Results.Last();
            personalResult.Prize = view.Credits - before[member.SteamId];
            personalResult.RatingDelta = view.Rating - priorRating; personalResult.FansDelta = view.Fans - priorFans;
            if (personalResult.Settlement is { } summary) { summary.Credits = view.Credits; summary.Fans = view.Fans; summary.Rating = view.Rating; }
            Capture(w, member, view);
        }
        if (d.Day != day) AdvanceMembers(w);
        w.Settlements.Add(new() { Attempt = attempt, MatchId = match.Id, Title = match.Event, Outcome = record.Outcome, Cleared = clear, Floor = floor, Seconds = seconds, Day = day,
            Players = players, Payouts = played.ToDictionary(m => m.SteamId, m => m.Credits - before[m.SteamId]), Rankings = record.Settlement });
        if (w.Settlements.Count > 100) w.Settlements.RemoveAt(0);
        var post = d.Posts.FirstOrDefault(p => p.EventKey == "match" + match.Id);
        if (post != null)
        {
            post.SourceBody += "\n本场为合作队伍赛，全体真人共同爬塔。队员为" + string.Join("、", played.Select(m => m.Name)) + "。对手全队为" + string.Join("、", run.Opponents.Select(id => CareerEngine.DisplayName(d, id))) + "。";
            if (details != null) foreach (var member in played)
                if (details.TryGetValue(member.SteamId, out var detail))
                    post.SourceBody += $"\n{member.Name}使用{detail.Character}，{detail.Evidence.ResourceSummary()}，牌组为{string.Join("、", detail.DeckSummary)}。";
            post.RelatedPeople.AddRange(played.Select(m => m.PersonId)); CommunityThreads.Remember(d, post);
        }
        w.Run = null; w.LatestCheckpoint = ""; w.Revision++; RefreshPeople(w); return w;
    }
}
