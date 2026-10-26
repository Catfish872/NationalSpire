namespace NationalSpire;

public sealed class DateGameState
{
    public string Host { get; set; } = "";
    public string OfferId { get; set; } = "";
    public string TurnId { get; set; } = "";
    public List<string> People { get; set; } = [];
    public Dictionary<string, string> Voices { get; set; } = [];
    public bool ReturnPending { get; set; }
    public string ResultTurnId { get; set; } = "";
    public List<CareerMatch> Companions { get; set; } = [];
    public HashSet<string> Fired { get; set; } = [];
    public List<DateGameFact> Facts { get; set; } = [];
    public string PendingChat { get; set; } = "";
    public string PendingSpeaker { get; set; } = "";
    public string PendingLine { get; set; } = "";
    public double PendingUntil { get; set; }
    public string Snapshot { get; set; } = "";
    public double LastChat { get; set; } = -20;
    public double LastSpeech { get; set; } = -10;
}

public sealed class DateGameRule
{
    public string Trigger { get; set; } = "fast";
    public bool Enabled { get; set; } = true;
    public bool Chat { get; set; }
    public double Threshold { get; set; }
    public List<string> Lines { get; set; } = [];
}

/// <summary>约会切磋绑定原生日程；固定赛果保持一致，交流学习沿用人物成长。</summary>
public static class DateGames
{
    public const string AttachmentKind = "date-game";
    public const double ChatRequestSeconds = 20;
    public const double ChatRequestInterval = 20;
    public static void RequestChat(CareerData data, DateGameState game, string person, string line, string context, double seconds)
    {
        game.LastChat = seconds;
        game.PendingSpeaker = person; game.PendingLine = line; game.PendingUntil = seconds + ChatRequestSeconds;
        game.PendingChat = CareerEngine.DisplayName(data, person) + "：" + line + (context.Length > 0 ? "\n" + context : "");
    }
    public static void ClearChatRequest(DateGameState game)
    { game.PendingChat = game.PendingSpeaker = game.PendingLine = ""; game.PendingUntil = 0; }
    public static bool TickChatRequest(CareerData data, DateGameState game, double seconds, bool accepted = false)
    {
        if (game.PendingChat.Length == 0) return false;
        if (game.PendingUntil <= 0)
        {
            // 旧存档的待回应台词在首次恢复时开始完整计时。
            game.PendingUntil = seconds + ChatRequestSeconds;
            game.PendingSpeaker = game.People.FirstOrDefault(p => game.PendingChat.StartsWith(CareerEngine.DisplayName(data, p) + "：", StringComparison.Ordinal)) ?? game.Host;
            string prefix = CareerEngine.DisplayName(data, game.PendingSpeaker) + "：";
            game.PendingLine = game.PendingChat.Split('\n')[0];
            if (game.PendingLine.StartsWith(prefix, StringComparison.Ordinal)) game.PendingLine = game.PendingLine[prefix.Length..];
            return true;
        }
        if (!accepted && game.PendingUntil > seconds + ChatRequestSeconds)
        { game.PendingUntil = seconds + ChatRequestSeconds; return true; }
        if (!accepted && seconds >= game.PendingUntil) { ClearChatRequest(game); return true; }
        return false;
    }
    public static string? ValidateContext(CareerData data, PrivateConversation conversation, DateSceneRequest request, bool retained = false)
    {
        bool saved = retained || conversation.Turns.Any(t => ReferenceEquals(t.Scene, request));
        string? matchId = request.GameEvent.Length > 0 || saved && request.GameMatchId.Length > 0 ? request.GameMatchId : data.PendingMatchId;
        var match = data.Matches.FirstOrDefault(m => m.Id == matchId);
        var game = match?.DateGame;
        bool belongs = game != null && game.Host == conversation.PersonId && game.OfferId == request.OfferId;
        if (saved && request.GameMatchId.Length > 0 && (!belongs || data.PendingMatchId != null && data.PendingMatchId != request.GameMatchId
            || data.PendingMatchId == null && match!.Status != "已结算")) return "这条消息对应的对局已变化，请返回当前对局重新回应。";
        if (request.GameEvent.Length > 0 && (!belongs || data.LocalHumanId.Length > 0
            || request.GameEvent is not ("request" or "result")
            || request.GameEvent == "request" && data.PendingMatchId != match!.Id
            || request.GameEvent == "result" && match!.Status != "已结算")) return "约会对局的进程关联已失效。";
        // 聊天缘由在首次入队后保留；进度每次取当前绑定对局的最新观测。
        string chat = saved ? request.GameChatRequest : "";
        const string legacyChat = "\nNPC发起聊天：";
        if (saved && chat.Length == 0 && request.GameContext.IndexOf(legacyChat, StringComparison.Ordinal) is >= 0 and var at)
            chat = request.GameContext[(at + legacyChat.Length)..];
        if (!saved || request.GameMatchId.Length == 0) chat = belongs ? game!.PendingChat : "";
        request.GameMatchId = belongs ? match!.Id : "";
        request.GameChatRequest = belongs ? chat : "";
        request.GameContext = belongs ? game!.Snapshot + (chat.Length > 0 ? "\nNPC发起聊天：" + chat : "") : "";
        if (belongs && match!.Status == "已结算")
        {
            var result = data.Results.LastOrDefault(r => r.MatchId == match.Id);
            request.GameContext += $"\n本局已经结束。玩家到达{match.PlayerFloor}层，用时{MatchRules.Time(match.PlayerSeconds ?? 0)}，"
                + (result == null ? "" : $"原版通关：{(result.Win ? "是" : "否")}；切磋结果：{result.Outcome}。")
                + $"\n{CareerEngine.DisplayName(data, match.OpponentId)}的模拟成绩：{match.OpponentFloor}层，{(match.OpponentWon ? "通关" : "未通关")}。"
                + "\n从结束对局的这一刻主动开始交流，结合本局表现与刚才的聊天说出感想。";
        }
        return null;
    }
    public static string PromptContext(DateSceneRequest request) => request.GameContext.Length == 0 ? "" :
        "<current_date_game>\n当前对局编号：" + request.GameMatchId + "\n本轮核验的对局进程与聊天缘由：\n" + request.GameContext
        + "\n楼层、生命、用时和胜负以本块为准。聊天缘由描述本局触发请求时发生的事情，最新进度表示玩家回应时的现状。历史聊天中的其他对局及较早进度属于过去，不能作为当前战况。\n</current_date_game>";
    public static string HistorySource(PrivateTurn turn) => turn.Scene is { } scene && (scene.GameMatchId.Length > 0 || scene.GameContext.Length > 0)
        ? "历史约会对局" + (scene.GameMatchId.Length > 0 ? " · 编号 " + scene.GameMatchId : "（旧记录未保存对局编号）") + "；以下是当时的交流，当前战况见本轮进程。" : "";
    public static string? FollowUp(CareerData data, PrivateConversation conversation, DateSceneRequest request)
    {
        if (request.GameEvent is not ("request" or "result")) return "请选择有效的对局返回事件。";
        if (DateScenes.Validate(data, conversation, request) is { } error) return error;
        var game = data.Matches.First(m => m.Id == request.GameMatchId).DateGame!;
        if (request.GameEvent == "result" && game.ResultTurnId.Length > 0
            && conversation.Turns.Any(t => t.Id == game.ResultTurnId && !t.ReplyDeleted)) return null;
        if (request.GameEvent == "request" && game.PendingChat.Length == 0) return "这条聊天请求已经处理。";
        if (request.GameEvent != "result" && (AiService.PrivateBusy(data, conversation.PersonId)
            || conversation.Turns.Any(t => t.Status is "queued" or "sending"))) return "请等待当前回复完成，再回应聊天请求。";
        request.GameInvitation = request.Opening = request.Ending = false;
        var turn = PrivateMessages.Enqueue(data, conversation.PersonId, request.GameEvent == "result"
            ? "（对局结束，请根据本局过程和结果主动继续约会对话。）"
            : "（玩家回应了聊天请求。请结合刚才提出的事情和双方当前的对局进程，主动接着说。）", queueAfterCurrent: request.GameEvent == "result");
        turn.Scene = Coop.CoopJson.Copy(request);
        conversation.DateSceneStates[request.OfferId] = "active";
        if (request.GameEvent == "result") game.ResultTurnId = turn.Id;
        ClearChatRequest(game);
        return null;
    }
    public static string? Cancel(CareerData data, string host, string offer)
    {
        var match = Find(data, host, offer);
        if (match == null || data.PendingMatchId == match.Id) return "该对局当前无法取消。";
        match.Status = "已取消";
        foreach (var card in PrivateMessages.Conversation(data, host).Offers.Where(o => o.MatchId == match.Id)) card.State = "已取消";
        return null;
    }
    public const string InvitationProtocol = "玩家邀请大家在约会期间一起玩《杀戮尖塔2》切磋。每名参与者依据意愿回应，随后各自输出 [DateGame: 接受, Actor: 完整PersonId] 或 [DateGame: 拒绝, Actor: 完整PersonId]。全部接受后玩家可开始游戏。";
    public static CareerMatch? Find(CareerData data, string host, string offer)
        => data.Matches.LastOrDefault(m => m.DateGame is { } g && g.Host == host && g.OfferId == offer && m.Status == "待赛");
    // 原生对局直到结算前仍保留待赛状态；开局选项还须检查当前生涯的运行绑定。
    public static CareerMatch? AwaitingStart(CareerData data, string host, string offer)
        => data.PendingMatchId == null ? Find(data, host, offer) : null;
    public static CareerMatch? InProgress(CareerData data, string host, string offer)
        => data.PendingMatchId == null ? null : data.Matches.FirstOrDefault(m => m.Id == data.PendingMatchId
            && m.Status == "待赛" && m.DateGame is { } g && g.Host == host && g.OfferId == offer);
    public static void Respond(CareerData data, PrivateConversation c, PrivateTurn turn, IReadOnlyList<Dictionary<string, string>> directives)
    {
        if (turn.Scene is not { GameInvitation: true } scene || Find(data, c.PersonId, scene.OfferId) != null) return;
        var offer = c.Offers.FirstOrDefault(o => o.Id == scene.OfferId);
        if (offer == null || !DateScenes.Available(data, offer, c) || data.PendingMatchId != null) return;
        var people = DateSceneParty.People(data, offer, c.PersonId);
        foreach (string person in people)
        {
            var answer = directives.LastOrDefault(d => d.ContainsKey("DateGame") && (d.GetValueOrDefault("Actor") == person || people.Count == 1 && !d.ContainsKey("Actor")));
            if (answer?.GetValueOrDefault("DateGame") != "接受") return;
        }
        var match = PrivateAppointments.CreateMatch(data, c.PersonId, data.Day, 0, "切磋", "约会");
        match.DateGame = new() { Host = c.PersonId, OfferId = offer.Id, TurnId = turn.Id, People = people };
        c.Offers.Add(new() { Kind = "match", Id = "date-game-" + match.Id, TurnId = turn.Id, MatchId = match.Id,
            State = "已确认", Mode = "切磋", Season = data.Season, Day = SeasonCalendar.Day(data, data.Day), Title = "约会对局" });
    }
    public static List<DateGameRule> Defaults() =>
    [
        new() { Trigger = "fast", Threshold = 65, Chat = true, Lines = ["你走得好快！刚才选牌是怎么考虑的？"] },
        new() { Trigger = "act1", Chat = true, Lines = ["第一幕过了！刚才那场战斗我们聊聊吧。"] },
        new() { Trigger = "act2", Chat = true, Lines = ["第二幕也过了，接下来需要调整哪些地方？"] },
        new() { Trigger = "npc-death", Chat = true, Lines = ["我这边倒下了……陪我想想刚才哪里可以更稳一点？"] },
        new() { Trigger = "npc-damage", Threshold = 35, Chat = true, Lines = ["这一层损失了好多生命，我想听听你的判断。"] },
        new() { Trigger = "player-danger", Threshold = 25, Lines = ["你的生命有点低了，我们稳一点吧。"] },
        new() { Trigger = "gold-spent", Threshold = 300, Chat = true, Lines = ["这一层买了不少东西呢。想听你说说，这些东西准备怎么搭配？"] },
        new() { Trigger = "elite-fast", Threshold = 30, Chat = true, Lines = ["精英这么快就打完了！刚才那套配合可以教教我吗？"] },
        new() { Trigger = "boss-fast", Threshold = 60, Chat = true, Lines = ["首领战结束得好快。刚才决定胜负的是哪一步？"] },
        new() { Trigger = "floor-gap", Threshold = 12, Chat = true, Lines = ["我们的进度已经差了好多层，聊聊各自遇到的情况吧？"] }
    ];
    public static string Label(string trigger) => trigger switch { "fast" => "20层起平均每层用时低于阈值（秒）", "act1" => "玩家通过第一幕", "act2" => "玩家通过第二幕", "npc-death" => "NPC倒下", "npc-damage" => "NPC单层损血达到阈值（%），每幕一次", "player-danger" => "玩家生命低于阈值（%）", "gold-spent" => "单层花费金币达到阈值，每幕一次", "elite-fast" => "精英战用时小于阈值（秒），每幕一次", "boss-fast" => "首领战用时小于阈值（秒），每幕一次", "floor-gap" => "双方相差楼层达到阈值，每局一次", _ => trigger };
    public static List<DateGameRule> UpgradeRules(IEnumerable<DateGameRule> rules)
    {
        var defaults = Defaults(); var ids = defaults.Select(r => r.Trigger).ToHashSet();
        var result = rules.Where(r => ids.Contains(r.Trigger)).DistinctBy(r => r.Trigger).ToList();
        result.AddRange(defaults.Where(r => result.All(old => old.Trigger != r.Trigger)));
        return result;
    }
    public static bool Upgrade(CareerData data)
    {
        var rules = UpgradeRules(data.DateGameRules);
        bool changed = !rules.Select(r => r.Trigger).SequenceEqual(data.DateGameRules.Select(r => r.Trigger)) || data.DateGameTiming.FastMinimumFloor < 20;
        if (changed) { data.DateGameRules = rules; data.DateGameTiming.FastMinimumFloor = Math.Max(20, data.DateGameTiming.FastMinimumFloor); }
        return changed;
    }
}
