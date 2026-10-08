using Godot;

namespace NationalSpire;

/// <summary>
/// 局内顶部弹幕层：把解说与观众文本做成多轨道横向飘动的弹幕。
/// 只负责显示，不产生任何文本，也不改变比赛结算与存档数据。
/// 挂在游戏原生 <c>NRun.GlobalUi</c> 下，与转播面板同级，不拦截鼠标。
/// </summary>
public partial class LiveDanmakuLayer : Control
{
    /// <summary>轨道高度，轨道数乘以它就是弹幕层占用的画面高度（与配置界面文案一致）。</summary>
    private const int LaneHeight = 34;
    /// <summary>基准滚动速度（像素/秒），实际速度再乘以配置倍率。</summary>
    private const float BaseSpeed = 190f;
    /// <summary>弹幕随机配色池：高饱和亮色，压在战斗背景上也读得清。</summary>
    private static readonly Color[] Palette =
    [
        new("ffd45e"), new("8bf0e4"), new("8fd0ff"), new("c9a6ff"),
        new("ff9fd6"), new("a8f57a"), new("ffb066"), new("ff8f8f")
    ];
    /// <summary>弹幕左移出这条线之外，连同其宽度一起离开屏幕后才回收。</summary>
    private const float RecycleMargin = 64f;
    /// <summary>发射时与前一条弹幕保持的最小水平间距，间隔不足时换轨道。</summary>
    private const float SpawnGap = 90f;
    /// <summary>
    /// 同一条高度上，前一条弹幕的尾部还没离开出生点这么远时，就不在这条高度上再生成。
    /// 注意别调大：它同时是「生成量」的隐形上限——阈值越大，单位时间内可发射的条数越少，
    /// 会让「最低同时生成数量」拿不到轨道而静默丢条。密度由生成间距控制，这里只防贴脸重叠。
    /// </summary>
    private const float TightSpawnGap = 40f;
    /// <summary>单条弹幕在屏时长的兜底上限，防止极端慢速下永不回收。</summary>
    private const double MaximumLifetime = 30;

    private sealed class Item
    {
        public Label Label = null!;
        public float Width;
        public float Speed;
        public double Lifetime;
        public bool[] Boarded = null!;
    }

    private readonly List<Item> _items = [];
    private readonly List<Item> _pool = [];
    private readonly Queue<(string Text, bool Analyst, string Topic)> _pending = [];
    /// <summary>去重窗口：记录最近实际发射过的文本与条数，窗口按「条」滑动。</summary>
    private readonly Dictionary<string, int> _window = [];
    private readonly Queue<string> _windowOrder = [];
    private DanmakuOptions _options = new();
    private readonly Random _random = new();
    /// <summary>生成范围内的候选高度（像素），随窗口尺寸与生成范围刷新。</summary>
    private float[] _lanes = [];
    /// <summary>层内累计时间（秒），用于按浓度档位节流。</summary>
    private double _now;
    /// <summary>上一次实际发射的时间戳（秒）。</summary>
    private double _lastEmit;
    private Font _font = null!;
    private int _activeLanes;
    private int _dropped;
    private int _droppedLane;
    private int _droppedWide;
    private int _starved;
    private int _spawned;
    private bool _layoutDirty;
    private int _pixelBudget;
    private bool _selfTestComplete;

    /// <summary>当前生效配置。</summary>
    public DanmakuOptions Options => _options;
    /// <summary>在屏弹幕条数。</summary>
    public int ActiveCount => _items.Count;
    /// <summary>等待上屏的条数。</summary>
    public int PendingCount => _pending.Count;
    /// <summary>已成功发射的总条数（用于自检与诊断）。</summary>
    public int SpawnedTotal => _spawned;
    /// <summary>因超过在屏上限或没有可用轨道而被丢弃的条数。</summary>
    public int DroppedTotal => _dropped;
    /// <summary>本场因轨道拥挤而丢掉的条数（生成量上不去的首要嫌疑）。</summary>
    public int DroppedLaneTotal => _droppedLane;
    /// <summary>本场因单条过宽而丢掉的条数。</summary>
    public int DroppedWideTotal => _droppedWide;
    /// <summary>本场因补料枯竭或全部去重而提前结束的轮次。</summary>
    public int StarvedRounds => _starved;
    /// <summary>当前实际使用的轨道数。</summary>
    public int LaneCount => _activeLanes;

