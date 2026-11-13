using System.Reflection;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Runs;

namespace NationalSpire;

/// <summary>保存游戏实际选定的整幕支配来源，供结算和重启恢复读取。</summary>
public static class DreadFacts
{
    private static readonly MethodInfo? Dominion = typeof(EncounterModel).GetMethod("GetDominion", Type.EmptyTypes);
    private static readonly PropertyInfo? Description = typeof(EncounterModel).Assembly
        .GetType("MegaCrit.Sts2.Core.Models.Dread.DominionModel")?.GetProperty("Description");

    public static void Capture(CareerMatch match, IRunState run)
    {
        if (run.GameMode.ToString() != MatchModes.Dread) return;
        match.DreadDominions ??= [];
        for (int act = 0; act < run.Acts.Count; act++)
        {
            var encounter = run.Acts[act].SecondBossEncounter ?? run.Acts[act].BossEncounter;
            string id = encounter.Id.ToString();
            if (match.DreadDominions.TryGetValue(act + 1, out var previous) && previous.Boss == id) continue;
            if (Dominion?.Invoke(encounter, null) is not { } dominion
                || Description?.GetValue(dominion) is not LocString description) continue;
            string text = GameText.Plain(description.GetFormattedText());
            // 当前中文资源误写为仅第一回合；实际逻辑在敌人进入战斗时施加，包含后续召唤。
            if (encounter.Id.Entry == "TEST_SUBJECT_BOSS")
                text = "所有敌人进入战斗时获得3点力量。";
            string ordinary = text.Replace("你的", "玩家的").Replace("你在", "玩家在"), elite = ordinary;
            if (encounter.GetType().Name == "QueenBoss")
                ordinary = elite = "第2回合开始时，玩家获得3层虚弱、易伤和脆弱。";
            else if (encounter.GetType().Name == "VantomBoss")
            {
                ordinary = "敌人进入战斗时获得1层滑溜，后续召唤的敌人也获得1层滑溜。";
                elite = "敌人进入战斗时获得2层滑溜，后续召唤的敌人获得1层滑溜。";
            }
            else if (encounter.GetType().Name == "WaterfallGiantBoss")
            {
                ordinary = "敌人死亡时造成爆炸伤害。多名敌人时每只造成3点；单个弱敌造成4点，其他单个普通敌人造成5点。";
                elite = "敌人死亡时造成爆炸伤害。多名敌人时每只造成3点，单个精英造成7点。";
            }
            else if (encounter.GetType().Name == "KnowledgeDemonBoss")
                ordinary = elite = "首回合从懒惰和失忆中选择1项灾祸。懒惰使玩家每回合最多打出3张牌；失忆使玩家本回合少抽2张牌，并失去1点能量。";
            else if (encounter.GetType().Name == "TheInsatiableBoss")
                ordinary = elite = "玩家每回合结束时受到当前回合数加2点伤害。";
            var bosses = new[] { run.Acts[act].BossEncounter, run.Acts[act].SecondBossEncounter }
                .Where(b => b != null).Select(b => (Boss: b!, Effect: BossEffect(b!))).Where(b => b.Effect.Length > 0).ToArray();
            string boss = string.Join("", bosses.Select(b => bosses.Length > 1 ? GameText.Plain(b.Boss.Title.GetFormattedText()) + "的首领战中，" + b.Effect : b.Effect));
            match.DreadDominions[act + 1] = new(id, "普通战斗中，" + ordinary + "精英战斗中，" + elite + (boss.Length > 0 ? (bosses.Length == 1 ? "首领战中，" : "") + boss : ""));
        }
    }

    public static string? Effect(CareerMatch? match, int act, string encounter)
        => match?.DreadDominions?.TryGetValue(act, out var fact) == true && fact.Boss == encounter ? fact.Description : null;

    // 集中记录当前游戏的首领自身强化；整幕支配文字优先读取游戏中文资源。
    private static string BossEffect(EncounterModel boss) => boss.GetType().Name switch
    {
        "TheKinBoss" => "额外出现1名同族信徒，信徒数量由2名增加至3名。",
        "CeremonialBeastBoss" => "首领基础生命提高30点；横冲直撞未被打断时，获得的力量由2点提高到3点；横冲直撞被打断后，首领获得2层仪式。",
        "VantomBoss" => "首领开场的滑溜由9层提高到11层，使用准备招式时获得的力量由2点提高到3点。",
        "WaterfallGiantBoss" => "首领每次积累的蒸汽喷发由3层提高到4层。",
        "LagavulinMatriarchBoss" => "首领基础生命提高22点；同时攻击和格挡的招式，其基础伤害与格挡各提高2点；削弱招式使玩家失去的力量和敏捷分别由2点提高到3点。",
        "SoulFyshBoss" => "首领使用呼唤招式时，额外向玩家手牌加入1张呼唤，总数由2张提高到3张。",
        "KaiserCrabBoss" => "碾碎爪与火箭各获得14层覆甲，火箭的火箭钳基础伤害提高5点。",
        "TheInsatiableBoss" => "首领基础生命提高20点，沙坑的吞噬倒计时由4回合减少至3回合。",
        "KnowledgeDemonBoss" => "三轮选择中，瓦解的伤害分别由6、7、8点提高到8、9、10点。",
        "TestSubjectBoss" => "首领的激怒由3层提高到4层，连续爪击的基础次数由3次提高到4次，燃烧之吼获得的力量由3点提高到6点。",
        "AeonglassBoss" => "加大力度加入的凋萎由2张提高到3张，并改为放入抽牌堆。",
        "QueenBoss" => "首领在首回合同时施加魂缚锁链及99层虚弱、易伤和脆弱；为火炬头聚合体增加的力量由1点提高到2点，火炬头聚合体的强力冲撞基础伤害提高5点。",
        _ => ""
    };

}
