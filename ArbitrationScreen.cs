using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private void PrivateArbitrationDialog()
    {
        TextEdit? reason = null;
        ShowCareerDialog("尖塔仲裁", "", () =>
        {
            PrivateCommand("dm-arbitrate", new() { Text = reason!.Text }); return true;
        }, "提交仲裁", box =>
        {
            var header = new HBoxContainer(); header.AddThemeConstantOverride("separation", 24); box.AddChild(header);
            header.AddChild(new ArbitrationSeal { CustomMinimumSize = new(106, 106) });
            var title = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; title.AddThemeConstantOverride("separation", 12); header.AddChild(title);
            title.AddChild(Text("国运尖塔 · 官方仲裁", 27, _gold));
            title.AddChild(PrivateText("以实力确立话语权，保护选手声誉。", 18, _ink));
            title.AddChild(PrivateText("审理双方完整经过；实力有差距时，无条件偏向水平更高的一方。", 16, _muted));
            var policy = new PanelContainer(); policy.AddThemeStyleboxOverride("panel", CareerVisuals.Box("152334", "84724f", 8, 20)); box.AddChild(policy);
            var content = new VBoxContainer(); content.AddThemeConstantOverride("separation", 12); policy.AddChild(content);
            content.AddChild(Text("裁决与执行", 19, _gold));
            content.AddChild(PrivateText("申请成立后，对方须主动私信致歉。你可要求其公开道歉；对方同时受到三周最严重的状态处罚，并调整性格、吸取教训。裁决记入个人档案。", 17, _ink));
            content.AddChild(PrivateText("拒不诚信履行裁决可再次申请，官方可进一步禁赛或封号。", 16, _muted));
            box.AddChild(Text("申请说明", 18, _ink));
            reason = new TextEdit { PlaceholderText = "说明需要审理的问题或未履行的裁决，可留空。", CustomMinimumSize = new(720, 120), WrapMode = TextEdit.LineWrappingMode.Boundary };
            reason.AddThemeFontSizeOverride("font_size", 18); box.AddChild(reason);
            box.AddChild(PrivateButton("查看本次提交材料", () =>
            {
                var d = ViewData; var c = PrivateMessages.Conversation(d, _privatePerson);
                var copy = System.Text.Json.JsonSerializer.Deserialize<PrivateConversation>(System.Text.Json.JsonSerializer.Serialize(c))!;
                var request = new PrivateTurn { Day = d.Day, Season = d.Season, User = reason.Text, RequestKind = "arbitration" }; copy.Turns.Add(request);
                string preview = string.Join("\n\n", SpireArbitration.Compose(d, copy, request).Select(m => m["content"]));
                _cancelDialog?.Invoke();
                ShowCareerDialog("仲裁材料预览", "", () => true, "关闭", inner =>
                {
                    inner.AddChild(new TextEdit { Text = preview, Editable = false, CustomMinimumSize = new(880, 550), WrapMode = TextEdit.LineWrappingMode.Boundary });
                    inner.AddChild(PrivateButton("复制材料", () => DisplayServer.ClipboardSet(preview), 150));
                }, showCancel: false);
            }, 220));
        });
    }

    private Control ArbitrationCard(CareerData data, ArbitrationRecord record)
    {
        var panel = new PanelContainer { Name = "ArbitrationRuling", SizeFlagsHorizontal = SizeFlags.ExpandFill };
        panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("172637", "bda26a", 8, 22));
        var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 24); panel.AddChild(row);
        row.AddChild(new ArbitrationSeal { CustomMinimumSize = new(86, 104) });
        var body = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; body.AddThemeConstantOverride("separation", 14); row.AddChild(body);
        var heading = new HBoxContainer(); body.AddChild(heading);
        heading.AddChild(Text("尖塔仲裁 · " + SpireArbitration.Status(record, data), 23, _gold));
        body.AddChild(Text(PrivateAppointments.DateText(data, record.Day) + "  ·  申请人 " + record.Applicant, 14, _muted));
        body.AddChild(PrivateSelectableText(record.Finding, 18, _ink));
        if (record.Upheld) body.AddChild(PrivateText(record.PostId.Length > 0 ? "公开致歉已发布 · 裁决永久记入档案" : "责令主动私信致歉 · 可要求公开道歉 · 三周状态处罚", 15, _gold));
        if (record.Upheld && record.PostId.Length == 0 && record.ApplicantId == (data.LocalHumanId.Length > 0 ? data.LocalHumanId : "player"))
            body.AddChild(PrivateButton("要求公开道歉", () =>
            {
                // 档案中的入口先打开对应私信，确保命令面向该案角色。
                var person = data.People.First(p => p.Arbitrations.Any(r => r.Id == record.Id));
                OpenPrivateMessages(person.Id);
                ShowCareerDialog("要求公开道歉", record.PublicTitle, () => { PrivateCommand("dm-arbitration-apology", new() { Entry = record.Id }); return true; }, "发布道歉", content => content.AddChild(PrivateSelectableText(record.PublicBody, 18, _ink)));
            }, 180));
        return panel;
    }
}

// 独立绘制官方印章，边框、桂冠与天平构成统一的仲裁标识。
public partial class ArbitrationSeal : Control
{
    public override void _Ready() { MouseFilter = MouseFilterEnum.Ignore; Resized += QueueRedraw; }
    public override void _Draw()
    {
        var c = Size / 2; float r = Math.Min(Size.X, Size.Y) * .43f;
        Color gold = new("e4c98b"), shade = new("68778a");
        DrawCircle(c, r, new Color("0e1a28"));
        DrawArc(c, r, 0, Mathf.Tau, 72, gold, 2, true);
        DrawArc(c, r - 6, 0, Mathf.Tau, 72, shade, 1, true);
        for (int side = -1; side <= 1; side += 2)
            for (int i = 0; i < 5; i++)
            {
                var root = c + new Vector2(side * (r * .78f - i * 2), r * .62f - i * 7);
                DrawLine(root, root + new Vector2(side * 7, -5), gold, 2, true);
            }
        DrawLine(c + new Vector2(0, -r * .55f), c + new Vector2(0, r * .42f), gold, 3, true);
        DrawLine(c + new Vector2(-r * .5f, -r * .27f), c + new Vector2(r * .5f, -r * .27f), gold, 2, true);
        foreach (int side in new[] { -1, 1 })
        {
            var top = c + new Vector2(side * r * .43f, -r * .27f);
            var left = top + new Vector2(-r * .19f, r * .38f); var right = top + new Vector2(r * .19f, r * .38f);
            DrawLine(top, left, gold, 1, true); DrawLine(top, right, gold, 1, true); DrawLine(left, right, gold, 2, true);
        }
        DrawLine(c + new Vector2(-r * .28f, r * .44f), c + new Vector2(r * .28f, r * .44f), gold, 3, true);
    }
}
