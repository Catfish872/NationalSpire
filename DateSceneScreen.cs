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
    private void PromptDateScene(string offer)
    {
        string person = _privatePerson; var data = ViewData;
        var conversation = PrivateMessages.Conversation(data, person);
        if (_privateGroup.Length > 0 || !conversation.Offers.Any(o => o.Id == offer && DateScenes.Available(data, o, conversation))) return;
        string? issue;
        try { issue = DateSceneAssetStore.Ready(DateSceneAssetStore.Read(data, person), PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person)); }
        catch (Exception e) { issue = e.Message; }
        ShowCareerDialog(issue == null ? "进入约会场景" : "准备角色立绘", issue ?? "以视觉小说方式继续这次活动；场景对话保存在约会历史中，附件与关系变化继续生效。", () =>
        {
            Callable.From(() => { if (!IsInstanceValid(this) || !CareerStore.IsCurrent(data)) return; if (issue == null) OpenDateScene(offer); else OpenDateAssets(data, person); }).CallDeferred(); return true;
        }, issue == null ? "进入场景" : "导入立绘", cancelText: "继续私聊");
    }
    private DateSceneRequest SceneRequest(bool opening = false) => new()
    {
        OfferId = _dateOffer, OutfitId = _dateAssets!.OutfitId, Opening = opening,
        DefaultEmotionId = _dateDesign!.DefaultEmotionId,
        Emotions = _dateDesign!.Emotions.Where(e => e.Enabled && SpriteVariants(e.Id).Count > 0).ToDictionary(e => e.Id, e => e.Name + "：" + e.Description),
        Backgrounds = DateSceneBackgrounds.AutomaticChoices(_dateBackgrounds).ToDictionary(b => b.Id, b => b.Description), CurrentBackground = _dateBackground
    };
    private void OpenDateScene(string offer)
    {
        if (_dateView != null || _privateGroup.Length > 0 || _privatePerson.Length == 0) return;
        var data = ViewData; string person = _privatePerson;
        try
        {
            _dateDesign = PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person); _dateAssets = DateSceneAssetStore.Read(data, person);
            if (DateSceneAssetStore.Ready(_dateAssets, _dateDesign) is { } reason) throw new InvalidOperationException(reason);
            if (_dateAssets.Background.Length == 64 && _dateAssets.Background.All(char.IsAsciiHexDigit))
            {
                try { _dateAssets.Background = DateSceneBackgrounds.RegisterLegacy(_dateAssets.Background); }
                catch { _dateAssets.Background = ""; }
            }
            _dateBackgrounds = DateSceneBackgrounds.Read(out string backgroundWarning);
            _dateBackground = _dateInitialBackground = _dateBackgrounds.Any(b => b.Id == _dateAssets.Background) ? _dateAssets.Background : "";
            var check = new DateSceneRequest { OfferId = offer, OutfitId = _dateAssets.OutfitId, DefaultEmotionId = _dateDesign!.DefaultEmotionId, Emotions = new() { [_dateDesign.DefaultEmotionId] = "默认" } };
            if (DateScenes.Validate(data, PrivateMessages.Conversation(data, person), check) is { } error) throw new InvalidOperationException(error);
            _dateBackground = _dateInitialBackground = "";
            foreach (var item in _dateAssets.Sprites.Where(p => DateSceneAssetStore.EmotionForSprite(_dateDesign!, p.Key) != null))
            {
                try { _dateTextures[item.Key] = _dateTextures.FirstOrDefault(p => _dateAssets.Sprites[p.Key] == item.Value).Value ?? DateSceneAssetStore.Texture(item.Value); }
                catch (Exception) { }
            }
            if (SpriteVariants(_dateDesign!.DefaultEmotionId).Count == 0) throw new InvalidDataException($"请导入有效的默认立绘 {_dateDesign!.DefaultEmotionId}.png 或对应编号变体。");
            _datePerson = person; _dateOffer = offer; _dateKey = PortraitDesignStore.Key(data, person);
            _dateTurn = _dateReply = _dateState = _dateAttachments = _dateSource = ""; _dateLines = []; _dateIndex = 0;
            _dateEditingTurn = "";
            var view = new DateSceneView { TextSpeed = _dateAssets.TextSpeed, WaitingSprites = _dateTextures.Values.Distinct().ToArray(),
                WaitingDefault = _dateTextures[SpriteVariants(_dateDesign.DefaultEmotionId)[0]] }; _dateView = view;
            view.Advance = AdvanceDateScene; view.Submit = SendDateScene; view.AddAttachment = () => { if (_dateEditingTurn.Length == 0) PrivateActions(); else Notice("本次修订保留原消息附件；新附件可在下一轮添加。", false); }; view.Settings = DateSceneSettings; view.Exit = DateSceneExitChoices;
            view.ReturnToEdit = EditFailedDateScene;
            view.PromptSettings = () => OpenPromptInsertions("date");
            view.Regenerate = RegenerateDateScene;
            view.HistoryText = () => DateScenes.History(PrivateMessages.Conversation(ViewData, _datePerson), _dateOffer, _dateState == "complete" ? _dateTurn : "", _dateIndex, CareerEngine.Name(ViewData), CareerEngine.DisplayName(ViewData, _datePerson));
            view.Blocked = () => _dialogOverlay != null; view.Tick = TickDateScene;
            view.RetryStop = () => PrivateCommand(PrivateMessages.Conversation(ViewData, _datePerson).Turns.Any(t => t.Status is "queued" or "sending") ? "dm-stop" : "dm-retry", new());
            _stage.AddChild(view); view.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect); view.Editor.Text = _privateInput!.Text;
            view.Preferences(_dateAssets.FontSize, _dateAssets.PanelFade, _dateAssets.LetterSpacing);
            view.Presentation(_dateAssets.SpriteScale, _dateAssets.SpriteX, _dateAssets.SpriteY, _dateAssets.TextOutline);
            view.AffectionVisibility(_dateAssets.ShowAffectionBadge);
            _privateOverlay?.Hide();
            view.Editor.TextChanged += () => { if (_privateInput != null && IsInstanceValid(_privateInput)) _privateInput.Text = view.Editor.Text; };
            view.Background("", true, _dateAssets.BlurAmount);
            var c = PrivateMessages.Conversation(data, person);
            if (!c.Turns.Any(t => t.Scene?.OfferId == offer && t.Scene.Opening && !t.ReplyDeleted)) PrivateCommand("dm-date-open", new() { Scene = SceneRequest(true) });
            TickDateScene();
            if (backgroundWarning.Length > 0) view.Status.Text = backgroundWarning;
        }
        catch (Exception e) { CloseDateScene(); Notice("打开约会场景失败：" + e.Message, true); }
    }
    private void CloseDateScene()
    {
        if (_dateView != null && IsInstanceValid(_dateView))
        {
            if (_datePerson.Length > 0)
            {
                _privateDrafts[_datePerson] = _dateView.Editor.Text;
                if (_privatePerson == _datePerson && _privateInput != null && IsInstanceValid(_privateInput)) _privateInput.Text = _dateView.Editor.Text;
            }
            _dateView.QueueFree(); _dateView = null;
        }
        foreach (var texture in _dateTextures.Values.Distinct()) texture.Dispose(); _dateTextures.Clear();
        if (_privateOverlay != null && IsInstanceValid(_privateOverlay)) _privateOverlay.Show();
        _datePerson = _dateOffer = ""; _dateAssets = null; _dateDesign = null; _privateSignature = "";
        _dateBackgrounds.Clear();
    }
    private void DateSceneExitChoices()
    {
        if (_dateView == null) return;
        ShowCareerDialog("返回私聊", "结束约会后，对方会在私信中分享感想。暂时返回会保留当前进度。", () => true, "继续约会", showCancel: false);
        if (_dialogOverlay?.FindChild("CareerDialogConfirm", true, false) is not Button resume) return;
        var row = (HBoxContainer)resume.GetParent(); row.Alignment = BoxContainer.AlignmentMode.Begin; row.AddThemeConstantOverride("separation", 0);
        var end = PrivateButton("结束约会", () => LeaveDateScene(true), 150); var pause = PrivateButton("暂时返回私聊", () => LeaveDateScene(false), 150);
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
            { _cancelDialog?.Invoke(); CloseDateScene(); RefreshPrivateChat(); });
        }
        catch (Exception e) { _dateView.Status.Text = "保存约会状态失败：" + e.Message; }
    }
    private void AddPausedDateScenes(CareerData data, PrivateConversation conversation)
    {
        foreach (var offer in conversation.Offers.Where(o => conversation.DateSceneStates.GetValueOrDefault(o.Id) == "paused" && DateScenes.Available(data, o, conversation)))
        {
            var panel = new PanelContainer { Name = "DateResumeCard" }; panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("353042", "cf9db9", 10, 16));
            _privateBody!.AddChild(panel); var box = Inner(panel); box.AddChild(Text("继续约会 · " + offer.Title, 20, _ink));
            box.AddChild(PrivateButton("继续约会", () => OpenDateScene(offer.Id), 180));
        }
    }
    private void TickDateScene()
    {
        if (_dateView == null || _dateAssets == null) return;
        var data = ViewData;
        if (_privatePerson != _datePerson || _privateGroup.Length > 0 || PortraitDesignStore.Key(data, _datePerson) != _dateKey || !PrivateMessages.CanChat(data, _datePerson)) { CloseDateScene(); return; }
        _dateView.Relationship(PrivateMessages.Relation(data, _datePerson));
        var c = PrivateMessages.Conversation(data, _datePerson);
        _dateView.RegenerateButton.Disabled = !CanRegenerateDate(c.Turns.LastOrDefault());
        if (!c.Offers.Any(o => o.Id == _dateOffer && DateScenes.Available(data, o, c))) { CloseDateScene(); return; }
        var turn = c.Turns.LastOrDefault(t => t.Scene?.OfferId == _dateOffer && !t.ReplyDeleted);
        if (turn == null) { _dateView.ShowWaiting(_privateStatus?.Text.Length > 0 ? _privateStatus.Text : "正在准备开场…", true); return; }
        if (turn.Status != "complete")
        {
            if (_dateEditingTurn == turn.Id && turn.Status == "failed") return;
            _dateEditingTurn = "";
            string state = turn.Id + turn.Status + turn.Error;
            if (_dateState != state) { _dateState = state; _dateView.ShowWaiting(turn.Status == "failed" ? turn.Error : "正在生成完整回复与情绪差分…", turn.Status == "failed"); }
            return;
        }
        if (_dateTurn != turn.Id || _dateSource != turn.Reply || _dateState != "complete")
        {
            string hash = DateSceneAssetStore.Hash(Encoding.UTF8.GetBytes(turn.Reply));
            _dateTurn = turn.Id; _dateReply = hash; _dateSource = turn.Reply; _dateState = "complete"; _dateLines = DateScenes.Lines(turn);
            _dateInitialBackground = _dateBackgrounds.Any(b => b.Id == turn.Scene?.CurrentBackground) ? turn.Scene!.CurrentBackground : _dateBackground;
            var bookmark = _dateAssets.Bookmarks.GetValueOrDefault(_dateOffer);
            _dateIndex = bookmark?.Turn == turn.Id && bookmark.ReplyHash == hash ? Math.Clamp(bookmark.Index, 0, _dateLines.Count) : 0;
            ShowDateLine(); if (turn.Error.Length > 0) _dateView.Status.Text = turn.Error;
        }
        string attachments = string.Join('|', PrivateAttachments.Select(a => a.Id));
        if (_dateAttachments != attachments)
        {
            _dateAttachments = attachments; CareerVisuals.ClearContent(_dateView.Attachments);
            foreach (var item in PrivateAttachments) _dateView.Attachments.AddChild(PrivateAttachmentCard(item, true)); _dateView.ShowAttachments();
        }
        if (_dateView.InputMode && _privateStatus is { Visible: true, Text.Length: > 0 }) _dateView.Status.Text = _privateStatus.Text;
    }
    private void ShowDateLine()
    {
        if (_dateView == null) return;
        ApplyDateBackground();
        if (_dateIndex >= _dateLines.Count) _dateView.ShowInput(CareerEngine.Name(ViewData));
        else
        {
            var line = _dateLines[_dateIndex]; var variants = SpriteVariants(line.Emotion); bool fallback = variants.Count == 0;
            if (fallback) variants = SpriteVariants(_dateDesign!.DefaultEmotionId);
            _dateView.ShowLine(line, CareerEngine.DisplayName(ViewData, _datePerson), _dateTextures[variants[Random.Shared.Next(variants.Count)]]);
            if (fallback) _dateView.Status.Text = "此差分缺少立绘，当前使用平淡立绘。";
        }
    }
    private List<string> SpriteVariants(string emotion) => _dateTextures.Keys.Where(id => _dateDesign != null && DateSceneAssetStore.EmotionForSprite(_dateDesign, id) == emotion).ToList();
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
        string id = _dateAssets.AutoBackground ? DateScenes.BackgroundAt(_dateLines, _dateIndex, _dateInitialBackground) : _dateAssets.Background;
        if (_dateAssets.AutoBackground && !DateSceneBackgrounds.AutomaticChoices(_dateBackgrounds).Any(b => b.Id == id))
        {
            var offer = PrivateMessages.Conversation(ViewData, _datePerson).Offers.FirstOrDefault(o => o.Id == _dateOffer);
            id = DateSceneBackgrounds.Closest(_dateBackgrounds, offer?.Title + " " + offer?.Detail + " " + string.Concat(_dateLines.Take(_dateIndex + 1).Where(l => l.Narration).Select(l => l.Text)), _dateBackground);
        }
        SelectDateBackground(id);
    }
    private void AdvanceDateScene()
    {
        if (_dateView == null || _dateState != "complete" || _dateIndex >= _dateLines.Count) return;
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
                _dateEditingTurn = ""; _dateState = "";
                if (_dateView != null) _dateView.Editor.Text = "";
                _privateDrafts.Remove(_datePerson); TickDateScene();
            });
            return;
        }
        _privateInput!.Text = _dateView.Editor.Text; SendPrivate();
    }
    private bool CanRegenerateDate(PrivateTurn? turn) => turn is { Status: "complete", UserDeleted: false, ReplyDeleted: false,
        Scene: { Opening: false, Ending: false } } && turn.Scene.OfferId == _dateOffer && turn.RequestKind != "arbitration";
    private void RegenerateDateScene()
    {
        if (_dateView == null || _dateAssets == null) return;
        var turn = PrivateMessages.Conversation(ViewData, _datePerson).Turns.LastOrDefault();
        if (!CanRegenerateDate(turn)) return;
        string entry = turn!.Id, person = _datePerson, offer = _dateOffer;
        ShowCareerDialog("重新生成本轮回复", "将沿用你上一次发送的内容与附件，撤回原回复带来的关系及事件变化，再生成一份新回复。", () =>
        {
            if (_dateView == null || _datePerson != person || _dateOffer != offer) return true;
            PrivateCommand("dm-regenerate", new() { Entry = entry }, () =>
            {
                _dateAssets?.Bookmarks.Remove(offer); _dateState = ""; _dateEditingTurn = ""; TickDateScene();
            });
            return true;
        }, "重新生成");
    }
    private void EditFailedDateScene()
    {
        if (_dateView == null) return;
        var turn = PrivateMessages.Conversation(ViewData, _datePerson).Turns.LastOrDefault();
        if (turn?.Status != "failed" || turn.Scene?.OfferId != _dateOffer || turn.Scene.Ending) return;
        _dateEditingTurn = turn.Id;
        _dateView.Editor.Text = _privateDrafts.GetValueOrDefault(_datePerson) is { Length: > 0 } draft ? draft : turn.Scene.Opening ? "" : turn.User;
        _dateView.ShowInput(CareerEngine.Name(ViewData), keepWaiting: true); _dateView.Editor.SetCaretLine(_dateView.Editor.GetLineCount() - 1); _dateView.Editor.SetCaretColumn(_dateView.Editor.GetLine(_dateView.Editor.GetCaretLine()).Length);
        CareerVisuals.ClearContent(_dateView.Attachments);
        foreach (var item in turn.Attachments) _dateView.Attachments.AddChild(PrivateAttachmentCard(item, false));
        _dateView.ShowAttachments(); _dateView.Status.Text = "修改后发送将重试这一条消息，原附件继续保留。";
    }
    private void DateSceneSettings()
    {
        if (_dateView == null || _dateAssets == null) return;
        var data = ViewData; string person = _datePerson; var assets = _dateAssets;
        void Apply() { if (_dateView != null && IsInstanceValid(_dateView)) { _dateView.TextSpeed = assets.TextSpeed; _dateView.Preferences(assets.FontSize, assets.PanelFade, assets.LetterSpacing); _dateView.Presentation(assets.SpriteScale, assets.SpriteX, assets.SpriteY, assets.TextOutline); _dateView.AffectionVisibility(assets.ShowAffectionBadge); ApplyDateBackground(); } }
        void Save() { DateSceneAssetStore.Save(data, person, assets); Apply(); }
        ShowCareerDialog("场景设置", "背景与显示偏好保存在本机。", () => true, "关闭", outer =>
        {
            var scroll = new BroadcastScroll { Name = "DateSettingsScroll", CustomMinimumSize = new(660, Math.Clamp(_stage.Size.Y - 300, 330, 540)), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; outer.AddChild(scroll);
            var box = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; box.AddThemeConstantOverride("separation", 14); scroll.AddChild(box);
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
            var scaleLabel = Text($"立绘缩放 · {assets.SpriteScale:P0}", 18, _ink); box.AddChild(scaleLabel);
            var scale = new HSlider { Name = "DateSpriteScale", MinValue = .25, MaxValue = 2.5, Step = .01, Value = assets.SpriteScale, CustomMinimumSize = new(600, 35) }; box.AddChild(scale);
            scale.ValueChanged += value => { assets.SpriteScale = value; scaleLabel.Text = $"立绘缩放 · {value:P0}"; Apply(); };
            scale.DragEnded += changed => { if (changed) Save(); };
            var position = new HBoxContainer(); position.AddThemeConstantOverride("separation", 16); box.AddChild(position);
            SpinBox Offset(string axis, double value, Action<double> change)
            {
                position.AddChild(Text(axis, 17, _ink)); var input = new SpinBox { Name = "DateSprite" + axis, MinValue = -4096, MaxValue = 4096, Step = 1, Value = value, CustomMinimumSize = new(170, 42) };
                position.AddChild(input); input.ValueChanged += v => { change(v); Save(); }; return input;
            }
            var x = Offset("X", assets.SpriteX, v => assets.SpriteX = v); var y = Offset("Y", assets.SpriteY, v => assets.SpriteY = v);
            box.AddChild(Button("恢复立绘默认大小与位置", () => { assets.SpriteScale = 1; assets.SpriteX = assets.SpriteY = 0; scale.SetValueNoSignal(1); x.SetValueNoSignal(0); y.SetValueNoSignal(0); scaleLabel.Text = "立绘缩放 · 100%"; Save(); }, 300));
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
