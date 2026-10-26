using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private void DeleteDateHistoryReply(string person, string offerId, string turnId, DateSceneMemory? playback = null, Action? refresh = null)
    {
        var data = ViewData;
        string key = DateSceneMemories.FilePath(data, offerId);
        Label? error = null;
        Control? dialog = null;
        void Fail(string message) { if (error != null && IsInstanceValid(error)) error.Text = message; }
        ShowCareerDialog("删除这轮回复", "将删除这一轮 AI 回复的全部发言、旁白及对应回忆画面，并移除相关未确认交互。玩家输入、记忆摘要、好感变化及已确认事项保留。", () =>
        {
            if (DateSceneMemories.FilePath(ViewData, offerId) != key) { Fail("当前生涯已切换，请重新打开历史记录。"); return false; }
            var conversation = PrivateMessages.Mailbox(ViewData).Conversations.GetValueOrDefault(person);
            var turn = conversation?.Turns.FirstOrDefault(t => t.Id == turnId);
            if (turn != null && turn.Scene?.OfferId != offerId) { Fail("这条回复的约会来源已变化，请重新打开历史记录。"); return false; }
            void Applied()
            {
                _multiplayer?.Refresh();
                if (!IsInsideTree() || DateSceneMemories.FilePath(ViewData, offerId) != key) return;
                try
                {
                    if (_dateMemory != null && _dateMemoryKey == key)
                    { if (DateSceneMemories.RemoveReply(_dateMemory.Memory, turnId)) _dateMemory.Dirty = true; }
                    // Persist only the already recorded subset when recording has been turned off.
                    var saved = playback ?? DateSceneMemories.Read(ViewData, offerId);
                    if (saved != null) { DateSceneMemories.RemoveReply(saved, turnId); DateSceneMemories.Save(ViewData, saved); }
                    if (_dateView != null && _datePerson == person && _dateOffer == offerId)
                    {
                        if (_dateTurn == turnId || _dateView.InputMode && _dateInputTurn == turnId)
                        {
                            _dateTurn = _dateSource = _dateEditingTurn = ""; _dateLines = []; _dateIndex = 0;
                            _dateState = "history-deleted"; ShowDateInput(manualGame: CanResumeDateGame());
                        }
                        _dateView.RefreshHistory();
                    }
                    refresh?.Invoke(); if (_dialogOverlay == dialog) _cancelDialog?.Invoke();
                }
                catch (Exception e) { Fail("回复已删除，回忆文件保存失败。请再次确认以重试：" + e.Message); }
            }
            if (turn == null)
            {
                if (playback == null) { Fail("这条回复已不存在，请重新打开历史记录。"); return false; }
                // Archived-only replies have already left the conversation's raw context.
                Applied();
            }
            else PrivateCommand("dm-delete", new() { Entry = turnId, Part = "reply" }, Applied, person, Fail);
            return false;
        }, "删除回复", box => { error = Text("", 17, _muted); error.Name = "DateAttendanceError"; box.AddChild(error); });
        dialog = _dialogOverlay;
    }
}
