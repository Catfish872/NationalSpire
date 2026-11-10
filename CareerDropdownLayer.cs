using Godot;

namespace NationalSpire;

// 选项、编号及回调仍由原控件持有。展开时只在当前生涯页面绘制列表，游戏窗口继续接收输入。
public partial class CareerDropdownLayer : Control
{
    private Button? _anchor;
    private PopupMenu? _menu;
    private ItemList? _list;
    private Action? _closed;
    internal static CareerDropdownLayer At(Control control) => LandscapeViewport.StageOf(control).GetNode<CareerDropdownLayer>("CareerDropdowns");
    internal bool Showing(Button control) => _anchor == control;

    public override void _Input(InputEvent e)
    {
        if (e is not (InputEventMouseButton or InputEventKey or InputEventJoypadButton or InputEventAction) || !IsVisibleInTree()) return;
        var viewport = GetViewport();
        if (_anchor != null)
        {
            if (e.IsActionPressed("ui_cancel")) { viewport.SetInputAsHandled(); Close(); }
            return;
        }
        bool click = e is InputEventMouseButton { Pressed: true, ButtonIndex: MouseButton.Left };
        if (!click && !e.IsActionPressed("ui_accept")) return;
        var hit = click ? viewport.GuiGetHoveredControl() : viewport.GuiGetFocusOwner();
        for (Node? n = hit; n != null; n = n.GetParent())
        {
            if (n is not Button b) continue;
            if (b is not (OptionButton or MenuButton) || b.Disabled || LandscapeViewport.StageOf(b) != GetParent()) return;
            var menu = b switch { OptionButton o => o.GetPopup(), MenuButton m => m.GetPopup(), _ => null };
            if (menu != null) { viewport.SetInputAsHandled(); Open(b, menu); }
            return;
        }
    }
    public override void _GuiInput(InputEvent e)
    {
        if (_anchor != null && e is InputEventMouseButton { Pressed: true, ButtonIndex: MouseButton.Left })
        { AcceptEvent(); Close(); }
    }
    internal void Open(Button anchor, PopupMenu menu, Action? closed = null)
    {
        Close();
        menu.EmitSignal(PopupMenu.SignalName.AboutToPopup);
        if (menu.ItemCount == 0) { closed?.Invoke(); return; }
        _anchor = anchor; _menu = menu; _closed = closed;
        anchor.TreeExiting += Close; anchor.VisibilityChanged += AnchorVisibility;
        MoveToFront(); MouseFilter = MouseFilterEnum.Stop;
        var list = new ItemList { Name = "CareerDropdownItems", MaxColumns = 1, AllowRmbSelect = false,
            FixedIconSize = new(26,26), MouseDefaultCursorShape = CursorShape.PointingHand };
        _list = list; AddChild(list);
        var panel = CareerVisuals.Box("132534", "4c6d7c", 9, 8);
        panel.ShadowColor = new Color(0,0,0,.35f); panel.ShadowSize = 5;
        list.AddThemeStyleboxOverride("panel",panel);
        list.AddThemeStyleboxOverride("focus",new StyleBoxEmpty());
        var selected = CareerVisuals.Box("25464f","589994",5,4);
        foreach (var state in new[]{"selected","selected_focus","hovered_selected","hovered_selected_focus"})
            list.AddThemeStyleboxOverride(state,selected);
        list.AddThemeStyleboxOverride("hovered",CareerVisuals.Box("213b49","365866",5,4));
        list.AddThemeFontOverride("font",CareerVisuals.InterfaceText());
        list.AddThemeFontSizeOverride("font_size",18); list.AddThemeColorOverride("font_color",CareerVisuals.Ink);
        list.AddThemeColorOverride("font_selected_color",CareerVisuals.Teal);
        list.AddThemeConstantOverride("v_separation",10); list.AddThemeConstantOverride("icon_margin",8);
        float width = anchor.Size.X;
        var font = list.GetThemeFont("font"); int current = -1;
        for (int i = 0; i < menu.ItemCount; i++)
        {
            string label = Caption(menu,anchor,i);
            bool disabled = menu.IsItemDisabled(i) || menu.IsItemSeparator(i);
            list.AddItem(label,menu.GetItemIcon(i),!disabled); list.SetItemDisabled(i,disabled);
            list.SetItemTooltip(i,menu.GetItemTooltip(i));
            width = Math.Max(width,font.GetStringSize(label,fontSize:18).X + (menu.GetItemIcon(i)!=null ? 72 : 44));
            if (anchor is OptionButton o ? o.Selected == i : menu.IsItemRadioCheckable(i) && menu.IsItemChecked(i)) current=i;
        }
        var transform = GetGlobalTransformWithCanvas().AffineInverse() * anchor.GetGlobalTransformWithCanvas();
        var rect = transform * new Rect2(Vector2.Zero,anchor.Size);
        var below = Size.Y-rect.End.Y-12; var above = rect.Position.Y-12;
        // 展开前计算实际行高，短列表贴合内容，长列表使用控件自身的滚动条。
        list.Size=new(Math.Min(width,Size.X-16),480);
        list.ForceUpdateListSize();
        float height = Math.Min(480, list.GetItemRect(menu.ItemCount-1).End.Y + 19);
        bool down = height<=below || below>=above;
        list.Size = new(Math.Min(width,Size.X-16),Math.Min(height,Math.Max(40,down?below:above)));
        list.Position = new(Math.Clamp(rect.Position.X,8,Math.Max(8,Size.X-list.Size.X-8)),
            down ? rect.End.Y+4 : rect.Position.Y-4-list.Size.Y);
        if (current>=0) { list.Select(current); list.EnsureCurrentIsVisible(); }
        list.GrabFocus();
        list.ItemClicked += (i,_,button) => { if (button == (long)MouseButton.Left) Choose((int)i); };
        list.ItemActivated += i => Choose((int)i);
    }
    private static string Caption(PopupMenu menu,Button anchor,int i)
    {
        string label = menu.GetItemText(i);
        if (menu.IsItemSeparator(i) && label.Length==0) return "────────";
        return anchor is not OptionButton && (menu.IsItemCheckable(i) || menu.IsItemRadioCheckable(i))
            ? (menu.IsItemChecked(i) ? "✓   " : "　   ") + label : label;
    }
    private void Choose(int index)
    {
        if (_anchor is not {} anchor || _menu is not {} menu || menu.IsItemDisabled(index) || menu.IsItemSeparator(index)) return;
        if (anchor is OptionButton option)
        {
            bool notify = option.Selected != index || option.AllowReselect;
            Close(); option.Select(index);
            if (notify) option.EmitSignal(OptionButton.SignalName.ItemSelected,(long)index);
            return;
        }
        bool keep = menu.IsItemCheckable(index) ? !menu.HideOnCheckableItemSelection : !menu.HideOnItemSelection;
        int id=menu.GetItemId(index);
        if (!keep) Close();
        menu.EmitSignal(PopupMenu.SignalName.IdPressed,(long)id);
        if (keep && _list != null)
            for (int i=0;i<menu.ItemCount;i++) _list.SetItemText(i,Caption(menu,anchor,i));
    }
    private void AnchorVisibility() { if (_anchor?.IsVisibleInTree() == false) Close(); }
    internal void Close()
    {
        if (_anchor is not {} anchor) return;
        _anchor=null; _menu=null; var closed=_closed; _closed=null;
        anchor.TreeExiting -= Close; anchor.VisibilityChanged -= AnchorVisibility;
        MouseFilter=MouseFilterEnum.Ignore;
        _list!.Hide(); _list.QueueFree(); _list=null;
        if (anchor.IsVisibleInTree() && anchor.IsInsideTree() && !anchor.IsQueuedForDeletion() && anchor.GetFocusModeWithOverride()!=FocusModeEnum.None) anchor.GrabFocus();
        closed?.Invoke();
    }
}
