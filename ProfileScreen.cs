using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private bool _showGameArchive;

    private static HFlowContainer ProfileActions()
    {
        var row = new HFlowContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill };
        row.AddThemeConstantOverride("h_separation", 16);
        row.AddThemeConstantOverride("v_separation", 14);
        return row;
    }

    private VBoxContainer ProfileSection(string title)
    {
        var card = Card(); _content.AddChild(card);
        card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("142332", "314958", 8, 24));
        var box = Inner(card); box.AddThemeConstantOverride("separation", 20);
        if (title.Length > 0) box.AddChild(Text(title, 22, _gold));
        return box;
    }

    private void ProfileFields(VBoxContainer box, params (string Label, string Value)[] fields)
    {
        var grid = new GridContainer { Columns = fields.Count(f => f.Value.Length > 0) == 1 ? 1 : 2, SizeFlagsHorizontal = SizeFlags.ExpandFill };
        grid.AddThemeConstantOverride("h_separation", 32); grid.AddThemeConstantOverride("v_separation", 22);
        box.AddChild(grid);
        foreach (var field in fields.Where(f => f.Value.Length > 0))
        {
            var column = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill };
            column.AddThemeConstantOverride("separation", 8); grid.AddChild(column);
            column.AddChild(Text(field.Label, 14, _muted));
            column.AddChild(Text(field.Value, 18, _ink));
        }
    }

    private void ProfileStats(CareerData data,string clubId,bool player,params (string Label,string Value)[] fields)
    {
        var row=new HBoxContainer {Name="ProfileStats",SizeFlagsHorizontal=SizeFlags.ExpandFill};
        row.AddThemeConstantOverride("separation",18); _content.AddChild(row);
        VBoxContainer Stat(string label)
        {
            var card=Card(); row.AddChild(card); var body=Inner(card);
            body.AddThemeConstantOverride("separation",9); body.AddChild(DashboardLabel(label,14,_muted)); return body;
        }
        foreach(var (label,value) in fields) Stat(label).AddChild(DashboardLabel(value,23,_ink,true));
        var club=EsportsWorld.Club(data,clubId);
        var line=new HBoxContainer(); line.AddThemeConstantOverride("separation",10); Stat("所属俱乐部").AddChild(line);
        line.AddChild(DashboardLabel(club?.Name??"自由选手",23,_ink,true));
        if (player || club != null) line.AddChild(ClubAffiliationLink(data, club, player));
    }

    private Button ClubAffiliationLink(CareerData data, CareerClub? club, bool player)
    {
        return TextLink(club == null ? "加入俱乐部" : "查看俱乐部", () =>
        {
            if (player || club == null || club.Id == data.Esports.ClubId) OpenWorldSection("俱乐部");
            else Visit(() => { _tab = "赛事与俱乐部"; _worldSection = "所属俱乐部"; _profileClubId = club.Id; _competitionId = null; });
        }, 14, underline: true);
    }

    private void PlayerProfile(CareerData data)
    {
        _content.AddChild(PlayerBanner(data, "player"));
        if (ClubCoaching.PlayerFeatures(data))
            _content.AddChild(Text((ClubCoaching.PlayerReserve(data) ? "俱乐部轮换" : "俱乐部首发") + (ClubCoaching.PlayerCoach(data) ? " · 兼任教练" : ""), 18, CareerVisuals.Teal));
        var toolbar = new HBoxContainer { Name = "ProfileToolbar" }; toolbar.AddThemeConstantOverride("separation",16); _content.AddChild(toolbar);
        toolbar.AddChild(Button("编辑角色", () => OpenCharacterCard(data, "player"), 165));
        toolbar.AddChild(Button("更换头像", () => OpenAvatarSettings(data), 165));
        toolbar.AddChild(Button(_choosingFrame ? "收起头像框" : "更换头像框", () => { _choosingFrame = !_choosingFrame; Render(); }, 165));
        toolbar.AddChild(new Control { SizeFlagsHorizontal=SizeFlags.ExpandFill, MouseFilter=MouseFilterEnum.Ignore });
        toolbar.AddChild(Button("我的收藏", () => OpenShopShelf(null), 165));
        toolbar.AddChild(Button("我的资产", () => GoHub("我的资产"), 165));
        toolbar.AddChild(Button("荣誉室", () => OpenWorldSection("荣誉室"), 165));
        if (_choosingFrame) AvatarWardrobe(data, ProfileSection("头像框"));
        ProfileStats(data,data.Esports.ClubId,true,("生涯战绩", $"{data.Wins} 胜  {data.Draws} 平  {data.Losses} 负"),
            ("关注", data.Fans.ToString("N0")), ("世界积分", CircuitLedger.Points(data, "player").ToString()));
        var info = ProfileSection("人物资料");
        var card = data.PlayerCard;
        string character = card?.Character ?? CareerAvatars.MainCharacter(data, "player");
        character = GameBridge.Characters().FirstOrDefault(c => c.Id.ToString() == character)?.Title.GetFormattedText() ?? character;
        ProfileFields(info, ("性别", data.PlayerGender), ("职业", card?.Role ?? EsportsWorld.LicenseName(data)),
            ("擅长角色", character), ("姓名", card?.Name ?? ""),
            ("参赛资格", card != null && card.Role != EsportsWorld.LicenseName(data) ? EsportsWorld.LicenseName(data) : ""),
            ("当前连胜", data.Esports.WinStreak > 0 ? $"{data.Esports.WinStreak} 场" : ""));
        ProfileFields(info, ("本季国家队", data.Esports.NationalTeam ? "国家队代表" : "尚未入选"),
            ("当前目标", EsportsWorld.NextGoal(data)), ("生涯评价", CareerNarrative.PlayerEvaluation(data)));
        if (card?.Style.Length > 0) ProfileFields(info, ("构筑偏好", card.Style));
        if (card?.Biography.Length > 0) ProfileSection("人物介绍").AddChild(Text(card.Biography, 18, _ink));
        var honors = ProfileSection("荣誉与排名");
        string standing = CircuitLedger.PublicStanding(data, "player", data.Day);
        if (standing.Length > 0) honors.AddChild(Text(standing, 17, CareerVisuals.Teal));
        foreach (var honor in data.Esports.Honors.TakeLast(4).Reverse())
            ProfileEntry(honors, honor.Title, $"第 {honor.Season} 赛季", _gold);
        if (standing.Length == 0 && data.Esports.Honors.Count == 0) honors.AddChild(Text("暂无荣誉记录", 16, _muted));
        if (data.PlayerIntroduction.Length > 0)
            ProfileSection($"周刊档案 · 第 {data.PlayerIntroductionDay / 7} 周").AddChild(Text(data.PlayerIntroduction, 18, _ink));
        if (data.Results.Count > 0)
        {
            var results = ProfileSection("近期赛事");
            foreach (var result in data.Results.TakeLast(3).Reverse())
            {
                var entry = new VBoxContainer(); entry.AddThemeConstantOverride("separation", 10); results.AddChild(entry);
                ProfileEntry(entry, result.Event, result.Outcome, _ink);
                entry.AddChild(Text($"{MatchRules.AscensionLabel(result)} · {MatchRules.Performance(result.Win, result.Floor, result.RunSeconds)}", 15, _muted));
            }
        }
        if (_multiplayer == null)
        {
            _content.AddChild(Button(_showGameArchive ? "收起游戏总档案" : "查看游戏总档案", () => { _showGameArchive = !_showGameArchive; Render(); }, 220));
            if (_showGameArchive) ShowArchive();
        }
    }

    private void PersonProfile(CareerData data, CareerPerson person)
    {
        _content.AddChild(PlayerBanner(data, person.Id));
        {
            var toolbar = ProfileActions(); _content.AddChild(toolbar);
            toolbar.AddChild(Button("设计立绘", () => OpenPortraitDesigner(data, person.Id), 165));
            toolbar.AddChild(Button("立绘与场景", () => OpenDateAssets(data, person.Id), 165));
            if (CanEditCharacter(data, person.Id)) toolbar.AddChild(Button("编辑角色", () => OpenCharacterCard(data, person.Id), 165));
            if (!GroupChats.IsHuman(data, person.Id)) toolbar.AddChild(Button("选择头像框", () => NpcAvatarFramePicker(data, person.Id), 165));
        }
        int total = person.Wins + person.Losses;
        ProfileStats(data,person.ClubId,false,("累计战绩", $"{person.Wins} 胜  {person.Losses} 负"),
            ("历史胜率", total == 0 ? "暂无战绩" : $"{100.0 * person.Wins / total:0.#}%"),
            ("世界积分", CircuitLedger.Points(data, person.Id).ToString()));
        PrivateProfile(data,person);
        var info = ProfileSection("人物资料");
        ProfileFields(info, ("性别", IdentityGender.Of(data, person.Id)), ("擅长角色", person.Character),
            ("身份", string.Join(" / ", person.Identities)), ("构筑偏好", person.Style),
            ("关注俱乐部", person.SupportedClubId.Length > 0 ? EsportsWorld.ClubName(data, person.SupportedClubId) : ""));
        ProfileFields(info, ($"进阶 {person.MaxAscension} 当前通关率", MatchRules.Evaluate(data, person, person.MaxAscension).Display()));
        if (CareerTraining.MoodLevel(person, data.Day) is var mood && mood != 0)
            ProfileFields(info, ("短期状态", (mood > 0 ? "振奋" : "低落") + $" · 剩余 {CareerTraining.MoodUntil(person, data.Day) - data.Day} 天"),
                ("状态变化", "随日期逐渐消退"));
        if (person.RecordedWinStreak > 0) ProfileSection("连胜纪录").AddChild(Text(CameoContent.StreakText(person), 18, _gold));
        string standing = CircuitLedger.PublicStanding(data, person.Id, data.Day);
        if (standing.Length > 0) ProfileSection("赛事排名").AddChild(Text(standing, 17, CareerVisuals.Teal));
        if (person.Biography.Length > 0 || person.CameoId.Length == 0 && EsportsWorld.IsProfessional(person))
        {
            var bio = ProfileSection("人物介绍");
            if (person.Biography.Length > 0) bio.AddChild(Text(person.Biography, 18, person.CameoId.Length > 0 ? _gold : _ink));
            if (person.CameoId.Length == 0 && EsportsWorld.IsProfessional(person)) bio.AddChild(Text(CareerNarrative.Evaluation(data, person), 17, _gold));
        }
        if (person.CameoId.Length == 0 && person.AiIntroduction.Length > 0)
            ProfileSection($"周刊档案 · 第 {person.IntroductionDay / 7} 周").AddChild(Text(person.AiIntroduction, 18, _ink));
        // 合同控件仍使用已有转会与解约流程，无操作时不占据空白区域。
        var contract = new VBoxContainer(); contract.AddThemeConstantOverride("separation", 20);
        ClubProfileActions(data, person, contract);
        if (contract.GetChildCount() > 0) ProfileSection("俱乐部合同").AddChild(contract); else contract.Free();
        if (person.Connections.Count > 0)
        {
            var relations = ProfileSection("熟悉的人");
            foreach (string id in person.Connections.Take(2)) relations.AddChild(PersonLink(data, id, CareerEngine.DisplayName(data, id) + "   ↗", 40));
        }
    }

    private void ProfileEntry(VBoxContainer parent, string title, string detail, Color color)
    {
        var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 24); parent.AddChild(row);
        row.AddChild(Text(title, 18, color));
        var label = Text(detail, 15, _muted); label.SizeFlagsHorizontal = SizeFlags.ShrinkEnd;
        label.CustomMinimumSize = new(125, 0); label.HorizontalAlignment = HorizontalAlignment.Right; row.AddChild(label);
    }
}

