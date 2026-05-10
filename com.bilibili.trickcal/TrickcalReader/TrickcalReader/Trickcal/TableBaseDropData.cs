using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TableBaseDropData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Group { get; set; }
    [Key(2)]
    public RewardType RewardType { get; set; }
    [Key(3)]
    public int RewardUid { get; set; }
    [Key(4)]
    public int ValueMin { get; set; }
    [Key(5)]
    public int ValueMax { get; set; }
    [Key(6)]
    public int DropRatio { get; set; }
    [Key(7)]
    public DropItemType DropType { get; set; }
}
