using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class FlatReceivedData {
    [Key(0)]
    public int FlatUid { get; set; }
    [Key(1)]
    public int ReceivedDay { get; set; }
    [Key(2)]
    public RewardData ReceivedRewardData { get; set; }
}
