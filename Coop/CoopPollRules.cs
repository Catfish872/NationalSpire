using System.Text.Json;

namespace NationalSpire.Coop;

/// <summary>
/// 玩家发起投票的多人命令。
///
/// **单独成文件**，`CoopRules.cs` 本体只加一行 `case "poll-ask"` ——
/// 投票是外挂功能，不该把逻辑混进本体那个大 switch 里。
///
/// 与单人的 <c>CareerScreen.CreateReplyPoll</c> 是同一件事：
/// 先发一条正文为问题的回复，再把投票挂到它上面。区别只是这里在**主机侧**执行，
/// 单人那份直接改本地数据。
///
/// 为什么必须走命令：成员界面拿到的是 `CoopRules.View` 的**深拷贝**，
/// 直接改只会写进副本、刷新即丢。只有主机在 `w.World` 上改才算数。
/// </summary>
public static partial class CoopRules
{
    /// <summary>选项上限，与单人一致。</summary>
    private const int PollMaxOptions = 8;

    private sealed class PollAskPayload
    {
        public string Question { get; set; } = "";
        public List<string> Options { get; set; } = [];
    }

    /// <summary>默认区分大小写，界面发的是小写键，必须显式打开。</summary>
    private static readonly JsonSerializerOptions PollJson = new() { PropertyNameCaseInsensitive = true };

    /// <summary>
    /// 执行「发起投票」。返回 null 表示成功，否则返回给玩家的错误。
    ///
    /// 与单人路径一样做**格式校验**：问题非空、选项 2–8 个、去空去重后仍够数。
    /// 不合规就整体拒绝，不产生回复、也不产生投票 —— 不能留半截状态。
    /// </summary>
    private static string? PollAsk(CoopWorld w, CoopMember member, CoopCommand command)
    {
        var post = CommunityThreads.All(w.World).FirstOrDefault(p => p.Id == command.Target);
        if (post == null) return "帖子不存在。";
        return AttachPoll(w, member, post, command.Text, onReply: true);
    }

    /// <summary>
    /// 把投票挂到帖子上（主机侧）。返回 null 表示成功，否则返回错误。
    ///
    /// **两条路径共用**：
    ///   · `poll-ask` —— 在已有帖子里单独发起，先发一条回复、投票挂在回复上
    ///   · `post`     —— 发帖时随帖发起，**挂在主楼**，不额外生成回复
    /// </summary>
    private static string? AttachPoll(CoopWorld w, CoopMember member, CommunityPost post,
                                      string payloadText, bool onReply)
    {
        PollAskPayload ask;
        try { ask = JsonSerializer.Deserialize<PollAskPayload>(payloadText, PollJson) ?? new(); }
        catch { return "投票内容无法解析。"; }

        var question = (ask.Question ?? "").Trim();
        var options = (ask.Options ?? []).Select(o => (o ?? "").Trim())
            .Where(o => o.Length > 0).Distinct().Take(PollMaxOptions).ToList();
        if (question.Length == 0 || options.Count < 2) return "请填写问题与至少两个选项。";

        string replyId = "";
        if (onReply)
        {
            // 正文就是问题本身 —— 它会进讨论提示词，AI 因此看得到要投什么
            var reply = new CommunityReply
            {
                AuthorId = member.PersonId,
                Body = question,
                Day = w.World.Day,
                NeedsReaction = true,
                MentionedPeople = CommunityMentions.Resolve(w.World, question),
            };
            post.Replies.Add(reply);
            post.AiPending = false;
            post.Revision++;
            CommunityThreads.Remember(w.World, post);
            replyId = reply.Id;
        }

        w.World.Polls.Add(new CommunityPoll
        {
            PostId = post.Id,
            ReplyId = replyId,
            Kind = "PlayerAsked",
            Question = question,
            Options = options,
            Votes = options.Select(_ => 0).ToList(),
            // 规模随帖子所属赛事 —— 与单人路径一致
            Scale = PollSchedule.ScaleFor(w.World, post),
        });
        return null;
    }
}
