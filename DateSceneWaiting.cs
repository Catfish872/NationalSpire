using Godot;

namespace NationalSpire;

/// <summary>生成等待期间的本地立绘互动；失败、重试共用同一展示状态。</summary>
public partial class DateSceneView
{
    public Func<string, IReadOnlyList<Texture2D>>? WaitingPortraits { get; set; }
    public IReadOnlyList<Texture2D> WaitingSprites { get; set; } = [];
    public Texture2D? WaitingDefault { get; set; }
    private sealed class WaitingActor(string id, TextureRect sprite)
    {
        public readonly string Id = id;
        public readonly TextureRect Sprite = sprite;
        public readonly Texture2D? Anchor = sprite.Texture;
        public Vector2 Base;
        public IReadOnlyList<Texture2D>? Sprites;
        public readonly Queue<double> Clicks = new();
        public double ShiftAt = -2;
        public float Shift, ShiftFrom, ShiftTarget, ShiftElapsed = 1, Jump, Duration, Height;
        public bool Twice;
    }
    private bool _waiting;
    private Texture2D? _positionAnchor;
    private double _waitingClock, _waitingBounceAt;
    private readonly List<WaitingActor> _waitingActors = [];
    private readonly List<(PanelContainer Panel, double Born, WaitingActor Actor)> _waitingBubbles = [];
    private readonly Dictionary<ulong, Rect2> _spriteBounds = [];
    private static readonly string[] WaitingPhrases = ["哈哈哈！", "痒死了！", "别戳了~~~", "呜呜呜……", "嘿嘿～", "嗯？", "哎呀！", "抓到你啦！", "唔……", "又来啦？"];

