# PortraitPromptExport.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`5078CA638BD80047352F1B6813529BBAEB395655C7A11197F1EB0A207DE1BDF3`。来源：[源码](../../PortraitPromptExport.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.PortraitPromptExport`。

字段、事件及初始值（源码原样）：

```csharp
private const string Guide = """
        # 使用说明

        1. 先生成默认立绘：打开“基准立绘提示词.md”，复制全部内容，发给你使用的生图 AI。有画风参考图时，一起上传。满意后下载 PNG 原图，保存为 `{defaultFile}`。
        2. 再生成其他表情：打开“表情差分提示词.md”，每次复制一个框里的完整提示词。在同一对话中重新上传刚才满意的默认立绘，再发送这段提示词。每张都从同一张默认立绘开始。
        3. 保存图片：按每段上方写的文件名保存，例如 `happy.png`。检查人物完整、服装一致、背景确实透明；如果背景仍是一整块颜色，请让生图 AI 修改后重新下载。
        4. 导入游戏：把默认立绘和其他表情的 PNG 放在一起，压缩成 ZIP。在该角色的“立绘与场景”中点击导入立绘包，选择这个 ZIP。

        同一个表情有多张图时，可保存为 `happy_1.png`、`happy_2.png`，游戏会随机选用。默认立绘请保留上面指定的文件名。

        这三个文档用于生成图片。图片完成后再打包导入游戏；整个角色连同图片的分享，请使用游戏里的“导出角色设计”。
        """;
```

<a id="symbol-381ffd792ba0"></a>

## `NationalSpire.PortraitPromptExport.Files(NationalSpire.PortraitDesign, string) — public static Dictionary<string, string> Files(PortraitDesign design, string name)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PortraitPromptExport.Write(string, NationalSpire.PortraitDesign, string)`](PortraitPromptExport.cs.md#symbol-bb8047a026c0)

