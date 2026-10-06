using Godot;
using System.Text.Json;

namespace NationalSpire;

public partial class CareerScreen
{
    private Control? _avatarOverlay;
    private Action? _closeAvatar;
    private void OpenAvatarSettings(CareerData data, PlayerAvatar? initial = null, Action<PlayerAvatar>? choose = null, string personId = "player", AvatarArt? automatic = null)
    {
        if (_avatarOverlay != null) return;
        var previousFocus = GetViewport().GuiGetFocusOwner();
        IEnumerable<Control> Controls(Node node) => node.GetChildren().SelectMany(child =>
            (child is Control control ? new[] { control } : Array.Empty<Control>()).Concat(Controls(child)));
        var focus = Controls(_stage).Where(c => c.FocusMode != FocusModeEnum.None).Select(c => (Control: c, Mode: c.FocusMode)).ToList();
        foreach (var entry in focus) entry.Control.FocusMode = FocusModeEnum.None;
        var selected = initial ?? data.SelectedAvatar; int selectionRevision = 0;
        string category = "character"; int page = 0; const int pageSize = 12;
        IReadOnlyList<AvatarChoice> characters = AvatarSources.Characters();
        IReadOnlyList<AvatarChoice>? cards = null;
        var shade = new ColorRect { Name = "AvatarEditor", Color = new(0, 0, 0, .82f), MouseFilter = MouseFilterEnum.Stop, ZIndex = 20 };
        _avatarOverlay = shade; _stage.AddChild(shade); shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        var margin = new MarginContainer(); shade.AddChild(margin); margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        foreach (string edge in new[] { "left", "right" }) margin.AddThemeConstantOverride("margin_" + edge, 100);
        foreach (string edge in new[] { "top", "bottom" }) margin.AddThemeConstantOverride("margin_" + edge, 55);
        var panel = Card(); margin.AddChild(panel); var box = Inner(panel); box.AddThemeConstantOverride("separation", 14);
        box.AddChild(Text("选择头像", 28, _gold));
        box.AddChild(Text("用于当前生涯的档案、社区和队伍展示。头像框与进阶角标照常保留。", 17, _muted));
        var previewRow = new HBoxContainer(); previewRow.AddThemeConstantOverride("separation", 20); box.AddChild(previewRow);
        var preview = new CareerAvatar { Name = "AvatarPreview", CustomMinimumSize = new(104, 104), Identity = AvatarHonors.ForPerson(data, personId) };
        previewRow.AddChild(preview);
        var details = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; previewRow.AddChild(details);
        var description = Text("", 23, _gold); details.AddChild(description);
        var status = Text("图片会居中裁剪成正方形。确认保存后生效，原图片移动或删除不影响头像。", 17, _muted); details.AddChild(status);
        void Select(PlayerAvatar avatar)
        {
            selectionRevision++;
            selected = avatar;
            preview.Art = AvatarImages.Read(avatar) ?? automatic ?? CareerAvatars.Automatic(data, personId);
            description.Text = avatar.Label;
        }
        Select(selected);
        var sources = new HBoxContainer(); sources.AddThemeConstantOverride("separation", 12); box.AddChild(sources);
        var search = new LineEdit { Name = "AvatarSearch", PlaceholderText = "搜索头像或卡牌名称", CustomMinimumSize = new(0, 46) };
        var scroll = new BroadcastScroll { SizeFlagsVertical = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 290), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled };
        var grid = new GridContainer { Name = "AvatarGallery", Columns = 3, SizeFlagsHorizontal = SizeFlags.ExpandFill };
        grid.AddThemeConstantOverride("h_separation", 16); grid.AddThemeConstantOverride("v_separation", 12); scroll.AddChild(grid);
        var paging = new HBoxContainer(); paging.AddThemeConstantOverride("separation", 16);
        Label pages = Text("", 16, _muted); Button previous = null!, next = null!;
        void Gallery()
        {
            CareerVisuals.ClearContent(grid);
            var choices = (category == "character" ? characters : cards ??= AvatarSources.Cards())
                .Where(c => c.Name.Contains(search.Text.Trim(), StringComparison.OrdinalIgnoreCase)).ToList();
            int totalPages = Math.Max(1, (choices.Count + pageSize - 1) / pageSize); page = Math.Clamp(page, 0, totalPages - 1);
            foreach (var choice in choices.Skip(page * pageSize).Take(pageSize))
            {
                AvatarArt? art = null; try { art = choice.Read(); } catch { }
                var item = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 78) }; item.AddThemeConstantOverride("separation", 10); grid.AddChild(item);
                item.AddChild(new CareerAvatar { Art = art ?? new(null, CareerVisuals.Teal, choice.Name), CustomMinimumSize = new(70, 70), SizeFlagsVertical = SizeFlags.ShrinkCenter });
                var choose = Button(choice.Name, () =>
                {
                    try { Select(AvatarImages.FromArt(art!, category)); status.Text = "已预览，点击保存头像后生效。"; }
                    catch (Exception e) { status.Text = e.Message; }
                }, 0);
                choose.AutowrapMode = TextServer.AutowrapMode.WordSmart; choose.SizeFlagsHorizontal = SizeFlags.ExpandFill; choose.Disabled = !AvatarAssets.Usable(art?.Texture); item.AddChild(choose);
            }
            pages.Text = choices.Count == 0 ? "没有找到匹配的图片" : $"{page + 1} / {totalPages} · 共 {choices.Count} 张";
            previous.Disabled = page == 0; next.Disabled = page + 1 >= totalPages; scroll.ScrollVertical = 0;
        }
        sources.AddChild(Button("自动头像", () => { Select(new()); status.Text = "恢复跟随角色的自动头像。"; }, 170));
        sources.AddChild(Button("游戏头像", () => { category = "character"; search.Text = ""; page = 0; Gallery(); }, 170));
        sources.AddChild(Button("游戏卡图", () => { category = "card"; search.Text = ""; page = 0; Gallery(); }, 170));
        var steam = Button("Steam 头像", () => { }, 180); sources.AddChild(steam);
        steam.Pressed += async () =>
        {
            int requestedRevision = selectionRevision;
            steam.Disabled = true; status.Text = "正在读取你的 Steam 头像……";
            try
            {
                var avatar = await AvatarSources.Steam();
                if (!IsInstanceValid(shade) || shade.IsQueuedForDeletion() || requestedRevision != selectionRevision) return;
                Select(avatar); status.Text = "已读取当前 Steam 头像，确认保存后生效。";
            }
            catch (Exception e) { if (IsInstanceValid(status) && requestedRevision == selectionRevision) status.Text = e is ArgumentException ? e.Message : "暂时无法读取 Steam 头像，请确认 Steam 已登录后重试。"; }
            finally { if (IsInstanceValid(steam)) steam.Disabled = false; }
        };
        sources.AddChild(Button("选择本地图片", () => OpenFilePicker("选择头像图片", [".png", ".jpg", ".jpeg", ".webp"], path =>
        {
            try { Select(AvatarImages.FromFile(path)); status.Text = "已预览本地图片，确认保存后生效。"; }
            catch (Exception e) { status.Text = e is ArgumentException ? e.Message : "无法读取这张图片，请重新选择。"; }
        }), 200));
        box.AddChild(search); box.AddChild(scroll); box.AddChild(paging);
        previous = Button("上一页", () => { page--; Gallery(); }, 140); paging.AddChild(previous); paging.AddChild(pages);
        next = Button("下一页", () => { page++; Gallery(); }, 140); paging.AddChild(next);
        search.TextChanged += _ => { page = 0; Gallery(); };
        void CloseAvatar()
        {
            _avatarOverlay = null; _closeAvatar = null; shade.Hide(); _stage.RemoveChild(shade); shade.QueueFree();
            foreach (var entry in focus)
                if (IsInstanceValid(entry.Control) && !entry.Control.IsQueuedForDeletion()) entry.Control.FocusMode = entry.Mode;
            if (IsInstanceValid(previousFocus) && previousFocus.IsInsideTree() && !previousFocus.IsQueuedForDeletion() && previousFocus.IsVisibleInTree()) previousFocus.GrabFocus();
        }
        _closeAvatar = CloseAvatar;
        var actions = new HBoxContainer(); actions.AddThemeConstantOverride("separation", 16); box.AddChild(actions);
        actions.AddChild(Button(choose == null ? "保存头像" : "使用此头像", () =>
        {
            if (choose != null) { selected.Validate(); choose(selected); CloseAvatar(); return; }
            ShowCareerDialog("保存头像", "使用当前预览作为本生涯头像？多人模式下，队友也会看到这张头像。", () =>
            {
                if (MultiplayerCommand("avatar", text: JsonSerializer.Serialize(selected, new JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping }))) { CloseAvatar(); return true; }
                var old = data.SelectedAvatar;
                try { selected.Validate(); data.SelectedAvatar = selected; CareerStore.Save(data); CloseAvatar(); Render(); return true; }
                catch { data.SelectedAvatar = old; status.Text = "头像未能保存，请检查存档文件夹的写入权限。"; return true; }
            });
        }, 200));
        actions.AddChild(Button("取消", CloseAvatar, 160));
        Gallery();
        search.GrabFocus();
    }
}
