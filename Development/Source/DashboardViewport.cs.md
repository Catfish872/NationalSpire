# DashboardViewport.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`20C700FE94767E9CA1868047A1B6B6AAED78549060CC6C17E515A88BF1D69A81`。来源：[源码](../../DashboardViewport.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.LandscapeViewport`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly Vector2 DesignSize = new(1600, 1000);
private static int _mobileScreens;
private static DisplayServer.ScreenOrientation _previousOrientation;
```

<a id="symbol-adb87fe8fef5"></a>

## `NationalSpire.LandscapeViewport.Mount(Godot.Control) — internal static Control Mount(Control owner)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Build()`](CareerScreen.cs.md#symbol-8b4784fe3138)；[`NationalSpire.CareerScreen.SelectNpcGeneration(Godot.Control, NationalSpire.AiOptions, System.Func<NationalSpire.NpcGenerationSetup, System.Threading.Tasks.Task>, System.Action?)`](NpcGenerationScreen.cs.md#symbol-4a76a0da98d8)；[`NationalSpire.Coop.CoopScreen._Ready()`](Coop/CoopScreen.cs.md#symbol-5affb9c9c17f)

**调用：** [`Fit()`](DashboardViewport.cs.md#symbol-689ddf36dc19)；`Godot.Control.Control()`；`Godot.DisplayServer.ScreenGetOrientation(int)`；`Godot.DisplayServer.ScreenSetOrientation(Godot.DisplayServer.ScreenOrientation, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetViewport()`；`Godot.OS.HasFeature(string)`

**字段、属性、事件及方法组引用：** `Fit()`；`NationalSpire.LandscapeViewport.DesignSize`；`NationalSpire.LandscapeViewport._mobileScreens`；`NationalSpire.LandscapeViewport._previousOrientation`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Fit()`；输入表达式：`Fit()`；返回值紧邻使用处：`ExpressionStatementSyntax: Fit();`
- `Godot.Control.Control()`；输入表达式：`new Control { Name = "CareerStage", Size = DesignSize }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Control { Name = "CareerStage", Size = DesignSize }`
- `Godot.DisplayServer.ScreenGetOrientation(int)`；输入表达式：`DisplayServer.ScreenGetOrientation()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _previousOrientation = DisplayServer.ScreenGetOrientation()`
- `Godot.DisplayServer.ScreenSetOrientation(Godot.DisplayServer.ScreenOrientation, int)`；输入表达式：`DisplayServer.ScreenSetOrientation(DisplayServer.ScreenOrientation.SensorLandscape)`；返回值紧邻使用处：`ExpressionStatementSyntax: DisplayServer.ScreenSetOrientation(DisplayServer.ScreenOrientation.SensorLandscape);`
- `Godot.DisplayServer.ScreenSetOrientation(Godot.DisplayServer.ScreenOrientation, int)`；输入表达式：`DisplayServer.ScreenSetOrientation(_previousOrientation)`；返回值紧邻使用处：`ExpressionStatementSyntax: DisplayServer.ScreenSetOrientation(_previousOrientation);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`owner.AddChild(stage)`；返回值紧邻使用处：`ExpressionStatementSyntax: owner.AddChild(stage);`
- `Godot.Node.GetViewport()`；输入表达式：`owner.GetViewport()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = owner.GetViewport()`
- `Godot.OS.HasFeature(string)`；输入表达式：`OS.HasFeature("android")`；返回值紧邻使用处：`BinaryExpressionSyntax: OS.HasFeature("android") || OS.HasFeature("ios")`
- `Godot.OS.HasFeature(string)`；输入表达式：`OS.HasFeature("ios")`；返回值紧邻使用处：`BinaryExpressionSyntax: OS.HasFeature("android") || OS.HasFeature("ios")`

**赋值（含属性/字段和局部值）：**

- `Name` = `"CareerStage"`
- `Size` = `DesignSize`
- `_previousOrientation` = `DisplayServer.ScreenGetOrientation()`
- `owner.Resized` += `Fit`
- `owner.Resized` -= `Fit`
- `owner.TreeExiting` += `() => { owner.Resized -= Fit; viewport.SizeChanged -= Fit; if (mobile && --_mobileScreens == 0) DisplayServer.ScreenSetOrientation(_previousOrientation); }`
- `viewport.SizeChanged` += `Fit`
- `viewport.SizeChanged` -= `Fit`

<a id="symbol-689ddf36dc19"></a>

## `Fit() — void Fit()`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LandscapeViewport.Mount(Godot.Control)`](DashboardViewport.cs.md#symbol-adb87fe8fef5)

**调用：** `Godot.CanvasItem.GetGlobalTransform()`；`Godot.CanvasItem.GetViewportTransform()`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.Label.Label()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Abs()`；[`NationalSpire.CareerVisuals.FitTextDensity(float)`](CareerVisuals.cs.md#symbol-450a39fba218)；`System.Math.Max(float, float)`；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.FitTextDensity(float)`；`NationalSpire.CareerVisuals.Ink`；`NationalSpire.LandscapeViewport.DesignSize`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.GetGlobalTransform()`；输入表达式：`stage.GetGlobalTransform()`；返回值紧邻使用处：`BinaryExpressionSyntax: stage.GetViewportTransform() * stage.GetGlobalTransform()`
- `Godot.CanvasItem.GetViewportTransform()`；输入表达式：`stage.GetViewportTransform()`；返回值紧邻使用处：`BinaryExpressionSyntax: stage.GetViewportTransform() * stage.GetGlobalTransform()`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`hint.AddThemeColorOverride("font_color", CareerVisuals.Ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: hint.AddThemeColorOverride("font_color", CareerVisuals.Ink);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`hint.AddThemeFontSizeOverride("font_size", 22)`；返回值紧邻使用处：`ExpressionStatementSyntax: hint.AddThemeFontSizeOverride("font_size", 22);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`hint.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: hint.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect);`
- `Godot.Label.Label()`；输入表达式：`new Label { Name = "LandscapeHint", Text = "请横屏查看", MouseFilter = Control.MouseFilterEnum.Stop, HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center }`；返回值紧邻使用处：`AssignmentExpressionSyntax: hint = new Label { Name = "LandscapeHint", Text = "请横屏查看", MouseFilter = Control.MouseFilterEnum.Stop, HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`owner.AddChild(hint)`；返回值紧邻使用处：`ExpressionStatementSyntax: owner.AddChild(hint);`
- `Godot.Vector2.Abs()`；输入表达式：`(stage.GetViewportTransform() * stage.GetGlobalTransform()).Scale.Abs()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = (stage.GetViewportTransform() * stage.GetGlobalTransform()).Scale.Abs()`
- `NationalSpire.CareerVisuals.FitTextDensity(float)`；输入表达式：`CareerVisuals.FitTextDensity(Math.Max(pixels.X, pixels.Y))`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.FitTextDensity(Math.Max(pixels.X, pixels.Y));`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(pixels.X, pixels.Y)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(pixels.X, pixels.Y)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(available.X / DesignSize.X, available.Y / DesignSize.Y)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(available.X / DesignSize.X, available.Y / DesignSize.Y)`

**赋值（含属性/字段和局部值）：**

- `HorizontalAlignment` = `HorizontalAlignment.Center`
- `MouseFilter` = `Control.MouseFilterEnum.Stop`
- `Name` = `"LandscapeHint"`
- `Text` = `"请横屏查看"`
- `VerticalAlignment` = `VerticalAlignment.Center`
- `hint.Visible` = `!landscape`
- `hint` = `new Label { Name = "LandscapeHint", Text = "请横屏查看", MouseFilter = Control.MouseFilterEnum.Stop, HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center }`
- `stage.Position` = `(available - DesignSize * scale) / 2`
- `stage.ProcessMode` = `landscape ? Node.ProcessModeEnum.Inherit : Node.ProcessModeEnum.Disabled`
- `stage.Scale` = `Vector2.One * scale`
- `stage.Visible` = `landscape`
