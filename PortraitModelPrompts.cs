namespace NationalSpire;

/// <summary>外部绘图模型的可编辑约束模板；绘制参考由玩家在外部模型中上传。</summary>
public static class PortraitModelPrompts
{
    public static readonly (string Id, string Name)[] Models = [("gpt-image-2.5", "GPT Image 2.5"), ("gemini", "Gemini / Nano Banana"), ("custom", "通用 / 自定义")];
    public const string Movement = "以角色日常站姿为基础。情绪主要通过眉眼、瞳孔、嘴角、头的轻微倾斜和简单手部动作表达，角色已有的耳、尾等器官可自然变化。强烈情绪才使用较大幅度的全身动作。按本项具体动作处理所需部位，保留其余已确认的姿态。";
    public const string Common = """
        二维手绘视觉小说立绘，线条清楚，内部线条疏密有层次，面部为视觉中心。
        平整干净的底色、清晰的主要阴影和少量柔和过渡；保持哑光肤色与布料质感。
        主色中低饱和，强调色集中于少量关键部位。头发按束归纳，发梢沿自然方向收束。
        衣褶沿受力方向组织，饰品数量与设定一致，边角细节密度服从主轮廓。
        控制油亮涂抹、塑料感、摄影棚式体积光、过量轮廓高光、杂乱碎发和无依据的装饰纹理。
        交付单张RGBA PNG，人物外像素Alpha=0，边缘保留必要的半透明。检查实际Alpha通道。
        """;
    public static string Default(string model) => Common + "\n\n" + (model switch
    {
        "gpt-image-2.5" => """
            GPT Image 2.5 编辑约束：每张差分重新上传同一张已确认默认立绘作为编辑输入。
            锁定角色脸型、五官比例、发型结构、服饰及辨识特征，维持基准图的光影方向、上色方法、色板和低噪质感。
            保持基准图中已经确认的必要纹理与细节密度，减少新生的颗粒、密集细碎花纹与过度锐化边缘。
            每轮明确本次允许改动的部位，其余部位保持基准外观。例如仅修正嘴部时，保留原本的眼睛、脸型、头发、服饰、光影、上色和透明通道。
            局部修正以最新确认图为输入；下一张独立情绪差分仍回到默认立绘。先确认基准，再逐项生成并检查。
            真实透明背景通过模型的透明输出选项与RGBA PNG交付，下载后检验边缘与Alpha；噪点要求属于视觉约束。
            """,
        "gemini" => """
            Gemini / Nano Banana 编辑约束：每张差分上传同一默认立绘，明确标出“人物与画风基准”，额外风格图标为“仅参考绘制方式”。
            每次完整重述需要保留的脸型、服装、发型、色板、光照和纹理密度，以及当前允许调整的表情和小动作。
            同一画布、镜头距离、人物尺度与鞋底基线；每轮检查脸部、发梢、布料边缘和背景透明度。
            下载原始图验证Alpha；实色背景输出需经过主体蒙版和边缘修整，保存为RGBA PNG后导入游戏。
            """,
        _ => "每次使用同一角色基准与同一画风参考，说明每张参考图的用途。逐项编辑、核对轮廓与色板、检查真实透明通道，确认后保存对应情绪ID的PNG。"
    });
    public static string Get(PortraitDesign design) => design.ModelConstraints?.GetValueOrDefault(design.PromptModel) ?? Default(design.PromptModel);
}
