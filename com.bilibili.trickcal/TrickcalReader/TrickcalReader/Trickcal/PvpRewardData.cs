using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PvpRewardData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int SeasonUid { get; set; }
    [Key(2)]
    public PvpRewardType PvpRewardType { get; set; }
    [Key(3)]
    public int RankStandard { get; set; }
    [Key(4)]
    public int[] RewardItemUid { get; set; }
    [Key(5)]
    public IntOrFloatData[] RewardItemValue { get; set; }
    [Key(6)]
    public GroupType GroupType { get; set; }
}
