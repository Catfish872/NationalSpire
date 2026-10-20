using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private string _journeyNotice = "";
    private void JourneyResumeButton(CareerData data, VBoxContainer parent)
    {
        if (data.Journey.Destination <= data.Day) return;
        var button = Button("继续前往 " + GameCalendar.Text(data, data.Journey.Destination) + "  →", ContinueEventJourney, 280);
        button.Name = "ResumeEventJourney"; parent.AddChild(button);
    }
    private void ContinueEventJourney()
    {
        int destination = ViewData.Journey.Destination;
        if (destination <= ViewData.Day) return;
        if (_eventView != null) { _eventView.QueueFree(); _eventView = null; }
        _cancelDialog?.Invoke();
        if (MultiplayerCommand("propose-advance", number: destination, accepted: Render)) return;
        CareerEngine.AdvanceToDay(ViewData, destination); Render();
    }
    private void ShowJourneyEncounter()
    {
        var data = ViewData;
        if (!EventJourney.PublicationsPaused(data) || _dialogOverlay != null || _eventView != null) return;
        var encounter = RandomEvents.Next(data, data.Day);
        if (encounter == null) return;
        string key = data.WorldId + ":" + encounter.Id;
        if (_journeyNotice == key) return;
        _journeyNotice = key;
        if (_tab != "首页") { _tab = "首页"; Render(); }
        Callable.From(() =>
        {
            if (!IsInstanceValid(this) || ViewData.WorldId != data.WorldId || !EventJourney.PublicationsPaused(ViewData)) return;
            ShowCareerDialog("途中际遇", "", () => true, "留在当天", box =>
            {
                var banner = new PanelContainer { CustomMinimumSize = new(0, 120) }; box.AddChild(banner);
                banner.AddThemeStyleboxOverride("panel", CareerVisuals.Box("132835", "496776", 8, 0));
                var background = RandomEventArt.Load("");
                var picture = new TextureRect { Texture = background, ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCovered,
                    Modulate = new(0.42f, 0.42f, 0.42f, 1), MouseFilter = MouseFilterEnum.Ignore }; banner.AddChild(picture);
                banner.TreeExiting += () => { picture.Texture = null; background?.Dispose(); };
                var inset = new MarginContainer(); foreach (string side in new[] { "left", "right", "top", "bottom" }) inset.AddThemeConstantOverride("margin_" + side, 18); banner.AddChild(inset);
                var heading = new HBoxContainer(); heading.AddThemeConstantOverride("separation", 16); inset.AddChild(heading);
                heading.AddChild(new EventEmblem { CustomMinimumSize = new(58, 58), SizeFlagsVertical = SizeFlags.ShrinkCenter });
                var dates = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, Alignment = BoxContainer.AlignmentMode.Center }; dates.AddThemeConstantOverride("separation", 10); heading.AddChild(dates);
                dates.AddChild(Text(GameCalendar.Text(data, data.Day), 24, _gold));
                dates.AddChild(Text("原定行程 · " + GameCalendar.Text(data, data.Journey.Destination), 16, _muted));
                var enter = new EventStoryButton { Name = "EnterJourneyEvent", Caption = "在这里停留片刻", Detail = "进入今日际遇，完成后可以继续原定行程", Mark = "?", CustomMinimumSize = new(0, 100) };
                enter.Pressed += () => { _cancelDialog?.Invoke(); OpenRandomEvent(encounter.Id); }; box.AddChild(enter);
                var skip = Button("跳过这次际遇，继续前往  →", () =>
                {
                    _cancelDialog?.Invoke();
                    if (MultiplayerCommand("event-skip", encounter.Id, accepted: ContinueEventJourney)) return;
                    RandomEvents.Skip(ViewData, encounter.Id); CareerStore.Save(ViewData); ContinueEventJourney();
                }, 0);
                skip.Name = "SkipJourneyEvent"; box.AddChild(skip);
            }, showCancel: false);
        }).CallDeferred();
    }
}
