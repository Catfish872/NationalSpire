# PortraitModelPrompts.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`F414BEB3363213DA5FCE3471B565FC5D550C7983D534CD98073B0EB45B764745`。来源：[源码](../../PortraitModelPrompts.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.PortraitModelPrompts`。

字段、事件及初始值（源码原样）：

```csharp
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
```

<a id="symbol-e2cc08446a70"></a>

## `NationalSpire.PortraitModelPrompts.Default(string) — public static string Default(string model)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DrawPortraitStyles(Godot.VBoxContainer, NationalSpire.PortraitDesign)`](PortraitStyleScreen.cs.md#symbol-f030328fcc3e)；[`NationalSpire.PortraitModelPrompts.Get(NationalSpire.PortraitDesign)`](PortraitModelPrompts.cs.md#symbol-78c7c2214dc7)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.PortraitModelPrompts.Common`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-78c7c2214dc7"></a>

## `NationalSpire.PortraitModelPrompts.Get(NationalSpire.PortraitDesign) — public static string Get(PortraitDesign design)`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DrawPortraitStyles(Godot.VBoxContainer, NationalSpire.PortraitDesign)`](PortraitStyleScreen.cs.md#symbol-f030328fcc3e)；[`NationalSpire.PortraitPromptExport.Files(NationalSpire.PortraitDesign, string)`](PortraitPromptExport.cs.md#symbol-381ffd792ba0)

**调用：** [`NationalSpire.PortraitModelPrompts.Default(string)`](PortraitModelPrompts.cs.md#symbol-e2cc08446a70)；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.PortraitDesign.ModelConstraints`；`NationalSpire.PortraitDesign.PromptModel`；`NationalSpire.PortraitModelPrompts.Default(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PortraitModelPrompts.Default(string)`；输入表达式：`Default(design.PromptModel)`；返回值紧邻使用处：`BinaryExpressionSyntax: design.ModelConstraints?.GetValueOrDefault(design.PromptModel) ?? Default(design.PromptModel)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`.GetValueOrDefault(design.PromptModel)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: design.ModelConstraints?.GetValueOrDefault(design.PromptModel)`

**赋值（含属性/字段和局部值）：**
