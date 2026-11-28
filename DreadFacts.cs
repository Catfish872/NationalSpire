using MegaCrit.Sts2.Core.Runs;

namespace NationalSpire;

/// <summary>按本局各幕首领保存战报所用的固定说明。</summary>
public static class DreadFacts
{
    // 支配说明取自游戏简体中文 ascension.json，人数占位符使用单人值。
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

    public static void Capture(CareerMatch match, IRunState run)
    {
        if (run.GameMode.ToString() != MatchModes.Dread) return;
        match.DreadDominions ??= [];
        for (int act = 0; act < run.Acts.Count; act++)
        {
            var first = run.Acts[act].BossEncounter;
            var second = run.Acts[act].SecondBossEncounter;
            var provider = second ?? first;
            string id = provider.Id.ToString();
            if (match.DreadDominions.TryGetValue(act + 1, out var previous) && previous.Boss == id) continue;
            if (!Facts.TryGetValue(provider.Id.Entry, out var fact)) continue;

            string boss = second != null && Facts.TryGetValue(first.Id.Entry, out var firstFact)
                ? firstFact.Name + "的首领战中，" + firstFact.Boss + fact.Name + "的首领战中，" + fact.Boss
                : "首领战中，" + fact.Boss;
            match.DreadDominions[act + 1] = new(id, fact.Dominion + boss);
        }
    }

    public static string? Effect(CareerMatch? match, int act, string encounter)
        => match?.DreadDominions?.TryGetValue(act, out var fact) == true && fact.Boss == encounter ? fact.Description : null;
}
