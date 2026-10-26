using Godot;
using MegaCrit.Sts2.Core.Nodes;

namespace NationalSpire;

public partial class CareerScreen
{
    private Action? _dateRunResume;
    private Button? _dateGameAction, _dateResumeGame;
    private bool _dateManualGameInput, _datePhoneManualInput;
    private string _dateInputTurn = "", _datePhonePerson = "", _datePhoneOffer = "";
    private Button? _datePhoneReturn;
    private void AddDateGameActions()
    {
        _dateGameAction = _dateView!.AddInputAction("DateGameInvite", AffectionArt.Texture("calendar-crossed-swords"), InviteDateGame, "发起对局邀请");
        _dateView.AddInputAction("DatePhone", AffectionArt.Texture("date-phone"), DatePhone, "打开讯息");
        _dateResumeGame = _dateView.ExitButton;
        _dateView.Resume = ResumeDateGame;
        TickDateGameActions();
    }
    private void TickDateGameActions()
    {
        if (_dateView == null || _dateGameAction == null) return;
        _dateGameAction.Disabled = !_dateView.InputMode || ViewData.PendingMatchId != null || _multiplayer != null;
        _dateView.ResumeGame.Visible = CanResumeDateGame();
        _dateView.ResumeGame.Disabled = _starting;
        if (_dateResumeGame != null)
        {
            _dateResumeGame.Text = "退出约会  Esc";
            _dateResumeGame.Disabled = _starting;
        }
    }
    private void InviteDateGame()
    {
        if (_dateView?.InputMode != true || _multiplayer != null || ViewData.PendingMatchId != null) return;
        if (PrivateAttachments.Any(a => a.Kind == DateGames.AttachmentKind)) return;
        AttachPrivate(new() { Kind = DateGames.AttachmentKind, Title = "一起开一局", Detail = "邀请当前约会参加者游玩《杀戮尖塔2》切磋。", MatchId = _dateOffer });
        TickDateScene(); _dateView.Editor.GrabFocus();
    }
    private void ShowDateGameChoices(CareerMatch match)
    {
        _dateView!.ShowGameChoices(() => DateGameStartDialog(match),
            () => PrivateCommand("dm-date-game-cancel", new() { Offer = _dateOffer }, () => ShowDateInput()));
    }
    private void DateGameStartDialog(CareerMatch match)
    {
        if (_starting || _dateRunResume != null || DateGames.AwaitingStart(ViewData, _datePerson, _dateOffer)?.Id != match.Id) return;
        var characters = GameBridge.Characters();
        if (characters.Count == 0) { Notice("没有可用角色。", true); return; }
        int selected = Math.Max(0, characters.FindIndex(c => c.Id.ToString() == ViewData.SelectedCharacter));
        SpinBox? level = null;
        ShowCareerDialog("开始约会对局", "选择本局使用的角色和进阶。", () =>
        {
            if (_starting || DateGames.AwaitingStart(ViewData, _datePerson, _dateOffer)?.Id != match.Id) return false;
            level!.Apply(); _ = LaunchDateGame(match, characters[selected], (int)level.Value); return true;
        }, "开始游戏", box =>
        {
            box.AddChild(Text("出战角色", 18, _ink));
            var characterRow = new HBoxContainer { Name = "DateGameCharacterRow" }; characterRow.AddThemeConstantOverride("separation", 16); box.AddChild(characterRow);
            var portrait = new CareerAvatar { Name = "DateGameCharacterPortrait", Art = AvatarAssets.Load(characters[selected].Title.GetFormattedText(), 0, false), CustomMinimumSize = new(48, 48), SizeFlagsVertical = SizeFlags.ShrinkCenter, MouseFilter = MouseFilterEnum.Ignore };
            characterRow.AddChild(portrait);
            var choice = new OptionButton { Name = "DateGameCharacter", CustomMinimumSize = new(456, 44), SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsVertical = SizeFlags.ShrinkCenter };
            foreach (var character in characters) choice.AddItem(character.Title.GetFormattedText());
            choice.Select(selected); choice.ItemSelected += i => { selected = (int)i; portrait.Art = AvatarAssets.Load(characters[selected].Title.GetFormattedText(), 0, false); portrait.QueueRedraw(); }; characterRow.AddChild(choice);
            var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 16); box.AddChild(row);
            row.AddChild(Text("挑战进阶", 18, _ink));
            level = new SpinBox { Name = "DateGameAscension", MinValue = match.RequiredAscension, MaxValue = 10, Step = 1,
                Value = MatchRules.PreferredAscension(ViewData, match), CustomMinimumSize = new(160, 44) }; row.AddChild(level);
        });
    }
    private void DatePhone()
    {
        if (_dateView?.InputMode != true) return;
        string person = _dateView.SpeakerId.Length > 0 ? _dateView.SpeakerId : _datePerson;
        SaveDateGameBookmark();
        PrivateCommand("dm-date-pause", new() { Offer = _dateOffer }, () =>
        {
            _datePhonePerson = _datePerson; _datePhoneOffer = _dateOffer;
            _datePhoneManualInput = _dateManualGameInput;
            var resume = _dateRunResume; _dateRunResume = null;
            CloseDateScene(); _dateRunResume = resume; OpenPrivateMessages(person);
            if (_datePhoneReturn != null) _datePhoneReturn.Show();
        });
    }
    private void ReturnFromDatePhone()
    {
        if (_datePhonePerson.Length == 0 || _datePhoneOffer.Length == 0) return;
        string person = _datePhonePerson, offer = _datePhoneOffer;
        var conversation = PrivateMessages.Conversation(ViewData, person);
        if (!conversation.Offers.Any(o => o.Id == offer && DateScenes.Available(ViewData, o, conversation)))
        { Notice("这场约会已经结束。", false); _datePhoneReturn?.Hide(); return; }
        OpenPrivateMessages(person); OpenDateScene(offer, inputOnly: _datePhoneManualInput);
    }
    private void ShowDateInput(bool manualGame = false, bool keepWaiting = false)
    {
        if (_dateView == null) return;
        var turn = PrivateMessages.Conversation(ViewData, _datePerson).Turns.LastOrDefault(t => t.Scene?.OfferId == _dateOffer && !t.ReplyDeleted);
        _dateInputTurn = turn?.Id ?? "";
        if (_dateEditingTurn.Length > 0) { _dateView.ShowInput(CareerEngine.Name(ViewData), keepWaiting, showChoices: false); return; }
        if (manualGame) _dateManualGameInput = true;
        if (_dateManualGameInput && CanResumeDateGame())
            _dateView.SetReplyChoices("返回游戏", ResumeDateGame, "结束约会", DateSceneExitChoices);
        else
        {
            var choices = turn?.SceneChoices?.Where(t => !string.IsNullOrWhiteSpace(t)).Distinct().Take(2).ToList() ?? [];
            foreach (string fallback in new[] { "（接着刚才的话题继续聊。）", "（稍作停顿，看看大家的反应。）" })
                if (choices.Count < 2 && !choices.Contains(fallback)) choices.Add(fallback);
            _dateView.SetReplyChoices(choices[0], () => ChooseDateReply(choices[0]), choices[1], () => ChooseDateReply(choices[1]));
        }
        _dateView.ShowInput(CareerEngine.Name(ViewData), keepWaiting);
    }
    private void ChooseDateReply(string text)
    {
        if (_dateView?.InputMode != true || _dateView.Blocked?.Invoke() == true) return;
        if (PrivateMessages.Conversation(ViewData, _datePerson).Turns.Any(t => t.Status is "queued" or "sending"))
        { _dateView.Status.Text = "当前回复还在生成，请等待完成。"; return; }
        if (_dateMemory != null) _dateMemory.PendingChoice = text;
        _dateView.Editor.Text = text; SendDateScene();
    }
    private void StartDateGameReply(CareerMatch match, string reason)
    {
        if (_dateView == null) return;
        _dateManualGameInput = false;
        var request = SceneRequest(); request.GameInvitation = false;
        request.GameMatchId = match.Id; request.GameEvent = reason;
        _dateView.ShowWaiting("正在根据对局进程继续对话…", false);
        bool accepted = false;
        PrivateCommand("dm-date-game-next", new() { Scene = request }, () =>
        {
            accepted = true;
            _dateState = ""; TickDateScene();
            if (reason == "result" && match.DateGame is { } game) { game.ReturnPending = false; CareerStore.Save(ViewData); }
        });
        // 若排队被拒绝，保留可输入和返回游戏的入口。
        if (!accepted)
        { string error = _dateView?.Status.Text ?? ""; ShowDateInput(manualGame: CanResumeDateGame()); if (_dateView != null) _dateView.Status.Text = error; }
    }
    private async Task LaunchDateGame(CareerMatch match, MegaCrit.Sts2.Core.Models.CharacterModel character, int ascension)
    {
        if (_starting || _dateRunResume != null || DateGames.AwaitingStart(ViewData, _datePerson, _dateOffer)?.Id != match.Id) return; _starting = true;
        try
        {
            SaveDateGameBookmark();
            if (match.DateGame is { } game) foreach (string person in game.People)
            {
                var art = DateSceneAssetStore.Read(ViewData, person);
                game.Voices[person] = DateGameVoices.Ids.Contains(art.GameVoice) ? art.GameVoice : DateGameVoices.Default(ViewData, person);
            }
            var error = await GameBridge.StartMatch(match, character, ascension);
            if (error != null && IsInstanceValid(this)) Notice(error, true);
        }
        catch (Exception e) { if (IsInstanceValid(this)) Notice("启动约会对局失败：" + e.Message, true); }
        finally { _starting = false; }
    }
    internal static bool OpenRunDate(NRun run, CareerMatch match, Action resume, bool respond = false)
    {
        if (Current != null || match.DateGame is not { } game) return false;
        try
        {
            OpenView(run.GlobalUi, null, "首页");
            if (Current is not { } screen) return false;
            screen._dateRunResume = resume;
            screen.OpenPrivateMessages(game.Host);
            screen.OpenDateSceneReady(game.OfferId, !respond, respond, () => { if (respond) screen.StartDateGameReply(match, "request"); });
            if (screen._dateView == null && !screen._datePresentationPending) { screen.Close(force: true); return false; }
            return true;
        }
        catch
        {
            if (Current is { } failed) failed.Close(force: true);
            throw;
        }
    }
    private bool CanResumeDateGame() => _dateView != null && (_dateRunResume != null
        || _multiplayer == null && DateGames.InProgress(ViewData, _datePerson, _dateOffer) != null);
    private void ResumeDateGame()
    {
        if (_starting || !CanResumeDateGame()) return;
        Action? loadSaved = null;
        if (_dateRunResume == null)
        {
            try { loadSaved = DateGameReturn.PrepareSavedResume(ViewData, _datePerson, _dateOffer); }
            catch (Exception e)
            {
                Diagnostics.Error("date.game.resume.prepare", e);
                Notice("恢复对局失败：" + e.GetBaseException().Message, true); return;
            }
        }
        _starting = true;
        try { SaveDateGameBookmark(); }
        catch (Exception e) { Diagnostics.Error("date.game.bookmark", e); }
        // 生成和播放可以在下次打开时继续；原生对局的暂停必须随界面关闭归还。
        try { PrivateCommand("dm-date-pause", new() { Offer = _dateOffer }); }
        finally
        {
            try { CloseDateScene(); }
            finally
            {
                _starting = false;
                if (loadSaved != null) { Close(force: true); loadSaved(); }
            }
        }
    }
    private void SaveDateGameBookmark()
    {
        if (_dateAssets == null || _dateState != "complete") return;
        _dateAssets.Bookmarks[_dateOffer] = new() { Turn = _dateTurn, ReplyHash = _dateReply, Index = _dateIndex };
        DateSceneAssetStore.Save(ViewData, _datePerson, _dateAssets);
    }
    private void EditDateGameRules()
    {
        if (_multiplayer != null) { Notice("约会对局的发言规则可在单人生涯中编辑。", false); return; }
        var data = ViewData;
        var working = new CareerData { DateGameRules = Coop.CoopJson.Copy(data.DateGameRules), DateGameTiming = Coop.CoopJson.Copy(data.DateGameTiming), DateGameVoiceEdits = Coop.CoopJson.Copy(data.DateGameVoiceEdits) };
        DateGames.Upgrade(working);
        var rules = working.DateGameRules; int index = 0; string profile = DateGameVoices.Ids[0];
        TextEdit? lines = null; SpinBox? threshold = null; CheckBox? enabled = null, chat = null;
        bool filling = false;
        void Fill()
        {
            filling = true;
            try { var r = rules[index]; lines!.Text = string.Join("\n", DateGameVoices.EventLines(working, profile, r)); threshold!.SetValueNoSignal(r.Threshold); enabled!.SetPressedNoSignal(r.Enabled); chat!.SetPressedNoSignal(r.Chat); }
            finally { filling = false; }
        }
        ShowCareerDialog("约会对局 · 发言与聊天触发", "选择性格后，每行填写一句该性格的完整事件台词。触发条件共用；请求聊天时先播出台词，玩家接受后在当前动作结束时打开约会。", () =>
        {
            try
            {
                var bundle = DateGameContent.Snapshot(working, rules);
                DateGameContent.Apply(data, bundle); CareerStore.Save(data); return true;
            }
            catch (Exception e) { Notice("保存失败：" + e.Message, true); return false; }
        }, "保存", box =>
        {
            var selector = new OptionButton { CustomMinimumSize = new(680, 44) }; foreach (var r in rules) selector.AddItem(DateGames.Label(r.Trigger)); box.AddChild(selector);
            var voices = new OptionButton { Name = "DateRulePersonality", CustomMinimumSize = new(680, 44) };
            foreach (string name in DateGameVoices.Labels) voices.AddItem(name);
            box.AddChild(voices); voices.ItemSelected += i => { profile = DateGameVoices.Ids[(int)i]; Fill(); };
            var flags = new HBoxContainer(); box.AddChild(flags);
            enabled = new CheckBox { Text = "启用事件" }; chat = new CheckBox { Text = "请求聊天" }; flags.AddChild(enabled); flags.AddChild(chat);
            threshold = new SpinBox { MinValue = 0, MaxValue = 3600, Step = 1, CustomMinimumSize = new(180, 44) }; box.AddChild(Text("阈值（单位见事件名称；其余事件忽略此项）", 16, _muted)); box.AddChild(threshold);
            lines = new TextEdit { Name = "DateRuleLines", CustomMinimumSize = new(680, 240), WrapMode = TextEdit.LineWrappingMode.Boundary }; box.AddChild(lines);
            lines.TextChanged += () =>
            {
                if (filling) return;
                if (!working.DateGameVoiceEdits.TryGetValue(profile, out var edits)) working.DateGameVoiceEdits[profile] = edits = new();
                edits.Triggers[rules[index].Trigger] = lines.Text.Split('\n', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries).ToList();
            };
            threshold.ValueChanged += v => rules[index].Threshold = v; enabled.Toggled += v => rules[index].Enabled = v; chat.Toggled += v => rules[index].Chat = v;
            selector.ItemSelected += i => { index = (int)i; Fill(); }; Fill();
            var transfer = new HBoxContainer(); transfer.AddThemeConstantOverride("separation", 16); box.AddChild(transfer);
            var status = Text("导入后点击保存应用；取消保留原设置。", 16, _muted);
            transfer.AddChild(Button("导出全部台词", () =>
            {
                try
                {
                    string path = DateGameContent.Write(PromptTransfer.Desktop, working, rules);
                    status.Text = "已导出：" + path; OS.ShellShowInFileManager(path);
                }
                catch (Exception e) { status.Text = "导出失败：" + e.Message; }
            }, 220));
            transfer.AddChild(Button("导入台词JSON", () => PickNestedFile("导入约会对局台词", [".json"], file =>
            {
                try
                {
                    if (new FileInfo(file).Length > 24 * 1024 * 1024) throw new InvalidDataException("文件超过24MB。");
                    working.DateGameRules = rules;
                    string result = DateGameContent.Import(working, File.ReadAllText(file));
                    rules = working.DateGameRules; index = 0; selector.Clear();
                    foreach (var r in rules) selector.AddItem(DateGames.Label(r.Trigger)); selector.Select(0); Fill();
                    status.Text = result + "；点击保存应用。";
                }
                catch (Exception e) { status.Text = "导入失败，原设置已保留：" + e.Message; }
            }), 220));
            box.AddChild(status);
        });
    }
    private void AddDateVoiceSettings(VBoxContainer box)
    {
        var people = DateParticipants(); if (people.Count == 0) return;
        box.AddChild(Text("对局台词版本", 18, _ink));
        var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 16); box.AddChild(row);
        var person = new OptionButton { CustomMinimumSize = new(300, 42), SizeFlagsHorizontal = SizeFlags.ExpandFill, FitToLongestItem = false };
        var voice = new OptionButton { CustomMinimumSize = new(280, 42), SizeFlagsHorizontal = SizeFlags.ExpandFill };
        foreach (var p in people) person.AddItem(p.Name);
        foreach (string label in DateGameVoices.Labels) voice.AddItem(label);
        row.AddChild(person); row.AddChild(voice);
        void Select()
        {
            string id = people[person.Selected].PersonId;
            var art = id == _datePerson ? _dateAssets! : DateSceneAssetStore.Read(ViewData, id);
            voice.Select(Math.Max(0, Array.IndexOf(DateGameVoices.Ids, art.GameVoice.Length > 0 ? art.GameVoice : DateGameVoices.Default(ViewData, id))));
        }
        person.ItemSelected += _ => Select();
        voice.ItemSelected += index =>
        {
            string id = people[person.Selected].PersonId;
            var art = id == _datePerson ? _dateAssets! : DateSceneAssetStore.Read(ViewData, id);
            art.GameVoice = DateGameVoices.Ids[(int)index]; DateSceneAssetStore.Save(ViewData, id, art);
            if (ViewData.Matches.FirstOrDefault(m => m.Id == ViewData.PendingMatchId)?.DateGame is { } active) { active.Voices[id] = art.GameVoice; CareerStore.Save(ViewData); }
        };
        Select();
    }
}
