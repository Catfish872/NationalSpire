namespace NationalSpire;

/// <summary>新生涯先确定赛季和国家发展水平，导入角色后才处理俱乐部归属。</summary>
public sealed class CareerOpeningWorld
{
    public int Season { get; set; } = 1;
    public Dictionary<string, Dictionary<string,int>> Levels { get; set; } = [];
    public string ClubMode { get; set; } = "";
    public string ClubName { get; set; } = "";
    public string ClubCountry { get; set; } = "";
    public string ClubSponsor { get; set; } = "";

    internal async Task Prepare(CareerData d, Func<Task> yieldFrame)
    {
        if (d.Season < Season)
        {
            // 新世界尚无玩家。正式比赛、俱乐部运营、选手训练及行情按游戏日期推进。
            d.Matches.Clear();
            d.Life.RandomEvents.Clear();
            CareerMarket.Initialize(d);
            var frame = System.Diagnostics.Stopwatch.StartNew();
            while (d.Season < Season)
            {
                EsportsWorld.EndDay(d, d.Day, false);
                if (d.Day == SeasonCalendar.End(d))
                {
                    SeasonCeremony.Close(d);
                    d.Day++; d.Season++;
                    CircuitWorld.StartSeason(d, beforePlayerJoins: d.Season < Season);
                }
                else d.Day++;
                ClubOperations.Advance(d);
                CareerEngine.SimulateNpcTraining(d, new Random(CareerEngine.StableHash($"{d.WorldId}:world:{d.Day}")));
                CareerMarket.Advance(d);
                if (frame.ElapsedMilliseconds >= 16 || d.Day == SeasonCalendar.Start(d) + 1)
                { await yieldFrame(); frame.Restart(); }
            }
            foreach (var post in d.Posts.Where(p => p.Day < d.Day)) post.AiPending = false;
            d.PendingCeremonySeason = 0;
            d.Life.NextOfferDay = d.Day + 2; d.Life.NextProjectDay = d.Day + 21;
            RandomEvents.Schedule(d.Life, d.Day, d.WorldId);
        }
        NationalDevelopment.Ensure(d);
        foreach (var nation in d.Esports.Nations)
            if (Levels.TryGetValue(nation.Country, out var levels))
                foreach (var i in NationalDevelopment.All)
                    if (levels.TryGetValue(i.Id, out int level)) { nation.Indicators[i.Id] = Math.Clamp(level,0,9); nation.Progress.Remove(i.Id); nation.ExtraProgress.Remove(i.Id); }
    }
}
