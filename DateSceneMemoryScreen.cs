using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private DateMemoryRecorder? _dateMemory;
    private string _dateMemoryKey = "";
    private bool _dateRecording;
    private readonly Dictionary<ulong, string> _dateMemoryImages = [];
    private DateMemoryPlayback? _dateMemoryPlayback;

    private string RememberDateImage(Texture2D texture)
    {
        ulong id = texture.GetInstanceId();
        if (_dateMemoryImages.TryGetValue(id, out string? image)) return image;
        string? existing = _dateTextures.FirstOrDefault(p => p.Value == texture && p.Key.Length == 64).Key;
        if (!string.IsNullOrEmpty(existing)) return _dateMemoryImages[id] = existing;
        using var pixels = texture.GetImage(); byte[] bytes = pixels.SavePngToBuffer();
        string hash = DateSceneAssetStore.Hash(bytes); DateSceneAssetStore.Store(bytes, hash);
        return _dateMemoryImages[id] = hash;
    }
    private void BeginDateMemory(CareerData data, PrivateOffer offer)
    {
        string key = DateSceneMemories.FilePath(data, offer.Id);
        _dateRecording = DateSceneMemories.Recording;
        if (_dateMemoryKey != key || _dateMemory == null)
        {
            _dateMemoryImages.Clear();
            var saved = DateSceneMemories.Read(data, offer.Id);
            _dateMemory = new(saved ?? new() { OfferId = offer.Id, Host = _datePerson, Title = offer.Title, Season = offer.Season, Day = offer.Day, Player = CareerEngine.Name(data) });
            _dateMemoryKey = key;
        }
        RefreshDateMemoryPeople(); SyncDateMemory();
    }
    private void RefreshDateMemoryPeople()
    {
        if (_dateMemory == null) return;
        foreach (var (person, art) in _datePartyArt)
        {
            if (_dateMemory.Memory.People.ContainsKey(person)) continue;
            string fallback = RememberDateImage(PartyTexture(person, art.Design.DefaultEmotionId));
            var entry = new DateMemoryPerson { Name = CareerEngine.DisplayName(ViewData, person), Default = fallback };
            foreach (var emotion in art.Design.Emotions.Where(e => e.Enabled))
                entry.Emotions[emotion.Id] = _dateDefaultPeople.Contains(person) ? fallback
                    : DateSceneAssetStore.SpriteKeys(art.Assets, art.Design, emotion.Id).Select(k => art.Assets.Sprites[k]).FirstOrDefault() ?? fallback;
            _dateMemory.Memory.People[person] = entry; _dateMemory.Dirty = true;
        }
    }
    private void SyncDateMemory()
    {
        if (_dateMemory == null || _datePerson.Length == 0 || DateSceneMemories.FilePath(ViewData, _dateOffer) != _dateMemoryKey) return;
        _dateMemory.Sync(PrivateMessages.Conversation(ViewData, _datePerson));
    }
    private void CaptureDateMemory()
    {
        if (_dateMemory == null || _dateView == null || _dateAssets == null || _dateIndex >= _dateLines.Count) return;
        try
        {
            RefreshDateMemoryPeople();
            var frame = _dateView.CaptureMemoryFrame(RememberDateImage);
            frame.Background = DateSceneBackgrounds.ResolveImage(frame.Background);
            var assets = _dateAssets;
            frame.FontSize = assets.FontSize; frame.Fade = assets.PanelFade; frame.Spacing = assets.LetterSpacing;
            frame.Scale = assets.SpriteScale; frame.X = assets.SpriteX; frame.Y = assets.SpriteY; frame.Outline = assets.TextOutline;
            frame.Blur = assets.BlurAmount; frame.Badge = assets.ShowAffectionBadge;
            var relation = PrivateMessages.Relation(ViewData, frame.Speaker.Length > 0 ? frame.Speaker : _datePerson);
            frame.Favour = relation.Favour; frame.Relationship = relation.Relationship; frame.Bond = relation.SelectedBond; frame.Oath = relation.OathConfirmed;
            _dateMemory.Capture(_dateTurn, _dateIndex, _dateLines[_dateIndex], frame);
            if (_dateBackground.Length > 0) _dateMemory.Memory.Backgrounds[_dateBackground] = frame.Background;
        }
        catch (Exception e) { _dateView.Status.Text = "回忆画面记录失败：" + e.Message; }
    }
    private void SaveDateMemory(bool end = false)
    {
        if (_dateMemory == null || _datePerson.Length == 0 || DateSceneMemories.FilePath(ViewData, _dateOffer) != _dateMemoryKey) return;
        try
        {
            if (_dateState is "complete" or "streaming" && _dateView?.InputMode == false) CaptureDateMemory();
            SyncDateMemory();
            if (_dateRecording)
            {
                if (end) { _dateMemory.Memory.Ended = true; _dateMemory.Dirty = true; }
                if (!_dateMemory.Dirty) return;
                foreach (string id in _dateMemory.Memory.Turns.SelectMany(t => t.Lines).Select(l => l.Background).Where(s => s.Length > 0).Distinct())
                    if (!_dateMemory.Memory.Backgrounds.ContainsKey(id) && _dateBackgrounds.FirstOrDefault(b => b.Id == id) is { } background)
                        _dateMemory.Memory.Backgrounds[id] = DateSceneBackgrounds.ResolveImage(background.Image);
                DateSceneMemories.Save(ViewData, _dateMemory.Memory); _dateMemory.Dirty = false;
            }
            else if (end && DateSceneMemories.Read(ViewData, _dateOffer) is { } saved)
            { saved.Ended = true; DateSceneMemories.Save(ViewData, saved); }
        }
        catch (Exception e)
        {
            if (_dateView != null && IsInstanceValid(_dateView)) _dateView.Status.Text = "回忆保存失败：" + e.Message;
            GD.PushWarning("[NationalSpire] 回忆保存失败：" + e.Message);
        }
    }
    private void AddDateMemorySetting(VBoxContainer box)
    {
        var record = new CheckBox { Name = "DateRecordMemory", Text = "保留所有约会对话", ButtonPressed = _dateRecording };
        box.AddChild(record); box.AddChild(Text("保存在本机，可从约会日记进入回忆。此设置持续应用于之后的约会。", 16, _muted));
        record.Toggled += value =>
        {
            try
            {
                if (!value) SaveDateMemory();
                DateSceneMemories.Recording = value; _dateRecording = value;
                if (value) { CaptureDateMemory(); if (_dateMemory != null) _dateMemory.Dirty = true; SaveDateMemory(); }
            }
            catch (Exception e) { record.SetPressedNoSignal(_dateRecording); Notice(e.Message, true); }
        };
    }
    private void OpenDateMemory(CareerData data, string person, DateSceneMemory memory)
    {
        if (_dateMemoryPlayback != null) return;
        _cancelDialog?.Invoke();
        var replay = new DateMemoryPlayback { Memory = memory, Blocked = () => _dialogOverlay != null };
        replay.DeleteReply = id => DeleteDateHistoryReply(memory.Host, memory.OfferId, id, memory, replay.RefreshHistory);
        _dateMemoryPlayback = replay;
        replay.Closed = () =>
        {
            _dateMemoryPlayback = null;
            if (IsInsideTree() && CareerStore.IsCurrent(data)) DateDiaryEntryDialog(data, person, memory.OfferId);
        };
        _stage.AddChild(replay);
    }
}
