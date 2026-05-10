using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LevelRewardData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int NeedTotalLevel { get; set; }
    [Key(2)]
    public int[] RewardUids { get; set; }
    [Key(3)]
    public int[] RewardValues { get; set; }
}
