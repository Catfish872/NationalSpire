namespace NationalSpire;

public static class ClubOperations
{
    public static void Entry(CareerClub club, int day, string title, int amount)
    {
        club.Ledger.Add(new() { Day = day, Title = title, Amount = amount, Balance = club.Budget });
        if (club.Ledger.Count > 36) club.Ledger.RemoveRange(0, club.Ledger.Count - 36);
    }
    public static void Advance(CareerData d)
    {
        if (d.Life.Version == 0) return;
        foreach (var club in d.Esports.Clubs.Where(c => c.Id != d.Esports.OwnedClub?.ClubId))
        {
            if (club.NextOperatingDay == 0) club.NextOperatingDay = d.Day + 7 + CareerEngine.StableHash(club.Id) % 7;
            if (club.NextOperatingDay > d.Day) continue;
            club.NextOperatingDay = d.Day + 14; club.LastOperatingSeason = d.Season;
            var members = d.People.Where(p => p.ClubId == club.Id).ToList();
            int professionals = members.Count(EsportsWorld.IsProfessional);
            int income = Math.Max(100, club.OperatingIncome / 6);
            club.Budget += income; Entry(club, d.Day, "本期运营收入", income);
            int wages = Math.Min(Math.Max(0, club.Budget - club.TrainingFund), professionals * 180 + members.Count(p => p.Role == "青训选手") * 45);
            club.Budget -= wages; Entry(club, d.Day, "人员与场地支出", -wages);
            int training = Math.Min(club.Budget, (club.Identity == "青训俱乐部" ? 220 : 120) + club.TrainingFund);
            club.TrainingFund = 0; club.Budget -= training; Entry(club, d.Day, "训练与专项支持", -training);
            var youth = members.Where(p => p.Role == "青训选手").OrderBy(p => CareerEngine.StableHash(p.Id + d.Day)).Take(2).ToList();
            var progress = new List<string>();
            foreach (var p in youth)
            {
                int gain = CareerLife.Grow(d, p, training / Math.Max(1, youth.Count), club.Id + d.Day);
                if (gain > 0) progress.Add($"{p.PublicName}阶段训练进步，评分增加{gain}");
            }
            var senior = members.Where(EsportsWorld.IsProfessional).OrderBy(p => CareerEngine.StableHash(p.Id + ":senior:" + d.Day)).FirstOrDefault();
            if (senior != null && CareerLife.Grow(d, senior, CareerCommerce.TrainingInvestment(training / 2, 90), club.Id + ":senior:" + d.Day) is var seniorGain && seniorGain > 0)
                progress.Add($"{senior.PublicName}训练有所进步，评分增加{seniorGain}");
            int overhead = Math.Min(Math.Max(0, club.Budget - 12000), club.Budget / 150);
            if (overhead > 0) { club.Budget -= overhead; Entry(club, d.Day, "设备维护与后勤", -overhead); }
            string direction = club.Identity switch {
                "商业俱乐部" => "本期继续安排品牌合作与观众活动", "争冠强队" => "教练组按近期比赛准备下一轮阵容",
                "青训俱乐部" => "训练资源优先用于新人", _ => "保留资金，继续考察轮换人选" };
            club.SeasonReport = $"第{d.Day}天：运营收入{CareerMoney.Format(income)}，人员与场地支出{CareerMoney.Format(wages)}，训练投入{CareerMoney.Format(training)}。"
                + (progress.Count > 0 ? string.Join("；", progress) + "。" : "本期训练按计划完成。") + direction + "。";
            if (club.Id == d.Esports.ClubId && progress.Count > 0)
                CareerLife.AddEvent(d, "club-progress-" + club.Id + "-" + d.Day, "俱乐部", club.Name + "公布阶段进展", string.Join("；", progress), youth.Select(p => p.Id).ToList());
            TryTransfer(d, club);
        }
    }
    private static void TryTransfer(CareerData d, CareerClub buyer)
    {
        if (d.Season <= 1 || buyer.LastTransferSeason >= d.Season || SeasonCalendar.Day(d, d.Day) > SeasonCalendar.LeagueDeadline(d)
            || buyer.Budget - buyer.TrainingFund < 12000 || CareerEngine.StableHash(buyer.Id + d.Season) % 3 != 0) return;
        var roster = d.People.Where(p => p.ClubId == buyer.Id && EsportsWorld.IsProfessional(p)).ToList();
        if (roster.Count >= 8) return;
        int weakest = roster.Select(p => p.Rating).DefaultIfEmpty(1000).Min();
        var candidate = d.People.Where(p => p.Country == buyer.Country && !OwnedClubs.TransferReserved(d, p.Id) && p.ClubId != d.Esports.OwnedClub?.ClubId && p.ClubId != buyer.Id && EsportsWorld.IsProfessional(p)
            && p.Rating > weakest + 20 && OwnedClubs.CanSparePlayer(d, p)
            && d.Esports.Clubs.Any(c => c.Id == p.ClubId && c.LastTransferSeason < d.Season))
            .OrderBy(p => p.Rating).FirstOrDefault();
        if (candidate == null) return;
        int fee = Math.Clamp(candidate.Rating * 5, 4000, 10000);
        if (buyer.Budget - buyer.TrainingFund < fee + 6000) return;
        var seller = EsportsWorld.Club(d, candidate.ClubId)!;
        buyer.Budget -= fee; seller.Budget += fee; candidate.ClubId = buyer.Id;
        buyer.LastTransferSeason = seller.LastTransferSeason = d.Season;
        Entry(buyer, d.Day, "签入" + candidate.PublicName, -fee); Entry(seller, d.Day, candidate.PublicName + "转会收入", fee);
        string fact = $"{candidate.PublicName}从{seller.Name}转入{buyer.Name}，转会费{CareerMoney.Format(fee)}。已确认的赛事名单继续有效，新名单在下次报名时采用。";
        buyer.SeasonReport += fact; seller.SeasonReport += fact;
        string key = "transfer-life-" + candidate.Id + "-" + d.Season;
        string title = candidate.PublicName + "加盟" + buyer.Name;
        CareerLife.AddEvent(d, key, "转会", title, fact, [candidate.Id], true);
        CareerEngine.Publish(d, key, title, fact, "转会", true, [candidate.Id]);
        if (d.Posts.FirstOrDefault(p => p.EventKey == key) is { } post)
            d.Life.Events.Single(e => e.Id == key).PostId = post.Id;
    }
}
