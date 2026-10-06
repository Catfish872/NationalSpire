using Godot;

namespace NationalSpire;

public partial class CareerAvatar
{
    // 在控件边界内绘制；无逐帧动画、额外节点或全屏材质。
    private void DrawMetalFrame(AvatarFrame frame)
    {
        float scale = Math.Min(Size.X, Size.Y) / 100f;
        Vector2 Point(float x, float y) => new(x * scale, y * scale);
        var metal = new Color(frame.Color);
        var light = metal.Lightened(.6f);
        var shade = metal.Darkened(.58f);
        var glow = new Color(frame.Grade == 2 ? "81cfe5" : frame.Grade >= 7 ? "fff0b6" : frame.Color);
        int grade = frame.Grade;
        bool small = scale < .4f;
        void Shape(Color tint, params Vector2[] points) => DrawColoredPolygon(points.Select(p => p * scale).ToArray(), tint);
        void Stroke(Color tint, float width, params Vector2[] points) => DrawPolyline(points.Select(p => p * scale).ToArray(), tint, Math.Max(.75f, width * scale), true);
        Vector2[] Octagon(float inset, float cut) =>
        [Point(inset + cut, inset), Point(100 - inset - cut, inset), Point(100 - inset, inset + cut),
            Point(100 - inset, 100 - inset - cut), Point(100 - inset - cut, 100 - inset),
            Point(inset + cut, 100 - inset), Point(inset, 100 - inset - cut), Point(inset, inset + cut)];
        void Ring(float inset, float thickness, Color tint)
        {
            var outer = Octagon(inset, 11); var inner = Octagon(inset + thickness, 8);
            for (int i = 0; i < 8; i++)
            {
                int next = (i + 1) % 8;
                // 上沿受光、下沿压暗，斜切面形成金属厚度。
                var face = i switch { 0 or 7 => tint.Lightened(.52f), 1 or 6 => tint.Lightened(.15f), 2 => tint, _ => tint.Darkened(.38f) };
                DrawPolygon([outer[i], outer[next], inner[next], inner[i]], [face, face, face.Darkened(.25f), face.Darkened(.25f)]);
            }
        }
        var halo = Octagon(2, 11); DrawPolyline(halo.Append(halo[0]).ToArray(), new Color(glow, .14f), Math.Max(2, scale * 5), true);
        Ring(3, grade == 1 ? 4 : 6, metal);
        var insetEdge = Octagon(grade == 1 ? 8 : 10, 8);
        DrawPolyline(insetEdge.Append(insetEdge[0]).ToArray(), new Color("07131f"), Math.Max(1, scale * 2), true);
        Stroke(glow, 1.5f, new(16, 11), new(35, 11));
        Stroke(glow.Darkened(.15f), 1.5f, new(89, 36), new(89, 63));

        if (grade == 1)
        {
            Shape(metal, new(4, 25), new(11, 18), new(11, 37), new(4, 44));
            Shape(light, new(4, 25), new(11, 18), new(8, 28), new(4, 33));
        }
        if (grade >= 2)
        {
            // 肩甲扩大职业框轮廓；明暗两片在小头像上也保留辨识度。
            foreach (bool right in new[] { false, true })
            {
                Vector2 P(float x, float y) => new(right ? 100 - x : x, y);
                Shape(shade, P(0, 17), P(17, 0), P(36, 0), P(29, 7), P(16, 8), P(8, 18), P(7, 32), P(0, 39));
                Shape(light, P(1, 17), P(17, 1), P(34, 1), P(28, 5), P(15, 5), P(5, 16));
                Shape(metal, P(1, 19), P(6, 16), P(6, 30), P(1, 35));
                if (grade >= 3) Shape(glow, P(1, 44), P(7, 39), P(7, 54), P(1, 60));
            }
            Stroke(light, 2, new(12, 82), new(18, 88), new(56, 88));
            Stroke(glow, 2, new(23, 94), new(51, 94));
        }

        if (grade == 2)
        {
            Shape(shade, new(38, 1), new(62, 1), new(58, 10), new(50, 15), new(42, 10));
            Stroke(light, 2, new(41, 3), new(50, 10), new(59, 3));
            if (!small) Stroke(glow, 1.5f, new(44, 2), new(50, 6), new(56, 2));
        }
        if (grade is >= 3 and <= 7)
        {
            float gem = grade >= 5 ? 10 : 8;
            Shape(shade, new(50 - gem - 3, 6), new(50, 0), new(50 + gem + 3, 6), new(50, 19));
            Shape(light, new(50 - gem, 6), new(50, 1), new(50, 16));
            Shape(metal.Darkened(.12f), new(50, 1), new(50 + gem, 6), new(50, 16));
            if (!small) Stroke(glow, 1, new(50 - gem, 6), new(50, 8), new(50 + gem, 6));
            if (grade >= 4)
            {
                Shape(light, new(33, 3), new(39, 5), new(35, 10), new(30, 6));
                Shape(light, new(67, 3), new(61, 5), new(65, 10), new(70, 6));
            }
        }
        if (grade == 5)
        {
            Shape(metal, new(0, 58), new(12, 66), new(16, 82), new(7, 73));
            Shape(light, new(0, 58), new(9, 61), new(12, 66));
            Shape(metal, new(100, 58), new(88, 66), new(84, 82), new(93, 73));
            Shape(light, new(100, 58), new(91, 61), new(88, 66));
        }
        if (grade >= 6)
        {
            int leaves = small ? 2 : grade == 8 ? 4 : 3;
            foreach (bool right in new[] { false, true })
            {
                Vector2 P(float x, float y) => new(right ? 100 - x : x, y);
                Stroke(shade, 2, P(13, 76), P(7, 60), P(7, 30));
                for (int i = 0; i < leaves; i++)
                {
                    float y = 30 + i * 11;
                    Shape(metal, P(7, y + 12), P(0, y + 3), P(1, y - 4), P(8, y + 3));
                    Shape(light, P(7, y + 12), P(8, y + 3), P(15, y - 2), P(14, y + 5));
                }
            }
        }
        if (grade == 8)
        {
            Shape(shade, new(28, 0), new(41, 5), new(50, 0), new(59, 5), new(72, 0), new(66, 20), new(34, 20));
            Shape(metal, new(30, 1), new(42, 8), new(50, 0), new(58, 8), new(70, 1), new(64, 16), new(36, 16));
            Shape(light, new(30, 1), new(42, 8), new(50, 0), new(50, 14), new(36, 14));
            Stroke(glow, 2, new(36, 17), new(64, 17));
            Shape(new Color("65dad1"), new(47, 10), new(50, 6), new(53, 10), new(50, 14));
        }
    }
}
