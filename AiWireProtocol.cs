using System.Text.Json;
using System.Text.Json.Nodes;

namespace NationalSpire;

// 存档标识留在程序内部；模型只处理当前请求的短编号。
internal sealed class AiWireProtocol
{
    private static readonly System.Text.Json.JsonSerializerOptions Json = new() { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping };
    private readonly Dictionary<string, string> _encode = new();
    private readonly Dictionary<string, string> _decode = new();
    private readonly List<(string Earlier, string Current)> _names = [];
    private readonly CareerData _data;
    private static readonly HashSet<string> IdFields = ["id", "Id", "authorId", "AuthorId", "parentId", "ParentId", "postId", "PostId", "sourcePostId", "sourceReplyId", "allowedAuthors", "requiredAuthors", "messageId", "People"];
    internal AiWireProtocol(CareerData data)
    {
        _data = data;
        void Add(string id, string shortId)
        { if (id.Length > 0 && id != "player" && _encode.TryAdd(id, shortId)) _decode.Add(shortId, id); }
        int person = 0, post = 0, comment = 0;
        foreach (var p in data.People)
        {
            Add(p.Id, "u" + ++person);
            foreach (string alias in p.HandleAliases.Where(a => a != p.PublicName && a.Length > 0)) _names.Add((alias, p.PublicName));
        }
        foreach (string alias in data.PlayerNameAliases.Where(a => a != CareerEngine.Name(data) && a.Length > 0))
            _names.Add((alias, CareerEngine.Name(data)));
        foreach (var p in CommunityThreads.All(data))
        {
            Add(p.Id, "t" + ++post);
            foreach (var r in p.Replies) Add(r.Id, "c" + ++comment);
        }
    }
    internal string Encode(string context)
    {
        var node = JsonNode.Parse(context)!;
        AddMemorySources(node);
        // 只为本次材料中确实出现的旧称提供身份对照，历史原文继续按原样保存。
        string readable = node.ToJsonString(Json);
        var referenced = _names.Where(n => readable.Contains(n.Earlier, StringComparison.Ordinal)).Distinct().ToArray();
        if (referenced.Length > 0)
            node["nameHistory"] = new JsonArray(referenced.Select(n => (JsonNode)new JsonObject
                { ["原ID"] = n.Earlier, ["现ID"] = n.Current }).ToArray());
        // 记忆只用于提供经历与归属，返回协议不引用记忆记录的存档标识。
        foreach (string key in new[] { "memory", "communityMemory" })
            if (node[key] is JsonArray memories)
                foreach (var memory in memories.OfType<JsonObject>()) { memory.Remove("Id"); memory.Remove("PostId"); }
        Rewrite(node, _encode, calendar: _data); return node.ToJsonString(Json);
    }
    // 历史评论保留原帖与父回复。来源按帖子编号合并，人物使用具名身份。
    private void AddMemorySources(JsonNode node)
    {
        var sources = CommunityThreads.All(_data).ToDictionary(p => p.Id);
        var selected = new Dictionary<string, HashSet<string>>();
        foreach (string key in new[] { "memory", "communityMemory" })
        {
            if (node[key] is not JsonArray memories) continue;
            foreach (var memory in memories.OfType<JsonObject>())
            {
                string postId = memory["PostId"]?.GetValue<string>() ?? "", id = memory["Id"]?.GetValue<string>() ?? "";
                if (!sources.TryGetValue(postId, out var post)) continue;
                var reply = post.Replies.FirstOrDefault(r => id == postId + ":" + r.Id);
                if (reply == null) continue;
                memory["sourcePostId"] = postId; memory["sourceReplyId"] = reply.Id;
                memory["author"] = CareerEngine.DisplayName(_data, reply.AuthorId);
                memory["parentId"] = reply.ParentId;
                if (!selected.TryGetValue(postId, out var ancestors)) selected.Add(postId, ancestors = []);
                var replies = post.Replies.ToDictionary(r => r.Id);
                while (replies.TryGetValue(reply.ParentId, out var parent) && ancestors.Add(parent.Id)) reply = parent;
            }
        }
        if (selected.Count == 0) return;
        // 当前回帖目标已经包含正文和评论时，来源仅补充尚未提供的父回复。
        var supplied = (node["targets"] as JsonArray ?? []).OfType<JsonObject>().ToDictionary(p => p["Id"]!.GetValue<string>());
        var records = new JsonArray();
        foreach (var entry in selected.OrderBy(x => x.Key, StringComparer.Ordinal))
        {
            var post = sources[entry.Key];
            var record = new JsonObject { ["postId"] = post.Id };
            HashSet<string> existing = [];
            if (supplied.TryGetValue(post.Id, out var target))
                existing = (target["conversation"] as JsonArray ?? []).Select(r => r!["Id"]!.GetValue<string>()).ToHashSet();
            else
            {
                record["title"] = post.Title; record["author"] = CareerEngine.DisplayName(_data, post.AuthorId); record["day"] = post.Day;
                record["body"] = post.Body; record["bodyKind"] = "作者公开发言";
                if (post.SourceBody.Length > 0 && !CommunityThreads.IsHuman(_data, post.AuthorId)) record["officialRecord"] = AiGeneratedText.Source(post);
            }
            record["parentComments"] = JsonSerializer.SerializeToNode(post.Replies.Where(r => entry.Value.Contains(r.Id) && !existing.Contains(r.Id))
                .Select(r => new { r.Id, r.ParentId, author = CareerEngine.DisplayName(_data, r.AuthorId), r.Day, r.Body }), Json);
            records.Add(record);
        }
        node["communitySources"] = records;
    }
    internal string Decode(string response, bool normalizeFields = true, string? expectedArray = null)
    {
        var node = ReadBody(response, normalizeFields, expectedArray);
        if (normalizeFields) NormalizeFields(node);
        Rewrite(node, _decode); return node.ToJsonString(Json);
    }
    private static JsonNode ReadBody(string response, bool extract, string? expectedArray)
    {
        try
        {
            var direct = JsonNode.Parse(response);
            if (direct is not JsonObject) throw new InvalidDataException("模型正文需要是 JSON 对象");
            if (expectedArray != null && !HasRows(direct, expectedArray, false))
                throw new InvalidDataException("模型正文缺少 " + expectedArray + " 数组");
            return direct;
        }
        catch (JsonException) when (extract) { }

        response = UnwrapLeadingBlocks(response);

        // 按 JSON 的括号、字符串及转义规则识别完整片段，不依赖思考标签或代码围栏名称。
        // 不从未闭合对象中提取子对象，避免把截断的整批结果当作完整结果。
        JsonNode? selected = null;
        int start = -1; bool quoted = false, escaped = false;
        var brackets = new Stack<char>();
        for (int index = 0; index < response.Length; index++)
        {
            char c = response[index];
            if (start < 0)
            {
                if (c is not ('{' or '[')) continue;
                start = index; brackets.Push(c); quoted = escaped = false; continue;
            }
            if (quoted)
            {
                if (escaped) escaped = false;
                else if (c == '\\') escaped = true;
                else if (c == '"') quoted = false;
                continue;
            }
            if (c == '"') { quoted = true; continue; }
            if (c is '{' or '[') { brackets.Push(c); continue; }
            if (c is not ('}' or ']')) continue;
            if (brackets.Peek() != (c == '}' ? '{' : '['))
                throw new InvalidDataException("模型返回的 JSON 括号不匹配");
            brackets.Pop();
            if (brackets.Count > 0) continue;
            JsonNode? candidate = null;
            try { candidate = JsonNode.Parse(response[start..(index + 1)]); } catch (JsonException) { }
            start = -1;
            if (candidate is not JsonObject) continue;
            bool matches = expectedArray != null ? HasRows(candidate, expectedArray, true)
                : new[] { "posts", "reactions", "slides", "profiles" }.Any(key => HasRows(candidate, key, true));
            if (!matches) continue;
            if (selected != null) throw new InvalidDataException("模型返回了多份符合要求的 JSON，无法确定最终正文");
            selected = candidate;
        }
        if (start >= 0) throw new InvalidDataException("模型返回的 JSON 片段未完整结束");
        return selected ?? throw new InvalidDataException("模型返回内容中没有符合本次请求的完整 JSON 正文");
    }
    private static string UnwrapLeadingBlocks(string response)
    {
        string text = response.Trim();
        var blocks = new List<string>();
        while (text.Length > 0)
        {
            int begin, end, after;
            if (text[0] == '【')
            {
                begin = 1; end = -1; int depth = 1;
                for (int i = 1; i < text.Length; i++)
                {
                    if (text[i] == '【') depth++;
                    if (text[i] == '】' && --depth == 0) { end = i; break; }
                }
                if (end < 0) throw new InvalidDataException("模型返回的前置说明未完整结束");
                after = end + 1;
            }
            else
            {
                var opening = System.Text.RegularExpressions.Regex.Match(text, @"\A<([\p{L}_][\p{L}\p{N}_.:-]*)(?:\s+[^<>]*)?>");
                if (!opening.Success) break;
                begin = opening.Length; end = -1; after = -1; int depth = 1;
                string name = System.Text.RegularExpressions.Regex.Escape(opening.Groups[1].Value);
                var boundaries = System.Text.RegularExpressions.Regex.Matches(text[begin..], @"<(/?)" + name + @"(?:\s+[^<>]*)?>", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                foreach (System.Text.RegularExpressions.Match boundary in boundaries)
                {
                    depth += boundary.Groups[1].Length == 0 ? 1 : -1;
                    if (depth != 0) continue;
                    end = begin + boundary.Index; after = end + boundary.Length; break;
                }
                if (end < 0) throw new InvalidDataException("模型返回的标签未完整闭合");
            }
            // 有未包裹的后续正文时跳过前置块；只有包裹内容时保留全部候选，避免选择最后一份草稿。
            blocks.Add(text[begin..end]);
            string remainder = text[after..].Trim();
            if (remainder.Length == 0) return string.Join("\n", blocks);
            text = remainder;
        }
        return text;
    }
    private static bool HasRows(JsonNode node, string name, bool requireRows)
        => node.AsObject().Any(p => p.Key.Equals(name, StringComparison.OrdinalIgnoreCase)
            && p.Value is JsonArray rows && (!requireRows || rows.Count > 0));
    private static void NormalizeFields(JsonNode node)
    {
        if (node is JsonObject obj)
            foreach (string key in obj.Select(p => p.Key).ToArray())
            {
                string canonical = key.ToLowerInvariant() switch
                {
                    "profiles" => "profiles", "slides" => "slides", "posts" => "posts", "reactions" => "reactions", "replies" => "replies", "id" => "id", "postid" => "postId",
                    "authorid" => "authorId", "parentid" => "parentId", "body" => "body", "title" => "title", _ => key
                };
                var value = obj[key];
                if (canonical != key)
                {
                    if (obj.ContainsKey(canonical)) throw new InvalidDataException("返回字段重复");
                    obj.Remove(key); obj[canonical] = value;
                }
                if (value != null) NormalizeFields(value);
            }
        else if (node is JsonArray array) foreach (var value in array) if (value != null) NormalizeFields(value);
    }
    private static void Rewrite(JsonNode node, Dictionary<string, string> map, bool identifiers = false, CareerData? calendar = null)
    {
        if (node is JsonObject obj)
            foreach (var key in obj.Select(p => p.Key).ToArray())
            {
                var value = obj[key]; bool id = IdFields.Contains(key);
                if (calendar != null && GameCalendar.ConvertDateField(calendar, obj, key)) continue;
                if (id && value is JsonValue text && text.TryGetValue<string>(out var raw) && map.TryGetValue(raw, out var replacement)) obj[key] = replacement;
                else if (value != null) Rewrite(value, map, id, calendar);
            }
        else if (node is JsonArray array)
            for (int i = 0; i < array.Count; i++)
            {
                var value = array[i];
                if (identifiers && value is JsonValue text && text.TryGetValue<string>(out var raw) && map.TryGetValue(raw, out var replacement)) array[i] = replacement;
                else if (value != null) Rewrite(value, map, identifiers, calendar);
            }
    }
}
