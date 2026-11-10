using Godot;

namespace NationalSpire;

// Career, the multiplayer lobby and its standalone setup share one landscape canvas.
internal static class LandscapeViewport
{
    private static readonly Vector2 DesignSize = new(1600, 1000);
    private static int _mobileScreens;
    private static DisplayServer.ScreenOrientation _previousOrientation;

    internal static Control Mount(Control owner)
    {
        var stage = new Control { Name = "CareerStage", Size = DesignSize };
        owner.AddChild(stage);
        var viewport = owner.GetViewport();
        Label? hint = null;
        bool mobile = OS.HasFeature("android") || OS.HasFeature("ios");
        if (mobile && _mobileScreens++ == 0)
        {
            _previousOrientation = DisplayServer.ScreenGetOrientation();
            DisplayServer.ScreenSetOrientation(DisplayServer.ScreenOrientation.SensorLandscape);
        }

        void Fit()
        {
            var available = owner.Size;
            if (available.X < 1 || available.Y < 1) return;
            bool landscape = available.X >= available.Y;
            stage.Visible = landscape;
            stage.ProcessMode = landscape ? Node.ProcessModeEnum.Inherit : Node.ProcessModeEnum.Disabled;
            if (!landscape && hint == null)
            {
                hint = new Label { Name = "LandscapeHint", Text = "请横屏查看", MouseFilter = Control.MouseFilterEnum.Stop,
                    HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center };
                hint.AddThemeFontSizeOverride("font_size", 22);
                hint.AddThemeColorOverride("font_color", CareerVisuals.Ink);
                owner.AddChild(hint);
                hint.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect);
            }
            if (hint != null) hint.Visible = !landscape;
            if (!landscape) return;
            float scale = Math.Min(available.X / DesignSize.X, available.Y / DesignSize.Y);
            stage.Scale = Vector2.One * scale;
            stage.Position = (available - DesignSize * scale) / 2;
            // The native game can stretch its logical viewport to a HiDPI window.
            var pixels = (stage.GetViewportTransform() * stage.GetGlobalTransform()).Scale.Abs();
            CareerVisuals.FitTextDensity(Math.Max(pixels.X, pixels.Y));
        }
        owner.Resized += Fit;
        viewport.SizeChanged += Fit;
        owner.TreeExiting += () =>
        {
            owner.Resized -= Fit;
            viewport.SizeChanged -= Fit;
            if (mobile && --_mobileScreens == 0) DisplayServer.ScreenSetOrientation(_previousOrientation);
        };
        Fit();
        return stage;
    }
}
