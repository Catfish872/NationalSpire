namespace NationalSpire;

/// <summary>只组合相同情境、相同立场的完整分句；语气词不参与轮换。</summary>
public static class LiveSpeechComposer
{
    private static readonly string[][] RepeatedIdeas =
    [
        ["结束回合", "等下一手", "下回合", "交回合"],
        ["数牌", "数不过", "数不清", "计数员"],
        ["记笔记", "记下来", "得记着"],
        ["重新算", "计算", "算错", "算的"],
        ["下班", "失业", "工作", "出勤", "上班"],
        ["回去重看", "再看一次", "看两遍", "重新看一遍", "录像", "研究"],
        ["我不会", "看不懂", "没看懂", "不理解"],
        ["放一起看", "放一块看", "两张地图", "换地图"],
        ["跟不上", "来不及", "没跟上", "没说完", "跟得上", "解说慢"],
        ["想学", "自己下把", "自己也行", "下把又", "重新学", "自己开一局"]
        , ["商人", "收钱", "老板"]
        , ["先过", "先把自己的", "先顾好", "眼前这", "自己的路走"]
    ];
    public static readonly Dictionary<string, string[]> Endings = Create();
    private static Dictionary<string, string[]> Create()
    {
        var result = new Dictionary<string, string[]>();
        ContentPools.Append(result, """
audience_remove_doubt=这钱拿去买瓶药不好吗？|我是真舍不得，它又不是诅咒。|等打不过了可别说没卡牌用。|以前我还觉得牌越多越安心呢。|删的时候干脆，抽不到的时候怎么办？|反正换我下不去手。
audience_remove_support=别光看数量，等会儿看结果。|有些东西不用带到最后的。|我等着看下一场，你们先争。|他都不心疼，咱们替他心疼什么。|自己不敢试，总得允许别人试吧。|哪次出现新打法不先吵一遍。
audience_remove_curious=我想学，又怕自己学错了。|原来商店还有这种逛法。|我一直把那个按钮当摆设呢。|是多一张反而会碍事吗？|先记着，回头看我能不能懂。|要不是看这场，我还真不敢想。
audience_remove_tease=卡牌也有自己的失业危机。|今天商人的理解也得更新。|下一场怪物还不知道发生了什么。|我先替那张牌委屈三秒。|以后夸牌组不能光看张数了。|收钱这一步商人倒是学得很快。
audience_buy_doubt=我就想听个具体点的理由。|别最后又变成没机会用。|有人跟我想的一样吗？|先留个记号，等会儿看。|可别谁问一句就骂谁不懂。|你们太容易激动了。
audience_buy_support=买回来就有新东西可看了。|别替他保管钱包了。|东西到了他手里，没准真不一样。|我想看他实际用一次。|等会儿看明白了再说呗。|今天能学一点算一点。
audience_buy_curious=我自己经常花完就后悔。|钱够不够是一个问题，会不会用又是一个。|要是讲得明白我下次也试试。|看选手挑东西，挺有意思的。|我收藏夹都快记不下了。|有没有老观众给讲两句？
audience_buy_tease=今天购物车里装的是我的疑问。|下次老板得准备个评论席。|看热闹不收费，我先坐好了。|有的人负责玩，有的人负责替他花钱。|我自己的账还没算明白呢。|又给观众增加一个争论项目。
audience_cards_doubt=至少等这轮打完吧。|别一个回合就开始给人排历史地位。|后面还能不能接，我先打个问号。|你们也别一听质疑就急。|真的每次都能这样吗？|我承认好看，但先别说谁都比不上。
audience_cards_support=我就喜欢看这种一张接一张的。|回头自己打，八成又做不出来。|刚才还嫌牌散，现在不嫌了吧。|我已经不猜什么时候停了。|这手牌到了我这里得少打一半。|先把这段看完，太想知道下一张了。
audience_cards_curious=我以前以为打完手里几张就只能等了。|顺序我还得重新看一遍。|脑子跟不上，眼睛也跟不上。|有没有人能从第一张开始讲？|我现在连自己漏了哪一步都不知道。|我是真的来学的，别只回我一个问号啊。
audience_cards_tease=怪物的准备工作已经做了三遍。|今天这场的计数员不好当。|我手没动，都替鼠标累了。|这回合结束以前外卖能到吗？|我现在怀疑是我平时太礼让对面。|场上一个人在打，场下一群人在数。
audience_draws_doubt=我还是想直接看伤害。|抽出来和用出来是两回事吧。|要是后面卡住就尴尬了。|别看见手牌满了就当赢了。|我倒要看看最后怎么结束。|他自己别被这一手牌绕晕了。
audience_draws_support=至少不用干等下一回合了。|手里有东西才有得选嘛。|我自己最怕要什么都没有。|这轮终于不用替他担心缺牌了。|先看看他会挑哪一张。|这感觉真让人羡慕。
audience_draws_curious=我的牌好像总在不需要的时候来。|是我抽得少，还是我太不会找了。|我以前都不知道能这么主动。|回头我得重新看一遍自己的牌组。|别光说简单，能不能讲讲怎么开始？|他这手里够我研究半天了。
audience_draws_tease=发牌员今天奖金稳了。|我下回合的牌还没送来呢。|原来牌库不是只能排队取号。|怪物继续保持礼貌等候。|这种时候我都想替他拿牌。|先找卡牌，晚点再找游戏理解。
audience_damage_doubt=下回合也得有东西才行吧。|这种画面不能只看最后那个数字。|我先看看后面，不急着夸。|别顺带把其他选手全说成不会玩。|我也想看懂，不想光听尖叫。|有人能解释一下刚才怎么凑的？
audience_damage_support=我真没想到能打成这样。|这比单看卡面有意思多了。|刚才还说不够用的，回头看看啊。|别让数字一闪就过去，我还想多看一眼。|看这一场就够我高兴了。|这牌换我来用，可能真没这个力气。
audience_damage_curious=我看着都一样，结果完全不一样。|最前面那几张是不是很关键？|我自己的顺序肯定有问题。|我都不敢再说这张牌不好用了。|这个能不能单独讲一遍？|我差的可能不只是几张卡牌。
audience_damage_tease=怪物的血量设计跟不上了。|我那点伤害就先不展示了。|这段发出去，得有人问是不是放快了。|卡牌有力气，玩家有脾气。|我刚打出来的建议现在显得很好笑。|今天最该复盘的可能是怪物。
audience_clean_doubt=先别把偶尔打好说成永远打好。|我还是等后面的硬仗。|质疑两句又不是希望他死。|你们别又替他把话说满了。|这次顺，下次能不能一样呢？|反正我先把疑问留着。
audience_clean_support=这比什么吹法都有说服力。|我自己要有这状态，得多看两眼血条。|少挨一次打，后面就多舒服一点。|看得我都想重新试试那几张牌。|刚才那点防守不能白看啊。|这场确实打得让人服气。
audience_clean_curious=我一直以为那些伤害没办法避免。|以前我还会拿少掉一点血安慰自己。|同样的关卡，我怎么总要硬扛。|能不能先讲这场，太想弄明白了。|我不要多快，能这样过关就满足了。|回头自己的录像估计没法看了。
audience_clean_tease=我的治疗药水工作强度太高了。|同一条血，别人存钱，我交房租。|我又开始觉得下把能行了。|等我上手，应该还有别的节目。|怪物打完也得找个人问问。|看完不许立刻去学，我怕又高估自己。
audience_elite_doubt=别带着新手一起学坏了。|换套牌再来一次呢？|我看着都替他后怕。|这打法不是看一遍就会的吧。|夸他就夸他，别顺便踩别人。|我还真不敢往这条路走。
audience_elite_support=这可不是普通小怪啊。|现在知道他敢来这里的原因了。|我自己先把这段记着。|这份奖励拿得太舒服了。|刚才替他担心的时间都白花了。|我今天真长见识了。
audience_elite_curious=我自己过精英跟过年似的。|是不是前几层就在准备这一场了？|别只说轻松，教教我怎么轻松。|我想学，可真有点不敢学。|换我来，这时候背包估计都空了。|我以前只会想着绕过去。
audience_elite_tease=精英回去也得找教练。|今天轮到怪物看选手脸色了。|谁说只有玩家能碰上坏种子。|换我进去，那就是另一档节目了。|怪物还没来得及发表意见。|下次地图上得给他单独做个警告。
audience_quick_doubt=快也不能代替最后过关吧。|我先等一场难一点的。|你们倒是给我点看懂的时间。|别这一场看舒服就什么都夸。|换个起手可能就是另一个情况了。|我只是想看完整点。
audience_quick_support=连我替他着急的时间都省了。|看得太痛快了。|我一回神已经该去下一层了。|先别解释，让我高兴一下。|我平时要是也这样就好了。|这进度看着真提气。
audience_quick_curious=我脑子还停在刚进门的时候。|能不能给刚才那场单独留个录像？|这一手是不是早就想好了？|我上去恐怕第一张都还没选。|真想学，结果只学会了惊讶。|有人跟上了吗，给我讲讲。
audience_quick_tease=这怪上班时间还没动画长。|刚才那条建议已经失去时效了。|现在不敢切出去回消息了。|我眨眼都得挑时间。|原来拦路也算一份高危工作。|怪物想表演都没机会。
audience_boss_support=这下总能好好高兴一下了。|前面那几步真没白准备。|我刚才一直攥着手呢。|先让我缓一下，终于过了。|今晚看这一场值了。|接着往上走，别停在这里。
audience_boss_curious=我刚才光盯着血条了。|最后那个顺序，我真想学。|有没有人把前面的铺垫也讲一讲？|我总是打到这里就乱了。|下次自己遇到我得想起这一场。|先存下来，学不学得会以后再说。
audience_cross_support=光看一张地图都找不全人了。|这已经不是快一点点了。|我看得真有点兴奋了。|同一个时间怎么能差这么多。|对面现在压力得多大。|我就想看最后能走到哪一步。
audience_cross_tease=导播得先学会跨幕通勤。|我刚找着对手，人家又换地方了。|同场这两个字突然有点勉强。|一张地图装不下这场比赛了。|现在加油得分两头喊。|这回真不能只看一个画面。
audience_lead_support=这可是一层层打出来的。|我站这边，没什么好藏的。|别每次都把打得好说成刚好。|继续走，越看越想看。|自己没上场也跟着得意。|对面想追得费点功夫了。
audience_lead_doubt=先把全程打完再说。|夸自己的就行，别把别人一起骂了。|这时候庆祝是不是早了点。|领先的人也可能犯错啊。|后面还有那么多层呢。|我不跟着喊就是不懂了？
audience_danger_support=我这会儿真不想听谁说风凉话。|让他把手里的牌想清楚。|还有一点机会就先别放弃。|刚才都过来了，再撑一下。|我先不乱出主意了。|求一张能派上用场的吧。
audience_danger_tease=这一刻所有老师都安静了。|我自己的鼠标明明没动。|现在只会祈祷，不会分析了。|刚才坐得多歪，现在就有多直。|看个比赛还挺费心脏。|这下真不敢移开视线了。
audience_skip_doubt=后面要用的时候又没有了。|我平时一张都舍不得漏。|再怎么样总有一张能打吧。|他是不是要求有点太高了。|不拿牌拿什么变强啊。|我是真替他着急。
audience_skip_support=不需要就不带，多简单。|别替他的牌组安排工作了。|免费又不是必须接受。|先看下一场，他肯定有打算。|我倒想看看他一直这样会怎样。|自己的牌组自己决定呗。
audience_skip_curious=我以前都默认必须拿一张。|是不是牌少一点也有好处？|先别笑，我真不知道。|我每次都是纠结选哪个。|一个都不选，这个答案我漏了。|等会儿看他还缺不缺吧。
audience_skip_tease=卡牌得重新准备自我介绍了。|这下三家粉丝一起不满意。|我刚写好的推荐词没地方发了。|免费也得排队面试啊。|这个人怎么这么难说服。|换我早就全想带走了。
thought_cross_proud=这次我记住了。|我现在着急也没用。|先把自己的路走完。|别只顾着看别人了。
thought_cross_anxious=先别慌啊。|我越看越不知道该怎么选。|自己还没结束呢。|我得把眼前这一步想清楚。
thought_far_proud=差距摆在这儿，光嘴硬没用。|我还没打算放弃。|回去得看看他怎么打的。|至少这局得认真打完。
thought_far_anxious=我还是想把这局走完。|先不看旁边了吧。|希望后面还能顺一点。|我已经很努力想快点了啊。
thought_behind_proud=自己的牌不能打乱了。|我又不是没在想办法。|等会儿再看他。|我先把这一层过了。
thought_behind_anxious=急也不会多出一张好牌啊。|我得重新看一下。|别点错了就好。|越紧张越不能乱来。
thought_healthy_lead_proud=赛后我得认真看他的录像。|我现在最烦的就是自己看不懂。|别光盼人家失误了。|自己的牌也得接着打。
thought_healthy_lead_anxious=我怎么就做不到呢。|算了，先顾好自己。|光看他也不会变快。|我怕自己一着急又打错。
thought_danger_proud=我还想再找找办法。|就剩这点血，也得认真打。|先别替我下结论。|再看一眼手牌。
thought_danger_anxious=手别抖啊。|这一步真不能乱点。|至少让我把能打的打完吧。|我还想往上走呢。
thought_chance_proud=这回得轮到我争口气了。|先别想赛后说什么。|我自己也不能出错。|机会得靠自己继续打。
thought_chance_anxious=我反而更紧张了。|别在这种时候打错啊。|先把自己的牌看明白。|我真的还想赢一次。
thought_ahead_proud=先别急着笑，最后赢了再说。|这种时候可不能自己犯错。|继续，别停下来得意。|自己的领先得自己留住。
thought_ahead_anxious=我得少看几次进度。|现在就怕自己手快。|先顾好这层吧。|真的不能太早高兴。
thought_hurt_behind_proud=光骂牌也没用，继续找办法。|我还想把这局打下去。|他快他的，先救自己。|这种时候更不能乱来。
thought_hurt_behind_anxious=我不想这么早就结束啊。|先别看他了。|我得把手稳下来。|这关过去再想别的吧。
""");
        ContentPools.Append(result, LiveCommentary.CompositionText);
        ContentPools.Append(result, LiveVoiceCatalog.CrowdTails);
        return result;
    }
    public static bool CanCombine(string main, string tail) => main.Length <= 55
        && !RepeatedIdeas.Any(group => group.Any(main.Contains) && group.Any(tail.Contains))
        && !Enumerable.Range(0, Math.Max(0, tail.Length - 5)).Any(n => main.Contains(tail.Substring(n, 6), StringComparison.Ordinal));

