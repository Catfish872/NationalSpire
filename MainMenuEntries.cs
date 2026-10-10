using Godot;
using MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;

namespace NationalSpire;

internal static class MainMenuEntries
{
    public static void Bind(NMainMenu menu, Button button)
    {
        void UpdateVisibility() => button.Visible = !menu.SubmenuStack.SubmenusOpen
            && !menu.PatchNotesScreen.IsOpen && CareerScreen.Current == null && Coop.CoopScreen.Current == null;

        // 原版子页面保留主菜单节点，因此入口必须随页面切换隐藏。
        menu.SubmenuStack.Connect(NSubmenuStack.SignalName.StackModified, Callable.From(UpdateVisibility));
        menu.PatchNotesScreen.VisibilityChanged += UpdateVisibility;
        UpdateVisibility();
    }
}
