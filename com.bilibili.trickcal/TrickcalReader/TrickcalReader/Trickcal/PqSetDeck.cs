using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSetDeck {
    [Key(0)]
    public DeckSettings[] Decks { get; set; }
}
