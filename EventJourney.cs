namespace NationalSpire;

/// <summary>保存途中停留的目的日期；日期模拟与自动生成分别处理。</summary>
public sealed class EventJourney
{
    public int Destination { get; set; }
    public int PausedDay { get; set; }
    [System.Text.Json.Serialization.JsonIgnore] public bool ResumePublications { get; set; }

    public static bool PublicationsPaused(CareerData data) => data.Journey.PausedDay == data.Day;
    public static void Begin(CareerData data, int destination)
    {
        Resume(data);
        data.Journey.Destination = destination;
    }
    public static void Resume(CareerData data)
    {
        if (data.Journey.PausedDay > 0) data.Journey.ResumePublications = true;
        data.Journey.PausedDay = 0;
        data.Journey.Destination = 0;
    }
    public static bool Stop(CareerData data, int destination, bool ordinaryStop, bool hasEvent)
    {
        if (ordinaryStop || data.Day >= destination) { data.Journey.Destination = 0; return ordinaryStop; }
        if (!hasEvent) return false;
        data.Journey.Destination = destination;
        data.Journey.PausedDay = data.Day;
        return true;
    }
}
