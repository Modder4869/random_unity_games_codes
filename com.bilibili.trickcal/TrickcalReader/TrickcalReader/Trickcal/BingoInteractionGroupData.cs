using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class BingoInteractionGroupData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int InteractionGroupUid { get; set; }
    [Key(2)]
    public int Day { get; set; }
    [Key(3)]
    public int Enter { get; set; }
    [Key(4)]
    public int Touch { get; set; }
    [Key(5)]
    public int Pickup { get; set; }
    [Key(6)]
    public int Bingo { get; set; }
    [Key(7)]
    public int Complete { get; set; }
    [Key(8)]
    public int Next { get; set; }
    [Key(9)]
    public float[] UnitPosX { get; set; }
    [Key(10)]
    public float[] UnitPosY { get; set; }
}
