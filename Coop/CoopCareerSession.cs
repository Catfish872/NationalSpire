using Godot;

namespace NationalSpire.Coop;

/// <summary>共用界面显示个人视图，操作由主机提交，不替换单人全局存档。</summary>
public sealed class CoopCareerSession : ICareerSession
{
    private readonly CoopCoordinator _session;
    private readonly Control _menu;
    private long _revision = -1;
    private string _presence = "";
    private CoopCommand? _pending;
    private int _queuedCeremony;
    private Action? _accepted;
    public CareerData Data { get; private set; } = null!;
    public bool Host => _session.Host;
    public bool Alive => CoopRuntime.Current?.Session == _session && _session.World != null;
    public event Action<string, bool>? Message;
    public string Status => $"多人模式 · 在线 {_session.Online.Count}人 · " + (Host ? "你是房主，开赛时全员准备" : "房主负责团队安排，你可以处理个人事务");
    public bool CanResume => Host && _session.Full && _session.World?.Run is { Phase: "paused", Terminal: null } && _session.World.Proposal == null;
    public string RunStatus => _session.World?.Run is { } run
        ? run.Phase == "paused" ? (run.FailureReason.Length > 0 ? "连接失败：" + run.FailureReason : "比赛已暂停，等待全队继续。")
        : CoopRuntime.Current?.Native?.Status is { Length: > 0 } status ? status : "正在连接比赛，请稍候。" : "";
    public string ProposalId => _session.World?.Proposal?.Id ?? "";
    public IReadOnlyList<CareerTeamMember> Team => _session.World!.Members.Where(m => _session.World.Run is { } run ? run.Characters.ContainsKey(m.SteamId) : _session.Online.Contains(m.SteamId)).Select(m =>
    {
        var last = m.Results.LastOrDefault();
        string character = _session.World!.Run?.Characters.GetValueOrDefault(m.SteamId) ?? m.Character;
        string detail = last == null ? "尚无本生涯战绩" : last.Event + " · " + last.Outcome + " · 收入 " + CareerMoney.Format(last.Prize);
        return new CareerTeamMember(m.SteamId == _session.Self ? "player" : m.PersonId, m.Name,
            character == CareerEngine.RandomCharacterChoice || m.RandomCharacter && _session.World.Run == null ? "随机角色 · 开赛时确定" : GameBridge.Characters().FirstOrDefault(c => c.Id.ToString() == character)?.Title.GetFormattedText() ?? character, detail);
    }).ToList();
    public IReadOnlyList<string> Opponents(CareerMatch match) =>
        _session.World!.Run is { } run && run.MatchId == match.Id ? run.Opponents :
        CoopRules.Opponents(_session.World, match).Select(p => p.Id).ToList();
    public bool HasVoted => _session.World?.Proposal?.Votes.Contains(_session.Self) == true
        || _pending is { Kind: "confirm" } pending && pending.Target == ProposalId;
    public string ProposalText => _session.World?.Proposal is { } p ? p.Label + "\n" + string.Join("  /  ", _session.World.Members.Where(m => p.Participants.Contains(m.SteamId)).Select(m => m.Name + (p.Votes.Contains(m.SteamId) ? " 已同意" : " 等待确认"))) : "";
    public CoopCareerSession(CoopCoordinator session, Control menu)
    { _session = session; _menu = menu; _session.Replied += Replied; Refresh(); }
    public bool Refresh()
    {
        if (!Alive) return false;
        if (_pending == null && _queuedCeremony > 0)
        {
            int season = _queuedCeremony; _queuedCeremony = 0;
            Send("ceremony-read", season.ToString());
        }
        var w = _session.World!; string presence = string.Join(',', _session.Online.Order()) + "|" + RunStatus + "|" + _pending?.Id;
        if (Data != null && _revision == w.Revision && _presence == presence) return false;
        _revision = w.Revision; _presence = presence;
        var member = w.Members.Single(m => m.SteamId == _session.Self);
        Data = CoopRules.View(w, member);
        Data.Esports.PlayerContract = w.World.Esports.PlayerContract == null ? null : CoopJson.Copy(w.World.Esports.PlayerContract);
        Data.PendingMatchId = w.World.Failure == null ? w.Run?.MatchId : null;
        foreach (var thread in CommunityThreads.All(Data))
        {
            if (thread.AuthorId == member.PersonId) thread.AuthorId = "player";
            foreach (var reply in thread.Replies) if (reply.AuthorId == member.PersonId) reply.AuthorId = "player";
        }
        foreach (var post in CommunityThreads.All(Data)) post.SeenRevision = member.ReadPosts.GetValueOrDefault(post.Id);
        foreach (var issue in Data.WeeklyEditions) issue.SeenRevision = member.ReadWeeks.GetValueOrDefault(issue.Week);
        Data.PendingSettlementId = member.SeenSettlement == Data.Results.LastOrDefault()?.MatchId ? "" : Data.Results.LastOrDefault()?.MatchId ?? "";
        if (Host) Data.Ai = AiSettingsStore.Load(new());
        var view = Data;
        Data.ExternalCurrent = () => Alive && ReferenceEquals(Data, view);
        Data.ExternalSave = SaveReading;
        return true;
    }
    private void SaveReading(CareerData data)
    {
        if (!Alive || _pending != null || !ReferenceEquals(data, Data)) return;
        var member = _session.World!.Members.Single(m => m.SteamId == _session.Self);
        var reading = new CoopReading();
        foreach (var post in CommunityThreads.All(data).Where(p => p.SeenRevision > member.ReadPosts.GetValueOrDefault(p.Id)).Take(80)) reading.Posts[post.Id] = post.SeenRevision;
        foreach (var week in data.WeeklyEditions.Where(w => w.SeenRevision > member.ReadWeeks.GetValueOrDefault(w.Week))) reading.Weeks[week.Week] = week.SeenRevision;
        if (data.PendingSettlementId.Length == 0 && data.Results.LastOrDefault()?.MatchId is { } id && member.SeenSettlement != id) reading.Settlement = id;
        if (reading.Posts.Count > 0 || reading.Weeks.Count > 0 || reading.Settlement.Length > 0)
            Send("reading", text: System.Text.Json.JsonSerializer.Serialize(reading, CoopJson.Options));
    }
    public void Send(string kind, string target = "", string text = "", int number = 0, string parent = "", Action? accepted = null)
    {
        if (!Alive) { Message?.Invoke("房间已断开，请返回队伍重新加入。", true); return; }
        if (kind == "ceremony-read" && _pending != null)
        { if (int.TryParse(target, out int season)) _queuedCeremony = Math.Max(_queuedCeremony, season); return; }
        if (_pending != null) { Message?.Invoke("正在同步上一项操作。", false); return; }
        var w = _session.World!;
        _pending = new(w.Id, w.Epoch, Guid.NewGuid().ToString("N"), w.Revision, kind, target, text, number, parent); _accepted = accepted;
        if (!Host && kind == "confirm") Message?.Invoke("已提交准备，等待同步。", false);
        try { _session.Retry(_pending); }
        catch (Exception e) { _pending = null; _accepted = null; Message?.Invoke(e.Message, true); }
    }
    private void Replied(CoopReply reply)
    {
        if (_pending?.Id != reply.Id) return;
        bool silent = _pending.Kind is "reading" or "ceremony-read" || _pending.Kind.StartsWith("dm-");
        var action = _accepted; _pending = null; _accepted = null;
        if (reply.Outcome.Accepted) { action?.Invoke(); }
        if (!silent || !reply.Outcome.Accepted) Message?.Invoke(reply.Outcome.Accepted ? (ProposalId.Length > 0 ? "提议已提交，等待队员确认。" : "操作已完成。") : reply.Outcome.Message, !reply.Outcome.Accepted);
    }
    public void SaveAi(CareerData data)
    {
        if (!Host) throw new InvalidOperationException("AI 设置由主机管理。");
        AiSettingsStore.Save(data.Ai); AiService.RefreshConcurrency(data.Ai);
        var world = CoopJson.Copy(_session.World!); world.World.Ai.Enabled = data.Ai.Enabled; world.Revision++;
        WeeklyJournal.ActivateLatest(world.World);
        _session.Commit(world, _session.NativeSave);
        if (!data.Ai.Enabled) CoopRuntime.Current!.Ai?.Stop();
    }
    public void Generate(bool retry = false)
    { if (Host) _ = CoopRuntime.Current!.Ai!.Process(retry); else Message?.Invoke("生成与重试由主机处理。", false); }
    public void OpenRoom() => CoopScreen.Open(_menu, true);
    public async Task<string> Export()
    {
        var reports = await _session.CollectDiagnostics();
        if (_session.World == null) throw new InvalidOperationException("房间已关闭，请重新连接后导出。");
        return Diagnostics.Export(_session.World.World, System.IO.Path.Combine(CoopSettings.Root, _session.World.Id),
            ProjectSettings.GlobalizePath("user://logs"), CoopRuntime.Current?.Status ?? "房间已关闭",
            new { world = CoopStorage.PublicCopy(_session.World), originalRun = _session.NativeSave, online = _session.Online.ToArray(), self = _session.Self }, reports);
    }
    public void Dispose() { _session.Replied -= Replied; }
}
