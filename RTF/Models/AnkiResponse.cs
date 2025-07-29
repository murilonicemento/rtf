using System.Text.Json.Serialization;

namespace RTF.Models;

public class AnkiResponse<T>
{
    [JsonPropertyName("result")] public T Result { get; set; }
    [JsonPropertyName("error")] public string Error { get; set; }
}