    public override void _Ready()
    {
        Name = "NationalSpireDanmaku";
        MouseFilter = MouseFilterEnum.Ignore;
        // 高于转播面板（面板为 0，地图对手机位为 10），保证弹幕压在面板之上又不遮挡地图标记。
        ZIndex = 5;
        SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        _font = CareerVisuals.CreateTheme().DefaultFont ?? new SystemFont { FontNames = ["Microsoft YaHei UI", "Microsoft YaHei"], AllowSystemFallback = true };
        RebuildLanes();
        if (GetParent() is Control parent) parent.Resized += OnParentResized;
    }

    public override void _ExitTree()
    {
        if (GetParent() is Control parent) parent.Resized -= OnParentResized;
        foreach (var item in _items) item.Label.QueueFree();
        foreach (var item in _pool) item.Label.QueueFree();
        _items.Clear(); _pool.Clear();
    }

    /// <summary>应用配置；配置变化会清空等待队列并重建生成范围，但不会打断已在屏的弹幕。</summary>
    public void Apply(DanmakuOptions options)
    {
        _options = (options ?? new DanmakuOptions()).Normalized();
        bool rangeChanged = _options.Lanes != _activeLanes || _lanes.Length == 0;
        RebuildLanes();
        if (rangeChanged) _pending.Clear();
        _layoutDirty = true;
        // 字号与透明度对已在屏的弹幕同样即时生效。
        foreach (var item in _items)
        {
            item.Label.AddThemeFontSizeOverride("font_size", _options.FontSize);
            item.Label.Modulate = new Color(1, 1, 1, _options.Opacity / 100f);
        }
        RefreshPixelBudget();
    }

    /// <summary>
    /// 一次事件连发多条弹幕，用来模拟真人弹幕的刷屏效果。
    /// 每条都走完整的去重与宽度校验，被丢弃的条数记入 <see cref="DroppedTotal"/>。
    /// 真正的上屏节奏由轨道占用情况决定（Emit 每帧按可用轨道消费队列），因此连发会自然错开。
    /// <paramref name="topic"/> 只影响配色分组，传空字符串时按解说色处理。
    /// 返回真正进入队列的条数。
    /// </summary>
    public int Burst(IEnumerable<string> texts, string topic = "")
    {
        if (!_options.Enabled) return 0;
        int queued = 0;
        foreach (string text in texts.Take(_options.FanOut))
        {
            if (string.IsNullOrWhiteSpace(text)) { _dropped++; continue; }
            string cleaned = text.Replace('\r', ' ').Replace('\n', ' ').Trim();
            if (cleaned.Length == 0 || IsDuplicate(cleaned)) { _dropped++; continue; }
            if (!Queue(cleaned, false, topic)) { _dropped++; continue; }
            queued++;
        }
        // 本次连发允许在同一个发射窗口内连续上屏，不必各自等一个间隔。
        if (queued > 0) _burstPending = queued;
        return queued;
    }

    /// <summary>
    /// 投递一条弹幕。返回 false 表示整条没有进入任何队列（关闭、去重命中或原文为空）；
    /// 返回 true 只代表首段已入队，超出同屏上限、轨道拥挤或队列满时仍可能有分段被丢弃，
    /// 具体条数看 <see cref="DroppedTotal"/>。
    /// </summary>
    public bool Spawn(string text, bool analyst = false, string topic = "")
    {
        if (!_options.Enabled || string.IsNullOrWhiteSpace(text)) return false;
        string cleaned = text.Replace('\r', ' ').Replace('\n', ' ').Trim();
        if (cleaned.Length == 0) return false;
        if (!Queue(cleaned, analyst, topic)) return false;
        // 立即尝试一次发射，让单条投递不必等到下一帧；实际节奏仍由生成间距与最低生成数量控制。
        Emit(_now);
        return true;
    }

