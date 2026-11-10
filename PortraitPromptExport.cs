using System.IO.Compression;
using System.Text;

namespace NationalSpire;

/// <summary>当前套装的基准、差分和简明使用说明；外部模型负责生成图片。</summary>
public static class PortraitPromptExport
{
    public static Dictionary<string, string> Files(PortraitDesign design, string name)
    {
        if (PortraitDesigns.Error(design) is { } error) throw new InvalidDataException(error);
        var outfit = design.Outfits.Single(o => o.Id == design.SelectedOutfit);
        var emotions = design.Emotions.Where(e => e.Enabled).OrderBy(e => e.Id == design.DefaultEmotionId ? 0 : 1).ToArray();
        string neutral = design.DefaultEmotionId + ".png";
        string constraints = PortraitModelPrompts.Get(design);
        string identity = $"角色：{name}。\n" + string.Join("\n", PortraitDesigns.BasicFields.Where(f => !string.IsNullOrWhiteSpace(design.Basics.GetValueOrDefault(f.Id))).Select(f => $"{f.Label}：{design.Basics.GetValueOrDefault(f.Id, "由角色基准图确定")}"))
            + $"\n套装：{outfit.Name}。\n" + string.Join("\n", PortraitDesigns.OutfitFields.Where(f => !string.IsNullOrWhiteSpace(outfit.Fields.GetValueOrDefault(f.Id))).Select(f => $"{f.Label}：{outfit.Fields.GetValueOrDefault(f.Id, "")}"));
        string geometry = "画布1024×1536（2:3），单人全身立绘，完整头发、双手与鞋底在画布内。人物轴线约x=512，头顶约y=100，鞋底基线约y=1450。固定镜头距离、视平线、身体比例、整体尺度与鞋底基线，四周预留少量动作空间。服装版型、配色、发型结构和饰品一致。";
        string alpha = "交付单张真正包含Alpha透明通道的RGBA PNG；人物外像素Alpha=0，边缘保留必要的半透明。仅绘制人物立绘；排除背景色块、棋盘格、文字与界面元素。文件名仅用于保存。";
        string master = $"制作视觉小说基准立绘。玩家另行上传的风格图提供线条、上色、光照和细节密度，人物形象遵循下列角色设定。\n本轮只执行一次图像编辑，生成一张结果后立即交付，等待我的反馈。禁止自行追加编辑或继续润色。参考图的画风和完成度已经确认，包括浅色配色、低饱和度、柔和的明暗对比、轻细的轮廓、现有阴影层次及纹理密度。禁止整体重新上色、强化光影、加深描边、增加高光、补充纹理或整理指定区域之外的细节。每张差分都从同一默认基准立绘开始。\n{identity}\n{geometry}\n{constraints}\n{PortraitModelPrompts.Movement}\n平淡表情与动作：{emotions.Single(e => e.Id == design.DefaultEmotionId).Description}\n{alpha}\n输出文件：{neutral}。确认此基准图后开始差分。";
        var files = new Dictionary<string, string>
        {
            ["基准立绘提示词.md"] = master,
            ["使用说明.md"] = Guide.Replace("{defaultFile}", neutral)
        };
        var expressions = new StringBuilder("# 情绪差分提示词\n\n默认基准立绘使用基准立绘提示词.md。下列差分按本次导出的启用顺序从1编号，每次复制一个代码块的完整内容。情绪名称、ID与保存文件名位于代码块外，供识别和保存。\n\n");
        int number = 0;
        foreach (var emotion in emotions.Where(e => e.Id != design.DefaultEmotionId))
        {
            number++;
            string prompt = $"现在开始生成第（{number}）个差分。\n严格在默认基准立绘上修改角色的表情差分。你只需要修改表情和动作姿态，不需要修改任何其他内容，包括服饰，画面尺寸，背景透明通道。\n表情与动作：{emotion.Description}\n\n按上述表情和动作调整相应部位，保持其余已确认细节、光影、上色和低噪质感。每张独立差分重新使用同一默认立绘。\n\n{alpha}";
            string fence = "```";
            while (prompt.Contains(fence, StringComparison.Ordinal)) fence += "`";
            expressions.Append($"## {number}. {emotion.Name.Replace('\r', ' ').Replace('\n', ' ')}\n\n情绪ID：`{emotion.Id}` · 保存文件：`{emotion.Id}.png`\n\n{fence}text\n{prompt}\n{fence}\n\n\n");
        }
        if (number == 0) expressions.Append("本次仅启用默认基准立绘，使用基准立绘提示词.md生成即可。\n");
        files["表情差分提示词.md"] = expressions.ToString();
        return files;
    }
    public static string Write(string directory, PortraitDesign design, string name)
    {
        var files = Files(design, name); Directory.CreateDirectory(directory);
        string safe = string.Concat(name.Select(c => Path.GetInvalidFileNameChars().Contains(c) ? '_' : c)); safe = safe.Length > 36 ? safe[..36] : safe;
        string path = Path.Combine(directory, "国运尖塔-立绘-" + safe + "-" + DateTime.Now.ToString("yyyyMMdd-HHmmssfff") + "-" + Guid.NewGuid().ToString("N")[..6] + ".zip"), temporary = path + ".tmp";
        try
        {
            using (var archive = ZipFile.Open(temporary, ZipArchiveMode.Create))
                foreach (var file in files) { using var writer = new StreamWriter(archive.CreateEntry(file.Key, CompressionLevel.Optimal).Open(), new UTF8Encoding(false)); writer.Write(file.Value); }
            File.Move(temporary, path); return path;
        }
        finally { if (File.Exists(temporary)) File.Delete(temporary); }
    }
    private const string Guide = """
        # 使用说明

        1. 先生成默认立绘：打开“基准立绘提示词.md”，复制全部内容，发给你使用的生图 AI。有画风参考图时，一起上传。满意后下载 PNG 原图，保存为 `{defaultFile}`。
        2. 再生成其他表情：打开“表情差分提示词.md”，每次复制一个框里的完整提示词。在同一对话中重新上传刚才满意的默认立绘，再发送这段提示词。每张都从同一张默认立绘开始。
        3. 保存图片：按每段上方写的文件名保存，例如 `happy.png`。检查人物完整、服装一致、背景确实透明；如果背景仍是一整块颜色，请让生图 AI 修改后重新下载。
        4. 导入游戏：把默认立绘和其他表情的 PNG 放在一起，压缩成 ZIP。在该角色的“立绘与场景”中点击导入立绘包，选择这个 ZIP。

        同一个表情有多张图时，可保存为 `happy_1.png`、`happy_2.png`，游戏会随机选用。默认立绘请保留上面指定的文件名。

        这三个文档用于生成图片。图片完成后再打包导入游戏；整个角色连同图片的分享，请使用游戏里的“导出角色设计”。
        """;
}
