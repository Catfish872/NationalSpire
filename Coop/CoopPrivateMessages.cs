using System.Text.Json;

namespace NationalSpire.Coop;

public sealed record CoopPrivateChunk(string World, string Epoch, string Person, string Turn, string Text, int Sequence, string Reasoning = "");
public sealed record CoopPrivatePart(string Person, CoopPart Part);

public sealed partial class CoopCoordinator
{
    private readonly Dictionary<string, int> _privateSequences = [];
    private readonly Dictionary<string, CoopAssembler> _privateAssemblers = [];
    private int _privateSendSequence;
    private void ReceivePrivate(CoopWire wire)
    {
        if (Host || World == null) return;
        var part = Read<CoopPrivatePart>(wire);
        if (part.Person.Length > 256 || part.Part.Total > 400000 || !PrivateMessages.CanChat(World.World, part.Person)) return;
        if (!_privateAssemblers.TryGetValue(part.Person, out var assembler))
        {
            if (_privateAssemblers.Count >= 64) _privateAssemblers.Remove(_privateAssemblers.Keys.First());
            _privateAssemblers[part.Person] = assembler = new();
        }
        if (assembler.Add(part.Part) is not { } bytes) return;
        var chunk = CoopJson.Read<CoopPrivateChunk>(bytes);
        if (chunk.World != World.Id || chunk.Epoch != World.Epoch || chunk.Text.Length + chunk.Reasoning.Length > 100000) return;
        string sequence = chunk.World + "/" + chunk.Epoch + "/" + chunk.Person + "/" + chunk.Turn;
        if (_privateSequences.GetValueOrDefault(sequence) >= chunk.Sequence) return;
        _privateSequences[sequence] = chunk.Sequence;
        if (_privateSequences.Count > 512) _privateSequences.Remove(_privateSequences.Keys.First());
        AiService.PrivateLive[World.Id + "-" + Self + "/" + chunk.Person] = (chunk.Turn, chunk.Text);
        AiService.PrivateReasoningLive[World.Id + "-" + Self + "/" + chunk.Person] = (chunk.Turn, chunk.Reasoning);
    }
    private void StartPrivate(ulong sender, CoopCommand command)
    {
        if (!Host || World == null || command.Kind is not ("dm-send" or "dm-retry" or "dm-regenerate" or "dm-arbitrate" or "dm-summary")) return;
        string worldId = World.Id, epoch = World.Epoch;
        CareerData? Current()
        {
            if (_closed || World?.Id != worldId || World.Epoch != epoch) return null;
            var member = World.Members.FirstOrDefault(m => m.SteamId == sender); if (member == null) return null;
            var data = CoopRules.View(World, member); data.Ai = AiSettingsStore.Load(new()); data.PrivatePromptSnapshot.Clear(); return data;
        }
        void Save(CareerData data)
        {
            if (_closed || World?.Id != worldId || World.Epoch != epoch) return;
            var copy = CoopJson.Copy(World); CoopJson.Detached(copy.World);
            var member = copy.Members.Single(m => m.SteamId == sender);
            member.Life.Mailbox = data.Life.Mailbox; member.Life.Relationships = data.Life.Relationships;
            CareerTraining.MergePrivateLearning(copy.World, member.Life.Mailbox);
            PrivateProfileChanges.Merge(copy.World, member.Life.Mailbox);
            SpireArbitration.Merge(copy.World, member.Life.Mailbox);
            foreach (var match in data.Matches.Where(m => PrivateAppointments.IsPrivate(m) && m.OpponentId == command.Target))
            {
                int index = copy.World.Matches.FindIndex(m => m.Id == match.Id);
                if (index >= 0) copy.World.Matches[index] = CoopJson.Copy(match);
            }
            CoopRules.RefreshPeople(copy); copy.Revision++; Commit(copy, NativeSave);
        }
        if (command.Kind == "dm-summary") { _ = AiService.SummarizePrivateManually(Current, Save, command.Target); return; }
        _ = AiService.ProcessPrivateAsync(Current, Save, command.Target, (turn, text) =>
        {
            if (!_closed && World?.Epoch == epoch && sender != Self)
                // 只回传这次私信的发起者，沿用正文的收件人隔离，禁止广播给其他队友。
                foreach (var part in CoopAssembler.Split(CoopJson.Bytes(new CoopPrivateChunk(worldId, epoch, command.Target, turn, text, ++_privateSendSequence,
                    AiService.PrivateReasoningLive.GetValueOrDefault(worldId + "-" + sender + "/" + command.Target).Text ?? ""))))
                    Send(sender, "private-chunk", new CoopPrivatePart(command.Target, part));
        });
    }
    public static CoopWorld PrivateSnapshot(CoopWorld source, ulong recipient)
    {
        var copy = CoopJson.Copy(source); CoopJson.Detached(copy.World);
        copy.World.Life.Mailbox = new();
        foreach (var member in copy.Members.Where(m => m.SteamId != recipient)) member.Life.Mailbox = new();
        return copy;
    }
}

