namespace NationalSpire;

public static class CareerLife
{
    public const int Version = 5;
    public static void Ensure(CareerData d)
    {
        RefreshPublicFacts(d);
        if (d.Esports.EcosystemVersion < 1 || d.Life.Version >= Version) return;
        if (d.Life.Version >= 3) { UpgradeOffers(d); d.Life.Version = Version; return; }
        if (d.Life.Version >= 2) { RepairActivities(d); UpgradeOffers(d); d.Life.Version = Version; return; }
        if (d.Life.Version < 1)
        {
            d.Life.NextOfferDay = d.Day + 2 + Hash(d, "first") % 4;
            d.Life.NextProjectDay = d.Day + 21;
            d.Life.NextWorldEventDay = d.Day + 2;
            foreach (var memory in d.CommunityMemories.Where(m => m.Kind == "fact")) memory.Text = CareerMoney.Historical(memory.Text);
            foreach (var snapshot in d.Esports.CommercialHistory) snapshot.Summary = CareerMoney.Historical(snapshot.Summary);
            foreach (var post in CommunityThreads.All(d).Where(p => p.AuthorId != "player"))
            { post.SourceTitle = CareerMoney.Historical(post.SourceTitle); post.SourceBody = CareerMoney.Historical(post.SourceBody); }
            // 旧版战报混合了商业收入；迁移时仅统计能够从比赛记录核实的奖金。
            d.Life.PrizeTotal = d.Results.Sum(r => (long)(d.Matches.FirstOrDefault(m => m.Id == r.MatchId) is { } m
                ? m.PlayerWon ? MatchRules.Reward(m.Prize, r.RewardMultiplier) : m.Draw ? MatchRules.Reward(m.Prize / 2, r.RewardMultiplier) : 0 : 0))
                + d.SeasonHistory.Sum(s => (long)s.Prize);
            foreach (var club in d.Esports.Clubs)
            {
                club.NextOperatingDay = d.Day + 7 + Hash(d, club.Id) % 7;
                int kind = CareerCommerce.IdentityIndex(d, club.Id);
                club.OperatingIncome = (kind switch { 0 => 10000, 1 => 7500, 2 => 12000, _ => 6500 }) + Hash(d, club.Id) % 151;
            }
            CareerCommerce.Capture(d);
        }
        int refund = LifeCatalog.Objects.Where(x => d.Life.Collection.ContainsKey(x.Key)).Sum(x => x.Cost);
        if (refund > 0) { d.Credits += refund; CareerMoney.Record(d, "旧版个人物品退款（收藏保留）", refund); }
        // 未开始的旧邀请合为一轮；已经确认的项目继续按原定日期完成。
        var available = d.Life.Activities.Where(a => a.Status == "可安排").ToList();
        foreach (var a in available) a.Round = 1;
        d.Life.OfferRound = Math.Max(1, d.Life.OfferRound);
        foreach (var a in d.Life.Activities.Where(a => a.Status != "可安排")) a.PaidCost = a.Cost;
        CareerRelics.Shop(d);
        RepairActivities(d);
        UpgradeOffers(d);
        d.Life.Version = Version;
    }
    private static void UpgradeOffers(CareerData d)
    {
        foreach (var a in d.Life.Activities.Where(a => a.Status is "可安排" or "进行中" && a.TermsVersion < 3))
        {
            if (a.Status == "可安排" && a.TermsVersion < 2 && a.Kind == "经营" && LifeCatalog.Resolve(a) is { } p)
            { a.Cost = p.Cost; a.Duration = p.Days; a.LongProject = p.Long; }
            // 仅加强尚未结算的效果，保留已付费用、已完成周数与既有成长。
            if (a.Status == "进行中" && a.TrainingStart > 0)
            { a.TemporaryPoints *= 2; a.DefensePoints *= 2; a.WeeklyGrowthPoints *= 2; }
            if (a.Kind == "商业") a.Detail = a.Detail.Replace("70%—130%", "84%—156%");
            a.TermsVersion = 3;
        }
    }
    private static void RepairActivities(CareerData d)
    {
        foreach (var a in d.Life.Activities)
        {
            var plan = LifeCatalog.Resolve(a);
            if (plan != null) a.Variant = plan.Key;
            if (CareerTraining.IsTraining(a))
            {
                if (CareerTraining.Multiplayer(d))
                {
                    if (a.Status is "进行中" or "已完成" && d.Life.RepairReceipts.Add("training-refund:" + a.Id))
                    { int refund = Math.Max(0, a.PaidCost >= 0 ? a.PaidCost : a.Cost); d.Credits += refund; CareerMoney.Record(d, a.Title + "无效备赛退款", refund); a.Result = "原备赛未能影响合作比赛，费用已退还。"; }
                    a.Status = "已结束";
                }
                else if (a.Status == "进行中") CareerTraining.Snapshot(d, a, true);
            }
            if (a.Status == "已完成" && a.Result == "活动已完成，原有安排记录已经保留。" && a.Kind is "商业" or "事业")
            {
                if (plan != null && d.Life.RepairReceipts.Add("activity-repair:" + a.Id))
                {
                    // 该固定结果来自未找到目录的提前返回分支，确认没有执行收益结算。
                    Complete(d, a);
                    d.Life.RepairNotices.Add(a.Title + "的漏发收益已补齐。");
                }
                else if (plan == null) d.Life.RepairNotices.Add(a.Title + "缺少原始活动定义，保留记录等待核实。");
            }
        }
    }
    private static int Hash(CareerData d, string key) => CareerEngine.StableHash(d.WorldId + ":life:" + key);
    public static void Advance(CareerData d)
    {
        Ensure(d);
        if (d.Esports.EcosystemVersion < 1) return;
        CareerRelics.Advance(d);
        ClubCoaching.Advance(d);
        foreach (var item in d.Life.Activities.Where(a => a.Status == "进行中").ToList())
        {
            if (ClubPrograms.IsTraining(item)) ClubPrograms.Advance(d, item);
            else CareerTraining.Advance(d, item);
            if (item.FinishDay <= d.Day) Complete(d, item);
            else if (!CareerTraining.IsTraining(item) && !ClubPrograms.IsTraining(item) && item.Duration >= 7 && item.ProgressDay == 0 && d.Day >= item.StartedDay + item.Duration / 2)
            {
                item.ProgressDay = d.Day;
                item.Result = item.Kind switch {
                    "青训" => "阶段安排已过半，对方已确认下一阶段的时间。",
                    "商业" => "制作方已确认样品，正在准备交付。",
                    "事业" => "筹备进入后半程，负责人员已确认完成时间。",
                    "内容" => "素材已经整理，正在完成剪辑与校对。",
                    _ => "场地与参与人员已经确认，准备工作按计划推进。" };
            }
        }
        foreach (var item in d.Life.Activities.Where(a => a.Status == "可安排" && a.ExpiresDay < d.Day)) item.Status = "已结束";
        if (d.Day >= d.Life.NextOfferDay) Offer(d);
        Trim(d);
    }
    public static void Offer(CareerData d)
    {
        var life = d.Life;
        var rng = new Random(Hash(d, "offers:" + d.Day));
        if (life.Activities.Any(a => a.Status == "可安排" && a.ExpiresDay >= d.Day) || life.LastDecisionDay > 0 && d.Day < life.NextOfferDay) return;
        life.NextOfferDay = d.Day + rng.Next(7, 13);
        int round = ++life.OfferRound;
        bool project = d.Day >= life.NextProjectDay && !life.Activities.Any(a => a.LongProject && a.Status == "进行中");
        var used = life.Activities.Where(a => a.OfferedDay > d.Day - 28).Select(a => a.Variant).ToHashSet();
        var kinds = new HashSet<string>();
        var candidates = LifeCatalog.Plans.Where(p => !used.Contains(p.Key) && (!p.Long || project)
            && (p.Kind is not ("俱乐部" or "备赛" or "培养") || d.Esports.ClubId.Length > 0)
            && (p.Kind is not ("备赛" or "培养") || !CareerTraining.Multiplayer(d) && CareerTraining.Targets(d).Any(x => CareerTraining.ActiveRoster(d, x.Id)))
            && (p.Kind != "经营" || OwnedClubs.CanOperate(d) && ClubPrograms.CanOffer(d, p.Title))
            && (p.Kind != "内容" || d.Results.Count > 0)).OrderBy(p => d.Credits < 300 && p.Cost <= d.Credits ? 0 : 1).ThenBy(_ => rng.Next()).ToList();
        int count = CareerRelics.Has(d, "TOOLBOX") ? 4 : 3;
        bool dream = CareerRelics.Has(d, "DREAM_CATCHER") && life.Figurines["DREAM_CATCHER"].Charge > 0 && d.Results.Count > 0;
        if (dream) count++;
        if (CareerRelics.Has(d, "JUZU_BRACELET")) candidates = candidates.OrderBy(p => p.Kind is "生活" or "社交" ? 0 : 1).ToList();
        if (dream) candidates = candidates.OrderBy(p => p.Kind == "内容" ? 0 : 1).ToList();
        if (d.Esports.ClubId.Length > 0 && round % 2 == 0 && !life.Activities.Any(a => a.Kind == "备赛" && a.Status == "进行中"))
            candidates = candidates.OrderBy(p => p.Kind == "备赛" ? 0 : 1).ToList();
        if (OwnedClubs.CanOperate(d)) candidates = candidates.OrderBy(p => p.Kind == "经营" ? 0 : 1).ToList();
        foreach (var plan in candidates)
        {
            if (count <= 0) break;
            if (!kinds.Add(plan.Kind) || plan.Long && !project) continue;
            var people = d.People.Where(p => plan.Kind is "备赛" or "培养"
                ? p.ClubId == d.Esports.ClubId && EsportsWorld.IsProfessional(p)
                : p.Country == d.Esports.Country && (plan.Kind == "青训" ? p.Role == "青训选手" : p.Role is "职业选手" or "普通玩家" or "主播" or "解说员" or "退役选手"))
                .OrderByDescending(p => life.Relationships.ContainsKey(p.Id) || d.Esports.Duels.Any(x => x.PersonId == p.Id))
                .ThenBy(p => Hash(d, plan.Key + p.Id + d.Day)).Take(30).ToList();
            if (people.Count == 0) continue;
            var person = people[rng.Next(Math.Min(people.Count, 12))];
            if (plan.Kind is "备赛" or "培养") person = CareerTraining.Targets(d).First();
            var club = EsportsWorld.Club(d, d.Esports.ClubId) ?? EsportsWorld.Club(d, person.ClubId)
                ?? d.Esports.Clubs.First(c => c.Country == d.Esports.Country);
            string setting = d.Esports.Country + new[] { "的社区活动中心", "的城市文化街区", "的赛事会场周边", "的地方会馆", "的俱乐部所在街区" }[rng.Next(5)];
            int scale = plan.Kind is "生活" or "社交" or "备赛" or "培养" or "经营" ? 1 : rng.Next(1, 4);
            string Text(string s) => s.Replace("{人}", person.PublicName).Replace("{队}", club.Name).Replace("{地}", setting);
            var item = new LifeActivity { Round = round, Id = "life-" + d.Day + "-" + plan.Key, Kind = plan.Kind, Variant = plan.Key,
                Title = plan.Title, Detail = Text(plan.Purpose), PersonId = person.Id, ClubId = club.Id, Setting = setting,
                Cost = plan.Cost * scale, OfferedDay = d.Day, ExpiresDay = life.NextOfferDay - 1,
                Duration = plan.Days, Public = plan.Public, LongProject = plan.Long, TermsVersion = 3 };
            if (plan.Kind is "青训" or "社交") item.Detail += "。" + (life.Relationships.ContainsKey(person.Id) ? "你们此前已经有过来往" : d.Esports.Duels.Any(x => x.PersonId == person.Id) ? "你们曾在赛场交手" : "这次可以认识一位圈内的新朋友");
            if (scale > 1) item.Detail += "。" + (plan.Kind switch {
                "青训" => scale == 2 ? "采用更完整的配套服务，覆盖本阶段的准备工作" : "承担本阶段的完整配套费用，方便对方专心参加",
                "内容" => scale == 2 ? "增加现场记录与后期整理的预算" : "安排专人完成拍摄、剪辑与资料整理",
                "社区" => scale == 2 ? "扩大开放名额，补充现场物料" : "扩大活动覆盖范围，配齐场地、物料和后勤人员",
                "俱乐部" => scale == 2 ? "覆盖职业队与青训组的相关需求" : "按全队规模安排，配齐相关设备与后勤支持",
                "商业" => scale == 2 ? "采用中等规模的制作与场地预算" : "按较大规模筹备，增加制作与推广预算",
                _ => scale == 2 ? "扩大项目规模，补充配套设施" : "按完整规模筹备，配齐场地、设施与负责人员" });
            if (plan.Kind == "商业") item.Detail += $"。项目结束后结算一次，预计收回投入的84%—156%，金额随关注度和销售情况变化";
            life.Activities.Add(item); count--;
            if (dream && plan.Kind == "内容") { life.Figurines["DREAM_CATCHER"].Charge = 0; dream = false; }
            if (plan.Long) { project = false; life.NextProjectDay = d.Day + rng.Next(21, 36); }
        }
    }
    public static string? Accept(CareerData d, string id, string targetId = "")
    {
        var item = d.Life.Activities.FirstOrDefault(a => a.Id == id);
        if (item == null || item.Status != "可安排" || item.ExpiresDay < d.Day) return "这项活动已经结束。";
        if (item.Kind == "经营" && !OwnedClubs.CanOperate(d)) return "这项经营安排由俱乐部房主管理。";
        if (item.Kind == "俱乐部" && item.ClubId != d.Esports.ClubId) return "这项安排属于此前的俱乐部。";
        if (CareerTraining.IsTraining(item))
        {
            if (CareerTraining.Multiplayer(d)) return "合作比赛由真人共同完成，这项NPC训练不适用。";
            if (item.ClubId != d.Esports.ClubId) return "这项训练属于此前的俱乐部。";
            var targets = CareerTraining.Targets(d);
            if (targetId.Length > 0 && !targets.Any(p => p.Id == targetId)) return "培养对象已不属于本队职业阵容。";
            if (targetId.Length > 0) item.PersonId = targetId;
            if (!targets.Any(p => p.Id == item.PersonId)) return "培养对象已不在本队。";
            if (!CareerTraining.GrowthAvailable(d, item)) return "当前没有可培养的队友。";
            if (CareerTraining.Kind(item.Title) is "team" or "team-growth" && !targets.Any(p => CareerTraining.ActiveRoster(d, p.Id))) return "本队尚无已确认的参赛阵容。";
        }
        if (ClubPrograms.IsTraining(item) && ClubPrograms.Error(d, item) is { } programError) return programError;
        int cost = CareerRelics.Cost(d, item);
        if (d.Credits < cost) return "当前资金不足，可以稍后再安排。";
        if (item.LongProject && d.Life.Activities.Any(a => a.LongProject && a.Status == "进行中")) return "当前长期项目完成后，可以开始下一项。";
        int duration = CareerRelics.Duration(d, item);
        if (cost > 0) CareerRelics.Spend(d);
        CareerRelics.Accept(d, item);
        d.Credits -= cost; item.PaidCost = cost; CareerMoney.Record(d, item.Title, -cost);
        item.Status = "进行中"; item.StartedDay = d.Day; item.FinishDay = d.Day + duration;
        if (ClubPrograms.IsTraining(item)) ClubPrograms.Snapshot(d, item);
        else if (CareerTraining.IsTraining(item)) CareerTraining.Snapshot(d, item);
        else if (item.Kind == "俱乐部" && item.TermsVersion >= 1)
            item.TrainingTargets = CareerTraining.Targets(d).Where(p => CareerTraining.ActiveRoster(d, p.Id)).Select(p => p.Id).ToList();
        foreach (var other in d.Life.Activities.Where(a => a.Status == "可安排" && a.Round == item.Round)) other.Status = "已结束";
        d.Life.LastDecisionDay = d.Day; d.Life.NextOfferDay = d.Day + 7 + Hash(d, "decision:" + item.Id) % 6;
        item.Result = (CareerTraining.IsTraining(item) || ClubPrograms.IsTraining(item))
            ? item.WeeklyGrowthPoints > 0 ? $"第 {item.TrainingStart} 天开始培养，每周记录长期成长，第 {item.FinishDay} 天完成。"
                : $"第 {item.TrainingStart} 天开始备赛，效果持续至第 {item.TrainingEnd} 天（含当天）。第 {item.FinishDay} 天完成结算。"
            : $"安排已确认，预计第 {item.FinishDay} 天完成。";
        if (cost < item.Cost) item.Result += $"本次优惠 {CareerMoney.Format(item.Cost - cost)}。";
        if (duration < item.Duration) item.Result += $"筹备缩短 {item.Duration - duration} 天。";
        if (item.Kind is "青训" or "社交") item.Result += " " + Thanks(d, item);
        if (item.Public) AddEvent(d, item.Id + ":start", item.Kind, item.Title + "已安排",
            $"{CareerEngine.Name(d)}安排了{item.Title}，投入{CareerMoney.Format(cost)}。{item.Detail}。计划第{item.FinishDay}天完成。", ["player", item.PersonId], item.LongProject);
        CareerStore.Save(d); return null;
    }
    private static string Thanks(CareerData d, LifeActivity item)
    {
        var p = CareerEngine.Person(d, item.PersonId);
        if (p == null) return "";
        string[] first = item.Kind == "青训"
            ? ["这次的安排收到了，感谢！结束以后给你说说情况。", "收到！后面的安排终于能定下来了。", "谢谢，这份支持我记下了。我会认真准备。", "刚看到消息，真的帮上忙了！"]
            : ["时间记下了，到时候见！", "正好有空，就这么定了！", "收到，终于能一起坐下来聊聊了。", "好啊！到时候我提前联系你。"];
        string[] familiar = ["又麻烦你了！这次结束后一起吃顿饭吧。", "收到！上次的事还没来得及谢你，这次也记下了。", "谢谢老朋友！具体安排我们到时候再联系。", "看到了！下回见面好好聊聊。"];
        var pool = d.Life.Relationships.GetValueOrDefault(p.Id) > 0 ? familiar : first;
        return p.PublicName + "：" + pool[Hash(d, item.Id + ":thanks") % pool.Length];
    }
    private static void Complete(CareerData d, LifeActivity a)
    {
        var plan = LifeCatalog.Resolve(a);
        if (plan == null) { a.Status = "已完成"; a.Result = "活动已完成，原有安排记录已经保留。"; return; }
        string name = CareerEngine.DisplayName(d, a.PersonId), club = EsportsWorld.ClubName(d, a.ClubId);
        a.Status = "已完成";
        a.Result = plan.Outcome.Replace("{人}", name).Replace("{队}", club).Replace("{地}", a.Setting) + "。";
        if (a.Kind == "经营") a.Result += OwnedClubs.CompleteActivity(d, a);
        if (a.Kind is "青训" or "社交") PrivateMessages.ChangeFavour(d, a.PersonId, a.TermsVersion >= 1 && a.Kind == "社交" ? 6 : 3);
        if (a.Kind == "青训" && CareerEngine.Person(d, a.PersonId) is { } youth)
        {
            int gain = Grow(d, youth, ActivityBenefit(a, CareerCommerce.TrainingInvestment(a.Cost, 300)) + CareerRelics.Training(d, a), a.Id);
            a.Result += gain > 0 ? $"{name}在阶段训练中有所进步，评分增加{gain}。" : $"{name}完成了阶段安排，比赛成绩将由后续赛事记录。";
        }
        if (a.Kind == "俱乐部" && EsportsWorld.Club(d, a.ClubId) is { } team)
        {
            // 项目交付时确认专项收支，已经完成的采购不会再次计入后续训练预算。
            team.Budget += a.Cost;
            ClubOperations.Entry(team, d.Day, CareerEngine.Name(d) + "的专项支持", a.Cost);
            team.Budget -= a.Cost;
            ClubOperations.Entry(team, d.Day, a.Title + "交付支出", -a.Cost);
            a.Result += "本次专项收支已记入俱乐部账目。";
            foreach (var member in d.People.Where(p => p.ClubId == team.Id && p.Role == "青训选手").Take(2))
            {
                int gain = Grow(d, member, ActivityBenefit(a, CareerCommerce.TrainingInvestment(a.Cost / 2, 150)), a.Id + member.Id);
                if (gain > 0) a.Result += $"{member.PublicName}从本次安排中有所收获，评分增加{gain}。";
            }
        }
        if (CareerTraining.IsTraining(a)) a.Result = a.WeeklyGrowthPoints > 0 ? "培养完成。" + CareerTraining.Gains(d, a) : "四周备赛已结束。";
        if (a.TermsVersion >= 1 && a.Kind == "俱乐部")
        {
            foreach (string id in a.TrainingTargets)
                a.Result += $"{CareerEngine.DisplayName(d, id)}永久通关率 +{CareerTraining.Grow(d, id, a.TermsVersion >= 3 ? 30 : a.TermsVersion >= 2 ? 15 : 25, d.Season) / 100.0:0.##}%。";
        }
        if (a.TermsVersion >= 1 && a.Title is "重看经典比赛" or "录制选手对谈" && CareerEngine.Person(d, a.PersonId) is { } companion && EsportsWorld.IsProfessional(companion))
            a.Result += $"{companion.PublicName}永久通关率 +{CareerTraining.Grow(d, companion.Id, a.TermsVersion >= 3 ? 20 : 10, d.Season) / 100.0:0.##}%。";
        if (a.Kind == "商业")
        {
            int percent = Math.Clamp(70 + Hash(d, a.Id + ":sales") % 41 + Math.Min(20, d.Fans / 5000), 70, 130);
            int revenue = CareerRelics.Business(d, a, ActivityBenefit(a, a.Cost * percent / 100)); d.Credits += revenue;
            CareerMoney.Record(d, a.Title + "结算", revenue); a.Result += $"本次到账{CareerMoney.Format(revenue)}，项目已结清。";
        }
        if (a.Kind == "生活") { d.Life.Preparation = 1; a.Result += "休息后整理了想法，下次内容制作费用减少 12%，最多节省 $240，不叠加次数。"; }
        if (a.Kind == "事业") { d.Life.Facilities = Math.Min(3, d.Life.Facilities + 1); a.Result += $"长期配套已投入使用：内容和社区活动费用减少 {d.Life.Facilities * 2.4:0.#}%，每次最多节省 $240。"; }
        if (a.Kind is "青训" or "社交") a.Result += $"{name}对你的好感为 {PrivateMessages.Favour(d, a.PersonId)}。";
        if (a.Kind is "内容" or "社区" or "商业")
        {
            int fans = 15 + Hash(d, a.Id) % 61 + Math.Min(75, a.Cost / 10);
            if (a.TermsVersion >= 1 && a.Kind is "内容" or "社区") fans = fans * 6 / 5;
            fans = ActivityBenefit(a, fans);
            d.Fans += fans; a.Result += $"新增{fans}位关注者。";
        }
        if (a.Kind is "生活" or "事业" || a.Variant.Contains(':') && a.Kind == "社交")
            d.Life.Collection[a.Variant] = a.Title + " · 第" + d.Season + "赛季";
        CareerRelics.Complete(d, a);
        if (a.Public) AddEvent(d, a.Id + ":finish", a.Kind, a.Title + "完成", CareerEngine.Name(d) + "安排的" + a.Title + "完成。" + a.Result, ["player", a.PersonId], a.LongProject);
    }
    public static int ActivityBenefit(LifeActivity a, int value) => a.TermsVersion >= 3 ? value * 6 / 5 : value;
    public static int Grow(CareerData d, CareerPerson person, int investment, string seed)
    {
        if (d.Life.GrowthSeason != d.Season) { d.Life.GrowthThisSeason.Clear(); d.Life.GrowthSeason = d.Season; }
        if (investment <= 0) return 0;
        int scale = person.MaxAscension >= 9 ? 1 : person.MaxAscension >= 8 ? 2 : person.MaxAscension >= 7 ? 5 : 12;
        double pace = 1 / (1 + d.Life.GrowthThisSeason.GetValueOrDefault(person.Id) / (double)scale);
        int gain = CareerCommerce.Develop(person, investment, seed, pace);
        d.Life.GrowthThisSeason[person.Id] = d.Life.GrowthThisSeason.GetValueOrDefault(person.Id) + gain;
        return gain;
    }
    public static double TeamMatchBonus(CareerData d, WorldCompetition competition, string personId, int matchDay, int ascension = 8)
    {
        var person = CareerEngine.Person(d, personId);
        if (person == null) return 0;
        var factors = MatchRules.Evaluate(d, person, ascension, matchDay);
        return factors.Growth + factors.Training + factors.Practice;
    }
    public static void SkipRound(CareerData d)
    {
        if (!d.Life.Activities.Any(a => a.Status == "可安排")) return;
        foreach (var a in d.Life.Activities.Where(a => a.Status == "可安排")) a.Status = "已结束";
        d.Life.LastDecisionDay = d.Day;
        d.Life.NextOfferDay = d.Day + 7 + Hash(d, "skip:" + d.Life.OfferRound) % 6;
        CareerStore.Save(d);
    }
    public static string Expected(CareerData d, LifeActivity a)
    {
        if (ClubPrograms.IsTraining(a)) return ClubPrograms.Description(d, a);
        if (CareerTraining.IsTraining(a)) return CareerTraining.Description(d, a);
        int extra = Math.Min(75, a.Cost / 10);
        int fanLow = 15 + extra, fanHigh = 75 + extra;
        if (a.TermsVersion >= 1 && a.Kind is "内容" or "社区") { fanLow = fanLow * 6 / 5; fanHigh = fanHigh * 6 / 5; }
        fanLow = ActivityBenefit(a, fanLow); fanHigh = ActivityBenefit(a, fanHigh);
        return a.Kind switch
        {
            "生活" => "下次内容制作费用 -12%（最多省 $240）",
            "社交" => $"与{CareerEngine.DisplayName(d, a.PersonId)}的关系 +{(a.TermsVersion >= 1 ? 2 : 1)}" + (a.TermsVersion >= 1 && a.Title == "重看经典比赛" ? $"；职业选手永久通关率最多 +{(a.TermsVersion >= 3 ? 0.2 : 0.1)}%" : ""),
            "青训" => $"与{CareerEngine.DisplayName(d, a.PersonId)}的关系 +1；评分随选手能力提升",
            "俱乐部" => "两名青训获得评分成长" + (a.TermsVersion >= 1 ? $"；参赛队友永久通关率最多 +{(a.TermsVersion >= 3 ? 0.3 : a.TermsVersion >= 2 ? 0.15 : 0.25)}%" : ""),
            "内容" or "社区" => $"预计关注 +{fanLow}～{fanHigh}" + (a.TermsVersion >= 1 && a.Title == "录制选手对谈" ? $"；参与对谈的职业选手永久通关率最多 +{(a.TermsVersion >= 3 ? 0.2 : 0.1)}%" : ""),
            "商业" => $"回款 {CareerMoney.Format(ActivityBenefit(a, a.Cost * 70 / 100))}～{CareerMoney.Format(ActivityBenefit(a, a.Cost * 130 / 100))}（含本金）；预计关注 +{fanLow}～{fanHigh}",
            "经营" => a.LongProject ? $"签约选手永久通关率最多 +{(a.TermsVersion >= 3 ? 1 : 0.5)}%" : $"俱乐部关注 +{ActivityBenefit(a, 300)}～{ActivityBenefit(a, 600)}，随已有关注规模递减",
            "事业" => "永久降低内容、社区活动费用 2.4%（累计最多 7.2%）",
            _ => "留下一份活动记录"
        };
    }

