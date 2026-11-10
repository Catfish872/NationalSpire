using Godot;

namespace NationalSpire;

/// <summary>单人生涯、房主与首次加入的队员共用同一份个人资料编辑器。</summary>
internal static class OpeningPlayerEditor
{
    internal static void Draw(VBoxContainer parent, CareerOpeningPlayer player, string defaultName, string defaultCountry, string? teamCountry = null)
    {
        var panel = new BroadcastPanel { Accent = CareerVisuals.Teal };
        panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("152633","365565",10,16)); parent.AddChild(panel);
        var body = new VBoxContainer(); body.AddThemeConstantOverride("separation",10); panel.AddChild(body);
        var title = new Label { Text = "选手档案" }; title.AddThemeColorOverride("font_color", CareerVisuals.Gold); body.AddChild(title);
        if (teamCountry != null)
            body.AddChild(new Label { Text = $"全队代表{teamCountry}参赛。外汇也按全队参赛国报价。" });
        var grid = new GridContainer { Columns = 3 }; grid.AddThemeConstantOverride("h_separation",12); grid.AddThemeConstantOverride("v_separation",8); body.AddChild(grid);
        VBoxContainer Field(string label)
        {
            var field = new VBoxContainer { SizeFlagsHorizontal = Control.SizeFlags.ExpandFill };
            var caption = new Label { Text = label }; caption.AddThemeColorOverride("font_color",CareerVisuals.Muted); field.AddChild(caption); grid.AddChild(field); return field;
        }
        void Input(string label, string value, string hint, Action<string> changed)
        {
            var input = new LineEdit { Text = value, PlaceholderText = hint, CustomMinimumSize = new(128,42) };
            Field(label).AddChild(input); input.TextChanged += changed.Invoke;
        }
        void Choose(string label, string first, IEnumerable<string> source, string value, Action<string> changed)
        {
            var list = source.Distinct().ToArray(); var choice = new OptionButton { FitToLongestItem = false };
            choice.AddItem(first); foreach (var item in list) choice.AddItem(item); choice.Select(Array.IndexOf(list,value)+1);
            Field(label).AddChild(choice); choice.ItemSelected += i => changed(i == 0 ? "" : list[(int)i-1]);
        }
        Input("姓名",player.Name,defaultName,v=>player.Name=v);
        Choose("国籍","沿用 "+defaultCountry, EsportsWorld.Countries,player.Country,v=>player.Country=v);
        Choose("性别","沿用默认", IdentityGender.Choices.Where(s=>s!=IdentityGender.Unset),player.Gender,v=>player.Gender=v);
        void Count(string label,int? current,Action<int?> set) =>
            Input(label,current?.ToString() ?? "","沿用默认",s => set(int.TryParse(s,out int n) && n>=0 ? n : null));
        Count("胜场",player.Wins,v=>player.Wins=v); Count("平局",player.Draws,v=>player.Draws=v); Count("负场",player.Losses,v=>player.Losses=v);
        Input("初始资金（美元）",player.Credits?.ToString() ?? "","沿用默认",s=>player.Credits=decimal.TryParse(s,out var n) && n>=0 ? n : null);
        Choose("个人赞助","无赞助",RegionalOrganizations.SponsorCatalog().Select(s=>s.Brand),player.Sponsor,v=>player.Sponsor=v);
        var avatar = new BroadcastButton { Text=player.Avatar?.Label ?? "选择头像", CustomMinimumSize=new(0,42) }; Field("头像").AddChild(avatar);
        avatar.Pressed += () => {
            var picker=new FileDialog { FileMode=FileDialog.FileModeEnum.OpenFile, Access=FileDialog.AccessEnum.Filesystem, Filters=["*.png,*.jpg,*.jpeg,*.webp ; 人物头像"] };
            body.AddChild(picker); picker.FileSelected += path => { try { player.Avatar=AvatarImages.FromFile(path); avatar.Text=player.Avatar.Label; } catch(Exception e){avatar.Text=e.Message;} picker.QueueFree(); };
            picker.Canceled += picker.QueueFree; picker.PopupCenteredRatio(.7f);
        };
        var biography = new TextEdit { Text = player.Biography, PlaceholderText="人物介绍 · 写下希望其他人知道的经历", CustomMinimumSize=new(0,78), WrapMode=TextEdit.LineWrappingMode.Boundary };
        body.AddChild(biography); biography.TextChanged += () => player.Biography=biography.Text;
    }
}
