using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private int _weeklyIndex;
    private int _weeklyWeek;
    private int _latestWeeklyPublished;
    private VBoxContainer? _weeklyContent;
    private double _weeklyClock;
    private const double WeeklyInterval = 10;
    private Tween? _weeklyTween;
    private bool _weeklyAuto = true;
    private ProgressBar? _weeklyProgress;
    private OptionButton? _weeklySelector;
    private readonly HashSet<int> _weeklyCeremonyShown = [];
    private void WeeklyCarousel(CareerData data)
    {
        var published = data.WeeklyEditions.Where(w => CameoContent.VisibleSlides(w).Count > 0).OrderByDescending(w => w.Week).ToList();
        var latest = data.WeeklyEditions.LastOrDefault();
        if (latest == null) return;
        var section = Card(); section.Name = "WeeklySection"; _content.AddChild(section); var box = Inner(section);
        var heading = new HBoxContainer(); box.AddChild(heading);
        var headingText = Text("尖塔双周刊", 25, _gold); headingText.SizeFlagsHorizontal = SizeFlags.ExpandFill; heading.AddChild(headingText);
        if (published.Count > 0)
        {
            var cover = CameoContent.VisibleSlides(published[0]).FirstOrDefault(s => s.CeremonySeason > 0);
            if (cover != null && _weeklyCeremonyShown.Add(cover.CeremonySeason))
            { _weeklyWeek = published[0].Week; _weeklyIndex = 0; _weeklyClock = 0; }
            if (published[0].Week > _latestWeeklyPublished)
            { _latestWeeklyPublished = published[0].Week; _weeklyWeek = published[0].Week; _weeklyIndex = 0; }
            if (!published.Any(w => w.Week == _weeklyWeek)) { _weeklyWeek = published[0].Week; _weeklyIndex = 0; }
            var select = new OptionButton { Name = "WeeklyEditionSelector", CustomMinimumSize = new Vector2(210, 44) };
            _weeklySelector = select;
            foreach (var edition in published) select.AddItem($"{edition.PeriodLabel} · 第 {edition.StartDay}—{edition.EndDay} 天", edition.Week);
            select.Select(published.FindIndex(w => w.Week == _weeklyWeek));
            select.ItemSelected += index => { _weeklyWeek = select.GetItemId((int)index); _weeklyIndex = 0; _weeklyClock = 0; RenderWeeklySlide(data, false); };
            heading.AddChild(select);
            _weeklyContent = new VBoxContainer { Name = "WeeklyCarousel", SizeFlagsHorizontal = SizeFlags.ExpandFill };
            var viewport = new PanelContainer { ClipContents = true, SizeFlagsHorizontal = SizeFlags.ExpandFill };
            viewport.AddThemeStyleboxOverride("panel", new StyleBoxEmpty());
            viewport.AddChild(_weeklyContent); box.AddChild(viewport); RenderWeeklySlide(data, false);
        }
        else box.AddChild(Text(latest.NewsWork.State == "disabled" ? "开启 AI 后，这里会刊登双周精选。" : "本期精选正在整理，稍后就能阅读。", 17, _muted));
        foreach (var edition in data.WeeklyEditions.Where(w => w.ProfilesWork.State == "failed" || w.NewsWork.State == "failed" || w == latest))
        {
            if (edition.ProfilesWork.State is "failed" or "queued" or "sending") box.AddChild(Text($"第 {edition.Week} 周 · 选手介绍", 14, _muted));
            if (edition.ProfilesWork.State is "failed" or "queued" or "sending") RenderWorkStatus(box, edition.ProfilesWork, () => GenerateContent(() => { _ = AiService.RetryWeeklyAsync(edition.Week, true); }, true), "WeeklyProfiles_" + edition.Week);
            if (edition.NewsWork.State is "failed" or "queued" or "sending") box.AddChild(Text($"第 {edition.Week} 周 · 周刊精选", 14, _muted));
            if (edition.NewsWork.State is "failed" or "queued" or "sending") RenderWorkStatus(box, edition.NewsWork, () => GenerateContent(() => { _ = AiService.RetryWeeklyAsync(edition.Week, false); }, true), "WeeklyNews_" + edition.Week);
        }
    }
    private void RenderWeeklySlide(CareerData data, bool animate)
    {
        if (!IsInstanceValid(_weeklyContent) || _weeklyContent!.IsQueuedForDeletion()) return;
        var issue = data.WeeklyEditions.FirstOrDefault(w => w.Week == _weeklyWeek);
        if (issue == null) return;
        var slides = CameoContent.VisibleSlides(issue);
        if (slides.Count == 0) return;
        _weeklyTween?.Kill();
        string? focusName = GetViewport().GuiGetFocusOwner() is { } focus && _weeklyContent.IsAncestorOf(focus) ? focus.Name.ToString() : null;
        CareerVisuals.ClearContent(_weeklyContent);
        _weeklyIndex = (_weeklyIndex % slides.Count + slides.Count) % slides.Count;
        var slide = slides[_weeklyIndex];
        var row = new HBoxContainer { Name = "WeeklyFeature", SizeFlagsHorizontal = SizeFlags.ExpandFill };
        var featureViewport = new Control { Name = "WeeklyFeatureViewport", CustomMinimumSize = new Vector2(0, 180), SizeFlagsHorizontal = SizeFlags.ExpandFill, ClipContents = true };
        _weeklyContent.AddChild(featureViewport); featureViewport.AddChild(row);
        row.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        row.AddThemeConstantOverride("separation", 24);
        var artButton = Button("", () => OpenWeekly(issue, slide), 240); artButton.Name = "WeeklyArtLink";
        artButton.CustomMinimumSize = new Vector2(240, 170); artButton.TooltipText = "阅读：" + slide.Title;
        artButton.AddChild(WeeklyArt(issue, slide, false)); row.AddChild(artButton);
        var copy = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; row.AddChild(copy);
        copy.AddChild(Text((slide.CeremonySeason > 0 ? "本期封面 · 荣誉特刊" : slide.Advertisement ? "俱乐部推广" : slide.Importance >= 3 ? "本期头条" : "本期精选")
            + (issue.Revision > issue.SeenRevision ? "   ● 新双周刊" : ""), 14, _gold));
        var title = Button(slide.Title, () => OpenWeekly(issue, slide)); title.Name = "WeeklyHeadline";
        title.AutowrapMode = TextServer.AutowrapMode.WordSmart; title.Alignment = HorizontalAlignment.Left;
        title.SizeFlagsHorizontal = SizeFlags.ExpandFill; title.AddThemeFontSizeOverride("font_size", 26); copy.AddChild(title);
        copy.AddChild(Text(slide.Topic, 16, _muted));
        var controls = new HBoxContainer { Name = "WeeklyControls" }; _weeklyContent.AddChild(controls);
        void Change(int index) { _weeklyIndex = index; _weeklyClock = 0; RenderWeeklySlide(data, true); }
        var previous = Button("‹", () => Change(_weeklyIndex - 1), 46); previous.Name = "WeeklyPrevious"; controls.AddChild(previous);
        for (int i = 0; i < slides.Count; i++)
        {
            int index = i;
            var dot = Button(i == _weeklyIndex ? "●" : "○", () => Change(index), 42); dot.Name = "WeeklyDot_" + i;
            dot.TooltipText = slides[i].Advertisement ? "俱乐部推广" : slides[i].Title; controls.AddChild(dot);
        }
        var next = Button("›", () => Change(_weeklyIndex + 1), 46); next.Name = "WeeklyNext"; controls.AddChild(next);
        controls.AddChild(Text($"{_weeklyIndex + 1} / {slides.Count}", 14, _muted));
        var pause = Button(_weeklyAuto ? "暂停轮播" : "自动轮播", () => { _weeklyAuto = !_weeklyAuto; _weeklyClock = 0; RenderWeeklySlide(data, false); }, 112);
        pause.Name = "WeeklyAuto"; controls.AddChild(pause);
        _weeklyProgress = new ProgressBar { Name = "WeeklyProgress", CustomMinimumSize = new Vector2(0, 3), ShowPercentage = false, MaxValue = WeeklyInterval, Step = 0, Value = _weeklyClock, MouseFilter = MouseFilterEnum.Ignore };
        _weeklyProgress.AddThemeStyleboxOverride("background", CareerVisuals.Box("142532", "142532", 0, 0));
        _weeklyProgress.AddThemeStyleboxOverride("fill", CareerVisuals.Box("527e85", "527e85", 0, 0));
        _weeklyContent.AddChild(_weeklyProgress);
        if (focusName != null)
        {
            var target = CareerVisuals.FindContent(_weeklyContent, focusName) as Control;
            if (target != null) Callable.From(() => { if (IsInstanceValid(target) && target.IsInsideTree()) target.GrabFocus(); }).CallDeferred();
        }
        if (animate)
        {
            row.Modulate = new Color(1, 1, 1, .4f);
            _weeklyTween = CreateTween().SetParallel().SetTrans(Tween.TransitionType.Cubic).SetEase(Tween.EaseType.Out);
            _weeklyTween.TweenProperty(row, "modulate:a", 1.0, .28);
            // 从右侧进入，父容器裁切边缘；绘制位置变化不触发整页重新布局。
            _weeklyTween.TweenProperty(row, "position:x", 0f, .28).From(20f);
        }
    }
    private Control WeeklyArt(WeeklyEdition issue, WeeklySlide slide, bool large)
    {
        if (slide.CeremonySeason > 0) return CeremonyWeeklyCover(_boundData, slide, large);
        var art = AvatarAssets.LoadWeekly(_boundData, issue, slide);
        var panel = new PanelContainer { Name = "WeeklyIllustration", MouseFilter = MouseFilterEnum.Ignore };
        panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("10242b", slide.Importance >= 3 ? "d6b77a" : slide.Importance == 2 ? "70d4bc" : "627c86", 10, 4));
        if (!large) panel.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        else { panel.CustomMinimumSize = new Vector2(0, 280); panel.SizeFlagsHorizontal = SizeFlags.ExpandFill; }
        if (art.Texture != null && GodotObject.IsInstanceValid(art.Texture))
            panel.AddChild(new TextureRect { Texture = art.Texture, MouseFilter = MouseFilterEnum.Ignore, ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize,
                StretchMode = large ? TextureRect.StretchModeEnum.KeepAspectCentered : TextureRect.StretchModeEnum.KeepAspectCovered, TooltipText = art.Description });
        else panel.AddChild(Text(slide.Character, 24, _gold));
        return panel;
    }
    private void TickWeekly(double delta)
    {
        if (_tab != "社区" || _postId != null || !IsInstanceValid(_weeklyContent) || !_weeklyContent!.IsVisibleInTree()) return;
        if (!_weeklyAuto || !_weeklyContent.GetGlobalRect().Intersects(_scroll.GetGlobalRect())
            || IsInstanceValid(_weeklySelector) && _weeklySelector!.GetPopup().Visible) return;
        var issue = _boundData.WeeklyEditions.FirstOrDefault(w => w.Week == _weeklyWeek);
        if (issue == null || CameoContent.VisibleSlides(issue).Count < 2) return;
        _weeklyClock += delta;
        if (IsInstanceValid(_weeklyProgress)) _weeklyProgress!.Value = _weeklyClock;
        if (_weeklyClock < WeeklyInterval) return;
        _weeklyClock = 0; _weeklyIndex++; RenderWeeklySlide(_boundData, true);
    }
    private void OpenWeekly(WeeklyEdition issue, WeeklySlide slide) => Visit(() => { _tab = "社区"; _postId = $"weekly:{issue.Week}:{slide.Id}"; });
    private bool RenderWeeklyDetail(CareerData data)
    {
        if (_postId?.StartsWith("weekly:") != true) return false;
        var parts = _postId.Split(':');
        var issue = parts.Length == 3 && int.TryParse(parts[1], out int week) ? data.WeeklyEditions.FirstOrDefault(w => w.Week == week) : null;
        var slide = issue?.Slides.FirstOrDefault(s => s.Id == parts[2]);
        if (issue == null || slide == null) { _content.AddChild(Text("这期周刊尚不可用。", 18, _muted)); return true; }
        issue.SeenRevision = issue.Revision; CareerStore.Save(data);
        AddHeading(slide.Title, $"尖塔双周刊 · {issue.PeriodLabel} · 第 {issue.StartDay}—{issue.EndDay} 天" + (slide.Advertisement ? " · 俱乐部推广" : ""));
        if (slide.CeremonySeason > 0 && data.Ceremonies.Any(c => c.Season == slide.CeremonySeason))
        {
            var ceremony = Button("查看完整颁奖盛典   →", () =>
            { _ceremonySeason = slide.CeremonySeason; _ceremonySection = "获奖名单"; OpenCeremony(); }, 300);
            Emphasize(ceremony); _content.AddChild(ceremony);
        }
        _content.AddChild(WeeklyArt(issue, slide, true));
        var card = Card(); _content.AddChild(card); Inner(card).AddChild(MentionText(data, slide.Body, 21, _ink, slide.People));
        if (CameoContent.FindStory(slide) is { } story)
        {
            var video = Button("▶  珍贵历史影像  ↗", () => OS.ShellOpen(story.Video), 320);
            video.Name = "CameoHistoricalVideo";
            video.CustomMinimumSize = new Vector2(320, 76);
            video.AddThemeColorOverride("font_color", _gold);
            video.AddThemeStyleboxOverride("normal", CareerVisuals.Box("18333d", "d6b77a", 10, 2));
            video.TooltipText = "在浏览器中观看视频";
            _content.AddChild(video);
        }
        if (!slide.Advertisement)
        {
            var people = new HFlowContainer(); _content.AddChild(people);
            foreach (string id in slide.People.Distinct().Take(8)) people.AddChild(Button(CareerEngine.DisplayName(data, id) + " ↗", () => OpenPerson(id), 160));
        }
        _content.AddChild(Button("返回周刊", Back, 160)); return true;
    }
}
