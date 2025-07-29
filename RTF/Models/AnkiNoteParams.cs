using System.Text.Json.Serialization;

namespace RTF.Models;

public class AnkiNoteParams
{
    [JsonPropertyName("notes")] public List<AnkiNote> Notes { get; set; }
}

public class AnkiNote
{
    [JsonPropertyName("deckName")] public string DeckName { get; set; }

    [JsonPropertyName("modelName")] public string ModelName { get; set; }

    [JsonPropertyName("fields")] public AnkiFields Fields { get; set; }

    [JsonPropertyName("options")] public AnkiOptions Options { get; set; }

    [JsonPropertyName("tags")] public List<string> Tags { get; set; }
}

public class AnkiFields
{
    [JsonPropertyName("Frente")] public string Front { get; set; }

    [JsonPropertyName("Verso")] public string Back { get; set; }
    
    // [JsonPropertyName("Card ID")] public string CardId { get; set; }
}

public class AnkiOptions
{
    [JsonPropertyName("allowDuplicate")] public bool AllowDuplicate { get; set; }
}