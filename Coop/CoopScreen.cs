using Godot;
using MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext;

namespace NationalSpire.Coop;

/// <summary>仅负责建房、邀请、等待与存档管理，生涯内容统一使用 CareerScreen。</summary>
public partial class CoopScreen : Control, IScreenContext
{
    public static CoopScreen? Current { get; private set; }
    public Control? DefaultFocusedControl => _back;
    private CoopRuntime Runtime => CoopRuntime.Ensure();
    private CoopCoordinator? Session => Runtime.Session;
    private Control _stage = null!;
    private VBoxContainer _body = null!;
    private VBoxContainer _footer = null!;
    private Label _status = null!;
    private Button _back = null!;
    private readonly List<CanvasItem> _hidden = [];
    private string _message = "", _presence = "";
    private long _revision = -1;
    private int _entrySequence = -1;
    private double _tick;
    private bool _working;
    private Control? _dialog;
    private CoopCommand? _pending;
    private CoopCoordinator? _replySession;
    public static void Open(Control menu, bool stayInRoom = false)
    {
        if (Current != null && IsInstanceValid(Current)) return;
        var screen = new CoopScreen { Name = "NationalSpireMultiplayerLobby", ZIndex = 100, Theme = CareerVisuals.CreateTheme() };
        foreach (var child in menu.GetChildren().OfType<CanvasItem>().Where(c => c.Visible)) { screen._hidden.Add(child); child.Hide(); }
        menu.AddChild(screen); Current = screen;
    }
    public static void OpenCareerOrRoom(Control menu)
    {
        var session = CoopRuntime.Current?.Session;
        if (session?.World is { CareerStarted: true } )
            CareerScreen.OpenView(menu, new CoopCareerSession(session, menu));
        else Open(menu);
    }
    public static void CloseCurrent() { if (Current != null && IsInstanceValid(Current)) Current.Close(); }
    private void Close()
    {
        if (_replySession != null) _replySession.Replied -= Replied;
        foreach (var node in _hidden.Where(IsInstanceValid)) node.Show();
        Current = null; QueueFree(); ActiveScreenContext.Instance.Update();
    }
    private void EnterCareer()
    {
        var menu = (Control)GetParent(); var session = Session!;
        Close(); CareerScreen.OpenView(menu, new CoopCareerSession(session, menu));
    }
    public override void _Ready()
    {
        SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect); MouseFilter = MouseFilterEnum.Stop;
        var background = new BroadcastBackdrop(); AddChild(background); background.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        _stage = new Control(); AddChild(_stage); Resized += Fit; Fit();
        var margin = new MarginContainer(); _stage.AddChild(margin); margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        foreach (string edge in new[] { "left", "right", "top", "bottom" }) margin.AddThemeConstantOverride("margin_" + edge, 38);
        var frame = new VBoxContainer(); frame.AddThemeConstantOverride("separation", 24); margin.AddChild(frame);
        var header = new HBoxContainer(); frame.AddChild(header);
        var brand = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; header.AddChild(brand);
        Text(brand, "国运尖塔：多人模式", 32, CareerVisuals.Gold);
        Text(brand, "一起攀登，同一支队伍，同一个赛季。", 17, CareerVisuals.Muted);
        _back = Button(header, "返回主菜单", Leave, 180);
        _status = Text(frame, "", 17, CareerVisuals.Teal);
        var scroll = new BroadcastScroll { SizeFlagsVertical = SizeFlags.ExpandFill, HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; frame.AddChild(scroll);
        var padding = new MarginContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; padding.AddThemeConstantOverride("margin_bottom", 28); scroll.AddChild(padding);
        _body = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; _body.AddThemeConstantOverride("separation", 22); padding.AddChild(_body);
        _footer = new VBoxContainer(); frame.AddChild(_footer);
        _entrySequence = Session?.World?.EntrySequence ?? -1; Render();
    }
    private void Fit()
    { float scale = Math.Min(Size.X / 1600f, Size.Y / 1000f); _stage.Size = new(1600, 1000); _stage.Scale = Vector2.One * scale; _stage.Position = (Size - _stage.Size * scale) / 2; }
    public override void _Process(double delta)
    {
        _tick += delta; if (_tick < .3) return; _tick = 0;
        _status.Text = _message.Length > 0 ? _message : _working ? "正在连接 Steam 房间……" : Session?.World is { } w ? $"等待房间 · 在线 {Session.Online.Count}/{w.Capacity} · " + (w.Run != null ? "已载入未完成的比赛" : w.CareerStarted ? "生涯进度已载入" : "等待开始生涯") : "2—4 人组队 · 房主保存进度 · 单人存档保持独立";
        if (Session?.World is { } world)
        {
            if (_entrySequence < 0) _entrySequence = world.EntrySequence;
            else if (world.EntrySequence > _entrySequence) { EnterCareer(); return; }
        }
        if (Session is { World: null }) _status.Text = Session.Status;
        string presence = string.Join(',', Session?.Online.Order() ?? Enumerable.Empty<ulong>());
        if (_dialog == null && ((Session?.World?.Revision ?? -1) != _revision || presence != _presence)) Render();
    }
    public override void _Input(InputEvent input)
    {
        if (input is not InputEventKey { Pressed: true, Echo: false, Keycode: Key.Escape }) return;
        GetViewport().SetInputAsHandled();
        if (_dialog != null) { _dialog.QueueFree(); _dialog = null; } else Leave();
    }
    private void Leave()
    {
        if (_working) { Runtime.CancelConnection(); Close(); return; }
        if (Session == null) { Close(); return; }
        Confirm("离开房间", "离开后队伍会等待你重新加入，已经保存的生涯进度会保留。", () => { Runtime.Disconnect(); Close(); });
    }
    private static Label Text(Node parent, string value, int size = 19, Color? color = null)
    { var label = new Label { Text = value, AutowrapMode = TextServer.AutowrapMode.WordSmart, SizeFlagsHorizontal = SizeFlags.ExpandFill }; label.AddThemeFontSizeOverride("font_size", size); label.AddThemeColorOverride("font_color", color ?? CareerVisuals.Ink); parent.AddChild(label); return label; }
    private static Button Button(Node parent, string text, Action action, int width = 220)
    { var button = new BroadcastButton { Text = text, CustomMinimumSize = new(width, 50), SizeFlagsHorizontal = SizeFlags.ShrinkBegin }; button.Pressed += action; parent.AddChild(button); return button; }
    private static VBoxContainer Card(Node parent, string title, Color? accent = null)
    {
        var panel = new BroadcastPanel { Accent = accent ?? CareerVisuals.Teal, SizeFlagsHorizontal = SizeFlags.ExpandFill }; panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("142431", "375061", 10, 25)); parent.AddChild(panel);
        var box = new VBoxContainer(); box.AddThemeConstantOverride("separation", 15); panel.AddChild(box); Text(box, title, 25, CareerVisuals.Gold); return box;
    }
    private static LineEdit Input(Node parent, string placeholder, string value = "")
    { var line = new LineEdit { PlaceholderText = placeholder, Text = value, CustomMinimumSize = new(0, 48), SizeFlagsHorizontal = SizeFlags.ExpandFill }; parent.AddChild(line); return line; }
    private void Confirm(string title, string question, Action action)
    {
        if (_dialog != null) return;
        var shade = new ColorRect { Color = new(0, 0, 0, .8f), MouseFilter = MouseFilterEnum.Stop }; _dialog = shade; _stage.AddChild(shade); shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        var center = new CenterContainer(); shade.AddChild(center); center.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        var wrapper = new VBoxContainer { CustomMinimumSize = new(720, 0) }; center.AddChild(wrapper);
        var body = Card(wrapper, title); Text(body, question); var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 16); body.AddChild(row);
        Button(row, "确认", () => { shade.QueueFree(); _dialog = null; try { action(); } catch (Exception e) { _message = e.Message; } });
        Button(row, "取消", () => { shade.QueueFree(); _dialog = null; });
    }
    private async void Connect(bool host, string name, int capacity = 2, string country = "中国", string code = "", string saved = "")
    {
        if (_working) return; _working = true; _message = "正在连接 Steam 房间……";
        try
        {
            await Runtime.Connect(host, name, name.Trim() + "的队伍", capacity, country, code, saved);
            if (!IsInstanceValid(this) || IsQueuedForDeletion()) return;
            _entrySequence = Session?.World?.EntrySequence ?? -1; _message = "房间已创建，请先邀请队友。"; if (!host) _message = "已加入房间，正在等待队友。"; Render();
        }
        catch (Exception e) { if (IsInstanceValid(this) && !IsQueuedForDeletion()) _message = e.Message; }
        finally { _working = false; }
    }
    private void Submit(string kind, string target = "")
    {
        if (Session?.World is not { } world) return;
        if (_pending != null) return;
        if (_replySession != Session) { if (_replySession != null) _replySession.Replied -= Replied; _replySession = Session; Session.Replied += Replied; }
        _pending = new(world.Id, world.Epoch, Guid.NewGuid().ToString("N"), world.Revision, kind, target);
        _message = kind == "confirm" ? "已提交准备，等待同步。" : "正在同步。";
        try { Session.Retry(_pending); Render(); } catch (Exception e) { _pending = null; _message = e.Message; }
    }
    private void Replied(CoopReply reply)
    { if (_pending?.Id != reply.Id) return; _pending = null; _message = reply.Outcome.Accepted ? (Session?.World?.Proposal != null ? "已准备，等待队友。" : "已完成。") : reply.Outcome.Message; Render(); }
    private void Render()
    {
        CareerVisuals.ClearContent(_body);
        CareerVisuals.ClearContent(_footer);
        _revision = Session?.World?.Revision ?? -1; _presence = string.Join(',', Session?.Online.Order() ?? Enumerable.Empty<ulong>());
        if (Session == null) { Entrance(); return; }
        if (Session.World == null) { var sync = Card(_body, "正在同步房间"); Text(sync, "等待房主发送队伍和存档信息。首次加入可能需要一点时间。"); Button(sync, "取消加入", () => { Runtime.Disconnect(); Render(); }); return; }
        WaitingRoom(Session.World);
    }
    private void Entrance()
    {
        var identity = Card(_body, "你的选手名字"); var name = Input(identity, "进入队伍后显示的名字", CareerEngine.PlayerName); name.Name = "LobbyPlayerName";
        var columns = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }; columns.AddThemeConstantOverride("h_separation", 24); _body.AddChild(columns);
        var host = Card(columns, "创建房间", CareerVisuals.Lime); Text(host, "创建后邀请朋友，进入生涯安排赛事，开赛时全员准备。", 18, CareerVisuals.Muted);
        var choices = new HBoxContainer(); choices.AddThemeConstantOverride("separation", 16); host.AddChild(choices);
        var count = new OptionButton(); foreach (int n in new[] { 2, 3, 4 }) count.AddItem(n + " 人队伍", n); choices.AddChild(count);
        var country = new OptionButton(); foreach (string c in EsportsWorld.Countries) country.AddItem(c); choices.AddChild(country);
        Button(host, "创建房间并邀请队友", () => Connect(true, name.Text, count.GetSelectedId(), country.GetItemText(country.Selected)), 300);
        var join = Card(columns, "加入朋友的房间"); Text(join, "让房主在等待房间中复制邀请码发给你，然后粘贴到这里。", 18, CareerVisuals.Muted);
        var code = Input(join, "在这里粘贴房间邀请码"); code.Name = "LobbyInviteInput";
        var actions = new HBoxContainer(); actions.AddThemeConstantOverride("separation", 12); join.AddChild(actions);
        Button(actions, "粘贴邀请码", () => code.Text = DisplayServer.ClipboardGet().Trim(), 190);
        Button(actions, "加入房间", () => Connect(false, name.Text, code: code.Text), 180);
        var saves = Card(_body, "已有多人生涯"); Text(saves, "房主重新打开存档后，需要再次邀请原来的队友。删除只移除本机这份多人存档。", 17, CareerVisuals.Muted);
        var checkpoints = CoopSettings.Storage.List().ToList();
        if (checkpoints.Count == 0) Text(saves, "尚无多人存档。创建房间后会自动保存。", 18, CareerVisuals.Muted);
        foreach (var cp in checkpoints.OrderByDescending(c => c.World.World.Day))
        {
            var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 14); saves.AddChild(row);
            Text(row, $"{cp.World.Name} · 第 {cp.World.World.Day} 天 · {cp.World.Members.Count}/{cp.World.Capacity} 人", 18);
            Button(row, "继续并邀请", () => Connect(true, name.Text, saved: cp.World.Id), 190);
            Button(row, "删除", () => Confirm("删除多人存档", $"删除“{cp.World.Name}”的本机存档？单人生涯不受影响。", () => { CoopSettings.Storage.Delete(cp.World.Id); Render(); }), 100);
        }
    }
    private void WaitingRoom(CoopWorld world)
    {
        var invite = Card(_body, "邀请队友", CareerVisuals.Lime);
        Text(invite, world.CareerStarted ? "生涯进度已保留。离线队友可使用下面的邀请码重新加入，无需重复确认进入大厅。" : "房间已经建立。把下面的邀请码发给朋友，对方在“多人模式 → 加入朋友的房间”中粘贴。", 18);
        var code = Input(invite, "正在取得邀请码", Runtime.InviteCode); code.Editable = false; code.Name = "RoomInviteCode";
        code.AddThemeStyleboxOverride("read_only", CareerVisuals.Box("102b39", "47788a", 8, 14)); code.AddThemeColorOverride("font_uneditable_color", CareerVisuals.Ink);
        var inviteActions = new HBoxContainer(); invite.AddChild(inviteActions);
        Button(inviteActions, "复制邀请码", () => { DisplayServer.ClipboardSet(Runtime.InviteCode); _message = "邀请码已复制，现在可以发送给朋友。"; }, 210);
        Text(inviteActions, "每次重新打开房间都会生成新的邀请码。", 16, CareerVisuals.Muted);
        var members = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }; members.AddThemeConstantOverride("h_separation", 20); members.AddThemeConstantOverride("v_separation", 20); _body.AddChild(members);
        for (int i = 0; i < world.Capacity; i++)
        {
            var member = world.Members.ElementAtOrDefault(i); var card = Card(members, member == null ? "等待队友加入" : member.Name + (member.SteamId == world.Owner ? " · 房主" : ""));
            if (member == null) { Text(card, "将邀请码发给朋友，这个位置正在等他。", 18, CareerVisuals.Muted); continue; }
            var row = new HBoxContainer(); card.AddChild(row);
            row.AddChild(new CareerAvatar { Art = CareerAvatars.ForPerson(world.World, member.PersonId), Identity = AvatarHonors.ForPerson(world.World, member.PersonId), CustomMinimumSize = new(72,72) });
            string characterId = world.Run?.Characters.GetValueOrDefault(member.SteamId) ?? member.Character;
            string characterName = GameBridge.Characters().FirstOrDefault(c => c.Id.ToString() == characterId)?.Title.GetFormattedText()
                ?? (characterId.Length > 0 ? "角色当前不可用（" + characterId + "）" : "尚未选择角色");
            if (characterId == CareerEngine.RandomCharacterChoice || world.Run == null && member.RandomCharacter) characterName = "随机角色 · 开赛时确定";
            Text(row, (Session!.Online.Contains(member.SteamId) ? "已连接" : "暂时离线") + " · " + characterName, 19);
            if (world.Run != null)
            {
                Text(card, characterId == CareerEngine.RandomCharacterChoice ? "正在准备比赛，随机角色将在开赛时确定。" : "本场角色已保存，继续比赛时自动使用。", 17, CareerVisuals.Teal);
                continue;
            }
            if (member.SteamId != Session.Self) continue;
            Text(card, "选择你的角色", 17, CareerVisuals.Teal); var choices = new HFlowContainer(); card.AddChild(choices);
            foreach (var character in GameBridge.Characters())
            { Button(choices, (!member.RandomCharacter && member.Character == character.Id.ToString() ? "✓ " : "") + character.Title.GetFormattedText(), () => Submit("character", character.Id.ToString()), 180); }
            Button(choices, (member.RandomCharacter ? "✓ " : "") + "随机角色", () => Submit("character", CareerEngine.RandomCharacterChoice), 180);
        }
        var ready = _footer;
        if (world.Proposal is { } proposal)
        {
            Text(ready, proposal.Label); Text(ready, string.Join("  /  ", world.Members.Select(m => m.Name + (proposal.Votes.Contains(m.SteamId) ? " 已同意" : " 等待确认"))), 17, CareerVisuals.Teal);
            bool voted = proposal.Votes.Contains(Session!.Self) || _pending is { Kind: "confirm" } pending && pending.Target == proposal.Id;
            var approve = Button(ready, voted ? "已准备，等待队友" : proposal.Kind == "resume" ? "准备继续比赛" : "准备开赛", () => Submit("confirm", proposal.Id)); approve.Disabled = voted;
            Button(ready, "取消这项安排", () => Submit("cancel"));
        }
        else if (world.Run is { } savedRun)
        {
            Text(ready, !Session!.Full ? "比赛和角色已保存，等待原队友加入后继续。" : "角色沿用本场存档。房主发起继续，全员确认后恢复比赛。", 18, CareerVisuals.Muted);
            if (Session.Host)
            {
                var resume = Button(ready, "继续已保存的比赛", () => Submit("propose-resume"), 300);
                resume.Disabled = !Session.Full || savedRun.Phase != "paused" || savedRun.Terminal != null;
                if (Session.Full && savedRun.Phase != "paused" && savedRun.Terminal == null)
                    Text(ready, "正在完成比赛转场，请稍候。", 17, CareerVisuals.Teal);
            }
            else Text(ready, "等待房主发起继续比赛。", 17, CareerVisuals.Teal);
        }
        else
        {
            Text(ready, "可直接进入生涯，开赛和恢复比赛时全员准备。", 18, CareerVisuals.Muted);
            if (!world.CareerStarted)
            {
                var enter = Button(ready, "进入多人生涯", () => Submit("propose-enter"), 300); enter.Disabled = !Session!.Host;
            }
        }
        if (world.CareerStarted) Button(ready, "进入多人生涯", EnterCareer, 240);
    }
}
