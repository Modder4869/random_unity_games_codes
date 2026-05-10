using MessagePack;
using System.Collections;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserWWEData {
    [Key(0)]
    public int[] MatchIds { get; set; }
    [Key(1)]
    public TeamType[] Bets { get; set; }
    [Key(2)]
    public BitArray BetRewardReceived { get; set; }
    [Key(3)]
    public int[] SuccessCountRewardReceived { get; set; }
}