    private bool Queue(string text, bool analyst, string topic)
    {
        // 单条宽度超过「视口宽 − SpawnGap」会被整条丢弃，因此按当前视口与字号折算一次预算，
        // 避免窄窗口或大字号下切出来的每条都超宽、导致弹幕层整场空白。
        int budget = _options.MaxChars;
        var size = Size;
        if (_pixelBudget > 0) budget = Math.Clamp(Math.Min(budget, _pixelBudget), 4, _options.MaxChars);
        var parts = DanmakuText.Chunks(text, budget);
        if (parts.Count == 0) return false;
        bool accepted = false;
        foreach (string part in parts)
        {
            if (_pending.Count >= 60) { _dropped++; continue; }
            // 入队即记账：多条在同一帧被投递时，若等到发射后才记账，它们会互相看不见彼此而重复上屏。
            if (IsDuplicate(part)) { _dropped++; continue; }
            Remember(part);
            _pending.Enqueue((part, analyst, topic));
            accepted = true;
        }
        return accepted;
    }

    private bool IsDuplicate(string text)
    {
        if (_options.DedupWindow <= 0) return false;
        return _window.ContainsKey(text);
    }

    /// <summary>把一条真正上屏的弹幕计入窗口；窗口按发射条数滑动，而不是按不同文本数。</summary>
    private void Remember(string text)
    {
        if (_options.DedupWindow <= 0) return;
        _window[text] = _window.TryGetValue(text, out int count) ? count + 1 : 1;
        _windowOrder.Enqueue(text);
        while (_windowOrder.Count > _options.DedupWindow)
        {
            string oldest = _windowOrder.Dequeue();
            if (!_window.TryGetValue(oldest, out int remaining)) continue;
            if (remaining <= 1) _window.Remove(oldest);
            else _window[oldest] = remaining - 1;
        }
    }

    public override void _Process(double delta)
    {
        // 自检要等两件事就绪：Apply 已经写入真实配置，父节点布局已经完成（Size.X 有效）。
        // 在 _Ready 里跑会拿到默认字号与 0 宽度，把依赖视口的检查误报为失败。
        if (!_selfTestComplete && Size.X > 200)
        {
            _selfTestComplete = true;
            try { DanmakuSelfTest.Run(_font, _options.FontSize, Size.X); }
            catch (Exception e) { Diagnostics.Error("danmaku.selftest", e); }
        }
        if (_layoutDirty) { _layoutDirty = false; RefreshPixelBudget(); RefreshLanes(); RestorePositions(); }
        _now += delta;
        if (_options.Enabled) Emit(_now);
        var size = Size;
        if (size.X <= 1) return;
        bool freed = false;
        foreach (var item in _items.ToList())
        {
            float step = item.Speed * (float)delta;
            var position = item.Label.Position;
            position.X -= step;
            item.Label.Position = position;
            item.Lifetime += delta;
            if (position.X + item.Width < -RecycleMargin || item.Lifetime > MaximumLifetime)
            {
                _items.Remove(item); Recycle(item); freed = true;
            }
        }
        if (freed) RestorePositions();
    }

    private void Emit(double now)
    {
        var size = Size;
        if (size.X <= 1 || size.Y <= 1) return;
        // 按生成间距节流：两次发射之间至少间隔一段时间；连发的剩余条数不受此限制。
        if (_burstPending <= 0 && now - _lastEmit < _options.EmitIntervalSeconds) return;
        // 不限制单场总量：只有同屏上限与轨道占用决定节奏，重复由去重窗口与冷却控制。
        // 每到生成间隔至少放出 MinPerBurst 条；场上事件不够时向外部索取（通用噪音/广告）补足。
        int target = Math.Max(1, _options.MinPerBurst);
        int burst = 0;
        int guard = 0;
        while (burst < target && _items.Count < _options.MaxOnScreen && guard++ < target + 4)
        {
            if (_pending.Count == 0 && !Fill())
            {
                // 既没有待发内容、也补不到新内容：本轮到手多少算多少，不再空转。
                if (burst == 0) { _starved++; return; }
                break;
            }
            int lane = TakeLane(size.X);
            if (lane < 0) { _dropped++; _droppedLane++; break; }
            var (text, analyst, topic) = _pending.Dequeue();
            float width = DanmakuText.Measure(text, _font, _options.FontSize);
            // 单条宽于可视区时不上屏：这类文本在窄窗口或大字号下会整屏遮挡战场。
            if (width <= 1 || width > size.X - SpawnGap) { _dropped++; _droppedWide++; continue; }
            var item = Rent();
            item.Width = width;
            item.Speed = BaseSpeed * _options.Speed;
            item.Lifetime = 0;
            item.Label.Text = text;
            // 在生成范围内随机高度：轨道位置加一点抖动，避免所有弹幕排成整齐的几行。
            float y = RandomHeight();
            item.Label.Position = new Vector2(size.X + SpawnGap, y);
            item.Label.Modulate = new Color(1, 1, 1, 0);
            item.Label.AddThemeFontSizeOverride("font_size", _options.FontSize);
            item.Label.AddThemeColorOverride("font_color", ColorFor(analyst, topic));
            item.Label.Show();
            var fade = CreateTween();
            fade.TweenProperty(item.Label, "modulate:a", _options.Opacity / 100f, .18);
            _items.Add(item);
            Remember(text);
            _spawned++;
            _lastEmit = now;
            burst++;
            if (_burstPending > 0) _burstPending--;
        }
    }

