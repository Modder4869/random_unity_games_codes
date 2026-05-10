using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class FlatRewardData {
    [Key(0)]
    public int DayIndex { get; set; }
    [Key(1)]
    public RewardData RewardData { get; set; }
}
