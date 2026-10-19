using Godot;

namespace NationalSpire;

/// <summary>生成等待期间的本地立绘互动；失败、重试共用同一展示状态。</summary>
public partial class DateSceneView
{
    public IReadOnlyList<Texture2D> WaitingSprites { get; set; } = [];
    public Texture2D? WaitingDefault { get; set; }
    private bool _waiting, _waitingDoubleBounce;
    private Texture2D? _waitingAnchor, _positionAnchor;
    private double _waitingClock, _waitingBounceAt, _waitingShiftAt = -2;
    private readonly Queue<double> _waitingClicks = new();
    private float _waitingShift, _waitingShiftFrom, _waitingShiftTarget, _waitingShiftElapsed = 1;
    private readonly List<(PanelContainer Panel, double Born)> _waitingBubbles = [];
    private readonly Dictionary<ulong, Rect2> _spriteBounds = [];
    private static readonly string[] WaitingPhrases = ["哈哈哈！", "痒死了！", "别戳了~~~", "呜呜呜……", "嘿嘿～", "嗯？", "哎呀！", "抓到你啦！", "唔……", "又来啦？"];

    private void BeginWaiting()
    {
        if (_waiting) return;
        _waiting = true; _waitingAnchor = _sprite.Texture ?? WaitingDefault;
        _sprite.Texture = _waitingAnchor; _targetAlpha = _waitingAnchor == null ? 0 : 1;
        _waitingClock = 0; _waitingBounceAt = 5; _waitingShiftAt = -2; _waitingClicks.Clear();
        if (_waitingAnchor != null) RememberSprite(_waitingAnchor);
        Layout();
    }
    private void EndWaiting()
    {
        if (!_waiting) return;
        _waiting = false; _sprite.Texture = _waitingAnchor; _waitingAnchor = null;
        _waitingShift = _waitingShiftFrom = _waitingShiftTarget = 0; _waitingShiftElapsed = 1;
        _jump = 0; _waitingDoubleBounce = false; _waitingClicks.Clear();
        foreach (var bubble in _waitingBubbles) { bubble.Panel.Hide(); bubble.Panel.QueueFree(); }
        _waitingBubbles.Clear(); Layout();
    }
    private void RememberSprite(Texture2D texture)
    {
        ulong id = texture.GetInstanceId(); if (_spriteBounds.ContainsKey(id)) return;
        using var image = texture.GetImage(); var used = image.GetUsedRect(); var dimensions = texture.GetSize();
        if (!used.HasArea()) used = new Rect2I(Vector2I.Zero, image.GetSize());
        _spriteBounds[id] = new Rect2((Vector2)used.Position / dimensions, (Vector2)used.Size / dimensions);
        _headRatios[id] = used.Position.Y / dimensions.Y;
    }
    private Rect2 WaitingSpriteBounds()
    {
        if (_sprite.Texture == null) return new();
        RememberSprite(_sprite.Texture); var dimensions = _sprite.Texture.GetSize();
        float fit = Math.Min(_sprite.Size.X / dimensions.X, _sprite.Size.Y / dimensions.Y);
        var drawn = dimensions * fit; var used = _spriteBounds[_sprite.Texture.GetInstanceId()];
        return new Rect2(_sprite.Position + (_sprite.Size - drawn) / 2 + used.Position * drawn, used.Size * drawn);
    }
    private bool WaitingClick(Vector2 position)
    {
        if (!_waiting || HistoryOpen || _sprite.Texture == null || !WaitingSpriteBounds().HasPoint(position)) return false;
        if (!DialogueHidden && (_dialog.GetRect().HasPoint(position) || _nameBox.Visible && _nameBox.GetRect().HasPoint(position))) return false;
        if (WaitingSprites.Count > 0)
        {
            int index = Random.Shared.Next(WaitingSprites.Count);
            // 连续点击时优先显示另一张已导入的图片。
            if (WaitingSprites.Count > 1 && WaitingSprites[index] == _sprite.Texture) index = (index + 1) % WaitingSprites.Count;
            _sprite.Texture = WaitingSprites[index];
        }
        WaitingBounce(true, false);
        while (_waitingClicks.Count > 0 && _waitingClock - _waitingClicks.Peek() > .75) _waitingClicks.Dequeue();
        _waitingClicks.Enqueue(_waitingClock);
        if (_waitingClicks.Count == 3)
        {
            _waitingClicks.Clear(); WaitingBubble();
            if (_waitingClock - _waitingShiftAt >= 2)
            {
                _waitingShiftAt = _waitingClock; _waitingShiftFrom = _waitingShift;
                float distance = Random.Shared.Next(50, 121);
                int direction = Random.Shared.Next(2) == 0 ? -1 : 1;
                if (Math.Abs(_waitingShift + direction * distance) > 120) direction = -direction;
                _waitingShiftTarget = _waitingShift + direction * distance; _waitingShiftElapsed = 0;
            }
        }
        return true;
    }
    private void WaitingBounce(bool strong, bool twice)
    {
        _waitingDoubleBounce = twice; _jumpDuration = twice ? .56f : .36f; _jumpHeight = strong ? 18 : 9; _jump = _jumpDuration;
    }
    private void TickWaiting(double delta)
    {
        if (!_waiting) return;
        _waitingClock += delta;
        if (_waitingClock >= _waitingBounceAt) { _waitingBounceAt = _waitingClock + 5; WaitingBounce(false, true); }
        _waitingShiftElapsed = Math.Min(1, _waitingShiftElapsed + (float)delta / .28f);
        float eased = _waitingShiftElapsed * _waitingShiftElapsed * (3 - 2 * _waitingShiftElapsed);
        _waitingShift = Mathf.Lerp(_waitingShiftFrom, _waitingShiftTarget, eased);
        _sprite.Position = new((Size.X - _sprite.Size.X) * .5f + _spriteX + _waitingShift, _sprite.Position.Y);
        var portrait = _waitingBubbles.Count > 0 ? WaitingSpriteBounds() : new Rect2();
        for (int i = _waitingBubbles.Count - 1; i >= 0; i--)
        {
            var item = _waitingBubbles[i]; double age = _waitingClock - item.Born;
            var bounds = item.Panel.GetRect();
            var center = bounds.GetCenter();
            if (age >= 2.8 || Math.Abs(center.Y - portrait.Position.Y) > 100 || Math.Min(Math.Abs(center.X - portrait.Position.X), Math.Abs(center.X - portrait.End.X)) > 150
                || _dialog.Position.Y - center.Y < 50 || bounds.Intersects(_dialog.GetRect()) || _nameBox.Visible && bounds.Intersects(_nameBox.GetRect()) || _favourHost.Visible && bounds.Intersects(_favourHost.GetRect()))
            { item.Panel.Hide(); item.Panel.QueueFree(); _waitingBubbles.RemoveAt(i); }
            else item.Panel.Modulate = new Color(1, 1, 1, (float)Math.Clamp((2.8 - age) / .4, 0, 1));
        }
    }
    private void WaitingBubble()
    {
        if (DialogueHidden) return;
        var bubble = new PanelContainer { Name = "DateWaitingBubble", MouseFilter = MouseFilterEnum.Ignore };
        bubble.AddThemeStyleboxOverride("panel", CareerVisuals.Box("233b4f66", "b6d0da66", 14, 12));
        var text = new Label { Text = WaitingPhrases[Random.Shared.Next(WaitingPhrases.Length)], MouseFilter = MouseFilterEnum.Ignore };
        text.AddThemeFontSizeOverride("font_size", Math.Max(1, _text.GetThemeFontSize("normal_font_size") - 3)); text.AddThemeColorOverride("font_color", Ink);
        bubble.AddChild(text); _interface.AddChild(bubble); bubble.Size = bubble.GetCombinedMinimumSize();
        var portrait = WaitingSpriteBounds(); var half = bubble.Size / 2;
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
            if (rect.Intersects(_dialog.GetRect()) || _nameBox.Visible && rect.Intersects(_nameBox.GetRect()) || _favourHost.Visible && rect.Intersects(_favourHost.GetRect())) continue;
            bubble.Position = rect.Position; placed = true; break;
        }
        if (!placed) { bubble.Hide(); bubble.QueueFree(); return; }
        _waitingBubbles.Add((bubble, _waitingClock));
    }
}
