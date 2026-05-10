using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveWWESuccessCountReward {
    [Key(0)]
    public int SeasonId { get; set; }
    [Key(1)]
    public int SuccessRewardUId { get; set; }
}
