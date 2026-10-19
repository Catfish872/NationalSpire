# NpcAvatarFrameScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`44B7018B71BB6756D395752BBD14C1B003F05797BE97C1321F91C59146DD95F6`。来源：[源码](../../NpcAvatarFrameScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`、`NationalSpire.NpcFrameLock`。

字段、事件及初始值（源码原样）：

```csharp

```

<a id="symbol-ca2807c0402f"></a>

## `NationalSpire.CareerScreen.NpcAvatarFramePicker(NationalSpire.CareerData, string) — private void NpcAvatarFramePicker(CareerData data, string person)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PersonProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](ProfileScreen.cs.md#symbol-2d802d5a07b9)

**调用：** `Godot.CanvasItem.GetViewportRect()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.Control()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.GridContainer.GridContainer()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.HSeparator.HSeparator()`；`Godot.MarginContainer.MarginContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.FindChild(string, bool, bool)`；`Godot.ScrollContainer.ScrollContainer()`；`Godot.Shader.Shader()`；`Godot.ShaderMaterial.ShaderMaterial()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.AvatarFrame.AvatarFrame(string, string, string, int, string)`；[`NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`](AvatarHonors.cs.md#symbol-5207a1627331)；`NationalSpire.CareerAvatar.CareerAvatar()`；[`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-cd3d95caefab)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.PrivateIgnoreMouse(Godot.Node)`](PrivateMemoryScreen.cs.md#symbol-780ecbf2f8bf)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`](CareerDialog.cs.md#symbol-d832b736b02b)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.NpcAvatarFrames.Locked(NationalSpire.CareerData, string, string)`](NpcAvatarFrames.cs.md#symbol-312d47fec9fa)；[`NationalSpire.NpcAvatarFrames.Requirement(string)`](NpcAvatarFrames.cs.md#symbol-810d8a8cbd67)；`NationalSpire.NpcFrameLock.NpcFrameLock()`；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；[`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-8a6bb6e78fa5)；[`Preview()`](NpcAvatarFrameScreen.cs.md#symbol-81e2560db041)；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Math.Clamp(float, float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarFrame.Id`；`NationalSpire.AvatarFrame.Name`；`NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.AvatarIdentity.SelectedFrame`；`NationalSpire.CareerAvatar.Art`；`NationalSpire.CareerAvatar.Identity`；`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.PrivateIgnoreMouse(Godot.Node)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.NpcAvatarFrames.Choices`；`NationalSpire.NpcAvatarFrames.Locked(NationalSpire.CareerData, string, string)`；`NationalSpire.NpcAvatarFrames.Requirement(string)`；`NationalSpire.PrivateMailbox.NpcAvatarFrames`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；`Preview()`；`Save()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.GetViewportRect()`；输入表达式：`GetViewportRect()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetViewportRect().Size`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`content.AddThemeConstantOverride("separation", 9)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddThemeConstantOverride("separation", 9);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`details.AddThemeConstantOverride("separation", 9)`；返回值紧邻使用处：`ExpressionStatementSyntax: details.AddThemeConstantOverride("separation", 9);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("h_separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("h_separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("v_separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("v_separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`inset.AddThemeConstantOverride("margin_" + edge, 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: inset.AddThemeConstantOverride("margin_" + edge, 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`top.AddThemeConstantOverride("separation", 26)`；返回值紧邻使用处：`ExpressionStatementSyntax: top.AddThemeConstantOverride("separation", 26);`
- `Godot.Control.Control()`；输入表达式：`new Control { CustomMinimumSize = new(76, 76), SizeFlagsHorizontal = SizeFlags.ShrinkCenter }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Control { CustomMinimumSize = new(76, 76), SizeFlagsHorizontal = SizeFlags.ShrinkCenter }`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`inset.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: inset.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`padlock.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: padlock.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`picture.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: picture.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer { Columns = 4, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GridContainer { Columns = 4, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.HSeparator.HSeparator()`；输入表达式：`new HSeparator()`；返回值紧邻使用处：`ArgumentSyntax: new HSeparator()`
- `Godot.MarginContainer.MarginContainer()`；输入表达式：`new MarginContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MarginContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(new HSeparator())`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(new HSeparator());`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(status)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(status);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(top)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(top);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`button.AddChild(inset)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddChild(inset);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(name)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(name);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(sample)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(sample);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`details.AddChild(condition)`；返回值紧邻使用处：`ExpressionStatementSyntax: details.AddChild(condition);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`details.AddChild(description)`；返回值紧邻使用处：`ExpressionStatementSyntax: details.AddChild(description);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`details.AddChild(title)`；返回值紧邻使用处：`ExpressionStatementSyntax: details.AddChild(title);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`grid.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddChild(button);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inset.AddChild(content)`；返回值紧邻使用处：`ExpressionStatementSyntax: inset.AddChild(content);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`sample.AddChild(padlock)`；返回值紧邻使用处：`ExpressionStatementSyntax: sample.AddChild(padlock);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`sample.AddChild(picture)`；返回值紧邻使用处：`ExpressionStatementSyntax: sample.AddChild(picture);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scroll.AddChild(grid)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.AddChild(grid);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`top.AddChild(details)`；返回值紧邻使用处：`ExpressionStatementSyntax: top.AddChild(details);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`top.AddChild(portrait)`；返回值紧邻使用处：`ExpressionStatementSyntax: top.AddChild(portrait);`
- `Godot.Node.FindChild(string, bool, bool)`；输入表达式：`.FindChild("CareerDialogConfirm", true, false)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _dialogOverlay?.FindChild("CareerDialogConfirm", true, false)`
- `Godot.ScrollContainer.ScrollContainer()`；输入表达式：`new ScrollContainer { Name = "NpcFrameScroll", CustomMinimumSize = new(780, Math.Clamp(GetViewportRect().Size.Y - 430, 200, 330)), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ScrollContainer { Name = "NpcFrameScroll", CustomMinimumSize = new(780, Math.Clamp(GetViewportRect().Size.Y - 430, 200, 330)), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `Godot.Shader.Shader()`；输入表达式：`new Shader { Code = "shader_type canvas_item; void fragment(){ vec4 c = texture(TEXTURE, UV) * COLOR; float g = dot(c.rgb, vec3(0.299,0.587,0.114)); COLOR = vec4(vec3(g * 0.62), c.a); }" }`；返回值紧邻使用处：`AssignmentExpressionSyntax: Shader = new Shader { Code = "shader_type canvas_item; void fragment(){ vec4 c = texture(TEXTURE, UV) * COLOR; float g = dot(c.rgb, vec3(0.299,0.587,0.114)); COLOR = vec4(vec3(g * 0.62), c.a); }" }`
- `Godot.ShaderMaterial.ShaderMaterial()`；输入表达式：`new ShaderMaterial { Shader = new Shader { Code = "shader_type canvas_item; void fragment(){ vec4 c = texture(TEXTURE, UV) * COLOR; float g = dot(c.rgb, vec3(0.299,0.587,0.114)); COLOR = vec4(vec3(g * 0.62), c.a); }" } }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ShaderMaterial { Shader = new Shader { Code = "shader_type canvas_item; void fragment(){ vec4 c = texture(TEXTURE, UV) * COLOR; float g = dot(c.rgb, vec3(0.299,0.587,0.114)); COLOR = vec4(vec3(g * 0.62), c.a); }" } }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(620, 126) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(620, 126) }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(112, 112)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(112, 112)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(178, 133)`；返回值紧邻使用处：`AssignmentExpressionSyntax: button.CustomMinimumSize = new(178, 133)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(620, 126)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(620, 126)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(76, 76)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(76, 76)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(780, Math.Clamp(GetViewportRect().Size.Y - 430, 200, 330))`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(780, Math.Clamp(GetViewportRect().Size.Y - 430, 200, 330))`
- `NationalSpire.AvatarFrame.AvatarFrame(string, string, string, int, string)`；输入表达式：`new AvatarFrame("auto", "默认", "526b78", 0, "")`；返回值紧邻使用处：`InitializerExpressionSyntax: { new AvatarFrame("auto", "默认", "526b78", 0, "") }`
- `NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`AvatarHonors.ForPerson(data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AvatarHonors.ForPerson(data, person)`
- `NationalSpire.CareerAvatar.CareerAvatar()`；输入表达式：`new CareerAvatar { Art = art, Identity = identity with { SelectedFrame = frame.Id == "auto" ? "" : frame.Id }, Material = locked == null ? null : gray }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CareerAvatar { Art = art, Identity = identity with { SelectedFrame = frame.Id == "auto" ? "" : frame.Id }, Material = locked == null ? null : gray }`
- `NationalSpire.CareerAvatar.CareerAvatar()`；输入表达式：`new CareerAvatar { Name = "NpcFramePreview", Art = art, Identity = identity, CustomMinimumSize = new(112, 112), SizeFlagsVertical = SizeFlags.ShrinkCenter }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CareerAvatar { Name = "NpcFramePreview", Art = art, Identity = identity, CustomMinimumSize = new(112, 112), SizeFlagsVertical = SizeFlags.ShrinkCenter }`
- `NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`CareerAvatars.ForPerson(data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerAvatars.ForPerson(data, person)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("", () => { selected = frame.Id; Preview(); }, 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button("", () => { selected = frame.Id; Preview(); }, 0)`
- `NationalSpire.CareerScreen.PrivateIgnoreMouse(Godot.Node)`；输入表达式：`PrivateIgnoreMouse(inset)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateIgnoreMouse(inset);`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；输入表达式：`ShowCareerDialog("选择头像框", "", Save, "保存", box => { var top = new HBoxContainer(); top.AddThemeConstantOverride("separation", 26); box.AddChild(top); var portrait = new CareerAvatar { Name = "NpcFramePreview", Art = art, Identity = identity, CustomMinimumSize = new(112, 112), SizeFlagsVertical = SizeFlags.ShrinkCenter }; top.AddChild(portrait); var details = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(620, 126) }; details.AddThemeConstantOverride("separation", 9); top.AddChild(details); var title = Text("", 22, _ink); title.Name = "NpcFrameTitle"; details.AddChild(title); var description = Text("", 17, _ink); details.AddChild(description); var condition = Text("", 15, _muted); condition.Name = "NpcFrameRequirement"; details.AddChild(condition); box.AddChild(new HSeparator()); var scroll = new ScrollContainer { Name = "NpcFrameScroll", CustomMinimumSize = new(780, Math.Clamp(GetViewportRect().Size.Y - 430, 200, 330)), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll); var grid = new GridContainer { Columns = 4, SizeFlagsHorizontal = SizeFlags.ExpandFill }; grid.AddThemeConstantOverride("h_separation", 12); grid.AddThemeConstantOverride("v_separation", 12); scroll.AddChild(grid); status = Text("", 15, _muted); status.Name = "NpcFrameStatus"; var buttons = new Dictionary<string, Button>(); var frames = new[] { new AvatarFrame("auto", "默认", "526b78", 0, "") }.Concat(NpcAvatarFrames.Choices).ToArray(); void Preview() { var frame = frames.FirstOrDefault(f => f.Id == selected) ?? frames[0]; selected = frame.Id; string? locked = NpcAvatarFrames.Locked(ViewData, person, selected); portrait.Identity = identity with { SelectedFrame = selected == "auto" ? "" : selected }; title.Text = CareerEngine.DisplayName(data, person) + " · " + frame.Name; description.Text = NpcAvatarFrames.Description(selected); condition.Text = "获得条件：" + NpcAvatarFrames.Requirement(selected); status.Text = locked ?? "选好后点击保存，应用头像框。"; status.Modulate = locked == null ? Colors.White : new Color("ee929d"); if (save != null) save.Disabled = locked != null; foreach (var (id, button) in buttons) button.AddThemeStyleboxOverride("normal", CareerVisuals.Box(id == selected ? "334b60" : "203448", id == selected ? "e6bcce" : "405c72", 8, 10)); } var gray = new ShaderMaterial { Shader = new Shader { Code = "shader_type canvas_item; void fragment(){ vec4 c = texture(TEXTURE, UV) * COLOR; float g = dot(c.rgb, vec3(0.299,0.587,0.114)); COLOR = vec4(vec3(g * 0.62), c.a); }" } }; foreach (var frame in frames) { string? locked = NpcAvatarFrames.Locked(data, person, frame.Id); var button = Button("", () => { selected = frame.Id; Preview(); }, 0); button.Name = "NpcFrame_" + frame.Id; button.CustomMinimumSize = new(178, 133); button.SizeFlagsHorizontal = SizeFlags.ExpandFill; button.TooltipText = locked ?? NpcAvatarFrames.Requirement(frame.Id); grid.AddChild(button); buttons[frame.Id] = button; var inset = new MarginContainer(); button.AddChild(inset); inset.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect); foreach (string edge in new[] { "left", "right", "top", "bottom" }) inset.AddThemeConstantOverride("margin_" + edge, 12); var content = new VBoxContainer(); content.AddThemeConstantOverride("separation", 9); inset.AddChild(content); var sample = new Control { CustomMinimumSize = new(76, 76), SizeFlagsHorizontal = SizeFlags.ShrinkCenter }; content.AddChild(sample); var picture = new CareerAvatar { Art = art, Identity = identity with { SelectedFrame = frame.Id == "auto" ? "" : frame.Id }, Material = locked == null ? null : gray }; sample.AddChild(picture); picture.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect); if (locked != null) { var padlock = new NpcFrameLock { Name = "NpcFrameLock" }; sample.AddChild(padlock); padlock.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect); } var name = Text(frame.Name, 18, locked == null ? _ink : _muted); name.HorizontalAlignment = HorizontalAlignment.Center; content.AddChild(name); PrivateIgnoreMouse(inset); } box.AddChild(status); Preview(); })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("选择头像框", "", Save, "保存", box => { var top = new HBoxContainer(); top.AddThemeConstantOverride("separation", 26); box.AddChild(top); var portrait = new CareerAvatar { Name = "NpcFramePreview", Art = art, Identity = identity, CustomMinimumSize = new(112, 112), SizeFlagsVertical = SizeFlags.ShrinkCenter }; top.AddChild(portrait); var details = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(620, 126) }; details.AddThemeConstantOverride("separation", 9); top.AddChild(details); var title = Text("", 22, _ink); title.Name = "NpcFrameTitle"; details.AddChild(title); var description = Text("", 17, _ink); details.AddChild(description); var condition = Text("", 15, _muted); condition.Name = "NpcFrameRequirement"; details.AddChild(condition); box.AddChild(new HSeparator()); var scroll = new ScrollContainer { Name = "NpcFrameScroll", CustomMinimumSize = new(780, Math.Clamp(GetViewportRect().Size.Y - 430, 200, 330)), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll); var grid = new GridContainer { Columns = 4, SizeFlagsHorizontal = SizeFlags.ExpandFill }; grid.AddThemeConstantOverride("h_separation", 12); grid.AddThemeConstantOverride("v_separation", 12); scroll.AddChild(grid); status = Text("", 15, _muted); status.Name = "NpcFrameStatus"; var buttons = new Dictionary<string, Button>(); var frames = new[] { new AvatarFrame("auto", "默认", "526b78", 0, "") }.Concat(NpcAvatarFrames.Choices).ToArray(); void Preview() { var frame = frames.FirstOrDefault(f => f.Id == selected) ?? frames[0]; selected = frame.Id; string? locked = NpcAvatarFrames.Locked(ViewData, person, selected); portrait.Identity = identity with { SelectedFrame = selected == "auto" ? "" : selected }; title.Text = CareerEngine.DisplayName(data, person) + " · " + frame.Name; description.Text = NpcAvatarFrames.Description(selected); condition.Text = "获得条件：" + NpcAvatarFrames.Requirement(selected); status.Text = locked ?? "选好后点击保存，应用头像框。"; status.Modulate = locked == null ? Colors.White : new Color("ee929d"); if (save != null) save.Disabled = locked != null; foreach (var (id, button) in buttons) button.AddThemeStyleboxOverride("normal", CareerVisuals.Box(id == selected ? "334b60" : "203448", id == selected ? "e6bcce" : "405c72", 8, 10)); } var gray = new ShaderMaterial { Shader = new Shader { Code = "shader_type canvas_item; void fragment(){ vec4 c = texture(TEXTURE, UV) * COLOR; float g = dot(c.rgb, vec3(0.299,0.587,0.114)); COLOR = vec4(vec3(g * 0.62), c.a); }" } }; foreach (var frame in frames) { string? locked = NpcAvatarFrames.Locked(data, person, frame.Id); var button = Button("", () => { selected = frame.Id; Preview(); }, 0); button.Name = "NpcFrame_" + frame.Id; button.CustomMinimumSize = new(178, 133); button.SizeFlagsHorizontal = SizeFlags.ExpandFill; button.TooltipText = locked ?? NpcAvatarFrames.Requirement(frame.Id); grid.AddChild(button); buttons[frame.Id] = button; var inset = new MarginContainer(); button.AddChild(inset); inset.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect); foreach (string edge in new[] { "left", "right", "top", "bottom" }) inset.AddThemeConstantOverride("margin_" + edge, 12); var content = new VBoxContainer(); content.AddThemeConstantOverride("separation", 9); inset.AddChild(content); var sample = new Control { CustomMinimumSize = new(76, 76), SizeFlagsHorizontal = SizeFlags.ShrinkCenter }; content.AddChild(sample); var picture = new CareerAvatar { Art = art, Identity = identity with { SelectedFrame = frame.Id == "auto" ? "" : frame.Id }, Material = locked == null ? null : gray }; sample.AddChild(picture); picture.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect); if (locked != null) { var padlock = new NpcFrameLock { Name = "NpcFrameLock" }; sample.AddChild(padlock); padlock.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect); } var name = Text(frame.Name, 18, locked == null ? _ink : _muted); name.HorizontalAlignment = HorizontalAlignment.Center; content.AddChild(name); PrivateIgnoreMouse(inset); } box.AddChild(status); Preview(); });`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 15, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("", 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 15, _muted)`；返回值紧邻使用处：`AssignmentExpressionSyntax: status = Text("", 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 17, _ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("", 17, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 22, _ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("", 22, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(frame.Name, 18, locked == null ? _ink : _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text(frame.Name, 18, locked == null ? _ink : _muted)`
- `NationalSpire.NpcAvatarFrames.Locked(NationalSpire.CareerData, string, string)`；输入表达式：`NpcAvatarFrames.Locked(data, person, frame.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = NpcAvatarFrames.Locked(data, person, frame.Id)`
- `NationalSpire.NpcAvatarFrames.Locked(NationalSpire.CareerData, string, string)`；输入表达式：`NpcAvatarFrames.Locked(data, person, selected)`；返回值紧邻使用处：`BinaryExpressionSyntax: NpcAvatarFrames.Locked(data, person, selected) != null`
- `NationalSpire.NpcAvatarFrames.Requirement(string)`；输入表达式：`NpcAvatarFrames.Requirement(frame.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: locked ?? NpcAvatarFrames.Requirement(frame.Id)`
- `NationalSpire.NpcFrameLock.NpcFrameLock()`；输入表达式：`new NpcFrameLock { Name = "NpcFrameLock" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new NpcFrameLock { Name = "NpcFrameLock" }`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).NpcAvatarFrames`
- `NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Relation(data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Relation(data, person)`
- `Preview()`；输入表达式：`Preview()`；返回值紧邻使用处：`ExpressionStatementSyntax: Preview();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, Button>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, Button>()`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`new[] { new AvatarFrame("auto", "默认", "526b78", 0, "") }.Concat(NpcAvatarFrames.Choices)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { new AvatarFrame("auto", "默认", "526b78", 0, "") }.Concat(NpcAvatarFrames.Choices).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`new[] { new AvatarFrame("auto", "默认", "526b78", 0, "") }.Concat(NpcAvatarFrames.Choices).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new[] { new AvatarFrame("auto", "默认", "526b78", 0, "") }.Concat(NpcAvatarFrames.Choices).ToArray()`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`PrivateMessages.Mailbox(data).NpcAvatarFrames.GetValueOrDefault(person, "auto")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Mailbox(data).NpcAvatarFrames.GetValueOrDefault(person, "auto")`
- `System.Math.Clamp(float, float, float)`；输入表达式：`Math.Clamp(GetViewportRect().Size.Y - 430, 200, 330)`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(GetViewportRect().Size.Y - 430, 200, 330)`

**赋值（含属性/字段和局部值）：**

- `Art` = `art`
- `Code` = `"shader_type canvas_item; void fragment(){ vec4 c = texture(TEXTURE, UV) * COLOR; float g = dot(c.rgb, vec3(0.299,0.587,0.114)); COLOR = vec4(vec3(g * 0.62), c.a); }"`
- `Columns` = `4`
- `CustomMinimumSize` = `new(112, 112)`
- `CustomMinimumSize` = `new(620, 126)`
- `CustomMinimumSize` = `new(76, 76)`
- `CustomMinimumSize` = `new(780, Math.Clamp(GetViewportRect().Size.Y - 430, 200, 330))`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `Identity` = `identity with { SelectedFrame = frame.Id == "auto" ? "" : frame.Id }`
- `Identity` = `identity`
- `Material` = `locked == null ? null : gray`
- `Name` = `"NpcFrameLock"`
- `Name` = `"NpcFramePreview"`
- `Name` = `"NpcFrameScroll"`
- `SelectedFrame` = `frame.Id == "auto" ? "" : frame.Id`
- `Shader` = `new Shader { Code = "shader_type canvas_item; void fragment(){ vec4 c = texture(TEXTURE, UV) * COLOR; float g = dot(c.rgb, vec3(0.299,0.587,0.114)); COLOR = vec4(vec3(g * 0.62), c.a); }" }`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsHorizontal` = `SizeFlags.ShrinkCenter`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `button.CustomMinimumSize` = `new(178, 133)`
- `button.Name` = `"NpcFrame_" + frame.Id`
- `button.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `button.TooltipText` = `locked ?? NpcAvatarFrames.Requirement(frame.Id)`
- `buttons[frame.Id]` = `button`
- `condition.Name` = `"NpcFrameRequirement"`
- `name.HorizontalAlignment` = `HorizontalAlignment.Center`
- `save.Disabled` = `NpcAvatarFrames.Locked(data, person, selected) != null`
- `save` = `_dialogOverlay?.FindChild("CareerDialogConfirm", true, false) as Button`
- `selected` = `frame.Id`
- `status.Name` = `"NpcFrameStatus"`
- `status` = `Text("", 15, _muted)`
- `title.Name` = `"NpcFrameTitle"`

<a id="symbol-ed1e42458c16"></a>

## `Applied() — void Applied()`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Save()`](NpcAvatarFrameScreen.cs.md#symbol-053e6d0ce097)

**调用：** `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Node.IsInsideTree()`；[`RefreshPictures(Godot.Node)`](NpcAvatarFrameScreen.cs.md#symbol-acaa451c0109)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.LocalHumanId`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._groupSignature`；`NationalSpire.CareerScreen._privateListSignature`；`NationalSpire.CareerScreen._privateSignature`；`NationalSpire.CareerScreen._stage`；`RefreshPictures(Godot.Node)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(this)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(this)`
- `Godot.Node.IsInsideTree()`；输入表达式：`IsInsideTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInsideTree()`
- `RefreshPictures(Godot.Node)`；输入表达式：`RefreshPictures(_stage)`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshPictures(_stage);`

**赋值（含属性/字段和局部值）：**

- `_groupSignature` = `""`
- `_privateListSignature` = `_privateSignature = _groupSignature = ""`
- `_privateSignature` = `_groupSignature = ""`

<a id="symbol-acaa451c0109"></a>

## `RefreshPictures(Godot.Node) — void RefreshPictures(Node node)`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Applied()`](NpcAvatarFrameScreen.cs.md#symbol-ed1e42458c16)；[`RefreshPictures(Godot.Node)`](NpcAvatarFrameScreen.cs.md#symbol-acaa451c0109)

**调用：** `Godot.Node.GetChildren(bool)`；[`NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`](AvatarHonors.cs.md#symbol-5207a1627331)；[`RefreshPictures(Godot.Node)`](NpcAvatarFrameScreen.cs.md#symbol-acaa451c0109)

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.CareerAvatar.Identity`；`NationalSpire.CareerAvatar.PersonId`；`NationalSpire.CareerAvatar.Simplified`；`NationalSpire.CareerScreen.ViewData`；`RefreshPictures(Godot.Node)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.GetChildren(bool)`；输入表达式：`node.GetChildren()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var child in node.GetChildren()) RefreshPictures(child);`
- `NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`AvatarHonors.ForPerson(ViewData, person)`；返回值紧邻使用处：`AssignmentExpressionSyntax: picture.Identity = AvatarHonors.ForPerson(ViewData, person)`
- `RefreshPictures(Godot.Node)`；输入表达式：`RefreshPictures(child)`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshPictures(child);`

**赋值（含属性/字段和局部值）：**

- `picture.Identity` = `AvatarHonors.ForPerson(ViewData, person)`

<a id="symbol-053e6d0ce097"></a>

## `Save() — bool Save()`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`Applied()`](NpcAvatarFrameScreen.cs.md#symbol-ed1e42458c16)；`Godot.Color.Color(string)`；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-e21b0ff1d18b)；[`NationalSpire.NpcAvatarFrames.Locked(NationalSpire.CareerData, string, string)`](NpcAvatarFrames.cs.md#symbol-312d47fec9fa)；[`NationalSpire.NpcAvatarFrames.Select(NationalSpire.CareerData, string, string)`](NpcAvatarFrames.cs.md#symbol-8c2dcfe0344a)；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `Applied()`；`NationalSpire.CareerData.LocalHumanId`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?)`；`NationalSpire.NpcAvatarFrames.Locked(NationalSpire.CareerData, string, string)`；`NationalSpire.NpcAvatarFrames.Select(NationalSpire.CareerData, string, string)`；`NationalSpire.PrivateMailbox.NpcAvatarFrames`；`NationalSpire.PrivateMessageCommand.Text`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Applied()`；输入表达式：`Applied()`；返回值紧邻使用处：`ExpressionStatementSyntax: Applied();`
- `Godot.Color.Color(string)`；输入表达式：`new Color("ee929d")`；返回值紧邻使用处：`AssignmentExpressionSyntax: status.Modulate = new Color("ee929d")`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(current)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(current);`
- `NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?)`；输入表达式：`_multiplayer.Send("dm-avatar-frame", person, JsonSerializer.Serialize(new PrivateMessageCommand { Text = selected }), accepted: Applied)`；返回值紧邻使用处：`ExpressionStatementSyntax: _multiplayer.Send("dm-avatar-frame", person, JsonSerializer.Serialize(new PrivateMessageCommand { Text = selected }), accepted: Applied);`
- `NationalSpire.NpcAvatarFrames.Locked(NationalSpire.CareerData, string, string)`；输入表达式：`NpcAvatarFrames.Locked(ViewData, person, selected)`；返回值紧邻使用处：`IsPatternExpressionSyntax: NpcAvatarFrames.Locked(ViewData, person, selected) is { } reason`
- `NationalSpire.NpcAvatarFrames.Select(NationalSpire.CareerData, string, string)`；输入表达式：`NpcAvatarFrames.Select(current, person, selected)`；返回值紧邻使用处：`IsPatternExpressionSyntax: NpcAvatarFrames.Select(current, person, selected) is { } error`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new PrivateMessageCommand { Text = selected }`；返回值紧邻使用处：`ArgumentSyntax: new PrivateMessageCommand { Text = selected }`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(current)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(current).NpcAvatarFrames`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`choices.Remove(person)`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.Remove(person);`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`choices.GetValueOrDefault(person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = choices.GetValueOrDefault(person)`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(new PrivateMessageCommand { Text = selected })`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.Serialize(new PrivateMessageCommand { Text = selected })`

**赋值（含属性/字段和局部值）：**

- `Text` = `selected`
- `choices[person]` = `previous`
- `status!.Text` = `"头像框保存失败，请检查存档目录后重试。"`
- `status!.Text` = `error`
- `status!.Text` = `reason`
- `status.Modulate` = `new Color("ee929d")`

<a id="symbol-81e2560db041"></a>

## `Preview() — void Preview()`

来源：源码第 71 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.NpcAvatarFramePicker(NationalSpire.CareerData, string)`](NpcAvatarFrameScreen.cs.md#symbol-ca2807c0402f)

**调用：** `Godot.Color.Color(string)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.NpcAvatarFrames.Description(string)`](NpcAvatarFrames.cs.md#symbol-5c31464eed81)；[`NationalSpire.NpcAvatarFrames.Locked(NationalSpire.CareerData, string, string)`](NpcAvatarFrames.cs.md#symbol-312d47fec9fa)；[`NationalSpire.NpcAvatarFrames.Requirement(string)`](NpcAvatarFrames.cs.md#symbol-810d8a8cbd67)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarFrame.Id`；`NationalSpire.AvatarFrame.Name`；`NationalSpire.AvatarIdentity.SelectedFrame`；`NationalSpire.CareerAvatar.Identity`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.NpcAvatarFrames.Description(string)`；`NationalSpire.NpcAvatarFrames.Locked(NationalSpire.CareerData, string, string)`；`NationalSpire.NpcAvatarFrames.Requirement(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("ee929d")`；返回值紧邻使用处：`ConditionalExpressionSyntax: locked == null ? Colors.White : new Color("ee929d")`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("normal", CareerVisuals.Box(id == selected ? "334b60" : "203448", id == selected ? "e6bcce" : "405c72", 8, 10))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("normal", CareerVisuals.Box(id == selected ? "334b60" : "203448", id == selected ? "e6bcce" : "405c72", 8, 10));`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, person)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.DisplayName(data, person) + " · "`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box(id == selected ? "334b60" : "203448", id == selected ? "e6bcce" : "405c72", 8, 10)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box(id == selected ? "334b60" : "203448", id == selected ? "e6bcce" : "405c72", 8, 10)`
- `NationalSpire.NpcAvatarFrames.Description(string)`；输入表达式：`NpcAvatarFrames.Description(selected)`；返回值紧邻使用处：`AssignmentExpressionSyntax: description.Text = NpcAvatarFrames.Description(selected)`
- `NationalSpire.NpcAvatarFrames.Locked(NationalSpire.CareerData, string, string)`；输入表达式：`NpcAvatarFrames.Locked(ViewData, person, selected)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = NpcAvatarFrames.Locked(ViewData, person, selected)`
- `NationalSpire.NpcAvatarFrames.Requirement(string)`；输入表达式：`NpcAvatarFrames.Requirement(selected)`；返回值紧邻使用处：`BinaryExpressionSyntax: "获得条件：" + NpcAvatarFrames.Requirement(selected)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`frames.FirstOrDefault(f => f.Id == selected)`；返回值紧邻使用处：`BinaryExpressionSyntax: frames.FirstOrDefault(f => f.Id == selected) ?? frames[0]`

**赋值（含属性/字段和局部值）：**

- `SelectedFrame` = `selected == "auto" ? "" : selected`
- `condition.Text` = `"获得条件：" + NpcAvatarFrames.Requirement(selected)`
- `description.Text` = `NpcAvatarFrames.Description(selected)`
- `portrait.Identity` = `identity with { SelectedFrame = selected == "auto" ? "" : selected }`
- `save.Disabled` = `locked != null`
- `selected` = `frame.Id`
- `status.Modulate` = `locked == null ? Colors.White : new Color("ee929d")`
- `status.Text` = `locked ?? "选好后点击保存，应用头像框。"`
- `title.Text` = `CareerEngine.DisplayName(data, person) + " · " + frame.Name`

<a id="symbol-e83fb0c6e0c7"></a>

## `NationalSpire.NpcFrameLock._Draw() — public override void _Draw()`

来源：源码第 115 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawStyleBox(Godot.StyleBox, Godot.Rect2)`；`Godot.Color.Color(string)`；`Godot.Color.Color(string, float)`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.StyleBoxFlat.StyleBoxFlat()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(center + new Vector2(0, -7), 8, MathF.PI, MathF.Tau, 24, ink, 2.5f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(center + new Vector2(0, -7), 8, MathF.PI, MathF.Tau, 24, ink, 2.5f, true);`
- `Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；输入表达式：`DrawCircle(center + new Vector2(0, 5), 2.5f, new Color("334350"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawCircle(center + new Vector2(0, 5), 2.5f, new Color("334350"));`
- `Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；输入表达式：`DrawCircle(center, 23, new Color("172431", .88f))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawCircle(center, 23, new Color("172431", .88f));`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(center + new Vector2(-8, -7), center + new Vector2(-8, -2), ink, 2.5f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(center + new Vector2(-8, -7), center + new Vector2(-8, -2), ink, 2.5f, true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(center + new Vector2(0, 6), center + new Vector2(0, 11), new Color("334350"), 2, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(center + new Vector2(0, 6), center + new Vector2(0, 11), new Color("334350"), 2, true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(center + new Vector2(8, -7), center + new Vector2(8, -2), ink, 2.5f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(center + new Vector2(8, -7), center + new Vector2(8, -2), ink, 2.5f, true);`
- `Godot.CanvasItem.DrawStyleBox(Godot.StyleBox, Godot.Rect2)`；输入表达式：`DrawStyleBox(new StyleBoxFlat { BgColor = ink, CornerRadiusTopLeft = 3, CornerRadiusTopRight = 3, CornerRadiusBottomLeft = 3, CornerRadiusBottomRight = 3 }, new Rect2(center + new Vector2(-13, -3), new Vector2(26, 21)))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawStyleBox(new StyleBoxFlat { BgColor = ink, CornerRadiusTopLeft = 3, CornerRadiusTopRight = 3, CornerRadiusBottomLeft = 3, CornerRadiusBottomRight = 3 }, new Rect2(center + new Vector2(-13, -3), new Vector2(26, 21)));`
- `Godot.Color.Color(string)`；输入表达式：`new Color("334350")`；返回值紧邻使用处：`ArgumentSyntax: new Color("334350")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("d1dae1")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Color("d1dae1")`
- `Godot.Color.Color(string, float)`；输入表达式：`new Color("172431", .88f)`；返回值紧邻使用处：`ArgumentSyntax: new Color("172431", .88f)`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(center + new Vector2(-13, -3), new Vector2(26, 21))`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(center + new Vector2(-13, -3), new Vector2(26, 21))`
- `Godot.StyleBoxFlat.StyleBoxFlat()`；输入表达式：`new StyleBoxFlat { BgColor = ink, CornerRadiusTopLeft = 3, CornerRadiusTopRight = 3, CornerRadiusBottomLeft = 3, CornerRadiusBottomRight = 3 }`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxFlat { BgColor = ink, CornerRadiusTopLeft = 3, CornerRadiusTopRight = 3, CornerRadiusBottomLeft = 3, CornerRadiusBottomRight = 3 }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-13, -3)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(-13, -3)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-8, -2)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(-8, -2)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-8, -7)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(-8, -7)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, -7)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(0, -7)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, 11)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(0, 11)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, 5)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(0, 5)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, 6)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(0, 6)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(26, 21)`；返回值紧邻使用处：`ArgumentSyntax: new Vector2(26, 21)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(8, -2)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(8, -2)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(8, -7)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(8, -7)`

**赋值（含属性/字段和局部值）：**

- `BgColor` = `ink`
- `CornerRadiusBottomLeft` = `3`
- `CornerRadiusBottomRight` = `3`
- `CornerRadiusTopLeft` = `3`
- `CornerRadiusTopRight` = `3`