    public static string Compose(string main, string key, BroadcastMemory memory, string seed, int index,
        IReadOnlyDictionary<string, string>? facts = null)
    {
        if (main.Length > 55 || !Endings.TryGetValue(key, out var bank)
            || CareerEngine.StableHash(seed + ":compose:" + key + index) % 5 >= 2) return main;
        string historyKey = "$voice-tail:" + key;
        var recent = memory.SharedPhrases.GetValueOrDefault(historyKey, []);
        int start = CareerEngine.StableHash(seed + ":ending:" + key + index) % bank.Length;
        for (int i = 0; i < bank.Length; i++)
        {
            string tail = bank[(start + i) % bank.Length];
            if (recent.Contains(tail) || !CanCombine(main, tail)) continue;
            string rendered = tail;
            if (facts != null) foreach (var (k, v) in facts) rendered = rendered.Replace("{" + k + "}", v, StringComparison.Ordinal);
            if (rendered.Contains('{')) continue;
            recent.Add(tail); if (recent.Count >= bank.Length) recent.RemoveAt(0);
            memory.SharedPhrases[historyKey] = recent;
            return main + (main.EndsWith('。') || main.EndsWith('！') || main.EndsWith('？') || main.EndsWith('…') ? "" : "。") + rendered;
        }
        return main;
    }
}
