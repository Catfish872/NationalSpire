using Godot;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Nodes;
using MegaCrit.Sts2.Core.Runs;

namespace NationalSpire;

public partial class LiveRunBridge
{
    internal string DateGameMatchId => _match.DateGame == null ? "" : _match.Id;
    private DateGamePause? _datePause;
    private Button? _dateChatAction;
    private LiveRequestButton? _dateRespondAction;
    private bool _datePauseAccepted, _dateRespondRequested;
    private double _dateOpenRetry;
    private double _dateRequestSeconds = -1;
    private void AdvanceDateRequestClock(double delta, double runSeconds, bool paused)
    {
        // 原版 RunTime 只有整秒；请求沿用其起点，随后按有效游戏帧累计小数秒。
        if (_dateRequestSeconds < 0) _dateRequestSeconds = runSeconds;
        else if (!paused) _dateRequestSeconds += Math.Max(0, delta);
    }
    private double _dateCombatStarted = -1;
    private int _dateCombatAct;
    private readonly Dictionary<string, (AvatarArt Art, AvatarIdentity Identity)> _dateAvatars = [];
    private void UpdateDateGame(LiveMatchState live, RivalProgress primary, double seconds, ref bool changed)
    {
        var game = _match.DateGame!;
        if (_datePause != null) return;
        double requestSeconds = _dateRequestSeconds < 0 ? seconds : _dateRequestSeconds;
        changed |= DateGames.TickChatRequest(_data, game, requestSeconds, _datePauseAccepted);
        var npcs = new List<DateGameNpc> { new(_rival.Id, primary, live.MaxHp) };
        foreach (string person in game.People.Where(p => p != _rival.Id))
        {
            var npc = CareerEngine.Person(_data, person); if (npc == null) continue;
            var companion = game.Companions.FirstOrDefault(c => c.OpponentId == person);
            if (companion == null)
            {
                companion = new() { Id = _match.Id + "/" + person, Kind = "private-friendly", Day = _match.Day, Seed = _match.Seed,
                    SeedRandomized = true, RequiredAscension = _match.RequiredAscension, ChosenAscension = _match.ChosenAscension, OpponentId = person };
                MatchRules.PrepareOpponent(_data, companion); game.Companions.Add(companion);
                changed = true;
            }
            if (companion.Live == null)
            { companion.Live = RivalSimulation.Create(companion, npc, PlanningMap(), GameCharacterNames.StartingHp(npc.Character)); changed = true; }
            changed |= RivalSimulation.TryAdjustPace(companion.Live, seconds, _run.CurrentActIndex, _run.TotalFloor);
            if (companion.Live.Steps.Count > 0) npcs.Add(new(person, RivalSimulation.At(companion.Live, seconds), companion.Live.MaxHp));
        }
        var player = new DateGameObservation(_run.TotalFloor, _run.CurrentActIndex, _player.Creature.CurrentHp, _player.Creature.MaxHp, seconds,
            _run.CurrentMapPointHistoryEntry?.GetEntry(_player.NetId)?.GoldSpent ?? 0);
        changed |= DateGameTriggers.Observe(game, player, npcs);
        game.Snapshot = $"玩家：第{player.Act + 1}幕、第{player.Floor}层，生命{player.Hp}/{player.MaxHp}，用时{MatchRules.Time(seconds)}，平均每层{seconds / Math.Max(1, player.Floor):F1}秒。\n"
            + string.Join("\n", npcs.Select(n => $"{CareerEngine.DisplayName(_data, n.Person)}：第{n.Progress.Step.Act + 1}幕、第{n.Progress.Step.Floor}层，生命{n.Progress.Hp}/{n.MaxHp}，{(n.Progress.Dead ? "已倒下" : n.Progress.Finished ? "已通关" : RivalSimulation.RoomName(n.Progress.Step.Kind))}。"));
        if (game.PendingChat.Length == 0 && seconds - live.Commentary.LastSpoke >= _data.DateGameTiming.SpeechSeconds && DateGameTriggers.Next(game, _data.DateGameRules, player with { Seconds = requestSeconds }, npcs, Random.Shared.Next(), _data.DateGameTiming) is { } cue)
        {
            DateGameTriggers.Record(game, cue, requestSeconds);
            if (!_dateAvatars.TryGetValue(cue.Person, out var appearance))
                _dateAvatars[cue.Person] = appearance = (CareerAvatars.ForPerson(_data, cue.Person), AvatarHonors.ForPerson(_data, cue.Person));
            string line = DateGameVoices.Event(_data, game, cue, Random.Shared.Next());
            if (cue.Chat) DateGames.RequestChat(_data, game, cue.Person, line, cue.Context, requestSeconds);
            else _hud.Say(CareerEngine.DisplayName(_data, cue.Person), line, "date/" + cue.Key, appearance.Art, appearance.Identity);
            live.Commentary.LastSpoke = seconds;
            changed = true;
        }
        _hud.SetRace("约会对局", string.Join(" · ", npcs.Select(n => CareerEngine.DisplayName(_data, n.Person) + (n.Progress.Dead ? "已倒下" : $" {n.Progress.Step.Floor}层"))), primary.Hp, live.MaxHp, false, seconds);
        UpdateDateGameAction(game, requestSeconds);
        if (_datePauseAccepted && seconds >= _dateOpenRetry && CanOpenDateChat()) { _datePauseAccepted = false; OpenDateGameChat(seconds); }
    }
    private void UpdateDateGameAction(DateGameState game, double seconds)
    {
        if (_dateChatAction == null)
        {
            _dateChatAction = _hud.AddAction("继续约会", () => { _dateRespondRequested = false; _datePauseAccepted = true; _hud.HoldChatRequest(true); });
            _dateChatAction.Name = "DateGameContinue";
        }
        var conversation = PrivateMessages.Conversation(_data, game.Host);
        bool available = conversation.DateSceneStates.GetValueOrDefault(game.OfferId) != "ended";
        if (available && game.PendingChat.Length > 0)
        {
            if (!_dateAvatars.TryGetValue(game.PendingSpeaker, out var appearance))
                _dateAvatars[game.PendingSpeaker] = appearance = (CareerAvatars.ForPerson(_data, game.PendingSpeaker), AvatarHonors.ForPerson(_data, game.PendingSpeaker));
            double remaining = _datePauseAccepted && _dateRespondAction != null ? _dateRespondAction.Remaining : game.PendingUntil - seconds;
            _dateRespondAction = (LiveRequestButton)_hud.ShowChatRequest(game.PendingChat, CareerEngine.DisplayName(_data, game.PendingSpeaker), game.PendingLine,
                appearance.Art, appearance.Identity, remaining, _datePauseAccepted || RunManager.Instance.IsPaused, _dateChatAction,
                () => { _dateRespondRequested = true; _datePauseAccepted = true; });
        }
        else { _hud.ClearChatRequest(); _dateRespondAction = null; }
        _dateChatAction.Disabled = _datePauseAccepted;
        _dateChatAction.TooltipText = _datePauseAccepted ? "当前动作结束后进入约会" : "";
        _dateChatAction.Visible = available;
    }
    private bool CanOpenDateChat() => _datePause == null && CareerScreen.Current == null && !RunManager.Instance.IsPaused
        && !RunManager.Instance.IsGameOver && !CombatManager.Instance.IsAboutToLose
        && (!CombatManager.Instance.IsInProgress || !CombatManager.Instance.EndingPlayerTurnPhaseOne
            && !CombatManager.Instance.EndingPlayerTurnPhaseTwo && !CombatManager.Instance.IsEnemyTurnStarted)
        && !CombatManager.Instance.IsStarting && !CombatManager.Instance.IsEnding
        && RunManager.Instance.ActionQueueSet.IsEmpty && RunManager.Instance.ActionExecutor.CurrentlyRunningAction == null
        && !RunManager.Instance.ActionExecutor.IsPaused && !CombatManager.Instance.IsPaused;
    private void OpenDateGameChat(double seconds)
    {
        if (_match.DateGame is not { } game || !CanOpenDateChat()) return;
        _datePause = new DateGamePause(_player.NetId);
        try
        {
            _datePause.Acquire();
            _hud.HoldChatRequest(true);
            if (!CareerScreen.OpenRunDate((NRun)GetParent(), _match, ResumeDateRun, _dateRespondRequested))
            { ResumeDateRun(); _dateOpenRetry = seconds + 15; _hud.Say("约会", "暂时无法打开约会，可点击聊天再次尝试。", "date/error"); }
        }
        catch (Exception e) { ResumeDateRun(); _dateOpenRetry = seconds + 15; Diagnostics.Error("date.game.open", e); }
    }
    private void ResumeDateRun() { var pause = _datePause; _datePause = null; pause?.Dispose(); if (IsInstanceValid(_hud)) _hud.HoldChatRequest(false); }
}

/// <summary>取得并归还本次暂停；战斗、队列与计时一起恢复。</summary>
internal sealed class DateGamePause : IDisposable
{
    private bool _acquired, _queuesWerePaused;
    private readonly ulong _player;
    public DateGamePause(ulong player) => _player = player;
    public void Acquire()
    {
        if (_acquired) return;
        _queuesWerePaused = RunManager.Instance.ActionQueueSet.ActionQueueIsPaused(_player);
        _acquired = true;
        RunManager.Instance.IsPaused = true;
        RunManager.Instance.ActionExecutor.Pause();
        CombatManager.Instance.Pause();
        if (!_queuesWerePaused) RunManager.Instance.ActionQueueSet.PauseAllPlayerQueues();
    }
    public void Dispose()
    {
        if (!_acquired) return; _acquired = false;
        if (!RunManager.Instance.IsInProgress) return;
        try { if (!_queuesWerePaused) RunManager.Instance.ActionQueueSet.UnpauseAllPlayerQueues(); }
        finally
        {
            try { CombatManager.Instance.Unpause(); }
            finally
            {
                try { RunManager.Instance.ActionExecutor.Unpause(); }
                finally { RunManager.Instance.IsPaused = false; }
            }
        }
    }
}