    /// <summary>
    /// 队列空了时向外部索取一条内容（通用观众噪音或广告），用于凑够「最低同时生成数量」。
    /// 外部来源可能连续给出已被本层去重窗口拦下的句子，因此重试几次再放弃——
    /// 否则一次重复就会让整轮发射提前结束，表现为「弹幕忽然不发了」。
    /// </summary>
    private bool Fill()
    {
        if (TopUp == null) return false;
        for (int attempt = 0; attempt < 4; attempt++)
        {
            if (TopUp() is not { Length: > 0 } text) return false;
            string cleaned = text.Replace('\r', ' ').Replace('\n', ' ').Trim();
            if (cleaned.Length == 0 || IsDuplicate(cleaned)) continue;
            _pending.Enqueue((cleaned, false, "audience_danmaku"));
            return true;
        }
        return false;
    }

    /// <summary>
    /// 选择发射轨道：优先完全空闲的轨道，否则选尾部最靠左（即最不容易追上）的那条。
    /// 连最靠左的轨道都还贴着出生点时才丢弃，避免新弹幕直接压在旧弹幕上。
    /// </summary>
    private int TakeLane(float viewportWidth)
    {
        if (_lanes.Length == 0) return -1;
        var tails = new float[_lanes.Length];
        for (int lane = 0; lane < tails.Length; lane++) tails[lane] = float.MinValue;
        foreach (var item in _items)
        {
            int lane = NearestLane(item.Label.Position.Y);
            float right = item.Label.Position.X + item.Width;
            if (right > tails[lane]) tails[lane] = right;
        }
        int best = -1;
        float bestTail = float.MaxValue;
        for (int lane = 0; lane < tails.Length; lane++)
        {
            if (tails[lane] == float.MinValue) return lane;      // 空轨道优先
            if (tails[lane] < bestTail) { bestTail = tails[lane]; best = lane; }
        }
        if (best < 0) return 0;
        return bestTail < viewportWidth - TightSpawnGap ? best : -1;
    }

    /// <summary>把屏幕纵向的生成范围换算成一组等距的候选高度（像素）。</summary>
    private void RefreshLanes()
    {
        int count = Math.Max(1, _options.Lanes);
        float top = Size.Y * Math.Clamp(_options.RangeTop, 0, 95) / 100f;
        float bottom = Size.Y * Math.Clamp(_options.RangeBottom, 5, 100) / 100f;
        if (bottom - top < LaneHeight) bottom = Math.Min(Size.Y - 4, top + LaneHeight);
        float step = (bottom - top) / count;
        _lanes = new float[count];
        for (int i = 0; i < count; i++) _lanes[i] = top + step * i;
        _activeLanes = count;
        _layoutDirty = true;
    }

    /// <summary>取离给定高度最近的候选高度下标。</summary>
    private int NearestLane(float y)
    {
        int best = 0;
        float distance = float.MaxValue;
        for (int i = 0; i < _lanes.Length; i++)
        {
            float current = Math.Abs(_lanes[i] - y);
            if (current < distance) { distance = current; best = i; }
        }
        return best;
    }

    /// <summary>在生成范围内取一个随机高度，并避开已被占用高度的附近区域。</summary>
    private float RandomHeight()
    {
        if (_lanes.Length == 0) return 0;
        // 先随机挑一个候选高度；若该位置附近已有弹幕，就换一个，最多试 6 次。
        for (int attempt = 0; attempt < 6; attempt++)
        {
            float candidate = _lanes[_random.Next(_lanes.Length)];
            bool crowded = _items.Any(item => Math.Abs(item.Label.Position.Y - candidate) < 10
                && item.Label.Position.X + item.Width > Size.X - SpawnGap * 2.5f);
            if (!crowded) return candidate;
        }
        return _lanes[_random.Next(_lanes.Length)];
    }

