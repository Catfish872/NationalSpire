using System.Text.Json;

namespace NationalSpire.Coop;

public sealed partial class CoopCoordinator
{
    private void StartGroup(ulong sender, CoopCommand command)
    {
        if (!Host || World == null || command.Kind is not ("group-send" or "group-retry" or "group-regenerate" or "group-summary" or "group-arbitrate")) return;
        string world = World.Id, epoch = World.Epoch;
        CareerData? Current()
        {
            if (_closed || World?.Id != world || World.Epoch != epoch) return null;
            var member = World.Members.FirstOrDefault(m => m.SteamId == sender); if (member == null) return null;
            var d = CoopRules.View(World, member); d.Ai = AiSettingsStore.Load(new()); d.PrivatePromptSnapshot.Clear();
            d.PrivateMemorySources = World.Members.ToDictionary(m => m.PersonId, m => m.PersonId == member.PersonId ? d.Life.Mailbox : CoopJson.Copy(m.Life.Mailbox));
            return d;
        }
        void Save(CareerData d)
        {
            if (_closed || World?.Id != world || World.Epoch != epoch) return;
            var next = CoopJson.Copy(World); CoopJson.Detached(next.World);
            CoopRules.CaptureGroup(next, next.Members.Single(m => m.SteamId == sender), d);
            next.Revision++; Commit(next, NativeSave);
        }
        if (command.Kind == "group-summary")
        {
            var payload = JsonSerializer.Deserialize<GroupCommand>(command.Text) ?? new();
            _ = AiService.SummarizeGroupAsync(Current, Save, command.Target, payload.Text); return;
        }
        _ = AiService.ProcessGroupAsync(Current, Save, command.Target, text =>
        {
            if (World?.Id != world || World.Epoch != epoch) return;
            var g = World.World.Chats.Groups.FirstOrDefault(g => g.Id == command.Target); if (g == null) return;
            var turn = g.Turns.LastOrDefault(); if (turn == null) return;
            foreach (var member in World.Members.Where(m => m.SteamId != Self && g.Members.Contains(m.PersonId)))
                foreach (var part in CoopAssembler.Split(CoopJson.Bytes(new CoopPrivateChunk(world, epoch, "group:" + g.Id, turn.Id, text, ++_privateSendSequence, AiService.GroupReasoningLive.GetValueOrDefault(world + "/group/" + g.Id).Text ?? ""))))
                    Send(member.SteamId, "private-chunk", new CoopPrivatePart("group:" + g.Id, part));
        });
    }
}
public static partial class CoopRules
{
    internal static void CaptureGroup(CoopWorld w, CoopMember member, CareerData view)
    {
        Capture(w, member, view); w.World.Chats = view.Chats; w.World.Matches = view.Matches; w.World.Esports.OwnedClub = view.Esports.OwnedClub;
        foreach (var other in w.Members.Where(m => m.SteamId != member.SteamId))
            if (view.PrivateMemorySources.TryGetValue(other.PersonId, out var box)) other.Life.Mailbox = box;
        RefreshPeople(w);
    }
    private static string? GroupCommand(CoopWorld w, CoopMember member, CoopCommand command)
    {
        var payload = JsonSerializer.Deserialize<GroupCommand>(command.Text) ?? new();
        var view = View(w, member);
        view.PrivateMemorySources = w.Members.ToDictionary(m => m.PersonId, m => m.PersonId == member.PersonId ? view.Life.Mailbox : CoopJson.Copy(m.Life.Mailbox));
        if (command.Kind is "group-summary" or "group-stop") return GroupChats.Command(view, command.Kind, command.Target, payload);
        if (command.Kind.StartsWith("group-offer-") && view.Chats.Groups.FirstOrDefault(g => g.Id == command.Target)?.Interactions.GetValueOrDefault(payload.Lane)?.Offers.FirstOrDefault(o => o.Id == payload.Interaction.Offer)?.Kind == "contract" && member.SteamId != w.Owner)
            return "合同由房主管理。";
        string? error = GroupChats.Command(view, command.Kind, command.Target, payload);
        if (error == null) CaptureGroup(w, member, view);
        return error;
    }
}
