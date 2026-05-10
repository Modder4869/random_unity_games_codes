using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSetCard {
    [Key(0)]
    public int CardId { get; set; }
    [Key(1)]
    public short CardLevel { get; set; }
}
