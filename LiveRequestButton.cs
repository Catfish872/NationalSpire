using Godot;

namespace NationalSpire;

/// <summary>限时回应的局内展示；有效期由对局状态提供，轮廓沿左上角逆时针消退。</summary>
public partial class LiveRequestButton : Button
{
    public double Remaining { get; private set; }
    public bool Held { get; private set; }
    public event Action? Elapsed;
    private Vector2[] _path = [];
    private float[] _lengths = [];
    private Vector2 _pathSize;
    public LiveRequestButton()
    {
        Name = "DateGameRespond"; Text = "回应请求"; FocusMode = FocusModeEnum.None;
        CustomMinimumSize = new(0, 54); AddThemeFontSizeOverride("font_size", 15);
        foreach (var (state, fill) in new[] { ("normal", "493444"), ("hover", "67465c"), ("pressed", "543b4c"), ("disabled", "493444") })
            AddThemeStyleboxOverride(state, CareerVisuals.Box(fill, "b7809d", 7, 10));
        foreach (string state in new[] { "font_color", "font_hover_color", "font_pressed_color", "font_disabled_color" })
            AddThemeColorOverride(state, new Color("f4dce8"));
    }
    public void Sync(double seconds, bool held)
    { Remaining = Math.Clamp(seconds, 0, DateGames.ChatRequestSeconds); Hold(held); QueueRedraw(); }
    public void Hold(bool held) { Held = held; Disabled = held || Remaining <= 0; }
    public override void _Process(double delta)
    {
        if (Held || Remaining <= 0) return;
        Remaining = Math.Max(0, Remaining - delta); QueueRedraw();
        if (Remaining <= 0) { Disabled = true; Elapsed?.Invoke(); }
    }
    private void MeasurePath()
    {
        _pathSize = Size; float inset = 6, radius = 6;
        float left = inset, top = inset, right = Math.Max(left + radius * 2, Size.X - inset), bottom = Math.Max(top + radius * 2, Size.Y - inset);
        var points = new List<Vector2>();
        void Arc(Vector2 center, float from)
        { for (int i = 0; i <= 10; i++) { float angle = Mathf.DegToRad(from - i * 9); points.Add(center + new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)) * radius); } }
        Arc(new(left + radius, top + radius), -90);
        Arc(new(left + radius, bottom - radius), -180);
        Arc(new(right - radius, bottom - radius), -270);
        Arc(new(right - radius, top + radius), 0);
        points.Add(points[0]); _path = points.ToArray(); _lengths = new float[_path.Length];
        for (int i = 1; i < _path.Length; i++) _lengths[i] = _lengths[i - 1] + _path[i - 1].DistanceTo(_path[i]);
    }
    public override void _Draw()
    {
        if (Remaining <= 0) return;
        if (_path.Length == 0 || _pathSize != Size) MeasurePath();
        float cut = _lengths[^1] * (float)(1 - Remaining / DateGames.ChatRequestSeconds);
        var color = new Color("d6ccd1");
        for (int i = 1; i < _path.Length; i++)
        {
            if (_lengths[i] <= cut) continue;
            float segment = _lengths[i] - _lengths[i - 1];
            if (segment <= 0) continue;
            var start = _path[i - 1].Lerp(_path[i], Math.Clamp((cut - _lengths[i - 1]) / segment, 0, 1));
            DrawLine(start, _path[i], color, 3.5f, true);
        }
    }
}
