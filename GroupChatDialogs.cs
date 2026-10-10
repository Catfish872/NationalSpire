using Godot;
using System.Text.Json;

namespace NationalSpire;

public partial class CareerScreen
{
    private List<string> _groupSelection = [];
    private void GroupActions()
    {
        var g = CurrentGroup; if (g == null) return;
        void Pick(string title, Action action, bool single = true) => GroupMemberPicker(g, people =>
        {
            _groupSelection = people.Where(id => PrivateMessages.CanChat(ViewData, id)).ToList();
            if (_groupSelection.Count == 0) return;
            _privatePerson = _groupSelection[0]; action();
        }, existing: true, title: title, single: single);
        ShowCareerDialog("添加到群聊消息", "", () => true, "关闭", box =>
        {
            var grid = new GridContainer { Columns = 2 }; grid.AddThemeConstantOverride("h_separation", 12); grid.AddThemeConstantOverride("v_separation", 12); box.AddChild(grid);
            void Choice(string title, string detail, Action action)
            { var b = PrivateButton(title + "\n" + detail, () => { _cancelDialog?.Invoke(); Callable.From(action).CallDeferred(); }, 285); b.CustomMinimumSize = new(285, 78); grid.AddChild(b); }
            Choice("约一局", "选择群内对手", () => Pick("选择约战对象", PrivateMatchPicker));
            Choice("制定训练计划", "选择受训队员与教练", () => Pick("选择受训队员", GroupTrainingPicker, false));
            Choice("调整阵容", "选择本队教练", () => Pick("选择负责教练", PrivateLineupPicker));
            Choice("商谈合同", "选择报价对象", () => Pick("选择商谈对象", () => AttachPrivate(new() { Kind = "contract" }), false));
            Choice("复盘比赛", "附上真实比赛记录", () => { _groupSelection.Clear(); _privatePerson = g.Members.FirstOrDefault(id => PrivateMessages.CanChat(ViewData, id)) ?? ""; PrivateSharePicker("result"); });
            Choice("分享帖子", "选择一篇社区讨论", () => { _groupSelection.Clear(); _privatePerson = g.Members.FirstOrDefault(id => PrivateMessages.CanChat(ViewData, id)) ?? ""; PrivateSharePicker("post"); });
            Choice("尖塔仲裁", "选择本次争议涉及的人物", () => Pick("选择被申请人", GroupArbitrationDialog, false));
        }, showCancel: false);
    }
    private void GroupTrainingPicker()
    {
        var d = ViewData; var g = CurrentGroup!; string text = "", coach = ""; int weeks = 4; Label? error = null;
        var coaches = g.Members.Where(id => CoachLineups.CanRequest(d, id)).ToList();
        if (!ClubCoaching.PlayerCoach(d)) coach = coaches.FirstOrDefault() ?? "";
        ShowCareerDialog("制定训练计划", "受训队员：" + string.Join("、", _groupSelection.Select(id => GroupChats.Name(d, id))), () =>
        {
            if (!ClubCoaching.PlayerCoach(d) && coach.Length == 0) { error!.Text = "请先添加本队教练，或在俱乐部兼任教练。"; return false; }
            if (string.IsNullOrWhiteSpace(text)) { error!.Text = "请填写训练内容。"; return false; }
            AttachPrivate(new() { Kind = "training", Detail = text, Weeks = weeks, CoachId = coach, Participants = _groupSelection.ToList() }); return true;
        }, "添加到消息", box =>
        {
            box.AddChild(PrivateText("负责教练", 16, _muted));
            var picker = new OptionButton { CustomMinimumSize = new(600, 44) }; var choices = new List<string>();
            if (ClubCoaching.PlayerCoach(d)) { picker.AddItem("由我负责训练"); choices.Add(""); }
            foreach (string id in coaches) { picker.AddItem(GroupChats.Name(d, id)); choices.Add(id); }
            picker.ItemSelected += i => coach = choices[(int)i]; box.AddChild(picker);
            var input = new TextEdit { PlaceholderText = "填写训练内容", CustomMinimumSize = new(600, 180), WrapMode = TextEdit.LineWrappingMode.Boundary }; input.TextChanged += () => text = input.Text; box.AddChild(input);
            var duration = new SpinBox { MinValue = 1, MaxValue = 4, Value = 4, Suffix = "周", CustomMinimumSize = new(180, 42) }; duration.ValueChanged += v => weeks = (int)v; box.AddChild(duration);
            error = PrivateText("", 15, new Color("ee929d")); box.AddChild(error);
        });
    }
    private void GroupArbitrationDialog()
    {
        string text = ""; var targets = _groupSelection.ToList();
        ShowCareerDialog("申请群聊仲裁", "被申请人：" + string.Join("、", targets.Select(id => GroupChats.Name(ViewData, id))), () =>
        { GroupCommand("group-arbitrate", new() { People = targets, Text = text }); return true; }, "提交申请", box =>
        {
            var input = new TextEdit { PlaceholderText = "说明需要审理的争议", CustomMinimumSize = new(620, 230), WrapMode = TextEdit.LineWrappingMode.Boundary };
            input.TextChanged += () => text = input.Text; box.AddChild(input);
        });
    }
    private void GroupSettings()
    {
        var g = CurrentGroup!; SpinBox? every = null, recent = null, limit = null, merge = null;
        ShowCareerDialog("群聊记录设置", "", () => { GroupCommand("group-settings", new() { Settings = new() { SummaryEvery = (int)every!.Value, RecentRounds = (int)recent!.Value, SmallSummaryLimit = (int)limit!.Value, MergeOldest = (int)merge!.Value } }); return true; }, "保存", box =>
        {
            SpinBox Field(string name, int value)
            {
                var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 24); box.AddChild(row);
                var label = PrivateLine(name, 18, _ink); label.SizeFlagsHorizontal = SizeFlags.ExpandFill; row.AddChild(label);
                var number = new SpinBox { MinValue = 0, MaxValue = int.MaxValue, Value = value, CustomMinimumSize = new(160, 44) }; row.AddChild(number); return number;
            }
            every = Field("每隔多少轮生成小总结", g.Settings.SummaryEvery); recent = Field("保留近期原文轮数", g.Settings.RecentRounds);
            limit = Field("小总结合并阈值", g.Settings.SmallSummaryLimit); merge = Field("每次合并最早几份", g.Settings.MergeOldest);
        });
    }
    private void GroupMemory()
    {
        var g = CurrentGroup!;
        ShowCareerDialog("群聊记忆", "", () => true, "关闭", box =>
        {
            var actions = new HBoxContainer(); actions.AddThemeConstantOverride("separation", 12); box.AddChild(actions);
            actions.AddChild(PrivateButton("生成小总结", () => GroupCommand("group-summary", new() { Text = "small" }), 140));
            actions.AddChild(PrivateButton("合并长期记忆", () => GroupCommand("group-summary", new() { Text = "big" }), 150));
            actions.AddChild(PrivateButton("清空聊天", () => { _cancelDialog?.Invoke(); ShowCareerDialog("清空群聊记录", "清空聊天原文，保留总结和已经生效的交互。", () => { GroupCommand("group-clear", new()); return true; }, "清空"); }, 110));
            var scroll = new ScrollContainer { CustomMinimumSize = new(670, 350), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);
            var items = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; items.AddThemeConstantOverride("separation", 14); scroll.AddChild(items);
            foreach (var (part, summaries) in new[] { ("big", g.BigSummaries), ("small", g.SmallSummaries) }) foreach (var s in summaries)
            {
                var entry = new VBoxContainer(); items.AddChild(entry); entry.AddChild(PrivateText((part == "big" ? "大总结" : "小总结") + $" · 第{s.From + 1}—{s.Through}轮", 17, _gold));
                var edit = new TextEdit { Text = s.Text, WrapMode = TextEdit.LineWrappingMode.Boundary, CustomMinimumSize = new(630, 130) }; entry.AddChild(edit);
                var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); entry.AddChild(row);
                row.AddChild(PrivateButton("保存", () => GroupCommand("group-summary-edit", new() { Text = edit.Text, Interaction = new() { Entry = s.Id, Part = part } }), 90));
                row.AddChild(PrivateButton("删除", () => { GroupCommand("group-summary-delete", new() { Interaction = new() { Entry = s.Id, Part = part } }); entry.QueueFree(); }, 90));
            }
        }, showCancel: false);
    }
    private void PreviewGroupPrompt()
    {
        var g = CurrentGroup!;
        string text = JsonSerializer.Serialize(GroupChatPrompts.Compose(ViewData, g, new() { Sender = GroupChats.Human(ViewData), Day = ViewData.Day, Order = ViewData.Chats.Order + 1, Text = _privateInput!.Text, Attachments = PrivateAttachments }), new JsonSerializerOptions { WriteIndented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping });
        ShowCareerDialog("群聊提示词预览", "", () => true, "关闭", box =>
        {
            var edit = new TextEdit { Text = text, Editable = false, CustomMinimumSize = new(900, 520), WrapMode = TextEdit.LineWrappingMode.Boundary }; box.AddChild(edit);
            box.AddChild(PrivateButton("复制完整提示词", () => DisplayServer.ClipboardSet(text), 180));
        }, showCancel: false);
    }
}
