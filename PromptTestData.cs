namespace NationalSpire;

public sealed record PromptTestSource(string Scene, string Id, string Label, int Week = 0);
public sealed class PromptTestSession
{
    public required PromptTestSource Source { get; init; }
    public string Message { get; init; } = "";
    public AiWorkState Work { get; } = new();
    public string Previous { get; internal set; } = "";
    public string Result { get; internal set; } = "";
    public bool Running { get; internal set; }
    internal CareerData Snapshot { get; init; } = null!;
    internal CareerData Owner { get; init; } = null!;
    public string Context { get; internal init; } = "";
    internal string TargetId { get; init; } = "";
}
