using Godot;
using MegaCrit.Sts2.Core.Nodes.Audio;
using MegaCrit.Sts2.Core.Commands;
using HarmonyLib;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Helpers;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.Characters;
using MegaCrit.Sts2.Core.Nodes;
using MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;
using MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext;
using MegaCrit.Sts2.Core.Random;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Saves;

namespace NationalSpire;

public static class GameBridge
{
    public static string NativeCareerPath => CareerStore.NativeRunPath;
    public static string RecoveryMessageFor(bool multiplayer) => multiplayer
        ? MatchRecovery.Message(true, false, false)
        : MatchRecovery.Message(false, SaveManager.Instance.HasRunSave, RunManager.Instance.IsInProgress);
    public static bool CanReleaseMissingRun => !SaveManager.Instance.HasRunSave && !RunManager.Instance.IsInProgress;
    public static List<CharacterModel> Characters() => ModelDb.AllCharacters.Where(c => c is not RandomCharacter).ToList();
    public static CharacterModel RandomChoice() => ModelDb.Character<RandomCharacter>();
    // 保留当前游戏返回的完整哈希宽度，与原生单人大厅的章节随机源一致。
    public static Rng CreateActSelectionRng(string seed) => GameCompatibility.ActRng(seed);

    public static async Task<string?> StartMatch(CareerMatch match, CharacterModel character, int ascension)
    {
        var data = CareerStore.Data;
        if (data.Failure is { } pending && (!pending.RetryRequested || pending.Result.MatchId != match.Id)) return MatchFailure.Locked(data);
        if (SaveManager.Instance.HasRunSave || RunManager.Instance.IsInProgress) return MatchRecovery.SingleplayerInUse;
        if (data.PendingMatchId != null) return "已有一场生涯比赛进行中。";
        if (!data.Matches.Contains(match) || match.Status != "待赛" || !match.Registered || match.Day != data.Day) return "请先报名并前往比赛日。";
        if (EsportsWorld.EntryReason(data, match) is { } locked) return locked;
        if (ascension < match.RequiredAscension || ascension > 10) return $"本场进阶范围为 {match.RequiredAscension}—10。";
        var clock = System.Diagnostics.Stopwatch.StartNew();
        bool transitionStarted = false;
        string stage = "初始化游戏场景";
        try
        {
            var game = NGame.Instance ?? throw new InvalidOperationException("游戏场景尚未初始化。");
            stage = "准备比赛种子";
            MatchRules.PrepareSeed(data, match);
            stage = "保存开赛前的生涯数据";
            CareerStore.Save(data);
            stage = "读取游戏解锁资料";
            var unlock = SaveManager.Instance.GenerateUnlockStateFromProgress();
            stage = "查找章节选择接口";
            var select = RuntimeApi.Bind(typeof(ActModel), "GetRandomList", true, typeof(Rng), unlock.GetType(), typeof(bool));
            stage = "创建章节随机源";
            var rng = CreateActSelectionRng(match.Seed);
            stage = "生成比赛章节";
            var acts = ((IEnumerable<ActModel>)RuntimeApi.Invoke(select, null, rng, unlock, false)!).ToList();
            // 与原版大厅一致：章节选定后，从同一随机源确定随机角色。
            stage = "确定出场角色";
            if (character is RandomCharacter) character = rng.NextItem(ModelDb.AllCharacters) ?? throw new InvalidOperationException("没有可用角色。");
            stage = "检查原生开局接口";
            var start = RuntimeApi.Bind(typeof(NGame), "StartNewSingleplayerRun", false, typeof(CharacterModel), typeof(bool),
                acts.GetType(), typeof(ModifierModel[]), typeof(string), typeof(GameMode), typeof(int));
            if (!typeof(Task).IsAssignableFrom(start.ReturnType)) throw new NotSupportedException("开局接口的返回类型发生变化。");
            long preparedAt = clock.ElapsedMilliseconds;
            Diagnostics.Record("match.preflight", new { game = GameCompatibility.Version(), rng = GameCompatibility.SeedMode, start = start.ToString() });
            stage = "播放开赛转场";
            transitionStarted = true;
            NAudioManager.Instance?.StopMusic();
            SfxCmd.Play(character.CharacterTransitionSfx);
            await game.Transition.FadeOut(0.4f, character.CharacterSelectTransitionPath);
            stage = "准备比赛对手";
            MatchRules.PrepareOpponent(data, match);
            stage = "保存比赛与生涯的关联";
            match.ChosenAscension = ascension;
            data.PendingMatchId = match.Id;
            data.PendingSince = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            data.PendingHistoryExcluded = SaveManager.Instance.GetAllRunHistoryNames().ToHashSet();
            data.SelectedCharacter = character.Id.ToString();
            data.SelectedAscension = ascension;
            CareerStore.Save(data);
            long savedAt = clock.ElapsedMilliseconds;
            stage = "执行原生开局";
            await (Task)RuntimeApi.Invoke(start, game, character, true, acts, Array.Empty<ModifierModel>(), match.Seed, GameMode.Standard, ascension)!;
            data.Failure = null; CareerStore.Save(data);
            GD.Print($"[NationalSpire] 开局耗时：接口检查及章节选择 {preparedAt}ms，转场及生涯保存 {savedAt - preparedAt}ms，原生开局 {clock.ElapsedMilliseconds - savedAt}ms");
            Diagnostics.Record("match.started", new { match.Id, match.Seed, ascension, saveMs = savedAt - preparedAt, prepareMs = preparedAt, startMs = clock.ElapsedMilliseconds - savedAt });
            return null;
        }
        catch (Exception e)
        {
            var context = new Dictionary<string, Func<object?>>
            {
                ["gameVersion"] = () => GameCompatibility.Version(),
                ["profile"] = () => SaveManager.Instance.CurrentProfileId,
                ["matchId"] = () => match.Id,
                ["seed"] = () => match.Seed,
                ["character"] = () => character.Id.ToString(),
                ["ascension"] = () => ascension,
                ["hasRunSave"] = () => SaveManager.Instance.HasRunSave,
                ["runInProgress"] = () => RunManager.Instance.IsInProgress,
                ["pendingMatchId"] = () => data.PendingMatchId
            };
            string message = Diagnostics.RecordStartFailure(stage, e, context);
            // 对局若已成功写入，保留绑定，允许继续；失败前不产生赛事输赢。
            try
            {
                if (!SaveManager.Instance.HasRunSave && !RunManager.Instance.IsInProgress)
                { data.PendingMatchId = null; data.PendingSince = 0; CareerStore.Save(data); }
            }
            catch (Exception cleanup) { Diagnostics.RecordStartFailure("清理失败的开赛关联", cleanup, context, "match.start.cleanup"); }
            GD.PushError("[NationalSpire] 开局失败：" + e);
            if (transitionStarted && NGame.Instance is { } failedGame)
            {
                try
                {
                    if (failedGame.MainMenu == null) await failedGame.ReturnToMainMenuWithInternalError(e);
                    await failedGame.Transition.FadeIn(0.2f);
                }
                catch (Exception recovery) { Diagnostics.RecordStartFailure("恢复主菜单与画面", recovery, context, "match.start.recovery"); }
            }
            return message;
        }
    }

