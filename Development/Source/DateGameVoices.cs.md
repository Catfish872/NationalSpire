# DateGameVoices.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`4B61FB5D5A52E6BFDCA99A9498EFE31F8CCD5E2591AED486B25FA479ECFC64CC`。来源：[源码](../../DateGameVoices.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.DateGameVoices`。

字段、事件及初始值（源码原样）：

```csharp
public static readonly string[] Ids = ["male", "female", "tsundere", "quiet", "playful", "teasing", "caring"];
public static readonly string[] Labels = ["男性默认", "女性默认", "傲娇", "无口", "抖M", "雌小鬼", "小妈妈"];
internal static readonly Dictionary<string, string[]> Remarks = new()
    {
        ["start"] = ["一起慢慢打完这局。", "准备好啦？我今天也想赢一回。", "准备好了。一起。", "认真和我打一局吧，赢了我也要教教我。", "让我看看你的本事。", "都准备好了，我们一起出发。"],
        ["danger"] = ["我陪你看清这一回合。", "先看清楚伤害，刚才吓我一跳。", "慢一点。我陪你看。", "呜，先一起把这一关过了吧。", "这下要认真起来了吧？我陪你看。", "手先放慢，把眼前这回合算清楚。"],
        ["loss"] = ["回头一起看看这步的选择。", "唔，这一手得记住，下次我要打回来。", "记下了。下次再来。", "呜，好厉害……再教我一次刚才那手吧。", "这手被抓到了，下回我会找回来的。", "这一局的经验记下来，我陪你复盘。"],
        ["win"] = ["这一段打得很漂亮。", "哼哼，这一手确实值得夸。", "漂亮。记住这手。", "哇，这手看得我都想再挑战一次了。", "还挺厉害的嘛，再让我看看。", "辛苦了，这一段打得很稳。"],
        ["fast"] = ["我想听听你刚才的思路。", "走这么快，还能分点注意力给我吧？", "好快。怎么想的？", "呜，跟得好辛苦，等会儿教教我嘛。", "跑得挺快嘛，后面我可要追你了。", "节奏很顺，记得也照顾好生命。"],
        ["ahead"] = ["我想把这个节奏继续保持下去。", "哼哼，看到我的进度了吧？", "继续。这个节奏很好。", "这次轮到我在前面了，还想认真和你比下去。", "追得到我吗？我可继续走了。", "这一段很顺，稳稳把后面也打好。"],
        ["behind"] = ["我先专心处理自己这一层。", "唔，让我把这手打好，我还想追上来。", "先看眼前。还能继续。", "呜，被你拉开了，更想学学你的打法了。", "先让你走一会儿，我还在打呢。", "按自己的节奏走，把每一层看清楚。"],
        ["shop"] = ["我想看看这次调整会怎样发挥。", "买好了就给我看看效果吧。", "记住这次选择。", "你来看看我的选择，认真挑出问题也可以。", "选好了？等会儿让我看看值不值。", "选好以后，把后面要用的资源也留意一下。"],
        ["cards"] = ["这几张牌的配合值得记下来。", "这配合我看清了，下回也要试试看。", "这个顺序。记下了。", "这手好漂亮，轮到我时你也认真指点我吧。", "这手有点意思，藏了什么好配合？", "牌序处理得很仔细，我在旁边看着。"],
        ["act"] = ["我们一起准备下一段路。", "过了！接下来我也会认真打。", "下一幕。一起走。", "呼，又过了一幕，还想继续跟着你学。", "这才刚热起来，下一幕继续。", "辛苦了，稍微松口气再看后面的路线。"],
        ["thought"] = ["我再认真看看手上的选择。", "我也想把这局打得漂亮一点。", "再看一眼。", "认真一点，希望这局能让你多看看我。", "我也有自己的打算，等着看吧。", "先把眼前照顾好，一步一步走。"],
        ["ambient"] = ["一起玩的时候，我也很在意你的思路。", "我在看着呢，好好打给我看吧。", "我在看。", "再陪我认真玩一会儿吧。", "我可一直在看你怎么打。", "慢慢来，我会陪你把这一局打完。"]
    };
```

<a id="symbol-b457de19f0a7"></a>

