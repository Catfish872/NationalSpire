using Godot;
using NationalSpire.Coop;

namespace NationalSpire;

public partial class CareerScreen
{
    private Control? _characterCardOverlay;
    private Action? _closeCharacterCard;
    private bool CanEditCharacter(CareerData data, string id) => id == "player" || !data.HumanIds.Contains(id) && _multiplayer?.Host != false;
    private void OpenCharacterCard(CareerData data, string? id, CareerPerson? imported = null)
    {
        if (_characterCardOverlay != null) return;
        if (data.PendingMatchId != null) { Notice("请在比赛结束后编辑角色。", true); return; }
        if (!CanEditCharacter(data, id ?? "")) return;
        bool create = id == null;
        var draft = imported ?? (create ? CharacterCards.New(data) : CharacterCards.Read(data, id!));
        var edit = new CharacterCardEdit { Create = create, Target = draft.Id, Person = draft };
        var previousFocus = GetViewport().GuiGetFocusOwner();
        IEnumerable<Control> Controls(Node node) => node.GetChildren().SelectMany(child =>
            (child is Control c ? new[] { c } : Array.Empty<Control>()).Concat(Controls(child)));
        var focus = Controls(_stage).Where(c => c.FocusMode != FocusModeEnum.None).Select(c => (Control: c, Mode: c.FocusMode)).ToList();
        foreach (var entry in focus) entry.Control.FocusMode = FocusModeEnum.None;
        var shade = new ColorRect { Name = "CharacterCardEditor", Color = new(0, 0, 0, .84f), MouseFilter = MouseFilterEnum.Stop, ZIndex = 15 };
        _characterCardOverlay = shade; _stage.AddChild(shade); shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        var margin = new MarginContainer(); shade.AddChild(margin); margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        foreach (string edge in new[] { "left", "right" }) margin.AddThemeConstantOverride("margin_" + edge, 100);
        foreach (string edge in new[] { "top", "bottom" }) margin.AddThemeConstantOverride("margin_" + edge, 45);
        var panel = Card(); margin.AddChild(panel); var root = Inner(panel); root.AddThemeConstantOverride("separation", 16);
        var header = new HBoxContainer(); header.AddThemeConstantOverride("separation", 22); root.AddChild(header);
        AvatarArt AutomaticPortrait()
        {
            if (CameoAssets.ForPerson(draft.CameoId) is { } cameo) return cameo;
            string world = data.AvatarWorldId.Length > 0 ? data.AvatarWorldId : data.WorldId;
            string identityId = draft.Id == "player" && data.LocalHumanId.Length > 0 ? data.LocalHumanId : draft.Id;
            int variation = CareerEngine.StableHash(world + ":avatar:" + identityId);
            return AvatarAssets.Load(draft.Character, variation, identityId != "player" && variation % 3 != 0);
        }
        var portrait = new CareerAvatar { Name = "CardPortrait", CustomMinimumSize = new(88, 88), Art = AvatarImages.Read(draft.Avatar) ?? AutomaticPortrait() };
        header.AddChild(portrait);
        var heading = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; header.AddChild(heading);
        heading.AddChild(Text(create ? "创建角色" : "编辑角色", 30, _gold));
        var subtitle = Text(imported != null ? "已读取角色卡，确认资料后创建。" : create ? "从预设开始，填写你的人物档案。" : draft.PublicName, 18, _muted); heading.AddChild(subtitle);
        header.AddChild(Button("选择头像", () => OpenAvatarSettings(data, draft.Avatar, avatar =>
        { draft.Avatar = avatar; portrait.Art = AvatarImages.Read(avatar) ?? AutomaticPortrait(); }, draft.Id, AutomaticPortrait()), 165));
        if (!create && draft.CreatedCard)
        {
            var delete = Button("删除角色", () => ShowCareerDialog("删除" + draft.PublicName, "取消未完成的安排，历史帖子和赛果保留。", () =>
            {
                if (MultiplayerCommand("character-delete", draft.Id, accepted: () => { _multiplayer!.Refresh(); _closeCharacterCard?.Invoke(); Render(); })) return true;
                var error = CharacterDeletion.Delete(data, draft.Id);
                if (error != null) { Notice(error, true); return false; }
                CareerStore.Save(data); _closeCharacterCard?.Invoke(); ResetNavigation(); Render(); return true;
            }, "删除角色", compact: true), 145);
            delete.Name = "DeleteCustomCharacter"; delete.AddThemeColorOverride("font_color", new Color("e9a799")); header.AddChild(delete);
        }
        var tabs = new HBoxContainer(); tabs.AddThemeConstantOverride("separation", 12); root.AddChild(tabs);
        var scroll = new BroadcastScroll { Name = "CharacterCardScroll", SizeFlagsVertical = SizeFlags.ExpandFill, HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; root.AddChild(scroll);
        var pages = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; scroll.AddChild(pages);
        var sections = new List<VBoxContainer>(); var tabButtons = new List<Button>();
        VBoxContainer Section(string title)
        {
            int index = sections.Count;
            var content = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, Visible = index == 0 }; content.AddThemeConstantOverride("separation", 18); pages.AddChild(content); sections.Add(content);
            var button = Button(title, () =>
            {
                for (int i = 0; i < sections.Count; i++) { sections[i].Visible = i == index; tabButtons[i].Modulate = i == index ? CareerVisuals.Teal : Colors.White; }
                scroll.ScrollVertical = 0;
            }, 170);
            if (index == 0) button.Modulate = CareerVisuals.Teal;
            tabs.AddChild(button); tabButtons.Add(button); return content;
        }
        VBoxContainer Field(Control parent, string label)
        {
            var box = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; box.AddThemeConstantOverride("separation", 8); parent.AddChild(box);
            box.AddChild(Text(label, 17, _muted)); return box;
        }
        GridContainer Pair(Control parent)
        {
            var grid = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }; grid.AddThemeConstantOverride("h_separation", 24); grid.AddThemeConstantOverride("v_separation", 18); parent.AddChild(grid); return grid;
        }
        LineEdit Line(Control parent, string label, string value, Action<string> change, int limit = 120, string? name = null)
        {
            var field = Field(parent, label); var input = new LineEdit { Text = value, MaxLength = limit, CustomMinimumSize = new(0, 46), SizeFlagsHorizontal = SizeFlags.ExpandFill };
            if (name != null) input.Name = name;
            input.TextChanged += value => change(value); field.AddChild(input); return input;
        }
        OptionButton Choice(Control parent, string label, string[] labels, int selected, Action<int> change, string? name = null)
        {
            var field = Field(parent, label); var input = new OptionButton { FitToLongestItem = false, CustomMinimumSize = new(0, 46), SizeFlagsHorizontal = SizeFlags.ExpandFill };
            if (name != null) input.Name = name;
            foreach (string text in labels) input.AddItem(text); input.Select(Math.Max(0, selected)); field.AddChild(input); input.ItemSelected += n => change((int)n); return input;
        }
        SpinBox Number(Control parent, string label, double value, double min, double max, Action<double> change, string name, double step = 1)
        {
            var field = Field(parent, label); var input = new SpinBox { Name = name, MinValue = min, MaxValue = max, Step = step, Value = value, CustomMinimumSize = new(0, 46), SizeFlagsHorizontal = SizeFlags.ExpandFill };
            field.AddChild(input); input.ValueChanged += value => change(value); return input;
        }
        TextEdit Memo(Control parent, string label, string value, Action<string> change, string? name = null)
        {
            var field = Field(parent, label); var input = new TextEdit { Text = value, CustomMinimumSize = new(0, 96), WrapMode = TextEdit.LineWrappingMode.Boundary, SizeFlagsHorizontal = SizeFlags.ExpandFill };
            input.AddThemeFontSizeOverride("font_size", 18);
            input.AddThemeColorOverride("font_color", _ink);
            input.AddThemeStyleboxOverride("normal", CareerVisuals.Box("0c1b27", "304e5d", 8, 14));
            input.AddThemeStyleboxOverride("focus", CareerVisuals.Box("10232e", "69bcb3", 8, 14));
            if (name != null) input.Name = name; input.TextChanged += () => change(input.Text); field.AddChild(input); return input;
        }
        var identity = Section("身份与归属"); var identityFields = Pair(identity);
        Line(identityFields, "游戏 ID", draft.Handle, v => { draft.Handle = v; subtitle.Text = v; }, 32, "CardHandle");
        Line(identityFields, "姓名 · 可留空", draft.Name, v => draft.Name = v, 64, "CardRealName");
        var genders = draft.Id == "player" ? IdentityGender.Choices : new[] { "男", "女" };
        var gender = Choice(identityFields, "性别", genders, Array.IndexOf(genders, draft.Gender), n => draft.Gender = genders[n], "CardGender");
        gender.Disabled = draft.CameoId.Length > 0;
        string? clubLock = CharacterCards.ClubLock(data, draft.Id);
        var country = Choice(identityFields, "国家 / 地区", EsportsWorld.Countries, Array.IndexOf(EsportsWorld.Countries, draft.Country), n => draft.Country = EsportsWorld.Countries[n], "CardCountry");
        country.Disabled = draft.Id == "player" && clubLock != null;
        var clubChoices = data.Esports.Clubs.OrderByDescending(c => c.Id == data.Esports.OwnedClub?.ClubId).ToArray();
        var clubs = new[] { "" }.Concat(clubChoices.Select(c => c.Id)).ToArray();
        var clubNames = new[] { "无俱乐部" }.Concat(clubChoices.Select(c => c.Country + " / " + c.Name)).ToArray();
        var club = Choice(identity, "所属俱乐部", clubNames, Array.IndexOf(clubs, draft.ClubId), n => draft.ClubId = clubs[n], "CardClub"); club.Disabled = clubLock != null;
        identity.AddChild(Text(clubLock ?? "已报名的赛事沿用原阵容。自建俱乐部通过签约招募。", 15, _muted));
        Choice(identity, "关注俱乐部", new[] { "无固定支持" }.Concat(clubNames.Skip(1)).ToArray(), Array.IndexOf(clubs, draft.SupportedClubId), n => draft.SupportedClubId = clubs[n]);
        Memo(identity, "人物简介", draft.Biography, v => draft.Biography = v, "CardBiography");

