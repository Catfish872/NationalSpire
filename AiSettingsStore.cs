using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using Godot;

namespace NationalSpire;

public static class AiSettingsStore
{
    private static AiOptions? _options;
    private static string _saved = "", _savedPath = "";
    private static string SettingsPath => ProjectSettings.GlobalizePath("user://national_spire_ai_settings.json");
    private static string SecretPath => ProjectSettings.GlobalizePath("user://national_spire_ai_key.bin");
    public static AiOptions Load(AiOptions legacy)
    {
        if (_options != null) return _options;
        try { if (File.Exists(SettingsPath)) _options = JsonSerializer.Deserialize<AiOptions>(File.ReadAllText(SettingsPath)); }
        catch { GD.PushWarning("[NationalSpire] AI 配置无法读取，使用生涯中的配置副本。"); }
        return _options ??= legacy;
    }
    public static void Save(AiOptions options)
    {
        string content = JsonSerializer.Serialize(options);
        if (_saved == content && _savedPath == SettingsPath && File.Exists(SettingsPath)) { _options = options; return; }
        Directory.CreateDirectory(Path.GetDirectoryName(SettingsPath)!);
        File.WriteAllText(SettingsPath + ".tmp", content);
        File.Move(SettingsPath + ".tmp", SettingsPath, true);
        _options = options; _saved = content; _savedPath = SettingsPath;
    }
    public static string? ReadKey()
    {
        if (!OperatingSystem.IsWindows() || !File.Exists(SecretPath))
        {
            Diagnostics.Record("ai.credential.read", new { status = OperatingSystem.IsWindows() ? "missing" : "unsupported" });
            return null;
        }
        try
        {
            string value = Encoding.UTF8.GetString(Transform(File.ReadAllBytes(SecretPath), false));
            Diagnostics.RegisterSecret(value);
            Diagnostics.Record("ai.credential.read", new { status = string.IsNullOrWhiteSpace(value) ? "empty" : "loaded" });
            return value;
        }
        catch (Exception e)
        {
            Diagnostics.Record("ai.credential.read", new { status = "failed", error = e.GetType().Name });
            GD.PushWarning("[NationalSpire] 已保存密钥无法解密，请重新输入。"); return null;
        }
    }
    public static void SaveKey(string key)
    {
        if (string.IsNullOrWhiteSpace(key)) { if (File.Exists(SecretPath)) File.Delete(SecretPath); return; }
        if (!OperatingSystem.IsWindows()) throw new PlatformNotSupportedException("当前系统仅支持临时密钥。");
        Directory.CreateDirectory(Path.GetDirectoryName(SecretPath)!);
        File.WriteAllBytes(SecretPath + ".tmp", Transform(Encoding.UTF8.GetBytes(key), true));
        File.Move(SecretPath + ".tmp", SecretPath, true);
    }
    // DPAPI 将密钥绑定到当前 Windows 用户；生涯文件及诊断不包含明文密钥。
    [StructLayout(LayoutKind.Sequential)] private struct Blob { public int Length; public IntPtr Data; }
    [DllImport("crypt32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool CryptProtectData(ref Blob input, string? description, IntPtr entropy, IntPtr reserved, IntPtr prompt, int flags, out Blob output);
    [DllImport("crypt32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool CryptUnprotectData(ref Blob input, IntPtr description, IntPtr entropy, IntPtr reserved, IntPtr prompt, int flags, out Blob output);
    [DllImport("kernel32.dll")] private static extern IntPtr LocalFree(IntPtr memory);
    private static byte[] Transform(byte[] bytes, bool protect)
    {
        var input = new Blob { Length = bytes.Length, Data = Marshal.AllocHGlobal(bytes.Length) };
        Blob output = default;
        try
        {
            Marshal.Copy(bytes, 0, input.Data, bytes.Length);
            bool ok = protect ? CryptProtectData(ref input, "NationalSpire", IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, 1, out output)
                : CryptUnprotectData(ref input, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, 1, out output);
            if (!ok) throw new System.ComponentModel.Win32Exception(Marshal.GetLastWin32Error());
            var result = new byte[output.Length]; Marshal.Copy(output.Data, result, 0, result.Length); return result;
        }
        finally { Marshal.FreeHGlobal(input.Data); if (output.Data != IntPtr.Zero) LocalFree(output.Data); Array.Clear(bytes); }
    }
}
