using MessagePack;
using System.Collections;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserBingoEventData {
    [Key(0)]
    public int Round { get; set; }
    [Key(1)]
    public BitArray ReceivedReward { get; set; }
    [Key(2)]
    public int[] TileLocation { get; set; }
    [Key(3)]
    public int[] ReceivedLineBingoRewards { get; set; }
    [Key(4)]
    public bool IsReceivedRoundReward { get; set; }
    [Key(5)]
    public int OpenPatternGroupUid { get; set; }
    [Key(6)]
    public int[] PatternHiddenCounts { get; set; }
    [Key(7)]
    public int RoundDrawCount { get; set; }
    [Key(8)]
    public bool IsAllOpened { get; set; }
}
