# DateGameContent.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`7F6822FF6655974F72E337BA43BE8DE7BCDB6C6944422BDF6FA0B0D3119D2EBE`。来源：[源码](../../DateGameContent.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.DateGameTiming`、`NationalSpire.DateVoiceEdits`、`NationalSpire.DateGameContent`、`NationalSpire.DateGameContent.Phrase`、`NationalSpire.DateGameContent.Profile`、`NationalSpire.DateGameContent.TriggerSpeech`、`NationalSpire.DateGameContent.RuleSetting`、`NationalSpire.DateGameContent.Bundle`、`NationalSpire.DateGameContent.VoiceFile`、`NationalSpire.DateGameContent.RuleFile`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly JsonSerializerOptions Json = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase, WriteIndented = true,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow, MaxDepth = 32
    };
private static readonly Lazy<Dictionary<string, Phrase>> Catalog = new(BuildCatalog);
public const string Guide = """
        # 约会对局发言与触发条件

        每种性格是一份独立 JSON：对局发言_男性默认、女性默认、傲娇、无口、抖M、雌小鬼、小妈妈。可以只把需要修改的一份交给 AI。
        每份性格文件同时包含普通对局发言和十种事件的请求聊天台词。公共阈值、开关和冷却保存在“对局触发条件.json”。

        ## 编辑并导入

        1. 修改触发事件的台词：在性格文件的 profile.triggers 下找到事件（例如 fast），直接编辑其 lines 列表，每项是一句完整候选台词，可以增删。旁边的 condition 解释触发时机，实际数值由公共条件文件控制。
        2. 修改普通解说与内心发言：编辑 profile.lines，情境补句在 profile.remarks（可以留空）。catalog 提供这部分原句的用途和对照；保留编号以及 {hp}、{damage} 等花括号里的名称，游戏会填入真实数据。
        3. 保存为 JSON。在“模组设置 → 约会对局发言与触发 → 导入台词JSON”中选择这一份文件。可依次导入其他性格。
        4. 检查后点击“保存”。单份性格文件只更新对应性格；公共条件文件只更新触发规则。取消编辑会保留之前的设置。

        例如在“对局发言_傲娇.json”中，把 profile.triggers.fast.lines 改为 ["跑这么快，也稍微等等我呀。", "这一路的选择，你待会儿给我讲讲。"]。快速推进触发时，该性格会随机说其中一句；其他性格保留自己的候选句。
        事件 lines 已经是完整发言，游戏会直接使用，并保留原本先发言、后请求聊天的流程。这里的句子可独立增删，普通发言区的补句应用于普通解说。
        可以把这句话连同文件发给 AI：请保留字段名、触发事件编号、普通台词编号和花括号里的名称，按我的要求修改 profile 中的台词与补句，重点改写 profile.triggers 每个事件的 lines，返回完整的这个性格 JSON 文件。

        ## 调整公共条件

        rules 中 enabled 是开关，chat 表示发言后是否请求聊天，threshold 是阈值；conditions 说明单位、比较方式和次数限制。排列 rules 可以调整检查优先级。事件候选台词统一在各性格文件的 profile.triggers 中编辑。
        timing 中 speechSeconds 是事件发言间隔，chatSeconds 是请求聊天间隔（从上次请求出现时起计算，最短20秒），fastMinimumFloor 是快速推进的起始楼层（至少20层）。

        默认包含：快速推进、通过第一幕、通过第二幕、NPC倒下、NPC大量受伤、玩家低生命、单层花费300金币、30秒内精英胜利、60秒内首领胜利、双方相差12层。
        大量受伤、单层消费、精英速胜、首领速胜各自每幕一次；进度差距每局一次。精英与首领用时采用严格小于阈值。
        先播出台词，再由玩家点击“回应请求”；游戏在当前动作完成后打开约会。冷却期间发生的消费、战斗等事实会保留，等待播报。
        各性格的事件候选句通过 fast、gold-spent 等固定事件编号对应，可直接编辑后单独导入。调整公共阈值会保留已经编辑的各性格台词。

        原有普通解说、内心活动、商店、出牌等台词也包含在各性格文件中，继续使用原有播报时机。start 和 ambient 已从这组约会请求条件移除。
        旧版综合文件及第一版分性格文件仍可导入；综合文件会更新全部性格。旧台词改写会在下次导出时归入相应事件。新导出的文件始终按性格拆分。建议修改前保留一份导出备份。
        """;
```

<a id="symbol-a646f7817e29"></a>

## `NationalSpire.DateGameTiming.SpeechSeconds — public double SpeechSeconds`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b7d503b07cfc"></a>

## `NationalSpire.DateGameTiming.ChatSeconds — public double ChatSeconds`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.DateGames.ChatRequestInterval`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-817b058d1da3"></a>

## `NationalSpire.DateGameTiming.FastMinimumFloor — public int FastMinimumFloor`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2caa99ce7d9f"></a>

## `NationalSpire.DateGameTiming.AmbientMinimumSeconds — public double AmbientMinimumSeconds`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-5e039e8830b7"></a>

## `NationalSpire.DateVoiceEdits.Lines — public Dictionary<string, string> Lines`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c4fc219ad800"></a>

## `NationalSpire.DateVoiceEdits.Remarks — public Dictionary<string, string> Remarks`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-eec49b38a3eb"></a>

## `NationalSpire.DateVoiceEdits.Triggers — public Dictionary<string, List<string>> Triggers`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-4d1110eb500d"></a>

## `NationalSpire.DateGameContent.Phrase.Context — public string Context`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d651e7e73a75"></a>

## `NationalSpire.DateGameContent.Phrase.Variables — public string[] Variables`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e8b0ae854937"></a>

## `NationalSpire.DateGameContent.Phrase.Text — public string Text`

来源：源码第 35 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-41f68f24758f"></a>

## `NationalSpire.DateGameContent.Profile.Name — public string Name`

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ed1dfb26b8b6"></a>

## `NationalSpire.DateGameContent.Profile.Lines — public Dictionary<string, string> Lines`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-738ab61c0456"></a>

## `NationalSpire.DateGameContent.Profile.Remarks — public Dictionary<string, string> Remarks`

来源：源码第 41 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b56f051b456c"></a>

## `NationalSpire.DateGameContent.Profile.Triggers — public Dictionary<string, TriggerSpeech> Triggers`

来源：源码第 42 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-83be2530f2f0"></a>

## `NationalSpire.DateGameContent.TriggerSpeech.Condition — public string Condition`

来源：源码第 46 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-5a34f9fa1ed0"></a>

## `NationalSpire.DateGameContent.TriggerSpeech.Lines — public List<string> Lines`

来源：源码第 47 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f3ddea0efa42"></a>

## `NationalSpire.DateGameContent.RuleSetting.Trigger — public string Trigger`

来源：源码第 51 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9d29c73bdc70"></a>

## `NationalSpire.DateGameContent.RuleSetting.Enabled — public bool Enabled`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-81317e238c63"></a>

## `NationalSpire.DateGameContent.RuleSetting.Chat — public bool Chat`

来源：源码第 53 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ee1ee616abca"></a>

## `NationalSpire.DateGameContent.RuleSetting.Threshold — public double Threshold`

来源：源码第 54 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c292201db6dd"></a>

## `NationalSpire.DateGameContent.RuleSetting.Lines — public List<string>? Lines`

来源：源码第 55 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b720e29023c4"></a>

## `NationalSpire.DateGameContent.Bundle.Format — public string Format`

来源：源码第 60 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-46dbecff1ce3"></a>

## `NationalSpire.DateGameContent.Bundle.Version — public int Version`

来源：源码第 61 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a30a457ac209"></a>

## `NationalSpire.DateGameContent.Bundle.Timing — public DateGameTiming Timing`

来源：源码第 62 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `NationalSpire.DateGameTiming.DateGameTiming()`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGameTiming.DateGameTiming()`；输入表达式：`new()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b0a29c2f5693"></a>

## `NationalSpire.DateGameContent.Bundle.Rules — public List<DateGameRule> Rules`

来源：源码第 63 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3c458ecff310"></a>

## `NationalSpire.DateGameContent.Bundle.Conditions — public Dictionary<string, string> Conditions`

来源：源码第 64 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f83551d2a6cf"></a>

## `NationalSpire.DateGameContent.Bundle.Catalog — public Dictionary<string, Phrase> Catalog`

来源：源码第 65 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-1ba918a785d7"></a>

## `NationalSpire.DateGameContent.Bundle.Profiles — public Dictionary<string, Profile> Profiles`

来源：源码第 66 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a96595c73e79"></a>

## `NationalSpire.DateGameContent.VoiceFile.Format — public string Format`

来源：源码第 70 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9c3bef92f42a"></a>

## `NationalSpire.DateGameContent.VoiceFile.Version — public int Version`

来源：源码第 71 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d41b8cd8abd8"></a>

## `NationalSpire.DateGameContent.VoiceFile.Personality — public string Personality`

来源：源码第 72 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-347ecdfc8dc8"></a>

## `NationalSpire.DateGameContent.VoiceFile.Profile — public Profile Profile`

来源：源码第 73 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `NationalSpire.DateGameContent.Profile.Profile()`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGameContent.Profile.Profile()`；输入表达式：`new()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e380cb85c9f7"></a>

## `NationalSpire.DateGameContent.VoiceFile.Catalog — public Dictionary<string, Phrase> Catalog`

来源：源码第 74 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2440bbac44ed"></a>

## `NationalSpire.DateGameContent.RuleFile.Format — public string Format`

来源：源码第 78 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-0fc01be64149"></a>

## `NationalSpire.DateGameContent.RuleFile.Version — public int Version`

来源：源码第 79 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-48e40bda30bd"></a>

## `NationalSpire.DateGameContent.RuleFile.Timing — public DateGameTiming Timing`

来源：源码第 80 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `NationalSpire.DateGameTiming.DateGameTiming()`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGameTiming.DateGameTiming()`；输入表达式：`new()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ee9e2965b8d2"></a>

## `NationalSpire.DateGameContent.RuleFile.Rules — public List<RuleSetting> Rules`

来源：源码第 81 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-dff65bff4adc"></a>

## `NationalSpire.DateGameContent.RuleFile.Conditions — public Dictionary<string, string> Conditions`

来源：源码第 82 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-04fef069e286"></a>

## `NationalSpire.DateGameContent.Key(string) — public static string Key(string source)`

