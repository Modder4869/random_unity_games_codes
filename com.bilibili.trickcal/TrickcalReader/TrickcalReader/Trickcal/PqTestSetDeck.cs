using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSetDeck {
    [Key(0)]
    public DeckSettings[] DeckSettings { get; set; }
}
