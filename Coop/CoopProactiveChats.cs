namespace NationalSpire.Coop;

public sealed partial class CoopCoordinator
{
    private void StartProactiveChats()
    {
        if (!Host || World == null) return;
        foreach (var member in World.Members.ToArray())
        {
            foreach (var c in member.Life.Mailbox.Conversations.Values.ToArray())
                if (!c.Hidden && c.Turns.LastOrDefault() is { Status: "queued", ProactiveReason.Length: > 0 })
                    StartPrivate(member.SteamId, new(World.Id, World.Epoch, "", World.Revision, "dm-send", c.PersonId));
            foreach (var g in World.World.Chats.Groups.Where(g => !g.Dissolved && g.Members.Contains(member.PersonId)).ToArray())
                if (g.Turns.LastOrDefault() is { Status: "queued", ProactiveReason.Length: > 0 } turn && turn.Sender == member.PersonId)
                    StartGroup(member.SteamId, new(World.Id, World.Epoch, "", World.Revision, "group-send", g.Id));
        }
    }
}
