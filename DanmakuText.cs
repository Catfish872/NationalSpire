using System.Globalization;
using System.Text;
using Godot;

namespace NationalSpire;

/// <summary>
/// 弹幕文本工具（纯静态、无副作用、可重复调用）：
/// 1. 单行像素宽度测量（Measure）；
/// 2. 按像素宽度折行（Split，供多行弹幕排版）；
/// 3. 按显示宽度把超长弹幕切成多条独立弹幕（Chunks）。
///
/// 设计约束：
/// - 字体实例一律由调用方传入，本类不缓存字体、不访问场景树、不持有任何静态可变状态；
/// - 线程约束：Measure（以及内部逐行调用它的 Split）会经 Font.GetStringSize 进入 Godot TextServer，
///   必须在 Godot 主线程调用；Chunks 与 DisplayWidth 是纯托管实现（只用 System.Globalization 与自带宽度表），
///   可在任意线程调用。后续若要把调用点挪到后台线程，只能挪 Chunks / DisplayWidth；
/// - 测量完全交给传入的 Font（Font.GetStringSize），不做任何字宽估算；
/// - maxWidth 不大于 0、maxChars 不大于 0 时按 1 处理，不抛异常、不死循环。
///
/// 已知限制（调用方须知）：
/// - font 为 null 或已被释放时无法测量，Measure 返回 0（Split 会退化成整段一行），绝不抛异常；
/// - Split 会丢弃「行首空白」（仅当该行后面还有实际内容），因此把返回的各行拼回去可能比原文少几个空白字符；
/// - 极窄 maxWidth 下每个字素簇独占一行；
/// - maxChars 为 1 且遇到全角字或 emoji（显示宽度 2）时，单条仍会超过 maxChars——单个字符无法再拆。
/// </summary>
public static class DanmakuText
{
    /// <summary>约定的断点标点集合：中英文标点、半角空格与全角空格（U+3000）。</summary>
    private const string BreakChars = "，。！？；：、,.!?;: \u3000";

    /// <summary>
    /// 测量「单行」像素宽度。text 为 null 或空串返回 0；不做任何折行或按行累加。
    /// 实现：width 参数传 -1，Godot 不触发自动换行，返回的就是整条文本单行排布时的宽度，
    /// 调用方可以直接拿它和可视区宽度比较（宽于可视区的弹幕可整条丢弃）。
    /// 注意：若文本自带换行符，其度量行为由 Godot TextServer 决定，本方法不额外处理。
    /// 线程：本方法会进入 Godot TextServer（非线程安全），必须在 Godot 主线程调用。
    /// </summary>
    public static float Measure(string text, Font font, int fontSize)
    {
        if (string.IsNullOrEmpty(text)) return 0f;
        if (font is null || !GodotObject.IsInstanceValid(font)) return 0f;
        int size = fontSize > 0 ? fontSize : 1;
        Vector2 box = font.GetStringSize(text, HorizontalAlignment.Left, -1f, size);
        float width = box.X;
        // 防御异常返回值：NaN/无穷/负数一律按 0 处理，避免污染调用方的排版计算。
        return float.IsNaN(width) || float.IsInfinity(width) || width < 0f ? 0f : width;
    }

    /// <summary>
    /// 按最大像素宽度折行，返回至少一条。
    ///
    /// 折行策略：先用强制换行符（\n、\r\n）把文本拆成段，段内做贪心累加——
    /// 逐个字素簇（grapheme cluster）追加，只要「已累计内容 + 下一个字素簇」的实测像素宽度不超过 maxWidth 就继续，
    /// 一旦超宽就在当前字素簇之前断开。断点只落在字素簇边界，emoji、代理对、组合音标不会被劈成两半。
    /// 第一个字素簇无条件放入新行（即使它自身就比 maxWidth 宽，也独占一行），因此循环一定前进，不会死循环。
    ///
    /// 返回值保证：至少一条；除「text 为 null/空串」或「text 只由换行符组成」两种退化情况会返回单条空串外，
    /// 不会出现空串。纯空白段（例如作者故意留的空行）会保留为一条空白串，不会被写成空串。
    ///
    /// maxWidth 不大于 0 时按 1 处理。
    /// 线程：内部逐行调用 Measure，会进入 Godot TextServer（非线程安全），必须在 Godot 主线程调用。
    /// </summary>
    public static List<string> Split(string text, Font font, int fontSize, float maxWidth)
    {
        var lines = new List<string>();
        if (string.IsNullOrEmpty(text))
        {
            lines.Add(string.Empty); // 退化输入：仍然给调用方一条，避免它去处理空列表
            return lines;
        }

        int size = fontSize > 0 ? fontSize : 1;
        float limit = maxWidth > 0f ? maxWidth : 1f;

        foreach (string segment in Segments(text))
        {
            if (segment.Length == 0) continue; // 连续换行产生的空段直接丢弃，不产生空行
            WrapSegment(segment, font, size, limit, lines);
        }

        if (lines.Count == 0) lines.Add(string.Empty); // 输入只有换行符时的兜底
        return lines;
    }

