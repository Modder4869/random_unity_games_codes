using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MaterialInfoData : TableItem<TableData> {
    [Key(0)]
    public TableBaseItemData ItemData { get; set; }
    [Key(1)]
    public string Desc2 { get; set; }
    [Key(2)]
    public string Background { get; set; }
    [Key(3)]
    public string Border { get; set; }
}
