using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class EventUnitStatLevelData : TableItem<TableData> {
    [Key(0)]
    public int GroupUid { get; set; }
    [Key(1)]
    public int Level { get; set; }
    [Key(2)]
    public StatType[] StatTypes { get; set; }
    [Key(3)]
    public float[] StatValues { get; set; }
    [Key(4)]
    public int NeedItemUid { get; set; }
    [Key(5)]
    public int NeedItemValue { get; set; }
}
