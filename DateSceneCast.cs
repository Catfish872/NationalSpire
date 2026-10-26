using Godot;

namespace NationalSpire;

public sealed record DateSceneCast(string PersonId, string Name, Func<Texture2D> LoadDefault)
{
    private Texture2D? _default;
    public Texture2D Default => _default ??= LoadDefault();
}

/// <summary>Visible slots follow the four latest speaker turns in one AI reply; display splits and narration preserve the current turn.</summary>
public sealed class DateCastRoster
{
    private readonly List<string> _visible = [];
    private readonly Queue<string> _recent = new();
    private string _lastSpeaker = "";
    public IReadOnlyList<string> Visible => _visible;
    public void Clear() { _visible.Clear(); _recent.Clear(); _lastSpeaker = ""; }
    public void Observe(DateSceneLine line, string fallback)
    {
        if (line.Narration || string.IsNullOrWhiteSpace(line.Text)) return;
        string speaker = line.Speaker.Length > 0 ? line.Speaker : fallback;
        if (speaker.Length == 0 || speaker == _lastSpeaker) return;
        // 一次连续发言可含多句、多个显示片段和差分；旁白跳过，换人接话才推进计数。
        _lastSpeaker = speaker;
        _recent.Enqueue(speaker);
        while (_recent.Count > 4) _recent.Dequeue();
        _visible.RemoveAll(id => !_recent.Contains(id));
        if (_visible.Contains(speaker)) return;
        if (_visible.Count < DateSceneParty.VisibleMaximum) _visible.Add(speaker);
        else
        {
            var history = _recent.ToArray();
            string oldest = _visible.OrderBy(id => Array.LastIndexOf(history, id)).First();
            _visible[_visible.IndexOf(oldest)] = speaker;
        }
    }
    public void Replay(IReadOnlyList<DateSceneLine> lines, int index, string fallback)
    {
        Clear();
        for (int i = 0; i <= index && i < lines.Count; i++) Observe(lines[i], fallback);
    }
}