        var ability = Section("职业与水平");
        var presetRow = new HBoxContainer(); presetRow.AddThemeConstantOverride("separation", 18); ability.AddChild(presetRow);
        var preset = Choice(presetRow, "能力预设", CharacterCards.Templates, Array.IndexOf(CharacterCards.Templates, draft.AbilityTemplate.Length > 0 ? draft.AbilityTemplate : draft.Role), _ => { }, "CardPreset");
        var abilityFields = Pair(ability);
        var role = Line(abilityFields, "职业 · 可自定义", draft.Role, v => draft.Role = v, 40, "CardRole");
        var characterNames = CharacterIdentity.Source().Select(c => c.DisplayName).Concat(new[] { "铁甲战士", "静默猎手", "故障机器人", "亡灵契约师", "储君", draft.Character }).Where(s => s.Length > 0).Distinct().ToArray();
        void SetCharacter(string value) { draft.Character = value; if (draft.Avatar.Source == "auto") portrait.Art = AutomaticPortrait(); }
        var character = Line(abilityFields, "擅长角色", draft.Character, SetCharacter, 120, "CardCharacter");
        Choice(ability, "选择已安装的角色", characterNames, Array.IndexOf(characterNames, draft.Character), n => { character.Text = characterNames[n]; SetCharacter(character.Text); });
        var numbers = Pair(ability);
        var ascension = Number(numbers, "最高通关进阶", draft.MaxAscension, 0, 10, v => draft.MaxAscension = (int)v, "CardAscension");
        var rating = Number(numbers, "评分", draft.Rating, 0, 100000, v => draft.Rating = (int)v, "CardRating");
        var wins = Number(numbers, "累计胜场", draft.Wins, 0, 1000000, v => draft.Wins = (int)v, "CardWins");
        var losses = Number(numbers, "累计负场", draft.Losses, 0, 1000000, v => draft.Losses = (int)v, "CardLosses");
        var probability = Pair(ability);
        SpinBox rate = null!;
        var mode = Choice(probability, "模拟通关率", ["现有算法", "自定义"], draft.CustomClearChance.HasValue ? 1 : 0, n =>
        { draft.CustomClearChance = n == 0 ? null : rate.Value / 100; rate.Editable = n == 1; }, "CardChanceMode");
        rate = Number(probability, "基础通关率 %", (draft.CustomClearChance ?? MatchRules.BaseChance(draft, draft.MaxAscension)) * 100, 0, 100,
            v => { if (mode.Selected == 1) draft.CustomClearChance = v / 100; }, "CardChance", .1);
        rate.Editable = draft.CustomClearChance.HasValue;
        ability.AddChild(Text("胜率为通过的最高进阶胜率，更高或更低进阶将动态调整", 15, _muted));
        var apply = Button("应用预设", () =>
        {
            CharacterCards.ApplyTemplate(draft, CharacterCards.Templates[preset.Selected]); role.Text = draft.Role;
            ascension.Value = draft.MaxAscension; rating.Value = draft.Rating; wins.Value = draft.Wins; losses.Value = draft.Losses;
            mode.Select(0); rate.Editable = false; rate.Value = MatchRules.BaseChance(draft, draft.MaxAscension) * 100;
        }, 160); apply.SizeFlagsVertical = SizeFlags.ShrinkEnd; presetRow.AddChild(apply);
        ability.AddChild(Text("培养加成另计。累计胜负仅修改档案；真人对局由实际战斗决定。", 15, _muted));

