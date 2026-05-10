using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqExchangeAllCardFreeMileages {
    [Key(0)]
    public CardType Type { get; set; }
}
