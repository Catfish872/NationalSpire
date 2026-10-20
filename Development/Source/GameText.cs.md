# GameText.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`54C15888E9DFE26A9D90EFC0C58C464AD16E2FD5BFDE080264B6D9E77E270274`。来源：[源码](../../GameText.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.GameText`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly Regex Images = new(@"\[img[^\]]*\](.*?)\[/img\]", RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.Compiled);
private static readonly Regex Resources = new(@"res://[A-Za-z0-9_./-]+?\.(?:png|webp|svg|tres|jpg)|uid://[A-Za-z0-9]+", RegexOptions.IgnoreCase | RegexOptions.Compiled);
private static readonly Regex Tags = new(@"\[[^\]]*\]", RegexOptions.Compiled);
```

<a id="symbol-5f5f6d4e92e7"></a>

## `NationalSpire.GameText.Icon(string) — private static string Icon(string path)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameText.Plain(string)`](GameText.cs.md#symbol-e2c48dec4564)

**调用：** `string.Contains(string, System.StringComparison)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Contains(string, System.StringComparison)`；输入表达式：`path.Contains("energy", StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`ConditionalExpressionSyntax: path.Contains("energy", StringComparison.OrdinalIgnoreCase) ? "\uE000" : path.Contains("star_icon", StringComparison.OrdinalIgnoreCase) ? "\uE001" : ""`
- `string.Contains(string, System.StringComparison)`；输入表达式：`path.Contains("star_icon", StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`ConditionalExpressionSyntax: path.Contains("star_icon", StringComparison.OrdinalIgnoreCase) ? "\uE001" : ""`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e2c48dec4564"></a>

## `NationalSpire.GameText.Plain(string) — public static string Plain(string text)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Add(string, string, string)`](LiveShopObserver.cs.md#symbol-3cb46534a05e)；[`Describe()`](GameCardKnowledge.cs.md#symbol-5a0afbe041e1)；[`NationalSpire.AiService.BuildWeeklyContext(NationalSpire.CareerData, NationalSpire.WeeklyEdition, bool)`](AiWeekly.cs.md#symbol-d24065dcfca3)；[`NationalSpire.AvatarSources.Cards()`](AvatarSources.cs.md#symbol-3bc6741f18ea)；[`NationalSpire.AvatarSources.Characters()`](AvatarSources.cs.md#symbol-6c772247bc69)；[`NationalSpire.CareerScreen.RenderPostBackground(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-2d520c5b6596)；[`NationalSpire.CommunityMemorySearch.Retrieve(NationalSpire.CareerData, string, System.Collections.Generic.IEnumerable<string>, int, System.Collections.Generic.ISet<string>, int, System.Collections.Generic.ISet<string>?, bool, NationalSpire.CommunityMemorySearch.Request?)`](CommunityMemorySearch.cs.md#symbol-f933ce4e4ad8)；[`NationalSpire.CommunitySharing.Prepare(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](CommunitySharing.cs.md#symbol-b6e3b5a6b60e)；[`NationalSpire.Coop.CoopBroadcast.Changed()`](Coop/CoopBroadcast.cs.md#symbol-9cb809e0579a)；[`NationalSpire.GameBridge.ReadDefeatedEncounters(MegaCrit.Sts2.Core.Runs.RunHistory)`](GameBridge.cs.md#symbol-e0b622ef14ef)；[`NationalSpire.GameBridge.ReadPlayerHistory(MegaCrit.Sts2.Core.Runs.RunHistory, MegaCrit.Sts2.Core.Runs.RunHistoryPlayer)`](GameBridge.cs.md#symbol-2ddde8df91f3)；[`NationalSpire.GameCardKnowledge.Read()`](GameCardKnowledge.cs.md#symbol-58b00f45030f)；[`NationalSpire.LiveRunBridge.History(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Combat.History.CombatHistoryEntry)`](LiveRunBridge.cs.md#symbol-42aede5a364b)；[`NationalSpire.LiveRunBridge.ObservePotions(NationalSpire.BroadcastMemory, double)`](LiveRunBridge.cs.md#symbol-e509c91bb4f4)；[`NationalSpire.PrivatePublicContext.PostTexts(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CareerPerson, string, System.Collections.Generic.IEnumerable<NationalSpire.CommunityMemory>?, NationalSpire.CommunityMemorySearch.Request?, bool)`](PrivatePublicContext.cs.md#symbol-b4d8110deb5b)；[`NationalSpire.RunEvidence.PlainText()`](RunEvidence.cs.md#symbol-0a70d5e23e9a)；[`NationalSpire.RunEvidence.ResourceSummary()`](RunEvidence.cs.md#symbol-5809d489d617)；[`NationalSpire.RunEvidence.Summary()`](RunEvidence.cs.md#symbol-d852a24404b2)

**调用：** [`NationalSpire.GameText.Icon(string)`](GameText.cs.md#symbol-5f5f6d4e92e7)；`int.ToString()`；`string.Trim()`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Text.RegularExpressions.Regex.Replace(string, string, string)`；`System.Text.RegularExpressions.Regex.Replace(string, string, System.Text.RegularExpressions.MatchEvaluator)`；`System.Text.RegularExpressions.Regex.Replace(string, string)`；`System.Text.RegularExpressions.Regex.Replace(string, System.Text.RegularExpressions.MatchEvaluator)`

**字段、属性、事件及方法组引用：** `NationalSpire.GameText.Icon(string)`；`NationalSpire.GameText.Images`；`NationalSpire.GameText.Resources`；`NationalSpire.GameText.Tags`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.ToString()`；输入表达式：`m.Groups["icons"].Value.Count(c => c == symbol).ToString()`；返回值紧邻使用处：`ConditionalExpressionSyntax: m.Groups["number"].Success ? m.Groups["number"].Value : m.Groups["icons"].Value.Count(c => c == symbol).ToString()`
- `NationalSpire.GameText.Icon(string)`；输入表达式：`Icon(m.Groups[1].Value)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: m => Icon(m.Groups[1].Value)`
- `NationalSpire.GameText.Icon(string)`；输入表达式：`Icon(m.Value)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: m => Icon(m.Value)`
- `string.Trim()`；输入表达式：`Regex.Replace(value, @"[ \t]{2,}", " ").Trim()`；返回值紧邻使用处：`ReturnStatementSyntax: return Regex.Replace(value, @"[ \t]{2,}", " ").Trim();`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`m.Groups["icons"].Value.Count(c => c == symbol)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: m.Groups["icons"].Value.Count(c => c == symbol).ToString`
- `System.Text.RegularExpressions.Regex.Replace(string, string, string)`；输入表达式：`Regex.Replace(value, @"[ \t]{2,}", " ")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Regex.Replace(value, @"[ \t]{2,}", " ").Trim`
- `System.Text.RegularExpressions.Regex.Replace(string, string, System.Text.RegularExpressions.MatchEvaluator)`；输入表达式：`Regex.Replace(value, @"(?<number>\d+|X)?[ \t]*(?<icons>" + symbol + @"(?:[ \t]*" + symbol + @")*)", m =>                 (m.Groups["number"].Success ? m.Groups["number"].Value : m.Groups["icons"].Value.Count(c => c == symbol).ToString()) + "点" + unit)`；返回值紧邻使用处：`AssignmentExpressionSyntax: value = Regex.Replace(value, @"(?<number>\d+|X)?[ \t]*(?<icons>" + symbol + @"(?:[ \t]*" + symbol + @")*)", m =>                 (m.Groups["number"].Success ? m.Groups["number"].Value : m.Groups["icons"].Value.Count(c => c == symbol).ToString()) + "点" + unit)`
- `System.Text.RegularExpressions.Regex.Replace(string, string)`；输入表达式：`Tags.Replace(value, "")`；返回值紧邻使用处：`AssignmentExpressionSyntax: value = Tags.Replace(value, "")`
- `System.Text.RegularExpressions.Regex.Replace(string, System.Text.RegularExpressions.MatchEvaluator)`；输入表达式：`Images.Replace(text, m => Icon(m.Groups[1].Value))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Images.Replace(text, m => Icon(m.Groups[1].Value))`
- `System.Text.RegularExpressions.Regex.Replace(string, System.Text.RegularExpressions.MatchEvaluator)`；输入表达式：`Resources.Replace(value, m => Icon(m.Value))`；返回值紧邻使用处：`AssignmentExpressionSyntax: value = Resources.Replace(value, m => Icon(m.Value))`

**赋值（含属性/字段和局部值）：**

- `value` = `Regex.Replace(value, @"(?<number>\d+|X)?[ \t]*(?<icons>" + symbol + @"(?:[ \t]*" + symbol + @")*)", m =>                 (m.Groups["number"].Success ? m.Groups["number"].Value : m.Groups["icons"].Value.Count(c => c == symbol).ToString()) + "点" + unit)`
- `value` = `Resources.Replace(value, m => Icon(m.Value))`
- `value` = `Tags.Replace(value, "")`
