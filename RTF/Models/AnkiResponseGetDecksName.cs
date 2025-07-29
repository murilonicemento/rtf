using System.Text.Json.Serialization;

namespace RTF.Models;

public class AnkiResponseGetDecksName
{
    [JsonPropertyName("result")] public string[] Result { get; set; }
    [JsonPropertyName("error")] public string Error { get; set; }
}