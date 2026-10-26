using Godot;
using System.Text.Json;

namespace NationalSpire;

public partial class CareerScreen
{
    // 编辑草稿与已应用的人物快照分离；与事件池共用设置入口及保存方式。
    private void OpenPersonalityPool(CareerData data, PersonalityPool? initial = null, Action<PersonalityPool>? accepted = null)
    {
        var draft = initial == null ? PersonalityPools.Read(data.Ai) : Coop.CoopJson.Copy(initial);
        int categoryIndex = 0, styleIndex = 0; bool loading = false;
        Label status = null!; VBoxContainer fields = null!;
        void Rebuild()
        {
            loading = true; CareerVisuals.ClearContent(fields);
            categoryIndex = Math.Clamp(categoryIndex, 0, draft.Categories.Count - 1);
            var c = draft.Categories[categoryIndex]; styleIndex = Math.Clamp(styleIndex, 0, c.Styles.Count - 1);
            OptionButton Options(Node parent, string name, IEnumerable<string> choices, int value, Action<int> changed)
            {
                var option = new OptionButton { Name = name, CustomMinimumSize = new(200, 44), SizeFlagsHorizontal = SizeFlags.ExpandFill, FitToLongestItem = false };
                foreach (var choice in choices) option.AddItem(choice); option.Select(value); parent.AddChild(option);
                option.ItemSelected += n => { if (!loading) changed((int)n); }; return option;
            }
            void Line(string label, string value, Action<string> changed, string name)
            {
                var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); fields.AddChild(row);
                var caption = Text(label, 17, _muted); caption.CustomMinimumSize = new(130, 0); row.AddChild(caption);
                var edit = new LineEdit { Name = name, Text = value, CustomMinimumSize = new(0, 42), SizeFlagsHorizontal = SizeFlags.ExpandFill }; row.AddChild(edit);
                edit.TextChanged += s => { if (!loading) changed(s); };
            }
            void Memo(string label, string value, Action<string> changed, string name)
            {
                fields.AddChild(Text(label, 17, _muted));
                var edit = new TextEdit { Name = name, Text = value, CustomMinimumSize = new(0, 105), WrapMode = TextEdit.LineWrappingMode.Boundary };
                edit.AddThemeFontSizeOverride("font_size", 18); fields.AddChild(edit); edit.TextChanged += () => { if (!loading) changed(edit.Text); };
            }
            void Weight(string label, double value, Action<double> changed)
            {
                var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); fields.AddChild(row); row.AddChild(Text(label, 17, _muted));
                var number = new SpinBox { MinValue = 0, MaxValue = 1000000, Step = .1, Value = value, CustomMinimumSize = new(160, 42) }; row.AddChild(number);
                number.ValueChanged += n => { if (!loading) changed(n); };
            }
            var categories = new HBoxContainer(); categories.AddThemeConstantOverride("separation", 12); fields.AddChild(categories);
            Options(categories, "PersonalityCategory", draft.Categories.Select(x => x.Name), categoryIndex, n => { categoryIndex = n; styleIndex = 0; Rebuild(); });
            categories.AddChild(Button("新增类别", () => { draft.Categories.Add(new() { Styles = [new()] }); categoryIndex = draft.Categories.Count - 1; styleIndex = 0; Rebuild(); }, 130));
            var deleteCategory = Button("删除类别", () => { draft.Categories.RemoveAt(categoryIndex); Rebuild(); }, 130); deleteCategory.Disabled = draft.Categories.Count == 1; categories.AddChild(deleteCategory);
            Line("类别名称", c.Name, s => c.Name = s, "PersonalityCategoryName");
            Line("类别 ID", c.Id, s => c.Id = s, "PersonalityCategoryId");
            var gender = new HBoxContainer(); gender.AddThemeConstantOverride("separation", 12); fields.AddChild(gender); gender.AddChild(Text("适用性别", 17, _muted));
            Options(gender, "PersonalityCategoryGender", PersonalityPools.Genders.Select(g => g == PersonalityPools.NeutralGender ? "中性（男女均可）" : g),
                Array.IndexOf(PersonalityPools.Genders, c.Gender), n => c.Gender = PersonalityPools.Genders[n]);
            Weight("类别生成权重", c.Weight, v => c.Weight = v);
            Memo("类别共同提示词", c.Prompt, s => c.Prompt = s, "PersonalityCategoryPrompt");
            fields.AddChild(new HSeparator());
            var styles = new HBoxContainer(); styles.AddThemeConstantOverride("separation", 12); fields.AddChild(styles);
            Options(styles, "PersonalityStyle", c.Styles.Select(s => s.Name), styleIndex, n => { styleIndex = n; Rebuild(); });
            styles.AddChild(Button("新增性格", () => { c.Styles.Add(new()); styleIndex = c.Styles.Count - 1; Rebuild(); }, 130));
            var deleteStyle = Button("删除性格", () => { c.Styles.RemoveAt(styleIndex); Rebuild(); }, 130); deleteStyle.Disabled = c.Styles.Count == 1; styles.AddChild(deleteStyle);
            var s = c.Styles[styleIndex];
            Line("性格名称", s.Name, v => s.Name = v, "PersonalityStyleName"); Line("性格 ID", s.Id, v => s.Id = v, "PersonalityStyleId");
            Weight("类别内生成权重", s.Weight, v => s.Weight = v);
            Memo("具体性格提示词", s.Prompt, v => s.Prompt = v, "PersonalityStylePrompt");
            loading = false;
        }
        void Replace(PersonalityPool pool) { draft = pool; categoryIndex = styleIndex = 0; Rebuild(); status.Text = "已加载到编辑草稿，保存后应用。"; }
        ShowCareerDialog("性格池", "类别可指定男性、女性或中性（男女均可）。人物同时使用类别与具体性格两份提示词；已保存的人物保留自己的版本。", () =>
        {
            try
            {
                PersonalityPools.Validate(draft);
                if (accepted != null) { accepted(Coop.CoopJson.Copy(draft)); return true; }
                var old = data.Ai.PersonalityPool; data.Ai.PersonalityPool = Coop.CoopJson.Copy(draft);
                try { SaveAiSettings(data); } catch { data.Ai.PersonalityPool = old; throw; }
                return true;
            }
            catch (Exception e) { status.Text = e.Message; return false; }
        }, "保存性格池", box =>
        {
            box.CustomMinimumSize = new(880, 0);
            var toolbar = new HBoxContainer(); toolbar.AddThemeConstantOverride("separation", 12); box.AddChild(toolbar);
            toolbar.AddChild(Button("导入 JSON", () => PickNestedFile("导入性格池", [".json"], path =>
            { try { Replace(PersonalityPools.Import(File.ReadAllText(path))); } catch (Exception e) { status.Text = e.Message; } }), 150));
            toolbar.AddChild(Button("导出 JSON", () =>
            {
                try { var path = Path.Combine(PromptTransfer.Desktop, "国运尖塔-性格池-" + DateTime.Now.ToString("yyyyMMdd-HHmmssfff") + ".json"); File.WriteAllText(path, PersonalityPools.Export(draft)); OS.ShellShowInFileManager(path); status.Text = "性格池已导出到桌面。"; }
                catch (Exception e) { status.Text = e.Message; }
            }, 150));
            toolbar.AddChild(Button("批量分类编辑", () =>
            {
                var parent = _dialogOverlay; var cancel = _cancelDialog; var returnDialog = _returnDialog; parent!.Hide(); _dialogOverlay = null; _cancelDialog = null;
                TextEdit bulk = null!; Label error = null!;
                ShowCareerDialog("批量分类编辑", "编辑完整的两级性格池 JSON，支持整批复制、添加和修改类别及性格。weight 为相对生成权重，0 表示暂停生成。", () =>
                { try { Replace(PersonalityPools.Import(bulk.Text)); return true; } catch (Exception e) { error.Text = e.Message; return false; } }, "应用到草稿", content =>
                {
                    content.CustomMinimumSize = new(880, 0); bulk = new TextEdit { Name = "PersonalityPoolBulk", Text = JsonSerializer.Serialize(draft, PersonalityPools.Json), CustomMinimumSize = new(0, 460) }; content.AddChild(bulk);
                    error = Text("", 16, _muted); content.AddChild(error);
                });
                _dialogOverlay!.TreeExiting += () => Callable.From(() => { if (IsInstanceValid(parent) && !parent.IsQueuedForDeletion()) { _dialogOverlay = parent; _cancelDialog = cancel; _returnDialog = returnDialog; parent.Show(); } }).CallDeferred();
            }, 180));
            var scroll = new BroadcastScroll { CustomMinimumSize = new(0, 460), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);
            fields = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; fields.AddThemeConstantOverride("separation", 10); scroll.AddChild(fields);
            status = Text("新建生涯时可调整两级生成比例。", 16, _muted); box.AddChild(status); Rebuild();
        });
    }
}
