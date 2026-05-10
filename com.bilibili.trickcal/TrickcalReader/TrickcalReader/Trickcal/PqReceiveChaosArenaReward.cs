using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveChaosArenaReward {
    [Key(0)]
    public int ChaosArenaSeasonId { get; set; }
    [Key(1)]
    public int ChaosArenaRewardUid { get; set; }
}
