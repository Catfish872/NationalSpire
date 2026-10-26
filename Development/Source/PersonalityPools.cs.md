# PersonalityPools.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`506E42BEAE295DC021501827ACFCEDA336ED6C96E150C4016D9686A772255273`。来源：[源码](../../PersonalityPools.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.PersonalityPool`、`NationalSpire.PersonalityCategory`、`NationalSpire.PersonalityStyle`、`NationalSpire.PersonalitySelection`、`NationalSpire.PersonalityPools`。

字段、事件及初始值（源码原样）：

```csharp
public const string NeutralGender = "中性";
public static readonly string[] Genders = ["男", "女", NeutralGender];
public static readonly JsonSerializerOptions Json = new() { WriteIndented = true, PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        PropertyNameCaseInsensitive = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow };
```

<a id="symbol-473368341997"></a>

## `NationalSpire.PersonalityPool.Format — public string Format`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-94937b945a7e"></a>

## `NationalSpire.PersonalityPool.Version — public int Version`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-15ab0f4117f3"></a>

## `NationalSpire.PersonalityPool.Categories — public List<PersonalityCategory> Categories`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-235f7826e069"></a>

## `NationalSpire.PersonalityCategory.Id — public string Id`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Guid.NewGuid()`；`System.Guid.ToString(string?)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`BinaryExpressionSyntax: "category_" + Guid.NewGuid().ToString("N")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e7b414c014be"></a>

## `NationalSpire.PersonalityCategory.Name — public string Name`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d3cf37970b6d"></a>

## `NationalSpire.PersonalityCategory.Gender — public string Gender`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-93a2c9e9dc3a"></a>

## `NationalSpire.PersonalityCategory.Weight — public double Weight`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c9c93c6602f4"></a>

## `NationalSpire.PersonalityCategory.Prompt — public string Prompt`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a829b127be54"></a>

## `NationalSpire.PersonalityCategory.Styles — public List<PersonalityStyle> Styles`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-fb4cca6a082c"></a>

## `NationalSpire.PersonalityStyle.Id — public string Id`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Guid.NewGuid()`；`System.Guid.ToString(string?)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`BinaryExpressionSyntax: "style_" + Guid.NewGuid().ToString("N")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3529deaea28d"></a>

## `NationalSpire.PersonalityStyle.Name — public string Name`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-eb22394eac1a"></a>

## `NationalSpire.PersonalityStyle.Weight — public double Weight`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-0cc5f84ef81b"></a>

## `NationalSpire.PersonalityStyle.Prompt — public string Prompt`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8b6e91637437"></a>

## `NationalSpire.PersonalitySelection.CategoryId — public string CategoryId`

来源：源码第 30 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9c7c49548272"></a>

## `NationalSpire.PersonalitySelection.CategoryName — public string CategoryName`

来源：源码第 31 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b0f83a5c9b41"></a>

## `NationalSpire.PersonalitySelection.Gender — public string Gender`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-eef81890c558"></a>

## `NationalSpire.PersonalitySelection.StyleId — public string StyleId`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-5914f87ac6d4"></a>

## `NationalSpire.PersonalitySelection.StyleName — public string StyleName`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e3a776563969"></a>

## `NationalSpire.PersonalitySelection.CategoryPrompt — public string CategoryPrompt`

来源：源码第 35 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-26ff7a75ec41"></a>

## `NationalSpire.PersonalitySelection.StylePrompt — public string StylePrompt`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a732432a426b"></a>

## `NationalSpire.PersonalityPools.AllowsGender(string, string) — public static bool AllowsGender(string categoryGender, string personGender)`

来源：源码第 44 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCharacterCardCore(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?, NationalSpire.CharacterDesignPackage.Imported?)`](CharacterCardScreen.cs.md#symbol-c2fe452ad056)；[`NationalSpire.PersonalityPools.Assign(NationalSpire.CareerData, NationalSpire.CareerPerson)`](PersonalityPools.cs.md#symbol-6b60e68cd691)；[`NationalSpire.PersonalityPools.SelectionError(NationalSpire.PersonalityProfile, string)`](PersonalityPools.cs.md#symbol-56ca980b9e62)；[`RefreshStyles()`](CharacterCardScreen.cs.md#symbol-39bba49614cc)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.PersonalityPools.NeutralGender`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-992b7f26d8a7"></a>

## `NationalSpire.PersonalityPools.Defaults() — public static PersonalityPool Defaults()`