        var personality = Section("打法与性格");
        Memo(personality, "打法偏好", draft.Style, v => draft.Style = v, "CardStyle");
        var kind = Line(personality, "性格", draft.Personality.Kind, v => draft.Personality.Kind = v, 80, "CardPersonality");
        var attitudeFields = Pair(personality);
        var attitudeMin = Number(attitudeFields, "态度下界", draft.Personality.AttitudeMin, -5, -1, v => draft.Personality.AttitudeMin = (int)v, "CardAttitudeMin");
        var attitudeMax = Number(attitudeFields, "态度上界", draft.Personality.AttitudeMax, 1, 5, v => draft.Personality.AttitudeMax = (int)v, "CardAttitudeMax");
        personality.AddChild(Text("-5 偏向嘲讽、挑衅，+5 偏向维护、吹捧。性格决定表达方式。", 15, _muted));
        Memo(personality, "性格概述", draft.Temperament, v => draft.Temperament = v);
        var social = Memo(personality, "说话动机", draft.Personality.Social, v => draft.Personality.Social = v);
        Choice(personality, "性格预设", new[] { "保留当前性格" }.Concat(PersonalityLibrary.Kinds).ToArray(), 0, n =>
        {
            if (n == 0) return; PersonalityLibrary.SelectKind(draft.Personality, PersonalityLibrary.Kinds[n - 1]);
            kind.Text = draft.Personality.Kind; attitudeMin.Value = draft.Personality.AttitudeMin; attitudeMax.Value = draft.Personality.AttitudeMax; social.Text = draft.Personality.Social;
        });
        Memo(personality, "表达习惯", draft.Voice, v => draft.Voice = v);
        Memo(personality, "判断依据", draft.Personality.Evidence, v => draft.Personality.Evidence = v);
        Memo(personality, "受挫反应", draft.Personality.Pressure, v => draft.Personality.Pressure = v);
        Memo(personality, "玩笑习惯", draft.Personality.Humor, v => draft.Personality.Humor = v);
        Memo(personality, "维护立场", draft.Personality.Loyalty, v => draft.Personality.Loyalty = v);
        Memo(personality, "关注与好奇", draft.Personality.Curiosity, v => draft.Personality.Curiosity = v);
        var status = Text("保存后应用于当前生涯。", 16, _muted); status.Name = "CardStatus"; root.AddChild(status);
        void OnCardMessage(string message, bool failure)
        { if (failure && IsInstanceValid(status)) { status.Text = message; status.Modulate = new Color("f08080"); } }
        if (_multiplayer != null)
        {
            var session = _multiplayer; session.Message += OnCardMessage;
            shade.TreeExiting += () => session.Message -= OnCardMessage;
        }
        var actions = new HBoxContainer(); actions.AddThemeConstantOverride("separation", 16); root.AddChild(actions);
        void CloseEditor()
        {
            if (!IsInstanceValid(shade) || shade.IsQueuedForDeletion()) return;
            shade.QueueFree(); _characterCardOverlay = null; _closeCharacterCard = null;
            foreach (var entry in focus) if (IsInstanceValid(entry.Control) && !entry.Control.IsQueuedForDeletion()) entry.Control.FocusMode = entry.Mode;
            if (IsInstanceValid(previousFocus) && previousFocus.IsInsideTree() && !previousFocus.IsQueuedForDeletion() && previousFocus.IsVisibleInTree()) previousFocus.GrabFocus();
        }
        _closeCharacterCard = CloseEditor;
        void ShowSavedCard()
        {
            CloseEditor();
            if (_tab == "选手档案" && _personId == edit.Target)
            {
                int position = _scroll.ScrollVertical; Render(); _ = RestoreScrollAsync(position, _renderVersion);
            }
            else OpenPerson(edit.Target);
        }
        actions.AddChild(Button(create ? "创建并保存" : "保存角色", () =>
        {
            foreach (var input in Controls(shade).OfType<SpinBox>()) input.Apply();
            GetViewport().GuiGetFocusOwner()?.ReleaseFocus();
            if (_multiplayer != null)
            {
                string payload;
                try { payload = CharacterCards.Encode(edit); }
                catch (Exception e) { status.Text = e.Message; status.Modulate = new Color("f08080"); return; }
                status.Text = "正在提交，保存成功后关闭。";
                _multiplayer.Send("character-card", text: payload, accepted: () =>
                { _multiplayer.Refresh(); ShowSavedCard(); });
                return;
            }
            if (CharacterCards.Save(ViewData, edit) is { } error) { status.Text = error; status.Modulate = new Color("f08080"); return; }
            ShowSavedCard();
        }, 210));
        actions.AddChild(Button("取消", CloseEditor, 150));
        actions.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill });
        var importButton = Button("导入 PNG", () => OpenFilePicker("导入角色卡", [".png"], path =>
        {
            try
            {
                var incoming = CharacterCardPng.ReadFile(ViewData, path, AvatarImages.FromCardPng);
                if (AvatarImages.Read(incoming.Avatar) == null) throw new InvalidDataException("角色卡头像无法解码。");
                CloseEditor(); OpenCharacterCard(ViewData, null, incoming);
            }
            catch (Exception e) { if (IsInstanceValid(status)) { status.Text = "导入失败：" + e.Message; status.Modulate = new Color("f08080"); } }
        }), 155);
        importButton.Name = "ImportCharacterPng"; importButton.Disabled = !CanEditCharacter(data, ""); actions.AddChild(importButton);
        var exportButton = Button("导出 PNG", async () =>
        {
            try
            {
                foreach (var input in Controls(shade).OfType<SpinBox>()) input.Apply();
                var avatar = draft.Avatar.Source == "auto" ? await AvatarImages.FromCharacterCardArt(this, AutomaticPortrait()) : draft.Avatar;
                if (!IsInstanceValid(status) || shade.IsQueuedForDeletion()) return;
                string path = CharacterCardPng.WriteDesktop(CharacterCardPng.Export(data, draft, avatar));
                status.Text = "角色卡已导出到桌面。分享时请发送原始 PNG 文件。"; status.Modulate = Colors.White;
                OS.ShellShowInFileManager(path);
            }
            catch (Exception e) { status.Text = "导出失败：" + e.Message; status.Modulate = new Color("f08080"); }
        }, 155);
        exportButton.Name = "ExportCharacterPng"; actions.AddChild(exportButton);
    }
}
