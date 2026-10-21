# PromptTemplates.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`4BC37EC10EC08A9FCE4EFD1025461EC5D0DEBD72B5EE977A11FBE33F97489E36`。来源：[源码](../../PromptTemplates.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.PromptLibrary`。

字段、事件及初始值（源码原样）：

```csharp
public const string DefaultTemplate = "world-life";
private static readonly Lazy<IReadOnlyList<PromptSection>> CurrentSections = new(BuildCurrent);
private static readonly Lazy<Dictionary<string, string>> ReducedAggression = new(() => ReadPreset("reduced-aggression"));
private static readonly Lazy<Dictionary<string, string>> TiebaAggressive = new(() => ReadPreset("tieba-aggressive"));
```

<a id="symbol-35d237dd78a0"></a>

## `NationalSpire.PromptLibrary.Templates — public static IReadOnlyList<PromptTemplate> Templates`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `NationalSpire.PromptTemplate.PromptTemplate(string, string, string)`

**字段、属性、事件及方法组引用：** `NationalSpire.PromptLibrary.DefaultTemplate`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PromptTemplate.PromptTemplate(string, string, string)`；输入表达式：`new("legacy", "赛事叙述 · 旧版", "保留此前的写法，叙述较克制，主要围绕比赛与职业经历。")`；返回值紧邻使用处：`ExpressionElementSyntax: new("legacy", "赛事叙述 · 旧版", "保留此前的写法，叙述较克制，主要围绕比赛与职业经历。")`
- `NationalSpire.PromptTemplate.PromptTemplate(string, string, string)`；输入表达式：`new("reduced-aggression", "攻击性弱化版", "包含千恋万花具体示例，保留作者当前使用的社区文风与私信提示词。")`；返回值紧邻使用处：`ExpressionElementSyntax: new("reduced-aggression", "攻击性弱化版", "包含千恋万花具体示例，保留作者当前使用的社区文风与私信提示词。")`
- `NationalSpire.PromptTemplate.PromptTemplate(string, string, string)`；输入表达式：`new("tieba-aggressive", "贴吧社区（攻击性加强）", "贴吧老哥社区 2.0，侧重贴吧式争论、起哄与强烈情绪。")`；返回值紧邻使用处：`ExpressionElementSyntax: new("tieba-aggressive", "贴吧社区（攻击性加强）", "贴吧老哥社区 2.0，侧重贴吧式争论、起哄与强烈情绪。")`
- `NationalSpire.PromptTemplate.PromptTemplate(string, string, string)`；输入表达式：`new(DefaultTemplate, "国运日常 · 新版", "尖塔牵动生活，社区有热闹、偏心和针锋相对，也有人认真交流。")`；返回值紧邻使用处：`ExpressionElementSyntax: new(DefaultTemplate, "国运日常 · 新版", "尖塔牵动生活，社区有热闹、偏心和针锋相对，也有人认真交流。")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-237e889aeae3"></a>

