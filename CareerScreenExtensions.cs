using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    protected virtual DateSceneRequest ConfigureDateRequest(DateSceneRequest request) => request;
    protected virtual void DateViewOpened() { }
    protected virtual void DateViewClosing() { }
    protected virtual bool BeforeDateTick() => true;
    protected virtual void DateLineShown(DateSceneLine line, string? turn = null, int index = -1) { }
    protected virtual void DatePlaybackInterrupted(bool clearWork = false) { }
    protected virtual void AddDateSettings(VBoxContainer box) { }
    protected virtual void OpenDateMemoryChoice(CareerData data, string person, DateSceneMemory memory) => OpenDateMemory(data, person, memory);
    protected virtual DateMemoryPlayback CreateDateMemoryPlayback(CareerData data, DateSceneMemory memory)
        => new() { Memory = memory, Blocked = () => _dialogOverlay != null };
}
