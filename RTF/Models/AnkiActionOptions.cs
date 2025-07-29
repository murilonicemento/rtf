namespace RTF;

public enum AnkiActionOptions
{
    DeckNames,
    AddNote,
}

public static class AnkiActionOptionsExtensions
{
    public static string ToActionString(this AnkiActionOptions action)
    {
        return action switch
        {
            AnkiActionOptions.DeckNames => "deckNames",
            AnkiActionOptions.AddNote => "addNote",
            _ => throw new ArgumentOutOfRangeException(nameof(action), action, null)
        };
    }
}