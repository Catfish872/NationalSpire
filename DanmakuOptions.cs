namespace NationalSpire;

/// <summary>
/// 局内弹幕层配置。挂在 <see cref="BroadcastUiState"/> 上随生涯存档持久化，
/// 因此只保存 JSON 可序列化的基础类型；取值在读取时统一收敛。
/// 只影响显示，不参与任何比赛结算或存档数据计算。
/// </summary>
public sealed class DanmakuOptions
{
    /// <summary>总开关；关闭后弹幕层完全不创建节点，也不订阅任何内容。</summary>
    public bool Enabled { get; set; } = true;
    /// <summary>解说通道：解说与现场发言是否飘弹幕。</summary>
    public bool Commentary { get; set; } = true;
    /// <summary>观众通道：串子弹幕库与观众闲聊反应是否飘弹幕。</summary>
    public bool Crowd { get; set; } = true;
    /// <summary>最大同时产生数：同屏同时在飘的弹幕上限。这是唯一的数量护栏——不限制单场总量，重复由去重窗口与冷却控制。</summary>
    public int MaxOnScreen { get; set; } = DefaultMaxOnScreen;
    /// <summary>生成间距：两次发射之间至少间隔多少秒，用来控制整体密度。</summary>
    public int EmitIntervalSeconds { get; set; } = DefaultEmitInterval;
    /// <summary>
    /// 最低同时生成数量：每到生成间隔，一次至少放出这么多条弹幕。
    /// 场上事件不够时由通用观众噪音与广告补足，保证画面不会长时间空着。
    /// </summary>
    public int MinPerBurst { get; set; } = DefaultMinPerBurst;
    /// <summary>滚动速度档位，1 慢 / 2 标准 / 3 快 / 4 极快。</summary>
    public int SpeedLevel { get; set; } = 2;
    /// <summary>弹幕字号。</summary>
    public int FontSize { get; set; } = DefaultFontSize;
    /// <summary>单条弹幕显示宽度上限，超出按标点切成多条连续发射。</summary>
    public int MaxChars { get; set; } = DefaultMaxChars;
    /// <summary>去重窗口：最近多少条内出现过的相同文本不再重复上屏。</summary>
    public int DedupWindow { get; set; } = 120;
    /// <summary>弹幕颜色在调色板内随机取色。</summary>
    public bool RandomColor { get; set; } = true;
    /// <summary>弹幕不透明度百分比（10—100）；数值越低越透，压住画面越少。</summary>
    public int Opacity { get; set; } = 100;
    /// <summary>生成范围上边界：占屏幕高度的百分比，弹幕只会在这条线以下出现。</summary>
    public int RangeTop { get; set; } = 12;
    /// <summary>生成范围下边界：占屏幕高度的百分比，弹幕只会在这条线以上出现。</summary>
    public int RangeBottom { get; set; } = 38;
    /// <summary>
    /// 配置模型版本。低于当前版本的旧档会做一次性升级（改为浓度/速度档位模型，
    /// 并把字号提到当前默认值），避免旧存档里的字号把新默认值压回去。
    /// </summary>
    public int ConfigVersion { get; set; }

    /// <summary>当前配置模型版本。</summary>
    public const int CurrentConfigVersion = 3;
    /// <summary>当前默认值，供默认设置、升级与回落共用。</summary>
    public const int DefaultFontSize = 34, DefaultMaxChars = 64;
    public const int DefaultMaxOnScreen = 40;
    public const int DefaultEmitInterval = 3;
    public const int DefaultMinPerBurst = 1;    /// <summary>旧档升级时把这三个数量参数也拉到当前默认值（用户可从界面随意改）。</summary>
    public const int DefaultLanes = 8;

    public const int MinimumDensity = 1, MaximumDensity = 5;
    public const int MinimumSpeedLevel = 1, MaximumSpeedLevel = 4;    public const int MinimumFontSize = 20, MaximumFontSize = 60;
    public const int MinimumChars = 8, MaximumChars = 200;
    public const int MinimumDedup = 0, MaximumDedup = 600;
    public const int MinimumOnScreen = 1, MaximumOnScreen = 200;
    public const int MinimumEmitInterval = 1, MaximumEmitInterval = 30;
    public const int MinimumMinPerBurst = 1, MaximumMinPerBurst = 10;
    public const int MinimumOpacity = 10, MaximumOpacity = 100;
    public const int MinimumRangeTop = 0, MaximumRangeTop = 90;
    public const int MinimumRangeBottom = 10, MaximumRangeBottom = 100;

