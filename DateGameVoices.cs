namespace NationalSpire;

/// <summary>共享赛事事实与触发条件，在约会播报处应用玩家选择的口吻；全过程使用本地台词。</summary>
public static class DateGameVoices
{
    public static readonly string[] Ids = ["male", "female", "tsundere", "quiet", "playful", "teasing", "caring"];
    public static readonly string[] Labels = ["男性默认", "女性默认", "傲娇", "无口", "抖M", "雌小鬼", "小妈妈"];
    // 六列依次为女性默认和五种性格。事实正文由原解说系统提供，保留卡牌、伤害、路线及对手进度。
    internal static readonly Dictionary<string, string[]> Remarks = new()
    {
        ["start"] = ["一起慢慢打完这局。", "准备好啦？我今天也想赢一回。", "准备好了。一起。", "认真和我打一局吧，赢了我也要教教我。", "让我看看你的本事。", "都准备好了，我们一起出发。"],
        ["danger"] = ["我陪你看清这一回合。", "先看清楚伤害，刚才吓我一跳。", "慢一点。我陪你看。", "呜，先一起把这一关过了吧。", "这下要认真起来了吧？我陪你看。", "手先放慢，把眼前这回合算清楚。"],
        ["loss"] = ["回头一起看看这步的选择。", "唔，这一手得记住，下次我要打回来。", "记下了。下次再来。", "呜，好厉害……再教我一次刚才那手吧。", "这手被抓到了，下回我会找回来的。", "这一局的经验记下来，我陪你复盘。"],
        ["win"] = ["这一段打得很漂亮。", "哼哼，这一手确实值得夸。", "漂亮。记住这手。", "哇，这手看得我都想再挑战一次了。", "还挺厉害的嘛，再让我看看。", "辛苦了，这一段打得很稳。"],
        ["fast"] = ["我想听听你刚才的思路。", "走这么快，还能分点注意力给我吧？", "好快。怎么想的？", "呜，跟得好辛苦，等会儿教教我嘛。", "跑得挺快嘛，后面我可要追你了。", "节奏很顺，记得也照顾好生命。"],
        ["ahead"] = ["我想把这个节奏继续保持下去。", "哼哼，看到我的进度了吧？", "继续。这个节奏很好。", "这次轮到我在前面了，还想认真和你比下去。", "追得到我吗？我可继续走了。", "这一段很顺，稳稳把后面也打好。"],
        ["behind"] = ["我先专心处理自己这一层。", "唔，让我把这手打好，我还想追上来。", "先看眼前。还能继续。", "呜，被你拉开了，更想学学你的打法了。", "先让你走一会儿，我还在打呢。", "按自己的节奏走，把每一层看清楚。"],
        ["shop"] = ["我想看看这次调整会怎样发挥。", "买好了就给我看看效果吧。", "记住这次选择。", "你来看看我的选择，认真挑出问题也可以。", "选好了？等会儿让我看看值不值。", "选好以后，把后面要用的资源也留意一下。"],
        ["cards"] = ["这几张牌的配合值得记下来。", "这配合我看清了，下回也要试试看。", "这个顺序。记下了。", "这手好漂亮，轮到我时你也认真指点我吧。", "这手有点意思，藏了什么好配合？", "牌序处理得很仔细，我在旁边看着。"],
        ["act"] = ["我们一起准备下一段路。", "过了！接下来我也会认真打。", "下一幕。一起走。", "呼，又过了一幕，还想继续跟着你学。", "这才刚热起来，下一幕继续。", "辛苦了，稍微松口气再看后面的路线。"],
        ["thought"] = ["我再认真看看手上的选择。", "我也想把这局打得漂亮一点。", "再看一眼。", "认真一点，希望这局能让你多看看我。", "我也有自己的打算，等着看吧。", "先把眼前照顾好，一步一步走。"],
        ["ambient"] = ["一起玩的时候，我也很在意你的思路。", "我在看着呢，好好打给我看吧。", "我在看。", "再陪我认真玩一会儿吧。", "我可一直在看你怎么打。", "慢慢来，我会陪你把这一局打完。"]
    };
    public static string Default(CareerData data, string person) => IdentityGender.Of(data, person) == "女" ? "female" : "male";
    public static string Version(CareerData data, DateGameState game, string person)
        => game.Voices.TryGetValue(person, out var id) && Ids.Contains(id) ? id : Default(data, person);
    public static string Family(string topic)
    {
        topic = topic.Split('/')[0];
        if (topic == "gold-spent") return "shop";
        if (topic is "elite-fast" or "boss-fast") return "win";
        if (topic == "floor-gap") return "fast";
        if (topic == "start") return "start";
        if (topic.Contains("danger") || topic.Contains("hurt") || topic.Contains("damage") && topic.StartsWith("npc")) return "danger";
        if (topic.Contains("dead") || topic.Contains("death") || topic.Contains("lost")) return "loss";
        if (topic is "act1" or "act2" || topic.Contains("boss")) return "act";
        if (topic.Contains("clean") || topic.Contains("champion") || topic.Contains("finished")) return "win";
        if (topic.Contains("behind") || topic.Contains("far")) return "behind";
        if (topic.Contains("ahead") || topic.Contains("lead")) return "ahead";
        if (topic.Contains("quick") || topic.Contains("fast")) return "fast";
        if (topic.StartsWith("shop") || topic.Contains("reward")) return "shop";
        if (topic.Contains("card") || topic.Contains("draw") || topic.Contains("energy") || topic.Contains("damage")) return "cards";
        return topic.StartsWith("thought") ? "thought" : "ambient";
    }
    public static string Style(CareerData data, DateGameState game, string person, string topic, string text)
    {
        string profile = Version(data, game, person);
        return Finish(data, profile, topic, DateGameContent.RewritePhrase(data, profile, text));
    }
    public static IReadOnlyList<string> EventLines(CareerData data, string profile, DateGameRule rule)
        => data.DateGameVoiceEdits.GetValueOrDefault(profile)?.Triggers.GetValueOrDefault(rule.Trigger)
            ?? rule.Lines.Select(line => Finish(data, profile, rule.Trigger, DateGameContent.RewritePhrase(data, profile, line))).ToList();

