using System.Text.Json;
using System.Text.Json.Serialization;

namespace NationalSpire;

/// <summary>Preserves optional module data in the original JSON shape across installations.</summary>
public abstract class ExtensibleData : IJsonOnDeserialized
{
    [JsonExtensionData]
    public Dictionary<string, object?> Extra { get; set; } = [];

    public T ExtensionValue<T>(string key, Func<T> create)
    {
        if (Extra.TryGetValue(key, out var raw))
        {
            if (raw is T value) return value;
            if (raw is JsonElement json && json.ValueKind != JsonValueKind.Null)
            {
                T? decoded = json.Deserialize<T>();
                if (decoded != null) { Extra[key] = decoded; return decoded; }
            }
        }
        T result = create(); Extra[key] = result; return result;
    }
    public void OnDeserialized()
    {
        // Keep scalar extension values compact; structured values remain opaque JSON.
        foreach (string key in Extra.Keys.ToArray())
            if (Extra[key] is JsonElement json)
                Extra[key] = json.ValueKind switch
                {
                    JsonValueKind.String => json.GetString(), JsonValueKind.True => true,
                    JsonValueKind.False => false, JsonValueKind.Null => null, _ => json
                };
    }
    public Dictionary<string, object?> CopyExtra() => Extra.ToDictionary(p => p.Key,
        p => p.Value is null or string or ValueType ? p.Value : (object?)JsonSerializer.SerializeToElement(p.Value));
    public static bool SameExtra(ExtensibleData a, ExtensibleData b) => a.Extra.Count == b.Extra.Count
        && a.Extra.All(p => b.Extra.TryGetValue(p.Key, out var value)
            && (Equals(p.Value, value) || JsonElement.DeepEquals(JsonSerializer.SerializeToElement(p.Value), JsonSerializer.SerializeToElement(value))));
}
