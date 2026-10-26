using Godot;
using System.Text;

namespace NationalSpire;

/// <summary>开发者预览：仅维护内存台词及资源，完全独立于私信队列和生涯保存。</summary>
public partial class DateSceneTesting : Control
{
    public Action? Closed;
    private DateSceneView _view = null!;
    private DateSceneRequest _request = new();
    private readonly Dictionary<string, Dictionary<string, List<Texture2D>>> _textures = [];
    private readonly List<Texture2D> _owned = [];
    private readonly StringBuilder _history = new();
    private PrivateStreamParser _parser = new();
    private List<DateSceneLine> _lines = [];
    private string _pending = "";
    private int _received, _index, _round;
    private double _clock;
    private bool _complete;
    private string _lastInput = "";
    private int _roundHistoryStart;
    private bool _editing;
    public void Initialize(CareerData data, IReadOnlyList<string> people)
    {
        if (people.Count < 1) throw new ArgumentException("请选择至少一名角色。");
        foreach (string person in people.Distinct())
        {
            var member = new DateSceneParticipant { PersonId = person, Name = CareerEngine.DisplayName(data, person), Emotions = new() { ["neutral"] = "平淡", ["excited"] = "兴奋" } };
            var images = new Dictionary<string, List<Texture2D>>();
            try
            {
                var design = PortraitDesignStore.Read(PortraitDesignStore.FilePath(data, person), person);
                var assets = DateSceneAssetStore.Read(data, person);
                if (!assets.UseDefaultPortrait && design != null && DateSceneAssetStore.Ready(assets, design) == null)
                {
                    member.DefaultEmotionId = design.DefaultEmotionId; member.OutfitId = assets.OutfitId; member.Emotions.Clear();
                    foreach (var emotion in design.Emotions.Where(e => e.Enabled))
                    {
                        var loaded = new List<Texture2D>();
                        foreach (string key in DateSceneAssetStore.SpriteKeys(assets, design, emotion.Id))
                            try { var image = DateSceneAssetStore.Texture(assets.Sprites[key]); loaded.Add(image); _owned.Add(image); } catch { }
                        if (loaded.Count > 0) { images[emotion.Id] = loaded; member.Emotions[emotion.Id] = emotion.Name; }
                    }
                }
            }
            catch { }
            if (!images.ContainsKey(member.DefaultEmotionId))
            {
                member.DefaultEmotionId = "neutral"; member.Emotions = new() { ["neutral"] = "平淡", ["excited"] = "兴奋" };
                var texture = DateDefaultPortraits.Texture(data, person); _owned.Add(texture);
                images["neutral"] = [texture]; images["excited"] = [texture];
            }
            _request.Participants.Add(member); _textures[person] = images;
        }
        var first = _request.Participants[0]; _request.DefaultEmotionId = first.DefaultEmotionId; _request.Emotions = first.Emotions;
    }
    private Texture2D Texture(string person, string emotion)
    {
        var member = _request.Participants.First(p => p.PersonId == person); var options = _textures[person].GetValueOrDefault(emotion) ?? _textures[person][member.DefaultEmotionId];
        return options[Random.Shared.Next(options.Count)];
    }
    public override void _Ready()
    {
        Name = "DeveloperDateTest"; MouseFilter = MouseFilterEnum.Stop; ZIndex = 60;
        SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        var first = _request.Participants[0]; var initial = Texture(first.PersonId, first.DefaultEmotionId);
        _view = new() { WaitingDefault = initial, WaitingSprites = _owned, Exit = Close, Submit = Send, Advance = Advance,
            HistoryText = () => _history.ToString(), RetryStop = () => Generate("重新测试"), EditPrevious = EditPreviousInput,
            Settings = () => { _view!.TextSpeed = _view.TextSpeed == DateSceneView.InstantSpeed ? 75 : DateSceneView.InstantSpeed; _view.Status.Text = "测试字速已切换；Esc结束测试。"; } };
        AddChild(_view); _view.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        _view.SetCast(_request.Participants.Select(p => new DateSceneCast(p.PersonId, p.Name, () => Texture(p.PersonId, p.DefaultEmotionId))));
        _view.WaitingPortraits = person => _textures.GetValueOrDefault(person, _textures[first.PersonId]).Values.SelectMany(x => x).Distinct().ToList();
        _view.AddAttachment = () => _view.Status.Text = "测试约会使用本地台词，附件在正式约会中使用。";
        _view.Relationship(new PrivateRelation { Favour = 30, Relationship = "测试关系" });
        Generate("开场");
    }
    private void Send()
    {
        if (!_view.InputMode || string.IsNullOrWhiteSpace(_view.Editor.Text)) return;
        SendInput(_view.Editor.Text);
    }
    private void SendInput(string text)
    {
        if (_editing) _history.Length = _roundHistoryStart;
        _editing = false; _lastInput = text; _roundHistoryStart = _history.Length;
        _history.AppendLine("玩家").AppendLine(text).AppendLine(); _view.Editor.Text = ""; Generate(text);
    }
    private void EditPreviousInput()
    {
        if (!_complete || _lastInput.Length == 0 || _editing) return;
        _editing = true; _view.Editor.Text = _lastInput;
        _view.ShowInput("玩家 · 测试约会", showChoices: false);
        _view.Editor.SetCaretLine(_view.Editor.GetLineCount() - 1); _view.Editor.SetCaretColumn(_view.Editor.GetLine(_view.Editor.GetCaretLine()).Length);
    }
    private void Generate(string input)
    {
        _round++; _index = _received = 0; _clock = 0; _complete = false; _lines.Clear(); _parser = new();
        var script = new StringBuilder("[Scene: narration, Emotion: neutral, Background: current]（微风拂过树梢，大家在长椅旁坐下。）\n");
        string[][] phrases = [["这里真舒服。你也坐过来吧。", "听你这么说，我想到了另一个办法。", "那我们就这样约好了！"], ["我也觉得，不过我更想先去散散步。", "等一下，这个主意听起来很有趣。", "好呀，我和你们一起。"], ["你们看那边，我刚发现了一家小店。", "我刚好也想说这个！", "走吧，今天还有很多时间。"]];
        for (int exchange = 0; exchange < 3; exchange++)
            for (int i = 0; i < _request.Participants.Count; i++)
            {
                var p = _request.Participants[i]; string emotion = exchange == 2 && p.Emotions.ContainsKey("excited") ? "excited" : p.DefaultEmotionId;
                script.AppendLine($"[Scene: dialogue, Speaker: {p.PersonId}, Emotion: {emotion}, Background: current]{phrases[i % phrases.Length][exchange]}");
            }
        _pending = script.ToString(); _view.ShowWaiting("本地测试台词 · 模拟流式接收", false);
    }
    public override void _Process(double delta)
    {
        _view.EditPreviousButton.Disabled = !_complete || _lastInput.Length == 0 || _editing;
        if (_complete) return;
        _clock += delta; if (_clock < .06) return; _clock = 0;
        int count = Math.Min(18, _pending.Length - _received); _parser.Feed(_pending.Substring(_received, count)); _received += count;
        _complete = _received == _pending.Length; if (_complete) _parser.Finish();
        bool first = _lines.Count == 0; _lines = DateScenes.TaggedLines(_parser, _request);
        if (_lines.Count > 0)
        {
            if (first) Show();
            else
            {
                var line = _lines[Math.Min(_index, _lines.Count - 1)];
                _view.AppendLine(_lines, Math.Min(_index, _lines.Count - 1), () =>
                {
                    var person = _request.Participants.FirstOrDefault(p => p.PersonId == line.Speaker) ?? _request.Participants[0];
                    return (person.Name, Texture(person.PersonId, line.Emotion));
                });
            }
            _view.Streaming(!_complete);
        }
        if (_complete)
            foreach (var line in _lines) _history.AppendLine(line.Narration ? "旁白" : _request.Participants.First(p => p.PersonId == line.Speaker).Name).AppendLine(DateScenes.DisplayText(line)).AppendLine();
    }
    private void Advance()
    {
        if (!_complete && _index + 2 >= _lines.Count) return;
        if (_index < _lines.Count) _index++; Show();
    }
    private new void Show()
    {
        if (_index >= _lines.Count)
        {
            _view.SetReplyChoices("聊聊接下来的安排", () => SendInput("聊聊接下来的安排"), "一起休息一会儿", () => SendInput("一起休息一会儿"));
            _view.ShowInput("玩家 · 测试约会"); return;
        }
        var line = _lines[_index]; var person = _request.Participants.FirstOrDefault(p => p.PersonId == line.Speaker) ?? _request.Participants[0];
        _view.ShowRoundLine(_lines, _index, person.Name, Texture(person.PersonId, line.Emotion)); _view.Streaming(!_complete);
    }
    public void Close() { Hide(); Closed?.Invoke(); QueueFree(); }
    public override void _ExitTree() { foreach (var texture in _owned) texture.Dispose(); }
}

public partial class CareerScreen
{
    private DateSceneTesting? _testDateScene;
    private void TestDateScenePicker()
    {
        GroupMemberPicker(new GroupChat(), people =>
        {
            if (people.Count < 1) { Notice("测试约会请选择至少一名NPC。", true); return; }
            var test = new DateSceneTesting();
            try { test.Initialize(ViewData, people); }
            catch (Exception e) { test.Dispose(); Notice(e.Message, true); return; }
            _testDateScene = test; test.Closed = () => _testDateScene = null; _stage.AddChild(test);
        }, title: "测试约会 · 选择参与角色");
    }
}