public static partial class CoopRules
{
    private static string? PrivateCommand(CoopWorld w, CoopMember member, CoopCommand command)
    {
        var payload = JsonSerializer.Deserialize<PrivateMessageCommand>(command.Text, CoopJson.Options) ?? new();
        var view = View(w, member);
        if (command.Kind is "dm-confirm" or "dm-decline")
        {
            var offer = PrivateMessages.Conversation(view, command.Target).Offers.FirstOrDefault(o => o.Id == payload.Offer);
            if (offer == null) return "邀约不存在。";
            if (offer.Kind == "match" && (command.Kind == "dm-confirm" || offer.MatchId.Length > 0))
            {
                if (w.Proposal != null) return "请先完成当前团队安排。";
                if (command.Kind == "dm-confirm" && PrivateAppointments.Error(w.World, command.Target, offer) is { } error) return error;
                var arrangement = new CoopProposal { Kind = "dm-match", Target = member.SteamId + "/" + command.Target + "/" + offer.Id,
                    Number = command.Kind == "dm-confirm" ? 1 : 0, Votes = [member.SteamId],
                    Label = (command.Kind == "dm-confirm" ? "安排" : "取消") + $"与{CareerEngine.DisplayName(w.World, command.Target)}的{offer.Mode} · 第{offer.Season}赛季第{offer.Day}天 · 进阶{offer.Ascension}" };
                return ConfirmPrivateMatch(w, arrangement);
            }
            if (offer.Kind == "contract" && member.SteamId != w.Owner) return "合同由房主管理。";
            if (offer.Kind == "contract" && (w.Run != null || w.Proposal != null)) return "请先完成当前比赛或团队安排。";
        }
        string? result = PrivateMessageCommands.Apply(view, command.Kind, command.Target, payload);
        if (result == null)
        {
            Capture(w, member, view);
            if (command.Kind is "dm-regenerate")
            { w.World.Matches = view.Matches; w.World.Esports.Competitions = view.Esports.Competitions; }
            if (command.Kind is "dm-clear" or "dm-delete" or "dm-regenerate" && w.Proposal is { Kind: "dm-match" } pending)
            {
                string prefix = member.SteamId + "/" + command.Target + "/";
                if (pending.Target.StartsWith(prefix) && !PrivateMessages.Conversation(view, command.Target).Offers.Any(o => o.Id == pending.Target[prefix.Length..])) w.Proposal = null;
            }
        }
        return result;
    }
    private static string? ConfirmPrivateMatch(CoopWorld w, CoopProposal proposal)
    {
        string[] ids = proposal.Target.Split('/');
        if (ids.Length != 3 || !ulong.TryParse(ids[0], out ulong sender)) return "约战信息无效。";
        var member = w.Members.FirstOrDefault(m => m.SteamId == sender);
        var c = member?.Life.Mailbox.Conversations.GetValueOrDefault(ids[1]);
        var offer = c?.Offers.FirstOrDefault(o => o.Id == ids[2]);
        if (offer == null) return "约战邀约已经失效。";
        var view = View(w, member!);
        var local = PrivateMessages.Conversation(view, ids[1]).Offers.Single(o => o.Id == ids[2]);
        string? error = proposal.Number == 1 ? PrivateAppointments.Confirm(view, ids[1], local) : PrivateAppointments.Cancel(view, local);
        if (error == null) { Capture(w, member!, view); w.World.Matches = view.Matches; }
        return error;
    }
}
