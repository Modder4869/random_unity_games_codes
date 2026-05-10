using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqOpenCard {
    [Key(0)]
    public int CardId { get; set; }
}
