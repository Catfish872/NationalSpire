using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private const string PersonalPlans = "个人生活安排", TrainingPlans = "俱乐部训练安排", SponsorPlans = "俱乐部赞助";
    private sealed record CalendarPlan(string Key, string Section, string Title, string Target, string Effect, string Dates, Func<int, bool> Covers,
        Action? Confirm = null, bool Enabled = true, List<CareerPerson>? Targets = null, string ActionText = "安排", int Cost = 0, string Availability = "", Func<string>? TrainingDetails = null);

    private static bool ClubPlan(LifeActivity activity) =>
        CareerTraining.IsTraining(activity) || ClubPrograms.IsTraining(activity) || activity.Kind is "俱乐部" or "经营";
    private List<CalendarPlan> CalendarPlans(CareerData d)
    {
        bool member = d.Esports.ClubId.Length > 0;
        var plans = member ? TeamPreparationPlans(d).ToList() : new List<CalendarPlan>();
        foreach (var a in d.Life.Activities.Where(a => a.Status == "可安排" && a.ExpiresDay >= d.Day))
        {
            bool training = CareerTraining.IsTraining(a), program = ClubPrograms.IsTraining(a);
            bool club = ClubPlan(a);
            if (club && !member) continue;
            var targets = training && CareerTraining.Kind(a.Title) is not ("team" or "team-growth") ? CareerTraining.Targets(d) : null;
            string target = a.Id == _planKey && targets?.Any(p => p.Id == _planTarget) == true ? _planTarget :
                targets?.FirstOrDefault(p => p.Id == a.PersonId)?.Id ?? targets?.FirstOrDefault()?.Id ?? a.PersonId;
            var quote = a.PreviewFor(d,target);
            int start = d.Day, end = start + Math.Max(1, CareerRelics.Duration(d, a)) - 1;
            if (training || program)
            {
                quote.StartedDay = d.Day;
                if (training) CareerTraining.Snapshot(d, quote); else ClubPrograms.Snapshot(d, quote);
                start = quote.TrainingStart; end = quote.TrainingEnd;
            }
            string names = quote.TrainingTargets.Count > 0 ? string.Join("、", quote.TrainingTargets.Select(id => CareerEngine.DisplayName(d,id)))
                : a.Kind is "俱乐部" or "经营" ? EsportsWorld.ClubName(d,a.ClubId) : CareerEngine.DisplayName(d, target);
            int cost = CareerRelics.Cost(d, a);
            string effect = quote.Detail+"\n"+CareerLife.Expected(d,quote);
            plans.Add(new(a.Id, club ? TrainingPlans : PersonalPlans, a.Title, names, effect, AgendaRange(d,start,end), day => day >= start && day <= end, () =>
            {
                if (MultiplayerCommand("activity", a.Id, target, accepted: ClearPlan)) return;
                FinishPlan(CareerLife.Accept(d, a.Id, target));
            }, d.Credits >= cost && !(a.LongProject && d.Life.Activities.Any(x => x.LongProject && x.Status == "进行中")), targets, Cost:cost,
                TrainingDetails: program ? () => ClubPrograms.Details(d, quote) : training ? () => CareerTraining.Details(d, quote) : null));
        }
        if (!member) return plans;
        foreach (var p in ClubCoaching.TrainingPlans(d).Where(p => p.ClubId == d.Esports.ClubId && p.State == "进行中"))
        {
            string name = CareerEngine.DisplayName(d,p.PersonId);
            plans.Add(new("coach:" + p.Id, TrainingPlans, "教练训练 · " + name,
                name, p.Content, AgendaRange(d,p.StartDay,p.EndDay),
                day => day >= p.StartDay && day <= p.EndDay, () => OpenPrivateMessages(p.CoachId.Length == 0 ? p.PersonId : p.CoachId), ActionText:"查看私信"));
        }
        if (OwnedClubs.IsOwner(d) && d.Esports.OwnedClub is { } o)
        {
            int fans = ClubAudience.Total(d,o.ClubId);
            foreach (var id in new[] { "steady", "results", "fans" })
            {
                var quote = OwnedClubs.SponsorQuote(d,id);
                int start = d.Day;
                if (o.Sponsor is { } old && old.EndDay > d.Day)
                {
                    int payday = o.NextPayDay > 0 ? o.NextPayDay : d.Day;
                    start = payday + Math.Max(0, (old.EndDay - payday + 6) / 7) * 7;
                }
                int end = start + (quote.EndDay - d.Day) - 1;
                string effect = RegionalOrganizations.SponsorDescription(quote.Brand) +
                    $"\n周结 {CareerMoney.Format(OwnedClubs.SponsorWeekly(quote,fans))} · 胜场 {CareerMoney.Format(OwnedClubs.SponsorWinBonus(quote,fans))}";
                plans.Add(new("club-sponsor:" + id, SponsorPlans, quote.Brand + (o.NextSponsor == id ? " · 下期已选" : o.Sponsor?.Id == id ? " · 当前合作" : ""),
                    EsportsWorld.ClubName(d,o.ClubId), effect, AgendaRange(d,start,end), day => day >= start && day <= end, () => ClubAction(d, "sponsor", target:id, success:ClearPlan),
                    CanManageClub && o.NextSponsor != id));
            }
        }
        else if (d.Esports.ClubId.Length > 0)
        {
            foreach (var s in d.Esports.Sponsors.Where(s => s.TargetId == d.Esports.ClubId && s.EndedDay == 0 && s.StartSeason <= d.Season && s.EndSeason >= d.Season))
                plans.Add(new("active-sponsor:" + s.Id, SponsorPlans, s.Brand, EsportsWorld.ClubName(d,s.TargetId), $"{s.Slogan}\n每赛季支持战队 {CareerMoney.Format(SponsorIncome.Retainer(d,s))}", $"第 {s.StartSeason} 至 {s.EndSeason} 赛季",
                    day => GameCalendar.Season(d,day) >= s.StartSeason && GameCalendar.Season(d,day) <= s.EndSeason));
        }
        return plans;
    }
    private IEnumerable<CalendarPlan> TeamPreparationPlans(CareerData d)
    {
        const string effect = "未来三个比赛轮次，NPC 队友的通关率提高 16 个百分点，与临时训练取较高值。";
        var competitions = TeamPreparations.Available(d).ToList();
        if (competitions.Count == 0)
            yield return new("team:upcoming", TrainingPlans, "集体备赛", "参赛队友", effect, "待赛程公布", _ => false,
                Cost: TeamPreparations.Cost, Availability: "加入参赛阵容并排定团体对阵后可安排。");
        foreach (var cup in competitions)
        {
            string team = TeamPreparations.PlayerTeam(cup);
            var active = d.TeamPreparations.FirstOrDefault(p => p.CompetitionId == cup.Id && p.Team == team && p.Remaining > 0);
            var days = cup.Fixtures.Where(f => !f.Finished && (f.HomeTeam == team || f.AwayTeam == team))
                .GroupBy(f => f.Round).OrderBy(g => g.Key).Take(active?.Remaining ?? 3).SelectMany(g => g.Select(f => f.Day)).ToHashSet();
            string dates = string.Join("、", days.Order().Select(day => GameCalendar.Date(d,day).ToString("M/d")));
            string state = active != null ? "备赛已生效" : _multiplayer is {Host:false} ? "由房主安排" :
                d.PendingMatchId != null ? "当前比赛结束后可安排" : CareerMoney.Balance(d) < TeamPreparations.Cost ? "可用资金不足" : "";
            yield return new("team:" + cup.Id, TrainingPlans, "集体备赛 · " + cup.Name, CircuitWorld.TeamName(d,cup,team),
                effect, dates.Length > 0 ? dates : "待赛程公布", days.Contains, () => ConfirmTeamPreparation(d,cup.Id),
                state.Length == 0, Cost: TeamPreparations.Cost, Availability: state);
        }
    }
    private int CurrentPlanScroll() => _tab=="日程" && _calendarMode=="计划" &&
        CareerVisuals.FindContent(_content,"CalendarSideScroll") is ScrollContainer pane ? pane.ScrollVertical : _planScroll;

    private void FinishPlan(string? error)
    {
        if (error == null) ClearPlan();
        Render(); if (error != null) Notice(error, true);
    }
    private sealed record PlanCard(PanelContainer Panel,VBoxContainer Body,Button Toggle,TextureRect Arrow)
    {
        public void ShowExpanded(bool expanded)
        {
            Toggle.SetMeta("expanded",expanded);
            Arrow.Texture=NavigationIcon(expanded?"chevron-up":"chevron-down");
            ((StyleBoxFlat)Panel.GetThemeStylebox("panel")).BorderColor=new Color(expanded?"80e7db":"36515d");
        }
    }

    private void PlanPane(CareerData d,VBoxContainer box,ScrollContainer scroll,List<CalendarPlan> plans,CalendarDayButton[] dates)
    {
        var cards=new Dictionary<string,PlanCard>();
        MarginContainer? expanded=null;

        void Choose(string key,string target="")
        {
            int y=scroll.ScrollVertical;
            if(cards.TryGetValue(_planKey,out var previous) && expanded!=null)
            {
                // Closing a preceding card moves the chosen heading up by the height of the old detail.
                if(cards.TryGetValue(key,out var next) && previous.Panel.GetIndex()<next.Panel.GetIndex())
                    y-=Mathf.RoundToInt(expanded.Size.Y);
                previous.ShowExpanded(false);
                previous.Body.RemoveChild(expanded); expanded.QueueFree(); expanded=null;
            }
            _planKey=key; _planTarget=target;
            var selected=key.Length>0 ? CalendarPlans(d).Find(p=>p.Key==key) : null;
            if(selected!=null && cards.TryGetValue(key,out var current))
            {
                current.ShowExpanded(true);
                expanded=PlanDetails(d,selected,id=>Choose(key,id)); current.Body.AddChild(expanded);
            }
            foreach(var date in dates) date.SetPlanPreview(selected?.Covers(date.Day)==true);
            _planScroll=Math.Max(0,y);
            scroll.ScrollVertical=_planScroll;
        }
        foreach (string group in new[] { PersonalPlans, TrainingPlans, SponsorPlans })
        {
            if (group != PersonalPlans && d.Esports.ClubId.Length == 0) continue;
            var heading=DashboardLabel(group,23,_ink);
            heading.CustomMinimumSize=new(0,40); box.AddChild(heading);
            var rows = plans.Where(p => p.Section == group).ToList();
            if (rows.Count == 0) box.AddChild(Text("暂无可用安排", 15, _muted));
            foreach (var p in rows)
            {
                bool open = p.Key == _planKey;
                var card=new PanelContainer { Name="Plan_"+p.Key };
                card.AddThemeStyleboxOverride("panel",CareerVisuals.Box("172c38",open?"80e7db":"36515d",5,1)); box.AddChild(card);
                var body=Inner(card); body.AddThemeConstantOverride("separation",0);
                var row=new HBoxContainer(); row.AddThemeConstantOverride("separation",11);
                row.AddChild(Glyph(group==SponsorPlans?"handshake":group==TrainingPlans?"dumbbell":"heart",24,CareerVisuals.Teal));
                row.AddChild(DashboardLabel(p.Title,18,_ink,true));
                var arrow=Glyph(open?"chevron-up":"chevron-down",18,_gold); arrow.Name="DisclosureArrow"; row.AddChild(arrow);
                var toggle=ActionRow(body,"PlanHeading",p.Title,()=>Choose(_planKey==p.Key?"":p.Key),row,76,13,10,"172c38","00000000","203d49");
                toggle.SetMeta("expanded",open);
                cards[p.Key]=new PlanCard(card,body,toggle,arrow);
                if(open)
                {
                    expanded=PlanDetails(d,p,id=>Choose(p.Key,id)); body.AddChild(expanded);
                }
            }
        }
        if (PendingPlans(d)) box.AddChild(FramedAction("跳过此轮", () => ConfirmLife("跳过此轮", "结束当前生活和训练邀请？", () =>
        {
            if (MultiplayerCommand("skip", accepted:ClearPlan)) return; CareerLife.SkipRound(d); FinishPlan(null);
        }),height:43,quiet:true));
        var history = d.Life.Activities.Where(a => a.Status is "进行中" or "已完成" && (d.Esports.ClubId.Length > 0 || !ClubPlan(a))).OrderByDescending(a => a.StartedDay).ToList();
        if (history.Count > 0)
        {
            box.AddChild(Text("进行中与过往安排", 18, _gold));
            foreach (var a in history.Take(_lifeHistoryLimit))
            {
                bool ongoing = a.Status == "进行中";
                string period = AgendaRange(d, a.StartedDay, a.FinishDay);
                string detail = ongoing ? period : $"{GameCalendar.Date(d, a.FinishDay):M/d} · 花费 {CareerMoney.Format(a.PaidCost >= 0 ? a.PaidCost : a.Cost)}";
                if (a.Result.Length > 0) detail += "\n" + a.Result;
                if (ongoing && (CareerTraining.IsTraining(a) || ClubPrograms.IsTraining(a))) detail += "\n" + CareerLife.Expected(d, a);
                box.AddChild(Text($"{a.Title} · {a.Status}\n{detail}", 15, _muted));
            }
            if (history.Count > _lifeHistoryLimit) box.AddChild(CaptionButton("查看更多", () => { _lifeHistoryLimit+=8; _planScroll=scroll.ScrollVertical; Render(); }));
        }
        scroll.SetDeferred(ScrollContainer.PropertyName.ScrollVertical, _planScroll);
    }
    private MarginContainer PlanDetails(CareerData d,CalendarPlan plan,Action<string> chooseTarget)
    {
        var inset=Inset(15,12);
        var details=new VBoxContainer {Name="PlanDetails"}; details.AddThemeConstantOverride("separation",5); inset.AddChild(details);
        details.AddChild(new HSeparator());
        void Field(string name,string value)
        {
            details.AddChild(DashboardLabel(name,14,_muted)); details.AddChild(DashboardLabel(value,16,_ink,true));
        }
        if(plan.Targets is {Count:>0} people)
        {
            details.AddChild(DashboardLabel("计划对象",14,_muted));
            var list=new OptionButton {FitToLongestItem=false}; details.AddChild(list);
            foreach(var person in people) list.AddItem(person.PublicName);
            string chosen=_planTarget.Length>0 ? _planTarget : d.Life.Activities.FirstOrDefault(a=>a.Id==plan.Key)?.PersonId??"";
            list.Select(Math.Max(0,people.FindIndex(person=>person.Id==chosen)));
            list.ItemSelected+=index=>chooseTarget(people[(int)index].Id);
        }
        else Field("计划对象",plan.Target);
        Field("实际影响",plan.Effect); Field("覆盖日期",plan.Dates);
        if(plan.Cost>0) Field("费用",CareerMoney.Format(plan.Cost));
        if (d.Life.Activities.FirstOrDefault(a => a.Id == plan.Key) is { } activity &&
            (plan.Cost < activity.Cost || CareerRelics.Duration(d, activity) < activity.Duration))
            Field("筹备与手办优惠", $"原价 {CareerMoney.Format(activity.Cost)} · 原定 {activity.Duration} 天");
        if (plan.TrainingDetails is { } breakdown)
        {
            var explanation = DashboardLabel("", 15, _muted, true); explanation.Hide();
            details.AddChild(TextLink("训练明细", () =>
            {
                if (!explanation.Visible) explanation.Text = breakdown();
                explanation.Visible = !explanation.Visible;
            }, 15, underline: true));
            details.AddChild(explanation);
        }
        if(plan.Availability.Length > 0) details.AddChild(DashboardLabel(plan.Availability,15,_muted,true));
        if(plan.Confirm!=null || plan.Availability.Length > 0)
        {
            var confirm=FramedAction(plan.ActionText,()=>plan.Confirm?.Invoke(),width:84,height:38);
            ButtonSurface(confirm,"2b4b51","7b9487","385d61","eed39b",5); confirm.Disabled=plan.Confirm==null || !plan.Enabled;
            confirm.Name="PlanConfirm"; confirm.SizeFlagsHorizontal=SizeFlags.ShrinkEnd; details.AddChild(confirm);
        }
        return inset;
    }

    private void OpenCalendarDay(int day)
    {
        var now = GameCalendar.Date(ViewData, ViewData.Day); var selected = GameCalendar.Date(ViewData, day);
        Visit(() => { _tab = "日程"; _calendarMonth = CalendarMonth.Distance(CalendarMonth.Owner(now),CalendarMonth.Owner(selected));
            _selectedDay = day; _calendarMode = "当日"; ClearPlan(); });
    }
    private sealed record AgendaItem(int Day,string Title,string Detail,string Person="player",
        CareerMatch? Match=null,PrivateOffer? Visit=null,RandomEventRecord? Encounter=null);

    private static string AgendaRange(CareerData data,int start,int end)
    {
        var a=GameCalendar.Date(data,start); var b=GameCalendar.Date(data,end);
        if (a==b) return a.ToString("M/d");
        string format=a.Year==b.Year ? "M/d" : "yy/M/d";
        return a.ToString(format)+"–"+b.ToString(format);
    }

    private static (string Title,string Stage) MatchCaption(CareerData d,CareerMatch match)
    {
        var cup=match.CompetitionId.Length==0 ? null : d.Esports.Competitions.FirstOrDefault(c=>c.Id==match.CompetitionId);
        string stage=match.Round>0 ? cup is {Modern:true} ? CircuitWorld.RoundName(cup,match.Round) : $"第{match.Round}轮" : "";
        string title=match.Event.Trim();
        if (title.Length==0) title=cup?.Name??EsportsWorld.StageName(match.Kind);
        // The fixture generator appends a round to the saved event name. Show that round once, on the detail line.
        int split=title.LastIndexOf(" · ",StringComparison.Ordinal);
        if (split>=0)
        {
            string suffix=title[(split+3)..];
            string compact=suffix.Replace(" ","");
            if (compact==stage.Replace(" ","") || match.Round>0 && compact==$"第{match.Round}轮")
                return (title[..split],suffix);
        }
        return (title,stage);
    }

    private static string MatchTitle(CareerData d,CareerMatch match) => MatchCaption(d,match).Title;
    private static string MatchDetail(CareerData d,CareerMatch match)
    {
        string opponent=match.OpponentId.Length>0 ? "对手："+CareerEngine.DisplayName(d,match.OpponentId) : "";
        return string.Join(" · ",new[]{MatchCaption(d,match).Stage,opponent}.Where(s=>s.Length>0));
    }

    private sealed record CalendarPeriod(string Title,string Status,int StartedDay,int FinishDay,int CompletionDay);
    private static IEnumerable<CalendarPeriod> CalendarPeriods(CareerData d)
    {
        foreach (var activity in d.Life.Activities.Where(a=>a.StartedDay>0 && (a.Status is "进行中" or "已完成")))
        {
            bool training=activity.TrainingStart>0 && activity.TrainingEnd>=activity.TrainingStart;
            yield return new(activity.Title,activity.Status,training?activity.TrainingStart:activity.StartedDay,
                training?activity.TrainingEnd:activity.FinishDay,activity.FinishDay);
        }
        foreach (var plan in ClubCoaching.TrainingPlans(d).Where(p=>p.ClubId==d.Esports.ClubId && (p.State is "进行中" or "已完成")))
            yield return new("教练训练 · "+CareerEngine.DisplayName(d,plan.PersonId),plan.State,plan.StartDay,plan.EndDay,plan.EndDay);
    }

    private static IEnumerable<AgendaItem> Upcoming(CareerData d,bool showPlans=true)
    {
        var encounters=d.Life.RandomEvents.Where(e=>e.Day>=d.Day && e.State is not ("complete" or "skipped"))
            .Select(e=>new AgendaItem(e.Day,e.Title,"随机事件",e.People.FirstOrDefault(id=>d.People.Any(p=>p.Id==id))??"player",Encounter:e));
        var visits=SocialAppointments.All(d).Where(x=>x.Offer.State=="已确认")
            .Select(x=>new AgendaItem(PrivateAppointments.Date(d,x.Offer),x.Offer.Title,
                "对象："+CareerEngine.DisplayName(d,x.Conversation.PersonId),x.Conversation.PersonId,Visit:x.Offer));
        var matches=d.Matches.Where(m=>m.Day>=d.Day && m.Registered && m.Status=="待赛").OrderByDescending(m=>m.CompetitionId.Length>0)
            .Select(m=>new AgendaItem(m.Day,MatchTitle(d,m),MatchDetail(d,m),m.OpponentId,Match:m));
        var plans=CalendarPeriods(d).Where(a=>showPlans && a.Status=="进行中").Select(a=>new AgendaItem(a.CompletionDay,a.Title,"计划完成日"));
        return encounters.Concat(visits).Concat(matches).Concat(plans).Where(x=>x.Day>=d.Day).OrderBy(x=>x.Day);
    }

    private void OpenAgendaItem(CareerData data,AgendaItem item)
    {
        if (item.Match is { } match) { Visit(()=>{ _tab="赛事"; _arenaMatchId=match.Id; }); return; }
        if (item.Day!=data.Day) { OpenCalendarDay(item.Day); return; }
        if (item.Encounter!=null) OpenRandomEvent(item.Encounter.Id);
        else if (item.Visit is { } visit)
        {
            if(visit.GroupId.Length>0) SelectGroup(visit.GroupId); else OpenPrivateMessages(item.Person);
        }
        else OpenCalendarDay(item.Day);
    }

    private void AgendaEntry(CareerData d,VBoxContainer box,AgendaItem item)
    {
        var row=new HBoxContainer {Alignment=BoxContainer.AlignmentMode.Begin};
        row.AddThemeConstantOverride("separation",15);
        var when=DashboardLabel(item.Day==d.Day?"今天":GameCalendar.Date(d,item.Day).ToString("M/d"),15,_gold);
        when.CustomMinimumSize=new(39,0); when.SizeFlagsHorizontal=SizeFlags.ShrinkBegin;
        when.SizeFlagsVertical=SizeFlags.ShrinkBegin; row.AddChild(when);
        var copy=new VBoxContainer {SizeFlagsHorizontal=SizeFlags.ExpandFill,MouseFilter=MouseFilterEnum.Ignore};
        copy.AddThemeConstantOverride("separation",3); row.AddChild(copy);
        copy.AddChild(DashboardLabel(item.Title,16,_ink,true));
        copy.AddChild(DashboardLabel(item.Detail,13,_muted,true));
        if (box.GetChildCount()>0) box.AddChild(Hairline());
        ActionRow(box,"AgendaRow",item.Title,()=>OpenCalendarDay(item.Day),row,68,0,8,"00000000","00000000","18303c");
    }

    private void UpcomingDays(CareerData d, VBoxContainer box)
    {
        var list=new VBoxContainer(); list.AddThemeConstantOverride("separation",0); box.AddChild(list);
        foreach (var item in Upcoming(d,_showCalendarPlans)) AgendaEntry(d,list,item);
        if (list.GetChildCount()==0) list.AddChild(DashboardLabel("暂无后续安排",16,_muted));
    }

    private void CalendarCommands(CareerData d, HBoxContainer box)
    {
        void Advance(int day)
        {
            if (day == d.Day) { OpenCalendarDay(day); return; }
            if (MultiplayerCommand("propose-advance",number:day)) return; CareerEngine.AdvanceToDay(d,day);
            _selectedDay = d.Day; _calendarMonth = 0; Render();
        }
        box.AddChild(TeamButton("推进一天",AdvanceCareerDay,0));
        if (CareerEngine.NextEventDay(d) is int day) box.AddChild(TeamButton("跳到下一个事件",()=>Advance(day),0));
        box.AddChild(TeamButton("跳过四周",()=>Advance(d.Day + 28),0));
        box.AddChild(TeamButton("下个赛季",()=>Advance(SeasonCalendar.End(d)+1),0));
        box.AddChild(new Control { SizeFlagsHorizontal=SizeFlags.ExpandFill });
        foreach(var button in box.GetChildren().OfType<Button>())
        {
            button.CustomMinimumSize=new(0,38); button.AddThemeFontSizeOverride("font_size",15);
            ButtonSurface(button,"142632","395365","28434c","658c91",6,5);
        }
        box.AddChild(DashboardSwitch("显示计划",_showCalendarPlans,on=>{_showCalendarPlans=on; Render();},112,38));
        var auto=DashboardSwitch("选拔赛自动报名",d.AutoQualifiers,on=>
        {
            if (MultiplayerCommand("propose-auto",number:on ? 1 : 0)) { Render(); return; }
            d.AutoQualifiers = on;
            if (d.AutoQualifiers) CircuitWorld.AutoEntry(d);
            else foreach (var m in d.Matches.Where(m => m.Kind is "local" or "city" or "academy" && m.Status == "待赛" && m.Id != d.PendingMatchId)) m.Registered = false;
            CareerStore.Save(d); Render();
        },158,38);
        auto.Disabled = _multiplayer is {Host:false}; box.AddChild(auto);
    }
}
