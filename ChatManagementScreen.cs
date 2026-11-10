using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private IEnumerable<(string Title, Action Run)> ChatMenuItems(string id, bool group)
    {
        string key = group ? "group:" + id : id;
        if (id.Length > 0)
        {
            void Open(Action action)
            {
                CloseChatContextMenu();
                if (ChatDraftKey != key) { if (group) SelectGroup(id); else SelectPrivate(id); }
                OpenChatDialog(action);
            }
            yield return (ChatPinned(key) ? "取消置顶" : "置顶会话", () =>
            {
                SetChatPinned(key, !ChatPinned(key)); CloseChatContextMenu();
                if (_dialogOverlay != null) OpenChatDialog(ChatSettingsMenu, false);
            });
            yield return ("聊天记录设置", () => Open(PrivateSettings));
            yield return ("导出聊天记录", () => Open(ExportChatTranscript));
            yield return ("主动联系", () => Open(ProactiveChatDialog));
            yield return (group ? "群聊管理" : "私聊管理", () => Open(ChatManageDialog));
            yield return ("记忆管理", () => Open(PrivateMemory));
            yield return ("提示词预览", () => Open(PreviewPrivatePrompt));
            if (group) yield return ("添加群成员", () => Open(() => GroupMemberPicker(CurrentGroup!, people => GroupCommand("group-add", new() { People = people }))));
        }
        yield return ("恢复会话", () =>
        {
            CloseChatContextMenu();
            if (id.Length > 0 && ChatDraftKey != key) { if (group) SelectGroup(id); else SelectPrivate(id); }
            OpenChatDialog(RestoreChatDialog);
        });
    }
    private void ChatSettingsMenu()
    {
        var g = CurrentGroup;
        ShowCareerDialog("通讯设置", "", () => true, "关闭", box =>
        {
            if (ChatDraftKey.Length > 0)
                box.AddChild(Text(g == null ? "当前私聊 · " + GroupChats.Name(ViewData, _privatePerson) : "当前群聊 · " + g.Name, 18, _muted));
            var grid = new GridContainer { Columns = 2 }; grid.AddThemeConstantOverride("h_separation", 14); grid.AddThemeConstantOverride("v_separation", 14); box.AddChild(grid);
            foreach (var item in ChatMenuItems(g?.Id ?? _privatePerson, g != null))
            {
                var button = PrivateButton(item.Title, item.Run, 260); button.SizeFlagsHorizontal = SizeFlags.ExpandFill; grid.AddChild(button);
            }
        }, showCancel: false);
    }
    private void ChatManageDialog()
    {
        var g = CurrentGroup;
        ShowCareerDialog(g == null ? "管理私聊" : "管理群聊", "", () => true, "完成", box =>
        {
            if (g != null)
            {
                box.AddChild(Text("群聊名称", 16, _muted));
                var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); box.AddChild(row);
                var input = new LineEdit { Name = "GroupRenameInput", Text = g.Name, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 44) };
                row.AddChild(input);
                var error = Text("", 15, new Color("ee929d")); error.Visible = false;
                void Rename()
                {
                    error.Visible = string.IsNullOrWhiteSpace(input.Text);
                    if (error.Visible) { error.Text = "请填写群聊名称。"; input.GrabFocus(); return; }
                    GroupCommand("group-rename", new() { Text = input.Text }, () => OpenChatDialog(ChatManageDialog));
                }
                var saveName = PrivateButton("保存名称", Rename, 110); saveName.SizeFlagsVertical = SizeFlags.Fill; row.AddChild(saveName);
                input.TextChanged += _ => error.Visible = false;
                input.TextSubmitted += _ => Rename(); box.AddChild(error);
            }
            void Choice(string title, string detail, Action action)
            {
                var button = PrivateButton(title, () => OpenChatDialog(action), 0); box.AddChild(button);
                box.AddChild(Text(detail, 15, _muted));
            }
            Choice(g == null ? "隐藏私聊" : "解散群聊", "保留聊天记录，可在恢复会话中重新打开。", () => ConfirmChatRemoval(false));
            Choice(g == null ? "删除私聊及其全部记忆" : "删除群聊及其全部记忆", "清除这段会话的记录、总结和上下文来源；已发生的游戏结果继续保留。", () => ConfirmChatRemoval(true));
            if (g != null)
            {
                var scroll = new ScrollContainer { CustomMinimumSize = new(0, Math.Min(320, (g.Members.Count - 1) * 54)), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled };
                var members = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill };
                scroll.AddChild(members); box.AddChild(scroll);
                foreach (string id in g.Members.Where(id => id != GroupChats.Human(ViewData)))
                {
                    string person = id;
                    var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); members.AddChild(row);
                    var name = Text(GroupChats.Name(ViewData, person), 18, _ink); name.SizeFlagsHorizontal = SizeFlags.ExpandFill; row.AddChild(name);
                    row.AddChild(PrivateButton("移出群聊", () => OpenChatDialog(() => ConfirmKick(person, false)), 110));
                    row.AddChild(PrivateButton("移出并删除其群聊记忆", () => OpenChatDialog(() => ConfirmKick(person, true)), 230));
                }
            }
        });
    }
    private void OpenChatDialog(Action action, bool returnToSettings = true)
    {
        _cancelDialog?.Invoke();
        Callable.From(() =>
        {
            if (_privateOverlay == null) return;
            _openingDialogReturn = returnToSettings ? ChatSettingsMenu : null;
            try { action(); }
            finally { _openingDialogReturn = null; }
        }).CallDeferred();
    }
    private void ConfirmKick(string person, bool forget)
        => ShowCareerDialog("移出 " + GroupChats.Name(ViewData, person), forget ? "将这位成员移出群聊，并清除其从本群读取的聊天记录、总结及上下文来源。" : "这位成员保留离开前的群聊记忆。",
            () =>
            {
                var dialog = _dialogOverlay;
                GroupCommand("group-manage", new() { Text = forget ? "kick-forget" : "kick", People = [person] },
                    () => { if (_dialogOverlay == dialog && _privateOverlay != null) OpenChatDialog(ChatManageDialog); });
                return false;
            }, "确定");
    private void ConfirmChatRemoval(bool forget)
        => ShowCareerDialog(forget ? CurrentGroup == null ? "删除私聊及其全部记忆" : "删除群聊及其全部记忆" : CurrentGroup == null ? "隐藏私聊" : "解散群聊",
            forget ? (CurrentGroup == null ? "删除与" + GroupChats.Name(ViewData, _privatePerson) + "的私聊" : "删除群聊《" + CurrentGroup.Name + "》及现任、已离群成员对本群的记忆") + "，清除聊天记录、总结及上下文来源。已经生效的合同、活动、训练及关系继续保留。" : "记录和总结保留在恢复会话中。", () =>
            {
                void Removed()
                {
                    if (forget && ChatPinned(ChatDraftKey)) SetChatPinned(ChatDraftKey, false);
                    _privateGroup = _privatePerson = ""; _privateListSignature = "";
                    CareerVisuals.ClearContent(_privateHeading!); CareerVisuals.ClearContent(_privateBody!); RefreshPrivateList();
                }
                if (CurrentGroup != null) GroupCommand("group-manage", new() { Text = forget ? "forget" : "hide" }, Removed);
                else PrivateCommand("dm-manage", new() { Part = forget ? "forget" : "hide" }, Removed);
                return true;
            }, forget ? "清除并删除" : "确定");
    private void RestoreChatDialog()
    {
        var d = ViewData;
        ShowCareerDialog("恢复会话", "选择一段保留的会话。", () => true, "完成", box =>
        {
            foreach (var c in PrivateMessages.Mailbox(d).Conversations.Values.Where(c => c.Hidden && !c.Forgotten))
            {
                string id = c.PersonId;
                box.AddChild(PrivateButton(GroupChats.Name(d, id), () => { _privatePerson = id; PrivateCommand("dm-manage", new() { Part = "restore" }, () => { _cancelDialog?.Invoke(); SelectPrivate(id); }); }, 0));
            }
            foreach (var g in d.Chats.Groups.Where(g => g.Dissolved && !g.Forgotten && g.Members.Contains(GroupChats.Human(d))))
            {
                string id = g.Id;
                box.AddChild(PrivateButton(g.Name, () => { _privateGroup = id; GroupCommand("group-manage", new() { Text = "restore" }, () => { _cancelDialog?.Invoke(); SelectGroup(id); }); }, 0));
            }
        });
    }
    private void ProactiveChatDialog()
    {
        var current = CurrentGroup is { } g ? g.Proactive.GetValueOrDefault(GroupChats.Human(ViewData)) ?? new()
            : PrivateMessages.Conversation(ViewData, _privatePerson).Proactive;
        CheckBox? enabled = null, final = null; SpinBox? match = null, events = null, days = null, unanswered = null;
        ShowCareerDialog("主动联系", "为当前会话设置。你回复后，连续联系次数重新计算。", () =>
        {
            var value = new ProactiveChatSettings { Enabled = enabled!.ButtonPressed, FinalAlwaysReply = final!.ButtonPressed, MatchChance = (int)match!.Value,
                EventChance = (int)events!.Value, DayChance = (int)days!.Value, UnansweredLimit = (int)unanswered!.Value };
            if (CurrentGroup != null) GroupCommand("group-proactive", new() { Proactive = value });
            else PrivateCommand("dm-proactive", new() { Proactive = value });
            return true;
        }, "保存", box =>
        {
            enabled = new CheckBox { Text = "允许主动联系", ButtonPressed = current.Enabled }; box.AddChild(enabled);
            SpinBox Field(string label, int value, int min, int max, string suffix)
            {
                var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 24); box.AddChild(row);
                var caption = Text(label, 18, _ink); caption.SizeFlagsHorizontal = SizeFlags.ExpandFill; row.AddChild(caption);
                var number = new SpinBox { MinValue = min, MaxValue = max, Value = value, Suffix = suffix,
                    UpdateOnTextChanged = true, CustomMinimumSize = new(160, 46) }; row.AddChild(number); return number;
            }
            match = Field("赛后联系概率", current.MatchChance, 0, 100, "%");
            final = new CheckBox { Text = "夺冠赛必定回复", ButtonPressed = current.FinalAlwaysReply }; box.AddChild(final);
            box.AddChild(Text("参加决赛后，胜负均按100%触发；沿用连续联系次数上限。", 15, _muted));
            events = Field("相关事件联系概率", current.EventChance, 0, 100, "%");
            days = Field("平常过日联系概率", current.DayChance, 0, 100, "%");
            unanswered = Field("连续几轮后等待回应", current.UnansweredLimit, 1, int.MaxValue, "轮");
            box.AddChild(Text($"已连续主动联系 {current.Unanswered} 轮", 15, _muted));
        });
    }
}