**调用：** [`NationalSpire.PortraitDesigns.Error(NationalSpire.PortraitDesign)`](PortraitDesign.cs.md#symbol-4591e55fbd90)；[`NationalSpire.PortraitModelPrompts.Get(NationalSpire.PortraitDesign)`](PortraitModelPrompts.cs.md#symbol-78c7c2214dc7)；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.Text.StringBuilder.Append(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；`System.Text.StringBuilder.Append(string?)`；`System.Text.StringBuilder.StringBuilder(string?)`；`System.Text.StringBuilder.ToString()`；`string.Contains(string, System.StringComparison)`；`string.IsNullOrWhiteSpace(string?)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`string.Replace(char, char)`；`string.Replace(string, string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.PortraitDesign.Basics`；`NationalSpire.PortraitDesign.DefaultEmotionId`；`NationalSpire.PortraitDesign.Emotions`；`NationalSpire.PortraitDesign.Outfits`；`NationalSpire.PortraitDesign.SelectedOutfit`；`NationalSpire.PortraitDesigns.BasicFields`；`NationalSpire.PortraitDesigns.Error(NationalSpire.PortraitDesign)`；`NationalSpire.PortraitDesigns.OutfitFields`；`NationalSpire.PortraitEmotion.Description`；`NationalSpire.PortraitEmotion.Enabled`；`NationalSpire.PortraitEmotion.Id`；`NationalSpire.PortraitEmotion.Name`；`NationalSpire.PortraitModelPrompts.Get(NationalSpire.PortraitDesign)`；`NationalSpire.PortraitModelPrompts.Movement`；`NationalSpire.PortraitOutfit.Fields`；`NationalSpire.PortraitOutfit.Id`；`NationalSpire.PortraitOutfit.Name`；`NationalSpire.PortraitPromptExport.Guide`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PortraitDesigns.Error(NationalSpire.PortraitDesign)`；输入表达式：`PortraitDesigns.Error(design)`；返回值紧邻使用处：`IsPatternExpressionSyntax: PortraitDesigns.Error(design) is { } error`
- `NationalSpire.PortraitModelPrompts.Get(NationalSpire.PortraitDesign)`；输入表达式：`PortraitModelPrompts.Get(design)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PortraitModelPrompts.Get(design)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, string> { ["基准立绘提示词.md"] = master, ["使用说明.md"] = Guide.Replace("{defaultFile}", neutral) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, string> { ["基准立绘提示词.md"] = master, ["使用说明.md"] = Guide.Replace("{defaultFile}", neutral) }`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`design.Emotions.Where(e => e.Enabled).OrderBy(e => e.Id == design.DefaultEmotionId ? 0 : 1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: design.Emotions.Where(e => e.Enabled).OrderBy(e => e.Id == design.DefaultEmotionId ? 0 : 1).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`PortraitDesigns.BasicFields.Where(f => !string.IsNullOrWhiteSpace(design.Basics.GetValueOrDefault(f.Id))).Select(f => $"{f.Label}：{design.Basics.GetValueOrDefault(f.Id, "由角色基准图确定")}")`；返回值紧邻使用处：`ArgumentSyntax: PortraitDesigns.BasicFields.Where(f => !string.IsNullOrWhiteSpace(design.Basics.GetValueOrDefault(f.Id))).Select(f => $"{f.Label}：{design.Basics.GetValueOrDefault(f.Id, "由角色基准图确定")}")`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`PortraitDesigns.OutfitFields.Where(f => !string.IsNullOrWhiteSpace(outfit.Fields.GetValueOrDefault(f.Id))).Select(f => $"{f.Label}：{outfit.Fields.GetValueOrDefault(f.Id, "")}")`；返回值紧邻使用处：`ArgumentSyntax: PortraitDesigns.OutfitFields.Where(f => !string.IsNullOrWhiteSpace(outfit.Fields.GetValueOrDefault(f.Id))).Select(f => $"{f.Label}：{outfit.Fields.GetValueOrDefault(f.Id, "")}")`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`design.Outfits.Single(o => o.Id == design.SelectedOutfit)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = design.Outfits.Single(o => o.Id == design.SelectedOutfit)`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`emotions.Single(e => e.Id == design.DefaultEmotionId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: emotions.Single(e => e.Id == design.DefaultEmotionId).Description`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`design.Emotions.Where(e => e.Enabled).OrderBy(e => e.Id == design.DefaultEmotionId ? 0 : 1).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = design.Emotions.Where(e => e.Enabled).OrderBy(e => e.Id == design.DefaultEmotionId ? 0 : 1).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`PortraitDesigns.BasicFields.Where(f => !string.IsNullOrWhiteSpace(design.Basics.GetValueOrDefault(f.Id)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PortraitDesigns.BasicFields.Where(f => !string.IsNullOrWhiteSpace(design.Basics.GetValueOrDefault(f.Id))).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`PortraitDesigns.OutfitFields.Where(f => !string.IsNullOrWhiteSpace(outfit.Fields.GetValueOrDefault(f.Id)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PortraitDesigns.OutfitFields.Where(f => !string.IsNullOrWhiteSpace(outfit.Fields.GetValueOrDefault(f.Id))).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`design.Emotions.Where(e => e.Enabled)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: design.Emotions.Where(e => e.Enabled).OrderBy`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`emotions.Where(e => e.Id != design.DefaultEmotionId)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var emotion in emotions.Where(e => e.Id != design.DefaultEmotionId)) { number++; string prompt = $"现在开始生成第（{number}）个差分。\n严格在默认基准立绘上修改角色的表情差分。你只需要修改表情和动作姿态，不需要修改任何其他内容，包括服饰，画面尺寸，背景透明通道。\n表情与动作：{emotion.Description}\n\n按上述表情和动作调整相应部位，保持其余已确认细节、光影、上色和低噪质感。每张独立差分重新使用同一默认立绘。\n\n{alpha}"; string fence = "```"; while (prompt.Contains(fence, StringComparison.Ordinal)) fence += "`"; expressions.Append($"## {number}. {emotion.Name.Replace('\r', ' ').Replace('\n', ' ')}\n\n情绪ID：`{emotion.Id}` · 保存文件：`{emotion.Id}.png`\n\n{fence}text\n{prompt}\n{fence}\n\n\n"); }`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`design.Basics.GetValueOrDefault(f.Id)`；返回值紧邻使用处：`ArgumentSyntax: design.Basics.GetValueOrDefault(f.Id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`outfit.Fields.GetValueOrDefault(f.Id)`；返回值紧邻使用处：`ArgumentSyntax: outfit.Fields.GetValueOrDefault(f.Id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`design.Basics.GetValueOrDefault(f.Id, "由角色基准图确定")`；返回值紧邻使用处：`InterpolationSyntax: {design.Basics.GetValueOrDefault(f.Id, "由角色基准图确定")}`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`outfit.Fields.GetValueOrDefault(f.Id, "")`；返回值紧邻使用处：`InterpolationSyntax: {outfit.Fields.GetValueOrDefault(f.Id, "")}`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException(error)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException(error);`
- `System.Text.StringBuilder.Append(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`expressions.Append($"## {number}. {emotion.Name.Replace('\r', ' ').Replace('\n', ' ')}\n\n情绪ID：`{emotion.Id}` · 保存文件：`{emotion.Id}.png`\n\n{fence}text\n{prompt}\n{fence}\n\n\n")`；返回值紧邻使用处：`ExpressionStatementSyntax: expressions.Append($"## {number}. {emotion.Name.Replace('\r', ' ').Replace('\n', ' ')}\n\n情绪ID：`{emotion.Id}` · 保存文件：`{emotion.Id}.png`\n\n{fence}text\n{prompt}\n{fence}\n\n\n");`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`expressions.Append("本次仅启用默认基准立绘，使用基准立绘提示词.md生成即可。\n")`；返回值紧邻使用处：`ExpressionStatementSyntax: expressions.Append("本次仅启用默认基准立绘，使用基准立绘提示词.md生成即可。\n");`
- `System.Text.StringBuilder.StringBuilder(string?)`；输入表达式：`new StringBuilder("# 情绪差分提示词\n\n默认基准立绘使用基准立绘提示词.md。下列差分按本次导出的启用顺序从1编号，每次复制一个代码块的完整内容。情绪名称、ID与保存文件名位于代码块外，供识别和保存。\n\n")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StringBuilder("# 情绪差分提示词\n\n默认基准立绘使用基准立绘提示词.md。下列差分按本次导出的启用顺序从1编号，每次复制一个代码块的完整内容。情绪名称、ID与保存文件名位于代码块外，供识别和保存。\n\n")`
- `System.Text.StringBuilder.ToString()`；输入表达式：`expressions.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: files["表情差分提示词.md"] = expressions.ToString()`
- `string.Contains(string, System.StringComparison)`；输入表达式：`prompt.Contains(fence, StringComparison.Ordinal)`；返回值紧邻使用处：`WhileStatementSyntax: while (prompt.Contains(fence, StringComparison.Ordinal)) fence += "`";`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(design.Basics.GetValueOrDefault(f.Id))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !string.IsNullOrWhiteSpace(design.Basics.GetValueOrDefault(f.Id))`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(outfit.Fields.GetValueOrDefault(f.Id))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !string.IsNullOrWhiteSpace(outfit.Fields.GetValueOrDefault(f.Id))`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n", PortraitDesigns.BasicFields.Where(f => !string.IsNullOrWhiteSpace(design.Basics.GetValueOrDefault(f.Id))).Select(f => $"{f.Label}：{design.Basics.GetValueOrDefault(f.Id, "由角色基准图确定")}"))`；返回值紧邻使用处：`BinaryExpressionSyntax: $"角色：{name}。\n" + string.Join("\n", PortraitDesigns.BasicFields.Where(f => !string.IsNullOrWhiteSpace(design.Basics.GetValueOrDefault(f.Id))).Select(f => $"{f.Label}：{design.Basics.GetValueOrDefault(f.Id, "由角色基准图确定")}"))`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n", PortraitDesigns.OutfitFields.Where(f => !string.IsNullOrWhiteSpace(outfit.Fields.GetValueOrDefault(f.Id))).Select(f => $"{f.Label}：{outfit.Fields.GetValueOrDefault(f.Id, "")}"))`；返回值紧邻使用处：`BinaryExpressionSyntax: $"角色：{name}。\n" + string.Join("\n", PortraitDesigns.BasicFields.Where(f => !string.IsNullOrWhiteSpace(design.Basics.GetValueOrDefault(f.Id))).Select(f => $"{f.Label}：{design.Basics.GetValueOrDefault(f.Id, "由角色基准图确定")}")) + $"\n套装：{outfit.Name}。\n" + string.Join("\n", PortraitDesigns.OutfitFields.Where(f => !string.IsNullOrWhiteSpace(outfit.Fields.GetValueOrDefault(f.Id))).Select(f => $"{f.Label}：{outfit.Fields.GetValueOrDefault(f.Id, "")}"))`
- `string.Replace(char, char)`；输入表达式：`emotion.Name.Replace('\r', ' ')`；返回值紧邻使用处：`MemberAccessExpressionSyntax: emotion.Name.Replace('\r', ' ').Replace`
- `string.Replace(char, char)`；输入表达式：`emotion.Name.Replace('\r', ' ').Replace('\n', ' ')`；返回值紧邻使用处：`InterpolationSyntax: {emotion.Name.Replace('\r', ' ').Replace('\n', ' ')}`
- `string.Replace(string, string?)`；输入表达式：`Guide.Replace("{defaultFile}", neutral)`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["使用说明.md"] = Guide.Replace("{defaultFile}", neutral)`

**赋值（含属性/字段和局部值）：**

- `["使用说明.md"]` = `Guide.Replace("{defaultFile}", neutral)`
- `["基准立绘提示词.md"]` = `master`
- `fence` += `"`"`
- `files["表情差分提示词.md"]` = `expressions.ToString()`

<a id="symbol-bb8047a026c0"></a>

## `NationalSpire.PortraitPromptExport.Write(string, NationalSpire.PortraitDesign, string) — public static string Write(string directory, PortraitDesign design, string name)`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenPortraitDesigner(NationalSpire.CareerData, string)`](PortraitDesignScreen.cs.md#symbol-3bb5119a73ca)

**调用：** [`NationalSpire.PortraitPromptExport.Files(NationalSpire.PortraitDesign, string)`](PortraitPromptExport.cs.md#symbol-381ffd792ba0)；`string.Concat<T>(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.DateTime.ToString(string?)`；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`；`System.IO.Compression.ZipArchive.CreateEntry(string, System.IO.Compression.CompressionLevel)`；`System.IO.Compression.ZipArchiveEntry.Open()`；`System.IO.Compression.ZipFile.Open(string, System.IO.Compression.ZipArchiveMode)`；`System.IO.Directory.CreateDirectory(string)`；`System.IO.File.Delete(string)`；`System.IO.File.Exists(string?)`；`System.IO.File.Move(string, string)`；`System.IO.Path.Combine(string, string)`；`System.IO.Path.GetInvalidFileNameChars()`；`System.IO.StreamWriter.StreamWriter(System.IO.Stream, System.Text.Encoding)`；`System.IO.StreamWriter.Write(string?)`；`System.Text.UTF8Encoding.UTF8Encoding(bool)`

**字段、属性、事件及方法组引用：** `NationalSpire.PortraitPromptExport.Files(NationalSpire.PortraitDesign, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PortraitPromptExport.Files(NationalSpire.PortraitDesign, string)`；输入表达式：`Files(design, name)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Files(design, name)`
- `string.Concat<T>(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`string.Concat(name.Select(c => Path.GetInvalidFileNameChars().Contains(c) ? '_' : c))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = string.Concat(name.Select(c => Path.GetInvalidFileNameChars().Contains(c) ? '_' : c))`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`Path.GetInvalidFileNameChars().Contains(c)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Path.GetInvalidFileNameChars().Contains(c) ? '_' : c`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`name.Select(c => Path.GetInvalidFileNameChars().Contains(c) ? '_' : c)`；返回值紧邻使用处：`ArgumentSyntax: name.Select(c => Path.GetInvalidFileNameChars().Contains(c) ? '_' : c)`
- `System.DateTime.ToString(string?)`；输入表达式：`DateTime.Now.ToString("yyyyMMdd-HHmmssfff")`；返回值紧邻使用处：`BinaryExpressionSyntax: "国运尖塔-立绘-" + safe + "-" + DateTime.Now.ToString("yyyyMMdd-HHmmssfff")`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`ElementAccessExpressionSyntax: Guid.NewGuid().ToString("N")[..6]`
- `System.IO.Compression.ZipArchive.CreateEntry(string, System.IO.Compression.CompressionLevel)`；输入表达式：`archive.CreateEntry(file.Key, CompressionLevel.Optimal)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: archive.CreateEntry(file.Key, CompressionLevel.Optimal).Open`
- `System.IO.Compression.ZipArchiveEntry.Open()`；输入表达式：`archive.CreateEntry(file.Key, CompressionLevel.Optimal).Open()`；返回值紧邻使用处：`ArgumentSyntax: archive.CreateEntry(file.Key, CompressionLevel.Optimal).Open()`
- `System.IO.Compression.ZipFile.Open(string, System.IO.Compression.ZipArchiveMode)`；输入表达式：`ZipFile.Open(temporary, ZipArchiveMode.Create)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ZipFile.Open(temporary, ZipArchiveMode.Create)`
- `System.IO.Directory.CreateDirectory(string)`；输入表达式：`Directory.CreateDirectory(directory)`；返回值紧邻使用处：`ExpressionStatementSyntax: Directory.CreateDirectory(directory);`
- `System.IO.File.Delete(string)`；输入表达式：`File.Delete(temporary)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Delete(temporary);`
- `System.IO.File.Exists(string?)`；输入表达式：`File.Exists(temporary)`；返回值紧邻使用处：`IfStatementSyntax: if (File.Exists(temporary)) File.Delete(temporary);`
- `System.IO.File.Move(string, string)`；输入表达式：`File.Move(temporary, path)`；返回值紧邻使用处：`ExpressionStatementSyntax: File.Move(temporary, path);`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(directory, "国运尖塔-立绘-" + safe + "-" + DateTime.Now.ToString("yyyyMMdd-HHmmssfff") + "-" + Guid.NewGuid().ToString("N")[..6] + ".zip")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Path.Combine(directory, "国运尖塔-立绘-" + safe + "-" + DateTime.Now.ToString("yyyyMMdd-HHmmssfff") + "-" + Guid.NewGuid().ToString("N")[..6] + ".zip")`
- `System.IO.Path.GetInvalidFileNameChars()`；输入表达式：`Path.GetInvalidFileNameChars()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Path.GetInvalidFileNameChars().Contains`
- `System.IO.StreamWriter.StreamWriter(System.IO.Stream, System.Text.Encoding)`；输入表达式：`new StreamWriter(archive.CreateEntry(file.Key, CompressionLevel.Optimal).Open(), new UTF8Encoding(false))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StreamWriter(archive.CreateEntry(file.Key, CompressionLevel.Optimal).Open(), new UTF8Encoding(false))`
- `System.IO.StreamWriter.Write(string?)`；输入表达式：`writer.Write(file.Value)`；返回值紧邻使用处：`ExpressionStatementSyntax: writer.Write(file.Value);`
- `System.Text.UTF8Encoding.UTF8Encoding(bool)`；输入表达式：`new UTF8Encoding(false)`；返回值紧邻使用处：`ArgumentSyntax: new UTF8Encoding(false)`

**赋值（含属性/字段和局部值）：**

- `safe` = `safe.Length > 36 ? safe[..36] : safe`