来源：源码第 91 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Add(string, System.Collections.Generic.IEnumerable<string>)`](DateGameContent.cs.md#symbol-e4424c6ca6f5)；[`NationalSpire.DateGameContent.Read(string)`](DateGameContent.cs.md#symbol-ad02667b222b)；[`NationalSpire.DateGameContent.RewritePhrase(NationalSpire.CareerData, string, string)`](DateGameContent.cs.md#symbol-28305905e4be)；[`NationalSpire.DateGameContent.Snapshot(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.DateGameRule>?)`](DateGameContent.cs.md#symbol-f9fa9ec59680)；[`NationalSpire.DateGameContent.Validate(NationalSpire.DateGameContent.Bundle, bool)`](DateGameContent.cs.md#symbol-a56139e0281f)

**调用：** `System.Convert.ToHexString(byte[])`；`System.Security.Cryptography.SHA256.HashData(byte[])`；`System.Text.Encoding.GetBytes(string)`；`string.ToLowerInvariant()`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Convert.ToHexString(byte[])`；输入表达式：`Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(source)))`；返回值紧邻使用处：`ElementAccessExpressionSyntax: Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(source)))[..24]`
- `System.Security.Cryptography.SHA256.HashData(byte[])`；输入表达式：`SHA256.HashData(Encoding.UTF8.GetBytes(source))`；返回值紧邻使用处：`ArgumentSyntax: SHA256.HashData(Encoding.UTF8.GetBytes(source))`
- `System.Text.Encoding.GetBytes(string)`；输入表达式：`Encoding.UTF8.GetBytes(source)`；返回值紧邻使用处：`ArgumentSyntax: Encoding.UTF8.GetBytes(source)`
- `string.ToLowerInvariant()`；输入表达式：`Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(source)))[..24].ToLowerInvariant()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(source)))[..24].ToLowerInvariant()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b357dc27bdfb"></a>

## `NationalSpire.DateGameContent.Variables(string) — private static string[] Variables(string source)`

来源：源码第 92 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Add(string, System.Collections.Generic.IEnumerable<string>)`](DateGameContent.cs.md#symbol-e4424c6ca6f5)；[`NationalSpire.DateGameContent.Validate(NationalSpire.DateGameContent.Bundle, bool)`](DateGameContent.cs.md#symbol-a56139e0281f)

**调用：** `System.Collections.Generic.IEnumerable<T>.Order<T>(System.Collections.Generic.IComparer<T>?)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Text.RegularExpressions.Regex.Matches(string, string)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<T>.Order<T>(System.Collections.Generic.IComparer<T>?)`；输入表达式：`Regex.Matches(source, @"\{[^{}]+\}").Select(m => m.Value).Distinct().Order(StringComparer.Ordinal)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Regex.Matches(source, @"\{[^{}]+\}").Select(m => m.Value).Distinct().Order(StringComparer.Ordinal).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`Regex.Matches(source, @"\{[^{}]+\}").Select(m => m.Value).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Regex.Matches(source, @"\{[^{}]+\}").Select(m => m.Value).Distinct().Order`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Regex.Matches(source, @"\{[^{}]+\}").Select(m => m.Value)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Regex.Matches(source, @"\{[^{}]+\}").Select(m => m.Value).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Regex.Matches(source, @"\{[^{}]+\}").Select(m => m.Value).Distinct().Order(StringComparer.Ordinal).ToArray()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Regex.Matches(source, @"\{[^{}]+\}").Select(m => m.Value).Distinct().Order(StringComparer.Ordinal).ToArray()`
- `System.Text.RegularExpressions.Regex.Matches(string, string)`；输入表达式：`Regex.Matches(source, @"\{[^{}]+\}")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Regex.Matches(source, @"\{[^{}]+\}").Select`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ee6db67d591b"></a>

## `NationalSpire.DateGameContent.BuildCatalog() — private static Dictionary<string, Phrase> BuildCatalog()`

来源：源码第 93 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`Add(string, System.Collections.Generic.IEnumerable<string>)`](DateGameContent.cs.md#symbol-e4424c6ca6f5)；[`NationalSpire.LiveCommentary.DateContentBanks()`](LiveCommentary.cs.md#symbol-f0a726313633)；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`string.StartsWith(string, System.StringComparison)`

**字段、属性、事件及方法组引用：** `Add(string, System.Collections.Generic.IEnumerable<string>)`；`NationalSpire.LiveCommentary.DateContentBanks()`；`NationalSpire.LiveSpeechComposer.Endings`；`NationalSpire.LiveVoiceCatalog.Banks`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Add(string, System.Collections.Generic.IEnumerable<string>)`；输入表达式：`Add("内心或现场发言：" + context, lines)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add("内心或现场发言：" + context, lines);`
- `Add(string, System.Collections.Generic.IEnumerable<string>)`；输入表达式：`Add("可选补句：" + context, lines)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add("可选补句：" + context, lines);`
- `Add(string, System.Collections.Generic.IEnumerable<string>)`；输入表达式：`Add(context, lines)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(context, lines);`
- `NationalSpire.LiveCommentary.DateContentBanks()`；输入表达式：`LiveCommentary.DateContentBanks()`；返回值紧邻使用处：`ForEachVariableStatementSyntax: foreach (var (context, lines) in LiveCommentary.DateContentBanks()) Add(context, lines);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, Phrase>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, Phrase>()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`LiveSpeechComposer.Endings.Where(p => p.Key.StartsWith("thought_", StringComparison.Ordinal) || (p.Key.StartsWith("host_", StringComparison.Ordinal) || p.Key.StartsWith("shop_", StringComparison.Ordinal)) || p.Key.StartsWith("world_", StringComparison.Ordinal))`；返回值紧邻使用处：`ForEachVariableStatementSyntax: foreach (var (context, lines) in LiveSpeechComposer.Endings.Where(p => p.Key.StartsWith("thought_", StringComparison.Ordinal) || (p.Key.StartsWith("host_", StringComparison.Ordinal) || p.Key.StartsWith("shop_", StringComparison.Ordinal)) || p.Key.StartsWith("world_", StringComparison.Ordinal))) Add("可选补句：" + context, lines);`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`LiveVoiceCatalog.Banks.Where(p => p.Key.StartsWith("thought_", StringComparison.Ordinal) || (p.Key.StartsWith("host_", StringComparison.Ordinal) || p.Key.StartsWith("shop_", StringComparison.Ordinal)))`；返回值紧邻使用处：`ForEachVariableStatementSyntax: foreach (var (context, lines) in LiveVoiceCatalog.Banks.Where(p => p.Key.StartsWith("thought_", StringComparison.Ordinal) || (p.Key.StartsWith("host_", StringComparison.Ordinal) || p.Key.StartsWith("shop_", StringComparison.Ordinal)))) Add("内心或现场发言：" + context, lines);`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`p.Key.StartsWith("host_", StringComparison.Ordinal)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.Key.StartsWith("host_", StringComparison.Ordinal) || p.Key.StartsWith("shop_", StringComparison.Ordinal)`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`p.Key.StartsWith("shop_", StringComparison.Ordinal)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.Key.StartsWith("host_", StringComparison.Ordinal) || p.Key.StartsWith("shop_", StringComparison.Ordinal)`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`p.Key.StartsWith("thought_", StringComparison.Ordinal)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.Key.StartsWith("thought_", StringComparison.Ordinal) || (p.Key.StartsWith("host_", StringComparison.Ordinal) || p.Key.StartsWith("shop_", StringComparison.Ordinal))`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`p.Key.StartsWith("world_", StringComparison.Ordinal)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.Key.StartsWith("thought_", StringComparison.Ordinal) || (p.Key.StartsWith("host_", StringComparison.Ordinal) || p.Key.StartsWith("shop_", StringComparison.Ordinal)) || p.Key.StartsWith("world_", StringComparison.Ordinal)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e4424c6ca6f5"></a>

## `Add(string, System.Collections.Generic.IEnumerable<string>) — void Add(string context, IEnumerable<string> lines)`

来源：源码第 96 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGameContent.BuildCatalog()`](DateGameContent.cs.md#symbol-ee6db67d591b)

**调用：** [`NationalSpire.DateGameContent.Key(string)`](DateGameContent.cs.md#symbol-04fef069e286)；`NationalSpire.DateGameContent.Phrase.Phrase()`；[`NationalSpire.DateGameContent.Variables(string)`](DateGameContent.cs.md#symbol-b357dc27bdfb)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateGameContent.Key(string)`；`NationalSpire.DateGameContent.Phrase.Context`；`NationalSpire.DateGameContent.Phrase.Text`；`NationalSpire.DateGameContent.Phrase.Variables`；`NationalSpire.DateGameContent.Variables(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGameContent.Key(string)`；输入表达式：`Key(text)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Key(text)`
- `NationalSpire.DateGameContent.Phrase.Phrase()`；输入表达式：`new() { Context = context, Text = text, Variables = Variables(text) }`；返回值紧邻使用处：`AssignmentExpressionSyntax: result[key] = new() { Context = context, Text = text, Variables = Variables(text) }`
- `NationalSpire.DateGameContent.Variables(string)`；输入表达式：`Variables(text)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Variables = Variables(text)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`result.TryGetValue(key, out var previous)`；返回值紧邻使用处：`IfStatementSyntax: if (result.TryGetValue(key, out var previous)) previous.Context += " / " + context; else result[key] = new() { Context = context, Text = text, Variables = Variables(text) };`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`lines.Where(t => t.Length > 0)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string text in lines.Where(t => t.Length > 0)) { string key = Key(text); if (result.TryGetValue(key, out var previous)) previous.Context += " / " + context; else result[key] = new() { Context = context, Text = text, Variables = Variables(text) }; }`

**赋值（含属性/字段和局部值）：**

- `Context` = `context`
- `Text` = `text`
- `Variables` = `Variables(text)`
- `previous.Context` += `" / " + context`
- `result[key]` = `new() { Context = context, Text = text, Variables = Variables(text) }`

<a id="symbol-bb442b479ffc"></a>

## `NationalSpire.DateGameContent.DefaultRemarks(string) — public static Dictionary<string, string> DefaultRemarks(string profile)`

来源：源码第 110 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGameContent.Edits(string, NationalSpire.DateGameContent.Profile, System.Collections.Generic.Dictionary<string, NationalSpire.DateGameContent.Phrase>, System.Collections.Generic.List<NationalSpire.DateGameRule>)`](DateGameContent.cs.md#symbol-608ae4848093)；[`NationalSpire.DateGameContent.Snapshot(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.DateGameRule>?)`](DateGameContent.cs.md#symbol-f9fa9ec59680)

**调用：** `System.Array.IndexOf<T>(T[], T)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateGameVoices.Ids`；`NationalSpire.DateGameVoices.Remarks`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Array.IndexOf<T>(T[], T)`；输入表达式：`Array.IndexOf(DateGameVoices.Ids, profile)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Array.IndexOf(DateGameVoices.Ids, profile)`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`DateGameVoices.Remarks.ToDictionary(p => p.Key, p => index <= 0 ? "" : p.Value[index - 1])`；返回值紧邻使用处：`ReturnStatementSyntax: return DateGameVoices.Remarks.ToDictionary(p => p.Key, p => index <= 0 ? "" : p.Value[index - 1]);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f9fa9ec59680"></a>

## `NationalSpire.DateGameContent.Snapshot(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.DateGameRule>?) — public static Bundle Snapshot(CareerData data, List<DateGameRule>? drafts = null)`

来源：源码第 115 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.EditDateGameRules()`](DateGameScreen.cs.md#symbol-0a1b70a243b1)；[`NationalSpire.DateGameContent.Export(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.DateGameRule>?)`](DateGameContent.cs.md#symbol-84e05bfe9c17)；[`NationalSpire.DateGameContent.Files(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.DateGameRule>?)`](DateGameContent.cs.md#symbol-c778174ab92f)

**调用：** [`NationalSpire.Coop.CoopJson.Copy<T>(T)`](Coop/CoopData.cs.md#symbol-38a51b2b1811)；`NationalSpire.DateGameContent.Bundle.Bundle()`；[`NationalSpire.DateGameContent.Conditions()`](DateGameContent.cs.md#symbol-81cefbde8918)；[`NationalSpire.DateGameContent.DefaultRemarks(string)`](DateGameContent.cs.md#symbol-bb442b479ffc)；[`NationalSpire.DateGameContent.Key(string)`](DateGameContent.cs.md#symbol-04fef069e286)；`NationalSpire.DateGameContent.Phrase.Phrase()`；`NationalSpire.DateGameContent.Profile.Profile()`；`NationalSpire.DateGameContent.TriggerSpeech.TriggerSpeech()`；[`NationalSpire.DateGameVoices.EventLines(NationalSpire.CareerData, string, NationalSpire.DateGameRule)`](DateGameVoices.cs.md#symbol-036aa782750d)；[`NationalSpire.DateGames.UpgradeRules(System.Collections.Generic.IEnumerable<NationalSpire.DateGameRule>)`](DateGames.cs.md#symbol-c824a5233693)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryAdd(TKey, TValue)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.DateGameRules`；`NationalSpire.CareerData.DateGameTiming`；`NationalSpire.CareerData.DateGameVoiceEdits`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.DateGameContent.Bundle.Catalog`；`NationalSpire.DateGameContent.Bundle.Conditions`；`NationalSpire.DateGameContent.Bundle.Profiles`；`NationalSpire.DateGameContent.Bundle.Rules`；`NationalSpire.DateGameContent.Bundle.Timing`；`NationalSpire.DateGameContent.Catalog`；`NationalSpire.DateGameContent.Conditions()`；`NationalSpire.DateGameContent.DefaultRemarks(string)`；`NationalSpire.DateGameContent.Key(string)`；`NationalSpire.DateGameContent.Phrase.Context`；`NationalSpire.DateGameContent.Phrase.Text`；`NationalSpire.DateGameContent.Phrase.Variables`；`NationalSpire.DateGameContent.Profile.Lines`；`NationalSpire.DateGameContent.Profile.Name`；`NationalSpire.DateGameContent.Profile.Remarks`；`NationalSpire.DateGameContent.Profile.Triggers`；`NationalSpire.DateGameContent.TriggerSpeech.Condition`；`NationalSpire.DateGameContent.TriggerSpeech.Lines`；`NationalSpire.DateGameRule.Lines`；`NationalSpire.DateGameRule.Trigger`；`NationalSpire.DateGameTiming.AmbientMinimumSeconds`；`NationalSpire.DateGameTiming.FastMinimumFloor`；`NationalSpire.DateGameVoices.EventLines(NationalSpire.CareerData, string, NationalSpire.DateGameRule)`；`NationalSpire.DateGameVoices.Ids`；`NationalSpire.DateGameVoices.Labels`；`NationalSpire.DateGames.UpgradeRules(System.Collections.Generic.IEnumerable<NationalSpire.DateGameRule>)`；`NationalSpire.DateVoiceEdits.Lines`；`NationalSpire.DateVoiceEdits.Remarks`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`Coop.CoopJson.Copy(Catalog.Value)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Catalog = Coop.CoopJson.Copy(Catalog.Value)`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`Coop.CoopJson.Copy(DateGames.UpgradeRules(drafts ?? data.DateGameRules))`；返回值紧邻使用处：`AssignmentExpressionSyntax: Rules = Coop.CoopJson.Copy(DateGames.UpgradeRules(drafts ?? data.DateGameRules))`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`Coop.CoopJson.Copy(data.DateGameTiming)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Timing = Coop.CoopJson.Copy(data.DateGameTiming)`
- `NationalSpire.DateGameContent.Bundle.Bundle()`；输入表达式：`new Bundle { Timing = Coop.CoopJson.Copy(data.DateGameTiming), Rules = Coop.CoopJson.Copy(DateGames.UpgradeRules(drafts ?? data.DateGameRules)), Catalog = Coop.CoopJson.Copy(Catalog.Value), Conditions = Conditions() }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Bundle { Timing = Coop.CoopJson.Copy(data.DateGameTiming), Rules = Coop.CoopJson.Copy(DateGames.UpgradeRules(drafts ?? data.DateGameRules)), Catalog = Coop.CoopJson.Copy(Catalog.Value), Conditions = Conditions() }`
- `NationalSpire.DateGameContent.Conditions()`；输入表达式：`Conditions()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Conditions = Conditions()`
- `NationalSpire.DateGameContent.DefaultRemarks(string)`；输入表达式：`DefaultRemarks(id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DefaultRemarks(id).ToDictionary`
- `NationalSpire.DateGameContent.Key(string)`；输入表达式：`Key(text)`；返回值紧邻使用处：`ArgumentSyntax: Key(text)`
- `NationalSpire.DateGameContent.Phrase.Phrase()`；输入表达式：`new() { Context = "请求或事件台词：" + rule.Trigger, Text = text, Variables = [] }`；返回值紧邻使用处：`ArgumentSyntax: new() { Context = "请求或事件台词：" + rule.Trigger, Text = text, Variables = [] }`
- `NationalSpire.DateGameContent.Profile.Profile()`；输入表达式：`new() { Name = DateGameVoices.Labels[i], Lines = bundle.Catalog.ToDictionary(p => p.Key, p => edits?.Lines.GetValueOrDefault(p.Key) ?? p.Value.Text), Remarks = DefaultRemarks(id).ToDictionary(p => p.Key, p => edits?.Remarks.GetValueOrDefault(p.Key) ?? p.Value), Triggers = bundle.Rules.ToDictionary(r => r.Trigger, r => new TriggerSpeech { Condition = bundle.Conditions[r.Trigger], Lines = DateGameVoices.EventLines(data, id, r).ToList() }) }`；返回值紧邻使用处：`AssignmentExpressionSyntax: bundle.Profiles[id] = new() { Name = DateGameVoices.Labels[i], Lines = bundle.Catalog.ToDictionary(p => p.Key, p => edits?.Lines.GetValueOrDefault(p.Key) ?? p.Value.Text), Remarks = DefaultRemarks(id).ToDictionary(p => p.Key, p => edits?.Remarks.GetValueOrDefault(p.Key) ?? p.Value), Triggers = bundle.Rules.ToDictionary(r => r.Trigger, r => new TriggerSpeech { Condition = bundle.Conditions[r.Trigger], Lines = DateGameVoices.EventLines(data, id, r).ToList() }) }`
- `NationalSpire.DateGameContent.TriggerSpeech.TriggerSpeech()`；输入表达式：`new TriggerSpeech { Condition = bundle.Conditions[r.Trigger], Lines = DateGameVoices.EventLines(data, id, r).ToList() }`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: r => new TriggerSpeech { Condition = bundle.Conditions[r.Trigger], Lines = DateGameVoices.EventLines(data, id, r).ToList() }`
- `NationalSpire.DateGameVoices.EventLines(NationalSpire.CareerData, string, NationalSpire.DateGameRule)`；输入表达式：`DateGameVoices.EventLines(data, id, r)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateGameVoices.EventLines(data, id, r).ToList`
- `NationalSpire.DateGames.UpgradeRules(System.Collections.Generic.IEnumerable<NationalSpire.DateGameRule>)`；输入表达式：`DateGames.UpgradeRules(drafts ?? data.DateGameRules)`；返回值紧邻使用处：`ArgumentSyntax: DateGames.UpgradeRules(drafts ?? data.DateGameRules)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryAdd(TKey, TValue)`；输入表达式：`bundle.Catalog.TryAdd(Key(text), new() { Context = "请求或事件台词：" + rule.Trigger, Text = text, Variables = [] })`；返回值紧邻使用处：`ExpressionStatementSyntax: bundle.Catalog.TryAdd(Key(text), new() { Context = "请求或事件台词：" + rule.Trigger, Text = text, Variables = [] });`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`DefaultRemarks(id).ToDictionary(p => p.Key, p => edits?.Remarks.GetValueOrDefault(p.Key) ?? p.Value)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Remarks = DefaultRemarks(id).ToDictionary(p => p.Key, p => edits?.Remarks.GetValueOrDefault(p.Key) ?? p.Value)`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`bundle.Catalog.ToDictionary(p => p.Key, p => edits?.Lines.GetValueOrDefault(p.Key) ?? p.Value.Text)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Lines = bundle.Catalog.ToDictionary(p => p.Key, p => edits?.Lines.GetValueOrDefault(p.Key) ?? p.Value.Text)`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`bundle.Rules.ToDictionary(r => r.Trigger, r => new TriggerSpeech { Condition = bundle.Conditions[r.Trigger], Lines = DateGameVoices.EventLines(data, id, r).ToList() })`；返回值紧邻使用处：`AssignmentExpressionSyntax: Triggers = bundle.Rules.ToDictionary(r => r.Trigger, r => new TriggerSpeech { Condition = bundle.Conditions[r.Trigger], Lines = DateGameVoices.EventLines(data, id, r).ToList() })`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`DateGameVoices.EventLines(data, id, r).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Lines = DateGameVoices.EventLines(data, id, r).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`rule.Lines.Where(t => t.Length > 0)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string text in rule.Lines.Where(t => t.Length > 0)) bundle.Catalog.TryAdd(Key(text), new() { Context = "请求或事件台词：" + rule.Trigger, Text = text, Variables = [] });`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`.Lines.GetValueOrDefault(p.Key)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: edits?.Lines.GetValueOrDefault(p.Key)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`.Remarks.GetValueOrDefault(p.Key)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: edits?.Remarks.GetValueOrDefault(p.Key)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`data.DateGameVoiceEdits.GetValueOrDefault(id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.DateGameVoiceEdits.GetValueOrDefault(id)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(20, bundle.Timing.FastMinimumFloor)`；返回值紧邻使用处：`AssignmentExpressionSyntax: bundle.Timing.FastMinimumFloor = Math.Max(20, bundle.Timing.FastMinimumFloor)`

**赋值（含属性/字段和局部值）：**

- `Catalog` = `Coop.CoopJson.Copy(Catalog.Value)`
- `Condition` = `bundle.Conditions[r.Trigger]`
- `Conditions` = `Conditions()`
- `Context` = `"请求或事件台词：" + rule.Trigger`
- `Lines` = `DateGameVoices.EventLines(data, id, r).ToList()`
- `Lines` = `bundle.Catalog.ToDictionary(p => p.Key, p => edits?.Lines.GetValueOrDefault(p.Key) ?? p.Value.Text)`
- `Name` = `DateGameVoices.Labels[i]`
- `Remarks` = `DefaultRemarks(id).ToDictionary(p => p.Key, p => edits?.Remarks.GetValueOrDefault(p.Key) ?? p.Value)`
- `Rules` = `Coop.CoopJson.Copy(DateGames.UpgradeRules(drafts ?? data.DateGameRules))`
- `Text` = `text`
- `Timing` = `Coop.CoopJson.Copy(data.DateGameTiming)`
- `Triggers` = `bundle.Rules.ToDictionary(r => r.Trigger, r => new TriggerSpeech { Condition = bundle.Conditions[r.Trigger], Lines = DateGameVoices.EventLines(data, id, r).ToList() })`
- `Variables` = `[]`
- `bundle.Profiles[id]` = `new() { Name = DateGameVoices.Labels[i], Lines = bundle.Catalog.ToDictionary(p => p.Key, p => edits?.Lines.GetValueOrDefault(p.Key) ?? p.Value.Text), Remarks = DefaultRemarks(id).ToDictionary(p => p.Key, p => edits?.Remarks.GetValueOrDefault(p.Key) ?? p.Value), Triggers = bundle.Rules.ToDictionary(r => r.Trigger, r => new TriggerSpeech { Condition = bundle.Conditions[r.Trigger], Lines = DateGameVoices.EventLines(data, id, r).ToList() }) }`
- `bundle.Timing.AmbientMinimumSeconds` = `0`
- `bundle.Timing.FastMinimumFloor` = `Math.Max(20, bundle.Timing.FastMinimumFloor)`

<a id="symbol-84e05bfe9c17"></a>

## `NationalSpire.DateGameContent.Export(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.DateGameRule>?) — public static string Export(CareerData data, List<DateGameRule>? drafts = null)`

来源：源码第 135 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.DateGameContent.Snapshot(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.DateGameRule>?)`](DateGameContent.cs.md#symbol-f9fa9ec59680)；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateGameContent.Json`；`NationalSpire.DateGameContent.Snapshot(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.DateGameRule>?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGameContent.Snapshot(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.DateGameRule>?)`；输入表达式：`Snapshot(data, drafts)`；返回值紧邻使用处：`ArgumentSyntax: Snapshot(data, drafts)`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(Snapshot(data, drafts), Json)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => JsonSerializer.Serialize(Snapshot(data, drafts), Json)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ad02667b222b"></a>

## `NationalSpire.DateGameContent.Read(string) — public static Bundle Read(string text)`

来源：源码第 136 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGameContent.Import(NationalSpire.CareerData, string)`](DateGameContent.cs.md#symbol-2c2e135d0e20)

**调用：** [`NationalSpire.DateGameContent.Conditions()`](DateGameContent.cs.md#symbol-81cefbde8918)；[`NationalSpire.DateGameContent.Key(string)`](DateGameContent.cs.md#symbol-04fef069e286)；[`NationalSpire.DateGameContent.Parse(string)`](DateGameContent.cs.md#symbol-2749e1ca3d2d)；`NationalSpire.DateGameContent.Phrase.Phrase()`；[`NationalSpire.DateGameContent.Validate(NationalSpire.DateGameContent.Bundle, bool)`](DateGameContent.cs.md#symbol-a56139e0281f)；[`NationalSpire.DateGames.Defaults()`](DateGames.cs.md#symbol-f6f62ee5a1dd)；[`NationalSpire.DateGames.UpgradeRules(System.Collections.Generic.IEnumerable<NationalSpire.DateGameRule>)`](DateGames.cs.md#symbol-c824a5233693)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryAdd(TKey, TValue)`；`System.Collections.Generic.HashSet<T>.Remove(T)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.Math.Max(int, int)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateGameContent.Bundle.Catalog`；`NationalSpire.DateGameContent.Bundle.Conditions`；`NationalSpire.DateGameContent.Bundle.Format`；`NationalSpire.DateGameContent.Bundle.Profiles`；`NationalSpire.DateGameContent.Bundle.Rules`；`NationalSpire.DateGameContent.Bundle.Timing`；`NationalSpire.DateGameContent.Bundle.Version`；`NationalSpire.DateGameContent.Conditions()`；`NationalSpire.DateGameContent.Json`；`NationalSpire.DateGameContent.Key(string)`；`NationalSpire.DateGameContent.Parse(string)`；`NationalSpire.DateGameContent.Phrase.Context`；`NationalSpire.DateGameContent.Phrase.Text`；`NationalSpire.DateGameContent.Profile.Lines`；`NationalSpire.DateGameContent.Validate(NationalSpire.DateGameContent.Bundle, bool)`；`NationalSpire.DateGameRule.Lines`；`NationalSpire.DateGameRule.Trigger`；`NationalSpire.DateGameTiming.AmbientMinimumSeconds`；`NationalSpire.DateGameTiming.FastMinimumFloor`；`NationalSpire.DateGames.Defaults()`；`NationalSpire.DateGames.UpgradeRules(System.Collections.Generic.IEnumerable<NationalSpire.DateGameRule>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGameContent.Conditions()`；输入表达式：`Conditions()`；返回值紧邻使用处：`AssignmentExpressionSyntax: bundle.Conditions = Conditions()`
- `NationalSpire.DateGameContent.Key(string)`；输入表达式：`Key(line)`；返回值紧邻使用处：`ArgumentSyntax: Key(line)`
- `NationalSpire.DateGameContent.Parse(string)`；输入表达式：`Parse(text)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Parse(text)`
- `NationalSpire.DateGameContent.Phrase.Phrase()`；输入表达式：`new() { Text = line, Context = "请求或事件台词：" + rule.Trigger }`；返回值紧邻使用处：`ArgumentSyntax: new() { Text = line, Context = "请求或事件台词：" + rule.Trigger }`
- `NationalSpire.DateGameContent.Validate(NationalSpire.DateGameContent.Bundle, bool)`；输入表达式：`Validate(bundle)`；返回值紧邻使用处：`ExpressionStatementSyntax: Validate(bundle);`
- `NationalSpire.DateGames.Defaults()`；输入表达式：`DateGames.Defaults()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateGames.Defaults().Select`
- `NationalSpire.DateGames.UpgradeRules(System.Collections.Generic.IEnumerable<NationalSpire.DateGameRule>)`；输入表达式：`DateGames.UpgradeRules(bundle.Rules)`；返回值紧邻使用处：`AssignmentExpressionSyntax: bundle.Rules = DateGames.UpgradeRules(bundle.Rules)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryAdd(TKey, TValue)`；输入表达式：`bundle.Catalog.TryAdd(Key(line), new() { Text = line, Context = "请求或事件台词：" + rule.Trigger })`；返回值紧邻使用处：`IfStatementSyntax: if (bundle.Catalog.TryAdd(Key(line), new() { Text = line, Context = "请求或事件台词：" + rule.Trigger })) foreach (var profile in bundle.Profiles.Values) profile.Lines.TryAdd(Key(line), line);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryAdd(TKey, TValue)`；输入表达式：`profile.Lines.TryAdd(Key(line), line)`；返回值紧邻使用处：`ExpressionStatementSyntax: profile.Lines.TryAdd(Key(line), line);`
- `System.Collections.Generic.HashSet<T>.Remove(T)`；输入表达式：`ids.Remove(r.Trigger)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ids.Remove(r.Trigger)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`bundle.Rules.Any(r => r == null || !ids.Remove(r.Trigger))`；返回值紧邻使用处：`IfStatementSyntax: if (bundle.Rules.Any(r => r == null || !ids.Remove(r.Trigger))) throw new InvalidDataException("旧版文件含未知或重复的触发编号。");`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`DateGames.Defaults().Select(r => r.Trigger).Concat(["start", "ambient"])`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateGames.Defaults().Select(r => r.Trigger).Concat(["start", "ambient"]).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`DateGames.Defaults().Select(r => r.Trigger)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateGames.Defaults().Select(r => r.Trigger).Concat`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`DateGames.Defaults().Select(r => r.Trigger).Concat(["start", "ambient"]).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateGames.Defaults().Select(r => r.Trigger).Concat(["start", "ambient"]).ToHashSet()`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("文件为空。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidDataException("文件为空。")`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("旧版文件含未知或重复的触发编号。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("旧版文件含未知或重复的触发编号。");`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(20, bundle.Timing.FastMinimumFloor)`；返回值紧邻使用处：`AssignmentExpressionSyntax: bundle.Timing.FastMinimumFloor = Math.Max(20, bundle.Timing.FastMinimumFloor)`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<Bundle>(text, Json)`；返回值紧邻使用处：`BinaryExpressionSyntax: JsonSerializer.Deserialize<Bundle>(text, Json) ?? throw new InvalidDataException("文件为空。")`

**赋值（含属性/字段和局部值）：**

- `Context` = `"请求或事件台词：" + rule.Trigger`
- `Text` = `line`
- `bundle.Conditions` = `Conditions()`
- `bundle.Rules` = `DateGames.UpgradeRules(bundle.Rules)`
- `bundle.Timing.AmbientMinimumSeconds` = `0`
- `bundle.Timing.FastMinimumFloor` = `Math.Max(20, bundle.Timing.FastMinimumFloor)`
- `bundle.Version` = `2`

<a id="symbol-2749e1ca3d2d"></a>

## `NationalSpire.DateGameContent.Parse(string) — private static JsonDocument Parse(string text)`

来源：源码第 153 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGameContent.Import(NationalSpire.CareerData, string)`](DateGameContent.cs.md#symbol-2c2e135d0e20)；[`NationalSpire.DateGameContent.Read(string)`](DateGameContent.cs.md#symbol-ad02667b222b)

**调用：** [`NationalSpire.DateGameContent.CheckDuplicateKeys(System.Text.Json.JsonElement)`](DateGameContent.cs.md#symbol-95c897dc6ef5)；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.Text.Encoding.GetByteCount(string)`；`System.Text.Json.JsonDocument.Dispose()`；`System.Text.Json.JsonDocument.Parse(string, System.Text.Json.JsonDocumentOptions)`；`System.Text.Json.JsonDocumentOptions.JsonDocumentOptions()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateGameContent.CheckDuplicateKeys(System.Text.Json.JsonElement)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGameContent.CheckDuplicateKeys(System.Text.Json.JsonElement)`；输入表达式：`CheckDuplicateKeys(document.RootElement)`；返回值紧邻使用处：`ExpressionStatementSyntax: CheckDuplicateKeys(document.RootElement);`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("台词文件超过24MB，请缩短内容后再导入。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("台词文件超过24MB，请缩短内容后再导入。");`
- `System.Text.Encoding.GetByteCount(string)`；输入表达式：`Encoding.UTF8.GetByteCount(text)`；返回值紧邻使用处：`BinaryExpressionSyntax: Encoding.UTF8.GetByteCount(text) > 24 * 1024 * 1024`
- `System.Text.Json.JsonDocument.Dispose()`；输入表达式：`document.Dispose()`；返回值紧邻使用处：`ExpressionStatementSyntax: document.Dispose();`
- `System.Text.Json.JsonDocument.Parse(string, System.Text.Json.JsonDocumentOptions)`；输入表达式：`JsonDocument.Parse(text, new() { MaxDepth = 32 })`；返回值紧邻使用处：`EqualsValueClauseSyntax: = JsonDocument.Parse(text, new() { MaxDepth = 32 })`
- `System.Text.Json.JsonDocumentOptions.JsonDocumentOptions()`；输入表达式：`new() { MaxDepth = 32 }`；返回值紧邻使用处：`ArgumentSyntax: new() { MaxDepth = 32 }`

**赋值（含属性/字段和局部值）：**

- `MaxDepth` = `32`

<a id="symbol-2c2e135d0e20"></a>

## `NationalSpire.DateGameContent.Import(NationalSpire.CareerData, string) — public static string Import(CareerData data, string text)`

来源：源码第 160 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.EditDateGameRules()`](DateGameScreen.cs.md#symbol-0a1b70a243b1)

**调用：** [`NationalSpire.Coop.CoopJson.Copy<T>(T)`](Coop/CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.DateGameContent.Apply(NationalSpire.CareerData, NationalSpire.DateGameContent.Bundle)`](DateGameContent.cs.md#symbol-5a89da7cbb82)；`NationalSpire.DateGameContent.Bundle.Bundle()`；[`NationalSpire.DateGameContent.Edits(string, NationalSpire.DateGameContent.Profile, System.Collections.Generic.Dictionary<string, NationalSpire.DateGameContent.Phrase>, System.Collections.Generic.List<NationalSpire.DateGameRule>)`](DateGameContent.cs.md#symbol-608ae4848093)；[`NationalSpire.DateGameContent.Parse(string)`](DateGameContent.cs.md#symbol-2749e1ca3d2d)；[`NationalSpire.DateGameContent.Read(string)`](DateGameContent.cs.md#symbol-ad02667b222b)；[`NationalSpire.DateGameContent.Validate(NationalSpire.DateGameContent.Bundle, bool)`](DateGameContent.cs.md#symbol-a56139e0281f)；`NationalSpire.DateGameRule.DateGameRule()`；[`NationalSpire.DateGames.UpgradeRules(System.Collections.Generic.IEnumerable<NationalSpire.DateGameRule>)`](DateGames.cs.md#symbol-c824a5233693)；`System.Array.IndexOf<T>(T[], T)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.Text.Json.JsonElement.GetString()`；`System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.DateGameRules`；`NationalSpire.CareerData.DateGameTiming`；`NationalSpire.CareerData.DateGameVoiceEdits`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.DateGameContent.Apply(NationalSpire.CareerData, NationalSpire.DateGameContent.Bundle)`；`NationalSpire.DateGameContent.Bundle.Catalog`；`NationalSpire.DateGameContent.Bundle.Conditions`；`NationalSpire.DateGameContent.Bundle.Profiles`；`NationalSpire.DateGameContent.Bundle.Rules`；`NationalSpire.DateGameContent.Bundle.Timing`；`NationalSpire.DateGameContent.Catalog`；`NationalSpire.DateGameContent.Edits(string, NationalSpire.DateGameContent.Profile, System.Collections.Generic.Dictionary<string, NationalSpire.DateGameContent.Phrase>, System.Collections.Generic.List<NationalSpire.DateGameRule>)`；`NationalSpire.DateGameContent.Json`；`NationalSpire.DateGameContent.Parse(string)`；`NationalSpire.DateGameContent.Profile.Triggers`；`NationalSpire.DateGameContent.Read(string)`；`NationalSpire.DateGameContent.RuleFile.Conditions`；`NationalSpire.DateGameContent.RuleFile.Rules`；`NationalSpire.DateGameContent.RuleFile.Timing`；`NationalSpire.DateGameContent.RuleFile.Version`；`NationalSpire.DateGameContent.RuleSetting.Chat`；`NationalSpire.DateGameContent.RuleSetting.Enabled`；`NationalSpire.DateGameContent.RuleSetting.Lines`；`NationalSpire.DateGameContent.RuleSetting.Threshold`；`NationalSpire.DateGameContent.RuleSetting.Trigger`；`NationalSpire.DateGameContent.Validate(NationalSpire.DateGameContent.Bundle, bool)`；`NationalSpire.DateGameContent.VoiceFile.Catalog`；`NationalSpire.DateGameContent.VoiceFile.Personality`；`NationalSpire.DateGameContent.VoiceFile.Profile`；`NationalSpire.DateGameContent.VoiceFile.Version`；`NationalSpire.DateGameRule.Chat`；`NationalSpire.DateGameRule.Enabled`；`NationalSpire.DateGameRule.Lines`；`NationalSpire.DateGameRule.Threshold`；`NationalSpire.DateGameRule.Trigger`；`NationalSpire.DateGameVoices.Ids`；`NationalSpire.DateGameVoices.Labels`；`NationalSpire.DateGames.UpgradeRules(System.Collections.Generic.IEnumerable<NationalSpire.DateGameRule>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`Coop.CoopJson.Copy(file.Timing)`；返回值紧邻使用处：`AssignmentExpressionSyntax: data.DateGameTiming = Coop.CoopJson.Copy(file.Timing)`
- `NationalSpire.DateGameContent.Apply(NationalSpire.CareerData, NationalSpire.DateGameContent.Bundle)`；输入表达式：`Apply(data, Read(text))`；返回值紧邻使用处：`ExpressionStatementSyntax: Apply(data, Read(text));`
- `NationalSpire.DateGameContent.Bundle.Bundle()`；输入表达式：`new Bundle { Rules = DateGames.UpgradeRules(data.DateGameRules), Catalog = file.Catalog, Profiles = new() { [file.Personality] = file.Profile } }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Bundle { Rules = DateGames.UpgradeRules(data.DateGameRules), Catalog = file.Catalog, Profiles = new() { [file.Personality] = file.Profile } }`
- `NationalSpire.DateGameContent.Bundle.Bundle()`；输入表达式：`new() { Rules = rules, Timing = file.Timing, Conditions = file.Conditions, Catalog = Catalog.Value }`；返回值紧邻使用处：`ArgumentSyntax: new() { Rules = rules, Timing = file.Timing, Conditions = file.Conditions, Catalog = Catalog.Value }`
- `NationalSpire.DateGameContent.Edits(string, NationalSpire.DateGameContent.Profile, System.Collections.Generic.Dictionary<string, NationalSpire.DateGameContent.Phrase>, System.Collections.Generic.List<NationalSpire.DateGameRule>)`；输入表达式：`Edits(file.Personality, file.Profile, file.Catalog, bundle.Rules)`；返回值紧邻使用处：`AssignmentExpressionSyntax: data.DateGameVoiceEdits[file.Personality] = Edits(file.Personality, file.Profile, file.Catalog, bundle.Rules)`
- `NationalSpire.DateGameContent.Parse(string)`；输入表达式：`Parse(text)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Parse(text)`
- `NationalSpire.DateGameContent.Read(string)`；输入表达式：`Read(text)`；返回值紧邻使用处：`ArgumentSyntax: Read(text)`
- `NationalSpire.DateGameContent.Validate(NationalSpire.DateGameContent.Bundle, bool)`；输入表达式：`Validate(bundle, partial: true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Validate(bundle, partial: true);`
- `NationalSpire.DateGameContent.Validate(NationalSpire.DateGameContent.Bundle, bool)`；输入表达式：`Validate(new() { Rules = rules, Timing = file.Timing, Conditions = file.Conditions, Catalog = Catalog.Value }, partial: true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Validate(new() { Rules = rules, Timing = file.Timing, Conditions = file.Conditions, Catalog = Catalog.Value }, partial: true);`
- `NationalSpire.DateGameRule.DateGameRule()`；输入表达式：`new DateGameRule { Trigger = r.Trigger, Enabled = r.Enabled, Chat = r.Chat, Threshold = r.Threshold, Lines = r.Lines?.ToList() ?? current.GetValueOrDefault(r.Trigger)?.Lines.ToList() ?? [] }`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: r => new DateGameRule { Trigger = r.Trigger, Enabled = r.Enabled, Chat = r.Chat, Threshold = r.Threshold, Lines = r.Lines?.ToList() ?? current.GetValueOrDefault(r.Trigger)?.Lines.ToList() ?? [] }`
- `NationalSpire.DateGames.UpgradeRules(System.Collections.Generic.IEnumerable<NationalSpire.DateGameRule>)`；输入表达式：`DateGames.UpgradeRules(data.DateGameRules)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Rules = DateGames.UpgradeRules(data.DateGameRules)`
- `NationalSpire.DateGames.UpgradeRules(System.Collections.Generic.IEnumerable<NationalSpire.DateGameRule>)`；输入表达式：`DateGames.UpgradeRules(data.DateGameRules)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateGames.UpgradeRules(data.DateGameRules).ToDictionary`
- `System.Array.IndexOf<T>(T[], T)`；输入表达式：`Array.IndexOf(DateGameVoices.Ids, file.Personality)`；返回值紧邻使用处：`ArgumentSyntax: Array.IndexOf(DateGameVoices.Ids, file.Personality)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new() { [file.Personality] = file.Profile }`；返回值紧邻使用处：`AssignmentExpressionSyntax: Profiles = new() { [file.Personality] = file.Profile }`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`file.Rules.Any(r => r == null || (file.Version == 1 ? r.Lines == null : r.Lines != null))`；返回值紧邻使用处：`BinaryExpressionSyntax: file.Version is not (1 or 2) || file.Rules == null || file.Rules.Any(r => r == null || (file.Version == 1 ? r.Lines == null : r.Lines != null))`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`DateGameVoices.Ids.Contains(file.Personality)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !DateGameVoices.Ids.Contains(file.Personality)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`file.Rules.Select(r => new DateGameRule { Trigger = r.Trigger, Enabled = r.Enabled, Chat = r.Chat, Threshold = r.Threshold, Lines = r.Lines?.ToList() ?? current.GetValueOrDefault(r.Trigger)?.Lines.ToList() ?? [] })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: file.Rules.Select(r => new DateGameRule { Trigger = r.Trigger, Enabled = r.Enabled, Chat = r.Chat, Threshold = r.Threshold, Lines = r.Lines?.ToList() ?? current.GetValueOrDefault(r.Trigger)?.Lines.ToList() ?? [] }).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`DateGames.UpgradeRules(data.DateGameRules).ToDictionary(r => r.Trigger)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateGames.UpgradeRules(data.DateGameRules).ToDictionary(r => r.Trigger)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`.Lines.ToList()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: current.GetValueOrDefault(r.Trigger)?.Lines.ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`.ToList()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: r.Lines?.ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`file.Rules.Select(r => new DateGameRule { Trigger = r.Trigger, Enabled = r.Enabled, Chat = r.Chat, Threshold = r.Threshold, Lines = r.Lines?.ToList() ?? current.GetValueOrDefault(r.Trigger)?.Lines.ToList() ?? [] }).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = file.Rules.Select(r => new DateGameRule { Trigger = r.Trigger, Enabled = r.Enabled, Chat = r.Chat, Threshold = r.Threshold, Lines = r.Lines?.ToList() ?? current.GetValueOrDefault(r.Trigger)?.Lines.ToList() ?? [] }).ToList()`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`current.GetValueOrDefault(r.Trigger)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: current.GetValueOrDefault(r.Trigger)?.Lines.ToList()`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("性格文件版本或编号无效。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("性格文件版本或编号无效。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("性格文件需保留全部十种事件的触发编号及候选台词。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("性格文件需保留全部十种事件的触发编号及候选台词。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("触发规则文件版本或字段无效。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("触发规则文件版本或字段无效。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("请选择对局发言性格文件或公共触发条件文件。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("请选择对局发言性格文件或公共触发条件文件。");`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`field.GetString()`；返回值紧邻使用处：`ConditionalExpressionSyntax: document.RootElement.TryGetProperty("format", out var field) ? field.GetString() : null`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`document.RootElement.TryGetProperty("format", out var field)`；返回值紧邻使用处：`ConditionalExpressionSyntax: document.RootElement.TryGetProperty("format", out var field) ? field.GetString() : null`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<RuleFile>(text, Json)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: JsonSerializer.Deserialize<RuleFile>(text, Json)!`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<VoiceFile>(text, Json)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: JsonSerializer.Deserialize<VoiceFile>(text, Json)!`

**赋值（含属性/字段和局部值）：**

- `Catalog` = `Catalog.Value`
- `Catalog` = `file.Catalog`
- `Chat` = `r.Chat`
- `Conditions` = `file.Conditions`
- `Enabled` = `r.Enabled`
- `Lines` = `r.Lines?.ToList() ?? current.GetValueOrDefault(r.Trigger)?.Lines.ToList() ?? []`
- `Profiles` = `new() { [file.Personality] = file.Profile }`
- `Rules` = `DateGames.UpgradeRules(data.DateGameRules)`
- `Rules` = `rules`
- `Threshold` = `r.Threshold`
- `Timing` = `file.Timing`
- `Trigger` = `r.Trigger`
- `[file.Personality]` = `file.Profile`
- `data.DateGameRules` = `rules`
- `data.DateGameTiming` = `Coop.CoopJson.Copy(file.Timing)`
- `data.DateGameVoiceEdits[file.Personality]` = `Edits(file.Personality, file.Profile, file.Catalog, bundle.Rules)`

<a id="symbol-95c897dc6ef5"></a>

## `NationalSpire.DateGameContent.CheckDuplicateKeys(System.Text.Json.JsonElement) — private static void CheckDuplicateKeys(JsonElement element)`

来源：源码第 188 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGameContent.CheckDuplicateKeys(System.Text.Json.JsonElement)`](DateGameContent.cs.md#symbol-95c897dc6ef5)；[`NationalSpire.DateGameContent.Parse(string)`](DateGameContent.cs.md#symbol-2749e1ca3d2d)

**调用：** [`NationalSpire.DateGameContent.CheckDuplicateKeys(System.Text.Json.JsonElement)`](DateGameContent.cs.md#symbol-95c897dc6ef5)；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.HashSet(System.Collections.Generic.IEqualityComparer<T>?)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.Text.Json.JsonElement.EnumerateArray()`；`System.Text.Json.JsonElement.EnumerateObject()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateGameContent.CheckDuplicateKeys(System.Text.Json.JsonElement)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGameContent.CheckDuplicateKeys(System.Text.Json.JsonElement)`；输入表达式：`CheckDuplicateKeys(field.Value)`；返回值紧邻使用处：`ExpressionStatementSyntax: CheckDuplicateKeys(field.Value);`
- `NationalSpire.DateGameContent.CheckDuplicateKeys(System.Text.Json.JsonElement)`；输入表达式：`CheckDuplicateKeys(item)`；返回值紧邻使用处：`ExpressionStatementSyntax: CheckDuplicateKeys(item);`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`names.Add(field.Name)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !names.Add(field.Name)`
- `System.Collections.Generic.HashSet<T>.HashSet(System.Collections.Generic.IEqualityComparer<T>?)`；输入表达式：`new HashSet<string>(StringComparer.Ordinal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HashSet<string>(StringComparer.Ordinal)`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("文件中有重复字段：" + field.Name)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("文件中有重复字段：" + field.Name);`
- `System.Text.Json.JsonElement.EnumerateArray()`；输入表达式：`element.EnumerateArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var item in element.EnumerateArray()) CheckDuplicateKeys(item);`
- `System.Text.Json.JsonElement.EnumerateObject()`；输入表达式：`element.EnumerateObject()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var field in element.EnumerateObject()) { if (!names.Add(field.Name)) throw new InvalidDataException("文件中有重复字段：" + field.Name); CheckDuplicateKeys(field.Value); }`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a56139e0281f"></a>

## `NationalSpire.DateGameContent.Validate(NationalSpire.DateGameContent.Bundle, bool) — public static void Validate(Bundle bundle, bool partial = false)`

来源：源码第 201 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGameContent.Apply(NationalSpire.CareerData, NationalSpire.DateGameContent.Bundle)`](DateGameContent.cs.md#symbol-5a89da7cbb82)；[`NationalSpire.DateGameContent.Files(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.DateGameRule>?)`](DateGameContent.cs.md#symbol-c778174ab92f)；[`NationalSpire.DateGameContent.Import(NationalSpire.CareerData, string)`](DateGameContent.cs.md#symbol-2c2e135d0e20)；[`NationalSpire.DateGameContent.Read(string)`](DateGameContent.cs.md#symbol-ad02667b222b)

**调用：** [`NationalSpire.DateGameContent.Key(string)`](DateGameContent.cs.md#symbol-04fef069e286)；[`NationalSpire.DateGameContent.Variables(string)`](DateGameContent.cs.md#symbol-b357dc27bdfb)；[`NationalSpire.DateGames.Defaults()`](DateGames.cs.md#symbol-f6f62ee5a1dd)；[`Require(bool, string)`](DateGameContent.cs.md#symbol-a08f08e275d3)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.HashSet<T>.Remove(T)`；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SequenceEqual<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Text.RegularExpressions.Regex.Replace(string, string, string)`；`double.IsFinite(double)`；`string.Contains(char)`；`string.IndexOfAny(char[])`；`string.IsNullOrWhiteSpace(string?)`；`string.StartsWith(string, System.StringComparison)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateGameContent.Bundle.Catalog`；`NationalSpire.DateGameContent.Bundle.Conditions`；`NationalSpire.DateGameContent.Bundle.Format`；`NationalSpire.DateGameContent.Bundle.Profiles`；`NationalSpire.DateGameContent.Bundle.Rules`；`NationalSpire.DateGameContent.Bundle.Timing`；`NationalSpire.DateGameContent.Bundle.Version`；`NationalSpire.DateGameContent.Catalog`；`NationalSpire.DateGameContent.Key(string)`；`NationalSpire.DateGameContent.Phrase.Context`；`NationalSpire.DateGameContent.Phrase.Text`；`NationalSpire.DateGameContent.Profile.Lines`；`NationalSpire.DateGameContent.Profile.Remarks`；`NationalSpire.DateGameContent.Profile.Triggers`；`NationalSpire.DateGameContent.TriggerSpeech.Lines`；`NationalSpire.DateGameContent.Variables(string)`；`NationalSpire.DateGameRule.Enabled`；`NationalSpire.DateGameRule.Lines`；`NationalSpire.DateGameRule.Threshold`；`NationalSpire.DateGameRule.Trigger`；`NationalSpire.DateGameTiming.ChatSeconds`；`NationalSpire.DateGameTiming.FastMinimumFloor`；`NationalSpire.DateGameTiming.SpeechSeconds`；`NationalSpire.DateGameVoices.Ids`；`NationalSpire.DateGameVoices.Remarks`；`NationalSpire.DateGames.Defaults()`；`Require(bool, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGameContent.Key(string)`；输入表达式：`Key(phrase.Text)`；返回值紧邻使用处：`BinaryExpressionSyntax: key == Key(phrase.Text)`
- `NationalSpire.DateGameContent.Variables(string)`；输入表达式：`Variables(bundle.Catalog[key].Text)`；返回值紧邻使用处：`ArgumentSyntax: Variables(bundle.Catalog[key].Text)`
- `NationalSpire.DateGameContent.Variables(string)`；输入表达式：`Variables(line!)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Variables(line!).SequenceEqual`
- `NationalSpire.DateGames.Defaults()`；输入表达式：`DateGames.Defaults()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateGames.Defaults().Select`
- `Require(bool, string)`；输入表达式：`Require(!string.IsNullOrWhiteSpace(line) && line.Length <= 1000 && !line.Contains('{') && !line.Contains('}'), "事件台词需为1～1000字的普通文本：" + rule.Trigger)`；返回值紧邻使用处：`ExpressionStatementSyntax: Require(!string.IsNullOrWhiteSpace(line) && line.Length <= 1000 && !line.Contains('{') && !line.Contains('}'), "事件台词需为1～1000字的普通文本：" + rule.Trigger);`
- `Require(bool, string)`；输入表达式：`Require(!string.IsNullOrWhiteSpace(line) && line.Length <= 4000 && !line.Contains('{') && !line.Contains('}'), "事件台词需为1～4000字的普通文本：" + id + "/" + trigger)`；返回值紧邻使用处：`ExpressionStatementSyntax: Require(!string.IsNullOrWhiteSpace(line) && line.Length <= 4000 && !line.Contains('{') && !line.Contains('}'), "事件台词需为1～4000字的普通文本：" + id + "/" + trigger);`
- `Require(bool, string)`；输入表达式：`Require(Catalog.Value.Keys.All(bundle.Catalog.ContainsKey), "文件缺少当前版本台词。请重新导出完整文件再编辑。")`；返回值紧邻使用处：`ExpressionStatementSyntax: Require(Catalog.Value.Keys.All(bundle.Catalog.ContainsKey), "文件缺少当前版本台词。请重新导出完整文件再编辑。");`
- `Require(bool, string)`；输入表达式：`Require(Variables(line!).SequenceEqual(Variables(bundle.Catalog[key].Text)) && Regex.Replace(line!, @"\{[^{}]+\}", "").IndexOfAny(['{', '}']) < 0, "请保留原句中花括号及其中的名称：" + id + "/" + key)`；返回值紧邻使用处：`ExpressionStatementSyntax: Require(Variables(line!).SequenceEqual(Variables(bundle.Catalog[key].Text)) && Regex.Replace(line!, @"\{[^{}]+\}", "").IndexOfAny(['{', '}']) < 0, "请保留原句中花括号及其中的名称：" + id + "/" + key);`
- `Require(bool, string)`；输入表达式：`Require(bundle.Catalog!.Count <= Catalog.Value.Count + 800, "条目数量超出范围。")`；返回值紧邻使用处：`ExpressionStatementSyntax: Require(bundle.Catalog!.Count <= Catalog.Value.Count + 800, "条目数量超出范围。");`
- `Require(bool, string)`；输入表达式：`Require(bundle.Format == "national-spire-date-game-content" && bundle.Version == 2, "请选择当前版本的约会对局内容。")`；返回值紧邻使用处：`ExpressionStatementSyntax: Require(bundle.Format == "national-spire-date-game-content" && bundle.Version == 2, "请选择当前版本的约会对局内容。");`
- `Require(bool, string)`；输入表达式：`Require(bundle.Rules!.Count == triggers.Count && bundle.Rules.All(r => r != null && triggers.Remove(r.Trigger)) && triggers.Count == 0, "请保留十种事件的原编号，每种出现一次。")`；返回值紧邻使用处：`ExpressionStatementSyntax: Require(bundle.Rules!.Count == triggers.Count && bundle.Rules.All(r => r != null && triggers.Remove(r.Trigger)) && triggers.Count == 0, "请保留十种事件的原编号，每种出现一次。");`
- `Require(bool, string)`；输入表达式：`Require(bundle.Timing != null && bundle.Rules != null && bundle.Profiles != null && bundle.Catalog != null && bundle.Conditions != null, "文件缺少完整的规则或台词内容。")`；返回值紧邻使用处：`ExpressionStatementSyntax: Require(bundle.Timing != null && bundle.Rules != null && bundle.Profiles != null && bundle.Catalog != null && bundle.Conditions != null, "文件缺少完整的规则或台词内容。");`
- `Require(bool, string)`；输入表达式：`Require(double.IsFinite(rule.Threshold) && rule.Threshold is >= 0 and <= 3600, "事件阈值需在0～3600之间：" + rule.Trigger)`；返回值紧邻使用处：`ExpressionStatementSyntax: Require(double.IsFinite(rule.Threshold) && rule.Threshold is >= 0 and <= 3600, "事件阈值需在0～3600之间：" + rule.Trigger);`
- `Require(bool, string)`；输入表达式：`Require(line != null && line.Length <= 1000 && !line.Contains('{') && !line.Contains('}'), "性格补句请使用1000字以内的普通文本，可留空。")`；返回值紧邻使用处：`ExpressionStatementSyntax: Require(line != null && line.Length <= 1000 && !line.Contains('{') && !line.Contains('}'), "性格补句请使用1000字以内的普通文本，可留空。");`
- `Require(bool, string)`；输入表达式：`Require(line != null && line.Length <= 4000 && !string.IsNullOrWhiteSpace(line), "台词需为1～4000字：" + id + "/" + key)`；返回值紧邻使用处：`ExpressionStatementSyntax: Require(line != null && line.Length <= 4000 && !string.IsNullOrWhiteSpace(line), "台词需为1～4000字：" + id + "/" + key);`
- `Require(bool, string)`；输入表达式：`Require(new[] { timing.SpeechSeconds, timing.ChatSeconds }.All(v => double.IsFinite(v) && v >= 0 && v <= 3600) && timing.FastMinimumFloor is >= 20 and <= 999, "间隔需在0～3600秒之间，快速推进起始楼层需在20～999之间。")`；返回值紧邻使用处：`ExpressionStatementSyntax: Require(new[] { timing.SpeechSeconds, timing.ChatSeconds }.All(v => double.IsFinite(v) && v >= 0 && v <= 3600) && timing.FastMinimumFloor is >= 20 and <= 999, "间隔需在0～3600秒之间，快速推进起始楼层需在20～999之间。");`
- `Require(bool, string)`；输入表达式：`Require(partial ? bundle.Profiles!.Keys.All(DateGameVoices.Ids.Contains) : bundle.Profiles!.Count == DateGameVoices.Ids.Length && DateGameVoices.Ids.All(bundle.Profiles.ContainsKey), "台词版本编号不完整或无效。")`；返回值紧邻使用处：`ExpressionStatementSyntax: Require(partial ? bundle.Profiles!.Keys.All(DateGameVoices.Ids.Contains) : bundle.Profiles!.Count == DateGameVoices.Ids.Length && DateGameVoices.Ids.All(bundle.Profiles.ContainsKey), "台词版本编号不完整或无效。");`
- `Require(bool, string)`；输入表达式：`Require(phrase != null && phrase.Text != null && key == Key(phrase.Text) && phrase.Text.Length <= 4000 && (Catalog.Value.ContainsKey(key) || phrase.Context?.StartsWith("请求或事件台词：", StringComparison.Ordinal) == true), "条目编号或原文已改变，请只编辑profiles中的台词：" + key)`；返回值紧邻使用处：`ExpressionStatementSyntax: Require(phrase != null && phrase.Text != null && key == Key(phrase.Text) && phrase.Text.Length <= 4000 && (Catalog.Value.ContainsKey(key) || phrase.Context?.StartsWith("请求或事件台词：", StringComparison.Ordinal) == true), "条目编号或原文已改变，请只编辑profiles中的台词：" + key);`
- `Require(bool, string)`；输入表达式：`Require(profile != null && profile.Lines != null && profile.Remarks != null && profile.Triggers != null, "台词版本内容不完整：" + id)`；返回值紧邻使用处：`ExpressionStatementSyntax: Require(profile != null && profile.Lines != null && profile.Remarks != null && profile.Triggers != null, "台词版本内容不完整：" + id);`
- `Require(bool, string)`；输入表达式：`Require(profile!.Lines!.Count == bundle.Catalog.Count && bundle.Catalog.Keys.All(profile.Lines.ContainsKey), "请保留全部台词编号：" + id)`；返回值紧邻使用处：`ExpressionStatementSyntax: Require(profile!.Lines!.Count == bundle.Catalog.Count && bundle.Catalog.Keys.All(profile.Lines.ContainsKey), "请保留全部台词编号：" + id);`
- `Require(bool, string)`；输入表达式：`Require(profile.Remarks!.Count == DateGameVoices.Remarks.Count && DateGameVoices.Remarks.Keys.All(profile.Remarks.ContainsKey), "请保留全部性格补句类别：" + id)`；返回值紧邻使用处：`ExpressionStatementSyntax: Require(profile.Remarks!.Count == DateGameVoices.Remarks.Count && DateGameVoices.Remarks.Keys.All(profile.Remarks.ContainsKey), "请保留全部性格补句类别：" + id);`
- `Require(bool, string)`；输入表达式：`Require(profile.Triggers!.Keys.All(key => bundle.Rules.Any(r => r.Trigger == key)), "事件台词包含未知触发编号：" + id)`；返回值紧邻使用处：`ExpressionStatementSyntax: Require(profile.Triggers!.Keys.All(key => bundle.Rules.Any(r => r.Trigger == key)), "事件台词包含未知触发编号：" + id);`
- `Require(bool, string)`；输入表达式：`Require(rule.Lines != null && rule.Lines.Count <= 100 && (!rule.Enabled || rule.Lines.Count > 0), "启用的事件需要1～100句台词：" + rule.Trigger)`；返回值紧邻使用处：`ExpressionStatementSyntax: Require(rule.Lines != null && rule.Lines.Count <= 100 && (!rule.Enabled || rule.Lines.Count > 0), "启用的事件需要1～100句台词：" + rule.Trigger);`
- `Require(bool, string)`；输入表达式：`Require(speech != null && speech.Lines != null && speech.Lines.Count <= 100 && (!bundle.Rules.Single(r => r.Trigger == trigger).Enabled || speech.Lines.Count > 0), "启用的事件需要1～100句性格台词：" + id + "/" + trigger)`；返回值紧邻使用处：`ExpressionStatementSyntax: Require(speech != null && speech.Lines != null && speech.Lines.Count <= 100 && (!bundle.Rules.Single(r => r.Trigger == trigger).Enabled || speech.Lines.Count > 0), "启用的事件需要1～100句性格台词：" + id + "/" + trigger);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`Catalog.Value.ContainsKey(key)`；返回值紧邻使用处：`BinaryExpressionSyntax: Catalog.Value.ContainsKey(key) || phrase.Context?.StartsWith("请求或事件台词：", StringComparison.Ordinal) == true`
- `System.Collections.Generic.HashSet<T>.Remove(T)`；输入表达式：`triggers.Remove(r.Trigger)`；返回值紧邻使用处：`BinaryExpressionSyntax: r != null && triggers.Remove(r.Trigger)`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`Catalog.Value.Keys.All(bundle.Catalog.ContainsKey)`；返回值紧邻使用处：`ArgumentSyntax: Catalog.Value.Keys.All(bundle.Catalog.ContainsKey)`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`DateGameVoices.Ids.All(bundle.Profiles.ContainsKey)`；返回值紧邻使用处：`BinaryExpressionSyntax: bundle.Profiles!.Count == DateGameVoices.Ids.Length && DateGameVoices.Ids.All(bundle.Profiles.ContainsKey)`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`DateGameVoices.Remarks.Keys.All(profile.Remarks.ContainsKey)`；返回值紧邻使用处：`BinaryExpressionSyntax: profile.Remarks!.Count == DateGameVoices.Remarks.Count && DateGameVoices.Remarks.Keys.All(profile.Remarks.ContainsKey)`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`bundle.Catalog.Keys.All(profile.Lines.ContainsKey)`；返回值紧邻使用处：`BinaryExpressionSyntax: profile!.Lines!.Count == bundle.Catalog.Count && bundle.Catalog.Keys.All(profile.Lines.ContainsKey)`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`bundle.Profiles!.Keys.All(DateGameVoices.Ids.Contains)`；返回值紧邻使用处：`ConditionalExpressionSyntax: partial ? bundle.Profiles!.Keys.All(DateGameVoices.Ids.Contains) : bundle.Profiles!.Count == DateGameVoices.Ids.Length && DateGameVoices.Ids.All(bundle.Profiles.ContainsKey)`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`bundle.Rules.All(r => r != null && triggers.Remove(r.Trigger))`；返回值紧邻使用处：`BinaryExpressionSyntax: bundle.Rules!.Count == triggers.Count && bundle.Rules.All(r => r != null && triggers.Remove(r.Trigger))`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`new[] { timing.SpeechSeconds, timing.ChatSeconds }.All(v => double.IsFinite(v) && v >= 0 && v <= 3600)`；返回值紧邻使用处：`BinaryExpressionSyntax: new[] { timing.SpeechSeconds, timing.ChatSeconds }.All(v => double.IsFinite(v) && v >= 0 && v <= 3600) && timing.FastMinimumFloor is >= 20 and <= 999`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`profile.Triggers!.Keys.All(key => bundle.Rules.Any(r => r.Trigger == key))`；返回值紧邻使用处：`ArgumentSyntax: profile.Triggers!.Keys.All(key => bundle.Rules.Any(r => r.Trigger == key))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`bundle.Rules.Any(r => r.Trigger == key)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: key => bundle.Rules.Any(r => r.Trigger == key)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`DateGames.Defaults().Select(r => r.Trigger)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateGames.Defaults().Select(r => r.Trigger).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.SequenceEqual<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`Variables(line!).SequenceEqual(Variables(bundle.Catalog[key].Text))`；返回值紧邻使用处：`BinaryExpressionSyntax: Variables(line!).SequenceEqual(Variables(bundle.Catalog[key].Text)) && Regex.Replace(line!, @"\{[^{}]+\}", "").IndexOfAny(['{', '}']) < 0`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`bundle.Rules.Single(r => r.Trigger == trigger)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: bundle.Rules.Single(r => r.Trigger == trigger).Enabled`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`DateGames.Defaults().Select(r => r.Trigger).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateGames.Defaults().Select(r => r.Trigger).ToHashSet()`
- `System.Text.RegularExpressions.Regex.Replace(string, string, string)`；输入表达式：`Regex.Replace(line!, @"\{[^{}]+\}", "")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Regex.Replace(line!, @"\{[^{}]+\}", "").IndexOfAny`
- `double.IsFinite(double)`；输入表达式：`double.IsFinite(rule.Threshold)`；返回值紧邻使用处：`BinaryExpressionSyntax: double.IsFinite(rule.Threshold) && rule.Threshold is >= 0 and <= 3600`
- `double.IsFinite(double)`；输入表达式：`double.IsFinite(v)`；返回值紧邻使用处：`BinaryExpressionSyntax: double.IsFinite(v) && v >= 0`
- `string.Contains(char)`；输入表达式：`line.Contains('{')`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !line.Contains('{')`
- `string.Contains(char)`；输入表达式：`line.Contains('}')`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !line.Contains('}')`
- `string.IndexOfAny(char[])`；输入表达式：`Regex.Replace(line!, @"\{[^{}]+\}", "").IndexOfAny(['{', '}'])`；返回值紧邻使用处：`BinaryExpressionSyntax: Regex.Replace(line!, @"\{[^{}]+\}", "").IndexOfAny(['{', '}']) < 0`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(line)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !string.IsNullOrWhiteSpace(line)`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`.StartsWith("请求或事件台词：", StringComparison.Ordinal)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: phrase.Context?.StartsWith("请求或事件台词：", StringComparison.Ordinal)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a08f08e275d3"></a>

## `Require(bool, string) — void Require(bool condition, string message)`

来源：源码第 203 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGameContent.Validate(NationalSpire.DateGameContent.Bundle, bool)`](DateGameContent.cs.md#symbol-a56139e0281f)

**调用：** `System.IO.InvalidDataException.InvalidDataException(string?)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException(message)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException(message);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-608ae4848093"></a>

## `NationalSpire.DateGameContent.Edits(string, NationalSpire.DateGameContent.Profile, System.Collections.Generic.Dictionary<string, NationalSpire.DateGameContent.Phrase>, System.Collections.Generic.List<NationalSpire.DateGameRule>) — private static DateVoiceEdits Edits(string id, Profile profile, Dictionary<string, Phrase> catalog, List<DateGameRule> rules)`

来源：源码第 245 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGameContent.Apply(NationalSpire.CareerData, NationalSpire.DateGameContent.Bundle)`](DateGameContent.cs.md#symbol-5a89da7cbb82)；[`NationalSpire.DateGameContent.Import(NationalSpire.CareerData, string)`](DateGameContent.cs.md#symbol-2c2e135d0e20)

**调用：** `NationalSpire.CareerData.CareerData()`；[`NationalSpire.DateGameContent.DefaultRemarks(string)`](DateGameContent.cs.md#symbol-bb442b479ffc)；[`NationalSpire.DateGameVoices.EventLines(NationalSpire.CareerData, string, NationalSpire.DateGameRule)`](DateGameVoices.cs.md#symbol-036aa782750d)；`NationalSpire.DateVoiceEdits.DateVoiceEdits()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>.ToDictionary<TKey, TValue>()`；`System.Collections.Generic.IEnumerable<TSource>.SequenceEqual<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.DateGameVoiceEdits`；`NationalSpire.DateGameContent.DefaultRemarks(string)`；`NationalSpire.DateGameContent.Phrase.Text`；`NationalSpire.DateGameContent.Profile.Lines`；`NationalSpire.DateGameContent.Profile.Remarks`；`NationalSpire.DateGameContent.Profile.Triggers`；`NationalSpire.DateGameContent.TriggerSpeech.Lines`；`NationalSpire.DateGameRule.Trigger`；`NationalSpire.DateGameVoices.EventLines(NationalSpire.CareerData, string, NationalSpire.DateGameRule)`；`NationalSpire.DateVoiceEdits.Lines`；`NationalSpire.DateVoiceEdits.Remarks`；`NationalSpire.DateVoiceEdits.Triggers`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerData.CareerData()`；输入表达式：`new CareerData { DateGameVoiceEdits = new() { [id] = edits } }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CareerData { DateGameVoiceEdits = new() { [id] = edits } }`
- `NationalSpire.DateGameContent.DefaultRemarks(string)`；输入表达式：`DefaultRemarks(id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DefaultRemarks(id)`
- `NationalSpire.DateGameVoices.EventLines(NationalSpire.CareerData, string, NationalSpire.DateGameRule)`；输入表达式：`DateGameVoices.EventLines(baseline, id, rules.Single(r => r.Trigger == trigger))`；返回值紧邻使用处：`ArgumentSyntax: DateGameVoices.EventLines(baseline, id, rules.Single(r => r.Trigger == trigger))`
- `NationalSpire.DateVoiceEdits.DateVoiceEdits()`；输入表达式：`new DateVoiceEdits { Lines = profile.Lines.Where(p => p.Value != catalog[p.Key].Text).ToDictionary(), Remarks = profile.Remarks.Where(p => p.Value != defaults[p.Key]).ToDictionary() }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new DateVoiceEdits { Lines = profile.Lines.Where(p => p.Value != catalog[p.Key].Text).ToDictionary(), Remarks = profile.Remarks.Where(p => p.Value != defaults[p.Key]).ToDictionary() }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new() { [id] = edits }`；返回值紧邻使用处：`AssignmentExpressionSyntax: DateGameVoiceEdits = new() { [id] = edits }`
- `System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>.ToDictionary<TKey, TValue>()`；输入表达式：`profile.Lines.Where(p => p.Value != catalog[p.Key].Text).ToDictionary()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Lines = profile.Lines.Where(p => p.Value != catalog[p.Key].Text).ToDictionary()`
- `System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>.ToDictionary<TKey, TValue>()`；输入表达式：`profile.Remarks.Where(p => p.Value != defaults[p.Key]).ToDictionary()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Remarks = profile.Remarks.Where(p => p.Value != defaults[p.Key]).ToDictionary()`
- `System.Collections.Generic.IEnumerable<TSource>.SequenceEqual<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`speech.Lines.SequenceEqual(DateGameVoices.EventLines(baseline, id, rules.Single(r => r.Trigger == trigger)))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !speech.Lines.SequenceEqual(DateGameVoices.EventLines(baseline, id, rules.Single(r => r.Trigger == trigger)))`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`rules.Single(r => r.Trigger == trigger)`；返回值紧邻使用处：`ArgumentSyntax: rules.Single(r => r.Trigger == trigger)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`speech.Lines.ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: edits.Triggers[trigger] = speech.Lines.ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`profile.Lines.Where(p => p.Value != catalog[p.Key].Text)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: profile.Lines.Where(p => p.Value != catalog[p.Key].Text).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`profile.Remarks.Where(p => p.Value != defaults[p.Key])`；返回值紧邻使用处：`MemberAccessExpressionSyntax: profile.Remarks.Where(p => p.Value != defaults[p.Key]).ToDictionary`

**赋值（含属性/字段和局部值）：**

- `DateGameVoiceEdits` = `new() { [id] = edits }`
- `Lines` = `profile.Lines.Where(p => p.Value != catalog[p.Key].Text).ToDictionary()`
- `Remarks` = `profile.Remarks.Where(p => p.Value != defaults[p.Key]).ToDictionary()`
- `[id]` = `edits`
- `edits.Triggers[trigger]` = `speech.Lines.ToList()`

<a id="symbol-5a89da7cbb82"></a>

## `NationalSpire.DateGameContent.Apply(NationalSpire.CareerData, NationalSpire.DateGameContent.Bundle) — public static void Apply(CareerData data, Bundle bundle)`

来源：源码第 256 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.EditDateGameRules()`](DateGameScreen.cs.md#symbol-0a1b70a243b1)；[`NationalSpire.DateGameContent.Import(NationalSpire.CareerData, string)`](DateGameContent.cs.md#symbol-2c2e135d0e20)

**调用：** [`NationalSpire.Coop.CoopJson.Copy<T>(T)`](Coop/CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.DateGameContent.Edits(string, NationalSpire.DateGameContent.Profile, System.Collections.Generic.Dictionary<string, NationalSpire.DateGameContent.Phrase>, System.Collections.Generic.List<NationalSpire.DateGameRule>)`](DateGameContent.cs.md#symbol-608ae4848093)；[`NationalSpire.DateGameContent.Validate(NationalSpire.DateGameContent.Bundle, bool)`](DateGameContent.cs.md#symbol-a56139e0281f)；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.DateGameRules`；`NationalSpire.CareerData.DateGameTiming`；`NationalSpire.CareerData.DateGameVoiceEdits`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.DateGameContent.Bundle.Catalog`；`NationalSpire.DateGameContent.Bundle.Profiles`；`NationalSpire.DateGameContent.Bundle.Rules`；`NationalSpire.DateGameContent.Bundle.Timing`；`NationalSpire.DateGameContent.Edits(string, NationalSpire.DateGameContent.Profile, System.Collections.Generic.Dictionary<string, NationalSpire.DateGameContent.Phrase>, System.Collections.Generic.List<NationalSpire.DateGameRule>)`；`NationalSpire.DateGameContent.Validate(NationalSpire.DateGameContent.Bundle, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`Coop.CoopJson.Copy(bundle.Rules)`；返回值紧邻使用处：`AssignmentExpressionSyntax: data.DateGameRules = Coop.CoopJson.Copy(bundle.Rules)`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`Coop.CoopJson.Copy(bundle.Timing)`；返回值紧邻使用处：`AssignmentExpressionSyntax: data.DateGameTiming = Coop.CoopJson.Copy(bundle.Timing)`
- `NationalSpire.DateGameContent.Edits(string, NationalSpire.DateGameContent.Profile, System.Collections.Generic.Dictionary<string, NationalSpire.DateGameContent.Phrase>, System.Collections.Generic.List<NationalSpire.DateGameRule>)`；输入表达式：`Edits(id, profile, bundle.Catalog, bundle.Rules)`；返回值紧邻使用处：`AssignmentExpressionSyntax: edits[id] = Edits(id, profile, bundle.Catalog, bundle.Rules)`
- `NationalSpire.DateGameContent.Validate(NationalSpire.DateGameContent.Bundle, bool)`；输入表达式：`Validate(bundle)`；返回值紧邻使用处：`ExpressionStatementSyntax: Validate(bundle);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, DateVoiceEdits>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, DateVoiceEdits>()`

**赋值（含属性/字段和局部值）：**

- `data.DateGameRules` = `Coop.CoopJson.Copy(bundle.Rules)`
- `data.DateGameTiming` = `Coop.CoopJson.Copy(bundle.Timing)`
- `data.DateGameVoiceEdits` = `edits`
- `edits[id]` = `Edits(id, profile, bundle.Catalog, bundle.Rules)`

<a id="symbol-28305905e4be"></a>

## `NationalSpire.DateGameContent.RewritePhrase(NationalSpire.CareerData, string, string) — public static string RewritePhrase(CareerData data, string profile, string source)`

来源：源码第 268 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGameVoices.EventLines(NationalSpire.CareerData, string, NationalSpire.DateGameRule)`](DateGameVoices.cs.md#symbol-036aa782750d)；[`NationalSpire.DateGameVoices.Style(NationalSpire.CareerData, NationalSpire.DateGameState, string, NationalSpire.BroadcastLine)`](DateGameVoices.cs.md#symbol-c55503cf04d2)；[`NationalSpire.DateGameVoices.Style(NationalSpire.CareerData, NationalSpire.DateGameState, string, string, string)`](DateGameVoices.cs.md#symbol-eaf8509231ad)

**调用：** [`NationalSpire.DateGameContent.Key(string)`](DateGameContent.cs.md#symbol-04fef069e286)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.DateGameVoiceEdits`；`NationalSpire.DateGameContent.Key(string)`；`NationalSpire.DateVoiceEdits.Lines`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGameContent.Key(string)`；输入表达式：`Key(source)`；返回值紧邻使用处：`ArgumentSyntax: Key(source)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`data.DateGameVoiceEdits.TryGetValue(profile, out var edits)`；返回值紧邻使用处：`BinaryExpressionSyntax: data.DateGameVoiceEdits.TryGetValue(profile, out var edits) && edits.Lines.Count > 0`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`edits.Lines.GetValueOrDefault(Key(source), source)`；返回值紧邻使用处：`ConditionalExpressionSyntax: data.DateGameVoiceEdits.TryGetValue(profile, out var edits) && edits.Lines.Count > 0 ? edits.Lines.GetValueOrDefault(Key(source), source) : source`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1f7e926e9345"></a>

## `NationalSpire.DateGameContent.Remark(NationalSpire.CareerData, string, string, string) — public static string Remark(CareerData data, string profile, string family, string fallback)`

来源：源码第 270 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGameVoices.Finish(NationalSpire.CareerData, string, string, string)`](DateGameVoices.cs.md#symbol-0d8429ae95a9)

**调用：** `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.DateGameVoiceEdits`；`NationalSpire.DateVoiceEdits.Remarks`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`.Remarks.GetValueOrDefault(family)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: data.DateGameVoiceEdits.GetValueOrDefault(profile)?.Remarks.GetValueOrDefault(family)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`data.DateGameVoiceEdits.GetValueOrDefault(profile)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: data.DateGameVoiceEdits.GetValueOrDefault(profile)?.Remarks.GetValueOrDefault(family)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7f516f204c6d"></a>

## `NationalSpire.DateGameContent.Write(string, NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.DateGameRule>?) — public static string Write(string directory, CareerData data, List<DateGameRule>? drafts = null)`

来源：源码第 272 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.EditDateGameRules()`](DateGameScreen.cs.md#symbol-0a1b70a243b1)

**调用：** [`NationalSpire.DateGameContent.Files(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.DateGameRule>?)`](DateGameContent.cs.md#symbol-c778174ab92f)；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`；`System.IO.Compression.ZipArchive.CreateEntry(string)`；`System.IO.Compression.ZipArchiveEntry.Open()`；`System.IO.Compression.ZipFile.Open(string, System.IO.Compression.ZipArchiveMode)`；`System.IO.Directory.CreateDirectory(string)`；`System.IO.File.Delete(string)`；`System.IO.File.Exists(string?)`；`System.IO.File.Move(string, string)`；`System.IO.Path.Combine(string, string)`；`System.IO.StreamWriter.StreamWriter(System.IO.Stream, System.Text.Encoding)`；`System.IO.StreamWriter.Write(string?)`；`System.Text.UTF8Encoding.UTF8Encoding(bool)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateGameContent.Files(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.DateGameRule>?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGameContent.Files(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.DateGameRule>?)`；输入表达式：`Files(data, drafts)`；返回值紧邻使用处：`ForEachVariableStatementSyntax: foreach (var (name, text) in Files(data, drafts)) { using var writer = new StreamWriter(zip.CreateEntry(name).Open(), new UTF8Encoding(false)); writer.Write(text); }`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`ElementAccessExpressionSyntax: Guid.NewGuid().ToString("N")[..6]`
- `System.IO.Compression.ZipArchive.CreateEntry(string)`；输入表达式：`zip.CreateEntry(name)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: zip.CreateEntry(name).Open`
- `System.IO.Compression.ZipArchiveEntry.Open()`；输入表达式：`zip.CreateEntry(name).Open()`；返回值紧邻使用处：`ArgumentSyntax: zip.CreateEntry(name).Open()`
- `System.IO.Compression.ZipFile.Open(string, System.IO.Compression.ZipArchiveMode)`；输入表达式：`ZipFile.Open(temporary, ZipArchiveMode.Create)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ZipFile.Open(temporary, ZipArchiveMode.Create)`
- `System.IO.Directory.CreateDirectory(string)`；输入表达式：`Directory.CreateDirectory(directory)`；返回值紧邻使用处：`ExpressionStatementSyntax: Directory.CreateDirectory(directory);`
- `System.IO.File.Delete(string)`；输入表达式：`File.Delete(temporary)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Delete(temporary);`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(temporary)`；返回值紧邻使用处：`IfStatementSyntax: if (File.Exists(temporary)) File.Delete(temporary);`
- `System.IO.File.Move(string, string)`；输入表达式：`File.Move(temporary, path)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Move(temporary, path);`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(directory, $"约会对局台词-{DateTime.Now:yyyyMMdd-HHmmss}-{Guid.NewGuid().ToString("N")[..6]}.zip")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Path.Combine(directory, $"约会对局台词-{DateTime.Now:yyyyMMdd-HHmmss}-{Guid.NewGuid().ToString("N")[..6]}.zip")`
- `System.IO.StreamWriter.StreamWriter(System.IO.Stream, System.Text.Encoding)`；输入表达式：`new StreamWriter(zip.CreateEntry(name).Open(), new UTF8Encoding(false))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StreamWriter(zip.CreateEntry(name).Open(), new UTF8Encoding(false))`
- `System.IO.StreamWriter.Write(string?)`；输入表达式：`writer.Write(text)`；返回值紧邻使用处：`ExpressionStatementSyntax: writer.Write(text);`
- `System.Text.UTF8Encoding.UTF8Encoding(bool)`；输入表达式：`new UTF8Encoding(false)`；返回值紧邻使用处：`ArgumentSyntax: new UTF8Encoding(false)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c778174ab92f"></a>

## `NationalSpire.DateGameContent.Files(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.DateGameRule>?) — public static Dictionary<string, string> Files(CareerData data, List<DateGameRule>? drafts = null)`

来源：源码第 286 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGameContent.Write(string, NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.DateGameRule>?)`](DateGameContent.cs.md#symbol-7f516f204c6d)

**调用：** [`NationalSpire.DateGameContent.Conditions()`](DateGameContent.cs.md#symbol-81cefbde8918)；`NationalSpire.DateGameContent.RuleFile.RuleFile()`；`NationalSpire.DateGameContent.RuleSetting.RuleSetting()`；[`NationalSpire.DateGameContent.Snapshot(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.DateGameRule>?)`](DateGameContent.cs.md#symbol-f9fa9ec59680)；[`NationalSpire.DateGameContent.Validate(NationalSpire.DateGameContent.Bundle, bool)`](DateGameContent.cs.md#symbol-a56139e0281f)；`NationalSpire.DateGameContent.VoiceFile.VoiceFile()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>.ToDictionary<TKey, TValue>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateGameContent.Bundle.Catalog`；`NationalSpire.DateGameContent.Bundle.Profiles`；`NationalSpire.DateGameContent.Bundle.Rules`；`NationalSpire.DateGameContent.Bundle.Timing`；`NationalSpire.DateGameContent.Catalog`；`NationalSpire.DateGameContent.Conditions()`；`NationalSpire.DateGameContent.Guide`；`NationalSpire.DateGameContent.Json`；`NationalSpire.DateGameContent.Profile.Lines`；`NationalSpire.DateGameContent.Profile.Name`；`NationalSpire.DateGameContent.RuleFile.Conditions`；`NationalSpire.DateGameContent.RuleFile.Rules`；`NationalSpire.DateGameContent.RuleFile.Timing`；`NationalSpire.DateGameContent.RuleSetting.Chat`；`NationalSpire.DateGameContent.RuleSetting.Enabled`；`NationalSpire.DateGameContent.RuleSetting.Threshold`；`NationalSpire.DateGameContent.RuleSetting.Trigger`；`NationalSpire.DateGameContent.Snapshot(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.DateGameRule>?)`；`NationalSpire.DateGameContent.Validate(NationalSpire.DateGameContent.Bundle, bool)`；`NationalSpire.DateGameContent.VoiceFile.Catalog`；`NationalSpire.DateGameContent.VoiceFile.Personality`；`NationalSpire.DateGameContent.VoiceFile.Profile`；`NationalSpire.DateGameRule.Chat`；`NationalSpire.DateGameRule.Enabled`；`NationalSpire.DateGameRule.Threshold`；`NationalSpire.DateGameRule.Trigger`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGameContent.Conditions()`；输入表达式：`Conditions()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Conditions = Conditions()`
- `NationalSpire.DateGameContent.RuleFile.RuleFile()`；输入表达式：`new RuleFile { Timing = bundle.Timing, Rules = bundle.Rules.Select(r => new RuleSetting { Trigger = r.Trigger, Enabled = r.Enabled, Chat = r.Chat, Threshold = r.Threshold }).ToList(), Conditions = Conditions() }`；返回值紧邻使用处：`ArgumentSyntax: new RuleFile { Timing = bundle.Timing, Rules = bundle.Rules.Select(r => new RuleSetting { Trigger = r.Trigger, Enabled = r.Enabled, Chat = r.Chat, Threshold = r.Threshold }).ToList(), Conditions = Conditions() }`
- `NationalSpire.DateGameContent.RuleSetting.RuleSetting()`；输入表达式：`new RuleSetting { Trigger = r.Trigger, Enabled = r.Enabled, Chat = r.Chat, Threshold = r.Threshold }`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: r => new RuleSetting { Trigger = r.Trigger, Enabled = r.Enabled, Chat = r.Chat, Threshold = r.Threshold }`
- `NationalSpire.DateGameContent.Snapshot(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.DateGameRule>?)`；输入表达式：`Snapshot(data, drafts)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Snapshot(data, drafts)`
- `NationalSpire.DateGameContent.Validate(NationalSpire.DateGameContent.Bundle, bool)`；输入表达式：`Validate(bundle)`；返回值紧邻使用处：`ExpressionStatementSyntax: Validate(bundle);`
- `NationalSpire.DateGameContent.VoiceFile.VoiceFile()`；输入表达式：`new VoiceFile { Personality = id, Profile = profile, Catalog = bundle.Catalog }`；返回值紧邻使用处：`ArgumentSyntax: new VoiceFile { Personality = id, Profile = profile, Catalog = bundle.Catalog }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`Catalog.Value.ContainsKey(p.Key)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => Catalog.Value.ContainsKey(p.Key)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`bundle.Catalog.ContainsKey(p.Key)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => bundle.Catalog.ContainsKey(p.Key)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, string>()`
- `System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>.ToDictionary<TKey, TValue>()`；输入表达式：`bundle.Catalog.Where(p => Catalog.Value.ContainsKey(p.Key)).ToDictionary()`；返回值紧邻使用处：`AssignmentExpressionSyntax: bundle.Catalog = bundle.Catalog.Where(p => Catalog.Value.ContainsKey(p.Key)).ToDictionary()`
- `System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>.ToDictionary<TKey, TValue>()`；输入表达式：`profile.Lines.Where(p => bundle.Catalog.ContainsKey(p.Key)).ToDictionary()`；返回值紧邻使用处：`AssignmentExpressionSyntax: profile.Lines = profile.Lines.Where(p => bundle.Catalog.ContainsKey(p.Key)).ToDictionary()`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`bundle.Rules.Select(r => new RuleSetting { Trigger = r.Trigger, Enabled = r.Enabled, Chat = r.Chat, Threshold = r.Threshold })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: bundle.Rules.Select(r => new RuleSetting { Trigger = r.Trigger, Enabled = r.Enabled, Chat = r.Chat, Threshold = r.Threshold }).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`bundle.Rules.Select(r => new RuleSetting { Trigger = r.Trigger, Enabled = r.Enabled, Chat = r.Chat, Threshold = r.Threshold }).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Rules = bundle.Rules.Select(r => new RuleSetting { Trigger = r.Trigger, Enabled = r.Enabled, Chat = r.Chat, Threshold = r.Threshold }).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`bundle.Catalog.Where(p => Catalog.Value.ContainsKey(p.Key))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: bundle.Catalog.Where(p => Catalog.Value.ContainsKey(p.Key)).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`profile.Lines.Where(p => bundle.Catalog.ContainsKey(p.Key))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: profile.Lines.Where(p => bundle.Catalog.ContainsKey(p.Key)).ToDictionary`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(new RuleFile { Timing = bundle.Timing, Rules = bundle.Rules.Select(r => new RuleSetting { Trigger = r.Trigger, Enabled = r.Enabled, Chat = r.Chat, Threshold = r.Threshold }).ToList(), Conditions = Conditions() }, Json)`；返回值紧邻使用处：`AssignmentExpressionSyntax: files["对局触发条件.json"] = JsonSerializer.Serialize(new RuleFile { Timing = bundle.Timing, Rules = bundle.Rules.Select(r => new RuleSetting { Trigger = r.Trigger, Enabled = r.Enabled, Chat = r.Chat, Threshold = r.Threshold }).ToList(), Conditions = Conditions() }, Json)`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(new VoiceFile { Personality = id, Profile = profile, Catalog = bundle.Catalog }, Json)`；返回值紧邻使用处：`AssignmentExpressionSyntax: files["对局发言_" + profile.Name + ".json"] = JsonSerializer.Serialize(new VoiceFile { Personality = id, Profile = profile, Catalog = bundle.Catalog }, Json)`

**赋值（含属性/字段和局部值）：**

- `Catalog` = `bundle.Catalog`
- `Chat` = `r.Chat`
- `Conditions` = `Conditions()`
- `Enabled` = `r.Enabled`
- `Personality` = `id`
- `Profile` = `profile`
- `Rules` = `bundle.Rules.Select(r => new RuleSetting { Trigger = r.Trigger, Enabled = r.Enabled, Chat = r.Chat, Threshold = r.Threshold }).ToList()`
- `Threshold` = `r.Threshold`
- `Timing` = `bundle.Timing`
- `Trigger` = `r.Trigger`
- `bundle.Catalog` = `bundle.Catalog.Where(p => Catalog.Value.ContainsKey(p.Key)).ToDictionary()`
- `files["使用说明.md"]` = `Guide`
- `files["对局发言_" + profile.Name + ".json"]` = `JsonSerializer.Serialize(new VoiceFile { Personality = id, Profile = profile, Catalog = bundle.Catalog }, Json)`
- `files["对局触发条件.json"]` = `JsonSerializer.Serialize(new RuleFile { Timing = bundle.Timing, Rules = bundle.Rules.Select(r => new RuleSetting { Trigger = r.Trigger, Enabled = r.Enabled, Chat = r.Chat, Threshold = r.Threshold }).ToList(), Conditions = Conditions() }, Json)`
- `profile.Lines` = `profile.Lines.Where(p => bundle.Catalog.ContainsKey(p.Key)).ToDictionary()`

<a id="symbol-81cefbde8918"></a>

## `NationalSpire.DateGameContent.Conditions() — private static Dictionary<string, string> Conditions()`

来源：源码第 301 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGameContent.Files(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.DateGameRule>?)`](DateGameContent.cs.md#symbol-c778174ab92f)；[`NationalSpire.DateGameContent.Read(string)`](DateGameContent.cs.md#symbol-ad02667b222b)；[`NationalSpire.DateGameContent.Snapshot(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.DateGameRule>?)`](DateGameContent.cs.md#symbol-f9fa9ec59680)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new() { ["fast"] = "玩家至少前进20层，并到达timing.fastMinimumFloor层后，累计用时/当前楼层<=threshold秒；整局一次。", ["act1"] = "玩家进入第二幕（通过第一幕）；整局一次。", ["act2"] = "玩家进入第三幕（通过第二幕）；整局一次。", ["npc-death"] = "NPC模拟对局已死亡；每名NPC一次。", ["npc-damage"] = "NPC本层开始生命减当前生命，占最大生命比例>=threshold%；以受伤NPC所在幕计，全体NPC共用每幕一次。", ["player-danger"] = "玩家当前生命占最大生命比例<=threshold%；整局一次。", ["gold-spent"] = "原版房间历史记录的玩家单层GoldSpent>=threshold金币（默认300）；每幕一次，获得金币不抵扣花费。", ["elite-fast"] = "完整观察精英战开始到胜利的原版对局计时，用时严格小于threshold秒（默认30）；每幕一次。战斗中途载入时跳过此次计时。", ["boss-fast"] = "完整观察首领战开始到胜利的原版对局计时，用时严格小于threshold秒（默认60）；每幕一次。战斗中途载入时跳过此次计时。", ["floor-gap"] = "玩家与任一NPC的楼层差绝对值>=threshold（默认12）；全体NPC共用每局一次。", ["priority"] = "按rules的排列顺序检查。所有事件受speechSeconds限制；请求聊天从上次请求出现时起至少间隔20秒，chatSeconds可设定更长间隔。已有待回应请求时等待处理。先播出台词，玩家点击回应请求后等待当前动作结束，再暂停进入约会。" }`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new() { ["fast"] = "玩家至少前进20层，并到达timing.fastMinimumFloor层后，累计用时/当前楼层<=threshold秒；整局一次。", ["act1"] = "玩家进入第二幕（通过第一幕）；整局一次。", ["act2"] = "玩家进入第三幕（通过第二幕）；整局一次。", ["npc-death"] = "NPC模拟对局已死亡；每名NPC一次。", ["npc-damage"] = "NPC本层开始生命减当前生命，占最大生命比例>=threshold%；以受伤NPC所在幕计，全体NPC共用每幕一次。", ["player-danger"] = "玩家当前生命占最大生命比例<=threshold%；整局一次。", ["gold-spent"] = "原版房间历史记录的玩家单层GoldSpent>=threshold金币（默认300）；每幕一次，获得金币不抵扣花费。", ["elite-fast"] = "完整观察精英战开始到胜利的原版对局计时，用时严格小于threshold秒（默认30）；每幕一次。战斗中途载入时跳过此次计时。", ["boss-fast"] = "完整观察首领战开始到胜利的原版对局计时，用时严格小于threshold秒（默认60）；每幕一次。战斗中途载入时跳过此次计时。", ["floor-gap"] = "玩家与任一NPC的楼层差绝对值>=threshold（默认12）；全体NPC共用每局一次。", ["priority"] = "按rules的排列顺序检查。所有事件受speechSeconds限制；请求聊天从上次请求出现时起至少间隔20秒，chatSeconds可设定更长间隔。已有待回应请求时等待处理。先播出台词，玩家点击回应请求后等待当前动作结束，再暂停进入约会。" }`

**赋值（含属性/字段和局部值）：**

- `["act1"]` = `"玩家进入第二幕（通过第一幕）；整局一次。"`
- `["act2"]` = `"玩家进入第三幕（通过第二幕）；整局一次。"`
- `["boss-fast"]` = `"完整观察首领战开始到胜利的原版对局计时，用时严格小于threshold秒（默认60）；每幕一次。战斗中途载入时跳过此次计时。"`
- `["elite-fast"]` = `"完整观察精英战开始到胜利的原版对局计时，用时严格小于threshold秒（默认30）；每幕一次。战斗中途载入时跳过此次计时。"`
- `["fast"]` = `"玩家至少前进20层，并到达timing.fastMinimumFloor层后，累计用时/当前楼层<=threshold秒；整局一次。"`
- `["floor-gap"]` = `"玩家与任一NPC的楼层差绝对值>=threshold（默认12）；全体NPC共用每局一次。"`
- `["gold-spent"]` = `"原版房间历史记录的玩家单层GoldSpent>=threshold金币（默认300）；每幕一次，获得金币不抵扣花费。"`
- `["npc-damage"]` = `"NPC本层开始生命减当前生命，占最大生命比例>=threshold%；以受伤NPC所在幕计，全体NPC共用每幕一次。"`
- `["npc-death"]` = `"NPC模拟对局已死亡；每名NPC一次。"`
- `["player-danger"]` = `"玩家当前生命占最大生命比例<=threshold%；整局一次。"`
- `["priority"]` = `"按rules的排列顺序检查。所有事件受speechSeconds限制；请求聊天从上次请求出现时起至少间隔20秒，chatSeconds可设定更长间隔。已有待回应请求时等待处理。先播出台词，玩家点击回应请求后等待当前动作结束，再暂停进入约会。"`
