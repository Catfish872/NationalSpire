namespace NationalSpire.Solver;

// 上游计算卡效与能力收益。对决按实际的防守结果和已经登记的意图比较候选牌序。
internal static class LeagueDuelScore
{
    internal static decimal Defender(int hp, int deferredDoom, bool dead, decimal setupScore, int stars) =>
        (dead ? -10000 : Math.Max(.1m, hp - deferredDoom * .85m) * 1.6m) + setupScore + stars * .5m;

    internal static decimal ForgedBlade(int damage, int enemyHp) => .65m * Math.Min(damage, enemyHp);

    internal static decimal Opponent(int initialHp, int initialBlock, int hp, int attack, int through,
        int poison, int activeDoom, int deferredDoom, bool defenderDead)
    {
        decimal value = Math.Min(initialHp + initialBlock, attack + initialHp - hp)
            + 1.5m * poison + .85m * (activeDoom + deferredDoom);
        if (activeDoom > 0 && activeDoom >= hp - through && !defenderDead) value += initialHp;
        return value;
    }

    internal static decimal Continue(decimal endScore, int usableCards, int energy) =>
        endScore + usableCards * .8m + energy * 1.25m;
}