    public static bool MatchesPending(CareerData data, RunHistory history)
    {
        return CareerRunBinding.Find(data, history.Seed, history.Players.FirstOrDefault()?.Character.ToString() ?? "",
            history.Ascension, history.Players.Count, history.GameMode == GameMode.Standard, history.StartTime) != null;
    }

    public static void CompleteHistory(RunHistory history)
    {
        var data = CareerStore.Data;
        if (!MatchesPending(data, history)) return;
        var match = data.Matches.First(m => m.Id == data.PendingMatchId);
        var detail = ReadPlayerHistory(history, history.Players[0]);
        CareerEngine.FinishMatch(data, match, history.Win, history.WasAbandoned,
            history.MapPointHistory.Sum(a => a.Count), detail.Character, history.Ascension, detail.Cards, history.RunTime, detail.DeckSummary, detail.Evidence, detail.CharacterId);
        PlayerArchive.Invalidate();
        _ = AiService.ProcessPendingAsync();
    }

    public static CareerResult ReadPlayerHistory(RunHistory history, RunHistoryPlayer player)
    {
        var cards = new List<string>();
        var deckNames = new List<string>();
        foreach (var serialized in player.Deck.Where(c => c.Id != null))
        {
            try { var card = CardModel.FromSerializable(serialized); deckNames.Add(GameText.Plain(card.Title)); }
            catch { deckNames.Add(serialized.Id!.ToString()); }
        }
        var deckSummary = deckNames.GroupBy(name => name).Select(g => g.Key + " ×" + g.Count()).ToList();
        var evidence = new RunEvidence { PotionsRecorded = true, PotionSlots = player.MaxPotionSlotCount };
        try { evidence.DefeatedEncounters = ReadDefeatedEncounters(history); }
        catch (Exception e) { Diagnostics.Error("history.encounters", e); }
        var roomStats = history.MapPointHistory.SelectMany(a => a).SelectMany(e => e.PlayerStats).Where(s => s.PlayerId == player.Id).ToList();
        if (roomStats.LastOrDefault() is { MaxHp: > 0 } last)
        { evidence.FinalHp = last.CurrentHp; evidence.MaxHp = last.MaxHp; evidence.PotionsUsed = roomStats.Sum(s => s.PotionUsed.Count); }
        if (roomStats.LastOrDefault() is { } finalStats)
        {
            evidence.PotionsObtained = roomStats.Sum(s => s.PotionChoices.Count(p => p.wasPicked));
            evidence.GoldGained = roomStats.Sum(s => s.GoldGained);
            evidence.RemainingGold = finalStats.CurrentGold;
        }
        foreach (var potion in player.Potions.Where(p => p.Id != null))
        {
            try { evidence.RemainingPotions.Add(GameText.Plain(PotionModel.FromSerializable(potion).Title.GetFormattedText())); }
            catch { evidence.RemainingPotions.Add("未识别药水"); }
        }
        foreach (var badge in player.Badges)
        {
            try
            {
                string prefix = badge.Rarity.ToString().ToLowerInvariant();
                bool tiered = LocString.Exists("badges", badge.Id + "." + prefix + "Title");
                string name = new LocString("badges", badge.Id + (tiered ? "." + prefix + "Title" : ".title")).GetFormattedText();
                string description = new LocString("badges", badge.Id + (tiered ? "." + prefix + "Description" : ".description")).GetFormattedText();
                evidence.Badges.Add(new() { Name = GameText.Plain(name), Description = GameText.Plain(description), Rarity = badge.Rarity.ToString() });
            }
            catch { /* 缺少本地化的徽章不伪造描述，也不阻止结算。 */ }
        }
        // 优先保留升级牌和后续获得的牌，并从序列化状态恢复实际牌面。
        foreach (var serialized in player.Deck.Where(c => c.Id != null)
            .OrderByDescending(c => c.CurrentUpgradeLevel).ThenByDescending(c => c.FloorAddedToDeck ?? 0)
            .DistinctBy(c => c.Id).Take(6))
        {
            try
            {
                var card = CardModel.FromSerializable(serialized);
                string text = GameText.Plain(card.Title + "：" + card.GetDescriptionForPile(PileType.None));
                cards.Add(text);
            }
            catch { /* 已卸载的 Mod 卡牌不阻止结算。 */ }
        }
        return new() { Character = PlayerArchive.CharacterName(player.Character), CharacterId = player.Character.ToString(), Cards = cards, DeckSummary = deckSummary, Evidence = evidence };
    }

