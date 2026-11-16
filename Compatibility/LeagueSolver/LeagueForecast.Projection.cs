using CombatSolver;
using CombatSolver.Engine.Common;
using HarmonyLib;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Modding;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.Blitz;
using MegaCrit.Sts2.Core.Models.Dread;
using MegaCrit.Sts2.Core.Runs;
using System.Runtime.CompilerServices;

namespace NationalSpire.Solver;

public sealed partial class LeagueForecast {
    private readonly HashSet<Type> _unmodelledPlays=[];

    [UnsafeAccessor(UnsafeAccessorKind.Method,Name="set_RunModels")]
    private static extern void SetRunRules(RunState run,IReadOnlyList<RunModel> rules);
    private static void ProjectRunRules(RunState run){
        // 与内置 SimulatedCombatState 的规则复制范围一致。金币等效果还会从临时 RunState 读取同一份名单。
        static bool Known(RunModel rule)=>rule is MultiplayerScalingModel or BlitzRunModel or DreadRunModel;
        if(run.RunModels.Any(r=>!Known(r)))SetRunRules(run,run.RunModels.Where(Known).ToArray());
    }

    [ThreadStatic] private static CaptureProjection? _capture;
    private sealed class CaptureProjection : IDisposable {
        internal readonly RunState Run;
        internal readonly CombatState Board;
        internal readonly HashSet<Type> Unmodelled;
        internal readonly AbstractModel[] RunSubscribers,CombatSubscribers;
        private readonly CaptureProjection? _previous;
        internal CaptureProjection(RunState run,CombatState board,HashSet<Type> unmodelled){
            Run=run;Board=board;Unmodelled=unmodelled;Unmodelled.Clear();
            RunSubscribers=Supported(ModHelper.IterateAllRunStateSubscribers(run),"run");
            CombatSubscribers=Supported(ModHelper.IterateAllCombatStateSubscribers(board),"combat");
            _previous=_capture;_capture=this;
        }
        private static AbstractModel[] Supported(IEnumerable<AbstractModel> models,string scope)=>
            models.Where(m=>{
                try{PredictionModHookSubscriberCapture.ValidateSubscriber(m,scope);return true;}
                catch(NotSupportedException){return false;}
            }).ToArray();
        public void Dispose()=>_capture=_previous;
    }

    private static void InstallProjection(Harmony h){
        h.Patch(AccessTools.Method(typeof(ModHelper),nameof(ModHelper.IterateAllRunStateSubscribers)),prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(RunSubscribers)));
        h.Patch(AccessTools.Method(typeof(ModHelper),nameof(ModHelper.IterateAllCombatStateSubscribers)),prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(CombatSubscribers)));
        h.Patch(AccessTools.Method(typeof(PredictionModPatchAudit),"AuditCardOnPlay"),finalizer:new HarmonyMethod(typeof(LeagueForecast),nameof(CardAudit)));
    }
    // 只在同步复制这个临时战场时复用同一份名单；真实对局及其他求解器照常枚举。
    private static bool RunSubscribers(RunState __0,ref IEnumerable<AbstractModel> __result){
        if(_capture is not {} p||!ReferenceEquals(__0,p.Run))return true;
        __result=p.RunSubscribers;return false;
    }
    private static bool CombatSubscribers(CombatState __0,ref IEnumerable<AbstractModel> __result){
        if(_capture is not {} p||!ReferenceEquals(__0,p.Board))return true;
        __result=p.CombatSubscribers;return false;
    }
    private static Exception? CardAudit(Type type,ref PredictionModPatchAudit.ForeignPatch? firstForeign,
        AdaptedCardOnPlayMirrors.Registration? __result,Exception? __exception){
        if(_capture is not {} p||(__exception is not NotSupportedException &&
            !(__exception==null&&firstForeign!=null&&__result==null)))return __exception;
        p.Unmodelled.Add(type);firstForeign=null;return null;
    }
}
