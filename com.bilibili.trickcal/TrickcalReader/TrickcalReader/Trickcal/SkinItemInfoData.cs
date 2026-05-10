using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SkinItemInfoData : TableItem<TableData> {
    [Key(0)]
    public TableBaseItemData ItemData { get; set; }
    [Key(1)]
    public SkinItemType Type { get; set; }
}
