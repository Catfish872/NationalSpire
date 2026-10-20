using System.IO.Compression;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Security.Cryptography;

namespace NationalSpire;

/// <summary>当前套装的基准和差分提示词、模型约束及编号清单；外部模型负责生成图片。</summary>
public static class PortraitPromptExport
{
    public static Dictionary<string, string> Files(PortraitDesign design, string name)
    {
        if (PortraitDesigns.Error(design) is { } error) throw new InvalidDataException(error);
        var outfit = design.Outfits.Single(o => o.Id == design.SelectedOutfit);
        var emotions = design.Emotions.Where(e => e.Enabled).OrderBy(e => e.Id == design.DefaultEmotionId ? 0 : 1).ToArray();
        string key = "character_" + Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(design.PersonId)))[..16].ToLowerInvariant();
        string root = $"sprites/{key}/{outfit.Id}/", neutral = root + design.DefaultEmotionId + ".png";
        string constraints = PortraitModelPrompts.Get(design);
        string identity = $"角色：{name}。\n" + string.Join("\n", PortraitDesigns.BasicFields.Select(f => $"{f.Label}：{design.Basics.GetValueOrDefault(f.Id, "由角色基准图确定")}"))
            + $"\n套装：{outfit.Name}。\n" + string.Join("\n", PortraitDesigns.OutfitFields.Select(f => $"{f.Label}：{outfit.Fields.GetValueOrDefault(f.Id, "")}"));
        string geometry = "画布1024×1536（2:3），单人全身立绘，完整头发、双手与鞋底在画布内。人物轴线约x=512，头顶约y=100，鞋底基线约y=1450。固定镜头距离、视平线、身体比例、整体尺度与鞋底基线，四周预留少量动作空间。服装版型、配色、发型结构和饰品一致。";
        string alpha = "交付单张真正包含Alpha透明通道的RGBA PNG；人物外像素Alpha=0，边缘保留必要的半透明。仅绘制人物立绘；排除背景色块、棋盘格、文字与界面元素。文件名仅用于保存。";
        string master = $"制作视觉小说基准立绘。玩家另行上传的风格图提供线条、上色、光照和细节密度，人物形象遵循下列角色设定。\n本轮只执行一次图像编辑，生成一张结果后立即交付，等待我的反馈。禁止自行追加编辑或继续润色。参考图的画风和完成度已经确认，包括浅色配色、低饱和度、柔和的明暗对比、轻细的轮廓、现有阴影层次及纹理密度。禁止整体重新上色、强化光影、加深描边、增加高光、补充纹理或整理指定区域之外的细节。每张差分都从同一默认基准立绘开始。\n{identity}\n{geometry}\n{constraints}\n{PortraitModelPrompts.Movement}\n平淡表情与动作：{emotions.Single(e => e.Id == design.DefaultEmotionId).Description}\n{alpha}\n输出文件：{neutral}。确认此基准图后开始差分。";
        var files = new Dictionary<string, string>
        {
            ["00-使用说明.md"] = Guide,
            ["01-角色与画风锁定.md"] = identity + "\n\n" + geometry + "\n\n" + constraints,
            ["02-基准立绘.md"] = master,
            ["03-画风校准与差分验收.md"] = ArtDirection,
            ["04-参考图片与上传顺序.md"] = "# 上传顺序\n\n基准：在外部模型中上传自己选择的画风图，主参考在前、辅助参考随后；说明各图仅提供绘制方式，并粘贴02。\n\n差分：在同一对话中重新上传已确认的默认基准立绘PNG，复制expressions.md中所选段落的代码块内容。代码块外的情绪名称、情绪ID与保存文件名供识别和保存时使用。每张独立差分重新使用同一默认基准立绘。参考图片由玩家自行准备。",
            ["05-模型约束.md"] = "# " + design.PromptModel + "\n\n" + constraints,
            ["design.json"] = JsonSerializer.Serialize(new { format = "national-spire-portrait-design", version = 1, characterId = key, name, design.PromptModel, constraints, design.Basics, outfit, emotions }, PortraitDesigns.Json),
            ["models/gpt-image-2.5.json"] = JsonSerializer.Serialize(new { model = "gpt-image-2.5-sunburst", quality = "high", size = "1024x1536", background = "transparent", output_format = "png", n = 1,
                workflow = "有参考图时使用图像编辑；差分每次输入同一基准立绘。参数按实际账号接口配置，下载原图后逐张检验Alpha与一致性。" }, PortraitDesigns.Json),
            ["models/gemini.md"] = "# Gemini / Nano Banana\n\n在所用界面选择可用的图像模型，上传基准立绘和参考图，粘贴本轮差分提示。统一2:3构图；将最终图片等比缩放并填充为1024×1536透明PNG。逐张检查Alpha、人物比例和脚底基线。模型版本及API参数以所用渠道为准。"
        };
        var expressions = new StringBuilder("# 情绪差分提示词\n\n默认基准立绘使用02-基准立绘.md。下列差分按本次导出的启用顺序从1编号，每次复制一个代码块的完整内容。情绪名称、ID与保存文件名位于代码块外，供识别和保存。\n\n");
        int number = 0;
        foreach (var emotion in emotions.Where(e => e.Id != design.DefaultEmotionId))
        {
            number++;
            string prompt = $"现在开始生成第（{number}）个差分。\n严格在默认基准立绘上修改角色的表情差分。你只需要修改表情和动作姿态，不需要修改任何其他内容，包括服饰，画面尺寸，背景透明通道。\n表情与动作：{emotion.Description}\n\n按上述表情和动作调整相应部位，保持其余已确认细节、光影、上色和低噪质感。每张独立差分重新使用同一默认立绘。\n\n{alpha}";
            string fence = "```";
            while (prompt.Contains(fence, StringComparison.Ordinal)) fence += "`";
            expressions.Append($"## {number}. {emotion.Name.Replace('\r', ' ').Replace('\n', ' ')}\n\n情绪ID：`{emotion.Id}` · 保存文件：`{emotion.Id}.png`\n\n{fence}text\n{prompt}\n{fence}\n\n\n");
        }
        if (number == 0) expressions.Append("本次仅启用默认基准立绘，使用02-基准立绘.md生成即可。\n");
        files["expressions.md"] = expressions.ToString();
        files["manifest.json"] = JsonSerializer.Serialize(new
        {
            format = "national-spire-portrait-prompts", version = 1, characterId = key, outfitId = outfit.Id,
            target = new { width = 1024, height = 1536, format = "PNG", mode = "RGBA", centerX = 512, headY = 100, feetY = 1450 },
            fallbackEmotionId = design.DefaultEmotionId, reference = neutral,
            sprites = emotions.Select(e => new { emotionId = e.Id, label = e.Name, file = root + e.Id + ".png", prompt = e.Id == design.DefaultEmotionId ? "02-基准立绘.md" : "expressions.md", reference = e.Id == design.DefaultEmotionId ? "" : neutral }),
            validation = new[] { "编号、文件名和情绪逐项对应", "RGBA PNG具有真实透明像素", "统一画布、人物尺度及鞋底基线", "五官、服饰、发型、光影、上色及纹理密度与基准一致", "表情与克制动作符合角色性格" }
        }, PortraitDesigns.Json);
        foreach (string file in files.Keys.Where(k => k.EndsWith(".json", StringComparison.Ordinal)).ToArray())
        {
            var json = JsonNode.Parse(files[file])!; RemoveEmpty(json); files[file] = json.ToJsonString(PortraitDesigns.Json);
        }
        return files;
    }
    private static void RemoveEmpty(JsonNode node)
    {
        if (node is JsonObject obj)
            foreach (var (key, value) in obj.ToArray())
            {
                if (value == null || value is JsonValue scalar && scalar.TryGetValue<string>(out var text) && string.IsNullOrWhiteSpace(text)) obj.Remove(key);
                else RemoveEmpty(value);
            }
        else if (node is JsonArray array) foreach (var value in array) if (value != null) RemoveEmpty(value);
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
        # 立绘提示词包

        当前套装及已启用情绪的提示词、约束和编号清单在本包中。参考图和画风要求请在外部模型中上传。
        1. 阅读01和05，在外部模型中上传风格参考，复制02生成平淡基准。确认五官、服装、光影、噪点和真实透明背景。
        2. 在同一对话中，每次重新上传同一默认基准立绘，复制expressions.md中一个代码块的完整内容。差分序号从1连续编号；代码块外的情绪名称和ID供识别，文件名用于保存。等待完成、验收后再发送下一项。
        3. 局部修正时明确改动区域和保留区域。新情绪的生成继续回到默认立绘。
        4. 下载原始PNG，检查Alpha通道以及深色、浅色底上的边缘。实色底图需抠图并修整边缘。
        5. 按情绪ID保存PNG；同情绪的多张图片可以命名proud_1.png、proud_2.png。默认差分为必需项（初始ID为neutral）。PNG直接压成ZIP即可在“立绘与场景”导入；manifest为可选兼容清单。

        包内提示词无法保证外部模型每次的最终质量。保持固定基准、逐项局部编辑和逐图验收；严格像素一致的部位可使用分层素材复用。
        GPT Image 2.5的示例API设置见models目录，网页端选择可用模型并要求透明PNG。Gemini需实测Alpha并统一画布。参数以当前所用接口支持为准。
        本包只包含设计与提示词。角色资料连同全部立绘的交换请使用“导出角色设计”。
        官方图像输出说明：https://developers.openai.com/api/docs/guides/image-prompting
        """;
    private const string ArtDirection = """
        # 校准与验收

        在“画风调试与噪点控制”选择模型，并按实际结果微调约束。每种模型的编辑内容分别保存。
        先确认默认立绘，特别检查肤色、二维光照、发束方向、饰品数量、边角纹理和Alpha。
        以同一基准制作平淡、开心、沮丧、嫌弃四张，检查五官与衣着的一致性、微表情可读性和姿态幅度。
        参考图只约束绘制语言；角色设计与默认立绘决定身份、服饰和比例。每轮明确图片用途与上传顺序。
        局部修正可以只改变嘴形、眼睛或手势；把其他区域的光影、上色、噪点密度和透明度列入保留项。
        约束文字表达审美要求，实际去噪强度由外部模型或后期工具决定。放大检查边缘，再以游戏内尺寸判断细节密度。
        """;
}
