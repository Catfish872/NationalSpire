namespace NationalSpire;

/// <summary>Optional scene integration points. With no registered extension these retain core behavior.</summary>
public static class DateSceneExtensions
{
    public static Func<CareerScreen>? CreateCareerScreen { get; set; }
    public static Func<DateSceneView>? CreateView { get; set; }
    public static IDateSceneExtension? Current { get; set; }
    public static DateSceneView NewView() => CreateView?.Invoke() ?? new DateSceneView();
    public static IEnumerable<string> MetadataFields => new[] { "Scene", "Emotion", "Background", "Speaker" }
        .Concat(Current?.MetadataFields ?? []);
}

public interface IDateSceneExtension
{
    IEnumerable<string> MetadataFields { get; }
    string Guidance(DateSceneRequest scene, bool tools);
    void Materials(DateSceneRequest scene, Dictionary<string, object?> materials);
    void ReplySchema(DateSceneRequest scene, Dictionary<string, object> properties);
    string ReplyExample(DateSceneRequest scene);
    string HistoryCue(DateSceneLine line);
    bool MergeHistory(DateSceneLine first, DateSceneLine next);
    string[] RequiredMetadata(DateSceneRequest? scene);
    void ReadSegment(DateSceneRequest scene, Dictionary<string, string>? fields, List<DateSceneLine> lines);
    void SplitLine(DateSceneLine original, DateSceneLine part, int index);
    void RecordTurn(DateMemoryTurn entry, DateSceneRequest scene);
    void DeleteMemory(CareerData data, string offer);
    DateSceneRequest RefreshRequest(CareerData data, string person, DateSceneRequest previous, DateSceneRequest? current);
}
