using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MiniGameEdActiveSkillChangeCostData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int ReRollCount { get; set; }
    [Key(2)]
    public int[] RewardValue { get; set; }
}
