using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private void ClubLeaveDialog()
    {
        bool owner = OwnedClubs.IsOwner(ViewData);
        Label? error = null;
        ShowCareerDialog("退出俱乐部", owner ? "" : "退出后可能无法再次加入同俱乐部，是否确认？", () =>
        {
            var data = ViewData;
            if (ClubDeparture.Error(data) is { } reason) { error!.Text = reason; return false; }
            if (MultiplayerCommand("propose-leave-club", data.Esports.ClubId)) return true;
            var result = ClubDeparture.Leave(data);
            if (result != null) { error!.Text = result; return false; }
            _clubDraft = null; _ownerSection = "阵容"; Render(); return true;
        }, "确认退出", box =>
        {
            if (owner)
            {
                var message = new RichTextLabel { Name = "ClubDepartureWarning", BbcodeEnabled = true, FitContent = true, ScrollActive = false,
                    SizeFlagsHorizontal = SizeFlags.ExpandFill, Text = "退出后将[color=#ee929d][b]永久失去[/b][/color]俱乐部管理权且可能无法再次加入同俱乐部，是否确认？" };
                message.AddThemeFontSizeOverride("normal_font_size", 18); message.AddThemeColorOverride("default_color", _ink); box.AddChild(message);
            }
            error = Text("", 16, new Color("ee929d")); error.Name = "ClubDepartureError"; box.AddChild(error);
        });
    }
}
