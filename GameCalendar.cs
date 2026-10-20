using System.Globalization;
using System.Text.Json.Nodes;

namespace NationalSpire;

/// <summary>公历显示与内部累计天数共用换算，起始年份随生涯保存。</summary>
public static class GameCalendar
{
    public static bool Initialize(CareerData data)
    {
        if (data.CalendarStartYear != 0) return false;
        data.CalendarStartYear = DateTime.Now.Year;
        return true;
    }
    // 尚未打开的旧存档只预览升级年份；实际载入时由 Initialize 固定并随原保存流程提交。
    private static DateOnly Epoch(CareerData data) => new(data.CalendarStartYear == 0 ? DateTime.Now.Year : data.CalendarStartYear, 1, 1);
    public static DateOnly Date(CareerData data, int day) => Epoch(data).AddDays(day - 1);
    public static int Day(CareerData data, DateOnly date) => date.DayNumber - Epoch(data).DayNumber + 1;
    public static string Text(CareerData data, int day) => Date(data, day).ToString("yyyy年M月d日", CultureInfo.InvariantCulture);
    public static string Iso(CareerData data, int day) => Date(data, day).ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
    public static int Season(CareerData data, int day)
    {
        int change = data.LongSeasonsFrom > 0 ? (data.LongSeasonsFrom - 1) * 28 : int.MaxValue;
        return day > change ? data.LongSeasonsFrom + (day - change - 1) / 84 : (day - 1) / 28 + 1;
    }
    public static bool TryDay(CareerData data, string? text, out int day)
    {
        day = 0;
        if (!DateOnly.TryParseExact(text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out var date)) return false;
        day = Day(data, date);
        return day > 0;
    }
    public static string Range(CareerData data, int first, int last) => first == last ? Text(data, first) : Text(data, first) + "至" + Text(data, last);
    public static bool ConvertDateField(CareerData data, JsonObject obj, string key)
    {
        if (!(key.Equals("day", StringComparison.OrdinalIgnoreCase) || key.EndsWith("Day", StringComparison.Ordinal))) return false;
        var value = obj[key];
        if (value != null && !(value is JsonValue date && date.TryGetValue<int>(out _))) return false;
        int day = value?.GetValue<int>() ?? 0;
        obj.Remove(key);
        obj[key[..^3] + (key == "day" ? "date" : "Date")] = day > 0 ? Iso(data, day) : null;
        return true;
    }
    public static void ConvertJsonDates(CareerData data, JsonNode node)
    {
        if (node is JsonObject obj)
            foreach (string key in obj.Select(p => p.Key).ToArray())
                if (!ConvertDateField(data, obj, key) && obj[key] is { } child) ConvertJsonDates(data, child);
        if (node is JsonArray array)
            foreach (var child in array) if (child != null) ConvertJsonDates(data, child);
    }
    public static bool NormalizeFields(CareerData data, Dictionary<string, string> fields)
    {
        if (!fields.TryGetValue("Date", out var value)) return true;
        if (!TryDay(data, value, out int day)) return false;
        fields["Season"] = Season(data, day).ToString(CultureInfo.InvariantCulture);
        fields["Day"] = SeasonCalendar.Day(data, day).ToString(CultureInfo.InvariantCulture);
        return true;
    }
}
