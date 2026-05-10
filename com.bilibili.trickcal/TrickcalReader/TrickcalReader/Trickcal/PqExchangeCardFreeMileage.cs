using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqExchangeCardFreeMileage {
    [Key(0)]
    public int CardId { get; set; }
}