public partial class DateSceneView
{
    private readonly List<DateSceneCast> _cast = [];
    private readonly Dictionary<string, TextureRect> _castSprites = [];
    private readonly List<string> _visibleCast = [];
    private readonly DateCastRoster _castRoster = new();
    private bool _castConfigured;
    private string _speaker = "";
    private bool _castNarration;
    private readonly Dictionary<string, DatePortraitPlacement> _portraitPlacements = [];
    public void PortraitPlacements(IReadOnlyDictionary<string, DatePortraitPlacement> placements)
    {
        _portraitPlacements.Clear();
        foreach (var (id, placement) in placements) _portraitPlacements[id] = placement.Normalized();
        Layout();
    }
    private Vector2 PortraitSize(string person)
        => new Vector2(Size.Y * .62f * 1.3f, Size.Y * .93f * 1.3f) * (_portraitPlacements.TryGetValue(person, out var placement) ? (float)placement.Scale : _spriteScale);
    private Vector2 PortraitPosition(string person, int slot, Vector2 size, Texture2D? anchor)
    {
        if (anchor != null) RememberSprite(anchor);
        float top = anchor == null ? 0 : _headRatios.GetValueOrDefault(anchor.GetInstanceId());
        bool individual = _portraitPlacements.TryGetValue(person, out var placement);
        return new(Size.X * DateSceneParty.Position(_visibleCast.Count, Math.Max(0, slot)) - size.X * .5f + (individual ? 0 : _spriteX),
            Size.Y * .4f - top * size.Y - 160 + (individual ? -(float)placement!.Y : _spriteY));
    }
    public string SpeakerId => _speaker;
    public void SetCast(IEnumerable<DateSceneCast> cast)
    {
        bool waiting = _waiting; EndWaiting();
        _castConfigured = true;
        var visible = _visibleCast.ToArray();
        var members = cast.ToArray();
        _cast.Clear(); _cast.AddRange(members);
        if (!_cast.Any(c => c.PersonId == _speaker))
        {
            _speaker = ""; _positionAnchor = WaitingDefault = _sprite.Texture = null;
            _alpha = _targetAlpha = 0;
        }
        else _positionAnchor = WaitingDefault = _cast.First(c => c.PersonId == _speaker).Default;
        RestoreVisibleCast(visible);
        Layout();
        if (waiting) BeginWaiting();
    }
    private void RestoreVisibleCast(IEnumerable<string> visible)
    {
        var ids = visible.Where(id => _cast.Any(c => c.PersonId == id)).Distinct().Take(DateSceneParty.VisibleMaximum).ToArray();
        foreach (string id in _castSprites.Keys.Except(ids).ToArray())
        { var node = _castSprites[id]; node.Hide(); node.QueueFree(); _castSprites.Remove(id); }
        _visibleCast.Clear(); _visibleCast.AddRange(ids);
        foreach (string id in ids)
            if (!_castSprites.ContainsKey(id)) AddCastSprite(_cast.First(c => c.PersonId == id));
    }
    public void ShowRoundLine(IReadOnlyList<DateSceneLine> lines, int index, string speaker, Texture2D sprite)
    {
        EndWaiting();
        _castRoster.Replay(lines, index, _cast.FirstOrDefault()?.PersonId ?? "");
        RestoreVisibleCast(_castRoster.Visible);
        ShowLineCore(lines[index], speaker, sprite, false);
    }
    private void AddCastSprite(DateSceneCast member)
    {
        var texture = member.Default;
        var node = new TextureRect { Name = "DateCast" + member.PersonId, Texture = texture,
            ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered,
            MouseFilter = MouseFilterEnum.Ignore, Modulate = new(1, 1, 1, 0) };
        AddChild(node); MoveChild(node, _sprite.GetIndex()); _castSprites[member.PersonId] = node;
        RememberSprite(texture);
    }
    private void SelectSpeaker(DateSceneLine line, Texture2D texture, bool advanceCast)
    {
        _castNarration = line.Narration;
        if (line.Narration || _cast.Count == 0) return;
        string next = _cast.Any(c => c.PersonId == line.Speaker) ? line.Speaker : _cast[0].PersonId;
        if (advanceCast)
        {
            _castRoster.Observe(line, next); RestoreVisibleCast(_castRoster.Visible);
        }
        if (_speaker != next)
        {
            if (_castSprites.TryGetValue(_speaker, out var previous))
            { previous.Texture = _sprite.Texture; previous.Modulate = _sprite.Modulate; }
            // 主讲与旁听控件交接同一人物时保留实际透明度，新入场者沿自身初始透明度淡入。
            _alpha = _castSprites.TryGetValue(next, out var incoming) ? incoming.Modulate.A : 0;
            _sprite.Modulate = new Color(1, 1, 1, _alpha);
            _speaker = next; _positionAnchor = _cast.First(c => c.PersonId == next).Default;
        }
        if (_castSprites.TryGetValue(next, out var current)) { current.Texture = texture; current.Hide(); }
        WaitingDefault = _cast.First(c => c.PersonId == next).Default;
    }
    private void LayoutCast()
    {
        foreach (var id in _visibleCast)
        {
            var member = _cast.First(c => c.PersonId == id); var node = _castSprites[id];
            node.Size = PortraitSize(id);
            int slot = _visibleCast.IndexOf(member.PersonId);
            node.Position = PortraitPosition(id, slot, node.Size, member.Default);
            node.Visible = slot >= 0 && member.PersonId != _speaker;
        }
    }
    private void TickCast(double delta)
    {
        foreach (var (id, node) in _castSprites)
        {
            node.Visible = _visibleCast.Contains(id) && id != _speaker;
            float target = _castNarration && !_waiting ? 0 : .9f;
            node.Modulate = new Color(1, 1, 1, Mathf.MoveToward(node.Modulate.A, target, (float)delta * 4));
        }
    }
    public Button AddSceneAction(string text, string name, Action action)
    {
        var button = ActionButton(text, action, name, 150); _settings.AddChild(button);
        foreach (string state in new[] { "normal", "hover", "pressed", "focus", "disabled" }) button.AddThemeStyleboxOverride(state, new StyleBoxEmpty());
        return button;
    }
}
