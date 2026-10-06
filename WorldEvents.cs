namespace NationalSpire;

/// <summary>世界日常按题材与人物轮换；赛事与人物的真实状态用于筛选素材。</summary>
public static class WorldEvents
{
    private sealed record Topic(string Key, string Title, string Detail);
    private static readonly Topic[] Topics = [
        new("观众", "{人}遇到远道而来的观众", "{人}在{队}的观众活动中见到了专程赶来的支持者，现场留下了一张合照。"),
        new("观众", "{队}征集新赛季应援图", "{队}向观众征集应援设计，{人}挑选了几份自己喜欢的作品。征集仍在进行。"),
        new("观众", "一张旧门票又被翻了出来", "观众在{队}的交流活动中带来一张早期赛事门票，{人}聊起了那个时期的参赛经历。"),
        new("生活", "{人}分享了一份客场歌单", "{人}在社区分享了出行时常听的音乐，留言里有人推荐了同一支乐队。"),
        new("生活", "{人}晒出新做的杯子", "{人}在休息日体验陶艺，做出的杯口有些歪，仍决定留在训练桌上使用。"),
        new("生活", "{人}的相册里多了几张街景", "{人}整理近期出行拍下的街景，观众在照片里认出了熟悉的街角。"),
        new("生活", "{人}尝试了一道当地菜", "{人}参加了一次地方料理体验，把手写食谱带回了住处。"),
        new("生活", "{人}分享了书架的一角", "{人}贴出最近阅读的书，社区话题从比赛转到了各自喜欢的故事。"),
        new("生活", "{人}给训练桌换了布置", "{人}整理桌面，把观众赠送的纪念品放在了显示器旁边。"),
        new("生活", "{人}在休息日去了小剧场", "{人}分享了当地剧团的节目单，有观众发现彼此看过同一场演出。"),
        new("生活", "{人}加入了一场桌游聚会", "{人}和几位圈内朋友在休息时玩了桌游，合照里还留着没有收好的棋子。"),
        new("生活", "{人}晒出了自己的绿植", "{人}在社区分享桌边绿植的近照，几个观众认真讨论起了浇水频率。"),
        new("创作", "社区画师给{人}画了新头像", "一位社区创作者根据{人}的公开形象画了一张头像，{人}署名转发并表达感谢。"),
        new("创作", "{队}公开一组幕后照片", "{队}发布了一组准备比赛的幕后照片，{人}出现在其中一张合照里。"),
        new("创作", "{人}参与录制观众问答", "{人}回答了关于客场生活和兴趣的问题，这期内容已经在社区公开。"),
        new("创作", "{队}的应援短片上线", "社区创作者完成了{队}的应援短片，使用的赛事镜头注明了来源，{人}转发了作品。"),
        new("创作", "{人}收到一份手工纪念品", "观众送来一件手工制作的参赛纪念品，{人}把它放进了个人收藏。"),
        new("创作", "{队}征集队史旧照片", "{队}开始整理旧照片和物件，{人}也找出了一份早期活动资料。"),
        new("公益", "{人}参加社区义卖", "{人}为当地义卖提供了签名纪念品，主办方在活动结束后公布了收支。"),
        new("公益", "{队}开放外设借用登记", "{队}整理出一批可用的备用外设，开放给本地社区活动登记借用。{人}参加了设备整理。"),
        new("公益", "{人}参加校园兴趣交流", "{人}到当地兴趣社团介绍参赛生活，学生们准备了不少关于比赛的问题。"),
        new("社区", "{人}出现在地方观赛聚会", "{人}参加了当地社区组织的观赛聚会，现场有人第一次认识这位选手。"),
        new("社区", "{队}举办观众解说体验", "{队}邀请观众尝试解说一场社区比赛，{人}在现场参与交流。"),
        new("社区", "{人}整理了一份新人参赛清单", "{人}根据自己的经历整理了报名和出行准备事项，方便社区新人参考。"),
        new("社区", "{队}邀请观众参观队史角", "{队}开放队史展示区，{人}向观众介绍了几件已经留存的老物件。"),
        new("设备", "{人}找回了落下的外设包", "{人}在活动结束后发现外设包落在会场，工作人员确认失主后将它送还。"),
        new("设备", "{队}清理出一批老外设", "{队}整理备用设备，{人}认出了自己早期用过的同款鼠标。"),
        new("设备", "{人}体验了社区制作的桌垫", "社区创作者把设计做成了桌垫，{人}收到样品并分享了使用照片。"),
        new("往事", "{人}认出了多年前的合照", "社区有人分享早期活动合照，{人}认出了照片中的自己，并补充了当时的经历。"),
        new("往事", "{人}收到一封老观众来信", "一位长期观众回顾了关注{人}的经过，{人}回复感谢，并提起了双方曾见面的活动。"),
        new("往事", "{队}的旧队服重新展出", "{队}在队史角展出旧款队服，{人}和观众聊起了当年的设计。"),
        new("兴趣", "{人}参加了一次城市骑行", "{人}在休息时间参加短途骑行，回来后分享了路线与沿途照片。"),
        new("兴趣", "{人}推荐了一家旧书店", "{人}分享休息日逛旧书店的见闻，留言里出现了几位同好。"),
        new("兴趣", "{人}带回一张地方唱片", "{人}在出行期间买了一张本地乐队的唱片，准备带回去慢慢听。"),
        new("兴趣", "{人}体验了一次胶片摄影", "{人}把洗出的照片发到社区，几张失焦的画面也一起保留下来。"),
        new("兴趣", "{人}参加星空观测", "{人}在休息日参加天文馆活动，带回来一张当晚的星图。")
    ];
    public static void Advance(CareerData d)
    {
        if (d.Life.Version == 0 || d.Day < d.Life.NextWorldEventDay) return;
        int seed = CareerEngine.StableHash(d.WorldId + ":events:" + d.Day);
        var rng = new Random(seed); d.Life.NextWorldEventDay = d.Day + rng.Next(3, 7);
        var candidates = Topics.Where(t => d.Day - d.Life.LastTopics.GetValueOrDefault("world:" + t.Key, -100) >= 14).ToList();
        if (candidates.Count == 0) return;
        var topic = candidates[rng.Next(candidates.Count)];
        var people = d.People.Where(p => p.ClubId.Length > 0 && EsportsWorld.IsProfessional(p)
            && d.Day - d.Life.LastTopics.GetValueOrDefault("person:" + p.Id, -100) >= 42).ToList();
        if (people.Count == 0) return;
        var person = people[rng.Next(people.Count)];
        string Render(string s) => s.Replace("{人}", person.PublicName).Replace("{队}", EsportsWorld.ClubName(d, person.ClubId));
        d.Life.LastTopics["world:" + topic.Key] = d.Day; d.Life.LastTopics["person:" + person.Id] = d.Day;
        string title = Render(topic.Title), detail = Render(topic.Detail);
        CareerLife.AddEvent(d, "world-life-" + d.Day, topic.Key, title, detail, [person.Id]);
        CareerEngine.Publish(d, "world-life-" + d.Day, title, detail, "人物日常", true, [person.Id]);
        if (d.Posts.FirstOrDefault(p => p.EventKey == "world-life-" + d.Day) is { } post) post.NewsTopic = topic.Key;
    }
}
