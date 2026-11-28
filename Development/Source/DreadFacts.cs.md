# DreadFacts.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`23C47D8558CC3E6C47619EFBA036637E374669EE860B224567F3CC174FCFFF08`。来源：[源码](../../../../NationalSpire/DreadFacts.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.DreadFacts`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly Dictionary<string, (string Name, string Dominion, string Boss)> Facts = new()
    {
        ["AEONGLASS_BOSS"] = ("永世沙漏", "在你的回合开始时，在你的抽牌堆顶加入1张凋萎。", "加大力度加入的凋萎由2张提高到3张，并改为放入抽牌堆。"),
        ["CEREMONIAL_BEAST_BOSS"] = ("仪式兽", "所有敌人获得1层仪式。", "首领基础生命提高30点；横冲直撞未被打断时，获得的力量由2点提高到3点；横冲直撞被打断后，首领获得2层仪式。"),
        ["KAISER_CRAB_BOSS"] = ("帝皇蟹", "所有敌人获得7层覆甲。", "碾碎爪与火箭各获得14层覆甲，火箭的火箭钳基础伤害提高5点。"),
        ["KNOWLEDGE_DEMON_BOSS"] = ("知识恶魔", "在战斗开始时，从2种支配灾祸中选择1种。", "三轮选择中，瓦解的伤害分别由6、7、8点提高到8、9、10点。"),
        ["LAGAVULIN_MATRIARCH_BOSS"] = ("乐加维林族母", "在你的第一回合结束时，失去1点力量和敏捷。", "首领基础生命提高22点；同时攻击和格挡的招式，其基础伤害与格挡各提高2点；削弱招式使玩家失去的力量和敏捷分别由2点提高到3点。"),
        ["QUEEN_BOSS"] = ("女王", "在第2回合开始时，获得3层虚弱、易伤和脆弱。", "首领在首回合同时施加魂缚锁链及99层虚弱、易伤和脆弱；为火炬头聚合体增加的力量由1点提高到2点，火炬头聚合体的强力冲撞基础伤害提高5点。"),
        ["SOUL_FYSH_BOSS"] = ("灵魂异鱼", "在每场战斗开始时，在你的抽牌堆中洗入一张呼唤。", "首领使用呼唤招式时，额外向玩家手牌加入1张呼唤，总数由2张提高到3张。"),
        ["TEST_SUBJECT_BOSS"] = ("实验体", "所有敌人在战斗的第一回合获得3点力量。", "首领的激怒由3层提高到4层，连续爪击的基础次数由3次提高到4次，燃烧之吼获得的力量由3点提高到6点。"),
        ["THE_INSATIABLE_BOSS"] = ("无厌沙虫", "在你的回合结束时，根据当前回合数受到伤害。", "首领基础生命提高20点，沙坑的吞噬倒计时由4回合减少至3回合。"),
        ["THE_KIN_BOSS"] = ("同族小队", "你在战斗开始时拥有2层虚弱和脆弱。", "额外出现1名同族信徒，信徒数量由2名增加至3名。"),
        ["VANTOM_BOSS"] = ("墨影幻灵", "普通敌人获得1层滑溜。精英获得2层滑溜。", "首领开场的滑溜由9层提高到11层，使用准备招式时获得的力量由2点提高到3点。"),
        ["WATERFALL_GIANT_BOSS"] = ("瀑布巨兽", "敌人死亡时会爆炸，造成伤害。", "首领每次积累的蒸汽喷发由3层提高到4层。"),
    };
```

<a id="symbol-f5ed76aeee69"></a>

## `NationalSpire.DreadFacts.Capture(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Runs.IRunState) — public static void Capture(CareerMatch match, IRunState run)`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameBridge.ReadDefeatedEncounters(MegaCrit.Sts2.Core.Runs.RunHistory, NationalSpire.CareerMatch?)`](GameBridge.cs.md#symbol-0910b7cd5c5f)；[`NationalSpire.LiveMaps.Read(MegaCrit.Sts2.Core.Runs.IRunState, NationalSpire.CareerMatch, bool)`](LiveMaps.cs.md#symbol-c878186b1e5a)

**调用：** `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`NationalSpire.DreadActFact.DreadActFact(string, string)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Enum.ToString()`

**字段、属性、事件及方法组引用：** `(string Name, string Dominion, string Boss).Boss`；`(string Name, string Dominion, string Boss).Dominion`；`(string Name, string Dominion, string Boss).Name`；`NationalSpire.CareerMatch.DreadDominions`；`NationalSpire.DreadActFact.Boss`；`NationalSpire.DreadFacts.Facts`；`NationalSpire.MatchModes.Dread`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`provider.Id.ToString()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = provider.Id.ToString()`
- `NationalSpire.DreadActFact.DreadActFact(string, string)`；输入表达式：`new(id, fact.Dominion + boss)`；返回值紧邻使用处：`AssignmentExpressionSyntax: match.DreadDominions[act + 1] = new(id, fact.Dominion + boss)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Facts.TryGetValue(first.Id.Entry, out var firstFact)`；返回值紧邻使用处：`BinaryExpressionSyntax: second != null && Facts.TryGetValue(first.Id.Entry, out var firstFact)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Facts.TryGetValue(provider.Id.Entry, out var fact)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Facts.TryGetValue(provider.Id.Entry, out var fact)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`match.DreadDominions.TryGetValue(act + 1, out var previous)`；返回值紧邻使用处：`BinaryExpressionSyntax: match.DreadDominions.TryGetValue(act + 1, out var previous) && previous.Boss == id`
- `System.Enum.ToString()`；输入表达式：`run.GameMode.ToString()`；返回值紧邻使用处：`BinaryExpressionSyntax: run.GameMode.ToString() != MatchModes.Dread`

**赋值（含属性/字段和局部值）：**

- `match.DreadDominions[act + 1]` = `new(id, fact.Dominion + boss)`
- `match.DreadDominions` ??= `[]`

<a id="symbol-eed00a23a71a"></a>

## `NationalSpire.DreadFacts.Effect(NationalSpire.CareerMatch?, int, string) — public static string? Effect(CareerMatch? match, int act, string encounter)`

来源：源码第 45 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameBridge.ReadDefeatedEncounters(MegaCrit.Sts2.Core.Runs.RunHistory, NationalSpire.CareerMatch?)`](GameBridge.cs.md#symbol-0910b7cd5c5f)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMatch.DreadDominions`；`NationalSpire.DreadActFact.Boss`；`NationalSpire.DreadActFact.Description`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`.TryGetValue(act, out var fact)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .DreadDominions?.TryGetValue(act, out var fact)`

**赋值（含属性/字段和局部值）：**
