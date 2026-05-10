using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AffinityLevelUpData : TableItem<TableData> {
    [Key(0)]
    public int Level { get; set; }
    [Key(1)]
    public int NeedAffinity { get; set; }
    [Key(2)]
    public string AffinityTitle { get; set; }
    [Key(3)]
    public int RewardUid { get; set; }
    [Key(4)]
    public int RewardValue { get; set; }
    [Key(5)]
    public RewardType RewardType { get; set; }
}
