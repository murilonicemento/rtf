﻿using System.Text.Json.Serialization;

namespace RTF.Models;

public class AnkiRequestGetDecksName
{
    [JsonPropertyName("action")] public string Action { get; set; }

    [JsonPropertyName("version")] public int Version { get; set; } = 6;
}