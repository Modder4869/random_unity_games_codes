using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveSoloRaidRankingReward {
    [Key(0)]
    public int SoloRaidId { get; set; }
}
