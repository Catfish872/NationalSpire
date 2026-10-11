using MegaCrit.Sts2.Core.Map;
using MegaCrit.Sts2.Core.Runs;

namespace NationalSpire;

/// <summary>读取当前实际地图；后续幕预测失败时，只替换该幕的模拟路线。</summary>
public static class LiveMaps
{
    public static List<RouteNode> Read(IRunState run, CareerMatch match, bool cooperative)
    {
        var nodes = new List<RouteNode>();
        for (int act = 0; act < run.Acts.Count; act++)
        {
            bool second = match.RequiredAscension >= 10 && act == run.Acts.Count - 1;
            if (act == run.CurrentActIndex) { nodes.AddRange(Copy(run.Map, act, second)); continue; }
            try
            {
                var map = new StandardActMap(GameCompatibility.MapRng(run.Rng, act + 1), run.Acts[act], cooperative, false, second);
                nodes.AddRange(Copy(map, act, second));
            }
            catch (Exception e)
            {
                Diagnostics.Error("live.map_prediction", e);
                Diagnostics.Record("live.independent_route", new { match = match.Id, act, cooperative, model = run.Acts[act].Id.ToString() });
                nodes.AddRange(RivalSimulation.IndependentMap(act, run.Acts[act].GetNumberOfRooms(cooperative), second, match.Seed));
            }
        }
        return nodes;
    }

    public static List<RouteNode> Copy(ActMap map, int act, bool secondBoss)
    {
        var all = map.GetAllMapPoints().Append(map.StartingMapPoint).Append(map.BossMapPoint);
        if (secondBoss && map.SecondBossMapPoint != null) all = all.Append(map.SecondBossMapPoint);
        return all.DistinctBy(p => p.coord).Select(p => new RouteNode(act, p.coord.row, p.coord.col, p.PointType.ToString(),
            p.Children.Where(c => secondBoss || c != map.SecondBossMapPoint).Select(c => (c.coord.row, c.coord.col)).ToList())).ToList();
    }

    public static bool Matches(ActMap map, IEnumerable<RivalStep> steps, int act)
    {
        var route = steps.Where(s => s.Act == act).ToList();
        for (int i = 0; i < route.Count; i++)
        {
            var step = route[i];
            if (step.IndependentRoute || map.GetPoint(new(step.Col, step.Row)) is not { } point || point.PointType.ToString() != step.Kind) return false;
            if (i > 0)
            {
                var previous = map.GetPoint(new(route[i - 1].Col, route[i - 1].Row));
                if (previous == null || !previous.Children.Any(c => c.coord == point.coord)) return false;
            }
        }
        return true;
    }
}
