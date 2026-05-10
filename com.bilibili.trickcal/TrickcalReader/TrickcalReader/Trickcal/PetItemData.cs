using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PetItemData : TableItem<TableData> {
    [Key(0)]
    public TableBaseItemData ItemData { get; set; }
}
