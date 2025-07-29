namespace RTF.Models;

public enum AnkiActionOptions
{
    DeckNames,
    AddNotes,
}

public static class AnkiActionOptionsExtensions
{
    public static string ToActionString(this AnkiActionOptions action)
    {
        return action switch
        {
            AnkiActionOptions.DeckNames => "deckNames",
            AnkiActionOptions.AddNotes => "addNotes",
            _ => throw new ArgumentOutOfRangeException(nameof(action), action, null)
        };
    }
}