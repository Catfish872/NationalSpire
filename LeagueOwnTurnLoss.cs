using MegaCrit.Sts2.Core.Models.Powers;
using MegaCrit.Sts2.Core.Models.Relics;

namespace NationalSpire;

internal static class LeagueOwnTurnLoss
{
    // 这三项原生效果用当前行动方识别自己回合失血。实战与推演共用名单。
    internal static readonly Type[] Effects = [typeof(RupturePower), typeof(InfernoPower), typeof(DemonTongue)];
}