## `NationalSpire.DateGameVoices.Default(NationalSpire.CareerData, string) — public static string Default(CareerData data, string person)`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LaunchDateGame(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](DateGameScreen.cs.md#symbol-60cf62536a73)；[`NationalSpire.DateGameVoices.Version(NationalSpire.CareerData, NationalSpire.DateGameState, string)`](DateGameVoices.cs.md#symbol-94f34d9c9805)；[`NationalSpire.DatePresentation.Initial(NationalSpire.CareerData, string, bool)`](DatePresentation.cs.md#symbol-8371585517ce)；[`Select()`](DateGameScreen.cs.md#symbol-c15130f82b97)

**调用：** [`NationalSpire.IdentityGender.Of(NationalSpire.CareerData, string)`](IdentityGender.cs.md#symbol-961507352d98)

**字段、属性、事件及方法组引用：** `NationalSpire.IdentityGender.Of(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.IdentityGender.Of(NationalSpire.CareerData, string)`；输入表达式：`IdentityGender.Of(data, person)`；返回值紧邻使用处：`BinaryExpressionSyntax: IdentityGender.Of(data, person) == "女"`

**赋值（含属性/字段和局部值）：**


<a id="symbol-94f34d9c9805"></a>

## `NationalSpire.DateGameVoices.Version(NationalSpire.CareerData, NationalSpire.DateGameState, string) — public static string Version(CareerData data, DateGameState game, string person)`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGameVoices.Event(NationalSpire.CareerData, NationalSpire.DateGameState, NationalSpire.DateGameCue, int)`](DateGameVoices.cs.md#symbol-feac45068c6c)；[`NationalSpire.DateGameVoices.Style(NationalSpire.CareerData, NationalSpire.DateGameState, string, NationalSpire.BroadcastLine)`](DateGameVoices.cs.md#symbol-c55503cf04d2)；[`NationalSpire.DateGameVoices.Style(NationalSpire.CareerData, NationalSpire.DateGameState, string, string, string)`](DateGameVoices.cs.md#symbol-eaf8509231ad)

**调用：** [`NationalSpire.DateGameVoices.Default(NationalSpire.CareerData, string)`](DateGameVoices.cs.md#symbol-b457de19f0a7)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateGameState.Voices`；`NationalSpire.DateGameVoices.Default(NationalSpire.CareerData, string)`；`NationalSpire.DateGameVoices.Ids`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGameVoices.Default(NationalSpire.CareerData, string)`；输入表达式：`Default(data, person)`；返回值紧邻使用处：`ConditionalExpressionSyntax: game.Voices.TryGetValue(person, out var id) && Ids.Contains(id) ? id : Default(data, person)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`game.Voices.TryGetValue(person, out var id)`；返回值紧邻使用处：`BinaryExpressionSyntax: game.Voices.TryGetValue(person, out var id) && Ids.Contains(id)`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`Ids.Contains(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: game.Voices.TryGetValue(person, out var id) && Ids.Contains(id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b9be8e9b0d60"></a>

## `NationalSpire.DateGameVoices.Family(string) — public static string Family(string topic)`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGameVoices.Finish(NationalSpire.CareerData, string, string, string)`](DateGameVoices.cs.md#symbol-0d8429ae95a9)

**调用：** `string.Contains(string)`；`string.Split(char, System.StringSplitOptions)`；`string.StartsWith(string)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Contains(string)`；输入表达式：`topic.Contains("ahead")`；返回值紧邻使用处：`BinaryExpressionSyntax: topic.Contains("ahead") || topic.Contains("lead")`
- `string.Contains(string)`；输入表达式：`topic.Contains("behind")`；返回值紧邻使用处：`BinaryExpressionSyntax: topic.Contains("behind") || topic.Contains("far")`
- `string.Contains(string)`；输入表达式：`topic.Contains("boss")`；返回值紧邻使用处：`BinaryExpressionSyntax: topic is "act1" or "act2" || topic.Contains("boss")`
- `string.Contains(string)`；输入表达式：`topic.Contains("card")`；返回值紧邻使用处：`BinaryExpressionSyntax: topic.Contains("card") || topic.Contains("draw")`
- `string.Contains(string)`；输入表达式：`topic.Contains("champion")`；返回值紧邻使用处：`BinaryExpressionSyntax: topic.Contains("clean") || topic.Contains("champion")`
- `string.Contains(string)`；输入表达式：`topic.Contains("clean")`；返回值紧邻使用处：`BinaryExpressionSyntax: topic.Contains("clean") || topic.Contains("champion")`
- `string.Contains(string)`；输入表达式：`topic.Contains("damage")`；返回值紧邻使用处：`BinaryExpressionSyntax: topic.Contains("damage") && topic.StartsWith("npc")`
- `string.Contains(string)`；输入表达式：`topic.Contains("damage")`；返回值紧邻使用处：`BinaryExpressionSyntax: topic.Contains("card") || topic.Contains("draw") || topic.Contains("energy") || topic.Contains("damage")`
- `string.Contains(string)`；输入表达式：`topic.Contains("danger")`；返回值紧邻使用处：`BinaryExpressionSyntax: topic.Contains("danger") || topic.Contains("hurt")`
- `string.Contains(string)`；输入表达式：`topic.Contains("dead")`；返回值紧邻使用处：`BinaryExpressionSyntax: topic.Contains("dead") || topic.Contains("death")`
- `string.Contains(string)`；输入表达式：`topic.Contains("death")`；返回值紧邻使用处：`BinaryExpressionSyntax: topic.Contains("dead") || topic.Contains("death")`
- `string.Contains(string)`；输入表达式：`topic.Contains("draw")`；返回值紧邻使用处：`BinaryExpressionSyntax: topic.Contains("card") || topic.Contains("draw")`
- `string.Contains(string)`；输入表达式：`topic.Contains("energy")`；返回值紧邻使用处：`BinaryExpressionSyntax: topic.Contains("card") || topic.Contains("draw") || topic.Contains("energy")`
- `string.Contains(string)`；输入表达式：`topic.Contains("far")`；返回值紧邻使用处：`BinaryExpressionSyntax: topic.Contains("behind") || topic.Contains("far")`
- `string.Contains(string)`；输入表达式：`topic.Contains("fast")`；返回值紧邻使用处：`BinaryExpressionSyntax: topic.Contains("quick") || topic.Contains("fast")`
- `string.Contains(string)`；输入表达式：`topic.Contains("finished")`；返回值紧邻使用处：`BinaryExpressionSyntax: topic.Contains("clean") || topic.Contains("champion") || topic.Contains("finished")`
- `string.Contains(string)`；输入表达式：`topic.Contains("hurt")`；返回值紧邻使用处：`BinaryExpressionSyntax: topic.Contains("danger") || topic.Contains("hurt")`
- `string.Contains(string)`；输入表达式：`topic.Contains("lead")`；返回值紧邻使用处：`BinaryExpressionSyntax: topic.Contains("ahead") || topic.Contains("lead")`
- `string.Contains(string)`；输入表达式：`topic.Contains("lost")`；返回值紧邻使用处：`BinaryExpressionSyntax: topic.Contains("dead") || topic.Contains("death") || topic.Contains("lost")`
- `string.Contains(string)`；输入表达式：`topic.Contains("quick")`；返回值紧邻使用处：`BinaryExpressionSyntax: topic.Contains("quick") || topic.Contains("fast")`
- `string.Contains(string)`；输入表达式：`topic.Contains("reward")`；返回值紧邻使用处：`BinaryExpressionSyntax: topic.StartsWith("shop") || topic.Contains("reward")`
- `string.Split(char, System.StringSplitOptions)`；输入表达式：`topic.Split('/')`；返回值紧邻使用处：`ElementAccessExpressionSyntax: topic.Split('/')[0]`
- `string.StartsWith(string)`；输入表达式：`topic.StartsWith("npc")`；返回值紧邻使用处：`BinaryExpressionSyntax: topic.Contains("damage") && topic.StartsWith("npc")`
- `string.StartsWith(string)`；输入表达式：`topic.StartsWith("shop")`；返回值紧邻使用处：`BinaryExpressionSyntax: topic.StartsWith("shop") || topic.Contains("reward")`
- `string.StartsWith(string)`；输入表达式：`topic.StartsWith("thought")`；返回值紧邻使用处：`ConditionalExpressionSyntax: topic.StartsWith("thought") ? "thought" : "ambient"`

**赋值（含属性/字段和局部值）：**

- `topic` = `topic.Split('/')[0]`

<a id="symbol-eaf8509231ad"></a>

## `NationalSpire.DateGameVoices.Style(NationalSpire.CareerData, NationalSpire.DateGameState, string, string, string) — public static string Style(CareerData data, DateGameState game, string person, string topic, string text)`

来源：源码第 45 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGameVoices.Event(NationalSpire.CareerData, NationalSpire.DateGameState, NationalSpire.DateGameCue, int)`](DateGameVoices.cs.md#symbol-feac45068c6c)

**调用：** [`NationalSpire.DateGameContent.RewritePhrase(NationalSpire.CareerData, string, string)`](DateGameContent.cs.md#symbol-28305905e4be)；[`NationalSpire.DateGameVoices.Finish(NationalSpire.CareerData, string, string, string)`](DateGameVoices.cs.md#symbol-0d8429ae95a9)；[`NationalSpire.DateGameVoices.Version(NationalSpire.CareerData, NationalSpire.DateGameState, string)`](DateGameVoices.cs.md#symbol-94f34d9c9805)

**字段、属性、事件及方法组引用：** `NationalSpire.DateGameContent.RewritePhrase(NationalSpire.CareerData, string, string)`；`NationalSpire.DateGameVoices.Finish(NationalSpire.CareerData, string, string, string)`；`NationalSpire.DateGameVoices.Version(NationalSpire.CareerData, NationalSpire.DateGameState, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGameContent.RewritePhrase(NationalSpire.CareerData, string, string)`；输入表达式：`DateGameContent.RewritePhrase(data, profile, text)`；返回值紧邻使用处：`ArgumentSyntax: DateGameContent.RewritePhrase(data, profile, text)`
- `NationalSpire.DateGameVoices.Finish(NationalSpire.CareerData, string, string, string)`；输入表达式：`Finish(data, profile, topic, DateGameContent.RewritePhrase(data, profile, text))`；返回值紧邻使用处：`ReturnStatementSyntax: return Finish(data, profile, topic, DateGameContent.RewritePhrase(data, profile, text));`
- `NationalSpire.DateGameVoices.Version(NationalSpire.CareerData, NationalSpire.DateGameState, string)`；输入表达式：`Version(data, game, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Version(data, game, person)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-036aa782750d"></a>

## `NationalSpire.DateGameVoices.EventLines(NationalSpire.CareerData, string, NationalSpire.DateGameRule) — public static IReadOnlyList<string> EventLines(CareerData data, string profile, DateGameRule rule)`

来源：源码第 50 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Fill()`](DateGameScreen.cs.md#symbol-70f585bf64d5)；[`NationalSpire.DateGameContent.Edits(string, NationalSpire.DateGameContent.Profile, System.Collections.Generic.Dictionary<string, NationalSpire.DateGameContent.Phrase>, System.Collections.Generic.List<NationalSpire.DateGameRule>)`](DateGameContent.cs.md#symbol-608ae4848093)；[`NationalSpire.DateGameContent.Snapshot(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.DateGameRule>?)`](DateGameContent.cs.md#symbol-f9fa9ec59680)

**调用：** [`NationalSpire.DateGameContent.RewritePhrase(NationalSpire.CareerData, string, string)`](DateGameContent.cs.md#symbol-28305905e4be)；[`NationalSpire.DateGameVoices.Finish(NationalSpire.CareerData, string, string, string)`](DateGameVoices.cs.md#symbol-0d8429ae95a9)；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.DateGameVoiceEdits`；`NationalSpire.DateGameContent.RewritePhrase(NationalSpire.CareerData, string, string)`；`NationalSpire.DateGameRule.Lines`；`NationalSpire.DateGameRule.Trigger`；`NationalSpire.DateGameVoices.Finish(NationalSpire.CareerData, string, string, string)`；`NationalSpire.DateVoiceEdits.Triggers`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGameContent.RewritePhrase(NationalSpire.CareerData, string, string)`；输入表达式：`DateGameContent.RewritePhrase(data, profile, line)`；返回值紧邻使用处：`ArgumentSyntax: DateGameContent.RewritePhrase(data, profile, line)`
- `NationalSpire.DateGameVoices.Finish(NationalSpire.CareerData, string, string, string)`；输入表达式：`Finish(data, profile, rule.Trigger, DateGameContent.RewritePhrase(data, profile, line))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: line => Finish(data, profile, rule.Trigger, DateGameContent.RewritePhrase(data, profile, line))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`rule.Lines.Select(line => Finish(data, profile, rule.Trigger, DateGameContent.RewritePhrase(data, profile, line)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: rule.Lines.Select(line => Finish(data, profile, rule.Trigger, DateGameContent.RewritePhrase(data, profile, line))).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`rule.Lines.Select(line => Finish(data, profile, rule.Trigger, DateGameContent.RewritePhrase(data, profile, line))).ToList()`；返回值紧邻使用处：`BinaryExpressionSyntax: data.DateGameVoiceEdits.GetValueOrDefault(profile)?.Triggers.GetValueOrDefault(rule.Trigger) ?? rule.Lines.Select(line => Finish(data, profile, rule.Trigger, DateGameContent.RewritePhrase(data, profile, line))).ToList()`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`.Triggers.GetValueOrDefault(rule.Trigger)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: data.DateGameVoiceEdits.GetValueOrDefault(profile)?.Triggers.GetValueOrDefault(rule.Trigger)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`data.DateGameVoiceEdits.GetValueOrDefault(profile)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: data.DateGameVoiceEdits.GetValueOrDefault(profile)?.Triggers.GetValueOrDefault(rule.Trigger)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-feac45068c6c"></a>

## `NationalSpire.DateGameVoices.Event(NationalSpire.CareerData, NationalSpire.DateGameState, NationalSpire.DateGameCue, int) — public static string Event(CareerData data, DateGameState game, DateGameCue cue, int choice)`

来源：源码第 54 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.UpdateDateGame(NationalSpire.LiveMatchState, NationalSpire.RivalProgress, double, ref bool)`](LiveDateGame.cs.md#symbol-cb87a418530f)

**调用：** [`NationalSpire.DateGameVoices.Style(NationalSpire.CareerData, NationalSpire.DateGameState, string, string, string)`](DateGameVoices.cs.md#symbol-eaf8509231ad)；[`NationalSpire.DateGameVoices.Version(NationalSpire.CareerData, NationalSpire.DateGameState, string)`](DateGameVoices.cs.md#symbol-94f34d9c9805)；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`string.Split(char, System.StringSplitOptions)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.DateGameVoiceEdits`；`NationalSpire.DateGameCue.Key`；`NationalSpire.DateGameCue.Person`；`NationalSpire.DateGameCue.Text`；`NationalSpire.DateGameVoices.Style(NationalSpire.CareerData, NationalSpire.DateGameState, string, string, string)`；`NationalSpire.DateGameVoices.Version(NationalSpire.CareerData, NationalSpire.DateGameState, string)`；`NationalSpire.DateVoiceEdits.Triggers`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGameVoices.Style(NationalSpire.CareerData, NationalSpire.DateGameState, string, string, string)`；输入表达式：`Style(data, game, cue.Person, cue.Key, cue.Text)`；返回值紧邻使用处：`ConditionalExpressionSyntax: lines is { Count: > 0 } ? lines[(choice & int.MaxValue) % lines.Count] : Style(data, game, cue.Person, cue.Key, cue.Text)`
- `NationalSpire.DateGameVoices.Version(NationalSpire.CareerData, NationalSpire.DateGameState, string)`；输入表达式：`Version(data, game, cue.Person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Version(data, game, cue.Person)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`.Triggers.GetValueOrDefault(trigger)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: data.DateGameVoiceEdits.GetValueOrDefault(profile)?.Triggers.GetValueOrDefault(trigger)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`data.DateGameVoiceEdits.GetValueOrDefault(profile)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: data.DateGameVoiceEdits.GetValueOrDefault(profile)?.Triggers.GetValueOrDefault(trigger)`
- `string.Split(char, System.StringSplitOptions)`；输入表达式：`cue.Key.Split('/')`；返回值紧邻使用处：`ElementAccessExpressionSyntax: cue.Key.Split('/')[0]`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c55503cf04d2"></a>

## `NationalSpire.DateGameVoices.Style(NationalSpire.CareerData, NationalSpire.DateGameState, string, NationalSpire.BroadcastLine) — public static string Style(CareerData data, DateGameState game, string person, BroadcastLine line)`

来源：源码第 61 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?)`](LiveRunBridge.cs.md#symbol-c7a514513ce3)

**调用：** [`NationalSpire.DateGameContent.RewritePhrase(NationalSpire.CareerData, string, string)`](DateGameContent.cs.md#symbol-28305905e4be)；[`NationalSpire.DateGameVoices.Finish(NationalSpire.CareerData, string, string, string)`](DateGameVoices.cs.md#symbol-0d8429ae95a9)；[`NationalSpire.DateGameVoices.Version(NationalSpire.CareerData, NationalSpire.DateGameState, string)`](DateGameVoices.cs.md#symbol-94f34d9c9805)；`System.Func<T, TResult>.Invoke(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastLine.Rewrite`；`NationalSpire.BroadcastLine.Text`；`NationalSpire.BroadcastLine.Topic`；`NationalSpire.DateGameContent.RewritePhrase(NationalSpire.CareerData, string, string)`；`NationalSpire.DateGameVoices.Finish(NationalSpire.CareerData, string, string, string)`；`NationalSpire.DateGameVoices.Version(NationalSpire.CareerData, NationalSpire.DateGameState, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGameContent.RewritePhrase(NationalSpire.CareerData, string, string)`；输入表达式：`DateGameContent.RewritePhrase(data, profile, line.Text)`；返回值紧邻使用处：`ConditionalExpressionSyntax: line.Rewrite == null ? DateGameContent.RewritePhrase(data, profile, line.Text) : line.Rewrite(source => DateGameContent.RewritePhrase(data, profile, source))`
- `NationalSpire.DateGameContent.RewritePhrase(NationalSpire.CareerData, string, string)`；输入表达式：`DateGameContent.RewritePhrase(data, profile, source)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: source => DateGameContent.RewritePhrase(data, profile, source)`
- `NationalSpire.DateGameVoices.Finish(NationalSpire.CareerData, string, string, string)`；输入表达式：`Finish(data, profile, line.Topic, text)`；返回值紧邻使用处：`ReturnStatementSyntax: return Finish(data, profile, line.Topic, text);`
- `NationalSpire.DateGameVoices.Version(NationalSpire.CareerData, NationalSpire.DateGameState, string)`；输入表达式：`Version(data, game, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Version(data, game, person)`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`line.Rewrite(source => DateGameContent.RewritePhrase(data, profile, source))`；返回值紧邻使用处：`ConditionalExpressionSyntax: line.Rewrite == null ? DateGameContent.RewritePhrase(data, profile, line.Text) : line.Rewrite(source => DateGameContent.RewritePhrase(data, profile, source))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0d8429ae95a9"></a>

## `NationalSpire.DateGameVoices.Finish(NationalSpire.CareerData, string, string, string) — private static string Finish(CareerData data, string profile, string topic, string text)`

来源：源码第 68 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGameVoices.EventLines(NationalSpire.CareerData, string, NationalSpire.DateGameRule)`](DateGameVoices.cs.md#symbol-036aa782750d)；[`NationalSpire.DateGameVoices.Style(NationalSpire.CareerData, NationalSpire.DateGameState, string, NationalSpire.BroadcastLine)`](DateGameVoices.cs.md#symbol-c55503cf04d2)；[`NationalSpire.DateGameVoices.Style(NationalSpire.CareerData, NationalSpire.DateGameState, string, string, string)`](DateGameVoices.cs.md#symbol-eaf8509231ad)

**调用：** [`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.DateGameContent.Remark(NationalSpire.CareerData, string, string, string)`](DateGameContent.cs.md#symbol-1f7e926e9345)；[`NationalSpire.DateGameVoices.Family(string)`](DateGameVoices.cs.md#symbol-b9be8e9b0d60)；`System.Array.IndexOf<T>(T[], T)`；`System.Text.RegularExpressions.Regex.Replace(string, string, string)`；`string.Replace(string, string?)`；`string.StartsWith(string)`；`string.TrimEnd()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.DateGameContent.Remark(NationalSpire.CareerData, string, string, string)`；`NationalSpire.DateGameVoices.Family(string)`；`NationalSpire.DateGameVoices.Ids`；`NationalSpire.DateGameVoices.Remarks`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(data)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.Name(data)`
- `NationalSpire.DateGameContent.Remark(NationalSpire.CareerData, string, string, string)`；输入表达式：`DateGameContent.Remark(data, profile, Family(topic), version <= 0 ? "" : Remarks[Family(topic)][version - 1])`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateGameContent.Remark(data, profile, Family(topic), version <= 0 ? "" : Remarks[Family(topic)][version - 1])`
- `NationalSpire.DateGameVoices.Family(string)`；输入表达式：`Family(topic)`；返回值紧邻使用处：`ArgumentSyntax: Family(topic)`
- `System.Array.IndexOf<T>(T[], T)`；输入表达式：`Array.IndexOf(Ids, profile)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Array.IndexOf(Ids, profile)`
- `System.Text.RegularExpressions.Regex.Replace(string, string, string)`；输入表达式：`System.Text.RegularExpressions.Regex.Replace(source, @"(?<=^|[。！？，…])他(?=这|那|的|比|先|还|在|想|会|追|怎么)", "你")`；返回值紧邻使用处：`AssignmentExpressionSyntax: source = System.Text.RegularExpressions.Regex.Replace(source, @"(?<=^|[。！？，…])他(?=这|那|的|比|先|还|在|想|会|追|怎么)", "你")`
- `string.Replace(string, string?)`；输入表达式：`source.Replace("狠狠干", "认真打")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: source.Replace("狠狠干", "认真打").Replace`
- `string.Replace(string, string?)`；输入表达式：`source.Replace("狠狠干", "认真打").Replace("干掉", "击败")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: source.Replace("狠狠干", "认真打").Replace("干掉", "击败").Replace`
- `string.Replace(string, string?)`；输入表达式：`source.Replace("狠狠干", "认真打").Replace("干掉", "击败").Replace("牛逼", "漂亮")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: source.Replace("狠狠干", "认真打").Replace("干掉", "击败").Replace("牛逼", "漂亮").Replace`
- `string.Replace(string, string?)`；输入表达式：`source.Replace("狠狠干", "认真打").Replace("干掉", "击败").Replace("牛逼", "漂亮").Replace("卧槽", "真厉害")`；返回值紧邻使用处：`AssignmentExpressionSyntax: source = source.Replace("狠狠干", "认真打").Replace("干掉", "击败").Replace("牛逼", "漂亮").Replace("卧槽", "真厉害")`
- `string.Replace(string, string?)`；输入表达式：`text.Replace(CareerEngine.Name(data), "你")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.Replace(CareerEngine.Name(data), "你").Replace`
- `string.Replace(string, string?)`；输入表达式：`text.Replace(CareerEngine.Name(data), "你").Replace("这家伙", "你")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.Replace(CareerEngine.Name(data), "你").Replace("这家伙", "你").Replace`
- `string.Replace(string, string?)`；输入表达式：`text.Replace(CareerEngine.Name(data), "你").Replace("这家伙", "你").Replace("这小子", "你")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = text.Replace(CareerEngine.Name(data), "你").Replace("这家伙", "你").Replace("这小子", "你")`
- `string.StartsWith(string)`；输入表达式：`topic.StartsWith("thought")`；返回值紧邻使用处：`IfStatementSyntax: if (topic.StartsWith("thought")) source = System.Text.RegularExpressions.Regex.Replace(source, @"(?<=^|[。！？，…])他(?=这|那|的|比|先|还|在|想|会|追|怎么)", "你");`
- `string.TrimEnd()`；输入表达式：`source.TrimEnd()`；返回值紧邻使用处：`BinaryExpressionSyntax: source.TrimEnd() + (remark.Length > 0 ? " " + remark : "")`

**赋值（含属性/字段和局部值）：**

- `source` = `System.Text.RegularExpressions.Regex.Replace(source, @"(?<=^|[。！？，…])他(?=这|那|的|比|先|还|在|想|会|追|怎么)", "你")`
- `source` = `source.Replace("狠狠干", "认真打").Replace("干掉", "击败").Replace("牛逼", "漂亮").Replace("卧槽", "真厉害")`
