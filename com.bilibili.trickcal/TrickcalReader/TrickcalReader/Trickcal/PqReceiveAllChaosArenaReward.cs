using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveAllChaosArenaReward {
    [Key(0)]
    public int ChaosArenaSeasonId { get; set; }
}
