using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private void CoachManagement(CareerData d)
    {
        var o = d.Esports.OwnedClub!;
        var box = ClubCard("教练与席位", "教练提升轮换与青训陪练效果，多名教练取最高加成。");
        var row = new HFlowContainer(); row.AddThemeConstantOverride("h_separation", 12); row.AddThemeConstantOverride("v_separation", 10); box.AddChild(row);
        row.AddChild(Text($"当前陪练系数 ×{ClubCoaching.Factor(d):0.#}", 20, CareerVisuals.Teal));
        if (ClubCoaching.PlayerFeatures(d))
        {
            row.AddChild(ClubButton(o.PlayerCoach ? "结束教练任职" : "兼任教练", () =>
                ShowCareerDialog(o.PlayerCoach ? "结束教练任职" : "兼任教练", o.PlayerCoach ? "停止未完成的教练训练，已获得成长保留。" : "可在队员私信中附上训练计划，由对方确认后开始。", () => { ClubAction(d, "player-coach", o.PlayerCoach ? "0" : "1"); return true; }), 170));
            row.AddChild(ClubButton(o.PlayerReserve ? "恢复首发" : "退出首发", () => PlayerPositionDialog(d), 190));
            if (o.PlayerPositionSeason > 0)
            {
                box.AddChild(Text($"第{o.PlayerPositionSeason}赛季转为{o.PlayerNextPosition} · 与{CareerEngine.DisplayName(d, o.PlayerReplacement)}调整席位", 17, _gold));
                box.AddChild(ClubButton("撤销席位申请", () => ClubAction(d, "player-position", target: "取消"), 170));
            }
        }
        foreach (var a in o.CoachAppointments)
        {
            var pending = new HFlowContainer(); box.AddChild(pending);
            pending.AddChild(Text($"{CareerEngine.DisplayName(d, a.PersonId)} · 第{a.Season}赛季转任教练", 17, _muted));
            pending.AddChild(ClubButton("取消调整", () => ClubAction(d, "coach-cancel", target: a.PersonId), 120));
        }
    }
    private void PlayerPositionDialog(CareerData d)
    {
        var o = d.Esports.OwnedClub!;
        bool reserve = !o.PlayerReserve;
        var ids = reserve ? ClubCoaching.Replacements(d) : OwnedClubs.ReplaceableStarters(d);
        string selected = ids.FirstOrDefault() ?? "";
        Label? error = null;
        ShowCareerDialog(reserve ? "退出首发" : "恢复首发", OwnedClubSchedule.PlayerPositionTiming(d), () =>
        {
            var result = ClubCoaching.SetPlayerPosition(d, reserve ? "轮换" : "首发", selected);
            if (result != null) { error!.Text = result; return false; }
            Render(); return true;
        }, "确认调整", box =>
        {
            box.AddChild(Text(CareerEngine.Name(d) + (reserve ? " · 首发 → 轮换" : " · 轮换 → 首发"), 18, _ink));
            if (ids.Count > 0) box.AddChild(ClubSelect(ids.Select(id => (reserve ? "接替首发 · " : "转入轮换 · ") + CareerEngine.DisplayName(d, id)).ToArray(), 0, i => selected = ids[i]));
            error = Text(ids.Count == 0 ? "没有符合条件的接替人选，请先补齐阵容。" : "", 16, new Color("ee929d")); box.AddChild(error);
        });
    }
    private void CoachAppointmentDialog(CareerData d, string id)
    {
        var o = d.Esports.OwnedClub!;
        bool scheduled = ClubCoaching.Scheduled(d, id);
        var ids = o.Starters.Contains(id) ? ClubCoaching.Replacements(d, id) : [];
        string replacement = ids.FirstOrDefault() ?? "";
        Label? error = null;
        ShowCareerDialog("转任教练", CareerEngine.DisplayName(d, id) + (scheduled ? " · 下赛季生效" : " · 立即生效") + "\n合同待遇保留，转任后不再兼任选手。", () =>
        {
            if (MultiplayerCommand("owned-coach", id, replacement)) return true;
            var result = ClubCoaching.Appoint(d, id, replacement);
            if (result != null) { error!.Text = result; return false; }
            Render(); return true;
        }, "确认转任", box =>
        {
            if (ids.Count > 0) box.AddChild(ClubSelect(ids.Select(i => "接替首发 · " + CareerEngine.DisplayName(d, i)).ToArray(), 0, i => replacement = ids[i]));
            error = Text("", 16, new Color("ee929d")); box.AddChild(error);
        });
    }
    private void PrivateTrainingPicker()
    {
        TextEdit? input = null; int weeks = 4; Label? error = null;
        ShowCareerDialog("制定训练计划", "发送附件，由队员确认训练内容。", () =>
        {
            var attachment = new PrivateOffer { Kind = "training", Detail = input!.Text.Trim(), Weeks = weeks };
            if (ClubCoaching.TrainingError(ViewData, _privatePerson, attachment) is { } result) { error!.Text = result; return false; }
            AttachPrivate(attachment); return true;
        }, "添加附件", box =>
        {
            input = new TextEdit { PlaceholderText = "填写训练内容", CustomMinimumSize = new(680, 150), WrapMode = TextEdit.LineWrappingMode.Boundary }; box.AddChild(input);
            var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 16); box.AddChild(row);
            row.AddChild(Text("训练周期", 18, _ink));
            var picker = new OptionButton { CustomMinimumSize = new(150, 46) }; for (int w = 1; w <= 4; w++) picker.AddItem(w + "周");
            picker.Select(3); picker.ItemSelected += i => weeks = (int)i + 1; row.AddChild(picker);
            error = Text("", 16, new Color("ee929d")); box.AddChild(error);
        });
    }
    private void PrivateLineupPicker()
    {
        var data = ViewData; var members = CoachLineups.Candidates(data);
        string first = members.FirstOrDefault()?.Id ?? "";
        string second = members.FirstOrDefault(p => first.Length > 0 && CoachLineups.Position(data, p) != CoachLineups.Position(data, members[0]))?.Id ?? "";
        Label? error = null, preview = null;
        void Preview()
        {
            if (preview != null) preview.Text = first.Length > 0 && second.Length > 0
                ? CoachLineups.Description(data, new() { First = first, Second = second, FirstPosition = CoachLineups.Position(data, CoachLineups.Person(data, first)!), SecondPosition = CoachLineups.Position(data, CoachLineups.Person(data, second)!) }) : "请选择两名队员。";
        }
        ShowCareerDialog("请求调整阵容", $"由教练答复，第{data.Season + 1}赛季生效。", () =>
        {
            var attachment = new PrivateOffer { Kind = "lineup", FirstPerson = first, SecondPerson = second };
            if (CoachLineups.Error(ViewData, _privatePerson, attachment) is { } result) { error!.Text = result; return false; }
            attachment.Detail = CoachLineups.Prepare(ViewData, attachment); AttachPrivate(attachment); return true;
        }, "添加附件", box =>
        {
            string[] labels = members.Select(p => $"{p.PublicName}{(p.Id == "player" ? "（你）" : "")} · {CoachLineups.Position(data, p)} · A{p.MaxAscension}").ToArray();
            if (members.Count > 0)
            {
                box.AddChild(Text("调整队员", 17, _muted));
                box.AddChild(ClubSelect(labels, 0, i => { first = members[i].Id; Preview(); }));
                box.AddChild(Text("交换席位的队员", 17, _muted));
                box.AddChild(ClubSelect(labels, Math.Max(0, members.FindIndex(p => p.Id == second)), i => { second = members[i].Id; Preview(); }));
            }
            preview = PrivateText("", 18, CareerVisuals.Teal); box.AddChild(preview); Preview();
            error = Text(members.Count == 0 ? "目前没有可调整的队员。" : "", 16, new Color("ee929d")); box.AddChild(error);
        });
    }
    private void PrivateLineupCard(CareerData data, CoachLineupRequest request, VBoxContainer parent, Action<string, PrivateMessageCommand>? send = null)
    {
        var panel = new PanelContainer { Name = "CoachLineupCard" };
        panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("193440", "6aa9a8", 9, 18)); parent.AddChild(panel);
        var inner = Inner(panel); inner.AddThemeConstantOverride("separation", 10);
        inner.AddChild(Text("阵容调整 · " + request.State, 21, _gold));
        inner.AddChild(PrivateText(CoachLineups.Description(data, request), 18, _ink));
        inner.AddChild(Text($"第{request.Season}赛季", 16, _muted));
        if (request.Reason.Length > 0) inner.AddChild(PrivateText(request.Reason, 16, new Color("ee929d")));
        if (request.State == "待生效") inner.AddChild(PrivateButton("取消调整", () => { if (send != null) send("lineup-cancel", new() { Offer = request.Id }); else PrivateCommand("dm-lineup-cancel", new() { Offer = request.Id }); }, 130));
    }
    private readonly HashSet<string> _privateExpandedTraining = [];
    private Queue<CoachTrainingPlan> TrainingCompletions(IEnumerable<PrivateOffer> offers, long first, long end)
    {
        var ids = offers.Where(o => o.Kind == "training" && !o.MemoryDeleted).Select(o => o.Id).ToHashSet();
        return new(ClubCoaching.TrainingPlans(ViewData).Where(p => p.State == "已完成" && p.CompletionOrder > 0
            && p.CompletionOrder >= first && p.CompletionOrder < end && ids.Contains(p.Id)).OrderBy(p => p.CompletionOrder));
    }
    private void TrainingCompletionsThrough(Queue<CoachTrainingPlan> plans, long order)
    {
        while (plans.TryPeek(out var plan) && plan.CompletionOrder <= order)
        {
            plans.Dequeue();
            _privateBody!.AddChild(PrivateLine(PrivateAppointments.DateText(ViewData, plan.CompletionDay) + " · " + GroupChats.Name(ViewData, plan.PersonId), 13, _muted));
            PrivateTrainingCard(ViewData, plan, _privateBody);
        }
    }
    private void PrivateTrainingCard(CareerData data, CoachTrainingPlan plan, VBoxContainer parent, Action<string, PrivateMessageCommand>? send = null)
    {
        var panel = new PanelContainer { Name = "CoachTrainingCard" }; panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("193440", "6aa9a8", 9, 18)); parent.AddChild(panel);
        var inner = Inner(panel); inner.AddThemeConstantOverride("separation", 10);
        inner.AddChild(Text((send != null ? GroupChats.Name(data, plan.PersonId) + " · " : "") + "教练训练 · " + plan.State, 21, _gold));
        inner.AddChild(Text($"{PrivateAppointments.DateText(data, plan.StartDay)}—{PrivateAppointments.DateText(data, plan.EndDay)}", 15, _muted));
        var progress = new ProgressBar { MinValue = 0, MaxValue = plan.Weeks, Value = plan.PaidWeeks, ShowPercentage = false, CustomMinimumSize = new(0, 8), MouseFilter = MouseFilterEnum.Ignore };
        inner.AddChild(progress);
        inner.AddChild(Text($"完成 {plan.PaidWeeks}/{plan.Weeks} 周 · 永久成长 +{plan.Gained * 100:0.##}%", 17, CareerVisuals.Teal));
        var details = PrivateText(plan.Content, 18, _ink); details.Name = "TrainingDetails_" + plan.Id;
        details.Visible = _privateExpandedTraining.Contains(plan.Id);
        var toggle = new CoachTrainingDisclosureButton { Name = "TrainingToggle_" + plan.Id, Text = details.Visible ? "收起" : "展开", Flat = true,
            SizeFlagsHorizontal = SizeFlags.ShrinkBegin, MouseDefaultCursorShape = CursorShape.PointingHand };
        toggle.AddThemeFontSizeOverride("font_size", 14);
        foreach (string state in new[] { "font_color", "font_hover_color", "font_pressed_color", "font_hover_pressed_color", "font_focus_color" })
            toggle.AddThemeColorOverride(state, _muted);
        foreach (string state in new[] { "normal", "hover", "pressed" })
            toggle.AddThemeStyleboxOverride(state, new StyleBoxEmpty { ContentMarginRight = 20 });
        toggle.Pressed += () =>
        {
            bool expanded = !_privateExpandedTraining.Remove(plan.Id);
            if (expanded) _privateExpandedTraining.Add(plan.Id);
            details.Visible = expanded; toggle.Text = expanded ? "收起" : "展开"; toggle.QueueRedraw();
        };
        inner.AddChild(toggle); inner.AddChild(details);
        if (plan.State == "进行中") inner.AddChild(PrivateButton("取消训练", () => { if (send != null) send("training-cancel", new()); else PrivateCommand("dm-training-cancel", new()); }, 130));
    }
}

/// <summary>训练详情的无柄箭头与按钮文字共用字号及颜色。</summary>
public partial class CoachTrainingDisclosureButton : Button
{
    public override void _Draw()
    {
        float side = GetThemeFontSize("font_size"), direction = Text == "收起" ? -1 : 1;
        var center = new Vector2(Size.X - side / 2, Size.Y / 2);
        DrawPolyline([center + new Vector2(-side * .4f, -direction * side * .2f),
            center + new Vector2(0, direction * side * .2f),
            center + new Vector2(side * .4f, -direction * side * .2f)], GetThemeColor("font_color"), 1.5f, true);
    }
}
