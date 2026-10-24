using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private void BuildChatToolToggle(HBoxContainer actions)
    {
        var options = AiSettingsStore.Load(ViewData.Ai);
        var button = PrivateButton("", () => { }, 46);
        button.Name = "ChatToolMode"; button.ToggleMode = true; button.ButtonPressed = options.ChatTools;
        button.TooltipText = "开启严格工具调用：AI总是口头答应但不生效？尝试开启此选项使用API允许的强制工具调用进行交互。\n已测试 DeepSeek 官方 API，其他渠道可用性未知。";
        button.SizeFlagsVertical = SizeFlags.Fill;
        var icon = new ChatToolIcon { Enabled = options.ChatTools, MouseFilter = MouseFilterEnum.Ignore };
        button.AddChild(icon); actions.AddChild(button);
        void Paint(bool enabled)
        {
            button.AddThemeStyleboxOverride("normal", CareerVisuals.Box(enabled ? "244850" : "1c3040", enabled ? "78dcd2" : "405b70", 8, 8));
            button.AddThemeStyleboxOverride("pressed", CareerVisuals.Box("244850", "78dcd2", 8, 8));
            icon.Enabled = enabled; icon.QueueRedraw();
        }
        Paint(options.ChatTools);
        button.Toggled += enabled =>
        {
            options.ChatTools = enabled; ViewData.Ai.ChatTools = enabled; Paint(enabled);
            try { AiSettingsStore.Save(options); }
            catch (Exception e) { Diagnostics.Error("chat.tools.settings", e); }
        };
    }
}

/// <summary>工具连接和勾选使用聊天栏现有线条、青色与灰蓝色。</summary>
public partial class ChatToolIcon : Control
{
    public bool Enabled { get; set; }
    public override void _Ready() { SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect); Resized += QueueRedraw; }
    public override void _Draw()
    {
        Vector2 center = Size / 2; Color color = Enabled ? new("78dcd2") : new("adbdcc");
        DrawPolyline([center + new Vector2(-3, -9), center + new Vector2(-9, -9), center + new Vector2(-9, 8), center + new Vector2(-3, 8)], color, 1.8f, true);
        DrawPolyline([center + new Vector2(3, -9), center + new Vector2(9, -9), center + new Vector2(9, -1)], color, 1.8f, true);
        DrawLine(center + new Vector2(2, -5), center + new Vector2(-2, 4), color, 1.8f, true);
        DrawCircle(center + new Vector2(7, 7), 6, new("142a36"), true, -1, true);
        if (Enabled) DrawPolyline([center + new Vector2(3, 7), center + new Vector2(6, 10), center + new Vector2(11, 4)], color, 1.9f, true);
        else DrawArc(center + new Vector2(7, 7), 5, 0, Mathf.Tau, 24, color, 1.2f, true);
    }
}
