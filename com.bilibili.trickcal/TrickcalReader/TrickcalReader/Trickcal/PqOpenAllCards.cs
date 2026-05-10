using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqOpenAllCards {
    [Key(0)]
    public CardType Type { get; set; }
}
