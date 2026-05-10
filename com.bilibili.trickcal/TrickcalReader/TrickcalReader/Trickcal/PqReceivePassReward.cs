using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceivePassReward {
    [Key(0)]
    public int EventId { get; set; }
    [Key(1)]
    public bool IsPaid { get; set; }
    [Key(2)]
    public short Level { get; set; }
}