    public static void AddEvent(CareerData d, string id, string topic, string title, string detail, List<string> people, bool important = false)
    {
        if (d.Life.Events.Any(e => e.Id == id)) return;
        detail = PublicActivityText(detail);
        d.Life.Events.Add(new() { Id = id, Day = d.Day, Topic = topic, Title = title, Detail = detail, People = people.Distinct().ToList(), Important = important });
        // 公开事实即时可查；调用只在日期推进或既有赛后流程触发。
        CircuitLedger.Remember(d, "life-fact:" + id, title + "：" + detail, people);
    }
    // 仅转换程序生成的活动结算措辞；实际评分、账目和玩家可见收益继续保留。
    internal static string PublicActivityText(string text)
    {
        text = System.Text.RegularExpressions.Regex.Replace(text, @"，评分增加\d+", "");
        text = System.Text.RegularExpressions.Regex.Replace(text, @"休息后整理了想法，下次内容制作费用减少 (?:10|12)%，最多节省 \$(?:200|240)，不叠加次数。", "休息后重新整理了创作想法。");
        text = System.Text.RegularExpressions.Regex.Replace(text, @"长期配套已投入使用：内容和社区活动费用减少 [\d.]+%，每次最多节省 \$(?:200|240)。", "长期配套已投入使用。");
        text = System.Text.RegularExpressions.Regex.Replace(text, @"永久通关率 \+[\d.]+%。", "在专项训练中取得进步。");
        text = System.Text.RegularExpressions.Regex.Replace(text, @"长期发挥能力增加 [\d.]+ 个百分点。", "在专项训练中取得进步。");
        text = System.Text.RegularExpressions.Regex.Replace(text, @"从交流中获得长期进步，增加 [\d.]+ 个百分点。", "从交流中获得长期进步。");
        return System.Text.RegularExpressions.Regex.Replace(text, @"与[^。\r\n]+的来往程度为 \d+/20。", "");
    }
    private static void RefreshPublicFacts(CareerData d)
    {
        foreach (var e in d.Life.Events)
            e.Detail = PublicActivityText(e.Detail);
        var posts = CommunityThreads.All(d).Where(p => p.AuthorId != "player" && p.EventKey.StartsWith("life-update-")).ToList();
        foreach (var post in posts)
        {
            post.SourceBody = PublicActivityText(post.SourceBody);
            if (post.NewsGeneration.State != "completed") post.Body = PublicActivityText(post.Body);
        }
        foreach (var slide in d.WeeklyEditions.SelectMany(w => w.Slides).Where(s => s.EventIds.Count > 0))
            slide.Facts = PublicActivityText(slide.Facts);
        var postIds = posts.Select(p => p.Id).ToHashSet();
        foreach (var memory in d.CommunityMemories.Where(m => m.Kind == "fact" && (m.Id.StartsWith("life-fact:")
            || postIds.Contains(m.PostId))))
            memory.Text = PublicActivityText(memory.Text);
    }
    public static void PublishPending(CareerData d)
    {
        var events = d.Life.Events.Where(e => e.PostId.Length == 0 && e.Day < d.Day && e.Day >= d.Day - 7 && e.People.Any(id => id == "player" || d.HumanIds.Contains(id))
            && (d.CooperativeMembers <= 1 || !e.Id.StartsWith("human-")))
            .OrderByDescending(e => e.Important).ThenByDescending(e => e.Day).Take(4).ToList();
        if (events.Count == 0 || !d.Ai.Enabled) return;
        var first = events[0]; string key = (d.CooperativeMembers > 1 ? "club-update-" : "life-update-") + d.Day;
        CareerEngine.Publish(d, key, events.Count == 1 ? first.Title : CareerEngine.Name(d) + "的近期安排与进展",
            string.Join("\n", events.OrderBy(e => e.Day).Select(e => $"第{e.Day}天，{e.Title}：{e.Detail}")), "人物日常", true,
            events.SelectMany(e => e.People).Distinct().ToList());
        var post = d.Posts.FirstOrDefault(p => p.EventKey == key);
        if (post != null) foreach (var e in events) e.PostId = post.Id;
    }
    private static void Trim(CareerData d)
    {
        var keep = d.Life.Activities.Where(a => a.Status is "可安排" or "进行中").Concat(d.Life.Activities.Where(a => a.Status == "已完成").TakeLast(48)).ToList();
        d.Life.Activities = keep;
        d.Life.Events.RemoveAll(e => e.Day < d.Day - 168 && (!e.Important || e.EditionWeek > 0));
        var oldFacts = d.CommunityMemories.Where(m => m.Id.StartsWith("life-fact:")).OrderByDescending(m => m.Day).Skip(384).Select(m => m.Id).ToHashSet();
        d.CommunityMemories.RemoveAll(m => oldFacts.Contains(m.Id));
        if (d.Life.Events.Count > 256) d.Life.Events.RemoveRange(0, d.Life.Events.Count - 256);
    }
}
