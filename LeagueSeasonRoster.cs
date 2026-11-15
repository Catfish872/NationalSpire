namespace NationalSpire;

public sealed partial record LeagueSeasonRoster
{
    internal static bool Prepare(CareerData world,IReadOnlyList<string> available){
        if(world.LeagueRoster?.Season==world.Season)return false;
        var roles=available.ToDictionary(NpcCharacters.Index);
        var groups=world.People.Where(p=>p.Id!="player"&&!world.HumanIds.Contains(p.Id)).Select(p=>(Person:p,Role:roles.GetValueOrDefault(NpcCharacters.Index(p.Character))))
            .Where(x=>x.Role!=null).GroupBy(x=>(Role:x.Role!,Plan:LeagueArchetypes.Name(x.Role!,x.Person.Style)));
        var brackets=new List<LeagueBracket>();
        foreach(var group in groups.OrderBy(g=>g.Key.Role,StringComparer.Ordinal).ThenBy(g=>g.Key.Plan,StringComparer.Ordinal)){
            var people=group.Select(x=>x.Person).OrderBy(p=>p.MaxAscension).ThenBy(p=>p.Rating).ThenBy(p=>p.Id,StringComparer.Ordinal).ToArray();
            int n=people.Length, offset=0;
            void Record(int tier,IEnumerable<CareerPerson> members){
                var styles=members.GroupBy(p=>p.Style).ToDictionary(g=>g.Key,g=>g.Select(p=>p.Id).ToArray());
                if(styles.Count>0)brackets.Add(new(group.Key.Role,group.Key.Plan,tier,styles));
            }
            if(n<4){
                foreach(var tier in people.GroupBy(p=>p.MaxAscension switch{>=10=>3,9=>2,>=6=>1,_=>0}))Record(tier.Key,tier);
            }else for(int tier=0;tier<4;tier++){
                int count=n/4+(tier<n%4?1:0);Record(tier,new ArraySegment<CareerPerson>(people,offset,count));offset+=count;
            }
        }
        world.LeagueRoster=new(world.Season,brackets.ToArray());return true;
    }
}
