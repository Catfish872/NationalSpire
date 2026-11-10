using Godot;
using System.Globalization;

namespace NationalSpire;

public partial class CareerScreen
{
    private void ApplyDatePortraitPlacements()
    {
        if (_dateView != null && IsInstanceValid(_dateView))
            _dateView.PortraitPlacements(_datePartyArt.ToDictionary(p => p.Key, p => DatePortraitPlacement.FromAssets(p.Value.Assets)));
    }
    private void AddDatePortraitSettings(VBoxContainer box, CareerData data)
    {
        var people = _datePartyArt.Keys.ToArray();
        if (people.Length == 0) return;
        // Keep each original asset object so closing the dialog flushes edits to the selected person only.
        var settings = _datePartyArt.ToDictionary(p => p.Key, p => p.Value.Assets);
        string selected = "";
        string keyPerson = people[0];
        string worldKey = PortraitDesignStore.Key(data, keyPerson);
        bool CurrentWorld() => PortraitDesignStore.Key(ViewData, keyPerson) == worldKey;
        IEnumerable<string> Targets() => selected.Length == 0 ? people : [selected];
        var dirty = new HashSet<string>();
        var heading = new HBoxContainer(); heading.AddThemeConstantOverride("separation", 12); box.AddChild(heading);
        heading.AddChild(Text("立绘缩放", 18, _ink));
        var peopleChoice = new OptionButton { Name = "DatePortraitPerson", FitToLongestItem = false, CustomMinimumSize = new(220, 36) };
        peopleChoice.AddItem("所有对象");
        foreach (string id in people) peopleChoice.AddItem(CareerEngine.DisplayName(data, id));
        peopleChoice.Select(0); heading.AddChild(peopleChoice);
        heading.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill });
        LineEdit Number(HBoxContainer row, string name, string suffix)
        {
            var input = new LineEdit { Name = name, CustomMinimumSize = new(86, 36), Alignment = HorizontalAlignment.Right, SelectAllOnFocus = true };
            input.AddThemeFontSizeOverride("font_size", 18); row.AddChild(input);
            if (suffix.Length > 0) row.AddChild(Text(suffix, 18, _ink));
            return input;
        }
        var scaleNumber = Number(heading, "DateSpriteScaleValue", "%");
        var scale = new HSlider { Name = "DateSpriteScale", MinValue = .25, MaxValue = 2.5, Step = .01, CustomMinimumSize = new(600, 35) }; box.AddChild(scale);
        var verticalHeading = new HBoxContainer(); box.AddChild(verticalHeading);
        verticalHeading.AddChild(Text("上下位置 · 正值向上", 18, _ink)); verticalHeading.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill });
        var yNumber = Number(verticalHeading, "DateSpriteYValue", "");
        var y = new HSlider { Name = "DateSpriteY", MinValue = -200, MaxValue = 200, Step = 1, CustomMinimumSize = new(600, 35) }; box.AddChild(y);
        void SaveDirty()
        {
            if (!CurrentWorld()) return;
            foreach (string id in dirty.ToArray())
            {
                try { DateSceneAssetStore.Save(data, id, settings[id]); dirty.Remove(id); }
                catch (Exception e) { Notice("立绘设置保存失败：" + e.Message, true); }
            }
        }
        void ShowValues()
        {
            var values = Targets().Select(id => DatePortraitPlacement.FromAssets(settings[id])).ToArray();
            var value = values[0];
            scale.SetValueNoSignal(value.Scale); y.SetValueNoSignal(value.Y);
            scaleNumber.PlaceholderText = yNumber.PlaceholderText = "多值";
            scaleNumber.Text = values.All(v => v.Scale == value.Scale) ? (value.Scale * 100).ToString("0", CultureInfo.InvariantCulture) : "";
            yNumber.Text = values.All(v => v.Y == value.Y) ? value.Y.ToString("0", CultureInfo.InvariantCulture) : "";
        }
        void Change(bool scaling, double value)
        {
            if (!CurrentWorld()) return;
            foreach (string id in Targets())
            {
                var assets = settings[id];
                if (scaling) assets.SpriteScale = Math.Round(value * 100) / 100; else assets.SpriteY = -Math.Round(value);
                dirty.Add(id);
            }
            ShowValues(); ApplyDatePortraitPlacements();
        }
        void Commit(LineEdit input, bool scaling)
        {
            if (double.TryParse(input.Text.Trim().TrimEnd('%', '％'), NumberStyles.Float, CultureInfo.InvariantCulture, out double value) && double.IsFinite(value))
            {
                value = scaling ? Math.Clamp(Math.Round(value), 25, 250) / 100 : Math.Clamp(Math.Round(value), -200, 200);
                if (Targets().Select(id => DatePortraitPlacement.FromAssets(settings[id])).Any(current => value != (scaling ? current.Scale : current.Y))) Change(scaling, value);
            }
            ShowValues(); SaveDirty();
        }
        scale.ValueChanged += value => Change(true, value); y.ValueChanged += value => Change(false, value);
        scale.DragEnded += _ => SaveDirty(); y.DragEnded += _ => SaveDirty();
        scaleNumber.TextSubmitted += _ => Commit(scaleNumber, true); scaleNumber.FocusExited += () => Commit(scaleNumber, true);
        yNumber.TextSubmitted += _ => Commit(yNumber, false); yNumber.FocusExited += () => Commit(yNumber, false);
        peopleChoice.ItemSelected += index => { SaveDirty(); selected = index == 0 ? "" : people[(int)index - 1]; ShowValues(); };
        box.AddChild(Button("恢复所选对象默认大小与位置", () => { Change(true, 1); Change(false, 0); SaveDirty(); }, 340));
        ShowValues();
        if (_dialogOverlay != null) _dialogOverlay.TreeExiting += SaveDirty;
    }
}
