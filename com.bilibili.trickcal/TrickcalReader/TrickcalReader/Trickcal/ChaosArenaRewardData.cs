using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ChaosArenaRewardData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int ChaosArenaInfoUid { get; set; }
    [Key(2)]
    public GroupType GroupType { get; set; }
    [Key(3)]
    public ChaosArenaRewardType ChaosArenaRewardType { get; set; }
    [Key(4)]
    public int ChaosArenaRewardValue { get; set; }
    [Key(5)]
    public int[] RewardItemUids { get; set; }
    [Key(6)]
    public int[] RewardItemValues { get; set; }
    [Key(7)]
    public string Desc { get; set; }
}
