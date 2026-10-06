using System.Reflection;
using System.Runtime.ExceptionServices;

namespace NationalSpire;

/// <summary>按实际签名适配已知接口，保留游戏自身的哈希算法与随机数位宽。</summary>
public sealed class SeedApi
{
    private readonly MethodInfo _hash;
    private readonly ConstructorInfo _constructor;
    public string Description => $"{_hash.ReturnType.Name} → {_constructor.GetParameters()[0].ParameterType.Name}";
    public SeedApi(Type helper, Type rng)
    {
        _hash = helper.GetMethod("GetDeterministicHashCode", BindingFlags.Public | BindingFlags.Static, [typeof(string)])
            ?? throw new MissingMethodException(helper.FullName, "GetDeterministicHashCode");
        Type width = _hash.ReturnType == typeof(int) || _hash.ReturnType == typeof(uint) ? typeof(uint)
            : _hash.ReturnType == typeof(ulong) ? typeof(ulong)
            : throw new NotSupportedException("未知的种子哈希类型：" + _hash.ReturnType);
        _constructor = rng.GetConstructor([width, typeof(string)])
            ?? throw new MissingMethodException(rng.FullName, $".ctor({width.Name}, String)");
    }
    public object FromText(string seed, string stream) => FromValue(_hash.Invoke(null, [seed])!, stream);
    public object FromRun(object runRng, string stream)
    {
        var property = runRng.GetType().GetProperty("Seed", BindingFlags.Public | BindingFlags.Instance)
            ?? throw new MissingMemberException(runRng.GetType().FullName, "Seed");
        return FromValue(property.GetValue(runRng)!, stream);
    }
    private object FromValue(object value, string stream)
    {
        object number = _constructor.GetParameters()[0].ParameterType == typeof(uint)
            ? value switch { int i => (object)unchecked((uint)i), uint value32 => value32, _ => throw new NotSupportedException("32 位随机数收到不匹配的种子类型") }
            : value is ulong value64 ? value64 : throw new NotSupportedException("64 位随机数收到不匹配的种子类型");
        return _constructor.Invoke([number, stream]);
    }
}

public static class RuntimeApi
{
    // 新增的尾部参数具有默认值时沿用游戏默认值；必需参数变化时在转场前明确失败。
    public static MethodInfo Bind(Type type, string name, bool isStatic, params Type[] supplied)
    {
        var candidates = type.GetMethods(BindingFlags.Public | (isStatic ? BindingFlags.Static : BindingFlags.Instance))
            .Where(m => m.Name == name && !m.ContainsGenericParameters)
            .Where(m => { var p = m.GetParameters(); return p.Length >= supplied.Length
                && supplied.Select((t, i) => p[i].ParameterType.IsAssignableFrom(t)).All(b => b)
                && p.Skip(supplied.Length).All(a => a.HasDefaultValue); }).OrderBy(m => m.GetParameters().Length).ToList();
        if (candidates.Count == 0) throw new MissingMethodException(type.FullName, name);
        if (candidates.Count > 1 && candidates[0].GetParameters().Length == candidates[1].GetParameters().Length)
            throw new AmbiguousMatchException(type.FullName + "." + name);
        return candidates[0];
    }
    public static object? Invoke(MethodInfo method, object? instance, params object?[] supplied)
    {
        var arguments = method.GetParameters().Select((p, i) => i < supplied.Length ? supplied[i] : p.DefaultValue).ToArray();
        try { return method.Invoke(instance, arguments); }
        catch (TargetInvocationException e) when (e.InnerException != null)
        { ExceptionDispatchInfo.Capture(e.InnerException).Throw(); throw; }
    }
}
