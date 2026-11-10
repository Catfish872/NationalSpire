using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private (string Turn, int Index) DateHistoryCursor()
        => _dateHistoryTurn != null ? (_dateHistoryTurn.Id, _dateHistoryIndex)
            : (_dateState == "complete" ? _dateTurn : "", _dateIndex);
    protected PrivateTurn? _dateHistoryTurn;
    protected List<DateSceneLine> _dateHistoryLines = [];
    protected int _dateHistoryIndex;
    private Button? _dateHistoryReturn;

    private static bool DateHistoryHasInput(PrivateTurn turn)
        => !turn.UserDeleted && turn.User.Length > 0 && turn.Scene is { Opening: false, Ending: false, GameEvent.Length: 0 };

    private static bool DateHistoryHasReply(PrivateTurn turn)
        => !turn.ReplyDeleted && turn.Status == "complete" && DateScenes.Lines(turn).Count > 0;

    private void JumpDateHistory(string id)
    {
        var turn = PrivateMessages.Conversation(ViewData, _datePerson).Turns.FirstOrDefault(t => t.Id == id && t.Scene?.OfferId == _dateOffer);
        if (_dateView == null || turn == null || !DateHistoryHasInput(turn) && !DateHistoryHasReply(turn)) return;
        DatePlaybackInterrupted();
        _dateHistoryTurn = turn; _dateHistoryLines = DateHistoryHasReply(turn) ? DateScenes.Lines(turn) : [];
        _dateHistoryIndex = DateHistoryHasInput(turn) ? -1 : 0;
        _dateHistoryReturn?.Show(); ShowDateHistoryPage();
    }

    private void ShowDateHistoryPage(bool notify = true)
    {
        if (_dateView == null || _dateHistoryTurn == null) return;
        if (_dateHistoryIndex < 0)
        {
            DatePlaybackInterrupted();
            _dateView.ShowLine(new() { Text = _dateHistoryTurn.User, Speaker = _datePerson }, CareerEngine.Name(ViewData), PartyTexture(_datePerson, _dateDesign!.DefaultEmotionId));
        }
        else
        {
            var line = _dateHistoryLines[_dateHistoryIndex];
            string speaker = _datePartyArt.ContainsKey(line.Speaker) ? line.Speaker : _datePerson;
            _dateView.ShowRoundLine(_dateHistoryLines, _dateHistoryIndex, CareerEngine.DisplayName(ViewData, speaker), PartyTexture(speaker, line.Emotion));
        }
        _dateView.Streaming(false);
        _dateView.Status.Text = "历史回放 · 点击继续查看已保存的对话";
        ApplyDateHistoryBackground();
        if (notify && _dateHistoryIndex >= 0) DateLineShown(_dateHistoryLines[_dateHistoryIndex], _dateHistoryTurn.Id, _dateHistoryIndex);
        _dateView.EditPreviousButton.Disabled = _dateHistoryTurn.Status != "complete" || !CanEditPreviousDate(_dateHistoryTurn) || _dateHistoryTurn.Scene!.GameEvent.Length > 0;
    }

    private void ApplyDateHistoryBackground()
    {
        if (_dateView == null || _dateHistoryTurn == null || _dateAssets == null) return;
        string id = _dateAssets.Background;
        if (_dateAssets.AutoBackground)
        {
            id = DateSceneBackgrounds.At(_dateBackgrounds, _dateHistoryLines, _dateHistoryIndex, _dateHistoryTurn.Scene!.CurrentBackground, "");
        }
        try { _dateView.Background(_dateBackgrounds.FirstOrDefault(b => b.Id == id)?.Image ?? "", true, _dateAssets.BlurAmount); }
        catch (Exception e) { _dateView.Status.Text = e.Message; }
    }

    private void AdvanceDateHistory()
    {
        if (_dateHistoryIndex + 1 < _dateHistoryLines.Count) { _dateHistoryIndex++; ShowDateHistoryPage(); }
        else
        {
            var turns = PrivateMessages.Conversation(ViewData, _datePerson).Turns;
            int current = turns.FindIndex(turn => turn.Id == _dateHistoryTurn?.Id);
            var next = turns.Skip(current + 1).FirstOrDefault(turn => turn.Scene?.OfferId == _dateOffer
                && (DateHistoryHasInput(turn) || DateHistoryHasReply(turn)));
            if (next != null) JumpDateHistory(next.Id);
            else FinishDateHistory();
        }
    }

    private void FinishDateHistory()
    {
        string last = _dateHistoryTurn?.Id ?? "";
        ClearDateHistory();
        if (_dateView == null) return;
        if (_dateEditingTurn.Length > 0) { ShowDateInput(); return; }
        var latest = PrivateMessages.Conversation(ViewData, _datePerson).Turns.LastOrDefault(turn => turn.Scene?.OfferId == _dateOffer && !turn.ReplyDeleted);
        if (latest?.Id == last && latest.Status == "complete")
        {
            _dateTurn = latest.Id; _dateSource = latest.Reply;
            _dateReply = DateSceneAssetStore.Hash(System.Text.Encoding.UTF8.GetBytes(latest.Reply));
            _dateState = "complete"; _dateLines = DateScenes.Lines(latest);
            _dateInitialBackground = latest.Scene?.CurrentBackground ?? "";
            _dateIndex = _dateLines.Count;
            ShowDateLine();
            _dateAssets!.Bookmarks[_dateOffer] = new() { Turn = _dateTurn, ReplyHash = _dateReply, Index = _dateIndex };
            try { DateSceneAssetStore.Save(ViewData, _datePerson, _dateAssets); }
            catch (Exception e) { _dateView.Status.Text = "播放进度保存失败：" + e.Message; }
        }
        else { _dateState = ""; TickDateScene(); }
    }

    private void ClearDateHistory()
    {
        DatePlaybackInterrupted();
        _dateHistoryTurn = null; _dateHistoryLines = []; _dateHistoryReturn?.Hide();
    }

    private void ReturnFromDateHistory()
    {
        ClearDateHistory();
        if (_dateView == null) return;
        if (_dateView.HistoryOpen) _dateView.GoBack();
        if (_dateEditingTurn.Length > 0) ShowDateInput();
        else if (_dateState == "complete") ShowDateLine();
        else { _dateState = ""; TickDateScene(); }
    }

    private void ConfirmDateHistoryInput()
    {
        if (_dateHistoryTurn == null || _dateView == null) return;
        var turn = _dateHistoryTurn; string person = _datePerson, offer = _dateOffer, key = _dateKey;
        var conversation = PrivateMessages.Conversation(ViewData, person);
        var command = new PrivateMessageCommand { Entry = turn.Id, Offer = offer, Part = conversation.MemoryRevision.ToString(), Text = conversation.Turns.LastOrDefault()?.Id ?? "", Replacement = Guid.NewGuid().ToString("N") };
        ShowCareerDialog("从这里重新输入？", "这里使用重新输入会跳回到之前的对话内容，这一段已有的回复以及之后已经发生的对话将消失。确认后返回当时的输入界面。", () =>
        {
            if (_dateView == null || _datePerson != person || _dateOffer != offer || PortraitDesignStore.Key(ViewData, person) != key) return true;
            PrivateCommand("dm-date-rewind", command, () =>
            {
                _multiplayer?.Refresh();
                _cancelDialog?.Invoke();
                if (_dateView == null || _datePerson != person || _dateOffer != offer || PortraitDesignStore.Key(ViewData, person) != key) return;
                _dateHistoryTurn = null; _dateHistoryLines = []; _dateHistoryReturn?.Hide();
                DatePlaybackInterrupted(true);
                _dateEditingTurn = ""; _dateState = ""; _dateLines = []; _dateIndex = 0;
                _dateAssets?.Bookmarks.Remove(offer); _privateDrafts.Remove(person);
                SyncDateMemory(); SaveDateMemory();
                EditPreviousDateScene();
            }, person);
            return false;
        }, "确认并返回输入", box => { var error = Text("", 17, _muted); error.Name = "DateAttendanceError"; box.AddChild(error); });
    }
}
