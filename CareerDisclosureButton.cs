using Godot;

namespace NationalSpire;

/// <summary>折叠文字入口：使用按钮按下状态绘制无柄箭头，调用者提供文字、留白和展开内容。</summary>
public partial class CareerDisclosureButton : Button
{
    public bool ArrowOnLeft { get; set; }

    public override void _Draw()
    {
        float side = GetThemeFontSize("font_size"), direction = ButtonPressed ? -1 : 1;
        var center = new Vector2(ArrowOnLeft ? side / 2 : Size.X - side / 2, Size.Y / 2);
        DrawPolyline([center + new Vector2(-side * .4f, -direction * side * .2f),
            center + new Vector2(0, direction * side * .2f),
            center + new Vector2(side * .4f, -direction * side * .2f)], GetThemeColor("font_color"), 1.5f, true);
    }
}
