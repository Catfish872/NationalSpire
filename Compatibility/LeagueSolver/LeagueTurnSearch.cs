using System.Diagnostics;

namespace NationalSpire.Solver;

// 国运尖塔决定搜索多少步以及何时收手。局面的表示、牌效和分数由调用方提供。
internal static class LeagueTurnSearch
{
    internal readonly record struct Candidate<T,TKey>(T State,TKey Key,decimal EndScore,decimal ContinueScore,bool Lethal,bool WinsTie);
    internal readonly record struct Result<T>(T State,int Compared,bool TimedOut);

    internal static Result<T> Choose<T,TKey>(T pass,decimal passScore,int level,CancellationToken exit,
        Func<T,Func<bool>,IEnumerable<Candidate<T,TKey>>> expand) where TKey:notnull
    {
        long start=Stopwatch.GetTimestamp();
        int compared=0;
        bool timedOut=false;
        bool hasMove=false;
        bool rootComplete=false;
        bool Expired(){
            exit.ThrowIfCancellationRequested();
            // 冷启动也先得到可执行的出牌决定；首层没有更优出牌时，比较完首层才可停手。
            if((hasMove || rootComplete) && Stopwatch.GetElapsedTime(start).TotalMilliseconds>=18+6*level)timedOut=true;
            return timedOut;
        }
        var best=pass;
        decimal bestEnd=passScore,bestContinue=decimal.MinValue;
        var visited=new Dictionary<TKey,decimal>();
        List<T> frontier=[pass];
        for(int depth=0;depth<24 && frontier.Count>0 && !Expired();depth++){
            var next=new List<(T State,decimal Score)>();
            foreach(var parent in frontier){
                if(Expired())break;
                foreach(var candidate in expand(parent,Expired)){
                    compared++;
                    if(candidate.Lethal)return new(candidate.State,compared,timedOut);
                    if(candidate.EndScore>bestEnd || candidate.EndScore==bestEnd &&
                        (hasMove?candidate.ContinueScore>bestContinue:candidate.WinsTie)){
                        best=candidate.State;bestEnd=candidate.EndScore;bestContinue=candidate.ContinueScore;hasMove=true;
                    }
                    if(visited.TryGetValue(candidate.Key,out var previous) && previous>=candidate.ContinueScore)continue;
                    visited[candidate.Key]=candidate.ContinueScore;
                    next.Add((candidate.State,candidate.ContinueScore));
                }
            }
            rootComplete=true;
            frontier=next.OrderByDescending(item=>item.Score).Take(3+2*level).Select(item=>item.State).ToList();
        }
        return new(best,compared,timedOut);
    }
}