    private static List<RunEncounter> ReadDefeatedEncounters(RunHistory history)
    {
        var rooms = new List<RunEncounter>();
        int floor = 0;
        for (int act = 0; act < history.MapPointHistory.Count; act++)
            foreach (var point in history.MapPointHistory[act])
            {
                floor++;
                foreach (var room in point.Rooms)
                {
                    string kind = room.RoomType.ToString(), name = "";
                    if (kind is "Elite" or "Boss" && room.ModelId is { } id)
                    {
                        name = id.Entry;
                        try { name = ModelDb.GetByIdOrNull<EncounterModel>(id)?.Title.GetFormattedText() ?? name; }
                        catch { /* 已卸载的模组遭遇保留标识，不根据地图候选池补造名称。 */ }
                    }
                    // 保留所有房间的位置，终局失败时仅排除最后一个尚未完成的房间。
                    rooms.Add(new(act + 1, floor, kind, GameText.Plain(name.Length > 0 ? name : kind == "Boss" ? "未识别BOSS" : "未识别精英")));
                }
            }
        // 战后领取奖励时退赛仍算击败；只采信同一份原版历史对应的已完成房间。
        var state = RunManager.Instance.DebugOnlyGetState();
        var lastPoint = history.MapPointHistory.LastOrDefault()?.LastOrDefault();
        bool finalRoomCompleted = state != null && ReferenceEquals(state.CurrentMapPointHistoryEntry, lastPoint)
            && state.CurrentRoom is MegaCrit.Sts2.Core.Rooms.CombatRoom { IsPreFinished: true };
        return RunEvidence.CompletedEncounters(rooms, history.Win && !history.WasAbandoned, finalRoomCompleted);
    }

