using System.Reflection;
using System.IO.Compression;
using System.Runtime.Loader;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;

namespace NationalSpire;

// 主模组仍可在旧游戏中加载。首次使用对战功能时，从国运尖塔自身载入推演组件。
internal sealed class LeagueSolverLink : IDisposable
{
    internal const string Unavailable="当前游戏版本不支持镜面对决";
    // 内置版本使用 113 的战场、箭槽及逐击资料。探测游戏自身，不检查玩家安装的其他模组。
    internal static readonly bool Supported=typeof(Player).Assembly.GetType("MegaCrit.Sts2.Core.Entities.FoolArrows.ArrowSlot")!=null
        && typeof(MegaCrit.Sts2.Core.Runs.RunState).GetProperty("RunModels")!=null;
    // 游戏与联赛共用角色类型；求解器和它的辅助库只在这个上下文内解析。
    private sealed class EngineContext():AssemblyLoadContext("NationalSpire.LeagueEngine"){
        private readonly Assembly host=typeof(LeagueSolverLink).Assembly;
        protected override Assembly? Load(AssemblyName name){
            if(name.Name=="CombatSolver" || name.Name!.StartsWith("STS2-RitsuLib",StringComparison.Ordinal)){
                using var pack=new ZipArchive(host.GetManifestResourceStream("NationalSpire.LeagueEngine.zip")!);
                using var input=pack.GetEntry(name.Name+".dll")!.Open();using var bytes=new MemoryStream();
                input.CopyTo(bytes);bytes.Position=0;return LoadFromStream(bytes);
            }
            return GetLoadContext(host)!.Assemblies.Concat(AppDomain.CurrentDomain.GetAssemblies()).FirstOrDefault(a=>AssemblyName.ReferenceMatchesDefinition(a.GetName(),name));
        }
    }
    private readonly Func<decimal[],int[],Task<CardModel?>>? _choose;
    private readonly IDisposable? _session;
    private readonly Func<int>? _aim;
    private readonly Func<(CardModel,int)[]>? _rest;
    internal int Aim=>_aim?.Invoke()??-1;
    internal (CardModel,int)[] Rest()=>_rest?.Invoke()??[];
    private bool _failed;
    private LeagueSolverLink(){}
    private LeagueSolverLink(object session){_session=(IDisposable)session;_aim=session.GetType().GetProperty("LastAim")!.GetMethod!.CreateDelegate<Func<int>>(session);_rest=session.GetType().GetMethod("Continuation")!.CreateDelegate<Func<(CardModel,int)[]>>(session);_choose=session.GetType().GetMethod("Choose")!.CreateDelegate<Func<decimal[],int[],Task<CardModel?>>>(session);}
    private static readonly Lazy<Task<Type?>> Ready=new(()=>Task.Run(()=>{
        try{using var stream=typeof(LeagueSolverLink).Assembly.GetManifestResourceStream("NationalSpire.LeagueSolver.dll")!;
            var type=new EngineContext().LoadFromStream(stream).GetType("NationalSpire.Solver.LeagueForecast",true)!;
            type.GetMethod("Prepare")!.Invoke(null,null);return type;
        }catch(Exception e){Diagnostics.Error("league-solver",e.GetBaseException());return null;}
    }));
    public static void Prepare()=>_=Ready.Value;
    public static async Task<LeagueSolverLink> Open(Player rival,int tier,string[] setup,int preference){
        try{var adapter=await Ready.Value;if(adapter==null)return new();
            return new(Activator.CreateInstance(adapter,rival,tier,setup,(Func<int,int>)LeagueNativeMatch.AddedDoom,preference)!);
        }catch(Exception e){Diagnostics.Error("league-solver",e.GetBaseException());return new();}
    }
    public async Task<CardModel?> Choose(decimal[] amounts,int[] properties){
        if(_failed||_choose==null)return null;
        try{return await _choose(amounts,properties);}catch(Exception e){_failed=true;Diagnostics.Error("league-solver",e.GetBaseException());return null;}
    }
    public void Dispose()=>_session?.Dispose();
}