## `NationalSpire.PromptLibrary.ReadPreset(string) — private static Dictionary<string, string> ReadPreset(string id)`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `string.IsNullOrWhiteSpace(string?)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.InvalidOperationException.InvalidOperationException(string?)`；`System.Reflection.Assembly.GetManifestResourceStream(string)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(System.IO.Stream, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.PromptLibrary.Sections`；`NationalSpire.PromptSection.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(p.Value)`；返回值紧邻使用处：`BinaryExpressionSyntax: !Sections.Any(s => s.Id == p.Key) || string.IsNullOrWhiteSpace(p.Value)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`sections.Any(p => !Sections.Any(s => s.Id == p.Key) || string.IsNullOrWhiteSpace(p.Value))`；返回值紧邻使用处：`IfStatementSyntax: if (sections.Any(p => !Sections.Any(s => s.Id == p.Key) || string.IsNullOrWhiteSpace(p.Value)))              throw new InvalidOperationException("内置提示词模块无效：" + id);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`Sections.Any(s => s.Id == p.Key)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Sections.Any(s => s.Id == p.Key)`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("内置提示词模块无效：" + id)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("内置提示词模块无效：" + id);`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("内置提示词资源缺失：" + id)`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidOperationException("内置提示词资源缺失：" + id)`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("内置提示词资源为空：" + id)`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidOperationException("内置提示词资源为空：" + id)`
- `System.Reflection.Assembly.GetManifestResourceStream(string)`；输入表达式：`typeof(PromptLibrary).Assembly.GetManifestResourceStream($"NationalSpire.PromptPresets.{id}.json")`；返回值紧邻使用处：`BinaryExpressionSyntax: typeof(PromptLibrary).Assembly.GetManifestResourceStream($"NationalSpire.PromptPresets.{id}.json")              ?? throw new InvalidOperationException("内置提示词资源缺失：" + id)`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(System.IO.Stream, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(stream)`；返回值紧邻使用处：`BinaryExpressionSyntax: System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(stream)              ?? throw new InvalidOperationException("内置提示词资源为空：" + id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-516b94b8a572"></a>

## `NationalSpire.PromptLibrary.Sections — public static IReadOnlyList<PromptSection> Sections`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.PromptLibrary.CurrentSections`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a6fed82a7f3f"></a>

## `NationalSpire.PromptLibrary.BuildCurrent() — private static IReadOnlyList<PromptSection> BuildCurrent()`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.PromptLibrary.LegacySections`；`NationalSpire.PromptSection.DefaultText`；`NationalSpire.PromptSection.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`LegacySections.Select(s => s with { DefaultText = s.Id switch          {              "world" => world,              "voice" => voice,              "news" => """              标题直接表达态度或疑问，正文通常两到四句，只围绕作者想聊的一个重点。评论各接自己在意的部分，可以自然岔开，楼主按兴趣参与。              """,              "discussion" => """              回应玩家这句话本身，按现有楼层的语境与情绪继续。问到技术再谈技术，必要解释在几句话内说清楚，普通闲聊照常接话。              """,              "profiles" => """              写这个人最近值得认识的一面，联系已有经历与本期变化。编辑可以欣赏、惋惜或幽默，评价有事实支撑，引用保留出处。每人通常50—100字，素材少时简短，各人的经历决定写法。              """,              "weekly" => """              双周刊写最近发生的变化，比赛与生活都值得看。正式消息交代清楚，人物和趣闻可以有编辑的趣味，失利也有自己的分量。引用争议保留归属，每篇随题材另起写法。标题通常12—24字，正文80—180字，按素材调整，段落用换行表示。              advertisement=true时写轻松的推广，品牌、代言关系与产品功效以资料为据。              """,              _ => s.DefaultText          }})`；返回值紧邻使用处：`MemberAccessExpressionSyntax: LegacySections.Select(s => s with { DefaultText = s.Id switch          {              "world" => world,              "voice" => voice,              "news" => """              标题直接表达态度或疑问，正文通常两到四句，只围绕作者想聊的一个重点。评论各接自己在意的部分，可以自然岔开，楼主按兴趣参与。              """,              "discussion" => """              回应玩家这句话本身，按现有楼层的语境与情绪继续。问到技术再谈技术，必要解释在几句话内说清楚，普通闲聊照常接话。              """,              "profiles" => """              写这个人最近值得认识的一面，联系已有经历与本期变化。编辑可以欣赏、惋惜或幽默，评价有事实支撑，引用保留出处。每人通常50—100字，素材少时简短，各人的经历决定写法。              """,              "weekly" => """              双周刊写最近发生的变化，比赛与生活都值得看。正式消息交代清楚，人物和趣闻可以有编辑的趣味，失利也有自己的分量。引用争议保留归属，每篇随题材另起写法。标题通常12—24字，正文80—180字，按素材调整，段落用换行表示。              advertisement=true时写轻松的推广，品牌、代言关系与产品功效以资料为据。              """,              _ => s.DefaultText          }}).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`LegacySections.Select(s => s with { DefaultText = s.Id switch          {              "world" => world,              "voice" => voice,              "news" => """              标题直接表达态度或疑问，正文通常两到四句，只围绕作者想聊的一个重点。评论各接自己在意的部分，可以自然岔开，楼主按兴趣参与。              """,              "discussion" => """              回应玩家这句话本身，按现有楼层的语境与情绪继续。问到技术再谈技术，必要解释在几句话内说清楚，普通闲聊照常接话。              """,              "profiles" => """              写这个人最近值得认识的一面，联系已有经历与本期变化。编辑可以欣赏、惋惜或幽默，评价有事实支撑，引用保留出处。每人通常50—100字，素材少时简短，各人的经历决定写法。              """,              "weekly" => """              双周刊写最近发生的变化，比赛与生活都值得看。正式消息交代清楚，人物和趣闻可以有编辑的趣味，失利也有自己的分量。引用争议保留归属，每篇随题材另起写法。标题通常12—24字，正文80—180字，按素材调整，段落用换行表示。              advertisement=true时写轻松的推广，品牌、代言关系与产品功效以资料为据。              """,              _ => s.DefaultText          }}).ToArray()`；返回值紧邻使用处：`ReturnStatementSyntax: return LegacySections.Select(s => s with { DefaultText = s.Id switch          {              "world" => world,              "voice" => voice,              "news" => """              标题直接表达态度或疑问，正文通常两到四句，只围绕作者想聊的一个重点。评论各接自己在意的部分，可以自然岔开，楼主按兴趣参与。              """,              "discussion" => """              回应玩家这句话本身，按现有楼层的语境与情绪继续。问到技术再谈技术，必要解释在几句话内说清楚，普通闲聊照常接话。              """,              "profiles" => """              写这个人最近值得认识的一面，联系已有经历与本期变化。编辑可以欣赏、惋惜或幽默，评价有事实支撑，引用保留出处。每人通常50—100字，素材少时简短，各人的经历决定写法。              """,              "weekly" => """              双周刊写最近发生的变化，比赛与生活都值得看。正式消息交代清楚，人物和趣闻可以有编辑的趣味，失利也有自己的分量。引用争议保留归属，每篇随题材另起写法。标题通常12—24字，正文80—180字，按素材调整，段落用换行表示。              advertisement=true时写轻松的推广，品牌、代言关系与产品功效以资料为据。              """,              _ => s.DefaultText          }}).ToArray();`

**赋值（含属性/字段和局部值）：**

- `DefaultText` = `s.Id switch          {              "world" => world,              "voice" => voice,              "news" => """              标题直接表达态度或疑问，正文通常两到四句，只围绕作者想聊的一个重点。评论各接自己在意的部分，可以自然岔开，楼主按兴趣参与。              """,              "discussion" => """              回应玩家这句话本身，按现有楼层的语境与情绪继续。问到技术再谈技术，必要解释在几句话内说清楚，普通闲聊照常接话。              """,              "profiles" => """              写这个人最近值得认识的一面，联系已有经历与本期变化。编辑可以欣赏、惋惜或幽默，评价有事实支撑，引用保留出处。每人通常50—100字，素材少时简短，各人的经历决定写法。              """,              "weekly" => """              双周刊写最近发生的变化，比赛与生活都值得看。正式消息交代清楚，人物和趣闻可以有编辑的趣味，失利也有自己的分量。引用争议保留归属，每篇随题材另起写法。标题通常12—24字，正文80—180字，按素材调整，段落用换行表示。              advertisement=true时写轻松的推广，品牌、代言关系与产品功效以资料为据。              """,              _ => s.DefaultText          }`

<a id="symbol-51c9e7869e6e"></a>

## `NationalSpire.PromptLibrary.TemplateId(NationalSpire.AiOptions) — public static string TemplateId(AiOptions options)`

来源：源码第 195 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConfirmPromptImport(NationalSpire.CareerData, string, System.Action)`](PromptScreen.cs.md#symbol-b9da8509093b)；[`NationalSpire.CareerScreen.OpenEventPoolSettings(NationalSpire.CareerData)`](EventPoolScreen.cs.md#symbol-8608563c139b)；[`NationalSpire.CareerScreen.OpenPromptSettings(NationalSpire.CareerData)`](PromptScreen.cs.md#symbol-fda1b116cf88)；[`NationalSpire.EventPools.Get(NationalSpire.AiOptions)`](EventPools.cs.md#symbol-5c94170cef9e)；[`NationalSpire.EventPools.Overrides(NationalSpire.AiOptions, string?)`](EventPools.cs.md#symbol-bc809b41fa9c)；[`NationalSpire.EventPools.Save(NationalSpire.AiOptions, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<NationalSpire.EventPoolEntry>>, string?)`](EventPools.cs.md#symbol-a7331058425b)；[`NationalSpire.PromptLibrary.CreateTemplate(NationalSpire.AiOptions, string, string)`](CustomPromptTemplates.cs.md#symbol-89804de92137)；[`NationalSpire.PromptLibrary.Default(NationalSpire.AiOptions, string)`](PromptTemplates.cs.md#symbol-7db48705d31b)；[`NationalSpire.PromptLibrary.DeleteTemplate(NationalSpire.AiOptions, string)`](CustomPromptTemplates.cs.md#symbol-c0e48d11dac8)；[`NationalSpire.PromptLibrary.SelectTemplate(NationalSpire.AiOptions, string)`](PromptTemplates.cs.md#symbol-50231e85e9e7)；[`NationalSpire.PromptLibrary.Template(NationalSpire.AiOptions)`](PromptTemplates.cs.md#symbol-facad1ba9cab)；[`NationalSpire.PromptTransfer.Export(NationalSpire.AiOptions, System.Collections.Generic.IReadOnlyDictionary<string, string>)`](PromptTransfer.cs.md#symbol-0bce76771cbe)

**调用：** [`NationalSpire.PromptLibrary.AvailableTemplates(NationalSpire.AiOptions)`](CustomPromptTemplates.cs.md#symbol-034310e38b45)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.PromptTemplate`；`NationalSpire.PromptLibrary.AvailableTemplates(NationalSpire.AiOptions)`；`NationalSpire.PromptLibrary.DefaultTemplate`；`NationalSpire.PromptTemplate.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PromptLibrary.AvailableTemplates(NationalSpire.AiOptions)`；输入表达式：`AvailableTemplates(options)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AvailableTemplates(options).Any`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`AvailableTemplates(options).Any(t => t.Id == options.PromptTemplate)`；返回值紧邻使用处：`ConditionalExpressionSyntax: AvailableTemplates(options).Any(t => t.Id == options.PromptTemplate) ? options.PromptTemplate : DefaultTemplate`

**赋值（含属性/字段和局部值）：**


<a id="symbol-facad1ba9cab"></a>

## `NationalSpire.PromptLibrary.Template(NationalSpire.AiOptions) — public static PromptTemplate Template(AiOptions options)`

来源：源码第 196 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenEventPoolSettings(NationalSpire.CareerData)`](EventPoolScreen.cs.md#symbol-8608563c139b)；[`NationalSpire.CareerScreen.OpenPromptSettings(NationalSpire.CareerData)`](PromptScreen.cs.md#symbol-fda1b116cf88)；[`Show()`](PromptScreen.cs.md#symbol-26218fc52477)

**调用：** [`NationalSpire.PromptLibrary.AvailableTemplates(NationalSpire.AiOptions)`](CustomPromptTemplates.cs.md#symbol-034310e38b45)；[`NationalSpire.PromptLibrary.TemplateId(NationalSpire.AiOptions)`](PromptTemplates.cs.md#symbol-51c9e7869e6e)；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.PromptLibrary.AvailableTemplates(NationalSpire.AiOptions)`；`NationalSpire.PromptLibrary.TemplateId(NationalSpire.AiOptions)`；`NationalSpire.PromptTemplate.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PromptLibrary.AvailableTemplates(NationalSpire.AiOptions)`；输入表达式：`AvailableTemplates(options)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AvailableTemplates(options).First`
- `NationalSpire.PromptLibrary.TemplateId(NationalSpire.AiOptions)`；输入表达式：`TemplateId(options)`；返回值紧邻使用处：`BinaryExpressionSyntax: t.Id == TemplateId(options)`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`AvailableTemplates(options).First(t => t.Id == TemplateId(options))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => AvailableTemplates(options).First(t => t.Id == TemplateId(options))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7db48705d31b"></a>

## `NationalSpire.PromptLibrary.Default(NationalSpire.AiOptions, string) — public static string Default(AiOptions options, string id)`

来源：源码第 197 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PromptLibrary.Get(NationalSpire.AiOptions, string)`](PromptLibrary.cs.md#symbol-3f64d002bbbe)；[`NationalSpire.PromptLibrary.Save(NationalSpire.AiOptions, string, string)`](PromptLibrary.cs.md#symbol-101a181e9f40)；[`NationalSpire.PromptTransfer.Apply(NationalSpire.AiOptions, NationalSpire.PromptTransfer.Bundle, string?)`](PromptTransfer.cs.md#symbol-3403e8b82dd8)；[`NationalSpire.PromptTransfer.Export(NationalSpire.AiOptions, System.Collections.Generic.IReadOnlyDictionary<string, string>)`](PromptTransfer.cs.md#symbol-0bce76771cbe)；[`NationalSpire.PromptTransfer.Validate(NationalSpire.PromptTransfer.Bundle)`](PromptTransfer.cs.md#symbol-c81f82a79264)

**调用：** [`NationalSpire.PromptLibrary.EditableText(string, string)`](PromptLibrary.cs.md#symbol-09cee4947d64)；[`NationalSpire.PromptLibrary.TemplateId(NationalSpire.AiOptions)`](PromptTemplates.cs.md#symbol-51c9e7869e6e)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.CustomPromptTemplates`；`NationalSpire.CustomPromptTemplate.BaseTemplate`；`NationalSpire.CustomPromptTemplate.Sections`；`NationalSpire.PromptLibrary.EditableText(string, string)`；`NationalSpire.PromptLibrary.LegacySections`；`NationalSpire.PromptLibrary.ReducedAggression`；`NationalSpire.PromptLibrary.Sections`；`NationalSpire.PromptLibrary.TemplateId(NationalSpire.AiOptions)`；`NationalSpire.PromptLibrary.TiebaAggressive`；`NationalSpire.PromptSection.DefaultText`；`NationalSpire.PromptSection.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PromptLibrary.EditableText(string, string)`；输入表达式：`EditableText(id, legacyEvent)`；返回值紧邻使用处：`ReturnStatementSyntax: return EditableText(id, legacyEvent);`
- `NationalSpire.PromptLibrary.EditableText(string, string)`；输入表达式：`EditableText(id, presetText)`；返回值紧邻使用处：`ReturnStatementSyntax: return EditableText(id, presetText);`
- `NationalSpire.PromptLibrary.EditableText(string, string)`；输入表达式：`EditableText(id, text)`；返回值紧邻使用处：`ReturnStatementSyntax: return EditableText(id, text);`
- `NationalSpire.PromptLibrary.TemplateId(NationalSpire.AiOptions)`；输入表达式：`TemplateId(options)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = TemplateId(options)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`.TryGetValue(id, out var presetText)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: preset?.TryGetValue(id, out var presetText)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`.TryGetValue(template, out var custom)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: options.CustomPromptTemplates?.TryGetValue(template, out var custom)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`custom.Sections.TryGetValue("events", out var legacyEvent)`；返回值紧邻使用处：`BinaryExpressionSyntax: id == "event" && custom.Sections.TryGetValue("events", out var legacyEvent)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`custom.Sections.TryGetValue(id, out var text)`；返回值紧邻使用处：`IfStatementSyntax: if (custom.Sections.TryGetValue(id, out var text)) return EditableText(id, text);`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`(template == "legacy" ? LegacySections : Sections).First(s => s.Id == id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: (template == "legacy" ? LegacySections : Sections).First(s => s.Id == id).DefaultText`

**赋值（含属性/字段和局部值）：**

- `template` = `custom.BaseTemplate`

<a id="symbol-50231e85e9e7"></a>

## `NationalSpire.PromptLibrary.SelectTemplate(NationalSpire.AiOptions, string) — public static void SelectTemplate(AiOptions options, string id)`

来源：源码第 211 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenPromptSettings(NationalSpire.CareerData)`](PromptScreen.cs.md#symbol-fda1b116cf88)；[`NationalSpire.PromptLibrary.CreateTemplate(NationalSpire.AiOptions, string, string)`](CustomPromptTemplates.cs.md#symbol-89804de92137)；[`NationalSpire.PromptLibrary.DeleteTemplate(NationalSpire.AiOptions, string)`](CustomPromptTemplates.cs.md#symbol-c0e48d11dac8)；[`NationalSpire.PromptTransfer.Apply(NationalSpire.AiOptions, NationalSpire.PromptTransfer.Bundle, string?)`](PromptTransfer.cs.md#symbol-3403e8b82dd8)

**调用：** [`NationalSpire.PromptLibrary.AvailableTemplates(NationalSpire.AiOptions)`](CustomPromptTemplates.cs.md#symbol-034310e38b45)；[`NationalSpire.PromptLibrary.TemplateId(NationalSpire.AiOptions)`](PromptTemplates.cs.md#symbol-51c9e7869e6e)；`System.ArgumentException.ArgumentException(string?)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IDictionary<TKey, TValue>)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.PromptOverrides`；`NationalSpire.AiOptions.PromptTemplate`；`NationalSpire.AiOptions.PromptTemplateOverrides`；`NationalSpire.PromptLibrary.AvailableTemplates(NationalSpire.AiOptions)`；`NationalSpire.PromptLibrary.TemplateId(NationalSpire.AiOptions)`；`NationalSpire.PromptTemplate.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PromptLibrary.AvailableTemplates(NationalSpire.AiOptions)`；输入表达式：`AvailableTemplates(options)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AvailableTemplates(options).Any`
- `NationalSpire.PromptLibrary.TemplateId(NationalSpire.AiOptions)`；输入表达式：`TemplateId(options)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = TemplateId(options)`
- `System.ArgumentException.ArgumentException(string?)`；输入表达式：`new ArgumentException("未知提示词模板。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new ArgumentException("未知提示词模板。");`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new()`；返回值紧邻使用处：`AssignmentExpressionSyntax: options.PromptTemplateOverrides ??= new()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new()`；返回值紧邻使用处：`BinaryExpressionSyntax: options.PromptOverrides ?? new()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new()`；返回值紧邻使用处：`ConditionalExpressionSyntax: options.PromptTemplateOverrides.TryGetValue(id, out var saved) ? new(saved) : new()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IDictionary<TKey, TValue>)`；输入表达式：`new(options.PromptOverrides ?? new())`；返回值紧邻使用处：`AssignmentExpressionSyntax: options.PromptTemplateOverrides[previous] = new(options.PromptOverrides ?? new())`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IDictionary<TKey, TValue>)`；输入表达式：`new(saved)`；返回值紧邻使用处：`ConditionalExpressionSyntax: options.PromptTemplateOverrides.TryGetValue(id, out var saved) ? new(saved) : new()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`options.PromptTemplateOverrides.Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: options.PromptTemplateOverrides.Remove(id);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`options.PromptTemplateOverrides.TryGetValue(id, out var saved)`；返回值紧邻使用处：`ConditionalExpressionSyntax: options.PromptTemplateOverrides.TryGetValue(id, out var saved) ? new(saved) : new()`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`AvailableTemplates(options).Any(t => t.Id == id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !AvailableTemplates(options).Any(t => t.Id == id)`

**赋值（含属性/字段和局部值）：**

- `options.PromptOverrides` = `options.PromptTemplateOverrides.TryGetValue(id, out var saved) ? new(saved) : new()`
- `options.PromptTemplate` = `id`
- `options.PromptTemplateOverrides[previous]` = `new(options.PromptOverrides ?? new())`
- `options.PromptTemplateOverrides` ??= `new()`