    public static void RecoverPending()
    {
        var data = CareerStore.Data;
        if (data.PendingMatchId == null) return;
        var save = SaveManager.Instance;
        int checkedCount = 0, unreadable = 0;
        foreach (string file in MatchRecovery.HistoryCandidates(save.GetAllRunHistoryNames(), data.PendingSince).Where(file => !data.PendingHistoryExcluded.Contains(file)))
        {
            try
            {
                var result = save.LoadRunHistory(file); checkedCount++;
                if (result.Success && result.SaveData is { } history)
                {
                    if (MatchesPending(data, history)) { CompleteHistory(history); return; }
                }
                else unreadable++;
            }
            catch (Exception e) { unreadable++; Diagnostics.Error("match.recovery.history", e); }
        }
        Diagnostics.Record("match.recovery", new { profile = save.CurrentProfileId, data.PendingMatchId,
            data.PendingSince, hasSave = save.HasRunSave, inProgress = RunManager.Instance.IsInProgress, checkedCount, unreadable });
    }

    public static void ReleaseMissingRun()
    {
        if (!CanReleaseMissingRun) return;
        RecoverPending();
        if (!CanReleaseMissingRun) return;
        var data = CareerStore.Data;
        if (data.PendingMatchId == null) return;
        data.PendingMatchId = null; data.PendingSince = 0;
        CareerStore.Save(data);
    }
}

[HarmonyPatch(typeof(NMainMenu), "_Ready")]
public static class MenuPatch
{
    public static void Postfix(NMainMenu __instance)
    {
        try
        {
            PlayerArchive.Invalidate();
            AvatarAssets.Invalidate();
            if (!Coop.CoopRuntime.Bound) GameBridge.RecoverPending();
            var button = new Button { Text = "国运尖塔：单人生涯", CustomMinimumSize = new Vector2(310, 64), Theme = CareerVisuals.CreateTheme() };
            __instance.AddChild(button);
            button.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.BottomLeft);
            button.OffsetLeft = 40; button.OffsetRight = 350;
            button.OffsetTop = -106; button.OffsetBottom = -42;
            button.Pressed += () => CareerScreen.Open(__instance);
            MainMenuEntries.Bind(__instance, button);
            // 主菜单底部独立入口，避开左上方档案选择和原生菜单列表。
            if (!Coop.CoopRuntime.Bound) _ = AiService.ProcessPendingAsync();
        }
        catch (Exception e) { Diagnostics.Error("career.entry", e); GD.PushError("[NationalSpire] 生涯入口初始化失败：" + e); }
    }
}

[HarmonyPatch(typeof(SaveManager), nameof(SaveManager.SaveRunHistory))]
public static class HistoryPatch
{
    public static void Postfix(RunHistory history)
    {
        try { GameBridge.CompleteHistory(history); }
        catch (Exception e) { Diagnostics.Error("match.settlement", e); GD.PushError("[NationalSpire] 生涯结算失败：" + e); }
    }
}

[HarmonyPatch(typeof(ActiveScreenContext), nameof(ActiveScreenContext.GetCurrentScreen))]
public static class CareerContextPatch
{
    public static void Postfix(ref IScreenContext? __result)
    {
        if (__result is NMainMenu && CareerScreen.Current is { } screen) __result = screen;
    }
}
