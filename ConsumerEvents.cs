namespace NationalSpire;

/// <summary>消费先记录生活事件，由现有日期推进流程汇总发帖。</summary>
public static class ConsumerEvents
{
    public static void Purchase(CareerData data, string detail, IReadOnlyList<string> guests)
    {
        string human = GroupChats.Human(data), prefix = human + "/shop-batch-";
        var people = new[] { human }.Concat(guests).Distinct().ToList();
        // 已进入帖子或周刊的事件不追加事实，后续购买另开一条待发布记录。
        var entry = data.Life.Events.LastOrDefault(e => e.Id.StartsWith(prefix, StringComparison.Ordinal)
            && e.Day == data.Day && e.PostId.Length == 0 && e.EditionWeek == 0);
        if (entry == null)
        {
            CareerLife.AddEvent(data, prefix + data.Life.Consumer.PurchaseCount, "消费与生活",
                CareerEngine.Name(data) + "的购物与消费", detail, people);
            return;
        }
        entry.Detail += "\n" + detail;
        entry.People = entry.People.Concat(people).Distinct().ToList();
        var fact = data.CommunityMemories.FirstOrDefault(m => m.Id == "life-fact:" + entry.Id);
        if (fact != null) { fact.Text = entry.Title + "：" + entry.Detail; fact.People = entry.People.ToList(); }
    }
    public static void Activity(CareerData data, Good good, GoodVerb verb, IReadOnlyList<string> guests, bool planned = false)
    {
        string human = GroupChats.Human(data);
        string people = string.Join("、", guests.Select(id => CareerEngine.DisplayName(data, id)));
        CareerLife.AddEvent(data, human + "/party-" + data.Life.Consumer.PartyCount, "消费与生活", verb.Name + (planned ? "已约定" : "已完成"),
            $"{CareerEngine.Name(data)}使用{good.Name}安排的{verb.Name}" + (planned ? "已得到邀约对象接受，具体安排见日程。" : "已经结束。")
            + (people.Length > 0 ? "参加者：" + people + "。" : ""), [human, .. guests]);
    }
}