    /// <summary>
    /// 按「显示宽度」把超长弹幕切成多条独立弹幕。maxChars 是显示宽度预算（半角字符 = 1，全角/emoji = 2，
    /// 可用 DisplayWidth 得到同口径宽度），不是 UTF-16 长度。
    ///
    /// 切分策略：
    /// 1. 贪心往前吃字素簇，直到再加一个就超过 maxChars；
    /// 2. 若后面还有内容，则退回到窗口内「最后一个断点之后」再切——断点 = 约定标点、空格或任意空白字符，
    ///    这样标点会留在前一条末尾，读起来不断句；
    /// 3. 窗口内一个断点都没有（例如 200 字无标点长句）时按宽度硬切；
    /// 4. 单个字素簇自身就超过预算时（如 maxChars 为 1 遇到全角字）它独占一条，保证前进。
    /// 每条结果都会去掉首尾空白，纯空白片段直接丢弃，因此返回值里不会出现空串或只有空白的串。
    ///
    /// maxChars 不大于 0 时按 1 处理。text 为 null、空串或纯空白时返回空列表（没有可发的弹幕）。
    /// 若剩余内容整体放得下，就不再按断点拆开——能一条发完的绝不拆成两条。
    /// </summary>
    public static List<string> Chunks(string text, int maxChars)
    {
        var chunks = new List<string>();
        if (string.IsNullOrEmpty(text)) return chunks;

        int limit = maxChars > 0 ? maxChars : 1;
        List<Element> elements = TextElements(text);

        int index = 0;
        while (index < elements.Count)
        {
            int width = 0, end = index, lastBreak = -1;
            while (end < elements.Count && width + elements[end].Width <= limit)
            {
                width += elements[end].Width;
                if (IsBreakPoint(elements[end].Text)) lastBreak = end; // 该字素簇之后可作为断点
                end++;
            }

            if (end == index)
            {
                end = index + 1; // 单字素簇即超预算：独占一条
            }
            else if (end < elements.Count && lastBreak >= index)
            {
                end = lastBreak + 1; // 后面还有内容：优先在最后一个标点/空白之后断开
            }

            string chunk = Slice(text, elements, index, end).Trim();
            if (chunk.Length > 0) chunks.Add(chunk); // 纯空白片段直接丢弃
            index = end;
        }

        return chunks;
    }

    /// <summary>
    /// 辅助接口：按显示宽度统计文本相当于多少个半角字符。
    /// CJK/全角/emoji 记 2，ASCII 记 1，组合符号与零宽字符记 0（emoji 组合、国旗整体按一个字宽计，不叠加内部码位）。
    /// Chunks 的 maxChars 就是这个口径；像素宽度请改用 Measure。
    /// </summary>
    public static int DisplayWidth(string text)
    {
        if (string.IsNullOrEmpty(text)) return 0;
        int total = 0;
        foreach (Element element in TextElements(text)) total += element.Width;
        return total;
    }

    /// <summary>段内折行：贪心累加字素簇，行首空白不占位。</summary>
    private static void WrapSegment(string segment, Font font, int fontSize, float limit, List<string> lines)
    {
        List<Element> elements = TextElements(segment);
        int index = 0;
        while (index < elements.Count)
        {
            // 行首空白不占位：跳过它，但仅当本行后面确实还有非空白内容，否则整段空白会被整行吞掉。
            int firstContent = index;
            while (firstContent < elements.Count && string.IsNullOrWhiteSpace(elements[firstContent].Text)) firstContent++;
            if (firstContent < elements.Count) index = firstContent;

            // 第一个字素簇无条件放入：既保证单个超宽字素簇能独占一行，也保证 index 必然前进。
            var line = new StringBuilder();
            line.Append(elements[index].Text);
            index++;

            while (index < elements.Count)
            {
                string candidate = line.ToString() + elements[index].Text;
                if (Measure(candidate, font, fontSize) > limit) break; // 超宽：下一个字素簇留给下一行
                line.Append(elements[index].Text);
                index++;
            }

            lines.Add(line.ToString());
        }
    }

    /// <summary>按强制换行符拆段（\r\n、\n、\r 均视为一个换行）。</summary>
    private static IEnumerable<string> Segments(string text)
    {
        int start = 0;
        for (int i = 0; i < text.Length; i++)
        {
            char c = text[i];
            if (c != '\n' && c != '\r') continue;
            yield return text.Substring(start, i - start);
            if (c == '\r' && i + 1 < text.Length && text[i + 1] == '\n') i++;
            start = i + 1;
        }
        yield return text.Substring(start);
    }

