using Godot;
using System.Text;
using System.Text.Json;

namespace NationalSpire;

public partial class DateSceneView
{
    public DateMemoryFrame CaptureMemoryFrame(Func<Texture2D, string> image)
    {
        var result = new DateMemoryFrame { Background = _queuedBackgroundId.Length > 0 ? _queuedBackgroundId : _backgroundId, Speaker = _speaker, Cast = _visibleCast.ToList(), Placements = new(_portraitPlacements) };
        foreach (string id in _visibleCast)
        {
            var texture = id == _speaker ? _sprite.Texture : _castSprites.GetValueOrDefault(id)?.Texture;
            texture ??= _cast.First(c => c.PersonId == id).Default;
            result.Portraits[id] = image(texture);
            result.Anchors[id] = image(_cast.First(c => c.PersonId == id).Default);
        }
        return result;
    }
    public void MemoryControls(Action previous, Action restart)
    {
        _hintDismissed = true; _hint.Hide();
        EditPreviousButton.Hide(); _settings.GetNode<Button>("DateSettings").Hide();
        _settings.GetNode<Button>("DateEnd").Text = "返回日记"; ExitButton.Text = "返回日记  Esc";
        AddSceneAction("上一句", "DateMemoryPrevious", previous);
        AddSceneAction("从头回看", "DateMemoryRestart", restart);
    }
    public void ShowMemoryFrame(DateMemoryFrame frame, DateSceneLine line, string name, bool player,
        IReadOnlyDictionary<string, DateMemoryPerson> people, Func<string, Texture2D> texture)
    {
        // Reuse visible controls while restoring the recorded order and per-person textures.
        var ids = frame.Cast.Where(people.ContainsKey).Take(DateSceneParty.VisibleMaximum).ToList();
        SetCast(ids.Select(id => new DateSceneCast(id, people[id].Name, () => texture(frame.Anchors.GetValueOrDefault(id, people[id].Default)))));
        RestoreVisibleCast(ids);
        string speaker = ids.Contains(frame.Speaker) ? frame.Speaker : ids.FirstOrDefault() ?? "";
        var shown = DateSceneMemories.CopyLine(line); shown.Speaker = player || !ids.Contains(line.Speaker) ? speaker : line.Speaker;
        var portrait = texture(frame.Portraits.GetValueOrDefault(shown.Speaker, people.GetValueOrDefault(speaker)?.Default ?? ""));
        PortraitPlacements(frame.Placements);
        Preferences(frame.FontSize, frame.Fade, frame.Spacing); Presentation(frame.Scale, frame.X, frame.Y, frame.Outline);
        AffectionVisibility(frame.Badge);
        Relationship(new() { Favour = frame.Favour, Relationship = frame.Relationship, SelectedBond = frame.Bond, OathConfirmed = frame.Oath }, speaker, animate: false);
        if (line.Narration)
        {
            // Seeking into narration restores the recorded fading portrait, including its last speaker.
            SelectSpeaker(new() { Speaker = speaker }, portrait, false);
            _sprite.Texture = portrait;
        }
        ShowLineCore(shown, name, portrait, false); Streaming(false);
        foreach (string id in ids) _castSprites[id].Texture = texture(frame.Portraits.GetValueOrDefault(id, people[id].Default));
        if (player) _jump = 0;
        SetDialogueVisible(true);
    }
}

