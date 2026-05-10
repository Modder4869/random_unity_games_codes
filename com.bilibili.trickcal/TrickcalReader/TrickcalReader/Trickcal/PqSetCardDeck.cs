using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSetCardDeck {
    [Key(0)]
    public UserCardDeckKey Key { get; set; }
    [Key(1)]
    public int[] DisabledCardIds { get; set; }
    [Key(2)]
    public string Name { get; set; }
}
