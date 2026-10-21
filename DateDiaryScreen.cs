using Godot;
using System.Text.Json;

namespace NationalSpire;

public partial class CareerScreen
{
    private void AddCompletedDateCard(CareerData data, string person, PrivateOffer offer)
    {
                var completed = new PanelContainer { Name = "CompletedDateCard" };
                completed.AddThemeStyleboxOverride("panel", CareerVisuals.Box("353042", "cf9db9", 10, 12)); _privateBody!.AddChild(completed);
                var summary = new HBoxContainer(); summary.AddThemeConstantOverride("separation", 12); completed.AddChild(summary);
                var title = PrivateLine(offer.Title, 23, _gold); title.Name = "CompletedDateTitle";
                title.SizeFlagsHorizontal = SizeFlags.ShrinkBegin; title.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis; title.ClipText = true;
                title.SizeFlagsVertical = SizeFlags.ShrinkCenter; summary.AddChild(title);
                var timing = PrivateLine($"{GameCalendar.Text(data, PrivateAppointments.Date(data, offer))} · {offer.State}", 16, _muted);
                timing.Name = "CompletedDateTime"; timing.SizeFlagsHorizontal = SizeFlags.ShrinkBegin; timing.SizeFlagsVertical = SizeFlags.ShrinkCenter; summary.AddChild(timing);
                summary.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill });
                var diary = PrivateButton("约会日记", () => DateDiaryEntryDialog(data, person, offer.Id), 120);
                diary.Name = "CompletedDateDiary"; summary.AddChild(diary);
                void FitTitle() => title.CustomMinimumSize = new(Math.Min(title.GetThemeFont("font").GetStringSize(title.Text, fontSize: 23).X,
                    Math.Max(0, summary.Size.X - timing.GetCombinedMinimumSize().X - diary.GetCombinedMinimumSize().X - 36)), 0);
                summary.Resized += FitTitle; FitTitle(); return;
    }
    private void DateDiaryDialog(CareerData data, string person)
        => DateDiaryEntryDialog(data, person, "");
    private void DateDiaryEntryDialog(CareerData data, string person, string offerId)
    {
        var conversation = PrivateMessages.Conversation(data, person);
        ShowCareerDialog("约会日记 · " + CareerEngine.DisplayName(data, person), "", () => true, "关闭", box =>
        {
            var scroll = new BroadcastScroll { Name = "DateDiaryScroll", CustomMinimumSize = new(760, 440), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);
            var list = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; list.AddThemeConstantOverride("separation", 18); scroll.AddChild(list);
            foreach (var diary in DateDiaries.Records(conversation).OrderByDescending(d => d.OfferId == offerId).ThenByDescending(d => d.Season).ThenByDescending(d => d.Day))
            {
                var card = new PanelContainer { Name = "DateDiaryEntry" }; card.SetMeta("offer_id", diary.OfferId);
                card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("292e40", diary.OfferId == offerId ? "efb4d0" : "ad7b97", 8, 18)); list.AddChild(card);
                var body = new VBoxContainer(); body.AddThemeConstantOverride("separation", 12); card.AddChild(body);
                body.AddChild(Text($"{GameCalendar.Text(data, SeasonCalendar.Start(data, diary.Season) + diary.Day)} · {diary.Title}", 22, new Color("efb4d0")));
                body.AddChild(Text("地点 · " + diary.Location, 17, _muted)); body.AddChild(Text("内容 · " + diary.Content, 17, _ink));
                body.AddChild(Text(diary.Summary.Length > 0 ? diary.Summary : conversation.DateSceneStates.GetValueOrDefault(diary.OfferId) == "ended" ? "约会已结束，等待对方整理日记。" : "约会进行中，结束后记录这次相处的感想。", 20, _ink));
            }
        }, showCancel: false);
    }
}