来源：源码第 49 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.NpcGenerationSetup.Pool`](NpcGenerationSetup.cs.md#symbol-cc4d488cfd93)；[`NationalSpire.PersonalityPools.Read(NationalSpire.AiOptions)`](PersonalityPools.cs.md#symbol-80fcf785b385)

**调用：** `NationalSpire.PersonalityCategory.PersonalityCategory()`；`NationalSpire.PersonalityPool.PersonalityPool()`；`NationalSpire.PersonalityStyle.PersonalityStyle()`

**字段、属性、事件及方法组引用：** `NationalSpire.PersonalityCategory.Gender`；`NationalSpire.PersonalityCategory.Id`；`NationalSpire.PersonalityCategory.Name`；`NationalSpire.PersonalityCategory.Prompt`；`NationalSpire.PersonalityCategory.Styles`；`NationalSpire.PersonalityPool.Categories`；`NationalSpire.PersonalityStyle.Id`；`NationalSpire.PersonalityStyle.Name`；`NationalSpire.PersonalityStyle.Prompt`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PersonalityCategory.PersonalityCategory()`；输入表达式：`new() { Id = "female", Name = "女性风格", Gender = "女", Prompt = "语言自然、细腻、有生活感。情绪通过具体用词、短暂停顿和简单动作体现；语气词随情境少量使用，保留人物自己的想法和主动表达。", Styles = [ new() { Id = "tsundere", Name = "傲娇", Prompt = "好胜、爱面子，在意亲近之人的看法。突然被夸奖会短暂慌张，熟悉后敢于直接关心和撒娇。让嘴上逞强与实际照顾自然共存。" }, new() { Id = "quiet", Name = "无口", Prompt = "言语简洁、情绪细微，用视线、停顿和短句表达关注。遇到重视的话题会主动补充想法，逐渐显露亲近。" }, new() { Id = "playful", Name = "抖M", Prompt = "在双方愿意的轻松玩笑中容易害羞，喜欢被关注，受调侃时表现局促与开心；保留自己的意见、界限和认真讨论的能力。" }, new() { Id = "teasing", Name = "雌小鬼", Prompt = "俏皮好胜，喜欢机灵的小挑衅和接话，得意时语气轻快，遇到意料外的关心会害羞。玩笑结合具体情境与已有关系。" }, new() { Id = "caring", Name = "小妈妈", Prompt = "温柔细心，留意对方的日常需求，用具体的小事表达照顾；也会表达自己的愿望、疲惫和期待，让关心与依赖双向流动。" } ] }`；返回值紧邻使用处：`ExpressionElementSyntax: new() { Id = "female", Name = "女性风格", Gender = "女", Prompt = "语言自然、细腻、有生活感。情绪通过具体用词、短暂停顿和简单动作体现；语气词随情境少量使用，保留人物自己的想法和主动表达。", Styles = [ new() { Id = "tsundere", Name = "傲娇", Prompt = "好胜、爱面子，在意亲近之人的看法。突然被夸奖会短暂慌张，熟悉后敢于直接关心和撒娇。让嘴上逞强与实际照顾自然共存。" }, new() { Id = "quiet", Name = "无口", Prompt = "言语简洁、情绪细微，用视线、停顿和短句表达关注。遇到重视的话题会主动补充想法，逐渐显露亲近。" }, new() { Id = "playful", Name = "抖M", Prompt = "在双方愿意的轻松玩笑中容易害羞，喜欢被关注，受调侃时表现局促与开心；保留自己的意见、界限和认真讨论的能力。" }, new() { Id = "teasing", Name = "雌小鬼", Prompt = "俏皮好胜，喜欢机灵的小挑衅和接话，得意时语气轻快，遇到意料外的关心会害羞。玩笑结合具体情境与已有关系。" }, new() { Id = "caring", Name = "小妈妈", Prompt = "温柔细心，留意对方的日常需求，用具体的小事表达照顾；也会表达自己的愿望、疲惫和期待，让关心与依赖双向流动。" } ] }`
- `NationalSpire.PersonalityCategory.PersonalityCategory()`；输入表达式：`new() { Id = "male", Name = "男性风格", Gender = "男", Prompt = "按人物已有的经历、性格及关系自然表达，保持个人说话习惯。", Styles = [new() { Id = "natural", Name = "自然", Prompt = "结合原有性格维度与当下话题作出回应。" }] }`；返回值紧邻使用处：`ExpressionElementSyntax: new() { Id = "male", Name = "男性风格", Gender = "男", Prompt = "按人物已有的经历、性格及关系自然表达，保持个人说话习惯。", Styles = [new() { Id = "natural", Name = "自然", Prompt = "结合原有性格维度与当下话题作出回应。" }] }`
- `NationalSpire.PersonalityPool.PersonalityPool()`；输入表达式：`new() { Categories = [ new() { Id = "male", Name = "男性风格", Gender = "男", Prompt = "按人物已有的经历、性格及关系自然表达，保持个人说话习惯。", Styles = [new() { Id = "natural", Name = "自然", Prompt = "结合原有性格维度与当下话题作出回应。" }] }, new() { Id = "female", Name = "女性风格", Gender = "女", Prompt = "语言自然、细腻、有生活感。情绪通过具体用词、短暂停顿和简单动作体现；语气词随情境少量使用，保留人物自己的想法和主动表达。", Styles = [ new() { Id = "tsundere", Name = "傲娇", Prompt = "好胜、爱面子，在意亲近之人的看法。突然被夸奖会短暂慌张，熟悉后敢于直接关心和撒娇。让嘴上逞强与实际照顾自然共存。" }, new() { Id = "quiet", Name = "无口", Prompt = "言语简洁、情绪细微，用视线、停顿和短句表达关注。遇到重视的话题会主动补充想法，逐渐显露亲近。" }, new() { Id = "playful", Name = "抖M", Prompt = "在双方愿意的轻松玩笑中容易害羞，喜欢被关注，受调侃时表现局促与开心；保留自己的意见、界限和认真讨论的能力。" }, new() { Id = "teasing", Name = "雌小鬼", Prompt = "俏皮好胜，喜欢机灵的小挑衅和接话，得意时语气轻快，遇到意料外的关心会害羞。玩笑结合具体情境与已有关系。" }, new() { Id = "caring", Name = "小妈妈", Prompt = "温柔细心，留意对方的日常需求，用具体的小事表达照顾；也会表达自己的愿望、疲惫和期待，让关心与依赖双向流动。" } ] } ] }`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new() { Categories = [ new() { Id = "male", Name = "男性风格", Gender = "男", Prompt = "按人物已有的经历、性格及关系自然表达，保持个人说话习惯。", Styles = [new() { Id = "natural", Name = "自然", Prompt = "结合原有性格维度与当下话题作出回应。" }] }, new() { Id = "female", Name = "女性风格", Gender = "女", Prompt = "语言自然、细腻、有生活感。情绪通过具体用词、短暂停顿和简单动作体现；语气词随情境少量使用，保留人物自己的想法和主动表达。", Styles = [ new() { Id = "tsundere", Name = "傲娇", Prompt = "好胜、爱面子，在意亲近之人的看法。突然被夸奖会短暂慌张，熟悉后敢于直接关心和撒娇。让嘴上逞强与实际照顾自然共存。" }, new() { Id = "quiet", Name = "无口", Prompt = "言语简洁、情绪细微，用视线、停顿和短句表达关注。遇到重视的话题会主动补充想法，逐渐显露亲近。" }, new() { Id = "playful", Name = "抖M", Prompt = "在双方愿意的轻松玩笑中容易害羞，喜欢被关注，受调侃时表现局促与开心；保留自己的意见、界限和认真讨论的能力。" }, new() { Id = "teasing", Name = "雌小鬼", Prompt = "俏皮好胜，喜欢机灵的小挑衅和接话，得意时语气轻快，遇到意料外的关心会害羞。玩笑结合具体情境与已有关系。" }, new() { Id = "caring", Name = "小妈妈", Prompt = "温柔细心，留意对方的日常需求，用具体的小事表达照顾；也会表达自己的愿望、疲惫和期待，让关心与依赖双向流动。" } ] } ] }`
- `NationalSpire.PersonalityStyle.PersonalityStyle()`；输入表达式：`new() { Id = "caring", Name = "小妈妈", Prompt = "温柔细心，留意对方的日常需求，用具体的小事表达照顾；也会表达自己的愿望、疲惫和期待，让关心与依赖双向流动。" }`；返回值紧邻使用处：`ExpressionElementSyntax: new() { Id = "caring", Name = "小妈妈", Prompt = "温柔细心，留意对方的日常需求，用具体的小事表达照顾；也会表达自己的愿望、疲惫和期待，让关心与依赖双向流动。" }`
- `NationalSpire.PersonalityStyle.PersonalityStyle()`；输入表达式：`new() { Id = "natural", Name = "自然", Prompt = "结合原有性格维度与当下话题作出回应。" }`；返回值紧邻使用处：`ExpressionElementSyntax: new() { Id = "natural", Name = "自然", Prompt = "结合原有性格维度与当下话题作出回应。" }`
- `NationalSpire.PersonalityStyle.PersonalityStyle()`；输入表达式：`new() { Id = "playful", Name = "抖M", Prompt = "在双方愿意的轻松玩笑中容易害羞，喜欢被关注，受调侃时表现局促与开心；保留自己的意见、界限和认真讨论的能力。" }`；返回值紧邻使用处：`ExpressionElementSyntax: new() { Id = "playful", Name = "抖M", Prompt = "在双方愿意的轻松玩笑中容易害羞，喜欢被关注，受调侃时表现局促与开心；保留自己的意见、界限和认真讨论的能力。" }`
- `NationalSpire.PersonalityStyle.PersonalityStyle()`；输入表达式：`new() { Id = "quiet", Name = "无口", Prompt = "言语简洁、情绪细微，用视线、停顿和短句表达关注。遇到重视的话题会主动补充想法，逐渐显露亲近。" }`；返回值紧邻使用处：`ExpressionElementSyntax: new() { Id = "quiet", Name = "无口", Prompt = "言语简洁、情绪细微，用视线、停顿和短句表达关注。遇到重视的话题会主动补充想法，逐渐显露亲近。" }`
- `NationalSpire.PersonalityStyle.PersonalityStyle()`；输入表达式：`new() { Id = "teasing", Name = "雌小鬼", Prompt = "俏皮好胜，喜欢机灵的小挑衅和接话，得意时语气轻快，遇到意料外的关心会害羞。玩笑结合具体情境与已有关系。" }`；返回值紧邻使用处：`ExpressionElementSyntax: new() { Id = "teasing", Name = "雌小鬼", Prompt = "俏皮好胜，喜欢机灵的小挑衅和接话，得意时语气轻快，遇到意料外的关心会害羞。玩笑结合具体情境与已有关系。" }`
- `NationalSpire.PersonalityStyle.PersonalityStyle()`；输入表达式：`new() { Id = "tsundere", Name = "傲娇", Prompt = "好胜、爱面子，在意亲近之人的看法。突然被夸奖会短暂慌张，熟悉后敢于直接关心和撒娇。让嘴上逞强与实际照顾自然共存。" }`；返回值紧邻使用处：`ExpressionElementSyntax: new() { Id = "tsundere", Name = "傲娇", Prompt = "好胜、爱面子，在意亲近之人的看法。突然被夸奖会短暂慌张，熟悉后敢于直接关心和撒娇。让嘴上逞强与实际照顾自然共存。" }`

**赋值（含属性/字段和局部值）：**

- `Categories` = `[ new() { Id = "male", Name = "男性风格", Gender = "男", Prompt = "按人物已有的经历、性格及关系自然表达，保持个人说话习惯。", Styles = [new() { Id = "natural", Name = "自然", Prompt = "结合原有性格维度与当下话题作出回应。" }] }, new() { Id = "female", Name = "女性风格", Gender = "女", Prompt = "语言自然、细腻、有生活感。情绪通过具体用词、短暂停顿和简单动作体现；语气词随情境少量使用，保留人物自己的想法和主动表达。", Styles = [ new() { Id = "tsundere", Name = "傲娇", Prompt = "好胜、爱面子，在意亲近之人的看法。突然被夸奖会短暂慌张，熟悉后敢于直接关心和撒娇。让嘴上逞强与实际照顾自然共存。" }, new() { Id = "quiet", Name = "无口", Prompt = "言语简洁、情绪细微，用视线、停顿和短句表达关注。遇到重视的话题会主动补充想法，逐渐显露亲近。" }, new() { Id = "playful", Name = "抖M", Prompt = "在双方愿意的轻松玩笑中容易害羞，喜欢被关注，受调侃时表现局促与开心；保留自己的意见、界限和认真讨论的能力。" }, new() { Id = "teasing", Name = "雌小鬼", Prompt = "俏皮好胜，喜欢机灵的小挑衅和接话，得意时语气轻快，遇到意料外的关心会害羞。玩笑结合具体情境与已有关系。" }, new() { Id = "caring", Name = "小妈妈", Prompt = "温柔细心，留意对方的日常需求，用具体的小事表达照顾；也会表达自己的愿望、疲惫和期待，让关心与依赖双向流动。" } ] } ]`
- `Gender` = `"女"`
- `Gender` = `"男"`
- `Id` = `"caring"`
- `Id` = `"female"`
- `Id` = `"male"`
- `Id` = `"natural"`
- `Id` = `"playful"`
- `Id` = `"quiet"`
- `Id` = `"teasing"`
- `Id` = `"tsundere"`
- `Name` = `"傲娇"`
- `Name` = `"女性风格"`
- `Name` = `"小妈妈"`
- `Name` = `"抖M"`
- `Name` = `"无口"`
- `Name` = `"男性风格"`
- `Name` = `"自然"`
- `Name` = `"雌小鬼"`
- `Prompt` = `"俏皮好胜，喜欢机灵的小挑衅和接话，得意时语气轻快，遇到意料外的关心会害羞。玩笑结合具体情境与已有关系。"`
- `Prompt` = `"在双方愿意的轻松玩笑中容易害羞，喜欢被关注，受调侃时表现局促与开心；保留自己的意见、界限和认真讨论的能力。"`
- `Prompt` = `"好胜、爱面子，在意亲近之人的看法。突然被夸奖会短暂慌张，熟悉后敢于直接关心和撒娇。让嘴上逞强与实际照顾自然共存。"`
- `Prompt` = `"按人物已有的经历、性格及关系自然表达，保持个人说话习惯。"`
- `Prompt` = `"温柔细心，留意对方的日常需求，用具体的小事表达照顾；也会表达自己的愿望、疲惫和期待，让关心与依赖双向流动。"`
- `Prompt` = `"结合原有性格维度与当下话题作出回应。"`
- `Prompt` = `"言语简洁、情绪细微，用视线、停顿和短句表达关注。遇到重视的话题会主动补充想法，逐渐显露亲近。"`
- `Prompt` = `"语言自然、细腻、有生活感。情绪通过具体用词、短暂停顿和简单动作体现；语气词随情境少量使用，保留人物自己的想法和主动表达。"`
- `Styles` = `[ new() { Id = "tsundere", Name = "傲娇", Prompt = "好胜、爱面子，在意亲近之人的看法。突然被夸奖会短暂慌张，熟悉后敢于直接关心和撒娇。让嘴上逞强与实际照顾自然共存。" }, new() { Id = "quiet", Name = "无口", Prompt = "言语简洁、情绪细微，用视线、停顿和短句表达关注。遇到重视的话题会主动补充想法，逐渐显露亲近。" }, new() { Id = "playful", Name = "抖M", Prompt = "在双方愿意的轻松玩笑中容易害羞，喜欢被关注，受调侃时表现局促与开心；保留自己的意见、界限和认真讨论的能力。" }, new() { Id = "teasing", Name = "雌小鬼", Prompt = "俏皮好胜，喜欢机灵的小挑衅和接话，得意时语气轻快，遇到意料外的关心会害羞。玩笑结合具体情境与已有关系。" }, new() { Id = "caring", Name = "小妈妈", Prompt = "温柔细心，留意对方的日常需求，用具体的小事表达照顾；也会表达自己的愿望、疲惫和期待，让关心与依赖双向流动。" } ]`
- `Styles` = `[new() { Id = "natural", Name = "自然", Prompt = "结合原有性格维度与当下话题作出回应。" }]`

<a id="symbol-7a6a591a48dd"></a>

## `NationalSpire.PersonalityPools.Validate(NationalSpire.PersonalityPool) — public static void Validate(PersonalityPool pool)`

来源：源码第 59 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.CreateNew(bool, int, NationalSpire.PersonalityPool?, string?, string?)`](CareerEngine.cs.md#symbol-63d93017946a)；[`NationalSpire.CareerScreen.OpenNpcGeneration(NationalSpire.AiOptions, System.Action<NationalSpire.NpcGenerationSetup>, bool, System.Func<NationalSpire.NpcGenerationSetup, System.Threading.Tasks.Task>?, int, bool)`](NpcGenerationScreen.cs.md#symbol-fa734ac20da4)；[`NationalSpire.CareerScreen.OpenPersonalityPool(NationalSpire.CareerData, NationalSpire.PersonalityPool?, System.Action<NationalSpire.PersonalityPool>?)`](PersonalityPoolScreen.cs.md#symbol-13f6866c9d3b)；[`NationalSpire.CareerStore.Read(string)`](CareerStore.cs.md#symbol-bd7895ebe52b)；[`NationalSpire.PersonalityPools.Export(NationalSpire.PersonalityPool)`](PersonalityPools.cs.md#symbol-6e2bdf455d82)；[`NationalSpire.PersonalityPools.Import(string)`](PersonalityPools.cs.md#symbol-a524890425ed)；[`NationalSpire.PersonalityPools.SelectionError(NationalSpire.PersonalityProfile, string)`](PersonalityPools.cs.md#symbol-56ca980b9e62)；[`NationalSpire.PromptTransfer.Validate(NationalSpire.PromptTransfer.Bundle)`](PromptTransfer.cs.md#symbol-c81f82a79264)

**调用：** [`Id(string)`](PersonalityPools.cs.md#symbol-b2d4485b39b6)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；[`Text(string, int)`](PersonalityPools.cs.md#symbol-e9022cda194e)；[`Weight(double)`](PersonalityPools.cs.md#symbol-a2093654d6c4)；`string.IsNullOrWhiteSpace(string?)`

**字段、属性、事件及方法组引用：** `Id(string)`；`NationalSpire.PersonalityCategory.Gender`；`NationalSpire.PersonalityCategory.Id`；`NationalSpire.PersonalityCategory.Name`；`NationalSpire.PersonalityCategory.Prompt`；`NationalSpire.PersonalityCategory.Styles`；`NationalSpire.PersonalityCategory.Weight`；`NationalSpire.PersonalityPool.Categories`；`NationalSpire.PersonalityPool.Format`；`NationalSpire.PersonalityPool.Version`；`NationalSpire.PersonalityPools.Genders`；`NationalSpire.PersonalityStyle.Id`；`NationalSpire.PersonalityStyle.Name`；`NationalSpire.PersonalityStyle.Prompt`；`NationalSpire.PersonalityStyle.Weight`；`Text(string, int)`；`Weight(double)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Id(string)`；输入表达式：`Id(c.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Id(c.Id)`
- `Id(string)`；输入表达式：`Id(s.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Id(s.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Styles.Any(s => s == null || !Id(s.Id) || !Text(s.Name, 80) || string.IsNullOrWhiteSpace(s.Name) || !Weight(s.Weight) || !Text(s.Prompt, 16000))`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Styles.Select(s => s?.Id).Distinct().Count() != c.Styles.Count || c.Styles.Any(s => s == null || !Id(s.Id) || !Text(s.Name, 80) || string.IsNullOrWhiteSpace(s.Name) || !Weight(s.Weight) || !Text(s.Prompt, 16000))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Styles.Any(s => s.Weight > 0)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !c.Styles.Any(s => s.Weight > 0)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`pool.Categories.Any(c => c.Weight > 0)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !pool.Categories.Any(c => c.Weight > 0)`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`Genders.Contains(c.Gender)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Genders.Contains(c.Gender)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`c.Styles.Select(s => s?.Id).Distinct().Count()`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Styles.Select(s => s?.Id).Distinct().Count() != c.Styles.Count`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`pool.Categories.Select(c => c?.Id).Distinct().Count()`；返回值紧邻使用处：`BinaryExpressionSyntax: pool.Categories.Select(c => c?.Id).Distinct().Count() != pool.Categories.Count`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`c.Styles.Select(s => s?.Id).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Styles.Select(s => s?.Id).Distinct().Count`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`pool.Categories.Select(c => c?.Id).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: pool.Categories.Select(c => c?.Id).Distinct().Count`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`c.Styles.Select(s => s?.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Styles.Select(s => s?.Id).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`pool.Categories.Select(c => c?.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: pool.Categories.Select(c => c?.Id).Distinct`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("类别 ID 应各不相同。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("类别 ID 应各不相同。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("请为至少一个类别设置正权重。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("请为至少一个类别设置正权重。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("请检查类别名称、ID、适用性别、权重及具体性格列表。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("请检查类别名称、ID、适用性别、权重及具体性格列表。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("请选择有效的性格池 JSON，包含 1—256 个类别。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("请选择有效的性格池 JSON，包含 1—256 个类别。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException(c.Name + "：具体性格需要独立 ID、名称、有效权重和提示词。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException(c.Name + "：具体性格需要独立 ID、名称、有效权重和提示词。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException(c.Name + "：请为至少一种性格设置正权重。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException(c.Name + "：请为至少一种性格设置正权重。");`
- `Text(string, int)`；输入表达式：`Text(c.Name, 80)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Text(c.Name, 80)`
- `Text(string, int)`；输入表达式：`Text(c.Prompt, 16000)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Text(c.Prompt, 16000)`
- `Text(string, int)`；输入表达式：`Text(s.Name, 80)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Text(s.Name, 80)`
- `Text(string, int)`；输入表达式：`Text(s.Prompt, 16000)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Text(s.Prompt, 16000)`
- `Weight(double)`；输入表达式：`Weight(c.Weight)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Weight(c.Weight)`
- `Weight(double)`；输入表达式：`Weight(s.Weight)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Weight(s.Weight)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(c.Name)`；返回值紧邻使用处：`BinaryExpressionSyntax: c == null || !Id(c.Id) || !Text(c.Name, 80) || string.IsNullOrWhiteSpace(c.Name)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(s.Name)`；返回值紧邻使用处：`BinaryExpressionSyntax: s == null || !Id(s.Id) || !Text(s.Name, 80) || string.IsNullOrWhiteSpace(s.Name)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a2093654d6c4"></a>

## `Weight(double) — bool Weight(double w)`

来源：源码第 63 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PersonalityPools.Validate(NationalSpire.PersonalityPool)`](PersonalityPools.cs.md#symbol-7a6a591a48dd)

**调用：** `double.IsFinite(double)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `double.IsFinite(double)`；输入表达式：`double.IsFinite(w)`；返回值紧邻使用处：`BinaryExpressionSyntax: double.IsFinite(w) && w is >= 0 and <= 1000000`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e9022cda194e"></a>

## `Text(string, int) — bool Text(string s, int max)`

来源：源码第 64 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PersonalityPools.Validate(NationalSpire.PersonalityPool)`](PersonalityPools.cs.md#symbol-7a6a591a48dd)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`char.IsControl(char)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`s.All(c => !char.IsControl(c) || c is '\n' or '\r' or '\t')`；返回值紧邻使用处：`BinaryExpressionSyntax: s != null && s.Length <= max && s.All(c => !char.IsControl(c) || c is '\n' or '\r' or '\t')`
- `char.IsControl(char)`；输入表达式：`char.IsControl(c)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !char.IsControl(c)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b2d4485b39b6"></a>

## `Id(string) — bool Id(string id)`

来源：源码第 65 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PersonalityPools.Validate(NationalSpire.PersonalityPool)`](PersonalityPools.cs.md#symbol-7a6a591a48dd)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`id.All(c => c is >= 'a' and <= 'z' or >= '0' and <= '9' or '_')`；返回值紧邻使用处：`BinaryExpressionSyntax: id != null && id.Length is >= 1 and <= 64 && id[0] is >= 'a' and <= 'z' && id.All(c => c is >= 'a' and <= 'z' or >= '0' and <= '9' or '_')`

**赋值（含属性/字段和局部值）：**


<a id="symbol-6e2bdf455d82"></a>

## `NationalSpire.PersonalityPools.Export(NationalSpire.PersonalityPool) — public static string Export(PersonalityPool pool)`

来源：源码第 80 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenPersonalityPool(NationalSpire.CareerData, NationalSpire.PersonalityPool?, System.Action<NationalSpire.PersonalityPool>?)`](PersonalityPoolScreen.cs.md#symbol-13f6866c9d3b)

**调用：** [`NationalSpire.PersonalityPools.Validate(NationalSpire.PersonalityPool)`](PersonalityPools.cs.md#symbol-7a6a591a48dd)；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.PersonalityPools.Json`；`NationalSpire.PersonalityPools.Validate(NationalSpire.PersonalityPool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PersonalityPools.Validate(NationalSpire.PersonalityPool)`；输入表达式：`Validate(pool)`；返回值紧邻使用处：`ExpressionStatementSyntax: Validate(pool);`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(pool, Json)`；返回值紧邻使用处：`ReturnStatementSyntax: return JsonSerializer.Serialize(pool, Json);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a524890425ed"></a>

## `NationalSpire.PersonalityPools.Import(string) — public static PersonalityPool Import(string text)`

来源：源码第 81 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenNpcGeneration(NationalSpire.AiOptions, System.Action<NationalSpire.NpcGenerationSetup>, bool, System.Func<NationalSpire.NpcGenerationSetup, System.Threading.Tasks.Task>?, int, bool)`](NpcGenerationScreen.cs.md#symbol-fa734ac20da4)；[`NationalSpire.CareerScreen.OpenPersonalityPool(NationalSpire.CareerData, NationalSpire.PersonalityPool?, System.Action<NationalSpire.PersonalityPool>?)`](PersonalityPoolScreen.cs.md#symbol-13f6866c9d3b)

**调用：** [`NationalSpire.PersonalityPools.Validate(NationalSpire.PersonalityPool)`](PersonalityPools.cs.md#symbol-7a6a591a48dd)；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.PersonalityPools.Json`；`NationalSpire.PersonalityPools.Validate(NationalSpire.PersonalityPool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PersonalityPools.Validate(NationalSpire.PersonalityPool)`；输入表达式：`Validate(pool)`；返回值紧邻使用处：`ExpressionStatementSyntax: Validate(pool);`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("性格池为空。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidDataException("性格池为空。")`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("性格池文件超过 8 MiB，请拆分后导入。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("性格池文件超过 8 MiB，请拆分后导入。");`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<PersonalityPool>(text, Json)`；返回值紧邻使用处：`BinaryExpressionSyntax: JsonSerializer.Deserialize<PersonalityPool>(text, Json) ?? throw new InvalidDataException("性格池为空。")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-80fcf785b385"></a>

## `NationalSpire.PersonalityPools.Read(NationalSpire.AiOptions) — public static PersonalityPool Read(AiOptions options)`

来源：源码第 86 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCharacterCardCore(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?, NationalSpire.CharacterDesignPackage.Imported?)`](CharacterCardScreen.cs.md#symbol-c2fe452ad056)；[`NationalSpire.CareerScreen.OpenNpcGeneration(NationalSpire.AiOptions, System.Action<NationalSpire.NpcGenerationSetup>, bool, System.Func<NationalSpire.NpcGenerationSetup, System.Threading.Tasks.Task>?, int, bool)`](NpcGenerationScreen.cs.md#symbol-fa734ac20da4)；[`NationalSpire.CareerScreen.OpenPersonalityPool(NationalSpire.CareerData, NationalSpire.PersonalityPool?, System.Action<NationalSpire.PersonalityPool>?)`](PersonalityPoolScreen.cs.md#symbol-13f6866c9d3b)；[`NationalSpire.PromptTransfer.Export(NationalSpire.AiOptions, System.Collections.Generic.IReadOnlyDictionary<string, string>)`](PromptTransfer.cs.md#symbol-0bce76771cbe)

**调用：** [`NationalSpire.Coop.CoopJson.Copy<T>(T)`](Coop/CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.PersonalityPools.Defaults()`](PersonalityPools.cs.md#symbol-992b7f26d8a7)

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.PersonalityPool`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.PersonalityPools.Defaults()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`Coop.CoopJson.Copy(options.PersonalityPool ?? Defaults())`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Coop.CoopJson.Copy(options.PersonalityPool ?? Defaults())`
- `NationalSpire.PersonalityPools.Defaults()`；输入表达式：`Defaults()`；返回值紧邻使用处：`BinaryExpressionSyntax: options.PersonalityPool ?? Defaults()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f32c4fb186ef"></a>

## `NationalSpire.PersonalityPools.Pick<T>(System.Collections.Generic.IEnumerable<T>, System.Func<T, double>, double) — private static T Pick<T>(IEnumerable<T> items, Func<T, double> weight, double sample)`

来源：源码第 87 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PersonalityPools.Assign(NationalSpire.CareerData, NationalSpire.CareerPerson)`](PersonalityPools.cs.md#symbol-6b60e68cd691)；[`NationalSpire.PersonalityPools.Category(NationalSpire.CareerData, string)`](PersonalityPools.cs.md#symbol-a1bd93e3692f)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, double>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Func<T, TResult>.Invoke(T)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, double>)`；输入表达式：`choices.Sum(weight)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = choices.Sum(weight)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`items.Where(i => weight(i) > 0).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = items.Where(i => weight(i) > 0).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`items.Where(i => weight(i) > 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: items.Where(i => weight(i) > 0).ToArray`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`weight(choice)`；返回值紧邻使用处：`AssignmentExpressionSyntax: remaining -= weight(choice)`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`weight(i)`；返回值紧邻使用处：`BinaryExpressionSyntax: weight(i) > 0`

**赋值（含属性/字段和局部值）：**

- `remaining` -= `weight(choice)`

<a id="symbol-a1bd93e3692f"></a>

## `NationalSpire.PersonalityPools.Category(NationalSpire.CareerData, string) — public static PersonalityCategory? Category(CareerData data, string id)`

来源：源码第 93 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.IdentityGender.Assigned(NationalSpire.CareerData, string)`](IdentityGender.cs.md#symbol-9b3f1de1d44a)；[`NationalSpire.PersonalityPools.Assign(NationalSpire.CareerData, NationalSpire.CareerPerson)`](PersonalityPools.cs.md#symbol-6b60e68cd691)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.PersonalityPools.Pick<T>(System.Collections.Generic.IEnumerable<T>, System.Func<T, double>, double)`](PersonalityPools.cs.md#symbol-f32c4fb186ef)；`System.Random.NextDouble()`；`System.Random.Random(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.NpcPersonalityPool`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.PersonalityCategory.Weight`；`NationalSpire.PersonalityPool.Categories`；`NationalSpire.PersonalityPools.Pick<T>(System.Collections.Generic.IEnumerable<T>, System.Func<T, double>, double)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(data.WorldId + ":personality-category:" + id)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.StableHash(data.WorldId + ":personality-category:" + id)`
- `NationalSpire.PersonalityPools.Pick<T>(System.Collections.Generic.IEnumerable<T>, System.Func<T, double>, double)`；输入表达式：`Pick(data.NpcPersonalityPool.Categories, c => c.Weight, random.NextDouble())`；返回值紧邻使用处：`ReturnStatementSyntax: return Pick(data.NpcPersonalityPool.Categories, c => c.Weight, random.NextDouble());`
- `System.Random.NextDouble()`；输入表达式：`random.NextDouble()`；返回值紧邻使用处：`ArgumentSyntax: random.NextDouble()`
- `System.Random.Random(int)`；输入表达式：`new Random(CareerEngine.StableHash(data.WorldId + ":personality-category:" + id))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Random(CareerEngine.StableHash(data.WorldId + ":personality-category:" + id))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-6b60e68cd691"></a>

## `NationalSpire.PersonalityPools.Assign(NationalSpire.CareerData, NationalSpire.CareerPerson) — public static void Assign(CareerData data, CareerPerson person)`

来源：源码第 99 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PersonalityLibrary.Ensure(NationalSpire.CareerData, NationalSpire.CareerPerson)`](PersonalityLibrary.cs.md#symbol-902b2bd837d2)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-24bc82bdbbd4)；[`NationalSpire.PersonalityPools.AllowsGender(string, string)`](PersonalityPools.cs.md#symbol-a732432a426b)；[`NationalSpire.PersonalityPools.Category(NationalSpire.CareerData, string)`](PersonalityPools.cs.md#symbol-a1bd93e3692f)；[`NationalSpire.PersonalityPools.Pick<T>(System.Collections.Generic.IEnumerable<T>, System.Func<T, double>, double)`](PersonalityPools.cs.md#symbol-f32c4fb186ef)；[`NationalSpire.PersonalityPools.Select(NationalSpire.PersonalityProfile, NationalSpire.PersonalityCategory, NationalSpire.PersonalityStyle)`](PersonalityPools.cs.md#symbol-5029bd05726a)；`System.Random.NextDouble()`；`System.Random.Random(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerPerson.CameoId`；`NationalSpire.CareerPerson.CreatedCard`；`NationalSpire.CareerPerson.EditedCard`；`NationalSpire.CareerPerson.Gender`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Personality`；`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.PersonalityCategory.Gender`；`NationalSpire.PersonalityCategory.Styles`；`NationalSpire.PersonalityPools.AllowsGender(string, string)`；`NationalSpire.PersonalityPools.Category(NationalSpire.CareerData, string)`；`NationalSpire.PersonalityPools.Pick<T>(System.Collections.Generic.IEnumerable<T>, System.Func<T, double>, double)`；`NationalSpire.PersonalityPools.Select(NationalSpire.PersonalityProfile, NationalSpire.PersonalityCategory, NationalSpire.PersonalityStyle)`；`NationalSpire.PersonalityProfile.Selection`；`NationalSpire.PersonalityStyle.Weight`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(data.WorldId + ":personality-style:" + person.Id)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.StableHash(data.WorldId + ":personality-style:" + person.Id)`
- `NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.IsHuman(data, person.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: person.Personality.Selection != null || person.EditedCard || person.CreatedCard || person.CameoId.Length > 0 || GroupChats.IsHuman(data, person.Id)`
- `NationalSpire.PersonalityPools.AllowsGender(string, string)`；输入表达式：`AllowsGender(category.Gender, person.Gender)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !AllowsGender(category.Gender, person.Gender)`
- `NationalSpire.PersonalityPools.Category(NationalSpire.CareerData, string)`；输入表达式：`Category(data, person.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Category(data, person.Id)`
- `NationalSpire.PersonalityPools.Pick<T>(System.Collections.Generic.IEnumerable<T>, System.Func<T, double>, double)`；输入表达式：`Pick(category.Styles, s => s.Weight, random.NextDouble())`；返回值紧邻使用处：`ArgumentSyntax: Pick(category.Styles, s => s.Weight, random.NextDouble())`
- `NationalSpire.PersonalityPools.Select(NationalSpire.PersonalityProfile, NationalSpire.PersonalityCategory, NationalSpire.PersonalityStyle)`；输入表达式：`Select(person.Personality, category, Pick(category.Styles, s => s.Weight, random.NextDouble()))`；返回值紧邻使用处：`ExpressionStatementSyntax: Select(person.Personality, category, Pick(category.Styles, s => s.Weight, random.NextDouble()));`
- `System.Random.NextDouble()`；输入表达式：`random.NextDouble()`；返回值紧邻使用处：`ArgumentSyntax: random.NextDouble()`
- `System.Random.Random(int)`；输入表达式：`new Random(CareerEngine.StableHash(data.WorldId + ":personality-style:" + person.Id))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Random(CareerEngine.StableHash(data.WorldId + ":personality-style:" + person.Id))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5029bd05726a"></a>

## `NationalSpire.PersonalityPools.Select(NationalSpire.PersonalityProfile, NationalSpire.PersonalityCategory, NationalSpire.PersonalityStyle) — public static void Select(PersonalityProfile profile, PersonalityCategory category, PersonalityStyle style)`

来源：源码第 106 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCharacterCardCore(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?, NationalSpire.CharacterDesignPackage.Imported?)`](CharacterCardScreen.cs.md#symbol-c2fe452ad056)；[`NationalSpire.PersonalityPools.Assign(NationalSpire.CareerData, NationalSpire.CareerPerson)`](PersonalityPools.cs.md#symbol-6b60e68cd691)

**调用：** `NationalSpire.PersonalitySelection.PersonalitySelection()`

**字段、属性、事件及方法组引用：** `NationalSpire.PersonalityCategory.Gender`；`NationalSpire.PersonalityCategory.Id`；`NationalSpire.PersonalityCategory.Name`；`NationalSpire.PersonalityCategory.Prompt`；`NationalSpire.PersonalityProfile.Selection`；`NationalSpire.PersonalitySelection.CategoryId`；`NationalSpire.PersonalitySelection.CategoryName`；`NationalSpire.PersonalitySelection.CategoryPrompt`；`NationalSpire.PersonalitySelection.Gender`；`NationalSpire.PersonalitySelection.StyleId`；`NationalSpire.PersonalitySelection.StyleName`；`NationalSpire.PersonalitySelection.StylePrompt`；`NationalSpire.PersonalityStyle.Id`；`NationalSpire.PersonalityStyle.Name`；`NationalSpire.PersonalityStyle.Prompt`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PersonalitySelection.PersonalitySelection()`；输入表达式：`new() { CategoryId = category.Id, CategoryName = category.Name, Gender = category.Gender, StyleId = style.Id, StyleName = style.Name, CategoryPrompt = category.Prompt, StylePrompt = style.Prompt }`；返回值紧邻使用处：`AssignmentExpressionSyntax: profile.Selection = new() { CategoryId = category.Id, CategoryName = category.Name, Gender = category.Gender, StyleId = style.Id, StyleName = style.Name, CategoryPrompt = category.Prompt, StylePrompt = style.Prompt }`

**赋值（含属性/字段和局部值）：**

- `CategoryId` = `category.Id`
- `CategoryName` = `category.Name`
- `CategoryPrompt` = `category.Prompt`
- `Gender` = `category.Gender`
- `StyleId` = `style.Id`
- `StyleName` = `style.Name`
- `StylePrompt` = `style.Prompt`
- `profile.Selection` = `new() { CategoryId = category.Id, CategoryName = category.Name, Gender = category.Gender, StyleId = style.Id, StyleName = style.Name, CategoryPrompt = category.Prompt, StylePrompt = style.Prompt }`

<a id="symbol-56ca980b9e62"></a>

## `NationalSpire.PersonalityPools.SelectionError(NationalSpire.PersonalityProfile, string) — public static string? SelectionError(PersonalityProfile profile, string gender)`

来源：源码第 108 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CharacterCards.Validate(NationalSpire.CareerData, NationalSpire.CharacterCardEdit, bool)`](CharacterCards.cs.md#symbol-43d6137cec3b)

**调用：** `NationalSpire.PersonalityCategory.PersonalityCategory()`；`NationalSpire.PersonalityPool.PersonalityPool()`；[`NationalSpire.PersonalityPools.AllowsGender(string, string)`](PersonalityPools.cs.md#symbol-a732432a426b)；[`NationalSpire.PersonalityPools.Validate(NationalSpire.PersonalityPool)`](PersonalityPools.cs.md#symbol-7a6a591a48dd)；`NationalSpire.PersonalityStyle.PersonalityStyle()`

**字段、属性、事件及方法组引用：** `NationalSpire.PersonalityCategory.Gender`；`NationalSpire.PersonalityCategory.Id`；`NationalSpire.PersonalityCategory.Name`；`NationalSpire.PersonalityCategory.Prompt`；`NationalSpire.PersonalityCategory.Styles`；`NationalSpire.PersonalityPool.Categories`；`NationalSpire.PersonalityPools.AllowsGender(string, string)`；`NationalSpire.PersonalityPools.Validate(NationalSpire.PersonalityPool)`；`NationalSpire.PersonalityProfile.Selection`；`NationalSpire.PersonalitySelection.CategoryId`；`NationalSpire.PersonalitySelection.CategoryName`；`NationalSpire.PersonalitySelection.CategoryPrompt`；`NationalSpire.PersonalitySelection.Gender`；`NationalSpire.PersonalitySelection.StyleId`；`NationalSpire.PersonalitySelection.StyleName`；`NationalSpire.PersonalitySelection.StylePrompt`；`NationalSpire.PersonalityStyle.Id`；`NationalSpire.PersonalityStyle.Name`；`NationalSpire.PersonalityStyle.Prompt`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PersonalityCategory.PersonalityCategory()`；输入表达式：`new() { Id = s.CategoryId, Name = s.CategoryName, Gender = s.Gender, Prompt = s.CategoryPrompt, Styles = [new() { Id = s.StyleId, Name = s.StyleName, Prompt = s.StylePrompt }] }`；返回值紧邻使用处：`ExpressionElementSyntax: new() { Id = s.CategoryId, Name = s.CategoryName, Gender = s.Gender, Prompt = s.CategoryPrompt, Styles = [new() { Id = s.StyleId, Name = s.StyleName, Prompt = s.StylePrompt }] }`
- `NationalSpire.PersonalityPool.PersonalityPool()`；输入表达式：`new() { Categories = [new() { Id = s.CategoryId, Name = s.CategoryName, Gender = s.Gender, Prompt = s.CategoryPrompt, Styles = [new() { Id = s.StyleId, Name = s.StyleName, Prompt = s.StylePrompt }] }] }`；返回值紧邻使用处：`ArgumentSyntax: new() { Categories = [new() { Id = s.CategoryId, Name = s.CategoryName, Gender = s.Gender, Prompt = s.CategoryPrompt, Styles = [new() { Id = s.StyleId, Name = s.StyleName, Prompt = s.StylePrompt }] }] }`
- `NationalSpire.PersonalityPools.AllowsGender(string, string)`；输入表达式：`AllowsGender(s.Gender, gender)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !AllowsGender(s.Gender, gender)`
- `NationalSpire.PersonalityPools.Validate(NationalSpire.PersonalityPool)`；输入表达式：`Validate(new() { Categories = [new() { Id = s.CategoryId, Name = s.CategoryName, Gender = s.Gender, Prompt = s.CategoryPrompt, Styles = [new() { Id = s.StyleId, Name = s.StyleName, Prompt = s.StylePrompt }] }] })`；返回值紧邻使用处：`ExpressionStatementSyntax: Validate(new() { Categories = [new() { Id = s.CategoryId, Name = s.CategoryName, Gender = s.Gender, Prompt = s.CategoryPrompt, Styles = [new() { Id = s.StyleId, Name = s.StyleName, Prompt = s.StylePrompt }] }] });`
- `NationalSpire.PersonalityStyle.PersonalityStyle()`；输入表达式：`new() { Id = s.StyleId, Name = s.StyleName, Prompt = s.StylePrompt }`；返回值紧邻使用处：`ExpressionElementSyntax: new() { Id = s.StyleId, Name = s.StyleName, Prompt = s.StylePrompt }`

**赋值（含属性/字段和局部值）：**

- `Categories` = `[new() { Id = s.CategoryId, Name = s.CategoryName, Gender = s.Gender, Prompt = s.CategoryPrompt, Styles = [new() { Id = s.StyleId, Name = s.StyleName, Prompt = s.StylePrompt }] }]`
- `Gender` = `s.Gender`
- `Id` = `s.CategoryId`
- `Id` = `s.StyleId`
- `Name` = `s.CategoryName`
- `Name` = `s.StyleName`
- `Prompt` = `s.CategoryPrompt`
- `Prompt` = `s.StylePrompt`
- `Styles` = `[new() { Id = s.StyleId, Name = s.StyleName, Prompt = s.StylePrompt }]`