    private void BeginWaiting()
    {
        if (_waiting) return;
        _waiting = true; _sprite.Texture ??= WaitingDefault; _targetAlpha = _sprite.Texture == null || _castConfigured && !_visibleCast.Contains(_speaker) ? 0 : 1;
        _waitingClock = 0; _waitingBounceAt = 5; _jump = 0;
        if (!_castConfigured) _waitingActors.Add(new("", _sprite));
        else foreach (string id in _visibleCast) _waitingActors.Add(new(id, id == _speaker ? _sprite : _castSprites[id]));
        Layout();
    }
    private void EndWaiting()
    {
        if (!_waiting) return;
        foreach (var actor in _waitingActors) if (IsInstanceValid(actor.Sprite)) actor.Sprite.Texture = actor.Anchor;
        _waiting = false; _waitingActors.Clear(); _jump = 0;
        foreach (var bubble in _waitingBubbles) { bubble.Panel.Hide(); bubble.Panel.QueueFree(); }
        _waitingBubbles.Clear(); Layout();
    }
    private void LayoutWaiting()
    {
        foreach (var actor in _waitingActors) { actor.Base = actor.Sprite.Position; PositionWaiting(actor); }
    }
    private static void PositionWaiting(WaitingActor actor)
    {
        float phase = actor.Duration > 0 ? 1 - actor.Jump / actor.Duration : 1;
        float bounce = actor.Jump > 0 ? MathF.Abs(MathF.Sin(phase * MathF.PI * (actor.Twice ? 2 : 1))) * actor.Height : 0;
        actor.Sprite.Position = actor.Base + new Vector2(actor.Shift, -bounce);
    }
    private void RememberSprite(Texture2D texture)
    {
        ulong id = texture.GetInstanceId(); if (_spriteBounds.ContainsKey(id)) return;
        using var image = texture.GetImage(); var used = image.GetUsedRect(); var dimensions = texture.GetSize();
        if (!used.HasArea()) used = new Rect2I(Vector2I.Zero, image.GetSize());
        _spriteBounds[id] = new Rect2((Vector2)used.Position / dimensions, (Vector2)used.Size / dimensions);
        _headRatios[id] = used.Position.Y / dimensions.Y;
    }
    private Rect2 WaitingSpriteBounds(TextureRect sprite)
    {
        if (sprite.Texture == null) return new();
        RememberSprite(sprite.Texture); var dimensions = sprite.Texture.GetSize();
        float fit = Math.Min(sprite.Size.X / dimensions.X, sprite.Size.Y / dimensions.Y);
        var drawn = dimensions * fit; var used = _spriteBounds[sprite.Texture.GetInstanceId()];
        return new Rect2(sprite.Position + (sprite.Size - drawn) / 2 + used.Position * drawn, used.Size * drawn);
    }
    private bool WaitingBlocked(Rect2 bounds) => !DialogueHidden && (bounds.Intersects(_dialog.GetRect())
        || _nameBox.Visible && bounds.Intersects(_nameBox.GetRect())
        || _favourHost.Visible && bounds.Intersects(_favourHost.GetRect())
        || bounds.Intersects(_navigation.GetRect())
        || _replyChoices.Visible && bounds.Intersects(_replyChoices.GetRect())
        || _gameChoices.Visible && bounds.Intersects(_gameChoices.GetRect()));
    private bool WaitingClick(Vector2 position)
    {
        if (!_waiting || HistoryOpen || WaitingBlocked(new Rect2(position, Vector2.One))) return false;
        var actor = _waitingActors.Where(a => a.Sprite.Visible && a.Sprite.Texture != null && WaitingSpriteBounds(a.Sprite).HasPoint(position))
            .OrderByDescending(a => a.Sprite.GetIndex()).FirstOrDefault();
        if (actor == null) return false;
        // 每名角色首次被点击时才读取自己的差分，后续点击复用本轮缓存。
        actor.Sprites ??= WaitingPortraits?.Invoke(actor.Id) ?? WaitingSprites;
        if (actor.Sprites.Count > 0)
        {
            int index = Random.Shared.Next(actor.Sprites.Count);
            if (actor.Sprites.Count > 1 && actor.Sprites[index] == actor.Sprite.Texture) index = (index + 1) % actor.Sprites.Count;
            actor.Sprite.Texture = actor.Sprites[index];
        }
        WaitingBounce(actor, true, false);
        while (actor.Clicks.Count > 0 && _waitingClock - actor.Clicks.Peek() > .75) actor.Clicks.Dequeue();
        actor.Clicks.Enqueue(_waitingClock);
        if (actor.Clicks.Count == 3)
        {
            actor.Clicks.Clear(); WaitingBubble(actor);
            if (_waitingClock - actor.ShiftAt >= 2)
            {
                actor.ShiftAt = _waitingClock; actor.ShiftFrom = actor.Shift;
                float distance = Random.Shared.Next(50, 121);
                int direction = Random.Shared.Next(2) == 0 ? -1 : 1;
                if (Math.Abs(actor.Shift + direction * distance) > 120) direction = -direction;
                actor.ShiftTarget = actor.Shift + direction * distance; actor.ShiftElapsed = 0;
            }
        }
        return true;
    }
    private static void WaitingBounce(WaitingActor actor, bool strong, bool twice)
    {
        actor.Twice = twice; actor.Duration = twice ? .56f : .36f; actor.Height = strong ? 18 : 9; actor.Jump = actor.Duration;
    }
    private void TickWaiting(double delta)
    {
        if (!_waiting) return;
        _waitingClock += delta;
        if (_waitingClock >= _waitingBounceAt)
        {
            _waitingBounceAt = _waitingClock + 5;
            foreach (var actor in _waitingActors) WaitingBounce(actor, false, true);
        }
        foreach (var actor in _waitingActors)
        {
            actor.ShiftElapsed = Math.Min(1, actor.ShiftElapsed + (float)delta / .28f);
            float eased = actor.ShiftElapsed * actor.ShiftElapsed * (3 - 2 * actor.ShiftElapsed);
            actor.Shift = Mathf.Lerp(actor.ShiftFrom, actor.ShiftTarget, eased);
            actor.Jump = Math.Max(0, actor.Jump - (float)delta); PositionWaiting(actor);
        }
        for (int i = _waitingBubbles.Count - 1; i >= 0; i--)
        {
            var item = _waitingBubbles[i]; double age = _waitingClock - item.Born;
            var portrait = WaitingSpriteBounds(item.Actor.Sprite); var bounds = item.Panel.GetRect(); var center = bounds.GetCenter();
            if (age >= 2.8 || Math.Abs(center.Y - portrait.Position.Y) > 100
                || Math.Min(Math.Abs(center.X - portrait.Position.X), Math.Abs(center.X - portrait.End.X)) > 150
                || _dialog.Position.Y - center.Y < 50 || WaitingBlocked(bounds))
            { item.Panel.Hide(); item.Panel.QueueFree(); _waitingBubbles.RemoveAt(i); }
            else item.Panel.Modulate = new Color(1, 1, 1, (float)Math.Clamp((2.8 - age) / .4, 0, 1));
        }
    }
    private void WaitingBubble(WaitingActor actor)
    {
        if (DialogueHidden) return;
        var bubble = new PanelContainer { Name = "DateWaitingBubble", MouseFilter = MouseFilterEnum.Ignore };
        bubble.SetMeta("person", actor.Id);
        bubble.AddThemeStyleboxOverride("panel", CareerVisuals.Box("233b4f66", "b6d0da66", 14, 12));
        var text = new Label { Text = WaitingPhrases[Random.Shared.Next(WaitingPhrases.Length)], MouseFilter = MouseFilterEnum.Ignore };
        text.AddThemeFontSizeOverride("font_size", Math.Max(1, _text.GetThemeFontSize("normal_font_size") - 3)); text.AddThemeColorOverride("font_color", Ink);
        bubble.AddChild(text); _interface.AddChild(bubble); bubble.Size = bubble.GetCombinedMinimumSize();
        var portrait = WaitingSpriteBounds(actor.Sprite); var half = bubble.Size / 2;
        float low = Math.Max(half.Y + 4, portrait.Position.Y - 80);
        float high = Math.Min(portrait.Position.Y + 80, Math.Min(_dialog.Position.Y - 50, _dialog.Position.Y - half.Y - 4));
        bool placed = false;
        for (int i = 0; i < 16 && high >= low; i++)
        {
            float side = Random.Shared.Next(2) == 0 ? portrait.Position.X : portrait.End.X;
            float left = Math.Max(half.X + 4, side - 150), right = Math.Min(Size.X - half.X - 4, side + 150);
            if (right < left) continue;
            var center = new Vector2(Mathf.Lerp(left, right, Random.Shared.NextSingle()), Mathf.Lerp(low, high, Random.Shared.NextSingle()));
            var rect = new Rect2(center - half, bubble.Size);
            if (WaitingBlocked(rect)) continue;
            bubble.Position = rect.Position; placed = true; break;
        }
        if (!placed) { bubble.Hide(); bubble.QueueFree(); return; }
        _waitingBubbles.Add((bubble, _waitingClock, actor));
    }
}
