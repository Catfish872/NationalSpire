using Godot;
using System.Text.Json;

namespace NationalSpire;

public partial class CareerScreen
{
    private void NpcAvatarFramePicker(CareerData data, string person)
    {
        string selected = PrivateMessages.Mailbox(data).NpcAvatarFrames.GetValueOrDefault(person, "auto");
        var identity = AvatarHonors.ForPerson(data, person);
        var art = CareerAvatars.ForPerson(data, person);
        var relation = PrivateMessages.Relation(data, person);
        Label? status = null;
        Button? save = null;
        void Applied()
        {
            if (!IsInstanceValid(this) || !IsInsideTree() || ViewData.WorldId != data.WorldId || ViewData.LocalHumanId != data.LocalHumanId) return;
            _privateListSignature = _privateSignature = _groupSignature = "";
            void RefreshPictures(Node node)
            {
                if (node is CareerAvatar { Simplified: false } picture && picture.PersonId == person) picture.Identity = AvatarHonors.ForPerson(ViewData, person);
                foreach (var child in node.GetChildren()) RefreshPictures(child);
            }
            RefreshPictures(_stage);
        }
        bool Save()
        {
            if (ViewData.WorldId != data.WorldId || ViewData.LocalHumanId != data.LocalHumanId) return true;
            if (NpcAvatarFrames.Locked(ViewData, person, selected) is { } reason)
            {
                status!.Text = reason; status.Modulate = new Color("ee929d"); return false;
            }
            if (_multiplayer != null)
            {
                _multiplayer.Send("dm-avatar-frame", person, JsonSerializer.Serialize(new PrivateMessageCommand { Text = selected }), accepted: Applied);
                return true;
            }
            var current = ViewData; var choices = PrivateMessages.Mailbox(current).NpcAvatarFrames;
            string? previous = choices.GetValueOrDefault(person);
            if (NpcAvatarFrames.Select(current, person, selected) is { } error)
            {
                status!.Text = error; status.Modulate = new Color("ee929d"); return false;
            }
            try { CareerStore.Save(current); }
            catch
            {
                if (previous == null) choices.Remove(person); else choices[person] = previous;
                status!.Text = "头像框保存失败，请检查存档目录后重试。"; status.Modulate = new Color("ee929d"); return false;
            }
            Applied(); return true;
        }
        ShowCareerDialog("选择头像框", "", Save, "保存", box =>
        {
            var top = new HBoxContainer(); top.AddThemeConstantOverride("separation", 26); box.AddChild(top);
            var portrait = new CareerAvatar { Name = "NpcFramePreview", Art = art, Identity = identity, CustomMinimumSize = new(112, 112), SizeFlagsVertical = SizeFlags.ShrinkCenter };
            top.AddChild(portrait);
            var details = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(620, 126) };
            details.AddThemeConstantOverride("separation", 9); top.AddChild(details);
            var title = Text("", 22, _ink); title.Name = "NpcFrameTitle"; details.AddChild(title);
            var description = Text("", 17, _ink); details.AddChild(description);
            var condition = Text("", 15, _muted); condition.Name = "NpcFrameRequirement"; details.AddChild(condition);
            box.AddChild(new HSeparator());
            var scroll = new ScrollContainer { Name = "NpcFrameScroll", CustomMinimumSize = new(780, Math.Clamp(GetViewportRect().Size.Y - 430, 200, 330)), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled };
            box.AddChild(scroll);
            var grid = new GridContainer { Columns = 4, SizeFlagsHorizontal = SizeFlags.ExpandFill };
            grid.AddThemeConstantOverride("h_separation", 12); grid.AddThemeConstantOverride("v_separation", 12); scroll.AddChild(grid);
            status = Text("", 15, _muted); status.Name = "NpcFrameStatus";
            var buttons = new Dictionary<string, Button>();
            var frames = new[] { new AvatarFrame("auto", "默认", "526b78", 0, "") }.Concat(NpcAvatarFrames.Choices).ToArray();
            void Preview()
            {
                var frame = frames.FirstOrDefault(f => f.Id == selected) ?? frames[0]; selected = frame.Id;
                string? locked = NpcAvatarFrames.Locked(ViewData, person, selected);
                portrait.Identity = identity with { SelectedFrame = selected == "auto" ? "" : selected };
                title.Text = CareerEngine.DisplayName(data, person) + " · " + frame.Name;
                description.Text = NpcAvatarFrames.Description(selected);
                condition.Text = "获得条件：" + NpcAvatarFrames.Requirement(selected);
                status.Text = locked ?? "选好后点击保存，应用头像框。";
                status.Modulate = locked == null ? Colors.White : new Color("ee929d");
                if (save != null) save.Disabled = locked != null;
                foreach (var (id, button) in buttons)
                    button.AddThemeStyleboxOverride("normal", CareerVisuals.Box(id == selected ? "334b60" : "203448", id == selected ? "e6bcce" : "405c72", 8, 10));
            }
            var gray = new ShaderMaterial { Shader = new Shader { Code = "shader_type canvas_item; void fragment(){ vec4 c = texture(TEXTURE, UV) * COLOR; float g = dot(c.rgb, vec3(0.299,0.587,0.114)); COLOR = vec4(vec3(g * 0.62), c.a); }" } };
            foreach (var frame in frames)
            {
                string? locked = NpcAvatarFrames.Locked(data, person, frame.Id);
                var button = Button("", () => { selected = frame.Id; Preview(); }, 0); button.Name = "NpcFrame_" + frame.Id;
                button.CustomMinimumSize = new(178, 133); button.SizeFlagsHorizontal = SizeFlags.ExpandFill;
                button.TooltipText = locked ?? NpcAvatarFrames.Requirement(frame.Id); grid.AddChild(button); buttons[frame.Id] = button;
                var inset = new MarginContainer(); button.AddChild(inset); inset.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
                foreach (string edge in new[] { "left", "right", "top", "bottom" }) inset.AddThemeConstantOverride("margin_" + edge, 12);
                var content = new VBoxContainer(); content.AddThemeConstantOverride("separation", 9); inset.AddChild(content);
                var sample = new Control { CustomMinimumSize = new(76, 76), SizeFlagsHorizontal = SizeFlags.ShrinkCenter }; content.AddChild(sample);
                var picture = new CareerAvatar { Art = art, Identity = identity with { SelectedFrame = frame.Id == "auto" ? "" : frame.Id }, Material = locked == null ? null : gray };
                sample.AddChild(picture); picture.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
                if (locked != null)
                {
                    var padlock = new NpcFrameLock { Name = "NpcFrameLock" }; sample.AddChild(padlock); padlock.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
                }
                var name = Text(frame.Name, 18, locked == null ? _ink : _muted); name.HorizontalAlignment = HorizontalAlignment.Center; content.AddChild(name);
                PrivateIgnoreMouse(inset);
            }
            box.AddChild(status); Preview();
        });
        save = _dialogOverlay?.FindChild("CareerDialogConfirm", true, false) as Button;
        if (save != null) save.Disabled = NpcAvatarFrames.Locked(data, person, selected) != null;
    }
}

/// <summary>头像框预览中的矢量锁；鼠标交互交给下层选项。</summary>
public partial class NpcFrameLock : Control
{
    public override void _Draw()
    {
        var center = Size / 2;
        DrawCircle(center, 23, new Color("172431", .88f));
        var ink = new Color("d1dae1");
        DrawArc(center + new Vector2(0, -7), 8, MathF.PI, MathF.Tau, 24, ink, 2.5f, true);
        DrawLine(center + new Vector2(-8, -7), center + new Vector2(-8, -2), ink, 2.5f, true);
        DrawLine(center + new Vector2(8, -7), center + new Vector2(8, -2), ink, 2.5f, true);
        DrawStyleBox(new StyleBoxFlat { BgColor = ink, CornerRadiusTopLeft = 3, CornerRadiusTopRight = 3, CornerRadiusBottomLeft = 3, CornerRadiusBottomRight = 3 }, new Rect2(center + new Vector2(-13, -3), new Vector2(26, 21)));
        DrawCircle(center + new Vector2(0, 5), 2.5f, new Color("334350"));
        DrawLine(center + new Vector2(0, 6), center + new Vector2(0, 11), new Color("334350"), 2, true);
    }
}
