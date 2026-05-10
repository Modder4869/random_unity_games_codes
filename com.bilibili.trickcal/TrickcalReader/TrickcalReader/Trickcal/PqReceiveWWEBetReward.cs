using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveWWEBetReward {
    [Key(0)]
    public int SeasonId { get; set; }
    [Key(1)]
    public int[] MatchIds { get; set; }
}
