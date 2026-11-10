using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private string _journeyNotice = "", _appointmentNotice = "";
    private void ShowDueAppointments()
    {
        var data=ViewData;
        if (EventJourney.PublicationsPaused(data) || data.Failure!=null || data.PendingMatchId!=null || _privateOverlay!=null || _dialogOverlay!=null || _eventView!=null) return;
        var visits=SocialAppointments.Due(data).ToList();
        if (visits.Count==0) return;
        string key=string.Join("|",visits.Select(v=>v.Offer.GroupId+"/"+v.Conversation.PersonId+"/"+v.Offer.Id).Order())+"@"+data.Day;
        if (_appointmentNotice==key) return;
        Callable.From(()=>
        {
            if(!IsInstanceValid(this) || IsQueuedForDeletion() || !ReferenceEquals(data,ViewData) || _appointmentNotice==key || _tab is not ("首页" or "日程")
                || _privateOverlay!=null || _dialogOverlay!=null || _eventView!=null || !SocialAppointments.Due(data).Any())return;
            _appointmentNotice=key;
            ShowCareerDialog("今日赴约","",()=>true,"留在当天",box=>
            {
                foreach(var (conversation,offer) in SocialAppointments.Due(data))
                    box.AddChild(Button(offer.Title+" · "+CareerEngine.DisplayName(data,conversation.PersonId),()=>
                    {
                        _cancelDialog?.Invoke();
                        if(offer.GroupId.Length>0) SelectGroup(offer.GroupId); else OpenPrivateMessages(conversation.PersonId);
                    },0));
            },showCancel:false);
        }).CallDeferred();
    }
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
        TravelTo(destination);
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
                var picture = new EventArtPicture { ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCovered,
                    Modulate = new(0.42f, 0.42f, 0.42f, 1), MouseFilter = MouseFilterEnum.Ignore };
                banner.AddChild(picture); picture.ShowArt("");
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
