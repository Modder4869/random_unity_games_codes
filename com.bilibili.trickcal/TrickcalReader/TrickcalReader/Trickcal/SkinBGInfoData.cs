using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SkinBGInfoData : TableItem<TableData> {
    [Key(0)]
    public TableBaseItemData ItemData { get; set; }
    [Key(1)]
    public int Sort { get; set; }
    [Key(2)]
    public string Effect { get; set; }
}