    /// <summary>该字素簇之后是否适合断开：约定的标点、全角空格，或任意空白字符。</summary>
    private static bool IsBreakPoint(string element)
    {
        if (element.Length == 0) return false;
        char last = element[element.Length - 1];
        return BreakChars.Contains(last) || char.IsWhiteSpace(last);
    }

    /// <summary>用元素下标区间还原原文切片。</summary>
    private static string Slice(string text, List<Element> elements, int from, int toExclusive)
    {
        Element first = elements[from];
        Element last = elements[toExclusive - 1];
        return text.Substring(first.Start, last.Start + last.Text.Length - first.Start);
    }

    /// <summary>按字素簇切分文本（emoji 组合、代理对、组合音标都保持完整），并记录起始下标与显示宽度。</summary>
    private static List<Element> TextElements(string text)
    {
        var elements = new List<Element>(text.Length);
        TextElementEnumerator walker = StringInfo.GetTextElementEnumerator(text);
        while (walker.MoveNext())
        {
            string element = walker.GetTextElement();
            elements.Add(new Element(element, walker.ElementIndex, WidthOfElement(element)));
        }
        return elements;
    }

    /// <summary>单个字素簇的显示宽度：含全角/emoji 记 2，否则含可见字符记 1，全为组合符/零宽字符记 0。</summary>
    private static int WidthOfElement(string element)
    {
        bool wide = false, narrow = false;
        foreach (Rune rune in element.EnumerateRunes())
        {
            if (IsZeroWidth(rune)) continue;
            if (IsWideCodePoint(rune.Value)) wide = true;
            else narrow = true;
        }
        if (wide) return 2; // 一个显示单元整体按一个字宽计，不把内部码位简单相加
        return narrow ? 1 : 0;
    }

    /// <summary>组合符号、变体选择符、零宽字符、控制字符等不占位。</summary>
    private static bool IsZeroWidth(Rune rune)
    {
        int value = rune.Value;
        if (value is >= 0x200B and <= 0x200F or 0x2028 or 0x2029 or 0xFEFF) return true; // 零宽空格/方向标记/分隔符/零宽不换行空格
        if (value is >= 0xFE00 and <= 0xFE0F or >= 0xE0100 and <= 0xE01EF) return true;  // 变体选择符
        if (value is >= 0x1160 and <= 0x11FF) return true;                                // 韩文母音/终声，与前一字母合体
        return Rune.GetUnicodeCategory(rune) is UnicodeCategory.NonSpacingMark or UnicodeCategory.EnclosingMark
            or UnicodeCategory.Format or UnicodeCategory.Control
            or UnicodeCategory.LineSeparator or UnicodeCategory.ParagraphSeparator;
    }

    /// <summary>East Asian Wide / Fullwidth 的常用区段（近似实现，够弹幕分条使用）。</summary>
    private static bool IsWideCodePoint(int value) => value switch
    {
        >= 0x1100 and <= 0x115F => true,   // 韩文字母
        >= 0x2E80 and <= 0x303E => true,   // CJK 部首、康熙部首、日文标点、CJK 符号（含 U+3000 全角空格）
        >= 0x3041 and <= 0x33FF => true,   // 假名、注音、韩文兼容字母、带圈 CJK
        >= 0x3400 and <= 0x4DBF => true,   // CJK 扩展 A
        >= 0x4E00 and <= 0x9FFF => true,   // CJK 统一表意文字
        >= 0xA000 and <= 0xA4CF => true,   // 彝文
        >= 0xA960 and <= 0xA97F => true,   // 韩文字母扩展 A
        >= 0xAC00 and <= 0xD7A3 => true,   // 韩文音节
        >= 0xF900 and <= 0xFAFF => true,   // CJK 兼容表意文字
        >= 0xFE10 and <= 0xFE19 => true,   // 竖排标点
        >= 0xFE30 and <= 0xFE6F => true,   // CJK 兼容形式、小写变体
        >= 0xFF01 and <= 0xFF60 => true,   // 全角 ASCII 与全角片假名
        >= 0xFFE0 and <= 0xFFE6 => true,   // 全角货币/符号
        >= 0x1B000 and <= 0x1B2FF => true, // 假名补充
        >= 0x1F1E6 and <= 0x1F1FF => true, // 区域指示符（国旗）
        >= 0x1F200 and <= 0x1F2FF => true, // 带圈 CJK 补充
        >= 0x1F300 and <= 0x1FAFF => true, // 常用 emoji 区段（含 🚀 U+1F680）
        >= 0x20000 and <= 0x3FFFD => true, // CJK 扩展 B 及以后
        _ => false
    };

    /// <summary>字素簇及其在原文中的起始下标与显示宽度。</summary>
    private readonly struct Element
    {
        public Element(string text, int start, int width)
        {
            Text = text;
            Start = start;
            Width = width;
        }

        public readonly string Text;
        public readonly int Start;
        public readonly int Width;
    }
}
