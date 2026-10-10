using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private PersonMentions? _mentions;
    private List<(string Id, string Name)> _mentionNames = [];
    private bool _mentionsChecked;
    private Control MentionText(CareerData data, string source, int size, Color color, IEnumerable<string>? related = null)
    {
        if (!_mentionsChecked)
        {
            // 只复用名称索引，每次重建页面仍核对完整姓名和别名；不缓存帖子内容或人物状态。
            var names = data.People.SelectMany(p => p.HandleAliases.Append(p.PublicName).Append(p.Name)
                .Select(name => (p.Id, name))).Concat(data.PlayerNameAliases.Append(CareerEngine.Name(data)).Select(name => ("player", name))).ToList();
            if (_mentions == null || !names.SequenceEqual(_mentionNames)) { _mentions = new PersonMentions(names); _mentionNames = names; }
            _mentionsChecked = true;
        }
        string text = CareerMoney.Display(source);
        var matches = _mentions!.Find(text, related);
        if (matches.Count == 0) return PrivateSelectableText(text, size, color);
        var rich = new RichTextLabel { Name = "PersonMentionText", FitContent = true, ScrollActive = false,
            SelectionEnabled = true, BbcodeEnabled = false, AutowrapMode = TextServer.AutowrapMode.WordSmart,
            SizeFlagsHorizontal = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Pass };
        rich.AddThemeStyleboxOverride("focus", new StyleBoxEmpty());
        rich.AddThemeFontSizeOverride("normal_font_size", size);
        rich.AddThemeColorOverride("default_color", color);
        int cursor = 0;
        foreach (var mention in matches)
        {
            rich.AddText(text[cursor..mention.Start]);
            var person = CareerEngine.Person(data, mention.PersonId);
            string details = mention.PersonId == "player"
                ? $"{CareerEngine.Name(data)} · {EsportsWorld.LicenseName(data)}\n{data.Esports.Country} · {EsportsWorld.ClubName(data, data.Esports.ClubId)}"
                : $"{person?.PublicName} · {person?.Role}\n{person?.Country} · {EsportsWorld.ClubName(data, person?.ClubId ?? "")}";
            rich.PushMeta(mention.PersonId, RichTextLabel.MetaUnderline.Always, details + "\n点击查看档案");
            rich.PushColor(new Color("9bc3ce"));
            rich.AddText(text.Substring(mention.Start, mention.Length)); rich.Pop(); rich.Pop();
            cursor = mention.Start + mention.Length;
        }
        rich.AddText(text[cursor..]);
        rich.MetaClicked += meta =>
        {
            string id = meta.AsString();
            if (id == "player" || CareerEngine.Person(data, id) != null) OpenPerson(id);
        };
        return rich;
    }
}
