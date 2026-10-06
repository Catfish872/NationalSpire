using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private PersonMentions? _mentions;
    private Control MentionText(CareerData data, string source, int size, Color color, IEnumerable<string>? related = null)
    {
        _mentions ??= new PersonMentions(data.People.SelectMany(p => p.HandleAliases.Append(p.PublicName).Append(p.Name)
            .Select(name => (p.Id, name))).Concat(data.PlayerNameAliases.Append(CareerEngine.Name(data)).Select(name => ("player", name))));
        string text = CareerMoney.Display(source);
        var matches = _mentions.Find(text, related);
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
