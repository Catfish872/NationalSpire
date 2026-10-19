namespace NationalSpire;

/// <summary>当前玩家的 NPC 头像装扮；荣誉数据与关系状态由原模块管理。</summary>
public static class NpcAvatarFrames
{
    public static readonly AvatarFrame[] Special =
    [
        new("friend", "好友", "8fd8d0", 0, "好感达到 50"),
        new("intimate", "亲密", "c8b5ec", 0, "好感达到 80"),
        new("lover", "恋人", "efa5bc", 0, "交往关系为恋人"),
        new("cat", "猫咪", "edcdae", 0, "好感超过 25"),
        new("oath", "钻戒誓约", "dce6f1", 0, "完成盛大婚礼的约会场景")
    ];
    public static IEnumerable<AvatarFrame> Choices => AvatarHonors.Frames.Concat(Special);
    public static string Requirement(string id) => id == "auto" ? "默认可用，跟随角色原有荣誉与誓约。"
        : Special.FirstOrDefault(f => f.Id == id) is { } special ? special.Requirement + "。"
        : "好感超过 25" + (AvatarHonors.Frames.FirstOrDefault(f => f.Id == id) is { Grade: > 0 } honor ? "；" + honor.Requirement : "") + "。";
    public static string Description(string id) => id switch
    {
        "auto" => "展示角色原有的荣誉头像框；完成婚礼并保持婚约时使用钻戒誓约框。",
        "plain" => "简洁的青灰边框，衬托清晰的角色头像。",
        "academy" => "青绿色细边与轻巧的金属转角，记录初登赛场的朝气。",
        "pro" => "银蓝色金属轮廓，沉稳而利落。",
        "international" => "湛蓝的多层边饰，带有国际赛场的光泽。",
        "ranked" => "紫蓝色荣誉边饰，点亮世界名将的风采。",
        "elite" => "暖金色分层边框，展现世界顶尖的气度。",
        "quarter" => "淡紫色赛事边饰，纪念八强舞台的荣耀。",
        "semi" => "浅金色赛事边饰，映照四强舞台的光芒。",
        "champion" => "明亮的金色冠冕边框，呈现冠军主题装扮。",
        "friend" => "柔和的青绿与浅金交织，为熟悉的陪伴留下一圈暖意。",
        "intimate" => "淡紫与银色相映，细致的弧线寄托亲近与信任。",
        "lover" => "粉色花瓣与爱心点缀，记录两人之间的温柔心意。",
        "cat" => "奶油色软边、微翘猫耳与粉色肉垫，藏着一条俏皮的小尾巴。佩戴时隐藏身份标签，保留进阶等级。",
        "oath" => "银白钻戒扣住精致边框，以粉色宝石和柔光纪念共同的誓约。",
        _ => ""
    };
    public static AvatarFrame? Find(string id)
    {
        foreach (var frame in AvatarHonors.Frames) if (frame.Id == id) return frame;
        foreach (var frame in Special) if (frame.Id == id) return frame;
        return null;
    }
    public static string? Locked(PrivateRelation relation, string id)
    {
        if (id == "auto") return null;
        if (Find(id) == null) return "请选择有效的头像框。";
        if (relation.Favour <= 25) return "需提升好感度至 26 后更换头像框。";
        return id switch
        {
            "friend" when relation.Favour < 50 => "需提升好感度至 50 后使用好友头像框。",
            "intimate" when relation.Favour < 80 => "需提升好感度至 80 后使用亲密头像框。",
            "lover" when !(relation.OathConfirmed || relation.SelectedBond >= 1 || relation.SelectedBond == null && RelationshipPresentation.IsRomantic(relation.Relationship)) => "交往关系达到恋人后解锁。",
            "oath" when !RelationshipPresentation.OathAppearance(relation) => "完成盛大婚礼的约会场景后解锁。",
            _ => null
        };
    }
    public static string? Select(CareerData data, string person, string id)
    {
        if (GroupChats.IsHuman(data, person) || CareerEngine.Person(data, person) == null) return "请选择 NPC。";
        if (Locked(data, person, id) is { } error) return error;
        var choices = PrivateMessages.Mailbox(data).NpcAvatarFrames;
        if (id == "auto") choices.Remove(person); else choices[person] = id;
        return null;
    }
    public static string? Locked(CareerData data, string person, string id)
    {
        if (Locked(PrivateMessages.Relation(data, person), id) is { } error) return error;
        return AvatarHonors.Frames.FirstOrDefault(f => f.Id == id) is { Grade: > 0 } honor && !AvatarHonors.Earned(data, person).ContainsKey(id)
            ? "该角色需先" + honor.Requirement + "。" : null;
    }
}
