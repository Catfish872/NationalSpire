namespace NationalSpire.Coop;

public static partial class CoopRules
{
    private static string? EventCommand(CoopWorld w, CoopMember member, CoopCommand command)
    {
        var d = View(w, member); d.Ai = AiSettingsStore.Load(new());
        if (command.Kind == "event-settings")
        {
            RandomEvents.SetFrequency(d, command.Target == "enabled", command.Number, int.Parse(command.Text, System.Globalization.CultureInfo.InvariantCulture));
            Capture(w, member, d); return null;
        }
        string? error = command.Kind switch
        {
            "event-custom" => RandomEvents.Custom(d, command.Target, command.Text),
            "event-custom-choose" => RandomEvents.ChooseCustom(d, command.Target, command.Text == "public"),
            "event-start" => RandomEvents.Start(d, command.Target),
            "event-skip" => RandomEvents.Skip(d, command.Target),
            "event-stop" => RandomEvents.Stop(d, command.Target),
            "event-choose" => RandomEvents.Choose(d, command.Target, command.Number, command.Text == "public"),
            _ => "事件操作不存在。"
        };
        if (error != null) return error;
        Capture(w, member, d);
        if (command.Kind is "event-choose" or "event-custom-choose")
        {
            w.World.Matches = d.Matches; w.World.Market = d.Market; w.World.Esports.Nations = d.Esports.Nations;
            foreach (var match in d.Matches.Where(m => RandomEvents.Find(d, command.Target)?.MatchIds.Contains(m.Id) == true)) match.Registered = true;
        }
        return null;
    }
}
public sealed partial class CoopCoordinator
{
    private void StartEvent(ulong sender, CoopCommand command)
    {
        if (!Host || World == null || command.Kind is not ("event-start" or "event-custom")) return;
        string worldId = World.Id, epoch = World.Epoch;
        CareerData? Current()
        {
            if (_closed || World?.Id != worldId || World.Epoch != epoch) return null;
            var member = World.Members.FirstOrDefault(m => m.SteamId == sender); if (member == null) return null;
            var data = CoopRules.View(World, member); data.Ai = AiSettingsStore.Load(new()); return data;
        }
        void Save(CareerData data)
        {
            if (_closed || World?.Id != worldId || World.Epoch != epoch) return;
            var copy = CoopJson.Copy(World); CoopJson.Detached(copy.World);
            var member = copy.Members.Single(m => m.SteamId == sender);
            int index = member.Life.RandomEvents.FindIndex(e => e.Id == command.Target);
            if (index < 0 || member.Life.RandomEvents[index].State != "generating" && member.Life.RandomEvents[index].CustomState != "generating") return;
            member.Life.RandomEvents[index] = RandomEvents.Find(data, command.Target)!;
            copy.Revision++; Commit(copy, NativeSave);
        }
        _ = AiService.ProcessEventAsync(Current, Save, command.Target, live =>
        {
            if (_closed || World?.Epoch != epoch || sender == Self) return;
            string person = "event:" + command.Target;
            foreach (var part in CoopAssembler.Split(CoopJson.Bytes(new CoopPrivateChunk(worldId, epoch, person, command.Target,
                System.Text.Json.JsonSerializer.Serialize(live), ++_privateSendSequence))))
                Send(sender, "private-chunk", new CoopPrivatePart(person, part));
        });
    }
}
