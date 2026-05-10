using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ArcadeSeasonRankRewardData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int SeasonRewardGroup { get; set; }
    [Key(2)]
    public GroupType GroupType { get; set; }
    [Key(3)]
    public RankType RankType { get; set; }
    [Key(4)]
    public int RankStandard { get; set; }
    [Key(5)]
    public RewardType[] RewardType { get; set; }
    [Key(6)]
    public int[] RewardUid { get; set; }
    [Key(7)]
    public int[] RewardValue { get; set; }
}
