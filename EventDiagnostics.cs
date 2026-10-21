using System.Text;
using System.Text.Json;

namespace NationalSpire;

public static partial class Diagnostics
{
    private static readonly HashSet<string> EventChecks = [];
    private static readonly Queue<string> EventCheckOrder = [];
    /// <summary>每轮请求、回复和检查现场完整追加，统一保留最近五份文件。</summary>
    internal static void RecordEvent(string context, string attempt, string stage, object detail)
    {
        using var measure = new LogMeasure(LogWork.Record, "event." + stage);
        try
        {
            string body;
            using (new LogMeasure(LogWork.Serialize, "event." + stage))
                body = JsonSerializer.Serialize(new { utc = DateTimeOffset.UtcNow, version = ModVersion, context, attempt, stage, detail }, Json);
            body = Redact(body);
            using var writing = new LogMeasure(LogWork.Write, "event." + stage);
            WriteLog("random-events.jsonl", body);
        }
        catch (Exception error) { Error("event.diagnostics", error); }
    }

    internal static void RecordEventCheck(CareerData data, RandomEventRecord record, RandomEventOption option, string error)
    {
        // 同一选项的相同错误只记录一次，界面刷新复用检查时不反复写入正文。
        try
        {
            string context = AiService.EventKey(data, record.Id);
            string signature = TraceKey(context + error + JsonSerializer.Serialize(option, Json));
            lock (Gate)
            {
                if (_directory == null || !EventChecks.Add(signature)) return;
                EventCheckOrder.Enqueue(signature);
                while (EventCheckOrder.Count > 512) EventChecks.Remove(EventCheckOrder.Dequeue());
            }
            RecordEvent(context, signature, "effect-check", new
            {
                error, data.Day, data.Season, player = new { id = GroupChats.Human(data), name = CareerEngine.Name(data) },
                participants = record.People, record,
                optionIndex = record.Options.IndexOf(option), custom = ReferenceEquals(record.CustomOption, option), option,
                targets = option.Effects.Where(e => e.Keys.Any(k => k is "favour" or "impression" or "status" or "learning" or "challenge"))
                    .Select(e => new { effect = e, target = e.GetValueOrDefault(RandomEventEffects.Kind(e)),
                        exists = e.GetValueOrDefault(RandomEventEffects.Kind(e)).ValueKind == JsonValueKind.String
                            && PrivateMessages.CanChat(data, e[RandomEventEffects.Kind(e)].GetString()!) }).ToArray(),
                walletDollars = CareerMoney.Balance(data) * 10, data.Fans, clubOwner = OwnedClubs.IsOwner(data),
                ownedClub = data.Esports.OwnedClub, inventory = data.Life.Consumer.Goods
            });
        }
        catch (Exception failure) { Error("event.diagnostics.check", failure); }
    }

    private static string ReadEventRecords()
    {
        try
        {
            return string.Join('\n', ReadLogs("random-events.jsonl").Select(p => p.Value.TrimEnd('\n'))
                .Concat(LegacyLogs("random-events", "*.json").Select(p => p.Value)));
        }
        catch (Exception error) { Error("event.diagnostics.read", error); return ""; }
    }
}
