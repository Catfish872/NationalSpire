using Godot;

namespace NationalSpire;

/// <summary>商品分类插画使用原生绘制，无磁盘加载或逐帧动画。</summary>
public partial class LifestyleArt : Control
{
    public static readonly string[] Sections = ["活动与计划", "我的空间", "消费商城", "交易市场", "人气榜", "公开消息", "收支记录"];
    private static readonly Dictionary<string, Texture2D> Icons = [];
    public static Texture2D Icon(string section)
    {
        if (Icons.TryGetValue(section, out var icon)) return icon;
        string path = section switch {
            "训练装备" => "M3 12v8 M7 8v16 M7 16h18 M25 8v16 M29 12v8",
            "电竞设备" => "M3 5h26v18H3z M16 23v5 M10 29h12 M10 17l4-5 4 3 5-6",
            "日常消费" => "M5 11h22l-2 18H7z M11 11V8a5 5 0 0 1 10 0v3",
            "外汇" => "M4 10h23l-5-5 M28 22H5l5 5 M16 7v18",
            "杠杆" => "M4 27V5 M4 27h25 M9 22v-5 M16 22V12 M23 22V7",
            "做多" => "M5 27V5 M5 27h24 M9 21l6-8 5 4 8-11 M21 6h7v7",
            "做空" => "M5 27V5 M5 27h24 M9 8l6 8 5-4 8 11 M21 23h7v-7",
            "确认" => "M6 16l7 7L27 8",
            "收起" => "M7 21l9-10 9 10",
            "清除" => "M8 8l16 16 M24 8L8 24",
            "波动" => "M3 17h6l4-10 6 19 4-12h6",
            "活动与计划" => "M5 6h22v23H5z M5 12h22 M10 3v6 M22 3v6 M10 19l4 4 8-8",
            "我的空间" => "M3 15L16 4l13 11 M7 12v17h18V12 M13 29V18h6v11",
            "消费商城" => "M5 11h22l-2 18H7z M11 11V8a5 5 0 0 1 10 0v3",
            "交易市场" => "M5 27V5 M5 27h24 M9 21l6-8 5 4 8-11 M25 6h3v4",
            "人气榜" => "M8 5h16v6a8 8 0 0 1-16 0z M8 8H3v4l6 4 M24 8h5v4l-6 4 M16 19v8 M10 28h12",
            "公开消息" => "M5 7h22v19H5z M9 12h14 M9 17h14 M9 22h8",
            _ => "M7 3h18v27l-4-3-5 3-5-3-4 3z M11 9h10 M11 15h10 M11 21h6" };
        using var image = new Image();
        string color = section is "训练装备" or "电竞设备" or "日常消费" or "外汇" or "做多" or "做空" ? MarketVisuals.Accent(section).ToHtml(false) : "8bd9cd";
        image.LoadSvgFromString("<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32'><path d='" + path + "' fill='none' stroke='#" + color + "' stroke-width='1.7' stroke-linecap='round' stroke-linejoin='round'/></svg>");
        return Icons[section] = ImageTexture.CreateFromImage(image);
    }
    public string Category { get; set; } = "";
    public override void _Ready() { MouseFilter = MouseFilterEnum.Ignore; Resized += QueueRedraw; }
    public override void _Draw()
    {
        var center = Size / 2; float scale = Math.Min(Size.X, Size.Y) / 200;
        Vector2 P(float x, float y) => center + new Vector2(x, y) * scale;
        var ink = CareerVisuals.Gold; var teal = new Color("436c72");
        void Line(float x, float y, float xx, float yy, Color? c = null) => DrawLine(P(x,y),P(xx,yy),c ?? ink,2*scale,true);
        DrawCircle(center, 76 * scale, new Color("153846"));
        DrawArc(center, 87 * scale, -.5f, 4.5f, 48, teal, scale, true);
        Line(-78, 57, 78, 57, teal);
        if (Category.Contains("甜筒"))
        {
            DrawPolyline([P(-28,-12),P(28,-12),P(0,58),P(-28,-12)], ink, 2*scale,true);
            DrawCircle(P(0,-30),32*scale,teal);DrawArc(P(0,-30),32*scale,0,Mathf.Tau,40,ink,2*scale,true);
            Line(-20,6,12,30);Line(20,6,-12,30);
        }
        else if (Category.Contains("蛋糕"))
        {
            DrawRect(new Rect2(P(-55,-10),new Vector2(110,58)*scale),ink,false,2*scale);
            Line(-55,12,55,12);Line(-55,32,55,32);
            foreach(float x in new[]{-25f,0f,25f}){Line(x,-12,x,-37);DrawCircle(P(x,-45),4*scale,ink);}
        }
        else if (Category.Contains("穿戴") || Category.Contains("珠宝"))
        {
            DrawPolyline([P(-50,-20),P(-25,-45),P(25,-45),P(50,-20),P(0,48),P(-50,-20),P(50,-20)],ink,2*scale,true);
            Line(-25,-45,0,48);Line(25,-45,0,48);
        }
        else if (Category.Contains("房") || Category.Contains("住宅") || Category.Contains("地产") || Category.Contains("家居"))
        {
            Line(-62,40,-62,-22);Line(-62,-22,15,-55);Line(15,-55,65,-18);Line(65,-18,65,40);Line(-62,40,65,40);
            Line(-72,-18,15,-66);Line(15,-66,75,-18);Line(15,-55,15,40);Line(30,40,30,2);Line(30,2,49,2);Line(49,2,49,40);
            for(int i=0;i<3;i++){ float x=-46+i*19;Line(x,-5,x,16);Line(x,-5,x+10,-5);Line(x+10,-5,x+10,16);Line(x,16,x+10,16); }
        }
        else if (Category.Contains("车") || Category.Contains("交通"))
        {
            DrawPolyline([P(-72,28),P(-65,-4),P(-30,-12),P(-12,-38),P(32,-38),P(56,-7),P(76,2),P(76,28),P(-72,28)],ink,2*scale,true);
            Line(-30,-12,56,-7);Line(10,-38,10,-10);DrawCircle(P(-42,30),14*scale,teal);DrawCircle(P(45,30),14*scale,teal);
        }
        else if (Category.Contains("艇") || Category.Contains("航") || Category.Contains("游"))
        {
            DrawPolyline([P(-75,18),P(70,18),P(40,47),P(-48,47),P(-75,18)],ink,2*scale,true);
            DrawPolyline([P(-35,18),P(-25,-17),P(28,-17),P(42,18)],ink,2*scale,true);Line(-10,-17,-10,-46);Line(-10,-46,30,-32);Line(30,-32,-10,-22);
            for(int i=0;i<3;i++)Line(-48+i*37,63,-25+i*37,63,teal);
        }
        else if (Category.Contains("数码") || Category.Contains("设备") || Category.Contains("运营"))
        {
            DrawPolyline([P(-62,-42),P(62,-42),P(62,24),P(-62,24),P(-62,-42)],ink,2*scale,true);Line(0,24,0,45);Line(-30,45,30,45);
            DrawPolyline([P(-43,8),P(-22,-12),P(-2,-1),P(20,-30),P(42,-20)],CareerVisuals.Teal,3*scale,true);
        }
        else
        {
            DrawPolyline([P(-42,-30),P(34,-30),P(29,35),P(-35,35),P(-42,-30)],ink,2*scale,true);
            DrawArc(P(34,-8),20*scale,-1.5f,1.5f,20,ink,2*scale,true);Line(-52,46,51,46);Line(-20,-49,-14,-67,teal);Line(8,-47,14,-65,teal);
        }
    }
}
