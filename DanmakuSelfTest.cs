using Godot;

namespace NationalSpire;

/// <summary>
/// 弹幕层自检。Godot 的字体 API 必须在引擎进程内使用（托管类型在独立进程会崩在原生初始化），
/// 因此这里在局内层挂载时用真实字体跑一次度量检查，把结果写进模组诊断日志。
/// 只读、无副作用，不改变任何配置或存档；失败只记录并告警，不阻断比赛。
/// </summary>
public static class DanmakuSelfTest
{
    /// <summary>按当前实际字号与视口宽度校验度量、折行与切分；返回失败项数量。</summary>
    public static int Run(Font font, int fontSize, float viewportWidth)
    {
        var failed = new List<string>();
        var samples = new List<object>();

        void Check(string name, bool ok, string detail)
        {
            if (!ok) failed.Add($"{name}: {detail}");
            samples.Add(new { name, ok, detail });
        }

        float Measure(string text) => DanmakuText.Measure(text, font, fontSize);

        // 1. 基础度量：空值、纯中文、中英混排、emoji、真实解说署名文本。
        Check("空串为 0", Measure("") == 0, $"{Measure("")}");
        Check("null 为 0", Measure(null!) == 0, $"{Measure(null!)}");
        float han = Measure("我说伤害特别高");
        Check("中文宽度为正", han > 0, $"{han:0.##}px / 7 字 = {han / 7:0.##}px 每字");
        float ascii = Measure("boss 12");
        Check("英文数字宽度为正", ascii > 0, $"{ascii:0.##}px / 7 字 = {ascii / 7:0.##}px 每字");
        float emoji = Measure("我已启动🚀");
        float plain = Measure("我已启动");
        Check("emoji 可测量", emoji > 0, $"{emoji:0.##}px");
        // 界面字体是 MSDF 子集字体、没有系统回退；若缺 emoji 字形，HarfBuzz 可能给 0 宽度。
        // 这里把实测差值记进日志，供判断该字体是否需要为 emoji 补回退。
        bool emojiCounted = emoji - plain > fontSize * .5f;
        samples.Add(new { name = "emoji 字形宽度", ok = emojiCounted, detail = $"emoji={emoji:0.##}px 纯文本={plain:0.##}px 差值={emoji - plain:0.##}px 字号={fontSize}" });
        if (!emojiCounted)
            GD.PushWarning($"[NationalSpire] 弹幕字体可能缺少 emoji 字形：含 emoji 的弹幕会被低估宽度（{emoji:0.##} vs {plain:0.##}）。");
        float byline = Measure("闻笙 · 解说：这场比赛赢了，用时三分二十秒");
        Check("真实署名文本可测量", byline > 0, $"{byline:0.##}px");

        // 2. 折行：内容守恒且不产生空串，是渲染层唯一的正确性依赖。
        string longText = new string('测', 60) + "这是一条很长的解说文本用于验证折行";
        var lines = DanmakuText.Split(longText, font, fontSize, 320f);
        Check("折行至少一行", lines.Count >= 1, $"{lines.Count} 行");
        Check("折行无空串", lines.All(line => !string.IsNullOrEmpty(line)), "");
        Check("折行内容守恒", string.Concat(lines) == longText, $"{string.Concat(lines).Length}/{longText.Length}");
        Check("折行不超宽", lines.All(line => Measure(line) <= 321f),
            string.Join("|", lines.Select(line => $"{Measure(line):0.#}")));
        var narrow = DanmakuText.Split("测试", font, fontSize, 1f);
        Check("极窄宽度不空转", narrow.Count >= 1 && narrow.All(line => !string.IsNullOrEmpty(line)), $"{narrow.Count} 行");

        // 3. 切分：超长文本必须能被切成多条，且不丢失内容。
        string noPunctuation = new string('哈', 200);
        var chunks = DanmakuText.Chunks(noPunctuation, 40);
        Check("200 字可切分", chunks.Count >= 5, $"{chunks.Count} 条");
        Check("切分不超上限", chunks.All(chunk => chunk.Length <= 40), string.Join(",", chunks.Select(chunk => chunk.Length)));
        Check("切分无空串", chunks.All(chunk => !string.IsNullOrWhiteSpace(chunk)), "");
        Check("切分内容守恒", string.Concat(chunks) == noPunctuation, $"{string.Concat(chunks).Length}/200");
        var punctuated = DanmakuText.Chunks("第一条弹幕，第二条弹幕！第三条弹幕？第四条弹幕", 8);
        Check("带标点优先断开", punctuated.Count >= 2 && punctuated.All(chunk => chunk.Length <= 8), string.Join("|", punctuated));
        Check("短文本不切分", DanmakuText.Chunks("短", 40) is { Count: 1 } single && single[0] == "短", "");
        Check("上限为 0 不抛异常", DanmakuText.Chunks("测试文本", 0).Count >= 1, "");

        // 4. 上屏可行性：按当前视口宽度判断样本能否整条显示（渲染层同口径）。
        // 层在 _Ready 里自检时父节点可能还没完成布局，Size.X 为 0，此时跳过而不是记成失败。
        if (viewportWidth > 200)
        {
            var visible = new List<string>();
            var hidden = new List<string>();
            foreach (string text in new[] { "老霸道了", "我说{card}伤害特别高", "考虑攻杀大怪，先动大的会不会好一点呢？", "我已启动🚀" })
            {
                float width = Measure(text);
                bool onScreen = width > 1 && width <= viewportWidth - 90;
                (onScreen ? visible : hidden).Add($"{text}({width:0.#}px)");
            }
            Check("样本中存在可上屏文本", visible.Count > 0, string.Join(" / ", visible));
            Check("无过宽样本挤压画面", hidden.Count == 0, hidden.Count == 0 ? "" : string.Join(" / ", hidden));
        }
        else
        {
            samples.Add(new { name = "上屏可行性", ok = true, detail = $"视口宽度 {viewportWidth:0.#}px 尚未布局，本次跳过" });
        }

        Diagnostics.Record("danmaku.selftest", new
        {
            font = font.GetType().Name,
            fontSize,
            viewportWidth,
            passed = samples.Count - failed.Count,
            failed = failed.Count,
            failures = failed,
            samples,
            chunkSample = chunks.Take(3).ToList(),
            // 选词随机性：抽 30 次看覆盖了多少条、有没有连着重复，用来说明「不是按顺序发」。
            randomness = SituationDanmaku.RandomnessReport("hurt", 30)
        });
        if (failed.Count > 0)
            GD.PushWarning($"[NationalSpire] 弹幕自检有 {failed.Count} 项未通过：{string.Join("；", failed)}");
        return failed.Count;
    }
}
