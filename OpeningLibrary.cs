using System.Text.Json;
using NationalSpire.Coop;

namespace NationalSpire;

public sealed record OpeningRole(string Path, string Id, string Name, string Career);

internal static class OpeningLibrary
{
    internal static List<OpeningRole> SavedRoles(string original)
    {
        var folder = new DirectoryInfo(Path.GetDirectoryName(original)!);
        var profiles = folder.Parent is { } parent && folder.Name.StartsWith("profile") && parent.Exists
            ? parent.EnumerateDirectories("profile*").Select(p=>p.FullName) : [folder.FullName];
        var result = new List<OpeningRole>();
        var names = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        foreach(var path in profiles.SelectMany(CareerLibrary.SavedPaths).OrderByDescending(File.GetLastWriteTimeUtc))
        {
            using var file = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete);
            using var json = JsonDocument.Parse(file);
            var root=json.RootElement;
            if(!root.TryGetProperty("People",out var people)) continue;
            string career=root.TryGetProperty("SaveName",out var label) && !string.IsNullOrWhiteSpace(label.GetString()) ? label.GetString()! : Path.GetFileNameWithoutExtension(path);
            foreach(var p in people.EnumerateArray())
                if(p.TryGetProperty("CreatedCard",out var created) && created.ValueKind==JsonValueKind.True)
                {
                    string handle=p.GetProperty("Handle").GetString()!;
                    if(names.Add(handle))result.Add(new(path,p.GetProperty("Id").GetString()!,handle,career));
                }
        }
        return result.OrderBy(c=>c.Name,StringComparer.CurrentCulture).ToList();
    }

    internal static void Apply(CareerData fresh,CareerData artOwner,IEnumerable<OpeningRole> roles,List<CharacterDesignPackage.Installation> installs)
    {
        foreach(var group in roles.GroupBy(r=>r.Path))
        {
            using var file=File.OpenRead(group.Key);using var json=JsonDocument.Parse(file);
            var source=new CareerData { WorldId=json.RootElement.GetProperty("WorldId").GetString()! };
            var ids=group.Select(r=>r.Id).ToHashSet();
            foreach(var element in json.RootElement.GetProperty("People").EnumerateArray())
            {
                if(!ids.Contains(element.GetProperty("Id").GetString()!))continue;
                var p=element.Deserialize<CareerPerson>(CoopJson.Options)!;
                if(EsportsWorld.Club(fresh,p.ClubId)==null)p.ClubId="";
                if(EsportsWorld.Club(fresh,p.SupportedClubId)==null)p.SupportedClubId="";
                if(CharacterCards.Apply(fresh,new(){Create=true,Target=p.Id,Person=p}) is { } error)throw new InvalidDataException(p.PublicName+" · "+error);
                if(PortraitDesignStore.Read(PortraitDesignStore.FilePath(source,p.Id),p.Id) is { } art)
                    installs.Add(new(artOwner,p.Id,art,DateSceneAssetStore.Read(source,p.Id)));
            }
        }
    }
}
