using Godot;

namespace NationalSpire;

internal static class OpeningControls
{
    internal static Label Label(string text,int size=16,Color? color=null)
    {
        var l=new Label{Text=text,AutowrapMode=TextServer.AutowrapMode.WordSmart};
        l.AddThemeFontSizeOverride("font_size",size);l.AddThemeColorOverride("font_color",color??CareerVisuals.Muted);return l;
    }
    internal static VBoxContainer Section(Container parent,string name,string icon,string detail,bool open=false,Color? accent=null)
    {
        var panel=new PanelContainer{SizeFlagsHorizontal=Control.SizeFlags.ExpandFill};
        panel.AddThemeStyleboxOverride("panel",CareerVisuals.Box("132430","354d5c",9,12));parent.AddChild(panel);
        var shell=new VBoxContainer();panel.AddChild(shell);
        var head=new Button{Flat=true,ToggleMode=true,ButtonPressed=open,AccessibilityName=name,CustomMinimumSize=new(0,44),MouseDefaultCursorShape=Control.CursorShape.PointingHand};
        shell.AddChild(head);
        var line=new HBoxContainer{MouseFilter=Control.MouseFilterEnum.Ignore};head.AddChild(line);line.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect);line.OffsetLeft=9;line.OffsetRight=-9;line.AddThemeConstantOverride("separation",14);
        line.AddChild(CareerScreen.Glyph(icon,23,accent??CareerVisuals.Gold));var heading=Label(name,21,CareerVisuals.Ink);heading.AutowrapMode=TextServer.AutowrapMode.Off;line.AddChild(heading);
        var summary=Label(detail);summary.SizeFlagsHorizontal=Control.SizeFlags.ExpandFill;summary.HorizontalAlignment=HorizontalAlignment.Right;line.AddChild(summary);
        var down=CareerScreen.Glyph("chevron-down",18,CareerVisuals.Teal);line.AddChild(down);
        var up=CareerScreen.Glyph("chevron-up",18,CareerVisuals.Teal);line.AddChild(up);
        var box=new VBoxContainer();box.AddThemeConstantOverride("separation",10);shell.AddChild(box);
        void Fold(bool on){box.Visible=on;up.Visible=on;down.Visible=!on;}
        Fold(open);head.Toggled+=Fold;return box;
    }
    internal static Button Card(Container parent,string title,string detail,string icon,bool chosen,Action select,ButtonGroup? group=null)
    {
        var button=new BroadcastButton{AccessibilityName=title,ToggleMode=true,ButtonGroup=group,ButtonPressed=chosen,CustomMinimumSize=new(0,74),SizeFlagsHorizontal=Control.SizeFlags.ExpandFill};
        parent.AddChild(button);button.Pressed+=select.Invoke;
        var line=new HBoxContainer{MouseFilter=Control.MouseFilterEnum.Ignore};button.AddChild(line);line.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect);
        line.OffsetLeft=16;line.OffsetRight=-12;line.AddThemeConstantOverride("separation",12);line.AddChild(CareerScreen.Glyph(icon,23,CareerVisuals.Teal));
        var words=new VBoxContainer{MouseFilter=Control.MouseFilterEnum.Ignore,Alignment=BoxContainer.AlignmentMode.Center,SizeFlagsHorizontal=Control.SizeFlags.ExpandFill};line.AddChild(words);
        words.AddChild(Label(title,20,CareerVisuals.Ink));words.AddChild(Label(detail,15));
        return button;
    }
    internal static Button Chip(Container parent,ButtonGroup group,string title,bool chosen,Action select)
    {
        var b=new BroadcastButton{Text=title,ToggleMode=true,ButtonGroup=group,ButtonPressed=chosen,CustomMinimumSize=new(66,39)};
        parent.AddChild(b);b.Pressed+=select.Invoke;return b;
    }
    internal static VBoxContainer Field(Container grid,string name)
    {
        var col=new VBoxContainer{SizeFlagsHorizontal=Control.SizeFlags.ExpandFill};col.AddThemeConstantOverride("separation",4);
        grid.AddChild(col);col.AddChild(Label(name));return col;
    }
}