    /// <summary>各速度档位的滚动倍率（基准约每秒 190 像素）。</summary>
    public static readonly float[] SpeedPresets = [0.7f, 1f, 1.5f, 2.2f];

    public static string SpeedName(int level) => level switch { 4 => "极快", 3 => "快", 1 => "慢", _ => "标准" };

    /// <summary>轨道数按同屏上限推算：每 4 条同屏配 1 条轨道，最多 14 条，避免弹幕全部挤在少数轨道上。</summary>
    public int Lanes => Math.Clamp((MaxOnScreen + 3) / 4, 2, 14);
    /// <summary>每次事件发射的弹幕条数：生成间距很短时一次来两条，仍受同屏与总量上限约束。</summary>
    public int FanOut => EmitIntervalSeconds <= 2 ? 2 : 1;
    /// <summary>滚动速度倍率。</summary>
    public float Speed => SpeedPresets[Math.Clamp(SpeedLevel, MinimumSpeedLevel, MaximumSpeedLevel) - 1];

    /// <summary>
    /// 把越界或旧版缺失的取值收敛回合法范围；读档后与写入界面时都会调用。
    /// 非正数一律视为「旧档未填写」，回落到默认值而不是最小值。
    /// </summary>
    public DanmakuOptions Normalized()
    {
        // 旧档一次性升级：把字号与数量参数对齐当前默认值，其余用户选择保留。
        if (ConfigVersion < CurrentConfigVersion)
        {
            ConfigVersion = CurrentConfigVersion;
            if (FontSize < DefaultFontSize) FontSize = DefaultFontSize;
            if (MaxChars < DefaultMaxChars) MaxChars = DefaultMaxChars;
            if (MaxOnScreen <= 0) MaxOnScreen = DefaultMaxOnScreen;
            if (EmitIntervalSeconds <= 0) EmitIntervalSeconds = DefaultEmitInterval;
            if (MinPerBurst <= 0) MinPerBurst = DefaultMinPerBurst;
        }
        if (SpeedLevel <= 0) SpeedLevel = 2;
        if (FontSize <= 0) FontSize = DefaultFontSize;
        if (MaxChars <= 0) MaxChars = DefaultMaxChars;
        if (MaxOnScreen <= 0) MaxOnScreen = DefaultMaxOnScreen;
        if (EmitIntervalSeconds <= 0) EmitIntervalSeconds = DefaultEmitInterval;
        if (MinPerBurst <= 0) MinPerBurst = DefaultMinPerBurst;
        SpeedLevel = Math.Clamp(SpeedLevel, MinimumSpeedLevel, MaximumSpeedLevel);
        FontSize = Math.Clamp(FontSize, MinimumFontSize, MaximumFontSize);
        MaxChars = Math.Clamp(MaxChars, MinimumChars, MaximumChars);
        DedupWindow = Math.Clamp(DedupWindow, MinimumDedup, MaximumDedup);
        MaxOnScreen = Math.Clamp(MaxOnScreen, MinimumOnScreen, MaximumOnScreen);
        EmitIntervalSeconds = Math.Clamp(EmitIntervalSeconds, MinimumEmitInterval, MaximumEmitInterval);
        MinPerBurst = Math.Clamp(MinPerBurst, MinimumMinPerBurst, MaximumMinPerBurst);
        if (Opacity <= 0) Opacity = 100;
        Opacity = Math.Clamp(Opacity, MinimumOpacity, MaximumOpacity);
        RangeTop = Math.Clamp(RangeTop, MinimumRangeTop, MaximumRangeTop);
        RangeBottom = Math.Clamp(RangeBottom, MinimumRangeBottom, MaximumRangeBottom);
        // 下边界必须留出至少一条轨道的空间，否则生成范围会退化成一条线。
        if (RangeBottom <= RangeTop) RangeBottom = Math.Min(MaximumRangeBottom, RangeTop + 8);
        return this;
    }
}
