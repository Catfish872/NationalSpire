using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private bool _npcSetupOpening;
    internal static void SelectNpcGeneration(Control parent, AiOptions ai, Func<NpcGenerationSetup, Task> selected, Action? cancelled = null, string country = "中国")
    {
        var screen = new CareerScreen { Theme = CareerVisuals.CreateTheme() }; parent.AddChild(screen); screen.SetProcess(false); screen.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        screen._stage = LandscapeViewport.Mount(screen);
        bool complete = false;
        screen.OpenNpcGeneration(ai, _ => { }, selectedAsync: async plan => { await selected(plan); complete = true; }, team: true, country: country);
        screen._dialogOverlay!.TreeExiting += () => { if (!complete) cancelled?.Invoke(); if (!screen.IsQueuedForDeletion()) screen.QueueFree(); };
    }

    private void OpenNpcGeneration(AiOptions ai, Action<NpcGenerationSetup> selected, bool required = false,
        Func<NpcGenerationSetup, Task>? selectedAsync = null, int rivalLevel = 1000, bool team = false, string country = "中国")
    {
        var setup = new NpcGenerationSetup { TeamCountry = team ? country : null, Pool = PersonalityPools.Read(ai), Ai = Coop.CoopJson.Copy(ai), RivalLevel = rivalLevel };
        AiRouting.Ensure(setup.Ai);
        if (!setup.Ai.ConnectionProfiles.ContainsKey(AiRouting.Default)) setup.Ai.ConnectionProfiles[AiRouting.Default] = new() { Endpoint = setup.Ai.Endpoint, Model = setup.Ai.Model };
        Label status = null!; GridContainer weights = null!; VBoxContainer files = null!;
        Func<bool> commitConnection=()=>true;
        string openingProfile=AiRouting.Default;
        var sliders = new List<PercentageSlider>(); bool busy = false;
        string original = CareerStore.DefaultPath;
        var savedRoles = Task.Run(() => OpeningLibrary.SavedRoles(original));
        Task? fillRoles = null;
        async Task SubmitAsync()
        {
            busy = true; status.Text = team ? "正在建立共同生涯……" : "正在建立生涯……";
            var dialog = _dialogOverlay;
            try { if(fillRoles!=null)await fillRoles; await selectedAsync!(Coop.CoopJson.Copy(setup)); if (IsInstanceValid(this) && !IsQueuedForDeletion() && _dialogOverlay == dialog) _cancelDialog?.Invoke(); }
            catch (Exception e) { if (IsInstanceValid(status) && !status.IsQueuedForDeletion()) status.Text = "配置未应用：" + e.Message; }
            finally { busy = false; }
        }
        void Files()
        {
            CareerVisuals.ClearContent(files); files.Visible = setup.Files.Count > 0;
            foreach (var path in setup.Files.ToArray())
            {
                var row = new HBoxContainer(); files.AddChild(row);
                var name = Text(Path.GetFileName(path), 16, _ink); name.SizeFlagsHorizontal = SizeFlags.ExpandFill; name.AutowrapMode = TextServer.AutowrapMode.WordSmart; row.AddChild(name);
                row.AddChild(Button("移除", () => { if (busy) return; setup.Files.Remove(path); Files(); }, 90));
            }
        }
        void Weights()
        {
            CareerVisuals.ClearContent(weights); sliders.Clear();
            var categories = setup.Pool.Categories;
            var categoryValues = PercentageAllocation.Normalize(categories.Select(c => c.Weight));
            var categorySliders = new List<PercentageSlider>();
            var categoryLocks = new bool[categories.Count];
            bool updating = false;
            void AddSlider(HBoxContainer row, PercentageSlider slider, bool[] locks, int index)
            {
                var toggle = new PercentageLockButton { Name = slider.Name + "_Lock" };
                row.AddChild(toggle); row.AddChild(slider);
                toggle.Toggled += locked =>
                {
                    slider.Commit(); locks[index] = locked;
                    slider.Editable = !locked && locks.Length > 1;
                };
            }
            for (int i = 0; i < categories.Count; i++) categories[i].Weight = categoryValues[i];
            foreach (var category in categories)
            {
                int index = categories.IndexOf(category);
                var panel = new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill };
                panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("142734", "365565", 8, 14)); weights.AddChild(panel);
                var column = new VBoxContainer(); column.AddThemeConstantOverride("separation", 8); panel.AddChild(column);
                column.AddChild(Text(category.Name + " · " + category.Gender, 19, _gold));
                var parentSlider = new PercentageSlider { Name = "CategoryPercent_" + category.Id, Value = category.Weight, Editable = categories.Count > 1 };
                sliders.Add(parentSlider); categorySliders.Add(parentSlider);
                var parentRow = new HBoxContainer(); parentRow.AddThemeConstantOverride("separation", 6); column.AddChild(parentRow);
                AddSlider(parentRow, parentSlider, categoryLocks, index);
                parentSlider.ValueChanged += value =>
                {
                    if (updating) return; updating = true;
                    var adjusted = PercentageAllocation.Adjust(categories.Select(c => c.Weight).ToArray(), index, value, categoryLocks);
                    for (int j = 0; j < categories.Count; j++) { categories[j].Weight = adjusted[j]; categorySliders[j].SetValueNoSignal(adjusted[j]); categorySliders[j].Refresh(); }
                    updating = false;
                };
                column.AddChild(new HSeparator());
                column.AddChild(Text("类别内性格 · 合计 100%", 15, _muted));
                var styles = category.Styles; var values = PercentageAllocation.Normalize(styles.Select(s => s.Weight)); var children = new List<PercentageSlider>();
                var childLocks = new bool[styles.Count];
                for (int j = 0; j < styles.Count; j++) styles[j].Weight = values[j];
                foreach (var style in styles)
                {
                    int childIndex = styles.IndexOf(style);
                    var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 10); column.AddChild(row);
                    var name = Text(style.Name, 17, _ink); name.CustomMinimumSize = new(76, 0); name.SizeFlagsHorizontal = SizeFlags.Fill;
                    name.AutowrapMode = TextServer.AutowrapMode.WordSmart; row.AddChild(name);
                    var slider = new PercentageSlider { Name = "StylePercent_" + category.Id + "_" + style.Id, Value = style.Weight, Editable = styles.Count > 1 };
                    sliders.Add(slider); children.Add(slider); AddSlider(row, slider, childLocks, childIndex);
                    slider.ValueChanged += value =>
                    {
                        if (updating) return; updating = true;
                        var adjusted = PercentageAllocation.Adjust(styles.Select(s => s.Weight).ToArray(), childIndex, value, childLocks);
                        for (int k = 0; k < styles.Count; k++) { styles[k].Weight = adjusted[k]; children[k].SetValueNoSignal(adjusted[k]); children[k].Refresh(); }
                        updating = false;
                    };
                }
            }
        }
        ShowCareerDialog("配置新世界", "", () =>
        {
            if (busy) return false;
            try
            {
                foreach (var slider in sliders) slider.Commit();
                PersonalityPools.Validate(setup.Pool);
                if(!commitConnection()) return false;
                if (selectedAsync != null) { _ = SubmitAsync(); return false; }
                selected(setup); return true;
            }
            catch (Exception e) { status.Text = "配置未应用：" + e.Message; return false; }
        }, "生成并开始", box =>
        {
            box.CustomMinimumSize = new(1040, 0); box.AddThemeConstantOverride("separation", 16);
            var scroll = new BroadcastScroll { Name = "NewWorldScroll", CustomMinimumSize = new(0, 634), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);
            var content = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; content.AddThemeConstantOverride("separation", 12); scroll.AddChild(content);
            var aiSection=OpeningControls.Section(content,"AI 连接方案","settings-2","保存连接 · 按任务选择模型");
            var aiEditor=new VBoxContainer();aiSection.AddChild(aiEditor);
            var confirmRow=new HBoxContainer{Visible=false};aiSection.AddChild(confirmRow);confirmRow.AddChild(Text("当前连接尚未保存，是否切换？",16,_gold));
            Action? switchTo=null;confirmRow.AddChild(Button("继续编辑",()=>confirmRow.Hide(),118));confirmRow.AddChild(Button("确认切换",()=>{confirmRow.Hide();switchTo?.Invoke();},118));
            void Connections(){
                CareerVisuals.ClearContent(aiEditor);
                AiSettingsPanel.BuildConnections(aiEditor,setup.Ai!,()=>AiSettingsStore.Save(Coop.CoopJson.Copy(setup.Ai!)),()=>{},null,
                    (message,error)=>{if(IsInstanceValid(status)){status.Text=message;status.Modulate=error?new Color("efa9a4"):Colors.White;}},null,"保存方案",
                    action=>{switchTo=action;confirmRow.Show();},commit=>commitConnection=commit,openingProfile,id=>openingProfile=id);
            }
            Connections();
            var styleSection=OpeningControls.Section(content,"世界设定","flag","提示词模板 · 对手水平",accent:CareerVisuals.Teal);
            var level = AiSettingsPanel.RivalLevelPicker(setup.RivalLevel, team); level.CustomMinimumSize = new(0, 44);
            level.ItemSelected += i => setup.RivalLevel = level.GetItemId((int)i); OpeningControls.Field(styleSection,"对手比赛水平").AddChild(level);
            var templates = PromptLibrary.AvailableTemplates(setup.Ai).ToArray();
            var worlds = new OptionButton { Name = "WorldPromptTemplate", FitToLongestItem = false, CustomMinimumSize = new(0, 44), SizeFlagsHorizontal = SizeFlags.ExpandFill };
            void RefreshWorlds()
            {
                templates = PromptLibrary.AvailableTemplates(setup.Ai).ToArray(); worlds.Clear();
                foreach (var template in templates) worlds.AddItem(template.Name);
                worlds.AddSeparator(); worlds.AddItem("导入提示词…");
                worlds.Select(Array.FindIndex(templates, t => t.Id == PromptLibrary.TemplateId(setup.Ai)));
            }
            RefreshWorlds();
            worlds.ItemSelected += i =>
            {
                if (busy) { RefreshWorlds(); return; }
                if (i < templates.Length) { PromptLibrary.SelectTemplate(setup.Ai, templates[(int)i].Id); setup.Pool = PersonalityPools.Read(setup.Ai); Weights(); return; }
                RefreshWorlds();
                PickNestedFile("选择提示词 JSON", [".json"], path =>
                {
                    try
                    {
                        var imported = Coop.CoopJson.Copy(setup.Ai);
                        var bundle = PromptTransfer.Read(File.ReadAllText(path));
                        PromptTransfer.Apply(imported, bundle);
                        setup.Ai = imported; Connections();
                        setup.Pool = PersonalityPools.Read(imported); Weights();
                        RefreshWorlds(); status.Text = "提示词已载入：" + worlds.GetItemText(worlds.Selected)
                            + (bundle.PersonalityPool != null ? "，性格池与人物比例已同步。" : "。") + "生成新世界时应用。";
                    }
                    catch (Exception e) { status.Text = "提示词导入失败：" + e.Message; }
                });
            };
            OpeningControls.Field(styleSection,"世界观与提示词模板").AddChild(worlds);
            var presets=OpeningControls.Section(content,"开局模板","shuffle","选择起点后仍可编辑",true);
            var presetRow=new HBoxContainer();presetRow.AddThemeConstantOverride("separation",10);presets.AddChild(presetRow);var presetGroup=new ButtonGroup();
            var draftPanel=new VBoxContainer(); content.AddChild(draftPanel);
            void DrawDraft()
            {
                CareerVisuals.ClearContent(draftPanel);
                Action<string>? updateRegion=null;
                OpeningPlayerEditor.Draw(draftPanel,setup.Personal,setup.PlayerName,setup.TeamCountry??country,setup.TeamCountry,n=>{if(setup.TeamCountry==null)updateRegion?.Invoke(n);});
                updateRegion=OpeningWorldEditor.Draw(draftPanel,setup.World,setup.TeamCountry??(setup.Personal.Country.Length>0?setup.Personal.Country:country));
            }
            foreach(var (title,detail,icon) in new[]{("新秀起步","自由选手 · 从零开始","flag"),("职业选手","12 胜 4 负 · $50,000","swords"),("俱乐部创办人","自建俱乐部 · $500,000","landmark")})
            {
                OpeningControls.Card(presetRow,title,detail,icon,title=="新秀起步",()=>{
                    if(busy)return;
                    setup.Personal=new();setup.World=new();
                    if(title=="职业选手"){setup.Personal.Wins=12;setup.Personal.Losses=4;setup.Personal.Credits=50000;setup.World.ClubMode="加盟";}
                    if(title=="俱乐部创办人"){setup.Personal.Credits=500000;setup.World.ClubMode="自建";}
                    DrawDraft();
                },presetGroup);
            }
            DrawDraft();
            var guide=new TextEdit{PlaceholderText="描述想加入的世界、所在赛季和选手经历……",CustomMinimumSize=new(0,74),WrapMode=TextEdit.LineWrappingMode.Boundary};
            var generation=OpeningControls.Section(content,"用 AI 填写开局","pencil","描述你的故事，可重复生成",accent:CareerVisuals.Teal); content.MoveChild(generation.GetParent().GetParent(),1); generation.AddChild(guide);
            var lifetime=new CancellationTokenSource(); guide.TreeExiting+=()=>lifetime.Cancel();
            generation.AddChild(Button("根据描述填写",async ()=>{
                if(busy || string.IsNullOrWhiteSpace(guide.Text))return;
                busy=true;
                try
                {
                    if(!commitConnection())return;status.Text="正在生成开局草案……";
                    var result=Coop.CoopJson.Copy(setup);
                    await OpeningGeneration.Generate(result,guide.Text,lifetime.Token,openingProfile);
                    if(!IsInstanceValid(guide)||lifetime.IsCancellationRequested)return;
                    setup.WorldId=result.WorldId;setup.TeamCountry=result.TeamCountry;setup.Personal=result.Personal;setup.World=result.World;setup.Pool=result.Pool;setup.RivalLevel=result.RivalLevel;
                    PromptLibrary.SelectTemplate(setup.Ai,PromptLibrary.TemplateId(result.Ai!));
                    presetGroup.GetPressedButton()?.SetPressedNoSignal(false);DrawDraft();Weights();RefreshWorlds();level.Select(level.GetItemIndex(setup.RivalLevel));
                    status.Text="开局草案已填入，可以编辑或修改描述再次生成。";
                }
                catch(Exception e){if(IsInstanceValid(status)&&!lifetime.IsCancellationRequested)status.Text=e.Message;}
                finally{busy=false;}
            },160));
            var peopleRow = new HBoxContainer(); peopleRow.AddThemeConstantOverride("separation", 24); var rolesSection=OpeningControls.Section(content,"人物与素材","users-round","角色卡 · 形象包");rolesSection.AddChild(peopleRow);
            var peopleColumn = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; peopleColumn.AddThemeConstantOverride("separation", 12); peopleRow.AddChild(peopleColumn);

            var toolbar = new HBoxContainer(); toolbar.AddThemeConstantOverride("separation", 12); peopleColumn.AddChild(toolbar);
            toolbar.AddChild(Button("批量导入角色", () => { if (busy) return; PickNestedFile("选择角色卡或角色设计包", [".png", ".zip"], _ => { }, paths =>
            {
                foreach (var path in paths) if (!setup.Files.Contains(path, StringComparer.OrdinalIgnoreCase)) setup.Files.Add(path);
                Files(); status.Text = "已选 " + setup.Files.Count + " 个角色文件；确认后统一校验并导入。";
            }); }, 180));

            var reuse=new VBoxContainer{Visible=false}; var selectSaved=new CareerDisclosureButton{Text="沿用已导入的角色与形象包",ArrowOnLeft=true,ToggleMode=true};rolesSection.AddChild(selectSaved);rolesSection.AddChild(reuse);
            selectSaved.Toggled+=show=>reuse.Visible=show;
            foreach(var entry in AppearanceLibrary.List().Where(e=>!e.BuiltIn))
            {
                var check=new CheckBox{Text=entry.Name+"  ·  形象包",ButtonPressed=true};reuse.AddChild(check);
                check.Toggled+=on=>{if(on)setup.ExcludedPacks.Remove(entry.Id);else setup.ExcludedPacks.Add(entry.Id);};
            }
            async Task FillRoles()
            {
                try
                {
                    var roles=await savedRoles;
                    if(!IsInstanceValid(reuse)||reuse.IsQueuedForDeletion())return;
                    setup.SavedRoles=roles.ToList();
                    foreach(var role in roles)
                    {
                        var check=new CheckBox{Text=role.Name+"  ·  角色卡",TooltipText=role.Career,ButtonPressed=true};reuse.AddChild(check);
                        check.Toggled+=on=>{if(on)setup.SavedRoles.Add(role);else setup.SavedRoles.Remove(role);};
                    }
                    selectSaved.Text=$"沿用已导入的角色与形象包  ·  {reuse.GetChildCount()} 项";
                    selectSaved.Disabled=reuse.GetChildCount()==0;
                }
                catch(Exception e){if(IsInstanceValid(selectSaved))selectSaved.Text="读取已有角色卡失败  ·  "+e.Message;}
            }
            fillRoles=FillRoles();
            files = new VBoxContainer(); rolesSection.AddChild(files); Files();
            var proportions=OpeningControls.Section(content,"人物比例","users-round","类别 · 说话风格");
            proportions.Name="WorldProportions";
            var allocationHint = Text("各大类、每类内部各合计 100%。点击锁固定比例；其余未锁定项均摊差额，调整上限为剩余额度。", 16, _muted);
            allocationHint.AutowrapMode = TextServer.AutowrapMode.WordSmart; proportions.AddChild(allocationHint);
            weights = new GridContainer { Columns = 2, SizeFlagsHorizontal = SizeFlags.ExpandFill }; weights.AddThemeConstantOverride("h_separation", 16); weights.AddThemeConstantOverride("v_separation", 16);
            proportions.AddChild(weights); Weights();
            status = Text("已沿用现有世界设定；导入角色保留自己的设定，随机人物按类别与性格比例生成。", 15, _muted); status.AutowrapMode = TextServer.AutowrapMode.WordSmart; box.AddChild(status);
        }, showCancel: !required);
        if (required) _returnDialog = () => { };
    }

    private void BeginNpcSetup(bool reset)
    {
        _cancelDialog?.Invoke();
        OpenNpcGeneration(ViewData.Ai, _ => {}, selectedAsync: async plan =>
        {
            var fresh = NpcGeneration.Create(ViewData.Ai, plan);
            fresh.ExternalSave = _=>{};
            await plan.World.Prepare(fresh, async () => { await ToSignal(GetTree(), SceneTree.SignalName.ProcessFrame); });
            plan.Personal.Apply(fresh);
            using var imported = new NpcGeneration.ImportBatch(fresh, plan);
            await OpeningClubEditor.Choose(this,fresh,plan.World);
            fresh.ExternalSave = null;
            if (reset) _boundData = CareerStore.ReplaceFreshCareer(fresh);
            else
            {
                var path = CareerLibrary.Create(CareerStore.DefaultPath, fresh); imported.Commit(); _boundData = CareerStore.SwitchCareer(path);
                _boundData.Ai = fresh.Ai; CareerStore.Save(_boundData);
            }
            imported.Commit(); _npcSetupOpening = false; _confirmReset = false; ResetNavigation();
            Callable.From(Render).CallDeferred();
        }, required: ViewData.NpcSetupPending, rivalLevel: ViewData.RivalLevel);
    }
}
