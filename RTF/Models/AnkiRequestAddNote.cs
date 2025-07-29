using System.Text.Json.Serialization;

namespace RTF.Models;

public class AnkiRequestAddNote
{
    [JsonPropertyName("action")] public string Action { get; set; }

    [JsonPropertyName("version")] public int Version { get; set; } = 6;

    [JsonPropertyName("params")] public object Params { get; set; }
}