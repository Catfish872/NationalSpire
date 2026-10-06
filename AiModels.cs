using System.Net.Http.Headers;
using System.Text.Json;

namespace NationalSpire;

public static partial class AiService
{
    internal static Uri ModelsEndpoint(string endpoint)
    {
        if (!Uri.TryCreate(endpoint.Trim(), UriKind.Absolute, out var address) || address.Scheme is not ("http" or "https") || address.Host.Length == 0)
            throw new ArgumentException("请填写完整的 http:// 或 https:// 服务地址。");
        var builder = new UriBuilder(address) { Fragment = "" };
        string path = builder.Path.TrimEnd('/');
        if (path.EndsWith("/chat/completions", StringComparison.OrdinalIgnoreCase)) path = path[..^"/chat/completions".Length] + "/models";
        else if (!path.EndsWith("/models", StringComparison.OrdinalIgnoreCase)) path = path.Length == 0 ? "/v1/models" : path + "/models";
        builder.Path = path; return builder.Uri;
    }
    public static async Task<IReadOnlyList<string>> FetchModelsAsync(string endpoint, string? enteredKey)
    {
        string? key = string.IsNullOrWhiteSpace(enteredKey) ? CurrentKey : enteredKey.Trim();
        if (string.IsNullOrWhiteSpace(key)) throw new InvalidOperationException("请先填写 API 密钥。");
        Diagnostics.RegisterSecret(key);
        var uri = ModelsEndpoint(endpoint);
        using var request = new HttpRequestMessage(HttpMethod.Get, uri);
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", key);
        request.Options.Set(TimeoutOption, TimeSpan.FromSeconds(30));
        Diagnostics.Record("ai.models.request", new { endpoint = uri.ToString(), credential = string.IsNullOrWhiteSpace(enteredKey) ? "saved" : "input" });
        string rawBody = "";
        try
        {
            using var response = await Transport(request);
            string body = await response.Content.ReadAsStringAsync();
            rawBody = body;
            Diagnostics.Record("ai.models.response", new { status = (int)response.StatusCode, body });
            if (!response.IsSuccessStatusCode) throw new InvalidOperationException(await HttpFailure(response));
            using var document = JsonDocument.Parse(body);
            var root = document.RootElement;
            if (root.ValueKind != JsonValueKind.Object || !root.TryGetProperty("data", out var rows) || rows.ValueKind != JsonValueKind.Array)
                throw new InvalidDataException("接口没有返回模型列表。\n" + Diagnostics.Redact(body));
            return rows.EnumerateArray().Where(row => row.ValueKind == JsonValueKind.Object && row.TryGetProperty("id", out var id) && id.ValueKind == JsonValueKind.String)
                .Select(row => row.GetProperty("id").GetString()!).Where(id => !string.IsNullOrWhiteSpace(id))
                .Distinct(StringComparer.Ordinal).Order(StringComparer.OrdinalIgnoreCase).ToArray();
        }
        catch (JsonException e)
        {
            Diagnostics.Record("ai.models.failed", new { error = FailureReason(e) });
            throw new InvalidDataException("接口返回的内容不是有效的模型列表 JSON。\n" + Diagnostics.Redact(rawBody), e);
        }
        catch (Exception e) { Diagnostics.Record("ai.models.failed", new { error = FailureReason(e) }); throw; }
    }
}
