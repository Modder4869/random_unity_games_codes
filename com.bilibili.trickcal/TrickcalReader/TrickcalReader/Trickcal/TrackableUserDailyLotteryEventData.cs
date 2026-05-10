using MessagePack;
using System.Collections;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserDailyLotteryEventData {
    [Key(0)]
    public int[] SelectedRewardGroups { get; set; }
    [Key(1)]
    public UserDailyLotteryStatus[] LotteryStatus { get; set; }
    [Key(2)]
    public BitArray IsHallOfFameDismissed { get; set; }
    [Key(3)]
    public int[] SelectedRewards { get; set; }
}
