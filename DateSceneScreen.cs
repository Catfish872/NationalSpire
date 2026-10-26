using Godot;
using System.Text;

namespace NationalSpire;

public partial class CareerScreen
{
    private DateSceneView? _dateView;
    private DateSceneAssets? _dateAssets;
    private PortraitDesign? _dateDesign;
    private string _datePerson = "", _dateOffer = "", _dateKey = "", _dateTurn = "", _dateReply = "", _dateState = "", _dateAttachments = "", _dateSource = "";
    private List<DateSceneLine> _dateLines = [];
    private List<DateSceneBackground> _dateBackgrounds = [];
    private string _dateBackground = "", _dateInitialBackground = "";
    private int _dateIndex;
    private string _dateEditingTurn = "";
    private readonly Dictionary<string, Texture2D> _dateTextures = [];
    private readonly HashSet<string> _dateMissingTextures = [];
    private string _dateTextureWarning = "";
    private void PromptDateScene(string offer)
    {
        string person = _privatePerson; var data = ViewData;
        var conversation = PrivateMessages.Conversation(data, person);
        if (_privateGroup.Length > 0 || !conversation.Offers.Any(o => o.Id == offer && DateScenes.Available(data, o, conversation))) return;
        ShowCareerDialog("进入约会场景", "以视觉小说方式继续这次活动；尚未导入立绘的角色使用默认剪影。", () =>
        {
            Callable.From(() => { if (IsInstanceValid(this) && CareerStore.IsCurrent(data)) OpenDateScene(offer); }).CallDeferred(); return true;
        }, "进入场景", cancelText: "继续私聊");
    }
    private DateSceneRequest SceneRequest(bool opening = false) => new()
    {
        OfferId = _dateOffer, OutfitId = _dateAssets!.OutfitId, Opening = opening, Participants = DateParticipants(),
        DefaultEmotionId = _dateDesign!.DefaultEmotionId,
        Emotions = DateParticipants().First(p => p.PersonId == _datePerson).Emotions,
        GameInvitation = PrivateAttachments.Any(a => a.Kind == DateGames.AttachmentKind),
        Backgrounds = DateSceneBackgrounds.AutomaticChoices(_dateBackgrounds).ToDictionary(b => b.Id, b => b.Description), CurrentBackground = _dateBackground
    };
    private void OpenDateScene(string offer, bool inputOnly = false, bool deferReply = false)
        => OpenDateSceneReady(offer, inputOnly, deferReply, null);
    private void OpenDateSceneReady(string offer, bool inputOnly, bool deferReply, Action? ready)
    {
        if (_dateView != null || _privateGroup.Length > 0 || _privatePerson.Length == 0) return;
        var data = ViewData; string person = _privatePerson;
        try
        {
            var appointment = PrivateMessages.Conversation(data, person).Offers.FirstOrDefault(o => o.Id == offer);
            if (appointment == null || !DateScenes.Available(data, appointment, PrivateMessages.Conversation(data, person)))
                throw new InvalidOperationException("这项约会已结束或尚未赴约。");
            if (ConfigureDatePresentation(data, DateSceneParty.People(data, appointment, person),
                () => { if (_privatePerson == person) OpenDateSceneReady(offer, inputOnly, deferReply, ready); else CloseDateScene(); }, CloseDateScene)) return;
            _dateDesign = PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person); _dateAssets = DateSceneAssetStore.Read(data, person);
            if (_dateAssets.Background.Length == 64 && _dateAssets.Background.All(char.IsAsciiHexDigit))
            {
                try { _dateAssets.Background = DateSceneBackgrounds.RegisterLegacy(_dateAssets.Background); }
                catch { _dateAssets.Background = ""; }
            }
            _dateBackgrounds = DateSceneBackgrounds.Read(out string backgroundWarning);
            _dateBackground = _dateInitialBackground = _dateBackgrounds.Any(b => b.Id == _dateAssets.Background) ? _dateAssets.Background : "";
            LoadDateParty(data, person, offer);
            var check = new DateSceneRequest { Participants = DateParticipants(), OfferId = offer, OutfitId = _dateAssets.OutfitId, DefaultEmotionId = _dateDesign!.DefaultEmotionId, Emotions = new() { [_dateDesign.DefaultEmotionId] = "默认" } };
            if (DateScenes.Validate(data, PrivateMessages.Conversation(data, person), check) is { } error) throw new InvalidOperationException(error);
            var initialTexture = PartyTexture(person, _dateDesign.DefaultEmotionId);
            _datePerson = person; _dateOffer = offer; _dateKey = PortraitDesignStore.Key(data, person);
            _dateTurn = _dateReply = _dateState = _dateAttachments = _dateSource = ""; _dateLines = []; _dateIndex = 0;
            _dateEditingTurn = "";
            _dateManualGameInput = inputOnly; _dateInputTurn = "";
            var view = new DateSceneView { TextSpeed = _dateAssets.TextSpeed, WaitingSprites = [initialTexture],
                WaitingDefault = initialTexture }; _dateView = view;
            view.Advance = AdvanceDateScene; view.Submit = SendDateScene; view.AddAttachment = () => { if (_dateEditingTurn.Length == 0) PrivateActions(); else Notice("本次修订保留原消息附件；新附件可在下一轮添加。", false); }; view.Settings = DateSceneSettings; view.Exit = DateSceneExitChoices;
            view.ReturnToEdit = EditPreviousDateScene;
            view.EditPrevious = EditPreviousDateScene;
            view.HistoryText = () => DateScenes.History(PrivateMessages.Conversation(ViewData, _datePerson), _dateOffer, _dateState == "complete" ? _dateTurn : "", _dateIndex, CareerEngine.Name(ViewData), CareerEngine.DisplayName(ViewData, _datePerson));
            view.HistoryEntries = () => DateScenes.HistoryEntries(PrivateMessages.Conversation(ViewData, _datePerson), _dateOffer, _dateState == "complete" ? _dateTurn : "", _dateIndex, CareerEngine.Name(ViewData), CareerEngine.DisplayName(ViewData, _datePerson));
            view.DeleteHistoryReply = id => DeleteDateHistoryReply(_datePerson, _dateOffer, id);
            view.Blocked = () => _dialogOverlay != null || ChatModelPickerOpen; view.Tick = TickDateScene;
            view.RetryStop = () => PrivateCommand(PrivateMessages.Conversation(ViewData, _datePerson).Turns.Any(t => t.Status is "queued" or "sending") ? "dm-stop" : "dm-retry", new());
            _stage.AddChild(view); view.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect); view.Editor.Text = _privateInput!.Text;
            Button? modelButton = null;
            modelButton = view.AddInputAction("DateModelButton", AffectionArt.Texture("chat-model"), () => ShowChatModelPicker(modelButton!, "private"), "切换私聊和约会使用的模型方案");
            ConfigureModelPermission(modelButton);
            view.SetCast(DateParticipants().Select(p => new DateSceneCast(p.PersonId, p.Name, () => PartyTexture(p.PersonId, p.DefaultEmotionId))));
            AddDateGameActions();
            view.WaitingPortraits = person => PartyWaitingTextures(person.Length > 0 ? person : _datePerson);
            view.Preferences(_dateAssets.FontSize, _dateAssets.PanelFade, _dateAssets.LetterSpacing);
            view.Presentation(1, 0, 0, _dateAssets.TextOutline); ApplyDatePortraitPlacements();
            view.AffectionVisibility(_dateAssets.ShowAffectionBadge);
            _privateOverlay?.Hide();
            view.Editor.TextChanged += () => { if (_privateInput != null && IsInstanceValid(_privateInput)) _privateInput.Text = view.Editor.Text; };
            view.Background(_dateBackgrounds.FirstOrDefault(b => b.Id == _dateBackground)?.Image ?? "", true, _dateAssets.BlurAmount);
            try { BeginDateMemory(data, appointment); }
            catch (Exception e) { _dateMemory = null; view.Status.Text = "回忆记录准备失败：" + e.Message; }
            var c = PrivateMessages.Conversation(data, person);
            if (deferReply) view.ShowWaiting("正在根据对局进程继续对话…", false);
            else
            {
                if (inputOnly)
                {
                    var latest = c.Turns.LastOrDefault(t => t.Scene?.OfferId == offer && !t.ReplyDeleted);
                    if (latest?.Status == "complete") _dateAssets.Bookmarks[offer] = new() { Turn = latest.Id,
                        ReplyHash = DateSceneAssetStore.Hash(Encoding.UTF8.GetBytes(latest.Reply)), Index = DateScenes.Lines(latest).Count };
                }
                if (!inputOnly && !c.Turns.Any(t => t.Scene?.OfferId == offer && !t.ReplyDeleted)) PrivateCommand("dm-date-open", new() { Scene = SceneRequest(true) });
                TickDateScene();
                if (inputOnly) ShowDateInput(manualGame: true);
            }
            if (backgroundWarning.Length > 0) view.Status.Text = backgroundWarning;
            ready?.Invoke();
        }
        catch (Exception e) { CloseDateScene(); Notice("打开约会场景失败：" + e.Message, true); }
    }
    private void CloseDateScene()
    {
        var resume = _dateRunResume; _dateRunResume = null;
        try { ReleaseDateSceneView(); }
        finally
        {
            if (resume != null)
            {
                try { Close(force: true); }
                finally { resume(); }
            }
        }
    }
    private void ReleaseDateSceneView()
    {
        SaveDateMemory();
        if (_dateView != null && IsInstanceValid(_dateView))
        {
            if (_datePerson.Length > 0)
            {
                _privateDrafts[_datePerson] = _dateView.Editor.Text;
                if (_privatePerson == _datePerson && _privateInput != null && IsInstanceValid(_privateInput)) _privateInput.Text = _dateView.Editor.Text;
            }
            _dateView.QueueFree(); _dateView = null;
        }
        foreach (var texture in _dateTextures.Values.Distinct()) texture.Dispose(); _dateTextures.Clear(); _dateMissingTextures.Clear(); _dateTextureWarning = "";
        if (_privateOverlay != null && IsInstanceValid(_privateOverlay)) _privateOverlay.Show();
        _datePerson = _dateOffer = ""; _dateAssets = null; _dateDesign = null; _privateSignature = "";
        _dateBackgrounds.Clear(); _datePartyArt.Clear(); _dateDefaultPeople.Clear(); _dateGameAction = _dateResumeGame = null;
    }
    private void DateSceneExitChoices()
    {
        if (_dateView == null) return;
        ShowCareerDialog("返回私聊", "结束约会后返回私聊，聊天记录继续保留。暂时返回会保留当前进度。", () => true, "继续约会", showCancel: false);
        if (_dialogOverlay?.FindChild("CareerDialogConfirm", true, false) is not Button resume) return;
        var row = (HBoxContainer)resume.GetParent(); row.Alignment = BoxContainer.AlignmentMode.Begin; row.AddThemeConstantOverride("separation", 0);
        var end = PrivateButton("结束约会", () => LeaveDateScene(true), 150);
        var pause = CanResumeDateGame() ? PrivateButton("返回游戏", () => { _cancelDialog?.Invoke(); ResumeDateGame(); }, 150)
            : PrivateButton("暂时返回私聊", () => LeaveDateScene(false), 150);
        end.CustomMinimumSize = pause.CustomMinimumSize = resume.GetCombinedMinimumSize();
        foreach (var button in new[] { end, pause, resume }) button.SizeFlagsVertical = SizeFlags.Fill;
        row.AddChild(end); row.MoveChild(end, 0);
        var gap1 = new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }; row.AddChild(gap1); row.MoveChild(gap1, 1);
        row.AddChild(pause); row.MoveChild(pause, 2);
        var gap2 = new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }; row.AddChild(gap2); row.MoveChild(gap2, 3);
        foreach (string state in new[] { "font_color", "font_hover_color", "font_pressed_color", "font_focus_color" }) resume.AddThemeColorOverride(state, Colors.Black);
    }
    private void LeaveDateScene(bool end)
    {
        if (_dateView == null || _dateAssets == null) return;
        try
        {
            if (_dateState == "complete") _dateAssets.Bookmarks[_dateOffer] = new() { Turn = _dateTurn, ReplyHash = _dateReply, Index = _dateIndex };
            DateSceneAssetStore.Save(ViewData, _datePerson, _dateAssets);
            PrivateCommand(end ? "dm-date-end" : "dm-date-pause", new() { Offer = _dateOffer }, () =>
            { SaveDateMemory(end); _cancelDialog?.Invoke(); CloseDateScene(); RefreshPrivateChat(); });
        }
        catch (Exception e) { _dateView.Status.Text = "保存约会状态失败：" + e.Message; }
    }
    private void AddPausedDateScenes(CareerData data, PrivateConversation conversation)
    {
        var active = PrivateMessages.Mailbox(data).Conversations.Values.SelectMany(c => c.Offers
            .Where(o => c.DateSceneStates.GetValueOrDefault(o.Id) is "active" or "paused" && DateScenes.Available(data, o, c)
                && DateSceneParty.People(data, o, c.PersonId).Contains(conversation.PersonId)).Select(o => (Host: c.PersonId, Offer: o))).ToList();
        foreach (var (host, offer) in active)
        {
            var panel = new PanelContainer { Name = "DateResumeCard" }; panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("353042", "cf9db9", 10, 16));
            _privateBody!.AddChild(panel); var box = Inner(panel); box.AddChild(Text("约会中 · " + offer.Title, 20, _ink));
            var actions = new HBoxContainer(); actions.AddThemeConstantOverride("separation", 16); box.AddChild(actions);
            actions.AddChild(PrivateButton("继续约会", () => { OpenPrivateMessages(host); OpenDateScene(offer.Id); }, 180));
            actions.AddChild(PrivateButton("邀请其他人", () => { OpenPrivateMessages(host); InviteDateParticipant(offer.Id); }, 180));
        }
    }
    private void TickDateScene()
    {
        if (_dateView == null || _dateAssets == null) return;
        var data = ViewData;
        TickDateGameActions();
        if (_dateView.InputMode && !RefreshDateParty()) return;
        if (_privatePerson != _datePerson || _privateGroup.Length > 0 || PortraitDesignStore.Key(data, _datePerson) != _dateKey || !PrivateMessages.CanChat(data, _datePerson)) { CloseDateScene(); return; }
        string speaker = _dateView.SpeakerId.Length > 0 ? _dateView.SpeakerId : _datePerson;
        _dateView.Relationship(PrivateMessages.Relation(data, speaker), speaker);
        var c = PrivateMessages.Conversation(data, _datePerson);
        SyncDateMemory();
        _dateView.EditPreviousButton.Disabled = _dateEditingTurn.Length > 0 || !CanEditPreviousDate(c.Turns.LastOrDefault());
        if (!c.Offers.Any(o => o.Id == _dateOffer && DateScenes.Available(data, o, c))) { SaveDateMemory(c.DateSceneStates.GetValueOrDefault(_dateOffer) == "ended"); CloseDateScene(); return; }
        var turn = c.Turns.LastOrDefault(t => t.Scene?.OfferId == _dateOffer && !t.ReplyDeleted);
        if (_dateState == "history-deleted" && _dateView.InputMode && (turn?.Id ?? "") == _dateInputTurn) { RefreshDateSceneAttachments(); return; }
        if (_dateInputTurn.Length > 0 && turn?.Id != _dateInputTurn) { _dateManualGameInput = false; _dateInputTurn = ""; }
        if (_dateManualGameInput && _dateView.InputMode && (turn?.Id ?? "") == _dateInputTurn) { RefreshDateSceneAttachments(); return; }
        if (turn == null) { _dateView.ShowWaiting(_privateStatus?.Text.Length > 0 ? _privateStatus.Text : "正在准备开场…", true); return; }
        if (_dateEditingTurn == turn.Id && turn.Status is "complete" or "failed") return;
        _dateEditingTurn = "";
        if (turn.Status != "complete")
        {
            var live = AiService.PrivateSceneLive.GetValueOrDefault(AiService.PrivateKey(data, _datePerson));
            if (turn.Status == "sending" && live.Turn == turn.Id && live.Lines?.Count > 0)
            {
                bool first = _dateTurn != turn.Id || _dateState != "streaming";
                if (first) { _dateIndex = 0; _dateTurn = turn.Id; _dateInitialBackground = turn.Scene!.CurrentBackground; }
                _dateState = "streaming"; _dateLines = live.Lines;
                if (first) ShowDateLine();
                else { AppendDateLine(_dateLines[Math.Min(_dateIndex, _dateLines.Count - 1)]); _dateView.Streaming(true); }
                return;
            }
            string state = turn.Id + turn.Status + turn.Error;
            if (_dateState != state) { _dateState = state; _dateView.ShowWaiting(turn.Status == "failed" ? turn.Error : "正在生成完整回复与情绪差分…", turn.Status == "failed"); }
            return;
        }
        if (_dateTurn != turn.Id || _dateSource != turn.Reply || _dateState != "complete")
        {
            string hash = DateSceneAssetStore.Hash(Encoding.UTF8.GetBytes(turn.Reply));
            bool streamed = _dateState == "streaming" && _dateTurn == turn.Id;
            _dateTurn = turn.Id; _dateReply = hash; _dateSource = turn.Reply; _dateState = "complete"; _dateLines = DateScenes.Lines(turn);
            _dateInitialBackground = turn.Scene?.CurrentBackground ?? "";
            var bookmark = _dateAssets.Bookmarks.GetValueOrDefault(_dateOffer);
            if (!streamed) _dateIndex = bookmark?.Turn == turn.Id && bookmark.ReplyHash == hash ? Math.Clamp(bookmark.Index, 0, _dateLines.Count) : 0;
            if (streamed && _dateIndex < _dateLines.Count) { AppendDateLine(_dateLines[_dateIndex]); _dateView.Streaming(false); }
            else ShowDateLine();
            if (turn.Error.Length > 0) _dateView.Status.Text = turn.Error;
            SaveDateMemory();
        }
        RefreshDateSceneAttachments();
    }
    private void RefreshDateSceneAttachments()
    {
        if (_dateView == null) return;
        string attachments = string.Join('|', PrivateAttachments.Select(a => a.Id));
        if (_dateAttachments != attachments)
        {
            _dateAttachments = attachments; CareerVisuals.ClearContent(_dateView.Attachments);
            foreach (var item in PrivateAttachments) _dateView.Attachments.AddChild(PrivateAttachmentCard(item, true)); _dateView.ShowAttachments();
        }
    }
    private void AppendDateLine(DateSceneLine line)
    {
        ApplyDateBackground();
        _dateView!.AppendLine(_dateLines, Math.Min(_dateIndex, _dateLines.Count - 1), () =>
        {
            string speaker = _datePartyArt.ContainsKey(line.Speaker) ? line.Speaker : _datePerson;
            return (CareerEngine.DisplayName(ViewData, speaker), PartyTexture(speaker, line.Emotion));
        });
        CaptureDateMemory();
    }
    private void ShowDateLine()
    {
        if (_dateView == null) return;
        ApplyDateBackground();
        if (_dateIndex >= _dateLines.Count)
        {
            if (_dateRunResume == null && DateGames.AwaitingStart(ViewData, _datePerson, _dateOffer) is { } game) ShowDateGameChoices(game);
            else ShowDateInput();
        }
        else
        {
            var line = _dateLines[_dateIndex];
            string speaker = _datePartyArt.ContainsKey(line.Speaker) ? line.Speaker : _datePerson;
            _dateView.ShowRoundLine(_dateLines, _dateIndex, CareerEngine.DisplayName(ViewData, speaker), PartyTexture(speaker, line.Emotion));
            _dateView.Streaming(_dateState == "streaming");
            CaptureDateMemory();
            if (_dateTextureWarning.Length > 0) _dateView.Status.Text = _dateTextureWarning;
        }
    }
    private void AddDateSceneAction(CareerData data, PrivateOffer offer, HBoxContainer row)
    {
        var conversation = PrivateMessages.Conversation(data, _privatePerson);
        if (DateSceneParty.Eligible(data, offer, conversation) && offer.State is "已确认" or "已赴约")
            row.AddChild(PrivateButton("邀请其他人", () => InviteDateParticipant(offer.Id), 150));
        bool attend = offer.State == "已确认" && PrivateAppointments.Date(data, offer) == data.Day;
        if (!DateSceneParty.Eligible(data, offer, conversation) || !(attend || DateScenes.Available(data, offer, conversation))) return;
        var button = new DateChoiceButton { Name = "ExclusiveDate", Caption = conversation.DateSceneStates.GetValueOrDefault(offer.Id) == "paused" ? "继续约会" : "专属约会", CustomMinimumSize = new(150, 48), SizeFlagsVertical = SizeFlags.ShrinkCenter };
        button.Pressed += () =>
        {
            if (!attend) { PromptDateScene(offer.Id); return; }
            ShowCareerDialog("专属约会", "选择这次赴约的公开方式。", () => true, "取消", box =>
            {
                var choices = new HBoxContainer(); choices.AddThemeConstantOverride("separation", 20); box.AddChild(choices);
                foreach (bool visible in new[] { false, true })
                {
                    var choice = new DateChoiceButton { Name = visible ? "DatePublicChoice" : "DatePrivateChoice", Caption = visible ? "公开赴约" : "私密赴约",
                        Subtitle = visible ? "让这次相聚成为公开经历" : "将这次相聚留在彼此之间", Public = visible,
                        CustomMinimumSize = new(290, 150), SizeFlagsHorizontal = SizeFlags.ExpandFill };
                    choice.Pressed += () => PrivateCommand("dm-attend", new() { Offer = offer.Id, Part = visible ? "public" : "", SceneAttendance = true },
                        () => { _cancelDialog?.Invoke(); Callable.From(() => PromptDateScene(offer.Id)).CallDeferred(); });
                    choices.AddChild(choice);
                }
                var error = Text("", 16, new Color("ee929d")); error.Name = "DateAttendanceError"; error.Hide(); box.AddChild(error);
            }, showCancel: false);
        };
        row.AddChild(button);
    }
    private void SelectDateBackground(string id)
    {
        if (_dateView == null || _dateAssets == null) return;
        var background = _dateBackgrounds.FirstOrDefault(b => b.Id == id);
        try { _dateView.Background(background?.Image ?? "", true, _dateAssets.BlurAmount); _dateBackground = _dateAssets.Background = background?.Id ?? ""; }
        catch (Exception e) { _dateView.Status.Text = "背景加载失败，保留当前背景：" + e.Message; }
    }
    private void ApplyDateBackground()
    {
        if (_dateAssets == null) return;
        string id = _dateAssets.Background;
        if (_dateAssets.AutoBackground)
        {
            var offer = PrivateMessages.Conversation(ViewData, _datePerson).Offers.FirstOrDefault(o => o.Id == _dateOffer);
            id = DateSceneBackgrounds.At(_dateBackgrounds, _dateLines, _dateIndex, _dateInitialBackground, offer?.Title + " " + offer?.Detail);
        }
        SelectDateBackground(id);
    }
    private void AdvanceDateScene()
    {
        if (_dateView == null || _dateState is not ("complete" or "streaming") || _dateIndex >= _dateLines.Count) return;
        CaptureDateMemory(); SaveDateMemory();
        // 末尾两段仍可能随标点和长句拆分变化，收到后续句段后再翻动。
        if (_dateState == "streaming")
        {
            if (_dateIndex + 2 >= _dateLines.Count) { _dateView.Status.Text = "正在续写当前回复…"; return; }
            _dateIndex++; ShowDateLine(); return;
        }
        _dateIndex++; _dateAssets!.Bookmarks[_dateOffer] = new() { Turn = _dateTurn, ReplyHash = _dateReply, Index = _dateIndex };
        try { DateSceneAssetStore.Save(ViewData, _datePerson, _dateAssets); } catch (Exception e) { _dateView.Status.Text = "播放进度保存失败：" + e.Message; }
        ShowDateLine();
    }
    private void SendDateScene()
    {
        if (_dateView?.InputMode != true || _dateView.HistoryOpen || _dateView.DialogueHidden) return;
        if (_dateEditingTurn.Length > 0)
        {
            PrivateCommand("dm-date-revise", new() { Entry = _dateEditingTurn, Text = _dateView.Editor.Text }, () =>
            {
                _dateManualGameInput = false;
                _dateEditingTurn = ""; _dateState = "";
                _dateAssets?.Bookmarks.Remove(_dateOffer);
                if (_dateView != null) _dateView.Editor.Text = "";
                if (_privateInput != null && IsInstanceValid(_privateInput)) _privateInput.Text = "";
                _privateDrafts.Remove(_datePerson); TickDateScene();
            });
            return;
        }
        _privateInput!.Text = _dateView.Editor.Text; SendPrivate();
    }
    private bool CanEditPreviousDate(PrivateTurn? turn) => turn is { Status: "complete" or "failed", UserDeleted: false, ReplyDeleted: false,
        Scene: { Ending: false } } && turn.Scene.OfferId == _dateOffer && turn.RequestKind != "arbitration"
        && (turn.Status == "failed" || !turn.Scene.Opening);
    private void EditPreviousDateScene()
    {
        if (_dateView == null || _dateEditingTurn.Length > 0) return;
        var turn = PrivateMessages.Conversation(ViewData, _datePerson).Turns.LastOrDefault();
        if (!CanEditPreviousDate(turn)) return;
        _dateEditingTurn = turn!.Id; _dateManualGameInput = false;
        _dateView.Editor.Text = turn.Status == "failed" && _privateDrafts.GetValueOrDefault(_datePerson) is { Length: > 0 } draft ? draft
            : turn.Scene!.Opening || turn.Scene.GameEvent.Length > 0 ? "" : turn.User;
        ShowDateInput(keepWaiting: turn.Status == "failed"); _dateView.Editor.SetCaretLine(_dateView.Editor.GetLineCount() - 1); _dateView.Editor.SetCaretColumn(_dateView.Editor.GetLine(_dateView.Editor.GetCaretLine()).Length);
        CareerVisuals.ClearContent(_dateView.Attachments);
        foreach (var item in turn.Attachments) _dateView.Attachments.AddChild(PrivateAttachmentCard(item, false));
        _dateView.ShowAttachments(); _dateView.Status.Text = "编辑后点击发送，将替换本轮回复；原附件继续保留。";
    }
    private void DateSceneSettings()
    {
        if (_dateView == null || _dateAssets == null) return;
        var data = ViewData; string person = _datePerson; var assets = _dateAssets;
        void Apply() { if (_dateView != null && IsInstanceValid(_dateView)) { _dateView.TextSpeed = assets.TextSpeed; _dateView.Preferences(assets.FontSize, assets.PanelFade, assets.LetterSpacing); _dateView.Presentation(1, 0, 0, assets.TextOutline); ApplyDatePortraitPlacements(); _dateView.AffectionVisibility(assets.ShowAffectionBadge); ApplyDateBackground(); } }
        void Save() { DateSceneAssetStore.Save(data, person, assets); Apply(); }
        ShowCareerDialog("场景设置", "背景与显示偏好保存在本机。", () => true, "关闭", outer =>
        {
            var scroll = new BroadcastScroll { Name = "DateSettingsScroll", CustomMinimumSize = new(660, Math.Clamp(_stage.Size.Y - 300, 330, 540)), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; outer.AddChild(scroll);
            void FitSettings() => scroll.CustomMinimumSize = new(660, Math.Clamp(_stage.Size.Y - 300, 220, 540));
            _stage.Resized += FitSettings; scroll.TreeExiting += () => _stage.Resized -= FitSettings; FitSettings();
            var box = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; box.AddThemeConstantOverride("separation", 14); scroll.AddChild(box);
            AddDateMemorySetting(box);
            AddDateVoiceSettings(box);
            box.AddChild(Button("选择约会立绘与播报口吻", () =>
            {
                _cancelDialog?.Invoke();
                Callable.From(() =>
                {
                    if (_dateView == null || !CareerStore.IsCurrent(data)) return;
                    ConfigureDatePresentation(data, _datePartyArt.Keys.ToArray(), () =>
                    {
                        if (_dateView == null) return;
                        _dateDesign = PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person);
                        _dateAssets = DateSceneAssetStore.Read(data, person);
                        LoadDateParty(data, person, _dateOffer);
                        _dateView.SetCast(DateParticipants().Select(p => new DateSceneCast(p.PersonId, p.Name, () => PartyTexture(p.PersonId, p.DefaultEmotionId))));
                        ApplyDatePortraitPlacements();
                        if (DateGames.InProgress(data, person, _dateOffer)?.DateGame is { } game)
                        {
                            foreach (var p in _datePartyArt) game.Voices[p.Key] = p.Value.Assets.GameVoice;
                            CareerStore.Save(data);
                        }
                        if (!_dateView.InputMode && _dateLines.Count > 0) ShowDateLine();
                    }, () => { }, firstOnly: false);
                }).CallDeferred();
            }, 360));
            var auto = new CheckBox { Name = "DateAutoBackground", Text = "根据场景和时间自动切换背景", ButtonPressed = assets.AutoBackground }; box.AddChild(auto);
            var choices = new OptionButton { Name = "DateBackgroundChoice", CustomMinimumSize = new(0, 40), FitToLongestItem = false }; box.AddChild(choices);
            void PopulateBackgrounds()
            {
                choices.Clear(); foreach (var item in _dateBackgrounds) choices.AddItem(item.Id + " · " + item.Description);
                if (_dateBackgrounds.Count == 0) { choices.AddItem("请导入背景图片或ZIP背景包"); choices.SetItemDisabled(0, true); }
                choices.Select(Math.Max(0, _dateBackgrounds.FindIndex(b => b.Id == _dateBackground)));
            }
            choices.ItemSelected += index => { assets.Background = _dateBackgrounds[(int)index].Id; assets.AutoBackground = false; auto.SetPressedNoSignal(false); Save(); };
            PopulateBackgrounds();
            auto.Toggled += value => { assets.AutoBackground = value; Save(); PopulateBackgrounds(); };
            var backgroundActions = new HBoxContainer(); backgroundActions.AddThemeConstantOverride("separation", 18); box.AddChild(backgroundActions);
            backgroundActions.AddChild(Button("导入背景图片 / ZIP背景包", () => PickNestedFile("导入背景", [".png", ".jpg", ".jpeg", ".webp", ".zip"], path =>
            { try { assets.Background = DateSceneBackgrounds.Import(path); _dateBackgrounds = DateSceneBackgrounds.Read(out _); assets.AutoBackground = false; auto.SetPressedNoSignal(false); Save(); PopulateBackgrounds(); } catch (Exception e) { Notice("背景导入失败：" + e.Message, true); } }), 350));
            var removeBackground = Button("删除当前背景", () =>
            {
                if (_dateBackground.Length == 0) return;
                try { DateSceneBackgrounds.Remove(_dateBackground); _dateBackgrounds = DateSceneBackgrounds.Read(out _); assets.Background = DateSceneBackgrounds.Closest(_dateBackgrounds, "", ""); Save(); PopulateBackgrounds(); }
                catch (Exception e) { Notice("背景删除失败：" + e.Message, true); }
            }, 180); removeBackground.Name = "DateBackgroundDelete"; backgroundActions.AddChild(removeBackground);
            var blurLabel = Text($"模糊强度 · {assets.BlurAmount:F1}", 18, _ink); box.AddChild(blurLabel);
            var blurAmount = new HSlider { Name = "DateBlurAmount", MinValue = 0, MaxValue = 20, Step = 0, Value = assets.BlurAmount, CustomMinimumSize = new(600, 35) }; box.AddChild(blurAmount);
            blurAmount.ValueChanged += value => { assets.BlurAmount = value; blurLabel.Text = $"模糊强度 · {value:F1}"; Apply(); };
            blurAmount.DragEnded += changed => { if (changed) Save(); };
            var fonts = new OptionButton { Name = "DateFontSize", CustomMinimumSize = new(0, 42) };
            foreach (string label in new[] { "小号", "中号（默认）", "大号" }) fonts.AddItem(label);
            fonts.Select(Math.Clamp(assets.FontSize, 0, 2)); box.AddChild(Text("字体大小", 18, _ink)); box.AddChild(fonts);
            fonts.ItemSelected += value => { assets.FontSize = (int)value; Save(); };
            var spacingLabel = Text($"字间距 · 额外增加 {assets.LetterSpacing:P0}", 18, _ink); box.AddChild(spacingLabel);
            var spacing = new HSlider { Name = "DateLetterSpacing", MinValue = 0, MaxValue = 3, Step = .05, Value = assets.LetterSpacing, CustomMinimumSize = new(600, 35) }; box.AddChild(spacing);
            spacing.TooltipText = "0% 使用原始间距；默认增加100%，约为原字间留白的两倍。";
            spacing.ValueChanged += value => { assets.LetterSpacing = value; spacingLabel.Text = $"字间距 · 额外增加 {value:P0}"; Apply(); };
            spacing.DragEnded += changed => { if (changed) Save(); };
            var switches = new HBoxContainer(); switches.AddThemeConstantOverride("separation", 16); box.AddChild(switches);
            var outline = new CheckBox { Name = "DateTextOutline", Text = "正文黑色描边", ButtonPressed = assets.TextOutline, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(292, 0) }; switches.AddChild(outline);
            var affection = new CheckBox { Name = "DateShowAffection", Text = "显示好感徽章", ButtonPressed = assets.ShowAffectionBadge, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(292, 0) }; switches.AddChild(affection);
            outline.Toggled += value => { assets.TextOutline = value; Save(); };
            affection.Toggled += value => { assets.ShowAffectionBadge = value; Save(); };
            AddDatePortraitSettings(box, data);
            var speedLabel = Text("文字速度 · 滑到最右立即显示全文", 18, _ink); box.AddChild(speedLabel);
            var speed = new HSlider { Name = "DateTextSpeed", MinValue = 5, MaxValue = DateSceneView.InstantSpeed, Step = 0, Value = assets.TextSpeed, CustomMinimumSize = new(600, 35) }; box.AddChild(speed);
            speed.ValueChanged += value => { assets.TextSpeed = value; speedLabel.Text = value >= DateSceneView.InstantSpeed ? "文字速度 · 立即显示全文" : $"文字速度 · {value:F0}字/秒"; Apply(); };
            var fadeLabel = Text("文本框不透明度 · 底部100% / 上缘75% → 底部50% / 上缘0%\n上缘位于顶部下方15像素，顶部始终完全透明。", 16, _ink); box.AddChild(fadeLabel);
            var fade = new HSlider { Name = "DatePanelFade", MinValue = 0, MaxValue = 1, Step = 0, Value = assets.PanelFade, CustomMinimumSize = new(600, 35) }; box.AddChild(fade);
            fade.ValueChanged += value => { assets.PanelFade = value; Apply(); };
            speed.DragEnded += changed => { if (changed) Save(); }; fade.DragEnded += changed => { if (changed) Save(); };
            box.AddChild(Button("从本轮第一句重看", () => { _dateIndex = 0; ShowDateLine(); _cancelDialog?.Invoke(); }, 240));
        }, showCancel: false);
        if (_dialogOverlay != null) _dialogOverlay.TreeExiting += () => { try { DateSceneAssetStore.Save(data, person, assets); } catch (Exception e) { Notice(e.Message, true); } };
    }
}
