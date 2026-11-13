using MegaCrit.Sts2.Core.Runs;

namespace NationalSpire;

/// <summary>统一管理游戏模式、原生进阶与赛事记录进阶之间的换算。</summary>
public static class MatchModes
{
    public const string Standard = "Standard", Blitz = "Blitz", Dread = "Dread";
    public static readonly string[] All = [Standard, Blitz, Dread];
    public static bool Available(string mode) => All.Contains(mode) && Enum.TryParse<GameMode>(mode, out _);
    public static GameMode Native(string mode) => Enum.Parse<GameMode>(mode);
    public static string Name(string mode) => mode switch { Blitz => "快速模式", Dread => "恐惧模式", _ => "普通模式" };
    public static int Minimum(string mode, int required) => mode == Dread ? 10 : mode == Blitz ? (required + 1) / 2 : required;
    public static int Maximum(string mode) => mode == Blitz ? 5 : 10;
    public static int RecordedAscension(string mode, int native) => mode == Blitz ? native * 2 : mode == Dread ? 10 : native;
    public static int NativeAscension(string mode, int recorded) => mode == Blitz ? (recorded + 1) / 2 : mode == Dread ? 10 : recorded;
    public static bool Valid(string mode, int required, int recorded)
        => Available(mode) && NativeAscension(mode, recorded) is var level
            && level >= Minimum(mode, required) && level <= Maximum(mode)
            && RecordedAscension(mode, level) == recorded;
    public static string ForMatch(CareerMatch match) => match.ChosenMode ?? Standard;
    public static string Preferred(CareerData data, CareerMatch match)
    {
        string mode = match.ChosenMode ?? data.SelectedMode;
        return Available(mode) ? mode : Standard;
    }
    public static int PreferredLevel(CareerData data, CareerMatch match, string mode)
    {
        int value = match.ChosenMode == mode && match.ChosenAscension is { } chosen ? NativeAscension(mode, chosen)
            : mode == Blitz ? data.SelectedBlitzAscension ?? Minimum(mode, match.RequiredAscension)
            : mode == Dread ? 10 : match.ChosenMode == null ? match.ChosenAscension ?? data.SelectedAscension : data.SelectedAscension;
        return Math.Clamp(value, Minimum(mode, match.RequiredAscension), Maximum(mode));
    }
    public static void Select(CareerData data, CareerMatch match, string mode, int native)
    {
        // 对手使用赛事进阶；只有切换快速模式才会改变其总用时与地图路线。
        if ((ForMatch(match) == Blitz) != (mode == Blitz))
        { match.OpponentPrepared = false; match.OpponentSeconds = null; match.Live = null; }
        match.ChosenMode = data.SelectedMode = mode;
        match.ChosenAscension = RecordedAscension(mode, native);
        if (mode == Blitz) data.SelectedBlitzAscension = native;
        else if (mode == Standard) data.SelectedAscension = native;
    }
    public static int PendingNativeAscension(CareerData data)
    {
        var match = data.Matches.FirstOrDefault(m => m.Id == data.PendingMatchId);
        return match == null ? data.SelectedAscension
            : NativeAscension(ForMatch(match), match.ChosenAscension ?? data.SelectedAscension);
    }
    public static double RivalTimeScale(string mode) => mode == Blitz ? 2.0 / 3 : 1;
}
