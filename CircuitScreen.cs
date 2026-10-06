using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private string ClubRole(CareerData d, string club, string id) => d.Esports.OwnedClub is { } own && own.ClubId == club
        ? OwnedClubs.Position(own, id)
        : d.Esports.Competitions.Any(c => c.Season == d.Season && c.Kind == "league" && c.Rosters.GetValueOrDefault(club)?.Contains(id) == true) ? "本季首发" : "轮换选手";
    private void ShowSponsors(CareerData d)
    {
        _content.AddChild(Text("商业合作", 24, _gold));
        var contracts = d.Esports.Sponsors.Where(s => (s.TargetId == "player" && s.Accepted || d.Esports.ClubId.Length > 0 && s.TargetId == d.Esports.ClubId)
            && s.EndedDay == 0 && s.StartSeason <= d.Season && s.EndSeason >= d.Season).ToList();
        foreach (var contract in contracts)
        {
            var card = Card(); _content.AddChild(card); var box = Inner(card);
            box.AddChild(Text(contract.Brand + "  /  " + (contract.TargetId == "player" ? "个人赞助" : "俱乐部赞助"), 24, _gold));
            box.AddChild(Text(contract.TargetId == "player" ? CareerCommerce.SponsorTerms(contract) : $"合作至第 {contract.EndSeason} 赛季 · 每赛季支持球队 {CareerMoney.Format(contract.Retainer)}", 17, _ink));
            box.AddChild(Text(contract.Slogan, 17, _muted));
            if (contract.Description.Length > 0) box.AddChild(Text(contract.Description, 16, _muted));
        }
        if (CareerCommerce.ActiveSponsor(d) == null)
        {
            _content.AddChild(Text(d.Esports.License < 3 ? "取得职业资格后，将收到个人赞助邀请。" : "挑选一份个人赞助，也可以稍后决定。接受后发放本季支持，合同到期后重新选择。", 17, _muted));
            foreach (var offer in d.Esports.SponsorOffers.Where(s => s.ExpiresDay >= d.Day))
            {
                var card = Card(); _content.AddChild(card); var box = Inner(card);
                box.AddChild(Text(offer.Brand + "  /  " + offer.Plan, 24, _gold));
                box.AddChild(Text(CareerCommerce.SponsorTerms(offer), 17, _ink));
                box.AddChild(Text(offer.Slogan + $" · 邀请剩余 {offer.ExpiresDay - d.Day + 1} 天", 16, _muted));
                if (offer.Description.Length > 0) box.AddChild(Text(offer.Description, 16, _muted));
                box.AddChild(Button("接受赞助", () =>
                {
                    if (MultiplayerCommand("sponsor", offer.Id)) return; var error = CareerCommerce.AcceptSponsor(d, offer); Render(); Notice(error ?? "合作已确认，本季支持已经到账。", error != null);

                }, 180));
            }
        }
        _content.AddChild(Button("安排赛场之外的生活 →", () => Visit(() => _tab = "生涯生活"), 310));
    }
    private void NationRanking(CareerData data)
    {
        _content.AddChild(Text($"第 {CircuitLedger.Year(data.Season)} 年 · 国运榜", 30, _gold));
        _content.AddChild(Text("在国际赛事中为国家争取更高名次。国运榜每四赛季重新排名，国运带来的资金会支持选手、俱乐部和青训。", 17, _muted));
        int rank = 0;
        var nationTable = CircuitLedger.NationTable(data);
        foreach (var row in CircuitLedger.NationTable(data))
        {
            var nation = data.Esports.Nations.FirstOrDefault(n => n.Country == row.Country);
            var card = Card(); _content.AddChild(card); var box = Inner(card);
            rank = nationTable.Count(n => n.Points > row.Points) + 1;
            box.AddChild(Text($"{rank:00}   {row.Country}    {row.Points} 国运" + (row.Country == data.Esports.Country ? "   ·   我的国家" : ""), 25, row.Country == data.Esports.Country ? _gold : _ink));
            var awards = data.Esports.CircuitAwards.Where(a => a.Country == row.Country && CircuitLedger.Year(a.Season) == CircuitLedger.Year(data.Season) && a.Fortune > 0).ToList();
            int own = awards.Where(a => a.PersonId == "player").Sum(a => a.Fortune);
            box.AddChild(Text($"储备资金 {CareerMoney.Format(nation?.Treasury ?? 0)}    ·    累计投入 {CareerMoney.Format(nation?.Development ?? 0)}" + (own > 0 ? $"    ·    我的贡献 {own}（{own * 100 / Math.Max(1, row.Points)}%）" : ""), 17, CareerVisuals.Teal));
            foreach (var contribution in awards.GroupBy(a => a.PersonId).OrderByDescending(g => g.Sum(a => a.Fortune)).Take(3))
                box.AddChild(PersonLink(data, contribution.Key, $"{CareerEngine.DisplayName(data, contribution.Key)}    +{contribution.Sum(a => a.Fortune)} 国运   ↗", 36));
            foreach (var source in awards.GroupBy(a => a.CompetitionId).OrderByDescending(g => g.First().Day).Take(3))
                box.AddChild(Text($"第 {source.First().Season} 赛季 · {source.First().Event}    +{source.Sum(a => a.Fortune)}", 15, _muted));
        }
    }
    private void WorldHonors(CareerData data)
    {
        _content.AddChild(Text("世界总决赛 · 荣誉榜", 30, _gold));
        _content.AddChild(Text("新一届冠军诞生前，这里保留上届世界总决赛排名。", 17, _muted));
        var latest = data.Esports.CircuitAwards.Where(a => a.Kind == "worldfinal").Select(a => a.Season).DefaultIfEmpty(0).Max();
        var current = data.Esports.Competitions.FirstOrDefault(c => c.Season == data.Season && c.Kind == "worldfinal");
        if (current != null) _content.AddChild(Button("本届签表与比赛结果   →", () => OpenCompetition(current.Id), 400));
        if (latest == 0) { _content.AddChild(Text("首届世界总决赛席位将在联赛结束后公布。联赛个人前二自动入围，其余席位按世界积分和本季表现补齐。", 20, _ink)); return; }
        foreach (var award in data.Esports.CircuitAwards.Where(a => a.Kind == "worldfinal" && a.Season == latest).OrderBy(a => a.Stage).ThenBy(a => a.PersonId))
        {
            var card = Card(); _content.AddChild(card); var box = Inner(card);
            box.AddChild(Text($"第 {award.Season} 赛季 · {award.Place}    /    {award.Country}", 22, award.Stage == 1 ? _gold : _ink));
            box.AddChild(PersonLink(data, award.PersonId, CareerEngine.DisplayName(data, award.PersonId) + "   ↗", 54));
            box.AddChild(Text(EsportsWorld.ClubName(data, award.ClubId) + $"    ·    {award.Points} 积分    ·    {award.Fortune} 国运", 16, _muted));
            var competition = data.Esports.Competitions.FirstOrDefault(c => c.Id == award.CompetitionId);
            if (competition != null)
            {
                var defeated = competition.Fixtures.Where(f => f.WinnerId == award.PersonId).OrderBy(f => f.Round)
                    .Select(f => CareerEngine.DisplayName(data, f.HomeId == award.PersonId ? f.AwayId : f.HomeId));
                box.AddChild(Text("晋级之路：" + string.Join(" → ", defeated.DefaultIfEmpty("首轮止步")), 16, _muted));
            }
        }
    }
    private void CircuitRanking(CareerData data)
    {
        _content.AddChild(Text("世界积分榜", 30, _gold));
        _content.AddChild(Text("最近四赛季，取最高六项赛事成绩相加。新赛季开始时，四赛季以前的成绩到期。", 18, _ink));
        _content.AddChild(Text("国内联赛个人：第1名300分，第2名180分，第3—4名105分，第5—8名54分，其余20分。\n世界总决赛：冠军1500分，亚军900分，四强525分，八强270分，十六强120分，三十二强50分。", 16, _muted));
        var own = CircuitLedger.Counted(data, "player").ToList();
        var summary = Card(); _content.AddChild(summary); var sb = Inner(summary);
        sb.AddChild(Text($"我的积分：{own.Sum(a => a.Points)}    /    已计入 {own.Count} 项成绩", 24, _gold));
        foreach (var award in own) sb.AddChild(Text($"第{award.Season}赛季 {award.Event} · {award.Place}：{award.Points}分    （第{award.Season + 4}赛季开始到期）", 16, _ink));
        int rank = 0;
        var ranking = data.Esports.CircuitAwards.Select(a => a.PersonId).Distinct().Select(id => (Id: id, Points: CircuitLedger.Points(data, id)))
            .Where(x => x.Points > 0).OrderByDescending(x => x.Points).ThenBy(x => x.Id, StringComparer.Ordinal).ToList();
        int ownRank = ranking.Any(x => x.Id == "player") ? ranking.Count(x => x.Points > CircuitLedger.Points(data, "player")) + 1 : 0;
        if (ownRank > 0) sb.AddChild(Text($"当前排名：第 {ownRank} 名", 18, CareerVisuals.Teal));
        _content.AddChild(Text("同分并列。下方展示前64位，个人排名始终显示在上方。", 15, _muted));
        foreach (var row in ranking.Take(64))
        {
            rank = ranking.Count(x => x.Points > row.Points) + 1;
            _content.AddChild(PersonLink(data, row.Id, $"{rank:00}   {CareerEngine.DisplayName(data, row.Id)}    {row.Points} 分   ↗", 40));
        }
        if (ranking.Count == 0) _content.AddChild(Text("首项赛事结束后公布积分。", 18, _muted));
    }
    private void ModernCompetition(CareerData data, WorldCompetition c)
    {
        _content.AddChild(Text($"第 {c.Season} 赛季 · {c.Name}", 28, _gold));
        _content.AddChild(Text(c.TeamEvent ? "每队三名选手各打一场，先赢两场的队伍获胜。你只需完成自己的比赛。" : "每轮一场，获胜晋级。通关优先，双方通关比较用时，双方失败比较楼层，同成绩加赛。", 17, _muted));
        if (c.Finished) _content.AddChild(Text("◆ 冠军：" + (c.TeamEvent ? CircuitWorld.TeamName(data, c, c.ChampionTeam) : CareerEngine.DisplayName(data, c.ChampionId)), 25, _gold));
        if (c.Kind == "league")
        {
            _content.AddChild(Text("俱乐部积分：胜3分、平1分、负0分；同分比较个人对决胜场。前二进入洲际杯。", 17, _ink));
            int rank = 0;
            foreach (var row in CircuitWorld.TeamTable(c)) _content.AddChild(Text($"{++rank:00}   {CircuitWorld.TeamName(data, c, row.PersonId)}    {row.Points}分    {row.Wins}胜 {row.Draws}平 {row.Losses}负", 19, row.PersonId == data.Esports.ClubId ? _gold : _ink));
            _content.AddChild(Text("奇数赛季个人表现前二自动进入世界总决赛；其余席位按世界积分和本季表现补齐。", 17, CareerVisuals.Teal));
            foreach (var row in EsportsWorld.Ranked(c).Take(6)) _content.AddChild(PersonLink(data, row.PersonId, $"{CareerEngine.DisplayName(data, row.PersonId)}   {row.Wins}胜 {row.Losses}负   ↗", 36));
        }
        foreach (var round in c.Fixtures.GroupBy(f => f.Round).OrderBy(g => g.Key))
        {
            _content.AddChild(Text(CircuitWorld.RoundName(c, round.Key), 23, _gold));
            var groups = c.TeamEvent ? round.GroupBy(f => f.HomeTeam + "|" + f.AwayTeam) : round.GroupBy(f => f.Id);
            foreach (var tie in groups)
            {
                var card = Card(); _content.AddChild(card); var box = Inner(card); var first = tie.First();
                string heading = c.TeamEvent ? $"{CircuitWorld.TeamName(data, c, first.HomeTeam)}  vs  {CircuitWorld.TeamName(data, c, first.AwayTeam)}" : "个人对决";
                if (c.TeamEvent && tie.All(f => f.Finished)) heading += $"    {tie.Count(f => f.WinnerId == f.HomeId)} : {tie.Count(f => f.WinnerId == f.AwayId)}";
                box.AddChild(Text($"第 {SeasonCalendar.Day(data, first.Day)} 天 · {heading}", 20, _gold));
                foreach (var f in tie)
                {
                    var line = new HBoxContainer(); box.AddChild(line);
                    line.AddChild(PersonLink(data, f.HomeId, (f.WinnerId == f.HomeId ? "◆ " : "") + CareerEngine.DisplayName(data, f.HomeId), 36));
                    line.AddChild(Text("  vs  ", 17, _muted));
                    line.AddChild(PersonLink(data, f.AwayId, (f.WinnerId == f.AwayId ? "◆ " : "") + CareerEngine.DisplayName(data, f.AwayId), 36));
                    if (f.Finished) box.AddChild(Text(f.Walkover ? "弃权判定" : MatchRules.Performance(f.HomeCleared, f.HomeFloor, f.HomeSeconds) + " / " + MatchRules.Performance(f.AwayCleared, f.AwayFloor, f.AwaySeconds), 15, _muted));
                }
            }
        }
    }
    private void ModernRules()
    {
        AddHeading("赛事指南", "从社区赛出发，一路赢到世界赛场。获得参赛资格后，日程里就会出现下一场比赛。");
        foreach (var (title, body) in new[] {
            ("晋级", "社区杯 → 城市赛 → 青训选拔 → 签约俱乐部。\n世界总决赛：职业联赛个人前二直接入围。\n洲际杯：各国联赛的前两家俱乐部参赛。\n世界杯：各国按本赛季表现选出三名选手。"),
            ("公开赛", "社区杯、城市赛和青训选拔每两周举办一次，失利后还可以再来。\n成为青训选手后，仍能参加社区杯和城市赛。青训及职业选手也可报名进阶 7 的巡回公开赛。"),
            ("比赛", "通关胜过未通关。\n都通关：用时更短的一方获胜。\n都未通关：到达更高楼层的一方获胜。\n成绩相同：换一个种子加赛。\n团队赛：三人各打一场，先赢两场的队伍获胜。"),
            ("积分", "俱乐部联赛：胜 3 分、平 1 分、负 0 分。\n世界积分：最近四赛季里，最高的六项赛事积分相加。每项成绩能得多少分、何时到期，都可以在世界积分榜查看。"),
            ("国运", "在国际赛事中取得好成绩，就能为国家赢得国运。名次越高，贡献越大；每贡献 1 点国运，你还会获得 $20 奖金。\n国运榜每四赛季重新排名，历年的建设成果会保留。"),
            ("日程", "每赛季 12 周。先打国内联赛，赛季末迎来世界大赛。\n第 1、3、5……赛季举办世界总决赛和洲际杯；第 2、4、6……赛季举办世界杯。具体比赛日期以日程为准。"),
            ("个人挑战", "觉得比赛进阶太轻松？可以选择更高进阶挑战。每提高一级，单场奖金增加 15%，获胜或平局时的关注奖励也增加 15%。\n赛事战报仍记为比赛规定的进阶，游戏历史记录会保留你实际挑战的进阶。") })
        { var card = Card(); _content.AddChild(card); var box = Inner(card); box.AddChild(Text(title, 24, _gold)); box.AddChild(Text(body, 18, _ink)); }
    }
}
