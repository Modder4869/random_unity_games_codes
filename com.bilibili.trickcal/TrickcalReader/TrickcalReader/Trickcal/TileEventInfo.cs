using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TileEventInfo : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int TileGroup { get; set; }
    [Key(2)]
    public int NeedItemUid { get; set; }
    [Key(3)]
    public int NeedItemValue { get; set; }
    [Key(4)]
    public int StepGroup { get; set; }
    [Key(5)]
    public TileEventStepGroupUnlockType StepGroupUnlockType { get; set; }
    [Key(6)]
    public int StepGroupUnlockValue { get; set; }
}
