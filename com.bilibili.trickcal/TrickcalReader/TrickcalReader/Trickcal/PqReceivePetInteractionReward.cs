using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceivePetInteractionReward {
    [Key(0)]
    public short Index { get; set; }
}
