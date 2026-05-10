using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveChaosArenaDailyReward {
    [Key(0)]
    public int ChaosArenaSeasonId { get; set; }
}
