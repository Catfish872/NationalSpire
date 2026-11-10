<#
Creates a directly extractable mods/NationalSpire package from an existing build.
Run from any directory: pwsh -File Tools/PackageMod.ps1 -OutputZip release/example.zip
The two legacy JSON paths deliberately remain in the overlay as inert objects.
This lets ZIP extraction replace obsolete manifests before the game scans them.
#>
[CmdletBinding()]
param(
    [Parameter(Mandatory=$true)][string]$OutputZip,
    [string]$DllPath,
    [string]$BuildLabel = 'overlay-compatible',
    [switch]$RuntimeOnly
)
$ErrorActionPreference = 'Stop'
$repo = [IO.Path]::GetFullPath((Join-Path $PSScriptRoot '..'))
if (!$DllPath) { $DllPath = Join-Path $repo '.godot/mono/temp/bin/Release/NationalSpire.dll' }
$DllPath = (Resolve-Path -LiteralPath $DllPath).Path
$output = [IO.Path]::GetFullPath($OutputZip)
if (Test-Path -LiteralPath $output) { throw 'Output already exists; choose a new package name.' }
$manifestPath = Join-Path $repo 'NationalSpire.json'
$manifest = Get-Content -LiteralPath $manifestPath -Raw | ConvertFrom-Json
if ($manifest.id -ne 'NationalSpire' -or !$manifest.has_dll -or $manifest.has_pck) { throw 'Unexpected mod manifest.' }
$dllHash = (Get-FileHash -LiteralPath $DllPath -Algorithm SHA256).Hash.ToLowerInvariant()
$files = [ordered]@{}
foreach ($entry in @(
    @('NationalSpire.dll', $DllPath),
    @('NationalSpire.json', $manifestPath),
    @('LICENSE', (Join-Path $repo 'LICENSE')),
    @('LICENSE-LUCIDE.txt', (Join-Path $repo 'Art/Affection/LICENSE-LUCIDE.txt')),
    @('BACKGROUND-SOURCES.txt', (Join-Path $repo 'date-backgrounds/SOURCES.txt'))
)) { $files[$entry[0]] = [IO.File]::ReadAllBytes($entry[1]) }
$utf8 = [Text.UTF8Encoding]::new($false)
$files['BUILD-INFO.txt'] = $utf8.GetBytes(([ordered]@{
    version=$manifest.version; build=$BuildLabel; dllSha256=$dllHash
    installation='Extract into mods and replace all same-name files.'
    legacyCompatibility=@('BUILD-INFO.json','portrait-style-library/library.json')
} | ConvertTo-Json -Depth 4))
# Keep these keys distinct from every ModManifest field. The game recognizes
# these objects as auxiliary data and returns before trying to load a mod.
$files['BUILD-INFO.json'] = $utf8.GetBytes('{"national_spire_legacy_build_info":{"retired":true,"details":"BUILD-INFO.txt"}}' + "`n")
$files['portrait-style-library/library.json'] = $utf8.GetBytes('{"national_spire_legacy_style_library":{"retired":true,"note":"Compatibility placeholder for ZIP overlay upgrades; existing images are preserved."}}' + "`n")
$instructions = @"
NationalSpire / GalTheSpire2 · $($manifest.version) 覆盖升级兼容版
构建：$BuildLabel

安装与升级
1. 保存进度并退出《杀戮尖塔2》。
2. 将此 ZIP 直接解压到游戏目录的 mods 文件夹，选择替换全部同名文件。
3. 确认文件位置为 mods/NationalSpire/NationalSpire.dll，然后启动游戏。

这份包同时适用于首次安装和覆盖旧版本。包内的 BUILD-INFO.json 和
portrait-style-library/library.json 是旧安装的兼容占位文件，游戏会安全跳过。
请一并覆盖它们；仅复制 DLL 无法完成旧文件兼容处理。
实际构建信息保存在 BUILD-INFO.txt。已有参考图片、背景和其他模组继续保留。
玩家存档、个人角色素材与 API 配置继续使用游戏用户目录。
默认背景、立绘和头像框资源内嵌于 DLL。

本版继续包含角色设计包导入修复：有效 PNG 经重新保存或替换后，按实际
图片内容重算校验值；路径、大小、图片格式和透明通道校验继续执行。
项目：https://github.com/Catfish872/NationalSpire
许可见 LICENSE；图标及背景来源见附带说明。
"@
$files['安装说明.txt'] = $utf8.GetBytes($instructions)
$hashLines = foreach ($name in $files.Keys) {
    $hash = [Convert]::ToHexString([Security.Cryptography.SHA256]::HashData($files[$name])).ToLowerInvariant()
    "$hash  $name"
}
$files['SHA256SUMS.txt'] = $utf8.GetBytes(($hashLines -join "`n") + "`n")
if ($RuntimeOnly) {
    foreach ($name in @('BUILD-INFO.txt','安装说明.txt','SHA256SUMS.txt')) { $files.Remove($name) }
    $files['BUILD-INFO.json'] = $utf8.GetBytes('{"national_spire_legacy_build_info":{"retired":true}}' + "`n")
}
$manifestKeys = @('id','name','author','description','version','has_dll','has_pck','dependencies','affects_gameplay','min_game_version')
foreach ($name in $files.Keys | Where-Object { $_.EndsWith('.json') -and $_ -ne 'NationalSpire.json' }) {
    $node = [Text.Json.JsonDocument]::Parse($utf8.GetString($files[$name]))
    try {
        if ($node.RootElement.ValueKind -ne [Text.Json.JsonValueKind]::Object) { throw "Auxiliary JSON must be an object: $name" }
        foreach ($property in $node.RootElement.EnumerateObject()) {
            if ($property.Name -in $manifestKeys) { throw "Auxiliary JSON contains a manifest field: $name / $($property.Name)" }
        }
    } finally { $node.Dispose() }
}
New-Item -ItemType Directory -Path (Split-Path -Parent $output) -Force | Out-Null
$zip = [IO.Compression.ZipFile]::Open($output, [IO.Compression.ZipArchiveMode]::Create)
try {
    foreach ($name in $files.Keys) {
        $stream = $zip.CreateEntry('NationalSpire/' + $name, [IO.Compression.CompressionLevel]::Optimal).Open()
        try { $stream.Write($files[$name], 0, $files[$name].Length) } finally { $stream.Dispose() }
    }
} finally { $zip.Dispose() }
$zip = [IO.Compression.ZipFile]::OpenRead($output)
try {
    if ($zip.Entries.Count -ne $files.Count) { throw 'ZIP entry count mismatch.' }
    foreach ($name in $files.Keys) {
        $stream = $zip.GetEntry('NationalSpire/' + $name).Open()
        try { $actual = [Convert]::ToHexString([Security.Cryptography.SHA256]::HashData($stream)) }
        finally { $stream.Dispose() }
        if ($actual -ne [Convert]::ToHexString([Security.Cryptography.SHA256]::HashData($files[$name]))) { throw "ZIP content mismatch: $name" }
    }
} finally { $zip.Dispose() }
[pscustomobject]@{ Package=$output; Version=$manifest.version; Files=$files.Count; Bytes=(Get-Item -LiteralPath $output).Length; SHA256=(Get-FileHash -LiteralPath $output).Hash; DLL_SHA256=$dllHash }