    /// <summary>
    /// 外部内容补充：队列空了、又需要凑够「最低同时生成数量」时调用。
    /// 由桥接层接入通用观众噪音与广告，词库层本身不关心内容来源。
    /// </summary>
    public Func<string?>? TopUp { get; set; }

    /// <summary>上次 <see cref="Burst"/> 投递的总条数中，还有多少条允许跳过间隔节流立刻上屏。</summary>
    private int _burstPending;

    /// <summary>
    /// 取弹幕颜色。默认在调色板内随机取色（同一次连发也各自随机），
    /// 少数有语义的话题（对手出局、夺冠、玩家危险）保留固定色以便一眼分辨。
    /// </summary>
    private Color ColorFor(bool analyst, string topic)
    {
        if (_options.RandomColor && topic is not ("rival_dead" or "rival_clear" or "player_champion" or "player_danger"))
            return Palette[_random.Next(Palette.Length)];
        if (topic.StartsWith("audience_") || topic.StartsWith("reply_")) return new Color("8bf0e4");
        if (topic.StartsWith("thought_")) return new Color("c9a6ff");
        if (analyst) return new Color("8fd0ff");
        if (topic is "rival_dead" or "rival_clear" or "player_danger") return new Color("ff8f8f");
        return new Color("ffd45e");
    }

    private Item Rent()
    {
        Item item;
        if (_pool.Count > 0) { item = _pool[^1]; _pool.RemoveAt(_pool.Count - 1); }
        else
        {
            var label = new Label
            {
                MouseFilter = MouseFilterEnum.Ignore,
                ZIndex = 0,
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Center
            };
            // 深色描边保证弹幕压在亮色战斗背景上仍然可读，不额外加面板以免遮挡战场。
            label.AddThemeConstantOverride("outline_size", 8);
            label.AddThemeColorOverride("font_outline_color", new Color(0, 0, 0, .92f));
            label.AddThemeFontOverride("font", _font);
            AddChild(label);
            item = new Item { Label = label };
        }
        return item;
    }

    private void Recycle(Item item)
    {
        item.Label.Hide();
        _pool.Add(item);
    }

    /// <summary>按配置的轨道数占位（仅用于界面预览高度），实际生成高度在 <see cref="RefreshLanes"/> 里按生成范围算。</summary>
    private void RebuildLanes()
    {
        _activeLanes = Math.Max(1, _options.Lanes);
        CustomMinimumSize = new Vector2(0, _activeLanes * LaneHeight);
        RefreshLanes();
    }

    /// <summary>
    /// 按当前视口与字号，把「视口宽 − SpawnGap」折算成单条弹幕允许的显示宽度预算。
    /// 注意单位：<see cref="DanmakuText.Chunks"/> 的预算是「显示宽度」（汉字 = 2），而这里量到的
    /// 是每个汉字的像素数，所以要先换算成「能放下几个汉字」再乘 2，否则弹幕会比预期短一半。
    /// 不这么做的话，窄窗口或大字号下切出来的每条都会在 Emit 里因超宽被丢弃，表现为整场没有弹幕。
    /// </summary>
    private void RefreshPixelBudget()
    {
        _pixelBudget = 0;
        if (_font == null || Size.X <= SpawnGap * 2) return;
        float unit = DanmakuText.Measure("测测测测测测测测", _font, _options.FontSize) / 8f;
        if (unit <= 0) return; // 字体尚未就绪，保持不限预算而不是误判为 0
        int hanzi = Math.Max(2, (int)((Size.X - SpawnGap) * .92f / unit));
        _pixelBudget = hanzi * 2;
    }

    /// <summary>屏幕尺寸或生成范围变化后，把已发射弹幕夹回生成范围内，避免堆在范围外。</summary>
    private void RestorePositions()
    {
        var size = Size;
        if (size.X <= 1 || _lanes.Length == 0) return;
        float top = _lanes[0], bottom = _lanes[^1];
        foreach (var item in _items)
        {
            float y = Mathf.Clamp(item.Label.Position.Y, top, bottom);
            item.Label.Position = new Vector2(Math.Min(item.Label.Position.X, size.X + SpawnGap), y);
        }
    }

    private void OnParentResized() => _layoutDirty = true;
}