    public static string Event(CareerData data, DateGameState game, DateGameCue cue, int choice)
    {
        string profile = Version(data, game, cue.Person), trigger = cue.Key.Split('/')[0];
        var lines = data.DateGameVoiceEdits.GetValueOrDefault(profile)?.Triggers.GetValueOrDefault(trigger);
        return lines is { Count: > 0 } ? lines[(choice & int.MaxValue) % lines.Count]
            : Style(data, game, cue.Person, cue.Key, cue.Text);
    }
    public static string Style(CareerData data, DateGameState game, string person, BroadcastLine line)
    {
        string profile = Version(data, game, person);
        string text = line.Rewrite == null ? DateGameContent.RewritePhrase(data, profile, line.Text)
            : line.Rewrite(source => DateGameContent.RewritePhrase(data, profile, source));
        return Finish(data, profile, line.Topic, text);
    }
    private static string Finish(CareerData data, string profile, string topic, string text)
    {
        int version = Array.IndexOf(Ids, profile);
        string remark = DateGameContent.Remark(data, profile, Family(topic), version <= 0 ? "" : Remarks[Family(topic)][version - 1]);
        if (version <= 0) return text + (remark.Length > 0 ? " " + remark : "");
        string source = text.Replace(CareerEngine.Name(data), "你").Replace("这家伙", "你").Replace("这小子", "你");
        if (topic.StartsWith("thought")) source = System.Text.RegularExpressions.Regex.Replace(source, @"(?<=^|[。！？，…])他(?=这|那|的|比|先|还|在|想|会|追|怎么)", "你");
        // 女性默认收敛强硬赛事用语；其余版本沿用事实句，接续对应情境的本地口吻。
        source = source.Replace("狠狠干", "认真打").Replace("干掉", "击败").Replace("牛逼", "漂亮").Replace("卧槽", "真厉害");
        return source.TrimEnd() + (remark.Length > 0 ? " " + remark : "");
    }
}
