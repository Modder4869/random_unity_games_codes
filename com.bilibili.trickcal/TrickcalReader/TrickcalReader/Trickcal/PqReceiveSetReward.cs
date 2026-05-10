using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveSetReward {
    [Key(0)]
    public int SetId { get; set; }
}
