using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LayoutGroupData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Group { get; set; }
    [Key(2)]
    public int Floor { get; set; }
    [Key(3)]
    public FurnitureCategoryType Category { get; set; }
    [Key(4)]
    public float PosX { get; set; }
    [Key(5)]
    public float PosY { get; set; }
}