/// <summary>Playback renderer; history deletion is delegated to the owning career screen.</summary>
public partial class DateMemoryPlayback : Control
{
    public Action? Closed;
    public Action<string>? DeleteReply;
    public Func<bool>? Blocked;
    public DateSceneMemory Memory { get; set; } = new();
    private DateSceneView _view = null!;
    private readonly Dictionary<string, Texture2D> _textures = [];
    private readonly List<(DateSceneLine Line, string Name, bool Player, DateMemoryFrame Frame, string Turn, int Index)> _pages = [];
    private int _index;
    private string _warning = "";
    public override void _Ready()
    {
        Name = "DateMemoryPlayback"; SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect); MouseFilter = MouseFilterEnum.Stop; ZIndex = 32;
        BuildPages();
        _view = new DateSceneView { TextSpeed = 75, Advance = Next, Exit = Close, HistoryText = History, HistoryEntries = HistoryEntries,
            DeleteHistoryReply = DeleteReply, Blocked = Blocked };
        AddChild(_view); _view.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        _view.MemoryControls(() => { _index = Math.Max(0, _index - 1); ShowPage(); }, () => { _index = 0; ShowPage(); });
        ShowPage();
    }
    private void BuildPages()
    {
        _pages.Clear();
        var last = Memory.Initial ?? new DateMemoryFrame { Cast = Memory.People.Keys.Take(DateSceneParty.VisibleMaximum).ToList(), Speaker = Memory.Host };
        foreach (var turn in Memory.Turns)
        {
            var roster = new DateCastRoster();
            if (turn.User.Length > 0) _pages.Add((new() { Text = turn.User }, Memory.Player + (turn.Choice ? " · 选择回应" : ""), true, turn.UserFrame ?? last, turn.Id, -1));
            for (int index = 0; index < turn.Lines.Count; index++)
            {
                var line = turn.Lines[index];
                if (string.IsNullOrWhiteSpace(line.Text)) continue;
                roster.Observe(line, Memory.Host);
                var frame = turn.Frames.GetValueOrDefault(index);
                if (frame == null)
                {
                    // Unviewed tail at exit still has its text and the date's frozen asset mapping.
                    frame = JsonSerializer.Deserialize<DateMemoryFrame>(JsonSerializer.Serialize(last))!;
                    frame.Cast = roster.Visible.ToList();
                    string speaker = Memory.People.ContainsKey(line.Speaker) ? line.Speaker : Memory.Host;
                    if (!line.Narration && Memory.People.TryGetValue(speaker, out var person))
                    {
                        frame.Speaker = speaker; frame.Portraits[speaker] = person.Emotions.GetValueOrDefault(line.Emotion, person.Default);
                    }
                    if (Memory.Backgrounds.TryGetValue(line.Background, out string? background)) frame.Background = background;
                }
                last = frame;
                _pages.Add((line, line.Narration ? "" : Memory.People.GetValueOrDefault(line.Speaker)?.Name ?? Memory.People.GetValueOrDefault(frame.Speaker)?.Name ?? "", false, frame, turn.Id, index));
            }
        }
    }
    private Texture2D Texture(string hash)
    {
        if (_textures.TryGetValue(hash, out var texture)) return texture;
        try { if (hash.Length > 0) return _textures[hash] = DateSceneAssetStore.Texture(hash); }
        catch (Exception e) { _warning = "部分回忆素材读取失败：" + e.Message; }
        using var image = Image.CreateEmpty(8, 8, false, Image.Format.Rgba8); image.Fill(Colors.Transparent);
        return _textures[hash] = ImageTexture.CreateFromImage(image);
    }
    private void ShowPage()
    {
        if (_pages.Count == 0)
        {
            _view.ShowMemoryFrame(new(), new() { Narration = true, Text = "这份回忆中尚无对话记录。" }, "", false, Memory.People, Texture);
            return;
        }
        var page = _pages[_index];
        _view.ShowMemoryFrame(page.Frame, page.Line, page.Name, page.Player, Memory.People, Texture);
        try { _view.Background(page.Frame.Background, true, page.Frame.Blur); }
        catch (Exception e) { _view.Background("", false); _warning = "回忆背景读取失败：" + e.Message; }
        _view.Status.Text = _warning.Length > 0 ? _warning : $"回忆 · {_index + 1}/{_pages.Count}";
    }
    private void Next()
    {
        if (_index + 1 < _pages.Count) { _index++; ShowPage(); }
        else _view.Status.Text = "回忆已播放完毕 · 可从头回看或返回日记";
    }
    private string History()
    {
        var text = new StringBuilder();
        foreach (var page in _pages.Take(_index + 1)) text.AppendLine(page.Name.Length > 0 ? page.Name : "旁白").AppendLine(DateScenes.DisplayText(page.Line)).AppendLine();
        return text.ToString();
    }
    private IReadOnlyList<DateHistoryEntry> HistoryEntries() => _pages.Take(_index + 1)
        .GroupBy(p => (p.Turn, p.Player)).Select(g => new DateHistoryEntry(g.Key.Turn,
            string.Join("\n\n", g.Select(p => (p.Name.Length > 0 ? p.Name : "旁白") + "\n" + DateScenes.DisplayText(p.Line))), !g.Key.Player)).ToList();
    public void RefreshHistory()
    {
        var anchor = _pages.Count > 0 ? (_pages[_index].Turn, _pages[_index].Index) : ("", -1);
        BuildPages(); int found = _pages.FindIndex(p => (p.Turn, p.Index) == anchor);
        _index = found >= 0 ? found : Math.Clamp(_index, 0, Math.Max(0, _pages.Count - 1));
        ShowPage(); _view.RefreshHistory();
    }
    public void GoBack() => _view.GoBack();
    public void Close() { Hide(); Closed?.Invoke(); QueueFree(); }
    public override void _ExitTree() { foreach (var texture in _textures.Values) texture.Dispose(); }
}
