using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LayoutOrderData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int LayoutUid { get; set; }
    [Key(2)]
    public FurnitureCategoryType Category { get; set; }
    [Key(3)]
    public int Order { get; set; }
}
